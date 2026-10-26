// ============================================================
// token 0x06000789   FB4955BB838D485E::79B4ACF1084A40AA
// native code: 0x28d9722dc70  (137 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '79B4ACF1084A40AA' () cil managed noinlining
//   
// native-calls: 06001056,06000007,06000003
// native-strings: 0x1bf8:Detections:Analysis:SpinBot:Enabled
// ============================================================

public  void 79B4ACF1084A40AA()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d9722dc88  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722dca8  <Module>::3F57E81A62734AC2(0x16921083)   ; "Detections:Analysis:SpinBot:Enabled"
    //   0x28d9722dcc8  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d9722dce0  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0x16921083), <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd), ?)
    // 1 store(s):
    //   0x28d9722dcf0  0x28d966357d0 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0x16921083), <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd), ?)
    // returns: 0x28d966357d0
    // string table refs:
    //   0x1bf8  "Detections:Analysis:SpinBot:Enabled"
}
