// ============================================================
// token 0x0600096d   AE8979A166C64D26::3A3AAE3891E54E4A
// native code: 0x28d97318140  (211 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance valuetype '0732D1C8FF584BB5'/FFFC598AFAF4431B& '3A3AAE3891E54E4A' () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public  0732D1C8FF584BB5.FFFC598AFAF4431B& 3A3AAE3891E54E4A()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 1 call(s):
    //   0x28d97318210  THROW(0x146, 0x73)
    // 6 store(s):
    //   0x28d9731816e  this <- ((((movsxd this.f18) inc 0x1) idiv 0x14) mod 0x14)
    //   0x28d97318191  this <- ((movsxd this.f1c) inc 0x1)
    //   0x28d973181c4  ((this.f10 add ((movsxd ((((movsxd this.f18) add (movsxd this.f1c)) idiv 0x14) mod 0x14)) imul 0x48)) add 0x20).f10 <- ((movsxd ((this.f10 add ((movsxd ((((movsxd this.f18) add (movsxd this.f1c)) idiv 0x14) mod 0x14)) imul 0x48)) add 0x20).f10.f1c) inc 0x1)
    //   0x28d973181c7  ((this.f10 add ((movsxd ((((movsxd this.f18) add (movsxd this.f1c)) idiv 0x14) mod 0x14)) imul 0x48)) add 0x20).f10 <- 0x0
    //   0x28d973181e1  ((this.f10 add ((movsxd ((((movsxd this.f18) add (movsxd this.f1c)) idiv 0x14) mod 0x14)) imul 0x48)) add 0x20).f18 <- ((movsxd ((this.f10 add ((movsxd ((((movsxd this.f18) add (movsxd this.f1c)) idiv 0x14) mod 0x14)) imul 0x48)) add 0x20).f18.f1c) inc 0x1)
    //   0x28d973181e4  ((this.f10 add ((movsxd ((((movsxd this.f18) add (movsxd this.f1c)) idiv 0x14) mod 0x14)) imul 0x48)) add 0x20).f18 <- 0x0
    // returns: ((this.f10 add ((movsxd ((((movsxd this.f18) add (movsxd this.f1c)) idiv 0x14) mod 0x14)) imul 0x48)) add 0x20)
}
