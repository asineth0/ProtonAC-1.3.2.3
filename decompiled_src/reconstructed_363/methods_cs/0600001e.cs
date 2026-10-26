// ============================================================
// token 0x0600001e   9B079DF67D3C4497::7258175EBFC64560
// native code: 0x28d9581d230  (376 bytes)
// kind: SMALL_CALL   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint32 '7258175EBFC64560' (
//   class '<Module>'/EC1CFC21DD4E4A90 rangeDecoder,
//   uint32 posState
//   ) cil managed
//   
// native-calls: 06000009,0600000c
// native-strings: 
// ============================================================

if (Choice.Decode(rangeDecoder) == 0)
    return LowCoder[posState].Decode(rangeDecoder);
else {
    uint symbol = kNumLowLenSymbols;
    if (Choice2.Decode(rangeDecoder) == 0)
        symbol += MidCoder[posState].Decode(rangeDecoder);
    else {
        symbol += kNumMidLenSymbols;
        symbol += HighCoder.Decode(rangeDecoder);
    }
    return symbol;
}
