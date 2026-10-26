// ============================================================
// token 0x06000281   9141790102E746D1::MoveNext
// native code: 0x28d95a2f670  (1362 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000005,06000283,0600463d,06000006,06000003,06004674,06000004,06004673
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x0600026f
// state-machine class: 9141790102E746D1 ; fields: 4
//   .field public int32 '19A852C36C754AB1'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder C7A5FA5508DB470A
//   .field public class A19CBF069C964833 '7DF8495D10AC4983'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '49BBF9FE47DC4385'
private async Task DA96FE2A9A0442AB()
{
    // <>1__state <- <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (? add 0xffffffffffffffa0), this, ?)
    this.<>1__state = 0;
    this.<>1__state = 0;
    this.<>1__state = 0;
    // 1 await site(s):
    //   await #1 @0x28d95a2f770  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d95a2f770  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffffa0), this, ?)
    //   0x28d95a2f7b8  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (? add 0xffffffffffffffa0), this, ?)
    //   0x28d95a2f820  9141790102E746D1::99525D2F8F8B4F51(this.f20.f18)
    //   0x28d95a2f8f8  TaskAwaiter::GetResult((? add 0xffffffffffffffa0), 9141790102E746D1::99525D2F8F8B4F51(this.f20.f18), this, ?)
    //   0x28d95a2f940  <Module>::58ECCB512F2A43AC((movsxd 0x1505777c))   ; =0
    //   0x28d95a2fa28  <Module>::8B9C7B12B1AE4949((movsxd 0xd72b2571), (((((((((((movsxd 0xaa0d8a13) imul 0x81973db5) neg 0x1) sub 0x585c1c23) neg 0x1) add 0x18d62a4634836d15) add 0xf28c8b68) xor 0x7cdae1a1) imul 0x4aa1857d
    //   0x28d95a2fa70  sub_28c8598b8d0((this add 0x8), 0x0, this, ?)
    //   0x28d95a2fa90  ?(sub_28c8598b8d0((this add 0x8), 0x0, this, ?), 0x0, this, ?)
    //   0x28d95a2fad0  <Module>::390073C602714496((movsxd 0x30c4c57f), 0x0, this, ?)
    //   0x28d95a2fbb8  THROW(0x162, 0x326)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
