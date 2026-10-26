using System.IO;
using System.Runtime.CompilerServices;

internal class D540FD5E7F8F45F5 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string B0E938F17C2C4D92;

	public string _48EF518AEC5A4D2B
	{
		[CompilerGenerated]
		get
		{
			return B0E938F17C2C4D92;
		}
		[CompilerGenerated]
		set
		{
			B0E938F17C2C4D92 = b0E938F17C2C4D;
		}
	}

	public D540FD5E7F8F45F5()
	{
	}

	public D540FD5E7F8F45F5(string P_0)
	{
		while (true)
		{
			int num = 1298949629;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~unchecked(280351981 * ~-162027301) - (~unchecked(1714277110 * -603084831) - -1086435423) - -((-(unchecked(1913533551 * unchecked((~(-1498384502 - -1732956683) - (-840449804 - ~1097378258)) * 309751775)) - -741382551 * ((0x992F42E ^ -1531280659) - (-2114788268 - ~(~-2006456547)))) - num2) ^ ~(-(--517181222 + ~1535432950 - (-823834049 ^ --1549738475)) + -(-(-2063954435 ^ -990403295))))))) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_00e5;
				case 1u:
					return;
				}
				break;
				IL_00e5:
				_3BEE597276A44B27((object)this, P_0);
				num = (int)((num3 * 2016636063) ^ 0x575E42EF);
			}
		}
	}

	public virtual void _90203E37BC1948A0(BinaryWriter P_0)
	{
		_86FF172751E640AB((object)P_0, C9738917D3774F9C((object)this));
	}

	public virtual void _3F03291610104EEA(BinaryReader P_0)
	{
		_3BEE597276A44B27((object)this, BC7FA4B9711545AD((object)P_0));
	}

	static void _3BEE597276A44B27(object P_0, string P_1)
	{
		((D540FD5E7F8F45F5)P_0)._48EF518AEC5A4D2B = P_1;
	}

	static string C9738917D3774F9C(object P_0)
	{
		return ((D540FD5E7F8F45F5)P_0)._48EF518AEC5A4D2B;
	}

	static void _86FF172751E640AB(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string BC7FA4B9711545AD(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
