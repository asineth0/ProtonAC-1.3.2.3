// ============================================================
// token 0x060004ed   8BAADFBB2FC94256::4D7D3847E27541AE
// native code: 0x28d958665d0  (245 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   bool '4D7D3847E27541AE' () cil managed
//   
// native-calls: 06004969,06004a02
// native-strings: 
// ============================================================

public static bool 4D7D3847E27541AE()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 6 call(s):
    //   0x28d958665f8  sub_28b82782ba0(0x28d93eb50b8, ?, ?, ?)
    //   0x28d95866618  op_Inequality(0x28d0351ce60.f0, (xor ?), ?, ?)
    //   0x28d95866648  sub_28b82782ba0(0x28d93eb50b8, (xor ?), ?, ?)
    //   0x28d95866668  MethodInfo::op_Inequality(0x28d0351ce68.f0, ((xor ?) xor (xor ?)), ?, ?)
    //   0x28d95866698  sub_28b82782ba0(0x28d93eb50b8, ((xor ?) xor (xor ?)), ?, ?)
    //   0x28d958666b8  PropertyInfo::op_Inequality(0x28d0351ce70.f0, (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), ?, ?)
    // returns: (PropertyInfo::op_Inequality(0x28d0351ce70.f0, (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), ?, ?) xor PropertyInfo::op_Inequality(0x28d0351ce70.f0, (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?
}
