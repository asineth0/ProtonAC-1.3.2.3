// ============================================================
// token 0x06001030   1C1340EEE9C744F4::5439F9D450104626
// native code: 0x28d95a369f0  (3529 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private hidebysig
//   instance void '5439F9D450104626' (
//   valuetype [ProtonAC.System.Text.Json]System.Text.Json.JsonElement '',
//   string ''
//   ) cil managed noinlining
//   
// native-calls: 06000007,06000004,06000006,0600103c,06001030,06000003,0600103d,0600616e,0600103e,0600618e
// native-strings: 0x3650::,0x1d2c:\n
// ============================================================

 void 5439F9D450104626(JsonElement arg0, string arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 43 call(s):
    //   0x28d95a36ac0  get_ValueKind(arg0, arg0, arg1, ?)
    //   0x28d95a36b68  <Module>::3F57E81A62734AC2(0x3ca2d4c7)   ; =1
    //   0x28d95a36bb0  <Module>::390073C602714496(0x4da2eb80)   ; =2
    //   0x28d95a36be8  EnumerateObject(arg0, (? add 0xfffffffffffffee8), arg1, ?)
    //   0x28d95a36d08  get_Current((? add 0xfffffffffffffed0), (? add 0xffffffffffffff00), arg1, ?)
    //   0x28d95a36d20  get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?)
    //   0x28d95a36d70  <Module>::58ECCB512F2A43AC(0x5e51990d)   ; ":"
    //   0x28d95a36d90  1C1340EEE9C744F4::1A183CE2001C4D0D(arg1, <Module>::58ECCB512F2A43AC(0x5e51990d), get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?))
    //   0x28d95a36dc8  MoveNext((? add 0xfffffffffffffed0), <Module>::58ECCB512F2A43AC(0x5e51990d), get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?)
    //   0x28d95a36e58  1C1340EEE9C744F4::5439F9D450104626(this, (? add 0xffffffffffffff70), get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?))
    //   0x28d95a36e82  sub_28d95a36eb0(this, (? add 0xffffffffffffff70), get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?)
    //   0x28d95a36ea8  sub_28b82785f1f(this, (? add 0xffffffffffffff70), get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?)
    //   0x28d95a36ef0  EnumerateArray(arg0, (? add 0xffffffffffffff80), get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?)
    //   0x28d95a36f08  ALLOC_OBJECT(0x28d961936f0)
    //   0x28d95a36f40  WBARRIER((ALLOC_OBJECT(0x28d961936f0) add 0x10), S[rbp-80])
    //   0x28d95a36f78  ToList(ALLOC_OBJECT(0x28d961936f0), S[rbp-70], get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?)
    //   0x28d95a36fd8  ALLOC_OBJECT(0x28d961be310)
    //   0x28d95a37010  WBARRIER((ALLOC_OBJECT(0x28d961be310) add 0x20), ToList(ALLOC_OBJECT(0x28d961936f0), S[rbp-70], get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?))
    //   0x28d95a37090  WBARRIER(0x28d0351cce8, 0x28d961be3e0.f28)
    //   0x28d95a370b8  All(ToList(ALLOC_OBJECT(0x28d961936f0), S[rbp-70], get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?), ALLOC_OBJECT(0x28d961be310), get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00)
    //   0x28d95a37160  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd, ((((((((((0x20f18d34 neg 0x1) sub 0xe11a677bc7a7156a) neg 0x1) imul 0xf06e1719) imul 0xd8abf2a1) imul 0x2d2d96fb) not 0x1) not 0x1) div 0x5) mod 0x5), get_Name((? add 0xffff
    //   0x28d95a371a8  <Module>::3F57E81A62734AC2(0x4f376c94)   ; "\n"
    //   0x28d95a37218  ALLOC_OBJECT(0x28d961be4d0)
    //   0x28d95a37250  WBARRIER((ALLOC_OBJECT(0x28d961be4d0) add 0x20), ToList(ALLOC_OBJECT(0x28d961936f0), S[rbp-70], get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?))
    //   0x28d95a372d0  WBARRIER(0x28d0351ccf0, 0x28d961be5a0.f28)
    //   0x28d95a37300  Select(ToList(ALLOC_OBJECT(0x28d961936f0), S[rbp-70], get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?), ALLOC_OBJECT(0x28d961be4d0), get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff
    //   0x28d95a37318  1C1340EEE9C744F4::20C4CF0F6C514057(<Module>::3F57E81A62734AC2(0x4f376c94), Select(ToList(ALLOC_OBJECT(0x28d961936f0), S[rbp-70], get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?), ALLOC_OBJECT(0
    //   0x28d95a37338  set_Item(this.f10, arg1, 1C1340EEE9C744F4::20C4CF0F6C514057(<Module>::3F57E81A62734AC2(0x4f376c94), Select(ToList(ALLOC_OBJECT(0x28d961936f0), S[rbp-70], get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1,
    //   0x28d95a373a8  List`1::GetEnumerator(ToList(ALLOC_OBJECT(0x28d961936f0), S[rbp-70], get_Name((? add 0xffffffffffffff00), (? add 0xffffffffffffff00), arg1, ?), ?), (? add 0xffffffffffffff18), 1C1340EEE9C744F4::20C4CF0F6C514057(<Module>::3
    //   0x28d95a37480  <Module>::390073C602714496(0xffffffffb1e97daf, ((((((((((0xffffffffbf01854a neg 0x1) sub 0xe11a677bc7a7156a) neg 0x1) imul 0xf06e1719) imul 0xd8abf2a1) imul 0x2d2d96fb) not 0x1) not 0x1) div 0x5) mod 0x5), 1C1340EEE9C744
    //   0x28d95a374c0  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b), ((((((((((0xffffffffbf01854a neg 0x1) sub 0xe11a677bc7a7156a) neg 0x1) imul 0xf06e1719) imul 0xd8abf2a1) imul 0x2d2d96fb) not 0x1) not 0x1) div 0x5) mod 0x5), 1C1340EEE9C74
    //   0x28d95a374f0  ALLOC_OBJECT(0x28c852328c8)
    //   0x28d95a37510  1C1340EEE9C744F4::0A4A56BCEE094C42(<Module>::390073C602714496(0xffffffffb1e97daf, ((((((((((0xffffffffbf01854a neg 0x1) sub 0xe11a677bc7a7156a) neg 0x1) imul 0xf06e1719) imul 0xd8abf2a1) imul 0x2d2d96fb) not 0x1) not 0x1
    //   0x28d95a37558  1C1340EEE9C744F4::5439F9D450104626(this, (? add 0xffffffffffffff98), 1C1340EEE9C744F4::0A4A56BCEE094C42(<Module>::390073C602714496(0xffffffffb1e97daf, ((((((((((0xffffffffbf01854a neg 0x1) sub 0xe11a677bc7a7156a) neg 0x1
    //   0x28d95a37580  Enumerator::MoveNext((? add 0xffffffffffffff18), (? add 0xffffffffffffff98), 1C1340EEE9C744F4::0A4A56BCEE094C42(<Module>::390073C602714496(0xffffffffb1e97daf, ((((((((((0xffffffffbf01854a neg 0x1) sub 0xe11a677bc7a7156a)
    //   0x28d95a375bd  sub_28d95a375e8((? add 0xffffffffffffff18), (? add 0xffffffffffffff98), 1C1340EEE9C744F4::0A4A56BCEE094C42(<Module>::390073C602714496(0xffffffffb1e97daf, ((((((((((0xffffffffbf01854a neg 0x1) sub 0xe11a677bc7a7156a) neg 
    //   0x28d95a375e0  sub_28b82785f1f((? add 0xffffffffffffff18), (? add 0xffffffffffffff98), 1C1340EEE9C744F4::0A4A56BCEE094C42(<Module>::390073C602714496(0xffffffffb1e97daf, ((((((((((0xffffffffbf01854a neg 0x1) sub 0xe11a677bc7a7156a) neg 
    //   0x28d95a376b8  get_ValueKind(arg0, ((((((((((0xffffffffb9c9b059 neg 0x1) sub 0xe11a677bc7a7156a) neg 0x1) imul 0xf06e1719) imul 0xd8abf2a1) imul 0x2d2d96fb) not 0x1) not 0x1) div 0x3) mod 0x3), 1C1340EEE9C744F4::0A4A56BCEE094C42(<Module>
    //   0x28d95a376f0  <Module>::8B9C7B12B1AE4949((movsxd 0xfebf202))   ; =7
    //   0x28d95a37710  ToString(arg0, ((((((((((0xffffffffb9c9b059 neg 0x1) sub 0xe11a677bc7a7156a) neg 0x1) imul 0xf06e1719) imul 0xd8abf2a1) imul 0x2d2d96fb) not 0x1) not 0x1) div 0x3) mod 0x3), 1C1340EEE9C744F4::0A4A56BCEE094C42(<Module>::390
    //   0x28d95a37748  set_Item(this.f10, arg1, 0x28c840f0fe0, ?)
    //   0x28d95a37790  THROW(0x162, 0x56b)
    //   0x28d95a377a8  THROW(0xf3, 0x5b4)
    // 18 store(s):
    //   0x28d95a36f27  (ALLOC_OBJECT(0x28d961936f0) add 0x10) <- S[rbp-80]
    //   0x28d95a36f60  ((ALLOC_OBJECT(0x28d961936f0) add 0x10) add 0x8) <- S[rbp-78]
    //   0x28d95a36f6b  (((ALLOC_OBJECT(0x28d961936f0) add 0x10) add 0x8) add 0x8) <- S[rbp-70]
    //   0x28d95a36ff5  ALLOC_OBJECT(0x28d961be310) <- 0x28ccb7badb0
    //   0x28d95a3702b  ALLOC_OBJECT(0x28d961be310) <- 0x28ccd8df738
    //   0x28d95a37039  ALLOC_OBJECT(0x28d961be310) <- 0x28d961be3d8
    //   0x28d95a3704b  ALLOC_OBJECT(0x28d961be310) <- 0x28d961be3e0.f28
    //   0x28d95a37053  ALLOC_OBJECT(0x28d961be310) <- 0x28d961be3e0.f20
    //   0x28d95a37057  ALLOC_OBJECT(0x28d961be310) <- 0x0
    //   0x28d95a3706f  0x28d0351cce8 <- ALLOC_OBJECT(0x28d961be310)
    //   0x28d95a37235  ALLOC_OBJECT(0x28d961be4d0) <- 0x28ccb7badb0
    //   0x28d95a3726b  ALLOC_OBJECT(0x28d961be4d0) <- 0x28ccd8df7c8
    //   0x28d95a37279  ALLOC_OBJECT(0x28d961be4d0) <- 0x28d961be598
    //   0x28d95a3728b  ALLOC_OBJECT(0x28d961be4d0) <- 0x28d961be5a0.f28
    //   0x28d95a37293  ALLOC_OBJECT(0x28d961be4d0) <- 0x28d961be5a0.f20
    //   0x28d95a37297  ALLOC_OBJECT(0x28d961be4d0) <- 0x0
    //   0x28d95a372af  0x28d0351ccf0 <- ALLOC_OBJECT(0x28d961be4d0)
    //   0x28d95a374f6  ALLOC_OBJECT(0x28c852328c8) <- (movsxd <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd, ((((((((((0x20f18d34 neg 0x1) sub 0xe11a677bc7a7156a) neg 0x1) imul 0xf06e1719) imul 0xd8abf2a1) imul 0x2
    // returns: set_Item(this.f10, arg1, 0x28c840f0fe0, ?)
    // string table refs:
    //   0x3650  ":"
    //   0x1d2c  "\n"
}
