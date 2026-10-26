// ============================================================
// token 0x0600093f   087B17044C8447C2::860B6225B78349C7
// native code: 0x28d95a3a680  (180 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   void '860B6225B78349C7' (
//   class [ProtonAC.Microsoft.Extensions.Configuration.Abstractions]Microsoft.Extensions.Configuration.IConfiguration ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public static void 860B6225B78349C7(Microsoft.Extensions.Configuration.IConfiguration arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a3a6a8  sub_28d95868d30(0x28d0d966cb0, 0x2ff8, ?, ?)
    //   0x28d95a3a6c8  GetValue(arg0, sub_28d95868d30(0x28d0d966cb0, 0x2ff8, ?, ?), 0x200, ?)
    //   0x28d95a3a6f8  sub_28d95868d30(0x28d0d966cb0, 0x3056, 0x200, ?)
    //   0x28d95a3a718  GetValue(arg0, sub_28d95868d30(0x28d0d966cb0, 0x3056, 0x200, ?), 0x180, ?)
    // 2 store(s):
    //   0x28d95a3a6d8  0x28d96129e48 <- GetValue(arg0, sub_28d95868d30(0x28d0d966cb0, 0x2ff8, ?, ?), 0x200, ?)
    //   0x28d95a3a728  0x28d96129e4c <- GetValue(arg0, sub_28d95868d30(0x28d0d966cb0, 0x3056, 0x200, ?), 0x180, ?)
    // returns: 0x28d96129e4c
}
