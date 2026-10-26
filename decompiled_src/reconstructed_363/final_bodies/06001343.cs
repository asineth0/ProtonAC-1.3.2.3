using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06001343 {
    public unsafe static System.Threading.Tasks.Task M06001343(ref EB69693599F64B76 __this, System.Threading.CancellationToken p0) {
      object s4 = default;
      object s5 = default;
      uint __state = 1;
      while (true) {
        switch (__state) {
          case 0: // native state S0 @0x28d958de08a
            __state = 3; break;
          case 1: // native state S1 @0x28d958de01e
            s4 = __this;
            __state = 2; break;
          case 2: // native state S2 @0x28d958de05b
            s5 = p0;
            __state = 0; break;
          case 3: // native state S3 @0x28d958de113
            return default;
      // [auto-dropped] default: return;
        }
      }
    }
  }
}
