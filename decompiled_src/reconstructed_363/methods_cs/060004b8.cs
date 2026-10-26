// ============================================================
// token 0x060004b8   50316A65685442A0::.ctor
// native code: 0x28d95a3fbd0  (251 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 060004b9,060004ba,06001086
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 8 call(s):
    //   0x28d95a3fbf8  ALLOC_OBJECT(0x28d961cbeb0)
    //   0x28d95a3fc10  .ctor(ALLOC_OBJECT(0x28d961cbeb0), ?, ?, ?)
    //   0x28d95a3fc30  WBARRIER(this+10, ?)
    //   0x28d95a3fc48  50316A65685442A0::95E825D2BB0040F0()
    //   0x28d95a3fc58  50316A65685442A0::548826F12A95422C(50316A65685442A0::95E825D2BB0040F0())
    //   0x28d95a3fc88  WBARRIER(this+18, 50316A65685442A0::548826F12A95422C(50316A65685442A0::95E825D2BB0040F0()))
    //   0x28d95a3fca0  C179263454B44BF6::.ctor(this)
    //   0x28d95a3fcc8  THROW(0x162, 0x69)
    // 2 store(s):
    //   0x28d95a3fc1f  this+10 <- ALLOC_OBJECT(0x28d961cbeb0)
    //   0x28d95a3fc77  this+18 <- 50316A65685442A0::548826F12A95422C(50316A65685442A0::95E825D2BB0040F0())
    // returns: C179263454B44BF6::.ctor(this)
}
