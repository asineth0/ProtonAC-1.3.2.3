// ============================================================
// token 0x06000566   2A320E2F1A3D4AAC::54D7989141C24A59
// native code: 0x28d972d9040  (173 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   void '54D7989141C24A59' (
//   class [ProtonAC.Microsoft.Extensions.Configuration.Abstractions]Microsoft.Extensions.Configuration.IConfiguration C9B177373F5A4A95
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public static void 54D7989141C24A59(Microsoft.Extensions.Configuration.IConfiguration C9B177373F5A4A95)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d972d9068  sub_28d95868d30(0x28d0d966cb0, 0x122e, ?, ?)
    //   0x28d972d9088  GetValue(C9B177373F5A4A95, sub_28d95868d30(0x28d0d966cb0, 0x122e, ?, ?), 0x1, ?)
    //   0x28d972d90b8  sub_28d95868d30(0x28d0d966cb0, 0x1280, 0x1, ?)
    //   0x28d972d90d0  GetValue(C9B177373F5A4A95, sub_28d95868d30(0x28d0d966cb0, 0x1280, 0x1, ?), (0x1 xor 0x1), ?)
    // 2 store(s):
    //   0x28d972d9098  0x28ccb6edd08 <- GetValue(C9B177373F5A4A95, sub_28d95868d30(0x28d0d966cb0, 0x122e, ?, ?), 0x1, ?)
    //   0x28d972d90e0  0x28ccb6edd09 <- GetValue(C9B177373F5A4A95, sub_28d95868d30(0x28d0d966cb0, 0x1280, 0x1, ?), (0x1 xor 0x1), ?)
    // returns: 0x28ccb6edd09
}
