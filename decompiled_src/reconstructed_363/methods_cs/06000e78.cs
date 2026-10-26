// ============================================================
// token 0x06000e78   02C54685DE0E4B81::7B3F63781CFF4AAD
// native code: 0x28d95a02200  (221 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '7B3F63781CFF4AAD' () cil managed noinlining
//   
// native-calls: 06000003
// native-strings: 
// ============================================================

public  Task 7B3F63781CFF4AAD()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a02278  WBARRIER(((? add 0xffffffffffffffb0) add 0x20), ?)
    //   0x28d95a02290  <Module>::8B9C7B12B1AE4949(0xffffffffb56a1fe0)   ; =-1
    //   0x28d95a022b8  Start(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    //   0x28d95a022d0  get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    // 4 store(s):
    //   0x28d95a02246  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a0224d  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a02255  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a02264  ((? add 0xffffffffffffffb0) add 0x20) <- this
    // returns: get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
}
