// ============================================================
// token 0x06000e6a   02C54685DE0E4B81::204ED62F8A484557
// native code: 0x28d95a016a0  (221 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '204ED62F8A484557' () cil managed noinlining
//   
// native-calls: 06000006
// native-strings: 
// ============================================================

 Task 204ED62F8A484557()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a01718  WBARRIER(((? add 0xffffffffffffffb0) add 0x20), ?)
    //   0x28d95a01730  <Module>::58ECCB512F2A43AC(0xfffffffff9446e57)   ; =-1
    //   0x28d95a01758  Start(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    //   0x28d95a01770  get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    // 4 store(s):
    //   0x28d95a016e6  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a016ed  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a016f5  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a01704  ((? add 0xffffffffffffffb0) add 0x20) <- this
    // returns: get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
}
