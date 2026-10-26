// ============================================================
// token 0x060006cf   F0CD1E00058640DE::SendPlayerStates_Prefix
// native code: 0x28d973093e0  (3243 bytes)
// kind: LOOP   confidence: outline
// original IL signature:
//   .method public hidebysig static
//   bool SendPlayerStates_Prefix (
//   class ['Assembly-CSharp']SDG.Unturned.PlayerManager __instance
//   ) cil managed
//   
// native-calls: 060001be,06000271,06000360,06006141,06001bd4,060006d2,0600463e,0600372c,06003fb5,060019f5,060008c5,0600094a,06003b0d,06003b12,06003b0f,06003b18,06000950,0600616e,0600618e,06001469,06001880,06006155,06000272,06000273
// native-strings: 
// ============================================================

public static bool SendPlayerStates_Prefix(SDG.Unturned.PlayerManager __instance)
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 61 call(s):
    //   0x28d973094a0  9AB67761792440A7::00FC653ED33A4A96()
    //   0x28d973094d0  40FE7AC3F69F4B10::10270708481F445D(0x28d03164140)
    //   0x28d973094f8  C7A753824C0746AE::ADAA9521257F4886(0x28d0323f680)
    //   0x28d97309520  ALLOC_OBJECT(0x28d96e55008)
    //   0x28d97309558  WBARRIER((ALLOC_OBJECT(0x28d96e55008) add 0x20), ALLOC_OBJECT(0x28d96e55008))
    //   0x28d973095c8  KeyValuePair`2::Deconstruct((? add 0xffffffffffffff20), (? add 0xffffffffffffff30), (? add 0xffffffffffffff08), ?)
    //   0x28d97309608  Time::get_realtimeSinceStartup((? add 0xffffffffffffff20), (? add 0xffffffffffffff30), (? add 0xffffffffffffff08), ?)
    //   0x28d97309650  ALLOC_OBJECT(0x28d96e55198)
    //   0x28d97309668  02834BF6F9CE4817::.ctor(ALLOC_OBJECT(0x28d96e55198), (? add 0xffffffffffffff30), (? add 0xffffffffffffff08), ?)
    //   0x28d97309688  Time::get_realtimeSinceStartup(ALLOC_OBJECT(0x28d96e55198), (? add 0xffffffffffffff30), (? add 0xffffffffffffff08), ?)
    //   0x28d973096b8  PlayerTool::getPlayer((movsxd (rax xor rax)), (? add 0xffffffffffffff30), (? add 0xffffffffffffff08), ?)
    //   0x28d973096d0  9AB67761792440A7::00FC653ED33A4A96((movsxd (rax xor rax)), (? add 0xffffffffffffff30), (? add 0xffffffffffffff08), ?)
    //   0x28d97309730  ALLOC_OBJECT(0x28d96e55318)
    //   0x28d97309758  sub_28b82780dcb((ALLOC_OBJECT(0x28d96e55318) add 0x20), 9AB67761792440A7::00FC653ED33A4A96((movsxd (rax xor rax)), (? add 0xffffffffffffff30), (? add 0xffffffffffffff08), ?), (? add 0xffffffffffffff08), ?)
    //   0x28d973097b0  Player::sendScreenshot(PlayerTool::getPlayer((movsxd (rax xor rax)), (? add 0xffffffffffffff30), (? add 0xffffffffffffff08), ?), (movsxd 0x28cc7d686f8.f0), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d973097e4  sub_28d9730980d(ALLOC_OBJECT(0x28d96e55008), (movsxd 0x28cc7d686f8.f0), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309808  sub_28b82785f1f(ALLOC_OBJECT(0x28d96e55008), (movsxd 0x28cc7d686f8.f0), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309868  GetEnumerator(0x28cc768cb50.f0, (? add 0xffffffffffffff38), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309890  SteamPlayer::get_player((rax xor rax), (? add 0xffffffffffffff38), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d973098a8  Object::op_Equality(SteamPlayer::get_player((rax xor rax), (? add 0xffffffffffffff38), ALLOC_OBJECT(0x28d96e55318), ?), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d973098c8  SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d973098d8  A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ((? add 0xffffffffffffff38) xor (? add 0xfffffffffff
    //   0x28d97309908  88BB72CD49B54743::4E762C6DC349455E(A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ((? add 0xfffffff
    //   0x28d97309948  SteamPlayer::get_player((rax xor rax), 9AB67761792440A7::00FC653ED33A4A96(), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309968  PlayerLook::get_canUseFreecam(SteamPlayer::get_player((rax xor rax), 9AB67761792440A7::00FC653ED33A4A96(), ALLOC_OBJECT(0x28d96e55318), ?).f88, 9AB67761792440A7::00FC653ED33A4A96(), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309988  SteamPlayer::get_player((rax xor rax), 9AB67761792440A7::00FC653ED33A4A96(), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d973099b0  PlayerLook::sendFreecamAllowed(SteamPlayer::get_player((rax xor rax), 9AB67761792440A7::00FC653ED33A4A96(), ALLOC_OBJECT(0x28d96e55318), ?).f88, (9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A9
    //   0x28d973099c8  SteamPlayer::get_player((rax xor rax), (9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96()), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d973099e8  PlayerLook::get_canUseSpecStats(SteamPlayer::get_player((rax xor rax), (9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96()), ALLOC_OBJECT(0x28d96e55318), ?).f88, (9AB67761792440A7::00FC653ED33A
    //   0x28d97309a08  SteamPlayer::get_player((rax xor rax), (9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96()), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309a30  PlayerLook::sendSpecStatsAllowed(SteamPlayer::get_player((rax xor rax), (9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96()), ALLOC_OBJECT(0x28d96e55318), ?).f88, ((9AB67761792440A7::00FC653ED3
    //   0x28d97309a58  MoveNext((? add 0xffffffffffffff38), ((9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96()) xor (9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96())), ALLOC_OBJECT(0x2
    //   0x28d97309a72  sub_28d97309a9d((? add 0xffffffffffffff38), ((9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96()) xor (9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96())), ALLOC_OBJ
    //   0x28d97309a98  sub_28b82785f1f((? add 0xffffffffffffff38), ((9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96()) xor (9AB67761792440A7::00FC653ED33A4A96() xor 9AB67761792440A7::00FC653ED33A4A96())), ALLOC_OBJ
    //   0x28d97309ae8  GetEnumerator(0x28cc768cb50.f0, (? add 0xffffffffffffff38), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309b10  SteamPlayer::get_player((rax xor rax), (? add 0xffffffffffffff38), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309b28  Object::op_Equality(SteamPlayer::get_player((rax xor rax), (? add 0xffffffffffffff38), ALLOC_OBJECT(0x28d96e55318), ?), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309b48  SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309b80  SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309bd0  SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309bf8  CD12FBF2EC134DF5::F05B22B752C743A2(0x28ccac5cd80, SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309c10  SteamPlayer::get_player((rax xor rax), SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309c48  List`1::GetEnumerator(SteamPlayer::get_player((rax xor rax), SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ALLOC_OBJECT(0x28d96e55318
    //   0x28d97309cd0  Enumerator::MoveNext((? add 0xffffffffffffff50), (? add 0xffffffffffffff50), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309cea  sub_28d97309d15((? add 0xffffffffffffff50), (? add 0xffffffffffffff50), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309d10  sub_28b82785f1f((? add 0xffffffffffffff50), (? add 0xffffffffffffff50), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309d50  MoveNext((? add 0xffffffffffffff38), (? add 0xffffffffffffff50), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309d6a  sub_28d97309d95((? add 0xffffffffffffff38), (? add 0xffffffffffffff50), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309d90  sub_28b82785f1f((? add 0xffffffffffffff38), (? add 0xffffffffffffff50), ALLOC_OBJECT(0x28d96e55318), ?)
    //   0x28d97309e20  Array::Clear(0x28c840e8408.f0.f10, ((? add 0xffffffffffffff50) xor (? add 0xffffffffffffff50)), (movsxd (movsxd 0x28c840e8408.f0.f18)), ?)
    //   0x28d97309e38  FindObjectsOfType(0x28c840e8408.f0.f10, ((? add 0xffffffffffffff50) xor (? add 0xffffffffffffff50)), (movsxd (movsxd 0x28c840e8408.f0.f18)), ?)
    //   0x28d97309ea8  Component::GetComponentsInChildren(FindObjectsOfType(0x28c840e8408.f0.f10, ((? add 0xffffffffffffff50) xor (? add 0xffffffffffffff50)), (movsxd (movsxd 0x28c840e8408.f0.f18)), ?)+(movsxd (rbx xor rbx))*8+20.f0, 0x1, (mov
    //   0x28d97309ec8  List`1::AddRange(0x28c840e8408.f0, Component::GetComponentsInChildren(FindObjectsOfType(0x28c840e8408.f0.f10, ((? add 0xffffffffffffff50) xor (? add 0xffffffffffffff50)), (movsxd (movsxd 0x28c840e8408.f0.f18)), ?)+(movsx
    //   0x28d97309ef8  FindObjectsOfType(FindObjectsOfType(0x28c840e8408.f0.f10, ((? add 0xffffffffffffff50) xor (? add 0xffffffffffffff50)), (movsxd (movsxd 0x28c840e8408.f0.f18)), ?), Component::GetComponentsInChildren(FindObjectsOfType(0x28
    //   0x28d97309f68  Component::GetComponentsInChildren(FindObjectsOfType(FindObjectsOfType(0x28c840e8408.f0.f10, ((? add 0xffffffffffffff50) xor (? add 0xffffffffffffff50)), (movsxd (movsxd 0x28c840e8408.f0.f18)), ?), Component::GetComponen
    //   0x28d97309f88  List`1::AddRange(0x28c840e8408.f0, Component::GetComponentsInChildren(FindObjectsOfType(FindObjectsOfType(0x28c840e8408.f0.f10, ((? add 0xffffffffffffff50) xor (? add 0xffffffffffffff50)), (movsxd (movsxd 0x28c840e8408.f
    //   0x28d97309ff8  40FE7AC3F69F4B10::F27B18C1D6E54F89(0x28d03164140)
    //   0x28d9730a020  40FE7AC3F69F4B10::7FA5DD9F1F7146C9(0x28d03164140, 40FE7AC3F69F4B10::F27B18C1D6E54F89(0x28d03164140))
    //   0x28d9730a048  THROW(0x146, 0x12e)
    //   0x28d9730a068  THROW(0x162, 0x3e4)
    //   0x28d9730a088  THROW(0xf3, 0x978)
    // 18 store(s):
    //   0x28d9730952d  ALLOC_OBJECT(0x28d96e55008) <- 0x0
    //   0x28d97309549  (ALLOC_OBJECT(0x28d96e55008) add 0x20) <- C7A753824C0746AE::ADAA9521257F4886(0x28d0323f680)
    //   0x28d9730969e  (rax xor rax) <- ((movsxd (rax xor rax).f18) inc 0x1)
    //   0x28d973096e4  ALLOC_OBJECT(0x28d96e55198) <- 9AB67761792440A7::00FC653ED33A4A96((movsxd (rax xor rax)), (? add 0xffffffffffffff30), (? add 0xffffffffffffff08), ?)
    //   0x28d9730973f  ALLOC_OBJECT(0x28d96e55318) <- ALLOC_OBJECT(0x28d96e55198)
    //   0x28d9730976c  ALLOC_OBJECT(0x28d96e55318) <- 0x28d96b9d180
    //   0x28d9730977a  ALLOC_OBJECT(0x28d96e55318) <- 0x28d96e553e0
    //   0x28d9730978c  ALLOC_OBJECT(0x28d96e55318) <- 0x28d96e553e8.f28
    //   0x28d97309794  ALLOC_OBJECT(0x28d96e55318) <- 0x28d96e553e8.f20
    //   0x28d97309798  ALLOC_OBJECT(0x28d96e55318) <- 0x0
    //   0x28d9730992f  A3116505AAB24996::69C6AFA769194D6F(SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?) <- 9AB67761792440A7::00FC653ED33A4A96()
    //   0x28d97309c99  CD12FBF2EC134DF5::F05B22B752C743A2(0x28ccac5cd80, SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ALLOC_OBJECT(0x28d96e55318), ?)+20 <- (movsxd (movsxd ((? add 0xffffffffffffff50) add 0x10).f0))
    //   0x28d97309ca2  CD12FBF2EC134DF5::F05B22B752C743A2(0x28ccac5cd80, SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ALLOC_OBJECT(0x28d96e55318), ?)+20 <- (movsxd (movsxd ((? add 0xffffffffffffff50) add 0x10).f4))
    //   0x28d97309cac  CD12FBF2EC134DF5::F05B22B752C743A2(0x28ccac5cd80, SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ALLOC_OBJECT(0x28d96e55318), ?)+20 <- (movsxd (movsxd ((? add 0xffffffffffffff50) add 0x10).f8))
    //   0x28d97309cb6  CD12FBF2EC134DF5::F05B22B752C743A2(0x28ccac5cd80, SteamPlayer::get_player((rax xor rax), ((? add 0xffffffffffffff38) xor (? add 0xffffffffffffff38)), ALLOC_OBJECT(0x28d96e55318), ?), ALLOC_OBJECT(0x28d96e55318), ?)+20 <- (movsxd (movsxd ((? add 0xffffffffffffff50) add 0x10).fc))
    //   0x28d97309dd1  0x28c840e8418 <- 0x1
    //   0x28d97309ded  0x28c840e8408.f0 <- ((movsxd 0x28c840e8408.f0.f1c) inc 0x1)
    //   0x28d97309dfa  0x28c840e8408.f0 <- 0x0
    // returns: (movsxd FindObjectsOfType(FindObjectsOfType(0x28c840e8408.f0.f10, ((? add 0xffffffffffffff50) xor (? add 0xffffffffffffff50)), (movsxd (movsxd 0x28c840e8408.f0.f18)), ?), Component::GetComponentsInChi
}
