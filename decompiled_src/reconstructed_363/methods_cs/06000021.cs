// ============================================================
// token 0x06000021   4A7DB6E4806E4AE0::B8D669920C714E9A
// native code: 0x28d9581c9e0  (147 bytes)
// kind: LOOP   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void B8D669920C714E9A () cil managed
//   
// native-calls: 06000027
// native-strings: 
// ============================================================

uint numStates = (uint)1 << (NumPrevBits + NumPosBits);
for (uint i = 0; i < numStates; i++)
    Coders[i].Init();
