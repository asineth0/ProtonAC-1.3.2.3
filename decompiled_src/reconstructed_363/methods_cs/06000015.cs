// ============================================================
// token 0x06000015   EEC15067D7014D61::5A685E2C85D94622
// native code: 0x28d9581b270  (121 bytes)
// kind: CALL_RET   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void '5A685E2C85D94622' (
//   uint32 dictionarySize
//   ) cil managed
//   
// native-calls: 0600002a
// native-strings: 
// ============================================================

if (DictionarySize == dictionarySize) return;
DictionarySize = dictionarySize;
DictionarySizeCheck = Math.Max(DictionarySize, 1u);
uint blockSize = Math.Max(DictionarySizeCheck, 1u << 12);
OutWindow.Create(blockSize);
