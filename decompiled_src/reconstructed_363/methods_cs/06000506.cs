// ============================================================
// token 0x06000506   A30F7371EEB94415::23C2FAC539F6483B
// native code: 0x28d97223a70  (5225 bytes)
// kind: LOOP   confidence: outline
// original IL signature:
//   .method public hidebysig static
//   class [netstandard]System.Collections.Generic.IEnumerable`1<class ['0Harmony']HarmonyLib.CodeInstruction> '23C2FAC539F6483B' (
//   class [netstandard]System.Collections.Generic.IEnumerable`1<class ['0Harmony']HarmonyLib.CodeInstruction> instructions
//   ) cil managed
//   
// native-calls: 0600050d,06000510,0600050e,06006153,06000511,06001469,060000b0,060000ae,06000522,0600009c
// native-strings: ?:E504ECB3C66148CC,?:stfld pendingSecondaryAttackInput → TickStart,?:stloc WalkingPlayerInputPacket → HandleMovement + MisSimulatedPacket,?:61AEC9C3614E4DAE,?:PlayerMovement::simulate(9) → HandleMovement,?:539D9A90EEA84064,?:ldsfld SendSimulateMispredictedInputs → MisSimulatedPacket,?:DB2C7A7FEA8946E0,?:ldsfld onPluginKeyTick → TickEnd,?:; ,?:PlayerInput.FixedUpdate: не найдены якоря [{A}] — детекты отключены,?:2804802979776,?:2804346043680,?:2804346038144,?:2804802979712,?:2804346043568,?:2804802979648,?:2804345915360,?:2804802979520,?:2803724993280,?:2803732044672,?:2804346037984
// ============================================================

