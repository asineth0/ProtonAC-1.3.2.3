using System;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

internal class _85399D7C08B94D76
{
	private string _7F64BAA0AA954927;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _85399D7C08B94D76 _66692E0EB4194A0C(string P_0)
	{
		_6F7AEB8047BD46A1((string)null, (string)null);
		D90EE4645F0A48D6(P_0);
		_7F64BAA0AA954927 = P_0;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public C0225ABF72C4425E _2A2378566E004678()
	{
		FCED451CB19D4B23(_7F64BAA0AA954927, (string)null);
		_6F61788E0AA44245(_7F64BAA0AA954927);
		_80E329AF727A424E(_7F64BAA0AA954927);
		EC4FC2925D364DEA(_7F64BAA0AA954927);
		B882850FAFDD462C((string)null);
		_0EDB60F16FA14BB5((string)null);
		throw new Exception();
	}

	public _85399D7C08B94D76()
	{
		_2E5FC999C4F84832();
		_7F64BAA0AA954927 = null;
	}

	static bool D90EE4645F0A48D6(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static object _6F7AEB8047BD46A1(string P_0, string P_1)
	{
		return new ArgumentException(P_0, P_1);
	}

	static bool _80E329AF727A424E(string P_0)
	{
		return Directory.Exists(P_0);
	}

	static object EC4FC2925D364DEA(string P_0)
	{
		return Directory.CreateDirectory(P_0);
	}

	static string _442DA5E0704C49E0(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	static string _8E644F7CCB9F4DD5(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static void _95D1B769C3B24A1F(object P_0)
	{
		Debug.Log(P_0);
	}

	static ConsoleColor D92BA4832B1F4E27()
	{
		return Console.ForegroundColor;
	}

	static void _6F5746D17F5F4D60(ConsoleColor P_0)
	{
		Console.ForegroundColor = P_0;
	}

	static void E084194C18364616(string P_0)
	{
		Console.WriteLine(P_0);
	}

	static string[] FCED451CB19D4B23(string P_0, string P_1)
	{
		return Directory.GetFiles(P_0, P_1);
	}

	static DateTime B882850FAFDD462C(string P_0)
	{
		return File.GetLastWriteTime(P_0);
	}

	static void _0EDB60F16FA14BB5(string P_0)
	{
		File.Delete(P_0);
	}

	static object _6F61788E0AA44245(string P_0)
	{
		return new C0225ABF72C4425E(P_0);
	}

	static string _2E5FC999C4F84832()
	{
		return AppContext.BaseDirectory;
	}
}
