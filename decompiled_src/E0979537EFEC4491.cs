using System;
using System.Collections.Generic;
using SDG.NetTransport;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

internal class E0979537EFEC4491 : _2B4193F94A734FAF
{
	private static readonly ClientStaticMethod<uint, byte, Vector3, byte, bool> _684313DC9C944857 = ClientStaticMethod<uint, byte, Vector3, byte, bool>.Get((ReceiveDelegate<uint, byte, Vector3, byte, bool>)VehicleManager.ReceiveExitVehicle);

	private static readonly ClientStaticMethod<uint> _5A42424918F54E84 = ClientStaticMethod<uint>.Get(typeof(VehicleManager), "ReceiveDestroySingleVehicle");

	private static readonly ClientInstanceMethod<EPlayerStance> C2A6FB1177EE4D14 = ClientInstanceMethod<EPlayerStance>.Get(typeof(PlayerStance), "ReceiveStance");

	private static readonly ClientInstanceMethod<Vector3, byte> C2E3989A57A5491C = ClientInstanceMethod<Vector3, byte>.Get(typeof(Player), "ReceiveTeleport");

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint)
	})]
	public static void F31D9E877F5340E3(ClientStaticMethod<uint> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_3A9949C7F5CF4C2A(__instance, reliability, transportConnections, arg);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint>), "InvokeAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(uint)
	})]
	public static void _51582428F7F042D3(ClientStaticMethod<uint> __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, uint arg)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_3A9949C7F5CF4C2A(__instance, reliability, transportConnections, arg);
	}

	[_542A381FC1D44BA3(typeof(ClientStaticMethod<uint>), "Invoke", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(uint)
	})]
	public static bool _4E3EC82FFCF847C3(ClientStaticMethod<uint> __instance, ENetReliability reliability, ITransportConnection transportConnection, uint arg)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_2B4193F94A734FAF.FBD24C93F0844D3C.Clear();
		_2B4193F94A734FAF.FBD24C93F0844D3C.Add(transportConnection);
		_3A9949C7F5CF4C2A(__instance, reliability, _2B4193F94A734FAF.FBD24C93F0844D3C, arg);
		return _2B4193F94A734FAF.FBD24C93F0844D3C.Count > 0;
	}

	public static void _3A9949C7F5CF4C2A(ClientStaticMethod<uint> _9AE861BCAA8142AE, ENetReliability A2A31F5081944C0F, List<ITransportConnection> _0B4D82B3F25949A9, uint _613A34A88D04410E)
	{
		string text = _2B4193F94A734FAF._65BC78CFA56840D0((ClientMethodHandle)(object)_9AE861BCAA8142AE);
		if (text == "ReceiveDestroySingleVehicle")
		{
			ThreadUtil.assertIsGameThread();
			if (_2B4193F94A734FAF.FFA26FAB3AA94112)
			{
				return;
			}
			{
				foreach (ITransportConnection item in _0B4D82B3F25949A9)
				{
					SteamPlayer val = Provider.findPlayer(item);
					if (val != null)
					{
						A3116505AAB24996._69C6AFA769194D6F(val.player)?._83B3415EF0E34C51.E30CF0C5A95049BF(_613A34A88D04410E);
					}
				}
				return;
			}
		}
		if (!(text == "ReceiveVehicleExploded"))
		{
			return;
		}
		for (int num = _0B4D82B3F25949A9.Count - 1; num >= 0; num--)
		{
			SteamPlayer val2 = Provider.findPlayer(_0B4D82B3F25949A9[num]);
			if (val2 != null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val2.player);
				if (a3116505AAB != null)
				{
					_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.F424C4A47EFA4596(_613A34A88D04410E);
					if (obj != null)
					{
						obj.C4AD1DF4F6E1475E = true;
						obj._7A9750FB420B45A6 = false;
						obj.AE752C85788B4E77 = false;
						obj.C713EBE2590F4E41 = false;
						if (!obj.BB8633A6EFF8468C)
						{
							_0B4D82B3F25949A9.RemoveAt(num);
						}
					}
				}
			}
		}
	}

	public static void B7B0E288AF484EF2(ITransportConnection _284CF91AD959454A, _087B17044C8447C2[] _2EA18F3351A64A8C, int A0AC237BBA7D44F7)
	{
		for (int i = 0; i < A0AC237BBA7D44F7; i++)
		{
			_087B17044C8447C2 obj = _2EA18F3351A64A8C[i];
			_2B4193F94A734FAF.FFA26FAB3AA94112 = true;
			_5A42424918F54E84.Invoke((ENetReliability)0, _284CF91AD959454A, obj.DEB09FE855AE49DB);
			_2B4193F94A734FAF.FFA26FAB3AA94112 = false;
		}
	}

	public static void FC8EE84CBF844C5F(ITransportConnection _0795A3D7A57B4663, _087B17044C8447C2[] _0765D308A1D3436F, int _8C05AFB6F3D748EB)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < _8C05AFB6F3D748EB; i++)
		{
			_087B17044C8447C2 obj = _0765D308A1D3436F[i];
			for (byte b = 0; b < obj._2F395796086E4AB0.Length; b++)
			{
				if (obj._2F395796086E4AB0[b] != CSteamID.Nil)
				{
					_2B4193F94A734FAF.FFA26FAB3AA94112 = true;
					_684313DC9C944857.Invoke((ENetReliability)0, _0795A3D7A57B4663, obj.DEB09FE855AE49DB, b, PlayerManager.CulledPosition, (byte)0, true);
					_2B4193F94A734FAF.FFA26FAB3AA94112 = false;
					FB19ACF0E0D043CD(_0795A3D7A57B4663, b, obj._2F395796086E4AB0[b], BD62043649A04BD7: false, _462C18A65EAB4629: false);
				}
			}
		}
	}

	public static void FB19ACF0E0D043CD(ITransportConnection _9B7B16D360864AEF, byte _8B744B8B94894AB8, CSteamID _92CE984759264392, bool BD62043649A04BD7, bool _462C18A65EAB4629)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		Player player = PlayerTool.getPlayer(_92CE984759264392);
		if ((Object)(object)player != (Object)null)
		{
			if (!BD62043649A04BD7)
			{
				_2B4193F94A734FAF.FFA26FAB3AA94112 = true;
				C2A6FB1177EE4D14.Invoke(((PlayerCaller)player.stance).GetNetId(), (ENetReliability)0, _9B7B16D360864AEF, (EPlayerStance)((!_462C18A65EAB4629) ? 3 : ((_8B744B8B94894AB8 == 0) ? 6 : 7)));
				_2B4193F94A734FAF.FFA26FAB3AA94112 = false;
			}
			_2B4193F94A734FAF.FFA26FAB3AA94112 = true;
			C2E3989A57A5491C.Invoke(player.GetNetId(), (ENetReliability)0, _9B7B16D360864AEF, PlayerManager.CulledPosition, (byte)0);
			_2B4193F94A734FAF.FFA26FAB3AA94112 = false;
		}
	}
}
