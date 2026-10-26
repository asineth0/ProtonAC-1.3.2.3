using System;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

internal static class _635EDF414A0B480B
{
	private const int _5C07A86751E54AAE = 12;

	private const int _88ED49B7338245C0 = 16;

	private static readonly SecureRandom B23EC9D1C57D4A6A = (SecureRandom)_249A957328CF4CE2();

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] BF68416E6CE14953(byte[] P_0, byte[] P_1)
	{
		return _4EAC363705494A06(P_0, _003CModule_003E._390073C602714496<int>((int)(0x4BF36C7D ^ new _81DD83B8AA2247AA(3147083166u)._184044A093C04AF2(4, 1329311135u))), P_0.Length, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] _51BF5B35C33D48FF(byte[] P_0, int P_1, int P_2, byte[] P_3)
	{
		GC.KeepAlive(null);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] _91EA18E0A4CE4C82(byte[] P_0, byte[] P_1)
	{
		_46A7056FF6104E82(P_0, 0, 0, P_1);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] _95DB8685DB6E479C(byte[] P_0, int P_1, int P_2, byte[] P_3)
	{
		GC.KeepAlive(null);
		return null;
	}

	static byte[] _4EAC363705494A06(byte[] P_0, int P_1, int P_2, byte[] P_3)
	{
		return _51BF5B35C33D48FF(P_0, P_1, P_2, P_3);
	}

	static object _6EB92129F13D4BF6(string P_0)
	{
		return new ArgumentNullException(P_0);
	}

	static object _1E04411B03A543EC(string P_0, string P_1)
	{
		return new ArgumentOutOfRangeException(P_0, P_1);
	}

	static void A7DD1AD94D624447(object P_0, byte[] P_1)
	{
		((Random)P_0).NextBytes(P_1);
	}

	static object E4CCE6524FBB487F()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return (object)new AesEngine();
	}

	static object E284D1BC16924AA8(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object)new GcmBlockCipher((IBlockCipher)P_0);
	}

	static object _96E92789EC224422(byte[] P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object)new KeyParameter(P_0);
	}

	static object _6B65D404CEDB43CD(object P_0, int P_1, byte[] P_2, byte[] P_3)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected Obj, but got Unknown
		return (object)new AeadParameters((KeyParameter)P_0, P_1, P_2, P_3);
	}

	static void _8E526FF03DD54532(object P_0, bool P_1, object P_2)
	{
		((GcmBlockCipher)P_0).Init(P_1, (ICipherParameters)P_2);
	}

	static int _66E7CCC2735C4766(object P_0, int P_1)
	{
		return ((GcmBlockCipher)P_0).GetOutputSize(P_1);
	}

	static void _3DD12EADBA8841E2(Array P_0, int P_1, Array P_2, int P_3, int P_4)
	{
		Buffer.BlockCopy(P_0, P_1, P_2, P_3, P_4);
	}

	static int D6C4FEFAF463435E(object P_0, byte[] P_1, int P_2, int P_3, byte[] P_4, int P_5)
	{
		return 0;
	}

	static int _3C9E8444E66E4C7D(object P_0, byte[] P_1, int P_2)
	{
		return ((GcmBlockCipher)P_0).DoFinal(P_1, P_2);
	}

	static byte[] _46A7056FF6104E82(byte[] P_0, int P_1, int P_2, byte[] P_3)
	{
		return _95DB8685DB6E479C(P_0, P_1, P_2, P_3);
	}

	static object _4D4ACAAE320E45CA(string P_0, string P_1)
	{
		return new ArgumentException(P_0, P_1);
	}

	static object _249A957328CF4CE2()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return (object)new SecureRandom();
	}
}
