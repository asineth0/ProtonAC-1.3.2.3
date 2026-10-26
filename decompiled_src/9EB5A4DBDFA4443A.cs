using System.IO;
using System.Runtime.CompilerServices;

internal class _9EB5A4DBDFA4443A : _652C34B1E6554F10
{
	[CompilerGenerated]
	private byte[] _45CCA4C592DF449B;

	public byte[] _39D8E3C3A71E4939
	{
		[CompilerGenerated]
		get
		{
			return _45CCA4C592DF449B;
		}
		[CompilerGenerated]
		set
		{
			_45CCA4C592DF449B = array;
		}
	}

	public _9EB5A4DBDFA4443A()
	{
	}

	public _9EB5A4DBDFA4443A(byte[] P_0)
	{
		F78925A7C8D042D3((object)this, P_0);
	}

	public virtual void E8FFB79D1BC14293(BinaryWriter P_0)
	{
		_726EED57888943E7((object)P_0, _7C9046097A6C47D9((object)this).Length);
		_67E777BB682D445B((object)P_0, _7C9046097A6C47D9((object)this));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _018724327D4C4824(BinaryReader P_0)
	{
		_1E81047E99BD4EDD((object)P_0);
		_1DDD03DAC9404604((object)P_0, 0);
		F78925A7C8D042D3((object)this, (byte[])null);
	}

	static void F78925A7C8D042D3(object P_0, byte[] P_1)
	{
		((_9EB5A4DBDFA4443A)P_0)._39D8E3C3A71E4939 = P_1;
	}

	static byte[] _7C9046097A6C47D9(object P_0)
	{
		return ((_9EB5A4DBDFA4443A)P_0)._39D8E3C3A71E4939;
	}

	static void _726EED57888943E7(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static void _67E777BB682D445B(object P_0, byte[] P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static int _1E81047E99BD4EDD(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	static byte[] _1DDD03DAC9404604(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}
}
