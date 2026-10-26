using System;
using System.Collections;
using System.Collections.Generic;

internal class _8CD136FD6675485E : IReadOnlyList<_9F61EB4FCBA44886>, IEnumerable<_9F61EB4FCBA44886>, IEnumerable, IReadOnlyCollection<_9F61EB4FCBA44886>
{
	private unsafe byte* memory;

	private unsafe C3BAEA502162488F* first;

	private int count;

	private unsafe byte* nameData;

	public unsafe _9F61EB4FCBA44886 this[int index]
	{
		get
		{
			if (index >= count)
			{
				throw new IndexOutOfRangeException($"Index {index} out of range {count}");
			}
			return new _9F61EB4FCBA44886(memory, first + index, nameData + first[index].Name);
		}
	}

	public int Count => count;

	public unsafe _8CD136FD6675485E(byte* data, ulong offset, int count, int nameIndex = -1)
	{
		memory = data;
		first = (C3BAEA502162488F*)(data + offset);
		this.count = count;
		if (nameIndex != 0)
		{
			nameData = new _9F61EB4FCBA44886(memory, first + nameIndex, null).GetData();
		}
	}

	public IEnumerator<_9F61EB4FCBA44886> GetEnumerator()
	{
		int i = 0;
		while (i < count)
		{
			yield return this[i];
			int num = i + 1;
			i = num;
		}
	}

	IEnumerator<_9F61EB4FCBA44886> IEnumerable<_9F61EB4FCBA44886>.GetEnumerator()
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
