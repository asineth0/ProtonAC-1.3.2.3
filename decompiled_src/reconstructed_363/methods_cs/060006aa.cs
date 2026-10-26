// ============================================================
// token 0x060006aa   C6338AE87AE0450D::7F2B64E9831F4FB0
// native code: 0x28d9723e2c0  (2078 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method public hidebysig virtual
//   instance void '7F2B64E9831F4FB0' () cil managed noinlining
//   
// native-calls: 06001056,06000003,06000004,06000005,060006ab,06000007,06000006,060006b5,060006b6,060006b7
// native-strings: 0x1730:Detections:Analysis:ChatGuard:StringSimilarity:Enabled,0x198c:Detections:Analysis:ChatGuard:ChatsForCheck,0x19bc:GLOBAL,LOCAL,0x18e8:Detections:Analysis:ChatGuard:AntiLinks:Enabled,0x191c:Detections:Analysis:ChatGuard:AntiBadWords:Enabled,0x1954:Detections:Analysis:ChatGuard:CharWhitelist:Enabled,0x176c:Detections:Analysis:ChatGuard:StringSimilarity:Percentage,0x17b4:Detections:Analysis:ChatGuard:StringSimilarity:Expiration,0x17f4:Detections:Analysis:ChatGuard:StringSimilarity:History,0x1830:Detections:Analysis:ChatGuard:StringSimilarity:Allowed,0x186c:Detections:Analysis:ChatGuard:MessageLength:Enabled,0x18a4:Detections:Analysis:ChatGuard:MessageLength:MaxLength
// ============================================================

