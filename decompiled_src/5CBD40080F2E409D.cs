using System.IO;
using System.Runtime.CompilerServices;

internal class _5CBD40080F2E409D : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string B403BAC4B65645F3;

	public string C6992C51938E46FD
	{
		[CompilerGenerated]
		get
		{
			return B403BAC4B65645F3;
		}
		[CompilerGenerated]
		set
		{
			B403BAC4B65645F3 = b403BAC4B65645F;
		}
	}

	public _5CBD40080F2E409D()
	{
	}

	public _5CBD40080F2E409D(string P_0)
	{
		_9383711015A545B0((object)this, P_0);
	}

	public virtual void _39FC76190B4D4E4E(BinaryWriter P_0)
	{
		D3854B333D2C482A((object)P_0, D9394C7DB9B44DB2((object)this));
	}

	public virtual void _0DE10D8EB8944649(BinaryReader P_0)
	{
		_9383711015A545B0((object)this, _91470BE322254335((object)P_0));
	}

	static void _9383711015A545B0(object P_0, string P_1)
	{
		((_5CBD40080F2E409D)P_0).C6992C51938E46FD = P_1;
	}

	static string D9394C7DB9B44DB2(object P_0)
	{
		return ((_5CBD40080F2E409D)P_0).C6992C51938E46FD;
	}

	static void D3854B333D2C482A(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _91470BE322254335(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
