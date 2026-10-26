// ============================================================
// token 0x0600000f   EC1CFC21DD4E4A90::5E426B582A5449F7
// native code: 0x28d9581c790  (127 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void '5E426B582A5449F7' (
//   class [mscorlib]System.IO.Stream 'stream'
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

Stream = stream;
Code = 0;
Range = 0xFFFFFFFFu;
for (int i = 0; i < 5; i++)
    Code = (Code << 8) | (byte)stream.ReadByte();
