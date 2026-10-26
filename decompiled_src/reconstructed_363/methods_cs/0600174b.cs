// ============================================================
// token 0x0600174b   83D3069491A44F2C::.ctor
// native code: 0x28d959ef8e0  (133 bytes)
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
    //   0x28d959ef908  ALLOC_OBJECT(0x28d93fc6220)
    //   0x28d959ef920  .ctor(ALLOC_OBJECT(0x28d93fc6220), ?, ?, ?)
    //   0x28d959ef940  WBARRIER(this+28, ?)
    //   0x28d959ef958  652C34B1E6554F10::.ctor(this)
    // 1 store(s):
    //   0x28d959ef92f  this+28 <- ALLOC_OBJECT(0x28d93fc6220)
    // returns: 652C34B1E6554F10::.ctor(this)
}
