// ============================================================
// token 0x0600043c   C4462CD02B8C4225::8112AE6BB2924ED0
// native code: 0x28d97012fe0  (253 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '8112AE6BB2924ED0' (
//   valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

 Task 8112AE6BB2924ED0(Threading.CancellationToken arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d97013018  memset((? add 0xffffffffffffff58), (arg0 xor arg0), 0x88, ?)
    //   0x28d97013068  WBARRIER(((? add 0xffffffffffffff58) add 0x28), (arg0 xor arg0))
    //   0x28d970130b0  Start(((? add 0xffffffffffffff58) add 0x8), (? add 0xffffffffffffff58), 0x88, ?)
    //   0x28d970130d0  get_Task(((? add 0xffffffffffffff58) add 0x8), (? add 0xffffffffffffff58), 0x88, ?)
    // 5 store(s):
    //   0x28d9701303a  ((? add 0xffffffffffffff58) add 0x8) <- ((? add 0xffffffffffffff58) xor (? add 0xffffffffffffff58))
    //   0x28d97013041  ((? add 0xffffffffffffff58) add 0x8) <- ((? add 0xffffffffffffff58) xor (? add 0xffffffffffffff58))
    //   0x28d97013049  ((? add 0xffffffffffffff58) add 0x8) <- ((? add 0xffffffffffffff58) xor (? add 0xffffffffffffff58))
    //   0x28d9701305b  ((? add 0xffffffffffffff58) add 0x28) <- this
    //   0x28d9701307f  ((? add 0xffffffffffffff58) add 0x20) <- arg0
    // returns: get_Task(((? add 0xffffffffffffff58) add 0x8), (? add 0xffffffffffffff58), 0x88, ?)
}
