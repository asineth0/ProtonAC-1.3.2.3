import os, glob, collections, json, csv, re
FB = r'C:\dev\ProtonRE\work\jit-363\final_bodies'
W = r'C:\dev\ProtonRE\work\jit-363'
B = r'C:\dev\ProtonRE\work\dll-build'
A = json.load(open(os.path.join(W, 'analysis_all.json')))
STATUS = {r['token']: r for r in csv.DictReader(open(os.path.join(B, 'token_status.tsv'), encoding='utf-8'), delimiter='\t')}
rows = []
for f in sorted(glob.glob(os.path.join(FB, '[0-9a-f]' * 8 + '.cs'))):
    tok = os.path.basename(f)[:8]
    txt = open(f, encoding='utf-8').read()
    body = txt.split('{', 1)[1] if '{' in txt else txt
    stmts = [l.strip() for l in txt.splitlines() if l.strip().endswith(';') and not l.strip().startswith('using')]
    nreal = 0
    ndefault = 0
    for l in txt.splitlines():
        s = l.strip()
        if not s.endswith(';'): continue
        if s.startswith('using'): continue
        if '= default;' in s or 'return default;' in s:
            ndefault += 1
        elif s.startswith('//'):
            continue
        else:
            nreal += 1
    rows.append((tok, STATUS[tok]['final_kind'], A[tok]['kind'], len(A[tok]['calls']), nreal, ndefault, os.path.getsize(f)))
print('files', len(rows))
print('real stmt count distribution:', collections.Counter(r[4] for r in rows).most_common(12))
for lo, hi in [(0, 0), (1, 1), (2, 2), (3, 5), (6, 10), (11, 999)]:
    sel = [r for r in rows if lo <= r[4] <= hi]
    print('real %d-%d: %d  kinds=%s' % (lo, hi, len(sel), collections.Counter(r[2] for r in sel).most_common(5)))
print()
print('tokens with 0 real stmts:', ' '.join(r[0] for r in rows if r[4] == 0))
