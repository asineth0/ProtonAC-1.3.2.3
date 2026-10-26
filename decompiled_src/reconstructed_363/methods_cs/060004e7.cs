// ============================================================
// token 0x060004e7   40273E31A09B48E7::.ctor
// native code: 0x28d97013a20  (81 bytes)
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
    // 2 call(s):
    //   0x28d97013a48  ALLOC_ARRAY(0x28c851b3688, 0x2000)
    //   0x28d97013a60  WBARRIER(this+10, 0x2000)
    // 1 store(s):
    //   0x28d97013a53  this+10 <- ALLOC_ARRAY(0x28c851b3688, 0x2000)
    // returns: ALLOC_ARRAY(0x28c851b3688, 0x2000)
}
