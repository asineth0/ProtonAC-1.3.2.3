using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

internal class EE0FD11A7E47463C : C179263454B44BF6
{
	private class FAF70C516C494AEF
	{
		[CompilerGenerated]
		private int FC0945B70AE1453E;

		[CompilerGenerated]
		private string? F67716C1152448CD;

		[CompilerGenerated]
		private B31394A5015E4A0D? D4180D94226F47B3;

		public int _67061D87641B4F4D
		{
			[CompilerGenerated]
			get
			{
				return FC0945B70AE1453E;
			}
			[CompilerGenerated]
			set
			{
				FC0945B70AE1453E = fC0945B70AE1453E;
			}
		}

		public string? _9E19A7E7BC164341
		{
			[CompilerGenerated]
			get
			{
				return F67716C1152448CD;
			}
			[CompilerGenerated]
			set
			{
				F67716C1152448CD = f67716C1152448CD;
			}
		}

		public B31394A5015E4A0D? _915B09CDC84D4F1E
		{
			[CompilerGenerated]
			get
			{
				return D4180D94226F47B3;
			}
			[CompilerGenerated]
			set
			{
				D4180D94226F47B3 = d4180D94226F47B;
			}
		}
	}

	private class B31394A5015E4A0D
	{
		[CompilerGenerated]
		private string[]? E4DF813D22144582;

		[CompilerGenerated]
		private string[]? _9F5F3B3640D8427F;

		[CompilerGenerated]
		private string[]? A9F411B895EB4974;

		public string[]? _7A368F857787437D
		{
			[CompilerGenerated]
			get
			{
				return E4DF813D22144582;
			}
			[CompilerGenerated]
			set
			{
				E4DF813D22144582 = e4DF813D;
			}
		}

		public string[]? E27D8701AB414EDA
		{
			[CompilerGenerated]
			get
			{
				return _9F5F3B3640D8427F;
			}
			[CompilerGenerated]
			set
			{
				_9F5F3B3640D8427F = array;
			}
		}

		public string[]? _87C4CD27B4B94447
		{
			[CompilerGenerated]
			get
			{
				return A9F411B895EB4974;
			}
			[CompilerGenerated]
			set
			{
				A9F411B895EB4974 = a9F411B895EB;
			}
		}
	}

	private class AFEE455F5F9849CC
	{
		public int _9FDCC79813744F4A = 0;

		public int B0C3ADEBCC3941A6;

		public string _4DCAD2C3C0664B80;
	}

	[CompilerGenerated]
	private sealed class F833A21E40764BD7
	{
		public DateTime DF966A4A04F64777;

		internal bool _1F17D29E157740C1(DateTime P_0)
		{
			return DF966A4A04F64777 - P_0 > BD239546035F4E07;
		}
	}

	private static readonly TimeSpan BD239546035F4E07;

	private static readonly TimeSpan _82A22333E0044655;

	private const string _8A7EB7E84A894325 = "A-Za-zА-Яа-яЁёІіЇїҐґ0-9";

	private const string _1D425F28356B434D = "[warn]";

	private Dictionary<string, List<AFEE455F5F9849CC>> B5A256AC23A84E6D;

	private HashSet<char> B150924831C3437D;

	private HashSet<string> _50D8F276F13C4F1F;

	private Regex? _11A9A7B79C0A4050;

	private List<Regex> D9748D91DDA9473C;

