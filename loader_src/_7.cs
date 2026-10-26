using System;

internal class _7
{
	private unsafe byte* _memory;

	private unsafe _9* _obj;

	private string _name;

	public unsafe ElfSymbolType Type => (ElfSymbolType)((Environment.Is64BitProcess ? _obj->Data64.Info : _obj->Data32.Info) & 0xF);

	public unsafe ElfSymbolBinding Binding => (ElfSymbolBinding)((Environment.Is64BitProcess ? _obj->Data64.Info : _obj->Data32.Info) >> 4);

	public string Name => _name;

	public unsafe ushort SectionHeaderTableIndex
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return _obj->Data32.SectionHeaderTableIndex;
			}
			return _obj->Data64.SectionHeaderTableIndex;
		}
	}

	public unsafe ushort Other
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return _obj->Data32.Other;
			}
			return _obj->Data64.Other;
		}
	}

	public unsafe ulong Value
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return _obj->Data32.Value;
			}
			return (ulong)_obj->Data64.Value;
		}
		set
		{
			if (Environment.Is64BitProcess)
			{
				_obj->Data64.Value = (UIntPtr)value;
			}
			else
			{
				_obj->Data32.Value = (uint)value;
			}
		}
	}

	public unsafe ulong Size
	{
		get
		{
			if (!Environment.Is64BitProcess)
			{
				return _obj->Data32.Size;
			}
			return (ulong)_obj->Data64.Size;
		}
	}

	public unsafe _7(byte* memory, _9* obj)
	{
		_memory = memory;
		_obj = obj;
	}

	public override string ToString()
	{
		return $"ELF Symbol:\n- Name: {Name}\n- Type: {Type}\n- Binding: {Binding}\n- Other: {Other}\n- Value: 0x{Value:x}\n- Size: {Size}\n- Index: {SectionHeaderTableIndex}\n";
	}

	public unsafe string ResolveName(_6 stringTable)
	{
		return _name = stringTable.GetString(Environment.Is64BitProcess ? _obj->Data64.Name : _obj->Data32.Name);
	}
}
