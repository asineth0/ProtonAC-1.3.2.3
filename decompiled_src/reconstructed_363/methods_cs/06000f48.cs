// ============================================================
// token 0x06000f48   6DBDED421BCE4AB1::MoveNext
// native code: 0x28d95a19850  (3963 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000007,06000006,06000004,06000f50,06000f51,06000f52,06000f53,06000f4b,06000f54,06000005,06000f4c,06000f4d,06000f4e,06000f4f,06000f55,06000003,06000f4a,06004674
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06000f46
// state-machine class: 6DBDED421BCE4AB1 ; fields: 8
//   .field public int32 '1CF4B12EC37A47BC'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder B08E83EE3C184F9F
//   .field public class '7C3933FE2CD94926' '65C3EBB235A74CEB'
//   .field public class '02C54685DE0E4B81' B2EF364E2A334256
//   .field public valuetype [netstandard]System.Threading.CancellationToken '0C84FE936E20480A'
//   .field private valuetype [ProtonAC.UniTask]Cysharp.Threading.Tasks.SwitchToMainThreadAwaitable/Awaiter '9585D811EAB74062'
//   .field private valuetype [ProtonAC.UniTask]Cysharp.Threading.Tasks.SwitchToThreadPoolAwaitable/Awaiter '620EB4ECE7C94635'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '723D03F3E644495C'
private async Task 9522A597174F41D2(02C54685DE0E4B81 arg0, 7C3933FE2CD94926 arg1, valuetype Threading.CancellationToken arg2)
{
    this.<>1__state = -1;
    this.<>1__state = 3;
    this.<>1__state = 1;
    this.<>1__state = 2;
    // 4 await site(s):
    //   await #1 @0x28d95a19b58  type=[ProtonAC.UniTask]Cysharp.Threading.Tasks.SwitchToMainThreadAwaitable/Awaiter
    //   await #2 @0x28d95a19d00  type=[ProtonAC.UniTask]Cysharp.Threading.Tasks.SwitchToThreadPoolAwaitable/Awaiter
    //   await #3 @0x28d95a19db8  type=Runtime.CompilerServices.TaskAwaiter
    //   await #4 @0x28d95a19fc8  type=[ProtonAC.UniTask]Cysharp.Threading.Tasks.SwitchToMainThreadAwaitable/Awaiter
    //
    // native action order (address order):
    //   0x28d95a19980  GetResult((? add 0xffffffffffffff60), ((((((((((movsxd 0xad9fa41d) not 0x1) add 0xa87b7e58) xor 0xb1bc84a147ff846d) neg 0x1) neg 0x1) sub 0xf615d11d) xor 0xb5534709) div 0x24) mod 0x24), ?, ?)
    //   0x28d95a19a08  <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93))   ; =-1
    //   0x28d95a19a90  <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7))   ; =3
    //   0x28d95a19af0  <Module>::390073C602714496((movsxd 0xf10a970c))   ; =1
    //   0x28d95a19b58  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff50), this, ?)
    //   0x28d95a19b98  <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7))   ; =1
    //   0x28d95a19ba8  6DBDED421BCE4AB1::D0B5BDF7530C4B70(<Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7)))
    //   0x28d95a19bc8  6DBDED421BCE4AB1::90A02C4E75CF44DF(this.f20)
    //   0x28d95a19c08  6DBDED421BCE4AB1::7CFC2E0A847C4773(this.f28, 6DBDED421BCE4AB1::D0B5BDF7530C4B70(<Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7))), 6DBDED421BCE4AB1::90A02C4E75CF44DF(this.f20), (this add 0x30).f0)
    //   0x28d95a19c18  6DBDED421BCE4AB1::B739EEE1338F4003(6DBDED421BCE4AB1::7CFC2E0A847C4773(this.f28, 6DBDED421BCE4AB1::D0B5BDF7530C4B70(<Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7))), 6DBDED421BCE4AB1::90A02C4E75CF44DF(
    //   0x28d95a19d00  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff28), this, (this add 0x30).f0)
    //   0x28d95a19db8  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff60), this, (this add 0x30).f0)
    //   0x28d95a19e08  get_IsCompleted((? add 0xffffffffffffff50), (? add 0xffffffffffffff60), this, (this add 0x30).f0)
    //   0x28d95a19e78  GetResult((? add 0xffffffffffffff60), (? add 0xffffffffffffff60), this, (this add 0x30).f0)
    //   0x28d95a19e88  6DBDED421BCE4AB1::E47270F3F0634EAB()
    //   0x28d95a19e98  6DBDED421BCE4AB1::C889A6BC4235458B(6DBDED421BCE4AB1::E47270F3F0634EAB())
    //   0x28d95a19fc8  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff60), this, (this add 0x30).f0)
    //   0x28d95a1a028  <Module>::3F57E81A62734AC2((movsxd 0xcd941453))   ; =2
    //   0x28d95a1a0d0  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515))   ; =0
    //   0x28d95a1a130  get_IsCompleted((? add 0xffffffffffffff28), <Module>::F84FA79ABE6944BB((movsxd 0x535d8515)), this, (this add 0x30).f0)
    //   0x28d95a1a1c0  GetResult((? add 0xffffffffffffff28), <Module>::F84FA79ABE6944BB((movsxd 0x535d8515)), this, (this add 0x30).f0)
    //   0x28d95a1a1d0  6DBDED421BCE4AB1::E47270F3F0634EAB()
    //   0x28d95a1a1f0  6DBDED421BCE4AB1::8EFBC5DBF2FE4F7A(this.f20)
    //   0x28d95a1a210  6DBDED421BCE4AB1::76BE29EB123B4830(this.f20)
    //   0x28d95a1a230  6DBDED421BCE4AB1::E8524C6C811D45C9(this.f20)
    //   0x28d95a1a258  6DBDED421BCE4AB1::788B4C3D1EE74595(6DBDED421BCE4AB1::E47270F3F0634EAB(), 6DBDED421BCE4AB1::8EFBC5DBF2FE4F7A(this.f20), 6DBDED421BCE4AB1::76BE29EB123B4830(this.f20), 6DBDED421BCE4AB1::E8524C6C811D45C9(
    //   0x28d95a1a2b8  <Module>::390073C602714496((movsxd 0xd413acc0))   ; =-1
    //   0x28d95a1a360  GetResult((? add 0xffffffffffffff50), <Module>::390073C602714496((movsxd 0xd413acc0)), 6DBDED421BCE4AB1::76BE29EB123B4830(this.f20), 6DBDED421BCE4AB1::E8524C6C811D45C9(this.f20))
    //   0x28d95a1a3b0  <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57))   ; =-1
    //   0x28d95a1a3f0  6DBDED421BCE4AB1::7F3FF68E09C84359(this.f28)
    //   0x28d95a1a400  6DBDED421BCE4AB1::B739EEE1338F4003(6DBDED421BCE4AB1::7F3FF68E09C84359(this.f28))
    //   0x28d95a1a508  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0))   ; =-1
    //   0x28d95a1a570  6DBDED421BCE4AB1::C44BE55597F04A3E(this.f20)
    //   0x28d95a1a690  <Module>::F84FA79ABE6944BB((movsxd 0x56d54e19), ((((((((((movsxd 0xd6d46a05) not 0x1) add 0xa87b7e58) xor 0xb1bc84a147ff846d) neg 0x1) neg 0x1) sub 0xf615d11d) xor 0xb5534709) div 0x3) mod 0x3), 6DBDE
    //   0x28d95a1a6e0  sub_28c8598b8d0((this add 0x8), (rax xor rax), 6DBDED421BCE4AB1::76BE29EB123B4830(this.f20), 6DBDED421BCE4AB1::E8524C6C811D45C9(this.f20))
    //   0x28d95a1a700  ?(sub_28c8598b8d0((this add 0x8), (rax xor rax), 6DBDED421BCE4AB1::76BE29EB123B4830(this.f20), 6DBDED421BCE4AB1::E8524C6C811D45C9(this.f20)), (rax xor rax), 6DBDED421BCE4AB1::76BE29EB123B4830(this.f20
    //   0x28d95a1a740  <Module>::F84FA79ABE6944BB((movsxd 0x56d54e19))   ; =-2
    //   0x28d95a1a790  THROW(0x162, 0x25d)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
