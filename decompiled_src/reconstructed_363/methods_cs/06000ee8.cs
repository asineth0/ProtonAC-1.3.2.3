// ============================================================
// token 0x06000ee8   3394AA09403349F1::MoveNext
// native code: 0x28d95a0aab0  (2249 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000eea,06000eee,06000eef,06000007,06000006,06000003,06000005,06000eeb,06000eec,06000eed,06000004,06004680
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06000e72
// state-machine class: 3394AA09403349F1 ; fields: 6
//   .field public int32 '80513F65DA954677'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<bool> BC4F3A5824BC4B52
//   .field public class '652C34B1E6554F10' '2D0BE5512ABA4D4D'
//   .field public class '02C54685DE0E4B81' '0F2ABA2A88274631'
//   .field public valuetype [netstandard]System.Threading.CancellationToken '597A6478BA904A62'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '9F9D2B5CDCAA4ACE'
private async Task<bool> 6E01EC7AE9294356(652C34B1E6554F10 arg0, valuetype Threading.CancellationToken arg1)
{
    this.<>1__state = -1;
    this.<>1__state = 0;
    this.<>1__state = 0;
    this.<>1__state = -2;
    // 1 await site(s):
    //   await #1 @0x28d95a0af78  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d95a0abb8  3394AA09403349F1::3296F3B50FAC4587(this.f28)
    //   0x28d95a0ac48  3394AA09403349F1::0BC8CD3BE6DE499A(this.f28.f10, this.f20, (this add 0x30).f0)
    //   0x28d95a0ac58  3394AA09403349F1::AAC67260D6414B0A(3394AA09403349F1::0BC8CD3BE6DE499A(this.f28.f10, this.f20, (this add 0x30).f0))
    //   0x28d95a0acd0  <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7))   ; =1
    //   0x28d95a0ad50  <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57))   ; =-1
    //   0x28d95a0ad88  GetResult((? add 0xffffffffffffff80), <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), (this add 0x30).f0, ?)
    //   0x28d95a0ae50  <Module>::8B9C7B12B1AE4949((movsxd 0x97605b29), <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), (this add 0x30).f0, ?)
    //   0x28d95a0ae70  <Module>::3F57E81A62734AC2(0x3ca2d4c7, <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), (this add 0x30).f0, ?)
    //   0x28d95a0aeb8  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515), <Module>::3F57E81A62734AC2(0x3ca2d4c7, <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), (this add 0x30).f0, ?), (this add 0x30).f0, ?)
    //   0x28d95a0aed8  3394AA09403349F1::174F3D586E104430(this.f20, <Module>::3F57E81A62734AC2(0x3ca2d4c7, <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), (this add 0x30).f0, ?), (this add 0x30).f0, ?)
    //   0x28d95a0aee8  3394AA09403349F1::24EE1DB505F44140(3394AA09403349F1::174F3D586E104430(this.f20, <Module>::3F57E81A62734AC2(0x3ca2d4c7, <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), (this add 0x30).f0, ?), (this ad
    //   0x28d95a0af18  3394AA09403349F1::BB42B5DACB05475D(this.f28.f60, <Module>::8B9C7B12B1AE4949((movsxd 0x97605b29), <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), (this add 0x30).f0, ?), ALLOC_ARRAY(0x28c8527bc08, <Mo
    //   0x28d95a0af38  <Module>::390073C602714496((movsxd 0x7f132d63), <Module>::8B9C7B12B1AE4949((movsxd 0x97605b29), <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), (this add 0x30).f0, ?), ALLOC_ARRAY(0x28c8527bc08, <Mod
    //   0x28d95a0af78  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff80), this, ?)
    //   0x28d95a0b0e0  <Module>::3F57E81A62734AC2((movsxd 0x94857146))   ; =0
    //   0x28d95a0b250  <Module>::F84FA79ABE6944BB((movsxd 0x56d54e19), ((((0x7162adaaaa75511 sub ((((((movsxd (movsxd 0x20e1d037)) xor 0xd7e04c9879817683) imul 0xfc740353) imul 0x8e7fc93f) neg 0x1) xor 0x9b325be3e9e68ba)) x
    //   0x28d95a0b2a0  sub_28c8598b8d0((this add 0x8), (rsi xor rsi), this, ?)
    //   0x28d95a0b2c0  ?(sub_28c8598b8d0((this add 0x8), (rsi xor rsi), this, ?), (rsi xor rsi), this, ?)
    //   0x28d95a0b300  <Module>::F84FA79ABE6944BB((movsxd 0x56d54e19))   ; =-2
    //   0x28d95a0b368  THROW(0x162, 0x250)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
