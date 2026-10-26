// ============================================================
// token 0x06000791   3D705F3CBB924411::7D85D260200A4054
// native code: 0x28d970e06d0  (1468 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void '7D85D260200A4054' () cil managed
//   
// native-calls: 06001068
// native-strings: 
// ============================================================

public  void 7D85D260200A4054()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 25 call(s):
    //   0x28d970e0720  ALLOC_OBJECT(0x28ccd1bb3e0)
    //   0x28d970e0748  WBARRIER((ALLOC_OBJECT(0x28ccd1bb3e0) add 0x20), ?)
    //   0x28d970e0798  Combine(0x28cc768ccb8.f0, ALLOC_OBJECT(0x28ccd1bb3e0), 0x28d96756ce8.f28, ?)
    //   0x28d970e07e8  WBARRIER(0x28cc768ccb8, ALLOC_OBJECT(0x28ccd1bb3e0))
    //   0x28d970e0820  ALLOC_OBJECT(0x28d96756dd8)
    //   0x28d970e0848  WBARRIER((ALLOC_OBJECT(0x28d96756dd8) add 0x20), ALLOC_OBJECT(0x28ccd1bb3e0))
    //   0x28d970e0898  Combine(0x28cc768cdf8.f0, ALLOC_OBJECT(0x28d96756dd8), 0x28d96756ea8.f28, ?)
    //   0x28d970e08e8  WBARRIER(0x28cc768cdf8, ALLOC_OBJECT(0x28d96756dd8))
    //   0x28d970e0920  ALLOC_OBJECT(0x28d96756f98)
    //   0x28d970e0948  WBARRIER((ALLOC_OBJECT(0x28d96756f98) add 0x20), ALLOC_OBJECT(0x28d96756dd8))
    //   0x28d970e0998  Combine(0x28cc768ce00.f0, ALLOC_OBJECT(0x28d96756f98), 0x28d96757068.f28, ?)
    //   0x28d970e09e8  WBARRIER(0x28cc768ce00, ALLOC_OBJECT(0x28d96756f98))
    //   0x28d970e0a10  ALLOC_OBJECT(0x28d96757158)
    //   0x28d970e0a38  WBARRIER((ALLOC_OBJECT(0x28d96757158) add 0x20), ALLOC_OBJECT(0x28d96756f98))
    //   0x28d970e0a88  add_onBattlEyeKick(ALLOC_OBJECT(0x28d96757158), 0x28d96757228.f28, 0x28d96757068.f28, ?)
    //   0x28d970e0aa8  ALLOC_OBJECT(0x28d96757318)
    //   0x28d970e0ad0  WBARRIER((ALLOC_OBJECT(0x28d96757318) add 0x20), 0x28d96757228.f28)
    //   0x28d970e0b20  add_onBulletHit(ALLOC_OBJECT(0x28d96757318), 0x28d967573e8.f28, 0x28d96757068.f28, ?)
    //   0x28d970e0b40  ALLOC_OBJECT(0x28d967574d8)
    //   0x28d970e0b68  WBARRIER((ALLOC_OBJECT(0x28d967574d8) add 0x20), 0x28d967573e8.f28)
    //   0x28d970e0bb8  add_OnGestureChanged_Global(ALLOC_OBJECT(0x28d967574d8), 0x28d967575a8.f28, 0x28d96757068.f28, ?)
    //   0x28d970e0bc8  760EF57D5259421C::A599C828530B4E69(this)
    //   0x28d970e0bf8  THROW(0x162, 0xb2)
    //   0x28d970e0c10  THROW(0xf3, 0xed)
    //   0x28d970e0c48  THROW(0x14b, 0x291)
    // 39 store(s):
    //   0x28d970e072f  ALLOC_OBJECT(0x28ccd1bb3e0) <- this
    //   0x28d970e075d  ALLOC_OBJECT(0x28ccd1bb3e0) <- 0x28d9674a158
    //   0x28d970e076b  ALLOC_OBJECT(0x28ccd1bb3e0) <- 0x28d96756ce0
    //   0x28d970e077d  ALLOC_OBJECT(0x28ccd1bb3e0) <- 0x28d96756ce8.f28
    //   0x28d970e0785  ALLOC_OBJECT(0x28ccd1bb3e0) <- 0x28d96756ce8.f20
    //   0x28d970e0789  ALLOC_OBJECT(0x28ccd1bb3e0) <- 0x0
    //   0x28d970e07cd  0x28cc768ccb8 <- Combine(0x28cc768ccb8.f0, ALLOC_OBJECT(0x28ccd1bb3e0), 0x28d96756ce8.f28, ?)
    //   0x28d970e082f  ALLOC_OBJECT(0x28d96756dd8) <- this
    //   0x28d970e085d  ALLOC_OBJECT(0x28d96756dd8) <- 0x28d9674a198
    //   0x28d970e086b  ALLOC_OBJECT(0x28d96756dd8) <- 0x28d96756ea0
    //   0x28d970e087d  ALLOC_OBJECT(0x28d96756dd8) <- 0x28d96756ea8.f28
    //   0x28d970e0885  ALLOC_OBJECT(0x28d96756dd8) <- 0x28d96756ea8.f20
    //   0x28d970e0889  ALLOC_OBJECT(0x28d96756dd8) <- 0x0
    //   0x28d970e08cd  0x28cc768cdf8 <- Combine(0x28cc768cdf8.f0, ALLOC_OBJECT(0x28d96756dd8), 0x28d96756ea8.f28, ?)
    //   0x28d970e092f  ALLOC_OBJECT(0x28d96756f98) <- this
    //   0x28d970e095d  ALLOC_OBJECT(0x28d96756f98) <- 0x28d9674a1d8
    //   0x28d970e096b  ALLOC_OBJECT(0x28d96756f98) <- 0x28d96757060
    //   0x28d970e097d  ALLOC_OBJECT(0x28d96756f98) <- 0x28d96757068.f28
    //   0x28d970e0985  ALLOC_OBJECT(0x28d96756f98) <- 0x28d96757068.f20
    //   0x28d970e0989  ALLOC_OBJECT(0x28d96756f98) <- 0x0
    //   0x28d970e09cd  0x28cc768ce00 <- Combine(0x28cc768ce00.f0, ALLOC_OBJECT(0x28d96756f98), 0x28d96757068.f28, ?)
    //   0x28d970e0a1f  ALLOC_OBJECT(0x28d96757158) <- this
    //   0x28d970e0a49  ALLOC_OBJECT(0x28d96757158) <- 0x28d9674a200
    //   0x28d970e0a57  ALLOC_OBJECT(0x28d96757158) <- 0x28d96757220
    //   0x28d970e0a69  ALLOC_OBJECT(0x28d96757158) <- 0x28d96757228.f28
    //   0x28d970e0a71  ALLOC_OBJECT(0x28d96757158) <- 0x28d96757228.f20
    //   0x28d970e0a75  ALLOC_OBJECT(0x28d96757158) <- 0x0
    //   0x28d970e0ab7  ALLOC_OBJECT(0x28d96757318) <- this
    //   0x28d970e0ae1  ALLOC_OBJECT(0x28d96757318) <- 0x28d9674a260
    //   0x28d970e0aef  ALLOC_OBJECT(0x28d96757318) <- 0x28d967573e0
    // returns: 760EF57D5259421C::A599C828530B4E69(this)
}
