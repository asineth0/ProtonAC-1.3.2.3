// ============================================================
// token 0x06000017   EEC15067D7014D61::6EF08D6C67244714
// native code: 0x28d9581b620  (121 bytes)
// kind: CALL_RET   confidence: exact
// original IL signature:
//   .method assembly hidebysig
//   instance void '6EF08D6C67244714' (
//   int32 pb
//   ) cil managed
//   
// native-calls: 0600001c
// native-strings: 
// ============================================================

uint numPosStates = 1u << pb;
LenDecoder.Create(numPosStates);
RepLenDecoder.Create(numPosStates);
PosStateMask = numPosStates - 1;
