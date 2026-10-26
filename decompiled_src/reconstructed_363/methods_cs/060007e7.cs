// ============================================================
// token 0x060007e7   374BE951F2E44BB5::.ctor
// native code: 0x28d970e1e40  (133 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 0600106b
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d970e1e68  ALLOC_OBJECT(0x28d96758748)
    //   0x28d970e1e80  .ctor(ALLOC_OBJECT(0x28d96758748), ?, ?, ?)
    //   0x28d970e1ea0  WBARRIER(this+10, ?)
    //   0x28d970e1eb8  760EF57D5259421C::.ctor(this)
    // 1 store(s):
    //   0x28d970e1e8f  this+10 <- ALLOC_OBJECT(0x28d96758748)
    // returns: 760EF57D5259421C::.ctor(this)
}
