// ============================================================
// token 0x06000f9c   B7BD4E0782844B6C::DF7DD2D31F8D4DB0
// native code: 0x28d95a08010  (465 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public final hidebysig newslot virtual
//   instance class [netstandard]System.Threading.Tasks.Task DF7DD2D31F8D4DB0 (
//   class '02C54685DE0E4B81' '',
//   class FBFDE69E8DC9496E '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06000007
// native-strings: 
// ============================================================

public  Task DF7DD2D31F8D4DB0(02C54685DE0E4B81 arg0, FBFDE69E8DC9496E arg1, valuetype Threading.CancellationToken arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d95a080a8  WBARRIER(((? add 0xffffffffffffff88) add 0x28), arg0)
    //   0x28d95a080c8  WBARRIER(((? add 0xffffffffffffff88) add 0x20), arg0)
    //   0x28d95a08168  <Module>::3F57E81A62734AC2(0x16aa9e93)   ; =-1
    //   0x28d95a08198  Start(((? add 0xffffffffffffff88) add 0x8), (? add 0xffffffffffffff88), arg1, arg2)
    //   0x28d95a081c8  get_Task(((? add 0xffffffffffffff88) add 0x8), (? add 0xffffffffffffff88), arg1, arg2)
    // 6 store(s):
    //   0x28d95a08077  ((? add 0xffffffffffffff88) add 0x8) <- (this xor this)
    //   0x28d95a0807e  ((? add 0xffffffffffffff88) add 0x8) <- (this xor this)
    //   0x28d95a08086  ((? add 0xffffffffffffff88) add 0x8) <- (this xor this)
    //   0x28d95a08095  ((? add 0xffffffffffffff88) add 0x28) <- arg0
    //   0x28d95a080b6  ((? add 0xffffffffffffff88) add 0x20) <- arg1
    //   0x28d95a08140  ((? add 0xffffffffffffff88) add 0x30) <- arg2
    // returns: get_Task(((? add 0xffffffffffffff88) add 0x8), (? add 0xffffffffffffff88), arg1, arg2)
}
