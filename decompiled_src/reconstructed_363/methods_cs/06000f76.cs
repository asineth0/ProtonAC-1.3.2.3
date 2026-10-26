// ============================================================
// token 0x06000f76   49992BF9672941B5::.ctor
// native code: 0x28d957e2d30  (89 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 06000f77,06000f78
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d957e2d50  49992BF9672941B5::F44EA4B48650401C()
    //   0x28d957e2d60  49992BF9672941B5::FB514321CDDE420A(49992BF9672941B5::F44EA4B48650401C())
    //   0x28d957e2d78  WBARRIER(this+10, ?)
    // 1 store(s):
    //   0x28d957e2d6b  this+10 <- 49992BF9672941B5::FB514321CDDE420A(49992BF9672941B5::F44EA4B48650401C())
    // returns: 49992BF9672941B5::FB514321CDDE420A(49992BF9672941B5::F44EA4B48650401C())
}
