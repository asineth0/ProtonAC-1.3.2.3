using System.IO;
using System.Runtime.CompilerServices;

internal class _64EE58BE0EEA42DE : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string A3846FF36B7442C0;

	public string _04FEFB883BDE4123
	{
		[CompilerGenerated]
		get
		{
			return A3846FF36B7442C0;
		}
		[CompilerGenerated]
		set
		{
			A3846FF36B7442C0 = a3846FF36B7442C;
		}
	}

	public _64EE58BE0EEA42DE()
	{
	}

	public _64EE58BE0EEA42DE(string P_0)
	{
		while (true)
		{
			int num = -677092851;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~num2) ^ ((0x7DAF7C18 ^ -unchecked(1750608991 * -1155056569)) + ~(~1033924669) - (--1817436599 + (0x507667C5 ^ -906050942) - ~1901320919 - ((-1988615822 ^ -1889504849) - ~(-200822615 + -1023475808)))))) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0080;
				case 0u:
					return;
				}
				break;
				IL_0080:
				_64AF382BE0C34A01((object)this, P_0);
				num = (int)((num3 * 977237735) ^ 0x2539A6);
			}
		}
	}

	public virtual void FD0F948071074DD4(BinaryWriter P_0)
	{
		_8EC872196317476D((object)P_0, _679D4CB806044073((object)this));
	}

	public virtual void D89BA058207E47C9(BinaryReader P_0)
	{
		_64AF382BE0C34A01((object)this, _88BCF27718FE4B87((object)P_0));
	}

	static void _64AF382BE0C34A01(object P_0, string P_1)
	{
		((_64EE58BE0EEA42DE)P_0)._04FEFB883BDE4123 = P_1;
	}

	static string _679D4CB806044073(object P_0)
	{
		return ((_64EE58BE0EEA42DE)P_0)._04FEFB883BDE4123;
	}

	static void _8EC872196317476D(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _88BCF27718FE4B87(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
