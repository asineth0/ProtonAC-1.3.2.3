// ============================================================
// token 0x06000cfc   0CAF5A99CBFA42D0::.ctor
// native code: 0x28d9586cd00  (145 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   string '',
//   valuetype [ProtonAC.Microsoft.Extensions.Logging.Abstractions]Microsoft.Extensions.Logging.LogLevel '',
//   string '',
//   string ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public  void .ctor(string arg0, Microsoft.Extensions.Logging.LogLevel arg1, string arg2, string arg3)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d9586cd40  WBARRIER(this, arg0)
    //   0x28d9586cd60  WBARRIER(this+10, arg0)
    //   0x28d9586cd78  WBARRIER(this+18, arg0)
    // 4 store(s):
    //   0x28d9586cd29  this <- arg0
    //   0x28d9586cd47  this <- (movsxd arg1)
    //   0x28d9586cd4f  this+10 <- arg2
    //   0x28d9586cd67  this+18 <- S[rbp+30]
    // returns: WBARRIER(this+18, arg0)
}
