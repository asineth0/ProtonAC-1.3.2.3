// ============================================================
// token 0x06001445   B165E908635F4A7C::.ctor
// native code: 0x28d959ef000  (157 bytes)
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
    //   0x28d959ef028  ALLOC_OBJECT(0x28c86b41b40)
    //   0x28d959ef058  WBARRIER((ALLOC_OBJECT(0x28c86b41b40) add 0x10), ?)
    //   0x28d959ef078  WBARRIER(this+30, ?)
    //   0x28d959ef090  652C34B1E6554F10::.ctor(this)
    // 2 store(s):
    //   0x28d959ef044  (ALLOC_OBJECT(0x28c86b41b40) add 0x10) <- 0x28cc75df3c0
    //   0x28d959ef06b  this+30 <- ALLOC_OBJECT(0x28c86b41b40)
    // returns: 652C34B1E6554F10::.ctor(this)
}
