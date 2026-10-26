// ============================================================
// token 0x0600063c   BE3140E5E8934376::70BDA8CE0B774170
// native code: 0x28d9722dec0  (273 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '70BDA8CE0B774170' () cil managed noinlining
//   
// native-calls: 06001056,06000005,06000007
// native-strings: 0x1688:Detections:Raycast:Basic:Enabled,0x16ac:Detections:Raycast:Basic:Mitigate
// ============================================================

public  void 70BDA8CE0B774170()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d9722ded8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722df00  <Module>::F84FA79ABE6944BB(0xffffffff98ee4024)   ; "Detections:Raycast:Basic:Enabled"
    //   0x28d9722df20  <Module>::3F57E81A62734AC2(0xffffffff94857146)   ; =0
    //   0x28d9722df38  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::F84FA79ABE6944BB(0xffffffff98ee4024), <Module>::3F57E81A62734AC2(0xffffffff94857146), ?)
    //   0x28d9722df58  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722df80  <Module>::3F57E81A62734AC2(0xffffffff8d48a674)   ; "Detections:Raycast:Basic:Mitigate"
    //   0x28d9722dfa0  <Module>::3F57E81A62734AC2(0xffffffff94857146)   ; =0
    //   0x28d9722dfb8  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0xffffffff8d48a674), <Module>::3F57E81A62734AC2(0xffffffff94857146), ?)
    // 2 store(s):
    //   0x28d9722df48  0x28d03f81d18 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::F84FA79ABE6944BB(0xffffffff98ee4024), <Module>::3F57E81A62734AC2(0xffffffff94857146), ?)
    //   0x28d9722dfc8  0x28d03f81d19 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0xffffffff8d48a674), <Module>::3F57E81A62734AC2(0xffffffff94857146), ?)
    // returns: 0x28d03f81d19
    // string table refs:
    //   0x1688  "Detections:Raycast:Basic:Enabled"
    //   0x16ac  "Detections:Raycast:Basic:Mitigate"
}
