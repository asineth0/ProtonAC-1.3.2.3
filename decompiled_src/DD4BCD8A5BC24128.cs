using System.IO;
using System.Runtime.CompilerServices;

internal class DD4BCD8A5BC24128 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string _7707E04A87174D5D;

	[CompilerGenerated]
	private string _553A347881BF4BEA;

	public string _0A743B1B41F74FBE
	{
		[CompilerGenerated]
		get
		{
			return _7707E04A87174D5D;
		}
		[CompilerGenerated]
		set
		{
			_7707E04A87174D5D = text;
		}
	}

	public string FA6CD948C0A549E3
	{
		[CompilerGenerated]
		get
		{
			return _553A347881BF4BEA;
		}
		[CompilerGenerated]
		set
		{
			_553A347881BF4BEA = text;
		}
	}

	public DD4BCD8A5BC24128()
	{
	}

	public DD4BCD8A5BC24128(string P_0, string P_1)
	{
		F97B91457AF8459C((object)this, P_0);
		C107670D5DBD46E3((object)this, P_1);
	}

	public virtual void F0C6B8D08F55443E(BinaryWriter P_0)
	{
		F8DC8BC910294E26((object)P_0, _669C6378CFB041DE((object)this));
		while (true)
		{
			int num = -719684325;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((2129868470 + unchecked(1573599988 - unchecked(unchecked(-202693601 * unchecked(322778006 * -51255473)) * -1360738437)) - num2 * -97798253) ^ (486045302 - (-229837415 + -(--1663455774)) + -221546161 * (-(~2145087181) - -(1148917363 - 1597199706)))))) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0084;
				case 0u:
					return;
				}
				break;
				IL_0084:
				F8DC8BC910294E26((object)P_0, C0CB6B8F1A854338((object)this));
				num = (int)(num3 * 1289310294) ^ -2000273353;
			}
		}
	}

	public virtual void BBB15C7619D84450(BinaryReader P_0)
	{
		F97B91457AF8459C((object)this, _8A7F777D4C944AF0((object)P_0));
		while (true)
		{
			int num = -2076552841;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(472414846 - ~(-(~((-544724915 ^ 0x13EAF389) + unchecked(-999665792 - 1277147171))) - ~((num2 * -786275795) ^ (0x19BB1868 ^ (-(~-333641540) * -1487154379))) + (-2075464446 ^ 0x436505D0)) * -1405685389)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_009e;
				case 2u:
					return;
				}
				break;
				IL_009e:
				C107670D5DBD46E3((object)this, _8A7F777D4C944AF0((object)P_0));
				num = ((int)num3 * -1456171114) ^ 0x42A6B9DE;
			}
		}
	}

	static void F97B91457AF8459C(object P_0, string P_1)
	{
		((DD4BCD8A5BC24128)P_0)._0A743B1B41F74FBE = P_1;
	}

	static void C107670D5DBD46E3(object P_0, string P_1)
	{
		((DD4BCD8A5BC24128)P_0).FA6CD948C0A549E3 = P_1;
	}

	static string _669C6378CFB041DE(object P_0)
	{
		return ((DD4BCD8A5BC24128)P_0)._0A743B1B41F74FBE;
	}

	static void F8DC8BC910294E26(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string C0CB6B8F1A854338(object P_0)
	{
		return ((DD4BCD8A5BC24128)P_0).FA6CD948C0A549E3;
	}

	static string _8A7F777D4C944AF0(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
