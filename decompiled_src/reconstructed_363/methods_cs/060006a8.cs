// ============================================================
// token 0x060006a8   C6338AE87AE0450D::935D65F066DD447D
// native code: 0x28d9701fd50  (387 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '935D65F066DD447D' () cil managed
//   
// native-calls: 060006b1,060006b2
// native-strings: 
// ============================================================

public  void 935D65F066DD447D()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d9701fd98  ALLOC_OBJECT(0x28d967541d8)
    //   0x28d9701fdc0  WBARRIER((ALLOC_OBJECT(0x28d967541d8) add 0x20), ?)
    //   0x28d9701fe10  C6338AE87AE0450D::17F69241B813462E(0x28cc7610f00.f0, ALLOC_OBJECT(0x28d967541d8))
    //   0x28d9701fe60  WBARRIER(0x28cc7610f00, ALLOC_OBJECT(0x28d967541d8))
    //   0x28d9701fe78  C6338AE87AE0450D::83E52F905667495C(this)
    //   0x28d9701fea0  THROW(0x14b, 0x71)
    //   0x28d9701feb8  THROW(0x162, 0x11a)
    //   0x28d9701fed0  THROW(0xf3, 0x15c)
    // 7 store(s):
    //   0x28d9701fda7  ALLOC_OBJECT(0x28d967541d8) <- this
    //   0x28d9701fdd5  ALLOC_OBJECT(0x28d967541d8) <- 0x28d96749510
    //   0x28d9701fde3  ALLOC_OBJECT(0x28d967541d8) <- 0x28d967542a0
    //   0x28d9701fdf5  ALLOC_OBJECT(0x28d967541d8) <- 0x28d967542a8.f28
    //   0x28d9701fdfd  ALLOC_OBJECT(0x28d967541d8) <- 0x28d967542a8.f20
    //   0x28d9701fe01  ALLOC_OBJECT(0x28d967541d8) <- 0x0
    //   0x28d9701fe45  0x28cc7610f00 <- C6338AE87AE0450D::17F69241B813462E(0x28cc7610f00.f0, ALLOC_OBJECT(0x28d967541d8))
    // returns: C6338AE87AE0450D::83E52F905667495C(this)
}
