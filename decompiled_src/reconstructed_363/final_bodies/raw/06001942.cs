using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06001942 {
    public unsafe static void M06001942(ref T_81DD83B8AA2247AA __this, uint seed) {
      __this.AC0A7CEDFFF44036 = (seed * 557916961);
      __this.T_2AFF121C01C1459F = ((seed * 557916961) * 557916961);
      __this.FA7EF4447A474D70 = (((seed * 557916961) * 557916961) * 557916961);
      __this.T_964259AAC7FB4290 = ((((seed * 557916961) * 557916961) * 557916961) * 557916961);
    }
  }
}