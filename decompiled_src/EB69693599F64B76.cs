using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;

internal class EB69693599F64B76
{
	private class _89831CDD121E4CF1 : Exception
	{
		public _89831CDD121E4CF1(string P_0)
			: base(P_0)
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class CF8ECF9FCDB04818
	{
		public static readonly CF8ECF9FCDB04818 _003C_003E9 = (CF8ECF9FCDB04818)EE4A0A703C8C4163();

		public static Func<_652C34B1E6554F10, Task> _003C_003E9__39_0;

		public static Func<Task> _003C_003E9__39_1;

		public static Func<Task> _003C_003E9__39_2;

		public static Func<WebSocketCloseStatus?, string?, bool, bool, Task> _003C_003E9__39_3;

		public static Func<Task> _003C_003E9__39_4;

		public static Func<Task> _003C_003E9__39_5;

		internal Task EA2D04D1F91D416D(_652C34B1E6554F10 P_0)
		{
			return (Task)_4F5303B726724A57();
		}

		internal Task BADA0EAE66F744A3()
		{
			return (Task)_4F5303B726724A57();
		}

		internal Task _458E6A47489D47CC()
		{
			return (Task)_4F5303B726724A57();
		}

		internal Task DACE7B0AD196417D(WebSocketCloseStatus? P_0, string? P_1, bool P_2, bool P_3)
		{
			return (Task)_4F5303B726724A57();
		}

		internal Task _9E817DA30DC948B3()
		{
			return (Task)_4F5303B726724A57();
		}

		internal Task F46485CCB5A847B4()
		{
			return (Task)_4F5303B726724A57();
		}

		static object EE4A0A703C8C4163()
		{
			return new CF8ECF9FCDB04818();
		}

		static object _4F5303B726724A57()
		{
			return Task.CompletedTask;
		}
	}

	[CompilerGenerated]
	private sealed class _75188EBF12FF4CD0<_0001> where _0001 : notnull, _652C34B1E6554F10
	{
		public TaskCompletionSource<_652C34B1E6554F10> E937C06F91DE4985;

