// ============================================================
// token 0x060006b0   C6338AE87AE0450D::.cctor
// native code: 0x28d970df9a0  (793 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed noinlining
//   
// native-calls: 06000005,06000007,06000003,06000004,06000006
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 12 call(s):
    //   0x28d970df9c8  <Module>::F84FA79ABE6944BB(0x535d8515)   ; =0
    //   0x28d970df9f8  <Module>::3F57E81A62734AC2(0xfffffffff5805bb4)   ; =0
    //   0x28d970dfac0  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d970dfaf8  <Module>::8B9C7B12B1AE4949(0xfffffffff7c2a15a)   ; =256
    //   0x28d970dfb30  <Module>::390073C602714496(0x3a2815d2)   ; =5
    //   0x28d970dfb58  <Module>::58ECCB512F2A43AC(0x4808bf97)   ; =2
    //   0x28d970dfb88  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d970dfbc0  <Module>::3F57E81A62734AC2(0xffffffff94857146)   ; =0
    //   0x28d970dfbf8  <Module>::8B9C7B12B1AE4949(0xffffffff9f38430e)   ; =10
    //   0x28d970dfc30  <Module>::58ECCB512F2A43AC(0x1505777c)   ; =0
    //   0x28d970dfc68  sub_28b82782ba0(0x28d96753730, ((((((((((0x4b17fb33 sub 0xe72948206d62b4a) sub 0xf19da7e3a0e3547b) sub 0x8ae91d70905a7d96) not 0x1) sub 0x466d1795fc31ff3c) xor 0x513ba72421a79eb) xor 0x28c18e0ebb41471c) imul 0x967d37b) d
    //   0x28d970dfca0  WBARRIER(0x28c840e83e8, ((((((((((0x4b17fb33 sub 0xe72948206d62b4a) sub 0xf19da7e3a0e3547b) sub 0x8ae91d70905a7d96) not 0x1) sub 0x466d1795fc31ff3c) xor 0x513ba72421a79eb) xor 0x28c18e0ebb41471c) imul 0x967d37b) div 0x7)
    // 10 store(s):
    //   0x28d970df9d8  0x28c840e83c0 <- <Module>::F84FA79ABE6944BB(0x535d8515)
    //   0x28d970dfad0  0x28c840e83e5 <- <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)
    //   0x28d970dfb08  0x28c840e83e0 <- <Module>::8B9C7B12B1AE4949(0xfffffffff7c2a15a)
    //   0x28d970dfb40  0x28c840e83d4 <- <Module>::390073C602714496(0x3a2815d2)
    //   0x28d970dfb68  0x28c840e83d8 <- <Module>::58ECCB512F2A43AC(0x4808bf97)
    //   0x28d970dfb98  0x28c840e83dc <- <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)
    //   0x28d970dfbd0  0x28c840e83e4 <- <Module>::3F57E81A62734AC2(0xffffffff94857146)
    //   0x28d970dfc08  0x28c840e83d0 <- <Module>::8B9C7B12B1AE4949(0xffffffff9f38430e)
    //   0x28d970dfc40  0x28c840e83e6 <- <Module>::58ECCB512F2A43AC(0x1505777c)
    //   0x28d970dfc82  0x28c840e83e8 <- 0x28d03f81b60.f0
    // returns: 0x28c840e83e8
}
