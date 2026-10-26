"""Generate compilable C# bodies for the remaining wiped methods.

Reads the recovered trace (analysis_all.json), runtime class map, Cecil layout and
ref2 metadata, and emits a wrapper class per token under final_bodies/.
"""
import json, csv, re, os, sys, collections
W = r'C:\dev\ProtonRE\work\jit-363'
B = r'C:\dev\ProtonRE\work\dll-build'
OUT = W + r'\final_bodies'
sys.path.insert(0, W)
import statics
os.makedirs(OUT, exist_ok=True)

A = json.load(open(W + r'\analysis_all.json'))
T = {r['token']: r for r in csv.DictReader(open(B + r'\tokmeta.tsv', encoding='utf-8'), delimiter='\t')}
REFM = {int(k, 16): v for k, v in json.load(open(W + r'\refmap_methods.json')).items()}
REFT = json.load(open(W + r'\refmap_types.json'))
CM = {int(k, 16): (v[0] if isinstance(v, list) else v) for k, v in json.load(open(W + r'\classmap.json')).items()}
STATUS = {r['token']: r for r in csv.DictReader(open(B + r'\token_status.tsv', encoding='utf-8'), delimiter='\t')}

# layout: (type_token, offset) -> (field, ftype, fstatic)
LAYOUT = {}
LAYOUT_BY_NAME = {}
FTYPE_BY_NAME = {}
for line in open(B + r'\layout.tsv', encoding='utf-8'):
    p = line.rstrip('\n').split('\t')
    if len(p) < 6 or p[0] == 'type':
        continue
    if p[3] != '-':
        try:
            LAYOUT[(p[1], int(p[3], 16))] = (p[2], p[4], p[5])
            LAYOUT_BY_NAME[(p[0], int(p[3], 16))] = (p[2], p[4], p[5])
            FTYPE_BY_NAME.setdefault(p[2], p[4])
        except Exception:
            pass

def tn(t):
    if not t: return 'object'
    t = t.replace('/', '.').replace('+', '.')
    t = t.replace('`1', '').replace('`2', '').replace('`3', '').replace('`4', '')
    return t

def ident(name):
    if not name:
        return 'object'
    if name[0].isdigit():
        return '_' + name
    return name

def san_type(s):
    if not s: return 'object'
    s = s.replace('/', '.').replace('+', '.')
    s = re.sub(r'`\d+', '', s)
    return s

# string-decryptor resolution: (caller token, decryptor token, immediate arg) -> plaintext
DEC = {}
DECNAMES = {}
for _tok, _a in A.items():
    for _d in _a.get('dec_calls') or []:
        _dec = _d.get('dec')
        _arg = _d.get('arg')
        _val = _d.get('value')
        if _dec is None or _arg is None or not isinstance(_val, str):
            continue
        try:
            _aiv = int(_arg, 16) & 0xffffffff
        except Exception:
            continue
        DEC[(int(_tok, 16), _dec & 0xffffffff, _aiv)] = _val
        _r = T.get('%08x' % _dec)
        if _r:
            DECNAMES[_dec & 0xffffffff] = _r['method']
# decryptor token -> method name also comes straight from the call labels
for _a in A.values():
    for _c in _a.get('calls') or []:
        _t = _c.get('token')
        _lbl = _c.get('label') or ''
        if _t and '::' in _lbl and _lbl.startswith('<Module>'):
            DECNAMES[_t & 0xffffffff] = _lbl.split('::', 1)[1]

def params_of(tok):
    return [part.split()[-1].strip("'\"") for part in params_decl(tok)]

def params_decl(tok):
    r = T.get('%08x' % tok) or T.get(tok)
    if not r: return []
    sig = r['sig_cs']
    p = sig.find('(')
    if p < 0: return []
    depth = 0; end = -1
    for i in range(p, len(sig)):
        if sig[i] == '(': depth += 1
        elif sig[i] == ')':
            depth -= 1
            if depth == 0: end = i; break
    if end < 0: return []
    body = sig[p+1:end].strip()
    if not body: return []
    out = []
    for i, part in enumerate(split_top(body)):
        part = part.strip()
        if not part: continue
        # if it has no name, add pN
        toks = part.split()
        if len(toks) == 1:
            part = part + ' p%d' % i
        out.append(part)
    return out

SHORT2FULL = {}
for k in REFT:
    short = k.replace('/', '.').split('.')[-1]
    SHORT2FULL.setdefault(short, k.replace('/', '.'))

