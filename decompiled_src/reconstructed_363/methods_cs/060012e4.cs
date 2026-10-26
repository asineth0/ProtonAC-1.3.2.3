// ============================================================
// token 0x060012e4   FCCCB96C1ED54B33::MoveNext
// native code: 0x28d958b2290  (3186 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06001942,06001943,06000005,060012e6,06000007,060012e7,060012e8,06000006,06004674,06000004
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x060012e3
// state-machine class: FCCCB96C1ED54B33 ; fields: 7
//   .field public int32 FB09D97E1F2C415E
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder F510453212A14D61
//   .field public class '1FFBEDFB3FCE4374'/AF79E7444BE448B5 EF283C9BEF0F49E2
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter EB28496087314868
//   .field public class [netstandard]System.Func`1<class [netstandard]System.Threading.Tasks.Task> '6BC2A8A3463C441E'
//   .field public class [netstandard]System.Action`1<class [netstandard]System.Exception> A91729BAB9D34C35
//   .field public string '62319C31FAE444DC'
private async Task AF99366C78464237()
{
    // <>1__state <- <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x8, (0xffffffff8e95e3f1 xor 0xffffffff8e95e3f1)) xor 0x2dad9fca))
    // <>1__state <- <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x9, 0x415e9a79) xor 0x2b1edecf))
    // <>1__state <- <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x2, 0x2e9f2673, ?) xor 0xde7dfda9), 0x2, 0x2e9f2673, ?)
    // <>1__state <- <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x8, 0x5c3d7764) xor 0x48879ea5))
    // 1 await site(s):
    //   await #1 @0x28d958b2720  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d958b2338  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff70), 0xfffffffff9604059)
    //   0x28d958b2380  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x4, 0xffffffffe8db4f60)
    //   0x28d958b2448  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x2, 0x72fc9563)
    //   0x28d958b2538  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x9, 0xffffffff8e95e3f1)
    //   0x28d958b2558  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x8, (0xffffffff8e95e3f1 xor 0xffffffff8e95e3f1))
    //   0x28d958b2570  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x8, (0xffffffff8e95e3f1 xor 0xffffffff8e95e3f1)) xor 0x2dad9fca))
    //   0x28d958b25b8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x4, 0x5c3d7764)
    //   0x28d958b25d0  GetResult((? add 0xffffffffffffff68), 0x4, 0x5c3d7764, ?)
    //   0x28d958b2608  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x5, 0xffffffff8e95e3f1)
    //   0x28d958b2638  FCCCB96C1ED54B33::226E2288E911415B(this.f20.f10)
    //   0x28d958b2720  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff68), this, ?)
    //   0x28d958b2770  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x9, 0x415e9a79)
    //   0x28d958b2788  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x9, 0x415e9a79) xor 0x2b1edecf))
    //   0x28d958b28b8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x1, 0xffffffff894b648d, ?)
    //   0x28d958b2918  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0xb, 0xfffffffffb5f1386, ?)
    //   0x28d958b2958  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x2, 0x70abeca5, ?)
    //   0x28d958b29a0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x1, 0xffffffff894b648d, ?)
    //   0x28d958b29c0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x6, (0xffffffff894b648d xor 0xffffffff894b648d), ?)
    //   0x28d958b29e0  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x6, (0xffffffff894b648d xor 0xffffffff894b648d), ?) xor 0xb57a9efa), 0x6, (0xffffffff894b648d xor 0xffffffff
    //   0x28d958b2a08  FCCCB96C1ED54B33::9CC6DE4528614713(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x6, (0xffffffff894b648d xor 0xffffffff894b648d), ?) xor 0xb57a9efa), 0x6,
    //   0x28d958b2a18  FCCCB96C1ED54B33::3BB026976DD54E07(FCCCB96C1ED54B33::9CC6DE4528614713(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x6, (0xffffffff894b648d xor 0xffffffff
    //   0x28d958b2a50  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x8, 0xffffffffb0bd9fc2, ?)
    //   0x28d958b2ac8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x9, 0xffffffffd615295e, ?)
    //   0x28d958b2af8  sub_28c8598b8d0((? add 0xffffffffffffff70), 0x9, 0xffffffffd615295e, ?)
    //   0x28d958b2b18  ?(sub_28c8598b8d0((? add 0xffffffffffffff70), 0x9, 0xffffffffd615295e, ?), 0x9, 0xffffffffd615295e, ?)
    //   0x28d958b2b40  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0xa, 0xffffffffda6442cc)
    //   0x28d958b2c38  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), (((((((((((movsxd 0xa051c4fc) sub 0x5adab758ad52573c) xor 0x435cbfeb) sub 0x98df732ca4d7b23f) not 0x1) neg 0x1) xor 0xc6228495) not 0x1) 
    //   0x28d958b2c60  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x9, 0xea0bd7a, ?)
    //   0x28d958b2c88  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x7, 0x168d5cf0, ?)
    //   0x28d958b2cb0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x2, 0x2e9f2673, ?)
    //   0x28d958b2cc8  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x2, 0x2e9f2673, ?) xor 0xde7dfda9), 0x2, 0x2e9f2673, ?)
    //   0x28d958b2d28  sub_28c8598b8d0((this add 0x8), 0x0, 0x2e9f2673, ?)
    //   0x28d958b2d48  ?(sub_28c8598b8d0((this add 0x8), 0x0, 0x2e9f2673, ?), 0x0, 0x2e9f2673, ?)
    //   0x28d958b2d80  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x5, 0x415e9a79)
    //   0x28d958b2da8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0xa, 0xffffffffda6442cc)
    //   0x28d958b2dd0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x8, 0x5c3d7764)
    //   0x28d958b2de8  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff70), 0x8, 0x5c3d7764) xor 0x48879ea5))
    //   0x28d958b2ec0  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff70), 0xffffffff84ca7f06)
    //   0x28d958b2ef8  THROW(0x162, 0x832)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
