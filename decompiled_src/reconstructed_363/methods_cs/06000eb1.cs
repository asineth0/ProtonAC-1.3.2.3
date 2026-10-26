// ============================================================
// token 0x06000eb1   859517ED378E4302::MoveNext
// native code: 0x28d958df8d0  (445 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000004
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06000e6b
// state-machine class: 859517ED378E4302 ; fields: 2
//   .field public int32 B90231064F464324
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '0EA3C176BFCC48CF'
private async Task 44AD45EE94144118()
{
    this.<>1__state = -2;
    // no await sites -> the method completes synchronously.
    // native action order (address order):
    //   0x28d958df9b8  <Module>::390073C602714496((movsxd 0x30c4c57f))   ; =-2
    this.<>t__builder.SetResult();
}
