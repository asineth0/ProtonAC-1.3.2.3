// ============================================================
// token 0x06000155   FA614F32E31A4FDD::.cctor
// native code: 0x28d973037e0  (773 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed noinlining
//   
// native-calls: 06000004
// native-strings: 0x5ec:hasClipPrefab
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 20 call(s):
    //   0x28d97303808  <Module>::390073C602714496(0x2801613d)   ; "hasClipPrefab"
    //   0x28d97303818  FieldRefAccess(<Module>::390073C602714496(0x2801613d), ?, ?, ?)
    //   0x28d97303848  WBARRIER(0x28c840e6500, ?)
    //   0x28d97303868  ALLOC_OBJECT(0x28d96eadb78)
    //   0x28d97303880  .ctor(ALLOC_OBJECT(0x28d96eadb78), ?, ?, ?)
    //   0x28d973038b0  WBARRIER(0x28c840e6508, ?)
    //   0x28d973038d0  ALLOC_OBJECT(0x28d0d7fa160)
    //   0x28d973038e8  .ctor(ALLOC_OBJECT(0x28d0d7fa160), ?, ?, ?)
    //   0x28d97303918  WBARRIER(0x28c840e6510, ?)
    //   0x28d97303938  ALLOC_OBJECT(0x28d96eaddc8)
    //   0x28d97303950  .ctor(ALLOC_OBJECT(0x28d96eaddc8), ?, ?, ?)
    //   0x28d97303980  WBARRIER(0x28c840e6518, ?)
    //   0x28d973039a0  ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d973039d0  WBARRIER((ALLOC_OBJECT(0x28c86f73f50) add 0x10), ?)
    //   0x28d97303a00  WBARRIER(0x28c840e6520, ?)
    //   0x28d97303a20  ALLOC_OBJECT(0x28d96eae018)
    //   0x28d97303a38  .ctor(ALLOC_OBJECT(0x28d96eae018), ?, ?, ?)
    //   0x28d97303a68  WBARRIER(0x28c840e6528, ?)
    //   0x28d97303a90  sub_28b82782ba0(0x28d96eae180, ?, ?, ?)
    //   0x28d97303ac8  WBARRIER(0x28c840e6530, ?)
    // 9 store(s):
    //   0x28d97303828  0x28c840e6500 <- FieldRefAccess(<Module>::390073C602714496(0x2801613d), ?, ?, ?)
    //   0x28d97303891  0x28c840e6508 <- ALLOC_OBJECT(0x28d96eadb78)
    //   0x28d973038f9  0x28c840e6510 <- ALLOC_OBJECT(0x28d0d7fa160)
    //   0x28d97303961  0x28c840e6518 <- ALLOC_OBJECT(0x28d96eaddc8)
    //   0x28d973039bc  (ALLOC_OBJECT(0x28c86f73f50) add 0x10) <- 0x28cc75df260
    //   0x28d973039e5  0x28c840e6520 <- ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d97303a49  0x28c840e6528 <- ALLOC_OBJECT(0x28d96eae018)
    //   0x28d97303aaa  0x28c840e6530 <- 0x28d03f81840.f0
    //   0x28d97303ad9  0x28c840e6538 <- 0x1e9be401
    // returns: 0x28c840e6538
    // string table refs:
    //   0x5ec  "hasClipPrefab"
}
