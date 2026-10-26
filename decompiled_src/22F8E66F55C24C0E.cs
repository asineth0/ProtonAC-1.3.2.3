using System;
using System.Runtime.CompilerServices;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

internal class _22F8E66F55C24C0E
{
	private static readonly ClientStaticMethod<Vector3, Vector3, string, Transform, NetId> _3528B6E7794140CB = ClientStaticMethod<Vector3, Vector3, string, Transform, NetId>.Get((ReceiveDelegate<Vector3, Vector3, string, Transform, NetId>)DamageTool.ReceiveSpawnBulletImpact);

	private static readonly ClientStaticMethod<Vector3, Vector3, string, Transform> _905345FA828D4B1C;

	private static readonly ClientInstanceMethod<Vector3, Vector3, string, Transform> A676D697BFC54C68;

	public static void _3B1EE6DC390B49EE(Player P_0, BulletInfo P_1, InputInfo P_2)
	{
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		if (_361E7A5223CE4AB0((Object)(object)P_2.player, (Object)null))
		{
			goto IL_0011;
		}
		goto IL_0122;
		IL_0011:
		int num = -1656069435;
		goto IL_0016;
		IL_0016:
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(((num2 ^ (--110191611 + -(0x5DFEE2AA ^ -(-(0x16AAC974 ^ 0x1A1B655))) - (-(-(-(-1478374314 - -501653183 - unchecked(1228195985 + 1384556581)))) ^ ((unchecked(-826068979 * (829080742 + -606696349)) - (2124936716 - 1861350395 + --1888602577)) * 1169566959 + ~(-unchecked(-892099931 * 696022151)) * 1125325537)))) * -1758491961) ^ ((unchecked(1947958783 * (1270846970 - -736642850)) + (-690608006 + unchecked(-1380615835 * -1007641295)) + -(unchecked(2020533223 * 1691520629) + -988903058)) ^ -(-598044702 + (unchecked(-207280295 * 367098746) + (1980533381 - 1672878461)))))) % 10)
			{
			case 4u:
				break;
			default:
				return;
			case 8u:
				goto IL_0122;
			case 5u:
			{
				int num6;
				int num7;
				if (!_7BB43FDF47DA459A((object)P_1.magazineAsset))
				{
					num6 = 1626567465;
					num7 = num6;
				}
				else
				{
					num6 = -465008827;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 677232268);
				continue;
			}
			case 3u:
				_635A03E66BFC4875(P_2.point, P_2.normal, P_2.materialName, P_2.colliderTransform, ((SteamChannel)_1424597351534F53((object)P_0)).owner, (ITransportConnection)_41AC09C9EC8947C9((object)((SteamChannel)_1424597351534F53((object)P_0)).owner));
				num = 74181136;
				continue;
			case 9u:
			{
				int num8;
				int num9;
				if (P_1.magazineAsset == null)
				{
					num8 = -982899483;
					num9 = num8;
				}
				else
				{
					num8 = 686157595;
					num9 = num8;
				}
				num = num8 ^ ((int)num3 * -385803900);
				continue;
			}
			case 6u:
				return;
			case 7u:
			{
				int num4;
				int num5;
				if (_88FA0DF1509448D7((Object)(object)P_2.player, (Object)(object)P_0))
				{
					num4 = -1388679976;
					num5 = num4;
				}
				else
				{
					num4 = -542857640;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -1967609644);
				continue;
			}
			case 2u:
				return;
			case 1u:
				_20E00D2754674933((EffectAsset)E36240AB651D4180((object)P_1.magazineAsset), P_2.point, P_2.normal, ((SteamChannel)_1424597351534F53((object)P_0)).owner);
				num = ((int)num3 * -2015111519) ^ -1966133505;
				continue;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0011;
		IL_0122:
		int num10;
		if (!_495DBBF07EF24BB8(P_2.materialName))
		{
			num = 464461013;
			num10 = num;
		}
		else
		{
			num = 74181136;
			num10 = num;
		}
		goto IL_0016;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _635A03E66BFC4875(Vector3 P_0, Vector3 P_1, string P_2, Transform P_3, SteamPlayer P_4, ITransportConnection P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		P_0 += P_1 * A553B35A82BC4585(_003CModule_003E._3F57E81A62734AC2<float>(-1486407007), _003CModule_003E._390073C602714496<float>(1387991123));
		NetId val = default;
		while (true)
		{
			int num = -565262375;
			while (true)
			{
				int num2 = num;
				uint num3;
				NetId val2;
				switch ((num3 = (uint)(~(-(-(~(-num2 * -346099403) ^ -1827748813)) ^ -1941127755))) % 4)
				{
				case 0u:
					break;
				case 1u:
					if (P_4 == null)
					{
						num = (int)((num3 * 946124606) ^ 0x11876B4A);
						continue;
					}
					val2 = A23C5E070CA84A09((object)P_4);
					goto IL_008c;
				case 2u:
					val2 = NetId.INVALID;
					goto IL_008c;
				default:
					{
						_3528B6E7794140CB.Invoke((ENetReliability)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019), P_5, P_0, P_1, P_2, P_3, val);
						return;
					}
					IL_008c:
					val = val2;
					num = 46188803;
					continue;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _829B9A13774E4CB8(Vector3 P_0, Vector3 P_1, string P_2, Transform P_3, ITransportConnection P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		P_0 += P_1 * A553B35A82BC4585(_003CModule_003E._390073C602714496<float>(-524048726), _003CModule_003E.F84FA79ABE6944BB<float>(1156899973));
		_905345FA828D4B1C.Invoke((ENetReliability)_003CModule_003E._390073C602714496<int>(-250964212), P_4, P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DEE51D8B0DE24256(Vector3 P_0, Vector3 P_1, string P_2, Transform P_3, NetId P_4, ITransportConnection P_5)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		P_0 += P_1 * A553B35A82BC4585(_003CModule_003E._58ECCB512F2A43AC<float>(-846029555), _003CModule_003E._8B9C7B12B1AE4949<float>(-90749795));
		A676D697BFC54C68.Invoke(P_4, (ENetReliability)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668), P_5, P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void D9CA88F07183479D(Player P_0, InputInfo P_1)
	{
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (_361E7A5223CE4AB0((Object)(object)P_1.player, (Object)null))
		{
			goto IL_0011;
		}
		goto IL_0149;
		IL_0011:
		int num = -723195133;
		goto IL_0016;
		IL_0016:
		Vector3 val = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(~(-(-(num2 * 1165132297) ^ -1433718006)))) % 9)
			{
			case 6u:
				break;
			default:
				return;
			case 3u:
				goto IL_0083;
			case 7u:
				_829B9A13774E4CB8(P_1.point, P_1.normal, P_1.materialName, P_1.colliderTransform, (ITransportConnection)_41AC09C9EC8947C9((object)((SteamChannel)_1424597351534F53((object)P_0)).owner));
				num = ((int)num3 * -406378164) ^ 0x11DBDB99;
				continue;
			case 8u:
				goto IL_00e3;
			case 4u:
				return;
			case 2u:
			{
				int num4;
				int num5;
				if (!_88FA0DF1509448D7((Object)(object)P_1.player, (Object)(object)P_0))
				{
					num4 = -154273233;
					num5 = num4;
				}
				else
				{
					num4 = -1467585658;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -1678542641);
				continue;
			}
			case 5u:
				goto IL_0149;
			case 1u:
				return;
			case 0u:
				return;
			}
			break;
			IL_00e3:
			int num6;
			if (val.sqrMagnitude <= _003CModule_003E._390073C602714496<float>(-53161128))
			{
				num = 84217216;
				num6 = num;
			}
			else
			{
				num = -1877497619;
				num6 = num;
			}
			continue;
			IL_0083:
			int num7;
			if (_495DBBF07EF24BB8(P_1.materialName))
			{
				num = 669154333;
				num7 = num;
			}
			else
			{
				num = -1706817862;
				num7 = num;
			}
		}
		goto IL_0011;
		IL_0149:
		val = P_1.point - _1D063530BFF54AF9(_0B7E68952C9549A4(B4C99CC32CA74986((object)P_0)));
		num = -67234092;
		goto IL_0016;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _11480E0414B04058(Player P_0, InputInfo P_1, ItemMeleeAsset P_2)
	{
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		if (_361E7A5223CE4AB0((Object)(object)P_1.player, (Object)null))
		{
			goto IL_0011;
		}
		goto IL_018d;
		IL_0011:
		int num = -163740850;
		goto IL_0016;
		IL_0016:
		Vector3 val = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(769771871 - ((num2 + ((-1785170544 - unchecked(unchecked(unchecked(unchecked(293161242 + (1585247594 - -489351962)) + unchecked(~-1803200172 + ~-1937475307)) - -1189372459) - 1579597175)) ^ -(-(0x55A6CF14 ^ 0x16D4A0F3)))) ^ (-1183169638 ^ ~(-209470891 - (-1613187553 ^ 0x64DA48F2)) ^ (unchecked(1800952837 * unchecked(863884141 * unchecked(-171642598 * 1529568737))) - (116269349 + -1057841610 - 302623453 - -(0x36A61E7C ^ 0x3621801B))) ^ (-45403387 * -968185523 - (-(-(~-1407041670)) + (-667565314 ^ -313641405))))))) % 11)
			{
			case 5u:
				break;
			default:
				return;
			case 10u:
				goto IL_015e;
			case 4u:
				return;
			case 8u:
				goto IL_018d;
			case 0u:
				goto IL_01b3;
			case 7u:
				return;
			case 6u:
			{
				int num6;
				int num7;
				if (!_991F075719BA443B((object)P_2))
				{
					num6 = -808625502;
					num7 = num6;
				}
				else
				{
					num6 = -1918763797;
					num7 = num6;
				}
				num = num6 ^ ((int)num3 * -1692223107);
				continue;
			}
			case 3u:
				goto IL_020b;
			case 9u:
			{
				int num4;
				int num5;
				if (!_88FA0DF1509448D7((Object)(object)P_1.player, (Object)(object)P_0))
				{
					num4 = -1749173087;
					num5 = num4;
				}
				else
				{
					num4 = -1779250946;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 285229501);
				continue;
			}
			case 1u:
				DEE51D8B0DE24256(P_1.point, P_1.normal, P_1.materialName, P_1.colliderTransform, D3DFB98FCB0B472B(_1BCC0900D9E64733(F69FF6CA11D4487E((object)P_0))), (ITransportConnection)_41AC09C9EC8947C9((object)((SteamChannel)_1424597351534F53((object)P_0)).owner));
				num = (int)((num3 * 924934675) ^ 0x5BE0148);
				continue;
			case 2u:
				return;
			}
			break;
			IL_020b:
			int num8;
			if (val.sqrMagnitude <= _3C62201D39034253(((ItemWeaponAsset)P_2).range + _003CModule_003E._390073C602714496<float>(1858878721)))
			{
				num = -222051138;
				num8 = num;
			}
			else
			{
				num = 777993622;
				num8 = num;
			}
			continue;
			IL_01b3:
			int num9;
			if (!_495DBBF07EF24BB8(P_1.materialName))
			{
				num = 965579410;
				num9 = num;
			}
			else
			{
				num = -1083138400;
				num9 = num;
			}
			continue;
			IL_015e:
			int num10;
			if (!BDD2D94B3A9947AA((object)P_2))
			{
				num = -48482071;
				num10 = num;
			}
			else
			{
				num = 972790449;
				num10 = num;
			}
		}
		goto IL_0011;
		IL_018d:
		val = P_1.point - _1D063530BFF54AF9(_0B7E68952C9549A4(B4C99CC32CA74986((object)P_0)));
		num = 407145157;
		goto IL_0016;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _22F8E66F55C24C0E()
	{
		while (true)
		{
			int num = -1920709888;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((((num2 ^ (--1854218715 ^ ((-unchecked(261481989 * -244879981) * 119583713 * -1348546995 + (-(unchecked(-1206815591 * -1454741398) - (0x362BCE3A ^ -54862163)) ^ -506001347)) ^ 0xEB28063)) ^ (-1643940249 ^ (((-1119646084 ^ (-1090040903 - unchecked(1123995607 * 801344167))) + (-(236270800 - 1946402408) ^ -1275981079)) ^ -1384420252))) - (-(~(~unchecked(-1652136398 * -536672247))) + (-886283041 + -1056136303 - ~879409067 - (unchecked(1006442833 * 172506373) - (-183711576 ^ 0x36E9EC95)) + (--997240405 + unchecked(-611518307 - 1741415089) - (-1277789504 ^ 0x4366201B))))) ^ (unchecked(1056328465 * 209361217) - 674993263 * (unchecked(1494407581 + 1751320136) + -163216773))) * -1278338991) - ~2146130147)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_017b;
				case 1u:
					return;
				}
				break;
				IL_017b:
				_905345FA828D4B1C = ClientStaticMethod<Vector3, Vector3, string, Transform>.Get((ReceiveDelegate<Vector3, Vector3, string, Transform>)DamageTool.ReceiveSpawnLegacyImpact);
				A676D697BFC54C68 = ClientInstanceMethod<Vector3, Vector3, string, Transform>.Get((Type)_10A9EE6214AC42F8(typeof(UseableMelee).TypeHandle), _003CModule_003E.F84FA79ABE6944BB<string>(-1631807046));
				num = 1281055050;
			}
		}
	}

	static bool _361E7A5223CE4AB0(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static bool _88FA0DF1509448D7(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static bool _495DBBF07EF24BB8(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static bool _7BB43FDF47DA459A(object P_0)
	{
		return ((ItemMagazineAsset)P_0).IsImpactEffectRefNull();
	}

	static object E36240AB651D4180(object P_0)
	{
		return ((ItemMagazineAsset)P_0).FindImpactEffectAsset();
	}

	static object _1424597351534F53(object P_0)
	{
		return ((Player)P_0).channel;
	}

	static void _20E00D2754674933(EffectAsset P_0, Vector3 P_1, Vector3 P_2, SteamPlayer P_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		DamageTool.ServerTriggerImpactEffectForMagazinesV2(P_0, P_1, P_2, P_3);
	}

	static object _41AC09C9EC8947C9(object P_0)
	{
		return ((SteamConnectedClientBase)P_0).transportConnection;
	}

	static float A553B35A82BC4585(float P_0, float P_1)
	{
		return Random.Range(P_0, P_1);
	}

	static NetId A23C5E070CA84A09(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((SteamPlayer)P_0).GetNetId();
	}

	static object B4C99CC32CA74986(object P_0)
	{
		return ((Player)P_0).look;
	}

	static object _0B7E68952C9549A4(object P_0)
	{
		return ((PlayerLook)P_0).aim;
	}

	static Vector3 _1D063530BFF54AF9(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Transform)P_0).position;
	}

	static float _3C62201D39034253(float P_0)
	{
		return MathfEx.Square(P_0);
	}

	static bool BDD2D94B3A9947AA(object P_0)
	{
		return ((ItemMeleeAsset)P_0).isRepair;
	}

	static bool _991F075719BA443B(object P_0)
	{
		return ((ItemMeleeAsset)P_0).isRepeated;
	}

	static object F69FF6CA11D4487E(object P_0)
	{
		return ((Player)P_0).equipment;
	}

	static object _1BCC0900D9E64733(object P_0)
	{
		return ((PlayerEquipment)P_0).useable;
	}

	static NetId D3DFB98FCB0B472B(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((PlayerCaller)P_0).GetNetId();
	}

	static object _10A9EE6214AC42F8(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
