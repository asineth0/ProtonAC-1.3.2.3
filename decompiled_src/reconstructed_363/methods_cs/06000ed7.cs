// ============================================================
// token 0x06000ed7   EE16DFEEDF594543::MoveNext
// native code: 0x28d9730b070  (5573 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000edc,06000004,06000005,06000ed9,06000eda,06000edb,06000ee1,06000edf,06000edd,06000ee2,06000006,06000ee0,06000ee3,06000ee4,06000ede,06000e73,06000003,06000ee5,06000ee6,06000007,06000ee7,06004674
// native-strings: 0x30b0:/Map.png,0x3120:Uploading game map image to cloud...,0x3148:Game map upload completed.
// ============================================================

// OUTER ASYNC METHOD token 0x06000e79
// state-machine class: EE16DFEEDF594543 ; fields: 8
//   .field public int32 '37C12D9C95974F7B'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder A5BC7B67B748460E
//   .field public class '02C54685DE0E4B81' EBF5AE9D54B14422
//   .field private string E89235762B374B1D
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<string> '0BDF0BD68D7343AD'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<class '24CB10E1628641EE'> '33530FF7D7BC49F6'
//   .field private class [netstandard]System.IO.FileStream '4FFF977C762B4DF9'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<bool> '44A3AAAB703945A0'
private async Task 1CD1829443FF4215()
{
    this.<>1__state = -1;
    this.<>1__state = -1;
    this.<>1__state = 1;
    this.<>1__state = 0;
    // 3 await site(s):
    //   await #1 @0x28d9730b2f8  type=Runtime.CompilerServices.TaskAwaiter`1<string>
    //   await #2 @0x28d9730b880  type=Runtime.CompilerServices.TaskAwaiter`1<'24CB10E1628641EE'>
    //      awaiter source: GetAwaiter(EE16DFEEDF594543::0CFE9D682CDA4BC3(this.f28, 0x0), 0x0, this, ?)
    //   await #3 @0x28d9730bf88  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //      awaiter source: GetAwaiter(02C54685DE0E4B81::26BAEDD2B7134543(this.f20, EE16DFEEDF594543::6B9F5FC1FA8345AA(this.f20.f68), FromSeconds(0x3d412794, <Module>::58ECCB512F2A43AC((movsxd 0xedd
    //
    // native action order (address order):
    //   0x28d9730b280  EE16DFEEDF594543::B0C79E22E8E34C94(this.f28)
    //   0x28d9730b2f8  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffef0), this, ?)
    //   0x28d9730b388  GetResult((? add 0xfffffffffffffee0), (? add 0xfffffffffffffef0), this, ?)
    //   0x28d9730b3e0  <Module>::390073C602714496((movsxd 0xd413acc0))   ; =-1
    //   0x28d9730b440  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410))   ; =-1
    //   0x28d9730b480  EE16DFEEDF594543::C05DB04E4FEF42F3()
    //   0x28d9730b4c0  EE16DFEEDF594543::81E748475BD84F36((EE16DFEEDF594543::C05DB04E4FEF42F3() xor EE16DFEEDF594543::C05DB04E4FEF42F3()))
    //   0x28d9730b508  <Module>::390073C602714496(0xffffffffa46c8a72)   ; "/Map.png"
    //   0x28d9730b520  EE16DFEEDF594543::F24BC430C15242CA(EE16DFEEDF594543::81E748475BD84F36((EE16DFEEDF594543::C05DB04E4FEF42F3() xor EE16DFEEDF594543::C05DB04E4FEF42F3())), <Module>::390073C602714496(0xffffffffa46c8a72))
    //   0x28d9730b578  EE16DFEEDF594543::81A877F2250341AB(0x0)
    //   0x28d9730b5d0  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4))   ; =1
    //   0x28d9730b660  GetResult((? add 0xfffffffffffffef0), 0x0, this, ?)
    //   0x28d9730b678  EE16DFEEDF594543::53E095D4171E4BC8(GetResult((? add 0xfffffffffffffef0), 0x0, this, ?))
    //   0x28d9730b728  EE16DFEEDF594543::0CFE9D682CDA4BC3(this.f28, 0x0)
    //   0x28d9730b740  GetAwaiter(EE16DFEEDF594543::0CFE9D682CDA4BC3(this.f28, 0x0), 0x0, this, ?)
    //   0x28d9730b7f8  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515))   ; =0
    //   0x28d9730b880  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffee0), this, ?)
    //   0x28d9730b8a8  EE16DFEEDF594543::650EDCC1A32F4DA9(GetResult((? add 0xfffffffffffffef0), 0x0, this, ?))
    //   0x28d9730b938  op_Inequality((? add 0xffffffffffffff60), (? add 0xffffffffffffff50), this, ?)
    //   0x28d9730b990  <Module>::58ECCB512F2A43AC((movsxd 0x8f7d91f6), (? add 0xffffffffffffff50), this, ?)
    //   0x28d9730b9b0  EE16DFEEDF594543::DB44F323F2A04CDE(this.f20.f60, <Module>::58ECCB512F2A43AC((movsxd 0x8f7d91f6), (? add 0xffffffffffffff50), this, ?), 0x28cc7550840, ?)
    //   0x28d9730ba20  <Module>::58ECCB512F2A43AC((movsxd 0xedd46851))   ; "Uploading game map image to cloud..."
    //   0x28d9730ba40  EE16DFEEDF594543::D8C7A630B6B74073(this.f20.f60, <Module>::58ECCB512F2A43AC((movsxd 0xedd46851)), 0x28cc7550840)
    //   0x28d9730ba60  EE16DFEEDF594543::46B13BBA87894F7F(this.f28)
    //   0x28d9730baf8  EE16DFEEDF594543::6B9F5FC1FA8345AA(this.f20.f68)
    //   0x28d9730bb18  <Module>::F84FA79ABE6944BB(0x3d412794)   ; =0
    //   0x28d9730bb28  FromSeconds(0x3d412794, <Module>::58ECCB512F2A43AC((movsxd 0xedd46851)), 0x28cc7550840, ?)
    //   0x28d9730bb78  02C54685DE0E4B81::26BAEDD2B7134543(this.f20, EE16DFEEDF594543::6B9F5FC1FA8345AA(this.f20.f68), FromSeconds(0x3d412794, <Module>::58ECCB512F2A43AC((movsxd 0xedd46851)), 0x28cc7550840, ?), this.f20+58.f
    //   0x28d9730bb90  GetAwaiter(02C54685DE0E4B81::26BAEDD2B7134543(this.f20, EE16DFEEDF594543::6B9F5FC1FA8345AA(this.f20.f68), FromSeconds(0x3d412794, <Module>::58ECCB512F2A43AC((movsxd 0xedd46851)), 0x28cc7550840, ?), th
    //   0x28d9730bbe8  <Module>::58ECCB512F2A43AC((movsxd 0x4808bf97))   ; =2
    //   0x28d9730bca0  <Module>::8B9C7B12B1AE4949(0x3358112e)   ; =5
    //   0x28d9730bcc0  EE16DFEEDF594543::7F29D836AF134B54(this.f40)
    //   0x28d9730bce8  EE16DFEEDF594543::650EDCC1A32F4DA9(GetResult((? add 0xfffffffffffffef0), 0x0, this, ?))
    //   0x28d9730bd00  ToString((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), FromSeconds(0x3d412794, <Module>::58ECCB512F2A43AC((movsxd 0xedd46851)), 0x28cc7550840, ?), this.f20+58.f0)
    //   0x28d9730bd28  EE16DFEEDF594543::DD317ACBDF604264(this.f20, this.f40, <Module>::8B9C7B12B1AE4949(0x3358112e), EE16DFEEDF594543::7F29D836AF134B54(this.f40))
    //   0x28d9730bdde  sub_28d9730c088(EE16DFEEDF594543::DD317ACBDF604264(this.f20, this.f40, <Module>::8B9C7B12B1AE4949(0x3358112e), EE16DFEEDF594543::7F29D836AF134B54(this.f40)), this.f40, <Module>::8B9C7B12B1AE4949(0x335
    //   0x28d9730be00  sub_28b82785f1f(EE16DFEEDF594543::DD317ACBDF604264(this.f20, this.f40, <Module>::8B9C7B12B1AE4949(0x3358112e), EE16DFEEDF594543::7F29D836AF134B54(this.f40)), this.f40, <Module>::8B9C7B12B1AE4949(0x335
    //   0x28d9730be70  <Module>::390073C602714496((movsxd 0xd413acc0))   ; =-1
    //   0x28d9730bf00  <Module>::3F57E81A62734AC2((movsxd 0xcd941453))   ; =2
    //   0x28d9730bf88  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffef8), this, EE16DFEEDF594543::7F29D836AF134B54(this.f40))
    //   0x28d9730bfb0  GetResult((? add 0xfffffffffffffef8), (? add 0xfffffffffffffef8), this, EE16DFEEDF594543::7F29D836AF134B54(this.f40))
    //   0x28d9730bfe0  <Module>::F84FA79ABE6944BB((movsxd 0xdf3a8e54))   ; "Game map upload completed."
    //   0x28d9730c000  EE16DFEEDF594543::D8C7A630B6B74073(this.f20.f60, <Module>::F84FA79ABE6944BB((movsxd 0xdf3a8e54)), 0x28cc7550840)
    //   0x28d9730c038  <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994))   ; =1
    //   0x28d9730c05e  sub_28d9730c088((movsxd 0x14ddf994), <Module>::F84FA79ABE6944BB((movsxd 0xdf3a8e54)), 0x28cc7550840, EE16DFEEDF594543::7F29D836AF134B54(this.f40))
    //   0x28d9730c080  sub_28b82785f1f((movsxd 0x14ddf994), <Module>::F84FA79ABE6944BB((movsxd 0xdf3a8e54)), 0x28cc7550840, EE16DFEEDF594543::7F29D836AF134B54(this.f40))
    //   0x28d9730c1f0  EE16DFEEDF594543::14CF8622E29C4430(this.f40)
    //   0x28d9730c2d0  <Module>::8B9C7B12B1AE4949((movsxd 0x46b352ec), (((((((((((movsxd 0x9fb0e3c6) sub 0x29f6f50f512b7f88) not 0x1) neg 0x1) imul 0xe0838559) not 0x1) neg 0x1) xor 0x69ad6792) sub 0x179cd433) div 0x3) mod 
    //   0x28d9730c2f0  EE16DFEEDF594543::D8C7A630B6B74073(this.f20.f60, <Module>::8B9C7B12B1AE4949((movsxd 0x46b352ec), (((((((((((movsxd 0x9fb0e3c6) sub 0x29f6f50f512b7f88) not 0x1) neg 0x1) imul 0xe0838559) not 0x1) neg 0
    //   0x28d9730c318  <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7), <Module>::8B9C7B12B1AE4949((movsxd 0x46b352ec), (((((((((((movsxd 0x9fb0e3c6) sub 0x29f6f50f512b7f88) not 0x1) neg 0x1) imul 0xe0838559) not 0x1) neg 0x
    //   0x28d9730c400  <Module>::3F57E81A62734AC2((movsxd 0x2da21f0a), (((((((((((movsxd 0x866d6a7c) sub 0x29f6f50f512b7f88) not 0x1) neg 0x1) imul 0xe0838559) not 0x1) neg 0x1) xor 0x69ad6792) sub 0x179cd433) div 0x5) mod 
    //   0x28d9730c498  sub_28c8598b8d0((this add 0x8), 0x0, 0x28cc7550840, EE16DFEEDF594543::7F29D836AF134B54(this.f40))
    //   0x28d9730c4b8  ?(sub_28c8598b8d0((this add 0x8), 0x0, 0x28cc7550840, EE16DFEEDF594543::7F29D836AF134B54(this.f40)), 0x0, 0x28cc7550840, EE16DFEEDF594543::7F29D836AF134B54(this.f40))
    //   0x28d9730c4f8  <Module>::390073C602714496((movsxd 0x30c4c57f))   ; =-2
    //   0x28d9730c608  THROW(0x162, 0x6de)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
