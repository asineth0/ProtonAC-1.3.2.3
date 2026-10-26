// ============================================================
// token 0x06000f0d   3A8A2A8CACC148DA::MoveNext
// native code: 0x28d958b4fd0  (2261 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000004,06000e69,06000f0f,06000007,06000006,06000f10,06000f11,06000005,06000f12,06000f13,06000003
// native-strings: 0x32f0:Proton Anticheat loading...
// ============================================================

// OUTER ASYNC METHOD token 0x06000e68
// state-machine class: 3A8A2A8CACC148DA ; fields: 6
//   .field public int32 '649CF5BE1B574A2A'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '410D294B220F4D41'
//   .field public class '02C54685DE0E4B81' '53395E1943EE4F37'
//   .field public valuetype [netstandard]System.Threading.CancellationToken CEDDB0532A5A469A
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<bool> DEC29FDF4E5E4303
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter '91CC97A155DC4C01'
private async Task 73E9E2A3C0BD48F5(valuetype Threading.CancellationToken arg0)
{
    this.<>1__state = 0;
    this.<>1__state = -1;
    this.<>1__state = 1;
    this.<>1__state = -1;
    // 2 await site(s):
    //   await #1 @0x28d958b50f8  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //   await #2 @0x28d958b51c0  type=Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter
    //
    // native action order (address order):
    //   0x28d958b50f8  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff60), this, ?)
    //   0x28d958b5140  <Module>::390073C602714496((movsxd 0x7f132d63))   ; =0
    //   0x28d958b51c0  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff58), this, ?)
    //   0x28d958b51d8  02C54685DE0E4B81::E4562FFAB4464AE1(this.f20)
    //   0x28d958b51e8  3A8A2A8CACC148DA::208179AC625E410D()
    //   0x28d958b52d8  <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93))   ; =-1
    //   0x28d958b5338  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b))   ; =1
    //   0x28d958b53e0  GetResult((? add 0xffffffffffffff60), (rax xor rax), this, ?)
    //   0x28d958b5408  3A8A2A8CACC148DA::0B8EE9539D004DFD(this.f20.f40)
    //   0x28d958b5438  3A8A2A8CACC148DA::10C6D6E23D764292(this.f20.f10, 3A8A2A8CACC148DA::0B8EE9539D004DFD(this.f20.f40), this.f20+58.f0)
    //   0x28d958b5460  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515))   ; =0
    //   0x28d958b5480  3A8A2A8CACC148DA::A0D1A3490CB346C7(3A8A2A8CACC148DA::10C6D6E23D764292(this.f20.f10, 3A8A2A8CACC148DA::0B8EE9539D004DFD(this.f20.f40), this.f20+58.f0), (? add 0xffffffffffffff70))
    //   0x28d958b5548  <Module>::390073C602714496((movsxd 0xbf97f982))   ; "Proton Anticheat loading..."
    //   0x28d958b5568  3A8A2A8CACC148DA::BFF8175CE1254DFE(this.f20.f60, <Module>::390073C602714496((movsxd 0xbf97f982)), 0x28cc7550840)
    //   0x28d958b5590  GetResult((? add 0xffffffffffffff58), <Module>::390073C602714496((movsxd 0xbf97f982)), 0x28cc7550840, ?)
    //   0x28d958b55c8  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b))   ; =1
    //   0x28d958b5668  <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57))   ; =-1
    //   0x28d958b5818  <Module>::8B9C7B12B1AE4949((movsxd 0xd72b2571))   ; =-2
    //   0x28d958b5878  THROW(0x162, 0x1e5)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
