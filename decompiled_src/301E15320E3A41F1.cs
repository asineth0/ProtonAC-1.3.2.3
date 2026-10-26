using System.Collections.Generic;
using HarmonyLib;
using SDG.Unturned;

internal class _301E15320E3A41F1
{
	[_542A381FC1D44BA3(typeof(PlayerAnimator), "onLifeUpdated", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _35A3518690984BFB(PlayerAnimator __instance)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		F0CD1E00058640DE.playerTracking.F05B22B752C743A2(((PlayerCaller)__instance).player)._12878EC8DCE341EE.D63E5FFE5E6249E2 = (EPlayerGesture)0;
	}

	[_542A381FC1D44BA3(typeof(PlayerEquipment), "ReceiveEquip", _24AD03718EF64384._810C4D09A1164BC3)]
	public static IEnumerable<CodeInstruction> _09B5393A83114339(IEnumerable<CodeInstruction> instructions)
	{
		E651E17AA2CA4BC8._18821157D5754512((object)null);
		E651E17AA2CA4BC8._18821157D5754512((object)null);
		_6487285FB41C4853._36CB4EE3CC6C48CE.C01D94B9EF1A4342((object)null);
		_6487285FB41C4853._36CB4EE3CC6C48CE.C01D94B9EF1A4342((object)null);
		return null;
	}

	public static void _448A3958B7B5464C(PlayerEquipment F0687C1CCD0E426F)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		F0CD1E00058640DE.playerTracking.F05B22B752C743A2(((PlayerCaller)F0687C1CCD0E426F).player)._12878EC8DCE341EE.D63E5FFE5E6249E2 = (EPlayerGesture)0;
	}
}
