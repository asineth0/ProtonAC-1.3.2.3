using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
namespace FinalBodies {
  public static class H_0600043b {
    public unsafe static void M0600043b(ref C4462CD02B8C4225 __this, System.Threading.CancellationToken p0) {
      T_40273E31A09B48E7 o1 = default;
      var v2 = C4462CD02B8C4225.C700DF6D63C14083();
      var v3 = o1.E3D17168C7014F0A();
      T_0D2DBD97EB44499A o4 = default;
      o1 = new T_40273E31A09B48E7();
      o1.T_605A92C29EFB4E06();
      o1.T_26D727290E7043B3();
      o4 = new T_0D2DBD97EB44499A(default, null, default);
      __this.T_62A8949511C3432B(o4, (byte)(null));
      // call Wait(this.f28, 0xfa, ?, ?)
      // call ConcurrentQueue`1::TryDequeue(this.f20, (? add 0xffffffffffffff60), ?, ?)
      // call sub_28d97013710(this, ALLOC_OBJECT(0x28ccd8f1530), (movzx (rax xor rax)), 40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420), ?, ?))
      // call sub_28b82785f1f(this, ALLOC_OBJECT(0x28ccd8f1530), (movzx (rax xor rax)), 40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420), ?, ?))
      // call get_IsCancellationRequested((? add 0xffffffffffffff30), ALLOC_OBJECT(0x28ccd8f1530), (movzx (rax xor rax)), 40273E31A09B48E7::E3D17168C7014F0A(ALLOC_OBJECT(0x28ccd8f1420), ALLOC_OBJECT(0x28ccd8f1420), ?, ?))
    }
  }
}