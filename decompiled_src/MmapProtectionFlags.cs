using System;

[Flags]
internal enum MmapProtectionFlags
{
	Read = 1,
	Write = 2,
	Execute = 4,
	All = Read | Write | Execute,
	None = 0
}
