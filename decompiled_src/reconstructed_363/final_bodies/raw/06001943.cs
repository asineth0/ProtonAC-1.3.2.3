using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06001943 {
    public unsafe static uint M06001943(ref T_81DD83B8AA2247AA __this, byte f, uint q) {
      __this.AC0A7CEDFFF44036 = q;
      __this.T_2AFF121C01C1459F = q;
      __this.FA7EF4447A474D70 = q;
      __this.T_964259AAC7FB4290 = q;
      __this.AC0A7CEDFFF44036 = (__this.AC0A7CEDFFF44036 ^ q);
      __this.T_2AFF121C01C1459F = (__this.T_2AFF121C01C1459F + q);
      __this.FA7EF4447A474D70 = (__this.FA7EF4447A474D70 ^ q);
      __this.T_964259AAC7FB4290 = (__this.T_964259AAC7FB4290 - q);
      return __this.T_964259AAC7FB4290;
    }
  }
}