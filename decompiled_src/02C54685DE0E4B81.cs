using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Net.WebSockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using SDG.Unturned;

internal class _02C54685DE0E4B81
{
	[Serializable]
	[CompilerGenerated]
	private sealed class D735038FACBE4F5E
	{
		public static readonly D735038FACBE4F5E _003C_003E9 = (D735038FACBE4F5E)_1E8876A7BDCD438B();

		public static Func<string> _003C_003E9__17_1;

		internal string _1E569840F4CA4936()
		{
			_1754342FBEA347D1();
			return null;
		}

		static object _1E8876A7BDCD438B()
		{
			return new D735038FACBE4F5E();
		}

		static string _1754342FBEA347D1()
		{
			return _395E5F59237B4E3F._4C3E983BB0114883();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _24BCE2466670491B : IAsyncStateMachine
	{
		public int C57F5E5C6DFA4A94;

		public AsyncTaskMethodBuilder CEBBD044036643B8;

		public _02C54685DE0E4B81 _8F4AA216B3BA45B8;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			C57F5E5C6DFA4A94 = -2;
			CEBBD044036643B8.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			CEBBD044036643B8.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static void F94C9F33878A4152(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogInformation(P_0, P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct BC0716B8FC364A86 : IAsyncStateMachine
	{
		public int _6EAEBA28B9B54B2C;

		public AsyncTaskMethodBuilder _266B18FBFF004971;

		public _02C54685DE0E4B81 FD2C14B734114709;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_02C54685DE0E4B81 obj = FD2C14B734114709;
			try
			{
				_3E12331BDDC646FA((object)obj, (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0);
				C84F15CC43BE449C(obj._9ABB18DB80F6431E, _003CModule_003E._390073C602714496<string>(-1755742372), Array.Empty<object>());
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num = -441832706;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)((-(((-(0xA1210 ^ 0x3395CA8C) ^ 0x6080EFFD) - ~unchecked((-729106188 ^ 0x6DA41B8F) - -356794540 + -1902099858) - num2) ^ ((-(unchecked(-184964624 + -2084011093) - 1982078567) ^ -1265929408 ^ -(-unchecked(1454482194 * 1488061683))) + unchecked(unchecked(208320329 * -273501156) + (unchecked(1568623821 * -1548411635) - (~-572286232 - unchecked(1465211703 * -1923491799))) + ~(0x12ACC5B8 ^ 0x7EFF26A7)))) - (-(--1654634998 ^ -1975841823) - 176835850)) * 1219328005)) % 3)
						{
						case 2u:
							break;
						default:
							return;
						case 1u:
							goto IL_0167;
						case 0u:
							return;
						}
						break;
						IL_0167:
						_6EAEBA28B9B54B2C = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
						_266B18FBFF004971.SetException(exception);
						num = 1391614421;
					}
				}
			}
			_6EAEBA28B9B54B2C = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			_266B18FBFF004971.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_266B18FBFF004971.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static void _3E12331BDDC646FA(object P_0, bool P_1)
		{
			((_02C54685DE0E4B81)P_0)._19BA68A8CF284E00 = P_1;
		}

		static void C84F15CC43BE449C(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogInformation(P_0, P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _859517ED378E4302 : IAsyncStateMachine
	{
		public int B90231064F464324;

		public AsyncTaskMethodBuilder _0EA3C176BFCC48CF;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			B90231064F464324 = -2;
			_0EA3C176BFCC48CF.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_0EA3C176BFCC48CF.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _739C182D1CDD45C5 : IAsyncStateMachine
	{
		public int _0C29B7A69F4C4752;

		public AsyncTaskMethodBuilder _96E7C072631E432D;

		public _02C54685DE0E4B81 _6A90F8A5D2604BF0;

		private TaskAwaiter _84A474E617C64E6B;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_0C29B7A69F4C4752 = 0;
			_0C29B7A69F4C4752 = -1;
			_0C29B7A69F4C4752 = -1;
			_0C29B7A69F4C4752 = -2;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_96E7C072631E432D.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static void _06102EFDDFCD4901(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogDebug(P_0, P_1, P_2);
		}

		static object _6E8581D93B374C0F(object P_0)
		{
			return ((_02C54685DE0E4B81)P_0)._7B3F63781CFF4AAD();
		}

		static TaskAwaiter _5B740E2692EF48A1(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct C62D056E87BB4E52 : IAsyncStateMachine
	{
		public int _35644122203846A5;

		public AsyncTaskMethodBuilder D0A5FA4176284A43;

		public _02C54685DE0E4B81 _0F0AEA1A4A36477D;

		private TaskAwaiter EC11344891A246DF;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _35644122203846A5;
			_02C54685DE0E4B81 obj = _0F0AEA1A4A36477D;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_0147;
				IL_0014:
				int num2 = 193778818;
				goto IL_0019;
				IL_0019:
				TaskAwaiter awaiter = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(((-(((-(-(~(0x7906F8A8 ^ 0x170B1E00)) ^ -1547312984) - num3 * 473982553) ^ ~(-1860565892 * -922333573)) * -1959381977) ^ -(--663561442)) - (768612245 + -414572881)) ^ -1349538404)) % 7)
					{
					case 2u:
						break;
					case 0u:
						num = (_35644122203846A5 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
						EC11344891A246DF = awaiter;
						D0A5FA4176284A43.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 6u:
					{
						int num5;
						int num6;
						if (awaiter.IsCompleted)
						{
							num5 = 311011406;
							num6 = num5;
						}
						else
						{
							num5 = 951613049;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num4 * 1643631326);
						continue;
					}
					case 1u:
						_555E361415754900(obj._9ABB18DB80F6431E, _003CModule_003E._3F57E81A62734AC2<string>(2023776430), Array.Empty<object>());
						awaiter = _2CBCC520E0DE42A1(_26F83C21F5574E88((object)obj));
						num2 = -1518158910;
						continue;
					case 3u:
						num = (_35644122203846A5 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
						num2 = 2127465182;
						continue;
					case 5u:
						goto IL_0147;
					default:
						awaiter.GetResult();
						goto end_IL_000e;
					}
					break;
				}
				goto IL_0014;
				IL_0147:
				awaiter = EC11344891A246DF;
				EC11344891A246DF = default;
				num2 = 1445830556;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_35644122203846A5 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
				while (true)
				{
					int num7 = 290873461;
					while (true)
					{
						int num3 = num7;
						uint num4;
						switch ((num4 = (uint)(((-(((-(-(~(0x7906F8A8 ^ 0x170B1E00)) ^ -1547312984) - num3 * 473982553) ^ ~(-1860565892 * -922333573)) * -1959381977) ^ -(--663561442)) - (768612245 + -414572881)) ^ -1349538404)) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 1u:
							goto IL_01f5;
						case 2u:
							return;
						}
						break;
						IL_01f5:
						D0A5FA4176284A43.SetException(exception);
						num7 = (int)(num4 * 876109460) ^ -770217226;
					}
				}
			}
			_35644122203846A5 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
			D0A5FA4176284A43.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			D0A5FA4176284A43.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static void _555E361415754900(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogDebug(P_0, P_1, P_2);
		}

		static object _26F83C21F5574E88(object P_0)
		{
			return ((_02C54685DE0E4B81)P_0)._7B3F63781CFF4AAD();
		}

		static TaskAwaiter _2CBCC520E0DE42A1(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct A40068D417F44BED : IAsyncStateMachine
	{
		public int E54236AA15B24D7C;

		public AsyncTaskMethodBuilder _614C4617FA1045B2;

		public _02C54685DE0E4B81 _63242889011642E5;

		public CancellationToken _59878CCF57D04CAA;

		private object F5D539D97E5D43B3;

		private int _862D2D8A60C74FB1;

		private TaskAwaiter<bool> _27B3293680404438;

		private TaskAwaiter FF88C28AA1CF40CA;

		private object _6E2DDB2039A34982;

		private int _49BA781B895E4636;

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
			_614C4617FA1045B2.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static Task<bool> _7B239F7EABC24DEB(object P_0, TimeSpan P_1, CancellationToken P_2)
		{
			return ((SemaphoreSlim)P_0).WaitAsync(P_1, P_2);
		}

		static bool E69A7A0645B54629(object P_0)
		{
			return ((EB69693599F64B76)P_0)._5EB25730C8A14FB2;
		}

		static bool _9745FCF27107416C(object P_0)
		{
			return ((_02C54685DE0E4B81)P_0)._19BA68A8CF284E00;
		}

		static object _2843B0D2CFDC435C(int P_0, CancellationToken P_1)
		{
			return Task.Delay(P_0, P_1);
		}

		static TaskAwaiter _23B9C5AA3BB74861(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static int _6469ECA0E89041DC(object P_0)
		{
			return ((SemaphoreSlim)P_0).CurrentCount;
		}

		static int _9D2C55E689D64154(object P_0)
		{
			return ((SemaphoreSlim)P_0).Release();
		}

		static bool E16F1499AF4F474C(object P_0)
		{
			return ((_365B9A5C91614F23)P_0).DDD5694FE0D84D69;
		}

		static object _052B03920E8D4D86(object P_0)
		{
			return ((_365B9A5C91614F23)P_0)._2D636DB4F07744B8;
		}

		static Task<bool> _9A78E1682AD5458E(object P_0, object P_1, CancellationToken P_2)
		{
			return ((_02C54685DE0E4B81)P_0)._6E01EC7AE9294356((_652C34B1E6554F10)P_1, P_2);
		}

		static string _3947E9F627BF45F1(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		static string A2A8200B3F3D4749(string P_0, string P_1, string P_2)
		{
			return P_0 + P_1 + P_2;
		}

		static void D53AB1B0489748F6(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}

		static void CE71170C7DC648D4(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _3BFCD00718A5475C : IAsyncStateMachine
	{
		public int DA89C0F723E74D28;

		public AsyncTaskMethodBuilder _8E2C2080F27A4215;

		public _02C54685DE0E4B81 _5C286FA9E9804BA7;

		private TaskAwaiter _0098248483324004;

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
			_8E2C2080F27A4215.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _298382F35C554BE5(TimeSpan P_0, CancellationToken P_1)
		{
			return Task.Delay(P_0, P_1);
		}

		static TaskAwaiter _3009F18629374A77(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static string _5F41A1919DC64F4D()
		{
			return _395E5F59237B4E3F._6712D9D04AD2481C();
		}

		static void F00EAF7BC1D94A9D(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static void _2EDACE49F0D547BD(object P_0)
		{
			((_02C54685DE0E4B81)P_0).C870A72D9ECB4B2F();
		}

		static object _7D98DAEBE35642C3(string P_0, Guid P_1, ushort P_2)
		{
			return new _0EBA44DDBA854271(P_0, P_1, P_2);
		}

		static object _5F589F8A0C244ED4(object P_0, object P_1, CancellationToken P_2)
		{
			return ((EB69693599F64B76)P_0).BC87B91F67354814((_652C34B1E6554F10)P_1, P_2);
		}

		static void _25BE7CD45B42467F(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogDebug(P_0, P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct EE16DFEEDF594543 : IAsyncStateMachine
	{
		public int _37C12D9C95974F7B;

		public AsyncTaskMethodBuilder A5BC7B67B748460E;

		public _02C54685DE0E4B81 EBF5AE9D54B14422;

		private string E89235762B374B1D;

		private TaskAwaiter<string> _0BDF0BD68D7343AD;

		private TaskAwaiter<_24CB10E1628641EE> _33530FF7D7BC49F6;

		private FileStream _4FFF977C762B4DF9;

		private TaskAwaiter<bool> _44A3AAAB703945A0;

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
			A5BC7B67B748460E.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object C05DB04E4FEF42F3()
		{
			return Level.info;
		}

		static string _81E748475BD84F36(object P_0)
		{
			return ((LevelInfo)P_0).path;
		}

		static string F24BC430C15242CA(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static bool B0C79E22E8E34C94(string P_0)
		{
			return File.Exists(P_0);
		}

		static Task<string> _0CFE9D682CDA4BC3(string P_0, CancellationToken P_1)
		{
			return C0116C0E74974CCA._580648BE2D68495A(P_0, P_1);
		}

		static object _6B9F5FC1FA8345AA(string P_0)
		{
			return new _279E7B969ADE4364(P_0);
		}

		static bool _53E095D4171E4BC8(object P_0)
		{
			return ((_24CB10E1628641EE)P_0).D816EAA447FE4B09;
		}

		static void DB44F323F2A04CDE(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static bool _81A877F2250341AB(object P_0)
		{
			return ((_24CB10E1628641EE)P_0)._2DBF90D5937C4020;
		}

		static Guid _650EDCC1A32F4DA9(object P_0)
		{
			return ((_24CB10E1628641EE)P_0).E9202630FC09403B;
		}

		static void D8C7A630B6B74073(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogInformation(P_0, P_1, P_2);
		}

		static object _46B13BBA87894F7F(string P_0)
		{
			return File.OpenRead(P_0);
		}

		static long _7F29D836AF134B54(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		static Task<bool> DD317ACBDF604264(object P_0, object P_1, B79532442FF34B1B P_2, long P_3, string P_4)
		{
			return ((_02C54685DE0E4B81)P_0)._3787CDA13EC74733((Stream)P_1, P_2, P_3, P_4);
		}

		static void _14CF8622E29C4430(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _3394AA09403349F1 : IAsyncStateMachine
	{
		public int _80513F65DA954677;

		public AsyncTaskMethodBuilder<bool> BC4F3A5824BC4B52;

		public _652C34B1E6554F10 _2D0BE5512ABA4D4D;

		public _02C54685DE0E4B81 _0F2ABA2A88274631;

		public CancellationToken _597A6478BA904A62;

		private TaskAwaiter _9F9D2B5CDCAA4ACE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_80513F65DA954677 = -1;
			_80513F65DA954677 = 0;
			_80513F65DA954677 = 0;
			_80513F65DA954677 = -2;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			BC4F3A5824BC4B52.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool _3296F3B50FAC4587(object P_0)
		{
			return ((_02C54685DE0E4B81)P_0)._19BA68A8CF284E00;
		}

		static object _174F3D586E104430(object P_0)
		{
			return P_0.GetType();
		}

		static string _24EE1DB505F44140(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		static void BB42B5DACB05475D(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static object _0BC8CD3BE6DE499A(object P_0, object P_1, CancellationToken P_2)
		{
			return ((EB69693599F64B76)P_0).BC87B91F67354814((_652C34B1E6554F10)P_1, P_2);
		}

		static TaskAwaiter AAC67260D6414B0A(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _62FD87A08C794440 : IAsyncStateMachine
	{
		public int C4719AB77E354320;

		public AsyncTaskMethodBuilder<bool> A817855AAA8C473B;

		public _02C54685DE0E4B81 _854050FE0BAF4687;

		public _652C34B1E6554F10 _37C35D2463534A93;

		public CancellationToken _29EF67EF60E04798;

		public TimeSpan? _3550EE9BFCD1457C;

		private TaskAwaiter<bool> _01469D76A3AF43B3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = C4719AB77E354320;
			_02C54685DE0E4B81 obj = _854050FE0BAF4687;
			bool result = default;
			try
			{
				if (num != 0)
				{
					while (true)
					{
						int num2 = -1885447855;
						while (true)
						{
							int num3 = num2;
							uint num4;
							switch ((num4 = (uint)(~((~num3 ^ (585879297 + -(-1264580747 ^ -541561657) - ~(-((--1435655713 ^ -448373650) * 696751353)))) - (~(-(-579252394 - 780844338) - (1149337922 - (-12850932 ^ 0xE26F509))) - unchecked((0x1353C11E ^ 0x66093AF3) + 1117167610))))) % 4)
							{
							case 0u:
								break;
							case 1u:
								goto IL_00c0;
							case 3u:
								goto IL_00e3;
							default:
								goto end_IL_0014;
							}
							break;
							IL_00e3:
							if (_7912FC2835F44B74((object)obj))
							{
								num2 = (int)((num4 * 1509526900) ^ 0x3C6910FC);
								continue;
							}
							goto IL_02df;
							IL_00c0:
							if (C9298BA578954F82((object)obj.E3EEB511799641CD))
							{
								num2 = (int)(num4 * 258674869) ^ -2132036858;
								continue;
							}
							goto IL_02df;
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
						goto IL_0108;
					}
					goto IL_0202;
					IL_0108:
					int num5 = 1593809868;
					goto IL_010d;
					IL_010d:
					TaskAwaiter<bool> awaiter = default;
					while (true)
					{
						int num3 = num5;
						uint num4;
						switch ((num4 = (uint)(~((~num3 ^ (585879297 + -(-1264580747 ^ -541561657) - ~(-((--1435655713 ^ -448373650) * 696751353)))) - (~(-(-579252394 - 780844338) - (1149337922 - (-12850932 ^ 0xE26F509))) - unchecked((0x1353C11E ^ 0x66093AF3) + 1117167610))))) % 7)
						{
						case 3u:
							break;
						case 1u:
						{
							awaiter = _00E8283EB65E4C7A((object)obj, (object)_37C35D2463534A93, _29EF67EF60E04798).GetAwaiter();
							int num6;
							int num7;
							if (!awaiter.IsCompleted)
							{
								num6 = -1402633452;
								num7 = num6;
							}
							else
							{
								num6 = -1815456357;
								num7 = num6;
							}
							num5 = num6 ^ ((int)num4 * -1199400369);
							continue;
						}
						case 2u:
							goto IL_0202;
						case 0u:
							_01469D76A3AF43B3 = awaiter;
							A817855AAA8C473B.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 6u:
							num = (C4719AB77E354320 = _003CModule_003E._390073C602714496<int>(-736908096));
							num5 = 1465155241;
							continue;
						case 4u:
							num = (C4719AB77E354320 = _003CModule_003E._390073C602714496<int>(2131963235));
							num5 = -2014222016;
							continue;
						default:
							result = awaiter.GetResult();
							goto end_IL_0102;
						}
						break;
					}
					goto IL_0108;
					IL_0202:
					awaiter = _01469D76A3AF43B3;
					_01469D76A3AF43B3 = default;
					num5 = -1512027070;
					goto IL_010d;
					end_IL_0102:;
				}
				catch (Exception ex)
				{
					_2242401835E34683(obj._9ABB18DB80F6431E, _9D1906C04B7E4FC7(_003CModule_003E._390073C602714496<string>(660543877), _18CDBD5EA0ED4597(_3A8591F1764D4C58((object)_37C35D2463534A93)), _003CModule_003E._390073C602714496<string>(-1750873027), E5AEF3F690B84F53((object)ex)), Array.Empty<object>());
					goto IL_02df;
				}
				goto end_IL_000e;
				IL_02f4:
				int num8;
				bool flag = default;
				while (true)
				{
					int num3 = num8;
					uint num4;
					switch ((num4 = (uint)(~((~num3 ^ (585879297 + -(-1264580747 ^ -541561657) - ~(-((--1435655713 ^ -448373650) * 696751353)))) - (~(-(-579252394 - 780844338) - (1149337922 - (-12850932 ^ 0xE26F509))) - unchecked((0x1353C11E ^ 0x66093AF3) + 1117167610))))) % 14)
					{
					case 13u:
						break;
					case 3u:
						goto IL_03c7;
					case 12u:
						goto IL_03f4;
					case 0u:
						A02EB5B9DDC24155((object)obj.EF806ABEE3244F23);
						num8 = (int)(num4 * 1929652842) ^ -1565623020;
						continue;
					case 9u:
						goto end_IL_000e;
					case 7u:
						result = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
						num8 = -2070638785;
						continue;
					case 5u:
					{
						int num13;
						int num14;
						if (!(_37C35D2463534A93 is _0EBA44DDBA854271))
						{
							num13 = 1777503624;
							num14 = num13;
						}
						else
						{
							num13 = 2139942761;
							num14 = num13;
						}
						num8 = num13 ^ ((int)num4 * -732281568);
						continue;
					}
					case 8u:
						flag = (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
						num8 = 1784476508;
						continue;
					case 2u:
						_08545855F5844A27(obj._9ABB18DB80F6431E, _7917987890F04C9E(_003CModule_003E.F84FA79ABE6944BB<string>(1119828740), _18CDBD5EA0ED4597(_3A8591F1764D4C58((object)_37C35D2463534A93))), Array.Empty<object>());
						result = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
						goto end_IL_000e;
					case 11u:
					{
						_365B9A5C91614F23 item = (_365B9A5C91614F23)_3F7FA0EF350A41D2((object)_37C35D2463534A93, _3550EE9BFCD1457C ?? obj.D2A8BF46A8C84978);
						obj.EBEDBE21A33B4DB6.Enqueue(item);
						num8 = -1596906514;
						continue;
					}
					case 10u:
					{
						int num11;
						int num12;
						if (_964B2AFD371C4925((object)obj.EF806ABEE3244F23) == 0)
						{
							num11 = -1434680712;
							num12 = num11;
						}
						else
						{
							num11 = 1946139072;
							num12 = num11;
						}
						num8 = num11 ^ (int)(num4 * 242641515);
						continue;
					}
					case 4u:
					{
						int num9;
						int num10;
						if (!(_37C35D2463534A93 is BF6E7C343D674996))
						{
							num9 = -285253799;
							num10 = num9;
						}
						else
						{
							num9 = 801506509;
							num10 = num9;
						}
						num8 = num9 ^ (int)(num4 * 1679974846);
						continue;
					}
					case 1u:
						goto IL_057f;
					default:
						result = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019) != 0;
						goto end_IL_000e;
					}
					break;
					IL_03f4:
					int num15;
					if (flag)
					{
						num8 = 2051235233;
						num15 = num8;
					}
					else
					{
						num8 = 1226816971;
						num15 = num8;
					}
					continue;
					IL_03c7:
					int num16;
					if (obj.EBEDBE21A33B4DB6.Count < _003CModule_003E._8B9C7B12B1AE4949<int>(1417699913))
					{
						num8 = -1286164971;
						num16 = num8;
					}
					else
					{
						num8 = -1462801226;
						num16 = num8;
					}
				}
				goto IL_02ef;
				IL_057f:
				flag = (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0;
				num8 = 1784476508;
				goto IL_02f4;
				IL_02ef:
				num8 = -2039682244;
				goto IL_02f4;
				IL_02df:
				if (!(_37C35D2463534A93 is C44631BE80E84975))
				{
					goto IL_02ef;
				}
				goto IL_057f;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				C4719AB77E354320 = _003CModule_003E._390073C602714496<int>(818201983);
				A817855AAA8C473B.SetException(exception);
				return;
			}
			C4719AB77E354320 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			while (true)
			{
				int num17 = 1284955014;
				while (true)
				{
					int num3 = num17;
					uint num4;
					switch ((num4 = (uint)(~((~num3 ^ (585879297 + -(-1264580747 ^ -541561657) - ~(-((--1435655713 ^ -448373650) * 696751353)))) - (~(-(-579252394 - 780844338) - (1149337922 - (-12850932 ^ 0xE26F509))) - unchecked((0x1353C11E ^ 0x66093AF3) + 1117167610))))) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0686;
					case 2u:
						return;
					}
					break;
					IL_0686:
					A817855AAA8C473B.SetResult(result);
					num17 = (int)(num4 * 417058014) ^ -729308913;
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
			A817855AAA8C473B.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool C9298BA578954F82(object P_0)
		{
			return ((EB69693599F64B76)P_0)._5EB25730C8A14FB2;
		}

		static bool _7912FC2835F44B74(object P_0)
		{
			return ((_02C54685DE0E4B81)P_0)._19BA68A8CF284E00;
		}

		static Task<bool> _00E8283EB65E4C7A(object P_0, object P_1, CancellationToken P_2)
		{
			return ((_02C54685DE0E4B81)P_0)._6E01EC7AE9294356((_652C34B1E6554F10)P_1, P_2);
		}

		static object _3A8591F1764D4C58(object P_0)
		{
			return P_0.GetType();
		}

		static string _18CDBD5EA0ED4597(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		static string E5AEF3F690B84F53(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		static string _9D1906C04B7E4FC7(string P_0, string P_1, string P_2, string P_3)
		{
			return P_0 + P_1 + P_2 + P_3;
		}

		static void _2242401835E34683(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}

		static string _7917987890F04C9E(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static void _08545855F5844A27(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static object _3F7FA0EF350A41D2(object P_0, TimeSpan P_1)
		{
			return new _365B9A5C91614F23((_652C34B1E6554F10)P_0, P_1);
		}

		static int _964B2AFD371C4925(object P_0)
		{
			return ((SemaphoreSlim)P_0).CurrentCount;
		}

		static int A02EB5B9DDC24155(object P_0)
		{
			return ((SemaphoreSlim)P_0).Release();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct E509931EC4FC485F : IAsyncStateMachine
	{
		public int _1297016BCA6942A0;

		public AsyncTaskMethodBuilder<bool> _3977C2630AEF436B;

		public Stream _25F503696DA14A07;

		public _02C54685DE0E4B81 EB790ED028394273;

		public string _6587A542945B4A2A;

		public B79532442FF34B1B _28CDDCACE00D4D4B;

		public long _5D2C324E16124BA6;

		private byte[] C7077B41893F4E8E;

		private int _5B507CD58A2C46A8;

		private int _91CF0A8B21824EBC;

		private byte[] _0FC684E5E2D34853;

		private TaskAwaiter<int> _5F8775F325BC4BE1;

		private TaskAwaiter<bool> _3089FF315F1A45AF;

		private long AB6F25F59E4B4761;

		private ValueTaskAwaiter<int> _2AAFDFB71AED4389;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _1297016BCA6942A0;
			_02C54685DE0E4B81 obj = EB790ED028394273;
			bool result2;
			try
			{
				int num2;
				TaskAwaiter<bool> awaiter = default;
				TaskAwaiter<int> awaiter2 = default;
				int result = default;
				switch (num)
				{
				default:
					num2 = 1590993213;
					goto IL_0029;
				case 1:
					goto IL_0278;
				case 0:
					goto IL_028a;
				case 2:
				case 3:
					break;
					IL_0029:
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(-(-(~(~(-num3) * -2130792745 + -unchecked((-753349869 + 1867300122) * -183216647)) ^ -1360636817)))) % 33)
						{
						case 16u:
							break;
						case 11u:
							_3089FF315F1A45AF = default;
							num = (_1297016BCA6942A0 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num2 = 2026511787;
							continue;
						case 5u:
							_6587A542945B4A2A = Guid.NewGuid().ToString();
							num2 = (int)(num4 * 2117018228) ^ -943296124;
							continue;
						case 10u:
							result2 = (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
							goto end_IL_000e;
						case 20u:
							BCB8AB5BA3044632((object)_25F503696DA14A07, (long)_003CModule_003E._58ECCB512F2A43AC<int>(352679804), (SeekOrigin)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
							num2 = -12311365;
							continue;
						case 23u:
							BCB8AB5BA3044632((object)_25F503696DA14A07, (long)_003CModule_003E._390073C602714496<int>(2131963235), (SeekOrigin)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
							C7077B41893F4E8E = new byte[_003CModule_003E._58ECCB512F2A43AC<int>(-1633929632)];
							_5B507CD58A2C46A8 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563);
							num2 = 1784585235;
							continue;
						case 30u:
							goto IL_01ea;
						case 31u:
							DE0AF44E42724A6E(obj._9ABB18DB80F6431E, _003CModule_003E._8B9C7B12B1AE4949<string>(123036974), Array.Empty<object>());
							result2 = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
							goto end_IL_000e;
						case 24u:
							goto IL_0250;
						case 29u:
							goto IL_0278;
						case 8u:
							goto IL_028a;
						case 17u:
						{
							ILogger val2 = obj._9ABB18DB80F6431E;
							string text2 = _003CModule_003E._390073C602714496<string>(-2136292254);
							object[] array2 = new object[_003CModule_003E._3F57E81A62734AC2<int>(1017304263)];
							array2[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)] = _6587A542945B4A2A;
							DE0AF44E42724A6E(val2, text2, array2);
							result2 = (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
							goto end_IL_000e;
						}
						case 6u:
							result2 = (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
							goto end_IL_000e;
						case 32u:
							return;
						case 26u:
							goto IL_0348;
						case 1u:
						{
							awaiter = _6AC28554CB964501((object)obj, _6664D416A8D448BD(_6587A542945B4A2A, _28CDDCACE00D4D4B, C7077B41893F4E8E), obj.FF453AB557DC44BF).GetAwaiter();
							int num7;
							int num8;
							if (awaiter.IsCompleted)
							{
								num7 = 1114507735;
								num8 = num7;
							}
							else
							{
								num7 = 250506201;
								num8 = num7;
							}
							num2 = num7 ^ (int)(num4 * 64940028);
							continue;
						}
						case 18u:
						{
							int num11;
							int num12;
							if (E2B45AEF7EF8462F((object)_25F503696DA14A07))
							{
								num11 = 1639292315;
								num12 = num11;
							}
							else
							{
								num11 = 456043626;
								num12 = num11;
							}
							num2 = num11 ^ (int)(num4 * 400156976);
							continue;
						}
						case 7u:
							goto IL_03f0;
						case 2u:
							num2 = (int)(num4 * 502948905) ^ -409587737;
							continue;
						case 22u:
							num = (_1297016BCA6942A0 = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
							_5F8775F325BC4BE1 = awaiter2;
							_3977C2630AEF436B.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num2 = 896383333;
							continue;
						case 4u:
						{
							int num9;
							int num10;
							if (result != 0)
							{
								num9 = -1092984446;
								num10 = num9;
							}
							else
							{
								num9 = -598464832;
								num10 = num9;
							}
							num2 = num9 ^ (int)(num4 * 1844584768);
							continue;
						}
						case 9u:
							num = (_1297016BCA6942A0 = _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
							_3089FF315F1A45AF = awaiter;
							_3977C2630AEF436B.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num2 = -81075906;
							continue;
						case 21u:
						{
							ILogger val = obj._9ABB18DB80F6431E;
							string text = _003CModule_003E._390073C602714496<string>(275124650);
							object[] array = new object[_003CModule_003E._58ECCB512F2A43AC<int>(1006217019)];
							array[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)] = BBDF26622B48439A((object)_25F503696DA14A07);
							DE0AF44E42724A6E(val, text, array);
							num2 = 275464622;
							continue;
						}
						case 3u:
						{
							int num5;
							int num6;
							if (!awaiter2.IsCompleted)
							{
								num5 = -846056369;
								num6 = num5;
							}
							else
							{
								num5 = 2057545126;
								num6 = num5;
							}
							num2 = num5 ^ ((int)num4 * -663553852);
							continue;
						}
						case 19u:
							result = awaiter2.GetResult();
							num2 = -1048050738;
							continue;
						case 12u:
							_5B507CD58A2C46A8 += result;
							num2 = -1808391466;
							continue;
						case 27u:
							goto IL_054a;
						case 13u:
							return;
						case 25u:
							DE0AF44E42724A6E(obj._9ABB18DB80F6431E, _003CModule_003E._58ECCB512F2A43AC<string>(-294550857), Array.Empty<object>());
							num2 = -100164972;
							continue;
						case 14u:
							awaiter2 = _628A160F7773414E((object)_25F503696DA14A07, C7077B41893F4E8E, _5B507CD58A2C46A8, _003CModule_003E._3F57E81A62734AC2<int>(-1597598054) - _5B507CD58A2C46A8, obj.FF453AB557DC44BF).GetAwaiter();
							num2 = 1902483348;
							continue;
						case 0u:
							awaiter.GetResult();
							num2 = 1994678779;
							continue;
						case 28u:
							_91CF0A8B21824EBC = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845);
							_0FC684E5E2D34853 = ArrayPool<byte>.Shared.Rent(_003CModule_003E._390073C602714496<int>(1434334845));
							num2 = 611555058;
							continue;
						default:
							goto end_IL_000f;
						}
						break;
						IL_054a:
						int num13;
						if (!_9C9A31CC4104447A(_6587A542945B4A2A))
						{
							num2 = -850417804;
							num13 = num2;
						}
						else
						{
							num2 = -449597528;
							num13 = num2;
						}
						continue;
						IL_01ea:
						int num14;
						if (BBDF26622B48439A((object)_25F503696DA14A07) >= _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
						{
							num2 = 2027491369;
							num14 = num2;
						}
						else
						{
							num2 = 234378682;
							num14 = num2;
						}
						continue;
						IL_0348:
						int num15;
						if (BBDF26622B48439A((object)_25F503696DA14A07) < _003CModule_003E._58ECCB512F2A43AC<int>(-1633929632))
						{
							num2 = 2084886040;
							num15 = num2;
						}
						else
						{
							num2 = 271294501;
							num15 = num2;
						}
						continue;
						IL_03f0:
						int num16;
						if (_39E25E1134D44C90((object)obj))
						{
							num2 = -399256373;
							num16 = num2;
						}
						else
						{
							num2 = -791206868;
							num16 = num2;
						}
						continue;
						IL_0250:
						int num17;
						if (_5B507CD58A2C46A8 < _003CModule_003E.F84FA79ABE6944BB<int>(-1647478807))
						{
							num2 = -1475123452;
							num17 = num2;
						}
						else
						{
							num2 = 1900605988;
							num17 = num2;
						}
					}
					goto default;
					IL_028a:
					awaiter2 = _5F8775F325BC4BE1;
					_5F8775F325BC4BE1 = default;
					num = (_1297016BCA6942A0 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
					num2 = -1774246618;
					goto IL_0029;
					IL_0278:
					awaiter = _3089FF315F1A45AF;
					num2 = -668478306;
					goto IL_0029;
					end_IL_000f:
					break;
				}
				try
				{
					if (num != _003CModule_003E._390073C602714496<int>(1302522752))
					{
						goto IL_0647;
					}
					goto IL_0824;
					IL_0647:
					int num18 = -1911519831;
					goto IL_064c;
					IL_064c:
					byte[] array3 = default;
					int result3 = default;
					bool flag = default;
					ValueTaskAwaiter<int> awaiter3 = default;
					while (true)
					{
						int num3 = num18;
						uint num4;
						switch ((num4 = (uint)(-(-(~(~(-num3) * -2130792745 + -unchecked((-753349869 + 1867300122) * -183216647)) ^ -1360636817)))) % 21)
						{
						case 9u:
							break;
						default:
							goto end_IL_0635;
						case 2u:
							_3089FF315F1A45AF = default;
							num18 = (int)((num4 * 492175938) ^ 0x1595773);
							continue;
						case 12u:
							return;
						case 20u:
							num = (_1297016BCA6942A0 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num18 = -817059898;
							continue;
						case 1u:
							goto IL_0739;
						case 17u:
							awaiter.GetResult();
							num18 = 733201591;
							continue;
						case 11u:
							array3 = new byte[result3];
							num18 = -162155191;
							continue;
						case 13u:
							num = (_1297016BCA6942A0 = _003CModule_003E._58ECCB512F2A43AC<int>(1208532887));
							_3089FF315F1A45AF = awaiter;
							num18 = -784414373;
							continue;
						case 8u:
							num = (_1297016BCA6942A0 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num18 = 994311150;
							continue;
						case 14u:
							_0ACEC282C35C418E((Array)_0FC684E5E2D34853, _003CModule_003E.F84FA79ABE6944BB<int>(1398637845), (Array)array3, _003CModule_003E._3F57E81A62734AC2<int>(-1803194042), result3);
							AB6F25F59E4B4761 += result3;
							flag = ((AB6F25F59E4B4761 < _5D2C324E16124BA6) ? 1 : 0) == _003CModule_003E.F84FA79ABE6944BB<int>(1398637845);
							num18 = 1620596212;
							continue;
						case 10u:
							goto IL_0824;
						case 6u:
							_3977C2630AEF436B.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 19u:
							_2AAFDFB71AED4389 = default;
							num18 = (int)(num4 * 1583055220) ^ -1664652870;
							continue;
						case 4u:
							goto IL_087b;
						case 15u:
							num = (_1297016BCA6942A0 = _003CModule_003E._8B9C7B12B1AE4949<int>(944380096));
							_2AAFDFB71AED4389 = awaiter3;
							_3977C2630AEF436B.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
							num18 = -270733296;
							continue;
						case 18u:
							num18 = ((int)num4 * -853279893) ^ -384113741;
							continue;
						case 0u:
							goto IL_092b;
						case 7u:
							awaiter3 = _2AAFDFB71AED4389;
							num18 = 1703452394;
							continue;
						case 16u:
							AB6F25F59E4B4761 = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845);
							num18 = -1189128824;
							continue;
						case 5u:
							goto IL_099e;
						case 3u:
							goto end_IL_0635;
						}
						break;
						IL_099e:
						int num19;
						if ((result3 = awaiter3.GetResult()) <= _003CModule_003E._390073C602714496<int>(2131963235))
						{
							num18 = 79281380;
							num19 = num18;
						}
						else
						{
							num18 = 321771850;
							num19 = num18;
						}
						continue;
						IL_087b:
						string text3 = _6587A542945B4A2A;
						byte[] array4 = array3;
						int num20 = _91CF0A8B21824EBC;
						_91CF0A8B21824EBC = num20 + _003CModule_003E._8B9C7B12B1AE4949<int>(350091668);
						C99D72A8C2334B20 c99D72A8C2334B = (C99D72A8C2334B20)A4E21FA0CDE6415E(text3, array4, (long)num20, flag, _28CDDCACE00D4D4B);
						awaiter = _6AC28554CB964501((object)obj, (object)c99D72A8C2334B, obj.FF453AB557DC44BF).GetAwaiter();
						int num21;
						if (awaiter.IsCompleted)
						{
							num18 = 994311150;
							num21 = num18;
						}
						else
						{
							num18 = -1725946027;
							num21 = num18;
						}
						continue;
						IL_0739:
						int num22;
						if (num == _003CModule_003E._3F57E81A62734AC2<int>(-1030831117))
						{
							num18 = -95179427;
							num22 = num18;
						}
						else
						{
							num18 = 1344185318;
							num22 = num18;
						}
						continue;
						IL_092b:
						awaiter3 = _8AB7587A81524786((object)_25F503696DA14A07, (Memory<byte>)_0FC684E5E2D34853, obj.FF453AB557DC44BF).GetAwaiter();
						int num23;
						if (awaiter3.IsCompleted)
						{
							num18 = -817059898;
							num23 = num18;
						}
						else
						{
							num18 = 2122913610;
							num23 = num18;
						}
					}
					goto IL_0647;
					IL_0824:
					awaiter = _3089FF315F1A45AF;
					num18 = -193636363;
					goto IL_064c;
					end_IL_0635:;
				}
				finally
				{
					if (num < _003CModule_003E.F84FA79ABE6944BB<int>(1398637845))
					{
						while (true)
						{
							IL_09de:
							int num24 = -1449813276;
							while (true)
							{
								int num3 = num24;
								uint num4;
								switch ((num4 = (uint)(-(-(~(~(-num3) * -2130792745 + -unchecked((-753349869 + 1867300122) * -183216647)) ^ -1360636817)))) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_09e3;
								case 2u:
									goto IL_0a2f;
								case 1u:
									goto end_IL_09e3;
								}
								goto IL_09de;
								IL_0a2f:
								ArrayPool<byte>.Shared.Return(_0FC684E5E2D34853, (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0);
								num24 = -775331403;
								continue;
								end_IL_09e3:
								break;
							}
							break;
						}
					}
				}
				result2 = (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_1297016BCA6942A0 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				while (true)
				{
					int num25 = -1105703582;
					while (true)
					{
						int num3 = num25;
						uint num4;
						switch ((num4 = (uint)(-(-(~(~(-num3) * -2130792745 + -unchecked((-753349869 + 1867300122) * -183216647)) ^ -1360636817)))) % 4)
						{
						case 0u:
							break;
						case 2u:
							C7077B41893F4E8E = null;
							num25 = ((int)num4 * -815895519) ^ 0x5852FCD;
							continue;
						case 1u:
							_0FC684E5E2D34853 = null;
							num25 = ((int)num4 * -954697017) ^ -248636562;
							continue;
						default:
							_3977C2630AEF436B.SetException(exception);
							return;
						}
						break;
					}
				}
			}
			_1297016BCA6942A0 = _003CModule_003E._390073C602714496<int>(818201983);
			while (true)
			{
				int num26 = -741404340;
				while (true)
				{
					int num3 = num26;
					uint num4;
					switch ((num4 = (uint)(-(-(~(~(-num3) * -2130792745 + -unchecked((-753349869 + 1867300122) * -183216647)) ^ -1360636817)))) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_0b71;
					case 0u:
						return;
					}
					break;
					IL_0b71:
					C7077B41893F4E8E = null;
					_0FC684E5E2D34853 = null;
					_3977C2630AEF436B.SetResult(result2);
					num26 = (int)((num4 * 1581587512) ^ 0x67B000D2);
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
			_3977C2630AEF436B.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool E2B45AEF7EF8462F(object P_0)
		{
			return ((Stream)P_0).CanSeek;
		}

		static long BBDF26622B48439A(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		static void DE0AF44E42724A6E(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static bool _39E25E1134D44C90(object P_0)
		{
			return ((_02C54685DE0E4B81)P_0)._19BA68A8CF284E00;
		}

		static bool _9C9A31CC4104447A(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}

		static long BCB8AB5BA3044632(object P_0, long P_1, SeekOrigin P_2)
		{
			return ((Stream)P_0).Seek(P_1, P_2);
		}

		static Task<int> _628A160F7773414E(object P_0, byte[] P_1, int P_2, int P_3, CancellationToken P_4)
		{
			return ((Stream)P_0).ReadAsync(P_1, P_2, P_3, P_4);
		}

		static object _6664D416A8D448BD(string P_0, B79532442FF34B1B P_1, byte[] P_2)
		{
			return new _3CD537B3A9A44CB2(P_0, P_1, P_2);
		}

		static Task<bool> _6AC28554CB964501(object P_0, object P_1, CancellationToken P_2)
		{
			return ((_02C54685DE0E4B81)P_0)._6E01EC7AE9294356((_652C34B1E6554F10)P_1, P_2);
		}

		static void _0ACEC282C35C418E(Array P_0, int P_1, Array P_2, int P_3, int P_4)
		{
			Array.Copy(P_0, P_1, P_2, P_3, P_4);
		}

		static object A4E21FA0CDE6415E(string P_0, byte[] P_1, long P_2, bool P_3, B79532442FF34B1B P_4)
		{
			return new C99D72A8C2334B20(P_0, P_1, P_2, P_3, P_4);
		}

		static ValueTask<int> _8AB7587A81524786(object P_0, Memory<byte> P_1, CancellationToken P_2)
		{
			return ((Stream)P_0).ReadAsync(P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _3A8A2A8CACC148DA : IAsyncStateMachine
	{
		public int _649CF5BE1B574A2A;

		public AsyncTaskMethodBuilder _410D294B220F4D41;

		public _02C54685DE0E4B81 _53395E1943EE4F37;

		public CancellationToken CEDDB0532A5A469A;

		private TaskAwaiter<bool> DEC29FDF4E5E4303;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _91CC97A155DC4C01;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_649CF5BE1B574A2A = 0;
			_649CF5BE1B574A2A = -1;
			_649CF5BE1B574A2A = 1;
			_649CF5BE1B574A2A = -1;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_410D294B220F4D41.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static Task<bool> _208179AC625E410D()
		{
			return _6487285FB41C4853._46F5E45364394CBB();
		}

		static object _0B8EE9539D004DFD(string P_0)
		{
			return new Uri(P_0);
		}

		static object _10C6D6E23D764292(object P_0, object P_1, CancellationToken P_2)
		{
			return ((EB69693599F64B76)P_0)._01D019C428634CBA((Uri)P_1, P_2);
		}

		static ConfiguredTaskAwaitable A0D1A3490CB346C7(object P_0, bool P_1)
		{
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		static void BFF8175CE1254DFE(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogInformation(P_0, P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct AC9B681A16954282 : IAsyncStateMachine
	{
		public int E1211B801BBE4661;

		public AsyncTaskMethodBuilder A50F82CC85D24F18;

		public _02C54685DE0E4B81 _8DC65C7D683B45E2;

		private TaskAwaiter _64C3B27DD7764573;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = E1211B801BBE4661;
			_02C54685DE0E4B81 obj = _8DC65C7D683B45E2;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_015c;
				IL_0014:
				int num2 = 1228742548;
				goto IL_0019;
				IL_0019:
				TaskAwaiter awaiter = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(-(-(~(-num3))))) % 10)
					{
					case 0u:
						break;
					default:
						goto end_IL_000e;
					case 4u:
						_64C3B27DD7764573 = default;
						num = (E1211B801BBE4661 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
						num2 = 1936486824;
						continue;
					case 1u:
						return;
					case 7u:
					{
						CancellationTokenSource? cancellationTokenSource = obj._91CC2A56EA1B4D5E;
						if (cancellationTokenSource == null)
						{
							goto IL_00d1;
						}
						_54613E58CACC4AA5((object)cancellationTokenSource);
						num2 = 365514053;
						continue;
					}
					case 8u:
						A50F82CC85D24F18.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = (int)((num4 * 1670820873) ^ 0x30823CBC);
						continue;
					case 2u:
						goto IL_00d1;
					case 3u:
						awaiter.GetResult();
						A2E1B93E24F64685(obj._9ABB18DB80F6431E, _003CModule_003E._8B9C7B12B1AE4949<string>(772305489), Array.Empty<object>());
						num2 = 1540078526;
						continue;
					case 6u:
						goto IL_015c;
					case 9u:
						num = (E1211B801BBE4661 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563));
						_64C3B27DD7764573 = awaiter;
						num2 = 1043518509;
						continue;
					case 5u:
						goto end_IL_000e;
					}
					break;
					IL_00d1:
					awaiter = _144856109F4040CF(_1BED0EDF41624D36((object)obj.E3EEB511799641CD, (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0, (WebSocketCloseStatus)_003CModule_003E._58ECCB512F2A43AC<int>(-1952847299), _003CModule_003E._58ECCB512F2A43AC<string>(-1605743651)));
					int num5;
					if (awaiter.IsCompleted)
					{
						num2 = 1936486824;
						num5 = num2;
					}
					else
					{
						num2 = 1241606910;
						num5 = num2;
					}
				}
				goto IL_0014;
				IL_015c:
				awaiter = _64C3B27DD7764573;
				num2 = 314964235;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num6 = 1240786887;
					while (true)
					{
						int num3 = num6;
						uint num4;
						switch ((num4 = (uint)(-(-(~(-num3))))) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 2u:
							goto IL_01ba;
						case 1u:
							return;
						}
						break;
						IL_01ba:
						E1211B801BBE4661 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
						A50F82CC85D24F18.SetException(exception);
						num6 = 877866965;
					}
				}
			}
			E1211B801BBE4661 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			while (true)
			{
				int num7 = 1443829019;
				while (true)
				{
					int num3 = num7;
					uint num4;
					switch ((num4 = (uint)(-(-(~(-num3))))) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0218;
					case 2u:
						return;
					}
					break;
					IL_0218:
					A50F82CC85D24F18.SetResult();
					num7 = (int)((num4 * 34279526) ^ 0x6D4EF77F);
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
			A50F82CC85D24F18.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static void _54613E58CACC4AA5(object P_0)
		{
			((CancellationTokenSource)P_0).Cancel();
		}

		static object _1BED0EDF41624D36(object P_0, bool P_1, bool P_2, WebSocketCloseStatus P_3, string P_4)
		{
			return ((EB69693599F64B76)P_0)._34BDF5F647EA44F1(P_1, P_2, P_3, P_4);
		}

		static TaskAwaiter _144856109F4040CF(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static void A2E1B93E24F64685(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogInformation(P_0, P_1, P_2);
		}
	}

	private readonly EB69693599F64B76 E3EEB511799641CD;

	private readonly ConcurrentQueue<_365B9A5C91614F23> EBEDBE21A33B4DB6;

	private readonly SemaphoreSlim EF806ABEE3244F23;

	private Task? _48DEC019724C41DD;

	private CancellationTokenSource? _91CC2A56EA1B4D5E;

	private const int _9951DAB4764A4675 = 100000;

	private readonly TimeSpan D2A8BF46A8C84978;

	private readonly string _6CCF9FF588F548B7;

	private readonly string EDB7ACD80B2B4D99;

	internal readonly CDD77F4B61A645F5 _7CC404D458D24C39;

	[CompilerGenerated]
	private bool A80A0EE662B6414C;

	internal readonly _793AD9726F0B488F FEF1EDB6312C4632;

	internal CancellationToken FF453AB557DC44BF;

	private readonly ILogger _9ABB18DB80F6431E;

	private const int _6FDC0BB6C48E48CE = 512;

	private string? _9A2F386704484379;

	public bool DB01519AB1BE4F53;

	internal bool _19BA68A8CF284E00
	{
		[CompilerGenerated]
		get
		{
			return A80A0EE662B6414C;
		}
		[CompilerGenerated]
		set
		{
			A80A0EE662B6414C = a80A0EE662B6414C;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _02C54685DE0E4B81(ILogger P_0)
	{
		ConcurrentQueue<_365B9A5C91614F23> eBEDBE21A33B4DB = null;
		_5A690657AF774003(0);
		_75BB81D3BDEE425E._22ED7975D32246BC._95D359E5341A4936((object)1027680148);
		_606938F5F7B24508();
		_9B8024EA81184A6D();
		BDFE184CA8AE49F2();
		B9AC42DA663347C4((object)P_0);
		EBEDBE21A33B4DB6 = eBEDBE21A33B4DB;
		EF806ABEE3244F23 = null;
		_9ABB18DB80F6431E = null;
		D2A8BF46A8C84978 = default;
		_6CCF9FF588F548B7 = null;
		_91CC2A56EA1B4D5E = null;
		_48DEC019724C41DD = null;
		E1E49D90BFD0484B();
		_7CC404D458D24C39 = null;
		EDB7ACD80B2B4D99 = null;
		throw new Exception();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_3A8A2A8CACC148DA))]
	public Task _73E9E2A3C0BD48F5(CancellationToken P_0 = default(CancellationToken))
	{
		return null;
	}

	private void E4562FFAB4464AE1()
	{
		uint num = 2u;
		while (num != 1 && num == 2)
		{
			num = 1u;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_739C182D1CDD45C5))]
	private Task _204ED62F8A484557()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_859517ED378E4302))]
	private Task _44AD45EE94144118()
	{
		uint num = 3u;
		while (true)
		{
			switch (num)
			{
			case 1u:
				return null;
			case 2u:
				num = 1u;
				break;
			case 3u:
				num = 2u;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_24BCE2466670491B))]
	private Task _596C5A2B9AB24C48()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(C62D056E87BB4E52))]
	private Task _7206E2C786A7442C()
	{
		C62D056E87BB4E52 stateMachine = default;
		stateMachine.D0A5FA4176284A43 = AsyncTaskMethodBuilder.Create();
		stateMachine._0F0AEA1A4A36477D = this;
		stateMachine._35644122203846A5 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120);
		stateMachine.D0A5FA4176284A43.Start(ref stateMachine);
		return stateMachine.D0A5FA4176284A43.Task;
	}

	private Task C7AFCA690C7A459F(_652C34B1E6554F10 P_0)
	{
		_3EC2B2DFACD8432E((object)EDB7ACD80B2B4D99, (object)this, (object)P_0, default(CancellationToken));
		throw new Exception();
	}

	private void E1E49D90BFD0484B()
	{
		CEB31F0C7F1E44FA();
		A17DB1DB9DBD45EC();
		_86CA2E4A5DF14D1D();
		_98D05B12EFFB42CC();
		B9C49CC95F2D4462();
		_3BB84272D08447E8();
		C5B0DC6AFF7A448D();
		A9EC0D70C6D14C35();
		_0A8F4A2F1CE54311();
		_6FD5231CB2544B8F();
		A1019994692D49BC();
		D8B6A999545F455F();
		F9B4F220F6C54892();
		B9C49CC95F2D4462();
		uint num = 3u;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1u:
				num = 5u;
				break;
			case 2u:
				num = 4u;
				break;
			case 3u:
				num = 1u;
				break;
			case 4u:
				return;
			case 5u:
				num = 2u;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(BC0716B8FC364A86))]
	private Task DEAE379336D74523(WebSocketCloseStatus? P_0, string? P_1, bool P_2, bool P_3)
	{
		BC0716B8FC364A86 stateMachine = default;
		stateMachine._266B18FBFF004971 = AsyncTaskMethodBuilder.Create();
		stateMachine.FD2C14B734114709 = this;
		stateMachine._6EAEBA28B9B54B2C = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
		stateMachine._266B18FBFF004971.Start(ref stateMachine);
		return stateMachine._266B18FBFF004971.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_62FD87A08C794440))]
	[Obsolete("Удалить потом")]
	public Task<bool> _6B8C087F18814C58(_652C34B1E6554F10 P_0, CancellationToken P_1 = default(CancellationToken), TimeSpan? P_2 = null)
	{
		_62FD87A08C794440 stateMachine = default;
		stateMachine.A817855AAA8C473B = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._854050FE0BAF4687 = this;
		stateMachine._37C35D2463534A93 = P_0;
		stateMachine._29EF67EF60E04798 = P_1;
		stateMachine._3550EE9BFCD1457C = P_2;
		stateMachine.C4719AB77E354320 = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
		stateMachine.A817855AAA8C473B.Start(ref stateMachine);
		return stateMachine.A817855AAA8C473B.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_3394AA09403349F1))]
	public Task<bool> _6E01EC7AE9294356(_652C34B1E6554F10 P_0, CancellationToken P_1 = default(CancellationToken))
	{
		return null;
	}

	public Task<_0001> _26BAEDD2B7134543<_0001>(_652C34B1E6554F10 P_0, TimeSpan P_1, CancellationToken P_2 = default(CancellationToken)) where _0001 : _652C34B1E6554F10
	{
		return E3EEB511799641CD._9BC08422660541D9<_0001>(P_0, P_1, P_2);
	}

	public Task _884DB9DE8C5C4C0A(_652C34B1E6554F10 P_0, long P_1, CancellationToken P_2 = default(CancellationToken))
	{
		DB81054CD29A4F0D((object)E3EEB511799641CD, (object)P_0, P_1, P_2);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(E509931EC4FC485F))]
	public Task<bool> _3787CDA13EC74733(Stream P_0, B79532442FF34B1B P_1, long P_2, string? P_3 = null)
	{
		E509931EC4FC485F stateMachine = default;
		stateMachine._3977C2630AEF436B = AsyncTaskMethodBuilder<bool>.Create();
		while (true)
		{
			int num = -1296161679;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-1657873075 - (num2 * -64363587 - 825635141 * -(~((unchecked(62023486 * -1728845727) - --1410949257) ^ -2064010234)))) ^ -1627117387)) % 4)
				{
				case 3u:
					break;
				case 1u:
					stateMachine.EB790ED028394273 = this;
					stateMachine._25F503696DA14A07 = P_0;
					num = ((int)num3 * -2126659425) ^ 0x16F83F85;
					continue;
				case 2u:
					stateMachine._28CDDCACE00D4D4B = P_1;
					num = (int)(num3 * 1653833142) ^ -204131108;
					continue;
				default:
					stateMachine._5D2C324E16124BA6 = P_2;
					stateMachine._6587A542945B4A2A = P_3;
					stateMachine._1297016BCA6942A0 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
					stateMachine._3977C2630AEF436B.Start(ref stateMachine);
					return stateMachine._3977C2630AEF436B.Task;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(A40068D417F44BED))]
	private Task A1DECD4C16994BD0(CancellationToken P_0)
	{
		return null;
	}

	public Task B248057F431F42E0(bool P_0, bool P_1, WebSocketCloseStatus P_2 = WebSocketCloseStatus.NormalClosure, string P_3 = "None")
	{
		return (Task)_5D6DABD42E9F481C((object)E3EEB511799641CD, P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_3BFCD00718A5475C))]
	public Task _7B3F63781CFF4AAD()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(EE16DFEEDF594543))]
	public Task _1CD1829443FF4215()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void C870A72D9ECB4B2F()
	{
		_6D01881DEFA9411B(_9ABB18DB80F6431E, _003CModule_003E._8B9C7B12B1AE4949<string>(1451565965), Array.Empty<object>());
		try
		{
			_1FFF86D195EC45FF();
		}
		catch
		{
			_3E4CFD5A1FE44AE6(_003CModule_003E._390073C602714496<int>(2131963235));
			try
			{
				_95443812203344A9(A6B129306813484C());
				return;
			}
			catch
			{
				DE3F6757BADA43F2(_003CModule_003E._58ECCB512F2A43AC<int>(352679804));
				return;
			}
		}
		_2C84AAEFF0FD4B76(_1FFF86D195EC45FF());
		try
		{
			object obj3 = _1FFF86D195EC45FF();
			if (obj3 != null)
			{
				_39F8CF3391D3462E(obj3);
			}
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(AC9B681A16954282))]
	public Task B76672FFD39D4ACA()
	{
		AC9B681A16954282 stateMachine = default;
		stateMachine.A50F82CC85D24F18 = AsyncTaskMethodBuilder.Create();
		stateMachine._8DC65C7D683B45E2 = this;
		stateMachine.E1211B801BBE4661 = _003CModule_003E._390073C602714496<int>(-736908096);
		stateMachine.A50F82CC85D24F18.Start(ref stateMachine);
		return stateMachine.A50F82CC85D24F18.Task;
	}

	[CompilerGenerated]
	private Task B623A3C4E19E45F5()
	{
		EE34FA58CBFF4194((object)_91CC2A56EA1B4D5E);
		EE34FA58CBFF4194((object)this);
		return null;
	}

	static object _5A690657AF774003(int P_0)
	{
		return new SemaphoreSlim(P_0);
	}

	static object _606938F5F7B24508()
	{
		return new CancellationTokenSource();
	}

	static object _66A77EEDCD8D4C13(Func<Task> P_0)
	{
		return Task.Run(P_0);
	}

	static object BDFE184CA8AE49F2()
	{
		return new CDD77F4B61A645F5();
	}

	static object _9B8024EA81184A6D()
	{
		return new _793AD9726F0B488F();
	}

	static object B9AC42DA663347C4(object P_0)
	{
		return new _8612513DA60842B6((ILogger)P_0);
	}

	static object B108BF03B62D4C9B(object P_0, Func<string> P_1)
	{
		return new EB69693599F64B76((_5E780D61DAD9496E)P_0, P_1);
	}

	static void A6AFAEB843D843C0(object P_0, Func<Task> P_1)
	{
		((EB69693599F64B76)P_0)._4A29525306EF475B += P_1;
	}

	static void _0C15A70DCCED4B88(object P_0, Func<_652C34B1E6554F10, Task> P_1)
	{
		((EB69693599F64B76)P_0).AEE603F91511436D += P_1;
	}

	static void C184B46A02554661(object P_0, Func<WebSocketCloseStatus?, string, bool, bool, Task> P_1)
	{
		((EB69693599F64B76)P_0)._42939D361F994B89 += P_1;
	}

	static void A2764DB6FA044738(object P_0, Func<Task> P_1)
	{
		((EB69693599F64B76)P_0)._027E10BCABB34AD7 += P_1;
	}

	static void EFFE37A3B1674F90(object P_0, Func<Task> P_1)
	{
		((EB69693599F64B76)P_0)._32B7149AA751427B += P_1;
	}

	static void _284D9A9A74DF437D(object P_0, Func<Task> P_1)
	{
		((EB69693599F64B76)P_0).E28CDD53BAE04685 += P_1;
	}

	static object _3EC2B2DFACD8432E(object P_0, object P_1, object P_2, CancellationToken P_3)
	{
		return ((CDD77F4B61A645F5)P_0)._1144E21C9FA84988((_02C54685DE0E4B81)P_1, (_652C34B1E6554F10)P_2, P_3);
	}

	static object _9C2EAB8E11914432()
	{
		return new B7BD4E0782844B6C();
	}

	static object _9060B8453FD24C2A()
	{
		return new E1BCCB8C609E4D1D();
	}

	static object B9C49CC95F2D4462()
	{
		return new B59CC8BC30E040CA();
	}

	static object _3BB84272D08447E8()
	{
		return new CAD29C8FC5154E1A();
	}

	static object C5B0DC6AFF7A448D()
	{
		return new FFAD2097F647455E();
	}

	static object A9EC0D70C6D14C35()
	{
		return new _6CC092F150414638();
	}

	static object _0A8F4A2F1CE54311()
	{
		return new B36FC4BCC63448B7();
	}

	static object _6FD5231CB2544B8F()
	{
		return new _75BB81D3BDEE425E();
	}

	static object CEB31F0C7F1E44FA()
	{
		return new _49992BF9672941B5();
	}

	static object A17DB1DB9DBD45EC()
	{
		return new _461303B1053C4226();
	}

	static object _86CA2E4A5DF14D1D()
	{
		return new F8628D416336433B();
	}

	static object _98D05B12EFFB42CC()
	{
		return new _2C17228CC29D4798();
	}

	static object A1019994692D49BC()
	{
		return new _7B7C71CB5C5546D7();
	}

	static object D8B6A999545F455F()
	{
		return new B153EEB24D4D4804();
	}

	static object F9B4F220F6C54892()
	{
		return new _479102BBF61D43FC();
	}

	static object DB81054CD29A4F0D(object P_0, object P_1, long P_2, CancellationToken P_3)
	{
		return ((EB69693599F64B76)P_0).F5A6A61E65934D1F((_652C34B1E6554F10)P_1, P_2, P_3);
	}

	static object _5D6DABD42E9F481C(object P_0, bool P_1, bool P_2, WebSocketCloseStatus P_3, string P_4)
	{
		return ((EB69693599F64B76)P_0)._34BDF5F647EA44F1(P_1, P_2, P_3, P_4);
	}

	static void _6D01881DEFA9411B(ILogger P_0, string P_1, object[] P_2)
	{
		LoggerExtensions.LogWarning(P_0, P_1, P_2);
	}

	static object _1FFF86D195EC45FF()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static void _3E4CFD5A1FE44AE6(int P_0)
	{
		Provider.shutdown(P_0);
	}

	static object A6B129306813484C()
	{
		return Process.GetCurrentProcess();
	}

	static void _95443812203344A9(object P_0)
	{
		((Process)P_0).Kill();
	}

	static void DE3F6757BADA43F2(int P_0)
	{
		Environment.Exit(P_0);
	}

	static void _2C84AAEFF0FD4B76(object P_0)
	{
		((_1DB744298E9F4B09)P_0)._0598F4A5E1DD443D();
	}

	static void _39F8CF3391D3462E(object P_0)
	{
		((_1DB744298E9F4B09)P_0)._1D51E2B36C7345F0();
	}

	static CancellationToken EE34FA58CBFF4194(object P_0)
	{
		return ((CancellationTokenSource)P_0).Token;
	}
}
