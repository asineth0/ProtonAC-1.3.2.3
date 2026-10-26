// ============================================================
// token 0x06000fc6   A5083E75A3964193::MoveNext
// native code: 0x28d95a11690  (1562 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000fc8,06000fc9,06000007,06000005,06000004,06004674
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06000fc4
// state-machine class: A5083E75A3964193 ; fields: 4
//   .field public int32 '0415C46AF1F94A4B'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder FFE853CB2B864A60
//   .field public class '9E7CD8E645DD49BC' '484E1BF7540B43ED'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<bool> '25BAC398D076444B'
private async Task 0FD0A40473244371(02C54685DE0E4B81 arg0, 9E7CD8E645DD49BC arg1, valuetype Threading.CancellationToken arg2)
{
    this.<>1__state = 0;
    this.<>1__state = -1;
    this.<>1__state = -1;
    this.<>1__state = -2;
    // 1 await site(s):
    //   await #1 @0x28d95a11980  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //
    // native action order (address order):
    //   0x28d95a11790  A5083E75A3964193::B4651FA2DCFD4D27(this.f20)
    //   0x28d95a117b8  A5083E75A3964193::475E96959E504806((? add 0xffffffffffffffa0))
    //   0x28d95a11850  <Module>::3F57E81A62734AC2((movsxd 0x94857146))   ; =0
    //   0x28d95a11908  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410))   ; =-1
    //   0x28d95a11980  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff80), this, ?)
    //   0x28d95a11a08  GetResult((? add 0xffffffffffffff80), (? add 0xffffffffffffff80), this, ?)
    //   0x28d95a11af0  <Module>::390073C602714496((movsxd 0x30c4c57f), (((0x4adc53b7 sub (((((((0xc5751ce8db6a468d sub (movsxd (movsxd 0xf9276ac6))) imul 0x2921747d) xor 0xb48b267551f7f826) not 0x1) sub 0x901a10e3) neg 0x1)
    //   0x28d95a11b40  sub_28c8598b8d0((this add 0x8), 0x0, this, ?)
    //   0x28d95a11b60  ?(sub_28c8598b8d0((this add 0x8), 0x0, this, ?), 0x0, this, ?)
    //   0x28d95a11ba0  <Module>::390073C602714496((movsxd 0x30c4c57f))   ; =-2
    //   0x28d95a11ca0  THROW(0x162, 0x36d)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
