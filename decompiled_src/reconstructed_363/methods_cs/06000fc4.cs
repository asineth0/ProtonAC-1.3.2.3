// ============================================================
// token 0x06000fc4   461303B1053C4226::0FD0A40473244371
// native code: 0x28d95a11400  (221 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public final hidebysig newslot virtual
//   instance class [netstandard]System.Threading.Tasks.Task '0FD0A40473244371' (
//   class '02C54685DE0E4B81' '',
//   class '9E7CD8E645DD49BC' '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06000005
// native-strings: 
// ============================================================

public  Task 0FD0A40473244371(02C54685DE0E4B81 arg0, 9E7CD8E645DD49BC arg1, valuetype Threading.CancellationToken arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a11478  WBARRIER(((? add 0xffffffffffffffb0) add 0x20), arg0)
    //   0x28d95a11490  <Module>::F84FA79ABE6944BB(0x55eec410)   ; =-1
    //   0x28d95a114b8  Start(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), arg1, arg2)
    //   0x28d95a114d0  get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), arg1, arg2)
    // 4 store(s):
    //   0x28d95a11449  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a11450  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a11458  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d95a11467  ((? add 0xffffffffffffffb0) add 0x20) <- arg1
    // returns: get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), arg1, arg2)
}
