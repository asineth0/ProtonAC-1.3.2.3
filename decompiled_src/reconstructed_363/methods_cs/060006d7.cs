// ============================================================
// token 0x060006d7   324819153CA4494E::6B10D39431EA4CCB
// native code: 0x28d970ce7e0  (672 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '6B10D39431EA4CCB' () cil managed
//   
// native-calls: 06001068
// native-strings: 
// ============================================================

public  void 6B10D39431EA4CCB()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 12 call(s):
    //   0x28d970ce828  ALLOC_OBJECT(0x28d96646b48)
    //   0x28d970ce850  WBARRIER((ALLOC_OBJECT(0x28d96646b48) add 0x20), ?)
    //   0x28d970ce8a0  Combine(0x28d03f81cd8.f0, ALLOC_OBJECT(0x28d96646b48), 0x28d96646c18.f28, ?)
    //   0x28d970ce8f0  WBARRIER(0x28d03f81cd8, ALLOC_OBJECT(0x28d96646b48))
    //   0x28d970ce928  ALLOC_OBJECT(0x28d96646d78)
    //   0x28d970ce950  WBARRIER((ALLOC_OBJECT(0x28d96646d78) add 0x20), ALLOC_OBJECT(0x28d96646b48))
    //   0x28d970ce9a0  Combine(0x28d03f81cc0.f0, ALLOC_OBJECT(0x28d96646d78), 0x28d96646e48.f28, ?)
    //   0x28d970ce9f0  WBARRIER(0x28d03f81cc0, ALLOC_OBJECT(0x28d96646d78))
    //   0x28d970cea08  760EF57D5259421C::A599C828530B4E69(this)
    //   0x28d970cea38  THROW(0x14b, 0x79)
    //   0x28d970cea50  THROW(0x162, 0x122)
    //   0x28d970cea68  THROW(0xf3, 0x160)
    // 14 store(s):
    //   0x28d970ce837  ALLOC_OBJECT(0x28d96646b48) <- this
    //   0x28d970ce865  ALLOC_OBJECT(0x28d96646b48) <- 0x28d9663e898
    //   0x28d970ce873  ALLOC_OBJECT(0x28d96646b48) <- 0x28d96646c10
    //   0x28d970ce885  ALLOC_OBJECT(0x28d96646b48) <- 0x28d96646c18.f28
    //   0x28d970ce88d  ALLOC_OBJECT(0x28d96646b48) <- 0x28d96646c18.f20
    //   0x28d970ce891  ALLOC_OBJECT(0x28d96646b48) <- 0x0
    //   0x28d970ce8d5  0x28d03f81cd8 <- Combine(0x28d03f81cd8.f0, ALLOC_OBJECT(0x28d96646b48), 0x28d96646c18.f28, ?)
    //   0x28d970ce937  ALLOC_OBJECT(0x28d96646d78) <- this
    //   0x28d970ce965  ALLOC_OBJECT(0x28d96646d78) <- 0x28d9663eb40
    //   0x28d970ce973  ALLOC_OBJECT(0x28d96646d78) <- 0x28d96646e40
    //   0x28d970ce985  ALLOC_OBJECT(0x28d96646d78) <- 0x28d96646e48.f28
    //   0x28d970ce98d  ALLOC_OBJECT(0x28d96646d78) <- 0x28d96646e48.f20
    //   0x28d970ce991  ALLOC_OBJECT(0x28d96646d78) <- 0x0
    //   0x28d970ce9d5  0x28d03f81cc0 <- Combine(0x28d03f81cc0.f0, ALLOC_OBJECT(0x28d96646d78), 0x28d96646e48.f28, ?)
    // returns: 760EF57D5259421C::A599C828530B4E69(this)
}
