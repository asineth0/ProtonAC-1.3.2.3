using System;

[Flags]
internal enum MmapProtectionFlags
{
	Read = 1,
	Write = 2,
	Execute = 4,
	All = 7,
	None = 0
}
