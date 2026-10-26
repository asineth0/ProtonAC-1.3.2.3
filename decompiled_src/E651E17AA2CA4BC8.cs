using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

public class E651E17AA2CA4BC8 : C179263454B44BF6
{
	public struct C84D19F98EAA497F(SteamPlayerID P_0, ECheckCategory P_1, ECheckType P_2, EFlagLevel P_3, string P_4)
	{
		public SteamPlayerID A94B00EF444A4363 = P_0;

		public ECheckCategory _664A9756528C46FB = P_1;

		public ECheckType C6CB24124EA94C86 = P_2;

		public EFlagLevel DAC7A80B62CA45B5 = P_3;

		public string _6C0F36D636E344A2 = P_4;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class B199BB1D204541ED
	{
		public static readonly B199BB1D204541ED _003C_003E9 = (B199BB1D204541ED)_4F7612E4F0E5412E();

		public static Func<_0447F941905C4653, _0447F941905C4653> _003C_003E9__20_1;

		public static Func<_57DE83A6944B4063, long> _003C_003E9__35_0;

		internal _0447F941905C4653 _669A05EAD0B048BC(_0447F941905C4653 P_0)
		{
			return (_0447F941905C4653)_54B081F580B247ED((object)P_0);
		}

		internal long B224D2BD3CF848D2(_57DE83A6944B4063 P_0)
		{
			return _0C99CCE541034D1B((object)P_0);
		}

		static object _4F7612E4F0E5412E()
		{
			return new B199BB1D204541ED();
		}

		static object _54B081F580B247ED(object P_0)
		{
			return ((_0447F941905C4653)P_0)._878C7278A049438F();
		}

		static long _0C99CCE541034D1B(object P_0)
		{
			return ((_57DE83A6944B4063)P_0).CCC125B916614E35;
		}
	}

	[CompilerGenerated]
	private sealed class _113C547E3E7142C1
	{
		[StructLayout(LayoutKind.Auto)]
		private struct EEE742FC0CF449C0 : IAsyncStateMachine
		{
			public int _84D6E87F8C5A4575;

			public AsyncTaskMethodBuilder C1847D8215D94467;

			public _113C547E3E7142C1 _64F46CA2D9A9460B;

			private TaskAwaiter D894637AD8C44550;

