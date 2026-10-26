using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

internal class _7F042AF7ECCF4530
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private unsafe delegate void InitDelegate(int argc, byte** argv, byte** envp);

	private static readonly byte[] MagicSymbol = new byte[4] { 127, 69, 76, 70 };

	private unsafe byte* _memory;

	private unsafe _50E28FBE88E34375* obj;

	public readonly A96A6382B424400A ProgramHeaders;

	public readonly _8CD136FD6675485E SectionHeaders;

	public readonly _9F61EB4FCBA44886 DynamicSectionHeader;

	private readonly Dictionary<string, IntPtr> _dependencyHandles = new Dictionary<string, IntPtr>();

	public unsafe _7F042AF7ECCF4530(byte* ptr)
	{
		_memory = ptr;
		obj = (_50E28FBE88E34375*)ptr;
		if (*obj->Magic != MagicSymbol[0] || obj->Magic[1] != MagicSymbol[1] || obj->Magic[2] != MagicSymbol[2] || obj->Magic[3] != MagicSymbol[3])
		{
			throw new InvalidOperationException("Not a valid ELF header.");
		}
		ProgramHeaders = new A96A6382B424400A(ptr, (ulong)(long)obj->ProgramHeaderOffset, obj->ProgramHeaderCount);
		SectionHeaders = new _8CD136FD6675485E(ptr, (ulong)(long)obj->SectionHeaderOffset, obj->SectionHeaderCount, obj->SectionHeaderStringIndex);
		DynamicSectionHeader = SectionHeaders.FirstOrDefault((_9F61EB4FCBA44886 header) => header.Type == ElfSectionHeaderType.Dynamic);
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
