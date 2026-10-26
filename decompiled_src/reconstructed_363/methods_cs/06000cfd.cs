// ============================================================
// token 0x06000cfd   85399D7C08B94D76::66692E0EB4194A0C
// native code: 0x28d958345b0  (344 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class '85399D7C08B94D76' '66692E0EB4194A0C' (
//   string ''
//   ) cil managed noinlining
//   
// native-calls: 06000d00,06000007,06000006,06000d01
// native-strings: 
// ============================================================

public  85399D7C08B94D76 66692E0EB4194A0C(string arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 6 call(s):
    //   0x28d958345e0  85399D7C08B94D76::D90EE4645F0A48D6(arg0)
    //   0x28d95834680  <Module>::3F57E81A62734AC2(0x2a206f6, ((((((0xd4ea47d sub ((((0x58f6e408 xor 0x98be3c9e1f4248a5) neg 0x1) neg 0x1) xor 0x94334040efc7a03a)) neg 0x1) sub 0xa639a003) not 0x1) div 0x3) mod 0x3), ?, ?)
    //   0x28d958346a0  <Module>::58ECCB512F2A43AC(0x1e246f78, ((((((0xd4ea47d sub ((((0x58f6e408 xor 0x98be3c9e1f4248a5) neg 0x1) neg 0x1) xor 0x94334040efc7a03a)) neg 0x1) sub 0xa639a003) not 0x1) div 0x3) mod 0x3), ?, ?)
    //   0x28d958346b8  85399D7C08B94D76::6F7AEB8047BD46A1(<Module>::3F57E81A62734AC2(0x2a206f6, ((((((0xd4ea47d sub ((((0x58f6e408 xor 0x98be3c9e1f4248a5) neg 0x1) neg 0x1) xor 0x94334040efc7a03a)) neg 0x1) sub 0xa639a003) not 0x1) div 0x3) mo
    //   0x28d958346c8  ?(85399D7C08B94D76::6F7AEB8047BD46A1(<Module>::3F57E81A62734AC2(0x2a206f6, ((((((0xd4ea47d sub ((((0x58f6e408 xor 0x98be3c9e1f4248a5) neg 0x1) neg 0x1) xor 0x94334040efc7a03a)) neg 0x1) sub 0xa639a003) not 0x1) div 0x3) 
    //   0x28d958346e8  WBARRIER(this+10, <Module>::58ECCB512F2A43AC(0x1e246f78, ((((((0xd4ea47d sub ((((0x58f6e408 xor 0x98be3c9e1f4248a5) neg 0x1) neg 0x1) xor 0x94334040efc7a03a)) neg 0x1) sub 0xa639a003) not 0x1) div 0x3) mod 0x3), ?, ?))
    // 1 store(s):
    //   0x28d958346d4  this+10 <- arg0
    // returns: this
}
