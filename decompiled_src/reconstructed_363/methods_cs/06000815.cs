// ============================================================
// token 0x06000815   592672D60B944FFF::3B31AC6BA57D4013
// native code: 0x28d9722d480  (137 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '3B31AC6BA57D4013' () cil managed noinlining
//   
// native-calls: 06001056,06000007,06000004
// native-strings: 0x1df4:Detections:FakeLag:Input:Enabled
// ============================================================

public  void 3B31AC6BA57D4013()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d9722d498  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d4c0  <Module>::3F57E81A62734AC2(0xffffffffb2a2f22e)   ; "Detections:FakeLag:Input:Enabled"
    //   0x28d9722d4d8  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d9722d4f0  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0xffffffffb2a2f22e), <Module>::390073C602714496(0x7f132d63), ?)
    // 1 store(s):
    //   0x28d9722d500  0x28d9665c668 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0xffffffffb2a2f22e), <Module>::390073C602714496(0x7f132d63), ?)
    // returns: 0x28d9665c668
    // string table refs:
    //   0x1df4  "Detections:FakeLag:Input:Enabled"
}
