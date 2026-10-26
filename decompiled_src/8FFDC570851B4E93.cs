using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

internal class _8FFDC570851B4E93 : _2B4193F94A734FAF
{
	private static readonly List<ITransportConnection> _2FB356D7CA214E70 = new List<ITransportConnection>();

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<EPlayerStance>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(EPlayerStance)
	})]
	public static void _09A2C87503AF45ED(ClientInstanceMethod<EPlayerStance> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, EPlayerStance arg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		BC2CD26B6D99409C(__instance, netId, reliability, transportConnections, arg);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<EPlayerStance>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(EPlayerStance)
	})]
	public static void _7619B6BE5DB04B40(ClientInstanceMethod<EPlayerStance> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, EPlayerStance arg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		BC2CD26B6D99409C(__instance, netId, reliability, transportConnections, arg);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<EPlayerStance>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(EPlayerStance)
	})]
	public static bool F809C2176F5240D5(ClientInstanceMethod<EPlayerStance> __instance, NetId netId, ENetReliability reliability, ITransportConnection transportConnection, EPlayerStance arg)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		BC2CD26B6D99409C(__instance, netId, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void BC2CD26B6D99409C(ClientInstanceMethod<EPlayerStance> _0F1305DE717D4490, NetId _42BDF5B7B12E454D, ENetReliability _4D5C68D5E4FC4126, List<ITransportConnection> CDFD3508F920400C, EPlayerStance _53173706CEE045B3)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_0F1305DE717D4490) == "ReceiveStance"))
		{
			return;
		}
		ThreadUtil.assertIsGameThread();
		if (_2B4193F94A734FAF.FFA26FAB3AA94112)
		{
			return;
		}
		Player val = _306ADE91FE314334(_42BDF5B7B12E454D);
		if ((Object)(object)val == (Object)null)
		{
			return;
		}
		_2FB356D7CA214E70.Clear();
		for (int num = CDFD3508F920400C.Count - 1; num >= 0; num--)
		{
			ITransportConnection val2 = CDFD3508F920400C[num];
			SteamPlayer val3 = Provider.findPlayer(val2);
			if (val3 != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val3.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51._706B8B0574FC4C59(val.channel.owner.playerID.steamID);
					if (obj != null && !obj.BB8633A6EFF8468C)
					{
						_2FB356D7CA214E70.Add(val2);
						CDFD3508F920400C.RemoveAt(num);
					}
				}
			}
		}
		if (_2FB356D7CA214E70.Count > 0)
		{
			_2B4193F94A734FAF.FFA26FAB3AA94112 = true;
			_0F1305DE717D4490.Invoke(_42BDF5B7B12E454D, _4D5C68D5E4FC4126, _2FB356D7CA214E70, (EPlayerStance)3);
			_2B4193F94A734FAF.FFA26FAB3AA94112 = false;
		}
	}

	private static Player? _306ADE91FE314334(NetId netId)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		foreach (SteamPlayer client in Provider.clients)
		{
			if (!((Object)(object)client.player == (Object)null) && ((PlayerCaller)client.player.stance).GetNetId() == netId)
			{
				return client.player;
			}
		}
		return null;
	}
}
