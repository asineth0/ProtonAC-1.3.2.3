// ============================================================
// token 0x060013eb   807B969C6FEF4819::MoveNext
// native code: 0x28d958bcc30  (7854 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06001942,06001943,06004671,06000003,06000006,06001348,060013ed,060013ee,06000005,060013ef,06001dc2,06000007,06001342,06000004,06001344,0600463d,060013f0,060013f1,060013f2,06004674
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x06001341
// state-machine class: 807B969C6FEF4819 ; fields: 9
//   .field public int32 DBB679C9D3A24046
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '6581E9423C8E4C55'
//   .field public class EB69693599F64B76 '19D3B470E7FF49AF'
//   .field public class [netstandard]System.Uri '10BD129B4B2F4765'
//   .field public valuetype [netstandard]System.Threading.CancellationToken '0065713379194052'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '663C199554DB490F'
//   .field private object FD975F11EF054834
//   .field private int32 '893B9DE64FD64001'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<bool> CB09D19006CB4223
private async Task 01D019C428634CBA(Uri arg0, valuetype Threading.CancellationToken arg1)
{
    // <>1__state <- <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0xa, (0xffffffffd7405af9 xor 0xffffffffd7405af9), ?) xor 0x52e086a9),
    // <>1__state <- <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x7, 0xffffffffd50698b2, ?) xor 0x9e1716c1), 0x7, 0xffffffffd50698b2,
    // <>1__state <- <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), (0xb xor 0xb), 0x46330f60) xor 0x3de866c))
    // <>1__state <- <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x8, 0x39937b5a) xor 0x2e68a04b))
    // 3 await site(s):
    //   await #1 @0x28d958bced0  type=Runtime.CompilerServices.TaskAwaiter
    //   await #2 @0x28d958bdaa0  type=Runtime.CompilerServices.ConfiguredTaskAwaitable`1/ConfiguredTaskAwaiter<bool>
    //   await #3 @0x28d958be480  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d958bcce8  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff10), 0x4fc02bbe)
    //   0x28d958bcde8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x8, 0xffffffffa6e29205)
    //   0x28d958bced0  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffee8), this, ?)
    //   0x28d958bcf20  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x9, 0x28bfa507)
    //   0x28d958bcf38  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x9, 0x28bfa507) xor 0x73621133))
    //   0x28d958bcf88  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), (0x9 xor 0x9), 0xffffffff9044f151)
    //   0x28d958bd000  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x9, 0xffffffffd7405af9, ?)
    //   0x28d958bd020  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0xa, (0xffffffffd7405af9 xor 0xffffffffd7405af9), ?)
    //   0x28d958bd038  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0xa, (0xffffffffd7405af9 xor 0xffffffffd7405af9), ?) xor 0x52e086a9), 0xa, (0xffffffffd7405af9 xor 0xffffffff
    //   0x28d958bd088  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x1, 0xffffffffd7405af9)
    //   0x28d958bd138  EB69693599F64B76::A21AF88AEF814609(this.f20)
    //   0x28d958bd148  807B969C6FEF4819::16B29B59F808427C(EB69693599F64B76::A21AF88AEF814609(this.f20))
    //   0x28d958bd188  GetResult((? add 0xfffffffffffffee8), (this add 0x30).f0, 0xffffffffd7405af9, ?)
    //   0x28d958bd248  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x4, 0xf3bedad, ?)
    //   0x28d958bd270  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0xa, 0xffffffffb96e9c72, ?)
    //   0x28d958bd298  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x1, 0x5e390cd5, ?)
    //   0x28d958bd2c0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x7, 0xffffffffd50698b2, ?)
    //   0x28d958bd2d8  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x7, 0xffffffffd50698b2, ?) xor 0x9e1716c1), 0x7, 0xffffffffd50698b2, ?)
    //   0x28d958bd330  sub_28b82780dcb((this add 0x38), 807B969C6FEF4819::16B29B59F808427C(EB69693599F64B76::A21AF88AEF814609(this.f20)), 0xffffffffd50698b2, ?)
    //   0x28d958bd388  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), (807B969C6FEF4819::16B29B59F808427C(EB69693599F64B76::A21AF88AEF814609(this.f20)) xor 807B969C6FEF4819::16B29B59F808427C(EB69693599F64B76
    //   0x28d958bd3a0  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), (807B969C6FEF4819::16B29B59F808427C(EB69693599F64B76::A21AF88AEF814609(this.f20)) xor 807B969C6FEF4819::16B29
    //   0x28d958bd480  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x9, 0xffffffffdc22e120)
    //   0x28d958bd4a0  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x9, 0xffffffffdc22e120) xor 0xaa84389c))
    //   0x28d958bd4c8  807B969C6FEF4819::9817B139C926457B(this.f20.f18, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x9, 0xffffffffdc22e120) xor 0xaa84389c)), 0x28cc7550840)
    //   0x28d958bd4f8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x6, 0x546b3eb5)
    //   0x28d958bd520  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x9, 0x23dd1ee0)
    //   0x28d958bd540  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x7, (0x23dd1ee0 xor 0x23dd1ee0))
    //   0x28d958bd558  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x7, (0x23dd1ee0 xor 0x23dd1ee0)) xor 0x5c3d644a))
    //   0x28d958bd5f0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, ((0x23dd1ee0 xor 0x23dd1ee0) xor (0x23dd1ee0 xor 0x23dd1ee0)), ?)
    //   0x28d958bd610  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, ((0x23dd1ee0 xor 0x23dd1ee0) xor (0x23dd1ee0 xor 0x23dd1ee0)), ?) xor 0x96373607), 0x2, ((0x23dd1ee0 xor
    //   0x28d958bd638  807B969C6FEF4819::9817B139C926457B(this.f20.f18, <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, ((0x23dd1ee0 xor 0x23dd1ee0) xor (0x23dd1ee0 xor 0x23dd
    //   0x28d958bd6a0  sub_28b82780dcb((ALLOC_OBJECT(0x28cc8356f60) add 0x20), <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, ((0x23dd1ee0 xor 0x23dd1ee0) xor (0x23dd1ee0 xor
    //   0x28d958bd720  807B969C6FEF4819::15D228E960E04B69(ALLOC_OBJECT(0x28cc8356f60), (this.f20 add 0x28).f0, 0x28cc7550840, ?)
    //   0x28d958bd760  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x6, 0x546b3eb5, ?)
    //   0x28d958bd788  CancellationToken::get_IsCancellationRequested((this.f20 add 0x28), 0x6, 0x546b3eb5, ?)
    //   0x28d958bd878  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0xa, 0xffffffffb96e9c72)
    //   0x28d958bd8a0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x357967ce)
    //   0x28d958bd8c8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0xb, 0xffffffffd50698b2)
    //   0x28d958bd8e8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), (0xb xor 0xb), 0x46330f60)
    //   0x28d958bd900  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), (0xb xor 0xb), 0x46330f60) xor 0x3de866c))
    //   0x28d958bd950  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff10), 0x517c89b6)
    //   0x28d958bd968  GetResult((? add 0xfffffffffffffef0), 0x517c89b6, 0x46330f60, ?)
    //   0x28d958bd9d0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x8, 0x39937b5a)
    //   0x28d958bd9e8  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x8, 0x39937b5a) xor 0x2e68a04b))
    //   0x28d958bdaa0  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffef0), this, ?)
    //   0x28d958bdaf0  EB69693599F64B76::095631238EF24370(this.f20, this.f28, (this add 0x30).f0)
    //   0x28d958bdb20  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x6, 0xffffffffb96e9c72)
    //   0x28d958bdb48  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x1, 0x357967ce)
    //   0x28d958bdb70  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x7, 0xffffffffd50698b2)
    //   0x28d958bdb98  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x8, 0x46330f60)
    //   0x28d958bdbb0  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x8, 0x46330f60) xor 0x7cf03f0))
    //   0x28d958bdcc8  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff10), 0x683c740c)
    //   0x28d958bdd10  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x4, 0xffffffff8bd2019a)
    //   0x28d958bded0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x4, 0xffffffffeb071817)
    //   0x28d958bdef8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x9, 0xffffffffba507925)
    //   0x28d958bdf20  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x3, 0x1271cb9b)
    //   0x28d958bdf48  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x6, 0xffffffffd81e6df8)
    //   0x28d958bdf60  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x6, 0xffffffffd81e6df8) xor 0x6447a1ff))
    //   0x28d958be088  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, 0x4e1f9573, ?)
    //   0x28d958be0a0  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, 0x4e1f9573, ?) xor 0xc69f3eee), 0x2, 0x4e1f9573, ?)
    //   0x28d958be0d0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x4, 0xffffffff8c2196dd, ?)
    //   0x28d958be0e8  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x4, 0xffffffff8c2196dd, ?) xor 0x711d2d82), 0x4, 0xffffffff8c2196dd, ?)
    //   0x28d958be118  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?)
    //   0x28d958be130  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?) xor 0x155226bd), 0x5, 0x2e816b98, ?)
    //   0x28d958be160  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x8, 0x5ac7d71b, ?)
    //   0x28d958be180  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x8, 0x5ac7d71b, ?) xor 0x44d250ee), 0x8, 0x5ac7d71b, ?)
    //   0x28d958be1b8  EB69693599F64B76::2BBC551851794EDE(this.f20, <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, 0x4e1f9573, ?) xor 0xc69f3eee), 0x2, 0x4e1f9573, ?), <Modul
    //   0x28d958be1c8  807B969C6FEF4819::16B29B59F808427C(EB69693599F64B76::2BBC551851794EDE(this.f20, <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, 0x4e1f9573, ?) xor 0xc69
    //   0x28d958be2c8  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff10), 0xffffffffee5a979b, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x4, 0xffffffff8c2196dd, ?) xor 0x711
    //   0x28d958be2e0  TaskAwaiter::GetResult((? add 0xfffffffffffffee8), 0xffffffffee5a979b, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x4, 0xffffffff8c2196dd, ?) xor 0x711d
    //   0x28d958be318  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x9, 0x205c6dbd)
    //   0x28d958be368  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), (0x9 xor 0x9), 0xffffffffcc0318eb, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e81
    //   0x28d958be390  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x7, 0xffffffffb12f070f, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?) x
    //   0x28d958be3b8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x6, 0x725bdce6, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?) xor 0x155
    //   0x28d958be3e0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0xffffffffb4382876, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?) x
    //   0x28d958be3f8  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0xffffffffb4382876, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffff
    //   0x28d958be450  sub_28b82780dcb((this add 0x38), 807B969C6FEF4819::16B29B59F808427C(EB69693599F64B76::2BBC551851794EDE(this.f20, <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff1
    //   0x28d958be480  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffee8), this, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5,
    //   0x28d958be4c0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x4, 0xffffffffc338f546, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?) x
    //   0x28d958be4e8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x1, 0xffffffff81413f58, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?) x
    //   0x28d958be510  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0xa, 0xffffffffcb354094, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?) x
    //   0x28d958be538  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x3, 0x23d791a3, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?) xor 0x155
    //   0x28d958be550  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x3, 0x23d791a3, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0
    //   0x28d958be608  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, 0x536bb5a2, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x5, 0x2e816b98, ?) xor 0x155
    //   0x28d958be628  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0x2, 0x536bb5a2, <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff10), 0
    //   ... 23 more calls
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
