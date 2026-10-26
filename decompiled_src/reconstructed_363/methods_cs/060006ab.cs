// ============================================================
// token 0x060006ab   C6338AE87AE0450D::3A17FD50073842B9
// native code: 0x28d9723f5d0  (1226 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig static
//   valuetype ['Assembly-CSharp']SDG.Unturned.EChatMode[] '3A17FD50073842B9' (
//   string ''
//   ) cil managed noinlining
//   
// native-calls: 060006b8,06000003,060006bb,06001058,06000005,06000004,060006bc,060006bd,060006ba,060006b9
// native-strings: 
// ============================================================

static SDG.Unturned.EChatMode 3A17FD50073842B9(string arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 20 call(s):
    //   0x28d9723f630  C6338AE87AE0450D::1BBB024F15ED40DD(arg0)
    //   0x28d9723f6c8  <Module>::8B9C7B12B1AE4949(0x14ddf994)   ; =1
    //   0x28d9723f6e8  TryParse(0x0, <Module>::8B9C7B12B1AE4949(0x14ddf994), (? add 0xffffffffffffffa0), ?)
    //   0x28d9723f740  C6338AE87AE0450D::C5A761BDE26E43D1(0x0)
    //   0x28d9723f788  760EF57D5259421C::44706B4DDFCF4FD5(0x0, <Module>::8B9C7B12B1AE4949(0x14ddf994), (? add 0xffffffffffffffa0), ?)
    //   0x28d9723f7b8  <Module>::F84FA79ABE6944BB(0xfffffffff4e18f03, <Module>::8B9C7B12B1AE4949(0x14ddf994), (? add 0xffffffffffffffa0), ?)
    //   0x28d9723f7e8  <Module>::390073C602714496(0xe378542, <Module>::8B9C7B12B1AE4949(0x14ddf994), (? add 0xffffffffffffffa0), ?)
    //   0x28d9723f808  C6338AE87AE0450D::73E1027E90FF42D2(<Module>::F84FA79ABE6944BB(0xfffffffff4e18f03, <Module>::8B9C7B12B1AE4949(0x14ddf994), (? add 0xffffffffffffffa0), ?), 0x0, <Module>::390073C602714496(0xe378542, <Module>::8B9C7B12B1AE4
    //   0x28d9723f828  C6338AE87AE0450D::1E74BC84FE044EED(760EF57D5259421C::44706B4DDFCF4FD5(0x0, <Module>::8B9C7B12B1AE4949(0x14ddf994), (? add 0xffffffffffffffa0), ?), C6338AE87AE0450D::73E1027E90FF42D2(<Module>::F84FA79ABE6944BB(0xfffffffff
    //   0x28d9723f850  <Module>::8B9C7B12B1AE4949(0x14ddf994)   ; =1
    //   0x28d9723f888  ALLOC_OBJECT(0x28d96b99068)
    //   0x28d9723f8a0  .ctor(ALLOC_OBJECT(0x28d96b99068), C6338AE87AE0450D::73E1027E90FF42D2(<Module>::F84FA79ABE6944BB(0xfffffffff4e18f03, <Module>::8B9C7B12B1AE4949(0x14ddf994), (? add 0xffffffffffffffa0), ?), 0x0, <Module>::390073C602714496
    //   0x28d9723f938  AddWithResize(ALLOC_OBJECT(0x28d96b99068), (movsxd (movsxd 0x0)), 0x28cc7550840, ?)
    //   0x28d9723f978  C6338AE87AE0450D::59A3183E57394007(0x0+(movsxd (movsxd ((movsxd 0x0) add <Module>::8B9C7B12B1AE4949(0x14ddf994))))*8+20.f0)
    //   0x28d9723f9d8  <Module>::8B9C7B12B1AE4949(0x79160b1d)   ; =44
    //   0x28d9723f9f0  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d9723fa08  C6338AE87AE0450D::23E9D56762C94CC1(arg0, <Module>::8B9C7B12B1AE4949(0x79160b1d), <Module>::390073C602714496(0x7f132d63))
    //   0x28d9723fa28  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d9723fa50  ToArray(ALLOC_OBJECT(0x28d96b99068), <Module>::8B9C7B12B1AE4949(0x79160b1d), <Module>::390073C602714496(0x7f132d63), ?)
    //   0x28d9723fa90  THROW(0x146, 0x133)
    // 3 store(s):
    //   0x28d9723f8e4  ALLOC_OBJECT(0x28d96b99068) <- ((movsxd ALLOC_OBJECT(0x28d96b99068).f1c) inc 0x1)
    //   0x28d9723f908  ALLOC_OBJECT(0x28d96b99068) <- ((movsxd (movsxd ALLOC_OBJECT(0x28d96b99068).f18)) inc 0x1)
    //   0x28d9723f922  ALLOC_OBJECT(0x28d96b99068).f10+(movsxd (movsxd (movsxd ALLOC_OBJECT(0x28d96b99068).f18)))*4+20 <- (movsxd (movsxd 0x0))
    // returns: ToArray(ALLOC_OBJECT(0x28d96b99068), <Module>::8B9C7B12B1AE4949(0x79160b1d), <Module>::390073C602714496(0x7f132d63), ?)
}
