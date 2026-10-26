// ============================================================
// token 0x0600082d   269EE5A44F844EAA::EC142F04063848BB
// native code: 0x28d9722ddb0  (241 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void EC142F04063848BB () cil managed noinlining
//   
// native-calls: 06001056,06000003,06000005,06000004
// native-strings: 0x1e54:Detections:Analysis:NoRecoil:Enabled,0x1e7c:Detections:Analysis:NoRecoil:Mitigate
// ============================================================

public  void EC142F04063848BB()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d9722ddc8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722dde8  <Module>::8B9C7B12B1AE4949(0x4495ee9d)   ; "Detections:Analysis:NoRecoil:Enabled"
    //   0x28d9722de00  <Module>::F84FA79ABE6944BB(0x535d8515)   ; =0
    //   0x28d9722de18  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0x4495ee9d), <Module>::F84FA79ABE6944BB(0x535d8515), ?)
    //   0x28d9722de38  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722de58  <Module>::F84FA79ABE6944BB(0x1bd56cef)   ; "Detections:Analysis:NoRecoil:Mitigate"
    //   0x28d9722de70  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d9722de88  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::F84FA79ABE6944BB(0x1bd56cef), <Module>::390073C602714496(0x7f132d63), ?)
    // 2 store(s):
    //   0x28d9722de28  0x28d0351cb18 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0x4495ee9d), <Module>::F84FA79ABE6944BB(0x535d8515), ?)
    //   0x28d9722de98  0x28d0351cb19 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::F84FA79ABE6944BB(0x1bd56cef), <Module>::390073C602714496(0x7f132d63), ?)
    // returns: 0x28d0351cb19
    // string table refs:
    //   0x1e54  "Detections:Analysis:NoRecoil:Enabled"
    //   0x1e7c  "Detections:Analysis:NoRecoil:Mitigate"
}