			private Awaiter D667B9318A6E4411;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				//IL_0249: Unknown result type (might be due to invalid IL or missing references)
				//IL_024a: Unknown result type (might be due to invalid IL or missing references)
				//IL_032c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0331: Unknown result type (might be due to invalid IL or missing references)
				//IL_0297: Unknown result type (might be due to invalid IL or missing references)
				//IL_029c: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_013b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0140: Unknown result type (might be due to invalid IL or missing references)
				int num = _84D6E87F8C5A4575;
				_113C547E3E7142C1 obj = _64F46CA2D9A9460B;
				try
				{
					if (num != 0)
					{
						goto IL_0014;
					}
					goto IL_01cf;
					IL_0014:
					int num2 = -1475706647;
					goto IL_0019;
					IL_0019:
					SwitchToMainThreadAwaitable val = default;
					CancellationToken cancellationToken = default;
					TaskAwaiter awaiter2 = default;
					Awaiter awaiter = default;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(-(-(-(((-(-(~unchecked(-2016858999 + -1080545100))) + -(~unchecked((416279110 - (-302392835 + -1219777123)) * 1554481447))) ^ ((-282124601 * (unchecked(1518537997 * (1690816974 + -1673744230)) - unchecked(unchecked(1990624379 * 406475894) * 1843215685) + (-(-627058682 - -1250354707) + ~unchecked(-1126898614 - 1328273518)))) ^ (691643433 * --1661196573 + (-1344805905 ^ 0x1978C501)))) - num3))))) % 18)
						{
						case 3u:
							break;
						case 11u:
							goto IL_0116;
						case 10u:
							val = UniTask.SwitchToMainThread(cancellationToken);
							num2 = ((int)num4 * -2097129911) ^ 0x45685C29;
							continue;
						case 9u:
							num = (_84D6E87F8C5A4575 = _003CModule_003E._390073C602714496<int>(2131963235));
							D894637AD8C44550 = awaiter2;
							num2 = 1891684402;
							continue;
						case 8u:
							awaiter2.GetResult();
							num2 = 1840280924;
							continue;
						case 13u:
							num = (_84D6E87F8C5A4575 = _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
							num2 = -1867203832;
							continue;
						case 16u:
							C1847D8215D94467.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						case 17u:
							goto IL_01cf;
						case 12u:
							return;
						case 14u:
						{
							int num7;
							int num8;
							if (!awaiter.IsCompleted)
							{
								num7 = 1262569971;
								num8 = num7;
							}
							else
							{
								num7 = -1875913025;
								num8 = num7;
							}
							num2 = num7 ^ (int)(num4 * 1983173013);
							continue;
						}
						case 6u:
							num = (_84D6E87F8C5A4575 = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num2 = 2004656012;
							continue;
						case 0u:
							D667B9318A6E4411 = awaiter;
							C1847D8215D94467.AwaitUnsafeOnCompleted<Awaiter, EEE742FC0CF449C0>(ref awaiter, ref this);
							num2 = (int)((num4 * 966485675) ^ 0x139E0AB2);
							continue;
						case 5u:
						{
							int num5;
							int num6;
							if (awaiter2.IsCompleted)
							{
								num5 = -875941679;
								num6 = num5;
							}
							else
							{
								num5 = 1559058582;
								num6 = num5;
							}
							num2 = num5 ^ ((int)num4 * -531930447);
							continue;
						}
						case 7u:
							awaiter = D667B9318A6E4411;
							D667B9318A6E4411 = default;
							num = (_84D6E87F8C5A4575 = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num2 = -1138166107;
							continue;
						case 4u:
							awaiter2 = _8670F25235474230(EB12C41D859F4070(TimeSpan.FromSeconds(_97A83AD13472491E(_003CModule_003E.F84FA79ABE6944BB<int>(1650979182), _003CModule_003E.F84FA79ABE6944BB<int>(-243036841))), _1C8E155FBDB448A3((object)obj._4F2A4A2B5A524EAC.C8D0E9D0F9154ABD)));
							num2 = -1868415623;
							continue;
						case 2u:
							cancellationToken = default;
							num2 = ((int)num4 * -1423437416) ^ 0x326F28E4;
							continue;
						case 1u:
							awaiter = val.GetAwaiter();
							num2 = ((int)num4 * -1465289424) ^ -1096273970;
							continue;
						default:
							awaiter.GetResult();
							C2AF6DB5067D4E07(obj.F7BEB86308454E76);
							goto end_IL_000e;
						}
						break;
						IL_0116:
						int num9;
						if (num != _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
						{
							num2 = -706389102;
							num9 = num2;
						}
						else
						{
							num2 = -1073524029;
							num9 = num2;
						}
					}
					goto IL_0014;
					IL_01cf:
					awaiter2 = D894637AD8C44550;
					D894637AD8C44550 = default;
					num2 = -969338590;
					goto IL_0019;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					_84D6E87F8C5A4575 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
					while (true)
					{
						int num10 = -1394771738;
						while (true)
						{
							int num3 = num10;
							uint num4;
							switch ((num4 = (uint)(-(-(-(((-(-(~unchecked(-2016858999 + -1080545100))) + -(~unchecked((416279110 - (-302392835 + -1219777123)) * 1554481447))) ^ ((-282124601 * (unchecked(1518537997 * (1690816974 + -1673744230)) - unchecked(unchecked(1990624379 * 406475894) * 1843215685) + (-(-627058682 - -1250354707) + ~unchecked(-1126898614 - 1328273518)))) ^ (691643433 * --1661196573 + (-1344805905 ^ 0x1978C501)))) - num3))))) % 3)
							{
							case 0u:
								break;
							default:
								return;
							case 2u:
								goto IL_0432;
							case 1u:
								return;
							}
							break;
							IL_0432:
							C1847D8215D94467.SetException(exception);
							num10 = (int)(num4 * 359586373) ^ -743364970;
						}
					}
				}
				_84D6E87F8C5A4575 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
				C1847D8215D94467.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				C1847D8215D94467.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static int _97A83AD13472491E(int P_0, int P_1)
			{
				return Random.Range(P_0, P_1);
			}

			static CancellationToken _1C8E155FBDB448A3(object P_0)
			{
				return ((CancellationTokenSource)P_0).Token;
			}

			static object EB12C41D859F4070(TimeSpan P_0, CancellationToken P_1)
			{
				return Task.Delay(P_0, P_1);
			}

			static TaskAwaiter _8670F25235474230(object P_0)
			{
				return ((Task)P_0).GetAwaiter();
			}

			static void C2AF6DB5067D4E07(string P_0)
			{
				_64A4BBC5E4CE4EE1.E6DC166DE03C47D7(P_0);
			}
		}

		public E651E17AA2CA4BC8 _4F2A4A2B5A524EAC;

		public string F7BEB86308454E76;

		public CSteamID _0384B25C56404CA1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(EEE742FC0CF449C0))]
		internal Task A526D61B58364E4A()
		{
			EEE742FC0CF449C0 stateMachine = default;
			stateMachine.C1847D8215D94467 = AsyncTaskMethodBuilder.Create();
			stateMachine._64F46CA2D9A9460B = this;
			stateMachine._84D6E87F8C5A4575 = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
			stateMachine.C1847D8215D94467.Start(ref stateMachine);
			return stateMachine.C1847D8215D94467.Task;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _44BB773DA3A54CE6(Task P_0)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			_4F2A4A2B5A524EAC._37AD32AB2C8A4F8F.Remove(_0384B25C56404CA1);
			while (true)
			{
				int num = 1978476971;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~((~num2 + (-(-(-(unchecked(212878595 * 591398309) - (-1263642888 + 2023586745)))) + -1619037054)) ^ 0x64E83486) + -801585244)) % 5)
					{
					case 4u:
						break;
					default:
						return;
					case 2u:
						E99233C7A0704294(C179263454B44BF6._54DF173DA5E74DC3, (Exception)_5C10906946F44113((object)P_0), B95A9F7E9BDC4442(_003CModule_003E._3F57E81A62734AC2<string>(1429874209), F7BEB86308454E76), Array.Empty<object>());
						num = -536814143;
						continue;
					case 0u:
					{
						object obj = _5C10906946F44113((object)P_0);
						int num6;
						if (!(((obj != null) ? EA176019C2A24B73(obj) : null) is OperationCanceledException))
						{
							num = 2011287624;
							num6 = num;
						}
						else
						{
							num = -536814143;
							num6 = num;
						}
						continue;
					}
					case 1u:
					{
						int num4;
						int num5;
						if (DAEB7CD3A96843CB((object)P_0))
						{
							num4 = -1221224649;
							num5 = num4;
						}
						else
						{
							num4 = -859158100;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 461937865);
						continue;
					}
					case 3u:
						return;
					}
					break;
				}
			}
		}

		static bool DAEB7CD3A96843CB(object P_0)
		{
			return ((Task)P_0).IsFaulted;
		}

		static object _5C10906946F44113(object P_0)
		{
			return ((Task)P_0).Exception;
		}

		static object EA176019C2A24B73(object P_0)
		{
			return ((Exception)P_0).GetBaseException();
		}

		static string B95A9F7E9BDC4442(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static void E99233C7A0704294(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	[CompilerGenerated]
	private sealed class _2916CA89ED784421
	{
		public ECheckType DBAB473878C84349;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _17C3BAC2D543433A(_57DE83A6944B4063 P_0)
		{
			if (A72ABEF8199F411B((object)P_0) == DBAB473878C84349)
			{
				while (true)
				{
					int num = -110540180;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-(~num2) + ((0x1F8DE5BA ^ 0x370259D5) - 102991228 + unchecked(-1451303661 * 831499765) - -(~-1588095241) * -1009595253) * -17992233) * -1992831995 * 458515941 + unchecked(~906629430 - ~-1813596424))) % 4)
						{
						case 2u:
							break;
						case 1u:
						{
							int num4;
							int num5;
							if (_4A7F806A51B44199((object)P_0) == EFlagLevel.Shadow)
							{
								num4 = -93513453;
								num5 = num4;
							}
							else
							{
								num4 = 473000682;
								num5 = num4;
							}
							num = num4 ^ ((int)num3 * -490884780);
							continue;
						}
						case 3u:
							return ((_4A7F806A51B44199((object)P_0) == (EFlagLevel)_003CModule_003E._8B9C7B12B1AE4949<int>(1083331464)) ? 1 : 0) == _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
						default:
							goto end_IL_0011;
						}
						break;
					}
					continue;
					end_IL_0011:
					break;
				}
			}
			return (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
		}

		static ECheckType A72ABEF8199F411B(object P_0)
		{
			return ((_57DE83A6944B4063)P_0)._0BF1E0A59047451B;
		}

		static EFlagLevel _4A7F806A51B44199(object P_0)
		{
			return ((_57DE83A6944B4063)P_0).CFCEBCA7D5D243BB;
		}
	}

	[CompilerGenerated]
	private sealed class FAB38C0F2B6F4311
	{
		public ECheckType _6623045666DC4AFA;

		internal bool _2BB149958A484D1B(_0447F941905C4653 P_0)
		{
			return _3A00259073824DED((object)P_0) == _6623045666DC4AFA;
		}

		static ECheckType _3A00259073824DED(object P_0)
		{
			return ((_0447F941905C4653)P_0)._2B86A443CB024E20;
		}
	}

	[CompilerGenerated]
	private sealed class _7497D9F457FE469E
	{
		[StructLayout(LayoutKind.Auto)]
		private struct C0F33B48397C4DE5 : IAsyncStateMachine
		{
			public int _4EECB1A078D847A7;

			public AsyncTaskMethodBuilder _63400D810FA34AAA;

			public _7497D9F457FE469E _97791D36F9154A0A;

			private SteamPlayer DE96D1FFAC1C4526;

			private string C92F1C2F90C242C8;

			private (byte[] data, string format, Guid transactionId)? _7FB93942F18D4191;

			private TaskAwaiter<(byte[] data, string format, Guid transactionId)?> B97EBC28BD564A8B;

			private TaskAwaiter<bool> DE290A7D356F4F42;

			private TaskAwaiter FD497D95107D48B4;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				//IL_0389: Unknown result type (might be due to invalid IL or missing references)
				//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0468: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				int num = _4EECB1A078D847A7;
				_7497D9F457FE469E obj = _97791D36F9154A0A;
				try
				{
					Exception ex = default;
					_03550CE5B4D54D24 b8B36C5813AC;
					int num11;
					_003C_003Ef__AnonymousType7<string, string, ulong, int, string, string, string, string> anon;
					ulong steamID;
					Guid guid;
					byte[] array;
					TaskAwaiter<bool> awaiter2 = default;
					int num12;
					int num13;
					TaskAwaiter awaiter3 = default;
					switch (num)
					{
					default:
						while (true)
						{
							int num2 = 972615946;
							while (true)
							{
								int num3 = num2;
								uint num4;
								switch ((num4 = (uint)(-(-(((0x6606DA6D ^ -1846655484) + 2004762514 + -1009073186) * -924197367 * 412990813 * 2033442269 - num3)))) % 6)
								{
								case 5u:
									break;
								case 2u:
									C92F1C2F90C242C8 = _310A7B5760FC431E((object)_4EB0DBCE7BC748B4((object)_4EB0DBCE7BC748B4((object)obj.BAC6841A32394DA4, _003CModule_003E._390073C602714496<string>(-994642608), _003CModule_003E._58ECCB512F2A43AC<string>(692318299)), _003CModule_003E._3F57E81A62734AC2<string>(2006990324), _003CModule_003E._390073C602714496<string>(-485078612)));
									_7FB93942F18D4191 = null;
									num2 = 1914927389;
									continue;
								case 4u:
									goto end_IL_0020;
								case 1u:
								{
									DE96D1FFAC1C4526 = (SteamPlayer)_6DFA97E829CD4C5E(_262B601EEF084658((object)obj._5B4B7697703F4FD3.A94B00EF444A4363));
									int num5;
									int num6;
									if (DE96D1FFAC1C4526 == null)
									{
										num5 = 1656272730;
										num6 = num5;
									}
									else
									{
										num5 = 471990484;
										num6 = num5;
									}
									num2 = num5 ^ ((int)num4 * -1322170753);
									continue;
								}
								case 0u:
									goto IL_013c;
								default:
									goto IL_0163;
								}
								break;
								IL_013c:
								if (_6D466E70791B4F5A((object)obj.BAC6841A32394DA4, _003CModule_003E._58ECCB512F2A43AC<string>(2113935346)))
								{
									num2 = 567753284;
									continue;
								}
								goto IL_03a4;
							}
							continue;
							end_IL_0020:
							break;
						}
						break;
					case 0:
						goto IL_0163;
					case 2:
						goto IL_05f2;
					case 1:
						goto IL_0674;
						IL_0163:
						try
						{
							if (num != 0)
							{
								goto IL_0169;
							}
							goto IL_02d1;
							IL_0169:
							int num7 = 964855952;
							goto IL_016e;
							IL_016e:
							TaskAwaiter<(byte[], string, Guid)?> awaiter = default;
							(byte[], string, Guid)? result = default;
							while (true)
							{
								int num3 = num7;
								uint num4;
								switch ((num4 = (uint)(-(-(((0x6606DA6D ^ -1846655484) + 2004762514 + -1009073186) * -924197367 * 412990813 * 2033442269 - num3)))) % 10)
								{
								case 6u:
									break;
								default:
									goto end_IL_0163;
								case 1u:
									B97EBC28BD564A8B = default;
									num = (_4EECB1A078D847A7 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
									num7 = 1594311275;
									continue;
								case 4u:
									num = (_4EECB1A078D847A7 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
									B97EBC28BD564A8B = awaiter;
									_63400D810FA34AAA.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num7 = 247383576;
									continue;
								case 5u:
									_7FB93942F18D4191 = (result.Value.Item1, result.Value.Item2, result.Value.Item3);
									num7 = ((int)num4 * -393822005) ^ 0x6D7C9C70;
									continue;
								case 0u:
									result = awaiter.GetResult();
									num7 = 1675058223;
									continue;
								case 2u:
								{
									int num8;
									int num9;
									if (result.HasValue)
									{
										num8 = 1304823502;
										num9 = num8;
									}
									else
									{
										num8 = 165322297;
										num9 = num8;
									}
									num7 = num8 ^ (int)(num4 * 294690788);
									continue;
								}
								case 9u:
									return;
								case 7u:
									goto IL_02d1;
								case 3u:
									goto IL_02e2;
								case 8u:
									goto end_IL_0163;
								}
								break;
								IL_02e2:
								awaiter = obj._550E641997CB4191.F6F9070F6A9B4252(DE96D1FFAC1C4526, TimeSpan.FromSeconds(_003CModule_003E._58ECCB512F2A43AC<double>(479577513))).GetAwaiter();
								int num10;
								if (!awaiter.IsCompleted)
								{
									num7 = 418857781;
									num10 = num7;
								}
								else
								{
									num7 = 1594311275;
									num10 = num7;
								}
							}
							goto IL_0169;
							IL_02d1:
							awaiter = B97EBC28BD564A8B;
							num7 = 1010231874;
							goto IL_016e;
							end_IL_0163:;
						}
						catch (object obj2) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							Exception obj3 = obj2 as Exception;
							Unsafe.SkipInit(out int result2);
							if (obj3 == null)
							{
								result2 = _003CModule_003E._390073C602714496<int>(2131963235);
							}
							else
							{
								ex = obj3;
								result2 = ((((((ex is OperationCanceledException) ? 1 : 0) == _003CModule_003E._58ECCB512F2A43AC<int>(352679804)) ? 1u : 0u) > (uint)_003CModule_003E._390073C602714496<int>(2131963235)) ? 1 : 0);
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							_458B6CE8CD41437A(C179263454B44BF6._54DF173DA5E74DC3, ex, _2DBFE3FFF84D4603(_003CModule_003E.F84FA79ABE6944BB<string>(1863062964), (object)_262B601EEF084658((object)obj._5B4B7697703F4FD3.A94B00EF444A4363)), Array.Empty<object>());
						}
						goto IL_03a4;
						IL_03a4:
						b8B36C5813AC = obj._550E641997CB4191.B8B36C5813AC4505;
						num11 = _003CModule_003E._8B9C7B12B1AE4949<int>(350091668);
						anon = new
						{
							character_name = _5AB9F7D8692A4A4A(_952440B3FD41485B((object)DE96D1FFAC1C4526)),
							steam_name = _3B72114ED0F7408C(_952440B3FD41485B((object)DE96D1FFAC1C4526)),
							steam_id = _262B601EEF084658(_952440B3FD41485B((object)DE96D1FFAC1C4526)).m_SteamID,
							player_ping = C6CE59092BDF474E((Player)_342496EAE5454CE9((object)DE96D1FFAC1C4526)),
							flag_level = obj._5B4B7697703F4FD3.DAC7A80B62CA45B5.ToString(),
							flag_category = obj._5B4B7697703F4FD3._664A9756528C46FB.ToString(),
							flag_name = obj._5B4B7697703F4FD3.C6CB24124EA94C86.ToString(),
							session_time = _9F4D00138C5A4DB0(_3ED4ACEC2B1B4597() - E8A421893BEC4147((object)DE96D1FFAC1C4526))
						};
						steamID = _262B601EEF084658(_952440B3FD41485B((object)DE96D1FFAC1C4526)).m_SteamID;
						guid = ((!_7FB93942F18D4191.HasValue) ? Guid.Empty : _7FB93942F18D4191.Value.transactionId);
						if (_7FB93942F18D4191.HasValue)
						{
							array = (_19230E9F6DD14B37((object)_7FB93942F18D4191.Value.format, _003CModule_003E._8B9C7B12B1AE4949<string>(490915593), (StringComparison)_003CModule_003E._8B9C7B12B1AE4949<int>(944380096)) ? _7FB93942F18D4191.Value.data : null);
						}
						else
						{
							array = null;
						}
						awaiter2 = _9ACD880120DC4E80((object)b8B36C5813AC, num11, (object)anon, steamID, guid, array).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							goto IL_0500;
						}
						goto IL_0604;
						IL_0500:
						num12 = 1508306000;
						goto IL_0505;
						IL_0604:
						if (!awaiter2.GetResult())
						{
							num12 = 202960045;
							num13 = num12;
						}
						else
						{
							num12 = 1423310281;
							num13 = num12;
						}
						goto IL_0505;
						IL_0674:
						awaiter2 = DE290A7D356F4F42;
						DE290A7D356F4F42 = default;
						num = (_4EECB1A078D847A7 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
						num12 = 932319398;
						goto IL_0505;
						IL_05f2:
						awaiter3 = FD497D95107D48B4;
						num12 = 575491382;
						goto IL_0505;
						IL_0505:
						while (true)
						{
							int num3 = num12;
							uint num4;
							switch ((num4 = (uint)(-(-(((0x6606DA6D ^ -1846655484) + 2004762514 + -1009073186) * -924197367 * 412990813 * 2033442269 - num3)))) % 13)
							{
							case 10u:
								break;
							default:
								goto end_IL_000f;
							case 12u:
								goto IL_0580;
							case 8u:
								goto IL_05f2;
							case 5u:
								goto IL_0604;
							case 11u:
								awaiter3.GetResult();
								num12 = 1564808272;
								continue;
							case 6u:
								return;
							case 4u:
								FD497D95107D48B4 = default;
								num = (_4EECB1A078D847A7 = _003CModule_003E._390073C602714496<int>(-736908096));
								num12 = 2013643233;
								continue;
							case 2u:
								goto IL_0674;
							case 9u:
								num = (_4EECB1A078D847A7 = _003CModule_003E._8B9C7B12B1AE4949<int>(350091668));
								DE290A7D356F4F42 = awaiter2;
								_63400D810FA34AAA.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num12 = 571056546;
								continue;
							case 3u:
								num = (_4EECB1A078D847A7 = _003CModule_003E._390073C602714496<int>(1302522752));
								FD497D95107D48B4 = awaiter3;
								_63400D810FA34AAA.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num12 = -2107201083;
								continue;
							case 0u:
								_0971DE3BE76449A6(C179263454B44BF6._54DF173DA5E74DC3, _003CModule_003E._390073C602714496<string>(1787137237), Array.Empty<object>());
								num12 = 1423310281;
								continue;
							case 7u:
								return;
							case 1u:
								goto end_IL_000f;
							}
							break;
							IL_0580:
							awaiter3 = _46695849599A4BD9(_4128D75EA23246A9((object)obj._550E641997CB4191._0E2A57E4DF4D4ED1, B49EF8F61BF94AF7(DE96D1FFAC1C4526), obj._32B8578766084E5D, obj._5B4B7697703F4FD3.DAC7A80B62CA45B5, obj._5B4B7697703F4FD3._664A9756528C46FB, obj._5B4B7697703F4FD3.C6CB24124EA94C86, C92F1C2F90C242C8, _7FB93942F18D4191));
							int num14;
							if (awaiter3.IsCompleted)
							{
								num12 = 2013643233;
								num14 = num12;
							}
							else
							{
								num12 = 709038472;
								num14 = num12;
							}
						}
						goto IL_0500;
						end_IL_000f:
						break;
					}
				}
				catch (Exception exception)
				{
					_4EECB1A078D847A7 = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
					DE96D1FFAC1C4526 = null;
					while (true)
					{
						int num15 = 1985585483;
						while (true)
						{
							int num3 = num15;
							uint num4;
							switch ((num4 = (uint)(-(-(((0x6606DA6D ^ -1846655484) + 2004762514 + -1009073186) * -924197367 * 412990813 * 2033442269 - num3)))) % 4)
							{
							case 0u:
								break;
							default:
								return;
							case 2u:
								C92F1C2F90C242C8 = null;
								num15 = (int)((num4 * 472656586) ^ 0x681BFDD2);
								continue;
							case 3u:
								_7FB93942F18D4191 = null;
								_63400D810FA34AAA.SetException(exception);
								num15 = ((int)num4 * -180541034) ^ -2128076774;
								continue;
							case 1u:
								return;
							}
							break;
						}
					}
				}
				_4EECB1A078D847A7 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				while (true)
				{
					int num16 = 1601827932;
					while (true)
					{
						int num3 = num16;
						uint num4;
						switch ((num4 = (uint)(-(-(((0x6606DA6D ^ -1846655484) + 2004762514 + -1009073186) * -924197367 * 412990813 * 2033442269 - num3)))) % 6)
						{
						case 4u:
							break;
						default:
							return;
						case 5u:
							DE96D1FFAC1C4526 = null;
							num16 = ((int)num4 * -943184333) ^ -158199883;
							continue;
						case 1u:
							C92F1C2F90C242C8 = null;
							num16 = ((int)num4 * -128600616) ^ 0x77FC8696;
							continue;
						case 0u:
							_63400D810FA34AAA.SetResult();
							num16 = ((int)num4 * -1068514337) ^ 0x1A8B6FB9;
							continue;
						case 3u:
							_7FB93942F18D4191 = null;
							num16 = (int)((num4 * 797733032) ^ 0x71FD8963);
							continue;
						case 2u:
							return;
						}
						break;
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
				_63400D810FA34AAA.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static CSteamID _262B601EEF084658(object P_0)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return ((SteamPlayerID)P_0).steamID;
			}

			static object _6DFA97E829CD4C5E(CSteamID P_0)
			{
				//IL_0000: Unknown result type (might be due to invalid IL or missing references)
				return PlayerTool.getSteamPlayer(P_0);
			}

			static string _4EB0DBCE7BC748B4(object P_0, string P_1, string P_2)
			{
				return ((string)P_0).Replace(P_1, P_2);
			}

			static string _310A7B5760FC431E(object P_0)
			{
				return ((string)P_0).Trim();
			}

			static bool _6D466E70791B4F5A(object P_0, string P_1)
			{
				return ((string)P_0).Contains(P_1);
			}

			static string _2DBFE3FFF84D4603(string P_0, object P_1)
			{
				return string.Format(P_0, P_1);
			}

			static void _458B6CE8CD41437A(ILogger P_0, Exception P_1, string P_2, object[] P_3)
			{
				LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
			}

			static object _952440B3FD41485B(object P_0)
			{
				return ((SteamPlayer)P_0).playerID;
			}

			static string _5AB9F7D8692A4A4A(object P_0)
			{
				return ((SteamPlayerID)P_0).characterName;
			}

			static string _3B72114ED0F7408C(object P_0)
			{
				return ((SteamPlayerID)P_0).playerName;
			}

			static object _342496EAE5454CE9(object P_0)
			{
				return ((SteamPlayer)P_0).player;
			}

			static int C6CE59092BDF474E(Player P_0)
			{
				return _5D3F4B1BF6654E52.C8F36D848FF540AB(P_0);
			}

			static float _3ED4ACEC2B1B4597()
			{
				return Time.realtimeSinceStartup;
			}

			static float E8A421893BEC4147(object P_0)
			{
				return ((SteamPlayer)P_0).joined;
			}

			static string _9F4D00138C5A4DB0(float P_0)
			{
				return _9AB67761792440A7._9EF78793AEAE41AB(P_0);
			}

			static bool _19230E9F6DD14B37(object P_0, string P_1, StringComparison P_2)
			{
				return ((string)P_0).Equals(P_1, P_2);
			}

			static Task<bool> _9ACD880120DC4E80(object P_0, int P_1, object P_2, ulong P_3, Guid P_4, byte[] P_5)
			{
				return ((_03550CE5B4D54D24)P_0).C269E25CA8FC4AF2(P_1, P_2, P_3, P_4, P_5);
			}

			static void _0971DE3BE76449A6(ILogger P_0, string P_1, object[] P_2)
			{
				LoggerExtensions.LogError(P_0, P_1, P_2);
			}

			static B7097FC49A384CFA._708ECF20BC9E451D B49EF8F61BF94AF7(SteamPlayer P_0)
			{
				return B7097FC49A384CFA._9E407BCF45E5403A(P_0);
			}

			static object _4128D75EA23246A9(object P_0, B7097FC49A384CFA._708ECF20BC9E451D P_1, int P_2, EFlagLevel P_3, ECheckCategory P_4, ECheckType P_5, string P_6, (byte[], string, Guid)? P_7)
			{
				return ((B7097FC49A384CFA)P_0)._843A5100D1DA4FE0(P_1, P_2, P_3, P_4, P_5, P_6, P_7);
			}

			static TaskAwaiter _46695849599A4BD9(object P_0)
			{
				return ((Task)P_0).GetAwaiter();
			}
		}

		public C84D19F98EAA497F _5B4B7697703F4FD3;

		public string BAC6841A32394DA4;

		public E651E17AA2CA4BC8 _550E641997CB4191;

		public int _32B8578766084E5D;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(C0F33B48397C4DE5))]
		internal Task _3A401AF3FFA0428B()
		{
			C0F33B48397C4DE5 stateMachine = default;
			stateMachine._63400D810FA34AAA = AsyncTaskMethodBuilder.Create();
			while (true)
			{
				int num = 1590149600;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((-1324126845 * -(~1574569285) * 1693039467 + (0x3E3D0FDA ^ 0x1CF77770) - ((-452128955 * -(--1748865371 + (185268828 - -1622785902))) ^ -1173323731) - (num2 ^ (-333708787 * -598353435)) - -1259083680) ^ (--1491501398 + (0x2489FB8 ^ --2090692212)))) % 3)
					{
					case 0u:
						break;
					case 1u:
						goto IL_00b6;
					default:
						stateMachine._63400D810FA34AAA.Start(ref stateMachine);
						return stateMachine._63400D810FA34AAA.Task;
					}
					break;
					IL_00b6:
					stateMachine._97791D36F9154A0A = this;
					stateMachine._4EECB1A078D847A7 = _003CModule_003E._390073C602714496<int>(-736908096);
					num = 1902607827;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void C4BC49D8BC6D481B(Task P_0)
		{
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			if (!_36E33CD64E4C4CD6((object)P_0))
			{
				return;
			}
			while (true)
			{
				int num = 1657483;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(((~(-(num2 * 1111335553 - (~((-unchecked(1390862068 + 1383668291) - -(-2089136309 ^ 0xE6BF31F)) ^ ~(--746720819 ^ -113292113)) - (-(0x37CBC21B ^ -unchecked(947538377 * -293446039)) - -((--1434931991 ^ 0xD2C5AAF) - ((-1187399829 ^ -464762648) - --558814703)))))) + ~-1380518981 - (-97594901 ^ -1595462440)) ^ -1924523869) - 493172096)) % 4)
					{
					case 3u:
						break;
					default:
						return;
					case 1u:
					{
						object obj = _93BB358F82C243E8((object)P_0);
						int num4;
						if (!(((obj != null) ? _7850E93C6DB34E61(obj) : null) is OperationCanceledException))
						{
							num = -451562756;
							num4 = num;
						}
						else
						{
							num = 2138191578;
							num4 = num;
						}
						continue;
					}
					case 0u:
						_9711AC85792B453C(C179263454B44BF6._54DF173DA5E74DC3, (Exception)_93BB358F82C243E8((object)P_0), C8D18125A5B14A0C(_003CModule_003E._390073C602714496<string>(-1266104007), (object)_78D12C3B593C4A4D((object)_5B4B7697703F4FD3.A94B00EF444A4363)), Array.Empty<object>());
						num = 2138191578;
						continue;
					case 2u:
						return;
					}
					break;
				}
			}
		}

		static bool _36E33CD64E4C4CD6(object P_0)
		{
			return ((Task)P_0).IsFaulted;
		}

		static object _93BB358F82C243E8(object P_0)
		{
			return ((Task)P_0).Exception;
		}

		static object _7850E93C6DB34E61(object P_0)
		{
			return ((Exception)P_0).GetBaseException();
		}

		static CSteamID _78D12C3B593C4A4D(object P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((SteamPlayerID)P_0).steamID;
		}

		static string C8D18125A5B14A0C(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void _9711AC85792B453C(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	[CompilerGenerated]
	private sealed class DA254AB910AB4BD9
	{
		public TaskCompletionSource<byte[]> DFB7F447B66C4CAB;

		internal void F0AF480E819F431F(CSteamID P_0, byte[] P_1)
		{
			DFB7F447B66C4CAB.TrySetResult(P_1);
		}
	}

	[CompilerGenerated]
	private sealed class _2031CC5701C34566
	{
		public long _70981B4BDD564FD6;

		public _0447F941905C4653 _0C89D56BA7364B39;

		internal bool A7909110507F4688(_57DE83A6944B4063 P_0)
		{
			return _70981B4BDD564FD6 - _6C282486723747BE((object)P_0) > _0549D438EB594BDD((object)_0C89D56BA7364B39);
		}

		static long _6C282486723747BE(object P_0)
		{
			return ((_57DE83A6944B4063)P_0).CCC125B916614E35;
		}

		static int _0549D438EB594BDD(object P_0)
		{
			return ((_0447F941905C4653)P_0).EE92B8CFE44149FB;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct F1E6C0BAA85E41FE : IAsyncStateMachine
	{
		public int _25EEA8A270424A8F;

		public AsyncTaskMethodBuilder _42CAD0E6761B44CA;

		public E651E17AA2CA4BC8 D437C570EBBF4C7B;

		public CancellationToken _0C19E38F669F4552;

		private IUniTaskAsyncEnumerator<C84D19F98EAA497F> _62927B8FB56E42B8;

		private object _4221C4690B424241;

		private int _6C9D81CCC5764C5F;

		private Awaiter<bool> _1B653506FA64431E;

		private Awaiter B06B6C51A9444FAA;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			GC.KeepAlive(null);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_42CAD0E6761B44CA.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static CSteamID _234E1A323CBC4C86(object P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((SteamPlayerID)P_0).steamID;
		}

		static string DCC3441A162847A4(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void FBA86331A16B4D92(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}

		static UniTask C23F7D2ACA144919(object P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((IUniTaskAsyncDisposable)P_0).DisposeAsync();
		}

		static object A9372F4E59BD4FA9(Exception P_0)
		{
			return ExceptionDispatchInfo.Capture(P_0);
		}

		static void B85F9ED725FB4492(object P_0)
		{
			((ExceptionDispatchInfo)P_0).Throw();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct DF3265EC97554FF2 : IAsyncStateMachine
	{
		public int _2DD2148528D944CF;

		public AsyncTaskMethodBuilder<_6BD76CD39E2A4E73> _2FB06B6F897449E2;

		public E651E17AA2CA4BC8 _40E6FA6F21234C2C;

		public Guid E298C166FFA54C6F;

		public TimeSpan AA0218AFDB744041;

		private TaskCompletionSource<_6BD76CD39E2A4E73> E03B33416F89420E;

		private CancellationTokenSource ED7B3F7ED00D42B5;

		private TaskAwaiter<Task> _278F1C3CA9EF4756;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _2DD2148528D944CF;
			E651E17AA2CA4BC8 e651E17AA2CA4BC = _40E6FA6F21234C2C;
			_6BD76CD39E2A4E73 result = default;
			try
			{
				if (num != 0)
				{
					while (true)
					{
						int num2 = -1160703961;
						while (true)
						{
							int num3 = num2;
							uint num4;
							switch ((num4 = (uint)(~(~num3) - ~unchecked(-2117288757 * ~unchecked(~-1621985361 + unchecked(-1008967652 * 663223043))) + ~(-(~(-885833023 + -958892329))))) % 5)
							{
							case 2u:
								break;
							case 3u:
								E03B33416F89420E = new TaskCompletionSource<_6BD76CD39E2A4E73>((TaskCreationOptions)_003CModule_003E._390073C602714496<int>(-463823582));
								num2 = 599392476;
								continue;
							case 1u:
								ED7B3F7ED00D42B5 = (CancellationTokenSource)AD8A0664FA5D4928();
								num2 = (int)(num4 * 1042046068) ^ -1681691929;
								continue;
							case 0u:
								_11F552BB3E554052((object)e651E17AA2CA4BC._9C8BC7D7CF674BF3, E298C166FFA54C6F, E03B33416F89420E);
								num2 = ((int)num4 * -1560476962) ^ -2137606809;
								continue;
							default:
								goto end_IL_0014;
							}
							break;
						}
						continue;
						end_IL_0014:
						break;
					}
				}
				try
				{
					if (num != 0)
					{
						goto IL_00d6;
					}
					goto IL_02a6;
					IL_00d6:
					int num5 = -595731104;
					goto IL_00db;
					IL_00db:
					TaskAwaiter<Task> awaiter = default;
					while (true)
					{
						int num3 = num5;
						uint num4;
						switch ((num4 = (uint)(~(~num3) - ~unchecked(-2117288757 * ~unchecked(~-1621985361 + unchecked(-1008967652 * 663223043))) + ~(-(~(-885833023 + -958892329))))) % 11)
						{
						case 6u:
							break;
						case 1u:
							goto IL_0147;
						case 2u:
						{
							int num6;
							int num7;
							if (E03B33416F89420E.Task.Result != null)
							{
								num6 = 1007399162;
								num7 = num6;
							}
							else
							{
								num6 = -4778575;
								num7 = num6;
							}
							num5 = num6 ^ ((int)num4 * -331756136);
							continue;
						}
						case 4u:
							num = (_2DD2148528D944CF = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
							num5 = -690635439;
							continue;
						case 3u:
							_278F1C3CA9EF4756 = awaiter;
							_2FB06B6F897449E2.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num5 = (int)(num4 * 2044299889) ^ -156715525;
							continue;
						case 0u:
							return;
						case 9u:
							goto IL_024a;
						case 8u:
							E03B33416F89420E.TrySetCanceled();
							result = null;
							num5 = -182960203;
							continue;
						case 10u:
							goto IL_02a6;
						case 5u:
							goto end_IL_00d0;
						default:
							result = E03B33416F89420E.Task.Result;
							goto end_IL_00d0;
						}
						break;
						IL_024a:
						Task result2 = awaiter.GetResult();
						_2A9205F0FC98413D((object)ED7B3F7ED00D42B5);
						_4F94C4C64E524D80((object)e651E17AA2CA4BC._9C8BC7D7CF674BF3, E298C166FFA54C6F);
						int num8;
						if (result2 == E03B33416F89420E.Task)
						{
							num5 = 381857069;
							num8 = num5;
						}
						else
						{
							num5 = -557228919;
							num8 = num5;
						}
						continue;
						IL_0147:
						Task[] array = new Task[_003CModule_003E.F84FA79ABE6944BB<int>(-1423102128)];
						array[_003CModule_003E._390073C602714496<int>(2131963235)] = E03B33416F89420E.Task;
						array[_003CModule_003E._390073C602714496<int>(-250964212)] = (Task)AE35BA200B014DBC(AA0218AFDB744041, _05508263ABEA4940((object)ED7B3F7ED00D42B5));
						awaiter = _5E589A72DAB84279(array).GetAwaiter();
						int num9;
						if (!awaiter.IsCompleted)
						{
							num5 = -527675905;
							num9 = num5;
						}
						else
						{
							num5 = 227739123;
							num9 = num5;
						}
					}
					goto IL_00d6;
					IL_02a6:
					awaiter = _278F1C3CA9EF4756;
					_278F1C3CA9EF4756 = default;
					num = (_2DD2148528D944CF = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
					num5 = 227739123;
					goto IL_00db;
					end_IL_00d0:;
				}
				finally
				{
					if (num < _003CModule_003E.F84FA79ABE6944BB<int>(1398637845))
					{
						while (true)
						{
							IL_0317:
							int num10 = -971720099;
							while (true)
							{
								int num3 = num10;
								uint num4;
								switch ((num4 = (uint)(~(~num3) - ~unchecked(-2117288757 * ~unchecked(~-1621985361 + unchecked(-1008967652 * 663223043))) + ~(-(~(-885833023 + -958892329))))) % 4)
								{
								case 2u:
									break;
								default:
									goto end_IL_031c;
								case 1u:
								{
									int num11;
									int num12;
									if (ED7B3F7ED00D42B5 == null)
									{
										num11 = -1364984289;
										num12 = num11;
									}
									else
									{
										num11 = 139299396;
										num12 = num11;
									}
									num10 = num11 ^ ((int)num4 * -1569650720);
									continue;
								}
								case 0u:
									_729DF9B8EC564B7B((object)ED7B3F7ED00D42B5);
									num10 = (int)(num4 * 1750122601) ^ -1258860373;
									continue;
								case 3u:
									goto end_IL_031c;
								}
								goto IL_0317;
								continue;
								end_IL_031c:
								break;
							}
							break;
						}
					}
				}
			}
			catch (Exception exception)
			{
				_2DD2148528D944CF = _003CModule_003E._390073C602714496<int>(818201983);
				E03B33416F89420E = null;
				ED7B3F7ED00D42B5 = null;
				_2FB06B6F897449E2.SetException(exception);
				return;
			}
			_2DD2148528D944CF = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
			E03B33416F89420E = null;
			ED7B3F7ED00D42B5 = null;
			while (true)
			{
				int num13 = -320626001;
				while (true)
				{
					int num3 = num13;
					uint num4;
					switch ((num4 = (uint)(~(~num3) - ~unchecked(-2117288757 * ~unchecked(~-1621985361 + unchecked(-1008967652 * 663223043))) + ~(-(~(-885833023 + -958892329))))) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_044a;
					case 1u:
						return;
					}
					break;
					IL_044a:
					_2FB06B6F897449E2.SetResult(result);
					num13 = ((int)num4 * -1561336958) ^ -623483865;
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
			_2FB06B6F897449E2.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static void _11F552BB3E554052(object P_0, Guid P_1, TaskCompletionSource<_6BD76CD39E2A4E73> P_2)
		{
			((_50316A65685442A0)P_0)._30F434DE5EF741DC(P_1, P_2);
		}

		static object AD8A0664FA5D4928()
		{
			return new CancellationTokenSource();
		}

		static CancellationToken _05508263ABEA4940(object P_0)
		{
			return ((CancellationTokenSource)P_0).Token;
		}

		static object AE35BA200B014DBC(TimeSpan P_0, CancellationToken P_1)
		{
			return Task.Delay(P_0, P_1);
		}

		static Task<Task> _5E589A72DAB84279(Task[] P_0)
		{
			return Task.WhenAny(P_0);
		}

		static void _2A9205F0FC98413D(object P_0)
		{
			((CancellationTokenSource)P_0).Cancel();
		}

		static void _4F94C4C64E524D80(object P_0, Guid P_1)
		{
			((_50316A65685442A0)P_0)._1AB9E065CC1E4BE9(P_1);
		}

		static void _729DF9B8EC564B7B(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct BF0698DA304A4D6A : IAsyncStateMachine
	{
		public int CBEEB49A71BC4CA1;

		public AsyncTaskMethodBuilder<byte[]> _9364289E96224C21;

		public SteamPlayer _11C140A301E54B49;

		private DA254AB910AB4BD9 B851B02264AC4BB6;

		public TimeSpan DFFC0D54A1FF4F65;

		private CancellationTokenSource _62257F35AB2C4051;

		private Awaiter _6DEF585F05354899;

		private Awaiter DF2E6334FFCE4414;

		private TaskAwaiter<Task> _6BAE4BEAD7BF4A80;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Expected Obj, but got Unknown
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			int num = CBEEB49A71BC4CA1;
			byte[] result;
			try
			{
				int num2;
				Awaiter awaiter = default;
				Awaiter awaiter2 = default;
				SwitchToMainThreadAwaitable val = default;
				switch (num)
				{
				default:
					num2 = 1214066419;
					goto IL_001e;
				case 1:
					goto IL_02e2;
				case 0:
					goto IL_02f4;
				case 2:
					break;
					IL_001e:
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(1951703377 - ~(-(-578670614 ^ -1457907169) - (~((-483701299 ^ -(-(0x154DEB19 ^ 0x4F85A9A8) - -(-949229129 ^ -812264579))) - num3 * 2147481905) - (--1843076066 * 751356853 + ~(329800627 + -1407601017) - (758165542 - (-639555614 + -114911244 - 328710334)))) - -1589331566))) % 17)
						{
						case 12u:
							break;
						case 2u:
							num = (CBEEB49A71BC4CA1 = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042));
							_6DEF585F05354899 = awaiter;
							num2 = 11700821;
							continue;
						case 11u:
						{
							awaiter.GetResult();
							C6F757F3517C45E1(_92699D81714648B0((object)_11C140A301E54B49), CSteamID.Nil, (object)(PlayerSpyReady)((CSteamID P_0, byte[] P_1) =>
							{
								B851B02264AC4BB6.DFB7F447B66C4CAB.TrySetResult(P_1);
							}));
							SwitchToThreadPoolAwaitable val2 = UniTask.SwitchToThreadPool();
							awaiter2 = val2.GetAwaiter();
							num2 = 1311552856;
							continue;
						}
						case 0u:
						{
							int num7;
							int num8;
							if (!awaiter.IsCompleted)
							{
								num7 = 1326213454;
								num8 = num7;
							}
							else
							{
								num7 = 225638323;
								num8 = num7;
							}
							num2 = num7 ^ ((int)num4 * -1601064566);
							continue;
						}
						case 16u:
							B851B02264AC4BB6 = (DA254AB910AB4BD9)_3588D3BB60934DD1();
							B851B02264AC4BB6.DFB7F447B66C4CAB = new TaskCompletionSource<byte[]>((TaskCreationOptions)_003CModule_003E.F84FA79ABE6944BB<int>(-1925532226));
							val = UniTask.SwitchToMainThread(default(CancellationToken));
							num2 = 4689181;
							continue;
						case 14u:
							DF2E6334FFCE4414 = default;
							num = (CBEEB49A71BC4CA1 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = 545052138;
							continue;
						case 13u:
						{
							int num5;
							int num6;
							if (awaiter2.IsCompleted)
							{
								num5 = -1319200934;
								num6 = num5;
							}
							else
							{
								num5 = -678913082;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num4 * 162791248);
							continue;
						}
						case 8u:
							_6DEF585F05354899 = default;
							num2 = (int)(num4 * 807732358) ^ -352868778;
							continue;
						case 5u:
							awaiter2.GetResult();
							num2 = -614370939;
							continue;
						case 6u:
							num = (CBEEB49A71BC4CA1 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = -657844925;
							continue;
						case 10u:
							_9364289E96224C21.AwaitUnsafeOnCompleted<Awaiter, BF0698DA304A4D6A>(ref awaiter, ref this);
							return;
						case 3u:
							num = (CBEEB49A71BC4CA1 = _003CModule_003E._8B9C7B12B1AE4949<int>(350091668));
							DF2E6334FFCE4414 = awaiter2;
							_9364289E96224C21.AwaitUnsafeOnCompleted<Awaiter, BF0698DA304A4D6A>(ref awaiter2, ref this);
							return;
						case 4u:
							_62257F35AB2C4051 = (CancellationTokenSource)DA45D485A53348DA();
							num2 = ((int)num4 * -559119968) ^ 0x5860EAAA;
							continue;
						case 9u:
							goto IL_02e2;
						case 7u:
							goto IL_02f4;
						case 1u:
							awaiter = val.GetAwaiter();
							num2 = ((int)num4 * -284080997) ^ -504699871;
							continue;
						default:
							goto end_IL_0008;
						}
						break;
					}
					goto default;
					IL_02f4:
					awaiter = _6DEF585F05354899;
					num2 = 2065854576;
					goto IL_001e;
					IL_02e2:
					awaiter2 = DF2E6334FFCE4414;
					num2 = -412519555;
					goto IL_001e;
					end_IL_0008:
					break;
				}
				try
				{
					if (num != _003CModule_003E._3F57E81A62734AC2<int>(-845933485))
					{
						goto IL_0333;
					}
					goto IL_045f;
					IL_0333:
					int num9 = 1305324241;
					goto IL_0338;
					IL_0338:
					TaskAwaiter<Task> awaiter3 = default;
					while (true)
					{
						int num3 = num9;
						uint num4;
						switch ((num4 = (uint)(1951703377 - ~(-(-578670614 ^ -1457907169) - (~((-483701299 ^ -(-(0x154DEB19 ^ 0x4F85A9A8) - -(-949229129 ^ -812264579))) - num3 * 2147481905) - (--1843076066 * 751356853 + ~(329800627 + -1407601017) - (758165542 - (-639555614 + -114911244 - 328710334)))) - -1589331566))) % 11)
						{
						case 9u:
							break;
						case 5u:
						{
							Task[] array = new Task[_003CModule_003E._8B9C7B12B1AE4949<int>(-1540732256)];
							array[_003CModule_003E._58ECCB512F2A43AC<int>(352679804)] = B851B02264AC4BB6.DFB7F447B66C4CAB.Task;
							array[_003CModule_003E.F84FA79ABE6944BB<int>(1741630884)] = (Task)_24809BC521494486(DFFC0D54A1FF4F65, A37D315C29D241D0((object)_62257F35AB2C4051));
							awaiter3 = E2FC8EA8E5A74B9F(array).GetAwaiter();
							num9 = 661570738;
							continue;
						}
						case 4u:
							goto IL_045f;
						case 3u:
							B851B02264AC4BB6.DFB7F447B66C4CAB.TrySetCanceled();
							A03AC42BF95D49A8(C179263454B44BF6._54DF173DA5E74DC3, _425F98B2BC354F22(_003CModule_003E._3F57E81A62734AC2<string>(-619986034), _2C4758310BAE4235((object)_11C140A301E54B49)), Array.Empty<object>());
							result = null;
							goto end_IL_0321;
						case 1u:
							num = (CBEEB49A71BC4CA1 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
							num9 = -1430057429;
							continue;
						case 6u:
							goto IL_04e8;
						case 2u:
							_6BAE4BEAD7BF4A80 = awaiter3;
							_9364289E96224C21.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							return;
						case 0u:
							num = (CBEEB49A71BC4CA1 = _003CModule_003E._58ECCB512F2A43AC<int>(1208532887));
							num9 = -843317785;
							continue;
						case 10u:
						{
							int num12;
							int num13;
							if (awaiter3.IsCompleted)
							{
								num12 = -666738783;
								num13 = num12;
							}
							else
							{
								num12 = -854376166;
								num13 = num12;
							}
							num9 = num12 ^ (int)(num4 * 2019581890);
							continue;
						}
						case 8u:
						{
							int num10;
							int num11;
							if (B851B02264AC4BB6.DFB7F447B66C4CAB.Task.Result.Length == 0)
							{
								num10 = -1874472154;
								num11 = num10;
							}
							else
							{
								num10 = 594804419;
								num11 = num10;
							}
							num9 = num10 ^ ((int)num4 * -1786764687);
							continue;
						}
						default:
							result = B851B02264AC4BB6.DFB7F447B66C4CAB.Task.Result;
							goto end_IL_0321;
						}
						break;
						IL_04e8:
						Task result2 = awaiter3.GetResult();
						_49439D131D544AED((object)_62257F35AB2C4051);
						int num14;
						if (result2 == B851B02264AC4BB6.DFB7F447B66C4CAB.Task)
						{
							num9 = -887072265;
							num14 = num9;
						}
						else
						{
							num9 = -253356010;
							num14 = num9;
						}
					}
					goto IL_0333;
					IL_045f:
					awaiter3 = _6BAE4BEAD7BF4A80;
					_6BAE4BEAD7BF4A80 = default;
					num9 = 1653169961;
					goto IL_0338;
					end_IL_0321:;
				}
				finally
				{
					if (num < _003CModule_003E._58ECCB512F2A43AC<int>(352679804))
					{
						while (true)
						{
							IL_05f4:
							int num15 = 727160978;
							while (true)
							{
								int num3 = num15;
								uint num4;
								switch ((num4 = (uint)(1951703377 - ~(-(-578670614 ^ -1457907169) - (~((-483701299 ^ -(-(0x154DEB19 ^ 0x4F85A9A8) - -(-949229129 ^ -812264579))) - num3 * 2147481905) - (--1843076066 * 751356853 + ~(329800627 + -1407601017) - (758165542 - (-639555614 + -114911244 - 328710334)))) - -1589331566))) % 4)
								{
								case 0u:
									break;
								default:
									goto end_IL_05f9;
								case 1u:
								{
									int num16;
									int num17;
									if (_62257F35AB2C4051 == null)
									{
										num16 = 2059850544;
										num17 = num16;
									}
									else
									{
										num16 = -1610948627;
										num17 = num16;
									}
									num15 = num16 ^ ((int)num4 * -1905152803);
									continue;
								}
								case 3u:
									BFB073851B11460B((object)_62257F35AB2C4051);
									num15 = (int)((num4 * 1057172380) ^ 0x5C803F15);
									continue;
								case 2u:
									goto end_IL_05f9;
								}
								goto IL_05f4;
								continue;
								end_IL_05f9:
								break;
							}
							break;
						}
					}
				}
			}
			catch (Exception exception)
			{
				CBEEB49A71BC4CA1 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
				B851B02264AC4BB6 = null;
				_62257F35AB2C4051 = null;
				_9364289E96224C21.SetException(exception);
				return;
			}
			CBEEB49A71BC4CA1 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
			while (true)
			{
				int num18 = -630381996;
				while (true)
				{
					int num3 = num18;
					uint num4;
					switch ((num4 = (uint)(1951703377 - ~(-(-578670614 ^ -1457907169) - (~((-483701299 ^ -(-(0x154DEB19 ^ 0x4F85A9A8) - -(-949229129 ^ -812264579))) - num3 * 2147481905) - (--1843076066 * 751356853 + ~(329800627 + -1407601017) - (758165542 - (-639555614 + -114911244 - 328710334)))) - -1589331566))) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 3u:
						B851B02264AC4BB6 = null;
						num18 = ((int)num4 * -71876851) ^ -96576946;
						continue;
					case 2u:
						_62257F35AB2C4051 = null;
						_9364289E96224C21.SetResult(result);
						num18 = (int)((num4 * 1659688399) ^ 0x66FBBA24);
						continue;
					case 1u:
						return;
					}
					break;
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
			_9364289E96224C21.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _3588D3BB60934DD1()
		{
			return new DA254AB910AB4BD9();
		}

		static object _92699D81714648B0(object P_0)
		{
			return ((SteamPlayer)P_0).player;
		}

		static void C6F757F3517C45E1(object P_0, CSteamID P_1, object P_2)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Player)P_0).sendScreenshot(P_1, (PlayerSpyReady)P_2);
		}

		static object DA45D485A53348DA()
		{
			return new CancellationTokenSource();
		}

		static CancellationToken A37D315C29D241D0(object P_0)
		{
			return ((CancellationTokenSource)P_0).Token;
		}

		static object _24809BC521494486(TimeSpan P_0, CancellationToken P_1)
		{
			return Task.Delay(P_0, P_1);
		}

		static Task<Task> E2FC8EA8E5A74B9F(Task[] P_0)
		{
			return Task.WhenAny(P_0);
		}

		static void _49439D131D544AED(object P_0)
		{
			((CancellationTokenSource)P_0).Cancel();
		}

		static object _2C4758310BAE4235(object P_0)
		{
			return ((SteamPlayer)P_0).playerID;
		}

		static string _425F98B2BC354F22(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void A03AC42BF95D49A8(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}

		static void BFB073851B11460B(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _8D086FF5304A4147 : IAsyncStateMachine
	{
		public int _8025C20B67B64453;

		public AsyncTaskMethodBuilder<(byte[] data, string format, Guid transactionId)?> B85185EF0B224329;

		public E651E17AA2CA4BC8 _904D5959DD964417;

		public SteamPlayer _856CB7B72A2C4F85;

		public TimeSpan _86D34DC7CA7B4A83;

		private bool _912B94DD84AD4D58;

		private C7A753824C0746AE._359F714CB1DB4E96 _2409253A30A34EEC;

		private Guid _83F5937EFD734F24;

		private Awaiter _6152920A70634445;

		private Awaiter _8C4646A11A1D49B4;

		private TaskAwaiter _50D734D9456349A8;

		private TaskAwaiter<bool> B6050F73799649D5;

		private TaskAwaiter<_6BD76CD39E2A4E73?> _5929189E621F4C00;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0718: Unknown result type (might be due to invalid IL or missing references)
			//IL_071d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0725: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_063a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0820: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
			int num = _8025C20B67B64453;
			E651E17AA2CA4BC8 e651E17AA2CA4BC = _904D5959DD964417;
			(byte[], string, Guid)? result = default;
			try
			{
				switch (num)
				{
				case 0:
					goto IL_02c6;
				case 4:
					goto IL_03ef;
				case 3:
					goto IL_041f;
				case 1:
					goto IL_0717;
				case 2:
					goto IL_075f;
				}
				goto IL_0028;
				IL_0028:
				int num2 = 158442341;
				goto IL_002d;
				IL_002d:
				TaskAwaiter awaiter = default;
				_6BD76CD39E2A4E73 result2 = default;
				Awaiter awaiter2 = default;
				TaskAwaiter<_6BD76CD39E2A4E73> awaiter3 = default;
				(byte[], string, Guid)? tuple2 = default;
				TaskAwaiter<bool> awaiter5 = default;
				Awaiter awaiter4 = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					(byte[], string, Guid)? tuple;
					switch ((num4 = (uint)((-((-(num3 - ((((0x7C39EBC8 ^ --1356383667) - 156410640) ^ -1004217500 ^ -(-124040521 ^ --1356124176)) - -(0x17426D7 ^ (~(--2108054769) + (0x461A6543 ^ -1169560511))) - unchecked(-1274713907 * -1095331262))) * 1378465111) ^ -(-701862485 * (--189962760 - (-85733030 + 88239271)))) ^ 0x3B7A9819) * 2020272727)) % 44)
					{
					case 13u:
						break;
					default:
						goto end_IL_000e;
					case 10u:
						goto IL_01c2;
					case 35u:
					{
						int num9;
						int num10;
						if (!_912B94DD84AD4D58)
						{
							num9 = 1733529186;
							num10 = num9;
						}
						else
						{
							num9 = -180612208;
							num10 = num9;
						}
						num2 = num9 ^ (int)(num4 * 106522676);
						continue;
					}
					case 36u:
						return;
					case 2u:
						B85185EF0B224329.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = ((int)num4 * -1796557322) ^ 0x1D920CE3;
						continue;
					case 39u:
					{
						int num13;
						int num14;
						if (result2 != null)
						{
							num13 = 1569124089;
							num14 = num13;
						}
						else
						{
							num13 = -1359259626;
							num14 = num13;
						}
						num2 = num13 ^ (int)(num4 * 1843079303);
						continue;
					}
					case 42u:
						_83F5937EFD734F24 = Guid.NewGuid();
						num2 = -380310758;
						continue;
					case 31u:
						goto IL_0273;
					case 12u:
						if (_2409253A30A34EEC._849CF3D1826A4684 <= _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
						{
							num2 = 911691905;
							continue;
						}
						tuple = (BB5CFE91B57D4A83((object)_2409253A30A34EEC._358E24B6AAB2450C[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)]), _003CModule_003E.F84FA79ABE6944BB<string>(-1642410511), _83F5937EFD734F24);
						goto IL_069b;
					case 24u:
						goto IL_02c6;
					case 25u:
						num = (_8025C20B67B64453 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
						num2 = -1021422199;
						continue;
					case 22u:
						_5929189E621F4C00 = default;
						num = (_8025C20B67B64453 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
						num2 = 165518107;
						continue;
					case 32u:
						result = (BB5CFE91B57D4A83((object)_2409253A30A34EEC._358E24B6AAB2450C[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)]), _003CModule_003E.F84FA79ABE6944BB<string>(-1642410511), _83F5937EFD734F24);
						goto end_IL_000e;
					case 41u:
						goto IL_036c;
					case 6u:
						awaiter2.GetResult();
						num2 = -574622904;
						continue;
					case 19u:
						_2409253A30A34EEC = (C7A753824C0746AE._359F714CB1DB4E96)_28933A4EFD8A44A5();
						B893F8CB43F44F1F((object)e651E17AA2CA4BC._3C47EC9157E44260).TryAdd(_6B50E28CA2F54419(EA20E2B7C04F4571((object)_856CB7B72A2C4F85)), _2409253A30A34EEC);
						num2 = (int)(num4 * 1259170038) ^ -2074975050;
						continue;
					case 23u:
						goto IL_03ef;
					case 29u:
						num = (_8025C20B67B64453 = _003CModule_003E._8B9C7B12B1AE4949<int>(944380096));
						num2 = -1265406809;
						continue;
					case 7u:
						goto IL_041f;
					case 37u:
						_912B94DD84AD4D58 = B893F8CB43F44F1F((object)e651E17AA2CA4BC._3C47EC9157E44260).TryGetValue(_6B50E28CA2F54419(EA20E2B7C04F4571((object)_856CB7B72A2C4F85)), out _2409253A30A34EEC);
						num2 = ((int)num4 * -799712595) ^ 0x1551EC77;
						continue;
					case 11u:
						num = (_8025C20B67B64453 = _003CModule_003E.F84FA79ABE6944BB<int>(2084623923));
						_5929189E621F4C00 = awaiter3;
						B85185EF0B224329.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					case 38u:
					{
						SwitchToMainThreadAwaitable val = UniTask.SwitchToMainThread(default(CancellationToken));
						awaiter2 = val.GetAwaiter();
						int num11;
						int num12;
						if (!awaiter2.IsCompleted)
						{
							num11 = -1114991856;
							num12 = num11;
						}
						else
						{
							num11 = 463961809;
							num12 = num11;
						}
						num2 = num11 ^ ((int)num4 * -2098261046);
						continue;
					}
					case 34u:
						goto IL_04f4;
					case 20u:
						goto IL_052a;
					case 18u:
						tuple2 = null;
						num2 = ((int)num4 * -161758381) ^ -122340578;
						continue;
					case 0u:
						B6050F73799649D5 = awaiter5;
						B85185EF0B224329.AwaitUnsafeOnCompleted(ref awaiter5, ref this);
						return;
					case 15u:
						_8C4646A11A1D49B4 = awaiter4;
						B85185EF0B224329.AwaitUnsafeOnCompleted<Awaiter, _8D086FF5304A4147>(ref awaiter4, ref this);
						return;
					case 16u:
						result2 = awaiter3.GetResult();
						num2 = 326476510;
						continue;
					case 27u:
						num = (_8025C20B67B64453 = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
						num2 = -1821894387;
						continue;
					case 14u:
						awaiter.GetResult();
						num2 = 914650643;
						continue;
					case 28u:
					{
						B893F8CB43F44F1F((object)e651E17AA2CA4BC._3C47EC9157E44260).TryRemove(_6B50E28CA2F54419(EA20E2B7C04F4571((object)_856CB7B72A2C4F85)), out C7A753824C0746AE._359F714CB1DB4E96 _);
						num2 = ((int)num4 * -1117308721) ^ 0x38762FCD;
						continue;
					}
					case 33u:
						tuple = tuple2;
						goto IL_069b;
					case 5u:
						goto IL_06a6;
					case 8u:
						result = null;
						goto end_IL_000e;
					case 1u:
						goto IL_0717;
					case 43u:
					{
						int num7;
						int num8;
						if (_2409253A30A34EEC._849CF3D1826A4684 != 0)
						{
							num7 = 1909649748;
							num8 = num7;
						}
						else
						{
							num7 = -1729515883;
							num8 = num7;
						}
						num2 = num7 ^ (int)(num4 * 733924446);
						continue;
					}
					case 3u:
						goto IL_075f;
					case 17u:
						num = (_8025C20B67B64453 = _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
						num2 = -1536098398;
						continue;
					case 9u:
						result = (_836D5B4BCFA34463((object)result2), _003CModule_003E._3F57E81A62734AC2<string>(-940222795), _83F5937EFD734F24);
						goto end_IL_000e;
					case 21u:
						num = (_8025C20B67B64453 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
						_6152920A70634445 = awaiter2;
						B85185EF0B224329.AwaitUnsafeOnCompleted<Awaiter, _8D086FF5304A4147>(ref awaiter2, ref this);
						return;
					case 30u:
						_6152920A70634445 = default;
						num = (_8025C20B67B64453 = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
						num2 = 2087077557;
						continue;
					case 4u:
						num = (_8025C20B67B64453 = _003CModule_003E._3F57E81A62734AC2<int>(-845933485));
						_50D734D9456349A8 = awaiter;
						num2 = -837667023;
						continue;
					case 40u:
					{
						int num5;
						int num6;
						if (!_912B94DD84AD4D58)
						{
							num5 = 1832490323;
							num6 = num5;
						}
						else
						{
							num5 = -405466871;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num4 * 2123779187);
						continue;
					}
					case 26u:
						goto end_IL_000e;
						IL_069b:
						result = tuple;
						num2 = -2111314735;
						continue;
					}
					break;
					IL_06a6:
					awaiter5 = _90F9C0F6D0424154((object)e651E17AA2CA4BC._9C8BC7D7CF674BF3, _907976CCB0C04E48(_83F5937EFD734F24, _003CModule_003E.F84FA79ABE6944BB<float>(-717502281), _2409253A30A34EEC._358E24B6AAB2450C)).GetAwaiter();
					int num15;
					if (!awaiter5.IsCompleted)
					{
						num2 = 1521756640;
						num15 = num2;
					}
					else
					{
						num2 = -1821894387;
						num15 = num2;
					}
					continue;
					IL_04f4:
					awaiter4.GetResult();
					awaiter = _6A41E9CC2BBC4E39(_04BE5759E4BE4317(_86D34DC7CA7B4A83));
					int num16;
					if (!awaiter.IsCompleted)
					{
						num2 = 577911859;
						num16 = num2;
					}
					else
					{
						num2 = 430591973;
						num16 = num2;
					}
					continue;
					IL_0273:
					int num17;
					if (_2409253A30A34EEC._849CF3D1826A4684 == _003CModule_003E._58ECCB512F2A43AC<int>(1006217019))
					{
						num2 = 1552432759;
						num17 = num2;
					}
					else
					{
						num2 = -314051712;
						num17 = num2;
					}
					continue;
					IL_052a:
					awaiter3 = e651E17AA2CA4BC.DE3CCAE06F70472C(_83F5937EFD734F24, TimeSpan.FromSeconds(_003CModule_003E._390073C602714496<double>(-634760324))).GetAwaiter();
					int num18;
					if (awaiter3.IsCompleted)
					{
						num2 = 165518107;
						num18 = num2;
					}
					else
					{
						num2 = 1219544978;
						num18 = num2;
					}
					continue;
					IL_01c2:
					int num19;
					if (!awaiter5.GetResult())
					{
						num2 = 821360623;
						num19 = num2;
					}
					else
					{
						num2 = -402482421;
						num19 = num2;
					}
					continue;
					IL_036c:
					SwitchToThreadPoolAwaitable val2 = UniTask.SwitchToThreadPool();
					awaiter4 = val2.GetAwaiter();
					int num20;
					if (!awaiter4.IsCompleted)
					{
						num2 = -17052848;
						num20 = num2;
					}
					else
					{
						num2 = -1021422199;
						num20 = num2;
					}
				}
				goto IL_0028;
				IL_02c6:
				awaiter2 = _6152920A70634445;
				num2 = 1500571877;
				goto IL_002d;
				IL_0717:
				awaiter4 = _8C4646A11A1D49B4;
				_8C4646A11A1D49B4 = default;
				num2 = 207062456;
				goto IL_002d;
				IL_041f:
				awaiter5 = B6050F73799649D5;
				B6050F73799649D5 = default;
				num2 = 1029738534;
				goto IL_002d;
				IL_075f:
				awaiter = _50D734D9456349A8;
				_50D734D9456349A8 = default;
				num = (_8025C20B67B64453 = _003CModule_003E._390073C602714496<int>(-736908096));
				num2 = 430591973;
				goto IL_002d;
				IL_03ef:
				awaiter3 = _5929189E621F4C00;
				num2 = 350707949;
				goto IL_002d;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num21 = 180519608;
					while (true)
					{
						int num3 = num21;
						uint num4;
						switch ((num4 = (uint)((-((-(num3 - ((((0x7C39EBC8 ^ --1356383667) - 156410640) ^ -1004217500 ^ -(-124040521 ^ --1356124176)) - -(0x17426D7 ^ (~(--2108054769) + (0x461A6543 ^ -1169560511))) - unchecked(-1274713907 * -1095331262))) * 1378465111) ^ -(-701862485 * (--189962760 - (-85733030 + 88239271)))) ^ 0x3B7A9819) * 2020272727)) % 3)
						{
						case 0u:
							break;
						case 2u:
							goto IL_0988;
						default:
							B85185EF0B224329.SetException(exception);
							return;
						}
						break;
						IL_0988:
						_8025C20B67B64453 = _003CModule_003E._390073C602714496<int>(818201983);
						_2409253A30A34EEC = null;
						num21 = -78018379;
					}
				}
			}
			_8025C20B67B64453 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
			_2409253A30A34EEC = null;
			while (true)
			{
				int num22 = 764099614;
				while (true)
				{
					int num3 = num22;
					uint num4;
					switch ((num4 = (uint)((-((-(num3 - ((((0x7C39EBC8 ^ --1356383667) - 156410640) ^ -1004217500 ^ -(-124040521 ^ --1356124176)) - -(0x17426D7 ^ (~(--2108054769) + (0x461A6543 ^ -1169560511))) - unchecked(-1274713907 * -1095331262))) * 1378465111) ^ -(-701862485 * (--189962760 - (-85733030 + 88239271)))) ^ 0x3B7A9819) * 2020272727)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_0ac8;
					case 1u:
						return;
					}
					break;
					IL_0ac8:
					B85185EF0B224329.SetResult(result);
					num22 = (int)((num4 * 45644558) ^ 0x5D5E0B71);
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
			B85185EF0B224329.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static ConcurrentDictionary<CSteamID, C7A753824C0746AE._359F714CB1DB4E96> B893F8CB43F44F1F(object P_0)
		{
			return ((C7A753824C0746AE)P_0).ADAA9521257F4886();
		}

		static object EA20E2B7C04F4571(object P_0)
		{
			return ((SteamPlayer)P_0).playerID;
		}

		static CSteamID _6B50E28CA2F54419(object P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((SteamPlayerID)P_0).steamID;
		}

		static object _28933A4EFD8A44A5()
		{
			return new C7A753824C0746AE._359F714CB1DB4E96();
		}

		static object _04BE5759E4BE4317(TimeSpan P_0)
		{
			return Task.Delay(P_0);
		}

		static TaskAwaiter _6A41E9CC2BBC4E39(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static byte[] BB5CFE91B57D4A83(object P_0)
		{
			return ((_23AFFD5168C1458B)P_0)._970C081BF3CA45E7;
		}

		static object _907976CCB0C04E48(Guid P_0, float P_1, List<_23AFFD5168C1458B> P_2)
		{
			return new _83D3069491A44F2C(P_0, P_1, P_2);
		}

		static Task<bool> _90F9C0F6D0424154(object P_0, object P_1)
		{
			return ((_50316A65685442A0)P_0).C0812FEDC7E142DB((_83D3069491A44F2C)P_1);
		}

		static byte[] _836D5B4BCFA34463(object P_0)
		{
			return ((_6BD76CD39E2A4E73)P_0)._7B4BD7A07B534357;
		}
	}

	private readonly ConcurrentDictionary<CSteamID, _58C92E7ADC894CE6> F16BE55E1EE94732;

	private readonly global::EF9B595087F64C1E<CSteamID> _2B9B820492184B13;

	private readonly global::EF9B595087F64C1E<CSteamID> _37AD32AB2C8A4F8F;

	private readonly CancellationTokenSource C8D0E9D0F9154ABD;

	private readonly Channel<C84D19F98EAA497F> _619449577E0148F4;

	private readonly List<_0447F941905C4653> _3AD1B11BAAF840BA;

	private readonly object _5117E882064249C0;

	private readonly B7097FC49A384CFA _0E2A57E4DF4D4ED1;

	private readonly C7A753824C0746AE _3C47EC9157E44260;

	private readonly _50316A65685442A0 _9C8BC7D7CF674BF3;

	private readonly _03550CE5B4D54D24 B8B36C5813AC4505;

	private const string _1130607CD5FD4624 = "[delayed] ";

	private const string _47EB38DED1F341AA = "[webhook] ";

	private const string _9FD2DFD4249749FC = "[spyscreenshot]";

	public E651E17AA2CA4BC8()
	{
		uint num = 1u;
		while (num != 0 && num == 1)
		{
			_414C8056DA234214((object)this);
			num = 0u;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void F08FFF64C62C4F0A()
	{
		GC.KeepAlive(null);
	}

	public void E99E5CDB10C04998(SteamPlayerID P_0, ECheckCategory P_1, ECheckType P_2, EFlagLevel P_3, string P_4)
	{
		((Channel<C84D19F98EAA497F, C84D19F98EAA497F>)(object)_619449577E0148F4).Writer.TryWrite(new C84D19F98EAA497F(P_0, P_1, P_2, P_3, P_4));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(F1E6C0BAA85E41FE))]
	private Task _408AEEE548064800(CancellationToken P_0)
	{
		uint num = 2u;
		while (true)
		{
			switch (num)
			{
			case 1u:
				return null;
			case 2u:
				goto IL_000e;
			}
			continue;
			IL_000e:
			num = 1u;
		}
	}

	public void D921A004769646BD(CSteamID P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_2B9B820492184B13.Add(P_0);
	}

	public bool C3BAAC3F99224A6F(CSteamID P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return _2B9B820492184B13.Remove(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void AF700B8F7DCC4112(C84D19F98EAA497F P_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_58C92E7ADC894CE6 orAdd = F16BE55E1EE94732.GetOrAdd(_141C1FCE13204C7E((object)P_0.A94B00EF444A4363), [MethodImpl(MethodImplOptions.NoInlining)] (CSteamID val) =>
		{
			object obj2 = _5117E882064249C0;
			bool flag2 = (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0;
			try
			{
				CC8376A4C38A41F6(obj2, ref flag2);
				object obj3 = _7FC0ED74141B4E31();
				B01DDECE6CBF4085(obj3, _3AD1B11BAAF840BA.Select((_0447F941905C4653 obj4) => (_0447F941905C4653)B199BB1D204541ED._54B081F580B247ED((object)obj4)).ToList());
				return (_58C92E7ADC894CE6)obj3;
			}
			finally
			{
				if (flag2)
				{
					while (true)
					{
						IL_0062:
						int num9 = 257061851;
						while (true)
						{
							int num10 = num9;
							uint num11;
							switch ((num11 = (uint)((-(-(-((((-(-(--182633996)) - ~(0x48995ABD ^ -333109855)) ^ -1456186834 ^ ~((-388007398 ^ 0x4E4118) - -(~-585828427) - -(~(--548057148)))) * 184823471 - num10) * 2029789447) * 2147294115)) * 1510236403) ^ 0xFEAB0A6)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_0067;
							case 1u:
								goto IL_0121;
							case 2u:
								goto end_IL_0067;
							}
							goto IL_0062;
							IL_0121:
							_3E929CB8CFA8443C(obj2);
							num9 = (int)((num11 * 600912833) ^ 0xC91A1F4);
							continue;
							end_IL_0067:
							break;
						}
						break;
					}
				}
			}
		});
		List<_57DE83A6944B4063> list = _2A035A8D06F347C5((object)orAdd);
		bool flag = (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
		try
		{
			CC8376A4C38A41F6((object)list, ref flag);
			if (!_539D90F5B14A40F1(orAdd, P_0.C6CB24124EA94C86, out _0447F941905C4653 obj))
			{
				goto IL_0050;
			}
			goto IL_00cb;
			IL_0050:
			int num = -273021899;
			goto IL_0055;
			IL_0055:
			int num4 = default;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(unchecked(1047595755 * 169385394) - (unchecked(-907978372 * -840697839) + -722439946) + -1861195274 - ~(~num2 * 233621253))) % 8)
				{
				case 0u:
					break;
				case 5u:
					return;
				case 1u:
					goto IL_00cb;
				case 4u:
					return;
				case 7u:
					goto IL_0108;
				case 3u:
				{
					int num5;
					int num6;
					if (P_0.DAC7A80B62CA45B5 == EFlagLevel.Shadow)
					{
						num5 = 1875107408;
						num6 = num5;
					}
					else
					{
						num5 = -434826911;
						num6 = num5;
					}
					num = num5 ^ ((int)num3 * -1431525370);
					continue;
				}
				case 6u:
					_8FCB3A1FBFC24DDC(P_0, num4);
					num = ((int)num3 * -1894242468) ^ 0x60EEAAEF;
					continue;
				default:
					A2A0216051544893(obj, P_0, num4);
					return;
				}
				break;
				IL_0108:
				int num7;
				if (P_0.DAC7A80B62CA45B5 != (EFlagLevel)_003CModule_003E._58ECCB512F2A43AC<int>(1018572111))
				{
					num = -1598049924;
					num7 = num;
				}
				else
				{
					num = -1342381758;
					num7 = num;
				}
			}
			goto IL_0050;
			IL_00cb:
			AF648FF29706486F(orAdd, obj);
			BD6E8D257DCD4A82(orAdd, P_0);
			num4 = CF1396A136BA4D05(_2A035A8D06F347C5((object)orAdd), P_0.C6CB24124EA94C86);
			num = 1855445424;
			goto IL_0055;
		}
		finally
		{
			if (flag)
			{
				while (true)
				{
					IL_0180:
					int num8 = 1237575944;
					while (true)
					{
						int num2 = num8;
						uint num3;
						switch ((num3 = (uint)(unchecked(1047595755 * 169385394) - (unchecked(-907978372 * -840697839) + -722439946) + -1861195274 - ~(~num2 * 233621253))) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_0185;
						case 1u:
							goto IL_01cf;
						case 0u:
							goto end_IL_0185;
						}
						goto IL_0180;
						IL_01cf:
						_3E929CB8CFA8443C((object)list);
						num8 = (int)((num3 * 340337632) ^ 0x55E26084);
						continue;
						end_IL_0185:
						break;
					}
					break;
				}
			}
		}
	}

	private void BD6E8D257DCD4A82(_58C92E7ADC894CE6 P_0, C84D19F98EAA497F P_1)
	{
		List<_57DE83A6944B4063> list = _2A035A8D06F347C5((object)P_0);
		object obj = AA40D04FC20646AC();
		_8C6D4A534A404B5E(obj, P_1._664A9756528C46FB);
		E04001CD16664FE3(obj, P_1.C6CB24124EA94C86);
		BDB3971EBC7D4E1A(obj, P_1.DAC7A80B62CA45B5);
		_0316360DA0DA417F(obj, DateTimeOffset.Now.ToUnixTimeMilliseconds());
		_127DA1BE39FF4CDD(obj, P_1._6C0F36D636E344A2);
		list.Add((_57DE83A6944B4063)obj);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _8FCB3A1FBFC24DDC(C84D19F98EAA497F P_0, int P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		var anon = new
		{
			SteamID = ((object)_141C1FCE13204C7E((object)P_0.A94B00EF444A4363)/*cast due to constrained. prefix*/).ToString(),
			SteamName = B134B83DB77E4DA5((object)P_0.A94B00EF444A4363),
			Category = P_0._664A9756528C46FB.ToString(),
			Type = P_0.C6CB24124EA94C86.ToString(),
			Vl = P_1,
			Level = P_0.DAC7A80B62CA45B5.ToString(),
			Description = P_0._6C0F36D636E344A2
		};
		ILogger val = C179263454B44BF6._54DF173DA5E74DC3;
		IStringLocalizer val2 = C179263454B44BF6._66EFCEB30AD8408A;
		string text = _003CModule_003E._8B9C7B12B1AE4949<string>(1084203254);
		object[] array = new object[_003CModule_003E._390073C602714496<int>(-250964212)];
		array[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)] = anon;
		_4927C8F4D8314A07(val, FBAA544D7B7D4F66((LocalizedString)_15483B7C4DE54615((object)val2, text, array)), Array.Empty<object>());
		IEnumerator<CSteamID> enumerator = _2B9B820492184B13.GetEnumerator();
		try
		{
			SteamPlayer val3 = default;
			while (true)
			{
				int num;
				int num2;
				if (C00C5AAD0F344559((object)enumerator))
				{
					num = -2031721258;
					num2 = num;
				}
				else
				{
					num = -1147913153;
					num2 = num;
				}
				while (true)
				{
					int num3 = num;
					uint num4;
					switch ((num4 = (uint)(-((~num3 - (-216319183 ^ -(-1756933863 + (-250344010 + (0x4AC73A2E ^ 0x35E8CD60)))) + (((0xC51AD87 ^ 0x6626C19D) + (-unchecked(-67656494 * -1712054087) - ~(0x22835AB2 ^ 0x2AD902E0))) ^ (-1855523325 - unchecked(-1560933635 * unchecked(1229569161 * ~907380621))))) ^ 0x66C4B138) * 1675682881 - unchecked(-1805583583 - 2068803298) + -87241993)) % 5)
					{
					case 4u:
						num = -2031721258;
						continue;
					default:
						return;
					case 0u:
						break;
					case 3u:
					{
						IStringLocalizer val4 = C179263454B44BF6._66EFCEB30AD8408A;
						string text2 = _003CModule_003E._390073C602714496<string>(1773704066);
						object[] array2 = new object[_003CModule_003E._390073C602714496<int>(-250964212)];
						array2[_003CModule_003E._58ECCB512F2A43AC<int>(352679804)] = anon;
						B902554C47F4464A(FBAA544D7B7D4F66((LocalizedString)_15483B7C4DE54615((object)val4, text2, array2)), Color.white, (SteamPlayer)null, val3, (EChatMode)_003CModule_003E._58ECCB512F2A43AC<int>(1659754234), _003CModule_003E._8B9C7B12B1AE4949<string>(-1332434181), (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0);
						num = 356163674;
						continue;
					}
					case 1u:
					{
						val3 = (SteamPlayer)A6AC3C7AF8BD45FB(enumerator.Current);
						int num5;
						if (val3 == null)
						{
							num = 356163674;
							num5 = num;
						}
						else
						{
							num = -1512420353;
							num5 = num;
						}
						continue;
					}
					case 2u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_028b:
					int num6 = -1948953726;
					while (true)
					{
						int num3 = num6;
						uint num4;
						switch ((num4 = (uint)(-((~num3 - (-216319183 ^ -(-1756933863 + (-250344010 + (0x4AC73A2E ^ 0x35E8CD60)))) + (((0xC51AD87 ^ 0x6626C19D) + (-unchecked(-67656494 * -1712054087) - ~(0x22835AB2 ^ 0x2AD902E0))) ^ (-1855523325 - unchecked(-1560933635 * unchecked(1229569161 * ~907380621))))) ^ 0x66C4B138) * 1675682881 - unchecked(-1805583583 - 2068803298) + -87241993)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0290;
						case 2u:
							goto IL_038a;
						case 1u:
							goto end_IL_0290;
						}
						goto IL_028b;
						IL_038a:
						_249DA14D3CDF4E2B((object)enumerator);
						num6 = (int)((num4 * 1536460366) ^ 0x17C58E3E);
						continue;
						end_IL_0290:
						break;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void A2A0216051544893(_0447F941905C4653 P_0, C84D19F98EAA497F P_1, int P_2)
	{
		using List<_936A12B4AC454ECB>.Enumerator enumerator = _066516CC42564A38((object)P_0).GetEnumerator();
		_936A12B4AC454ECB current = default;
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 972568823;
				num2 = num;
			}
			else
			{
				num = 519840146;
				num2 = num;
			}
			while (true)
			{
				int num3 = num;
				uint num4;
				bool flag;
				switch ((num4 = (uint)(-((num3 - ~(-(-(-(0x50D2EE4B ^ 0x569F2662)) ^ -457207109))) * 378700971))) % 9)
				{
				case 7u:
					num = 972568823;
					continue;
				default:
					return;
				case 8u:
					current = enumerator.Current;
					num = 1011357804;
					continue;
				case 4u:
					_1669A60AED6B4CC6(current, P_1, P_2);
					num = ((int)num4 * -1584696696) ^ 0x68486F90;
					continue;
				case 2u:
					flag = P_2 % _2BF1530804C14F69((object)current) == _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563);
					goto IL_00c7;
				case 3u:
				{
					_936A12B4AC454ECB obj = current;
					int num7 = _8D91ECAC25454126((object)obj);
					_97DB94717BD64DFD((object)obj, num7 + _003CModule_003E._390073C602714496<int>(-250964212));
					num = 483181090;
					continue;
				}
				case 0u:
				{
					int num5;
					int num6;
					if (P_2 < AF9A167E4C734DA7((object)current))
					{
						num5 = 758679147;
						num6 = num5;
					}
					else
					{
						num5 = -755436015;
						num6 = num5;
					}
					num = num5 ^ (int)(num4 * 1968550143);
					continue;
				}
				case 6u:
					if (_2BF1530804C14F69((object)current) == 0)
					{
						flag = _8D91ECAC25454126((object)current) == _003CModule_003E._3F57E81A62734AC2<int>(-1803194042);
						goto IL_00c7;
					}
					num = ((int)num4 * -836834322) ^ -1696824577;
					continue;
				case 5u:
					break;
				case 1u:
					return;
					IL_00c7:
					if (flag)
					{
						num = -1380431471;
						continue;
					}
					break;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _1669A60AED6B4CC6(_936A12B4AC454ECB P_0, C84D19F98EAA497F P_1, int P_2)
	{
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		string text = _2D111E46D4B74A5F((object)P_0);
		string text4 = default;
		string text3 = default;
		while (true)
		{
			int num = 107058189;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(((0x1160C862 ^ 0x1FE0F8B3) - (-(num2 + -(~-2059560826)) ^ (374121649 * ~(-(-unchecked(-1425757283 * 456993078)))))) ^ -941062715))) % 14)
				{
				case 3u:
					break;
				default:
					return;
				case 5u:
				{
					int num8;
					if (!_48CBDE7A1DFC43EE((object)text, _003CModule_003E._3F57E81A62734AC2<string>(1056629219)))
					{
						num = -1811206103;
						num8 = num;
					}
					else
					{
						num = -1297478016;
						num8 = num;
					}
					continue;
				}
				case 9u:
					_9942B87C04F948C0(text4);
					_329F93EB41E14EBD(C179263454B44BF6._54DF173DA5E74DC3, _0E81E7AAE7F34DC6(_003CModule_003E._8B9C7B12B1AE4949<string>(1554035911), text4), Array.Empty<object>());
					num = -333345593;
					continue;
				case 4u:
					text4 = A4729F6607EC45A6(text, P_1, P_2);
					num = -600489196;
					continue;
				case 1u:
				{
					int num6;
					if (_1F726A27F65142D1(ConfigurationBinder.GetValue<string>(C179263454B44BF6.F4734FD3602D47CD, _003CModule_003E._390073C602714496<string>(1002865612), _003CModule_003E._58ECCB512F2A43AC<string>(692318299)) ?? _003CModule_003E._3F57E81A62734AC2<string>(-2142288665)))
					{
						num = -1255430499;
						num6 = num;
					}
					else
					{
						num = -1802261195;
						num6 = num;
					}
					continue;
				}
				case 6u:
				{
					int num7;
					if (!_48CBDE7A1DFC43EE((object)text, _003CModule_003E._58ECCB512F2A43AC<string>(-790302633)))
					{
						num = -978779568;
						num7 = num;
					}
					else
					{
						num = -18693638;
						num7 = num;
					}
					continue;
				}
				case 0u:
					return;
				case 8u:
					_329F93EB41E14EBD(C179263454B44BF6._54DF173DA5E74DC3, _0E81E7AAE7F34DC6(_003CModule_003E._390073C602714496<string>(32600959), text3), Array.Empty<object>());
					num = -690307177;
					continue;
				case 2u:
					return;
				case 7u:
				{
					int num4;
					int num5;
					if (_37AD32AB2C8A4F8F.Contains(_141C1FCE13204C7E((object)P_1.A94B00EF444A4363)))
					{
						num4 = 424841000;
						num5 = num4;
					}
					else
					{
						num4 = 28022829;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1166464007);
					continue;
				}
				case 10u:
					text3 = A4729F6607EC45A6(text, P_1, P_2);
					_684318500BA24C7C(text3, P_1, P_2);
					num = -1205907731;
					continue;
				case 11u:
					return;
				case 13u:
				{
					_37AD32AB2C8A4F8F.Add(_141C1FCE13204C7E((object)P_1.A94B00EF444A4363));
					string text2 = A4729F6607EC45A6(_25D56B31607C4A00((object)text, _3F60BFA5C3294102((object)_003CModule_003E.F84FA79ABE6944BB<string>(849192464))), P_1, P_2);
					_05B936A6095E4DC2(text2, _141C1FCE13204C7E((object)P_1.A94B00EF444A4363));
					_329F93EB41E14EBD(C179263454B44BF6._54DF173DA5E74DC3, _4805F74C00144828(_003CModule_003E.F84FA79ABE6944BB<string>(-522779692), (object)text2, (object)_141C1FCE13204C7E((object)P_1.A94B00EF444A4363)), Array.Empty<object>());
					num = -729591072;
					continue;
				}
				case 12u:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string A4729F6607EC45A6(string P_0, C84D19F98EAA497F P_1, int P_2)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		return A4755EE14EB54998((object)A4755EE14EB54998((object)A4755EE14EB54998((object)A4755EE14EB54998((object)A4755EE14EB54998((object)A4755EE14EB54998((object)P_0, _003CModule_003E._3F57E81A62734AC2<string>(-219143236), ((object)_141C1FCE13204C7E((object)P_1.A94B00EF444A4363)/*cast due to constrained. prefix*/).ToString()), _003CModule_003E._58ECCB512F2A43AC<string>(-1268293346), _4CEFA97A389F4CA1((object)P_1.A94B00EF444A4363)), _003CModule_003E._390073C602714496<string>(-984455667), P_2.ToString()), _003CModule_003E.F84FA79ABE6944BB<string>(1043351909), P_1.DAC7A80B62CA45B5.ToString()), _003CModule_003E.F84FA79ABE6944BB<string>(-991146819), P_1._664A9756528C46FB.ToString()), _003CModule_003E.F84FA79ABE6944BB<string>(-671613286), P_1.C6CB24124EA94C86.ToString());
	}

	private void _05B936A6095E4DC2(string P_0, CSteamID P_1)
	{
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		_113C547E3E7142C1 CS_0024_003C_003E8__locals7 = (_113C547E3E7142C1)_1BA897AD7E174710();
		while (true)
		{
			int num = 1553781001;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-((~num2 ^ (~(--167037196 - unchecked(-1285451831 * -212806323)) + (1272580934 + -(-193267245 ^ -1059350436)) + -(~(--953558700 + (-1605620242 ^ -41619452) + -2051137942)))) - ~(~(~(~(1034626636 - 1942660675))))) - unchecked(400695645 * (-323457416 + -1074270495 - ~571447220))))) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_009e;
				default:
					CS_0024_003C_003E8__locals7._0384B25C56404CA1 = P_1;
					_82D797296DB7464D(_44E3775C76EA45B6((Func<Task>)([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_113C547E3E7142C1.EEE742FC0CF449C0))] () =>
					{
						_113C547E3E7142C1.EEE742FC0CF449C0 stateMachine = default;
						stateMachine.C1847D8215D94467 = AsyncTaskMethodBuilder.Create();
						stateMachine._64F46CA2D9A9460B = CS_0024_003C_003E8__locals7;
						stateMachine._84D6E87F8C5A4575 = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
						stateMachine.C1847D8215D94467.Start(ref stateMachine);
						return stateMachine.C1847D8215D94467.Task;
					}), FB620365697A4B88((object)C8D0E9D0F9154ABD)), (Action<Task>)([MethodImpl(MethodImplOptions.NoInlining)] (Task task) =>
					{
						//IL_000c: Unknown result type (might be due to invalid IL or missing references)
						CS_0024_003C_003E8__locals7._4F2A4A2B5A524EAC._37AD32AB2C8A4F8F.Remove(CS_0024_003C_003E8__locals7._0384B25C56404CA1);
						while (true)
						{
							int num4 = 1978476971;
							while (true)
							{
								int num5 = num4;
								uint num6;
								switch ((num6 = (uint)(~((~num5 + (-(-(-(unchecked(212878595 * 591398309) - (-1263642888 + 2023586745)))) + -1619037054)) ^ 0x64E83486) + -801585244)) % 5)
								{
								case 4u:
									break;
								default:
									return;
								case 2u:
									_113C547E3E7142C1.E99233C7A0704294(C179263454B44BF6._54DF173DA5E74DC3, (Exception)_113C547E3E7142C1._5C10906946F44113((object)task), _113C547E3E7142C1.B95A9F7E9BDC4442(_003CModule_003E._3F57E81A62734AC2<string>(1429874209), CS_0024_003C_003E8__locals7.F7BEB86308454E76), Array.Empty<object>());
									num4 = -536814143;
									continue;
								case 0u:
								{
									object obj = _113C547E3E7142C1._5C10906946F44113((object)task);
									int num9;
									if (!(((obj != null) ? _113C547E3E7142C1.EA176019C2A24B73(obj) : null) is OperationCanceledException))
									{
										num4 = 2011287624;
										num9 = num4;
									}
									else
									{
										num4 = -536814143;
										num9 = num4;
									}
									continue;
								}
								case 1u:
								{
									int num7;
									int num8;
									if (_113C547E3E7142C1.DAEB7CD3A96843CB((object)task))
									{
										num7 = -1221224649;
										num8 = num7;
									}
									else
									{
										num7 = -859158100;
										num8 = num7;
									}
									num4 = num7 ^ (int)(num6 * 461937865);
									continue;
								}
								case 3u:
									return;
								}
								break;
							}
						}
					}), D6781066068D493C());
					return;
				}
				break;
				IL_009e:
				CS_0024_003C_003E8__locals7._4F2A4A2B5A524EAC = this;
				CS_0024_003C_003E8__locals7.F7BEB86308454E76 = P_0;
				num = ((int)num3 * -712021827) ^ -263985790;
			}
		}
	}

	private int CF1396A136BA4D05(IEnumerable<_57DE83A6944B4063> P_0, ECheckType P_1)
	{
		_2916CA89ED784421 CS_0024_003C_003E8__locals2 = (_2916CA89ED784421)_894810B9232947F6();
		while (true)
		{
			int num = 1957769686;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~(~(-(num2 ^ (~(~((unchecked(380839139 * -436842596) - -(0x1F90319E ^ 0x4ADABE8B)) * 1439702587)) - -unchecked(~unchecked(1180650377 * (-1668235887 ^ 0x3B3B6776)) - 893004612)))) * 154949951 * -1494795597) * 516436161))) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_007b;
				default:
					return P_0.Count([MethodImpl(MethodImplOptions.NoInlining)] (_57DE83A6944B4063 obj) =>
					{
						if (_2916CA89ED784421.A72ABEF8199F411B((object)obj) == CS_0024_003C_003E8__locals2.DBAB473878C84349)
						{
							while (true)
							{
								int num4 = -110540180;
								while (true)
								{
									int num5 = num4;
									uint num6;
									switch ((num6 = (uint)((-(~num5) + ((0x1F8DE5BA ^ 0x370259D5) - 102991228 + unchecked(-1451303661 * 831499765) - -(~-1588095241) * -1009595253) * -17992233) * -1992831995 * 458515941 + unchecked(~906629430 - ~-1813596424))) % 4)
									{
									case 2u:
										break;
									case 1u:
									{
										int num7;
										int num8;
										if (_2916CA89ED784421._4A7F806A51B44199((object)obj) == EFlagLevel.Shadow)
										{
											num7 = -93513453;
											num8 = num7;
										}
										else
										{
											num7 = 473000682;
											num8 = num7;
										}
										num4 = num7 ^ ((int)num6 * -490884780);
										continue;
									}
									case 3u:
										return ((_2916CA89ED784421._4A7F806A51B44199((object)obj) == (EFlagLevel)_003CModule_003E._8B9C7B12B1AE4949<int>(1083331464)) ? 1 : 0) == _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
									default:
										goto end_IL_0011;
									}
									break;
								}
								continue;
								end_IL_0011:
								break;
							}
						}
						return (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
					});
				}
				break;
				IL_007b:
				CS_0024_003C_003E8__locals2.DBAB473878C84349 = P_1;
				num = (int)((num3 * 1811930380) ^ 0x1A5A5E0);
			}
		}
	}

	private bool _539D90F5B14A40F1(_58C92E7ADC894CE6 P_0, ECheckType P_1, out _0447F941905C4653 P_2)
	{
		FAB38C0F2B6F4311 CS_0024_003C_003E8__locals2 = (FAB38C0F2B6F4311)AD4C7A1A2ED54A34();
		CS_0024_003C_003E8__locals2._6623045666DC4AFA = P_1;
		P_2 = _18821157D5754512((object)P_0).FirstOrDefault((_0447F941905C4653 obj) => FAB38C0F2B6F4311._3A00259073824DED((object)obj) == CS_0024_003C_003E8__locals2._6623045666DC4AFA);
		return P_2 != null;
	}

	private void _684318500BA24C7C(string P_0, C84D19F98EAA497F P_1, int P_2)
	{
		_7497D9F457FE469E CS_0024_003C_003E8__locals6 = (_7497D9F457FE469E)EE42452E13184BF0();
		CS_0024_003C_003E8__locals6._5B4B7697703F4FD3 = P_1;
		while (true)
		{
			int num = 24156714;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-((num2 + ((((1169725603 * ~(--107163897)) ^ -1965174712) - (0x4504F217 ^ -(--961888118 + (-655067767 + 1297120337)))) ^ -unchecked((0x50136236 ^ 0xB018CCC) * 470443429)) * 1130970627) * 1113488605 * 1405877791 - (-687137818 - -753371697))) + unchecked(640856407 + 2087056378) - 218329105)) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_00bf;
				case 0u:
					return;
				}
				break;
				IL_00bf:
				CS_0024_003C_003E8__locals6.BAC6841A32394DA4 = P_0;
				CS_0024_003C_003E8__locals6._550E641997CB4191 = this;
				CS_0024_003C_003E8__locals6._32B8578766084E5D = P_2;
				_82D797296DB7464D(_44E3775C76EA45B6((Func<Task>)([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_7497D9F457FE469E.C0F33B48397C4DE5))] () =>
				{
					_7497D9F457FE469E.C0F33B48397C4DE5 stateMachine = default;
					stateMachine._63400D810FA34AAA = AsyncTaskMethodBuilder.Create();
					while (true)
					{
						int num4 = 1590149600;
						while (true)
						{
							int num5 = num4;
							uint num6;
							switch ((num6 = (uint)((-1324126845 * -(~1574569285) * 1693039467 + (0x3E3D0FDA ^ 0x1CF77770) - ((-452128955 * -(--1748865371 + (185268828 - -1622785902))) ^ -1173323731) - (num5 ^ (-333708787 * -598353435)) - -1259083680) ^ (--1491501398 + (0x2489FB8 ^ --2090692212)))) % 3)
							{
							case 0u:
								break;
							case 1u:
								goto IL_00b6;
							default:
								stateMachine._63400D810FA34AAA.Start(ref stateMachine);
								return stateMachine._63400D810FA34AAA.Task;
							}
							break;
							IL_00b6:
							stateMachine._97791D36F9154A0A = CS_0024_003C_003E8__locals6;
							stateMachine._4EECB1A078D847A7 = _003CModule_003E._390073C602714496<int>(-736908096);
							num4 = 1902607827;
						}
					}
				}), FB620365697A4B88((object)C8D0E9D0F9154ABD)), (Action<Task>)([MethodImpl(MethodImplOptions.NoInlining)] (Task task) =>
				{
					//IL_0125: Unknown result type (might be due to invalid IL or missing references)
					if (_7497D9F457FE469E._36E33CD64E4C4CD6((object)task))
					{
						while (true)
						{
							int num4 = 1657483;
							while (true)
							{
								int num5 = num4;
								uint num6;
								switch ((num6 = (uint)(((~(-(num5 * 1111335553 - (~((-unchecked(1390862068 + 1383668291) - -(-2089136309 ^ 0xE6BF31F)) ^ ~(--746720819 ^ -113292113)) - (-(0x37CBC21B ^ -unchecked(947538377 * -293446039)) - -((--1434931991 ^ 0xD2C5AAF) - ((-1187399829 ^ -464762648) - --558814703)))))) + ~-1380518981 - (-97594901 ^ -1595462440)) ^ -1924523869) - 493172096)) % 4)
								{
								case 3u:
									break;
								default:
									return;
								case 1u:
								{
									object obj = _7497D9F457FE469E._93BB358F82C243E8((object)task);
									int num7;
									if (!(((obj != null) ? _7497D9F457FE469E._7850E93C6DB34E61(obj) : null) is OperationCanceledException))
									{
										num4 = -451562756;
										num7 = num4;
									}
									else
									{
										num4 = 2138191578;
										num7 = num4;
									}
									continue;
								}
								case 0u:
									_7497D9F457FE469E._9711AC85792B453C(C179263454B44BF6._54DF173DA5E74DC3, (Exception)_7497D9F457FE469E._93BB358F82C243E8((object)task), _7497D9F457FE469E.C8D18125A5B14A0C(_003CModule_003E._390073C602714496<string>(-1266104007), (object)_7497D9F457FE469E._78D12C3B593C4A4D((object)CS_0024_003C_003E8__locals6._5B4B7697703F4FD3.A94B00EF444A4363)), Array.Empty<object>());
									num4 = 2138191578;
									continue;
								case 2u:
									return;
								}
								break;
							}
						}
					}
				}), D6781066068D493C());
				num = ((int)num3 * -2146878902) ^ 0x6A8F6014;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(BF0698DA304A4D6A))]
	private Task<byte[]?> ED0C51F934CF49A8(SteamPlayer P_0, TimeSpan P_1)
	{
		BF0698DA304A4D6A stateMachine = default;
		stateMachine._9364289E96224C21 = AsyncTaskMethodBuilder<byte[]>.Create();
		while (true)
		{
			int num = 1212475089;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-(-(-873327753 - (-1860552524 - ~(num2 * 1104643297)))) - unchecked(-2011518951 * -602928153)) * 1669241075)) % 4)
				{
				case 0u:
					break;
				case 2u:
					stateMachine._11C140A301E54B49 = P_0;
					num = ((int)num3 * -1587318464) ^ 0x36BEE29E;
					continue;
				case 3u:
					stateMachine.DFFC0D54A1FF4F65 = P_1;
					stateMachine.CBEEB49A71BC4CA1 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120);
					stateMachine._9364289E96224C21.Start(ref stateMachine);
					num = 1369171080;
					continue;
				default:
					return stateMachine._9364289E96224C21.Task;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_8D086FF5304A4147))]
	private Task<(byte[] data, string format, Guid transactionId)?> F6F9070F6A9B4252(SteamPlayer P_0, TimeSpan P_1)
	{
		_8D086FF5304A4147 stateMachine = default;
		stateMachine.B85185EF0B224329 = AsyncTaskMethodBuilder<(byte[], string, Guid)?>.Create();
		stateMachine._904D5959DD964417 = this;
		stateMachine._856CB7B72A2C4F85 = P_0;
		stateMachine._86D34DC7CA7B4A83 = P_1;
		stateMachine._8025C20B67B64453 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
		stateMachine.B85185EF0B224329.Start(ref stateMachine);
		return stateMachine.B85185EF0B224329.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(DF3265EC97554FF2))]
	private Task<_6BD76CD39E2A4E73?> DE3CCAE06F70472C(Guid P_0, TimeSpan P_1)
	{
		DF3265EC97554FF2 stateMachine = default;
		stateMachine._2FB06B6F897449E2 = AsyncTaskMethodBuilder<_6BD76CD39E2A4E73>.Create();
		stateMachine._40E6FA6F21234C2C = this;
		stateMachine.E298C166FFA54C6F = P_0;
		while (true)
		{
			int num = -763358708;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~-1979576471) * -360320099 - ~(-1111207313 * --1997733437 - num2) * -310892343)) % 4)
				{
				case 0u:
					break;
				case 2u:
					stateMachine.AA0218AFDB744041 = P_1;
					stateMachine._2DD2148528D944CF = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
					num = -1512223351;
					continue;
				case 1u:
					stateMachine._2FB06B6F897449E2.Start(ref stateMachine);
					num = (int)(num3 * 1806085228) ^ -210966577;
					continue;
				default:
					return stateMachine._2FB06B6F897449E2.Task;
				}
				break;
			}
		}
	}

	private void AF648FF29706486F(_58C92E7ADC894CE6 P_0, _0447F941905C4653 P_1)
	{
		_2031CC5701C34566 CS_0024_003C_003E8__locals4 = (_2031CC5701C34566)_2E1CCD8658A6423F();
		CS_0024_003C_003E8__locals4._0C89D56BA7364B39 = P_1;
		CS_0024_003C_003E8__locals4._70981B4BDD564FD6 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
		_2A035A8D06F347C5((object)P_0).RemoveAll((_57DE83A6944B4063 obj) => CS_0024_003C_003E8__locals4._70981B4BDD564FD6 - _2031CC5701C34566._6C282486723747BE((object)obj) > _2031CC5701C34566._0549D438EB594BDD((object)CS_0024_003C_003E8__locals4._0C89D56BA7364B39));
	}

	public _58C92E7ADC894CE6? _43E12F1680A74674(CSteamID P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		F16BE55E1EE94732.TryGetValue(P_0, out _58C92E7ADC894CE6 value);
		return value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public (IEnumerable<_57DE83A6944B4063> Data, int TotalPages) _91E225D4F2EB4609(CSteamID P_0, int P_1)
	{
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		if (P_1 >= _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
		{
			List<_57DE83A6944B4063> list = default;
			_58C92E7ADC894CE6 value = default;
			while (true)
			{
				int num = -972270980;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~((-223894703 ^ 0x69CF3310) - ~((1308930147 * ((-(-unchecked(834591989 * -682628403)) ^ -((0x73E711CB ^ -1693601389) - -245704183)) + (unchecked(1633307569 * -310738807) - unchecked(-942672553 * (0x1AD32189 ^ -1983011752)))) - -num2) ^ ~(-(-308837477 * --1082777479) - (-1515333557 ^ -1578390420)))))) % 7)
					{
					case 5u:
						break;
					case 3u:
						return (Data: Array.Empty<_57DE83A6944B4063>(), TotalPages: _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
					case 1u:
						goto end_IL_0012;
					case 0u:
						goto IL_012a;
					case 2u:
						goto IL_014e;
					case 6u:
						list = _2A035A8D06F347C5((object)value);
						num = 600372689;
						continue;
					default:
					{
						bool flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
						List<_57DE83A6944B4063> source;
						try
						{
							CC8376A4C38A41F6((object)list, ref flag);
							source = _2A035A8D06F347C5((object)value).ToList();
						}
						finally
						{
							if (flag)
							{
								while (true)
								{
									IL_01b0:
									int num4 = 140785134;
									while (true)
									{
										num2 = num4;
										switch ((num3 = (uint)(~((-223894703 ^ 0x69CF3310) - ~((1308930147 * ((-(-unchecked(834591989 * -682628403)) ^ -((0x73E711CB ^ -1693601389) - -245704183)) + (unchecked(1633307569 * -310738807) - unchecked(-942672553 * (0x1AD32189 ^ -1983011752)))) - -num2) ^ ~(-(-308837477 * --1082777479) - (-1515333557 ^ -1578390420)))))) % 3)
										{
										case 2u:
											break;
										default:
											goto end_IL_01b5;
										case 1u:
											goto IL_026c;
										case 0u:
											goto end_IL_01b5;
										}
										goto IL_01b0;
										IL_026c:
										_3E929CB8CFA8443C((object)list);
										num4 = ((int)num3 * -1461244982) ^ 0x66BD43D6;
										continue;
										end_IL_01b5:
										break;
									}
									break;
								}
							}
						}
						List<_57DE83A6944B4063> list2 = source.OrderBy((_57DE83A6944B4063 obj) => B199BB1D204541ED._0C99CCE541034D1B((object)obj)).ToList();
						return new ValueTuple<IEnumerable<_57DE83A6944B4063>, int>(item2: (int)D88CDAEBA46A4CE6((double)list2.Count / _003CModule_003E._3F57E81A62734AC2<double>(804808823)), item1: list2.Skip((P_1 - _003CModule_003E._3F57E81A62734AC2<int>(1017304263)) * _003CModule_003E.F84FA79ABE6944BB<int>(695290574)).Take(_003CModule_003E._8B9C7B12B1AE4949<int>(-1623702770)));
					}
					}
					break;
					IL_014e:
					int num5;
					if (P_1 > _003CModule_003E._58ECCB512F2A43AC<int>(-1328138632))
					{
						num = -659455224;
						num5 = num;
					}
					else
					{
						num = -169914396;
						num5 = num;
					}
					continue;
					IL_012a:
					int num6;
					if (!F16BE55E1EE94732.TryGetValue(P_0, out value))
					{
						num = -568712907;
						num6 = num;
					}
					else
					{
						num = -993621991;
						num6 = num;
					}
				}
				continue;
				end_IL_0012:
				break;
			}
		}
		throw _74A1C28597124D2A(_003CModule_003E._3F57E81A62734AC2<string>(-1378550055), _003CModule_003E._3F57E81A62734AC2<string>(-1827226493));
	}

	public void DE1F41CD69D248AC(CSteamID P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		F16BE55E1EE94732.TryRemove(P_0, out _58C92E7ADC894CE6 _);
	}

	public _58C92E7ADC894CE6? _5E3E15C29E0A41E4(CSteamID P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		F16BE55E1EE94732.TryRemove(P_0, out _58C92E7ADC894CE6 value);
		return value;
	}

	public virtual void BBBE2276E72D4653()
	{
		_16B622734A3B4BB1((object)C8D0E9D0F9154ABD);
		((Channel<C84D19F98EAA497F, C84D19F98EAA497F>)(object)_619449577E0148F4).Writer.Complete((Exception)null);
		_2E11BA866AF64FE8((object)C8D0E9D0F9154ABD);
		_0C75EFE7EED147F9();
	}

	[CompilerGenerated]
	private Task F4FBCD766A02480A()
	{
		FB620365697A4B88((object)C8D0E9D0F9154ABD);
		_408AEEE548064800(default);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private _58C92E7ADC894CE6 _7527869DF8F34FCB(CSteamID P_0)
	{
		object obj = _5117E882064249C0;
		bool flag = (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0;
		try
		{
			CC8376A4C38A41F6(obj, ref flag);
			object obj2 = _7FC0ED74141B4E31();
			B01DDECE6CBF4085(obj2, _3AD1B11BAAF840BA.Select((_0447F941905C4653 obj3) => (_0447F941905C4653)B199BB1D204541ED._54B081F580B247ED((object)obj3)).ToList());
			return (_58C92E7ADC894CE6)obj2;
		}
		finally
		{
			if (flag)
			{
				while (true)
				{
					IL_0062:
					int num = 257061851;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-(-(-((((-(-(--182633996)) - ~(0x48995ABD ^ -333109855)) ^ -1456186834 ^ ~((-388007398 ^ 0x4E4118) - -(~-585828427) - -(~(--548057148)))) * 184823471 - num2) * 2029789447) * 2147294115)) * 1510236403) ^ 0xFEAB0A6)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0067;
						case 1u:
							goto IL_0121;
						case 2u:
							goto end_IL_0067;
						}
						goto IL_0062;
						IL_0121:
						_3E929CB8CFA8443C(obj);
						num = (int)((num3 * 600912833) ^ 0xC91A1F4);
						continue;
						end_IL_0067:
						break;
					}
					break;
				}
			}
		}
	}

	static object _354F80C02D9F4151()
	{
		return new CancellationTokenSource();
	}

	static object _89B4055E65CA46C4()
	{
		return new object();
	}

	static void _414C8056DA234214(object P_0)
	{
		((E651E17AA2CA4BC8)P_0).F08FFF64C62C4F0A();
	}

	static object _6C0CDBF8ED8448DD(Func<Task> P_0)
	{
		return Task.Run(P_0);
	}

	static object E5B5860E064347F2(object P_0, string P_1)
	{
		return ((IConfiguration)P_0).GetSection(P_1);
	}

	static IEnumerable<IConfigurationSection> BA6F90C10F904078(object P_0)
	{
		return ((IConfiguration)P_0).GetChildren();
	}

	static string DAAD3D166E1B4A1A(object P_0)
	{
		return ((IConfigurationSection)P_0).Key;
	}

	static string[] _17B6D1A64CBC47EB(object P_0, char P_1, int P_2, StringSplitOptions P_3)
	{
		return ((string)P_0).Split(P_1, P_2, P_3);
	}

	static string[] A72A8C1E50EF46CF(object P_0, char P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split(P_1, P_2);
	}

	static string _0E81E7AAE7F34DC6(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static void _4927C8F4D8314A07(ILogger P_0, string P_1, object[] P_2)
	{
		LoggerExtensions.LogWarning(P_0, P_1, P_2);
	}

	static object _47A23300007E463A()
	{
		return new _936A12B4AC454ECB();
	}

	static void _0A802C26116041E1(object P_0, int P_1)
	{
		((_936A12B4AC454ECB)P_0).C1633EF59737414E = P_1;
	}

	static void CAEECE0ED3F04A19(object P_0, int P_1)
	{
		((_936A12B4AC454ECB)P_0).B3E1F396768D43AF = P_1;
	}

	static void B40F668366BB4E13(object P_0, string P_1)
	{
		((_936A12B4AC454ECB)P_0)._7F318BFB41FF4365 = P_1;
	}

	static object _096B4C28AE4B4B79()
	{
		return new _0447F941905C4653();
	}

	static void E98C95786A2F4335(object P_0, ECheckCategory P_1)
	{
		((_0447F941905C4653)P_0)._57B94C00CD654639 = P_1;
	}

	static void DAB52F173B794A9E(object P_0, ECheckType P_1)
	{
		((_0447F941905C4653)P_0)._2B86A443CB024E20 = P_1;
	}

	static void _219B4ED872854FF2(object P_0, List<_936A12B4AC454ECB> P_1)
	{
		((_0447F941905C4653)P_0)._624381EEC42D4D8C = P_1;
	}

	static void C5347FD88D014E98(object P_0, int P_1)
	{
		((_0447F941905C4653)P_0).EE92B8CFE44149FB = P_1;
	}

	static bool C00C5AAD0F344559(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	static void _249DA14D3CDF4E2B(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static void B66E6898F3174F5A(ILogger P_0, Exception P_1, string P_2, object[] P_3)
	{
		LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
	}

	static void CC8376A4C38A41F6(object P_0, ref bool P_1)
	{
		Monitor.Enter(P_0, ref P_1);
	}

	static void _3E929CB8CFA8443C(object P_0)
	{
		Monitor.Exit(P_0);
	}

	static CSteamID _141C1FCE13204C7E(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((SteamPlayerID)P_0).steamID;
	}

	static List<_57DE83A6944B4063> _2A035A8D06F347C5(object P_0)
	{
		return ((_58C92E7ADC894CE6)P_0).D17F6A7C79614A4D;
	}

	static object AA40D04FC20646AC()
	{
		return new _57DE83A6944B4063();
	}

	static void _8C6D4A534A404B5E(object P_0, ECheckCategory P_1)
	{
		((_57DE83A6944B4063)P_0)._846B312DABE64B32 = P_1;
	}

	static void E04001CD16664FE3(object P_0, ECheckType P_1)
	{
		((_57DE83A6944B4063)P_0)._0BF1E0A59047451B = P_1;
	}

	static void BDB3971EBC7D4E1A(object P_0, EFlagLevel P_1)
	{
		((_57DE83A6944B4063)P_0).CFCEBCA7D5D243BB = P_1;
	}

	static void _0316360DA0DA417F(object P_0, long P_1)
	{
		((_57DE83A6944B4063)P_0).CCC125B916614E35 = P_1;
	}

	static void _127DA1BE39FF4CDD(object P_0, string P_1)
	{
		((_57DE83A6944B4063)P_0)._2506BD1A25634E70 = P_1;
	}

	static string B134B83DB77E4DA5(object P_0)
	{
		return ((SteamPlayerID)P_0).characterName;
	}

	static object _15483B7C4DE54615(object P_0, string P_1, object[] P_2)
	{
		return ((IStringLocalizer)P_0)[P_1, P_2];
	}

	static string FBAA544D7B7D4F66(LocalizedString P_0)
	{
		return LocalizedString.op_Implicit(P_0);
	}

	static object A6AC3C7AF8BD45FB(CSteamID P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return PlayerTool.getSteamPlayer(P_0);
	}

	static void B902554C47F4464A(string P_0, Color P_1, SteamPlayer P_2, SteamPlayer P_3, EChatMode P_4, string P_5, bool P_6)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		ChatManager.serverSendMessage(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
	}

	static List<_936A12B4AC454ECB> _066516CC42564A38(object P_0)
	{
		return ((_0447F941905C4653)P_0)._624381EEC42D4D8C;
	}

	static int AF9A167E4C734DA7(object P_0)
	{
		return ((_936A12B4AC454ECB)P_0).C1633EF59737414E;
	}

	static int _2BF1530804C14F69(object P_0)
	{
		return ((_936A12B4AC454ECB)P_0).B3E1F396768D43AF;
	}

	static int _8D91ECAC25454126(object P_0)
	{
		return ((_936A12B4AC454ECB)P_0).BEBAB13BD3DC4CE0;
	}

	static void _97DB94717BD64DFD(object P_0, int P_1)
	{
		((_936A12B4AC454ECB)P_0).BEBAB13BD3DC4CE0 = P_1;
	}

	static string _2D111E46D4B74A5F(object P_0)
	{
		return ((_936A12B4AC454ECB)P_0)._7F318BFB41FF4365;
	}

	static bool _48CBDE7A1DFC43EE(object P_0, string P_1)
	{
		return ((string)P_0).StartsWith(P_1);
	}

	static int _3F60BFA5C3294102(object P_0)
	{
		return ((string)P_0).Length;
	}

	static string _25D56B31607C4A00(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	static string _4805F74C00144828(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static void _329F93EB41E14EBD(ILogger P_0, string P_1, object[] P_2)
	{
		LoggerExtensions.LogDebug(P_0, P_1, P_2);
	}

	static bool _1F726A27F65142D1(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static void _9942B87C04F948C0(string P_0)
	{
		_64A4BBC5E4CE4EE1.E6DC166DE03C47D7(P_0);
	}

	static string A4755EE14EB54998(object P_0, string P_1, string P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	static string _4CEFA97A389F4CA1(object P_0)
	{
		return ((SteamPlayerID)P_0).playerName;
	}

	static object _1BA897AD7E174710()
	{
		return new _113C547E3E7142C1();
	}

	static CancellationToken FB620365697A4B88(object P_0)
	{
		return ((CancellationTokenSource)P_0).Token;
	}

	static object _44E3775C76EA45B6(Func<Task> P_0, CancellationToken P_1)
	{
		return Task.Run(P_0, P_1);
	}

	static object D6781066068D493C()
	{
		return TaskScheduler.Default;
	}

	static object _82D797296DB7464D(object P_0, Action<Task> P_1, object P_2)
	{
		return ((Task)P_0).ContinueWith(P_1, (TaskScheduler)P_2);
	}

	static object _894810B9232947F6()
	{
		return new _2916CA89ED784421();
	}

	static object AD4C7A1A2ED54A34()
	{
		return new FAB38C0F2B6F4311();
	}

	static List<_0447F941905C4653> _18821157D5754512(object P_0)
	{
		return ((_58C92E7ADC894CE6)P_0)._0120FF3B09FB4FD5;
	}

	static object EE42452E13184BF0()
	{
		return new _7497D9F457FE469E();
	}

	static object _2E1CCD8658A6423F()
	{
		return new _2031CC5701C34566();
	}

	static object _74A1C28597124D2A(string P_0, string P_1)
	{
		return new ArgumentOutOfRangeException(P_0, P_1);
	}

	static double D88CDAEBA46A4CE6(double P_0)
	{
		return Math.Ceiling(P_0);
	}

	static void _16B622734A3B4BB1(object P_0)
	{
		((CancellationTokenSource)P_0).Cancel();
	}

	static void _2E11BA866AF64FE8(object P_0)
	{
		((CancellationTokenSource)P_0).Dispose();
	}

	void _0C75EFE7EED147F9()
	{
		base.Dispose();
	}

	static object _7FC0ED74141B4E31()
	{
		return new _58C92E7ADC894CE6();
	}

	static void B01DDECE6CBF4085(object P_0, List<_0447F941905C4653> P_1)
	{
		((_58C92E7ADC894CE6)P_0)._0120FF3B09FB4FD5 = P_1;
	}
}
