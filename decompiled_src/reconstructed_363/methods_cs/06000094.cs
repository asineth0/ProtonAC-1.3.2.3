// ============================================================
// token 0x06000094   CCF339C5456845F6::524F3D4EA6214321
// native code: 0x28d970b7ef0  (165 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance void '524F3D4EA6214321' (
//   class '0994D846605341C2' ''
//   ) cil managed
//   
// native-calls: 060000a6
// native-strings: 
// ============================================================

 void 524F3D4EA6214321(0994D846605341C2 arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 2 call(s):
    //   0x28d970b7f68  AddWithResize(this.f10, arg0, arg0, ?)
    //   0x28d970b7f78  CCF339C5456845F6::F97E94933E324356(arg0)
    // 2 store(s):
    //   0x28d970b7f25  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d970b7f3f  this.f10 <- (movsxd this.f10.f18)+1
    // returns: CCF339C5456845F6::F97E94933E324356(arg0)
}
