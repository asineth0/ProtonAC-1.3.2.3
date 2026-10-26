// ============================================================
// token 0x06000d11   C0225ABF72C4425E::8F556C33BC784C69
// native code: 0x28d9583b8c0  (397 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '8F556C33BC784C69' () cil managed noinlining
//   
// native-calls: 06000004
// native-strings: 
// ============================================================

 Task 8F556C33BC784C69()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d9583b8f8  memset((? add 0xffffffffffffff70), (xor ?), 0x60, ?)
    //   0x28d9583b948  WBARRIER(((? add 0xffffffffffffff70) add 0x20), (xor ?))
    //   0x28d9583b9d8  <Module>::390073C602714496(0xffffffffd413acc0)   ; =-1
    //   0x28d9583ba08  Start(((? add 0xffffffffffffff70) add 0x8), (? add 0xffffffffffffff70), 0x60, ?)
    //   0x28d9583ba38  get_Task(((? add 0xffffffffffffff70) add 0x8), (? add 0xffffffffffffff70), 0x60, ?)
    // 4 store(s):
    //   0x28d9583b91a  ((? add 0xffffffffffffff70) add 0x8) <- ((? add 0xffffffffffffff70) xor (? add 0xffffffffffffff70))
    //   0x28d9583b921  ((? add 0xffffffffffffff70) add 0x8) <- ((? add 0xffffffffffffff70) xor (? add 0xffffffffffffff70))
    //   0x28d9583b929  ((? add 0xffffffffffffff70) add 0x8) <- ((? add 0xffffffffffffff70) xor (? add 0xffffffffffffff70))
    //   0x28d9583b93b  ((? add 0xffffffffffffff70) add 0x20) <- this
    // returns: get_Task(((? add 0xffffffffffffff70) add 0x8), (? add 0xffffffffffffff70), 0x60, ?)
}
