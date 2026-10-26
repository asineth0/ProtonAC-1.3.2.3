// ============================================================
// token 0x06000d14   C0225ABF72C4425E::EB02E7E2E9E945AA
// native code: 0x28d9586e4d0  (646 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private hidebysig static
//   string EB02E7E2E9E945AA (
//   valuetype [ProtonAC.Microsoft.Extensions.Logging.Abstractions]Microsoft.Extensions.Logging.LogLevel ''
//   ) cil managed noinlining
//   
// native-calls: 06000007,06000004
// native-strings: 0x258c:INFO,0x2584:DBUG,0x257c:TRCE
// ============================================================

static string EB02E7E2E9E945AA(Microsoft.Extensions.Logging.LogLevel arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 7 call(s):
    //   0x28d9586e598  <Module>::3F57E81A62734AC2(0xffffffffefa5ebdc)   ; "INFO"
    //   0x28d9586e5d0  <Module>::3F57E81A62734AC2(0xffffffffd4e7a986, ((((((0xf9d3e4dd8544f360 sub (0x414c8daa not 0x1)) imul 0x4027052f) imul 0x5661e8b3) imul 0xea541ecb) div 0xd) mod 0xd), ?, ?)
    //   0x28d9586e630  <Module>::3F57E81A62734AC2(0xa642e32)   ; "DBUG"
    //   0x28d9586e660  <Module>::390073C602714496(0x4d3d7ead, ((((((0xf9d3e4dd8544f360 sub (0x414c8daa not 0x1)) imul 0x4027052f) imul 0x5661e8b3) imul 0xea541ecb) div 0xd) mod 0xd), ?, ?)
    //   0x28d9586e698  <Module>::3F57E81A62734AC2(0xfffffffffb148338)   ; "TRCE"
    //   0x28d9586e6f8  <Module>::390073C602714496(0x151b2551, ((((((0xf9d3e4dd8544f360 sub (0x414c8daa not 0x1)) imul 0x4027052f) imul 0x5661e8b3) imul 0xea541ecb) div 0xd) mod 0xd), ?, ?)
    //   0x28d9586e728  <Module>::3F57E81A62734AC2(0x755d378a, ((((((0xf9d3e4dd8544f360 sub (0x414c8daa not 0x1)) imul 0x4027052f) imul 0x5661e8b3) imul 0xea541ecb) div 0xd) mod 0xd), ?, ?)
    // returns: <Module>::3F57E81A62734AC2(0x755d378a, ((((((0xf9d3e4dd8544f360 sub (0x414c8daa not 0x1)) imul 0x4027052f) imul 0x5661e8b3) imul 0xea541ecb) div 0xd) mod 0xd), ?, ?)
    // string table refs:
    //   0x258c  "INFO"
    //   0x2584  "DBUG"
    //   0x257c  "TRCE"
}
