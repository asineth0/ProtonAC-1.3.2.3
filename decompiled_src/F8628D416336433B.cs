using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal sealed class F8628D416336433B : global::_94E3D906D3E34B5F<_189C5F67754E4802>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct AD6F6F3BBF664F17 : IAsyncStateMachine
	{
		public int AB6AC484848C468E;

		public AsyncTaskMethodBuilder D2D7191B1D32447A;

		public _189C5F67754E4802 _53279B4E949F431B;

		public F8628D416336433B F0E484A290854E53;

		private Awaiter _35669B6DF8C14F30;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			int num = AB6AC484848C468E;
			F8628D416336433B f8628D416336433B = F0E484A290854E53;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_01f6;
				IL_0014:
				int num2 = -983469068;
				goto IL_0019;
				IL_0019:
				CancellationToken cancellationToken = default;
				Awaiter awaiter = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)((-num3 - (-(-1078322506 ^ 0x6561BF99) + (1973197142 + -(--396649529)) - (-(-74494427 ^ -1093937754) ^ 0x52B73720) + ~870794030)) ^ -1667666119)) % 9)
					{
					case 2u:
						break;
					default:
						goto end_IL_000e;
					case 6u:
					{
						ILogger? val2 = f8628D416336433B._8C5583CA4B9149CA;
						if (val2 != null)
						{
							string text = _003CModule_003E._3F57E81A62734AC2<string>(-1981539115);
							object[] array = new object[_003CModule_003E._58ECCB512F2A43AC<int>(1208532887)];
							array[_003CModule_003E._390073C602714496<int>(2131963235)] = _22F3907B28F84557((object)_53279B4E949F431B);
							array[_003CModule_003E._58ECCB512F2A43AC<int>(1006217019)] = (_2C29E7145DEC41E7(A81C86CCF3B546C0((object)_53279B4E949F431B)) ? _003CModule_003E._3F57E81A62734AC2<string>(198485668) : A81C86CCF3B546C0((object)_53279B4E949F431B));
							_8BC70F264C334F84(val2, text, array);
							num2 = -240245543;
							continue;
						}
						goto end_IL_000e;
					}
					case 8u:
					{
						SwitchToMainThreadAwaitable val = UniTask.SwitchToMainThread(cancellationToken);
						awaiter = val.GetAwaiter();
						num2 = (int)((num4 * 1203985389) ^ 0x367758C5);
						continue;
					}
					case 1u:
						cancellationToken = default;
						num2 = (int)(num4 * 2021759388) ^ -1125423864;
						continue;
					case 0u:
						awaiter.GetResult();
						_0649CCF0B26141F0(_22F3907B28F84557((object)_53279B4E949F431B));
						num2 = -1662074711;
						continue;
					case 5u:
					{
						int num5;
						int num6;
						if (!awaiter.IsCompleted)
						{
							num5 = -1702494257;
							num6 = num5;
						}
						else
						{
							num5 = 1356257979;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num4 * 1286153360);
						continue;
					}
					case 4u:
						goto IL_01f6;
					case 7u:
						num = (AB6AC484848C468E = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
						_35669B6DF8C14F30 = awaiter;
						D2D7191B1D32447A.AwaitUnsafeOnCompleted<Awaiter, AD6F6F3BBF664F17>(ref awaiter, ref this);
						return;
					case 3u:
						goto end_IL_000e;
					}
					break;
				}
				goto IL_0014;
				IL_01f6:
				awaiter = _35669B6DF8C14F30;
				_35669B6DF8C14F30 = default;
				num = (AB6AC484848C468E = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
				num2 = -977739541;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num7 = -408744738;
					while (true)
					{
						int num3 = num7;
						uint num4;
						switch ((num4 = (uint)((-num3 - (-(-1078322506 ^ 0x6561BF99) + (1973197142 + -(--396649529)) - (-(-74494427 ^ -1093937754) ^ 0x52B73720) + ~870794030)) ^ -1667666119)) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 2u:
							goto IL_031a;
						case 1u:
							return;
						}
						break;
						IL_031a:
						AB6AC484848C468E = _003CModule_003E._390073C602714496<int>(818201983);
						D2D7191B1D32447A.SetException(exception);
						num7 = -1079248656;
					}
				}
			}
			AB6AC484848C468E = _003CModule_003E._390073C602714496<int>(818201983);
			D2D7191B1D32447A.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			D2D7191B1D32447A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static string _22F3907B28F84557(object P_0)
		{
			return ((_189C5F67754E4802)P_0)._9A35F3E389974B29;
		}

		static void _0649CCF0B26141F0(string P_0)
		{
			_64A4BBC5E4CE4EE1.E6DC166DE03C47D7(P_0);
		}

		static string A81C86CCF3B546C0(object P_0)
		{
			return ((_189C5F67754E4802)P_0)._866C9427894F418F;
		}

		static bool _2C29E7145DEC41E7(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}

		static void _8BC70F264C334F84(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}
	}

	private readonly ILogger? _8C5583CA4B9149CA;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(AD6F6F3BBF664F17))]
	public Task _1AA97E7EE83A4BFF(_02C54685DE0E4B81 P_0, _189C5F67754E4802 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		AD6F6F3BBF664F17 stateMachine = default;
		stateMachine.D2D7191B1D32447A = AsyncTaskMethodBuilder.Create();
		stateMachine.F0E484A290854E53 = this;
		stateMachine._53279B4E949F431B = P_1;
		stateMachine.AB6AC484848C468E = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120);
		stateMachine.D2D7191B1D32447A.Start(ref stateMachine);
		return stateMachine.D2D7191B1D32447A.Task;
	}

	Task global::_94E3D906D3E34B5F<_189C5F67754E4802>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, _189C5F67754E4802 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in 1AA97E7EE83A4BFF
		return this._1AA97E7EE83A4BFF(P_0, P_1, P_2);
	}

	public F8628D416336433B()
	{
		E372066418F1461A();
		_39D831234F1F4967((object)null);
		_8C5583CA4B9149CA = null;
	}

	static object E372066418F1461A()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static object _39D831234F1F4967(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
	}
}
