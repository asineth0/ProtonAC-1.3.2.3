// ============================================================
// token 0x06000202   EE0FD11A7E47463C::.ctor
// native code: 0x28d97033f90  (601 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 06001086,0600020b
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 14 call(s):
    //   0x28d97033fc8  ALLOC_OBJECT(0x28d961ff3d8)
    //   0x28d97033fe0  .ctor(ALLOC_OBJECT(0x28d961ff3d8), ?, ?, ?)
    //   0x28d97034000  WBARRIER(this+10, ?)
    //   0x28d97034020  ALLOC_OBJECT(0x28d961ff628)
    //   0x28d97034038  .ctor(ALLOC_OBJECT(0x28d961ff628), ?, ?, ?)
    //   0x28d97034058  WBARRIER(this+18, ?)
    //   0x28d97034078  ALLOC_OBJECT(0x28cc77c7210)
    //   0x28d97034090  .ctor(ALLOC_OBJECT(0x28cc77c7210), ?, ?, ?)
    //   0x28d970340b0  WBARRIER(this+20, ?)
    //   0x28d970340d0  ALLOC_OBJECT(0x28d961ff7f0)
    //   0x28d970340e8  .ctor(ALLOC_OBJECT(0x28d961ff7f0), ?, ?, ?)
    //   0x28d97034108  WBARRIER(this+30, ?)
    //   0x28d97034120  C179263454B44BF6::.ctor(this)
    //   0x28d970341b8  EE0FD11A7E47463C::E2873669CEEA43CF(this)
    // 4 store(s):
    //   0x28d97033fef  this+10 <- ALLOC_OBJECT(0x28d961ff3d8)
    //   0x28d97034047  this+18 <- ALLOC_OBJECT(0x28d961ff628)
    //   0x28d9703409f  this+20 <- ALLOC_OBJECT(0x28cc77c7210)
    //   0x28d970340f7  this+30 <- ALLOC_OBJECT(0x28d961ff7f0)
    // returns: (((((0x75fc55fe sub ((((0xffffffffeb5167b6 imul 0x793c6657) sub 0x2ba008c4) sub 0xea42be87aef596c1) neg 0x1)) sub 0xc6ff3506) not 0x1) xor 0x407134aa) imul 0xcd734c32)
}
