// ============================================================
// token 0x06001333   EB69693599F64B76::91400173B6374192
// native code: 0x28d959e5b60  (182 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname
//   instance bool '91400173B6374192' () cil managed noinlining
//   
// native-calls: 06001942,0600134d,06001943,06000004
// native-strings: 
// ============================================================

public  bool 91400173B6374192()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d959e5ba8  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffe8), 0xffffffff97b47140)
    //   0x28d959e5bc0  EB69693599F64B76::CBBE600BD0E643BD(this.f10)
    //   0x28d959e5be0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), (0xffffffff97b47140 xor 0xffffffff97b47140), 0x63114fad)
    //   0x28d959e5bf8  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), (0xffffffff97b47140 xor 0xffffffff97b47140), 0x63114fad) xor 0x144dfd6d))
    // returns: (movzx EB69693599F64B76::CBBE600BD0E643BD(this.f10))
}
