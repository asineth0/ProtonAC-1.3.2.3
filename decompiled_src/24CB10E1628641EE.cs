using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class _24CB10E1628641EE : _652C34B1E6554F10
{
	[CompilerGenerated]
	private bool _04029D2F088E4EB3;

	[CompilerGenerated]
	private bool ACC61946B8A54871;

	[CompilerGenerated]
	private Guid DD7EA11491894CAE;

	public bool D816EAA447FE4B09
	{
		[CompilerGenerated]
		get
		{
			return _04029D2F088E4EB3;
		}
		[CompilerGenerated]
		set
		{
			_04029D2F088E4EB3 = flag;
		}
	}

	public bool _2DBF90D5937C4020
	{
		[CompilerGenerated]
		get
		{
			return ACC61946B8A54871;
		}
		[CompilerGenerated]
		set
		{
			ACC61946B8A54871 = aCC61946B8A;
		}
	}

	public Guid E9202630FC09403B
	{
		[CompilerGenerated]
		get
		{
			return DD7EA11491894CAE;
		}
		[CompilerGenerated]
		set
		{
			DD7EA11491894CAE = dD7EA11491894CAE;
		}
	}

	public _24CB10E1628641EE()
	{
	}

	public _24CB10E1628641EE(bool P_0, bool P_1, Guid? P_2 = null)
	{
		_12ED42FFFB7F4842((object)this, P_0);
		_0BBF6079C8AA4F4D((object)this, P_1);
		CA002C90439C4707((object)this, P_2 ?? Guid.Empty);
	}

	public virtual void _1DF4F07A5AF0457E(BinaryWriter P_0)
	{
		_28A67803F72F4C29((object)P_0, C9042E67CE424C6E((object)this));
		_28A67803F72F4C29((object)P_0, _13399CA2B5114921((object)this));
		CFFBAFA56D6047F2((object)P_0, _10C382F04BC549B0((object)this).ToString());
	}

	public virtual void _1483C64BB2934DB0(BinaryReader P_0)
	{
		B9C234ECD19A45AA((object)P_0);
		_57AD0F04481847DB((object)P_0);
		uint num = 2u;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1u:
				CA002C90439C4707((object)this, default(Guid));
				return;
			case 2u:
				break;
			}
			_0BBF6079C8AA4F4D((object)this, false);
			num = 1u;
		}
	}

	static void _12ED42FFFB7F4842(object P_0, bool P_1)
	{
		((_24CB10E1628641EE)P_0).D816EAA447FE4B09 = P_1;
	}

	static void _0BBF6079C8AA4F4D(object P_0, bool P_1)
	{
		((_24CB10E1628641EE)P_0)._2DBF90D5937C4020 = P_1;
	}

	static void CA002C90439C4707(object P_0, Guid P_1)
	{
		((_24CB10E1628641EE)P_0).E9202630FC09403B = P_1;
	}

	static bool C9042E67CE424C6E(object P_0)
	{
		return ((_24CB10E1628641EE)P_0).D816EAA447FE4B09;
	}

	static void _28A67803F72F4C29(object P_0, bool P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static bool _13399CA2B5114921(object P_0)
	{
		return ((_24CB10E1628641EE)P_0)._2DBF90D5937C4020;
	}

	static Guid _10C382F04BC549B0(object P_0)
	{
		return ((_24CB10E1628641EE)P_0).E9202630FC09403B;
	}

	static void CFFBAFA56D6047F2(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static bool _57AD0F04481847DB(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}

	static string B9C234ECD19A45AA(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
