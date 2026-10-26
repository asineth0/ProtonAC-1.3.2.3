using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class _6CC092F150414638 : global::_94E3D906D3E34B5F<_6BD76CD39E2A4E73>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _787C649259DB4348 : IAsyncStateMachine
	{
		public int _542B76EE86A648C6;

		public AsyncTaskMethodBuilder _4D8B6F28D0754176;

		public _6BD76CD39E2A4E73 _248B16E3937C4F84;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			try
			{
				D610A149FD0946DC((object)((_1DB744298E9F4B09)A32B75EA0298484E()).CF47F3EE0E0C4452.F3B62BCE1450413B<_50316A65685442A0>(), _3BF1F74C373148AA((object)_248B16E3937C4F84), (object)_248B16E3937C4F84);
			}
			catch (Exception exception)
			{
				_542B76EE86A648C6 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				_4D8B6F28D0754176.SetException(exception);
				return;
			}
			_542B76EE86A648C6 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			while (true)
			{
				int num = -863635421;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(-((~(~-1553111914) - (num2 ^ -445862148)) ^ 0x516C1078)) * 384502217 * -1243166667 * -2062038911)) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_00e1;
					case 0u:
						return;
					}
					break;
					IL_00e1:
					_4D8B6F28D0754176.SetResult();
					num = (int)(num3 * 1745023603) ^ -1729392005;
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
			_4D8B6F28D0754176.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object A32B75EA0298484E()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static Guid _3BF1F74C373148AA(object P_0)
		{
			return ((_6BD76CD39E2A4E73)P_0).FFF25575EFCC42D4;
		}

		static void D610A149FD0946DC(object P_0, Guid P_1, object P_2)
		{
			((_50316A65685442A0)P_0).CC65BE05F6C34614(P_1, (_6BD76CD39E2A4E73)P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_787C649259DB4348))]
	public Task _450A0DF90E094DE8(_02C54685DE0E4B81 P_0, _6BD76CD39E2A4E73 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		_787C649259DB4348 stateMachine = default;
		stateMachine._4D8B6F28D0754176 = AsyncTaskMethodBuilder.Create();
		stateMachine._248B16E3937C4F84 = P_1;
		stateMachine._542B76EE86A648C6 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
		while (true)
		{
			int num = -608110578;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(((-num2 - ~(1522510961 + -(~(-692448679 + 152457026)) + ~(-unchecked(1950965259 * (-128304210 + 1046817772))))) * 966521085 - 200651837 * (-(-100489600 - -853449326) + ~-351579104)) * -578119765 * -1037371117 + 454031935))) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_00a2;
				default:
					return stateMachine._4D8B6F28D0754176.Task;
				}
				break;
				IL_00a2:
				stateMachine._4D8B6F28D0754176.Start(ref stateMachine);
				num = ((int)num3 * -2091995313) ^ -1195154653;
			}
		}
	}

	Task global::_94E3D906D3E34B5F<_6BD76CD39E2A4E73>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, _6BD76CD39E2A4E73 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in 450A0DF90E094DE8
		return this._450A0DF90E094DE8(P_0, P_1, P_2);
	}
}
