using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HarmonyLib;
using SDG.NetPak;
using SDG.NetTransport;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

internal class _2B4193F94A734FAF
{
	private enum _18F98ADA88B2427D : byte
	{
		None,
		MultipleVehicles,
		SingleVehicle,
		VehicleStates,
		DestroyAllVehicles,
		MultipleBarricades
	}

	private sealed class _20AA812B164143D2 : IEqualityComparer<ClientMethodInfo>
	{
		public static readonly _20AA812B164143D2 Instance = new _20AA812B164143D2();

		public bool Equals(ClientMethodInfo CC5C66C03BE441D6, ClientMethodInfo _7B90FD3C62644B7F)
		{
			return CC5C66C03BE441D6 == _7B90FD3C62644B7F;
		}

		bool IEqualityComparer<ClientMethodInfo>.Equals(ClientMethodInfo CC5C66C03BE441D6, ClientMethodInfo _7B90FD3C62644B7F)
		{
			//ILSpy generated this explicit interface implementation from .override directive in Equals
			return this.Equals(CC5C66C03BE441D6, _7B90FD3C62644B7F);
		}

		public int GetHashCode(ClientMethodInfo _0EFC13FB200041EE)
		{
			return RuntimeHelpers.GetHashCode(_0EFC13FB200041EE);
		}

