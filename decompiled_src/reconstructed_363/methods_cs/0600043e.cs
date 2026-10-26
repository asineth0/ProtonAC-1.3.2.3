// ============================================================
// token 0x0600043e   C4462CD02B8C4225::5F4A801667FE45CC
// native code: 0x28d97016a80  (197 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '5F4A801667FE45CC' () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

 Task 5F4A801667FE45CC()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d97016af8  WBARRIER(((? add 0xffffffffffffffb0) add 0x20), ?)
    //   0x28d97016b20  Start(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    //   0x28d97016b38  get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
    // 4 store(s):
    //   0x28d97016ac6  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d97016acd  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d97016ad5  ((? add 0xffffffffffffffb0) add 0x8) <- (this xor this)
    //   0x28d97016ae4  ((? add 0xffffffffffffffb0) add 0x20) <- this
    // returns: get_Task(((? add 0xffffffffffffffb0) add 0x8), (? add 0xffffffffffffffb0), ?, ?)
}
