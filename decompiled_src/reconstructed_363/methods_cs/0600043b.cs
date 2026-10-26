// ============================================================
// token 0x0600043b   C4462CD02B8C4225::CE6DFA7D5BCC43E0
// native code: 0x28d97013350  (1273 bytes)
// kind: LOOP   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance void CE6DFA7D5BCC43E0 (
//   valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed
//   
// native-calls: 060004e7,06005ed9,060004c6,06000439,060004c7,060004c5,060016bf,0600043a
// native-strings: 
// ============================================================

 void CE6DFA7D5BCC43E0(Threading.CancellationToken arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 14 call(s):
    //   0x28d970133b8  ALLOC_OBJECT(0x28ccd8f1420)
    //   0x28d970133d0  40273E31A09B48E7::.ctor(ALLOC_OBJECT(0x28ccd8f1420))
    //   0x28d97013408  Wait(this.f28, 0xfa, ?, ?)
    //   0x28d97013478  ConcurrentQueue`1::TryDequeue(this.f20, (? add 0xffffffffffffff60), ?, ?)
    //   0x28d970134a0  40273E31A09B48E7::605A92C29EFB4E06(ALLOC_OBJECT(0x28ccd8f1420), (? add 0xffffffffffffff60), ?, ?)
    //   0x28d970134e0  C4462CD02B8C4225::C700DF6D63C14083((rax xor rax), ALLOC_OBJECT(0x28ccd8f1420), ?, ?)
    //   0x28d97013510  40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420), ?, ?)
    //   0x28d97013538  40273E31A09B48E7::26D727290E7043B3(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420), ?, ?)
    //   0x28d97013558  ALLOC_OBJECT(0x28ccd8f1530)
    //   0x28d97013590  0D2DBD97EB44499A::.ctor(ALLOC_OBJECT(0x28ccd8f1530), C4462CD02B8C4225::C700DF6D63C14083((rax xor rax), ALLOC_OBJECT(0x28ccd8f1420), ?, ?), (rax xor rax), 40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), AL
    //   0x28d970135b8  C4462CD02B8C4225::62A8949511C3432B(this, ALLOC_OBJECT(0x28ccd8f1530), (movzx (rax xor rax)), 40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420), ?, ?))
    //   0x28d970135ca  sub_28d97013710(this, ALLOC_OBJECT(0x28ccd8f1530), (movzx (rax xor rax)), 40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420), ?, ?))
    //   0x28d970135f0  sub_28b82785f1f(this, ALLOC_OBJECT(0x28ccd8f1530), (movzx (rax xor rax)), 40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420), ?, ?))
    //   0x28d97013838  get_IsCancellationRequested((? add 0xffffffffffffff30), ALLOC_OBJECT(0x28ccd8f1530), (movzx (rax xor rax)), 40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420), ?, ?))
    // returns: get_IsCancellationRequested((? add 0xffffffffffffff30), ALLOC_OBJECT(0x28ccd8f1530), (movzx (rax xor rax)), 40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420),
}
