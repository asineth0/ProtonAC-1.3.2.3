// ============================================================
// token 0x0600075b   C513333D2D3A4C12::.cctor
// native code: 0x28d970ceb60  (4185 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed noinlining
//   
// native-calls: 0600105e,06000131,06000005,06000782,06000004,06000785,06000006,06000003,06000007,06000783,06000784
// native-strings: 0x1be0:PRT
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 92 call(s):
    //   0x28d970ceb90  760EF57D5259421C::EBDC6C691E8048F7()
    //   0x28d970cebb0  631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970cebe0  WBARRIER(0x28b826c0dd0, ?)
    //   0x28d970cec20  <Module>::F84FA79ABE6944BB(0xffffffff9e9a3a9a)   ; "PRT"
    //   0x28d970cec38  C513333D2D3A4C12::BC8FB48CDB314E53(0x28b826c0dd0.f0, <Module>::F84FA79ABE6944BB(0xffffffff9e9a3a9a))
    //   0x28d970cec68  WBARRIER(0x28b826c0dd8, <Module>::F84FA79ABE6944BB(0xffffffff9e9a3a9a))
    //   0x28d970cecf8  <Module>::390073C602714496(0x57ebf971)   ; =15
    //   0x28d970ced08  C513333D2D3A4C12::72E318DB88E74E86(<Module>::390073C602714496(0x57ebf971))
    //   0x28d970ced38  WBARRIER(0x28b826c0e50, (((((((((0xffffffffbcbd78f0 not 0x1) imul 0x15ed5505) not 0x1) xor 0xf9dc612008808e1) not 0x1) sub 0x8c5ee161) sub 0xa0721dc2) div 0xe) mod 0xe))
    //   0x28d970ced60  <Module>::58ECCB512F2A43AC(0xffffffff95b247b9)   ; =14
    //   0x28d970ced70  C513333D2D3A4C12::72E318DB88E74E86(<Module>::58ECCB512F2A43AC(0xffffffff95b247b9))
    //   0x28d970ceda0  WBARRIER(0x28b826c0e58, (((((((((0xffffffffbcbd78f0 not 0x1) imul 0x15ed5505) not 0x1) xor 0xf9dc612008808e1) not 0x1) sub 0x8c5ee161) sub 0xa0721dc2) div 0xe) mod 0xe))
    //   0x28d970cedc0  <Module>::58ECCB512F2A43AC(0x1b3c252f)   ; =13
    //   0x28d970cedd0  C513333D2D3A4C12::72E318DB88E74E86(<Module>::58ECCB512F2A43AC(0x1b3c252f))
    //   0x28d970cee00  WBARRIER(0x28b826c0e60, (((((((((0xffffffffbcbd78f0 not 0x1) imul 0x15ed5505) not 0x1) xor 0xf9dc612008808e1) not 0x1) sub 0x8c5ee161) sub 0xa0721dc2) div 0xe) mod 0xe))
    //   0x28d970cee28  <Module>::F84FA79ABE6944BB(0xfffffffff51db57b)   ; =12
    //   0x28d970cee38  C513333D2D3A4C12::72E318DB88E74E86(<Module>::F84FA79ABE6944BB(0xfffffffff51db57b))
    //   0x28d970cee68  WBARRIER(0x28b826c0e68, (((((((((0xffffffffbcbd78f0 not 0x1) imul 0x15ed5505) not 0x1) xor 0xf9dc612008808e1) not 0x1) sub 0x8c5ee161) sub 0xa0721dc2) div 0xe) mod 0xe))
    //   0x28d970cee90  <Module>::390073C602714496(0xffffffffb582cfce)   ; =19
    //   0x28d970ceea0  C513333D2D3A4C12::72E318DB88E74E86(<Module>::390073C602714496(0xffffffffb582cfce))
    //   0x28d970ceed0  WBARRIER(0x28b826c0e70, (((((((((0xffffffffbcbd78f0 not 0x1) imul 0x15ed5505) not 0x1) xor 0xf9dc612008808e1) not 0x1) sub 0x8c5ee161) sub 0xa0721dc2) div 0xe) mod 0xe))
    //   0x28d970ceef0  <Module>::58ECCB512F2A43AC(0x7eaee01f)   ; =11
    //   0x28d970cef00  C513333D2D3A4C12::72E318DB88E74E86(<Module>::58ECCB512F2A43AC(0x7eaee01f))
    //   0x28d970cef30  WBARRIER(0x28b826c0e78, (((((((((0xffffffffbcbd78f0 not 0x1) imul 0x15ed5505) not 0x1) xor 0xf9dc612008808e1) not 0x1) sub 0x8c5ee161) sub 0xa0721dc2) div 0xe) mod 0xe))
    //   0x28d970cef60  <Module>::8B9C7B12B1AE4949(0x6f6f10f5)   ; =16
    //   0x28d970cef70  C513333D2D3A4C12::72E318DB88E74E86(<Module>::8B9C7B12B1AE4949(0x6f6f10f5))
    //   0x28d970cefa0  WBARRIER(0x28b826c0e48, (((((((((0xffffffffbcbd78f0 not 0x1) imul 0x15ed5505) not 0x1) xor 0xf9dc612008808e1) not 0x1) sub 0x8c5ee161) sub 0xa0721dc2) div 0xe) mod 0xe))
    //   0x28d970cefd0  <Module>::58ECCB512F2A43AC(0x4173ceda)   ; =8
    //   0x28d970ceff0  ALLOC_OBJECT(0x28d96647148)
    //   0x28d970cf008  .ctor(ALLOC_OBJECT(0x28d96647148), <Module>::58ECCB512F2A43AC(0x4173ceda), ?, ?)
    //   0x28d970cf038  WBARRIER(0x28b826c0df0, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf090  <Module>::390073C602714496(0xffffffffd6935d04)   ; =1065353216
    //   0x28d970cf0c8  <Module>::3F57E81A62734AC2(0x63f131ae, <Module>::58ECCB512F2A43AC(0x4173ceda), ?, ?)
    //   0x28d970cf110  <Module>::3F57E81A62734AC2(0x7eaf7404)   ; =1083179008
    //   0x28d970cf140  <Module>::8B9C7B12B1AE4949(0xfffffffff626ccfe, <Module>::58ECCB512F2A43AC(0x4173ceda), ?, ?)
    //   0x28d970cf188  <Module>::3F57E81A62734AC2(0xc0e952f)   ; =438026241
    //   0x28d970cf1a8  C513333D2D3A4C12::F35317EDC902477E()
    //   0x28d970cf1e0  <Module>::3F57E81A62734AC2(0xffffffffaf43b39c)   ; =4
    //   0x28d970cf200  ALLOC_ARRAY(0x28cc7f69d88, <Module>::3F57E81A62734AC2(0xffffffffaf43b39c))
    //   0x28d970cf230  C513333D2D3A4C12::5847E348194D4EE3(ALLOC_ARRAY(0x28cc7f69d88, <Module>::3F57E81A62734AC2(0xffffffffaf43b39c)), 0x28d961bffa0)
    //   0x28d970cf260  WBARRIER(0x28b826c0df8, 0x28d961bffa0)
    //   0x28d970cf298  <Module>::8B9C7B12B1AE4949(0xfffffffff595f7cc)   ; =20
    //   0x28d970cf2a8  C513333D2D3A4C12::72E318DB88E74E86(<Module>::8B9C7B12B1AE4949(0xfffffffff595f7cc))
    //   0x28d970cf2d8  WBARRIER(0x28b826c0e80, 0x28d961bffa0)
    //   0x28d970cf2f8  <Module>::390073C602714496(0x51ee1700)   ; =21
    //   0x28d970cf308  C513333D2D3A4C12::72E318DB88E74E86(<Module>::390073C602714496(0x51ee1700))
    //   0x28d970cf338  WBARRIER(0x28b826c0e88, 0x28d961bffa0)
    //   0x28d970cf360  <Module>::3F57E81A62734AC2(0xffffffff94367c09)   ; =10
    //   0x28d970cf370  C513333D2D3A4C12::72E318DB88E74E86(<Module>::3F57E81A62734AC2(0xffffffff94367c09))
    //   0x28d970cf3a0  WBARRIER(0x28b826c0e90, 0x28d961bffa0)
    //   0x28d970cf3c8  <Module>::8B9C7B12B1AE4949(0x50f4f95b)   ; =4
    //   0x28d970cf3e8  ALLOC_ARRAY(0x28cc7f69d88, <Module>::8B9C7B12B1AE4949(0x50f4f95b))
    //   0x28d970cf418  C513333D2D3A4C12::5847E348194D4EE3(ALLOC_ARRAY(0x28cc7f69d88, <Module>::8B9C7B12B1AE4949(0x50f4f95b)), 0x28d961bffa0)
    //   0x28d970cf448  WBARRIER(0x28b826c0e00, 0x28d961bffa0)
    //   0x28d970cf468  <Module>::58ECCB512F2A43AC(0x4173ceda)   ; =8
    //   0x28d970cf488  ALLOC_ARRAY(0x28c85420a20, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf4b8  WBARRIER(0x28b826c0e08, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf4e8  ALLOC_OBJECT(0x28c86e9b260)
    //   0x28d970cf518  WBARRIER((ALLOC_OBJECT(0x28c86e9b260) add 0x10), <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf558  WBARRIER(0x28b826c0e10, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf578  ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d970cf5a8  WBARRIER((ALLOC_OBJECT(0x28c86f73f50) add 0x10), <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf5e0  WBARRIER(0x28b826c0e18, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf600  ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d970cf630  WBARRIER((ALLOC_OBJECT(0x28c86f73f50) add 0x10), <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf660  WBARRIER(0x28b826c0e20, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf688  <Module>::8B9C7B12B1AE4949(0xffffffff9fe7a2be)   ; =22
    //   0x28d970cf698  C513333D2D3A4C12::72E318DB88E74E86(<Module>::8B9C7B12B1AE4949(0xffffffff9fe7a2be))
    //   0x28d970cf6c8  WBARRIER(0x28b826c0e30, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf6f0  <Module>::58ECCB512F2A43AC(0x4d5d7fb)   ; =18
    //   0x28d970cf700  C513333D2D3A4C12::72E318DB88E74E86(<Module>::58ECCB512F2A43AC(0x4d5d7fb))
    //   0x28d970cf730  WBARRIER(0x28b826c0e38, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf750  <Module>::F84FA79ABE6944BB(0x5276fb0c)   ; =17
    //   0x28d970cf760  C513333D2D3A4C12::72E318DB88E74E86(<Module>::F84FA79ABE6944BB(0x5276fb0c))
    //   0x28d970cf790  WBARRIER(0x28b826c0e40, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf7b0  C513333D2D3A4C12::F35317EDC902477E()
    //   0x28d970cf7f8  <Module>::3F57E81A62734AC2(0xffffffff9055686b)   ; =13
    //   0x28d970cf818  ALLOC_ARRAY(0x28d96647348, <Module>::3F57E81A62734AC2(0xffffffff9055686b))
    //   0x28d970cf840  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d970cf880  <Module>::F84FA79ABE6944BB(0x67cf2da4)   ; =1
    //   0x28d970cf8c8  <Module>::F84FA79ABE6944BB(0xffffffffab2d2f50)   ; =2
    //   0x28d970cf910  <Module>::390073C602714496(0xffffffff952677a0)   ; =3
    //   0x28d970cf950  <Module>::F84FA79ABE6944BB(0x7c40d633)   ; =4
    //   0x28d970cf990  <Module>::8B9C7B12B1AE4949(0x3358112e)   ; =5
    //   0x28d970cf9d0  <Module>::58ECCB512F2A43AC(0x3cb62d4f)   ; =6
    //   0x28d970cfa10  <Module>::3F57E81A62734AC2(0x3453c7d)   ; =7
    //   0x28d970cfa50  <Module>::390073C602714496(0x2414cb95)   ; =8
    //   0x28d970cfa90  <Module>::390073C602714496(0x79fb0890)   ; =9
    //   0x28d970cfad0  <Module>::F84FA79ABE6944BB(0x29714ace)   ; =10
    //   0x28d970cfb10  <Module>::58ECCB512F2A43AC(0x7eaee01f)   ; =11
    //   0x28d970cfb50  <Module>::390073C602714496(0x51211dad)   ; =12
    //   0x28d970cfb98  WBARRIER(0x28b826c0e98, <Module>::390073C602714496(0x51211dad))
    // 27 store(s):
    //   0x28d970cebc0  0x28b826c0dd0 <- 631D551E2DA64E7D::F3B62BCE1450413B(760EF57D5259421C::EBDC6C691E8048F7().f68)
    //   0x28d970cec48  0x28b826c0dd8 <- C513333D2D3A4C12::BC8FB48CDB314E53(0x28b826c0dd0.f0, <Module>::F84FA79ABE6944BB(0xffffffff9e9a3a9a))
    //   0x28d970ced18  0x28b826c0e50 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::390073C602714496(0x57ebf971))
    //   0x28d970ced80  0x28b826c0e58 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::58ECCB512F2A43AC(0xffffffff95b247b9))
    //   0x28d970cede0  0x28b826c0e60 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::58ECCB512F2A43AC(0x1b3c252f))
    //   0x28d970cee48  0x28b826c0e68 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::F84FA79ABE6944BB(0xfffffffff51db57b))
    //   0x28d970ceeb0  0x28b826c0e70 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::390073C602714496(0xffffffffb582cfce))
    //   0x28d970cef10  0x28b826c0e78 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::58ECCB512F2A43AC(0x7eaee01f))
    //   0x28d970cef80  0x28b826c0e48 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::8B9C7B12B1AE4949(0x6f6f10f5))
    //   0x28d970cf019  0x28b826c0df0 <- ALLOC_OBJECT(0x28d96647148)
    //   0x28d970cf198  0x28b826c0de0 <- <Module>::3F57E81A62734AC2(0xc0e952f)
    //   0x28d970cf241  0x28b826c0df8 <- ALLOC_ARRAY(0x28cc7f69d88, <Module>::3F57E81A62734AC2(0xffffffffaf43b39c))
    //   0x28d970cf2b8  0x28b826c0e80 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::8B9C7B12B1AE4949(0xfffffffff595f7cc))
    //   0x28d970cf318  0x28b826c0e88 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::390073C602714496(0x51ee1700))
    //   0x28d970cf380  0x28b826c0e90 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::3F57E81A62734AC2(0xffffffff94367c09))
    //   0x28d970cf429  0x28b826c0e00 <- ALLOC_ARRAY(0x28cc7f69d88, <Module>::8B9C7B12B1AE4949(0x50f4f95b))
    //   0x28d970cf498  0x28b826c0e08 <- ALLOC_ARRAY(0x28c85420a20, <Module>::58ECCB512F2A43AC(0x4173ceda))
    //   0x28d970cf50a  (ALLOC_OBJECT(0x28c86e9b260) add 0x10) <- 0x28cc75df380
    //   0x28d970cf533  0x28b826c0e10 <- ALLOC_OBJECT(0x28c86e9b260)
    //   0x28d970cf597  (ALLOC_OBJECT(0x28c86f73f50) add 0x10) <- 0x28cc75df260
    //   0x28d970cf5c0  0x28b826c0e18 <- ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d970cf61c  (ALLOC_OBJECT(0x28c86f73f50) add 0x10) <- 0x28cc75df260
    //   0x28d970cf645  0x28b826c0e20 <- ALLOC_OBJECT(0x28c86f73f50)
    //   0x28d970cf6a8  0x28b826c0e30 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::8B9C7B12B1AE4949(0xffffffff9fe7a2be))
    //   0x28d970cf710  0x28b826c0e38 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::58ECCB512F2A43AC(0x4d5d7fb))
    //   0x28d970cf770  0x28b826c0e40 <- C513333D2D3A4C12::72E318DB88E74E86(<Module>::F84FA79ABE6944BB(0x5276fb0c))
    //   0x28d970cfb7d  0x28b826c0e98 <- ALLOC_ARRAY(0x28d96647348, <Module>::3F57E81A62734AC2(0xffffffff9055686b))
    // returns: 0x28b826c0e98
    // string table refs:
    //   0x1be0  "PRT"
}
