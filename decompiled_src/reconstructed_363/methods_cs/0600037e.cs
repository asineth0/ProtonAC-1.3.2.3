// ============================================================
// token 0x0600037e   B7097FC49A384CFA::.ctor
// native code: 0x28d97016ed0  (149 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 060003a5,060003a6,06001086
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d97016ef0  B7097FC49A384CFA::34563B1FC7304350()
    //   0x28d97016f20  B7097FC49A384CFA::882421B50F934C0C(B7097FC49A384CFA::34563B1FC7304350(), 0x28d0351ccc0.f0)
    //   0x28d97016f40  WBARRIER(this+10, 0x28d0351ccc0.f0)
    //   0x28d97016f58  C179263454B44BF6::.ctor(this)
    // 1 store(s):
    //   0x28d97016f2f  this+10 <- B7097FC49A384CFA::34563B1FC7304350()
    // returns: C179263454B44BF6::.ctor(this)
}
