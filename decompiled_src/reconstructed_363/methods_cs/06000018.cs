// ============================================================
// token 0x06000018   EEC15067D7014D61::EDD9BC0532B04B33
// native code: 0x28d9581c380  (748 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void EDD9BC0532B04B33 (
//   class [mscorlib]System.IO.Stream inStream,
//   class [mscorlib]System.IO.Stream outStream
//   ) cil managed
//   
// native-calls: 0600000f,0600002b,06000008,06000021,0600000b,0600001d
// native-strings: 
// ============================================================

// LZMA.Decoder.Init(inStream, outStream)  (SDK-identical)
RangeDecoder.Init(inStream);
OutWindow.Init(outStream, Solid);

for (uint i = 0; i < kNumStates; i++)
{
    for (uint j = 0; j <= PosStateMask; j++)
    {
        uint index = (i << kNumPosStatesBitsMax) + j;
        IsMatchDecoders[index].Init();
        IsRep0LongDecoders[index].Init();
    }
    IsRepDecoders[i].Init();
    IsRepG0Decoders[i].Init();
    IsRepG1Decoders[i].Init();
    IsRepG2Decoders[i].Init();
}
LiteralDecoder.Init();
for (uint i = 0; i < kNumLenToPosStates; i++) PosSlotDecoder[i].Init();
for (uint i = 0; i < kNumFullDistances - kEndPosModelIndex; i++) PosDecoders[i].Init();
LenDecoder.Init();
RepLenDecoder.Init();
PosAlignDecoder.Init();

