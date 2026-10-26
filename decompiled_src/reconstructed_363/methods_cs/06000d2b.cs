// ============================================================
// token 0x06000d2b   F74796E0377D4732::MoveNext
// native code: 0x28d9583d460  (8430 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000004,06000d2d,06000003,06000d14,06000005,06000006,06000007,06000d2e,06000d2f,06000d13,06000d32,06000d33,06000d34,06000d35,06000d36,06000d37,06000d31,06000d12,06000d30,06000d38,06000d3d,06000d3e,06004671,06000d3c,06004673
// native-strings: 0x25dc:[,0x25e4:] [,0x25ec:]: ,0x25f4:ProtonLogs-{0:dd-MM-yyyy}.log
// ============================================================

// OUTER ASYNC METHOD token 0x06000d11
// state-machine class: F74796E0377D4732 ; fields: 17
//   .field public int32 '55F25C63141047CD'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '78C036EED30049BE'
//   .field public class C0225ABF72C4425E '1E02CB95DFA246C9'
//   .field private class [ProtonAC.UniTask]Cysharp.Threading.Tasks.IUniTaskAsyncEnumerator`1<valuetype '3DBA106924E9431F'/'0CAF5A99CBFA42D0'> '4690444F9D1A407E'
//   .field private object '1345E38E3B1C407F'
//   .field private int32 '35E93E70F81842F2'
//   .field private valuetype [ProtonAC.UniTask]Cysharp.Threading.Tasks.UniTask`1/Awaiter<bool> ACE92E13F6044D6B
//   .field private valuetype [ProtonAC.UniTask]Cysharp.Threading.Tasks.UniTask/Awaiter B9286F0A9ECA4084
//   .field private initonly class [netstandard]System.Action`2<class ['Assembly-CSharp']SDG.Unturned.CommandWindow, string> FCFC1DE0F37540DA
//   .field private initonly class [netstandard]System.Action`2<class ['Assembly-CSharp']SDG.Unturned.CommandWindow, string> '34900D1CEB264F66'
//   .field private initonly class [netstandard]System.Action`2<class ['Assembly-CSharp']SDG.Unturned.CommandWindow, string> '55B9C95C1CCD4CC2'
//   .field private initonly class [ProtonAC.UniTask]Cysharp.Threading.Tasks.Channel`1<valuetype '3DBA106924E9431F'/'0CAF5A99CBFA42D0'> '666FE28F0087465E'
//   .field private initonly class [netstandard]System.Threading.Tasks.Task '7C6AE811B100406F'
//   .field private initonly class [netstandard]System.Threading.CancellationTokenSource '28048F3EEEF142F9'
//   .field private initonly string '6D0BB5E5B22D4B42'
//   .field private class [netstandard]System.IO.StreamWriter '665ED21C3CA34A9F'
//   .field private int32 '754FFAFF3833451F'
private async Task 8F556C33BC784C69()
{
    this.<>1__state = -1;
    this.<>1__state = 0;
    this.<>1__state = 0;
    this.<>1__state = 0;
    // 2 await site(s):
    //   await #1 @0x28d9583ec68  type=[ProtonAC.UniTask]Cysharp.Threading.Tasks.UniTask`1/Awaiter<bool>
    //   await #2 @0x28d9583f020  type=[ProtonAC.UniTask]Cysharp.Threading.Tasks.UniTask/Awaiter
    //
    // native action order (address order):
    //   0x28d9583d620  <Module>::390073C602714496((movsxd 0x7f132d63))   ; =0
    //   0x28d9583d680  F74796E0377D4732::22117A979C814D05(this.f20.f38)
    //   0x28d9583d758  <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994))   ; =1
    //   0x28d9583d8a8  C0225ABF72C4425E::EB02E7E2E9E945AA((movsxd S[rbp-190]))
    //   0x28d9583d8d0  <Module>::F84FA79ABE6944BB((movsxd 0x240a0e98))   ; =6
    //   0x28d9583d948  <Module>::58ECCB512F2A43AC((movsxd 0x1505777c))   ; =0
    //   0x28d9583d9c0  <Module>::3F57E81A62734AC2((movsxd 0xe4375480))   ; "["
    //   0x28d9583da38  <Module>::390073C602714496((movsxd 0xf10a970c))   ; =1
    //   0x28d9583dac0  <Module>::58ECCB512F2A43AC((movsxd 0x4808bf97))   ; =2
    //   0x28d9583db38  <Module>::58ECCB512F2A43AC((movsxd 0x8214d920))   ; "] ["
    //   0x28d9583dbb0  <Module>::F84FA79ABE6944BB((movsxd 0xab4f8e70))   ; =3
    //   0x28d9583dc28  <Module>::58ECCB512F2A43AC((movsxd 0x62edd6fa))   ; =4
    //   0x28d9583dca0  <Module>::F84FA79ABE6944BB((movsxd 0x6cf0338b))   ; "]: "
    //   0x28d9583dd18  <Module>::8B9C7B12B1AE4949((movsxd 0x3358112e))   ; =5
    //   0x28d9583dd58  F74796E0377D4732::5E2F6448F5EF4B5B(ALLOC_ARRAY(0x28c845f5a20, <Module>::F84FA79ABE6944BB((movsxd 0x240a0e98))))
    //   0x28d9583de40  <Module>::8B9C7B12B1AE4949((movsxd 0xd8c6f9cd))   ; =0
    //   0x28d9583de68  F74796E0377D4732::B831350993644A29(0x28ccb7bafe0, (? add 0xfffffffffffffdc8))
    //   0x28d9583df08  get_Now((u32 ((((0xb56c6526519281c7 sub (((movsxd (movsxd 0xb4f6d170)) xor 0x59487a8722076e2) neg 0x1)) div 0x9) mod 0x9) shl 0x3)), (((0xb56c6526519281c7 sub (((movsxd (movsxd 0xb4f6d170)) xor 0x5948
    //   0x28d9583df38  get_DayOfYear((? add 0xfffffffffffffe20), (((0xb56c6526519281c7 sub (((movsxd (movsxd 0xb4f6d170)) xor 0x59487a8722076e2) neg 0x1)) div 0x9) mod 0x9), S[rbp-180], ?)
    //   0x28d9583dfc8  C0225ABF72C4425E::C8F7B527BD9C43EF(this.f20, F74796E0377D4732::5E2F6448F5EF4B5B(ALLOC_ARRAY(0x28c845f5a20, <Module>::F84FA79ABE6944BB((movsxd 0x240a0e98)))))
    //   0x28d9583e008  <Module>::58ECCB512F2A43AC((movsxd 0xe6441a24))   ; "ProtonLogs-{0:dd-MM-yyyy}.log"
    //   0x28d9583e060  F74796E0377D4732::F704307136884E08(<Module>::58ECCB512F2A43AC((movsxd 0xe6441a24)), ALLOC_OBJECT(0x28cc7724230))
    //   0x28d9583e088  F74796E0377D4732::86BFFACB65014C3A(this.f20.f40, F74796E0377D4732::F704307136884E08(<Module>::58ECCB512F2A43AC((movsxd 0xe6441a24)), ALLOC_OBJECT(0x28cc7724230)))
    //   0x28d9583e0c0  <Module>::8B9C7B12B1AE4949((movsxd 0x40925388))   ; =6
    //   0x28d9583e110  <Module>::3F57E81A62734AC2((movsxd 0xcd941453))   ; =2
    //   0x28d9583e180  <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7))   ; =3
    //   0x28d9583e1a8  F74796E0377D4732::C6BB3236DEE44322(F74796E0377D4732::86BFFACB65014C3A(this.f20.f40, F74796E0377D4732::F704307136884E08(<Module>::58ECCB512F2A43AC((movsxd 0xe6441a24)), ALLOC_OBJECT(0x28cc7724230))), (
    //   0x28d9583e1d8  F74796E0377D4732::581D8E165FBC46F1()
    //   0x28d9583e1f0  F74796E0377D4732::092875002EBB482E(F74796E0377D4732::C6BB3236DEE44322(F74796E0377D4732::86BFFACB65014C3A(this.f20.f40, F74796E0377D4732::F704307136884E08(<Module>::58ECCB512F2A43AC((movsxd 0xe6441a24)
    //   0x28d9583e268  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b))   ; =1
    //   0x28d9583e280  F74796E0377D4732::4A523D1EA4AC40E2(F74796E0377D4732::092875002EBB482E(F74796E0377D4732::C6BB3236DEE44322(F74796E0377D4732::86BFFACB65014C3A(this.f20.f40, F74796E0377D4732::F704307136884E08(<Module>::5
    //   0x28d9583e2e0  get_DayOfYear((? add 0xfffffffffffffe20), <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b)), (movsxd <Module>::3F57E81A62734AC2((movsxd 0xcd941453))), <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583e340  <Module>::F84FA79ABE6944BB((movsxd 0xab2d2f50))   ; =2
    //   0x28d9583e3e0  F74796E0377D4732::04DA14162CC44A5D(this.f20.f48, <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b)), (movsxd <Module>::3F57E81A62734AC2((movsxd 0xcd941453))), <Module>::58ECCB512F2A43AC((movsxd 0x5db286b
    //   0x28d9583e488  C0225ABF72C4425E::9BB2AAD6E5BC41F3(this.f20, (? add 0xffffffffffffff28), C0225ABF72C4425E::EB02E7E2E9E945AA((movsxd S[rbp-190])))
    //   0x28d9583e4e0  F74796E0377D4732::1CAD3AA345484DCF(this.f20.f48, (? add 0xffffffffffffff28), C0225ABF72C4425E::EB02E7E2E9E945AA((movsxd S[rbp-190])), <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583e501  sub_28d9583e528(this.f20.f48, (? add 0xffffffffffffff28), C0225ABF72C4425E::EB02E7E2E9E945AA((movsxd S[rbp-190])), <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583e520  sub_28b82785f1f(this.f20.f48, (? add 0xffffffffffffff28), C0225ABF72C4425E::EB02E7E2E9E945AA((movsxd S[rbp-190])), <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583e680  F74796E0377D4732::D511E37564654E94(0x28ccb7bafe0)
    //   0x28d9583e960  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410))   ; =-1
    //   0x28d9583eb00  <Module>::3F57E81A62734AC2((movsxd 0x94857146))   ; =0
    //   0x28d9583ec68  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe28), this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583ef40  ?(this.f30, (movsx (? add 0xfffffffffffffe48).f8), this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583ef58  F74796E0377D4732::30359F15A59B4DD1(0x0, (movsx (? add 0xfffffffffffffe48).f8), this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583ef68  F74796E0377D4732::A60003C4A0EC4749(F74796E0377D4732::30359F15A59B4DD1(0x0, (movsx (? add 0xfffffffffffffe48).f8), this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7))), (movsx (? add 0xfffffffffffffe
    //   0x28d9583efd8  sub_28b82780dcb((this add 0x50), (this add 0x50).f0, this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583f020  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe48), this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583f068  <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93), (? add 0xfffffffffffffe48), this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583f0e8  F74796E0377D4732::FCFD6FA86F8E4385(this.f28, (? add 0xfffffffffffffec0), this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583f190  sub_28b82780dcb((? add 0xfffffffffffffee0), (? add 0xfffffffffffffe58).f0, this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583f320  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4), (movsx (? add 0xfffffffffffffe48).f8), this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7)))
    //   0x28d9583f438  <Module>::58ECCB512F2A43AC((movsxd 0x2b6bc4b0), <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4), (movsx (? add 0xfffffffffffffe48).f8), this, <Module>::58ECCB512F2A43AC((movsxd 0x5db286b7))), this, <Mo
    //   0x28d9583f528  THROW(0x162, 0x3c9)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
