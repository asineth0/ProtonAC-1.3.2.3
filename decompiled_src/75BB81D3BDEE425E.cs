using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal class _75BB81D3BDEE425E : global::_94E3D906D3E34B5F<DC150B2EA63F481E>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _22ED7975D32246BC : IAsyncStateMachine
	{
		public int _809DAE3A956D4D85;

		public AsyncTaskMethodBuilder D29590D272EE483A;

		public _02C54685DE0E4B81 _13F347224FC94CAD;

		public DC150B2EA63F481E _2A777B358FA040BA;

		private A24F37B85A5745EF F33DE21993C84163;

		private TaskAwaiter B742B5BD3DBA48BC;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _809DAE3A956D4D85;
			try
			{
				if (num != 0)
				{
					goto IL_000d;
				}
				goto IL_0289;
				IL_000d:
				int num2 = -1976561401;
				goto IL_0012;
				IL_0012:
				TaskAwaiter awaiter = default;
				long? num10 = default;
				byte[] value = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(~(-(~(~1731335406 + (~(0x647F2CE9 ^ -486931687) + -(-530714610 ^ -1911011011))) - ((num3 + -(-2010091703 * -((0x37DB6FFF ^ -1411944958) - -(~unchecked(-1679869326 * -2044398737))))) ^ 0x1BB12F68) - ~(-(-2035560872 ^ -727074253))) ^ 0x186FF443) - -1446766734)) % 13)
					{
					case 12u:
						break;
					case 7u:
						awaiter = CD8A1E074FC54FF1(F68AB9D8A188470C(_2D03FCB1B17241DF(_1FB48E0E2D394F5D((object)F33DE21993C84163))));
						num2 = 1068001194;
						continue;
					case 0u:
					{
						int num7;
						int num8;
						if (!awaiter.IsCompleted)
						{
							num7 = -11007731;
							num8 = num7;
						}
						else
						{
							num7 = 646195618;
							num8 = num7;
						}
						num2 = num7 ^ (int)(num4 * 618685661);
						continue;
					}
					case 4u:
						goto end_IL_0007;
					case 3u:
					{
						int num5;
						int num6;
						if (_0A4A6CDF1BE34A89((object)_13F347224FC94CAD.FEF1EDB6312C4632).TryGetValue(_6584EAE91FED4771((object)_2A777B358FA040BA), out F33DE21993C84163))
						{
							num5 = 2128941079;
							num6 = num5;
						}
						else
						{
							num5 = -728634372;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num4 * 199933787);
						continue;
					}
					case 8u:
						goto IL_01a5;
					case 9u:
						B742B5BD3DBA48BC = default;
						num = (_809DAE3A956D4D85 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
						num2 = 579564552;
						continue;
					case 5u:
						D29590D272EE483A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = (int)((num4 * 469151061) ^ 0x4E6FF0A3);
						continue;
					case 11u:
					{
						object obj = C8DE01D5113645E3(E8FE6BC5373E4B58());
						if (obj != null)
						{
							string text = _003CModule_003E._390073C602714496<string>(1900646814);
							object[] array = new object[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)];
							array[_003CModule_003E._390073C602714496<int>(2131963235)] = _6584EAE91FED4771((object)_2A777B358FA040BA);
							_5C47C6530F104603((ILogger)obj, text, array);
							num2 = -31729172;
							continue;
						}
						goto end_IL_0007;
					}
					case 1u:
						num = (_809DAE3A956D4D85 = _003CModule_003E._390073C602714496<int>(2131963235));
						B742B5BD3DBA48BC = awaiter;
						num2 = -419030560;
						continue;
					case 10u:
						goto IL_0289;
					case 6u:
						return;
					default:
						goto IL_02b2;
					}
					break;
					IL_02b2:
					awaiter.GetResult();
					try
					{
						_7566988E55304ED1(_1FB48E0E2D394F5D((object)F33DE21993C84163))[F6CE680A78A7481D((object)_2A777B358FA040BA)] = _31D1B3F73DA9486F((object)_2A777B358FA040BA);
						if (_4587AC01BA6C40A9((object)_2A777B358FA040BA))
						{
							goto IL_02f4;
						}
						goto IL_04e8;
						IL_02f4:
						int num9 = 1049111870;
						goto IL_02f9;
						IL_02f9:
						while (true)
						{
							num3 = num9;
							switch ((num4 = (uint)(~(-(~(~1731335406 + (~(0x647F2CE9 ^ -486931687) + -(-530714610 ^ -1911011011))) - ((num3 + -(-2010091703 * -((0x37DB6FFF ^ -1411944958) - -(~unchecked(-1679869326 * -2044398737))))) ^ 0x1BB12F68) - ~(-(-2035560872 ^ -727074253))) ^ 0x186FF443) - -1446766734)) % 11)
							{
							case 5u:
								break;
							default:
								goto end_IL_02b9;
							case 7u:
								_8A9B98F0A8704281(_1FB48E0E2D394F5D((object)F33DE21993C84163)).TrySetResult((byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0);
								num9 = 1761806461;
								continue;
							case 6u:
								_7566988E55304ED1(_1FB48E0E2D394F5D((object)F33DE21993C84163)).Remove(_4A0E0117E14E4AFB(_1FB48E0E2D394F5D((object)F33DE21993C84163)));
								num9 = (int)((num4 * 1686075667) ^ 0x4532AF20);
								continue;
							case 8u:
							{
								long num14 = _4A0E0117E14E4AFB(_1FB48E0E2D394F5D((object)F33DE21993C84163));
								num10 = C6A783F459D649D5(_1FB48E0E2D394F5D((object)F33DE21993C84163));
								int num15;
								int num16;
								if (num14 <= num10.Value)
								{
									num15 = -1289910446;
									num16 = num15;
								}
								else
								{
									num15 = -1059396067;
									num16 = num15;
								}
								num9 = num15 ^ (int)(num4 * 1785305533);
								continue;
							}
							case 0u:
							{
								int num12;
								int num13;
								if (!num10.HasValue)
								{
									num12 = -1319549644;
									num13 = num12;
								}
								else
								{
									num12 = -652027206;
									num13 = num12;
								}
								num9 = num12 ^ ((int)num4 * -797542395);
								continue;
							}
							case 3u:
							{
								object obj2 = _1FB48E0E2D394F5D((object)F33DE21993C84163);
								long num11 = _4A0E0117E14E4AFB(obj2);
								F65449A3BB324BBD(obj2, num11 + _003CModule_003E._390073C602714496<int>(-250964212));
								num9 = 48517484;
								continue;
							}
							case 1u:
								goto IL_04e8;
							case 2u:
								num10 = C6A783F459D649D5(_1FB48E0E2D394F5D((object)F33DE21993C84163));
								num9 = 1046786541;
								continue;
							case 10u:
								BC0B052EA75A457A(_4F23147808A64944(_1FB48E0E2D394F5D((object)F33DE21993C84163)), value, _003CModule_003E._390073C602714496<int>(2131963235), value.Length);
								num9 = 1437398648;
								continue;
							case 4u:
								_74926375EF4F4CD9(_1FB48E0E2D394F5D((object)F33DE21993C84163), (long?)F6CE680A78A7481D((object)_2A777B358FA040BA));
								num9 = ((int)num4 * -1885401990) ^ -1136439008;
								continue;
							case 9u:
								goto end_IL_02b9;
							}
							break;
						}
						goto IL_02f4;
						IL_04e8:
						int num17;
						if (!_7566988E55304ED1(_1FB48E0E2D394F5D((object)F33DE21993C84163)).TryGetValue(_4A0E0117E14E4AFB(_1FB48E0E2D394F5D((object)F33DE21993C84163)), out value))
						{
							num9 = 506019222;
							num17 = num9;
						}
						else
						{
							num9 = 1955413687;
							num17 = num9;
						}
						goto IL_02f9;
						end_IL_02b9:;
					}
					finally
					{
						if (num < _003CModule_003E.F84FA79ABE6944BB<int>(1398637845))
						{
							while (true)
							{
								IL_05ba:
								int num18 = 920104107;
								while (true)
								{
									num3 = num18;
									switch ((num4 = (uint)(~(-(~(~1731335406 + (~(0x647F2CE9 ^ -486931687) + -(-530714610 ^ -1911011011))) - ((num3 + -(-2010091703 * -((0x37DB6FFF ^ -1411944958) - -(~unchecked(-1679869326 * -2044398737))))) ^ 0x1BB12F68) - ~(-(-2035560872 ^ -727074253))) ^ 0x186FF443) - -1446766734)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_05bf;
									case 2u:
										goto IL_0687;
									case 1u:
										goto end_IL_05bf;
									}
									goto IL_05ba;
									IL_0687:
									_9500FA099653429F(_2D03FCB1B17241DF(_1FB48E0E2D394F5D((object)F33DE21993C84163)));
									num18 = ((int)num4 * -760501178) ^ -758180891;
									continue;
									end_IL_05bf:
									break;
								}
								break;
							}
						}
					}
					if (!_4587AC01BA6C40A9((object)_2A777B358FA040BA))
					{
						goto IL_06c1;
					}
					goto IL_0812;
					IL_0812:
					_1469CBB6811C4870(_4F23147808A64944(_1FB48E0E2D394F5D((object)F33DE21993C84163)), (long)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042), (SeekOrigin)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
					int num19 = 1595202905;
					goto IL_06c6;
					IL_01a5:
					if (num != _003CModule_003E._8B9C7B12B1AE4949<int>(350091668))
					{
						num2 = 1168713564;
						continue;
					}
					goto IL_0869;
					IL_06c1:
					num19 = -357881834;
					goto IL_06c6;
					IL_0869:
					awaiter = B742B5BD3DBA48BC;
					B742B5BD3DBA48BC = default;
					num19 = 1268184147;
					goto IL_06c6;
					IL_06c6:
					while (true)
					{
						num3 = num19;
						switch ((num4 = (uint)(~(-(~(~1731335406 + (~(0x647F2CE9 ^ -486931687) + -(-530714610 ^ -1911011011))) - ((num3 + -(-2010091703 * -((0x37DB6FFF ^ -1411944958) - -(~unchecked(-1679869326 * -2044398737))))) ^ 0x1BB12F68) - ~(-(-2035560872 ^ -727074253))) ^ 0x186FF443) - -1446766734)) % 12)
						{
						case 6u:
							break;
						case 8u:
						{
							int num20;
							int num21;
							if (!awaiter.IsCompleted)
							{
								num20 = 1443728382;
								num21 = num20;
							}
							else
							{
								num20 = 809471131;
								num21 = num20;
							}
							num19 = num20 ^ (int)(num4 * 1745418151);
							continue;
						}
						case 2u:
							num = (_809DAE3A956D4D85 = _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
							num19 = 1193502419;
							continue;
						case 10u:
							goto end_IL_0007;
						case 0u:
							goto IL_0812;
						case 11u:
							num = (_809DAE3A956D4D85 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num19 = 1545088675;
							continue;
						case 1u:
							goto IL_0869;
						case 3u:
							awaiter.GetResult();
							num19 = 684656396;
							continue;
						case 9u:
							awaiter = CD8A1E074FC54FF1(_1C46159866AF4C8A(_13F347224FC94CAD, _6584EAE91FED4771((object)_2A777B358FA040BA), F33DE21993C84163));
							num19 = (int)(num4 * 400134426) ^ -612300798;
							continue;
						case 5u:
							goto IL_08cc;
						case 7u:
							B742B5BD3DBA48BC = awaiter;
							D29590D272EE483A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						default:
						{
							_0A4A6CDF1BE34A89((object)_13F347224FC94CAD.FEF1EDB6312C4632).TryRemove(_6584EAE91FED4771((object)_2A777B358FA040BA), out var _);
							goto end_IL_0007;
						}
						}
						break;
						IL_08cc:
						int num22;
						if ((int)_95D359E5341A4936((object)F33DE21993C84163) != _003CModule_003E._390073C602714496<int>(1661075637))
						{
							num19 = 684656396;
							num22 = num19;
						}
						else
						{
							num19 = 1097722169;
							num22 = num19;
						}
					}
					goto IL_06c1;
				}
				goto IL_000d;
				IL_0289:
				awaiter = B742B5BD3DBA48BC;
				num2 = 629232524;
				goto IL_0012;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_809DAE3A956D4D85 = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
				F33DE21993C84163 = null;
				D29590D272EE483A.SetException(exception);
				return;
			}
			_809DAE3A956D4D85 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
			while (true)
			{
				int num23 = -1985958076;
				while (true)
				{
					int num3 = num23;
					uint num4;
					switch ((num4 = (uint)(~(-(~(~1731335406 + (~(0x647F2CE9 ^ -486931687) + -(-530714610 ^ -1911011011))) - ((num3 + -(-2010091703 * -((0x37DB6FFF ^ -1411944958) - -(~unchecked(-1679869326 * -2044398737))))) ^ 0x1BB12F68) - ~(-(-2035560872 ^ -727074253))) ^ 0x186FF443) - -1446766734)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0a57;
					case 2u:
						return;
					}
					break;
					IL_0a57:
					F33DE21993C84163 = null;
					D29590D272EE483A.SetResult();
					num23 = ((int)num4 * -128806525) ^ -1286694924;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			D29590D272EE483A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static ConcurrentDictionary<string, A24F37B85A5745EF> _0A4A6CDF1BE34A89(object P_0)
		{
			return ((_793AD9726F0B488F)P_0)._2FC10FC8DA964445;
		}

		static string _6584EAE91FED4771(object P_0)
		{
			return ((DC150B2EA63F481E)P_0)._76BC4C7C7ECD423D;
		}

		static object E8FE6BC5373E4B58()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static object C8DE01D5113645E3(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
		}

		static void _5C47C6530F104603(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static object _1FB48E0E2D394F5D(object P_0)
		{
			return ((A24F37B85A5745EF)P_0).E5416C55D0A342A9;
		}

		static object _2D03FCB1B17241DF(object P_0)
		{
			return ((_92E045C44FAC46F3)P_0)._309BAE722CA94271;
		}

		static object F68AB9D8A188470C(object P_0)
		{
			return ((SemaphoreSlim)P_0).WaitAsync();
		}

		static TaskAwaiter CD8A1E074FC54FF1(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static SortedDictionary<long, byte[]> _7566988E55304ED1(object P_0)
		{
			return ((_92E045C44FAC46F3)P_0)._61E39332C26842D0;
		}

		static long F6CE680A78A7481D(object P_0)
		{
			return ((DC150B2EA63F481E)P_0)._8A384E8366C941D5;
		}

		static byte[] _31D1B3F73DA9486F(object P_0)
		{
			return ((DC150B2EA63F481E)P_0)._37CEE15431BC410D;
		}

		static bool _4587AC01BA6C40A9(object P_0)
		{
			return ((DC150B2EA63F481E)P_0)._75B11046E5734D0E;
		}

		static void _74926375EF4F4CD9(object P_0, long? P_1)
		{
			((_92E045C44FAC46F3)P_0)._1A55046179A347E1 = P_1;
		}

		static long _4A0E0117E14E4AFB(object P_0)
		{
			return ((_92E045C44FAC46F3)P_0)._292FBC325CEE4318;
		}

		static object _4F23147808A64944(object P_0)
		{
			return ((_92E045C44FAC46F3)P_0)._626F75DE2391436C;
		}

		static void BC0B052EA75A457A(object P_0, byte[] P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write(P_1, P_2, P_3);
		}

		static void F65449A3BB324BBD(object P_0, long P_1)
		{
			((_92E045C44FAC46F3)P_0)._292FBC325CEE4318 = P_1;
		}

		static long? C6A783F459D649D5(object P_0)
		{
			return ((_92E045C44FAC46F3)P_0)._1A55046179A347E1;
		}

		static TaskCompletionSource<bool> _8A9B98F0A8704281(object P_0)
		{
			return ((_92E045C44FAC46F3)P_0)._7A4FE2B7C2A945FA;
		}

		static int _9500FA099653429F(object P_0)
		{
			return ((SemaphoreSlim)P_0).Release();
		}

		static long _1469CBB6811C4870(object P_0, long P_1, SeekOrigin P_2)
		{
			return ((Stream)P_0).Seek(P_1, P_2);
		}

		static B79532442FF34B1B _95D359E5341A4936(object P_0)
		{
			return ((A24F37B85A5745EF)P_0)._195B5211EE8240A8;
		}

		static object _1C46159866AF4C8A(_02C54685DE0E4B81 P_0, string P_1, A24F37B85A5745EF P_2)
		{
			return DD80A734C57C4EAA._9B5654B6E21D4F53(P_0, P_1, P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_22ED7975D32246BC))]
	public Task _4DCF3D926A4D4EE3(_02C54685DE0E4B81 P_0, DC150B2EA63F481E P_1, CancellationToken P_2 = default(CancellationToken))
	{
		_22ED7975D32246BC stateMachine = default;
		stateMachine.D29590D272EE483A = AsyncTaskMethodBuilder.Create();
		while (true)
		{
			int num = 728992905;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-(~num2) ^ ((-32748332 ^ -1690989490) + -228873225 * -310361301)) + -(~(-2131352579 ^ 0x645CBA51)))) % 4)
				{
				case 0u:
					break;
				case 2u:
					stateMachine._13F347224FC94CAD = P_0;
					stateMachine._2A777B358FA040BA = P_1;
					stateMachine._809DAE3A956D4D85 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817);
					num = -134779156;
					continue;
				case 3u:
					stateMachine.D29590D272EE483A.Start(ref stateMachine);
					num = ((int)num3 * -981566382) ^ 0x6D8FFD4C;
					continue;
				default:
					return stateMachine.D29590D272EE483A.Task;
				}
				break;
			}
		}
	}

	Task global::_94E3D906D3E34B5F<DC150B2EA63F481E>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, DC150B2EA63F481E P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in 4DCF3D926A4D4EE3
		return this._4DCF3D926A4D4EE3(P_0, P_1, P_2);
	}
}
