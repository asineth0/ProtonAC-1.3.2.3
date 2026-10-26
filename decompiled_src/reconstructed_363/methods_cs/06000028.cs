// ============================================================
// token 0x06000028   83D27F3A38934C43::8B827561475F4C70
// native code: 0x28d9581d020  (155 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint8 '8B827561475F4C70' (
//   class '<Module>'/EC1CFC21DD4E4A90 rangeDecoder
//   ) cil managed
//   
// native-calls: 06000009
// native-strings: 
// ============================================================

uint symbol = 1;
do {
    uint bit = Decoders[symbol].Decode(rangeDecoder);
    symbol = (symbol << 1) | bit;
} while (symbol < 0x100);
return (byte)symbol;
