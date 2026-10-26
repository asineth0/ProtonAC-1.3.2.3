// ============================================================
// token 0x0600000d   5FE50471BBC64EF1::4C26482FE8BB4317
// native code: 0x28d9581dab0  (203 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint32 '4C26482FE8BB4317' (
//   class '<Module>'/EC1CFC21DD4E4A90 rangeDecoder
//   ) cil managed
//   
// native-calls: 06000009
// native-strings: 
// ============================================================

uint m = 1, symbol = 0;
for (int i = 0; i < NumBitLevels; i++) {
    uint bit = Models[m].Decode(rangeDecoder);
    m = (m << 1) | bit;
    symbol |= bit << i;
}
return symbol;
