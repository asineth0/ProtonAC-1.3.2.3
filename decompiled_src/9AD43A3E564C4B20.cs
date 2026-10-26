using System;
using SDG.Unturned;
using UnityEngine;

internal class _9AD43A3E564C4B20 : _89ED754871B24D32
{
	private static readonly float _815B98D4A2FD47C4;

	private static readonly float _6D6232A48FA74D5E;

	private const int _2E84534463BB42D8 = 11;

	private static readonly float _635D41E1DF564588;

	private static readonly float _356680FFD62842E5;

	private const int F17654568FAE4315 = 2;

	public virtual ECheckType EB87A5149CF74431()
	{
		return ECheckType.VerticalSpeed;
	}

	public virtual (string debug, EFlagLevel level)? _115510E1DD2E43EB(A3116505AAB24996 P_0, Player P_1, InteractableVehicle P_2, Rigidbody P_3, _222604882F4244C0 P_4, _7B93EFC9B3644586 P_5)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		if (P_2.asset == null || (int)P_2.asset.engine != 0)
		{
			return null;
		}
		bool flag = (Object)(object)_64A4BBC5E4CE4EE1.CFB8EA5D392C40F4.Invoke(P_2) != (Object)null && P_5._0CAA8017E59C4B00();
		if (!P_5.B5D48CE083EC49C0 || flag || P_5._5E1BF4EB49FC4BD6(P_2) || P_5._5E9772367AA844EF(P_0, P_2))
		{
			P_0._4E59ED5DE8F64E9D._19F5F779612A4A8C(0.005f);
			P_5._8E4287F6739840E3 = 0;
			return null;
		}
		P_5._8E4287F6739840E3++;
		if (P_5._8E4287F6739840E3 <= 2)
		{
			return null;
		}
		float num = Mathf.Clamp01(1f - P_3.drag * Time.fixedDeltaTime);
		float num2 = 1f;
		float num3 = 0f;
		for (int i = 0; i < PlayerInput.SAMPLES; i++)
		{
			num2 *= num;
			num3 = (num3 + 1f) * num;
		}
		_1187FAD6AB3F40BD._335A18BA0BAC488D(P_2, P_3, P_4.FF7A51941D954D73, P_5._02FAEBC136A94E70, out var val, out var _, out var num4, out var val3);
		Vector3 val4 = P_5._279E82653E8044B4 * num2 + (Physics.gravity + val) * (Time.fixedDeltaTime * num3);
		Vector3 val5 = P_5._625ACB8DDEB14250 - val4;
		Vector3 val6 = val3 * PlayerInput.RATE;
		Vector3 val7 = new Vector3(_4C1350AE398047B9(val5.x, val6.x), _4C1350AE398047B9(val5.y, val6.y), _4C1350AE398047B9(val5.z, val6.z));
		float num5 = _20560C78D8514B33(P_3, ((Component)P_2).transform.lossyScale);
		float num6 = _68A7F5861CF448F0(num4, P_5._7E879489692D4CC6);
		float num7 = _6D6232A48FA74D5E + num5 + num6;
		float num8 = val7.magnitude - num7;
		if (num8 <= 0f)
		{
			P_0._4E59ED5DE8F64E9D._19F5F779612A4A8C(0.005f);
			return null;
		}
		if (!P_0._642384DB2ED34461(P_5.A9449C8C144D4F20))
		{
			return null;
		}
		DCF7FAB51EEB4F00 dCF7FAB51EEB4F = _89ED754871B24D32._0736621F55AC491C._3ECE4ABFF9E04BFF<DCF7FAB51EEB4F00>();
		dCF7FAB51EEB4F.C79D69EBECF5403C = P_1.channel.owner.playerID.steamID.m_SteamID;
		dCF7FAB51EEB4F._9F0E6BB71A7F4276 = ((Asset)P_2.asset).FriendlyName;
		dCF7FAB51EEB4F.F6815343840F460F = ((Asset)P_2.asset).id;
		dCF7FAB51EEB4F._352B8CF663A348D0 = num8;
		dCF7FAB51EEB4F.BC5548652B054E05 = val5;
		dCF7FAB51EEB4F._3C6D560A25814D40 = val7;
		dCF7FAB51EEB4F._8E6765397A5F478A = val4;
		dCF7FAB51EEB4F._092CC9DB09434C20 = P_5._625ACB8DDEB14250;
		dCF7FAB51EEB4F._458D48A3721C4024 = P_5._279E82653E8044B4;
		dCF7FAB51EEB4F._75C04A135E7F4DF0 = val6;
		dCF7FAB51EEB4F._5C372AA284A64D5D = val;
		dCF7FAB51EEB4F.F32F3D123B5B469F = num7;
		dCF7FAB51EEB4F._733674C925224259 = _6D6232A48FA74D5E;
		dCF7FAB51EEB4F._6C7F61CD86AC44D7 = num5;
		dCF7FAB51EEB4F.B537C1F8CACC4D6D = num6;
		dCF7FAB51EEB4F._72E13C0DBD27495F = P_5._7E879489692D4CC6;
		dCF7FAB51EEB4F._9FF0639F21BC40EE = P_3.centerOfMass;
		dCF7FAB51EEB4F.DD8CEC89C1B44419 = P_3.mass;
		dCF7FAB51EEB4F.B9E706A1C9DD45B7 = P_3.drag;
		dCF7FAB51EEB4F._931305E182564EE9 = P_5._8E4287F6739840E3;
		dCF7FAB51EEB4F._6A2188F43439462C = P_4.FF7A51941D954D73.Count;
		dCF7FAB51EEB4F.A0ECBE444BA64DA6 = P_5.A9449C8C144D4F20;
		dCF7FAB51EEB4F._2C475EC71CD14650 = P_5.D25D2B302B15425A;
		dCF7FAB51EEB4F.D28F91A803E54804 = (int)(P_5._8905377ABE704BFE - P_5.FA5227EBF51C4830);
		Wheel[] tires = P_2.tires;
		if (tires != null)
		{
			for (int j = 0; j < tires.Length; j++)
			{
				bool flag2 = _1187FAD6AB3F40BD.A8A3594975F047AC(tires[j], P_2, P_5.ACDFDD5F50BA4EE4, P_5._402AC6E5E1384F45, out var eC42C732153F478D);
				dCF7FAB51EEB4F._661CB133EAAA4F8E.Add(new _1C51DE4D9D294E46
				{
					D5325E824538435B = j,
					C48F713C197144B3 = !flag2,
					_8C2C2DF16AAB40FB = eC42C732153F478D.CE91CF7E1A224A8D,
					AE45E70E70CD4DA7 = eC42C732153F478D._444D47266C31484C,
					_5A9AFC948B074012 = eC42C732153F478D.C7A747A4225344F9,
					D0661150FF0A4611 = eC42C732153F478D.A36F51F04D5A4752,
					D6F11A24917348A8 = eC42C732153F478D._8B7E5BEBEA7D4EAB,
					C43A60926721406C = eC42C732153F478D.F7E6157E550F4697,
					_53835FD009FC4FE2 = eC42C732153F478D._9361EBEFD8994F07,
					_30BB14311B0A423B = eC42C732153F478D.D68DF0192596499A,
					_458F390C6C54447D = eC42C732153F478D.C9843BA935AD44AB,
					_3BB5DCDD797F4FEE = eC42C732153F478D._1FA9FF460BAB4839
				});
			}
		}
		_89ED754871B24D32._0736621F55AC491C.CB4E939A3F83474C("Vehicle AirSpeed V5", dCF7FAB51EEB4F);
		if (!(P_0._4E59ED5DE8F64E9D._8853594054184234() > 1f))
		{
			return null;
		}
		return ("type: A", EFlagLevel.Minimal);
	}

	private static float _4C1350AE398047B9(float P_0, float P_1)
	{
		return Mathf.Sign(P_0) * Mathf.Max(0f, Mathf.Abs(P_0) - P_1);
	}

	private static float _20560C78D8514B33(Rigidbody P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = Vector3.Scale(P_0.centerOfMass, P_1);
		float magnitude = val.magnitude;
		return 4f * _356680FFD62842E5 * magnitude / PlayerInput.RATE;
	}

	private static float _68A7F5861CF448F0(float P_0, Vector3 P_1)
	{
		if (P_0 <= 0f)
		{
			return 0f;
		}
		float num = Mathf.Min(P_1.magnitude * PlayerInput.RATE, MathF.PI / 2f);
		return P_0 * PlayerInput.RATE * Mathf.Sin(num);
	}

	static _9AD43A3E564C4B20()
	{
		GC.KeepAlive(null);
	}
}
