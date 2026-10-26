// ============================================================
// token 0x06000e68   02C54685DE0E4B81::73E9E2A3C0BD48F5
// native code: 0x28d958b3c30  (421 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '73E9E2A3C0BD48F5' (
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06000006
// native-strings: 
// ============================================================

public  Task 73E9E2A3C0BD48F5(valuetype Threading.CancellationToken arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d958b3c68  memset((? add 0xffffffffffffff88), (arg0 xor arg0), 0x48, ?)
    //   0x28d958b3cb8  WBARRIER(((? add 0xffffffffffffff88) add 0x20), (arg0 xor arg0))
    //   0x28d958b3d58  <Module>::58ECCB512F2A43AC(0xfffffffff9446e57)   ; =-1
    //   0x28d958b3d90  Start(((? add 0xffffffffffffff88) add 0x8), (? add 0xffffffffffffff88), 0x48, ?)
    //   0x28d958b3dc0  get_Task(((? add 0xffffffffffffff88) add 0x8), (? add 0xffffffffffffff88), 0x48, ?)
    // 5 store(s):
    //   0x28d958b3c88  ((? add 0xffffffffffffff88) add 0x8) <- ((? add 0xffffffffffffff88) xor (? add 0xffffffffffffff88))
    //   0x28d958b3c8f  ((? add 0xffffffffffffff88) add 0x8) <- ((? add 0xffffffffffffff88) xor (? add 0xffffffffffffff88))
    //   0x28d958b3c97  ((? add 0xffffffffffffff88) add 0x8) <- ((? add 0xffffffffffffff88) xor (? add 0xffffffffffffff88))
    //   0x28d958b3ca6  ((? add 0xffffffffffffff88) add 0x20) <- this
    //   0x28d958b3d3a  ((? add 0xffffffffffffff88) add 0x28) <- arg0
    // returns: get_Task(((? add 0xffffffffffffff88) add 0x8), (? add 0xffffffffffffff88), 0x48, ?)
}
