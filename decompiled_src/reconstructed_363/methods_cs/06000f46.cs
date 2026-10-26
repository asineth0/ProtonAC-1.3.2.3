// ============================================================
// token 0x06000f46   2C17228CC29D4798::9522A597174F41D2
// native code: 0x28d95a19560  (305 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public final hidebysig newslot virtual
//   instance class [netstandard]System.Threading.Tasks.Task '9522A597174F41D2' (
//   class '02C54685DE0E4B81' '',
//   class '7C3933FE2CD94926' '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06000006
// native-strings: 
// ============================================================

public  Task 9522A597174F41D2(02C54685DE0E4B81 arg0, 7C3933FE2CD94926 arg1, valuetype Threading.CancellationToken arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 6 call(s):
    //   0x28d95a195a0  memset((? add 0xffffffffffffff80), (arg0 xor arg0), 0x58, arg2)
    //   0x28d95a195f0  WBARRIER(((? add 0xffffffffffffff80) add 0x28), (arg0 xor arg0))
    //   0x28d95a19610  WBARRIER(((? add 0xffffffffffffff80) add 0x20), (arg0 xor arg0))
    //   0x28d95a19640  <Module>::58ECCB512F2A43AC(0xfffffffff9446e57)   ; =-1
    //   0x28d95a19668  Start(((? add 0xffffffffffffff80) add 0x8), (? add 0xffffffffffffff80), 0x58, arg2)
    //   0x28d95a19680  get_Task(((? add 0xffffffffffffff80) add 0x8), (? add 0xffffffffffffff80), 0x58, arg2)
    // 6 store(s):
    //   0x28d95a195c0  ((? add 0xffffffffffffff80) add 0x8) <- ((? add 0xffffffffffffff80) xor (? add 0xffffffffffffff80))
    //   0x28d95a195c7  ((? add 0xffffffffffffff80) add 0x8) <- ((? add 0xffffffffffffff80) xor (? add 0xffffffffffffff80))
    //   0x28d95a195cf  ((? add 0xffffffffffffff80) add 0x8) <- ((? add 0xffffffffffffff80) xor (? add 0xffffffffffffff80))
    //   0x28d95a195de  ((? add 0xffffffffffffff80) add 0x28) <- arg0
    //   0x28d95a195fe  ((? add 0xffffffffffffff80) add 0x20) <- arg1
    //   0x28d95a19625  ((? add 0xffffffffffffff80) add 0x30) <- arg2
    // returns: get_Task(((? add 0xffffffffffffff80) add 0x8), (? add 0xffffffffffffff80), 0x58, arg2)
}
