// ============================================================
// token 0x06000568   2A320E2F1A3D4AAC::.cctor
// native code: 0x28d9722e280  (2258 bytes)
// kind: SMALL_CALL   confidence: outline
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed
//   
// native-calls: 060000b0,06000131,0600026d,06000965
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 58 call(s):
    //   0x28d9722e298  1DB744298E9F4B09::C2FE386528B74E31()
    //   0x28d9722e2b8  631D551E2DA64E7D::F3B62BCE1450413B(1DB744298E9F4B09::C2FE386528B74E31().f68)
    //   0x28d9722e2e8  WBARRIER(0x28ccb6edc60, ?)
    //   0x28d9722e320  sub_28d95868d30(0x28d0d966cb0, 0x750, ?, ?)
    //   0x28d9722e340  A19CBF069C964833::99A93C8FCF084453(0x28ccb6edc60.f0, sub_28d95868d30(0x28d0d966cb0, 0x750, ?, ?))
    //   0x28d9722e370  WBARRIER(0x28ccb6edc68, sub_28d95868d30(0x28d0d966cb0, 0x750, ?, ?))
    //   0x28d9722e3a8  sub_28d95868d30(0x28d0d966cb0, 0x758, ?, ?)
    //   0x28d9722e3c8  A19CBF069C964833::99A93C8FCF084453(0x28ccb6edc60.f0, sub_28d95868d30(0x28d0d966cb0, 0x758, ?, ?))
    //   0x28d9722e3f8  WBARRIER(0x28ccb6edc70, sub_28d95868d30(0x28d0d966cb0, 0x758, ?, ?))
    //   0x28d9722e430  sub_28d95868d30(0x28d0d966cb0, 0x760, ?, ?)
    //   0x28d9722e450  A19CBF069C964833::99A93C8FCF084453(0x28ccb6edc60.f0, sub_28d95868d30(0x28d0d966cb0, 0x760, ?, ?))
    //   0x28d9722e480  WBARRIER(0x28ccb6edc78, sub_28d95868d30(0x28d0d966cb0, 0x760, ?, ?))
    //   0x28d9722e4a8  sub_28d95868d30(0x28d0d966cb0, 0x12be, ?, ?)
    //   0x28d9722e4c8  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x12be, ?, ?), 0x12be, ?, ?)
    //   0x28d9722e4f8  WBARRIER(0x28ccb6edc80, 0x12be)
    //   0x28d9722e520  sub_28d95868d30(0x28d0d966cb0, 0x1300, ?, ?)
    //   0x28d9722e540  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1300, ?, ?), 0x1300, ?, ?)
    //   0x28d9722e570  WBARRIER(0x28ccb6edc88, 0x1300)
    //   0x28d9722e590  sub_28d95868d30(0x28d0d966cb0, 0x131e, ?, ?)
    //   0x28d9722e5b0  Method(0x28cc7529510, sub_28d95868d30(0x28d0d966cb0, 0x131e, ?, ?), (xor ?), (xor ?))
    //   0x28d9722e5d8  MethodDelegate(Method(0x28cc7529510, sub_28d95868d30(0x28d0d966cb0, 0x131e, ?, ?), (xor ?), (xor ?)), (sub_28d95868d30(0x28d0d966cb0, 0x131e, ?, ?) xor sub_28d95868d30(0x28d0d966cb0, 0x131e, ?, ?)), 0x1, (xor ?))
    //   0x28d9722e608  WBARRIER(0x28ccb6edc90, (sub_28d95868d30(0x28d0d966cb0, 0x131e, ?, ?) xor sub_28d95868d30(0x28d0d966cb0, 0x131e, ?, ?)))
    //   0x28d9722e628  sub_28d95868d30(0x28d0d966cb0, 0x1334, 0x1, (xor ?))
    //   0x28d9722e638  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1334, 0x1, (xor ?)), 0x1334, 0x1, (xor ?))
    //   0x28d9722e668  WBARRIER(0x28ccb6edc98, 0x1334)
    //   0x28d9722e688  sub_28d95868d30(0x28d0d966cb0, 0x1368, 0x1, (xor ?))
    //   0x28d9722e698  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1368, 0x1, (xor ?)), 0x1368, 0x1, (xor ?))
    //   0x28d9722e6c8  WBARRIER(0x28ccb6edca0, 0x1368)
    //   0x28d9722e6e8  sub_28d95868d30(0x28d0d966cb0, 0x1376, 0x1, (xor ?))
    //   0x28d9722e708  Field(0x28c859c7cf0, sub_28d95868d30(0x28d0d966cb0, 0x1376, 0x1, (xor ?)), 0x1, (xor ?))
    //   0x28d9722e718  StaticFieldRefAccess(Field(0x28c859c7cf0, sub_28d95868d30(0x28d0d966cb0, 0x1376, 0x1, (xor ?)), 0x1, (xor ?)), sub_28d95868d30(0x28d0d966cb0, 0x1376, 0x1, (xor ?)), 0x1, (xor ?))
    //   0x28d9722e748  WBARRIER(0x28ccb6edca8, sub_28d95868d30(0x28d0d966cb0, 0x1376, 0x1, (xor ?)))
    //   0x28d9722e768  sub_28d95868d30(0x28d0d966cb0, 0x137e, 0x1, (xor ?))
    //   0x28d9722e778  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x137e, 0x1, (xor ?)), 0x137e, 0x1, (xor ?))
    //   0x28d9722e7a8  WBARRIER(0x28ccb6edcb0, 0x137e)
    //   0x28d9722e7c8  ALLOC_OBJECT(0x28c86cc1be0)
    //   0x28d9722e818  Get(ALLOC_OBJECT(0x28c86cc1be0), 0x28c86cc1cb0.f28, 0x1, (xor ?))
    //   0x28d9722e848  WBARRIER(0x28ccb6edcb8, 0x28c86cc1cb0.f28)
    //   0x28d9722e868  sub_28d95868d30(0x28d0d966cb0, 0x13ac, 0x1, (xor ?))
    //   0x28d9722e888  Method(0x28cc7527e70, sub_28d95868d30(0x28d0d966cb0, 0x13ac, 0x1, (xor ?)), (0x1 xor 0x1), ((xor ?) xor (xor ?)))
    //   0x28d9722e8b0  MethodDelegate(Method(0x28cc7527e70, sub_28d95868d30(0x28d0d966cb0, 0x13ac, 0x1, (xor ?)), (0x1 xor 0x1), ((xor ?) xor (xor ?))), (sub_28d95868d30(0x28d0d966cb0, 0x13ac, 0x1, (xor ?)) xor sub_28d95868d30(0x28d0d966cb0, 0
    //   0x28d9722e8e0  WBARRIER(0x28ccb6edcc0, (sub_28d95868d30(0x28d0d966cb0, 0x13ac, 0x1, (xor ?)) xor sub_28d95868d30(0x28d0d966cb0, 0x13ac, 0x1, (xor ?))))
    //   0x28d9722e900  sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d9722e920  Method(0x28c859c7cf0, sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?))), (0x1 xor 0x1), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))))
    //   0x28d9722e948  MethodDelegate(Method(0x28c859c7cf0, sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?))), (0x1 xor 0x1), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?)))), (sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((x
    //   0x28d9722e978  WBARRIER(0x28ccb6edcc8, (sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?))) xor sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?)))))
    //   0x28d9722e998  ALLOC_OBJECT(0x28d96c89600)
    //   0x28d9722e9b0  .ctor(ALLOC_OBJECT(0x28d96c89600), (sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?))) xor sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?)))), 0x1, (((xor ?) xor (xor ?)) xor ((xor ?) xor
    //   0x28d9722e9e0  WBARRIER(0x28ccb6edcd0, (sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?))) xor sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?)))))
    //   0x28d9722ea00  ALLOC_ARRAY(0x28d96c897c8, 0x1f4)
    //   0x28d9722ea30  WBARRIER(0x28ccb6edcd8, 0x1f4)
    //   0x28d9722ea50  ALLOC_ARRAY(0x28d96c897c8, 0x1f4)
    //   0x28d9722ea80  WBARRIER(0x28ccb6edce0, 0x1f4)
    //   0x28d9722eaa0  ALLOC_ARRAY(0x28d96c897c8, 0x1f4)
    //   0x28d9722ead0  WBARRIER(0x28ccb6edce8, 0x1f4)
    //   0x28d9722eaf0  ALLOC_OBJECT(0x28d96c89958)
    //   0x28d9722eb08  0732D1C8FF584BB5::.ctor(ALLOC_OBJECT(0x28d96c89958))
    //   0x28d9722eb38  WBARRIER(0x28ccb6edd00, 0x1f4)
    // 25 store(s):
    //   0x28d9722e2c8  0x28ccb6edc60 <- 631D551E2DA64E7D::F3B62BCE1450413B(1DB744298E9F4B09::C2FE386528B74E31().f68)
    //   0x28d9722e350  0x28ccb6edc68 <- A19CBF069C964833::99A93C8FCF084453(0x28ccb6edc60.f0, sub_28d95868d30(0x28d0d966cb0, 0x750, ?, ?))
    //   0x28d9722e3d8  0x28ccb6edc70 <- A19CBF069C964833::99A93C8FCF084453(0x28ccb6edc60.f0, sub_28d95868d30(0x28d0d966cb0, 0x758, ?, ?))
    //   0x28d9722e460  0x28ccb6edc78 <- A19CBF069C964833::99A93C8FCF084453(0x28ccb6edc60.f0, sub_28d95868d30(0x28d0d966cb0, 0x760, ?, ?))
    //   0x28d9722e4d8  0x28ccb6edc80 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x12be, ?, ?), 0x12be, ?, ?)
    //   0x28d9722e550  0x28ccb6edc88 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1300, ?, ?), 0x1300, ?, ?)
    //   0x28d9722e5e8  0x28ccb6edc90 <- MethodDelegate(Method(0x28cc7529510, sub_28d95868d30(0x28d0d966cb0, 0x131e, ?, ?), (xor ?), (xor ?)), (sub_28d95868d30(0x28d0d966cb0, 0x131e, ?, ?) xor sub_28d9
    //   0x28d9722e648  0x28ccb6edc98 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1334, 0x1, (xor ?)), 0x1334, 0x1, (xor ?))
    //   0x28d9722e6a8  0x28ccb6edca0 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1368, 0x1, (xor ?)), 0x1368, 0x1, (xor ?))
    //   0x28d9722e728  0x28ccb6edca8 <- StaticFieldRefAccess(Field(0x28c859c7cf0, sub_28d95868d30(0x28d0d966cb0, 0x1376, 0x1, (xor ?)), 0x1, (xor ?)), sub_28d95868d30(0x28d0d966cb0, 0x1376, 0x1, (xor 
    //   0x28d9722e788  0x28ccb6edcb0 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x137e, 0x1, (xor ?)), 0x137e, 0x1, (xor ?))
    //   0x28d9722e7d8  ALLOC_OBJECT(0x28c86cc1be0) <- 0x28c86a586e8
    //   0x28d9722e7e6  ALLOC_OBJECT(0x28c86cc1be0) <- 0x28c86cc1ca8
    //   0x28d9722e7f8  ALLOC_OBJECT(0x28c86cc1be0) <- 0x28c86cc1cb0.f28
    //   0x28d9722e800  ALLOC_OBJECT(0x28c86cc1be0) <- 0x28c86cc1cb0.f20
    //   0x28d9722e804  ALLOC_OBJECT(0x28c86cc1be0) <- 0x0
    //   0x28d9722e828  0x28ccb6edcb8 <- Get(ALLOC_OBJECT(0x28c86cc1be0), 0x28c86cc1cb0.f28, 0x1, (xor ?))
    //   0x28d9722e8c0  0x28ccb6edcc0 <- MethodDelegate(Method(0x28cc7527e70, sub_28d95868d30(0x28d0d966cb0, 0x13ac, 0x1, (xor ?)), (0x1 xor 0x1), ((xor ?) xor (xor ?))), (sub_28d95868d30(0x28d0d966cb0
    //   0x28d9722e958  0x28ccb6edcc8 <- MethodDelegate(Method(0x28c859c7cf0, sub_28d95868d30(0x28d0d966cb0, 0x13cc, 0x1, ((xor ?) xor (xor ?))), (0x1 xor 0x1), (((xor ?) xor (xor ?)) xor ((xor ?) xor 
    //   0x28d9722e9c1  0x28ccb6edcd0 <- ALLOC_OBJECT(0x28d96c89600)
    //   0x28d9722ea10  0x28ccb6edcd8 <- ALLOC_ARRAY(0x28d96c897c8, 0x1f4)
    //   0x28d9722ea60  0x28ccb6edce0 <- ALLOC_ARRAY(0x28d96c897c8, 0x1f4)
    //   0x28d9722eab0  0x28ccb6edce8 <- ALLOC_ARRAY(0x28d96c897c8, 0x1f4)
    //   0x28d9722eb19  0x28ccb6edd00 <- ALLOC_OBJECT(0x28d96c89958)
    //   0x28d9722eb49  0x28ccb6edd08 <- 0x1
    // returns: 0x28ccb6edd08
}
