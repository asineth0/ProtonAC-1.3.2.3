// ============================================================
// token 0x0600026f   A19CBF069C964833::DA96FE2A9A0442AB
// native code: 0x28d95a3f870  (197 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task DA96FE2A9A0442AB () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

 Task DA96FE2A9A0442AB()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d95a3f8e8  WBARRIER(((? add 0xffffffffffffffb0) add 0x20), ?)
    //   0x28d95a3f910  Start(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    //   0x28d95a3f928  get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    // 4 store(s):
    //   0x28d95a3f8b6  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a3f8bd  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a3f8c5  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a3f8d4  ((? add 0xffffffffffffffb0) add 0x20) <- this
    // returns: get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
}
