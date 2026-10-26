using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class _0792EF88277943B4 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid _72469C65518B4C6D;

	public Guid _654C0D86A9DB4214
	{
		[CompilerGenerated]
		get
		{
			return _72469C65518B4C6D;
		}
		[CompilerGenerated]
		set
		{
			_72469C65518B4C6D = guid;
		}
	}

	public _0792EF88277943B4()
	{
	}

	public _0792EF88277943B4(Guid P_0)
	{
		_83450C3519B64403((object)this, P_0);
	}

	public virtual void B2F3085DD1CA4390(BinaryWriter P_0)
	{
		_5BBDA55DF6E84561((object)P_0, _51A52828395C4EAD((object)this).ToString());
	}

	public virtual void _1045591169234EC0(BinaryReader P_0)
	{
	}

	static void _83450C3519B64403(object P_0, Guid P_1)
	{
		((_0792EF88277943B4)P_0)._654C0D86A9DB4214 = P_1;
	}

	static Guid _51A52828395C4EAD(object P_0)
	{
		return ((_0792EF88277943B4)P_0)._654C0D86A9DB4214;
	}

	static void _5BBDA55DF6E84561(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string B3A1D613110E4A71(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
