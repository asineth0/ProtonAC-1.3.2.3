using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct _1BF6F1682AC14ECD
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
