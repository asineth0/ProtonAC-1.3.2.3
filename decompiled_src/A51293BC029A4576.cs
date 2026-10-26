using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

internal class A51293BC029A4576 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<byte, Vector3>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(byte),
		typeof(Vector3)
	})]
	public static void F090352D18E24FF0(ClientInstanceMethod<byte, Vector3> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, byte arg1, Vector3 arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		D19930F738CE4462(__instance, netId, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<byte, Vector3>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(byte),
		typeof(Vector3)
	})]
	public static void EAE685E635FA4B49(ClientInstanceMethod<byte, Vector3> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, byte arg1, Vector3 arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		D19930F738CE4462(__instance, netId, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<byte, Vector3>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(byte),
		typeof(Vector3)
	})]
	public static void _083EC0673E064C63(ClientInstanceMethod<byte, Vector3> __instance, NetId netId, ENetReliability reliability, ITransportConnection transportConnection, byte arg1, Vector3 arg2)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		D19930F738CE4462(__instance, netId, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2);
	}

	public static void D19930F738CE4462(ClientInstanceMethod<byte, Vector3> _0E58DB99CE824F31, NetId _3FEAF109D87B409F, ENetReliability _6AD54E6AA76B402D, List<ITransportConnection> _212BA8EA11894C3D, byte A36E877B83754D9B, Vector3 _23300D123023419C)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_0E58DB99CE824F31) == "ReceiveDamagedEvent"))
		{
			return;
		}
		foreach (ITransportConnection item in _212BA8EA11894C3D)
		{
			SteamPlayer val = Provider.findPlayer(item);
			if (val != null && (Object)(object)val.player != (Object)null && ((PlayerCaller)val.player.life).GetNetId() == _3FEAF109D87B409F)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
				if (a3116505AAB != null)
				{
					a3116505AAB._35F1EA6BE31E4755._8CA8F128050E4F92(A36E877B83754D9B, _23300D123023419C);
					break;
				}
			}
		}
	}
}
