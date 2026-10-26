// ============================================================
// token 0x06000f6b   F8628D416336433B::.ctor
// native code: 0x28d957e6320  (89 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 06000f6c,06000f6d
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d957e6340  F8628D416336433B::E372066418F1461A()
    //   0x28d957e6350  F8628D416336433B::39D831234F1F4967(F8628D416336433B::E372066418F1461A())
    //   0x28d957e6368  WBARRIER(this+10, ?)
    // 1 store(s):
    //   0x28d957e635b  this+10 <- F8628D416336433B::39D831234F1F4967(F8628D416336433B::E372066418F1461A())
    // returns: F8628D416336433B::39D831234F1F4967(F8628D416336433B::E372066418F1461A())
}