	public EE0FD11A7E47463C()
	{
		uint num = 1u;
		while (num != 0 && num == 1)
		{
			E2873669CEEA43CF((object)this);
			num = 0u;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _8C2712E8062140BB()
	{
		GC.KeepAlive(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _87F35AC9F3974279(A3116505AAB24996 P_0, CSteamID P_1, string P_2, string P_3, string P_4)
	{
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		F833A21E40764BD7 CS_0024_003C_003E8__locals3 = (F833A21E40764BD7)_86A86C5DD53242C6();
		CS_0024_003C_003E8__locals3.DF966A4A04F64777 = DateTime.UtcNow;
		List<DateTime> value2 = default;
		int count = default;
		List<AFEE455F5F9849CC> value = default;
		AFEE455F5F9849CC current = default;
		while (true)
		{
			int num = -1748420774;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-((-(-(-(num2 ^ (-((-1770027488 ^ (-1685929621 + 1222982358 + --1730783340)) * -1698738585) + (0x7CE7FE1B ^ -764962014) + unchecked(2135722597 * -300649951)))) - -(unchecked(-1828842859 * (-1775050909 - -639286680)) - ~338100175)) - ~(~109683491)) * 225071631))) % 8)
				{
				case 0u:
					break;
				case 1u:
					return;
				case 7u:
					value2.RemoveAll((DateTime dateTime) => CS_0024_003C_003E8__locals3.DF966A4A04F64777 - dateTime > BD239546035F4E07);
					value2.Add(CS_0024_003C_003E8__locals3.DF966A4A04F64777);
					num = -758622320;
					continue;
				case 3u:
					count = value2.Count;
					num = (int)(num3 * 1475252359) ^ -1889374494;
					continue;
				case 2u:
				{
					int num15;
					int num16;
					if (!B5A256AC23A84E6D.TryGetValue(P_3, out value))
					{
						num15 = -1551488164;
						num16 = num15;
					}
					else
					{
						num15 = 835479857;
						num16 = num15;
					}
					num = num15 ^ ((int)num3 * -1536159507);
					continue;
				}
				case 4u:
					value2 = new List<DateTime>();
					P_0.BEE1CD7F6E384F04[P_3] = value2;
					num = (int)(num3 * 1072230472) ^ -1750554084;
					continue;
				case 5u:
				{
					int num13;
					int num14;
					if (!P_0.BEE1CD7F6E384F04.TryGetValue(P_3, out value2))
					{
						num13 = 1722260498;
						num14 = num13;
					}
					else
					{
						num13 = -987777913;
						num14 = num13;
					}
					num = num13 ^ ((int)num3 * -669930649);
					continue;
				}
				default:
				{
					using List<AFEE455F5F9849CC>.Enumerator enumerator = value.GetEnumerator();
					while (true)
					{
						int num4;
						int num5;
						if (enumerator.MoveNext())
						{
							num4 = 1487994767;
							num5 = num4;
						}
						else
						{
							num4 = -663646248;
							num5 = num4;
						}
						while (true)
						{
							num2 = num4;
							switch ((num3 = (uint)(-((-(-(-(num2 ^ (-((-1770027488 ^ (-1685929621 + 1222982358 + --1730783340)) * -1698738585) + (0x7CE7FE1B ^ -764962014) + unchecked(2135722597 * -300649951)))) - -(unchecked(-1828842859 * (-1775050909 - -639286680)) - ~338100175)) - ~(~109683491)) * 225071631))) % 9)
							{
							case 2u:
								num4 = 1487994767;
								continue;
							default:
								return;
							case 4u:
							{
								int num9;
								int num10;
								if (count == current._9FDCC79813744F4A)
								{
									num9 = 562285901;
									num10 = num9;
								}
								else
								{
									num9 = -546307559;
									num10 = num9;
								}
								num4 = num9 ^ (int)(num3 * 258368942);
								continue;
							}
							case 7u:
								break;
							case 5u:
								AD7DD157F4674899(current._4DCAD2C3C0664B80, P_1, P_2, P_3, count, P_4);
								num4 = 430663035;
								continue;
							case 3u:
							{
								int num8;
								if (current.B0C3ADEBCC3941A6 <= _003CModule_003E.F84FA79ABE6944BB<int>(1398637845))
								{
									num4 = 430663035;
									num8 = num4;
								}
								else
								{
									num4 = 1184255109;
									num8 = num4;
								}
								continue;
							}
							case 8u:
								current = enumerator.Current;
								num4 = -691608481;
								continue;
							case 0u:
							{
								int num11;
								int num12;
								if ((count - current._9FDCC79813744F4A) % current.B0C3ADEBCC3941A6 == 0)
								{
									num11 = -16480653;
									num12 = num11;
								}
								else
								{
									num11 = 1524915995;
									num12 = num11;
								}
								num4 = num11 ^ ((int)num3 * -448092550);
								continue;
							}
							case 6u:
							{
								int num6;
								int num7;
								if (count >= current._9FDCC79813744F4A)
								{
									num6 = -1464429330;
									num7 = num6;
								}
								else
								{
									num6 = 1645998443;
									num7 = num6;
								}
								num4 = num6 ^ (int)(num3 * 1034622632);
								continue;
							}
							case 1u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AD7DD157F4674899(string P_0, CSteamID P_1, string P_2, string P_3, int P_4, string P_5)
	{
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		if (_67981124C6C542DE(P_0))
		{
			goto IL_000b;
		}
		goto IL_0187;
		IL_000b:
		int num = 924944936;
		goto IL_0010;
		IL_0010:
		SteamPlayer val = default;
		string text = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(((num2 + (0x2BC003F4 ^ ~(-(-1765872015 + (1086064244 - -(882644986 + -1292776259))))) + (-(0x394C968C ^ -123461652) + (-unchecked(1611340636 + 735552622) - -1502989019 - unchecked(-630200101 * -38963371))) * -960930509 + unchecked(-1410841371 - unchecked(~((-1931957438 ^ -1032410917) - (0x41FBC3E1 ^ 0x7E69A57E)) + unchecked(826598143 * unchecked(~2042304775 * 1286533505))))) ^ -129337324 ^ 0x2EC01FC0) - (-83314226 ^ -528454274) + ~1366256643)) % 8)
			{
			case 4u:
				break;
			case 1u:
				return;
			case 7u:
			{
				int num4;
				int num5;
				if (val != null)
				{
					num4 = 1240999311;
					num5 = num4;
				}
				else
				{
					num4 = 1700561330;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 1375359690);
				continue;
			}
			case 0u:
				_001B4F88D5274702(text);
				return;
			case 3u:
				goto IL_0187;
			case 2u:
				val = (SteamPlayer)_8B8A4CDD3F8D4FE9(P_1);
				num = 1024202778;
				continue;
			case 5u:
				return;
			default:
				_548FCA43EBF24894(_747F7417883E42FE((object)_67B21B351AB24EDF((object)text, E65CCFE7AD104C14((object)_003CModule_003E._58ECCB512F2A43AC<string>(-55169713)))), Color.yellow, (SteamPlayer)null, val, (EChatMode)_003CModule_003E._58ECCB512F2A43AC<int>(1659754234), (string)null, (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0);
				return;
			}
			break;
		}
		goto IL_000b;
		IL_0187:
		text = D4D6D7558C2546ED((object)D4D6D7558C2546ED((object)D4D6D7558C2546ED((object)D4D6D7558C2546ED((object)D4D6D7558C2546ED((object)P_0, _003CModule_003E._8B9C7B12B1AE4949<string>(1804948987), ((object)P_1/*cast due to constrained. prefix*/).ToString()), _003CModule_003E._8B9C7B12B1AE4949<string>(2067355359), P_2), _003CModule_003E._390073C602714496<string>(-984455667), P_4.ToString()), _003CModule_003E._8B9C7B12B1AE4949<string>(313481269), P_3), _003CModule_003E._58ECCB512F2A43AC<string>(-1735988149), P_5);
		int num6;
		if (FB75052DF45842A4((object)text, _003CModule_003E._8B9C7B12B1AE4949<string>(9589640)))
		{
			num = -301979035;
			num6 = num;
		}
		else
		{
			num = 540509379;
			num6 = num;
		}
		goto IL_0010;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void F9E4652CF76D4829(string P_0)
	{
		GC.KeepAlive(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool _3E2D77852D3848E1(string P_0)
	{
		HashSet<char> b150924831C3437D = B150924831C3437D;
		if (b150924831C3437D.Count == 0)
		{
			goto IL_0012;
		}
		goto IL_00f5;
		IL_0012:
		int num = 865023138;
		goto IL_0017;
		IL_0017:
		int num4 = default;
		char item = default;
		string text = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(-(((~(-(num2 * -1492869697)) - -unchecked(unchecked((0x141D2890 ^ 0x4815D97B) + (0x513EE038 ^ 0x13FECE8D)) - unchecked((896382598 - 2127830288) * -1488194085))) ^ (-639379126 + -unchecked(302826437 + 2094496523))) * 1969550973 * 237098177))) % 10)
			{
			case 9u:
				break;
			case 0u:
				num4 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
				num = -1615611122;
				continue;
			case 2u:
				item = E5B1F378A0214B2B((object)text, num4);
				num = -506855005;
				continue;
			case 4u:
			{
				int num5;
				int num6;
				if (b150924831C3437D.Contains(item))
				{
					num5 = -1585169228;
					num6 = num5;
				}
				else
				{
					num5 = 1124721213;
					num6 = num5;
				}
				num = num5 ^ ((int)num3 * -2062536807);
				continue;
			}
			case 8u:
				goto IL_00f5;
			case 3u:
				goto IL_0101;
			case 6u:
				return (byte)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019) != 0;
			case 1u:
				return (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0;
			case 5u:
				num4 += _003CModule_003E._58ECCB512F2A43AC<int>(1006217019);
				num = -1615611122;
				continue;
			default:
				return (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
			}
			break;
			IL_0101:
			int num7;
			if (num4 < _638FC64DA7A7497C((object)text))
			{
				num = -1805577983;
				num7 = num;
			}
			else
			{
				num = 1231656288;
				num7 = num;
			}
		}
		goto IL_0012;
		IL_00f5:
		text = P_0;
		num = -1029507401;
		goto IL_0017;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool _0DD5D3B055034ACB(string P_0)
	{
		Regex regex = _11A9A7B79C0A4050;
		List<Regex> d9748D91DDA9473C = default;
		string text2 = default;
		bool result = default;
		while (true)
		{
			int num = 1626332832;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-(-1617049503 + unchecked(-1880982817 - unchecked(-767652259 * -1967118099)) + (-unchecked(1226756519 + 1940166148) - -(-343865583))) - (-num2 ^ (-302991555 * (~1535490443 + (-unchecked(-693817429 * -572388345) - (0x11F733EE ^ --477329327)) * -1581774001)))) * 1466075067)) % 7)
				{
				case 0u:
					break;
				case 6u:
				{
					d9748D91DDA9473C = D9748D91DDA9473C;
					int num14;
					int num15;
					if (regex != null)
					{
						num14 = -802474802;
						num15 = num14;
					}
					else
					{
						num14 = -281131582;
						num15 = num14;
					}
					num = num14 ^ ((int)num3 * -293537626);
					continue;
				}
				case 2u:
				{
					text2 = _4D0815BDC9124675(P_0);
					int num13;
					if (_638FC64DA7A7497C((object)text2) != 0)
					{
						num = -694561642;
						num13 = num;
					}
					else
					{
						num = 1407826223;
						num13 = num;
					}
					continue;
				}
				case 1u:
					return (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
				case 5u:
					return (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0;
				case 4u:
				{
					int num11;
					int num12;
					if (d9748D91DDA9473C.Count != 0)
					{
						num11 = -2009115487;
						num12 = num11;
					}
					else
					{
						num11 = 1768816430;
						num12 = num11;
					}
					num = num11 ^ ((int)num3 * -316083249);
					continue;
				}
				default:
					{
						string text = _20EB8E3F2A754D66(text2);
						try
						{
							if (regex != null)
							{
								while (true)
								{
									int num4 = 326078888;
									while (true)
									{
										num2 = num4;
										switch ((num3 = (uint)((-(-1617049503 + unchecked(-1880982817 - unchecked(-767652259 * -1967118099)) + (-unchecked(1226756519 + 1940166148) - -(-343865583))) - (-num2 ^ (-302991555 * (~1535490443 + (-unchecked(-693817429 * -572388345) - (0x11F733EE ^ --477329327)) * -1581774001)))) * 1466075067)) % 4)
										{
										case 0u:
											break;
										case 3u:
										{
											int num5;
											int num6;
											if (!_30B0D52BA45149B6((object)regex, text))
											{
												num5 = 1337981411;
												num6 = num5;
											}
											else
											{
												num5 = 1621408940;
												num6 = num5;
											}
											num4 = num5 ^ ((int)num3 * -830606298);
											continue;
										}
										case 1u:
											result = (byte)_003CModule_003E._3F57E81A62734AC2<int>(1017304263) != 0;
											goto end_IL_0148;
										default:
											goto end_IL_014e;
										}
										break;
									}
									continue;
									end_IL_014e:
									break;
								}
							}
							using (List<Regex>.Enumerator enumerator = d9748D91DDA9473C.GetEnumerator())
							{
								while (true)
								{
									IL_02c0:
									int num7;
									int num8;
									if (enumerator.MoveNext())
									{
										num7 = 1283634346;
										num8 = num7;
									}
									else
									{
										num7 = 1718840023;
										num8 = num7;
									}
									while (true)
									{
										num2 = num7;
										switch ((num3 = (uint)((-(-1617049503 + unchecked(-1880982817 - unchecked(-767652259 * -1967118099)) + (-unchecked(1226756519 + 1940166148) - -(-343865583))) - (-num2 ^ (-302991555 * (~1535490443 + (-unchecked(-693817429 * -572388345) - (0x11F733EE ^ --477329327)) * -1581774001)))) * 1466075067)) % 6)
										{
										case 0u:
											num7 = 1283634346;
											continue;
										default:
											goto end_IL_0230;
										case 4u:
											break;
										case 3u:
											goto end_IL_0148;
										case 1u:
											result = (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0;
											num7 = -1534364980;
											continue;
										case 5u:
										{
											int num9;
											if (_30B0D52BA45149B6((object)enumerator.Current, text))
											{
												num7 = -399997058;
												num9 = num7;
											}
											else
											{
												num7 = -615328815;
												num9 = num7;
											}
											continue;
										}
										case 2u:
											goto end_IL_0230;
										}
										goto IL_02c0;
										continue;
										end_IL_0230:
										break;
									}
									break;
								}
							}
							goto IL_03f6;
							end_IL_0148:;
						}
						catch (RegexMatchTimeoutException)
						{
							while (true)
							{
								IL_0346:
								int num10 = -1175391843;
								while (true)
								{
									num2 = num10;
									switch ((num3 = (uint)((-(-1617049503 + unchecked(-1880982817 - unchecked(-767652259 * -1967118099)) + (-unchecked(1226756519 + 1940166148) - -(-343865583))) - (-num2 ^ (-302991555 * (~1535490443 + (-unchecked(-693817429 * -572388345) - (0x11F733EE ^ --477329327)) * -1581774001)))) * 1466075067)) % 3)
									{
									case 0u:
										break;
									case 2u:
										goto IL_03cf;
									default:
										goto end_IL_034b;
									}
									goto IL_0346;
									IL_03cf:
									CD928A4616984DEB(C179263454B44BF6._54DF173DA5E74DC3, _003CModule_003E.F84FA79ABE6944BB<string>(-1087896834), Array.Empty<object>());
									num10 = 1220739155;
									continue;
									end_IL_034b:
									break;
								}
								break;
							}
							goto IL_03f6;
						}
						return result;
					}
					IL_03f6:
					return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string _20EB8E3F2A754D66(string P_0)
	{
		HashSet<string> hashSet = _50D8F276F13C4F1F;
		if (hashSet.Count == 0)
		{
			goto IL_0012;
		}
		goto IL_015e;
		IL_0012:
		int num = -1223494407;
		goto IL_0017;
		IL_0017:
		int num2 = num;
		uint num3;
		switch ((num3 = (uint)(((-(1706957785 * ((-1021652749 * ((unchecked(1384430069 * 180086897) - -(0x54DFE8C ^ 0x5099D06E)) ^ 0x724426EA)) ^ -365771403) - num2 - ((0x1747FC6D ^ -1417495013) - -1210120609 * (0x6856372B ^ -(-(9585425 - 626928324))))) * 2013597457) ^ -349460049) * -1910250251 * 1113449975 + -1273880470)) % 4)
		{
		case 0u:
			break;
		case 2u:
			return P_0;
		case 3u:
			goto IL_015e;
		default:
			goto IL_016a;
		}
		goto IL_0012;
		IL_016a:
		char[] array = default;
		using (HashSet<string>.Enumerator enumerator = hashSet.GetEnumerator())
		{
			int num6 = default;
			string current = default;
			int num7 = default;
			while (true)
			{
				IL_02d1:
				int num4;
				int num5;
				if (enumerator.MoveNext())
				{
					num4 = -67387878;
					num5 = num4;
				}
				else
				{
					num4 = -2109374719;
					num5 = num4;
				}
				while (true)
				{
					num2 = num4;
					switch ((num3 = (uint)(((-(1706957785 * ((-1021652749 * ((unchecked(1384430069 * 180086897) - -(0x54DFE8C ^ 0x5099D06E)) ^ 0x724426EA)) ^ -365771403) - num2 - ((0x1747FC6D ^ -1417495013) - -1210120609 * (0x6856372B ^ -(-(9585425 - 626928324))))) * 2013597457) ^ -349460049) * -1910250251 * 1113449975 + -1273880470)) % 12)
					{
					case 2u:
						num4 = -67387878;
						continue;
					default:
						goto end_IL_017b;
					case 3u:
						break;
					case 1u:
						array = _569A4B29FCF54CBF((object)P_0);
						num4 = (int)(num3 * 782259328) ^ -1405082160;
						continue;
					case 8u:
						num6 = B24304D852214FA4((object)P_0, current, num6 + _638FC64DA7A7497C((object)current), (StringComparison)_003CModule_003E._390073C602714496<int>(1661075637));
						num4 = -1995762758;
						continue;
					case 0u:
						num6 = A37B3CA485FE4141((object)P_0, current, (StringComparison)_003CModule_003E._3F57E81A62734AC2<int>(-1354517604));
						num4 = -1995762758;
						continue;
					case 11u:
					{
						int num10;
						if (num6 != _003CModule_003E.F84FA79ABE6944BB<int>(1441711120))
						{
							num4 = 1305293840;
							num10 = num4;
						}
						else
						{
							num4 = 2123394834;
							num10 = num4;
						}
						continue;
					}
					case 5u:
						num7 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563);
						num4 = -1170443343;
						continue;
					case 10u:
					{
						int num9;
						if (num7 >= _638FC64DA7A7497C((object)current))
						{
							num4 = -757029321;
							num9 = num4;
						}
						else
						{
							num4 = 631167355;
							num9 = num4;
						}
						continue;
					}
					case 9u:
					{
						int num8;
						if (array == null)
						{
							num4 = -724619780;
							num8 = num4;
						}
						else
						{
							num4 = 993067856;
							num8 = num4;
						}
						continue;
					}
					case 7u:
						current = enumerator.Current;
						num4 = 1764093047;
						continue;
					case 4u:
						array[num6 + num7] = (char)_003CModule_003E._3F57E81A62734AC2<int>(-1560113592);
						num7 += _003CModule_003E.F84FA79ABE6944BB<int>(1741630884);
						num4 = -1170443343;
						continue;
					case 6u:
						goto end_IL_017b;
					}
					goto IL_02d1;
					continue;
					end_IL_017b:
					break;
				}
				break;
			}
		}
		if (array != null)
		{
			while (true)
			{
				num2 = -774832374;
				switch ((num3 = (uint)(((-(1706957785 * ((-1021652749 * ((unchecked(1384430069 * 180086897) - -(0x54DFE8C ^ 0x5099D06E)) ^ 0x724426EA)) ^ -365771403) - num2 - ((0x1747FC6D ^ -1417495013) - -1210120609 * (0x6856372B ^ -(-(9585425 - 626928324))))) * 2013597457) ^ -349460049) * -1910250251 * 1113449975 + -1273880470)) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return (string)AD0B6CF96DED454A(array);
				}
				break;
			}
		}
		return P_0;
		IL_015e:
		array = null;
		num = -1119693848;
		goto IL_0017;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static EE0FD11A7E47463C()
	{
		_75BB81D3BDEE425E._22ED7975D32246BC._1469CBB6811C4870((object)null, 0L, SeekOrigin.Begin);
		BD239546035F4E07 = default;
	}

	static void E2873669CEEA43CF(object P_0)
	{
		((EE0FD11A7E47463C)P_0)._8C2712E8062140BB();
	}

	static object _5A0DF3F8E6754265(object P_0, string P_1)
	{
		return ((IConfiguration)P_0).GetSection(P_1);
	}

	static IEnumerable<IConfigurationSection> _8A4C74B06C4245B5(object P_0)
	{
		return ((IConfiguration)P_0).GetChildren();
	}

	static bool F14D429ABD224FF1(IConfigurationSection P_0)
	{
		return ConfigurationExtensions.Exists(P_0);
	}

	static bool _67981124C6C542DE(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static string[] EC220A7F1E014A03(object P_0, char P_1, int P_2, StringSplitOptions P_3)
	{
		return ((string)P_0).Split(P_1, P_2, P_3);
	}

	static object _9A5EEE236CF44E0B()
	{
		return new AFEE455F5F9849CC();
	}

	static string _4BFEB6E286AC4926(object P_0)
	{
		return ((IConfigurationSection)P_0).Key;
	}

	static bool _93E12ED014884E0D(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	static void _616CD1AD73E84960(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static object _86A86C5DD53242C6()
	{
		return new F833A21E40764BD7();
	}

	static string D4D6D7558C2546ED(object P_0, string P_1, string P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	static bool FB75052DF45842A4(object P_0, string P_1)
	{
		return ((string)P_0).StartsWith(P_1);
	}

	static void _001B4F88D5274702(string P_0)
	{
		_64A4BBC5E4CE4EE1.E6DC166DE03C47D7(P_0);
	}

	static object _8B8A4CDD3F8D4FE9(CSteamID P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return PlayerTool.getSteamPlayer(P_0);
	}

	static int E65CCFE7AD104C14(object P_0)
	{
		return ((string)P_0).Length;
	}

	static string _67B21B351AB24EDF(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	static string _747F7417883E42FE(object P_0)
	{
		return ((string)P_0).Trim();
	}

	static void _548FCA43EBF24894(string P_0, Color P_1, SteamPlayer P_2, SteamPlayer P_3, EChatMode P_4, string P_5, bool P_6)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		ChatManager.serverSendMessage(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
	}

	static object AD408834FD8F4A49(string P_0, string P_1)
	{
		return new ArgumentException(P_0, P_1);
	}

	static object A9D08C86418B4833()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return (object)new JsonSerializerOptions();
	}

	static void AD2AA6E917CB4A07(object P_0, bool P_1)
	{
		((JsonSerializerOptions)P_0).PropertyNameCaseInsensitive = P_1;
	}

	static object C7B42723E9134A5C(string P_0)
	{
		return new InvalidOperationException(P_0);
	}

	static string _9075338F51454002(object P_0)
	{
		return ((FAF70C516C494AEF)P_0)._9E19A7E7BC164341;
	}

	static object BC5DA3EE53CF4564(object P_0)
	{
		return ((FAF70C516C494AEF)P_0)._915B09CDC84D4F1E;
	}

	static string[] _9E41287A4D9D4E49(object P_0)
	{
		return ((B31394A5015E4A0D)P_0)._87C4CD27B4B94447;
	}

	static string _4D0815BDC9124675(string P_0)
	{
		return _52E00C0CB6ED438D._57F3F3B600774394(P_0);
	}

	static int _638FC64DA7A7497C(object P_0)
	{
		return ((string)P_0).Length;
	}

	static string[] _7B7FDCE000F94F0C(object P_0)
	{
		return ((B31394A5015E4A0D)P_0)._7A368F857787437D;
	}

	static string _73E7A089F7AF42FA(string P_0)
	{
		return Regex.Escape(P_0);
	}

	static string _51BE4AC7CA7F4EFF(string P_0, IEnumerable<string> P_1)
	{
		return string.Join(P_0, P_1);
	}

	static string B5D03339FE214B23(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static object _54723B550E254869(string P_0, RegexOptions P_1, TimeSpan P_2)
	{
		return new Regex(P_0, P_1, P_2);
	}

	static string[] B87E7A961F7D47D6(object P_0)
	{
		return ((B31394A5015E4A0D)P_0).E27D8701AB414EDA;
	}

	static string _4A7855E7651E43DF(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	static string _5FC50652F816413C(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static void CD928A4616984DEB(ILogger P_0, string P_1, object[] P_2)
	{
		LoggerExtensions.LogWarning(P_0, P_1, P_2);
	}

	static char E5B1F378A0214B2B(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	static bool _30B0D52BA45149B6(object P_0, string P_1)
	{
		return ((Regex)P_0).IsMatch(P_1);
	}

	static int A37B3CA485FE4141(object P_0, string P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf(P_1, P_2);
	}

	static char[] _569A4B29FCF54CBF(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	static int B24304D852214FA4(object P_0, string P_1, int P_2, StringComparison P_3)
	{
		return ((string)P_0).IndexOf(P_1, P_2, P_3);
	}

	static object AD0B6CF96DED454A(char[] P_0)
	{
		return new string(P_0);
	}
}
