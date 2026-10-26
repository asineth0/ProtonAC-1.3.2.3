using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

public class _0732D1C8FF584BB5
{
	public struct FFFC598AFAF4431B : C66C869F25E04CC3
	{
		public Vector3 _1AD61A3DF366419E;

		public List<BACE3A97F70C46B0> _0EE12B9C4E3B4338;

		public List<FC39AB69EDEF48B4> _41D6CB4BFDD14843;

		public Bounds? FFAC7B809BCE4D6A;

		[CompilerGenerated]
		private long _4C175372350A40DE;

		public long _226B7B943D07494C
		{
			[CompilerGenerated]
			readonly get
			{
				return _4C175372350A40DE;
			}
			[CompilerGenerated]
			set
			{
				_4C175372350A40DE = num;
			}
		}
	}

	public struct FC39AB69EDEF48B4
	{
		public Vector3 AB1F3273C0674DCE;

		public Vector3 _6DFB0807053D43D3;

		public Matrix4x4 B448176098514505;
	}

	public struct BACE3A97F70C46B0
	{
		public Vector3 BCF717E56F1C4757;

		public Quaternion B6BA11EF2DE84A0B;

		public bool _867A75B3EDD34DB1;
	}

	public class _4774CC3E188745EA
	{
		public List<BoxCollider> B32F651F0B7149B2;

		public List<Collider> _35818FFFD9F24D3C;

		public AE8979A166C64D26 _8CE9CCBF2CE848A8;

		public long _430D6C02CAC94F8A;

		public bool _7785B46181924BCA;

		public _4774CC3E188745EA()
		{
			List<BoxCollider> b32F651F0B7149B = null;
			List<Collider> list = null;
			AE8979A166C64D26 aE8979A166C64D = null;
			B32F651F0B7149B2 = b32F651F0B7149B;
			_35818FFFD9F24D3C = list;
			aE8979A166C64D = new AE8979A166C64D26();
			_8CE9CCBF2CE848A8 = aE8979A166C64D;
		}
	}

	public sealed class AE8979A166C64D26
	{
		public struct _19D91E4990774FAD
		{
			private readonly FFFC598AFAF4431B[] B3491FAE9F714B09;

			private readonly int CA671AC10860465D;

			private readonly int _73686C9780FA404D;

			private int E90D09ABA19940CA;

			public readonly FFFC598AFAF4431B EA5BCFA5A19F48AA
			{
				get
				{
					int num = CA671AC10860465D + E90D09ABA19940CA;
					if (num >= 20)
					{
						num -= 20;
					}
					return B3491FAE9F714B09[num];
				}
			}

			internal _19D91E4990774FAD(AE8979A166C64D26 P_0)
			{
				B3491FAE9F714B09 = P_0._5D03280268864AEE;
				CA671AC10860465D = P_0._081312C345974B19;
				_73686C9780FA404D = P_0._250BA586B59D4A91;
				E90D09ABA19940CA = -1;
			}

			public bool _88CF3ABF4B214952()
			{
				return ++E90D09ABA19940CA < _73686C9780FA404D;
			}
		}

		public const int _5F81DB21ACFD496E = 20;

		private readonly FFFC598AFAF4431B[] _5D03280268864AEE;

		private int _081312C345974B19;

		private int _250BA586B59D4A91;

		public int _5468E839208943F2 => _250BA586B59D4A91;

		public long _585D59F4EC46418E
		{
			get
			{
				throw new Exception();
			}
		}

		public AE8979A166C64D26()
		{
			FFFC598AFAF4431B[] array = new FFFC598AFAF4431B[20];
			List<object> list = null;
			_ = null;
			_5D03280268864AEE = array;
			throw new Exception();
		}

		public ref FFFC598AFAF4431B _3A3AAE3891E54E4A()
		{
			_250BA586B59D4A91 = 0;
			throw new Exception();
		}

		public void E797B23ED8FB4F22()
		{
			_250BA586B59D4A91 = 0;
		}

		public _19D91E4990774FAD _59C6AFD091054418()
		{
			return new _19D91E4990774FAD(this);
		}
	}

	public struct _46973BD565ED4E94 : C66C869F25E04CC3
	{
		public List<Bounds> E263A30D298E4689;

