// ============================================================
// token 0x06000185   6487285FB41C4853::46F5E45364394CBB
// native code: 0x28d958b7190  (365 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   class [netstandard]System.Threading.Tasks.Task`1<bool> '46F5E45364394CBB' () cil managed noinlining
//   
// native-calls: 06000005
// native-strings: 
// ============================================================

public static Task<bool> 46F5E45364394CBB()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958b71c8  memset((? add 0xffffffffffffff60), (xor ?), 0x70, ?)
    //   0x28d958b7290  <Module>::F84FA79ABE6944BB(0x55eec410)   ; =-1
    //   0x28d958b72c0  Start(((? add 0xffffffffffffff60) add 0x8), (? add 0xffffffffffffff60), 0x70, ?)
    //   0x28d958b72e8  get_Task(((? add 0xffffffffffffff60) add 0x8), (? add 0xffffffffffffff60), 0x70, ?)
    // 3 store(s):
    //   0x28d958b71ea  ((? add 0xffffffffffffff60) add 0x8) <- ((? add 0xffffffffffffff60) xor (? add 0xffffffffffffff60))
    //   0x28d958b71f1  ((? add 0xffffffffffffff60) add 0x8) <- ((? add 0xffffffffffffff60) xor (? add 0xffffffffffffff60))
    //   0x28d958b71f9  ((? add 0xffffffffffffff60) add 0x8) <- ((? add 0xffffffffffffff60) xor (? add 0xffffffffffffff60))
    // returns: get_Task(((? add 0xffffffffffffff60) add 0x8), (? add 0xffffffffffffff60), 0x70, ?)
}
