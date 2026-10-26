// ============================================================
// token 0x06000270   40FE7AC3F69F4B10::.ctor
// native code: 0x28d95a3dd90  (165 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   string '',
//   bool ''
//   ) cil managed
//   
// native-calls: 06000d56
// native-strings: 
// ============================================================

public  void .ctor(string arg0, bool arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a3ddc0  WBARRIER(this+10, arg0)
    //   0x28d95a3dde0  ALLOC_OBJECT(0x28d9612b8e8)
    //   0x28d95a3de00  A807FD2A83C845A2::.ctor(ALLOC_OBJECT(0x28d9612b8e8), 0x7d)
    //   0x28d95a3de20  WBARRIER(this+18, 0x7d)
    // 3 store(s):
    //   0x28d95a3ddae  this+10 <- arg0
    //   0x28d95a3ddc7  this <- (movzx arg1)
    //   0x28d95a3de0f  this+18 <- ALLOC_OBJECT(0x28d9612b8e8)
    // returns: ALLOC_OBJECT(0x28d9612b8e8)
}
