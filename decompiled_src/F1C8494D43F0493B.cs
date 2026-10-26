using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

public class F1C8494D43F0493B
{
	private F065C3FBB6824DBC[] _82AE48E917EA409F;

	private int D4537BF74AB94AA5;

	private int _5356AE77C5F84637;

	private float _183C3D3F89E14749;

	private Vector3[] _8D71D7BC9FC84ACF;

	private int _7C66E74CF06B4FDB;

	private int F7E42E27508C4DF9;

	private float EF345DAEDB3E46AA;

	private bool _9CC661874AD248F6;

	private float _4AE96DE53FE646C6;

	private Vector3 B8AE7B56A4774E0A;

	private int _733A5BA96F4F4F2F;

	private float[] _29C4C8843DB34DB5;

	private int[] _983A7A6C805D4BA0;

	private float[] EE8395181CE34652;

	private int _3893DB55496E4317;

	private int _04FDF87DA40F4215;

	private int D7E6AC4E418B487E;

	private int _8D8D2E57BE25480C;

	private int _9EA55FE7005A4938;

	private int _32E1A69715414ED2;

	private int _8257BAAE51D64B19;

	private int _668BBB40D30E466C;

	private int _795C92D7C7FD49B9;

	private bool F7CF2D6894D84D25;

	private const float B6329B9318684DA4 = 0.01f;

	private const float _235BB2B07B874FBA = 0.85f;

	private const int _11C994544D5E4D82 = 6;

	private const int E7D859867BFC47ED = 50;

	private const int FFFFE8D694E845A6 = 5;

	private const float _34B179A0FD5E44D9 = 256f;

	private const int AFFCD2962F4E4FA2 = 19;

	private const int F51A42EC40714C9B = 38;

	private const int _648B87B0A4004904 = 38;

	private static readonly float BCEF274DC0E14429 = 22.25f;

	private const float _48F0C867300B43CD = 1f;

	private const float _2BC572BAE7FF49B8 = 90f;

	private const float _28CD3F38777B473A = 0.1f;

	private const float _1A388921C7C94A7F = 0.2f;

	private const float E30CC35755CA4640 = -0.1f;

	private const float CC39BA62062940E0 = 0.25f;

	private const int F147D4AF2A31418C = 13;

	private const int _03DFE987D5014392 = 38;

	public float _0110D07157A74BF8
	{
		get
		{
			return _183C3D3F89E14749;
		}
		set
		{
			_183C3D3F89E14749 = num;
		}
	}

	public F1C8494D43F0493B()
	{
		_82AE48E917EA409F = new F065C3FBB6824DBC[300];
		_8D71D7BC9FC84ACF = new Vector3[50];
		_29C4C8843DB34DB5 = new float[38];
		_983A7A6C805D4BA0 = new int[38];
		EE8395181CE34652 = new float[38];
		D4537BF74AB94AA5 = 0;
		_5356AE77C5F84637 = 0;
		_7C66E74CF06B4FDB = 0;
		F7E42E27508C4DF9 = 0;
	}

	public void EEFD181D01164D49()
	{
		D4537BF74AB94AA5 = 0;
		_5356AE77C5F84637 = 0;
		_9CC661874AD248F6 = false;
		F7CF2D6894D84D25 = false;
		_32E1A69715414ED2 = 0;
		_733A5BA96F4F4F2F = 0;
	}

