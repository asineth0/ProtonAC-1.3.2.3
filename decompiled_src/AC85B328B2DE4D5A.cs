using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;

internal class AC85B328B2DE4D5A : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, bool>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(bool)
	})]
	public static void BC7C3F0EA0634193(ClientStaticMethod<uint, bool> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, bool arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_5AD33028E69C4DF7(__instance, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, bool>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(bool)
	})]
	public static void ED02CB2B5FC140AF(ClientStaticMethod<uint, bool> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, bool arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_5AD33028E69C4DF7(__instance, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, bool>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(uint),
		typeof(bool)
	})]
	public static bool _496C084B47214210(ClientStaticMethod<uint, bool> __instance, ENetReliability reliability, ITransportConnection transportConnection, uint arg1, bool arg2)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		_5AD33028E69C4DF7(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void _5AD33028E69C4DF7(ClientStaticMethod<uint, bool> _28BD1AEDD541430F, ENetReliability _92B08E21ACB74062, List<ITransportConnection> _598A818BEDF84910, uint _9AF420C2FEF84690, bool _51BFA4CAE8BB42B9)
	{
		switch (_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_28BD1AEDD541430F))
		{
		case "ReceiveVehicleHeadlights":
		{
			for (int num2 = _598A818BEDF84910.Count - 1; num2 >= 0; num2--)
			{
				SteamPlayer val2 = Provider.findPlayer(_598A818BEDF84910[num2]);
				if (val2 != null)
				{
					A3116505AAB24996 a3116505AAB2 = A3116505AAB24996._69C6AFA769194D6F(val2.player);
					if (a3116505AAB2 != null)
					{
						_087B17044C8447C2 obj2 = a3116505AAB2._83B3415EF0E34C51.F424C4A47EFA4596(_9AF420C2FEF84690);
						if (obj2 != null)
						{
							obj2.C713EBE2590F4E41 = _51BFA4CAE8BB42B9;
							if (!obj2.BB8633A6EFF8468C)
							{
								_598A818BEDF84910.RemoveAt(num2);
							}
						}
					}
				}
			}
			break;
		}
		case "ReceiveVehicleBlimp":
		{
			for (int num3 = _598A818BEDF84910.Count - 1; num3 >= 0; num3--)
			{
				SteamPlayer val3 = Provider.findPlayer(_598A818BEDF84910[num3]);
				if (val3 != null)
				{
					A3116505AAB24996 a3116505AAB3 = A3116505AAB24996._69C6AFA769194D6F(val3.player);
					if (a3116505AAB3 != null)
					{
						_087B17044C8447C2 obj3 = a3116505AAB3._83B3415EF0E34C51.F424C4A47EFA4596(_9AF420C2FEF84690);
						if (obj3 != null)
						{
							obj3.AE752C85788B4E77 = _51BFA4CAE8BB42B9;
							if (!obj3.BB8633A6EFF8468C)
							{
								_598A818BEDF84910.RemoveAt(num3);
							}
						}
					}
				}
			}
			break;
		}
		case "ReceiveVehicleSirens":
		{
			for (int num = _598A818BEDF84910.Count - 1; num >= 0; num--)
			{
				SteamPlayer val = Provider.findPlayer(_598A818BEDF84910[num]);
				if (val != null)
				{
					A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
					if (a3116505AAB != null)
					{
						_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.F424C4A47EFA4596(_9AF420C2FEF84690);
						if (obj != null)
						{
							obj._7A9750FB420B45A6 = _51BFA4CAE8BB42B9;
							if (!obj.BB8633A6EFF8468C)
							{
								_598A818BEDF84910.RemoveAt(num);
							}
						}
					}
				}
			}
			break;
		}
		}
	}
}