		public List<Bounds> _303A3B95A94A4719;

		[CompilerGenerated]
		private long _35202FB4B3CF4460;

		public long _226B7B943D07494C
		{
			[CompilerGenerated]
			readonly get
			{
				return _35202FB4B3CF4460;
			}
			[CompilerGenerated]
			set
			{
				_35202FB4B3CF4460 = num;
			}
		}
	}

	public struct _00AE748AAABE4B0F : C66C869F25E04CC3
	{
		public List<Collider> BF78DD9D05D344AF;

		[CompilerGenerated]
		private long _5BE317B6117C47B3;

		public long _226B7B943D07494C
		{
			[CompilerGenerated]
			readonly get
			{
				return _5BE317B6117C47B3;
			}
			[CompilerGenerated]
			set
			{
				_5BE317B6117C47B3 = num;
			}
		}
	}

	private const float CE6829EF9C7C4D1F = 0.1f;

	private static readonly List<Collider> _9D52CCFE3E844D97 = new List<Collider>();

	public Dictionary<uint, _4774CC3E188745EA> _0442BACC6B2A4332;

	public global::_1A42C15FF0B54B42<_46973BD565ED4E94> _777E0ECC9E4A47E3;

	public global::_1A42C15FF0B54B42<_00AE748AAABE4B0F> _9C9BA43C8C834495;

	private readonly List<uint> CA440D609413411F;

