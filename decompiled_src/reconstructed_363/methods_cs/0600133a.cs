// ============================================================
// token 0x0600133a   EB69693599F64B76::29214BD50A514278
// native code: 0x28d958b6850  (403 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname
//   instance void '29214BD50A514278' (
//   class [netstandard]System.Func`5<valuetype [netstandard]System.Nullable`1<valuetype [netstandard]System.Net.WebSockets.WebSocketCloseStatus>, string, bool, bool, class [netstandard]System.Threading.Tasks.Task> ''
//   ) cil managed
//   
// native-calls: 0600134e
// native-strings: 
// ============================================================

public  void 29214BD50A514278(Func`5<valuetype Nullable<valuetype Net.WebSockets.WebSocketCloseStatus>, string, bool, bool, class Task> arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958b6910  EB69693599F64B76::11D1055F90F84D70(this.f70, arg0)
    //   0x28d958b6938  sub_28c85c9b7f0(EB69693599F64B76::11D1055F90F84D70(this.f70, arg0), 0x28cc85ec348, 0x28d0dfbfa38, ?)
    //   0x28d958b6968  WBARRIER((this add 0x70), 0x28cc85ec348)
    //   0x28d958b69e0  THROW(0x162, 0x9e)
    // returns: (((((0xffffffff816d3ff2 imul 0xb1d06b5b) not 0x1) sub 0xb816109b19976eae) imul 0x6d4253a7) imul 0x3f4488b9)
}
