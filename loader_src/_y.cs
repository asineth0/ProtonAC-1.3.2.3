using System;
using System.Collections;
using System.Collections.Generic;

internal class _y
{
	private unsafe byte* memory;

	private unsafe _z* obj;

	public unsafe ElfProgramHeaderType Type
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return obj->Data32.Type;
			}
			return obj->Data64.Type;
		}
	}

	public unsafe ulong Offset
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return obj->Data32.Offset;
			}
			return (ulong)obj->Data64.Offset;
		}
	}

	public unsafe ulong FileSize
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return obj->Data32.FileSize;
			}
			return (ulong)obj->Data64.FileSize;
		}
	}

	public unsafe ulong VirtualAddress
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return obj->Data32.VirtualAddress;
			}
			return (ulong)obj->Data64.VirtualAddress;
		}
	}

	public unsafe ulong MemorySize
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return obj->Data32.MemorySize;
			}
			return (ulong)obj->Data64.MemorySize;
		}
	}

	public unsafe ulong Align
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return obj->Data32.Align;
			}
			return (ulong)obj->Data64.Align;
		}
	}

	public unsafe uint Flags
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return obj->Data32.Flags;
			}
			return obj->Data64.Flags;
		}
	}

	public unsafe _y(byte* memory, _z* obj)
	{
		this.memory = memory;
		this.obj = obj;
	}

	public unsafe override string ToString()
	{
		if (!Environment.Is64BitProcess)
		{
			return $"ELF Program Header at: 0x{(ulong)obj:x}, owned by 0x{(ulong)memory:x}\n- Type: {obj->Data32.Type},\n- Size on file: 0x{(ulong)obj->Data32.Offset:x}..0x{obj->Data32.Offset + obj->Data32.FileSize:x}, {obj->Data64.FileSize} bytes.\n- Virtual address: 0x{(ulong)obj->Data32.VirtualAddress:x}..0x{obj->Data32.VirtualAddress + obj->Data32.MemorySize:x}\n- Flags: {obj->Data32.Flags}\n- Alignment: {obj->Data32.Align}\n";
		}
		return $"ELF Program Header at: 0x{(ulong)obj:x}, owned by 0x{(ulong)memory:x}\n- Type: {obj->Data64.Type},\n- Size on file: 0x{(ulong)obj->Data64.Offset:x}..0x{obj->Data64.Offset.ToUInt64() + obj->Data64.FileSize.ToUInt64():x}, {obj->Data64.FileSize} bytes.\n- Virtual address: 0x{(ulong)obj->Data64.VirtualAddress:x}..0x{obj->Data64.VirtualAddress.ToUInt64() + obj->Data64.MemorySize.ToUInt64():x}\n- Flags: {obj->Data64.Flags}\n- Alignment: {obj->Data64.Align}\n";
	}
}
internal class _Y : IReadOnlyList<_y>, IEnumerable<_y>, IEnumerable, IReadOnlyCollection<_y>
{
	private unsafe byte* _memory;

	private unsafe _z* _first;

	private int _count;

	public unsafe _y this[int index]
	{
		get
		{
			if (index >= _count)
			{
				throw new IndexOutOfRangeException($"Index {index} out of range {_count}");
			}
			return new _y(_memory, _first + index);
		}
	}

	public int Count => _count;

	public unsafe _Y(byte* data, ulong offset, int count)
	{
		_memory = data;
		_first = (_z*)(data + offset);
		_count = count;
	}

	public IEnumerator<_y> GetEnumerator()
	{
		int i = 0;
		while (i < _count)
		{
			yield return this[i];
			int num = i + 1;
			i = num;
		}
	}

	IEnumerator<_y> IEnumerable<_y>.GetEnumerator()
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
