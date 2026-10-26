using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;

internal class B380A5375C7A4BB0 : _2B4193F94A734FAF
{
	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, ushort>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(ushort)
	})]
	public static void _04562212807D45E7(ClientStaticMethod<uint, ushort> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, ushort arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		F0A9FA7A1A074557(__instance, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, ushort>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint),
		typeof(ushort)
	})]
	public static void AAA3A4DF2C994045(ClientStaticMethod<uint, ushort> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg1, ushort arg2)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		F0A9FA7A1A074557(__instance, reliability, transportConnections, arg1, arg2);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint, ushort>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(uint),
		typeof(ushort)
	})]
	public static bool DAED241CA8CA4961(ClientStaticMethod<uint, ushort> __instance, ENetReliability reliability, ITransportConnection transportConnection, uint arg1, ushort arg2)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		F0A9FA7A1A074557(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg1, arg2);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void F0A9FA7A1A074557(ClientStaticMethod<uint, ushort> _1EEC530EF09040E0, ENetReliability _6D307BC272514A9A, List<ITransportConnection> _8F120651D9B4472E, uint _5C004A0D3FE5408E, ushort B71C5266DA4C49F6)
	{
		switch (_2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_1EEC530EF09040E0))
		{
		case "ReceiveVehicleBatteryCharge":
		{
			for (int num2 = _8F120651D9B4472E.Count - 1; num2 >= 0; num2--)
			{
				SteamPlayer val2 = Provider.findPlayer(_8F120651D9B4472E[num2]);
				if (val2 != null)
				{
					A3116505AAB24996 a3116505AAB2 = A3116505AAB24996._69C6AFA769194D6F(val2.player);
					if (a3116505AAB2 != null)
					{
						_087B17044C8447C2 obj2 = a3116505AAB2._83B3415EF0E34C51.F424C4A47EFA4596(_5C004A0D3FE5408E);
						if (obj2 != null)
						{
							obj2._58F4F1E53C5347CE = B71C5266DA4C49F6;
							if (!obj2.BB8633A6EFF8468C)
							{
								_8F120651D9B4472E.RemoveAt(num2);
							}
						}
					}
				}
			}
			break;
		}
		case "ReceiveVehicleFuel":
		{
			for (int num3 = _8F120651D9B4472E.Count - 1; num3 >= 0; num3--)
			{
				SteamPlayer val3 = Provider.findPlayer(_8F120651D9B4472E[num3]);
				if (val3 != null)
				{
					A3116505AAB24996 a3116505AAB3 = A3116505AAB24996._69C6AFA769194D6F(val3.player);
					if (a3116505AAB3 != null)
					{
						_087B17044C8447C2 obj3 = a3116505AAB3._83B3415EF0E34C51.F424C4A47EFA4596(_5C004A0D3FE5408E);
						if (obj3 != null)
						{
							obj3.D8A705E2547D4658 = B71C5266DA4C49F6;
							if (!obj3.BB8633A6EFF8468C)
							{
								_8F120651D9B4472E.RemoveAt(num3);
							}
						}
					}
				}
			}
			break;
		}
		case "ReceiveVehicleHealth":
		{
			for (int num = _8F120651D9B4472E.Count - 1; num >= 0; num--)
			{
				SteamPlayer val = Provider.findPlayer(_8F120651D9B4472E[num]);
				if (val != null)
				{
					A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val.player);
					if (a3116505AAB != null)
					{
						_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.F424C4A47EFA4596(_5C004A0D3FE5408E);
						if (obj != null)
						{
							obj.D6D573E4F5634F10 = B71C5266DA4C49F6;
							if (!obj.BB8633A6EFF8468C)
							{
								_8F120651D9B4472E.RemoveAt(num);
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