public  void 7F2B64E9831F4FB0()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 58 call(s):
    //   0x28d9723e2f8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e320  <Module>::8B9C7B12B1AE4949(0x3297746e)   ; "Detections:Analysis:ChatGuard:StringSimilarity:Enabled"
    //   0x28d9723e340  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d9723e358  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0x3297746e), <Module>::390073C602714496(0x7f132d63), ?)
    //   0x28d9723e3e8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e410  <Module>::F84FA79ABE6944BB(0x3bfc17f3)   ; "Detections:Analysis:ChatGuard:ChatsForCheck"
    //   0x28d9723e438  <Module>::F84FA79ABE6944BB(0x46a8313f)   ; "GLOBAL,LOCAL"
    //   0x28d9723e458  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::F84FA79ABE6944BB(0x3bfc17f3), <Module>::F84FA79ABE6944BB(0x46a8313f), ?)
    //   0x28d9723e468  C6338AE87AE0450D::3A17FD50073842B9(GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::F84FA79ABE6944BB(0x3bfc17f3), <Module>::F84FA79ABE6944BB(0x46a8313f), ?))
    //   0x28d9723e498  WBARRIER(0x28c840e83e8, <Module>::F84FA79ABE6944BB(0x3bfc17f3))
    //   0x28d9723e4b8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e4e0  <Module>::8B9C7B12B1AE4949(0x3f94a1cc)   ; "Detections:Analysis:ChatGuard:AntiLinks:Enabled"
    //   0x28d9723e500  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d9723e518  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0x3f94a1cc), <Module>::390073C602714496(0x7f132d63), ?)
    //   0x28d9723e538  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e560  <Module>::390073C602714496(0xffffffffcd979931)   ; "Detections:Analysis:ChatGuard:AntiBadWords:Enabled"
    //   0x28d9723e580  <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd)   ; =0
    //   0x28d9723e598  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0xffffffffcd979931), <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd), ?)
    //   0x28d9723e5b8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e5e0  <Module>::3F57E81A62734AC2(0xffffffff946ce336)   ; "Detections:Analysis:ChatGuard:CharWhitelist:Enabled"
    //   0x28d9723e600  <Module>::F84FA79ABE6944BB(0x535d8515)   ; =0
    //   0x28d9723e618  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0xffffffff946ce336), <Module>::F84FA79ABE6944BB(0x535d8515), ?)
    //   0x28d9723e648  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e670  <Module>::390073C602714496(0x7225c9d)   ; "Detections:Analysis:ChatGuard:StringSimilarity:Percentage"
    //   0x28d9723e690  <Module>::58ECCB512F2A43AC(0x1894aa32)   ; =0
    //   0x28d9723e6a8  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0x7225c9d), <Module>::F84FA79ABE6944BB(0x535d8515), ?)
    //   0x28d9723e6c8  <Module>::390073C602714496(0x24fa8933)   ; =0
    //   0x28d9723e6f0  <Module>::390073C602714496(0x21addf9c)   ; =0
    //   0x28d9723e710  C6338AE87AE0450D::160D4C2B11FD4200(0x21addf9c, <Module>::390073C602714496(0x7225c9d), <Module>::F84FA79ABE6944BB(0x535d8515))
    //   0x28d9723e738  <Module>::8B9C7B12B1AE4949(0x14ddf994)   ; =1
    //   0x28d9723e750  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e780  <Module>::8B9C7B12B1AE4949(0xffffffffebce7b55)   ; "Detections:Analysis:ChatGuard:StringSimilarity:Expiration"
    //   0x28d9723e798  <Module>::F84FA79ABE6944BB(0x29714ace)   ; =10
    //   0x28d9723e7b0  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0xffffffffebce7b55), <Module>::F84FA79ABE6944BB(0x29714ace), ?)
    //   0x28d9723e7c8  C6338AE87AE0450D::0EDDE79E80A044BD(<Module>::8B9C7B12B1AE4949(0x14ddf994), GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0xffffffffebce7b55), <Module>::F84FA79ABE6944BB(0x29714ace), ?))
    //   0x28d9723e7f0  <Module>::8B9C7B12B1AE4949(0x14ddf994)   ; =1
    //   0x28d9723e808  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e838  <Module>::390073C602714496(0x6220be6b)   ; "Detections:Analysis:ChatGuard:StringSimilarity:History"
    //   0x28d9723e858  <Module>::58ECCB512F2A43AC(0xffffffff8a20de15)   ; =5
    //   0x28d9723e870  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0x6220be6b), <Module>::58ECCB512F2A43AC(0xffffffff8a20de15), ?)
    //   0x28d9723e888  C6338AE87AE0450D::0EDDE79E80A044BD(<Module>::8B9C7B12B1AE4949(0x14ddf994), GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0x6220be6b), <Module>::58ECCB512F2A43AC(0xffffffff8a20de15), ?))
    //   0x28d9723e8b0  <Module>::8B9C7B12B1AE4949(0x14ddf994)   ; =1
    //   0x28d9723e8c8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e8f8  <Module>::58ECCB512F2A43AC(0xb1a4395)   ; "Detections:Analysis:ChatGuard:StringSimilarity:Allowed"
    //   0x28d9723e918  <Module>::3F57E81A62734AC2(0xffffffffcd941453)   ; =2
    //   0x28d9723e930  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::58ECCB512F2A43AC(0xb1a4395), <Module>::3F57E81A62734AC2(0xffffffffcd941453), ?)
    //   0x28d9723e948  C6338AE87AE0450D::0EDDE79E80A044BD(<Module>::8B9C7B12B1AE4949(0x14ddf994), GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::58ECCB512F2A43AC(0xb1a4395), <Module>::3F57E81A62734AC2(0xffffffffcd941453), ?))
    //   0x28d9723e968  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723e990  <Module>::390073C602714496(0xffffffffa75622dd)   ; "Detections:Analysis:ChatGuard:MessageLength:Enabled"
    //   0x28d9723e9b0  <Module>::F84FA79ABE6944BB(0x535d8515)   ; =0
    //   0x28d9723e9c8  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0xffffffffa75622dd), <Module>::F84FA79ABE6944BB(0x535d8515), ?)
    //   0x28d9723e9e8  760EF57D5259421C::02D998059BCD47E8()
    //   0x28d9723ea10  <Module>::390073C602714496(0xffffffffaabb90bf)   ; "Detections:Analysis:ChatGuard:MessageLength:MaxLength"
    //   0x28d9723ea30  <Module>::58ECCB512F2A43AC(0x77a806a1)   ; =256
    //   0x28d9723ea48  GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0xffffffffaabb90bf), <Module>::58ECCB512F2A43AC(0x77a806a1), ?)
    //   0x28d9723ea68  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d9723ea88  <Module>::F84FA79ABE6944BB(0xffffffff9dcd77e9)   ; =512
    //   0x28d9723eaa0  C6338AE87AE0450D::A3CF7DAEF2C9436B(GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0xffffffffaabb90bf), <Module>::58ECCB512F2A43AC(0x77a806a1), ?), <Module>::390073C602714496(0x7f132d63), <Modul
    // 10 store(s):
    //   0x28d9723e368  0x28c840e83c0 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0x3297746e), <Module>::390073C602714496(0x7f132d63), ?)
    //   0x28d9723e478  0x28c840e83e8 <- C6338AE87AE0450D::3A17FD50073842B9(GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::F84FA79ABE6944BB(0x3bfc17f3), <Module>::F84FA79ABE6944BB(0x46a8313f)
    //   0x28d9723e528  0x28c840e83e4 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0x3f94a1cc), <Module>::390073C602714496(0x7f132d63), ?)
    //   0x28d9723e5a8  0x28c840e83e5 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0xffffffffcd979931), <Module>::8B9C7B12B1AE4949(0xffffffffd8c6f9cd), ?)
    //   0x28d9723e628  0x28c840e83e6 <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::3F57E81A62734AC2(0xffffffff946ce336), <Module>::F84FA79ABE6944BB(0x535d8515), ?)
    //   0x28d9723e7d8  0x28c840e83d0 <- C6338AE87AE0450D::0EDDE79E80A044BD(<Module>::8B9C7B12B1AE4949(0x14ddf994), GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::8B9C7B12B1AE4949(0xffffffffe
    //   0x28d9723e898  0x28c840e83d4 <- C6338AE87AE0450D::0EDDE79E80A044BD(<Module>::8B9C7B12B1AE4949(0x14ddf994), GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0x6220be6b)
    //   0x28d9723e958  0x28c840e83d8 <- C6338AE87AE0450D::0EDDE79E80A044BD(<Module>::8B9C7B12B1AE4949(0x14ddf994), GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::58ECCB512F2A43AC(0xb1a4395),
    //   0x28d9723e9d8  0x28c840e83dc <- GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0xffffffffa75622dd), <Module>::F84FA79ABE6944BB(0x535d8515), ?)
    //   0x28d9723eab0  0x28c840e83e0 <- C6338AE87AE0450D::A3CF7DAEF2C9436B(GetValue(760EF57D5259421C::02D998059BCD47E8(), <Module>::390073C602714496(0xffffffffaabb90bf), <Module>::58ECCB512F2A43AC(0x7
    // returns: 0x28c840e83e0
    // string table refs:
    //   0x1730  "Detections:Analysis:ChatGuard:StringSimilarity:Enabled"
    //   0x198c  "Detections:Analysis:ChatGuard:ChatsForCheck"
    //   0x19bc  "GLOBAL,LOCAL"
    //   0x18e8  "Detections:Analysis:ChatGuard:AntiLinks:Enabled"
    //   0x191c  "Detections:Analysis:ChatGuard:AntiBadWords:Enabled"
    //   0x1954  "Detections:Analysis:ChatGuard:CharWhitelist:Enabled"
    //   0x176c  "Detections:Analysis:ChatGuard:StringSimilarity:Percentage"
    //   0x17b4  "Detections:Analysis:ChatGuard:StringSimilarity:Expiration"
    //   0x17f4  "Detections:Analysis:ChatGuard:StringSimilarity:History"
    //   0x1830  "Detections:Analysis:ChatGuard:StringSimilarity:Allowed"
    //   0x186c  "Detections:Analysis:ChatGuard:MessageLength:Enabled"
    //   0x18a4  "Detections:Analysis:ChatGuard:MessageLength:MaxLength"
}
