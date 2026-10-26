// ============================================================
// token 0x06000661   3301ED6AA1A1474A::.cctor
// native code: 0x28d970b6fc0  (1177 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed noinlining
//   
// native-calls: 0600105e,06000131,06000004,06000003,06000005,060006a7,06000007
// native-strings: 0x1724:TTT
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 24 call(s):
    //   0x28d970b6ff0  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970b7010  631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970b7040  WBARRIER(0x28c840e8480, ?)
    //   0x28d970b70c8  <Module>::390073C602714496(0x4da2eb80)   ; =2
    //   0x28d970b70e8  ALLOC_ARRAY(0x28c85396850, <Module>::390073C602714496(0x4da2eb80))
    //   0x28d970b7108  <Module>::8B9C7B12B1AE4949(0x14ddf994)   ; =1
    //   0x28d970b7128  <Module>::F84FA79ABE6944BB(0x67cf2da4)   ; =1
    //   0x28d970b7168  WBARRIER(0x28c840e84a0, <Module>::390073C602714496(0x4da2eb80))
    //   0x28d970b7198  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d970b71c8  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d970b71f0  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970b7210  631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970b7240  WBARRIER(0x28c840e8488, <Module>::390073C602714496(0x4da2eb80))
    //   0x28d970b7290  <Module>::390073C602714496(0xffffffffcb9a955f)   ; "TTT"
    //   0x28d970b72a8  3301ED6AA1A1474A::A636D00EF74944C6(0x28c840e8488.f0, <Module>::390073C602714496(0xffffffffcb9a955f))
    //   0x28d970b72d8  WBARRIER(0x28c840e8490, <Module>::390073C602714496(0xffffffffcb9a955f))
    //   0x28d970b72f8  <Module>::390073C602714496(0x4da2eb80)   ; =2
    //   0x28d970b7318  ALLOC_ARRAY(0x28cc7f69d88, <Module>::390073C602714496(0x4da2eb80))
    //   0x28d970b7340  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d970b7360  <Module>::3F57E81A62734AC2(0xffffffffa1648114)   ; =-1082130432
    //   0x28d970b7398  <Module>::F84FA79ABE6944BB(0x67cf2da4)   ; =1
    //   0x28d970b73b8  <Module>::3F57E81A62734AC2(0xffffffffaef4be5f)   ; =1065353216
    //   0x28d970b7400  WBARRIER(0x28c840e8498, <Module>::390073C602714496(0x4da2eb80))
    //   0x28d970b7448  THROW(0x146, 0x85)
    // 8 store(s):
    //   0x28d970b7020  0x28c840e8480 <- 631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970b7140  ALLOC_ARRAY(0x28c85396850, <Module>::390073C602714496(0x4da2eb80))+(movsxd <Module>::8B9C7B12B1AE4949(0x14ddf994))*1+20 <- <Module>::F84FA79ABE6944BB(0x67cf2da4)
    //   0x28d970b714d  0x28c840e84a0 <- ALLOC_ARRAY(0x28c85396850, <Module>::390073C602714496(0x4da2eb80))
    //   0x28d970b71a8  0x28c840e84a8 <- <Module>::390073C602714496(0x7f132d63)
    //   0x28d970b71d8  0x28c840e84a9 <- <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)
    //   0x28d970b7220  0x28c840e8488 <- 631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970b72b8  0x28c840e8490 <- 3301ED6AA1A1474A::A636D00EF74944C6(0x28c840e8488.f0, <Module>::390073C602714496(0xffffffffcb9a955f))
    //   0x28d970b73e3  0x28c840e8498 <- ALLOC_ARRAY(0x28cc7f69d88, <Module>::390073C602714496(0x4da2eb80))
    // returns: 0x28c840e8498
    // string table refs:
    //   0x1724  "TTT"
}
