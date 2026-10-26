// ============================================================
// token 0x060013a5   CB205E8EC72E43F8::MoveNext
// native code: 0x28d959f0000  (47058 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06001942,06001943,06000003,06000004,06000007,060013a7,060013a8,060013aa,060013a9,06000006,060013ab,060013ac,06004671,060013ae,06004650,06000005,060013af,060013b0,06001344,060013b2,060013ad,06000df2,060013b1,060013b3,060013b4,060013b5,060013b7,06001332,060013b6,060013b8,0600463d,060013b9,060013ba,060013bb,060013bc,060013c2,060013c3,060013c4,060013c5,060013c6,060013c7,060013c9,060013c1,060013ca,060013c8,060013bd,060013be,060013bf,060013c0,06001347,06001dc2,06004674,06004673
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06001343
// state-machine class: CB205E8EC72E43F8 ; fields: 15
//   .field public int32 '8AB0D168BE894563'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder CD6E7CCE4A5D4D86
//   .field public class EB69693599F64B76 D19ED181B6F2435A
//   .field public valuetype [netstandard]System.Threading.CancellationToken FF0F697D89A94E57
//   .field private uint8[] EC207DB469D546A2
//   .field private object C51471BD81CA4079
//   .field private int32 '2DC8188872DE49A1'
//   .field private class [netstandard]System.IO.MemoryStream '748EA84EABAD4426'
//   .field private uint8[] '2A13DD13D99549B1'
//   .field private class '652C34B1E6554F10' '25CB8E83F0D64050'
//   .field private class [netstandard]System.Threading.CancellationTokenSource '574C2E9F3BA04E02'
//   .field private class [netstandard]System.Threading.CancellationTokenSource A32C76BE62524808
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<class [netstandard]System.Net.WebSockets.WebSocketReceiveResult> '3AC8A2EAAFE14B1A'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter '96601506ACC14FE7'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter B79CA7A4E2AD4AF5
private async Task 8F5BC7DF90C24392(Threading.CancellationToken arg0)
{
    // <>1__state <- <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, 0x70f890e5, ?) xor 0x355dfc28), 0xa, 0x70f890e5, ?)
    // <>1__state <- <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x3, 0x6e7f15a8, (movsxd (movsxd (movsxd (movsxd (? add 0xfffffffffff
    // <>1__state <- <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x2, 0x4d878f8d) xor 0x67ce8d46))
    // <>1__state <- <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x9, 0x7906f6d8) xor 0xf649cb7e))
    // 15 await site(s):
    //   await #1 @0x28d959f0fc8  type=Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<Net.WebSockets.WebSocketReceiveResult>
    //   await #2 @0x28d959f1010  type=Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter
    //   await #3 @0x28d959f3f20  type=Runtime.CompilerServices.TaskAwaiter
    //   await #4 @0x28d959f4040  type=Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<Net.WebSockets.WebSocketReceiveResult>
    //   await #5 @0x28d959f5140  type=Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter
    //   await #6 @0x28d959f6368  type=Runtime.CompilerServices.TaskAwaiter
    //   await #7 @0x28d959f6928  type=Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<Net.WebSockets.WebSocketReceiveResult>
    //   await #8 @0x28d959f7330  type=Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter
    //   await #9 @0x28d959f75f8  type=Runtime.CompilerServices.TaskAwaiter
    //   await #10 @0x28d959f7f40  type=Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<Net.WebSockets.WebSocketReceiveResult>
    //   await #11 @0x28d959f82c8  type=Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter
    //   await #12 @0x28d959f9168  type=Runtime.CompilerServices.TaskAwaiter
    //   await #13 @0x28d959f9470  type=Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<Net.WebSockets.WebSocketReceiveResult>
    //   await #14 @0x28d959fa178  type=Runtime.CompilerServices.ConfiguredTaskAwaitable/ConfiguredTaskAwaiter
    //   await #15 @0x28d959fa8e0  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d959f0158  81DD83B8AA2247AA::.ctor((? add 0xfffffffffffffb90), 0x5a7d2dc8)
    //   0x28d959f0268  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x2, 0xfffffffff957b208)
    //   0x28d959f0280  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x2, 0xfffffffff957b208) xor 0x59210cea))
    //   0x28d959f0360  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x1, 0xffffffff82d70b38)
    //   0x28d959f0378  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x1, 0xffffffff82d70b38) xor 0xb1994746))
    //   0x28d959f0418  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x9, 0x7d28f4c8)
    //   0x28d959f0438  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, (0x7d28f4c8 xor 0x7d28f4c8))
    //   0x28d959f0458  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, (0x7d28f4c8 xor 0x7d28f4c8)) xor 0x394427a2))
    //   0x28d959f0480  CB205E8EC72E43F8::9101D1F2547E48FB(this.f20.f18, <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, (0x7d28f4c8 xor 0x7d28f4c8)) xor 0x394427a2)), 0x28cc75
    //   0x28d959f04b8  81DD83B8AA2247AA::.ctor((? add 0xfffffffffffffb90), 0x6e989fab)
    //   0x28d959f04e0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, 0xffffffffc548688a)
    //   0x28d959f05d8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, (0xffffffffc548688a xor 0xffffffffc548688a))
    //   0x28d959f05f0  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, (0xffffffffc548688a xor 0xffffffffc548688a)) xor 0x352cff07))
    //   0x28d959f0640  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x9, 0xffffffffdfa399be)
    //   0x28d959f0678  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, 0xffffffffaf0dd552)
    //   0x28d959f06a0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x5, 0x58ad998a)
    //   0x28d959f06c0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), (0x5 xor 0x5), 0x8d7a412)
    //   0x28d959f06e8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x7, 0xffffffffb9c12ab8)
    //   0x28d959f0700  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x7, 0xffffffffb9c12ab8) xor 0x251c17ba))
    //   0x28d959f07e0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), (((((((((((0x813454dc8930dd45 sub (movsxd (movsxd 0x133652c8))) xor 0xab769eb51a9b3b1) sub 0x84e633b4) xor 0x745be533) add 0x9573f214) xo
    //   0x28d959f0810  81DD83B8AA2247AA::.ctor((? add 0xfffffffffffffb90), 0x98b0f3)
    //   0x28d959f0858  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x8, 0xffffffff88af5a4a)
    //   0x28d959f0878  CB205E8EC72E43F8::D2464AB5BFCB401F()
    //   0x28d959f08e0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x2, 0xffffffffd656fae3)
    //   0x28d959f09c0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x1, (0xffffffffd656fae3 xor 0xffffffffd656fae3))
    //   0x28d959f09d8  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x1, (0xffffffffd656fae3 xor 0xffffffffd656fae3)) xor 0x8621ccea))
    //   0x28d959f09e8  FromMinutes((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x1, (0xffffffffd656fae3 xor 0xffffffffd656fae3)) xor 0x8621ccea), 0x1, (0xffffffffd656fae3 xor 0xffffffffd656fae3), ?)
    //   0x28d959f0a08  CB205E8EC72E43F8::266ECFEFEA5748B5(FromMinutes((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x1, (0xffffffffd656fae3 xor 0xffffffffd656fae3)) xor 0x8621ccea), 0x1, (0xffffffffd656fa
    //   0x28d959f0a70  get_IsCancellationRequested((this add 0x28), 0x1, (0xffffffffd656fae3 xor 0xffffffffd656fae3), ?)
    //   0x28d959f0aa0  CB205E8EC72E43F8::A753AE9B159E4B2C(this.f20.f10)
    //   0x28d959f0ac8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), (0x1 xor 0x1), ((0xffffffffd656fae3 xor 0xffffffffd656fae3) xor (0xffffffffd656fae3 xor 0xffffffffd656fae3)))
    //   0x28d959f0ae0  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), (0x1 xor 0x1), ((0xffffffffd656fae3 xor 0xffffffffd656fae3) xor (0xffffffffd656fae3 xor 0xffffffffd656fae3)))
    //   0x28d959f0b88  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x6, 0xffffffffef4027f0)
    //   0x28d959f0bc0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x6, 0xffffffffaf562bf6)
    //   0x28d959f0bd8  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x6, 0xffffffffaf562bf6) xor 0x8ad3cc88))
    //   0x28d959f0cd8  CB205E8EC72E43F8::16147F1F4F214A36(this.f60)
    //   0x28d959f0d00  CB205E8EC72E43F8::AC3B737F13C6413E((this add 0x28).f0, CB205E8EC72E43F8::16147F1F4F214A36(this.f60))
    //   0x28d959f0d68  81DD83B8AA2247AA::.ctor((? add 0xfffffffffffffb90), 0x55291b5e)
    //   0x28d959f0d90  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x1, 0xffffffffb656c4a6)
    //   0x28d959f0e78  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xb, 0xffffffff8ad89643, ?)
    //   0x28d959f0ea0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x1, 0xffffffffeab4687d, ?)
    //   0x28d959f0ec0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), (0x1 xor 0x1), 0x32149a25, ?)
    //   0x28d959f0ee8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, 0x70f890e5, ?)
    //   0x28d959f0f00  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xa, 0x70f890e5, ?) xor 0x355dfc28), 0xa, 0x70f890e5, ?)
    //   0x28d959f0f80  sub_28b82780dcb((this add 0x80), (rax xor rax), 0x70f890e5, ?)
    //   0x28d959f0fc8  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffb60), this, ?)
    //   0x28d959f1010  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f1022  sub_28d959f2408((this add 0x8), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f1048  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f105a  sub_28d959f26e0((this add 0x8), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f1080  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f1092  sub_28d959f83a8((this add 0x8), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f10b8  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f10ca  sub_28d959fb018((this add 0x8), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f10f0  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f1118  GetResult((? add 0xfffffffffffffb40), (? add 0xfffffffffffffb40), this, ?)
    //   0x28d959f1130  CB205E8EC72E43F8::CBAF62549A424241(GetResult((? add 0xfffffffffffffb40), (? add 0xfffffffffffffb40), this, ?))
    //   0x28d959f1160  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), ((? add 0xfffffffffffffb40) xor (? add 0xfffffffffffffb40)), 0xffffffffe3d454d7)
    //   0x28d959f1188  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x7, 0x588fb683)
    //   0x28d959f11b0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x1, 0xffffffffb4661cbf)
    //   0x28d959f11d8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x6, 0x6953dfe5)
    //   0x28d959f11f0  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x6, 0x6953dfe5) xor 0xdb096348))
    //   0x28d959f1280  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xffffffffffffff84, 0x34930853, ?)
    //   0x28d959f12b0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xffffffffffffff89, 0xffffffffb12a6bb3, ?)
    //   0x28d959f12d8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xffffffffffffff8a, 0xea45b13, ?)
    //   0x28d959f1308  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f1320  ConfiguredTaskAwaiter::GetResult((? add 0xfffffffffffffb60), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f1332  sub_28d959f2408((? add 0xfffffffffffffb60), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f1358  sub_28b82785f1f((? add 0xfffffffffffffb60), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f136a  sub_28d959f26e0((? add 0xfffffffffffffb60), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f1390  sub_28b82785f1f((? add 0xfffffffffffffb60), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f13a2  sub_28d959f83a8((? add 0xfffffffffffffb60), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f13c8  sub_28b82785f1f((? add 0xfffffffffffffb60), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f13da  sub_28d959fb018((? add 0xfffffffffffffb60), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f1400  sub_28b82785f1f((? add 0xfffffffffffffb60), 0xffffffffffffff8b, 0xffffffffee765673, ?)
    //   0x28d959f1578  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x4, 0x3f413b72)
    //   0x28d959f1590  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x4, 0x3f413b72) xor 0x8eff4e20))
    //   0x28d959f1638  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x5, 0x7b25b5d6, ?)
    //   0x28d959f1650  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x5, 0x7b25b5d6, ?) xor 0xc11965c1), 0x5, 0x7b25b5d6, ?)
    //   0x28d959f1680  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x6, 0x6acbb353, ?)
    //   0x28d959f1698  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x6, 0x6acbb353, ?) xor 0x24ce0b59), 0x6, 0x6acbb353, ?)
    //   0x28d959f16b8  CB205E8EC72E43F8::1FE71BF270194A79(GetResult((? add 0xfffffffffffffb40), (? add 0xfffffffffffffb40), this, ?), 0x6, 0x6acbb353, ?)
    //   0x28d959f1700  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x6, 0x29424ec9, ?)
    //   0x28d959f1718  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffb90), 0x6, 0x29424ec9, ?) xor 0x85a03c), 0x6, 0x29424ec9, ?)
    //   0x28d959f1790  CB205E8EC72E43F8::4CCF68FBA3F54C9E(GetResult((? add 0xfffffffffffffb40), (? add 0xfffffffffffffb40), this, ?), 0x6, 0x29424ec9, ?)
    //   ... 618 more calls
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
