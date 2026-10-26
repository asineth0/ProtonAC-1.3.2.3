using System;
using System.Collections;
using System.Collections.Generic;

internal class _4 : IReadOnlyList<_3>, IEnumerable<_3>, IEnumerable, IReadOnlyCollection<_3>
{
	private unsafe byte* memory;

	private unsafe _5* first;

	private int count;

	private unsafe byte* nameData;

	public unsafe _3 this[int index]
	{
		get
		{
			if (index >= count)
			{
				throw new IndexOutOfRangeException($"Index {index} out of range {count}");
			}
			return new _3(memory, first + index, nameData + first[index].Name);
		}
	}

	public int Count => count;

	public unsafe _4(byte* data, ulong offset, int count, int nameIndex = -1)
	{
		memory = data;
		first = (_5*)(data + offset);
		this.count = count;
		if (nameIndex != 0)
		{
			nameData = new _3(memory, first + nameIndex, null).GetData();
		}
	}

	public IEnumerator<_3> GetEnumerator()
	{
		int i = 0;
		while (i < count)
		{
			yield return this[i];
			int num = i + 1;
			i = num;
		}
	}

	IEnumerator<_3> IEnumerable<_3>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		int i = 0;
		while (i < count)
		{
			yield return this[i];
			int num = i + 1;
			i = num;
		}
	}
}
