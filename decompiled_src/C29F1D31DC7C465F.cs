using System.IO;
using System.Runtime.CompilerServices;

internal class C29F1D31DC7C465F : _652C34B1E6554F10
{
	[CompilerGenerated]
	private ulong F1A09E851E744DB1;

	[CompilerGenerated]
	private string _7CF9808DC99649A4;

	public ulong _459F3072FA1A4B78
	{
		[CompilerGenerated]
		get
		{
			return F1A09E851E744DB1;
		}
		[CompilerGenerated]
		set
		{
			F1A09E851E744DB1 = f1A09E851E744DB;
		}
	}

	public string _45A6C567243A4C24
	{
		[CompilerGenerated]
		get
		{
			return _7CF9808DC99649A4;
		}
		[CompilerGenerated]
		set
		{
			_7CF9808DC99649A4 = text;
		}
	}

	public C29F1D31DC7C465F()
	{
	}

	public C29F1D31DC7C465F(ulong P_0, string P_1)
	{
		_787934C200114053((object)this, P_0);
		_04EF97F36B67427A((object)this, P_1);
	}

	public virtual void _3A6F980D78514298(BinaryWriter P_0)
	{
		_5FF19D31CFDD41A5((object)P_0, FE6E9144871C4F2A((object)this));
		while (true)
		{
			int num = 2146430538;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~(~(((num2 - (~(-(-(1560084245 - -42118262 + (745168788 - 1182358319)) + 1956095984)) + (unchecked((~unchecked(unchecked(1803019546 * 1042326439) + (1886987556 - 582377537)) - unchecked(-1638914728 + (-1830955355 ^ 0x4E59D30C))) * -1184533543) + ((-(-(1137621833 + -1448398652)) * 1460856877) ^ -1091198060)))) * 2030561155) ^ ~(~(--2043754680 + 2129851139 + (unchecked(-1613943811 + -980569509) - (1981643452 - 2046974621)))))) ^ 0x1F5BE898) * -723689545)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_00fb;
				case 1u:
					return;
				}
				break;
				IL_00fb:
				_2A65FB31087144DA((object)P_0, _498A9E9A9CA94C99((object)this));
				num = ((int)num3 * -1226068379) ^ -966806299;
			}
		}
	}

	public virtual void CA63E1AEC0AF4A26(BinaryReader P_0)
	{
		_787934C200114053((object)this, FBC3F5E953DF42AC((object)P_0));
		while (true)
		{
			int num = 1227871154;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-((num2 ^ (-1643924341 * (~(-505819371 * ~(-(0x17923F42 ^ -742809781))) ^ 0x55DCBB44))) - ~(~-459153205 + (-1440128637 ^ -(-1572008494 - ~-402856474)))))) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_007b;
				case 1u:
					return;
				}
				break;
				IL_007b:
				_04EF97F36B67427A((object)this, BF5B0D6D9E0540ED((object)P_0));
				num = (int)((num3 * 76336838) ^ 0x5141DBE2);
			}
		}
	}

	static void _787934C200114053(object P_0, ulong P_1)
	{
		((C29F1D31DC7C465F)P_0)._459F3072FA1A4B78 = P_1;
	}

	static void _04EF97F36B67427A(object P_0, string P_1)
	{
		((C29F1D31DC7C465F)P_0)._45A6C567243A4C24 = P_1;
	}

	static ulong FE6E9144871C4F2A(object P_0)
	{
		return ((C29F1D31DC7C465F)P_0)._459F3072FA1A4B78;
	}

	static void _5FF19D31CFDD41A5(object P_0, ulong P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _498A9E9A9CA94C99(object P_0)
	{
		return ((C29F1D31DC7C465F)P_0)._45A6C567243A4C24;
	}

	static void _2A65FB31087144DA(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static ulong FBC3F5E953DF42AC(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt64();
	}

	static string BF5B0D6D9E0540ED(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
