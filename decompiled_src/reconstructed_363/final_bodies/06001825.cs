using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06001825 {
    public unsafe static void M06001825(ref T_24CB10E1628641EE __this, System.IO.BinaryReader p0) {
      var v5 = T_24CB10E1628641EE.B9C234ECD19A45AA(p0);
      var v6 = T_24CB10E1628641EE.T_57AD0F04481847DB(p0);
      uint __state = 2;
      while (true) {
        switch (__state) {
          case 1: // native state S1 @0x28d9732058b
            T_24CB10E1628641EE.CA002C90439C4707(__this, default);
            return;
          case 2: // native state S2 @0x28d9732054a
            T_24CB10E1628641EE.T_0BBF6079C8AA4F4D(__this, default);
            __state = 1; break;
          default: return;
        }
      }
    }
  }
}