	public void CECE6312F32C491C(Player P_0, EPlayerGesture P_1, PlayerStateUpdate P_2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		int num = D4537BF74AB94AA5 * 6;
		int num2 = _32AD7C20BC5744AA(P_0.stance.stance);
		int num3 = _87BE2232E0224468(P_1);
		int num4 = E48CA8EDC7FA48D3(P_0.stance.stance);
		if (F7CF2D6894D84D25 && (num2 != _8257BAAE51D64B19 || num3 != _668BBB40D30E466C || num4 != _795C92D7C7FD49B9))
		{
			D7E6AC4E418B487E = _8257BAAE51D64B19;
			_8D8D2E57BE25480C = _668BBB40D30E466C;
			_9EA55FE7005A4938 = _795C92D7C7FD49B9;
			bool flag = _8257BAAE51D64B19 == 3 || num2 == 3;
			_32E1A69715414ED2 = (flag ? 38 : 13);
		}
		C5EC0A4992BD4040(P_0, P_1, P_2, _82AE48E917EA409F, num);
		_8257BAAE51D64B19 = num2;
		_668BBB40D30E466C = num3;
		_795C92D7C7FD49B9 = num4;
		F7CF2D6894D84D25 = true;
		if (_32E1A69715414ED2 > 0)
		{
			_32E1A69715414ED2--;
		}
		_8D71D7BC9FC84ACF[_7C66E74CF06B4FDB] = B8AE7B56A4774E0A;
		_7C66E74CF06B4FDB = (_7C66E74CF06B4FDB + 1) % 50;
		F7E42E27508C4DF9 = Mathf.Min(F7E42E27508C4DF9 + 1, 50);
		EF345DAEDB3E46AA = _4AE96DE53FE646C6;
		_9CC661874AD248F6 = true;
		D4537BF74AB94AA5 = (D4537BF74AB94AA5 + 1) % 50;
		_5356AE77C5F84637 = Mathf.Min(_5356AE77C5F84637 + 1, 50);
	}

	public bool _635085B12CF4471D(ELimb P_0, Vector3 P_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		int num = Mathf.Min(5, _733A5BA96F4F4F2F);
		if (_5356AE77C5F84637 <= num)
		{
			return true;
		}
		int num2 = (int)_09FCEF8A22DF4388(P_0);
		int num3 = D4537BF74AB94AA5 - num;
		if (num3 < 0)
		{
			num3 += 50;
		}
		int num4 = _5356AE77C5F84637 - num;
		int num5 = 0;
		bool flag = false;
		Bounds val = default;
		do
		{
			num3--;
			if (num3 < 0)
			{
				num3 = 49;
			}
			Bounds val2 = _82AE48E917EA409F[num3 * 6 + num2]._283518A6C5444B80;
			if (val2.Contains(P_1))
			{
				return true;
			}
			if (flag)
			{
				Bounds val3 = val;
				val3.Encapsulate(val2);
				if (val3.Contains(P_1))
				{
					return true;
				}
			}
			val = val2;
			flag = true;
			num5++;
		}
		while (num5 < num4);
		return false;
	}

