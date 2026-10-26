// ============================================================
// token 0x06000953   CD12FBF2EC134DF5::.ctor
// native code: 0x28d970d2950  (113 bytes)
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
    //   0x28d970d2978  ALLOC_OBJECT(0x28d9665c2a0)
    //   0x28d970d2990  .ctor(ALLOC_OBJECT(0x28d9665c2a0), ?, ?, ?)
    //   0x28d970d29b0  WBARRIER(this+10, ?)
    // 1 store(s):
    //   0x28d970d299f  this+10 <- ALLOC_OBJECT(0x28d9665c2a0)
    // returns: ALLOC_OBJECT(0x28d9665c2a0)
}
