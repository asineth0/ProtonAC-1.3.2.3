// ============================================================
// token 0x06000d0f   C0225ABF72C4425E::.ctor
// native code: 0x28d95836290  (1339 bytes)
// kind: DISPATCH   confidence: behavior
// original IL signature:
//   .method public hidebysig specialname rtspecialname
//   instance void .ctor (
//   string ''
//   ) cil managed noinlining
//   
// native-calls: 06000d16,06000003,06000d17,06000004,06000006,06000007,06000005,06000d18,06000d19,06000d1a
// native-strings: 0x24fc:internalLogInformation,0x2518:internalLogWarning,0x2530:internalLogError
// ============================================================

public  void .ctor(string arg0)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 33 call(s):
    //   0x28d958362e8  C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0)
    //   0x28d95836310  <Module>::8B9C7B12B1AE4949(0xffffffffa24f6977)   ; "internalLogInformation"
    //   0x28d95836330  C0225ABF72C4425E::245145C3EE1348C8(C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0), <Module>::8B9C7B12B1AE4949(0xffffffffa24f6977), (xor ?), (xor ?))
    //   0x28d95836350  <Module>::390073C602714496(0xfffffffff10a970c)   ; =1
    //   0x28d95836370  MethodDelegate(C0225ABF72C4425E::245145C3EE1348C8(C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0), <Module>::8B9C7B12B1AE4949(0xffffffffa24f6977), (xor ?), (xor ?)), (<Module>::8B9C7B12B1AE4949(0xffffffffa24f6977) xor 
    //   0x28d95836390  WBARRIER(this+10, (<Module>::8B9C7B12B1AE4949(0xffffffffa24f6977) xor <Module>::8B9C7B12B1AE4949(0xffffffffa24f6977)))
    //   0x28d958363c0  C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0)
    //   0x28d958363e8  <Module>::58ECCB512F2A43AC(0xffffffffa90908df)   ; "internalLogWarning"
    //   0x28d95836408  C0225ABF72C4425E::245145C3EE1348C8(C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0), <Module>::58ECCB512F2A43AC(0xffffffffa90908df), (<Module>::390073C602714496(0xfffffffff10a970c) xor <Module>::390073C602714496(0xfffff
    //   0x28d95836420  <Module>::8B9C7B12B1AE4949(0x14ddf994)   ; =1
    //   0x28d95836440  MethodDelegate(C0225ABF72C4425E::245145C3EE1348C8(C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0), <Module>::58ECCB512F2A43AC(0xffffffffa90908df), (<Module>::390073C602714496(0xfffffffff10a970c) xor <Module>::390073C60
    //   0x28d95836460  WBARRIER(this+18, (<Module>::58ECCB512F2A43AC(0xffffffffa90908df) xor <Module>::58ECCB512F2A43AC(0xffffffffa90908df)))
    //   0x28d95836490  C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0)
    //   0x28d958364b8  <Module>::3F57E81A62734AC2(0x7923f969)   ; "internalLogError"
    //   0x28d958364d8  C0225ABF72C4425E::245145C3EE1348C8(C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0), <Module>::3F57E81A62734AC2(0x7923f969), (<Module>::8B9C7B12B1AE4949(0x14ddf994) xor <Module>::8B9C7B12B1AE4949(0x14ddf994)), (((xor ?)
    //   0x28d958364f0  <Module>::F84FA79ABE6944BB(0x67cf2da4)   ; =1
    //   0x28d95836510  MethodDelegate(C0225ABF72C4425E::245145C3EE1348C8(C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0), <Module>::3F57E81A62734AC2(0x7923f969), (<Module>::8B9C7B12B1AE4949(0x14ddf994) xor <Module>::8B9C7B12B1AE4949(0x14ddf9
    //   0x28d95836530  WBARRIER(this+20, (<Module>::3F57E81A62734AC2(0x7923f969) xor <Module>::3F57E81A62734AC2(0x7923f969)))
    //   0x28d95836548  C0225ABF72C4425E::3B76DFD658B84AAF()
    //   0x28d95836560  WBARRIER(this+38, (<Module>::3F57E81A62734AC2(0x7923f969) xor <Module>::3F57E81A62734AC2(0x7923f969)))
    //   0x28d95836580  <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0))   ; =-1
    //   0x28d95836640  <Module>::3F57E81A62734AC2((movsxd 0xe05640e2), ((((((((((0x5cf89df5 sub 0xbf036aef0c77f93c) xor 0x40bba4b651a22ac5) sub 0x3673c7a5311ac345) not 0x1) xor 0xac86cd49) imul 0xc9ce2587) neg 0x1) imul 0xb96e43d5) div 0x3) mo
    //   0x28d95836650  C0225ABF72C4425E::D8DAE5710B804E3C(<Module>::3F57E81A62734AC2((movsxd 0xe05640e2), ((((((((((0x5cf89df5 sub 0xbf036aef0c77f93c) xor 0x40bba4b651a22ac5) sub 0x3673c7a5311ac345) not 0x1) xor 0xac86cd49) imul 0xc9ce2587) ne
    //   0x28d95836660  ?(C0225ABF72C4425E::D8DAE5710B804E3C(<Module>::3F57E81A62734AC2((movsxd 0xe05640e2), ((((((((((0x5cf89df5 sub 0xbf036aef0c77f93c) xor 0x40bba4b651a22ac5) sub 0x3673c7a5311ac345) not 0x1) xor 0xac86cd49) imul 0xc9ce2587) 
    //   0x28d95836680  WBARRIER(this+40, ((((((((((0x5cf89df5 sub 0xbf036aef0c77f93c) xor 0x40bba4b651a22ac5) sub 0x3673c7a5311ac345) not 0x1) xor 0xac86cd49) imul 0xc9ce2587) neg 0x1) imul 0xb96e43d5) div 0x3) mod 0x3))
    //   0x28d95836698  CreateSingleConsumerUnbounded(this+40, ((((((((((0x5cf89df5 sub 0xbf036aef0c77f93c) xor 0x40bba4b651a22ac5) sub 0x3673c7a5311ac345) not 0x1) xor 0xac86cd49) imul 0xc9ce2587) neg 0x1) imul 0xb96e43d5) div 0x3) mod 0x3), <
    //   0x28d958366b8  WBARRIER(this+28, ((((((((((0x5cf89df5 sub 0xbf036aef0c77f93c) xor 0x40bba4b651a22ac5) sub 0x3673c7a5311ac345) not 0x1) xor 0xac86cd49) imul 0xc9ce2587) neg 0x1) imul 0xb96e43d5) div 0x3) mod 0x3))
    //   0x28d958366e0  ALLOC_OBJECT(0x28cc8356f60)
    //   0x28d95836708  WBARRIER((ALLOC_OBJECT(0x28cc8356f60) add 0x20), ((((((((((0x5cf89df5 sub 0xbf036aef0c77f93c) xor 0x40bba4b651a22ac5) sub 0x3673c7a5311ac345) not 0x1) xor 0xac86cd49) imul 0xc9ce2587) neg 0x1) imul 0xb96e43d5) div 0x3) m
    //   0x28d95836758  C0225ABF72C4425E::C44DBF6F2D1849D6(ALLOC_OBJECT(0x28cc8356f60))
    //   0x28d95836770  WBARRIER(this+30, 0x28d949c3978.f28)
    //   0x28d958367b0  THROW(0x162, 0xca)
    //   0x28d958367c8  THROW(0xf3, 0x106)
    // 14 store(s):
    //   0x28d9583637e  this+10 <- MethodDelegate(C0225ABF72C4425E::245145C3EE1348C8(C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0), <Module>::8B9C7B12B1AE4949(0xffffffffa24f6977), (xor ?), (x
    //   0x28d9583644e  this+18 <- MethodDelegate(C0225ABF72C4425E::245145C3EE1348C8(C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0), <Module>::58ECCB512F2A43AC(0xffffffffa90908df), (<Module>::
    //   0x28d9583651e  this+20 <- MethodDelegate(C0225ABF72C4425E::245145C3EE1348C8(C0225ABF72C4425E::55CE53361FAE40EB(0x28c866aa0f0), <Module>::3F57E81A62734AC2(0x7923f969), (<Module>::8B9C7B12
    //   0x28d95836553  this+38 <- C0225ABF72C4425E::3B76DFD658B84AAF()
    //   0x28d95836583  this <- <Module>::8B9C7B12B1AE4949((movsxd 0xb56a1fe0))
    //   0x28d9583666c  this+40 <- arg0
    //   0x28d958366a6  this+28 <- CreateSingleConsumerUnbounded(this+40, ((((((((((0x5cf89df5 sub 0xbf036aef0c77f93c) xor 0x40bba4b651a22ac5) sub 0x3673c7a5311ac345) not 0x1) xor 0xac86cd49) imu
    //   0x28d958366ef  ALLOC_OBJECT(0x28cc8356f60) <- this
    //   0x28d9583671c  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d94e91c50
    //   0x28d9583672a  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d949c3970
    //   0x28d9583673c  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d949c3978.f28
    //   0x28d95836744  ALLOC_OBJECT(0x28cc8356f60) <- 0x28d949c3978.f20
    //   0x28d95836748  ALLOC_OBJECT(0x28cc8356f60) <- 0x0
    //   0x28d95836763  this+30 <- C0225ABF72C4425E::C44DBF6F2D1849D6(ALLOC_OBJECT(0x28cc8356f60))
    // returns: C0225ABF72C4425E::C44DBF6F2D1849D6(ALLOC_OBJECT(0x28cc8356f60))
    // string table refs:
    //   0x24fc  "internalLogInformation"
    //   0x2518  "internalLogWarning"
    //   0x2530  "internalLogError"
}
