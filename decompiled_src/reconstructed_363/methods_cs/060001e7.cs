// ============================================================
// token 0x060001e7   52E00C0CB6ED438D::.cctor
// native code: 0x28d958c6250  (165 bytes)
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
    // 4 call(s):
    //   0x28d958c6278  sub_28d95868d30(0x28d0d966cb0, 0x56d, ?, ?)
    //   0x28d958c6298  ALLOC_OBJECT(0x28cc7f09888)
    //   0x28d958c62b8  .ctor(ALLOC_OBJECT(0x28cc7f09888), sub_28d95868d30(0x28d0d966cb0, 0x56d, ?, ?), 0x9, ?)
    //   0x28d958c62e8  WBARRIER(0x28cca2db3a0, sub_28d95868d30(0x28d0d966cb0, 0x56d, ?, ?))
    // 1 store(s):
    //   0x28d958c62c9  0x28cca2db3a0 <- ALLOC_OBJECT(0x28cc7f09888)
    // returns: 0x28cca2db3a0
}
