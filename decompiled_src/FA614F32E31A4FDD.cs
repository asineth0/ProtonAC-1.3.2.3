using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Microsoft.Extensions.Logging;
using SDG.Unturned;
using UnityEngine;

internal static class FA614F32E31A4FDD
{
	internal readonly struct _041C68EA4DEF4ECB(Matrix4x4 P_0, Vector3 P_1, Vector3 P_2, int P_3)
	{
		public readonly Matrix4x4 C6FAD9CBFBDA4978 = P_0.inverse;

		public readonly Matrix4x4 A27A1AFFE7134B0C = P_0;

		public readonly Vector3 C83FC9AB5AFF46C6 = P_1;

		public readonly Vector3 _5A3C6D4AF0414088 = P_2;

		public readonly int _3769F48C84E94AD0 = P_3;
	}

	private const string _302D3B25463A4CE4 = "Barricade";

	private const string D410A4676A0E4F1E = "/barricade.prefab";

	private const string C2BDA452885B4331 = "ProtonAC.BarricadeGeometryScan";

	private static readonly FieldRef<ItemBarricadeAsset, bool> _2E96F2825FFF46F6;

	private static readonly Dictionary<ushort, _041C68EA4DEF4ECB[]> _9FF53AD1074D4B7C;

	private static readonly HashSet<ushort> F09A74034204482A;

	private static readonly Dictionary<MasterBundleConfig, string[]> B488F322FEE841DA;

	private static readonly List<Collider> _458D2C3F7F674839;

	private static readonly List<_041C68EA4DEF4ECB> _7EE9E46385214896;

	private static readonly _041C68EA4DEF4ECB[] B2A8174EE3E34E6C = null;

	private static readonly int _7238C9182A9A4E9C;

	public static int _330939B93C2E4AB7 => _9FF53AD1074D4B7C.Count;

