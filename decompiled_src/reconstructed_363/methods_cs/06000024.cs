// ============================================================
// token 0x06000024   4A7DB6E4806E4AE0::24916B1DB2C04FBB
// native code: 0x28d9581d5f0  (147 bytes)
// kind: SMALL_CALL   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint8 '24916B1DB2C04FBB' (
//   class '<Module>'/EC1CFC21DD4E4A90 rangeDecoder,
//   uint32 pos,
//   uint8 prevByte,
//   uint8 matchByte
//   ) cil managed
//   
// native-calls: 06000022,06000029
// native-strings: 
// ============================================================

return Coders[GetState(pos, prevByte)].DecodeWithMatchByte(rangeDecoder, matchByte);
