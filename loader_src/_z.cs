using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct _z
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct DataLayout32
	{
		public ElfProgramHeaderType Type;

		public uint Offset;

		public uint VirtualAddress;

		public uint PhysicalAddress;

		public uint FileSize;

		public uint MemorySize;

		public uint Flags;

		public uint Align;
	}

	public struct DataLayout64
	{
		public ElfProgramHeaderType Type;

		public uint Flags;

		public UIntPtr Offset;

		public UIntPtr VirtualAddress;

		public UIntPtr PhysicalAddress;

		public UIntPtr FileSize;

		public UIntPtr MemorySize;

		public UIntPtr Align;
	}

	[FieldOffset(0)]
	public DataLayout32 Data32;

	[FieldOffset(0)]
	public DataLayout64 Data64;
}
internal class _Z
{
	private unsafe byte* _memory;

	private unsafe _1* _obj;

	public unsafe ulong Offset => (ulong)_obj->Offset;

	public unsafe _2 Type
	{
		get
		{
			if (Environment.Is64BitProcess)
			{
				return new _2((ulong)_obj->Info & 0xFFFFFFFFu);
			}
			return new _2((ulong)_obj->Info & 0xFF);
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

	public unsafe _Z(byte* memory, _1* obj)
	{
		_memory = memory;
		_obj = obj;
	}

	public unsafe override string ToString()
	{
		return $"ELF Relocation Entry at: 0x{(ulong)_obj:x}\n- Offset: 0x{Offset:x}\n- Type: {Type}\n- Symbol: {Symbol}\n- Addend: {Addend}\n";
	}
}
