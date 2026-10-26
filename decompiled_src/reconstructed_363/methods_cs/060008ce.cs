// ============================================================
// token 0x060008ce   A3116505AAB24996::.cctor
// native code: 0x28d972d8190  (153 bytes)
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
    //   0x28d972d81b0  ALLOC_OBJECT(0x28d96c87200)
    //   0x28d972d81c8  .ctor(ALLOC_OBJECT(0x28d96c87200), ?, ?, ?)
    //   0x28d972d81f8  WBARRIER(0x28d0351caa0, ?)
    // 3 store(s):
    //   0x28d972d81d9  0x28d0351caa0 <- ALLOC_OBJECT(0x28d96c87200)
    //   0x28d972d820e  0x28d0351caa8 <- 0x2ee
    //   0x28d972d8220  0x28d0351cab0 <- 0x3e8
    // returns: 0x28d0351cab0
}
