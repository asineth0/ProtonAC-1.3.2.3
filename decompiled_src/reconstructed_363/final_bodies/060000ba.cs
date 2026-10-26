using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_060000ba {
    public unsafe static void M060000ba(ref T_1DB744298E9F4B09 __this) {
      object o15 = default;
      var v16 = T_1DB744298E9F4B09.T_08D958B930D443EB(default);
      var v17 = T_1DB744298E9F4B09.E73073B4F7264BA1(default);
      var v18 = T_1DB744298E9F4B09.T_08D958B930D443EB(default);
      var v19 = "mainThreadId";
      var v20 = T_1DB744298E9F4B09.T_80D7F4281FD5494F(default, default, default);
      var v21 = T_1DB744298E9F4B09.E73073B4F7264BA1(default);
      var v22 = T_1DB744298E9F4B09.T_01B722A967B642C6();
      var v23 = T_1DB744298E9F4B09.T_3B3CF6E9B6C94F08(default);
      System.Int32 o24 = default;
      var v25 = T_1DB744298E9F4B09.T_2329A64F30024A49();
      var v26 = T_1DB744298E9F4B09.T_08D958B930D443EB(default);
      var v27 = "unitySynchronizationContext";
      var v28 = T_1DB744298E9F4B09.T_80D7F4281FD5494F(default, default, default);
      uint __state = 8;
      while (true) {
        switch (__state) {
          case 0: // native state S0 @0x28d957eb772
      // [auto-dropped] o15.T_1DC5134FEF8147BE = __this;
      // [auto-dropped] o15.BCA776D1DA7D4C8D = default;
      // [auto-dropped] o15.E876F2059BDE4E2D = default;
      // [auto-dropped] o15.T_28EB422A207049DC = default;
      // [auto-dropped] o15.A625F449A82745AC = default;
      // [auto-dropped] o15.CF47F3EE0E0C4452 = 0;
      // [auto-dropped] T_1DB744298E9F4B09.T_7D7B108555E24AD4(o15);
            __state = 1; break;
          case 1: // native state S1 @0x28d957eb856
            return;
          case 2: // native state S2 @0x28d957eb3e3
      // [auto-dropped] T_1DB744298E9F4B09.DB99B16D9EFB4F44(default, default);
            __state = 0; break;
          case 3: // native state S3 @0x28d957eb42e
            T_1DB744298E9F4B09.T_80D7F4281FD5494F(default, default, default);
            __state = 7; break;
          case 4: // native state S4 @0x28d957eb52e
            T_1DB744298E9F4B09.T_4632CE99A2EE4D98(default, 0, o24);
            __state = 5; break;
          case 5: // native state S5 @0x28d957eb3ad
            T_1DB744298E9F4B09.T_2C8446EA5F1243E8();
            __state = 2; break;
          case 7: // native state S7 @0x28d957eb73e
            T_1DB744298E9F4B09.T_4632CE99A2EE4D98(default, 0, default);
            __state = 4; break;
          case 8: // native state S8 @0x28d957eb686
            __state = 3; break;
          default: return;
        }
      }
    }
  }
}
