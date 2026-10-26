// ============================================================
// token 0x06001677   23352941A2C442FB::.ctor
// native code: 0x28d95a10000  (125 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   valuetype [netstandard]System.Guid '',
//   uint16 ''
//   ) cil managed
//   
// native-calls: 06001940,0600167a,0600167b
// native-strings: 
// ============================================================

public  void .ctor(Guid arg0, ushort arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d95a10028  652C34B1E6554F10::.ctor(this)
    //   0x28d95a10058  23352941A2C442FB::FF78C43EB8534B6F(this, (? add 0xffffffffffffffe8))
    //   0x28d95a10070  23352941A2C442FB::C2A444AEDA7B4277(this, (movzx arg1))
    // returns: 23352941A2C442FB::C2A444AEDA7B4277(this, (movzx arg1))
}
