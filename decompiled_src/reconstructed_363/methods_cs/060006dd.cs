// ============================================================
// token 0x060006dd   324819153CA4494E::.cctor
// native code: 0x28d970ca510  (1021 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed
//   
// native-calls: 060006e7,060006ea,060006f0,060006e3,060006ed
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 24 call(s):
    //   0x28d970ca538  sub_28d95868d30(0x28d0d966cb0, 0xb2e, ?, ?)
    //   0x28d970ca548  FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xb2e, ?, ?), 0xb2e, ?, ?)
    //   0x28d970ca578  WBARRIER(0x28c840e8420, 0xb2e)
    //   0x28d970ca5a0  sub_28d95868d30(0x28d0d966cb0, 0x1e14, ?, ?)
    //   0x28d970ca5c0  PropertySetter(0x28cc7527e70, sub_28d95868d30(0x28d0d966cb0, 0x1e14, ?, ?), ?, ?)
    //   0x28d970ca5f0  WBARRIER(0x28c840e8428, sub_28d95868d30(0x28d0d966cb0, 0x1e14, ?, ?))
    //   0x28d970ca618  sub_28d95868d30(0x28d0d966cb0, 0x1e34, ?, ?)
    //   0x28d970ca638  PropertySetter(0x28cc7527e70, sub_28d95868d30(0x28d0d966cb0, 0x1e34, ?, ?), ?, ?)
    //   0x28d970ca668  WBARRIER(0x28c840e8430, sub_28d95868d30(0x28d0d966cb0, 0x1e34, ?, ?))
    //   0x28d970ca690  ALLOC_ARRAY(0x28d96645e70, 0x5)
    //   0x28d970ca6b8  ALLOC_OBJECT(0x28d96646000)
    //   0x28d970ca6d0  B6EA0A2F39B94A06::.ctor(ALLOC_OBJECT(0x28d96646000))
    //   0x28d970ca718  ALLOC_OBJECT(0x28d96646108)
    //   0x28d970ca730  76ADFA724BE5493C::.ctor(ALLOC_OBJECT(0x28d96646108))
    //   0x28d970ca770  ALLOC_OBJECT(0x28d96646190)
    //   0x28d970ca788  D67833F516334C13::.ctor(ALLOC_OBJECT(0x28d96646190))
    //   0x28d970ca7c8  ALLOC_OBJECT(0x28d96646230)
    //   0x28d970ca7e0  9AD43A3E564C4B20::.ctor(ALLOC_OBJECT(0x28d96646230))
    //   0x28d970ca820  ALLOC_OBJECT(0x28d966462d0)
    //   0x28d970ca838  59207101D2374F50::.ctor(ALLOC_OBJECT(0x28d966462d0))
    //   0x28d970ca880  WBARRIER(0x28c840e8438, 0x4)
    //   0x28d970ca8a0  ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d970ca8d0  WBARRIER((ALLOC_OBJECT(0x28c86f73f50) add 0x10), 0x4)
    //   0x28d970ca900  WBARRIER(0x28c840e8440, 0x4)
    // 6 store(s):
    //   0x28d970ca558  0x28c840e8420 <- FieldRefAccess(sub_28d95868d30(0x28d0d966cb0, 0xb2e, ?, ?), 0xb2e, ?, ?)
    //   0x28d970ca5d0  0x28c840e8428 <- PropertySetter(0x28cc7527e70, sub_28d95868d30(0x28d0d966cb0, 0x1e14, ?, ?), ?, ?)
    //   0x28d970ca648  0x28c840e8430 <- PropertySetter(0x28cc7527e70, sub_28d95868d30(0x28d0d966cb0, 0x1e34, ?, ?), ?, ?)
    //   0x28d970ca862  0x28c840e8438 <- ALLOC_ARRAY(0x28d96645e70, 0x5)
    //   0x28d970ca8bc  (ALLOC_OBJECT(0x28c86f73f50) add 0x10) <- 0x28cc75df260
    //   0x28d970ca8e5  0x28c840e8440 <- ALLOC_OBJECT(0x28c86f73f50)
    // returns: 0x28c840e8440
}
