// ============================================================
// token 0x06000963   0732D1C8FF584BB5::4D79E39DE8BE4B66
// native code: 0x28d97318230  (9972 bytes)
// kind: LOOP   confidence: outline
// original IL signature:
//   .method private hidebysig static
//   valuetype [netstandard]System.Nullable`1<valuetype [UnityEngine.CoreModule]UnityEngine.Bounds> '4D79E39DE8BE4B66' (
//   class [netstandard]System.Collections.Generic.List`1<class [UnityEngine.PhysicsModule]UnityEngine.Collider> ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

static Nullable<valuetype UnityEngine.Bounds> 4D79E39DE8BE4B66(List<class UnityEngine.Collider> arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d973183f8  get_Item(arg0, (xor ?), ?, ?)
    //   0x28d97318418  get_bounds(get_Item(arg0, (xor ?), ?, ?), (? add 0xfffffffffffff9c0), ?, ?)
    //   0x28d97318440  get_Item(arg0, 0x1, ?, ?)
    //   0x28d97318460  get_bounds(get_Item(arg0, 0x1, ?, ?), (? add 0xfffffffffffffdb0), ?, ?)
    //   0x28d9731a888  THROW(0x162, 0x1ab)
    // 18 store(s):
    //   0x28d973193fb  (? add 0xfffffffffffff9c0)+c <- (movsxd (movsxd 0x0))
    //   0x28d97319404  (? add 0xfffffffffffff9c0)+c <- (movsxd (movsxd 0x0))
    //   0x28d9731940e  (? add 0xfffffffffffff9c0)+c <- (movsxd (movsxd 0x0))
    //   0x28d973195ce  (? add 0xfffffffffffff9c0) <- (movsxd (movsxd 0x0))
    //   0x28d973195d9  (? add 0xfffffffffffff9c0) <- (movsxd (movsxd 0x0))
    //   0x28d973195e5  (? add 0xfffffffffffff9c0) <- (movsxd (movsxd 0x0))
    //   0x28d9731a51e  (? add 0xfffffffffffff9c0)+c <- (movsxd (movsxd 0x0))
    //   0x28d9731a527  (? add 0xfffffffffffff9c0)+c <- (movsxd (movsxd 0x0))
    //   0x28d9731a531  (? add 0xfffffffffffff9c0)+c <- (movsxd (movsxd 0x0))
    //   0x28d9731a6ed  (? add 0xfffffffffffff9c0) <- (movsxd (movsxd 0x0))
    //   0x28d9731a6f6  (? add 0xfffffffffffff9c0) <- (movsxd (movsxd 0x0))
    //   0x28d9731a6fd  (? add 0xfffffffffffff9c0) <- (movsxd (movsxd 0x0))
    //   0x28d9731a7c9  ((? add 0xfffffffffffffd50) add 0x4) <- (movsxd (movsxd 0x0))
    //   0x28d9731a7cf  ((? add 0xfffffffffffffd50) add 0x4) <- (movsxd (movsxd 0x0))
    //   0x28d9731a7d6  ((? add 0xfffffffffffffd50) add 0x4) <- (movsxd (movsxd 0x0))
    //   0x28d9731a7dd  ((? add 0xfffffffffffffd50) add 0x4) <- (movsxd (movsxd 0x0))
    //   0x28d9731a7e4  ((? add 0xfffffffffffffd50) add 0x4) <- (movsxd (movsxd 0x0))
    //   0x28d9731a7eb  ((? add 0xfffffffffffffd50) add 0x4) <- (movsxd (movsxd 0x0))
    // returns: (movsxd arg0.f18)
}
