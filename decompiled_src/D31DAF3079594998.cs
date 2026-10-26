using SDG.Unturned;
using UnityEngine;

internal class D31DAF3079594998
{
	private static bool _3A4B129701414126;

	[_542A381FC1D44BA3(typeof(Player), "teleportToLocationUnsafe", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void ED72E8BE83A84DE3()
	{
		_3A4B129701414126 = true;
	}

	[_542A381FC1D44BA3(typeof(Player), "teleportToLocationUnsafe", _24AD03718EF64384._21C2F47B5D9744BD)]
	public static void A9EE3F6041184108()
	{
		_3A4B129701414126 = false;
	}

	[_542A381FC1D44BA3(typeof(Player), "ReceiveTeleport", _24AD03718EF64384._21C2F47B5D9744BD)]
	public static void C90059F3687E4225(Player __instance)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (_3A4B129701414126 && !__instance.movement.canAddSimulationResultsToUpdates)
		{
			_3A4B129701414126 = false;
			return;
		}
		_3A4B129701414126 = false;
		CD12FBF2EC134DF5._02D6D2763D074C45 obj = F0CD1E00058640DE.playerTracking.F05B22B752C743A2(__instance);
		obj._3FE17818BFA04239 = new PlayerStateUpdate(((Component)__instance).transform.position, __instance.look.angle, __instance.look.rot);
		obj._6626673394694F24.EEFD181D01164D49();
		obj._6626673394694F24.CECE6312F32C491C(__instance, obj._12878EC8DCE341EE.D63E5FFE5E6249E2, obj._3FE17818BFA04239);
	}
}
