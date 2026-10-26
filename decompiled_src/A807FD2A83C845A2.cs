using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

[DefaultMember("Item")]
public class A807FD2A83C845A2<_0001> : IEnumerable<_0001>, IEnumerable
{
	public struct _0A72B7172F03473E : IEnumerator<_0001>, IEnumerator, IDisposable
	{
		private readonly _0001[] _6DF22D22FDDA449A;

		private readonly int DCB3CC81E13C4898;

		private readonly int A32227A7154B450A;

		private int _889BF5696CDD4650;

		public readonly _0001 Current
		{
			get
			{
				int num = DCB3CC81E13C4898 + _889BF5696CDD4650;
				if (num >= _6DF22D22FDDA449A.Length)
				{
					num -= _6DF22D22FDDA449A.Length;
				}
				return _6DF22D22FDDA449A[num];
			}
		}

		readonly object? IEnumerator.BE8476BB2C4E4E57 => Current;

		internal _0A72B7172F03473E(global::A807FD2A83C845A2<_0001> P_0)
		{
			_6DF22D22FDDA449A = P_0._1ECF1C0D162147EE;
			A32227A7154B450A = P_0._9831333A9ABD4A3A;
			DCB3CC81E13C4898 = (P_0.A07670049B234C82 - P_0._9831333A9ABD4A3A + _6DF22D22FDDA449A.Length) % _6DF22D22FDDA449A.Length;
			_889BF5696CDD4650 = -1;
		}

		public bool MoveNext()
		{
			return ++_889BF5696CDD4650 < A32227A7154B450A;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		public void Reset()
		{
			_889BF5696CDD4650 = -1;
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Reset
			this.Reset();
		}

		public readonly void Dispose()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}
	}

	private readonly _0001[] _1ECF1C0D162147EE;

	private int A07670049B234C82;

	private int _9831333A9ABD4A3A;

	public int DE13140484C148CD => _9831333A9ABD4A3A;

	public int _40BD3A6A06724EE5 => _1ECF1C0D162147EE.Length;

	// C# has no syntax for parameterized property '94A9FC80A4134B9C'.
	public _0001 E8BE769561E344FF(int P_0)
	{
		if (P_0 < 0 || P_0 >= _9831333A9ABD4A3A)
		{
			throw new IndexOutOfRangeException($"Index {P_0} is out of valid range (0..{_9831333A9ABD4A3A - 1}).");
		}
		int num = (A07670049B234C82 - _9831333A9ABD4A3A + P_0 + _1ECF1C0D162147EE.Length) % _1ECF1C0D162147EE.Length;
		return _1ECF1C0D162147EE[num];
	}

	public void _2EDC54ECFE604E3C(int P_0, _0001 P_1)
	{
		if (num < 0 || num >= _9831333A9ABD4A3A)
		{
			throw new IndexOutOfRangeException($"Index {num} is out of valid range (0..{_9831333A9ABD4A3A - 1}).");
		}
		int num2 = (A07670049B234C82 - _9831333A9ABD4A3A + num + _1ECF1C0D162147EE.Length) % _1ECF1C0D162147EE.Length;
		_1ECF1C0D162147EE[num2] = val;
	}

	public A807FD2A83C845A2(int P_0)
	{
		if (P_0 <= 0)
		{
			throw new ArgumentException("Capacity must be greater than zero.", "capacity");
		}
		_1ECF1C0D162147EE = new _0001[P_0];
	}

	public void _0412FB40DF604255(_0001 P_0)
	{
		_1ECF1C0D162147EE[A07670049B234C82] = P_0;
		A07670049B234C82 = (A07670049B234C82 + 1) % _1ECF1C0D162147EE.Length;
		if (_9831333A9ABD4A3A < _1ECF1C0D162147EE.Length)
		{
			_9831333A9ABD4A3A++;
		}
	}

	public void AB85BBE366014A80()
	{
		A07670049B234C82 = 0;
		_9831333A9ABD4A3A = 0;
		Array.Clear(_1ECF1C0D162147EE, 0, _1ECF1C0D162147EE.Length);
	}

	public _0A72B7172F03473E _22761929FC6F47F7()
	{
		return new _0A72B7172F03473E(this);
	}

	IEnumerator<_0001> IEnumerable<_0001>.GetEnumerator()
	{
		return _22761929FC6F47F7();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return _22761929FC6F47F7();
	}
}
