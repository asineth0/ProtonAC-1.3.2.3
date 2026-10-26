using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal sealed class B59CC8BC30E040CA : global::_94E3D906D3E34B5F<F3E4AB234A904B5E>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _54A95DF69F9D4812 : IAsyncStateMachine
	{
		public int _3D32F453C7AD4EAB;

		public AsyncTaskMethodBuilder B56E61A46BEC4A4E;

		public _02C54685DE0E4B81 _5E31DABA00AB4C16;

		public F3E4AB234A904B5E _58CD4E31649140E5;

		private TaskAwaiter<bool> C609D30A981B4E7B;

		private TaskAwaiter _404D678D3D224341;

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
			B56E61A46BEC4A4E.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool _470C9E7BE18C480D(object P_0)
		{
			return ((F3E4AB234A904B5E)P_0)._5BC77EB4C1E04BAA;
		}

		static void D80DEFBAE6264DB8(object P_0, bool P_1)
		{
			((_02C54685DE0E4B81)P_0)._19BA68A8CF284E00 = P_1;
		}

		static string _9FCBFB129BD54027(object P_0)
		{
			return ((F3E4AB234A904B5E)P_0).A3197CF3088A49FB;
		}

		static bool E2FBF10AF9B34E73(object P_0, string P_1)
		{
			return ((string)P_0).Equals(P_1);
		}

		static object _13E8D85767DB4032()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static object _0D04B775CDE842B1(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
		}

		static void C935C7A363B54CA7(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static void _86E6C312DFF247CE(object P_0)
		{
			((_02C54685DE0E4B81)P_0).C870A72D9ECB4B2F();
		}

		static bool FFCA8CB3C2C44642(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._6EB2D3D9EC934A7A;
		}

		static void _536F23CD59724BD3(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogInformation(P_0, P_1, P_2);
		}

		static Task<bool> CADDD906090C4AF3()
		{
			return _8162F8F545F5474A._4D65BD4381F7417B();
		}

		static object _7A6124DDA1AF4474()
		{
			return Task.CompletedTask;
		}

		static TaskAwaiter _88DC0FA278184548(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_54A95DF69F9D4812))]
	public Task B1EA6B83E25B4D8E(_02C54685DE0E4B81 P_0, F3E4AB234A904B5E P_1, CancellationToken P_2 = default(CancellationToken))
	{
		return null;
	}

	Task global::_94E3D906D3E34B5F<F3E4AB234A904B5E>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, F3E4AB234A904B5E P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in B1EA6B83E25B4D8E
		return this.B1EA6B83E25B4D8E(P_0, P_1, P_2);
	}
}
