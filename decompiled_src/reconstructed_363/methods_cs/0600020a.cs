// ============================================================
// token 0x0600020a   EE0FD11A7E47463C::.cctor
// native code: 0x28d970342f0  (134 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed noinlining
//   
// native-calls: 06000007,06000006
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d97034308  <Module>::3F57E81A62734AC2(0x3fb15a6d)   ; =0
    //   0x28d97034318  FromSeconds(0x3fb15a6d, ?, ?, ?)
    //   0x28d97034348  <Module>::58ECCB512F2A43AC(0xffffffffc2dd252b)   ; =0
    //   0x28d97034358  FromMilliseconds(0xffffffffc2dd252b, ?, ?, ?)
    // 2 store(s):
    //   0x28d9703432d  0x28cca2db050 <- FromSeconds(0x3fb15a6d, ?, ?, ?)
    //   0x28d9703436d  0x28cca2db058 <- FromMilliseconds(0xffffffffc2dd252b, ?, ?, ?)
    // returns: 0x28cca2db058
}