def ctype(name):
    if not name: return 'object'
    if name == '<Module>': return '_Module_'
    gm = {
        'System.Collections.Generic.List`1': 'System.Collections.Generic.List<object>',
        'System.Collections.Concurrent.ConcurrentDictionary`2': 'System.Collections.Concurrent.ConcurrentDictionary<object,object>',
        'System.Collections.Generic.Dictionary`2': 'System.Collections.Generic.Dictionary<object,object>',
        'System.Collections.Generic.HashSet`1': 'System.Collections.Generic.HashSet<object>',
        'System.Collections.Generic.IEnumerable`1': 'System.Collections.Generic.IEnumerable<object>',
        'System.Collections.Generic.IList`1': 'System.Collections.Generic.IList<object>',
        'System.Func`1': 'System.Func<object>',
        'System.Func`2': 'System.Func<object,object>',
        'System.Threading.Tasks.Task`1': 'System.Threading.Tasks.Task<object>',
    }
    if name in gm: return gm[name]
    if '`' in name:
        if '<' in name:
            return san_type(name)
        return 'object'
    if name in REFT:
        return name.replace('/', '.')
    if ('T_' + name) in REFT:
        return ('T_' + name).replace('/', '.')
    short = name.replace('/', '.').split('.')[-1]
    if short in SHORT2FULL:
        return SHORT2FULL[short]
    if ('T_' + short) in SHORT2FULL:
        return SHORT2FULL['T_' + short]
    name = name.replace('/', '.')
    if not re.match(r'^[A-Za-z_][A-Za-z0-9_.]*$', name):
        return 'object'
    if name.startswith('System.'):
        return name
    if name.startswith('_Module_.'):
        return name
    return name.replace('/', '.').replace('+', '.')

def field_meta(type_token, off, current_tok):
    m = None
    for key in ((type_token, off), (type_token, off-0x10)):
        if key in LAYOUT:
            m = LAYOUT[key]
            break
    if m is None:
        r = T.get('%08x' % current_tok)
        if r:
            for key in ((r['type'], off), (r['type'], off-0x10)):
                if key in LAYOUT_BY_NAME:
                    m = LAYOUT_BY_NAME[key]
                    break
    if m is None:
        return None
    return (ident(m[0]), m[1], m[2])

def field_name(type_token, off, current_tok):
    m = field_meta(type_token, off, current_tok)
    return m[0] if m else None

def split_top(s, sep=','):
    out=[]; depth=0; cur=''
    for ch in s:
        if ch in '(<[': depth+=1
        elif ch in ')>]': depth=max(0,depth-1)
        if ch==sep and depth==0:
            out.append(cur); cur=''
        else: cur+=ch
    if cur.strip(): out.append(cur)
    return out

def cstr(s):
    return '"' + s.replace('\\', '\\\\').replace('"', '\\"').replace('\n', '\\n').replace('\r', '\\r').replace('\t', '\\t') + '"'

BINOPS = ('add','sub','imul','xor','and','or','shl','shr','sar','mul','div','mod','udiv','urem')

def split_bin(inner):
    """Find the last top-level binary operator in a parenthesised expression body."""
    depth = 0
    hits = []
    i = 0
    n = len(inner)
    while i < n:
        ch = inner[i]
        if ch == '(':
            depth += 1
        elif ch == ')':
            depth -= 1
        elif depth == 0 and ch == ' ':
            for op in BINOPS:
                tok = ' ' + op + ' '
                if inner.startswith(tok, i):
                    hits.append((i, op))
                    break
        i += 1
    if not hits:
        return None
    i, op = hits[-1]
    return inner[:i], op, inner[i + len(op) + 2:]

def valid_expr(s):
    if not s: return True
    if '?' in s or ' xor ' in s or ' shl ' in s or ' add 0x' in s: return False
    if '<Module>' in s or 'default.' in s or '.default' in s or 'object.' in s: return False
    if 'Dictionary<' in s and s.count('<') != s.count('>'): return False
    for a,b in (('(',')'),('[',']'),('{','}'),('<','>')):
        if s.count(a) != s.count(b): return False
    # method/member names starting with a digit
    if re.search(r'[.>]\s*\d', s): return False
    if '..' in s: return False
    return True

