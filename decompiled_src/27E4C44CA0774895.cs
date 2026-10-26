using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

internal class _27E4C44CA0774895 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<float>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(float)
	})]
	public static void _41602327047C4A01(ClientInstanceMethod<float> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, float arg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		B24FD12FE44C4275(__instance, netId, reliability, transportConnections, arg);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<float>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(float)
	})]
	public static void _3A883DCBC37E4A89(ClientInstanceMethod<float> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, float arg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		B24FD12FE44C4275(__instance, netId, reliability, transportConnections, arg);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<float>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(float)
	})]
	public static void A6267E171D2643FC(ClientInstanceMethod<float> __instance, NetId netId, ENetReliability reliability, ITransportConnection transportConnection, float arg)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		B24FD12FE44C4275(__instance, netId, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg);
	}

	public static void B24FD12FE44C4275(ClientInstanceMethod<float> F807B77551CD4B9B, NetId CDB4A89F36C44C3F, ENetReliability AD3EB932749A4D2A, List<ITransportConnection> _9222E7C211584301, float AC73994F2A93453E)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)F807B77551CD4B9B) == "ReceiveSalvageTimeOverride"))
		{
			return;
		}
		foreach (ITransportConnection item in _9222E7C211584301)
		{
			SteamPlayer val = Provider.findPlayer(item);
			if (val != null && (Object)(object)val.player != (Object)null && ((PlayerCaller)val.player.interact).GetNetId() == CDB4A89F36C44C3F)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
				if (a3116505AAB != null)
				{
					a3116505AAB.F470F3F6558649C1._8EF072D3ACE7443F = AC73994F2A93453E;
					a3116505AAB.F470F3F6558649C1._572825A58EC3403A = AC73994F2A93453E > -0.5f;
					break;
				}
			}
		}
	}
}
