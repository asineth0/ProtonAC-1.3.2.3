using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;

internal class DC74B663696D4402 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(byte)
	})]
	public static void _4A2B7B1A4B0F40D8(ClientStaticMethod<uint, byte> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, byte arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_66BB6AA043E04252(__instance, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(byte)
	})]
	public static void _8B15C144FFA14AE6(ClientStaticMethod<uint, byte> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, byte arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_66BB6AA043E04252(__instance, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(uint),
		typeof(byte)
	})]
	public static bool E9C7ED9AAF34432D(ClientStaticMethod<uint, byte> __instance, ENetReliability reliability, ITransportConnection transportConnection, uint arg1, byte arg2)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		_66BB6AA043E04252(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void _66BB6AA043E04252(ClientStaticMethod<uint, byte> A368DF6F336B47E7, ENetReliability _634404C3564D47BF, List<ITransportConnection> _07CCD301B1EA4A9B, uint F756D24701D74B16, byte _6D837DFDFC7644F2)
	{
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)A368DF6F336B47E7) == "ReceiveVehicleTireAliveMask"))
		{
			return;
		}
		for (int num = _07CCD301B1EA4A9B.Count - 1; num >= 0; num--)
		{
			SteamPlayer val = Provider.findPlayer(_07CCD301B1EA4A9B[num]);
			if (val != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.F424C4A47EFA4596(F756D24701D74B16);
					if (obj != null)
					{
						obj._000BEE2C871E45F4 = _6D837DFDFC7644F2;
						if (!obj.BB8633A6EFF8468C)
						{
							_07CCD301B1EA4A9B.RemoveAt(num);
						}
					}
				}
			}
		}
	}
}