class Gen:
    def __init__(self, tok):
        self.tok = tok
        self.r = T['%08x' % tok]
        self.ttype_token = self.r['type_token']
        self.ttype = ctype(self.r['type'])
        self.params = params_of(tok)
        self.stmts = []
        self.decls = []
        self.temps = 0
        self.alloc = {}
        self.alloc_hint = {}
        self.alloc_class = {}
        self.locals = {}
        self.calltext = {}
        self.replacements = []
        self.notes = []
        self.failed = None
        self.static_map = {}
        self.var_types = {}

    def fail(self, why):
        if not self.failed: self.failed = why
        return None

    def tmp(self, prefix='v'):
        self.temps += 1
        return '%s%d' % (prefix, self.temps)

    def local(self, key):
        if key not in self.locals:
            n = self.tmp('s')
            self.locals[key] = n
            self.decls.append('object %s = default;' % n)
        return self.locals[key]

    def base_field(self, base, off, bt=None):
        if bt is None:
            if base == '__this': bt = self.ttype_token
        if bt:
            f = field_name(bt, off, self.tok)
            if f: return '%s.%s' % (base, f)
        return 'default'

    def expr(self, e, depth=0):
        if e is None: return 'default'
        e = e.strip()
        for a, b in self.replacements:
            e = e.replace(a, b)
        if e in ('this',): return '__this'
        if e in ('null', '(this xor this)', '(a0 xor a0)', '(rax xor rax)', '(rdi xor rdi)'):
            return 'null'
        if e in ('(null >> 0)', '(null shl 0)', '(null << 0)'):
            return '0'
        if e in ('?', 'default'): return 'default'
        if re.match(r'^a\d+$', e):
            i = int(e[1:])
            return self.params[i] if i < len(self.params) else 'default'
        if re.match(r'^0x[0-9a-fA-F]+$', e):
            v = int(e, 16)
            if v in self.static_map:
                tn, fn = self.static_map[v]
                return '%s.%s' % (ctype(tn), ident(fn))
            cl = CM.get(v)
            if cl and cl != 'const':
                return 'default'
            if v > 0xffffffff: return 'default'
            if v >= 1 << 63: v -= 1 << 64
            elif v > 0x7fffffff: v -= 1 << 32
            return str(v)
        if re.match(r'^-?\d+$', e): return e
        if e.startswith('S['):
            return self.local(e)
        if e.startswith('static['):
            return 'default'
        # ALLOC
        m = re.match(r'^ALLOC_OBJECT\((0x[0-9a-f]+)\)$', e)
        if m:
            p = int(m.group(1), 16)
            if p in self.alloc: return self.alloc[p]
            name = self.alloc_hint.get(p) or CM.get(p) or 'object'
            nm = ctype(name)
            v = self.tmp('o')
            self.alloc[p] = v
            self.decls.append('%s %s = default;' % (nm, v))
            return v
        m = re.match(r'^ALLOC_ARRAY\((0x[0-9a-f]+),\s*(.+)\)$', e)
        if m:
            p = int(m.group(1), 16); cnt = self.expr(m.group(2), depth+1)
            name = CM.get(p) or 'object[]'
            if not name.endswith('[]'): name = name + '[]'
            v = self.tmp('a')
            self.decls.append('var %s = new %s[%s];' % (v, ctype(name[:-2]), cnt))
            return v
        # this fields
        for pat in (r'^this\.f([0-9a-f]+)$', r'^this\+([0-9a-f]+)$', r'^\(this add 0x([0-9a-f]+)\)$'):
            m = re.match(pat, e)
            if m: return self.base_field('__this', int(m.group(1), 16))
        # base.field / base+off
        m = re.match(r'^(.*)\.f([0-9a-f]+)$', e)
        if m and depth < 3:
            base = self.expr(m.group(1), depth+1)
            return self.base_field(base, int(m.group(2), 16))
        m = re.match(r'^(.*)\+([0-9a-f]+)$', e)
        if m and depth < 3 and not m.group(1).startswith('0x'):
            base = self.expr(m.group(1), depth+1)
            return self.base_field(base, int(m.group(2), 16))
        m = re.match(r'^\((.*) add 0x([0-9a-f]+)\)$', e)
        if m and depth < 3:
            base = self.expr(m.group(1), depth+1)
            return self.base_field(base, int(m.group(2), 16))
        # unary
        m = re.match(r'^\((movsxd|movzx|movsx|u32|neg|not|inc|dec)\s+(.+)\)$', e)
        if m:
            op = m.group(1); a = self.expr(m.group(2), depth+1)
            if op == 'movsxd': return '(int)(%s)' % a
            if op in ('movzx','movsx'): return '(byte)(%s)' % a
            if op == 'u32': return '(uint)(%s)' % a
            if op == 'neg': return '(-%s)' % a
            if op == 'not': return '(~%s)' % a
            if op == 'inc': return '(%s + 1)' % a
            if op == 'dec': return '(%s - 1)' % a
        # binary / nested
        if e.startswith('(') and e.endswith(')'):
            inner = e[1:-1].strip()
            binop = split_bin(inner)
            if binop:
                left, opname, right = binop
                if opname == 'xor' and left.strip() == right.strip():
                    return '0'
                a = self.expr(left, depth+1)
                b = self.expr(right, depth+1)
                if opname == 'xor' and a == b:
                    return '0'
                op = {'add':'+','sub':'-','imul':'*','xor':'^','and':'&','or':'|','shl':'<<','shr':'>>','sar':'>>','mul':'*','div':'/','mod':'%','udiv':'/','urem':'%'}[opname]
                return '(%s %s %s)' % (a, op, b)
        # call
        m = re.match(r'^(.*?)\((.*)\)$', e)
        if m and depth < 3:
            head = m.group(1).strip()
            if head == 'FieldRefAccess' or head.startswith('sub_'):
                return 'default'
            if '::' in head:
                cls, meth = head.split('::', 1)
                meth = meth.strip("'")
                cname = cls.strip("'")
                if cname == 'FieldRefAccess' or meth == 'FieldRefAccess':
                    return 'default'
                if cname in ('<Module>', '_Module_'):
                    raw = m.group(2).strip()
                    try:
                        aiv = int(raw, 16) & 0xffffffff
                    except Exception:
                        aiv = None
                    if aiv is not None:
                        for dtok, dname in DECNAMES.items():
                            if dname == meth and (self.tok, dtok, aiv) in DEC:
                                return cstr(DEC[(self.tok, dtok, aiv)])
                if meth == '.ctor':
                    return 'default'
            args = [self.expr(x, depth+1) for x in split_top(m.group(2))]
            if '::' in head:
                call = '%s.%s(%s)' % (ctype(cls.strip("'")), meth, ', '.join(args))
                return call if valid_expr(call) else 'default'
            call = '%s(%s)' % (head, ', '.join(args))
            return call if valid_expr(call) else 'default'
        return 'default'

    def call_stmt(self, c):
        label = c.get('label') or ''
        args = c.get('args') or []
        tok = c.get('token')
        # helpers
        if label in ('ALLOC_OBJECT','ALLOC_ARRAY','WBARRIER'): return None
        if label == 'THROW':
            self.stmts.append('throw new System.Exception();')
            return 'void'
        if label in ('ALLOC','ALLOC_OBJECT'):
            return None
        # resolve callee
        m = REFM.get(tok) if tok else None
        cls = meth = None; static = None; nparams = None
        if m:
            cls = ctype(m['type']); meth = m['name']; static = m['static']; nparams = m['nparams']
        elif c.get('klass') and c.get('name'):
            cls = ctype(c['klass']); meth = c['name']; static = True
        elif '::' in label:
            cls, meth = label.split('::', 1); cls = ctype(cls.strip("'")); meth = meth.strip("'")
        if not meth:
            return None
        meth = ident(meth)
        dt = tok & 0xffffffff if tok else None
        if dt in DECNAMES:
            arg0 = args[0] if args else ''
            try:
                aiv = int(arg0, 16) & 0xffffffff
            except Exception:
                aiv = None
            if aiv is not None and (self.tok, dt, aiv) in DEC:
                return cstr(DEC[(self.tok, dt, aiv)])
            return None
        if cls in ('_Module_', '<Module>') and meth.startswith('T_'):
            return None
        # constructor
        if meth == '.ctor':
            if args and args[0].strip().startswith('ALLOC_OBJECT('):
                p = int(re.search(r'0x[0-9a-f]+', args[0]).group(0), 16)
                alloc = self.expr(args[0])
                nm = ctype(self.alloc_hint.get(p) or CM.get(p) or 'object')
                if '`' in nm or nm == 'object':
                    return None
                raw = [x for x in args[1:] if x.strip() not in ('?', 'default')]
                a = [self.expr(x) for x in raw]
                stmt='%s = new %s(%s);' % (alloc, nm, ', '.join(a))
                if valid_expr(stmt): self.stmts.append(stmt)
                return 'ctor'
            return None
        # generic helper / decryptor calls cannot be emitted without type args
        if cls in ('_Module_', '<Module>') and meth in ('F84FA79ABE6944BB','8B9C7B12B1AE4949','390073C602714496','58ECCB512F2A43AC','3F57E81A62734AC2'):
            return None
        if not cls or '`' in cls or '<' in cls or '>' in cls:
            return None
        # receiver
        if static is False:
            recv = self.expr(args[0]) if args else '__this'
            rest = args[1:]
        elif static is True:
            recv = cls
            rest = args
        else:
            recv = cls or '__this'
            rest = args[1:] if args and args[0].strip() == 'this' else args
        if recv in ('default','object') or recv.startswith('default') or 'default.' in recv:
            return None
        if nparams is not None and nparams >= 0:
            if len(rest) > nparams: rest = rest[:nparams]
            while len(rest) < nparams: rest.append('?')
        vals = [self.expr(x) for x in rest]
        call = '%s.%s(%s)' % (recv, meth, ', '.join(vals))
        if not valid_expr(call):
            return None
        # decide statement vs expression
        return call

    def merge_events(self, calls, stores, rets):
        ev = [(c['addr'], 'call', c) for c in calls] + [(s['addr'], 'store', s) for s in stores]
        ev.sort()
        return ev

    def store_stmt(self, s):
        target = s['target']
        meta = None
        # resolve the destination field before evaluating the value so ALLOC
        # temporaries can borrow the field's closed generic type.
        tm = re.match(r'^(?:this\.f|this\+|\(this add 0x)([0-9a-f]+)\)?$', target)
        if target == 'this':
            meta = field_meta(self.ttype_token, s.get('off', 0), self.tok)
        elif tm:
            meta = field_meta(self.ttype_token, int(tm.group(1), 16), self.tok)
        am = re.match(r'^ALLOC_OBJECT\((0x[0-9a-f]+)\)$', target)
        value = self.expr(s['value'])
        if not valid_expr(value): value = 'default'
        if meta and meta[1]:
            ft = san_type(meta[1])
            if value.startswith('(int)(') and ft not in ('int', 'System.Int32', 'uint', 'System.UInt32'):
                value = '(' + ft + ')' + value[5:]
        m = re.match(r'^0x([0-9a-f]+)$', target)
        if m:
            addr = int(m.group(1), 16)
            if addr in self.static_map:
                tn, fn = self.static_map[addr]
                self.stmts.append('%s.%s = %s;' % (ctype(tn), ident(fn), value))
            else:
                self.notes.append('static 0x%x = %s' % (addr, value))
            return
        # object field
        m = re.match(r'^ALLOC_OBJECT\((0x[0-9a-f]+)\)$', target)
        if m:
            p = int(m.group(1), 16)
            alloc = self.alloc.get(p)
            if alloc is None:
                nm = ctype(CM.get(p) or 'object')
                alloc = self.tmp('o'); self.alloc[p] = alloc
                self.decls.append('%s %s = default;' % (nm, alloc))
            if s.get('off', 0):
                tt = self.alloc_class.get(p)
                f = field_name(tt, s['off'], self.tok) if tt else None
                if not f:
                    clsname = CM.get(p) or ''
                    f = field_name(None, s['off'], self.tok) if not clsname else None
                if f:
                    self.stmts.append('%s.%s = %s;' % (alloc, f, value))
            return
        m = re.match(r'^ALLOC_OBJECT\((0x[0-9a-f]+)\)\.f([0-9a-f]+)$', target)
        if m:
            alloc = self.expr('ALLOC_OBJECT(%s)' % m.group(1))
            f = field_name(None, int(m.group(2), 16), self.tok)
            if f: self.stmts.append('%s.%s = %s;' % (alloc, f, value))
            return
        # this
        if target == 'this':
            f = field_name(self.ttype_token, s.get('off', 0), self.tok)
            if f:
                self.stmts.append('__this.%s = %s;' % (f, value))
            elif s.get('off'):
                self.notes.append('unresolved this+0x%x = %s' % (s['off'], value))
            return
        for pat in (r'^this\.f([0-9a-f]+)$', r'^this\+([0-9a-f]+)$', r'^\(this add 0x([0-9a-f]+)\)$'):
            m = re.match(pat, target)
            if m:
                f = field_name(self.ttype_token, int(m.group(1), 16), self.tok)
                if f: self.stmts.append('__this.%s = %s;' % (f, value))
                return
        # stack/local
        if target.startswith('(') or target.startswith('S['):
            loc = self.local(target)
            self.stmts.append('%s = %s;' % (loc, value))
            return
        # static
        if target.startswith('static['):
            return

    def run(self):
        d = A['%08x' % self.tok]
        calls = d.get('calls') or []
        stores = d.get('stores') or []
        rets = d.get('rets') or []
        # precompute call texts
        for c in calls:
            c['_text'] = '%s(%s)' % (c.get('label') or '', ', '.join(c.get('args') or []))
        later = []
        for c in calls:
            later.append(' '.join(c.get('args') or []))
        for s in stores: later.append(s.get('value') or '')
        for r in rets: later.append(r or '')
        # pre-scan: static field addresses of the declaring class
        saddr = []
        for s in stores:
            t = s.get('target') or ''
            if re.match(r'^0x[0-9a-f]+$', t):
                saddr.append(int(t, 16))
        self.static_map = statics.resolve(self.tok, saddr)
        # static fields also carry their type via the Cecil layout
        for s in stores:
            vm = re.match(r'^ALLOC_OBJECT\((0x[0-9a-f]+)\)$', s.get('value') or '')
            if not vm:
                continue
            tgt = s.get('target') or ''
            if re.match(r'^0x[0-9a-f]+$', tgt):
                ent = self.static_map.get(int(tgt, 16))
                if ent:
                    ft = FTYPE_BY_NAME.get(ent[1])
                    if ft:
                        self.alloc_hint[int(vm.group(1), 16)] = ft
        alloc_offs = {}
        for s in stores:
            vm = re.match(r'^ALLOC_OBJECT\((0x[0-9a-f]+)\)$', s.get('target') or '')
            if vm and s.get('off'):
                alloc_offs.setdefault(int(vm.group(1), 16), set()).add(s['off'])
        for p, offs in alloc_offs.items():
            hits = sum(1 for off in offs if field_meta(self.ttype_token, off, self.tok))
            if hits >= 2:
                self.alloc_hint[p] = self.ttype
                self.alloc_class[p] = self.ttype_token
        for s in stores:
            vm = re.match(r'^ALLOC_OBJECT\((0x[0-9a-f]+)\)$', s.get('value') or '')
            if not vm:
                continue
            p = int(vm.group(1), 16)
            tgt = s.get('target') or ''
            mm = re.match(r'^this[.+](?:f)?(?:\(this add 0x)?([0-9a-f]+)\)?$', tgt)
            off = s.get('off', 0) if tgt == 'this' else (int(mm.group(1), 16) if mm else None)
            if off is None:
                continue
            meta = field_meta(self.ttype_token, off, self.tok)
            if meta and meta[1]:
                self.alloc_hint[p] = meta[1]
        # emit sorted events
        ev = self.merge_events(calls, stores, rets)
        for addr, kind, obj in ev:
            if kind == 'call':
                c = obj
                call = self.call_stmt(c)
                if call in (None, 'ctor', 'void'):
                    if call is None and c.get('label') not in ('ALLOC_OBJECT','ALLOC_ARRAY','ALLOC','WBARRIER'):
                        self.notes.append('call %s(%s)' % (c.get('label') or '', ', '.join(c.get('args') or [])))
                        self.replacements.append((c['_text'], 'default'))
                    continue
                # is it used later?
                used = any(c['_text'] in x for x in later)
                if call.startswith('"') and not used:
                    continue
                if used:
                    v = self.tmp()
                    self.decls.append('var %s = %s;' % (v, call))
                    self.replacements.append((c['_text'], v))
                else:
                    self.stmts.append(call + ';')
            else:
                self.store_stmt(obj)
        # return
        rtype = self.r.get('ret') or 'void'
        if rtype != 'void':
            if rets:
                r = self.expr(rets[0])
                if r == 'default' or 'default' in r or re.search(r'\ba\d+\b', r) or r.count('(') != r.count(')'):
                    r = 'default'
                if san_type(rtype) in ('bool', 'System.Boolean') and r in ('0', '1'):
                    r = 'false' if r == '0' else 'true'
                if r == 'default': self.stmts.append('return default;')
                else: self.stmts.append('return %s;' % r)
            else:
                self.stmts.append('return default;')
        return None

    def emit(self):
        d = A['%08x' % self.tok]
        self.run()
        if self.failed:
            return None
        # wrapper
        l = []
        l.append('using System;')
        l.append('using System.IO;')
        l.append('using System.Collections.Generic;')
        l.append('using System.Threading;')
        l.append('using System.Threading.Tasks;')
        l.append('using System.Runtime.CompilerServices;')
        l.append('namespace FinalBodies {')
        l.append('  public static class H_%08x {' % self.tok)
        sigparams = [san_type(x) for x in params_decl(self.tok)]
        if self.r.get('static') == '0':
            sigparams = ['ref %s __this' % self.ttype] + sigparams
        ret = san_type(self.r.get('ret') or 'void')
        l.append('    public unsafe static %s M%08x(%s) {' % (ret, self.tok, ', '.join(sigparams)))
        for x in self.decls: l.append('      ' + x)
        for x in self.stmts: l.append('      ' + x)
        for x in self.notes: l.append('      // ' + x)
        l.append('    }')
        l.append('  }')
        l.append('}')
        return '\n'.join(l)

