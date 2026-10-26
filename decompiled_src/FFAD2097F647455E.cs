using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

internal sealed class FFAD2097F647455E : global::_94E3D906D3E34B5F<D08691711E724502>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct E7E0775CC8D74A86 : IAsyncStateMachine
	{
		public int _5EAD1DF63F06449B;

		public AsyncTaskMethodBuilder _3D2ADBA85D014503;

		public D08691711E724502 EAE48EFD8EEC4319;

		private Awaiter _90184390EC9440F0;

		private Awaiter D3DAA3BF9EB74A5C;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			int num = _5EAD1DF63F06449B;
			try
			{
				if (num != 0)
				{
					goto IL_000d;
				}
				goto IL_01e1;
				IL_000d:
				int num2 = -1441442962;
				goto IL_0012;
				IL_0012:
				Awaiter awaiter = default;
				Awaiter awaiter2 = default;
				SteamPlayer val = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)((~(-((--1620935220 ^ 0x1875E679) * 843649609 + (--1481709134 + unchecked(1349778139 * 980153479) + (-862854821 ^ 0x773EE815)))) - num3 * -2055552759) ^ 0x2094373)) % 16)
					{
					case 4u:
						break;
					case 6u:
						num = (_5EAD1DF63F06449B = _003CModule_003E._8B9C7B12B1AE4949<int>(350091668));
						D3DAA3BF9EB74A5C = awaiter;
						num2 = 1907010311;
						continue;
					case 9u:
						awaiter = D3DAA3BF9EB74A5C;
						num2 = 1056425724;
						continue;
					case 7u:
					{
						SwitchToMainThreadAwaitable val2 = UniTask.SwitchToMainThread(default(CancellationToken));
						awaiter2 = val2.GetAwaiter();
						int num7;
						int num8;
						if (awaiter2.IsCompleted)
						{
							num7 = 1325346175;
							num8 = num7;
						}
						else
						{
							num7 = -1850207663;
							num8 = num7;
						}
						num2 = num7 ^ ((int)num4 * -1073909491);
						continue;
					}
					case 13u:
						_3D2ADBA85D014503.AwaitUnsafeOnCompleted<Awaiter, E7E0775CC8D74A86>(ref awaiter, ref this);
						return;
					case 5u:
						_9B15A71493034D9F(_003CModule_003E.F84FA79ABE6944BB<string>(-1220028650), Color.white, (SteamPlayer)null, val, (EChatMode)_003CModule_003E._390073C602714496<int>(1661075637), _025B061817784AB3((object)EAE48EFD8EEC4319), (byte)_003CModule_003E._3F57E81A62734AC2<int>(1017304263) != 0);
						num2 = 1617483619;
						continue;
					case 12u:
						goto IL_0194;
					case 15u:
						_90184390EC9440F0 = default;
						num = (_5EAD1DF63F06449B = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
						num2 = 1135195764;
						continue;
					case 14u:
						goto IL_01e1;
					case 8u:
					{
						val = (SteamPlayer)_364FF690B8454500(new CSteamID(E6CF81C4D71F4A0A((object)EAE48EFD8EEC4319)));
						int num5;
						int num6;
						if (val != null)
						{
							num5 = 1031225335;
							num6 = num5;
						}
						else
						{
							num5 = -851668965;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num4 * 1024220231);
						continue;
					}
					case 11u:
						num = (_5EAD1DF63F06449B = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
						num2 = 2127158949;
						continue;
					case 2u:
						D3DAA3BF9EB74A5C = default;
						num2 = (int)((num4 * 1173037190) ^ 0x47DDB7B1);
						continue;
					case 0u:
						num = (_5EAD1DF63F06449B = _003CModule_003E._390073C602714496<int>(2131963235));
						_90184390EC9440F0 = awaiter2;
						_3D2ADBA85D014503.AwaitUnsafeOnCompleted<Awaiter, E7E0775CC8D74A86>(ref awaiter2, ref this);
						return;
					case 1u:
						goto IL_029d;
					case 10u:
						awaiter2.GetResult();
						num2 = 1605372226;
						continue;
					default:
						awaiter.GetResult();
						goto end_IL_0007;
					}
					break;
					IL_029d:
					SwitchToThreadPoolAwaitable val3 = UniTask.SwitchToThreadPool();
					awaiter = val3.GetAwaiter();
					int num9;
					if (!awaiter.IsCompleted)
					{
						num2 = 692938056;
						num9 = num2;
					}
					else
					{
						num2 = 2127158949;
						num9 = num2;
					}
					continue;
					IL_0194:
					int num10;
					if (num != _003CModule_003E._390073C602714496<int>(-250964212))
					{
						num2 = 1290111745;
						num10 = num2;
					}
					else
					{
						num2 = -1007103029;
						num10 = num2;
					}
				}
				goto IL_000d;
				IL_01e1:
				awaiter2 = _90184390EC9440F0;
				num2 = 51489641;
				goto IL_0012;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num11 = 183880299;
					while (true)
					{
						int num3 = num11;
						uint num4;
						switch ((num4 = (uint)((~(-((--1620935220 ^ 0x1875E679) * 843649609 + (--1481709134 + unchecked(1349778139 * 980153479) + (-862854821 ^ 0x773EE815)))) - num3 * -2055552759) ^ 0x2094373)) % 4)
						{
						case 3u:
							break;
						default:
							return;
						case 1u:
							_5EAD1DF63F06449B = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
							num11 = 1845386168;
							continue;
						case 2u:
							_3D2ADBA85D014503.SetException(exception);
							num11 = ((int)num4 * -1301710886) ^ 0x7DE9CCE6;
							continue;
						case 0u:
							return;
						}
						break;
					}
				}
			}
			_5EAD1DF63F06449B = _003CModule_003E._390073C602714496<int>(818201983);
			_3D2ADBA85D014503.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_3D2ADBA85D014503.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static ulong E6CF81C4D71F4A0A(object P_0)
		{
			return ((D08691711E724502)P_0)._392F2945CA144A30;
		}

		static object _364FF690B8454500(CSteamID P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return PlayerTool.getSteamPlayer(P_0);
		}

		static string _025B061817784AB3(object P_0)
		{
			return ((D08691711E724502)P_0)._107908C557794813;
		}

		static void _9B15A71493034D9F(string P_0, Color P_1, SteamPlayer P_2, SteamPlayer P_3, EChatMode P_4, string P_5, bool P_6)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			ChatManager.serverSendMessage(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(E7E0775CC8D74A86))]
	public Task _2A139B69B24945D5(_02C54685DE0E4B81 P_0, D08691711E724502 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		E7E0775CC8D74A86 stateMachine = default;
		stateMachine._3D2ADBA85D014503 = AsyncTaskMethodBuilder.Create();
		stateMachine.EAE48EFD8EEC4319 = P_1;
		stateMachine._5EAD1DF63F06449B = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
		stateMachine._3D2ADBA85D014503.Start(ref stateMachine);
		return stateMachine._3D2ADBA85D014503.Task;
	}

	Task global::_94E3D906D3E34B5F<D08691711E724502>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, D08691711E724502 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in 2A139B69B24945D5
		return this._2A139B69B24945D5(P_0, P_1, P_2);
	}
}
