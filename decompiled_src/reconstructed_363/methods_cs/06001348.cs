// ============================================================
// token 0x06001348   EB69693599F64B76::A21AF88AEF814609
// native code: 0x28d958befb0  (553 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance class [netstandard]System.Threading.Tasks.Task A21AF88AEF814609 () cil managed noinlining
//   
// native-calls: 06001942,06001943,06000005,06001352,06001355,06001356,06001357
// native-strings: 
// ============================================================

 Task A21AF88AEF814609()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d958bf008  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffd0), 0xffffffffc11be468)
    //   0x28d958bf0e8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffd0), 0x7, (xor ?), ?)
    //   0x28d958bf108  <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffd0), 0x7, (xor ?), ?) xor 0x29df940f), 0x7, (xor ?), ?)
    //   0x28d958bf128  EB69693599F64B76::63C7696E08254366(this.f18, <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffd0), 0x7, (xor ?), ?) xor 0x29df940f), 0x7, (xor ?), ?), 0x28cc7550840, ?)
    //   0x28d958bf158  EB69693599F64B76::2207D0F3AAB445FA(this.f30, <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffd0), 0x7, (xor ?), ?) xor 0x29df940f), 0x7, (xor ?), ?), 0x28cc7550840, ?)
    //   0x28d958bf170  EB69693599F64B76::A35EDF805C774582(this.f30, <Module>::F84FA79ABE6944BB((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffd0), 0x7, (xor ?), ?) xor 0x29df940f), 0x7, (xor ?), ?), 0x28cc7550840, ?)
    //   0x28d958bf1b0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffd0), 0x6, 0x65ccaddc)
    //   0x28d958bf1c0  EB69693599F64B76::121FC7E3DDA44C65()
    // 1 store(s):
    //   0x28d958bf173  this <- 0x0
    // returns: EB69693599F64B76::121FC7E3DDA44C65()
}
