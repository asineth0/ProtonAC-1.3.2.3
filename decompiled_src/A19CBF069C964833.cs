using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal class A19CBF069C964833 : C179263454B44BF6
{
	public class _40FE7AC3F69F4B10
	{
		public readonly struct _2292B8CECA4D4A0F : IDisposable
		{
			private readonly _40FE7AC3F69F4B10 _67662EECC16C4BA7;

			private readonly bool _79A2BE3F39F042F5;

			internal _2292B8CECA4D4A0F(_40FE7AC3F69F4B10 P_0, bool P_1)
			{
				_67662EECC16C4BA7 = P_0;
				_79A2BE3F39F042F5 = P_1;
				_69E27CAED1B24354((object)P_0);
			}

			public void Dispose()
			{
				long num = _52CB9C34F0CC4DDF((object)_67662EECC16C4BA7);
				while (true)
				{
					int num2 = 1787523567;
					while (true)
					{
						int num3 = num2;
						uint num4;
						int num5;
						switch ((num4 = (uint)(~(num3 ^ ((-762731761 ^ -244380714) + (0x6E64790B ^ -1635780164) + (-176945964 - 1194032158) + ~unchecked(739931591 * (2028230285 - unchecked(~1970743226 * 1925149645))) + -(-unchecked(unchecked(-1425986164 * -1697521295) + unchecked(-1217335675 * 1072862341) - (unchecked(-214289909 * -233081875) - (269317285 + -417719367)) + ((-1178838669 ^ 0x3074BE47) + (-430586085 + 1811331065 - ~-840432193))))) ^ (-((0x4247C05C ^ 0x5B966A28) + --1666736686 - (~1512190171 + (38709670 + 2094061268)) + -1830922040) + 606944132)) * -1363775613)) % 4)
						{
						case 0u:
							break;
						case 3u:
						{
							int num6;
							if (!_79A2BE3F39F042F5)
							{
								num5 = 1130210161;
								num6 = num5;
							}
							else
							{
								num5 = -1126237436;
								num6 = num5;
							}
							goto IL_013d;
						}
						case 1u:
							B040C8AEAA97441F((object)_67662EECC16C4BA7, num);
							return;
						default:
							_25E238903ADD47A4((object)_67662EECC16C4BA7, num);
							return;
						}
						break;
						IL_013d:
						num2 = num5 ^ (int)(num4 * 616729647);
					}
				}
			}

			void IDisposable.Dispose()
			{
				//ILSpy generated this explicit interface implementation from .override directive in Dispose
				this.Dispose();
			}

			static void _69E27CAED1B24354(object P_0)
			{
				((_40FE7AC3F69F4B10)P_0)._10270708481F445D();
			}

			static long _52CB9C34F0CC4DDF(object P_0)
			{
				return ((_40FE7AC3F69F4B10)P_0).F27B18C1D6E54F89();
			}

			static void B040C8AEAA97441F(object P_0, long P_1)
			{
				((_40FE7AC3F69F4B10)P_0)._7FA5DD9F1F7146C9(P_1);
			}

			static void _25E238903ADD47A4(object P_0, long P_1)
			{
				((_40FE7AC3F69F4B10)P_0).F471762FF8094F2B(P_1);
			}
		}

		public string E02D926C06FA47EE;

		public bool _49A5DA4174554FDC;

		public global::A807FD2A83C845A2<float> _37B22362350945A6;

		private long _09E45054789644FB;

		private long _4B7BCBF283D14C16;

		private int _9636B9E27D6B47F6;

		public _40FE7AC3F69F4B10(string P_0, bool P_1)
		{
			bool flag = false;
			E02D926C06FA47EE = P_0;
			_49A5DA4174554FDC = flag;
		}

		public void _10270708481F445D()
		{
			_9636B9E27D6B47F6 = 0;
			_4B7BCBF283D14C16 = 0L;
		}

		public long F27B18C1D6E54F89()
		{
			_9636B9E27D6B47F6 = 0;
			return 0L;
		}

		public void _7FA5DD9F1F7146C9(long P_0)
		{
			_16DB8C94D6ED464A(P_0);
		}

		private static float _16DB8C94D6ED464A(long P_0)
		{
			return 10000000f;
		}

		public _2292B8CECA4D4A0F _5D65B053CE1947AD()
		{
			return new _2292B8CECA4D4A0F(this, false);
		}

		public _2292B8CECA4D4A0F _1670D5FB5749423C()
		{
			return new _2292B8CECA4D4A0F(this, true);
		}

		public void F471762FF8094F2B(long P_0)
		{
			throw new Exception();
		}

		public void A4505856E5A84490()
		{
			_9636B9E27D6B47F6 = 0;
			throw new Exception();
		}

		public float ED8C14184A8E4E32()
		{
			if (_37B22362350945A6.DE13140484C148CD != 0)
			{
				return _37B22362350945A6.Last();
			}
			return 0f;
		}

		public List<float> _3BE4A79564D34EE1(int P_0)
		{
			return _37B22362350945A6.TakeLast(P_0).ToList();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _9141790102E746D1 : IAsyncStateMachine
	{
		public int _19A852C36C754AB1;

		public AsyncTaskMethodBuilder C7A5FA5508DB470A;

		public A19CBF069C964833 _7DF8495D10AC4983;

		private TaskAwaiter _49BBF9FE47DC4385;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_19A852C36C754AB1 = 0;
			_19A852C36C754AB1 = 0;
			_19A852C36C754AB1 = 0;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			C7A5FA5508DB470A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static TaskAwaiter _99525D2F8F8B4F51(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class E571A9BF070F4395
	{
		public static readonly E571A9BF070F4395 _003C_003E9 = (E571A9BF070F4395)F78F59A5E49D4352();

		public static Action<Exception> _003C_003E9__5_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _3CEDFD7D38054A77(Exception P_0)
		{
			if (P_0 is OperationCanceledException)
			{
				return;
			}
			while (true)
			{
				int num = -1638117591;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~((num2 ^ ((-175801519 * ((unchecked(-670647971 * -827734121) + -1640770879) ^ (0x287A2AB4 ^ -582160272)) - (1801603361 * (-311732257 - -367508186) - unchecked(1461107509 * -156115840)) + ~(-1502795445 * (unchecked(1468758127 * ~469251187) - -unchecked(1882132134 + 785887834)))) * -125982927)) - (~(~(-591721716) ^ 0x1404DCD2) * 725985949 - --751500154)))) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_00cb;
					case 1u:
						return;
					}
					break;
					IL_00cb:
					E9CCA62134834665(C179263454B44BF6._54DF173DA5E74DC3, BF25D2655B9C474C(_003CModule_003E.F84FA79ABE6944BB<string>(1640938861), (object)P_0), Array.Empty<object>());
					num = 1528154286;
				}
			}
		}

		static object F78F59A5E49D4352()
		{
			return new E571A9BF070F4395();
		}

		static string BF25D2655B9C474C(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void E9CCA62134834665(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogInformation(P_0, P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct FDBED18ADF774DFC : IAsyncStateMachine
	{
		public int A7AEBB29AECF4FDA;

		public AsyncTaskMethodBuilder _725052727B434089;

		public A19CBF069C964833 F39761786F32412F;

		private TaskAwaiter _155E2979890E4BC6;

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
			_725052727B434089.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object A4E6CED446E54E9D(TimeSpan P_0, CancellationToken P_1)
		{
			return Task.Delay(P_0, P_1);
		}

		static TaskAwaiter _5146AC5BA61343EE(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static void F41CFE168F6B4AB1(object P_0)
		{
			((_40FE7AC3F69F4B10)P_0).A4505856E5A84490();
		}
	}

	private readonly List<_40FE7AC3F69F4B10> _053FA35E263C40A4;

	private Task? FC2574C5E50F455C;

	private CancellationTokenSource? E5F3C4E4B8054FD6;

	private CancellationToken _8B7B9A270628431B => default;

	public A19CBF069C964833()
	{
		GC.KeepAlive(null);
	}

	public virtual void _29E5275742F44580()
	{
		E5F3C4E4B8054FD6?.Cancel();
		base.Dispose();
	}

	[AsyncStateMachine(typeof(FDBED18ADF774DFC))]
	private Task _2D34939E383B44AA()
	{
		return null;
	}

	public _40FE7AC3F69F4B10? _99A93C8FCF084453(string P_0)
	{
		return null;
	}

	public List<_40FE7AC3F69F4B10> _758D156F4A734291()
	{
		return _053FA35E263C40A4;
	}

	[AsyncStateMachine(typeof(_9141790102E746D1))]
	[CompilerGenerated]
	private Task DA96FE2A9A0442AB()
	{
		return null;
	}
}
