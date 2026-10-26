// ============================================================
// token 0x06001432   0E002E61EDA64248::459859367B31489C
// native code: 0x28d958d9cc0  (987 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   string '459859367B31489C' (
//   int32 ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000003,06000007,0600143d,0600143e,0600143f,06000005,06001437
// native-strings: 
// ============================================================

public static string 459859367B31489C(int arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 20 call(s):
    //   0x28d958d9d20  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffc0), 0xffffffffdcb75713)
    //   0x28d958d9d40  ALLOC_ARRAY(0x28c85178270, arg0)
    //   0x28d958d9d68  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0xa, 0xffffffffab97f654)
    //   0x28d958d9d88  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0x9, 0x7aeaee55)
    //   0x28d958d9da8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), (0x9 xor 0x9), 0x3604b2f6)
    //   0x28d958d9dd0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0xb, 0xffffffffa37b712e)
    //   0x28d958d9de8  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0xb, 0xffffffffa37b712e) xor 0x8f14e2aa))
    //   0x28d958d9eb0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0x1, 0xffffffffadff91c0)
    //   0x28d958d9ed0  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0x1, 0xffffffffadff91c0) xor 0x4515f37c))
    //   0x28d958d9ef8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0xa, 0x5acba8a2)
    //   0x28d958d9f18  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0xa, 0x5acba8a2) xor 0x379f889e))
    //   0x28d958d9f28  0E002E61EDA64248::7DC3097357444095(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0xa, 0x5acba8a2) xor 0x379f889e)))
    //   0x28d958d9f48  0E002E61EDA64248::08E65A4FF41045F6(0x28d0cbfd2a0, 0E002E61EDA64248::7DC3097357444095(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0xa, 0x5acba8a2) xor 0x379f889e))))
    //   0x28d958d9f60  0E002E61EDA64248::8F20DEC2C3E04E0F(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0x1, 0xffffffffadff91c0) xor 0x4515f37c)), 0E002E61EDA64248::08E65A4FF41045F6(0x28d0cbfd2a0, 0
    //   0x28d958d9fa0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0x1, 0xffffffffb27f9643)
    //   0x28d958d9fb8  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0x1, 0xffffffffb27f9643) xor 0x42974d21))
    //   0x28d958da020  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffc0), 0xffffffffe60974e5)
    //   0x28d958da050  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0xa, 0x618cdf49)
    //   0x28d958da060  0E002E61EDA64248::79236636998E4A93(ALLOC_ARRAY(0x28c85178270, arg0))
    //   0x28d958da098  THROW(0x146, 0x12e)
    // 1 store(s):
    //   0x28d958d9f78  ALLOC_ARRAY(0x28c85178270, arg0)+(movsxd <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0xb, 0xffffffffa37b712e) xor 0x8f14e2aa)))*2+20 <- 0E002E61EDA64248::8F20DEC2C3E04E0F(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0x1, 0xffffffffadff91c0) xor 0x451
    // returns: 0E002E61EDA64248::79236636998E4A93(ALLOC_ARRAY(0x28c85178270, arg0))
}
