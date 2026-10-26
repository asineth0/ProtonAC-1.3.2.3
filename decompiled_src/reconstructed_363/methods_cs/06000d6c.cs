// ============================================================
// token 0x06000d6c   22986AEA233A48AF::InitializeIndexes
// native code: 0x28d9703ece0  (1704 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig
//   instance void InitializeIndexes () cil managed
//   
// native-calls: 
// native-strings: ?:hardwareIDHistory,?:x,?:verifiedPlayers,?:2804822767680,?:2804804006592,?:2804822767616
// ============================================================

 void InitializeIndexes()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 27 call(s):
    //   0x28d9703ed60  sub_7fff672fcbd0(this.f10, (? add 0xffffffffffffff78), ?, ?)
    //   0x28d9703ed80  sub_28ccccae950(this.f10, (? add 0xffffffffffffff78), ?, ?)
    //   0x28d9703edb0  GetCollection(this.f18, 0x28d0c76f840, 0xa, ?)   ; "hardwareIDHistory"
    //   0x28d9703edd8  Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?)   ; "x"
    //   0x28d9703ee10  GetMethodFromHandle(0x28d9616ada8, 0x28d0b58b2c0, 0xa, ?)   ; "x"
    //   0x28d9703ee68  Property(Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?), GetMethodFromHandle(0x28d9616ada8, 0x28d0b58b2c0, 0xa, ?), 0xa, ?)
    //   0x28d9703ee90  ALLOC_ARRAY(0x28ccdb56c40, 0x1)
    //   0x28d9703eed0  Lambda(Property(Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?), GetMethodFromHandle(0x28d9616ada8, 0x28d0b58b2c0, 0xa, ?), 0xa, ?), ALLOC_ARRAY(0x28ccdb56c40, 0x1), Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?), ?)
    //   0x28d9703ef10  Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?) xor Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?)), ?)   ; "x"
    //   0x28d9703ef48  GetMethodFromHandle(0x28d9616ae88, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?) xor Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?)), ?)   ; "x"
    //   0x28d9703efa0  Property(Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?) xor Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?)), ?), GetMethodFromHandle(0x28d9616ae88, 0x28d0b58b2c0, (Parameter(0x2
    //   0x28d9703efc8  ALLOC_ARRAY(0x28ccdb56c40, 0x1)
    //   0x28d9703f008  Lambda(Property(Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?) xor Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?)), ?), GetMethodFromHandle(0x28d9616ae88, 0x28d0b58b2c0, (Parame
    //   0x28d9703f048  Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?) xor Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?)), ?) xor Parameter(0x28ccc6f54e0, 0x28
    //   0x28d9703f080  GetMethodFromHandle(0x28d9616aeb0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?) xor Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?)), ?) xor Parameter(0x28ccc6f
    //   0x28d9703f0d8  Property(Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?) xor Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?)), ?) xor Parameter(0x28ccc6f5
    //   0x28d9703f100  ALLOC_ARRAY(0x28ccdb56c40, 0x1)
    //   0x28d9703f140  Lambda(Property(Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, (Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?) xor Parameter(0x28ccc6f54e0, 0x28d0b58b2c0, 0xa, ?)), ?) xor Parameter(0x2
    //   0x28d9703f188  GetCollection(this.f18, 0x28d0c76f800, 0xa, ?)   ; "verifiedPlayers"
    //   0x28d9703f1b0  Parameter(0x28ccc6f54b0, 0x28d0b58b2c0, 0xa, ?)   ; "x"
    //   0x28d9703f1e8  GetMethodFromHandle(0x28d9616af40, 0x28d0b58b2c0, 0xa, ?)   ; "x"
    //   0x28d9703f240  Property(Parameter(0x28ccc6f54b0, 0x28d0b58b2c0, 0xa, ?), GetMethodFromHandle(0x28d9616af40, 0x28d0b58b2c0, 0xa, ?), 0xa, ?)
    //   0x28d9703f268  ALLOC_ARRAY(0x28ccdb56c40, 0x1)
    //   0x28d9703f2a8  Lambda(Property(Parameter(0x28ccc6f54b0, 0x28d0b58b2c0, 0xa, ?), GetMethodFromHandle(0x28d9616af40, 0x28d0b58b2c0, 0xa, ?), 0xa, ?), ALLOC_ARRAY(0x28ccdb56c40, 0x1), Parameter(0x28ccc6f54b0, 0x28d0b58b2c0, 0xa, ?), ?)
    //   0x28d9703f2e1  sub_28d9703f30d(GetCollection(this.f18, 0x28d0c76f800, 0xa, ?), Lambda(Property(Parameter(0x28ccc6f54b0, 0x28d0b58b2c0, 0xa, ?), GetMethodFromHandle(0x28d9616af40, 0x28d0b58b2c0, 0xa, ?), 0xa, ?), ALLOC_ARRAY(0x28ccdb56c
    //   0x28d9703f308  sub_28b82785f1f(GetCollection(this.f18, 0x28d0c76f800, 0xa, ?), Lambda(Property(Parameter(0x28ccc6f54b0, 0x28d0b58b2c0, 0xa, ?), GetMethodFromHandle(0x28d9616af40, 0x28d0b58b2c0, 0xa, ?), 0xa, ?), ALLOC_ARRAY(0x28ccdb56c
    //   0x28d9703f370  THROW(0x14b, 0x156)
    // returns: sub_28b82785f1f(GetCollection(this.f18, 0x28d0c76f800, 0xa, ?), Lambda(Property(Parameter(0x28ccc6f54b0, 0x28d0b58b2c0, 0xa, ?), GetMethodFromHandle(0x28d9616af40, 0x28d0b58b2c0, 0xa, ?), 0xa, ?), ALL
    // string table refs:
    //   literal  "hardwareIDHistory"
    //   literal  "x"
    //   literal  "verifiedPlayers"
    //   literal  "2804822767680"
    //   literal  "2804804006592"
    //   literal  "2804822767616"
}
