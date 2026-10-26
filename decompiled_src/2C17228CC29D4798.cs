using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;

internal sealed class _2C17228CC29D4798 : global::_94E3D906D3E34B5F<_7C3933FE2CD94926>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _6DBDED421BCE4AB1 : IAsyncStateMachine
	{
		public int _1CF4B12EC37A47BC;

		public AsyncTaskMethodBuilder B08E83EE3C184F9F;

		public _7C3933FE2CD94926 _65C3EBB235A74CEB;

		public _02C54685DE0E4B81 B2EF364E2A334256;

		public CancellationToken _0C84FE936E20480A;

		private Awaiter _9585D811EAB74062;

		private Awaiter _620EB4ECE7C94635;

		private TaskAwaiter _723D03F3E644495C;

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
			B08E83EE3C184F9F.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool C44BE55597F04A3E(object P_0)
		{
			return ((_652C34B1E6554F10)P_0)._34B44C79896F4AF2;
		}

		static object E47270F3F0634EAB()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static string _8EFBC5DBF2FE4F7A(object P_0)
		{
			return ((_7C3933FE2CD94926)P_0).EC9A38F0433042C8;
		}

		static string _76BE29EB123B4830(object P_0)
		{
			return ((_7C3933FE2CD94926)P_0)._69B42B2ACA6F4E1E;
		}

		static string E8524C6C811D45C9(object P_0)
		{
			return ((_7C3933FE2CD94926)P_0).F01DA256AA6943BA;
		}

		static void _788B4C3D1EE74595(object P_0, string P_1, string P_2, string P_3)
		{
			((_1DB744298E9F4B09)P_0)._72F9E20AFFAE478D(P_1, P_2, P_3);
		}

		static object D0B5BDF7530C4B70(bool P_0)
		{
			return new _95A08CC1D4B4428B(P_0);
		}

		static long _90A02C4E75CF44DF(object P_0)
		{
			return ((_652C34B1E6554F10)P_0).C4CF7218A3D4459F;
		}

		static object _7CFC2E0A847C4773(object P_0, object P_1, long P_2, CancellationToken P_3)
		{
			return ((_02C54685DE0E4B81)P_0)._884DB9DE8C5C4C0A((_652C34B1E6554F10)P_1, P_2, P_3);
		}

		static TaskAwaiter B739EEE1338F4003(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static bool C889A6BC4235458B(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._6EB2D3D9EC934A7A;
		}

		static object _7F3FF68E09C84359(object P_0)
		{
			return ((_02C54685DE0E4B81)P_0)._1CD1829443FF4215();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_6DBDED421BCE4AB1))]
	public Task _9522A597174F41D2(_02C54685DE0E4B81 P_0, _7C3933FE2CD94926 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		return null;
	}

	Task global::_94E3D906D3E34B5F<_7C3933FE2CD94926>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, _7C3933FE2CD94926 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in 9522A597174F41D2
		return this._9522A597174F41D2(P_0, P_1, P_2);
	}
}
