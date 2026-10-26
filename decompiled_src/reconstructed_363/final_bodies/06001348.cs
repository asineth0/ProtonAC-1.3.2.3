using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06001348 {
    public unsafe static System.Threading.Tasks.Task M06001348(ref EB69693599F64B76 __this) {
      uint __state = 2;
      while (true) {
        switch (__state) {
          case 0: // native state S0 @0x28d958bf143
            EB69693599F64B76.T_2207D0F3AAB445FA(__this.DB068CC2AA444C4C);
            EB69693599F64B76.A35EDF805C774582(__this.DB068CC2AA444C4C);
      // [auto-dropped] __this.DB068CC2AA444C4C = 0;
            __state = 4; break;
          case 1: // native state S1 @0x28d958bf0c3
      // [auto-dropped] EB69693599F64B76.T_63C7696E08254366(__this.T_2BBF92E607BB475E, _Module_.F84FA79ABE6944BB((default ^ 702518287), 7, (default), default), default);
            __state = 0; break;
          case 2: // native state S2 @0x28d958bf087
            __state = 1; break;
          case 4: // native state S4 @0x28d958bf193
            EB69693599F64B76.T_121FC7E3DDA44C65();
            return default;
      // [auto-dropped] default: return;
        }
      }
    }
  }
}
