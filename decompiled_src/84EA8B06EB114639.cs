using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

internal class _84EA8B06EB114639 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<Vector3, byte>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(Vector3),
		typeof(byte)
	})]
	public static void _7615769937774299(ClientInstanceMethod<Vector3, byte> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, Vector3 arg1, byte arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		_67029ADF719B420C(__instance, netId, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<Vector3, byte>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(Vector3),
		typeof(byte)
	})]
	public static void _690CCA11F3D7424C(ClientInstanceMethod<Vector3, byte> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, Vector3 arg1, byte arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		_67029ADF719B420C(__instance, netId, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<Vector3, byte>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(Vector3),
		typeof(byte)
	})]
	public static void F26A3D95C8FE43F8(ClientInstanceMethod<Vector3, byte> __instance, NetId netId, ENetReliability reliability, ITransportConnection transportConnection, Vector3 arg1, byte arg2)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		_67029ADF719B420C(__instance, netId, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2);
	}

	public static void _67029ADF719B420C(ClientInstanceMethod<Vector3, byte> BC172AED2C0C4BF1, NetId B662EFF6541A429A, ENetReliability _85ADB84E4BE44C11, List<ITransportConnection> _25C650FD07D54034, Vector3 _33A2D240D17B459F, byte _493B24A1C65F46E7)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		string text = _2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)BC172AED2C0C4BF1);
		if (text == "ReceiveTeleport")
		{
			foreach (ITransportConnection item in _25C650FD07D54034)
			{
				SteamPlayer val = Provider.findPlayer(item);
				if (val != null && (Object)(object)val.player != (Object)null && val.player.GetNetId() == B662EFF6541A429A)
				{
					A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
					if (a3116505AAB != null)
					{
						a3116505AAB.D4B92BC609984285();
						break;
					}
				}
			}
			return;
		}
		if (!(text == "ReceiveRevive"))
		{
			return;
		}
		foreach (ITransportConnection item2 in _25C650FD07D54034)
		{
			SteamPlayer val2 = Provider.findPlayer(item2);
			if (val2 != null && (Object)(object)val2.player != (Object)null && ((PlayerCaller)val2.player.life).GetNetId() == B662EFF6541A429A)
			{
				A3116505AAB24996 a3116505AAB2 = A3116505AAB24996._69C6AFA769194D6F(val2.player);
				if (a3116505AAB2 != null)
				{
					a3116505AAB2.D4B92BC609984285();
					break;
				}
			}
		}
	}
}
