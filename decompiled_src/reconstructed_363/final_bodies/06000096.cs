using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06000096 {
    public unsafe static void M06000096(ref CCF339C5456845F6 __this) {
      uint __state = 2;
      while (true) {
        switch (__state) {
          case 1: // native state S1 @0x28d9723e17a
            return;
          case 2: // native state S2 @0x28d9723e140
            CCF339C5456845F6.F4BCFF6780374CF0(default);
            __state = 4; break;
          case 3: // native state S3 @0x28d9723e0c1
            __state = 1; break;
          case 4: // native state S4 @0x28d9723e10f
            __state = 3; break;
          default: return;
        }
      }
    }
  }
}