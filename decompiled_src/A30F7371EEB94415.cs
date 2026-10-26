using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HarmonyLib;
using SDG.Unturned;
using UnityEngine;

internal class A30F7371EEB94415
{
	public delegate void _2649B8F8F4A94C6C(bool D82CCA92AA484B24, ERaycastInfoUsage E460E73C86C54C5D, PlayerInput _654782747FDC4149, ref InputInfo? _355685C0A85E4BA2);

	public delegate void E2EA6C8214674B80(Player EB93F6518A6E4442);

	[Serializable]
	[CompilerGenerated]
	private sealed class F101D9517BE2483D
	{
		public static readonly F101D9517BE2483D _003C_003E9 = new F101D9517BE2483D();

		public static Func<CodeInstruction, bool> _003C_003E9__11_4;

		public static Func<CodeInstruction, bool> _003C_003E9__11_5;

		public static Func<CodeInstruction, bool> _003C_003E9__11_7;

		public static Func<CodeInstruction, bool> _003C_003E9__11_8;

		public static Func<CodeInstruction, bool> _003C_003E9__11_9;

		public static Func<(int At, bool MoveLabels, CodeInstruction[] Code), int> _003C_003E9__11_10;

		internal bool _003CFixedUpdate_Transpiler_003Eb__11_4(CodeInstruction _95BC75A76BAF43B0)
		{
			return false;
		}

		internal bool _003CFixedUpdate_Transpiler_003Eb__11_5(CodeInstruction _3D9D29EEBC164318)
		{
			throw new Exception();
		}

		internal bool _003CFixedUpdate_Transpiler_003Eb__11_7(CodeInstruction _16FCE213890F45AC)
		{
			throw new Exception();
		}

		internal bool _003CFixedUpdate_Transpiler_003Eb__11_8(CodeInstruction _2BCA1838A7424FD5)
		{
			return false;
		}

		internal bool _003CFixedUpdate_Transpiler_003Eb__11_9(CodeInstruction B670D24B42F24B83)
		{
			return false;
		}

		internal int _003CFixedUpdate_Transpiler_003Eb__11_10((int At, bool MoveLabels, CodeInstruction[] Code) _29753070FA8340B4)
		{
			return _29753070FA8340B4.At;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct EE4415A3944348F7
	{
		public List<CodeInstruction> codes;

		public List<string> missing;

		public List<(int At, bool MoveLabels, CodeInstruction[] Code)> edits;

		public int store;
	}

	private static readonly FieldRef<PlayerInput, Queue<PlayerInputPacket>> _712B532B55954762;

	private static readonly FieldRef<PlayerInput, bool> _7918534CF8DE4504;

	private static readonly FieldRef<PlayerInput, uint> _430BAA20DF944935;

	public static _2649B8F8F4A94C6C? _8878F056D7F640C6;

	public static E2EA6C8214674B80? _3B2526A411C740E5;

	[_542A381FC1D44BA3(typeof(PlayerInput), "getInput", _24AD03718EF64384._21C2F47B5D9744BD, new Type[]
	{
		typeof(bool),
		typeof(ERaycastInfoUsage)
	})]
	public static void _356DFE08B0AE4D7C(PlayerInput __instance, bool doOcclusionCheck, ERaycastInfoUsage usage, ref InputInfo? __result)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		_8878F056D7F640C6?.Invoke(doOcclusionCheck, usage, __instance, ref __result);
	}

