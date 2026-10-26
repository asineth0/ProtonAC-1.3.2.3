// ============================================================
// token 0x06000030   386822932A254DF5::7F0F018E704241F8
// native code: 0x28d9581d170  (107 bytes)
// kind: SMALL_CALL   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint8 '7F0F018E704241F8' (
//   uint32 distance
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

uint pos = Pos - distance - 1;
if (pos >= WindowSize) pos += WindowSize;
return Buffer[pos];
