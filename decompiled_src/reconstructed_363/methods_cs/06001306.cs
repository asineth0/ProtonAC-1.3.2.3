// ============================================================
// token 0x06001306   C0116C0E74974CCA::580648BE2D68495A
// native code: 0x28d9730cef0  (577 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   class [netstandard]System.Threading.Tasks.Task`1<string> '580648BE2D68495A' (
//   string '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000004
// native-strings: 
// ============================================================

public static Task<string> 580648BE2D68495A(string arg0, valuetype Threading.CancellationToken arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 7 call(s):
    //   0x28d9730cf38  memset((? add 0xffffffffffffff60), (arg1 xor arg1), 0x58, ?)
    //   0x28d9730cf70  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0x29311cb4)
    //   0x28d9730d038  WBARRIER(((? add 0xffffffffffffff60) add 0x20), 0x29311cb4)
    //   0x28d9730d090  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffe89ac950)
    //   0x28d9730d0a8  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffe89ac950) xor 0x57e6e3f4))
    //   0x28d9730d0d8  Start(((? add 0xffffffffffffff60) add 0x8), (? add 0xffffffffffffff60), 0xffffffffe89ac950, ?)
    //   0x28d9730d118  get_Task(((? add 0xffffffffffffff60) add 0x8), (? add 0xffffffffffffff60), 0xffffffffe89ac950, ?)
    // 5 store(s):
    //   0x28d9730cf92  ((? add 0xffffffffffffff60) add 0x8) <- ((? add 0xffffffffffffffb8) xor (? add 0xffffffffffffffb8))
    //   0x28d9730cf99  ((? add 0xffffffffffffff60) add 0x8) <- ((? add 0xffffffffffffffb8) xor (? add 0xffffffffffffffb8))
    //   0x28d9730cfa1  ((? add 0xffffffffffffff60) add 0x8) <- ((? add 0xffffffffffffffb8) xor (? add 0xffffffffffffffb8))
    //   0x28d9730d02b  ((? add 0xffffffffffffff60) add 0x20) <- arg0
    //   0x28d9730d067  ((? add 0xffffffffffffff60) add 0x28) <- arg1
    // returns: get_Task(((? add 0xffffffffffffff60) add 0x8), (? add 0xffffffffffffff60), 0xffffffffe89ac950, ?)
}
