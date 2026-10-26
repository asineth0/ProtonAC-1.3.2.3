using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static class _9h
{
	public unsafe delegate IntPtr PlatformLoadLibraryFunc(byte* dataPtr, long length, CustomAllocFunc allocMemory = null, CustomFreeFunc freeMemory = null, CustomLoadLibraryFunc loadLibrary = null, CustomGetProcAddressFunc getProcAddress = null, CustomFreeLibraryFunc freeLibrary = null);

	public delegate bool PlatformFreeLibraryFunc(IntPtr handle);

	public delegate IntPtr PlatformGetSymbolFunc(IntPtr module, string name);

	internal unsafe delegate void* PlatformGetSymbolUnsafeFunc(void* module, char* name);

	public static readonly PlatformLoadLibraryFunc _uJ;

	public static readonly PlatformFreeLibraryFunc _Pc;

	public static readonly PlatformGetSymbolFunc _di;

	public static readonly CustomLoadLibraryFunc _bI;

	public static readonly CustomFreeLibraryFunc _IJ;

	public static readonly CustomGetProcAddressFunc _Ki;

	internal static readonly PlatformGetSymbolUnsafeFunc _mD;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static unsafe _9h()
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3290969192u);
		while (true)
		{
			int num = -1989222521;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-(-(-((num2 + ((0x8FC5F22 ^ ~(~(~(--1404649157))) ^ -494873199) + (-1617372751 - ((-1179578491 ^ 0x4BE533CA) - ~(~6517013) + -874502864 * 2133831511 + 414576469 * -(0x79A8ABC7 ^ 0x17F76F59))))) * -260774593 - (-((-1571437939 + 398436038 * 534127351) ^ -2105975578) ^ (-1472464604 + -1435458960 - 1601260039 * -280284017 + -2040785463 - -(0x39523B23 ^ -669681993)))))) ^ -1531281248) - -1077174694)) % 27)
				{
				case 20u:
					break;
				default:
					return;
				case 11u:
					_Ki = _NF._Hg;
					num = ((int)num3 * -1404626452) ^ -1043920060;
					continue;
				case 17u:
					_Pc = _FN._li<bool, IntPtr>;
					num = (int)((num3 * 1234268609) ^ 0x3DAF877);
					continue;
				case 14u:
				{
					int num8;
					int num9;
					if (!_200B_200E_206E_200D_200B_206A_200D_200E_202B_202D_206D_200D_206F_202C_206C_202A_200B_200C_202A_206F_206A_206D_200B_206B_202C_202C_202B_206F_200C_206F_200E_206B_206D_200B_200C_202D_202E_206D_200E_206C_202E(OSPlatform.Windows))
					{
						num8 = 700012807;
						num9 = num8;
					}
					else
					{
						num8 = -1873551971;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -399394866);
					continue;
				}
				case 19u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1038783940u);
					num = -885606733;
					continue;
				case 0u:
					_Pc = _NF._bm;
					num = (int)(num3 * 1686964050) ^ -95535949;
					continue;
				case 18u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1547970181u);
					num = 791847844;
					continue;
				case 2u:
					_di = _NF._0B<char, IntPtr, string>;
					num = (int)((num3 * 247658991) ^ 0x10FAAAA3);
					continue;
				case 5u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 847483199u);
					num = 1881723291;
					continue;
				case 10u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1948141630u);
					num = (int)(num3 * 22176931) ^ -1432661607;
					continue;
				case 3u:
					_uJ = _NF._BA<IntPtr, byte, long>;
					num = ((int)num3 * -2091963856) ^ -1526320239;
					continue;
				case 26u:
					return;
				case 9u:
					_uJ = _FN._tc<IntPtr, byte, long>;
					num = ((int)num3 * -350324723) ^ -1372955828;
					continue;
				case 21u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1590548721u);
					num = ((int)num3 * -462171788) ^ -1588900869;
					continue;
				case 23u:
					throw _200B_202A_206C_206F_206A_206A_200F_200C_200C_202D_206D_206B_202A_202E_206C_202C_202E_202E_202B_200F_200C_202A_206A_202C_202C_206B_200C_202D_202B_206C_206F_206E_202D_206E_200B_206E_206B_200C_202A_202A_202E(global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<string>((int)(0xC0C9DD8 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 24076986u))));
				case 7u:
					_mD = _FN._fI;
					num = (int)((num3 * 235804121) ^ 0xD478356);
					continue;
				case 1u:
				{
					int num6;
					int num7;
					if (!_200B_200E_206E_200D_200B_206A_200D_200E_202B_202D_206D_200D_206F_202C_206C_202A_200B_200C_202A_206F_206A_206D_200B_206B_202C_202C_202B_206F_200C_206F_200E_206B_206D_200B_200C_202D_202E_206D_200E_206C_202E(OSPlatform.Linux))
					{
						num6 = -1840871452;
						num7 = num6;
					}
					else
					{
						num6 = -1186906057;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -286030448);
					continue;
				}
				case 4u:
					_di = _FN._fC<char, IntPtr, string>;
					num = ((int)num3 * -1494312870) ^ -1507487772;
					continue;
				case 8u:
					_mD = _NF._qm;
					num = (int)((num3 * 1129859941) ^ 0x27AA827);
					continue;
				case 12u:
					_bI = _FN._7M;
					num = (int)((num3 * 1421205659) ^ 0x290F6D39);
					continue;
				case 24u:
					_IJ = _FN._xc<bool>;
					num = ((int)num3 * -352877515) ^ 0xA0B044C;
					continue;
				case 13u:
				{
					int num4;
					int num5;
					if (_200B_200E_206E_200D_200B_206A_200D_200E_202B_202D_206D_200D_206F_202C_206C_202A_200B_200C_202A_206F_206A_206D_200B_206B_202C_202C_202B_206F_200C_206F_200E_206B_206D_200B_200C_202D_202E_206D_200E_206C_202E(OSPlatform.OSX))
					{
						num4 = 1657882900;
						num5 = num4;
					}
					else
					{
						num4 = 1807283763;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1581615941);
					continue;
				}
				case 15u:
					_Ki = _FN._nF;
					num = (int)(num3 * 1307618390) ^ -1865391557;
					continue;
				case 16u:
					return;
				case 22u:
					_IJ = _NF._mJ<bool>;
					num = ((int)num3 * -926357932) ^ -122995833;
					continue;
				case 6u:
					_bI = _NF._AF;
					num = ((int)num3 * -1464576643) ^ 0x6F20D0B3;
					continue;
				case 25u:
					return;
				}
				break;
			}
		}
	}

	static bool _200B_200E_206E_200D_200B_206A_200D_200E_202B_202D_206D_200D_206F_202C_206C_202A_200B_200C_202A_206F_206A_206D_200B_206B_202C_202C_202B_206F_200C_206F_200E_206B_206D_200B_200C_202D_202E_206D_200E_206C_202E(OSPlatform P_0)
	{
		return RuntimeInformation.IsOSPlatform(P_0);
	}

	static object _200B_202A_206C_206F_206A_206A_200F_200C_200C_202D_206D_206B_202A_202E_206C_202C_202E_202E_202B_200F_200C_202A_206A_202C_202C_206B_200C_202D_202B_206C_206F_206E_202D_206E_200B_206E_206B_200C_202A_202A_202E(string P_0)
	{
		return new NotImplementedException(P_0);
	}
}
