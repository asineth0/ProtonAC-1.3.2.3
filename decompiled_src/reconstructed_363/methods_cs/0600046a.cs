// ============================================================
// token 0x0600046a   8162F8F545F5474A::.cctor
// native code: 0x28d95a0dbf0  (360 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed noinlining
//   
// native-calls: 0600046b,0600046c,06000005,06000007,0600046d
// native-strings: 
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 7 call(s):
    //   0x28d95a0dc10  8162F8F545F5474A::921DFC786DF5479E()
    //   0x28d95a0dc20  8162F8F545F5474A::0B1BAE0D9C324FA5(8162F8F545F5474A::921DFC786DF5479E())
    //   0x28d95a0dc50  WBARRIER(0x28cca2db200, ?)
    //   0x28d95a0dcd0  <Module>::F84FA79ABE6944BB(0x67cf2da4)   ; =1
    //   0x28d95a0dce8  <Module>::3F57E81A62734AC2(0x3ca2d4c7)   ; =1
    //   0x28d95a0dd00  8162F8F545F5474A::32D3D94265C645F8(<Module>::F84FA79ABE6944BB(0x67cf2da4), <Module>::3F57E81A62734AC2(0x3ca2d4c7))
    //   0x28d95a0dd30  WBARRIER(0x28cca2db208, <Module>::3F57E81A62734AC2(0x3ca2d4c7))
    // 2 store(s):
    //   0x28d95a0dc39  0x28cca2db200 <- 8162F8F545F5474A::0B1BAE0D9C324FA5(8162F8F545F5474A::921DFC786DF5479E())
    //   0x28d95a0dd10  0x28cca2db208 <- 8162F8F545F5474A::32D3D94265C645F8(<Module>::F84FA79ABE6944BB(0x67cf2da4), <Module>::3F57E81A62734AC2(0x3ca2d4c7))
    // returns: 0x28cca2db208
}
