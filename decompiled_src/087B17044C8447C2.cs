using System;
using Microsoft.Extensions.Configuration;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

public class _087B17044C8447C2
{
	public class _71C33CCAC4054724
	{
		public struct BA62D461F2B04371
		{
			public float BE4AF20CF3034F36;

			public PhysicsMaterialNetId _9890E7EA28F246AF;
		}

		public uint _7308E79B9FC942A7;

		public Vector3 DA95D0492C1543C0;

		public Quaternion BCED77D0DB6E4C76;

		public float _81714811F8D94580;

		public float _2AB60864D73C4A18;

		public float _236D92A7A69C4003;

		public float _3BDE76AAB28D423C;

		public bool _7886DC8126EB49FB;

		public _087B17044C8447C2? _08D49DAEA84D4F1F;

		public BA62D461F2B04371[] _002C432B3EAC4082 = Array.Empty<BA62D461F2B04371>();

		public uint BDB4C98814154970;

		public float BB4EF4D666D64F90;
	}

	private static int _561E633B3A124657;

	private static int _81EA1F9921484FAD;

	public Guid _1868F026CB5F4E8E;

	public VehicleAsset? _5487C62CF9DC433A;

	public ushort _3B8B8C1D6075410D;

	public ushort A6580BD9091D4B23;

	public Vector3 B92980C9711F4EB7;

	public Quaternion _2B15AB43587A4D02;

	public bool _7A9750FB420B45A6;

	public bool AE752C85788B4E77;

	public bool C713EBE2590F4E41;

	public bool _9B99B99CF7B643FE;

	public ushort D8A705E2547D4658;

	public bool C4AD1DF4F6E1475E;

	public ushort D6D573E4F5634F10;

	public ushort _58F4F1E53C5347CE;

	public CSteamID _10EE6A914786423D;

	public CSteamID _2C48DDCF175D45F1;

	public bool D5D10DE6B19D4008;

	public CSteamID[] _2F395796086E4AB0 = Array.Empty<CSteamID>();

	public uint DEB09FE855AE49DB;

	public byte _000BEE2C871E45F4;

	public NetId FC3A17294F3E41FE;

	public Color32 E9DAEDF6796349E3;

	public float[] _9072B63C552840B9 = Array.Empty<float>();

	public bool BB8633A6EFF8468C;

	public bool _84FBBCC10ECA454B;

	public bool D3D432C5496746C1;

	public bool C78D9091A5D444E1(SteamPlayer P_0, Vector3 P_1)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Invalid comparison between Unknown and I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Invalid comparison between Unknown and I4
		float horizontalSqrMagnitude;
		int num;
		if (_2A320E2F1A3D4AAC.B5DBDA6B08C74F8A)
		{
			VehicleAsset? val = _5487C62CF9DC433A;
			if (val == null || (int)val.engine != 5)
			{
				if (!D3D432C5496746C1)
				{
					horizontalSqrMagnitude = Vector3Ex.GetHorizontalSqrMagnitude(B92980C9711F4EB7 - P_1);
					VehicleAsset? val2 = _5487C62CF9DC433A;
					if (val2 == null || (int)val2.engine != 0)
					{
						VehicleAsset? val3 = _5487C62CF9DC433A;
						if (val3 == null || (int)val3.engine != 4)
						{
							num = _561E633B3A124657 * _561E633B3A124657;
							goto IL_007f;
						}
					}
					num = _81EA1F9921484FAD * _81EA1F9921484FAD;
					goto IL_007f;
				}
				goto IL_008a;
			}
		}
		return true;
		IL_008a:
		return true;
		IL_007f:
		if (!(horizontalSqrMagnitude <= (float)num))
		{
			return _10A18776B9F14544(P_0);
		}
		goto IL_008a;
	}

	public bool _10A18776B9F14544(SteamPlayer P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		CSteamID steamID = P_0.playerID.steamID;
		bool flag = P_0.player.quests.groupID != CSteamID.Nil;
		CSteamID[] array = _2F395796086E4AB0;
		foreach (CSteamID val in array)
		{
			if (val == CSteamID.Nil)
			{
				continue;
			}
			if (steamID == val)
			{
				return true;
			}
			if (flag)
			{
				SteamPlayer steamPlayer = PlayerTool.getSteamPlayer(val);
				if (steamPlayer != null && steamPlayer.isMemberOfSameGroupAs(P_0))
				{
					return true;
				}
			}
		}
		return false;
	}

	public _087B17044C8447C2 _62F3FBE1CBBD4F18()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		return new _087B17044C8447C2
		{
			_1868F026CB5F4E8E = _1868F026CB5F4E8E,
			_5487C62CF9DC433A = _5487C62CF9DC433A,
			_3B8B8C1D6075410D = _3B8B8C1D6075410D,
			A6580BD9091D4B23 = A6580BD9091D4B23,
			B92980C9711F4EB7 = B92980C9711F4EB7,
			_2B15AB43587A4D02 = _2B15AB43587A4D02,
			_7A9750FB420B45A6 = _7A9750FB420B45A6,
			AE752C85788B4E77 = AE752C85788B4E77,
			C713EBE2590F4E41 = C713EBE2590F4E41,
			_9B99B99CF7B643FE = _9B99B99CF7B643FE,
			D8A705E2547D4658 = D8A705E2547D4658,
			C4AD1DF4F6E1475E = C4AD1DF4F6E1475E,
			D6D573E4F5634F10 = D6D573E4F5634F10,
			_58F4F1E53C5347CE = _58F4F1E53C5347CE,
			_10EE6A914786423D = _10EE6A914786423D,
			_2C48DDCF175D45F1 = _2C48DDCF175D45F1,
			D5D10DE6B19D4008 = D5D10DE6B19D4008,
			_2F395796086E4AB0 = (CSteamID[])_2F395796086E4AB0.Clone(),
			DEB09FE855AE49DB = DEB09FE855AE49DB,
			_000BEE2C871E45F4 = _000BEE2C871E45F4,
			FC3A17294F3E41FE = FC3A17294F3E41FE,
			E9DAEDF6796349E3 = E9DAEDF6796349E3,
			_9072B63C552840B9 = (float[])_9072B63C552840B9.Clone(),
			BB8633A6EFF8468C = BB8633A6EFF8468C
		};
	}

	public static void _860B6225B78349C7(IConfiguration P_0)
	{
		((object)P_0).Equals((object?)null);
		((object)P_0).Equals((object?)null);
	}

	unsafe static _087B17044C8447C2()
	{
		*(int*)2807131446856uL = 512;
		*(int*)2807131446860uL = 384;
	}
}
