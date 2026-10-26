// ============================================================
// token 0x06000014   EEC15067D7014D61::.ctor
// native code: 0x28d9581a800  (1411 bytes)
// kind: LOOP   confidence: high
// original IL signature:
//   .method assembly hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 0600001f,06000025,06000031,06000013,0600000a
// native-strings: 
// ============================================================

// LZMA.Decoder ctor: creates the bit-model tables
IsMatchDecoders     = new BitDecoder[kNumStates << kNumPosStatesBitsMax];
IsRepDecoders       = new BitDecoder[kNumStates];
IsRepG0Decoders     = new BitDecoder[kNumStates];
IsRepG1Decoders     = new BitDecoder[kNumStates];
IsRepG2Decoders     = new BitDecoder[kNumStates];
IsRep0LongDecoders  = new BitDecoder[kNumStates << kNumPosStatesBitsMax];
PosSlotDecoder      = new BitTreeDecoder[kNumLenToPosStates];
for (int i = 0; i < kNumLenToPosStates; i++)
    PosSlotDecoder[i] = new BitTreeDecoder(kNumPosSlotBits);
PosDecoders         = new BitDecoder[kNumFullDistances - kEndPosModelIndex];
PosAlignDecoder     = new BitTreeDecoder(kNumAlignBits);
LenDecoder          = new LenDecoder();
RepLenDecoder       = new LenDecoder();
LiteralDecoder      = new LiteralDecoder();
OutWindow           = new OutWindow();
RangeDecoder        = new RangeCoder.Decoder();
DictionarySize      = 0xFFFFFFFFu;
DictionarySizeCheck = 0;
SetDictionarySize(1u << 12);
