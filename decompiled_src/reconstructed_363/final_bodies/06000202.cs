using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06000202 {
    public unsafe static void M06000202(ref EE0FD11A7E47463C __this) {
      uint __state = 1;
      while (true) {
        switch (__state) {
          case 0: // native state S0 @0x28d970341d3
            return;
          case 1: // native state S1 @0x28d970341a4
            EE0FD11A7E47463C.E2873669CEEA43CF(__this);
            __state = 0; break;
          default: return;
        }
      }
    }
  }
}