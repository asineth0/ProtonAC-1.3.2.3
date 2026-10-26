// ============================================================
// token 0x06000eaa   24BCE2466670491B::MoveNext
// native code: 0x28d958dd9b0  (541 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000006,06000eac
// native-strings: 0x2fb4:Cloud connected
// ============================================================

// OUTER ASYNC METHOD token 0x06000e6c
// state-machine class: 24BCE2466670491B ; fields: 3
//   .field public int32 C57F5E5C6DFA4A94
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder CEBBD044036643B8
//   .field public class '02C54685DE0E4B81' '8F4AA216B3BA45B8'
private async Task 596C5A2B9AB24C48()
{
    this.<>1__state = -2;
    // no await sites -> the method completes synchronously.
    // native action order (address order):
    //   0x28d958dda08  <Module>::58ECCB512F2A43AC((movsxd 0x1489c0b4))   ; "Cloud connected"
    //   0x28d958dda28  24BCE2466670491B::F94C9F33878A4152(this.f20.f60, <Module>::58ECCB512F2A43AC((movsxd 0x1489c0b4)), 0x28cc7550840)
    //   0x28d958ddaf0  <Module>::58ECCB512F2A43AC((movsxd 0x2b6bc4b0))   ; =-2
    this.<>t__builder.SetResult();
}
