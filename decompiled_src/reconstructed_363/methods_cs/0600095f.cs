// ============================================================
// token 0x0600095f   0732D1C8FF584BB5::E277BCCCC4774490
// native code: 0x28d97316280  (3649 bytes)
// kind: LOOP   confidence: outline
// original IL signature:
//   .method public hidebysig
//   instance void E277BCCCC4774490 (
//   class ['Assembly-CSharp']SDG.Unturned.InteractableVehicle '',
//   bool ''
//   ) cil managed
//   
// native-calls: 06000969,06001469,06001881,0600096d,06000963,060001be,06000968
// native-strings: 
// ============================================================

public  void E277BCCCC4774490(SDG.Unturned.InteractableVehicle arg0, bool arg1)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 48 call(s):
    //   0x28d97316340  memset((? add 0xfffffffffffffd38), (arg0 xor arg0), 0x58, ?)
    //   0x28d97316380  TryGetValue(this.f10, arg0.f228, (? add 0xfffffffffffffce0), ?)
    //   0x28d973163a0  ALLOC_OBJECT(0x28ccd8602a8)
    //   0x28d973163b8  4774CC3E188745EA::.ctor(ALLOC_OBJECT(0x28ccd8602a8))
    //   0x28d97316408  Add(this.f10, arg0.f228, ALLOC_OBJECT(0x28ccd8602a8), ?)
    //   0x28d97316470  Array::Clear(ALLOC_OBJECT(0x28ccd8602a8).f10.f10, (arg0.f228 xor arg0.f228), (movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f18), ?)
    //   0x28d97316498  GetComponents(arg0, (arg0.f228 xor arg0.f228), (movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f18), ?)
    //   0x28d973164e8  sub_28cc86e2cd0(GetComponents(arg0, (arg0.f228 xor arg0.f228), (movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f18), ?)+(movsxd (r12 xor r12))*8+20.f0, (arg0.f228 xor arg0.f228), (movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f18), ?)
    //   0x28d97316500  sub_28d941e4dd0(sub_28cc86e2cd0(GetComponents(arg0, (arg0.f228 xor arg0.f228), (movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f18), ?)+(movsxd (r12 xor r12))*8+20.f0, (arg0.f228 xor arg0.f228), (movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f18
    //   0x28d97316578  AddWithResize(ALLOC_OBJECT(0x28ccd8602a8).f10, GetComponents(arg0, (arg0.f228 xor arg0.f228), (movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f18), ?)+(movsxd (r12 xor r12))*8+20.f0, GetComponents(arg0, (arg0.f228 xor arg0.f228), (movsxd AL
    //   0x28d973165e8  Array::Clear(ALLOC_OBJECT(0x28ccd8602a8).f18.f10, (GetComponents(arg0, (arg0.f228 xor arg0.f228), (movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f18), ?)+(movsxd (r12 xor r12))*8+20.f0 xor GetComponents(arg0, (arg0.f228 xor arg0.f228), (mo
    //   0x28d97316620  GetComponentsInChildren(arg0, 0x1, ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316650  GetEnumerator(ALLOC_OBJECT(0x28ccd8602a8).f18, (? add 0xfffffffffffffce8), ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316670  op_Equality((rax xor rax), ((? add 0xfffffffffffffce8) xor (? add 0xfffffffffffffce8)), ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d973166f8  Array::Clear(ALLOC_OBJECT(0x28ccd8602a8).f18.f10, (((? add 0xfffffffffffffce8) xor (? add 0xfffffffffffffce8)) xor ((? add 0xfffffffffffffce8) xor (? add 0xfffffffffffffce8))), (movsxd (movsxd ALLOC_OBJECT(0x28ccd8602a8)
    //   0x28d97316740  Component::GetComponentsInChildren(arg0, 0x1, ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316752  sub_28d973167e5(arg0, 0x1, ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316778  sub_28b82785f1f(arg0, 0x1, ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d973167a0  MoveNext((? add 0xfffffffffffffce8), 0x1, ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d973167ba  sub_28d973167e5((? add 0xfffffffffffffce8), 0x1, ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d973167e0  sub_28b82785f1f((? add 0xfffffffffffffce8), 0x1, ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316820  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20)
    //   0x28d97316848  sub_28d941ea4f0(arg0, 0x1, ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316868  get_position(sub_28d941ea4f0(arg0, 0x1, ALLOC_OBJECT(0x28ccd8602a8).f18, ?), (? add 0xfffffffffffffe08), ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d973168c0  0732D1C8FF584BB5::4D79E39DE8BE4B66(ALLOC_OBJECT(0x28ccd8602a8).f18)
    //   0x28d97316920  9AB67761792440A7::00FC653ED33A4A96()
    //   0x28d97316938  FFFC598AFAF4431B::13A4E50077024097(AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20), 9AB67761792440A7::00FC653ED33A4A96())
    //   0x28d973169e8  get_position(arg0.f1a0+(movsxd (((r12 xor r12) inc 0x1) xor ((r12 xor r12) inc 0x1)))*8+20.f0.f20, (? add 0xfffffffffffffe38), ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316a48  get_rotation(arg0.f1a0+(movsxd (((r12 xor r12) inc 0x1) xor ((r12 xor r12) inc 0x1)))*8+20.f0.f20, (? add 0xfffffffffffffe48), ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316c70  AddWithResize(AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10, (? add 0xfffffffffffffe78), ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316ca8  GetEnumerator(ALLOC_OBJECT(0x28ccd8602a8).f10, (? add 0xfffffffffffffd20), ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316cd8  sub_28cc86e2cd0((rax xor rax), (? add 0xfffffffffffffd20), ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316cf0  sub_28d941e4dd0(sub_28cc86e2cd0((rax xor rax), (? add 0xfffffffffffffd20), ALLOC_OBJECT(0x28ccd8602a8).f18, ?), (? add 0xfffffffffffffd20), ALLOC_OBJECT(0x28ccd8602a8).f18, ?)
    //   0x28d97316d38  memset((? add 0xfffffffffffffd38), ((? add 0xfffffffffffffd20) xor (? add 0xfffffffffffffd20)), 0x58, ?)
    //   0x28d97316d58  get_center((rax xor rax), (? add 0xfffffffffffffe98), 0x58, ?)
    //   0x28d97316db0  get_size((rax xor rax), (? add 0xfffffffffffffea8), 0x58, ?)
    //   0x28d97316e00  sub_28d941ea4f0((rax xor rax), (? add 0xfffffffffffffea8), 0x58, ?)
    //   0x28d97316e20  get_worldToLocalMatrix(sub_28d941ea4f0((rax xor rax), (? add 0xfffffffffffffea8), 0x58, ?), (? add 0xfffffffffffffeb8), 0x58, ?)
    //   0x28d97316e48  memcpy(((? add 0xfffffffffffffd38) add 0x18), (? add 0xfffffffffffffeb8), 0x40, ?)
    //   0x28d97316e70  memcpy((? add 0xfffffffffffffef8), (? add 0xfffffffffffffd38), 0x58, ?)
    //   0x28d97316ea8  memcpy((? add 0xfffffffffffffdb0), (? add 0xfffffffffffffef8), 0x58, ?)
    //   0x28d97316f10  memcpy(((AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f18.f10 add ((movsxd (movsxd AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f18.f18)) imul 0x58)) add 0x20), (? add 0xffff
    //   0x28d97316fc0  AddWithResize(AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f18, (? add 0xffffffffffffff50), 0x58, ?)
    //   0x28d97316fe8  MoveNext((? add 0xfffffffffffffd20), (? add 0xffffffffffffff50), 0x58, ?)
    //   0x28d97317002  sub_28d9731702d((? add 0xfffffffffffffd20), (? add 0xffffffffffffff50), 0x58, ?)
    //   0x28d97317028  sub_28b82785f1f((? add 0xfffffffffffffd20), (? add 0xffffffffffffff50), 0x58, ?)
    //   0x28d97317088  THROW(0x146, 0x1ab)
    //   0x28d973170b0  THROW(0x162, 0x7ed)
    // 38 store(s):
    //   0x28d97316446  ALLOC_OBJECT(0x28ccd8602a8).f10 <- ((movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f1c) inc 0x1)
    //   0x28d9731644d  ALLOC_OBJECT(0x28ccd8602a8).f10 <- 0x0
    //   0x28d97316536  ALLOC_OBJECT(0x28ccd8602a8).f10 <- ((movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f1c) inc 0x1)
    //   0x28d97316550  ALLOC_OBJECT(0x28ccd8602a8).f10 <- (movsxd ALLOC_OBJECT(0x28ccd8602a8).f10.f18)+1
    //   0x28d973165c1  ALLOC_OBJECT(0x28ccd8602a8).f18 <- ((movsxd ALLOC_OBJECT(0x28ccd8602a8).f18.f1c) inc 0x1)
    //   0x28d973165c9  ALLOC_OBJECT(0x28ccd8602a8).f18 <- 0x0
    //   0x28d973166a7  ALLOC_OBJECT(0x28ccd8602a8).f18 <- ((movsxd ALLOC_OBJECT(0x28ccd8602a8).f18.f1c) inc 0x1)
    //   0x28d973166c8  ALLOC_OBJECT(0x28ccd8602a8).f18 <- 0x0
    //   0x28d97316704  ALLOC_OBJECT(0x28ccd8602a8).f18 <- 0x0
    //   0x28d97316882  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20) <- (movsxd S[rbp-1f8])
    //   0x28d9731688c  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20) <- (movsxd S[rbp-1f4])
    //   0x28d97316897  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20) <- (movsxd S[rbp-1f0])
    //   0x28d973168d7  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20)+20 <- (movsxd S[rbp-1e8])
    //   0x28d973168e0  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20)+20 <- (movsxd S[rbp-1e4])
    //   0x28d973168ea  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20)+20 <- (movsxd S[rbp-1e0])
    //   0x28d973168f4  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20)+20 <- (movsxd S[rbp-1dc])
    //   0x28d973168fe  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20)+20 <- (movsxd S[rbp-1d8])
    //   0x28d97316908  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20)+20 <- (movsxd S[rbp-1d4])
    //   0x28d97316912  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20)+20 <- (movsxd S[rbp-1d0])
    //   0x28d97316a64  ((? add 0xfffffffffffffd00) add 0xc) <- (movsxd S[rbp-1b8])
    //   0x28d97316a6d  ((? add 0xfffffffffffffd00) add 0xc) <- (movsxd S[rbp-1b4])
    //   0x28d97316a77  ((? add 0xfffffffffffffd00) add 0xc) <- (movsxd S[rbp-1b0])
    //   0x28d97316a81  ((? add 0xfffffffffffffd00) add 0xc) <- (movsxd S[rbp-1ac])
    //   0x28d97316b78  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10 <- ((movsxd AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f1c) inc 0x1)
    //   0x28d97316ba8  AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10 <- ((movsxd (movsxd AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f18)) inc 0x1)
    //   0x28d97316bd1  ((AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f10 add ((movsxd (movsxd (movsxd AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f18))) shl 0x5)) add 0x20) <- (movsxd (movsxd (movsxd (movsxd S[rbp-1c8]))))
    //   0x28d97316bda  ((AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f10 add ((movsxd (movsxd (movsxd AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f18))) shl 0x5)) add 0x20) <- (movsxd (movsxd (movsxd (movsxd S[rbp-1c4]))))
    //   0x28d97316be4  ((AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f10 add ((movsxd (movsxd (movsxd AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f18))) shl 0x5)) add 0x20) <- (movsxd (movsxd (movsxd (movsxd S[rbp-1c0]))))
    //   0x28d97316bee  ((AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f10 add ((movsxd (movsxd (movsxd AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f18))) shl 0x5)) add 0x20) <- (movsxd (movsxd (movsxd 0x0)))
    //   0x28d97316bf8  ((AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f10 add ((movsxd (movsxd (movsxd AE8979A166C64D26::3A3AAE3891E54E4A(ALLOC_OBJECT(0x28ccd8602a8).f20).f10.f18))) shl 0x5)) add 0x20) <- (movsxd (movsxd (movsxd 0x0)))
    // returns: sub_28b82785f1f((? add 0xfffffffffffffd20), (? add 0xffffffffffffff50), 0x58, ?)
}
