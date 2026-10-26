// ============================================================
// token 0x0600002e   386822932A254DF5::8327E502A29C4E7A
// native code: 0x28d9581d4e0  (242 bytes)
// kind: LOOP   confidence: high
// original IL signature:
//   .method assembly hidebysig
//   instance void '8327E502A29C4E7A' (
//   uint32 distance,
//   uint32 len
//   ) cil managed
//   
// native-calls: 0600002d
// native-strings: 
// ============================================================

uint pos = Pos - distance - 1;
if (pos >= WindowSize) pos += WindowSize;
while (len-- > 0) {
    if (pos >= WindowSize) pos = 0;
    Buffer[Pos++] = Buffer[pos++];
    if (Pos >= WindowSize) Flush();
}
