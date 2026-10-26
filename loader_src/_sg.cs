using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

internal class _sg : IDisposable
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

	private static readonly Dictionary<IntPtr, LibraryInfo> _if = (Dictionary<IntPtr, LibraryInfo>)Activator.CreateInstance(typeof(Dictionary<IntPtr, LibraryInfo>));

	private static readonly Dictionary<string, HashSet<IntPtr>> _9B;

	private static readonly CustomGetProcAddressFunc _KA;

	private static readonly CustomFreeLibraryFunc _hd;

	private IntPtr _Wh;

	private string _Mm;

	private bool _sM;

	private readonly CustomLoadLibraryFunc _JL;

	public string _0c => _Mm;

	private unsafe _sg()
	{
		while (true)
		{
			int num = 1880954560;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-(~num2 - ((~(~(--491188756) ^ -1241093057) ^ 0x234BB141) + 1485307121 * -471374099) - 1044646501 * 1174554292) * 1216245777 - -193371965) ^ -1070322184 ^ -1472435922)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0089;
				case 1u:
					return;
				}
				break;
				IL_0089:
				_JL = _rn<char, Dictionary<IntPtr, LibraryInfo>, bool, HashSet<IntPtr>, IntPtr, string>;
				num = ((int)num3 * -1188378029) ^ 0x41DA268F;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T0[] _v<T0, T1, T2>(T0[] P_0)
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2657073174u);
		T1 val = (T1)_206C_206C_206E_206E_200B_206B_200B_206C_206A_206B_202D_202D_206D_200C_200D_206E_202C_206A_206B_206D_206A_202B_206C_200B_200F_206E_206B_202A_200E_202A_206E_206B_206D_202D_206C_200E_202E_202D_200B_206E_202E((byte[])(object)P_0);
		T0[] result = default(T0[]);
		try
		{
			T2 val2 = (T2)_206B_206B_206A_202A_206D_200C_200C_200E_202D_206F_202E_206A_202B_202A_202D_206A_200B_206D_202C_202E_202C_206C_200E_202A_202B_202C_202D_202A_202E_206C_206C_202D_206E_202A_202E_206C_202A_200E_200B_200D_202E((object)val, (CompressionMode)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x8C09FD2 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3535281899u))));
			try
			{
				obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3201608063u);
				T1 val3 = (T1)_206B_202E_202E_206F_202C_200B_200F_202D_200D_202E_200F_200F_206D_202A_206E_206F_200C_206E_200D_202A_206E_206E_206A_200F_202D_206B_206B_206C_206E_202B_202B_200B_200B_200C_202E_206B_206E_206B_202D_200E_202E();
				try
				{
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2158073961u);
					while (true)
					{
						IL_0053:
						int num = -1646953668;
						while (true)
						{
							int num2 = num;
							uint num3;
							switch ((num3 = (uint)(-((~(-num2 * 354160257 - ((-(-1016368640 ^ -263038407) ^ -508950791 ^ -(~(-526270005 + 2132251062))) + 1612489997 * -(439447117 + 1243545892) * -1567231261) - -1772670126) + -(-1980154539 * 2047001141)) ^ 0x367265F8))) % 4)
							{
							case 0u:
								break;
							default:
								goto end_IL_0058;
							case 3u:
								_202A_202E_202E_206C_200E_200E_206C_200E_200F_206D_206F_200C_202C_202D_206F_202C_206D_200C_202D_202D_202D_200F_202B_200F_206C_206A_206D_206E_206C_200E_202B_206B_200B_200B_200F_206A_206A_200F_206E_202B_202E((object)val2, (object)val3);
								num = (int)(num3 * 577781474) ^ -1444105460;
								continue;
							case 1u:
								result = (T0[])(object)_206C_200E_202B_202A_200F_202B_206E_200F_206D_206F_206D_206D_202E_206D_202C_206B_206A_200C_206E_202E_202C_202E_206F_200C_206C_206A_206C_202C_200D_200F_202A_206D_206A_206D_200E_206D_202E_200E_200B_200F_202E((object)val3);
								num = (int)((num3 * 122442293) ^ 0x44355F90);
								continue;
							case 2u:
								goto end_IL_0058;
							}
							goto IL_0053;
							continue;
							end_IL_0058:
							break;
						}
						break;
					}
				}
				finally
				{
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1462757191u);
					while (true)
					{
						IL_012b:
						int num4 = 48532624;
						while (true)
						{
							int num2 = num4;
							uint num3;
							switch ((num3 = (uint)(-((~(-num2 * 354160257 - ((-(-1016368640 ^ -263038407) ^ -508950791 ^ -(~(-526270005 + 2132251062))) + 1612489997 * -(439447117 + 1243545892) * -1567231261) - -1772670126) + -(-1980154539 * 2047001141)) ^ 0x367265F8))) % 8)
							{
							case 2u:
								break;
							default:
								goto end_IL_0130;
							case 4u:
								obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1034300177u);
								num4 = -246272012;
								continue;
							case 6u:
								_202E_200E_206C_202C_200D_206A_202E_202D_200B_202B_206E_200F_202A_206D_206D_202D_202D_202A_200C_200B_200C_202B_200C_200F_202C_200E_202B_206D_206C_202E_202A_200B_202B_206A_202B_206E_206F_200E_200C_206D_202E((object)val3);
								num4 = ((int)num3 * -1107962348) ^ -693465497;
								continue;
							case 3u:
							{
								int num5;
								int num6;
								if (val3 != null)
								{
									num5 = 281664557;
									num6 = num5;
								}
								else
								{
									num5 = -590931361;
									num6 = num5;
								}
								num4 = num5 ^ ((int)num3 * -1315339296);
								continue;
							}
							case 0u:
								obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 15876552u);
								num4 = ((int)num3 * -654674107) ^ -2134511814;
								continue;
							case 7u:
								obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1623949368u);
								num4 = ((int)num3 * -170330906) ^ -343858756;
								continue;
							case 5u:
								obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3978154232u);
								num4 = (int)((num3 * 748620637) ^ 0x32BBBBAA);
								continue;
							case 1u:
								goto end_IL_0130;
							}
							goto IL_012b;
							continue;
							end_IL_0130:
							break;
						}
						break;
					}
				}
			}
			finally
			{
				obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3656324612u);
				while (true)
				{
					IL_0293:
					int num7 = -1282149241;
					while (true)
					{
						int num2 = num7;
						uint num3;
						switch ((num3 = (uint)(-((~(-num2 * 354160257 - ((-(-1016368640 ^ -263038407) ^ -508950791 ^ -(~(-526270005 + 2132251062))) + 1612489997 * -(439447117 + 1243545892) * -1567231261) - -1772670126) + -(-1980154539 * 2047001141)) ^ 0x367265F8))) % 8)
						{
						case 7u:
							break;
						default:
							goto end_IL_0298;
						case 4u:
						{
							int num8;
							int num9;
							if (val2 != null)
							{
								num8 = -1118337824;
								num9 = num8;
							}
							else
							{
								num8 = -714977202;
								num9 = num8;
							}
							num7 = num8 ^ (int)(num3 * 1747473458);
							continue;
						}
						case 1u:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1697951643u);
							num7 = (int)((num3 * 318462841) ^ 0x7ED9DE4A);
							continue;
						case 2u:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 136921147u);
							num7 = (int)(num3 * 821345676) ^ -453309926;
							continue;
						case 3u:
							_202E_200E_206C_202C_200D_206A_202E_202D_200B_202B_206E_200F_202A_206D_206D_202D_202D_202A_200C_200B_200C_202B_200C_200F_202C_200E_202B_206D_206C_202E_202A_200B_202B_206A_202B_206E_206F_200E_200C_206D_202E((object)val2);
							num7 = (int)(num3 * 1623574768) ^ -1592759786;
							continue;
						case 0u:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 3219677957u);
							num7 = ((int)num3 * -1730005147) ^ -360899547;
							continue;
						case 5u:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1991036082u);
							num7 = 669777489;
							continue;
						case 6u:
							goto end_IL_0298;
						}
						goto IL_0293;
						continue;
						end_IL_0298:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(983721128u);
			while (true)
			{
				IL_03fb:
				int num10 = 607526703;
				while (true)
				{
					int num2 = num10;
					uint num3;
					switch ((num3 = (uint)(-((~(-num2 * 354160257 - ((-(-1016368640 ^ -263038407) ^ -508950791 ^ -(~(-526270005 + 2132251062))) + 1612489997 * -(439447117 + 1243545892) * -1567231261) - -1772670126) + -(-1980154539 * 2047001141)) ^ 0x367265F8))) % 8)
					{
					case 2u:
						break;
					default:
						goto end_IL_0400;
					case 4u:
					{
						int num11;
						int num12;
						if (val == null)
						{
							num11 = -396596880;
							num12 = num11;
						}
						else
						{
							num11 = -1885927313;
							num12 = num11;
						}
						num10 = num11 ^ (int)(num3 * 680513559);
						continue;
					}
					case 7u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1831690142u);
						num10 = 1482341098;
						continue;
					case 0u:
						_202E_200E_206C_202C_200D_206A_202E_202D_200B_202B_206E_200F_202A_206D_206D_202D_202D_202A_200C_200B_200C_202B_200C_200F_202C_200E_202B_206D_206C_202E_202A_200B_202B_206A_202B_206E_206F_200E_200C_206D_202E((object)val);
						num10 = (int)((num3 * 1501525881) ^ 0x7735D84);
						continue;
					case 1u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1858068631u);
						num10 = (int)(num3 * 1256352449) ^ -861131207;
						continue;
					case 3u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 4747191u);
						num10 = (int)(num3 * 1781476147) ^ -90108244;
						continue;
					case 6u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 2956333993u);
						num10 = (int)((num3 * 27434800) ^ 0x7A1CBB2E);
						continue;
					case 5u:
						goto end_IL_0400;
					}
					goto IL_03fb;
					continue;
					end_IL_0400:
					break;
				}
				break;
			}
		}
		obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 548571961u);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static _sg _qk(byte[] P_0, bool P_1, string P_2 = null)
	{
		//The blocks IL_040c, IL_0411, IL_0449 are reachable both inside and outside the pinned region starting at IL_048c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		//The blocks IL_0193, IL_0198, IL_01d0 are reachable both inside and outside the pinned region starting at IL_0213. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(868939417u);
		MemoryStream memoryStream = (MemoryStream)_206C_206C_206E_206E_200B_206B_200B_206C_206A_206B_202D_202D_206D_200C_200D_206E_202C_206A_206B_206D_206A_202B_206C_200B_200F_206E_206B_202A_200E_202A_206E_206B_206D_202D_206C_200E_202E_202D_200B_206E_202E(_206B_202B_202B_206B_206B_206D_206E_202C_202E_206D_206B_200E_202B_202A_206B_200C_206B_200E_206E_202C_200B_206D_200F_202E_200D_202E_206B_206C_200C_206E_202A_206D_206E_202D_200B_206F_206D_200D_200C_200C_202E(P_0));
		_sg result2 = default(_sg);
		_sg result = default(_sg);
		int num2;
		uint num3;
		try
		{
			obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1923578258u);
			BinaryReader binaryReader = (BinaryReader)_206A_206A_202E_206F_200D_202E_202B_206F_206F_202D_202B_202C_206C_202C_200D_202E_202D_202A_200C_200F_202E_200F_200B_206F_202E_206A_202C_206A_200D_200C_200F_206D_206F_202D_202D_202A_206A_200C_202A_200D_202E((object)memoryStream);
			try
			{
				obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2184405254u);
				int num4 = default(int);
				int num11 = default(int);
				while (true)
				{
					IL_003d:
					int num = -12555144;
					while (true)
					{
						num2 = num;
						switch ((num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564)) % 5)
						{
						case 0u:
							break;
						case 1u:
							num4 = _200D_200C_206E_206D_202C_206B_202C_200F_202E_206F_200F_206E_202A_200F_202D_200F_206A_202A_206B_206E_206A_200E_202D_200B_202A_200B_202B_200C_206A_200E_200C_206A_202D_202C_206B_206C_206C_206E_202B_206A_202E((object)binaryReader);
							num = (int)((num3 * 462640058) ^ 0x76C0CC78);
							continue;
						case 3u:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 864482967u);
							num = (int)(num3 * 1503813784) ^ -2124205230;
							continue;
						case 4u:
							if (P_1)
							{
								num = ((int)num3 * -435527187) ^ 0x6733211D;
								continue;
							}
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2755825654u);
							while (true)
							{
								IL_02da:
								int num10 = 257115422;
								while (true)
								{
									num2 = num10;
									switch ((num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564)) % 4)
									{
									case 2u:
										break;
									case 3u:
										_202A_206E_200C_202D_206C_200C_200B_206B_200B_206C_206A_202E_206A_200F_206B_202D_206F_200C_200C_206D_200E_206F_202C_202A_202D_206E_200D_200F_200F_206E_202E_206B_206B_206A_202E_206A_206A_200D_202E_202E((object)binaryReader, num4);
										num10 = (int)((num3 * 936055959) ^ 0x4E27E932);
										continue;
									case 0u:
										num11 = _200D_200C_206E_206D_202C_206B_202C_200F_202E_206F_200F_206E_202A_200F_202D_200F_206A_202A_206B_206E_206A_200E_202D_200B_202A_200B_202B_200C_206A_200E_200C_206A_202D_202C_206B_206C_206C_206E_202B_206A_202E((object)binaryReader);
										num10 = (int)((num3 * 1750134247) ^ 0x586B4D60);
										continue;
									default:
									{
										byte[] array2 = _202A_206E_200C_202D_206C_200C_200B_206B_200B_206C_206A_202E_206A_200F_206B_202D_206F_200C_200C_206D_200E_206F_202C_202A_202D_206E_200D_200F_200F_206E_202E_206B_206B_206A_202E_206A_206A_200D_202E_202E((object)binaryReader, num11);
										try
										{
											try
											{
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 1355986951u);
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3028032441u);
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2638683644u);
												fixed (byte* ptr = &array2[global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x566645E7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 2747763997u)))])
												{
													while (true)
													{
														IL_03a1:
														int num12 = 1304109977;
														while (true)
														{
															num2 = num12;
															switch ((num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564)) % 3)
															{
															case 2u:
																break;
															default:
																goto end_IL_03a6;
															case 1u:
																goto IL_03de;
															case 0u:
																goto end_IL_03a6;
															}
															goto IL_03a1;
															IL_03de:
															result2 = _Im<Dictionary<IntPtr, LibraryInfo>, bool, IntPtr, byte, long, string, HashSet<IntPtr>>(ptr, num11, P_2);
															num12 = (int)(num3 * 1546338591) ^ -1739833191;
															continue;
															end_IL_03a6:
															break;
														}
														break;
													}
												}
											}
											finally
											{
												obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(540516004u);
												while (true)
												{
													int num13 = (num2 = -1587676466);
													uint num14 = (num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564));
													switch (num14 % 3)
													{
													case 2u:
														break;
													default:
														goto end_IL_040c;
													case 1u:
													{
														int num15 = -1184536404;
														obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 68054774u);
														obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3019335223u);
														obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 3496997266u);
														while (true)
														{
															IL_048c:
															fixed (byte* ptr = &Unsafe.AsRef<byte>((byte*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(num15 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3896732022u))))
															{
																num13 = (int)(num3 * 1654915224) ^ -968602959;
																while (true)
																{
																	num2 = num13;
																	num14 = (num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564));
																	switch (num14 % 3)
																	{
																	case 2u:
																		break;
																	default:
																		goto end_IL_0411;
																	case 1u:
																		num15 = -1184536404;
																		obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 68054774u);
																		obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3019335223u);
																		obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 3496997266u);
																		goto IL_048c;
																	case 0u:
																		goto end_IL_0411;
																	}
																	num13 = -1587676466;
																	continue;
																	end_IL_0411:
																	break;
																}
															}
															break;
														}
														goto end_IL_040c;
													}
													case 0u:
														goto end_IL_040c;
													}
													continue;
													end_IL_040c:
													break;
												}
											}
										}
										finally
										{
											obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3886155362u);
											while (true)
											{
												IL_04ae:
												int num16 = 1111075570;
												while (true)
												{
													num2 = num16;
													switch ((num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564)) % 3)
													{
													case 0u:
														break;
													default:
														goto end_IL_04b3;
													case 1u:
														goto IL_04eb;
													case 2u:
														goto end_IL_04b3;
													}
													goto IL_04ae;
													IL_04eb:
													obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 2621632592u);
													obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3926762233u);
													obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2258145008u);
													byte* ptr3 = (byte*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-377374403 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2321665008u));
													num16 = (int)((num3 * 669837797) ^ 0x490BB42F);
													continue;
													end_IL_04b3:
													break;
												}
												break;
											}
										}
										goto end_IL_02df;
									}
									}
									goto IL_02da;
									continue;
									end_IL_02df:
									break;
								}
								break;
							}
							goto end_IL_002e;
						default:
						{
							byte[] array = _202A_206E_200C_202D_206C_200C_200B_206B_200B_206C_206A_202E_206A_200F_206B_202D_206F_200C_200C_206D_200E_206F_202C_202A_202D_206E_200D_200F_200F_206E_202E_206B_206B_206A_202E_206A_206A_200D_202E_202E((object)binaryReader, num4);
							try
							{
								try
								{
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 126157547u);
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2281368878u);
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 1355986951u);
									fixed (byte* ptr = &array[global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-2008256067 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2638683644u))])
									{
										while (true)
										{
											IL_0128:
											int num5 = 1951389139;
											while (true)
											{
												num2 = num5;
												switch ((num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564)) % 3)
												{
												case 0u:
													break;
												default:
													goto end_IL_012d;
												case 1u:
													goto IL_0165;
												case 2u:
													goto end_IL_012d;
												}
												goto IL_0128;
												IL_0165:
												result = _Im<Dictionary<IntPtr, LibraryInfo>, bool, IntPtr, byte, long, string, HashSet<IntPtr>>(ptr, num4, P_2);
												num5 = ((int)num3 * -1635174623) ^ -1164614658;
												continue;
												end_IL_012d:
												break;
											}
											break;
										}
									}
								}
								finally
								{
									obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2338319209u);
									while (true)
									{
										int num6 = (num2 = 1249162405);
										uint num7 = (num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564));
										switch (num7 % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0193;
										case 1u:
										{
											int num8 = 1973689012;
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2785609179u);
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 4174919218u);
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2099810587u);
											while (true)
											{
												IL_0213:
												fixed (byte* ptr = &Unsafe.AsRef<byte>((byte*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(num8 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 522147031u))))
												{
													num6 = ((int)num3 * -203080450) ^ 0x2B8803A1;
													while (true)
													{
														num2 = num6;
														num7 = (num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564));
														switch (num7 % 3)
														{
														case 0u:
															break;
														default:
															goto end_IL_0198;
														case 1u:
															num8 = 1973689012;
															obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2785609179u);
															obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 4174919218u);
															obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2099810587u);
															goto IL_0213;
														case 2u:
															goto end_IL_0198;
														}
														num6 = 1249162405;
														continue;
														end_IL_0198:
														break;
													}
												}
												break;
											}
											goto end_IL_0193;
										}
										case 2u:
											goto end_IL_0193;
										}
										continue;
										end_IL_0193:
										break;
									}
								}
							}
							finally
							{
								obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3708656172u);
								while (true)
								{
									IL_0235:
									int num9 = 1428560208;
									while (true)
									{
										num2 = num9;
										switch ((num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564)) % 3)
										{
										case 2u:
											break;
										default:
											goto end_IL_023a;
										case 1u:
											goto IL_0272;
										case 0u:
											goto end_IL_023a;
										}
										goto IL_0235;
										IL_0272:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3913045502u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2469345455u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 4102027390u);
										byte* ptr2 = (byte*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-901519762 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 2947207450u));
										num9 = ((int)num3 * -827433655) ^ 0x50100C0F;
										continue;
										end_IL_023a:
										break;
									}
									break;
								}
							}
							goto end_IL_0042;
						}
						}
						goto IL_003d;
						continue;
						end_IL_0042:
						break;
					}
					break;
				}
				goto IL_0756;
				end_IL_002e:;
			}
			finally
			{
				obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2443083282u);
				while (true)
				{
					IL_0551:
					int num17 = -1428333213;
					while (true)
					{
						num2 = num17;
						switch ((num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564)) % 5)
						{
						case 0u:
							break;
						default:
							goto end_IL_0556;
						case 1u:
						{
							int num18;
							int num19;
							if (binaryReader == null)
							{
								num18 = -1072638386;
								num19 = num18;
							}
							else
							{
								num18 = -1787684395;
								num19 = num18;
							}
							num17 = num18 ^ ((int)num3 * -1003178611);
							continue;
						}
						case 2u:
							_202E_200E_206C_202C_200D_206A_202E_202D_200B_202B_206E_200F_202A_206D_206D_202D_202D_202A_200C_200B_200C_202B_200C_200F_202C_200E_202B_206D_206C_202E_202A_200B_202B_206A_202B_206E_206F_200E_200C_206D_202E((object)binaryReader);
							num17 = (int)((num3 * 1410996407) ^ 0x393DF2B0);
							continue;
						case 3u:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3263586121u);
							num17 = 1143053081;
							continue;
						case 4u:
							goto end_IL_0556;
						}
						goto IL_0551;
						continue;
						end_IL_0556:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(4124583574u);
			while (true)
			{
				IL_05ef:
				int num20 = 1291223796;
				while (true)
				{
					num2 = num20;
					switch ((num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564)) % 8)
					{
					case 0u:
						break;
					default:
						goto end_IL_05f4;
					case 1u:
					{
						int num21;
						int num22;
						if (memoryStream == null)
						{
							num21 = -454208671;
							num22 = num21;
						}
						else
						{
							num21 = -2085116178;
							num22 = num21;
						}
						num20 = num21 ^ ((int)num3 * -1343600074);
						continue;
					}
					case 4u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2768620804u);
						num20 = -226374082;
						continue;
					case 5u:
						_202E_200E_206C_202C_200D_206A_202E_202D_200B_202B_206E_200F_202A_206D_206D_202D_202D_202A_200C_200B_200C_202B_200C_200F_202C_200E_202B_206D_206C_202E_202A_200B_202B_206A_202B_206E_206F_200E_200C_206D_202E((object)memoryStream);
						num20 = ((int)num3 * -1763809501) ^ -959794728;
						continue;
					case 2u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 3817110148u);
						num20 = (int)((num3 * 523400579) ^ 0x6CE850E4);
						continue;
					case 6u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2647708164u);
						num20 = (int)((num3 * 1807163282) ^ 0x42663129);
						continue;
					case 3u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2935844293u);
						num20 = ((int)num3 * -1968532127) ^ -368376222;
						continue;
					case 7u:
						goto end_IL_05f4;
					}
					goto IL_05ef;
					continue;
					end_IL_05f4:
					break;
				}
				break;
			}
		}
		obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 617856635u);
		goto IL_0703;
		IL_0703:
		int num23 = -16051540;
		goto IL_0708;
		IL_0756:
		obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 598344142u);
		num23 = 1955422842;
		goto IL_0708;
		IL_0708:
		num2 = num23;
		switch ((num3 = (uint)(-(~(-(-(num2 * -120211399)))) ^ -144838564)) % 4)
		{
		case 0u:
			break;
		case 1u:
			return result2;
		case 2u:
			goto IL_0756;
		default:
			return result;
		}
		goto IL_0703;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static _sg _vh(byte[] P_0, string P_1 = null)
	{
		//The blocks IL_000c, IL_0011, IL_008c are reachable both inside and outside the pinned region starting at IL_007c. ILSpy has duplicated these blocks in order to place them both within and outside the `fixed` statement.
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(4058505282u);
		ref byte reference = default(ref byte);
		while (true)
		{
			int num2;
			int num = (num2 = 1066512000);
			uint num4;
			uint num3 = (num4 = (uint)((0x29B83A95 ^ 0x7EEDC22C) + -(--1196986711 ^ 0x5522040A) + -760682607 - -num2 * 1810200255));
			switch (num3 % 3)
			{
			case 2u:
				break;
			case 1u:
				while (true)
				{
					fixed (byte* ptr = &P_0[global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x5A31BEBE ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 739884896u)))])
					{
						num = ((int)num4 * -898518934) ^ 0x7B5C6E65;
						while (true)
						{
							num2 = num;
							num3 = (num4 = (uint)((0x29B83A95 ^ 0x7EEDC22C) + -(--1196986711 ^ 0x5522040A) + -760682607 - -num2 * 1810200255));
							switch (num3 % 3)
							{
							case 1u:
								break;
							case 2u:
								goto IL_000c_2;
							default:
								return _Im<Dictionary<IntPtr, LibraryInfo>, bool, IntPtr, byte, long, string, HashSet<IntPtr>>(ptr, P_0.Length, P_1);
							}
							break;
							IL_000c_2:
							num = 1066512000;
						}
					}
				}
			default:
				return _Im<Dictionary<IntPtr, LibraryInfo>, bool, IntPtr, byte, long, string, HashSet<IntPtr>>((byte*)Unsafe.AsPointer(ref reference), P_0.Length, P_1);
			}
		}
	}

	public unsafe static _sg _p(Stream P_0, string P_1 = null)
	{
		MemoryStream memoryStream = P_0 as MemoryStream;
		UnmanagedMemoryStream unmanagedMemoryStream = default(UnmanagedMemoryStream);
		_sg result = default(_sg);
		while (true)
		{
			int num = -387426660;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~(((~(num2 - (~(-(--2395018)) ^ -(-(-1460170397 ^ -(~(--999672780))))) - (-(~(-1397405360 ^ 0x66ABBA86)) ^ --1739782170)) - ((--167209577 ^ -1088294161) - 554143121 * (97376642 - 897461014) + 710338898)) ^ -1618159980) * 379071931)))) % 5)
				{
				case 0u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (memoryStream != null)
					{
						num5 = -70877052;
						num6 = num5;
					}
					else
					{
						num5 = -455733053;
						num6 = num5;
					}
					num = num5 ^ (int)(num3 * 1381314267);
					continue;
				}
				case 1u:
					unmanagedMemoryStream = P_0 as UnmanagedMemoryStream;
					num = -1290039516;
					continue;
				case 4u:
					return (_sg)_206E_206B_202D_206F_200D_200E_206F_200E_206A_206F_206B_200E_200B_206F_206D_206F_206A_202C_200C_206A_206C_200E_200F_200B_200E_206B_206B_206E_200E_200F_200B_202E_202C_200F_206C_206B_206E_202E_200F_200F_202E(_206C_200E_202B_202A_200F_202B_206E_200F_206D_206F_206D_206D_202E_206D_202C_206B_206A_200C_206E_202E_202C_202E_206F_200C_206C_206A_206C_202C_200D_200F_202A_206D_206A_206D_200E_206D_202E_200E_200B_200F_202E((object)memoryStream), P_1);
				default:
				{
					if (unmanagedMemoryStream != null)
					{
						try
						{
							result = _Im<Dictionary<IntPtr, LibraryInfo>, bool, IntPtr, byte, long, string, HashSet<IntPtr>>(_206F_202D_200B_200C_206D_206E_200E_206F_200F_206E_206D_202A_206D_200F_200F_200E_202C_200E_200D_206B_200C_200B_202B_200B_200B_202D_206B_200F_200C_202D_200C_202A_206D_206B_200C_206E_206C_206D_206F_200D_202E((object)unmanagedMemoryStream), _202D_202E_206E_202B_202D_200F_200C_206E_206A_206A_206D_202B_206A_206A_202B_202E_206C_206A_202D_200F_202D_206C_200B_206C_202D_202E_200C_206F_206C_200E_206D_202A_200F_206F_200F_206A_200F_200B_202B_200C_202E((object)unmanagedMemoryStream) - _202A_200C_200B_202D_200C_206E_206D_202A_200B_200E_206D_206D_202E_200F_202A_200D_200F_202E_200D_202B_202C_206B_202E_206B_200C_206D_206D_202A_202E_200E_200F_200F_206C_200E_206C_200D_206D_202A_206B_202E_202E((object)unmanagedMemoryStream), P_1);
							return result;
						}
						catch (NotSupportedException)
						{
						}
					}
					MemoryStream memoryStream2 = (MemoryStream)_206B_202E_202E_206F_202C_200B_200F_202D_200D_202E_200F_200F_206D_202A_206E_206F_200C_206E_200D_202A_206E_206E_206A_200F_202D_206B_206B_206C_206E_202B_202B_200B_200B_200C_202E_206B_206E_206B_202D_200E_202E();
					while (true)
					{
						int num4 = 1500079180;
						while (true)
						{
							num2 = num4;
							switch ((num3 = (uint)(~(~(((~(num2 - (~(-(--2395018)) ^ -(-(-1460170397 ^ -(~(--999672780))))) - (-(~(-1397405360 ^ 0x66ABBA86)) ^ --1739782170)) - ((--167209577 ^ -1088294161) - 554143121 * (97376642 - 897461014) + 710338898)) ^ -1618159980) * 379071931)))) % 4)
							{
							case 2u:
								break;
							case 1u:
								goto IL_01d5;
							case 3u:
							{
								byte[] array = _206C_200E_202B_202A_200F_202B_206E_200F_206D_206F_206D_206D_202E_206D_202C_206B_206A_200C_206E_202E_202C_202E_206F_200C_206C_206A_206C_202C_200D_200F_202A_206D_206A_206D_200E_206D_202E_200E_200B_200F_202E((object)memoryStream2);
								_206B_200F_200F_206F_202D_200F_200F_202A_206B_200D_206F_200F_202E_200D_206F_206A_206D_202D_200E_202D_206A_200C_200E_200C_202B_202E_200D_200D_202D_206A_206A_200D_206C_202C_200D_206A_202A_206F_200F_200C_202E((object)memoryStream2);
								return (_sg)_206E_206B_202D_206F_200D_200E_206F_200E_206A_206F_206B_200E_200B_206F_206D_206F_206A_202C_200C_206A_206C_200E_200F_200B_200E_206B_206B_206E_200E_200F_200B_202E_202C_200F_206C_206B_206E_202E_200F_200F_202E(array, P_1);
							}
							default:
								return result;
							}
							break;
							IL_01d5:
							_202A_202E_202E_206C_200E_200E_206C_200E_200F_206D_206F_200C_202C_202D_206F_202C_206D_200C_202D_202D_202D_200F_202B_200F_206C_206A_206D_206E_206C_200E_202B_206B_200B_200B_200F_206A_206A_200F_206E_202B_202E((object)P_0, (object)memoryStream2);
							num4 = (int)(num3 * 1437703546) ^ -1262397660;
						}
					}
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static _sg _Im<T0, T1, T2, T3, T4, T5, T6>(T3* P_0, T4 P_1, T5 P_2 = default(T5))
	{
		//IL_0113: Expected O, but got I4
		//IL_0391: Expected I, but got O
		//IL_0376: Expected I, but got O
		//IL_0262: Expected I, but got O
		//IL_02f2: Expected I8, but got O
		//IL_02f3: Expected O, but got I
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2499872740u);
		T2 val2 = default(T2);
		_sg sg = default(_sg);
		T0 val3 = default(T0);
		_sg result = default(_sg);
		while (true)
		{
			int num = 890079639;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-(num2 + -227237341 * ((--1960871268 - (-1428709786 ^ --108475195 ^ (--1089729984 - (-2004610350 ^ -523759915))) + ~(-(-880639616 - 544819023 + 758927202))) ^ -(-1591522362 + -887204146 + (340128359 - 1004676427) - (1966604177 * -1663128665 - -70541076) + -519991432))) ^ (~(-(~(0x58D118A8 ^ -2021430702))) + (((~252645319 - -516269411) ^ 0x156FC868) + ~(~(~-1198345248))))) * -1601125043)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_00e1;
				default:
				{
					T1 val = (T1)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1318756264 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3520862917u));
					try
					{
						obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1109578800u);
						while (true)
						{
							IL_011f:
							int num4 = -1895717152;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)((-(num2 + -227237341 * ((--1960871268 - (-1428709786 ^ --108475195 ^ (--1089729984 - (-2004610350 ^ -523759915))) + ~(-(-880639616 - 544819023 + 758927202))) ^ -(-1591522362 + -887204146 + (340128359 - 1004676427) - (1966604177 * -1663128665 - -70541076) + -519991432))) ^ (~(-(~(0x58D118A8 ^ -2021430702))) + (((~252645319 - -516269411) ^ 0x156FC868) + ~(~(~-1198345248))))) * -1601125043)) % 16)
								{
								case 12u:
									break;
								default:
									goto end_IL_0124;
								case 7u:
								{
									int num7;
									int num8;
									if (!_202A_202C_206C_206A_206A_202C_206D_206A_200C_202C_202E_206B_200F_200D_202D_200C_206C_202E_206D_206C_202C_200C_200B_202E_206A_200B_206B_202C_206F_202B_200B_200E_202D_202C_206A_206E_206A_202A_202B_200E_202E((string)P_2))
									{
										num7 = 1820336284;
										num8 = num7;
									}
									else
									{
										num7 = 706751870;
										num8 = num7;
									}
									num4 = num7 ^ (int)(num3 * 137449987);
									continue;
								}
								case 9u:
									_if.Add((IntPtr)val2, (LibraryInfo)_200D_200E_200E_206D_202A_200F_202D_200E_206D_200B_206B_206C_202A_202E_202C_202B_206C_206B_206E_202A_200C_202D_202D_200F_200E_202A_206A_202B_202B_202B_202B_200E_200D_206A_202B_206A_206A_202D_206F_202E_202E((string)P_2));
									num4 = (int)(num3 * 1894799791) ^ -1713381681;
									continue;
								case 6u:
									_9B.Add((string)P_2, (HashSet<IntPtr>)Activator.CreateInstance(typeof(T6)));
									num4 = (int)(num3 * 73813213) ^ -1124210268;
									continue;
								case 14u:
									sg = new _sg();
									num4 = ((int)num3 * -650628466) ^ 0x7AEE3658;
									continue;
								case 1u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3416158844u);
									num4 = 2131387614;
									continue;
								case 11u:
									val2 = (T2)(nint)_9h._uJ((byte*)P_0, (long)P_1, null, null, sg._JL, _KA, _hd);
									num4 = ((int)num3 * -1242376144) ^ 0x5DD76D22;
									continue;
								case 15u:
									_202B_200F_200F_200F_200F_200D_206E_202C_200F_202B_202C_200C_202E_206C_206F_206D_202E_200E_200B_206B_200F_206D_202A_200E_200D_200E_206D_206B_206F_200F_202B_200F_206F_200E_202C_206E_206C_206A_206A_206F_202E((object)val3, ref *(bool*)(&val));
									num4 = (int)((num3 * 7713553) ^ 0x11216672);
									continue;
								case 13u:
									sg._Mm = (string)P_2;
									num4 = (int)((num3 * 681347313) ^ 0x6FBE4D0A);
									continue;
								case 8u:
								{
									int num5;
									int num6;
									if (_9B.ContainsKey((string)P_2))
									{
										num5 = -1750721030;
										num6 = num5;
									}
									else
									{
										num5 = 2015371349;
										num6 = num5;
									}
									num4 = num5 ^ ((int)num3 * -1645813776);
									continue;
								}
								case 5u:
									_9B[(string)P_2].Add((IntPtr)val2);
									num4 = (int)((num3 * 495394779) ^ 0x6F3872DC);
									continue;
								case 0u:
									sg._Wh = (IntPtr)val2;
									num4 = (int)(num3 * 181062830) ^ -1818971820;
									continue;
								case 3u:
									result = sg;
									num4 = (int)(num3 * 1912138838) ^ -1937345997;
									continue;
								case 4u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2396995981u);
									num4 = 1926017270;
									continue;
								case 10u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 878808452u);
									num4 = ((int)num3 * -1576697037) ^ -1805559231;
									continue;
								case 2u:
									goto end_IL_0124;
								}
								goto IL_011f;
								continue;
								end_IL_0124:
								break;
							}
							break;
						}
					}
					finally
					{
						obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(342541818u);
						while (true)
						{
							IL_0405:
							int num9 = 2109409157;
							while (true)
							{
								num2 = num9;
								switch ((num3 = (uint)((-(num2 + -227237341 * ((--1960871268 - (-1428709786 ^ --108475195 ^ (--1089729984 - (-2004610350 ^ -523759915))) + ~(-(-880639616 - 544819023 + 758927202))) ^ -(-1591522362 + -887204146 + (340128359 - 1004676427) - (1966604177 * -1663128665 - -70541076) + -519991432))) ^ (~(-(~(0x58D118A8 ^ -2021430702))) + (((~252645319 - -516269411) ^ 0x156FC868) + ~(~(~-1198345248))))) * -1601125043)) % 8)
								{
								case 0u:
									break;
								default:
									goto end_IL_040a;
								case 6u:
								{
									int num10;
									int num11;
									if (val != null)
									{
										num10 = -535979313;
										num11 = num10;
									}
									else
									{
										num10 = 221551380;
										num11 = num10;
									}
									num9 = num10 ^ (int)(num3 * 786135218);
									continue;
								}
								case 1u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 969724423u);
									num9 = (int)((num3 * 1969941762) ^ 0x446D6BCB);
									continue;
								case 4u:
									_200E_206A_206A_206E_202E_206F_206B_202A_206D_206C_200E_206C_200E_202E_202C_200B_206B_206F_200D_202E_202C_200F_200D_200F_206F_202B_200B_202D_202B_202C_206A_202E_206A_200B_200E_200B_206F_206A_200B_200F_202E((object)val3);
									num9 = ((int)num3 * -1744274525) ^ 0x2813133C;
									continue;
								case 7u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3772864778u);
									num9 = -968200956;
									continue;
								case 2u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 2578136778u);
									num9 = ((int)num3 * -1047964306) ^ -188330254;
									continue;
								case 3u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2709632950u);
									num9 = ((int)num3 * -1677142137) ^ 0x63605407;
									continue;
								case 5u:
									goto end_IL_040a;
								}
								goto IL_0405;
								continue;
								end_IL_040a:
								break;
							}
							break;
						}
					}
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2487671948u);
					return result;
				}
				}
				break;
				IL_00e1:
				val3 = (T0)_if;
				num = ((int)num3 * -534360312) ^ -1663103232;
			}
		}
	}

	public void _fm<T0>()
	{
		//IL_00d3: Expected I, but got O
		//IL_00d4: Expected O, but got I
		T0 val = default(T0);
		while (true)
		{
			int num = 1404076140;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((0x25FB3ADA ^ -755621999) - -(~(num2 + 1575682331 * (~(-(~-468349840) + 2073133727 - ~-2026599352 * -469797465 * 487648873) - (((-(-1987171151 ^ -1771000970) + 238990833) ^ -(1986405711 * (-1133435239 - -1778397489))) - -2053091871 * (-(0x541F1A8 ^ 0x5BC6B703) - -(750939133 - 1335491089))))))) * -31509059 * -1129714013 + 134598619 - -1152119022)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
					val = (T0)(nint)_206E_206E_206A_202E_202E_200E_200B_206F_200B_200B_202E_206B_202B_206D_200B_200D_200E_200E_206D_206B_200F_206E_202E_200E_202A_202E_202D_200F_206A_202D_206B_206F_206F_202A_202E_206B_202A_200C_200F_200D_202E(ref _Wh, (IntPtr)val);
					num = ((int)num3 * -1283716997) ^ -2100936867;
					continue;
				case 1u:
					_Bo<Dictionary<IntPtr, LibraryInfo>, bool, T0>(val);
					num = (int)(num3 * 1255450093) ^ -681175685;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public T0 _5<T0, T1>(T1 P_0)
	{
		return Marshal.GetDelegateForFunctionPointer<T0>(_9h._di(_Wh, (string)P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe static T1 _Bo<T0, T1, T2>(T2 P_0)
	{
		//IL_0085: Expected O, but got I4
		//IL_0409: Expected O, but got I4
		//IL_0307: Expected I, but got O
		//IL_0356: Expected I, but got O
		//IL_0286: Expected O, but got I4
		//IL_0197: Expected I, but got O
		//IL_01ff: Expected I, but got O
		//IL_016c: Expected I, but got O
		//IL_02f2: Expected O, but got I4
		//IL_029b: Expected I, but got O
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2256874193u);
		T0 val2 = default(T0);
		LibraryInfo libraryInfo = default(LibraryInfo);
		T1 result = default(T1);
		while (true)
		{
			int num = -1171512897;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~(-(num2 - (-1109856048 + ~(~(~(0x238D0FE7 ^ -(~-328740950)))))) ^ 0xCD355B1)))) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0055;
				default:
				{
					T1 val = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-661156692 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1710447186u));
					try
					{
						obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2539053504u);
						_202B_200F_200F_200F_200F_200D_206E_202C_200F_202B_202C_200C_202E_206C_206F_206D_202E_200E_200B_206B_200F_206D_202A_200E_200D_200E_206D_206B_206F_200F_202B_200F_206F_200E_202C_206E_206C_206A_206A_206F_202E((object)val2, ref *(bool*)(&val));
						try
						{
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1496023676u);
							while (true)
							{
								IL_00a7:
								int num4 = -893015971;
								while (true)
								{
									num2 = num4;
									switch ((num3 = (uint)(-(~(-(num2 - (-1109856048 + ~(~(~(0x238D0FE7 ^ -(~-328740950)))))) ^ 0xCD355B1)))) % 15)
									{
									case 7u:
										break;
									default:
										goto end_IL_00ac;
									case 10u:
										goto end_IL_00ac;
									case 1u:
									{
										int num13;
										int num14;
										if (libraryInfo.Name != null)
										{
											num13 = -338545424;
											num14 = num13;
										}
										else
										{
											num13 = -474951004;
											num14 = num13;
										}
										num4 = num13 ^ ((int)num3 * -1302293696);
										continue;
									}
									case 12u:
										libraryInfo = _if[(IntPtr)P_0];
										num4 = (int)((num3 * 1312348904) ^ 0x1730573D);
										continue;
									case 9u:
									{
										HashSet<IntPtr> hashSet = _9B[libraryInfo.Name];
										hashSet.Remove((IntPtr)P_0);
										int num11;
										int num12;
										if (hashSet.Count == 0)
										{
											num11 = -117490826;
											num12 = num11;
										}
										else
										{
											num11 = -543204540;
											num12 = num11;
										}
										num4 = num11 ^ ((int)num3 * -444549472);
										continue;
									}
									case 6u:
										libraryInfo.RefCount -= (uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1130949735 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 499365296u));
										num4 = ((int)num3 * -1004067686) ^ -1551559340;
										continue;
									case 11u:
									{
										int num7;
										int num8;
										if (!((IntPtr)P_0 != IntPtr.Zero))
										{
											num7 = 1415610519;
											num8 = num7;
										}
										else
										{
											num7 = 1653415881;
											num8 = num7;
										}
										num4 = num7 ^ (int)(num3 * 410731409);
										continue;
									}
									case 8u:
										_9B.Remove(libraryInfo.Name);
										num4 = ((int)num3 * -1531727664) ^ -1088768204;
										continue;
									case 5u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 181096648u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 4159046708u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1526098428u);
										result = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x388B23BB ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 3227444940u)));
										num4 = -939508730;
										continue;
									case 14u:
										_9h._Pc((IntPtr)P_0);
										num4 = ((int)num3 * -1120514649) ^ 0x46B55999;
										continue;
									case 13u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 386459000u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1526098428u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 3227444940u);
										result = (T1)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-587666871 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 4159046708u));
										num4 = -672251021;
										continue;
									case 0u:
									{
										int num9;
										int num10;
										if (_if.ContainsKey((IntPtr)P_0))
										{
											num9 = -721486299;
											num10 = num9;
										}
										else
										{
											num9 = -591673869;
											num10 = num9;
										}
										num4 = num9 ^ ((int)num3 * -1602341089);
										continue;
									}
									case 3u:
									{
										int num5;
										int num6;
										if (libraryInfo.RefCount != 0)
										{
											num5 = -2027803052;
											num6 = num5;
										}
										else
										{
											num5 = -1267476783;
											num6 = num5;
										}
										num4 = num5 ^ ((int)num3 * -1290871792);
										continue;
									}
									case 2u:
										_if.Remove((IntPtr)P_0);
										num4 = ((int)num3 * -1879164701) ^ -983141763;
										continue;
									case 4u:
										goto end_IL_00ac;
									}
									goto IL_00a7;
									continue;
									end_IL_00ac:
									break;
								}
								break;
							}
						}
						catch (Exception)
						{
							obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3664321833u);
							while (true)
							{
								IL_037c:
								int num15 = -1746611615;
								while (true)
								{
									num2 = num15;
									switch ((num3 = (uint)(-(~(-(num2 - (-1109856048 + ~(~(~(0x238D0FE7 ^ -(~-328740950)))))) ^ 0xCD355B1)))) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_0381;
									case 2u:
										goto IL_03c5;
									case 1u:
										goto end_IL_0381;
									}
									goto IL_037c;
									IL_03c5:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3959204277u);
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3158234251u);
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 1617074869u);
									result = (T1)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x207BDA9B ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 297981501u)));
									num15 = ((int)num3 * -123469673) ^ -891892287;
									continue;
									end_IL_0381:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(248058100u);
						while (true)
						{
							IL_042d:
							int num16 = -1157972946;
							while (true)
							{
								num2 = num16;
								switch ((num3 = (uint)(-(~(-(num2 - (-1109856048 + ~(~(~(0x238D0FE7 ^ -(~-328740950)))))) ^ 0xCD355B1)))) % 5)
								{
								case 4u:
									break;
								default:
									goto end_IL_0432;
								case 1u:
								{
									int num17;
									int num18;
									if (val != null)
									{
										num17 = -2018689168;
										num18 = num17;
									}
									else
									{
										num17 = -1591368634;
										num18 = num17;
									}
									num16 = num17 ^ ((int)num3 * -494057359);
									continue;
								}
								case 2u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2924204104u);
									num16 = 2099745993;
									continue;
								case 0u:
									_200E_206A_206A_206E_202E_206F_206B_202A_206D_206C_200E_206C_200E_202E_202C_200B_206B_206F_200D_202E_202C_200F_200D_200F_206F_202B_200B_202D_202B_202C_206A_202E_206A_200B_200E_200B_206F_206A_200B_200F_202E((object)val2);
									num16 = (int)((num3 * 300591390) ^ 0x71E7AAF3);
									continue;
								case 3u:
									goto end_IL_0432;
								}
								goto IL_042d;
								continue;
								end_IL_0432:
								break;
							}
							break;
						}
					}
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 979164786u);
					return result;
				}
				}
				break;
				IL_0055:
				val2 = (T0)_if;
				num = ((int)num3 * -947007585) ^ 0x3811EEAD;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected unsafe static T3 _Yb<T0, T1, T2, T3, T4>(T4 P_0, _sg P_1)
	{
		//IL_014f: Expected O, but got I4
		//IL_0359: Expected O, but got I
		//IL_02b2: Expected I, but got O
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2194867597u);
		T0 val3 = default(T0);
		T3 val2 = default(T3);
		T2 value = default(T2);
		T3 result = default(T3);
		while (true)
		{
			int num = -232830409;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(((num2 - ~((~(-((0x25FD5714 ^ -114238531) + ~249534882)) - -34253416) * 934119897)) ^ (-359272114 ^ ~(~1940878367 + (-624324078 - -797047637) - -(0x3355B41A ^ 0x6888A488)) ^ (--191641439 + (-1471324366 + 1140980353) + (-954222009 * 1806698057 + 2122175489) + -880636166 - (~(-(1663703313 * -2110869324)) + (1990888628 - (-995546078 + (948677046 - -1184194968))))))) - -(-(-717080727 * (1649038235 * (453373021 + -1480473549))))))) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_011d;
				default:
				{
					T1 val = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x537956E2 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2533146901u)));
					try
					{
						obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(778163491u);
						while (true)
						{
							IL_015b:
							int num4 = 829353555;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(-(((num2 - ~((~(-((0x25FD5714 ^ -114238531) + ~249534882)) - -34253416) * 934119897)) ^ (-359272114 ^ ~(~1940878367 + (-624324078 - -797047637) - -(0x3355B41A ^ 0x6888A488)) ^ (--191641439 + (-1471324366 + 1140980353) + (-954222009 * 1806698057 + 2122175489) + -880636166 - (~(-(1663703313 * -2110869324)) + (1990888628 - (-995546078 + (948677046 - -1184194968))))))) - -(-(-717080727 * (1649038235 * (453373021 + -1480473549))))))) % 10)
								{
								case 2u:
									break;
								default:
									goto end_IL_0160;
								case 8u:
									_202B_200F_200F_200F_200F_200D_206E_202C_200F_202B_202C_200C_202E_206C_206F_206D_202E_200E_200B_206B_200F_206D_202A_200E_200D_200E_206D_206B_206F_200F_202B_200F_206F_200E_202C_206E_206C_206A_206A_206F_202E((object)val3, ref *(bool*)(&val));
									num4 = ((int)num3 * -1529784632) ^ 0x588A22FD;
									continue;
								case 6u:
								{
									LibraryInfo libraryInfo = _if[(IntPtr)val2];
									uint refCount = libraryInfo.RefCount;
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3057603146u);
									libraryInfo.RefCount = refCount + (uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x117B5B40 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 0u)));
									num4 = (int)((num3 * 1960487472) ^ 0x5E833601);
									continue;
								}
								case 0u:
								{
									int num5;
									int num6;
									if (_9B.TryGetValue((string)P_0, out *(HashSet<IntPtr>*)(&value)))
									{
										num5 = -1443480540;
										num6 = num5;
									}
									else
									{
										num5 = 1632529218;
										num6 = num5;
									}
									num4 = num5 ^ (int)(num3 * 1763883260);
									continue;
								}
								case 1u:
									goto end_IL_0160;
								case 9u:
									val2 = ((IEnumerable<T3>)value).First();
									num4 = ((int)num3 * -1780012051) ^ -2039440320;
									continue;
								case 5u:
									result = (T3)(nint)IntPtr.Zero;
									num4 = (int)(num3 * 491846675) ^ -15079293;
									continue;
								case 4u:
									result = val2;
									num4 = (int)(num3 * 979253863) ^ -1917099888;
									continue;
								case 7u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3057603146u);
									num4 = -417341922;
									continue;
								case 3u:
									goto end_IL_0160;
								}
								goto IL_015b;
								continue;
								end_IL_0160:
								break;
							}
							break;
						}
					}
					finally
					{
						obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(956466857u);
						while (true)
						{
							IL_03ab:
							int num7 = 986262437;
							while (true)
							{
								num2 = num7;
								switch ((num3 = (uint)(-(((num2 - ~((~(-((0x25FD5714 ^ -114238531) + ~249534882)) - -34253416) * 934119897)) ^ (-359272114 ^ ~(~1940878367 + (-624324078 - -797047637) - -(0x3355B41A ^ 0x6888A488)) ^ (--191641439 + (-1471324366 + 1140980353) + (-954222009 * 1806698057 + 2122175489) + -880636166 - (~(-(1663703313 * -2110869324)) + (1990888628 - (-995546078 + (948677046 - -1184194968))))))) - -(-(-717080727 * (1649038235 * (453373021 + -1480473549))))))) % 8)
								{
								case 0u:
									break;
								default:
									goto end_IL_03b0;
								case 2u:
								{
									int num8;
									int num9;
									if (val == null)
									{
										num8 = -1206572602;
										num9 = num8;
									}
									else
									{
										num8 = -938710694;
										num9 = num8;
									}
									num7 = num8 ^ (int)(num3 * 143370424);
									continue;
								}
								case 5u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3066802426u);
									num7 = ((int)num3 * -1149544735) ^ 0x3CE3A9EE;
									continue;
								case 3u:
									_200E_206A_206A_206E_202E_206F_206B_202A_206D_206C_200E_206C_200E_202E_202C_200B_206B_206F_200D_202E_202C_200F_200D_200F_206F_202B_200B_202D_202B_202C_206A_202E_206A_200B_200E_200B_206F_206A_200B_200F_202E((object)val3);
									num7 = (int)((num3 * 424881946) ^ 0x708DE838);
									continue;
								case 1u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 2127973510u);
									num7 = (int)(num3 * 1682883749) ^ -206520276;
									continue;
								case 4u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1160597504u);
									num7 = (int)(num3 * 1988148464) ^ -201455340;
									continue;
								case 7u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1342583882u);
									num7 = -786953600;
									continue;
								case 6u:
									goto end_IL_03b0;
								}
								goto IL_03ab;
								continue;
								end_IL_03b0:
								break;
							}
							break;
						}
					}
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1330714263u);
					return result;
				}
				}
				break;
				IL_011d:
				val3 = (T0)_if;
				num = (int)((num3 * 413103464) ^ 0x7A230729);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe void* _rn<T0, T1, T2, T3, T4, T5>(T0* P_0, void* P_1)
	{
		//IL_0130: Expected I, but got O
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2513617251u);
		void* ptr = default(void*);
		while (true)
		{
			int num = -162876876;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~(-(((-(462126469 * ((0x55AD8841 ^ 0x16EF083C) - (1175948876 - (416698753 + -68961739)))) + (--1991931144 - (~(~365161705 + 692687005) - ((--114786143 ^ -1053049804) - (0x5587C120 ^ -2050504451) * 812331379)))) * -545397889 - num2) * 487603229)) ^ (-1046338726 + (-2073650344 ^ -1899619191) - -(-1257804986 - -1050106444))) * -1039987891 - -1142505404 - 151747676)) % 7)
				{
				case 4u:
					break;
				case 2u:
					ptr = _9h._bI((char*)P_0, P_1);
					num = (int)(num3 * 1958976926) ^ -242227574;
					continue;
				case 3u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2582609723u);
					num = (int)((num3 * 1369371921) ^ 0x56775131);
					continue;
				case 5u:
					return (void*)(IntPtr)_Yb<T1, T2, T3, T4, T5>((T5)_200D_206C_206C_200C_200C_200D_202D_206A_200B_202C_202C_206A_202E_206E_200F_200C_200C_206F_202B_200D_206E_200D_202B_202A_200B_206F_206D_206B_200D_206A_200F_200D_206A_206B_202E_202A_200E_206B_200D_202D_202E((IntPtr)P_0), this);
				case 1u:
				{
					int num4;
					int num5;
					if (ptr == (void*)(uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x461A747 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2510198563u))))
					{
						num4 = 1692162342;
						num5 = num4;
					}
					else
					{
						num4 = -1032631697;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -764078560);
					continue;
				}
				case 0u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3985924717u);
					num = 1381188188;
					continue;
				default:
					return ptr;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _OF<T0, T1, T2, T3>(void* P_0, T3* P_1, void* P_2)
	{
		//IL_009f: Expected O, but got I4
		//IL_0060: Expected O, but got I
		//IL_012b: Expected I, but got O
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3980201392u);
		T0 val3 = default(T0);
		T1 val2 = default(T1);
		void* result = default(void*);
		while (true)
		{
			int num = 529937052;
			while (true)
			{
				int num2 = num;
				int num10;
				uint num3;
				switch ((num3 = (uint)(~((-(~num2 * -1864846509) * -963102087 * 2020689407 + ~(1362333351 + -1548045173)) * -1954833403))) % 4)
				{
				case 2u:
					break;
				case 1u:
					val3 = (T0)(nint)(IntPtr)P_0;
					num = ((int)num3 * -324044166) ^ 0x2FB45504;
					continue;
				case 3u:
					val2 = (T1)_if;
					num = ((int)num3 * -1240892726) ^ 0x1C583CAB;
					continue;
				default:
					{
						T2 val = (T2)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-290323916 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 497275744u));
						try
						{
							obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3753832025u);
							while (true)
							{
								IL_00ab:
								int num4 = 621841633;
								while (true)
								{
									num2 = num4;
									switch ((num3 = (uint)(~((-(~num2 * -1864846509) * -963102087 * 2020689407 + ~(1362333351 + -1548045173)) * -1954833403))) % 8)
									{
									case 2u:
										break;
									default:
										goto end_IL_00b0;
									case 7u:
									{
										int num5;
										int num6;
										if (_if.ContainsKey((IntPtr)val3))
										{
											num5 = 212493572;
											num6 = num5;
										}
										else
										{
											num5 = -1171182330;
											num6 = num5;
										}
										num4 = num5 ^ ((int)num3 * -65620158);
										continue;
									}
									case 3u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3805683792u);
										num4 = (int)(num3 * 683692567) ^ -586922927;
										continue;
									case 4u:
										_202B_200F_200F_200F_200F_200D_206E_202C_200F_202B_202C_200C_202E_206C_206F_206D_202E_200E_200B_206B_200F_206D_202A_200E_200D_200E_206D_206B_206F_200F_202B_200F_206F_200E_202C_206E_206C_206A_206A_206F_202E((object)val2, ref *(bool*)(&val));
										num4 = ((int)num3 * -1463984927) ^ 0xB02B35A;
										continue;
									case 5u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3805683792u);
										num4 = -1827783025;
										continue;
									case 1u:
										result = _9h._mD(P_0, (char*)P_1);
										num4 = (int)((num3 * 381439698) ^ 0x50C9EE07);
										continue;
									case 6u:
										goto end_IL_00b0;
									case 0u:
										goto IL_035b;
									}
									goto IL_00ab;
									continue;
									end_IL_00b0:
									break;
								}
								break;
							}
						}
						finally
						{
							obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1294357517u);
							while (true)
							{
								IL_01d0:
								int num7 = -1564599216;
								while (true)
								{
									num2 = num7;
									switch ((num3 = (uint)(~((-(~num2 * -1864846509) * -963102087 * 2020689407 + ~(1362333351 + -1548045173)) * -1954833403))) % 8)
									{
									case 6u:
										break;
									default:
										goto end_IL_01d5;
									case 3u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3698358484u);
										num7 = 1978974325;
										continue;
									case 1u:
										_200E_206A_206A_206E_202E_206F_206B_202A_206D_206C_200E_206C_200E_202E_202C_200B_206B_206F_200D_202E_202C_200F_200D_200F_206F_202B_200B_202D_202B_202C_206A_202E_206A_200B_200E_200B_206F_206A_200B_200F_202E((object)val2);
										num7 = (int)(num3 * 273446775) ^ -878233507;
										continue;
									case 7u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 173772724u);
										num7 = (int)((num3 * 47684873) ^ 0x6217DA06);
										continue;
									case 5u:
									{
										int num8;
										int num9;
										if (val != null)
										{
											num8 = -2070850906;
											num9 = num8;
										}
										else
										{
											num8 = 1682067368;
											num9 = num8;
										}
										num7 = num8 ^ (int)(num3 * 1861256562);
										continue;
									}
									case 0u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3784066460u);
										num7 = (int)(num3 * 1603096658) ^ -1957735565;
										continue;
									case 2u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 123745620u);
										num7 = ((int)num3 * -439253448) ^ 0x1D31A246;
										continue;
									case 4u:
										goto end_IL_01d5;
									}
									goto IL_01d0;
									continue;
									end_IL_01d5:
									break;
								}
								break;
							}
						}
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1796966354u);
						goto IL_02f0;
					}
					IL_035b:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3369378927u);
					num10 = -474373216;
					goto IL_02f5;
					IL_02f5:
					num2 = num10;
					switch ((num3 = (uint)(~((-(~num2 * -1864846509) * -963102087 * 2020689407 + ~(1362333351 + -1548045173)) * -1954833403))) % 4)
					{
					case 0u:
						break;
					case 2u:
						return _9h._Ki(P_0, (char*)P_1, P_2);
					case 3u:
						goto IL_035b;
					default:
						return result;
					}
					goto IL_02f0;
					IL_02f0:
					num10 = -26086105;
					goto IL_02f5;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T0 _Vo<T0, T1, T2>(void* P_0, void* P_1)
	{
		//IL_0086: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2242000390u);
		while (true)
		{
			int num = 822716946;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(num2 - ~(-77429211 * -2106551087 + -986076978) - (~(598481453 * -(-833514397)) ^ 0x7D8956C2) * -138143927 + -(-((-1001856524 - -2112936685) * -2304377)) * -1420042937))) % 5)
				{
				case 0u:
					break;
				case 1u:
				{
					int num4;
					int num5;
					if (_Bo<T1, T0, T2>((T2)(nint)(IntPtr)P_0) != null)
					{
						num4 = -173693250;
						num5 = num4;
					}
					else
					{
						num4 = 1621504193;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 969356753);
					continue;
				}
				case 4u:
					return (T0)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0xC5CC08F ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3918155189u)));
				case 3u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 2227442083u);
					num = -36701765;
					continue;
				default:
					return (T0)_9h._IJ(P_0, P_1);
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _pg(bool P_0)
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3442987908u);
		while (true)
		{
			int num = -1197739308;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-1954375646 - ((0x7B67B39F ^ 0x5A8D493D) - -(-(-(0xE20029A ^ -259936226) - (~(646384806 + -(-(-190345017 ^ (525413081 * -1974574221 + --486383220)))) - num2 - (-(-(~(-186978460 + -2006030984)) ^ 0x65D6E78E) - -(-310543660 - -852284899 - ~(620399561 * 1120912797 - (0x7CEB9197 ^ 0x7E039989)))) - -(~(0x1379F0EB ^ -1559832630)) * -1731312291)))))) % 7)
				{
				case 6u:
					break;
				default:
					return;
				case 2u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2957461677u);
					num = -1522706641;
					continue;
				case 4u:
					num = ((int)num3 * -947897236) ^ 0x72A20766;
					continue;
				case 3u:
					_200C_202B_200F_206A_202C_200B_200E_206B_200D_200D_202C_206D_202E_206A_206D_206B_206B_200F_202C_206E_202E_206E_200D_206D_206A_200E_206E_206C_206A_200E_202E_200F_200E_206C_206D_206B_206F_202A_202A_202E_202E((object)this);
					num = (int)((num3 * 31071270) ^ 0x4F3FC1C0);
					continue;
				case 1u:
					_sM = (byte)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x6D32D4CD ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 0u))) != 0;
					num = ((int)num3 * -1174150156) ^ 0x6360ED5E;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (!_sM)
					{
						num4 = 314272493;
						num5 = num4;
					}
					else
					{
						num4 = 184062456;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1588190162);
					continue;
				}
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	protected virtual void _iH()
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj;
		try
		{
			obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(131131554u);
			while (true)
			{
				IL_000c:
				int num = 1442008486;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(((0x600098D8 ^ (0x773BA382 ^ (-1527637496 * 1497263269)) ^ ((((-565967096 ^ -26670130) - --534778139) ^ 0x55B49561) + 658182563)) - -(num2 * 138541791)) * 1129867335) * 1021995689 * 365984715 * -1329587059)) % 3)
					{
					case 2u:
						break;
					default:
						goto end_IL_0011;
					case 1u:
						goto IL_00ac;
					case 0u:
						goto end_IL_0011;
					}
					goto IL_000c;
					IL_00ac:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2205443288u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 2136826792u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 377329240u);
					_pg((byte)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x1811EEF5 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3941185496u))) != 0);
					num = ((int)num3 * -1014549710) ^ 0x14313FB6;
					continue;
					end_IL_0011:
					break;
				}
				break;
			}
		}
		finally
		{
			obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3108436218u);
			while (true)
			{
				IL_0117:
				int num4 = -361087245;
				while (true)
				{
					int num2 = num4;
					uint num3;
					switch ((num3 = (uint)(-(((0x600098D8 ^ (0x773BA382 ^ (-1527637496 * 1497263269)) ^ ((((-565967096 ^ -26670130) - --534778139) ^ 0x55B49561) + 658182563)) - -(num2 * 138541791)) * 1129867335) * 1021995689 * 365984715 * -1329587059)) % 3)
					{
					case 0u:
						break;
					default:
						goto end_IL_011c;
					case 2u:
						goto IL_01b7;
					case 1u:
						goto end_IL_011c;
					}
					goto IL_0117;
					IL_01b7:
					base.Finalize();
					num4 = ((int)num3 * -1419476527) ^ -610032330;
					continue;
					end_IL_011c:
					break;
				}
				break;
			}
		}
		obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2415136148u);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2770840150u);
		while (true)
		{
			int num = 706370395;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-((-1491584819 * ((0xFEDD587 ^ 0x62EE01FE) + ~1650119361) - (((0x3F617662 ^ 0x1FBC0203) - (~(~(--592634079)) + ((0x6FB44A5A ^ -1231255564) + (826977197 + 1027866653) * 1564252071)) - ((num2 * -1796479459) ^ 0x20E4205C)) ^ ((-564655353 * ~-1591584671 - -368713729 * -1937802237) * -1895855067))) ^ -811835653) * 1681136471)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
					_pg((byte)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x9AD9842 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3324938243u))) != 0);
					num = ((int)num3 * -222015507) ^ 0x586EB294;
					continue;
				case 1u:
					_206C_200D_206F_202E_206A_200B_202B_206B_202A_202C_206D_200F_200F_202E_202C_206E_206B_206D_206D_206A_206E_202C_206E_200D_206C_206B_206D_200E_206E_206A_206C_206D_200E_206B_206D_202B_206C_200D_206E_206D_202E((object)this);
					num = (int)((num3 * 344816) ^ 0x590D36D);
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	unsafe static _sg()
	{
		while (true)
		{
			int num = -245894575;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~((0x4633BEAF ^ ~(-(~(--1955896125 - (1154282039 - 419865401))))) - num2 * 1137928729) - -(-(0x4D4BBD14 ^ --933921596))) * 1851920897)) % 5)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					_9B = new Dictionary<string, HashSet<IntPtr>>((IEqualityComparer<string>?)_206B_200B_202C_206F_202C_206D_206E_200E_202A_206C_200D_206E_200F_200F_202C_200D_202E_200E_202C_202B_202B_200B_206E_206E_200C_202A_206A_200B_200C_200E_202A_202B_200E_200E_206E_202C_200E_200E_206A_206F_202E());
					num = (int)(num3 * 2036188825) ^ -1994134762;
					continue;
				case 4u:
					_hd = _Vo<bool, Dictionary<IntPtr, LibraryInfo>, IntPtr>;
					num = ((int)num3 * -699503787) ^ -1167515244;
					continue;
				case 1u:
					_KA = _OF<IntPtr, Dictionary<IntPtr, LibraryInfo>, bool, char>;
					num = ((int)num3 * -890468503) ^ -2100616087;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	static object _206C_206C_206E_206E_200B_206B_200B_206C_206A_206B_202D_202D_206D_200C_200D_206E_202C_206A_206B_206D_206A_202B_206C_200B_200F_206E_206B_202A_200E_202A_206E_206B_206D_202D_206C_200E_202E_202D_200B_206E_202E(byte[] P_0)
	{
		return new MemoryStream(P_0);
	}

	static object _206B_206B_206A_202A_206D_200C_200C_200E_202D_206F_202E_206A_202B_202A_202D_206A_200B_206D_202C_202E_202C_206C_200E_202A_202B_202C_202D_202A_202E_206C_206C_202D_206E_202A_202E_206C_202A_200E_200B_200D_202E(object P_0, CompressionMode P_1)
	{
		return new GZipStream((Stream)P_0, P_1);
	}

	static object _206B_202E_202E_206F_202C_200B_200F_202D_200D_202E_200F_200F_206D_202A_206E_206F_200C_206E_200D_202A_206E_206E_206A_200F_202D_206B_206B_206C_206E_202B_202B_200B_200B_200C_202E_206B_206E_206B_202D_200E_202E()
	{
		return Activator.CreateInstance(typeof(MemoryStream));
	}

	static void _202A_202E_202E_206C_200E_200E_206C_200E_200F_206D_206F_200C_202C_202D_206F_202C_206D_200C_202D_202D_202D_200F_202B_200F_206C_206A_206D_206E_206C_200E_202B_206B_200B_200B_200F_206A_206A_200F_206E_202B_202E(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	static byte[] _206C_200E_202B_202A_200F_202B_206E_200F_206D_206F_206D_206D_202E_206D_202C_206B_206A_200C_206E_202E_202C_202E_206F_200C_206C_206A_206C_202C_200D_200F_202A_206D_206A_206D_200E_206D_202E_200E_200B_200F_202E(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	static void _202E_200E_206C_202C_200D_206A_202E_202D_200B_202B_206E_200F_202A_206D_206D_202D_202D_202A_200C_200B_200C_202B_200C_200F_202C_200E_202B_206D_206C_202E_202A_200B_202B_206A_202B_206E_206F_200E_200C_206D_202E(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static byte[] _206B_202B_202B_206B_206B_206D_206E_202C_202E_206D_206B_200E_202B_202A_206B_200C_206B_200E_206E_202C_200B_206D_200F_202E_200D_202E_206B_206C_200C_206E_202A_206D_206E_202D_200B_206F_206D_200D_200C_200C_202E(byte[] P_0)
	{
		return _v<byte, MemoryStream, GZipStream>(P_0);
	}

	static object _206A_206A_202E_206F_200D_202E_202B_206F_206F_202D_202B_202C_206C_202C_200D_202E_202D_202A_200C_200F_202E_200F_200B_206F_202E_206A_202C_206A_200D_200C_200F_206D_206F_202D_202D_202A_206A_200C_202A_200D_202E(object P_0)
	{
		return new BinaryReader((Stream)P_0);
	}

	static int _200D_200C_206E_206D_202C_206B_202C_200F_202E_206F_200F_206E_202A_200F_202D_200F_206A_202A_206B_206E_206A_200E_202D_200B_202A_200B_202B_200C_206A_200E_200C_206A_202D_202C_206B_206C_206C_206E_202B_206A_202E(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	static byte[] _202A_206E_200C_202D_206C_200C_200B_206B_200B_206C_206A_202E_206A_200F_206B_202D_206F_200C_200C_206D_200E_206F_202C_202A_202D_206E_200D_200F_200F_206E_202E_206B_206B_206A_202E_206A_206A_200D_202E_202E(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	static object _206E_206B_202D_206F_200D_200E_206F_200E_206A_206F_206B_200E_200B_206F_206D_206F_206A_202C_200C_206A_206C_200E_200F_200B_200E_206B_206B_206E_200E_200F_200B_202E_202C_200F_206C_206B_206E_202E_200F_200F_202E(byte[] P_0, string P_1)
	{
		return _vh(P_0, P_1);
	}

	unsafe static byte* _206F_202D_200B_200C_206D_206E_200E_206F_200F_206E_206D_202A_206D_200F_200F_200E_202C_200E_200D_206B_200C_200B_202B_200B_200B_202D_206B_200F_200C_202D_200C_202A_206D_206B_200C_206E_206C_206D_206F_200D_202E(object P_0)
	{
		return ((UnmanagedMemoryStream)P_0).PositionPointer;
	}

	static long _202D_202E_206E_202B_202D_200F_200C_206E_206A_206A_206D_202B_206A_206A_202B_202E_206C_206A_202D_200F_202D_206C_200B_206C_202D_202E_200C_206F_206C_200E_206D_202A_200F_206F_200F_206A_200F_200B_202B_200C_202E(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	static long _202A_200C_200B_202D_200C_206E_206D_202A_200B_200E_206D_206D_202E_200F_202A_200D_200F_202E_200D_202B_202C_206B_202E_206B_200C_206D_206D_202A_202E_200E_200F_200F_206C_200E_206C_200D_206D_202A_206B_202E_202E(object P_0)
	{
		return ((Stream)P_0).Position;
	}

	static void _206B_200F_200F_206F_202D_200F_200F_202A_206B_200D_206F_200F_202E_200D_206F_206A_206D_202D_200E_202D_206A_200C_200E_200C_202B_202E_200D_200D_202D_206A_206A_200D_206C_202C_200D_206A_202A_206F_200F_200C_202E(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	static void _202B_200F_200F_200F_200F_200D_206E_202C_200F_202B_202C_200C_202E_206C_206F_206D_202E_200E_200B_206B_200F_206D_202A_200E_200D_200E_206D_206B_206F_200F_202B_200F_206F_200E_202C_206E_206C_206A_206A_206F_202E(object P_0, ref bool P_1)
	{
		Monitor.Enter(P_0, ref P_1);
	}

	static object _200D_200E_200E_206D_202A_200F_202D_200E_206D_200B_206B_206C_202A_202E_202C_202B_206C_206B_206E_202A_200C_202D_202D_200F_200E_202A_206A_202B_202B_202B_202B_200E_200D_206A_202B_206A_206A_202D_206F_202E_202E(string P_0)
	{
		return new LibraryInfo(P_0);
	}

	static bool _202A_202C_206C_206A_206A_202C_206D_206A_200C_202C_202E_206B_200F_200D_202D_200C_206C_202E_206D_206C_202C_200C_200B_202E_206A_200B_206B_202C_206F_202B_200B_200E_202D_202C_206A_206E_206A_202A_202B_200E_202E(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static void _200E_206A_206A_206E_202E_206F_206B_202A_206D_206C_200E_206C_200E_202E_202C_200B_206B_206F_200D_202E_202C_200F_200D_200F_206F_202B_200B_202D_202B_202C_206A_202E_206A_200B_200E_200B_206F_206A_200B_200F_202E(object P_0)
	{
		Monitor.Exit(P_0);
	}

	static IntPtr _206E_206E_206A_202E_202E_200E_200B_206F_200B_200B_202E_206B_202B_206D_200B_200D_200E_200E_206D_206B_200F_206E_202E_200E_202A_202E_202D_200F_206A_202D_206B_206F_206F_202A_202E_206B_202A_200C_200F_200D_202E(ref IntPtr P_0, IntPtr P_1)
	{
		return Interlocked.Exchange(ref P_0, P_1);
	}

	static string _200D_206C_206C_200C_200C_200D_202D_206A_200B_202C_202C_206A_202E_206E_200F_200C_200C_206F_202B_200D_206E_200D_202B_202A_200B_206F_206D_206B_200D_206A_200F_200D_206A_206B_202E_202A_200E_206B_200D_202D_202E(IntPtr P_0)
	{
		return Marshal.PtrToStringAnsi(P_0);
	}

	static void _200C_202B_200F_206A_202C_200B_200E_206B_200D_200D_202C_206D_202E_206A_206D_206B_206B_200F_202C_206E_202E_206E_200D_206D_206A_200E_206E_206C_206A_200E_202E_200F_200E_206C_206D_206B_206F_202A_202A_202E_202E(object P_0)
	{
		((_sg)P_0)._fm<IntPtr>();
	}

	static void _206C_200D_206F_202E_206A_200B_202B_206B_202A_202C_206D_200F_200F_202E_202C_206E_206B_206D_206D_206A_206E_202C_206E_200D_206C_206B_206D_200E_206E_206A_206C_206D_200E_206B_206D_202B_206C_200D_206E_206D_202E(object P_0)
	{
		GC.SuppressFinalize(P_0);
	}

	static object _206B_200B_202C_206F_202C_206D_206E_200E_202A_206C_200D_206E_200F_200F_202C_200D_202E_200E_202C_202B_202B_200B_206E_206E_200C_202A_206A_200B_200C_200E_202A_202B_200E_200E_206E_202C_200E_200E_206A_206F_202E()
	{
		return StringComparer.InvariantCultureIgnoreCase;
	}
}
internal static class _Sg
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _VE
	{
		public static readonly _VE _003C_003E9 = (_VE)_202D_200F_200C_206D_202E_206A_206E_200C_206D_206D_206D_206B_200D_206F_202B_200E_206F_206F_200E_200F_200C_206C_206C_206E_206D_202C_200F_202D_202C_206F_206E_206A_202B_206C_200D_206C_200C_206D_206B_202E();

		internal _BB _pn()
		{
			return (_BB)_200E_202D_200F_202E_206F_206A_200F_206D_206A_202D_200F_206E_206D_200B_200C_206A_202E_200F_206F_202B_202B_206D_202B_202E_206B_202C_200C_200C_202B_206E_206D_202B_200F_206E_206E_202B_200E_200C_200B_202A_202E();
		}

		internal _BB _OH()
		{
			return (_BB)_200B_206C_202E_206B_202E_202D_202D_200E_206F_202D_206C_206D_202C_206C_200B_202E_202D_200C_200C_200F_202D_200E_202A_200F_202A_206A_206F_206E_200B_202A_206E_206E_200F_200F_200D_202A_206C_206A_206B_202D_202E();
		}

		internal _BB _rb()
		{
			return (_BB)_206D_202C_206C_200C_202A_206B_200E_206D_206F_202E_206A_200D_206D_206C_206D_206C_200E_206E_200F_206E_200F_202E_202D_206D_200B_202B_206D_200E_200C_202E_206D_202A_206E_206D_200C_206B_200E_206A_206B_202B_202E();
		}

		internal _BB _ul()
		{
			return (_BB)_200F_206C_200F_200B_206C_200B_202D_206E_206B_200E_206F_200C_206B_206D_206B_202E_206E_200B_202B_202C_200E_200F_202B_200D_200B_202C_202E_200F_202C_202C_200D_206E_200C_200D_202C_206F_206F_206D_200C_200F_202E();
		}

		internal _BB _6g()
		{
			return (_BB)_200F_202C_202E_206A_206F_206D_206A_206A_202A_200E_200B_200C_200C_202A_206F_206D_202E_202D_206B_200C_200B_206A_202C_206B_206E_206C_202D_206D_206F_202C_206B_202E_200F_202B_200E_206C_200F_206B_202E_202C_202E();
		}

		internal _BB _7o()
		{
			return (_BB)_200C_202A_206F_200F_206C_202E_206A_206D_206C_206B_202D_200E_206C_206B_200B_200D_206F_206E_202B_202C_202B_206D_202E_202E_200B_202A_200F_206A_206D_202A_202D_200E_200C_206C_202A_206E_202D_202D_202B_206B_202E();
		}

		internal _BB _QJ()
		{
			return (_BB)_202A_202E_200E_206C_202A_206B_206B_200D_206D_202E_202C_202D_202C_202E_200B_206D_200F_200F_206F_202A_200F_206B_206D_202A_206B_200D_202D_202A_206C_202C_200E_206C_202E_200F_200B_200B_202C_200C_202A_206C_202E();
		}

		internal _BB _5b()
		{
			return (_BB)_200E_202A_200B_200B_200B_206D_200B_200E_202E_202D_206B_206D_206C_206D_200F_200D_200E_202B_202E_202D_206D_206E_202B_200E_206F_200C_206B_202E_206B_200E_202A_200C_206E_200C_202C_202B_206F_206F_200B_206D_202E();
		}

		internal _BB _LI()
		{
			return (_BB)_200D_202B_206B_206E_206A_200F_206D_200B_202D_206A_206D_206A_200F_200F_206E_202B_200D_206C_202A_200B_200F_202D_206D_202D_202C_202B_202B_206D_202B_206C_200B_200D_200D_206F_206A_206C_202A_206A_200F_200C_202E();
		}

		internal _BB _EJ()
		{
			return (_BB)_202A_206B_206F_200F_206E_202A_200C_206F_200C_200D_206B_206A_206A_202A_200D_200F_202C_202B_206A_202C_200F_206D_206D_202B_200F_206F_202A_200D_202D_200F_202E_202C_202C_202C_200D_206D_200B_202B_202D_206E_202E();
		}

		internal _BB _fj()
		{
			return (_BB)_202A_200E_200C_202A_206E_200C_200C_206F_202E_206D_206E_202C_202A_200F_202B_202C_200D_206B_202D_200B_202E_202D_202D_202E_206F_200E_206E_206C_206B_202B_200F_202C_200F_200B_206B_206A_206A_200C_202B_206C_202E();
		}

		internal _BB _5n()
		{
			return (_BB)_206F_200C_206A_206F_206B_202B_206A_202C_200D_202D_202D_202C_200C_200E_200E_200C_200E_202A_200E_202A_202D_200D_200F_200D_206D_200F_206A_206E_206D_200E_200B_202C_206A_206D_202A_200F_200C_202B_206A_200D_202E();
		}

		internal _BB _DF()
		{
			return (_BB)_200B_200F_206A_200F_200C_200F_206F_202E_200F_200E_206A_206A_206F_202E_206A_202C_206B_206B_202B_200D_200E_200F_202E_202C_202D_202A_206C_206B_200B_202A_206A_200F_200D_200F_202E_202E_206A_206E_200F_206D_202E();
		}

		internal _BB _EH()
		{
			return (_BB)_202B_202D_202B_206C_200D_206A_206F_200F_200E_206B_206A_202D_202A_202B_200F_202E_202C_200E_200D_206A_202D_200D_200D_202D_202D_202B_202C_206F_206C_202C_206D_206D_206C_202E_202B_206D_202D_206D_202C_200C_202E();
		}

		internal _BB _tj()
		{
			return (_BB)_206A_206F_206E_202E_206E_206C_200F_206E_200D_200C_206F_202D_202A_200D_206C_202C_202D_206F_202A_200B_206F_202D_202E_202D_200D_200E_200F_206F_202B_206D_200C_200E_200B_206A_200D_200E_200E_206D_206F_202A_202E();
		}

		internal _BB _Ld()
		{
			return (_BB)_200B_200E_206B_200E_200E_202A_206B_200C_202D_202D_206C_202B_200C_206E_200B_200F_200C_202C_200B_200F_200C_206F_202A_200E_202A_202A_206D_202C_206C_200B_202B_202C_202C_202D_200F_200E_202D_206F_206D_206D_202E();
		}

		internal _BB _Qk()
		{
			return (_BB)_206A_200C_202B_206A_200D_206A_202C_202A_206C_202C_200E_206E_200B_202B_202C_200F_202B_202A_200E_200F_200C_200F_202E_200D_206D_202E_202C_206B_202B_200D_200B_202D_206D_202D_202A_200B_206B_206F_202E_206E_202E();
		}

		internal _BB _qF()
		{
			return (_BB)_202E_202C_200E_206A_206D_206C_206E_200B_202C_202C_200D_206B_206C_202A_206E_206E_200D_200F_202E_206B_202A_202A_202A_200D_202D_202E_202A_202E_200C_206D_202B_200E_200B_202A_200B_202D_202A_206F_202B_202A_202E();
		}

		internal _BB _7k()
		{
			return (_BB)_202E_206D_200B_200D_202E_206B_200C_206B_202E_202A_206F_200E_200F_206F_200F_206A_206A_200F_206A_206B_206C_202A_206F_200F_206E_202B_206A_206D_202E_200F_202D_200B_206C_200B_206A_200C_200F_206A_202B_206D_202E();
		}

		internal _BB _yi()
		{
			return (_BB)_200F_206C_200E_206C_206E_206E_206B_206E_200E_206B_200E_206A_200C_206C_202C_206B_206A_206F_202B_206B_202D_200B_200C_202E_200B_202D_200F_206E_202D_206B_206D_200E_200B_200D_202C_206E_200F_206C_200B_202A_202E();
		}

		internal _BB _Qg()
		{
			return (_BB)_206A_206C_200E_206B_206B_206C_206F_202D_200B_202A_206D_202E_206D_206C_200D_200C_206B_206F_202B_206D_206E_202E_200E_202D_202E_206F_202E_202B_200D_200D_206F_206A_202E_206D_202B_206A_202A_202E_206B_200D_202E();
		}

		internal _BB _Uj()
		{
			return (_BB)_206E_200C_200D_200C_206C_206F_200E_206C_202B_206F_206B_206A_206A_206F_206B_206E_206C_202D_202E_202B_200D_202C_206E_206C_200C_200F_200E_202B_202D_206E_202E_206C_202A_200E_206C_206F_206F_202E_202B_200C_202E();
		}

		internal _BB _im()
		{
			return (_BB)_200C_206C_202B_200F_202A_202A_206E_202B_206E_202C_200B_206D_206B_206F_206F_202C_206D_206B_200B_202B_206D_202C_202A_200B_206D_206C_200C_200B_202A_206E_202E_202A_202A_200F_202E_200B_200D_202C_200B_202C_202E();
		}

		internal _BB _Si()
		{
			return (_BB)_202B_202D_206C_206F_200E_202C_200E_206A_200F_206B_206A_202C_202A_202B_200F_200D_200D_202E_206F_206D_206D_206C_200F_202D_206D_202B_202E_202D_206E_206E_206D_206C_206E_206F_206C_200F_206A_206B_200D_206B_202E();
		}

		internal _BB _JH()
		{
			return (_BB)_206E_206D_206B_202B_206C_206A_202B_206E_202C_206A_200B_206C_202B_200D_202C_202D_206B_206A_200F_200D_202A_200C_206C_200E_200E_206D_202D_200F_200C_202A_200B_206B_200F_202E_202D_202B_206D_206D_206E_202C_202E();
		}

		internal _BB _xl()
		{
			return (_BB)_202E_200E_206A_200C_200E_206E_206B_200B_206E_202C_200C_206B_206A_202A_206C_206D_200C_206A_206F_206A_202D_200E_202B_206A_202D_206B_202C_200F_200F_206C_200B_206C_206D_202A_200F_206B_206F_206C_206B_202D_202E();
		}

		internal _BB _6L()
		{
			return (_BB)_206A_200C_202D_206F_200D_200D_206B_206A_200D_202B_200C_200B_202B_202B_202D_206D_206C_200E_200F_200E_202B_200D_202B_200E_206A_200C_202C_202B_202A_202A_200E_206C_206C_200B_206E_202B_200F_200E_206D_206C_202E();
		}

		internal _BB _zl()
		{
			return (_BB)_202D_202C_206E_206C_200B_206C_200C_202A_202D_202C_206D_202D_200D_200E_200D_206F_206B_206D_200D_200D_206C_200F_202E_206E_206A_206E_206C_206A_200C_200B_200C_206C_202C_200E_200C_202A_200B_202D_200D_200E_202E();
		}

		internal _BB _Lc()
		{
			return (_BB)_206C_202C_206A_202B_206B_202B_200E_206C_206E_202C_206B_202C_206E_206A_200D_202C_206F_202B_206B_202E_206A_206E_200C_200F_206E_200E_200F_206D_200C_202E_200F_200F_206E_206C_202B_200B_202C_206A_202C_200F_202E();
		}

		internal _BB _aC()
		{
			return (_BB)_202C_206C_200B_202C_206C_202E_200D_206E_200F_200B_202E_200D_200B_206D_206D_200D_206D_206E_200B_200F_206B_202D_202C_206B_206D_206C_206B_206E_202A_200E_202B_200F_202C_200D_200B_202A_200B_202A_200B_206A_202E();
		}

		internal _BB _YE()
		{
			return (_BB)_200C_206E_200F_206C_206A_202A_202A_202A_206B_200D_200D_200C_206D_206A_200D_202B_206F_200C_202D_202E_206E_206D_200C_206B_206A_202C_200D_202B_202D_206C_200C_206E_200E_202D_200D_206D_202B_202B_206B_200D_202E();
		}

		internal _BB _kb()
		{
			return (_BB)_200F_206C_202A_202D_200E_200D_206E_206C_202D_202A_202C_200C_200D_206B_202D_206F_206A_206B_202E_202E_200C_206C_200C_200B_206A_206B_206F_200B_200D_200D_202A_206D_200E_206B_206A_202E_200E_202B_200E_206C_202E();
		}

		internal _BB _YH()
		{
			return (_BB)_206F_200D_206B_202D_206A_200E_200B_202D_202A_202C_206A_200F_200C_206B_200C_202C_200C_200B_202C_206A_200B_206D_200C_206F_206F_206E_202B_200D_202C_202D_206E_206C_206F_200E_202D_206C_200B_206D_206B_206E_202E();
		}

		internal _BB _bJ()
		{
			return (_BB)_202C_206C_202B_202D_206B_206C_206D_202A_200B_200E_206A_206D_206D_200F_202A_206D_206F_200D_206C_200F_200F_206E_206E_200F_200F_206B_206E_206E_202C_202D_200C_206C_202B_202C_206D_202A_200E_200C_202A_206B_202E();
		}

		internal _BB _xA()
		{
			return (_BB)_202C_206F_200B_200C_202B_206D_200D_206C_202D_200F_200D_206E_202A_202C_202D_200F_200D_200B_200D_202E_206B_206B_200B_202B_200C_206D_206F_200B_200B_206B_200E_206C_206C_206A_202D_202D_200C_200F_202C_206D_202E();
		}

		internal _BB _JN()
		{
			return (_BB)_206A_206D_202C_206B_206B_206D_202D_202A_206C_202C_206A_206D_202B_202D_206E_206A_206E_202B_200D_206D_202C_202B_202B_200F_206A_202C_202C_202C_202B_202C_200B_200C_202A_200E_200C_206E_202D_206C_206E_200E_202E();
		}

		internal _BB _1G()
		{
			return (_BB)_206C_202D_202E_202C_206B_202B_202C_202D_206D_206C_200C_202B_200D_200C_202B_200F_202A_206C_200D_206C_206F_202B_202A_206F_200F_200D_202B_206C_202E_206B_206C_206C_202A_206B_202B_206C_202C_206B_202A_200C_202E();
		}

		internal _BB _iG()
		{
			return (_BB)_206D_202B_206D_206F_206F_206C_200F_206E_200B_206E_206C_206C_206D_206F_202D_200B_202C_206E_206C_200C_206D_202B_200E_200F_206B_200D_202D_206D_206F_202D_206D_200C_202B_200C_206F_202A_200B_200D_200D_202A_202E();
		}

		internal _BB _2E()
		{
			return (_BB)_200C_202B_202C_206B_206A_202C_200D_206B_206E_206D_200F_202C_206E_202B_200F_206D_206B_206A_200C_202E_206A_200B_200B_202C_206E_200C_206B_206B_206F_206B_200E_202D_206D_202C_200B_202C_206D_202C_206A_200D_202E();
		}

		internal _BB _XL()
		{
			return (_BB)_200D_206E_206E_202C_206A_206C_202B_206F_206E_202B_202A_206D_206F_202C_200F_200D_200D_206C_206C_200F_200C_206D_200D_206A_200B_202C_200B_206E_200C_202B_206E_200D_200F_200B_202A_206F_202D_202D_200D_202C_202E();
		}

		internal _BB _dI()
		{
			return (_BB)_206C_202C_202D_206A_206B_200D_200D_206C_202E_202D_202C_202B_202D_200F_206F_202A_206C_202C_200E_206A_206C_200F_202A_202D_202B_206A_202B_202A_202C_202A_206C_206E_206B_202E_200F_206B_206A_200D_206A_206E_202E();
		}

		internal _BB _EM()
		{
			return (_BB)_202C_206E_202C_200F_200B_200C_200C_206B_202A_200E_206E_202E_206A_206D_206C_202E_200D_200E_206A_206F_206F_202B_206E_202B_202E_206F_202B_202A_200B_206F_200F_200C_202E_200F_206D_202A_202E_200C_202A_206F_202E();
		}

		internal _BB _0e()
		{
			return (_BB)_202A_206E_206D_200F_202D_202B_206B_200F_202B_200E_202D_206C_206A_200D_200C_206A_202E_206D_206C_202C_200F_206F_206F_200C_202E_200B_200D_202E_202E_202A_202D_202A_206A_206F_202E_206F_200D_206D_206E_206E_202E();
		}

		internal _BB _8K()
		{
			return (_BB)_202A_206E_200B_200E_206D_206F_202C_206A_200E_202B_200F_202C_206C_200E_206D_206F_206B_206A_202B_200B_202A_200B_200C_200F_206B_200B_200C_202E_200D_206D_200F_202E_200D_206E_206D_200B_200D_206A_206C_206E_202E();
		}

		internal _BB _aE()
		{
			return (_BB)_202B_206F_200F_200C_202B_200B_200D_202C_202D_202C_200B_200B_202E_200E_206B_206C_202E_200E_200B_206F_202D_206A_202E_200E_202C_200D_202C_206F_202D_200C_202A_200B_206E_206D_206E_200C_206A_206B_206C_202E();
		}

		internal _BB _mL()
		{
			return (_BB)_202C_206D_202B_206C_206D_202D_202A_202B_200C_206A_202B_206E_200B_206E_200D_206E_202A_202E_206E_206B_206E_206E_200D_206F_200D_202C_206C_200F_200C_202D_206D_206F_206E_202E_206F_200F_200D_200E_200B_202B_202E();
		}

		internal _BB _eK()
		{
			return (_BB)_206D_200E_202B_202D_202E_206B_202E_202E_206F_206A_202C_206F_206E_202E_202C_206F_202A_206D_202A_200C_206E_206E_206A_206C_202D_202D_202C_206F_202E_206A_200B_206A_200E_200D_200E_206F_200C_200B_200E_202B_202E();
		}

		static object _202D_200F_200C_206D_202E_206A_206E_200C_206D_206D_206D_206B_200D_206F_202B_200E_206F_206F_200E_200F_200C_206C_206C_206E_206D_202C_200F_202D_202C_206F_206E_206A_202B_206C_200D_206C_200C_206D_206B_202E()
		{
			return new _VE();
		}

		static object _200E_202D_200F_202E_206F_206A_200F_206D_206A_202D_200F_206E_206D_200B_200C_206A_202E_200F_206F_202B_202B_206D_202B_202E_206B_202C_200C_200C_202B_206E_206D_202B_200F_206E_206E_202B_200E_200C_200B_202A_202E()
		{
			return new _tA();
		}

		static object _200B_206C_202E_206B_202E_202D_202D_200E_206F_202D_206C_206D_202C_206C_200B_202E_202D_200C_200C_200F_202D_200E_202A_200F_202A_206A_206F_206E_200B_202A_206E_206E_200F_200F_200D_202A_206C_206A_206B_202D_202E()
		{
			return new _Xm();
		}

		static object _206D_202C_206C_200C_202A_206B_200E_206D_206F_202E_206A_200D_206D_206C_206D_206C_200E_206E_200F_206E_200F_202E_202D_206D_200B_202B_206D_200E_200C_202E_206D_202A_206E_206D_200C_206B_200E_206A_206B_202B_202E()
		{
			return new _6M();
		}

		static object _200F_206C_200F_200B_206C_200B_202D_206E_206B_200E_206F_200C_206B_206D_206B_202E_206E_200B_202B_202C_200E_200F_202B_200D_200B_202C_202E_200F_202C_202C_200D_206E_200C_200D_202C_206F_206F_206D_200C_200F_202E()
		{
			return new _7J();
		}

		static object _200F_202C_202E_206A_206F_206D_206A_206A_202A_200E_200B_200C_200C_202A_206F_206D_202E_202D_206B_200C_200B_206A_202C_206B_206E_206C_202D_206D_206F_202C_206B_202E_200F_202B_200E_206C_200F_206B_202E_202C_202E()
		{
			return new _Kc();
		}

		static object _200C_202A_206F_200F_206C_202E_206A_206D_206C_206B_202D_200E_206C_206B_200B_200D_206F_206E_202B_202C_202B_206D_202E_202E_200B_202A_200F_206A_206D_202A_202D_200E_200C_206C_202A_206E_202D_202D_202B_206B_202E()
		{
			return new _wl();
		}

		static object _202A_202E_200E_206C_202A_206B_206B_200D_206D_202E_202C_202D_202C_202E_200B_206D_200F_200F_206F_202A_200F_206B_206D_202A_206B_200D_202D_202A_206C_202C_200E_206C_202E_200F_200B_200B_202C_200C_202A_206C_202E()
		{
			return new _zG();
		}

		static object _200E_202A_200B_200B_200B_206D_200B_200E_202E_202D_206B_206D_206C_206D_200F_200D_200E_202B_202E_202D_206D_206E_202B_200E_206F_200C_206B_202E_206B_200E_202A_200C_206E_200C_202C_202B_206F_206F_200B_206D_202E()
		{
			return new _aD();
		}

		static object _200D_202B_206B_206E_206A_200F_206D_200B_202D_206A_206D_206A_200F_200F_206E_202B_200D_206C_202A_200B_200F_202D_206D_202D_202C_202B_202B_206D_202B_206C_200B_200D_200D_206F_206A_206C_202A_206A_200F_200C_202E()
		{
			return new _EB();
		}

		static object _202A_206B_206F_200F_206E_202A_200C_206F_200C_200D_206B_206A_206A_202A_200D_200F_202C_202B_206A_202C_200F_206D_206D_202B_200F_206F_202A_200D_202D_200F_202E_202C_202C_202C_200D_206D_200B_202B_202D_206E_202E()
		{
			return new _Cn();
		}

		static object _202A_200E_200C_202A_206E_200C_200C_206F_202E_206D_206E_202C_202A_200F_202B_202C_200D_206B_202D_200B_202E_202D_202D_202E_206F_200E_206E_206C_206B_202B_200F_202C_200F_200B_206B_206A_206A_200C_202B_206C_202E()
		{
			return new _XN();
		}

		static object _206F_200C_206A_206F_206B_202B_206A_202C_200D_202D_202D_202C_200C_200E_200E_200C_200E_202A_200E_202A_202D_200D_200F_200D_206D_200F_206A_206E_206D_200E_200B_202C_206A_206D_202A_200F_200C_202B_206A_200D_202E()
		{
			return new _Al();
		}

		static object _200B_200F_206A_200F_200C_200F_206F_202E_200F_200E_206A_206A_206F_202E_206A_202C_206B_206B_202B_200D_200E_200F_202E_202C_202D_202A_206C_206B_200B_202A_206A_200F_200D_200F_202E_202E_206A_206E_200F_206D_202E()
		{
			return new _rK();
		}

		static object _202B_202D_202B_206C_200D_206A_206F_200F_200E_206B_206A_202D_202A_202B_200F_202E_202C_200E_200D_206A_202D_200D_200D_202D_202D_202B_202C_206F_206C_202C_206D_206D_206C_202E_202B_206D_202D_206D_202C_200C_202E()
		{
			return new _ck();
		}

		static object _206A_206F_206E_202E_206E_206C_200F_206E_200D_200C_206F_202D_202A_200D_206C_202C_202D_206F_202A_200B_206F_202D_202E_202D_200D_200E_200F_206F_202B_206D_200C_200E_200B_206A_200D_200E_200E_206D_206F_202A_202E()
		{
			return new _pA();
		}

		static object _200B_200E_206B_200E_200E_202A_206B_200C_202D_202D_206C_202B_200C_206E_200B_200F_200C_202C_200B_200F_200C_206F_202A_200E_202A_202A_206D_202C_206C_200B_202B_202C_202C_202D_200F_200E_202D_206F_206D_206D_202E()
		{
			return new _ub();
		}

		static object _206A_200C_202B_206A_200D_206A_202C_202A_206C_202C_200E_206E_200B_202B_202C_200F_202B_202A_200E_200F_200C_200F_202E_200D_206D_202E_202C_206B_202B_200D_200B_202D_206D_202D_202A_200B_206B_206F_202E_206E_202E()
		{
			return new _5f();
		}

		static object _202E_202C_200E_206A_206D_206C_206E_200B_202C_202C_200D_206B_206C_202A_206E_206E_200D_200F_202E_206B_202A_202A_202A_200D_202D_202E_202A_202E_200C_206D_202B_200E_200B_202A_200B_202D_202A_206F_202B_202A_202E()
		{
			return new _Hl();
		}

		static object _202E_206D_200B_200D_202E_206B_200C_206B_202E_202A_206F_200E_200F_206F_200F_206A_206A_200F_206A_206B_206C_202A_206F_200F_206E_202B_206A_206D_202E_200F_202D_200B_206C_200B_206A_200C_200F_206A_202B_206D_202E()
		{
			return new _u();
		}

		static object _200F_206C_200E_206C_206E_206E_206B_206E_200E_206B_200E_206A_200C_206C_202C_206B_206A_206F_202B_206B_202D_200B_200C_202E_200B_202D_200F_206E_202D_206B_206D_200E_200B_200D_202C_206E_200F_206C_200B_202A_202E()
		{
			return new _Nd();
		}

		static object _206A_206C_200E_206B_206B_206C_206F_202D_200B_202A_206D_202E_206D_206C_200D_200C_206B_206F_202B_206D_206E_202E_200E_202D_202E_206F_202E_202B_200D_200D_206F_206A_202E_206D_202B_206A_202A_202E_206B_200D_202E()
		{
			return new _nB();
		}

		static object _206E_200C_200D_200C_206C_206F_200E_206C_202B_206F_206B_206A_206A_206F_206B_206E_206C_202D_202E_202B_200D_202C_206E_206C_200C_200F_200E_202B_202D_206E_202E_206C_202A_200E_206C_206F_206F_202E_202B_200C_202E()
		{
			return new _LJ();
		}

		static object _200C_206C_202B_200F_202A_202A_206E_202B_206E_202C_200B_206D_206B_206F_206F_202C_206D_206B_200B_202B_206D_202C_202A_200B_206D_206C_200C_200B_202A_206E_202E_202A_202A_200F_202E_200B_200D_202C_200B_202C_202E()
		{
			return new _ij();
		}

		static object _202B_202D_206C_206F_200E_202C_200E_206A_200F_206B_206A_202C_202A_202B_200F_200D_200D_202E_206F_206D_206D_206C_200F_202D_206D_202B_202E_202D_206E_206E_206D_206C_206E_206F_206C_200F_206A_206B_200D_206B_202E()
		{
			return new _Ag();
		}

		static object _206E_206D_206B_202B_206C_206A_202B_206E_202C_206A_200B_206C_202B_200D_202C_202D_206B_206A_200F_200D_202A_200C_206C_200E_200E_206D_202D_200F_200C_202A_200B_206B_200F_202E_202D_202B_206D_206D_206E_202C_202E()
		{
			return new _8H();
		}

		static object _202E_200E_206A_200C_200E_206E_206B_200B_206E_202C_200C_206B_206A_202A_206C_206D_200C_206A_206F_206A_202D_200E_202B_206A_202D_206B_202C_200F_200F_206C_200B_206C_206D_202A_200F_206B_206F_206C_206B_202D_202E()
		{
			return new _Gm();
		}

		static object _206A_200C_202D_206F_200D_200D_206B_206A_200D_202B_200C_200B_202B_202B_202D_206D_206C_200E_200F_200E_202B_200D_202B_200E_206A_200C_202C_202B_202A_202A_200E_206C_206C_200B_206E_202B_200F_200E_206D_206C_202E()
		{
			return new _AG();
		}

		static object _202D_202C_206E_206C_200B_206C_200C_202A_202D_202C_206D_202D_200D_200E_200D_206F_206B_206D_200D_200D_206C_200F_202E_206E_206A_206E_206C_206A_200C_200B_200C_206C_202C_200E_200C_202A_200B_202D_200D_200E_202E()
		{
			return new _tl();
		}

		static object _206C_202C_206A_202B_206B_202B_200E_206C_206E_202C_206B_202C_206E_206A_200D_202C_206F_202B_206B_202E_206A_206E_200C_200F_206E_200E_200F_206D_200C_202E_200F_200F_206E_206C_202B_200B_202C_206A_202C_200F_202E()
		{
			return new _Pe();
		}

		static object _202C_206C_200B_202C_206C_202E_200D_206E_200F_200B_202E_200D_200B_206D_206D_200D_206D_206E_200B_200F_206B_202D_202C_206B_206D_206C_206B_206E_202A_200E_202B_200F_202C_200D_200B_202A_200B_202A_200B_206A_202E()
		{
			return new _SF();
		}

		static object _200C_206E_200F_206C_206A_202A_202A_202A_206B_200D_200D_200C_206D_206A_200D_202B_206F_200C_202D_202E_206E_206D_200C_206B_206A_202C_200D_202B_202D_206C_200C_206E_200E_202D_200D_206D_202B_202B_206B_200D_202E()
		{
			return new _Yc();
		}

		static object _200F_206C_202A_202D_200E_200D_206E_206C_202D_202A_202C_200C_200D_206B_202D_206F_206A_206B_202E_202E_200C_206C_200C_200B_206A_206B_206F_200B_200D_200D_202A_206D_200E_206B_206A_202E_200E_202B_200E_206C_202E()
		{
			return new _BD();
		}

		static object _206F_200D_206B_202D_206A_200E_200B_202D_202A_202C_206A_200F_200C_206B_200C_202C_200C_200B_202C_206A_200B_206D_200C_206F_206F_206E_202B_200D_202C_202D_206E_206C_206F_200E_202D_206C_200B_206D_206B_206E_202E()
		{
			return new _Ih();
		}

		static object _202C_206C_202B_202D_206B_206C_206D_202A_200B_200E_206A_206D_206D_200F_202A_206D_206F_200D_206C_200F_200F_206E_206E_200F_200F_206B_206E_206E_202C_202D_200C_206C_202B_202C_206D_202A_200E_200C_202A_206B_202E()
		{
			return new _mC();
		}

		static object _202C_206F_200B_200C_202B_206D_200D_206C_202D_200F_200D_206E_202A_202C_202D_200F_200D_200B_200D_202E_206B_206B_200B_202B_200C_206D_206F_200B_200B_206B_200E_206C_206C_206A_202D_202D_200C_200F_202C_206D_202E()
		{
			return new _1E();
		}

		static object _206A_206D_202C_206B_206B_206D_202D_202A_206C_202C_206A_206D_202B_202D_206E_206A_206E_202B_200D_206D_202C_202B_202B_200F_206A_202C_202C_202C_202B_202C_200B_200C_202A_200E_200C_206E_202D_206C_206E_200E_202E()
		{
			return new _Vn();
		}

		static object _206C_202D_202E_202C_206B_202B_202C_202D_206D_206C_200C_202B_200D_200C_202B_200F_202A_206C_200D_206C_206F_202B_202A_206F_200F_200D_202B_206C_202E_206B_206C_206C_202A_206B_202B_206C_202C_206B_202A_200C_202E()
		{
			return new _Sm();
		}

		static object _206D_202B_206D_206F_206F_206C_200F_206E_200B_206E_206C_206C_206D_206F_202D_200B_202C_206E_206C_200C_206D_202B_200E_200F_206B_200D_202D_206D_206F_202D_206D_200C_202B_200C_206F_202A_200B_200D_200D_202A_202E()
		{
			return new _jk();
		}

		static object _200C_202B_202C_206B_206A_202C_200D_206B_206E_206D_200F_202C_206E_202B_200F_206D_206B_206A_200C_202E_206A_200B_200B_202C_206E_200C_206B_206B_206F_206B_200E_202D_206D_202C_200B_202C_206D_202C_206A_200D_202E()
		{
			return new _9d();
		}

		static object _200D_206E_206E_202C_206A_206C_202B_206F_206E_202B_202A_206D_206F_202C_200F_200D_200D_206C_206C_200F_200C_206D_200D_206A_200B_202C_200B_206E_200C_202B_206E_200D_200F_200B_202A_206F_202D_202D_200D_202C_202E()
		{
			return new _HB();
		}

		static object _206C_202C_202D_206A_206B_200D_200D_206C_202E_202D_202C_202B_202D_200F_206F_202A_206C_202C_200E_206A_206C_200F_202A_202D_202B_206A_202B_202A_202C_202A_206C_206E_206B_202E_200F_206B_206A_200D_206A_206E_202E()
		{
			return new _yE();
		}

		static object _202C_206E_202C_200F_200B_200C_200C_206B_202A_200E_206E_202E_206A_206D_206C_202E_200D_200E_206A_206F_206F_202B_206E_202B_202E_206F_202B_202A_200B_206F_200F_200C_202E_200F_206D_202A_202E_200C_202A_206F_202E()
		{
			return new _vg();
		}

		static object _202A_206E_206D_200F_202D_202B_206B_200F_202B_200E_202D_206C_206A_200D_200C_206A_202E_206D_206C_202C_200F_206F_206F_200C_202E_200B_200D_202E_202E_202A_202D_202A_206A_206F_202E_206F_200D_206D_206E_206E_202E()
		{
			return new _PI();
		}

		static object _202A_206E_200B_200E_206D_206F_202C_206A_200E_202B_200F_202C_206C_200E_206D_206F_206B_206A_202B_200B_202A_200B_200C_200F_206B_200B_200C_202E_200D_206D_200F_202E_200D_206E_206D_200B_200D_206A_206C_206E_202E()
		{
			return new _Ej();
		}

		static object _202B_206F_200F_200C_202B_200B_200D_202C_202D_202C_200B_200B_202E_200E_206B_206C_202E_200E_200B_206F_202D_206A_202E_200E_202C_200D_202C_206F_202D_200C_202A_200B_206E_206D_206E_200C_206A_206B_206C_202E()
		{
			return new _xm();
		}

		static object _202C_206D_202B_206C_206D_202D_202A_202B_200C_206A_202B_206E_200B_206E_200D_206E_202A_202E_206E_206B_206E_206E_200D_206F_200D_202C_206C_200F_200C_202D_206D_206F_206E_202E_206F_200F_200D_200E_200B_202B_202E()
		{
			return new _2F();
		}

		static object _206D_200E_202B_202D_202E_206B_202E_202E_206F_206A_202C_206F_206E_202E_202C_206F_202A_206D_202A_200C_206E_206E_206A_206C_202D_202D_202C_206F_202E_206A_200B_206A_200E_200D_200E_206F_200C_200B_200E_202B_202E()
		{
			return new _Xc();
		}
	}

	private static readonly Dictionary<_Em, Dictionary<int, Func<_BB>>> _hD;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _Sg()
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2799437717u);
		while (true)
		{
			int num = 1492198912;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-480931543 * -2022624559 - (~((-(485540927 * (~(~309356121 * 975449059) - ((0x5F275DE ^ 0x340B8AA7) + (-710808341 ^ 0x12AA1984) + -1486910707))) - (num2 + (-((0x70C2B950 ^ -1686986058) + (-1561460526 ^ -287976905)) + ~(1182383179 - (-2027370183 ^ 0x70006F52)) + (-99068333 * ((2061277929 * --1833726257) ^ 0x6406939C) - (-1133146911 * (~428736537 * -1280176551) + -((-1503490931 - 1726925317) * 1963925867))) - ~(-(~(-(~1013410477)) + (0x71B6B1C7 ^ -210505147)))))) * -2015516119) ^ 0x721797D9) - ~894736615 - -1615095706)) % 50)
				{
				case 10u:
					break;
				default:
					return;
				case 26u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x1482B12E ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3749316014u))), () => (_BB)_VE._200B_200F_206A_200F_200C_200F_206F_202E_200F_200E_206A_206A_206F_202E_206A_202C_206B_206B_202B_200D_200E_200F_202E_202C_202D_202A_206C_206B_200B_202A_206A_200F_200D_200F_202E_202E_206A_206E_200F_206D_202E());
					num = ((int)num3 * -599788266) ^ -1936399912;
					continue;
				case 41u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-436093352 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2743395589u)), () => (_BB)_VE._206F_200C_206A_206F_206B_202B_206A_202C_200D_202D_202D_202C_200C_200E_200E_200C_200E_202A_200E_202A_202D_200D_200F_200D_206D_200F_206A_206E_206D_200E_200B_202C_206A_206D_202A_200F_200C_202B_206A_200D_202E());
					num = (int)((num3 * 1987900254) ^ 0x77D8DC6E);
					continue;
				case 43u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0xF82EA0C ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3981903119u))), () => (_BB)_VE._206C_202C_206A_202B_206B_202B_200E_206C_206E_202C_206B_202C_206E_206A_200D_202C_206F_202B_206B_202E_206A_206E_200C_200F_206E_200E_200F_206D_200C_202E_200F_200F_206E_206C_202B_200B_202C_206A_202C_200F_202E());
					num = (int)((num3 * 512833025) ^ 0x54F95655);
					continue;
				case 17u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x7EEC3C92 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 462491630u))), () => (_BB)_VE._200C_206E_200F_206C_206A_202A_202A_202A_206B_200D_200D_200C_206D_206A_200D_202B_206F_200C_202D_202E_206E_206D_200C_206B_206A_202C_200D_202B_202D_206C_200C_206E_200E_202D_200D_206D_202B_202B_206B_200D_202E());
					num = ((int)num3 * -1827618055) ^ 0x465D355;
					continue;
				case 12u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x21ABB64B ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3536593953u))), () => (_BB)_VE._202D_202C_206E_206C_200B_206C_200C_202A_202D_202C_206D_202D_200D_200E_200D_206F_206B_206D_200D_200D_206C_200F_202E_206E_206A_206E_206C_206A_200C_200B_200C_206C_202C_200E_200C_202A_200B_202D_200D_200E_202E());
					num = ((int)num3 * -724685866) ^ 0x2FB48113;
					continue;
				case 4u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-849584385 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3672423863u)), () => (_BB)_VE._202A_206E_200B_200E_206D_206F_202C_206A_200E_202B_200F_202C_206C_200E_206D_206F_206B_206A_202B_200B_202A_200B_200C_200F_206B_200B_200C_202E_200D_206D_200F_202E_200D_206E_206D_200B_200D_206A_206C_206E_202E());
					num = (int)(num3 * 1409348891) ^ -1209596287;
					continue;
				case 34u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-449192419 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 393523386u)), () => (_BB)_VE._202E_200E_206A_200C_200E_206E_206B_200B_206E_202C_200C_206B_206A_202A_206C_206D_200C_206A_206F_206A_202D_200E_202B_206A_202D_206B_202C_200F_200F_206C_200B_206C_206D_202A_200F_206B_206F_206C_206B_202D_202E());
					num = (int)((num3 * 370801036) ^ 0x495C8358);
					continue;
				case 27u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-20196286 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1218043158u)), () => (_BB)_VE._202C_206C_202B_202D_206B_206C_206D_202A_200B_200E_206A_206D_206D_200F_202A_206D_206F_200D_206C_200F_200F_206E_206E_200F_200F_206B_206E_206E_202C_202D_200C_206C_202B_202C_206D_202A_200E_200C_202A_206B_202E());
					num = (int)((num3 * 1630354455) ^ 0x58918C6E);
					continue;
				case 36u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x3A385C41 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 340900614u))), () => (_BB)_VE._200B_206C_202E_206B_202E_202D_202D_200E_206F_202D_206C_206D_202C_206C_200B_202E_202D_200C_200C_200F_202D_200E_202A_200F_202A_206A_206F_206E_200B_202A_206E_206E_200F_200F_200D_202A_206C_206A_206B_202D_202E());
					num = (int)((num3 * 988748742) ^ 0x494DDEC5);
					continue;
				case 24u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x4E27CC85 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3839159959u))), () => (_BB)_VE._206A_206C_200E_206B_206B_206C_206F_202D_200B_202A_206D_202E_206D_206C_200D_200C_206B_206F_202B_206D_206E_202E_200E_202D_202E_206F_202E_202B_200D_200D_206F_206A_202E_206D_202B_206A_202A_202E_206B_200D_202E());
					num = ((int)num3 * -152158895) ^ -819320043;
					continue;
				case 47u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1629225573 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 679585897u)), () => (_BB)_VE._206F_200D_206B_202D_206A_200E_200B_202D_202A_202C_206A_200F_200C_206B_200C_202C_200C_200B_202C_206A_200B_206D_200C_206F_206F_206E_202B_200D_202C_202D_206E_206C_206F_200E_202D_206C_200B_206D_206B_206E_202E());
					num = (int)(num3 * 706894310) ^ -266283643;
					continue;
				case 49u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-45164140 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3336565209u)), () => (_BB)_VE._206D_202B_206D_206F_206F_206C_200F_206E_200B_206E_206C_206C_206D_206F_202D_200B_202C_206E_206C_200C_206D_202B_200E_200F_206B_200D_202D_206D_206F_202D_206D_200C_202B_200C_206F_202A_200B_200D_200D_202A_202E());
					num = (int)(num3 * 1965343959) ^ -889656535;
					continue;
				case 18u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1792593766 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2350617038u)), () => (_BB)_VE._202A_206B_206F_200F_206E_202A_200C_206F_200C_200D_206B_206A_206A_202A_200D_200F_202C_202B_206A_202C_200F_206D_206D_202B_200F_206F_202A_200D_202D_200F_202E_202C_202C_202C_200D_206D_200B_202B_202D_206E_202E());
					num = ((int)num3 * -448539509) ^ 0x19302C21;
					continue;
				case 14u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1918462737 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3975669940u)), () => (_BB)_VE._202C_206C_200B_202C_206C_202E_200D_206E_200F_200B_202E_200D_200B_206D_206D_200D_206D_206E_200B_200F_206B_202D_202C_206B_206D_206C_206B_206E_202A_200E_202B_200F_202C_200D_200B_202A_200B_202A_200B_206A_202E());
					num = ((int)num3 * -310434328) ^ -525747001;
					continue;
				case 44u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1792593766 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 880627419u)), () => (_BB)_VE._202B_202D_202B_206C_200D_206A_206F_200F_200E_206B_206A_202D_202A_202B_200F_202E_202C_200E_200D_206A_202D_200D_200D_202D_202D_202B_202C_206F_206C_202C_206D_206D_206C_202E_202B_206D_202D_206D_202C_200C_202E());
					num = (int)((num3 * 95534251) ^ 0x6076DC91);
					continue;
				case 30u:
					_hD = (Dictionary<_Em, Dictionary<int, Func<_BB>>>)Activator.CreateInstance(typeof(Dictionary<_Em, Dictionary<int, Func<_BB>>>));
					num = (int)(num3 * 2091046753) ^ -783810004;
					continue;
				case 40u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x6E556F35 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1876471589u))), () => (_BB)_VE._200D_206E_206E_202C_206A_206C_202B_206F_206E_202B_202A_206D_206F_202C_200F_200D_200D_206C_206C_200F_200C_206D_200D_206A_200B_202C_200B_206E_200C_202B_206E_200D_200F_200B_202A_206F_202D_202D_200D_202C_202E());
					num = ((int)num3 * -1940918299) ^ 0x4A84BCB4;
					continue;
				case 42u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-948440027 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2941700803u)), () => (_BB)_VE._200F_206C_200E_206C_206E_206E_206B_206E_200E_206B_200E_206A_200C_206C_202C_206B_206A_206F_202B_206B_202D_200B_200C_202E_200B_202D_200F_206E_202D_206B_206D_200E_200B_200D_202C_206E_200F_206C_200B_202A_202E());
					num = (int)(num3 * 1924906123) ^ -1306660832;
					continue;
				case 20u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1291815034 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2221449798u)), () => (_BB)_VE._206A_200C_202D_206F_200D_200D_206B_206A_200D_202B_200C_200B_202B_202B_202D_206D_206C_200E_200F_200E_202B_200D_202B_200E_206A_200C_202C_202B_202A_202A_200E_206C_206C_200B_206E_202B_200F_200E_206D_206C_202E());
					num = ((int)num3 * -261607820) ^ 0x11972BC0;
					continue;
				case 39u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x5FF79F32 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 4071940075u))), () => (_BB)_VE._202B_206F_200F_200C_202B_200B_200D_202C_202D_202C_200B_200B_202E_200E_206B_206C_202E_200E_200B_206F_202D_206A_202E_200E_202C_200D_202C_206F_202D_200C_202A_200B_206E_206D_206E_200C_206A_206B_206C_202E());
					num = ((int)num3 * -1330293527) ^ -926762772;
					continue;
				case 22u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0xC0983D2 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3195797420u))), () => (_BB)_VE._206D_200E_202B_202D_202E_206B_202E_202E_206F_206A_202C_206F_206E_202E_202C_206F_202A_206D_202A_200C_206E_206E_206A_206C_202D_202D_202C_206F_202E_206A_200B_206A_200E_200D_200E_206F_200C_200B_200E_202B_202E());
					num = ((int)num3 * -1517851050) ^ -1914218551;
					continue;
				case 45u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-409789036 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3782660730u)), () => (_BB)_VE._200C_206C_202B_200F_202A_202A_206E_202B_206E_202C_200B_206D_206B_206F_206F_202C_206D_206B_200B_202B_206D_202C_202A_200B_206D_206C_200C_200B_202A_206E_202E_202A_202A_200F_202E_200B_200D_202C_200B_202C_202E());
					num = ((int)num3 * -898118190) ^ -342430076;
					continue;
				case 25u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-880329026 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3360152971u)), () => (_BB)_VE._200F_202C_202E_206A_206F_206D_206A_206A_202A_200E_200B_200C_200C_202A_206F_206D_202E_202D_206B_200C_200B_206A_202C_206B_206E_206C_202D_206D_206F_202C_206B_202E_200F_202B_200E_206C_200F_206B_202E_202C_202E());
					num = ((int)num3 * -1004600887) ^ 0x1A810DD8;
					continue;
				case 48u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x4436C2F7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 697875149u))), () => (_BB)_VE._202B_202D_206C_206F_200E_202C_200E_206A_200F_206B_206A_202C_202A_202B_200F_200D_200D_202E_206F_206D_206D_206C_200F_202D_206D_202B_202E_202D_206E_206E_206D_206C_206E_206F_206C_200F_206A_206B_200D_206B_202E());
					num = ((int)num3 * -53984649) ^ -331819411;
					continue;
				case 6u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0xD817C3F ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 468134184u))), () => (_BB)_VE._200F_206C_202A_202D_200E_200D_206E_206C_202D_202A_202C_200C_200D_206B_202D_206F_206A_206B_202E_202E_200C_206C_200C_200B_206A_206B_206F_200B_200D_200D_202A_206D_200E_206B_206A_202E_200E_202B_200E_206C_202E());
					num = (int)((num3 * 2120752692) ^ 0x3D0A9995);
					continue;
				case 46u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x259E40A9 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 950431537u))), () => (_BB)_VE._206C_202C_202D_206A_206B_200D_200D_206C_202E_202D_202C_202B_202D_200F_206F_202A_206C_202C_200E_206A_206C_200F_202A_202D_202B_206A_202B_202A_202C_202A_206C_206E_206B_202E_200F_206B_206A_200D_206A_206E_202E());
					num = (int)(num3 * 1087507079) ^ -409739727;
					continue;
				case 5u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x55F0B1BA ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1491489071u))), () => (_BB)_VE._206D_202C_206C_200C_202A_206B_200E_206D_206F_202E_206A_200D_206D_206C_206D_206C_200E_206E_200F_206E_200F_202E_202D_206D_200B_202B_206D_200E_200C_202E_206D_202A_206E_206D_200C_206B_200E_206A_206B_202B_202E());
					num = (int)(num3 * 1963627816) ^ -1674427812;
					continue;
				case 38u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x55F0B1BA ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1854762998u))), () => (_BB)_VE._200E_202D_200F_202E_206F_206A_200F_206D_206A_202D_200F_206E_206D_200B_200C_206A_202E_200F_206F_202B_202B_206D_202B_202E_206B_202C_200C_200C_202B_206E_206D_202B_200F_206E_206E_202B_200E_200C_200B_202A_202E());
					num = (int)((num3 * 1879740484) ^ 0x25325982);
					continue;
				case 15u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x1482B12E ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3462297778u))), () => (_BB)_VE._202A_200E_200C_202A_206E_200C_200C_206F_202E_206D_206E_202C_202A_200F_202B_202C_200D_206B_202D_200B_202E_202D_202D_202E_206F_200E_206E_206C_206B_202B_200F_202C_200F_200B_206B_206A_206A_200C_202B_206C_202E());
					num = ((int)num3 * -384037360) ^ -725830077;
					continue;
				case 33u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1291820431 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2442950651u)), () => (_BB)_VE._206E_200C_200D_200C_206C_206F_200E_206C_202B_206F_206B_206A_206A_206F_206B_206E_206C_202D_202E_202B_200D_202C_206E_206C_200C_200F_200E_202B_202D_206E_202E_206C_202A_200E_206C_206F_206F_202E_202B_200C_202E());
					num = (int)(num3 * 1231680274) ^ -431915691;
					continue;
				case 32u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1629225573 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 960755590u)), () => (_BB)_VE._200C_202B_202C_206B_206A_202C_200D_206B_206E_206D_200F_202C_206E_202B_200F_206D_206B_206A_200C_202E_206A_200B_200B_202C_206E_200C_206B_206B_206F_206B_200E_202D_206D_202C_200B_202C_206D_202C_206A_200D_202E());
					num = ((int)num3 * -1528623746) ^ 0xD591342;
					continue;
				case 9u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1463473538 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 4079274824u)), () => (_BB)_VE._206A_206D_202C_206B_206B_206D_202D_202A_206C_202C_206A_206D_202B_202D_206E_206A_206E_202B_200D_206D_202C_202B_202B_200F_206A_202C_202C_202C_202B_202C_200B_200C_202A_200E_200C_206E_202D_206C_206E_200E_202E());
					num = (int)(num3 * 916406427) ^ -1362645206;
					continue;
				case 3u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-368495166 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2088764441u)), () => (_BB)_VE._200C_202A_206F_200F_206C_202E_206A_206D_206C_206B_202D_200E_206C_206B_200B_200D_206F_206E_202B_202C_202B_206D_202E_202E_200B_202A_200F_206A_206D_202A_202D_200E_200C_206C_202A_206E_202D_202D_202B_206B_202E());
					num = (int)((num3 * 773651319) ^ 0x1D67B9C6);
					continue;
				case 0u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x55641B3A ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2646351864u))), () => (_BB)_VE._202E_206D_200B_200D_202E_206B_200C_206B_202E_202A_206F_200E_200F_206F_200F_206A_206A_200F_206A_206B_206C_202A_206F_200F_206E_202B_206A_206D_202E_200F_202D_200B_206C_200B_206A_200C_200F_206A_202B_206D_202E());
					num = (int)((num3 * 437895108) ^ 0x54028C60);
					continue;
				case 23u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x2B80C51E ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 201886618u))), () => (_BB)_VE._200D_202B_206B_206E_206A_200F_206D_200B_202D_206A_206D_206A_200F_200F_206E_202B_200D_206C_202A_200B_200F_202D_206D_202D_202C_202B_202B_206D_202B_206C_200B_200D_200D_206F_206A_206C_202A_206A_200F_200C_202E());
					num = (int)((num3 * 1784400142) ^ 0x660381CA);
					continue;
				case 1u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x3A6EEBB3 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1870916466u))), () => (_BB)_VE._206C_202D_202E_202C_206B_202B_202C_202D_206D_206C_200C_202B_200D_200C_202B_200F_202A_206C_200D_206C_206F_202B_202A_206F_200F_200D_202B_206C_202E_206B_206C_206C_202A_206B_202B_206C_202C_206B_202A_200C_202E());
					num = (int)(num3 * 1907701859) ^ -1146280730;
					continue;
				case 8u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1724925184 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3292080585u)), () => (_BB)_VE._200E_202A_200B_200B_200B_206D_200B_200E_202E_202D_206B_206D_206C_206D_200F_200D_200E_202B_202E_202D_206D_206E_202B_200E_206F_200C_206B_202E_206B_200E_202A_200C_206E_200C_202C_202B_206F_206F_200B_206D_202E());
					num = ((int)num3 * -1680061668) ^ 0x193F8F49;
					continue;
				case 31u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1629225573 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 565664804u)), () => (_BB)_VE._202C_206F_200B_200C_202B_206D_200D_206C_202D_200F_200D_206E_202A_202C_202D_200F_200D_200B_200D_202E_206B_206B_200B_202B_200C_206D_206F_200B_200B_206B_200E_206C_206C_206A_202D_202D_200C_200F_202C_206D_202E());
					num = ((int)num3 * -1587834327) ^ 0x61E590D0;
					continue;
				case 16u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-722572815 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2084302139u)), () => (_BB)_VE._200F_206C_200F_200B_206C_200B_202D_206E_206B_200E_206F_200C_206B_206D_206B_202E_206E_200B_202B_202C_200E_200F_202B_200D_200B_202C_202E_200F_202C_202C_200D_206E_200C_200D_202C_206F_206F_206D_200C_200F_202E());
					num = (int)((num3 * 1190830936) ^ 0x5CF07DA7);
					continue;
				case 13u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-154843477 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3378949504u)), () => (_BB)_VE._206A_206F_206E_202E_206E_206C_200F_206E_200D_200C_206F_202D_202A_200D_206C_202C_202D_206F_202A_200B_206F_202D_202E_202D_200D_200E_200F_206F_202B_206D_200C_200E_200B_206A_200D_200E_200E_206D_206F_202A_202E());
					num = ((int)num3 * -1639094386) ^ -912364881;
					continue;
				case 7u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-880329026 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 292554627u)), () => (_BB)_VE._202A_202E_200E_206C_202A_206B_206B_200D_206D_202E_202C_202D_202C_202E_200B_206D_200F_200F_206F_202A_200F_206B_206D_202A_206B_200D_202D_202A_206C_202C_200E_206C_202E_200F_200B_200B_202C_200C_202A_206C_202E());
					num = (int)((num3 * 587970896) ^ 0x61316E8A);
					continue;
				case 28u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-410928296 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3155783988u)), () => (_BB)_VE._206A_200C_202B_206A_200D_206A_202C_202A_206C_202C_200E_206E_200B_202B_202C_200F_202B_202A_200E_200F_200C_200F_202E_200D_206D_202E_202C_206B_202B_200D_200B_202D_206D_202D_202A_200B_206B_206F_202E_206E_202E());
					num = ((int)num3 * -784545260) ^ 0x703DE93C;
					continue;
				case 2u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-698384819 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3049520804u)), () => (_BB)_VE._202E_202C_200E_206A_206D_206C_206E_200B_202C_202C_200D_206B_206C_202A_206E_206E_200D_200F_202E_206B_202A_202A_202A_200D_202D_202E_202A_202E_200C_206D_202B_200E_200B_202A_200B_202D_202A_206F_202B_202A_202E());
					num = ((int)num3 * -332133676) ^ 0x29CC97E2;
					continue;
				case 35u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-20196286 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 305797084u)), () => (_BB)_VE._202C_206E_202C_200F_200B_200C_200C_206B_202A_200E_206E_202E_206A_206D_206C_202E_200D_200E_206A_206F_206F_202B_206E_202B_202E_206F_202B_202A_200B_206F_200F_200C_202E_200F_206D_202A_202E_200C_202A_206F_202E());
					num = ((int)num3 * -1246531125) ^ -1790415008;
					continue;
				case 29u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x55641B3A ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1170547930u))), () => (_BB)_VE._200B_200E_206B_200E_200E_202A_206B_200C_202D_202D_206C_202B_200C_206E_200B_200F_200C_202C_200B_200F_200C_206F_202A_200E_202A_202A_206D_202C_206C_200B_202B_202C_202C_202D_200F_200E_202D_206F_206D_206D_202E());
					num = (int)(num3 * 1280433994) ^ -310969066;
					continue;
				case 19u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1513942003 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2702122218u)), () => (_BB)_VE._206E_206D_206B_202B_206C_206A_202B_206E_202C_206A_200B_206C_202B_200D_202C_202D_206B_206A_200F_200D_202A_200C_206C_200E_200E_206D_202D_200F_200C_202A_200B_206B_200F_202E_202D_202B_206D_206D_206E_202C_202E());
					num = ((int)num3 * -568839746) ^ 0x2731A4AC;
					continue;
				case 37u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x56717AB ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3359328596u))), () => (_BB)_VE._202C_206D_202B_206C_206D_202D_202A_202B_200C_206A_202B_206E_200B_206E_200D_206E_202A_202E_206E_206B_206E_206E_200D_206F_200D_202C_206C_200F_200C_202D_206D_206F_206E_202E_206F_200F_200D_200E_200B_202B_202E());
					num = (int)((num3 * 884992553) ^ 0x2F20767D);
					continue;
				case 11u:
					_7m<int, Func<_BB>, Dictionary<int, Func<_BB>>>((_Em)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-20196286 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3836803469u)), () => (_BB)_VE._202A_206E_206D_200F_202D_202B_206B_200F_202B_200E_202D_206C_206A_200D_200C_206A_202E_206D_206C_202C_200F_206F_206F_200C_202E_200B_200D_202E_202E_202A_202D_202A_206A_206F_202E_206F_200D_206D_206E_206E_202E());
					num = (int)((num3 * 229634964) ^ 0x4ACB49EE);
					continue;
				case 21u:
					return;
				}
				break;
			}
		}
	}

	private static void _7m<T0, T1, T2>(_Em P_0, Func<_BB> P_1) where T0 : notnull where T1 : notnull where T2 : notnull
	{
		//IL_011b: Expected O, but got I4
		//IL_0137: Expected I4, but got O
		if (!_hD.ContainsKey(P_0))
		{
			goto IL_0010;
		}
		goto IL_010a;
		IL_0010:
		int num = -99512596;
		goto IL_0015;
		IL_0015:
		T0 val = default(T0);
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(-(~(~(num2 + (((~(0x20C188C5 ^ -1836318105) - ~(-1668599680 + (1998431682 - 166165547) + 2132608050)) ^ -((-(-1430882735 + -394033310) + -573322505 * (1955364257 * 1850399473)) ^ 0x7FFA1507)) - -(-(-(-(0x321327B9 ^ 0x6933C13B))) - -(-(--1535090531 ^ -1460828826))))))) * -541900729)) % 5)
			{
			case 0u:
				break;
			default:
				return;
			case 2u:
				_hD[P_0] = (Dictionary<int, Func<_BB>>)Activator.CreateInstance(typeof(Dictionary<int, Func<_BB>>));
				num = ((int)num3 * -1915244734) ^ 0x7C50BA20;
				continue;
			case 4u:
				goto IL_010a;
			case 3u:
				_hD[P_0][(int)val] = P_1;
				num = (int)((num3 * 1196169923) ^ 0x70F0A695);
				continue;
			case 1u:
				return;
			}
			break;
		}
		goto IL_0010;
		IL_010a:
		val = (T0)_hD[P_0].Count;
		num = 840210847;
		goto IL_0015;
	}

	public static _BB _mH<T0>(_Em P_0, T0 P_1) where T0 : notnull
	{
		//IL_0011: Expected I4, but got O
		return _hD[P_0][(int)P_1]();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static T2 _Nh<T0, T1, T2>(_Em P_0, _BB P_1) where T0 : notnull where T1 : notnull where T2 : notnull
	{
		//IL_00df: Expected O, but got I4
		//IL_03cc: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3120700782u);
		Dictionary<int, Func<_BB>>.Enumerator enumerator = _hD[P_0].GetEnumerator();
		T2 result = default(T2);
		try
		{
			obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1123876989u);
			KeyValuePair<int, Func<_BB>> current = default(KeyValuePair<int, Func<_BB>>);
			while (true)
			{
				IL_002b:
				int num = -801086118;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((-((-(-num2) ^ -(-(0x2DB53FB6 ^ -1979993732))) * -789477309) - 1683972970 - -811643302 * -1696686527) * 1940317927)) % 16)
					{
					case 13u:
						break;
					default:
						goto end_IL_0030;
					case 6u:
						result = (T2)current.Key;
						num = (int)((num3 * 149246413) ^ 0x755D4228);
						continue;
					case 10u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1321695294u);
						num = (int)(num3 * 1893294787) ^ -494890240;
						continue;
					case 2u:
					{
						int num6;
						int num7;
						if (!enumerator.MoveNext())
						{
							num6 = 1162917314;
							num7 = num6;
						}
						else
						{
							num6 = 1154184325;
							num7 = num6;
						}
						num = num6 ^ (int)(num3 * 173290003);
						continue;
					}
					case 4u:
						num = ((int)num3 * -637805140) ^ 0x3826CB72;
						continue;
					case 14u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3259929993u);
						num = ((int)num3 * -882079306) ^ 0x2E7667EC;
						continue;
					case 5u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3259929993u);
						num = ((int)num3 * -140096882) ^ 0x293C3A4A;
						continue;
					case 3u:
					{
						int num4;
						int num5;
						if (!_206B_202A_206E_206F_200D_206A_206F_200F_206F_200C_206A_202E_202D_200B_202E_206B_202E_206E_200E_202B_200F_206F_206A_202A_206D_202C_206D_200E_206A_202C_206C_206D_206F_200D_200F_200B_202E_206C_202C_202E_202E((Type)_206B_202A_206D_200E_206A_202A_202C_206B_200E_206F_202D_202A_200F_202B_200C_200F_202D_202D_206A_206F_200D_202C_206E_206A_202B_206A_200C_206E_202E_200F_206F_206B_206A_206E_200B_202A_202B_206A_206F_206B_202E((object)current.Value()), (Type)_206B_202A_206D_200E_206A_202A_202C_206B_200E_206F_202D_202A_200F_202B_200C_200F_202D_202D_206A_206F_200D_202C_206E_206A_202B_206A_200C_206E_202E_200F_206F_206B_206A_206E_200B_202A_202B_206A_206F_206B_202E((object)P_1)))
						{
							num4 = -712981350;
							num5 = num4;
						}
						else
						{
							num4 = -643149471;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1341311624);
						continue;
					}
					case 1u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(130, 4036684974u);
						num = ((int)num3 * -624416883) ^ 0x24838122;
						continue;
					case 12u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2973272002u);
						num = -878058960;
						continue;
					case 15u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(137, 2353317227u);
						num = (int)(num3 * 1813172910) ^ -1771292657;
						continue;
					case 9u:
						current = enumerator.Current;
						num = (int)(num3 * 477726176) ^ -1482419049;
						continue;
					case 7u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(136, 3946435886u);
						num = 1640298667;
						continue;
					case 11u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(131, 3095546990u);
						num = (int)(num3 * 18525362) ^ -1315024637;
						continue;
					case 0u:
						goto end_IL_0030;
					case 8u:
						goto IL_0440;
					}
					goto IL_002b;
					continue;
					end_IL_0030:
					break;
				}
				break;
			}
		}
		finally
		{
			obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(132, 695681191u);
			while (true)
			{
				IL_02a9:
				int num8 = -54853049;
				while (true)
				{
					int num2 = num8;
					uint num3;
					switch ((num3 = (uint)((-((-(-num2) ^ -(-(0x2DB53FB6 ^ -1979993732))) * -789477309) - 1683972970 - -811643302 * -1696686527) * 1940317927)) % 6)
					{
					case 2u:
						break;
					default:
						goto end_IL_02ae;
					case 5u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(133, 2353317227u);
						num8 = ((int)num3 * -2072453776) ^ 0x15062A60;
						continue;
					case 4u:
						((IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						num8 = ((int)num3 * -1512503800) ^ 0x36713E7D;
						continue;
					case 0u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(134, 4036684974u);
						num8 = (int)(num3 * 534476757) ^ -1080502401;
						continue;
					case 1u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(135, 3095546990u);
						num8 = (int)((num3 * 10032934) ^ 0x2112466);
						continue;
					case 3u:
						goto end_IL_02ae;
					}
					goto IL_02a9;
					continue;
					end_IL_02ae:
					break;
				}
				break;
			}
		}
		return (T2)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1108326854 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 251320738u));
		IL_0440:
		while (true)
		{
			obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1258691797u);
			int num9 = -25004192;
			while (true)
			{
				int num2 = num9;
				uint num3;
				switch ((num3 = (uint)((-((-(-num2) ^ -(-(0x2DB53FB6 ^ -1979993732))) * -789477309) - 1683972970 - -811643302 * -1696686527) * 1940317927)) % 3)
				{
				case 2u:
					goto IL_03cc;
				case 1u:
					break;
				default:
					return result;
				}
				break;
				IL_03cc:
				num9 = -1104722462;
			}
		}
	}

	static object _206B_202A_206D_200E_206A_202A_202C_206B_200E_206F_202D_202A_200F_202B_200C_200F_202D_202D_206A_206F_200D_202C_206E_206A_202B_206A_200C_206E_202E_200F_206F_206B_206A_206E_200B_202A_202B_206A_206F_206B_202E(object P_0)
	{
		return P_0.GetType();
	}

	static bool _206B_202A_206E_206F_200D_206A_206F_200F_206F_200C_206A_202E_202D_200B_202E_206B_202E_206E_200E_202B_200F_206F_206A_202A_206D_202C_206D_200E_206A_202C_206C_206D_206F_200D_200F_200B_202E_206C_202C_202E_202E(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}
}
