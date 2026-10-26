// ============================================================
// token 0x0600106c   542A381FC1D44BA3::.ctor
// native code: 0x28d970e4610  (181 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   class [netstandard]System.Type '',
//   string '',
//   valuetype '24AD03718EF64384' '',
//   class [netstandard]System.Type[] '',
//   class [netstandard]System.Type[] ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public  void .ctor(Type arg0, string arg1, 24AD03718EF64384 arg2, Type arg3, Type arg4)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d970e4658  WBARRIER(this+10, arg0)
    //   0x28d970e4670  WBARRIER(this+18, arg0)
    //   0x28d970e4690  WBARRIER(this+20, arg0)
    //   0x28d970e46a8  WBARRIER(this+28, arg0)
    // 5 store(s):
    //   0x28d970e4646  this+10 <- arg0
    //   0x28d970e4660  this+18 <- arg1
    //   0x28d970e4677  this <- (movsxd arg2)
    //   0x28d970e4681  this+20 <- S[rbp+30]
    //   0x28d970e4698  this+28 <- S[rbp+38]
    // returns: WBARRIER(this+28, arg0)
}