	[_542A381FC1D44BA3(typeof(PlayerInput), "FixedUpdate", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool D5838616C7674F66(PlayerInput __instance)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (_7918534CF8DE4504.Invoke(__instance))
		{
			return true;
		}
		CD12FBF2EC134DF5._02D6D2763D074C45 obj = F0CD1E00058640DE.playerTracking.F05B22B752C743A2(((PlayerCaller)__instance).player);
		obj._6626673394694F24.CECE6312F32C491C(((PlayerCaller)__instance).player, obj._12878EC8DCE341EE.D63E5FFE5E6249E2, obj._3FE17818BFA04239);
		obj._12878EC8DCE341EE._08588F9CCF7147D9();
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)__instance).player);
		if (a3116505AAB == null)
		{
			return true;
		}
		if (a3116505AAB.A19A123B68EB4A44._59C1BE92AFE94F18 > 2)
		{
			a3116505AAB.A19A123B68EB4A44.DAC55D584AC44841 = _9AB67761792440A7._00FC653ED33A4A96();
		}
		if (a3116505AAB.A19A123B68EB4A44._59C1BE92AFE94F18 > 1)
		{
			if (a3116505AAB.A19A123B68EB4A44._5F54FD9721024C28(2000L))
			{
				a3116505AAB.A19A123B68EB4A44._512D236D21D24D16 = _9AB67761792440A7._00FC653ED33A4A96();
			}
			a3116505AAB.A19A123B68EB4A44._5544D59F11E04B78 = _9AB67761792440A7._00FC653ED33A4A96();
		}
		a3116505AAB.A19A123B68EB4A44._59C1BE92AFE94F18 = 0;
		return true;
	}

	[_542A381FC1D44BA3(typeof(PlayerInput), "ReceiveInputs", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _2D8EEF731ADC4C48(PlayerInput __instance)
	{
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)__instance).player);
		if (a3116505AAB != null)
		{
			_712B532B55954762.Invoke(__instance);
			a3116505AAB.A19A123B68EB4A44.DFCCDD6FEFB04381 = _712B532B55954762.Invoke(__instance).Count;
			a3116505AAB.A19A123B68EB4A44._5682BEACE9C7411F = _430BAA20DF944935.Invoke(__instance);
		}
	}

	[_542A381FC1D44BA3(typeof(PlayerInput), "ReceiveInputs", _24AD03718EF64384._21C2F47B5D9744BD)]
	public static void F46C5BB60E2845C1(PlayerInput __instance)
	{
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)__instance).player);
		if (a3116505AAB != null)
		{
			if (_712B532B55954762.Invoke(__instance).Count > a3116505AAB.A19A123B68EB4A44.DFCCDD6FEFB04381)
			{
				a3116505AAB.A19A123B68EB4A44.DAB0DD940A6642E1();
				a3116505AAB.A19A123B68EB4A44._59C1BE92AFE94F18 = a3116505AAB.A19A123B68EB4A44._78463DEA761F48CF.F912CB261E164317 - 1;
			}
			uint num = a3116505AAB.A19A123B68EB4A44._5682BEACE9C7411F;
			if (num != uint.MaxValue && _430BAA20DF944935.Invoke(__instance) > num + 1)
			{
				a3116505AAB._7F3836A6EEFC4FC4++;
			}
		}
	}

	[_542A381FC1D44BA3(typeof(PlayerInput), "FixedUpdate", _24AD03718EF64384._810C4D09A1164BC3)]
	public static IEnumerable<CodeInstruction> _23C2FAC539F6483B(IEnumerable<CodeInstruction> instructions)
	{
		GC.KeepAlive(null);
		return null;
	}

	public static void E504ECB3C66148CC(PlayerInput _35AA726509504A25)
	{
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)_35AA726509504A25).player);
		if (a3116505AAB != null)
		{
			a3116505AAB._76477626BCDE4550.DAB71A667E20425F = null;
			a3116505AAB._55A04A73D4B1454E = false;
		}
	}

	public static void DB2C7A7FEA8946E0(PlayerInput _7A03218238984C92)
	{
		_3B2526A411C740E5?.Invoke(((PlayerCaller)_7A03218238984C92).player);
	}

	public static void _61AEC9C3614E4DAE(PlayerInput _2D3ED38C7E824CA4, WalkingPlayerInputPacket _908503473D604BC5)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)_2D3ED38C7E824CA4).player);
		if (a3116505AAB != null)
		{
			_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?._10270708481F445D();
			a3116505AAB._76477626BCDE4550._0A55EDE023B44259 = ((PlayerCaller)_2D3ED38C7E824CA4).player.look.aim.localPosition;
			a3116505AAB._76477626BCDE4550._722C1E3EDF244863 = Vector3.Distance(a3116505AAB._76477626BCDE4550._13C2E84001FA4667, a3116505AAB._76477626BCDE4550._0A55EDE023B44259) > 0.05f;
			a3116505AAB._76477626BCDE4550._13C2E84001FA4667 = a3116505AAB._76477626BCDE4550._0A55EDE023B44259;
			a3116505AAB._76477626BCDE4550._18447759A2394EC9 = a3116505AAB._76477626BCDE4550._7ED3CB3A6B244A09(((PlayerCaller)_2D3ED38C7E824CA4).player);
			a3116505AAB._76477626BCDE4550.DAB71A667E20425F = new B3E800F7DAAE405D._8B7C6A7C18684FA8
			{
				AE0F78E8DD484598 = _908503473D604BC5.clientPosition,
				_8B47B2B22D864C7B = _908503473D604BC5.clientPosition + a3116505AAB._76477626BCDE4550._0A55EDE023B44259
			};
			Vector3 val = a3116505AAB._76477626BCDE4550.D6A0D62EDEA74C2C(((PlayerCaller)_2D3ED38C7E824CA4).player, _908503473D604BC5.clientPosition);
			a3116505AAB._76477626BCDE4550._8EBCE734A07644E8 = new B3E800F7DAAE405D._8B7C6A7C18684FA8
			{
				AE0F78E8DD484598 = val,
				_8B47B2B22D864C7B = val + a3116505AAB._76477626BCDE4550._0A55EDE023B44259
			};
			B3E800F7DAAE405D._8B7C6A7C18684FA8 obj = a3116505AAB._76477626BCDE4550._7ED3CB3A6B244A09(((PlayerCaller)_2D3ED38C7E824CA4).player);
			B3E800F7DAAE405D._8B7C6A7C18684FA8 obj2 = a3116505AAB._76477626BCDE4550._519D3BF95CBF4676(((PlayerCaller)_2D3ED38C7E824CA4).player);
			a3116505AAB._76477626BCDE4550.A8AD496AF10A4C77(obj2);
			a3116505AAB._76477626BCDE4550._42DF72C175E845A9 = obj._8B47B2B22D864C7B - obj2._8B47B2B22D864C7B;
			_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?.F471762FF8094F2B(_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F.F27B18C1D6E54F89());
		}
	}

	public static void _539D9A90EEA84064(PlayerInput C69C74ABACFE4C48, WalkingPlayerInputPacket CC16BA03C0C34685)
	{
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)C69C74ABACFE4C48).player);
		if (a3116505AAB != null)
		{
			a3116505AAB.D54F3E2F2CEB4FCF = _9AB67761792440A7._00FC653ED33A4A96();
			a3116505AAB._55A04A73D4B1454E = true;
		}
	}

	static A30F7371EEB94415()
	{
		E651E17AA2CA4BC8._113C547E3E7142C1.EEE742FC0CF449C0.C2AF6DB5067D4E07((string)null);
		E651E17AA2CA4BC8._113C547E3E7142C1.EEE742FC0CF449C0.C2AF6DB5067D4E07((string)null);
		E651E17AA2CA4BC8._113C547E3E7142C1.EEE742FC0CF449C0.C2AF6DB5067D4E07((string)null);
	}

	[CompilerGenerated]
	internal static int AE910687FF9741D9(int from, Func<CodeInstruction, bool> match, ref EE4415A3944348F7 P_2)
	{
		return 0;
	}

	[CompilerGenerated]
	internal static void _9F129C4220FF4F40(int at, bool moveLabels, string anchor, params CodeInstruction[] code, ref EE4415A3944348F7 P_4)
	{
		throw new Exception();
	}

	[CompilerGenerated]
	internal static bool BE26B69C1917471A(CodeInstruction c, OpCode op, string n)
	{
		throw new Exception();
	}

	[CompilerGenerated]
	internal static CodeInstruction _76DC6F8B678D43D6(string m)
	{
		E651E17AA2CA4BC8._18821157D5754512((object)null);
		_6487285FB41C4853._36CB4EE3CC6C48CE.C01D94B9EF1A4342((object)null);
		return null;
	}

	[CompilerGenerated]
	internal static CodeInstruction _476021DB46E44E95(ref EE4415A3944348F7 P_0)
	{
		_6487285FB41C4853._36CB4EE3CC6C48CE.C01D94B9EF1A4342((object)null);
		return null;
	}
}