	public void _4C62EF0AE3694F6E(B15E2605ED474C2A P_0, Player P_1, Player P_2, ELimb P_3, Vector3 P_4)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		P_0._08C17298D4F44F01 = P_1.channel.owner.playerID.steamID.m_SteamID;
		P_0.AF8591C5AC444EA8 = P_2.channel.owner.playerID.steamID.m_SteamID;
		P_0._341D11B636DB4405 = _5D3F4B1BF6654E52.C8F36D848FF540AB(P_1);
		P_0._0CEF90795CAB44B1 = P_3;
		P_0._9F9A4C6A32564D6B = P_4;
		int num = D4537BF74AB94AA5;
		for (int i = 0; i < _5356AE77C5F84637; i++)
		{
			num--;
			if (num < 0)
			{
				num = 49;
			}
			List<_03D84A7376B94EA1> list = P_0._7856127C6B6646D5(6);
			for (int j = 0; j < 6; j++)
			{
				F065C3FBB6824DBC f065C3FBB6824DBC = _82AE48E917EA409F[num * 6 + j];
				list.Add(new _03D84A7376B94EA1
				{
					FE10F57D9E4C4038 = f065C3FBB6824DBC._8999679655554A71,
					E8F951C697CA42A1 = f065C3FBB6824DBC._6657A291E47D4800,
					_93E9CC9B28A746F4 = f065C3FBB6824DBC.FEB23D8636C94AF3,
					D682CB523DFE4EE9 = f065C3FBB6824DBC.AA36EB8957524BDB,
					_034C4849684C4024 = f065C3FBB6824DBC.C8C83BE8BE8B4170,
					_2497939BA36B42E1 = f065C3FBB6824DBC._01B595B6CDDA44C4,
					C20F93DA1DAE4749 = f065C3FBB6824DBC._95D153F5FEA44EC4,
					_91C5E8531EE94644 = f065C3FBB6824DBC._9D5B595F31C64DE2,
					_41C3CAFB66204BD5 = f065C3FBB6824DBC._31CA2DF0B3554C53,
					D555C6197D204B34 = f065C3FBB6824DBC.B632EBEB22684DA6,
					_0030C6F54B664C64 = f065C3FBB6824DBC._283518A6C5444B80,
					F4EBE4552D264906 = f065C3FBB6824DBC._45A014E3F8BC44DA,
					_499A2B3C876C406D = f065C3FBB6824DBC._7955B10E02AC4EAF.eulerAngles
				});
			}
			P_0.E2102A94A4944897.Add(list);
		}
	}

	public static _41E9235EFE5A4C06 _09FCEF8A22DF4388(ELimb P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected I4, but got Unknown
		switch ((int)P_0)
		{
		case 13:
			return _41E9235EFE5A4C06.HEAD;
		case 4:
		case 5:
			return _41E9235EFE5A4C06.ARM_LEFT;
		case 6:
		case 7:
			return _41E9235EFE5A4C06.ARM_RIGHT;
		case 0:
		case 1:
			return _41E9235EFE5A4C06.LEG_LEFT;
		case 2:
		case 3:
			return _41E9235EFE5A4C06.LEG_RIGHT;
		default:
			return _41E9235EFE5A4C06.TORSO;
		}
	}

	public void C5EC0A4992BD4040(Player P_0, EPlayerGesture P_1, PlayerStateUpdate P_2, F065C3FBB6824DBC[] P_3, int P_4)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Invalid comparison between Unknown and I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Invalid comparison between Unknown and I4
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Invalid comparison between Unknown and I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Unknown result type (might be due to invalid IL or missing references)
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		Vector3 pos = default;
		Quaternion val = default;
		float num;
		if ((Object)(object)P_0.movement.getVehicle() == (Object)null)
		{
			pos = P_2.pos;
			val = Quaternion.Euler(0f, (float)(int)P_2.rot * 2f, 0f);
			num = (int)P_2.angle;
		}
		else
		{
			((Component)P_0).transform.GetPositionAndRotation(ref pos, ref val);
			num = P_0.look.pitch;
		}
		_4AE96DE53FE646C6 = val.eulerAngles.y;
		B8AE7B56A4774E0A = pos;
		if (!_680955959F674DCC.E4DFDEB8A1664084)
		{
			for (int i = 0; i < 6; i++)
			{
				P_3[P_4 + i] = new F065C3FBB6824DBC
				{
					_283518A6C5444B80 = new Bounds(pos, new Vector3(1000f, 1000f, 1000f)),
					_8999679655554A71 = (_41E9235EFE5A4C06)i,
					_6657A291E47D4800 = P_0.stance.stance,
					FEB23D8636C94AF3 = P_1,
					_95D153F5FEA44EC4 = num,
					_45A014E3F8BC44DA = pos,
					_7955B10E02AC4EAF = val
				};
			}
			return;
		}
		EPlayerStance stance = P_0.stance.stance;
		float num2 = (P_0.channel.owner.IsLeftHanded ? (-1f) : 1f);
		int num3 = Mathf.RoundToInt(Mathf.Clamp((float)P_0.animator.lean, -1f, 1f) * num2);
		int num4 = _87BE2232E0224468(P_1);
		int num5 = _32AD7C20BC5744AA(stance);
		int num6 = E48CA8EDC7FA48D3(stance);
		bool flag = _08C3369E2CA74530(pos, out var flag2);
		if (flag2)
		{
			_733A5BA96F4F4F2F = 0;
		}
		else if (_733A5BA96F4F4F2F < 5)
		{
			_733A5BA96F4F4F2F++;
		}
		bool hasValidUseable = P_0.equipment.HasValidUseable;
		float num7 = CCE3DD1C74514565(stance);
		float num8 = (((int)stance == 6 || (int)stance == 7 || (int)P_1 == 16) ? 90f : num);
		_3893DB55496E4317 = (_3893DB55496E4317 + 1) % 38;
		_29C4C8843DB34DB5[_3893DB55496E4317] = num8;
		_983A7A6C805D4BA0[_3893DB55496E4317] = num3;
		EE8395181CE34652[_3893DB55496E4317] = num7;
		_04FDF87DA40F4215 = Mathf.Min(_04FDF87DA40F4215 + 1, 38);
		float num9 = num8;
		float num10 = num8;
		int num11 = num3;
		int num12 = num3;
		float num13 = num7;
		float num14 = num7;
		for (int j = 0; j < _04FDF87DA40F4215; j++)
		{
			int num15 = _3893DB55496E4317 - j;
			if (num15 < 0)
			{
				num15 += 38;
			}
			if (j < 19)
			{
				num9 = Mathf.Min(num9, _29C4C8843DB34DB5[num15]);
				num10 = Mathf.Max(num10, _29C4C8843DB34DB5[num15]);
			}
			num11 = Mathf.Min(num11, _983A7A6C805D4BA0[num15]);
			num12 = Mathf.Max(num12, _983A7A6C805D4BA0[num15]);
			num13 = Mathf.Min(num13, EE8395181CE34652[num15]);
			num14 = Mathf.Max(num14, EE8395181CE34652[num15]);
		}
		float num16 = (_9CC661874AD248F6 ? (Mathf.Abs(Mathf.DeltaAngle(EF345DAEDB3E46AA, _4AE96DE53FE646C6)) * (MathF.PI / 180f)) : 0f);
		Vector3 val2 = F353DF279A6F4CC3(num5);
		Vector3 val3 = ((_32E1A69715414ED2 > 0) ? F353DF279A6F4CC3(D7E6AC4E418B487E) : val2);
		for (int k = 0; k < 6; k++)
		{
			_74983A91751E45E1(num5, num4, num6, flag, num8, num3, k, out var val4, out var val5);
			val4 += val2;
			_991553D641194A7B(num5, num4, num6, flag, num9, num10, num11, num12, k, val2, ref val4, ref val5);
			if (_32E1A69715414ED2 > 0)
			{
				_74983A91751E45E1(D7E6AC4E418B487E, _8D8D2E57BE25480C, _9EA55FE7005A4938, flag, num8, num3, k, out var val6, out var val7);
				_797CC3B38B1F495F(ref val4, ref val5, val6 + val3, val7);
				_991553D641194A7B(D7E6AC4E418B487E, _8D8D2E57BE25480C, _9EA55FE7005A4938, flag, num9, num10, num11, num12, k, val3, ref val4, ref val5);
			}
			if (num16 > 0f)
			{
				float num17 = Mathf.Min((Mathf.Sqrt(val4.x * val4.x + val4.z * val4.z) + Mathf.Max(val5.x, val5.z)) * (1f - Mathf.Cos(num16 * 0.5f)), 0.25f);
				val5.x += num17;
				val5.z += num17;
			}
			if (k == 0 && num14 > num13)
			{
				float num18 = num14 - num13;
				val5.x += num18;
				val5.y += num18;
				val5.z += num18;
			}
			Bounds val8 = default;
			bool flag3 = false;
			for (int l = 0; l < 8; l++)
			{
				Vector3 val9 = new Vector3((val4.x + (((l & 1) == 0) ? (0f - val5.x) : val5.x)) * num2, val4.y + (((l & 2) == 0) ? (0f - val5.y) : val5.y), val4.z + (((l & 4) == 0) ? (0f - val5.z) : val5.z));
				Vector3 val10 = pos + val * val9;
				if (!flag3)
				{
					val8 = new Bounds(val10, Vector3.zero);
					flag3 = true;
				}
				else
				{
					val8.Encapsulate(val10);
				}
			}
			val8.Expand(_183C3D3F89E14749 * 2f);
			if (hasValidUseable && (k == 2 || k == 3))
			{
				val8.Expand(1.7f);
			}
			P_3[P_4 + k] = new F065C3FBB6824DBC
			{
				_283518A6C5444B80 = val8,
				_8999679655554A71 = (_41E9235EFE5A4C06)k,
				_6657A291E47D4800 = stance,
				FEB23D8636C94AF3 = P_1,
				AA36EB8957524BDB = num3,
				C8C83BE8BE8B4170 = num2,
				_01B595B6CDDA44C4 = flag,
				_95D153F5FEA44EC4 = num,
				_9D5B595F31C64DE2 = num9,
				_31CA2DF0B3554C53 = num10,
				B632EBEB22684DA6 = num12 - num11,
				_45A014E3F8BC44DA = pos,
				_7955B10E02AC4EAF = val
			};
		}
	}

	private static void _991553D641194A7B(int P_0, int P_1, int P_2, bool P_3, float P_4, float P_5, int P_6, int P_7, int P_8, Vector3 P_9, ref Vector3 P_10, ref Vector3 P_11)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (P_5 - P_4 < 1f && P_6 == P_7)
		{
			return;
		}
		for (int i = P_6; i <= P_7; i++)
		{
			float num = P_4;
			while (true)
			{
				_74983A91751E45E1(P_0, P_1, P_2, P_3, num, i, P_8, out var val, out var val2);
				_797CC3B38B1F495F(ref P_10, ref P_11, val + P_9, val2);
				if (num >= P_5)
				{
					break;
				}
				num = Mathf.Min(num + BCEF274DC0E14429, P_5);
			}
		}
	}

	private static void _797CC3B38B1F495F(ref Vector3 P_0, ref Vector3 P_1, Vector3 P_2, Vector3 P_3)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Vector3.Min(P_0 - P_1, P_2 - P_3);
		Vector3 val2 = Vector3.Max(P_0 + P_1, P_2 + P_3);
		P_0 = (val + val2) * 0.5f;
		P_1 = (val2 - val) * 0.5f;
	}

	private static void _74983A91751E45E1(int P_0, int P_1, int P_2, bool P_3, float P_4, int P_5, int P_6, out Vector3 P_7, out Vector3 P_8)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 >= 0 && P_2 >= 0)
		{
			_680955959F674DCC.BD3BC3603262456A(P_1, P_2, P_3, P_4, P_5, P_6, out P_7, out P_8);
			if (P_3)
			{
				_680955959F674DCC.BD3BC3603262456A(P_1, P_2, false, P_4, P_5, P_6, out var val, out var val2);
				_797CC3B38B1F495F(ref P_7, ref P_8, val, val2);
			}
		}
		else
		{
			_680955959F674DCC.A2C717841AB84AE5(P_0, P_3, P_4, P_5, P_6, out P_7, out P_8);
			if (P_3)
			{
				_680955959F674DCC.A2C717841AB84AE5(P_0, false, P_4, P_5, P_6, out var val3, out var val4);
				_797CC3B38B1F495F(ref P_7, ref P_8, val3, val4);
			}
		}
	}

	private static float CCE3DD1C74514565(EPlayerStance P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		if ((int)P_0 != 4)
		{
			if ((int)P_0 == 5)
			{
				return 0.2f;
			}
			return 0f;
		}
		return 0.1f;
	}

	private static Vector3 F353DF279A6F4CC3(int P_0)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		if (P_0 != 3)
		{
			return Vector3.zero;
		}
		return new Vector3(0f, -0.1f, 0f);
	}

	private static int _32AD7C20BC5744AA(EPlayerStance P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected I4, but got Unknown
		return (int)P_0 switch
		{
			2 => 1, 
			4 => 2, 
			5 => 3, 
			1 => 4, 
			0 => 5, 
			7 => 6, 
			6 => 7, 
			_ => 0, 
		};
	}

	private static int E48CA8EDC7FA48D3(EPlayerStance P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected I4, but got Unknown
		return (int)P_0 switch
		{
			3 => 0, 
			2 => 1, 
			4 => 2, 
			1 => 3, 
			0 => 4, 
			_ => -1, 
		};
	}

	private static int _87BE2232E0224468(EPlayerGesture P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected I4, but got Unknown
		return (P_0 - 1) switch
		{
			5 => 0, 
			10 => 1, 
			12 => 2, 
			7 => 3, 
			8 => 4, 
			9 => 5, 
			14 => 6, 
			2 => 7, 
			0 => 8, 
			15 => 9, 
			3 => 10, 
			4 => 11, 
			_ => -1, 
		};
	}

	private bool _08C3369E2CA74530(Vector3 P_0, out bool P_1)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		P_1 = false;
		int num = _7C66E74CF06B4FDB;
		for (int i = 0; i < F7E42E27508C4DF9; i++)
		{
			num--;
			if (num < 0)
			{
				num = 49;
			}
			Vector3 val = _8D71D7BC9FC84ACF[num];
			if (!flag && (Mathf.Abs(val.x - P_0.x) > 0.01f || Mathf.Abs(val.y - P_0.y) > 0.01f || Mathf.Abs(val.z - P_0.z) > 0.01f))
			{
				flag = true;
			}
			if (!P_1)
			{
				Vector3 val2 = val - P_0;
				if (val2.sqrMagnitude > 256f)
				{
					P_1 = true;
				}
			}
			if (flag & P_1)
			{
				break;
			}
		}
		return flag;
	}
}
