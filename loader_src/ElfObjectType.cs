internal enum ElfObjectType : ushort
{
	None = 0,
	Rel = 1,
	Exec = 2,
	Dyn = 3,
	Core = 4,
	LoOS = 65024,
	HiOS = 65279,
	LoProc = 65280,
	HiProc = ushort.MaxValue
}
