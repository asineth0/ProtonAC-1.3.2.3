// ============================================================
// token 0x06000e67   02C54685DE0E4B81::.ctor
// native code: 0x28d957e0000  (1432 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   class [ProtonAC.Microsoft.Extensions.Logging.Abstractions]Microsoft.Extensions.Logging.ILogger ''
//   ) cil managed noinlining
//   
// native-calls: 06000003,06000e7d,06000005,06000006,06000004,06000e7e,06000e7f,06000e6f,06000e81,06000e80,06000e82,06000e83
// native-strings: 0x2f40:wss://api.proton-anticheat.dev/cloud/ac,0x2f6c:wss://pro.sarshane.store/cloud/ac
// ============================================================

public  void .ctor(Microsoft.Extensions.Logging.ILogger arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 32 call(s):
    //   0x28d957e0040  ALLOC_OBJECT(0x28d94ff9e98)
    //   0x28d957e0058  .ctor(ALLOC_OBJECT(0x28d94ff9e98), arg0, ?, ?)
    //   0x28d957e0078  WBARRIER(this+18, arg0)
    //   0x28d957e0098  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d957e00a8  02C54685DE0E4B81::5A690657AF774003(<Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd))
    //   0x28d957e00c0  WBARRIER(this+20, arg0)
    //   0x28d957e00e0  <Module>::F84FA79ABE6944BB(0x3d412794)   ; =0
    //   0x28d957e00f0  FromMinutes(0x3d412794, arg0, ?, ?)
    //   0x28d957e0130  <Module>::58ECCB512F2A43AC(0xffffffff9f8dc5c9)   ; "wss://api.proton-anticheat.dev/cloud/ac"
    //   0x28d957e0148  WBARRIER(this+38, arg0)
    //   0x28d957e0170  <Module>::390073C602714496(0x3aa8669d)   ; "wss://pro.sarshane.store/cloud/ac"
    //   0x28d957e0188  WBARRIER(this+40, arg0)
    //   0x28d957e0220  02C54685DE0E4B81::606938F5F7B24508()
    //   0x28d957e0238  WBARRIER(this+30, ((((0xffffffffd175e263 sub ((((((0x4c6d860 add 0x192360419f81c940) sub 0xf044027db120a9cd) imul 0x40bd3ecf) not 0x1) not 0x1) add 0xdb74458a)) sub 0xd218c99d) div 0x6) mod 0x6))
    //   0x28d957e0260  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d957e0288  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), ((((0xffffffffd175e263 sub ((((((0x4c6d860 add 0x192360419f81c940) sub 0xf044027db120a9cd) imul 0x40bd3ecf) not 0x1) not 0x1) add 0xdb74458a)) sub 0xd218c99d) div 0x6) mod
    //   0x28d957e02d8  02C54685DE0E4B81::66A77EEDCD8D4C13(ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d957e02f0  WBARRIER(this+28, 0x28d94ff9f60.f28)
    //   0x28d957e0308  WBARRIER(this+60, 0x28d94ff9f60.f28)
    //   0x28d957e0330  02C54685DE0E4B81::E1E49D90BFD0484B(this)
    //   0x28d957e0358  02C54685DE0E4B81::9B8024EA81184A6D()
    //   0x28d957e0370  WBARRIER(this+50, 0x28d94ff9f60.f28)
    //   0x28d957e03a0  02C54685DE0E4B81::BDFE184CA8AE49F2()
    //   0x28d957e03b8  WBARRIER(this+48, 0x28d94ff9f60.f28)
    //   0x28d957e03e8  02C54685DE0E4B81::B9AC42DA663347C4(arg0)
    //   0x28d957e0440  ALLOC_OBJECT(0x28cc8531cd8)
    //   0x28d957e0470  WBARRIER((ALLOC_OBJECT(0x28cc8531cd8) add 0x20), 02C54685DE0E4B81::B9AC42DA663347C4(arg0))
    //   0x28d957e04e8  WBARRIER(0x28cca2db3f8, 0x28d94d190b0.f28)
    //   0x28d957e0510  02C54685DE0E4B81::B108BF03B62D4C9B(02C54685DE0E4B81::B9AC42DA663347C4(arg0), ALLOC_OBJECT(0x28cc8531cd8))
    //   0x28d957e0528  WBARRIER(this+10, ALLOC_OBJECT(0x28cc8531cd8))
    //   0x28d957e0568  THROW(0x162, 0x11e)
    //   0x28d957e0580  THROW(0xf3, 0x160)
    // 24 store(s):
    //   0x28d957e0067  this+18 <- ALLOC_OBJECT(0x28d94ff9e98)
    //   0x28d957e00b3  this+20 <- 02C54685DE0E4B81::5A690657AF774003(<Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd))
    //   0x28d957e0108  this+70 <- FromMinutes(0x3d412794, arg0, ?, ?)
    //   0x28d957e013b  this+38 <- <Module>::58ECCB512F2A43AC(0xffffffff9f8dc5c9)
    //   0x28d957e017b  this+40 <- <Module>::390073C602714496(0x3aa8669d)
    //   0x28d957e022b  this+30 <- 02C54685DE0E4B81::606938F5F7B24508()
    //   0x28d957e026f  ALLOC_OBJECT(0x28cc8356f60) <- this
    //   0x28d957e0299  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94d09a10
    //   0x28d957e02a7  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ff9f58
    //   0x28d957e02b9  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ff9f60.f28
    //   0x28d957e02c1  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ff9f60.f20
    //   0x28d957e02c5  ALLOC_OBJECT(0x28cc8356f60) <- 0x0
    //   0x28d957e02e3  this+28 <- 02C54685DE0E4B81::66A77EEDCD8D4C13(ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d957e02fb  this+60 <- arg0
    //   0x28d957e0363  this+50 <- 02C54685DE0E4B81::9B8024EA81184A6D()
    //   0x28d957e03ab  this+48 <- 02C54685DE0E4B81::BDFE184CA8AE49F2()
    //   0x28d957e0457  ALLOC_OBJECT(0x28cc8531cd8) <- 0x28cca817210
    //   0x28d957e0485  ALLOC_OBJECT(0x28cc8531cd8) <- 0x28d94d09cc0
    //   0x28d957e0493  ALLOC_OBJECT(0x28cc8531cd8) <- 0x28d94d190a8
    //   0x28d957e04a5  ALLOC_OBJECT(0x28cc8531cd8) <- 0x28d94d190b0.f28
    //   0x28d957e04ad  ALLOC_OBJECT(0x28cc8531cd8) <- 0x28d94d190b0.f20
    //   0x28d957e04b1  ALLOC_OBJECT(0x28cc8531cd8) <- 0x0
    //   0x28d957e04c6  0x28cca2db3f8 <- ALLOC_OBJECT(0x28cc8531cd8)
    //   0x28d957e051b  this+10 <- 02C54685DE0E4B81::B108BF03B62D4C9B(02C54685DE0E4B81::B9AC42DA663347C4(arg0), ALLOC_OBJECT(0x28cc8531cd8))
    // returns: 02C54685DE0E4B81::B108BF03B62D4C9B(02C54685DE0E4B81::B9AC42DA663347C4(arg0), ALLOC_OBJECT(0x28cc8531cd8))
    // string table refs:
    //   0x2f40  "wss://api.proton-anticheat.dev/cloud/ac"
    //   0x2f6c  "wss://pro.sarshane.store/cloud/ac"
}
