// ============================================================
// token 0x060004ff   301E15320E3A41F1::09B5393A83114339
// native code: 0x28d97210000  (1148 bytes)
// kind: LOOP   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   class [netstandard]System.Collections.Generic.IEnumerable`1<class ['0Harmony']HarmonyLib.CodeInstruction> '09B5393A83114339' (
//   class [netstandard]System.Collections.Generic.IEnumerable`1<class ['0Harmony']HarmonyLib.CodeInstruction> instructions
//   ) cil managed
//   
// native-calls: 06006153,0600614d,06006155
// native-strings: ?:equip,?:448A3958B7B5464C,?:2804801926016,?:2804812767168
// ============================================================

public static IEnumerable<class HarmonyLib.CodeInstruction> 09B5393A83114339(IEnumerable<class HarmonyLib.CodeInstruction> instructions)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 19 call(s):
    //   0x28d97210040  ToList(instructions, ?, ?, ?)
    //   0x28d97210070  Method(0x28cc7532b10, 0x28d0b38f380, (xor ?), (xor ?))   ; "equip"
    //   0x28d972100a0  Method(0x28ccc6f3f90, 0x28d0bde5fc0, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)))   ; "448A3958B7B5464C"
    //   0x28d972100c8  get_Item(ToList(instructions, ?, ?, ?), (r13 xor r13), ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)))
    //   0x28d972100e0  Calls(get_Item(ToList(instructions, ?, ?, ?), (r13 xor r13), ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?))), Method(0x28cc7532b10, 0x28d0b38f380, (xor ?), (xor ?)), ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)))
    //   0x28d97210100  ALLOC_OBJECT(0x28d9463a108)
    //   0x28d97210130  WBARRIER((ALLOC_OBJECT(0x28d9463a108) add 0x10), Method(0x28cc7532b10, 0x28d0b38f380, (xor ?), (xor ?)))
    //   0x28d972101b0  ALLOC_OBJECT(0x28d9458e2f0)
    //   0x28d972101d0  .ctor(ALLOC_OBJECT(0x28d9458e2f0), (movsx 0x28cc7a09838.f0), (((xor ?) xor (xor ?)) xor ((xor ?) xor (xor ?))), ((xor ?) xor (xor ?)))
    //   0x28d97210248  AddWithResize(ALLOC_OBJECT(0x28d9463a108), ALLOC_OBJECT(0x28d9458e2f0), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
    //   0x28d972102b8  ALLOC_OBJECT(0x28d9458e2f0)
    //   0x28d972102d8  .ctor(ALLOC_OBJECT(0x28d9458e2f0), (movsx 0x28cc7a09960.f0), Method(0x28ccc6f3f90, 0x28d0bde5fc0, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?))), ((xor ?) xor (xor ?)))
    //   0x28d97210350  List`1::AddWithResize(ALLOC_OBJECT(0x28d9463a108), ALLOC_OBJECT(0x28d9458e2f0), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
    //   0x28d97210370  get_Item(ToList(instructions, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
    //   0x28d972103a0  List`1::get_Item(ALLOC_OBJECT(0x28d9463a108), ((r13 xor r13) xor (r13 xor r13)), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
    //   0x28d972103c8  List`1::get_Item(ToList(instructions, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
    //   0x28d972103f0  List`1::AddRange(List`1::get_Item(ALLOC_OBJECT(0x28d9463a108), ((r13 xor r13) xor (r13 xor r13)), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?))).f18, List`1::get_Item(ToList(instructions, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT
    //   0x28d97210408  List`1::get_Item(ToList(instructions, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
    //   0x28d97210440  InsertRange(ToList(instructions, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9463a108), ((xor ?) xor (xor ?)))
    // 7 store(s):
    //   0x28d97210122  (ALLOC_OBJECT(0x28d9463a108) add 0x10) <- 0x28d0bebe440
    //   0x28d972101f1  ALLOC_OBJECT(0x28d9463a108) <- ((movsxd ALLOC_OBJECT(0x28d9463a108).f1c) inc 0x1)
    //   0x28d9721021a  ALLOC_OBJECT(0x28d9463a108) <- ((movsxd (movsxd ALLOC_OBJECT(0x28d9463a108).f18)) inc 0x1)
    //   0x28d972102f8  ALLOC_OBJECT(0x28d9463a108) <- ((movsxd ALLOC_OBJECT(0x28d9463a108).f1c) inc 0x1)
    //   0x28d97210323  ALLOC_OBJECT(0x28d9463a108) <- ((movsxd (movsxd ALLOC_OBJECT(0x28d9463a108).f18)) inc 0x1)
    //   0x28d9721041b  List`1::get_Item(ToList(instructions, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?))).f18 <- ((movsxd List`1::get_Item(ToList(instructions, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?))).f18.f1c) inc 0x1)
    //   0x28d9721041e  List`1::get_Item(ToList(instructions, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?))).f18 <- 0x0
    // returns: (movsxd ToList(instructions, ?, ?, ?).f18)
    // string table refs:
    //   literal  "equip"
    //   literal  "448A3958B7B5464C"
    //   literal  "2804801926016"
    //   literal  "2804812767168"
}
