using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal sealed class _49992BF9672941B5 : global::_94E3D906D3E34B5F<DD4BCD8A5BC24128>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct C6BE28F943B44492 : IAsyncStateMachine
	{
		public int _03451EB0FD994E93;

		public AsyncTaskMethodBuilder _7B63517D1A5D40E5;

		public DD4BCD8A5BC24128 C511988B35B5452E;

		public CancellationToken _527DD970D153473F;

		public _02C54685DE0E4B81 EDA32DD6FBBD455E;

		public _49992BF9672941B5 _6B30829BE2CE4865;

		private MemoryStream _521C9AC9678E4B3B;

		private ZipArchive FBB3D47C56AB4798;

		private string[] _549479B8219B492C;

		private int _6B190AE1B4634CB7;

		private FileStream D6A0EDC11827448E;

		private Stream _13CAEF06484E40F0;

		private TaskAwaiter EB123786CB964BA2;

		private TaskAwaiter<bool> D6FD8AA35FC54DFB;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _03451EB0FD994E93;
			_49992BF9672941B5 obj = _6B30829BE2CE4865;
			try
			{
				string[] array = default;
				if ((uint)num > (uint)_003CModule_003E._390073C602714496<int>(-250964212))
				{
					while (true)
					{
						int num2 = -1948270836;
						while (true)
						{
							int num3 = num2;
							uint num4;
							switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 3)
							{
							case 0u:
								break;
							case 1u:
								array = A4B10CE932904DF2(FFA2A488F1DA4542(D6C68620F652489B()), _5D994B9A8E0B4807((object)C511988B35B5452E));
								num2 = (int)((num4 * 2136433327) ^ 0x488CFFF9);
								continue;
							default:
								goto end_IL_0020;
							}
							break;
						}
						continue;
						end_IL_0020:
						break;
					}
				}
				try
				{
					if ((uint)num > (uint)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668))
					{
						while (true)
						{
							int num5 = 1186778412;
							while (true)
							{
								int num3 = num5;
								uint num4;
								switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 3)
								{
								case 2u:
									break;
								case 1u:
									_521C9AC9678E4B3B = (MemoryStream)C29C09D538A74A01();
									num5 = ((int)num4 * -1240664893) ^ -634224432;
									continue;
								default:
									goto end_IL_00cd;
								}
								break;
							}
							continue;
							end_IL_00cd:
							break;
						}
					}
					try
					{
						if ((uint)num > (uint)_003CModule_003E._390073C602714496<int>(-250964212))
						{
							while (true)
							{
								int num6 = -196844876;
								while (true)
								{
									int num3 = num6;
									uint num4;
									switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 3)
									{
									case 0u:
										break;
									case 1u:
										FBB3D47C56AB4798 = (ZipArchive)_030E86369AB4436E((object)_521C9AC9678E4B3B, (ZipArchiveMode)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019), (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0);
										num6 = 884377692;
										continue;
									default:
										goto end_IL_016a;
									}
									break;
								}
								continue;
								end_IL_016a:
								break;
							}
						}
						try
						{
							if (num != 0)
							{
								goto IL_0210;
							}
							goto IL_034e;
							IL_0210:
							int num7 = 1483001608;
							goto IL_0215;
							IL_0215:
							while (true)
							{
								int num3 = num7;
								uint num4;
								switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 6)
								{
								case 2u:
									break;
								case 4u:
									goto IL_02a3;
								case 1u:
									goto IL_030e;
								case 5u:
									_549479B8219B492C = array;
									_6B190AE1B4634CB7 = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042);
									num7 = 454619475;
									continue;
								default:
									goto IL_034e;
								case 0u:
									goto IL_07b1;
								}
								break;
								IL_030e:
								if (num != _003CModule_003E._3F57E81A62734AC2<int>(1017304263))
								{
									num7 = -1724570892;
									continue;
								}
								goto IL_08a1;
							}
							goto IL_0210;
							IL_07b1:
							if (_6B190AE1B4634CB7 < _549479B8219B492C.Length)
							{
								goto IL_02a3;
							}
							int num8 = 1841279588;
							goto IL_072a;
							IL_08a1:
							TaskAwaiter<bool> awaiter = D6FD8AA35FC54DFB;
							D6FD8AA35FC54DFB = default;
							num8 = 558752604;
							goto IL_072a;
							IL_02a3:
							string text = _549479B8219B492C[_6B190AE1B4634CB7];
							string text2 = _3BC8C2BEB5124D05(text);
							ZipArchiveEntry zipArchiveEntry = (ZipArchiveEntry)B6893B8080354FE6((object)FBB3D47C56AB4798, text2, (CompressionLevel)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042));
							D6A0EDC11827448E = (FileStream)_4F291F36B0504269(text, (FileMode)_003CModule_003E.F84FA79ABE6944BB<int>(-1420849552), (FileAccess)_003CModule_003E._3F57E81A62734AC2<int>(1017304263), (FileShare)_003CModule_003E.F84FA79ABE6944BB<int>(-1420849552));
							num7 = 1863128052;
							goto IL_0215;
							IL_034e:
							try
							{
								if (num != 0)
								{
									while (true)
									{
										int num9 = -1422376860;
										while (true)
										{
											int num3 = num9;
											uint num4;
											switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 3)
											{
											case 0u:
												break;
											case 2u:
												_13CAEF06484E40F0 = (Stream)ADC930F9AF544C51((object)zipArchiveEntry);
												num9 = ((int)num4 * -481665191) ^ -101015070;
												continue;
											default:
												goto end_IL_0354;
											}
											break;
										}
										continue;
										end_IL_0354:
										break;
									}
								}
								try
								{
									if (num != 0)
									{
										goto IL_03e7;
									}
									goto IL_0525;
									IL_03e7:
									int num10 = -1343806609;
									goto IL_03ec;
									IL_03ec:
									TaskAwaiter awaiter2 = default;
									while (true)
									{
										int num3 = num10;
										uint num4;
										switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 9)
										{
										case 3u:
											break;
										case 4u:
											return;
										case 2u:
										{
											int num11;
											int num12;
											if (awaiter2.IsCompleted)
											{
												num11 = -1957329138;
												num12 = num11;
											}
											else
											{
												num11 = 2085895949;
												num12 = num11;
											}
											num10 = num11 ^ (int)(num4 * 2021977138);
											continue;
										}
										case 6u:
											num = (_03451EB0FD994E93 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
											num10 = -303453986;
											continue;
										case 1u:
											awaiter2 = _0BB3EDE189024B5B(_9B68D3EA3EF24492((object)D6A0EDC11827448E, (object)_13CAEF06484E40F0, _527DD970D153473F));
											num10 = ((int)num4 * -1482000783) ^ -1403176449;
											continue;
										case 0u:
											EB123786CB964BA2 = awaiter2;
											_7B63517D1A5D40E5.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
											num10 = (int)(num4 * 1252270444) ^ -726385993;
											continue;
										case 7u:
											goto IL_0525;
										case 5u:
											num = (_03451EB0FD994E93 = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
											num10 = -1746848780;
											continue;
										default:
											awaiter2.GetResult();
											goto end_IL_03e1;
										}
										break;
									}
									goto IL_03e7;
									IL_0525:
									awaiter2 = EB123786CB964BA2;
									EB123786CB964BA2 = default;
									num10 = -552850014;
									goto IL_03ec;
									end_IL_03e1:;
								}
								finally
								{
									if (num < _003CModule_003E._3F57E81A62734AC2<int>(-1803194042))
									{
										while (true)
										{
											IL_057f:
											int num13 = 767802345;
											while (true)
											{
												int num3 = num13;
												uint num4;
												switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 4)
												{
												case 3u:
													break;
												default:
													goto end_IL_0584;
												case 2u:
												{
													int num14;
													int num15;
													if (_13CAEF06484E40F0 == null)
													{
														num14 = -1613368269;
														num15 = num14;
													}
													else
													{
														num14 = -921281106;
														num15 = num14;
													}
													num13 = num14 ^ (int)(num4 * 1008256182);
													continue;
												}
												case 1u:
													_76D9C8681EFF4614((object)_13CAEF06484E40F0);
													num13 = (int)((num4 * 578977619) ^ 0x77D9BAF0);
													continue;
												case 0u:
													goto end_IL_0584;
												}
												goto IL_057f;
												continue;
												end_IL_0584:
												break;
											}
											break;
										}
									}
								}
							}
							finally
							{
								if (num < _003CModule_003E._390073C602714496<int>(2131963235))
								{
									while (true)
									{
										IL_064a:
										int num16 = -1856538622;
										while (true)
										{
											int num3 = num16;
											uint num4;
											switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 4)
											{
											case 2u:
												break;
											default:
												goto end_IL_064f;
											case 1u:
											{
												int num17;
												int num18;
												if (D6A0EDC11827448E == null)
												{
													num17 = 696681257;
													num18 = num17;
												}
												else
												{
													num17 = -697129470;
													num18 = num17;
												}
												num16 = num17 ^ (int)(num4 * 1963001458);
												continue;
											}
											case 3u:
												_76D9C8681EFF4614((object)D6A0EDC11827448E);
												num16 = ((int)num4 * -1112198203) ^ -260657400;
												continue;
											case 0u:
												goto end_IL_064f;
											}
											goto IL_064a;
											continue;
											end_IL_064f:
											break;
										}
										break;
									}
								}
							}
							D6A0EDC11827448E = null;
							_13CAEF06484E40F0 = null;
							_6B190AE1B4634CB7 += _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
							goto IL_0725;
							IL_072a:
							while (true)
							{
								int num3 = num8;
								uint num4;
								switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 10)
								{
								case 8u:
									break;
								default:
									goto end_IL_020a;
								case 6u:
									goto IL_07b1;
								case 2u:
									_7B63517D1A5D40E5.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								case 3u:
									awaiter.GetResult();
									num8 = -1012198119;
									continue;
								case 5u:
									num = (_03451EB0FD994E93 = _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
									D6FD8AA35FC54DFB = awaiter;
									num8 = -2019661673;
									continue;
								case 0u:
									goto IL_082c;
								case 7u:
									num = (_03451EB0FD994E93 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
									num8 = -782803066;
									continue;
								case 1u:
									goto IL_08a1;
								case 9u:
									_549479B8219B492C = null;
									C050B0BC76BD4C22((object)_521C9AC9678E4B3B, (long)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845), (SeekOrigin)_003CModule_003E._390073C602714496<int>(2131963235));
									num8 = -4533593;
									continue;
								case 4u:
									goto end_IL_020a;
								}
								break;
								IL_082c:
								awaiter = AB03AFDCDC514752((object)EDA32DD6FBBD455E, (object)_521C9AC9678E4B3B, (B79532442FF34B1B)_003CModule_003E.F84FA79ABE6944BB<int>(1650979182), _0BB65EFC8A094A24((object)_521C9AC9678E4B3B), F598E4EAFFFB4C81((object)C511988B35B5452E)).GetAwaiter();
								int num19;
								if (!awaiter.IsCompleted)
								{
									num8 = 2100626274;
									num19 = num8;
								}
								else
								{
									num8 = -782803066;
									num19 = num8;
								}
							}
							goto IL_0725;
							IL_0725:
							num8 = 227376275;
							goto IL_072a;
							end_IL_020a:;
						}
						finally
						{
							if (num < _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
							{
								while (true)
								{
									IL_090c:
									int num20 = 139325452;
									while (true)
									{
										int num3 = num20;
										uint num4;
										switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 4)
										{
										case 0u:
											break;
										default:
											goto end_IL_0911;
										case 3u:
										{
											int num21;
											int num22;
											if (FBB3D47C56AB4798 == null)
											{
												num21 = 196681382;
												num22 = num21;
											}
											else
											{
												num21 = 704549517;
												num22 = num21;
											}
											num20 = num21 ^ ((int)num4 * -793701703);
											continue;
										}
										case 1u:
											_76D9C8681EFF4614((object)FBB3D47C56AB4798);
											num20 = ((int)num4 * -1866344258) ^ -1309455045;
											continue;
										case 2u:
											goto end_IL_0911;
										}
										goto IL_090c;
										continue;
										end_IL_0911:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						if (num < _003CModule_003E._3F57E81A62734AC2<int>(-1803194042))
						{
							while (true)
							{
								IL_09d7:
								int num23 = 897844982;
								while (true)
								{
									int num3 = num23;
									uint num4;
									switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 4)
									{
									case 3u:
										break;
									default:
										goto end_IL_09dc;
									case 1u:
									{
										int num24;
										int num25;
										if (_521C9AC9678E4B3B != null)
										{
											num24 = -1692196570;
											num25 = num24;
										}
										else
										{
											num24 = 1564313104;
											num25 = num24;
										}
										num23 = num24 ^ ((int)num4 * -1002807545);
										continue;
									}
									case 2u:
										_76D9C8681EFF4614((object)_521C9AC9678E4B3B);
										num23 = (int)(num4 * 1027155181) ^ -1658137451;
										continue;
									case 0u:
										goto end_IL_09dc;
									}
									goto IL_09d7;
									continue;
									end_IL_09dc:
									break;
								}
								break;
							}
						}
					}
					_521C9AC9678E4B3B = null;
					while (true)
					{
						IL_0a92:
						int num26 = 1567899662;
						while (true)
						{
							int num3 = num26;
							uint num4;
							switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_0a97;
							case 2u:
								goto IL_0afe;
							case 1u:
								goto end_IL_0a97;
							}
							goto IL_0a92;
							IL_0afe:
							FBB3D47C56AB4798 = null;
							num26 = ((int)num4 * -1951224367) ^ -2064627034;
							continue;
							end_IL_0a97:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					while (true)
					{
						IL_0b1c:
						int num27 = -1990362863;
						while (true)
						{
							int num3 = num27;
							uint num4;
							ILogger? aD27E750B6F84B;
							switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_0b21;
							case 1u:
								aD27E750B6F84B = obj.AD27E750B6F84B54;
								if (aD27E750B6F84B != null)
								{
									goto IL_0b94;
								}
								goto end_IL_0b21;
							case 0u:
								goto end_IL_0b21;
							}
							goto IL_0b1c;
							IL_0b94:
							_47E4CE56B2FC4854(aD27E750B6F84B, ex, _003CModule_003E._8B9C7B12B1AE4949<string>(-111378971), Array.Empty<object>());
							num27 = -1964430700;
							continue;
							end_IL_0b21:
							break;
						}
						break;
					}
				}
			}
			catch (Exception exception)
			{
				_03451EB0FD994E93 = _003CModule_003E._390073C602714496<int>(818201983);
				_7B63517D1A5D40E5.SetException(exception);
				return;
			}
			_03451EB0FD994E93 = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
			while (true)
			{
				int num28 = 336725662;
				while (true)
				{
					int num3 = num28;
					uint num4;
					switch ((num4 = (uint)((((~(-num3) ^ -1668369908 ^ -582197859) * 452536307) ^ -369467327) * -1628375227)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0c5e;
					case 2u:
						return;
					}
					break;
					IL_0c5e:
					_7B63517D1A5D40E5.SetResult();
					num28 = (int)((num4 * 1857420189) ^ 0x713C1A63);
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
			_7B63517D1A5D40E5.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object D6C68620F652489B()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static string FFA2A488F1DA4542(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0).E58B6ED9182C4C76;
		}

		static string _5D994B9A8E0B4807(object P_0)
		{
			return ((DD4BCD8A5BC24128)P_0).FA6CD948C0A549E3;
		}

		static string[] A4B10CE932904DF2(string P_0, string P_1)
		{
			return Directory.GetFiles(P_0, P_1);
		}

		static object C29C09D538A74A01()
		{
			return new MemoryStream();
		}

		static object _030E86369AB4436E(object P_0, ZipArchiveMode P_1, bool P_2)
		{
			return new ZipArchive((Stream)P_0, P_1, P_2);
		}

		static string _3BC8C2BEB5124D05(string P_0)
		{
			return Path.GetFileName(P_0);
		}

		static object B6893B8080354FE6(object P_0, string P_1, CompressionLevel P_2)
		{
			return ((ZipArchive)P_0).CreateEntry(P_1, P_2);
		}

		static object _4F291F36B0504269(string P_0, FileMode P_1, FileAccess P_2, FileShare P_3)
		{
			return new FileStream(P_0, P_1, P_2, P_3);
		}

		static object ADC930F9AF544C51(object P_0)
		{
			return ((ZipArchiveEntry)P_0).Open();
		}

		static object _9B68D3EA3EF24492(object P_0, object P_1, CancellationToken P_2)
		{
			return ((Stream)P_0).CopyToAsync((Stream)P_1, P_2);
		}

		static TaskAwaiter _0BB3EDE189024B5B(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static void _76D9C8681EFF4614(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		static long C050B0BC76BD4C22(object P_0, long P_1, SeekOrigin P_2)
		{
			return ((Stream)P_0).Seek(P_1, P_2);
		}

		static long _0BB65EFC8A094A24(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		static string F598E4EAFFFB4C81(object P_0)
		{
			return ((DD4BCD8A5BC24128)P_0)._0A743B1B41F74FBE;
		}

		static Task<bool> AB03AFDCDC514752(object P_0, object P_1, B79532442FF34B1B P_2, long P_3, string P_4)
		{
			return ((_02C54685DE0E4B81)P_0)._3787CDA13EC74733((Stream)P_1, P_2, P_3, P_4);
		}

		static void _47E4CE56B2FC4854(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	private readonly ILogger? AD27E750B6F84B54;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(C6BE28F943B44492))]
	public Task _1B629DD026924E06(_02C54685DE0E4B81 P_0, DD4BCD8A5BC24128 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		C6BE28F943B44492 stateMachine = default;
		stateMachine._7B63517D1A5D40E5 = AsyncTaskMethodBuilder.Create();
		stateMachine._6B30829BE2CE4865 = this;
		stateMachine.EDA32DD6FBBD455E = P_0;
		stateMachine.C511988B35B5452E = P_1;
		stateMachine._527DD970D153473F = P_2;
		stateMachine._03451EB0FD994E93 = _003CModule_003E._390073C602714496<int>(-736908096);
		stateMachine._7B63517D1A5D40E5.Start(ref stateMachine);
		return stateMachine._7B63517D1A5D40E5.Task;
	}

	Task global::_94E3D906D3E34B5F<DD4BCD8A5BC24128>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, DD4BCD8A5BC24128 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in 1B629DD026924E06
		return this._1B629DD026924E06(P_0, P_1, P_2);
	}

	public _49992BF9672941B5()
	{
		F44EA4B48650401C();
		FB514321CDDE420A((object)null);
	}

	static object F44EA4B48650401C()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static object FB514321CDDE420A(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
	}
}
