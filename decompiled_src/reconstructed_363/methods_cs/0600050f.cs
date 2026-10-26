// ============================================================
// token 0x0600050f   A30F7371EEB94415::BE26B69C1917471A
// native code: 0x28d972252a0  (283 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method assembly hidebysig static
//   bool BE26B69C1917471A (
//   class ['0Harmony']HarmonyLib.CodeInstruction c,
//   valuetype [netstandard]System.Reflection.Emit.OpCode op,
//   string n
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

static bool BE26B69C1917471A(HarmonyLib.CodeInstruction c, Reflection.Emit.OpCode op, string n)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d97225328  op_Equality((movsx c+28.f0), op, n, ?)
    //   0x28d97225388  op_Equality((c.f10 xor c.f10).f0, n, n, ?)
    //   0x28d972253b8  THROW(0x162, 0xf9)
    // returns: (op_Equality((c.f10 xor c.f10).f0, n, n, ?) xor op_Equality((c.f10 xor c.f10).f0, n, n, ?))
}
