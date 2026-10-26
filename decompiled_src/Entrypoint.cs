using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SDG.Unturned;

public class Entrypoint
{
	private static _1DB744298E9F4B09? _bootstrapper;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Load()
	{
		_442E6804D1F44B28();
		_233F95D5C10148FA((string)null, (string)null, (string)null, (string)null);
		_3DB1CF071A5B4F1C((string)null, (string)null);
		_3DB1CF071A5B4F1C((string)null, (string)null);
		_3DB1CF071A5B4F1C((string)null, (string)null);
		_9637543B4903491F();
		_99A2C437C2764F79((object)null, (string)null);
		_43F6362FABFF48B9((object)null, (string)null);
		_6098ED3B592E4123((object)null);
		_3DB1CF071A5B4F1C((string)null, (string)null);
		_3DB1CF071A5B4F1C((string)null, (string)null);
		DBFD0AD5939E426B((string)null);
		DBFD0AD5939E426B((string)null);
		_3DB1CF071A5B4F1C((string)null, (string)null);
		DBFD0AD5939E426B((string)null);
		A9DB0CBBB57B4BE7((string)null);
		A9DB0CBBB57B4BE7((string)null);
		A75D72BB03424E6D((string)null);
		_1C7D82A0F4094E00((string)null, false);
		throw new Exception();
	}

	public static void Unload()
	{
		_1DB744298E9F4B09? bootstrapper = _bootstrapper;
		if (bootstrapper != null)
		{
			_5B9DB5EB322B453C((object)bootstrapper);
		}
	}

	static string _442E6804D1F44B28()
	{
		return Provider.serverID;
	}

	static string _233F95D5C10148FA(string P_0, string P_1, string P_2, string P_3)
	{
		return Path.Combine(P_0, P_1, P_2, P_3);
	}

	static string _3DB1CF071A5B4F1C(string P_0, string P_1)
	{
		return Path.Combine(P_0, P_1);
	}

	static bool DBFD0AD5939E426B(string P_0)
	{
		return File.Exists(P_0);
	}

	static void A9DB0CBBB57B4BE7(string P_0)
	{
		File.Delete(P_0);
	}

	static bool A75D72BB03424E6D(string P_0)
	{
		return Directory.Exists(P_0);
	}

	static void _1C7D82A0F4094E00(string P_0, bool P_1)
	{
		Directory.Delete(P_0, P_1);
	}

	static object _9637543B4903491F()
	{
		return _1DB744298E9F4B09._5854F6AC0CF0464E();
	}

	static object _99A2C437C2764F79(object P_0, string P_1)
	{
		return ((_1DB744298E9F4B09)P_0)._9127E76D13FB459F(P_1);
	}

	static object _43F6362FABFF48B9(object P_0, string P_1)
	{
		return ((_1DB744298E9F4B09)P_0)._2A06EA6591F2473D(P_1);
	}

	static object _79C43D71BABF4D8A(object P_0, Func<Task> P_1)
	{
		return ((_1DB744298E9F4B09)P_0)._287B059A86E24015(P_1);
	}

	static object _6098ED3B592E4123(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0).E8D77ACB56BA43BF();
	}

	static void _0ADEE3C50FFE4E94(object P_0)
	{
		((_1DB744298E9F4B09)P_0)._2470246CB7CF4D5E();
	}

	static void _5B9DB5EB322B453C(object P_0)
	{
		((_1DB744298E9F4B09)P_0)._1D51E2B36C7345F0();
	}
}
