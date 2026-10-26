using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using GlibcInterop;

internal static class _5658C81EDBBB4F69
{
	private class MemoryModule
	{
		public unsafe void* codeBase;

		public ulong codeSize;

		public LinkMap map;

		public IntPtr[] dependencies;

		public bool initialized;

		public CustomAllocFunc alloc;

		public CustomFreeFunc free;

		public CustomLoadLibraryFunc loadLibrary;

		public CustomGetProcAddressFunc getProcAddress;

		public CustomFreeLibraryFunc freeLibrary;

		public Dictionary<string, List<_4697E400134E4CA8>> nameExportsTable;

		public unsafe void* symbolArrayPtr;

		public _06E00CD4BCAE4936 symbolArray;

		public IntPtr firstFinalizer;

		public IntPtr finalizerArray;

		public ulong finalizerArrayCount;

		public unsafe void* userdata;

		public ulong pageSize;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 8)]
	public struct POINTER_LIST
	{
		public unsafe POINTER_LIST* next;

		public unsafe void* address;
	}

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private unsafe delegate void InitDelegate(int argc, byte** argv, byte** envp);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void FiniDelegate();

	private static class Dl
	{
		[DllImport("libdl.so.2", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void* dlopen(char* name, int mode = 257);

		[DllImport("libdl.so.2", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern void* dlsym(void* handle, char* name);

		[DllImport("libdl.so.2", CallingConvention = CallingConvention.Cdecl)]
		public unsafe static extern int dlclose(void* handle);
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public _1E7BC0C438DF4CB6 symbolTable;

		internal bool _003CResolveSymbols_003Eb__1(_9F61EB4FCBA44886 header)
		{
			return header.Offset == symbolTable.Value;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public _1E7BC0C438DF4CB6 jumpRel;

		internal bool _003CApplyRelocations_003Eb__4(_9F61EB4FCBA44886 header)
		{
			return header.Offset == jumpRel.Value;
		}
	}

	public static CustomAllocFunc E838ACF743B94050;

	public static CustomFreeFunc _6976359CB1334015;

	public static CustomLoadLibraryFunc D2DFE763FC804846;

	public static CustomGetProcAddressFunc _9E971C61A9554C8C;

	public static CustomFreeLibraryFunc _19AD7ED97F0D4A36;

	private static readonly uint _9BFE71D11087449F;

	private const int EF024A52B54847A0 = 30;

	private const int _80295DF2ADBF4F15 = 30;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static IntPtr _6C0C1695013442A3(byte* P_0, long P_1, CustomAllocFunc P_2 = null, CustomFreeFunc P_3 = null, CustomLoadLibraryFunc P_4 = null, CustomGetProcAddressFunc P_5 = null, CustomFreeLibraryFunc P_6 = null)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(215799460u);
		while (true)
		{
			int num = -1213631628;
			while (true)
			{
				int num2 = num;
				uint num3;
				CustomLoadLibraryFunc customLoadLibraryFunc;
				switch ((num3 = (uint)(113573731 - (~(-(~(num2 * -70681629 * 1883244755)) + ~(~unchecked(-1069637098 * 2047488717))) ^ 0xAA28A61))) % 3)
				{
				case 0u:
					break;
				case 1u:
				{
					CustomAllocFunc customAllocFunc = P_2 ?? E838ACF743B94050;
					obj._184044A093C04AF2(9, 1165243083u);
					P_2 = customAllocFunc;
					CustomFreeFunc customFreeFunc = P_3 ?? _6976359CB1334015;
					obj._184044A093C04AF2(8, 3433333990u);
					P_3 = customFreeFunc;
					customLoadLibraryFunc = P_4 ?? D2DFE763FC804846;
					goto IL_0093;
				}
				default:
				{
					CustomGetProcAddressFunc customGetProcAddressFunc = P_5 ?? _9E971C61A9554C8C;
					obj._184044A093C04AF2(2, 3383273126u);
					P_5 = customGetProcAddressFunc;
					P_6 = P_6 ?? _19AD7ED97F0D4A36;
					return (IntPtr)_6A1740F9B833428F(P_0, (ulong)P_1, P_2, P_3, P_4, P_5, P_6, (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x669B626 ^ obj._184044A093C04AF2(0, 3840188657u))));
				}
				}
				break;
				IL_0093:
				obj._184044A093C04AF2(2, 1653096656u);
				P_4 = customLoadLibraryFunc;
				num = -229712127;
			}
		}
	}

	public static bool _4AE84E4B3FBB437E(IntPtr P_0)
	{
		return _795B0C994B1B4A98(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static IntPtr _93B27360AFC246A7(IntPtr P_0, string P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3478428412u);
		char* ptr = (char*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>(-1442214831 ^ (int)obj._184044A093C04AF2(10, 2705071697u));
		IntPtr result;
		try
		{
			obj = new _81DD83B8AA2247AA(510853324u);
			ptr = (char*)(void*)_2E00853FE0304BD9(P_1);
			result = (IntPtr)_66A9E74204E54F09(P_0, ptr);
		}
		finally
		{
			obj._184044A093C04AF2(132, 633011788u);
			obj._184044A093C04AF2(137, 3408604108u);
			while (true)
			{
				IL_006f:
				int num = 804641947;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((-770427156 ^ -1930550415) - ((unchecked((0x36074135 ^ 0xF5977F2) - ~(-787486714 ^ -1090419122)) - (-(-1609300052) ^ -unchecked(-374494841 * 1196033321)) - -unchecked(unchecked(-1511582639 * (-678689892 ^ -867581045)) + ~unchecked(1587245971 * -1590136039)) - (num2 - (-((-((0x6AC87F4 ^ 0x630702C7) + unchecked(-13092249 * -387642643)) + unchecked(unchecked((0x4E2202D0 ^ 0x49A65C8C) * -1319042937) * 1977786459)) * -2112750193) - 1752023323 * (-(~2115625381 + 716393027) - -1435942161 * -(--12402784) - -(-(unchecked(1690179842 * 1540470565) - ~1305929343)))) - ~(316510868 - ((-2000742554 + unchecked(-1098605613 + -1412354707)) ^ -2007957328) - (unchecked(860025559 * ~unchecked(1956033731 * -1974811099)) + (--818597716 ^ -2025739464 ^ (-648518680 ^ -1729333723)))))) ^ 0x425351EC ^ (unchecked(~1409673830 * 1212008985) - ~(--2032352181)) ^ 0x1D481168) - 554763304)) % 4)
					{
					case 0u:
						break;
					default:
						goto end_IL_0074;
					case 2u:
						obj._184044A093C04AF2(130, 2186905932u);
						obj._184044A093C04AF2(139, 3013351116u);
						num = (int)((num3 * 362785274) ^ 0x2B9E93D0);
						continue;
					case 1u:
						BE4FAD676FA840DD((IntPtr)ptr);
						num = (int)((num3 * 603971728) ^ 0x4C113EE6);
						continue;
					case 3u:
						goto end_IL_0074;
					}
					goto IL_006f;
					continue;
					end_IL_0074:
					break;
				}
				break;
			}
		}
		obj._184044A093C04AF2(10, 3868784763u);
		return result;
	}

	public unsafe static void* _01D94F3CF02247C5(void* P_0, char* P_1)
	{
		return _66A9E74204E54F09((IntPtr)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void* _29E2D651EFA24403(void* P_0, UIntPtr P_1, MemoryAllocation P_2, PageProtection P_3, void* P_4)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(436604650u);
		return A6E46F54B4744622(P_0, P_1, _25CC0C914F1C4C57(P_3), (MmapMappingFlags)_003CModule_003E._8B9C7B12B1AE4949<int>(-797675171 ^ (int)obj._184044A093C04AF2(9, 1077259847u)), _003CModule_003E._3F57E81A62734AC2<int>(-2023152359 ^ (int)obj._184044A093C04AF2(10, 996647712u)), _003CModule_003E._58ECCB512F2A43AC<int>(-2067346186 ^ (int)obj._184044A093C04AF2(9, 3787483366u)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static bool FAA2AD51ED324311(void* P_0, UIntPtr P_1, MemoryAllocation P_2, void* P_3)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(839687019u);
		return _6EFB65D1AFFB4D0C(P_0, P_1) == _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x3D572CDE ^ obj._184044A093C04AF2(2, 614453171u)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void* _3098F709D72A40CB(char* P_0, void* P_1)
	{
		void* result;
		_81DD83B8AA2247AA obj;
		try
		{
			result = _38D2FF4E262C4A91(P_0, _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x242848D7 ^ new _81DD83B8AA2247AA(3309637081u)._184044A093C04AF2(5, 397360267u))));
		}
		catch (EntryPointNotFoundException)
		{
			obj = new _81DD83B8AA2247AA(224912749u);
			obj._184044A093C04AF2(8, 1737165300u);
			obj._184044A093C04AF2(10, 971723636u);
			obj._184044A093C04AF2(7, 2125689236u);
			result = _0B2778CB90D44154(P_0, _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x6839ADC8 ^ obj._184044A093C04AF2(5, 81442807u))));
		}
		obj = new _81DD83B8AA2247AA(1778469556u);
		return result;
	}

	internal unsafe static void* C4DAF164D55549A1(void* P_0, char* P_1, void* P_2)
	{
		try
		{
			return _28A201EFE05E4907(P_0, P_1);
		}
		catch (EntryPointNotFoundException)
		{
			return _76ADEE7338A44D5C(P_0, P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static bool C55C162F34BF4212(void* P_0, void* P_1)
	{
		bool result = default;
		_81DD83B8AA2247AA obj;
		try
		{
			obj = new _81DD83B8AA2247AA(3494007383u);
			result = _084B789F36664D29(P_0) == _003CModule_003E._3F57E81A62734AC2<int>((int)(0x39DF3F51 ^ obj._184044A093C04AF2(4, 802266593u)));
		}
		catch (EntryPointNotFoundException)
		{
			obj = new _81DD83B8AA2247AA(4240744693u);
			while (true)
			{
				IL_003f:
				int num = -1477518358;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(~(-num2)))) % 3)
					{
					case 0u:
						break;
					default:
						goto end_IL_0044;
					case 2u:
						goto IL_0060;
					case 1u:
						goto end_IL_0044;
					}
					goto IL_003f;
					IL_0060:
					int num4 = C7DFA364C2124BA3(P_0);
					obj._184044A093C04AF2(4, 3451593027u);
					obj._184044A093C04AF2(10, 165445666u);
					obj._184044A093C04AF2(7, 1043715486u);
					result = num4 == _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x692D428B ^ obj._184044A093C04AF2(9, 3263159778u)));
					num = (int)(num3 * 1557535778) ^ -292190064;
					continue;
					end_IL_0044:
					break;
				}
				break;
			}
		}
		obj = new _81DD83B8AA2247AA(3860335580u);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _2B481CCB20E54BAB(void* P_0, ulong P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2267572769u);
		return _6A1740F9B833428F(P_0, P_1, E838ACF743B94050, _6976359CB1334015, D2DFE763FC804846, _9E971C61A9554C8C, _19AD7ED97F0D4A36, (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x6620F24C ^ obj._184044A093C04AF2(9, 947200971u))));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _6A1740F9B833428F(void* P_0, ulong P_1, CustomAllocFunc P_2, CustomFreeFunc P_3, CustomLoadLibraryFunc P_4, CustomGetProcAddressFunc P_5, CustomFreeLibraryFunc P_6, void* P_7)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(304195840u);
		MemoryModule memoryModule = (MemoryModule)_444841BEAB0E4D97();
		IntPtr intPtr = (IntPtr)GCHandle.Alloc(memoryModule);
		void* result = default;
		try
		{
			DD25C3AA7E904C37(P_1, (ulong)sizeof(_50E28FBE88E34375));
			_7F042AF7ECCF4530 obj2 = default;
			_50E28FBE88E34375* ptr = default;
			while (true)
			{
				IL_002b:
				int num = 796734132;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(-(-(~(-(-(-unchecked(1206486917 * -901773753) ^ (((0x191A47E3 ^ -592440675) - (--749144492 ^ 0x30C7EB3D)) ^ -587927658))) - num2) ^ -(~(0x2EE20086 ^ 0x79484A87)))) - unchecked(unchecked(-1488700589 - 1685916180) * 1792744119)) * 1313755657)) % 23)
					{
					case 3u:
						break;
					default:
						goto end_IL_0030;
					case 10u:
						_294C6177A534426F(memoryModule, obj2);
						_4DD8CE92B45A41BD(memoryModule, obj2);
						num = ((int)num3 * -1673074501) ^ 0x3B20ED11;
						continue;
					case 12u:
						obj = new _81DD83B8AA2247AA(2609167128u);
						num = 2143290294;
						continue;
					case 11u:
						_42A934BEB8264747(memoryModule, obj2);
						_732BE3E7D86F40A0(memoryModule, obj2);
						result = (void*)intPtr;
						num = ((int)num3 * -1929843102) ^ 0x47BC1839;
						continue;
					case 0u:
					{
						obj._184044A093C04AF2(8, 3790983427u);
						int num13;
						if (ptr->SectionHeaderSize != sizeof(C3BAEA502162488F))
						{
							num = -9209110;
							num13 = num;
						}
						else
						{
							num = -1231960270;
							num13 = num;
						}
						continue;
					}
					case 1u:
						throw BEFBA9987F55444F(_003CModule_003E._390073C602714496<string>(-2116516962 ^ (int)obj._184044A093C04AF2(2, 2765450777u)));
					case 20u:
					{
						obj = new _81DD83B8AA2247AA(1049560714u);
						int num16;
						if (ptr->ProgramHeaderSize != sizeof(_1BF6F1682AC14ECD))
						{
							num = -1322904731;
							num16 = num;
						}
						else
						{
							num = 1521095863;
							num16 = num;
						}
						continue;
					}
					case 14u:
						B037B093099A4DD1(memoryModule, obj2);
						num = (int)((num3 * 1227174561) ^ 0x69A86B2D);
						continue;
					case 9u:
						D37E939616FA44A5(memoryModule, obj2);
						_569686D00A854548(memoryModule, obj2);
						num = ((int)num3 * -1796098189) ^ 0x5987DBD1;
						continue;
					case 22u:
					{
						int num9;
						int num10;
						if ((uint)ptr->Machine == _9BFE71D11087449F)
						{
							num9 = -1139519701;
							num10 = num9;
						}
						else
						{
							num9 = -2093723672;
							num10 = num9;
						}
						num = num9 ^ (int)(num3 * 550419211);
						continue;
					}
					case 4u:
					{
						int num6;
						if ((int)ptr->Type == _003CModule_003E._390073C602714496<int>((int)(0x18C406B8 ^ obj._184044A093C04AF2(4, 391997459u))))
						{
							num = 639548951;
							num6 = num;
						}
						else
						{
							num = -473093124;
							num6 = num;
						}
						continue;
					}
					case 19u:
						throw BEFBA9987F55444F(_003CModule_003E._390073C602714496<string>(-1881039676 ^ (int)obj._184044A093C04AF2(6, 2059651262u)));
					case 21u:
					{
						ptr = (_50E28FBE88E34375*)P_0;
						byte magic = *ptr->Magic;
						obj._184044A093C04AF2(11, 2313736621u);
						obj._184044A093C04AF2(10, 1166153459u);
						obj._184044A093C04AF2(5, 1334086547u);
						int num14;
						int num15;
						if (magic == _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x536D930B ^ obj._184044A093C04AF2(8, 449256499u))))
						{
							num14 = -809309023;
							num15 = num14;
						}
						else
						{
							num14 = -1274771517;
							num15 = num14;
						}
						num = num14 ^ (int)(num3 * 1816619540);
						continue;
					}
					case 17u:
						throw BEFBA9987F55444F(_003CModule_003E._390073C602714496<string>(-436096626 ^ (int)obj._184044A093C04AF2(10, 3206026219u)));
					case 2u:
					{
						byte b = ptr->Magic[_003CModule_003E._8B9C7B12B1AE4949<int>(-680842073 ^ (int)obj._184044A093C04AF2(2, 1756741873u))];
						obj._184044A093C04AF2(10, 1756741873u);
						int num11;
						int num12;
						if (b == _003CModule_003E._3F57E81A62734AC2<int>((int)(0x23C727 ^ obj._184044A093C04AF2(4, 0u))))
						{
							num11 = 1544384778;
							num12 = num11;
						}
						else
						{
							num11 = -417492084;
							num12 = num11;
						}
						num = num11 ^ (int)(num3 * 1090821479);
						continue;
					}
					case 8u:
						throw BEFBA9987F55444F(_003CModule_003E._390073C602714496<string>((int)(0x78D607CE ^ obj._184044A093C04AF2(10, 1639367654u))));
					case 5u:
					{
						int num7;
						int num8;
						if (ptr->Magic[_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x35739183 ^ obj._184044A093C04AF2(9, 1509525724u)))] != _003CModule_003E._390073C602714496<int>(-248867311 ^ (int)obj._184044A093C04AF2(9, 2785441572u)))
						{
							num7 = -1653846714;
							num8 = num7;
						}
						else
						{
							num7 = 1350417471;
							num8 = num7;
						}
						num = num7 ^ (int)(num3 * 1577628121);
						continue;
					}
					case 15u:
						throw BEFBA9987F55444F(_003CModule_003E._3F57E81A62734AC2<string>((int)(0xE0BD89D ^ obj._184044A093C04AF2(9, 1042834205u))));
					case 7u:
						obj = new _81DD83B8AA2247AA(959168979u);
						num = (int)(num3 * 1578152366) ^ -1515485536;
						continue;
					case 16u:
						memoryModule.alloc = P_2;
						memoryModule.free = P_3;
						memoryModule.getProcAddress = P_5;
						memoryModule.loadLibrary = P_4;
						memoryModule.freeLibrary = P_6;
						memoryModule.userdata = P_7;
						memoryModule.pageSize = (ulong)(long)A6796BC215504547(_003CModule_003E.F84FA79ABE6944BB<int>(-786109046 ^ (int)obj._184044A093C04AF2(8, 893549570u)));
						num = (int)(num3 * 754423462) ^ -1388381896;
						continue;
					case 13u:
						obj2 = (_7F042AF7ECCF4530)_2E267DA82520454E((byte*)P_0);
						num = -137476834;
						continue;
					case 18u:
					{
						int num4;
						int num5;
						if (ptr->Magic[_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x351130A3 ^ obj._184044A093C04AF2(9, 825864247u)))] != _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x588632DD ^ obj._184044A093C04AF2(5, 3469103049u))))
						{
							num4 = -1392215849;
							num5 = num4;
						}
						else
						{
							num4 = 653280380;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1463328552);
						continue;
					}
					case 6u:
						goto end_IL_0030;
					}
					goto IL_002b;
					continue;
					end_IL_0030:
					break;
				}
				break;
			}
		}
		catch (FBEA5B68721C48F2)
		{
			obj = new _81DD83B8AA2247AA(3439055932u);
			_795B0C994B1B4A98(intPtr);
			throw;
		}
		catch (Exception ex)
		{
			obj = new _81DD83B8AA2247AA(694974545u);
			Exception ex2 = ex;
			_795B0C994B1B4A98(intPtr);
			throw EBD707871A6E4847(_003CModule_003E.F84FA79ABE6944BB<string>((int)(0x4E5D06D0 ^ obj._184044A093C04AF2(0, 4274409477u))), (object)ex2);
		}
		obj = new _81DD83B8AA2247AA(3320687313u);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static bool _795B0C994B1B4A98(IntPtr P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3610223897u);
		if (P_0 == IntPtr.Zero)
		{
			goto IL_001c;
		}
		goto IL_023d;
		IL_001c:
		int num = -1469772958;
		goto IL_0021;
		IL_0021:
		MemoryModule memoryModule = default;
		int num8 = default;
		IntPtr[] dependencies = default;
		IntPtr intPtr = default;
		GCHandle gCHandle = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)((~(-(-(num2 ^ (--1597308531 * 211313917)))) + ~(-135856125 ^ -1850469701) - (unchecked(-998819801 * 575317248) - ~-859731196) + (471656556 - 1783724577)) ^ 0x333F96A5)) % 29)
			{
			case 25u:
				break;
			case 3u:
				obj._184044A093C04AF2(137, 4074416826u);
				num = (int)(num3 * 967680065) ^ -1509335252;
				continue;
			case 4u:
				D5F7E8787B544691((object)memoryModule.map);
				num = (int)((num3 * 761227726) ^ 0x5DC77B82);
				continue;
			case 23u:
				_64826DF2F55343F6(_6F59E495CF1B4376((object)memoryModule.map));
				num = (int)((num3 * 92333649) ^ 0x4BC2BBB1);
				continue;
			case 16u:
				obj._184044A093C04AF2(0, 1104638981u);
				num = 2123227187;
				continue;
			case 22u:
				_2F9B7352FB5C4699(memoryModule);
				num = ((int)num3 * -233910864) ^ 0x56850024;
				continue;
			case 6u:
				obj._184044A093C04AF2(132, 618186556u);
				num = -1979664585;
				continue;
			case 28u:
				_64826DF2F55343F6(memoryModule.symbolArrayPtr);
				num = ((int)num3 * -1787680588) ^ 0x62257873;
				continue;
			case 13u:
				obj._184044A093C04AF2(5, 2165469857u);
				num8 = _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x4F3642B4 ^ obj._184044A093C04AF2(8, 0u)));
				num = ((int)num3 * -409413846) ^ 0x389A3B55;
				continue;
			case 18u:
			{
				int num6;
				int num7;
				if (memoryModule.initialized)
				{
					num6 = -267376996;
					num7 = num6;
				}
				else
				{
					num6 = -1070199498;
					num7 = num6;
				}
				num = num6 ^ ((int)num3 * -13720942);
				continue;
			}
			case 19u:
			{
				int num11;
				int num12;
				if (memoryModule.dependencies != null)
				{
					num11 = 1592131739;
					num12 = num11;
				}
				else
				{
					num11 = 1145991390;
					num12 = num11;
				}
				num = num11 ^ ((int)num3 * -2146191578);
				continue;
			}
			case 9u:
				goto IL_023d;
			case 14u:
				num = (int)(num3 * 2130405002) ^ -1449061622;
				continue;
			case 0u:
				memoryModule.free(memoryModule.codeBase, (UIntPtr)(ulong)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x6943D332 ^ obj._184044A093C04AF2(2, 796088696u))), (MemoryAllocation)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x1C3FC92C ^ obj._184044A093C04AF2(2, 796088696u))), memoryModule.userdata);
				num = ((int)num3 * -1322242276) ^ 0x1A17B1B5;
				continue;
			case 15u:
				obj._184044A093C04AF2(134, 2549136249u);
				num = ((int)num3 * -106533335) ^ -1023636806;
				continue;
			case 5u:
			{
				obj._184044A093C04AF2(131, 2992813465u);
				int num9;
				int num10;
				if (num8 >= dependencies.Length)
				{
					num9 = -1518933838;
					num10 = num9;
				}
				else
				{
					num9 = 2061628505;
					num10 = num9;
				}
				num = num9 ^ (int)(num3 * 618129742);
				continue;
			}
			case 27u:
				return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x59810C2B ^ obj._184044A093C04AF2(10, 3668725446u))) != 0;
			case 21u:
				intPtr = dependencies[num8];
				num = -1215687241;
				continue;
			case 24u:
				num8 += _003CModule_003E._3F57E81A62734AC2<int>((int)(0x187A13FB ^ obj._184044A093C04AF2(1, 2165469857u)));
				num = (int)(num3 * 539947338) ^ -195538110;
				continue;
			case 17u:
				goto IL_038f;
			case 12u:
				A4546C5E1BC34ED9(memoryModule.map);
				num = ((int)num3 * -365033635) ^ 0x6EA1F72B;
				continue;
			case 10u:
				dependencies = memoryModule.dependencies;
				num = ((int)num3 * -1643013884) ^ -2070526031;
				continue;
			case 8u:
			{
				memoryModule = (MemoryModule)gCHandle.Target;
				int num4;
				int num5;
				if (memoryModule != null)
				{
					num4 = -1004430848;
					num5 = num4;
				}
				else
				{
					num4 = 859853378;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 329964718);
				continue;
			}
			case 20u:
				return (byte)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x13C8B08A ^ obj._184044A093C04AF2(4, 1986624183u))) != 0;
			case 26u:
				goto IL_0455;
			case 1u:
				goto IL_048a;
			case 11u:
				memoryModule.freeLibrary((void*)intPtr, memoryModule.userdata);
				num = (int)((num3 * 1432099453) ^ 0x32A5078A);
				continue;
			case 2u:
				obj._184044A093C04AF2(1, 3278915181u);
				num = 1093297855;
				continue;
			default:
				gCHandle.Free();
				return (byte)_003CModule_003E._390073C602714496<int>((int)(0xC4F66E6 ^ obj._184044A093C04AF2(1, 1177516307u))) != 0;
			}
			break;
			IL_048a:
			obj = new _81DD83B8AA2247AA(1204739754u);
			int num13;
			if (memoryModule.map != null)
			{
				num = 1694358749;
				num13 = num;
			}
			else
			{
				num = -1210108312;
				num13 = num;
			}
			continue;
			IL_0455:
			int num14;
			if (memoryModule.codeBase == (void*)(uint)_003CModule_003E._390073C602714496<int>(-387738086 ^ (int)obj._184044A093C04AF2(8, 1486775154u)))
			{
				num = 1426102509;
				num14 = num;
			}
			else
			{
				num = 2007686794;
				num14 = num;
			}
			continue;
			IL_038f:
			int num15;
			if (memoryModule.symbolArrayPtr != (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x2F1B215B ^ obj._184044A093C04AF2(2, 2036636195u))))
			{
				num = -1881192526;
				num15 = num;
			}
			else
			{
				num = 1724536795;
				num15 = num;
			}
		}
		goto IL_001c;
		IL_023d:
		obj._184044A093C04AF2(9, 678067956u);
		gCHandle = GCHandle.FromIntPtr(P_0);
		num = 1529401237;
		goto IL_0021;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _66A9E74204E54F09(IntPtr P_0, char* P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3569824278u);
		string key = default;
		GCHandle gCHandle = default;
		List<_4697E400134E4CA8> value = default;
		MemoryModule memoryModule = default;
		while (true)
		{
			int num = -1750271893;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((num2 + -1985842575 * --1276279964 * -829980729) * 1210996985) ^ 0x77291AD4)) % 8)
				{
				case 6u:
					break;
				case 3u:
					key = _47BF306900844384((IntPtr)P_1);
					gCHandle = GCHandle.FromIntPtr(P_0);
					num = ((int)num3 * -1180179072) ^ 0x20F8731F;
					continue;
				case 1u:
					return (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x39FF3435 ^ obj._184044A093C04AF2(5, 536427106u)));
				case 0u:
					obj._184044A093C04AF2(0, 1903485210u);
					num = ((int)num3 * -531293197) ^ 0x4AC3218A;
					continue;
				case 2u:
				{
					_4697E400134E4CA8? obj2 = value.FirstOrDefault();
					long num6;
					if (obj2 == null)
					{
						obj._184044A093C04AF2(6, 2312628697u);
						num6 = _003CModule_003E._390073C602714496<int>((int)(0x7A524CEC ^ obj._184044A093C04AF2(11, 0u)));
					}
					else
					{
						obj._184044A093C04AF2(10, 2312628697u);
						num6 = (long)B715417451164C01((object)obj2);
					}
					obj._184044A093C04AF2(6, 2010785004u);
					return (void*)num6;
				}
				case 5u:
				{
					obj._184044A093C04AF2(5, 3485422586u);
					int num7;
					if (!memoryModule.nameExportsTable.TryGetValue(key, out value))
					{
						num = -249532540;
						num7 = num;
					}
					else
					{
						num = -1743151824;
						num7 = num;
					}
					continue;
				}
				case 7u:
				{
					memoryModule = gCHandle.Target as MemoryModule;
					int num4;
					int num5;
					if (memoryModule != null)
					{
						num4 = 1763165868;
						num5 = num4;
					}
					else
					{
						num4 = 1642868280;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1192538623);
					continue;
				}
				default:
					return (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>(-1012768123 ^ (int)obj._184044A093C04AF2(6, 4123532490u));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void DD25C3AA7E904C37(ulong P_0, ulong P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(541153082u);
		if (P_0 < P_1)
		{
			goto IL_0010;
		}
		goto IL_008d;
		IL_0010:
		int num = 1762978938;
		goto IL_0015;
		IL_0015:
		int num2 = num;
		uint num3;
		switch ((num3 = (uint)((-(-(-num2 * -396346445 * -1485079209)) ^ -1515023443) * 835160203 * -1225582369)) % 4)
		{
		case 0u:
			break;
		default:
			return;
		case 3u:
			throw BEFBA9987F55444F(_003CModule_003E._8B9C7B12B1AE4949<string>(-1371221429 ^ (int)obj._184044A093C04AF2(8, 3303881143u)));
		case 2u:
			goto IL_008d;
		case 1u:
			return;
		}
		goto IL_0010;
		IL_008d:
		obj._184044A093C04AF2(1, 1587506403u);
		num = -1112087448;
		goto IL_0015;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ulong AFCDB19BC45E447C(ulong P_0, ulong P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2317968059u);
		return (ulong)(((long)(P_0 + P_1) - (long)_003CModule_003E._390073C602714496<int>((int)(0x4473C877 ^ obj._184044A093C04AF2(4, 4101837761u)))) & ~((long)P_1 - (long)_003CModule_003E.F84FA79ABE6944BB<int>(-1696147536 ^ (int)obj._184044A093C04AF2(0, 2902762190u))));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void* _859468254EF54D0F(void* P_0, int P_1)
	{
		return Unsafe.Add<byte>(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static ulong _866BF6AA2F8F4BB2(ulong P_0, ulong P_1)
	{
		return P_0 & (ulong)(~((long)P_1 - (long)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x5CA48FDD ^ new _81DD83B8AA2247AA(1660742681u)._184044A093C04AF2(8, 1396350149u)))));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void* _5859CBA88E8848A5(void* P_0, UIntPtr P_1)
	{
		return (void*)_866BF6AA2F8F4BB2((ulong)P_0, (ulong)P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void B037B093099A4DD1(MemoryModule P_0, _7F042AF7ECCF4530 P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1106577883u);
		ulong num8 = default;
		ulong num5 = default;
		List<AF4EA33D30884C93> list = default;
		AF4EA33D30884C93 current = default;
		ulong num6 = default;
		ulong num18 = default;
		byte* ptr2 = default;
		AF4EA33D30884C93 current2 = default;
		MmapProtectionFlags mmapProtectionFlags = default;
		while (true)
		{
			int num = 1355609856;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-(~(-(-(num2 - ~((--1001561495 * 198302845) ^ -1193636360))))) * -214672335 + (-741679328 ^ -1916522416)))) % 5)
				{
				case 3u:
					break;
				case 4u:
					return;
				case 2u:
					obj._184044A093C04AF2(6, 2025225506u);
					num = (int)(num3 * 919393437) ^ -35765020;
					continue;
				case 1u:
				{
					num8 = (ulong)_003CModule_003E.F84FA79ABE6944BB<int>(-958870901 ^ (int)obj._184044A093C04AF2(4, 2739631779u));
					num5 = (ulong)_003CModule_003E._58ECCB512F2A43AC<int>(-2043446809 ^ (int)obj._184044A093C04AF2(6, 1689263867u));
					A96A6382B424400A programHeaders = P_1.ProgramHeaders;
					Func<AF4EA33D30884C93, bool> predicate = (AF4EA33D30884C93 header) => header.Type == ElfProgramHeaderType.Load;
					obj = new _81DD83B8AA2247AA(600937873u);
					list = programHeaders.Where(predicate).ToList();
					int num24;
					if (list.Count != 0)
					{
						num = -1553169850;
						num24 = num;
					}
					else
					{
						num = -415473505;
						num24 = num;
					}
					continue;
				}
				default:
				{
					obj._184044A093C04AF2(0, 419387281u);
					List<AF4EA33D30884C93>.Enumerator enumerator = list.GetEnumerator();
					try
					{
						obj._184044A093C04AF2(4, 1802106942u);
						while (true)
						{
							IL_014f:
							int num4 = -195735945;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(~(-(~(-(-(num2 - ~((--1001561495 * 198302845) ^ -1193636360))))) * -214672335 + (-741679328 ^ -1916522416)))) % 10)
								{
								case 8u:
									break;
								default:
									goto end_IL_0154;
								case 9u:
									num4 = ((int)num3 * -1663807047) ^ 0x12E64FC2;
									continue;
								case 7u:
									obj._184044A093C04AF2(134, 2393747697u);
									obj._184044A093C04AF2(139, 566608401u);
									current = enumerator.Current;
									num4 = ((int)num3 * -66102034) ^ 0x29C6431C;
									continue;
								case 5u:
								{
									obj._184044A093C04AF2(4, 1599987670u);
									int num9;
									if (!enumerator.MoveNext())
									{
										num4 = 1980278879;
										num9 = num4;
									}
									else
									{
										num4 = 1051230510;
										num9 = num4;
									}
									continue;
								}
								case 0u:
									obj._184044A093C04AF2(136, 2212410654u);
									num4 = 1658748918;
									continue;
								case 3u:
									obj._184044A093C04AF2(1, 4077912989u);
									num4 = ((int)num3 * -948833976) ^ -2056669369;
									continue;
								case 2u:
								{
									ulong num7 = _44A00F79AC0E4853((object)current);
									num6 = num7 + _971F426DB65F4504((object)current);
									num8 = D30E9CC8AC6C4CFF(num8, num7);
									num4 = (int)(num3 * 2020066118) ^ -115592;
									continue;
								}
								case 4u:
									obj._184044A093C04AF2(129, 1826792401u);
									num4 = ((int)num3 * -1356989098) ^ -504411279;
									continue;
								case 6u:
									num5 = FAEEC58E9C3F4D11(num5, num6);
									num4 = ((int)num3 * -1023117915) ^ 0x2EDCF5E3;
									continue;
								case 1u:
									goto end_IL_0154;
								}
								goto IL_014f;
								continue;
								end_IL_0154:
								break;
							}
							break;
						}
					}
					finally
					{
						obj._184044A093C04AF2(136, 3699600072u);
						obj._184044A093C04AF2(137, 1609738094u);
						while (true)
						{
							IL_0309:
							int num10 = 1979000538;
							while (true)
							{
								num2 = num10;
								switch ((num3 = (uint)(~(-(~(-(-(num2 - ~((--1001561495 * 198302845) ^ -1193636360))))) * -214672335 + (-741679328 ^ -1916522416)))) % 3)
								{
								case 2u:
									break;
								default:
									goto end_IL_030e;
								case 1u:
									goto IL_035f;
								case 0u:
									goto end_IL_030e;
								}
								goto IL_0309;
								IL_035f:
								obj._184044A093C04AF2(138, 2393747697u);
								obj._184044A093C04AF2(135, 566608401u);
								((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								num10 = (int)((num3 * 1238342055) ^ 0x5E941792);
								continue;
								end_IL_030e:
								break;
							}
							break;
						}
					}
					ulong num11 = AFCDB19BC45E447C(num5 - num8, P_0.pageSize);
					void* ptr = P_0.alloc((void*)num8, (UIntPtr)num11, (MemoryAllocation)_003CModule_003E._3F57E81A62734AC2<int>(-1949609315 ^ (int)obj._184044A093C04AF2(8, 1047421430u)), (PageProtection)_003CModule_003E._8B9C7B12B1AE4949<int>(-1943644843 ^ (int)obj._184044A093C04AF2(4, 2346719148u)), P_0.userdata);
					while (true)
					{
						int num12 = 202901329;
						while (true)
						{
							num2 = num12;
							int num22;
							switch ((num3 = (uint)(~(-(~(-(-(num2 - ~((--1001561495 * 198302845) ^ -1193636360))))) * -214672335 + (-741679328 ^ -1916522416)))) % 4)
							{
							case 3u:
								break;
							case 1u:
							{
								int num23;
								if (ptr != (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-1312037537 ^ (int)obj._184044A093C04AF2(2, 1306163413u)))
								{
									num22 = -1104389985;
									num23 = num22;
								}
								else
								{
									num22 = 524228837;
									num23 = num22;
								}
								goto IL_047d;
							}
							case 2u:
								throw F323CED35BFC4720(_003CModule_003E._58ECCB512F2A43AC<string>(-118705000 ^ (int)obj._184044A093C04AF2(4, 3037980491u)));
							default:
								obj = new _81DD83B8AA2247AA(4061238970u);
								P_0.codeBase = ptr;
								P_0.codeSize = num11;
								enumerator = list.GetEnumerator();
								try
								{
									obj._184044A093C04AF2(5, 231580779u);
									while (true)
									{
										IL_07c3:
										obj._184044A093C04AF2(10, 1140095646u);
										int num13 = -1090699876;
										while (true)
										{
											num2 = num13;
											switch ((num3 = (uint)(~(-(~(-(-(num2 - ~((--1001561495 * 198302845) ^ -1193636360))))) * -214672335 + (-741679328 ^ -1916522416)))) % 11)
											{
											case 0u:
												num13 = -1623210406;
												continue;
											case 8u:
												throw BEFBA9987F55444F(_34ABD9DCB1D542B5(_003CModule_003E._3F57E81A62734AC2<string>(-1575360977 ^ (int)obj._184044A093C04AF2(0, 1219671756u)), (object)num18));
											case 5u:
												num18 = _866BF6AA2F8F4BB2((ulong)ptr2, P_0.pageSize);
												E91C55B720DB45E9((void*)ptr2, (void*)_2F54C4F2A19C4E8E((object)P_1, B622221CF61844E2((object)current2)), (uint)A9E832C2524E40BC((object)current2));
												mmapProtectionFlags = (MmapProtectionFlags)_003CModule_003E.F84FA79ABE6944BB<int>((int)(0x1FAFF41A ^ obj._184044A093C04AF2(5, 1665287018u)));
												num13 = ((int)num3 * -1574508470) ^ 0x2C81AA28;
												continue;
											case 6u:
												mmapProtectionFlags = (MmapProtectionFlags)((int)mmapProtectionFlags | _003CModule_003E._3F57E81A62734AC2<int>((int)(0x43E2D10F ^ obj._184044A093C04AF2(3, 0u))));
												num13 = ((int)num3 * -1765757658) ^ -16891295;
												continue;
											case 7u:
												obj._184044A093C04AF2(128, 3675905018u);
												obj._184044A093C04AF2(137, 3920637349u);
												obj._184044A093C04AF2(134, 2729483898u);
												num13 = -1211713605;
												continue;
											case 10u:
											{
												uint num16 = _485E2204693C4B5E((object)current2);
												if ((num16 & (uint)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x30124985 ^ obj._184044A093C04AF2(10, 3314242805u)))) != 0)
												{
													mmapProtectionFlags = (MmapProtectionFlags)((int)mmapProtectionFlags | _003CModule_003E._3F57E81A62734AC2<int>(-1953758323 ^ (int)obj._184044A093C04AF2(10, 0u)));
												}
												obj._184044A093C04AF2(7, 2543863774u);
												obj._184044A093C04AF2(6, 1908540493u);
												obj._184044A093C04AF2(1, 1169462221u);
												if ((num16 & (uint)_003CModule_003E._390073C602714496<int>(-240843671 ^ (int)obj._184044A093C04AF2(4, 1433345702u))) != 0)
												{
													obj = new _81DD83B8AA2247AA(3323917788u);
													mmapProtectionFlags = (MmapProtectionFlags)((int)mmapProtectionFlags | _003CModule_003E._8B9C7B12B1AE4949<int>(-2038760120 ^ (int)obj._184044A093C04AF2(7, 0u)));
												}
												int num17;
												if ((num16 & (uint)_003CModule_003E.F84FA79ABE6944BB<int>(-1685667373 ^ (int)obj._184044A093C04AF2(5, 2651122087u))) == 0)
												{
													num13 = 988726829;
													num17 = num13;
												}
												else
												{
													num13 = -492065576;
													num17 = num13;
												}
												continue;
											}
											case 3u:
											{
												current2 = enumerator.Current;
												ulong num21 = _44A00F79AC0E4853((object)current2);
												_971F426DB65F4504((object)current2);
												ptr2 = (byte*)ptr + num21 - num8;
												num13 = 1950171894;
												continue;
											}
											case 9u:
											{
												obj._184044A093C04AF2(135, 359209914u);
												int num19;
												int num20;
												if (_73270FF02EE64DF1((void*)num18, (UIntPtr)((ulong)((long)_971F426DB65F4504((object)current2) + (long)ptr2) - num18), mmapProtectionFlags) != IntPtr.Zero)
												{
													num19 = 1775251656;
													num20 = num19;
												}
												else
												{
													num19 = -877747555;
													num20 = num19;
												}
												num13 = num19 ^ (int)(num3 * 952952996);
												continue;
											}
											case 2u:
												break;
											case 1u:
											{
												int num14;
												int num15;
												if (!enumerator.MoveNext())
												{
													num14 = -380810561;
													num15 = num14;
												}
												else
												{
													num14 = -1369692316;
													num15 = num14;
												}
												num13 = num14 ^ (int)(num3 * 506900513);
												continue;
											}
											default:
												obj._184044A093C04AF2(4, 734975756u);
												goto end_IL_04f8;
											}
											goto IL_07c3;
											continue;
											end_IL_04f8:
											break;
										}
										break;
									}
								}
								finally
								{
									obj._184044A093C04AF2(136, 4040625398u);
									obj._184044A093C04AF2(137, 3920637349u);
									obj._184044A093C04AF2(130, 3779388644u);
									obj._184044A093C04AF2(131, 359209914u);
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
								}
								obj._184044A093C04AF2(4, 2726202245u);
								return;
							}
							break;
							IL_047d:
							num12 = num22 ^ (int)(num3 * 795023985);
						}
					}
				}
				}
				break;
			}
		}
	}

	private unsafe static void _294C6177A534426F(MemoryModule P_0, _7F042AF7ECCF4530 P_1)
	{
		AF4EA33D30884C93 aF4EA33D30884C = P_1.ProgramHeaders.FirstOrDefault((AF4EA33D30884C93 h) => h.Type == ElfProgramHeaderType.ThreadLocalStorage);
		if (aF4EA33D30884C == null)
		{
			goto IL_0031;
		}
		goto IL_011d;
		IL_011d:
		P_0.map = (LinkMap)_0B4815D418994E20();
		_09F89D1245EB4ECA((object)P_0.map, A64822CAFD2843BC((object)aF4EA33D30884C));
		_98C8A8371DBA4D03((object)P_0.map, _971F426DB65F4504((object)aF4EA33D30884C));
		F0D82998D85B4329((object)P_0.map, A9E832C2524E40BC((object)aF4EA33D30884C));
		byte* ptr = (byte*)_9106838A6F904831((uint)A9E832C2524E40BC((object)aF4EA33D30884C));
		int num = -429697228;
		goto IL_0036;
		IL_0036:
		ulong num4 = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(~(~(-((~(num2 * 1585084335) * 1944900559) ^ -1790145255)) ^ -1943875649))) % 6)
			{
			case 2u:
				break;
			default:
				return;
			case 3u:
				return;
			case 4u:
				_6D937E79DBCC4A27((object)P_0.map, num4);
				_0102DBCEA6344F02(P_0.map);
				num = ((int)num3 * -2116082227) ^ 0x5297255B;
				continue;
			case 1u:
			{
				byte* ptr2 = _2F54C4F2A19C4E8E((object)P_1, B622221CF61844E2((object)aF4EA33D30884C));
				E91C55B720DB45E9((void*)ptr, (void*)ptr2, (uint)A9E832C2524E40BC((object)aF4EA33D30884C));
				F929B03EF7F14704((object)P_0.map, (void*)ptr);
				num4 = _46078A6E86764C21();
				num = (int)(num3 * 1905996555) ^ -1783901946;
				continue;
			}
			case 5u:
				goto IL_011d;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0031;
		IL_0031:
		num = -577401944;
		goto IL_0036;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void D37E939616FA44A5(MemoryModule P_0, _7F042AF7ECCF4530 P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2984398874u);
		List<_1E7BC0C438DF4CB6> source = P_1.DynamicSectionHeader.DynamicSectionItems.ToList();
		Func<_1E7BC0C438DF4CB6, bool> predicate = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.StrTab;
		obj._184044A093C04AF2(9, 689532988u);
		_1E7BC0C438DF4CB6 obj2 = source.First(predicate);
		List<IntPtr> list = new List<IntPtr>();
		Func<_1E7BC0C438DF4CB6, bool> predicate2 = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.Needed;
		obj._184044A093C04AF2(9, 44468433u);
		IEnumerator<_1E7BC0C438DF4CB6> enumerator = source.Where(predicate2).GetEnumerator();
		try
		{
			obj._184044A093C04AF2(0, 2427418754u);
			byte* ptr2 = default;
			void* ptr = default;
			while (true)
			{
				IL_02e8:
				obj._184044A093C04AF2(0, 1707824604u);
				int num;
				int num2;
				if (!_5E1433D6AD6B4624((object)enumerator))
				{
					num = 1388356519;
					num2 = num;
				}
				else
				{
					num = 1198487078;
					num2 = num;
				}
				while (true)
				{
					int num3 = num;
					uint num4;
					switch ((num4 = (uint)(((((-num3 - (((-(~279546060 + ~-1579542692) + (-(-1141994168 ^ 0x72B145CB) - -2085113247)) ^ -1697624967) + unchecked(~unchecked((0x3C61F7ED ^ 0x7EDCDE99) * 1940551139) * -2078099297))) ^ -2120309834) - ~(~(0x4B1B1A36 ^ -527655617)) - (-unchecked(-506272580 - 2001326149) ^ -1753885847)) * -1233808905) ^ -391787397 ^ 0x64640317)) % 10)
					{
					case 6u:
						num = 1198487078;
						continue;
					default:
						goto end_IL_00a8;
					case 9u:
					{
						_1E7BC0C438DF4CB6 current = enumerator.Current;
						ptr2 = _2F54C4F2A19C4E8E((object)P_1, (ulong)_2017DABDBE874768((object)obj2) + _1540D1CE0F194D87((object)current));
						ptr = P_0.loadLibrary((char*)ptr2, P_0.userdata);
						num = -411724732;
						continue;
					}
					case 2u:
						P_0.dependencies = list.ToArray();
						throw BEFBA9987F55444F(_96D1BCE786D04E0E(_003CModule_003E._58ECCB512F2A43AC<string>((int)(0x2B3DA3D0 ^ obj._184044A093C04AF2(9, 2286154935u))), _47BF306900844384((IntPtr)ptr2)));
					case 4u:
						list.Add((IntPtr)ptr);
						num = (int)(num4 * 656220848) ^ -1394598334;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (ptr == (void*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>(-1123887438 ^ (int)obj._184044A093C04AF2(4, 2494194665u)))
						{
							num5 = -1041235867;
							num6 = num5;
						}
						else
						{
							num5 = -269158126;
							num6 = num5;
						}
						num = num5 ^ (int)(num4 * 1436346428);
						continue;
					}
					case 0u:
						obj._184044A093C04AF2(129, 3999224743u);
						obj._184044A093C04AF2(138, 3137846234u);
						obj._184044A093C04AF2(135, 4144497946u);
						num = ((int)num4 * -771440299) ^ 0x331D3A57;
						continue;
					case 8u:
						obj._184044A093C04AF2(8, 837773858u);
						num = ((int)num4 * -738712234) ^ 0x74BFBDF8;
						continue;
					case 3u:
						break;
					case 7u:
						obj._184044A093C04AF2(136, 521574872u);
						num = -504402625;
						continue;
					case 1u:
						goto end_IL_00a8;
					}
					goto IL_02e8;
					continue;
					end_IL_00a8:
					break;
				}
				break;
			}
		}
		finally
		{
			obj = new _81DD83B8AA2247AA(3660965243u);
			while (true)
			{
				IL_033c:
				int num7 = -1769579352;
				while (true)
				{
					int num3 = num7;
					uint num4;
					switch ((num4 = (uint)(((((-num3 - (((-(~279546060 + ~-1579542692) + (-(-1141994168 ^ 0x72B145CB) - -2085113247)) ^ -1697624967) + unchecked(~unchecked((0x3C61F7ED ^ 0x7EDCDE99) * 1940551139) * -2078099297))) ^ -2120309834) - ~(~(0x4B1B1A36 ^ -527655617)) - (-unchecked(-506272580 - 2001326149) ^ -1753885847)) * -1233808905) ^ -391787397 ^ 0x64640317)) % 6)
					{
					case 0u:
						break;
					default:
						goto end_IL_0341;
					case 1u:
						obj._184044A093C04AF2(8, 3586114557u);
						num7 = 322359702;
						continue;
					case 4u:
						_4CEA51BDE5AA4E75((object)enumerator);
						num7 = ((int)num4 * -1836105210) ^ -1099922890;
						continue;
					case 3u:
						obj._184044A093C04AF2(5, 295518572u);
						obj._184044A093C04AF2(6, 2189087041u);
						obj._184044A093C04AF2(11, 2752571873u);
						num7 = (int)((num4 * 2143677208) ^ 0x2630377F);
						continue;
					case 5u:
					{
						int num8;
						int num9;
						if (enumerator != null)
						{
							num8 = 2105877017;
							num9 = num8;
						}
						else
						{
							num8 = 920415752;
							num9 = num8;
						}
						num7 = num8 ^ (int)(num4 * 99115198);
						continue;
					}
					case 2u:
						goto end_IL_0341;
					}
					goto IL_033c;
					continue;
					end_IL_0341:
					break;
				}
				break;
			}
		}
		obj._184044A093C04AF2(5, 3894922173u);
		P_0.dependencies = list.ToArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _4DD8CE92B45A41BD(MemoryModule P_0, _7F042AF7ECCF4530 P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(367432196u);
		_003C_003Ec__DisplayClass27_0 obj3 = default;
		List<_1E7BC0C438DF4CB6> list = default;
		_4697E400134E4CA8 current = default;
		string key = default;
		while (true)
		{
			int num = 63895728;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-256277785 + 243733170 - -((~((num2 - ~((-(~(-unchecked(1326033092 - -904722434))) ^ ~(-(~1119507314 - (-2083674906 ^ 0x6D961511)))) + -1405230681 * ((--1218987395 ^ 0x3F40CFF2 ^ 0x901204A) + (~(~2050416023) - (0x2AAAF412 ^ 0x3547C885))))) * 1052960203) ^ ~(-unchecked(~-440885779 + unchecked(-766272319 * -1136166094)))) - -258840222)) * -667883155)) % 6)
				{
				case 0u:
					break;
				case 5u:
					obj3 = (_003C_003Ec__DisplayClass27_0)_85C8DCFDC56E46E9();
					num = (int)(num3 * 288885625) ^ -597419539;
					continue;
				case 4u:
					P_0.symbolArrayPtr = (void*)(uint)_003CModule_003E._3F57E81A62734AC2<int>(-502704446 ^ (int)obj._184044A093C04AF2(9, 0u));
					P_0.nameExportsTable = null;
					num = (int)((num3 * 1033534796) ^ 0x2AA2AB92);
					continue;
				case 1u:
				{
					list = P_1.DynamicSectionHeader.DynamicSectionItems.ToList();
					_003C_003Ec__DisplayClass27_0 obj7 = obj3;
					List<_1E7BC0C438DF4CB6> source = list;
					Func<_1E7BC0C438DF4CB6, bool> predicate = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.SymTab;
					obj._184044A093C04AF2(0, 441194783u);
					obj7.symbolTable = source.FirstOrDefault(predicate);
					int num15;
					if (obj3.symbolTable != null)
					{
						num = -1275830526;
						num15 = num;
					}
					else
					{
						num = 1635499735;
						num15 = num;
					}
					continue;
				}
				case 2u:
					P_0.symbolArray = null;
					num = ((int)num3 * -666883331) ^ 0x39D54BEB;
					continue;
				default:
				{
					_9F61EB4FCBA44886 obj2 = P_1.SectionHeaders.First(obj3._003CResolveSymbols_003Eb__1);
					P_0.symbolArrayPtr = _9106838A6F904831((uint)_5FBDB97C5DD74801((object)obj2));
					E91C55B720DB45E9(P_0.symbolArrayPtr, (void*)_2F54C4F2A19C4E8E((object)P_1, _218FE6C854D6408D((object)obj2)), (uint)_5FBDB97C5DD74801((object)obj2));
					_06E00CD4BCAE4936 obj4 = (P_0.symbolArray = (_06E00CD4BCAE4936)CBFD5F73E938436E((byte*)P_0.symbolArrayPtr, (ulong)_003CModule_003E._390073C602714496<int>((int)(0x109C1667 ^ obj._184044A093C04AF2(4, 2537187365u))), _5FBDB97C5DD74801((object)obj2) / _3A65438579D14862((object)obj2)));
					_1E7BC0C438DF4CB6 obj5 = list.First((_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.StrTab);
					CBD209469E2A430D cBD209469E2A430D = (CBD209469E2A430D)F73F9A44363F40B1(_2F54C4F2A19C4E8E((object)P_1, (ulong)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x638950F8 ^ obj._184044A093C04AF2(9, 1486741213u)))), _1540D1CE0F194D87((object)obj5));
					P_0.nameExportsTable = new Dictionary<string, List<_4697E400134E4CA8>>();
					IEnumerator<_4697E400134E4CA8> enumerator = obj4.GetEnumerator();
					try
					{
						obj = new _81DD83B8AA2247AA(3737873160u);
						while (true)
						{
							IL_0297:
							int num4 = -669807633;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)((-256277785 + 243733170 - -((~((num2 - ~((-(~(-unchecked(1326033092 - -904722434))) ^ ~(-(~1119507314 - (-2083674906 ^ 0x6D961511)))) + -1405230681 * ((--1218987395 ^ 0x3F40CFF2 ^ 0x901204A) + (~(~2050416023) - (0x2AAAF412 ^ 0x3547C885))))) * 1052960203) ^ ~(-unchecked(~-440885779 + unchecked(-766272319 * -1136166094)))) - -258840222)) * -667883155)) % 13)
								{
								case 3u:
									break;
								case 2u:
									num4 = (int)((num3 * 824082189) ^ 0x7875E503);
									continue;
								case 8u:
								{
									obj._184044A093C04AF2(0, 3321578735u);
									int num11;
									if (_5E1433D6AD6B4624((object)enumerator))
									{
										num4 = 1355596289;
										num11 = num4;
									}
									else
									{
										num4 = 656393008;
										num11 = num4;
									}
									continue;
								}
								case 1u:
								{
									int num7;
									int num8;
									if (CB5AE2D7DE644F61((object)current) != 0L)
									{
										num7 = 1245741040;
										num8 = num7;
									}
									else
									{
										num7 = -1512748534;
										num8 = num7;
									}
									num4 = num7 ^ (int)(num3 * 274851525);
									continue;
								}
								case 7u:
									obj._184044A093C04AF2(8, 4206732555u);
									num4 = ((int)num3 * -896608860) ^ 0x47D95FD8;
									continue;
								case 4u:
								{
									int num9;
									int num10;
									if (P_0.nameExportsTable.ContainsKey(key))
									{
										num9 = -2027917722;
										num10 = num9;
									}
									else
									{
										num9 = -875070149;
										num10 = num9;
									}
									num4 = num9 ^ ((int)num3 * -1347591868);
									continue;
								}
								case 10u:
									current = enumerator.Current;
									num4 = -399552264;
									continue;
								case 6u:
									obj._184044A093C04AF2(0, 4206732555u);
									obj._184044A093C04AF2(9, 1334227621u);
									obj._184044A093C04AF2(6, 3427903947u);
									obj._184044A093C04AF2(3, 1399730715u);
									P_0.nameExportsTable.Add(key, new List<_4697E400134E4CA8> { current });
									num4 = -2076543249;
									continue;
								case 9u:
								{
									key = _76DA2DE12CBF4EEB((object)current, (object)cBD209469E2A430D);
									int num5;
									int num6;
									if ((int)_85AAA8FAF3984FB8((object)current) != _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0xCE62E80 ^ obj._184044A093C04AF2(6, 1625822364u))))
									{
										num5 = 1990737424;
										num6 = num5;
									}
									else
									{
										num5 = 1275121053;
										num6 = num5;
									}
									num4 = num5 ^ (int)(num3 * 1487559324);
									continue;
								}
								case 0u:
								{
									_4697E400134E4CA8 obj6 = current;
									_691CAD673A344C78((object)obj6, CB5AE2D7DE644F61((object)obj6) + (ulong)P_0.codeBase);
									num4 = (int)((num3 * 1354000049) ^ 0x6A83E9);
									continue;
								}
								case 11u:
									obj = new _81DD83B8AA2247AA(2473362339u);
									num4 = 1897672439;
									continue;
								case 12u:
									obj._184044A093C04AF2(1, 1334227621u);
									obj._184044A093C04AF2(2, 3427903947u);
									obj._184044A093C04AF2(7, 1399730715u);
									P_0.nameExportsTable[key].Add(current);
									num4 = ((int)num3 * -198112764) ^ -1097404333;
									continue;
								default:
									obj._184044A093C04AF2(1, 1221788098u);
									goto end_IL_029c;
								}
								goto IL_0297;
								continue;
								end_IL_029c:
								break;
							}
							break;
						}
					}
					finally
					{
						obj = new _81DD83B8AA2247AA(244381808u);
						while (true)
						{
							IL_0592:
							int num12 = 766592374;
							while (true)
							{
								num2 = num12;
								switch ((num3 = (uint)((-256277785 + 243733170 - -((~((num2 - ~((-(~(-unchecked(1326033092 - -904722434))) ^ ~(-(~1119507314 - (-2083674906 ^ 0x6D961511)))) + -1405230681 * ((--1218987395 ^ 0x3F40CFF2 ^ 0x901204A) + (~(~2050416023) - (0x2AAAF412 ^ 0x3547C885))))) * 1052960203) ^ ~(-unchecked(~-440885779 + unchecked(-766272319 * -1136166094)))) - -258840222)) * -667883155)) % 5)
								{
								case 3u:
									break;
								case 4u:
								{
									int num13;
									int num14;
									if (enumerator != null)
									{
										num13 = -46299094;
										num14 = num13;
									}
									else
									{
										num13 = 1408911208;
										num14 = num13;
									}
									num12 = num13 ^ (int)(num3 * 92326234);
									continue;
								}
								case 0u:
									_4CEA51BDE5AA4E75((object)enumerator);
									num12 = ((int)num3 * -1932665612) ^ 0x33459186;
									continue;
								case 2u:
									obj._184044A093C04AF2(8, 1309603479u);
									obj._184044A093C04AF2(5, 3892578906u);
									num12 = 930488625;
									continue;
								default:
									obj._184044A093C04AF2(6, 2712696u);
									obj._184044A093C04AF2(7, 2052514152u);
									goto end_IL_0597;
								}
								goto IL_0592;
								continue;
								end_IL_0597:
								break;
							}
							break;
						}
					}
					obj._184044A093C04AF2(6, 432923053u);
					return;
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _569686D00A854548(MemoryModule P_0, _7F042AF7ECCF4530 P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1638545759u);
		_003C_003Ec__DisplayClass28_0 CS_0024_003C_003E8__locals3 = (_003C_003Ec__DisplayClass28_0)AD13CD4BF2EB430D();
		List<_1E7BC0C438DF4CB6> list = default;
		_1E7BC0C438DF4CB6 obj3 = default;
		_1E7BC0C438DF4CB6 obj4 = default;
		_1E7BC0C438DF4CB6 obj2 = default;
		_5D1CA4FB0960430A obj6 = default;
		F94D8F12CF5B448C current = default;
		ushort* ptr2 = default;
		void** ptr = default;
		IntPtr intPtr = default;
		byte* codeBase = default;
		while (true)
		{
			int num = 1351157518;
			while (true)
			{
				int num2 = num;
				IEnumerable<F94D8F12CF5B448C> first;
				List<_1E7BC0C438DF4CB6> source4;
				Func<_1E7BC0C438DF4CB6, bool> predicate4;
				IEnumerable<F94D8F12CF5B448C> second;
				IEnumerator<F94D8F12CF5B448C> enumerator;
				uint num3;
				switch ((num3 = (uint)(-(-(num2 * -1518930325)) - ((--1366707368 * -1145398321) ^ -1538055338))) % 6)
				{
				case 5u:
					break;
				case 1u:
				{
					List<_1E7BC0C438DF4CB6> source2 = list;
					Func<_1E7BC0C438DF4CB6, bool> predicate2 = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.RelaSz;
					obj._184044A093C04AF2(9, 2072914325u);
					obj3 = source2.FirstOrDefault(predicate2);
					List<_1E7BC0C438DF4CB6> source3 = list;
					Func<_1E7BC0C438DF4CB6, bool> predicate3 = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.RelaEnt;
					obj._184044A093C04AF2(6, 2624147049u);
					obj4 = source3.FirstOrDefault(predicate3);
					num = 1663396902;
					continue;
				}
				case 4u:
					if (obj2 != null)
					{
						num = (int)((num3 * 391287621) ^ 0x7F55FBDC);
						continue;
					}
					obj._184044A093C04AF2(5, 582136240u);
					first = Enumerable.Empty<F94D8F12CF5B448C>();
					goto IL_01ce;
				case 2u:
					list = P_1.DynamicSectionHeader.DynamicSectionItems.ToList();
					num = ((int)num3 * -915641381) ^ 0x56E52F17;
					continue;
				case 3u:
				{
					List<_1E7BC0C438DF4CB6> source = list;
					Func<_1E7BC0C438DF4CB6, bool> predicate = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.Rela;
					obj._184044A093C04AF2(6, 2579598985u);
					obj2 = source.FirstOrDefault(predicate);
					num = 1166329665;
					continue;
				}
				default:
					{
						obj._184044A093C04AF2(5, 582136240u);
						IEnumerable<F94D8F12CF5B448C> enumerable = (IEnumerable<F94D8F12CF5B448C>)_9FFF279F4AC8445D(_2F54C4F2A19C4E8E((object)P_1, (ulong)_003CModule_003E.F84FA79ABE6944BB<int>(-4856022 ^ (int)obj._184044A093C04AF2(2, 0u))), _1540D1CE0F194D87((object)obj2), _1540D1CE0F194D87((object)obj3) / _1540D1CE0F194D87((object)obj4));
						first = enumerable;
						goto IL_01ce;
					}
					IL_01ce:
					obj._184044A093C04AF2(5, 299244155u);
					source4 = list;
					predicate4 = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.JmpRel;
					obj._184044A093C04AF2(8, 1683301295u);
					CS_0024_003C_003E8__locals3.jumpRel = source4.FirstOrDefault(predicate4);
					second = Enumerable.Empty<F94D8F12CF5B448C>();
					if (CS_0024_003C_003E8__locals3.jumpRel != null)
					{
						_9F61EB4FCBA44886 obj5 = P_1.SectionHeaders.FirstOrDefault((_9F61EB4FCBA44886 header) => header.Offset == CS_0024_003C_003E8__locals3.jumpRel.Value);
						second = (IEnumerable<F94D8F12CF5B448C>)_9FFF279F4AC8445D(_2F54C4F2A19C4E8E((object)P_1, (ulong)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x107BB85D ^ obj._184044A093C04AF2(2, 0u)))), _218FE6C854D6408D((object)obj5), _5FBDB97C5DD74801((object)obj5) / _3A65438579D14862((object)obj5));
					}
					obj._184044A093C04AF2(8, 1258935193u);
					enumerator = first.Concat(second).GetEnumerator();
					try
					{
						obj._184044A093C04AF2(6, 2882364116u);
						while (true)
						{
							IL_0428:
							obj._184044A093C04AF2(0, 691941522u);
							int num4 = -1724119357;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(-(-(num2 * -1518930325)) - ((--1366707368 * -1145398321) ^ -1538055338))) % 39)
								{
								case 33u:
									num4 = 1376443911;
									continue;
								case 24u:
									obj = new _81DD83B8AA2247AA(585800313u);
									num4 = -1821319683;
									continue;
								case 2u:
								{
									obj6 = _7871A055BF3B46D5((object)current);
									int num7;
									int num8;
									if (!obj6.IsGlobDat())
									{
										num7 = -1379245345;
										num8 = num7;
									}
									else
									{
										num7 = -218226388;
										num8 = num7;
									}
									num4 = num7 ^ ((int)num3 * -1254342184);
									continue;
								}
								case 12u:
									ptr2 = (ushort*)ptr;
									num4 = (int)((num3 * 2131881618) ^ 0x585C93B5);
									continue;
								case 32u:
								{
									obj._184044A093C04AF2(4, 1164172635u);
									obj6 = _7871A055BF3B46D5((object)current);
									int num19;
									if (!obj6.IsModule())
									{
										num4 = 811324423;
										num19 = num4;
									}
									else
									{
										num4 = -925911286;
										num19 = num4;
									}
									continue;
								}
								case 6u:
									break;
								case 25u:
								{
									int num13;
									int num14;
									if (!obj6.IsOffset())
									{
										num13 = 217914659;
										num14 = num13;
									}
									else
									{
										num13 = 692488694;
										num14 = num13;
									}
									num4 = num13 ^ (int)(num3 * 870429755);
									continue;
								}
								case 29u:
									obj._184044A093C04AF2(10, 1384451212u);
									num4 = (int)(num3 * 1067314713) ^ -1340331353;
									continue;
								case 3u:
									obj6 = _7871A055BF3B46D5((object)current);
									num4 = ((int)num3 * -1340351936) ^ -2126997605;
									continue;
								case 26u:
									obj._184044A093C04AF2(8, 1474827324u);
									obj._184044A093C04AF2(10, 1384451212u);
									*ptr = (void*)((ulong)(long)intPtr + _5D62B0180D50400E((object)current));
									num4 = 1854845776;
									continue;
								case 18u:
									throw C76A156BA0634614(_34ABD9DCB1D542B5(_003CModule_003E._3F57E81A62734AC2<string>(-480705245 ^ (int)obj._184044A093C04AF2(8, 4093972120u)), (object)_7871A055BF3B46D5((object)current)));
								case 11u:
								{
									int num17;
									int num18;
									if (!_5E1433D6AD6B4624((object)enumerator))
									{
										num17 = 1494892899;
										num18 = num17;
									}
									else
									{
										num17 = 119169447;
										num18 = num17;
									}
									num4 = num17 ^ (int)(num3 * 265595360);
									continue;
								}
								case 13u:
									obj6 = _7871A055BF3B46D5((object)current);
									num4 = (int)((num3 * 695000962) ^ 0x19A658F4);
									continue;
								case 4u:
								{
									obj._184044A093C04AF2(10, 829877331u);
									_4697E400134E4CA8 obj7 = P_0.symbolArray[_14405C03C90542F4((object)current)];
									*ptr = (void*)CB5AE2D7DE644F61((object)obj7);
									num4 = (int)((num3 * 279411113) ^ 0x4F41EF0);
									continue;
								}
								case 28u:
									obj6 = _7871A055BF3B46D5((object)current);
									num4 = (int)((num3 * 937251938) ^ 0x1B9F862);
									continue;
								case 15u:
								{
									int num9;
									int num10;
									if (!obj6.IsRelative())
									{
										num9 = 480110725;
										num10 = num9;
									}
									else
									{
										num9 = 1867007026;
										num10 = num9;
									}
									num4 = num9 ^ (int)(num3 * 1920617108);
									continue;
								}
								case 14u:
								{
									obj6 = _7871A055BF3B46D5((object)current);
									int num22;
									int num23;
									if (!obj6.Is16())
									{
										num22 = 250919134;
										num23 = num22;
									}
									else
									{
										num22 = -387705307;
										num23 = num22;
									}
									num4 = num22 ^ ((int)num3 * -306200959);
									continue;
								}
								case 34u:
									num4 = (int)(num3 * 398121962) ^ -871587396;
									continue;
								case 7u:
									obj._184044A093C04AF2(0, 812136294u);
									num4 = ((int)num3 * -41161316) ^ -1036287690;
									continue;
								case 27u:
									obj._184044A093C04AF2(10, 2052215058u);
									num4 = (int)(num3 * 427315160) ^ -2036342387;
									continue;
								case 1u:
									obj._184044A093C04AF2(6, 1384451212u);
									num4 = -329389972;
									continue;
								case 20u:
									obj._184044A093C04AF2(0, 3869370000u);
									obj._184044A093C04AF2(9, 2246789670u);
									num4 = 467230263;
									continue;
								case 17u:
									obj._184044A093C04AF2(8, 812136294u);
									obj._184044A093C04AF2(10, 1384451212u);
									*ptr = (void*)CCE1B618FACE4982((object)P_0.map);
									num4 = (int)(num3 * 1264239801) ^ -976998264;
									continue;
								case 19u:
								{
									int num20;
									int num21;
									if (!obj6.IsJmpSlot())
									{
										num20 = 1122011561;
										num21 = num20;
									}
									else
									{
										num20 = -119037506;
										num21 = num20;
									}
									num4 = num20 ^ ((int)num3 * -1842837725);
									continue;
								}
								case 8u:
									current = enumerator.Current;
									num4 = ((int)num3 * -596092161) ^ -1736486274;
									continue;
								case 21u:
									obj._184044A093C04AF2(8, 1474827324u);
									obj6 = _7871A055BF3B46D5((object)current);
									num4 = ((int)num3 * -273406199) ^ 0x654177E;
									continue;
								case 16u:
									obj._184044A093C04AF2(4, 1963715133u);
									num4 = ((int)num3 * -1558112211) ^ 0x777091A0;
									continue;
								case 31u:
									obj._184044A093C04AF2(8, 585367041u);
									num4 = 785932620;
									continue;
								case 35u:
									obj._184044A093C04AF2(8, 1474827324u);
									*ptr = codeBase + _5D62B0180D50400E((object)current);
									num4 = ((int)num3 * -548227682) ^ 0x7557EDA3;
									continue;
								case 22u:
									*ptr2 = (ushort)((ulong)(long)intPtr + _5D62B0180D50400E((object)current));
									num4 = ((int)num3 * -337583353) ^ -1939462509;
									continue;
								case 30u:
									num4 = ((int)num3 * -129077731) ^ 0x399F482A;
									continue;
								case 9u:
									num4 = (int)((num3 * 2130022755) ^ 0x101FB321);
									continue;
								case 36u:
								{
									int num15;
									int num16;
									if (!obj6.Is64())
									{
										num15 = 1948167113;
										num16 = num15;
									}
									else
									{
										num15 = -237835356;
										num16 = num15;
									}
									num4 = num15 ^ (int)(num3 * 838626375);
									continue;
								}
								case 23u:
									obj._184044A093C04AF2(10, 1676927199u);
									num4 = 697848922;
									continue;
								case 5u:
								{
									obj6 = _7871A055BF3B46D5((object)current);
									int num11;
									int num12;
									if (obj6.IsNone())
									{
										num11 = 771267205;
										num12 = num11;
									}
									else
									{
										num11 = 530647239;
										num12 = num11;
									}
									num4 = num11 ^ (int)(num3 * 86107571);
									continue;
								}
								case 0u:
									intPtr = B8E2402FB4794704(P_0, current);
									num4 = (int)((num3 * 1002822682) ^ 0x1CE3D7F5);
									continue;
								case 37u:
								{
									codeBase = (byte*)P_0.codeBase;
									ptr = (void**)(codeBase + _8868C9572BC84B4F((object)current));
									intPtr = IntPtr.Zero;
									int num5;
									int num6;
									if (!FD4EE0C92EFF4343((object)current))
									{
										num5 = -325988809;
										num6 = num5;
									}
									else
									{
										num5 = -1919977278;
										num6 = num5;
									}
									num4 = num5 ^ ((int)num3 * -1640257962);
									continue;
								}
								case 10u:
									obj._184044A093C04AF2(11, 2429720090u);
									num4 = ((int)num3 * -854725666) ^ -363238583;
									continue;
								default:
									obj._184044A093C04AF2(6, 2810949691u);
									goto end_IL_02a9;
								}
								goto IL_0428;
								continue;
								end_IL_02a9:
								break;
							}
							break;
						}
					}
					finally
					{
						obj = new _81DD83B8AA2247AA(3033458972u);
						if (enumerator != null)
						{
							goto IL_0914;
						}
						goto IL_09b4;
						IL_0914:
						int num24 = 2071146674;
						goto IL_0919;
						IL_0919:
						while (true)
						{
							num2 = num24;
							switch ((num3 = (uint)(-(-(num2 * -1518930325)) - ((--1366707368 * -1145398321) ^ -1538055338))) % 5)
							{
							case 0u:
								break;
							default:
								goto end_IL_0901;
							case 1u:
								_4CEA51BDE5AA4E75((object)enumerator);
								num24 = ((int)num3 * -1573154258) ^ 0x5EB5499D;
								continue;
							case 4u:
								obj._184044A093C04AF2(3, 423633469u);
								num24 = (int)((num3 * 386162136) ^ 0x1A4FA946);
								continue;
							case 3u:
								goto IL_09b4;
							case 2u:
								goto end_IL_0901;
							}
							break;
						}
						goto IL_0914;
						IL_09b4:
						obj._184044A093C04AF2(8, 3459006983u);
						obj._184044A093C04AF2(1, 3802461379u);
						obj._184044A093C04AF2(6, 989358700u);
						num24 = 436151472;
						goto IL_0919;
						end_IL_0901:;
					}
					obj._184044A093C04AF2(6, 1381405989u);
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static IntPtr B8E2402FB4794704(MemoryModule P_0, F94D8F12CF5B448C P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1356742547u);
		IntPtr[] dependencies = default;
		int num10 = default;
		_4697E400134E4CA8 obj2 = default;
		IntPtr result = default;
		IntPtr intPtr = default;
		while (true)
		{
			int num = -1492997996;
			while (true)
			{
				int num2 = num;
				int num6;
				uint num3;
				switch ((num3 = (uint)((-(((~num2 + 1723385631 * (-541463897 * (222757035 * -unchecked(940235443 * -357240541) - unchecked(-479469523 * -224066510)))) ^ (~unchecked(-1269138187 * -1550503369) + -(0x7ACD6A6D ^ -2123694724) + (0x2D01EC86 ^ (--1040566583 ^ 0x421C203A)) - ((0x3B942357 ^ 0x5EE3D1F0) - ((3621235 * -1074832611) ^ 0x7CEF1B2A)))) - -(--130442884)) * 68324949 * -1811387551) ^ 0x186C9995)) % 7)
				{
				case 5u:
					break;
				case 3u:
					dependencies = P_0.dependencies;
					obj._184044A093C04AF2(3, 1216630012u);
					obj._184044A093C04AF2(1, 3850701316u);
					obj._184044A093C04AF2(6, 2055854468u);
					num10 = _003CModule_003E._390073C602714496<int>(-700681900 ^ (int)obj._184044A093C04AF2(8, 2879498721u));
					goto IL_0613;
				case 4u:
					return (IntPtr)(long)CB5AE2D7DE644F61((object)obj2);
				case 1u:
					obj2 = P_0.symbolArray[_14405C03C90542F4((object)P_1)];
					num = ((int)num3 * -832979729) ^ 0x3EA1ACB5;
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (CB5AE2D7DE644F61((object)obj2) != 0L)
					{
						num4 = -1364475301;
						num5 = num4;
					}
					else
					{
						num4 = 907491931;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1007013803);
					continue;
				}
				case 6u:
					obj._184044A093C04AF2(10, 2292628449u);
					num = (int)(num3 * 1087238273) ^ -395292618;
					continue;
				default:
					{
						obj = new _81DD83B8AA2247AA(2514791617u);
						IntPtr intPtr2 = dependencies[num10];
						IntPtr intPtr3 = _2E00853FE0304BD9(_71B74A99B440438C((object)obj2));
						try
						{
							void* ptr = P_0.getProcAddress((void*)intPtr2, (char*)(void*)intPtr3, P_0.userdata);
							if (ptr != (void*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-18836500 ^ (int)obj._184044A093C04AF2(8, 2966879889u)))
							{
								goto IL_0226;
							}
							goto IL_035f;
							IL_0226:
							int num11 = -1821684121;
							goto IL_022b;
							IL_022b:
							while (true)
							{
								num2 = num11;
								switch ((num3 = (uint)((-(((~num2 + 1723385631 * (-541463897 * (222757035 * -unchecked(940235443 * -357240541) - unchecked(-479469523 * -224066510)))) ^ (~unchecked(-1269138187 * -1550503369) + -(0x7ACD6A6D ^ -2123694724) + (0x2D01EC86 ^ (--1040566583 ^ 0x421C203A)) - ((0x3B942357 ^ 0x5EE3D1F0) - ((3621235 * -1074832611) ^ 0x7CEF1B2A)))) - -(--130442884)) * 68324949 * -1811387551) ^ 0x186C9995)) % 7)
								{
								case 3u:
									break;
								case 1u:
									obj = new _81DD83B8AA2247AA(18931863u);
									_691CAD673A344C78((object)obj2, (ulong)ptr);
									num11 = (int)((num3 * 715279784) ^ 0x3DF5D496);
									continue;
								case 0u:
									result = (IntPtr)(long)CB5AE2D7DE644F61((object)obj2);
									num11 = (int)(num3 * 1493078724) ^ -2121608328;
									continue;
								case 2u:
									goto end_IL_01e6;
								case 5u:
									goto IL_035f;
								case 6u:
									obj._184044A093C04AF2(129, 1147858007u);
									num11 = ((int)num3 * -1133631415) ^ 0x6A49EE1D;
									continue;
								default:
									obj._184044A093C04AF2(138, 2838453303u);
									obj._184044A093C04AF2(131, 3383584791u);
									goto IL_03fe;
								}
								break;
							}
							goto IL_0226;
							IL_035f:
							obj._184044A093C04AF2(132, 558405751u);
							num11 = 974203947;
							goto IL_022b;
							end_IL_01e6:;
						}
						finally
						{
							obj._184044A093C04AF2(136, 558405751u);
							obj._184044A093C04AF2(137, 1147858007u);
							obj._184044A093C04AF2(138, 2838453303u);
							obj._184044A093C04AF2(139, 3383584791u);
							BE4FAD676FA840DD(intPtr3);
						}
						goto IL_066b;
					}
					IL_0419:
					num6 = 1145211926;
					goto IL_041e;
					IL_041e:
					while (true)
					{
						num2 = num6;
						switch ((num3 = (uint)((-(((~num2 + 1723385631 * (-541463897 * (222757035 * -unchecked(940235443 * -357240541) - unchecked(-479469523 * -224066510)))) ^ (~unchecked(-1269138187 * -1550503369) + -(0x7ACD6A6D ^ -2123694724) + (0x2D01EC86 ^ (--1040566583 ^ 0x421C203A)) - ((0x3B942357 ^ 0x5EE3D1F0) - ((3621235 * -1074832611) ^ 0x7CEF1B2A)))) - -(--130442884)) * 68324949 * -1811387551) ^ 0x186C9995)) % 11)
						{
						case 5u:
							break;
						case 8u:
							goto IL_0503;
						case 9u:
							obj._184044A093C04AF2(4, 1273022787u);
							num6 = (int)(num3 * 1379342309) ^ -731278374;
							continue;
						case 7u:
							obj = new _81DD83B8AA2247AA(1471211248u);
							num6 = -104046922;
							continue;
						case 10u:
						{
							int num7;
							int num8;
							if (!(intPtr != IntPtr.Zero))
							{
								num7 = -980367163;
								num8 = num7;
							}
							else
							{
								num7 = -435986517;
								num8 = num7;
							}
							num6 = num7 ^ (int)(num3 * 1902785607);
							continue;
						}
						case 0u:
							obj._184044A093C04AF2(0, 1795497609u);
							return intPtr;
						case 1u:
							return IntPtr.Zero;
						case 4u:
							throw BEFBA9987F55444F(_96D1BCE786D04E0E(_003CModule_003E._58ECCB512F2A43AC<string>((int)(0x1878976D ^ obj._184044A093C04AF2(5, 2506262918u))), _71B74A99B440438C((object)obj2)));
						case 6u:
							goto IL_0613;
						case 3u:
							intPtr = (IntPtr)_76ADEE7338A44D5C((void*)IntPtr.Zero, (char*)(void*)_2E00853FE0304BD9(_71B74A99B440438C((object)obj2)));
							num6 = ((int)num3 * -261620682) ^ 0x377DD82;
							continue;
						default:
							goto IL_066b;
						}
						break;
						IL_0503:
						int num9;
						if ((int)EAF36BDDBB8945C2((object)obj2) == _003CModule_003E._58ECCB512F2A43AC<int>(-449928750 ^ (int)obj._184044A093C04AF2(9, 3312925433u)))
						{
							num6 = -1190688918;
							num9 = num6;
						}
						else
						{
							num6 = 2077222334;
							num9 = num6;
						}
					}
					goto IL_0419;
					IL_03fe:
					num10 += _003CModule_003E._390073C602714496<int>((int)(0x5825CB3B ^ obj._184044A093C04AF2(8, 1816361829u)));
					goto IL_0419;
					IL_0613:
					obj = new _81DD83B8AA2247AA(1643868005u);
					if (num10 < dependencies.Length)
					{
						goto default;
					}
					num6 = 1440228499;
					goto IL_041e;
					IL_066b:
					obj._184044A093C04AF2(2, 1226904021u);
					return result;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _42A934BEB8264747(MemoryModule P_0, _7F042AF7ECCF4530 P_1)
	{
		//The blocks IL_0509, IL_050e, IL_057d are reachable both inside and outside the pinned region starting at IL_05c1. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3738224223u);
		List<_1E7BC0C438DF4CB6> source = P_1.DynamicSectionHeader.DynamicSectionItems.ToList();
		Func<_1E7BC0C438DF4CB6, bool> predicate = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.Init;
		obj._184044A093C04AF2(10, 2080246995u);
		_1E7BC0C438DF4CB6 obj2 = source.FirstOrDefault(predicate);
		if (obj2 == null)
		{
			goto IL_0058;
		}
		goto IL_0156;
		IL_0156:
		obj._184044A093C04AF2(4, 1057984869u);
		int num = 1265500230;
		goto IL_005d;
		IL_005d:
		_1E7BC0C438DF4CB6 obj3 = default;
		ulong num5 = default;
		int num6 = default;
		IntPtr[] array5 = default;
		IntPtr[] array6 = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(-num2 * -1541741091 - (unchecked(unchecked(728661372 - 230926880 + (2046325093 + -1746530802) + ~unchecked(1241067719 + 1521269475)) * -1568467899) + (unchecked((681160034 + (-1455570044 - -590154408)) * 852632543) - -(-(~1314788517)))))) % 5)
			{
			case 0u:
				break;
			case 1u:
			{
				Func<_1E7BC0C438DF4CB6, bool> predicate2 = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.InitArray;
				obj._184044A093C04AF2(6, 2967250363u);
				obj3 = source.First(predicate2);
				Func<_1E7BC0C438DF4CB6, bool> predicate3 = (_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.InitArraySz;
				obj._184044A093C04AF2(0, 2714467381u);
				num5 = _1540D1CE0F194D87((object)source.First(predicate3)) / (ulong)sizeof(IntPtr);
				num = 1002021491;
				continue;
			}
			case 2u:
				goto IL_0156;
			case 3u:
				P_0.initialized = (byte)_003CModule_003E._390073C602714496<int>((int)(0x1DA48313 ^ obj._184044A093C04AF2(6, 1251054865u))) != 0;
				return;
			default:
			{
				string[] array = DC862AA0CCD64E3C();
				IEnumerable<DictionaryEntry> source2 = ((IEnumerable)_675DD5F915F74A06()).Cast<DictionaryEntry>();
				Func<DictionaryEntry, string> selector = (DictionaryEntry x) => $"{x.Key}={x.Value}";
				obj._184044A093C04AF2(10, 3814225457u);
				IEnumerable<string> source3 = source2.Select(selector);
				int argc = array.Length;
				Func<string, IntPtr> selector2 = (string arg) => Marshal.StringToHGlobalAnsi(arg);
				obj._184044A093C04AF2(6, 3806443311u);
				IntPtr[] array2 = array.Select(selector2).ToArray();
				IEnumerable<IntPtr> first = source3.Select((string envv) => Marshal.StringToHGlobalAnsi(envv));
				IntPtr[] array3 = new IntPtr[_003CModule_003E._3F57E81A62734AC2<int>(-1674155954 ^ (int)obj._184044A093C04AF2(8, 3396139180u))];
				array3[_003CModule_003E._3F57E81A62734AC2<int>(-288956222 ^ (int)obj._184044A093C04AF2(10, 3671534861u))] = IntPtr.Zero;
				IntPtr[] array4 = first.Concat(array3).ToArray();
				try
				{
					obj = new _81DD83B8AA2247AA(4118966167u);
					InitDelegate delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer<InitDelegate>((IntPtr)((byte*)P_0.codeBase + _1540D1CE0F194D87((object)obj2)));
					try
					{
						fixed (IntPtr* argv = &array2[_003CModule_003E._58ECCB512F2A43AC<int>(-922765608 ^ (int)obj._184044A093C04AF2(0, 2593375955u))])
						{
							try
							{
								fixed (IntPtr* envp = &array4[_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x53C3869 ^ obj._184044A093C04AF2(2, 3847988970u)))])
								{
									delegateForFunctionPointer(argc, (byte**)argv, (byte**)envp);
									while (true)
									{
										IL_0310:
										int num4 = 1887077926;
										while (true)
										{
											num2 = num4;
											switch ((num3 = (uint)(-num2 * -1541741091 - (unchecked(unchecked(728661372 - 230926880 + (2046325093 + -1746530802) + ~unchecked(1241067719 + 1521269475)) * -1568467899) + (unchecked((681160034 + (-1455570044 - -590154408)) * 852632543) - -(-(~1314788517)))))) % 9)
											{
											case 0u:
												break;
											default:
												goto end_IL_0315;
											case 2u:
												obj = new _81DD83B8AA2247AA(575117151u);
												num4 = -1124523660;
												continue;
											case 4u:
											{
												int num7;
												int num8;
												if (num6 >= array6.Length)
												{
													num7 = 1021267412;
													num8 = num7;
												}
												else
												{
													num7 = -854691318;
													num8 = num7;
												}
												num4 = num7 ^ ((int)num3 * -210578238);
												continue;
											}
											case 3u:
												Marshal.GetDelegateForFunctionPointer<InitDelegate>(array6[num6])(argc, (byte**)argv, (byte**)envp);
												num6 += _003CModule_003E._3F57E81A62734AC2<int>((int)(0x7235DC16 ^ obj._184044A093C04AF2(5, 3365135282u)));
												num4 = 773368876;
												continue;
											case 5u:
												obj._184044A093C04AF2(6, 3907507373u);
												num4 = (int)(num3 * 1552272847) ^ -1640588027;
												continue;
											case 1u:
												array6 = array5;
												obj._184044A093C04AF2(4, 1055998363u);
												obj._184044A093C04AF2(7, 3334919224u);
												obj._184044A093C04AF2(5, 2177944954u);
												num6 = _003CModule_003E._3F57E81A62734AC2<int>(-1260424007 ^ (int)obj._184044A093C04AF2(10, 3644295089u));
												num4 = (int)((num3 * 1836108167) ^ 0x1249E9FC);
												continue;
											case 7u:
												D110A7617DA2483D((IntPtr)((long)P_0.codeBase + (long)_1540D1CE0F194D87((object)obj3)), array5, _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x21AB7B83 ^ obj._184044A093C04AF2(10, 3690442643u))), (int)num5);
												num4 = ((int)num3 * -1899212415) ^ 0x51AF1971;
												continue;
											case 8u:
												array5 = new IntPtr[num5];
												num4 = (int)((num3 * 2089567504) ^ 0x413A39BB);
												continue;
											case 6u:
												goto end_IL_0315;
											}
											goto IL_0310;
											continue;
											end_IL_0315:
											break;
										}
										break;
									}
								}
							}
							finally
							{
								obj = new _81DD83B8AA2247AA(2750572852u);
								while (true)
								{
									int num9 = (num2 = -383928022);
									uint num10 = (num3 = (uint)(-num2 * -1541741091 - (unchecked(unchecked(728661372 - 230926880 + (2046325093 + -1746530802) + ~unchecked(1241067719 + 1521269475)) * -1568467899) + (unchecked((681160034 + (-1455570044 - -590154408)) * 852632543) - -(-(~1314788517))))));
									switch (num10 % 3)
									{
									case 2u:
										break;
									default:
										goto end_IL_0509;
									case 1u:
									{
										int num11 = 1590025426;
										obj._184044A093C04AF2(10, 800616934u);
										obj._184044A093C04AF2(1, 3075106539u);
										obj._184044A093C04AF2(0, 1407069067u);
										while (true)
										{
											IL_05c1:
											fixed (IntPtr* ptr = &Unsafe.AsRef<IntPtr>((IntPtr*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>(num11 ^ (int)obj._184044A093C04AF2(7, 2939859029u))))
											{
												num9 = ((int)num3 * -1567422372) ^ -104316581;
												while (true)
												{
													num2 = num9;
													num10 = (num3 = (uint)(-num2 * -1541741091 - (unchecked(unchecked(728661372 - 230926880 + (2046325093 + -1746530802) + ~unchecked(1241067719 + 1521269475)) * -1568467899) + (unchecked((681160034 + (-1455570044 - -590154408)) * 852632543) - -(-(~1314788517))))));
													switch (num10 % 3)
													{
													case 2u:
														break;
													default:
														goto end_IL_050e;
													case 1u:
														num11 = 1590025426;
														obj._184044A093C04AF2(10, 800616934u);
														obj._184044A093C04AF2(1, 3075106539u);
														obj._184044A093C04AF2(0, 1407069067u);
														goto IL_05c1;
													case 0u:
														goto end_IL_050e;
													}
													num9 = -383928022;
													continue;
													end_IL_050e:
													break;
												}
											}
											break;
										}
										goto end_IL_0509;
									}
									case 0u:
										goto end_IL_0509;
									}
									continue;
									end_IL_0509:
									break;
								}
							}
						}
					}
					finally
					{
						obj = new _81DD83B8AA2247AA(4028412626u);
						obj._184044A093C04AF2(0, 3128705837u);
						obj._184044A093C04AF2(2, 2110974656u);
						obj._184044A093C04AF2(5, 3293940173u);
						fixed (IntPtr* ptr2 = &Unsafe.AsRef<IntPtr>((IntPtr*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>(-166791357 ^ (int)obj._184044A093C04AF2(3, 2875326707u))))
						{
						}
					}
					P_0.initialized = (byte)_003CModule_003E._390073C602714496<int>((int)(0x7709B213 ^ obj._184044A093C04AF2(5, 0u))) != 0;
				}
				finally
				{
					obj = new _81DD83B8AA2247AA(1381039023u);
					array6 = array2;
					while (true)
					{
						IL_0658:
						int num12 = 1581660893;
						while (true)
						{
							num2 = num12;
							switch ((num3 = (uint)(-num2 * -1541741091 - (unchecked(unchecked(728661372 - 230926880 + (2046325093 + -1746530802) + ~unchecked(1241067719 + 1521269475)) * -1568467899) + (unchecked((681160034 + (-1455570044 - -590154408)) * 852632543) - -(-(~1314788517)))))) % 14)
							{
							case 0u:
								break;
							case 12u:
								obj._184044A093C04AF2(4, 1515026679u);
								obj._184044A093C04AF2(1, 2563740696u);
								obj._184044A093C04AF2(10, 4209753912u);
								num6 = _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x25B8E2D0 ^ obj._184044A093C04AF2(7, 3248649704u)));
								num12 = (int)((num3 * 207629670) ^ 0x4B35ED22);
								continue;
							case 13u:
								obj = new _81DD83B8AA2247AA(969290412u);
								num12 = 707377165;
								continue;
							case 5u:
								num6 += _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x4A13B647 ^ obj._184044A093C04AF2(0, 3103430607u)));
								num12 = ((int)num3 * -1503416437) ^ -957250294;
								continue;
							case 2u:
								num6 += _003CModule_003E._58ECCB512F2A43AC<int>(-1407736145 ^ (int)obj._184044A093C04AF2(6, 3377014441u));
								num12 = ((int)num3 * -254655752) ^ -809764619;
								continue;
							case 6u:
								array6 = array4;
								num12 = ((int)num3 * -1527022812) ^ 0x2A831752;
								continue;
							case 1u:
								obj._184044A093C04AF2(10, 3146632946u);
								obj._184044A093C04AF2(9, 1935492133u);
								obj._184044A093C04AF2(11, 977551515u);
								num6 = _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x463521C1 ^ obj._184044A093C04AF2(8, 1390001563u)));
								num12 = (int)((num3 * 287202218) ^ 0x67386AB);
								continue;
							case 4u:
								obj._184044A093C04AF2(0, 1982696467u);
								num12 = (int)(num3 * 740652062) ^ -1099922596;
								continue;
							case 11u:
								BE4FAD676FA840DD(array6[num6]);
								num12 = -1962818170;
								continue;
							case 7u:
							{
								int num14;
								int num15;
								if (num6 < array6.Length)
								{
									num14 = -974159852;
									num15 = num14;
								}
								else
								{
									num14 = -1205628969;
									num15 = num14;
								}
								num12 = num14 ^ ((int)num3 * -373578353);
								continue;
							}
							case 9u:
								BE4FAD676FA840DD(array6[num6]);
								num12 = -112310119;
								continue;
							case 3u:
							{
								obj = new _81DD83B8AA2247AA(3435861140u);
								int num13;
								if (num6 < array6.Length)
								{
									num12 = -1908283947;
									num13 = num12;
								}
								else
								{
									num12 = 958746416;
									num13 = num12;
								}
								continue;
							}
							case 10u:
								num12 = ((int)num3 * -2141620334) ^ -1373825885;
								continue;
							default:
								obj._184044A093C04AF2(5, 1430622067u);
								obj._184044A093C04AF2(2, 2821660286u);
								obj._184044A093C04AF2(7, 3963622861u);
								goto end_IL_065d;
							}
							goto IL_0658;
							continue;
							end_IL_065d:
							break;
						}
						break;
					}
				}
				obj._184044A093C04AF2(1, 2724911410u);
				return;
			}
			}
			break;
		}
		goto IL_0058;
		IL_0058:
		num = -650859103;
		goto IL_005d;
	}

	private unsafe static void _732BE3E7D86F40A0(MemoryModule P_0, _7F042AF7ECCF4530 P_1)
	{
		List<_1E7BC0C438DF4CB6> source = P_1.DynamicSectionHeader.DynamicSectionItems.ToList();
		_1E7BC0C438DF4CB6 obj = source.FirstOrDefault((_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.Fini);
		_1E7BC0C438DF4CB6 obj2 = source.FirstOrDefault((_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.FiniArray);
		_1E7BC0C438DF4CB6 obj3 = source.FirstOrDefault((_1E7BC0C438DF4CB6 item) => item.Tag == ElfDynamicSectionItemType.FiniArraySz);
		while (true)
		{
			int num = -1659796162;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~((-(-(-unchecked((0x5E63CBD5 ^ -130808835) * -980384365))) + -(-(0x1C91511B ^ -1522153565 ^ 0x17EBCFDB)) - num2) * -1782296403 * 1437963357)))) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					P_0.firstFinalizer = (IntPtr)(long)_1540D1CE0F194D87((object)obj);
					P_0.finalizerArray = (IntPtr)(long)_1540D1CE0F194D87((object)obj2);
					num = (int)(num3 * 1558524514) ^ -2136112630;
					continue;
				case 3u:
					P_0.finalizerArrayCount = _1540D1CE0F194D87((object)obj3) / (ulong)sizeof(IntPtr);
					num = ((int)num3 * -958567494) ^ 0x3E61FE79;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _2F9B7352FB5C4699(MemoryModule P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1543454551u);
		IntPtr* ptr = default;
		ulong num4 = default;
		while (true)
		{
			int num = -1157636425;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-(num2 - ((~(-unchecked((~275108999 + unchecked(1862487897 * -670136804)) * 1528368493)) ^ ((-(0x6BA45760 ^ -1208138293) + -unchecked(1435929243 - -1167450513) + -171718310) ^ ~(-(~-927937147) + --1987961096 * 2034562451))) - (-906156167 * (719192101 * ((-1111487863 ^ -947704322) - --347757617)) + (-640564721 ^ -1898074744) + -(-(-1201220846 * 14308941 - -unchecked(-309733143 * 361267011))))))))) % 6)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
					obj._184044A093C04AF2(1, 901133827u);
					num = (int)(num3 * 1592953626) ^ -215969091;
					continue;
				case 5u:
					Marshal.GetDelegateForFunctionPointer<FiniDelegate>(ptr[num4])();
					num4 += (ulong)_003CModule_003E._58ECCB512F2A43AC<int>(-129892080 ^ (int)obj._184044A093C04AF2(4, 888453705u));
					num = -1835839110;
					continue;
				case 2u:
				{
					obj = new _81DD83B8AA2247AA(2704416107u);
					int num5;
					if (num4 >= P_0.finalizerArrayCount)
					{
						num = -1974665824;
						num5 = num;
					}
					else
					{
						num = 1832215561;
						num5 = num;
					}
					continue;
				}
				case 1u:
					Marshal.GetDelegateForFunctionPointer<FiniDelegate>((IntPtr)((long)P_0.codeBase + (long)P_0.firstFinalizer))();
					ptr = (IntPtr*)((ulong)P_0.codeBase + (ulong)(long)P_0.finalizerArray);
					obj._184044A093C04AF2(0, 3723878069u);
					obj._184044A093C04AF2(5, 908536596u);
					obj._184044A093C04AF2(10, 1511804540u);
					num4 = (ulong)_003CModule_003E.F84FA79ABE6944BB<int>(-1863965890 ^ (int)obj._184044A093C04AF2(7, 2362394604u));
					num = ((int)num3 * -846764368) ^ -263377622;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[DllImport("libc", EntryPoint = "mmap")]
	private unsafe static extern void* A6E46F54B4744622(void* P_0, UIntPtr P_1, MmapProtectionFlags P_2, MmapMappingFlags P_3, int P_4 = -1, int P_5 = 0);

	[DllImport("libc", EntryPoint = "mprotect")]
	private unsafe static extern IntPtr _73270FF02EE64DF1(void* P_0, UIntPtr P_1, MmapProtectionFlags P_2);

	[DllImport("libc", EntryPoint = "munmap")]
	private unsafe static extern int _6EFB65D1AFFB4D0C(void* P_0, UIntPtr P_1);

	[DllImport("libc", EntryPoint = "sysconf")]
	private static extern IntPtr A6796BC215504547(int P_0);

	[DllImport("libc", EntryPoint = "dlopen")]
	private unsafe static extern void* _38D2FF4E262C4A91(char* P_0, int P_1 = 257);

	[DllImport("libc", EntryPoint = "dlsym")]
	private unsafe static extern void* _28A201EFE05E4907(void* P_0, char* P_1);

	[DllImport("libc", EntryPoint = "dlclose")]
	private unsafe static extern int _084B789F36664D29(void* P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	unsafe static _5658C81EDBBB4F69()
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3967095132u);
		E838ACF743B94050 = _29E2D651EFA24403;
		while (true)
		{
			int num = -488393083;
			while (true)
			{
				int num2 = num;
				uint num3;
				int num4;
				switch ((num3 = (uint)(-(unchecked(-81193365 * 874848399) - unchecked(-1955206620 + (-691654038 ^ 0x6EEB3F50)) - ((~(~(--1850598942 ^ 0x5016402)) ^ (441468265 - -(-1928530581 - -482923241 - unchecked(-1475818665 * -1105046211)))) - (~(unchecked(1114244002 * -706264229) + --1619877854) - ~(-(--330203970)) + --740777709)) - num2) - -(0xDBD866D ^ -(--371943309 + ~-1630744935)))) % 4)
				{
				case 0u:
					break;
				case 1u:
					_6976359CB1334015 = FAA2AD51ED324311;
					D2DFE763FC804846 = _3098F709D72A40CB;
					_9E971C61A9554C8C = C4DAF164D55549A1;
					num = ((int)num3 * -1869006283) ^ -525445374;
					continue;
				case 3u:
					_19AD7ED97F0D4A36 = C55C162F34BF4212;
					if (!D109CABCE71F4DD5())
					{
						num = ((int)num3 * -83999508) ^ -336535138;
						continue;
					}
					obj._184044A093C04AF2(6, 1644106332u);
					num4 = _003CModule_003E._3F57E81A62734AC2<int>((int)(0x7601934E ^ obj._184044A093C04AF2(5, 0u)));
					goto IL_0185;
				default:
					{
						num4 = _003CModule_003E._3F57E81A62734AC2<int>((int)(0x25C132F ^ obj._184044A093C04AF2(2, 1644106332u)));
						goto IL_0185;
					}
					IL_0185:
					obj = new _81DD83B8AA2247AA(2745113845u);
					_9BFE71D11087449F = (uint)num4;
					return;
				}
				break;
			}
		}
	}

	static IntPtr _2E00853FE0304BD9(string P_0)
	{
		return Marshal.StringToHGlobalAnsi(P_0);
	}

	static void BE4FAD676FA840DD(IntPtr P_0)
	{
		Marshal.FreeHGlobal(P_0);
	}

	static MmapProtectionFlags _25CC0C914F1C4C57(PageProtection P_0)
	{
		return _84084DACA4D745AE._647ABD1B683C455D(P_0);
	}

	unsafe static void* _0B2778CB90D44154(char* P_0, int P_1)
	{
		return Dl.dlopen(P_0, P_1);
	}

	unsafe static void* _76ADEE7338A44D5C(void* P_0, char* P_1)
	{
		return Dl.dlsym(P_0, P_1);
	}

	unsafe static int C7DFA364C2124BA3(void* P_0)
	{
		return Dl.dlclose(P_0);
	}

	static object _444841BEAB0E4D97()
	{
		return new MemoryModule();
	}

	static object BEFBA9987F55444F(string P_0)
	{
		return new FBEA5B68721C48F2(P_0);
	}

	unsafe static object _2E267DA82520454E(byte* P_0)
	{
		return new _7F042AF7ECCF4530(P_0);
	}

	static object EBD707871A6E4847(string P_0, object P_1)
	{
		return new FBEA5B68721C48F2(P_0, (Exception)P_1);
	}

	unsafe static void _64826DF2F55343F6(void* P_0)
	{
		_9B23CE46D4544D63._22A3CC2BB1664890(P_0);
	}

	static void A4546C5E1BC34ED9(LinkMap P_0)
	{
		GlibcTls.RemoveFromSlotInfo(P_0);
	}

	unsafe static void* _6F59E495CF1B4376(object P_0)
	{
		return ((LinkMap)P_0).TlsInitialImage;
	}

	static void D5F7E8787B544691(object P_0)
	{
		((LinkMap)P_0).Dispose();
	}

	static string _47BF306900844384(IntPtr P_0)
	{
		return Marshal.PtrToStringAnsi(P_0);
	}

	static ulong B715417451164C01(object P_0)
	{
		return ((_4697E400134E4CA8)P_0).Value;
	}

	static ulong _44A00F79AC0E4853(object P_0)
	{
		return ((AF4EA33D30884C93)P_0).VirtualAddress;
	}

	static ulong _971F426DB65F4504(object P_0)
	{
		return ((AF4EA33D30884C93)P_0).MemorySize;
	}

	static ulong D30E9CC8AC6C4CFF(ulong P_0, ulong P_1)
	{
		return Math.Min(P_0, P_1);
	}

	static ulong FAEEC58E9C3F4D11(ulong P_0, ulong P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static object F323CED35BFC4720(string P_0)
	{
		return new OutOfMemoryException(P_0);
	}

	static ulong B622221CF61844E2(object P_0)
	{
		return ((AF4EA33D30884C93)P_0).Offset;
	}

	unsafe static byte* _2F54C4F2A19C4E8E(object P_0, ulong P_1)
	{
		return ((_7F042AF7ECCF4530)P_0).GetAddress(P_1);
	}

	static ulong A9E832C2524E40BC(object P_0)
	{
		return ((AF4EA33D30884C93)P_0).FileSize;
	}

	unsafe static void* E91C55B720DB45E9(void* P_0, void* P_1, uint P_2)
	{
		return _9B23CE46D4544D63._2967AA18DF7D4B63(P_0, P_1, P_2);
	}

	static uint _485E2204693C4B5E(object P_0)
	{
		return ((AF4EA33D30884C93)P_0).Flags;
	}

	static string _34ABD9DCB1D542B5(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static object _0B4815D418994E20()
	{
		return new LinkMap();
	}

	static ulong A64822CAFD2843BC(object P_0)
	{
		return ((AF4EA33D30884C93)P_0).Align;
	}

	static void _09F89D1245EB4ECA(object P_0, ulong P_1)
	{
		((LinkMap)P_0).TlsBlockAlignment = P_1;
	}

	static void _98C8A8371DBA4D03(object P_0, ulong P_1)
	{
		((LinkMap)P_0).TlsBlockSize = P_1;
	}

	static void F0D82998D85B4329(object P_0, ulong P_1)
	{
		((LinkMap)P_0).TlsInitImageSize = P_1;
	}

	unsafe static void* _9106838A6F904831(uint P_0)
	{
		return _9B23CE46D4544D63._7A6047F799AC428E(P_0);
	}

	unsafe static void F929B03EF7F14704(object P_0, void* P_1)
	{
		((LinkMap)P_0).TlsInitialImage = P_1;
	}

	static ulong _46078A6E86764C21()
	{
		return GlibcTls.GetNextModuleId();
	}

	static void _6D937E79DBCC4A27(object P_0, ulong P_1)
	{
		((LinkMap)P_0).TlsModuleId = P_1;
	}

	static void _0102DBCEA6344F02(LinkMap P_0)
	{
		GlibcTls.AddToSlotInfo(P_0);
	}

	static UIntPtr _2017DABDBE874768(object P_0)
	{
		return ((_1E7BC0C438DF4CB6)P_0).Pointer;
	}

	static ulong _1540D1CE0F194D87(object P_0)
	{
		return ((_1E7BC0C438DF4CB6)P_0).Value;
	}

	static string _96D1BCE786D04E0E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static bool _5E1433D6AD6B4624(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	static void _4CEA51BDE5AA4E75(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static object _85C8DCFDC56E46E9()
	{
		return new _003C_003Ec__DisplayClass27_0();
	}

	static ulong _5FBDB97C5DD74801(object P_0)
	{
		return ((_9F61EB4FCBA44886)P_0).Size;
	}

	static ulong _218FE6C854D6408D(object P_0)
	{
		return ((_9F61EB4FCBA44886)P_0).Offset;
	}

	static ulong _3A65438579D14862(object P_0)
	{
		return ((_9F61EB4FCBA44886)P_0).EntrySize;
	}

	unsafe static object CBFD5F73E938436E(byte* P_0, ulong P_1, ulong P_2)
	{
		return new _06E00CD4BCAE4936(P_0, P_1, P_2);
	}

	unsafe static object F73F9A44363F40B1(byte* P_0, ulong P_1)
	{
		return new CBD209469E2A430D(P_0, P_1);
	}

	static string _76DA2DE12CBF4EEB(object P_0, object P_1)
	{
		return ((_4697E400134E4CA8)P_0).ResolveName((CBD209469E2A430D)P_1);
	}

	static ElfSymbolType _85AAA8FAF3984FB8(object P_0)
	{
		return ((_4697E400134E4CA8)P_0).Type;
	}

	static ulong CB5AE2D7DE644F61(object P_0)
	{
		return ((_4697E400134E4CA8)P_0).Value;
	}

	static void _691CAD673A344C78(object P_0, ulong P_1)
	{
		((_4697E400134E4CA8)P_0).Value = P_1;
	}

	static object AD13CD4BF2EB430D()
	{
		return new _003C_003Ec__DisplayClass28_0();
	}

	unsafe static object _9FFF279F4AC8445D(byte* P_0, ulong P_1, ulong P_2)
	{
		return new _9AB63A5D077D4BCA(P_0, P_1, P_2);
	}

	static ulong _8868C9572BC84B4F(object P_0)
	{
		return ((F94D8F12CF5B448C)P_0).Offset;
	}

	static bool FD4EE0C92EFF4343(object P_0)
	{
		return ((F94D8F12CF5B448C)P_0).DependsOnSymbol();
	}

	static _5D1CA4FB0960430A _7871A055BF3B46D5(object P_0)
	{
		return ((F94D8F12CF5B448C)P_0).Type;
	}

	static ulong _5D62B0180D50400E(object P_0)
	{
		return ((F94D8F12CF5B448C)P_0).Addend;
	}

	static ulong CCE1B618FACE4982(object P_0)
	{
		return ((LinkMap)P_0).TlsModuleId;
	}

	static ulong _14405C03C90542F4(object P_0)
	{
		return ((F94D8F12CF5B448C)P_0).Symbol;
	}

	static object C76A156BA0634614(string P_0)
	{
		return new NotImplementedException(P_0);
	}

	static string _71B74A99B440438C(object P_0)
	{
		return ((_4697E400134E4CA8)P_0).Name;
	}

	static ElfSymbolBinding EAF36BDDBB8945C2(object P_0)
	{
		return ((_4697E400134E4CA8)P_0).Binding;
	}

	static string[] DC862AA0CCD64E3C()
	{
		return Environment.GetCommandLineArgs();
	}

	static object _675DD5F915F74A06()
	{
		return Environment.GetEnvironmentVariables();
	}

	static void D110A7617DA2483D(IntPtr P_0, IntPtr[] P_1, int P_2, int P_3)
	{
		Marshal.Copy(P_0, P_1, P_2, P_3);
	}

	static bool D109CABCE71F4DD5()
	{
		return Environment.Is64BitProcess;
	}
}
