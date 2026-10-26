// ============================================================
// token 0x06000787   FB4955BB838D485E::59F72B64E7E84E50
// native code: 0x28d970ca1d0  (387 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '59F72B64E7E84E50' () cil managed
//   
// native-calls: 0600078d,0600078e
// native-strings: 
// ============================================================

public  void 59F72B64E7E84E50()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d970ca218  ALLOC_OBJECT(0x28d96635960)
    //   0x28d970ca240  WBARRIER((ALLOC_OBJECT(0x28d96635960) add 0x20), ?)
    //   0x28d970ca290  FB4955BB838D485E::60A2A9CE74704AEC(0x28d03f81cf0.f0, ALLOC_OBJECT(0x28d96635960))
    //   0x28d970ca2e0  WBARRIER(0x28d03f81cf0, ALLOC_OBJECT(0x28d96635960))
    //   0x28d970ca2f8  FB4955BB838D485E::EE7D12296CF048ED(this)
    //   0x28d970ca320  THROW(0x14b, 0x71)
    //   0x28d970ca338  THROW(0x162, 0x11a)
    //   0x28d970ca350  THROW(0xf3, 0x15c)
    // 7 store(s):
    //   0x28d970ca227  ALLOC_OBJECT(0x28d96635960) <- this
    //   0x28d970ca255  ALLOC_OBJECT(0x28d96635960) <- 0x28d96637930
    //   0x28d970ca263  ALLOC_OBJECT(0x28d96635960) <- 0x28d96635a28
    //   0x28d970ca275  ALLOC_OBJECT(0x28d96635960) <- 0x28d96635a30.f28
    //   0x28d970ca27d  ALLOC_OBJECT(0x28d96635960) <- 0x28d96635a30.f20
    //   0x28d970ca281  ALLOC_OBJECT(0x28d96635960) <- 0x0
    //   0x28d970ca2c5  0x28d03f81cf0 <- FB4955BB838D485E::60A2A9CE74704AEC(0x28d03f81cf0.f0, ALLOC_OBJECT(0x28d96635960))
    // returns: FB4955BB838D485E::EE7D12296CF048ED(this)
}