	public void _9BC2CB07D61C4058(Transform P_0)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		List<Bounds> list = new List<Bounds>();
		List<Bounds> list2 = new List<Bounds>();
		((Component)P_0).GetComponentsInChildren<Collider>(true, _9D52CCFE3E844D97);
		foreach (Collider item in _9D52CCFE3E844D97)
		{
			if (item.isTrigger)
			{
				continue;
			}
			int layer = ((Component)item).gameObject.layer;
			bool flag = _1187FAD6AB3F40BD._739EFC5D5557461E(layer);
			bool flag2 = _1187FAD6AB3F40BD._566147A1CCDD4F15(layer);
			if (flag || flag2)
			{
				Bounds bounds = item.bounds;
				if (flag)
				{
					list.Add(bounds);
				}
				if (flag2)
				{
					list2.Add(bounds);
				}
			}
		}
		_9D52CCFE3E844D97.Clear();
		_777E0ECC9E4A47E3._918CCD4D03A64F7C(new _46973BD565ED4E94
		{
			_303A3B95A94A4719 = list,
			E263A30D298E4689 = list2,
			_226B7B943D07494C = _9AB67761792440A7._00FC653ED33A4A96()
		});
	}

	public void _73A3269801654974(Transform P_0)
	{
		List<Collider> list = new List<Collider>();
		((Component)P_0).GetComponentsInChildren<Collider>(list);
		_9C9BA43C8C834495._918CCD4D03A64F7C(new _00AE748AAABE4B0F
		{
			BF78DD9D05D344AF = list,
			_226B7B943D07494C = _9AB67761792440A7._00FC653ED33A4A96()
		});
	}

	public bool _3FA9FE04F7C54C5E(InteractableVehicle P_0, Vector3 P_1)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (!_0442BACC6B2A4332.TryGetValue(P_0.instanceID, out _4774CC3E188745EA value) || value._7785B46181924BCA)
		{
			return true;
		}
		Bounds? val = _205C119B21F04A52(value);
		if (val.HasValue)
		{
			Bounds value2 = val.Value;
			return value2.Contains(P_1);
		}
		return true;
	}

	public bool C855493D68FC40C0(InteractableVehicle P_0, Vector3 P_1)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		if (!_0442BACC6B2A4332.TryGetValue(P_0.instanceID, out _4774CC3E188745EA value) || value._7785B46181924BCA)
		{
			return true;
		}
		Bounds? val = _304D068D6E744D79(value);
		if (val.HasValue)
		{
			Bounds value2 = val.Value;
			return value2.Contains(P_1);
		}
		return true;
	}

	public bool FE59E1EE1CEA40B2(InteractableVehicle P_0, Vector3 P_1, Ray P_2, float P_3)
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		bool flag = (Object)(object)P_0 != (Object)null;
		uint? num = ((!flag) ? new uint?(0u) : P_0?.instanceID);
		foreach (KeyValuePair<uint, _4774CC3E188745EA> item in _0442BACC6B2A4332)
		{
			_4774CC3E188745EA value = item.Value;
			if (!value._7785B46181924BCA)
			{
				bool flag2 = flag && item.Key == num;
				if ((flag2 || AF26CFC3DE8443C2(value, P_2, P_3)) && _8C9FAB62C2C647F8(P_1, P_2, value, P_3, flag2))
				{
					return true;
				}
			}
		}
		return false;
	}

	private static bool AF26CFC3DE8443C2(_4774CC3E188745EA P_0, Ray P_1, float P_2)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (P_0._8CE9CCBF2CE848A8._5468E839208943F2 == 0)
		{
			return false;
		}
		AE8979A166C64D26._19D91E4990774FAD obj = P_0._8CE9CCBF2CE848A8._59C6AFD091054418();
		float num = default;
		while (obj._88CF3ABF4B214952())
		{
			FFFC598AFAF4431B fFFC598AFAF4431B = obj.EA5BCFA5A19F48AA;
			if (!fFFC598AFAF4431B.FFAC7B809BCE4D6A.HasValue)
			{
				return true;
			}
			Bounds value = fFFC598AFAF4431B.FFAC7B809BCE4D6A.Value;
			value.Expand(0.1f);
			if (!value.IntersectRay(P_1, ref num) || num > P_2)
			{
				return false;
			}
		}
		return true;
	}

	public bool _8C9FAB62C2C647F8(Vector3 P_0, Ray P_1, _4774CC3E188745EA P_2, float P_3, bool P_4)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (P_2._8CE9CCBF2CE848A8._5468E839208943F2 == 0)
		{
			return false;
		}
		AE8979A166C64D26._19D91E4990774FAD obj = P_2._8CE9CCBF2CE848A8._59C6AFD091054418();
		while (obj._88CF3ABF4B214952())
		{
			FFFC598AFAF4431B fFFC598AFAF4431B = obj.EA5BCFA5A19F48AA;
			bool flag = !P_4;
			if (P_4)
			{
				foreach (BACE3A97F70C46B0 item in fFFC598AFAF4431B._0EE12B9C4E3B4338)
				{
					Bounds val = _9AB67761792440A7._79FF44A168A24F7A(item);
					if (val.Contains(P_0))
					{
						flag = true;
					}
				}
			}
			if (flag && !_9D13B2359E624A1D(in fFFC598AFAF4431B, P_1, P_3))
			{
				return false;
			}
		}
		return true;
	}

	public bool _9D13B2359E624A1D(in FFFC598AFAF4431B P_0, Ray P_1, float P_2)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		foreach (FC39AB69EDEF48B4 item in P_0._41D6CB4BFDD14843)
		{
			if (FB1CB865A3324672(P_1, item, P_2, 0.05f, out var _))
			{
				return true;
			}
		}
		return false;
	}

	public void _92EC43D608A14E21(InteractableVehicle P_0)
	{
		if (_0442BACC6B2A4332.TryGetValue(P_0.instanceID, out _4774CC3E188745EA value) && !value._7785B46181924BCA)
		{
			value._7785B46181924BCA = true;
			value._430D6C02CAC94F8A = _9AB67761792440A7._00FC653ED33A4A96();
		}
	}

	public void _648E305AD3AD4839()
	{
		_9AB67761792440A7._00FC653ED33A4A96();
		((global::_1A42C15FF0B54B42<>)(object)_777E0ECC9E4A47E3).A96488F8354C4887(0L);
		((global::_1A42C15FF0B54B42<>)(object)_9C9BA43C8C834495).A96488F8354C4887(0L);
		CA440D609413411F = null;
		CA440D609413411F = null;
		CA440D609413411F = null;
		throw new Exception();
	}

	public void E277BCCCC4774490(InteractableVehicle P_0, bool P_1)
	{
		GC.KeepAlive(null);
	}

	public float DB296859268A40D5(InteractableVehicle P_0, Vector3 P_1)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		if (!_0442BACC6B2A4332.TryGetValue(P_0.instanceID, out _4774CC3E188745EA value) || value._7785B46181924BCA)
		{
			return float.MaxValue;
		}
		float num = float.MaxValue;
		AE8979A166C64D26._19D91E4990774FAD obj = value._8CE9CCBF2CE848A8._59C6AFD091054418();
		while (obj._88CF3ABF4B214952())
		{
			num = Mathf.Min(num, Vector3.Distance(obj.EA5BCFA5A19F48AA._1AD61A3DF366419E, P_1));
		}
		return num;
	}

	public Bounds? _205C119B21F04A52(_4774CC3E188745EA P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		Bounds value = default;
		AE8979A166C64D26._19D91E4990774FAD obj = P_0._8CE9CCBF2CE848A8._59C6AFD091054418();
		while (obj._88CF3ABF4B214952())
		{
			foreach (BACE3A97F70C46B0 item in obj.EA5BCFA5A19F48AA._0EE12B9C4E3B4338)
			{
				Bounds val = _9AB67761792440A7._79FF44A168A24F7A(item);
				if (flag)
				{
					value.Encapsulate(val);
					continue;
				}
				flag = true;
				value = val;
			}
		}
		if (!flag)
		{
			return null;
		}
		return value;
	}

	public Bounds? _304D068D6E744D79(_4774CC3E188745EA P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		Bounds value = default;
		AE8979A166C64D26._19D91E4990774FAD obj = P_0._8CE9CCBF2CE848A8._59C6AFD091054418();
		while (obj._88CF3ABF4B214952())
		{
			FFFC598AFAF4431B fFFC598AFAF4431B = obj.EA5BCFA5A19F48AA;
			if (!fFFC598AFAF4431B.FFAC7B809BCE4D6A.HasValue)
			{
				return null;
			}
			if (flag)
			{
				value.Encapsulate(fFFC598AFAF4431B.FFAC7B809BCE4D6A.Value);
				continue;
			}
			flag = true;
			value = fFFC598AFAF4431B.FFAC7B809BCE4D6A.Value;
		}
		if (!flag)
		{
			return null;
		}
		return value;
	}

	private static Bounds? _4D79E39DE8BE4B66(List<Collider> P_0)
	{
		GC.KeepAlive(null);
		return null;
	}

	public bool FB1CB865A3324672(Ray P_0, in FC39AB69EDEF48B4 P_1, float P_2, float P_3, out float P_4)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		P_4 = 0f;
		Matrix4x4 b448176098514505 = P_1.B448176098514505;
		Vector3 val = b448176098514505.MultiplyPoint(P_0.origin);
		Vector3 val2 = b448176098514505.MultiplyVector(P_0.direction);
		Bounds val3 = new Bounds(P_1.AB1F3273C0674DCE, P_1._6DFB0807053D43D3);
		Vector3 min = val3.min;
		Vector3 max = val3.max;
		float num = float.MinValue;
		float num2 = float.MaxValue;
		for (int i = 0; i < 3; i++)
		{
			if (Mathf.Abs(val2[i]) < 0.0001f)
			{
				if (val[i] < min[i] || val[i] > max[i])
				{
					return false;
				}
				continue;
			}
			float num3 = 1f / val2[i];
			float num4 = (min[i] - val[i]) * num3;
			float num5 = (max[i] - val[i]) * num3;
			if (num4 > num5)
			{
				float num6 = num4;
				num4 = num5;
				num5 = num6;
			}
			num = Mathf.Max(num, num4);
			num2 = Mathf.Min(num2, num5);
			if (num > num2)
			{
				return false;
			}
		}
		if (num2 < 0f)
		{
			return false;
		}
		if (num < 0f - P_3)
		{
			return false;
		}
		float num7 = Mathf.Max(0f, num);
		if (num7 > P_2)
		{
			return false;
		}
		P_4 = num7;
		return true;
	}

	public _0732D1C8FF584BB5()
	{
		Dictionary<uint, _4774CC3E188745EA> dictionary = null;
		List<uint> cA440D609413411F = null;
		_0442BACC6B2A4332 = dictionary;
		CA440D609413411F = cA440D609413411F;
	}
}
