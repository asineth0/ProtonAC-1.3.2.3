// ============================================================
// token 0x0600001d   9B079DF67D3C4497::9BAD2AC2B3DE401E
// native code: 0x28d9581cbd0  (313 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void '9BAD2AC2B3DE401E' () cil managed
//   
// native-calls: 06000008,0600000b
// native-strings: 
// ============================================================

Choice.Init();
for (uint posState = 0; posState < NumPosStates; posState++) {
    LowCoder[posState].Init();
    MidCoder[posState].Init();
}
Choice2.Init();
HighCoder.Init();
