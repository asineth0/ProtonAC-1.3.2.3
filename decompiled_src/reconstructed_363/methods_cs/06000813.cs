// ============================================================
// token 0x06000813   592672D60B944FFF::60725731F99042FD
// native code: 0x28d970d2ca0  (387 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '60725731F99042FD' () cil managed
//   
// native-calls: 06000818,06000819
// native-strings: 
// ============================================================

public  void 60725731F99042FD()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d970d2ce8  ALLOC_OBJECT(0x28d9683b260)
    //   0x28d970d2d10  WBARRIER((ALLOC_OBJECT(0x28d9683b260) add 0x20), ?)
    //   0x28d970d2d60  592672D60B944FFF::6968D850CB394C1E(0x28c84109b48.f0, ALLOC_OBJECT(0x28d9683b260))
    //   0x28d970d2db0  WBARRIER(0x28c84109b48, ALLOC_OBJECT(0x28d9683b260))
    //   0x28d970d2dc8  592672D60B944FFF::40975B540FB44986(this)
    //   0x28d970d2df0  THROW(0x14b, 0x71)
    //   0x28d970d2e08  THROW(0x162, 0x11a)
    //   0x28d970d2e20  THROW(0xf3, 0x15c)
    // 7 store(s):
    //   0x28d970d2cf7  ALLOC_OBJECT(0x28d9683b260) <- this
    //   0x28d970d2d25  ALLOC_OBJECT(0x28d9683b260) <- 0x28d96652b38
    //   0x28d970d2d33  ALLOC_OBJECT(0x28d9683b260) <- 0x28d9665c6f0
    //   0x28d970d2d45  ALLOC_OBJECT(0x28d9683b260) <- 0x28d9665c6f8.f28
    //   0x28d970d2d4d  ALLOC_OBJECT(0x28d9683b260) <- 0x28d9665c6f8.f20
    //   0x28d970d2d51  ALLOC_OBJECT(0x28d9683b260) <- 0x0
    //   0x28d970d2d95  0x28c84109b48 <- 592672D60B944FFF::6968D850CB394C1E(0x28c84109b48.f0, ALLOC_OBJECT(0x28d9683b260))
    // returns: 592672D60B944FFF::40975B540FB44986(this)
}
