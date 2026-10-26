// ============================================================
// token 0x06000096   CCF339C5456845F6::062A95E296D640E5
// native code: 0x28d9723dff0  (424 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance void '062A95E296D640E5' () cil managed noinlining
//   
// native-calls: 06000005,06000007,06000003,060000a8
// native-strings: 
// ============================================================

public  void 062A95E296D640E5()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d9723e038  <Module>::F84FA79ABE6944BB(0x67cf2da4)   ; =1
    //   0x28d9723e0e0  <Module>::3F57E81A62734AC2(0xffffffff94857146)   ; =0
    //   0x28d9723e128  <Module>::8B9C7B12B1AE4949(0x14ddf994)   ; =1
    //   0x28d9723e158  get_Item(this.f10, (((movsxd this.f10.f18) sub <Module>::F84FA79ABE6944BB(0x67cf2da4)) sub <Module>::8B9C7B12B1AE4949(0x14ddf994)), ?, ?)
    //   0x28d9723e168  CCF339C5456845F6::F4BCFF6780374CF0(get_Item(this.f10, (((movsxd this.f10.f18) sub <Module>::F84FA79ABE6944BB(0x67cf2da4)) sub <Module>::8B9C7B12B1AE4949(0x14ddf994)), ?, ?))
    // returns: CCF339C5456845F6::F4BCFF6780374CF0(get_Item(this.f10, (((movsxd this.f10.f18) sub <Module>::F84FA79ABE6944BB(0x67cf2da4)) sub <Module>::8B9C7B12B1AE4949(0x14ddf994)), ?, ?))
}
