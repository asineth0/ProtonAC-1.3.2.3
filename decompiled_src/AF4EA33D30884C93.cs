using System;

internal class AF4EA33D30884C93
{
	private unsafe byte* memory;

	private unsafe _1BF6F1682AC14ECD* obj;

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

	public unsafe AF4EA33D30884C93(byte* memory, _1BF6F1682AC14ECD* obj)
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
