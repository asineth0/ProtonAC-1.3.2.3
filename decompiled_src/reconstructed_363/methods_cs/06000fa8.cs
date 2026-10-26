// ============================================================
// token 0x06000fa8   B59CC8BC30E040CA::B1EA6B83E25B4D8E
// native code: 0x28d95a0c3c0  (273 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public final hidebysig newslot virtual
//   instance class [netstandard]System.Threading.Tasks.Task B1EA6B83E25B4D8E (
//   class '02C54685DE0E4B81' '',
//   class F3E4AB234A904B5E '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06000004
// native-strings: 
// ============================================================

public  Task B1EA6B83E25B4D8E(02C54685DE0E4B81 arg0, F3E4AB234A904B5E arg1, valuetype Threading.CancellationToken arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d95a0c448  WBARRIER(((? add 0xffffffffffffff98) add 0x20), arg0)
    //   0x28d95a0c468  WBARRIER(((? add 0xffffffffffffff98) add 0x28), arg0)
    //   0x28d95a0c480  <Module>::390073C602714496(0xffffffffd413acc0)   ; =-1
    //   0x28d95a0c4a8  Start(((? add 0xffffffffffffff98) add 0x8), (? add 0xffffffffffffff98), arg1, arg2)
    //   0x28d95a0c4c0  get_Task(((? add 0xffffffffffffff98) add 0x8), (? add 0xffffffffffffff98), arg1, arg2)
    // 5 store(s):
    //   0x28d95a0c418  ((? add 0xffffffffffffff98) add 0x8) <- (this xor this)
    //   0x28d95a0c41f  ((? add 0xffffffffffffff98) add 0x8) <- (this xor this)
    //   0x28d95a0c427  ((? add 0xffffffffffffff98) add 0x8) <- (this xor this)
    //   0x28d95a0c436  ((? add 0xffffffffffffff98) add 0x20) <- arg0
    //   0x28d95a0c456  ((? add 0xffffffffffffff98) add 0x28) <- arg1
    // returns: get_Task(((? add 0xffffffffffffff98) add 0x8), (? add 0xffffffffffffff98), arg1, arg2)
}
