// ============================================================
// token 0x0600014b   FA614F32E31A4FDD::2F2E47BE5BFE404B
// native code: 0x28d97306860  (2939 bytes)
// kind: DISPATCH   confidence: outline
// original IL signature:
//   .method public hidebysig static
//   void '2F2E47BE5BFE404B' () cil managed noinlining
//   
// native-calls: 0600015a,0600015b,06000004,06000158,06000007,06000159,0600015c,06000003,0600015d,06000151,0600015e,06001a39,06000152,06000006,060060b1,0600014c,06001469
// native-strings: 0x53c:ProtonAC.BarricadeGeometryScan
// ============================================================

public static void 2F2E47BE5BFE404B()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 27 call(s):
    //   0x28d973068d0  Clear(0x28c840e6508.f0, ?, ?, ?)
    //   0x28d97306950  FA614F32E31A4FDD::0210227444604609(0x0)
    //   0x28d97306a30  FA614F32E31A4FDD::6B6B0AA68E1F424D(FA614F32E31A4FDD::0210227444604609(0x0), (? add 0xffffffffffffff48), (? add 0xffffffffffffff38))
    //   0x28d97306a70  Clear(0x28c840e6518.f0, (? add 0xffffffffffffff48), (? add 0xffffffffffffff38), ?)
    //   0x28d97306a98  <Module>::390073C602714496((movsxd 0x1bfeae9))   ; "ProtonAC.BarricadeGeometryScan"
    //   0x28d97306aa8  FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9)))
    //   0x28d97306ae8  <Module>::3F57E81A62734AC2(0xffffffff94857146)   ; =0
    //   0x28d97306b00  FA614F32E31A4FDD::9E421E6E6C004E33(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9))), <Module>::3F57E81A62734AC2(0xffffffff94857146))
    //   0x28d97306b30  Clear(0x28c840e6510.f0, <Module>::3F57E81A62734AC2(0xffffffff94857146), (? add 0xffffffffffffff38), ?)
    //   0x28d97306b60  FA614F32E31A4FDD::0210227444604609(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9))))
    //   0x28d97306bc0  FA614F32E31A4FDD::9D9A7DB609C84983(FA614F32E31A4FDD::0210227444604609(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9)))), (? add 0xffffffffffffff68))
    //   0x28d97306be0  <Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994))   ; =1
    //   0x28d97306bf0  FA614F32E31A4FDD::D175BFE1F3B94F56(<Module>::8B9C7B12B1AE4949((movsxd 0x14ddf994)))
    //   0x28d97306c78  FA614F32E31A4FDD::0210227444604609(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9))), ((((((movsxd 0xf40c77e8) not 0x1) imul 0x6a47bb5f) imul 0xc565503f) div 0xc) mod 0xc), (? add 0xfffff
    //   0x28d97306c90  FA614F32E31A4FDD::B92B8DE302DD40F7((r14 xor r14), FA614F32E31A4FDD::0210227444604609(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9))), ((((((movsxd 0xf40c77e8) not 0x1) imul 0x6a47bb5f) 
    //   0x28d97306d00  FA614F32E31A4FDD::0DF8867D56B54525((r14 xor r14), (FA614F32E31A4FDD::0210227444604609(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9))), ((((((movsxd 0xf40c77e8) not 0x1) imul 0x6a47bb5f)
    //   0x28d97306d90  HashSet`1::Add(0x28c840e6510.f0, (movzx (r15 xor r15).f48), (? add 0xffffffffffffff38), ?)
    //   0x28d97306da0  FA614F32E31A4FDD::4D63DEA9B66E4E90((r15 xor r15), (movzx (r15 xor r15).f48), (? add 0xffffffffffffff38), ?)
    //   0x28d97306de0  <Module>::58ECCB512F2A43AC((movsxd 0x1505777c))   ; =0
    //   0x28d97306e60  Dictionary`2::set_Item(0x28c840e6508.f0, (movzx (r15 xor r15).f48), FA614F32E31A4FDD::B92B8DE302DD40F7((r14 xor r14), FA614F32E31A4FDD::0210227444604609(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movs
    //   0x28d97306e78  FA614F32E31A4FDD::99817E2B2825489E((r15 xor r15), FA614F32E31A4FDD::B92B8DE302DD40F7((r14 xor r14), FA614F32E31A4FDD::0210227444604609(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9))), (
    //   0x28d97306ec0  <Module>::8B9C7B12B1AE4949(0x14ddf994)   ; =1
    //   0x28d97307003  sub_28d97307170(0x28c866789e0, (r15 xor r15), FA614F32E31A4FDD::B92B8DE302DD40F7((r14 xor r14), FA614F32E31A4FDD::0210227444604609(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9))), (((((
    //   0x28d97307028  sub_28b82785f1f(0x28c866789e0, (r15 xor r15), FA614F32E31A4FDD::B92B8DE302DD40F7((r14 xor r14), FA614F32E31A4FDD::0210227444604609(FA614F32E31A4FDD::D7CEC37CB6F24CC3(<Module>::390073C602714496((movsxd 0x1bfeae9))), (((((
    //   0x28d973072c0  Array::Clear(0x28c840e6520.f0.f10, (((((((movsxd 0x1a4f3144) not 0x1) imul 0x6a47bb5f) imul 0xc565503f) div 0x3) mod 0x3) xor ((((((movsxd 0x1a4f3144) not 0x1) imul 0x6a47bb5f) imul 0xc565503f) div 0x3) mod 0x3)), (movsx
    //   0x28d97307360  Array::Clear(0x28c840e6528.f0.f10, ((((((((movsxd 0x1a4f3144) not 0x1) imul 0x6a47bb5f) imul 0xc565503f) div 0x3) mod 0x3) xor ((((((movsxd 0x1a4f3144) not 0x1) imul 0x6a47bb5f) imul 0xc565503f) div 0x3) mod 0x3)) xor ((
    //   0x28d973073d8  THROW(0x146, 0x47f)
    // 6 store(s):
    //   0x28d97307264  0x28c840e6520.f0 <- ((movsxd 0x28c840e6520.f0.f1c) inc 0x1)
    //   0x28d9730728c  0x28c840e6520.f0 <- 0x0
    //   0x28d973072cc  0x28c840e6520.f0 <- 0x0
    //   0x28d97307306  0x28c840e6528.f0 <- ((movsxd 0x28c840e6528.f0.f1c) inc 0x1)
    //   0x28d9730732b  0x28c840e6528.f0 <- 0x0
    //   0x28d9730736c  0x28c840e6528.f0 <- 0x0
    // returns: ((((((movsxd 0x1a4f3144) not 0x1) imul 0x6a47bb5f) imul 0xc565503f) imul 0xd5e6b19c) xor 0xbabb5795)
    // string table refs:
    //   0x53c  "ProtonAC.BarricadeGeometryScan"
}