	public static bool ACF97466CB9345C6(ushort P_0)
	{
		return F09A74034204482A.Contains(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool _8F4115917F6F414D(Transform P_0, out _041C68EA4DEF4ECB[] P_1)
	{
		if (_9FF53AD1074D4B7C.Count > _003CModule_003E._390073C602714496<int>(2131963235))
		{
			goto IL_001b;
		}
		goto IL_00e4;
		IL_001b:
		int num = -296945119;
		goto IL_0020;
		IL_0020:
		ushort result = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(~(-(-(-((~(num2 - -737854810 * -895715809) ^ ~(-(-1827909340 + ~1670746872 - 1521649461))) - unchecked(95836329 * (0x2CF09A05 ^ 0x52F9DCD4)))))))) % 5)
			{
			case 3u:
				break;
			case 1u:
			{
				int num4;
				int num5;
				if (ushort.TryParse(_30037A842F224809((object)P_0), out result))
				{
					num4 = 151815122;
					num5 = num4;
				}
				else
				{
					num4 = -1539547813;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -985578663);
				continue;
			}
			case 2u:
				return _74B4BDBE41564813(result, ref P_1);
			case 0u:
				goto IL_00e4;
			default:
				return (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
			}
			break;
		}
		goto IL_001b;
		IL_00e4:
		P_1 = B2A8174EE3E34E6C;
		num = -145111093;
		goto IL_0020;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool _00820F4264154872(ushort P_0, out _041C68EA4DEF4ECB[] P_1)
	{
		if (_9FF53AD1074D4B7C.TryGetValue(P_0, out _041C68EA4DEF4ECB[] value))
		{
			while (true)
			{
				int num = -191107798;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(-(-unchecked(207383325 * (~unchecked(199768775 * 577562030) + ((0x57E4259B ^ 0x78A20383) - (0x3C7370D9 ^ 0x1FAAF409)))) - -(num2 ^ -unchecked((-1046662621 ^ -109801404) - (0x591AC502 ^ -2014212754) + unchecked((~unchecked(unchecked(1249831329 * 2120895285) - ~-1504278108) + -218191031) * 1947098557))) - (-(unchecked(54868537 * 1468501891) + ~1583794648) ^ -(-239726896 - 397176794 - -961590307))) - ((0x25ACC396 ^ -904966005) - -1625245560)) + 1065844701)) % 4)
					{
					case 0u:
						break;
					case 1u:
					{
						int num4;
						int num5;
						if (value.Length == 0)
						{
							num4 = -408895761;
							num5 = num4;
						}
						else
						{
							num4 = -570804650;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -220815425);
						continue;
					}
					case 2u:
						P_1 = value;
						return (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0;
					default:
						goto end_IL_0012;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
		}
		P_1 = B2A8174EE3E34E6C;
		return (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _2F2E47BE5BFE404B()
	{
		GC.KeepAlive(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _99817E2B2825489E(ItemBarricadeAsset P_0, _041C68EA4DEF4ECB[] P_1)
	{
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		C4462CD02B8C4225 c4462CD02B8C = ((_1DB744298E9F4B09)B86DB5A255ED4FF6()).CF47F3EE0E0C4452?.F3B62BCE1450413B<C4462CD02B8C4225>();
		int num4 = default;
		_041C68EA4DEF4ECB[] array = default;
		_5026174F21AA4302 obj = default;
		while (true)
		{
			int num = -921304575;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-((num2 - (-(1881704666 - ((0x7D48F1A6 ^ -318760468) - -unchecked(-1962648253 * unchecked(1238118641 + 1162608320)))) ^ ((-(~-1181219493) - -(-1646929236 ^ -1665872635) + -unchecked(~1028855411 * -1801562621) + ((--383250545 + unchecked(-1421200785 * -1518481112)) ^ 0xFC0C26C)) * -1434705159)) - -(-1695003179) - -unchecked(1766426450 * -1709669309) - 1709791371 * (-702208188 ^ (-1536636733 - -2073343853))) ^ 0x66349BE1 ^ ~(--1227667446)))) % 10)
				{
				case 0u:
					break;
				default:
					return;
				case 8u:
				{
					int num7;
					if (num4 < array.Length)
					{
						num = 391922216;
						num7 = num;
					}
					else
					{
						num = -1227250643;
						num7 = num;
					}
					continue;
				}
				case 6u:
				{
					_041C68EA4DEF4ECB obj2 = array[num4];
					List<CCF76E55FEF4462A> list = CBED0CD2FDCF48F6((object)obj);
					CCF76E55FEF4462A item = new CCF76E55FEF4462A
					{
						FDAE5685248B4393 = obj2._3769F48C84E94AD0,
						C4805F8816044844 = obj2._5A3C6D4AF0414088 * _003CModule_003E._58ECCB512F2A43AC<float>(2041734968)
					};
					Matrix4x4 a27A1AFFE7134B0C = obj2.A27A1AFFE7134B0C;
					item._0115C6E6EBDC45EA = a27A1AFFE7134B0C.MultiplyPoint3x4(obj2.C83FC9AB5AFF46C6);
					list.Add(item);
					num = 390130889;
					continue;
				}
				case 4u:
					return;
				case 3u:
					num4 += _003CModule_003E._390073C602714496<int>(-250964212);
					num = 277727136;
					continue;
				case 1u:
					c4462CD02B8C.CB4E939A3F83474C(_003CModule_003E._390073C602714496<string>(642689612), obj, (_6C63CD6C48F7495C)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668));
					num = -882122347;
					continue;
				case 9u:
				{
					int num5;
					int num6;
					if (c4462CD02B8C != null)
					{
						num5 = -1685880469;
						num6 = num5;
					}
					else
					{
						num5 = -1889368710;
						num6 = num5;
					}
					num = num5 ^ (int)(num3 * 462176432);
					continue;
				}
				case 2u:
					array = P_1;
					num4 = _003CModule_003E._390073C602714496<int>(2131963235);
					num = 277727136;
					continue;
				case 7u:
					obj = c4462CD02B8C._3ECE4ABFF9E04BFF<_5026174F21AA4302>();
					_0A218ED6029E4AA8((object)obj, ((Asset)P_0).id);
					_26AF1FAB746E4D72((object)obj, CA47F247A85C4B19((object)P_0));
					_2D6A3E831F884C86((object)obj, _539AE8A1E0024F69((object)P_0));
					E2330834D84C48B4((object)obj, P_1.Length);
					num = -440970300;
					continue;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public static void CB1721A3FE0A4D59()
	{
		_96D272D40B7343E9();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool _376F056FB4F44F93(Transform P_0, in Ray P_1, float P_2, _041C68EA4DEF4ECB[] P_3, int P_4, out float P_5)
	{
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		P_5 = _003CModule_003E._8B9C7B12B1AE4949<float>(-1886109142);
		Matrix4x4 val2 = default;
		bool flag = default;
		_041C68EA4DEF4ECB[] array = default;
		Matrix4x4 val = default;
		_041C68EA4DEF4ECB obj = default;
		float num9 = default;
		int num4 = default;
		while (true)
		{
			int num = -904339552;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~(-((num2 - (~(--442700573 + (-(-(0x675D23B6 ^ 0x5B7FAD4D)) ^ (-(--754395628) - (-1711610691 ^ -993546161)))) + (unchecked(unchecked(~(0x4E3984F0 ^ -193060606) + 1954151246) * 1053577683) - -((-1402296386 - (-265629883 ^ -733427980)) ^ -1456713940) - (-unchecked(1646687978 - (0x3FF8D72A ^ -761819277) - unchecked(-2064626151 * (-335575503 - 1556002168))) + (unchecked(~unchecked(1116007609 * 105610024) * -721600505) - -1667245505)))) - ~unchecked(~unchecked(unchecked(-2123687579 * unchecked(1584009505 + 1485972913)) + ~(~-1575397596)) * 923605127)) ^ (-316988427 * (475227603 * (-370164570 + -1801909884) + (-1723212308 ^ (--229658906 ^ -363749213))))))) * 32703317 - -2093699213)) % 14)
				{
				case 4u:
					break;
				case 6u:
					val2 = _467E365C332C4FC0((object)P_0);
					flag = (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
					array = P_3;
					num = 2110806419;
					continue;
				case 5u:
				{
					int num12;
					int num13;
					if (!_1C6F751464E5456F(in val, in obj, in P_1, P_2, out num9))
					{
						num12 = 844843593;
						num13 = num12;
					}
					else
					{
						num12 = 681788210;
						num13 = num12;
					}
					num = num12 ^ (int)(num3 * 1556372777);
					continue;
				}
				case 13u:
				{
					int num6;
					int num7;
					if (!flag)
					{
						num6 = -778101699;
						num7 = num6;
					}
					else
					{
						num6 = 913420330;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -1642491870);
					continue;
				}
				case 2u:
					P_5 = num9;
					flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0;
					num = 1160474488;
					continue;
				case 3u:
					val = obj.C6FAD9CBFBDA4978 * val2;
					num = (int)((num3 * 1814934248) ^ 0x69E6DCF3);
					continue;
				case 1u:
					P_5 = _003CModule_003E.F84FA79ABE6944BB<float>(1398637845);
					num = 1954991860;
					continue;
				case 7u:
				{
					int num10;
					int num11;
					if (!(num9 < P_5))
					{
						num10 = -506350609;
						num11 = num10;
					}
					else
					{
						num10 = 1451279061;
						num11 = num10;
					}
					num = num10 ^ ((int)num3 * -1493419289);
					continue;
				}
				case 8u:
				{
					obj = array[num4];
					int num8;
					if ((P_4 & (_003CModule_003E._390073C602714496<int>(-250964212) << (obj._3769F48C84E94AD0 & _003CModule_003E._390073C602714496<int>(1718054551)))) != 0)
					{
						num = -476559465;
						num8 = num;
					}
					else
					{
						num = 1160474488;
						num8 = num;
					}
					continue;
				}
				case 11u:
				{
					int num5;
					if (num4 >= array.Length)
					{
						num = 871623705;
						num5 = num;
					}
					else
					{
						num = -1982516310;
						num5 = num;
					}
					continue;
				}
				case 9u:
					num4 = _003CModule_003E._390073C602714496<int>(2131963235);
					num = 898140546;
					continue;
				case 0u:
					num4 += _003CModule_003E._58ECCB512F2A43AC<int>(1006217019);
					num = 1434954241;
					continue;
				case 10u:
					num = (int)((num3 * 769709585) ^ 0x2E4DABD);
					continue;
				default:
					return flag;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static float F62E764B646B414A(Transform P_0, in Vector3 P_1, _041C68EA4DEF4ECB[] P_2, int P_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		Matrix4x4 val = _467E365C332C4FC0((object)P_0);
		Vector3 val6 = default;
		Vector3 val4 = default;
		_041C68EA4DEF4ECB[] array = default;
		int num7 = default;
		Vector3 val7 = default;
		Matrix4x4 val2 = default;
		_041C68EA4DEF4ECB obj = default;
		float num4 = default;
		float sqrMagnitude = default;
		Vector3 val5 = default;
		Matrix4x4 val3 = default;
		while (true)
		{
			int num = 2038753643;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(unchecked(-825824141 * -1633137810) - (-(~(num2 ^ ((-(1019318169 - -586126228) + -1423431005 + ~(~-777324604) + (-(-1838746466) + (~(~1014757779) + ~(--86370302) + -(-1811136179 + -162136229 + unchecked(-359053128 + -1974490323))))) ^ ~(-(unchecked(-324800744 * -1151339459) + (-448786675 ^ -428564514)))) ^ ((~unchecked(-199475335 * ~(-1748756342 - -943937829)) + -(unchecked(-762068094 - 2048973680) - -685227979 - (~1218435324 + unchecked(-1682989585 * 10868399)))) ^ (~((0x6A10F868 ^ -1543337465) - ~(-1166126942 ^ -518330999)) + -1044297447)))) + (-727576270 ^ 0x2DE00B42) + -(-1850496652 - -1574208163)) - -1857481284)) % 17)
				{
				case 3u:
					break;
				case 11u:
					val6 = P_1 - val4;
					num = (int)((num3 * 1826947651) ^ 0x74595D5B);
					continue;
				case 14u:
					array = P_2;
					num = (int)(num3 * 567023585) ^ -922637141;
					continue;
				case 15u:
					num7 += _003CModule_003E._58ECCB512F2A43AC<int>(1006217019);
					num = 1513660147;
					continue;
				case 4u:
					val7 = val2.MultiplyPoint3x4(P_1);
					num = (int)(num3 * 373199208) ^ -740717280;
					continue;
				case 7u:
				{
					int num8;
					if (num7 < array.Length)
					{
						num = 1541422638;
						num8 = num;
					}
					else
					{
						num = -1080208790;
						num8 = num;
					}
					continue;
				}
				case 9u:
					val2 = obj.C6FAD9CBFBDA4978 * val;
					num = (int)((num3 * 986011798) ^ 0x2F315C6);
					continue;
				case 5u:
					num4 = sqrMagnitude;
					num = ((int)num3 * -111272219) ^ -1175280655;
					continue;
				case 0u:
				{
					Bounds val8 = new Bounds(obj.C83FC9AB5AFF46C6, obj._5A3C6D4AF0414088 * _003CModule_003E._3F57E81A62734AC2<float>(-782576078));
					val5 = val8.ClosestPoint(val7);
					num = -2146685367;
					continue;
				}
				case 12u:
					val3 = C32C44B546974F89((object)P_0);
					num4 = _003CModule_003E._390073C602714496<float>(-1165873066);
					num = -1259193478;
					continue;
				case 2u:
				{
					int num10;
					if (num4 == _003CModule_003E._8B9C7B12B1AE4949<float>(-1886109142))
					{
						num = 2058097701;
						num10 = num;
					}
					else
					{
						num = -2022474027;
						num10 = num;
					}
					continue;
				}
				case 13u:
					num7 = _003CModule_003E._390073C602714496<int>(2131963235);
					num = 1513660147;
					continue;
				case 10u:
				{
					obj = array[num7];
					int num9;
					if ((P_3 & (_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) << (obj._3769F48C84E94AD0 & _003CModule_003E._390073C602714496<int>(1718054551)))) != 0)
					{
						num = -2039221978;
						num9 = num;
					}
					else
					{
						num = -1513186696;
						num9 = num;
					}
					continue;
				}
				case 16u:
					return _003CModule_003E.F84FA79ABE6944BB<float>(1398637845);
				case 8u:
				{
					sqrMagnitude = val6.sqrMagnitude;
					int num5;
					int num6;
					if (sqrMagnitude >= num4)
					{
						num5 = 474215626;
						num6 = num5;
					}
					else
					{
						num5 = 15248943;
						num6 = num5;
					}
					num = num5 ^ (int)(num3 * 810764798);
					continue;
				}
				case 6u:
					val2 = val3 * obj.A27A1AFFE7134B0C;
					val4 = val2.MultiplyPoint3x4(val5);
					num = (int)((num3 * 319858637) ^ 0x15E1F54F);
					continue;
				default:
					return Mathf.Sqrt(num4);
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _1C6F751464E5456F(in Matrix4x4 P_0, in _041C68EA4DEF4ECB P_1, in Ray P_2, float P_3, out float P_4)
	{
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		P_4 = _003CModule_003E._3F57E81A62734AC2<float>(-1803194042);
		float num10 = default;
		float num6 = default;
		float num4 = default;
		float num5 = default;
		int num11 = default;
		Vector3 val4 = default;
		Vector3 val6 = default;
		Vector3 val3 = default;
		Vector3 val5 = default;
		Matrix4x4 val = default;
		while (true)
		{
			int num = -1145970464;
			while (true)
			{
				int num2 = num;
				uint num3;
				Ray val2;
				switch ((num3 = (uint)(~(-1685148607 ^ -1793182721) + -(~488530008 - ~-1002943643) - ~((0x63043DF4 ^ -(-(~unchecked(1280136911 * -711275189) + (unchecked(-1597246317 - 1597593950) + (-1692204003 - 167922652))))) - -395666099 * (0x34148DCB ^ ((-902001428 ^ -1121914409) - (unchecked(-1293807582 + ~1865290051) - (--802122174 + 1978656938)))) - num2 - (0x5675231E ^ ~(-(~(~1780667575))) ^ (-1238707871 * -(~(-1913625873 * 1017626595))))))) % 20)
				{
				case 16u:
					break;
				case 13u:
				{
					float num9 = num10;
					num10 = num6;
					num6 = num9;
					num = (int)((num3 * 1655012867) ^ 0x5852E57E);
					continue;
				}
				case 0u:
					num4 = _003CModule_003E._3F57E81A62734AC2<float>(-1803194042);
					num5 = P_3;
					num11 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
					num = -1432845377;
					continue;
				case 5u:
				{
					int num17;
					int num18;
					if (val4[num11] <= val6[num11])
					{
						num17 = 816290034;
						num18 = num17;
					}
					else
					{
						num17 = 473321464;
						num18 = num17;
					}
					num = num17 ^ ((int)num3 * -1812989590);
					continue;
				}
				case 12u:
					num4 = Mathf.Max(num4, num10);
					num = -607661270;
					continue;
				case 10u:
				{
					float num19 = _003CModule_003E._58ECCB512F2A43AC<float>(1014453747) / val3[num11];
					num10 = (val5[num11] - val4[num11]) * num19;
					num6 = (val6[num11] - val4[num11]) * num19;
					num = 2050358067;
					continue;
				}
				case 7u:
					val5 = P_1.C83FC9AB5AFF46C6 - P_1._5A3C6D4AF0414088;
					val6 = P_1.C83FC9AB5AFF46C6 + P_1._5A3C6D4AF0414088;
					num = ((int)num3 * -1070130151) ^ -1037689578;
					continue;
				case 19u:
					val2 = P_2;
					val4 = val.MultiplyPoint3x4(val2.origin);
					num = (int)((num3 * 612808027) ^ 0x2B3A4F35);
					continue;
				case 1u:
					val = P_0;
					num = ((int)num3 * -1162481336) ^ 0x57132515;
					continue;
				case 9u:
					val = P_0;
					num = ((int)num3 * -320242749) ^ -876157879;
					continue;
				case 8u:
					val2 = P_2;
					val3 = val.MultiplyVector(val2.direction);
					num = ((int)num3 * -2120409941) ^ -52928898;
					continue;
				case 6u:
					return (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
				case 2u:
				{
					int num20;
					if (num11 < _003CModule_003E._8B9C7B12B1AE4949<int>(944380096))
					{
						num = 1690860123;
						num20 = num;
					}
					else
					{
						num = 1923800197;
						num20 = num;
					}
					continue;
				}
				case 11u:
				{
					int num15;
					int num16;
					if (!(val4[num11] < val5[num11]))
					{
						num15 = -1025784002;
						num16 = num15;
					}
					else
					{
						num15 = -306297296;
						num16 = num15;
					}
					num = num15 ^ (int)(num3 * 1411274334);
					continue;
				}
				case 3u:
					return (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
				case 18u:
				{
					int num14;
					if (Mathf.Abs(val3[num11]) >= _003CModule_003E.F84FA79ABE6944BB<float>(-1884711527))
					{
						num = 2049913971;
						num14 = num;
					}
					else
					{
						num = 1970661150;
						num14 = num;
					}
					continue;
				}
				case 14u:
				{
					int num12;
					int num13;
					if (num10 <= num6)
					{
						num12 = 197627665;
						num13 = num12;
					}
					else
					{
						num12 = -1140592840;
						num13 = num12;
					}
					num = num12 ^ (int)(num3 * 1594189260);
					continue;
				}
				case 17u:
					num11 += _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
					num = -1432845377;
					continue;
				case 15u:
				{
					num5 = Mathf.Min(num5, num6);
					int num7;
					int num8;
					if (num4 > num5)
					{
						num7 = -484758921;
						num8 = num7;
					}
					else
					{
						num7 = 666740640;
						num8 = num7;
					}
					num = num7 ^ ((int)num3 * -650833688);
					continue;
				}
				default:
					P_4 = num4;
					return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static _041C68EA4DEF4ECB[] B92B8DE302DD40F7(GameObject P_0, Transform P_1)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = Object.Instantiate<GameObject>(P_0, P_1);
		_041C68EA4DEF4ECB[] result = default;
		try
		{
			E21AB6526FF54646(_0210227444604609((object)val), Vector3.zero);
			Collider current = default;
			Vector3 val3 = default;
			Vector3 val4 = default;
			while (true)
			{
				IL_0018:
				int num = -1531699683;
				while (true)
				{
					int num2 = num;
					_041C68EA4DEF4ECB[] array;
					int num11;
					uint num3;
					switch ((num3 = (uint)(-(num2 * -37713353 - (777530697 * (-(-773840624 ^ 0xCC25BAE) - unchecked(~679534922 * -1007703971)) + ~163758778 - 1784846782)))) % 5)
					{
					case 0u:
						break;
					case 3u:
					{
						B25C4CF007C64A44(_0210227444604609((object)val), Quaternion.identity);
						_9D9A7DB609C84983(_0210227444604609((object)val), Vector3.one);
						_458D2C3F7F674839.Clear();
						val.GetComponentsInChildren<Collider>((byte)_003CModule_003E._3F57E81A62734AC2<int>(1017304263) != 0, _458D2C3F7F674839);
						int num10;
						if (_458D2C3F7F674839.Count == 0)
						{
							num = 1501452572;
							num10 = num;
						}
						else
						{
							num = -1941731892;
							num10 = num;
						}
						continue;
					}
					case 4u:
						goto end_IL_001d;
					case 1u:
						result = B2A8174EE3E34E6C;
						num = ((int)num3 * -1290548868) ^ -421301022;
						continue;
					default:
						{
							_7EE9E46385214896.Clear();
							Matrix4x4 val2 = _467E365C332C4FC0(_0210227444604609((object)val));
							using (List<Collider>.Enumerator enumerator = _458D2C3F7F674839.GetEnumerator())
							{
								while (true)
								{
									IL_01be:
									int num4;
									int num5;
									if (!enumerator.MoveNext())
									{
										num4 = 714132293;
										num5 = num4;
									}
									else
									{
										num4 = -422452890;
										num5 = num4;
									}
									while (true)
									{
										num2 = num4;
										switch ((num3 = (uint)(-(num2 * -37713353 - (777530697 * (-(-773840624 ^ 0xCC25BAE) - unchecked(~679534922 * -1007703971)) + ~163758778 - 1784846782)))) % 7)
										{
										case 0u:
											num4 = -422452890;
											continue;
										default:
											goto end_IL_0135;
										case 2u:
										{
											current = enumerator.Current;
											int num7;
											if (!_132C128A54724298((object)current))
											{
												num4 = 1020564848;
												num7 = num4;
											}
											else
											{
												num4 = 1133789497;
												num7 = num4;
											}
											continue;
										}
										case 6u:
											break;
										case 4u:
										{
											int num8;
											int num9;
											if (C99EB396F7B242D8(current, ref val3, ref val4))
											{
												num8 = 783083504;
												num9 = num8;
											}
											else
											{
												num8 = 650648621;
												num9 = num8;
											}
											num4 = num8 ^ (int)(num3 * 1586009271);
											continue;
										}
										case 3u:
										{
											int num6;
											if ((_7238C9182A9A4E9C & (_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) << (_36E783D7DB544557(_4A58AC9B2DC54853((object)current)) & _003CModule_003E._8B9C7B12B1AE4949<int>(-1970080423)))) != 0)
											{
												num4 = 1345761628;
												num6 = num4;
											}
											else
											{
												num4 = 1133789497;
												num6 = num4;
											}
											continue;
										}
										case 1u:
											_7EE9E46385214896.Add(new _041C68EA4DEF4ECB(val2 * C32C44B546974F89(_6FE84528EC6647ED((object)current)), (val3 + val4) * _003CModule_003E.F84FA79ABE6944BB<float>(1724269691), (val4 - val3) * _003CModule_003E._3F57E81A62734AC2<float>(563453236), _36E783D7DB544557(_4A58AC9B2DC54853((object)current))));
											num4 = 1133789497;
											continue;
										case 5u:
											goto end_IL_0135;
										}
										goto IL_01be;
										continue;
										end_IL_0135:
										break;
									}
									break;
								}
							}
							if (_7EE9E46385214896.Count <= _003CModule_003E._58ECCB512F2A43AC<int>(352679804))
							{
								goto IL_02da;
							}
							array = _7EE9E46385214896.ToArray();
							goto IL_0340;
						}
						IL_0340:
						result = array;
						num11 = 1694344747;
						goto IL_02df;
						IL_02df:
						num2 = num11;
						switch ((num3 = (uint)(-(num2 * -37713353 - (777530697 * (-(-773840624 ^ 0xCC25BAE) - unchecked(~679534922 * -1007703971)) + ~163758778 - 1784846782)))) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_001d;
						case 2u:
							goto IL_032f;
						case 1u:
							goto end_IL_001d;
						}
						goto IL_02da;
						IL_032f:
						array = B2A8174EE3E34E6C;
						goto IL_0340;
						IL_02da:
						num11 = -384032468;
						goto IL_02df;
					}
					goto IL_0018;
					continue;
					end_IL_001d:
					break;
				}
				break;
			}
		}
		finally
		{
			_5FE34CF40C324BCF((Object)(object)val);
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GameObject? _4D63DEA9B66E4E90(ItemBarricadeAsset P_0)
	{
		MasterBundleConfig val = (MasterBundleConfig)_28DBF1772C1B4DFD((object)P_0);
		GameObject val2 = default;
		string text = default;
		string text2 = default;
		string[] array = default;
		int num7 = default;
		string text3 = default;
		GameObject val3 = default;
		while (true)
		{
			int num = -1614903543;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~num2 ^ -((1570415332 + -(~unchecked(1625294199 * 572852285))) ^ 0x64812CD0)) - (((0x32893CE7 ^ (-1509429627 + (-1001789630 - -1097596545))) + unchecked(-454251738 * 695846503)) ^ 0x77DB93E9))) % 18)
				{
				case 0u:
					break;
				case 5u:
					return val2;
				case 15u:
				{
					text = _3B041FA9989B4C4E((Asset)(object)P_0, val);
					int num6;
					if (text == null)
					{
						num = 1989837588;
						num6 = num;
					}
					else
					{
						num = 1280540063;
						num6 = num;
					}
					continue;
				}
				case 4u:
				{
					text2 = array[num7];
					int num8;
					if (!_652D964192C44581((object)text2, text3, (StringComparison)_003CModule_003E.F84FA79ABE6944BB<int>(2084623923)))
					{
						num = 1566580007;
						num8 = num;
					}
					else
					{
						num = -1163941616;
						num8 = num;
					}
					continue;
				}
				case 3u:
				{
					int num12;
					int num13;
					if (_31A49184E09C442D((Object)(object)val3, (Object)null))
					{
						num12 = -1007589390;
						num13 = num12;
					}
					else
					{
						num12 = -1208672479;
						num13 = num12;
					}
					num = num12 ^ ((int)num3 * -1547544678);
					continue;
				}
				case 6u:
					return null;
				case 9u:
					val3 = ((AssetBundle)_8E5B583DE01E4E1B((object)val)).LoadAsset<GameObject>(text2);
					num = ((int)num3 * -138369235) ^ -1740602445;
					continue;
				case 7u:
					text3 = F40FBF213E71444B(_8BFC836DDABB42E3((object)text), _003CModule_003E._8B9C7B12B1AE4949<string>(-1247462133));
					array = _64620A2A0F7E4175(val);
					num7 = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042);
					num = 2045398141;
					continue;
				case 12u:
					val2 = ((AssetBundle)_8E5B583DE01E4E1B((object)val)).LoadAsset<GameObject>(F40FBF213E71444B(F71A6FD459A44822((object)val, F40FBF213E71444B(text, _003CModule_003E._390073C602714496<string>(-1297839694))), _003CModule_003E._8B9C7B12B1AE4949<string>(-239321902)));
					num = 2101926201;
					continue;
				case 11u:
					return val3;
				case 13u:
				{
					int num14;
					int num15;
					if (_0DF8867D56B54525((Object)_8E5B583DE01E4E1B((object)val), (Object)null))
					{
						num14 = 60104089;
						num15 = num14;
					}
					else
					{
						num14 = 1043716916;
						num15 = num14;
					}
					num = num14 ^ ((int)num3 * -1144756396);
					continue;
				}
				case 2u:
				{
					int num10;
					int num11;
					if (val != null)
					{
						num10 = 1616120148;
						num11 = num10;
					}
					else
					{
						num10 = 1527999001;
						num11 = num10;
					}
					num = num10 ^ (int)(num3 * 2058941138);
					continue;
				}
				case 16u:
				{
					int num9;
					if (num7 < array.Length)
					{
						num = -1802883225;
						num9 = num;
					}
					else
					{
						num = 747239046;
						num9 = num;
					}
					continue;
				}
				case 8u:
					num7 += _003CModule_003E._390073C602714496<int>(-250964212);
					num = -1120169479;
					continue;
				case 10u:
				{
					int num4;
					int num5;
					if (!_31A49184E09C442D((Object)(object)val2, (Object)null))
					{
						num4 = -320704496;
						num5 = num4;
					}
					else
					{
						num4 = 147754456;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 655568533);
					continue;
				}
				case 14u:
					num = (int)((num3 * 145618698) ^ 0x3E22092D);
					continue;
				case 17u:
					return null;
				default:
					return null;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string[] _64620A2A0F7E4175(MasterBundleConfig P_0)
	{
		if (B488F322FEE841DA.TryGetValue(P_0, out string[] value))
		{
			goto IL_0012;
		}
		goto IL_0269;
		IL_0012:
		int num = -1512444072;
		goto IL_0017;
		IL_0017:
		string text = default;
		string[] array = default;
		int num4 = default;
		List<string> list = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)((-(num2 - (-(~(0x54BA4132 ^ -219102478) + (0x1F5DE3DE ^ -568273297)) - ((0x49D502A3 ^ -(~1714353824) ^ 0x578AFD32) + ~(-(0x406326CB ^ -1635607502)) * 1822341817 - -(-1744338692 ^ -1420005892))) + (-1203617908 + (((~(235589618 - -1486419276) + -unchecked(1832418259 - -1158106927)) ^ (-unchecked(2040507715 * 1599667176) - ~(-611621526))) + (0x6732CB3E ^ -388875337)))) ^ 0x31226D0A) * -1038982169 * 2119215231 * 631589563 + 622077114)) % 9)
			{
			case 7u:
				break;
			case 0u:
				text = array[num4];
				num = -1164648702;
				continue;
			case 8u:
				goto IL_01d1;
			case 1u:
				return value;
			case 3u:
				goto IL_021b;
			case 5u:
				list.Add(text);
				num = (int)((num3 * 1963445016) ^ 0x5E895D32);
				continue;
			case 2u:
				num4 += _003CModule_003E._390073C602714496<int>(-250964212);
				num = 1580335396;
				continue;
			case 6u:
				goto IL_0269;
			default:
				value = list.ToArray();
				B488F322FEE841DA[P_0] = value;
				return value;
			}
			break;
			IL_021b:
			int num5;
			if (num4 >= array.Length)
			{
				num = 2052005884;
				num5 = num;
			}
			else
			{
				num = 1563073421;
				num5 = num;
			}
			continue;
			IL_01d1:
			int num6;
			if (!_652D964192C44581((object)text, _003CModule_003E._3F57E81A62734AC2<string>(548045100), (StringComparison)_003CModule_003E._390073C602714496<int>(1661075637)))
			{
				num = 181866850;
				num6 = num;
			}
			else
			{
				num = -417086383;
				num6 = num;
			}
		}
		goto IL_0012;
		IL_0269:
		list = new List<string>();
		array = F955AD2757B941DB(_8E5B583DE01E4E1B((object)P_0));
		num4 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
		num = 1580335396;
		goto IL_0017;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string? _3B041FA9989B4C4E(Asset P_0, MasterBundleConfig P_1)
	{
		string absoluteOriginFilePath = P_0.absoluteOriginFilePath;
		string text2 = default;
		string text = default;
		while (true)
		{
			int num = 2085949302;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((num2 + ((-(0x28CF1EDD ^ -1030420403) ^ -279085657 ^ 0x47E24639) + -1789599228 - (-158334169 ^ (1322332335 * (~1180235437 + (--766050349 - -810295629))) ^ (-(unchecked((-66197927 - -1802465276) * -1406299921) + (--913956400 ^ -1292147936)) ^ -2047433791))) - (-1707083474 - -(907548346 - -70740974 - 774446810) * -1096608073 + ~(390358392 + (-(--2039027606) - (-1763662588 - unchecked(-1459876589 * -83426597)))))) * 1229203611)) % 12)
				{
				case 7u:
					break;
				case 5u:
					return null;
				case 1u:
				{
					int num9;
					int num10;
					if (FC76C7413C0A4985(text2))
					{
						num9 = 224177908;
						num10 = num9;
					}
					else
					{
						num9 = 1934593771;
						num10 = num9;
					}
					num = num9 ^ ((int)num3 * -1259541304);
					continue;
				}
				case 6u:
				{
					text = CE124EC7D734400A(absoluteOriginFilePath);
					int num7;
					if (FC76C7413C0A4985(text))
					{
						num = -847857767;
						num7 = num;
					}
					else
					{
						num = -480377493;
						num7 = num;
					}
					continue;
				}
				case 2u:
					text = B2E11E5B950D4D34((object)text, (char)_003CModule_003E._8B9C7B12B1AE4949<int>(-1927594399), (char)_003CModule_003E.F84FA79ABE6944BB<int>(188355324));
					num = 1971181523;
					continue;
				case 8u:
					return null;
				case 0u:
					return null;
				case 4u:
				{
					int num8;
					if (!_00D0A4F2DB134F5F((object)text, text2, (StringComparison)_003CModule_003E._8B9C7B12B1AE4949<int>(861409582)))
					{
						num = 1552774156;
						num8 = num;
					}
					else
					{
						num = 375188254;
						num8 = num;
					}
					continue;
				}
				case 9u:
					return null;
				case 3u:
				{
					text2 = E8F84FFDD4154C24((object)P_1);
					int num5;
					int num6;
					if (!FC76C7413C0A4985(absoluteOriginFilePath))
					{
						num5 = -1511515608;
						num6 = num5;
					}
					else
					{
						num5 = 425626288;
						num6 = num5;
					}
					num = num5 ^ (int)(num3 * 913534340);
					continue;
				}
				case 10u:
				{
					text2 = _8D75CEF6318D4DB5((object)B2E11E5B950D4D34((object)text2, (char)_003CModule_003E._3F57E81A62734AC2<int>(1717685466), (char)_003CModule_003E._390073C602714496<int>(-167118956)), (char)_003CModule_003E._8B9C7B12B1AE4949<int>(-657047796));
					int num4;
					if (_295A597D40154B1F((object)text) <= _295A597D40154B1F((object)text2))
					{
						num = -1106162323;
						num4 = num;
					}
					else
					{
						num = 2142246657;
						num4 = num;
					}
					continue;
				}
				default:
					return E2632D55F75B4FB8((object)text, _295A597D40154B1F((object)text2));
				}
				break;
			}
		}
	}

	static string _30037A842F224809(object P_0)
	{
		return ((Object)P_0).name;
	}

	static bool _74B4BDBE41564813(ushort P_0, ref _041C68EA4DEF4ECB[] P_1)
	{
		return _00820F4264154872(P_0, out P_1);
	}

	static object D7CEC37CB6F24CC3(string P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object)new GameObject(P_0);
	}

	static void _9E421E6E6C004E33(object P_0, bool P_1)
	{
		((GameObject)P_0).SetActive(P_1);
	}

	static object _0210227444604609(object P_0)
	{
		return ((GameObject)P_0).transform;
	}

	static void _6B6B0AA68E1F424D(object P_0, Vector3 P_1, Quaternion P_2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((Transform)P_0).SetPositionAndRotation(P_1, P_2);
	}

	static void _9D9A7DB609C84983(object P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Transform)P_0).localScale = P_1;
	}

