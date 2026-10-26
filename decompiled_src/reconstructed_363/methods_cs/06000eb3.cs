// ============================================================
// token 0x06000eb3   739C182D1CDD45C5::MoveNext
// native code: 0x28d95a01930  (1418 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000003,06000eb5,06000006,06000eb6,06000eb7,06000005,06004674,06000004
// native-strings: 0x2fe0:Connection ready
// ============================================================

// OUTER ASYNC METHOD token 0x06000e6a
// state-machine class: 739C182D1CDD45C5 ; fields: 4
//   .field public int32 '0C29B7A69F4C4752'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '96E7C072631E432D'
//   .field public class '02C54685DE0E4B81' '6A90F8A5D2604BF0'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '84A474E617C64E6B'
private async Task 204ED62F8A484557()
{
    this.<>1__state = 0;
    this.<>1__state = -1;
    this.<>1__state = -1;
    this.<>1__state = -2;
    // 1 await site(s):
    //   await #1 @0x28d95a01b38  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d95a01a28  <Module>::8B9C7B12B1AE4949((movsxd 0xeb82211a))   ; "Connection ready"
    //   0x28d95a01a48  739C182D1CDD45C5::06102EFDDFCD4901(this.f20.f60, <Module>::8B9C7B12B1AE4949((movsxd 0xeb82211a)), 0x28cc7550840)
    //   0x28d95a01ab8  <Module>::58ECCB512F2A43AC((movsxd 0x1505777c))   ; =0
    //   0x28d95a01b38  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffffa0), this, ?)
    //   0x28d95a01b60  739C182D1CDD45C5::6E8581D93B374C0F(this.f20)
    //   0x28d95a01b70  739C182D1CDD45C5::5B740E2692EF48A1(739C182D1CDD45C5::6E8581D93B374C0F(this.f20))
    //   0x28d95a01c38  <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57))   ; =-1
    //   0x28d95a01c70  GetResult((? add 0xffffffffffffffa0), <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), this, ?)
    //   0x28d95a01d30  <Module>::F84FA79ABE6944BB((movsxd 0x56d54e19), ((((0x2bc1c3a2 sub (((movsxd (movsxd 0xb04074a0)) neg 0x1) sub 0x7237983ffefa517)) xor 0x8ee1b006) div 0x3) mod 0x3), this, ?)
    //   0x28d95a01d78  sub_28c8598b8d0((this add 0x8), 0x0, this, ?)
    //   0x28d95a01d98  ?(sub_28c8598b8d0((this add 0x8), 0x0, this, ?), 0x0, this, ?)
    //   0x28d95a01dd8  <Module>::390073C602714496((movsxd 0x30c4c57f))   ; =-2
    //   0x28d95a01eb0  THROW(0x162, 0x2d6)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
