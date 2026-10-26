// ============================================================
// token 0x060014ae   BFB93A4A8CB84CC6::.ctor
// native code: 0x28d959efad0  (157 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 06001940
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d959efaf8  ALLOC_OBJECT(0x28c86b41b40)
    //   0x28d959efb28  WBARRIER((ALLOC_OBJECT(0x28c86b41b40) add 0x10), ?)
    //   0x28d959efb48  WBARRIER(this+50, ?)
    //   0x28d959efb60  652C34B1E6554F10::.ctor(this)
    // 2 store(s):
    //   0x28d959efb14  (ALLOC_OBJECT(0x28c86b41b40) add 0x10) <- 0x28cc75df3c0
    //   0x28d959efb3b  this+50 <- ALLOC_OBJECT(0x28c86b41b40)
    // returns: 652C34B1E6554F10::.ctor(this)
}
