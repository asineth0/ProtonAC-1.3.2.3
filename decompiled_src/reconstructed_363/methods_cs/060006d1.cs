// ============================================================
// token 0x060006d1   F0CD1E00058640DE::.cctor
// native code: 0x28d970d26c0  (589 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed
//   
// native-calls: 0600105e,06000131,0600026d,06000953
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 15 call(s):
    //   0x28d970d26d8  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970d26f8  631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970d2728  WBARRIER(0x28c840e83f0, ?)
    //   0x28d970d2760  sub_28d95868d30(0x28d0d966cb0, 0x728, ?, ?)
    //   0x28d970d2780  A19CBF069C964833::99A93C8FCF084453(0x28c840e83f0.f0, sub_28d95868d30(0x28d0d966cb0, 0x728, ?, ?))
    //   0x28d970d27b0  WBARRIER(0x28c840e83f8, sub_28d95868d30(0x28d0d966cb0, 0x728, ?, ?))
    //   0x28d970d27c8  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970d27e8  631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970d2818  WBARRIER(0x28c840e8400, sub_28d95868d30(0x28d0d966cb0, 0x728, ?, ?))
    //   0x28d970d2838  ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d970d2868  WBARRIER((ALLOC_OBJECT(0x28c86f73f50) add 0x10), sub_28d95868d30(0x28d0d966cb0, 0x728, ?, ?))
    //   0x28d970d2898  WBARRIER(0x28c840e8408, sub_28d95868d30(0x28d0d966cb0, 0x728, ?, ?))
    //   0x28d970d28b8  ALLOC_OBJECT(0x28d9665c160)
    //   0x28d970d28d0  CD12FBF2EC134DF5::.ctor(ALLOC_OBJECT(0x28d9665c160))
    //   0x28d970d2900  WBARRIER(0x28c840e8410, sub_28d95868d30(0x28d0d966cb0, 0x728, ?, ?))
    // 6 store(s):
    //   0x28d970d2708  0x28c840e83f0 <- 631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970d2790  0x28c840e83f8 <- A19CBF069C964833::99A93C8FCF084453(0x28c840e83f0.f0, sub_28d95868d30(0x28d0d966cb0, 0x728, ?, ?))
    //   0x28d970d27f8  0x28c840e8400 <- 631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970d2854  (ALLOC_OBJECT(0x28c86f73f50) add 0x10) <- 0x28cc75df260
    //   0x28d970d287d  0x28c840e8408 <- ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d970d28e1  0x28c840e8410 <- ALLOC_OBJECT(0x28d9665c160)
    // returns: 0x28c840e8410
}
