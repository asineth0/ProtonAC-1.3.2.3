// ============================================================
// token 0x0600073a   C513333D2D3A4C12::43AF415ACE1B4273
// native code: 0x28d9722d520  (971 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '43AF415ACE1B4273' () cil managed noinlining
//   
// native-calls: 06001056,06000004,06000006,06000760,06000005,06000007,06000003
// native-strings: 0x1b40:Settings:MitigateInteractThroughWalls,0x1b6c:Detections:InteractDistance:{0}:Enabled,0x1b98:Detections:InteractDistance:{0}:Mitigate
// ============================================================

public  void 43AF415ACE1B4273()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 19 call(s):
    //   0x28d9722d560  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d588  <Module>::390073C602714496(0x2298188e)   ; "Settings:MitigateInteractThroughWalls"
    //   0x28d9722d5a8  <Module>::58ECCB512F2A43AC((movsxd 0x1505777c))   ; =0
    //   0x28d9722d5c0  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0x2298188e), <Module>::58ECCB512F2A43AC((movsxd 0x1505777c)), ?)
    //   0x28d9722d680  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d6b0  <Module>::58ECCB512F2A43AC((movsxd 0x322ddf02))   ; "Detections:InteractDistance:{0}:Enabled"
    //   0x28d9722d6d8  ALLOC_OBJECT(0x28d96167478)
    //   0x28d9722d6f8  C513333D2D3A4C12::5C94013EC2C34067(<Module>::58ECCB512F2A43AC((movsxd 0x322ddf02)), ALLOC_OBJECT(0x28d96167478))
    //   0x28d9722d718  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515))   ; =0
    //   0x28d9722d730  GetValue(760EF57D5259421C::02D998059BCD47E8(), C513333D2D3A4C12::5C94013EC2C34067(<Module>::58ECCB512F2A43AC((movsxd 0x322ddf02)), ALLOC_OBJECT(0x28d96167478)), <Module>::F84FA79ABE6944BB((movsxd 0x535d8515)), ?)
    //   0x28d9722d760  <Module>::3F57E81A62734AC2(0xffffffff94857146)   ; =0
    //   0x28d9722d780  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d7b0  <Module>::8B9C7B12B1AE4949((movsxd 0x5d40cf38))   ; "Detections:InteractDistance:{0}:Mitigate"
    //   0x28d9722d7d8  ALLOC_OBJECT(0x28d96167478)
    //   0x28d9722d7f8  C513333D2D3A4C12::5C94013EC2C34067(<Module>::8B9C7B12B1AE4949((movsxd 0x5d40cf38)), ALLOC_OBJECT(0x28d96167478))
    //   0x28d9722d818  <Module>::58ECCB512F2A43AC((movsxd 0x1505777c))   ; =0
    //   0x28d9722d830  GetValue(760EF57D5259421C::02D998059BCD47E8(), C513333D2D3A4C12::5C94013EC2C34067(<Module>::8B9C7B12B1AE4949((movsxd 0x5d40cf38)), ALLOC_OBJECT(0x28d96167478)), <Module>::58ECCB512F2A43AC((movsxd 0x1505777c)), ?)
    //   0x28d9722d850  <Module>::3F57E81A62734AC2(0x3ca2d4c7)   ; =1
    //   0x28d9722d8e8  THROW(0x146, 0x28d)
    // 5 store(s):
    //   0x28d9722d5d0  0x28b826c0e28 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0x2298188e), <Module>::58ECCB512F2A43AC((movsxd 0x1505777c)), ?)
    //   0x28d9722d6e6  ALLOC_OBJECT(0x28d96167478) <- (movsxd 0x0+(movsxd (rdi xor rdi))*8+20.f0.f10)
    //   0x28d9722d733  0x0+(movsxd (rdi xor rdi))*8+20.f0 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), C513333D2D3A4C12::5C94013EC2C34067(<Module>::58ECCB512F2A43AC((movsxd 0x322ddf02)), ALLOC_OBJECT(0x28d96167478)),
    //   0x28d9722d7e6  ALLOC_OBJECT(0x28d96167478) <- (movsxd 0x0+(movsxd (rdi xor rdi))*8+20.f0.f10)
    //   0x28d9722d833  0x0+(movsxd (rdi xor rdi))*8+20.f0 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), C513333D2D3A4C12::5C94013EC2C34067(<Module>::8B9C7B12B1AE4949((movsxd 0x5d40cf38)), ALLOC_OBJECT(0x28d96167478)),
    // returns: (movsxd 0x28ccac60f30.f18)
    // string table refs:
    //   0x1b40  "Settings:MitigateInteractThroughWalls"
    //   0x1b6c  "Detections:InteractDistance:{0}:Enabled"
    //   0x1b98  "Detections:InteractDistance:{0}:Mitigate"
}
