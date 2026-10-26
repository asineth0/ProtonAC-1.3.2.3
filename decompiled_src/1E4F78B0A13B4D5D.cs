using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using SDG.Unturned;
using Steamworks;

internal class _1E4F78B0A13B4D5D : _760EF57D5259421C
{
	private static bool _68A50FE342A94A07;

	private static bool EC04363AA5684C14;

	public virtual void _0755DF65C6134580()
	{
		throw new Exception();
	}

	public virtual void _708E04A438B04B2C()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected Obj, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected Obj, but got Unknown
		_8690CCDD61614AF2((SalvageRequestHandler)E5DD76B65F364EC4);
		_10C0FF01D58D4F26((SalvageRequestHandler)E5DD76B65F364EC4);
		_174A8844B6E844E7();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _93D20B0F76EF401E()
	{
		GC.KeepAlive(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void E5DD76B65F364EC4(object P_0, SteamPlayer P_1, ref bool P_2)
	{
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		Player val = (Player)_317EEACB68574F25((object)P_1);
		float num10 = default;
		A3116505AAB24996 a3116505AAB = default;
		float num4 = default;
		StructureDrop val3 = default;
		long num12 = default;
		BarricadeDrop val2 = default;
		while (true)
		{
			int num = 1784714014;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(unchecked(-442100799 * 159668174) + --539668443 - ((~(~num2) * -42969991) ^ 0x2468DD41 ^ -(-(--819796129))))) % 20)
				{
				case 0u:
					break;
				case 13u:
				{
					num10 = _7C2A1856045B4E11(a3116505AAB, val, num4) * _003CModule_003E._3F57E81A62734AC2<float>(373381015);
					int num11;
					if (a3116505AAB.C607DEBFA72A49CE == 0L)
					{
						num = 1350724312;
						num11 = num;
					}
					else
					{
						num = 1976176559;
						num11 = num;
					}
					continue;
				}
				case 4u:
					num4 = _184778EB5E0D4D35(_28900F8BC40A4ADB((object)val3));
					num = ((int)num3 * -1108723109) ^ -1645282524;
					continue;
				case 17u:
					num = (int)(num3 * 1949189241) ^ -281653551;
					continue;
				case 15u:
				{
					int num16;
					int num17;
					if (val3 == null)
					{
						num16 = 1874334329;
						num17 = num16;
					}
					else
					{
						num16 = -155494468;
						num17 = num16;
					}
					num = num16 ^ ((int)num3 * -1489106373);
					continue;
				}
				case 12u:
					return;
				case 6u:
					val3 = (StructureDrop)((P_0 is StructureDrop) ? P_0 : null);
					num = 1914438926;
					continue;
				case 8u:
				{
					_83D2494797314BB9((object)_760EF57D5259421C.E7E669564ABD4ED3, CAAC0954952341C5((object)((SteamChannel)_291A9867C64D46A6((object)val)).owner), (ECheckCategory)_003CModule_003E._390073C602714496<int>(975705554), (ECheckType)_003CModule_003E._8B9C7B12B1AE4949<int>(170655810), (EFlagLevel)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042), _70B2858454C94BCC(_003CModule_003E._8B9C7B12B1AE4949<string>(-272316164), (object)num12, (object)num10));
					int num19;
					if (!EC04363AA5684C14)
					{
						num = 1350724312;
						num19 = num;
					}
					else
					{
						num = 155558218;
						num19 = num;
					}
					continue;
				}
				case 2u:
				{
					int num15;
					if (A9B94785CBA74D26((object)a3116505AAB, (object)_760EF57D5259421C._8DC4187752784460, (object)_760EF57D5259421C._1D28939F0C774697, C6EC343BA5F4469D(CAAC0954952341C5((object)((SteamChannel)_291A9867C64D46A6((object)val)).owner))))
					{
						num = -866457435;
						num15 = num;
					}
					else
					{
						num = 1319796724;
						num15 = num;
					}
					continue;
				}
				case 16u:
					return;
				case 3u:
					num12 = _1CC7C690A66C42EE() - a3116505AAB.C607DEBFA72A49CE;
					num = 30175002;
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (_68A50FE342A94A07)
					{
						num6 = -1295223921;
						num7 = num6;
					}
					else
					{
						num6 = -1619219374;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -686031342);
					continue;
				}
				case 18u:
					num4 = BD192A03C4F04292(_7F553D98F9DB44BE((object)val2));
					num = ((int)num3 * -1946686517) ^ 0xD20C8CE;
					continue;
				case 1u:
				{
					int num18;
					if (a3116505AAB._256883125048413A)
					{
						num = -1180634413;
						num18 = num;
					}
					else
					{
						num = 1117597470;
						num18 = num;
					}
					continue;
				}
				case 14u:
					return;
				case 10u:
				{
					int num13;
					int num14;
					if ((float)num12 < num10)
					{
						num13 = 159085430;
						num14 = num13;
					}
					else
					{
						num13 = -1515556830;
						num14 = num13;
					}
					num = num13 ^ (int)(num3 * 999285365);
					continue;
				}
				case 11u:
				{
					a3116505AAB = (A3116505AAB24996)_3C4C584828044D25(val);
					int num8;
					int num9;
					if (a3116505AAB == null)
					{
						num8 = 216071129;
						num9 = num8;
					}
					else
					{
						num8 = -1251189089;
						num9 = num8;
					}
					num = num8 ^ (int)(num3 * 1726129288);
					continue;
				}
				case 19u:
				{
					num4 = _003CModule_003E._58ECCB512F2A43AC<float>(1014453747);
					val2 = (BarricadeDrop)((P_0 is BarricadeDrop) ? P_0 : null);
					int num5;
					if (val2 != null)
					{
						num = 829307671;
						num5 = num;
					}
					else
					{
						num = -1535123317;
						num5 = num;
					}
					continue;
				}
				case 7u:
					P_2 = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
					num = 1350724312;
					continue;
				default:
					a3116505AAB.C607DEBFA72A49CE = _1CC7C690A66C42EE();
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private float _6E3C92E239A149BF(A3116505AAB24996 P_0, Player P_1)
	{
		if (P_0.F470F3F6558649C1._572825A58EC3403A)
		{
			goto IL_0010;
		}
		goto IL_011a;
		IL_0010:
		int num = -541761830;
		goto IL_0015;
		IL_0015:
		LevelAsset val = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(-(~(~((-num2 ^ (-1716265381 * -(-(-1383459736) * 81725427 - (~unchecked(-934018703 - 1289043147) - (1551351567 + --654959312))))) - -646569749 * (-(~-741595644 + unchecked(-614617789 * -1745566960)) - (~unchecked(-1686028696 - 768245927) - ~(826436256 + 218832982)))) * 549873203 * -1810264829)))) % 10)
			{
			case 2u:
				break;
			case 5u:
				return _003CModule_003E._8B9C7B12B1AE4949<float>(1400717923);
			case 7u:
			{
				int num6;
				int num7;
				if (val.enableAdminFasterSalvageDuration)
				{
					num6 = -1924891338;
					num7 = num6;
				}
				else
				{
					num6 = -1627301066;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 1351075205);
				continue;
			}
			case 4u:
				return P_0.F470F3F6558649C1._8EF072D3ACE7443F;
			case 6u:
				goto IL_011a;
			case 1u:
				return _003CModule_003E._3F57E81A62734AC2<float>(-1359692193);
			case 0u:
			{
				int num4;
				int num5;
				if (val != null)
				{
					num4 = -1079623129;
					num5 = num4;
				}
				else
				{
					num4 = -827941965;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 1344819206);
				continue;
			}
			case 9u:
				goto IL_0176;
			case 8u:
				val = (LevelAsset)FE5D1946FCB240E5();
				num = ((int)num3 * -1193212752) ^ 0x1B6084A;
				continue;
			default:
				return _003CModule_003E._8B9C7B12B1AE4949<float>(2071972263);
			}
			break;
			IL_0176:
			int num8;
			if (!_7BBC2C4D078648F3((object)((SteamChannel)_291A9867C64D46A6((object)P_1)).owner))
			{
				num = -1414506909;
				num8 = num;
			}
			else
			{
				num = -1544822828;
				num8 = num;
			}
		}
		goto IL_0010;
		IL_011a:
		int num9;
		if (!(_476F4C44667C44F3(C8EC517C1D984A44((object)P_1)) is UseableHousingPlanner))
		{
			num = 1545968031;
			num9 = num;
		}
		else
		{
			num = 775325219;
			num9 = num;
		}
		goto IL_0015;
	}

	private float _7C2A1856045B4E11(A3116505AAB24996 P_0, Player P_1, float P_2)
	{
		return _6E3C92E239A149BF(P_0, P_1) * P_2;
	}

	static void _8F3C8E1A4D40475D(SalvageRequestHandler P_0)
	{
		BarricadeDrop.OnSalvageRequested_Global += P_0;
	}

	static void _96FF3A52951E4228(SalvageRequestHandler P_0)
	{
		StructureDrop.OnSalvageRequested_Global += P_0;
	}

	void _31305C5717B9479C()
	{
		base.A599C828530B4E69();
	}

	static void _8690CCDD61614AF2(SalvageRequestHandler P_0)
	{
		BarricadeDrop.OnSalvageRequested_Global -= P_0;
	}

	static void _10C0FF01D58D4F26(SalvageRequestHandler P_0)
	{
		StructureDrop.OnSalvageRequested_Global -= P_0;
	}

	void _174A8844B6E844E7()
	{
		base.C4CA2ECFAD654E77();
	}

	static object _317EEACB68574F25(object P_0)
	{
		return ((SteamPlayer)P_0).player;
	}

	static object _3C4C584828044D25(Player P_0)
	{
		return A3116505AAB24996._69C6AFA769194D6F(P_0);
	}

	static object _291A9867C64D46A6(object P_0)
	{
		return ((Player)P_0).channel;
	}

	static object CAAC0954952341C5(object P_0)
	{
		return ((SteamPlayer)P_0).playerID;
	}

	static CSteamID C6EC343BA5F4469D(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((SteamPlayerID)P_0).steamID;
	}

	static bool A9B94785CBA74D26(object P_0, object P_1, object P_2, CSteamID P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return ((A3116505AAB24996)P_0).A98460F771B0446B((_4C6B03DD3A6441ED)P_1, (IConfiguration)P_2, P_3);
	}

	static long _1CC7C690A66C42EE()
	{
		return _9AB67761792440A7._00FC653ED33A4A96();
	}

	static object _7F553D98F9DB44BE(object P_0)
	{
		return ((BarricadeDrop)P_0).asset;
	}

	static float BD192A03C4F04292(object P_0)
	{
		return ((ItemBarricadeAsset)P_0).salvageDurationMultiplier;
	}

	static object _28900F8BC40A4ADB(object P_0)
	{
		return ((StructureDrop)P_0).asset;
	}

	static float _184778EB5E0D4D35(object P_0)
	{
		return ((ItemStructureAsset)P_0).salvageDurationMultiplier;
	}

	static string _70B2858454C94BCC(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static void _83D2494797314BB9(object P_0, object P_1, ECheckCategory P_2, ECheckType P_3, EFlagLevel P_4, string P_5)
	{
		((E651E17AA2CA4BC8)P_0).E99E5CDB10C04998((SteamPlayerID)P_1, P_2, P_3, P_4, P_5);
	}

	static object C8EC517C1D984A44(object P_0)
	{
		return ((Player)P_0).equipment;
	}

	static object _476F4C44667C44F3(object P_0)
	{
		return ((PlayerEquipment)P_0).useable;
	}

	static bool _7BBC2C4D078648F3(object P_0)
	{
		return ((SteamPlayer)P_0).isAdmin;
	}

	static object FE5D1946FCB240E5()
	{
		return Level.getAsset();
	}
}
