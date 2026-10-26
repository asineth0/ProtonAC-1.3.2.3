using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class _51EFED4AA5044AFA : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid _8C7A4345A8DB4D87;

	[CompilerGenerated]
	private string _1151B8ED658D40F2;

	public Guid _600D5B95D5204733
	{
		[CompilerGenerated]
		get
		{
			return _8C7A4345A8DB4D87;
		}
		[CompilerGenerated]
		set
		{
			_8C7A4345A8DB4D87 = guid;
		}
	}

	public string _70CAF4ABA8E944B6
	{
		[CompilerGenerated]
		get
		{
			return _1151B8ED658D40F2;
		}
		[CompilerGenerated]
		set
		{
			_1151B8ED658D40F2 = text;
		}
	}

	public _51EFED4AA5044AFA()
	{
	}

	public _51EFED4AA5044AFA(Guid P_0, string P_1)
	{
		_26A4FE6BA48A4518((object)this, P_0);
		_01FDE80BDE6A4CCF((object)this, P_1);
	}

	public virtual void _68631111CF584299(BinaryWriter P_0)
	{
		_2AD9741D9029464A((object)P_0, FC026ACC97F9418D((object)this).ToString());
		_2AD9741D9029464A((object)P_0, BC46A97EA003445A((object)this));
	}

	public virtual void _9AD97F27BF64456A(BinaryReader P_0)
	{
		_26A4FE6BA48A4518((object)this, Guid.Parse(_3B627C19B5FB4661((object)P_0)));
		while (true)
		{
			int num = -803372765;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((0x410CAB90 ^ 0x69848040) - ~((((num2 - (~((unchecked(-1854441058 - 920094918) + -534957537 - (-2074596473 ^ 0x51E621E9)) ^ -6121950 ^ ~(0x10AF7597 ^ (--2038810479 - -1915926415))) - (--1029080735 ^ (unchecked(1977907173 * unchecked(607131057 * ~1957395821)) - (-(-427589939 - 1469036588) - (-1038574742 - unchecked(1206821079 * -807801025))) + ~(~(~(-1698905904 ^ 0x4DCCFD5C))))))) * -24854339 - (117070875 + ~(~(-(-500904457 ^ 0x58A2AE79))))) ^ 0x6138A564) - (0x661F4F39 ^ -1922852197) * -912826781) - 1935639761)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_011f;
				case 1u:
					return;
				}
				break;
				IL_011f:
				_01FDE80BDE6A4CCF((object)this, _3B627C19B5FB4661((object)P_0));
				num = ((int)num3 * -44808701) ^ -1643266786;
			}
		}
	}

	static void _26A4FE6BA48A4518(object P_0, Guid P_1)
	{
		((_51EFED4AA5044AFA)P_0)._600D5B95D5204733 = P_1;
	}

	static void _01FDE80BDE6A4CCF(object P_0, string P_1)
	{
		((_51EFED4AA5044AFA)P_0)._70CAF4ABA8E944B6 = P_1;
	}

	static Guid FC026ACC97F9418D(object P_0)
	{
		return ((_51EFED4AA5044AFA)P_0)._600D5B95D5204733;
	}

	static void _2AD9741D9029464A(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string BC46A97EA003445A(object P_0)
	{
		return ((_51EFED4AA5044AFA)P_0)._70CAF4ABA8E944B6;
	}

	static string _3B627C19B5FB4661(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