		internal void _2834FAE2C3444D5B()
		{
			E937C06F91DE4985.TrySetCanceled();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _375C35207D974AE3 : IAsyncStateMachine
	{
		public int CEFE1065EA0143C2;

		public AsyncTaskMethodBuilder _94F1528B93864B4A;

		public EB69693599F64B76 _40370AE8D56847E1;

		public bool _09CE08861BC54079;

		public bool C56A43B2E86B4D82;

		public string _921E32759C4B49BD;

		public WebSocketCloseStatus _3488156B597643EA;

		private TaskAwaiter _805AD3AF656B4B06;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1330063739u);
			TaskAwaiter awaiter = default;
			int num4 = default;
			while (true)
			{
				int num = -977750822;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(((575812599 + 1271501530 + (0x49228E21 ^ -250353555) + (~1111032752 - unchecked(2126644160 + 549961906)) - ((-num2 ^ (--1126886070 ^ ~(-unchecked(2144378223 - unchecked(1273254190 - -1621818948)) ^ (-(~-758559169) * 1891527981)))) + ~((~(-1490532194) ^ (--686170480 + (247510353 - -1291130941))) - -1761624692) + 1553002341) - -2087578933) ^ --1559356663) - 5391005)) % 3)
					{
					case 0u:
						break;
					case 2u:
						goto IL_00bd;
					default:
						{
							EB69693599F64B76 eB69693599F64B = _40370AE8D56847E1;
							try
							{
								obj._184044A093C04AF2(6, 1096699273u);
								if (num4 != 0)
								{
									goto IL_00f2;
								}
								goto IL_035d;
								IL_00f2:
								int num5 = -346468615;
								goto IL_00f7;
								IL_00f7:
								while (true)
								{
									num2 = num5;
									switch ((num3 = (uint)(((575812599 + 1271501530 + (0x49228E21 ^ -250353555) + (~1111032752 - unchecked(2126644160 + 549961906)) - ((-num2 ^ (--1126886070 ^ ~(-unchecked(2144378223 - unchecked(1273254190 - -1621818948)) ^ (-(~-758559169) * 1891527981)))) + ~((~(-1490532194) ^ (--686170480 + (247510353 - -1291130941))) - -1761624692) + 1553002341) - -2087578933) ^ --1559356663) - 5391005)) % 10)
									{
									case 8u:
										break;
									case 0u:
										obj = new _81DD83B8AA2247AA(2181359974u);
										num5 = ((int)num3 * -1743506629) ^ 0x210216F6;
										continue;
									case 3u:
										awaiter = _49175FBD15174E84((object)eB69693599F64B._2BBC551851794EDE(_09CE08861BC54079, C56A43B2E86B4D82, _3488156B597643EA, _921E32759C4B49BD));
										num5 = ((int)num3 * -1282328974) ^ -628299967;
										continue;
									case 5u:
									{
										_5E780D61DAD9496E obj2 = eB69693599F64B._2BBF92E607BB475E;
										obj._184044A093C04AF2(7, 3293200021u);
										obj._184044A093C04AF2(9, 2659772587u);
										obj._184044A093C04AF2(6, 3166629556u);
										_9D45C4620FDE4687((object)obj2, _05E833F559254D16(_003CModule_003E.F84FA79ABE6944BB<string>(-175200954 ^ (int)obj._184044A093C04AF2(0, 2170692093u)), (object)_09CE08861BC54079, (object)C56A43B2E86B4D82, (object)_921E32759C4B49BD), Array.Empty<object>());
										num5 = ((int)num3 * -1156702450) ^ -467893975;
										continue;
									}
									case 1u:
										_805AD3AF656B4B06 = awaiter;
										_94F1528B93864B4A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										goto end_IL_00de;
									case 9u:
									{
										int num6;
										int num7;
										if (!awaiter.IsCompleted)
										{
											num6 = -909392519;
											num7 = num6;
										}
										else
										{
											num6 = -643739113;
											num7 = num6;
										}
										num5 = num6 ^ ((int)num3 * -933820079);
										continue;
									}
									case 4u:
										_805AD3AF656B4B06 = default;
										obj._184044A093C04AF2(8, 2170692093u);
										obj._184044A093C04AF2(5, 2659772587u);
										obj._184044A093C04AF2(2, 3166629556u);
										num4 = (CEFE1065EA0143C2 = _003CModule_003E._3F57E81A62734AC2<int>(-1042573643 ^ (int)obj._184044A093C04AF2(3, 3293200021u)));
										num5 = (int)(num3 * 729360565) ^ -1093332668;
										continue;
									case 7u:
										goto IL_035d;
									case 2u:
										num4 = (CEFE1065EA0143C2 = _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x2450499A ^ obj._184044A093C04AF2(4, 1469910604u))));
										num5 = (int)(num3 * 1100589920) ^ -784255207;
										continue;
									default:
										obj = new _81DD83B8AA2247AA(1398823574u);
										awaiter.GetResult();
										goto IL_041a;
									}
									break;
								}
								goto IL_00f2;
								IL_035d:
								awaiter = _805AD3AF656B4B06;
								num5 = -306616578;
								goto IL_00f7;
								end_IL_00de:;
							}
							catch (Exception ex)
							{
								obj = new _81DD83B8AA2247AA(1231883291u);
								Exception exception = ex;
								obj._184044A093C04AF2(2, 1434362013u);
								obj._184044A093C04AF2(1, 2073042443u);
								obj._184044A093C04AF2(11, 2715808053u);
								CEFE1065EA0143C2 = _003CModule_003E._58ECCB512F2A43AC<int>(-1969796842 ^ (int)obj._184044A093C04AF2(8, 1836926481u));
								_94F1528B93864B4A.SetException(exception);
							}
							goto IL_046d;
						}
						IL_041a:
						obj._184044A093C04AF2(6, 3783126384u);
						obj._184044A093C04AF2(5, 1704747728u);
						obj._184044A093C04AF2(0, 3238537532u);
						CEFE1065EA0143C2 = _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x678070FF ^ obj._184044A093C04AF2(7, 1731119408u)));
						_94F1528B93864B4A.SetResult();
						goto IL_046d;
						IL_046d:
						obj = new _81DD83B8AA2247AA(1753664908u);
						return;
					}
					break;
					IL_00bd:
					num4 = CEFE1065EA0143C2;
					num = ((int)num3 * -708183042) ^ 0x566766C5;
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
			_94F1528B93864B4A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static string _05E833F559254D16(string P_0, object P_1, object P_2, object P_3)
		{
			return string.Format(P_0, P_1, P_2, P_3);
		}

		static void _9D45C4620FDE4687(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._4A918CD4B86142EF(P_1, P_2);
		}

		static TaskAwaiter _49175FBD15174E84(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct E07C0FAB04EC401D : IAsyncStateMachine
	{
		public int AEBCED4422F24F2D;

		public AsyncTaskMethodBuilder<bool> _75095D08D7534843;

		public CancellationToken _9BA4FE3B01B64224;

		public EB69693599F64B76 F37EA293814240E4;

		public Uri D2957516A9AA48D1;

		private string B8472611B8EA4A83;

		private CancellationTokenSource C7269FC6D3884B08;

		private CancellationTokenSource _4E663245309E4CFA;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter B29CF48A4F7747CC;

		private TaskAwaiter _4339C8585745431B;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_75095D08D7534843.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static void _66AF5486CD804036(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._4A918CD4B86142EF(P_1, P_2);
		}

		static WebSocketState _13A237A8C90142F3(object P_0)
		{
			return ((WebSocket)P_0).State;
		}

		static string BB8F1B3F12BB43D3(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void E2AC1B6C53C649D7(object P_0)
		{
			((WebSocket)P_0).Dispose();
		}

		static object D5ED10A5328647CC()
		{
			return new ClientWebSocket();
		}

		static object F3DED0EFBB9A41A3(object P_0)
		{
			return ((ClientWebSocket)P_0).Options;
		}

		static void _73FCF6753D274D4C(object P_0, string P_1, string P_2)
		{
			((ClientWebSocketOptions)P_0).SetRequestHeader(P_1, P_2);
		}

		static void _5C2073F713344AE3(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._753ADD0FDF864829(P_1, P_2);
		}

		static object _350725BB7D604C8F(TimeSpan P_0)
		{
			return new CancellationTokenSource(P_0);
		}

		static CancellationToken B4DE0124A32D4EB2(object P_0)
		{
			return ((CancellationTokenSource)P_0).Token;
		}

		static object BE76D893BDD743F1(CancellationToken P_0, CancellationToken P_1)
		{
			return CancellationTokenSource.CreateLinkedTokenSource(P_0, P_1);
		}

		static object _9DCD27F80D0E4256(object P_0, object P_1, CancellationToken P_2)
		{
			return ((ClientWebSocket)P_0).ConnectAsync((Uri)P_1, P_2);
		}

		static ConfiguredTaskAwaitable EC62DAD24FC341F0(object P_0, bool P_1)
		{
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		static string _6BBA9B1CF1844DE6(int P_0)
		{
			return _0E002E61EDA64248._459859367B31489C(P_0);
		}

		static (string, string) AE259C432A4142DA(string P_0, string P_1)
		{
			return _0E002E61EDA64248.D94ACEF1DC354E7E(P_0, P_1);
		}

		static object _353DA22C2E5C4F0C(string P_0, string P_1, string P_2)
		{
			return new _283B692664694E2C(P_0, P_1, P_2);
		}

		static object _0D125D8D8A904465(object P_0, object P_1, CancellationToken P_2)
		{
			return ((EB69693599F64B76)P_0).BC87B91F67354814((_652C34B1E6554F10)P_1, P_2);
		}

		static TaskAwaiter _6896E3BAECE54B51(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static void A3CFC87B4F904B4C(object P_0, ref bool P_1)
		{
			Monitor.Enter(P_0, ref P_1);
		}

		static void E374434C522C4F14(object P_0)
		{
			Monitor.Exit(P_0);
		}

		static object _3BD649D7BECE49C2(CancellationToken[] P_0)
		{
			return CancellationTokenSource.CreateLinkedTokenSource(P_0);
		}

		static object _754CA6F1289C4084(Func<Task> P_0, CancellationToken P_1)
		{
			return Task.Run(P_0, P_1);
		}

		static void AD5DD31F12DE4E31(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		static string _19C6A8252C6A42D1(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		static string _6EAAC89E9F9D437B(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static object _2F6ECBEAF268463A(string P_0, string P_1, RegexOptions P_2)
		{
			return Regex.Match(P_0, P_1, P_2);
		}

		static bool BF945B9694A248C4(object P_0)
		{
			return ((Group)P_0).Success;
		}

		static object _5915D9F78D4745A4(object P_0)
		{
			return ((Match)P_0).Groups;
		}

		static object CD123D6E57544F0D(object P_0, string P_1)
		{
			return ((GroupCollection)P_0)[P_1];
		}

		static string _2A3FD7B8A2804752(object P_0)
		{
			return ((Capture)P_0).Value;
		}

		static void _17958C9288E842FE(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._7AD9FD5CA92F419A(P_1, P_2);
		}

		static object _4B63B23628C34D92(string P_0)
		{
			return new _89831CDD121E4CF1(P_0);
		}

		static void _8DAB242FA2F14084(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0).C5D47CCBE968471D(P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _993921A7551C47D6 : IAsyncStateMachine
	{
		public int _4E1DA69A73AE44A4;

		public AsyncTaskMethodBuilder _564EACD9AD1645D4;

		public WebSocketCloseStatus _4044A10D10BE4BFA;

		public string CF4A871DB3594CE4;

		public bool _8824676C84414B60;

		public EB69693599F64B76 _4D772B0B86E04550;

		public bool _8E3DD53EEE9A4BD1;

		public Exception BB09ADF13B4044F8;

		private CancellationTokenSource _2C98F592415C4ADD;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter B97A05E6D5854EEB;

		private TaskAwaiter _1EE48AAAE9974974;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3472021953u);
			int num = _4E1DA69A73AE44A4;
			EB69693599F64B76 eB69693599F64B = _4D772B0B86E04550;
			try
			{
				obj._184044A093C04AF2(9, 120262629u);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default;
				ConfiguredTaskAwaitable configuredTaskAwaitable = default;
				while (true)
				{
					IL_0029:
					int num2 = 957392563;
					while (true)
					{
						int num3 = num2;
						int num28;
						uint num4;
						int num35;
						switch ((num4 = (uint)(((num3 ^ (0x46B47782 ^ ((((-1416900931 * --1013501730) ^ -unchecked(185068799 * -438591865)) * -1494902331) ^ -(unchecked(unchecked(-1106924225 * 1598018953) - unchecked(1943612963 * 1103974588)) + -(0x44EFADFA ^ 0x21DE9DB2))) ^ (~(1227722858 + -1839342830 + (-1426337066 + 273359581 - (-1268683100 + -710372144))) - (~(0x5C8BC921 ^ -33939326) + (-(-165366086) - 354998929)) - -((--151629625 ^ -897937715) + (0x1D4AC472 ^ 0x3B296330) + unchecked(1646603471 * unchecked(-1026338231 * -998458291)))))) - (~(-345658512) ^ ((-414757732 ^ 0x3C1D8A56) - (-(~1702027344 - 239319290) ^ -351206339)))) ^ 0x995F49A)) % 27)
						{
						case 0u:
							break;
						case 6u:
						{
							int num26;
							int num27;
							if (!eB69693599F64B._483A5AA14A424CB2.IsCancellationRequested)
							{
								num26 = -776131879;
								num27 = num26;
							}
							else
							{
								num26 = 427241696;
								num27 = num26;
							}
							num2 = num26 ^ (int)(num4 * 1399012461);
							continue;
						}
						case 4u:
						{
							int num36;
							int num37;
							if (BB09ADF13B4044F8 != null)
							{
								num36 = 1346278417;
								num37 = num36;
							}
							else
							{
								num36 = 909680550;
								num37 = num36;
							}
							num2 = num36 ^ (int)(num4 * 1525895390);
							continue;
						}
						case 17u:
							_8824676C84414B60 = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-1212486161 ^ (int)obj._184044A093C04AF2(6, 0u)) != 0;
							num2 = ((int)num4 * -1568036782) ^ -1629571581;
							continue;
						case 11u:
						{
							_5E780D61DAD9496E obj7 = eB69693599F64B._2BBF92E607BB475E;
							string text4 = _003CModule_003E._8B9C7B12B1AE4949<string>(-1099885893 ^ (int)obj._184044A093C04AF2(9, 1908603390u));
							object[] array = new object[_003CModule_003E._3F57E81A62734AC2<int>((int)(0x4E7CBDBC ^ obj._184044A093C04AF2(4, 4235938341u)))];
							array[_003CModule_003E._390073C602714496<int>(-1641274557 ^ (int)obj._184044A093C04AF2(6, 4095992749u))] = _4044A10D10BE4BFA;
							array[_003CModule_003E._3F57E81A62734AC2<int>(-1843733493 ^ (int)obj._184044A093C04AF2(5, 3447257772u))] = CF4A871DB3594CE4;
							array[_003CModule_003E._3F57E81A62734AC2<int>(-304690788 ^ (int)obj._184044A093C04AF2(8, 2785176431u))] = _8E3DD53EEE9A4BD1;
							obj._184044A093C04AF2(10, 2042174594u);
							obj._184044A093C04AF2(11, 1234654469u);
							obj._184044A093C04AF2(4, 2698099491u);
							array[_003CModule_003E.F84FA79ABE6944BB<int>(-985043923 ^ (int)obj._184044A093C04AF2(5, 3209615761u))] = _8824676C84414B60;
							CCCA6EB97DD64432((object)obj7, A0775BEF1100434F(text4, array), Array.Empty<object>());
							num2 = -853469012;
							continue;
						}
						case 1u:
							awaiter.GetResult();
							num2 = 196752896;
							continue;
						case 12u:
							obj = new _81DD83B8AA2247AA(1767262502u);
							num2 = 54697604;
							continue;
						case 22u:
							obj._184044A093C04AF2(3, 1091255644u);
							obj._184044A093C04AF2(9, 2107301568u);
							obj._184044A093C04AF2(6, 526502081u);
							_2C98F592415C4ADD = (CancellationTokenSource)_9C27CB06D13343A1(TimeSpan.FromSeconds(_003CModule_003E._8B9C7B12B1AE4949<double>(-1898283633 ^ (int)obj._184044A093C04AF2(4, 2033291536u))));
							num2 = ((int)num4 * -1357264261) ^ -1530597205;
							continue;
						case 13u:
							awaiter = B97A05E6D5854EEB;
							B97A05E6D5854EEB = default;
							num2 = -1439267400;
							continue;
						case 15u:
						{
							obj._184044A093C04AF2(9, 3162700519u);
							string text3 = CF4A871DB3594CE4;
							int num31 = ((text3 != null) ? (E31AC13DAB934305((object)text3, _003CModule_003E._58ECCB512F2A43AC<string>(-632355323 ^ (int)obj._184044A093C04AF2(10, 4267071470u))) ? 1 : 0) : _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x7C675D2B ^ obj._184044A093C04AF2(10, 4267071470u))));
							obj._184044A093C04AF2(128, 137389433u);
							obj._184044A093C04AF2(133, 148217753u);
							obj._184044A093C04AF2(134, 2536799673u);
							obj._184044A093C04AF2(135, 1877835737u);
							if (num31 == 0)
							{
								num2 = 1017986063;
								continue;
							}
							goto IL_0804;
						}
						case 7u:
							obj._184044A093C04AF2(8, 365954064u);
							obj._184044A093C04AF2(10, 3585009004u);
							obj._184044A093C04AF2(3, 3004166236u);
							num = (_4E1DA69A73AE44A4 = _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0xC9DAC0F ^ obj._184044A093C04AF2(5, 1716810597u))));
							B97A05E6D5854EEB = awaiter;
							num2 = (int)(num4 * 224623890) ^ -1357649121;
							continue;
						case 20u:
						{
							_5E780D61DAD9496E obj6 = eB69693599F64B._2BBF92E607BB475E;
							obj._184044A093C04AF2(8, 1613775355u);
							obj._184044A093C04AF2(1, 1692352928u);
							obj._184044A093C04AF2(7, 4238820705u);
							_7007462FA47B47B2((object)obj6, _5E5818169ED84367(_003CModule_003E._390073C602714496<string>((int)(0x31EB23E7 ^ obj._184044A093C04AF2(2, 1479809603u))), (object)eB69693599F64B._326CE841E5224D2B, (object)_8E3DD53EEE9A4BD1, (object)eB69693599F64B._483A5AA14A424CB2.IsCancellationRequested), Array.Empty<object>());
							goto end_IL_002e;
						}
						case 2u:
							obj = new _81DD83B8AA2247AA(1999206685u);
							num2 = (int)(num4 * 1974480297) ^ -2052371447;
							continue;
						case 5u:
							obj._184044A093C04AF2(4, 2033291536u);
							obj._184044A093C04AF2(1, 1578958455u);
							obj._184044A093C04AF2(3, 3203711652u);
							num = (_4E1DA69A73AE44A4 = _003CModule_003E._3F57E81A62734AC2<int>((int)(0x638F7B62 ^ obj._184044A093C04AF2(2, 1965930092u))));
							num2 = ((int)num4 * -759667654) ^ 0x7B0855FA;
							continue;
						case 26u:
						{
							WebSocketCloseStatus webSocketCloseStatus = _4044A10D10BE4BFA;
							obj._184044A093C04AF2(4, 69472664u);
							obj._184044A093C04AF2(6, 3517871157u);
							obj._184044A093C04AF2(11, 711089768u);
							if (webSocketCloseStatus != (WebSocketCloseStatus)_003CModule_003E._3F57E81A62734AC2<int>(-1789761150 ^ (int)obj._184044A093C04AF2(1, 489938556u)))
							{
								num2 = ((int)num4 * -1014103990) ^ 0x2EABC301;
								continue;
							}
							goto IL_0804;
						}
						case 16u:
							obj = new _81DD83B8AA2247AA(3289043450u);
							num2 = ((int)num4 * -1518319891) ^ 0x17E59EA;
							continue;
						case 18u:
						{
							configuredTaskAwaitable = DB87B86070FD459F((object)eB69693599F64B.A21AF88AEF814609(), (byte)_003CModule_003E._3F57E81A62734AC2<int>(-847335413 ^ (int)obj._184044A093C04AF2(8, 2403917698u)) != 0);
							awaiter = configuredTaskAwaitable.GetAwaiter();
							int num38;
							if (awaiter.IsCompleted)
							{
								num2 = -1534108744;
								num38 = num2;
							}
							else
							{
								num2 = -214782465;
								num38 = num2;
							}
							continue;
						}
						case 10u:
						{
							obj._184044A093C04AF2(4, 2366394872u);
							int num34;
							if (!(eB69693599F64B._326CE841E5224D2B & _8E3DD53EEE9A4BD1))
							{
								num2 = 1012842679;
								num34 = num2;
							}
							else
							{
								num2 = -940032912;
								num34 = num2;
							}
							continue;
						}
						case 19u:
						{
							_5E780D61DAD9496E obj8 = eB69693599F64B._2BBF92E607BB475E;
							string obj9 = D42ECB26AB2540C1((object)BB09ADF13B4044F8) ?? _003CModule_003E._390073C602714496<string>((int)(0x197B73DF ^ obj._184044A093C04AF2(3, 0u)));
							obj._184044A093C04AF2(6, 3481871792u);
							D126319042764ABB((object)obj8, obj9, Array.Empty<object>());
							num2 = -804679608;
							continue;
						}
						case 23u:
							_564EACD9AD1645D4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							goto IL_1833;
						case 21u:
						{
							int num32;
							int num33;
							if (num == 0)
							{
								num32 = 26462440;
								num33 = num32;
							}
							else
							{
								num32 = 1292916412;
								num33 = num32;
							}
							num2 = num32 ^ (int)(num4 * 783262005);
							continue;
						}
						case 8u:
						{
							int num29;
							int num30;
							if ((uint)(num - _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x18C98D75 ^ obj._184044A093C04AF2(1, 3686260023u)))) <= (uint)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x30B6A026 ^ obj._184044A093C04AF2(2, 1783398061u))))
							{
								num29 = -1284703124;
								num30 = num29;
							}
							else
							{
								num29 = 1597087175;
								num30 = num29;
							}
							num2 = num29 ^ (int)(num4 * 477562168);
							continue;
						}
						case 14u:
						{
							string text2 = CF4A871DB3594CE4;
							obj._184044A093C04AF2(2, 1912184533u);
							num28 = (_4162F18123274685(text2, _003CModule_003E._3F57E81A62734AC2<string>((int)(0x34DC1B8E ^ obj._184044A093C04AF2(3, 0u)))) ? 1 : 0);
							goto IL_081c;
						}
						case 24u:
						{
							_5E780D61DAD9496E obj4 = eB69693599F64B._2BBF92E607BB475E;
							string obj5 = C8A00A93BDA0422B((object)BB09ADF13B4044F8) ?? _003CModule_003E._3F57E81A62734AC2<string>((int)(0x163DA01A ^ obj._184044A093C04AF2(9, 0u)));
							obj._184044A093C04AF2(4, 2133436878u);
							D126319042764ABB((object)obj4, obj5, Array.Empty<object>());
							num2 = -546868414;
							continue;
						}
						case 3u:
							if (_4044A10D10BE4BFA != (WebSocketCloseStatus)_003CModule_003E.F84FA79ABE6944BB<int>(-294419763 ^ (int)obj._184044A093C04AF2(2, 0u)))
							{
								num2 = (int)((num4 * 394815361) ^ 0x7540C4C9);
								continue;
							}
							goto IL_0804;
						case 9u:
						{
							string text = CF4A871DB3594CE4;
							int num25 = ((text != null) ? (E31AC13DAB934305((object)text, _003CModule_003E._390073C602714496<string>(-567659061 ^ (int)obj._184044A093C04AF2(9, 1426677731u))) ? 1 : 0) : _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x4CA126C6 ^ obj._184044A093C04AF2(9, 1426677731u))));
							obj = new _81DD83B8AA2247AA(3157544793u);
							if (num25 == 0)
							{
								num2 = -691012507;
								continue;
							}
							goto IL_0804;
						}
						default:
							{
								try
								{
									if (num != _003CModule_003E._3F57E81A62734AC2<int>(-1452393206 ^ (int)obj._184044A093C04AF2(5, 1611717415u)))
									{
										goto IL_0939;
									}
									goto IL_0a96;
									IL_0939:
									int num5 = -53736576;
									goto IL_093e;
									IL_093e:
									while (true)
									{
										num3 = num5;
										switch ((num4 = (uint)(((num3 ^ (0x46B47782 ^ ((((-1416900931 * --1013501730) ^ -unchecked(185068799 * -438591865)) * -1494902331) ^ -(unchecked(unchecked(-1106924225 * 1598018953) - unchecked(1943612963 * 1103974588)) + -(0x44EFADFA ^ 0x21DE9DB2))) ^ (~(1227722858 + -1839342830 + (-1426337066 + 273359581 - (-1268683100 + -710372144))) - (~(0x5C8BC921 ^ -33939326) + (-(-165366086) - 354998929)) - -((--151629625 ^ -897937715) + (0x1D4AC472 ^ 0x3B296330) + unchecked(1646603471 * unchecked(-1026338231 * -998458291)))))) - (~(-345658512) ^ ((-414757732 ^ 0x3C1D8A56) - (-(~1702027344 - 239319290) ^ -351206339)))) ^ 0x995F49A)) % 4)
										{
										case 0u:
											break;
										case 1u:
											goto IL_0a69;
										case 3u:
											goto IL_0a96;
										default:
											goto IL_0aad;
										}
										break;
										IL_0aad:
										try
										{
											if (num != _003CModule_003E._8B9C7B12B1AE4949<int>(-1660763665 ^ (int)obj._184044A093C04AF2(2, 850242302u)))
											{
												goto IL_0acb;
											}
											goto IL_0e25;
											IL_0acb:
											int num6 = 170683082;
											goto IL_0ad0;
											IL_0ad0:
											while (true)
											{
												num3 = num6;
												switch ((num4 = (uint)(((num3 ^ (0x46B47782 ^ ((((-1416900931 * --1013501730) ^ -unchecked(185068799 * -438591865)) * -1494902331) ^ -(unchecked(unchecked(-1106924225 * 1598018953) - unchecked(1943612963 * 1103974588)) + -(0x44EFADFA ^ 0x21DE9DB2))) ^ (~(1227722858 + -1839342830 + (-1426337066 + 273359581 - (-1268683100 + -710372144))) - (~(0x5C8BC921 ^ -33939326) + (-(-165366086) - 354998929)) - -((--151629625 ^ -897937715) + (0x1D4AC472 ^ 0x3B296330) + unchecked(1646603471 * unchecked(-1026338231 * -998458291)))))) - (~(-345658512) ^ ((-414757732 ^ 0x3C1D8A56) - (-(~1702027344 - 239319290) ^ -351206339)))) ^ 0x995F49A)) % 15)
												{
												case 6u:
													break;
												default:
													goto end_IL_0aad;
												case 13u:
												{
													object obj2 = E914B49FC7ED4C01((object)eB69693599F64B._052E3A15F5B04E5E, _4044A10D10BE4BFA, CF4A871DB3594CE4, _3911080DBE8340BB((object)_2C98F592415C4ADD));
													obj._184044A093C04AF2(11, 2913648871u);
													obj._184044A093C04AF2(5, 3406368473u);
													obj._184044A093C04AF2(8, 28766075u);
													configuredTaskAwaitable = DB87B86070FD459F(obj2, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(-1499083162 ^ (int)obj._184044A093C04AF2(10, 1073061179u)) != 0);
													num6 = 1070858506;
													continue;
												}
												case 2u:
													obj._184044A093C04AF2(1, 1537635521u);
													num6 = -856442319;
													continue;
												case 0u:
													B97A05E6D5854EEB = awaiter;
													num6 = (int)(num4 * 176108511) ^ -332400644;
													continue;
												case 14u:
													_564EACD9AD1645D4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
													num6 = ((int)num4 * -1950496940) ^ -739964282;
													continue;
												case 3u:
												{
													int num11;
													int num12;
													if (DF6FD7308AD34E31((object)eB69693599F64B._052E3A15F5B04E5E) != (WebSocketState)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x250667B6 ^ obj._184044A093C04AF2(7, 0u))))
													{
														num11 = 2065373956;
														num12 = num11;
													}
													else
													{
														num11 = -1363060288;
														num12 = num11;
													}
													num6 = num11 ^ ((int)num4 * -531834452);
													continue;
												}
												case 4u:
													awaiter.GetResult();
													num6 = ((int)num4 * -839265757) ^ 0x50D9507C;
													continue;
												case 12u:
												{
													awaiter = configuredTaskAwaitable.GetAwaiter();
													int num13;
													int num14;
													if (!awaiter.IsCompleted)
													{
														num13 = -1982837189;
														num14 = num13;
													}
													else
													{
														num13 = -857151532;
														num14 = num13;
													}
													num6 = num13 ^ (int)(num4 * 1125230630);
													continue;
												}
												case 9u:
												{
													WebSocketState webSocketState = DF6FD7308AD34E31((object)eB69693599F64B._052E3A15F5B04E5E);
													obj._184044A093C04AF2(0, 3911899546u);
													obj._184044A093C04AF2(7, 3045700186u);
													obj._184044A093C04AF2(9, 4227516454u);
													int num9;
													int num10;
													if (webSocketState != (WebSocketState)_003CModule_003E._3F57E81A62734AC2<int>(-1386089038 ^ (int)obj._184044A093C04AF2(2, 2970004452u)))
													{
														num9 = -725116398;
														num10 = num9;
													}
													else
													{
														num9 = -317180273;
														num10 = num9;
													}
													num6 = num9 ^ ((int)num4 * -1815952931);
													continue;
												}
												case 11u:
												{
													int num7;
													int num8;
													if (DF6FD7308AD34E31((object)eB69693599F64B._052E3A15F5B04E5E) == (WebSocketState)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x1A5937FB ^ obj._184044A093C04AF2(7, 0u))))
													{
														num7 = -1106945994;
														num8 = num7;
													}
													else
													{
														num7 = 1620204188;
														num8 = num7;
													}
													num6 = num7 ^ ((int)num4 * -1036266155);
													continue;
												}
												case 8u:
													goto IL_0e25;
												case 10u:
													obj = new _81DD83B8AA2247AA(605754714u);
													obj._184044A093C04AF2(8, 28766075u);
													obj._184044A093C04AF2(11, 1381318425u);
													obj._184044A093C04AF2(6, 1073061179u);
													num = (_4E1DA69A73AE44A4 = _003CModule_003E._390073C602714496<int>((int)(0x7D5FB32D ^ obj._184044A093C04AF2(9, 2426234344u))));
													num6 = ((int)num4 * -1975529190) ^ -1922567434;
													continue;
												case 1u:
													obj = new _81DD83B8AA2247AA(1119069889u);
													num6 = -607801893;
													continue;
												case 5u:
													goto end_IL_091b;
												case 7u:
													goto end_IL_0aad;
												}
												break;
											}
											goto IL_0acb;
											IL_0e25:
											awaiter = B97A05E6D5854EEB;
											B97A05E6D5854EEB = default;
											obj._184044A093C04AF2(8, 3902551777u);
											obj._184044A093C04AF2(6, 2398303967u);
											obj._184044A093C04AF2(7, 1664381761u);
											num = (_4E1DA69A73AE44A4 = _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x16532BCA ^ obj._184044A093C04AF2(5, 3338917631u))));
											num6 = -489636834;
											goto IL_0ad0;
											end_IL_0aad:;
										}
										catch (Exception ex)
										{
											obj = new _81DD83B8AA2247AA(2991546255u);
											Exception ex2 = ex;
											while (true)
											{
												IL_0f38:
												int num15 = -644376221;
												while (true)
												{
													num3 = num15;
													switch ((num4 = (uint)(((num3 ^ (0x46B47782 ^ ((((-1416900931 * --1013501730) ^ -unchecked(185068799 * -438591865)) * -1494902331) ^ -(unchecked(unchecked(-1106924225 * 1598018953) - unchecked(1943612963 * 1103974588)) + -(0x44EFADFA ^ 0x21DE9DB2))) ^ (~(1227722858 + -1839342830 + (-1426337066 + 273359581 - (-1268683100 + -710372144))) - (~(0x5C8BC921 ^ -33939326) + (-(-165366086) - 354998929)) - -((--151629625 ^ -897937715) + (0x1D4AC472 ^ 0x3B296330) + unchecked(1646603471 * unchecked(-1026338231 * -998458291)))))) - (~(-345658512) ^ ((-414757732 ^ 0x3C1D8A56) - (-(~1702027344 - 239319290) ^ -351206339)))) ^ 0x995F49A)) % 3)
													{
													case 0u:
														break;
													default:
														goto end_IL_0f3d;
													case 2u:
														goto IL_1064;
													case 1u:
														goto end_IL_0f3d;
													}
													goto IL_0f38;
													IL_1064:
													_5E780D61DAD9496E obj3 = eB69693599F64B._2BBF92E607BB475E;
													obj._184044A093C04AF2(11, 3055753166u);
													obj._184044A093C04AF2(1, 1120697459u);
													obj._184044A093C04AF2(6, 729543694u);
													A94BB19575364223((object)obj3, (object)ex2, _003CModule_003E._3F57E81A62734AC2<string>(-1731247887 ^ (int)obj._184044A093C04AF2(0, 3899604878u)), Array.Empty<object>());
													num15 = ((int)num4 * -2146683561) ^ -1895098571;
													continue;
													end_IL_0f3d:
													break;
												}
												break;
											}
										}
										obj._184044A093C04AF2(9, 197119050u);
										TaskAwaiter awaiter2 = B04F91DA5CFF4663((object)eB69693599F64B._0201DB789F804DC5(_4044A10D10BE4BFA, CF4A871DB3594CE4, _8E3DD53EEE9A4BD1, _8824676C84414B60));
										if (!awaiter2.IsCompleted)
										{
											goto IL_1118;
										}
										goto IL_13bf;
										IL_13bf:
										obj._184044A093C04AF2(2, 3028936141u);
										int num16 = -310725357;
										goto IL_111d;
										IL_0a69:
										if (num != _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x7CEFD546 ^ obj._184044A093C04AF2(2, 0u))))
										{
											num5 = (int)((num4 * 509462724) ^ 0x2D484C52);
											continue;
										}
										goto IL_1332;
										IL_1118:
										num16 = 862189881;
										goto IL_111d;
										IL_1332:
										awaiter2 = _1EE48AAAE9974974;
										_1EE48AAAE9974974 = default;
										num16 = 25339188;
										goto IL_111d;
										IL_111d:
										while (true)
										{
											num3 = num16;
											switch ((num4 = (uint)(((num3 ^ (0x46B47782 ^ ((((-1416900931 * --1013501730) ^ -unchecked(185068799 * -438591865)) * -1494902331) ^ -(unchecked(unchecked(-1106924225 * 1598018953) - unchecked(1943612963 * 1103974588)) + -(0x44EFADFA ^ 0x21DE9DB2))) ^ (~(1227722858 + -1839342830 + (-1426337066 + 273359581 - (-1268683100 + -710372144))) - (~(0x5C8BC921 ^ -33939326) + (-(-165366086) - 354998929)) - -((--151629625 ^ -897937715) + (0x1D4AC472 ^ 0x3B296330) + unchecked(1646603471 * unchecked(-1026338231 * -998458291)))))) - (~(-345658512) ^ ((-414757732 ^ 0x3C1D8A56) - (-(~1702027344 - 239319290) ^ -351206339)))) ^ 0x995F49A)) % 12)
											{
											case 3u:
												break;
											case 4u:
											{
												int num19;
												int num20;
												if (_8824676C84414B60)
												{
													num19 = 240968530;
													num20 = num19;
												}
												else
												{
													num19 = -1238482160;
													num20 = num19;
												}
												num16 = num19 ^ ((int)num4 * -641487967);
												continue;
											}
											case 9u:
												obj._184044A093C04AF2(2, 1295102279u);
												obj._184044A093C04AF2(3, 2600405221u);
												obj._184044A093C04AF2(0, 3090185735u);
												num = (_4E1DA69A73AE44A4 = _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x393F3BC1 ^ obj._184044A093C04AF2(9, 1246640191u))));
												num16 = ((int)num4 * -502620269) ^ -7464825;
												continue;
											case 2u:
											{
												int num17;
												int num18;
												if (eB69693599F64B._483A5AA14A424CB2.IsCancellationRequested)
												{
													num17 = 875995528;
													num18 = num17;
												}
												else
												{
													num17 = 38070013;
													num18 = num17;
												}
												num16 = num17 ^ (int)(num4 * 1966958497);
												continue;
											}
											case 1u:
												eB69693599F64B._2EBCEBB349FB4F43();
												num16 = ((int)num4 * -948953625) ^ -1981805095;
												continue;
											case 6u:
												goto IL_1332;
											case 8u:
												_589972FC4EC0459C((Func<Task>)eB69693599F64B._00AEA2129F244701, eB69693599F64B._483A5AA14A424CB2);
												num16 = ((int)num4 * -1735375084) ^ 0x7C43201A;
												continue;
											case 0u:
												awaiter2.GetResult();
												num16 = (int)((num4 * 903721201) ^ 0x3ACCF85B);
												continue;
											case 7u:
												goto IL_1395;
											case 5u:
												goto IL_13bf;
											case 10u:
												obj._184044A093C04AF2(1, 4097848246u);
												num = (_4E1DA69A73AE44A4 = _003CModule_003E._3F57E81A62734AC2<int>((int)(0x19CF4191 ^ obj._184044A093C04AF2(7, 0u))));
												_1EE48AAAE9974974 = awaiter2;
												_564EACD9AD1645D4.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												goto end_IL_091b;
											default:
												obj._184044A093C04AF2(9, 1691529857u);
												obj._184044A093C04AF2(2, 3028936141u);
												goto end_IL_002e;
											}
											break;
											IL_1395:
											obj._184044A093C04AF2(5, 2406318389u);
											int num21;
											if (_8E3DD53EEE9A4BD1)
											{
												num16 = -1555823599;
												num21 = num16;
											}
											else
											{
												num16 = 1011971322;
												num21 = num16;
											}
										}
										goto IL_1118;
									}
									goto IL_0939;
									IL_0a96:
									obj = new _81DD83B8AA2247AA(2297693211u);
									num5 = 413554637;
									goto IL_093e;
									end_IL_091b:;
								}
								finally
								{
									obj = new _81DD83B8AA2247AA(3713491319u);
									if (num < _003CModule_003E._3F57E81A62734AC2<int>(-1634670654 ^ (int)obj._184044A093C04AF2(0, 2597864403u)))
									{
										goto IL_147b;
									}
									goto IL_15b6;
									IL_147b:
									int num22 = 290948494;
									goto IL_1480;
									IL_1480:
									while (true)
									{
										num3 = num22;
										switch ((num4 = (uint)(((num3 ^ (0x46B47782 ^ ((((-1416900931 * --1013501730) ^ -unchecked(185068799 * -438591865)) * -1494902331) ^ -(unchecked(unchecked(-1106924225 * 1598018953) - unchecked(1943612963 * 1103974588)) + -(0x44EFADFA ^ 0x21DE9DB2))) ^ (~(1227722858 + -1839342830 + (-1426337066 + 273359581 - (-1268683100 + -710372144))) - (~(0x5C8BC921 ^ -33939326) + (-(-165366086) - 354998929)) - -((--151629625 ^ -897937715) + (0x1D4AC472 ^ 0x3B296330) + unchecked(1646603471 * unchecked(-1026338231 * -998458291)))))) - (~(-345658512) ^ ((-414757732 ^ 0x3C1D8A56) - (-(~1702027344 - 239319290) ^ -351206339)))) ^ 0x995F49A)) % 6)
										{
										case 5u:
											break;
										default:
											goto end_IL_1451;
										case 2u:
											goto IL_15b6;
										case 3u:
											_0712A32345BA4C3F((object)_2C98F592415C4ADD);
											num22 = ((int)num4 * -713163262) ^ 0x61788951;
											continue;
										case 1u:
										{
											int num23;
											int num24;
											if (_2C98F592415C4ADD == null)
											{
												num23 = -935041873;
												num24 = num23;
											}
											else
											{
												num23 = 402751542;
												num24 = num23;
											}
											num22 = num23 ^ ((int)num4 * -967680904);
											continue;
										}
										case 4u:
											obj._184044A093C04AF2(139, 676014913u);
											num22 = ((int)num4 * -765040207) ^ 0x508BC4AB;
											continue;
										case 0u:
											goto end_IL_1451;
										}
										break;
									}
									goto IL_147b;
									IL_15b6:
									obj._184044A093C04AF2(136, 1626726881u);
									obj._184044A093C04AF2(133, 3562755522u);
									obj._184044A093C04AF2(138, 2354390049u);
									num22 = -321238581;
									goto IL_1480;
									end_IL_1451:;
								}
								goto IL_1833;
							}
							IL_0804:
							num28 = _003CModule_003E._3F57E81A62734AC2<int>((int)(0x3492B1BE ^ obj._184044A093C04AF2(2, 1912184533u)));
							goto IL_081c;
							IL_081c:
							obj = new _81DD83B8AA2247AA(1022482338u);
							if (num28 != 0)
							{
								num2 = 487868051;
								num35 = num2;
							}
							else
							{
								num2 = 520883771;
								num35 = num2;
							}
							continue;
						}
						goto IL_0029;
						continue;
						end_IL_002e:
						break;
					}
					break;
				}
			}
			catch (Exception ex3)
			{
				obj = new _81DD83B8AA2247AA(3109032664u);
				Exception exception = ex3;
				obj._184044A093C04AF2(11, 3758928791u);
				obj._184044A093C04AF2(1, 1231690986u);
				obj._184044A093C04AF2(4, 373822521u);
				_4E1DA69A73AE44A4 = _003CModule_003E._3F57E81A62734AC2<int>(-1577632981 ^ (int)obj._184044A093C04AF2(10, 2799763449u));
				_2C98F592415C4ADD = null;
				_564EACD9AD1645D4.SetException(exception);
				goto IL_1833;
			}
			_4E1DA69A73AE44A4 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1210137456 ^ (int)obj._184044A093C04AF2(0, 0u));
			goto IL_16de;
			IL_16de:
			int num39 = -293817048;
			goto IL_16e3;
			IL_1833:
			obj._184044A093C04AF2(0, 1025734036u);
			num39 = 162650755;
			goto IL_16e3;
			IL_16e3:
			while (true)
			{
				int num3 = num39;
				uint num4;
				switch ((num4 = (uint)(((num3 ^ (0x46B47782 ^ ((((-1416900931 * --1013501730) ^ -unchecked(185068799 * -438591865)) * -1494902331) ^ -(unchecked(unchecked(-1106924225 * 1598018953) - unchecked(1943612963 * 1103974588)) + -(0x44EFADFA ^ 0x21DE9DB2))) ^ (~(1227722858 + -1839342830 + (-1426337066 + 273359581 - (-1268683100 + -710372144))) - (~(0x5C8BC921 ^ -33939326) + (-(-165366086) - 354998929)) - -((--151629625 ^ -897937715) + (0x1D4AC472 ^ 0x3B296330) + unchecked(1646603471 * unchecked(-1026338231 * -998458291)))))) - (~(-345658512) ^ ((-414757732 ^ 0x3C1D8A56) - (-(~1702027344 - 239319290) ^ -351206339)))) ^ 0x995F49A)) % 4)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					_2C98F592415C4ADD = null;
					_564EACD9AD1645D4.SetResult();
					num39 = ((int)num4 * -860200154) ^ 0x667B8DAC;
					continue;
				case 3u:
					goto IL_1833;
				case 0u:
					return;
				}
				break;
			}
			goto IL_16de;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_564EACD9AD1645D4.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool E31AC13DAB934305(object P_0, string P_1)
		{
			return ((string)P_0).Contains(P_1);
		}

		static bool _4162F18123274685(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static string _5E5818169ED84367(string P_0, object P_1, object P_2, object P_3)
		{
			return string.Format(P_0, P_1, P_2, P_3);
		}

		static void _7007462FA47B47B2(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._4A918CD4B86142EF(P_1, P_2);
		}

		static string A0775BEF1100434F(string P_0, object[] P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void CCCA6EB97DD64432(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0).C5D47CCBE968471D(P_1, P_2);
		}

		static string C8A00A93BDA0422B(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		static void D126319042764ABB(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._7AD9FD5CA92F419A(P_1, P_2);
		}

		static string D42ECB26AB2540C1(object P_0)
		{
			return ((Exception)P_0).StackTrace;
		}

		static ConfiguredTaskAwaitable DB87B86070FD459F(object P_0, bool P_1)
		{
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		static object _9C27CB06D13343A1(TimeSpan P_0)
		{
			return new CancellationTokenSource(P_0);
		}

		static WebSocketState DF6FD7308AD34E31(object P_0)
		{
			return ((WebSocket)P_0).State;
		}

		static CancellationToken _3911080DBE8340BB(object P_0)
		{
			return ((CancellationTokenSource)P_0).Token;
		}

		static object E914B49FC7ED4C01(object P_0, WebSocketCloseStatus P_1, string P_2, CancellationToken P_3)
		{
			return ((WebSocket)P_0).CloseAsync(P_1, P_2, P_3);
		}

		static void A94BB19575364223(object P_0, object P_1, string P_2, object[] P_3)
		{
			((_5E780D61DAD9496E)P_0).BDC48832C287459D((Exception)P_1, P_2, P_3);
		}

		static TaskAwaiter B04F91DA5CFF4663(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static object _589972FC4EC0459C(Func<Task> P_0, CancellationToken P_1)
		{
			return Task.Run(P_0, P_1);
		}

		static void _0712A32345BA4C3F(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct CB205E8EC72E43F8 : IAsyncStateMachine
	{
		public int _8AB0D168BE894563;

		public AsyncTaskMethodBuilder CD6E7CCE4A5D4D86;

		public EB69693599F64B76 D19ED181B6F2435A;

		public CancellationToken FF0F697D89A94E57;

		private byte[] EC207DB469D546A2;

		private object C51471BD81CA4079;

		private int _2DC8188872DE49A1;

		private MemoryStream _748EA84EABAD4426;

		private byte[] _2A13DD13D99549B1;

		private _652C34B1E6554F10 _25CB8E83F0D64050;

		private CancellationTokenSource _574C2E9F3BA04E02;

		private CancellationTokenSource A32C76BE62524808;

		private ConfiguredTaskAwaitable<WebSocketReceiveResult>.ConfiguredTaskAwaiter _3AC8A2EAAFE14B1A;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _96601506ACC14FE7;

		private TaskAwaiter B79CA7A4E2AD4AF5;

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
			CD6E7CCE4A5D4D86.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static void _9101D1F2547E48FB(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._4A918CD4B86142EF(P_1, P_2);
		}

		static object D2464AB5BFCB401F()
		{
			return new MemoryStream();
		}

		static WebSocketState A753AE9B159E4B2C(object P_0)
		{
			return ((WebSocket)P_0).State;
		}

		static object _266ECFEFEA5748B5(TimeSpan P_0)
		{
			return new CancellationTokenSource(P_0);
		}

		static CancellationToken _16147F1F4F214A36(object P_0)
		{
			return ((CancellationTokenSource)P_0).Token;
		}

		static object AC3B737F13C6413E(CancellationToken P_0, CancellationToken P_1)
		{
			return CancellationTokenSource.CreateLinkedTokenSource(P_0, P_1);
		}

		static Task<WebSocketReceiveResult> _45D217AC6CB748BB(object P_0, ArraySegment<byte> P_1, CancellationToken P_2)
		{
			return ((WebSocket)P_0).ReceiveAsync(P_1, P_2);
		}

		static WebSocketMessageType CBAF62549A424241(object P_0)
		{
			return ((WebSocketReceiveResult)P_0).MessageType;
		}

		static WebSocketCloseStatus? _1FE71BF270194A79(object P_0)
		{
			return ((WebSocketReceiveResult)P_0).CloseStatus;
		}

		static string _4CCF68FBA3F54C9E(object P_0)
		{
			return ((WebSocketReceiveResult)P_0).CloseStatusDescription;
		}

		static string A7A802EA77AB4993(string P_0, object P_1, object P_2)
		{
			return string.Format(P_0, P_1, P_2);
		}

		static ConfiguredTaskAwaitable AB897E1ADF0C41DB(object P_0, bool P_1)
		{
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		static int _0FCE6DA7F8C2430A(object P_0)
		{
			return ((WebSocketReceiveResult)P_0).Count;
		}

		static void F333AB75381344EA(object P_0, byte[] P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write(P_1, P_2, P_3);
		}

		static void F39A3FFBA1154125(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		static bool _2D60D121CBDF462F(object P_0)
		{
			return ((WebSocketReceiveResult)P_0).EndOfMessage;
		}

		static byte[] CA9AE69A83C4417A(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		static byte[] F266AB73806640FB(byte[] P_0, byte[] P_1)
		{
			return _635EDF414A0B480B._91EA18E0A4CE4C82(P_0, P_1);
		}

		static string _022521E9230C46BB(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		static string _687EF5D68C174970(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static TaskAwaiter FA1AEF0BA0B24D02(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static object C623302C32724ABF(byte[] P_0, _59751E20330E4047 P_1, ref bool P_2)
		{
			return D303E6A3CA8C49F1.C83C8FBFA0384358(P_0, P_1, out P_2);
		}

		static byte[] _98D4605BE26C4E76(object P_0)
		{
			return ((_9EB5A4DBDFA4443A)P_0)._39D8E3C3A71E4939;
		}

		static object _46C8B0870619434E(object P_0)
		{
			return ((AsymmetricCipherKeyPair)P_0).Private;
		}

		static byte[] _8ED7F6931A7E4387(byte[] P_0, AsymmetricKeyParameter P_1)
		{
			return _59B50849A61D48E8._901A5D89A68E419A(P_0, P_1);
		}

		static Guid _227EBDBAD1D64828(object P_0)
		{
			return ((_0792EF88277943B4)P_0)._654C0D86A9DB4214;
		}

		static string _9E75CFB6BC6841B4(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void _796D1066B7E04304(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._753ADD0FDF864829(P_1, P_2);
		}

		static object _7EE9E473BFE049E6(int P_0)
		{
			return _59B50849A61D48E8.C73AB3465B8148AC(P_0);
		}

		static object _59769A7DF0EC49D3(object P_0)
		{
			return ((AsymmetricCipherKeyPair)P_0).Public;
		}

		static string ADE272E41D16484D(AsymmetricKeyParameter P_0)
		{
			return _59B50849A61D48E8.E61F859DF1CC4C27(P_0);
		}

		static object ABFDE4283B054858(string P_0)
		{
			return new BF6E7C343D674996(P_0);
		}

		static object AC99BE884C2B4037(object P_0, object P_1, CancellationToken P_2)
		{
			return ((EB69693599F64B76)P_0).BC87B91F67354814((_652C34B1E6554F10)P_1, P_2);
		}

		static bool _55F9505A890F4B5D(object P_0)
		{
			return ((_652C34B1E6554F10)P_0)._9B60B9CA08874C25;
		}

		static long _787C05144BF641F6(object P_0)
		{
			return ((_652C34B1E6554F10)P_0).C4CF7218A3D4459F;
		}

		static void B8BED601886C4205(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._0C91D7B8EFB446BF(P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _7E60177B1ACB4F14 : IAsyncStateMachine
	{
		public int _922804CC1DD44836;

		public AsyncTaskMethodBuilder E828AEEB7ECA4133;

		public EB69693599F64B76 _068F1E969D0F4760;

		public _652C34B1E6554F10 _396C0CA6D2B442B9;

		public CancellationToken _970BF13923B043E9;

		private TaskAwaiter A0C49B97844D4596;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _2CDBB47D1B174706;

		private object E17ABC635CB7417F;

		private int _8522F320B4A54474;

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
			E828AEEB7ECA4133.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool _835269A2C3284B74(object P_0)
		{
			return ((EB69693599F64B76)P_0)._5EB25730C8A14FB2;
		}

		static TaskAwaiter _6FF31D89A9234165(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static ArraySegment<byte> EEA021AC5F68490F(_652C34B1E6554F10 P_0, _59751E20330E4047 P_1, bool P_2)
		{
			return D303E6A3CA8C49F1.E2A3D410DBAC4E3A(P_0, P_1, P_2);
		}

		static byte[] _3BDA0C95CEFE4D8F(byte[] P_0, int P_1, int P_2, byte[] P_3)
		{
			return _635EDF414A0B480B._51BF5B35C33D48FF(P_0, P_1, P_2, P_3);
		}

		static ConfiguredTaskAwaitable _8F12AE43ACD14CD6(object P_0, bool P_1)
		{
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		static void _643B2E53E2AC4413(Array P_0, int P_1, Array P_2, int P_3, int P_4)
		{
			Buffer.BlockCopy(P_0, P_1, P_2, P_3, P_4);
		}

		static object _466E90E51B3C4746(string P_0)
		{
			return new ArgumentException(P_0);
		}

		static object CB767BC01A7747AF(object P_0, ArraySegment<byte> P_1, WebSocketMessageType P_2, bool P_3, CancellationToken P_4)
		{
			return ((WebSocket)P_0).SendAsync(P_1, P_2, P_3, P_4);
		}

		static WebSocketError _4F66824E0CFD4E0E(object P_0)
		{
			return ((WebSocketException)P_0).WebSocketErrorCode;
		}

		static string DE6E55C1E83F41BC(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		static string _251B97010B8C49AD(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static object _8B95B028BACA4A3A(Exception P_0)
		{
			return ExceptionDispatchInfo.Capture(P_0);
		}

		static void _2358C5549E874383(object P_0)
		{
			((ExceptionDispatchInfo)P_0).Throw();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _807B969C6FEF4819 : IAsyncStateMachine
	{
		public int DBB679C9D3A24046;

		public AsyncTaskMethodBuilder _6581E9423C8E4C55;

		public EB69693599F64B76 _19D3B470E7FF49AF;

		public Uri _10BD129B4B2F4765;

		public CancellationToken _0065713379194052;

		private TaskAwaiter _663C199554DB490F;

		private object FD975F11EF054834;

		private int _893B9DE64FD64001;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter CB09D19006CB4223;

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
			_6581E9423C8E4C55.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static TaskAwaiter _16B29B59F808427C(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static void _9817B139C926457B(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._753ADD0FDF864829(P_1, P_2);
		}

		static object _15D228E960E04B69(Func<Task> P_0, CancellationToken P_1)
		{
			return Task.Run(P_0, P_1);
		}

		static string B88B56A23B8B4F99(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		static string _81AA5254909A4887(string P_0, string P_1, string P_2)
		{
			return P_0 + P_1 + P_2;
		}

		static void _92B7234CDEC24A2A(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._7AD9FD5CA92F419A(P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _745B1C21A2524D3E : IAsyncStateMachine
	{
		public int E0BC3956538E4876;

		public AsyncTaskMethodBuilder _5B8479301D054353;

		public EB69693599F64B76 D4DD3CEF44B6424B;

		private TaskAwaiter _02B07E99FF2249D6;

		private object CF0D95623E224DCB;

		private int _238B411228C34E14;

		private TaskAwaiter<bool> _10D2840AF0D04FEC;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1699112609u);
			int num = E0BC3956538E4876;
			EB69693599F64B76 eB69693599F64B = D4DD3CEF44B6424B;
			int num4;
			uint num5;
			try
			{
				int num2 = num;
				obj._184044A093C04AF2(0, 1211521478u);
				obj._184044A093C04AF2(10, 1197380550u);
				obj._184044A093C04AF2(7, 701038970u);
				if ((uint)num2 > (uint)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x5727B2FD ^ obj._184044A093C04AF2(1, 2660532486u))))
				{
					object obj2 = default;
					while (true)
					{
						int num3 = -512584134;
						while (true)
						{
							num4 = num3;
							switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 3)
							{
							case 2u:
								break;
							case 1u:
								obj2 = eB69693599F64B._462232031513407A;
								num3 = (int)(num5 * 1639336046) ^ -832898508;
								continue;
							default:
								goto end_IL_0063;
							}
							break;
						}
						continue;
						end_IL_0063:
						break;
					}
					bool flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-1374244389 ^ (int)obj._184044A093C04AF2(10, 2575819729u)) != 0;
					try
					{
						obj = new _81DD83B8AA2247AA(1061862107u);
						_1DD434C8B674471F(obj2, ref flag);
						if (eB69693599F64B._326CE841E5224D2B)
						{
							goto IL_0161;
						}
						goto IL_02bb;
						IL_0161:
						int num6 = 380667358;
						goto IL_0166;
						IL_0166:
						while (true)
						{
							num4 = num6;
							switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 9)
							{
							case 0u:
								break;
							default:
								goto end_IL_0142;
							case 5u:
								eB69693599F64B._326CE841E5224D2B = (byte)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x77CE26B5 ^ obj._184044A093C04AF2(9, 1483467425u))) != 0;
								num6 = -1725928440;
								continue;
							case 7u:
							{
								_5E780D61DAD9496E obj3 = eB69693599F64B._2BBF92E607BB475E;
								obj._184044A093C04AF2(3, 413768372u);
								obj._184044A093C04AF2(1, 1420352076u);
								obj._184044A093C04AF2(4, 956523324u);
								_078A1CD181A1470B((object)obj3, _003CModule_003E._390073C602714496<string>(-485414343 ^ (int)obj._184044A093C04AF2(2, 2740988489u)), Array.Empty<object>());
								goto end_IL_001a;
							}
							case 3u:
								goto IL_02bb;
							case 4u:
							{
								_5E780D61DAD9496E obj4 = eB69693599F64B._2BBF92E607BB475E;
								obj._184044A093C04AF2(3, 413768372u);
								obj._184044A093C04AF2(9, 1420352076u);
								obj._184044A093C04AF2(0, 956523324u);
								_078A1CD181A1470B((object)obj4, _003CModule_003E._390073C602714496<string>(-1561881630 ^ (int)obj._184044A093C04AF2(6, 1496877116u)), Array.Empty<object>());
								num6 = ((int)num5 * -1409524696) ^ 0x793CA5E9;
								continue;
							}
							case 1u:
							{
								_5E780D61DAD9496E obj5 = eB69693599F64B._2BBF92E607BB475E;
								obj._184044A093C04AF2(10, 2740988489u);
								obj._184044A093C04AF2(9, 4231851947u);
								obj._184044A093C04AF2(0, 956523324u);
								_078A1CD181A1470B((object)obj5, _003CModule_003E._58ECCB512F2A43AC<string>(-639968559 ^ (int)obj._184044A093C04AF2(3, 413768372u)), Array.Empty<object>());
								num6 = (int)(num5 * 910531670) ^ -1957503951;
								continue;
							}
							case 8u:
							{
								int num7;
								int num8;
								if (eB69693599F64B._483A5AA14A424CB2.IsCancellationRequested)
								{
									num7 = -125041082;
									num8 = num7;
								}
								else
								{
									num7 = -1352038926;
									num8 = num7;
								}
								num6 = num7 ^ ((int)num5 * -492329273);
								continue;
							}
							case 2u:
								goto end_IL_001a;
							case 6u:
								goto end_IL_0142;
							}
							break;
						}
						goto IL_0161;
						IL_02bb:
						obj._184044A093C04AF2(6, 4200112757u);
						num6 = 172897146;
						goto IL_0166;
						end_IL_0142:;
					}
					finally
					{
						if (num < _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x4CCE5FF1 ^ new _81DD83B8AA2247AA(2662421325u)._184044A093C04AF2(6, 3779862854u))))
						{
							while (true)
							{
								int num9 = 1074606112;
								while (true)
								{
									num4 = num9;
									switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 4)
									{
									case 2u:
										break;
									case 3u:
									{
										int num10;
										int num11;
										if (!flag)
										{
											num10 = -1144287296;
											num11 = num10;
										}
										else
										{
											num10 = -1326879699;
											num11 = num10;
										}
										num9 = num10 ^ (int)(num5 * 182415626);
										continue;
									}
									case 0u:
										_7775AD7CDD0E42DF(obj2);
										num9 = ((int)num5 * -254112093) ^ -1804579002;
										continue;
									default:
										goto end_IL_0411;
									}
									break;
								}
								continue;
								end_IL_0411:
								break;
							}
						}
						obj = new _81DD83B8AA2247AA(3227961895u);
					}
				}
				obj._184044A093C04AF2(9, 361298442u);
				try
				{
					obj._184044A093C04AF2(8, 316655253u);
					int num12;
					TimeSpan timeSpan = default;
					TaskAwaiter awaiter = default;
					int num18;
					int num19;
					int num24;
					int num25;
					int num26;
					_89831CDD121E4CF1 obj12 = default;
					object obj2;
					bool flag;
					_5E780D61DAD9496E obj13;
					switch (num)
					{
					default:
						num12 = 131191518;
						goto IL_0543;
					case 0:
						goto IL_0632;
					case 1:
						goto IL_0bf8;
					case 2:
						goto IL_10d0;
					case 3:
						goto IL_137d;
					case 4:
						goto IL_15f9;
						IL_0543:
						while (true)
						{
							num4 = num12;
							switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 8)
							{
							case 7u:
								break;
							case 1u:
								goto IL_0600;
							case 2u:
								goto IL_0632;
							case 3u:
								goto IL_064a;
							case 5u:
							{
								eB69693599F64B._9583D8E230C1469B += _003CModule_003E._3F57E81A62734AC2<int>(-1379009130 ^ (int)obj._184044A093C04AF2(6, 3032886444u));
								timeSpan = TimeSpan.FromSeconds(eB69693599F64B.AE1C780539D14E14.TotalSeconds * DB1BACE7A0134D16(_003CModule_003E._3F57E81A62734AC2<double>((int)(0x27E8081C ^ obj._184044A093C04AF2(2, 3300223553u))), (double)(eB69693599F64B._9583D8E230C1469B - _003CModule_003E._3F57E81A62734AC2<int>(-1047477618 ^ (int)obj._184044A093C04AF2(5, 1807936760u)))));
								_5E780D61DAD9496E obj7 = eB69693599F64B._2BBF92E607BB475E;
								string text = _003CModule_003E.F84FA79ABE6944BB<string>((int)(0x61AD86CD ^ obj._184044A093C04AF2(9, 3205476689u)));
								object obj8 = eB69693599F64B._9583D8E230C1469B;
								obj._184044A093C04AF2(0, 4251767459u);
								obj._184044A093C04AF2(2, 2142210907u);
								obj._184044A093C04AF2(7, 2035961322u);
								_078A1CD181A1470B((object)obj7, _7F8CF2F296B04A52(text, obj8, (object)_003CModule_003E._390073C602714496<int>((int)(0x1D3DB740 ^ obj._184044A093C04AF2(1, 1087507543u))), (object)timeSpan.TotalSeconds), Array.Empty<object>());
								num12 = (int)(num5 * 1611006867) ^ -414100846;
								continue;
							}
							case 0u:
							{
								_5E780D61DAD9496E obj6 = eB69693599F64B._2BBF92E607BB475E;
								obj._184044A093C04AF2(0, 316655253u);
								obj._184044A093C04AF2(2, 1977142855u);
								AC7A94021B934771((object)obj6, _003CModule_003E.F84FA79ABE6944BB<string>((int)(0x67FB9BDD ^ obj._184044A093C04AF2(5, 3933668854u))), Array.Empty<object>());
								goto end_IL_0525;
							}
							case 6u:
								obj = new _81DD83B8AA2247AA(501070609u);
								num12 = ((int)num5 * -244743705) ^ 0x2FF42348;
								continue;
							default:
								goto IL_0833;
							}
							break;
							IL_0600:
							obj._184044A093C04AF2(2, 1977142855u);
							if (_38345C764EFC4A44(eB69693599F64B._7B08B37F799B4F6F, (Uri)null))
							{
								num12 = (int)((num5 * 216149361) ^ 0x4A968772);
								continue;
							}
							goto IL_1ce7;
						}
						goto default;
						IL_0833:
						try
						{
							obj._184044A093C04AF2(9, 447083103u);
							while (true)
							{
								IL_0842:
								int num13 = 161730237;
								while (true)
								{
									num4 = num13;
									switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 9)
									{
									case 6u:
										break;
									default:
										goto end_IL_0847;
									case 8u:
									{
										int num16;
										int num17;
										if (num != 0)
										{
											num16 = 436452039;
											num17 = num16;
										}
										else
										{
											num16 = 582516028;
											num17 = num16;
										}
										num13 = num16 ^ (int)(num5 * 1550796861);
										continue;
									}
									case 2u:
										num = (E0BC3956538E4876 = _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x42570240 ^ obj._184044A093C04AF2(4, 3413084417u))));
										num13 = (int)((num5 * 1970516332) ^ 0x130FD3B9);
										continue;
									case 1u:
										awaiter = _02B07E99FF2249D6;
										_02B07E99FF2249D6 = default;
										num13 = -124382323;
										continue;
									case 5u:
										obj._184044A093C04AF2(4, 3652210580u);
										num13 = -461365194;
										continue;
									case 7u:
										obj._184044A093C04AF2(0, 3652210580u);
										obj._184044A093C04AF2(1, 3486585751u);
										num = (E0BC3956538E4876 = _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x3791520A ^ obj._184044A093C04AF2(10, 2157378841u))));
										_02B07E99FF2249D6 = awaiter;
										_5B8479301D054353.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										goto IL_22bb;
									case 3u:
									{
										obj._184044A093C04AF2(4, 3413084417u);
										awaiter = _449B4584E79D4534(_367B899D68D3471D(timeSpan, eB69693599F64B._483A5AA14A424CB2));
										int num14;
										int num15;
										if (awaiter.IsCompleted)
										{
											num14 = 906685437;
											num15 = num14;
										}
										else
										{
											num14 = -664877812;
											num15 = num14;
										}
										num13 = num14 ^ (int)(num5 * 502306958);
										continue;
									}
									case 0u:
										obj._184044A093C04AF2(1, 3486585751u);
										obj._184044A093C04AF2(2, 2157378841u);
										awaiter.GetResult();
										num13 = (int)(num5 * 930820009) ^ -1619180406;
										continue;
									case 4u:
										goto end_IL_0847;
									}
									goto IL_0842;
									continue;
									end_IL_0847:
									break;
								}
								break;
							}
						}
						catch (OperationCanceledException)
						{
							obj._184044A093C04AF2(132, 902456327u);
							obj._184044A093C04AF2(137, 3884636647u);
							obj._184044A093C04AF2(138, 4015500231u);
							obj._184044A093C04AF2(135, 458250663u);
							break;
						}
						if (eB69693599F64B._483A5AA14A424CB2.IsCancellationRequested)
						{
							break;
						}
						goto IL_0acf;
						IL_137d:
						awaiter = _02B07E99FF2249D6;
						num18 = -1303610213;
						goto IL_0fde;
						IL_0acf:
						num19 = 180702336;
						goto IL_0ad4;
						IL_0ad4:
						while (true)
						{
							num4 = num19;
							switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 4)
							{
							case 2u:
								break;
							case 3u:
								_078A1CD181A1470B((object)eB69693599F64B._2BBF92E607BB475E, _0E1CBD41AD754B07(_003CModule_003E._390073C602714496<string>(-79534166 ^ (int)obj._184044A093C04AF2(8, 4186738741u)), (object)eB69693599F64B._9583D8E230C1469B), Array.Empty<object>());
								obj._184044A093C04AF2(5, 361298442u);
								_238B411228C34E14 = _003CModule_003E.F84FA79ABE6944BB<int>(-1370597660 ^ (int)obj._184044A093C04AF2(4, 3948107424u));
								num19 = (int)((num5 * 179666910) ^ 0x2ADB92C9);
								continue;
							case 0u:
								goto IL_0bf8;
							default:
								goto IL_0c11;
							}
							break;
						}
						goto IL_0acf;
						IL_0c11:
						try
						{
							if (num != _003CModule_003E._390073C602714496<int>(-1136977242 ^ (int)obj._184044A093C04AF2(10, 2724603501u)))
							{
								goto IL_0c30;
							}
							goto IL_0d46;
							IL_0c30:
							int num20 = -307464841;
							goto IL_0c35;
							IL_0c35:
							TaskAwaiter<bool> awaiter2 = default;
							while (true)
							{
								num4 = num20;
								switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 10)
								{
								case 6u:
									break;
								default:
									goto end_IL_0c11;
								case 4u:
								{
									obj = new _81DD83B8AA2247AA(1333177773u);
									awaiter2 = eB69693599F64B._095631238EF24370(eB69693599F64B._7B08B37F799B4F6F, eB69693599F64B._483A5AA14A424CB2).GetAwaiter();
									int num21;
									int num22;
									if (!awaiter2.IsCompleted)
									{
										num21 = -1413966481;
										num22 = num21;
									}
									else
									{
										num21 = 1151162486;
										num22 = num21;
									}
									num20 = num21 ^ (int)(num5 * 928189878);
									continue;
								}
								case 8u:
									goto IL_0d46;
								case 3u:
								{
									_5E780D61DAD9496E obj10 = eB69693599F64B._2BBF92E607BB475E;
									obj._184044A093C04AF2(0, 3895619146u);
									obj._184044A093C04AF2(2, 380777546u);
									obj._184044A093C04AF2(5, 37736867u);
									B2AF11D96E1E4124((object)obj10, _003CModule_003E._58ECCB512F2A43AC<string>((int)(0x2BF27128 ^ obj._184044A093C04AF2(3, 803634822u))), Array.Empty<object>());
									goto end_IL_0525;
								}
								case 1u:
									_5B8479301D054353.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									goto IL_22bb;
								case 2u:
									obj._184044A093C04AF2(7, 803634822u);
									obj._184044A093C04AF2(6, 380777546u);
									obj._184044A093C04AF2(1, 3600547578u);
									num = (E0BC3956538E4876 = _003CModule_003E._58ECCB512F2A43AC<int>(-726790916 ^ (int)obj._184044A093C04AF2(8, 3895619146u)));
									num20 = ((int)num5 * -1462508698) ^ -1149287918;
									continue;
								case 9u:
									goto IL_0e9c;
								case 0u:
								{
									_5E780D61DAD9496E obj9 = eB69693599F64B._2BBF92E607BB475E;
									obj._184044A093C04AF2(8, 3895619146u);
									obj._184044A093C04AF2(5, 37736867u);
									obj._184044A093C04AF2(2, 380777546u);
									_078A1CD181A1470B((object)obj9, _0E1CBD41AD754B07(_003CModule_003E._390073C602714496<string>(-1597360020 ^ (int)obj._184044A093C04AF2(11, 803634822u)), (object)eB69693599F64B._9583D8E230C1469B), Array.Empty<object>());
									num20 = -1370808176;
									continue;
								}
								case 5u:
									_10D2840AF0D04FEC = awaiter2;
									num20 = (int)(num5 * 1356368485) ^ -1523615771;
									continue;
								case 7u:
									goto end_IL_0c11;
								}
								break;
								IL_0e9c:
								obj._184044A093C04AF2(9, 3562810711u);
								int num23;
								if (awaiter2.GetResult())
								{
									num20 = 1303587972;
									num23 = num20;
								}
								else
								{
									num20 = 177576043;
									num23 = num20;
								}
							}
							goto IL_0c30;
							IL_0d46:
							awaiter2 = _10D2840AF0D04FEC;
							_10D2840AF0D04FEC = default;
							obj._184044A093C04AF2(4, 4209879263u);
							obj._184044A093C04AF2(2, 3033797159u);
							obj._184044A093C04AF2(11, 3491332474u);
							num = (E0BC3956538E4876 = _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x24BC641A ^ obj._184044A093C04AF2(1, 1025798039u))));
							num20 = -1476489202;
							goto IL_0c35;
							end_IL_0c11:;
						}
						catch (_89831CDD121E4CF1 obj11)
						{
							obj = new _81DD83B8AA2247AA(2238652601u);
							_89831CDD121E4CF1 cF0D95623E224DCB = obj11;
							CF0D95623E224DCB = cF0D95623E224DCB;
							obj._184044A093C04AF2(2, 14751966u);
							obj._184044A093C04AF2(7, 2014455698u);
							obj._184044A093C04AF2(8, 3104827102u);
							_238B411228C34E14 = _003CModule_003E._3F57E81A62734AC2<int>((int)(0x968B0C0 ^ obj._184044A093C04AF2(1, 2400735470u)));
						}
						num24 = _238B411228C34E14;
						if (num24 == _003CModule_003E._8B9C7B12B1AE4949<int>(-74821037 ^ (int)obj._184044A093C04AF2(8, 1900952649u)))
						{
							goto IL_0fd9;
						}
						goto IL_15e0;
						IL_10d0:
						awaiter = _02B07E99FF2249D6;
						num18 = 76669972;
						goto IL_0fde;
						IL_0bf8:
						obj._184044A093C04AF2(1, 3602290533u);
						num19 = -256911686;
						goto IL_0ad4;
						IL_0632:
						obj._184044A093C04AF2(2, 2157378841u);
						num12 = -695832257;
						goto IL_0543;
						IL_1ce7:
						obj._184044A093C04AF2(4, 316655253u);
						num25 = 999708905;
						goto IL_1c39;
						IL_1c39:
						while (true)
						{
							num4 = num25;
							switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 5)
							{
							case 0u:
								break;
							default:
								goto end_IL_0525;
							case 4u:
								goto IL_1ce7;
							case 1u:
								obj._184044A093C04AF2(5, 3933668854u);
								obj._184044A093C04AF2(10, 1977142855u);
								num25 = ((int)num5 * -124300479) ^ -1237844803;
								continue;
							case 3u:
								goto IL_1d2f;
							case 2u:
								goto end_IL_0525;
							}
							break;
							IL_1d2f:
							if (eB69693599F64B._483A5AA14A424CB2.IsCancellationRequested)
							{
								num25 = (int)((num5 * 1009625270) ^ 0x20D0AB80);
								continue;
							}
							goto IL_064a;
						}
						goto IL_1c34;
						IL_064a:
						num26 = eB69693599F64B._9583D8E230C1469B;
						obj._184044A093C04AF2(11, 2259005974u);
						obj._184044A093C04AF2(9, 2850312042u);
						obj._184044A093C04AF2(2, 266128822u);
						if (num26 < _003CModule_003E._8B9C7B12B1AE4949<int>(-383688417 ^ (int)obj._184044A093C04AF2(0, 4021490742u)))
						{
							num12 = 1364388209;
							goto IL_0543;
						}
						goto IL_138f;
						IL_0fd9:
						num18 = -1633542610;
						goto IL_0fde;
						IL_138f:
						_5B1E01FBFE5E4823((object)eB69693599F64B._2BBF92E607BB475E, _431D0F8BBFAD4871(_003CModule_003E.F84FA79ABE6944BB<string>((int)(0x202227D8 ^ obj._184044A093C04AF2(6, 1310574784u))), (object)_003CModule_003E._390073C602714496<int>(-684419233 ^ (int)obj._184044A093C04AF2(5, 1538087228u)), (object)eB69693599F64B._61177986609B49B1.TotalMinutes), Array.Empty<object>());
						num18 = 977376108;
						goto IL_0fde;
						IL_0fde:
						while (true)
						{
							num4 = num18;
							switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 21)
							{
							case 20u:
								break;
							case 14u:
								goto IL_10d0;
							case 9u:
								obj._184044A093C04AF2(3, 2035961322u);
								obj._184044A093C04AF2(1, 4201535322u);
								obj._184044A093C04AF2(0, 3961813594u);
								num = (E0BC3956538E4876 = _003CModule_003E.F84FA79ABE6944BB<int>(-1635390857 ^ (int)obj._184044A093C04AF2(2, 2766474361u)));
								_02B07E99FF2249D6 = awaiter;
								_5B8479301D054353.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num18 = (int)(num5 * 1726616021) ^ -1869205010;
								continue;
							case 18u:
							{
								AC7A94021B934771((object)eB69693599F64B._2BBF92E607BB475E, _81CF8BBF24D24798(_003CModule_003E._390073C602714496<string>(-643399912 ^ (int)obj._184044A093C04AF2(9, 2960676638u)), _135E57AC2AAD4E40((object)obj12), _003CModule_003E._58ECCB512F2A43AC<string>((int)(0x2520E0CF ^ obj._184044A093C04AF2(9, 3325821432u)))), Array.Empty<object>());
								awaiter = _449B4584E79D4534((object)eB69693599F64B._2BBC551851794EDE((byte)_003CModule_003E._58ECCB512F2A43AC<int>(-95232837 ^ (int)obj._184044A093C04AF2(8, 4257467954u)) != 0, (byte)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x3791520A ^ obj._184044A093C04AF2(9, 140931142u))) != 0, (WebSocketCloseStatus)_003CModule_003E._390073C602714496<int>((int)(0x61B1F0CD ^ obj._184044A093C04AF2(0, 3053488173u))), _003CModule_003E._8B9C7B12B1AE4949<string>(-1112195621 ^ (int)obj._184044A093C04AF2(8, 315829014u))));
								int num29;
								int num30;
								if (awaiter.IsCompleted)
								{
									num29 = 437343444;
									num30 = num29;
								}
								else
								{
									num29 = 471018596;
									num30 = num29;
								}
								num18 = num29 ^ (int)(num5 * 873813355);
								continue;
							}
							case 19u:
								_02B07E99FF2249D6 = default;
								obj._184044A093C04AF2(10, 2766474361u);
								obj._184044A093C04AF2(5, 4027100828u);
								obj._184044A093C04AF2(11, 2259005974u);
								num = (E0BC3956538E4876 = _003CModule_003E._58ECCB512F2A43AC<int>(-1292449303 ^ (int)obj._184044A093C04AF2(8, 4277910735u)));
								num18 = (int)((num5 * 1521045337) ^ 0x58784A1B);
								continue;
							case 17u:
								obj._184044A093C04AF2(4, 981571541u);
								num = (E0BC3956538E4876 = _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x5A3DB427 ^ obj._184044A093C04AF2(9, 1771163474u))));
								num18 = ((int)num5 * -1486551322) ^ 0x16777408;
								continue;
							case 1u:
								obj._184044A093C04AF2(129, 4245935089u);
								obj._184044A093C04AF2(130, 2593088896u);
								num18 = (int)((num5 * 1347296549) ^ 0x76EA4AB2);
								continue;
							case 2u:
							{
								int num27;
								int num28;
								if (awaiter.IsCompleted)
								{
									num27 = 665764486;
									num28 = num27;
								}
								else
								{
									num27 = -1755940758;
									num28 = num27;
								}
								num18 = num27 ^ ((int)num5 * -1103205071);
								continue;
							}
							case 6u:
								obj._184044A093C04AF2(135, 458250663u);
								CF0D95623E224DCB = null;
								num18 = (int)((num5 * 129250856) ^ 0x322ABAF0);
								continue;
							case 4u:
								goto IL_137d;
							case 8u:
								goto IL_138f;
							case 10u:
								obj12 = (_89831CDD121E4CF1)CF0D95623E224DCB;
								num18 = (int)((num5 * 45207536) ^ 0x2B06FDB1);
								continue;
							case 15u:
								obj._184044A093C04AF2(128, 902456327u);
								obj._184044A093C04AF2(129, 3884636647u);
								obj._184044A093C04AF2(138, 4015500231u);
								obj._184044A093C04AF2(135, 458250663u);
								awaiter.GetResult();
								goto end_IL_0525;
							case 5u:
								obj._184044A093C04AF2(128, 655729298u);
								obj._184044A093C04AF2(129, 4245935089u);
								obj._184044A093C04AF2(130, 4015500231u);
								obj._184044A093C04AF2(139, 458250663u);
								awaiter.GetResult();
								num18 = -210287850;
								continue;
							case 7u:
								obj._184044A093C04AF2(0, 677269824u);
								obj._184044A093C04AF2(1, 2162505380u);
								num = (E0BC3956538E4876 = _003CModule_003E._58ECCB512F2A43AC<int>(-1486941104 ^ (int)obj._184044A093C04AF2(11, 0u)));
								_02B07E99FF2249D6 = awaiter;
								_5B8479301D054353.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								goto IL_22bb;
							case 3u:
								eB69693599F64B._2EBCEBB349FB4F43();
								awaiter = _449B4584E79D4534((object)eB69693599F64B._0201DB789F804DC5((WebSocketCloseStatus)_003CModule_003E._3F57E81A62734AC2<int>(-353426752 ^ (int)obj._184044A093C04AF2(2, 1145096092u)), _003CModule_003E._390073C602714496<string>(-1257790227 ^ (int)obj._184044A093C04AF2(6, 2707738259u)), (byte)_003CModule_003E._3F57E81A62734AC2<int>(-549988616 ^ (int)obj._184044A093C04AF2(8, 3084168158u)) != 0, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(-132516367 ^ (int)obj._184044A093C04AF2(4, 3024340402u)) != 0));
								num18 = (int)(num5 * 769064587) ^ -1890969505;
								continue;
							case 12u:
								_02B07E99FF2249D6 = default;
								num18 = (int)((num5 * 871608462) ^ 0x2B114D10);
								continue;
							case 13u:
								goto IL_15e0;
							default:
								goto IL_15f9;
							case 11u:
								goto IL_1ce7;
							case 16u:
								goto IL_22bb;
							}
							break;
						}
						goto IL_0fd9;
						IL_15f9:
						obj._184044A093C04AF2(6, 22185764u);
						try
						{
							int num31 = num;
							obj._184044A093C04AF2(8, 1550572210u);
							obj._184044A093C04AF2(6, 2957569219u);
							obj._184044A093C04AF2(7, 1776694663u);
							if (num31 != _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x3CA016DA ^ obj._184044A093C04AF2(9, 3636856879u))))
							{
								goto IL_1651;
							}
							goto IL_1764;
							IL_1651:
							int num32 = -1279134838;
							goto IL_1656;
							IL_1656:
							while (true)
							{
								num4 = num32;
								switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 10)
								{
								case 4u:
									break;
								case 6u:
									_5B8479301D054353.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num32 = (int)((num5 * 480162797) ^ 0x7A7536C8);
									continue;
								case 9u:
									obj._184044A093C04AF2(0, 88475989u);
									obj._184044A093C04AF2(9, 514624597u);
									num32 = -361340597;
									continue;
								case 0u:
									goto IL_1764;
								case 3u:
								{
									obj = new _81DD83B8AA2247AA(495867154u);
									awaiter = _449B4584E79D4534(_367B899D68D3471D(eB69693599F64B._61177986609B49B1, eB69693599F64B._483A5AA14A424CB2));
									int num33;
									int num34;
									if (awaiter.IsCompleted)
									{
										num33 = -1800593403;
										num34 = num33;
									}
									else
									{
										num33 = 822093731;
										num34 = num33;
									}
									num32 = num33 ^ ((int)num5 * -2013523677);
									continue;
								}
								case 1u:
									obj._184044A093C04AF2(0, 88475989u);
									obj._184044A093C04AF2(3, 1989217387u);
									obj._184044A093C04AF2(10, 570646037u);
									num = (E0BC3956538E4876 = _003CModule_003E._390073C602714496<int>(-1940542606 ^ (int)obj._184044A093C04AF2(9, 514624597u)));
									num32 = ((int)num5 * -1605865990) ^ -985603228;
									continue;
								case 7u:
									_02B07E99FF2249D6 = awaiter;
									num32 = (int)((num5 * 100798077) ^ 0x25251E60);
									continue;
								case 2u:
									awaiter = _02B07E99FF2249D6;
									_02B07E99FF2249D6 = default;
									obj._184044A093C04AF2(11, 529055246u);
									obj._184044A093C04AF2(9, 4077154674u);
									obj._184044A093C04AF2(6, 2467902962u);
									num = (E0BC3956538E4876 = _003CModule_003E.F84FA79ABE6944BB<int>(-1657763454 ^ (int)obj._184044A093C04AF2(4, 1274156402u)));
									num32 = (int)((num5 * 579765711) ^ 0x6FEDE03A);
									continue;
								case 5u:
									goto end_IL_1608;
								default:
									obj._184044A093C04AF2(6, 570646037u);
									obj._184044A093C04AF2(11, 1989217387u);
									awaiter.GetResult();
									goto IL_1931;
								}
								break;
							}
							goto IL_1651;
							IL_1764:
							obj = new _81DD83B8AA2247AA(3031143456u);
							num32 = -126868973;
							goto IL_1656;
							end_IL_1608:;
						}
						catch (OperationCanceledException)
						{
							obj._184044A093C04AF2(136, 902456327u);
							obj._184044A093C04AF2(137, 3884636647u);
							obj._184044A093C04AF2(130, 4015500231u);
							obj._184044A093C04AF2(139, 458250663u);
							break;
						}
						goto IL_22bb;
						IL_1931:
						obj2 = eB69693599F64B._462232031513407A;
						flag = (byte)_003CModule_003E._58ECCB512F2A43AC<int>((int)(0x20CF137B ^ obj._184044A093C04AF2(1, 3113578180u))) != 0;
						try
						{
							_1DD434C8B674471F(obj2, ref flag);
							while (true)
							{
								IL_1959:
								int num35 = 407277991;
								while (true)
								{
									num4 = num35;
									switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 3)
									{
									case 2u:
										break;
									default:
										goto end_IL_195e;
									case 1u:
										goto IL_1a04;
									case 0u:
										goto end_IL_195e;
									}
									goto IL_1959;
									IL_1a04:
									obj._184044A093C04AF2(1, 1181389116u);
									eB69693599F64B._9583D8E230C1469B = _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x20CF137B ^ obj._184044A093C04AF2(3, 0u)));
									num35 = ((int)num5 * -465599878) ^ -2023211354;
									continue;
									end_IL_195e:
									break;
								}
								break;
							}
						}
						finally
						{
							obj = new _81DD83B8AA2247AA(554113844u);
							while (true)
							{
								IL_1a50:
								int num36 = -1373537958;
								while (true)
								{
									num4 = num36;
									switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 8)
									{
									case 0u:
										break;
									default:
										goto end_IL_1a55;
									case 4u:
										obj._184044A093C04AF2(130, 4015500231u);
										num36 = (int)(num5 * 1211930760) ^ -265855555;
										continue;
									case 2u:
										obj._184044A093C04AF2(139, 458250663u);
										num36 = (int)(num5 * 1394032429) ^ -66439666;
										continue;
									case 3u:
									{
										int num39;
										int num40;
										if (flag)
										{
											num39 = -700636962;
											num40 = num39;
										}
										else
										{
											num39 = -1762995311;
											num40 = num39;
										}
										num36 = num39 ^ (int)(num5 * 1120482408);
										continue;
									}
									case 6u:
										obj._184044A093C04AF2(136, 902456327u);
										obj._184044A093C04AF2(137, 3884636647u);
										num36 = 227088191;
										continue;
									case 5u:
									{
										int num37;
										int num38;
										if (num < _003CModule_003E._390073C602714496<int>((int)(0x1A43FD7 ^ obj._184044A093C04AF2(8, 3960533991u))))
										{
											num37 = 1668553015;
											num38 = num37;
										}
										else
										{
											num37 = -1933264602;
											num38 = num37;
										}
										num36 = num37 ^ ((int)num5 * -442138085);
										continue;
									}
									case 1u:
										_7775AD7CDD0E42DF(obj2);
										num36 = (int)(num5 * 1613709786) ^ -228213581;
										continue;
									case 7u:
										goto end_IL_1a55;
									}
									goto IL_1a50;
									continue;
									end_IL_1a55:
									break;
								}
								break;
							}
						}
						obj13 = eB69693599F64B._2BBF92E607BB475E;
						obj._184044A093C04AF2(6, 1977142855u);
						obj._184044A093C04AF2(0, 316655253u);
						_9E142A51EF504901((object)obj13, _003CModule_003E._390073C602714496<string>((int)(0x4C7502CC ^ obj._184044A093C04AF2(5, 361298442u))), Array.Empty<object>());
						goto IL_1c34;
						IL_1c34:
						num25 = 479993035;
						goto IL_1c39;
						IL_15e0:
						obj._184044A093C04AF2(136, 655729298u);
						num18 = 1165252993;
						goto IL_0fde;
						end_IL_0525:
						break;
					}
				}
				finally
				{
					obj = new _81DD83B8AA2247AA(1302184086u);
					if (num < _003CModule_003E._58ECCB512F2A43AC<int>(-1504791190 ^ (int)obj._184044A093C04AF2(4, 2248112653u)))
					{
						object obj2 = eB69693599F64B._462232031513407A;
						bool flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x4D25FF1B ^ obj._184044A093C04AF2(9, 2056389988u))) != 0;
						try
						{
							_1DD434C8B674471F(obj2, ref flag);
							obj._184044A093C04AF2(8, 2130004828u);
							obj._184044A093C04AF2(2, 2058661137u);
							obj._184044A093C04AF2(9, 3115127405u);
							eB69693599F64B._326CE841E5224D2B = (byte)_003CModule_003E._390073C602714496<int>((int)(0x4AD94964 ^ obj._184044A093C04AF2(3, 2469972463u))) != 0;
						}
						finally
						{
							obj = new _81DD83B8AA2247AA(2604932455u);
							while (true)
							{
								IL_1e04:
								int num41 = -189036269;
								while (true)
								{
									num4 = num41;
									switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 6)
									{
									case 3u:
										break;
									case 5u:
										obj._184044A093C04AF2(132, 902456327u);
										num41 = 212972042;
										continue;
									case 0u:
										_7775AD7CDD0E42DF(obj2);
										num41 = (int)((num5 * 1760796049) ^ 0x46EFB68);
										continue;
									case 2u:
									{
										int num44;
										int num45;
										if (!flag)
										{
											num44 = 1528401440;
											num45 = num44;
										}
										else
										{
											num44 = -402961357;
											num45 = num44;
										}
										num41 = num44 ^ ((int)num5 * -1080856455);
										continue;
									}
									case 4u:
									{
										int num42;
										int num43;
										if (num < _003CModule_003E.F84FA79ABE6944BB<int>(-1059359979 ^ (int)obj._184044A093C04AF2(10, 1714848007u)))
										{
											num42 = 394513579;
											num43 = num42;
										}
										else
										{
											num42 = -1914609600;
											num43 = num42;
										}
										num41 = num42 ^ (int)(num5 * 1029530206);
										continue;
									}
									default:
										obj._184044A093C04AF2(133, 3884636647u);
										obj._184044A093C04AF2(134, 4015500231u);
										obj._184044A093C04AF2(131, 458250663u);
										goto end_IL_1e09;
									}
									goto IL_1e04;
									continue;
									end_IL_1e09:
									break;
								}
								break;
							}
						}
						_5E780D61DAD9496E obj14 = eB69693599F64B._2BBF92E607BB475E;
						obj._184044A093C04AF2(0, 2130004828u);
						obj._184044A093C04AF2(1, 3418417199u);
						obj._184044A093C04AF2(11, 1824994833u);
						_078A1CD181A1470B((object)obj14, _003CModule_003E._3F57E81A62734AC2<string>((int)(0x70D505C2 ^ obj._184044A093C04AF2(6, 2058661137u))), Array.Empty<object>());
						goto IL_1fca;
					}
					goto IL_2075;
					IL_1fcf:
					int num46;
					num4 = num46;
					switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 3)
					{
					case 2u:
						break;
					case 1u:
						goto IL_2075;
					default:
						obj._184044A093C04AF2(137, 3884636647u);
						obj._184044A093C04AF2(138, 4015500231u);
						obj._184044A093C04AF2(139, 458250663u);
						goto end_IL_1d57;
					}
					goto IL_1fca;
					IL_2075:
					obj._184044A093C04AF2(136, 902456327u);
					num46 = 246511880;
					goto IL_1fcf;
					IL_1fca:
					num46 = 940088278;
					goto IL_1fcf;
					end_IL_1d57:;
				}
				end_IL_001a:;
			}
			catch (Exception ex3)
			{
				obj = new _81DD83B8AA2247AA(3444583246u);
				Exception exception = ex3;
				while (true)
				{
					IL_20cf:
					int num47 = -160243554;
					while (true)
					{
						num4 = num47;
						switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 3)
						{
						case 2u:
							break;
						case 1u:
							goto IL_217a;
						default:
							_5B8479301D054353.SetException(exception);
							goto end_IL_20d4;
						}
						goto IL_20cf;
						IL_217a:
						obj._184044A093C04AF2(11, 2371514535u);
						obj._184044A093C04AF2(10, 3476694345u);
						obj._184044A093C04AF2(9, 1164365593u);
						E0BC3956538E4876 = _003CModule_003E.F84FA79ABE6944BB<int>(-1319135234 ^ (int)obj._184044A093C04AF2(4, 1338333961u));
						num47 = (int)(num5 * 396980722) ^ -551228021;
						continue;
						end_IL_20d4:
						break;
					}
					break;
				}
				goto IL_22bb;
			}
			E0BC3956538E4876 = _003CModule_003E.F84FA79ABE6944BB<int>(-1182603810 ^ (int)obj._184044A093C04AF2(10, 0u));
			_5B8479301D054353.SetResult();
			goto IL_2210;
			IL_2210:
			int num48 = -609926808;
			goto IL_2215;
			IL_22bb:
			obj._184044A093C04AF2(4, 723405845u);
			num48 = 1134802412;
			goto IL_2215;
			IL_2215:
			num4 = num48;
			switch ((num5 = (uint)(~(~((-num4 + (~((-(--2120547185) * -2012998637) ^ -unchecked(-531725133 * (0x542F073C ^ -1140836802))) + (~(1249247780 + unchecked(1236511647 - -1372758304) - -(1010152719 + 606518366)) + -1041193879))) ^ (-494718999 * -unchecked(414841337 * ~(-1673618111 - -11530395)))) - -((0x5C0CDD50 ^ -1862985951) - unchecked(967060917 * 1134608864))) ^ -461294041)) % 3)
			{
			case 0u:
				break;
			default:
				return;
			case 1u:
				goto IL_22bb;
			case 2u:
				return;
			}
			goto IL_2210;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_5B8479301D054353.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static void _1DD434C8B674471F(object P_0, ref bool P_1)
		{
			Monitor.Enter(P_0, ref P_1);
		}

		static void _078A1CD181A1470B(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._4A918CD4B86142EF(P_1, P_2);
		}

		static void _7775AD7CDD0E42DF(object P_0)
		{
			Monitor.Exit(P_0);
		}

		static bool _38345C764EFC4A44(Uri P_0, Uri P_1)
		{
			return P_0 == P_1;
		}

		static void AC7A94021B934771(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._7AD9FD5CA92F419A(P_1, P_2);
		}

		static double DB1BACE7A0134D16(double P_0, double P_1)
		{
			return Math.Pow(P_0, P_1);
		}

		static string _7F8CF2F296B04A52(string P_0, object P_1, object P_2, object P_3)
		{
			return string.Format(P_0, P_1, P_2, P_3);
		}

		static object _367B899D68D3471D(TimeSpan P_0, CancellationToken P_1)
		{
			return Task.Delay(P_0, P_1);
		}

		static TaskAwaiter _449B4584E79D4534(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static string _0E1CBD41AD754B07(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void B2AF11D96E1E4124(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0).C5D47CCBE968471D(P_1, P_2);
		}

		static string _135E57AC2AAD4E40(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		static string _81CF8BBF24D24798(string P_0, string P_1, string P_2)
		{
			return P_0 + P_1 + P_2;
		}

		static string _431D0F8BBFAD4871(string P_0, object P_1, object P_2)
		{
			return string.Format(P_0, P_1, P_2);
		}

		static void _5B1E01FBFE5E4823(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._0C91D7B8EFB446BF(P_1, P_2);
		}

		static void _9E142A51EF504901(object P_0, string P_1, object[] P_2)
		{
			((_5E780D61DAD9496E)P_0)._753ADD0FDF864829(P_1, P_2);
		}
	}

	private ClientWebSocket _052E3A15F5B04E5E;

	private readonly _5E780D61DAD9496E _2BBF92E607BB475E;

	private Uri? _7B08B37F799B4F6F;

	private CancellationToken _483A5AA14A424CB2;

	private CancellationTokenSource? DB068CC2AA444C4C;

	private Guid F3BBD3A1B609422B;

	private byte[] _519185E5AE6A4628;

	private AsymmetricCipherKeyPair? _79BEC97DB0854FA9;

	private int _9583D8E230C1469B;

	private readonly TimeSpan AE1C780539D14E14;

	private const int BD63C400A53741FB = 5;

	private readonly TimeSpan _61177986609B49B1;

	private readonly object _462232031513407A;

	private bool _326CE841E5224D2B;

	private long DACE5AE5307C481F;

	private readonly ConcurrentDictionary<long, TaskCompletionSource<_652C34B1E6554F10>> _783F1AFC6A164075;

	[CompilerGenerated]
	private Func<_652C34B1E6554F10, Task> A1444A76F9B94E5B;

	[CompilerGenerated]
	private Func<Task> EA8D535A09C64613;

	[CompilerGenerated]
	private Func<Task> _1081F0AE0E154571;

	[CompilerGenerated]
	private Func<WebSocketCloseStatus?, string?, bool, bool, Task> _0201DB789F804DC5;

	[CompilerGenerated]
	private Func<Task> A4143C33375F4661;

	[CompilerGenerated]
	private Func<Task> _5F6D537C03A244A0;

	private readonly Func<string> E996D231699D46A6;

	private const int _995A566849D14BD8 = 65536;

	private bool _3C8A574514C749E0
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return false;
		}
	}

	public bool _5EB25730C8A14FB2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			CBBE600BD0E643BD((object)_052E3A15F5B04E5E);
			return false;
		}
	}

	public event Func<_652C34B1E6554F10, Task> AEE603F91511436D
	{
		[CompilerGenerated]
		add
		{
			throw new Exception();
		}
		[CompilerGenerated]
		remove
		{
			Func<_652C34B1E6554F10, Task> func = A1444A76F9B94E5B;
			Func<_652C34B1E6554F10, Task> func2 = default;
			Func<_652C34B1E6554F10, Task> value2 = default;
			while (true)
			{
				int num = -2119848851;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(((((-(0x19B2D7F5 ^ -1530242375) ^ (--89897336 - --1379915121)) - -unchecked(unchecked(-1647705740 - 1025891354) * 299578707) - -1586856324) ^ -((~(-2063875573 ^ 0x7D717B86) + --226047407) ^ (-unchecked(1163117038 * -1724354505) + -1629138624))) - (num2 + -(625607639 * (750423749 * -(-977824025 + (643889149 + -803544615))) - 1721159949)) - (((-193651416 ^ --1674249914) - ~(~1718470748)) ^ ~(-(-1214069144)) ^ (183755853 * ((0x2078CBCC ^ -686399780) + ~-260767293 + (0x53F5B43D ^ --2076414201)))) - -(~(1197332148 + 489697255 - (-973381674 - -1619653392))) - (unchecked(798031326 * -128462165) + ~552325096 - ((-619344887 ^ -2056582482) + unchecked(-2094734617 * 1841142002)))) * -1555135503) - -1032912450)) % 5)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						func2 = func;
						value2 = (Func<_652C34B1E6554F10, Task>)_894E434E98594883((Delegate)func2, (Delegate)func3);
						num = -490639997;
						continue;
					case 0u:
						func = Interlocked.CompareExchange(ref A1444A76F9B94E5B, value2, func2);
						num = ((int)num3 * -335578071) ^ 0x434A1DE8;
						continue;
					case 4u:
					{
						int num4;
						int num5;
						if ((object)func != func2)
						{
							num4 = -245931551;
							num5 = num4;
						}
						else
						{
							num4 = -1509482268;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 862719836);
						continue;
					}
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public event Func<Task> _4A29525306EF475B
	{
		[CompilerGenerated]
		add
		{
			throw new Exception();
		}
		[CompilerGenerated]
		remove
		{
			Func<Task> func = EA8D535A09C64613;
			Func<Task> func2 = default;
			Func<Task> value2 = default;
			while (true)
			{
				int num = 1936074843;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((((~(unchecked(((-938242337 ^ -2120013308) + (0x64C915B0 ^ -1801346187) - ~(~unchecked(159056095 * unchecked(-1319164964 + -1382375296)))) * 970730971) - -num2) * -1669566429) ^ 0x2438F6C4) - -(483167081 + -1559469278) - (670379431 - -908602345)) ^ -1072699435)) % 5)
					{
					case 4u:
						break;
					default:
						return;
					case 2u:
						func2 = func;
						num = -1995092852;
						continue;
					case 1u:
					{
						func = Interlocked.CompareExchange(ref EA8D535A09C64613, value2, func2);
						int num4;
						int num5;
						if ((object)func != func2)
						{
							num4 = 848655863;
							num5 = num4;
						}
						else
						{
							num4 = -1089460241;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -896341836);
						continue;
					}
					case 3u:
						value2 = (Func<Task>)_894E434E98594883((Delegate)func2, (Delegate)func3);
						num = (int)(num3 * 1170230337) ^ -490474613;
						continue;
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	public event Func<Task> _32B7149AA751427B
	{
		[CompilerGenerated]
		add
		{
			throw new Exception();
		}
		[CompilerGenerated]
		remove
		{
			Func<Task> func = _1081F0AE0E154571;
			while (true)
			{
				int num = 2127703038;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((-((num2 ^ -(-(~((--1280427816 + -1189785914) * 11909929) ^ -2044876874))) * -1663048681 * -321469451 + (-1955545265 - ~-56676955) - ~307742112) - -1064618998) * 1165359687)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
					{
						Func<Task> func2 = func;
						Func<Task> value2 = (Func<Task>)_894E434E98594883((Delegate)func2, (Delegate)func3);
						func = Interlocked.CompareExchange(ref _1081F0AE0E154571, value2, func2);
						int num4;
						if ((object)func != func2)
						{
							num = 2127703038;
							num4 = num;
						}
						else
						{
							num = 1593827737;
							num4 = num;
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
	}

	public event Func<WebSocketCloseStatus?, string?, bool, bool, Task> _42939D361F994B89
	{
		[CompilerGenerated]
		add
		{
			throw new Exception();
		}
		[CompilerGenerated]
		remove
		{
			Func<WebSocketCloseStatus?, string, bool, bool, Task> func = _0201DB789F804DC5;
			Func<WebSocketCloseStatus?, string, bool, bool, Task> func2 = default;
			Func<WebSocketCloseStatus?, string, bool, bool, Task> value2 = default;
			while (true)
			{
				int num = 1806322360;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((num2 ^ (1653201505 * ((-(-(-1938202725 - ~1543938928)) ^ (-1134386008 - --1235713772)) + (1114149089 + -(-413585315 + -615834191) + (~(--77441340) + (-633298533 + --998488117))) * 883174285))) * 46262451 + unchecked(-1317537565 * 3031724))) % 5)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						func2 = func;
						num = 1952703140;
						continue;
					case 4u:
					{
						func = Interlocked.CompareExchange(ref _0201DB789F804DC5, value2, func2);
						int num4;
						int num5;
						if ((object)func != func2)
						{
							num4 = 1199968774;
							num5 = num4;
						}
						else
						{
							num4 = -1754664039;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1361473299);
						continue;
					}
					case 0u:
						value2 = (Func<WebSocketCloseStatus?, string, bool, bool, Task>)_894E434E98594883((Delegate)func2, (Delegate)func3);
						num = (int)((num3 * 572699747) ^ 0x38EFE1AE);
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public event Func<Task> _027E10BCABB34AD7
	{
		[CompilerGenerated]
		add
		{
			throw new Exception();
		}
		[CompilerGenerated]
		remove
		{
			Func<Task> func = A4143C33375F4661;
			Func<Task> func2 = default;
			Func<Task> value2 = default;
			while (true)
			{
				int num = -980042765;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-((-(597923639 * (unchecked(1440220689 * unchecked(1047290097 * (-804815076 ^ -651716963))) - (-113428221 ^ -(-(~1582120045))))) - num2 + (((-2032532893 * -(-912470239 + 527865818)) ^ -853004945) - 2141504567 * -((-1185199872 ^ -640727501) - unchecked(-1190105373 * 104621445)) - unchecked(unchecked(-631269971 * unchecked(unchecked(239596127 * -1855690965) - unchecked(-1927853724 * -823833175) + ((0x728AD937 ^ -1657402720) - ~-977791639))) * 651601))) ^ -231444720) * 1023395281 * -1914233617 - ~1007087287 - 1702224548)) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 3u:
						func2 = func;
						value2 = (Func<Task>)_894E434E98594883((Delegate)func2, (Delegate)func3);
						num = -1885468796;
						continue;
					case 2u:
					{
						func = Interlocked.CompareExchange(ref A4143C33375F4661, value2, func2);
						int num4;
						int num5;
						if ((object)func != func2)
						{
							num4 = -742233995;
							num5 = num4;
						}
						else
						{
							num4 = -1454556849;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -646489517);
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

	public event Func<Task> E28CDD53BAE04685
	{
		[CompilerGenerated]
		add
		{
			throw new Exception();
		}
		[CompilerGenerated]
		remove
		{
			Func<Task> func = _5F6D537C03A244A0;
			Func<Task> func2 = default;
			while (true)
			{
				int num = 835714448;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~((~(-1152549745 ^ -(-1202600041 + -(-1798505490))) - num2 * 238046801) ^ (((--1233223282 - -96974662 + ~unchecked(1889721058 * -1182511287)) ^ 0x2335693D) * 1217676621)) * 797879713 * 689356523 - (-57232624 ^ 0xAE56A9B))) % 4)
					{
					case 3u:
						break;
					default:
						return;
					case 1u:
					{
						func2 = func;
						Func<Task> value2 = (Func<Task>)_894E434E98594883((Delegate)func2, (Delegate)func3);
						func = Interlocked.CompareExchange(ref _5F6D537C03A244A0, value2, func2);
						num = 416519263;
						continue;
					}
					case 2u:
					{
						int num4;
						int num5;
						if ((object)func != func2)
						{
							num4 = 1751388248;
							num5 = num4;
						}
						else
						{
							num4 = -1715957239;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1077749588);
						continue;
					}
					case 0u:
						return;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EB69693599F64B76(_5E780D61DAD9496E P_0, Func<string> P_1)
	{
		GC.KeepAlive(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_807B969C6FEF4819))]
	public Task _01D019C428634CBA(Uri P_0, CancellationToken P_1 = default(CancellationToken))
	{
		uint num = 2u;
		while (true)
		{
			switch (num)
			{
			case 0u:
				return null;
			case 1u:
				num = 0u;
				break;
			case 2u:
				num = 1u;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(E07C0FAB04EC401D))]
	private Task<bool> _095631238EF24370(Uri P_0, CancellationToken P_1)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(CB205E8EC72E43F8))]
	private Task _8F5BC7DF90C24392(CancellationToken P_0)
	{
		uint num = 1u;
		while (true)
		{
			switch (num)
			{
			case 0u:
				num = 3u;
				break;
			case 1u:
				num = 2u;
				break;
			case 2u:
				num = 0u;
				break;
			case 3u:
				return null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_993921A7551C47D6))]
	private Task _2BBC551851794EDE(bool P_0, bool P_1, WebSocketCloseStatus P_2, string? P_3, Exception? P_4 = null)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2639885942u);
		_993921A7551C47D6 stateMachine = default;
		stateMachine._564EACD9AD1645D4 = AsyncTaskMethodBuilder.Create();
		stateMachine._4D772B0B86E04550 = this;
		while (true)
		{
			int num = -1951923727;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-num2 * -667694851))) % 5)
				{
				case 4u:
					break;
				case 3u:
					stateMachine.BB09ADF13B4044F8 = P_4;
					num = (int)((num3 * 1432624643) ^ 0x554328FD);
					continue;
				case 1u:
					stateMachine._8824676C84414B60 = P_1;
					stateMachine._4044A10D10BE4BFA = P_2;
					stateMachine.CF4A871DB3594CE4 = P_3;
					num = (int)(num3 * 1009135074) ^ -73672701;
					continue;
				case 2u:
					stateMachine._8E3DD53EEE9A4BD1 = P_0;
					num = ((int)num3 * -1978197758) ^ 0x55F78C9B;
					continue;
				default:
					stateMachine._4E1DA69A73AE44A4 = _003CModule_003E._3F57E81A62734AC2<int>(-618989147 ^ (int)obj._184044A093C04AF2(1, 1119370528u));
					stateMachine._564EACD9AD1645D4.Start(ref stateMachine);
					return stateMachine._564EACD9AD1645D4.Task;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_375C35207D974AE3))]
	public Task _34BDF5F647EA44F1(bool P_0, bool P_1, WebSocketCloseStatus P_2 = WebSocketCloseStatus.NormalClosure, string P_3 = "None")
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3676328921u);
		_375C35207D974AE3 stateMachine = default;
		stateMachine._94F1528B93864B4A = AsyncTaskMethodBuilder.Create();
		while (true)
		{
			int num = 1413049913;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((unchecked(-481019745 * -1347113737) + -1011485460 - -(~(470901188 - --1980333406) - -(-unchecked(-706542613 * 1046955054)) - ((0x260D9000 ^ ((0xDC90A4A ^ ((--585006420 ^ -1342791240) + (unchecked(442195303 * -323951661) - unchecked(194709335 * -780178729)))) - -746240884)) - ~num2) * 1024556201)) ^ -1209306609)) % 4)
				{
				case 0u:
					break;
				case 3u:
					stateMachine._40370AE8D56847E1 = this;
					stateMachine._09CE08861BC54079 = P_0;
					num = (int)((num3 * 580481289) ^ 0xD238BBC);
					continue;
				case 1u:
					stateMachine.C56A43B2E86B4D82 = P_1;
					num = ((int)num3 * -1959393029) ^ 0x763908DF;
					continue;
				default:
					stateMachine._3488156B597643EA = P_2;
					stateMachine._921E32759C4B49BD = P_3;
					stateMachine.CEFE1065EA0143C2 = _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x14FE17AE ^ obj._184044A093C04AF2(1, 1053543042u)));
					stateMachine._94F1528B93864B4A.Start(ref stateMachine);
					return stateMachine._94F1528B93864B4A.Task;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_745B1C21A2524D3E))]
	private Task _00AEA2129F244701()
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3197214468u);
		_745B1C21A2524D3E stateMachine = default;
		stateMachine._5B8479301D054353 = AsyncTaskMethodBuilder.Create();
		stateMachine.D4DD3CEF44B6424B = this;
		stateMachine.E0BC3956538E4876 = _003CModule_003E._390073C602714496<int>(-1986746556 ^ (int)obj._184044A093C04AF2(2, 1777486318u));
		stateMachine._5B8479301D054353.Start(ref stateMachine);
		return stateMachine._5B8479301D054353.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _2EBCEBB349FB4F43()
	{
		GC.KeepAlive(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private Task A21AF88AEF814609()
	{
		uint num = 2u;
		while (true)
		{
			switch (num)
			{
			case 0u:
				_2207D0F3AAB445FA((object)DB068CC2AA444C4C);
				A35EDF805C774582((object)DB068CC2AA444C4C);
				num = 4u;
				break;
			case 1u:
				num = 0u;
				break;
			case 2u:
				num = 1u;
				break;
			case 4u:
				_121FC7E3DDA44C65();
				return null;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_7E60177B1ACB4F14))]
	public Task BC87B91F67354814(_652C34B1E6554F10 P_0, CancellationToken P_1 = default(CancellationToken))
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(DCA0EDDA28614E60))]
	public Task<_0001> _9BC08422660541D9<_0001>(_652C34B1E6554F10 P_0, TimeSpan P_1, CancellationToken P_2 = default(CancellationToken)) where _0001 : _652C34B1E6554F10
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1234293566u);
		DCA0EDDA28614E60<_0001> stateMachine = default;
		stateMachine.E2DE21413D134C81 = AsyncTaskMethodBuilder<_0001>.Create();
		stateMachine.BECA2C9C691C4A19 = this;
		stateMachine.A001B1799BE246A1 = P_0;
		stateMachine._84CE347B250C4E36 = P_1;
		stateMachine._0EBCD6E2097541A9 = P_2;
		stateMachine.D03526D743604820 = _003CModule_003E._390073C602714496<int>(-511858692 ^ (int)obj._184044A093C04AF2(5, 793705598u));
		stateMachine.E2DE21413D134C81.Start(ref stateMachine);
		return stateMachine.E2DE21413D134C81.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task F5A6A61E65934D1F(_652C34B1E6554F10 P_0, long P_1, CancellationToken P_2 = default(CancellationToken))
	{
		E70F42657B0F47CF((object)this, (object)P_0, P_2);
		F4C676F84DBA4E25((object)P_0, P_1);
		_2B2CE6FA81974211((object)P_0, false);
		return null;
	}

	[CompilerGenerated]
	private Task _637346E2B54E4258()
	{
		_3353975B6F264371((object)DB068CC2AA444C4C);
		_3353975B6F264371((object)this);
		return null;
	}

	static WebSocketState CBBE600BD0E643BD(object P_0)
	{
		return ((WebSocket)P_0).State;
	}

	static object _11D1055F90F84D70(Delegate P_0, Delegate P_1)
	{
		return Delegate.Combine(P_0, P_1);
	}

	static object _894E434E98594883(Delegate P_0, Delegate P_1)
	{
		return Delegate.Remove(P_0, P_1);
	}

	static object A2883CF93E264FF9()
	{
		return new ClientWebSocket();
	}

	static object A977E38F10864476()
	{
		return new object();
	}

	static void _63C7696E08254366(object P_0, string P_1, object[] P_2)
	{
		((_5E780D61DAD9496E)P_0)._4A918CD4B86142EF(P_1, P_2);
	}

	static bool A33B026B01A443B5(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	static void _0EFC063973E741C6(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static void _2207D0F3AAB445FA(object P_0)
	{
		((CancellationTokenSource)P_0).Cancel();
	}

	static void A35EDF805C774582(object P_0)
	{
		((CancellationTokenSource)P_0).Dispose();
	}

	static object _121FC7E3DDA44C65()
	{
		return Task.CompletedTask;
	}

	static void F4C676F84DBA4E25(object P_0, long P_1)
	{
		((_652C34B1E6554F10)P_0).C4CF7218A3D4459F = P_1;
	}

	static void _2B2CE6FA81974211(object P_0, bool P_1)
	{
		((_652C34B1E6554F10)P_0)._9B60B9CA08874C25 = P_1;
	}

	static object E70F42657B0F47CF(object P_0, object P_1, CancellationToken P_2)
	{
		return ((EB69693599F64B76)P_0).BC87B91F67354814((_652C34B1E6554F10)P_1, P_2);
	}

	static CancellationToken _3353975B6F264371(object P_0)
	{
		return ((CancellationTokenSource)P_0).Token;
	}
}
