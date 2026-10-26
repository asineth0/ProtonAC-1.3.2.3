using System;
using System.Runtime.CompilerServices;
using System.Text;

internal static class _0E002E61EDA64248
{
	private static readonly Random F308807992EE4502 = (Random)A9A27DC691AC43FA();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static (string obfuscatedText, string salt) D94ACEF1DC354E7E(string P_0, string? P_1 = null)
	{
		C5AA7C6BC71A434A();
		_2D855A89807D40FC((object)P_0);
		_79236636998E4A93((char[])null);
		C5AA7C6BC71A434A();
		_4889EE304D4F4A07((object)null, (string)null);
		A1F66558C0634EB6(0);
		_2ED8DDDC70FA4250(new byte[0]);
		BAE10625CABE4029(P_0);
		_4889EE304D4F4A07((object)null, (string)null);
		throw new Exception();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string _399245EC06264587(string P_0, string P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(286801907u);
		int num4 = default;
		byte[] array3 = default;
		byte[] array2 = default;
		byte[] array4 = default;
		while (true)
		{
			int num = 1055806373;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~(((num2 ^ (-(-(-(-(--614990142)) ^ -unchecked(2141236389 * ~765919559))) ^ (-(-(0x283E633F ^ -241387719) - (unchecked(-1211762904 * -56171225) + ~-524518371)) * -1865702839 + (1247565720 + -2015822178)))) + ((unchecked(-887923265 * (unchecked(1627509277 * -302603276) + (0x7CE44A5A ^ 0x634BC884))) - ((0x3C6FDF61 ^ --584597085) + -948310224) - (-1488783130 + (--381244855 + -931219704) - (unchecked(-1258557741 + -1964593988) + unchecked(-664321581 * -1279750965) + unchecked(~-1887075160 * -832043103)))) ^ -1814612352)) * -531879443) ^ 0x8D5FB9F ^ -777288995) - unchecked(34304115 * -1729589759) - -1743642078)) % 15)
				{
				case 5u:
					break;
				case 4u:
				{
					int num9;
					int num10;
					if (BAE10625CABE4029(P_0))
					{
						num9 = 357030308;
						num10 = num9;
					}
					else
					{
						num9 = 1287375810;
						num10 = num9;
					}
					num = num9 ^ (int)(num3 * 1822591685);
					continue;
				}
				case 1u:
				{
					int num7;
					int num8;
					if (num4 >= array3.Length)
					{
						num7 = 1097497117;
						num8 = num7;
					}
					else
					{
						num7 = 1327618793;
						num8 = num7;
					}
					num = num7 ^ (int)(num3 * 1926977206);
					continue;
				}
				case 10u:
					return P_0;
				case 0u:
					obj._184044A093C04AF2(5, 1386366380u);
					num = 1129685671;
					continue;
				case 2u:
					num = (int)(num3 * 1108388987) ^ -2102226425;
					continue;
				case 13u:
					array2 = new byte[array3.Length];
					obj._184044A093C04AF2(8, 1011361151u);
					obj._184044A093C04AF2(5, 4199014649u);
					obj._184044A093C04AF2(3, 537011911u);
					num4 = _003CModule_003E.F84FA79ABE6944BB<int>(-1707389328 ^ (int)obj._184044A093C04AF2(10, 3287433590u));
					num = (int)(num3 * 2001173076) ^ -1414804117;
					continue;
				case 12u:
					array4 = _4889EE304D4F4A07(C5AA7C6BC71A434A(), P_1);
					num = (int)((num3 * 1302504508) ^ 0x50E3BAC1);
					continue;
				case 14u:
				{
					int num5;
					int num6;
					if (!BAE10625CABE4029(P_1))
					{
						num5 = 670508341;
						num6 = num5;
					}
					else
					{
						num5 = -1821536520;
						num6 = num5;
					}
					num = num5 ^ (int)(num3 * 37395417);
					continue;
				}
				case 3u:
					array2[num4] = (byte)(array3[num4] ^ array4[num4 % array4.Length]);
					num = 1390931576;
					continue;
				case 7u:
					obj = new _81DD83B8AA2247AA(2601957548u);
					num = -1888889671;
					continue;
				case 6u:
					obj._184044A093C04AF2(0, 1402194843u);
					num = ((int)num3 * -1217204317) ^ 0x2A320F44;
					continue;
				case 11u:
					num4 += _003CModule_003E._3F57E81A62734AC2<int>(-171696222 ^ (int)obj._184044A093C04AF2(10, 2427805257u));
					num = ((int)num3 * -1548138588) ^ 0x583D0FC8;
					continue;
				case 8u:
					array3 = CD47445AA8AD42D4(P_0);
					num = 908261649;
					continue;
				default:
				{
					char[] array = _2D855A89807D40FC((object)_46BFC20C78E84E84(C5AA7C6BC71A434A(), array2));
					Array.Reverse(array);
					return (string)_79236636998E4A93(array);
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string _459859367B31489C(int P_0)
	{
		_7DC3097357444095((object)null);
		_08E65A4FF41045F6((object)null, 0);
		_8F20DEC2C3E04E0F((object)null, 0);
		_79236636998E4A93(new char[P_0]);
		throw new Exception();
	}

	static bool BAE10625CABE4029(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static string A1F66558C0634EB6(int P_0)
	{
		return _459859367B31489C(P_0);
	}

	static char[] _2D855A89807D40FC(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	static object _79236636998E4A93(char[] P_0)
	{
		return new string(P_0);
	}

	static object C5AA7C6BC71A434A()
	{
		return Encoding.UTF8;
	}

	static byte[] _4889EE304D4F4A07(object P_0, string P_1)
	{
		return ((Encoding)P_0).GetBytes(P_1);
	}

	static string _2ED8DDDC70FA4250(byte[] P_0)
	{
		return Convert.ToBase64String(P_0);
	}

	static byte[] CD47445AA8AD42D4(string P_0)
	{
		return Convert.FromBase64String(P_0);
	}

	static string _46BFC20C78E84E84(object P_0, byte[] P_1)
	{
		return ((Encoding)P_0).GetString(P_1);
	}

	static int _7DC3097357444095(object P_0)
	{
		return ((string)P_0).Length;
	}

	static int _08E65A4FF41045F6(object P_0, int P_1)
	{
		return ((Random)P_0).Next(P_1);
	}

	static char _8F20DEC2C3E04E0F(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	static object A9A27DC691AC43FA()
	{
		return new Random();
	}
}
