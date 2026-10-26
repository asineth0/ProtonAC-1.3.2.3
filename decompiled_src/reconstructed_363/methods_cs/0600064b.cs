// ============================================================
// token 0x0600064b   3301ED6AA1A1474A::FF143A0CEA054A0C
// native code: 0x28d970c3660  (846 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig virtual
//   instance void FF143A0CEA054A0C () cil managed
//   
// native-calls: 06000662,06000663,06000664
// native-strings: 
// ============================================================

public  void FF143A0CEA054A0C()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 15 call(s):
    //   0x28d970c36a8  ALLOC_OBJECT(0x28d9683b260)
    //   0x28d970c36d0  WBARRIER((ALLOC_OBJECT(0x28d9683b260) add 0x20), ?)
    //   0x28d970c3720  3301ED6AA1A1474A::EF3E97E51C654670(0x28c84109b48.f0, ALLOC_OBJECT(0x28d9683b260))
    //   0x28d970c3770  WBARRIER(0x28c84109b48, ALLOC_OBJECT(0x28d9683b260))
    //   0x28d970c3798  ALLOC_OBJECT(0x28d9683b420)
    //   0x28d970c37c0  WBARRIER((ALLOC_OBJECT(0x28d9683b420) add 0x20), ALLOC_OBJECT(0x28d9683b260))
    //   0x28d970c3810  3301ED6AA1A1474A::B1EC180BD62C468D(ALLOC_OBJECT(0x28d9683b420))
    //   0x28d970c3848  ALLOC_OBJECT(0x28d9683cfa8)
    //   0x28d970c3870  WBARRIER((ALLOC_OBJECT(0x28d9683cfa8) add 0x20), 0x28d9683b4f0.f28)
    //   0x28d970c38c0  3301ED6AA1A1474A::EF3E97E51C654670(0x28c840e8470.f0, ALLOC_OBJECT(0x28d9683cfa8))
    //   0x28d970c3910  WBARRIER(0x28c840e8470, ALLOC_OBJECT(0x28d9683cfa8))
    //   0x28d970c3928  3301ED6AA1A1474A::15AE93DFC562412F(this)
    //   0x28d970c3958  THROW(0x14b, 0x79)
    //   0x28d970c3970  THROW(0x162, 0x122)
    //   0x28d970c3988  THROW(0xf3, 0x164)
    // 20 store(s):
    //   0x28d970c36b7  ALLOC_OBJECT(0x28d9683b260) <- this
    //   0x28d970c36e5  ALLOC_OBJECT(0x28d9683b260) <- 0x28d96831be8
    //   0x28d970c36f3  ALLOC_OBJECT(0x28d9683b260) <- 0x28d9683b328
    //   0x28d970c3705  ALLOC_OBJECT(0x28d9683b260) <- 0x28d9683b330.f28
    //   0x28d970c370d  ALLOC_OBJECT(0x28d9683b260) <- 0x28d9683b330.f20
    //   0x28d970c3711  ALLOC_OBJECT(0x28d9683b260) <- 0x0
    //   0x28d970c3755  0x28c84109b48 <- 3301ED6AA1A1474A::EF3E97E51C654670(0x28c84109b48.f0, ALLOC_OBJECT(0x28d9683b260))
    //   0x28d970c37a7  ALLOC_OBJECT(0x28d9683b420) <- this
    //   0x28d970c37d1  ALLOC_OBJECT(0x28d9683b420) <- 0x28d96831e30
    //   0x28d970c37df  ALLOC_OBJECT(0x28d9683b420) <- 0x28d9683b4e8
    //   0x28d970c37f1  ALLOC_OBJECT(0x28d9683b420) <- 0x28d9683b4f0.f28
    //   0x28d970c37f9  ALLOC_OBJECT(0x28d9683b420) <- 0x28d9683b4f0.f20
    //   0x28d970c37fd  ALLOC_OBJECT(0x28d9683b420) <- 0x0
    //   0x28d970c3857  ALLOC_OBJECT(0x28d9683cfa8) <- this
    //   0x28d970c3885  ALLOC_OBJECT(0x28d9683cfa8) <- 0x28d968320b0
    //   0x28d970c3893  ALLOC_OBJECT(0x28d9683cfa8) <- 0x28d9683d070
    //   0x28d970c38a5  ALLOC_OBJECT(0x28d9683cfa8) <- 0x28d9683d078.f28
    //   0x28d970c38ad  ALLOC_OBJECT(0x28d9683cfa8) <- 0x28d9683d078.f20
    //   0x28d970c38b1  ALLOC_OBJECT(0x28d9683cfa8) <- 0x0
    //   0x28d970c38f5  0x28c840e8470 <- 3301ED6AA1A1474A::EF3E97E51C654670(0x28c840e8470.f0, ALLOC_OBJECT(0x28d9683cfa8))
    // returns: 3301ED6AA1A1474A::15AE93DFC562412F(this)
}
