// ============================================================
// token 0x0600026c   A19CBF069C964833::2D34939E383B44AA
// native code: 0x28d95a3df70  (197 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '2D34939E383B44AA' () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

 Task 2D34939E383B44AA()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d95a3dfe8  WBARRIER(((? add 0xffffffffffffffb0) add 0x20), ?)
    //   0x28d95a3e010  Start(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    //   0x28d95a3e028  get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    // 4 store(s):
    //   0x28d95a3dfb6  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a3dfbd  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a3dfc5  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a3dfd4  ((? add 0xffffffffffffffb0) add 0x20) <- this
    // returns: get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
}
