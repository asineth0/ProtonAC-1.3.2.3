using System;
using System.Collections;
using System.Collections.Generic;

internal class A96A6382B424400A : IReadOnlyList<AF4EA33D30884C93>, IEnumerable<AF4EA33D30884C93>, IEnumerable, IReadOnlyCollection<AF4EA33D30884C93>
{
	private unsafe byte* _memory;

	private unsafe _1BF6F1682AC14ECD* _first;

	private int _count;

	public unsafe AF4EA33D30884C93 this[int index]
	{
		get
		{
			if (index >= _count)
			{
				throw new IndexOutOfRangeException($"Index {index} out of range {_count}");
			}
			return new AF4EA33D30884C93(_memory, _first + index);
		}
	}

	public int Count => _count;

	public unsafe A96A6382B424400A(byte* data, ulong offset, int count)
	{
		_memory = data;
		_first = (_1BF6F1682AC14ECD*)(data + offset);
		_count = count;
	}

	public IEnumerator<AF4EA33D30884C93> GetEnumerator()
	{
		int i = 0;
		while (i < _count)
		{
			yield return this[i];
			int num = i + 1;
			i = num;
		}
	}

	IEnumerator<AF4EA33D30884C93> IEnumerable<AF4EA33D30884C93>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		int i = 0;
		while (i < _count)
		{
			yield return this[i];
			int num = i + 1;
			i = num;
		}
	}
}
