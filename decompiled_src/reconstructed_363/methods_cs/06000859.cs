// ============================================================
// token 0x06000859   7FE330C6E84D4C74::11B53F8AB29C433D
// native code: 0x28d9722cfc0  (1189 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '11B53F8AB29C433D' () cil managed
//   
// native-calls: 06001056
// native-strings: ?:Detections:Analysis:SteamProfile:Enabled,?:Detections:Analysis:SteamProfile:AllowedProfileStates,?:Detections:Analysis:SteamProfile:MinimalSteamProfileLevel,?:Detections:Analysis:SteamProfile:FailCounter:MaxFailCount,?:Detections:Analysis:SteamProfile:FailCounter:FailCommand,?:Detections:Analysis:SteamProfile:FailCounter:FinalFailCommand,?:Detections:Analysis:SteamProfile:GameActivity:Enabled,?:Detections:Analysis:SteamProfile:GameActivity:RequiredHours,?:Detections:Analysis:SteamProfile:GameActivity:BanIfNotEnough:Enabled,?:Detections:Analysis:SteamProfile:GameActivity:BanIfNotEnough:BanCommand,?:Detections:Analysis:SteamProfile:AccountCreatedLimit:Enabled,?:Detections:Analysis:SteamProfile:AccountCreatedLimit:AccountCreationTimeLimit,?:Detections:Analysis:SteamProfile:AccountCreatedLimit:BanIfNotEnough:Enabled,?:Detections:Analysis:SteamProfile:AccountCreatedLimit:BanIfNotEnough:BanCommand,?:2804669862224,?:2804680237440,?:2804670557568,?:2804670555840,?:2804670555696,?:2804670555552,?:2804680237312,?:2804670555408,?:2804354217696,?:2804349640704,?:2804670555264,?:2804349902624,?:2804349902448,?:2804342314880
// ============================================================

