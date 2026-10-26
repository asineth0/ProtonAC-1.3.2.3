// ============================================================
// token 0x06001022   9E6941D2442741AE::DF274E6B0CD241BF
// native code: 0x28d95a1c920  (1108 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   class [ProtonAC.Microsoft.Extensions.Configuration.Abstractions]Microsoft.Extensions.Configuration.IConfiguration DF274E6B0CD241BF (
//   string ''
//   ) cil managed noinlining
//   
// native-calls: 06001024,06000003,06000005,06001025,06001026,06001027,06000006,06001023,06001028,06001029,0600102a,0600102b
// native-strings: 0x708:
// ============================================================

public static Microsoft.Extensions.Configuration.IConfiguration DF274E6B0CD241BF(string arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 17 call(s):
    //   0x28d95a1c970  9E6941D2442741AE::08B5C347E79C43A2(arg0)
    //   0x28d95a1ca18  <Module>::8B9C7B12B1AE4949((movsxd 0x1cc89d11), (((((((((((movsxd 0x6f3ad297) imul 0x2813797d) imul 0x9319e2df) neg 0x1) imul 0xaea1b71d) not 0x1) not 0x1) xor 0x9a63ac0d) sub 0x9cf158ae) div 0x3) mod 0x3), ?, ?)
    //   0x28d95a1ca48  <Module>::F84FA79ABE6944BB(0x2c0b2191, (((((((((((movsxd 0x6f3ad297) imul 0x2813797d) imul 0x9319e2df) neg 0x1) imul 0xaea1b71d) not 0x1) not 0x1) xor 0x9a63ac0d) sub 0x9cf158ae) div 0x3) mod 0x3), ?, ?)
    //   0x28d95a1ca60  9E6941D2442741AE::F40A54269E334090(<Module>::8B9C7B12B1AE4949((movsxd 0x1cc89d11), (((((((((((movsxd 0x6f3ad297) imul 0x2813797d) imul 0x9319e2df) neg 0x1) imul 0xaea1b71d) not 0x1) not 0x1) xor 0x9a63ac0d) sub 0x9cf158a
    //   0x28d95a1ca70  ?(9E6941D2442741AE::F40A54269E334090(<Module>::8B9C7B12B1AE4949((movsxd 0x1cc89d11), (((((((((((movsxd 0x6f3ad297) imul 0x2813797d) imul 0x9319e2df) neg 0x1) imul 0xaea1b71d) not 0x1) not 0x1) xor 0x9a63ac0d) sub 0x9cf15
    //   0x28d95a1caa8  9E6941D2442741AE::ECCB2EFCC2C94155(arg0, (movsxd 0x0))
    //   0x28d95a1cac8  ALLOC_OBJECT(0x28cc77b46f0)
    //   0x28d95a1cae0  .ctor(ALLOC_OBJECT(0x28cc77b46f0), (movsxd 0x0), ?, ?)
    //   0x28d95a1cb80  9E6941D2442741AE::75FF290933E74119(9E6941D2442741AE::ECCB2EFCC2C94155(arg0, (movsxd 0x0)))
    //   0x28d95a1cbb8  <Module>::58ECCB512F2A43AC(0x2943f05b)   ; ""
    //   0x28d95a1cbe8  9E6941D2442741AE::41B34BCEE1A447D2((? add 0xffffffffffffffc0), <Module>::58ECCB512F2A43AC(0x2943f05b), ALLOC_OBJECT(0x28cc77b46f0))
    //   0x28d95a1cc08  9E6941D2442741AE::DF34DCCA33974DEC()
    //   0x28d95a1cc20  9E6941D2442741AE::DBF2C600A1CF4FBD(9E6941D2442741AE::DF34DCCA33974DEC(), ALLOC_OBJECT(0x28cc77b46f0))
    //   0x28d95a1cc30  9E6941D2442741AE::667C00DEDEC74084(9E6941D2442741AE::DBF2C600A1CF4FBD(9E6941D2442741AE::DF34DCCA33974DEC(), ALLOC_OBJECT(0x28cc77b46f0)))
    //   0x28d95a1cc5e  sub_28d95a1cc88(9E6941D2442741AE::DBF2C600A1CF4FBD(9E6941D2442741AE::DF34DCCA33974DEC(), ALLOC_OBJECT(0x28cc77b46f0)), ALLOC_OBJECT(0x28cc77b46f0), ALLOC_OBJECT(0x28cc77b46f0), ?)
    //   0x28d95a1cc80  sub_28b82785f1f(9E6941D2442741AE::DBF2C600A1CF4FBD(9E6941D2442741AE::DF34DCCA33974DEC(), ALLOC_OBJECT(0x28cc77b46f0)), ALLOC_OBJECT(0x28cc77b46f0), ALLOC_OBJECT(0x28cc77b46f0), ?)
    //   0x28d95a1cd38  9E6941D2442741AE::DCA4C86F47EC4593(9E6941D2442741AE::ECCB2EFCC2C94155(arg0, (movsxd 0x0)))
    // returns: 9E6941D2442741AE::667C00DEDEC74084(9E6941D2442741AE::DBF2C600A1CF4FBD(9E6941D2442741AE::DF34DCCA33974DEC(), ALLOC_OBJECT(0x28cc77b46f0)))
    // string table refs:
    //   0x708  ""
}
