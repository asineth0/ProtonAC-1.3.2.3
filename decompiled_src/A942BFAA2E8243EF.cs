using System;
using System.ComponentModel;
using System.Reflection;

internal static class A942BFAA2E8243EF
{
	public static string _06C963E93B514E5F(this Enum P_0)
	{
		if (P_0 == null)
		{
			goto IL_0006;
		}
		goto IL_0163;
		IL_0006:
		int num = 1817147538;
		goto IL_000b;
		IL_000b:
		string text = default;
		Type type = default;
		FieldInfo fieldInfo = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(((num2 ^ (-(-(-(~(~(766535947 - 2005211283))))) * -185126197)) - -(~(-(-unchecked(880328643 * 2070793981))) + (unchecked(unchecked(-1609302947 * -1254213811) * -786868673) - 73227964 - (unchecked(1580737545 * -658961022) + -1735439055 - -(-1561154635 ^ -1628130874)))) + (~(~unchecked(29725284 * 198253509)) - 880386614)) ^ -(402156901 + -849273678 + 191620924 - (--940294630 - ~-1543134779)))) % 10)
			{
			case 8u:
				break;
			case 5u:
				text = _5B26F6BB01724984(type, (object)P_0);
				num = ((int)num3 * -246028375) ^ 0x3A0BCD3B;
				continue;
			case 0u:
			{
				int num6;
				int num7;
				if (!E2311A4AAF11402E(fieldInfo, (FieldInfo)null))
				{
					num6 = -1856076570;
					num7 = num6;
				}
				else
				{
					num6 = 1150683229;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 727299589);
				continue;
			}
			case 4u:
			{
				int num4;
				int num5;
				if (text == null)
				{
					num4 = -2013715891;
					num5 = num4;
				}
				else
				{
					num4 = -2089133745;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -1745532386);
				continue;
			}
			case 7u:
				return text;
			case 2u:
				return string.Empty;
			case 1u:
				goto IL_0163;
			case 3u:
				fieldInfo = (FieldInfo)_5A737DF753864191((object)type, text);
				num = 619200100;
				continue;
			case 9u:
				return B9E8CD9D46F84AE8((object)P_0);
			default:
			{
				DescriptionAttribute obj = B6864A9A7C1541E7((MemberInfo)fieldInfo, (Type)_47A41DC700494DA4(typeof(DescriptionAttribute).TypeHandle)) as DescriptionAttribute;
				return ((obj != null) ? _87EB3E1A42D94BB9((object)obj) : null) ?? text;
			}
			}
			break;
		}
		goto IL_0006;
		IL_0163:
		type = (Type)_128B9E8CD6974A6E((object)P_0);
		num = -1647610221;
		goto IL_000b;
	}

	static object _128B9E8CD6974A6E(object P_0)
	{
		return P_0.GetType();
	}

	static string _5B26F6BB01724984(Type P_0, object P_1)
	{
		return Enum.GetName(P_0, P_1);
	}

	static string B9E8CD9D46F84AE8(object P_0)
	{
		return P_0.ToString();
	}

	static object _5A737DF753864191(object P_0, string P_1)
	{
		return ((Type)P_0).GetField(P_1);
	}

	static bool E2311A4AAF11402E(FieldInfo P_0, FieldInfo P_1)
	{
		return P_0 == P_1;
	}

	static object _47A41DC700494DA4(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object B6864A9A7C1541E7(MemberInfo P_0, Type P_1)
	{
		return Attribute.GetCustomAttribute(P_0, P_1);
	}

	static string _87EB3E1A42D94BB9(object P_0)
	{
		return ((DescriptionAttribute)P_0).Description;
	}
}
