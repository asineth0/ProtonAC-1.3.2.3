using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal sealed class E1BCCB8C609E4D1D : global::_94E3D906D3E34B5F<B6423B6AC0B843B4>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct A4FAA60AE10646AB : IAsyncStateMachine
	{
		public int BB93C4D1E0434FD8;

		public AsyncTaskMethodBuilder D44F42648D4243EA;

		public B6423B6AC0B843B4 D79E1D42F9974965;

		public _02C54685DE0E4B81 _34436A63518C43FC;

		private TaskAwaiter _65CE1BA3FBD1431A;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = BB93C4D1E0434FD8;
			try
			{
				if (num != 0)
				{
					goto IL_000d;
				}
				goto IL_0094;
				IL_000d:
				int num2 = -1781952298;
				goto IL_0012;
				IL_0012:
				string text2 = default;
				TaskAwaiter awaiter = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)((num3 * -537382049 * 1439130615) ^ -((~-625830703 - unchecked(-1283057737 * -1857002209) + -unchecked(340350087 * 1443861756)) ^ (-522185589 * (--2065414168 ^ 0x5B8F10BC))))) % 10)
					{
					case 7u:
						break;
					default:
						goto end_IL_0007;
					case 8u:
						goto IL_0094;
					case 2u:
						goto IL_00c5;
					case 3u:
						text2 = _0DFB3D673AB74E67((Enum)_05E24E32F7E243A1((object)D79E1D42F9974965));
						num2 = (int)((num4 * 658562076) ^ 0x53F72928);
						continue;
					case 5u:
						num = (BB93C4D1E0434FD8 = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042));
						num2 = -1135333969;
						continue;
					case 4u:
						_65CE1BA3FBD1431A = awaiter;
						D44F42648D4243EA.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 1u:
					{
						object obj = _79CDDE9E90B54EF8(F3E1D17A97D0468E());
						if (obj == null)
						{
							goto IL_01f9;
						}
						string text = _003CModule_003E._3F57E81A62734AC2<string>(-1339340730);
						object[] array = new object[_003CModule_003E._390073C602714496<int>(1302522752)];
						array[_003CModule_003E._58ECCB512F2A43AC<int>(352679804)] = text2;
						array[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)] = E8D9FC3D85F34DD4((object)D79E1D42F9974965);
						_1E2DE7AAECBD4068((ILogger)obj, text, array);
						num2 = 928397727;
						continue;
					}
					case 6u:
						goto IL_01f9;
					case 0u:
						awaiter.GetResult();
						num2 = -2061642992;
						continue;
					case 9u:
						goto end_IL_0007;
					}
					break;
					IL_01f9:
					int num5;
					if (!_5B8124925846408A((object)D79E1D42F9974965))
					{
						num2 = -2061642992;
						num5 = num2;
					}
					else
					{
						num2 = 446461859;
						num5 = num2;
					}
					continue;
					IL_00c5:
					awaiter = _38291023522243EC(_97AEA599560B4752((object)_34436A63518C43FC, _05F5581A978C401D((object)D79E1D42F9974965), _5910C04F1935431E((object)D79E1D42F9974965), (WebSocketCloseStatus)_003CModule_003E._8B9C7B12B1AE4949<int>(-750025980), _003CModule_003E._58ECCB512F2A43AC<string>(-2065201726)));
					int num6;
					if (awaiter.IsCompleted)
					{
						num2 = -1602348509;
						num6 = num2;
					}
					else
					{
						num2 = 264797806;
						num6 = num2;
					}
				}
				goto IL_000d;
				IL_0094:
				awaiter = _65CE1BA3FBD1431A;
				_65CE1BA3FBD1431A = default;
				num = (BB93C4D1E0434FD8 = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
				num2 = -1602348509;
				goto IL_0012;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num7 = -458286474;
					while (true)
					{
						int num3 = num7;
						uint num4;
						switch ((num4 = (uint)((num3 * -537382049 * 1439130615) ^ -((~-625830703 - unchecked(-1283057737 * -1857002209) + -unchecked(340350087 * 1443861756)) ^ (-522185589 * (--2065414168 ^ 0x5B8F10BC))))) % 3)
						{
						case 2u:
							break;
						case 1u:
							goto IL_0298;
						default:
							D44F42648D4243EA.SetException(exception);
							return;
						}
						break;
						IL_0298:
						BB93C4D1E0434FD8 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
						num7 = 201773852;
					}
				}
			}
			BB93C4D1E0434FD8 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			D44F42648D4243EA.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			D44F42648D4243EA.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static _886B4E6839FE475C _05E24E32F7E243A1(object P_0)
		{
			return ((B6423B6AC0B843B4)P_0).B984232847934EF6;
		}

		static string _0DFB3D673AB74E67(Enum P_0)
		{
			return P_0._06C963E93B514E5F();
		}

		static object F3E1D17A97D0468E()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static object _79CDDE9E90B54EF8(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
		}

		static string E8D9FC3D85F34DD4(object P_0)
		{
			return ((B6423B6AC0B843B4)P_0)._7C4B8D9668124322;
		}

		static void _1E2DE7AAECBD4068(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static bool _5B8124925846408A(object P_0)
		{
			return ((B6423B6AC0B843B4)P_0)._7128CD7504F34060;
		}

		static bool _05F5581A978C401D(object P_0)
		{
			return ((B6423B6AC0B843B4)P_0)._2AE5676B565245C5;
		}

		static bool _5910C04F1935431E(object P_0)
		{
			return ((B6423B6AC0B843B4)P_0)._00E058F504814402;
		}

		static object _97AEA599560B4752(object P_0, bool P_1, bool P_2, WebSocketCloseStatus P_3, string P_4)
		{
			return ((_02C54685DE0E4B81)P_0).B248057F431F42E0(P_1, P_2, P_3, P_4);
		}

		static TaskAwaiter _38291023522243EC(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(A4FAA60AE10646AB))]
	public Task _573DBE6C4CA24C95(_02C54685DE0E4B81 P_0, B6423B6AC0B843B4 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		A4FAA60AE10646AB stateMachine = default;
		stateMachine.D44F42648D4243EA = AsyncTaskMethodBuilder.Create();
		stateMachine._34436A63518C43FC = P_0;
		stateMachine.D79E1D42F9974965 = P_1;
		stateMachine.BB93C4D1E0434FD8 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120);
		stateMachine.D44F42648D4243EA.Start(ref stateMachine);
		return stateMachine.D44F42648D4243EA.Task;
	}

	Task global::_94E3D906D3E34B5F<B6423B6AC0B843B4>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, B6423B6AC0B843B4 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in 573DBE6C4CA24C95
		return this._573DBE6C4CA24C95(P_0, P_1, P_2);
	}
}
