// ============================================================
// token 0x06000e76   02C54685DE0E4B81::A1DECD4C16994BD0
// native code: 0x28d957e1130  (469 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task A1DECD4C16994BD0 (
//   valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06000006
// native-strings: 
// ============================================================

 Task A1DECD4C16994BD0(Threading.CancellationToken arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d957e1170  memset((? add 0xffffffffffffff70), (arg0 xor arg0), 0x60, ?)
    //   0x28d957e11c0  WBARRIER(((? add 0xffffffffffffff70) add 0x20), (arg0 xor arg0))
    //   0x28d957e1290  <Module>::58ECCB512F2A43AC(0xfffffffff9446e57)   ; =-1
    //   0x28d957e12d0  Start(((? add 0xffffffffffffff70) add 0x8), (? add 0xffffffffffffff70), 0x60, ?)
    //   0x28d957e12f0  get_Task(((? add 0xffffffffffffff70) add 0x8), (? add 0xffffffffffffff70), 0x60, ?)
    // 5 store(s):
    //   0x28d957e1192  ((? add 0xffffffffffffff70) add 0x8) <- ((? add 0xffffffffffffff70) xor (? add 0xffffffffffffff70))
    //   0x28d957e1199  ((? add 0xffffffffffffff70) add 0x8) <- ((? add 0xffffffffffffff70) xor (? add 0xffffffffffffff70))
    //   0x28d957e11a1  ((? add 0xffffffffffffff70) add 0x8) <- ((? add 0xffffffffffffff70) xor (? add 0xffffffffffffff70))
    //   0x28d957e11b3  ((? add 0xffffffffffffff70) add 0x20) <- this
    //   0x28d957e125c  ((? add 0xffffffffffffff70) add 0x28) <- arg0
    // returns: get_Task(((? add 0xffffffffffffff70) add 0x8), (? add 0xffffffffffffff70), 0x60, ?)
}
