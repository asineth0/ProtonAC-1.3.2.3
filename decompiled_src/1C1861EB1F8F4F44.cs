using HarmonyLib;
using SDG.Unturned;
using UnityEngine;

internal class _1C1861EB1F8F4F44
{
	private static readonly FieldRef<PlayerAnimator, bool> _5630723FD6064A00 = AccessTools.FieldRefAccess<PlayerAnimator, bool>("leanObstructed");

	[_542A381FC1D44BA3(typeof(PlayerLook), "updateAim", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _3585E4B35A9A4BA7(PlayerLook __instance)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)__instance).player);
		if (a3116505AAB == null)
		{
			return true;
		}
		_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?._10270708481F445D();
		_1DB744298E9F4B09._052FBC588F454484._4FCE5BF09DEA4F4D?._10270708481F445D();
		_ = a3116505AAB._6427DD414B754955;
		a3116505AAB.B2803D8C670749DB = a3116505AAB._6427DD414B754955;
		a3116505AAB._0DA16FC0A0F84A2C = __instance.aim.position - a3116505AAB._6427DD414B754955;
		a3116505AAB._6427DD414B754955 = __instance.aim.position;
		bool flag = ((PlayerCaller)__instance).player.animator.lean != 0 || _5630723FD6064A00.Invoke(((PlayerCaller)__instance).player.animator);
		int num = (flag ? 1 : 0);
		a3116505AAB._2D4F008C6CD24E06 = Mathf.Lerp(a3116505AAB._2D4F008C6CD24E06, (float)num * HumanAnimator.LEAN, 4f * PlayerInput.RATE);
		a3116505AAB._1C517C8A588A47C1 = flag || a3116505AAB._2D4F008C6CD24E06 > 0.05f;
		_1DB744298E9F4B09._052FBC588F454484._4FCE5BF09DEA4F4D?.F471762FF8094F2B(_1DB744298E9F4B09._052FBC588F454484._4FCE5BF09DEA4F4D.F27B18C1D6E54F89());
		_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?.F471762FF8094F2B(_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F.F27B18C1D6E54F89());
		return true;
	}
}
