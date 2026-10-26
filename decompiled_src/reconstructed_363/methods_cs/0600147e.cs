// ============================================================
// token 0x0600147e   6670217620CF4763::.ctor
// native code: 0x28d958db8f0  (157 bytes)
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
    //   0x28d958db918  ALLOC_OBJECT(0x28ccdab9ec8)
    //   0x28d958db948  WBARRIER((ALLOC_OBJECT(0x28ccdab9ec8) add 0x10), ?)
    //   0x28d958db968  WBARRIER(this+38, ?)
    //   0x28d958db980  652C34B1E6554F10::.ctor(this)
    // 2 store(s):
    //   0x28d958db934  (ALLOC_OBJECT(0x28ccdab9ec8) add 0x10) <- 0x28d0b6644a0
    //   0x28d958db95b  this+38 <- ALLOC_OBJECT(0x28ccdab9ec8)
    // returns: 652C34B1E6554F10::.ctor(this)
}
