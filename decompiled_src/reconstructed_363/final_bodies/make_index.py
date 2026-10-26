import csv, os, re, glob, json, collections, sys
W = r'C:\dev\ProtonRE\work\jit-363'
FB = os.path.join(W, 'final_bodies')
B = r'C:\dev\ProtonRE\work\dll-build'
STATUS = {r['token']: r for r in csv.DictReader(open(os.path.join(B, 'token_status.tsv'), encoding='utf-8'), delimiter='\t')}
MI = {r['token']: r for r in csv.DictReader(open(os.path.join(W, 'methods_index.tsv'), encoding='utf-8'), delimiter='\t')}
DM = {r['token']: r for r in csv.DictReader(open(os.path.join(W, 'dispatch_map.tsv'), encoding='utf-8'), delimiter='\t')}
SIM = set()
try:
    sys.path.insert(0, W)
    import lift_dispatch as LD
    for t in STATUS:
        if STATUS[t]['final_kind'] in ('stub-nocode', 'stub-compilefail', 'stub-tracefail') and LD.simulate(t):
            SIM.add(t)
except Exception as e:
    print('sim set unavailable', e)
EXACT = {'06000078', '0600007a', '060001bd', '0600130c', '06001857'}

rows = []
for tok in sorted(STATUS):
    st = STATUS[tok]
    mi = MI.get(tok, {})
    kind = st['final_kind']
    path = os.path.join(FB, tok + '.cs')
    style = ''
    status = ''
    conf = ''
    note = ''
    if os.path.exists(path) and kind in ('stub-nocode', 'stub-compilefail', 'stub-tracefail'):
        txt = open(path, encoding='utf-8').read()
        real = 0
        for line in txt.splitlines():
            s = line.strip()
            if not s.endswith(';') or s.startswith('using') or s.startswith('//'):
                continue
            if '= default;' in s or s == 'return default;':
                continue
            real += 1
        dropped = txt.count('[auto-dropped]')
        evidence = len(re.findall(r'^\s*// call ', txt, re.M))
        if tok in EXACT:
            style, status, conf = 'hand-cs', 'recovered-exact', 'high'
        elif tok in SIM:
            style, status, conf = 'dispatch-sim', 'recovered-behavior', 'medium'
            d = DM.get(tok, {})
            note = 'states=%s table=%s' % (d.get('entries', '?'), d.get('table', '?'))
        elif real > 0:
            style, status, conf = 'lifted-cs', 'recovered-behavior', 'medium' if real >= 2 else 'low'
        else:
            style, status, conf = 'stub-cs', 'outline', 'low'
        if note:
            note += '; '
        note += 'stmts=%d dropped=%d evidence=%d' % (real, dropped, evidence)
        file = 'final_bodies/%s.cs' % tok
    elif kind == 'compiled':
        style, status = 'compiled-il', ('recovered-exact' if mi.get('status') == 'exact' else 'recovered-behavior')
        conf = mi.get('confidence', 'high')
        note = 'compiled by dll-build'
        file = 'dll-build/recon'
    elif kind == 'trace-synth':
        style, status, conf = 'trace-synth', 'recovered-behavior', mi.get('confidence', 'medium')
        note = 'trace-synthesized by dll-build'
        file = 'dll-build/recon'
    elif kind == 'custom-cctor-stringtable':
        style, status, conf = kind, 'recovered-exact', 'high'
        note = 'hand-written in dll-build'
        file = 'dll-build/recon'
    elif kind == 'stub-module':
        style, status, conf = kind, 'outline', 'low'
        note = 'module-global stub in dll-build; body recovered in methods_cs'
        file = 'methods_cs/%s.cs' % tok
    elif kind == 'stub-outline':
        style, status, conf = 'outline', 'outline', 'low'
        note = 'structured outline; control flow not lifted'
        file = 'methods_cs/%s.cs' % tok
    else:
        style, status, conf = kind, 'outline', 'low'
        note = 'unhandled kind'
        file = ''
    rows.append(dict(token=tok, type=st['type'] if 'type' in st else '', method=st.get('method', ''),
                     status=status, style=style, confidence=conf, file=file,
                     native_size=mi.get('native_size', ''), notes=note))

with open(os.path.join(FB, 'index.tsv'), 'w', encoding='utf-8', newline='') as f:
    w = csv.DictWriter(f, fieldnames=['token', 'type', 'method', 'status', 'style', 'confidence', 'file', 'native_size', 'notes'], delimiter='\t')
    w.writeheader()
    for r in rows:
        w.writerow(r)
print('rows', len(rows))
print(collections.Counter(r['status'] for r in rows))
print(collections.Counter(r['style'] for r in rows))
print('final_bodies rows', sum(1 for r in rows if r['file'].startswith('final_bodies')))
