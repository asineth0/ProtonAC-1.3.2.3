// ============================================================
// token 0x0600026a   A19CBF069C964833::.ctor
// native code: 0x28d95a3ce30  (3697 bytes)
// kind: SMALL_CALL   confidence: outline
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 06001086,06000270,06006153,0600026c,0600107c,060000a9,060012dd
// native-strings: ?:BHT,?:TTT,?:PRT,?:PTT,?:GPT,?:NPT,?:VPT,?:MPT,?:VCT,?:VVT,?:VST,?:Performance-Scheduler,?:2804803032512,?:2804803032480,?:2804803032256,?:2804803032224,?:2804803032064,?:2804803032032,?:2804803031872,?:2804803031840,?:2804803031680,?:2804803031648,?:2804803031488,?:2804822515712
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 52 call(s):
    //   0x28d95a3ce70  ALLOC_OBJECT(0x28d9612b170)
    //   0x28d95a3ce88  .ctor(ALLOC_OBJECT(0x28d9612b170), ?, ?, ?)
    //   0x28d95a3ceb0  WBARRIER(this+10, ?)
    //   0x28d95a3cec8  C179263454B44BF6::.ctor(this)
    //   0x28d95a3cef0  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3cf18  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d5c0, 0x1)   ; "BHT"
    //   0x28d95a3cf80  AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3cfa8  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3cfd0  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d5a0, 0x1)   ; "TTT"
    //   0x28d95a3d058  List`1::AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d080  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3d0a8  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d4c0, 0x1)   ; "PRT"
    //   0x28d95a3d150  List`1::AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d178  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3d1a0  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d4a0, 0x1)   ; "PTT"
    //   0x28d95a3d248  List`1::AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d270  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3d298  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d400, 0x1)   ; "GPT"
    //   0x28d95a3d340  AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d368  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3d390  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d3e0, 0x1)   ; "NPT"
    //   0x28d95a3d438  List`1::AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d460  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3d488  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d340, 0x1)   ; "VPT"
    //   0x28d95a3d530  List`1::AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d558  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3d580  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d320, 0x1)   ; "MPT"
    //   0x28d95a3d628  List`1::AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d650  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3d678  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d280, (ALLOC_OBJECT(0x28d9612b2d8) xor ALLOC_OBJECT(0x28d9612b2d8)))   ; "VCT"
    //   0x28d95a3d720  AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d748  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3d770  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d260, (ALLOC_OBJECT(0x28d9612b2d8) xor ALLOC_OBJECT(0x28d9612b2d8)))   ; "VVT"
    //   0x28d95a3d818  List`1::AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d840  ALLOC_OBJECT(0x28d9612b2d8)
    //   0x28d95a3d868  40FE7AC3F69F4B10::.ctor(ALLOC_OBJECT(0x28d9612b2d8), 0x28d0b49d1c0, 0x1)   ; "VST"
    //   0x28d95a3d910  List`1::AddWithResize(this.f10, ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d928  ALLOC_OBJECT(0x28c86b1d020)
    //   0x28d95a3d940  .ctor(ALLOC_OBJECT(0x28c86b1d020), ALLOC_OBJECT(0x28d9612b2d8), ALLOC_OBJECT(0x28d9612b2d8), ?)
    //   0x28d95a3d968  WBARRIER(this+20, ALLOC_OBJECT(0x28d9612b2d8))
    //   0x28d95a3d980  A19CBF069C964833::2D34939E383B44AA(this)
    //   0x28d95a3d9a0  WBARRIER(this+18, ALLOC_OBJECT(0x28d9612b2d8))
    //   0x28d95a3d9c8  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d95a3d9f0  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), ALLOC_OBJECT(0x28d9612b2d8))
    //   0x28d95a3da48  C179263454B44BF6::A974151DEF324E6A()
    //   0x28d95a3da60  1DB744298E9F4B09::F9134C0BD55E44F8(C179263454B44BF6::A974151DEF324E6A())
    //   0x28d95a3db18  ALLOC_OBJECT(0x28cc8341df8)
    //   0x28d95a3db50  WBARRIER((ALLOC_OBJECT(0x28cc8341df8) add 0x20), (1DB744298E9F4B09::F9134C0BD55E44F8(C179263454B44BF6::A974151DEF324E6A()) xor 1DB744298E9F4B09::F9134C0BD55E44F8(C179263454B44BF6::A974151DEF324E6A())))
    //   0x28d95a3dbd0  WBARRIER(0x28cca2db108, 0x28d9612b7b8.f28)
    //   0x28d95a3dc38  1FFBEDFB3FCE4374::533FDA357CCF49A3(0x28d0c732000, ALLOC_OBJECT(0x28cc8356f60), (? add 0xffffffffffffffb8), ALLOC_OBJECT(0x28cc8341df8))   ; "Performance-Scheduler"
    //   0x28d95a3dc78  THROW(0x162, 0x153)
    //   0x28d95a3dc90  THROW(0xf3, 0x199)
    // 39 store(s):
    //   0x28d95a3ce9d  this+10 <- ALLOC_OBJECT(0x28d9612b170)
    //   0x28d95a3cf38  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3cf56  this.f10 <- (movsxd this.f10.f18)+1
    //   0x28d95a3cff3  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d025  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d0d7  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d10e  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d1cf  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d206  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d2c7  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d2fe  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d3bf  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d3f6  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d4b7  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d4ee  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d5af  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d5e6  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d6a7  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d6de  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d79f  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d7d6  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d897  this.f10 <- ((movsxd this.f10.f1c) inc 0x1)
    //   0x28d95a3d8ce  this.f10 <- ((movsxd (movsxd this.f10.f18)) inc 0x1)
    //   0x28d95a3d955  this+20 <- ALLOC_OBJECT(0x28c86b1d020)
    //   0x28d95a3d98e  this+18 <- A19CBF069C964833::2D34939E383B44AA(this)
    //   0x28d95a3d9d7  ALLOC_OBJECT(0x28cc8356f60) <- this
    //   0x28d95a3da04  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d96128cc8
    //   0x28d95a3da12  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d9612b620
    //   0x28d95a3da24  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d9612b628.f28
    //   0x28d95a3da2c  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d9612b628.f20
    // returns: 1FFBEDFB3FCE4374::533FDA357CCF49A3(0x28d0c732000, ALLOC_OBJECT(0x28cc8356f60), (? add 0xffffffffffffffb8), ALLOC_OBJECT(0x28cc8341df8))
    // string table refs:
    //   literal  "BHT"
    //   literal  "TTT"
    //   literal  "PRT"
    //   literal  "PTT"
    //   literal  "GPT"
    //   literal  "NPT"
    //   literal  "VPT"
    //   literal  "MPT"
    //   literal  "VCT"
    //   literal  "VVT"
    //   literal  "VST"
    //   literal  "Performance-Scheduler"
    //   literal  "2804803032512"
    //   literal  "2804803032480"
    //   literal  "2804803032256"
    //   literal  "2804803032224"
    //   literal  "2804803032064"
    //   literal  "2804803032032"
    //   literal  "2804803031872"
    //   literal  "2804803031840"
    //   literal  "2804803031680"
    //   literal  "2804803031648"
    //   literal  "2804803031488"
    //   literal  "2804822515712"
}
