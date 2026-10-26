// ============================================================
// token 0x06001858   FE504B49A4DA4B00::7DAFE9A595F34D03
// native code: 0x28d959e6f70  (1539 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig static
//   int32 '7DAFE9A595F34D03' (
//   valuetype '59751E20330E4047' '',
//   class '652C34B1E6554F10' ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06001859,0600185a,06000006
// native-strings: 
// ============================================================

public static int 7DAFE9A595F34D03(59751E20330E4047 arg0, 652C34B1E6554F10 arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 23 call(s):
    //   0x28d959e6fd8  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffffb8), 0xcd96885)
    //   0x28d959e7000  sub_28b82782ba0(0x28d0e026878, 0xcd96885, ?, ?)
    //   0x28d959e7028  get_Item(0x28cca2db270.f0, arg0, ?, ?)
    //   0x28d959e7048  GetEnumerator(get_Item(0x28cca2db270.f0, arg0, ?, ?), (? add 0xffffffffffffff80), ?, ?)
    //   0x28d959e7070  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x8, 0xffffffff9bc867aa)
    //   0x28d959e7138  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, 0xffffffffc4728df8)
    //   0x28d959e7154  sub_28d959e7398((? add 0xffffffffffffffb8), 0x9, 0xffffffffc4728df8, ?)
    //   0x28d959e7178  sub_28b82785f1f((? add 0xffffffffffffffb8), 0x9, 0xffffffffc4728df8, ?)
    //   0x28d959e71a8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xffffffffffffff80, 0xffffffff8bddcf8f)
    //   0x28d959e71d0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xffffffffffffff89, 0x7f2cbbc5)
    //   0x28d959e71f8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xffffffffffffff86, 0xffffffff94752365)
    //   0x28d959e7220  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0xffffffffffffff87, 0x28955f05)
    //   0x28d959e7268  FE504B49A4DA4B00::727D12CE409241B7(((? add 0xffffffffffffff80) add 0x10).f8)
    //   0x28d959e7280  FE504B49A4DA4B00::727D12CE409241B7(arg1)
    //   0x28d959e7298  FE504B49A4DA4B00::98086D9075584CC5(FE504B49A4DA4B00::727D12CE409241B7(((? add 0xffffffffffffff80) add 0x10).f8), FE504B49A4DA4B00::727D12CE409241B7(arg1))
    //   0x28d959e72e8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, 0x9a1e524)
    //   0x28d959e7300  MoveNext((? add 0xffffffffffffff80), 0x9, 0x9a1e524, ?)
    //   0x28d959e7358  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x9, 0xffffffffbad0a8d4, ?)
    //   0x28d959e736a  sub_28d959e7398((? add 0xffffffffffffffb8), 0x9, 0xffffffffbad0a8d4, ?)
    //   0x28d959e7390  sub_28b82785f1f((? add 0xffffffffffffffb8), 0x9, 0xffffffffbad0a8d4, ?)
    //   0x28d959e7478  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x6, 0xffffffff8b8fd705, ?)
    //   0x28d959e7490  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x6, 0xffffffff8b8fd705, ?) xor 0xbadb27ea), 0x6, 0xffffffff8b8fd705, ?)
    //   0x28d959e7540  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffffb8), 0x4, 0xffffffff9e84fd2a)
    // returns: (movsxd (movsxd (rax xor rax)))
}
