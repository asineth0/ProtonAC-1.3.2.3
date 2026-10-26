// ============================================================
// token 0x06000cfe   85399D7C08B94D76::2A2378566E004678
// native code: 0x28d95834870  (2307 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class C0225ABF72C4425E '2A2378566E004678' () cil managed noinlining
//   
// native-calls: 06000d02,06000d03,06000003,06000d0a,06000004,06000d0b,06000d0c,06000006,06000d0d
// native-strings: 0x24c4:*.log
// ============================================================

public  C0225ABF72C4425E 2A2378566E004678()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 13 call(s):
    //   0x28d958348f8  85399D7C08B94D76::80E329AF727A424E(this.f10)
    //   0x28d95834918  85399D7C08B94D76::EC4FC2925D364DEA(this.f10)
    //   0x28d95834c18  <Module>::8B9C7B12B1AE4949((movsxd 0xeb916659))   ; "*.log"
    //   0x28d95834c30  85399D7C08B94D76::FCED451CB19D4B23(this.f10, <Module>::8B9C7B12B1AE4949((movsxd 0xeb916659)))
    //   0x28d95834c48  get_Now(this.f10, <Module>::8B9C7B12B1AE4949((movsxd 0xeb916659)), ?, ?)
    //   0x28d95834cb8  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0))   ; =-1
    //   0x28d95834cd0  AddMonths((? add 0xffffffffffffff70), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0)), ?, ?)
    //   0x28d95834d90  <Module>::390073C602714496((movsxd 0x7f132d63))   ; =0
    //   0x28d95834dd8  85399D7C08B94D76::B882850FAFDD462C(85399D7C08B94D76::FCED451CB19D4B23(this.f10, <Module>::8B9C7B12B1AE4949((movsxd 0xeb916659)))+(movsxd (movsxd <Module>::390073C602714496((movsxd 0x7f132d63))))*8+20.f0, ((((((movsxd 0xe
    //   0x28d95834f00  85399D7C08B94D76::0EDB60F16FA14BB5(85399D7C08B94D76::FCED451CB19D4B23(this.f10, <Module>::8B9C7B12B1AE4949((movsxd 0xeb916659)))+(movsxd (movsxd <Module>::390073C602714496((movsxd 0x7f132d63))))*8+20.f0, ((((((movsxd 0x5
    //   0x28d95835080  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b), ((((((movsxd 0x59b08b9) sub 0xa13493c8) sub 0x172cf8a0) xor 0xffffffff6cb4943d) div 0x3) mod 0x3), ?, ?)
    //   0x28d95835150  85399D7C08B94D76::6F61788E0AA44245(this.f10)
    //   0x28d95835170  THROW(0x146, 0x3c1)
    // returns: 85399D7C08B94D76::6F61788E0AA44245(this.f10)
    // string table refs:
    //   0x24c4  "*.log"
}
