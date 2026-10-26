// ============================================================
// token 0x06000189   36CB4EE3CC6C48CE::MoveNext
// native code: 0x28d958b7640  (9651 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000003,06000006,06000005,0600018b,06000007,0600467c,0600018c,06000004,0600018d,0600018e,0600018f,06000190,06000191,06000192,06000193,06000195,06000196,0600463e,06000194,06004680
// native-strings: 0x600:http://ip-api.com/line/?fields=status,countryCode,0x648:RU,0x63c:success
// ============================================================

// OUTER ASYNC METHOD token 0x06000185
// state-machine class: 36CB4EE3CC6C48CE ; fields: 13
//   .field public int32 C7984810A4844DB9
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<bool> '7F6EE0AEB6134E2A'
//   .field private class [netstandard]System.Net.Http.HttpResponseMessage E194280DBF904BD2
//   .field private class [netstandard]System.IO.Stream CBEC1431F03F4D6D
//   .field private class [netstandard]System.IO.StreamReader '16997A03970F4E8B'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<class [netstandard]System.Net.Http.HttpResponseMessage> '85DA7C8255494A0A'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<class [netstandard]System.IO.Stream> '45AF8AE6C188489F'
//   .field private object '1BF957A5B3234DE2'
//   .field private int32 '92AAB1FCF89D4C53'
//   .field private bool D6478D73802B4095
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<string> '166839259CFE4071'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.ValueTaskAwaiter '0C2DE04693284036'
//   .field private static initonly class [netstandard]System.Net.Http.HttpClient F4F3315D845B450D
private async Task<bool> 46F5E45364394CBB()
{
    this.<>1__state = -1;
    this.<>1__state = 0;
    this.<>1__state = 1;
    this.<>1__state = 1;
    // 5 await site(s):
    //   await #1 @0x28d958b7a40  type=Runtime.CompilerServices.TaskAwaiter`1<Net.Http.HttpResponseMessage>
    //      awaiter source: GetAwaiter(36CB4EE3CC6C48CE::9633D28B72894C2B(0x28d03f34d70, <Module>::F84FA79ABE6944BB((movsxd 0x89646722)), <Module>::58ECCB512F2A43AC(0x3bf9a73b)), <Module>::F84FA79AB
    //   await #2 @0x28d958b7e88  type=Runtime.CompilerServices.TaskAwaiter`1<IO.Stream>
    //      awaiter source: GetAwaiter(36CB4EE3CC6C48CE::9633D28B72894C2B(0x28d03f34d70, <Module>::F84FA79ABE6944BB((movsxd 0x89646722)), <Module>::58ECCB512F2A43AC(0x3bf9a73b)), <Module>::F84FA79AB
    //   await #3 @0x28d958b8540  type=Runtime.CompilerServices.TaskAwaiter`1<string>
    //      awaiter source: GetAwaiter(36CB4EE3CC6C48CE::0760F0FDF58041DE(this.f30), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) 
    //   await #4 @0x28d958b8700  type=Runtime.CompilerServices.ValueTaskAwaiter
    //      awaiter source: GetAwaiter(36CB4EE3CC6C48CE::0760F0FDF58041DE(this.f30), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) 
    //   await #5 @0x28d958b9050  type=Runtime.CompilerServices.TaskAwaiter`1<Net.Http.HttpResponseMessage>
    //      awaiter source: GetAwaiter(36CB4EE3CC6C48CE::0760F0FDF58041DE(this.f30), <Module>::F84FA79ABE6944BB((movsxd 0xab2d2f50), <Module>::3F57E81A62734AC2(0x2257cf7), <Module>::F84FA79ABE6944BB
    //
    // native action order (address order):
    //   0x28d958b7738  <Module>::8B9C7B12B1AE4949((movsxd 0x50f4f95b))   ; =4
    //   0x28d958b7840  <Module>::58ECCB512F2A43AC((movsxd 0xf9446e57))   ; =-1
    //   0x28d958b78b0  <Module>::F84FA79ABE6944BB((movsxd 0x89646722))   ; "http://ip-api.com/line/?fields=status,countryCode"
    //   0x28d958b78e8  <Module>::58ECCB512F2A43AC(0x3bf9a73b)   ; =1
    //   0x28d958b7908  36CB4EE3CC6C48CE::9633D28B72894C2B(0x28d03f34d70, <Module>::F84FA79ABE6944BB((movsxd 0x89646722)), <Module>::58ECCB512F2A43AC(0x3bf9a73b))
    //   0x28d958b7920  GetAwaiter(36CB4EE3CC6C48CE::9633D28B72894C2B(0x28d03f34d70, <Module>::F84FA79ABE6944BB((movsxd 0x89646722)), <Module>::58ECCB512F2A43AC(0x3bf9a73b)), <Module>::F84FA79ABE6944BB((movsxd 0x89646722)), 
    //   0x28d958b79b8  <Module>::8B9C7B12B1AE4949((movsxd 0xd8c6f9cd))   ; =0
    //   0x28d958b7a40  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe80), this, ?)
    //   0x28d958b7a70  GetResult((? add 0xfffffffffffffe80), (? add 0xfffffffffffffe80), this, ?)
    //   0x28d958b7b38  <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7))   ; =1
    //   0x28d958b7b78  <Module>::F84FA79ABE6944BB((movsxd 0xab4f8e70))   ; =3
    //   0x28d958b7bf0  <Module>::3F57E81A62734AC2((movsxd 0x3ca2d4c7))   ; =1
    //   0x28d958b7ce8  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), (((((((((((movsxd 0xaaef7816) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) imul 0x6a578533) not 0x1) imul 0xf02d19
    //   0x28d958b7d30  GetResult((? add 0xfffffffffffffe88), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), (((((((((((movsxd 0xaaef7816) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) i
    //   0x28d958b7d80  <Module>::58ECCB512F2A43AC((movsxd 0x1505777c), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), (((((((((((movsxd 0xaaef7816) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x3
    //   0x28d958b7d99  sub_28d958b9758((movsxd 0x1505777c), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), (((((((((((movsxd 0xaaef7816) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) im
    //   0x28d958b7db8  sub_28b82785f1f((movsxd 0x1505777c), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), (((((((((((movsxd 0xaaef7816) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) im
    //   0x28d958b7e00  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4), <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), (((((((((((movsxd 0xaaef7816) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x3
    //   0x28d958b7e58  sub_28b82780dcb((this add 0x40), 0x0, this, ?)
    //   0x28d958b7e88  [await] AsyncTaskMethodBuilder`1::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe88), this, ?)
    //   0x28d958b7e9a  sub_28d958b9758((this add 0x8), (? add 0xfffffffffffffe88), this, ?)
    //   0x28d958b7ec0  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffe88), this, ?)
    //   0x28d958b7f90  36CB4EE3CC6C48CE::E094DF89E3784142(this.f20)
    //   0x28d958b8030  <Module>::390073C602714496((movsxd 0x7f132d63))   ; =0
    //   0x28d958b8068  36CB4EE3CC6C48CE::7BA68AD7CA2B4442(this.f20)
    //   0x28d958b8078  36CB4EE3CC6C48CE::DB4CC53065034A21(36CB4EE3CC6C48CE::7BA68AD7CA2B4442(this.f20))
    //   0x28d958b8090  GetAwaiter(36CB4EE3CC6C48CE::DB4CC53065034A21(36CB4EE3CC6C48CE::7BA68AD7CA2B4442(this.f20)), (? add 0xfffffffffffffe88), this, ?)
    //   0x28d958b80e8  <Module>::390073C602714496((movsxd 0x4da2eb80))   ; =2
    //   0x28d958b8128  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b))   ; =1
    //   0x28d958b81e8  36CB4EE3CC6C48CE::53A99E5A747C441C(this.f28)
    //   0x28d958b8270  <Module>::390073C602714496((movsxd 0x4da2eb80))   ; =2
    //   0x28d958b8320  36CB4EE3CC6C48CE::0760F0FDF58041DE(this.f30)
    //   0x28d958b8338  GetAwaiter(36CB4EE3CC6C48CE::0760F0FDF58041DE(this.f30), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) imul 0x6a578533) not 0x1) imul
    //   0x28d958b83d0  <Module>::390073C602714496((movsxd 0xd413acc0), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) imul 0x6a578533) not 0x1) imul 0xf02d19
    //   0x28d958b8430  <Module>::3F57E81A62734AC2((movsxd 0x94857146), <Module>::390073C602714496((movsxd 0xd413acc0), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x3
    //   0x28d958b8450  sub_28d958b8ba0(<Module>::3F57E81A62734AC2((movsxd 0x94857146), <Module>::390073C602714496((movsxd 0xd413acc0), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96ee
    //   0x28d958b8470  sub_28b82785f1f(<Module>::3F57E81A62734AC2((movsxd 0x94857146), <Module>::390073C602714496((movsxd 0xd413acc0), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96ee
    //   0x28d958b84b8  <Module>::3F57E81A62734AC2((movsxd 0xc28ec3f3), <Module>::390073C602714496((movsxd 0xd413acc0), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x3
    //   0x28d958b8510  sub_28b82780dcb((this add 0x58), GetAwaiter(36CB4EE3CC6C48CE::0760F0FDF58041DE(this.f30), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92
    //   0x28d958b8540  [await] AsyncTaskMethodBuilder`1::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b8552  sub_28d958b8ba0((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b8578  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b858a  sub_28d958b9758((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b85b0  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b85d8  GetResult((? add 0xfffffffffffffe90), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b8608  36CB4EE3CC6C48CE::3CCB9BB131684549(0x0)
    //   0x28d958b8668  <Module>::390073C602714496((movsxd 0xd413acc0), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b86d0  sub_28b82780dcb((this add 0x58), GetAwaiter(36CB4EE3CC6C48CE::0760F0FDF58041DE(this.f30), (((((((((((movsxd 0x483cc683) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92
    //   0x28d958b8700  [await] AsyncTaskMethodBuilder`1::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b8712  sub_28d958b8ba0((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b8738  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b874a  sub_28d958b9758((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b8770  sub_28b82785f1f((this add 0x8), (? add 0xfffffffffffffe90), this, ?)
    //   0x28d958b87f8  <Module>::3F57E81A62734AC2(0x2257cf7)   ; "RU"
    //   0x28d958b8840  <Module>::F84FA79ABE6944BB((movsxd 0x6267f16e))   ; =5
    //   0x28d958b8860  36CB4EE3CC6C48CE::B40A1107EC514DD7(36CB4EE3CC6C48CE::3CCB9BB131684549(0x0), <Module>::3F57E81A62734AC2(0x2257cf7), <Module>::F84FA79ABE6944BB((movsxd 0x6267f16e)))
    //   0x28d958b88b8  <Module>::390073C602714496((movsxd 0x952677a0))   ; =3
    //   0x28d958b8938  <Module>::F84FA79ABE6944BB((movsxd 0xab2d2f50), <Module>::3F57E81A62734AC2(0x2257cf7), <Module>::F84FA79ABE6944BB((movsxd 0x6267f16e)), ?)
    //   0x28d958b89b8  36CB4EE3CC6C48CE::0760F0FDF58041DE(this.f30)
    //   0x28d958b89d0  GetAwaiter(36CB4EE3CC6C48CE::0760F0FDF58041DE(this.f30), <Module>::F84FA79ABE6944BB((movsxd 0xab2d2f50), <Module>::3F57E81A62734AC2(0x2257cf7), <Module>::F84FA79ABE6944BB((movsxd 0x6267f16e)), ?), <Mo
    //   0x28d958b8a68  GetResult((? add 0xfffffffffffffe90), <Module>::F84FA79ABE6944BB((movsxd 0xab2d2f50), <Module>::3F57E81A62734AC2(0x2257cf7), <Module>::F84FA79ABE6944BB((movsxd 0x6267f16e)), ?), <Module>::F84FA79ABE69
    //   0x28d958b8a98  36CB4EE3CC6C48CE::3CCB9BB131684549(0x0)
    //   0x28d958b8ad8  <Module>::F84FA79ABE6944BB((movsxd 0x7f9ed7df))   ; "success"
    //   0x28d958b8b10  <Module>::390073C602714496(0x3a2815d2)   ; =5
    //   0x28d958b8b30  36CB4EE3CC6C48CE::B40A1107EC514DD7(36CB4EE3CC6C48CE::3CCB9BB131684549(0x0), <Module>::F84FA79ABE6944BB((movsxd 0x7f9ed7df)), <Module>::390073C602714496(0x3a2815d2))
    //   0x28d958b8b75  sub_28d958b8ba0(36CB4EE3CC6C48CE::3CCB9BB131684549(0x0), <Module>::F84FA79ABE6944BB((movsxd 0x7f9ed7df)), <Module>::390073C602714496(0x3a2815d2), ?)
    //   0x28d958b8b98  sub_28b82785f1f(36CB4EE3CC6C48CE::3CCB9BB131684549(0x0), <Module>::F84FA79ABE6944BB((movsxd 0x7f9ed7df)), <Module>::390073C602714496(0x3a2815d2), ?)
    //   0x28d958b8d20  36CB4EE3CC6C48CE::C01D94B9EF1A4342(this.f30)
    //   0x28d958b8d80  <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994))   ; =1
    //   0x28d958b8ecc  sub_28d958b9758((u32 ((((((((((((movsxd 0xd41ec027) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) imul 0x6a578533) not 0x1) imul 0xf02d19d5) div 0xe) mod 0xe) shl 
    //   0x28d958b8ef0  sub_28b82785f1f((u32 ((((((((((((movsxd 0xd41ec027) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) imul 0x6a578533) not 0x1) imul 0xf02d19d5) div 0xe) mod 0xe) shl 
    //   0x28d958b8f38  <Module>::8B9C7B12B1AE4949((movsxd 0x50f4f95b), (((((((((((movsxd 0xd41ec027) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) imul 0x6a578533) not 0x1) imul 0xf02d19
    //   0x28d958b8f86  sub_28d958b9758(<Module>::8B9C7B12B1AE4949((movsxd 0x50f4f95b), (((((((((((movsxd 0xd41ec027) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) imul 0x6a578533) not 0x
    //   0x28d958b8fa8  sub_28b82785f1f(<Module>::8B9C7B12B1AE4949((movsxd 0x50f4f95b), (((((((((((movsxd 0xd41ec027) neg 0x1) add 0xeadd5aa4411c4980) neg 0x1) sub 0xfa3e4c96eec32e6d) imul 0x32e2c92f) imul 0x6a578533) not 0x
    //   0x28d958b9008  sub_28b82780dcb((this add 0x60), (rax xor rax), <Module>::390073C602714496(0x3a2815d2), ?)
    //   0x28d958b9050  [await] AsyncTaskMethodBuilder`1::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xfffffffffffffe98), this, ?)
    //   0x28d958b90f8  ?(0x0, (? add 0xfffffffffffffe98), this, ?)
    //   0x28d958b9110  36CB4EE3CC6C48CE::05D5931AFF964D72(0x0, (? add 0xfffffffffffffe98), this, ?)
    //   0x28d958b9120  36CB4EE3CC6C48CE::3B19AC9E12E447E6(36CB4EE3CC6C48CE::05D5931AFF964D72(0x0, (? add 0xfffffffffffffe98), this, ?), (? add 0xfffffffffffffe98), this, ?)
    //   0x28d958b9258  TaskAwaiter::ValidateEnd(0x0, (? add 0xfffffffffffffe98), this, ?)
    //   0x28d958b9320  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), (movsx (? add 0xfffffffffffffe98).f8), this, ?)
    //   0x28d958b9390  36CB4EE3CC6C48CE::CF3C3CB83FC14A57(this.f28)
    //   0x28d958b96c8  <Module>::58ECCB512F2A43AC((movsxd 0x3bf9a73b))   ; =1
    //   0x28d958b972f  sub_28d958b9758((movsxd 0xfdc9b3b8), (movsx (? add 0xfffffffffffffe98).f8), this, ?)
    //   0x28d958b9750  sub_28b82785f1f((movsxd 0xfdc9b3b8), (movsx (? add 0xfffffffffffffe98).f8), this, ?)
    //   ... 12 more calls
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
