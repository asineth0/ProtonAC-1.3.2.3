// ============================================================
// token 0x0600001a   EEC15067D7014D61::8243EA5E10994C2E
// native code: 0x28d9581b080  (337 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void '8243EA5E10994C2E' (
//   uint8[] properties
//   ) cil managed
//   
// native-calls: 06000015,06000016,06000017
// native-strings: 
// ============================================================

// LZMA.Decoder.SetDecoderProperties(byte[] properties)  (SDK-identical)
if (properties.Length < 5) throw new InvalidParamException();
int lc = properties[0] % 9;
int remainder = properties[0] / 9;
int lp = remainder % 5;
int pb = remainder / 5;
if (pb > kNumPosStatesBitsMax) throw new InvalidParamException();
uint dict = 0;
for (int i = 0; i < 4; i++)
    dict += ((uint)properties[1 + i]) << (i * 8);
SetDictionarySize(dict);
SetLcLp(lp, lc);
SetPb(pb);

