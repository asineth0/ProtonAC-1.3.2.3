using System;
namespace FinalBodies {
  // compat shim: Roslyn hides System.Runtime.CompilerServices.Nullable* types in source
  public sealed class NullableAttributeXCompat { public byte[] NullableFlags; }
  public static class H_06000078 {
    public unsafe static void M06000078(ref NullableAttributeXCompat __this, byte p0) {
      __this.NullableFlags = new byte[] { p0 };
    }
  }
}
