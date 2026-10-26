using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

internal static class D303E6A3CA8C49F1
{
	[ThreadStatic]
	private static MemoryStream? F37AAAA412CA41D7;

	[ThreadStatic]
	private static BinaryWriter? DA254276B7B54803;

	private const int _1ADFED9720BD44D0 = 1048576;

	private const int _7A40806E48A347B3 = 4096;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ArraySegment<byte> E2A3D410DBAC4E3A(_652C34B1E6554F10 P_0, _59751E20330E4047 P_1, bool P_2)
	{
		GC.KeepAlive(null);
		return default;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] _8B6A8B6A45874AD1(_652C34B1E6554F10 P_0, _59751E20330E4047 P_1, bool P_2)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3855796404u);
		ArraySegment<byte> arraySegment = _9D9B83A712664B38(P_0, P_1, P_2);
		byte[] array = new byte[arraySegment.Count];
		_84F0DD1CB0684621((Array)arraySegment.Array, arraySegment.Offset, (Array)array, _003CModule_003E._3F57E81A62734AC2<int>((int)(0x26CA2172 ^ obj._184044A093C04AF2(8, 2367842565u))), arraySegment.Count);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static _652C34B1E6554F10 C83C8FBFA0384358(byte[] P_0, _59751E20330E4047 P_1, out bool P_2)
	{
		GC.KeepAlive(null);
		return null;
	}

	static int _36030A7EF71843B4(_59751E20330E4047 P_0, _652C34B1E6554F10 P_1)
	{
		return FE504B49A4DA4B00._7DAFE9A595F34D03(P_0, P_1);
	}

	static object _6A7D9BA8ECFC4DF3(object P_0)
	{
		return P_0.GetType();
	}

	static string _97EFFAFD5F7C43B1(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	static string _9AE3E85402EE4EF1(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static object _747D1A0AB2454F45(string P_0)
	{
		return new InvalidOperationException(P_0);
	}

	static int _8347FC956D1A4041(object P_0)
	{
		return ((MemoryStream)P_0).Capacity;
	}

	void _7B91F3448E524915()
	{
		((BinaryWriter)this).Dispose();
	}

	static object D03DB13877964667(int P_0)
	{
		return new MemoryStream(P_0);
	}

	static object ADB37DAACD3F4BA8()
	{
		return Encoding.UTF8;
	}

	static object _567FBBD865F749D6(object P_0, object P_1, bool P_2)
	{
		return new BinaryWriter((Stream)P_0, (Encoding)P_1, P_2);
	}

	static void DAF651182BDC4A65(object P_0, long P_1)
	{
		((Stream)P_0).SetLength(P_1);
	}

	static void C257A3905F2C42E7(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	static void ACB6DFDAB9E848EA(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static byte _34385E46A0CF4D4E(object P_0)
	{
		return ((_652C34B1E6554F10)P_0)._1F2EDFE19FDC44F7;
	}

	static void _04BCD9A8611A4846(object P_0, byte P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static long _80EED1F09C054D02(object P_0)
	{
		return ((_652C34B1E6554F10)P_0).C4CF7218A3D4459F;
	}

	static void _753DB4091B8B4C26(object P_0, long P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static bool B016C01714C94AEF(object P_0)
	{
		return ((_652C34B1E6554F10)P_0)._9B60B9CA08874C25;
	}

	static void AE66D99A94054929(object P_0, bool P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static void A7783E3DAEF64D28(object P_0, object P_1)
	{
		((_652C34B1E6554F10)P_0).BAC3FE443B90459D((BinaryWriter)P_1);
	}

	static void DCFA6336516147F7(object P_0)
	{
		((BinaryWriter)P_0).Flush();
	}

	static bool _04AD8EB160C14DC8(object P_0, ref ArraySegment<byte> P_1)
	{
		return ((MemoryStream)P_0).TryGetBuffer(out P_1);
	}

	static byte[] _233086BA35624E32(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	static ArraySegment<byte> _9D9B83A712664B38(_652C34B1E6554F10 P_0, _59751E20330E4047 P_1, bool P_2)
	{
		return E2A3D410DBAC4E3A(P_0, P_1, P_2);
	}

	static void _84F0DD1CB0684621(Array P_0, int P_1, Array P_2, int P_3, int P_4)
	{
		Buffer.BlockCopy(P_0, P_1, P_2, P_3, P_4);
	}

	static object _144139E4077D480E(byte[] P_0)
	{
		return new MemoryStream(P_0);
	}

	static object _86541DDB56ED46A1(object P_0, object P_1, bool P_2)
	{
		return new BinaryReader((Stream)P_0, (Encoding)P_1, P_2);
	}

	static int _4D54F80A95F244E1(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	static byte CBA1DB782E664A7F(object P_0)
	{
		return ((BinaryReader)P_0).ReadByte();
	}

	static long _7CF2D753C0FB4378(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt64();
	}

	static bool _64F4B4CE5F974857(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}

	static object _9442D63EFE27488E(_59751E20330E4047 P_0, int P_1)
	{
		return FE504B49A4DA4B00.C0A813A46BBB4B7C(P_0, P_1);
	}

	static string _555A29C174D34F7D(string P_0, object P_1, object P_2, object P_3)
	{
		return string.Format(P_0, P_1, P_2, P_3);
	}

	static void F4FBD9A1BE22441C(object P_0, byte P_1)
	{
		((_652C34B1E6554F10)P_0)._167F9F1911004A0F = P_1;
	}

	static void F5BAD49313CB423E(object P_0, long P_1)
	{
		((_652C34B1E6554F10)P_0).C4CF7218A3D4459F = P_1;
	}

	static void _41F81072884A4CBE(object P_0, bool P_1)
	{
		((_652C34B1E6554F10)P_0)._9B60B9CA08874C25 = P_1;
	}

	static void D9A6D551027F4FBB(object P_0, object P_1)
	{
		((_652C34B1E6554F10)P_0).E6ED68732E8C40AC((BinaryReader)P_1);
	}

	static void C7D6587C2E1E4DFD(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
