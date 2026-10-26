internal enum ElfSectionHeaderType : uint
{
	Null = 0u,
	ProgramBits = 1u,
	SymbolTable = 2u,
	StringTable = 3u,
	RelocationAddends = 4u,
	Hash = 5u,
	Dynamic = 6u,
	Note = 7u,
	NoBits = 8u,
	Relocation = 9u,
	ShLib = 10u,
	DynamicSymbol = 11u,
	InitArray = 14u,
	FinalizeArray = 15u,
	PreInitArray = 16u,
	Group = 17u,
	SymbolTableExtendedIndices = 18u,
	NumberOfDefindedTypes = 19u,
	LoOS = 1610612736u
}
