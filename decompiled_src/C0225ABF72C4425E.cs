using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using HarmonyLib;
using Microsoft.Extensions.Logging;
using SDG.Unturned;

public class C0225ABF72C4425E : ILoggerProvider, IDisposable
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct F74796E0377D4732 : IAsyncStateMachine
	{
		public int _55F25C63141047CD;

		public AsyncTaskMethodBuilder _78C036EED30049BE;

		public C0225ABF72C4425E _1E02CB95DFA246C9;

		private IUniTaskAsyncEnumerator<_3DBA106924E9431F._0CAF5A99CBFA42D0> _4690444F9D1A407E;

		private object _1345E38E3B1C407F;

		private int _35E93E70F81842F2;

		private Awaiter<bool> ACE92E13F6044D6B;

		private Awaiter B9286F0A9ECA4084;

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
			_78C036EED30049BE.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static CancellationToken _22117A979C814D05(object P_0)
		{
			return ((CancellationTokenSource)P_0).Token;
		}

		static string _5E2F6448F5EF4B5B(string[] P_0)
		{
			return string.Concat(P_0);
		}

		static void B831350993644A29(object P_0, ref bool P_1)
		{
			Monitor.Enter(P_0, ref P_1);
		}

		static void _1CAD3AA345484DCF(object P_0)
		{
			((TextWriter)P_0).Close();
		}

		unsafe void _04DA14162CC44A5D()
		{
			//IL_0006: Expected Obj, but got Ref
			((TextWriter)Unsafe.AsPointer(ref this)).Dispose();
		}

		static string F704307136884E08(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static string _86BFFACB65014C3A(string P_0, string P_1)
		{
			return Path.Combine(P_0, P_1);
		}

		static object C6BB3236DEE44322(string P_0, FileMode P_1, FileAccess P_2, FileShare P_3)
		{
			return new FileStream(P_0, P_1, P_2, P_3);
		}

		static object _581D8E165FBC46F1()
		{
			return Encoding.UTF8;
		}

		static object _092875002EBB482E(object P_0, object P_1)
		{
			return new StreamWriter((Stream)P_0, (Encoding)P_1);
		}

		static void _4A523D1EA4AC40E2(object P_0, bool P_1)
		{
			((StreamWriter)P_0).AutoFlush = P_1;
		}

		static void D511E37564654E94(object P_0)
		{
			Monitor.Exit(P_0);
		}

		static string D2A73E7B577742C9(object P_0)
		{
			return ((Exception)P_0).Message;
		}

		static string _50B9322F92F641D6(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static void C428803E8AC14792(string P_0)
		{
			Console.WriteLine(P_0);
		}

		static UniTask FCFD6FA86F8E4385(object P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((IUniTaskAsyncDisposable)P_0).DisposeAsync();
		}

		static object _30359F15A59B4DD1(Exception P_0)
		{
			return ExceptionDispatchInfo.Capture(P_0);
		}

		static void A60003C4A0EC4749(object P_0)
		{
			((ExceptionDispatchInfo)P_0).Throw();
		}
	}

	private readonly Action<CommandWindow, string> FCFC1DE0F37540DA;

	private readonly Action<CommandWindow, string> _34900D1CEB264F66;

	private readonly Action<CommandWindow, string> _55B9C95C1CCD4CC2;

	private readonly Channel<_3DBA106924E9431F._0CAF5A99CBFA42D0> _666FE28F0087465E;

	private readonly Task _7C6AE811B100406F;

	private readonly CancellationTokenSource _28048F3EEEF142F9;

	private readonly string _6D0BB5E5B22D4B42;

	private StreamWriter? _665ED21C3CA34A9F;

	private int _754FFAFF3833451F;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public C0225ABF72C4425E(string P_0)
	{
		_55CE53361FAE40EB(default(RuntimeTypeHandle));
		_245145C3EE1348C8((Type)null, (string)null, (Type[])null, (Type[])null);
		_55CE53361FAE40EB(default(RuntimeTypeHandle));
		_55CE53361FAE40EB(default(RuntimeTypeHandle));
		_3B76DFD658B84AAF();
		D8DAE5710B804E3C((string)null);
		CCF339C5456845F6.E24E36E66E444DDE();
		_28048F3EEEF142F9 = null;
		_754FFAFF3833451F = 0;
		_6D0BB5E5B22D4B42 = P_0;
		_7C6AE811B100406F = null;
		throw new Exception();
	}

	public ILogger CreateLogger(string categoryName)
	{
		A7DFC7756F604CF5(categoryName, _666FE28F0087465E);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(F74796E0377D4732))]
	private Task _8F556C33BC784C69()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _9BB2AAD6E5BC41F3(_3DBA106924E9431F._0CAF5A99CBFA42D0 P_0, string P_1)
	{
		_552EAF61379745B9();
		C5E6EE670EE645EB((string)null, (string)null);
		uint num = 1u;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1u:
				num = 2u;
				break;
			case 2u:
				num = 2u;
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void C8F7B527BD9C43EF(string P_0)
	{
		_3D2D480802654B43((object)_665ED21C3CA34A9F, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string EB02E7E2E9E945AA(LogLevel P_0)
	{
		_003CModule_003E._3F57E81A62734AC2<string>(-274338852);
		_003CModule_003E._3F57E81A62734AC2<string>(-723015290);
		_003CModule_003E._3F57E81A62734AC2<string>(174337586);
		_003CModule_003E._3F57E81A62734AC2<string>(1295875757);
		_003CModule_003E._3F57E81A62734AC2<string>(-82541768);
		_003CModule_003E._3F57E81A62734AC2<string>(354100561);
		_003CModule_003E._3F57E81A62734AC2<string>(1969043338);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Dispose()
	{
		((Channel<_3DBA106924E9431F._0CAF5A99CBFA42D0, _3DBA106924E9431F._0CAF5A99CBFA42D0>)(object)_666FE28F0087465E).Writer.TryComplete((Exception)null);
		try
		{
			B2197888C5684829((object)_7C6AE811B100406F, TimeSpan.FromSeconds(_003CModule_003E._58ECCB512F2A43AC<double>(1801066217)));
		}
		catch
		{
		}
		if (!_6B3AB99DC6F742B5((object)_28048F3EEEF142F9))
		{
			while (true)
			{
				int num = 1112505777;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(~(-489261877 * (~unchecked((0x41B5BBDB ^ 0x4B5C9D0A) * -1043362301) + ~(-unchecked(-1189056303 * (1157510436 - 1941274837))))) - num2) * -1614870911)) % 3)
					{
					case 0u:
						break;
					case 2u:
						A3A030F00E9548F6((object)_28048F3EEEF142F9);
						num = (int)(num3 * 240167975) ^ -521020657;
						continue;
					default:
						goto end_IL_0041;
					}
					break;
				}
				continue;
				end_IL_0041:
				break;
			}
		}
		BE38F6178CB3493C((object)_28048F3EEEF142F9);
		try
		{
			if (_665ED21C3CA34A9F == null)
			{
				return;
			}
			while (true)
			{
				int num4 = -1484879061;
				while (true)
				{
					int num2 = num4;
					uint num3;
					switch ((num3 = (uint)(~(~(-489261877 * (~unchecked((0x41B5BBDB ^ 0x4B5C9D0A) * -1043362301) + ~(-unchecked(-1189056303 * (1157510436 - 1941274837))))) - num2) * -1614870911)) % 4)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						AF1B0B256BAA412E((object)_665ED21C3CA34A9F);
						A4AA5DEB019A49C9((object)_665ED21C3CA34A9F);
						num4 = (int)((num3 * 1484758384) ^ 0x51A6862D);
						continue;
					case 3u:
						_4E1345C86C2B4CED((object)_665ED21C3CA34A9F);
						_665ED21C3CA34A9F = null;
						num4 = (int)((num3 * 2118850915) ^ 0x16318943);
						continue;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			while (true)
			{
				int num5 = 1703499763;
				while (true)
				{
					int num2 = num5;
					uint num3;
					switch ((num3 = (uint)(~(~(-489261877 * (~unchecked((0x41B5BBDB ^ 0x4B5C9D0A) * -1043362301) + ~(-unchecked(-1189056303 * (1157510436 - 1941274837))))) - num2) * -1614870911)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_01e4;
					case 1u:
						return;
					}
					break;
					IL_01e4:
					ConsoleColor consoleColor = _29301DE199574B6E();
					_2BC2EB31453247DC((ConsoleColor)_003CModule_003E.F84FA79ABE6944BB<int>(-182602373));
					_121B817C0E4942AF(C5E6EE670EE645EB(_003CModule_003E.F84FA79ABE6944BB<string>(-1960350883), B978EBE9C23C4936((object)ex)));
					_2BC2EB31453247DC(consoleColor);
					num5 = -1353951355;
				}
			}
		}
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}

	static object _55CE53361FAE40EB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object _245145C3EE1348C8(Type P_0, string P_1, Type[] P_2, Type[] P_3)
	{
		return AccessTools.Method(P_0, P_1, P_2, P_3);
	}

	static object _3B76DFD658B84AAF()
	{
		return new CancellationTokenSource();
	}

	static object D8DAE5710B804E3C(string P_0)
	{
		return new ArgumentNullException(P_0);
	}

	static object C44DBF6F2D1849D6(Func<Task> P_0)
	{
		return Task.Run(P_0);
	}

	static object A7DFC7756F604CF5(string P_0, Channel<_3DBA106924E9431F._0CAF5A99CBFA42D0> P_1)
	{
		return new _3DBA106924E9431F(P_0, P_1);
	}

	static object _552EAF61379745B9()
	{
		return Dedicator.commandWindow;
	}

	static string C5E6EE670EE645EB(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static void _3D2D480802654B43(object P_0, string P_1)
	{
		((TextWriter)P_0).WriteLine(P_1);
	}

	static void _85304267425B4EFF(int P_0)
	{
		Thread.Sleep(P_0);
	}

	static bool B2197888C5684829(object P_0, TimeSpan P_1)
	{
		return ((Task)P_0).Wait(P_1);
	}

	static bool _6B3AB99DC6F742B5(object P_0)
	{
		return ((CancellationTokenSource)P_0).IsCancellationRequested;
	}

	static void A3A030F00E9548F6(object P_0)
	{
		((CancellationTokenSource)P_0).Cancel();
	}

	static void BE38F6178CB3493C(object P_0)
	{
		((CancellationTokenSource)P_0).Dispose();
	}

	static void AF1B0B256BAA412E(object P_0)
	{
		((TextWriter)P_0).Flush();
	}

	static void A4AA5DEB019A49C9(object P_0)
	{
		((TextWriter)P_0).Close();
	}

	static void _4E1345C86C2B4CED(object P_0)
	{
		((TextWriter)P_0).Dispose();
	}

	static ConsoleColor _29301DE199574B6E()
	{
		return Console.ForegroundColor;
	}

	static void _2BC2EB31453247DC(ConsoleColor P_0)
	{
		Console.ForegroundColor = P_0;
	}

	static string B978EBE9C23C4936(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	static void _121B817C0E4942AF(string P_0)
	{
		Console.WriteLine(P_0);
	}
}
