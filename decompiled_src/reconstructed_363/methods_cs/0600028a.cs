// ============================================================
// token 0x0600028a   FDBED18ADF774DFC::MoveNext
// native code: 0x28d95a3e1f0  (2642 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000006,06000269,0600028c,0600028d,06000003,0600028e,06004674,06000005,06004673
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x0600026c
// state-machine class: FDBED18ADF774DFC ; fields: 7
//   .field public int32 A7AEBB29AECF4FDA
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '725052727B434089'
//   .field public class A19CBF069C964833 F39761786F32412F
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '155E2979890E4BC6'
//   .field private initonly class [netstandard]System.Collections.Generic.List`1<class A19CBF069C964833/'40FE7AC3F69F4B10'> '053FA35E263C40A4'
//   .field private class [netstandard]System.Threading.Tasks.Task FC2574C5E50F455C
//   .field private class [netstandard]System.Threading.CancellationTokenSource E5F3C4E4B8054FD6
private async Task 2D34939E383B44AA()
{
    this.<>1__state = -1;
    this.<>1__state = 0;
    this.<>1__state = 0;
    // 1 await site(s):
    //   await #1 @0x28d95a3e510  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d95a3e350  <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57))   ; =-1
    //   0x28d95a3e398  <Module>::58ECCB512F2A43AC((movsxd 0xefa9bf93))   ; =0
    //   0x28d95a3e3a8  FromMilliseconds((movsxd 0xefa9bf93), <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), ?, ?)
    //   0x28d95a3e3c0  A19CBF069C964833::5E5A0EFC450B41F2(this.f20)
    //   0x28d95a3e3e0  FDBED18ADF774DFC::A4E6CED446E54E9D(FromMilliseconds((movsxd 0xefa9bf93), <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), ?, ?), A19CBF069C964833::5E5A0EFC450B41F2(this.f20))
    //   0x28d95a3e3f0  FDBED18ADF774DFC::5146AC5BA61343EE(FDBED18ADF774DFC::A4E6CED446E54E9D(FromMilliseconds((movsxd 0xefa9bf93), <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57)), ?, ?), A19CBF069C964833::5E5A0EFC450B41F2(t
    //   0x28d95a3e488  <Module>::8B9C7B12B1AE4949((movsxd 0xd8c6f9cd))   ; =0
    //   0x28d95a3e510  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff50), this, ?)
    //   0x28d95a3e5a0  GetResult((? add 0xffffffffffffff50), (? add 0xffffffffffffff50), this, ?)
    //   0x28d95a3e5c8  GetEnumerator(this.f20.f10, (? add 0xffffffffffffff58), this, ?)
    //   0x28d95a3e6b0  FDBED18ADF774DFC::F41CFE168F6B4AB1((rax xor rax))
    //   0x28d95a3e6f0  MoveNext((? add 0xffffffffffffff58), (((((((((((movsxd 0xc1017fd2) sub 0xb570610e3361d28f) add 0xddf96dba5bcbeca) sub 0x1b3e57eca294d4c6) neg 0x1) not 0x1) add 0xffffffff7ed9697f) xor 0x8df0b5eb) not 
    //   0x28d95a3e735  sub_28d95a3e760((? add 0xffffffffffffff58), (((((((((((movsxd 0xc1017fd2) sub 0xb570610e3361d28f) add 0xddf96dba5bcbeca) sub 0x1b3e57eca294d4c6) neg 0x1) not 0x1) add 0xffffffff7ed9697f) xor 0x8df0b5e
    //   0x28d95a3e758  sub_28b82785f1f((? add 0xffffffffffffff58), (((((((((((movsxd 0xc1017fd2) sub 0xb570610e3361d28f) add 0xddf96dba5bcbeca) sub 0x1b3e57eca294d4c6) neg 0x1) not 0x1) add 0xffffffff7ed9697f) xor 0x8df0b5e
    //   0x28d95a3e8a0  A19CBF069C964833::5E5A0EFC450B41F2(this.f20)
    //   0x28d95a3e958  get_IsCancellationRequested((? add 0xffffffffffffff70), (((((((((((movsxd 0xd77a77f7) sub 0xb570610e3361d28f) add 0xddf96dba5bcbeca) sub 0x1b3e57eca294d4c6) neg 0x1) not 0x1) add 0xffffffff7ed9697f) x
    //   0x28d95a3eac0  sub_28c8598b8d0((this add 0x8), (rsi xor rsi), this, ?)
    //   0x28d95a3eae0  ?(sub_28c8598b8d0((this add 0x8), (rsi xor rsi), this, ?), (rsi xor rsi), this, ?)
    //   0x28d95a3eb20  <Module>::F84FA79ABE6944BB((movsxd 0x56d54e19), (rsi xor rsi), this, ?)
    //   0x28d95a3ec38  THROW(0x162, 0x786)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
