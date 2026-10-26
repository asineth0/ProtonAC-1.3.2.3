// ============================================================
// token 0x06000002   <Module>::272A6D0FCC934A06
// native code: 0x28d9581a550  (529 bytes)
// kind: LOOP   confidence: medium
// original IL signature:
//   .method assembly hidebysig static
//   uint8[] '272A6D0FCC934A06' (
//   uint8[] data
//   ) cil managed
//   
// native-calls: 06000014,0600001a,06000019
// native-strings: 
// ============================================================

// <Module>::272A6D0FCC934A06(byte[] data)
// Decompressor used by <Module>::.cctor to turn the 0x1d00-byte buffer into the
// 0x493c-byte string table _9F554F48BAED4B21.
// Native outline (529 bytes @0x28d9581a550):
//   new MemoryStream(data) -> new BinaryReader(stream)
//   Read 5 bytes, Read 4 bytes, ReadInt32, allocate byte[] of the decoded size,
//   then run the LZ-style copy loop and return the byte[].
// The final live string table was captured from the dump (string_blob_live.bin),
// so the exact decompressor body is not required for string recovery.