public static IEnumerable<class HarmonyLib.CodeInstruction> 23C2FAC539F6483B(IEnumerable<class HarmonyLib.CodeInstruction> instructions)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 71 call(s):
    //   0x28d97223ad8  ALLOC_OBJECT(0x28d9463a108)
    //   0x28d97223af8  .ctor(ALLOC_OBJECT(0x28d9463a108), instructions, ?, ?)
    //   0x28d97223b28  WBARRIER((? add 0xffffffffffffff28), instructions)
    //   0x28d97223b58  ALLOC_OBJECT(0x28d96a24b48)
    //   0x28d97223b70  .ctor(ALLOC_OBJECT(0x28d96a24b48), instructions, ?, ?)
    //   0x28d97223ba0  WBARRIER(((? add 0xffffffffffffff28) add 0x10), instructions)
    //   0x28d97223bd0  ALLOC_OBJECT(0x28c86b41b40)
    //   0x28d97223c00  WBARRIER((ALLOC_OBJECT(0x28c86b41b40) add 0x10), instructions)
    //   0x28d97223c30  WBARRIER(((? add 0xffffffffffffff28) add 0x8), 0x28cc75df3c0)
    //   0x28d97223c90  ALLOC_OBJECT(0x28d94639310)
    //   0x28d97223cc8  WBARRIER((ALLOC_OBJECT(0x28d94639310) add 0x20), 0x28cc75df3c0)
    //   0x28d97223d48  WBARRIER(0x28c840e6548, 0x28d96a24da8.f28)
    //   0x28d97223d80  A30F7371EEB94415::AE910687FF9741D9((movsxd 0x0), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28))
    //   0x28d97223dc8  ALLOC_ARRAY(0x28d9463a3c0, 0x2)
    //   0x28d97223e58  ALLOC_OBJECT(0x28d9458e2f0)
    //   0x28d97223e80  .ctor(ALLOC_OBJECT(0x28d9458e2f0), (movsx 0x28cc7a09838.f0), ((? add 0xffffffffffffff28) xor (? add 0xffffffffffffff28)), ?)
    //   0x28d97223ec8  A30F7371EEB94415::76DC6F8B678D43D6(0x28d0b4907c0)   ; "E504ECB3C66148CC"
    //   0x28d97223f18  A30F7371EEB94415::9F129C4220FF4F40((movsxd (A30F7371EEB94415::AE910687FF9741D9((movsxd 0x0), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28)) l A30F7371EEB94415::AE910687FF9741D9((movsxd 0x0), ALLOC_OBJECT(0x28d9
    //   0x28d97223f88  ALLOC_OBJECT(0x28d94639310)
    //   0x28d97223fc0  WBARRIER((ALLOC_OBJECT(0x28d94639310) add 0x20), (0x1 xor 0x1))
    //   0x28d97224040  WBARRIER(0x28c840e6550, 0x28d96a24e08.f28)
    //   0x28d97224078  A30F7371EEB94415::AE910687FF9741D9((movsxd A30F7371EEB94415::AE910687FF9741D9((movsxd 0x0), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28))), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28))
    //   0x28d97224118  List`1::AddWithResize((rax xor rax), 0x28cf00ca780, 0x28cf00ca780, ALLOC_ARRAY(0x28d9463a3c0, 0x2))   ; "stloc WalkingPlayerInputPacket → HandleMovement + MisSimulatedPacket", "stloc WalkingPlayerInputPacket → HandleMove
    //   0x28d97224178  ALLOC_OBJECT(0x28d94639310)
    //   0x28d972241b0  WBARRIER((ALLOC_OBJECT(0x28d94639310) add 0x20), (movsxd (rax xor rax)))
    //   0x28d97224230  WBARRIER(0x28c840e6558, 0x28d96a24e68.f28)
    //   0x28d97224268  A30F7371EEB94415::AE910687FF9741D9((movsxd (movsxd (rax xor rax))), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28))
    //   0x28d97224290  ALLOC_ARRAY(0x28d9463a3c0, 0x3)
    //   0x28d97224308  ALLOC_OBJECT(0x28d9458e2f0)
    //   0x28d97224328  .ctor(ALLOC_OBJECT(0x28d9458e2f0), (movsx 0x28cc7a09838.f0), ((? add 0xffffffffffffff28) xor (? add 0xffffffffffffff28)), ALLOC_ARRAY(0x28d9463a3c0, 0x2))
    //   0x28d97224370  A30F7371EEB94415::476021DB46E44E95((? add 0xffffffffffffff28))
    //   0x28d972243b8  A30F7371EEB94415::76DC6F8B678D43D6(0x28d0b490780)   ; "61AEC9C3614E4DAE"
    //   0x28d97224410  A30F7371EEB94415::9F129C4220FF4F40(A30F7371EEB94415::AE910687FF9741D9((movsxd (movsxd (rax xor rax))), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28)), 0x1, 0x28cf00cbcb0, ALLOC_ARRAY(0x28d9463a3c0, 0x3))   ; "P
    //   0x28d97224470  ALLOC_OBJECT(0x28d94639310)
    //   0x28d972244a8  WBARRIER((ALLOC_OBJECT(0x28d94639310) add 0x20), (movsxd (rax xor rax)))
    //   0x28d97224528  WBARRIER(0x28c840e6560, 0x28d96a24ec8.f28)
    //   0x28d97224560  A30F7371EEB94415::AE910687FF9741D9((movsxd (movsxd (rax xor rax))), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28))
    //   0x28d97224588  ALLOC_ARRAY(0x28d9463a3c0, 0x3)
    //   0x28d97224600  ALLOC_OBJECT(0x28d9458e2f0)
    //   0x28d97224620  .ctor(ALLOC_OBJECT(0x28d9458e2f0), (movsx 0x28cc7a09838.f0), ((? add 0xffffffffffffff28) xor (? add 0xffffffffffffff28)), ALLOC_ARRAY(0x28d9463a3c0, 0x3))
    //   0x28d97224668  A30F7371EEB94415::476021DB46E44E95((? add 0xffffffffffffff28))
    //   0x28d972246b0  A30F7371EEB94415::76DC6F8B678D43D6(0x28d0b490740)   ; "539D9A90EEA84064"
    //   0x28d97224708  A30F7371EEB94415::9F129C4220FF4F40(A30F7371EEB94415::AE910687FF9741D9((movsxd (movsxd (rax xor rax))), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28)), 0x1, 0x28cf00ac7e0, ALLOC_ARRAY(0x28d9463a3c0, 0x3))   ; "l
    //   0x28d97224760  ALLOC_OBJECT(0x28d94639310)
    //   0x28d97224798  WBARRIER((ALLOC_OBJECT(0x28d94639310) add 0x20), 0x1)
    //   0x28d97224818  WBARRIER(0x28c840e6568, 0x28d96a24f28.f28)
    //   0x28d97224850  A30F7371EEB94415::AE910687FF9741D9((movsxd 0x0), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28))
    //   0x28d97224878  ALLOC_ARRAY(0x28d9463a3c0, 0x2)
    //   0x28d972248f0  ALLOC_OBJECT(0x28d9458e2f0)
    //   0x28d97224910  .ctor(ALLOC_OBJECT(0x28d9458e2f0), (movsx 0x28cc7a09838.f0), ((? add 0xffffffffffffff28) xor (? add 0xffffffffffffff28)), ALLOC_ARRAY(0x28d9463a3c0, 0x3))
    //   0x28d97224958  A30F7371EEB94415::76DC6F8B678D43D6(0x28d0b4906c0)   ; "DB2C7A7FEA8946E0"
    //   0x28d972249b0  A30F7371EEB94415::9F129C4220FF4F40(A30F7371EEB94415::AE910687FF9741D9((movsxd 0x0), ALLOC_OBJECT(0x28d94639310), (? add 0xffffffffffffff28)), 0x1, 0x28ccb084300, ALLOC_ARRAY(0x28d9463a3c0, 0x2))   ; "ldsfld onPluginKeyTi
    //   0x28d97224a10  ALLOC_OBJECT(0x28d96a25018)
    //   0x28d97224a48  WBARRIER((ALLOC_OBJECT(0x28d96a25018) add 0x20), (rax xor rax))
    //   0x28d97224ac8  WBARRIER(0x28c840e6570, 0x28d96a250e8.f28)
    //   0x28d97224af0  OrderByDescending((rax xor rax), ALLOC_OBJECT(0x28d96a25018), 0x28ccb084300, ALLOC_ARRAY(0x28d9463a3c0, 0x2))   ; "ldsfld onPluginKeyTick → TickEnd"
    //   0x28d97224be8  get_Item(ALLOC_OBJECT(0x28d9463a108), (movsxd S[rbp-68]), 0x28ccb084300, ALLOC_ARRAY(0x28d9463a3c0, 0x2))   ; "ldsfld onPluginKeyTick → TickEnd"
    //   0x28d97224c10  AddRange(S[rbp-60].f20.f18, get_Item(ALLOC_OBJECT(0x28d9463a108), (movsxd S[rbp-68]), 0x28ccb084300, ALLOC_ARRAY(0x28d9463a3c0, 0x2)).f18, 0x28ccb084300, ALLOC_ARRAY(0x28d9463a3c0, 0x2))   ; "ldsfld onPluginKeyTick → Tic
    //   0x28d97224c30  get_Item(ALLOC_OBJECT(0x28d9463a108), (movsxd S[rbp-68]), 0x28ccb084300, ALLOC_ARRAY(0x28d9463a3c0, 0x2))   ; "ldsfld onPluginKeyTick → TickEnd"
    //   0x28d97224c78  Array::Clear(get_Item(ALLOC_OBJECT(0x28d9463a108), (movsxd S[rbp-68]), 0x28ccb084300, ALLOC_ARRAY(0x28d9463a3c0, 0x2)).f18.f10, ((movsxd S[rbp-68]) xor (movsxd S[rbp-68])), (movsxd get_Item(ALLOC_OBJECT(0x28d9463a108), (
    //   0x28d97224ca8  InsertRange(ALLOC_OBJECT(0x28d9463a108), (movsxd S[rbp-68]), S[rbp-60], ALLOC_ARRAY(0x28d9463a3c0, 0x2))
    //   0x28d97224cdc  sub_28d97224d05(OrderByDescending((rax xor rax), ALLOC_OBJECT(0x28d96a25018), 0x28ccb084300, ALLOC_ARRAY(0x28d9463a3c0, 0x2)).f0, (movsxd S[rbp-68]), S[rbp-60], ALLOC_ARRAY(0x28d9463a3c0, 0x2))
    //   0x28d97224d00  sub_28b82785f1f(OrderByDescending((rax xor rax), ALLOC_OBJECT(0x28d96a25018), 0x28ccb084300, ALLOC_ARRAY(0x28d9463a3c0, 0x2)).f0, (movsxd S[rbp-68]), S[rbp-60], ALLOC_ARRAY(0x28d9463a3c0, 0x2))
    //   0x28d97224d60  1DB744298E9F4B09::C2FE386528B74E31((rax xor rax), (movsxd S[rbp-68]), S[rbp-60], ALLOC_ARRAY(0x28d9463a3c0, 0x2))
    //   0x28d97224d78  1DB744298E9F4B09::B9EB2EB9A0D34A59(1DB744298E9F4B09::C2FE386528B74E31((rax xor rax), (movsxd S[rbp-68]), S[rbp-60], ALLOC_ARRAY(0x28d9463a3c0, 0x2)), (movsxd S[rbp-68]), S[rbp-60], ALLOC_ARRAY(0x28d9463a3c0, 0x2))
    //   0x28d97224da8  ALLOC_ARRAY(0x28c8527bc08, 0x1)
    //   0x28d97224dd8  String::Join(0x28ccb73db80, (rax xor rax), S[rbp-60], ALLOC_ARRAY(0x28d9463a3c0, 0x2))   ; "; "
    //   0x28d97224e18  LoggerExtensions::LogError(1DB744298E9F4B09::B9EB2EB9A0D34A59(1DB744298E9F4B09::C2FE386528B74E31((rax xor rax), (movsxd S[rbp-68]), S[rbp-60], ALLOC_ARRAY(0x28d9463a3c0, 0x2)), (movsxd S[rbp-68]), S[rbp-60], ALLOC_ARRAY(
    //   0x28d97224e60  THROW(0x146, 0x2b1)
    //   0x28d97224e78  THROW(0x162, 0x45b)
    //   0x28d97224e90  THROW(0xf3, 0x4a2)
    // 51 store(s):
    //   0x28d97223b8c  ((? add 0xffffffffffffff28) add 0x10) <- ALLOC_OBJECT(0x28d96a24b48)
    //   0x28d97223bf2  (ALLOC_OBJECT(0x28c86b41b40) add 0x10) <- 0x28cc75df3c0
    //   0x28d97223c23  ((? add 0xffffffffffffff28) add 0x8) <- ALLOC_OBJECT(0x28c86b41b40)
    //   0x28d97223cad  ALLOC_OBJECT(0x28d94639310) <- 0x28cc9e00dd0
    //   0x28d97223ce3  ALLOC_OBJECT(0x28d94639310) <- 0x28d96676f70
    //   0x28d97223cf1  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24da0
    //   0x28d97223d03  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24da8.f28
    //   0x28d97223d0b  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24da8.f20
    //   0x28d97223d0f  ALLOC_OBJECT(0x28d94639310) <- 0x0
    //   0x28d97223d27  0x28c840e6548 <- ALLOC_OBJECT(0x28d94639310)
    //   0x28d97223fa5  ALLOC_OBJECT(0x28d94639310) <- 0x28cc9e00dd0
    //   0x28d97223fdb  ALLOC_OBJECT(0x28d94639310) <- 0x28d969508b8
    //   0x28d97223fe9  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24e00
    //   0x28d97223ffb  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24e08.f28
    //   0x28d97224003  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24e08.f20
    //   0x28d97224007  ALLOC_OBJECT(0x28d94639310) <- 0x0
    //   0x28d9722401f  0x28c840e6550 <- ALLOC_OBJECT(0x28d94639310)
    //   0x28d972240a2  (? add 0xffffffffffffff28) <- (movsxd 0xffffffff)
    //   0x28d972240d1  (rax xor rax) <- ((movsxd (rax xor rax).f1c) inc 0x1)
    //   0x28d972240eb  (rax xor rax) <- (movsxd (rax xor rax).f18)+1
    //   0x28d97224195  ALLOC_OBJECT(0x28d94639310) <- 0x28cc9e00dd0
    //   0x28d972241cb  ALLOC_OBJECT(0x28d94639310) <- 0x28d969508e0
    //   0x28d972241d9  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24e60
    //   0x28d972241eb  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24e68.f28
    //   0x28d972241f3  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24e68.f20
    //   0x28d972241f7  ALLOC_OBJECT(0x28d94639310) <- 0x0
    //   0x28d9722420f  0x28c840e6558 <- ALLOC_OBJECT(0x28d94639310)
    //   0x28d9722448d  ALLOC_OBJECT(0x28d94639310) <- 0x28cc9e00dd0
    //   0x28d972244c3  ALLOC_OBJECT(0x28d94639310) <- 0x28d96950920
    //   0x28d972244d1  ALLOC_OBJECT(0x28d94639310) <- 0x28d96a24ec0
    // returns: LoggerExtensions::LogError(1DB744298E9F4B09::B9EB2EB9A0D34A59(1DB744298E9F4B09::C2FE386528B74E31((rax xor rax), (movsxd S[rbp-68]), S[rbp-60], ALLOC_ARRAY(0x28d9463a3c0, 0x2)), (movsxd S[rbp-68]), S[r
    // string table refs:
    //   literal  "E504ECB3C66148CC"
    //   literal  "stfld pendingSecondaryAttackInput → TickStart"
    //   literal  "stloc WalkingPlayerInputPacket → HandleMovement + MisSimulatedPacket"
    //   literal  "61AEC9C3614E4DAE"
    //   literal  "PlayerMovement::simulate(9) → HandleMovement"
    //   literal  "539D9A90EEA84064"
    //   literal  "ldsfld SendSimulateMispredictedInputs → MisSimulatedPacket"
    //   literal  "DB2C7A7FEA8946E0"
    //   literal  "ldsfld onPluginKeyTick → TickEnd"
    //   literal  "; "
    //   literal  "PlayerInput.FixedUpdate: не найдены якоря [{A}] — детекты отключены"
    //   literal  "2804802979776"
    //   literal  "2804346043680"
    //   literal  "2804346038144"
    //   literal  "2804802979712"
    //   literal  "2804346043568"
    //   literal  "2804802979648"
    //   literal  "2804345915360"
    //   literal  "2804802979520"
    //   literal  "2803724993280"
    //   literal  "2803732044672"
    //   literal  "2804346037984"
}
