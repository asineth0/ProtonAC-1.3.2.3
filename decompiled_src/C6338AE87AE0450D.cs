using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

internal class C6338AE87AE0450D : _760EF57D5259421C
{
	[CompilerGenerated]
	private sealed class A0B24288046A4FEC
	{
		public DateTime _55850173C2B848A8;

		internal bool D6BFECE496394396((string Text, DateTime Timestamp) P_0)
		{
			return (_55850173C2B848A8 - P_0.Timestamp).TotalSeconds > (double)_15A88F541E1B49CF;
		}
	}

	private readonly EE0FD11A7E47463C? D97790B0F26F4ACA;

	private static bool _4C65BE27323F4599;

	private static double _286196A3B5684655;

	private static int _15A88F541E1B49CF;

	private static int _0B44B1B2A3404BC5;

	private static int _05D5664E76244480;

	private static bool _3A7C95BABC9148A0;

	private static int C704F2C8E76A4840;

	private static bool C65663B163944990;

	private static bool A414845FAE4F4DED;

	private static bool _705474890A7948C6;

	private static EChatMode[] _4798EF83F57445A6;

	public virtual void _935D65F066DD447D()
	{
		Chatted val = null;
		_17F69241B813462E((Delegate)null, (Delegate)(object)val);
		throw new Exception();
	}

