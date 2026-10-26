// ============================================================
// token 0x060012ea   4CC1FD78B203468B::09BDB4F5D8BE4608
// native code: 0x28d95a092c0  (378 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig static
//   uint64 '09BDB4F5D8BE4608' (
//   uint64 '',
//   int32 ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000005,06000006
// native-strings: 
// ============================================================

static ulong 09BDB4F5D8BE4608(ulong arg0, int arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 9 call(s):
    //   0x28d95a09308  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffe0), 0x3103a96e)
    //   0x28d95a09328  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe0), (0x3103a96e xor 0x3103a96e), 0xffffffffc52f8c8f)
    //   0x28d95a09340  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe0), (0x3103a96e xor 0x3103a96e), 0xffffffffc52f8c8f) xor 0xe57b440b))
    //   0x28d95a09368  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe0), 0x2, 0x67c3e14f)
    //   0x28d95a09380  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe0), 0x2, 0x67c3e14f) xor 0xcfee76b0))
    //   0x28d95a093b0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe0), 0x4, 0x7e018414)
    //   0x28d95a093c8  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe0), 0x4, 0x7e018414) xor 0xd1ee550))
    //   0x28d95a093f8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe0), 0x9, 0xffffffffe4159053)
    //   0x28d95a09410  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe0), 0x9, 0xffffffffe4159053) xor 0xdfbe02f0))
    // returns: ((arg0 shr ((arg1 and <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe0), (0x3103a96e xor 0x3103a96e), 0xffffffffc52f8c8f) xor 0xe57b440b))) and <Module>::58ECCB512F
}
