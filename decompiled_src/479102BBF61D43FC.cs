using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;

internal sealed class _479102BBF61D43FC : global::_94E3D906D3E34B5F<A407C0CDC00D40B0>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct FEBB6A118C344A51 : IAsyncStateMachine
	{
		public int _9FAE6C0574114A3C;

		public AsyncTaskMethodBuilder F0EBA3D69E514A95;

		public A407C0CDC00D40B0 _40499ADB547E4075;

		public _02C54685DE0E4B81 _664BAE3F32D94A63;

		public CancellationToken _542E15D266B1404B;

		private AA43369C3B1A47A1 EF03FC35C4D3473C;

		private Awaiter _3B9A1311BFAB468C;

		private Awaiter _8508187883E0443C;

		private TaskAwaiter _78C517A9F5D84236;

		private TaskAwaiter<bool> D4236B211076449A;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_0359: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_047a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_023e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0416: Unknown result type (might be due to invalid IL or missing references)
			//IL_041b: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			int num = _9FAE6C0574114A3C;
			try
			{
				int num2;
				Awaiter awaiter3 = default;
				SwitchToThreadPoolAwaitable val = default;
				TaskAwaiter<bool> awaiter4 = default;
				Awaiter awaiter2 = default;
				TaskAwaiter awaiter = default;
				SwitchToMainThreadAwaitable val2 = default;
				switch (num)
				{
				default:
					num2 = 232613097;
					goto IL_0022;
				case 1:
					goto IL_01f1;
				case 0:
					goto IL_0358;
				case 3:
					goto IL_0442;
				case 2:
					goto IL_056e;
					IL_0022:
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)((num3 ^ ~(-(-2010085738 ^ -1113331083) * -779411705)) * 1582105015 - (0x5C5579C7 ^ (1230274834 - 841846951 * (-101965355 - unchecked(2047085661 + 664358053)))) - ((-(133922748 - 1713921064) ^ (--1311432551 + unchecked(-1633778009 + -705518045))) - -(-1554175432) * -922266457) - (unchecked(-2041866993 * -1822368873) - unchecked(183734013 + -1869788216 + ~1521450772)) - ~unchecked(-88666941 * -1014876031))) % 29)
						{
						case 6u:
							break;
						default:
							goto end_IL_0008;
						case 11u:
						{
							awaiter3 = val.GetAwaiter();
							int num7;
							int num8;
							if (!awaiter3.IsCompleted)
							{
								num7 = 2027621474;
								num8 = num7;
							}
							else
							{
								num7 = -1474517452;
								num8 = num7;
							}
							num2 = num7 ^ ((int)num4 * -1732603991);
							continue;
						}
						case 24u:
							awaiter4.GetResult();
							num2 = 364981202;
							continue;
						case 8u:
							goto IL_01f1;
						case 26u:
							return;
						case 14u:
							_8508187883E0443C = awaiter3;
							num2 = ((int)num4 * -362931316) ^ 0x3E7E4543;
							continue;
						case 2u:
						{
							int num9;
							int num10;
							if (awaiter2.IsCompleted)
							{
								num9 = -55303907;
								num10 = num9;
							}
							else
							{
								num9 = -286036544;
								num10 = num9;
							}
							num2 = num9 ^ (int)(num4 * 1414938645);
							continue;
						}
						case 20u:
							goto IL_027c;
						case 22u:
							num = (_9FAE6C0574114A3C = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num2 = 1780917872;
							continue;
						case 15u:
							F0EBA3D69E514A95.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num2 = ((int)num4 * -312811235) ^ 0x6DEE5D70;
							continue;
						case 19u:
							return;
						case 4u:
							val2 = UniTask.SwitchToMainThread(default(CancellationToken));
							num2 = ((int)num4 * -529399337) ^ -1318555216;
							continue;
						case 12u:
							goto IL_031d;
						case 3u:
							goto IL_0358;
						case 27u:
							num = (_9FAE6C0574114A3C = _003CModule_003E._3F57E81A62734AC2<int>(1017304263));
							num2 = 1799401304;
							continue;
						case 21u:
							num = (_9FAE6C0574114A3C = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563));
							_3B9A1311BFAB468C = awaiter2;
							F0EBA3D69E514A95.AwaitUnsafeOnCompleted<Awaiter, FEBB6A118C344A51>(ref awaiter2, ref this);
							return;
						case 16u:
							num = (_9FAE6C0574114A3C = _003CModule_003E._58ECCB512F2A43AC<int>(1571980983));
							D4236B211076449A = awaiter4;
							F0EBA3D69E514A95.AwaitUnsafeOnCompleted(ref awaiter4, ref this);
							num2 = 566670201;
							continue;
						case 7u:
							F0EBA3D69E514A95.AwaitUnsafeOnCompleted<Awaiter, FEBB6A118C344A51>(ref awaiter3, ref this);
							num2 = ((int)num4 * -1210996932) ^ -1108589927;
							continue;
						case 17u:
							awaiter2 = val2.GetAwaiter();
							num2 = ((int)num4 * -693100994) ^ 0x7427159B;
							continue;
						case 0u:
							num2 = (int)(num4 * 1588869102) ^ -22407260;
							continue;
						case 1u:
							goto IL_0442;
						case 10u:
							_3B9A1311BFAB468C = default;
							num = (_9FAE6C0574114A3C = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num2 = 433440094;
							continue;
						case 9u:
						{
							awaiter = _85FADEA350C04620(_028D5F230D3647CC((object)_664BAE3F32D94A63, (object)EF03FC35C4D3473C, D2B86318279F4839((object)_40499ADB547E4075), _542E15D266B1404B));
							int num5;
							int num6;
							if (awaiter.IsCompleted)
							{
								num5 = -818297616;
								num6 = num5;
							}
							else
							{
								num5 = 478268214;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num4 * 1666402016);
							continue;
						}
						case 25u:
							awaiter.GetResult();
							num2 = 1319892995;
							continue;
						case 18u:
							awaiter2.GetResult();
							EF03FC35C4D3473C = (AA43369C3B1A47A1)F2E552DE85BB4891((object)((_1DB744298E9F4B09)AE268D9108D8439C()).CF47F3EE0E0C4452.F3B62BCE1450413B<_85A0C820EF334E82>());
							val = UniTask.SwitchToThreadPool();
							num2 = -389626096;
							continue;
						case 5u:
							num = (_9FAE6C0574114A3C = _003CModule_003E._58ECCB512F2A43AC<int>(1208532887));
							_78C517A9F5D84236 = awaiter;
							num2 = 770062672;
							continue;
						case 23u:
							return;
						case 13u:
							goto IL_056e;
						case 28u:
							goto end_IL_0008;
						}
						break;
						IL_031d:
						awaiter4 = _35913063ED814BCA((object)_664BAE3F32D94A63, (object)EF03FC35C4D3473C, _542E15D266B1404B).GetAwaiter();
						int num11;
						if (!awaiter4.IsCompleted)
						{
							num2 = -612763149;
							num11 = num2;
						}
						else
						{
							num2 = 598855941;
							num11 = num2;
						}
						continue;
						IL_027c:
						awaiter3.GetResult();
						int num12;
						if (!_69220645D7BA437B((object)_40499ADB547E4075))
						{
							num2 = -1417810983;
							num12 = num2;
						}
						else
						{
							num2 = -1167316172;
							num12 = num2;
						}
					}
					goto default;
					IL_056e:
					awaiter = _78C517A9F5D84236;
					_78C517A9F5D84236 = default;
					num2 = 69099463;
					goto IL_0022;
					IL_0442:
					awaiter4 = D4236B211076449A;
					D4236B211076449A = default;
					num = (_9FAE6C0574114A3C = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
					num2 = 598855941;
					goto IL_0022;
					IL_0358:
					awaiter2 = _3B9A1311BFAB468C;
					num2 = -1383075698;
					goto IL_0022;
					IL_01f1:
					awaiter3 = _8508187883E0443C;
					_8508187883E0443C = default;
					num = (_9FAE6C0574114A3C = _003CModule_003E._390073C602714496<int>(-736908096));
					num2 = -687433028;
					goto IL_0022;
					end_IL_0008:
					break;
				}
			}
			catch (Exception exception)
			{
				_9FAE6C0574114A3C = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
				while (true)
				{
					int num13 = 999170329;
					while (true)
					{
						int num3 = num13;
						uint num4;
						switch ((num4 = (uint)((num3 ^ ~(-(-2010085738 ^ -1113331083) * -779411705)) * 1582105015 - (0x5C5579C7 ^ (1230274834 - 841846951 * (-101965355 - unchecked(2047085661 + 664358053)))) - ((-(133922748 - 1713921064) ^ (--1311432551 + unchecked(-1633778009 + -705518045))) - -(-1554175432) * -922266457) - (unchecked(-2041866993 * -1822368873) - unchecked(183734013 + -1869788216 + ~1521450772)) - ~unchecked(-88666941 * -1014876031))) % 4)
						{
						case 2u:
							break;
						default:
							return;
						case 3u:
							EF03FC35C4D3473C = null;
							num13 = (int)(num4 * 1746357811) ^ -1025268687;
							continue;
						case 0u:
							F0EBA3D69E514A95.SetException(exception);
							num13 = ((int)num4 * -604682826) ^ -1366969413;
							continue;
						case 1u:
							return;
						}
						break;
					}
				}
			}
			_9FAE6C0574114A3C = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			EF03FC35C4D3473C = null;
			while (true)
			{
				int num14 = -778727523;
				while (true)
				{
					int num3 = num14;
					uint num4;
					switch ((num4 = (uint)((num3 ^ ~(-(-2010085738 ^ -1113331083) * -779411705)) * 1582105015 - (0x5C5579C7 ^ (1230274834 - 841846951 * (-101965355 - unchecked(2047085661 + 664358053)))) - ((-(133922748 - 1713921064) ^ (--1311432551 + unchecked(-1633778009 + -705518045))) - -(-1554175432) * -922266457) - (unchecked(-2041866993 * -1822368873) - unchecked(183734013 + -1869788216 + ~1521450772)) - ~unchecked(-88666941 * -1014876031))) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_084f;
					case 1u:
						return;
					}
					break;
					IL_084f:
					F0EBA3D69E514A95.SetResult();
					num14 = (int)((num4 * 851206365) ^ 0x1687132C);
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
			F0EBA3D69E514A95.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object AE268D9108D8439C()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static object F2E552DE85BB4891(object P_0)
		{
			return ((_85A0C820EF334E82)P_0)._40CCC338AB744483();
		}

		static bool _69220645D7BA437B(object P_0)
		{
			return ((_652C34B1E6554F10)P_0)._34B44C79896F4AF2;
		}

		static long D2B86318279F4839(object P_0)
		{
			return ((_652C34B1E6554F10)P_0).C4CF7218A3D4459F;
		}

		static object _028D5F230D3647CC(object P_0, object P_1, long P_2, CancellationToken P_3)
		{
			return ((_02C54685DE0E4B81)P_0)._884DB9DE8C5C4C0A((_652C34B1E6554F10)P_1, P_2, P_3);
		}

		static TaskAwaiter _85FADEA350C04620(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static Task<bool> _35913063ED814BCA(object P_0, object P_1, CancellationToken P_2)
		{
			return ((_02C54685DE0E4B81)P_0)._6E01EC7AE9294356((_652C34B1E6554F10)P_1, P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(FEBB6A118C344A51))]
	public Task C8D6A877BFBD436D(_02C54685DE0E4B81 P_0, A407C0CDC00D40B0 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		FEBB6A118C344A51 stateMachine = default;
		stateMachine.F0EBA3D69E514A95 = AsyncTaskMethodBuilder.Create();
		while (true)
		{
			int num = -1040638083;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(num2 ^ (~(0x616F0C4C ^ (-251075645 * --1401798579 - (-1129781672 ^ -523553809) - ~(-(-147531567 + -12713185)))) ^ ((~(-458728341 ^ 0x59204F6F) - 1600663817 * -unchecked((0x9B03DD ^ 0x7F9E0708) + unchecked(-1909458103 * 1802647974))) ^ 0x47AA2845)) ^ (~(~(~-975031874) - 1125949992 - 1023535057 * -(~-29685539)) + (~-175200464 - unchecked(unchecked(1962719465 * ~281761250) * 1065557573) - -(-unchecked(-1836742179 * (-307046348 - 562612034)))))))) % 4)
				{
				case 0u:
					break;
				case 2u:
					stateMachine._664BAE3F32D94A63 = P_0;
					stateMachine._40499ADB547E4075 = P_1;
					stateMachine._542E15D266B1404B = P_2;
					stateMachine._9FAE6C0574114A3C = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
					num = -59524228;
					continue;
				case 3u:
					stateMachine.F0EBA3D69E514A95.Start(ref stateMachine);
					num = (int)(num3 * 1763022497) ^ -1916426519;
					continue;
				default:
					return stateMachine.F0EBA3D69E514A95.Task;
				}
				break;
			}
		}
	}

	Task global::_94E3D906D3E34B5F<A407C0CDC00D40B0>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, A407C0CDC00D40B0 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in C8D6A877BFBD436D
		return this.C8D6A877BFBD436D(P_0, P_1, P_2);
	}
}
