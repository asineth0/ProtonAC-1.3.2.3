import os, re, subprocess, glob, collections, sys
B=r'C:\dev\ProtonRE\work\dll-build'
FB=r'C:\dev\ProtonRE\work\jit-363\final_bodies'
SDK=r'C:\Program Files\dotnet\sdk\10.0.403'
CSC=os.path.join(SDK,'Roslyn','bincore','csc.dll')
# base flags/refs from recon.rsp
lines=open(B+r'\recon.rsp',encoding='utf-8').read().splitlines()
head=[]; src=[]
for l in lines:
    if l.startswith('"') and l.lower().endswith('.cs"'):
        src.append(l)
    else:
        head.append(l)
# replace output and remove source list
head=[l for l in head if not l.startswith('-out:')]
rsp=os.path.join(FB,'_compile.rsp')
files=sorted(glob.glob(os.path.join(FB,'*.cs')))
with open(rsp,'w',encoding='utf-8') as f:
    f.write('-target:library\n-out:%s\n'%os.path.join(FB,'_final.dll'))
    for l in head:
        if l.startswith('-target:'): continue
        f.write(l+'\n')
    for s in files: f.write('"%s"\n'%s)
r=subprocess.run(['dotnet',CSC,'@'+rsp],capture_output=True)
txt=r.stdout.decode('utf-8','replace')+r.stderr.decode('utf-8','replace')
open(os.path.join(FB,'_csc.log'),'w',encoding='utf-8').write(txt)
errs=[l for l in txt.splitlines() if ': error ' in l]
print('rc',r.returncode,'errors',len(errs),'files',len(set(re.findall(r'([0-9a-f]{8})\.cs',' '.join(errs)))))
print(collections.Counter(re.findall(r'error (CS\d+)',txt)).most_common(12))
for l in errs[:15]: print(l)
