// ============================================================
// token 0x06000969   4774CC3E188745EA::.ctor
// native code: 0x28d973173e0  (337 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 0600096a
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 9 call(s):
    //   0x28d97317408  ALLOC_OBJECT(0x28ccd8603a8)
    //   0x28d97317438  WBARRIER((ALLOC_OBJECT(0x28ccd8603a8) add 0x10), ?)
    //   0x28d97317458  WBARRIER(this+10, ?)
    //   0x28d97317478  ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d973174a8  WBARRIER((ALLOC_OBJECT(0x28c86f73f50) add 0x10), ?)
    //   0x28d973174c8  WBARRIER(this+18, ?)
    //   0x28d973174e8  ALLOC_OBJECT(0x28d953c3c00)
    //   0x28d97317500  AE8979A166C64D26::.ctor(ALLOC_OBJECT(0x28d953c3c00))
    //   0x28d97317520  WBARRIER(this+20, ?)
    // 5 store(s):
    //   0x28d97317424  (ALLOC_OBJECT(0x28ccd8603a8) add 0x10) <- 0x28cef17bdc0
    //   0x28d9731744b  this+10 <- ALLOC_OBJECT(0x28ccd8603a8)
    //   0x28d97317494  (ALLOC_OBJECT(0x28c86f73f50) add 0x10) <- 0x28cc75df260
    //   0x28d973174bb  this+18 <- ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d9731750f  this+20 <- ALLOC_OBJECT(0x28d953c3c00)
    // returns: ALLOC_OBJECT(0x28d953c3c00)
}
