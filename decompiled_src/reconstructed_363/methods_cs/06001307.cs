// ============================================================
// token 0x06001307   B3B2A314445E4979::MoveNext
// native code: 0x28d9730d340  (7289 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06001942,06001943,0600130a,06000007,06001309,06000004,06000005,06000003,0600130b,06000006,0600130d,0600130c,0600130e,0600130f,06001310,06001311,06001312,06001313,06004680
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06001306
// state-machine class: B3B2A314445E4979 ; fields: 8
//   .field public int32 C6C882B472974A95
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<string> '550D16D11F8C4532'
//   .field public string '2D82E063D21A48DE'
//   .field public valuetype [netstandard]System.Threading.CancellationToken BDCEC5E5B07C4189
//   .field private class [netstandard]System.Security.Cryptography.SHA256 '9119499AB1BD425E'
//   .field private uint8[] '0473D44229224A40'
//   .field private class [netstandard]System.IO.FileStream E453177D37F340F8
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<int32> F0196C6280B54883
private async Task<string> 580648BE2D68495A(string arg0, valuetype Threading.CancellationToken arg1)
{
    // <>1__state <- <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xa, 0x538c5a2d) xor 0xaca60e6a))
    // <>1__state <- <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffffcbb6faaa) xor 0x4f4791ac))
    // <>1__state <- <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x9, (0xffffffff8840bad0 xor 0xffffffff8840bad0)) xor 0x23af5af))
    // 1 await site(s):
    //   await #1 @0x28d9730e4c8  type=Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<int32>
    //
    // native action order (address order):
    //   0x28d9730d3e0  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff28), 0xffffffffc8fd7efe)
    //   0x28d9730d418  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x9, 0xfffffffff8c9a467)
    //   0x28d9730d530  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffffd1db3e2c)
    //   0x28d9730d550  B3B2A314445E4979::AAA995D57A5B4D41()
    //   0x28d9730d5b8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffff8d3e5b0a, ?)
    //   0x28d9730d5d8  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffff8d3e5b0a, ?) xor 0x34e15fcf), 0x6, 0xffffffff8d3e5b0a, ?)
    //   0x28d9730d5e8  B3B2A314445E4979::A659AB738A3443B6(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffff8d3e5b0a, ?) xor 0x34e15fcf), 0x6, 0xffffffff8d3e5b0a, ?), 
    //   0x28d9730d5f8  ?(B3B2A314445E4979::A659AB738A3443B6(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffff8d3e5b0a, ?) xor 0x34e15fcf), 0x6, 0xffffffff8d3e5b0a, ?)
    //   0x28d9730d678  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xa, 0xffffffffd1db3e2c)
    //   0x28d9730d6b8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x2, 0x3e992469)
    //   0x28d9730d6d8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), (0x2 xor 0x2), 0x5ed954b2)
    //   0x28d9730d7b8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x5, 0xffffffffaa4265a8)
    //   0x28d9730d7d0  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x5, 0xffffffffaa4265a8) xor 0xf157e35f))
    //   0x28d9730d860  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x9, 0xffffffff8cc0a99e)
    //   0x28d9730d878  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x9, 0xffffffff8cc0a99e) xor 0x3fe2e7f7))
    //   0x28d9730d8a8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffffb33b19c)
    //   0x28d9730d8c0  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffffb33b19c) xor 0xcd0bbdf3))
    //   0x28d9730d8f0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x5, 0xfffffffff4721827)
    //   0x28d9730d908  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x5, 0xfffffffff4721827) xor 0xd0b40fc6))
    //   0x28d9730d938  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffff831c00e1)
    //   0x28d9730d950  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffff831c00e1) xor 0x76092180))
    //   0x28d9730d980  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffffb33b19c)
    //   0x28d9730d9a8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x9, 0xffffffffd48ad893)
    //   0x28d9730d9d0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x2, 0xffffffff831c00e1)
    //   0x28d9730d9f0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xb, (0xffffffff831c00e1 xor 0xffffffff831c00e1))
    //   0x28d9730da08  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xb, (0xffffffff831c00e1 xor 0xffffffff831c00e1)) xor 0x5bce075b))
    //   0x28d9730da48  B3B2A314445E4979::FE96CCF7C21947FB(this.f20, <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x9, 0xffffffff8cc0a99e) xor 0x3fe2e7f7)), <Module>::F84FA79ABE6
    //   0x28d9730dab8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x1, 0x3b205cfd)
    //   0x28d9730dae0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x1, 0x79450770)
    //   0x28d9730dbd8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x5, 0x7a9366bd)
    //   0x28d9730dc00  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff1376ec6)
    //   0x28d9730dc28  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xa, 0x538c5a2d)
    //   0x28d9730dc40  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xa, 0x538c5a2d) xor 0xaca60e6a))
    //   0x28d9730dca8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x3, 0x2935fb2e)
    //   0x28d9730dcd0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x9, 0xffffffff92554cc1)
    //   0x28d9730dcf8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), (0x9 xor 0x9), 0xfffffffffe00fe1a)
    //   0x28d9730dd20  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffffcbb6faaa)
    //   0x28d9730dd38  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffffcbb6faaa) xor 0x4f4791ac))
    //   0x28d9730de28  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x1, 0x7a9366bd)
    //   0x28d9730de40  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x1, 0x7a9366bd) xor 0xc6543b70))
    //   0x28d9730de98  B3B2A314445E4979::E6A166C0397C45E0(this.f40, this.f38, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x1, 0x7a9366bd) xor 0xc6543b70)), (movsxd this.f38.f1
    //   0x28d9730dec8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff1376ec6)
    //   0x28d9730dee0  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff1376ec6) xor 0x865be719))
    //   0x28d9730dff8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0x48a2654e)
    //   0x28d9730e010  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0x48a2654e) xor 0x75017def))
    //   0x28d9730e040  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x3, 0xfffffffff7032aa4)
    //   0x28d9730e068  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xa, 0x2d800156)
    //   0x28d9730e090  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x1, 0xffffffff9f92af30)
    //   0x28d9730e0b0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), (0x1 xor 0x1), 0x2f462dee)
    //   0x28d9730e0c8  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), (0x1 xor 0x1), 0x2f462dee) xor 0xc6543b70))
    //   0x28d9730e100  B3B2A314445E4979::DFCBB7B34D9D4D9F(this.f30, this.f38, <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0x48a2654e) xor 0x75017def)), (rdi xor rdi))
    //   0x28d9730e150  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0x3116095d)
    //   0x28d9730e168  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0x3116095d) xor 0x44ac57af))
    //   0x28d9730e198  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff0dced59)
    //   0x28d9730e1b0  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff0dced59) xor 0x896fd91e))
    //   0x28d9730e1d8  B3B2A314445E4979::85FB7730B8BA4991(this.f30, 0x28c84118800, <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0x3116095d) xor 0x44ac57af)), <Module>::58EC
    //   0x28d9730e210  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff28), 0x1d0147a2)
    //   0x28d9730e238  GetResult((? add 0xffffffffffffff08), 0x1d0147a2, <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0x3116095d) xor 0x44ac57af)), <Module>::58ECCB512F2A43
    //   0x28d9730e270  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x4, 0xffffffffde714328)
    //   0x28d9730e298  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x1, 0xffffffffe5d9ea13)
    //   0x28d9730e2c0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x3, 0x8fcd55c)
    //   0x28d9730e2e8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xa, 0x65226418)
    //   0x28d9730e300  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xa, 0x65226418) xor 0x44ac57af))
    //   0x28d9730e448  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x2, 0x538c5a2d)
    //   0x28d9730e4c8  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff08), this, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff0dced59) xor
    //   0x28d9730e4da  sub_28d9730e740((this add 0x8), (? add 0xffffffffffffff08), this, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff0dced59) xor 0x896fd91e)))
    //   0x28d9730e500  sub_28b82785f1f((this add 0x8), (? add 0xffffffffffffff08), this, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff0dced59) xor 0x896fd91e)))
    //   0x28d9730e512  sub_28d9730e928((this add 0x8), (? add 0xffffffffffffff08), this, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff0dced59) xor 0x896fd91e)))
    //   0x28d9730e538  sub_28b82785f1f((this add 0x8), (? add 0xffffffffffffff08), this, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x8, 0xfffffffff0dced59) xor 0x896fd91e)))
    //   0x28d9730e558  B3B2A314445E4979::950A0AE4BDDD4846(this.f30)
    //   0x28d9730e580  B3B2A314445E4979::38ADEA32E3F94967(0x28c84118800)
    //   0x28d9730e5b0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x4, 0x6cd8c46f)
    //   0x28d9730e5d0  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x4, 0x6cd8c46f) xor 0x499fc559))
    //   0x28d9730e600  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x4, 0xffffffff8d639d59)
    //   0x28d9730e628  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x1, 0xffffffffac7b62ae)
    //   0x28d9730e650  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0xb, 0x203925d2)
    //   0x28d9730e678  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffffae949eb2)
    //   0x28d9730e698  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x6, 0xffffffffae949eb2) xor 0x753cb0e4))
    //   0x28d9730e6b8  B3B2A314445E4979::0DA3F7C438A049F7(B3B2A314445E4979::38ADEA32E3F94967(0x28c84118800), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x4, 0x6cd8c46f) xor 0x
    //   0x28d9730e6c8  B3B2A314445E4979::F6E6345867324268(B3B2A314445E4979::0DA3F7C438A049F7(B3B2A314445E4979::38ADEA32E3F94967(0x28c84118800), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffff
    //   0x28d9730e6dd  sub_28d9730e740(B3B2A314445E4979::0DA3F7C438A049F7(B3B2A314445E4979::38ADEA32E3F94967(0x28c84118800), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x4, 0x
    //   0x28d9730e700  sub_28b82785f1f(B3B2A314445E4979::0DA3F7C438A049F7(B3B2A314445E4979::38ADEA32E3F94967(0x28c84118800), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x4, 0x
    //   0x28d9730e712  sub_28d9730e928(B3B2A314445E4979::0DA3F7C438A049F7(B3B2A314445E4979::38ADEA32E3F94967(0x28c84118800), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x4, 0x
    //   0x28d9730e738  sub_28b82785f1f(B3B2A314445E4979::0DA3F7C438A049F7(B3B2A314445E4979::38ADEA32E3F94967(0x28c84118800), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff28), 0x4, 0x
    //   ... 15 more calls
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
