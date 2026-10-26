using System;
namespace FinalBodies {
  public static class H_0600130c {
    // BCL calli: rcx=p0, rdx=p1, r8=p2, r9=p3, [rsp+0x20]=p4, [rsp+0x28]=p5
    public unsafe static int M0600130c(object p0, byte[] p1, int p2, int p3, byte[] p4, int p5) {
      return ((System.Security.Cryptography.HashAlgorithm)p0).TransformBlock(p1, p2, p3, p4, p5);
    }
  }
}
