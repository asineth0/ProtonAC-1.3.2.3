// ============================================================
// token 0x06000467   8162F8F545F5474A::4D65BD4381F7417B
// native code: 0x28d95a0da00  (357 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   class [netstandard]System.Threading.Tasks.Task`1<bool> '4D65BD4381F7417B' () cil managed noinlining
//   
// native-calls: 06000007
// native-strings: 
// ============================================================

public static Task<bool> 4D65BD4381F7417B()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d95a0da78  <Module>::3F57E81A62734AC2(0x16aa9e93)   ; =-1
    //   0x28d95a0db20  Start(((? add 0xffffffffffffff90) add 0x8), (? add 0xffffffffffffff90), ?, ?)
    //   0x28d95a0db50  get_Task(((? add 0xffffffffffffff90) add 0x8), (? add 0xffffffffffffff90), ?, ?)
    // 3 store(s):
    //   0x28d95a0da56  ((? add 0xffffffffffffff90) add 0x8) <- (xor ?)
    //   0x28d95a0da5d  ((? add 0xffffffffffffff90) add 0x8) <- (xor ?)
    //   0x28d95a0da65  ((? add 0xffffffffffffff90) add 0x8) <- (xor ?)
    // returns: get_Task(((? add 0xffffffffffffff90) add 0x8), (? add 0xffffffffffffff90), ?, ?)
}
