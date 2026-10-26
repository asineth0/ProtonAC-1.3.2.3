using System;
using System.Runtime.CompilerServices;

internal class AD42310A59D34400
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int _9D2381FD286642FB(string P_0, string P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3727568197u);
		string[] array = _98396EC4C11D4C8C((object)P_0, (char)_003CModule_003E._8B9C7B12B1AE4949<int>(-1838841514 ^ (int)obj._184044A093C04AF2(2, 4133105096u)), (StringSplitOptions)_003CModule_003E._8B9C7B12B1AE4949<int>(-1251512260 ^ (int)obj._184044A093C04AF2(5, 4181678444u)));
		string[] array2 = _98396EC4C11D4C8C((object)P_1, (char)_003CModule_003E._8B9C7B12B1AE4949<int>(-677799842 ^ (int)obj._184044A093C04AF2(8, 2862024497u)), (StringSplitOptions)_003CModule_003E._390073C602714496<int>((int)(0x12B2A492 ^ obj._184044A093C04AF2(6, 761390605u))));
		int num5 = default;
		int num6 = default;
		int num10 = default;
		int num9 = default;
		while (true)
		{
			int num = 1581450232;
			while (true)
			{
				int num2 = num;
				uint num3;
				int num4;
				int num8;
				int num11;
				switch ((num3 = (uint)(((-1553646946 + unchecked(-1073975399 * 329666439) + --398307238) ^ (-(--1252787408) ^ 0x90CE2AA)) - (((num2 ^ (-138796909 * (-1617436085 * (--1167991080 ^ --1115872607) - unchecked(1612727017 * ~unchecked(-356741892 + -1907475902)) - ((0x10C93C3 ^ -1632792644) - (~(-2015269742) ^ -409422188))) - -(-(-1837496694 * -1236663951)))) * -104934983) ^ (0x2E59BFC8 ^ (-2130743597 + 1519832719 * --1222949641) ^ 0x32CE4830)))) % 12)
				{
				case 4u:
					break;
				case 0u:
					num5 += _003CModule_003E._390073C602714496<int>((int)(0x72FCC467 ^ obj._184044A093C04AF2(0, 1404647763u)));
					num = -228620971;
					continue;
				case 2u:
					obj = new _81DD83B8AA2247AA(53697336u);
					if (num5 >= array.Length)
					{
						num = -1064499514;
						continue;
					}
					obj._184044A093C04AF2(9, 2030180120u);
					num4 = int.Parse(array[num5]);
					goto IL_0387;
				case 6u:
					num8 = _003CModule_003E._58ECCB512F2A43AC<int>(-984998588 ^ (int)obj._184044A093C04AF2(1, 218277573u));
					goto IL_01fe;
				case 3u:
					num6 = _31889BA62AC2430B(array.Length, array2.Length);
					obj._184044A093C04AF2(4, 2127040703u);
					obj._184044A093C04AF2(7, 2823466125u);
					obj._184044A093C04AF2(2, 1060436543u);
					num5 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658065390 ^ (int)obj._184044A093C04AF2(9, 1856877944u));
					num = ((int)num3 * -1091569690) ^ 0x529F10AF;
					continue;
				case 8u:
					return _003CModule_003E.F84FA79ABE6944BB<int>(-1149234483 ^ (int)obj._184044A093C04AF2(6, 1370551954u));
				case 7u:
				{
					obj._184044A093C04AF2(10, 3199232487u);
					int num12;
					if (num10 <= num9)
					{
						num = 1724234423;
						num12 = num;
					}
					else
					{
						num = 1290295703;
						num12 = num;
					}
					continue;
				}
				case 9u:
					return _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x69252089 ^ obj._184044A093C04AF2(4, 3586823370u)));
				case 11u:
					if (num5 < array2.Length)
					{
						obj._184044A093C04AF2(9, 218277573u);
						num8 = int.Parse(array2[num5]);
						goto IL_01fe;
					}
					num = ((int)num3 * -990715996) ^ -609624147;
					continue;
				case 10u:
				{
					obj = new _81DD83B8AA2247AA(3056938196u);
					int num7;
					if (num5 < num6)
					{
						num = 33562373;
						num7 = num;
					}
					else
					{
						num = -1639138894;
						num7 = num;
					}
					continue;
				}
				case 1u:
					obj._184044A093C04AF2(5, 2030180120u);
					num4 = _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x88993F5 ^ obj._184044A093C04AF2(0, 0u)));
					goto IL_0387;
				default:
					{
						return _003CModule_003E.F84FA79ABE6944BB<int>(-1431542463 ^ (int)obj._184044A093C04AF2(8, 2497079559u));
					}
					IL_01fe:
					obj._184044A093C04AF2(5, 3889722914u);
					num9 = num8;
					if (num10 < num9)
					{
						num = -1289442458;
						num11 = num;
					}
					else
					{
						num = -1781021604;
						num11 = num;
					}
					continue;
					IL_0387:
					obj._184044A093C04AF2(1, 2289545778u);
					num10 = num4;
					num = -2143571616;
					continue;
				}
				break;
			}
		}
	}

	static string[] _98396EC4C11D4C8C(object P_0, char P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split(P_1, P_2);
	}

	static int _31889BA62AC2430B(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}
}
