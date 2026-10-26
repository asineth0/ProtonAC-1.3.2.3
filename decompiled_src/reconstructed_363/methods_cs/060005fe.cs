// ============================================================
// token 0x060005fe   2B4193F94A734FAF::.cctor
// native code: 0x28d972fe5e0  (1773 bytes)
// kind: SMALL_CALL   confidence: outline
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
    // 47 call(s):
    //   0x28d972fe608  sub_28d95868d30(0x28d0d966cb0, 0x1598, ?, ?)
    //   0x28d972fe628  Method(0x28c859c78a0, sub_28d95868d30(0x28d0d966cb0, 0x1598, ?, ?), (xor ?), (xor ?))
    //   0x28d972fe650  MethodDelegate(Method(0x28c859c78a0, sub_28d95868d30(0x28d0d966cb0, 0x1598, ?, ?), (xor ?), (xor ?)), (sub_28d95868d30(0x28d0d966cb0, 0x1598, ?, ?) xor sub_28d95868d30(0x28d0d966cb0, 0x1598, ?, ?)), 0x1, (xor ?))
    //   0x28d972fe680  WBARRIER(0x28d02319c00, (sub_28d95868d30(0x28d0d966cb0, 0x1598, ?, ?) xor sub_28d95868d30(0x28d0d966cb0, 0x1598, ?, ?)))
    //   0x28d972fe6a8  sub_28d95868d30(0x28d0d966cb0, 0x15cc, 0x1, (xor ?))
    //   0x28d972fe6c8  Method(0x28c859c78a0, sub_28d95868d30(0x28d0d966cb0, 0x15cc, 0x1, (xor ?)), (0x1 xor 0x1), ((xor ?) xor (xor ?)))
    //   0x28d972fe6f0  MethodDelegate(Method(0x28c859c78a0, sub_28d95868d30(0x28d0d966cb0, 0x15cc, 0x1, (xor ?)), (0x1 xor 0x1), ((xor ?) xor (xor ?))), (sub_28d95868d30(0x28d0d966cb0, 0x15cc, 0x1, (xor ?)) xor sub_28d95868d30(0x28d0d966cb0, 0
    //   0x28d972fe720  WBARRIER(0x28d02319c08, (sub_28d95868d30(0x28d0d966cb0, 0x15cc, 0x1, (xor ?)) xor sub_28d95868d30(0x28d0d966cb0, 0x15cc, 0x1, (xor ?))))
    //   0x28d972fe748  sub_28d95868d30(0x28d0d966cb0, 0x15ea, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe760  Method(sub_28d95868d30(0x28d0d966cb0, 0x15ea, 0x1, ((xor ?) xor (xor ?))), (0x15ea xor 0x15ea), (0x1 xor 0x1), ((xor ?) xor (xor ?)))
    //   0x28d972fe788  MethodDelegate(Method(sub_28d95868d30(0x28d0d966cb0, 0x15ea, 0x1, ((xor ?) xor (xor ?))), (0x15ea xor 0x15ea), (0x1 xor 0x1), ((xor ?) xor (xor ?))), ((0x15ea xor 0x15ea) xor (0x15ea xor 0x15ea)), 0x1, ((xor ?) xor (xor 
    //   0x28d972fe7b8  WBARRIER(0x28d02319c10, ((0x15ea xor 0x15ea) xor (0x15ea xor 0x15ea)))
    //   0x28d972fe7d8  sub_28d95868d30(0x28d0d966cb0, 0x1642, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe7f0  Method(sub_28d95868d30(0x28d0d966cb0, 0x1642, 0x1, ((xor ?) xor (xor ?))), (0x1642 xor 0x1642), (0x1 xor 0x1), ((xor ?) xor (xor ?)))
    //   0x28d972fe818  MethodDelegate(Method(sub_28d95868d30(0x28d0d966cb0, 0x1642, 0x1, ((xor ?) xor (xor ?))), (0x1642 xor 0x1642), (0x1 xor 0x1), ((xor ?) xor (xor ?))), ((0x1642 xor 0x1642) xor (0x1642 xor 0x1642)), 0x1, ((xor ?) xor (xor 
    //   0x28d972fe848  WBARRIER(0x28d02319c18, ((0x1642 xor 0x1642) xor (0x1642 xor 0x1642)))
    //   0x28d972fe868  sub_28d95868d30(0x28d0d966cb0, 0x169a, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe888  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x169a, 0x1, ((xor ?) xor (xor ?))), 0x169a, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe8b8  WBARRIER(0x28d02319c20, 0x169a)
    //   0x28d972fe8d8  sub_28d95868d30(0x28d0d966cb0, 0x16bc, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe8f8  Field(0x28c859c77e0, sub_28d95868d30(0x28d0d966cb0, 0x16bc, 0x1, ((xor ?) xor (xor ?))), 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe908  StaticFieldRefAccess(Field(0x28c859c77e0, sub_28d95868d30(0x28d0d966cb0, 0x16bc, 0x1, ((xor ?) xor (xor ?))), 0x1, ((xor ?) xor (xor ?))), sub_28d95868d30(0x28d0d966cb0, 0x16bc, 0x1, ((xor ?) xor (xor ?))), 0x1, ((xor ?)
    //   0x28d972fe938  WBARRIER(0x28d02319c28, sub_28d95868d30(0x28d0d966cb0, 0x16bc, 0x1, ((xor ?) xor (xor ?))))
    //   0x28d972fe958  sub_28d95868d30(0x28d0d966cb0, 0x14d6, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe978  Get(0x28c859c7cf0, sub_28d95868d30(0x28d0d966cb0, 0x14d6, 0x1, ((xor ?) xor (xor ?))), 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe9a8  WBARRIER(0x28d02319c30, sub_28d95868d30(0x28d0d966cb0, 0x14d6, 0x1, ((xor ?) xor (xor ?))))
    //   0x28d972fe9c8  sub_28d95868d30(0x28d0d966cb0, 0x16e8, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe9e8  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x16e8, 0x1, ((xor ?) xor (xor ?))), 0x16e8, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fea18  WBARRIER(0x28d02319c38, 0x16e8)
    //   0x28d972fea38  sub_28d95868d30(0x28d0d966cb0, 0x16f2, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fea58  PropertyGetter(0x28c859c1270, sub_28d95868d30(0x28d0d966cb0, 0x16f2, 0x1, ((xor ?) xor (xor ?))), 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fea80  MethodDelegate(PropertyGetter(0x28c859c1270, sub_28d95868d30(0x28d0d966cb0, 0x16f2, 0x1, ((xor ?) xor (xor ?))), 0x1, ((xor ?) xor (xor ?))), (sub_28d95868d30(0x28d0d966cb0, 0x16f2, 0x1, ((xor ?) xor (xor ?))) xor sub_28
    //   0x28d972feab0  WBARRIER(0x28d02319c40, (sub_28d95868d30(0x28d0d966cb0, 0x16f2, 0x1, ((xor ?) xor (xor ?))) xor sub_28d95868d30(0x28d0d966cb0, 0x16f2, 0x1, ((xor ?) xor (xor ?)))))
    //   0x28d972fead0  ALLOC_OBJECT(0x28d93cdb8b8)
    //   0x28d972feaf0  .ctor(ALLOC_OBJECT(0x28d93cdb8b8), 0x1, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972feb20  WBARRIER(0x28d02319c48, 0x1)
    //   0x28d972feb40  ALLOC_OBJECT(0x28d9539e460)
    //   0x28d972feb60  .ctor(ALLOC_OBJECT(0x28d9539e460), 0x40, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972feb90  WBARRIER(0x28d02319c50, 0x40)
    //   0x28d972febb0  ALLOC_OBJECT(0x28d9539e460)
    //   0x28d972febd0  .ctor(ALLOC_OBJECT(0x28d9539e460), 0x40, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fec00  WBARRIER(0x28d02319c58, 0x40)
    //   0x28d972fec20  ALLOC_OBJECT(0x28d9539e7f8)
    //   0x28d972fec40  .ctor(ALLOC_OBJECT(0x28d9539e7f8), 0x28cf0ab9370, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fec70  WBARRIER(0x28d02319c60, 0x28cf0ab9370)
    //   0x28d972fec90  ALLOC_ARRAY(0x28c851b3688, 0xffff)
    //   0x28d972fecc0  WBARRIER(0x28d02319c68, 0xffff)
    // 14 store(s):
    //   0x28d972fe660  0x28d02319c00 <- MethodDelegate(Method(0x28c859c78a0, sub_28d95868d30(0x28d0d966cb0, 0x1598, ?, ?), (xor ?), (xor ?)), (sub_28d95868d30(0x28d0d966cb0, 0x1598, ?, ?) xor sub_28d9
    //   0x28d972fe700  0x28d02319c08 <- MethodDelegate(Method(0x28c859c78a0, sub_28d95868d30(0x28d0d966cb0, 0x15cc, 0x1, (xor ?)), (0x1 xor 0x1), ((xor ?) xor (xor ?))), (sub_28d95868d30(0x28d0d966cb0
    //   0x28d972fe798  0x28d02319c10 <- MethodDelegate(Method(sub_28d95868d30(0x28d0d966cb0, 0x15ea, 0x1, ((xor ?) xor (xor ?))), (0x15ea xor 0x15ea), (0x1 xor 0x1), ((xor ?) xor (xor ?))), ((0x15ea x
    //   0x28d972fe828  0x28d02319c18 <- MethodDelegate(Method(sub_28d95868d30(0x28d0d966cb0, 0x1642, 0x1, ((xor ?) xor (xor ?))), (0x1642 xor 0x1642), (0x1 xor 0x1), ((xor ?) xor (xor ?))), ((0x1642 x
    //   0x28d972fe898  0x28d02319c20 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x169a, 0x1, ((xor ?) xor (xor ?))), 0x169a, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe918  0x28d02319c28 <- StaticFieldRefAccess(Field(0x28c859c77e0, sub_28d95868d30(0x28d0d966cb0, 0x16bc, 0x1, ((xor ?) xor (xor ?))), 0x1, ((xor ?) xor (xor ?))), sub_28d95868d30(0x28d
    //   0x28d972fe988  0x28d02319c30 <- Get(0x28c859c7cf0, sub_28d95868d30(0x28d0d966cb0, 0x14d6, 0x1, ((xor ?) xor (xor ?))), 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fe9f8  0x28d02319c38 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x16e8, 0x1, ((xor ?) xor (xor ?))), 0x16e8, 0x1, ((xor ?) xor (xor ?)))
    //   0x28d972fea90  0x28d02319c40 <- MethodDelegate(PropertyGetter(0x28c859c1270, sub_28d95868d30(0x28d0d966cb0, 0x16f2, 0x1, ((xor ?) xor (xor ?))), 0x1, ((xor ?) xor (xor ?))), (sub_28d95868d30(0
    //   0x28d972feb01  0x28d02319c48 <- ALLOC_OBJECT(0x28d93cdb8b8)
    //   0x28d972feb71  0x28d02319c50 <- ALLOC_OBJECT(0x28d9539e460)
    //   0x28d972febe1  0x28d02319c58 <- ALLOC_OBJECT(0x28d9539e460)
    //   0x28d972fec51  0x28d02319c60 <- ALLOC_OBJECT(0x28d9539e7f8)
    //   0x28d972feca0  0x28d02319c68 <- ALLOC_ARRAY(0x28c851b3688, 0xffff)
    // returns: 0x28d02319c68
}
