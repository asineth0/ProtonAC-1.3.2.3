// ============================================================
// token 0x06001007   CDD77F4B61A645F5::1144E21C9FA84988
// native code: 0x28d95a079c0  (941 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '1144E21C9FA84988' (
//   class '02C54685DE0E4B81' '',
//   class '652C34B1E6554F10' '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 0600100d,0600100b,0600100c,06000004,06001009,0600100a,06005f01,06000006,0600100e
// native-strings: 
// ============================================================

public  Task 1144E21C9FA84988(02C54685DE0E4B81 arg0, 652C34B1E6554F10 arg1, valuetype Threading.CancellationToken arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 15 call(s):
    //   0x28d95a07aa8  CDD77F4B61A645F5::FB3CC6B25CE742B5((r13 xor r13), (((((((((((0xffffffffd47a7118 xor 0xebb416d92aa217c8) not 0x1) imul 0x87bd41d5) add 0xa9676543196d4d55) add 0x1029d6a51) xor 0xecde63c69561faa9) not 0x1) sub 0x259cd29e) 
    //   0x28d95a07ad8  CDD77F4B61A645F5::FF65E1E221E948A3(arg1)
    //   0x28d95a07b00  TryGetValue(this.f10, CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2)
    //   0x28d95a07b40  CDD77F4B61A645F5::FA1A8878DB7E4FFE((r13 xor r13), CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2)
    //   0x28d95a07b70  <Module>::390073C602714496(0x46a4cc8, CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2)
    //   0x28d95a07b80  CDD77F4B61A645F5::3219F8BD54214BBF(<Module>::390073C602714496(0x46a4cc8, CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2), CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2)
    //   0x28d95a07b90  ?(CDD77F4B61A645F5::3219F8BD54214BBF(<Module>::390073C602714496(0x46a4cc8, CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2), CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2),
    //   0x28d95a07bc0  CDD77F4B61A645F5::CEB16D650A6D4233(0x28b83dd3e30, CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2)
    //   0x28d95a07bd8  CDD77F4B61A645F5::FB3CC6B25CE742B5(CDD77F4B61A645F5::FA1A8878DB7E4FFE((r13 xor r13), CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2), CDD77F4B61A645F5::CEB16D650A6D4233(0x28b83dd3e30, CDD77F4B61A6
    //   0x28d95a07c30  ConcurrentDictionary`2::TryGetValue(this.f10, CDD77F4B61A645F5::FA1A8878DB7E4FFE((r13 xor r13), CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2), (? add 0xffffffffffffffb0), arg2)
    //   0x28d95a07c70  CDD77F4B61A645F5::FA1A8878DB7E4FFE(CDD77F4B61A645F5::FF65E1E221E948A3(arg1), CDD77F4B61A645F5::FA1A8878DB7E4FFE((r13 xor r13), CDD77F4B61A645F5::FF65E1E221E948A3(arg1), (? add 0xffffffffffffffb0), arg2), (? add 0xfffffffffffff
    //   0x28d95a07cf0  <Module>::58ECCB512F2A43AC(0x5d03be8a, arg0, arg1, arg2)
    //   0x28d95a07d00  CDD77F4B61A645F5::3219F8BD54214BBF(<Module>::58ECCB512F2A43AC(0x5d03be8a, arg0, arg1, arg2), arg0, arg1, arg2)
    //   0x28d95a07d10  ?(CDD77F4B61A645F5::3219F8BD54214BBF(<Module>::58ECCB512F2A43AC(0x5d03be8a, arg0, arg1, arg2), arg0, arg1, arg2), arg0, arg1, arg2)
    //   0x28d95a07d48  CDD77F4B61A645F5::96D1E507C55A436C((r14 xor r14), arg0, arg1, arg2)
    // returns: CDD77F4B61A645F5::96D1E507C55A436C((r14 xor r14), arg0, arg1, arg2)
}
