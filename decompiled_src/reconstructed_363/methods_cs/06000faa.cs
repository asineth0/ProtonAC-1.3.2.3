// ============================================================
// token 0x06000faa   54A95DF69F9D4812::MoveNext
// native code: 0x28d95a0c690  (2886 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 06000005,06000fb0,06000fb1,06000fb2,06000003,06000fb7,06000fb8,06000fb3,06004671,06000007,06004649,06000fac,06000fad,06000004,06000fb6,06000fb4,06000fb5,06000fae,06000faf
// native-strings: 0x3088:protonac
// ============================================================

// OUTER ASYNC METHOD token 0x06000fa8
// state-machine class: 54A95DF69F9D4812 ; fields: 6
//   .field public int32 '3D32F453C7AD4EAB'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder B56E61A46BEC4A4E
//   .field public class '02C54685DE0E4B81' '5E31DABA00AB4C16'
//   .field public class F3E4AB234A904B5E '58CD4E31649140E5'
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter`1<bool> C609D30A981B4E7B
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '404D678D3D224341'
private async Task B1EA6B83E25B4D8E(02C54685DE0E4B81 arg0, F3E4AB234A904B5E arg1, valuetype Threading.CancellationToken arg2)
{
    // <>1__state <- <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (((((((0x3247f4ca neg 0x1) neg 0x1) xor 0x64dda57d) xor 0xee5965c19494f345) neg 0x1) div 0x1b) mod 0x1b), ?, ?)
    // <>1__state <- <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), <Module>::F84FA79ABE6944BB((movsxd 0x8e20a5b), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (((((((0x3247f4ca
    // <>1__state <- <Module>::3F57E81A62734AC2((movsxd 0x94857146), (? add 0xffffffffffffff90), this, ?)
    // <>1__state <- <Module>::3F57E81A62734AC2((movsxd 0xcd941453), <Module>::3F57E81A62734AC2((movsxd 0x94857146), (? add 0xffffffffffffff90), this, ?), this, ?)
    // 3 await site(s):
    //   await #1 @0x28d95a0ca68  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //   await #2 @0x28d95a0cd98  type=Runtime.CompilerServices.TaskAwaiter
    //   await #3 @0x28d95a0ce20  type=Runtime.CompilerServices.TaskAwaiter`1<bool>
    //
    // native action order (address order):
    //   0x28d95a0c7d0  <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (((((((0x3247f4ca neg 0x1) neg 0x1) xor 0x64dda57d) xor 0xee5965c19494f345) neg 0x1) div 0x1b) mod 0x1b), ?, ?)
    //   0x28d95a0c800  54A95DF69F9D4812::13E8D85767DB4032(<Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (((((((0x3247f4ca neg 0x1) neg 0x1) xor 0x64dda57d) xor 0xee5965c19494f345) neg 0x1) div 0x1b) mod 0x1b), ?, ?), <Mod
    //   0x28d95a0c810  54A95DF69F9D4812::0D04B775CDE842B1(54A95DF69F9D4812::13E8D85767DB4032(<Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (((((((0x3247f4ca neg 0x1) neg 0x1) xor 0x64dda57d) xor 0xee5965c19494f345) neg 0x
    //   0x28d95a0c848  <Module>::F84FA79ABE6944BB((movsxd 0x8e20a5b), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (((((((0x3247f4ca neg 0x1) neg 0x1) xor 0x64dda57d) xor 0xee5965c19494f345) neg 0x1) div 0x1b) mod 0x1b),
    //   0x28d95a0c868  54A95DF69F9D4812::C935C7A363B54CA7(54A95DF69F9D4812::0D04B775CDE842B1(54A95DF69F9D4812::13E8D85767DB4032(<Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (((((((0x3247f4ca neg 0x1) neg 0x1) xor 0x64dda
    //   0x28d95a0c8c8  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0), <Module>::F84FA79ABE6944BB((movsxd 0x8e20a5b), <Module>::F84FA79ABE6944BB((movsxd 0x55eec410), (((((((0x3247f4ca neg 0x1) neg 0x1) xor 0x64dda57d) xor 0
    //   0x28d95a0c920  sub_28b82780dcb((this add 0x30), 0x0, 0x28cc7550840, ?)
    //   0x28d95a0c9b0  GetResult((? add 0xffffffffffffff88), 0x0, 0x28cc7550840, ?)
    //   0x28d95a0c9c0  54A95DF69F9D4812::7A6124DDA1AF4474()
    //   0x28d95a0c9d0  54A95DF69F9D4812::88DC0FA278184548(54A95DF69F9D4812::7A6124DDA1AF4474())
    //   0x28d95a0c9f8  54A95DF69F9D4812::86E6C312DFF247CE(this.f20, 0x0, 0x28cc7550840, ?)
    //   0x28d95a0ca38  sub_28b82780dcb((this add 0x38), 54A95DF69F9D4812::88DC0FA278184548(54A95DF69F9D4812::7A6124DDA1AF4474()), 0x28cc7550840, ?)
    //   0x28d95a0ca68  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff90), this, ?)
    //   0x28d95a0cab0  <Module>::3F57E81A62734AC2((movsxd 0x94857146), (? add 0xffffffffffffff90), this, ?)
    //   0x28d95a0cae8  TaskAwaiter`1::GetResult((? add 0xffffffffffffff88), <Module>::3F57E81A62734AC2((movsxd 0x94857146), (? add 0xffffffffffffff90), this, ?), this, ?)
    //   0x28d95a0cb30  <Module>::3F57E81A62734AC2((movsxd 0xcd941453), <Module>::3F57E81A62734AC2((movsxd 0x94857146), (? add 0xffffffffffffff90), this, ?), this, ?)
    //   0x28d95a0cb78  54A95DF69F9D4812::470C9E7BE18C480D(this.f28)
    //   0x28d95a0cb90  54A95DF69F9D4812::D80DEFBAE6264DB8(this.f20, 54A95DF69F9D4812::470C9E7BE18C480D(this.f28))
    //   0x28d95a0cba8  54A95DF69F9D4812::470C9E7BE18C480D(this.f28)
    //   0x28d95a0cc48  <Module>::390073C602714496((movsxd 0xd413acc0))   ; =-1
    //   0x28d95a0cd00  <Module>::F84FA79ABE6944BB((movsxd 0x67cf2da4))   ; =1
    //   0x28d95a0cd98  [await] AsyncTaskMethodBuilder::AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff88), this, ?)
    //   0x28d95a0ce20  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff88), this, ?)
    //   0x28d95a0ce38  54A95DF69F9D4812::CADDD906090C4AF3()
    //   0x28d95a0ce90  54A95DF69F9D4812::CADDD906090C4AF3((? add 0xffffffffffffff98), (? add 0xffffffffffffff88), this, ?)
    //   0x28d95a0cec0  sub_28b82780dcb((? add 0xffffffffffffffa0), (? add 0xffffffffffffff88), this, ?)
    //   0x28d95a0cf10  54A95DF69F9D4812::13E8D85767DB4032()
    //   0x28d95a0cf20  54A95DF69F9D4812::FFCA8CB3C2C44642(54A95DF69F9D4812::13E8D85767DB4032())
    //   0x28d95a0cf58  54A95DF69F9D4812::13E8D85767DB4032(54A95DF69F9D4812::13E8D85767DB4032(), (? add 0xffffffffffffff88), this, ?)
    //   0x28d95a0cf68  54A95DF69F9D4812::0D04B775CDE842B1(54A95DF69F9D4812::13E8D85767DB4032(54A95DF69F9D4812::13E8D85767DB4032(), (? add 0xffffffffffffff88), this, ?), (? add 0xffffffffffffff88), this, ?)
    //   0x28d95a0cfa0  <Module>::8B9C7B12B1AE4949((movsxd 0x5c268acf), (? add 0xffffffffffffff88), this, ?)
    //   0x28d95a0cfc0  54A95DF69F9D4812::536F23CD59724BD3(54A95DF69F9D4812::0D04B775CDE842B1(54A95DF69F9D4812::13E8D85767DB4032(54A95DF69F9D4812::13E8D85767DB4032(), (? add 0xffffffffffffff88), this, ?), (? add 0xffffffffff
    //   0x28d95a0cfe8  54A95DF69F9D4812::9FCBFB129BD54027(this.f28)
    //   0x28d95a0d018  <Module>::8B9C7B12B1AE4949((movsxd 0xe8db4d94))   ; "protonac"
    //   0x28d95a0d030  54A95DF69F9D4812::E2FBF10AF9B34E73(54A95DF69F9D4812::9FCBFB129BD54027(this.f28), <Module>::8B9C7B12B1AE4949((movsxd 0xe8db4d94)))
    //   0x28d95a0d070  GetResult((? add 0xffffffffffffff90), <Module>::8B9C7B12B1AE4949((movsxd 0xe8db4d94)), 0x28cc7550840, ?)
    //   0x28d95a0d158  <Module>::390073C602714496((movsxd 0x30c4c57f))   ; =-2
    //   0x28d95a0d1b0  THROW(0x162, 0x2cc)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
