// ============================================================
// token 0x0600154a   0EBA44DDBA854271::4B1030A59ED9498A
// native code: 0x28d95a05130  (217 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '4B1030A59ED9498A' (
//   class [netstandard]System.IO.BinaryWriter ''
//   ) cil managed
//   
// native-calls: 0600154f,06001550,06001551,06001552,06001553
// native-strings: 
// ============================================================

public  void 4B1030A59ED9498A(BinaryWriter arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 7 call(s):
    //   0x28d95a05170  0EBA44DDBA854271::715C14C34FA14587(this)
    //   0x28d95a05188  0EBA44DDBA854271::4221603AF2DA47E4(arg0, 0EBA44DDBA854271::715C14C34FA14587(this))
    //   0x28d95a051a0  0EBA44DDBA854271::72CBAE14E2A14FFC(this)
    //   0x28d95a051b8  ToString((? add 0xffffffffffffffe0), (? add 0xffffffffffffffe0), ?, ?)
    //   0x28d95a051d0  0EBA44DDBA854271::4221603AF2DA47E4(arg0, ToString((? add 0xffffffffffffffe0), (? add 0xffffffffffffffe0), ?, ?))
    //   0x28d95a051e0  0EBA44DDBA854271::0C31D839E6364B1C(this)
    //   0x28d95a051f8  0EBA44DDBA854271::ABA0B0C23C714049(arg0, 0EBA44DDBA854271::0C31D839E6364B1C(this))
    // returns: 0EBA44DDBA854271::ABA0B0C23C714049(arg0, 0EBA44DDBA854271::0C31D839E6364B1C(this))
}
