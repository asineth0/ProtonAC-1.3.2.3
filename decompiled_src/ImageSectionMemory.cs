using System;

[Flags]
internal enum ImageSectionMemory : uint
{
	Discardable = 0x2000000u,
	NotCached = 0x4000000u,
	NotPaged = 0x8000000u,
	Shared = 0x10000000u,
	Exectute = 0x20000000u,
	Read = 0x40000000u,
	Write = 0x80000000u
}