		int IEqualityComparer<ClientMethodInfo>.GetHashCode(ClientMethodInfo _0EFC13FB200041EE)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetHashCode
			return this.GetHashCode(_0EFC13FB200041EE);
		}
	}

	private static readonly Func<ClientMethodHandle, NetPakWriter> B0BDA1819CB54912;

	private static readonly Action<ClientMethodHandle, NetPakWriter> CC3543183DD44188;

	private static readonly Func<NetPakReader> FB31EE37237E4823;

	private static readonly Func<NetPakWriter> F106F11CDCF04125;

	private static readonly FieldRef<ClientMethodHandle, ClientMethodInfo> _9E81B2B0A8224F3E;

	private static readonly FieldRef<int> _9C25F55BA25D43F5;

	private static readonly ClientStaticMethod _223771D37BD84552;

	private static readonly FieldRef<ClientMethodInfo, string> _0CD8E1C8E4604A5E;

	private static readonly Func<VehicleAsset, bool> C23C5278BD244939;

	protected static readonly List<ITransportConnection> FBD24C93F0844D3C;

	private static readonly List<_087B17044C8447C2> _3F4B5C8C4D3F42A0;

	private static readonly List<_087B17044C8447C2> _1924029EDD3D4C05;

	private static readonly Dictionary<ClientMethodInfo, _18F98ADA88B2427D> A8A87EFB7557420E;

	protected static byte[] DFC3C23CC7F04D23;

	public static bool FFA26FAB3AA94112;

	private static _18F98ADA88B2427D F5BD9EE8965C4DA1(ClientMethodInfo _9777A866794749D4)
	{
		if (A8A87EFB7557420E.TryGetValue(_9777A866794749D4, out var value))
		{
			return value;
		}
		value = _0CD8E1C8E4604A5E.Invoke(_9777A866794749D4) switch
		{
			"ReceiveMultipleVehicles" => _18F98ADA88B2427D.MultipleVehicles, 
			"ReceiveSingleVehicle" => _18F98ADA88B2427D.SingleVehicle, 
			"ReceiveDestroyAllVehicles" => _18F98ADA88B2427D.DestroyAllVehicles, 
			"ReceiveMultipleBarricades" => _18F98ADA88B2427D.MultipleBarricades, 
			_ => _18F98ADA88B2427D.None, 
		};
		A8A87EFB7557420E[_9777A866794749D4] = value;
		return value;
	}

	[_542A381FC1D44BA3(typeof(ClientMethodHandle), "SendAndLoopbackIfLocal", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(ITransportConnection),
		typeof(NetPakWriter)
	})]
	public static bool A21596DC1A5047F5(ClientMethodHandle __instance, ENetReliability reliability, ITransportConnection transportConnection, NetPakWriter writer)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		writer.Flush();
		FBD24C93F0844D3C.Clear();
		FBD24C93F0844D3C.Add(transportConnection);
		F69C69C04FE44959(__instance, reliability, FBD24C93F0844D3C, writer);
		if (FBD24C93F0844D3C.Count > 0)
		{
			transportConnection.Send(writer.buffer, (long)writer.writeByteIndex, reliability);
		}
		return false;
	}

	[_542A381FC1D44BA3(typeof(ClientMethodHandle), "SendAndLoopbackIfAnyAreLocal", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(NetPakWriter)
	})]
	public static bool _347F19B86C45429C(ClientMethodHandle __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, NetPakWriter writer)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		writer.Flush();
		F69C69C04FE44959(__instance, reliability, transportConnections, writer);
		foreach (ITransportConnection transportConnection in transportConnections)
		{
			transportConnection.Send(writer.buffer, (long)writer.writeByteIndex, reliability);
		}
		return false;
	}

	[_542A381FC1D44BA3(typeof(ClientMethodHandle), "SendAndLoopback", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(ENetReliability),
		typeof(List<ITransportConnection>),
		typeof(NetPakWriter)
	})]
	public static bool CC26B3A904584B82(ClientMethodHandle __instance, ENetReliability reliability, List<ITransportConnection> transportConnections, NetPakWriter writer)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		writer.Flush();
		F69C69C04FE44959(__instance, reliability, transportConnections, writer);
		foreach (ITransportConnection transportConnection in transportConnections)
		{
			transportConnection.Send(writer.buffer, (long)writer.writeByteIndex, reliability);
		}
		CC3543183DD44188(__instance, writer);
		return false;
	}

	private static void F69C69C04FE44959(ClientMethodHandle D75E7FA97FDB4668, ENetReliability _861E4DC30C164334, List<ITransportConnection> _844561AB1A6F48E6, NetPakWriter _7A5AA502D8094A7D)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		if (_844561AB1A6F48E6.Count == 0)
		{
			return;
		}
		_18F98ADA88B2427D obj = F5BD9EE8965C4DA1(_9E81B2B0A8224F3E.Invoke(D75E7FA97FDB4668));
		if (obj == _18F98ADA88B2427D.None)
		{
			return;
		}
		A19CBF069C964833._40FE7AC3F69F4B10 aBB07B32EA8A499F = _1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F;
		A19CBF069C964833._40FE7AC3F69F4B10 obj2 = _1DB744298E9F4B09._052FBC588F454484._769F45D6312C4B96;
		aBB07B32EA8A499F?._10270708481F445D();
		obj2?._10270708481F445D();
		try
		{
			_4488426129A8416F(obj, D75E7FA97FDB4668, _861E4DC30C164334, _844561AB1A6F48E6, _7A5AA502D8094A7D);
		}
		finally
		{
			obj2?.F471762FF8094F2B(obj2.F27B18C1D6E54F89());
			aBB07B32EA8A499F?.F471762FF8094F2B(aBB07B32EA8A499F.F27B18C1D6E54F89());
		}
	}

	private static void _4488426129A8416F(_18F98ADA88B2427D A7E43A1862A546AF, ClientMethodHandle _6C318B332A3F41F3, ENetReliability CA22F8958E7C4DF3, List<ITransportConnection> _5ECAB8B18C7642E2, NetPakWriter _568912260C7B4012)
	{
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		switch (A7E43A1862A546AF)
		{
		case _18F98ADA88B2427D.MultipleVehicles:
		{
			ThreadUtil.assertIsGameThread();
			NetPakReader val11 = DCE868FAD3C54E9C();
			val11.SetBufferSegmentCopy(_568912260C7B4012.buffer, DFC3C23CC7F04D23, _568912260C7B4012.writeByteIndex);
			val11.Reset();
			EClientMessage val12 = default;
			EClientMessage_NetEnum.ReadEnum(val11, ref val12);
			uint num5 = default;
			val11.ReadBits(_9C25F55BA25D43F5.Invoke(), ref num5);
			ushort num6 = default;
			SystemNetPakReaderEx.ReadUInt16(val11, ref num6);
			if (num6 == 0)
			{
				break;
			}
			_1924029EDD3D4C05.Clear();
			for (int i = 0; i < num6; i++)
			{
				_1924029EDD3D4C05.Add(_2C944D6544674317(val11));
			}
			for (int num7 = _5ECAB8B18C7642E2.Count - 1; num7 >= 0; num7--)
			{
				ITransportConnection val13 = _5ECAB8B18C7642E2[num7];
				SteamPlayer val14 = Provider.findPlayer(val13);
				if (val14 != null)
				{
					A3116505AAB24996 a3116505AAB3 = A3116505AAB24996._69C6AFA769194D6F(val14.player);
					if (a3116505AAB3 != null)
					{
						Vector3 position2 = ((Component)val14.player).transform.position;
						_3F4B5C8C4D3F42A0.Clear();
						foreach (_087B17044C8447C2 item in _1924029EDD3D4C05)
						{
							_087B17044C8447C2 obj4 = item._62F3FBE1CBBD4F18();
							a3116505AAB3._83B3415EF0E34C51._5A36DD1A17374A38[obj4.DEB09FE855AE49DB] = obj4;
							obj4.BB8633A6EFF8468C = obj4.C78D9091A5D444E1(val14, position2);
							if (obj4.BB8633A6EFF8468C)
							{
								_3F4B5C8C4D3F42A0.Add(obj4);
							}
							else
							{
								if (!_2A320E2F1A3D4AAC.B5DBDA6B08C74F8A)
								{
									continue;
								}
								for (byte b3 = 0; b3 < obj4._2F395796086E4AB0.Length; b3++)
								{
									if (obj4._2F395796086E4AB0[b3] != CSteamID.Nil)
									{
										E0979537EFEC4491.FB19ACF0E0D043CD(val13, b3, obj4._2F395796086E4AB0[b3], BD62043649A04BD7: false, _462C18A65EAB4629: false);
									}
								}
							}
						}
						if (_2A320E2F1A3D4AAC.B5DBDA6B08C74F8A)
						{
							NetPakWriter val15 = _1A49B55ABF484696();
							val15.Reset();
							EClientMessage_NetEnum.WriteEnum(val15, val12);
							val15.WriteBits(num5, _9C25F55BA25D43F5.Invoke());
							SystemNetPakWriterEx.WriteUInt16(val15, (ushort)_3F4B5C8C4D3F42A0.Count);
							foreach (_087B17044C8447C2 item2 in _3F4B5C8C4D3F42A0)
							{
								F98C07E6372F4362(val15, item2, val14);
							}
							val15.Flush();
							val13.Send(val15.buffer, (long)val15.writeByteIndex, CA22F8958E7C4DF3);
							_5ECAB8B18C7642E2.RemoveAt(num7);
						}
					}
				}
			}
			break;
		}
		case _18F98ADA88B2427D.SingleVehicle:
		{
			ThreadUtil.assertIsGameThread();
			NetPakReader val6 = DCE868FAD3C54E9C();
			val6.SetBufferSegmentCopy(_568912260C7B4012.buffer, DFC3C23CC7F04D23, _568912260C7B4012.writeByteIndex);
			val6.Reset();
			EClientMessage val7 = default;
			EClientMessage_NetEnum.ReadEnum(val6, ref val7);
			uint num3 = default;
			val6.ReadBits(_9C25F55BA25D43F5.Invoke(), ref num3);
			_087B17044C8447C2 obj2 = _2C944D6544674317(val6);
			for (int num4 = _5ECAB8B18C7642E2.Count - 1; num4 >= 0; num4--)
			{
				ITransportConnection val8 = _5ECAB8B18C7642E2[num4];
				SteamPlayer val9 = Provider.findPlayer(val8);
				if (val9 != null)
				{
					A3116505AAB24996 a3116505AAB2 = A3116505AAB24996._69C6AFA769194D6F(val9.player);
					if (a3116505AAB2 != null)
					{
						Vector3 position = ((Component)val9.player).transform.position;
						_087B17044C8447C2 obj3 = obj2._62F3FBE1CBBD4F18();
						a3116505AAB2._83B3415EF0E34C51._5A36DD1A17374A38[obj3.DEB09FE855AE49DB] = obj3;
						obj3.BB8633A6EFF8468C = obj3.C78D9091A5D444E1(val9, position);
						if (!obj3.BB8633A6EFF8468C)
						{
							_5ECAB8B18C7642E2.RemoveAt(num4);
						}
						else if (_2A320E2F1A3D4AAC.B5DBDA6B08C74F8A)
						{
							NetPakWriter val10 = _1A49B55ABF484696();
							val10.Reset();
							EClientMessage_NetEnum.WriteEnum(val10, val7);
							val10.WriteBits(num3, _9C25F55BA25D43F5.Invoke());
							F98C07E6372F4362(val10, obj3, val9);
							val10.Flush();
							val8.Send(val10.buffer, (long)val10.writeByteIndex, CA22F8958E7C4DF3);
							_5ECAB8B18C7642E2.RemoveAt(num4);
						}
					}
				}
			}
			break;
		}
		case _18F98ADA88B2427D.DestroyAllVehicles:
			ThreadUtil.assertIsGameThread();
			{
				foreach (ITransportConnection item3 in _5ECAB8B18C7642E2)
				{
					SteamPlayer val5 = Provider.findPlayer(item3);
					if (val5 != null)
					{
						A3116505AAB24996._69C6AFA769194D6F(val5.player)?._83B3415EF0E34C51._5A36DD1A17374A38.Clear();
					}
				}
				break;
			}
		case _18F98ADA88B2427D.MultipleBarricades:
		{
			ThreadUtil.assertIsGameThread();
			if (FFA26FAB3AA94112)
			{
				break;
			}
			NetPakReader val = DCE868FAD3C54E9C();
			val.SetBufferSegmentCopy(_568912260C7B4012.buffer, DFC3C23CC7F04D23, _568912260C7B4012.writeByteIndex);
			val.Reset();
			EClientMessage val2 = default;
			EClientMessage_NetEnum.ReadEnum(val, ref val2);
			uint num = default;
			val.ReadBits(_9C25F55BA25D43F5.Invoke(), ref num);
			byte b = default;
			SystemNetPakReaderEx.ReadUInt8(val, ref b);
			byte b2 = default;
			SystemNetPakReaderEx.ReadUInt8(val, ref b2);
			NetId val3 = default;
			NetIdPakEx.ReadNetId(val, ref val3);
			if (val3 == NetId.INVALID)
			{
				break;
			}
			for (int num2 = _5ECAB8B18C7642E2.Count - 1; num2 >= 0; num2--)
			{
				SteamPlayer val4 = Provider.findPlayer(_5ECAB8B18C7642E2[num2]);
				if (val4 != null)
				{
					A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(val4.player);
					if (a3116505AAB != null)
					{
						_087B17044C8447C2 obj = a3116505AAB._83B3415EF0E34C51.D302F4FC9DA8422A(val3);
						if (obj != null && !obj.BB8633A6EFF8468C)
						{
							_5ECAB8B18C7642E2.RemoveAt(num2);
						}
					}
				}
			}
			break;
		}
		case _18F98ADA88B2427D.VehicleStates:
			break;
		}
	}

	private static void F98C07E6372F4362(NetPakWriter _624D8F0677544468, _087B17044C8447C2 _6E3A5BC4F1C944E2, SteamPlayer DCE34FB5A2E140F6)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		SystemNetPakWriterEx.WriteGuid(_624D8F0677544468, _6E3A5BC4F1C944E2._1868F026CB5F4E8E);
		SystemNetPakWriterEx.WriteUInt16(_624D8F0677544468, _6E3A5BC4F1C944E2._3B8B8C1D6075410D);
		SystemNetPakWriterEx.WriteUInt16(_624D8F0677544468, _6E3A5BC4F1C944E2.A6580BD9091D4B23);
		UnityNetPakWriterEx.WriteClampedVector3(_624D8F0677544468, _6E3A5BC4F1C944E2.B92980C9711F4EB7, 13, 8);
		UnityNetPakWriterEx.WriteQuaternion(_624D8F0677544468, _6E3A5BC4F1C944E2._2B15AB43587A4D02, 11);
		_624D8F0677544468.WriteBit(_6E3A5BC4F1C944E2._7A9750FB420B45A6);
		_624D8F0677544468.WriteBit(_6E3A5BC4F1C944E2.AE752C85788B4E77);
		_624D8F0677544468.WriteBit(_6E3A5BC4F1C944E2.C713EBE2590F4E41);
		_624D8F0677544468.WriteBit(_6E3A5BC4F1C944E2._9B99B99CF7B643FE);
		SystemNetPakWriterEx.WriteUInt16(_624D8F0677544468, _6E3A5BC4F1C944E2.D8A705E2547D4658);
		_624D8F0677544468.WriteBit(_6E3A5BC4F1C944E2.C4AD1DF4F6E1475E);
		SystemNetPakWriterEx.WriteUInt16(_624D8F0677544468, _6E3A5BC4F1C944E2.D6D573E4F5634F10);
		SystemNetPakWriterEx.WriteUInt16(_624D8F0677544468, _6E3A5BC4F1C944E2._58F4F1E53C5347CE);
		SteamworksNetPakWriterEx.WriteSteamID(_624D8F0677544468, (_6E3A5BC4F1C944E2._10EE6A914786423D != CSteamID.Nil && _6E3A5BC4F1C944E2._10EE6A914786423D != DCE34FB5A2E140F6.playerID.steamID) ? CSteamID.Nil : _6E3A5BC4F1C944E2._10EE6A914786423D);
		SteamworksNetPakWriterEx.WriteSteamID(_624D8F0677544468, _6E3A5BC4F1C944E2._2C48DDCF175D45F1);
		_624D8F0677544468.WriteBit(_6E3A5BC4F1C944E2.D5D10DE6B19D4008);
		SystemNetPakWriterEx.WriteUInt8(_624D8F0677544468, (byte)_6E3A5BC4F1C944E2._2F395796086E4AB0.Length);
		for (int i = 0; i < _6E3A5BC4F1C944E2._2F395796086E4AB0.Length; i++)
		{
			SteamworksNetPakWriterEx.WriteSteamID(_624D8F0677544468, _6E3A5BC4F1C944E2._2F395796086E4AB0[i]);
		}
		SystemNetPakWriterEx.WriteUInt32(_624D8F0677544468, _6E3A5BC4F1C944E2.DEB09FE855AE49DB);
		SystemNetPakWriterEx.WriteUInt8(_624D8F0677544468, _6E3A5BC4F1C944E2._000BEE2C871E45F4);
		NetIdPakEx.WriteNetId(_624D8F0677544468, _6E3A5BC4F1C944E2.FC3A17294F3E41FE);
		UnityNetPakWriterEx.WriteColor32RGBA(_624D8F0677544468, _6E3A5BC4F1C944E2.E9DAEDF6796349E3);
		SystemNetPakWriterEx.WriteUInt8(_624D8F0677544468, (byte)_6E3A5BC4F1C944E2._9072B63C552840B9.Length);
		for (int j = 0; j < _6E3A5BC4F1C944E2._9072B63C552840B9.Length; j++)
		{
			SystemNetPakWriterEx.WriteUnsignedNormalizedFloat(_624D8F0677544468, _6E3A5BC4F1C944E2._9072B63C552840B9[j], 4);
		}
	}

	private static _087B17044C8447C2 _2C944D6544674317(NetPakReader _726019DA35A240C5)
	{
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected Obj, but got Unknown
		_087B17044C8447C2 obj = new _087B17044C8447C2();
		SystemNetPakReaderEx.ReadGuid(_726019DA35A240C5, ref obj._1868F026CB5F4E8E);
		SystemNetPakReaderEx.ReadUInt16(_726019DA35A240C5, ref obj._3B8B8C1D6075410D);
		SystemNetPakReaderEx.ReadUInt16(_726019DA35A240C5, ref obj.A6580BD9091D4B23);
		UnityNetPakReaderEx.ReadClampedVector3(_726019DA35A240C5, ref obj.B92980C9711F4EB7, 13, 8);
		UnityNetPakReaderEx.ReadQuaternion(_726019DA35A240C5, ref obj._2B15AB43587A4D02, 11);
		_726019DA35A240C5.ReadBit(ref obj._7A9750FB420B45A6);
		_726019DA35A240C5.ReadBit(ref obj.AE752C85788B4E77);
		_726019DA35A240C5.ReadBit(ref obj.C713EBE2590F4E41);
		_726019DA35A240C5.ReadBit(ref obj._9B99B99CF7B643FE);
		SystemNetPakReaderEx.ReadUInt16(_726019DA35A240C5, ref obj.D8A705E2547D4658);
		_726019DA35A240C5.ReadBit(ref obj.C4AD1DF4F6E1475E);
		SystemNetPakReaderEx.ReadUInt16(_726019DA35A240C5, ref obj.D6D573E4F5634F10);
		SystemNetPakReaderEx.ReadUInt16(_726019DA35A240C5, ref obj._58F4F1E53C5347CE);
		SteamworksNetPakReaderEx.ReadSteamID(_726019DA35A240C5, ref obj._10EE6A914786423D);
		SteamworksNetPakReaderEx.ReadSteamID(_726019DA35A240C5, ref obj._2C48DDCF175D45F1);
		_726019DA35A240C5.ReadBit(ref obj.D5D10DE6B19D4008);
		byte b = default;
		SystemNetPakReaderEx.ReadUInt8(_726019DA35A240C5, ref b);
		obj._2F395796086E4AB0 = new CSteamID[b];
		for (int i = 0; i < b; i++)
		{
			SteamworksNetPakReaderEx.ReadSteamID(_726019DA35A240C5, ref obj._2F395796086E4AB0[i]);
		}
		SystemNetPakReaderEx.ReadUInt32(_726019DA35A240C5, ref obj.DEB09FE855AE49DB);
		SystemNetPakReaderEx.ReadUInt8(_726019DA35A240C5, ref obj._000BEE2C871E45F4);
		NetIdPakEx.ReadNetId(_726019DA35A240C5, ref obj.FC3A17294F3E41FE);
		UnityNetPakReaderEx.ReadColor32RGBA(_726019DA35A240C5, ref obj.E9DAEDF6796349E3);
		byte b2 = default;
		SystemNetPakReaderEx.ReadUInt8(_726019DA35A240C5, ref b2);
		obj._9072B63C552840B9 = new float[b2];
		for (int j = 0; j < b2; j++)
		{
			SystemNetPakReaderEx.ReadUnsignedNormalizedFloat(_726019DA35A240C5, 4, ref obj._9072B63C552840B9[j]);
		}
		obj._5487C62CF9DC433A = (VehicleAsset)Assets.find(obj._1868F026CB5F4E8E);
		return obj;
	}

	public static void C94D65522B8243AA(ITransportConnection _6F42DE3F84D94E3A, _087B17044C8447C2[] _49B9978E48D94546, int _325BC7E8A0C94AA5, SteamPlayer _113BFFB2318B4E75)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		int num = (_325BC7E8A0C94AA5 - 1) / 50 + 1;
		int num2 = 0;
		for (int i = 0; i < num; i++)
		{
			int num3 = num2 + 50;
			if (num3 > _325BC7E8A0C94AA5)
			{
				num3 = _325BC7E8A0C94AA5;
			}
			int num4 = num3 - num2;
			NetPakWriter val = BAEE1894942D4D1E((ClientMethodHandle)(object)_223771D37BD84552);
			SystemNetPakWriterEx.WriteUInt16(val, (ushort)num4);
			for (int j = num2; j < num3; j++)
			{
				F98C07E6372F4362(val, _49B9978E48D94546[j], _113BFFB2318B4E75);
			}
			val.Flush();
			_6F42DE3F84D94E3A.Send(val.buffer, (long)val.writeByteIndex, (ENetReliability)0);
			for (int k = num2; k < num3; k++)
			{
				_087B17044C8447C2 obj = _49B9978E48D94546[k];
				for (byte b = 0; b < obj._2F395796086E4AB0.Length; b++)
				{
					if (obj._2F395796086E4AB0[b] != CSteamID.Nil)
					{
						E0979537EFEC4491.FB19ACF0E0D043CD(_6F42DE3F84D94E3A, b, obj._2F395796086E4AB0[b], BD62043649A04BD7: false, _462C18A65EAB4629: true);
					}
				}
			}
			num2 = num3;
		}
	}

	protected static string _65BC78CFA56840D0(ClientMethodHandle C7962F17CC9A42D0)
	{
		return _0CD8E1C8E4604A5E.Invoke(_9E81B2B0A8224F3E.Invoke(C7962F17CC9A42D0));
	}

	protected static NetPakReader DCE868FAD3C54E9C()
	{
		return FB31EE37237E4823();
	}

	protected static NetPakWriter _1A49B55ABF484696()
	{
		return F106F11CDCF04125();
	}

	protected static NetPakWriter BAEE1894942D4D1E(ClientMethodHandle _0915A66F66B846BB)
	{
		return B0BDA1819CB54912(_0915A66F66B846BB);
	}

	static _2B4193F94A734FAF()
	{
		GC.KeepAlive(null);
	}
}
