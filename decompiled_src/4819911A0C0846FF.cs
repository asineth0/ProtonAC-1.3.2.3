using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

public class _4819911A0C0846FF
{
	public class _3147FDB5568446E9
	{
		public UseableGun? _3491A0DDF1674FF0;

		public int E18F5E0961B94988;

		public int _30249645703B47E7;

		public int _48BEC7816DA943BC;

		public float AC47143ADD1E42BC;

		public float A06E15E132D548C1;

		public float B816394284A14C8D;

		public float _979A197054D84450;

		public float E8B36921B188475B;

		public float _5E8B57884ED846F7;

		public float B20DDC09C08540F1;

		public float ECEA119252CD4167;

		public float B32947997F7043B7;

		public float _7828A186B79F4E4F;

		public float _005A4DCA76144918;

		public float _8BCCCC895AFF484D;

		public float _0CDF4F72C2204DA3;

		public float _938D693909384ADF;

		public float _88487C61ED4D49F8;

		public bool F9050CCFB6B5492C;

		public bool _62DB85C9E0D5497C;

		public bool B0169C33A3674C0D;

		public bool _48FE83AE14EC46DA;

		public bool _05D08946EDA64DEC;

		public bool _47914AA1386B4B09;

		public B3E800F7DAAE405D._8B7C6A7C18684FA8 CB743CD423CB4991;

		public B3E800F7DAAE405D._8B7C6A7C18684FA8 FE6AF73253D346E7;

		public B3E800F7DAAE405D._8B7C6A7C18684FA8 _9EB9E2BEE74640DC;

		public Quaternion _63B79AD0C1094E94;

		public Quaternion _04A7C19047954A74;

		public Quaternion _1B0ED80F923E4586;

		public Quaternion EB3D8ED29BD04389;

		public Quaternion _7721B403999045BE;

		public Quaternion _803CF3EE969F42B9;

		public List<B3E800F7DAAE405D._8B7C6A7C18684FA8> BCEAA4E8A41640C2 = new List<B3E800F7DAAE405D._8B7C6A7C18684FA8>();

		public _63009F37A59A432B._87AA5908A6EF41DD BAC3D1236F334A36;

		public Quaternion _526C77F5AD8543F9
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				return _63B79AD0C1094E94 * EB3D8ED29BD04389;
			}
		}

		public Quaternion _5323059ADC574BFF
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				return _04A7C19047954A74 * _7721B403999045BE;
			}
		}

		public Quaternion _24D6906F99D54084
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				return _1B0ED80F923E4586 * _803CF3EE969F42B9;
			}
		}
	}

	public struct _80F40B3A6052448D
	{
		public List<_3147FDB5568446E9> _7EBE8DC10D2A4339;

		public Vector3 _0377D473DDE24690;

		public Vector3 D6BBF61F7BD54CB5;

		public float _4E367F2AD2F8498A;

		public int A1D4A938ECD84492;

		public int F4C9529C16D1499B;

		public bool _11F09242BCDF4087;

		public bool _81499F0A443E4DFC;

		public bool _59C152CABA934374;

		public bool E095AB92F06747F2;

		public string _3186DEB29E9F4153;

		public string _40919D6F28DC47E4;
	}

	public Queue<_80F40B3A6052448D> _1430091BC74B40AC = new Queue<_80F40B3A6052448D>();

	public List<_3147FDB5568446E9> F933B05D5259474E = new List<_3147FDB5568446E9>();

	public List<_3147FDB5568446E9> _64FD417C5D584B4D = new List<_3147FDB5568446E9>();

	public bool _270EE9BEFABF4D71;

	public _8027E1DAC1FA44EB E4E1FD4F5C744008 = new _8027E1DAC1FA44EB();

	public _8027E1DAC1FA44EB AADE095FEED54D3E = new _8027E1DAC1FA44EB();

	public _8027E1DAC1FA44EB _00327F881EB04CEE = new _8027E1DAC1FA44EB();

	public _8027E1DAC1FA44EB _0749B78FC51F49D9 = new _8027E1DAC1FA44EB();

	public void _0AF680B55A654923()
	{
		foreach (_3147FDB5568446E9 item in _64FD417C5D584B4D)
		{
			F933B05D5259474E.Remove(item);
		}
		_64FD417C5D584B4D.Clear();
		foreach (_3147FDB5568446E9 item2 in F933B05D5259474E)
		{
			if (item2.F9050CCFB6B5492C)
			{
				_64FD417C5D584B4D.Add(item2);
			}
		}
	}
}
