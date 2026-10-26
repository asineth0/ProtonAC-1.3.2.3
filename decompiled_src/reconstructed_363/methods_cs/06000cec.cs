// ============================================================
// token 0x06000cec   3DBA106924E9431F::.ctor
// native code: 0x28d958624f0  (105 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   string '',
//   class [ProtonAC.UniTask]Cysharp.Threading.Tasks.Channel`1<valuetype '3DBA106924E9431F'/'0CAF5A99CBFA42D0'> ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public  void .ctor(string arg0, Cysharp.Channel<valuetype 3DBA106924E9431F.0CAF5A99CBFA42D0> arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 2 call(s):
    //   0x28d95862520  WBARRIER(this+10, arg0)
    //   0x28d95862540  WBARRIER(this+18, arg0)
    // 2 store(s):
    //   0x28d95862511  this+10 <- arg0
    //   0x28d95862532  this+18 <- arg1.f18
    // returns: arg1.f18
}
