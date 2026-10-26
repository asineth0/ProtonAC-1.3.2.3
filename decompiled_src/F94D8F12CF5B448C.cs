using System;

internal class F94D8F12CF5B448C
{
	private unsafe byte* _memory;

	private unsafe _7E42BB58195B4621* _obj;

	public unsafe ulong Offset => (ulong)_obj->Offset;

	public unsafe _5D1CA4FB0960430A Type
	{
		get
		{
			if (Environment.Is64BitProcess)
			{
				return new _5D1CA4FB0960430A((ulong)_obj->Info & 0xFFFFFFFFu);
			}
			return new _5D1CA4FB0960430A((ulong)_obj->Info & 0xFF);
		}
	}

	public unsafe ulong Symbol
	{
		get
		{
			if (Environment.Is64BitProcess)
			{
				return (ulong)_obj->Info >> 32;
			}
			return (ulong)_obj->Info >> 8;
		}
	}

	public unsafe ulong Addend => (ulong)(long)_obj->Addend;

	public bool DependsOnSymbol()
	{
		if (!Type.Is16() && !Type.Is64() && !Type.IsGlobDat())
		{
			return Type.IsJmpSlot();
		}
		return true;
	}

	public unsafe F94D8F12CF5B448C(byte* memory, _7E42BB58195B4621* obj)
	{
		_memory = memory;
		_obj = obj;
	}

	public unsafe override string ToString()
	{
		return $"ELF Relocation Entry at: 0x{(ulong)_obj:x}\n- Offset: 0x{Offset:x}\n- Type: {Type}\n- Symbol: {Symbol}\n- Addend: {Addend}\n";
	}
}
