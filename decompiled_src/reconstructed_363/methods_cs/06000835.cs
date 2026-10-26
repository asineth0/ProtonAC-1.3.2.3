// ============================================================
// token 0x06000835   269EE5A44F844EAA::.cctor
// native code: 0x28d970c62a0  (409 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed noinlining
//   
// native-calls: 0600105e,06000131,06000007,06000004,06000003
// native-strings: 0x1ea8:startedReload,0x1ebc:reloadTime
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 11 call(s):
    //   0x28d970c62b8  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970c62d8  631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970c6308  WBARRIER(0x28d0351cb00, ?)
    //   0x28d970c6330  <Module>::3F57E81A62734AC2(0xffffffffd8ea1d9f)   ; "startedReload"
    //   0x28d970c6340  FieldRefAccess(<Module>::3F57E81A62734AC2(0xffffffffd8ea1d9f), ?, ?, ?)
    //   0x28d970c6370  WBARRIER(0x28d0351cb08, ?)
    //   0x28d970c6398  <Module>::390073C602714496(0xfffffffff20d9449)   ; "reloadTime"
    //   0x28d970c63a8  FieldRefAccess(<Module>::390073C602714496(0xfffffffff20d9449), ?, ?, ?)
    //   0x28d970c63d8  WBARRIER(0x28d0351cb10, ?)
    //   0x28d970c63f8  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d970c6420  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    // 5 store(s):
    //   0x28d970c62e8  0x28d0351cb00 <- 631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970c6350  0x28d0351cb08 <- FieldRefAccess(<Module>::3F57E81A62734AC2(0xffffffffd8ea1d9f), ?, ?, ?)
    //   0x28d970c63b8  0x28d0351cb10 <- FieldRefAccess(<Module>::390073C602714496(0xfffffffff20d9449), ?, ?, ?)
    //   0x28d970c6408  0x28d0351cb18 <- <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)
    //   0x28d970c6430  0x28d0351cb19 <- <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)
    // returns: 0x28d0351cb19
    // string table refs:
    //   0x1ea8  "startedReload"
    //   0x1ebc  "reloadTime"
}
