// ============================================================
// token 0x06000453   77F0FE2BC2764C1F::MoveNext
// native code: 0x28d97014150  (7678 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000003,06000007,06000432,06000457,06000455,06000006,06000456,06000004,06000feb,0600045a,06000005,06000459,06006143,06006153,06005ed9,06001078,0600045b,0600045c,06000458,06004671,06004657,06005ecf,06004673
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x0600043c
// state-machine class: 77F0FE2BC2764C1F ; fields: 17
//   .field public int32 '079166EB603C4718'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '2C3066477ECC4A21'
//   .field public valuetype [netstandard]System.Threading.CancellationToken D03C93B4516D4F4A
//   .field public class C4462CD02B8C4225 '355CDC03936E402F'
//   .field private valuetype [netstandard]System.TimeSpan '23A83DDEFF6A4AE2'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter '2F309EE39DF64E66'
//   .field private valuetype [netstandard]System.Collections.Generic.Dictionary`2/Enumerator<valuetype '6C63CD6C48F7495C', class [netstandard]System.Collections.Concurrent.ConcurrentQueue`1<class '0D2DBD97EB44499A'>> '340259D6521D4C34'
//   .field private class [netstandard]System.Collections.Generic.List`1<class '0D2DBD97EB44499A'> '3F0A02CD93EF43DB'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<bool> C89071EBB34F4269
//   .field private static literal int32 '66DDDD6431644C28' = int32(10000)
//   .field private static literal int32 '932E3B87C7D34770' = int32(250)
//   .field private initonly valuetype [netstandard]System.Threading.CancellationToken '16064A0D6557431D'
//   .field private initonly class [netstandard]System.Collections.Generic.Dictionary`2<valuetype '6C63CD6C48F7495C', class [netstandard]System.Collections.Concurrent.ConcurrentQueue`1<class '0D2DBD97EB44499A'>> '6D7F73BCD68340FD'
//   .field private initonly class [netstandard]System.Collections.Concurrent.ConcurrentQueue`1<valuetype C4462CD02B8C4225/'147B5CF1E696412C'> '39BCE4E1FD2E4699'
//   .field private initonly class [netstandard]System.Threading.SemaphoreSlim '6BE379233BB1472B'
//   .field private initonly class [netstandard]System.Threading.CancellationTokenSource '97EB2FD7B1C74F2F'
//   .field private class [netstandard]System.Threading.Tasks.Task '059ABF0DBDDA4503'
private async Task 8112AE6BB2924ED0(Threading.CancellationToken arg0)
{
    this.<>1__state = -1;
    this.<>1__state = 0;
    this.<>1__state = 1;
    this.<>1__state = 1;
    // 2 await site(s):
    //   await #1 @0x28d97014a38  type=Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter
    //   await #2 @0x28d97015698  type=Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<bool>
    //
    // native action order (address order):
    //   0x28d97014268  <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994))   ; =1
    //   0x28d97014338  <Module>::8B9C7B12B1AE4949((movsxd 0x3a954ccc))   ; =0
    //   0x28d97014348  FromSeconds((movsxd 0x3a954ccc), (((((((movsxd 0x4f3b4b43) not 0x1) add 0x4bd308b1f1b7f56c) add 0x1aa3767abac78a) add 0xd22ca4e12f7def7f) div 0x3) mod 0x3), ?, ?)
    //   0x28d97014450  <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93))   ; =-1
    //   0x28d970144e0  C4462CD02B8C4225::52B77E4921B64EFB(this.f28)
    //   0x28d970144f0  77F0FE2BC2764C1F::DA7792CDCF154322(C4462CD02B8C4225::52B77E4921B64EFB(this.f28))
    //   0x28d970145b0  77F0FE2BC2764C1F::17FD514258ED40C2((this add 0x30).f0, (this add 0x20).f0)
    //   0x28d970145e8  <Module>::58ECCB512F2A43AC((movsxd 0x1505777c))   ; =0
    //   0x28d97014610  77F0FE2BC2764C1F::3E10781D0F7B474F(77F0FE2BC2764C1F::17FD514258ED40C2((this add 0x30).f0, (this add 0x20).f0), (? add 0xfffffffffffffe08))
    //   0x28d97014678  <Module>::390073C602714496((movsxd 0xf10a970c))   ; =1
    //   0x28d970147b8  GetResult((? add 0xfffffffffffffdb8), (? add 0xfffffffffffffe08), <Module>::58ECCB512F2A43AC((movsxd 0x1505777c)), ?)
    //   0x28d970147d0  C4462CD02B8C4225::52B77E4921B64EFB(this.f28)
    //   0x28d970148d0  GetEnumerator(this.f28.f18, (? add 0xfffffffffffffe28), <Module>::58ECCB512F2A43AC((movsxd 0x1505777c)), ?)
    //   0x28d97014a38  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffdb8), this, ?)
    //   0x28d97014a80  <Module>::3F57E81A62734AC2((movsxd 0x94857146))   ; =0
    //   0x28d97014ae8  <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994))   ; =1
    //   0x28d97014b98  C4462CD02B8C4225::52B77E4921B64EFB(this.f28, (((((((movsxd 0x7b0b1757) not 0x1) add 0x4bd308b1f1b7f56c) add 0x1aa3767abac78a) add 0xd22ca4e12f7def7f) div 0x19) mod 0x19), this, ?)
    //   0x28d97014c28  <Module>::58ECCB512F2A43AC((movsxd 0x10c584a9), (this add 0x20).f0, this, ?)
    //   0x28d97014c38  TimeSpan::FromMinutes((movsxd 0x10c584a9), (this add 0x20).f0, this, ?)
    //   0x28d97014d10  77F0FE2BC2764C1F::8F7065512BE24B35(C4462CD02B8C4225::52B77E4921B64EFB(this.f28, (((((((movsxd 0x7b0b1757) not 0x1) add 0x4bd308b1f1b7f56c) add 0x1aa3767abac78a) add 0xd22ca4e12f7def7f) div 0x19) mod 0
    //   0x28d97014d48  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515), (rax xor rax), (this add 0x20).f0, (? add 0xffffffffffffff18))
    //   0x28d97014e18  sub_28b82780dcb((? add 0xfffffffffffffe98), (? add 0xfffffffffffffe98), (this add 0x20).f0, (? add 0xffffffffffffff18))
    //   0x28d97014e88  sub_28b82780dcb((? add 0xfffffffffffffe88), ((? add 0xfffffffffffffe88) xor (? add 0xfffffffffffffe88)), (this add 0x20).f0, (? add 0xffffffffffffff18))
    //   0x28d97015088  77F0FE2BC2764C1F::75417B2457F04DCA((movzx (movzx (movzx (? add 0xfffffffffffffdd8).f0))), this.f70, (this add 0x20).f0, (? add 0xffffffffffffff18))
    //   0x28d97015108  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4), this.f70, (this add 0x20).f0, (? add 0xffffffffffffff18))
    //   0x28d97015180  List`1::.ctor(ALLOC_OBJECT(0x28d93fc6af0), (movsxd (rax xor rax)), (this add 0x20).f0, (? add 0xffffffffffffff18))
    //   0x28d970151b0  sub_28b82780dcb((this add 0x70), (movsxd (rax xor rax)), (this add 0x20).f0, (? add 0xffffffffffffff18))
    //   0x28d970151d8  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515), (movsxd (rax xor rax)), (this add 0x20).f0, (? add 0xffffffffffffff18))
    //   0x28d97015208  get_IsEmpty((rax xor rax), (movsxd (rax xor rax)), (this add 0x20).f0, (? add 0xffffffffffffff18))
    //   0x28d97015348  List`1::AddWithResize(this.f70, (rax xor rax), (rax xor rax), (? add 0xffffffffffffff18))
    //   0x28d97015390  ConcurrentQueue`1::TryDequeue((rax xor rax), (? add 0xfffffffffffffd78), (rax xor rax), (? add 0xffffffffffffff18))
    //   0x28d97015460  C179263454B44BF6::3FA59457D2AF4C76((movsxd 0x2dc097cb), (? add 0xfffffffffffffd78), (rax xor rax), (? add 0xffffffffffffff18))
    //   0x28d970154a0  <Module>::390073C602714496((movsxd 0xe8917fab), (? add 0xfffffffffffffd78), (rax xor rax), (? add 0xffffffffffffff18))
    //   0x28d97015518  77F0FE2BC2764C1F::8265F6F9887649F8(<Module>::390073C602714496((movsxd 0xe8917fab), (? add 0xfffffffffffffd78), (rax xor rax), (? add 0xffffffffffffff18)), ALLOC_OBJECT(0x28c852328c8), (rax xor rax), (
    //   0x28d97015540  77F0FE2BC2764C1F::07F8567D04E84D6A(C179263454B44BF6::3FA59457D2AF4C76((movsxd 0x2dc097cb), (? add 0xfffffffffffffd78), (rax xor rax), (? add 0xffffffffffffff18)), 77F0FE2BC2764C1F::8265F6F9887649F8(<M
    //   0x28d970155c8  <Module>::3F57E81A62734AC2((movsxd 0x99880819), 77F0FE2BC2764C1F::8265F6F9887649F8(<Module>::390073C602714496((movsxd 0xe8917fab), (? add 0xfffffffffffffd78), (rax xor rax), (? add 0xffffffffffffff18)
    //   0x28d970155e0  77F0FE2BC2764C1F::73C6D060AAE140CD((movsxd (movsxd (rax xor rax))), <Module>::3F57E81A62734AC2((movsxd 0x99880819), 77F0FE2BC2764C1F::8265F6F9887649F8(<Module>::390073C602714496((movsxd 0xe8917fab), (
    //   0x28d97015650  sub_28b82780dcb((this add 0x78), (? add 0xfffffffffffffdf8).f0, 0x28cc7550840, (? add 0xffffffffffffff18))
    //   0x28d97015698  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffde8), this, (? add 0xffffffffffffff18))
    //   0x28d970156aa  sub_28d97015a98((this add 0x8), (? add 0xfffffffffffffde8), this, (? add 0xffffffffffffff18))
    //   0x28d970156d0  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffde8), this, (? add 0xffffffffffffff18))
    //   0x28d970156f0  ConfiguredTaskAwaiter::GetResult((? add 0xfffffffffffffde8), (? add 0xfffffffffffffde8), this, (? add 0xffffffffffffff18))
    //   0x28d97015788  <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7), (? add 0xfffffffffffffde8), this, (? add 0xffffffffffffff18))
    //   0x28d97015810  <Module>::390073C602714496((movsxd 0x7f132d63), <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7), (? add 0xfffffffffffffde8), this, (? add 0xffffffffffffff18)), this, (? add 0xffffffffffffff18))
    //   0x28d970158c8  <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7), (? add 0xfffffffffffffde8), this, (? add 0xffffffffffffff18)), this, (? add 0xffffffffffffff18))
    //   0x28d97015928  MoveNext((this add 0x48), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7), (? add 0xfffffffffffffde8), this, (? add 0xffffffffffffff18)), this, (? add 0x
    //   0x28d970159f0  ConcurrentQueue`1::get_Count((? add 0xfffffffffffffdd8).f8, <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7), (? add 0xfffffffffffffde8), this, (? add 0xf
    //   0x28d97015a6e  sub_28d97015a98(((((((movsxd 0x7b0b1757) not 0x1) add 0x4bd308b1f1b7f56c) add 0x1aa3767abac78a) add 0xd22ca4e12f7def7f) imul 0xefda2b2c), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), <Module>::3F57
    //   0x28d97015a90  sub_28b82785f1f(((((((movsxd 0x7b0b1757) not 0x1) add 0x4bd308b1f1b7f56c) add 0x1aa3767abac78a) add 0xd22ca4e12f7def7f) imul 0xefda2b2c), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), <Module>::3F57
    //   0x28d97015d00  get_IsCancellationRequested((this add 0x20), (((((((movsxd 0x883889fb) not 0x1) add 0x4bd308b1f1b7f56c) add 0x1aa3767abac78a) add 0xd22ca4e12f7def7f) div 0x3) mod 0x3), this, (? add 0xffffffffffffff18
    //   0x28d97015df8  <Module>::3F57E81A62734AC2((movsxd 0x2da21f0a), (((((((movsxd 0x883889fb) not 0x1) add 0x4bd308b1f1b7f56c) add 0x1aa3767abac78a) add 0xd22ca4e12f7def7f) div 0x3) mod 0x3), this, (? add 0xfffffffffffff
    //   0x28d97015ef0  THROW(0x162, 0x566)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
