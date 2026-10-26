// ============================================================
// token 0x06000642   BE3140E5E8934376::.cctor
// native code: 0x28d970c5b20  (193 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed noinlining
//   
// native-calls: 0600105e,06000131,06000004,06000003
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d970c5b38  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970c5b58  631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970c5b88  WBARRIER(0x28d03f81d10, ?)
    //   0x28d970c5ba0  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d970c5bc8  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    // 3 store(s):
    //   0x28d970c5b68  0x28d03f81d10 <- 631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970c5bb0  0x28d03f81d18 <- <Module>::390073C602714496(0x7f132d63)
    //   0x28d970c5bd8  0x28d03f81d19 <- <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)
    // returns: 0x28d03f81d19
}
