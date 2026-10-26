// ============================================================
// token 0x060018c6   D303E6A3CA8C49F1::E2A3D410DBAC4E3A
// native code: 0x28d959e5e20  (2898 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method public hidebysig static
//   valuetype [netstandard]System.ArraySegment`1<uint8> E2A3D410DBAC4E3A (
//   class '652C34B1E6554F10' '',
//   valuetype '59751E20330E4047' '',
//   bool ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,060018c9,06001943,06000006,060018d6,060018d7,060018d8,060018d9,060018df,0600071a,06000004,060018d3,060018d4,06000007,060018d0,060018d1,060018d2,060018dc,060018da,060018db,060018d5,060018ce,060018dd,060018de,060018cf,06000003,060018ca,060018cb,060018cc,060018cd
// native-strings: 
// ============================================================

public static ArraySegment<uint8> E2A3D410DBAC4E3A(652C34B1E6554F10 arg0, 59751E20330E4047 arg1, bool arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 65 call(s):
    //   0x28d959e5ea0  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff88), 0xffffffff95bc5d60)
    //   0x28d959e5ec0  D303E6A3CA8C49F1::36030A7EF71843B4((movsxd arg2), arg0)
    //   0x28d959e5ef0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x4, 0x5f366733)
    //   0x28d959e5f08  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x4, 0x5f366733) xor 0x2efc021c))
    //   0x28d959e5fa8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0xffffffffffffff86, 0xffffffffe79a421f, ?)
    //   0x28d959e5fd8  D303E6A3CA8C49F1::34385E46A0CF4D4E(arg0)
    //   0x28d959e5ff0  D303E6A3CA8C49F1::04BCD9A8611A4846((r12 xor r12), D303E6A3CA8C49F1::34385E46A0CF4D4E(arg0))
    //   0x28d959e6008  D303E6A3CA8C49F1::80EED1F09C054D02(arg0)
    //   0x28d959e6020  D303E6A3CA8C49F1::753DB4091B8B4C26((r12 xor r12), D303E6A3CA8C49F1::80EED1F09C054D02(arg0))
    //   0x28d959e6050  D303E6A3CA8C49F1::233086BA35624E32(0x0, D303E6A3CA8C49F1::80EED1F09C054D02(arg0), 0xffffffffe79a421f, ?)
    //   0x28d959e6078  ArraySegment`1::.ctor((? add 0xffffffffffffff98), D303E6A3CA8C49F1::233086BA35624E32(0x0, D303E6A3CA8C49F1::80EED1F09C054D02(arg0), 0xffffffffe79a421f, ?), 0xffffffffe79a421f, ?)
    //   0x28d959e60b8  sub_28b82780dcb(arg1, (D303E6A3CA8C49F1::233086BA35624E32(0x0, D303E6A3CA8C49F1::80EED1F09C054D02(arg0), 0xffffffffe79a421f, ?) xor D303E6A3CA8C49F1::233086BA35624E32(0x0, D303E6A3CA8C49F1::80EED1F09C054D02(arg0), 0xffffffffe7
    //   0x28d959e60f8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x55c6eda9)
    //   0x28d959e6110  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x55c6eda9) xor 0x11fed52d))
    //   0x28d959e6128  D303E6A3CA8C49F1::DAF651182BDC4A65(0x0, (movsxd <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x55c6eda9) xor 0x11fed52d))))
    //   0x28d959e6148  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), ((movsxd <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x55c6eda9) xor 0x11fed52d))) xor (movsxd <Module>::
    //   0x28d959e6160  <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), ((movsxd <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x55c6eda9) xor 0x11fed5
    //   0x28d959e6178  D303E6A3CA8C49F1::C257A3905F2C42E7(0x0, (movsxd <Module>::58ECCB512F2A43AC((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), ((movsxd <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0x
    //   0x28d959e61e8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x6d9c220b)
    //   0x28d959e6200  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x6d9c220b) xor 0x16ea390f))
    //   0x28d959e6210  D303E6A3CA8C49F1::D03DB13877964667(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x6d9c220b) xor 0x16ea390f)))
    //   0x28d959e6230  sub_7fff670b7af0(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x6d9c220b) xor 0x16ea390f)), 0x8, 0x6d9c220b, ?)
    //   0x28d959e6260  WBARRIER((sub_7fff670b7af0(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x6d9c220b) xor 0x16ea390f)), 0x8, 0x6d9c220b, ?).f60.f0 add 0x100), 0x8)
    //   0x28d959e62a0  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff88), 0x48932d0e)
    //   0x28d959e62b0  sub_7fff670b7af0((? add 0xffffffffffffff88), 0x48932d0e, 0x6d9c220b, ?)
    //   0x28d959e62e0  D303E6A3CA8C49F1::ADB37DAACD3F4BA8()
    //   0x28d959e6308  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x1, 0x3fc62c09)
    //   0x28d959e6328  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), (0x1 xor 0x1), 0x6d9c220b)
    //   0x28d959e6340  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), (0x1 xor 0x1), 0x6d9c220b) xor 0x49a52fc2))
    //   0x28d959e6360  D303E6A3CA8C49F1::567FBBD865F749D6(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x48932d0e, 0x6d9c220b, ?).f60.f0.f100, D303E6A3CA8C49F1::ADB37DAACD3F4BA8(), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2
    //   0x28d959e6378  sub_7fff670b7af0(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x48932d0e, 0x6d9c220b, ?).f60.f0.f100, D303E6A3CA8C49F1::ADB37DAACD3F4BA8(), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffff
    //   0x28d959e63a8  WBARRIER((sub_7fff670b7af0(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x48932d0e, 0x6d9c220b, ?).f60.f0.f100, D303E6A3CA8C49F1::ADB37DAACD3F4BA8(), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 
    //   0x28d959e63e0  D303E6A3CA8C49F1::A7783E3DAEF64D28(arg0, (r12 xor r12))
    //   0x28d959e6470  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0xffffffffffffff84, 0xfffffffff5c5745f, ?)
    //   0x28d959e6498  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0xffffffffffffff89, 0x787bfd3f, ?)
    //   0x28d959e64b8  D303E6A3CA8C49F1::B016C01714C94AEF(arg0)
    //   0x28d959e64d0  D303E6A3CA8C49F1::AE66D99A94054929((r12 xor r12), D303E6A3CA8C49F1::B016C01714C94AEF(arg0))
    //   0x28d959e6508  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff88), 0xffffffffc1bb277f)
    //   0x28d959e6520  D303E6A3CA8C49F1::ACB6DFDAB9E848EA((r12 xor r12), D303E6A3CA8C49F1::36030A7EF71843B4((movsxd arg2), arg0))
    //   0x28d959e6558  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x9, 0x6c6bf422, ?)
    //   0x28d959e6588  D303E6A3CA8C49F1::8347FC956D1A4041(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x48932d0e, 0x6d9c220b, ?).f60.f0.f100)
    //   0x28d959e65b0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x3, (0x6c6bf422 xor 0x6c6bf422))
    //   0x28d959e65c8  <Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x3, (0x6c6bf422 xor 0x6c6bf422)) xor 0xe523872f))
    //   0x28d959e6628  D303E6A3CA8C49F1::DCFA6336516147F7((r12 xor r12))
    //   0x28d959e6648  D303E6A3CA8C49F1::04AD8EB160C14DC8(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x48932d0e, 0x6d9c220b, ?).f60.f0.f100, (? add 0xffffffffffffff78))
    //   0x28d959e66a8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x1, 0x32ae20b0)
    //   0x28d959e66c0  sub_7fff670b7af0((? add 0xffffffffffffff88), 0x1, 0x32ae20b0, ?)
    //   0x28d959e6700  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x1, 0xffffffffbb260b92)
    //   0x28d959e6710  sub_7fff670b7af0((? add 0xffffffffffffff88), 0x1, 0xffffffffbb260b92, ?)
    //   0x28d959e6750  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x1, 0x513c865)
    //   0x28d959e6778  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x1, 0x513c865, ?)
    //   0x28d959e6790  D303E6A3CA8C49F1::7B91F3448E524915(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x1, 0xffffffffbb260b92, ?).f60.f0.f108, 0x1, 0x513c865, ?)
    //   0x28d959e67c8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0xffffffffffffff83, 0xffffffffbacbc2ff, ?)
    //   0x28d959e67e0  D303E6A3CA8C49F1::ACB6DFDAB9E848EA(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x1, 0x32ae20b0, ?).f60.f0.f108, (D303E6A3CA8C49F1::36030A7EF71843B4((movsxd arg2), arg0) not 0x1), 0xffffffffbacbc2ff, ?)
    //   0x28d959e67f8  D303E6A3CA8C49F1::34385E46A0CF4D4E(arg0, (D303E6A3CA8C49F1::36030A7EF71843B4((movsxd arg2), arg0) not 0x1), 0xffffffffbacbc2ff, ?)
    //   0x28d959e6810  D303E6A3CA8C49F1::04BCD9A8611A4846(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x1, 0x32ae20b0, ?).f60.f0.f108, D303E6A3CA8C49F1::34385E46A0CF4D4E(arg0, (D303E6A3CA8C49F1::36030A7EF71843B4((movsxd arg2), arg0) not 0x1), 0xfff
    //   0x28d959e6850  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0xfffffffff2bd2132, ?)
    //   0x28d959e6870  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0xfffffffff2bd2132, ?) xor 0x70938631), 0x8, 0xfffffffff2bd2132, ?)
    //   0x28d959e6890  D303E6A3CA8C49F1::6A7D9BA8ECFC4DF3(arg0, 0x8, 0xfffffffff2bd2132, ?)
    //   0x28d959e68a0  D303E6A3CA8C49F1::97EFFAFD5F7C43B1(D303E6A3CA8C49F1::6A7D9BA8ECFC4DF3(arg0, 0x8, 0xfffffffff2bd2132, ?), 0x8, 0xfffffffff2bd2132, ?)
    //   0x28d959e68b8  D303E6A3CA8C49F1::9AE3E85402EE4EF1(<Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0xfffffffff2bd2132, ?) xor 0x70938631), 0x8, 0xfffffffff2bd2132, ?), D303E6A3CA8C49F1::97
    //   0x28d959e68c8  D303E6A3CA8C49F1::747D1A0AB2454F45(D303E6A3CA8C49F1::9AE3E85402EE4EF1(<Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0xfffffffff2bd2132, ?) xor 0x70938631), 0x8, 0xfffffff
    //   0x28d959e68d8  ?(D303E6A3CA8C49F1::747D1A0AB2454F45(D303E6A3CA8C49F1::9AE3E85402EE4EF1(<Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0xfffffffff2bd2132, ?) xor 0x70938631), 0x8, 0xfffff
    //   0x28d959e68f8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x4008838f)
    //   0x28d959e6938  WBARRIER(arg1, (rax xor rax))
    // 6 store(s):
    //   0x28d959e609d  arg1 <- (D303E6A3CA8C49F1::233086BA35624E32(0x0, D303E6A3CA8C49F1::80EED1F09C054D02(arg0), 0xffffffffe79a421f, ?) xor D303E6A3CA8C49F1::233086BA35624E32(0x0, D303E6A3CA8C
    //   0x28d959e60d1  (arg1 add 0x8) <- (D303E6A3CA8C49F1::233086BA35624E32(0x0, D303E6A3CA8C49F1::80EED1F09C054D02(arg0), 0xffffffffe79a421f, ?) xor D303E6A3CA8C49F1::233086BA35624E32(0x0, D303E6A3CA8C
    //   0x28d959e6247  (sub_7fff670b7af0(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x6d9c220b) xor 0x16ea390f)), 0x8, 0x6d9c220b, ?).f60.f0 add 0x100) <- D303E6A3CA8C49F1::D03DB13877964667(<Module>::3F57E81A62734AC2((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), 0x8, 0x6d9c220b) xor 0x16ea390f)))
    //   0x28d959e638f  (sub_7fff670b7af0(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x48932d0e, 0x6d9c220b, ?).f60.f0.f100, D303E6A3CA8C49F1::ADB37DAACD3F4BA8(), <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff88), (0x1 xor 0x1), 0x6d9c220b) xor 0x49a52fc2)), ?).f60.f0 add 0x108) <- D303E6A3CA8C49F1::567FBBD865F749D6(sub_7fff670b7af0((? add 0xffffffffffffff88), 0x48932d0e, 0x6d9c220b, ?).f60.f0.f100, D303E6A3CA8C49F1::ADB37DAACD3F4BA8(), <M
    //   0x28d959e6920  arg1 <- (rax xor rax)
    //   0x28d959e6951  (arg1 add 0x8) <- (rax xor rax)
    // returns: (arg1 add 0x8)
}