public  void 11B53F8AB29C433D()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 35 call(s):
    //   0x28d9722cfe8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d008  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d0359d150, (xor ?), ?)   ; "Detections:Analysis:SteamProfile:Enabled"
    //   0x28d9722d020  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d070  Get((760EF57D5259421C::02D998059BCD47E8().f0 xor 760EF57D5259421C::02D998059BCD47E8().f0), 0x28d03f82180, (xor ?), ?)   ; "Detections:Analysis:SteamProfile:AllowedProfileStates"
    //   0x28d9722d098  ALLOC_OBJECT(0x28c86b41b40)
    //   0x28d9722d0c8  sub_28b82780dcb((ALLOC_OBJECT(0x28c86b41b40) add 0x10), 0x28d03f82180, (xor ?), ?)   ; "Detections:Analysis:SteamProfile:AllowedProfileStates"
    //   0x28d9722d0e8  WBARRIER(this+48, 0x28d03f82180)   ; "Detections:Analysis:SteamProfile:AllowedProfileStates"
    //   0x28d9722d0f8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d118  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d03646d80, 0x1, ?)   ; "Detections:Analysis:SteamProfile:MinimalSteamProfileLevel"
    //   0x28d9722d128  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d148  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d036466c0, 0x3, ?)   ; "Detections:Analysis:SteamProfile:FailCounter:MaxFailCount"
    //   0x28d9722d158  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d188  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d03646630, 0x28c840f0fe0, ?)   ; "Detections:Analysis:SteamProfile:FailCounter:FailCommand"
    //   0x28d9722d1b8  WBARRIER(this+28, 0x28d03646630)   ; "Detections:Analysis:SteamProfile:FailCounter:FailCommand"
    //   0x28d9722d1c8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d1f8  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d036465a0, 0x28c840f0fe0, ?)   ; "Detections:Analysis:SteamProfile:FailCounter:FinalFailCommand"
    //   0x28d9722d228  WBARRIER(this+30, 0x28d036465a0)   ; "Detections:Analysis:SteamProfile:FailCounter:FinalFailCommand"
    //   0x28d9722d238  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d258  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d03f82100, (0x28c840f0fe0 xor 0x28c840f0fe0), ?)   ; "Detections:Analysis:SteamProfile:GameActivity:Enabled"
    //   0x28d9722d270  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d290  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d03646510, 0x14, ?)   ; "Detections:Analysis:SteamProfile:GameActivity:RequiredHours"
    //   0x28d9722d2a0  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d2c0  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28cf08976e0, (0x14 xor 0x14), ?)   ; "Detections:Analysis:SteamProfile:GameActivity:BanIfNotEnough:Enabled"
    //   0x28d9722d2d8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d308  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28cf043a000, 0x28c840f0fe0, ?)   ; "Detections:Analysis:SteamProfile:GameActivity:BanIfNotEnough:BanCommand"
    //   0x28d9722d338  WBARRIER(this+38, 0x28cf043a000)   ; "Detections:Analysis:SteamProfile:GameActivity:BanIfNotEnough:BanCommand"
    //   0x28d9722d348  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d368  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d03646480, (0x28c840f0fe0 xor 0x28c840f0fe0), ?)   ; "Detections:Analysis:SteamProfile:AccountCreatedLimit:Enabled"
    //   0x28d9722d380  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d3a0  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28cf0479f20, 0x2, ?)   ; "Detections:Analysis:SteamProfile:AccountCreatedLimit:AccountCreationTimeLimit"
    //   0x28d9722d3b0  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d3d0  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28cf0479e70, (0x2 xor 0x2), ?)   ; "Detections:Analysis:SteamProfile:AccountCreatedLimit:BanIfNotEnough:Enabled"
    //   0x28d9722d3e8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9722d418  GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28cefd3d780, 0x28c840f0fe0, ?)   ; "Detections:Analysis:SteamProfile:AccountCreatedLimit:BanIfNotEnough:BanCommand"
    //   0x28d9722d450  WBARRIER(this+40, 0x28cefd3d780)   ; "Detections:Analysis:SteamProfile:AccountCreatedLimit:BanIfNotEnough:BanCommand"
    // 15 store(s):
    //   0x28d9722d00b  this <- GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d0359d150, (xor ?), ?)
    //   0x28d9722d0b4  (ALLOC_OBJECT(0x28c86b41b40) add 0x10) <- 0x28cc75df3c0
    //   0x28d9722d0da  this+48 <- ALLOC_OBJECT(0x28c86b41b40)
    //   0x28d9722d11b  this <- GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d03646d80, 0x1, ?)
    //   0x28d9722d14b  this <- GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d036466c0, 0x3, ?)
    //   0x28d9722d1ab  this+28 <- 0x28c840f0fe0
    //   0x28d9722d217  this+30 <- 0x28c840f0fe0
    //   0x28d9722d25b  this <- GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d03f82100, (0x28c840f0fe0 xor 0x28c840f0fe0), ?)
    //   0x28d9722d293  this <- GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d03646510, 0x14, ?)
    //   0x28d9722d2c3  this <- GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28cf08976e0, (0x14 xor 0x14), ?)
    //   0x28d9722d32b  this+38 <- 0x28c840f0fe0
    //   0x28d9722d36b  this <- GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28d03646480, (0x28c840f0fe0 xor 0x28c840f0fe0), ?)
    //   0x28d9722d3a3  this <- GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28cf0479f20, 0x2, ?)
    //   0x28d9722d3d3  this <- GetValue(760EF57D5259421C::02D998059BCD47E8(), 0x28cf0479e70, (0x2 xor 0x2), ?)
    //   0x28d9722d43d  this+40 <- 0x28c840f0fe0
    // returns: WBARRIER(this+40, 0x28cefd3d780)
    // string table refs:
    //   literal  "Detections:Analysis:SteamProfile:Enabled"
    //   literal  "Detections:Analysis:SteamProfile:AllowedProfileStates"
    //   literal  "Detections:Analysis:SteamProfile:MinimalSteamProfileLevel"
    //   literal  "Detections:Analysis:SteamProfile:FailCounter:MaxFailCount"
    //   literal  "Detections:Analysis:SteamProfile:FailCounter:FailCommand"
    //   literal  "Detections:Analysis:SteamProfile:FailCounter:FinalFailCommand"
    //   literal  "Detections:Analysis:SteamProfile:GameActivity:Enabled"
    //   literal  "Detections:Analysis:SteamProfile:GameActivity:RequiredHours"
    //   literal  "Detections:Analysis:SteamProfile:GameActivity:BanIfNotEnough:Enabled"
    //   literal  "Detections:Analysis:SteamProfile:GameActivity:BanIfNotEnough:BanCommand"
    //   literal  "Detections:Analysis:SteamProfile:AccountCreatedLimit:Enabled"
    //   literal  "Detections:Analysis:SteamProfile:AccountCreatedLimit:AccountCreationTimeLimit"
    //   literal  "Detections:Analysis:SteamProfile:AccountCreatedLimit:BanIfNotEnough:Enabled"
    //   literal  "Detections:Analysis:SteamProfile:AccountCreatedLimit:BanIfNotEnough:BanCommand"
    //   literal  "2804669862224"
    //   literal  "2804680237440"
    //   literal  "2804670557568"
    //   literal  "2804670555840"
    //   literal  "2804670555696"
    //   literal  "2804670555552"
    //   literal  "2804680237312"
    //   literal  "2804670555408"
    //   literal  "2804354217696"
    //   literal  "2804349640704"
    //   literal  "2804670555264"
    //   literal  "2804349902624"
    //   literal  "2804349902448"
    //   literal  "2804342314880"
}
