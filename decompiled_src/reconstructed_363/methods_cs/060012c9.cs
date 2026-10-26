// ============================================================
// token 0x060012c9   635EDF414A0B480B::91EA18E0A4CE4C82
// native code: 0x28d95a06790  (181 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   uint8[] '91EA18E0A4CE4C82' (
//   uint8[] '',
//   uint8[] ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000007,060012d9
// native-strings: 
// ============================================================

public static byte 91EA18E0A4CE4C82(byte arg0, byte arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a067e0  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffe8), 0xffffffffea2616bc)
    //   0x28d95a06800  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), 0x8, 0x5bffa94c)
    //   0x28d95a06818  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), 0x8, 0x5bffa94c) xor 0x666af87a))
    //   0x28d95a06838  635EDF414A0B480B::46A7056FF6104E82(arg0, <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), 0x8, 0x5bffa94c) xor 0x666af87a)), (movsxd arg0.f18), arg1)
    // returns: 635EDF414A0B480B::46A7056FF6104E82(arg0, <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), 0x8, 0x5bffa94c) xor 0x666af87a)), (movsxd arg0.f18), arg1)
}
