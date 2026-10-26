// ============================================================
// token 0x06000e6b   02C54685DE0E4B81::44AD45EE94144118
// native code: 0x28d958df5a0  (325 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '44AD45EE94144118' () cil managed noinlining
//   
// native-calls: 06000003
// native-strings: 
// ============================================================

 Task 44AD45EE94144118()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d958df670  <Module>::8B9C7B12B1AE4949(0xffffffffb56a1fe0)   ; =-1
    //   0x28d958df6a0  Start(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    //   0x28d958df6d0  get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    // 3 store(s):
    //   0x28d958df5e6  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d958df5ed  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d958df5f5  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    // returns: get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
}
