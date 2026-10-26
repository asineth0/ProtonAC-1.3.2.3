using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class _461303B1053C4226 : global::_94E3D906D3E34B5F<_9E7CD8E645DD49BC>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct A5083E75A3964193 : IAsyncStateMachine
	{
		public int _0415C46AF1F94A4B;

		public AsyncTaskMethodBuilder FFE853CB2B864A60;

		public _9E7CD8E645DD49BC _484E1BF7540B43ED;

		private TaskAwaiter<bool> _25BAC398D076444B;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_0415C46AF1F94A4B = 0;
			_0415C46AF1F94A4B = -1;
			_0415C46AF1F94A4B = -1;
			_0415C46AF1F94A4B = -2;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			FFE853CB2B864A60.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static Guid B4651FA2DCFD4D27(object P_0)
		{
			return ((_9E7CD8E645DD49BC)P_0).BE6ED36A04954AB0;
		}

		static Task<bool> _475E96959E504806(Guid P_0)
		{
			return _8162F8F545F5474A.FF8CE9A823D04023(P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(A5083E75A3964193))]
	public Task _0FD0A40473244371(_02C54685DE0E4B81 P_0, _9E7CD8E645DD49BC P_1, CancellationToken P_2 = default(CancellationToken))
	{
		return null;
	}

	Task global::_94E3D906D3E34B5F<_9E7CD8E645DD49BC>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, _9E7CD8E645DD49BC P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in 0FD0A40473244371
		return this._0FD0A40473244371(P_0, P_1, P_2);
	}
}
