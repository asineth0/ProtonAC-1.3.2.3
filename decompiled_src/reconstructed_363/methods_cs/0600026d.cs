// ============================================================
// token 0x0600026d   A19CBF069C964833::99A93C8FCF084453
// native code: 0x28d970b7870  (303 bytes)
// kind: LOOP   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class A19CBF069C964833/'40FE7AC3F69F4B10' '99A93C8FCF084453' (
//   string ''
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public  A19CBF069C964833.40FE7AC3F69F4B10 99A93C8FCF084453(string arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 7 call(s):
    //   0x28d970b78b8  GetEnumerator(this.f10, (? add 0xffffffffffffffc0), ?, ?)
    //   0x28d970b78d8  op_Equality((rax xor rax).f10, arg0, ?, ?)
    //   0x28d970b78f3  sub_28d970b796d((rax xor rax).f10, arg0, ?, ?)
    //   0x28d970b7910  sub_28b82785f1f((rax xor rax).f10, arg0, ?, ?)
    //   0x28d970b7938  MoveNext((? add 0xffffffffffffffc0), arg0, ?, ?)
    //   0x28d970b794b  sub_28d970b796d((? add 0xffffffffffffffc0), arg0, ?, ?)
    //   0x28d970b7968  sub_28b82785f1f((? add 0xffffffffffffffc0), arg0, ?, ?)
    // returns: (rax xor rax)
}
