// ============================================================
// token 0x06000292   E651E17AA2CA4BC8::408AEEE548064800
// native code: 0x28d970337d0  (441 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task '408AEEE548064800' (
//   valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06000005
// native-strings: 
// ============================================================

 Task 408AEEE548064800(Threading.CancellationToken arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d97033818  memset((? add 0xffffffffffffff60), (arg0 xor arg0), 0x68, ?)
    //   0x28d970338e8  WBARRIER(((? add 0xffffffffffffff60) add 0x20), ((((((((((0xd935ed42785d818 sub 0x1910eeb1) xor 0xb23008b262ada911) imul 0xbe29869) not 0x1) sub 0xffffffff18af49be) xor 0xc86f5a4d) imul 0x7c6fec17) not 0x1) div 0x3) mod 
    //   0x28d97033918  <Module>::F84FA79ABE6944BB(0x55eec410)   ; =-1
    //   0x28d97033948  Start(((? add 0xffffffffffffff60) add 0x8), (? add 0xffffffffffffff60), 0x68, ?)
    //   0x28d97033970  get_Task(((? add 0xffffffffffffff60) add 0x8), (? add 0xffffffffffffff60), 0x68, ?)
    // 5 store(s):
    //   0x28d9703383a  ((? add 0xffffffffffffff60) add 0x8) <- ((? add 0xffffffffffffff60) xor (? add 0xffffffffffffff60))
    //   0x28d97033841  ((? add 0xffffffffffffff60) add 0x8) <- ((? add 0xffffffffffffff60) xor (? add 0xffffffffffffff60))
    //   0x28d97033849  ((? add 0xffffffffffffff60) add 0x8) <- ((? add 0xffffffffffffff60) xor (? add 0xffffffffffffff60))
    //   0x28d970338db  ((? add 0xffffffffffffff60) add 0x20) <- this
    //   0x28d970338ff  ((? add 0xffffffffffffff60) add 0x28) <- arg0
    // returns: get_Task(((? add 0xffffffffffffff60) add 0x8), (? add 0xffffffffffffff60), 0x68, ?)
}
