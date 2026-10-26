// ============================================================
// token 0x06001343   EB69693599F64B76::8F5BC7DF90C24392
// native code: 0x28d958ddee0  (617 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '8F5BC7DF90C24392' (
//   valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000007
// native-strings: 
// ============================================================

 Task 8F5BC7DF90C24392(Threading.CancellationToken arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 7 call(s):
    //   0x28d958ddf28  memset((? add 0xffffffffffffff20), (arg0 xor arg0), 0x98, ?)
    //   0x28d958ddf68  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0xffffffffd8df6028)
    //   0x28d958de040  WBARRIER(((? add 0xffffffffffffff20) add 0x20), (((((((0xffffffffbd376f18 sub 0x2fb0244ff3dea849) imul 0x7ffff157) xor 0xff46edeff7edadf0) xor 0xfffffffe7b863b99) imul 0x8593ae47) div 0x5) mod 0x5))
    //   0x28d958de0b0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x5, 0xffffffffeb977ff4)
    //   0x28d958de0c8  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x5, 0xffffffffeb977ff4) xor 0xc39ae48f))
    //   0x28d958de0f8  Start(((? add 0xffffffffffffff20) add 0x8), (? add 0xffffffffffffff20), 0xffffffffeb977ff4, ?)
    //   0x28d958de130  get_Task(((? add 0xffffffffffffff20) add 0x8), (? add 0xffffffffffffff20), 0xffffffffeb977ff4, ?)
    // 5 store(s):
    //   0x28d958ddf8a  ((? add 0xffffffffffffff20) add 0x8) <- ((? add 0xffffffffffffffb8) xor (? add 0xffffffffffffffb8))
    //   0x28d958ddf91  ((? add 0xffffffffffffff20) add 0x8) <- ((? add 0xffffffffffffffb8) xor (? add 0xffffffffffffffb8))
    //   0x28d958ddf99  ((? add 0xffffffffffffff20) add 0x8) <- ((? add 0xffffffffffffffb8) xor (? add 0xffffffffffffffb8))
    //   0x28d958de02c  ((? add 0xffffffffffffff20) add 0x20) <- this
    //   0x28d958de06f  ((? add 0xffffffffffffff20) add 0x28) <- arg0
    // returns: get_Task(((? add 0xffffffffffffff20) add 0x8), (? add 0xffffffffffffff20), 0xffffffffeb977ff4, ?)
}
