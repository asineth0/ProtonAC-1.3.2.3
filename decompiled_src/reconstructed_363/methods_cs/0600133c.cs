// ============================================================
// token 0x0600133c   EB69693599F64B76::E6FD00CF2EC54A35
// native code: 0x28d958b6ab0  (395 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname
//   instance void E6FD00CF2EC54A35 (
//   class [netstandard]System.Func`1<class [netstandard]System.Threading.Tasks.Task> ''
//   ) cil managed
//   
// native-calls: 0600134e
// native-strings: 
// ============================================================

public  void E6FD00CF2EC54A35(Func<class Task> arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958b6b70  EB69693599F64B76::11D1055F90F84D70(this.f78, arg0)
    //   0x28d958b6b98  sub_28c85c9b7f0(EB69693599F64B76::11D1055F90F84D70(this.f78, arg0), 0x28cc833dce8, 0x28d0dfbfac0, ?)
    //   0x28d958b6bc8  WBARRIER((this add 0x78), 0x28cc833dce8)
    //   0x28d958b6c38  THROW(0x162, 0x96)
    // returns: this.f78
}
