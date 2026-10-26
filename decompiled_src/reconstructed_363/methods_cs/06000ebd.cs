// ============================================================
// token 0x06000ebd   A40068D417F44BED::MoveNext
// native code: 0x28d957e2e00  (8946 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000004,06000005,06000007,06004671,06000ec6,06000ec2,06000ec3,06000ec0,06000ec5,0600463d,06000ec4,06005ed9,06000ec1,06005ecd,06005edb,06000006,06000ebf,06000003,06000ec7,06000ec8,06004649,06000ec9,06000eca,06000ecb,06000ecc,06004673
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06000e76
// state-machine class: A40068D417F44BED ; fields: 10
//   .field public int32 E54236AA15B24D7C
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '614C4617FA1045B2'
//   .field public class '02C54685DE0E4B81' '63242889011642E5'
//   .field public valuetype [netstandard]System.Threading.CancellationToken '59878CCF57D04CAA'
//   .field private object F5D539D97E5D43B3
//   .field private int32 '862D2D8A60C74FB1'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<bool> '27B3293680404438'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter FF88C28AA1CF40CA
//   .field private object '6E2DDB2039A34982'
//   .field private int32 '49BA781B895E4636'
private async Task A1DECD4C16994BD0(Threading.CancellationToken arg0)
{
    this.<>1__state = 4;
    this.<>1__state = 4;
    this.<>1__state = 0;
    this.<>1__state = -1;
    // 5 await site(s):
    //   await #1 @0x28d957e3218  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //   await #2 @0x28d957e3468  type=Runtime.CompilerServices.TaskAwaiter
    //   await #3 @0x28d957e3e30  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //   await #4 @0x28d957e44f0  type=Runtime.CompilerServices.TaskAwaiter
    //   await #5 @0x28d957e4d78  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //
    // native action order (address order):
    //   0x28d957e2f08  <Module>::390073C602714496((movsxd 0x952677a0))   ; =3
    //   0x28d957e2ff8  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515))   ; =0
    //   0x28d957e3058  <Module>::3F57E81A62734AC2((movsxd 0xaf43b39c))   ; =4
    //   0x28d957e3188  <Module>::390073C602714496((movsxd 0xf10a970c), ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0xa83f1673)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc31346b) neg 0x1) not 0x1) sub 0xaaec8a6c)) not 0x
    //   0x28d957e31e8  sub_28b82780dcb((this add 0x48), 0x0, ?, ?)
    //   0x28d957e3218  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffec8), this, ?)
    //   0x28d957e3238  A40068D417F44BED::E16F1499AF4F474C(0x0, (? add 0xfffffffffffffec8), this, ?)
    //   0x28d957e32c0  <Module>::F84FA79ABE6944BB((movsxd 0x946f0606), (? add 0xfffffffffffffec8), this, ?)
    //   0x28d957e32f8  A40068D417F44BED::2843B0D2CFDC435C(<Module>::F84FA79ABE6944BB((movsxd 0x946f0606), (? add 0xfffffffffffffec8), this, ?), (this add 0x28).f0, this, ?)
    //   0x28d957e3308  A40068D417F44BED::23B9C5AA3BB74861(A40068D417F44BED::2843B0D2CFDC435C(<Module>::F84FA79ABE6944BB((movsxd 0x946f0606), (? add 0xfffffffffffffec8), this, ?), (this add 0x28).f0, this, ?), (this add 0x28
    //   0x28d957e3368  <Module>::3F57E81A62734AC2((movsxd 0x94857146), (this add 0x28).f0, this, ?)
    //   0x28d957e33c8  <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), (this add 0x28).f0, this, ?)
    //   0x28d957e3468  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffec0), this, ?)
    //   0x28d957e3488  A40068D417F44BED::E69A7A0645B54629(this.f20.f10, (? add 0xfffffffffffffec0), this, ?)
    //   0x28d957e3688  A40068D417F44BED::9D2C55E689D64154(this.f20.f20, (? add 0xfffffffffffffec0), this, ?)
    //   0x28d957e36c0  TaskAwaiter::GetResult((? add 0xfffffffffffffec8), (? add 0xfffffffffffffec0), this, ?)
    //   0x28d957e36d8  A40068D417F44BED::6469ECA0E89041DC(this.f20.f20, (? add 0xfffffffffffffec0), this, ?)
    //   0x28d957e3748  GetResult((? add 0xfffffffffffffec0), (? add 0xfffffffffffffec0), this, ?)
    //   0x28d957e3780  ConcurrentQueue`1::TryDequeue(this.f20.f18, (? add 0xfffffffffffffea0), this, ?)
    //   0x28d957e37c8  <Module>::390073C602714496((movsxd 0x7f132d63))   ; =0
    //   0x28d957e3850  get_IsEmpty(this.f20.f18, <Module>::390073C602714496((movsxd 0x7f132d63)), this, ?)
    //   0x28d957e38d0  A40068D417F44BED::9745FCF27107416C(this.f20, <Module>::390073C602714496((movsxd 0x7f132d63)), this, ?)
    //   0x28d957e3958  ConcurrentQueue`1::get_IsEmpty(this.f20.f18, <Module>::390073C602714496((movsxd 0x7f132d63)), this, ?)
    //   0x28d957e39e8  ConcurrentQueue`1::TryPeek(this.f20.f18, (? add 0xfffffffffffffea8), this, ?)
    //   0x28d957e3a70  <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93))   ; =-1
    //   0x28d957e3ae0  <Module>::58ECCB512F2A43AC((movsxd 0x6b5a16e9))   ; =0
    //   0x28d957e3af0  FromSeconds((movsxd 0x6b5a16e9), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93)), this, ?)
    //   0x28d957e3b38  A40068D417F44BED::7B239F7EABC24DEB(this.f20.f20, FromSeconds((movsxd 0x6b5a16e9), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93)), this, ?), (this add 0x28).f0)
    //   0x28d957e3c08  <Module>::8B9C7B12B1AE4949((movsxd 0xa42a4aa0), FromSeconds((movsxd 0x6b5a16e9), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93)), this, ?), (this add 0x28).f0, ?)
    //   0x28d957e3cd8  A40068D417F44BED::052B03920E8D4D86(0x0, ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0xcd9284c8)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc31346b) neg 0x1) not 0x1) sub 0xaaec8a6c)) not 0x1) div 0
    //   0x28d957e3d18  A40068D417F44BED::9A78E1682AD5458E(this.f20, A40068D417F44BED::052B03920E8D4D86(0x0, ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0xcd9284c8)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc31346b) neg 
    //   0x28d957e3d78  sub_28b82780dcb((? add 0xfffffffffffffef8), A40068D417F44BED::052B03920E8D4D86(0x0, ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0xcd9284c8)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc31346b) neg 0
    //   0x28d957e3e00  sub_28b82780dcb((this add 0x40), 0x0, (this add 0x28).f0, ?)
    //   0x28d957e3e30  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffec0), this, ?)
    //   0x28d957e3e78  <Module>::8B9C7B12B1AE4949((movsxd 0xa42a4aa0), (? add 0xfffffffffffffec0), this, ?)
    //   0x28d957e3f10  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), <Module>::8B9C7B12B1AE4949((movsxd 0xa42a4aa0), (? add 0xfffffffffffffec0), this, ?), this, ?)
    //   0x28d957e4018  TaskAwaiter`1::GetResult((? add 0xfffffffffffffec0), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), <Module>::8B9C7B12B1AE4949((movsxd 0xa42a4aa0), (? add 0xfffffffffffffec0), this, ?), this, ?), thi
    //   0x28d957e4040  ConcurrentQueue`1::TryDequeue(this.f20.f18, (? add 0xfffffffffffffea0), this, ?)
    //   0x28d957e4108  sub_28b82780dcb((this add 0x50), 0xc4f5e57fc31346b, this, ?)
    //   0x28d957e4168  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b), 0xc4f5e57fc31346b, this, ?)
    //   0x28d957e4198  sub_28c8598b8d0(<Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b), 0xc4f5e57fc31346b, this, ?), 0xc4f5e57fc31346b, this, ?)
    //   0x28d957e41b8  ?(sub_28c8598b8d0(<Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b), 0xc4f5e57fc31346b, this, ?), 0xc4f5e57fc31346b, this, ?), 0xc4f5e57fc31346b, this, ?)
    //   0x28d957e4320  <Module>::390073C602714496((movsxd 0xd92975ec), ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0x833074ec)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc31346b) neg 0x1) not 0x1) sub 0xaaec8a6c)) not 0x
    //   0x28d957e4340  A40068D417F44BED::3947E9F627BF45F1(this.f50, ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0x833074ec)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc31346b) neg 0x1) not 0x1) sub 0xaaec8a6c)) not 0x1) 
    //   0x28d957e43b8  <Module>::8B9C7B12B1AE4949((movsxd 0xc71a4803), this.f20.f60, this, ?)
    //   0x28d957e43d8  A40068D417F44BED::A2A8200B3F3D4749(<Module>::390073C602714496((movsxd 0xd92975ec), ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0x833074ec)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc31346b) neg 0x
    //   0x28d957e4400  A40068D417F44BED::D53AB1B0489748F6(this.f20.f60, A40068D417F44BED::A2A8200B3F3D4749(<Module>::390073C602714496((movsxd 0xd92975ec), ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0x833074ec)) neg 0x
    //   0x28d957e4450  <Module>::8B9C7B12B1AE4949((movsxd 0x384a18c0), A40068D417F44BED::A2A8200B3F3D4749(<Module>::390073C602714496((movsxd 0xd92975ec), ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0x833074ec)) neg 0x1
    //   0x28d957e44b0  sub_28b82780dcb((this add 0x48), (this add 0x48).f0, 0x28cc7550840, ?)
    //   0x28d957e44f0  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffec8), this, ?)
    //   0x28d957e4510  TaskAwaiter::GetResult((? add 0xfffffffffffffec8), (? add 0xfffffffffffffec8), this, ?)
    //   0x28d957e4560  <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), (? add 0xfffffffffffffec8), this, ?)
    //   0x28d957e46b8  <Module>::390073C602714496((movsxd 0xf10a970c), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), (? add 0xfffffffffffffec8), this, ?), this, ?)
    //   0x28d957e4768  <Module>::F84FA79ABE6944BB((movsxd 0x40256441), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), (? add 0xfffffffffffffec8), this, ?), this, ?)
    //   0x28d957e47a0  A40068D417F44BED::2843B0D2CFDC435C(<Module>::F84FA79ABE6944BB((movsxd 0x40256441), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), (? add 0xfffffffffffffec8), this, ?), this, ?), (this add 0x28).f0, t
    //   0x28d957e47b0  A40068D417F44BED::23B9C5AA3BB74861(A40068D417F44BED::2843B0D2CFDC435C(<Module>::F84FA79ABE6944BB((movsxd 0x40256441), <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), (? add 0xfffffffffffffec8), this, 
    //   0x28d957e49a0  get_IsCancellationRequested((this add 0x28), ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0xa6209d41)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc31346b) neg 0x1) not 0x1) sub 0xaaec8a6c)) not 0x1) 
    //   0x28d957e4a70  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0xa6209d41)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc31346b) neg 0x1) not 0x1) sub 0xaaec8a6c)) not 0x
    //   0x28d957e4ab8  TaskAwaiter::GetResult((? add 0xfffffffffffffec8), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0xa6209d41)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57
    //   0x28d957e4b50  <Module>::3F57E81A62734AC2((movsxd 0xcf199377), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), ((((0x27074295d079a21c sub (((((((movsxd (movsxd 0xa6209d41)) neg 0x1) imul 0x946bd9c1) sub 0xc4f5e57fc3
    //   0x28d957e4b80  A40068D417F44BED::CE71170C7DC648D4(this.f20.f60, this.f30, <Module>::3F57E81A62734AC2((movsxd 0xcf199377), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), ((((0x27074295d079a21c sub (((((((movsxd (mov
    //   0x28d957e4ba0  <Module>::8B9C7B12B1AE4949((movsxd 0xa34d1b33), this.f30, <Module>::3F57E81A62734AC2((movsxd 0xcf199377), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), ((((0x27074295d079a21c sub (((((((movsxd (movs
    //   0x28d957e4bd8  A40068D417F44BED::2843B0D2CFDC435C(<Module>::8B9C7B12B1AE4949((movsxd 0xa34d1b33), this.f30, <Module>::3F57E81A62734AC2((movsxd 0xcf199377), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), ((((0x27074
    //   0x28d957e4be8  A40068D417F44BED::23B9C5AA3BB74861(A40068D417F44BED::2843B0D2CFDC435C(<Module>::8B9C7B12B1AE4949((movsxd 0xa34d1b33), this.f30, <Module>::3F57E81A62734AC2((movsxd 0xcf199377), <Module>::F84FA79ABE6944
    //   0x28d957e4c48  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4), (this add 0x28).f0, <Module>::3F57E81A62734AC2((movsxd 0xcf199377), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), ((((0x27074295d079a21c sub (((((((mo
    //   0x28d957e4ce8  <Module>::3F57E81A62734AC2((movsxd 0xaf43b39c), (this add 0x28).f0, <Module>::3F57E81A62734AC2((movsxd 0xcf199377), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), ((((0x27074295d079a21c sub (((((((mo
    //   0x28d957e4d48  sub_28b82780dcb((this add 0x48), A40068D417F44BED::23B9C5AA3BB74861(A40068D417F44BED::2843B0D2CFDC435C(<Module>::8B9C7B12B1AE4949((movsxd 0xa34d1b33), this.f30, <Module>::3F57E81A62734AC2((movsxd 0xcf
    //   0x28d957e4d78  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffec8), this, 0x28cc7550840)
    //   0x28d957e4f60  <Module>::390073C602714496((movsxd 0x30c4c57f), (? add 0xfffffffffffffec8), this, 0x28cc7550840)
    //   0x28d957e5060  THROW(0x162, 0x2d9)
    //   0x28d957e5088  THROW(0x14b, 0x698)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
