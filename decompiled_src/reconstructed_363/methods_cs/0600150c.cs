// ============================================================
// token 0x0600150c   283B692664694E2C::.ctor
// native code: 0x28d958dae80  (125 bytes)
// kind: CALL_RET   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   string '',
//   string '',
//   string ''
//   ) cil managed
//   
// native-calls: 06001940,06001511,06001512,06001513
// native-strings: 
// ============================================================

public  void .ctor(string arg0, string arg1, string arg2)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 4 call(s):
    //   0x28d958daea8  652C34B1E6554F10::.ctor(this)
    //   0x28d958daec0  283B692664694E2C::ABF85B5E067F405F(this, arg0)
    //   0x28d958daed8  283B692664694E2C::179674F712A24FCD(this, arg1)
    //   0x28d958daef0  283B692664694E2C::53821C1ED8B244C7(this, arg2)
    // returns: 283B692664694E2C::53821C1ED8B244C7(this, arg2)
}
