// ============================================================
// token 0x0600102f   1C1340EEE9C744F4::.ctor
// native code: 0x28d95a36370  (547 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   string ''
//   ) cil managed noinlining
//   
// native-calls: 06001036,06000007,06000006,06001037,06001038,06001039,0600103a,06001030
// native-strings: 
// ============================================================

public  void .ctor(string arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 14 call(s):
    //   0x28d95a363b0  1C1340EEE9C744F4::358A7731B2814A47(arg0)
    //   0x28d95a363d8  <Module>::3F57E81A62734AC2(0x4cf4662a, arg0, ?, ?)
    //   0x28d95a36400  <Module>::58ECCB512F2A43AC(0xffffffffbf9a87b8, arg0, ?, ?)
    //   0x28d95a36418  1C1340EEE9C744F4::9D8E2D6009B74334(<Module>::3F57E81A62734AC2(0x4cf4662a, arg0, ?, ?), <Module>::58ECCB512F2A43AC(0xffffffffbf9a87b8, arg0, ?, ?), ?, ?)
    //   0x28d95a36428  ?(1C1340EEE9C744F4::9D8E2D6009B74334(<Module>::3F57E81A62734AC2(0x4cf4662a, arg0, ?, ?), <Module>::58ECCB512F2A43AC(0xffffffffbf9a87b8, arg0, ?, ?), ?, ?), <Module>::58ECCB512F2A43AC(0xffffffffbf9a87b8, arg0, ?, ?), ?, ?)
    //   0x28d95a36440  1C1340EEE9C744F4::AEA352792EEF4D90()
    //   0x28d95a36460  ALLOC_OBJECT(0x28cc77b46f0)
    //   0x28d95a36478  .ctor(ALLOC_OBJECT(0x28cc77b46f0), 1C1340EEE9C744F4::AEA352792EEF4D90(), ?, ?)
    //   0x28d95a36498  WBARRIER(this+10, 1C1340EEE9C744F4::AEA352792EEF4D90())
    //   0x28d95a364d0  1C1340EEE9C744F4::0D7AF6A54FFB400B(arg0, (movsxd 0x0))
    //   0x28d95a364f0  1C1340EEE9C744F4::A274ED7894D945C6(1C1340EEE9C744F4::0D7AF6A54FFB400B(arg0, (movsxd 0x0)))
    //   0x28d95a36520  1C1340EEE9C744F4::5439F9D450104626(this, (? add 0xffffffffffffffd0), (xor ?))
    //   0x28d95a3652f  sub_28d95a36555(this, (? add 0xffffffffffffffd0), (xor ?), ?)
    //   0x28d95a36550  sub_28b82785f1f(this, (? add 0xffffffffffffffd0), (xor ?), ?)
    // 1 store(s):
    //   0x28d95a36487  this+10 <- ALLOC_OBJECT(0x28cc77b46f0)
    // returns: sub_28b82785f1f(this, (? add 0xffffffffffffffd0), (xor ?), ?)
}
