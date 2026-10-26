using System;

[Flags]
internal enum ElfProgramHeaderLoadFlags
{
	Execute = 1,
	Write = 2,
	Read = 4
}
