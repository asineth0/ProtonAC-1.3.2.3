// ============================================================
// token 0x06000361   C7A753824C0746AE::.ctor
// native code: 0x28d97017810  (133 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 06001086
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d97017838  ALLOC_OBJECT(0x28d93f56638)
    //   0x28d97017850  .ctor(ALLOC_OBJECT(0x28d93f56638), ?, ?, ?)
    //   0x28d97017870  WBARRIER(this+10, ?)
    //   0x28d97017888  C179263454B44BF6::.ctor(this)
    // 1 store(s):
    //   0x28d9701785f  this+10 <- ALLOC_OBJECT(0x28d93f56638)
    // returns: C179263454B44BF6::.ctor(this)
}
