// ============================================================
// token 0x06001856   FE504B49A4DA4B00::908637E508BC4E4B
// native code: 0x28d959ec6c0  (553 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig static
//   void '908637E508BC4E4B' (
//   valuetype '59751E20330E4047' '',
//   class [netstandard]System.Func`1<class '652C34B1E6554F10'> ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

static void 908637E508BC4E4B(59751E20330E4047 arg0, Func<class 652C34B1E6554F10> arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 10 call(s):
    //   0x28d959ec700  sub_28b82782ba0(0x28d0e026878, arg1, ?, ?)
    //   0x28d959ec728  ContainsKey(0x28cca2db270.f0, arg0, ?, ?)
    //   0x28d959ec7b0  sub_28b82782ba0(0x28d0e026878, (((((0x211a7a72 neg 0x1) imul 0xc0e4262d) imul 0x15e9b273) div 0x3) mod 0x3), ?, ?)
    //   0x28d959ec7d8  ALLOC_OBJECT(0x28d0d63aaa8)
    //   0x28d959ec7f0  .ctor(ALLOC_OBJECT(0x28d0d63aaa8), (((((0x211a7a72 neg 0x1) imul 0xc0e4262d) imul 0x15e9b273) div 0x3) mod 0x3), ?, ?)
    //   0x28d959ec810  set_Item(0x28cca2db270.f0, arg0, ALLOC_OBJECT(0x28d0d63aaa8), ?)
    //   0x28d959ec850  sub_28b82782ba0(0x28d0e026878, arg0, ALLOC_OBJECT(0x28d0d63aaa8), ?)
    //   0x28d959ec878  get_Item(0x28cca2db270.f0, arg0, ALLOC_OBJECT(0x28d0d63aaa8), ?)
    //   0x28d959ec8b0  get_Item(0x28cca2db270.f0, arg0, ALLOC_OBJECT(0x28d0d63aaa8), ?)
    //   0x28d959ec8d0  set_Item(get_Item(0x28cca2db270.f0, arg0, ALLOC_OBJECT(0x28d0d63aaa8), ?), ((movsxd get_Item(0x28cca2db270.f0, arg0, ALLOC_OBJECT(0x28d0d63aaa8), ?).f40) sub (movsxd get_Item(0x28cca2db270.f0, arg0, ALLOC_OBJECT(0x28d0d63aaa8)
    // returns: set_Item(get_Item(0x28cca2db270.f0, arg0, ALLOC_OBJECT(0x28d0d63aaa8), ?), ((movsxd get_Item(0x28cca2db270.f0, arg0, ALLOC_OBJECT(0x28d0d63aaa8), ?).f40) sub (movsxd get_Item(0x28cca2db270.f0, arg0, ALLOC_O
}
