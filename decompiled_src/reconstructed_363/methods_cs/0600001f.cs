// ============================================================
// token 0x0600001f   9B079DF67D3C4497::.ctor
// native code: 0x28d9581ae70  (283 bytes)
// kind: SMALL_CALL   confidence: exact
// original IL signature:
//   .method assembly hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 0600000a
// native-strings: 
// ============================================================

Choice = new BitDecoder(); Choice2 = new BitDecoder();
LowCoder = new BitTreeDecoder[kNumPosStatesMax];
MidCoder = new BitTreeDecoder[kNumPosStatesMax];
HighCoder = new BitTreeDecoder(kNumHighLenBits);
