// ============================================================
// token 0x060012c8   635EDF414A0B480B::51BF5B35C33D48FF
// native code: 0x28d95a05740  (2321 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method public hidebysig static
//   uint8[] '51BF5B35C33D48FF' (
//   uint8[] '',
//   int32 '',
//   int32 '',
//   uint8[] ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000004,060012cf,06000007,06000006,060012d6,060012d7,060012d0,060012d1,060012d2,060012d3,060012d4,060012d5,060012ce,06000003,060012d8,06000005,060013dd,060012cd
// native-strings: 
// ============================================================

public static byte 51BF5B35C33D48FF(byte arg0, int arg1, int arg2, byte arg3)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 55 call(s):
    //   0x28d95a057a8  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0x7fed0a36)
    //   0x28d95a05848  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0xffffffffb07686f7)
    //   0x28d95a05868  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x1207c0fb)
    //   0x28d95a05880  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x1207c0fb) xor 0x6008f71a))
    //   0x28d95a058a0  ALLOC_ARRAY(0x28c851b3688, <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x1207c0fb) xor 0x6008f71a)))
    //   0x28d95a058c0  635EDF414A0B480B::A7DD1AD94D624447(0x28cca2a25d0, ALLOC_ARRAY(0x28c851b3688, <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x1207c0fb) xor 0x6008f71a))))
    //   0x28d95a058f0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xb, 0xffffffffb6dbfebf)
    //   0x28d95a05918  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x6, 0xffffffff93b94ae1)
    //   0x28d95a05940  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x5, 0xffffffffee5c3701)
    //   0x28d95a05960  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), (0x5 xor 0x5), 0x7cdb9821)
    //   0x28d95a05978  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), (0x5 xor 0x5), 0x7cdb9821) xor 0x706107b4))
    //   0x28d95a059d8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, 0xffffffff8d3d5e66)
    //   0x28d95a059f0  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, 0xffffffff8d3d5e66) xor 0x3ddc504))
    //   0x28d95a05a20  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), (0x9 xor 0x9), 0x6378667d)
    //   0x28d95a05a38  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), (0x9 xor 0x9), 0x6378667d) xor 0x3ae12d15))
    //   0x28d95a05a68  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffffb47dfc45)
    //   0x28d95a05a80  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffffb47dfc45) xor 0xe9fc0daf))
    //   0x28d95a05ab0  635EDF414A0B480B::3DD12EADBA8841E2(ALLOC_ARRAY(0x28c851b3688, <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x1207c0fb) xor 0x6008f71a))), <Module>::390073C602714496((81D
    //   0x28d95a05ad8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, 0x78e0025e)
    //   0x28d95a05af0  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, 0x78e0025e) xor 0x2deff5ca))
    //   0x28d95a05b20  635EDF414A0B480B::D6C4FEFAF463435E((r12 xor r12), arg0, (movsxd arg1), (movsxd arg2))
    //   0x28d95a05b58  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x2, ((movsxd arg1) xor (movsxd arg1)))
    //   0x28d95a05b70  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x2, ((movsxd arg1) xor (movsxd arg1))) xor 0x706107b4))
    //   0x28d95a05bf8  635EDF414A0B480B::E4CCE6524FBB487F()
    //   0x28d95a05c08  635EDF414A0B480B::E284D1BC16924AA8(635EDF414A0B480B::E4CCE6524FBB487F())
    //   0x28d95a05c38  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffffe73636e2)
    //   0x28d95a05c50  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffffe73636e2) xor 0xd8b3e70))
    //   0x28d95a05c68  635EDF414A0B480B::96E92789EC224422(arg3)
    //   0x28d95a05c90  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x6, 0x3c3baef0)
    //   0x28d95a05ca8  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x6, 0x3c3baef0) xor 0x28f44043))
    //   0x28d95a05cc8  635EDF414A0B480B::6B65D404CEDB43CD(635EDF414A0B480B::96E92789EC224422(arg3), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x6, 0x3c3baef0) xor 0x28f44043)), ALLOC_ARRAY(0x28c85
    //   0x28d95a05ce8  635EDF414A0B480B::8E526FF03DD54532(635EDF414A0B480B::E284D1BC16924AA8(635EDF414A0B480B::E4CCE6524FBB487F()), <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffffe7363
    //   0x28d95a05d20  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0x375fe6e0)
    //   0x28d95a05d38  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0x375fe6e0) xor 0x2deff5ca))
    //   0x28d95a05d50  635EDF414A0B480B::66E7CCC2735C4766(635EDF414A0B480B::E284D1BC16924AA8(635EDF414A0B480B::E4CCE6524FBB487F()), (movsxd arg2))
    //   0x28d95a05d70  ALLOC_ARRAY(0x28c851b3688, (<Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0x375fe6e0) xor 0x2deff5ca)) add 635EDF414A0B480B::66E7CCC2735C4766(635EDF414A0B480B::E284D1BC16
    //   0x28d95a05db0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffd95ac88d, ((movsxd arg2) xor (movsxd arg2)))
    //   0x28d95a05dd0  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffd95ac88d, ((movsxd arg2) xor (movsxd arg2))) xor 0xf2762a90), 0x1, 0xffffffffd95ac88d, ((movsxd arg2) xor (movsxd arg2)))
    //   0x28d95a05df8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffc0a04bd8, ((movsxd arg2) xor (movsxd arg2)))
    //   0x28d95a05e18  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffc0a04bd8, ((movsxd arg2) xor (movsxd arg2))) xor 0x5c0e9faa), 0x1, 0xffffffffc0a04bd8, ((movsxd arg2) xor (movsxd arg2)))
    //   0x28d95a05e30  635EDF414A0B480B::1E04411B03A543EC(<Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffd95ac88d, ((movsxd arg2) xor (movsxd arg2))) xor 0xf2762a90), 0x1, 0xffffffffd95ac8
    //   0x28d95a05e40  ?(635EDF414A0B480B::1E04411B03A543EC(<Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffd95ac88d, ((movsxd arg2) xor (movsxd arg2))) xor 0xf2762a90), 0x1, 0xffffffffd95a
    //   0x28d95a05e70  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0x285dec2b)
    //   0x28d95a05e88  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0x285dec2b) xor 0x7064a975))
    //   0x28d95a05ea8  635EDF414A0B480B::3C9E8444E66E4C7D(635EDF414A0B480B::E284D1BC16924AA8(635EDF414A0B480B::E4CCE6524FBB487F()), ALLOC_ARRAY(0x28c851b3688, (<Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xfffffffffff
    //   0x28d95a05ee0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffffc3cd7858)
    //   0x28d95a05ef8  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffffc3cd7858) xor 0xe842a0b))
    //   0x28d95a05f58  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, (0xffffffffc3cd7858 xor 0xffffffffc3cd7858), ((movsxd arg2) xor (movsxd arg2)))
    //   0x28d95a05f70  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, (0xffffffffc3cd7858 xor 0xffffffffc3cd7858), ((movsxd arg2) xor (movsxd arg2))) xor 0x89d35d1c), 0x9, (0xffffffffc3cd7858 xor 0x
    //   0x28d95a05f90  Array::Resize((? add 0xffffffffffffffb0), (<Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, (0xffffffffc3cd7858 xor 0xffffffffc3cd7858), ((movsxd arg2) xor (movsxd arg2))) xor 0
    //   0x28d95a05fc8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), ((<Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, (0xffffffffc3cd7858 xor 0xffffffffc3cd7858), ((movsxd arg2) x
    //   0x28d95a05fe8  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), ((<Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, (0xffffffffc3cd7858 xor 0xfffff
    //   0x28d95a05ff8  635EDF414A0B480B::6EB92129F13D4BF6(<Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), ((<Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0
    //   0x28d95a06008  ?(635EDF414A0B480B::6EB92129F13D4BF6(<Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), ((<Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8),
    //   0x28d95a06028  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0xffffffffc3f53dce)
    // returns: ALLOC_ARRAY(0x28c851b3688, (<Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0x375fe6e0) xor 0x2deff5ca)) add 635EDF414A0B480B::66E7CCC2735C4766(635EDF41
}
