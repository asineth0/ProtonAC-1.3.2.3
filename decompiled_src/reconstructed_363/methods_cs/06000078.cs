// ============================================================
// token 0x06000078   NullableAttribute::.ctor
// native code: 0x28d970fe150  (139 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   uint8 ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public  void .ctor(byte arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d970fe180  ALLOC_ARRAY(0x28c851b3688, 0x1)
    //   0x28d970fe1b0  WBARRIER(this+10, (movzx arg0))
    //   0x28d970fe1d8  THROW(0x146, 0x51)
    // 2 store(s):
    //   0x28d970fe194  ALLOC_ARRAY(0x28c851b3688, 0x1) <- (movzx arg0)
    //   0x28d970fe1a0  this+10 <- ALLOC_ARRAY(0x28c851b3688, 0x1)
    // returns: ALLOC_ARRAY(0x28c851b3688, 0x1)
}
