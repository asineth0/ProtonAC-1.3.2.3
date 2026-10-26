using System.IO;
using System.Runtime.CompilerServices;

internal class _7C3933FE2CD94926 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string DFF1935B457E4A0F;

	[CompilerGenerated]
	private string _3CC4D2B435D84208;

	[CompilerGenerated]
	private string _5B755E8C761D4006;

	public string EC9A38F0433042C8
	{
		[CompilerGenerated]
		get
		{
			return DFF1935B457E4A0F;
		}
		[CompilerGenerated]
		set
		{
			DFF1935B457E4A0F = dFF1935B457E4A0F;
		}
	}

	public string _69B42B2ACA6F4E1E
	{
		[CompilerGenerated]
		get
		{
			return _3CC4D2B435D84208;
		}
		[CompilerGenerated]
		set
		{
			_3CC4D2B435D84208 = text;
		}
	}

	public string F01DA256AA6943BA
	{
		[CompilerGenerated]
		get
		{
			return _5B755E8C761D4006;
		}
		[CompilerGenerated]
		set
		{
			_5B755E8C761D4006 = text;
		}
	}

	public _7C3933FE2CD94926()
	{
	}

	public _7C3933FE2CD94926(string P_0, string P_1, string P_2)
	{
		_3D792B0E2514494F((object)this, P_0);
		_14E4C4A1EB64422F((object)this, P_1);
		_6160851D63694EBC((object)this, P_2);
	}

	public virtual void F94FD3247D224242(BinaryWriter P_0)
	{
		EBCB49B0D1594F43((object)P_0, _67FB3746D8564447((object)this));
		while (true)
		{
			int num = -83121618;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((num2 - 1503695419 * (((~(-19246573 ^ -1144170784) - (-(-290936933 + -843249347) + ~(1799585580 + -522990291))) ^ -(-(632511428 + -1099923731) * -15117209)) * -1801457603)) * -808949577 * -411368565))) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0085;
				case 1u:
					return;
				}
				break;
				IL_0085:
				EBCB49B0D1594F43((object)P_0, C195BCD4CDA4470D((object)this));
				EBCB49B0D1594F43((object)P_0, DBD73862E9BB4E2D((object)this));
				num = (int)(num3 * 23023893) ^ -2052254006;
			}
		}
	}

	public virtual void _42C08C06271642F1(BinaryReader P_0)
	{
		_4B2D69C3C0BE4953((object)P_0);
		_4B2D69C3C0BE4953((object)this);
		_4B2D69C3C0BE4953((object)P_0);
		_4B2D69C3C0BE4953((object)this);
		_4B2D69C3C0BE4953((object)P_0);
		_4B2D69C3C0BE4953((object)this);
	}

	static void _3D792B0E2514494F(object P_0, string P_1)
	{
		((_7C3933FE2CD94926)P_0).EC9A38F0433042C8 = P_1;
	}

	static void _14E4C4A1EB64422F(object P_0, string P_1)
	{
		((_7C3933FE2CD94926)P_0)._69B42B2ACA6F4E1E = P_1;
	}

	static void _6160851D63694EBC(object P_0, string P_1)
	{
		((_7C3933FE2CD94926)P_0).F01DA256AA6943BA = P_1;
	}

	static string _67FB3746D8564447(object P_0)
	{
		return ((_7C3933FE2CD94926)P_0).EC9A38F0433042C8;
	}

	static void EBCB49B0D1594F43(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string C195BCD4CDA4470D(object P_0)
	{
		return ((_7C3933FE2CD94926)P_0)._69B42B2ACA6F4E1E;
	}

	static string DBD73862E9BB4E2D(object P_0)
	{
		return ((_7C3933FE2CD94926)P_0).F01DA256AA6943BA;
	}

	static string _4B2D69C3C0BE4953(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
