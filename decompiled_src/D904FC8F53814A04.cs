using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

internal class D904FC8F53814A04 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte, Vector3, byte, bool>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(byte),
		typeof(Vector3),
		typeof(byte),
		typeof(bool)
	})]
	public static void _9A382CE54ADF4523(ClientStaticMethod<uint, byte, Vector3, byte, bool> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, byte arg2, Vector3 arg3, byte arg4, bool arg5)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_1BC3B3F5993A4953(__instance, reliability, transportConnections, arg1, arg2, arg3, arg4, arg5);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte, Vector3, byte, bool>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(byte),
		typeof(Vector3),
		typeof(byte),
		typeof(bool)
	})]
	public static void C2222CB0BA4441AD(ClientStaticMethod<uint, byte, Vector3, byte, bool> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, byte arg2, Vector3 arg3, byte arg4, bool arg5)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_1BC3B3F5993A4953(__instance, reliability, transportConnections, arg1, arg2, arg3, arg4, arg5);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte, Vector3, byte, bool>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(uint),
		typeof(byte),
		typeof(Vector3),
		typeof(byte),
		typeof(bool)
	})]
	public static bool E54D6FDE5F52462A(ClientStaticMethod<uint, byte, Vector3, byte, bool> __instance, ENetReliability reliability, ITransportConnection transportConnection, uint arg1, byte arg2, Vector3 arg3, byte arg4, bool arg5)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		_1BC3B3F5993A4953(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2, arg3, arg4, arg5);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void _1BC3B3F5993A4953(ClientStaticMethod<uint, byte, Vector3, byte, bool> A642E4ACD9F54663, ENetReliability BA1E1ECBF95841E5, List<ITransportConnection> _1D639CACA9A74AB1, uint F2C4D9EDF80C4B79, byte _07C07F27FA8B44D4, Vector3 _74883C3D22714B25, byte AC99E70F3D2A4F7B, bool _0364A85F8ED9467A)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)A642E4ACD9F54663) == "ReceiveExitVehicle"))
		{
			return;
		}
		ThreadUtil.assertIsGameThread();
		if (_2B4193F94A734FAF.FFA26FAB3AA94112)
		{
			return;
		}
		for (int num = _1D639CACA9A74AB1.Count - 1; num >= 0; num--)
		{
			SteamPlayer val = Provider.findPlayer(_1D639CACA9A74AB1[num]);
			if (val != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.F424C4A47EFA4596(F2C4D9EDF80C4B79);
					if (obj != null)
					{
						if (_07C07F27FA8B44D4 >= 0 && _07C07F27FA8B44D4 < obj._2F395796086E4AB0.Length)
						{
							if (_07C07F27FA8B44D4 == 0 && obj._2F395796086E4AB0[_07C07F27FA8B44D4] == val.playerID.steamID)
							{
								obj.D3D432C5496746C1 = true;
							}
							obj._2F395796086E4AB0[_07C07F27FA8B44D4] = CSteamID.Nil;
						}
						if (!obj.BB8633A6EFF8468C)
						{
							_1D639CACA9A74AB1.RemoveAt(num);
						}
					}
				}
			}
		}
	}
}
