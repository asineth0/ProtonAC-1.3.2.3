using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal sealed class CAD29C8FC5154E1A : global::_94E3D906D3E34B5F<FF4343C122D84FC9>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _129ECA4A57834C17 : IAsyncStateMachine
	{
		public int _022BE56671024EA1;

		public AsyncTaskMethodBuilder _08D09936F36B4AEA;

		public FF4343C122D84FC9 _4B37051B21F346F2;

		private TaskAwaiter _9507150D7D1647DA;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _022BE56671024EA1;
			try
			{
				if (num != 0)
				{
					goto IL_000d;
				}
				goto IL_018c;
				IL_000d:
				int num2 = -2069311027;
				goto IL_0012;
				IL_0012:
				TaskAwaiter awaiter = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(-996259985 - ((~(((-(-(-598679799 * --1271687592) - -(-881261916 ^ -50995858)) ^ (-341585098 - (-2121034096 + unchecked(-1172394279 + -1110411498) - (--1157569554 + -1385984768) - unchecked(992109601 * ~(-1870731113 ^ 0x1171B56B))))) - num3 * -1760998423) ^ -1394299443) - unchecked(325632685 * ((-98288825 ^ -536340444) + (-1577140899 ^ -1293741201))) + unchecked(219924318 * -1760605145)) ^ 0x53013961))) % 7)
					{
					case 4u:
						break;
					case 3u:
						awaiter = _2B54DF531B6D4E7C(_4E43E36698BE40BB((object)((_1DB744298E9F4B09)_24CAE92EDAC6478F()).CF47F3EE0E0C4452.F3B62BCE1450413B<B7097FC49A384CFA>(), (object)_4B37051B21F346F2));
						num2 = (int)(num4 * 1223854808) ^ -1560541409;
						continue;
					case 5u:
						num = (_022BE56671024EA1 = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
						_9507150D7D1647DA = awaiter;
						_08D09936F36B4AEA.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 0u:
					{
						int num5;
						int num6;
						if (awaiter.IsCompleted)
						{
							num5 = -70247110;
							num6 = num5;
						}
						else
						{
							num5 = 183928289;
							num6 = num5;
						}
						num2 = num5 ^ ((int)num4 * -209189101);
						continue;
					}
					case 1u:
						num = (_022BE56671024EA1 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
						num2 = 1505619750;
						continue;
					case 6u:
						goto IL_018c;
					default:
						awaiter.GetResult();
						goto end_IL_0007;
					}
					break;
				}
				goto IL_000d;
				IL_018c:
				awaiter = _9507150D7D1647DA;
				_9507150D7D1647DA = default;
				num2 = -983899039;
				goto IL_0012;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_022BE56671024EA1 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				while (true)
				{
					int num7 = 1280768021;
					while (true)
					{
						int num3 = num7;
						uint num4;
						switch ((num4 = (uint)(-996259985 - ((~(((-(-(-598679799 * --1271687592) - -(-881261916 ^ -50995858)) ^ (-341585098 - (-2121034096 + unchecked(-1172394279 + -1110411498) - (--1157569554 + -1385984768) - unchecked(992109601 * ~(-1870731113 ^ 0x1171B56B))))) - num3 * -1760998423) ^ -1394299443) - unchecked(325632685 * ((-98288825 ^ -536340444) + (-1577140899 ^ -1293741201))) + unchecked(219924318 * -1760605145)) ^ 0x53013961))) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 2u:
							goto IL_0287;
						case 1u:
							return;
						}
						break;
						IL_0287:
						_08D09936F36B4AEA.SetException(exception);
						num7 = ((int)num4 * -119646631) ^ 0x2889D994;
					}
				}
			}
			_022BE56671024EA1 = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
			while (true)
			{
				int num8 = 102518858;
				while (true)
				{
					int num3 = num8;
					uint num4;
					switch ((num4 = (uint)(-996259985 - ((~(((-(-(-598679799 * --1271687592) - -(-881261916 ^ -50995858)) ^ (-341585098 - (-2121034096 + unchecked(-1172394279 + -1110411498) - (--1157569554 + -1385984768) - unchecked(992109601 * ~(-1870731113 ^ 0x1171B56B))))) - num3 * -1760998423) ^ -1394299443) - unchecked(325632685 * ((-98288825 ^ -536340444) + (-1577140899 ^ -1293741201))) + unchecked(219924318 * -1760605145)) ^ 0x53013961))) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_037b;
					case 1u:
						return;
					}
					break;
					IL_037b:
					_08D09936F36B4AEA.SetResult();
					num8 = ((int)num4 * -1156507511) ^ 0x62A6C385;
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
			_08D09936F36B4AEA.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _24CAE92EDAC6478F()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static object _4E43E36698BE40BB(object P_0, object P_1)
		{
			return ((B7097FC49A384CFA)P_0)._76B45974F94B4212((FF4343C122D84FC9)P_1);
		}

		static TaskAwaiter _2B54DF531B6D4E7C(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_129ECA4A57834C17))]
	public Task _0DC5C0F9145D4580(_02C54685DE0E4B81 P_0, FF4343C122D84FC9 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		_129ECA4A57834C17 stateMachine = default;
		stateMachine._08D09936F36B4AEA = AsyncTaskMethodBuilder.Create();
		stateMachine._4B37051B21F346F2 = P_1;
		while (true)
		{
			int num = 1881384241;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(num2 * -1883457789) + -(~(-37646344 ^ 0x415403F)))) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0053;
				default:
					stateMachine._08D09936F36B4AEA.Start(ref stateMachine);
					return stateMachine._08D09936F36B4AEA.Task;
				}
				break;
				IL_0053:
				stateMachine._022BE56671024EA1 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
				num = 2008990627;
			}
		}
	}

	Task global::_94E3D906D3E34B5F<FF4343C122D84FC9>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, FF4343C122D84FC9 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in 0DC5C0F9145D4580
		return this._0DC5C0F9145D4580(P_0, P_1, P_2);
	}
}
