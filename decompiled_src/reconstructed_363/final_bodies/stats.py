import csv, os, re, collections, json, sys
W = r'C:\dev\ProtonRE\work\jit-363'
FB = os.path.join(W, 'final_bodies')
IDX = list(csv.DictReader(open(os.path.join(FB, 'index.tsv'), encoding='utf-8'), delimiter='\t'))
NEW = [r for r in IDX if r['file'].startswith('final_bodies')]
stat = dict(files=len(NEW), real_stmts=0, files_real=0, files_stub=0,
            static_assign=0, files_static=0, string_lits=0, files_string=0,
            evidence=0, dropped=0)
for r in NEW:
    p = os.path.join(W, r['file'].replace('/', os.sep))
    txt = open(p, encoding='utf-8').read()
    n = 0
    st = 0
    for line in txt.splitlines():
        s = line.strip()
        if not s.endswith(';') or s.startswith('using') or s.startswith('//'):
            continue
        if '= default;' in s or s == 'return default;':
            continue
        n += 1
        if re.match(r'^[A-Za-z_][\w.<>]*\.[A-Za-z_]\w*\s*=', s) and '__this' not in s:
            st += 1
    if n:
        stat['files_real'] += 1
    else:
        stat['files_stub'] += 1
    stat['real_stmts'] += n
    stat['static_assign'] += st
    if st:
        stat['files_static'] += 1
    q = len(re.findall(r'"[^"\n]*"', txt))
    stat['string_lits'] += q
    if q:
        stat['files_string'] += 1
    stat['evidence'] += len(re.findall(r'^\s*// call ', txt, re.M))
    stat['dropped'] += txt.count('[auto-dropped]')
print(stat)
print('style counts', collections.Counter(r['style'] for r in NEW))
print('stub tokens', ' '.join(r['token'] for r in NEW if r['style'] == 'stub-cs'))
print()
print('dispatch-sim:')
for r in NEW:
    if r['style'] == 'dispatch-sim':
        print(' ', r['token'], r['notes'])
