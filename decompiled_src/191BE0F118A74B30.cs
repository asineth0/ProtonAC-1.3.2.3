using System.IO;
using System.Runtime.CompilerServices;

internal class _191BE0F118A74B30 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string FB1290D3FF30430E;

	public string E5D1D848B0664329
	{
		[CompilerGenerated]
		get
		{
			return FB1290D3FF30430E;
		}
		[CompilerGenerated]
		set
		{
			FB1290D3FF30430E = fB1290D3FF30430E;
		}
	}

	public _191BE0F118A74B30()
	{
	}

	public _191BE0F118A74B30(string P_0)
	{
		B575F390A3A24DCC((object)this, P_0);
	}

	public virtual void CC072CB396984C60(BinaryWriter P_0)
	{
		_0BA4F6726B264579((object)P_0, _3BAB9B5CB6CE468C((object)this));
	}

	public virtual void _814ACDBA0FF64BEB(BinaryReader P_0)
	{
		B575F390A3A24DCC((object)this, _0EE9C54C70D144D6((object)P_0));
	}

	static void B575F390A3A24DCC(object P_0, string P_1)
	{
		((_191BE0F118A74B30)P_0).E5D1D848B0664329 = P_1;
	}

	static string _3BAB9B5CB6CE468C(object P_0)
	{
		return ((_191BE0F118A74B30)P_0).E5D1D848B0664329;
	}

	static void _0BA4F6726B264579(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _0EE9C54C70D144D6(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
