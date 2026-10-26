using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static class _89C94C43C8614FCF
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
	private struct __anontype_1639d593_0026
	{
		[FieldOffset(0)]
		public uint dwOemID;

		[FieldOffset(0)]
		public __anontype_1639d593_0027 s;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	private struct __anontype_1639d593_0027
	{
		public ushort wProcessorArchitecture;

		public ushort wReserved;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
	private struct __anontype_1639d593_0036
	{
		[FieldOffset(0)]
		public uint PhysicalAddress;

		[FieldOffset(0)]
		public uint VirtualSize;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private class MEMORYMODULE
	{
		public unsafe _IMAGE_NT_HEADERS* headers;

		public unsafe byte* codeBase;

		public unsafe void** modules;

		public int numModules;

		[MarshalAs(UnmanagedType.Bool)]
		public bool initialized;

		[MarshalAs(UnmanagedType.Bool)]
		public bool isDLL;

		[MarshalAs(UnmanagedType.Bool)]
		public bool isRelocated;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomAllocFunc alloc;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomFreeFunc free;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomLoadLibraryFunc loadLibrary;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomGetProcAddressFunc getProcAddress;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomFreeLibraryFunc freeLibrary;

		public IntPtr nameExportsTable;

		public unsafe void* userdata;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public ExeEntryProc exeEntry;

		public uint pageSize;

		public unsafe POINTER_LIST* blockedMemory;

		public unsafe static MEMORYMODULE MarshalFrom(_MEMORYMODULE* ptr)
		{
			MEMORYMODULE mEMORYMODULE = new MEMORYMODULE();
			Marshal.PtrToStructure((IntPtr)ptr, mEMORYMODULE);
			return mEMORYMODULE;
		}

		public unsafe void MarshalTo(_MEMORYMODULE* ptr)
		{
			Marshal.StructureToPtr(this, (IntPtr)ptr, fDeleteOld: true);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private struct _MEMORYMODULE
	{
		public unsafe _IMAGE_NT_HEADERS* headers;

		public unsafe byte* codeBase;

		public unsafe void** modules;

		public int numModules;

		public int initialized;

		public int isDLL;

		public int isRelocated;

		public unsafe void* alloc;

		public unsafe void* free;

		public unsafe void* loadLibrary;

		public unsafe void* getProcAddress;

		public unsafe void* freeLibrary;

		public IntPtr nameExportsTable;

		public unsafe void* userdata;

		public unsafe void* exeEntry;

		public uint pageSize;

		public unsafe POINTER_LIST* blockedMemory;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 8)]
	public struct POINTER_LIST
	{
		public unsafe POINTER_LIST* next;

		public unsafe void* address;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 20)]
	private struct SECTIONFINALIZEDATA
	{
		public unsafe void* address;

		public unsafe void* alignedAddress;

		public uint size;

		public uint characteristics;

		public bool last;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	private struct __anontype_b18cdc1e_0003
	{
		[FieldOffset(0)]
		public __anontype_b18cdc1e_0004 DUMMYSTRUCTNAME;

		[FieldOffset(0)]
		public uint Name;

		[FieldOffset(0)]
		public ushort Id;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 4)]
	private struct __anontype_b18cdc1e_0004
	{
		public uint bits0;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	private struct __anontype_b18cdc1e_0005
	{
		[FieldOffset(0)]
		public uint OffsetToData;

		[FieldOffset(0)]
		public __anontype_b18cdc1e_0006 DUMMYSTRUCTNAME2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 4)]
	private struct __anontype_b18cdc1e_0006
	{
		public uint bits0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 8)]
	private struct _IMAGE_BASE_RELOCATION
	{
		public uint VirtualAddress;

		public uint SizeOfBlock;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	private struct _IMAGE_DATA_DIRECTORY
	{
		public uint VirtualAddress;

		public uint Size;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 128)]
	private struct _IMAGE_DATA_DIRECTORY_array_128
	{
		public unsafe _IMAGE_DATA_DIRECTORY this[int offset]
		{
			get
			{
				fixed (_IMAGE_DATA_DIRECTORY_array_128* ptr = &this)
				{
					void* ptr2 = ptr;
					_IMAGE_DATA_DIRECTORY* ptr3 = (_IMAGE_DATA_DIRECTORY*)ptr2;
					return ptr3[offset];
				}
			}
			set
			{
				fixed (_IMAGE_DATA_DIRECTORY_array_128* ptr = &this)
				{
					void* ptr2 = ptr;
					_IMAGE_DATA_DIRECTORY* ptr3 = (_IMAGE_DATA_DIRECTORY*)ptr2;
					ptr3[offset] = value;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
	private struct _IMAGE_EXPORT_DIRECTORY
	{
		public uint Characteristics;

		public uint TimeDateStamp;

		public ushort MajorVersion;

		public ushort MinorVersion;

		public uint Name;

		public uint Base;

		public uint NumberOfFunctions;

		public uint NumberOfNames;

		public uint AddressOfFunctions;

		public uint AddressOfNames;

		public uint AddressOfNameOrdinals;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
	private struct _IMAGE_FILE_HEADER
	{
		public ushort Machine;

		public ushort NumberOfSections;

		public uint TimeDateStamp;

		public uint PointerToSymbolTable;

		public uint NumberOfSymbols;

		public ushort SizeOfOptionalHeader;

		public ushort Characteristics;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2, Size = 4)]
	private struct _IMAGE_IMPORT_BY_NAME
	{
		public ushort Hint;

		public unsafe fixed byte Name[1];
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct _IMAGE_IMPORT_DESCRIPTOR
	{
		[FieldOffset(0)]
		public uint Characteristics;

		[FieldOffset(0)]
		public uint OriginalFirstThunk;

		[FieldOffset(4)]
		public uint TimeDateStamp;

		[FieldOffset(8)]
		public uint ForwarderChain;

		[FieldOffset(12)]
		public uint Name;

		[FieldOffset(16)]
		public uint FirstThunk;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 248)]
	private struct _IMAGE_NT_HEADERS
	{
		public uint Signature;

		public _IMAGE_FILE_HEADER FileHeader;

		public _IMAGE_OPTIONAL_HEADER OptionalHeader;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct _IMAGE_OPTIONAL_HEADER
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
		private struct DUMMY8BYTEVALUE
		{
			[FieldOffset(0)]
			public uint BaseOfData;

			[FieldOffset(4)]
			public uint ImageBase32;

			[FieldOffset(0)]
			public ulong ImageBase64;
		}

		private const int IMAGE_NUMBEROF_DIRECTORY_ENTRIES = 16;

		public ushort Magic;

		public byte MajorLinkerVersion;

		public byte MinorLinkerVersion;

		public uint SizeOfCode;

		public uint SizeOfInitializedData;

		public uint SizeOfUninitializedData;

		public uint AddressOfEntryPoint;

		public uint BaseOfCode;

		private DUMMY8BYTEVALUE _architectureSpecificValue1;

		public uint SectionAlignment;

		public uint FileAlignment;

		public ushort MajorOperatingSystemVersion;

		public ushort MinorOperatingSystemVersion;

		public ushort MajorImageVersion;

		public ushort MinorImageVersion;

		public ushort MajorSubsystemVersion;

		public ushort MinorSubsystemVersion;

		public uint Win32VersionValue;

		public uint SizeOfImage;

		public uint SizeOfHeaders;

		public uint CheckSum;

		public ushort Subsystem;

		public ushort DllCharacteristics;

		public UIntPtr SizeOfStackReserve;

		public UIntPtr SizeOfStackCommit;

		public UIntPtr SizeOfHeapReserve;

		public UIntPtr SizeOfHeapCommit;

		public uint LoaderFlags;

		public uint NumberOfRvaAndSizes;

		public _IMAGE_DATA_DIRECTORY_array_128 DataDirectory;

		public uint BaseOfData
		{
			get
			{
				return _architectureSpecificValue1.BaseOfData;
			}
			set
			{
				_architectureSpecificValue1.BaseOfData = value;
			}
		}

		public UIntPtr ImageBase
		{
			get
			{
				if (!Environment.Is64BitProcess)
				{
					return (UIntPtr)_architectureSpecificValue1.ImageBase32;
				}
				return (UIntPtr)_architectureSpecificValue1.ImageBase64;
			}
			set
			{
				if (Environment.Is64BitProcess)
				{
					_architectureSpecificValue1.ImageBase64 = (ulong)value;
				}
				else
				{
					_architectureSpecificValue1.ImageBase32 = (uint)value;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 16)]
	private struct _IMAGE_RESOURCE_DATA_ENTRY
	{
		public uint OffsetToData;

		public uint Size;

		public uint CodePage;

		public uint Reserved;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2, Size = 4)]
	private struct _IMAGE_RESOURCE_DIR_STRING_U
	{
		public ushort Length;

		public unsafe fixed char NameString[1];
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 16)]
	private struct _IMAGE_RESOURCE_DIRECTORY
	{
		public uint Characteristics;

		public uint TimeDateStamp;

		public ushort MajorVersion;

		public ushort MinorVersion;

		public ushort NumberOfNamedEntries;

		public ushort NumberOfIdEntries;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 8)]
	private struct _IMAGE_RESOURCE_DIRECTORY_ENTRY
	{
		public __anontype_b18cdc1e_0003 DUMMYUNIONNAME;

		public __anontype_b18cdc1e_0005 DUMMYUNIONNAME2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
	private struct _IMAGE_SECTION_HEADER
	{
		public unsafe fixed byte Name[8];

		public __anontype_1639d593_0036 Misc;

		public uint VirtualAddress;

		public uint SizeOfRawData;

		public uint PointerToRawData;

		public uint PointerToRelocations;

		public uint PointerToLinenumbers;

		public ushort NumberOfRelocations;

		public ushort NumberOfLinenumbers;

		public uint Characteristics;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private struct _IMAGE_TLS_DIRECTORY
	{
		public UIntPtr StartAddressOfRawData;

		public UIntPtr EndAddressOfRawData;

		public UIntPtr AddressOfIndex;

		public UIntPtr AddressOfCallBacks;

		public uint SizeOfZeroFill;

		public uint Characteristics;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct _SYSTEM_INFO
	{
		public __anontype_1639d593_0026 u;

		public uint dwPageSize;

		public unsafe void* lpMinimumApplicationAddress;

		public unsafe void* lpMaximumApplicationAddress;

		public UIntPtr dwActiveProcessorMask;

		public uint dwNumberOfProcessors;

		public uint dwProcessorType;

		public uint dwAllocationGranularity;

		public ushort wProcessorLevel;

		public ushort wProcessorRevision;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
	private struct IMAGE_DOS_HEADER
	{
		public ushort e_magic;

		public ushort e_cblp;

		public ushort e_cp;

		public ushort e_crlc;

		public ushort e_cparhdr;

		public ushort e_minalloc;

		public ushort e_maxalloc;

		public ushort e_ss;

		public ushort e_sp;

		public ushort e_csum;

		public ushort e_ip;

		public ushort e_cs;

		public ushort e_lfarlc;

		public ushort e_ovno;

		public unsafe fixed ushort e_res[4];

		public ushort e_oemid;

		public ushort e_oeminfo;

		public unsafe fixed ushort e_res2[10];

		public int e_lfanew;
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr FARPROC();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private unsafe delegate void PIMAGE_TLS_CALLBACK(void* DllHandle, uint Reason, void* Reserved);

	[UnmanagedFunctionPointer(CallingConvention.Winapi)]
	private unsafe delegate bool DllEntryProc(void* hinstDLL, Dll fdwReason, void* lpReserved);

	[UnmanagedFunctionPointer(CallingConvention.Winapi)]
	private delegate int ExeEntryProc();

	public static CustomAllocFunc DD1D33A9870E4CE7;

	public static CustomFreeFunc _084D8C4001694CA5;

	public static CustomLoadLibraryFunc _7A9F92DF137340BE;

	public static CustomGetProcAddressFunc _67D2A727A94F451D;

	public static CustomFreeLibraryFunc _708DBDD3C3BF4E22;

	private static readonly uint _45AD50D7D9F84A1A;

	private static readonly PageProtection[][][] _68FBFA3250A84BE2;

	private const uint _4D6E50442BD44409 = uint.MaxValue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static IntPtr _1DC86C26657C443F(byte* P_0, long P_1, CustomAllocFunc P_2 = null, CustomFreeFunc P_3 = null, CustomLoadLibraryFunc P_4 = null, CustomGetProcAddressFunc P_5 = null, CustomFreeLibraryFunc P_6 = null)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1007234437u);
		CustomAllocFunc customAllocFunc = P_2 ?? DD1D33A9870E4CE7;
		obj._184044A093C04AF2(10, 3756714596u);
		P_2 = customAllocFunc;
		CustomFreeFunc customFreeFunc = P_3 ?? _084D8C4001694CA5;
		obj._184044A093C04AF2(9, 2888593377u);
		P_3 = customFreeFunc;
		CustomLoadLibraryFunc customLoadLibraryFunc = P_4 ?? _7A9F92DF137340BE;
		obj._184044A093C04AF2(10, 2830277759u);
		P_4 = customLoadLibraryFunc;
		CustomGetProcAddressFunc customGetProcAddressFunc = P_5 ?? _67D2A727A94F451D;
		obj._184044A093C04AF2(9, 3485321483u);
		P_5 = customGetProcAddressFunc;
		P_6 = P_6 ?? _708DBDD3C3BF4E22;
		void* ptr = _5E63E1DA67C046A1(P_0, (ulong)P_1, P_2, P_3, P_4, P_5, P_6, (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>(-512718800 ^ (int)obj._184044A093C04AF2(1, 2535548432u)));
		if (ptr == (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x6AEBF4E8 ^ obj._184044A093C04AF2(2, 3049199711u))))
		{
			obj = new _81DD83B8AA2247AA(79531766u);
			throw _620FCAE00A124459((int)_4DDD9BAD87FB4691());
		}
		obj = new _81DD83B8AA2247AA(1295923761u);
		return new IntPtr(ptr);
	}

	public unsafe static bool FF9A58721C484FA2(IntPtr P_0)
	{
		return AD94EE958ADB4283((_MEMORYMODULE*)(void*)P_0);
	}

	public unsafe static _0001 _35956E2514FB4E0B<_0001>(IntPtr P_0, string P_1) where _0001 : Delegate
	{
		IntPtr intPtr = _1E0C77999D3E4F68(P_1);
		IntPtr intPtr2 = (IntPtr)_6B04F090606446FC((_MEMORYMODULE*)(void*)P_0, (char*)(void*)intPtr);
		if (intPtr2 == IntPtr.Zero)
		{
			throw _620FCAE00A124459((int)_4DDD9BAD87FB4691());
		}
		return (_0001)_25597B7A47384DDE(intPtr2, (Type)_075306E5B9FB4985(typeof(_0001).TypeHandle));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static IntPtr _0C450FB76CED42D3(IntPtr P_0, string P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2302798788u);
		char* ptr = (char*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x70B69F02 ^ obj._184044A093C04AF2(5, 900240723u)));
		IntPtr result;
		try
		{
			obj = new _81DD83B8AA2247AA(4209794112u);
			ptr = (char*)(void*)_1E0C77999D3E4F68(P_1);
			result = (IntPtr)_6B04F090606446FC((_MEMORYMODULE*)(void*)P_0, ptr);
		}
		finally
		{
			obj._184044A093C04AF2(136, 1431610432u);
			while (true)
			{
				IL_0064:
				int num = 241396342;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(~(~(-(num2 ^ (-746941043 * -(-116081198 ^ 0x471C94AD) - -unchecked(2103817581 * 275539989)))) * 243657687) - (unchecked(1282629746 * -1744023099) + --1799422290) - unchecked(-942757955 * 617998356)))) % 5)
					{
					case 0u:
						break;
					case 3u:
						obj._184044A093C04AF2(137, 2258496576u);
						num = ((int)num3 * -1314909130) ^ -1077904043;
						continue;
					case 4u:
						obj._184044A093C04AF2(131, 777223232u);
						num = ((int)num3 * -938170355) ^ -229327782;
						continue;
					case 2u:
						obj._184044A093C04AF2(130, 770192448u);
						num = ((int)num3 * -1715370799) ^ 0x147C1AFB;
						continue;
					default:
						_30FF1DBC74654F7B((IntPtr)ptr);
						goto end_IL_0069;
					}
					goto IL_0064;
					continue;
					end_IL_0069:
					break;
				}
				break;
			}
		}
		obj._184044A093C04AF2(8, 2444665161u);
		return result;
	}

	public unsafe static void* _1F7344CAB03C4710(void* P_0, char* P_1)
	{
		return _6B04F090606446FC((_MEMORYMODULE*)P_0, P_1);
	}

	internal unsafe static void* AAA645A4686F434E(void* P_0, UIntPtr P_1, MemoryAllocation P_2, PageProtection P_3, void* P_4)
	{
		return A40B0A3914BC4D4C(P_0, P_1, P_2, P_3);
	}

	internal unsafe static bool _5A65705A78994A08(void* P_0, UIntPtr P_1, MemoryAllocation P_2, void* P_3)
	{
		return _78DE2EAAD1584528(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void* DF2AD576C98244F3(char* P_0, void* P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3434345821u);
		void* ptr = default;
		while (true)
		{
			int num = -1818323829;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~((0x35368B01 ^ 0x3C2B2AE) - -(~(~(-num2) * -1063686997)))))) % 5)
				{
				case 3u:
					break;
				case 2u:
					return (void*)(uint)_003CModule_003E._390073C602714496<int>((int)(0x4F7A3FD ^ obj._184044A093C04AF2(0, 1019205987u)));
				case 4u:
				{
					int num4;
					int num5;
					if (ptr == (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x7CCC1750 ^ obj._184044A093C04AF2(6, 3766969414u))))
					{
						num4 = 1350194142;
						num5 = num4;
					}
					else
					{
						num4 = 1578051091;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 2105798124);
					continue;
				}
				case 1u:
					ptr = _8953E20892F241D0(P_0);
					num = (int)((num3 * 1497079074) ^ 0x77C55320);
					continue;
				default:
					obj = new _81DD83B8AA2247AA(1570270526u);
					return ptr;
				}
				break;
			}
		}
	}

	internal unsafe static void* _258EF3CD346F41E9(void* P_0, char* P_1, void* P_2)
	{
		return CED0FF9B864F4C22(P_0, P_1);
	}

	internal unsafe static bool _30D430E9499F4C5D(void* P_0, void* P_1)
	{
		return C664ED4F1AAD45A7(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* C30002B5761D43C9(void* P_0, ulong P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1237604545u);
		return _5E63E1DA67C046A1(P_0, P_1, DD1D33A9870E4CE7, _084D8C4001694CA5, _7A9F92DF137340BE, _67D2A727A94F451D, _708DBDD3C3BF4E22, (void*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>(-780688227 ^ (int)obj._184044A093C04AF2(2, 528903549u)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _5E63E1DA67C046A1(void* P_0, ulong P_1, CustomAllocFunc P_2, CustomFreeFunc P_3, CustomLoadLibraryFunc P_4, CustomGetProcAddressFunc P_5, CustomFreeLibraryFunc P_6, void* P_7)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3849426178u);
		_MEMORYMODULE* ptr2 = default;
		void* result = default;
		ulong num19 = default;
		int num22 = default;
		_IMAGE_NT_HEADERS* ptr5 = default;
		_IMAGE_SECTION_HEADER* ptr4 = default;
		byte* ptr3 = default;
		IMAGE_DOS_HEADER* ptr10 = default;
		POINTER_LIST* ptr7 = default;
		_SYSTEM_INFO sYSTEM_INFO = default;
		uint num11 = default;
		ulong num18 = default;
		while (true)
		{
			int num = -168349124;
			while (true)
			{
				int num2 = num;
				uint num3;
				byte* ptr13;
				switch ((num3 = (uint)(((0x18276DE0 ^ -2067126005) + ~unchecked(1374747255 - -2062226006) - ((-1790582006 ^ (unchecked(-255558367 * unchecked(925248238 * 565859747)) + -(917567265 - 1815473521))) - (num2 * 618721327 - unchecked(-408845897 * unchecked(~-1389785263 * 602571709))) * -1307084663)) ^ -1567796641 ^ 0x32556FF3)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_00c5;
				default:
					{
						ulong num4 = (ulong)_003CModule_003E._390073C602714496<int>((int)(0x1901EF15 ^ obj._184044A093C04AF2(4, 4255042614u)));
						ulong num5 = (ulong)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x7317B50A ^ obj._184044A093C04AF2(6, 3158254701u)));
						try
						{
							POINTER_LIST* ptr = (POINTER_LIST*)(uint)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x76067F77 ^ obj._184044A093C04AF2(10, 4136869578u)));
							if (!FC0231B4473749A8(P_1, (ulong)sizeof(IMAGE_DOS_HEADER)))
							{
								goto IL_0217;
							}
							goto IL_0961;
							IL_0217:
							int num6 = 1384580483;
							goto IL_021c;
							IL_021c:
							while (true)
							{
								num2 = num6;
								switch ((num3 = (uint)(((0x18276DE0 ^ -2067126005) + ~unchecked(1374747255 - -2062226006) - ((-1790582006 ^ (unchecked(-255558367 * unchecked(925248238 * 565859747)) + -(917567265 - 1815473521))) - (num2 * 618721327 - unchecked(-408845897 * unchecked(~-1389785263 * 602571709))) * -1307084663)) ^ -1567796641 ^ 0x32556FF3)) % 101)
								{
								case 47u:
									break;
								case 42u:
									obj = new _81DD83B8AA2247AA(2235053550u);
									num6 = 1264703017;
									continue;
								case 40u:
								{
									_MEMORYMODULE* ptr12 = ptr2;
									obj._184044A093C04AF2(2, 1892939717u);
									ptr12->isRelocated = _3178148E562E4ACC((byte)_003CModule_003E.F84FA79ABE6944BB<int>(-1094164376 ^ (int)obj._184044A093C04AF2(9, 0u)) != 0);
									num6 = 1041406500;
									continue;
								}
								case 64u:
									obj._184044A093C04AF2(2, 3095856806u);
									num6 = ((int)num3 * -22797666) ^ -661141900;
									continue;
								case 0u:
									obj._184044A093C04AF2(8, 4161514810u);
									obj._184044A093C04AF2(9, 3853473199u);
									obj._184044A093C04AF2(2, 415656123u);
									result = (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>(-1973761831 ^ (int)obj._184044A093C04AF2(11, 3709330222u));
									goto end_IL_01e9;
								case 25u:
									num6 = (int)(num3 * 1206870887) ^ -316367784;
									continue;
								case 95u:
									num19 = (ulong)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x3C18D820 ^ obj._184044A093C04AF2(9, 2682152556u)));
									num6 = 1817030912;
									continue;
								case 54u:
									obj = new _81DD83B8AA2247AA(3874528681u);
									num22 = (int)(ptr2->headers->OptionalHeader.ImageBase.ToUInt64() - ptr5->OptionalHeader.ImageBase.ToUInt64());
									num6 = -866512091;
									continue;
								case 66u:
									ptr4 = B823ADB6032F4C5B((UIntPtr)ptr5);
									num6 = 295496747;
									continue;
								case 39u:
								{
									int num45;
									int num46;
									if (!FC0231B4473749A8(P_1, ptr5->OptionalHeader.SizeOfHeaders))
									{
										num45 = -1999811224;
										num46 = num45;
									}
									else
									{
										num45 = -72298172;
										num46 = num45;
									}
									num6 = num45 ^ (int)(num3 * 1209876684);
									continue;
								}
								case 10u:
									DAB02FE0B5C74E11((Error)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x57DEF11F ^ obj._184044A093C04AF2(4, 3902205558u))));
									obj._184044A093C04AF2(3, 2857275492u);
									obj._184044A093C04AF2(10, 4058699583u);
									obj._184044A093C04AF2(9, 507425273u);
									result = (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-157099381 ^ (int)obj._184044A093C04AF2(4, 3871527699u));
									goto end_IL_01e9;
								case 7u:
									ptr2->codeBase = ptr3;
									num6 = -2053702724;
									continue;
								case 65u:
								{
									byte* ptr9 = ptr3;
									obj._184044A093C04AF2(4, 3980006985u);
									obj._184044A093C04AF2(5, 273527348u);
									int num29;
									int num30;
									if (ptr9 == (byte*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>(-1923360883 ^ (int)obj._184044A093C04AF2(10, 0u)))
									{
										num29 = -942772022;
										num30 = num29;
									}
									else
									{
										num29 = 1927107661;
										num30 = num29;
									}
									num6 = num29 ^ ((int)num3 * -1539059830);
									continue;
								}
								case 49u:
								{
									int num9;
									int num10;
									if (ptr3 != (byte*)(uint)_003CModule_003E._390073C602714496<int>((int)(0x78FBBAC4 ^ obj._184044A093C04AF2(10, 788860244u))))
									{
										num9 = -258225723;
										num10 = num9;
									}
									else
									{
										num9 = 1017574761;
										num10 = num9;
									}
									num6 = num9 ^ (int)(num3 * 1208892797);
									continue;
								}
								case 8u:
									ptr2->exeEntry = ptr3 + ptr2->headers->OptionalHeader.AddressOfEntryPoint;
									num6 = (int)((num3 * 1085045684) ^ 0x34C1AD1F);
									continue;
								case 73u:
									ptr3 = (byte*)P_2((void*)ptr5->OptionalHeader.ImageBase, (UIntPtr)num5, (MemoryAllocation)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x6E17F441 ^ obj._184044A093C04AF2(0, 1726989179u))), (PageProtection)_003CModule_003E._3F57E81A62734AC2<int>(-2018629265 ^ (int)obj._184044A093C04AF2(9, 852101561u)), P_7);
									num6 = 1634643664;
									continue;
								case 58u:
								{
									P_3(ptr3, (UIntPtr)(ulong)_003CModule_003E._390073C602714496<int>(-779529479 ^ (int)obj._184044A093C04AF2(2, 1247690094u)), (MemoryAllocation)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x2B97FC06 ^ obj._184044A093C04AF2(5, 893542581u))), P_7);
									int num41;
									int num42;
									if (_0C38845A5DED4296())
									{
										num41 = -1385420076;
										num42 = num41;
									}
									else
									{
										num41 = -118801712;
										num42 = num41;
									}
									num6 = num41 ^ ((int)num3 * -328559722);
									continue;
								}
								case 96u:
									obj = new _81DD83B8AA2247AA(3145331159u);
									DAB02FE0B5C74E11((Error)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x37FDC4DB ^ obj._184044A093C04AF2(0, 2570990917u))));
									num6 = ((int)num3 * -760581927) ^ -1800228240;
									continue;
								case 62u:
									obj._184044A093C04AF2(4, 2942727270u);
									num6 = ((int)num3 * -764021112) ^ -1942984405;
									continue;
								case 12u:
									obj._184044A093C04AF2(2, 3425942302u);
									num6 = ((int)num3 * -1512359787) ^ -1506312363;
									continue;
								case 85u:
									obj._184044A093C04AF2(132, 990674350u);
									obj._184044A093C04AF2(129, 2834890094u);
									obj._184044A093C04AF2(134, 1635797866u);
									num6 = ((int)num3 * -766846551) ^ 0x462EC75F;
									continue;
								case 53u:
									obj._184044A093C04AF2(5, 1157718590u);
									obj._184044A093C04AF2(10, 3095856806u);
									num6 = ((int)num3 * -373526263) ^ 0x14AD3C54;
									continue;
								case 18u:
								{
									ushort e_magic = ptr10->e_magic;
									obj._184044A093C04AF2(2, 591539014u);
									obj._184044A093C04AF2(1, 3802270497u);
									obj._184044A093C04AF2(11, 3944105131u);
									int num33;
									int num34;
									if (e_magic != _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x44915C88 ^ obj._184044A093C04AF2(8, 2031683725u))))
									{
										num33 = -518443539;
										num34 = num33;
									}
									else
									{
										num33 = 1114143764;
										num34 = num33;
									}
									num6 = num33 ^ (int)(num3 * 1585453363);
									continue;
								}
								case 84u:
									obj._184044A093C04AF2(1, 1015210578u);
									num6 = 994785195;
									continue;
								case 81u:
									goto IL_0961;
								case 37u:
									obj._184044A093C04AF2(128, 904050517u);
									obj._184044A093C04AF2(129, 1927233781u);
									num6 = -1578250053;
									continue;
								case 3u:
									obj._184044A093C04AF2(5, 2517105416u);
									num6 = -1003845538;
									continue;
								case 74u:
								{
									int num25;
									int num26;
									if (ptr2->headers->OptionalHeader.AddressOfEntryPoint == 0)
									{
										num25 = -637709178;
										num26 = num25;
									}
									else
									{
										num25 = 1120896520;
										num26 = num25;
									}
									num6 = num25 ^ (int)(num3 * 675740466);
									continue;
								}
								case 57u:
									ptr2 = (_MEMORYMODULE*)EE300819ED204F00(A1BFB55F51704683(), (uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x41F25942 ^ obj._184044A093C04AF2(6, 710022921u))), (uint)B3D0780808734390((Type)_075306E5B9FB4985(typeof(_MEMORYMODULE).TypeHandle)));
									num6 = -291634608;
									continue;
								case 77u:
								{
									int num16;
									int num17;
									if (((DllEntryProc)_25597B7A47384DDE((IntPtr)(ptr3 + ptr2->headers->OptionalHeader.AddressOfEntryPoint), (Type)_075306E5B9FB4985(typeof(DllEntryProc).TypeHandle)))(ptr3, (Dll)_003CModule_003E._390073C602714496<int>((int)(0x7741FD20 ^ obj._184044A093C04AF2(6, 2321730092u))), (void*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>(-1470341549 ^ (int)obj._184044A093C04AF2(5, 923647747u))))
									{
										num16 = -1189156930;
										num17 = num16;
									}
									else
									{
										num16 = 1348512802;
										num17 = num16;
									}
									num6 = num16 ^ (int)(num3 * 1086021316);
									continue;
								}
								case 41u:
									DAB02FE0B5C74E11((Error)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x3751AE4A ^ obj._184044A093C04AF2(6, 1949592784u))));
									obj._184044A093C04AF2(3, 2473135866u);
									obj._184044A093C04AF2(1, 3247854819u);
									obj._184044A093C04AF2(4, 1464278779u);
									result = (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x1C1B401 ^ obj._184044A093C04AF2(10, 4275110623u)));
									num6 = (int)(num3 * 1893604601) ^ -444069603;
									continue;
								case 94u:
									obj._184044A093C04AF2(10, 1892939717u);
									num6 = (int)(num3 * 151544843) ^ -1515356820;
									continue;
								case 92u:
									obj._184044A093C04AF2(8, 3983046152u);
									num6 = (int)(num3 * 1062264467) ^ -1972180526;
									continue;
								case 80u:
									ptr3 = (byte*)P_2((void*)(uint)_003CModule_003E._390073C602714496<int>((int)(0x2D90279C ^ obj._184044A093C04AF2(4, 346656513u))), (UIntPtr)num5, (MemoryAllocation)_003CModule_003E._390073C602714496<int>(-1263693436 ^ (int)obj._184044A093C04AF2(9, 2645613157u)), (PageProtection)_003CModule_003E._3F57E81A62734AC2<int>(-1402409147 ^ (int)obj._184044A093C04AF2(0, 352055104u)), P_7);
									num6 = ((int)num3 * -1061027646) ^ 0x1F0B2430;
									continue;
								case 97u:
									obj._184044A093C04AF2(0, 405573874u);
									obj._184044A093C04AF2(11, 3358468057u);
									obj._184044A093C04AF2(1, 3360776400u);
									result = (void*)(uint)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x4D823C8A ^ obj._184044A093C04AF2(10, 998523901u)));
									goto end_IL_01e9;
								case 19u:
								{
									int num47;
									int num48;
									if (ptr7 == (POINTER_LIST*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x6C0AB55 ^ obj._184044A093C04AF2(9, 1375826791u))))
									{
										num47 = 1521557249;
										num48 = num47;
									}
									else
									{
										num47 = 647074371;
										num48 = num47;
									}
									num6 = num47 ^ (int)(num3 * 1843104413);
									continue;
								}
								case 32u:
								{
									int num43;
									int num44;
									if (num22 != 0)
									{
										num43 = 1917741295;
										num44 = num43;
									}
									else
									{
										num43 = -1487680852;
										num44 = num43;
									}
									num6 = num43 ^ ((int)num3 * -1670908572);
									continue;
								}
								case 29u:
									obj._184044A093C04AF2(138, 1742593685u);
									obj._184044A093C04AF2(131, 1910313013u);
									num19 = ptr4->VirtualAddress + ptr4->SizeOfRawData;
									num6 = ((int)num3 * -1175543273) ^ -1896444352;
									continue;
								case 35u:
									obj._184044A093C04AF2(9, 3855674538u);
									num6 = ((int)num3 * -689116605) ^ -414238852;
									continue;
								case 60u:
								{
									int num39;
									int num40;
									if (ptr5->FileHeader.Machine == _45AD50D7D9F84A1A)
									{
										num39 = 1516214764;
										num40 = num39;
									}
									else
									{
										num39 = -862948824;
										num40 = num39;
									}
									num6 = num39 ^ ((int)num3 * -1583365230);
									continue;
								}
								case 16u:
									ptr7->address = ptr3;
									ptr = ptr7;
									num6 = ((int)num3 * -970912433) ^ 0x6D22A452;
									continue;
								case 34u:
									goto IL_0d2e;
								case 100u:
									ptr7->next = ptr;
									num6 = -2022642099;
									continue;
								case 71u:
									ptr2->blockedMemory = ptr;
									num6 = ((int)num3 * -251875617) ^ 0x1D1D0D19;
									continue;
								case 52u:
									goto IL_0d83;
								case 17u:
									obj._184044A093C04AF2(2, 1728918835u);
									obj._184044A093C04AF2(1, 4171246329u);
									obj._184044A093C04AF2(7, 2911844207u);
									result = (void*)(uint)_003CModule_003E._3F57E81A62734AC2<int>(-1159638528 ^ (int)obj._184044A093C04AF2(4, 3939466691u));
									goto end_IL_01e9;
								case 36u:
								{
									byte* ptr11 = ptr3;
									obj._184044A093C04AF2(9, 2754371156u);
									int num37;
									int num38;
									if (ptr11 == (byte*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x12EDE0DB ^ obj._184044A093C04AF2(8, 2746823416u))))
									{
										num37 = 2083297215;
										num38 = num37;
									}
									else
									{
										num37 = 1185098672;
										num38 = num37;
									}
									num6 = num37 ^ (int)(num3 * 1092961083);
									continue;
								}
								case 1u:
								{
									int num35;
									int num36;
									if (!A915C5148862457B(ptr2->isDLL))
									{
										num35 = 1060506538;
										num36 = num35;
									}
									else
									{
										num35 = -1709168447;
										num36 = num35;
									}
									num6 = num35 ^ ((int)num3 * -240668532);
									continue;
								}
								case 26u:
									DAB02FE0B5C74E11((Error)_003CModule_003E._3F57E81A62734AC2<int>(-26843602 ^ (int)obj._184044A093C04AF2(8, 3688745631u)));
									num6 = ((int)num3 * -1846043) ^ 0x14BB70AB;
									continue;
								case 88u:
									obj._184044A093C04AF2(10, 3740260971u);
									obj._184044A093C04AF2(1, 3950291008u);
									obj._184044A093C04AF2(4, 3495091099u);
									result = (void*)(uint)_003CModule_003E._390073C602714496<int>(-1508613969 ^ (int)obj._184044A093C04AF2(11, 2857275492u));
									num6 = ((int)num3 * -1498174597) ^ -1706497322;
									continue;
								case 51u:
									goto IL_0f81;
								case 93u:
									ptr2->isRelocated = _3178148E562E4ACC(_2F2FBEDE1C2F4057(ptr2, num22));
									num6 = ((int)num3 * -452309718) ^ 0x6E4B37E5;
									continue;
								case 55u:
									obj._184044A093C04AF2(4, 638803120u);
									num6 = 1977897386;
									continue;
								case 78u:
								{
									int num31;
									int num32;
									if (!_8AB571AFF0A04120(ptr2))
									{
										num31 = -673328492;
										num32 = num31;
									}
									else
									{
										num31 = -1838458885;
										num32 = num31;
									}
									num6 = num31 ^ ((int)num3 * -222689468);
									continue;
								}
								case 90u:
								{
									_6072F3E65B854F58(&sYSTEM_INFO);
									num5 = B4EE046A2F6747DA(ptr5->OptionalHeader.SizeOfImage, sYSTEM_INFO.dwPageSize);
									int num27;
									int num28;
									if (num5 != B4EE046A2F6747DA(num4, sYSTEM_INFO.dwPageSize))
									{
										num27 = 382871504;
										num28 = num27;
									}
									else
									{
										num27 = -635157619;
										num28 = num27;
									}
									num6 = num27 ^ (int)(num3 * 1237493024);
									continue;
								}
								case 24u:
									obj._184044A093C04AF2(11, 1148031291u);
									goto IL_1b37;
								case 27u:
									DAB02FE0B5C74E11((Error)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x59E6032E ^ obj._184044A093C04AF2(8, 1410851839u))));
									num6 = (int)((num3 * 156932630) ^ 0x333B8051);
									continue;
								case 69u:
									DAB02FE0B5C74E11((Error)_003CModule_003E._390073C602714496<int>((int)(0x126541C6 ^ obj._184044A093C04AF2(9, 3187415196u))));
									obj._184044A093C04AF2(11, 2911844207u);
									obj._184044A093C04AF2(2, 117514068u);
									obj._184044A093C04AF2(9, 1877373714u);
									result = (void*)(uint)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x4D823C8A ^ obj._184044A093C04AF2(8, 2054898520u)));
									num6 = (int)((num3 * 550072387) ^ 0x262C2D10);
									continue;
								case 98u:
									goto end_IL_01e9;
								case 70u:
								{
									_MEMORYMODULE* ptr8 = ptr2;
									obj._184044A093C04AF2(5, 1593457669u);
									obj._184044A093C04AF2(10, 2321730092u);
									ptr8->initialized = _3178148E562E4ACC((byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-841305000 ^ (int)obj._184044A093C04AF2(8, 0u)) != 0);
									num6 = 318479578;
									continue;
								}
								case 22u:
									goto end_IL_01e9;
								case 63u:
									obj._184044A093C04AF2(7, 1148031291u);
									obj._184044A093C04AF2(1, 3953120319u);
									obj._184044A093C04AF2(6, 853920906u);
									DAB02FE0B5C74E11((Error)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x6B26CDCF ^ obj._184044A093C04AF2(8, 2942727270u))));
									goto IL_1b37;
								case 46u:
									obj = new _81DD83B8AA2247AA(258181027u);
									num6 = 1118682996;
									continue;
								case 14u:
									DAB02FE0B5C74E11((Error)_003CModule_003E._58ECCB512F2A43AC<int>(-1603158028 ^ (int)obj._184044A093C04AF2(4, 3493792657u)));
									num6 = -1075596915;
									continue;
								case 9u:
									num6 = (int)((num3 * 1729896996) ^ 0x694FC6E3);
									continue;
								case 33u:
								{
									int num23;
									int num24;
									if (num19 > num4)
									{
										num23 = -1186486276;
										num24 = num23;
									}
									else
									{
										num23 = 1348127155;
										num24 = num23;
									}
									num6 = num23 ^ ((int)num3 * -1884731945);
									continue;
								}
								case 72u:
									obj = new _81DD83B8AA2247AA(1491987469u);
									num6 = -1531448182;
									continue;
								case 86u:
									obj._184044A093C04AF2(8, 3238939025u);
									obj._184044A093C04AF2(5, 101806738u);
									obj._184044A093C04AF2(10, 876608854u);
									num11 = (uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x172629DE ^ obj._184044A093C04AF2(3, 2159031534u)));
									num6 = ((int)num3 * -315514187) ^ 0x7A1E8462;
									continue;
								case 76u:
									goto IL_12f3;
								case 21u:
									goto IL_131d;
								case 11u:
									goto IL_1377;
								case 68u:
									ptr3 = (byte*)P_2((void*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x5A946F67 ^ obj._184044A093C04AF2(5, 211918101u))), (UIntPtr)num5, (MemoryAllocation)_003CModule_003E._3F57E81A62734AC2<int>(-1792109520 ^ (int)obj._184044A093C04AF2(8, 2746823416u)), (PageProtection)_003CModule_003E.F84FA79ABE6944BB<int>(-494679423 ^ (int)obj._184044A093C04AF2(5, 1328678039u)), P_7);
									num6 = (int)((num3 * 1183687632) ^ 0x316038ED);
									continue;
								case 99u:
									DAB02FE0B5C74E11((Error)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x71E4A585 ^ obj._184044A093C04AF2(8, 3102287237u))));
									num6 = ((int)num3 * -412046849) ^ 0xEC0F55F;
									continue;
								case 20u:
									ptr7 = (POINTER_LIST*)CDDC078DFED443F4((uint)sizeof(POINTER_LIST));
									num6 = -513626540;
									continue;
								case 5u:
									num11 += (uint)_003CModule_003E._390073C602714496<int>(-1764275815 ^ (int)obj._184044A093C04AF2(8, 299021639u));
									ptr4++;
									num6 = 1093837824;
									continue;
								case 91u:
								{
									int num20;
									int num21;
									if (ptr2 == (_MEMORYMODULE*)(uint)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x60D134D7 ^ obj._184044A093C04AF2(8, 2917352194u))))
									{
										num20 = 736323901;
										num21 = num20;
									}
									else
									{
										num20 = -1881136086;
										num21 = num20;
									}
									num6 = num20 ^ (int)(num3 * 602096597);
									continue;
								}
								case 13u:
								{
									_MEMORYMODULE* ptr6 = ptr2;
									obj._184044A093C04AF2(9, 2077812658u);
									ptr6->exeEntry = (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>(-952660771 ^ (int)obj._184044A093C04AF2(2, 0u));
									num6 = 1392871307;
									continue;
								}
								case 31u:
									_1A57D4B8754D4F54(ptr, P_3, P_7);
									num6 = (int)(num3 * 1659960354) ^ -1391407172;
									continue;
								case 43u:
									obj = new _81DD83B8AA2247AA(624542133u);
									num19 = ptr4->VirtualAddress + num18;
									num6 = (int)(num3 * 1406361408) ^ -206324140;
									continue;
								case 4u:
									obj._184044A093C04AF2(6, 942472772u);
									goto IL_1b37;
								case 87u:
									num4 = num19;
									num6 = ((int)num3 * -1832766575) ^ -1620449344;
									continue;
								case 45u:
									_1A57D4B8754D4F54(ptr, P_3, P_7);
									num6 = ((int)num3 * -259950101) ^ 0x65AB92D1;
									continue;
								case 50u:
									ptr2->isDLL = _3178148E562E4ACC((uint)(ptr5->FileHeader.Characteristics & _003CModule_003E._3F57E81A62734AC2<int>(-248338435 ^ (int)obj._184044A093C04AF2(9, 983465803u))) > (uint)_003CModule_003E._58ECCB512F2A43AC<int>(-1863560173 ^ (int)obj._184044A093C04AF2(0, 728980725u)));
									ptr2->alloc = (void*)Marshal.GetFunctionPointerForDelegate(P_2);
									ptr2->free = (void*)Marshal.GetFunctionPointerForDelegate(P_3);
									ptr2->loadLibrary = (void*)Marshal.GetFunctionPointerForDelegate(P_4);
									num6 = ((int)num3 * -1070040656) ^ 0x509F2E24;
									continue;
								case 6u:
									obj._184044A093C04AF2(1, 3489855815u);
									num6 = -518736544;
									continue;
								case 82u:
									num18 = ptr5->OptionalHeader.SectionAlignment;
									num6 = ((int)num3 * -1457315017) ^ -346957775;
									continue;
								case 59u:
									obj._184044A093C04AF2(2, 814850897u);
									obj._184044A093C04AF2(5, 1190972233u);
									obj._184044A093C04AF2(3, 852296468u);
									result = (void*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>(-872269136 ^ (int)obj._184044A093C04AF2(8, 1666579605u));
									goto end_IL_01e9;
								case 56u:
									DAB02FE0B5C74E11((Error)_003CModule_003E._3F57E81A62734AC2<int>(-469677854 ^ (int)obj._184044A093C04AF2(6, 3162092996u)));
									obj._184044A093C04AF2(4, 291106904u);
									obj._184044A093C04AF2(6, 3145247376u);
									obj._184044A093C04AF2(7, 2911844207u);
									result = (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x4CACF005 ^ obj._184044A093C04AF2(1, 3688962119u)));
									goto end_IL_01e9;
								case 38u:
									obj._184044A093C04AF2(8, 2942727270u);
									obj._184044A093C04AF2(1, 352607109u);
									num6 = (int)(num3 * 568172105) ^ -385208864;
									continue;
								case 30u:
								{
									ptr2->getProcAddress = (void*)Marshal.GetFunctionPointerForDelegate(P_5);
									ptr2->freeLibrary = (void*)Marshal.GetFunctionPointerForDelegate(P_6);
									ptr2->userdata = P_7;
									ptr2->pageSize = sYSTEM_INFO.dwPageSize;
									int num14;
									int num15;
									if (_0C38845A5DED4296())
									{
										num14 = 351523379;
										num15 = num14;
									}
									else
									{
										num14 = 2065752805;
										num15 = num14;
									}
									num6 = num14 ^ (int)(num3 * 1420409188);
									continue;
								}
								case 2u:
									goto end_IL_01e9;
								case 28u:
									obj._184044A093C04AF2(3, 2473135866u);
									obj._184044A093C04AF2(5, 3247854819u);
									obj._184044A093C04AF2(6, 2330291727u);
									result = (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x4CACF005 ^ obj._184044A093C04AF2(0, 1165297236u)));
									goto end_IL_01e9;
								case 44u:
									obj._184044A093C04AF2(131, 448177390u);
									goto IL_1b37;
								case 23u:
									obj = new _81DD83B8AA2247AA(2796128615u);
									num6 = (int)((num3 * 217728126) ^ 0x4CC057FD);
									continue;
								case 79u:
								{
									int num12;
									int num13;
									if (num11 < ptr5->FileHeader.NumberOfSections)
									{
										num12 = 1133141331;
										num13 = num12;
									}
									else
									{
										num12 = 623656618;
										num13 = num12;
									}
									num6 = num12 ^ ((int)num3 * -845297797);
									continue;
								}
								case 89u:
								{
									int num7;
									int num8;
									if (ptr4->SizeOfRawData == 0)
									{
										num7 = -359378251;
										num8 = num7;
									}
									else
									{
										num7 = 2013387130;
										num8 = num7;
									}
									num6 = num7 ^ (int)(num3 * 165479017);
									continue;
								}
								case 48u:
									num6 = (int)((num3 * 1685895058) ^ 0x5DE19B7C);
									continue;
								case 15u:
									obj._184044A093C04AF2(11, 1148031291u);
									goto IL_1b37;
								case 83u:
									obj._184044A093C04AF2(7, 3119743678u);
									obj._184044A093C04AF2(9, 1668168223u);
									obj._184044A093C04AF2(6, 3682414283u);
									result = (void*)(uint)_003CModule_003E._3F57E81A62734AC2<int>(-1159638528 ^ (int)obj._184044A093C04AF2(4, 330768752u));
									goto end_IL_01e9;
								case 75u:
									goto IL_19a6;
								case 67u:
									P_3(ptr3, (UIntPtr)(ulong)_003CModule_003E._8B9C7B12B1AE4949<int>(-1975127246 ^ (int)obj._184044A093C04AF2(4, 1860642233u)), (MemoryAllocation)_003CModule_003E._390073C602714496<int>(-800206867 ^ (int)obj._184044A093C04AF2(0, 3903709361u)), P_7);
									_1A57D4B8754D4F54(ptr, P_3, P_7);
									num6 = ((int)num3 * -674774508) ^ 0x1C2137E7;
									continue;
								default:
									obj._184044A093C04AF2(5, 303087122u);
									result = ptr2;
									goto end_IL_01e9;
								}
								break;
								IL_19a6:
								int num49;
								if (!C9DC76F773CD4FDB(ptr5->OptionalHeader.SectionAlignment & (uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-672076121 ^ (int)obj._184044A093C04AF2(0, 3387937328u))))
								{
									num6 = 2030945348;
									num49 = num6;
								}
								else
								{
									num6 = 1677288653;
									num49 = num6;
								}
								continue;
								IL_0d2e:
								obj = new _81DD83B8AA2247AA(1606500760u);
								int num50;
								if (_0C38845A5DED4296())
								{
									num6 = -58352117;
									num50 = num6;
								}
								else
								{
									num6 = 1611490899;
									num50 = num6;
								}
								continue;
								IL_0f81:
								obj = new _81DD83B8AA2247AA(2530100925u);
								int num51;
								if (!FC0231B4473749A8(P_1, (ulong)(ptr10->e_lfanew + sizeof(_IMAGE_NT_HEADERS))))
								{
									num6 = -1616669423;
									num51 = num6;
								}
								else
								{
									num6 = 1513217446;
									num51 = num6;
								}
								continue;
								IL_1377:
								ptr5 = (_IMAGE_NT_HEADERS*)((byte*)P_0 + ptr10->e_lfanew);
								uint signature = ptr5->Signature;
								obj._184044A093C04AF2(0, 620051994u);
								obj._184044A093C04AF2(2, 3958148506u);
								obj._184044A093C04AF2(3, 2027520086u);
								int num52;
								if (signature == (uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x486566CF ^ obj._184044A093C04AF2(5, 3817771306u))))
								{
									num6 = -1120962896;
									num52 = num6;
								}
								else
								{
									num6 = 283104527;
									num52 = num6;
								}
								continue;
								IL_12f3:
								obj._184044A093C04AF2(0, 4010894337u);
								int num53;
								if (!_35DC0C54BA534CB5(ptr2))
								{
									num6 = -233973487;
									num53 = num6;
								}
								else
								{
									num6 = -2010410285;
									num53 = num6;
								}
								continue;
								IL_0d83:
								ptr13 = (byte*)P_2(ptr3, (UIntPtr)ptr5->OptionalHeader.SizeOfHeaders, (MemoryAllocation)_003CModule_003E._390073C602714496<int>(-1112501660 ^ (int)obj._184044A093C04AF2(2, 1203416598u)), (PageProtection)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x7CFBCDC2 ^ obj._184044A093C04AF2(9, 582225058u))), P_7);
								_9E65D1B026A2487E((void*)ptr13, (void*)ptr10, ptr5->OptionalHeader.SizeOfHeaders);
								ptr2->headers = (_IMAGE_NT_HEADERS*)(ptr13 + ptr10->e_lfanew);
								ptr2->headers->OptionalHeader.ImageBase = (UIntPtr)ptr3;
								int num54;
								if (!_52CAEAC208774684((byte*)P_0, P_1, ptr5, ptr2))
								{
									num6 = -1814365442;
									num54 = num6;
								}
								else
								{
									num6 = -753465901;
									num54 = num6;
								}
								continue;
								IL_131d:
								ulong num55 = (ulong)ptr3 >> _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x39AA075A ^ obj._184044A093C04AF2(8, 3201751220u)));
								ulong num56 = (ulong)(ptr3 + num5);
								obj._184044A093C04AF2(0, 1405005500u);
								int num57;
								if (num55 >= num56 >> _003CModule_003E._58ECCB512F2A43AC<int>(-1213343679 ^ (int)obj._184044A093C04AF2(6, 0u)))
								{
									num6 = 1611490899;
									num57 = num6;
								}
								else
								{
									num6 = 250886413;
									num57 = num6;
								}
							}
							goto IL_0217;
							IL_0961:
							ptr10 = (IMAGE_DOS_HEADER*)P_0;
							num6 = -1760236338;
							goto IL_021c;
							end_IL_01e9:;
						}
						catch
						{
							obj = new _81DD83B8AA2247AA(745087548u);
							while (true)
							{
								int num58 = 1438670480;
								while (true)
								{
									num2 = num58;
									switch ((num3 = (uint)(((0x18276DE0 ^ -2067126005) + ~unchecked(1374747255 - -2062226006) - ((-1790582006 ^ (unchecked(-255558367 * unchecked(925248238 * 565859747)) + -(917567265 - 1815473521))) - (num2 * 618721327 - unchecked(-408845897 * unchecked(~-1389785263 * 602571709))) * -1307084663)) ^ -1567796641 ^ 0x32556FF3)) % 3)
									{
									case 2u:
										break;
									case 1u:
										goto IL_1b1b;
									default:
										throw;
									}
									break;
									IL_1b1b:
									AD94EE958ADB4283(ptr2);
									num58 = (int)(num3 * 564092908) ^ -1582920287;
								}
							}
						}
						obj._184044A093C04AF2(0, 1668184699u);
						return result;
					}
					IL_1b37:
					AD94EE958ADB4283(ptr2);
					return (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x703E04A3 ^ obj._184044A093C04AF2(6, 2480725826u)));
				}
				break;
				IL_00c5:
				ptr2 = (_MEMORYMODULE*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x61D8FE57 ^ obj._184044A093C04AF2(1, 3053286082u)));
				ptr10 = (IMAGE_DOS_HEADER*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x61D8FE57 ^ obj._184044A093C04AF2(1, 3808770387u)));
				ptr5 = (_IMAGE_NT_HEADERS*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x7A8E1082 ^ obj._184044A093C04AF2(6, 954137730u)));
				ptr3 = (byte*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-250254246 ^ (int)obj._184044A093C04AF2(6, 3593312214u));
				ptr13 = (byte*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x21752C33 ^ obj._184044A093C04AF2(0, 3409358524u)));
				num22 = _003CModule_003E.F84FA79ABE6944BB<int>(-76402301 ^ (int)obj._184044A093C04AF2(9, 1827174444u));
				sYSTEM_INFO = default;
				num11 = (uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x70E94D5B ^ obj._184044A093C04AF2(8, 2288746738u)));
				num18 = (ulong)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x64DD2270 ^ obj._184044A093C04AF2(1, 3478566067u)));
				num = (int)((num3 * 1136327263) ^ 0x361CAE58);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static bool AD94EE958ADB4283(_MEMORYMODULE* P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(173624363u);
		_MEMORYMODULE* ptr = default;
		int num4 = default;
		MEMORYMODULE mEMORYMODULE = default;
		while (true)
		{
			int num = -1325113989;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((-1286426437 ^ 0x76737DA) + --1820739746 - ~(-(num2 * 1534510519 - -(~unchecked(1362085809 * ~(~-2058474136))) - -(-337271896 - (-unchecked(565914591 * -2082607362) - ~(~248997597)))))) ^ 0x789D40A2 ^ 0x7E991FF6)) % 25)
				{
				case 19u:
					break;
				case 11u:
					ptr = P_0;
					num = ((int)num3 * -939445839) ^ -1653285293;
					continue;
				case 14u:
					_6225D4C3DB2E45E3(A1BFB55F51704683(), (uint)_003CModule_003E._3F57E81A62734AC2<int>(-1136993323 ^ (int)obj._184044A093C04AF2(1, 752512619u)), ptr);
					num = -249276574;
					continue;
				case 1u:
				{
					void** modules = ptr->modules;
					obj._184044A093C04AF2(2, 891916638u);
					obj._184044A093C04AF2(9, 2891534541u);
					obj._184044A093C04AF2(0, 238768271u);
					int num8;
					if (modules != (void**)(uint)_003CModule_003E._3F57E81A62734AC2<int>(-46923918 ^ (int)obj._184044A093C04AF2(3, 2608758294u)))
					{
						num = -574679185;
						num8 = num;
					}
					else
					{
						num = -1247288073;
						num8 = num;
					}
					continue;
				}
				case 9u:
					GCHandle.FromIntPtr(ptr->nameExportsTable).Free();
					num = ((int)num3 * -2086835578) ^ -1285664265;
					continue;
				case 18u:
				{
					void* intPtr = ptr->modules[num4];
					obj._184044A093C04AF2(7, 1739201316u);
					obj._184044A093C04AF2(6, 450602404u);
					obj._184044A093C04AF2(5, 1498797532u);
					int num12;
					if (intPtr != (void*)(uint)_003CModule_003E._390073C602714496<int>((int)(0x586A3822 ^ obj._184044A093C04AF2(0, 2756021156u))))
					{
						num = 454453033;
						num12 = num;
					}
					else
					{
						num = -1212085194;
						num12 = num;
					}
					continue;
				}
				case 23u:
				{
					obj._184044A093C04AF2(1, 4263326365u);
					int num15;
					if (!(ptr->nameExportsTable != IntPtr.Zero))
					{
						num = -1814555151;
						num15 = num;
					}
					else
					{
						num = 323705463;
						num15 = num;
					}
					continue;
				}
				case 12u:
				{
					int num11;
					if (ptr->codeBase != (byte*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>(-1460126375 ^ (int)obj._184044A093C04AF2(9, 37724535u)))
					{
						num = -77932811;
						num11 = num;
					}
					else
					{
						num = -865872418;
						num11 = num;
					}
					continue;
				}
				case 3u:
				{
					int num6;
					int num7;
					if (num4 < ptr->numModules)
					{
						num6 = -1917269346;
						num7 = num6;
					}
					else
					{
						num6 = -881127680;
						num7 = num6;
					}
					num = num6 ^ (int)(num3 * 496269393);
					continue;
				}
				case 0u:
					obj = new _81DD83B8AA2247AA(1396449883u);
					num = -654675757;
					continue;
				case 15u:
					num4 += _003CModule_003E._58ECCB512F2A43AC<int>(-1874480242 ^ (int)obj._184044A093C04AF2(5, 1085764692u));
					num = (int)((num3 * 1514423044) ^ 0x6910AB4D);
					continue;
				case 2u:
					obj._184044A093C04AF2(8, 3934916817u);
					_57D606BE468B48CD((void*)ptr->modules);
					num = ((int)num3 * -1291201345) ^ 0x26F61A6D;
					continue;
				case 16u:
					obj = new _81DD83B8AA2247AA(3991947077u);
					num = -307212926;
					continue;
				case 4u:
					_81DBF2D572F0454F(ptr->blockedMemory, ptr->free, ptr->userdata);
					num = ((int)num3 * -1121402655) ^ -233054796;
					continue;
				case 22u:
				{
					int num13;
					int num14;
					if (!A915C5148862457B(ptr->initialized))
					{
						num13 = 1817661621;
						num14 = num13;
					}
					else
					{
						num13 = 377887199;
						num14 = num13;
					}
					num = num13 ^ (int)(num3 * 1195132757);
					continue;
				}
				case 21u:
					mEMORYMODULE = (MEMORYMODULE)_89FA370153C24543(P_0);
					num = ((int)num3 * -436637881) ^ 0x648303BC;
					continue;
				case 6u:
					((DllEntryProc)_25597B7A47384DDE((IntPtr)(ptr->codeBase + ptr->headers->OptionalHeader.AddressOfEntryPoint), (Type)_075306E5B9FB4985(typeof(DllEntryProc).TypeHandle)))(ptr->codeBase, (Dll)_003CModule_003E._3F57E81A62734AC2<int>(-1572651157 ^ (int)obj._184044A093C04AF2(5, 3482191634u)), (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x34D05BAE ^ obj._184044A093C04AF2(1, 812775662u))));
					_499CB42D040340B5(ptr);
					num = (int)(num3 * 2113901742) ^ -470157492;
					continue;
				case 10u:
					mEMORYMODULE.freeLibrary(ptr->modules[num4], ptr->userdata);
					num = ((int)num3 * -993682561) ^ 0x69B103CB;
					continue;
				case 8u:
				{
					_MEMORYMODULE* ptr2 = ptr;
					obj._184044A093C04AF2(4, 2084425982u);
					obj._184044A093C04AF2(7, 1279125078u);
					obj._184044A093C04AF2(6, 417747710u);
					int num9;
					int num10;
					if (ptr2 != (_MEMORYMODULE*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x7396878 ^ obj._184044A093C04AF2(9, 2296359722u))))
					{
						num9 = 169304634;
						num10 = num9;
					}
					else
					{
						num9 = -848782419;
						num10 = num9;
					}
					num = num9 ^ (int)(num3 * 961286731);
					continue;
				}
				case 5u:
				{
					obj = new _81DD83B8AA2247AA(3743107891u);
					int num5;
					if (_0C38845A5DED4296())
					{
						num = -1259405605;
						num5 = num;
					}
					else
					{
						num = -1976435303;
						num5 = num;
					}
					continue;
				}
				case 20u:
					return (byte)_003CModule_003E.F84FA79ABE6944BB<int>(-1722811796 ^ (int)new _81DD83B8AA2247AA(3420137685u)._184044A093C04AF2(0, 3999970749u)) != 0;
				case 7u:
					obj._184044A093C04AF2(8, 1322228597u);
					obj._184044A093C04AF2(11, 1739201316u);
					obj._184044A093C04AF2(9, 2584562224u);
					num4 = _003CModule_003E.F84FA79ABE6944BB<int>(-193238380 ^ (int)obj._184044A093C04AF2(10, 450602404u));
					num = (int)((num3 * 1983510488) ^ 0x5EF54F35);
					continue;
				case 13u:
					obj = new _81DD83B8AA2247AA(2834288161u);
					num = -20319754;
					continue;
				case 24u:
				{
					CustomFreeFunc free = mEMORYMODULE.free;
					byte* codeBase = ptr->codeBase;
					UIntPtr size = (UIntPtr)(ulong)_003CModule_003E._3F57E81A62734AC2<int>(-2023023942 ^ (int)obj._184044A093C04AF2(4, 1029596150u));
					obj._184044A093C04AF2(4, 1029596150u);
					free(codeBase, size, (MemoryAllocation)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x2D0AB38 ^ obj._184044A093C04AF2(7, 0u))), ptr->userdata);
					num = ((int)num3 * -1403811272) ^ 0x28336CD6;
					continue;
				}
				default:
					return (byte)_003CModule_003E._390073C602714496<int>(-642433633 ^ (int)obj._184044A093C04AF2(2, 2296975694u)) != 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _6B04F090606446FC(_MEMORYMODULE* P_0, char* P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3418408590u);
		byte* codeBase = P_0->codeBase;
		uint value = (uint)_003CModule_003E._58ECCB512F2A43AC<int>(-1227980430 ^ (int)obj._184044A093C04AF2(6, 1714228562u));
		_IMAGE_EXPORT_DIRECTORY* ptr = default;
		_IMAGE_DATA_DIRECTORY* ptr2 = _3BD68850EE9E41E3(P_0, (ImageDirectoryEntry)_003CModule_003E._3F57E81A62734AC2<int>(-1014467832 ^ (int)obj._184044A093C04AF2(1, 2428744074u)));
		if (ptr2->Size == 0)
		{
			goto IL_0062;
		}
		goto IL_059d;
		IL_0062:
		int num = 1522722056;
		goto IL_0067;
		IL_0067:
		uint num6 = default;
		uint* ptr4 = default;
		ushort* ptr3 = default;
		Dictionary<string, uint> dictionary = default;
		IntPtr intPtr = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(-((603776258 - -(~unchecked(818212609 - -1600343334)) - (-362630725 ^ (-(-739307995 ^ -1407991086) * -1553691269)) - (-(~707447340) - (0x558EE14 ^ 0x4A366E5D) + unchecked(416564147 * unchecked(unchecked(-1390912586 * -857624347) * 951299343)) - (-1120136203 * -638782449 + -(~unchecked(-1765471709 * -1305760663)))) - num2 * -1740969899) ^ -1872101998) * 1667910173 * -1507247555 + -869750943 - 652202184)) % 36)
			{
			case 26u:
				break;
			case 3u:
				DAB02FE0B5C74E11((Error)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x3B1AE373 ^ obj._184044A093C04AF2(8, 3724357020u))));
				return (void*)(uint)_003CModule_003E._3F57E81A62734AC2<int>(-597313586 ^ (int)obj._184044A093C04AF2(0, 4090966775u));
			case 16u:
				num6 = (uint)_003CModule_003E._390073C602714496<int>((int)(0x35EA8FBF ^ obj._184044A093C04AF2(8, 3825961967u)));
				ptr4 = (uint*)(codeBase + ptr->AddressOfNames);
				ptr3 = (ushort*)(codeBase + ptr->AddressOfNameOrdinals);
				num = ((int)num3 * -1191658760) ^ 0x5EF863A5;
				continue;
			case 9u:
				goto IL_024f;
			case 13u:
			{
				dictionary = null;
				int num15;
				int num16;
				if (!(P_0->nameExportsTable == IntPtr.Zero))
				{
					num15 = 3877851;
					num16 = num15;
				}
				else
				{
					num15 = -1118954777;
					num16 = num15;
				}
				num = num15 ^ ((int)num3 * -810692045);
				continue;
			}
			case 10u:
				P_0->nameExportsTable = intPtr;
				num = (int)((num3 * 907952455) ^ 0x74113EF3);
				continue;
			case 19u:
				return (void*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x27B64A0 ^ obj._184044A093C04AF2(2, 1143355789u)));
			case 17u:
			{
				int num11;
				int num12;
				if (ptr->NumberOfFunctions == 0)
				{
					num11 = -2032009054;
					num12 = num11;
				}
				else
				{
					num11 = 307614404;
					num12 = num11;
				}
				num = num11 ^ (int)(num3 * 384897571);
				continue;
			}
			case 5u:
				DAB02FE0B5C74E11((Error)_003CModule_003E._390073C602714496<int>((int)(0x2E8D4625 ^ obj._184044A093C04AF2(1, 2065476759u))));
				return (void*)(uint)_003CModule_003E._390073C602714496<int>((int)(0x5AE36290 ^ obj._184044A093C04AF2(4, 1971177022u)));
			case 6u:
				obj._184044A093C04AF2(4, 2481449404u);
				num = ((int)num3 * -1825821013) ^ 0x10B699C2;
				continue;
			case 0u:
				obj._184044A093C04AF2(1, 2414204572u);
				num = ((int)num3 * -1162783935) ^ 0x59E6E9EA;
				continue;
			case 28u:
				obj._184044A093C04AF2(10, 3791244512u);
				num = ((int)num3 * -1515697720) ^ -716424797;
				continue;
			case 34u:
				obj._184044A093C04AF2(4, 2679446881u);
				obj._184044A093C04AF2(1, 171272708u);
				num = -1930960900;
				continue;
			case 11u:
				DAB02FE0B5C74E11((Error)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x21979912 ^ obj._184044A093C04AF2(10, 908543269u))));
				num = (int)((num3 * 1677486935) ^ 0x12B934A8);
				continue;
			case 35u:
				DAB02FE0B5C74E11((Error)_003CModule_003E._3F57E81A62734AC2<int>(-1945319813 ^ (int)obj._184044A093C04AF2(2, 1858054212u)));
				return (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x31A95AF8 ^ obj._184044A093C04AF2(5, 3089185937u)));
			case 25u:
				DAB02FE0B5C74E11((Error)_003CModule_003E._8B9C7B12B1AE4949<int>(-1072581708 ^ (int)obj._184044A093C04AF2(2, 2213429632u)));
				num = -1263817877;
				continue;
			case 30u:
			{
				ptr = (_IMAGE_EXPORT_DIRECTORY*)(codeBase + ptr2->VirtualAddress);
				int num13;
				int num14;
				if (ptr->NumberOfNames == 0)
				{
					num13 = 1410880539;
					num14 = num13;
				}
				else
				{
					num13 = 1501025971;
					num14 = num13;
				}
				num = num13 ^ ((int)num3 * -1469280781);
				continue;
			}
			case 14u:
				obj._184044A093C04AF2(0, 1106440857u);
				num = -668640707;
				continue;
			case 1u:
			{
				int num9;
				int num10;
				if (!(intPtr == IntPtr.Zero))
				{
					num9 = 230749124;
					num10 = num9;
				}
				else
				{
					num9 = -434498812;
					num10 = num9;
				}
				num = num9 ^ (int)(num3 * 1213832194);
				continue;
			}
			case 27u:
				goto IL_0506;
			case 4u:
			{
				int num7;
				int num8;
				if (A47632C5839C4501((UIntPtr)P_1) >= ptr->Base)
				{
					num7 = 551423884;
					num8 = num7;
				}
				else
				{
					num7 = 68832723;
					num8 = num7;
				}
				num = num7 ^ ((int)num3 * -1384410275);
				continue;
			}
			case 32u:
				obj._184044A093C04AF2(11, 2918295712u);
				dictionary = GCHandle.FromIntPtr(P_0->nameExportsTable).Target as Dictionary<string, uint>;
				num = (int)(num3 * 1902210730) ^ -210822766;
				continue;
			case 12u:
				goto IL_059d;
			case 24u:
				obj._184044A093C04AF2(4, 885943366u);
				obj._184044A093C04AF2(5, 4123694588u);
				obj._184044A093C04AF2(10, 3791244512u);
				num = 752270736;
				continue;
			case 7u:
				dictionary.Add(_9E97E44C26854DEE((IntPtr)(codeBase + *ptr4)), *ptr3);
				num6 += (uint)_003CModule_003E._390073C602714496<int>(-1014575718 ^ (int)obj._184044A093C04AF2(10, 2576102570u));
				ptr4 = (uint*)((byte*)ptr4 + _003CModule_003E._390073C602714496<int>((int)(0x70F44789 ^ obj._184044A093C04AF2(1, 149465119u))));
				num = -1348708378;
				continue;
			case 2u:
				DAB02FE0B5C74E11((Error)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x3CF590FE ^ obj._184044A093C04AF2(8, 2960017920u))));
				return (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-1415900328 ^ (int)obj._184044A093C04AF2(2, 477374371u));
			case 8u:
				DAB02FE0B5C74E11((Error)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x1FC1A9B3 ^ obj._184044A093C04AF2(0, 361092374u))));
				return (void*)(uint)_003CModule_003E._390073C602714496<int>((int)(0x5E4281FF ^ obj._184044A093C04AF2(8, 2116526348u)));
			case 22u:
				ptr3 = (ushort*)((byte*)ptr3 + _003CModule_003E._8B9C7B12B1AE4949<int>(-1767501770 ^ (int)obj._184044A093C04AF2(9, 4096342057u)));
				num = ((int)num3 * -328402989) ^ 0x51F7355;
				continue;
			case 23u:
				goto IL_070c;
			case 33u:
				return (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x2F8362EC ^ obj._184044A093C04AF2(9, 1332543002u)));
			case 21u:
				goto IL_0769;
			case 20u:
				obj._184044A093C04AF2(8, 1560732365u);
				value = A47632C5839C4501((UIntPtr)P_1) - ptr->Base;
				num = -849677067;
				continue;
			case 18u:
				obj._184044A093C04AF2(7, 2918295712u);
				obj._184044A093C04AF2(9, 1660329896u);
				obj._184044A093C04AF2(6, 2020997194u);
				num6 = (uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x61D1DF83 ^ obj._184044A093C04AF2(8, 3502630825u)));
				num = -1599929745;
				continue;
			case 31u:
			{
				obj._184044A093C04AF2(7, 1376671584u);
				int num4;
				int num5;
				if (dictionary.TryGetValue(_9E97E44C26854DEE((IntPtr)P_1), out value))
				{
					num4 = 172732494;
					num5 = num4;
				}
				else
				{
					num4 = -1110936286;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 370605037);
				continue;
			}
			case 29u:
				dictionary = new Dictionary<string, uint>();
				intPtr = GCHandle.ToIntPtr(GCHandle.Alloc(dictionary));
				num = (int)(num3 * 1417912173) ^ -2109576109;
				continue;
			default:
				return codeBase + (uint)(*(int*)(codeBase + ptr->AddressOfFunctions + (uint)((int)value * _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x6D3E758D ^ obj._184044A093C04AF2(2, 1351729116u))))));
			}
			break;
			IL_0769:
			obj._184044A093C04AF2(0, 2978600587u);
			int num17;
			if (value > ptr->NumberOfFunctions)
			{
				num = 1679135447;
				num17 = num;
			}
			else
			{
				num = 1795372559;
				num17 = num;
			}
			continue;
			IL_0506:
			obj = new _81DD83B8AA2247AA(2280397756u);
			int num18;
			if (num6 < ptr->NumberOfNames)
			{
				num = 706439419;
				num18 = num;
			}
			else
			{
				num = -315330612;
				num18 = num;
			}
			continue;
			IL_024f:
			obj._184044A093C04AF2(0, 610830543u);
			int num19;
			if (C9DC76F773CD4FDB(ptr->NumberOfNames))
			{
				num = 1302047426;
				num19 = num;
			}
			else
			{
				num = -1124526405;
				num19 = num;
			}
			continue;
			IL_070c:
			obj._184044A093C04AF2(8, 1440498416u);
			int num20;
			if (BCA2103C07414775((UIntPtr)P_1) == 0)
			{
				num = -444446594;
				num20 = num;
			}
			else
			{
				num = 1925592145;
				num20 = num;
			}
		}
		goto IL_0062;
		IL_059d:
		obj = new _81DD83B8AA2247AA(358282332u);
		num = -1556172374;
		goto IL_0067;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool FC0231B4473749A8(ulong P_0, ulong P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3184289513u);
		while (true)
		{
			int num = 1569797395;
			while (true)
			{
				int num2 = num;
				uint num3;
				int num4;
				switch ((num3 = (uint)((~(num2 * -414268707) * 1592884785 - ~-101964332) * -521567867 * -1827507631 + (630773434 - -1184580432) + -1933808756)) % 4)
				{
				case 2u:
					break;
				case 3u:
				{
					int num5;
					if (P_0 < P_1)
					{
						num4 = -764161963;
						num5 = num4;
					}
					else
					{
						num4 = 1535916498;
						num5 = num4;
					}
					goto IL_0072;
				}
				case 0u:
					DAB02FE0B5C74E11((Error)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x1009AA51 ^ obj._184044A093C04AF2(6, 1062358260u))));
					return (byte)_003CModule_003E._390073C602714496<int>(-326684054 ^ (int)obj._184044A093C04AF2(1, 949519257u)) != 0;
				default:
					return (byte)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x3750168D ^ obj._184044A093C04AF2(4, 3207815488u))) != 0;
				}
				break;
				IL_0072:
				num = num4 ^ ((int)num3 * -931915027);
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void _81DBF2D572F0454F(POINTER_LIST* P_0, void* P_1, void* P_2)
	{
		CustomFreeFunc delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer<CustomFreeFunc>((IntPtr)P_1);
		_1A57D4B8754D4F54(P_0, delegateForFunctionPointer, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _1A57D4B8754D4F54(POINTER_LIST* P_0, CustomFreeFunc P_1, void* P_2)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1675098033u);
		POINTER_LIST* ptr = P_0;
		while (true)
		{
			POINTER_LIST* ptr2 = ptr;
			obj._184044A093C04AF2(8, 3759701907u);
			obj._184044A093C04AF2(5, 2673508241u);
			obj._184044A093C04AF2(7, 2486563375u);
			int num;
			int num2;
			if (ptr2 == (POINTER_LIST*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>(-1444881833 ^ (int)obj._184044A093C04AF2(2, 117226707u)))
			{
				num = -236844809;
				num2 = num;
			}
			else
			{
				num = 932075793;
				num2 = num;
			}
			while (true)
			{
				int num3 = num;
				uint num4;
				switch ((num4 = (uint)(-(-(-1142870293 * 1689771033 - -(~unchecked(-56137113 * ~-1462399358)) - unchecked(-135006541 - (847936472 - unchecked(unchecked(-1704723055 * 1902895782) + (0x77440FE5 ^ 0x16954C6C))) + ~(-404243934 ^ -1864401334)) - (num3 - (-((-332583269 ^ -(833319594 + -218866525 - (-1394609648 ^ -1804821737))) - (0x2B3C3BA1 ^ (0x20F8FFDF ^ (-2061980353 ^ --1973812549)))) - ((-(-1119380115) ^ -728627263) * 1791512879 + unchecked(unchecked(701712275 * unchecked((-495409120 ^ 0x402AED8E) + ~(447996023 + 1421451315))) - (714372694 + (unchecked((-277717799 ^ 0x7887475B) - unchecked(-1659313089 * -107744381)) - (0x3696F138 ^ 0x3FA7C61B)))))))) + ~((-2042625687 ^ -1315976192) + ~642472002 + -725407519) + (unchecked(619471995 * -1720613385) - --474465962 + (0x1B6D149F ^ -1825659076))))) % 6)
				{
				case 0u:
					num = 932075793;
					continue;
				case 1u:
					obj = new _81DD83B8AA2247AA(3406887170u);
					num = 880691057;
					continue;
				case 5u:
				{
					void* address = ptr->address;
					UIntPtr size = (UIntPtr)(ulong)_003CModule_003E._8B9C7B12B1AE4949<int>(-857102664 ^ (int)obj._184044A093C04AF2(5, 738071027u));
					obj._184044A093C04AF2(2, 117226707u);
					obj._184044A093C04AF2(1, 883388028u);
					obj._184044A093C04AF2(4, 3759701907u);
					P_1(address, size, (MemoryAllocation)_003CModule_003E._390073C602714496<int>((int)(0x4FDB16AC ^ obj._184044A093C04AF2(3, 1808403921u))), P_2);
					num = ((int)num4 * -1663439121) ^ -1976841047;
					continue;
				}
				case 2u:
				{
					POINTER_LIST* next = ptr->next;
					_57D606BE468B48CD((void*)ptr);
					ptr = next;
					num = ((int)num4 * -1876873772) ^ -1069320910;
					continue;
				}
				case 4u:
					break;
				default:
					obj = new _81DD83B8AA2247AA(3576879917u);
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static _IMAGE_SECTION_HEADER* B823ADB6032F4C5B(UIntPtr P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(455073997u);
		return (_IMAGE_SECTION_HEADER*)(void*)UIntPtr.Add(UIntPtr.Add(P_0, _8D02A2DF6954498F((Type)_075306E5B9FB4985(typeof(_IMAGE_NT_HEADERS).TypeHandle), _003CModule_003E._58ECCB512F2A43AC<string>(-910989469 ^ (int)obj._184044A093C04AF2(4, 1588317377u))).ToInt32()), ((_IMAGE_NT_HEADERS*)(void*)P_0)->FileHeader.SizeOfOptionalHeader);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static _IMAGE_DATA_DIRECTORY* _3BD68850EE9E41E3(_MEMORYMODULE* P_0, ImageDirectoryEntry P_1)
	{
		return (_IMAGE_DATA_DIRECTORY*)((byte*)(&P_0->headers->OptionalHeader.DataDirectory) + (nint)P_1 * (nint)sizeof(_IMAGE_DATA_DIRECTORY));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool EE4BD34D196E4ED9(ulong P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1708288323u);
		return (P_0 & (ulong)_003CModule_003E.F84FA79ABE6944BB<long>((int)(0x511C58FD ^ obj._184044A093C04AF2(9, 3928262380u)))) > (ulong)_003CModule_003E._8B9C7B12B1AE4949<int>(-612550482 ^ (int)obj._184044A093C04AF2(9, 294165037u));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool E25333CEEC8F4DAA(ulong P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1886070323u);
		return (P_0 & (uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-36564618 ^ (int)obj._184044A093C04AF2(6, 1088212831u))) > (ulong)_003CModule_003E._58ECCB512F2A43AC<int>(-1976520592 ^ (int)obj._184044A093C04AF2(9, 948584919u));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static bool F212A3A51C904C21(UIntPtr P_0)
	{
		if (_0C38845A5DED4296())
		{
			while (true)
			{
				int num = 684891073;
				uint num2;
				switch ((num2 = (uint)((~(~(~(num * -2057267359)) * 649795967) - unchecked(1507760481 * unchecked(1783260744 * 1750955289))) * -2142797547 - 2017285671)) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return EE4BD34D196E4ED9(P_0.ToUInt64());
				}
				break;
			}
		}
		return E25333CEEC8F4DAA(P_0.ToUInt32());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ulong E7220CAD9E7F4C24(ulong P_0)
	{
		return P_0 & (ulong)_003CModule_003E._3F57E81A62734AC2<int>(-568795395 ^ (int)new _81DD83B8AA2247AA(3605381395u)._184044A093C04AF2(6, 3298982004u));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static uint C8ED8F05AE8D428D(uint P_0)
	{
		return P_0 & (uint)_003CModule_003E._3F57E81A62734AC2<int>(-1112902661 ^ (int)new _81DD83B8AA2247AA(1173403541u)._184044A093C04AF2(6, 1153078884u));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private static UIntPtr _7E69103FEF144B12(UIntPtr P_0)
	{
		if (_0C38845A5DED4296())
		{
			while (true)
			{
				int num = 407359420;
				uint num2;
				switch ((num2 = (uint)(1901055977 * -(-1745995189) - ~(-((num - (unchecked(unchecked((-665705701 ^ 0x3BF06EF) * -1817906409) * 1638449677) - -177970733 - -(-(-(554970071 * (--354735931 + -1581725746)))))) ^ (-(-(-(-unchecked(471154335 * 2085116283)))) ^ ~(-(0x57248F35 ^ -2075077292) * 1033735387)))) - (-256908610 ^ -430868184))) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return (UIntPtr)E7220CAD9E7F4C24(P_0.ToUInt64());
				}
				break;
			}
		}
		return (UIntPtr)C8ED8F05AE8D428D(P_0.ToUInt32());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ushort BCA2103C07414775(UIntPtr P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3069568736u);
		return (ushort)(((ulong)P_0 >> _003CModule_003E._58ECCB512F2A43AC<int>(-540876321 ^ (int)obj._184044A093C04AF2(10, 160380651u))) & (ulong)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x3C1745F2 ^ obj._184044A093C04AF2(10, 708135133u))));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ushort A47632C5839C4501(UIntPtr P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1679863184u);
		return (ushort)((ulong)P_0 & (ulong)_003CModule_003E._3F57E81A62734AC2<int>(-59510259 ^ (int)obj._184044A093C04AF2(10, 2518121651u)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ulong B4EE046A2F6747DA(ulong P_0, ulong P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1186922590u);
		return (ulong)(((long)(P_0 + P_1) - (long)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x3C6D048B ^ obj._184044A093C04AF2(0, 1900426834u)))) & ~((long)P_1 - (long)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x51C17F2D ^ obj._184044A093C04AF2(0, 1794574426u)))));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void* D1F7E7FC317C41C1(void* P_0, int P_1)
	{
		return (byte*)P_0 + P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static UIntPtr _3ED16AD98EC34F11(UIntPtr P_0, UIntPtr P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2528598618u);
		return (UIntPtr)(P_0.ToUInt64() & (ulong)(~((long)P_1.ToUInt64() - (long)_003CModule_003E._58ECCB512F2A43AC<int>(-1746503391 ^ (int)obj._184044A093C04AF2(9, 1554459584u)))));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void* A82264EB07AC4A21(void* P_0, UIntPtr P_1)
	{
		return (void*)_3ED16AD98EC34F11((UIntPtr)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static bool _52CAEAC208774684(byte* P_0, ulong P_1, _IMAGE_NT_HEADERS* P_2, _MEMORYMODULE* P_3)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(500203765u);
		byte* ptr = default;
		MEMORYMODULE mEMORYMODULE = default;
		byte* codeBase = default;
		_IMAGE_SECTION_HEADER* ptr2 = default;
		int num5 = default;
		int num4 = default;
		while (true)
		{
			int num = 1077182718;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(-num2)) * -2022532007)) % 19)
				{
				case 11u:
					break;
				case 8u:
				{
					ptr = (byte*)mEMORYMODULE.alloc(codeBase + ptr2->VirtualAddress, (UIntPtr)ptr2->SizeOfRawData, (MemoryAllocation)_003CModule_003E._390073C602714496<int>((int)(0x41668FCA ^ obj._184044A093C04AF2(2, 3312595501u))), (PageProtection)_003CModule_003E._58ECCB512F2A43AC<int>(-763713326 ^ (int)obj._184044A093C04AF2(5, 2991660584u)), mEMORYMODULE.userdata);
					int num13;
					if (ptr == (byte*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x1F1C99CD ^ obj._184044A093C04AF2(1, 1474150668u))))
					{
						num = -145953167;
						num13 = num;
					}
					else
					{
						num = -256069302;
						num13 = num;
					}
					continue;
				}
				case 3u:
				{
					obj = new _81DD83B8AA2247AA(3836218879u);
					int num10;
					if (num4 >= mEMORYMODULE.headers->FileHeader.NumberOfSections)
					{
						num = 412713931;
						num10 = num;
					}
					else
					{
						num = -782441030;
						num10 = num;
					}
					continue;
				}
				case 18u:
					obj = new _81DD83B8AA2247AA(1928224768u);
					num = 2061270654;
					continue;
				case 13u:
				{
					_9E65D1B026A2487E((void*)ptr, (void*)(P_0 + ptr2->PointerToRawData), ptr2->SizeOfRawData);
					__anontype_1639d593_0036* misc = &ptr2->Misc;
					ulong num17 = ((UIntPtr)ptr).ToUInt64();
					obj._184044A093C04AF2(7, 603221649u);
					obj._184044A093C04AF2(10, 2466162355u);
					obj._184044A093C04AF2(5, 2514481275u);
					misc->PhysicalAddress = (uint)(num17 & (uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0xD850D6F ^ obj._184044A093C04AF2(8, 4024608975u))));
					num = ((int)num3 * -1451628522) ^ -360798117;
					continue;
				}
				case 4u:
					return (byte)_003CModule_003E.F84FA79ABE6944BB<int>(-911176934 ^ (int)obj._184044A093C04AF2(0, 1563913743u)) != 0;
				case 16u:
					num5 = (int)P_2->OptionalHeader.SectionAlignment;
					num = ((int)num3 * -2070331336) ^ 0x47266A33;
					continue;
				case 17u:
					obj = new _81DD83B8AA2247AA(2212912623u);
					num4 += _003CModule_003E._8B9C7B12B1AE4949<int>(-1970743749 ^ (int)obj._184044A093C04AF2(6, 1157320157u));
					ptr2++;
					num = 855572338;
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (ptr2->SizeOfRawData == 0)
					{
						num8 = -1072728008;
						num9 = num8;
					}
					else
					{
						num8 = -2123099402;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -1725346766);
					continue;
				}
				case 10u:
					obj._184044A093C04AF2(6, 693233169u);
					num = 1614698511;
					continue;
				case 6u:
				{
					int num14 = num5;
					obj._184044A093C04AF2(8, 4024608975u);
					obj._184044A093C04AF2(7, 603221649u);
					obj._184044A093C04AF2(9, 2685325231u);
					int num15;
					int num16;
					if (num14 <= _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x3D3DBFB3 ^ obj._184044A093C04AF2(2, 2128441999u))))
					{
						num15 = -716238057;
						num16 = num15;
					}
					else
					{
						num15 = -1316359022;
						num16 = num15;
					}
					num = num15 ^ (int)(num3 * 656027580);
					continue;
				}
				case 7u:
				{
					ptr = (byte*)mEMORYMODULE.alloc(codeBase + ptr2->VirtualAddress, (UIntPtr)(ulong)num5, (MemoryAllocation)_003CModule_003E._3F57E81A62734AC2<int>(-430772498 ^ (int)obj._184044A093C04AF2(6, 3390112784u)), (PageProtection)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0xEBEC0AC ^ obj._184044A093C04AF2(8, 1305183475u))), mEMORYMODULE.userdata);
					int num11;
					int num12;
					if (ptr != (byte*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-1439109294 ^ (int)obj._184044A093C04AF2(9, 4243290670u)))
					{
						num11 = -1187765500;
						num12 = num11;
					}
					else
					{
						num11 = 1935551680;
						num12 = num11;
					}
					num = num11 ^ ((int)num3 * -770937738);
					continue;
				}
				case 1u:
				{
					int num6;
					int num7;
					if (FC0231B4473749A8(P_1, ptr2->PointerToRawData + ptr2->SizeOfRawData))
					{
						num6 = -473718716;
						num7 = num6;
					}
					else
					{
						num6 = 37548404;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -1181901042);
					continue;
				}
				case 12u:
					return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-793524487 ^ (int)obj._184044A093C04AF2(4, 912712522u)) != 0;
				case 0u:
				{
					ptr = codeBase + ptr2->VirtualAddress;
					ptr2->Misc.PhysicalAddress = (uint)(((UIntPtr)ptr).ToUInt64() & (uint)_003CModule_003E._390073C602714496<int>(-1310662404 ^ (int)obj._184044A093C04AF2(1, 1744018333u)));
					byte* ptr3 = ptr;
					obj._184044A093C04AF2(9, 2602625589u);
					obj._184044A093C04AF2(4, 1305183475u);
					C556D3BF617444F5((void*)ptr3, _003CModule_003E._390073C602714496<int>((int)(0x572BE5AC ^ obj._184044A093C04AF2(2, 3390112784u))), (uint)num5);
					num = 677538619;
					continue;
				}
				case 14u:
					return (byte)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x67FB61E3 ^ obj._184044A093C04AF2(8, 500716378u))) != 0;
				case 9u:
					num4 = _003CModule_003E._3F57E81A62734AC2<int>((int)(0x4451E493 ^ obj._184044A093C04AF2(9, 2282622561u)));
					num5 = _003CModule_003E._58ECCB512F2A43AC<int>(-1179489815 ^ (int)obj._184044A093C04AF2(2, 2461555857u));
					mEMORYMODULE = (MEMORYMODULE)_89FA370153C24543(P_3);
					codeBase = mEMORYMODULE.codeBase;
					ptr2 = B823ADB6032F4C5B((UIntPtr)mEMORYMODULE.headers);
					obj._184044A093C04AF2(7, 3494804998u);
					obj._184044A093C04AF2(6, 3195573782u);
					obj._184044A093C04AF2(9, 3500724505u);
					num4 = _003CModule_003E._58ECCB512F2A43AC<int>(-1957668653 ^ (int)obj._184044A093C04AF2(4, 2224019034u));
					num = (int)(num3 * 10176127) ^ -1041835460;
					continue;
				case 15u:
					ptr = codeBase + ptr2->VirtualAddress;
					num = -1034123664;
					continue;
				default:
					return (byte)_003CModule_003E._390073C602714496<int>((int)(0x11583DD3 ^ obj._184044A093C04AF2(2, 2583109854u))) != 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static bool _2F2FBEDE1C2F4057(_MEMORYMODULE* P_0, long P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2224225293u);
		byte* codeBase = P_0->codeBase;
		_IMAGE_BASE_RELOCATION* ptr = default;
		int num4 = default;
		ImageRelocation imageRelocation = default;
		long* ptr4 = default;
		byte* ptr3 = default;
		int num9 = default;
		ushort* ptr2 = default;
		uint num6 = default;
		_IMAGE_DATA_DIRECTORY* ptr5 = default;
		while (true)
		{
			int num = 1963526852;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((555620971 - (num2 * -1787576053 * 738465983 - (0x278A65DD ^ (-691538707 * -(452538573 - 1309329940))))) * 1342361271)) % 36)
				{
				case 26u:
					break;
				case 6u:
					obj._184044A093C04AF2(11, 4183360045u);
					obj._184044A093C04AF2(6, 2637990647u);
					obj._184044A093C04AF2(1, 1920826131u);
					DCED07FB8FF34198(AD0FFC72C1AA4E6F(_003CModule_003E._58ECCB512F2A43AC<string>((int)(0x6E774DC8 ^ obj._184044A093C04AF2(4, 1761653943u))), (object)(ImageRelocation)num4));
					num = 1176751094;
					continue;
				case 0u:
				{
					int num12;
					int num13;
					if (imageRelocation != ImageRelocation.BasedAbsolute)
					{
						num12 = 205785998;
						num13 = num12;
					}
					else
					{
						num12 = 2004699638;
						num13 = num12;
					}
					num = num12 ^ ((int)num3 * -1440300080);
					continue;
				}
				case 33u:
					obj._184044A093C04AF2(128, 2448896557u);
					num = (int)(num3 * 1434899644) ^ -1353218627;
					continue;
				case 24u:
					num = (int)((num3 * 1687153156) ^ 0x6AF43404);
					continue;
				case 10u:
					return P_1 == _003CModule_003E._8B9C7B12B1AE4949<int>(-923398317 ^ (int)new _81DD83B8AA2247AA(3138264003u)._184044A093C04AF2(5, 550128667u));
				case 11u:
				{
					int num14;
					int num15;
					if (imageRelocation != (ImageRelocation)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x427262B3 ^ obj._184044A093C04AF2(9, 2161193429u))))
					{
						num14 = -2078021017;
						num15 = num14;
					}
					else
					{
						num14 = 1401988250;
						num15 = num14;
					}
					num = num14 ^ (int)(num3 * 1690378859);
					continue;
				}
				case 25u:
					num = ((int)num3 * -480622717) ^ -105092375;
					continue;
				case 4u:
					obj._184044A093C04AF2(3, 3582726888u);
					ptr4 = (long*)(ptr3 + num9);
					num = (int)((num3 * 2142259421) ^ 0x17BE03E4);
					continue;
				case 16u:
					obj._184044A093C04AF2(134, 314408813u);
					num = ((int)num3 * -2099747103) ^ 0x5B290119;
					continue;
				case 3u:
					obj._184044A093C04AF2(0, 3850343448u);
					obj._184044A093C04AF2(1, 949958424u);
					obj._184044A093C04AF2(10, 1785306648u);
					DCED07FB8FF34198(_003CModule_003E._3F57E81A62734AC2<string>((int)(0x289A4765 ^ obj._184044A093C04AF2(3, 3582726888u))));
					num = 1176751094;
					continue;
				case 30u:
					ptr3 = codeBase + ptr->VirtualAddress;
					ptr2 = (ushort*)D1F7E7FC317C41C1(ptr, _003CModule_003E._3F57E81A62734AC2<int>((int)(0x5F67B3EB ^ obj._184044A093C04AF2(6, 311011598u))));
					obj._184044A093C04AF2(2, 4172624721u);
					obj._184044A093C04AF2(9, 1274044822u);
					obj._184044A093C04AF2(4, 1253957450u);
					num6 = (uint)_003CModule_003E.F84FA79ABE6944BB<int>(-212810686 ^ (int)obj._184044A093C04AF2(11, 1169024634u));
					num = ((int)num3 * -2009292013) ^ -762455853;
					continue;
				case 32u:
					ptr2 = (ushort*)((byte*)ptr2 + _003CModule_003E._8B9C7B12B1AE4949<int>(-199588339 ^ (int)obj._184044A093C04AF2(6, 2101829866u)));
					num = (int)((num3 * 2079091188) ^ 0x4D05EEA4);
					continue;
				case 20u:
					obj._184044A093C04AF2(131, 3129365517u);
					num = ((int)num3 * -441273858) ^ 0x241ED1DC;
					continue;
				case 21u:
				{
					int num17;
					int num18;
					if (ptr5->Size == 0)
					{
						num17 = 2139314385;
						num18 = num17;
					}
					else
					{
						num17 = -143482791;
						num18 = num17;
					}
					num = num17 ^ (int)(num3 * 540878974);
					continue;
				}
				case 7u:
					*ptr4 += P_1;
					num = (int)((num3 * 307870219) ^ 0x1AC991B7);
					continue;
				case 15u:
					num = ((int)num3 * -1244624592) ^ 0x76057AFE;
					continue;
				case 34u:
				{
					obj = new _81DD83B8AA2247AA(418459101u);
					uint* ptr6 = (uint*)(ptr3 + num9);
					*ptr6 += (uint)(int)P_1;
					num = 172219046;
					continue;
				}
				case 2u:
					obj = new _81DD83B8AA2247AA(2352265613u);
					ptr = (_IMAGE_BASE_RELOCATION*)(codeBase + ptr5->VirtualAddress);
					num = 984647108;
					continue;
				case 35u:
					num = ((int)num3 * -2096042305) ^ -2061673638;
					continue;
				case 1u:
					num6 = (uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0xDC1884B ^ obj._184044A093C04AF2(2, 3371772415u)));
					num = -224619841;
					continue;
				case 9u:
					num6 += (uint)_003CModule_003E._390073C602714496<int>(-1552697487 ^ (int)obj._184044A093C04AF2(1, 3261433232u));
					num = 614128597;
					continue;
				case 13u:
				{
					ushort num16 = *ptr2;
					obj._184044A093C04AF2(9, 3615510903u);
					obj._184044A093C04AF2(10, 2883871731u);
					num9 = num16 & _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x2BFD838D ^ obj._184044A093C04AF2(8, 3949821995u)));
					imageRelocation = (ImageRelocation)num4;
					num = ((int)num3 * -1981025020) ^ -1315678807;
					continue;
				}
				case 27u:
					obj._184044A093C04AF2(0, 3784669582u);
					obj._184044A093C04AF2(7, 1466527050u);
					obj._184044A093C04AF2(10, 2037895694u);
					ptr5 = _3BD68850EE9E41E3(P_0, (ImageDirectoryEntry)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x5847CC4D ^ obj._184044A093C04AF2(1, 397945142u))));
					num = ((int)num3 * -2096727047) ^ -1640142571;
					continue;
				case 8u:
					obj._184044A093C04AF2(129, 656842445u);
					num = (int)((num3 * 1242045446) ^ 0x5E6EAAF1);
					continue;
				case 5u:
				{
					int num10;
					int num11;
					if (imageRelocation == (ImageRelocation)_003CModule_003E._390073C602714496<int>((int)(0x2C555E10 ^ obj._184044A093C04AF2(5, 732422803u))))
					{
						num10 = 1252357979;
						num11 = num10;
					}
					else
					{
						num10 = -1063616576;
						num11 = num10;
					}
					num = num10 ^ (int)(num3 * 395479884);
					continue;
				}
				case 14u:
				{
					obj = new _81DD83B8AA2247AA(2940021957u);
					int num8;
					if (_0C38845A5DED4296())
					{
						num = 554840129;
						num8 = num;
					}
					else
					{
						num = 1159227656;
						num8 = num;
					}
					continue;
				}
				case 19u:
				{
					int num7;
					if (num6 >= (uint)((int)ptr->SizeOfBlock - _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x11430277 ^ obj._184044A093C04AF2(4, 3949821995u)))) / (uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-763098898 ^ (int)obj._184044A093C04AF2(10, 3601007385u)))
					{
						num = 1467520166;
						num7 = num;
					}
					else
					{
						num = 1460106419;
						num7 = num;
					}
					continue;
				}
				case 18u:
					obj._184044A093C04AF2(2, 1785306648u);
					num = ((int)num3 * -173638235) ^ -741356929;
					continue;
				case 31u:
					obj = new _81DD83B8AA2247AA(525283159u);
					num = ((int)num3 * -33272293) ^ 0x7B3E99B0;
					continue;
				case 17u:
				{
					uint virtualAddress = ptr->VirtualAddress;
					obj._184044A093C04AF2(3, 3719314742u);
					obj._184044A093C04AF2(5, 3709455434u);
					obj._184044A093C04AF2(4, 2301873434u);
					int num5;
					if (virtualAddress <= (uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x571DEE02 ^ obj._184044A093C04AF2(6, 2423623066u))))
					{
						num = 1213120608;
						num5 = num;
					}
					else
					{
						num = 505621942;
						num5 = num;
					}
					continue;
				}
				case 29u:
					obj = new _81DD83B8AA2247AA(1074595210u);
					num = (int)(num3 * 838275352) ^ -1419184172;
					continue;
				case 23u:
					ptr = (_IMAGE_BASE_RELOCATION*)D1F7E7FC317C41C1(ptr, (int)ptr->SizeOfBlock);
					num = (int)((num3 * 2053298530) ^ 0x1D128588);
					continue;
				case 12u:
					obj._184044A093C04AF2(8, 3850343448u);
					obj._184044A093C04AF2(1, 949958424u);
					num = (int)(num3 * 1733971793) ^ -1364829933;
					continue;
				case 22u:
					num4 = *ptr2 >> _003CModule_003E._58ECCB512F2A43AC<int>(-506351340 ^ (int)obj._184044A093C04AF2(5, 1712990457u));
					num = 523889754;
					continue;
				default:
					return (byte)_003CModule_003E.F84FA79ABE6944BB<int>(-1098481857 ^ (int)obj._184044A093C04AF2(10, 1535221868u)) != 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static bool _35DC0C54BA534CB5(_MEMORYMODULE* P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2028953378u);
		UIntPtr* ptr = default;
		byte* codeBase = default;
		_IMAGE_IMPORT_DESCRIPTOR* ptr4 = default;
		void** ptr2 = default;
		void** ptr3 = default;
		bool flag = default;
		_IMAGE_DATA_DIRECTORY* ptr7 = default;
		MEMORYMODULE mEMORYMODULE = default;
		void* ptr6 = default;
		char* ptr8 = default;
		while (true)
		{
			int num = -1131346071;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~(~num2)) - (-223898145 + unchecked((565682053 + -365935508 - unchecked(-491476546 - 1803287099)) * 1863728243)))) % 42)
				{
				case 12u:
					break;
				case 39u:
					obj._184044A093C04AF2(129, 3252451246u);
					obj._184044A093C04AF2(138, 4076222318u);
					obj._184044A093C04AF2(139, 1010773806u);
					ptr = (UIntPtr*)(codeBase + ptr4->FirstThunk);
					ptr2 = (void**)(codeBase + ptr4->FirstThunk);
					num = ((int)num3 * -448586247) ^ -1041627909;
					continue;
				case 14u:
					obj._184044A093C04AF2(132, 3645042670u);
					num = -357560974;
					continue;
				case 5u:
					ptr4++;
					num = ((int)num3 * -1912917729) ^ 0x2976B069;
					continue;
				case 3u:
					return (byte)_003CModule_003E._390073C602714496<int>(-807602117 ^ (int)obj._184044A093C04AF2(0, 3506490256u)) != 0;
				case 16u:
				{
					ptr3 = (void**)_97F696E1D53D4E1E((void*)P_0->modules, (uint)((P_0->numModules + _003CModule_003E._8B9C7B12B1AE4949<int>(-1288148824 ^ (int)obj._184044A093C04AF2(1, 3564760604u))) * sizeof(void*)));
					int num14;
					int num15;
					if (ptr3 == (void**)(uint)_003CModule_003E._390073C602714496<int>(-654918561 ^ (int)obj._184044A093C04AF2(1, 1182906002u)))
					{
						num14 = -1068627246;
						num15 = num14;
					}
					else
					{
						num14 = -1642048376;
						num15 = num14;
					}
					num = num14 ^ (int)(num3 * 1677360255);
					continue;
				}
				case 6u:
					obj._184044A093C04AF2(5, 3644776845u);
					num = -971531478;
					continue;
				case 0u:
				{
					int num18;
					int num19;
					if (ptr4->OriginalFirstThunk == 0)
					{
						num18 = -1075623543;
						num19 = num18;
					}
					else
					{
						num18 = -32939513;
						num19 = num18;
					}
					num = num18 ^ ((int)num3 * -1847946640);
					continue;
				}
				case 32u:
				{
					codeBase = P_0->codeBase;
					ptr4 = default;
					flag = (byte)_003CModule_003E._390073C602714496<int>((int)(0xD07EAD5 ^ obj._184044A093C04AF2(5, 2481390135u))) != 0;
					ptr7 = _3BD68850EE9E41E3(P_0, (ImageDirectoryEntry)_003CModule_003E._58ECCB512F2A43AC<int>(-940254494 ^ (int)obj._184044A093C04AF2(4, 900222405u)));
					int num12;
					int num13;
					if (ptr7->Size != 0)
					{
						num12 = -1402519393;
						num13 = num12;
					}
					else
					{
						num12 = -1849588362;
						num13 = num12;
					}
					num = num12 ^ (int)(num3 * 1871551727);
					continue;
				}
				case 1u:
					obj._184044A093C04AF2(6, 1519065155u);
					num = ((int)num3 * -723675084) ^ 0x313A056C;
					continue;
				case 2u:
					mEMORYMODULE = (MEMORYMODULE)_89FA370153C24543(P_0);
					num = ((int)num3 * -178034756) ^ 0x8ABB259;
					continue;
				case 26u:
				{
					obj._184044A093C04AF2(1, 26198758u);
					int num8;
					if (!flag)
					{
						num = -1640033037;
						num8 = num;
					}
					else
					{
						num = -212606074;
						num8 = num;
					}
					continue;
				}
				case 25u:
					ptr4 = (_IMAGE_IMPORT_DESCRIPTOR*)(codeBase + ptr7->VirtualAddress);
					num = ((int)num3 * -155645214) ^ 0x6E4AD956;
					continue;
				case 18u:
					obj = new _81DD83B8AA2247AA(3623542335u);
					num = -1275980066;
					continue;
				case 21u:
					*ptr2 = mEMORYMODULE.getProcAddress(ptr6, (char*)(void*)_7E69103FEF144B12(*ptr), P_0->userdata);
					num = (int)(num3 * 287258994) ^ -1102996588;
					continue;
				case 28u:
					obj._184044A093C04AF2(136, 3645042670u);
					num = -1987626148;
					continue;
				case 36u:
					obj._184044A093C04AF2(7, 1677695485u);
					obj._184044A093C04AF2(5, 64848967u);
					obj._184044A093C04AF2(8, 392024611u);
					flag = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(-678599987 ^ (int)obj._184044A093C04AF2(6, 381019482u)) != 0;
					num = ((int)num3 * -450298364) ^ -1424925931;
					continue;
				case 41u:
				{
					obj._184044A093C04AF2(2, 1519065155u);
					_IMAGE_IMPORT_BY_NAME* ptr9 = (_IMAGE_IMPORT_BY_NAME*)(codeBase + ptr->ToUInt64());
					*ptr2 = mEMORYMODULE.getProcAddress(ptr6, (char*)ptr9->Name, P_0->userdata);
					num = -194935622;
					continue;
				}
				case 17u:
				{
					P_0->modules = ptr3;
					void** modules = P_0->modules;
					int* numModules = &P_0->numModules;
					int num20 = *numModules;
					*numModules = num20 + _003CModule_003E._390073C602714496<int>((int)(0x6792D3CF ^ obj._184044A093C04AF2(5, 3622679385u)));
					modules[num20] = ptr6;
					num = 2139690249;
					continue;
				}
				case 35u:
					DAB02FE0B5C74E11((Error)_003CModule_003E._8B9C7B12B1AE4949<int>(-928603320 ^ (int)obj._184044A093C04AF2(6, 1866964409u)));
					num = (int)(num3 * 1805229321) ^ -20670004;
					continue;
				case 37u:
					mEMORYMODULE.freeLibrary(ptr6, P_0->userdata);
					num = (int)((num3 * 1855207426) ^ 0x7AD2E1AE);
					continue;
				case 11u:
				{
					obj._184044A093C04AF2(1, 3216716210u);
					int num17;
					if (!A915C5148862457B(D603CA34E20A4805(ptr4, (uint)sizeof(_IMAGE_IMPORT_DESCRIPTOR))))
					{
						num = -2035133873;
						num17 = num;
					}
					else
					{
						num = -1073531259;
						num17 = num;
					}
					continue;
				}
				case 15u:
					obj._184044A093C04AF2(133, 3252451246u);
					obj._184044A093C04AF2(130, 4076222318u);
					obj._184044A093C04AF2(131, 1010773806u);
					num = ((int)num3 * -189136693) ^ -736903522;
					continue;
				case 22u:
				{
					obj = new _81DD83B8AA2247AA(1332684593u);
					int num16;
					if (!F212A3A51C904C21(*ptr))
					{
						num = -1236242118;
						num16 = num;
					}
					else
					{
						num = -1408165550;
						num16 = num;
					}
					continue;
				}
				case 23u:
					obj._184044A093C04AF2(0, 305317011u);
					obj._184044A093C04AF2(3, 2751952003u);
					obj._184044A093C04AF2(10, 937087420u);
					flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x2A30CEA3 ^ obj._184044A093C04AF2(9, 2735111114u))) != 0;
					num = (int)((num3 * 1152968925) ^ 0x68893323);
					continue;
				case 27u:
					num = (int)((num3 * 29636026) ^ 0x2D4D3243);
					continue;
				case 4u:
					obj = new _81DD83B8AA2247AA(3495600174u);
					ptr = (UIntPtr*)(codeBase + ptr4->OriginalFirstThunk);
					num = ((int)num3 * -462451083) ^ -633077253;
					continue;
				case 9u:
					obj._184044A093C04AF2(0, 1778035953u);
					obj._184044A093C04AF2(5, 1713489886u);
					obj._184044A093C04AF2(2, 3500308401u);
					obj._184044A093C04AF2(3, 317019503u);
					num = -121702908;
					continue;
				case 20u:
					mEMORYMODULE.freeLibrary(ptr6, P_0->userdata);
					obj._184044A093C04AF2(8, 1778035953u);
					obj._184044A093C04AF2(5, 635238800u);
					obj._184044A093C04AF2(10, 3500308401u);
					DAB02FE0B5C74E11((Error)_003CModule_003E._3F57E81A62734AC2<int>(-302957068 ^ (int)obj._184044A093C04AF2(3, 317019503u)));
					num = ((int)num3 * -1010423272) ^ 0x533514E5;
					continue;
				case 33u:
					num = (int)(num3 * 1609857247) ^ -2028342620;
					continue;
				case 34u:
					obj = new _81DD83B8AA2247AA(243017148u);
					num = -280141535;
					continue;
				case 29u:
				{
					int num10;
					int num11;
					if (*ptr != UIntPtr.Zero)
					{
						num10 = 1840572899;
						num11 = num10;
					}
					else
					{
						num10 = -367424957;
						num11 = num10;
					}
					num = num10 ^ ((int)num3 * -1514184458);
					continue;
				}
				case 13u:
					ptr8 = (char*)(codeBase + ptr4->Name);
					ptr6 = mEMORYMODULE.loadLibrary(ptr8, P_0->userdata);
					num = (int)((num3 * 2062077933) ^ 0x459BC236);
					continue;
				case 7u:
				{
					int num9;
					if (*ptr2 == (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>(-1741836696 ^ (int)obj._184044A093C04AF2(0, 2136009516u)))
					{
						num = -2033276772;
						num9 = num;
					}
					else
					{
						num = -581979279;
						num9 = num;
					}
					continue;
				}
				case 19u:
					ptr2++;
					num = (int)((num3 * 590154416) ^ 0x3A046F35);
					continue;
				case 8u:
					ptr++;
					num = ((int)num3 * -372362379) ^ 0x763AA274;
					continue;
				case 31u:
					throw D2EC82C712AA417F(_515E3A2631534EA4(_003CModule_003E._3F57E81A62734AC2<string>(-1037794000 ^ (int)obj._184044A093C04AF2(9, 167442960u)), _9E97E44C26854DEE((IntPtr)ptr8)));
				case 10u:
				{
					int num6;
					int num7;
					if (ptr4->Name != 0)
					{
						num6 = 350392839;
						num7 = num6;
					}
					else
					{
						num6 = 1882689101;
						num7 = num6;
					}
					num = num6 ^ (int)(num3 * 1015152637);
					continue;
				}
				case 40u:
				{
					void* ptr5 = ptr6;
					obj._184044A093C04AF2(8, 392024611u);
					obj._184044A093C04AF2(10, 2045933795u);
					obj._184044A093C04AF2(7, 2617271811u);
					int num4;
					int num5;
					if (ptr5 != (void*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>(-1293883840 ^ (int)obj._184044A093C04AF2(1, 3777419019u)))
					{
						num4 = -603719849;
						num5 = num4;
					}
					else
					{
						num4 = -1847906228;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 994628905);
					continue;
				}
				case 30u:
					ptr2 = (void**)(codeBase + ptr4->FirstThunk);
					num = (int)(num3 * 1862660216) ^ -794401307;
					continue;
				case 24u:
					ptr = default;
					ptr2 = default;
					ptr3 = default;
					num = -2004555776;
					continue;
				default:
					obj._184044A093C04AF2(8, 3970551427u);
					return flag;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static UIntPtr D91EAC52DFF2430B(_MEMORYMODULE* P_0, _IMAGE_SECTION_HEADER* P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(623110334u);
		uint num4 = default;
		while (true)
		{
			int num = -1178278763;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((~(--13625487) - ((num2 * -628590083 + (unchecked((1334842163 + unchecked(1601639511 * unchecked(unchecked(1222784111 * -183845328) * 1805204451))) * 1977796257) - (~((0x1626245C ^ -364232726) - unchecked(-1893276265 + -1217838280)) - -unchecked((0x38E16BC6 ^ 0x33F92ED) * 253590883) + -(-(549281709 + 173376045 + 1037812341))))) ^ (~((0x6186001F ^ 0x5196155F) + --1538882013 * 1669654349) * -1012895013) ^ -677787821)) * 2077516709) - 1185679509)) % 10)
				{
				case 7u:
					break;
				case 1u:
					num4 = P_1->SizeOfRawData;
					num = ((int)num3 * -1941363849) ^ 0x154DFD6C;
					continue;
				case 2u:
					num4 = P_0->headers->OptionalHeader.SizeOfInitializedData;
					num = (int)((num3 * 1830970176) ^ 0x3C83516B);
					continue;
				case 9u:
					obj._184044A093C04AF2(8, 1891439288u);
					num = -2090713016;
					continue;
				case 8u:
					obj._184044A093C04AF2(128, 1219558014u);
					obj._184044A093C04AF2(129, 1762493502u);
					obj._184044A093C04AF2(138, 4119889406u);
					obj._184044A093C04AF2(131, 762380222u);
					num = (int)((num3 * 1441773872) ^ 0xB7B5626);
					continue;
				case 4u:
				{
					uint characteristics = P_1->Characteristics;
					obj._184044A093C04AF2(1, 906726042u);
					int num7;
					if (!C9DC76F773CD4FDB(characteristics & (uint)_003CModule_003E._390073C602714496<int>(-330486006 ^ (int)obj._184044A093C04AF2(10, 0u))))
					{
						num = -1369310229;
						num7 = num;
					}
					else
					{
						num = -1314466380;
						num7 = num;
					}
					continue;
				}
				case 5u:
				{
					int num8;
					int num9;
					if (C9DC76F773CD4FDB(P_1->Characteristics & (uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x78AA3040 ^ obj._184044A093C04AF2(9, 3388241254u)))))
					{
						num8 = -163615523;
						num9 = num8;
					}
					else
					{
						num8 = 1277337559;
						num9 = num8;
					}
					num = num8 ^ (int)(num3 * 1656923867);
					continue;
				}
				case 3u:
				{
					int num5;
					int num6;
					if (num4 == 0)
					{
						num5 = -2133710310;
						num6 = num5;
					}
					else
					{
						num5 = 1135837662;
						num6 = num5;
					}
					num = num5 ^ (int)(num3 * 972740227);
					continue;
				}
				case 0u:
					num4 = P_0->headers->OptionalHeader.SizeOfUninitializedData;
					num = (int)(num3 * 967586424) ^ -472969237;
					continue;
				default:
					return (UIntPtr)num4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static bool _3FA57B95C1094996(_MEMORYMODULE* P_0, SECTIONFINALIZEDATA* P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2070359666u);
		MEMORYMODULE mEMORYMODULE = (MEMORYMODULE)_89FA370153C24543(P_0);
		PageProtection pageProtection = (PageProtection)_003CModule_003E._58ECCB512F2A43AC<int>(-1242674802 ^ (int)obj._184044A093C04AF2(4, 4151370911u));
		bool flag3 = default;
		bool flag = default;
		bool flag2 = default;
		uint num4 = default;
		while (true)
		{
			int num = -426343857;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(num2 - ~(-(-(~388047275 + --40545818 - -(~138851088) - -unchecked(-27464989 * 1387297309) * -1342072241)))) * -1804697151)) % 20)
				{
				case 19u:
					break;
				case 17u:
					obj = new _81DD83B8AA2247AA(1571365428u);
					num = ((int)num3 * -944182332) ^ -316556750;
					continue;
				case 12u:
					flag3 = (P_1->characteristics & (uint)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x7B86940C ^ obj._184044A093C04AF2(6, 1492038331u)))) > (uint)_003CModule_003E._58ECCB512F2A43AC<int>(-1599576109 ^ (int)obj._184044A093C04AF2(1, 1128364337u));
					num = (int)((num3 * 167884045) ^ 0x7292FF80);
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (!P_1->last)
					{
						num6 = -1597558369;
						num7 = num6;
					}
					else
					{
						num6 = -2124516719;
						num7 = num6;
					}
					num = num6 ^ (int)(num3 * 2115076072);
					continue;
				}
				case 10u:
					return (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1458810765 ^ (int)obj._184044A093C04AF2(1, 1574715992u)) != 0;
				case 8u:
				{
					uint characteristics = P_1->characteristics;
					obj._184044A093C04AF2(3, 2458400496u);
					obj._184044A093C04AF2(1, 2789991696u);
					obj._184044A093C04AF2(6, 423020912u);
					int num12;
					if (C9DC76F773CD4FDB(characteristics & (uint)_003CModule_003E._390073C602714496<int>((int)(0x7C6D6459 ^ obj._184044A093C04AF2(8, 2976535408u)))))
					{
						num = 1628161074;
						num12 = num;
					}
					else
					{
						num = 1766394887;
						num12 = num;
					}
					continue;
				}
				case 4u:
				{
					pageProtection = _68FBFA3250A84BE2[_3178148E562E4ACC(flag)][_3178148E562E4ACC(flag2)][_3178148E562E4ACC(flag3)];
					int num13;
					int num14;
					if (!C9DC76F773CD4FDB(P_1->characteristics & (uint)_003CModule_003E._58ECCB512F2A43AC<int>(-256133144 ^ (int)obj._184044A093C04AF2(2, 3064442854u))))
					{
						num13 = -456062638;
						num14 = num13;
					}
					else
					{
						num13 = 924869498;
						num14 = num13;
					}
					num = num13 ^ (int)(num3 * 1699912247);
					continue;
				}
				case 9u:
					obj = new _81DD83B8AA2247AA(1550459716u);
					flag = (P_1->characteristics & (uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x7C0F9931 ^ obj._184044A093C04AF2(5, 3121894072u)))) > (uint)_003CModule_003E._390073C602714496<int>((int)(0x5BD7FAA7 ^ obj._184044A093C04AF2(2, 2685291494u)));
					num = -2019619127;
					continue;
				case 16u:
				{
					int num10;
					int num11;
					if (P_1->size == 0)
					{
						num10 = 1209342235;
						num11 = num10;
					}
					else
					{
						num10 = -1568381584;
						num11 = num10;
					}
					num = num10 ^ (int)(num3 * 470634216);
					continue;
				}
				case 1u:
				{
					int num17;
					int num18;
					if (P_0->headers->OptionalHeader.SectionAlignment == P_0->pageSize)
					{
						num17 = -1543434413;
						num18 = num17;
					}
					else
					{
						num17 = -409003783;
						num18 = num17;
					}
					num = num17 ^ ((int)num3 * -1636031406);
					continue;
				}
				case 18u:
					_8172C7F5002A4783(_62F12D0AC8CC4B86(), _003CModule_003E._390073C602714496<string>((int)(0x35AD771A ^ obj._184044A093C04AF2(5, 1897276139u))));
					return (byte)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x7B667080 ^ obj._184044A093C04AF2(0, 2662921988u))) != 0;
				case 5u:
					num4 = (uint)_003CModule_003E._390073C602714496<int>((int)(0x6A731E51 ^ obj._184044A093C04AF2(9, 4251682443u)));
					flag = (byte)_003CModule_003E._3F57E81A62734AC2<int>(-479393941 ^ (int)obj._184044A093C04AF2(1, 1954174979u)) != 0;
					flag2 = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-1435760385 ^ (int)obj._184044A093C04AF2(0, 88246047u)) != 0;
					obj._184044A093C04AF2(8, 3875829126u);
					obj._184044A093C04AF2(5, 4203125172u);
					obj._184044A093C04AF2(7, 3147490110u);
					flag3 = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x4D687D79 ^ obj._184044A093C04AF2(2, 4226714246u))) != 0;
					num = (int)((num3 * 340280485) ^ 0x4E8170AD);
					continue;
				case 14u:
					pageProtection = (PageProtection)((uint)pageProtection | (uint)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x1939B0E5 ^ obj._184044A093C04AF2(10, 0u))));
					num = ((int)num3 * -1783669972) ^ 0xEF73F66;
					continue;
				case 3u:
					flag2 = (P_1->characteristics & (uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x5D76B0FC ^ obj._184044A093C04AF2(1, 3228520038u)))) > (uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x7D7AB877 ^ obj._184044A093C04AF2(4, 2439628651u)));
					num = ((int)num3 * -306822280) ^ -306208148;
					continue;
				case 6u:
				{
					obj = new _81DD83B8AA2247AA(1927879300u);
					int num15;
					int num16;
					if (P_1->address == P_1->alignedAddress)
					{
						num15 = 752320154;
						num16 = num15;
					}
					else
					{
						num15 = -1761508721;
						num16 = num15;
					}
					num = num15 ^ (int)(num3 * 1800364657);
					continue;
				}
				case 7u:
					mEMORYMODULE.free(P_1->address, (UIntPtr)P_1->size, (MemoryAllocation)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x592CD23D ^ obj._184044A093C04AF2(3, 0u))), P_0->userdata);
					num = 1881106841;
					continue;
				case 15u:
					return (byte)_003CModule_003E.F84FA79ABE6944BB<int>(-146289120 ^ (int)obj._184044A093C04AF2(6, 213201224u)) != 0;
				case 13u:
				{
					int num8;
					int num9;
					if (P_1->size % P_0->pageSize == 0)
					{
						num8 = -1701627413;
						num9 = num8;
					}
					else
					{
						num8 = 1249833859;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -172908798);
					continue;
				}
				case 2u:
				{
					obj = new _81DD83B8AA2247AA(3163408888u);
					int num5;
					if (_36487117836A4DE3(P_1->address, (UIntPtr)P_1->size, pageProtection, &num4) != 0)
					{
						num = -1010727375;
						num5 = num;
					}
					else
					{
						num = 2091542510;
						num5 = num;
					}
					continue;
				}
				default:
					return (byte)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x79E1233F ^ obj._184044A093C04AF2(6, 3512105962u))) != 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static bool _8AB571AFF0A04120(_MEMORYMODULE* P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2931684829u);
		_IMAGE_SECTION_HEADER* ptr = B823ADB6032F4C5B((UIntPtr)P_0->headers);
		if (_0C38845A5DED4296())
		{
			goto IL_0027;
		}
		goto IL_018a;
		IL_0027:
		int num = 670069029;
		goto IL_002c;
		IL_002c:
		SECTIONFINALIZEDATA sECTIONFINALIZEDATA = default;
		void* ptr3 = default;
		UIntPtr uIntPtr2 = default;
		UIntPtr uIntPtr3 = default;
		void* ptr2 = default;
		UIntPtr uIntPtr = default;
		int num10 = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(-451457474 - (num2 - ((66059947 * ~(-unchecked(1928277045 + 1658783821) ^ 0x1A9C47BE)) ^ -1116566568 ^ (-(-1725940027 ^ -164286920) + -1771833220 - (--1299384595 - -unchecked(-929108841 * (-128194584 + -716656789)) * -745257483))) - ~480670406))) % 35)
			{
			case 23u:
				break;
			case 0u:
			{
				int num14;
				int num15;
				if ((sECTIONFINALIZEDATA.characteristics & (uint)_003CModule_003E._390073C602714496<int>(-952669805 ^ (int)obj._184044A093C04AF2(8, 0u))) == 0)
				{
					num14 = -1133468862;
					num15 = num14;
				}
				else
				{
					num14 = -1589404438;
					num15 = num14;
				}
				num = num14 ^ ((int)num3 * -387569452);
				continue;
			}
			case 27u:
				goto IL_018a;
			case 24u:
				goto IL_01a2;
			case 8u:
				obj = new _81DD83B8AA2247AA(542572406u);
				sECTIONFINALIZEDATA.characteristics |= ptr->Characteristics;
				num = 1945305249;
				continue;
			case 5u:
				return (byte)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x1949F280 ^ obj._184044A093C04AF2(5, 194959708u))) != 0;
			case 11u:
				uIntPtr = (UIntPtr)ptr->Misc.PhysicalAddress;
				num = (int)(num3 * 870967553) ^ -1238404772;
				continue;
			case 32u:
				ptr3 = (void*)(uIntPtr.ToUInt64() | uIntPtr2.ToUInt64());
				num = (int)((num3 * 335040803) ^ 0x22866B65);
				continue;
			case 31u:
				obj._184044A093C04AF2(5, 3640358318u);
				num = 1323310469;
				continue;
			case 20u:
				uIntPtr2 = UIntPtr.Zero;
				num = (int)((num3 * 967977320) ^ 0x172B4DA9);
				continue;
			case 14u:
			{
				uIntPtr3 = D91EAC52DFF2430B(P_0, ptr);
				int num7;
				int num8;
				if (sECTIONFINALIZEDATA.alignedAddress != ptr2)
				{
					num7 = 779292931;
					num8 = num7;
				}
				else
				{
					num7 = 342007147;
					num8 = num7;
				}
				num = num7 ^ (int)(num3 * 842908724);
				continue;
			}
			case 22u:
				obj._184044A093C04AF2(6, 2803022218u);
				obj._184044A093C04AF2(3, 3437586758u);
				num = (int)((num3 * 999157341) ^ 0x3522A539);
				continue;
			case 1u:
				num = (int)((num3 * 627689188) ^ 0x6ACD0CB5);
				continue;
			case 7u:
				obj._184044A093C04AF2(0, 3932014858u);
				obj._184044A093C04AF2(1, 612581448u);
				num = -2097690619;
				continue;
			case 13u:
				sECTIONFINALIZEDATA.size = (uint)D91EAC52DFF2430B(P_0, ptr);
				sECTIONFINALIZEDATA.characteristics = ptr->Characteristics;
				sECTIONFINALIZEDATA.last = (byte)_003CModule_003E._390073C602714496<int>(-1619491749 ^ (int)obj._184044A093C04AF2(2, 2791937483u)) != 0;
				ptr++;
				num = (int)(num3 * 1432289686) ^ -815430780;
				continue;
			case 18u:
				obj = new _81DD83B8AA2247AA(2396876220u);
				num = 98955673;
				continue;
			case 17u:
				sECTIONFINALIZEDATA.address = ptr3;
				num = (int)(num3 * 1655215946) ^ -465375830;
				continue;
			case 15u:
			{
				ulong num18 = uIntPtr.ToUInt64();
				uIntPtr = (UIntPtr)ptr2;
				int num19;
				int num20;
				if (num18 > uIntPtr.ToUInt64())
				{
					num19 = 685101530;
					num20 = num19;
				}
				else
				{
					num19 = 1104560891;
					num20 = num19;
				}
				num = num19 ^ ((int)num3 * -1023063003);
				continue;
			}
			case 9u:
			{
				ulong num16 = ((UIntPtr)ptr3).ToUInt64();
				uIntPtr = uIntPtr3;
				ulong num17 = num16 + uIntPtr.ToUInt64();
				uIntPtr = (UIntPtr)sECTIONFINALIZEDATA.address;
				sECTIONFINALIZEDATA.size = (uint)(num17 - uIntPtr.ToUInt64());
				num = (int)(num3 * 1990156749) ^ -1174668022;
				continue;
			}
			case 10u:
				obj._184044A093C04AF2(5, 2087154108u);
				num = 426826330;
				continue;
			case 34u:
				num10 = _003CModule_003E.F84FA79ABE6944BB<int>(-2019261284 ^ (int)obj._184044A093C04AF2(1, 1338827131u));
				num = ((int)num3 * -423135) ^ 0x170D3232;
				continue;
			case 33u:
				num = ((int)num3 * -1948813702) ^ 0x38807F1;
				continue;
			case 12u:
				sECTIONFINALIZEDATA.alignedAddress = ptr2;
				sECTIONFINALIZEDATA.size = (uint)uIntPtr3;
				sECTIONFINALIZEDATA.characteristics = ptr->Characteristics;
				num = (int)(num3 * 524647667) ^ -1801066103;
				continue;
			case 25u:
			{
				int num12;
				int num13;
				if (_3FA57B95C1094996(P_0, &sECTIONFINALIZEDATA))
				{
					num12 = -550802879;
					num13 = num12;
				}
				else
				{
					num12 = -7797258;
					num13 = num12;
				}
				num = num12 ^ ((int)num3 * -2086025575);
				continue;
			}
			case 30u:
			{
				uIntPtr = P_0->headers->OptionalHeader.ImageBase;
				ulong num11 = uIntPtr.ToUInt64();
				obj._184044A093C04AF2(4, 2304590149u);
				uIntPtr2 = (UIntPtr)(num11 & (ulong)_003CModule_003E._3F57E81A62734AC2<long>(-480392179 ^ (int)obj._184044A093C04AF2(11, 0u)));
				num = ((int)num3 * -1151204917) ^ 0x53557A69;
				continue;
			}
			case 19u:
			{
				int num9 = num10;
				obj._184044A093C04AF2(10, 3763881408u);
				obj._184044A093C04AF2(9, 3753248230u);
				obj._184044A093C04AF2(11, 3223345689u);
				num10 = num9 + _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x30D9DB4D ^ obj._184044A093C04AF2(8, 3279010062u)));
				ptr++;
				num = 2000419021;
				continue;
			}
			case 3u:
				goto IL_05b3;
			case 4u:
				return (byte)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x5E9838AF ^ obj._184044A093C04AF2(5, 206694859u))) != 0;
			case 29u:
				ptr2 = A82264EB07AC4A21(ptr3, (UIntPtr)P_0->pageSize);
				num = ((int)num3 * -1536605855) ^ -2005015701;
				continue;
			case 21u:
				num = ((int)num3 * -343720052) ^ -1607696080;
				continue;
			case 6u:
			{
				sECTIONFINALIZEDATA.last = (byte)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0xFD7883F ^ obj._184044A093C04AF2(9, 4049834884u))) != 0;
				int num5;
				int num6;
				if (_3FA57B95C1094996(P_0, &sECTIONFINALIZEDATA))
				{
					num5 = -454599244;
					num6 = num5;
				}
				else
				{
					num5 = -1141564828;
					num6 = num5;
				}
				num = num5 ^ (int)(num3 * 1978659451);
				continue;
			}
			case 16u:
				uIntPtr = UIntPtr.Add((UIntPtr)sECTIONFINALIZEDATA.address, (int)sECTIONFINALIZEDATA.size);
				num = (int)(num3 * 1987124181) ^ -1843443038;
				continue;
			case 2u:
				sECTIONFINALIZEDATA = default;
				uIntPtr = (UIntPtr)ptr->Misc.PhysicalAddress;
				sECTIONFINALIZEDATA.address = (void*)(uIntPtr.ToUInt64() | uIntPtr2.ToUInt64());
				sECTIONFINALIZEDATA.alignedAddress = A82264EB07AC4A21(sECTIONFINALIZEDATA.address, (UIntPtr)P_0->pageSize);
				num = 1474254211;
				continue;
			case 28u:
			{
				uint num4 = sECTIONFINALIZEDATA.characteristics | ptr->Characteristics;
				obj._184044A093C04AF2(8, 3932014858u);
				obj._184044A093C04AF2(1, 2165785658u);
				obj._184044A093C04AF2(3, 3437586758u);
				sECTIONFINALIZEDATA.characteristics = num4 & (uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x362DE9EF ^ obj._184044A093C04AF2(6, 2811905208u)));
				num = 1171063048;
				continue;
			}
			default:
				return (byte)_003CModule_003E._390073C602714496<int>((int)(0x22B13D2D ^ obj._184044A093C04AF2(0, 4080741413u))) != 0;
			}
			break;
			IL_05b3:
			obj = new _81DD83B8AA2247AA(287721860u);
			int num21;
			if (num10 >= P_0->headers->FileHeader.NumberOfSections)
			{
				num = 1792389868;
				num21 = num;
			}
			else
			{
				num = 728571751;
				num21 = num;
			}
			continue;
			IL_01a2:
			int num22;
			if ((ptr->Characteristics & (uint)_003CModule_003E._3F57E81A62734AC2<int>((int)(0xD3C1F58 ^ obj._184044A093C04AF2(2, 8977714u)))) != 0)
			{
				num = -2094379177;
				num22 = num;
			}
			else
			{
				num = 1281055386;
				num22 = num;
			}
		}
		goto IL_0027;
		IL_018a:
		obj._184044A093C04AF2(8, 2304590149u);
		num = 1016725279;
		goto IL_002c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static bool _499CB42D040340B5(_MEMORYMODULE* P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(4116300443u);
		byte* codeBase = default;
		_IMAGE_DATA_DIRECTORY* ptr2 = default;
		while (true)
		{
			int num = 1222433592;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-((-(--1258514421) + (-unchecked(-1052090127 * unchecked(unchecked(-752835089 + -1869661704) + unchecked(-679559989 + -1478315584))) + unchecked(-867261921 * ~(0x630A422A ^ -677522588))) + (-((-740969890 ^ -533963838) + (-822813255 ^ --255035721) - (-1133231895 - -(-1063893206 ^ -735382694))) ^ 0x3D8D19AD) - num2) ^ (-1763105313 * -1268659302)))) % 5)
				{
				case 3u:
					break;
				case 4u:
				{
					codeBase = P_0->codeBase;
					_IMAGE_TLS_DIRECTORY* ptr = default;
					num = (int)((num3 * 818583786) ^ 0x67A61F59);
					continue;
				}
				case 0u:
					return (byte)_003CModule_003E._3F57E81A62734AC2<int>(-2102589723 ^ (int)new _81DD83B8AA2247AA(4159094202u)._184044A093C04AF2(5, 2273862120u)) != 0;
				case 1u:
				{
					obj._184044A093C04AF2(0, 3965756417u);
					obj._184044A093C04AF2(1, 2558982367u);
					obj._184044A093C04AF2(7, 471210337u);
					ptr2 = _3BD68850EE9E41E3(P_0, (ImageDirectoryEntry)_003CModule_003E._58ECCB512F2A43AC<int>(-1592508547 ^ (int)obj._184044A093C04AF2(10, 4093425345u)));
					int num4;
					int num5;
					if (ptr2->VirtualAddress == 0)
					{
						num4 = -1767603403;
						num5 = num4;
					}
					else
					{
						num4 = -132648737;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -556863267);
					continue;
				}
				default:
				{
					obj = new _81DD83B8AA2247AA(125127675u);
					_IMAGE_TLS_DIRECTORY* ptr = (_IMAGE_TLS_DIRECTORY*)(codeBase + ptr2->VirtualAddress);
					return _9CD2CDF982024580(*(uint*)(void*)ptr->AddressOfIndex);
				}
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "SetLastError")]
	private static extern void DAB02FE0B5C74E11(Error P_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetLastError")]
	private static extern uint _4DDD9BAD87FB4691();

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetNativeSystemInfo")]
	private unsafe static extern void _6072F3E65B854F58(void* P_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "HeapAlloc")]
	private unsafe static extern void* EE300819ED204F00(void* P_0, uint P_1, uint P_2);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "HeapFree")]
	private unsafe static extern int _6225D4C3DB2E45E3(void* P_0, uint P_1, void* P_2);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetProcessHeap")]
	private unsafe static extern void* A1BFB55F51704683();

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "IsBadReadPtr")]
	private unsafe static extern int D603CA34E20A4805(void* P_0, uint P_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "VirtualAlloc")]
	private unsafe static extern void* A40B0A3914BC4D4C(void* P_0, UIntPtr P_1, MemoryAllocation P_2, PageProtection P_3);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "VirtualFree")]
	private unsafe static extern bool _78DE2EAAD1584528(void* P_0, UIntPtr P_1, MemoryAllocation P_2);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "LoadLibraryA")]
	private unsafe static extern void* _8953E20892F241D0(char* P_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetProcAddress")]
	private unsafe static extern void* CED0FF9B864F4C22(void* P_0, char* P_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "FreeLibrary")]
	private unsafe static extern bool C664ED4F1AAD45A7(void* P_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "VirtualProtect")]
	private unsafe static extern int _36487117836A4DE3(void* P_0, UIntPtr P_1, PageProtection P_2, void* P_3);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "TlsAlloc", SetLastError = true)]
	private static extern uint _11B1C4E88B6E47D6();

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "TlsFree", SetLastError = true)]
	private static extern bool _9CD2CDF982024580(uint P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	unsafe static _89C94C43C8614FCF()
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1200677507u);
		DD1D33A9870E4CE7 = AAA645A4686F434E;
		_084D8C4001694CA5 = _5A65705A78994A08;
		_7A9F92DF137340BE = DF2AD576C98244F3;
		_67D2A727A94F451D = _258EF3CD346F41E9;
		_708DBDD3C3BF4E22 = _30D430E9499F4C5D;
		while (true)
		{
			int num = -184112777;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-(~(num2 * -1352341351) * 1489149299) * 866586171 * -753410919 - unchecked(-17894313 * -1934495060)))) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_00a9;
				case 1u:
					return;
				}
				break;
				IL_00a9:
				_45AD50D7D9F84A1A = ((Func<uint>)(() => RuntimeInformation.ProcessArchitecture switch
				{
					Architecture.X86 => 332u, 
					Architecture.X64 => 34404u, 
					Architecture.Arm => 452u, 
					Architecture.Arm64 => 43620u, 
					_ => throw new PlatformNotSupportedException(), 
				}))();
				PageProtection[][][] array = new PageProtection[_003CModule_003E._3F57E81A62734AC2<int>(-1832209136 ^ (int)obj._184044A093C04AF2(4, 638143359u))][][];
				int num4 = _003CModule_003E._390073C602714496<int>((int)(0x9E7BDE2 ^ obj._184044A093C04AF2(10, 2796904994u)));
				PageProtection[][] array2 = new PageProtection[_003CModule_003E._8B9C7B12B1AE4949<int>(-76223517 ^ (int)obj._184044A093C04AF2(4, 4027905885u))][];
				int num5 = _003CModule_003E._390073C602714496<int>(-35330232 ^ (int)obj._184044A093C04AF2(0, 973237738u));
				PageProtection[] array3 = new PageProtection[_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x26DD808B ^ obj._184044A093C04AF2(1, 1587459907u)))];
				array3[_003CModule_003E._58ECCB512F2A43AC<int>(-1460129798 ^ (int)obj._184044A093C04AF2(4, 817492705u))] = (PageProtection)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x62296915 ^ obj._184044A093C04AF2(9, 2890825909u)));
				array3[_003CModule_003E._390073C602714496<int>(-2013395059 ^ (int)obj._184044A093C04AF2(8, 1011841355u))] = (PageProtection)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x2DD3487D ^ obj._184044A093C04AF2(9, 2565578799u)));
				array2[num5] = array3;
				int num6 = _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x20EAAA1B ^ obj._184044A093C04AF2(0, 3374630462u)));
				PageProtection[] array4 = new PageProtection[_003CModule_003E._8B9C7B12B1AE4949<int>(-1904046300 ^ (int)obj._184044A093C04AF2(10, 1549554949u))];
				array4[_003CModule_003E._3F57E81A62734AC2<int>(-1104300862 ^ (int)obj._184044A093C04AF2(8, 3841179014u))] = (PageProtection)_003CModule_003E._390073C602714496<int>((int)(0x670A2E04 ^ obj._184044A093C04AF2(9, 1717343102u)));
				array4[_003CModule_003E._390073C602714496<int>((int)(0x52DCAD35 ^ obj._184044A093C04AF2(2, 4144186495u)))] = (PageProtection)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0xB79DA12 ^ obj._184044A093C04AF2(4, 2951691571u)));
				array2[num6] = array4;
				array[num4] = array2;
				int num7 = _003CModule_003E._390073C602714496<int>(-1408454512 ^ (int)obj._184044A093C04AF2(0, 1363091606u));
				PageProtection[][] array5 = new PageProtection[_003CModule_003E._3F57E81A62734AC2<int>(-91676255 ^ (int)obj._184044A093C04AF2(5, 3448318218u))][];
				int num8 = _003CModule_003E._3F57E81A62734AC2<int>(-831835824 ^ (int)obj._184044A093C04AF2(0, 132671370u));
				PageProtection[] array6 = new PageProtection[_003CModule_003E._390073C602714496<int>((int)(0x5753A032 ^ obj._184044A093C04AF2(5, 3822327232u)))];
				array6[_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x9EB85CA ^ obj._184044A093C04AF2(5, 33400580u)))] = (PageProtection)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x26798B85 ^ obj._184044A093C04AF2(8, 3407276720u)));
				array6[_003CModule_003E.F84FA79ABE6944BB<int>(-1167807393 ^ (int)obj._184044A093C04AF2(9, 1293646961u))] = (PageProtection)_003CModule_003E.F84FA79ABE6944BB<int>(-1644677729 ^ (int)obj._184044A093C04AF2(10, 1719243832u));
				array5[num8] = array6;
				int num9 = _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x51F3C81C ^ obj._184044A093C04AF2(6, 858123535u)));
				PageProtection[] array7 = new PageProtection[_003CModule_003E._390073C602714496<int>(-598064858 ^ (int)obj._184044A093C04AF2(1, 2638547874u))];
				array7[_003CModule_003E._390073C602714496<int>(-135998033 ^ (int)obj._184044A093C04AF2(9, 905677301u))] = (PageProtection)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x66468383 ^ obj._184044A093C04AF2(6, 877748274u)));
				array7[_003CModule_003E._58ECCB512F2A43AC<int>(-1442771555 ^ (int)obj._184044A093C04AF2(1, 1422567905u))] = (PageProtection)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x1F2F1B21 ^ obj._184044A093C04AF2(4, 3686639057u)));
				array5[num9] = array7;
				array[num7] = array5;
				_68FBFA3250A84BE2 = array;
				num = (int)((num3 * 43580272) ^ 0x5F7F62FB);
			}
		}
	}

	static object _620FCAE00A124459(int P_0)
	{
		return new Win32Exception(P_0);
	}

	static IntPtr _1E0C77999D3E4F68(string P_0)
	{
		return Marshal.StringToHGlobalAnsi(P_0);
	}

	static object _075306E5B9FB4985(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object _25597B7A47384DDE(IntPtr P_0, Type P_1)
	{
		return Marshal.GetDelegateForFunctionPointer(P_0, P_1);
	}

	static void _30FF1DBC74654F7B(IntPtr P_0)
	{
		Marshal.FreeHGlobal(P_0);
	}

	static bool C9DC76F773CD4FDB(uint P_0)
	{
		return Convert.ToBoolean(P_0);
	}

	static bool _0C38845A5DED4296()
	{
		return Environment.Is64BitProcess;
	}

	unsafe static void* CDDC078DFED443F4(uint P_0)
	{
		return _9B23CE46D4544D63._7A6047F799AC428E(P_0);
	}

	static int B3D0780808734390(Type P_0)
	{
		return Marshal.SizeOf(P_0);
	}

	static int _3178148E562E4ACC(bool P_0)
	{
		return Convert.ToInt32(P_0);
	}

	unsafe static void* _9E65D1B026A2487E(void* P_0, void* P_1, uint P_2)
	{
		return _9B23CE46D4544D63._2967AA18DF7D4B63(P_0, P_1, P_2);
	}

	static bool A915C5148862457B(int P_0)
	{
		return Convert.ToBoolean(P_0);
	}

	unsafe static object _89FA370153C24543(_MEMORYMODULE* P_0)
	{
		return MEMORYMODULE.MarshalFrom(P_0);
	}

	unsafe static void _57D606BE468B48CD(void* P_0)
	{
		_9B23CE46D4544D63._22A3CC2BB1664890(P_0);
	}

	static string _9E97E44C26854DEE(IntPtr P_0)
	{
		return Marshal.PtrToStringAnsi(P_0);
	}

	static IntPtr _8D02A2DF6954498F(Type P_0, string P_1)
	{
		return Marshal.OffsetOf(P_0, P_1);
	}

	unsafe static void* C556D3BF617444F5(void* P_0, int P_1, uint P_2)
	{
		return _9B23CE46D4544D63._22EEA9845D2D4BDE(P_0, P_1, P_2);
	}

	static void DCED07FB8FF34198(string P_0)
	{
		Console.WriteLine(P_0);
	}

	static string AD0FFC72C1AA4E6F(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _515E3A2631534EA4(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static object D2EC82C712AA417F(string P_0)
	{
		return new FBEA5B68721C48F2(P_0);
	}

	unsafe static void* _97F696E1D53D4E1E(void* P_0, uint P_1)
	{
		return _9B23CE46D4544D63.D50F7FDB619343EA(P_0, P_1);
	}

	static object _62F12D0AC8CC4B86()
	{
		return Console.Error;
	}

	static void _8172C7F5002A4783(object P_0, string P_1)
	{
		((TextWriter)P_0).WriteLine(P_1);
	}
}
