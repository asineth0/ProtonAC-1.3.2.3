// ============================================================
// token 0x060004e8   40273E31A09B48E7::.cctor
// native code: 0x28d97013a90  (1517 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 36 call(s):
    //   0x28d97013aa8  get_ASCII(?, ?, ?, ?)
    //   0x28d97013ad0  sub_28d95868d30(0x28d0d966cb0, 0x914, ?, ?)
    //   0x28d97013b18  WBARRIER(0x28c859c4960, sub_28d95868d30(0x28d0d966cb0, 0x914, ?, ?))
    //   0x28d97013b30  get_ASCII(0x28c859c4960, sub_28d95868d30(0x28d0d966cb0, 0x914, ?, ?), ?, ?)
    //   0x28d97013b58  sub_28d95868d30(0x28d0d966cb0, 0x91e, ?, ?)
    //   0x28d97013ba0  WBARRIER(0x28c859c4968, sub_28d95868d30(0x28d0d966cb0, 0x91e, ?, ?))
    //   0x28d97013bb8  get_ASCII(0x28c859c4968, sub_28d95868d30(0x28d0d966cb0, 0x91e, ?, ?), ?, ?)
    //   0x28d97013be0  sub_28d95868d30(0x28d0d966cb0, 0x928, ?, ?)
    //   0x28d97013c28  WBARRIER(0x28c859c4970, sub_28d95868d30(0x28d0d966cb0, 0x928, ?, ?))
    //   0x28d97013c40  get_ASCII(0x28c859c4970, sub_28d95868d30(0x28d0d966cb0, 0x928, ?, ?), ?, ?)
    //   0x28d97013c68  sub_28d95868d30(0x28d0d966cb0, 0x934, ?, ?)
    //   0x28d97013cb0  WBARRIER(0x28c859c4978, sub_28d95868d30(0x28d0d966cb0, 0x934, ?, ?))
    //   0x28d97013cc8  get_ASCII(0x28c859c4978, sub_28d95868d30(0x28d0d966cb0, 0x934, ?, ?), ?, ?)
    //   0x28d97013ce8  sub_28d95868d30(0x28d0d966cb0, 0x93a, ?, ?)
    //   0x28d97013d28  WBARRIER(0x28c859c4980, sub_28d95868d30(0x28d0d966cb0, 0x93a, ?, ?))
    //   0x28d97013d40  get_ASCII(0x28c859c4980, sub_28d95868d30(0x28d0d966cb0, 0x93a, ?, ?), ?, ?)
    //   0x28d97013d60  sub_28d95868d30(0x28d0d966cb0, 0x940, ?, ?)
    //   0x28d97013da0  WBARRIER(0x28c859c4988, sub_28d95868d30(0x28d0d966cb0, 0x940, ?, ?))
    //   0x28d97013db8  get_ASCII(0x28c859c4988, sub_28d95868d30(0x28d0d966cb0, 0x940, ?, ?), ?, ?)
    //   0x28d97013dd8  sub_28d95868d30(0x28d0d966cb0, 0x946, ?, ?)
    //   0x28d97013e18  WBARRIER(0x28c859c4990, sub_28d95868d30(0x28d0d966cb0, 0x946, ?, ?))
    //   0x28d97013e30  get_ASCII(0x28c859c4990, sub_28d95868d30(0x28d0d966cb0, 0x946, ?, ?), ?, ?)
    //   0x28d97013e50  sub_28d95868d30(0x28d0d966cb0, 0x94c, ?, ?)
    //   0x28d97013e90  WBARRIER(0x28c859c4998, sub_28d95868d30(0x28d0d966cb0, 0x94c, ?, ?))
    //   0x28d97013ea8  get_ASCII(0x28c859c4998, sub_28d95868d30(0x28d0d966cb0, 0x94c, ?, ?), ?, ?)
    //   0x28d97013ec8  sub_28d95868d30(0x28d0d966cb0, 0x952, ?, ?)
    //   0x28d97013f08  WBARRIER(0x28c859c49a0, sub_28d95868d30(0x28d0d966cb0, 0x952, ?, ?))
    //   0x28d97013f20  get_ASCII(0x28c859c49a0, sub_28d95868d30(0x28d0d966cb0, 0x952, ?, ?), ?, ?)
    //   0x28d97013f40  sub_28d95868d30(0x28d0d966cb0, 0x958, ?, ?)
    //   0x28d97013f80  WBARRIER(0x28c859c49a8, sub_28d95868d30(0x28d0d966cb0, 0x958, ?, ?))
    //   0x28d97013fa0  ALLOC_ARRAY(0x28c851b3688, 0x3)
    //   0x28d97013fc8  memcpy((ALLOC_ARRAY(0x28c851b3688, 0x3) add 0x20), 0x28d95b7bbf8, 0x3, ?)
    //   0x28d97013ff8  WBARRIER(0x28c859c49b0, 0x28d95b7bbf8)
    //   0x28d97014010  get_ASCII(0x28c859c49b0, 0x28d95b7bbf8, 0x3, ?)
    //   0x28d97014030  sub_28d95868d30(0x28d0d966cb0, 0x95e, 0x3, ?)
    //   0x28d97014070  WBARRIER(0x28c859c49b8, sub_28d95868d30(0x28d0d966cb0, 0x95e, 0x3, ?))
    // 12 store(s):
    //   0x28d97013af6  0x28c859c4960 <- get_ASCII(?, ?, ?, ?).f0
    //   0x28d97013b7e  0x28c859c4968 <- get_ASCII(0x28c859c4960, sub_28d95868d30(0x28d0d966cb0, 0x914, ?, ?), ?, ?).f0
    //   0x28d97013c06  0x28c859c4970 <- get_ASCII(0x28c859c4968, sub_28d95868d30(0x28d0d966cb0, 0x91e, ?, ?), ?, ?).f0
    //   0x28d97013c8e  0x28c859c4978 <- get_ASCII(0x28c859c4970, sub_28d95868d30(0x28d0d966cb0, 0x928, ?, ?), ?, ?).f0
    //   0x28d97013d0b  0x28c859c4980 <- get_ASCII(0x28c859c4978, sub_28d95868d30(0x28d0d966cb0, 0x934, ?, ?), ?, ?).f0
    //   0x28d97013d83  0x28c859c4988 <- get_ASCII(0x28c859c4980, sub_28d95868d30(0x28d0d966cb0, 0x93a, ?, ?), ?, ?).f0
    //   0x28d97013dfb  0x28c859c4990 <- get_ASCII(0x28c859c4988, sub_28d95868d30(0x28d0d966cb0, 0x940, ?, ?), ?, ?).f0
    //   0x28d97013e73  0x28c859c4998 <- get_ASCII(0x28c859c4990, sub_28d95868d30(0x28d0d966cb0, 0x946, ?, ?), ?, ?).f0
    //   0x28d97013eeb  0x28c859c49a0 <- get_ASCII(0x28c859c4998, sub_28d95868d30(0x28d0d966cb0, 0x94c, ?, ?), ?, ?).f0
    //   0x28d97013f63  0x28c859c49a8 <- get_ASCII(0x28c859c49a0, sub_28d95868d30(0x28d0d966cb0, 0x952, ?, ?), ?, ?).f0
    //   0x28d97013fd9  0x28c859c49b0 <- ALLOC_ARRAY(0x28c851b3688, 0x3)
    //   0x28d97014053  0x28c859c49b8 <- get_ASCII(0x28c859c49b0, 0x28d95b7bbf8, 0x3, ?).f0
    // returns: 0x28c859c49b8
}
