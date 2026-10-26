// ============================================================
// token 0x06000554   2A320E2F1A3D4AAC::0C6AFC1C87254787
// native code: 0x28d97312e30  (6806 bytes)
// kind: LOOP   confidence: outline
// original IL signature:
//   .method public hidebysig static
//   bool '0C6AFC1C87254787' (
//   class ['Assembly-CSharp']SDG.Unturned.VehicleManager __instance
//   ) cil managed
//   
// native-calls: 06000575,060000b0,06000271,0600095e,0600095f,06000272,06000273,06003fb5,060019f5,060008c5,06001872,06001c64,060060ad,060060f9,0600093c,06006108,0600062c,0600062b,060005f8,06000277,060019f6,06001469,06001a34,06003fb3,06002851,06000275,06000978,06001c75,06006153,06001a5f,060011d7
// native-strings: 
// ============================================================

public static bool 0C6AFC1C87254787(SDG.Unturned.VehicleManager __instance)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 94 call(s):
    //   0x28d97312f18  ALLOC_OBJECT(0x28d9539e160)
    //   0x28d97312f30  4B3FB6AB0B764184::.ctor(ALLOC_OBJECT(0x28d9539e160))
    //   0x28d97312f60  WBARRIER((ALLOC_OBJECT(0x28d9539e160) add 0x10), ?)
    //   0x28d97312f78  1DB744298E9F4B09::C2FE386528B74E31()
    //   0x28d97312fa8  40FE7AC3F69F4B10::10270708481F445D(1DB744298E9F4B09::C2FE386528B74E31().f80)
    //   0x28d97312fd0  40FE7AC3F69F4B10::10270708481F445D(0x28d03164000)
    //   0x28d97313030  0732D1C8FF584BB5::648E305AD3AD4839(0x28cf0dd9f60)
    //   0x28d97313060  GetEnumerator(0x28c8599ee60.f0, (? add 0xfffffffffffffdb0), ?, ?)
    //   0x28d973130b8  Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)
    //   0x28d973130e8  Contains(0x28ccb6edc80.f0.f0, (rax xor rax), ?, ?)
    //   0x28d97313128  ContainsKey(0x28cf0dd9f60.f10, (rax xor rax).f228, ?, ?)
    //   0x28d97313160  0732D1C8FF584BB5::E277BCCCC4774490(0x28cf0dd9f60, (rax xor rax), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)))
    //   0x28d97313188  MoveNext((? add 0xfffffffffffffdb0), (rax xor rax), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?)
    //   0x28d973131a2  sub_28d973131cd((? add 0xfffffffffffffdb0), (rax xor rax), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?)
    //   0x28d973131c8  sub_28b82785f1f((? add 0xfffffffffffffdb0), (rax xor rax), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?)
    //   0x28d97313210  Clear(0x28ccb6edcd0.f0, (rax xor rax), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?)
    //   0x28d97313248  40FE7AC3F69F4B10::F27B18C1D6E54F89(0x28d03164000)
    //   0x28d97313270  40FE7AC3F69F4B10::7FA5DD9F1F7146C9(0x28d03164000, 40FE7AC3F69F4B10::F27B18C1D6E54F89(0x28d03164000))
    //   0x28d97313298  40FE7AC3F69F4B10::10270708481F445D(0x28d02ae7e00)
    //   0x28d973132c8  GetEnumerator(0x28cc768cb50.f0, (? add 0xfffffffffffffdc8), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?)
    //   0x28d973132f0  SteamPlayer::get_player((rax xor rax), (? add 0xfffffffffffffdc8), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?)
    //   0x28d97313308  Object::op_Equality(SteamPlayer::get_player((rax xor rax), (? add 0xfffffffffffffdc8), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?), ((? add 0xfffffffffffffdc8) xor (? add 0xffffffff
    //   0x28d97313330  SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?)
    //   0x28d97313340  A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?), (
    //   0x28d973133a0  SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?)
    //   0x28d973133b8  Component::get_transform(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0), ?, ?)), ?), ((? add 0xf
    //   0x28d973133d8  Transform::get_position(Component::get_transform(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add 0x20).f0),
    //   0x28d97313400  Dictionary`2::get_Values(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (movzx Contains(0x28ccb6edcd0.f0, (movsxd ((rax xor rax) add
    //   0x28d97313420  ValueCollection::GetEnumerator(Dictionary`2::get_Values(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (movzx Contains(0x28ccb6edcd0
    //   0x28d973134e8  087B17044C8447C2::C78D9091A5D444E1((rax xor rax), (rax xor rax), (? add 0xfffffffffffffeb8), ?)
    //   0x28d973135f0  Enumerator::MoveNext((? add 0xfffffffffffffdf0), (movsxd 0x28ccb6edcf4.f0), (rax xor rax), ?)
    //   0x28d9731360a  sub_28d97313635((? add 0xfffffffffffffdf0), (movsxd 0x28ccb6edcf4.f0), (rax xor rax), ?)
    //   0x28d97313630  sub_28b82785f1f((? add 0xfffffffffffffdf0), (movsxd 0x28ccb6edcf4.f0), (rax xor rax), ?)
    //   0x28d97313698  E0979537EFEC4491::FC8EE84CBF844C5F((rax xor rax).f10, 0x28d03242000, (movsxd 0x28ccb6edcf4.f0), ?)
    //   0x28d973136e0  E0979537EFEC4491::B7B0E288AF484EF2((rax xor rax).f10, 0x28d03240000, (movsxd 0x28ccb6edcf0.f0), ?)
    //   0x28d97313728  2B4193F94A734FAF::C94D65522B8243AA((rax xor rax).f10, 0x28d03244000, (movsxd 0x28ccb6edcf8.f0), (rax xor rax))
    //   0x28d97313860  SteamPlayer::get_player((rax xor rax), 0x28d03244000, (movsxd 0x28ccb6edcf8.f0), (rax xor rax))
    //   0x28d97313878  Component::get_transform(SteamPlayer::get_player((rax xor rax), 0x28d03244000, (movsxd 0x28ccb6edcf8.f0), (rax xor rax)), 0x28d03244000, (movsxd 0x28ccb6edcf8.f0), (rax xor rax))
    //   0x28d97313898  Transform::get_position(Component::get_transform(SteamPlayer::get_player((rax xor rax), 0x28d03244000, (movsxd 0x28ccb6edcf8.f0), (rax xor rax)), 0x28d03244000, (movsxd 0x28ccb6edcf8.f0), (rax xor rax)), (? add 0xfffffff
    //   0x28d973138c0  Transform::get_position(0x28b826c0f20.f0.f0.f0.f20, (? add 0xfffffffffffffee8), (movsxd 0x28ccb6edcf8.f0), (rax xor rax))
    //   0x28d97313c0c  sub_28d97313c35(0x28b826c0f20.f0.f0, 0x28b826c0f00.f0, (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97313c30  sub_28b82785f1f(0x28b826c0f20.f0.f0, 0x28b826c0f00.f0, (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97313cb0  MoveNext((? add 0xfffffffffffffdc8), 0x28b826c0f00.f0, (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97313cca  sub_28d97313cf5((? add 0xfffffffffffffdc8), 0x28b826c0f00.f0, (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97313cf0  sub_28b82785f1f((? add 0xfffffffffffffdc8), 0x28b826c0f00.f0, (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97313d50  40FE7AC3F69F4B10::F27B18C1D6E54F89(0x28d02ae7e00)
    //   0x28d97313d78  40FE7AC3F69F4B10::7FA5DD9F1F7146C9(0x28d02ae7e00, 40FE7AC3F69F4B10::F27B18C1D6E54F89(0x28d02ae7e00))
    //   0x28d97313d88  1DB744298E9F4B09::C2FE386528B74E31()
    //   0x28d97313db0  1DB744298E9F4B09::C2FE386528B74E31()
    //   0x28d97313dd0  40FE7AC3F69F4B10::F27B18C1D6E54F89(1DB744298E9F4B09::C2FE386528B74E31().f80)
    //   0x28d97313de8  40FE7AC3F69F4B10::F471762FF8094F2B(1DB744298E9F4B09::C2FE386528B74E31().f80, 40FE7AC3F69F4B10::F27B18C1D6E54F89(1DB744298E9F4B09::C2FE386528B74E31().f80))
    //   0x28d97313e70  GetEnumerator(0x28cc768cb50.f0, (? add 0xfffffffffffffdc8), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97313ea8  SteamPlayer::get_player((rax xor rax), (? add 0xfffffffffffffdc8), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97313ec0  Object::op_Inequality(SteamPlayer::get_player((rax xor rax), (? add 0xfffffffffffffdc8), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f
    //   0x28d97313ee8  SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97313ef8  A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xffff
    //   0x28d97313f80  Array::Clear(0x28ccb6edc88.f0.f0.f10, (((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)) xor ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8))), (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f2
    //   0x28d97313fb8  HashSet`1::GetEnumerator(0x28ccb6edc80.f0.f0, (? add 0xfffffffffffffe18), (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97313fd8  Object::op_Inequality((rax xor rax), ((? add 0xfffffffffffffe18) xor (? add 0xfffffffffffffe18)), (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314000  SteamPlayer::get_playerID((rax xor rax), ((? add 0xfffffffffffffe18) xor (? add 0xfffffffffffffe18)), (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314048  InteractableVehicle::checkDriver((rax xor rax), (movsxd (SteamPlayer::get_playerID((rax xor rax), ((? add 0xfffffffffffffe18) xor (? add 0xfffffffffffffe18)), (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f
    //   0x28d97314090  40FE7AC3F69F4B10::5D65B053CE1947AD(0x28d02ae7dc0, (? add 0xfffffffffffffe30), (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)
    //   0x28d973140b8  7A383615B64E4244::F424C4A47EFA4596(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0x
    //   0x28d973140e0  Component::get_transform((rax xor rax), (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314100  Transform::get_position(Component::get_transform((rax xor rax), (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0), (? add 0xffffffffffffff08), (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)
    //   0x28d97314140  Component::get_transform((rax xor rax), (? add 0xffffffffffffff08), (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314160  Transform::get_rotation(Component::get_transform((rax xor rax), (? add 0xffffffffffffff08), (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0), (? add 0xffffffffffffff18), (movsxd (movsxd 0x28ccb6edc88.f0
    //   0x28d973142a0  SteamPlayer::get_playerID((rax xor rax), 0x28ccb6edc98.f0, (r14 xor r14), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314349  sub_28d973143a5((movsxd (movsxd (SteamPlayer::get_playerID((rax xor rax), 0x28ccb6edc98.f0, (r14 xor r14), 0x28b826c0f20.f0.f0.f0) add 0x30).f0)), 0x28ccb6edc98.f0, (r14 xor r14), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314368  sub_28b82785f1f((movsxd (movsxd (SteamPlayer::get_playerID((rax xor rax), 0x28ccb6edc98.f0, (r14 xor r14), 0x28b826c0f20.f0.f0.f0) add 0x30).f0)), 0x28ccb6edc98.f0, (r14 xor r14), 0x28b826c0f20.f0.f0.f0)
    //   0x28d9731437f  sub_28d973143a5((movsxd (movsxd (SteamPlayer::get_playerID((rax xor rax), 0x28ccb6edc98.f0, (r14 xor r14), 0x28b826c0f20.f0.f0.f0) add 0x30).f0)), 0x28ccb6edc98.f0, (r14 xor r14), 0x28b826c0f20.f0.f0.f0)
    //   0x28d973143a0  sub_28b82785f1f((movsxd (movsxd (SteamPlayer::get_playerID((rax xor rax), 0x28ccb6edc98.f0, (r14 xor r14), 0x28b826c0f20.f0.f0.f0) add 0x30).f0)), 0x28ccb6edc98.f0, (r14 xor r14), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314450  List`1::AddWithResize(0x28ccb6edc88.f0.f0, (rax xor rax), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314478  Enumerator::MoveNext((? add 0xfffffffffffffe18), (rax xor rax), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314492  sub_28d973144bd((? add 0xfffffffffffffe18), (rax xor rax), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d973144b8  sub_28b82785f1f((? add 0xfffffffffffffe18), (rax xor rax), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314518  SteamPlayer::get_player((rax xor rax), (rax xor rax), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314530  Component::get_transform(SteamPlayer::get_player((rax xor rax), (rax xor rax), (rax xor rax), 0x28b826c0f20.f0.f0.f0), (rax xor rax), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314550  Transform::get_position(Component::get_transform(SteamPlayer::get_player((rax xor rax), (rax xor rax), (rax xor rax), 0x28b826c0f20.f0.f0.f0), (rax xor rax), (rax xor rax), 0x28b826c0f20.f0.f0.f0), (? add 0xfffffffffffff
    //   0x28d973145a0  ALLOC_OBJECT(0x28d936899c8)
    //   0x28d973145d0  sub_28b82780dcb((ALLOC_OBJECT(0x28d936899c8) add 0x20), (? add 0xfffffffffffffe40), (rax xor rax), 0x28b826c0f20.f0.f0.f0)
    //   0x28d97314670  ClientStaticMethod::Invoke(0x28d02b49b00, 0x1, (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d97314698  MoveNext((? add 0xfffffffffffffdc8), 0x1, (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d973146b2  sub_28d973146dd((? add 0xfffffffffffffdc8), 0x1, (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d973146d8  sub_28b82785f1f((? add 0xfffffffffffffdc8), 0x1, (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d97314720  GetEnumerator(0x28ccb6edc80.f0.f0, (? add 0xfffffffffffffe18), (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d97314748  op_Inequality((rax xor rax), ((? add 0xfffffffffffffe18) xor (? add 0xfffffffffffffe18)), (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d97314798  MoveNext((? add 0xfffffffffffffe18), (rax xor rax), (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d973147ae  sub_28d973147d5((? add 0xfffffffffffffe18), (rax xor rax), (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d973147d0  sub_28b82785f1f((? add 0xfffffffffffffe18), (rax xor rax), (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d97314810  Clear(0x28ccb6edc80.f0.f0, (rax xor rax), (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8))
    //   0x28d97314850  THROW(0x162, 0x2a3)
    //   0x28d97314868  THROW(0xf3, 0x2e8)
    //   0x28d97314888  THROW(0x146, 0x626)
    // 33 store(s):
    //   0x28d97312f4c  (ALLOC_OBJECT(0x28d9539e160) add 0x10) <- __instance
    //   0x28d9731335d  0x28ccb6edcf0 <- 0x0
    //   0x28d9731336d  0x28ccb6edcf4 <- 0x0
    //   0x28d9731337d  0x28ccb6edcf8 <- 0x0
    //   0x28d97313441  (rax xor rax) <- 0x0
    //   0x28d97313487  0x28ccb6edcf0 <- ((movsxd 0x28ccb6edcf0.f0) inc 0x1)
    //   0x28d9731350f  (rax xor rax) <- (movzx 087B17044C8447C2::C78D9091A5D444E1((rax xor rax), (rax xor rax), (? add 0xfffffffffffffeb8), ?))
    //   0x28d9731355d  0x28ccb6edcf8 <- ((movsxd 0x28ccb6edcf8.f0) inc 0x1)
    //   0x28d9731357b  (rax xor rax) <- 0x1
    //   0x28d973135c1  0x28ccb6edcf4 <- ((movsxd 0x28ccb6edcf4.f0) inc 0x1)
    //   0x28d97313b0f  0x28d02319c70 <- 0x1
    //   0x28d97313bd8  0x28d02319c70 <- 0x0
    //   0x28d97313e46  0x28ccb6edca8.f0 <- (0x28ccb6edca8.f0.f0 inc 0x1)
    //   0x28d97313f31  0x28ccb6edc88.f0.f0 <- ((movsxd 0x28ccb6edc88.f0.f0.f1c) inc 0x1)
    //   0x28d97313f52  0x28ccb6edc88.f0.f0 <- 0x0
    //   0x28d97313f8c  0x28ccb6edc88.f0.f0 <- 0x0
    //   0x28d97314117  7A383615B64E4244::F424C4A47EFA4596(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0).f90, (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)+3c <- (movsxd S[rbp-f8])
    //   0x28d97314120  7A383615B64E4244::F424C4A47EFA4596(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0).f90, (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)+3c <- (movsxd S[rbp-f4])
    //   0x28d9731412a  7A383615B64E4244::F424C4A47EFA4596(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0).f90, (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)+3c <- (movsxd S[rbp-f0])
    //   0x28d97314177  7A383615B64E4244::F424C4A47EFA4596(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0).f90, (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)+48 <- (movsxd S[rbp-e8])
    //   0x28d97314180  7A383615B64E4244::F424C4A47EFA4596(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0).f90, (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)+48 <- (movsxd S[rbp-e4])
    //   0x28d9731418a  7A383615B64E4244::F424C4A47EFA4596(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0).f90, (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)+48 <- (movsxd S[rbp-e0])
    //   0x28d97314194  7A383615B64E4244::F424C4A47EFA4596(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0).f90, (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0)+48 <- (movsxd S[rbp-dc])
    //   0x28d97314328  7A383615B64E4244::F424C4A47EFA4596(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0), ((? add 0xfffffffffffffdc8) xor (? add 0xfffffffffffffdc8)), (rax xor rax), 0x28b826c0f20.f0.f0.f0).f90, (rax xor rax).f228, (movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)), 0x28b826c0f20.f0.f0.f0) <- 0x0
    //   0x28d973143f8  0x28ccb6edc88.f0.f0 <- ((movsxd 0x28ccb6edc88.f0.f0.f1c) inc 0x1)
    //   0x28d9731441e  0x28ccb6edc88.f0.f0 <- ((movsxd (movsxd 0x28ccb6edc88.f0.f0.f18)) inc 0x1)
    //   0x28d973145b6  ALLOC_OBJECT(0x28d936899c8) <- ALLOC_OBJECT(0x28d9539e160)
    //   0x28d973145f2  ALLOC_OBJECT(0x28d936899c8) <- 0x28d96952790
    //   0x28d97314600  ALLOC_OBJECT(0x28d936899c8) <- 0x28ccd85f8c8
    //   0x28d97314612  ALLOC_OBJECT(0x28d936899c8) <- 0x28ccd85f8d0.f28
    // returns: (Clear(0x28ccb6edc80.f0.f0, (rax xor rax), (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8)) xor Clear(0x28ccb6edc80.f0.f0, (rax xor rax), (rax xor rax).f10, ALLOC_OBJECT(0x28d936899c8)))
}
