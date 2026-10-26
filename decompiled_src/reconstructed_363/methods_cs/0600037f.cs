// ============================================================
// token 0x0600037f   B7097FC49A384CFA::.cctor
// native code: 0x28d97016b90  (370 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed noinlining
//   
// native-calls: 06000005,06000004,06000003
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 6 call(s):
    //   0x28d97016bc0  <Module>::F84FA79ABE6944BB(0x6646d7d2)   ; =0
    //   0x28d97016bd0  FromSeconds(0x6646d7d2, ?, ?, ?)
    //   0x28d97016c70  <Module>::390073C602714496(0xffffffffe5279675)   ; =0
    //   0x28d97016c80  FromSeconds(0xffffffffe5279675, (((((0x1f76fb5 imul 0xe59fdbf7) add 0x8c11be2409216049) xor 0x1b6d1a9eebcf501c) div 0x3) mod 0x3), ?, ?)
    //   0x28d97016cc8  <Module>::8B9C7B12B1AE4949(0xffffffffde86eb8d)   ; =0
    //   0x28d97016cd8  FromSeconds(0xffffffffde86eb8d, (((((0x1f76fb5 imul 0xe59fdbf7) add 0x8c11be2409216049) xor 0x1b6d1a9eebcf501c) div 0x3) mod 0x3), ?, ?)
    // 3 store(s):
    //   0x28d97016be5  0x28d0351ccc0 <- FromSeconds(0x6646d7d2, ?, ?, ?)
    //   0x28d97016c95  0x28d0351ccc8 <- FromSeconds(0xffffffffe5279675, (((((0x1f76fb5 imul 0xe59fdbf7) add 0x8c11be2409216049) xor 0x1b6d1a9eebcf501c) div 0x3) mod 0x3), ?, ?)
    //   0x28d97016ced  0x28d0351ccd0 <- FromSeconds(0xffffffffde86eb8d, (((((0x1f76fb5 imul 0xe59fdbf7) add 0x8c11be2409216049) xor 0x1b6d1a9eebcf501c) div 0x3) mod 0x3), ?, ?)
    // returns: 0x28d0351ccd0
}
