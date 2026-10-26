using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

internal struct _x
{
	public unsafe fixed byte Magic[4];

	public ElfPointerClass Class;

	public ElfEndianess Endianess;

	public byte Version;

	public ElfAbi OsAbi;

	public byte AbiVersion;

	public unsafe fixed byte Padding[7];

	public ElfObjectType Type;

	public ElfArchitecture Machine;

	public int ElfVersion;

	public IntPtr Entry;

	public IntPtr ProgramHeaderOffset;

	public IntPtr SectionHeaderOffset;

	public int ArchitectureDependentFlags;

	public ushort ElfHeaderSize;

	public ushort ProgramHeaderSize;

	public ushort ProgramHeaderCount;

	public ushort SectionHeaderSize;

	public ushort SectionHeaderCount;

	public ushort SectionHeaderStringIndex;
}
internal abstract class _X<TNative, TManaged> : IEnumerable, IEnumerable<TManaged> where TNative : struct where TManaged : class
{
	private static readonly ulong _nativeSize = (ulong)Marshal.SizeOf<TNative>();

	private ulong _count;

	protected unsafe byte* _memory;

	protected unsafe byte* _first;

	protected TManaged[] _managed;

	public unsafe TManaged this[ulong index]
	{
		get
		{
			if (index > _count)
			{
				throw new IndexOutOfRangeException($"{index} is greater than array range {_count}");
			}
			return _managed[index] = _managed[index] ?? Construct(_first + index * _nativeSize);
		}
	}

	public ulong Count
	{
		get
		{
			return _count;
		}
		protected set
		{
			_count = value;
			_managed = new TManaged[_count];
		}
	}

	public unsafe _X(byte* data, ulong offset, ulong count)
	{
		_memory = data;
		_first = data + offset;
		_count = count;
		_managed = new TManaged[count];
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
