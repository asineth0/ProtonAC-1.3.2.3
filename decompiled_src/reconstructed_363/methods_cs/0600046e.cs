// ============================================================
// token 0x0600046e   D847CB6AB9214147::MoveNext
// native code: 0x28d95a0e0b0  (5780 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 0600467c,06000004,06000470,06000471,06000007,06000005,06000466,06000003,06004649,06000479,0600047a,06000b98,06000478,060022d9,06000476,06000477,06000472,06000473,06000474,06000475,0600047d,06004680
// native-strings: 0x1554:Instance.DO_NOT_DELETE
// ============================================================

// OUTER ASYNC METHOD token 0x06000467
// state-machine class: D847CB6AB9214147 ; fields: 6
//   .field public int32 C6C01598EE5F4123
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<bool> DDC18242C06D4429
//   .field private class '02C54685DE0E4B81' '952809FD20024B62'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter F52B75DF490A4D30
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<bool> F27A5D071B4C4F56
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<string> '376085A5CFE24545'
private async Task<bool> 4D65BD4381F7417B()
{
    // <>1__state <- <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xfffffffffffffe88), this, ?)
    this.<>1__state = 2;
    this.<>1__state = -1;
    this.<>1__state = -1;
    // 4 await site(s):
    //   await #1 @0x28d95a0e230  type=Runtime.CompilerServices.TaskAwaiter
    //   await #2 @0x28d95a0ed88  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //      awaiter source: Task`1::GetAwaiter(D847CB6AB9214147::01701AC83A804EFB((rsi xor rsi), 0x28cca2db200.f0, this, ?), 0x28cca2db200.f0, this, ?)
    //   await #3 @0x28d95a0f138  type=Runtime.CompilerServices.TaskAwaiter`1<string>
    //      awaiter source: Task`1::GetAwaiter(D847CB6AB9214147::01701AC83A804EFB((rsi xor rsi), 0x28cca2db200.f0, this, ?), 0x28cca2db200.f0, this, ?)
    //   await #4 @0x28d95a0f1a0  type=Runtime.CompilerServices.TaskAwaiter
    //      awaiter source: Task`1::GetAwaiter(D847CB6AB9214147::01701AC83A804EFB((rsi xor rsi), 0x28cca2db200.f0, this, ?), 0x28cca2db200.f0, this, ?)
    //
    // native action order (address order):
    //   0x28d95a0e230  [await] AsyncTaskMethodBuilder`1::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe88), this, ?)
    //   0x28d95a0e278  <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xfffffffffffffe88), this, ?)
    //   0x28d95a0e2d0  D847CB6AB9214147::BF976D3489524F87(0x28d03540bc0, 0x28cca2db200.f0)
    //   0x28d95a0e2e0  D847CB6AB9214147::C437267A5B424E3A(D847CB6AB9214147::BF976D3489524F87(0x28d03540bc0, 0x28cca2db200.f0))
    //   0x28d95a0e358  GetResult((? add 0xfffffffffffffe88), 0x28cca2db200.f0, this, ?)
    //   0x28d95a0e388  <Module>::3F57E81A62734AC2((movsxd 0x94857146), 0x28cca2db200.f0, this, ?)
    //   0x28d95a0e400  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4))   ; =1
    //   0x28d95a0e440  <Module>::3F57E81A62734AC2((movsxd 0xcd941453))   ; =2
    //   0x28d95a0e4c0  <Module>::390073C602714496((movsxd 0x7f132d63), 0x28cca2db200.f0, this, ?)
    //   0x28d95a0e518  sub_28b82780dcb((this add 0x28), D847CB6AB9214147::C437267A5B424E3A(D847CB6AB9214147::BF976D3489524F87(0x28d03540bc0, 0x28cca2db200.f0)), this, ?)
    //   0x28d95a0e550  8162F8F545F5474A::AEC8A7807AAE4A85()
    //   0x28d95a0e618  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4))   ; =1
    //   0x28d95a0e720  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0))   ; =-1
    //   0x28d95a0e780  <Module>::390073C602714496((movsxd 0xd413acc0), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0)), this, ?)
    //   0x28d95a0e810  <Module>::390073C602714496((movsxd 0xd413acc0), <Module>::390073C602714496((movsxd 0xd413acc0), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0)), this, ?), this, ?)
    //   0x28d95a0e858  TaskAwaiter`1::GetResult((? add 0xfffffffffffffea8), <Module>::390073C602714496((movsxd 0xd413acc0), <Module>::390073C602714496((movsxd 0xd413acc0), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0)), th
    //   0x28d95a0e868  D847CB6AB9214147::18534523AF2F45F8(TaskAwaiter`1::GetResult((? add 0xfffffffffffffea8), <Module>::390073C602714496((movsxd 0xd413acc0), <Module>::390073C602714496((movsxd 0xd413acc0), <Module>::8B9C7B
    //   0x28d95a0e878  D847CB6AB9214147::AFE002B536684B61(D847CB6AB9214147::18534523AF2F45F8(TaskAwaiter`1::GetResult((? add 0xfffffffffffffea8), <Module>::390073C602714496((movsxd 0xd413acc0), <Module>::390073C602714496((m
    //   0x28d95a0e898  Guid::.ctor((? add 0xfffffffffffffe90), D847CB6AB9214147::AFE002B536684B61(D847CB6AB9214147::18534523AF2F45F8(TaskAwaiter`1::GetResult((? add 0xfffffffffffffea8), <Module>::390073C602714496((movsxd 0x
    //   0x28d95a0e970  D847CB6AB9214147::01701AC83A804EFB((rsi xor rsi), 0x28cca2db200.f0, this, ?)
    //   0x28d95a0e988  Task`1::GetAwaiter(D847CB6AB9214147::01701AC83A804EFB((rsi xor rsi), 0x28cca2db200.f0, this, ?), 0x28cca2db200.f0, this, ?)
    //   0x28d95a0e9e0  <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7))   ; =1
    //   0x28d95a0ea60  sub_28d95a0f3a8((this add 0x30), (this add 0x30).f0, this, ?)
    //   0x28d95a0ea80  sub_28b82785f1f((this add 0x30), (this add 0x30).f0, this, ?)
    //   0x28d95a0eaf0  <Module>::F84FA79ABE6944BB((movsxd 0xab2d2f50), (this add 0x30).f0, this, ?)
    //   0x28d95a0eb48  sub_28b82780dcb((this add 0x38), Task`1::GetAwaiter(D847CB6AB9214147::01701AC83A804EFB((rsi xor rsi), 0x28cca2db200.f0, this, ?), 0x28cca2db200.f0, this, ?), this, ?)
    //   0x28d95a0ebe8  D847CB6AB9214147::02F1F6ED82FD4C17((? add 0xfffffffffffffef8), (movzx 0x28cc768cd58.f0))
    //   0x28d95a0ec20  D847CB6AB9214147::B0C11BA67A5544C5(this.f20, D847CB6AB9214147::02F1F6ED82FD4C17((? add 0xfffffffffffffef8), (movzx 0x28cc768cd58.f0)), 0x28cca2db200.f0)
    //   0x28d95a0ed38  <Module>::F84FA79ABE6944BB((movsxd 0xab4f8e70), D847CB6AB9214147::02F1F6ED82FD4C17((? add 0xfffffffffffffef8), (movzx 0x28cc768cd58.f0)), 0x28cca2db200.f0, ?)
    //   0x28d95a0ed88  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffea0), this, ?)
    //   0x28d95a0ed9a  sub_28d95a0f3a8((this add 0x8), (? add 0xfffffffffffffea0), this, ?)
    //   0x28d95a0edc0  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffea0), this, ?)
    //   0x28d95a0ede0  GetResult((? add 0xfffffffffffffea0), (? add 0xfffffffffffffea0), this, ?)
    //   0x28d95a0edf9  sub_28d95a0f3a8((? add 0xfffffffffffffea0), (? add 0xfffffffffffffea0), this, ?)
    //   0x28d95a0ee18  sub_28b82785f1f((? add 0xfffffffffffffea0), (? add 0xfffffffffffffea0), this, ?)
    //   0x28d95a0eed8  D847CB6AB9214147::02F1F6ED82FD4C17((? add 0xffffffffffffff20), (movzx 0x28cc768cd58.f0), this, ?)
    //   0x28d95a0ef10  D847CB6AB9214147::B0C11BA67A5544C5(this.f20, D847CB6AB9214147::02F1F6ED82FD4C17((? add 0xffffffffffffff20), (movzx 0x28cc768cd58.f0), this, ?), 0x28cca2db200.f0, ?)
    //   0x28d95a0ef48  sub_28b82780dcb((? add 0xfffffffffffffeb8), D847CB6AB9214147::02F1F6ED82FD4C17((? add 0xffffffffffffff20), (movzx 0x28cc768cd58.f0), this, ?), 0x28cca2db200.f0, ?)
    //   0x28d95a0efe0  D847CB6AB9214147::4EAD3D0EAD5D400A()
    //   0x28d95a0eff0  D847CB6AB9214147::0D78859E0FEC485C(D847CB6AB9214147::4EAD3D0EAD5D400A())
    //   0x28d95a0f030  <Module>::3F57E81A62734AC2((movsxd 0x354bb836))   ; "Instance.DO_NOT_DELETE"
    //   0x28d95a0f048  D847CB6AB9214147::E243DA7E07B24655(D847CB6AB9214147::0D78859E0FEC485C(D847CB6AB9214147::4EAD3D0EAD5D400A()), <Module>::3F57E81A62734AC2((movsxd 0x354bb836)))
    //   0x28d95a0f070  D847CB6AB9214147::975824755FAC4C70(D847CB6AB9214147::E243DA7E07B24655(D847CB6AB9214147::0D78859E0FEC485C(D847CB6AB9214147::4EAD3D0EAD5D400A()), <Module>::3F57E81A62734AC2((movsxd 0x354bb836))))
    //   0x28d95a0f108  sub_28b82780dcb((this add 0x30), D847CB6AB9214147::B0C11BA67A5544C5(this.f20, D847CB6AB9214147::02F1F6ED82FD4C17((? add 0xffffffffffffff20), (movzx 0x28cc768cd58.f0), this, ?), 0x28cca2db200.f0, ?), 0
    //   0x28d95a0f138  [await] AsyncTaskMethodBuilder`1::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffea0), this, ?)
    //   0x28d95a0f14a  sub_28d95a0f3a8((this add 0x8), (? add 0xfffffffffffffea0), this, ?)
    //   0x28d95a0f170  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffea0), this, ?)
    //   0x28d95a0f1a0  [await] AsyncTaskMethodBuilder`1::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffea8), this, ?)
    //   0x28d95a0f1d8  TaskAwaiter`1::GetResult((? add 0xfffffffffffffea0), (? add 0xfffffffffffffea8), this, ?)
    //   0x28d95a0f1f1  sub_28d95a0f3a8((? add 0xfffffffffffffea0), (? add 0xfffffffffffffea8), this, ?)
    //   0x28d95a0f210  sub_28b82785f1f((? add 0xfffffffffffffea0), (? add 0xfffffffffffffea8), this, ?)
    //   0x28d95a0f4b8  D847CB6AB9214147::5EE35F166AA84765(0x28d03540bc0)
    //   0x28d95a0f638  sub_28c8598b8d0((this add 0x8), (rsi xor rsi), this, ?)
    //   0x28d95a0f658  ?(sub_28c8598b8d0((this add 0x8), (rsi xor rsi), this, ?), (rsi xor rsi), this, ?)
    //   0x28d95a0f698  <Module>::8B9C7B12B1AE4949((movsxd 0xd72b2571))   ; =-2
    //   0x28d95a0f710  THROW(0x162, 0x63a)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
