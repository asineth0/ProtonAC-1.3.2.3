// ============================================================
// token 0x06000020   4A7DB6E4806E4AE0::BC62118902CC495C
// native code: 0x28d9581b450  (283 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void BC62118902CC495C (
//   int32 numPosBits,
//   int32 numPrevBits
//   ) cil managed
//   
// native-calls: 06000026
// native-strings: 
// ============================================================

if (Coders != null && NumPrevBits == numPrevBits && NumPosBits == numPosBits)
    return;
NumPosBits = numPosBits;
PosMask = (uint)((1 << numPosBits) - 1);
NumPrevBits = numPrevBits;
uint numStates = (uint)1 << (NumPrevBits + NumPosBits);
Coders = new Decoder2[numStates];
for (uint i = 0; i < numStates; i++)
    Coders[i].Create();
