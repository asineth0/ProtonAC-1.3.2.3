// ============================================================
// token 0x06000e6c   02C54685DE0E4B81::596C5A2B9AB24C48
// native code: 0x28d958dd640  (385 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '596C5A2B9AB24C48' () cil managed noinlining
//   
// native-calls: 06000005
// native-strings: 
// ============================================================

 Task 596C5A2B9AB24C48()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958dd740  WBARRIER(((? add 0xffffffffffffffa0) add 0x20), ((((((((((0xffffffffa8848da3 not 0x1) sub 0xf3f6c55b059a3baf) imul 0x5746e705) imul 0xc03a2f) xor 0x893d6e27) imul 0xec7e3a1d) neg 0x1) imul 0xaf40d3bf) div 0x3) mod 0x3))
    //   0x28d958dd758  <Module>::F84FA79ABE6944BB(0x55eec410)   ; =-1
    //   0x28d958dd780  Start(((? add 0xffffffffffffffa0) add 0x8), (? add 0xffffffffffffffa0), ?, ?)
    //   0x28d958dd7a8  get_Task(((? add 0xffffffffffffffa0) add 0x8), (? add 0xffffffffffffffa0), ?, ?)
    // 4 store(s):
    //   0x28d958dd691  ((? add 0xffffffffffffffa0) add 0x8) <- (this xor this)
    //   0x28d958dd698  ((? add 0xffffffffffffffa0) add 0x8) <- (this xor this)
    //   0x28d958dd6a0  ((? add 0xffffffffffffffa0) add 0x8) <- (this xor this)
    //   0x28d958dd72f  ((? add 0xffffffffffffffa0) add 0x20) <- this
    // returns: get_Task(((? add 0xffffffffffffffa0) add 0x8), (? add 0xffffffffffffffa0), ?, ?)
}
