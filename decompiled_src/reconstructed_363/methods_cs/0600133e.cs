// ============================================================
// token 0x0600133e   EB69693599F64B76::954D94EBDE984D59
// native code: 0x28d958b6f40  (403 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname
//   instance void '954D94EBDE984D59' (
//   class [netstandard]System.Func`1<class [netstandard]System.Threading.Tasks.Task> ''
//   ) cil managed
//   
// native-calls: 0600134e
// native-strings: 
// ============================================================

public  void 954D94EBDE984D59(Func<class Task> arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958b7008  EB69693599F64B76::11D1055F90F84D70(this.f80, arg0)
    //   0x28d958b7030  sub_28c85c9b7f0(EB69693599F64B76::11D1055F90F84D70(this.f80, arg0), 0x28cc833dce8, 0x28d0dfbfbd0, ?)
    //   0x28d958b7060  WBARRIER((this add 0x80), 0x28cc833dce8)
    //   0x28d958b70d0  THROW(0x162, 0x96)
    // returns: this.f80
}
