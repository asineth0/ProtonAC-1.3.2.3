// ============================================================
// token 0x0600096a   AE8979A166C64D26::.ctor
// native code: 0x28d97317570  (450 bytes)
// kind: LOOP   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor () cil managed
//   
// native-calls: 
// native-strings: 
// ============================================================

public  void .ctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 9 call(s):
    //   0x28d973175a0  ALLOC_ARRAY(0x28d953c3d40, 0x14)
    //   0x28d973175b8  WBARRIER(this+10, 0x14)
    //   0x28d97317600  ALLOC_OBJECT(0x28ccd860660)
    //   0x28d97317630  WBARRIER((ALLOC_OBJECT(0x28ccd860660) add 0x10), 0x14)
    //   0x28d97317658  WBARRIER((((this.f10 add ((movsxd (rdi xor rdi)) imul 0x48)) add 0x20) add 0x10), 0x28d0b188b60)
    //   0x28d97317698  ALLOC_OBJECT(0x28ccd860be8)
    //   0x28d973176c8  WBARRIER((ALLOC_OBJECT(0x28ccd860be8) add 0x10), 0x28d0b188b60)
    //   0x28d973176f0  WBARRIER((((this.f10 add ((movsxd (rdi xor rdi)) imul 0x48)) add 0x20) add 0x18), 0x28d0b188ae0)
    //   0x28d97317728  THROW(0x146, 0xc2)
    // 5 store(s):
    //   0x28d973175ab  this+10 <- ALLOC_ARRAY(0x28d953c3d40, 0x14)
    //   0x28d9731761c  (ALLOC_OBJECT(0x28ccd860660) add 0x10) <- 0x28d0b188b60
    //   0x28d97317647  (((this.f10 add ((movsxd (rdi xor rdi)) imul 0x48)) add 0x20) add 0x10) <- ALLOC_OBJECT(0x28ccd860660)
    //   0x28d973176b4  (ALLOC_OBJECT(0x28ccd860be8) add 0x10) <- 0x28d0b188ae0
    //   0x28d973176df  (((this.f10 add ((movsxd (rdi xor rdi)) imul 0x48)) add 0x20) add 0x18) <- ALLOC_OBJECT(0x28ccd860be8)
    // returns: ALLOC_OBJECT(0x28ccd860be8)
}
