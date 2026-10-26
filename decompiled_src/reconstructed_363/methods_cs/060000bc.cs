// ============================================================
// token 0x060000bc   1DB744298E9F4B09::2470246CB7CF4D5E
// native code: 0x28d957ea440  (1995 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance void '2470246CB7CF4D5E' () cil managed noinlining
//   
// native-calls: 060000fa,060000fb,06000006,060000ff,060000fc,060000fd,06000004,060000fe,060000f8,06000005,06000100,06000101,06000102,06000105,06000104,060000ba,06000003,06000106,06000107
// native-strings: 0x21c:protonac.loader,0x248:Internal-connection-task
// ============================================================

public  void 2470246CB7CF4D5E()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 28 call(s):
    //   0x28d957ea480  1DB744298E9F4B09::602204D3EAB54978()
    //   0x28d957ea490  1DB744298E9F4B09::C1294F0A5D8D438A(1DB744298E9F4B09::602204D3EAB54978())
    //   0x28d957ea4b8  <Module>::58ECCB512F2A43AC((movsxd 0x1505777c))   ; =0
    //   0x28d957ea588  <Module>::58ECCB512F2A43AC(0x71150dd4, (((((((0xe84c6e1df26d2301 sub ((((movsxd 0x44c26ab8) xor 0x66d6c37bad327f28) sub 0x5aac76bb) xor 0x48c79615)) imul 0x2b708579) neg 0x1) xor 0xb99d8cca) neg 0x1) div 0xa) mod 0xa), ?
    //   0x28d957ea5a8  1DB744298E9F4B09::D295963FF71444B7(this.f20, <Module>::58ECCB512F2A43AC(0x71150dd4, (((((((0xe84c6e1df26d2301 sub ((((movsxd 0x44c26ab8) xor 0x66d6c37bad327f28) sub 0x5aac76bb) xor 0x48c79615)) imul 0x2b708579) neg 0x1) 
    //   0x28d957ea5e0  1DB744298E9F4B09::0BDC346A9B654476(1DB744298E9F4B09::C1294F0A5D8D438A(1DB744298E9F4B09::602204D3EAB54978())+(movsxd <Module>::58ECCB512F2A43AC((movsxd 0x1505777c)))*8+20.f0)
    //   0x28d957ea5f0  1DB744298E9F4B09::4CF5126EEB2E4F86(1DB744298E9F4B09::0BDC346A9B654476(1DB744298E9F4B09::C1294F0A5D8D438A(1DB744298E9F4B09::602204D3EAB54978())+(movsxd <Module>::58ECCB512F2A43AC((movsxd 0x1505777c)))*8+20.f0))
    //   0x28d957ea618  <Module>::390073C602714496(0x17ebf971)   ; "protonac.loader"
    //   0x28d957ea638  <Module>::58ECCB512F2A43AC(0xffffffff8a20de15)   ; =5
    //   0x28d957ea658  1DB744298E9F4B09::2BB3781EEB3A40ED(1DB744298E9F4B09::4CF5126EEB2E4F86(1DB744298E9F4B09::0BDC346A9B654476(1DB744298E9F4B09::C1294F0A5D8D438A(1DB744298E9F4B09::602204D3EAB54978())+(movsxd <Module>::58ECCB512F2A43AC((movsxd
    //   0x28d957ea6a0  1DB744298E9F4B09::900528C3C94D4EB9((r13 xor r13), (<Module>::390073C602714496(0x17ebf971) xor <Module>::390073C602714496(0x17ebf971)))
    //   0x28d957ea730  <Module>::F84FA79ABE6944BB(0x67cf2da4)   ; =1
    //   0x28d957ea7a0  1DB744298E9F4B09::292A1432976B4A8A(<Module>::F84FA79ABE6944BB(0x67cf2da4), (<Module>::390073C602714496(0x17ebf971) xor <Module>::390073C602714496(0x17ebf971)), <Module>::58ECCB512F2A43AC(0xffffffff8a20de15), ?)
    //   0x28d957ea7b0  1DB744298E9F4B09::74776E9056D94426(<Module>::F84FA79ABE6944BB(0x67cf2da4), (<Module>::390073C602714496(0x17ebf971) xor <Module>::390073C602714496(0x17ebf971)), <Module>::58ECCB512F2A43AC(0xffffffff8a20de15), ?)
    //   0x28d957ea7c0  1DB744298E9F4B09::302B6840F2674835(1DB744298E9F4B09::74776E9056D94426(<Module>::F84FA79ABE6944BB(0x67cf2da4), (<Module>::390073C602714496(0x17ebf971) xor <Module>::390073C602714496(0x17ebf971)), <Module>::58ECCB512F2A43A
    //   0x28d957ea8e0  1DB744298E9F4B09::134AEE2E797D4022(0x28cca2db660.f0, (((((((0xe84c6e1df26d2301 sub ((((movsxd 0x8bc1b1fe) xor 0x66d6c37bad327f28) sub 0x5aac76bb) xor 0x48c79615)) imul 0x2b708579) neg 0x1) xor 0xb99d8cca) neg 0x1) div 0x
    //   0x28d957ea910  1DB744298E9F4B09::5E70AF3660A442D8(0x28cca2db660.f0, (((((((0xe84c6e1df26d2301 sub ((((movsxd 0x8bc1b1fe) xor 0x66d6c37bad327f28) sub 0x5aac76bb) xor 0x48c79615)) imul 0x2b708579) neg 0x1) xor 0xb99d8cca) neg 0x1) div 0x
    //   0x28d957ea938  1DB744298E9F4B09::72B072476EA64F92(this)
    //   0x28d957ea9a0  <Module>::8B9C7B12B1AE4949((movsxd 0xdae0b64))   ; "Internal-connection-task"
    //   0x28d957ea9d0  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d957eaa00  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), (((((((0xe84c6e1df26d2301 sub ((((movsxd 0x8bc1b1fe) xor 0x66d6c37bad327f28) sub 0x5aac76bb) xor 0x48c79615)) imul 0x2b708579) neg 0x1) xor 0xb99d8cca) neg 0x1) div 0x7) m
    //   0x28d957eaa60  1DB744298E9F4B09::F86B2FD60D0D4000(this)
    //   0x28d957eaad0  ALLOC_OBJECT(0x28cc8341df8)
    //   0x28d957eab00  WBARRIER((ALLOC_OBJECT(0x28cc8341df8) add 0x20), 0x28d94ffdfe8.f20)
    //   0x28d957eab80  1DB744298E9F4B09::8519B7AF8EFB4000(<Module>::8B9C7B12B1AE4949((movsxd 0xdae0b64)), ALLOC_OBJECT(0x28cc8356f60), (? add 0xffffffffffffff98), ALLOC_OBJECT(0x28cc8341df8))
    //   0x28d957eabc8  THROW(0x162, 0xeb)
    //   0x28d957eabe0  THROW(0xf3, 0x131)
    //   0x28d957eac08  THROW(0x146, 0x649)
    // 13 store(s):
    //   0x28d957ea9e6  ALLOC_OBJECT(0x28cc8356f60) <- this
    //   0x28d957eaa1b  ALLOC_OBJECT(0x28cc8356f60) <- 0x28ccda9ab90
    //   0x28d957eaa29  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ffdfe0
    //   0x28d957eaa3b  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ffdfe8.f28
    //   0x28d957eaa43  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ffdfe8.f20
    //   0x28d957eaa47  ALLOC_OBJECT(0x28cc8356f60) <- 0x0
    //   0x28d957eaa88  ((? add 0xffffffffffffff70) add 0x8) <- 1DB744298E9F4B09::F86B2FD60D0D4000(this)
    //   0x28d957eaae6  ALLOC_OBJECT(0x28cc8341df8) <- this
    //   0x28d957eab29  ALLOC_OBJECT(0x28cc8341df8) <- 0x28ccda9ac18
    //   0x28d957eab37  ALLOC_OBJECT(0x28cc8341df8) <- 0x28d94ffe040
    //   0x28d957eab49  ALLOC_OBJECT(0x28cc8341df8) <- 0x28d94ffe048.f28
    //   0x28d957eab51  ALLOC_OBJECT(0x28cc8341df8) <- 0x28d94ffe048.f20
    //   0x28d957eab55  ALLOC_OBJECT(0x28cc8341df8) <- 0x0
    // returns: 1DB744298E9F4B09::8519B7AF8EFB4000(<Module>::8B9C7B12B1AE4949((movsxd 0xdae0b64)), ALLOC_OBJECT(0x28cc8356f60), (? add 0xffffffffffffff98), ALLOC_OBJECT(0x28cc8341df8))
    // string table refs:
    //   0x21c  "protonac.loader"
    //   0x248  "Internal-connection-task"
}
