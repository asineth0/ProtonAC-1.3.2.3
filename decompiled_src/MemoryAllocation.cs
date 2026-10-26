using System;

[Flags]
internal enum MemoryAllocation : uint
{
	Commit = 0x1000u,
	Reserve = 0x2000u,
	Decommit = 0x4000u,
	Release = 0x8000u
}
