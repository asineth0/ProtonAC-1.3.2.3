using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_060004ff {
    public unsafe static System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> M060004ff(System.Collections.Generic.IEnumerable<HarmonyLib.CodeInstruction> instructions) {
      // [auto-dropped] var v1 = T_900C7FACA7284F09.DF99DA15D9EC43A6(instructions, default, default);
      var v2 = E651E17AA2CA4BC8.T_18821157D5754512(default);
      var v3 = E651E17AA2CA4BC8.T_18821157D5754512(default);
      object s4 = default;
      HarmonyLib.CodeInstruction o5 = default;
      System.Collections.Generic.List<object> o6 = default;
      // [auto-dropped] get_Item(default, 0, 0, 0).T_2115E39EB2D34824();
      s4 = default;
      T_6487285FB41C4853.T_36CB4EE3CC6C48CE.C01D94B9EF1A4342(o5);
      T_6487285FB41C4853.T_36CB4EE3CC6C48CE.C01D94B9EF1A4342(o5);
      return default;
      // call get_Item(ToList(a0, ?, ?, ?), (r13 xor r13), ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)))
      // call AddWithResize(ALLOC_OBJECT(0x28d9463a108), ALLOC_OBJECT(0x28d9458e2f0), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
      // call List`1::AddWithResize(ALLOC_OBJECT(0x28d9463a108), ALLOC_OBJECT(0x28d9458e2f0), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
      // call get_Item(ToList(a0, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
      // call List`1::get_Item(ALLOC_OBJECT(0x28d9463a108), ((r13 xor r13) xor (r13 xor r13)), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
      // call List`1::get_Item(ToList(a0, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
      // call List`1::AddRange(List`1::get_Item(ALLOC_OBJECT(0x28d9463a108), ((r13 xor r13) xor (r13 xor r13)), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?))).f18, List`1::get_Item(ToList(a0, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?))).f18, ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
      // call List`1::get_Item(ToList(a0, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9458e2f0), ((xor ?) xor (xor ?)))
      // call InsertRange(ToList(a0, ?, ?, ?), (r13 xor r13), ALLOC_OBJECT(0x28d9463a108), ((xor ?) xor (xor ?)))
    }
  }
}
