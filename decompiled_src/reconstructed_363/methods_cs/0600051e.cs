// ============================================================
// token 0x0600051e   F101D9517BE2483D::<FixedUpdate_Transpiler>b__11_7
// native code: 0x28d97225c90  (443 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method assembly hidebysig
//   instance bool '<FixedUpdate_Transpiler>b__11_7' (
//   class ['0Harmony']HarmonyLib.CodeInstruction '16FCE213890F45AC'
//   ) cil managed
//   
// native-calls: 
// native-strings: ?:simulate,?:2804803197376
// ============================================================

 bool <FixedUpdate_Transpiler>b__11_7(HarmonyLib.CodeInstruction 16FCE213890F45AC)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d97225d60  op_Equality((movsx 16FCE213890F45AC+28.f0), (movsx 0x28cc7a09b98.f0), ?, ?)
    //   0x28d97225dc8  op_Equality((16FCE213890F45AC.f10 xor 16FCE213890F45AC.f10).f0, 0x28d0b4c59c0, ?, ?)   ; "simulate"
    //   0x28d97225e48  THROW(0x162, 0x1a1)
    // returns: ((movzx (movsxd (16FCE213890F45AC.f10 xor 16FCE213890F45AC.f10).f0.f18)) xor (movzx (movsxd (16FCE213890F45AC.f10 xor 16FCE213890F45AC.f10).f0.f18)))
    // string table refs:
    //   literal  "simulate"
    //   literal  "2804803197376"
}
