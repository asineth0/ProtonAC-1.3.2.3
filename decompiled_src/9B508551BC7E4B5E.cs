using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

public class _9B508551BC7E4B5E : C179263454B44BF6
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _87D9B9CE2D364E4A : IAsyncStateMachine
	{
		public int _085D0C84F04F442A;

		public AsyncTaskMethodBuilder<bool> _3AF188D47AF24EBD;

		public _9B508551BC7E4B5E E10C23B9CD7D4231;

		public ulong EA7064853C714990;

		public string A11A038283024D20;

		private TaskAwaiter<bool> _6D82FB2477714F81;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _085D0C84F04F442A;
			_9B508551BC7E4B5E obj = E10C23B9CD7D4231;
			bool result = default;
			try
			{
				if (num == 0)
				{
					goto IL_0113;
				}
				while (true)
				{
					int num2 = 1272429131;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(-(-1900319797 ^ -1565639942) * -1008125761 - ~-1749704332 - -(num3 - -(~2081776325) - -((1512075835 + (--897217512 + unchecked(-1224439919 * -395302421)) - (--1572870476 + (-1392521028 ^ -525543031) + (-1653137633 ^ 0x1BDA6B79))) * -13883805)) + (1008630037 + unchecked(~-1832999964 + (10873556 + 515905775))))) % 5)
						{
						case 2u:
							break;
						case 4u:
						{
							int num5;
							int num6;
							if (obj._4F48502159354CD4 != null)
							{
								num5 = -715557433;
								num6 = num5;
							}
							else
							{
								num5 = 749424640;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num4 * 1497102881);
							continue;
						}
						case 3u:
							result = (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0;
							num2 = -1564770439;
							continue;
						case 0u:
							goto end_IL_0014;
						default:
							goto IL_0113;
						}
						break;
					}
					continue;
					end_IL_0014:
					break;
				}
				goto end_IL_000e;
				IL_0113:
				try
				{
					if (num != 0)
					{
						goto IL_0119;
					}
					goto IL_0238;
					IL_0119:
					int num7 = -1238940185;
					goto IL_011e;
					IL_011e:
					TaskAwaiter<bool> awaiter = default;
					while (true)
					{
						int num3 = num7;
						uint num4;
						switch ((num4 = (uint)(-(-1900319797 ^ -1565639942) * -1008125761 - ~-1749704332 - -(num3 - -(~2081776325) - -((1512075835 + (--897217512 + unchecked(-1224439919 * -395302421)) - (--1572870476 + (-1392521028 ^ -525543031) + (-1653137633 ^ 0x1BDA6B79))) * -13883805)) + (1008630037 + unchecked(~-1832999964 + (10873556 + 515905775))))) % 8)
						{
						case 6u:
							break;
						case 0u:
							_6D82FB2477714F81 = awaiter;
							_3AF188D47AF24EBD.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num7 = ((int)num4 * -1975551587) ^ 0x712714C9;
							continue;
						case 3u:
						{
							int num8;
							int num9;
							if (!awaiter.IsCompleted)
							{
								num8 = 133717573;
								num9 = num8;
							}
							else
							{
								num8 = 243467324;
								num9 = num8;
							}
							num7 = num8 ^ (int)(num4 * 1410276563);
							continue;
						}
						case 1u:
							return;
						case 2u:
							goto IL_0238;
						case 7u:
							awaiter = _30B9FB7C64CF4BBA((object)obj._4F48502159354CD4, FFDA2CCB7B384412(EA7064853C714990, A11A038283024D20, (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0), obj._8D85E31BF90F4422, (TimeSpan?)TimeSpan.FromMinutes(_003CModule_003E.F84FA79ABE6944BB<double>(1027680148))).GetAwaiter();
							num7 = 2130844099;
							continue;
						case 4u:
							num = (_085D0C84F04F442A = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042));
							num7 = 1188866160;
							continue;
						default:
							result = awaiter.GetResult();
							goto end_IL_0113;
						}
						break;
					}
					goto IL_0119;
					IL_0238:
					awaiter = _6D82FB2477714F81;
					_6D82FB2477714F81 = default;
					num = (_085D0C84F04F442A = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
					num7 = -1676352931;
					goto IL_011e;
					end_IL_0113:;
				}
				catch (Exception ex)
				{
					_525910F3DCEF4572(C179263454B44BF6._54DF173DA5E74DC3, ex, _003CModule_003E.F84FA79ABE6944BB<string>(1178670047), Array.Empty<object>());
					result = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
				}
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_085D0C84F04F442A = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
				_3AF188D47AF24EBD.SetException(exception);
				return;
			}
			_085D0C84F04F442A = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
			while (true)
			{
				int num10 = -1302985165;
				while (true)
				{
					int num3 = num10;
					uint num4;
					switch ((num4 = (uint)(-(-1900319797 ^ -1565639942) * -1008125761 - ~-1749704332 - -(num3 - -(~2081776325) - -((1512075835 + (--897217512 + unchecked(-1224439919 * -395302421)) - (--1572870476 + (-1392521028 ^ -525543031) + (-1653137633 ^ 0x1BDA6B79))) * -13883805)) + (1008630037 + unchecked(~-1832999964 + (10873556 + 515905775))))) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_03ed;
					case 0u:
						return;
					}
					break;
					IL_03ed:
					_3AF188D47AF24EBD.SetResult(result);
					num10 = ((int)num4 * -437638779) ^ -42298240;
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
			_3AF188D47AF24EBD.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object FFDA2CCB7B384412(ulong P_0, string P_1, bool P_2)
		{
			return new _099C214D55A84477(P_0, P_1, P_2);
		}

		static Task<bool> _30B9FB7C64CF4BBA(object P_0, object P_1, CancellationToken P_2, TimeSpan? P_3)
		{
			return ((_02C54685DE0E4B81)P_0)._6B8C087F18814C58((_652C34B1E6554F10)P_1, P_2, P_3);
		}

		static void _525910F3DCEF4572(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct D46DC7DBBC294A2A : IAsyncStateMachine
	{
		public int _081328641221437F;

		public AsyncTaskMethodBuilder<bool> _59142CE898DD44D2;

		public _9B508551BC7E4B5E _4D152D56BC774B72;

		public ulong FF0A6350648C40F7;

		public F9DC65C0B16C4603 CA3ECEB5DCFB43B8;

		private TaskAwaiter<bool> _85DF80B24D7A4811;

		private void MoveNext()
		{
			int num = _081328641221437F;
			_9B508551BC7E4B5E obj = _4D152D56BC774B72;
			bool result;
			try
			{
				if (num != 0 && obj._4F48502159354CD4 == null)
				{
					result = false;
				}
				else
				{
					try
					{
						TaskAwaiter<bool> awaiter;
						if (num != 0)
						{
							awaiter = obj._4F48502159354CD4._6B8C087F18814C58(new _19EE01C7CE6C4BD9(FF0A6350648C40F7, Guid.NewGuid(), CA3ECEB5DCFB43B8), obj._8D85E31BF90F4422, TimeSpan.FromMinutes(10.0)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_081328641221437F = 0);
								_85DF80B24D7A4811 = awaiter;
								_59142CE898DD44D2.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _85DF80B24D7A4811;
							_85DF80B24D7A4811 = default;
							num = (_081328641221437F = -1);
						}
						result = awaiter.GetResult();
					}
					catch (Exception ex)
					{
						LoggerExtensions.LogError(C179263454B44BF6._54DF173DA5E74DC3, ex, "Failed to send draw map request", Array.Empty<object>());
						result = false;
					}
				}
			}
			catch (Exception exception)
			{
				_081328641221437F = -2;
				_59142CE898DD44D2.SetException(exception);
				return;
			}
			_081328641221437F = -2;
			_59142CE898DD44D2.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_59142CE898DD44D2.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private readonly CancellationToken _8D85E31BF90F4422;

	private _02C54685DE0E4B81? _4F48502159354CD4 => ((_1DB744298E9F4B09)B4EA45A651CB495C())._0D077240941749FA;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_87D9B9CE2D364E4A))]
	public Task<bool> C3CBD45B38E74922(ulong P_0, string P_1)
	{
		_87D9B9CE2D364E4A stateMachine = default;
		stateMachine._3AF188D47AF24EBD = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.E10C23B9CD7D4231 = this;
		stateMachine.EA7064853C714990 = P_0;
		while (true)
		{
			int num = -1466764116;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-((0x341A278A ^ -364024009) - ~(-(num2 * 1637929007))) * -1059509107 * -1873175791))) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0093;
				default:
					stateMachine._3AF188D47AF24EBD.Start(ref stateMachine);
					return stateMachine._3AF188D47AF24EBD.Task;
				}
				break;
				IL_0093:
				stateMachine.A11A038283024D20 = P_1;
				stateMachine._085D0C84F04F442A = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
				num = 1245367592;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(D46DC7DBBC294A2A))]
	public Task<bool> _8836F1A5FA9A47D4(ulong P_0, F9DC65C0B16C4603 P_1)
	{
		D46DC7DBBC294A2A stateMachine = default;
		stateMachine._59142CE898DD44D2 = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._4D152D56BC774B72 = this;
		stateMachine.FF0A6350648C40F7 = P_0;
		stateMachine.CA3ECEB5DCFB43B8 = P_1;
		stateMachine._081328641221437F = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
		stateMachine._59142CE898DD44D2.Start(ref stateMachine);
		return stateMachine._59142CE898DD44D2.Task;
	}

	public _9B508551BC7E4B5E()
	{
		B4EA45A651CB495C();
		D5DC7B5ECC744289((object)null);
		_8D85E31BF90F4422 = D5DC7B5ECC744289((object)null);
		throw new Exception();
	}

	static object B4EA45A651CB495C()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static CancellationToken D5DC7B5ECC744289(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0).A70B1408B5ED4F4E;
	}
}
