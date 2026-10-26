// ============================================================
// token 0x0600071a   1E4F78B0A13B4D5D::0755DF65C6134580
// native code: 0x28d970dd920  (417 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '0755DF65C6134580' () cil managed
//   
// native-calls: 06000721,06000722,06000723
// native-strings: 
// ============================================================

public  void 0755DF65C6134580()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 9 call(s):
    //   0x28d970dd950  ALLOC_OBJECT(0x28d96746068)
    //   0x28d970dd978  WBARRIER((ALLOC_OBJECT(0x28d96746068) add 0x20), ?)
    //   0x28d970dd9c8  1E4F78B0A13B4D5D::8F3C8E1A4D40475D(ALLOC_OBJECT(0x28d96746068))
    //   0x28d970dd9e8  ALLOC_OBJECT(0x28d96746228)
    //   0x28d970dda10  WBARRIER((ALLOC_OBJECT(0x28d96746228) add 0x20), 0x28d96746138.f28)
    //   0x28d970dda60  1E4F78B0A13B4D5D::96FF3A52951E4228(ALLOC_OBJECT(0x28d96746228))
    //   0x28d970dda70  1E4F78B0A13B4D5D::31305C5717B9479C(this)
    //   0x28d970dda98  THROW(0x162, 0xaa)
    //   0x28d970ddab0  THROW(0xf3, 0xe5)
    // 12 store(s):
    //   0x28d970dd95f  ALLOC_OBJECT(0x28d96746068) <- this
    //   0x28d970dd989  ALLOC_OBJECT(0x28d96746068) <- 0x28d966595e0
    //   0x28d970dd997  ALLOC_OBJECT(0x28d96746068) <- 0x28d96746130
    //   0x28d970dd9a9  ALLOC_OBJECT(0x28d96746068) <- 0x28d96746138.f28
    //   0x28d970dd9b1  ALLOC_OBJECT(0x28d96746068) <- 0x28d96746138.f20
    //   0x28d970dd9b5  ALLOC_OBJECT(0x28d96746068) <- 0x0
    //   0x28d970dd9f7  ALLOC_OBJECT(0x28d96746228) <- this
    //   0x28d970dda21  ALLOC_OBJECT(0x28d96746228) <- 0x28d966595e0
    //   0x28d970dda2f  ALLOC_OBJECT(0x28d96746228) <- 0x28d96746130
    //   0x28d970dda41  ALLOC_OBJECT(0x28d96746228) <- 0x28d967462f0.f28
    //   0x28d970dda49  ALLOC_OBJECT(0x28d96746228) <- 0x28d967462f0.f20
    //   0x28d970dda4d  ALLOC_OBJECT(0x28d96746228) <- 0x0
    // returns: 1E4F78B0A13B4D5D::31305C5717B9479C(this)
}
