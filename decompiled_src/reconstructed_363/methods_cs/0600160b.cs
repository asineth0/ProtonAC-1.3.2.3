// ============================================================
// token 0x0600160b   3CD537B3A9A44CB2::.ctor
// native code: 0x28d959eff90  (85 bytes)
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
    // 2 call(s):
    //   0x28d959effc0  WBARRIER(this+30, ?)
    //   0x28d959effd8  652C34B1E6554F10::.ctor(this)
    // 1 store(s):
    //   0x28d959effb1  this+30 <- 0x28c84118800
    // returns: 652C34B1E6554F10::.ctor(this)
}
