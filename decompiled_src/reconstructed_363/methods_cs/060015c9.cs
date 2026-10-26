// ============================================================
// token 0x060015c9   F3E4AB234A904B5E::0E4F037D91B64E97
// native code: 0x28d95a0bf10  (209 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '0E4F037D91B64E97' (
//   class [netstandard]System.IO.BinaryReader ''
//   ) cil managed
//   
// native-calls: 060015d2,060015ca,060015cb,060015d3,060015cc
// native-strings: 
// ============================================================

public  void 0E4F037D91B64E97(BinaryReader arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 7 call(s):
    //   0x28d95a0bf38  F3E4AB234A904B5E::FE7C6D65E6F74C62(arg0)
    //   0x28d95a0bf50  Parse(F3E4AB234A904B5E::FE7C6D65E6F74C62(arg0), (? add 0xffffffffffffffd0), ?, ?)
    //   0x28d95a0bf80  F3E4AB234A904B5E::84107EBEF79B453A(this, (? add 0xffffffffffffffe0))
    //   0x28d95a0bf90  F3E4AB234A904B5E::FE7C6D65E6F74C62(arg0)
    //   0x28d95a0bfa8  F3E4AB234A904B5E::EEB94D1F8E714634(this, F3E4AB234A904B5E::FE7C6D65E6F74C62(arg0))
    //   0x28d95a0bfb8  F3E4AB234A904B5E::8DC26180EB194243(arg0)
    //   0x28d95a0bfd0  F3E4AB234A904B5E::B841EF3E0C624FAB(this, F3E4AB234A904B5E::8DC26180EB194243(arg0))
    // returns: F3E4AB234A904B5E::B841EF3E0C624FAB(this, F3E4AB234A904B5E::8DC26180EB194243(arg0))
}
