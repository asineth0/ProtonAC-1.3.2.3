// ============================================================
// token 0x06000499   03550CE5B4D54D24::.ctor
// native code: 0x28d95a3ca20  (163 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 0600049a,0600049d,06001086
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 5 call(s):
    //   0x28d95a3ca40  03550CE5B4D54D24::6D3D1833382F43E9()
    //   0x28d95a3ca50  03550CE5B4D54D24::BEA87FDFA6284013(03550CE5B4D54D24::6D3D1833382F43E9())
    //   0x28d95a3ca80  WBARRIER(this+10, 03550CE5B4D54D24::BEA87FDFA6284013(03550CE5B4D54D24::6D3D1833382F43E9()))
    //   0x28d95a3ca98  C179263454B44BF6::.ctor(this)
    //   0x28d95a3cac0  THROW(0x162, 0x69)
    // 1 store(s):
    //   0x28d95a3ca6f  this+10 <- 03550CE5B4D54D24::BEA87FDFA6284013(03550CE5B4D54D24::6D3D1833382F43E9())
    // returns: C179263454B44BF6::.ctor(this)
}
