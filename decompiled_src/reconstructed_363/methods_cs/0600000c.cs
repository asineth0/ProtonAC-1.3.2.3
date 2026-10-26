// ============================================================
// token 0x0600000c   5FE50471BBC64EF1::A9A16D03ACAE49E8
// native code: 0x28d9581d3c0  (195 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance uint32 A9A16D03ACAE49E8 (
//   class '<Module>'/EC1CFC21DD4E4A90 rangeDecoder
//   ) cil managed
//   
// native-calls: 06000009
// native-strings: 
// ============================================================

uint m = 1;
for (int i = NumBitLevels; i > 0; i--)
    m = (m << 1) | Models[m].Decode(rangeDecoder);
return m - (1u << NumBitLevels);
