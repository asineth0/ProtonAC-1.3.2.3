using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

internal class _67302BF334454A51 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<Color32>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(Color32)
	})]
	public static void A2A5AF3986C84369(ClientInstanceMethod<Color32> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, Color32 arg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		_76A37FEC24954CBB(__instance, netId, reliability, transportConnections, arg);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<Color32>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(Color32)
	})]
	public static void _862305EB1F1F485B(ClientInstanceMethod<Color32> __instance, NetId netId, ENetReliability reliability, List<ITransportConnection> transportConnections, Color32 arg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		_76A37FEC24954CBB(__instance, netId, reliability, transportConnections, arg);
	}

	[_542A381FC1D44BA3(typeof(ClientInstanceMethod<Color32>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(NetId),
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(Color32)
	})]
	public static bool E78C901880C94C16(ClientInstanceMethod<Color32> __instance, NetId netId, ENetReliability reliability, ITransportConnection transportConnection, Color32 arg)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		_76A37FEC24954CBB(__instance, netId, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void _76A37FEC24954CBB(ClientInstanceMethod<Color32> _2B4F3CD156104F45, NetId A2BD3BACAD0446B3, ENetReliability _58CF445F4D2E4139, List<ITransportConnection> B9F99BC39B034609, Color32 C6AB7B6AFC46416E)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_2B4F3CD156104F45) == "ReceivePaintColor"))
		{
			return;
		}
		for (int num = B9F99BC39B034609.Count - 1; num >= 0; num--)
		{
			SteamPlayer val = Provider.findPlayer(B9F99BC39B034609[num]);
			if (val != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.D302F4FC9DA8422A(A2BD3BACAD0446B3);
					if (obj != null)
					{
						obj.E9DAEDF6796349E3 = C6AB7B6AFC46416E;
						if (!obj.BB8633A6EFF8468C)
						{
							B9F99BC39B034609.RemoveAt(num);
						}
					}
				}
			}
		}
	}
}
