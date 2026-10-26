// ============================================================
// token 0x06000269   A19CBF069C964833::5E5A0EFC450B41F2
// native code: 0x28d95a3ef70  (185 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname
//   instance valuetype [netstandard]System.Threading.CancellationToken '5E5A0EFC450B41F2' () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

 Threading.CancellationToken 5E5A0EFC450B41F2()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a3efc8  sub_28c8598bdd0(0x13a67, ?, ?, ?)
    //   0x28d95a3efe0  sub_7fff673b5cf0(0x2000168, (xor ?), sub_28c8598bdd0(0x13a67, ?, ?, ?), ?)
    //   0x28d95a3eff0  ?(sub_7fff673b5cf0(0x2000168, (xor ?), sub_28c8598bdd0(0x13a67, ?, ?, ?), ?), (xor ?), sub_28c8598bdd0(0x13a67, ?, ?, ?), ?)
    //   0x28d95a3f010  WBARRIER((? add 0xffffffffffffffe8), (xor ?))
    // returns: this.f20
}
