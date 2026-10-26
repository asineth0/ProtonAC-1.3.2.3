// ============================================================
// token 0x06001341   EB69693599F64B76::01D019C428634CBA
// native code: 0x28d958bc7a0  (589 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '01D019C428634CBA' (
//   class [netstandard]System.Uri '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000003
// native-strings: 
// ============================================================

public  Task 01D019C428634CBA(Uri arg0, valuetype Threading.CancellationToken arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d958bc7e8  memset((? add 0xffffffffffffff50), (arg0 xor arg0), 0x60, ?)
    //   0x28d958bc828  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb0), 0xffffffffdc310cce)
    //   0x28d958bc8d8  WBARRIER(((? add 0xffffffffffffff50) add 0x20), 0xffffffffdc310cce)
    //   0x28d958bc8f8  WBARRIER(((? add 0xffffffffffffff50) add 0x28), 0xffffffffdc310cce)
    //   0x28d958bc950  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb0), 0x2, 0xffffffff860aa399)
    //   0x28d958bc968  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb0), 0x2, 0xffffffff860aa399) xor 0x500acf6e))
    //   0x28d958bc9b0  Start(((? add 0xffffffffffffff50) add 0x8), (? add 0xffffffffffffff50), 0xffffffff860aa399, ?)
    //   0x28d958bc9d0  get_Task(((? add 0xffffffffffffff50) add 0x8), (? add 0xffffffffffffff50), 0xffffffff860aa399, ?)
    // 6 store(s):
    //   0x28d958bc8a9  ((? add 0xffffffffffffff50) add 0x8) <- ((u32 (((((0xfffffffff8b869a4 xor 0x263657aa) sub 0x34c85d28) imul 0x10ba5425) and 0x3) shl 0x3)) xor (u32 (((((0xfffffffff8b869a4 xor 0x263657aa) sub 0x34c85d2
    //   0x28d958bc8b0  ((? add 0xffffffffffffff50) add 0x8) <- ((u32 (((((0xfffffffff8b869a4 xor 0x263657aa) sub 0x34c85d28) imul 0x10ba5425) and 0x3) shl 0x3)) xor (u32 (((((0xfffffffff8b869a4 xor 0x263657aa) sub 0x34c85d2
    //   0x28d958bc8b8  ((? add 0xffffffffffffff50) add 0x8) <- ((u32 (((((0xfffffffff8b869a4 xor 0x263657aa) sub 0x34c85d28) imul 0x10ba5425) and 0x3) shl 0x3)) xor (u32 (((((0xfffffffff8b869a4 xor 0x263657aa) sub 0x34c85d2
    //   0x28d958bc8ca  ((? add 0xffffffffffffff50) add 0x20) <- this
    //   0x28d958bc8e9  ((? add 0xffffffffffffff50) add 0x28) <- arg0
    //   0x28d958bc927  ((? add 0xffffffffffffff50) add 0x30) <- arg1
    // returns: get_Task(((? add 0xffffffffffffff50) add 0x8), (? add 0xffffffffffffff50), 0xffffffff860aa399, ?)
}