	public virtual void _5C33E514B5884A81()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		ChatManager.onChatted = (Chatted)_3D0F511C1E1C4423((Delegate)(object)ChatManager.onChatted, (Delegate)new Chatted(_98378761F5B54063));
		F9C86FD4A9DC444F();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _7F2B64E9831F4FB0()
	{
		GC.KeepAlive(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static EChatMode[] _3A17FD50073842B9(string? P_0)
	{
		_1BBB024F15ED40DD(P_0);
		C5A761BDE26E43D1((object)0);
		_1E74BC84FE044EED((ILogger)null, (string)null, (object[])null);
		_59A3183E57394007((object)null);
		_23E9D56762C94CC1((object)P_0, '\0', StringSplitOptions.None);
		throw new Exception();
	}

	private void _98378761F5B54063(SteamPlayer P_0, EChatMode P_1, ref Color P_2, ref bool P_3, string P_4, ref bool P_5)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (D97790B0F26F4ACA == null || AE629168DBEF4312(P_4) || BC9AD808552A4D08((object)P_4, 0) == '/' || BC9AD808552A4D08((object)P_4, 0) == '@' || Array.IndexOf(_4798EF83F57445A6, P_1) < 0)
		{
			return;
		}
		Player val = (Player)B6C8080E919344C5((object)P_0);
		if (AC00C02507B14A09((Object)(object)val, (Object)null))
		{
			return;
		}
		A3116505AAB24996 a3116505AAB = (A3116505AAB24996)E6845075398F4A64(val);
		if (a3116505AAB == null)
		{
			return;
		}
		CSteamID val2 = _96547B844B6B4F15(_0B1A08F9D25F4CC5((object)P_0));
		if (!_5386B530AC4E4FD1((object)a3116505AAB, (object)_760EF57D5259421C._8DC4187752784460, (object)_760EF57D5259421C._1D28939F0C774697, val2))
		{
			string text = BCB450D1FF1B4A99(a3116505AAB, P_4);
			if (text != null)
			{
				P_5 = false;
				_82BDF54293E9479C((object)D97790B0F26F4ACA, (object)a3116505AAB, val2, _419AFC0A9FED4466(_0B1A08F9D25F4CC5((object)P_0)), text, P_4);
			}
		}
	}

	private string? BCB450D1FF1B4A99(A3116505AAB24996 P_0, string P_1)
	{
		if (_3A7C95BABC9148A0 && C5A761BDE26E43D1((object)P_1) > C704F2C8E76A4840)
		{
			return "MessageLength";
		}
		if (C65663B163944990 && E81DECEE5FFE4C79(P_1))
		{
			return "AntiLinks";
		}
		if (A414845FAE4F4DED && B9BFDF2514954BCB((object)D97790B0F26F4ACA, P_1))
		{
			return "AntiBadWords";
		}
		if (_705474890A7948C6 && A8268B2DDAD04251((object)D97790B0F26F4ACA, P_1))
		{
			return "CharWhitelist";
		}
		if (_4C65BE27323F4599 && _93166A08F2AF4BFD(P_0, P_1))
		{
			return "StringSimilarity";
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _93166A08F2AF4BFD(A3116505AAB24996 P_0, string P_1)
	{
		A0B24288046A4FEC CS_0024_003C_003E8__locals3 = (A0B24288046A4FEC)_5A8678C8B75D420A();
		CS_0024_003C_003E8__locals3._55850173C2B848A8 = DateTime.UtcNow;
		List<(string, DateTime)> b6FB1868C64B4AE = P_0.B6FB1868C64B4AE7;
		b6FB1868C64B4AE.RemoveAll(((string Text, DateTime Timestamp) tuple) => (CS_0024_003C_003E8__locals3._55850173C2B848A8 - tuple.Timestamp).TotalSeconds > (double)_15A88F541E1B49CF);
		while (true)
		{
			int num = 391916812;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(1416387305 * (-2028163687 * --408532575) - --548300693 - ((-(~(-unchecked(1006230125 * (-1547405360 ^ -1657361046)))) ^ (unchecked(-1006420359 * (unchecked(-2037729464 + -296214706) - 1332578992)) - (~(69493296 + 789644959) + unchecked(unchecked(1083192343 * -1789169511) - ~-855215317)) + ~(~(-2010393781 + 447705494 - unchecked(-2002754252 * 1631270351))) + -(-(~1141681284)))) - num2 - (-441932830 - -714716204)) - unchecked(692477419 * (~(1007028566 + -262984005) - ~(-1261410317 ^ 0x251751B))))) - unchecked(1926926510 - -899519183))) % 4)
				{
				case 3u:
					break;
				case 2u:
				{
					int num9;
					int num10;
					if (b6FB1868C64B4AE.Count > _0B44B1B2A3404BC5)
					{
						num9 = -1435856549;
						num10 = num9;
					}
					else
					{
						num9 = -1446353102;
						num10 = num9;
					}
					num = num9 ^ ((int)num3 * -1534040070);
					continue;
				}
				case 1u:
					b6FB1868C64B4AE.RemoveRange(_003CModule_003E._58ECCB512F2A43AC<int>(352679804), b6FB1868C64B4AE.Count - _0B44B1B2A3404BC5);
					num = -1371366098;
					continue;
				default:
				{
					int num4 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563);
					using (List<(string, DateTime)>.Enumerator enumerator = b6FB1868C64B4AE.GetEnumerator())
					{
						while (true)
						{
							IL_02ff:
							int num5;
							int num6;
							if (!enumerator.MoveNext())
							{
								num5 = 473055296;
								num6 = num5;
							}
							else
							{
								num5 = -1373401998;
								num6 = num5;
							}
							while (true)
							{
								num2 = num5;
								switch ((num3 = (uint)(-(-(1416387305 * (-2028163687 * --408532575) - --548300693 - ((-(~(-unchecked(1006230125 * (-1547405360 ^ -1657361046)))) ^ (unchecked(-1006420359 * (unchecked(-2037729464 + -296214706) - 1332578992)) - (~(69493296 + 789644959) + unchecked(unchecked(1083192343 * -1789169511) - ~-855215317)) + ~(~(-2010393781 + 447705494 - unchecked(-2002754252 * 1631270351))) + -(-(~1141681284)))) - num2 - (-441932830 - -714716204)) - unchecked(692477419 * (~(1007028566 + -262984005) - ~(-1261410317 ^ 0x251751B))))) - unchecked(1926926510 - -899519183))) % 6)
								{
								case 5u:
									num5 = -1373401998;
									continue;
								default:
									goto end_IL_0191;
								case 2u:
								{
									int num8;
									if (!_421CF4FB73E24AFA(enumerator.Current.Item1, P_1, _286196A3B5684655))
									{
										num5 = -1426657826;
										num8 = num5;
									}
									else
									{
										num5 = -1458496319;
										num8 = num5;
									}
									continue;
								}
								case 3u:
								{
									int num7;
									if ((num4 += _003CModule_003E._3F57E81A62734AC2<int>(1017304263)) >= _05D5664E76244480)
									{
										num5 = 142989677;
										num7 = num5;
									}
									else
									{
										num5 = -1426657826;
										num7 = num5;
									}
									continue;
								}
								case 1u:
									return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0;
								case 0u:
									break;
								case 4u:
									goto end_IL_0191;
								}
								goto IL_02ff;
								continue;
								end_IL_0191:
								break;
							}
							break;
						}
					}
					b6FB1868C64B4AE.Add((P_1, CS_0024_003C_003E8__locals3._55850173C2B848A8));
					return (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
				}
				}
				break;
			}
		}
	}

	public C6338AE87AE0450D()
	{
		_631D551E2DA64E7D._7831985F69F94FB8((object)null);
		D97790B0F26F4ACA = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static C6338AE87AE0450D()
	{
		uint num = 0u;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0u:
				num = 3u;
				break;
			case 3u:
				A414845FAE4F4DED = false;
				num = 6u;
				break;
			case 6u:
				C65663B163944990 = false;
				num = 3u;
				break;
			}
		}
	}

	static object _17F69241B813462E(Delegate P_0, Delegate P_1)
	{
		return Delegate.Combine(P_0, P_1);
	}

	void _83E52F905667495C()
	{
		base.A599C828530B4E69();
	}

	static object _3D0F511C1E1C4423(Delegate P_0, Delegate P_1)
	{
		return Delegate.Remove(P_0, P_1);
	}

	void F9C86FD4A9DC444F()
	{
		base.C4CA2ECFAD654E77();
	}

	static double _160D4C2B11FD4200(double P_0, double P_1, double P_2)
	{
		return Math.Clamp(P_0, P_1, P_2);
	}

	static int _0EDDE79E80A044BD(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	static int A3CF7DAEF2C9436B(int P_0, int P_1, int P_2)
	{
		return Math.Clamp(P_0, P_1, P_2);
	}

	static bool _1BBB024F15ED40DD(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static string[] _23E9D56762C94CC1(object P_0, char P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split(P_1, P_2);
	}

	static string _59A3183E57394007(object P_0)
	{
		return ((string)P_0).Trim();
	}

	static int C5A761BDE26E43D1(object P_0)
	{
		return ((string)P_0).Length;
	}

	static string _73E1027E90FF42D2(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static void _1E74BC84FE044EED(ILogger P_0, string P_1, object[] P_2)
	{
		LoggerExtensions.LogWarning(P_0, P_1, P_2);
	}

	static bool AE629168DBEF4312(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static char BC9AD808552A4D08(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	static object B6C8080E919344C5(object P_0)
	{
		return ((SteamPlayer)P_0).player;
	}

	static bool AC00C02507B14A09(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static object E6845075398F4A64(Player P_0)
	{
		return A3116505AAB24996._69C6AFA769194D6F(P_0);
	}

	static object _0B1A08F9D25F4CC5(object P_0)
	{
		return ((SteamPlayer)P_0).playerID;
	}

	static CSteamID _96547B844B6B4F15(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((SteamPlayerID)P_0).steamID;
	}

	static bool _5386B530AC4E4FD1(object P_0, object P_1, object P_2, CSteamID P_3)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return ((A3116505AAB24996)P_0).A98460F771B0446B((_4C6B03DD3A6441ED)P_1, (IConfiguration)P_2, P_3);
	}

	static string _419AFC0A9FED4466(object P_0)
	{
		return ((SteamPlayerID)P_0).playerName;
	}

	static void _82BDF54293E9479C(object P_0, object P_1, CSteamID P_2, string P_3, string P_4, string P_5)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((EE0FD11A7E47463C)P_0)._87F35AC9F3974279((A3116505AAB24996)P_1, P_2, P_3, P_4, P_5);
	}

	static bool E81DECEE5FFE4C79(string P_0)
	{
		return _52E00C0CB6ED438D._86EA9DA592ED421C(P_0);
	}

	static bool B9BFDF2514954BCB(object P_0, string P_1)
	{
		return ((EE0FD11A7E47463C)P_0)._0DD5D3B055034ACB(P_1);
	}

	static bool A8268B2DDAD04251(object P_0, string P_1)
	{
		return ((EE0FD11A7E47463C)P_0)._3E2D77852D3848E1(P_1);
	}

	static object _5A8678C8B75D420A()
	{
		return new A0B24288046A4FEC();
	}

	static bool _421CF4FB73E24AFA(string P_0, string P_1, double P_2)
	{
		return _52E00C0CB6ED438D._49D568CDF3784C4C(P_0, P_1, P_2);
	}
}
