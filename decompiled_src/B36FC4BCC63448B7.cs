using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal class B36FC4BCC63448B7 : global::_94E3D906D3E34B5F<FD7DF9890DD84DA8>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct A96B992E2DF849F5 : IAsyncStateMachine
	{
		public int E0A144454E384B6E;

		public AsyncTaskMethodBuilder _0E00AD7CC45544B7;

		public _02C54685DE0E4B81 _59F4E5E5A13C4051;

		public FD7DF9890DD84DA8 _426657860EE34198;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			try
			{
				ConcurrentDictionary<string, A24F37B85A5745EF> concurrentDictionary = _83E135C0A63C4943((object)_59F4E5E5A13C4051.FEF1EDB6312C4632);
				string key = B6CE6AFC4E08423D((object)_426657860EE34198);
				object obj = FB6D970AA1B54608();
				_6933B79C73CA4623(obj, F072615EE7174031((object)_426657860EE34198));
				_85613BC2DB9E43DA(obj, _729B0749F10440D4());
				if (!concurrentDictionary.TryAdd(key, (A24F37B85A5745EF)obj))
				{
					while (true)
					{
						IL_0046:
						int num = -1367016326;
						while (true)
						{
							int num2 = num;
							uint num3;
							object obj2;
							switch ((num3 = (uint)((num2 * 1386774329 + ~(~-27212429 + unchecked((-771558084 ^ -1631365349) - 828743829 - ~(-848828737 ^ -1477753280)))) * -1246579663 * -1620746809)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_004b;
							case 1u:
								obj2 = C583248DDF5940EC(BFBFB7AF4F04487D());
								if (obj2 != null)
								{
									goto IL_00bf;
								}
								goto end_IL_004b;
							case 2u:
								goto end_IL_004b;
							}
							goto IL_0046;
							IL_00bf:
							string text = _003CModule_003E._58ECCB512F2A43AC<string>(81252331);
							object[] array = new object[_003CModule_003E._58ECCB512F2A43AC<int>(1208532887)];
							array[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)] = B6CE6AFC4E08423D((object)_426657860EE34198);
							array[_003CModule_003E._390073C602714496<int>(-250964212)] = F072615EE7174031((object)_426657860EE34198);
							_0193976CC73841A9((ILogger)obj2, text, array);
							num = 168071545;
							continue;
							end_IL_004b:
							break;
						}
						break;
					}
				}
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num4 = 946596944;
					while (true)
					{
						int num2 = num4;
						uint num3;
						switch ((num3 = (uint)((num2 * 1386774329 + ~(~-27212429 + unchecked((-771558084 ^ -1631365349) - 828743829 - ~(-848828737 ^ -1477753280)))) * -1246579663 * -1620746809)) % 4)
						{
						case 0u:
							break;
						default:
							return;
						case 3u:
							E0A144454E384B6E = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
							num4 = -2055055231;
							continue;
						case 2u:
							_0E00AD7CC45544B7.SetException(exception);
							num4 = ((int)num3 * -1188395808) ^ -1122951818;
							continue;
						case 1u:
							return;
						}
						break;
					}
				}
			}
			E0A144454E384B6E = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
			_0E00AD7CC45544B7.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_0E00AD7CC45544B7.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static ConcurrentDictionary<string, A24F37B85A5745EF> _83E135C0A63C4943(object P_0)
		{
			return ((_793AD9726F0B488F)P_0)._2FC10FC8DA964445;
		}

		static string B6CE6AFC4E08423D(object P_0)
		{
			return ((FD7DF9890DD84DA8)P_0).CC1467C209C647B9;
		}

		static object FB6D970AA1B54608()
		{
			return new A24F37B85A5745EF();
		}

		static B79532442FF34B1B F072615EE7174031(object P_0)
		{
			return ((FD7DF9890DD84DA8)P_0)._34CF1F32D50A406C;
		}

		static void _6933B79C73CA4623(object P_0, B79532442FF34B1B P_1)
		{
			((A24F37B85A5745EF)P_0)._195B5211EE8240A8 = P_1;
		}

		static object _729B0749F10440D4()
		{
			return new _92E045C44FAC46F3();
		}

		static void _85613BC2DB9E43DA(object P_0, object P_1)
		{
			((A24F37B85A5745EF)P_0).E5416C55D0A342A9 = (_92E045C44FAC46F3)P_1;
		}

		static object BFBFB7AF4F04487D()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static object C583248DDF5940EC(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
		}

		static void _0193976CC73841A9(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(A96B992E2DF849F5))]
	public Task A0FC9E3AF840406C(_02C54685DE0E4B81 P_0, FD7DF9890DD84DA8 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		A96B992E2DF849F5 stateMachine = default;
		stateMachine._0E00AD7CC45544B7 = AsyncTaskMethodBuilder.Create();
		stateMachine._59F4E5E5A13C4051 = P_0;
		stateMachine._426657860EE34198 = P_1;
		stateMachine.E0A144454E384B6E = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
		stateMachine._0E00AD7CC45544B7.Start(ref stateMachine);
		return stateMachine._0E00AD7CC45544B7.Task;
	}

	Task global::_94E3D906D3E34B5F<FD7DF9890DD84DA8>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, FD7DF9890DD84DA8 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in A0FC9E3AF840406C
		return this.A0FC9E3AF840406C(P_0, P_1, P_2);
	}
}
