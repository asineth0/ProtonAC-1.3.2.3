// ============================================================
// token 0x0600095e   0732D1C8FF584BB5::648E305AD3AD4839
// native code: 0x28d97314c10  (907 bytes)
// kind: LOOP   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance void '648E305AD3AD4839' () cil managed
//   
// native-calls: 060001be,06000d67,06006153,0600096e,0600096b,0600096c,060060c3
// native-strings: 
// ============================================================

public  void 648E305AD3AD4839()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 17 call(s):
    //   0x28d97314c80  9AB67761792440A7::00FC653ED33A4A96()
    //   0x28d97314ca0  1A42C15FF0B54B42::A96488F8354C4887(this.f18, 9AB67761792440A7::00FC653ED33A4A96())
    //   0x28d97314cc0  1A42C15FF0B54B42::A96488F8354C4887(this.f20, 9AB67761792440A7::00FC653ED33A4A96())
    //   0x28d97314d00  GetEnumerator(this.f10, (? add 0xffffffffffffff58), ?, ?)
    //   0x28d97314dc0  List`1::AddWithResize(this.f28, ((? add 0xffffffffffffff58) add 0x10).f0, ?, ?)
    //   0x28d97314de0  AE8979A166C64D26::E797B23ED8FB4F22(((? add 0xffffffffffffff58) add 0x10).f8.f20)
    //   0x28d97314df8  AE8979A166C64D26::DAF10031C08449F7(((? add 0xffffffffffffff58) add 0x10).f8.f20)
    //   0x28d97314e18  AE8979A166C64D26::FF62ABE9C6104A2E(((? add 0xffffffffffffff58) add 0x10).f8.f20)
    //   0x28d97314e40  MoveNext((? add 0xffffffffffffff58), ((? add 0xffffffffffffff58) add 0x10).f0, ?, ?)
    //   0x28d97314e5a  sub_28d97314e85((? add 0xffffffffffffff58), ((? add 0xffffffffffffff58) add 0x10).f0, ?, ?)
    //   0x28d97314e80  sub_28b82785f1f((? add 0xffffffffffffff58), ((? add 0xffffffffffffff58) add 0x10).f0, ?, ?)
    //   0x28d97314ec0  GetEnumerator(this.f28, (? add 0xffffffffffffff90), ?, ?)
    //   0x28d97314ee8  Dictionary`2::Remove(this.f10, (rax xor rax), ?, ?)
    //   0x28d97314f00  MoveNext((? add 0xffffffffffffff90), (rax xor rax), ?, ?)
    //   0x28d97314f16  sub_28d97314f3d((? add 0xffffffffffffff90), (rax xor rax), ?, ?)
    //   0x28d97314f38  sub_28b82785f1f((? add 0xffffffffffffff90), (rax xor rax), ?, ?)
    //   0x28d97314f98  THROW(0x146, 0x200)
    // 5 store(s):
    //   0x28d97314cd3  this.f28 <- ((movsxd this.f28.f1c) inc 0x1)
    //   0x28d97314cd6  this.f28 <- 0x0
    //   0x28d97314d6b  this.f28 <- ((movsxd this.f28.f1c) inc 0x1)
    //   0x28d97314d91  this.f28 <- ((movsxd (movsxd this.f28.f18)) inc 0x1)
    //   0x28d97314da6  this.f28.f10+(movsxd (movsxd (movsxd this.f28.f18)))*4+20 <- ((? add 0xffffffffffffff58) add 0x10).f0
    // returns: sub_28b82785f1f((? add 0xffffffffffffff90), (rax xor rax), ?, ?)
}
