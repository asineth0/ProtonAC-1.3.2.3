using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06001306 {
    public unsafe static System.Threading.Tasks.Task<string> M06001306(string p0, System.Threading.CancellationToken p1) {
      object s4 = default;
      object s5 = default;
      uint __state = 3;
      while (true) {
        switch (__state) {
          case 0: // native state S0 @0x28d9730d053
            s4 = p1;
            __state = 1; break;
          case 1: // native state S1 @0x28d9730d0f3
            return default;
          case 3: // native state S3 @0x28d9730d01d
            s5 = p0;
            __state = 0; break;
      // [auto-dropped] default: return;
        }
      }
    }
  }
}
