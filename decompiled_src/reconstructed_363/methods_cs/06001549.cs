// ============================================================
// token 0x06001549   0EBA44DDBA854271::.ctor
// native code: 0x28d95a04c50  (333 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   string '',
//   valuetype [netstandard]System.Guid '',
//   uint16 ''
//   ) cil managed
//   
// native-calls: 06001940,0600154c,0600154d,0600154e
// native-strings: 
// ============================================================

public  void .ctor(string arg0, Guid arg1, ushort arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a04c88  652C34B1E6554F10::.ctor(this)
    //   0x28d95a04d20  0EBA44DDBA854271::8D5549A5534D4B68(this, arg0)
    //   0x28d95a04d50  0EBA44DDBA854271::9EAC6C2696A04ABF(this, (? add 0xffffffffffffffc8))
    //   0x28d95a04d80  0EBA44DDBA854271::63F4A7D2E418458A(this, (movzx arg2))
    // returns: 0EBA44DDBA854271::63F4A7D2E418458A(this, (movzx arg2))
}
