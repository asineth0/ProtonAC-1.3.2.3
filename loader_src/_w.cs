using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

internal struct _w
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DummyUnion
	{
		[FieldOffset(0)]
		public UIntPtr Value;

		[FieldOffset(0)]
		public UIntPtr Ptr;
	}

	public UIntPtr Tag;

	public DummyUnion ValueOrPtr;
}
internal class _W
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private unsafe delegate void InitDelegate(int argc, byte** argv, byte** envp);

	private static readonly byte[] MagicSymbol = new byte[4] { 127, 69, 76, 70 };

	private unsafe byte* _memory;

	private unsafe _x* obj;

	public readonly _Y ProgramHeaders;

	public readonly _4 SectionHeaders;

	public readonly _3 DynamicSectionHeader;

	private readonly Dictionary<string, IntPtr> _dependencyHandles = (Dictionary<string, IntPtr>)Activator.CreateInstance(typeof(Dictionary<string, IntPtr>));

	public unsafe _W(byte* ptr)
	{
		_memory = ptr;
		obj = (_x*)ptr;
		if (*obj->Magic != MagicSymbol[0] || obj->Magic[1] != MagicSymbol[1] || obj->Magic[2] != MagicSymbol[2] || obj->Magic[3] != MagicSymbol[3])
		{
			throw new InvalidOperationException("Not a valid ELF header.");
		}
		ProgramHeaders = new _Y(ptr, (ulong)(long)obj->ProgramHeaderOffset, obj->ProgramHeaderCount);
		SectionHeaders = new _4(ptr, (ulong)(long)obj->SectionHeaderOffset, obj->SectionHeaderCount, obj->SectionHeaderStringIndex);
		DynamicSectionHeader = SectionHeaders.FirstOrDefault((_3 header) => header.Type == ElfSectionHeaderType.Dynamic);
	}

	public unsafe byte* GetAddress(ulong Offset = 0uL)
	{
		return _memory + Offset;
	}

	public unsafe override string ToString()
	{
		return $"ELF Header at: 0x{(ulong)_memory:x}\n- Pointer class: {obj->Class}\n- Endian: {obj->Endianess}\n- ELF Version: {obj->Version}\n- ABI: {obj->OsAbi}\n- ABI Version: {obj->AbiVersion}\n- Object type: {obj->Type}\n- Instruction set: {obj->Machine}\n- ELF Version: {obj->ElfVersion}\n- Entry Point Address: 0x{(ulong)(long)obj->Entry:x}\n- Program Header Table Location: 0x{(ulong)(long)obj->ProgramHeaderOffset:x}\n- Section Header Table Location: 0x{(ulong)(long)obj->SectionHeaderOffset:x}\n- Flags: {obj->ArchitectureDependentFlags}\n- Header size: {obj->ElfHeaderSize}\n- Program Header Table Entry Size: 0x{(ulong)obj->ProgramHeaderSize:x}\n- Program Header Table Entry Count: {obj->ProgramHeaderCount}\n- Section Header Table Entry Size: 0x{(ulong)obj->SectionHeaderSize:x}\n- Section Header Table Entry Count: {obj->SectionHeaderCount} \n- Section Header Table Name Index: {obj->SectionHeaderStringIndex}\n";
	}
}
