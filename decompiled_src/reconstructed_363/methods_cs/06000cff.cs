// ============================================================
// token 0x06000cff   85399D7C08B94D76::.ctor
// native code: 0x28d95833220  (73 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 06000d0e
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 2 call(s):
    //   0x28d95833240  85399D7C08B94D76::2E5FC999C4F84832()
    //   0x28d95833258  WBARRIER(this+10, ?)
    // 1 store(s):
    //   0x28d9583324b  this+10 <- 85399D7C08B94D76::2E5FC999C4F84832()
    // returns: 85399D7C08B94D76::2E5FC999C4F84832()
}
