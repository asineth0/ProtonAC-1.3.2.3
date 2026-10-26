using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using Steamworks;

internal class _7A97106D6B594168 : _2B4193F94A734FAF
{
	private static readonly List<ITransportConnection> _5ACE888413D54122 = new List<ITransportConnection>();

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, CSteamID, CSteamID, bool>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(CSteamID),
		typeof(CSteamID),
		typeof(bool)
	})]
	public static void _3B0537A927E5400A(ClientStaticMethod<uint, CSteamID, CSteamID, bool> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, CSteamID arg2, CSteamID arg3, bool arg4)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		EE8391B1E3B84302(__instance, reliability, transportConnections, arg1, arg2, arg3, arg4);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, CSteamID, CSteamID, bool>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(CSteamID),
		typeof(CSteamID),
		typeof(bool)
	})]
	public static void _7B51C5BE015349EE(ClientStaticMethod<uint, CSteamID, CSteamID, bool> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, CSteamID arg2, CSteamID arg3, bool arg4)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		EE8391B1E3B84302(__instance, reliability, transportConnections, arg1, arg2, arg3, arg4);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, CSteamID, CSteamID, bool>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(uint),
		typeof(CSteamID),
		typeof(CSteamID),
		typeof(bool)
	})]
	public static bool _672CCD87CA4D4CD2(ClientStaticMethod<uint, CSteamID, CSteamID, bool> __instance, ENetReliability reliability, ITransportConnection transportConnection, uint arg1, CSteamID arg2, CSteamID arg3, bool arg4)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		EE8391B1E3B84302(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2, arg3, arg4);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void EE8391B1E3B84302(ClientStaticMethod<uint, CSteamID, CSteamID, bool> _683CFB0AD5D245AF, ENetReliability _3D9710221AAC4E16, List<ITransportConnection> BBA4C8E369E74F96, uint _9670DCCAAC8C484A, CSteamID A3ACBFD3FDF74831, CSteamID EFC673B8B15F4478, bool _7030903A92E641E3)
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_683CFB0AD5D245AF) == "ReceiveVehicleLockState"))
		{
			return;
		}
		ThreadUtil.assertIsGameThread();
		if (_2B4193F94A734FAF.FFA26FAB3AA94112)
		{
			return;
		}
		_5ACE888413D54122.Clear();
		for (int num = BBA4C8E369E74F96.Count - 1; num >= 0; num--)
		{
			ITransportConnection val = BBA4C8E369E74F96[num];
			SteamPlayer val2 = Provider.findPlayer(val);
			if (val2 != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val2.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.F424C4A47EFA4596(_9670DCCAAC8C484A);
					if (obj != null)
					{
						obj._10EE6A914786423D = A3ACBFD3FDF74831;
						obj._2C48DDCF175D45F1 = EFC673B8B15F4478;
						obj.D5D10DE6B19D4008 = _7030903A92E641E3;
						if (A3ACBFD3FDF74831 != CSteamID.Nil && A3ACBFD3FDF74831 != val2.playerID.steamID)
						{
							_5ACE888413D54122.Add(val);
							BBA4C8E369E74F96.RemoveAt(num);
						}
						else if (!obj.BB8633A6EFF8468C)
						{
							BBA4C8E369E74F96.RemoveAt(num);
						}
					}
				}
			}
		}
		if (_5ACE888413D54122.Count > 0)
		{
			_2B4193F94A734FAF.FFA26FAB3AA94112 = true;
			_683CFB0AD5D245AF.Invoke(_3D9710221AAC4E16, _5ACE888413D54122, _9670DCCAAC8C484A, CSteamID.Nil, EFC673B8B15F4478, _7030903A92E641E3);
			_2B4193F94A734FAF.FFA26FAB3AA94112 = false;
		}
	}
}