if __name__ == '__main__':
    import collections
    MANUAL = {
        '060001bd': '''using System;
namespace FinalBodies {
  public static class H_060001bd {
    public unsafe static bool M060001bd() {
      // Native reads the module-level static int32 at 0x28cc768cd90 and returns (value != 3).
      // The address is a dump-time address; the check itself is exact.
      return *(int*)(void*)0x28cc768cd90 != 3;
    }
  }
}
''',
        '06000078': '''using System;
namespace FinalBodies {
  // compat shim: Roslyn hides System.Runtime.CompilerServices.Nullable* types in source
  public sealed class NullableAttributeXCompat { public byte[] NullableFlags; }
  public static class H_06000078 {
    public unsafe static void M06000078(ref NullableAttributeXCompat __this, byte p0) {
      __this.NullableFlags = new byte[] { p0 };
    }
  }
}
''',
        '0600007a': '''using System;
namespace FinalBodies {
  public sealed class NullableContextAttributeXCompat { public byte Flag; }
  public static class H_0600007a {
    public unsafe static void M0600007a(ref NullableContextAttributeXCompat __this, byte p0) {
      __this.Flag = p0;
    }
  }
}
''',
        '0600130c': '''using System;
namespace FinalBodies {
  public static class H_0600130c {
    // BCL calli: rcx=p0, rdx=p1, r8=p2, r9=p3, [rsp+0x20]=p4, [rsp+0x28]=p5
    public unsafe static int M0600130c(object p0, byte[] p1, int p2, int p3, byte[] p4, int p5) {
      return ((System.Security.Cryptography.HashAlgorithm)p0).TransformBlock(p1, p2, p3, p4, p5);
    }
  }
}
''',
        '06001857': '''using System;
namespace FinalBodies {
  public static class H_06001857 {
    // static Dictionary<T_59751E20330E4047, Dictionary<int, Func<T_652C34B1E6554F10>>>
    public unsafe static T_652C34B1E6554F10 M06001857(T_59751E20330E4047 p0, int p1) {
      return FE504B49A4DA4B00.CA298A97966E4D4A[p0][p1]();
    }
  }
}
''',
    }
    rows = []
    for tok, r in sorted(STATUS.items(), key=lambda kv: kv[0]):
        if r['final_kind'] not in ('stub-nocode','stub-compilefail','stub-tracefail'):
            continue
        g = Gen(int(tok, 16))
        txt = g.emit()
        if txt is None:
            rows.append((tok,'fail',g.failed or '?',''))
            continue
        open(os.path.join(OUT, tok + '.cs'), 'w', encoding='utf-8').write(txt)
        rows.append((tok,'ok',len(g.stmts),len(g.decls)))
    for tok, txt in MANUAL.items():
        open(os.path.join(OUT, tok + '.cs'), 'w', encoding='utf-8').write(txt)
    with open(os.path.join(OUT,'gen_log.tsv'),'w',encoding='utf-8') as f:
        for r in rows: f.write('\t'.join(str(x) for x in r)+'\n')
    print('generated', sum(1 for r in rows if r[1]=='ok'), 'failed', sum(1 for r in rows if r[1]=='fail'))
    print(collections.Counter(r[2] for r in rows if r[1]=='fail').most_common(10))
