// ============================================================
// token 0x0600047e   356AC1AB2B7D4344::MoveNext
// native code: 0x28d95a123d0  (6390 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000004,06000480,06000481,06000482,06000006,06000483,06000484,06000485,06000486,06000003,0600467c,06000489,060022d9,06000007,06004649,0600048a,06000487,06000488,06000005,0600048b,0600048c,0600048d,0600048e,0600048f,06000490
// native-strings: 0x15a0:Backups,0x15ac:Connection,0x1554:Instance.DO_NOT_DELETE
// ============================================================

// OUTER ASYNC METHOD token 0x06000468
// state-machine class: 356AC1AB2B7D4344 ; fields: 11
//   .field public int32 FA9C8281082843FF
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<bool> C8B4C7AB4FEB4C47
//   .field public valuetype [netstandard]System.Guid C1C49604BE974C9C
//   .field private string '60EE526A63C74C81'
//   .field private string '1617F32BA79B44CB'
//   .field private string '8F26E4939C5742E3'
//   .field private string '1AAFE1C9042947E3'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '2A7D0CC45D8A4819'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<string> '608E963776414D23'
//   .field private static initonly valuetype [netstandard]System.Threading.CancellationToken '57AEC1BA18484D6B'
//   .field private static initonly class [netstandard]System.Threading.SemaphoreSlim '048909779F134E08'
private async Task<bool> FF8CE9A823D04023(Guid arg0)
{
    // <>1__state <- <Module>::390073C602714496((movsxd 0x7f132d63), (((((((((movsxd 0x5a1a1933) add 0x5347d55530648d3d) sub 0xa678d3e2) imul 0x30b33de7) add 0xbfb0b50e) add 0xfe614
    // <>1__state <- <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), 0x28cca2db200.f0, <Module>::390073C602714496(0x2ae422ad), ?)
    this.<>1__state = 2;
    this.<>1__state = 2;
    // 3 await site(s):
    //   await #1 @0x28d95a12a50  type=Runtime.CompilerServices.TaskAwaiter
    //   await #2 @0x28d95a12eb0  type=Runtime.CompilerServices.TaskAwaiter`1<string>
    //      awaiter source: Task`1::GetAwaiter(356AC1AB2B7D4344::5D16DDC5BD1D4712(this.f38, 0x28cca2db200.f0, this, ?), 0x28cca2db200.f0, this, ?)
    //   await #3 @0x28d95a13608  type=Runtime.CompilerServices.TaskAwaiter
    //      awaiter source: Task`1::GetAwaiter(356AC1AB2B7D4344::5D16DDC5BD1D4712(this.f38, 0x28cca2db200.f0, this, ?), 0x28cca2db200.f0, this, ?)
    //
    // native action order (address order):
    //   0x28d95a12528  <Module>::390073C602714496((movsxd 0x7f132d63), (((((((((movsxd 0x5a1a1933) add 0x5347d55530648d3d) sub 0xa678d3e2) imul 0x30b33de7) add 0xbfb0b50e) add 0xfe614a890649c993) neg 0x1) div 0xc) mod 0xc),
    //   0x28d95a12568  356AC1AB2B7D4344::251E909A6F02466E()
    //   0x28d95a12578  356AC1AB2B7D4344::E7177445C00247DD(356AC1AB2B7D4344::251E909A6F02466E())
    //   0x28d95a12598  356AC1AB2B7D4344::5BF7E88B8D244588(356AC1AB2B7D4344::E7177445C00247DD(356AC1AB2B7D4344::251E909A6F02466E()), this.f30)
    //   0x28d95a12600  356AC1AB2B7D4344::251E909A6F02466E()
    //   0x28d95a12610  356AC1AB2B7D4344::E7177445C00247DD(356AC1AB2B7D4344::251E909A6F02466E())
    //   0x28d95a12670  <Module>::58ECCB512F2A43AC((movsxd 0x79a0b971))   ; "Backups"
    //   0x28d95a126d0  <Module>::390073C602714496(0x2ae422ad)   ; "Connection"
    //   0x28d95a126f0  356AC1AB2B7D4344::C2F2EB2710DD4FFA(356AC1AB2B7D4344::E7177445C00247DD(356AC1AB2B7D4344::251E909A6F02466E()), <Module>::58ECCB512F2A43AC((movsxd 0x79a0b971)), <Module>::390073C602714496(0x2ae422ad))
    //   0x28d95a12748  ToByteArray((this add 0x20), <Module>::58ECCB512F2A43AC((movsxd 0x79a0b971)), <Module>::390073C602714496(0x2ae422ad), ?)
    //   0x28d95a12758  356AC1AB2B7D4344::75A1BE8D09E0452F(ToByteArray((this add 0x20), <Module>::58ECCB512F2A43AC((movsxd 0x79a0b971)), <Module>::390073C602714496(0x2ae422ad), ?))
    //   0x28d95a127c0  356AC1AB2B7D4344::D8E0D9DFE6F44804(0x28d03540bc0, 0x28cca2db200.f0)
    //   0x28d95a127d0  356AC1AB2B7D4344::491C5DA9A4244B1E(356AC1AB2B7D4344::D8E0D9DFE6F44804(0x28d03540bc0, 0x28cca2db200.f0))
    //   0x28d95a128d0  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), 0x28cca2db200.f0, <Module>::390073C602714496(0x2ae422ad), ?)
    //   0x28d95a12930  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b))   ; =1
    //   0x28d95a12970  <Module>::390073C602714496((movsxd 0xf10a970c))   ; =1
    //   0x28d95a129c8  GetResult((? add 0xfffffffffffffef8), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), 0x28cca2db200.f0, <Module>::390073C602714496(0x2ae422ad), ?), <Module>::390073C602714496(0x2ae422ad), ?)
    //   0x28d95a12a20  sub_28b82780dcb((this add 0x50), (this add 0x50).f0, <Module>::390073C602714496(0x2ae422ad), ?)
    //   0x28d95a12a50  [await] AsyncTaskMethodBuilder`1::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffef8), this, ?)
    //   0x28d95a12ab8  <Module>::8B9C7B12B1AE4949((movsxd 0x1c56525d))   ; "Instance.DO_NOT_DELETE"
    //   0x28d95a12b38  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b))   ; =1
    //   0x28d95a12c08  356AC1AB2B7D4344::5D16DDC5BD1D4712(this.f38, 0x28cca2db200.f0, this, ?)
    //   0x28d95a12c20  Task`1::GetAwaiter(356AC1AB2B7D4344::5D16DDC5BD1D4712(this.f38, 0x28cca2db200.f0, this, ?), 0x28cca2db200.f0, this, ?)
    //   0x28d95a12c68  <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7), 0x28cca2db200.f0, this, ?)
    //   0x28d95a12c81  sub_28d95a138f8((movsxd 0x3ca2d4c7), 0x28cca2db200.f0, this, ?)
    //   0x28d95a12ca0  sub_28b82785f1f((movsxd 0x3ca2d4c7), 0x28cca2db200.f0, this, ?)
    //   0x28d95a12d50  <Module>::58ECCB512F2A43AC((movsxd 0x4808bf97))   ; =2
    //   0x28d95a12d98  TaskAwaiter`1::GetResult((? add 0xffffffffffffff00), 0x28cca2db200.f0, this, ?)
    //   0x28d95a12db8  356AC1AB2B7D4344::F306AC516B814178(TaskAwaiter`1::GetResult((? add 0xffffffffffffff00), 0x28cca2db200.f0, this, ?), this.f48, this, ?)
    //   0x28d95a12e28  <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7), this.f48, this, ?)
    //   0x28d95a12e80  sub_28b82780dcb((this add 0x58), Task`1::GetAwaiter(356AC1AB2B7D4344::5D16DDC5BD1D4712(this.f38, 0x28cca2db200.f0, this, ?), 0x28cca2db200.f0, this, ?), this, ?)
    //   0x28d95a12eb0  [await] AsyncTaskMethodBuilder`1::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff00), this, ?)
    //   0x28d95a12ec2  sub_28d95a138f8((this add 0x8), (? add 0xffffffffffffff00), this, ?)
    //   0x28d95a12ee8  sub_28b82785f1f((this add 0x8), (? add 0xffffffffffffff00), this, ?)
    //   0x28d95a12f30  <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xffffffffffffff00), this, ?)
    //   0x28d95a12fb0  356AC1AB2B7D4344::5F54CFA822A449B2(this.f40)
    //   0x28d95a12fe8  356AC1AB2B7D4344::CD082EEB568A4E00(this.f38)
    //   0x28d95a13058  <Module>::F84FA79ABE6944BB((movsxd 0x9ba1de3f), <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xffffffffffffff00), this, ?), this, ?)
    //   0x28d95a13078  Guid::NewGuid((? add 0xffffffffffffff30), <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xffffffffffffff00), this, ?), this, ?)
    //   0x28d95a130e8  356AC1AB2B7D4344::320ED81552A54888(<Module>::F84FA79ABE6944BB((movsxd 0x9ba1de3f), <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xffffffffffffff00), this, ?), this, ?), ALLOC_OBJECT(0x28c851
    //   0x28d95a13100  356AC1AB2B7D4344::5BF7E88B8D244588(this.f40, 356AC1AB2B7D4344::320ED81552A54888(<Module>::F84FA79ABE6944BB((movsxd 0x9ba1de3f), <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xffffffffffffff0
    //   0x28d95a13168  <Module>::8B9C7B12B1AE4949((movsxd 0xd8c6f9cd), 356AC1AB2B7D4344::320ED81552A54888(<Module>::F84FA79ABE6944BB((movsxd 0x9ba1de3f), <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xffffffffffff
    //   0x28d95a13188  356AC1AB2B7D4344::5A16C99D36424BD9(this.f38, 356AC1AB2B7D4344::5BF7E88B8D244588(this.f40, 356AC1AB2B7D4344::320ED81552A54888(<Module>::F84FA79ABE6944BB((movsxd 0x9ba1de3f), <Module>::390073C602714496(
    //   0x28d95a13238  356AC1AB2B7D4344::251E909A6F02466E((u32 ((((((((((movsxd 0xb137479d) add 0x5347d55530648d3d) sub 0xa678d3e2) imul 0x30b33de7) add 0xbfb0b50e) add 0xfe614a890649c993) neg 0x1) div 0x3) mod 0x3) shl 0x3
    //   0x28d95a13248  356AC1AB2B7D4344::9E7B97E01D6F44EB(356AC1AB2B7D4344::251E909A6F02466E((u32 ((((((((((movsxd 0xb137479d) add 0x5347d55530648d3d) sub 0xa678d3e2) imul 0x30b33de7) add 0xbfb0b50e) add 0xfe614a890649c993)
    //   0x28d95a132c8  <Module>::3F57E81A62734AC2((movsxd 0x3184f657), (((((((((movsxd 0xb137479d) add 0x5347d55530648d3d) sub 0xa678d3e2) imul 0x30b33de7) add 0xbfb0b50e) add 0xfe614a890649c993) neg 0x1) div 0x3) mod 0x3),
    //   0x28d95a132f8  356AC1AB2B7D4344::8CC9AC0FAD844E24(356AC1AB2B7D4344::9E7B97E01D6F44EB(356AC1AB2B7D4344::251E909A6F02466E((u32 ((((((((((movsxd 0xb137479d) add 0x5347d55530648d3d) sub 0xa678d3e2) imul 0x30b33de7) add 
    //   0x28d95a13318  sub_28c8598b8d0(356AC1AB2B7D4344::9E7B97E01D6F44EB(356AC1AB2B7D4344::251E909A6F02466E((u32 ((((((((((movsxd 0xb137479d) add 0x5347d55530648d3d) sub 0xa678d3e2) imul 0x30b33de7) add 0xbfb0b50e) add 0xf
    //   0x28d95a13338  ?(sub_28c8598b8d0(356AC1AB2B7D4344::9E7B97E01D6F44EB(356AC1AB2B7D4344::251E909A6F02466E((u32 ((((((((((movsxd 0xb137479d) add 0x5347d55530648d3d) sub 0xa678d3e2) imul 0x30b33de7) add 0xbfb0b50e) add 0
    //   0x28d95a13378  356AC1AB2B7D4344::2B6F32F437544561(this.f38, this.f48, 0x28cca2db200.f0)
    //   0x28d95a13388  356AC1AB2B7D4344::491C5DA9A4244B1E(356AC1AB2B7D4344::2B6F32F437544561(this.f38, this.f48, 0x28cca2db200.f0))
    //   0x28d95a13450  GetResult((? add 0xfffffffffffffef8), (((((((((movsxd 0xfe53923a) add 0x5347d55530648d3d) sub 0xa678d3e2) imul 0x30b33de7) add 0xbfb0b50e) add 0xfe614a890649c993) neg 0x1) div 0xa) mod 0xa), 0x28cca2d
    //   0x28d95a134a0  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0))   ; =-1
    //   0x28d95a13608  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffef8), this, 0x28cc7550840)
    //   0x28d95a136c0  <Module>::390073C602714496((movsxd 0x4da2eb80))   ; =2
    //   0x28d95a136fc  sub_28d95a138f8(<Module>::390073C602714496((movsxd 0x4da2eb80)), <Module>::390073C602714496((movsxd 0x4da2eb80)), this, 0x28cc7550840)
    //   0x28d95a13720  sub_28b82785f1f(<Module>::390073C602714496((movsxd 0x4da2eb80)), <Module>::390073C602714496((movsxd 0x4da2eb80)), this, 0x28cc7550840)
    //   0x28d95a13748  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4))   ; =1
    //   0x28d95a13761  sub_28d95a138f8((movsxd 0x67cf2da4), <Module>::390073C602714496((movsxd 0x4da2eb80)), this, 0x28cc7550840)
    //   0x28d95a13780  sub_28b82785f1f((movsxd 0x67cf2da4), <Module>::390073C602714496((movsxd 0x4da2eb80)), this, 0x28cc7550840)
    //   0x28d95a139f8  356AC1AB2B7D4344::A15C5A1623044B31(0x28d03540bc0)
    //   0x28d95a13b48  <Module>::F84FA79ABE6944BB((movsxd 0x56d54e19))   ; =-2
    //   0x28d95a13ca0  THROW(0x162, 0x644)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
