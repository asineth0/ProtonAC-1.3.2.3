"""Emit real while/switch state machines for simulated flattened dispatchers."""
import json, os, re, sys, csv, collections
sys.path.insert(0, r'C:\dev\ProtonRE\work\jit-363')
sys.path.insert(0, r'C:\dev\ProtonRE\work\jit-363\final_bodies')
import gen
import lift_dispatch as LD

W = r'C:\dev\ProtonRE\work\jit-363'
FB = os.path.join(W, 'final_bodies')
B = r'C:\dev\ProtonRE\work\dll-build'
STATUS = {r['token']: r for r in csv.DictReader(open(os.path.join(B, 'token_status.tsv'), encoding='utf-8'), delimiter='\t')}
A = gen.A


def render_events(g, calls, stores, later):
    for c in calls:
        c['_text'] = '%s(%s)' % (c.get('label') or '', ', '.join(c.get('args') or []))
    ev = [(c['addr'], 'call', c) for c in calls] + [(s['addr'], 'store', s) for s in stores]
    ev.sort()
    out = []
    for addr, kind, obj in ev:
        n0 = len(g.stmts)
        if kind == 'call':
            c = obj
            call = g.call_stmt(c)
            if call in (None, 'ctor', 'void'):
                if call is None and c.get('label') not in ('ALLOC_OBJECT', 'ALLOC_ARRAY', 'ALLOC', 'WBARRIER'):
                    g.replacements.append((c['_text'], 'default'))
                continue
            used = any(c['_text'] in x for x in later)
            if call.startswith('"') and not used:
                continue
            if used:
                v = g.tmp()
                g.decls.append('var %s = %s;' % (v, call))
                g.replacements.append((c['_text'], v))
            else:
                g.stmts.append(call + ';')
        else:
            g.store_stmt(obj)
        out.extend(g.stmts[n0:])
        del g.stmts[n0:]
    return out


def build(tok):
    s = LD.simulate(tok)
    if not s:
        return None
    g = gen.Gen(int(tok, 16))
    d = A[tok]
    calls = d.get('calls') or []
    stores = d.get('stores') or []
    # reuse Gen's pre-scans by running it once, then reset output state
    g.run()
    g.stmts = []
    g.decls = []
    g.locals = {}
    g.replacements = []
    g.alloc = {}
    # static/alloc hints are now populated
    later = []
    for c in calls:
        later.append(' '.join(c.get('args') or []))
    for st in stores:
        later.append(st.get('value') or '')
    blocks = {}
    base = LD.J[hex(int(tok, 16))]['code']
    for idx in sorted(s['graph']):
        target = s['graph'][idx]['addr']
        nxt = min([t for t in set(s['targets']) if t > target], default=base + s['size'])
        bcalls = [c for c in calls if target <= c['addr'] < nxt]
        bstores = [st for st in stores if target <= st['addr'] < nxt]
        blocks[idx] = render_events(g, bcalls, bstores, later)
    # body
    body = []
    body.append('      uint __state = %d;' % s['order'][0])
    body.append('      while (true) {')
    body.append('        switch (__state) {')
    for idx in sorted(blocks):
        e = s['graph'][idx]
        body.append('          case %d: // native state S%d @0x%x' % (idx, idx, e['addr']))
        for line in blocks[idx]:
            body.append('            ' + line)
        if e['terminal']:
            rt = gen.san_type(g.r.get('ret') or 'void')
            if rt == 'void':
                body.append('            return;')
            else:
                rv = g.expr((d.get('rets') or ['default'])[0])
                if not gen.valid_expr(rv) or 'default' in rv:
                    rv = 'default'
                body.append('            return %s;' % rv)
        else:
            body.append('            __state = %d; break;' % e['next_idx'])
    body.append('          default: return;')
    body.append('        }')
    body.append('      }')
    # declarations emitted before the machine
    head = list(g.decls)
    return head, body


def emit(tok):
    res = build(tok)
    if not res:
        return None
    decls, body = res
    g = gen.Gen(int(tok, 16))
    r = g.r
    sigparams = [gen.san_type(x) for x in gen.params_decl(int(tok, 16))]
    if r.get('static') == '0':
        sigparams = ['ref %s __this' % g.ttype] + sigparams
    ret = gen.san_type(r.get('ret') or 'void')
    if ret.startswith('ref '):
        return None
    L = ['using System;', 'using System.IO;', 'using System.Collections.Generic;',
         'using System.Threading;', 'using System.Threading.Tasks;',
         'using System.Runtime.CompilerServices;', 'namespace FinalBodies {',
         '  public static class H_%s {' % tok,
         '    public unsafe static %s M%s(%s) {' % (ret, tok, ', '.join(sigparams))]
    for x in decls:
        L.append('      ' + x)
    L.extend(body)
    if ret != 'void' and not body[-2].strip().startswith('return'):
        pass
    L.append('    }')
    L.append('  }')
    L.append('}')
    return '\n'.join(L)


if __name__ == '__main__':
    ok = []
    for tok, a in sorted(A.items()):
        if a['kind'] != 'DISPATCH':
            continue
        if STATUS[tok]['final_kind'] not in ('stub-nocode', 'stub-compilefail', 'stub-tracefail'):
            continue
        txt = emit(tok)
        if not txt:
            continue
        open(os.path.join(FB, tok + '.cs'), 'w', encoding='utf-8').write(txt)
        ok.append(tok)
    print('dispatch bodies', len(ok), ' '.join(ok))
