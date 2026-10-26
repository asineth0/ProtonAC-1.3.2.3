// ============================================================
// token 0x0600000e   5FE50471BBC64EF1::44790D73906349FF
// native code: 0x28d9581d890  (211 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig static
//   uint32 '44790D73906349FF' (
//   valuetype '<Module>'/'8A0B3F4694D8411A'[] Models,
//   uint32 startIndex,
//   class '<Module>'/EC1CFC21DD4E4A90 rangeDecoder,
//   int32 NumBitLevels
//   ) cil managed
//   
// native-calls: 06000009
// native-strings: 
// ============================================================

uint m = 1, symbol = 0;
for (int i = 0; i < NumBitLevels; i++) {
    uint bit = Models[startIndex + m].Decode(rangeDecoder);
    m = (m << 1) | bit;
    symbol |= bit << i;
}
return symbol;
