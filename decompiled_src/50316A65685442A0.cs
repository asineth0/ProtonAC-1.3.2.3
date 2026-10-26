using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal class _50316A65685442A0 : C179263454B44BF6
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct A2605BD50E9A4797 : IAsyncStateMachine
	{
		public int _96A4AFF88F984DA9;

		public AsyncTaskMethodBuilder<bool> _1BD64DB164714B1C;

		public _50316A65685442A0 _6B7B72C22D2549CA;

		public _83D3069491A44F2C _9B413A5C69A643FF;

		private TaskAwaiter<bool> E3086BD24204416D;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _96A4AFF88F984DA9;
			_50316A65685442A0 obj = _6B7B72C22D2549CA;
			bool result = default;
			try
			{
				if (num == 0)
				{
					goto IL_009e;
				}
				while (true)
				{
					int num2 = -729665123;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(-(-1151826575 - -(-(-(-(-num3) * -1328452731)))))) % 5)
						{
						case 2u:
							break;
						case 0u:
							goto end_IL_0014;
						case 4u:
							result = (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
							num2 = 1419098266;
							continue;
						case 1u:
						{
							int num5;
							int num6;
							if (obj._97DF35E1DA234D93 != null)
							{
								num5 = -1177143345;
								num6 = num5;
							}
							else
							{
								num5 = -774939552;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num4 * 27676984);
							continue;
						}
						default:
							goto IL_009e;
						}
						break;
					}
					continue;
					end_IL_0014:
					break;
				}
				goto end_IL_000e;
				IL_009e:
				try
				{
					if (num != 0)
					{
						goto IL_00a1;
					}
					goto IL_0118;
					IL_00a1:
					int num7 = -1088461540;
					goto IL_00a6;
					IL_00a6:
					TaskAwaiter<bool> awaiter = default;
					while (true)
					{
						int num3 = num7;
						uint num4;
						switch ((num4 = (uint)(-(-1151826575 - -(-(-(-(-num3) * -1328452731)))))) % 8)
						{
						case 2u:
							break;
						case 3u:
							awaiter = ED09D1A9500C4870((object)obj._97DF35E1DA234D93, (object)_9B413A5C69A643FF, obj._6F41C421EC514990).GetAwaiter();
							num7 = (int)((num4 * 1810896986) ^ 0x308B5FBD);
							continue;
						case 4u:
							goto IL_0118;
						case 0u:
						{
							int num8;
							int num9;
							if (!awaiter.IsCompleted)
							{
								num8 = 1526903336;
								num9 = num8;
							}
							else
							{
								num8 = -702739446;
								num9 = num8;
							}
							num7 = num8 ^ (int)(num4 * 1154037036);
							continue;
						}
						case 7u:
							num = (_96A4AFF88F984DA9 = _003CModule_003E._390073C602714496<int>(2131963235));
							E3086BD24204416D = awaiter;
							_1BD64DB164714B1C.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num7 = -1995061515;
							continue;
						case 1u:
							E3086BD24204416D = default;
							num = (_96A4AFF88F984DA9 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num7 = -2002209590;
							continue;
						case 6u:
							return;
						default:
							result = awaiter.GetResult();
							goto end_IL_009e;
						}
						break;
					}
					goto IL_00a1;
					IL_0118:
					awaiter = E3086BD24204416D;
					num7 = 1919399374;
					goto IL_00a6;
					end_IL_009e:;
				}
				catch (Exception ex)
				{
					while (true)
					{
						IL_01d0:
						int num10 = 164945872;
						while (true)
						{
							int num3 = num10;
							uint num4;
							switch ((num4 = (uint)(-(-1151826575 - -(-(-(-(-num3) * -1328452731)))))) % 4)
							{
							case 0u:
								break;
							default:
								goto end_IL_01d5;
							case 3u:
								C1DA53E41F214647(C179263454B44BF6._54DF173DA5E74DC3, ex, _003CModule_003E._3F57E81A62734AC2<string>(190323877), Array.Empty<object>());
								num10 = 2413654;
								continue;
							case 1u:
								result = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
								num10 = -746551527;
								continue;
							case 2u:
								goto end_IL_01d5;
							}
							goto IL_01d0;
							continue;
							end_IL_01d5:
							break;
						}
						break;
					}
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_96A4AFF88F984DA9 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
				_1BD64DB164714B1C.SetException(exception);
				return;
			}
			_96A4AFF88F984DA9 = _003CModule_003E._390073C602714496<int>(818201983);
			while (true)
			{
				int num11 = 972082439;
				while (true)
				{
					int num3 = num11;
					uint num4;
					switch ((num4 = (uint)(-(-1151826575 - -(-(-(-(-num3) * -1328452731)))))) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_02a9;
					case 1u:
						return;
					}
					break;
					IL_02a9:
					_1BD64DB164714B1C.SetResult(result);
					num11 = ((int)num4 * -2039580565) ^ -1326210248;
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
			_1BD64DB164714B1C.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static Task<bool> ED09D1A9500C4870(object P_0, object P_1, CancellationToken P_2)
		{
			return ((_02C54685DE0E4B81)P_0)._6E01EC7AE9294356((_652C34B1E6554F10)P_1, P_2);
		}

		static void C1DA53E41F214647(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	private readonly ConcurrentDictionary<Guid, TaskCompletionSource<_6BD76CD39E2A4E73>> _9DBC4714135448F4;

	private readonly CancellationToken _6F41C421EC514990;

	private _02C54685DE0E4B81? _97DF35E1DA234D93 => ((_1DB744298E9F4B09)_95E825D2BB0040F0())._0D077240941749FA;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(A2605BD50E9A4797))]
	public Task<bool> C0812FEDC7E142DB(_83D3069491A44F2C P_0)
	{
		A2605BD50E9A4797 stateMachine = default;
		stateMachine._1BD64DB164714B1C = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._6B7B72C22D2549CA = this;
		stateMachine._9B413A5C69A643FF = P_0;
		while (true)
		{
			int num = -1058091767;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-(-(~num2 ^ -114244928) - ~(-(--1114399562) - 1973988213)) ^ -(-363692649 - 516175574) ^ -887538069))) % 4)
				{
				case 0u:
					break;
				case 3u:
					stateMachine._96A4AFF88F984DA9 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120);
					num = -1186217788;
					continue;
				case 2u:
					stateMachine._1BD64DB164714B1C.Start(ref stateMachine);
					num = ((int)num3 * -1516675398) ^ 0xAD67A93;
					continue;
				default:
					return stateMachine._1BD64DB164714B1C.Task;
				}
				break;
			}
		}
	}

	public void _30F434DE5EF741DC(Guid P_0, TaskCompletionSource<_6BD76CD39E2A4E73> P_1)
	{
		_9DBC4714135448F4.TryAdd(P_0, P_1);
	}

	public void CC65BE05F6C34614(Guid P_0, _6BD76CD39E2A4E73 P_1)
	{
		if (!_9DBC4714135448F4.TryGetValue(P_0, out TaskCompletionSource<_6BD76CD39E2A4E73> value))
		{
			return;
		}
		while (true)
		{
			int num = -2128256695;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((num2 * -52306431 - ~(-(~(~(1400835915 - 1715560357))) - (-1945793032 - (-(~-575641964) + unchecked(-146546799 * -1901412889))))) * -498034265)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0064;
				case 1u:
					return;
				}
				break;
				IL_0064:
				value.TrySetResult(P_1);
				num = (int)((num3 * 676559530) ^ 0x1E857DA3);
			}
		}
	}

	public void _1AB9E065CC1E4BE9(Guid P_0)
	{
		_9DBC4714135448F4.TryRemove(P_0, out TaskCompletionSource<_6BD76CD39E2A4E73> _);
	}

	public _50316A65685442A0()
	{
		ConcurrentDictionary<Guid, TaskCompletionSource<_6BD76CD39E2A4E73>> concurrentDictionary = null;
		_95E825D2BB0040F0();
		_548826F12A95422C((object)null);
		_9DBC4714135448F4 = concurrentDictionary;
		_6F41C421EC514990 = default;
		throw new Exception();
	}

	static object _95E825D2BB0040F0()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static CancellationToken _548826F12A95422C(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0).A70B1408B5ED4F4E;
	}
}
