// ============================================================
// token 0x06000539   BB9CAD1F8D524E16::.cctor
// native code: 0x28d970d4440  (1261 bytes)
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
    // 37 call(s):
    //   0x28d970d4468  sub_28d95868d30(0x28d0d966cb0, 0xfd8, ?, ?)
    //   0x28d970d4488  PropertyGetter(0x28cc7532a80, sub_28d95868d30(0x28d0d966cb0, 0xfd8, ?, ?), ?, ?)
    //   0x28d970d44b0  MethodDelegate(PropertyGetter(0x28cc7532a80, sub_28d95868d30(0x28d0d966cb0, 0xfd8, ?, ?), ?, ?), (sub_28d95868d30(0x28d0d966cb0, 0xfd8, ?, ?) xor sub_28d95868d30(0x28d0d966cb0, 0xfd8, ?, ?)), 0x1, ?)
    //   0x28d970d44e0  WBARRIER(0x28c84109a80, (sub_28d95868d30(0x28d0d966cb0, 0xfd8, ?, ?) xor sub_28d95868d30(0x28d0d966cb0, 0xfd8, ?, ?)))
    //   0x28d970d4500  sub_28d95868d30(0x28d0d966cb0, 0x1006, 0x1, ?)
    //   0x28d970d4510  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1006, 0x1, ?), 0x1006, 0x1, ?)
    //   0x28d970d4540  WBARRIER(0x28c84109a88, 0x1006)
    //   0x28d970d4560  sub_28d95868d30(0x28d0d966cb0, 0x1018, 0x1, ?)
    //   0x28d970d4580  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1018, 0x1, ?), 0x1018, 0x1, ?)
    //   0x28d970d45b0  WBARRIER(0x28c84109a90, 0x1018)
    //   0x28d970d45d0  sub_28d95868d30(0x28d0d966cb0, 0x1026, 0x1, ?)
    //   0x28d970d45f0  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1026, 0x1, ?), 0x1026, 0x1, ?)
    //   0x28d970d4620  WBARRIER(0x28c84109a98, 0x1026)
    //   0x28d970d4640  sub_28d95868d30(0x28d0d966cb0, 0x1042, 0x1, ?)
    //   0x28d970d4650  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1042, 0x1, ?), 0x1042, 0x1, ?)
    //   0x28d970d4680  WBARRIER(0x28c84109aa0, 0x1042)
    //   0x28d970d46a0  sub_28d95868d30(0x28d0d966cb0, 0x104e, 0x1, ?)
    //   0x28d970d46b0  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x104e, 0x1, ?), 0x104e, 0x1, ?)
    //   0x28d970d46e0  WBARRIER(0x28c84109aa8, 0x104e)
    //   0x28d970d4700  sub_28d95868d30(0x28d0d966cb0, 0x105e, 0x1, ?)
    //   0x28d970d4710  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x105e, 0x1, ?), 0x105e, 0x1, ?)
    //   0x28d970d4740  WBARRIER(0x28c84109ab0, 0x105e)
    //   0x28d970d4760  sub_28d95868d30(0x28d0d966cb0, 0x106e, 0x1, ?)
    //   0x28d970d4770  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x106e, 0x1, ?), 0x106e, 0x1, ?)
    //   0x28d970d47a0  WBARRIER(0x28c84109ab8, 0x106e)
    //   0x28d970d47c0  sub_28d95868d30(0x28d0d966cb0, 0x107e, 0x1, ?)
    //   0x28d970d47d0  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x107e, 0x1, ?), 0x107e, 0x1, ?)
    //   0x28d970d4800  WBARRIER(0x28c84109ac0, 0x107e)
    //   0x28d970d4820  sub_28d95868d30(0x28d0d966cb0, 0x1090, 0x1, ?)
    //   0x28d970d4830  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1090, 0x1, ?), 0x1090, 0x1, ?)
    //   0x28d970d4860  WBARRIER(0x28c84109ac8, 0x1090)
    //   0x28d970d4880  sub_28d95868d30(0x28d0d966cb0, 0x10a2, 0x1, ?)
    //   0x28d970d4890  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x10a2, 0x1, ?), 0x10a2, 0x1, ?)
    //   0x28d970d48c0  WBARRIER(0x28c84109ad0, 0x10a2)
    //   0x28d970d48e0  sub_28d95868d30(0x28d0d966cb0, 0x10b4, 0x1, ?)
    //   0x28d970d48f0  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x10b4, 0x1, ?), 0x10b4, 0x1, ?)
    //   0x28d970d4920  WBARRIER(0x28c84109ad8, 0x10b4)
    // 12 store(s):
    //   0x28d970d44c0  0x28c84109a80 <- MethodDelegate(PropertyGetter(0x28cc7532a80, sub_28d95868d30(0x28d0d966cb0, 0xfd8, ?, ?), ?, ?), (sub_28d95868d30(0x28d0d966cb0, 0xfd8, ?, ?) xor sub_28d95868d3
    //   0x28d970d4520  0x28c84109a88 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1006, 0x1, ?), 0x1006, 0x1, ?)
    //   0x28d970d4590  0x28c84109a90 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1018, 0x1, ?), 0x1018, 0x1, ?)
    //   0x28d970d4600  0x28c84109a98 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1026, 0x1, ?), 0x1026, 0x1, ?)
    //   0x28d970d4660  0x28c84109aa0 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1042, 0x1, ?), 0x1042, 0x1, ?)
    //   0x28d970d46c0  0x28c84109aa8 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x104e, 0x1, ?), 0x104e, 0x1, ?)
    //   0x28d970d4720  0x28c84109ab0 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x105e, 0x1, ?), 0x105e, 0x1, ?)
    //   0x28d970d4780  0x28c84109ab8 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x106e, 0x1, ?), 0x106e, 0x1, ?)
    //   0x28d970d47e0  0x28c84109ac0 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x107e, 0x1, ?), 0x107e, 0x1, ?)
    //   0x28d970d4840  0x28c84109ac8 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x1090, 0x1, ?), 0x1090, 0x1, ?)
    //   0x28d970d48a0  0x28c84109ad0 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x10a2, 0x1, ?), 0x10a2, 0x1, ?)
    //   0x28d970d4900  0x28c84109ad8 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0x10b4, 0x1, ?), 0x10b4, 0x1, ?)
    // returns: 0x28c84109ad8
}
