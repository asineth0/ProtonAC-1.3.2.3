// ============================================================
// token 0x06001573   9EB5A4DBDFA4443A::018724327D4C4824
// native code: 0x28d95a00d60  (529 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '018724327D4C4824' (
//   class [netstandard]System.IO.BinaryReader ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001578,06001943,06000005,06001574,06001579
// native-strings: 
// ============================================================

public  void 018724327D4C4824(BinaryReader arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 9 call(s):
    //   0x28d95a00db8  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffc0), 0xffffffff85bd3ff2)
    //   0x28d95a00e38  9EB5A4DBDFA4443A::1E81047E99BD4EDD(arg0)
    //   0x28d95a00e68  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0x5, 0xffffffffa2b90e83)
    //   0x28d95a00e80  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffc0), 0x5, 0xffffffffa2b90e83) xor 0xb9e29351))
    //   0x28d95a00ee0  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffc0), 0xffffffffb84921d4, 0xffffffffa2b90e83, ?)
    //   0x28d95a00f00  9EB5A4DBDFA4443A::F78925A7C8D042D3(this, 0x28c84118800, 0xffffffffa2b90e83, ?)
    //   0x28d95a00f20  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffc0), 0x7c46a84a)
    //   0x28d95a00f38  9EB5A4DBDFA4443A::1DDD03DAC9404604(arg0, 9EB5A4DBDFA4443A::1E81047E99BD4EDD(arg0))
    //   0x28d95a00f50  9EB5A4DBDFA4443A::F78925A7C8D042D3(this, 9EB5A4DBDFA4443A::1DDD03DAC9404604(arg0, 9EB5A4DBDFA4443A::1E81047E99BD4EDD(arg0)))
    // returns: 9EB5A4DBDFA4443A::F78925A7C8D042D3(this, 9EB5A4DBDFA4443A::1DDD03DAC9404604(arg0, 9EB5A4DBDFA4443A::1E81047E99BD4EDD(arg0)))
}
