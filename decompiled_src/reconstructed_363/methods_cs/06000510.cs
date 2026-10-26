// ============================================================
// token 0x06000510   A30F7371EEB94415::76DC6F8B678D43D6
// native code: 0x28d972253d0  (205 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method assembly hidebysig static
//   class ['0Harmony']HarmonyLib.CodeInstruction '76DC6F8B678D43D6' (
//   string m
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

static HarmonyLib.CodeInstruction 76DC6F8B678D43D6(string m)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d97225450  Method(0x28ccc6f3f60, m, (xor ?), (xor ?))
    //   0x28d97225470  ALLOC_OBJECT(0x28d9458e2f0)
    //   0x28d97225490  .ctor(ALLOC_OBJECT(0x28d9458e2f0), (movsx 0x28cc7a09960.f0), Method(0x28ccc6f3f60, m, (xor ?), (xor ?)), (xor ?))
    // returns: ALLOC_OBJECT(0x28d9458e2f0)
}
