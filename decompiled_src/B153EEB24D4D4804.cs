using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using SDG.Unturned;

internal sealed class B153EEB24D4D4804 : global::_94E3D906D3E34B5F<C29F1D31DC7C465F>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _86482D4646F642BB : IAsyncStateMachine
	{
		public int _8499845786D74E4A;

		public AsyncTaskMethodBuilder _890EEE7035D341F2;

		public C29F1D31DC7C465F _0144623E8A4948EA;

		private Awaiter _02CF75B11FDF48DB;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			int num = _8499845786D74E4A;
			try
			{
				if (num != 0)
				{
					goto IL_000d;
				}
				goto IL_01d0;
				IL_000d:
				int num2 = 537117486;
				goto IL_0012;
				IL_0012:
				SteamPlayer val = default;
				Awaiter awaiter = default;
				CancellationToken cancellationToken = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(~(~((-(num3 ^ (unchecked(unchecked(1706134467 * unchecked(1442784273 * ~(-335207751 + 1778296016 - unchecked(1905979039 * 2038796285)))) * 836673189) + 1371119393 * -(-202009713 ^ -663228957))) * -1964979227) ^ (-unchecked(-1130176209 * 1698822011) + unchecked(-1839793553 * -1432416417) + -(-(-112745149 ^ -1148088436)))) * 1437165531))) % 10)
					{
					case 6u:
						break;
					case 4u:
					{
						val = (SteamPlayer)_7DD7B4EEF6F64996(_0149E1684098424D((object)_0144623E8A4948EA));
						int num7;
						int num8;
						if (val != null)
						{
							num7 = 2046835242;
							num8 = num7;
						}
						else
						{
							num7 = -1813123149;
							num8 = num7;
						}
						num2 = num7 ^ (int)(num4 * 1245849735);
						continue;
					}
					case 9u:
						awaiter.GetResult();
						num2 = 1207794718;
						continue;
					case 0u:
					{
						SwitchToMainThreadAwaitable val2 = UniTask.SwitchToMainThread(cancellationToken);
						awaiter = val2.GetAwaiter();
						num2 = ((int)num4 * -370863733) ^ -1523915519;
						continue;
					}
					case 1u:
					{
						int num5;
						int num6;
						if (awaiter.IsCompleted)
						{
							num5 = -972138792;
							num6 = num5;
						}
						else
						{
							num5 = -1026595296;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num4 * 1256225499);
						continue;
					}
					case 8u:
						cancellationToken = default;
						num2 = (int)(num4 * 520285864) ^ -109973918;
						continue;
					case 5u:
						num = (_8499845786D74E4A = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
						_02CF75B11FDF48DB = awaiter;
						_890EEE7035D341F2.AwaitUnsafeOnCompleted<Awaiter, _86482D4646F642BB>(ref awaiter, ref this);
						return;
					case 3u:
						goto end_IL_0007;
					case 7u:
						goto IL_01d0;
					default:
						_005EB5AFD4C14B12((object)((_1DB744298E9F4B09)_45E984E788F24DF4()).CF47F3EE0E0C4452.F3B62BCE1450413B<E651E17AA2CA4BC8>(), B6B220A7510445ED((object)val), (ECheckCategory)_003CModule_003E._8B9C7B12B1AE4949<int>(861409582), (ECheckType)_003CModule_003E.F84FA79ABE6944BB<int>(1577688673), (EFlagLevel)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884), B855779D47064BFA(_003CModule_003E._8B9C7B12B1AE4949<string>(1255632976), C38A03C4143B4995((object)_0144623E8A4948EA)));
						goto end_IL_0007;
					}
					break;
				}
				goto IL_000d;
				IL_01d0:
				awaiter = _02CF75B11FDF48DB;
				_02CF75B11FDF48DB = default;
				num = (_8499845786D74E4A = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
				num2 = 1357402861;
				goto IL_0012;
				end_IL_0007:;
			}
			catch (Exception exception)
			{
				_8499845786D74E4A = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				_890EEE7035D341F2.SetException(exception);
				return;
			}
			_8499845786D74E4A = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
			_890EEE7035D341F2.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_890EEE7035D341F2.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static ulong _0149E1684098424D(object P_0)
		{
			return ((C29F1D31DC7C465F)P_0)._459F3072FA1A4B78;
		}

		static object _7DD7B4EEF6F64996(ulong P_0)
		{
			return PlayerTool.getSteamPlayer(P_0);
		}

		static object _45E984E788F24DF4()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static object B6B220A7510445ED(object P_0)
		{
			return ((SteamPlayer)P_0).playerID;
		}

		static string C38A03C4143B4995(object P_0)
		{
			return ((C29F1D31DC7C465F)P_0)._45A6C567243A4C24;
		}

		static string B855779D47064BFA(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static void _005EB5AFD4C14B12(object P_0, object P_1, ECheckCategory P_2, ECheckType P_3, EFlagLevel P_4, string P_5)
		{
			((E651E17AA2CA4BC8)P_0).E99E5CDB10C04998((SteamPlayerID)P_1, P_2, P_3, P_4, P_5);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_86482D4646F642BB))]
	public Task B425FF8A227D458B(_02C54685DE0E4B81 P_0, C29F1D31DC7C465F P_1, CancellationToken P_2 = default(CancellationToken))
	{
		_86482D4646F642BB stateMachine = default;
		stateMachine._890EEE7035D341F2 = AsyncTaskMethodBuilder.Create();
		while (true)
		{
			int num = 1546542224;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(((num2 - (293987349 * ((unchecked(~716735500 * 1979042951) - (-655498013 ^ -unchecked(2006066160 * -107815441))) ^ (-(unchecked(-1772543315 - 1663716941) - -449808930) ^ -1841369533)) + ~(~-47967814 - ~(~794385087 - --1625739998) - ~(-1281681563 ^ ~(-1110161534))))) ^ (-(~unchecked(-1523854319 * 447458519)) * 476778493)) - ~(0x1F6F44C2 ^ -513645206)) - (-1549108525 + unchecked(353795371 * 1377073326)) * -1287204405 - 1969505656)) % 4)
				{
				case 0u:
					break;
				case 1u:
					stateMachine._0144623E8A4948EA = P_1;
					num = (int)((num3 * 1187177002) ^ 0x5A406EF9);
					continue;
				case 2u:
					stateMachine._8499845786D74E4A = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817);
					num = 1033430270;
					continue;
				default:
					stateMachine._890EEE7035D341F2.Start(ref stateMachine);
					return stateMachine._890EEE7035D341F2.Task;
				}
				break;
			}
		}
	}

	Task global::_94E3D906D3E34B5F<C29F1D31DC7C465F>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, C29F1D31DC7C465F P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in B425FF8A227D458B
		return this.B425FF8A227D458B(P_0, P_1, P_2);
	}
}
