using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using UnityEngine;

internal class _5A4D1C29B64F4327 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientStaticMethod<NetId, Guid, byte[], Vector3, Quaternion, ulong, ulong, NetId>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(NetId),
		typeof(Guid),
		typeof(byte[]),
		typeof(Vector3),
		typeof(Quaternion),
		typeof(ulong),
		typeof(ulong),
		typeof(NetId)
	})]
	public static void _06782535B6BA4E76(ClientStaticMethod<NetId, Guid, byte[], Vector3, Quaternion, ulong, ulong, NetId> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, NetId arg1, Guid arg2, byte[] arg3, Vector3 arg4, Quaternion arg5, ulong arg6, ulong arg7, NetId arg8)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		_048EE02908EB48B8(__instance, reliability, transportConnections, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<NetId, Guid, byte[], Vector3, Quaternion, ulong, ulong, NetId>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(NetId),
		typeof(Guid),
		typeof(byte[]),
		typeof(Vector3),
		typeof(Quaternion),
		typeof(ulong),
		typeof(ulong),
		typeof(NetId)
	})]
	public static void F1E435EC62FF4A80(ClientStaticMethod<NetId, Guid, byte[], Vector3, Quaternion, ulong, ulong, NetId> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, NetId arg1, Guid arg2, byte[] arg3, Vector3 arg4, Quaternion arg5, ulong arg6, ulong arg7, NetId arg8)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		_048EE02908EB48B8(__instance, reliability, transportConnections, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<NetId, Guid, byte[], Vector3, Quaternion, ulong, ulong, NetId>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(NetId),
		typeof(Guid),
		typeof(byte[]),
		typeof(Vector3),
		typeof(Quaternion),
		typeof(ulong),
		typeof(ulong),
		typeof(NetId)
	})]
	public static bool _500FD5E1130742BE(ClientStaticMethod<NetId, Guid, byte[], Vector3, Quaternion, ulong, ulong, NetId> __instance, ENetReliability reliability, ITransportConnection transportConnection, NetId arg1, Guid arg2, byte[] arg3, Vector3 arg4, Quaternion arg5, ulong arg6, ulong arg7, NetId arg8)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		_048EE02908EB48B8(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void _048EE02908EB48B8(ClientStaticMethod<NetId, Guid, byte[], Vector3, Quaternion, ulong, ulong, NetId> _272FB727C7784131, ENetReliability _75F23B47C9924EEA, List<ITransportConnection> _04C241F0453C49C3, NetId AE7279BCE42B46D8, Guid _0AFC55D527DA49B2, byte[] FA64117D67184CB0, Vector3 D6582849C405403B, Quaternion _2EAA714A5C6046B2, ulong _02BEBCE3C4DA4503, ulong E9517D72B4284F26, NetId _1CD0BB3A4565449E)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_272FB727C7784131) == "ReceiveSingleBarricade") || AE7279BCE42B46D8 == NetId.INVALID)
		{
			return;
		}
		for (int num = _04C241F0453C49C3.Count - 1; num >= 0; num--)
		{
			SteamPlayer val = Provider.findPlayer(_04C241F0453C49C3[num]);
			if (val != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.D302F4FC9DA8422A(AE7279BCE42B46D8);
					if (obj != null && !obj.BB8633A6EFF8468C)
					{
						_04C241F0453C49C3.RemoveAt(num);
					}
				}
			}
		}
	}
}
