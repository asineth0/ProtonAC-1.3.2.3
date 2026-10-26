using System;

[Flags]
internal enum MmapMappingFlags
{
	Private = 2,
	Fixed = 0x10,
	Anonymous = 0x20
}
