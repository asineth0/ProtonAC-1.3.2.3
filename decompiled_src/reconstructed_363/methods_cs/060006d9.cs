// ============================================================
// token 0x060006d9   324819153CA4494E::C09A92C44A1A4196
// native code: 0x28d9722da30  (395 bytes)
// kind: LOOP   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void C09A92C44A1A4196 () cil managed
//   
// native-calls: 06001056
// native-strings: ?:Detections:VehicleMovement:{0}:Enabled,?:Detections:VehicleMovement:{0}:Mitigate,?:2804666359520,?:2804666359408
// ============================================================

public  void C09A92C44A1A4196()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 9 call(s):
    //   0x28d9722da88  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722dab8  ALLOC_OBJECT(0x28d96167478)
    //   0x28d9722dae0  Format(0x28d03245ee0, ALLOC_OBJECT(0x28d96167478), ?, ?)   ; "Detections:VehicleMovement:{0}:Enabled"
    //   0x28d9722daf8  GetValue(760EF57D5259421C::02D998059BCD47E8(), Format(0x28d03245ee0, ALLOC_OBJECT(0x28d96167478), ?, ?), (xor ?), ?)
    //   0x28d9722db10  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722db38  ALLOC_OBJECT(0x28d96167478)
    //   0x28d9722db60  Format(0x28d03245e70, ALLOC_OBJECT(0x28d96167478), (xor ?), ?)   ; "Detections:VehicleMovement:{0}:Mitigate"
    //   0x28d9722db78  GetValue(760EF57D5259421C::02D998059BCD47E8(), Format(0x28d03245e70, ALLOC_OBJECT(0x28d96167478), (xor ?), ?), ((xor ?) xor (xor ?)), ?)
    //   0x28d9722dbb8  THROW(0x146, 0x155)
    // 4 store(s):
    //   0x28d9722dac5  ALLOC_OBJECT(0x28d96167478) <- 0x28ccac64780+(movsxd (r15 xor r15))*8+20.f0.f0
    //   0x28d9722daff  0x28ccac64780+(movsxd (r15 xor r15))*8+20.f0 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), Format(0x28d03245ee0, ALLOC_OBJECT(0x28d96167478), ?, ?), (xor ?), ?)
    //   0x28d9722db42  ALLOC_OBJECT(0x28d96167478) <- 0x28ccac64780+(movsxd (r15 xor r15))*8+20.f0.f0
    //   0x28d9722db7b  0x28ccac64780+(movsxd (r15 xor r15))*8+20.f0 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), Format(0x28d03245e70, ALLOC_OBJECT(0x28d96167478), (xor ?), ?), ((xor ?) xor (xor ?)), ?)
    // returns: (movsxd 0x28ccac64780.f18)
    // string table refs:
    //   literal  "Detections:VehicleMovement:{0}:Enabled"
    //   literal  "Detections:VehicleMovement:{0}:Mitigate"
    //   literal  "2804666359520"
    //   literal  "2804666359408"
}
