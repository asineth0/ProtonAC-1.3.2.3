// ============================================================
// token 0x06000468   8162F8F545F5474A::FF8CE9A823D04023
// native code: 0x28d95a12000  (437 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   class [netstandard]System.Threading.Tasks.Task`1<bool> FF8CE9A823D04023 (
//   valuetype [netstandard]System.Guid ''
//   ) cil managed noinlining
//   
// native-calls: 06000006
// native-strings: 
// ============================================================

public static Task<bool> FF8CE9A823D04023(Guid arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d95a12040  memset((? add 0xffffffffffffff70), (xor ?), 0x60, ?)
    //   0x28d95a12148  <Module>::58ECCB512F2A43AC(0xfffffffff9446e57)   ; =-1
    //   0x28d95a12178  Start(((? add 0xffffffffffffff70) add 0x8), (? add 0xffffffffffffff70), 0x60, ?)
    //   0x28d95a121a0  get_Task(((? add 0xffffffffffffff70) add 0x8), (? add 0xffffffffffffff70), 0x60, ?)
    // 7 store(s):
    //   0x28d95a12062  ((? add 0xffffffffffffff70) add 0x8) <- ((? add 0xffffffffffffff70) xor (? add 0xffffffffffffff70))
    //   0x28d95a12069  ((? add 0xffffffffffffff70) add 0x8) <- ((? add 0xffffffffffffff70) xor (? add 0xffffffffffffff70))
    //   0x28d95a12071  ((? add 0xffffffffffffff70) add 0x8) <- ((? add 0xffffffffffffff70) xor (? add 0xffffffffffffff70))
    //   0x28d95a1211d  ((? add 0xffffffffffffff70) add 0x20) <- (movsxd arg0.f0)
    //   0x28d95a12123  ((? add 0xffffffffffffff70) add 0x20) <- (movsxd arg0.f4)
    //   0x28d95a1212a  ((? add 0xffffffffffffff70) add 0x20) <- (movsxd arg0.f8)
    //   0x28d95a12131  ((? add 0xffffffffffffff70) add 0x20) <- (movsxd arg0.fc)
    // returns: get_Task(((? add 0xffffffffffffff70) add 0x8), (? add 0xffffffffffffff70), 0x60, ?)
}
