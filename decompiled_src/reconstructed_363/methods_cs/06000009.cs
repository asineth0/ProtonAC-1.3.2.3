// ============================================================
// token 0x06000009   8A0B3F4694D8411A::9385437DDFDE4D95
// native code: 0x28d9581cd50  (266 bytes)
// kind: SMALL_CALL   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint32 '9385437DDFDE4D95' (
//   class '<Module>'/EC1CFC21DD4E4A90 rangeDecoder
//   ) cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

// RangeCoder.BitDecoder.Decode
uint newBound = (rangeDecoder.Range >> 11) * Prob;
if (rangeDecoder.Code < newBound) {
    rangeDecoder.Range = newBound;
    Prob += (2048u - Prob) >> 5;
    if (rangeDecoder.Range < 16777216u) {
        rangeDecoder.Code = (rangeDecoder.Code << 8) | (byte)rangeDecoder.Stream.ReadByte();
        rangeDecoder.Range <<= 8;
    }
    return 0;
}
rangeDecoder.Range -= newBound;
rangeDecoder.Code -= newBound;
Prob -= Prob >> 5;
if (rangeDecoder.Range < 16777216u) {
    rangeDecoder.Code = (rangeDecoder.Code << 8) | (byte)rangeDecoder.Stream.ReadByte();
    rangeDecoder.Range <<= 8;
}
return 1;
