// ============================================================
// token 0x06000129   351058E3F6BE45AB::MoveNext
// native code: 0x28d958b34d0  (1154 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method private final hidebysig newslot virtual
//   instance void MoveNext () cil managed noinlining
//   
// native-calls: 0600012b,0600012c,0600012d,06000003,06000005,06000006
// native-strings: 
// ============================================================

// OUTER ASYNC METHOD token 0x060000c3
// state-machine class: 351058E3F6BE45AB ; fields: 27
//   .field public int32 '39B221AA455F4218'
//   .field public valuetype [netstandard]System.Runtime.CompilerServices.AsyncTaskMethodBuilder '423B4CD0D8254759'
//   .field public class '1DB744298E9F4B09' B6E2974E575D4A4F
//   .field private valuetype [netstandard]System.Runtime.CompilerServices.TaskAwaiter '437C287AEEFD45EE'
//   .field assembly static literal string E30D35CFB0804EC3 = "ProtonAnticheatPluginHarmony"
//   .field private class ['0Harmony']HarmonyLib.Harmony A625F449A82745AC
//   .field private class [ProtonAC.Microsoft.Extensions.Configuration.Abstractions]Microsoft.Extensions.Configuration.IConfiguration '28EB422A207049DC'
//   .field private class [ProtonAC.Microsoft.Extensions.Logging.Abstractions]Microsoft.Extensions.Logging.ILogger '1DC5134FEF8147BE'
//   .field private class [ProtonAC.Microsoft.Extensions.Logging.Abstractions]Microsoft.Extensions.Logging.ILoggerProvider BCA776D1DA7D4C8D
//   .field private class [ProtonAC.Microsoft.Extensions.Localization.Abstractions]Microsoft.Extensions.Localization.IStringLocalizer '207917117A0940F3'
//   .field private class '4C6B03DD3A6441ED' E189947B5D624D72
//   .field private string E876F2059BDE4E2D
//   .field private string '1324026459604EF8'
//   .field private class [netstandard]System.Threading.CancellationTokenSource '3F0C7F57126F4A3D'
//   .field private valuetype [netstandard]System.Threading.CancellationToken '78B98250AB1F4F24'
//   .field private bool A62FF70BE54F4876
//   .field assembly class CCF339C5456845F6 '6FB0679464DB4BF6'
//   .field assembly class '631D551E2DA64E7D' CF47F3EE0E0C4452
//   .field assembly class '02C54685DE0E4B81' '0D077240941749FA'
//   .field private class [netstandard]System.Func`1<class [netstandard]System.Threading.Tasks.Task> '65184107759743C4'
private async Task 41DFABF87E734B85()
{
    this.<>1__state = -1;
    this.<>1__state = 0;
    this.<>1__state = -2;
    // 1 await site(s):
    //   await #1 @0x28d958b3798  type=Runtime.CompilerServices.TaskAwaiter
    //
    // native action order (address order):
    //   0x28d958b35a8  351058E3F6BE45AB::536F76463D514C0E(this.f20)
    //   0x28d958b35c8  351058E3F6BE45AB::1094BCD675FB4F72(this.f20.f70, 351058E3F6BE45AB::536F76463D514C0E(this.f20))
    //   0x28d958b35d8  351058E3F6BE45AB::BF2F9B05A26448C0(351058E3F6BE45AB::1094BCD675FB4F72(this.f20.f70, 351058E3F6BE45AB::536F76463D514C0E(this.f20)))
    //   0x28d958b3688  GetResult((? add 0xffffffffffffff98), 351058E3F6BE45AB::536F76463D514C0E(this.f20), ?, ?)
    //   0x28d958b36c8  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0))   ; =-1
    //   0x28d958b3718  <Module>::F84FA79ABE6944BB((movsxd 0x535d8515))   ; =0
    //   0x28d958b3798  [await] AwaitUnsafeOnCompleted((this add 0x8), (? add 0xffffffffffffff98), this, ?)
    //   0x28d958b3870  <Module>::58ECCB512F2A43AC((movsxd 0x2b6bc4b0))   ; =-2
    //   0x28d958b3948  THROW(0x162, 0x20c)
    // completion: <>t__builder.SetResult() (or SetException on throw)
}
