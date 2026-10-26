using System;
using System.IO;
using System.Runtime.CompilerServices;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.OpenSsl;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.IO.Pem;

internal static class _59B50849A61D48E8
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] _1D0C0563561142FC(byte[] P_0, AsymmetricKeyParameter P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2047879555u);
		object obj2 = _315A7351645745E4(_9588845A455B4BEB());
		_8FF5EB17C8ED4974(obj2, (byte)_003CModule_003E._390073C602714496<int>((int)(0x55F70AE3 ^ obj._184044A093C04AF2(5, 1854404012u))) != 0, (object)P_1);
		return A520B7C7463148E3(obj2, P_0, _003CModule_003E._390073C602714496<int>((int)(0x83DF4C0 ^ obj._184044A093C04AF2(8, 3100647337u))), P_0.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] _901A5D89A68E419A(byte[] P_0, AsymmetricKeyParameter P_1)
	{
		_9588845A455B4BEB();
		_315A7351645745E4((object)null);
		A520B7C7463148E3((object)null, P_0, 0, 0);
		return null;
	}

	public static AsymmetricKeyParameter E5A3C953D3B34A0A(string P_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected Obj, but got Unknown
		StringReader stringReader = (StringReader)_9C796C4912534ED2(P_0);
		try
		{
			return (AsymmetricKeyParameter)A9C637A3CB144A47(_97511159E2C84AE0((object)stringReader));
		}
		finally
		{
			if (stringReader != null)
			{
				while (true)
				{
					IL_001d:
					int num = 1101444727;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(-num2) * -426505485)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0022;
						case 2u:
							goto IL_0043;
						case 1u:
							goto end_IL_0022;
						}
						goto IL_001d;
						IL_0043:
						_91C5F763740344AC((object)stringReader);
						num = (int)(num3 * 467781077) ^ -1020214222;
						continue;
						end_IL_0022:
						break;
					}
					break;
				}
			}
		}
	}

	public static AsymmetricKeyParameter _165FE3AE4F6E4675(string P_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected Obj, but got Unknown
		StringReader stringReader = (StringReader)_9C796C4912534ED2(P_0);
		try
		{
			return (AsymmetricKeyParameter)_3E8DFAA2CADE4B17((object)(AsymmetricCipherKeyPair)A9C637A3CB144A47(_97511159E2C84AE0((object)stringReader)));
		}
		finally
		{
			if (stringReader != null)
			{
				while (true)
				{
					IL_0022:
					int num = 1347875870;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-num2 * -872758711 - -(~(-(-(~1343407795)))))) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0027;
						case 1u:
							goto IL_0052;
						case 2u:
							goto end_IL_0027;
						}
						goto IL_0022;
						IL_0052:
						_91C5F763740344AC((object)stringReader);
						num = ((int)num3 * -111317835) ^ 0x1D3A502C;
						continue;
						end_IL_0027:
						break;
					}
					break;
				}
			}
		}
	}

	public static string E61F859DF1CC4C27(AsymmetricKeyParameter P_0)
	{
		_968DB9FA9E314CD3();
		_33E49763121C4F83((object)null);
		E853D2444C4440A2((object)null);
		FA8206A46DA74DDC((object)null);
		ECEC4ED7587F4E19((object)null, (object)P_0);
		_15B13C7340994B01(E853D2444C4440A2((object)null));
		_91C5F763740344AC((object)null);
		return null;
	}

	public static string _46485001B4CB49D8(AsymmetricKeyParameter P_0)
	{
		StringWriter stringWriter = (StringWriter)_968DB9FA9E314CD3();
		string result = default;
		try
		{
			object obj = _33E49763121C4F83((object)stringWriter);
			ECEC4ED7587F4E19(obj, (object)P_0);
			_15B13C7340994B01(E853D2444C4440A2(obj));
			while (true)
			{
				IL_001d:
				int num = -726539537;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(~(-(-num2)) * 628786397))) % 3)
					{
					case 2u:
						break;
					default:
						goto end_IL_0022;
					case 1u:
						goto IL_0045;
					case 0u:
						goto end_IL_0022;
					}
					goto IL_001d;
					IL_0045:
					result = FA8206A46DA74DDC((object)stringWriter);
					num = ((int)num3 * -75063359) ^ 0x1E4EB23E;
					continue;
					end_IL_0022:
					break;
				}
				break;
			}
		}
		finally
		{
			if (stringWriter != null)
			{
				while (true)
				{
					IL_0060:
					int num4 = 2115569844;
					while (true)
					{
						int num2 = num4;
						uint num3;
						switch ((num3 = (uint)(-(~(-(-num2)) * 628786397))) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_0065;
						case 1u:
							goto IL_0088;
						case 0u:
							goto end_IL_0065;
						}
						goto IL_0060;
						IL_0088:
						_91C5F763740344AC((object)stringWriter);
						num4 = ((int)num3 * -931814583) ^ -1751619466;
						continue;
						end_IL_0065:
						break;
					}
					break;
				}
			}
		}
		return result;
	}

	public static AsymmetricCipherKeyPair C73AB3465B8148AC(int P_0)
	{
		A9F59E891F204824();
		_5DFA7280E54E46EE();
		_6D3759D41F10410B((object)null, P_0);
		_0505AD17387E482C((object)null);
		_3D47249865AA4C01((object)null, (object)null);
		return null;
	}

	static object _9588845A455B4BEB()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return (object)new RsaEngine();
	}

	static object _315A7351645745E4(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object)new Pkcs1Encoding((IAsymmetricBlockCipher)P_0);
	}

	static void _8FF5EB17C8ED4974(object P_0, bool P_1, object P_2)
	{
		((Pkcs1Encoding)P_0).Init(P_1, (ICipherParameters)P_2);
	}

	static byte[] A520B7C7463148E3(object P_0, byte[] P_1, int P_2, int P_3)
	{
		return ((Pkcs1Encoding)P_0).ProcessBlock(P_1, P_2, P_3);
	}

	static object _9C796C4912534ED2(string P_0)
	{
		return new StringReader(P_0);
	}

	static object _97511159E2C84AE0(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object)new PemReader((TextReader)P_0);
	}

	static object A9C637A3CB144A47(object P_0)
	{
		return ((PemReader)P_0).ReadObject();
	}

	static void _91C5F763740344AC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static object _3E8DFAA2CADE4B17(object P_0)
	{
		return ((AsymmetricCipherKeyPair)P_0).Private;
	}

	static object _968DB9FA9E314CD3()
	{
		return new StringWriter();
	}

	static object _33E49763121C4F83(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object)new PemWriter((TextWriter)P_0);
	}

	static void ECEC4ED7587F4E19(object P_0, object P_1)
	{
		((PemWriter)P_0).WriteObject(P_1);
	}

	static object E853D2444C4440A2(object P_0)
	{
		return ((PemWriter)P_0).Writer;
	}

	static void _15B13C7340994B01(object P_0)
	{
		((TextWriter)P_0).Flush();
	}

	static string FA8206A46DA74DDC(object P_0)
	{
		return P_0.ToString();
	}

	static object A9F59E891F204824()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return (object)new RsaKeyPairGenerator();
	}

	static object _5DFA7280E54E46EE()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return (object)new SecureRandom();
	}

	static object _6D3759D41F10410B(object P_0, int P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected Obj, but got Unknown
		return (object)new KeyGenerationParameters((SecureRandom)P_0, P_1);
	}

	static void _3D47249865AA4C01(object P_0, object P_1)
	{
		((RsaKeyPairGenerator)P_0).Init((KeyGenerationParameters)P_1);
	}

	static object _0505AD17387E482C(object P_0)
	{
		return ((RsaKeyPairGenerator)P_0).GenerateKeyPair();
	}
}
