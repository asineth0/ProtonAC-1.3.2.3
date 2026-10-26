using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using SDG.Unturned;
using UnityEngine;

public sealed class _2E54684D829B4208 : _200C0FCD340543F6
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _4BCEAE041E464C5F
	{
		public static readonly _4BCEAE041E464C5F _003C_003E9 = (_4BCEAE041E464C5F)DCAAB9F1A424497A();

		public static Func<string, bool> _003C_003E9__5_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _420CDF3BC45A4DE9(string P_0)
		{
			return (_4EAAEDD6D5DB44CE(P_0) ? 1 : 0) == _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
		}

		static object DCAAB9F1A424497A()
		{
			return new _4BCEAE041E464C5F();
		}

		static bool _4EAAEDD6D5DB44CE(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _8B0419C158DC4EB9 : IAsyncStateMachine
	{
		public int F30DB38FDADA436B;

		public AsyncUniTaskMethodBuilder _0A5A147C029B48C6;

		public string F58A3515CBD74C9B;

		public Color _8D73A986CA774674;

		public _2E54684D829B4208 EA491B1D96634FEF;

		public string _277A14FA33D94FA3;

		public bool _9BB5841576674058;

		private IEnumerable<string> _05A84F52B8E9433E;

		private Awaiter B0FAA05CC75E4F48;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			int num = F30DB38FDADA436B;
			_2E54684D829B4208 obj = EA491B1D96634FEF;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_01c5;
				IL_0014:
				int num2 = 810482659;
				goto IL_0019;
				IL_0019:
				Awaiter b0FAA05CC75E4F = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(~(-(num3 + (~(-((-498914446 ^ -1537365733) - (-1139512596 ^ 0x5B6B4FB8)) - (-(-1678713141 ^ -1958800933) - unchecked((-1275045415 ^ -262473867) + unchecked((1117607625 - 98202564) * -1264488735)))) - ~(-unchecked(unchecked(-319182687 * (~-1509632912 - 1695646749)) * 1457004059)))) ^ --715531098) - (0x1A05C0B9 ^ 0x6ED71466))) % 11)
					{
					case 4u:
						break;
					case 2u:
						B0FAA05CC75E4F48 = default;
						num2 = (int)((num4 * 949106145) ^ 0x730087E7);
						continue;
					case 3u:
					{
						int num10;
						int num11;
						if (!_05A84F52B8E9433E.Any())
						{
							num10 = 213727870;
							num11 = num10;
						}
						else
						{
							num10 = 2009023126;
							num11 = num10;
						}
						num2 = num10 ^ (int)(num4 * 127383993);
						continue;
					}
					case 1u:
					{
						int num12;
						int num13;
						if (!b0FAA05CC75E4F.IsCompleted)
						{
							num12 = -1825300234;
							num13 = num12;
						}
						else
						{
							num12 = 1259733512;
							num13 = num12;
						}
						num2 = num12 ^ ((int)num4 * -344190340);
						continue;
					}
					case 5u:
						_05A84F52B8E9433E = from P_0 in E0B6144F066D4587((object)F359D58D8405468B((object)F58A3515CBD74C9B, _8D93381FBA394ACC(), _003CModule_003E._3F57E81A62734AC2<string>(1329032340)), (char)_003CModule_003E.F84FA79ABE6944BB<int>(695290574), (StringSplitOptions)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
							where (_4BCEAE041E464C5F._4EAAEDD6D5DB44CE(P_0) ? 1 : 0) == _003CModule_003E._58ECCB512F2A43AC<int>(352679804)
							select P_0;
						num2 = 550528641;
						continue;
					case 0u:
						goto IL_01c5;
					case 8u:
					{
						SwitchToMainThreadAwaitable val = UniTask.SwitchToMainThread(default(CancellationToken));
						b0FAA05CC75E4F = val.GetAwaiter();
						num2 = -353833222;
						continue;
					}
					case 10u:
						goto end_IL_000e;
					case 9u:
						num = (F30DB38FDADA436B = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
						B0FAA05CC75E4F48 = b0FAA05CC75E4F;
						_0A5A147C029B48C6.AwaitUnsafeOnCompleted<Awaiter, _8B0419C158DC4EB9>(ref b0FAA05CC75E4F, ref this);
						return;
					case 7u:
						num = (F30DB38FDADA436B = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
						num2 = 569578112;
						continue;
					default:
					{
						b0FAA05CC75E4F.GetResult();
						IEnumerator<string> enumerator = _05A84F52B8E9433E.GetEnumerator();
						try
						{
							while (true)
							{
								IL_0379:
								int num5;
								int num6;
								if (!CF2EED82730F448A((object)enumerator))
								{
									num5 = 83784661;
									num6 = num5;
								}
								else
								{
									num5 = -421616966;
									num6 = num5;
								}
								while (true)
								{
									num3 = num5;
									switch ((num4 = (uint)(~(-(num3 + (~(-((-498914446 ^ -1537365733) - (-1139512596 ^ 0x5B6B4FB8)) - (-(-1678713141 ^ -1958800933) - unchecked((-1275045415 ^ -262473867) + unchecked((1117607625 - 98202564) * -1264488735)))) - ~(-unchecked(unchecked(-319182687 * (~-1509632912 - 1695646749)) * 1457004059)))) ^ --715531098) - (0x1A05C0B9 ^ 0x6ED71466))) % 4)
									{
									case 0u:
										num5 = -421616966;
										continue;
									default:
										goto end_IL_0284;
									case 2u:
										_6C95A1A34CBB4B93(enumerator.Current, _8D73A986CA774674, (SteamPlayer)null, ((SteamChannel)_1ECC4DB6208B4C30(_567B438560174060((object)obj))).owner, (EChatMode)_003CModule_003E.F84FA79ABE6944BB<int>(2084623923), _277A14FA33D94FA3, _9BB5841576674058);
										num5 = 521263031;
										continue;
									case 3u:
										break;
									case 1u:
										goto end_IL_0284;
									}
									goto IL_0379;
									continue;
									end_IL_0284:
									break;
								}
								break;
							}
						}
						finally
						{
							if (num < _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
							{
								while (true)
								{
									IL_03ad:
									int num7 = 808992309;
									while (true)
									{
										num3 = num7;
										switch ((num4 = (uint)(~(-(num3 + (~(-((-498914446 ^ -1537365733) - (-1139512596 ^ 0x5B6B4FB8)) - (-(-1678713141 ^ -1958800933) - unchecked((-1275045415 ^ -262473867) + unchecked((1117607625 - 98202564) * -1264488735)))) - ~(-unchecked(unchecked(-319182687 * (~-1509632912 - 1695646749)) * 1457004059)))) ^ --715531098) - (0x1A05C0B9 ^ 0x6ED71466))) % 4)
										{
										case 0u:
											break;
										default:
											goto end_IL_03b2;
										case 1u:
										{
											int num8;
											int num9;
											if (enumerator == null)
											{
												num8 = 590336065;
												num9 = num8;
											}
											else
											{
												num8 = -1514765132;
												num9 = num8;
											}
											num7 = num8 ^ (int)(num4 * 108474379);
											continue;
										}
										case 3u:
											_9D1DCF346E3745CC((object)enumerator);
											num7 = ((int)num4 * -1947531444) ^ 0x69F40366;
											continue;
										case 2u:
											goto end_IL_03b2;
										}
										goto IL_03ad;
										continue;
										end_IL_03b2:
										break;
									}
									break;
								}
							}
						}
						goto end_IL_000e;
					}
					}
					break;
				}
				goto IL_0014;
				IL_01c5:
				b0FAA05CC75E4F = B0FAA05CC75E4F48;
				num2 = 722935370;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num14 = -21032717;
					while (true)
					{
						int num3 = num14;
						uint num4;
						switch ((num4 = (uint)(~(-(num3 + (~(-((-498914446 ^ -1537365733) - (-1139512596 ^ 0x5B6B4FB8)) - (-(-1678713141 ^ -1958800933) - unchecked((-1275045415 ^ -262473867) + unchecked((1117607625 - 98202564) * -1264488735)))) - ~(-unchecked(unchecked(-319182687 * (~-1509632912 - 1695646749)) * 1457004059)))) ^ --715531098) - (0x1A05C0B9 ^ 0x6ED71466))) % 3)
						{
						case 2u:
							break;
						default:
							return;
						case 1u:
							goto IL_0556;
						case 0u:
							return;
						}
						break;
						IL_0556:
						F30DB38FDADA436B = _003CModule_003E._390073C602714496<int>(818201983);
						_05A84F52B8E9433E = null;
						_0A5A147C029B48C6.SetException(exception);
						num14 = 753374836;
					}
				}
			}
			F30DB38FDADA436B = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
			while (true)
			{
				int num15 = 649194230;
				while (true)
				{
					int num3 = num15;
					uint num4;
					switch ((num4 = (uint)(~(-(num3 + (~(-((-498914446 ^ -1537365733) - (-1139512596 ^ 0x5B6B4FB8)) - (-(-1678713141 ^ -1958800933) - unchecked((-1275045415 ^ -262473867) + unchecked((1117607625 - 98202564) * -1264488735)))) - ~(-unchecked(unchecked(-319182687 * (~-1509632912 - 1695646749)) * 1457004059)))) ^ --715531098) - (0x1A05C0B9 ^ 0x6ED71466))) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_064e;
					case 0u:
						return;
					}
					break;
					IL_064e:
					_05A84F52B8E9433E = null;
					_0A5A147C029B48C6.SetResult();
					num15 = (int)((num4 * 1836208525) ^ 0x4487B9FB);
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
			_0A5A147C029B48C6.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static string _8D93381FBA394ACC()
		{
			return Environment.NewLine;
		}

		static string F359D58D8405468B(object P_0, string P_1, string P_2)
		{
			return ((string)P_0).Replace(P_1, P_2);
		}

		static string[] E0B6144F066D4587(object P_0, char P_1, StringSplitOptions P_2)
		{
			return ((string)P_0).Split(P_1, P_2);
		}

		static object _567B438560174060(object P_0)
		{
			return ((_2E54684D829B4208)P_0)._8E24919E3C4745CF;
		}

		static object _1ECC4DB6208B4C30(object P_0)
		{
			return ((Player)P_0).channel;
		}

		static void _6C95A1A34CBB4B93(string P_0, Color P_1, SteamPlayer P_2, SteamPlayer P_3, EChatMode P_4, string P_5, bool P_6)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			ChatManager.serverSendMessage(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		}

		static bool CF2EED82730F448A(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		static void _9D1DCF346E3745CC(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	[CompilerGenerated]
	private readonly Player _67CBD22755934102;

	public Player _8E24919E3C4745CF
	{
		[CompilerGenerated]
		get
		{
			return _67CBD22755934102;
		}
	}

	internal _2E54684D829B4208(Player P_0)
	{
		while (true)
		{
			int num = -436985564;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(-num2)))) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0027;
				case 1u:
					return;
				}
				break;
				IL_0027:
				_67CBD22755934102 = P_0;
				num = (int)((num3 * 261626998) ^ 0x1C033FDA);
			}
		}
	}

	public Player _86B8FB96D28A449D()
	{
		return (Player)_8E8C2FB6540C40A7((object)this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_8B0419C158DC4EB9))]
	public UniTask E76D9B877BC943A6(string P_0, Color P_1, bool P_2 = true, string? P_3 = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		_8B0419C158DC4EB9 obj = default;
		obj._0A5A147C029B48C6 = AsyncUniTaskMethodBuilder.Create();
		while (true)
		{
			int num = 1583658934;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(num2 ^ (~(-1012924512 - -752055275) * -304137969 + (((-unchecked(703908122 + 1991844896) - (1229280716 + -1137037071 - (0xC979310 ^ -1107823033)) + ~(~unchecked(230365759 * 179240591))) * 224994347) ^ ~((0x5594B2A7 ^ ((-774165764 ^ 0x309F8EC4) + --891722755)) + (-unchecked(538656686 * -1204346625) + unchecked(~-837065123 * -515707185))))) ^ (-948163665 * (-56271223 * -(0x49F10E74 ^ 0x56C49892)) + (((0x14AB08F1 ^ 0x5132C4BC) + (-1178232892 - --1782131379)) ^ -(-2089923286 ^ -1574511490)) - (-802639203 + -878533156)) ^ -(-1329531188 + 1409818645)))) % 4)
				{
				case 0u:
					break;
				case 2u:
					obj.EA491B1D96634FEF = this;
					obj.F58A3515CBD74C9B = P_0;
					obj._8D73A986CA774674 = P_1;
					obj._9BB5841576674058 = P_2;
					obj._277A14FA33D94FA3 = P_3;
					num = (int)(num3 * 506914895) ^ -286253273;
					continue;
				case 3u:
					obj.F30DB38FDADA436B = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120);
					obj._0A5A147C029B48C6.Start<_8B0419C158DC4EB9>(ref obj);
					num = 1438126599;
					continue;
				default:
					return obj._0A5A147C029B48C6.Task;
				}
				break;
			}
		}
	}

	static object _8E8C2FB6540C40A7(object P_0)
	{
		return ((_2E54684D829B4208)P_0)._8E24919E3C4745CF;
	}
}
