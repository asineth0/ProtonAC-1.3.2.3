// ============================================================
// token 0x06000001   <Module>::.cctor
// native code: 0x28d95819bf0  (2022 bytes)
// kind: LOOP   confidence: high
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed
//   
// native-calls: 06000002
// native-strings: 
// ============================================================

// Recovered from native code @0x28d95819bf0 (2022 bytes)
static _003CModule_003E()
{
    int[] table = new int[0x740];
    Buffer.BlockCopy(<static 0x1d00-byte blob _4FFB4B82A2564744>, 0, table, 0, 0x1d00);

    int[] key = new int[16];
    uint x = 0x5657403Eu;
    for (int i = 0; i < 16; i++)
    {
        x ^= x >> 12;
        x ^= x << 25;
        x ^= x >> 27;
        key[i] = (int)x;                    // xorshift32
    }

    int[] k = new int[16];
    byte[] buf = new byte[0x1d00];
    int o = 0;
    for (int off = 0; off < 0x740; off += 16)
    {
        for (int i = 0; i < 16; i++) k[i] = table[off + i];
        for (int i = 0; i < 16; i++) k[i] ^= key[i];
        for (int i = 0; i < 16; i++)
        {
            int v = k[i];
            buf[o++] = (byte)v;
            buf[o++] = (byte)(v >> 8);
            buf[o++] = (byte)(v >> 16);
            buf[o++] = (byte)(v >> 24);
            key[i] ^= k[i];
        }
    }

    _9F554F48BAED4B21 = _272A6D0FCC934A06(buf);   // decompress -> string table
}
