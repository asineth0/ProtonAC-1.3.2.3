internal enum ElfSymbolBinding : byte
{
	Local = 0,
	Global = 1,
	Weak = 2,
	LoProc = 13,
	HiProc = 15
}
