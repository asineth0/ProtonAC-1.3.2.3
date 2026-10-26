// ============================================================
// token 0x060012dd   1FFBEDFB3FCE4374::533FDA357CCF49A3
// native code: 0x28d958b1230  (467 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   void '533FDA357CCF49A3' (
//   string '',
//   class [netstandard]System.Func`1<class [netstandard]System.Threading.Tasks.Task> '',
//   valuetype [netstandard]System.Nullable`1<valuetype [netstandard]System.Threading.CancellationToken> '',
//   [opt] class [netstandard]System.Action`1<class [netstandard]System.Exception> ''
//   ) cil managed
//   
// native-calls: 060012e0,060012e1
// native-strings: 
// ============================================================

public static void 533FDA357CCF49A3(string arg0, Func<class Task> arg1, Nullable<valuetype Threading.CancellationToken> arg2, class Action<class Exception> arg3)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 9 call(s):
    //   0x28d958b1268  1FFBEDFB3FCE4374::931C8C843B2A4063()
    //   0x28d958b1288  WBARRIER((1FFBEDFB3FCE4374::931C8C843B2A4063() add 0x10), arg1)
    //   0x28d958b12a8  WBARRIER((1FFBEDFB3FCE4374::931C8C843B2A4063() add 0x18), arg1)
    //   0x28d958b12c8  WBARRIER((1FFBEDFB3FCE4374::931C8C843B2A4063() add 0x20), arg1)
    //   0x28d958b12f0  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d958b1320  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), arg1)
    //   0x28d958b13b8  1FFBEDFB3FCE4374::2962EFF6F7D74252(ALLOC_OBJECT(0x28cc8356f60), ((? add 0xffffffffffffffd0) add 0x8).f0)
    //   0x28d958b13e8  THROW(0x162, 0xee)
    //   0x28d958b1400  THROW(0xf3, 0x12d)
    // 9 store(s):
    //   0x28d958b1276  (1FFBEDFB3FCE4374::931C8C843B2A4063() add 0x10) <- arg1
    //   0x28d958b129a  (1FFBEDFB3FCE4374::931C8C843B2A4063() add 0x18) <- arg3
    //   0x28d958b12ba  (1FFBEDFB3FCE4374::931C8C843B2A4063() add 0x20) <- arg0
    //   0x28d958b1307  ALLOC_OBJECT(0x28cc8356f60) <- 1FFBEDFB3FCE4374::931C8C843B2A4063()
    //   0x28d958b1335  ALLOC_OBJECT(0x28cc8356f60) <- 0x28ccda9b968
    //   0x28d958b1343  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94e6a3a0
    //   0x28d958b1355  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94e6a3a8.f28
    //   0x28d958b135d  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94e6a3a8.f20
    //   0x28d958b1361  ALLOC_OBJECT(0x28cc8356f60) <- 0x0
    // returns: 1FFBEDFB3FCE4374::2962EFF6F7D74252(ALLOC_OBJECT(0x28cc8356f60), ((? add 0xffffffffffffffd0) add 0x8).f0)
}
