// ============================================================
// token 0x0600085d   7FE330C6E84D4C74::.ctor
// native code: 0x28d970d2fa0  (685 bytes)
// kind: SMALL_CALL   confidence: behavior
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
    // 21 call(s):
    //   0x28d970d2fc8  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970d3000  631D551E2DA64E7D::F3B62BCE1450413B((760EF57D5259421C::EBDC6C691E8048F7().f68 xor 760EF57D5259421C::EBDC6C691E8048F7().f68))
    //   0x28d970d3018  WBARRIER(this+10, ?)
    //   0x28d970d3028  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970d3060  631D551E2DA64E7D::F3B62BCE1450413B((760EF57D5259421C::EBDC6C691E8048F7().f68 xor 760EF57D5259421C::EBDC6C691E8048F7().f68))
    //   0x28d970d3080  WBARRIER(this+18, ?)
    //   0x28d970d3098  ALLOC_OBJECT(0x28d9665ca60)
    //   0x28d970d30b0  .ctor(ALLOC_OBJECT(0x28d9665ca60), ?, ?, ?)
    //   0x28d970d30d0  WBARRIER(this+20, ?)
    //   0x28d970d30f0  sub_28d95868d30(0x28d0d966cb0, 0x60c, ?, ?)
    //   0x28d970d3108  WBARRIER(this+28, 0x60c)
    //   0x28d970d3128  sub_28d95868d30(0x28d0d966cb0, 0x60c, ?, ?)
    //   0x28d970d3140  WBARRIER(this+30, 0x60c)
    //   0x28d970d3160  sub_28d95868d30(0x28d0d966cb0, 0x60c, ?, ?)
    //   0x28d970d3178  WBARRIER(this+38, 0x60c)
    //   0x28d970d3198  sub_28d95868d30(0x28d0d966cb0, 0x60c, ?, ?)
    //   0x28d970d31b0  WBARRIER(this+40, 0x60c)
    //   0x28d970d31d0  ALLOC_OBJECT(0x28c86b41b40)
    //   0x28d970d3200  WBARRIER((ALLOC_OBJECT(0x28c86b41b40) add 0x10), 0x60c)
    //   0x28d970d3220  WBARRIER(this+48, 0x60c)
    //   0x28d970d3238  760EF57D5259421C::.ctor(this)
    // 9 store(s):
    //   0x28d970d300a  this+10 <- 631D551E2DA64E7D::F3B62BCE1450413B((760EF57D5259421C::EBDC6C691E8048F7().f68 xor 760EF57D5259421C::EBDC6C691E8048F7().f68))
    //   0x28d970d306c  this+18 <- 631D551E2DA64E7D::F3B62BCE1450413B((760EF57D5259421C::EBDC6C691E8048F7().f68 xor 760EF57D5259421C::EBDC6C691E8048F7().f68))
    //   0x28d970d30bf  this+20 <- ALLOC_OBJECT(0x28d9665ca60)
    //   0x28d970d30fb  this+28 <- sub_28d95868d30(0x28d0d966cb0, 0x60c, ?, ?)
    //   0x28d970d3133  this+30 <- sub_28d95868d30(0x28d0d966cb0, 0x60c, ?, ?)
    //   0x28d970d316b  this+38 <- sub_28d95868d30(0x28d0d966cb0, 0x60c, ?, ?)
    //   0x28d970d31a3  this+40 <- sub_28d95868d30(0x28d0d966cb0, 0x60c, ?, ?)
    //   0x28d970d31ec  (ALLOC_OBJECT(0x28c86b41b40) add 0x10) <- 0x28cc75df3c0
    //   0x28d970d3213  this+48 <- ALLOC_OBJECT(0x28c86b41b40)
    // returns: 760EF57D5259421C::.ctor(this)
}