	static Asset[] D175BFE1F3B94F56(EAssetType P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Assets.find(P_0);
	}

	static bool _0DF8867D56B54525(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static object B86DB5A255ED4FF6()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static object _218F4BB5E9D542D2(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
	}

	static void FCE717E74F5D4F02(ILogger P_0, Exception P_1, string P_2, object[] P_3)
	{
		LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
	}

	static void _5FE34CF40C324BCF(Object P_0)
	{
		Object.DestroyImmediate(P_0);
	}

	static void _0A218ED6029E4AA8(object P_0, ushort P_1)
	{
		((_5026174F21AA4302)P_0)._60FB228B546A494D = P_1;
	}

	static string CA47F247A85C4B19(object P_0)
	{
		return ((Asset)P_0).FriendlyName;
	}

	static void _26AF1FAB746E4D72(object P_0, string P_1)
	{
		((_5026174F21AA4302)P_0)._4CEE5B8971034213 = P_1;
	}

	static EBuild _539AE8A1E0024F69(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((ItemBarricadeAsset)P_0).build;
	}

	static void _2D6A3E831F884C86(object P_0, EBuild P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((_5026174F21AA4302)P_0)._528ACD5C250D408B = P_1;
	}

	static void E2330834D84C48B4(object P_0, int P_1)
	{
		((_5026174F21AA4302)P_0)._0FD0D6CB93264B4D = P_1;
	}

	static List<CCF76E55FEF4462A> CBED0CD2FDCF48F6(object P_0)
	{
		return ((_5026174F21AA4302)P_0)._49735FDD1E164071;
	}

	static object _96D272D40B7343E9()
	{
		return Resources.UnloadUnusedAssets();
	}

	static Matrix4x4 _467E365C332C4FC0(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Transform)P_0).worldToLocalMatrix;
	}

	static Matrix4x4 C32C44B546974F89(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Transform)P_0).localToWorldMatrix;
	}

	static void E21AB6526FF54646(object P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Transform)P_0).localPosition = P_1;
	}

	static void B25C4CF007C64A44(object P_0, Quaternion P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Transform)P_0).localRotation = P_1;
	}

	static bool _132C128A54724298(object P_0)
	{
		return ((Collider)P_0).isTrigger;
	}

	static object _4A58AC9B2DC54853(object P_0)
	{
		return ((Component)P_0).gameObject;
	}

	static int _36E783D7DB544557(object P_0)
	{
		return ((GameObject)P_0).layer;
	}

	static bool C99EB396F7B242D8(Collider P_0, ref Vector3 P_1, ref Vector3 P_2)
	{
		return _1187FAD6AB3F40BD._81A4CC2F49C040DA(P_0, out P_1, out P_2);
	}

	static object _6FE84528EC6647ED(object P_0)
	{
		return ((Component)P_0).transform;
	}

	static object _28DBF1772C1B4DFD(object P_0)
	{
		return ((Asset)P_0).originMasterBundle;
	}

	static object _8E5B583DE01E4E1B(object P_0)
	{
		return ((MasterBundleConfig)P_0).assetBundle;
	}

	static string F40FBF213E71444B(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static string F71A6FD459A44822(object P_0, string P_1)
	{
		return ((MasterBundleConfig)P_0).formatAssetPath(P_1);
	}

	static bool _31A49184E09C442D(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static string _8BFC836DDABB42E3(object P_0)
	{
		return ((string)P_0).ToLowerInvariant();
	}

	static bool _652D964192C44581(object P_0, string P_1, StringComparison P_2)
	{
		return ((string)P_0).EndsWith(P_1, P_2);
	}

	static string[] F955AD2757B941DB(object P_0)
	{
		return ((AssetBundle)P_0).GetAllAssetNames();
	}

	static string E8F84FFDD4154C24(object P_0)
	{
		return ((MasterBundleConfig)P_0).directoryPath;
	}

	static bool FC76C7413C0A4985(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string CE124EC7D734400A(string P_0)
	{
		return Path.GetDirectoryName(P_0);
	}

	static string B2E11E5B950D4D34(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	static string _8D75CEF6318D4DB5(object P_0, char P_1)
	{
		return ((string)P_0).TrimEnd(P_1);
	}

	static int _295A597D40154B1F(object P_0)
	{
		return ((string)P_0).Length;
	}

	static bool _00D0A4F2DB134F5F(object P_0, string P_1, StringComparison P_2)
	{
		return ((string)P_0).StartsWith(P_1, P_2);
	}

	static string E2632D55F75B4FB8(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}
}
