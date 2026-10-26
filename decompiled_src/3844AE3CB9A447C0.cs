using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static class _3844AE3CB9A447C0
{
	public unsafe delegate IntPtr PlatformLoadLibraryFunc(byte* dataPtr, long length, CustomAllocFunc allocMemory = null, CustomFreeFunc freeMemory = null, CustomLoadLibraryFunc loadLibrary = null, CustomGetProcAddressFunc getProcAddress = null, CustomFreeLibraryFunc freeLibrary = null);

	public delegate bool PlatformFreeLibraryFunc(IntPtr handle);

	public delegate IntPtr PlatformGetSymbolFunc(IntPtr module, string name);

	internal unsafe delegate void* PlatformGetSymbolUnsafeFunc(void* module, char* name);

	public static readonly PlatformLoadLibraryFunc B73431636FF14D3E;

	public static readonly PlatformFreeLibraryFunc D829FB42EDC342B1;

	public static readonly PlatformGetSymbolFunc _833AD5F7E7AC4C9D;

	public static readonly CustomLoadLibraryFunc EC0D0BB57C55490C;

	public static readonly CustomFreeLibraryFunc _7405053409264778;

	public static readonly CustomGetProcAddressFunc _6637E1B8D0144B96;

	internal static readonly PlatformGetSymbolUnsafeFunc _3D853D3971AB40BD;

	[MethodImpl(MethodImplOptions.NoInlining)]
	unsafe static _3844AE3CB9A447C0()
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2989348081u);
		if (D29710C559DC404A(OSPlatform.Windows))
		{
			goto IL_001b;
		}
		goto IL_0178;
		IL_001b:
		int num = 1881095011;
		goto IL_0020;
		IL_0020:
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(~(-num2) + ~151727848)) % 11)
			{
			case 6u:
				break;
			case 1u:
				return;
			case 4u:
				obj._184044A093C04AF2(10, 2587440027u);
				B73431636FF14D3E = _5658C81EDBBB4F69._6C0C1695013442A3;
				D829FB42EDC342B1 = _5658C81EDBBB4F69._4AE84E4B3FBB437E;
				_833AD5F7E7AC4C9D = _5658C81EDBBB4F69._93B27360AFC246A7;
				EC0D0BB57C55490C = _5658C81EDBBB4F69._3098F709D72A40CB;
				_7405053409264778 = _5658C81EDBBB4F69.C55C162F34BF4212;
				_6637E1B8D0144B96 = _5658C81EDBBB4F69.C4DAF164D55549A1;
				_3D853D3971AB40BD = _5658C81EDBBB4F69._01D94F3CF02247C5;
				num = ((int)num3 * -1866102453) ^ 0x2BC841B0;
				continue;
			case 10u:
				goto IL_010e;
			case 2u:
			{
				int num4;
				int num5;
				if (!D29710C559DC404A(OSPlatform.Linux))
				{
					num4 = -457324399;
					num5 = num4;
				}
				else
				{
					num4 = -1291110294;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 1099570101);
				continue;
			}
			case 3u:
				return;
			case 0u:
				goto IL_0178;
			case 8u:
				_3D853D3971AB40BD = _89C94C43C8614FCF._1F7344CAB03C4710;
				num = ((int)num3 * -1749264947) ^ 0x6D1C74D7;
				continue;
			case 7u:
				throw _0F1CEC691FC9422B(_003CModule_003E._390073C602714496<string>((int)(0x3F2D0396 ^ obj._184044A093C04AF2(1, 3319262815u))));
			case 5u:
				obj._184044A093C04AF2(5, 2269089369u);
				B73431636FF14D3E = _89C94C43C8614FCF._1DC86C26657C443F;
				D829FB42EDC342B1 = _89C94C43C8614FCF.FF9A58721C484FA2;
				_833AD5F7E7AC4C9D = _89C94C43C8614FCF._0C450FB76CED42D3;
				EC0D0BB57C55490C = _89C94C43C8614FCF.DF2AD576C98244F3;
				_7405053409264778 = _89C94C43C8614FCF._30D430E9499F4C5D;
				_6637E1B8D0144B96 = _89C94C43C8614FCF._258EF3CD346F41E9;
				num = ((int)num3 * -1138309390) ^ -574680743;
				continue;
			default:
				obj._184044A093C04AF2(5, 718085564u);
				return;
			}
			break;
			IL_010e:
			obj._184044A093C04AF2(10, 369362547u);
			int num6;
			if (!D29710C559DC404A(OSPlatform.OSX))
			{
				num = 1257699231;
				num6 = num;
			}
			else
			{
				num = 1722784542;
				num6 = num;
			}
		}
		goto IL_001b;
		IL_0178:
		obj._184044A093C04AF2(9, 1901304916u);
		num = 2022781157;
		goto IL_0020;
	}

	static bool D29710C559DC404A(OSPlatform P_0)
	{
		return RuntimeInformation.IsOSPlatform(P_0);
	}

	static object _0F1CEC691FC9422B(string P_0)
	{
		return new NotImplementedException(P_0);
	}
}
