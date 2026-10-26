using System;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

internal class BE3140E5E8934376 : _760EF57D5259421C
{
	private static readonly C4462CD02B8C4225 EA079C54825F41EE;

	private static bool _2711EF3F606B461A;

	private static bool _82057913BAF24128;

	public virtual void _5809A23B8CB5419E()
	{
		uint num = 1u;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1u:
				break;
			case 2u:
				BB782E479FC44A40();
				return;
			}
			num = 2u;
		}
	}

	public virtual void _16F2FEAE8BDA41AB()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		A30F7371EEB94415._8878F056D7F640C6 = (A30F7371EEB94415._2649B8F8F4A94C6C)_93CEC935F5D443C6((Delegate)A30F7371EEB94415._8878F056D7F640C6, (Delegate)new A30F7371EEB94415._2649B8F8F4A94C6C(_32EE4F7522024978));
		_61E6738AC2A84A84((EnterVehicleRequestHandler)_177A384168B348B9);
		_07CB9578DDEE4425();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _70BDA8CE0B774170()
	{
		GC.KeepAlive(null);
	}

	private void _177A384168B348B9(Player P_0, InteractableVehicle P_1, ref bool P_2)
	{
		A3116505AAB24996 a3116505AAB = (A3116505AAB24996)_7B531A04DDA840E5(P_0);
		if (a3116505AAB == null)
		{
			goto IL_000d;
		}
		goto IL_010c;
		IL_000d:
		int num = -484674055;
		goto IL_0012;
		IL_0012:
		int num2 = num;
		uint num3;
		switch ((num3 = (uint)(~(((num2 - -(-unchecked(~1733963938 * 839101059) - unchecked(250441208 * 165706871) + -(122940094 + unchecked(1964376031 * ~1686477947)) - (unchecked((~unchecked(-442266143 - 1942022946) + ((0x4923EA06 ^ 0x6D625F0C) - -813288905)) * 2084245399) + ((-(0x13D619AF ^ -880878923) - (-780169249 ^ 0x61F2E750)) ^ 0x151F8148))) + -(-1509714940 + 661596133)) * 1153242467 * 1251722325 - (~unchecked(1030006735 + 1999387459) - unchecked(979919603 * (-1870652650 - -1816736737))) - 1331117805) * -1051446467))) % 4)
		{
		case 0u:
			break;
		default:
			return;
		case 3u:
			return;
		case 1u:
			goto IL_010c;
		case 2u:
			return;
		}
		goto IL_000d;
		IL_010c:
		a3116505AAB._410DB7863006432C = _00F181D4F1FC44A0();
		num = -1329356008;
		goto IL_0012;
	}

	private void _32EE4F7522024978(bool P_0, ERaycastInfoUsage P_1, PlayerInput P_2, ref InputInfo? P_3)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Invalid comparison between Unknown and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Invalid comparison between Unknown and I4
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Invalid comparison between Unknown and I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected Obj, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Invalid comparison between Unknown and I4
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Invalid comparison between Unknown and I4
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected Obj, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Invalid comparison between Unknown and I4
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		if (P_3 == null || (Object)(object)P_3.transform == (Object)null || !_2711EF3F606B461A || ((int)P_1 != 0 && (int)P_1 != 2))
		{
			return;
		}
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)P_2).player);
		if (a3116505AAB == null || a3116505AAB.A98460F771B0446B(_760EF57D5259421C._8DC4187752784460, _760EF57D5259421C._1D28939F0C774697, ((PlayerCaller)P_2).player.channel.owner.playerID.steamID))
		{
			return;
		}
		ItemAsset asset = ((PlayerCaller)P_2).player.equipment.asset;
		if ((int)P_1 == 2 && !(asset is ItemMeleeAsset))
		{
			return;
		}
		bool flag = a3116505AAB._9D9DA155E15B401B != 0L && _9AB67761792440A7._00FC653ED33A4A96() < a3116505AAB._9D9DA155E15B401B;
		bool flag2 = (Object)(object)((PlayerCaller)P_2).player.movement.getVehicle() != (Object)null || a3116505AAB._0F638DE7CA844A28(A3116505AAB24996._7B165DBD1B874D50);
		bool flag3 = (Object)(object)P_3.player != (Object)null || (Object)(object)P_3.animal != (Object)null || (Object)(object)P_3.zombie != (Object)null;
		bool flag4 = ((int)P_3.type == 2 || (int)P_3.type == 8 || (int)P_3.type == 9) | flag3;
		bool flag5 = flag3 && _9AB67761792440A7._079E8C19685F4DD4(P_3);
		float num = (((int)P_1 == 0) ? 1.75f : ((ItemWeaponAsset)(ItemMeleeAsset)asset).range);
		B3E800F7DAAE405D._8B7C6A7C18684FA8 obj = a3116505AAB._76477626BCDE4550._7ED3CB3A6B244A09(((PlayerCaller)P_2).player);
		float magnitude = a3116505AAB._76477626BCDE4550._42DF72C175E845A9.magnitude;
		float num2 = Vector3.Distance(P_3.point, obj._8B47B2B22D864C7B);
		EPlayerStance[] array = B3E800F7DAAE405D._45BD767F01AF43B2;
		foreach (EPlayerStance val in array)
		{
			num2 = Mathf.Min(num2, Vector3.Distance(P_3.point, obj.AE0F78E8DD484598 + new Vector3(0f, B3E800F7DAAE405D.CA4505681FD0490E(val), 0f)));
		}
		float num3 = num;
		num3 += magnitude / 2f;
		num3 += 0.25f;
		string text = D50039A66BE7492E(a3116505AAB, ((PlayerCaller)P_2).player, P_3, flag4);
		(string, EFlagLevel)? tuple = null;
		if ((Object)(object)P_3.player != (Object)null && (Object)(object)P_3.player == (Object)(object)((PlayerCaller)P_2).player)
		{
			tuple = ("type: A", EFlagLevel.Critical);
		}
		else if (_9AB67761792440A7.B8383F2716824CB2(P_3.type, P_3.limb))
		{
			tuple = ("type: B", EFlagLevel.Critical);
		}
		else if (_9AB67761792440A7._9849D016EBC24F95(flag4, P_3))
		{
			tuple = ("type: C", EFlagLevel.Critical);
		}
		else if (flag4 && Vector3.Dot(P_3.direction, P_3.normal) > 0f)
		{
			tuple = ("type: D", EFlagLevel.Critical);
		}
		else if (num2 > num3 && !flag2)
		{
			tuple = ($"type: E (d: {num2})", (!(num2 > num3 + 0.5f)) ? EFlagLevel.Minimal : EFlagLevel.Medium);
		}
		else if (text != null && !flag2)
		{
			tuple = ("type: F", EFlagLevel.Shadow);
		}
		else if (flag4 && EABEB9D8011B4B9B(a3116505AAB, ((PlayerCaller)P_2).player, P_3) && !flag2)
		{
			tuple = ("type: G", EFlagLevel.Minimal);
		}
		else if (flag3)
		{
			if ((Object)(object)P_3.player != (Object)null)
			{
				if (!a3116505AAB._8E872EA320404135(P_3.player, P_3.point))
				{
					tuple = ("type: Z", EFlagLevel.Shadow);
				}
				if (F0CD1E00058640DE.playerTracking.D8C5D4CF897D418B(a3116505AAB, P_3.player) && !F0CD1E00058640DE.playerTracking.F05B22B752C743A2(P_3.player)._6626673394694F24._635085B12CF4471D(P_3.limb, P_3.point))
				{
					B15E2605ED474C2A b15E2605ED474C2A = EA079C54825F41EE._3ECE4ABFF9E04BFF<B15E2605ED474C2A>();
					F0CD1E00058640DE.playerTracking.F05B22B752C743A2(P_3.player)._6626673394694F24._4C62EF0AE3694F6E(b15E2605ED474C2A, ((PlayerCaller)P_2).player, P_3.player, P_3.limb, P_3.point);
					EA079C54825F41EE.CB4E939A3F83474C("Missed Point V6", b15E2605ED474C2A);
				}
			}
			if (!tuple.HasValue && (flag5 & flag))
			{
				tuple = ("type: T", EFlagLevel.Shadow);
			}
		}
		else if ((Object)(object)P_3.vehicle != (Object)null && !a3116505AAB._6C1BA5297F7F4446(P_3.vehicle, P_3.point))
		{
			tuple = ("type: Z", EFlagLevel.Shadow);
		}
		else if ((int)P_3.type == 8 || (int)P_3.type == 7)
		{
			float num4 = _9AB67761792440A7.AFDAF7F618374BA0(P_3.transform, P_3.point, RayMasks.DAMAGE_CLIENT);
			if (num4 > 0.03f)
			{
				tuple = ($"type: Z (d: {num4} t: {((Object)P_3.transform).name})", EFlagLevel.Shadow);
			}
		}
		if (tuple.HasValue)
		{
			_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(((PlayerCaller)P_2).player.channel.owner.playerID, ECheckCategory.Raycast, ECheckType.Basic, tuple.Value.Item2, tuple.Value.Item1 + (a3116505AAB._1C517C8A588A47C1 ? " (lean)" : "") + " | target: " + _9AB67761792440A7._9D3DAA5834DD4DA6(P_3));
			if (_82057913BAF24128 && tuple.Value.Item2 != EFlagLevel.Warning)
			{
				if ((int)P_1 == 2)
				{
					_22F8E66F55C24C0E._11480E0414B04058(((PlayerCaller)P_2).player, P_3, (ItemMeleeAsset)asset);
				}
				else
				{
					_22F8E66F55C24C0E.D9CA88F07183479D(((PlayerCaller)P_2).player, P_3);
				}
				P_3 = null;
			}
			if (flag || tuple.Value.Item2 == EFlagLevel.Critical)
			{
				a3116505AAB._9D9DA155E15B401B = _9AB67761792440A7._00FC653ED33A4A96() + 10000;
			}
		}
		else if (_82057913BAF24128 & flag)
		{
			if ((int)P_1 == 2)
			{
				_22F8E66F55C24C0E._11480E0414B04058(((PlayerCaller)P_2).player, P_3, (ItemMeleeAsset)asset);
			}
			else
			{
				_22F8E66F55C24C0E.D9CA88F07183479D(((PlayerCaller)P_2).player, P_3);
			}
			P_3 = null;
		}
	}

	private bool EABEB9D8011B4B9B(A3116505AAB24996 P_0, Player P_1, InputInfo P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		float num = Vector3.Angle(P_0.DE38BE1DA5014794 * Vector3.forward, P_2.direction);
		float num2 = 1f;
		if (P_0._1C517C8A588A47C1)
		{
			float num3 = Vector3.Angle(P_0._92A513FF7BCD47D5 * Quaternion.Euler(0f, 0f, HumanAnimator.LEAN) * P_0.F1E0B3F113944108 * Vector3.forward, P_0.DE38BE1DA5014794 * Vector3.forward);
			float num4 = Vector3.Angle(P_0._92A513FF7BCD47D5 * Quaternion.Euler(0f, 0f, 0f - HumanAnimator.LEAN) * P_0.F1E0B3F113944108 * Vector3.forward, P_0.DE38BE1DA5014794 * Vector3.forward);
			float num5 = Mathf.Max(num3, num4);
			num2 += num5;
		}
		return num > num2;
	}

	private string? D50039A66BE7492E(A3116505AAB24996 P_0, Player P_1, InputInfo P_2, bool P_3)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		B3E800F7DAAE405D._8B7C6A7C18684FA8 obj = P_0._76477626BCDE4550._7ED3CB3A6B244A09(P_1);
		Vector3 val = (P_3 ? P_2.direction : P_1.look.aim.forward);
		float num = Vector3.Distance(P_2.point, obj._8B47B2B22D864C7B);
		using (global::A807FD2A83C845A2<B3E800F7DAAE405D._8B7C6A7C18684FA8>._0A72B7172F03473E obj2 = P_0._76477626BCDE4550._5C521683885F483B._22761929FC6F47F7())
		{
			while (obj2.MoveNext())
			{
				B3E800F7DAAE405D._8B7C6A7C18684FA8 current = obj2.Current;
				num = Mathf.Min(num, Vector3.Distance(P_2.point, current._8B47B2B22D864C7B));
			}
		}
		if (num < 0.1f)
		{
			return null;
		}
		Vector3 val2 = P_2.point - obj._8B47B2B22D864C7B;
		Vector3 normalized = val2.normalized;
		float num2 = Vector3.Angle(normalized, val);
		float num3 = 0f;
		using (global::A807FD2A83C845A2<B3E800F7DAAE405D._8B7C6A7C18684FA8>._0A72B7172F03473E obj2 = P_0._76477626BCDE4550._5C521683885F483B._22761929FC6F47F7())
		{
			while (obj2.MoveNext())
			{
				B3E800F7DAAE405D._8B7C6A7C18684FA8 current2 = obj2.Current;
				val2 = P_2.point - current2._8B47B2B22D864C7B;
				Vector3 normalized2 = val2.normalized;
				num3 = Mathf.Max(num3, Vector3.Angle(normalized, normalized2));
			}
		}
		float num4 = (P_3 ? 3f : 5f);
		float num5 = num3 + num4;
		if (P_0._1C517C8A588A47C1)
		{
			if (num < 1f)
			{
				return null;
			}
			num5 += 40f / num;
		}
		if (!(num2 > num5))
		{
			return null;
		}
		return $"a: {num2} m: {num3} c: {Mathf.Min(new float[1] { num2 - num5 })}";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static BE3140E5E8934376()
	{
		GC.KeepAlive(null);
	}

	static object A4E09B54247E4955(Delegate P_0, Delegate P_1)
	{
		return Delegate.Combine(P_0, P_1);
	}

	static void FFA7D0C836974FE8(EnterVehicleRequestHandler P_0)
	{
		VehicleManager.onEnterVehicleRequested += P_0;
	}

	void BB782E479FC44A40()
	{
		base.A599C828530B4E69();
	}

	static object _93CEC935F5D443C6(Delegate P_0, Delegate P_1)
	{
		return Delegate.Remove(P_0, P_1);
	}

	static void _61E6738AC2A84A84(EnterVehicleRequestHandler P_0)
	{
		VehicleManager.onEnterVehicleRequested -= P_0;
	}

	void _07CB9578DDEE4425()
	{
		base.C4CA2ECFAD654E77();
	}

	static object _7B531A04DDA840E5(Player P_0)
	{
		return A3116505AAB24996._69C6AFA769194D6F(P_0);
	}

	static long _00F181D4F1FC44A0()
	{
		return _9AB67761792440A7._00FC653ED33A4A96();
	}
}
