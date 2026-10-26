// ============================================================
// token 0x060016a6   313E272045674C37::.ctor
// native code: 0x28d959efda0  (133 bytes)
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
    //   0x28d959efdc8  ALLOC_OBJECT(0x28d93fc6af0)
    //   0x28d959efde0  .ctor(ALLOC_OBJECT(0x28d93fc6af0), ?, ?, ?)
    //   0x28d959efe00  WBARRIER(this+28, ?)
    //   0x28d959efe18  652C34B1E6554F10::.ctor(this)
    // 1 store(s):
    //   0x28d959efdef  this+28 <- ALLOC_OBJECT(0x28d93fc6af0)
    // returns: 652C34B1E6554F10::.ctor(this)
}
