// ============================================================
// token 0x06000855   C9DAE847B3664123::FF94B48B52124920
// native code: 0x28d9722dd10  (129 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void FF94B48B52124920 () cil managed noinlining
//   
// native-calls: 06001056,06000007,06000005
// native-strings: 0x1ecc:Detections:Analysis:NoSpread:Enabled
// ============================================================

public  void FF94B48B52124920()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d9722dd28  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722dd48  <Module>::3F57E81A62734AC2(0xa9fe06c)   ; "Detections:Analysis:NoSpread:Enabled"
    //   0x28d9722dd60  <Module>::F84FA79ABE6944BB(0x535d8515)   ; =0
    //   0x28d9722dd78  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0xa9fe06c), <Module>::F84FA79ABE6944BB(0x535d8515), ?)
    // 1 store(s):
    //   0x28d9722dd88  0x28d966355f8 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0xa9fe06c), <Module>::F84FA79ABE6944BB(0x535d8515), ?)
    // returns: 0x28d966355f8
    // string table refs:
    //   0x1ecc  "Detections:Analysis:NoSpread:Enabled"
}
