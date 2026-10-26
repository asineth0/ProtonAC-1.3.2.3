// ============================================================
// token 0x06000012   EC1CFC21DD4E4A90::DA569CD2D6D24F3E
// native code: 0x28d9581d9c0  (215 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint32 DA569CD2D6D24F3E (
//   int32 numTotalBits
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

uint range = Range, code = Code, result = 0;
for (int i = numTotalBits; i > 0; i--) {
    range >>= 1;
    uint t = (code - range) >> 31;
    code -= range & (t - 1);
    result = (result << 1) | (1 - t);
    if (range < 16777216u) {
        code = (code << 8) | (byte)Stream.ReadByte();
        range <<= 8;
    }
}
Range = range; Code = code;
return result;
