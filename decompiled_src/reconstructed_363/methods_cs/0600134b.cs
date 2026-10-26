// ============================================================
// token 0x0600134b   EB69693599F64B76::F5A6A61E65934D1F
// native code: 0x28d97308e60  (229 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method public hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task F5A6A61E65934D1F (
//   class '652C34B1E6554F10' '',
//   int64 '',
//   [opt] valuetype [netstandard]System.Threading.CancellationToken ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001358,06001943,06000007,06001359,0600135a
// native-strings: 
// ============================================================

public  Task F5A6A61E65934D1F(652C34B1E6554F10 arg0, long arg1, valuetype Threading.CancellationToken arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 6 call(s):
    //   0x28d97308eb8  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffe8), 0xffffffff9fddec57)
    //   0x28d97308ed0  EB69693599F64B76::F4C676F84DBA4E25(arg0, arg1)
    //   0x28d97308ef0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), 0x4, 0x39d601e1)
    //   0x28d97308f08  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), 0x4, 0x39d601e1) xor 0x4342bcd0))
    //   0x28d97308f20  EB69693599F64B76::2B2CE6FA81974211(arg0, <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffe8), 0x4, 0x39d601e1) xor 0x4342bcd0)))
    //   0x28d97308f38  EB69693599F64B76::E70F42657B0F47CF(this, arg0, arg2)
    // returns: EB69693599F64B76::E70F42657B0F47CF(this, arg0, arg2)
}
