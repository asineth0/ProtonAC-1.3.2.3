// ============================================================
// token 0x06001334   EB69693599F64B76::1CA6479155694046
// native code: 0x28d958b65d0  (395 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname
//   instance void '1CA6479155694046' (
//   class [netstandard]System.Func`2<class '652C34B1E6554F10', class [netstandard]System.Threading.Tasks.Task> ''
//   ) cil managed
//   
// native-calls: 0600134e
// native-strings: 
// ============================================================

public  void 1CA6479155694046(Func<class 652C34B1E6554F10, class Task> arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958b6688  EB69693599F64B76::11D1055F90F84D70(this.f58, arg0)
    //   0x28d958b66b0  sub_28c85c9b7f0(EB69693599F64B76::11D1055F90F84D70(this.f58, arg0), 0x28d94d0cc08, 0x28d0dfbf958, ?)
    //   0x28d958b66e0  WBARRIER((this add 0x58), 0x28d94d0cc08)
    //   0x28d958b6758  THROW(0x162, 0x9e)
    // returns: this.f58
}
