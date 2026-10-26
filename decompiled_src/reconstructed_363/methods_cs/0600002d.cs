// ============================================================
// token 0x0600002d   386822932A254DF5::D9FBF049DA9C4CF1
// native code: 0x28d9581c930  (107 bytes)
// kind: SMALL_CALL   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void D9FBF049DA9C4CF1 () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

uint size = Pos - StreamPos;
if (size == 0) return;
Stream.Write(Buffer, (int)StreamPos, (int)size);
if (Pos >= WindowSize) Pos = 0;
StreamPos = Pos;
