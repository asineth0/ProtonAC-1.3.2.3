using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal sealed class B7BD4E0782844B6C : global::_94E3D906D3E34B5F<FBFDE69E8DC9496E>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct B76A92C9E1D343D1 : IAsyncStateMachine
	{
		public int _0A74D61E4ED84C0C;

		public AsyncTaskMethodBuilder _5DD5E771474D45F7;

		public FBFDE69E8DC9496E _564E08EE062444F8;

		public _02C54685DE0E4B81 E5AC9308A2ED4927;

		public CancellationToken _276DF16607C542ED;

		private TaskAwaiter<bool> E58D71CDFBC1491C;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_0A74D61E4ED84C0C = 0;
			_0A74D61E4ED84C0C = -1;
			_0A74D61E4ED84C0C = -2;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_5DD5E771474D45F7.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static long E5F476F246D2485C(object P_0)
		{
			return ((FBFDE69E8DC9496E)P_0)._1C57B08C9C8140F8;
		}

		static long _73789994D90C4AB7(long P_0)
		{
			return _4CC1FD78B203468B._44AA40A57FC943B0(P_0);
		}

		static long C1034F99FA9840A7(object P_0)
		{
			return ((FBFDE69E8DC9496E)P_0)._5E1B9FCB44414AFE;
		}

		static object _928D7DCFD15C4258()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static object C13A5DF9898046F4(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
		}

		static void _7642D8F6FAE44B3D(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}

		static object _4D7BB8D560F14FAC(long P_0)
		{
			return new C44631BE80E84975(P_0);
		}

		static Task<bool> _62DCACFBF2424D9F(object P_0, object P_1, CancellationToken P_2)
		{
			return ((_02C54685DE0E4B81)P_0)._6E01EC7AE9294356((_652C34B1E6554F10)P_1, P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(B76A92C9E1D343D1))]
	public Task DF7DD2D31F8D4DB0(_02C54685DE0E4B81 P_0, FBFDE69E8DC9496E P_1, CancellationToken P_2 = default(CancellationToken))
	{
		return null;
	}

	Task global::_94E3D906D3E34B5F<FBFDE69E8DC9496E>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, FBFDE69E8DC9496E P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in DF7DD2D31F8D4DB0
		return this.DF7DD2D31F8D4DB0(P_0, P_1, P_2);
	}
}
