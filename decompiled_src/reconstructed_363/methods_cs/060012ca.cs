// ============================================================
// token 0x060012ca   635EDF414A0B480B::95DB8685DB6E479C
// native code: 0x28d95a06900  (2505 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method public hidebysig static
//   uint8[] '95DB8685DB6E479C' (
//   uint8[] '',
//   int32 '',
//   int32 '',
//   uint8[] ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000005,06000007,060012d6,06000006,060012d7,060012d8,060012d5,060013dd,06000003,060012ce,06000004,060012da,060012d0,060012d1,060012d2,060012d3,060012d4,060012cd
// native-strings: 
// ============================================================

public static byte 95DB8685DB6E479C(byte arg0, int arg1, int arg2, byte arg3)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 56 call(s):
    //   0x28d95a06968  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0x566121dd)
    //   0x28d95a06a08  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), ((((0xffffffffa0c1e112 sub (((((((0xd05eaf1 not 0x1) imul 0xb08a55cf) imul 0xa44d4b4d) imul 0x53c3999b) neg 0x1) sub 0x1e0d48f662c3ae3) sub 0xaf16944e)) div 
    //   0x28d95a06a20  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), ((((0xffffffffa0c1e112 sub (((((((0xd05eaf1 not 0x1) imul 0xb08a55cf) imul 0xa44d4b4d) imul 0x53c3999b) neg 0x1) sub 0x1e0d48f662
    //   0x28d95a06a40  ALLOC_ARRAY(0x28c851b3688, <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), ((((0xffffffffa0c1e112 sub (((((((0xd05eaf1 not 0x1) imul 0xb08a55cf) imul 0xa44d4b4d) imul 0x53c3999b
    //   0x28d95a06a68  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x2, 0x7b7496d7)
    //   0x28d95a06a80  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x2, 0x7b7496d7) xor 0xca294efc))
    //   0x28d95a06ab0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffff8d928ea4)
    //   0x28d95a06ac8  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffff8d928ea4) xor 0xac292fb3))
    //   0x28d95a06af0  635EDF414A0B480B::3DD12EADBA8841E2(arg0, (movsxd arg1), ALLOC_ARRAY(0x28c851b3688, <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), ((((0xffffffffa0c1e112 sub (((((((0xd05eaf1 not 0x
    //   0x28d95a06b30  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffff851e9a08)
    //   0x28d95a06b48  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffff851e9a08) xor 0xe2293d34))
    //   0x28d95a06b88  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x2, 0x1fa977fd)
    //   0x28d95a06ba0  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x2, 0x1fa977fd) xor 0x9fb4a7dc))
    //   0x28d95a06bd0  635EDF414A0B480B::D6C4FEFAF463435E((rbx xor rbx), arg0, ((movsxd arg1) add <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffff851e9a08) xor 0xe2293d34))), (r12 xor r12))
    //   0x28d95a06bf8  635EDF414A0B480B::3C9E8444E66E4C7D((rbx xor rbx), (rbx xor rbx), 635EDF414A0B480B::D6C4FEFAF463435E((rbx xor rbx), arg0, ((movsxd arg1) add <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffff
    //   0x28d95a06c60  635EDF414A0B480B::66E7CCC2735C4766((rbx xor rbx), (r12 xor r12))
    //   0x28d95a06c80  ALLOC_ARRAY(0x28c851b3688, 635EDF414A0B480B::66E7CCC2735C4766((rbx xor rbx), (r12 xor r12)))
    //   0x28d95a06cb8  Array::Resize((? add 0xffffffffffffffb0), (635EDF414A0B480B::D6C4FEFAF463435E((rbx xor rbx), arg0, ((movsxd arg1) add <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffff
    //   0x28d95a06d48  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0xffffffff99732f83, (r12 xor r12))
    //   0x28d95a06d68  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0xffffffff99732f83, (r12 xor r12)) xor 0x4428c5a), 0x8, 0xffffffff99732f83, (r12 xor r12))
    //   0x28d95a06d90  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xa, 0x430bb53d, (r12 xor r12))
    //   0x28d95a06db0  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xa, 0x430bb53d, (r12 xor r12)) xor 0xc6f599ff), 0xa, 0x430bb53d, (r12 xor r12))
    //   0x28d95a06dc8  635EDF414A0B480B::1E04411B03A543EC(<Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0xffffffff99732f83, (r12 xor r12)) xor 0x4428c5a), 0x8, 0xffffffff99732f83, (r12 xor r12)
    //   0x28d95a06dd8  ?(635EDF414A0B480B::1E04411B03A543EC(<Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0xffffffff99732f83, (r12 xor r12)) xor 0x4428c5a), 0x8, 0xffffffff99732f83, (r12 xor r1
    //   0x28d95a06e00  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x2, 0xffffffffb724f0ce)
    //   0x28d95a06e18  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x2, 0xffffffffb724f0ce) xor 0xff50b91e))
    //   0x28d95a06e60  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xa, 0xffffffffb34e1c6d, (r12 xor r12))
    //   0x28d95a06e80  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xa, 0xffffffffb34e1c6d, (r12 xor r12)) xor 0xd29aec08), 0xa, 0xffffffffb34e1c6d, (r12 xor r12))
    //   0x28d95a06ea8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x761faf57, (r12 xor r12))
    //   0x28d95a06ec8  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x761faf57, (r12 xor r12)) xor 0xad7f711d), 0x4, 0x761faf57, (r12 xor r12))
    //   0x28d95a06ee0  635EDF414A0B480B::4D4ACAAE320E45CA(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xa, 0xffffffffb34e1c6d, (r12 xor r12)) xor 0xd29aec08), 0xa, 0xffffffffb34e1c6d, (r12 xor r12
    //   0x28d95a06ef0  ?(635EDF414A0B480B::4D4ACAAE320E45CA(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xa, 0xffffffffb34e1c6d, (r12 xor r12)) xor 0xd29aec08), 0xa, 0xffffffffb34e1c6d, (r12 xor r
    //   0x28d95a06f00  635EDF414A0B480B::E4CCE6524FBB487F()
    //   0x28d95a06f10  635EDF414A0B480B::E284D1BC16924AA8(635EDF414A0B480B::E4CCE6524FBB487F())
    //   0x28d95a06f50  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0xffffffffc6369db5)
    //   0x28d95a06f78  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x3, 0xffffffffa6db0795)
    //   0x28d95a06fa0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x5, 0xffffffffc2745fab)
    //   0x28d95a06fc0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xa, 0x4a42ebb)
    //   0x28d95a06fd8  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xa, 0x4a42ebb) xor 0xfee8ffaa))
    //   0x28d95a07020  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), (0xa xor 0xa), 0xffffffffdc91fbb6)
    //   0x28d95a07038  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), (0xa xor 0xa), 0xffffffffdc91fbb6) xor 0x58340e1a))
    //   0x28d95a07080  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x5, 0xfffffffff84cc3a4)
    //   0x28d95a07098  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x5, 0xfffffffff84cc3a4) xor 0xc5042f2a))
    //   0x28d95a070b0  635EDF414A0B480B::96E92789EC224422(arg3)
    //   0x28d95a070e0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffcedbf094)
    //   0x28d95a070f8  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffcedbf094) xor 0x1672e05c))
    //   0x28d95a07118  635EDF414A0B480B::6B65D404CEDB43CD(635EDF414A0B480B::96E92789EC224422(arg3), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x1, 0xffffffffcedbf094) xor 0x1672e05c)), ALLOC_ARRAY
    //   0x28d95a07138  635EDF414A0B480B::8E526FF03DD54532(635EDF414A0B480B::E284D1BC16924AA8(635EDF414A0B480B::E4CCE6524FBB487F()), <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x5, 0xfffffffff84cc
    //   0x28d95a07170  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x4c75f27d, ((r12 xor r12) xor (r12 xor r12)))
    //   0x28d95a07190  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x4c75f27d, ((r12 xor r12) xor (r12 xor r12))) xor 0x33ab3746), 0x4, 0x4c75f27d, ((r12 xor r12) xor (r12 xor r12)))
    //   0x28d95a071a0  635EDF414A0B480B::6EB92129F13D4BF6(<Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x4c75f27d, ((r12 xor r12) xor (r12 xor r12))) xor 0x33ab3746), 0x4, 0x4c75f27d, ((r12 xo
    //   0x28d95a071b0  ?(635EDF414A0B480B::6EB92129F13D4BF6(<Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0x4c75f27d, ((r12 xor r12) xor (r12 xor r12))) xor 0x33ab3746), 0x4, 0x4c75f27d, ((r12 
    //   0x28d95a07208  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), (0x4 xor 0x4), (0x4c75f27d xor 0x4c75f27d))
    //   0x28d95a07220  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), (0x4 xor 0x4), (0x4c75f27d xor 0x4c75f27d)) xor 0x14c6e53b))
    //   0x28d95a07278  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0x3df698c8)
    //   0x28d95a072a0  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0x1f266c59)
    // returns: ALLOC_ARRAY(0x28c851b3688, 635EDF414A0B480B::66E7CCC2735C4766((rbx xor rbx), (r12 xor r12)))
}
