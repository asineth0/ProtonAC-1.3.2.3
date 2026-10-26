using System.IO;
using System.Runtime.CompilerServices;

internal class _454E92A85D3D40C1 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string _2F0EE04097D7444F;

	[CompilerGenerated]
	private bool DF4D2DDF775347A4;

	public string E149ED25C3F24C37
	{
		[CompilerGenerated]
		get
		{
			return _2F0EE04097D7444F;
		}
		[CompilerGenerated]
		set
		{
			_2F0EE04097D7444F = text;
		}
	}

	public bool _6F948741F6564E7C
	{
		[CompilerGenerated]
		get
		{
			return DF4D2DDF775347A4;
		}
		[CompilerGenerated]
		set
		{
			DF4D2DDF775347A4 = dF4D2DDF775347A;
		}
	}

	public _454E92A85D3D40C1()
	{
	}

	public _454E92A85D3D40C1(string P_0, bool P_1)
	{
		_1D4A28F3AADF4360((object)this, P_0);
		E70653E129C345BF((object)this, P_1);
	}

	public virtual void B6BC9D08D76148C6(BinaryWriter P_0)
	{
		_5197EF243F7F49BC((object)P_0, FEBD3846C13F4318((object)this));
		_3471C0FFA20D410F((object)P_0, CBCA5F2727894E97((object)this));
	}

	public virtual void _7AFB555E27C04DA0(BinaryReader P_0)
	{
		_1D4A28F3AADF4360((object)this, _46D6F7D733B54902((object)P_0));
		while (true)
		{
			int num = -149077972;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~(~(~(~num2) ^ (~((unchecked(-1224210089 * 727489886) + --1455610294) ^ ~(-1180144707)) - (-(-(-1201466454)) ^ 0x6D8D25D0)) ^ (1590419639 * --702761379))) + unchecked(376637838 * 4649057)) ^ 0x8B5BCDA)) % 3)
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
				E70653E129C345BF((object)this, _764DBA11CDAC4DA4((object)P_0));
				num = ((int)num3 * -1083575559) ^ -731752584;
			}
		}
	}

	static void _1D4A28F3AADF4360(object P_0, string P_1)
	{
		((_454E92A85D3D40C1)P_0).E149ED25C3F24C37 = P_1;
	}

	static void E70653E129C345BF(object P_0, bool P_1)
	{
		((_454E92A85D3D40C1)P_0)._6F948741F6564E7C = P_1;
	}

	static string FEBD3846C13F4318(object P_0)
	{
		return ((_454E92A85D3D40C1)P_0).E149ED25C3F24C37;
	}

	static void _5197EF243F7F49BC(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static bool CBCA5F2727894E97(object P_0)
	{
		return ((_454E92A85D3D40C1)P_0)._6F948741F6564E7C;
	}

	static void _3471C0FFA20D410F(object P_0, bool P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _46D6F7D733B54902(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static bool _764DBA11CDAC4DA4(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}
}
