// ============================================================
// token 0x060006af   C6338AE87AE0450D::.ctor
// native code: 0x28d970df8e0  (165 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 0600105e,06000131,0600106b
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d970df908  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970df940  631D551E2DA64E7D::F3B62BCE1450413B((760EF57D5259421C::EBDC6C691E8048F7().f68 xor 760EF57D5259421C::EBDC6C691E8048F7().f68))
    //   0x28d970df960  WBARRIER(this+10, ?)
    //   0x28d970df970  760EF57D5259421C::.ctor(this)
    // 1 store(s):
    //   0x28d970df94c  this+10 <- 631D551E2DA64E7D::F3B62BCE1450413B((760EF57D5259421C::EBDC6C691E8048F7().f68 xor 760EF57D5259421C::EBDC6C691E8048F7().f68))
    // returns: 760EF57D5259421C::.ctor(this)
}
