// ============================================================
// token 0x0600002a   386822932A254DF5::A47CA5EA71584F8B
// native code: 0x28d9581b330  (120 bytes)
// kind: CALL_RET   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void A47CA5EA71584F8B (
//   uint32 windowSize
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

if (windowSize != WindowSize) {
    Buffer = new byte[windowSize];
    WindowSize = windowSize;
    Pos = 0;
    StreamPos = 0;
}
