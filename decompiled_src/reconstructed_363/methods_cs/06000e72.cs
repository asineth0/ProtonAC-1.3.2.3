// ============================================================
// token 0x06000e72   02C54685DE0E4B81::6E01EC7AE9294356
// native code: 0x28d95a0a690  (497 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task`1<bool> '6E01EC7AE9294356' (
//   class '652C34B1E6554F10' '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06000004
// native-strings: 
// ============================================================

public  Task<bool> 6E01EC7AE9294356(652C34B1E6554F10 arg0, valuetype Threading.CancellationToken arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d95a0a720  WBARRIER(((? add 0xffffffffffffff88) add 0x28), arg0)
    //   0x28d95a0a7c0  WBARRIER(((? add 0xffffffffffffff88) add 0x20), ((((((((((0xffffffffb64c269c add 0x2c6db44b20c1c346) not 0x1) neg 0x1) neg 0x1) xor 0x6a90eca7f5cfc28e) neg 0x1) sub 0xffb53e09aa7d76d3) add 0xb13a2655) div 0x5) mod 0x5))
    //   0x28d95a0a7f0  <Module>::390073C602714496(0xffffffffd413acc0)   ; =-1
    //   0x28d95a0a818  Start(((? add 0xffffffffffffff88) add 0x8), (? add 0xffffffffffffff88), arg1, ?)
    //   0x28d95a0a868  get_Task(((? add 0xffffffffffffff88) add 0x8), (? add 0xffffffffffffff88), arg1, ?)
    // 6 store(s):
    //   0x28d95a0a6f4  ((? add 0xffffffffffffff88) add 0x8) <- (this xor this)
    //   0x28d95a0a6fb  ((? add 0xffffffffffffff88) add 0x8) <- (this xor this)
    //   0x28d95a0a703  ((? add 0xffffffffffffff88) add 0x8) <- (this xor this)
    //   0x28d95a0a712  ((? add 0xffffffffffffff88) add 0x28) <- this
    //   0x28d95a0a7b3  ((? add 0xffffffffffffff88) add 0x20) <- arg0
    //   0x28d95a0a839  ((? add 0xffffffffffffff88) add 0x30) <- arg1
    // returns: get_Task(((? add 0xffffffffffffff88) add 0x8), (? add 0xffffffffffffff88), arg1, ?)
}
