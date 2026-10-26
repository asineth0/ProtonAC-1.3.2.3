using System.IO;
using System.Runtime.CompilerServices;

internal class C44631BE80E84975 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private long A6C6DCD2FDC5476F;

	public long _3BBDA9196A4948DC
	{
		[CompilerGenerated]
		get
		{
			return A6C6DCD2FDC5476F;
		}
		[CompilerGenerated]
		set
		{
			A6C6DCD2FDC5476F = a6C6DCD2FDC5476F;
		}
	}

	public C44631BE80E84975()
	{
	}

	public C44631BE80E84975(long P_0)
	{
		for (uint num = 1u; num == 1; num = 2u)
		{
			_4A8CD8E581B448C1((object)this, P_0);
		}
		_ = 2;
	}

	public virtual void _1BA6596640F64AC4(BinaryWriter P_0)
	{
		_85D46EEEB71646F1((object)this);
		_85D46EEEB71646F1((object)P_0);
	}

	public virtual void D425B66E00A84DF4(BinaryReader P_0)
	{
		_4A8CD8E581B448C1((object)this, _85D46EEEB71646F1((object)P_0));
	}

	static void _4A8CD8E581B448C1(object P_0, long P_1)
	{
		((C44631BE80E84975)P_0)._3BBDA9196A4948DC = P_1;
	}

	static long _244336AE301D4EB1(object P_0)
	{
		return ((C44631BE80E84975)P_0)._3BBDA9196A4948DC;
	}

	static void _5F7C8FD6B8F54CB0(object P_0, long P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static long _85D46EEEB71646F1(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt64();
	}
}
