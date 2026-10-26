using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_0600152d {
    public unsafe static void M0600152d(ref C44631BE80E84975 __this, long p0) {
      uint __state = 1;
      while (true) {
        switch (__state) {
          case 1: // native state S1 @0x28d95a0a48c
            C44631BE80E84975.T_4A8CD8E581B448C1(__this, p0);
            __state = 2; break;
          case 2: // native state S2 @0x28d95a0a4bb
            return;
          default: return;
        }
      }
    }
  }
}