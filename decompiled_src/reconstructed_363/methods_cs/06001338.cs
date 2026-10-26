// ============================================================
// token 0x06001338   EB69693599F64B76::151A97BEB527479A
// native code: 0x28d958b6d00  (379 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname
//   instance void '151A97BEB527479A' (
//   class [netstandard]System.Func`1<class [netstandard]System.Threading.Tasks.Task> ''
//   ) cil managed
//   
// native-calls: 0600134e
// native-strings: 
// ============================================================

public  void 151A97BEB527479A(Func<class Task> arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958b6db0  EB69693599F64B76::11D1055F90F84D70(this.f68, arg0)
    //   0x28d958b6dd8  sub_28c85c9b7f0(EB69693599F64B76::11D1055F90F84D70(this.f68, arg0), 0x28cc833dce8, 0x28d0dfbfb48, ?)
    //   0x28d958b6e08  WBARRIER((this add 0x68), 0x28cc833dce8)
    //   0x28d958b6e78  THROW(0x162, 0x96)
    // returns: this.f68
}
