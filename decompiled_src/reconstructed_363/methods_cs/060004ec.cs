// ============================================================
// token 0x060004ec   8BAADFBB2FC94256::.cctor
// native code: 0x28d958666e0  (323 bytes)
// kind: SMALL_CALL   confidence: behavior
// original IL signature:
//   .method private hidebysig specialname rtspecialname static
//   void .cctor () cil managed
//   
// native-calls: 
// native-strings: ?:Rocket.Unturned.Player.UnturnedPlayer:FromCSteamID,?:Rocket.API.IRocketPlayerExtension:HasPermission,?:Rocket.Unturned.Player.UnturnedPlayer:IsAdmin,?:2804822892160,?:2804822892032,?:2804822717648
// ============================================================

static void .cctor()
{
    // Behavior-level reconstruction (native address order).
    // This method is part of the obfuscated/hot startup path; the exact IL
    // is replaced by the recovered call sequence and string references.
    // 6 call(s):
    //   0x28d95866708  Method(0x28d0c78de80, (xor ?), (xor ?), ?)   ; "Rocket.Unturned.Player.UnturnedPlayer:FromCSteamID"
    //   0x28d95866738  WBARRIER(0x28d0351ce60, (xor ?))
    //   0x28d95866758  Method(0x28d0c78de00, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)), ?)   ; "Rocket.API.IRocketPlayerExtension:HasPermission"
    //   0x28d95866788  WBARRIER(0x28d0351ce68, ((xor ?) xor (xor ?)))
    //   0x28d958667a8  Property(0x28d0c7634d0, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)), ?)   ; "Rocket.Unturned.Player.UnturnedPlayer:IsAdmin"
    //   0x28d958667d8  sub_28b82780dcb(0x28d0351ce70, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)), ?)
    // 3 store(s):
    //   0x28d95866718  0x28d0351ce60 <- Method(0x28d0c78de80, (xor ?), (xor ?), ?)
    //   0x28d95866768  0x28d0351ce68 <- Method(0x28d0c78de00, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)), ?)
    //   0x28d958667b8  0x28d0351ce70 <- Property(0x28d0c7634d0, ((xor ?) xor (xor ?)), ((xor ?) xor (xor ?)), ?)
    // returns: 0x28d0351ce70
    // string table refs:
    //   literal  "Rocket.Unturned.Player.UnturnedPlayer:FromCSteamID"
    //   literal  "Rocket.API.IRocketPlayerExtension:HasPermission"
    //   literal  "Rocket.Unturned.Player.UnturnedPlayer:IsAdmin"
    //   literal  "2804822892160"
    //   literal  "2804822892032"
    //   literal  "2804822717648"
}
