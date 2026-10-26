using System;
using HarmonyLib;
using SDG.Unturned;
using UnityEngine;

internal class BB9CAD1F8D524E16
{
	public delegate void _1987AE3037464979(UseableBarricade _99E209A302C9427B, Vector3 C170D6BFAFA4489D, float _0992D07C18E04A03, float A3BACA6ADAA44C6F, float _851731554E7840DC, ref bool D2DC09B06FC34DB7);

	private static readonly Func<UseableBarricade, bool> _8735259D37784D63;

	private static readonly FieldRef<UseableBarricade, bool> _81ECA3CEFB49445C;

	private static readonly FieldRef<UseableBarricade, Transform?> _16A7819F23604116;

	private static readonly FieldRef<UseableBarricade, InteractableVehicle?> CD90C910493846B8;

	private static readonly FieldRef<UseableBarricade, Vector3> _670F6BD8A40744A7;

	private static readonly FieldRef<UseableBarricade, float> _0D7AA13A065F45BE;

	private static readonly FieldRef<UseableBarricade, float> D901C6CBA8B641DD;

	private static readonly FieldRef<UseableBarricade, float> _937E001EC0EC40B8;

	private static readonly FieldRef<UseableBarricade, float> _720873E20CF34442;

	private static readonly FieldRef<UseableBarricade, float> _6064046352374B38;

	private static readonly FieldRef<UseableBarricade, float> _88F3E998A1274A39;

	private static readonly FieldRef<UseableBarricade, bool> AE236A3E83374CC3;

	public static _1987AE3037464979? ECEC72A0B80D41EA;

	[_542A381FC1D44BA3(typeof(UseableBarricade), "ReceiveBarricadeNone", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _0B040A63082345C0(UseableBarricade __instance, in ServerInvocationContext context, Vector3 newPoint, float newAngle_X, float newAngle_Y, float newAngle_Z)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		if (_81ECA3CEFB49445C.Invoke(__instance))
		{
			return false;
		}
		bool D2DC09B06FC34DB = true;
		ECEC72A0B80D41EA?.Invoke(__instance, newPoint, newAngle_X, newAngle_Y, newAngle_Z, ref D2DC09B06FC34DB);
		if (!D2DC09B06FC34DB)
		{
			_81ECA3CEFB49445C.Invoke(__instance) = true;
			_16A7819F23604116.Invoke(__instance) = null;
			CD90C910493846B8.Invoke(__instance) = null;
			_670F6BD8A40744A7.Invoke(__instance) = newPoint;
			if (_8735259D37784D63(__instance))
			{
				_0D7AA13A065F45BE.Invoke(__instance) = newAngle_X;
				D901C6CBA8B641DD.Invoke(__instance) = newAngle_Z;
			}
			else
			{
				_0D7AA13A065F45BE.Invoke(__instance) = 0f;
				D901C6CBA8B641DD.Invoke(__instance) = 0f;
			}
			_937E001EC0EC40B8.Invoke(__instance) = newAngle_Y;
			_720873E20CF34442.Invoke(__instance) = 0f;
			_6064046352374B38.Invoke(__instance) = 0f;
			_88F3E998A1274A39.Invoke(__instance) = 0f;
			AE236A3E83374CC3.Invoke(__instance) = false;
			return false;
		}
		return true;
	}

	static BB9CAD1F8D524E16()
	{
		E651E17AA2CA4BC8._4CEFA97A389F4CA1((object)null);
		CD90C910493846B8 = null;
		D901C6CBA8B641DD = null;
		AE236A3E83374CC3 = null;
		ECEC72A0B80D41EA = null;
	}
}
