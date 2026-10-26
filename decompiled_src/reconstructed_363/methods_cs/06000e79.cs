// ============================================================
// token 0x06000e79   02C54685DE0E4B81::1CD1829443FF4215
// native code: 0x28d9730aaf0  (229 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '1CD1829443FF4215' () cil managed noinlining
//   
// native-calls: 06000006
// native-strings: 
// ============================================================

public  Task 1CD1829443FF4215()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d9730ab20  memset((? add 0xffffffffffffff90), (xor ?), 0x50, ?)
    //   0x28d9730ab70  WBARRIER(((? add 0xffffffffffffff90) add 0x20), (xor ?))
    //   0x28d9730ab88  <Module>::58ECCB512F2A43AC(0xfffffffff9446e57)   ; =-1
    //   0x28d9730abb0  Start(((? add 0xffffffffffffff90) add 0x8), (? add 0xffffffffffffff90), 0x50, ?)
    //   0x28d9730abc8  get_Task(((? add 0xffffffffffffff90) add 0x8), (? add 0xffffffffffffff90), 0x50, ?)
    // 4 store(s):
    //   0x28d9730ab40  ((? add 0xffffffffffffff90) add 0x8) <- ((? add 0xffffffffffffff90) xor (? add 0xffffffffffffff90))
    //   0x28d9730ab47  ((? add 0xffffffffffffff90) add 0x8) <- ((? add 0xffffffffffffff90) xor (? add 0xffffffffffffff90))
    //   0x28d9730ab4f  ((? add 0xffffffffffffff90) add 0x8) <- ((? add 0xffffffffffffff90) xor (? add 0xffffffffffffff90))
    //   0x28d9730ab5e  ((? add 0xffffffffffffff90) add 0x20) <- this
    // returns: get_Task(((? add 0xffffffffffffff90) add 0x8), (? add 0xffffffffffffff90), 0x50, ?)
}
