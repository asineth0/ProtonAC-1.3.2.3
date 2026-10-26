using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HarmonyLib;
using SDG.Unturned;
using UnityEngine;

internal class _269EE5A44F844EAA : _760EF57D5259421C
{
	private static readonly C4462CD02B8C4225 FB6EFF734D384EB7;

	private static readonly FieldRef<UseableGun, float> B3736D6D98394C5F = null;

	private static readonly FieldRef<UseableGun, float> _6DFD5BE90E804D9F;

	private static bool _2ADDE021C9214B68;

	private static bool E0122F2C21684EAF = false;

	public virtual void _79AE08AF7B3B4851()
	{
		_38520E4A341440A0._62AB564E7133417D obj = null;
		D5FA3B7F2185424D((Delegate)null, (Delegate)obj);
		A76A63943FD04779.F268403FFFB4461D f268403FFFB4461D = null;
		D5FA3B7F2185424D((Delegate)null, (Delegate)f268403FFFB4461D);
		A76A63943FD04779._133C560B942C4748 obj2 = null;
		D5FA3B7F2185424D((Delegate)null, (Delegate)obj2);
		B3736D6D98394C5F = null;
		throw new Exception();
	}

	public virtual void B13B0B5188AE4876()
	{
		_38520E4A341440A0._385B0E3DCD904102 = (_38520E4A341440A0._62AB564E7133417D)CC79445DB19144DA((Delegate)_38520E4A341440A0._385B0E3DCD904102, (Delegate)new _38520E4A341440A0._62AB564E7133417D(_4D10ABAFED774F7F));
		while (true)
		{
			int num = -931317537;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-(~(-(num2 * 578256831) ^ ((-2061961279 ^ (-1029379847 * --1677215205)) + unchecked(-2080762741 * unchecked(~-1279038576 + (0x3D26C6CE ^ 0x6A9D4F3))) + (-1667006745 - unchecked(~unchecked(-1416577114 * -1400299725) + 1819700301))))) * -506736681) ^ 0x2FC1036A ^ 0x38556394)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_00b0;
				default:
					A76A63943FD04779._89D43889C2AB4B27 = (A76A63943FD04779._133C560B942C4748)CC79445DB19144DA((Delegate)A76A63943FD04779._89D43889C2AB4B27, (Delegate)new A76A63943FD04779._133C560B942C4748(_5D756E6411224D7F));
					BB9EEA263CEA4530();
					return;
				}
				break;
				IL_00b0:
				A76A63943FD04779._55A676AE7D2646A4 = (A76A63943FD04779.F268403FFFB4461D)CC79445DB19144DA((Delegate)A76A63943FD04779._55A676AE7D2646A4, (Delegate)new A76A63943FD04779.F268403FFFB4461D(_4DB5292EA68E4CC1));
				num = ((int)num3 * -1806193802) ^ -2144172085;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void EC142F04063848BB()
	{
		GC.KeepAlive(null);
	}

	private void _5D756E6411224D7F(A3116505AAB24996 P_0, UseableGun P_1, List<_4819911A0C0846FF._3147FDB5568446E9> P_2, InputInfo P_3, ref bool P_4, ref bool P_5)
	{
		if (!_2ADDE021C9214B68)
		{
			return;
		}
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item in P_2)
		{
			if (item.B0169C33A3674C0D)
			{
				P_0._1D67FF3A771947F1.A88639D29F0644DC = false;
				P_0._1D67FF3A771947F1.E9E287D7AA8B45D6 = true;
			}
		}
		bool flag = P_0._67938E92F30243BF != 0L && BEAA7676CE82484E() < P_0._67938E92F30243BF;
		if (E0122F2C21684EAF & flag)
		{
			if (P_4)
			{
				P_5 = true;
			}
			P_4 = false;
		}
	}

	private void _4DB5292EA68E4CC1(UseableGun P_0)
	{
		if (_09D86A692A0C45B0((Object)_469412B0EB554053((object)P_0), (Object)null) || !_2ADDE021C9214B68)
		{
			return;
		}
		A3116505AAB24996 a3116505AAB = (A3116505AAB24996)_0C7044C301554405((Player)_469412B0EB554053((object)P_0));
		if (a3116505AAB == null)
		{
			return;
		}
		a3116505AAB.CFA8D5E44E2A4880 = new _63009F37A59A432B._87AA5908A6EF41DD
		{
			_1649BA3AC8EE497F = Mathf.Abs(((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recover_x),
			_6D5F05EB5E914328 = Mathf.Abs(((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recover_y),
			_4A7D0792B5FA4CD9 = _601C83DD16124D13(P_0, B5D48C33CA6A46A4.F70D1D4EC1494AB8),
			_1F27592A92314C22 = _601C83DD16124D13(P_0, B5D48C33CA6A46A4.D2CD817685D64AB9),
			_9EAB8F9EC80340D7 = _601C83DD16124D13(P_0, B5D48C33CA6A46A4._1A30BBE4F3564857),
			_8D09E60C866E478D = _601C83DD16124D13(P_0, B5D48C33CA6A46A4._3CCDC7C17B8241E2)
		};
		if (!a3116505AAB.C4DA765AFB124762)
		{
			float num = B3736D6D98394C5F.Invoke(P_0);
			float num2 = _6DFD5BE90E804D9F.Invoke(P_0);
			float num3 = 1f;
			if (((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).unplace > 1f)
			{
				num3 = ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).unplace;
			}
			if (((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).replace > 1f)
			{
				num3 = ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).replace;
			}
			float num4 = num2 * num3;
			if ((num == 0f || num == float.MaxValue || !(_44F5AB0AC60F4E47() - num < num4 + 2.5f)) && !EDF7D4E1EE48450E((object)a3116505AAB.A19A123B68EB4A44, 500L))
			{
				a3116505AAB._1D67FF3A771947F1._5BA663D57CF14D25.Enqueue(new _63009F37A59A432B.E5183ED753B44C3E
				{
					_7D286E36BB364C67 = a3116505AAB.CFA8D5E44E2A4880,
					D2C147AA03E64D93 = a3116505AAB._0E84A52D8B85441F - a3116505AAB.F08C7614E1E24E42,
					CBB4E4B76C744D6E = a3116505AAB._68911883297A44E0 - a3116505AAB.A104D9F0D982448E,
					_9F2AF281376242EC = C1BCCD0315D045A3(P_0)
				});
			}
		}
	}

	private void _4D10ABAFED774F7F(A3116505AAB24996 P_0, Player P_1, float P_2, float P_3, float P_4)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.A98460F771B0446B(_760EF57D5259421C._8DC4187752784460, _760EF57D5259421C._1D28939F0C774697, P_1.channel.owner.playerID.steamID))
		{
			return;
		}
		if (P_0._443482020698440D != 0L && _9AB67761792440A7._00FC653ED33A4A96() - P_0._443482020698440D <= A3116505AAB24996.A77D61B4B0FD460D)
		{
			P_0._1D67FF3A771947F1._5BA663D57CF14D25.Clear();
			return;
		}
		while (P_0._1D67FF3A771947F1._5BA663D57CF14D25.Count > 0)
		{
			_63009F37A59A432B.E5183ED753B44C3E e5183ED753B44C3E = P_0._1D67FF3A771947F1._5BA663D57CF14D25.Dequeue();
			bool flag = P_1.movement.getVehicleSeat() != null && P_1.movement.getVehicleSeat().turret != null;
			float num = Mathf.Abs(P_0._0E84A52D8B85441F - P_0.F08C7614E1E24E42);
			float num2 = Mathf.Abs(e5183ED753B44C3E.D2C147AA03E64D93);
			float num3 = 0.15f + (num + num2) * 2f;
			float num4 = Mathf.Max(0f, e5183ED753B44C3E._7D286E36BB364C67._4A7D0792B5FA4CD9 - e5183ED753B44C3E._7D286E36BB364C67._4A7D0792B5FA4CD9 * e5183ED753B44C3E._7D286E36BB364C67._1649BA3AC8EE497F);
			bool flag2 = num3 <= Mathf.Min(num4, 2f);
			bool flag3 = (num4 > 0.1f) & flag2;
			float num5 = Mathf.Abs(P_0._68911883297A44E0 - P_0.A104D9F0D982448E);
			float num6 = Mathf.Abs(e5183ED753B44C3E.CBB4E4B76C744D6E);
			float num7 = 0.15f + (num5 + num6) * 2f;
			float num8 = Mathf.Max(0f, e5183ED753B44C3E._7D286E36BB364C67._9EAB8F9EC80340D7 - e5183ED753B44C3E._7D286E36BB364C67._9EAB8F9EC80340D7 * e5183ED753B44C3E._7D286E36BB364C67._6D5F05EB5E914328);
			bool flag4 = num7 <= Mathf.Min(num8, 2f);
			float num9 = Mathf.Min(e5183ED753B44C3E._7D286E36BB364C67._9EAB8F9EC80340D7, 2f);
			bool flag5 = ((num8 > 0.1f) & flag4) && !_9AB67761792440A7._47C3AA91C6B94D1E(P_0.A104D9F0D982448E, num9) && !_9AB67761792440A7._47C3AA91C6B94D1E(P_0._68911883297A44E0, num9);
			if ((flag3 | flag5) && !flag)
			{
				if (!P_0._1D67FF3A771947F1.E9E287D7AA8B45D6)
				{
					P_0._1D67FF3A771947F1.A88639D29F0644DC = true;
				}
				else if (P_0._1D67FF3A771947F1._28A64CB389FD497D._8853594054184234() > 1f)
				{
					P_0._1D67FF3A771947F1.E9E287D7AA8B45D6 = false;
					P_0._1D67FF3A771947F1.A88639D29F0644DC = true;
					if (flag3)
					{
						_8A0E98A514AA4628 obj = FB6EFF734D384EB7._3ECE4ABFF9E04BFF<_8A0E98A514AA4628>();
						obj.BC28ECD2965D413B = P_1.channel.owner.playerID.steamID.m_SteamID;
						obj.D0FF01D9007D4422 = num;
						obj._6F647DDB92E74EF3 = num4;
						obj.C07C9F48E9A444AA = e5183ED753B44C3E._7D286E36BB364C67._1649BA3AC8EE497F;
						obj.C3310413FDCB46C4 = num3;
						obj._56FADCBF399B4DF4 = e5183ED753B44C3E._9F2AF281376242EC;
						FB6EFF734D384EB7.CB4E939A3F83474C("NoRecoil H", obj);
					}
					if (flag5)
					{
						_75251EF256F04F76 obj2 = FB6EFF734D384EB7._3ECE4ABFF9E04BFF<_75251EF256F04F76>();
						obj2._1D2D97A416D24E27 = P_1.channel.owner.playerID.steamID.m_SteamID;
						obj2.B59318A50E294BB0 = num5;
						obj2._9E6235403496476B = num8;
						obj2._62A16EBF2AE544E8 = e5183ED753B44C3E._7D286E36BB364C67._6D5F05EB5E914328;
						obj2.F1CAC262C76343FF = num7;
						obj2._50D8C4E4DF414220 = P_0._68911883297A44E0;
						obj2._91F837A34219416F = e5183ED753B44C3E._9F2AF281376242EC;
						FB6EFF734D384EB7.CB4E939A3F83474C("NoRecoil V", obj2);
					}
					_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(P_1.channel.owner.playerID, ECheckCategory.Analysis, ECheckType.NoRecoil, EFlagLevel.Minimal, "t: " + (flag3 ? "h" : "") + (flag5 ? "v" : "") + " " + e5183ED753B44C3E._9F2AF281376242EC);
					if (E0122F2C21684EAF && P_0._1D67FF3A771947F1._28A64CB389FD497D._75C7C80D8F654C06 > 3f)
					{
						P_0._67938E92F30243BF = _9AB67761792440A7._00FC653ED33A4A96() + 10000;
					}
				}
			}
			else
			{
				P_0._1D67FF3A771947F1._28A64CB389FD497D._19F5F779612A4A8C(0.5f);
			}
		}
	}

	private static float _601C83DD16124D13(UseableGun P_0, B5D48C33CA6A46A4 P_1)
	{
		bool flag = P_1 == B5D48C33CA6A46A4.F70D1D4EC1494AB8 || P_1 == B5D48C33CA6A46A4.D2CD817685D64AB9;
		float num = (float)(int)CA16604326C54F3E(_665F0B698BEF452C(_469412B0EB554053((object)P_0))) / 100f;
		Attachments val = _64A4BBC5E4CE4EE1._74705AAE3534468A.Invoke(P_0);
		bool flag2 = _64A4BBC5E4CE4EE1.E8CFFE96D48E4806(P_0);
		float num2 = _761EFE18846448C4(P_1, flag ? ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recoilMin_x : ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recoilMin_y, flag ? ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recoilMax_x : ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recoilMax_y);
		num2 *= ((num < 0.5f) ? (1f + (1f - num * 2f)) : 1f);
		num2 *= _7650B5232BAC4BFB(F82365B076CB41CD(_469412B0EB554053((object)P_0)));
		num2 = _761EFE18846448C4(P_1, num2, num2 * ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).aimingRecoilMultiplier);
		if (_7E997E626921495B((object)val) != null)
		{
			num2 = _761EFE18846448C4(P_1, num2, num2 * ((ItemCaliberAsset)_7E997E626921495B((object)val)).aimingRecoilMultiplier);
			num2 *= (flag ? _7FB66083A37F4396(_7E997E626921495B((object)val)) : ACB35AD8CD86482F(_7E997E626921495B((object)val)));
		}
		if ((_0F6F523423704760((object)val) != null) & flag2)
		{
			num2 = _761EFE18846448C4(P_1, num2, num2 * ((ItemCaliberAsset)_0F6F523423704760((object)val)).aimingRecoilMultiplier);
			num2 *= (flag ? _7FB66083A37F4396(_0F6F523423704760((object)val)) : ACB35AD8CD86482F(_0F6F523423704760((object)val)));
		}
		if (_33B573E9632041BC((object)val) != null)
		{
			float num3 = num2;
			num3 = _761EFE18846448C4(P_1, num3, num3 * ((ItemCaliberAsset)_33B573E9632041BC((object)val)).aimingRecoilMultiplier);
			num3 *= (flag ? _7FB66083A37F4396(_33B573E9632041BC((object)val)) : ACB35AD8CD86482F(_33B573E9632041BC((object)val)));
			num2 = (BC1902FE1A5E4587(_33B573E9632041BC((object)val)) ? _761EFE18846448C4(P_1, num2, num3) : num3);
		}
		if (_93C191023BCA440E((object)val) != null)
		{
			num2 = _761EFE18846448C4(P_1, num2, num2 * ((ItemCaliberAsset)_93C191023BCA440E((object)val)).aimingRecoilMultiplier);
			num2 *= (flag ? _7FB66083A37F4396(_93C191023BCA440E((object)val)) : ACB35AD8CD86482F(_93C191023BCA440E((object)val)));
		}
		if (C5577390C0C946A2((object)val) != null)
		{
			num2 = _761EFE18846448C4(P_1, num2, num2 * ((ItemCaliberAsset)C5577390C0C946A2((object)val)).aimingRecoilMultiplier);
			num2 *= (flag ? _7FB66083A37F4396(C5577390C0C946A2((object)val)) : ACB35AD8CD86482F(C5577390C0C946A2((object)val)));
		}
		float num4 = 1f;
		num4 = _761EFE18846448C4(P_1, num4, ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recoilSprint);
		num4 = _761EFE18846448C4(P_1, num4, ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recoilCrouch);
		num4 = _761EFE18846448C4(P_1, num4, ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recoilProne);
		num4 = _761EFE18846448C4(P_1, num4, ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recoilSwimming);
		num4 = _761EFE18846448C4(P_1, num4, ((ItemGunAsset)_4F3BB5719C124DE0((object)P_0)).recoilMidair);
		num2 *= num4;
		float firstPerson_RecoilMultiplier = ((ModeConfigData)_5509FC2DEB4D4CD7()).Gameplay.FirstPerson_RecoilMultiplier;
		firstPerson_RecoilMultiplier = _761EFE18846448C4(P_1, firstPerson_RecoilMultiplier, firstPerson_RecoilMultiplier * ((ModeConfigData)_5509FC2DEB4D4CD7()).Gameplay.FirstPerson_AimingRecoilMultiplier);
		float num5 = 1f;
		Attachments val2 = _64A4BBC5E4CE4EE1._3D8DA4D4ADA34DEA.Invoke(P_0);
		if (_1BAF5CD2E77A4BAB((Object)(object)val2, (Object)null) && _7E997E626921495B((object)val2) != null && _1BAF5CD2E77A4BAB((Object)E3A5FE3ED5E14BD9((object)val2), (Object)null))
		{
			num5 = _1D5D4DA1000744CB(_7E997E626921495B((object)val2));
		}
		if (num5 > 1.0001f)
		{
			float num6 = 1f / num5;
			float num7 = Mathf.Lerp(1f, num6, ((ModeConfigData)_5509FC2DEB4D4CD7()).Gameplay.FirstPerson_AimingZoomRecoilReduction);
			firstPerson_RecoilMultiplier *= _761EFE18846448C4(P_1, 1f, num7);
		}
		num2 *= (_8B99A598590443B8() ? _761EFE18846448C4(P_1, firstPerson_RecoilMultiplier, ((ModeConfigData)_5509FC2DEB4D4CD7()).Gameplay.ThirdPerson_RecoilMultiplier) : firstPerson_RecoilMultiplier);
		return Mathf.Abs(num2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float _061B5453F0784467(B5D48C33CA6A46A4 P_0, float P_1, float P_2)
	{
		if (P_0 != B5D48C33CA6A46A4.F70D1D4EC1494AB8)
		{
			while (true)
			{
				int num = -805224808;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((num2 + ~(-1436377073 * (-903318121 * -unchecked(345010353 * 1711992948) - 782238294)) - unchecked(unchecked(unchecked(-1968663391 * (unchecked((-1594917711 ^ 0x625964F5) - 1264883319) - unchecked(unchecked(-1806916498 + -398362438) * 439894537))) * 229777655) - 1500135789)) * -157142187)) % 4)
					{
					case 0u:
						break;
					case 3u:
						goto IL_0084;
					case 2u:
						goto end_IL_0006;
					default:
						return Mathf.Max(P_1, P_2);
					}
					break;
					IL_0084:
					int num4;
					if (P_0 == (B5D48C33CA6A46A4)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668))
					{
						num = 78615391;
						num4 = num;
					}
					else
					{
						num = -483339662;
						num4 = num;
					}
				}
				continue;
				end_IL_0006:
				break;
			}
		}
		return Mathf.Min(P_1, P_2);
	}

	private string C1BCCD0315D045A3(UseableGun P_0)
	{
		Attachments val = _64A4BBC5E4CE4EE1._74705AAE3534468A.Invoke(P_0);
		List<string> list = new List<string>();
		if (_7E997E626921495B((object)val) != null)
		{
			list.Add(_0977BB968A794330("s: {0}", (object)((Asset)_7E997E626921495B((object)val)).id));
		}
		if (_0F6F523423704760((object)val) != null)
		{
			list.Add(_0977BB968A794330("t: {0}", (object)((Asset)_0F6F523423704760((object)val)).id));
		}
		if (_33B573E9632041BC((object)val) != null)
		{
			list.Add(_0977BB968A794330("g: {0}", (object)((Asset)_33B573E9632041BC((object)val)).id));
		}
		if (_93C191023BCA440E((object)val) != null)
		{
			list.Add(_0977BB968A794330("b: {0}", (object)((Asset)_93C191023BCA440E((object)val)).id));
		}
		if (C5577390C0C946A2((object)val) != null)
		{
			list.Add(_0977BB968A794330("m: {0}", (object)((Asset)C5577390C0C946A2((object)val)).id));
		}
		return _851990B07F28480B("i: {0} [{1}]", (object)((Asset)_4F3BB5719C124DE0((object)P_0)).id, (object)string.Join(' ', list));
	}

	static object D5FA3B7F2185424D(Delegate P_0, Delegate P_1)
	{
		return Delegate.Combine(P_0, P_1);
	}

	void _5DE3E225028C49D9()
	{
		base.A599C828530B4E69();
	}

	static object CC79445DB19144DA(Delegate P_0, Delegate P_1)
	{
		return Delegate.Remove(P_0, P_1);
	}

	void BB9EEA263CEA4530()
	{
		base.C4CA2ECFAD654E77();
	}

	static long BEAA7676CE82484E()
	{
		return _9AB67761792440A7._00FC653ED33A4A96();
	}

	static object _469412B0EB554053(object P_0)
	{
		return ((PlayerCaller)P_0).player;
	}

	static bool _09D86A692A0C45B0(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static object _0C7044C301554405(Player P_0)
	{
		return A3116505AAB24996._69C6AFA769194D6F(P_0);
	}

	static object _4F3BB5719C124DE0(object P_0)
	{
		return ((UseableGun)P_0).equippedGunAsset;
	}

	static float _44F5AB0AC60F4E47()
	{
		return Time.realtimeSinceStartup;
	}

	static bool EDF7D4E1EE48450E(object P_0, long P_1)
	{
		return ((_6E7C0DC30F544C9E)P_0).D02F123715D044B3(P_1);
	}

	static object _665F0B698BEF452C(object P_0)
	{
		return ((Player)P_0).equipment;
	}

	static byte CA16604326C54F3E(object P_0)
	{
		return ((PlayerEquipment)P_0).quality;
	}

	static float _761EFE18846448C4(B5D48C33CA6A46A4 P_0, float P_1, float P_2)
	{
		return _061B5453F0784467(P_0, P_1, P_2);
	}

	static object F82365B076CB41CD(object P_0)
	{
		return ((Player)P_0).skills;
	}

	static float _7650B5232BAC4BFB(object P_0)
	{
		return ((PlayerSkills)P_0).GetSharpshooterRecoilMultiplier();
	}

	static object _7E997E626921495B(object P_0)
	{
		return ((Attachments)P_0).sightAsset;
	}

	static float ACB35AD8CD86482F(object P_0)
	{
		return ((ItemCaliberAsset)P_0).recoil_y;
	}

	static float _7FB66083A37F4396(object P_0)
	{
		return ((ItemCaliberAsset)P_0).recoil_x;
	}

	static object _0F6F523423704760(object P_0)
	{
		return ((Attachments)P_0).tacticalAsset;
	}

	static object _33B573E9632041BC(object P_0)
	{
		return ((Attachments)P_0).gripAsset;
	}

	static bool BC1902FE1A5E4587(object P_0)
	{
		return ((ItemCaliberAsset)P_0).ShouldOnlyAffectAimWhileProne;
	}

	static object _93C191023BCA440E(object P_0)
	{
		return ((Attachments)P_0).barrelAsset;
	}

	static object C5577390C0C946A2(object P_0)
	{
		return ((Attachments)P_0).magazineAsset;
	}

	static object _5509FC2DEB4D4CD7()
	{
		return Provider.modeConfigData;
	}

	static bool _1BAF5CD2E77A4BAB(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static object E3A5FE3ED5E14BD9(object P_0)
	{
		return ((Attachments)P_0).scopeHook;
	}

	static float _1D5D4DA1000744CB(object P_0)
	{
		return ((ItemSightAsset)P_0).zoom;
	}

	static bool _8B99A598590443B8()
	{
		return _9AB67761792440A7._7B6477147E0F42D8;
	}

	static string _0977BB968A794330(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _851990B07F28480B(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}
}
