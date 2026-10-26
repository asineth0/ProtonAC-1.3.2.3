// ============================================================
// token 0x06000544   A76A63943FD04779::.cctor
// native code: 0x28d970b8040  (1733 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed
//   
// native-calls: 060000b0,06000131
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 34 call(s):
    //   0x28d970b8058  1DB744298E9F4B09::C2FE386528B74E31()
    //   0x28d970b8078  631D551E2DA64E7D::F3B62BCE1450413B(1DB744298E9F4B09::C2FE386528B74E31().f68)
    //   0x28d970b80a8  WBARRIER(0x28c84109af0, ?)
    //   0x28d970b80d0  sub_28d95868d30(0x28d0d966cb0, 0x10de, ?, ?)
    //   0x28d970b80f0  Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x10de, ?, ?), ?, ?)
    //   0x28d970b8120  WBARRIER(0x28c84109af8, sub_28d95868d30(0x28d0d966cb0, 0x10de, ?, ?))
    //   0x28d970b8148  sub_28d95868d30(0x28d0d966cb0, 0x10f6, ?, ?)
    //   0x28d970b8168  Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x10f6, ?, ?), ?, ?)
    //   0x28d970b8198  WBARRIER(0x28c84109b00, sub_28d95868d30(0x28d0d966cb0, 0x10f6, ?, ?))
    //   0x28d970b81c0  sub_28d95868d30(0x28d0d966cb0, 0x110e, ?, ?)
    //   0x28d970b81e0  Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x110e, ?, ?), ?, ?)
    //   0x28d970b8210  WBARRIER(0x28c84109b08, sub_28d95868d30(0x28d0d966cb0, 0x110e, ?, ?))
    //   0x28d970b8238  sub_28d95868d30(0x28d0d966cb0, 0x112e, ?, ?)
    //   0x28d970b8258  Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x112e, ?, ?), ?, ?)
    //   0x28d970b8288  WBARRIER(0x28c84109b10, sub_28d95868d30(0x28d0d966cb0, 0x112e, ?, ?))
    //   0x28d970b82b0  sub_28d95868d30(0x28d0d966cb0, 0x1146, ?, ?)
    //   0x28d970b82d0  Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x1146, ?, ?), ?, ?)
    //   0x28d970b8300  WBARRIER(0x28c84109b18, sub_28d95868d30(0x28d0d966cb0, 0x1146, ?, ?))
    //   0x28d970b8328  sub_28d95868d30(0x28d0d966cb0, 0x116e, ?, ?)
    //   0x28d970b8348  Method(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x116e, ?, ?), (xor ?), (xor ?))
    //   0x28d970b8378  WBARRIER(0x28c84109b20, sub_28d95868d30(0x28d0d966cb0, 0x116e, ?, ?))
    //   0x28d970b83a0  sub_28d95868d30(0x28d0d966cb0, 0x119e, (xor ?), (xor ?))
    //   0x28d970b83c0  Method(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x119e, (xor ?), (xor ?)), ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)))
    //   0x28d970b83f0  WBARRIER(0x28c84109b28, sub_28d95868d30(0x28d0d966cb0, 0x119e, (xor ?), (xor ?)))
    //   0x28d970b8418  sub_28d95868d30(0x28d0d966cb0, 0x11dc, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)))
    //   0x28d970b8438  Method(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x11dc, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?))), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))))
    //   0x28d970b8468  WBARRIER(0x28c84109b30, sub_28d95868d30(0x28d0d966cb0, 0x11dc, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?))))
    //   0x28d970b8488  sub_28d95868d30(0x28d0d966cb0, 0x120e, (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))))
    //   0x28d970b84a8  ALLOC_ARRAY(0x28c852193f0, 0xa)
    //   0x28d970b8660  Method(0x28cc75303c0, sub_28d95868d30(0x28d0d966cb0, 0x120e, (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?)))), ALLOC_ARRAY(0x28c852193f0, 0xa), ((((xor ?) xor (xor ?))
    //   0x28d970b8690  WBARRIER(0x28c84109b38, sub_28d95868d30(0x28d0d966cb0, 0x120e, (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?)))))
    //   0x28d970b86b0  ALLOC_OBJECT(0x28d96822ce8)
    //   0x28d970b86c8  .ctor(ALLOC_OBJECT(0x28d96822ce8), sub_28d95868d30(0x28d0d966cb0, 0x120e, (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?)))), ALLOC_ARRAY(0x28c852193f0, 0xa), ((((xor ?)
    //   0x28d970b86f8  WBARRIER(0x28c84109b40, sub_28d95868d30(0x28d0d966cb0, 0x120e, (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?)))))
    // 11 store(s):
    //   0x28d970b8088  0x28c84109af0 <- 631D551E2DA64E7D::F3B62BCE1450413B(1DB744298E9F4B09::C2FE386528B74E31().f68)
    //   0x28d970b8100  0x28c84109af8 <- Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x10de, ?, ?), ?, ?)
    //   0x28d970b8178  0x28c84109b00 <- Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x10f6, ?, ?), ?, ?)
    //   0x28d970b81f0  0x28c84109b08 <- Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x110e, ?, ?), ?, ?)
    //   0x28d970b8268  0x28c84109b10 <- Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x112e, ?, ?), ?, ?)
    //   0x28d970b82e0  0x28c84109b18 <- Field(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x1146, ?, ?), ?, ?)
    //   0x28d970b8358  0x28c84109b20 <- Method(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x116e, ?, ?), (xor ?), (xor ?))
    //   0x28d970b83d0  0x28c84109b28 <- Method(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x119e, (xor ?), (xor ?)), ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)))
    //   0x28d970b8448  0x28c84109b30 <- Method(0x28cc752c720, sub_28d95868d30(0x28d0d966cb0, 0x11dc, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?))), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), (
    //   0x28d970b8670  0x28c84109b38 <- Method(0x28cc75303c0, sub_28d95868d30(0x28d0d966cb0, 0x120e, (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))
    //   0x28d970b86d9  0x28c84109b40 <- ALLOC_OBJECT(0x28d96822ce8)
    // returns: 0x28c84109b40
}
