// ============================================================
// token 0x060008b5   0447F941905C4653::.ctor
// native code: 0x28d97030f00  (137 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d97030f28  ALLOC_OBJECT(0x28d961dbfc8)
    //   0x28d97030f58  WBARRIER((ALLOC_OBJECT(0x28d961dbfc8) add 0x10), ?)
    //   0x28d97030f78  WBARRIER(this+10, ?)
    // 2 store(s):
    //   0x28d97030f44  (ALLOC_OBJECT(0x28d961dbfc8) add 0x10) <- 0x28d0c9524e0
    //   0x28d97030f6b  this+10 <- ALLOC_OBJECT(0x28d961dbfc8)
    // returns: ALLOC_OBJECT(0x28d961dbfc8)
}
