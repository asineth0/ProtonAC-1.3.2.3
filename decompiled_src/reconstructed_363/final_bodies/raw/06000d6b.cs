using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_06000d6b {
    public unsafe static void M06000d6b(ref T_22986AEA233A48AF __this, string p0, string p1) {
      System.Object o1 = default;
      LiteDB.ConnectionString o2 = default;
      LiteDB.LiteDatabase o3 = default;
      var v4 = __this.InitializeIndexes();
      __this.T_59DC33CECAED4861 = o1;
      T_35E433569930420D.AA29B2005B934E27(p1);
      T_35E433569930420D.AA29B2005B934E27(p1);
      E651E17AA2CA4BC8.BF0698DA304A4D6A.C6F757F3517C45E1(o2, p0, p1);
      T_1DB744298E9F4B09.T_0B1227EB3A824F28(o3);
      __this.T_71D2A701276D4313 = o3;
      // call CreateDirectory(a1, a0, a1, ?)
      // call Combine(a1, a0, a1, ?)
    }
  }
}