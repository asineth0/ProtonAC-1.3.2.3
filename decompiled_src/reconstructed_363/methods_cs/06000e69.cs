// ============================================================
// token 0x06000e69   02C54685DE0E4B81::E4562FFAB4464AE1
// native code: 0x28d958b5c40  (1273 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance void E4562FFAB4464AE1 () cil managed
//   
// native-calls: 06000e84,06000e85,06000e86,06000e87,06000e88,06000e89
// native-strings: 
// ============================================================

 void E4562FFAB4464AE1()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 20 call(s):
    //   0x28d958b5c80  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d958b5ca8  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), ?)
    //   0x28d958b5cf8  02C54685DE0E4B81::A6AFAEB843D843C0(this.f10, ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d958b5d20  ALLOC_OBJECT(0x28d94ffd390)
    //   0x28d958b5d48  WBARRIER((ALLOC_OBJECT(0x28d94ffd390) add 0x20), ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d958b5d98  02C54685DE0E4B81::0C15A70DCCED4B88(this.f10, ALLOC_OBJECT(0x28d94ffd390))
    //   0x28d958b5e38  ALLOC_OBJECT(0x28cc83e9710)
    //   0x28d958b5e60  WBARRIER((ALLOC_OBJECT(0x28cc83e9710) add 0x20), (((((((0xffffffff843cd37a xor 0x9c55a617eb32c76) add 0xb224d28a944dd297) imul 0x6cee6087) not 0x1) neg 0x1) div 0x3) mod 0x3))
    //   0x28d958b5eb0  02C54685DE0E4B81::C184B46A02554661(this.f10, ALLOC_OBJECT(0x28cc83e9710))
    //   0x28d958b5ed8  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d958b5f00  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), ALLOC_OBJECT(0x28cc83e9710))
    //   0x28d958b5f50  02C54685DE0E4B81::A2764DB6FA044738(this.f10, ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d958b5f78  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d958b5fa0  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d958b5ff0  02C54685DE0E4B81::EFFE37A3B1674F90(this.f10, ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d958b6030  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d958b6058  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d958b60a8  02C54685DE0E4B81::284D9A9A74DF437D(this.f10, ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d958b60d8  THROW(0x162, 0xa2)
    //   0x28d958b60f0  THROW(0xf3, 0xdd)
    // 36 store(s):
    //   0x28d958b5c8f  ALLOC_OBJECT(0x28cc8356f60) <- this
    //   0x28d958b5cbd  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfb6f68
    //   0x28d958b5ccb  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbf5d0
    //   0x28d958b5cdd  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbf5d8.f28
    //   0x28d958b5ce5  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbf5d8.f20
    //   0x28d958b5ce9  ALLOC_OBJECT(0x28cc8356f60) <- 0x0
    //   0x28d958b5d2f  ALLOC_OBJECT(0x28d94ffd390) <- this
    //   0x28d958b5d5d  ALLOC_OBJECT(0x28d94ffd390) <- 0x28d0dfb6fe8
    //   0x28d958b5d6b  ALLOC_OBJECT(0x28d94ffd390) <- 0x28d0dfbf630
    //   0x28d958b5d7d  ALLOC_OBJECT(0x28d94ffd390) <- 0x28d0dfbf638.f28
    //   0x28d958b5d85  ALLOC_OBJECT(0x28d94ffd390) <- 0x28d0dfbf638.f20
    //   0x28d958b5d89  ALLOC_OBJECT(0x28d94ffd390) <- 0x0
    //   0x28d958b5e47  ALLOC_OBJECT(0x28cc83e9710) <- this
    //   0x28d958b5e75  ALLOC_OBJECT(0x28cc83e9710) <- 0x28d0dfb7068
    //   0x28d958b5e83  ALLOC_OBJECT(0x28cc83e9710) <- 0x28d0dfbf690
    //   0x28d958b5e95  ALLOC_OBJECT(0x28cc83e9710) <- 0x28d0dfbf698.f28
    //   0x28d958b5e9d  ALLOC_OBJECT(0x28cc83e9710) <- 0x28d0dfbf698.f20
    //   0x28d958b5ea1  ALLOC_OBJECT(0x28cc83e9710) <- 0x0
    //   0x28d958b5ee7  ALLOC_OBJECT(0x28cc8356f60) <- this
    //   0x28d958b5f15  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbb150
    //   0x28d958b5f23  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbf6f0
    //   0x28d958b5f35  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbf6f8.f28
    //   0x28d958b5f3d  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbf6f8.f20
    //   0x28d958b5f41  ALLOC_OBJECT(0x28cc8356f60) <- 0x0
    //   0x28d958b5f87  ALLOC_OBJECT(0x28cc8356f60) <- this
    //   0x28d958b5fb5  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbb1a0
    //   0x28d958b5fc3  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbf750
    //   0x28d958b5fd5  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbf758.f28
    //   0x28d958b5fdd  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d0dfbf758.f20
    //   0x28d958b5fe1  ALLOC_OBJECT(0x28cc8356f60) <- 0x0
    // returns: 02C54685DE0E4B81::284D9A9A74DF437D(this.f10, ALLOC_OBJECT(0x28cc8356f60))
}
