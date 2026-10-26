// ============================================================
// token 0x0600193d   652C34B1E6554F10::8F8B2E1FCFAF48EB
// native code: 0x28d95a1ae50  (190 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname
//   instance bool '8F8B2E1FCFAF48EB' () cil managed noinlining
//   
// native-calls: 06001942,06001941,06001943,06000006
// native-strings: 
// ============================================================

public  bool 8F8B2E1FCFAF48EB()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a1ae98  81DD83B8AA2247AA::.ctor((? add 0xfffffffffffffff0), 0xffffffffb186aa7b)
    //   0x28d95a1aeb0  652C34B1E6554F10::6002889CC5D04ED9(this)
    //   0x28d95a1aed8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffff0), 0xa, 0x30f157cc)
    //   0x28d95a1aef0  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffffffff0), 0xa, 0x30f157cc) xor 0x1d152f2b))
    // returns: (movzx 652C34B1E6554F10::6002889CC5D04ED9(this))
}
