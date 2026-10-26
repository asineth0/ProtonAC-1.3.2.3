using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal class _1FFBEDFB3FCE4374
{
	[CompilerGenerated]
	private sealed class AF79E7444BE448B5
	{
		[StructLayout(LayoutKind.Auto)]
		private struct FCCCB96C1ED54B33 : IAsyncStateMachine
		{
			public int FB09D97E1F2C415E;

			public AsyncTaskMethodBuilder F510453212A14D61;

			public AF79E7444BE448B5 EF283C9BEF0F49E2;

			private TaskAwaiter EB28496087314868;

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
				F510453212A14D61.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static TaskAwaiter _226E2288E911415B(object P_0)
			{
				return ((Task)P_0).GetAwaiter();
			}

			static string _9CC6DE4528614713(string P_0, object P_1, object P_2)
			{
				return string.Format(P_0, P_1, P_2);
			}

			static void _3BB026976DD54E07(string P_0)
			{
				Console.WriteLine(P_0);
			}
		}

		public Func<Task> _6BC2A8A3463C441E;

		public Action<Exception> A91729BAB9D34C35;

		public string _62319C31FAE444DC;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(FCCCB96C1ED54B33))]
		internal Task AF99366C78464237()
		{
			return null;
		}
	}

	public static void _7F73FA898A3C4371(string P_0, Func<Task> P_1, Action<Exception>? P_2 = null)
	{
		_99A473B3985840FB(P_0, P_1, (CancellationToken?)null, P_2);
	}

	public static void _533FDA357CCF49A3(string P_0, Func<Task> P_1, CancellationToken? P_2, Action<Exception>? P_3 = null)
	{
		_931C8C843B2A4063();
		throw new Exception();
	}

	static void _99A473B3985840FB(string P_0, Func<Task> P_1, CancellationToken? P_2, Action<Exception> P_3)
	{
		_533FDA357CCF49A3(P_0, P_1, P_2, P_3);
	}

	static object _931C8C843B2A4063()
	{
		return new AF79E7444BE448B5();
	}

	static object _2962EFF6F7D74252(Func<Task> P_0, CancellationToken P_1)
	{
		return Task.Run(P_0, P_1);
	}
}
