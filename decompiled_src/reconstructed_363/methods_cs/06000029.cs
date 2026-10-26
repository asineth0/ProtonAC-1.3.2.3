// ============================================================
// token 0x06000029   83D27F3A38934C43::332E387D18214A27
// native code: 0x28d9581d6c0  (314 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint8 '332E387D18214A27' (
//   class '<Module>'/EC1CFC21DD4E4A90 rangeDecoder,
//   uint8 matchByte
//   ) cil managed
//   
// native-calls: 06000009
// native-strings: 
// ============================================================

uint symbol = 1;
do {
    uint matchBit = (uint)(matchByte >> 7) & 1;
    matchByte <<= 1;
    uint bit = Decoders[((1 + matchBit) << 8) + symbol].Decode(rangeDecoder);
    symbol = (symbol << 1) | bit;
    if (matchBit != bit) {
        while (symbol < 0x100)
            symbol = (symbol << 1) | Decoders[symbol].Decode(rangeDecoder);
        break;
    }
} while (symbol < 0x100);
return (byte)symbol;
