// ============================================================
// token 0x060004f9   25BE834779884F9D::.cctor
// native code: 0x28d970ce700  (117 bytes)
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
    // 3 call(s):
    //   0x28d970ce728  sub_28d95868d30(0x28d0d966cb0, 0xb2e, ?, ?)
    //   0x28d970ce738  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xb2e, ?, ?), 0xb2e, ?, ?)
    //   0x28d970ce768  WBARRIER(0x28d03f81cd0, 0xb2e)
    // 1 store(s):
    //   0x28d970ce748  0x28d03f81cd0 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xb2e, ?, ?), 0xb2e, ?, ?)
    // returns: 0x28d03f81cd0
}
