// ============================================================
// token 0x06000f57   7B7C71CB5C5546D7::.ctor
// native code: 0x28d957e68f0  (89 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 06000f58,06000f59
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d957e6910  7B7C71CB5C5546D7::C8499E51FB314351()
    //   0x28d957e6920  7B7C71CB5C5546D7::F3CAA2F7AC8E4D36(7B7C71CB5C5546D7::C8499E51FB314351())
    //   0x28d957e6938  WBARRIER(this+10, ?)
    // 1 store(s):
    //   0x28d957e692b  this+10 <- 7B7C71CB5C5546D7::F3CAA2F7AC8E4D36(7B7C71CB5C5546D7::C8499E51FB314351())
    // returns: 7B7C71CB5C5546D7::F3CAA2F7AC8E4D36(7B7C71CB5C5546D7::C8499E51FB314351())
}
