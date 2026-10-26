// ============================================================
// token 0x060000c3   1DB744298E9F4B09::41DFABF87E734B85
// native code: 0x28d958b3200  (221 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '41DFABF87E734B85' () cil managed noinlining
//   
// native-calls: 06000006
// native-strings: 
// ============================================================

 Task 41DFABF87E734B85()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958b3278  WBARRIER(((? add 0xffffffffffffffb0) add 0x20), ?)
    //   0x28d958b3290  <Module>::58ECCB512F2A43AC(0xfffffffff9446e57)   ; =-1
    //   0x28d958b32b8  Start(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    //   0x28d958b32d0  get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    // 4 store(s):
    //   0x28d958b3246  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d958b324d  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d958b3255  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d958b3264  ((? add 0xffffffffffffffb0) add 0x20) <- this
    // returns: get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
}
