// ============================================================
// token 0x06000d6b   22986AEA233A48AF::.ctor
// native code: 0x28d97039930  (485 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   string '',
//   [opt] string ''
//   ) cil managed
//   
// native-calls: 06000d6c
// native-strings: 
// ============================================================

public  void .ctor(string arg0, string arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 12 call(s):
    //   0x28d97039970  ALLOC_OBJECT(0x28b83e23070)
    //   0x28d97039990  WBARRIER((this add 0x10), arg0)
    //   0x28d970399a8  IsNullOrWhiteSpace(arg1, arg0, arg1, ?)
    //   0x28d970399c0  CreateDirectory(arg1, arg0, arg1, ?)
    //   0x28d970399d0  IsNullOrWhiteSpace(arg1, arg0, arg1, ?)
    //   0x28d970399e8  Combine(arg1, arg0, arg1, ?)
    //   0x28d97039a18  ALLOC_OBJECT(0x28d96163a38)
    //   0x28d97039a30  .ctor(ALLOC_OBJECT(0x28d96163a38), arg0, arg1, ?)
    //   0x28d97039a60  ALLOC_OBJECT(0x28d96163b38)
    //   0x28d97039a80  .ctor(ALLOC_OBJECT(0x28d96163b38), ALLOC_OBJECT(0x28d96163a38), (arg1 xor arg1), ?)
    //   0x28d97039aa0  WBARRIER((this add 0x18), ALLOC_OBJECT(0x28d96163a38))
    //   0x28d97039b00  22986AEA233A48AF::InitializeIndexes(this)
    // 3 store(s):
    //   0x28d9703997f  (this add 0x10) <- ALLOC_OBJECT(0x28b83e23070)
    //   0x28d97039a41  ALLOC_OBJECT(0x28d96163a38) <- 0x1
    //   0x28d97039a93  (this add 0x18) <- ALLOC_OBJECT(0x28d96163b38)
    // returns: 22986AEA233A48AF::InitializeIndexes(this)
}
