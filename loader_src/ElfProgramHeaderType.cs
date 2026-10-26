internal enum ElfProgramHeaderType : uint
{
	Null = 0u,
	Load = 1u,
	Dynamic = 2u,
	Interpreter = 3u,
	Note = 4u,
	ShLib = 5u,
	ProgramHeaderTable = 6u,
	ThreadLocalStorage = 7u,
	LoOS = 1610612736u,
	HiOS = 1879048191u,
	LoProc = 1879048192u,
	HiProc = 2147483647u
}
