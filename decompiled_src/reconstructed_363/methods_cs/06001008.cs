// ============================================================
// token 0x06001008   CDD77F4B61A645F5::.ctor
// native code: 0x28d957e0e60  (113 bytes)
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
    //   0x28d957e0e88  ALLOC_OBJECT(0x28d94d19650)
    //   0x28d957e0ea0  .ctor(ALLOC_OBJECT(0x28d94d19650), ?, ?, ?)
    //   0x28d957e0ec0  WBARRIER(this+10, ?)
    // 1 store(s):
    //   0x28d957e0eaf  this+10 <- ALLOC_OBJECT(0x28d94d19650)
    // returns: ALLOC_OBJECT(0x28d94d19650)
}
