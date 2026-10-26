// ============================================================
// token 0x06000ecd   3BFCD00718A5475C::MoveNext
// native code: 0x28d95a02490  (3055 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000ed1,06000005,06000ed3,06000004,06000ed6,06000ed4,06000ed5,06000ed0,06000ed2,06000007,06000003,06000ecf,06004674
// native-strings: 0x3094:Authentification sended,0x3088:protonac
// ============================================================

// OUTER ASYNC METHOD token 0x06000e78
// state-machine class: 3BFCD00718A5475C ; fields: 4
//   .field public int32 DA89C0F723E74D28
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '8E2C2080F27A4215'
//   .field public class '02C54685DE0E4B81' '5C286FA9E9804BA7'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '0098248483324004'
private async Task 7B3F63781CFF4AAD()
{
    this.<>1__state = -1;
    this.<>1__state = 0;
    this.<>1__state = -1;
    this.<>1__state = 1;
    // 2 await site(s):
    //   await #1 @0x28d95a028a0  type=Runtime.CompilerServices.TaskAwaiter
    //   await #2 @0x28d95a02ba8  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d95a025e8  GetResult((? add 0xffffffffffffff30), ((((((((((movsxd 0xff96e174) imul 0xfed7958f) not 0x1) neg 0x1) imul 0xded030e5) add 0xfb1ece8cdc381d4b) not 0x1) sub 0xa9a8307e) div 0x17) mod 0x17), ?, ?)
    //   0x28d95a025f8  3BFCD00718A5475C::5F41A1919DC64F4D()
    //   0x28d95a02618  TryParse(3BFCD00718A5475C::5F41A1919DC64F4D(), (? add 0xffffffffffffff20), ?, ?)
    //   0x28d95a02670  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410))   ; =-1
    //   0x28d95a02710  3BFCD00718A5475C::2EDACE49F0D547BD(this.f20, 0x0, ?, ?)
    //   0x28d95a02758  <Module>::390073C602714496((movsxd 0x7f132d63))   ; =0
    //   0x28d95a028a0  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff30), this, ?)
    //   0x28d95a028d8  GetResult((? add 0xffffffffffffff30), (? add 0xffffffffffffff30), this, ?)
    //   0x28d95a02908  <Module>::390073C602714496((movsxd 0xa61f4163))   ; "Authentification sended"
    //   0x28d95a02928  3BFCD00718A5475C::25BE7CD45B42467F(this.f20.f60, <Module>::390073C602714496((movsxd 0xa61f4163)), 0x28cc7550840)
    //   0x28d95a029c0  op_Equality((? add 0xffffffffffffff80), (? add 0xffffffffffffff70), 0x28cc7550840, ?)
    //   0x28d95a02a40  <Module>::390073C602714496((movsxd 0x1816ab0c))   ; "protonac"
    //   0x28d95a02a80  3BFCD00718A5475C::7D98DAEBE35642C3(<Module>::390073C602714496((movsxd 0x1816ab0c)), (? add 0xffffffffffffff90), (movzx 0x28cc768cd58.f0))
    //   0x28d95a02ab0  3BFCD00718A5475C::5F589F8A0C244ED4(this.f20.f10, 3BFCD00718A5475C::7D98DAEBE35642C3(<Module>::390073C602714496((movsxd 0x1816ab0c)), (? add 0xffffffffffffff90), (movzx 0x28cc768cd58.f0)), 0x0)
    //   0x28d95a02ac0  3BFCD00718A5475C::3009F18629374A77(3BFCD00718A5475C::5F589F8A0C244ED4(this.f20.f10, 3BFCD00718A5475C::7D98DAEBE35642C3(<Module>::390073C602714496((movsxd 0x1816ab0c)), (? add 0xffffffffffffff90), (mov
    //   0x28d95a02b50  <Module>::390073C602714496((movsxd 0x68e4c334), 3BFCD00718A5475C::7D98DAEBE35642C3(<Module>::390073C602714496((movsxd 0x1816ab0c)), (? add 0xffffffffffffff90), (movzx 0x28cc768cd58.f0)), 0x0, ?)
    //   0x28d95a02b70  3BFCD00718A5475C::F00EAF7BC1D94A9D(this.f20.f60, <Module>::390073C602714496((movsxd 0x68e4c334), 3BFCD00718A5475C::7D98DAEBE35642C3(<Module>::390073C602714496((movsxd 0x1816ab0c)), (? add 0xffffffffff
    //   0x28d95a02ba8  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff30), this, ?)
    //   0x28d95a02bf0  <Module>::3F57E81A62734AC2((movsxd 0x16aa9e93))   ; =-1
    //   0x28d95a02c80  <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994))   ; =1
    //   0x28d95a02d20  <Module>::F84FA79ABE6944BB((movsxd 0xb5722b3c))   ; =0
    //   0x28d95a02d30  FromSeconds((movsxd 0xb5722b3c), <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994)), this, ?)
    //   0x28d95a02d60  3BFCD00718A5475C::298382F35C554BE5(FromSeconds((movsxd 0xb5722b3c), <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994)), this, ?), this.f20+58.f0)
    //   0x28d95a02d70  3BFCD00718A5475C::3009F18629374A77(3BFCD00718A5475C::298382F35C554BE5(FromSeconds((movsxd 0xb5722b3c), <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994)), this, ?), this.f20+58.f0))
    //   0x28d95a02e08  <Module>::390073C602714496((movsxd 0xf10a970c))   ; =1
    //   0x28d95a02f38  <Module>::8B9C7B12B1AE4949((movsxd 0xd72b2571), this.f20+58.f0, this, ?)
    //   0x28d95a02fa8  sub_28c8598b8d0((this add 0x8), 0x0, this, ?)
    //   0x28d95a02fc8  ?(sub_28c8598b8d0((this add 0x8), 0x0, this, ?), 0x0, this, ?)
    //   0x28d95a03008  <Module>::F84FA79ABE6944BB((movsxd 0x56d54e19))   ; =-2
    //   0x28d95a03060  THROW(0x162, 0x329)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
