using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_060006fa {
    public unsafe static void M060006fa() {
      uint __state = 1;
      while (true) {
        switch (__state) {
          case 0: // native state S0 @0x28d970d3d70
            __state = 1; break;
          case 1: // native state S1 @0x28d970d3df4
            __state = 0; break;
          default: return;
        }
      }
    }
  }
}