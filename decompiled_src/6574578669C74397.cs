using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using Steamworks;

internal class _6574578669C74397 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte, byte>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(byte),
		typeof(byte)
	})]
	public static void B4EAF62E3CF14C01(ClientStaticMethod<uint, byte, byte> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, byte arg2, byte arg3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_2E5FAAEE78F5447C(__instance, reliability, transportConnections, arg1, arg2, arg3);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte, byte>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(byte),
		typeof(byte)
	})]
	public static void _3A24823743374CB7(ClientStaticMethod<uint, byte, byte> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, byte arg2, byte arg3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_2E5FAAEE78F5447C(__instance, reliability, transportConnections, arg1, arg2, arg3);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, byte, byte>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(uint),
		typeof(byte),
		typeof(byte)
	})]
	public static bool F3993CCE19E446B3(ClientStaticMethod<uint, byte, byte> __instance, ENetReliability reliability, ITransportConnection transportConnection, uint arg1, byte arg2, byte arg3)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		_2E5FAAEE78F5447C(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2, arg3);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void _2E5FAAEE78F5447C(ClientStaticMethod<uint, byte, byte> AEF4F4BB97CE4548, ENetReliability CB708912D61B4862, List<ITransportConnection> F5E52B08F6D54EFB, uint _5BA528ACD9EB4F86, byte D4CE6B23E8DE4086, byte A1DFE313901A44BB)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		if (!(_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)AEF4F4BB97CE4548) == "ReceiveSwapVehicleSeats"))
		{
			return;
		}
		for (int num = F5E52B08F6D54EFB.Count - 1; num >= 0; num--)
		{
			SteamPlayer val = Provider.findPlayer(F5E52B08F6D54EFB[num]);
			if (val != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.F424C4A47EFA4596(_5BA528ACD9EB4F86);
					if (obj != null)
					{
						if (D4CE6B23E8DE4086 >= 0 && D4CE6B23E8DE4086 < obj._2F395796086E4AB0.Length && A1DFE313901A44BB >= 0 && A1DFE313901A44BB < obj._2F395796086E4AB0.Length)
						{
							CSteamID val2 = obj._2F395796086E4AB0[D4CE6B23E8DE4086];
							if (val2 != CSteamID.Nil)
							{
								obj._2F395796086E4AB0[D4CE6B23E8DE4086] = CSteamID.Nil;
								obj._2F395796086E4AB0[A1DFE313901A44BB] = val2;
								if (D4CE6B23E8DE4086 == 0 && val2 == val.playerID.steamID)
								{
									obj.D3D432C5496746C1 = true;
								}
							}
						}
						if (!obj.BB8633A6EFF8468C)
						{
							F5E52B08F6D54EFB.RemoveAt(num);
						}
					}
				}
			}
		}
	}
}
