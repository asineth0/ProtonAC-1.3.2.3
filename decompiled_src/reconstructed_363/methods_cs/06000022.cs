// ============================================================
// token 0x06000022   4A7DB6E4806E4AE0::DE52A1C8DA0A44EE
// native code: 0x28d9581cfc0  (75 bytes)
// kind: OTHER   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint32 DE52A1C8DA0A44EE (
//   uint32 pos,
//   uint8 prevByte
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

return ((pos & PosMask) << NumPrevBits) + (uint)(prevByte >> (8 - NumPrevBits));
