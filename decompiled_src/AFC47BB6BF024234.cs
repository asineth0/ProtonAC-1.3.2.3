using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;

internal class AFC47BB6BF024234 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, ushort, ushort>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(ushort),
		typeof(ushort)
	})]
	public static void _7509CD95564B490D(ClientStaticMethod<uint, ushort, ushort> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, ushort arg2, ushort arg3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		B316B160D0C94A8C(__instance, reliability, transportConnections, arg1, arg2, arg3);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, ushort, ushort>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(ushort),
		typeof(ushort)
	})]
	public static void BF5B6A28B6084B57(ClientStaticMethod<uint, ushort, ushort> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, ushort arg2, ushort arg3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		B316B160D0C94A8C(__instance, reliability, transportConnections, arg1, arg2, arg3);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, ushort, ushort>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(uint),
		typeof(ushort),
		typeof(ushort)
	})]
	public static bool _923FAEBF3F7E46F9(ClientStaticMethod<uint, ushort, ushort> __instance, ENetReliability reliability, ITransportConnection transportConnection, uint arg1, ushort arg2, ushort arg3)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		B316B160D0C94A8C(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2, arg3);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void B316B160D0C94A8C(ClientStaticMethod<uint, ushort, ushort> _8CB6AEA5C0FF48FD, ENetReliability F22E017AA6E440A7, List<ITransportConnection> E9845CE1812C4DAE, uint _0FCE7242C05B47D4, ushort _7A92A398E3664163, ushort B08F7FA3179D4878)
	{
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_8CB6AEA5C0FF48FD) == "ReceiveVehicleSkin"))
		{
			return;
		}
		for (int num = E9845CE1812C4DAE.Count - 1; num >= 0; num--)
		{
			SteamPlayer val = Provider.findPlayer(E9845CE1812C4DAE[num]);
			if (val != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.F424C4A47EFA4596(_0FCE7242C05B47D4);
					if (obj != null)
					{
						obj._3B8B8C1D6075410D = _7A92A398E3664163;
						obj.A6580BD9091D4B23 = B08F7FA3179D4878;
						if (!obj.BB8633A6EFF8468C)
						{
							E9845CE1812C4DAE.RemoveAt(num);
						}
					}
				}
			}
		}
	}
}
