// ============================================================
// token 0x06000f1c   793AD9726F0B488F::.ctor
// native code: 0x28d957e1390  (113 bytes)
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
    //   0x28d957e13b8  ALLOC_OBJECT(0x28d94d19d80)
    //   0x28d957e13d0  .ctor(ALLOC_OBJECT(0x28d94d19d80), ?, ?, ?)
    //   0x28d957e13f0  WBARRIER(this+10, ?)
    // 1 store(s):
    //   0x28d957e13df  this+10 <- ALLOC_OBJECT(0x28d94d19d80)
    // returns: ALLOC_OBJECT(0x28d94d19d80)
}
