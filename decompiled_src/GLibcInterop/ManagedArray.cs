using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GlibcInterop;

internal abstract class ManagedArray<TNative, TManaged> : IEnumerable, IEnumerable<TManaged> where TNative : struct
{
	private static readonly ulong _nativeSize = (ulong)Marshal.SizeOf<TNative>();

	protected unsafe byte* _first;

	protected ulong _count;

	public unsafe TManaged this[ulong index]
	{
		get
		{
			if (index > _count)
			{
				throw new IndexOutOfRangeException($"{index} is greater than array range {_count}");
			}
			return Construct(_first + index * _nativeSize);
		}
	}

	public ulong Count => _count;

	public unsafe ManagedArray(byte* data, ulong count)
	{
		_first = data;
		_count = count;
	}

	public IEnumerator<TManaged> GetEnumerator()
	{
		ulong i = 0uL;
		while (i < _count)
		{
			yield return this[i];
			ulong num = i + 1;
			i = num;
		}
	}

	IEnumerator<TManaged> IEnumerable<TManaged>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		ulong i = 0uL;
		while (i < _count)
		{
			yield return this[i];
			ulong num = i + 1;
			i = num;
		}
	}

	protected unsafe abstract TManaged Construct(void* ptr);
}
