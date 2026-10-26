// ============================================================
// token 0x060000c2   1DB744298E9F4B09::47DCD11B55514AD5
// native code: 0x28d95841ad0  (109 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance void '47DCD11B55514AD5' (
//   class [ProtonAC.Microsoft.Extensions.Logging.Abstractions]Microsoft.Extensions.Logging.ILoggingBuilder ''
//   ) cil managed noinlining
//   
// native-calls: 06000003,06000124,06000125
// native-strings: 
// ============================================================

 void 47DCD11B55514AD5(Microsoft.Extensions.Logging.ILoggingBuilder arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d95841b00  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d95841b18  1DB744298E9F4B09::D32755EB89534C20(arg0, <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd))
    //   0x28d95841b30  1DB744298E9F4B09::19F0C3FCC92C461A(1DB744298E9F4B09::D32755EB89534C20(arg0, <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)), this.f28)
    // returns: 1DB744298E9F4B09::19F0C3FCC92C461A(1DB744298E9F4B09::D32755EB89534C20(arg0, <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)), this.f28)
}
