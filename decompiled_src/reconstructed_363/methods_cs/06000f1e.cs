// ============================================================
// token 0x06000f1e   395E5F59237B4E3F::6712D9D04AD2481C
// native code: 0x28d95a03eb0  (2375 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method assembly hidebysig static
//   string '6712D9D04AD2481C' () cil managed noinlining
//   
// native-calls: 06000f20,06000003,06000007,06000f21,06000f22,06000f23,06000f24,06000f25,06000f26,06000004,06000f1f,06000005,06000f28,06000006,06000f29,06000f2a,06000f27,06000f2b
// native-strings: 0x333c:ProtonAC.Loader,0x18:config.yaml,0x3088:protonac,0x335c:Plugins,0x3368:licenceKey
// ============================================================

static string 6712D9D04AD2481C()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 31 call(s):
    //   0x28d95a03f48  395E5F59237B4E3F::F970B6ED9C744353()
    //   0x28d95a03f78  <Module>::8B9C7B12B1AE4949(0xffffffffc57e73a7)   ; "ProtonAC.Loader"
    //   0x28d95a03fa0  <Module>::3F57E81A62734AC2(0xfffffffff30a757b)   ; "config.yaml"
    //   0x28d95a03fc0  395E5F59237B4E3F::D513B85D8A594E3D(395E5F59237B4E3F::F970B6ED9C744353(), <Module>::8B9C7B12B1AE4949(0xffffffffc57e73a7), <Module>::3F57E81A62734AC2(0xfffffffff30a757b))
    //   0x28d95a04068  395E5F59237B4E3F::00529551FC9B463C(395E5F59237B4E3F::D513B85D8A594E3D(395E5F59237B4E3F::F970B6ED9C744353(), <Module>::8B9C7B12B1AE4949(0xffffffffc57e73a7), <Module>::3F57E81A62734AC2(0xfffffffff30a757b)))
    //   0x28d95a040c8  395E5F59237B4E3F::10B830F8CB504183(395E5F59237B4E3F::D513B85D8A594E3D(395E5F59237B4E3F::F970B6ED9C744353(), <Module>::8B9C7B12B1AE4949(0xffffffffc57e73a7), <Module>::3F57E81A62734AC2(0xfffffffff30a757b)))
    //   0x28d95a040e0  395E5F59237B4E3F::D157BF3665364974()
    //   0x28d95a040f8  395E5F59237B4E3F::43ACAEBC0BA64074(395E5F59237B4E3F::D157BF3665364974(), 395E5F59237B4E3F::10B830F8CB504183(395E5F59237B4E3F::D513B85D8A594E3D(395E5F59237B4E3F::F970B6ED9C744353(), <Module>::8B9C7B12B1AE4949(0xffffffffc5
    //   0x28d95a04110  395E5F59237B4E3F::3CD9AA53F5684245(395E5F59237B4E3F::D157BF3665364974())
    //   0x28d95a041e0  sub_28d95a046d8((u32 (((((((0xc8d228648f204a0c sub (((((movsxd (movsxd 0x2a907a9a)) imul 0x5f7a1795) neg 0x1) neg 0x1) sub 0x8cabcecf492819b)) neg 0x1) add 0xd37315a118ab2be5) imul 0x1d44f417) div 0xf) mod 0xf) shl 0x3))
    //   0x28d95a04200  sub_28b82785f1f((u32 (((((((0xc8d228648f204a0c sub (((((movsxd (movsxd 0x2a907a9a)) imul 0x5f7a1795) neg 0x1) neg 0x1) sub 0x8cabcecf492819b)) neg 0x1) add 0xd37315a118ab2be5) imul 0x1d44f417) div 0xf) mod 0xf) shl 0x3))
    //   0x28d95a04230  <Module>::390073C602714496(0x1816ab0c)   ; "protonac"
    //   0x28d95a04248  395E5F59237B4E3F::DB37E83FE96643F8(r15, <Module>::390073C602714496(0x1816ab0c))
    //   0x28d95a042a8  ToString((? add 0xffffffffffffffa8), <Module>::390073C602714496(0x1816ab0c), <Module>::3F57E81A62734AC2(0xfffffffff30a757b), ?)
    //   0x28d95a042dd  sub_28d95a046d8((? add 0xffffffffffffffa8), <Module>::390073C602714496(0x1816ab0c), <Module>::3F57E81A62734AC2(0xfffffffff30a757b), ?)
    //   0x28d95a04300  sub_28b82785f1f((? add 0xffffffffffffffa8), <Module>::390073C602714496(0x1816ab0c), <Module>::3F57E81A62734AC2(0xfffffffff30a757b), ?)
    //   0x28d95a043a0  <Module>::F84FA79ABE6944BB(0xffffffffdab9dc27)   ; "Plugins"
    //   0x28d95a043b8  395E5F59237B4E3F::DB37E83FE96643F8(0x0, <Module>::F84FA79ABE6944BB(0xffffffffdab9dc27))
    //   0x28d95a043e8  395E5F59237B4E3F::A1631CDB06DD4A89(395E5F59237B4E3F::DB37E83FE96643F8(r15, <Module>::390073C602714496(0x1816ab0c)))
    //   0x28d95a04418  <Module>::58ECCB512F2A43AC(0xffffffff95172543)   ; "licenceKey"
    //   0x28d95a04428  395E5F59237B4E3F::CED97961F77D4E0B(<Module>::58ECCB512F2A43AC(0xffffffff95172543))
    //   0x28d95a04530  395E5F59237B4E3F::847813CCD5A4489F(0x0)
    //   0x28d95a04548  TryParse(395E5F59237B4E3F::847813CCD5A4489F(0x0), (? add 0xffffffffffffffa8), (? add 0xffffffffffffff80), ?)
    //   0x28d95a045a3  sub_28d95a046d8((((((0xc8d228648f204a0c sub (((((movsxd (movsxd 0x2a907a9a)) imul 0x5f7a1795) neg 0x1) neg 0x1) sub 0x8cabcecf492819b)) neg 0x1) add 0xd37315a118ab2be5) imul 0x1d44f417) imul 0x761fdf40), (? add 0xfffffff
    //   0x28d95a045c8  sub_28b82785f1f((((((0xc8d228648f204a0c sub (((((movsxd (movsxd 0x2a907a9a)) imul 0x5f7a1795) neg 0x1) neg 0x1) sub 0x8cabcecf492819b)) neg 0x1) add 0xd37315a118ab2be5) imul 0x1d44f417) imul 0x761fdf40), (? add 0xfffffff
    //   0x28d95a045e0  395E5F59237B4E3F::3CD9AA53F5684245(395E5F59237B4E3F::D157BF3665364974())
    //   0x28d95a04600  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d95a04628  395E5F59237B4E3F::114DCE48BD924962(395E5F59237B4E3F::3CD9AA53F5684245(395E5F59237B4E3F::D157BF3665364974()).f0)
    //   0x28d95a046aa  sub_28d95a046d8(0x28d9349d398, <Module>::390073C602714496(0x7f132d63), (? add 0xffffffffffffff80), ?)
    //   0x28d95a046d0  sub_28b82785f1f(0x28d9349d398, <Module>::390073C602714496(0x7f132d63), (? add 0xffffffffffffff80), ?)
    //   0x28d95a047a8  395E5F59237B4E3F::E9A75BCCD8DE41A4(395E5F59237B4E3F::10B830F8CB504183(395E5F59237B4E3F::D513B85D8A594E3D(395E5F59237B4E3F::F970B6ED9C744353(), <Module>::8B9C7B12B1AE4949(0xffffffffc57e73a7), <Module>::3F57E81A62734AC2(0x
    // returns: 0x0
    // string table refs:
    //   0x333c  "ProtonAC.Loader"
    //   0x18  "config.yaml"
    //   0x3088  "protonac"
    //   0x335c  "Plugins"
    //   0x3368  "licenceKey"
}
