// ============================================================
// token 0x0600050c   A30F7371EEB94415::.cctor
// native code: 0x28d970b89c0  (325 bytes)
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
    // 9 call(s):
    //   0x28d970b89e8  sub_28d95868d30(0x28d0d966cb0, 0xe86, ?, ?)
    //   0x28d970b8a08  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xe86, ?, ?), 0xe86, ?, ?)
    //   0x28d970b8a38  WBARRIER(0x28c840e8450, 0xe86)
    //   0x28d970b8a58  sub_28d95868d30(0x28d0d966cb0, 0xeaa, ?, ?)
    //   0x28d970b8a68  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xeaa, ?, ?), 0xeaa, ?, ?)
    //   0x28d970b8a98  WBARRIER(0x28c840e8458, 0xeaa)
    //   0x28d970b8ab8  sub_28d95868d30(0x28d0d966cb0, 0xec2, ?, ?)
    //   0x28d970b8ac8  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xec2, ?, ?), 0xec2, ?, ?)
    //   0x28d970b8af8  WBARRIER(0x28c840e8460, 0xec2)
    // 3 store(s):
    //   0x28d970b8a18  0x28c840e8450 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xe86, ?, ?), 0xe86, ?, ?)
    //   0x28d970b8a78  0x28c840e8458 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xeaa, ?, ?), 0xeaa, ?, ?)
    //   0x28d970b8ad8  0x28c840e8460 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xec2, ?, ?), 0xec2, ?, ?)
    // returns: 0x28c840e8460
}
