// ============================================================
// token 0x06000f9e   B76A92C9E1D343D1::MoveNext
// native code: 0x28d95a08410  (2097 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000004,06000fa7,06000fa0,06000fa1,06000fa2,06000fa3,06000fa4,06000007,06000005,06000fa5,06000fa6
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06000f9c
// state-machine class: B76A92C9E1D343D1 ; fields: 6
//   .field public int32 '0A74D61E4ED84C0C'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '5DD5E771474D45F7'
//   .field public class FBFDE69E8DC9496E '564E08EE062444F8'
//   .field public class '02C54685DE0E4B81' E5AC9308A2ED4927
//   .field public valuetype [netstandard]System.Threading.CancellationToken '276DF16607C542ED'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<bool> E58D71CDFBC1491C
private async Task DF7DD2D31F8D4DB0(02C54685DE0E4B81 arg0, FBFDE69E8DC9496E arg1, valuetype Threading.CancellationToken arg2)
{
    this.<>1__state = 0;
    this.<>1__state = -1;
    this.<>1__state = -2;
    // 1 await site(s):
    //   await #1 @0x28d95a089f0  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //
    // native action order (address order):
    //   0x28d95a08528  <Module>::390073C602714496((movsxd 0x7f132d63))   ; =0
    //   0x28d95a085d8  B76A92C9E1D343D1::62DCACFBF2424D9F(this.f28, 0x0, (this add 0x30).f0)
    //   0x28d95a08690  B76A92C9E1D343D1::E5F476F246D2485C(this.f20)
    //   0x28d95a086a0  B76A92C9E1D343D1::73789994D90C4AB7(B76A92C9E1D343D1::E5F476F246D2485C(this.f20))
    //   0x28d95a086c8  B76A92C9E1D343D1::C1034F99FA9840A7(this.f20)
    //   0x28d95a08728  B76A92C9E1D343D1::928D7DCFD15C4258(B76A92C9E1D343D1::C1034F99FA9840A7(this.f20), 0x0, (this add 0x30).f0, ?)
    //   0x28d95a08738  B76A92C9E1D343D1::C13A5DF9898046F4(B76A92C9E1D343D1::928D7DCFD15C4258(B76A92C9E1D343D1::C1034F99FA9840A7(this.f20), 0x0, (this add 0x30).f0, ?), 0x0, (this add 0x30).f0, ?)
    //   0x28d95a08770  <Module>::390073C602714496((movsxd 0xa0ee5845), 0x0, (this add 0x30).f0, ?)
    //   0x28d95a08790  <Module>::3F57E81A62734AC2(0xffffffffc28ec3f3, 0x0, (this add 0x30).f0, ?)
    //   0x28d95a087d0  <Module>::F84FA79ABE6944BB(0x535d8515, <Module>::3F57E81A62734AC2(0xffffffffc28ec3f3, 0x0, (this add 0x30).f0, ?), (this add 0x30).f0, ?)
    //   0x28d95a087f0  B76A92C9E1D343D1::E5F476F246D2485C(this.f20, <Module>::3F57E81A62734AC2(0xffffffffc28ec3f3, 0x0, (this add 0x30).f0, ?), (this add 0x30).f0, ?)
    //   0x28d95a08850  <Module>::F84FA79ABE6944BB(0x67cf2da4, <Module>::F84FA79ABE6944BB(0x535d8515, <Module>::3F57E81A62734AC2(0xffffffffc28ec3f3, 0x0, (this add 0x30).f0, ?), (this add 0x30).f0, ?), ALLOC_OBJECT(0x28c86cd
    //   0x28d95a08870  B76A92C9E1D343D1::C1034F99FA9840A7(this.f20, <Module>::F84FA79ABE6944BB(0x535d8515, <Module>::3F57E81A62734AC2(0xffffffffc28ec3f3, 0x0, (this add 0x30).f0, ?), (this add 0x30).f0, ?), ALLOC_OBJECT(0x2
    //   0x28d95a088d8  <Module>::F84FA79ABE6944BB(0xffffffffab2d2f50, <Module>::F84FA79ABE6944BB(0x67cf2da4, <Module>::F84FA79ABE6944BB(0x535d8515, <Module>::3F57E81A62734AC2(0xffffffffc28ec3f3, 0x0, (this add 0x30).f0, ?),
    //   0x28d95a08930  B76A92C9E1D343D1::7642D8F6FAE44B3D(B76A92C9E1D343D1::C13A5DF9898046F4(B76A92C9E1D343D1::928D7DCFD15C4258(B76A92C9E1D343D1::C1034F99FA9840A7(this.f20), 0x0, (this add 0x30).f0, ?), 0x0, (this add 0x30)
    //   0x28d95a089a8  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410))   ; =-1
    //   0x28d95a089f0  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff88), this, ?)
    //   0x28d95a08a10  B76A92C9E1D343D1::E5F476F246D2485C(this.f20)
    //   0x28d95a08a20  B76A92C9E1D343D1::4D7BB8D560F14FAC(B76A92C9E1D343D1::E5F476F246D2485C(this.f20))
    //   0x28d95a08a50  GetResult((? add 0xffffffffffffff88), (? add 0xffffffffffffff88), this, ?)
    //   0x28d95a08b40  <Module>::390073C602714496((movsxd 0x30c4c57f))   ; =-2
    //   0x28d95a08c30  THROW(0x162, 0x2e7)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
