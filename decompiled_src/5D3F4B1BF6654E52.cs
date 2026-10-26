using System;
using System.Runtime.CompilerServices;
using SDG.Unturned;

internal class _5D3F4B1BF6654E52
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int C8F36D848FF540AB(Player P_0)
	{
		return (int)_8A76A2B1966C42E2((double)(F5524706F3F34FE9((object)((SteamChannel)_5F19A457652D4A6C((object)P_0)).owner) * _003CModule_003E._390073C602714496<float>(60796700)));
	}

	static object _5F19A457652D4A6C(object P_0)
	{
		return ((Player)P_0).channel;
	}

	static float F5524706F3F34FE9(object P_0)
	{
		return ((SteamPlayer)P_0).ping;
	}

	static double _8A76A2B1966C42E2(double P_0)
	{
		return Math.Round(P_0);
	}
}
