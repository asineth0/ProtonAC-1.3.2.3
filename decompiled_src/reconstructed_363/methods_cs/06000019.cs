// ============================================================
// token 0x06000019   EEC15067D7014D61::3AD92C56CB1D4E96
// native code: 0x28d9581b890  (1804 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void '3AD92C56CB1D4E96' (
//   class [mscorlib]System.IO.Stream inStream,
//   class [mscorlib]System.IO.Stream outStream,
//   int64 inSize,
//   int64 outSize
//   ) cil managed
//   
// native-calls: 06000018,06000032,06000009,06000033,06000023,0600002f,06000030,06000037,06000024,06000036,0600001e,06000035,06000034,0600001b,0600000c,0600000e,06000012,0600000d,0600002e,0600002d,0600002c,06000010
// native-strings: 
// ============================================================

// LZMA.Decoder.Code(inStream, outStream, inSize, outSize)  (SDK-identical)
Init(inStream, outStream);

F802DDD56AAD418F state = new F802DDD56AAD418F();
state.F05E99D5952142B7();                 // State.Init()
uint rep0 = 0, rep1 = 0, rep2 = 0, rep3 = 0;

ulong nowPos64 = 0;
ulong outSize64 = (ulong)outSize;
if (nowPos64 < outSize64)
{
    if (IsMatchDecoders[state._18E90C606D424267 << kNumPosStatesBitsMax]
            .Decode(RangeDecoder) != 0)
        throw new DataErrorException();
    state.DF4C66DD7D7E4F9A();             // UpdateChar()
    byte b = LiteralDecoder.DecodeNormal(RangeDecoder, 0, 0);
    OutWindow.PutByte(b);
    nowPos64++;
}
while (nowPos64 < outSize64)
{
    uint posState = (uint)nowPos64 & PosStateMask;
    if (IsMatchDecoders[(state._18E90C606D424267 << kNumPosStatesBitsMax) + posState]
            .Decode(RangeDecoder) == 0)
    {
        byte prevByte = OutWindow.GetByte(0);
        byte b = !state._5987B87C107C408B()   // !IsCharState()
            ? LiteralDecoder.DecodeWithMatchByte(RangeDecoder, (uint)nowPos64, prevByte, OutWindow.GetByte(rep0))
            : LiteralDecoder.DecodeNormal(RangeDecoder, (uint)nowPos64, prevByte);
        OutWindow.PutByte(b);
        state.DF4C66DD7D7E4F9A();         // UpdateChar()
        nowPos64++;
    }
    else
    {
        uint len;
        if (IsRepDecoders[state._18E90C606D424267].Decode(RangeDecoder) == 1)
        {
            if (IsRepG0Decoders[state._18E90C606D424267].Decode(RangeDecoder) == 0)
            {
                if (IsRep0LongDecoders[(state._18E90C606D424267 << kNumPosStatesBitsMax) + posState]
                        .Decode(RangeDecoder) == 0)
                {
                    state.D78845C868574748();     // UpdateShortRep()
                    OutWindow.PutByte(OutWindow.GetByte(rep0));
                    nowPos64++;
                    continue;
                }
            }
            else
            {
                uint distance;
                if (IsRepG1Decoders[state._18E90C606D424267].Decode(RangeDecoder) == 0)
                    distance = rep1;
                else
                {
                    if (IsRepG2Decoders[state._18E90C606D424267].Decode(RangeDecoder) == 0)
                        distance = rep2;
                    else { distance = rep3; rep3 = rep2; }
                    rep2 = rep1;
                }
                rep1 = rep0; rep0 = distance;
            }
            len = RepLenDecoder.Decode(RangeDecoder, posState) + kMatchMinLen;
            state._812BA9180E8E48BF();        // UpdateRep()
        }
        else
        {
            rep3 = rep2; rep2 = rep1; rep1 = rep0;
            len = kMatchMinLen + LenDecoder.Decode(RangeDecoder, posState);
            state._05DC7082FEF04055();        // UpdateMatch()
            uint posSlot = PosSlotDecoder[GetLenToPosState(len)]
                               .Decode(RangeDecoder);
            if (posSlot >= kStartPosModelIndex)
            {
                int numDirectBits = (int)((posSlot >> 1) - 1);
                rep0 = (2u | (posSlot & 1)) << numDirectBits;
                if (posSlot < kEndPosModelIndex)
                    rep0 += BitTreeDecoder.ReverseDecode(PosDecoders, rep0 - posSlot - 1,
                                                         RangeDecoder, numDirectBits);
                else
                {
                    rep0 += RangeDecoder.DecodeDirectBits(numDirectBits - kNumAlignBits) << kNumAlignBits;
                    rep0 += PosAlignDecoder.ReverseDecode(RangeDecoder);
                }
            }
            else rep0 = posSlot;
        }
        if (rep0 >= nowPos64 || rep0 >= DictionarySizeCheck)
        {
            if (rep0 == 0xFFFFFFFF) break;
            throw new DataErrorException();
        }
        OutWindow.CopyBlock(rep0, len);
        nowPos64 += len;
    }
}
OutWindow.Flush();
OutWindow.ReleaseStream();
RangeDecoder.ReleaseStream();

