// ============================================================
// token 0x060000bd   1DB744298E9F4B09::72F9E20AFFAE478D
// native code: 0x28d95a1ba70  (2415 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method public hidebysig
//   instance void '72F9E20AFFAE478D' (
//   string '',
//   string '',
//   string ''
//   ) cil managed noinlining
//   
// native-calls: 0600010a,0600010b,06000108,06000109,06000131,0600010e,0600010c,0600010d,06000006,060000d5,0600010f,06000007,06000003,06000110,06000111,06000114,06000005,060000ac,06000004,06000116,06000113,060000c7,06000112,06000115
// native-strings: 0x27c:Trace: Start called,0x2d8:Proton Anticheat loaded!,0x2b8:GPT,0x2c0:NPT,0x2c8:VPT,0x2d0:MPT
// ============================================================

public  void 72F9E20AFFAE478D(string arg0, string arg1, string arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 53 call(s):
    //   0x28d95a1bb28  1DB744298E9F4B09::D72B79A4C8314ED0(this, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), arg1, arg2)
    //   0x28d95a1bb38  1DB744298E9F4B09::87340CA8A935414D(this, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), arg1, arg2)
    //   0x28d95a1bb60  1DB744298E9F4B09::118BC2EF420749BD(arg0)
    //   0x28d95a1bb80  WBARRIER(this+18, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9))
    //   0x28d95a1bb98  1DB744298E9F4B09::76E110F82D444CD6(arg1)
    //   0x28d95a1bbb8  WBARRIER(this+30, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9))
    //   0x28d95a1bc28  631D551E2DA64E7D::F3B62BCE1450413B(this.f68, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), arg1, arg2)
    //   0x28d95a1bc48  1DB744298E9F4B09::BAF961CF365D4B81(631D551E2DA64E7D::F3B62BCE1450413B(this.f68, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), arg1, arg2), (((((0xb28dd608e7cac0fa sub 0x3
    //   0x28d95a1bc68  1DB744298E9F4B09::0DC9F1E24BAC45AD(this.f60, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), arg1, arg2)
    //   0x28d95a1bc80  1DB744298E9F4B09::5115F37B0C424E89(this.f18, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), arg1, arg2)
    //   0x28d95a1bcd0  <Module>::58ECCB512F2A43AC(0x7c28c8c0, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), arg1, arg2)
    //   0x28d95a1bcf0  1DB744298E9F4B09::EAFA0985C99445A0(this.f20, <Module>::58ECCB512F2A43AC(0x7c28c8c0, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), arg1, arg2), 0x28cc7550840, arg2)
    //   0x28d95a1bd20  631D551E2DA64E7D::F3B62BCE1450413B(this.f68, <Module>::58ECCB512F2A43AC(0x7c28c8c0, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), arg1, arg2), 0x28cc7550840, arg2)
    //   0x28d95a1bd48  1DB744298E9F4B09::8999EFDDB7264684(631D551E2DA64E7D::F3B62BCE1450413B(this.f68, <Module>::58ECCB512F2A43AC(0x7c28c8c0, (((((0xb28dd608e7cac0fa sub 0x31577dc8) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0x9) mod 0x9), a
    //   0x28d95a1bd70  <Module>::3F57E81A62734AC2(0x3ca2d4c7)   ; =1
    //   0x28d95a1bdb0  <Module>::8B9C7B12B1AE4949(0x78b10dd7)   ; "Trace: Start called"
    //   0x28d95a1bdd0  1DB744298E9F4B09::DB6EB265DF784F3B(this.f20, <Module>::8B9C7B12B1AE4949(0x78b10dd7), 0x28cc7550840)
    //   0x28d95a1be48  1DB744298E9F4B09::DA796AAF45954313()
    //   0x28d95a1be68  WBARRIER(this+68, (((((0xb28dd608e7cac0fa sub 0xb27b9a) sub 0xcf0de05e49b7b4ce) imul 0xf035fbcb) div 0xc) mod 0xc))
    //   0x28d95a1be90  1DB744298E9F4B09::52AF56F70AAA454D(this.f60)
    //   0x28d95a1bea8  1DB744298E9F4B09::0DC9F1E24BAC45AD(this.f60)
    //   0x28d95a1bec0  1DB744298E9F4B09::5115F37B0C424E89(this.f18)
    //   0x28d95a1bee0  631D551E2DA64E7D::F3B62BCE1450413B(this.f68)
    //   0x28d95a1bf08  1DB744298E9F4B09::8999EFDDB7264684(631D551E2DA64E7D::F3B62BCE1450413B(this.f68), arg2)
    //   0x28d95a1bf30  <Module>::F84FA79ABE6944BB(0x67cf2da4)   ; =1
    //   0x28d95a1bf48  1DB744298E9F4B09::523E5FCCDA114546(this, <Module>::F84FA79ABE6944BB(0x67cf2da4))
    //   0x28d95a1bf80  <Module>::390073C602714496(0x4585f78)   ; "Proton Anticheat loaded!"
    //   0x28d95a1bfa0  1DB744298E9F4B09::EAFA0985C99445A0(this.f20, <Module>::390073C602714496(0x4585f78), 0x28cc7550840)
    //   0x28d95a1bfc8  631D551E2DA64E7D::F3B62BCE1450413B(this.f68)
    //   0x28d95a1c008  <Module>::8B9C7B12B1AE4949((movsxd 0xf84a18c0))   ; "GPT"
    //   0x28d95a1c020  1DB744298E9F4B09::FC4B299082CA47F9(0x0, <Module>::8B9C7B12B1AE4949((movsxd 0xf84a18c0)))
    //   0x28d95a1c040  WBARRIER(this+80, <Module>::8B9C7B12B1AE4949((movsxd 0xf84a18c0)))
    //   0x28d95a1c068  631D551E2DA64E7D::F3B62BCE1450413B(this.f68)
    //   0x28d95a1c0a8  <Module>::390073C602714496((movsxd 0xb024d96e))   ; "NPT"
    //   0x28d95a1c0c0  1DB744298E9F4B09::FC4B299082CA47F9(0x0, <Module>::390073C602714496((movsxd 0xb024d96e)))
    //   0x28d95a1c0e0  WBARRIER(this+88, <Module>::390073C602714496((movsxd 0xb024d96e)))
    //   0x28d95a1c108  631D551E2DA64E7D::F3B62BCE1450413B(this.f68)
    //   0x28d95a1c148  <Module>::390073C602714496((movsxd 0xcc36061c))   ; "VPT"
    //   0x28d95a1c160  1DB744298E9F4B09::FC4B299082CA47F9(0x0, <Module>::390073C602714496((movsxd 0xcc36061c)))
    //   0x28d95a1c180  WBARRIER(this+90, <Module>::390073C602714496((movsxd 0xcc36061c)))
    //   0x28d95a1c1a8  1DB744298E9F4B09::D72B79A4C8314ED0(this)
    //   0x28d95a1c1b8  1DB744298E9F4B09::87340CA8A935414D(this)
    //   0x28d95a1c1d0  1DB744298E9F4B09::85EB28639CB34AC1(this.f68)
    //   0x28d95a1c208  <Module>::3F57E81A62734AC2(0x24f4dbc6, <Module>::390073C602714496((movsxd 0xcc36061c)), 0x28cc7550840, arg2)
    //   0x28d95a1c218  1DB744298E9F4B09::2112E077830844B3(<Module>::3F57E81A62734AC2(0x24f4dbc6, <Module>::390073C602714496((movsxd 0xcc36061c)), 0x28cc7550840, arg2), <Module>::390073C602714496((movsxd 0xcc36061c)), 0x28cc7550840, arg2)
    //   0x28d95a1c228  ?(1DB744298E9F4B09::2112E077830844B3(<Module>::3F57E81A62734AC2(0x24f4dbc6, <Module>::390073C602714496((movsxd 0xcc36061c)), 0x28cc7550840, arg2), <Module>::390073C602714496((movsxd 0xcc36061c)), 0x28cc7550840, arg2), <Modul
    //   0x28d95a1c238  1DB744298E9F4B09::16C61215B89E427B()
    //   0x28d95a1c258  WBARRIER(this+60, <Module>::390073C602714496((movsxd 0xcc36061c)))
    //   0x28d95a1c2b0  1DB744298E9F4B09::0E9912E29BCC4087()
    //   0x28d95a1c2e0  631D551E2DA64E7D::F3B62BCE1450413B(this.f68)
    //   0x28d95a1c320  <Module>::8B9C7B12B1AE4949((movsxd 0x12a012f6))   ; "MPT"
    //   0x28d95a1c338  1DB744298E9F4B09::FC4B299082CA47F9(0x0, <Module>::8B9C7B12B1AE4949((movsxd 0x12a012f6)))
    //   0x28d95a1c358  WBARRIER(this+98, <Module>::8B9C7B12B1AE4949((movsxd 0x12a012f6)))
    // 9 store(s):
    //   0x28d95a1bb6e  this+18 <- 1DB744298E9F4B09::118BC2EF420749BD(arg0)
    //   0x28d95a1bba6  this+30 <- 1DB744298E9F4B09::76E110F82D444CD6(arg1)
    //   0x28d95a1bd73  this <- <Module>::3F57E81A62734AC2(0x3ca2d4c7)
    //   0x28d95a1be56  this+68 <- 1DB744298E9F4B09::DA796AAF45954313()
    //   0x28d95a1c032  this+80 <- 1DB744298E9F4B09::FC4B299082CA47F9(0x0, <Module>::8B9C7B12B1AE4949((movsxd 0xf84a18c0)))
    //   0x28d95a1c0d2  this+88 <- 1DB744298E9F4B09::FC4B299082CA47F9(0x0, <Module>::390073C602714496((movsxd 0xb024d96e)))
    //   0x28d95a1c172  this+90 <- 1DB744298E9F4B09::FC4B299082CA47F9(0x0, <Module>::390073C602714496((movsxd 0xcc36061c)))
    //   0x28d95a1c246  this+60 <- 1DB744298E9F4B09::16C61215B89E427B()
    //   0x28d95a1c34a  this+98 <- 1DB744298E9F4B09::FC4B299082CA47F9(0x0, <Module>::8B9C7B12B1AE4949((movsxd 0x12a012f6)))
    // returns: 1DB744298E9F4B09::FC4B299082CA47F9(0x0, <Module>::8B9C7B12B1AE4949((movsxd 0x12a012f6)))
    // string table refs:
    //   0x27c  "Trace: Start called"
    //   0x2d8  "Proton Anticheat loaded!"
    //   0x2b8  "GPT"
    //   0x2c0  "NPT"
    //   0x2c8  "VPT"
    //   0x2d0  "MPT"
}
