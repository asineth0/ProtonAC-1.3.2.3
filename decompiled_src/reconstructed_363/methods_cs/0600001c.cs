// ============================================================
// token 0x0600001c   9B079DF67D3C4497::EEDAA5DB79104D6C
// native code: 0x28d9581b6e0  (402 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void EEDAA5DB79104D6C (
//   uint32 numPosStates
//   ) cil managed
//   
// native-calls: 0600000a
// native-strings: 
// ============================================================

for (uint posState = NumPosStates; posState < numPosStates; posState++) {
    LowCoder[posState] = new BitTreeDecoder(kNumLowLenBits);
    MidCoder[posState] = new BitTreeDecoder(kNumMidLenBits);
}
NumPosStates = numPosStates;
