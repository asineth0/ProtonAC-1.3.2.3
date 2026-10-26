// ============================================================
// token 0x06001332   EB69693599F64B76::67745766D2374CD1
// native code: 0x28d959e5ca0  (174 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname
//   instance bool '67745766D2374CD1' () cil managed noinlining
//   
// native-calls: 06001942,06001943,06000003
// native-strings: 
// ============================================================

 bool 67745766D2374CD1()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 3 call(s):
    //   0x28d959e5ce8  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffe8), 0x3ea47d2c)
    //   0x28d959e5d18  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), 0x9, 0xffffffffc903270b)
    //   0x28d959e5d30  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), 0x9, 0xffffffffc903270b) xor 0x67f7061))
    // returns: (movzx (movsxd this.f38.f18))
}
