// ============================================================
// token 0x0600064d   3301ED6AA1A1474A::55B1D16265F64FD9
// native code: 0x28d9722dff0  (471 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '55B1D16265F64FD9' () cil managed noinlining
//   
// native-calls: 06001056,06000004,06000007,06000003
// native-strings: 0x16d4:Detections:Raycast:Bullet:Enabled,0x16fc:Detections:Raycast:Bullet:Mitigate
// ============================================================

public  void 55B1D16265F64FD9()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d9722e020  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722e048  <Module>::390073C602714496(0x7401a173)   ; "Detections:Raycast:Bullet:Enabled"
    //   0x28d9722e068  <Module>::3F57E81A62734AC2(0xffffffff94857146)   ; =0
    //   0x28d9722e080  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0x7401a173), <Module>::3F57E81A62734AC2(0xffffffff94857146), ?)
    //   0x28d9722e128  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722e150  <Module>::8B9C7B12B1AE4949(0x3ad069f7)   ; "Detections:Raycast:Bullet:Mitigate"
    //   0x28d9722e170  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d9722e188  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0x3ad069f7), <Module>::390073C602714496(0x7f132d63), ?)
    // 2 store(s):
    //   0x28d9722e090  0x28c840e84a8 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0x7401a173), <Module>::3F57E81A62734AC2(0xffffffff94857146), ?)
    //   0x28d9722e198  0x28c840e84a9 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0x3ad069f7), <Module>::390073C602714496(0x7f132d63), ?)
    // returns: 0x28c840e84a9
    // string table refs:
    //   0x16d4  "Detections:Raycast:Bullet:Enabled"
    //   0x16fc  "Detections:Raycast:Bullet:Mitigate"
}
