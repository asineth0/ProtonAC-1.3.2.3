// ============================================================
// token 0x06000cee   3DBA106924E9431F::IsEnabled
// native code: 0x28d9586a6e0  (114 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public final hidebysig newslot virtual
//   instance bool IsEnabled (
//   valuetype [ProtonAC.Microsoft.Extensions.Logging.Abstractions]Microsoft.Extensions.Logging.LogLevel logLevel
//   ) cil managed noinlining
//   
// native-calls: 06000007,06000003
// native-strings: 
// ============================================================

public  bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 2 call(s):
    //   0x28d9586a708  <Module>::3F57E81A62734AC2(0x34e0ad8b)   ; =6
    //   0x28d9586a738  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    // returns: (movzx (movzx logLevel))
}
