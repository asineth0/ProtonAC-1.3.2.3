// ============================================================
// token 0x06001336   EB69693599F64B76::F4738F95C3C04B72
// native code: 0x28d958b6300  (403 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname
//   instance void F4738F95C3C04B72 (
//   class [netstandard]System.Func`1<class [netstandard]System.Threading.Tasks.Task> ''
//   ) cil managed
//   
// native-calls: 0600134e
// native-strings: 
// ============================================================

public  void F4738F95C3C04B72(Func<class Task> arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958b63c0  EB69693599F64B76::11D1055F90F84D70(this.f60, arg0)
    //   0x28d958b63e8  sub_28c85c9b7f0(EB69693599F64B76::11D1055F90F84D70(this.f60, arg0), 0x28cc833dce8, 0x28d0dfbf890, ?)
    //   0x28d958b6418  WBARRIER((this add 0x60), 0x28cc833dce8)
    //   0x28d958b6490  THROW(0x162, 0x9e)
    // returns: this.f60
}
