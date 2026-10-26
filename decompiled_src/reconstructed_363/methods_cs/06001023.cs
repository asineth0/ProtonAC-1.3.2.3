// ============================================================
// token 0x06001023   9E6941D2442741AE::41B34BCEE1A447D2
// native code: 0x28d95a2b5b0  (2188 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig static
//   void '41B34BCEE1A447D2' (
//   valuetype [ProtonAC.System.Text.Json]System.Text.Json.JsonElement '',
//   string '',
//   class [netstandard]System.Collections.Generic.Dictionary`2<string, string> ''
//   ) cil managed noinlining
//   
// native-calls: 06000006,06000007,0600102d,0600102c,06001023,06000004,0600102e,060060b1
// native-strings: 0x3650::,0x3658:{0}:{1}
// ============================================================

static void 41B34BCEE1A447D2(JsonElement arg0, string arg1, Dictionary<string, string> arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 26 call(s):
    //   0x28d95a2b670  get_ValueKind(arg0, arg1, arg2, ?)
    //   0x28d95a2b690  <Module>::58ECCB512F2A43AC(0x3bf9a73b)   ; =1
    //   0x28d95a2b758  EnumerateObject(arg0, (? add 0xfffffffffffffed8), arg2, ?)
    //   0x28d95a2b880  MoveNext((? add 0xfffffffffffffec0), (((((((0xffffffffa7e6911e sub 0x1fdc0bf0eaf2d01d) imul 0xa7909e81) not 0x1) xor 0x3924151561c33cd5) xor 0x6dda6b35) div 0x6) mod 0x6), arg2, ?)
    //   0x28d95a2b8d8  <Module>::3F57E81A62734AC2(0x63ebe6a1)   ; ":"
    //   0x28d95a2b8f0  9E6941D2442741AE::5A756FB500F149A1(arg1, <Module>::3F57E81A62734AC2(0x63ebe6a1), (r14 xor r14))
    //   0x28d95a2b930  get_Current((? add 0xfffffffffffffec0), (? add 0xfffffffffffffef0), (r14 xor r14), ?)
    //   0x28d95a2b948  get_Name((? add 0xfffffffffffffef0), (? add 0xfffffffffffffef0), (r14 xor r14), ?)
    //   0x28d95a2b960  9E6941D2442741AE::B1C6751B9C684626(arg1)
    //   0x28d95a2b9c0  9E6941D2442741AE::41B34BCEE1A447D2((? add 0xffffffffffffff88), (r14 xor r14), arg2)
    //   0x28d95a2b9ec  sub_28d95a2ba18((? add 0xffffffffffffff88), (r14 xor r14), arg2, ?)
    //   0x28d95a2ba10  sub_28b82785f1f((? add 0xffffffffffffff88), (r14 xor r14), arg2, ?)
    //   0x28d95a2ba58  <Module>::390073C602714496(0x7f132d63)   ; =0
    //   0x28d95a2ba80  EnumerateArray(arg0, (? add 0xffffffffffffff20), arg2, ?)
    //   0x28d95a2bb90  get_Current((? add 0xffffffffffffff08), (? add 0xffffffffffffff68), arg2, ?)
    //   0x28d95a2bbb8  <Module>::58ECCB512F2A43AC(0x1069398f)   ; "{0}:{1}"
    //   0x28d95a2bbd8  ALLOC_OBJECT(0x28c852328c8)
    //   0x28d95a2bc08  9E6941D2442741AE::ABCEA9B803CE46BB(<Module>::58ECCB512F2A43AC(0x1069398f), arg1, ALLOC_OBJECT(0x28c852328c8))
    //   0x28d95a2bc48  9E6941D2442741AE::41B34BCEE1A447D2((? add 0xffffffffffffff98), 9E6941D2442741AE::ABCEA9B803CE46BB(<Module>::58ECCB512F2A43AC(0x1069398f), arg1, ALLOC_OBJECT(0x28c852328c8)), arg2)
    //   0x28d95a2bc78  <Module>::3F57E81A62734AC2(0x3ca2d4c7)   ; =1
    //   0x28d95a2bca8  MoveNext((? add 0xffffffffffffff08), 9E6941D2442741AE::ABCEA9B803CE46BB(<Module>::58ECCB512F2A43AC(0x1069398f), arg1, ALLOC_OBJECT(0x28c852328c8)), arg2, ?)
    //   0x28d95a2bcd9  sub_28d95a2bd00((? add 0xffffffffffffff08), 9E6941D2442741AE::ABCEA9B803CE46BB(<Module>::58ECCB512F2A43AC(0x1069398f), arg1, ALLOC_OBJECT(0x28c852328c8)), arg2, ?)
    //   0x28d95a2bcf8  sub_28b82785f1f((? add 0xffffffffffffff08), 9E6941D2442741AE::ABCEA9B803CE46BB(<Module>::58ECCB512F2A43AC(0x1069398f), arg1, ALLOC_OBJECT(0x28c852328c8)), arg2, ?)
    //   0x28d95a2bd38  ToString(arg0, 9E6941D2442741AE::ABCEA9B803CE46BB(<Module>::58ECCB512F2A43AC(0x1069398f), arg1, ALLOC_OBJECT(0x28c852328c8)), arg2, ?)
    //   0x28d95a2bd60  set_Item(arg2, arg1, ToString(arg0, 9E6941D2442741AE::ABCEA9B803CE46BB(<Module>::58ECCB512F2A43AC(0x1069398f), arg1, ALLOC_OBJECT(0x28c852328c8)), arg2, ?), ?)
    //   0x28d95a2be08  Dictionary`2::set_Item(arg2, arg1, (ToString(arg0, 9E6941D2442741AE::ABCEA9B803CE46BB(<Module>::58ECCB512F2A43AC(0x1069398f), arg1, ALLOC_OBJECT(0x28c852328c8)), arg2, ?) xor ToString(arg0, 9E6941D2442741AE::ABCEA9B803CE46BB(<Module
    // 1 store(s):
    //   0x28d95a2bbec  ALLOC_OBJECT(0x28c852328c8) <- (movsxd <Module>::390073C602714496(0x7f132d63))
    // returns: Dictionary`2::set_Item(arg2, arg1, (ToString(arg0, 9E6941D2442741AE::ABCEA9B803CE46BB(<Module>::58ECCB512F2A43AC(0x1069398f), arg1, ALLOC_OBJECT(0x28c852328c8)), arg2, ?) xor ToString(arg0, 9E6941D2442741AE::ABCE
    // string table refs:
    //   0x3650  ":"
    //   0x3658  "{0}:{1}"
}
