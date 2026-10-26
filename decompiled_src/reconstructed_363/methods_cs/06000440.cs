// ============================================================
// token 0x06000440   81595F2216AD47A4::MoveNext
// native code: 0x28d97017220  (1074 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000004,06000442,0600463d,06000007,06004673
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x0600043e
// state-machine class: 81595F2216AD47A4 ; fields: 4
//   .field public int32 A0F8963F4F8D4B43
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '45DEF16282B243E8'
//   .field public class C4462CD02B8C4225 '62E2507AC5E84ACB'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '252F9CB964FB4491'
private async Task 5F4A801667FE45CC()
{
    this.<>1__state = 0;
    this.<>1__state = 0;
    this.<>1__state = 0;
    // 1 await site(s):
    //   await #1 @0x28d970173b8  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d97017330  <Module>::390073C602714496((movsxd 0x7f132d63))   ; =0
    //   0x28d970173b8  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffffa0), this, ?)
    //   0x28d97017400  <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xffffffffffffffa0), this, ?)
    //   0x28d97017438  81595F2216AD47A4::6DC8261276094061(this.f20.f38)
    //   0x28d970174a0  TaskAwaiter::GetResult((? add 0xffffffffffffffa0), <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xffffffffffffffa0), this, ?), this, ?)
    //   0x28d97017568  <Module>::3F57E81A62734AC2((movsxd 0x2da21f0a), <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xffffffffffffffa0), this, ?), this, ?)
    //   0x28d97017648  THROW(0x162, 0x2f7)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
