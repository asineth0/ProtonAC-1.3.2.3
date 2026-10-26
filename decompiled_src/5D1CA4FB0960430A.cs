using System;

internal struct _5D1CA4FB0960430A(ulong value)
{
	private enum x86 : uint
	{
		None = 0u,
		_32 = 1u,
		PC32 = 2u,
		GOT32 = 3u,
		PLT32 = 4u,
		Copy = 5u,
		GlobDat = 6u,
		JmpSlot = 7u,
		Relative = 8u,
		GOTOff = 9u,
		GOTPC = 10u,
		_32PLT = 11u,
		_16 = 20u,
		PC16 = 21u,
		_8 = 22u,
		PC8 = 23u,
		DTPMOD32 = 35u,
		DTPOFF32 = 36u,
		Size32 = 38u
	}

	private enum x86_64 : uint
	{
		None = 0u,
		_64 = 1u,
		PC32 = 2u,
		GOT32 = 3u,
		PLT32 = 4u,
		Copy = 5u,
		GlobDat = 6u,
		JmpSlot = 7u,
		Relative = 8u,
		GOTPCREL = 9u,
		_32 = 10u,
		_32S = 11u,
		_16 = 12u,
		PC16 = 13u,
		_8 = 14u,
		PC8 = 15u,
		DTPMOD64 = 16u,
		DTPOFF64 = 17u,
		PC64 = 24u,
		GOTOff64 = 25u,
		GOTPC32 = 26u,
		Size32 = 32u,
		Size64 = 33u
	}

	private uint _value = (uint)value;

	public static readonly uint None = (Environment.Is64BitProcess ? 0u : 0u);

	public static readonly uint Relative = (Environment.Is64BitProcess ? 8u : 8u);

	public static readonly uint GlobDat = (Environment.Is64BitProcess ? 6u : 6u);

	public static readonly uint JmpSlot = (Environment.Is64BitProcess ? 7u : 7u);

	public static readonly uint _64 = 1u;

	public static readonly uint _16 = (Environment.Is64BitProcess ? 12u : 20u);

	public static readonly uint Module = (Environment.Is64BitProcess ? 16u : 35u);

	public static readonly uint Offset = (Environment.Is64BitProcess ? 17u : 36u);

	public override string ToString()
	{
		if (!Environment.Is64BitProcess)
		{
			return $"x86_{(x86)_value}";
		}
		return $"x86_64_{(x86_64)_value}";
	}

	public bool IsNone()
	{
		return _value == None;
	}

	public bool IsRelative()
	{
		return _value == Relative;
	}

	public bool IsGlobDat()
	{
		return _value == GlobDat;
	}

	public bool IsJmpSlot()
	{
		return _value == JmpSlot;
	}

	public bool Is64()
	{
		if (!Environment.Is64BitProcess)
		{
			return false;
		}
		return _value == _64;
	}

	public bool Is16()
	{
		return _value == _16;
	}

	public bool IsModule()
	{
		return _value == Module;
	}

	public bool IsOffset()
	{
		return _value == Offset;
	}

	public static explicit operator _5D1CA4FB0960430A(ulong value)
	{
		return new _5D1CA4FB0960430A(value);
	}

	public static explicit operator uint(_5D1CA4FB0960430A relocationType)
	{
		return relocationType._value;
	}

	public static explicit operator ulong(_5D1CA4FB0960430A relocationType)
	{
		return relocationType._value;
	}
}
