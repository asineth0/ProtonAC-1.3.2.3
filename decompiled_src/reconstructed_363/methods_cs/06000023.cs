// ============================================================
// token 0x06000023   4A7DB6E4806E4AE0::4001CF03F30D4B13
// native code: 0x28d9581cec0  (147 bytes)
// kind: SMALL_CALL   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint8 '4001CF03F30D4B13' (
//   class '<Module>'/EC1CFC21DD4E4A90 rangeDecoder,
//   uint32 pos,
//   uint8 prevByte
//   ) cil managed
//   
// native-calls: 06000022,06000028
// native-strings: 
// ============================================================

return Coders[GetState(pos, prevByte)].DecodeNormal(rangeDecoder);
