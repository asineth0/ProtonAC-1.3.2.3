"""Generate, compile, and auto-repair the generated bodies.

Any line the C# compiler rejects is replaced by a comment that keeps the raw
text, so the emitted file always compiles while preserving the evidence.
"""
import os, re, glob, shutil, subprocess, collections, sys

FB = r'C:\dev\ProtonRE\work\jit-363\final_bodies'
W = r'C:\dev\ProtonRE\work\jit-363'
CSC = r'C:\Program Files\dotnet\sdk\10.0.403\Roslyn\bincore\csc.dll'
RAW = os.path.join(FB, 'raw')


def run(cmd, **kw):
    r = subprocess.run(cmd, capture_output=True, **kw)
    return r.returncode, (r.stdout + r.stderr).decode('utf-8', 'replace')


def compile_all():
    refs = []
    if os.path.exists(os.path.join(FB, '_compile.rsp')):
        refs = [l.rstrip() for l in open(os.path.join(FB, '_compile.rsp'), encoding='utf-8') if l.startswith('-r:')]
    if not refs:
        raise SystemExit('no refs')
    rsp = os.path.join(FB, '_auto.rsp')
    files = sorted(glob.glob(os.path.join(FB, '[0-9a-f][0-9a-f][0-9a-f][0-9a-f][0-9a-f][0-9a-f][0-9a-f][0-9a-f].cs')))
    with open(rsp, 'w', encoding='utf-8') as f:
        f.write('-target:library\n-out:%s\n-nostdlib+\n-noconfig\n-optimize+\n-unsafe+\n-langversion:latest\n-nologo\n' % os.path.join(FB, '_auto.dll'))
        f.write('-nowarn:CS0168,CS0219,CS0649,CS0169,CS0414,CS0108,CS0114,CS0162,CS1998,CS0067,CS0672,CS0824,CS0809,CS1591,CS0618,CS0252,CS0253,CS0472,CS0660,CS0661,CS0728,CS1717,CS8509,CS8524,CS8632,CS0164\n')
        for l in refs:
            f.write(l + '\n')
        for s in files:
            f.write('"%s"\n' % s)
    rc, out = run(['dotnet', CSC, '@' + rsp])
    return rc, out


def parse_errors(out):
    errs = collections.defaultdict(list)
    for line in out.splitlines():
        m = re.match(r'^([0-9a-f]{8})\.cs\((\d+),(\d+)\): error (CS\d+): (.*)$', line)
        if m:
            errs[m.group(1)].append((int(m.group(2)), m.group(4), m.group(5)))
    return errs


def patch_file(tok, errs, log):
    path = os.path.join(FB, tok + '.cs')
    lines = open(path, encoding='utf-8').read().splitlines()
    changed = False
    sig_bad = False
    for ln, code, msg in errs:
        if ln < 1 or ln > len(lines):
            continue
        text = lines[ln - 1]
        s = text.strip()
        if s.startswith('//'):
            continue
        if 'public unsafe static' in s:
            sig_bad = True
            continue
        changed = True
        log.append((tok, ln, code, s[:120]))
        if s.startswith('return'):
            if code == 'CS8150':
                lines[ln - 1] = '      throw new System.NotSupportedException();'
            else:
                lines[ln - 1] = '      return default;'
        elif s.startswith('var ') or s.startswith('object ') or re.match(r'^[A-Za-z_][\w<>,.\[\]]*\s+\w+\s*=\s*default;', s):
            lines[ln - 1] = '      // [auto-dropped] ' + s
        else:
            lines[ln - 1] = '      // [auto-dropped] ' + s
    if sig_bad:
        # replace whole body with a compilable fallback that keeps the evidence
        head = []
        for l in lines:
            if 'public unsafe static' in l:
                break
            head.append(l)
        head.append('    // signature could not be emitted in a standalone wrapper; original:')
        for l in lines:
            if 'public unsafe static' in l:
                head.append('    // ' + l.strip())
                break
        head.append('    public unsafe static void M%s() {' % tok)
        for l in lines:
            s = l.strip()
            if s.startswith('//'):
                continue
        head.append('      throw new System.NotSupportedException("see raw/%s.cs");' % tok)
        head.append('    }')
        head.append('  }')
        head.append('}')
        open(path, 'w', encoding='utf-8').write('\n'.join(head) + '\n')
        return
    if changed:
        open(path, 'w', encoding='utf-8').write('\n'.join(lines) + '\n')


def main():
    os.makedirs(RAW, exist_ok=True)
    if not os.environ.get('SKIP_GEN'):
        rc, out = run(['python', os.path.join(FB, 'gen.py')], cwd=FB)
        print('gen rc', rc, out.strip().splitlines()[-1] if out.strip() else '')
        for f in glob.glob(os.path.join(FB, '[0-9a-f]' * 8 + '.cs')):
            shutil.copy2(f, os.path.join(RAW, os.path.basename(f)))
    log = []
    for it in range(12):
        rc, out = compile_all()
        errs = parse_errors(out)
        if rc == 0 and not errs:
            print('clean after iteration', it)
            break
        n = sum(len(v) for v in errs.values())
        print('iteration', it, 'rc', rc, 'files', len(errs), 'errors', n)
        if not errs:
            print(out[:2000])
            break
        for tok, es in errs.items():
            patch_file(tok, es, log)
    with open(os.path.join(FB, 'autofix_log.tsv'), 'w', encoding='utf-8') as f:
        f.write('token\tline\tcode\ttext\n')
        for r in log:
            f.write('%s\t%d\t%s\t%s\n' % r)
    print('patched lines', len(log), 'tokens', len({r[0] for r in log}))


if __name__ == '__main__':
    main()
