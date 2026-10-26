"""Check emitted bodies against the recovered native call edges."""
import csv, os, re, json, collections, sys
W = r'C:\dev\ProtonRE\work\jit-363'
FB = os.path.join(W, 'final_bodies')
A = json.load(open(os.path.join(W, 'analysis_all.json')))
IDX = [r for r in csv.DictReader(open(os.path.join(FB, 'index.tsv'), encoding='utf-8'), delimiter='\t')
       if r['file'].startswith('final_bodies')]
GENERIC = {'F84FA79ABE6944BB', '8B9C7B12B1AE4949', '390073C602714496', '58ECCB512F2A43AC',
           '3F57E81A62734AC2', '272A6D0FCC934A06'}
rows = []
tot = collections.Counter()
for r in IDX:
    tok = r['token']
    txt = open(os.path.join(W, r['file'].replace('/', os.sep)), encoding='utf-8').read()
    emitted = set()
    for m in re.finditer(r'([A-Za-z_][\w.<>]*|[A-Za-z_]\w*)\.([A-Za-z_]\w*)\s*\(', txt):
        meth = m.group(2)
        if meth in ('Read',) or meth == 'Exception':
            continue
        emitted.add(meth)
    for m in re.finditer(r'\bnew\s+[A-Za-z_][\w.<>]*\s*\(', txt):
        pass
    emitted = {re.sub(r'^T_', '', re.sub(r'<.*$', '', e)) for e in emitted}
    native = set()
    for c in (A[tok].get('calls') or []):
        lbl = c.get('label') or ''
        name = re.sub(r'^T_', '', lbl.split('::')[-1])
        if name and name not in ('ALLOC_OBJECT', 'ALLOC_ARRAY', 'WBARRIER', 'THROW', 'ALLOC', '?'):
            native.add(name)
    # strip generic suffixes from emitted
    unmatched = sorted(e for e in emitted if e not in native and e not in GENERIC)
    missing = sorted(n for n in native if n not in emitted and n not in GENERIC)
    tot['native'] += len(native)
    tot['emitted_unique'] += len(emitted)
    tot['unmatched_emitted'] += len(unmatched)
    tot['missing_unique'] += len(missing)
    if unmatched:
        tot['files_unmatched'] += 1
    rows.append((tok, r['style'], len(native), len(emitted), ';'.join(unmatched), ';'.join(missing)))
with open(os.path.join(FB, 'validation.tsv'), 'w', encoding='utf-8') as f:
    f.write('token\tstyle\tnative_unique\temitted_unique\tunmatched_emitted\tmissing_unique\n')
    for row in rows:
        f.write('\t'.join(str(x) for x in row) + '\n')
print(dict(tot))
print('unmatched emitted (first 12):')
for r in rows:
    if r[4]:
        print(' ', r[0], r[4])
print('files with no emitted calls:', sum(1 for r in rows if r[3] == 0))
