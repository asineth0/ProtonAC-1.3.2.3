// ============================================================
// token 0x06000130   631D551E2DA64E7D::E3F4BD9854F044B6
// native code: 0x28d95a3c8c0  (137 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance void E3F4BD9854F044B6 (
//   class '03BCC9520C564E55' ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public  void E3F4BD9854F044B6(03BCC9520C564E55 arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 1 call(s):
    //   0x28d95a3c930  AddWithResize(this.f10, arg0, arg0, ?)
    // 2 store(s):
    //   0x28d95a3c8ee  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3c908  this.f10 <- (movsxd this.f10.f18)+1
    // returns: AddWithResize(this.f10, arg0, arg0, ?)
}
