// ============================================================
// token 0x06001340   EB69693599F64B76::.ctor
// native code: 0x28d957e7eb0  (3005 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   class '5E780D61DAD9496E' '',
//   class [netstandard]System.Func`1<string> ''
//   ) cil managed noinlining
//   
// native-calls: 06001942,06001943,06000004,06000003,06001351,06001350
// native-strings: 
// ============================================================

public  void .ctor(5E780D61DAD9496E arg0, Func<string> arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 49 call(s):
    //   0x28d957e7f18  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff98), 0xffffffff86bca495)
    //   0x28d957e7f90  WBARRIER(this+88, ((((((((((0x44b86864 not 0x1) not 0x1) not 0x1) not 0x1) neg 0x1) xor 0xf07d8ade) not 0x1) neg 0x1) div 0x7) mod 0x7))
    //   0x28d957e7fe8  WBARRIER(this+38, ((((((((((0x44b86864 not 0x1) not 0x1) not 0x1) not 0x1) neg 0x1) xor 0xf07d8ade) not 0x1) neg 0x1) div 0x7) mod 0x7))
    //   0x28d957e8010  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0xa, 0x4c9bfdb)
    //   0x28d957e8028  <Module>::390073C602714496((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0xa, 0x4c9bfdb) xor 0x348f63fa))
    //   0x28d957e8038  FromSeconds((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0xa, 0x4c9bfdb) xor 0x348f63fa), 0xa, 0x4c9bfdb, ?)
    //   0x28d957e8078  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0x8, 0x392f3dbd)
    //   0x28d957e8090  <Module>::8B9C7B12B1AE4949((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0x8, 0x392f3dbd) xor 0xd27c093c))
    //   0x28d957e80a0  FromMinutes((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0x8, 0x392f3dbd) xor 0xd27c093c), 0x8, 0x392f3dbd, ?)
    //   0x28d957e80c8  EB69693599F64B76::A977E38F10864476()
    //   0x28d957e80e0  WBARRIER(this+48, 0x8)
    //   0x28d957e8100  ALLOC_OBJECT(0x28d94ffd020)
    //   0x28d957e8118  .ctor(ALLOC_OBJECT(0x28d94ffd020), 0x8, 0x392f3dbd, ?)
    //   0x28d957e8138  WBARRIER(this+50, 0x8)
    //   0x28d957e8190  ALLOC_OBJECT(0x28d94ffd390)
    //   0x28d957e81c8  WBARRIER((ALLOC_OBJECT(0x28d94ffd390) add 0x20), 0x8)
    //   0x28d957e8240  WBARRIER(0x28c840e6648, 0x28d94ffd460.f28)
    //   0x28d957e8270  81DD83B8AA2247AA::.ctor((? add 0xffffffffffffff98), 0xffffffff9f6bc1ec)
    //   0x28d957e8288  WBARRIER(this+58, 0xffffffff9f6bc1ec)
    //   0x28d957e82d8  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d957e8310  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), 0xffffffff9f6bc1ec)
    //   0x28d957e8388  WBARRIER(0x28c840e6650, 0x28d94ffd4c0.f28)
    //   0x28d957e83b8  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0x5, 0x4d0ccb9e)
    //   0x28d957e83d0  WBARRIER(this+60, 0x5)
    //   0x28d957e8420  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d957e8458  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), 0x5)
    //   0x28d957e84d0  WBARRIER(0x28c840e6658, 0x28d94ffd520.f28)
    //   0x28d957e8500  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0x8, 0x7ec19921)
    //   0x28d957e8518  WBARRIER(this+68, 0x8)
    //   0x28d957e8568  ALLOC_OBJECT(0x28cc83e9710)
    //   0x28d957e85a0  WBARRIER((ALLOC_OBJECT(0x28cc83e9710) add 0x20), 0x8)
    //   0x28d957e8618  WBARRIER(0x28c840e6660, 0x28d94ffd580.f28)
    //   0x28d957e8640  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), (0x28d94ffd580.f28 xor 0x28d94ffd580.f28), 0x3329c5ee)
    //   0x28d957e8658  WBARRIER(this+70, (0x28d94ffd580.f28 xor 0x28d94ffd580.f28))
    //   0x28d957e86a8  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d957e86e0  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), (0x28d94ffd580.f28 xor 0x28d94ffd580.f28))
    //   0x28d957e8758  WBARRIER(0x28c840e6668, 0x28d94ffd5e0.f28)
    //   0x28d957e8788  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0x1, 0x4cde90f7)
    //   0x28d957e87a0  WBARRIER(this+78, 0x1)
    //   0x28d957e87f0  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d957e8828  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), 0x1)
    //   0x28d957e88a0  WBARRIER(0x28c840e6670, 0x28d94ffd640.f28)
    //   0x28d957e88d0  81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0x1, 0xffffffffed8b00a5)
    //   0x28d957e88e8  WBARRIER(this+80, 0x1)
    //   0x28d957e8908  WBARRIER(this+18, 0x1)
    //   0x28d957e8930  EB69693599F64B76::A2883CF93E264FF9()
    //   0x28d957e8948  WBARRIER(this+10, 0x1)
    //   0x28d957e89f0  THROW(0x162, 0x7c)
    //   0x28d957e8a10  THROW(0xf3, 0x23d)
    // 60 store(s):
    //   0x28d957e7f81  this+88 <- arg1
    //   0x28d957e7fd5  this+38 <- 0x28c84118800
    //   0x28d957e8053  this+a8 <- FromSeconds((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0xa, 0x4c9bfdb) xor 0x348f63fa), 0xa, 0x4c9bfdb, ?)
    //   0x28d957e80bb  this+b0 <- FromMinutes((81DD83B8AA2247AA::184044A093C04AF2((? add 0xffffffffffffff98), 0x8, 0x392f3dbd) xor 0xd27c093c), 0x8, 0x392f3dbd, ?)
    //   0x28d957e80d3  this+48 <- EB69693599F64B76::A977E38F10864476()
    //   0x28d957e8127  this+50 <- ALLOC_OBJECT(0x28d94ffd020)
    //   0x28d957e81aa  ALLOC_OBJECT(0x28d94ffd390) <- 0x28cca878df0
    //   0x28d957e81e0  ALLOC_OBJECT(0x28d94ffd390) <- 0x28d95007cd8
    //   0x28d957e81ee  ALLOC_OBJECT(0x28d94ffd390) <- 0x28d94ffd458
    //   0x28d957e8200  ALLOC_OBJECT(0x28d94ffd390) <- 0x28d94ffd460.f28
    //   0x28d957e8208  ALLOC_OBJECT(0x28d94ffd390) <- 0x28d94ffd460.f20
    //   0x28d957e820c  ALLOC_OBJECT(0x28d94ffd390) <- 0x0
    //   0x28d957e8221  0x28c840e6648 <- ALLOC_OBJECT(0x28d94ffd390)
    //   0x28d957e8277  this+58 <- ALLOC_OBJECT(0x28d94ffd390)
    //   0x28d957e82f2  ALLOC_OBJECT(0x28cc8356f60) <- 0x28cca878df0
    //   0x28d957e8328  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d95007d28
    //   0x28d957e8336  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ffd4b8
    //   0x28d957e8348  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ffd4c0.f28
    //   0x28d957e8350  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ffd4c0.f20
    //   0x28d957e8354  ALLOC_OBJECT(0x28cc8356f60) <- 0x0
    //   0x28d957e8369  0x28c840e6650 <- ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d957e83bf  this+60 <- ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d957e843a  ALLOC_OBJECT(0x28cc8356f60) <- 0x28cca878df0
    //   0x28d957e8470  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d95007d50
    //   0x28d957e847e  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ffd518
    //   0x28d957e8490  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ffd520.f28
    //   0x28d957e8498  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94ffd520.f20
    //   0x28d957e849c  ALLOC_OBJECT(0x28cc8356f60) <- 0x0
    //   0x28d957e84b1  0x28c840e6658 <- ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d957e8507  this+68 <- ALLOC_OBJECT(0x28cc8356f60)
    // returns: (((((((((0x44b86864 not 0x1) not 0x1) not 0x1) not 0x1) neg 0x1) xor 0xf07d8ade) not 0x1) neg 0x1) imul 0xdedf32a6)
}
