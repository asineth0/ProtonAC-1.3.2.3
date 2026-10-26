using System;

[Flags]
internal enum ElfSectionHeaderFlags : ulong
{
	Writeable = 1uL,
	Alloc = 2uL,
	Executable = 4uL,
	Merge = 0x10uL,
	Strings = 0x20uL,
	InfoLink = 0x40uL,
	LinkOrder = 0x80uL,
	OsNonconforming = 0x100uL,
	Group = 0x200uL,
	ThreadLocalStorage = 0x400uL,
	MaskOs = 0xFF00000uL,
	MaskProc = 0xF0000000uL
}
