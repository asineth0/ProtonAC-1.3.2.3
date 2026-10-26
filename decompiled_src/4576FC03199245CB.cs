using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

internal class _4576FC03199245CB : IDisposable
{
	private class LibraryInfo
	{
		public uint RefCount;

		public string Name;

		public LibraryInfo(string name)
		{
			RefCount = 1u;
			Name = name;
		}
	}

	private static readonly Dictionary<IntPtr, LibraryInfo> _0351B80197284DBB = new Dictionary<IntPtr, LibraryInfo>();

	private static readonly Dictionary<string, HashSet<IntPtr>> _3C146FC7BFB8420F = new Dictionary<string, HashSet<IntPtr>>((IEqualityComparer<string>?)DEE9BB7D2E004099());

	private unsafe static readonly CustomGetProcAddressFunc A598BA7997E44F51 = _243F2CEC4E874966;

	private unsafe static readonly CustomFreeLibraryFunc F7E968C5A6324E22 = _25075F43F6A54161;

	private IntPtr D18967752BCC462F;

	private string _8917050ED83C462E;

	private bool A9EECB1D5A9540AA;

	private readonly CustomLoadLibraryFunc A71E2C07B8FA4999;

	public string D65353A843D14F63 => _8917050ED83C462E;

	private unsafe _4576FC03199245CB()
	{
		A71E2C07B8FA4999 = EBD3F14CC2B14DB4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static byte[] C836DFA372C34677(byte[] P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(4292179898u);
		MemoryStream memoryStream = (MemoryStream)_80E2E54642DF4E45(P_0);
		byte[] result;
		try
		{
			GZipStream gZipStream = (GZipStream)AF950BFB188B48FB((object)memoryStream, (CompressionMode)_003CModule_003E._3F57E81A62734AC2<int>(-2115118212 ^ (int)obj._184044A093C04AF2(4, 3779340436u)));
			try
			{
				obj = new _81DD83B8AA2247AA(1339879533u);
				MemoryStream memoryStream2 = (MemoryStream)_2C00A37AFCBC46A1();
				try
				{
					obj._184044A093C04AF2(6, 1233934158u);
					DF547174CCC749FC((object)gZipStream, (object)memoryStream2);
					result = _1E9CF73DD9D048B0((object)memoryStream2);
				}
				finally
				{
					obj = new _81DD83B8AA2247AA(3409459835u);
					if (memoryStream2 != null)
					{
						goto IL_0077;
					}
					goto IL_011f;
					IL_0077:
					int num = -1347659121;
					goto IL_007c;
					IL_007c:
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(~(1779444824 - ((0x266DCD93 ^ (0x6AA28D60 ^ -193251399)) - (-(~1090077708) - -(--15236363))) - (-num2 + (-(--1315023803) ^ -1470093440)) - -(-((0x2A2B2434 ^ 0x4D5BEDA9) + -622803604))) - 481531700 - -511968313))) % 4)
						{
						case 0u:
							break;
						case 2u:
							E3FB09D95D72411A((object)memoryStream2);
							num = ((int)num3 * -1828069821) ^ 0x553D3890;
							continue;
						case 1u:
							goto IL_011f;
						default:
							obj._184044A093C04AF2(6, 172122776u);
							obj._184044A093C04AF2(3, 391661838u);
							goto end_IL_0065;
						}
						break;
					}
					goto IL_0077;
					IL_011f:
					obj._184044A093C04AF2(4, 260030422u);
					obj._184044A093C04AF2(1, 919971442u);
					num = 1853389116;
					goto IL_007c;
					end_IL_0065:;
				}
			}
			finally
			{
				obj = new _81DD83B8AA2247AA(1520785056u);
				while (true)
				{
					IL_016e:
					int num4 = -1662591462;
					while (true)
					{
						int num2 = num4;
						uint num3;
						switch ((num3 = (uint)(~(~(1779444824 - ((0x266DCD93 ^ (0x6AA28D60 ^ -193251399)) - (-(~1090077708) - -(--15236363))) - (-num2 + (-(--1315023803) ^ -1470093440)) - -(-((0x2A2B2434 ^ 0x4D5BEDA9) + -622803604))) - 481531700 - -511968313))) % 6)
						{
						case 5u:
							break;
						default:
							goto end_IL_0173;
						case 1u:
							obj._184044A093C04AF2(8, 1909387181u);
							num4 = -1318043131;
							continue;
						case 4u:
							E3FB09D95D72411A((object)gZipStream);
							num4 = ((int)num3 * -1758209425) ^ 0x26DFC308;
							continue;
						case 2u:
							obj._184044A093C04AF2(5, 3533967117u);
							obj._184044A093C04AF2(2, 571346851u);
							obj._184044A093C04AF2(7, 2940054451u);
							num4 = ((int)num3 * -1512944780) ^ -887333839;
							continue;
						case 3u:
						{
							int num5;
							int num6;
							if (gZipStream != null)
							{
								num5 = -183926711;
								num6 = num5;
							}
							else
							{
								num5 = -1754940696;
								num6 = num5;
							}
							num4 = num5 ^ (int)(num3 * 698104794);
							continue;
						}
						case 0u:
							goto end_IL_0173;
						}
						goto IL_016e;
						continue;
						end_IL_0173:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			obj = new _81DD83B8AA2247AA(2618045298u);
			if (memoryStream != null)
			{
				goto IL_02a9;
			}
			goto IL_035c;
			IL_02a9:
			int num7 = -1201923574;
			goto IL_02ae;
			IL_02ae:
			while (true)
			{
				int num2 = num7;
				uint num3;
				switch ((num3 = (uint)(~(~(1779444824 - ((0x266DCD93 ^ (0x6AA28D60 ^ -193251399)) - (-(~1090077708) - -(--15236363))) - (-num2 + (-(--1315023803) ^ -1470093440)) - -(-((0x2A2B2434 ^ 0x4D5BEDA9) + -622803604))) - 481531700 - -511968313))) % 6)
				{
				case 0u:
					break;
				default:
					goto end_IL_0297;
				case 5u:
					E3FB09D95D72411A((object)memoryStream);
					num7 = (int)(num3 * 1663412240) ^ -1784055614;
					continue;
				case 1u:
					goto IL_035c;
				case 3u:
					obj._184044A093C04AF2(9, 1065208251u);
					num7 = ((int)num3 * -427372903) ^ -1849051878;
					continue;
				case 2u:
					obj._184044A093C04AF2(6, 2202723633u);
					obj._184044A093C04AF2(11, 1746041221u);
					num7 = ((int)num3 * -1758975755) ^ -607849183;
					continue;
				case 4u:
					goto end_IL_0297;
				}
				break;
			}
			goto IL_02a9;
			IL_035c:
			obj._184044A093C04AF2(4, 327930559u);
			num7 = -1462442466;
			goto IL_02ae;
			end_IL_0297:;
		}
		obj._184044A093C04AF2(2, 940506916u);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static _4576FC03199245CB _41C9D77ADAE04B11(byte[] P_0, bool P_1, string P_2 = null)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(72272449u);
		MemoryStream memoryStream = (MemoryStream)_80E2E54642DF4E45(A5C11FF2F2E44E70(P_0));
		_4576FC03199245CB result2;
		_4576FC03199245CB result;
		try
		{
			obj._184044A093C04AF2(0, 1569219167u);
			BinaryReader binaryReader = (BinaryReader)C5A8CECF1F1745EE((object)memoryStream);
			try
			{
				obj._184044A093C04AF2(4, 3822873374u);
				int num4 = default;
				while (true)
				{
					IL_003b:
					int num = -525269719;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~((num2 ^ (621078547 + (~(-(~(909255715 + 294621433))) ^ ((-1322095721 ^ -(1546892427 - -599853081)) - 198343556)) - (~(~(~-482360277)) + (-(299534001 - -614938639) + -(-897445096 + -61556614)) * 646350025 + unchecked(unchecked(-863089957 * -1657580748) - ~unchecked((-732701903 ^ 0x34EC1AC5) * 1640598841) - unchecked(648293588 - ~unchecked(1568994494 * -194789943) + ~(~(-1151812215 - -2094685999))))))) - (-386566754 ^ -(~(~(~-1156090299) - unchecked(1977443143 * ~1013207094))))))) % 4)
						{
						case 0u:
							break;
						case 3u:
							num4 = E5B0EE0A15424036((object)binaryReader);
							num = (int)((num3 * 1754532086) ^ 0x29D63D4D);
							continue;
						case 1u:
						{
							if (P_1)
							{
								num = (int)((num3 * 1466080436) ^ 0x4BE0BFB6);
								continue;
							}
							obj._184044A093C04AF2(2, 2258335657u);
							B6EA2E2923064A56((object)binaryReader, num4);
							int num5 = E5B0EE0A15424036((object)binaryReader);
							byte[] array2 = B6EA2E2923064A56((object)binaryReader, num5);
							try
							{
								try
								{
									obj._184044A093C04AF2(0, 1548972265u);
									obj._184044A093C04AF2(6, 3816028417u);
									obj._184044A093C04AF2(3, 2343442840u);
									fixed (byte* ptr = &array2[_003CModule_003E._390073C602714496<int>(-1485990434 ^ (int)obj._184044A093C04AF2(5, 570610748u))])
									{
										result2 = _95E40DFE641445ED(ptr, num5, P_2);
									}
								}
								finally
								{
									obj = new _81DD83B8AA2247AA(600333626u);
									obj._184044A093C04AF2(7, 749022481u);
									obj._184044A093C04AF2(9, 4151494915u);
									obj._184044A093C04AF2(4, 3389292211u);
									fixed (byte* ptr = &Unsafe.AsRef<byte>((byte*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>(-847523903 ^ (int)obj._184044A093C04AF2(6, 43372019u))))
									{
									}
								}
							}
							finally
							{
								obj = new _81DD83B8AA2247AA(4147079274u);
								obj._184044A093C04AF2(6, 71899939u);
								obj._184044A093C04AF2(7, 2002030657u);
								obj._184044A093C04AF2(0, 1745125219u);
								byte* ptr3 = (byte*)(uint)_003CModule_003E.F84FA79ABE6944BB<int>(-1960624728 ^ (int)obj._184044A093C04AF2(5, 1545146835u));
							}
							goto end_IL_002d;
						}
						default:
						{
							obj._184044A093C04AF2(0, 2164329020u);
							byte[] array = B6EA2E2923064A56((object)binaryReader, num4);
							try
							{
								try
								{
									obj._184044A093C04AF2(10, 1709739688u);
									obj._184044A093C04AF2(3, 2343442840u);
									obj._184044A093C04AF2(8, 3713170133u);
									fixed (byte* ptr = &array[_003CModule_003E._58ECCB512F2A43AC<int>(-847523903 ^ (int)obj._184044A093C04AF2(5, 570610748u))])
									{
										result = _95E40DFE641445ED(ptr, num4, P_2);
									}
								}
								finally
								{
									obj = new _81DD83B8AA2247AA(29200526u);
									obj._184044A093C04AF2(8, 3406397575u);
									obj._184044A093C04AF2(10, 3389567687u);
									obj._184044A093C04AF2(5, 3617552559u);
									fixed (byte* ptr = &Unsafe.AsRef<byte>((byte*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-1495703356 ^ (int)obj._184044A093C04AF2(11, 1996479077u))))
									{
									}
								}
							}
							finally
							{
								obj = new _81DD83B8AA2247AA(1912895349u);
								obj._184044A093C04AF2(8, 1440082396u);
								obj._184044A093C04AF2(11, 3205083340u);
								obj._184044A093C04AF2(2, 1762846044u);
								byte* ptr2 = (byte*)(uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-1495703356 ^ (int)obj._184044A093C04AF2(9, 671994376u));
							}
							goto end_IL_0040;
						}
						}
						goto IL_003b;
						continue;
						end_IL_0040:
						break;
					}
					break;
				}
				goto IL_0664;
				end_IL_002d:;
			}
			finally
			{
				obj = new _81DD83B8AA2247AA(874044585u);
				if (binaryReader != null)
				{
					goto IL_03c0;
				}
				goto IL_04d2;
				IL_03c0:
				int num6 = 817118243;
				goto IL_03c5;
				IL_03c5:
				while (true)
				{
					int num2 = num6;
					uint num3;
					switch ((num3 = (uint)(~((num2 ^ (621078547 + (~(-(~(909255715 + 294621433))) ^ ((-1322095721 ^ -(1546892427 - -599853081)) - 198343556)) - (~(~(~-482360277)) + (-(299534001 - -614938639) + -(-897445096 + -61556614)) * 646350025 + unchecked(unchecked(-863089957 * -1657580748) - ~unchecked((-732701903 ^ 0x34EC1AC5) * 1640598841) - unchecked(648293588 - ~unchecked(1568994494 * -194789943) + ~(~(-1151812215 - -2094685999))))))) - (-386566754 ^ -(~(~(~-1156090299) - unchecked(1977443143 * ~1013207094))))))) % 4)
					{
					case 3u:
						break;
					default:
						goto end_IL_03ae;
					case 1u:
						E3FB09D95D72411A((object)binaryReader);
						num6 = ((int)num3 * -1380081436) ^ 0x3F46D9A4;
						continue;
					case 0u:
						goto IL_04d2;
					case 2u:
						goto end_IL_03ae;
					}
					break;
				}
				goto IL_03c0;
				IL_04d2:
				obj._184044A093C04AF2(1, 2933659604u);
				num6 = -787619738;
				goto IL_03c5;
				end_IL_03ae:;
			}
		}
		finally
		{
			obj = new _81DD83B8AA2247AA(801666528u);
			if (memoryStream != null)
			{
				goto IL_04fd;
			}
			goto IL_060f;
			IL_04fd:
			int num7 = -703139447;
			goto IL_0502;
			IL_0502:
			while (true)
			{
				int num2 = num7;
				uint num3;
				switch ((num3 = (uint)(~((num2 ^ (621078547 + (~(-(~(909255715 + 294621433))) ^ ((-1322095721 ^ -(1546892427 - -599853081)) - 198343556)) - (~(~(~-482360277)) + (-(299534001 - -614938639) + -(-897445096 + -61556614)) * 646350025 + unchecked(unchecked(-863089957 * -1657580748) - ~unchecked((-732701903 ^ 0x34EC1AC5) * 1640598841) - unchecked(648293588 - ~unchecked(1568994494 * -194789943) + ~(~(-1151812215 - -2094685999))))))) - (-386566754 ^ -(~(~(~-1156090299) - unchecked(1977443143 * ~1013207094))))))) % 4)
				{
				case 2u:
					break;
				default:
					goto end_IL_04eb;
				case 3u:
					E3FB09D95D72411A((object)memoryStream);
					num7 = (int)((num3 * 1451890414) ^ 0x34D858EE);
					continue;
				case 0u:
					goto IL_060f;
				case 1u:
					goto end_IL_04eb;
				}
				break;
			}
			goto IL_04fd;
			IL_060f:
			obj._184044A093C04AF2(0, 3013369129u);
			obj._184044A093C04AF2(5, 1551764189u);
			obj._184044A093C04AF2(10, 1738772713u);
			obj._184044A093C04AF2(3, 3492737207u);
			num7 = 166825243;
			goto IL_0502;
			end_IL_04eb:;
		}
		obj._184044A093C04AF2(9, 377231710u);
		return result2;
		IL_0664:
		obj._184044A093C04AF2(0, 3525884476u);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static _4576FC03199245CB _20533EEE01434310(byte[] P_0, string P_1 = null)
	{
		fixed (byte* ptr = &P_0[_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x556270C2 ^ new _81DD83B8AA2247AA(2527221295u)._184044A093C04AF2(1, 1539656543u)))])
		{
			return _95E40DFE641445ED(ptr, P_0.Length, P_1);
		}
	}

	public unsafe static _4576FC03199245CB A2CC73A6278B4B6D(Stream P_0, string P_1 = null)
	{
		if (P_0 is MemoryStream memoryStream)
		{
			while (true)
			{
				int num = 1790712396;
				uint num2;
				switch ((num2 = (uint)(-num + ((0x30B817E8 ^ -(-2092986899 * -254544438)) - (-1994647801 ^ (0x464BF75E ^ (0x2C5CE9CA ^ -1676155501))) - (unchecked((0x12C91C22 ^ -143632955) * -2027912373) + --665383932 * 2063042541 + -544466118)) - -(((-749969647 ^ 0x3399EB2D) + -1369298702) * -1998711185 - (~1545382667 + 912840787 - unchecked(-514305297 * (-163171363 + 578979056)))))) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return (_4576FC03199245CB)B8FF7B5FE19E466B(_1E9CF73DD9D048B0((object)memoryStream), P_1);
				}
				break;
			}
		}
		if (P_0 is UnmanagedMemoryStream unmanagedMemoryStream)
		{
			try
			{
				return _95E40DFE641445ED(_11DFDBE096874068((object)unmanagedMemoryStream), _22A2AEF89D9244D4((object)unmanagedMemoryStream) - BDF7C109A59D42F8((object)unmanagedMemoryStream), P_1);
			}
			catch (NotSupportedException)
			{
			}
		}
		MemoryStream memoryStream2 = (MemoryStream)_2C00A37AFCBC46A1();
		DF547174CCC749FC((object)P_0, (object)memoryStream2);
		byte[] array = _1E9CF73DD9D048B0((object)memoryStream2);
		_51F3EF91BEAE4D3E((object)memoryStream2);
		return (_4576FC03199245CB)B8FF7B5FE19E466B(array, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static _4576FC03199245CB _95E40DFE641445ED(byte* P_0, long P_1, string P_2 = null)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1236392308u);
		Dictionary<IntPtr, LibraryInfo> dictionary = _0351B80197284DBB;
		bool flag = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(-299985784 ^ (int)obj._184044A093C04AF2(2, 1783926810u)) != 0;
		_4576FC03199245CB result = default;
		try
		{
			obj = new _81DD83B8AA2247AA(1001968637u);
			D0BBA94499114834((object)dictionary, ref flag);
			_4576FC03199245CB obj2 = new _4576FC03199245CB();
			IntPtr intPtr = _3844AE3CB9A447C0.B73431636FF14D3E(P_0, P_1, null, null, obj2.A71E2C07B8FA4999, A598BA7997E44F51, F7E968C5A6324E22);
			while (true)
			{
				IL_0064:
				int num = 1009863400;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((-((-(-(--716567590) - num2) ^ (-(unchecked(unchecked(-1177937895 * -1308417361) - 1796914549) + (-1202401332 ^ 0x126DC682)) - unchecked(1622583607 * -1628390277))) + unchecked(~(~(0x3D85ABF5 ^ -344274848)) * 1770633055)) ^ -1774792022) * -153483739)) % 9)
					{
					case 6u:
						break;
					default:
						goto end_IL_0069;
					case 2u:
						obj._184044A093C04AF2(6, 3150839156u);
						obj2._8917050ED83C462E = P_2;
						obj2.D18967752BCC462F = intPtr;
						result = obj2;
						num = 206514778;
						continue;
					case 4u:
						obj._184044A093C04AF2(4, 861278183u);
						num = ((int)num3 * -1175757166) ^ -1717194017;
						continue;
					case 7u:
						_3C146FC7BFB8420F[P_2].Add(intPtr);
						num = (int)((num3 * 432584632) ^ 0x3E5FE3A3);
						continue;
					case 5u:
					{
						_0351B80197284DBB.Add(intPtr, (LibraryInfo)F69347F796144CD1(P_2));
						int num6;
						int num7;
						if (!_113210D4BE1743B4(P_2))
						{
							num6 = -271660392;
							num7 = num6;
						}
						else
						{
							num6 = -2093974303;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 1276976701);
						continue;
					}
					case 0u:
					{
						int num4;
						int num5;
						if (!_3C146FC7BFB8420F.ContainsKey(P_2))
						{
							num4 = -1140058789;
							num5 = num4;
						}
						else
						{
							num4 = -1348591807;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -259399428);
						continue;
					}
					case 8u:
						_3C146FC7BFB8420F.Add(P_2, new HashSet<IntPtr>());
						num = ((int)num3 * -748911607) ^ 0x1FA4BF74;
						continue;
					case 1u:
						obj._184044A093C04AF2(0, 861278183u);
						num = -1172098270;
						continue;
					case 3u:
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
		finally
		{
			obj = new _81DD83B8AA2247AA(2829801503u);
			while (true)
			{
				IL_0220:
				int num8 = -1154741935;
				while (true)
				{
					int num2 = num8;
					uint num3;
					switch ((num3 = (uint)((-((-(-(--716567590) - num2) ^ (-(unchecked(unchecked(-1177937895 * -1308417361) - 1796914549) + (-1202401332 ^ 0x126DC682)) - unchecked(1622583607 * -1628390277))) + unchecked(~(~(0x3D85ABF5 ^ -344274848)) * 1770633055)) ^ -1774792022) * -153483739)) % 6)
					{
					case 5u:
						break;
					case 1u:
					{
						int num9;
						int num10;
						if (!flag)
						{
							num9 = 595181040;
							num10 = num9;
						}
						else
						{
							num9 = -1250443432;
							num10 = num9;
						}
						num8 = num9 ^ ((int)num3 * -1933257920);
						continue;
					}
					case 3u:
						obj._184044A093C04AF2(5, 530259806u);
						num8 = (int)((num3 * 699520084) ^ 0x408362C8);
						continue;
					case 0u:
						obj._184044A093C04AF2(8, 3792335458u);
						num8 = 1773771139;
						continue;
					case 2u:
						_0E532CD24F8B415A((object)dictionary);
						num8 = ((int)num3 * -1021829214) ^ 0x6E2DF784;
						continue;
					default:
						obj._184044A093C04AF2(2, 116686870u);
						obj._184044A093C04AF2(7, 2718653730u);
						goto end_IL_0225;
					}
					goto IL_0220;
					continue;
					end_IL_0225:
					break;
				}
				break;
			}
		}
		obj._184044A093C04AF2(2, 669640080u);
		return result;
	}

	public void _2BEB536B96054BF6()
	{
		IntPtr intPtr = _08AC8F9D9B1A4DD3(ref D18967752BCC462F, default(IntPtr));
		DB3176DD8E604CFF(intPtr);
	}

	public _0001 _523ED1473CD44440<_0001>(string P_0) where _0001 : Delegate
	{
		return Marshal.GetDelegateForFunctionPointer<_0001>(_3844AE3CB9A447C0._833AD5F7E7AC4C9D(D18967752BCC462F, P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static bool DB3176DD8E604CFF(IntPtr P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2459991084u);
		Dictionary<IntPtr, LibraryInfo> dictionary = _0351B80197284DBB;
		bool flag = (byte)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x624FCEE7 ^ obj._184044A093C04AF2(0, 2107423799u))) != 0;
		bool result = default;
		try
		{
			obj = new _81DD83B8AA2247AA(2122821994u);
			D0BBA94499114834((object)dictionary, ref flag);
			try
			{
				obj._184044A093C04AF2(0, 853536840u);
				LibraryInfo libraryInfo = default;
				while (true)
				{
					IL_004d:
					int num = 1103509660;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(-(-(~(~(num2 * 1344773259 - --1959373610))) ^ 0x15CA0253) * 1814608371)) % 12)
						{
						case 7u:
							break;
						case 3u:
							libraryInfo.RefCount -= (uint)_003CModule_003E._3F57E81A62734AC2<int>(-1663797211 ^ (int)obj._184044A093C04AF2(1, 39202284u));
							num = ((int)num3 * -867781307) ^ -1081129417;
							continue;
						case 0u:
							_3C146FC7BFB8420F.Remove(libraryInfo.Name);
							num = ((int)num3 * -1943637044) ^ 0x4AB222A4;
							continue;
						case 5u:
							obj._184044A093C04AF2(0, 445897906u);
							obj._184044A093C04AF2(7, 3134611971u);
							obj._184044A093C04AF2(10, 3493957037u);
							result = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-1372026428 ^ (int)obj._184044A093C04AF2(1, 4115455697u)) != 0;
							goto end_IL_0052;
						case 4u:
						{
							int num6;
							int num7;
							if (libraryInfo.Name != null)
							{
								num6 = 2122668797;
								num7 = num6;
							}
							else
							{
								num6 = 1158167256;
								num7 = num6;
							}
							num = num6 ^ (int)(num3 * 1173172311);
							continue;
						}
						case 2u:
							libraryInfo = _0351B80197284DBB[P_0];
							num = (int)(num3 * 967820759) ^ -1483011676;
							continue;
						case 9u:
						{
							int num10;
							int num11;
							if (libraryInfo.RefCount != 0)
							{
								num10 = 127778697;
								num11 = num10;
							}
							else
							{
								num10 = 1652709498;
								num11 = num10;
							}
							num = num10 ^ (int)(num3 * 463345037);
							continue;
						}
						case 1u:
						{
							int num12;
							int num13;
							if (!(P_0 != IntPtr.Zero))
							{
								num12 = 1331918889;
								num13 = num12;
							}
							else
							{
								num12 = -1390132476;
								num13 = num12;
							}
							num = num12 ^ ((int)num3 * -1567891373);
							continue;
						}
						case 6u:
							_3844AE3CB9A447C0.D829FB42EDC342B1(P_0);
							_0351B80197284DBB.Remove(P_0);
							num = (int)((num3 * 856841417) ^ 0x1476F33F);
							continue;
						case 10u:
						{
							int num8;
							int num9;
							if (!_0351B80197284DBB.ContainsKey(P_0))
							{
								num8 = 1555244018;
								num9 = num8;
							}
							else
							{
								num8 = 2121318231;
								num9 = num8;
							}
							num = num8 ^ (int)(num3 * 1351725788);
							continue;
						}
						case 8u:
						{
							HashSet<IntPtr> hashSet = _3C146FC7BFB8420F[libraryInfo.Name];
							hashSet.Remove(P_0);
							int num4;
							int num5;
							if (hashSet.Count != 0)
							{
								num4 = -1707327396;
								num5 = num4;
							}
							else
							{
								num4 = -569948263;
								num5 = num4;
							}
							num = num4 ^ (int)(num3 * 1491884478);
							continue;
						}
						default:
							obj._184044A093C04AF2(7, 3134611971u);
							obj._184044A093C04AF2(2, 3493957037u);
							obj._184044A093C04AF2(9, 4154657981u);
							result = (byte)_003CModule_003E.F84FA79ABE6944BB<int>(-373754555 ^ (int)obj._184044A093C04AF2(0, 445897906u)) != 0;
							goto end_IL_0052;
						}
						goto IL_004d;
						continue;
						end_IL_0052:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
				obj = new _81DD83B8AA2247AA(2465003895u);
				while (true)
				{
					IL_02dc:
					int num14 = 1121356258;
					while (true)
					{
						int num2 = num14;
						uint num3;
						switch ((num3 = (uint)(-(-(~(~(num2 * 1344773259 - --1959373610))) ^ 0x15CA0253) * 1814608371)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_02e1;
						case 1u:
							goto IL_031a;
						case 0u:
							goto end_IL_02e1;
						}
						goto IL_02dc;
						IL_031a:
						obj._184044A093C04AF2(2, 1085116304u);
						obj._184044A093C04AF2(3, 543065232u);
						obj._184044A093C04AF2(4, 3191545095u);
						result = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(-341585413 ^ (int)obj._184044A093C04AF2(9, 1956069232u)) != 0;
						num14 = ((int)num3 * -286430226) ^ -717759776;
						continue;
						end_IL_02e1:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			obj = new _81DD83B8AA2247AA(2778791143u);
			if (flag)
			{
				while (true)
				{
					int num15 = 2065814844;
					while (true)
					{
						int num2 = num15;
						uint num3;
						switch ((num3 = (uint)(-(-(~(~(num2 * 1344773259 - --1959373610))) ^ 0x15CA0253) * 1814608371)) % 3)
						{
						case 0u:
							break;
						case 2u:
							_0E532CD24F8B415A((object)dictionary);
							num15 = (int)((num3 * 685714590) ^ 0x1289EDF7);
							continue;
						default:
							goto end_IL_0382;
						}
						break;
					}
					continue;
					end_IL_0382:
					break;
				}
			}
			obj._184044A093C04AF2(8, 3810418327u);
		}
		obj._184044A093C04AF2(2, 2052255166u);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected static IntPtr _585684129D5F4032(string P_0, _4576FC03199245CB P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(890659550u);
		Dictionary<IntPtr, LibraryInfo> dictionary = default;
		IntPtr intPtr = default;
		HashSet<IntPtr> value = default;
		while (true)
		{
			int num = 960054957;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(~((num2 - -(~(-1440200219 * ~(0x66C8F3C3 ^ --1344514154)))) * -494433727 * -1509649053 * -1397234579))) + -654537136)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0065;
				default:
				{
					bool flag = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(-1967099934 ^ (int)obj._184044A093C04AF2(1, 1512243178u)) != 0;
					IntPtr result;
					try
					{
						obj = new _81DD83B8AA2247AA(1846684056u);
						D0BBA94499114834((object)dictionary, ref flag);
						while (true)
						{
							IL_00a8:
							int num4 = 1421622996;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(-(-(~((num2 - -(~(-1440200219 * ~(0x66C8F3C3 ^ --1344514154)))) * -494433727 * -1509649053 * -1397234579))) + -654537136)) % 6)
								{
								case 3u:
									break;
								case 4u:
									obj._184044A093C04AF2(4, 1632315404u);
									num4 = -905525229;
									continue;
								case 0u:
									result = intPtr;
									goto end_IL_00ad;
								case 5u:
								{
									intPtr = value.First();
									LibraryInfo libraryInfo = _0351B80197284DBB[intPtr];
									uint refCount = libraryInfo.RefCount;
									obj._184044A093C04AF2(0, 1632315404u);
									libraryInfo.RefCount = refCount + (uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-121534964 ^ (int)obj._184044A093C04AF2(7, 0u));
									num4 = (int)((num3 * 56944894) ^ 0x1238D802);
									continue;
								}
								case 2u:
								{
									int num5;
									int num6;
									if (_3C146FC7BFB8420F.TryGetValue(P_0, out value))
									{
										num5 = -263163385;
										num6 = num5;
									}
									else
									{
										num5 = -1661442714;
										num6 = num5;
									}
									num4 = num5 ^ (int)(num3 * 1526260935);
									continue;
								}
								default:
									result = IntPtr.Zero;
									goto end_IL_00ad;
								}
								goto IL_00a8;
								continue;
								end_IL_00ad:
								break;
							}
							break;
						}
					}
					finally
					{
						obj = new _81DD83B8AA2247AA(4233542084u);
						if (flag)
						{
							goto IL_01da;
						}
						goto IL_0251;
						IL_01da:
						int num7 = 717504056;
						goto IL_01df;
						IL_01df:
						while (true)
						{
							num2 = num7;
							switch ((num3 = (uint)(-(-(~((num2 - -(~(-1440200219 * ~(0x66C8F3C3 ^ --1344514154)))) * -494433727 * -1509649053 * -1397234579))) + -654537136)) % 5)
							{
							case 0u:
								break;
							default:
								goto end_IL_01cb;
							case 2u:
								_0E532CD24F8B415A((object)dictionary);
								num7 = ((int)num3 * -991778116) ^ -62879161;
								continue;
							case 1u:
								goto IL_0251;
							case 3u:
								obj._184044A093C04AF2(5, 3716525268u);
								obj._184044A093C04AF2(6, 447991260u);
								obj._184044A093C04AF2(7, 2579420716u);
								num7 = (int)(num3 * 331041430) ^ -335833426;
								continue;
							case 4u:
								goto end_IL_01cb;
							}
							break;
						}
						goto IL_01da;
						IL_0251:
						obj._184044A093C04AF2(0, 1669575376u);
						num7 = -1633253090;
						goto IL_01df;
						end_IL_01cb:;
					}
					obj._184044A093C04AF2(2, 3441257603u);
					return result;
				}
				}
				break;
				IL_0065:
				dictionary = _0351B80197284DBB;
				num = ((int)num3 * -698793758) ^ 0x2A07217C;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void* EBD3F14CC2B14DB4(char* P_0, void* P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(464062033u);
		void* ptr = default;
		while (true)
		{
			int num = -715479448;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-(num2 - -(--1717131267))) * -1506293543 - (~unchecked(1805619252 - -954473993) + (--727010534 - unchecked(-1477418367 * 2062921798))))) % 5)
				{
				case 0u:
					break;
				case 3u:
					obj = new _81DD83B8AA2247AA(4052306291u);
					num = -267344333;
					continue;
				case 1u:
					obj = new _81DD83B8AA2247AA(2708869672u);
					return (void*)_585684129D5F4032(A9B0853DA1894A45((IntPtr)P_0), this);
				case 2u:
				{
					ptr = _3844AE3CB9A447C0.EC0D0BB57C55490C(P_0, P_1);
					int num4;
					int num5;
					if (ptr != (void*)(uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x6A625ECD ^ obj._184044A093C04AF2(9, 3494989506u))))
					{
						num4 = -1417567682;
						num5 = num4;
					}
					else
					{
						num4 = 1060396345;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -858326301);
					continue;
				}
				default:
					return ptr;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _243F2CEC4E874966(void* P_0, char* P_1, void* P_2)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(849028527u);
		IntPtr key = (IntPtr)P_0;
		Dictionary<IntPtr, LibraryInfo> dictionary = _0351B80197284DBB;
		bool flag = (byte)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x500C1013 ^ obj._184044A093C04AF2(4, 115043006u))) != 0;
		void* result;
		try
		{
			obj = new _81DD83B8AA2247AA(3674763314u);
			while (true)
			{
				IL_003e:
				int num = -366895249;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(~(num2 ^ ((~(-(-1011725484 ^ 0x330938F1) + unchecked(-1283870489 - -275700915 + unchecked(1465331533 * -1489618110) + unchecked(1852263487 * (1083600374 - 89844501)))) - 1329684023) ^ (-(-((-1416978777 ^ -1603655270) + --327203831)) + unchecked(unchecked(1751143903 * -1916775098) * -501528383))))) - (-1163741744 + -885442437 + (0x2398B98 ^ 0x15580EA2) + (-(~63806959) - ~(~1956703896))))) % 6)
					{
					case 0u:
						break;
					default:
						goto end_IL_0043;
					case 1u:
						obj._184044A093C04AF2(10, 1129918952u);
						result = _3844AE3CB9A447C0._3D853D3971AB40BD(P_0, P_1);
						goto IL_02e3;
					case 3u:
					{
						int num4;
						int num5;
						if (!_0351B80197284DBB.ContainsKey(key))
						{
							num4 = -1502076042;
							num5 = num4;
						}
						else
						{
							num4 = -1677943351;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1083709364);
						continue;
					}
					case 4u:
						obj._184044A093C04AF2(2, 1129918952u);
						num = 490055590;
						continue;
					case 5u:
						D0BBA94499114834((object)dictionary, ref flag);
						num = ((int)num3 * -434197155) ^ 0x43E3E782;
						continue;
					case 2u:
						goto end_IL_0043;
					}
					goto IL_003e;
					continue;
					end_IL_0043:
					break;
				}
				break;
			}
		}
		finally
		{
			obj = new _81DD83B8AA2247AA(412980548u);
			if (flag)
			{
				goto IL_01ae;
			}
			goto IL_0284;
			IL_01ae:
			int num6 = -1177017871;
			goto IL_01b3;
			IL_01b3:
			while (true)
			{
				int num2 = num6;
				uint num3;
				switch ((num3 = (uint)(-(~(num2 ^ ((~(-(-1011725484 ^ 0x330938F1) + unchecked(-1283870489 - -275700915 + unchecked(1465331533 * -1489618110) + unchecked(1852263487 * (1083600374 - 89844501)))) - 1329684023) ^ (-(-((-1416978777 ^ -1603655270) + --327203831)) + unchecked(unchecked(1751143903 * -1916775098) * -501528383))))) - (-1163741744 + -885442437 + (0x2398B98 ^ 0x15580EA2) + (-(~63806959) - ~(~1956703896))))) % 4)
				{
				case 0u:
					break;
				case 1u:
					_0E532CD24F8B415A((object)dictionary);
					num6 = (int)(num3 * 1185234651) ^ -1544899711;
					continue;
				case 2u:
					goto IL_0284;
				default:
					obj._184044A093C04AF2(2, 2053066718u);
					obj._184044A093C04AF2(3, 2056271378u);
					goto end_IL_019c;
				}
				break;
			}
			goto IL_01ae;
			IL_0284:
			obj._184044A093C04AF2(4, 870565302u);
			obj._184044A093C04AF2(5, 2437341806u);
			num6 = -155742757;
			goto IL_01b3;
			end_IL_019c:;
		}
		obj._184044A093C04AF2(8, 2728783540u);
		return _3844AE3CB9A447C0._6637E1B8D0144B96(P_0, P_1, P_2);
		IL_02e3:
		obj._184044A093C04AF2(4, 2972610591u);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static bool _25075F43F6A54161(void* P_0, void* P_1)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2425797885u);
		while (true)
		{
			int num = 123517651;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(~(-1053699515 - -118188502))) - ~((num2 ^ -((-(-unchecked(-521173965 * 1857157414) ^ 0x72C9F9E6) + -(-1066069443 + (0x5098205E ^ -1683991068))) * 1677322451)) + unchecked(1135477193 * 265844646)) - unchecked(1956280894 - (0x50110CCC ^ -1738636473)))) % 5)
				{
				case 3u:
					break;
				case 1u:
				{
					int num4;
					int num5;
					if (!DB3176DD8E604CFF((IntPtr)P_0))
					{
						num4 = -1086287957;
						num5 = num4;
					}
					else
					{
						num4 = -1448816220;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -130895682);
					continue;
				}
				case 4u:
					return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-866383351 ^ (int)obj._184044A093C04AF2(1, 3782297808u)) != 0;
				case 2u:
					obj._184044A093C04AF2(4, 1055154243u);
					num = 2090454730;
					continue;
				default:
					return _3844AE3CB9A447C0._7405053409264778(P_0, P_1);
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _3C4446345E4F4C4E(bool P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(450066258u);
		if (!A9EECB1D5A9540AA)
		{
			goto IL_0017;
		}
		goto IL_009e;
		IL_0017:
		int num = 1498923890;
		goto IL_001c;
		IL_001c:
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)((-((~num2 - unchecked(-29535225 * -863546623)) ^ 0xE5FCE33) - ~(--975447005 + --290979257) - ~(-32455523) - unchecked(355319421 - -1839252693)) ^ -1561942723)) % 5)
			{
			case 3u:
				break;
			default:
				return;
			case 4u:
				goto IL_009e;
			case 2u:
				A9EECB1D5A9540AA = (byte)_003CModule_003E._3F57E81A62734AC2<int>((int)(0xC64355 ^ obj._184044A093C04AF2(3, 0u))) != 0;
				num = (int)((num3 * 95646865) ^ 0x2A3E226B);
				continue;
			case 1u:
				A959D27E5E8E4F6C((object)this);
				num = ((int)num3 * -1620111830) ^ 0x20F27757;
				continue;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0017;
		IL_009e:
		obj._184044A093C04AF2(6, 1539200930u);
		num = 1595755986;
		goto IL_001c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _3D3B00FCB3D947D7()
	{
		_81DD83B8AA2247AA obj;
		try
		{
			obj = new _81DD83B8AA2247AA(4150435761u);
			while (true)
			{
				IL_000c:
				int num = 532613078;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(~(-(~(~(num2 + (((120714972 - (-(-402632200 ^ -92337215) - (1101392109 - -1039076328))) ^ ~((-494908416 ^ 0x11B05C17) - -(--2138250379 ^ 0x75683A7D))) + (1250811597 + ~(unchecked(849411765 * -1451394704) - (-54146233 - -800072896)) - -(~(~(~-1596775338))) + (1529685483 - -(-(0x2B01206D ^ -1090366232)))))) * -1091366929))) - (0x740DE013 ^ 0x277E981E)))) % 3)
					{
					case 0u:
						break;
					default:
						goto end_IL_0011;
					case 1u:
						goto IL_00ef;
					case 2u:
						goto end_IL_0011;
					}
					goto IL_000c;
					IL_00ef:
					obj._184044A093C04AF2(3, 663293199u);
					obj._184044A093C04AF2(10, 691792883u);
					obj._184044A093C04AF2(1, 2706169009u);
					_3C4446345E4F4C4E((byte)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x1D7A19AF ^ obj._184044A093C04AF2(0, 2042636467u))) != 0);
					num = (int)(num3 * 1223942245) ^ -1051516837;
					continue;
					end_IL_0011:
					break;
				}
				break;
			}
		}
		finally
		{
			obj = new _81DD83B8AA2247AA(1027962402u);
			base.Finalize();
		}
		obj._184044A093C04AF2(8, 314342000u);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(4133118617u);
		while (true)
		{
			int num = 1536503137;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-589564526 - 193038525) - -((num2 - (((--1502828027 + 1815207271 + (-(-1542561404 ^ 0x77491AD3) ^ -1139783439)) ^ -1721843950) + 564849791 * (0x52A5E5DD ^ (-(~1848387833) ^ 0x1DF4CD13))) * 1182537131 - ~(1910113412 - ~((0x2BA4C50C ^ -1607534589) - (806172335 + -1145095821)) - ((-846480641 ^ 0x767F2267) - -(-519611426 ^ -51194124)))) * 406999507) * -2131289967 - -2059757007 - -752803476)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0138;
				case 1u:
					return;
				}
				break;
				IL_0138:
				_3C4446345E4F4C4E((byte)_003CModule_003E._3F57E81A62734AC2<int>(-1763453410 ^ (int)obj._184044A093C04AF2(6, 389426124u)) != 0);
				_41F2CF5305F647DE((object)this);
				num = (int)(num3 * 998793210) ^ -1622258384;
			}
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	static object _80E2E54642DF4E45(byte[] P_0)
	{
		return new MemoryStream(P_0);
	}

	static object AF950BFB188B48FB(object P_0, CompressionMode P_1)
	{
		return new GZipStream((Stream)P_0, P_1);
	}

	static object _2C00A37AFCBC46A1()
	{
		return new MemoryStream();
	}

	static void DF547174CCC749FC(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	static byte[] _1E9CF73DD9D048B0(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	static void E3FB09D95D72411A(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static byte[] A5C11FF2F2E44E70(byte[] P_0)
	{
		return C836DFA372C34677(P_0);
	}

	static object C5A8CECF1F1745EE(object P_0)
	{
		return new BinaryReader((Stream)P_0);
	}

	static int E5B0EE0A15424036(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	static byte[] B6EA2E2923064A56(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	static object B8FF7B5FE19E466B(byte[] P_0, string P_1)
	{
		return _20533EEE01434310(P_0, P_1);
	}

	unsafe static byte* _11DFDBE096874068(object P_0)
	{
		return ((UnmanagedMemoryStream)P_0).PositionPointer;
	}

	static long _22A2AEF89D9244D4(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	static long BDF7C109A59D42F8(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	static void _51F3EF91BEAE4D3E(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	static void D0BBA94499114834(object P_0, ref bool P_1)
	{
		Monitor.Enter(P_0, ref P_1);
	}

	static object F69347F796144CD1(string P_0)
	{
		return new LibraryInfo(P_0);
	}

	static bool _113210D4BE1743B4(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static void _0E532CD24F8B415A(object P_0)
	{
		Monitor.Exit(P_0);
	}

	static IntPtr _08AC8F9D9B1A4DD3(ref IntPtr P_0, IntPtr P_1)
	{
		return Interlocked.Exchange(ref P_0, P_1);
	}

	static string A9B0853DA1894A45(IntPtr P_0)
	{
		return Marshal.PtrToStringAnsi(P_0);
	}

	static void A959D27E5E8E4F6C(object P_0)
	{
		((_4576FC03199245CB)P_0)._2BEB536B96054BF6();
	}

	static void _41F2CF5305F647DE(object P_0)
	{
		GC.SuppressFinalize(P_0);
	}

	static object DEE9BB7D2E004099()
	{
		return StringComparer.InvariantCultureIgnoreCase;
	}
}
