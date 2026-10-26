// ============================================================
// token 0x06001657   099C214D55A84477::.ctor
// native code: 0x28d959ef530  (313 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed noinlining
//   
// native-calls: 06001942,06001943,06000007,06001940
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d959ef580  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffd0), 0x221349bf)
    //   0x28d959ef608  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffd0), 0x4, 0x9c0648f)
    //   0x28d959ef620  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffd0), 0x4, 0x9c0648f) xor 0x5191fbb8))
    //   0x28d959ef638  652C34B1E6554F10::.ctor(this)
    // 1 store(s):
    //   0x28d959ef623  this <- <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffd0), 0x4, 0x9c0648f) xor 0x5191fbb8))
    // returns: ((((((0x172e6447 neg 0x1) add 0x162110f08f61919) imul 0xe7e2fc89) neg 0x1) neg 0x1) imul 0xfed686c2)
}
