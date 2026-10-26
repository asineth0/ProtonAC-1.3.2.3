using System;
using System.Collections;
using System.Collections.Generic;

internal class EF9B595087F64C1E<_0001> : IList<_0001>, ICollection<_0001>, IEnumerable<_0001>, IEnumerable, IList, ICollection
{
	private List<_0001> _32C1B7822B6E4E58;

	private object B4AE7654793345E9;

	public int Count
	{
		get
		{
			lock (B4AE7654793345E9)
			{
				return _32C1B7822B6E4E58.Count;
			}
		}
	}

	protected List<_0001> _26F487EF8C5149F4 => _32C1B7822B6E4E58;

	public object _90AFCF9AF5014494 => B4AE7654793345E9;

	public _0001 this[int index]
	{
		get
		{
			lock (B4AE7654793345E9)
			{
				return _32C1B7822B6E4E58[index];
			}
		}
		set
		{
			lock (B4AE7654793345E9)
			{
				if (index < 0 || index >= _32C1B7822B6E4E58.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				_320027C987F54055(index, value);
			}
		}
	}

	bool ICollection<_0001>.A511E462323D4B93 => false;

	bool ICollection.AD74FD8BEA164892 => true;

	object ICollection._47CDA251794D456D => B4AE7654793345E9;

	// C# has no syntax for parameterized property '3483CEC897E74864'.
	object? IList.get_Item(int index)
	{
		return this[index];
	}

	void IList.set_Item(int index, object? value)
	{
		B71A98DF45134D0F(value);
		if (value != null)
		{
			this[index] = (_0001)value;
		}
	}

	bool IList._265CBFFF60094FD9 => false;

	bool IList.C091EA150E36493B => false;

	public EF9B595087F64C1E()
	{
		_32C1B7822B6E4E58 = new List<_0001>();
		B4AE7654793345E9 = new object();
	}

	public EF9B595087F64C1E(object P_0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("syncRoot");
		}
		_32C1B7822B6E4E58 = new List<_0001>();
		B4AE7654793345E9 = P_0;
	}

