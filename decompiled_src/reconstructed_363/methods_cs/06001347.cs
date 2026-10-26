// ============================================================
// token 0x06001347   EB69693599F64B76::2EBCEBB349FB4F43
// native code: 0x28d958de400  (1915 bytes)
// kind: LOOP   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance void '2EBCEBB349FB4F43' () cil managed noinlining
//   
// native-calls: 06001942,06001943
// native-strings: 
// ============================================================

 void 2EBCEBB349FB4F43()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 9 call(s):
    //   0x28d958de468  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0xacbef4d)
    //   0x28d958de660  get_Values(this.f50, ((((((0xffffffffb2a6f6a7 sub ((((movsxd (movsxd 0xd7a422bd)) sub 0xa71fd3b0244e36d3) xor 0x5935979e07dd0200) xor 0x1f8bb7dc26c3437)) neg 0x1) sub 0xe590657cfd411149) imul 0x6a60f4c1) div 0x5) mod 0x5
    //   0x28d958de698  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0xffffffffb29432d5)
    //   0x28d958de8a0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x5, 0xfffffffff7a73c10)
    //   0x28d958de8c8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), (0x5 xor 0x5), 0x3c8002db)
    //   0x28d958de8d7  sub_28d958de900((? add 0xffffffffffffffb8), (0x5 xor 0x5), 0x3c8002db, ?)
    //   0x28d958de8f8  sub_28b82785f1f((? add 0xffffffffffffffb8), (0x5 xor 0x5), 0x3c8002db, ?)
    //   0x28d958deb30  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x2, 0x7261b12)
    //   0x28d958deb48  Clear(this.f50, 0x2, 0x7261b12, ?)
    // 1 store(s):
    //   0x28d958de63e  this <- 0x0
    // returns: Clear(this.f50, 0x2, 0x7261b12, ?)
}
