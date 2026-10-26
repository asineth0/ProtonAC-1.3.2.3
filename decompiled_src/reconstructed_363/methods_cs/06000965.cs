// ============================================================
// token 0x06000965   0732D1C8FF584BB5::.ctor
// native code: 0x28d972d8930  (417 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 06000d64
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 12 call(s):
    //   0x28d972d8958  ALLOC_OBJECT(0x28d96c8aed0)
    //   0x28d972d8970  .ctor(ALLOC_OBJECT(0x28d96c8aed0), ?, ?, ?)
    //   0x28d972d8990  WBARRIER(this+10, ?)
    //   0x28d972d89b0  ALLOC_OBJECT(0x28d96c877f8)
    //   0x28d972d89d0  1A42C15FF0B54B42::.ctor(ALLOC_OBJECT(0x28d96c877f8), 0x3e8)
    //   0x28d972d89f0  WBARRIER(this+18, 0x3e8)
    //   0x28d972d8a10  ALLOC_OBJECT(0x28d96c87860)
    //   0x28d972d8a30  1A42C15FF0B54B42::.ctor(ALLOC_OBJECT(0x28d96c87860), 0x3e8)
    //   0x28d972d8a50  WBARRIER(this+20, 0x3e8)
    //   0x28d972d8a70  ALLOC_OBJECT(0x28d0d823d58)
    //   0x28d972d8aa0  WBARRIER((ALLOC_OBJECT(0x28d0d823d58) add 0x10), 0x3e8)
    //   0x28d972d8ac0  WBARRIER(this+28, 0x3e8)
    // 5 store(s):
    //   0x28d972d897f  this+10 <- ALLOC_OBJECT(0x28d96c8aed0)
    //   0x28d972d89df  this+18 <- ALLOC_OBJECT(0x28d96c877f8)
    //   0x28d972d8a3f  this+20 <- ALLOC_OBJECT(0x28d96c87860)
    //   0x28d972d8a8c  (ALLOC_OBJECT(0x28d0d823d58) add 0x10) <- 0x28d0c3f6240
    //   0x28d972d8ab3  this+28 <- ALLOC_OBJECT(0x28d0d823d58)
    // returns: ALLOC_OBJECT(0x28d0d823d58)
}
