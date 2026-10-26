using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using Steamworks;

internal class AA466B8FF2374726 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte, CSteamID>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(byte),
		typeof(CSteamID)
	})]
	public static void _256EA163FC7D41AD(ClientStaticMethod<uint, byte, CSteamID> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, byte arg2, CSteamID arg3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		F5B9A38473F84B79(__instance, reliability, transportConnections, arg1, arg2, arg3);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte, CSteamID>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(byte),
		typeof(CSteamID)
	})]
	public static void _14B6ADD602054E98(ClientStaticMethod<uint, byte, CSteamID> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, byte arg2, CSteamID arg3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		F5B9A38473F84B79(__instance, reliability, transportConnections, arg1, arg2, arg3);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte, CSteamID>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(uint),
		typeof(byte),
		typeof(CSteamID)
	})]
	public static bool _75D87FFFB6CB48F0(ClientStaticMethod<uint, byte, CSteamID> __instance, ENetReliability reliability, ITransportConnection transportConnection, uint arg1, byte arg2, CSteamID arg3)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		F5B9A38473F84B79(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2, arg3);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void F5B9A38473F84B79(ClientStaticMethod<uint, byte, CSteamID> _4EA3151C17034489, ENetReliability C76C354577E74A3B, List<ITransportConnection> ADADA57BF3E54B0C, uint _5860BCAC48A54FE1, byte _09DBC5A60114430B, CSteamID E88D2A9927F846BF)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_4EA3151C17034489) == "ReceiveEnterVehicle"))
		{
			return;
		}
		for (int num = ADADA57BF3E54B0C.Count - 1; num >= 0; num--)
		{
			ITransportConnection val = ADADA57BF3E54B0C[num];
			SteamPlayer val2 = Provider.findPlayer(val);
			if (val2 != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val2.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.F424C4A47EFA4596(_5860BCAC48A54FE1);
					if (obj != null)
					{
						if (_09DBC5A60114430B >= 0 && _09DBC5A60114430B < obj._2F395796086E4AB0.Length)
						{
							obj._2F395796086E4AB0[_09DBC5A60114430B] = E88D2A9927F846BF;
							if (!obj.BB8633A6EFF8468C)
							{
								E0979537EFEC4491.FB19ACF0E0D043CD(val, _09DBC5A60114430B, E88D2A9927F846BF, BD62043649A04BD7: true, _462C18A65EAB4629: true);
							}
						}
						if (!obj.BB8633A6EFF8468C)
						{
							ADADA57BF3E54B0C.RemoveAt(num);
						}
					}
				}
			}
		}
	}
}
