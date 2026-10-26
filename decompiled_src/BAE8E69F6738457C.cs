using System.IO;
using System.Runtime.CompilerServices;

internal class BAE8E69F6738457C : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string D43834A5EA2F41C0;

	public string F329A04158A84794
	{
		[CompilerGenerated]
		get
		{
			return D43834A5EA2F41C0;
		}
		[CompilerGenerated]
		set
		{
			D43834A5EA2F41C0 = d43834A5EA2F41C;
		}
	}

	public BAE8E69F6738457C()
	{
	}

	public BAE8E69F6738457C(string P_0)
	{
		D8277891BA514189((object)this, P_0);
	}

	public virtual void _44EBFA30CAF440B2(BinaryWriter P_0)
	{
		_36976E04AECE4955((object)P_0, _98AD24B3060549A5((object)this));
	}

	public virtual void _50AEEEA02B924473(BinaryReader P_0)
	{
		D8277891BA514189((object)this, D4A70F93C4DD4B07((object)P_0));
	}

	static void D8277891BA514189(object P_0, string P_1)
	{
		((BAE8E69F6738457C)P_0).F329A04158A84794 = P_1;
	}

	static string _98AD24B3060549A5(object P_0)
	{
		return ((BAE8E69F6738457C)P_0).F329A04158A84794;
	}

	static void _36976E04AECE4955(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string D4A70F93C4DD4B07(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
