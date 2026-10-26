// ============================================================
// token 0x06001349   EB69693599F64B76::BC87B91F67354814
// native code: 0x28d958db290  (553 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task BC87B91F67354814 (
//   class '652C34B1E6554F10' '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000006
// native-strings: 
// ============================================================

public  Task BC87B91F67354814(652C34B1E6554F10 arg0, valuetype Threading.CancellationToken arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d958db2d8  memset((? add 0xffffffffffffff58), (arg0 xor arg0), 0x60, ?)
    //   0x28d958db318  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0xffffffffecec9d15)
    //   0x28d958db368  WBARRIER(((? add 0xffffffffffffff58) add 0x20), 0xffffffffecec9d15)
    //   0x28d958db3e8  WBARRIER(((? add 0xffffffffffffff58) add 0x28), ((((((0x4b4d1ba9+59791c2 neg 0x1) not 0x1) not 0x1) add 0xfa629d3d82dbcfc7) div 0x3) mod 0x3))
    //   0x28d958db438  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0x4af7e87d)
    //   0x28d958db450  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0x4af7e87d) xor 0x1ea9b3a2))
    //   0x28d958db480  Start(((? add 0xffffffffffffff58) add 0x8), (? add 0xffffffffffffff58), 0x4af7e87d, ?)
    //   0x28d958db4a0  get_Task(((? add 0xffffffffffffff58) add 0x8), (? add 0xffffffffffffff58), 0x4af7e87d, ?)
    // 6 store(s):
    //   0x28d958db33a  ((? add 0xffffffffffffff58) add 0x8) <- ((? add 0xffffffffffffffb8) xor (? add 0xffffffffffffffb8))
    //   0x28d958db341  ((? add 0xffffffffffffff58) add 0x8) <- ((? add 0xffffffffffffffb8) xor (? add 0xffffffffffffffb8))
    //   0x28d958db349  ((? add 0xffffffffffffff58) add 0x8) <- ((? add 0xffffffffffffffb8) xor (? add 0xffffffffffffffb8))
    //   0x28d958db35b  ((? add 0xffffffffffffff58) add 0x20) <- this
    //   0x28d958db3d9  ((? add 0xffffffffffffff58) add 0x28) <- arg0
    //   0x28d958db3ff  ((? add 0xffffffffffffff58) add 0x30) <- arg1
    // returns: get_Task(((? add 0xffffffffffffff58) add 0x8), (? add 0xffffffffffffff58), 0x4af7e87d, ?)
}
