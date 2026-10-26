// ============================================================
// token 0x060006f6   78E199359C6046BB::5E659220D0124971
// native code: 0x28d970dd590  (387 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '5E659220D0124971' () cil managed
//   
// native-calls: 060006fb,060006fc
// native-strings: 
// ============================================================

public  void 5E659220D0124971()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d970dd5d8  ALLOC_OBJECT(0x28d96745c10)
    //   0x28d970dd600  WBARRIER((ALLOC_OBJECT(0x28d96745c10) add 0x20), ?)
    //   0x28d970dd650  78E199359C6046BB::041C13D4E01948BF(0x28c84109ae0.f0, ALLOC_OBJECT(0x28d96745c10))
    //   0x28d970dd6a0  WBARRIER(0x28c84109ae0, ALLOC_OBJECT(0x28d96745c10))
    //   0x28d970dd6b8  78E199359C6046BB::FE270DB039224757(this)
    //   0x28d970dd6e0  THROW(0x14b, 0x71)
    //   0x28d970dd6f8  THROW(0x162, 0x11a)
    //   0x28d970dd710  THROW(0xf3, 0x15c)
    // 7 store(s):
    //   0x28d970dd5e7  ALLOC_OBJECT(0x28d96745c10) <- this
    //   0x28d970dd615  ALLOC_OBJECT(0x28d96745c10) <- 0x28d96658b20
    //   0x28d970dd623  ALLOC_OBJECT(0x28d96745c10) <- 0x28d96745cd8
    //   0x28d970dd635  ALLOC_OBJECT(0x28d96745c10) <- 0x28d96745ce0.f28
    //   0x28d970dd63d  ALLOC_OBJECT(0x28d96745c10) <- 0x28d96745ce0.f20
    //   0x28d970dd641  ALLOC_OBJECT(0x28d96745c10) <- 0x0
    //   0x28d970dd685  0x28c84109ae0 <- 78E199359C6046BB::041C13D4E01948BF(0x28c84109ae0.f0, ALLOC_OBJECT(0x28d96745c10))
    // returns: 78E199359C6046BB::FE270DB039224757(this)
}
