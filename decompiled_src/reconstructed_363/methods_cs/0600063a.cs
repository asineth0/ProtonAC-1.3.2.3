// ============================================================
// token 0x0600063a   BE3140E5E8934376::5809A23B8CB5419E
// native code: 0x28d970c5c50  (713 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '5809A23B8CB5419E' () cil managed
//   
// native-calls: 06000643,06000644,06000645
// native-strings: 
// ============================================================

public  void 5809A23B8CB5419E()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 11 call(s):
    //   0x28d970c5ca0  ALLOC_OBJECT(0x28d96634658)
    //   0x28d970c5cc8  WBARRIER((ALLOC_OBJECT(0x28d96634658) add 0x20), ?)
    //   0x28d970c5d18  BE3140E5E8934376::A4E09B54247E4955(0x28c840e8468.f0, ALLOC_OBJECT(0x28d96634658))
    //   0x28d970c5d68  WBARRIER(0x28c840e8468, ALLOC_OBJECT(0x28d96634658))
    //   0x28d970c5e00  ALLOC_OBJECT(0x28d96634818)
    //   0x28d970c5e28  WBARRIER((ALLOC_OBJECT(0x28d96634818) add 0x20), (((((((((0x255513e6 sub (0x6c2afc57 xor 0x4231715398a958ac)) not 0x1) xor 0x111ec2b4) neg 0x1) xor 0x92d44fad) neg 0x1) imul 0x7f3a97f9) div 0x3) mod 0x3))
    //   0x28d970c5e78  BE3140E5E8934376::FFA7D0C836974FE8(ALLOC_OBJECT(0x28d96634818))
    //   0x28d970c5ea0  BE3140E5E8934376::BB782E479FC44A40(this)
    //   0x28d970c5ed8  THROW(0x162, 0xd2)
    //   0x28d970c5ef0  THROW(0xf3, 0x10f)
    //   0x28d970c5f08  THROW(0x14b, 0x1d1)
    // 13 store(s):
    //   0x28d970c5caf  ALLOC_OBJECT(0x28d96634658) <- this
    //   0x28d970c5cdd  ALLOC_OBJECT(0x28d96634658) <- 0x28d96832d70
    //   0x28d970c5ceb  ALLOC_OBJECT(0x28d96634658) <- 0x28d96634720
    //   0x28d970c5cfd  ALLOC_OBJECT(0x28d96634658) <- 0x28d96634728.f28
    //   0x28d970c5d05  ALLOC_OBJECT(0x28d96634658) <- 0x28d96634728.f20
    //   0x28d970c5d09  ALLOC_OBJECT(0x28d96634658) <- 0x0
    //   0x28d970c5d4d  0x28c840e8468 <- BE3140E5E8934376::A4E09B54247E4955(0x28c840e8468.f0, ALLOC_OBJECT(0x28d96634658))
    //   0x28d970c5e0f  ALLOC_OBJECT(0x28d96634818) <- this
    //   0x28d970c5e39  ALLOC_OBJECT(0x28d96634818) <- 0x28d96832f98
    //   0x28d970c5e47  ALLOC_OBJECT(0x28d96634818) <- 0x28d966348e0
    //   0x28d970c5e59  ALLOC_OBJECT(0x28d96634818) <- 0x28d966348e8.f28
    //   0x28d970c5e61  ALLOC_OBJECT(0x28d96634818) <- 0x28d966348e8.f20
    //   0x28d970c5e65  ALLOC_OBJECT(0x28d96634818) <- 0x0
    // returns: BE3140E5E8934376::BB782E479FC44A40(this)
}
