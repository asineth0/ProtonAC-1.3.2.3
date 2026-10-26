// ============================================================
// token 0x0600096e   AE8979A166C64D26::E797B23ED8FB4F22
// native code: 0x28d973270b0  (54 bytes)
// kind: OTHER   confidence: high
// original IL signature:
//   .method public hidebysig
//   instance void E797B23ED8FB4F22 () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

// ring-buffer advance
if (this.<field_0x1c> != 0)
{
    this.<field_0x18> = (this.<field_0x18> + 1) % 20;
    this.<field_0x1c>--;
}
