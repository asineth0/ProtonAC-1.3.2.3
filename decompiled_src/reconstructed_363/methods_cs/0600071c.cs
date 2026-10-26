// ============================================================
// token 0x0600071c   1E4F78B0A13B4D5D::93D20B0F76EF401E
// native code: 0x28d9722cdb0  (447 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '93D20B0F76EF401E' () cil managed noinlining
//   
// native-calls: 06001056,06000003,06000007,06000006,06000004
// native-strings: 0x1ad0:Detections:Analysis:FastSalvage:Enabled,0x1afc:Detections:Analysis:FastSalvage:Mitigate
// ============================================================

public  void 93D20B0F76EF401E()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d9722cde0  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722ce08  <Module>::8B9C7B12B1AE4949(0xffffffff9c9ebcf6)   ; "Detections:Analysis:FastSalvage:Enabled"
    //   0x28d9722ce28  <Module>::3F57E81A62734AC2(0xffffffff94857146)   ; =0
    //   0x28d9722ce40  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0xffffffff9c9ebcf6), <Module>::3F57E81A62734AC2(0xffffffff94857146), ?)
    //   0x28d9722ced0  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722cef8  <Module>::58ECCB512F2A43AC(0xfffffffffacb3866)   ; "Detections:Analysis:FastSalvage:Mitigate"
    //   0x28d9722cf18  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d9722cf30  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::58ECCB512F2A43AC(0xfffffffffacb3866), <Module>::390073C602714496(0x7f132d63), ?)
    // 2 store(s):
    //   0x28d9722ce50  0x28d96745f48 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0xffffffff9c9ebcf6), <Module>::3F57E81A62734AC2(0xffffffff94857146), ?)
    //   0x28d9722cf40  0x28d96745f49 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::58ECCB512F2A43AC(0xfffffffffacb3866), <Module>::390073C602714496(0x7f132d63), ?)
    // returns: 0x28d96745f49
    // string table refs:
    //   0x1ad0  "Detections:Analysis:FastSalvage:Enabled"
    //   0x1afc  "Detections:Analysis:FastSalvage:Mitigate"
}
