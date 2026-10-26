using System;
namespace FinalBodies {
  public static class H_060001bd {
    public unsafe static bool M060001bd() {
      // Native reads the module-level static int32 at 0x28cc768cd90 and returns (value != 3).
      // The address is a dump-time address; the check itself is exact.
      return *(int*)(void*)0x28cc768cd90 != 3;
    }
  }
}
