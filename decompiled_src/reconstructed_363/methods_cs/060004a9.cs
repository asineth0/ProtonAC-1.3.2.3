// ============================================================
// token 0x060004a9   9B508551BC7E4B5E::.ctor
// native code: 0x28d95a3f720  (163 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 060004aa,060004ab,06001086
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d95a3f740  9B508551BC7E4B5E::B4EA45A651CB495C()
    //   0x28d95a3f750  9B508551BC7E4B5E::D5DC7B5ECC744289(9B508551BC7E4B5E::B4EA45A651CB495C())
    //   0x28d95a3f780  WBARRIER(this+10, 9B508551BC7E4B5E::D5DC7B5ECC744289(9B508551BC7E4B5E::B4EA45A651CB495C()))
    //   0x28d95a3f798  C179263454B44BF6::.ctor(this)
    //   0x28d95a3f7c0  THROW(0x162, 0x69)
    // 1 store(s):
    //   0x28d95a3f76f  this+10 <- 9B508551BC7E4B5E::D5DC7B5ECC744289(9B508551BC7E4B5E::B4EA45A651CB495C())
    // returns: C179263454B44BF6::.ctor(this)
}
