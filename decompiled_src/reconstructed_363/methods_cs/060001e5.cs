// ============================================================
// token 0x060001e5   52E00C0CB6ED438D::561BAC91D5264080
// native code: 0x28d958c5f80  (690 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   string '561BAC91D5264080' () cil managed
//   
// native-calls: 
// native-strings: ?:2803663050144,?:2803664465760,?:2803705236160
// ============================================================

public static string 561BAC91D5264080()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d958c6150  Join((? add 0xffffffffffffffd0), (? add 0xffffffffffffffc0), ?, ?)
    //   0x28d958c6198  op_Inequality(0x28c859be6f0.f0, (0x28cc9dacac0 xor 0x28cc9dacac0), 0x28, ?)
    //   0x28d958c6228  THROW(0x162, 0x16d)
    // returns: (0x28c859be6f0.f0.f0 xor 0x28c859be6f0.f0.f0).f18
    // string table refs:
    //   literal  "2803663050144"
    //   literal  "2803664465760"
    //   literal  "2803705236160"
}
