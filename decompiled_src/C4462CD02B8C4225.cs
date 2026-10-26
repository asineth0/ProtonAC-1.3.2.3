using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal class C4462CD02B8C4225 : C179263454B44BF6
{
	private readonly struct _147B5CF1E696412C(string P_0, _45A0FAC1031A4143 P_1, _6C63CD6C48F7495C P_2, Action<_45A0FAC1031A4143> P_3)
	{
		public readonly string _9D518E5E78804070 = P_0;

		public readonly _45A0FAC1031A4143 _960A3F1A81C1489B = P_1;

		public readonly _6C63CD6C48F7495C _790956CCC91F48E4 = P_2;

		public readonly Action<_45A0FAC1031A4143> _944618501A074C0D = P_3;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _81595F2216AD47A4 : IAsyncStateMachine
	{
		public int A0F8963F4F8D4B43;

		public AsyncTaskMethodBuilder _45DEF16282B243E8;

		public C4462CD02B8C4225 _62E2507AC5E84ACB;

		private TaskAwaiter _252F9CB964FB4491;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			A0F8963F4F8D4B43 = 0;
			A0F8963F4F8D4B43 = 0;
			A0F8963F4F8D4B43 = 0;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_45DEF16282B243E8.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static TaskAwaiter _6DC8261276094061(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _4FF27FED2EDE4457
	{
		public static readonly _4FF27FED2EDE4457 _003C_003E9 = (_4FF27FED2EDE4457)CA31989045A4439D();

		public static Action<Exception> _003C_003E9__11_3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _6E06A7FB029242C7(Exception P_0)
		{
			if (P_0 is OperationCanceledException)
			{
				return;
			}
			while (true)
			{
				int num = 288822359;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((-(~num2 * 1836381763 - ~(-976922649 ^ -42532059)) - unchecked(-1910447461 * ~unchecked(579649195 * 990728331)) - (~1638652771 - (-1450549220 - -1657091921)) - -1394603769) * -252290393)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_009b;
					case 2u:
						return;
					}
					break;
					IL_009b:
					C2542DB7E7B4453A(C179263454B44BF6._54DF173DA5E74DC3, E72F9E18CDE64A06(_003CModule_003E._58ECCB512F2A43AC<string>(-945257315), (object)P_0), Array.Empty<object>());
					num = -1169973387;
				}
			}
		}

		static object CA31989045A4439D()
		{
			return new _4FF27FED2EDE4457();
		}

		static string E72F9E18CDE64A06(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void C2542DB7E7B4453A(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogInformation(P_0, P_1, P_2);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class ACEE582EE7AB4F60<_0001> where _0001 : class, _45A0FAC1031A4143, new()
	{
		public static readonly ACEE582EE7AB4F60<_0001> _003C_003E9 = new ACEE582EE7AB4F60<_0001>();

		public static Action<_45A0FAC1031A4143> _003C_003E9__14_0;

		internal void _8506CB7DC53E4876(_45A0FAC1031A4143 P_0)
		{
			global::D7B91A037937472E<_0001>._8812F3ADA5664BC6((_0001)P_0);
		}
	}

	[CompilerGenerated]
	private sealed class _910BCD746BED4EFD
	{
		public CancellationToken _663EEB8A321443A1;

		public C4462CD02B8C4225 _81C43A819C4E4EB7;

		internal void DFC4D2DA60BF41E8()
		{
			throw new Exception();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void F5EDC6F0B61342A0(Task P_0)
		{
			if (_4DF24D8E92434ED8((object)P_0))
			{
				goto IL_000b;
			}
			goto IL_00c5;
			IL_000b:
			int num = 2036389257;
			goto IL_0010;
			IL_0010:
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~(num2 * -16444847 - (((-(92107740 - -1912077565) ^ 0x5D9D7C71) - -1852640425 + -919729426) ^ -683987925)) - -1242987899 * -(-(-89861689))) + unchecked(349895382 + 1070266590 + 1317561400))) % 6)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					_62826E11AFF4496F(C179263454B44BF6._54DF173DA5E74DC3, (Exception)_4B6FC7A008984694((object)P_0), _003CModule_003E._390073C602714496<string>(20790903), Array.Empty<object>());
					num = -655096018;
					continue;
				case 2u:
					goto IL_00c5;
				case 4u:
					return;
				case 0u:
					_06EF3523C1F44131(C179263454B44BF6._54DF173DA5E74DC3, _003CModule_003E._8B9C7B12B1AE4949<string>(-1582346490), Array.Empty<object>());
					num = 870451897;
					continue;
				case 5u:
					return;
				}
				break;
			}
			goto IL_000b;
			IL_00c5:
			int num4;
			if (_663EEB8A321443A1.IsCancellationRequested)
			{
				num = 870451897;
				num4 = num;
			}
			else
			{
				num = -306664604;
				num4 = num;
			}
			goto IL_0010;
		}

		static bool _4DF24D8E92434ED8(object P_0)
		{
			return ((Task)P_0).IsFaulted;
		}

		static object _4B6FC7A008984694(object P_0)
		{
			return ((Task)P_0).Exception;
		}

		static void _62826E11AFF4496F(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}

		static void _06EF3523C1F44131(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _77F0FE2BC2764C1F : IAsyncStateMachine
	{
		public int _079166EB603C4718;

		public AsyncTaskMethodBuilder _2C3066477ECC4A21;

		public CancellationToken D03C93B4516D4F4A;

		public C4462CD02B8C4225 _355CDC03936E402F;

		private TimeSpan _23A83DDEFF6A4AE2;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _2F309EE39DF64E66;

		private Dictionary<_6C63CD6C48F7495C, ConcurrentQueue<_0D2DBD97EB44499A>>.Enumerator _340259D6521D4C34;

		private List<_0D2DBD97EB44499A> _3F0A02CD93EF43DB;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter C89071EBB34F4269;

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
			_2C3066477ECC4A21.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _17FD514258ED40C2(TimeSpan P_0, CancellationToken P_1)
		{
			return Task.Delay(P_0, P_1);
		}

		static ConfiguredTaskAwaitable _3E10781D0F7B474F(object P_0, bool P_1)
		{
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		static bool DA7792CDCF154322(object P_0)
		{
			return ((_02C54685DE0E4B81)P_0)._19BA68A8CF284E00;
		}

		static int _73C6D060AAE140CD(int P_0, int P_1)
		{
			return Math.Min(P_0, P_1);
		}

		static object _75417B2457F04DCA(_6C63CD6C48F7495C P_0, List<_0D2DBD97EB44499A> P_1)
		{
			return new _313E272045674C37(P_0, P_1);
		}

		static Task<bool> _8F7065512BE24B35(object P_0, object P_1, CancellationToken P_2, TimeSpan? P_3)
		{
			return ((_02C54685DE0E4B81)P_0)._6B8C087F18814C58((_652C34B1E6554F10)P_1, P_2, P_3);
		}

		static string _8265F6F9887649F8(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void _07F8567D04E84D6A(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static void _599C258A9CDB47C1(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	private const int _66DDDD6431644C28 = 10000;

	private const int _932E3B87C7D34770 = 250;

	private readonly CancellationToken _16064A0D6557431D;

	private readonly Dictionary<_6C63CD6C48F7495C, ConcurrentQueue<_0D2DBD97EB44499A>> _6D7F73BCD68340FD;

	private readonly ConcurrentQueue<_147B5CF1E696412C> _39BCE4E1FD2E4699;

	private readonly SemaphoreSlim _6BE379233BB1472B;

	private readonly CancellationTokenSource _97EB2FD7B1C74F2F;

	private Task? _059ABF0DBDDA4503;

	private _02C54685DE0E4B81? _1168E50B93444997 => _1DB744298E9F4B09._052FBC588F454484._0D077240941749FA;

	public C4462CD02B8C4225()
	{
		GC.KeepAlive(null);
	}

	public _0001 _3ECE4ABFF9E04BFF<_0001>() where _0001 : class, _45A0FAC1031A4143, new()
	{
		return global::D7B91A037937472E<_0001>._2583D328976C4661();
	}

	public void _840CF0233A3D467E<_0001>(_0001 P_0) where _0001 : class, _45A0FAC1031A4143, new()
	{
		global::D7B91A037937472E<_0001>._8812F3ADA5664BC6(P_0);
	}

	public void CB4E939A3F83474C<_0001>(string P_0, _0001 P_1, _6C63CD6C48F7495C P_2 = _6C63CD6C48F7495C._9497E3D6CD2A485C) where _0001 : class, _45A0FAC1031A4143, new()
	{
		_39BCE4E1FD2E4699.Enqueue(new _147B5CF1E696412C(P_0, P_1, P_2, (_45A0FAC1031A4143 obj) =>
		{
			global::D7B91A037937472E<_0001>._8812F3ADA5664BC6((_0001)obj);
		}));
		_6BE379233BB1472B.Release();
	}

	public void _3D1EB9B558274F65(string P_0, string P_1, _6C63CD6C48F7495C P_2 = _6C63CD6C48F7495C._9497E3D6CD2A485C)
	{
		_62A8949511C3432B(new _0D2DBD97EB44499A(C700DF6D63C14083(), P_0, P_1), P_2);
	}

	public void _572632FBBF934FE8(_0D2DBD97EB44499A P_0, _6C63CD6C48F7495C P_1 = _6C63CD6C48F7495C._9497E3D6CD2A485C)
	{
		_62A8949511C3432B(P_0, P_1);
	}

	private static string C700DF6D63C14083()
	{
		return DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();
	}

	private void _62A8949511C3432B(_0D2DBD97EB44499A P_0, _6C63CD6C48F7495C P_1)
	{
		if (_6D7F73BCD68340FD.TryGetValue(P_1, out ConcurrentQueue<_0D2DBD97EB44499A> value))
		{
			value.Enqueue(P_0);
		}
		else
		{
			_6D7F73BCD68340FD[_6C63CD6C48F7495C._26B50F044DA6469D].Enqueue(P_0);
		}
	}

	private void CE6DFA7D5BCC43E0(CancellationToken P_0)
	{
		C700DF6D63C14083();
		((_40273E31A09B48E7)null).E3D17168C7014F0A();
		new _40273E31A09B48E7()._605A92C29EFB4E06();
		new _0D2DBD97EB44499A(null, null, null);
	}

	[AsyncStateMachine(typeof(_77F0FE2BC2764C1F))]
	private Task _8112AE6BB2924ED0(CancellationToken P_0)
	{
		return null;
	}

	public virtual void _02173358C8634572()
	{
		_97EB2FD7B1C74F2F.Cancel();
		_6BE379233BB1472B.Release();
		_97EB2FD7B1C74F2F.Dispose();
		_059ABF0DBDDA4503 = null;
		base.Dispose();
	}

	[AsyncStateMachine(typeof(_81595F2216AD47A4))]
	[CompilerGenerated]
	private Task _5F4A801667FE45CC()
	{
		return null;
	}
}
