using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_0600063a {
    public unsafe static void M0600063a(ref BE3140E5E8934376 __this) {
      // [auto-dropped] EnterVehicleRequestHandler o5 = default;
      uint __state = 1;
      while (true) {
        switch (__state) {
          case 1: // native state S1 @0x28d970c5de1
      // [auto-dropped] BE3140E5E8934376.FFA7D0C836974FE8(o5);
            __state = 2; break;
          case 2: // native state S2 @0x28d970c5e93
            __this.BB782E479FC44A40();
            return;
          default: return;
        }
      }
    }
  }
}
