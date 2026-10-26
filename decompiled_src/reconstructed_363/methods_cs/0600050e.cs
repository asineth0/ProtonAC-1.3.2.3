// ============================================================
// token 0x0600050e   A30F7371EEB94415::9F129C4220FF4F40
// native code: 0x28d972254b0  (459 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method assembly hidebysig static
//   void '9F129C4220FF4F40' (
//   int32 'at',
//   bool moveLabels,
//   string anchor,
//   class ['0Harmony']HarmonyLib.CodeInstruction[] code,
//   valuetype A30F7371EEB94415/EE4415A3944348F7& ''
//   ) cil managed
//   
// native-calls: 06006153
// native-strings: 
// ============================================================

static void 9F129C4220FF4F40(int at, bool moveLabels, string anchor, HarmonyLib.CodeInstruction code, A30F7371EEB94415.EE4415A3944348F7& arg4)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d97225540  List`1::AddWithResize(S[rbp+30].f8, anchor, anchor, code)
    //   0x28d97225578  .ctor((? add 0xffffffffffffff98), (movsxd S[rbp+30].f8.f18), S[rbp+30].f8.f10, code)
    //   0x28d97225608  WBARRIER((((S[rbp+30].f8.f10.f10 add ((movsxd (movsxd S[rbp+30].f8.f10.f18)) shl 0x4)) add 0x20) add 0x8), (movsxd S[rbp+30].f8.f18))
    //   0x28d97225640  AddWithResize(S[rbp+30].f8.f10, (? add 0xffffffffffffffc8), S[rbp+30].f8.f10, code)
    //   0x28d97225678  THROW(0x146, 0xa8)
    // 6 store(s):
    //   0x28d972254f8  S[rbp+30].f8 <- ((movsxd S[rbp+30].f8.f1c) inc 0x1)
    //   0x28d97225512  S[rbp+30].f8 <- (movsxd S[rbp+30].f8.f18)+1
    //   0x28d972255ab  S[rbp+30].f8.f10 <- ((movsxd S[rbp+30].f8.f10.f1c) inc 0x1)
    //   0x28d972255c9  S[rbp+30].f8.f10 <- (movsxd S[rbp+30].f8.f10.f18)+1
    //   0x28d972255eb  ((S[rbp+30].f8.f10.f10 add ((movsxd (movsxd S[rbp+30].f8.f10.f18)) shl 0x4)) add 0x20) <- (S[rbp+30].f8.f10 xor S[rbp+30].f8.f10)
    //   0x28d972255fa  (((S[rbp+30].f8.f10.f10 add ((movsxd (movsxd S[rbp+30].f8.f10.f18)) shl 0x4)) add 0x20) add 0x8) <- (S[rbp+30].f8.f10 xor S[rbp+30].f8.f10)
    // returns: AddWithResize(S[rbp+30].f8.f10, (? add 0xffffffffffffffc8), S[rbp+30].f8.f10, code)
}
