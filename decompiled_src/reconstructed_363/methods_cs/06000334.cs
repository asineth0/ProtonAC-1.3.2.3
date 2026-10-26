// ============================================================
// token 0x06000334   F1E6C0BAA85E41FE::MoveNext
// native code: 0x28d970345d0  (5181 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000005,06000295,06000007,06000006,06000339,06000003,06004671,0600033a,0600033b,06000004,06004673
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06000292
// state-machine class: F1E6C0BAA85E41FE ; fields: 9
//   .field public int32 '25EEA8A270424A8F'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '42CAD0E6761B44CA'
//   .field public class E651E17AA2CA4BC8 D437C570EBBF4C7B
//   .field public valuetype [netstandard]System.Threading.CancellationToken '0C19E38F669F4552'
//   .field private class [ProtonAC.UniTask]Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<valuetype E651E17AA2CA4BC8/C84D19F98EAA497F> '62927B8FB56E42B8'
//   .field private object '4221C4690B424241'
//   .field private int32 '6C9D81CCC5764C5F'
//   .field private valuetype [ProtonAC.UniTask]Cysharp.Threading.Tasks.UniTask`1/Awaiter<bool> '1B653506FA64431E'
//   .field private valuetype [ProtonAC.UniTask]Cysharp.Threading.Tasks.UniTask/Awaiter B06B6C51A9444FAA
private async Task 408AEEE548064800(Threading.CancellationToken arg0)
{
    this.<>1__state = 0;
    this.<>1__state = 0;
    this.<>1__state = 0;
    this.<>1__state = 0;
    // 2 await site(s):
    //   await #1 @0x28d97035040  type=[ProtonAC.UniTask]Cysharp.Threading.Tasks.UniTask`1/Awaiter<bool>
    //   await #2 @0x28d97035570  type=[ProtonAC.UniTask]Cysharp.Threading.Tasks.UniTask/Awaiter
    //
    // native action order (address order):
    //   0x28d97034780  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4))   ; =1
    //   0x28d970347f0  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515))   ; =0
    //   0x28d97034a70  E651E17AA2CA4BC8::AF700B8F7DCC4112(this.f20, (? add 0xffffffffffffff18), ?, ?)
    //   0x28d97034f70  <Module>::3F57E81A62734AC2((movsxd 0x94857146))   ; =0
    //   0x28d97035040  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe28), this, ?)
    //   0x28d970350c0  <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57), (? add 0xfffffffffffffe28), this, ?)
    //   0x28d970352c8  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), ((((((((((0x89e551c039c388e2 sub (movsxd (movsxd 0xec441165))) imul 0x54c0a3c7) imul 0xaf81c2ff) not 0x1) sub 0x1a9c548c) xor 0xffd30b7ca3c56455) sub 0x
    //   0x28d97035320  F1E6C0BAA85E41FE::C23F7D2ACA144919(this.f30, (? add 0xfffffffffffffeb8), this, ?)
    //   0x28d970353c8  sub_28b82780dcb((? add 0xfffffffffffffed8), (? add 0xfffffffffffffe58).f0, this, ?)
    //   0x28d970354b0  <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994), (? add 0xfffffffffffffe58).f0, this, ?)
    //   0x28d97035528  sub_28b82780dcb((this add 0x58), (this add 0x58).f0, this, ?)
    //   0x28d97035570  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe48), this, ?)
    //   0x28d97035708  ?(this.f38, (movsx (? add 0xfffffffffffffe48).f8), this, ?)
    //   0x28d97035720  F1E6C0BAA85E41FE::A9372F4E59BD4FA9(0x0, (movsx (? add 0xfffffffffffffe48).f8), this, ?)
    //   0x28d97035730  F1E6C0BAA85E41FE::B85F9ED725FB4492(F1E6C0BAA85E41FE::A9372F4E59BD4FA9(0x0, (movsx (? add 0xfffffffffffffe48).f8), this, ?), (movsx (? add 0xfffffffffffffe48).f8), this, ?)
    //   0x28d970358d8  <Module>::390073C602714496((movsxd 0x30c4c57f), (movsx (? add 0xfffffffffffffe48).f8), this, ?)
    //   0x28d970359e0  THROW(0x162, 0x4ef)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