	public EF9B595087F64C1E(object P_0, IEnumerable<_0001> P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("syncRoot");
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException("list");
		}
		_32C1B7822B6E4E58 = new List<_0001>(P_1);
		B4AE7654793345E9 = P_0;
	}

	public EF9B595087F64C1E(object P_0, params _0001[] P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("syncRoot");
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException("list");
		}
		_32C1B7822B6E4E58 = new List<_0001>(P_1.Length);
		for (int i = 0; i < P_1.Length; i++)
		{
			_32C1B7822B6E4E58.Add(P_1[i]);
		}
		B4AE7654793345E9 = P_0;
	}

	public void Add(_0001 item)
	{
		lock (B4AE7654793345E9)
		{
			int count = _32C1B7822B6E4E58.Count;
			_8C34B0676367467C(count, item);
		}
	}

	void ICollection<_0001>.Add(_0001 item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Add
		this.Add(item);
	}

	public void Clear()
	{
		lock (B4AE7654793345E9)
		{
			_03AFA5CF2FEC4418();
		}
	}

	void ICollection<_0001>.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clear
		this.Clear();
	}

	void IList.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clear
		this.Clear();
	}

	public void CopyTo(_0001[] array, int index)
	{
		lock (B4AE7654793345E9)
		{
			_32C1B7822B6E4E58.CopyTo(array, index);
		}
	}

	void ICollection<_0001>.CopyTo(_0001[] array, int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in CopyTo
		this.CopyTo(array, index);
	}

	public bool Contains(_0001 item)
	{
		lock (B4AE7654793345E9)
		{
			return _32C1B7822B6E4E58.Contains(item);
		}
	}

	bool ICollection<_0001>.Contains(_0001 item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Contains
		return this.Contains(item);
	}

	public IEnumerator<_0001> GetEnumerator()
	{
		lock (B4AE7654793345E9)
		{
			return _32C1B7822B6E4E58.GetEnumerator();
		}
	}

	IEnumerator<_0001> IEnumerable<_0001>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}

	public int IndexOf(_0001 item)
	{
		lock (B4AE7654793345E9)
		{
			return _89A1030A34D34886(item);
		}
	}

	int IList<_0001>.IndexOf(_0001 item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in IndexOf
		return this.IndexOf(item);
	}

	public void Insert(int index, _0001 item)
	{
		lock (B4AE7654793345E9)
		{
			if (index < 0 || index > _32C1B7822B6E4E58.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			_8C34B0676367467C(index, item);
		}
	}

	void IList<_0001>.Insert(int index, _0001 item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Insert
		this.Insert(index, item);
	}

	private int _89A1030A34D34886(_0001 P_0)
	{
		int count = _32C1B7822B6E4E58.Count;
		for (int i = 0; i < count; i++)
		{
			if (object.Equals(_32C1B7822B6E4E58[i], P_0))
			{
				return i;
			}
		}
		return -1;
	}

	public bool Remove(_0001 item)
	{
		lock (B4AE7654793345E9)
		{
			int num = _89A1030A34D34886(item);
			if (num < 0)
			{
				return false;
			}
			BC3BD2778B6740FE(num);
			return true;
		}
	}

	bool ICollection<_0001>.Remove(_0001 item)
	{
		//ILSpy generated this explicit interface implementation from .override directive in Remove
		return this.Remove(item);
	}

	public void RemoveAt(int index)
	{
		lock (B4AE7654793345E9)
		{
			if (index < 0 || index >= _32C1B7822B6E4E58.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			BC3BD2778B6740FE(index);
		}
	}

	void IList<_0001>.RemoveAt(int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RemoveAt
		this.RemoveAt(index);
	}

	void IList.RemoveAt(int index)
	{
		//ILSpy generated this explicit interface implementation from .override directive in RemoveAt
		this.RemoveAt(index);
	}

	protected virtual void _03AFA5CF2FEC4418()
	{
		_32C1B7822B6E4E58.Clear();
	}

	protected virtual void _8C34B0676367467C(int P_0, _0001 P_1)
	{
		_32C1B7822B6E4E58.Insert(P_0, P_1);
	}

	protected virtual void BC3BD2778B6740FE(int P_0)
	{
		_32C1B7822B6E4E58.RemoveAt(P_0);
	}

	protected virtual void _320027C987F54055(int P_0, _0001 P_1)
	{
		_32C1B7822B6E4E58[P_0] = P_1;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable)_32C1B7822B6E4E58).GetEnumerator();
	}

	void ICollection.CopyTo(Array array, int index)
	{
		lock (B4AE7654793345E9)
		{
			((ICollection)_32C1B7822B6E4E58).CopyTo(array, index);
		}
	}

	int IList.Add(object value)
	{
		B71A98DF45134D0F(value);
		lock (B4AE7654793345E9)
		{
			Add((_0001)value);
			return Count - 1;
		}
	}

	bool IList.Contains(object value)
	{
		B71A98DF45134D0F(value);
		return Contains((_0001)value);
	}

	int IList.IndexOf(object value)
	{
		B71A98DF45134D0F(value);
		return IndexOf((_0001)value);
	}

	void IList.Insert(int index, object value)
	{
		B71A98DF45134D0F(value);
		Insert(index, (_0001)value);
	}

	void IList.Remove(object value)
	{
		B71A98DF45134D0F(value);
		Remove((_0001)value);
	}

	private static void B71A98DF45134D0F(object P_0)
	{
		if (P_0 == null)
		{
			if (typeof(_0001).IsValueType)
			{
				throw new ArgumentException("SynchronizedCollectionWrongTypeNull");
			}
		}
		else if (!(P_0 is _0001))
		{
			throw new ArgumentException("SynchronizedCollectionWrongType1");
		}
	}
}
