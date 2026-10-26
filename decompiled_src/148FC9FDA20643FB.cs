using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Microsoft.Extensions.Localization;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

public class _148FC9FDA20643FB(_200C0FCD340543F6 P_0, string[] P_1) : FB9603B015784B9C
{
	[CompilerGenerated]
	private sealed class F83EA94894A94496
	{
		[StructLayout(LayoutKind.Auto)]
		private struct DCE84B5A30E74D2B : IAsyncStateMachine
		{
			public int _4DAA9E1002D740B9;

			public AsyncUniTaskVoidMethodBuilder _8F897728DCCB46F7;

			public F83EA94894A94496 _2BF3CF55A04A487E;

			private Awaiter A29E34B265824139;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
				//IL_013f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0144: Unknown result type (might be due to invalid IL or missing references)
				//IL_0147: Unknown result type (might be due to invalid IL or missing references)
				//IL_014c: Unknown result type (might be due to invalid IL or missing references)
				int num = _4DAA9E1002D740B9;
				F83EA94894A94496 f83EA94894A = _2BF3CF55A04A487E;
				try
				{
					if (num != 0)
					{
						goto IL_0014;
					}
					goto IL_0128;
					IL_0014:
					int num2 = 2046124029;
					goto IL_0019;
					IL_0019:
					Awaiter a29E34B = default;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)((0x258B14E ^ -1373142175) - ~num3 * 1942967901 - unchecked(~1722328992 + unchecked(2004241495 * 78369844)) - ((0x3404BECC ^ 0xE4E8968) + ~(-1428333456)))) % 8)
						{
						case 2u:
							break;
						default:
							goto end_IL_000e;
						case 5u:
							A29E34B265824139 = a29E34B;
							_8F897728DCCB46F7.AwaitUnsafeOnCompleted<Awaiter, DCE84B5A30E74D2B>(ref a29E34B, ref this);
							return;
						case 6u:
							A29E34B265824139 = default;
							num = (_4DAA9E1002D740B9 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num2 = -495354185;
							continue;
						case 1u:
							a29E34B.GetResult();
							num2 = 2096100201;
							continue;
						case 4u:
							num = (_4DAA9E1002D740B9 = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
							num2 = 1826670035;
							continue;
						case 0u:
							goto IL_0128;
						case 7u:
						{
							UniTask val = _83694AA0B0E448EC((object)f83EA94894A._4E44D80A21654F93);
							a29E34B = val.GetAwaiter();
							int num5;
							int num6;
							if (a29E34B.IsCompleted)
							{
								num5 = 1044828575;
								num6 = num5;
							}
							else
							{
								num5 = -1682704898;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num4 * 1676215832);
							continue;
						}
						case 3u:
							goto end_IL_000e;
						}
						break;
					}
					goto IL_0014;
					IL_0128:
					a29E34B = A29E34B265824139;
					num2 = -436742696;
					goto IL_0019;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					_4DAA9E1002D740B9 = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
					_8F897728DCCB46F7.SetException(exception);
					return;
				}
				_4DAA9E1002D740B9 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				_8F897728DCCB46F7.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_8F897728DCCB46F7.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static UniTask _83694AA0B0E448EC(object P_0)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return ((_148FC9FDA20643FB)P_0).CD8C425326C64AB5();
			}
		}

		public _148FC9FDA20643FB _4E44D80A21654F93;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(DCE84B5A30E74D2B))]
		internal UniTaskVoid _2B559F00451A449C()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			DCE84B5A30E74D2B dCE84B5A30E74D2B = default;
			dCE84B5A30E74D2B._8F897728DCCB46F7 = AsyncUniTaskVoidMethodBuilder.Create();
			dCE84B5A30E74D2B._2BF3CF55A04A487E = this;
			dCE84B5A30E74D2B._4DAA9E1002D740B9 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120);
			dCE84B5A30E74D2B._8F897728DCCB46F7.Start<DCE84B5A30E74D2B>(ref dCE84B5A30E74D2B);
			return dCE84B5A30E74D2B._8F897728DCCB46F7.Task;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _8AF6331E943144F4 : IAsyncStateMachine
	{
		public int _213BA1D9C27145CC;

		public AsyncUniTaskMethodBuilder _116FC2362C114D51;

		public _148FC9FDA20643FB C639F38DC3D5475B;

		private Awaiter _71B84601FF194825;

		private TaskAwaiter<bool> EEC5A862EDC8437C;

		private string _8F53B32FBC024A8C;

		private Awaiter B3985E84DB64474E;

		private List<SteamPlayer>.Enumerator _32966CE25F4B41F7;

		private SteamPlayer _8E525E60E3A24894;

		private AA43369C3B1A47A1 _4CEF489E50344905;

		private Awaiter _39E83795D3354955;

		private int _1305D1BC3BE54374;

		private TaskAwaiter<B0603A9963A3423A> DDC850B2C1B34E86;

		private TaskAwaiter A40A40ADC0DD4B36;

		private List<string> _353C93F6D73341B7;

		private List<string>.Enumerator _4F0E9D79B97C47B9;

		private Player BF8153357FCA495D;

		private bool _829C2E5021804851;

		private C7A753824C0746AE._359F714CB1DB4E96 BFF3185EDDB1428E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_0fe0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fe5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1137: Unknown result type (might be due to invalid IL or missing references)
			//IL_113c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0717: Unknown result type (might be due to invalid IL or missing references)
			//IL_071c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0723: Unknown result type (might be due to invalid IL or missing references)
			//IL_097a: Unknown result type (might be due to invalid IL or missing references)
			//IL_097f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0986: Unknown result type (might be due to invalid IL or missing references)
			//IL_124a: Unknown result type (might be due to invalid IL or missing references)
			//IL_124f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1256: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d55: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d61: Unknown result type (might be due to invalid IL or missing references)
			//IL_11bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_11c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_17cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c92: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c99: Unknown result type (might be due to invalid IL or missing references)
			//IL_1af5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1afa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b02: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bf5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bfa: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c02: Unknown result type (might be due to invalid IL or missing references)
			//IL_2613: Unknown result type (might be due to invalid IL or missing references)
			//IL_2618: Unknown result type (might be due to invalid IL or missing references)
			//IL_261f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2718: Unknown result type (might be due to invalid IL or missing references)
			//IL_271d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2368: Unknown result type (might be due to invalid IL or missing references)
			//IL_236d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2507: Unknown result type (might be due to invalid IL or missing references)
			//IL_250c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ded: Unknown result type (might be due to invalid IL or missing references)
			//IL_2df2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dfa: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dba: Unknown result type (might be due to invalid IL or missing references)
			//IL_2dbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d48: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d54: Unknown result type (might be due to invalid IL or missing references)
			//IL_421c: Unknown result type (might be due to invalid IL or missing references)
			//IL_4221: Unknown result type (might be due to invalid IL or missing references)
			//IL_4228: Unknown result type (might be due to invalid IL or missing references)
			//IL_37d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_37d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_37e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_410f: Unknown result type (might be due to invalid IL or missing references)
			//IL_4114: Unknown result type (might be due to invalid IL or missing references)
			//IL_352b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3530: Unknown result type (might be due to invalid IL or missing references)
			//IL_3537: Unknown result type (might be due to invalid IL or missing references)
			//IL_34ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_34f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_40d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_40d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_40e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_41c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_41ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_41d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_40f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_40f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_40fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c25: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b07: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_1218: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c23: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c24: Unknown result type (might be due to invalid IL or missing references)
			//IL_17da: Unknown result type (might be due to invalid IL or missing references)
			//IL_17df: Unknown result type (might be due to invalid IL or missing references)
			//IL_19e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_19e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b39: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aba: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bba: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c18: Unknown result type (might be due to invalid IL or missing references)
			//IL_2564: Unknown result type (might be due to invalid IL or missing references)
			//IL_23b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_26f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_2793: Unknown result type (might be due to invalid IL or missing references)
			//IL_2795: Unknown result type (might be due to invalid IL or missing references)
			//IL_25a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_25a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_23da: Unknown result type (might be due to invalid IL or missing references)
			//IL_23df: Unknown result type (might be due to invalid IL or missing references)
			//IL_26b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_26bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_26c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_26c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_22e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_22e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_27b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_2e24: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2cb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_426a: Unknown result type (might be due to invalid IL or missing references)
			//IL_426b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3313: Unknown result type (might be due to invalid IL or missing references)
			//IL_3318: Unknown result type (might be due to invalid IL or missing references)
			//IL_4186: Unknown result type (might be due to invalid IL or missing references)
			//IL_418b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_38b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_38bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_34a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_34a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3548: Unknown result type (might be due to invalid IL or missing references)
			//IL_354a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3c81: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_373d: Unknown result type (might be due to invalid IL or missing references)
			//IL_3742: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e22: Unknown result type (might be due to invalid IL or missing references)
			//IL_3e27: Unknown result type (might be due to invalid IL or missing references)
			//IL_3466: Unknown result type (might be due to invalid IL or missing references)
			//IL_38e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_38ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_4197: Unknown result type (might be due to invalid IL or missing references)
			//IL_419c: Unknown result type (might be due to invalid IL or missing references)
			//IL_41a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_41a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_41f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_41fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_4201: Unknown result type (might be due to invalid IL or missing references)
			//IL_4206: Unknown result type (might be due to invalid IL or missing references)
			//IL_33a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_4008: Unknown result type (might be due to invalid IL or missing references)
			//IL_4009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0659: Unknown result type (might be due to invalid IL or missing references)
			//IL_065e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0663: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0754: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0503: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a52: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_1113: Unknown result type (might be due to invalid IL or missing references)
			//IL_1114: Unknown result type (might be due to invalid IL or missing references)
			//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_135e: Unknown result type (might be due to invalid IL or missing references)
			//IL_135f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0431: Unknown result type (might be due to invalid IL or missing references)
			//IL_10ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_10cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a71: Unknown result type (might be due to invalid IL or missing references)
			//IL_18ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_18b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1820: Unknown result type (might be due to invalid IL or missing references)
			//IL_1822: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1932: Unknown result type (might be due to invalid IL or missing references)
			//IL_1937: Unknown result type (might be due to invalid IL or missing references)
			//IL_193c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f67: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f73: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f56: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2479: Unknown result type (might be due to invalid IL or missing references)
			//IL_2650: Unknown result type (might be due to invalid IL or missing references)
			//IL_2655: Unknown result type (might be due to invalid IL or missing references)
			//IL_265a: Unknown result type (might be due to invalid IL or missing references)
			//IL_265e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2663: Unknown result type (might be due to invalid IL or missing references)
			//IL_25ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_25f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2525: Unknown result type (might be due to invalid IL or missing references)
			//IL_252a: Unknown result type (might be due to invalid IL or missing references)
			//IL_252f: Unknown result type (might be due to invalid IL or missing references)
			//IL_24f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_24f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d23: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d25: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d92: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d97: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d75: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d76: Unknown result type (might be due to invalid IL or missing references)
			//IL_300a: Unknown result type (might be due to invalid IL or missing references)
			//IL_300f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3d1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3f99: Unknown result type (might be due to invalid IL or missing references)
			//IL_37b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_37b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_3718: Unknown result type (might be due to invalid IL or missing references)
			//IL_3719: Unknown result type (might be due to invalid IL or missing references)
			//IL_3341: Unknown result type (might be due to invalid IL or missing references)
			//IL_3343: Unknown result type (might be due to invalid IL or missing references)
			//IL_350c: Unknown result type (might be due to invalid IL or missing references)
			//IL_3511: Unknown result type (might be due to invalid IL or missing references)
			//IL_3516: Unknown result type (might be due to invalid IL or missing references)
			//IL_351a: Unknown result type (might be due to invalid IL or missing references)
			//IL_351f: Unknown result type (might be due to invalid IL or missing references)
			//IL_38a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_38a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_35b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_35b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_32e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_32e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_32ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_32ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_32f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b11: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b16: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3b24: Unknown result type (might be due to invalid IL or missing references)
			//IL_3668: Unknown result type (might be due to invalid IL or missing references)
			//IL_366a: Unknown result type (might be due to invalid IL or missing references)
			//IL_3dcb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0802: Unknown result type (might be due to invalid IL or missing references)
			//IL_0807: Unknown result type (might be due to invalid IL or missing references)
			//IL_080b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0810: Unknown result type (might be due to invalid IL or missing references)
			//IL_0766: Unknown result type (might be due to invalid IL or missing references)
			//IL_076b: Unknown result type (might be due to invalid IL or missing references)
			//IL_076f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0774: Unknown result type (might be due to invalid IL or missing references)
			//IL_0515: Unknown result type (might be due to invalid IL or missing references)
			//IL_051a: Unknown result type (might be due to invalid IL or missing references)
			//IL_051e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0523: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_12c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_12ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0447: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0450: Unknown result type (might be due to invalid IL or missing references)
			//IL_0455: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a83: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a88: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a91: Unknown result type (might be due to invalid IL or missing references)
			//IL_248b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2490: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fab: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_3fb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_3ddd: Unknown result type (might be due to invalid IL or missing references)
			//IL_3de2: Unknown result type (might be due to invalid IL or missing references)
			//IL_14b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1505: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f29: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1df2: Unknown result type (might be due to invalid IL or missing references)
			//IL_20ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_20f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fc1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f3b: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f40: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fa1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2fa6: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a24: Unknown result type (might be due to invalid IL or missing references)
			//IL_3a29: Unknown result type (might be due to invalid IL or missing references)
			//IL_212e: Unknown result type (might be due to invalid IL or missing references)
			//IL_212f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1e84: Unknown result type (might be due to invalid IL or missing references)
			//IL_2159: Unknown result type (might be due to invalid IL or missing references)
			//IL_215e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2163: Unknown result type (might be due to invalid IL or missing references)
			//IL_2efd: Unknown result type (might be due to invalid IL or missing references)
			//IL_2efe: Unknown result type (might be due to invalid IL or missing references)
			//IL_2be6: Unknown result type (might be due to invalid IL or missing references)
			//IL_2beb: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bef: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bf4: Unknown result type (might be due to invalid IL or missing references)
			int num = _213BA1D9C27145CC;
			_148FC9FDA20643FB obj = C639F38DC3D5475B;
			try
			{
				int num2;
				TaskAwaiter<bool> eEC5A862EDC8437C = default;
				Awaiter val = default;
				UniTask val2 = default;
				_2E54684D829B4208 obj2 = default;
				Awaiter b3985E84DB64474E = default;
				int num5 = default;
				string text = default;
				char c = default;
				CancellationToken cancellationToken = default;
				SwitchToMainThreadAwaitable val3 = default;
				int num49;
				int num50;
				int num51;
				Awaiter val5 = default;
				SwitchToThreadPoolAwaitable val4;
				TaskAwaiter a40A40ADC0DD4B = default;
				int num70;
				List<A19CBF069C964833._40FE7AC3F69F4B10>.Enumerator enumerator;
				int num85;
				int num93;
				SteamPlayer val6 = default;
				byte b = default;
				switch (num)
				{
				default:
					num2 = -1183379020;
					goto IL_00c5;
				case 9:
					goto IL_02e1;
				case 8:
					goto IL_033c;
				case 4:
					goto IL_0716;
				case 5:
					goto IL_0979;
				case 3:
					goto IL_0ace;
				case 1:
					goto IL_0b59;
				case 10:
					goto IL_0d54;
				case 0:
					goto IL_0fdf;
				case 7:
					goto IL_10ed;
				case 2:
					goto IL_1136;
				case 11:
					goto IL_11be;
				case 6:
					goto IL_1249;
				case 12:
					goto IL_13e7;
				case 14:
					goto IL_17c7;
				case 13:
					goto IL_1902;
				case 16:
					goto IL_1af4;
				case 17:
					goto IL_1bf4;
				case 15:
					goto IL_1c8c;
				case 18:
				case 19:
				case 20:
				case 21:
					goto IL_1cbe;
				case 25:
					goto IL_2367;
				case 26:
					goto IL_2506;
				case 22:
					goto IL_2612;
				case 23:
					goto IL_2717;
				case 24:
					goto IL_274e;
				case 28:
					goto IL_2db9;
				case 27:
					goto IL_2dec;
				case 29:
					goto IL_2e3e;
				case 37:
					goto IL_34ee;
				case 36:
					goto IL_352a;
				case 33:
					goto IL_37d3;
				case 35:
					goto IL_38c9;
				case 42:
					goto IL_3c24;
				case 31:
					goto IL_3d47;
				case 40:
					goto IL_3d78;
				case 30:
					goto IL_3dee;
				case 38:
					goto IL_40d3;
				case 41:
					goto IL_40f1;
				case 34:
					goto IL_410e;
				case 39:
					goto IL_41c4;
				case 32:
					goto IL_421b;
					IL_00c5:
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 116)
						{
						case 86u:
							break;
						case 92u:
							goto IL_02e1;
						case 68u:
							_71B84601FF194825 = default;
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = -1075852388;
							continue;
						case 14u:
							goto IL_033c;
						case 38u:
							_71B84601FF194825 = default;
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num2 = -1082609182;
							continue;
						case 28u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(1098108634));
							EEC5A862EDC8437C = eEC5A862EDC8437C;
							num2 = 380731337;
							continue;
						case 81u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(2131963235));
							_71B84601FF194825 = val;
							num2 = -1121207018;
							continue;
						case 18u:
							goto IL_03fb;
						case 99u:
							goto IL_041f;
						case 10u:
							_71B84601FF194825 = default;
							num2 = ((int)num4 * -788996707) ^ -627383936;
							continue;
						case 59u:
							goto IL_04aa;
						case 26u:
							val2 = A9B109CB5276484A((object)obj.D70334A6F9FB43AC, BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E._390073C602714496<string>(856723846))), Color.red, (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0, (string)null);
							val = val2.GetAwaiter();
							num2 = -653076873;
							continue;
						case 74u:
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(944380096));
							EEC5A862EDC8437C = eEC5A862EDC8437C;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _8AF6331E943144F4>(ref eEC5A862EDC8437C, ref this);
							return;
						case 11u:
							val.GetResult();
							goto end_IL_000f;
						case 90u:
							B3985E84DB64474E = default;
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096));
							num2 = 424487094;
							continue;
						case 83u:
							_442B7FBA97954791 = FB9603B015784B9C.A35C1F405E14467A.CF47F3EE0E0C4452.F3B62BCE1450413B<_85A0C820EF334E82>();
							_3C79809DB22A48D9 = FB9603B015784B9C.A35C1F405E14467A.CF47F3EE0E0C4452.F3B62BCE1450413B<C7A753824C0746AE>();
							num2 = (int)(num4 * 9512949) ^ -995927784;
							continue;
						case 54u:
							val = val2.GetAwaiter();
							num2 = ((int)num4 * -1227800085) ^ 0x1FCEFF28;
							continue;
						case 13u:
							F1FEC2A81524472A = FB9603B015784B9C.A35C1F405E14467A.CF47F3EE0E0C4452.F3B62BCE1450413B<E651E17AA2CA4BC8>();
							_1A13B20F5C464EB9 = FB9603B015784B9C.A35C1F405E14467A.CF47F3EE0E0C4452.F3B62BCE1450413B<B7097FC49A384CFA>();
							num2 = ((int)num4 * -622013143) ^ 0x45589155;
							continue;
						case 0u:
							val2 = obj._242543716BDB4890(_5BD35D831A404C2E(_003CModule_003E._8B9C7B12B1AE4949<string>(1920397855), B43F17A4C1424EC4(_08A7D348D0614530(_77AB40815D0C47BE()))), Color.white);
							num2 = -1093950766;
							continue;
						case 57u:
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = 488431924;
							continue;
						case 55u:
							goto IL_068d;
						case 107u:
							_951F97102D064735 = FB9603B015784B9C.A35C1F405E14467A.CF47F3EE0E0C4452.F3B62BCE1450413B<A19CBF069C964833>();
							num2 = (int)(num4 * 1551383334) ^ -881428549;
							continue;
						case 62u:
						{
							int num8;
							int num9;
							if (!val.IsCompleted)
							{
								num8 = -86056899;
								num9 = num8;
							}
							else
							{
								num8 = -250422370;
								num9 = num8;
							}
							num2 = num8 ^ ((int)num4 * -555251965);
							continue;
						}
						case 96u:
							goto IL_0716;
						case 19u:
							goto IL_0733;
						case 48u:
						{
							int num18;
							int num19;
							if (DD59AE63368F420E() == null)
							{
								num18 = 1834149784;
								num19 = num18;
							}
							else
							{
								num18 = 1789972665;
								num19 = num18;
							}
							num2 = num18 ^ (int)(num4 * 949519672);
							continue;
						}
						case 75u:
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							num2 = (int)(num4 * 58710980) ^ -1885143176;
							continue;
						case 4u:
							goto IL_07de;
						case 35u:
						{
							int num16;
							int num17;
							if (obj2 != null)
							{
								num16 = -1721137867;
								num17 = num16;
							}
							else
							{
								num16 = -243777878;
								num17 = num16;
							}
							num2 = num16 ^ (int)(num4 * 132106002);
							continue;
						}
						case 2u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref b3985E84DB64474E, ref this);
							return;
						case 20u:
							goto IL_0875;
						case 69u:
							goto IL_08ae;
						case 66u:
							goto IL_08d6;
						case 87u:
							val.GetResult();
							goto end_IL_000f;
						case 50u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 6u:
							goto IL_093a;
						case 45u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-292620683));
							num2 = 560963770;
							continue;
						case 44u:
							goto IL_0979;
						case 34u:
							goto IL_09aa;
						case 104u:
							return;
						case 22u:
							goto IL_09e0;
						case 46u:
							goto IL_0a17;
						case 42u:
							val2 = obj._242543716BDB4890(BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E._390073C602714496<string>(442815162))), Color.white);
							num2 = -1154370632;
							continue;
						case 49u:
							goto IL_0aa7;
						case 91u:
							goto IL_0ace;
						case 52u:
							val = val2.GetAwaiter();
							num2 = ((int)num4 * -1446278303) ^ 0x2F7FAF26;
							continue;
						case 65u:
						{
							int num14;
							int num15;
							if (!val.IsCompleted)
							{
								num14 = -356491706;
								num15 = num14;
							}
							else
							{
								num14 = 369257475;
								num15 = num14;
							}
							num2 = num14 ^ (int)(num4 * 128172250);
							continue;
						}
						case 71u:
							goto IL_0b59;
						case 61u:
							eEC5A862EDC8437C = _74DD419E29E14A61((object)FB9603B015784B9C._316F91961FA14705, _48876E33D81047E6((object)obj.D70334A6F9FB43AC), _003CModule_003E.F84FA79ABE6944BB<string>(-941975231)).GetAwaiter();
							num2 = 739782649;
							continue;
						case 31u:
							goto IL_0bb4;
						case 103u:
						{
							int num12;
							int num13;
							if (_3E991342A9BF4CEB(DD59AE63368F420E()))
							{
								num12 = 1706916300;
								num13 = num12;
							}
							else
							{
								num12 = 358864755;
								num13 = num12;
							}
							num2 = num12 ^ ((int)num4 * -1395989959);
							continue;
						}
						case 110u:
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 47u:
							goto IL_0c67;
						case 100u:
							_71B84601FF194825 = val;
							num2 = (int)((num4 * 2029702322) ^ 0x6A27F0F1);
							continue;
						case 102u:
						{
							int num10;
							int num11;
							if (val.IsCompleted)
							{
								num10 = -265041755;
								num11 = num10;
							}
							else
							{
								num10 = -231752066;
								num11 = num10;
							}
							num2 = num10 ^ ((int)num4 * -1581775114);
							continue;
						}
						case 9u:
							goto IL_0ce3;
						case 12u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num2 = 354440409;
							continue;
						case 25u:
							goto IL_0d54;
						case 16u:
							val.GetResult();
							goto end_IL_000f;
						case 109u:
							goto IL_0d9b;
						case 63u:
						{
							int num6;
							int num7;
							if (!eEC5A862EDC8437C.IsCompleted)
							{
								num6 = -1144955210;
								num7 = num6;
							}
							else
							{
								num6 = -387022749;
								num7 = num6;
							}
							num2 = num6 ^ (int)(num4 * 1444369364);
							continue;
						}
						case 73u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(1017304263));
							num2 = -458519032;
							continue;
						case 37u:
							goto IL_0dfa;
						case 77u:
							val.GetResult();
							goto end_IL_000f;
						case 60u:
							goto IL_0e34;
						case 24u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(-1181364256));
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 30u:
							goto IL_0e94;
						case 53u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(-1291160197));
							B3985E84DB64474E = b3985E84DB64474E;
							num2 = -1084341934;
							continue;
						case 106u:
							obj2 = obj.D70334A6F9FB43AC as _2E54684D829B4208;
							num2 = 516514589;
							continue;
						case 88u:
							goto IL_0ef2;
						case 15u:
							val.GetResult();
							goto end_IL_000f;
						case 95u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 64u:
							goto IL_0f4c;
						case 79u:
							val.GetResult();
							goto end_IL_000f;
						case 98u:
							b3985E84DB64474E.GetResult();
							_32966CE25F4B41F7 = ACBB5A52B1CF4D14().ToList().GetEnumerator();
							num2 = -758649679;
							continue;
						case 7u:
							goto IL_0fb2;
						case 3u:
							goto IL_0fdf;
						case 80u:
							num5 = _4F1A4299C0BE4B9D((object)text);
							switch (num5 - _003CModule_003E._8B9C7B12B1AE4949<int>(861409582))
							{
							case 6:
								break;
							case 3:
								goto IL_09aa;
							case 0:
								goto IL_0e34;
							case 2:
								goto IL_0ef2;
							default:
								goto IL_1028;
							case 1:
							case 4:
							case 5:
								goto IL_38b7;
							}
							goto IL_04aa;
						case 5u:
							text = obj._5CB5F38886F54B64[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)];
							if (text != null)
							{
								num2 = 243844308;
								continue;
							}
							goto IL_38b7;
						case 108u:
							return;
						case 115u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _8AF6331E943144F4>(ref eEC5A862EDC8437C, ref this);
							return;
						case 51u:
							goto IL_1094;
						case 114u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-1777584834));
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 36u:
							goto IL_10ed;
						case 76u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(975705554));
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 43u:
							goto IL_1136;
						case 1u:
							val.GetResult();
							goto end_IL_000f;
						case 82u:
							val.GetResult();
							goto end_IL_000f;
						case 40u:
							goto IL_1173;
						case 101u:
							goto IL_11a1;
						case 39u:
							goto IL_11be;
						case 27u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num2 = 180418213;
							continue;
						case 111u:
							goto IL_11ee;
						case 56u:
							_71B84601FF194825 = default;
							num2 = (int)(num4 * 1530228818) ^ -1092983785;
							continue;
						case 17u:
							goto IL_1249;
						case 70u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096));
							num2 = -750842387;
							continue;
						case 33u:
							return;
						case 72u:
							goto IL_129c;
						case 29u:
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							num2 = ((int)num4 * -546114874) ^ 0x20845279;
							continue;
						case 21u:
							goto IL_132c;
						case 89u:
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(1358231899));
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							num2 = -342164276;
							continue;
						case 94u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(887139723));
							num2 = -1524413767;
							continue;
						case 97u:
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-1540732256));
							num2 = -800122037;
							continue;
						case 8u:
							val.GetResult();
							goto end_IL_000f;
						default:
							goto IL_13e7;
						case 23u:
						case 32u:
						case 41u:
						case 58u:
						case 78u:
						case 84u:
						case 85u:
						case 93u:
						case 105u:
						case 112u:
						case 113u:
							goto IL_38b7;
							IL_1028:
							num2 = -834247069;
							continue;
							IL_0ef2:
							c = E0A5CA0656D94CD7((object)text, _003CModule_003E._8B9C7B12B1AE4949<int>(944380096));
							num2 = -1254144831;
							continue;
							IL_09aa:
							c = E0A5CA0656D94CD7((object)text, _003CModule_003E._390073C602714496<int>(2131963235));
							num2 = -221453263;
							continue;
						}
						break;
						IL_132c:
						int num20;
						if (eEC5A862EDC8437C.GetResult())
						{
							num2 = 842135307;
							num20 = num2;
						}
						else
						{
							num2 = -1322360766;
							num20 = num2;
						}
						continue;
						IL_0dfa:
						int num21;
						if (c != _003CModule_003E._58ECCB512F2A43AC<int>(380736777))
						{
							num2 = -277644985;
							num21 = num2;
						}
						else
						{
							num2 = -1323893618;
							num21 = num2;
						}
						continue;
						IL_0a17:
						_971383EA323F44E9((object)F1FEC2A81524472A, _48876E33D81047E6((object)obj2));
						val2 = obj._242543716BDB4890(BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E._390073C602714496<string>(1855477956))), Color.white);
						val = val2.GetAwaiter();
						int num22;
						if (!val.IsCompleted)
						{
							num2 = 495306070;
							num22 = num2;
						}
						else
						{
							num2 = -1082609182;
							num22 = num2;
						}
						continue;
						IL_129c:
						val2 = A9B109CB5276484A((object)obj.D70334A6F9FB43AC, _003CModule_003E._58ECCB512F2A43AC<string>(-780778298), Color.red, (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0, (string)null);
						val = val2.GetAwaiter();
						int num23;
						if (!val.IsCompleted)
						{
							num2 = -1230660208;
							num23 = num2;
						}
						else
						{
							num2 = -28644449;
							num23 = num2;
						}
						continue;
						IL_0733:
						val2 = A9B109CB5276484A((object)obj.D70334A6F9FB43AC, BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E._390073C602714496<string>(856723846))), Color.red, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019) != 0, (string)null);
						val = val2.GetAwaiter();
						int num24;
						if (val.IsCompleted)
						{
							num2 = 180418213;
							num24 = num2;
						}
						else
						{
							num2 = -587722145;
							num24 = num2;
						}
						continue;
						IL_0d9b:
						int num25;
						if (_951F97102D064735 == null)
						{
							num2 = -563903931;
							num25 = num2;
						}
						else
						{
							num2 = 228181296;
							num25 = num2;
						}
						continue;
						IL_11ee:
						int num26;
						if (c != _003CModule_003E._58ECCB512F2A43AC<int>(-106778271))
						{
							num2 = -1028497498;
							num26 = num2;
						}
						else
						{
							num2 = 523967823;
							num26 = num2;
						}
						continue;
						IL_03fb:
						int num27;
						if (c != _003CModule_003E._58ECCB512F2A43AC<int>(922562132))
						{
							num2 = -128430550;
							num27 = num2;
						}
						else
						{
							num2 = -841866770;
							num27 = num2;
						}
						continue;
						IL_09e0:
						cancellationToken = default;
						val3 = UniTask.SwitchToMainThread(cancellationToken);
						b3985E84DB64474E = val3.GetAwaiter();
						int num28;
						if (!b3985E84DB64474E.IsCompleted)
						{
							num2 = -924926477;
							num28 = num2;
						}
						else
						{
							num2 = 424487094;
							num28 = num2;
						}
						continue;
						IL_11a1:
						int num29;
						if (!eEC5A862EDC8437C.GetResult())
						{
							num2 = -317273599;
							num29 = num2;
						}
						else
						{
							num2 = -1443988706;
							num29 = num2;
						}
						continue;
						IL_0ce3:
						string[] source = obj._5CB5F38886F54B64;
						_8F53B32FBC024A8C = string.Join((char)_003CModule_003E._8B9C7B12B1AE4949<int>(-408136254), source.Skip(_003CModule_003E._58ECCB512F2A43AC<int>(1006217019)));
						int num30;
						if (AE7EF1D1F4FD421A(_8F53B32FBC024A8C))
						{
							num2 = -585415211;
							num30 = num2;
						}
						else
						{
							num2 = -943575742;
							num30 = num2;
						}
						continue;
						IL_0875:
						if (!F528D8CFC38342FD(text, _003CModule_003E._58ECCB512F2A43AC<string>(1367734941)))
						{
							num2 = 166996774;
							continue;
						}
						goto IL_345b;
						IL_1173:
						int num31;
						if (AE7EF1D1F4FD421A(obj._5CB5F38886F54B64[_003CModule_003E._390073C602714496<int>(2131963235)]))
						{
							num2 = 86819829;
							num31 = num2;
						}
						else
						{
							num2 = -1508990061;
							num31 = num2;
						}
						continue;
						IL_04aa:
						c = E0A5CA0656D94CD7((object)text, _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
						int num32;
						if (c != _003CModule_003E._390073C602714496<int>(992384955))
						{
							num2 = -651181489;
							num32 = num2;
						}
						else
						{
							num2 = 588114277;
							num32 = num2;
						}
						continue;
						IL_0c67:
						int num33;
						if (c == _003CModule_003E.F84FA79ABE6944BB<int>(354550111))
						{
							num2 = -805143936;
							num33 = num2;
						}
						else
						{
							num2 = -425377091;
							num33 = num2;
						}
						continue;
						IL_1094:
						if (!F528D8CFC38342FD(text, _003CModule_003E._58ECCB512F2A43AC<string>(332216992)))
						{
							num2 = -1068970549;
							continue;
						}
						goto IL_1aaf;
						IL_093a:
						if (!F528D8CFC38342FD(text, _003CModule_003E._8B9C7B12B1AE4949<string>(-620695351)))
						{
							num2 = -127788456;
							continue;
						}
						goto IL_3fc4;
						IL_0fb2:
						val2 = obj._637E3D758E1E4EA8();
						val = val2.GetAwaiter();
						int num34;
						if (val.IsCompleted)
						{
							num2 = 488431924;
							num34 = num2;
						}
						else
						{
							num2 = 256776419;
							num34 = num2;
						}
						continue;
						IL_07de:
						val2 = A9B109CB5276484A((object)obj.D70334A6F9FB43AC, _003CModule_003E._8B9C7B12B1AE4949<string>(-178853121), Color.red, (byte)_003CModule_003E._3F57E81A62734AC2<int>(1017304263) != 0, (string)null);
						val = val2.GetAwaiter();
						int num35;
						if (!val.IsCompleted)
						{
							num2 = -1187575041;
							num35 = num2;
						}
						else
						{
							num2 = -750842387;
							num35 = num2;
						}
						continue;
						IL_0bb4:
						eEC5A862EDC8437C = _74DD419E29E14A61((object)FB9603B015784B9C._316F91961FA14705, _48876E33D81047E6((object)obj.D70334A6F9FB43AC), _003CModule_003E._8B9C7B12B1AE4949<string>(-579210094)).GetAwaiter();
						int num36;
						if (eEC5A862EDC8437C.IsCompleted)
						{
							num2 = -20149097;
							num36 = num2;
						}
						else
						{
							num2 = 784220180;
							num36 = num2;
						}
						continue;
						IL_0f4c:
						int num37;
						if (obj._5CB5F38886F54B64.Length >= _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
						{
							num2 = -952824504;
							num37 = num2;
						}
						else
						{
							num2 = 86819829;
							num37 = num2;
						}
						continue;
						IL_08d6:
						int num38;
						if (!F528D8CFC38342FD(text, _003CModule_003E._8B9C7B12B1AE4949<string>(-482744750)))
						{
							num2 = -1101109735;
							num38 = num2;
						}
						else
						{
							num2 = -259838672;
							num38 = num2;
						}
						continue;
						IL_068d:
						int num39;
						if (c == _003CModule_003E._390073C602714496<int>(-1549669178))
						{
							num2 = 100153786;
							num39 = num2;
						}
						else
						{
							num2 = 242369252;
							num39 = num2;
						}
						continue;
						IL_0e94:
						if (!F528D8CFC38342FD(text, _003CModule_003E._58ECCB512F2A43AC<string>(2013035428)))
						{
							num2 = -118237657;
							continue;
						}
						goto IL_2559;
						IL_0aa7:
						int num40;
						if (!_46C71FA467354FFE((object)F1FEC2A81524472A, _48876E33D81047E6((object)obj2)))
						{
							num2 = -418479090;
							num40 = num2;
						}
						else
						{
							num2 = 286849122;
							num40 = num2;
						}
						continue;
						IL_0e34:
						int num41;
						if (!F528D8CFC38342FD(text, _003CModule_003E.F84FA79ABE6944BB<string>(-1910519880)))
						{
							num2 = -63380952;
							num41 = num2;
						}
						else
						{
							num2 = -257978543;
							num41 = num2;
						}
						continue;
						IL_041f:
						val2 = A9B109CB5276484A((object)obj.D70334A6F9FB43AC, _003CModule_003E._58ECCB512F2A43AC<string>(-1806000337), Color.red, (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0, _9AB67761792440A7._6142757B48FF46AD);
						val = val2.GetAwaiter();
						int num42;
						if (!val.IsCompleted)
						{
							num2 = 221376871;
							num42 = num2;
						}
						else
						{
							num2 = -855399097;
							num42 = num2;
						}
						continue;
						IL_08ae:
						int num43;
						if (!F528D8CFC38342FD(text, _003CModule_003E._58ECCB512F2A43AC<string>(-1908187862)))
						{
							num2 = 245700547;
							num43 = num2;
						}
						else
						{
							num2 = -1485903981;
							num43 = num2;
						}
					}
					goto default;
					IL_13e7:
					try
					{
						if (num != _003CModule_003E._58ECCB512F2A43AC<int>(1469793458))
						{
							goto IL_13f9;
						}
						goto IL_14ed;
						IL_13f9:
						int num44 = -676422449;
						goto IL_13fe;
						IL_13fe:
						while (true)
						{
							int num3 = num44;
							uint num4;
							switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 12)
							{
							case 11u:
								break;
							default:
								goto end_IL_13e7;
							case 10u:
								return;
							case 3u:
								goto IL_1492;
							case 5u:
								goto IL_14ed;
							case 4u:
								_29DD977FC69741BF(_8F53B32FBC024A8C, Color.white, (SteamPlayer)null, _8E525E60E3A24894, (EChatMode)_003CModule_003E.F84FA79ABE6944BB<int>(2084623923), _9AB67761792440A7._6142757B48FF46AD, (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0);
								_8E525E60E3A24894 = null;
								num44 = -959018324;
								continue;
							case 1u:
								num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(-1032555980));
								num44 = -42283660;
								continue;
							case 7u:
								EEC5A862EDC8437C = default;
								num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096));
								num44 = 394655498;
								continue;
							case 8u:
								EEC5A862EDC8437C = eEC5A862EDC8437C;
								_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _8AF6331E943144F4>(ref eEC5A862EDC8437C, ref this);
								num44 = ((int)num4 * -1378120931) ^ 0x66B17702;
								continue;
							case 2u:
								goto IL_15b5;
							case 0u:
								goto IL_15d2;
							case 9u:
								num44 = (int)((num4 * 920069399) ^ 0x43040C7);
								continue;
							case 6u:
								goto end_IL_13e7;
							}
							break;
							IL_15d2:
							int num45;
							if (!_32966CE25F4B41F7.MoveNext())
							{
								num44 = -449118098;
								num45 = num44;
							}
							else
							{
								num44 = -1420234787;
								num45 = num44;
							}
							continue;
							IL_15b5:
							int num46;
							if (eEC5A862EDC8437C.GetResult())
							{
								num44 = -1472114144;
								num46 = num44;
							}
							else
							{
								num44 = -959018324;
								num46 = num44;
							}
							continue;
							IL_1492:
							_8E525E60E3A24894 = _32966CE25F4B41F7.Current;
							eEC5A862EDC8437C = _74DD419E29E14A61((object)FB9603B015784B9C._316F91961FA14705, EFA8AE6F269E4C52(_21FF3FAF32E84647((object)_8E525E60E3A24894)), _003CModule_003E._58ECCB512F2A43AC<string>(434404517)).GetAwaiter();
							int num47;
							if (eEC5A862EDC8437C.IsCompleted)
							{
								num44 = 394655498;
								num47 = num44;
							}
							else
							{
								num44 = -1505638953;
								num47 = num44;
							}
						}
						goto IL_13f9;
						IL_14ed:
						eEC5A862EDC8437C = EEC5A862EDC8437C;
						num44 = 849633933;
						goto IL_13fe;
						end_IL_13e7:;
					}
					finally
					{
						if (num < _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
						{
							while (true)
							{
								IL_161a:
								int num48 = 788060643;
								while (true)
								{
									int num3 = num48;
									uint num4;
									switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_161f;
									case 1u:
										goto IL_1673;
									case 2u:
										goto end_IL_161f;
									}
									goto IL_161a;
									IL_1673:
									((IDisposable)_32966CE25F4B41F7/*cast due to constrained. prefix*/).Dispose();
									num48 = ((int)num4 * -1901794979) ^ -1654429659;
									continue;
									end_IL_161f:
									break;
								}
								break;
							}
						}
					}
					_32966CE25F4B41F7 = default;
					goto IL_16a1;
					IL_38b7:
					val2 = obj._637E3D758E1E4EA8();
					num49 = 509179455;
					goto IL_30ba;
					IL_1249:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num2 = 217730876;
					goto IL_00c5;
					IL_11be:
					b3985E84DB64474E = B3985E84DB64474E;
					num2 = -317208986;
					goto IL_00c5;
					IL_1136:
					val = _71B84601FF194825;
					num2 = -151144628;
					goto IL_00c5;
					IL_10ed:
					val = _71B84601FF194825;
					num2 = -429889258;
					goto IL_00c5;
					IL_1aaf:
					eEC5A862EDC8437C = _74DD419E29E14A61((object)FB9603B015784B9C._316F91961FA14705, _48876E33D81047E6((object)obj.D70334A6F9FB43AC), _003CModule_003E.F84FA79ABE6944BB<string>(727664113)).GetAwaiter();
					if (!eEC5A862EDC8437C.IsCompleted)
					{
						num50 = -1466777267;
						num51 = num50;
					}
					else
					{
						num50 = -2393623;
						num51 = num50;
					}
					goto IL_16a6;
					IL_033c:
					eEC5A862EDC8437C = EEC5A862EDC8437C;
					EEC5A862EDC8437C = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
					num2 = -20149097;
					goto IL_00c5;
					IL_02e1:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
					num2 = 836436801;
					goto IL_00c5;
					IL_16a6:
					while (true)
					{
						int num3 = num50;
						uint num4;
						switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 39)
						{
						case 24u:
							break;
						case 3u:
							_1305D1BC3BE54374 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563);
							num50 = 313866334;
							continue;
						case 37u:
							goto IL_17aa;
						case 6u:
							goto IL_17c7;
						case 0u:
							val = val2.GetAwaiter();
							num50 = (int)((num4 * 453804708) ^ 0x5A9402FB);
							continue;
						case 10u:
							return;
						case 22u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(1400898431));
							_39E83795D3354955 = val5;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val5, ref this);
							num50 = 451453666;
							continue;
						case 36u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							num50 = ((int)num4 * -1537662279) ^ -1887737970;
							continue;
						case 33u:
							return;
						case 29u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref b3985E84DB64474E, ref this);
							num50 = (int)((num4 * 1855389046) ^ 0x40AFFA3D);
							continue;
						case 5u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1993972221));
							B3985E84DB64474E = b3985E84DB64474E;
							num50 = 420930510;
							continue;
						case 35u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num50 = -1538524971;
							continue;
						case 31u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(730542174));
							_71B84601FF194825 = val;
							num50 = -1177723741;
							continue;
						case 11u:
							goto IL_1902;
						case 25u:
							b3985E84DB64474E.GetResult();
							num50 = 850595106;
							continue;
						case 38u:
							val2 = obj._242543716BDB4890(_003CModule_003E.F84FA79ABE6944BB<string>(-2016280199), Color.white);
							num50 = 135786452;
							continue;
						case 14u:
							EEC5A862EDC8437C = default;
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num50 = -2393623;
							continue;
						case 1u:
							return;
						case 32u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							num50 = (int)((num4 * 1879558173) ^ 0x327896);
							continue;
						case 15u:
						{
							int num56;
							int num57;
							if (val.IsCompleted)
							{
								num56 = -1190674182;
								num57 = num56;
							}
							else
							{
								num56 = 1993507471;
								num57 = num56;
							}
							num50 = num56 ^ (int)(num4 * 1310659553);
							continue;
						}
						case 2u:
						{
							_4CEF489E50344905 = (AA43369C3B1A47A1)_7A95747960884699((object)_442B7FBA97954791);
							val4 = UniTask.SwitchToThreadPool();
							val5 = val4.GetAwaiter();
							int num54;
							int num55;
							if (val5.IsCompleted)
							{
								num54 = -2066570184;
								num55 = num54;
							}
							else
							{
								num54 = -1395268994;
								num55 = num54;
							}
							num50 = num54 ^ (int)(num4 * 1073486647);
							continue;
						}
						case 8u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(456926511));
							EEC5A862EDC8437C = eEC5A862EDC8437C;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _8AF6331E943144F4>(ref eEC5A862EDC8437C, ref this);
							return;
						case 4u:
							goto IL_1a50;
						case 16u:
							goto IL_1aaf;
						case 34u:
							goto IL_1af4;
						case 28u:
						{
							int num52;
							int num53;
							if (!b3985E84DB64474E.IsCompleted)
							{
								num52 = 1816836492;
								num53 = num52;
							}
							else
							{
								num52 = 445208093;
								num53 = num52;
							}
							num50 = num52 ^ (int)(num4 * 1226061786);
							continue;
						}
						case 13u:
							_71B84601FF194825 = val;
							num50 = ((int)num4 * -365190438) ^ -595260077;
							continue;
						case 18u:
							return;
						case 27u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096));
							num50 = -66846034;
							continue;
						case 23u:
							b3985E84DB64474E = val3.GetAwaiter();
							num50 = ((int)num4 * -484950120) ^ 0x7D982E50;
							continue;
						case 20u:
							val.GetResult();
							cancellationToken = default;
							val3 = UniTask.SwitchToMainThread(cancellationToken);
							num50 = 213214495;
							continue;
						case 7u:
							goto end_IL_000f;
						case 19u:
							val.GetResult();
							goto end_IL_000f;
						case 9u:
							goto IL_1bf4;
						case 26u:
							_71B84601FF194825 = default;
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num50 = -943870317;
							continue;
						case 21u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(-1232977379));
							num50 = -1546867959;
							continue;
						case 17u:
							goto IL_1c5a;
						case 30u:
							goto IL_1c8c;
						default:
							goto IL_1cbe;
						}
						break;
						IL_1c5a:
						val5.GetResult();
						if (A4AF3565A9E04331((object)_4CEF489E50344905).Count > _003CModule_003E._390073C602714496<int>(2131963235))
						{
							num50 = -632607204;
							continue;
						}
						goto IL_2518;
						IL_17aa:
						int num58;
						if (!eEC5A862EDC8437C.GetResult())
						{
							num50 = 320915733;
							num58 = num50;
						}
						else
						{
							num50 = 410353980;
							num58 = num50;
						}
						continue;
						IL_1a50:
						val2 = A9B109CB5276484A((object)obj.D70334A6F9FB43AC, BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E.F84FA79ABE6944BB<string>(266054714))), Color.red, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019) != 0, (string)null);
						val = val2.GetAwaiter();
						int num59;
						if (!val.IsCompleted)
						{
							num50 = -1191788892;
							num59 = num50;
						}
						else
						{
							num50 = -943870317;
							num59 = num50;
						}
					}
					goto IL_16a1;
					IL_1cbe:
					try
					{
						int num60;
						TaskAwaiter<B0603A9963A3423A> dDC850B2C1B34E = default;
						B0603A9963A3423A result = default;
						switch (num - _003CModule_003E._58ECCB512F2A43AC<int>(81123323))
						{
						default:
							num60 = -305342099;
							goto IL_1ce6;
						case 2:
							goto IL_1e5b;
						case 3:
							goto IL_1f55;
						case 1:
							goto IL_1f66;
						case 0:
							goto IL_1fb6;
							IL_1ce6:
							while (true)
							{
								int num3 = num60;
								uint num4;
								switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 31)
								{
								case 12u:
									break;
								default:
									goto end_IL_1ccc;
								case 11u:
									return;
								case 19u:
									num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(-169746332));
									DDC850B2C1B34E86 = dDC850B2C1B34E;
									num60 = -147821580;
									continue;
								case 24u:
									_71B84601FF194825 = default;
									num60 = (int)((num4 * 534974344) ^ 0x1226ECB4);
									continue;
								case 18u:
									a40A40ADC0DD4B = DB86F69B1AEC476B(_2C5C45A7A2614D1A((object)_1A13B20F5C464EB9, A4AF3565A9E04331((object)_4CEF489E50344905).Count, _8D508894EE0F4ECD((object)result)));
									num60 = -1162543940;
									continue;
								case 23u:
									num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
									num60 = -1439788403;
									continue;
								case 13u:
									goto IL_1e5b;
								case 25u:
									val2 = obj._242543716BDB4890(_003CModule_003E.F84FA79ABE6944BB<string>(-1494236332), Color.red);
									num60 = -1269992083;
									continue;
								case 0u:
									num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-676660599));
									num60 = -1020853898;
									continue;
								case 20u:
									_71B84601FF194825 = val;
									_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
									return;
								case 28u:
								{
									int num63;
									int num64;
									if (!a40A40ADC0DD4B.IsCompleted)
									{
										num63 = -2066337403;
										num64 = num63;
									}
									else
									{
										num63 = -1902658312;
										num64 = num63;
									}
									num60 = num63 ^ ((int)num4 * -928439594);
									continue;
								}
								case 27u:
									_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter<B0603A9963A3423A>, _8AF6331E943144F4>(ref dDC850B2C1B34E, ref this);
									return;
								case 7u:
								{
									val = val2.GetAwaiter();
									int num67;
									int num68;
									if (val.IsCompleted)
									{
										num67 = 2020259684;
										num68 = num67;
									}
									else
									{
										num67 = 1871832714;
										num68 = num67;
									}
									num60 = num67 ^ (int)(num4 * 1823077927);
									continue;
								}
								case 4u:
									goto IL_1f55;
								case 8u:
									goto IL_1f66;
								case 22u:
									a40A40ADC0DD4B.GetResult();
									num60 = -1524428440;
									continue;
								case 10u:
									val.GetResult();
									num60 = -996021178;
									continue;
								case 15u:
									val.GetResult();
									num60 = -300559992;
									continue;
								case 14u:
									goto IL_1fb6;
								case 9u:
								{
									int num65;
									int num66;
									if (dDC850B2C1B34E.IsCompleted)
									{
										num65 = -1424379730;
										num66 = num65;
									}
									else
									{
										num65 = 1556776926;
										num66 = num65;
									}
									num60 = num65 ^ (int)(num4 * 271227390);
									continue;
								}
								case 5u:
									goto end_IL_000f;
								case 6u:
								{
									_02C54685DE0E4B81? obj3 = ((_1DB744298E9F4B09)DD59AE63368F420E())._0D077240941749FA;
									AA43369C3B1A47A1 aA43369C3B1A47A = _4CEF489E50344905;
									TimeSpan timeSpan = TimeSpan.FromSeconds(_003CModule_003E._390073C602714496<double>(-2136585970));
									cancellationToken = default;
									dDC850B2C1B34E = obj3._26BAEDD2B7134543<B0603A9963A3423A>(aA43369C3B1A47A, timeSpan, cancellationToken).GetAwaiter();
									num60 = 218001423;
									continue;
								}
								case 16u:
									num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-174721076));
									A40A40ADC0DD4B36 = a40A40ADC0DD4B;
									_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter, _8AF6331E943144F4>(ref a40A40ADC0DD4B, ref this);
									num60 = 411105856;
									continue;
								case 3u:
									A40A40ADC0DD4B36 = default;
									num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
									num60 = -118158728;
									continue;
								case 30u:
									goto IL_20c5;
								case 29u:
								{
									val = val2.GetAwaiter();
									int num61;
									int num62;
									if (val.IsCompleted)
									{
										num61 = 2073753931;
										num62 = num61;
									}
									else
									{
										num61 = 382752702;
										num62 = num61;
									}
									num60 = num61 ^ (int)(num4 * 40632028);
									continue;
								}
								case 2u:
									num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-1038049513));
									_71B84601FF194825 = val;
									_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
									num60 = 589872942;
									continue;
								case 26u:
									val2 = obj._242543716BDB4890(_003CModule_003E.F84FA79ABE6944BB<string>(235837480), Color.white);
									num60 = 158507783;
									continue;
								case 21u:
									num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
									num60 = -1254513337;
									continue;
								case 17u:
									return;
								case 1u:
									goto end_IL_1ccc;
								}
								break;
								IL_20c5:
								result = dDC850B2C1B34E.GetResult();
								int num69;
								if (_21480727BF2049D2((object)result))
								{
									num60 = -1456189980;
									num69 = num60;
								}
								else
								{
									num60 = -876482625;
									num69 = num60;
								}
							}
							goto default;
							IL_1fb6:
							dDC850B2C1B34E = DDC850B2C1B34E86;
							DDC850B2C1B34E86 = default;
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num60 = -995220152;
							goto IL_1ce6;
							IL_1f66:
							val = _71B84601FF194825;
							_71B84601FF194825 = default;
							num60 = 751197664;
							goto IL_1ce6;
							IL_1f55:
							val = _71B84601FF194825;
							num60 = -172633980;
							goto IL_1ce6;
							IL_1e5b:
							a40A40ADC0DD4B = A40A40ADC0DD4B36;
							num60 = 133870597;
							goto IL_1ce6;
							end_IL_1ccc:
							break;
						}
					}
					catch
					{
						_1305D1BC3BE54374 = _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
					}
					num5 = _1305D1BC3BE54374;
					goto IL_21c4;
					IL_37d3:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096));
					num49 = 437178217;
					goto IL_30ba;
					IL_1c8c:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
					num50 = 246173499;
					goto IL_16a6;
					IL_1bf4:
					val5 = _39E83795D3354955;
					_39E83795D3354955 = default;
					num50 = 407192752;
					goto IL_16a6;
					IL_1af4:
					b3985E84DB64474E = B3985E84DB64474E;
					B3985E84DB64474E = default;
					num50 = -678371728;
					goto IL_16a6;
					IL_1902:
					eEC5A862EDC8437C = EEC5A862EDC8437C;
					num50 = 742643070;
					goto IL_16a6;
					IL_17c7:
					val = _71B84601FF194825;
					num50 = -292326465;
					goto IL_16a6;
					IL_16a1:
					num50 = 772223654;
					goto IL_16a6;
					IL_0fdf:
					val = _71B84601FF194825;
					num2 = -1111169386;
					goto IL_00c5;
					IL_2559:
					eEC5A862EDC8437C = _74DD419E29E14A61((object)FB9603B015784B9C._316F91961FA14705, _48876E33D81047E6((object)obj.D70334A6F9FB43AC), _003CModule_003E.F84FA79ABE6944BB<string>(593939136)).GetAwaiter();
					num70 = -949081337;
					goto IL_21c9;
					IL_21c9:
					while (true)
					{
						int num3 = num70;
						uint num4;
						switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 45)
						{
						case 0u:
							break;
						case 19u:
							val.GetResult();
							goto end_IL_000f;
						case 40u:
							val = val2.GetAwaiter();
							num70 = (int)(num4 * 1982312184) ^ -1958869231;
							continue;
						case 21u:
							goto end_IL_000f;
						case 6u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-850865924));
							EEC5A862EDC8437C = eEC5A862EDC8437C;
							num70 = -673441420;
							continue;
						case 10u:
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num70 = 15343377;
							continue;
						case 33u:
							val.GetResult();
							num70 = 189356355;
							continue;
						case 8u:
							goto IL_2367;
						case 39u:
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-1776148968));
							num70 = -859951247;
							continue;
						case 5u:
							return;
						case 15u:
							_71B84601FF194825 = default;
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
							num70 = 755125855;
							continue;
						case 35u:
							val = val2.GetAwaiter();
							num70 = ((int)num4 * -1310483873) ^ 0x64C974E0;
							continue;
						case 11u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
							num70 = 340753489;
							continue;
						case 18u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 31u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							num70 = ((int)num4 * -1179943537) ^ -1694206583;
							continue;
						case 3u:
							val2 = A9B109CB5276484A((object)obj.D70334A6F9FB43AC, BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E._3F57E81A62734AC2<string>(-289862619))), Color.red, (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0, (string)null);
							num70 = 119092691;
							continue;
						case 28u:
							cancellationToken = default;
							num70 = -771833017;
							continue;
						case 13u:
							if (num5 == _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
							{
								num70 = -47690129;
								continue;
							}
							goto end_IL_000f;
						case 20u:
							val.GetResult();
							goto end_IL_000f;
						case 43u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(-1675443465));
							_71B84601FF194825 = val;
							num70 = 544274590;
							continue;
						case 24u:
							goto IL_2506;
						case 41u:
							goto IL_2518;
						case 2u:
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-1612209474));
							num70 = 838341307;
							continue;
						case 12u:
							goto IL_2559;
						case 32u:
							return;
						case 30u:
							_71B84601FF194825 = val;
							num70 = (int)((num4 * 1713920980) ^ 0x7463307E);
							continue;
						case 4u:
							goto IL_25bd;
						case 17u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(162944472));
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 7u:
							goto IL_2612;
						case 9u:
							val2 = obj._242543716BDB4890(_003CModule_003E._58ECCB512F2A43AC<string>(432345335), Color.red);
							val = val2.GetAwaiter();
							num70 = 472285836;
							continue;
						case 29u:
						{
							int num79;
							int num80;
							if (val.IsCompleted)
							{
								num79 = 1626266174;
								num80 = num79;
							}
							else
							{
								num79 = -1237315482;
								num80 = num79;
							}
							num70 = num79 ^ (int)(num4 * 754289874);
							continue;
						}
						case 14u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref b3985E84DB64474E, ref this);
							num70 = ((int)num4 * -1035580978) ^ -1310329851;
							continue;
						case 37u:
						{
							val3 = UniTask.SwitchToMainThread(cancellationToken);
							b3985E84DB64474E = val3.GetAwaiter();
							int num77;
							int num78;
							if (b3985E84DB64474E.IsCompleted)
							{
								num77 = 1095362501;
								num78 = num77;
							}
							else
							{
								num77 = 1330026992;
								num78 = num77;
							}
							num70 = num77 ^ (int)(num4 * 374584644);
							continue;
						}
						case 16u:
							_71B84601FF194825 = default;
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num70 = 760631;
							continue;
						case 36u:
							goto IL_2717;
						case 1u:
						{
							int num75;
							int num76;
							if (!eEC5A862EDC8437C.IsCompleted)
							{
								num75 = 1810848437;
								num76 = num75;
							}
							else
							{
								num75 = 1246977417;
								num76 = num75;
							}
							num70 = num75 ^ ((int)num4 * -529908168);
							continue;
						}
						case 38u:
							goto IL_274e;
						case 26u:
						{
							int num73;
							int num74;
							if (!val.IsCompleted)
							{
								num73 = 829563688;
								num74 = num73;
							}
							else
							{
								num73 = 728242638;
								num74 = num73;
							}
							num70 = num73 ^ ((int)num4 * -269046811);
							continue;
						}
						case 22u:
							B3985E84DB64474E = b3985E84DB64474E;
							num70 = ((int)num4 * -590239508) ^ 0x2EFB3BF3;
							continue;
						case 44u:
							B3985E84DB64474E = default;
							num70 = (int)(num4 * 279428829) ^ -831794573;
							continue;
						case 27u:
							b3985E84DB64474E.GetResult();
							_353C93F6D73341B7 = new List<string>();
							num70 = 61342057;
							continue;
						case 34u:
							return;
						case 25u:
						{
							int num71;
							int num72;
							if (!val.IsCompleted)
							{
								num71 = -1915229512;
								num72 = num71;
							}
							else
							{
								num71 = 376259109;
								num72 = num71;
							}
							num70 = num71 ^ (int)(num4 * 798814638);
							continue;
						}
						case 42u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _8AF6331E943144F4>(ref eEC5A862EDC8437C, ref this);
							num70 = (int)((num4 * 935809663) ^ 0x7C2D36A);
							continue;
						default:
							goto IL_2847;
						}
						break;
						IL_25bd:
						int num81;
						if (eEC5A862EDC8437C.GetResult())
						{
							num70 = 365129391;
							num81 = num70;
						}
						else
						{
							num70 = -812187167;
							num81 = num70;
						}
					}
					goto IL_21c4;
					IL_2847:
					enumerator = _3402CEAD12774C3C((object)_951F97102D064735).GetEnumerator();
					try
					{
						A19CBF069C964833._40FE7AC3F69F4B10 current = default;
						while (true)
						{
							IL_28be:
							int num82;
							int num83;
							if (enumerator.MoveNext())
							{
								num82 = -232073668;
								num83 = num82;
							}
							else
							{
								num82 = -1019777989;
								num83 = num82;
							}
							while (true)
							{
								int num3 = num82;
								uint num4;
								switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 5)
								{
								case 3u:
									num82 = -232073668;
									continue;
								default:
									goto end_IL_285f;
								case 4u:
									break;
								case 2u:
								{
									List<float> list = _2AE76733FC7C4318((object)current, _003CModule_003E._390073C602714496<int>(1361124781));
									List<string> list2 = _353C93F6D73341B7;
									string[] array = new string[_003CModule_003E._58ECCB512F2A43AC<int>(730542174)];
									array[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)] = current.E02D926C06FA47EE;
									array[_003CModule_003E.F84FA79ABE6944BB<int>(1741630884)] = _003CModule_003E._3F57E81A62734AC2<string>(1508292859);
									array[_003CModule_003E._3F57E81A62734AC2<int>(-845933485)] = obj._8CE2BF0C517D4102(C43E175F75614A60((object)current));
									array[_003CModule_003E.F84FA79ABE6944BB<int>(-1420849552)] = _003CModule_003E.F84FA79ABE6944BB<string>(-1196569144);
									array[_003CModule_003E._8B9C7B12B1AE4949<int>(1358231899)] = obj._8CE2BF0C517D4102((list.Count == 0) ? _003CModule_003E.F84FA79ABE6944BB<float>(1398637845) : _95C4856916E94383((IEnumerable<float>)list));
									array[_003CModule_003E._3F57E81A62734AC2<int>(-1993266263)] = _003CModule_003E.F84FA79ABE6944BB<string>(-1882555222);
									array[_003CModule_003E._3F57E81A62734AC2<int>(887139723)] = obj._8CE2BF0C517D4102((list.Count == 0) ? _003CModule_003E._8B9C7B12B1AE4949<float>(-658048563) : _54AEFB29825643AD((IEnumerable<float>)list));
									array[_003CModule_003E.F84FA79ABE6944BB<int>(518492322)] = _003CModule_003E._3F57E81A62734AC2<string>(354060629);
									array[_003CModule_003E._58ECCB512F2A43AC<int>(1098108634)] = obj._8CE2BF0C517D4102((list.Count == 0) ? _003CModule_003E.F84FA79ABE6944BB<float>(1398637845) : _6EDD029392514E22((IEnumerable<float>)list));
									array[_003CModule_003E.F84FA79ABE6944BB<int>(-1181364256)] = _003CModule_003E._58ECCB512F2A43AC<string>(-1987724385);
									array[_003CModule_003E._8B9C7B12B1AE4949<int>(-1623702770)] = obj._8CE2BF0C517D4102((current._37B22362350945A6.DE13140484C148CD == 0) ? _003CModule_003E._390073C602714496<float>(2131963235) : _95C4856916E94383((IEnumerable<float>)current._37B22362350945A6));
									array[_003CModule_003E._58ECCB512F2A43AC<int>(2125389855)] = _003CModule_003E.F84FA79ABE6944BB<string>(-1882555222);
									array[_003CModule_003E._8B9C7B12B1AE4949<int>(1786579299)] = obj._8CE2BF0C517D4102((current._37B22362350945A6.DE13140484C148CD == 0) ? _003CModule_003E._58ECCB512F2A43AC<float>(352679804) : _54AEFB29825643AD((IEnumerable<float>)current._37B22362350945A6));
									array[_003CModule_003E._390073C602714496<int>(1074607096)] = _003CModule_003E.F84FA79ABE6944BB<string>(-1882555222);
									array[_003CModule_003E._58ECCB512F2A43AC<int>(-1783478343)] = obj._8CE2BF0C517D4102((current._37B22362350945A6.DE13140484C148CD == 0) ? _003CModule_003E._390073C602714496<float>(2131963235) : _6EDD029392514E22((IEnumerable<float>)current._37B22362350945A6));
									list2.Add(A9B48B97C5D0494F(array));
									num82 = -843941295;
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num82 = 126607797;
									continue;
								case 0u:
									goto end_IL_285f;
								}
								goto IL_28be;
								continue;
								end_IL_285f:
								break;
							}
							break;
						}
					}
					finally
					{
						if (num < _003CModule_003E._390073C602714496<int>(2131963235))
						{
							while (true)
							{
								IL_2b6f:
								int num84 = -238375176;
								while (true)
								{
									int num3 = num84;
									uint num4;
									switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_2b74;
									case 2u:
										goto IL_2bc8;
									case 1u:
										goto end_IL_2b74;
									}
									goto IL_2b6f;
									IL_2bc8:
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
									num84 = ((int)num4 * -670438241) ^ -896091872;
									continue;
									end_IL_2b74:
									break;
								}
								break;
							}
						}
					}
					val4 = UniTask.SwitchToThreadPool();
					val5 = val4.GetAwaiter();
					if (!val5.IsCompleted)
					{
						goto IL_2c02;
					}
					goto IL_2da8;
					IL_352a:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num49 = -995485397;
					goto IL_30ba;
					IL_2da8:
					val5.GetResult();
					num85 = -1140314957;
					goto IL_2c07;
					IL_2c07:
					while (true)
					{
						int num3 = num85;
						uint num4;
						switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 15)
						{
						case 14u:
							break;
						case 0u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							num85 = (int)(num4 * 169462903) ^ -1283857708;
							continue;
						case 13u:
						{
							val = val2.GetAwaiter();
							int num86;
							int num87;
							if (val.IsCompleted)
							{
								num86 = -2028722746;
								num87 = num86;
							}
							else
							{
								num86 = -430194563;
								num87 = num86;
							}
							num85 = num86 ^ ((int)num4 * -880542542);
							continue;
						}
						case 4u:
							return;
						case 6u:
							return;
						case 1u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(1561685073));
							_39E83795D3354955 = val5;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val5, ref this);
							num85 = 195621302;
							continue;
						case 7u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num85 = -901104252;
							continue;
						case 12u:
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(170655810));
							_71B84601FF194825 = val;
							num85 = -41302272;
							continue;
						case 8u:
							val2 = obj._242543716BDB4890(_003CModule_003E._8B9C7B12B1AE4949<string>(981733308), Color.white);
							num85 = 836053779;
							continue;
						case 3u:
							goto IL_2da8;
						case 11u:
							goto IL_2db9;
						case 10u:
							val.GetResult();
							_4F0E9D79B97C47B9 = _353C93F6D73341B7.GetEnumerator();
							num85 = -1172044467;
							continue;
						case 9u:
							goto IL_2dec;
						case 2u:
							_71B84601FF194825 = default;
							num85 = (int)(num4 * 1367712095) ^ -261397689;
							continue;
						default:
							goto IL_2e3e;
						}
						break;
					}
					goto IL_2c02;
					IL_2e3e:
					try
					{
						if (num != _003CModule_003E._8B9C7B12B1AE4949<int>(-878969678))
						{
							goto IL_2e50;
						}
						goto IL_3009;
						IL_2e50:
						int num88 = -1209623984;
						goto IL_2e55;
						IL_2e55:
						string current2 = default;
						while (true)
						{
							int num3 = num88;
							uint num4;
							switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 13)
							{
							case 9u:
								break;
							default:
								goto end_IL_2e3e;
							case 5u:
								num88 = ((int)num4 * -289421473) ^ -1039549919;
								continue;
							case 12u:
								num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-1799951799));
								_71B84601FF194825 = val;
								_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
								num88 = 191231126;
								continue;
							case 8u:
								num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096));
								num88 = 736504312;
								continue;
							case 6u:
							{
								val = val2.GetAwaiter();
								int num89;
								int num90;
								if (val.IsCompleted)
								{
									num89 = -1775859747;
									num90 = num89;
								}
								else
								{
									num89 = 1222641067;
									num90 = num89;
								}
								num88 = num89 ^ ((int)num4 * -142261513);
								continue;
							}
							case 11u:
								val.GetResult();
								num88 = 346722837;
								continue;
							case 0u:
								goto IL_2f78;
							case 7u:
								val2 = obj._242543716BDB4890(current2, Color.white);
								num88 = ((int)num4 * -1091717946) ^ -1371349771;
								continue;
							case 4u:
								_71B84601FF194825 = default;
								num88 = ((int)num4 * -851716471) ^ 0x4EA5EB6D;
								continue;
							case 10u:
								current2 = _4F0E9D79B97C47B9.Current;
								num88 = -541889638;
								continue;
							case 2u:
								return;
							case 1u:
								goto IL_3009;
							case 3u:
								goto end_IL_2e3e;
							}
							break;
							IL_2f78:
							int num91;
							if (!_4F0E9D79B97C47B9.MoveNext())
							{
								num88 = -726605138;
								num91 = num88;
							}
							else
							{
								num88 = -573257475;
								num91 = num88;
							}
						}
						goto IL_2e50;
						IL_3009:
						val = _71B84601FF194825;
						num88 = -65103216;
						goto IL_2e55;
						end_IL_2e3e:;
					}
					finally
					{
						if (num < _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
						{
							while (true)
							{
								IL_302e:
								int num92 = -1125264323;
								while (true)
								{
									int num3 = num92;
									uint num4;
									switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 3)
									{
									case 2u:
										break;
									default:
										goto end_IL_3033;
									case 1u:
										goto IL_3087;
									case 0u:
										goto end_IL_3033;
									}
									goto IL_302e;
									IL_3087:
									((IDisposable)_4F0E9D79B97C47B9/*cast due to constrained. prefix*/).Dispose();
									num92 = (int)((num4 * 218137066) ^ 0x4309BD54);
									continue;
									end_IL_3033:
									break;
								}
								break;
							}
						}
					}
					_4F0E9D79B97C47B9 = default;
					goto IL_30b5;
					IL_34ee:
					val = _71B84601FF194825;
					num49 = -332458223;
					goto IL_30ba;
					IL_2dec:
					val5 = _39E83795D3354955;
					_39E83795D3354955 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
					num85 = 144160250;
					goto IL_2c07;
					IL_2db9:
					val = _71B84601FF194825;
					num85 = -345788098;
					goto IL_2c07;
					IL_2c02:
					num85 = -1331684980;
					goto IL_2c07;
					IL_274e:
					eEC5A862EDC8437C = EEC5A862EDC8437C;
					EEC5A862EDC8437C = default;
					num70 = 132375878;
					goto IL_21c9;
					IL_2717:
					val = _71B84601FF194825;
					num70 = 310890138;
					goto IL_21c9;
					IL_2612:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
					num70 = 261692958;
					goto IL_21c9;
					IL_2518:
					val2 = obj._242543716BDB4890(_003CModule_003E._58ECCB512F2A43AC<string>(1365675759), Color.white);
					num70 = -288252036;
					goto IL_21c9;
					IL_2506:
					b3985E84DB64474E = B3985E84DB64474E;
					num70 = -875899164;
					goto IL_21c9;
					IL_2367:
					val = _71B84601FF194825;
					num70 = -47221174;
					goto IL_21c9;
					IL_21c4:
					num70 = -968630757;
					goto IL_21c9;
					IL_0d54:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
					num2 = -855399097;
					goto IL_00c5;
					IL_0b59:
					val = _71B84601FF194825;
					num2 = -731021032;
					goto IL_00c5;
					IL_0ace:
					eEC5A862EDC8437C = EEC5A862EDC8437C;
					EEC5A862EDC8437C = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
					num2 = -345418977;
					goto IL_00c5;
					IL_0979:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096));
					num2 = -28644449;
					goto IL_00c5;
					IL_345b:
					eEC5A862EDC8437C = _74DD419E29E14A61((object)FB9603B015784B9C._316F91961FA14705, _48876E33D81047E6((object)obj.D70334A6F9FB43AC), _003CModule_003E._58ECCB512F2A43AC<string>(-866492367)).GetAwaiter();
					if (!eEC5A862EDC8437C.IsCompleted)
					{
						num49 = -1180382031;
						num93 = num49;
					}
					else
					{
						num49 = 594114200;
						num93 = num49;
					}
					goto IL_30ba;
					IL_30b5:
					num49 = -1117609939;
					goto IL_30ba;
					IL_0716:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num2 = -794084475;
					goto IL_00c5;
					IL_30ba:
					while (true)
					{
						int num3 = num49;
						uint num4;
						float num94;
						float num105;
						switch ((num4 = (uint)((~(~num3 - (--1701240130 ^ -1994912695)) ^ (-(~(--213757778)) * -479529643)) - 801227161 * -(~1913491449) + -335495198)) % 104)
						{
						case 63u:
							break;
						default:
							goto end_IL_000f;
						case 68u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(-1991541400));
							num49 = 740426236;
							continue;
						case 88u:
							goto IL_32c4;
						case 5u:
							val = val2.GetAwaiter();
							num49 = (int)((num4 * 1220362423) ^ 0xDB3C698);
							continue;
						case 62u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(788199270));
							B3985E84DB64474E = b3985E84DB64474E;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref b3985E84DB64474E, ref this);
							return;
						case 44u:
							EEC5A862EDC8437C = eEC5A862EDC8437C;
							num49 = ((int)num4 * -264968501) ^ -1817687771;
							continue;
						case 72u:
							goto IL_3380;
						case 98u:
							B3985E84DB64474E = default;
							num49 = ((int)num4 * -241710486) ^ -1746743239;
							continue;
						case 60u:
							goto IL_33c2;
						case 22u:
						{
							int num108;
							int num109;
							if (!_18B15859E37B4D6B((Object)DCEA54BFA6294707((object)_8E525E60E3A24894), (Object)null))
							{
								num108 = 111320744;
								num109 = num108;
							}
							else
							{
								num108 = -94449863;
								num109 = num108;
							}
							num49 = num108 ^ (int)(num4 * 1935083080);
							continue;
						}
						case 67u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(-1693727858));
							EEC5A862EDC8437C = eEC5A862EDC8437C;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _8AF6331E943144F4>(ref eEC5A862EDC8437C, ref this);
							return;
						case 80u:
							goto IL_345b;
						case 21u:
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							num49 = (int)(num4 * 1046310003) ^ -82885254;
							continue;
						case 19u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _8AF6331E943144F4>(ref eEC5A862EDC8437C, ref this);
							return;
						case 94u:
							goto IL_34ee;
						case 76u:
							val2 = obj._242543716BDB4890(_003CModule_003E._58ECCB512F2A43AC<string>(-780778298), Color.red);
							val = val2.GetAwaiter();
							num49 = -1125821806;
							continue;
						case 29u:
							goto IL_352a;
						case 37u:
							B3985E84DB64474E = b3985E84DB64474E;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref b3985E84DB64474E, ref this);
							num49 = (int)(num4 * 748835603) ^ -505509526;
							continue;
						case 61u:
							val.GetResult();
							num49 = 327262789;
							continue;
						case 43u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num49 = -466486486;
							continue;
						case 84u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1577688673));
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 18u:
						{
							int num112;
							int num113;
							if (b3985E84DB64474E.IsCompleted)
							{
								num112 = -1586875520;
								num113 = num112;
							}
							else
							{
								num112 = -1709201890;
								num113 = num112;
							}
							num49 = num112 ^ (int)(num4 * 1977074156);
							continue;
						}
						case 54u:
							return;
						case 74u:
						{
							int num103;
							int num104;
							if (val.IsCompleted)
							{
								num103 = -1814593131;
								num104 = num103;
							}
							else
							{
								num103 = 1793369434;
								num104 = num103;
							}
							num49 = num103 ^ (int)(num4 * 422245902);
							continue;
						}
						case 47u:
							goto end_IL_000f;
						case 100u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(440696661));
							_39E83795D3354955 = val5;
							num49 = 148191291;
							continue;
						case 42u:
							goto IL_3679;
						case 17u:
							goto IL_3696;
						case 45u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-1867133230));
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 65u:
						{
							val = val2.GetAwaiter();
							int num97;
							int num98;
							if (!val.IsCompleted)
							{
								num97 = 1292223259;
								num98 = num97;
							}
							else
							{
								num97 = -906169113;
								num98 = num97;
							}
							num49 = num97 ^ (int)(num4 * 1587204307);
							continue;
						}
						case 48u:
							val.GetResult();
							num49 = -153603071;
							continue;
						case 28u:
							goto IL_377a;
						case 38u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(-439448862));
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 2u:
							goto IL_37d3;
						case 69u:
						{
							int num116;
							int num117;
							if (val.IsCompleted)
							{
								num116 = 2033618951;
								num117 = num116;
							}
							else
							{
								num116 = -244026991;
								num117 = num116;
							}
							num49 = num116 ^ (int)(num4 * 1694233823);
							continue;
						}
						case 79u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(2086876499));
							num49 = -1267678690;
							continue;
						case 93u:
						{
							int num114;
							int num115;
							if (_18B15859E37B4D6B((Object)DCEA54BFA6294707((object)val6), (Object)null))
							{
								num114 = -1680881854;
								num115 = num114;
							}
							else
							{
								num114 = -2138976397;
								num115 = num114;
							}
							num49 = num114 ^ ((int)num4 * -705787962);
							continue;
						}
						case 86u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(826317558));
							num49 = -761819425;
							continue;
						case 82u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-1047045893));
							_71B84601FF194825 = val;
							num49 = 365175340;
							continue;
						case 20u:
							goto IL_38b7;
						case 64u:
							goto IL_38c9;
						case 85u:
						{
							val = val2.GetAwaiter();
							int num110;
							int num111;
							if (!val.IsCompleted)
							{
								num110 = 38837984;
								num111 = num110;
							}
							else
							{
								num110 = -1039285572;
								num111 = num110;
							}
							num49 = num110 ^ (int)(num4 * 1804304944);
							continue;
						}
						case 81u:
							goto IL_3915;
						case 33u:
							goto IL_3943;
						case 9u:
						{
							int num106;
							int num107;
							if (!val.IsCompleted)
							{
								num106 = 1011059853;
								num107 = num106;
							}
							else
							{
								num106 = 244653448;
								num107 = num106;
							}
							num49 = num106 ^ ((int)num4 * -357907358);
							continue;
						}
						case 58u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
							num49 = 594114200;
							continue;
						case 26u:
							num94 = (float)(BFF3185EDDB1428E._849CF3D1826A4684 / BFF3185EDDB1428E._8985A39E28C04E36) * _003CModule_003E._3F57E81A62734AC2<float>(-397719571);
							goto IL_39e4;
						case 77u:
						{
							int num101;
							int num102;
							if (!eEC5A862EDC8437C.IsCompleted)
							{
								num101 = -1950483580;
								num102 = num101;
							}
							else
							{
								num101 = 357788050;
								num102 = num101;
							}
							num49 = num101 ^ ((int)num4 * -220246320);
							continue;
						}
						case 56u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1204478400));
							num49 = 775766936;
							continue;
						case 71u:
							return;
						case 8u:
						{
							int num99;
							int num100;
							if (!val.IsCompleted)
							{
								num99 = 68285013;
								num100 = num99;
							}
							else
							{
								num99 = 2095967391;
								num100 = num99;
							}
							num49 = num99 ^ ((int)num4 * -14299549);
							continue;
						}
						case 1u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val5, ref this);
							return;
						case 55u:
							return;
						case 99u:
							val2 = obj._242543716BDB4890(BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E._3F57E81A62734AC2<string>(-286412893))), Color.red);
							val = val2.GetAwaiter();
							num49 = -439661588;
							continue;
						case 36u:
							goto IL_3b2f;
						case 3u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(119951387));
							A40A40ADC0DD4B36 = a40A40ADC0DD4B;
							num49 = -602041214;
							continue;
						case 66u:
							goto end_IL_000f;
						case 4u:
							goto IL_3bbb;
						case 96u:
							val.GetResult();
							goto end_IL_000f;
						case 16u:
							goto end_IL_000f;
						case 49u:
							num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
							num49 = -1478941772;
							continue;
						case 41u:
							goto IL_3c24;
						case 24u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 51u:
							_71B84601FF194825 = default;
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
							num49 = -1205076401;
							continue;
						case 95u:
							goto IL_3ca5;
						case 91u:
							val.GetResult();
							goto end_IL_000f;
						case 6u:
						{
							object obj5 = _86B99FA26B604A23();
							((C7A753824C0746AE._359F714CB1DB4E96)obj5).F74B17DBDC224CFC = _003CModule_003E._390073C602714496<float>(1416032329);
							BFF3185EDDB1428E = (C7A753824C0746AE._359F714CB1DB4E96)obj5;
							F73B4C212C0D4004((object)_3C79809DB22A48D9).TryAdd(EFA8AE6F269E4C52(_21FF3FAF32E84647((object)_8E525E60E3A24894)), BFF3185EDDB1428E);
							num49 = 860338331;
							continue;
						}
						case 40u:
							val.GetResult();
							num49 = -1271726662;
							continue;
						case 27u:
							goto IL_3d47;
						case 25u:
							goto IL_3d78;
						case 103u:
							val2 = A9B109CB5276484A((object)obj.D70334A6F9FB43AC, BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E.F84FA79ABE6944BB<string>(266054714))), Color.red, (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0, (string)null);
							num49 = -63649701;
							continue;
						case 73u:
							goto IL_3dee;
						case 70u:
						{
							b3985E84DB64474E = val3.GetAwaiter();
							int num95;
							int num96;
							if (b3985E84DB64474E.IsCompleted)
							{
								num95 = 300009431;
								num96 = num95;
							}
							else
							{
								num95 = 588773794;
								num96 = num95;
							}
							num49 = num95 ^ ((int)num4 * -962816582);
							continue;
						}
						case 32u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							return;
						case 34u:
						{
							ItemJar val7 = (ItemJar)C55019FCC8F14824(E13A18739BA44234((object)BF8153357FCA495D), ABC38FEDDCBA4AA4(_7F27B8A5B4DC47F3((object)BF8153357FCA495D)), b);
							D3BF50B51FF74331(E13A18739BA44234(_51F622F0D342406C((object)obj.D70334A6F9FB43AC)), _113547498C884B4A(_948D4A771E474FE6(_8792062CACF741F7((object)val7)), ((Item)_8792062CACF741F7((object)val7)).amount, ((Item)_8792062CACF741F7((object)val7)).quality, ((Item)_8792062CACF741F7((object)val7)).state), (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0);
							num49 = -153603071;
							continue;
						}
						case 52u:
							cancellationToken = default;
							num49 = -1420060144;
							continue;
						case 75u:
							if (BFF3185EDDB1428E._849CF3D1826A4684 == 0)
							{
								num94 = _003CModule_003E._8B9C7B12B1AE4949<float>(-658048563);
								goto IL_39e4;
							}
							num49 = 143616762;
							continue;
						case 11u:
						{
							F73B4C212C0D4004((object)_3C79809DB22A48D9).TryRemove(EFA8AE6F269E4C52(_21FF3FAF32E84647((object)_8E525E60E3A24894)), out C7A753824C0746AE._359F714CB1DB4E96 _);
							num49 = ((int)num4 * -1683026667) ^ -961820594;
							continue;
						}
						case 39u:
							num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num49 = -492775528;
							continue;
						case 10u:
							val2 = A9B109CB5276484A((object)obj.D70334A6F9FB43AC, BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E.F84FA79ABE6944BB<string>(266054714))), Color.red, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019) != 0, (string)null);
							val = val2.GetAwaiter();
							num49 = 428489391;
							continue;
						case 59u:
							goto IL_3fc4;
						case 50u:
							val.GetResult();
							num49 = -1107035672;
							continue;
						case 102u:
							_71B84601FF194825 = val;
							_116FC2362C114D51.AwaitUnsafeOnCompleted<Awaiter, _8AF6331E943144F4>(ref val, ref this);
							num49 = ((int)num4 * -1554724158) ^ -1943314053;
							continue;
						case 13u:
							goto IL_402f;
						case 90u:
							_116FC2362C114D51.AwaitUnsafeOnCompleted<TaskAwaiter, _8AF6331E943144F4>(ref a40A40ADC0DD4B, ref this);
							num49 = (int)((num4 * 1510939552) ^ 0x641EBB3E);
							continue;
						case 53u:
							return;
						case 15u:
							goto IL_4092;
						case 101u:
							goto IL_40d3;
						case 46u:
							goto IL_40f1;
						case 14u:
							goto IL_410e;
						case 78u:
							num = (_213BA1D9C27145CC = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num49 = -150432743;
							continue;
						case 12u:
							num49 = ((int)num4 * -300425279) ^ -1191125003;
							continue;
						case 97u:
							num = (_213BA1D9C27145CC = _003CModule_003E.F84FA79ABE6944BB<int>(-1254654765));
							num49 = -872116457;
							continue;
						case 7u:
							BF8153357FCA495D = (Player)DCEA54BFA6294707((object)val6);
							cancellationToken = default;
							val3 = UniTask.SwitchToMainThread(cancellationToken);
							num49 = 293049246;
							continue;
						case 89u:
							goto IL_4197;
						case 57u:
							goto IL_41c4;
						case 92u:
							val3 = UniTask.SwitchToMainThread(cancellationToken);
							b3985E84DB64474E = val3.GetAwaiter();
							num49 = (int)((num4 * 1780361705) ^ 0xAFE75C6);
							continue;
						case 30u:
							goto IL_421b;
						case 23u:
							num49 = (int)(num4 * 942157696) ^ -1230926719;
							continue;
						case 87u:
							num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096));
							num49 = -255866085;
							continue;
						case 0u:
							_71B84601FF194825 = val;
							num49 = (int)(num4 * 209781171) ^ -505368668;
							continue;
						case 35u:
							val.GetResult();
							num49 = 526705695;
							continue;
						case 31u:
							goto IL_4294;
						case 83u:
							goto end_IL_000f;
							IL_39e4:
							num105 = num94;
							val2 = obj._242543716BDB4890(ABC4AC51DF474E9D(_003CModule_003E._8B9C7B12B1AE4949<string>(235999449), (object)BFF3185EDDB1428E._849CF3D1826A4684, (object)BFF3185EDDB1428E._8985A39E28C04E36, (object)num105), Color.white);
							num49 = -758202233;
							continue;
						}
						break;
						IL_4294:
						int num118;
						if (_439943FCB7A54480(obj._5CB5F38886F54B64[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)], ref _8E525E60E3A24894))
						{
							num49 = -1167587522;
							num118 = num49;
						}
						else
						{
							num49 = -89771447;
							num118 = num49;
						}
						continue;
						IL_3bbb:
						int num119;
						if (!eEC5A862EDC8437C.GetResult())
						{
							num49 = -589256422;
							num119 = num49;
						}
						else
						{
							num49 = -937254165;
							num119 = num49;
						}
						continue;
						IL_32c4:
						val2 = obj._242543716BDB4890(BAD4CAA028BA4C07((LocalizedString)_7CF890F5AC024C2C((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E._390073C602714496<string>(-2097615856))), Color.red);
						val = val2.GetAwaiter();
						int num120;
						if (val.IsCompleted)
						{
							num49 = 437178217;
							num120 = num49;
						}
						else
						{
							num49 = -551553429;
							num120 = num49;
						}
						continue;
						IL_4197:
						val4 = UniTask.SwitchToThreadPool();
						val5 = val4.GetAwaiter();
						int num121;
						if (val5.IsCompleted)
						{
							num49 = -227020179;
							num121 = num49;
						}
						else
						{
							num49 = -629006808;
							num121 = num49;
						}
						continue;
						IL_33c2:
						int num122;
						if (_439943FCB7A54480(obj._5CB5F38886F54B64[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)], ref val6))
						{
							num49 = 594805039;
							num122 = num49;
						}
						else
						{
							num49 = 394003596;
							num122 = num49;
						}
						continue;
						IL_3b2f:
						b3985E84DB64474E.GetResult();
						_829C2E5021804851 = F73B4C212C0D4004((object)_3C79809DB22A48D9).TryGetValue(EFA8AE6F269E4C52(_21FF3FAF32E84647((object)_8E525E60E3A24894)), out BFF3185EDDB1428E);
						int num123;
						if (_829C2E5021804851)
						{
							num49 = 860338331;
							num123 = num49;
						}
						else
						{
							num49 = -957302538;
							num123 = num49;
						}
						continue;
						IL_4092:
						val5.GetResult();
						a40A40ADC0DD4B = DB86F69B1AEC476B(_92C62BA4151F472E(TimeSpan.FromSeconds(_003CModule_003E._8B9C7B12B1AE4949<double>(1702608018))));
						int num124;
						if (a40A40ADC0DD4B.IsCompleted)
						{
							num49 = -833957948;
							num124 = num49;
						}
						else
						{
							num49 = -820693759;
							num124 = num49;
						}
						continue;
						IL_377a:
						int num125;
						if (obj.D70334A6F9FB43AC is _2E54684D829B4208)
						{
							num49 = 526705695;
							num125 = num49;
						}
						else
						{
							num49 = -672685864;
							num125 = num49;
						}
						continue;
						IL_3679:
						int num126;
						if (eEC5A862EDC8437C.GetResult())
						{
							num49 = -879097632;
							num126 = num49;
						}
						else
						{
							num49 = 273696229;
							num126 = num49;
						}
						continue;
						IL_402f:
						int num127;
						if (obj._5CB5F38886F54B64.Length <= _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
						{
							num49 = 394003596;
							num127 = num49;
						}
						else
						{
							num49 = -1215664893;
							num127 = num49;
						}
						continue;
						IL_3943:
						int num128;
						if (obj._5CB5F38886F54B64.Length > _003CModule_003E._8B9C7B12B1AE4949<int>(350091668))
						{
							num49 = -1097893883;
							num128 = num49;
						}
						else
						{
							num49 = -89771447;
							num128 = num49;
						}
						continue;
						IL_3380:
						a40A40ADC0DD4B.GetResult();
						int num129;
						if (!_829C2E5021804851)
						{
							num49 = -705042543;
							num129 = num49;
						}
						else
						{
							num49 = 115597353;
							num129 = num49;
						}
						continue;
						IL_3ca5:
						int num130;
						if (!AE7EF1D1F4FD421A(obj._5CB5F38886F54B64[_003CModule_003E._3F57E81A62734AC2<int>(1017304263)]))
						{
							num49 = 345850221;
							num130 = num49;
						}
						else
						{
							num49 = -89771447;
							num130 = num49;
						}
						continue;
						IL_3696:
						b3985E84DB64474E.GetResult();
						b = _9DEB1DD20CDB46CF(E13A18739BA44234((object)BF8153357FCA495D), ABC38FEDDCBA4AA4(_7F27B8A5B4DC47F3((object)BF8153357FCA495D)), E6F086685ED14BA8(_7F27B8A5B4DC47F3((object)BF8153357FCA495D)), _2D31989C5E904B5F(_7F27B8A5B4DC47F3((object)BF8153357FCA495D)));
						int num131;
						if (b == _003CModule_003E._8B9C7B12B1AE4949<int>(605492671))
						{
							num49 = -704561892;
							num131 = num49;
						}
						else
						{
							num49 = -314304518;
							num131 = num49;
						}
						continue;
						IL_3915:
						int num132;
						if (AE7EF1D1F4FD421A(obj._5CB5F38886F54B64[_003CModule_003E._390073C602714496<int>(-250964212)]))
						{
							num49 = 394003596;
							num132 = num49;
						}
						else
						{
							num49 = 855742984;
							num132 = num49;
						}
					}
					goto IL_30b5;
					IL_421b:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num49 = -578690530;
					goto IL_30ba;
					IL_41c4:
					val5 = _39E83795D3354955;
					_39E83795D3354955 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
					num49 = -227020179;
					goto IL_30ba;
					IL_410e:
					b3985E84DB64474E = B3985E84DB64474E;
					num49 = -1007810670;
					goto IL_30ba;
					IL_40f1:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num49 = 264317977;
					goto IL_30ba;
					IL_40d3:
					b3985E84DB64474E = B3985E84DB64474E;
					B3985E84DB64474E = default;
					num49 = -200801667;
					goto IL_30ba;
					IL_3fc4:
					eEC5A862EDC8437C = _74DD419E29E14A61((object)FB9603B015784B9C._316F91961FA14705, _48876E33D81047E6((object)obj.D70334A6F9FB43AC), _003CModule_003E.F84FA79ABE6944BB<string>(-2046497433)).GetAwaiter();
					num49 = -1115464481;
					goto IL_30ba;
					IL_3dee:
					eEC5A862EDC8437C = EEC5A862EDC8437C;
					EEC5A862EDC8437C = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096));
					num49 = 559067138;
					goto IL_30ba;
					IL_3d78:
					a40A40ADC0DD4B = A40A40ADC0DD4B36;
					A40A40ADC0DD4B36 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
					num49 = -833957948;
					goto IL_30ba;
					IL_3d47:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
					num49 = -1530489580;
					goto IL_30ba;
					IL_3c24:
					val = _71B84601FF194825;
					_71B84601FF194825 = default;
					num = (_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
					num49 = 565610444;
					goto IL_30ba;
					IL_38c9:
					eEC5A862EDC8437C = EEC5A862EDC8437C;
					EEC5A862EDC8437C = default;
					num49 = 241661298;
					goto IL_30ba;
					end_IL_000f:
					break;
				}
			}
			catch (Exception exception)
			{
				_213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(818201983);
				_116FC2362C114D51.SetException(exception);
				return;
			}
			_213BA1D9C27145CC = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			_116FC2362C114D51.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_116FC2362C114D51.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object DD59AE63368F420E()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static bool _3E991342A9BF4CEB(object P_0)
		{
			return ((_1DB744298E9F4B09)P_0)._6EB2D3D9EC934A7A;
		}

		static UniTask A9B109CB5276484A(object P_0, string P_1, Color P_2, bool P_3, string P_4)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((_200C0FCD340543F6)P_0).AE48F40087984EA0(P_1, P_2, P_3, P_4);
		}

		static bool AE7EF1D1F4FD421A(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}

		static int _4F1A4299C0BE4B9D(object P_0)
		{
			return ((string)P_0).Length;
		}

		static char E0A5CA0656D94CD7(object P_0, int P_1)
		{
			return ((string)P_0)[P_1];
		}

		static bool F528D8CFC38342FD(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static object _77AB40815D0C47BE()
		{
			return Assembly.GetExecutingAssembly();
		}

		static object _08A7D348D0614530(object P_0)
		{
			return ((Assembly)P_0).GetName();
		}

		static object B43F17A4C1424EC4(object P_0)
		{
			return ((AssemblyName)P_0).Version;
		}

		static string _5BD35D831A404C2E(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static CSteamID _48876E33D81047E6(object P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((_200C0FCD340543F6)P_0).E6E47FE0E57A443A();
		}

		static Task<bool> _74DD419E29E14A61(object P_0, CSteamID P_1, string P_2)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((_4C6B03DD3A6441ED)P_0)._66F4DDEF71A94E25(P_1, P_2);
		}

		static object _7CF890F5AC024C2C(object P_0, string P_1)
		{
			return ((IStringLocalizer)P_0)[P_1];
		}

		static string BAD4CAA028BA4C07(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}

		static bool _46C71FA467354FFE(object P_0, CSteamID P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((E651E17AA2CA4BC8)P_0).C3BAAC3F99224A6F(P_1);
		}

		static void _971383EA323F44E9(object P_0, CSteamID P_1)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((E651E17AA2CA4BC8)P_0).D921A004769646BD(P_1);
		}

		static List<SteamPlayer> ACBB5A52B1CF4D14()
		{
			return Provider.clients;
		}

		static object _21FF3FAF32E84647(object P_0)
		{
			return ((SteamPlayer)P_0).playerID;
		}

		static CSteamID EFA8AE6F269E4C52(object P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((SteamPlayerID)P_0).steamID;
		}

		static void _29DD977FC69741BF(string P_0, Color P_1, SteamPlayer P_2, SteamPlayer P_3, EChatMode P_4, string P_5, bool P_6)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			ChatManager.serverSendMessage(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
		}

		static object _7A95747960884699(object P_0)
		{
			return ((_85A0C820EF334E82)P_0)._40CCC338AB744483();
		}

		static List<_31CD7D2CD00648BB> A4AF3565A9E04331(object P_0)
		{
			return ((AA43369C3B1A47A1)P_0)._57FA98D21C7B46D8;
		}

		static bool _21480727BF2049D2(object P_0)
		{
			return ((B0603A9963A3423A)P_0)._8C112B84978C478E;
		}

		static byte[] _8D508894EE0F4ECD(object P_0)
		{
			return ((B0603A9963A3423A)P_0).BD195F36B8F043BD;
		}

		static object _2C5C45A7A2614D1A(object P_0, int P_1, byte[] P_2)
		{
			return ((B7097FC49A384CFA)P_0).B188543F9BD44F49(P_1, P_2);
		}

		static TaskAwaiter DB86F69B1AEC476B(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static List<A19CBF069C964833._40FE7AC3F69F4B10> _3402CEAD12774C3C(object P_0)
		{
			return ((A19CBF069C964833)P_0)._758D156F4A734291();
		}

		static List<float> _2AE76733FC7C4318(object P_0, int P_1)
		{
			return ((A19CBF069C964833._40FE7AC3F69F4B10)P_0)._3BE4A79564D34EE1(P_1);
		}

		static float C43E175F75614A60(object P_0)
		{
			return ((A19CBF069C964833._40FE7AC3F69F4B10)P_0).ED8C14184A8E4E32();
		}

		static float _95C4856916E94383(IEnumerable<float> P_0)
		{
			return P_0.Max();
		}

		static float _54AEFB29825643AD(IEnumerable<float> P_0)
		{
			return P_0.Min();
		}

		static float _6EDD029392514E22(IEnumerable<float> P_0)
		{
			return P_0.Average();
		}

		static string A9B48B97C5D0494F(string[] P_0)
		{
			return string.Concat(P_0);
		}

		static bool _439943FCB7A54480(string P_0, ref SteamPlayer P_1)
		{
			return PlayerTool.tryGetSteamPlayer(P_0, ref P_1);
		}

		static object DCEA54BFA6294707(object P_0)
		{
			return ((SteamPlayer)P_0).player;
		}

		static bool _18B15859E37B4D6B(Object P_0, Object P_1)
		{
			return P_0 == P_1;
		}

		static object E13A18739BA44234(object P_0)
		{
			return ((Player)P_0).inventory;
		}

		static object _7F27B8A5B4DC47F3(object P_0)
		{
			return ((Player)P_0).equipment;
		}

		static byte ABC38FEDDCBA4AA4(object P_0)
		{
			return ((PlayerEquipment)P_0).equippedPage;
		}

		static byte E6F086685ED14BA8(object P_0)
		{
			return ((PlayerEquipment)P_0).equipped_x;
		}

		static byte _2D31989C5E904B5F(object P_0)
		{
			return ((PlayerEquipment)P_0).equipped_y;
		}

		static byte _9DEB1DD20CDB46CF(object P_0, byte P_1, byte P_2, byte P_3)
		{
			return ((PlayerInventory)P_0).getIndex(P_1, P_2, P_3);
		}

		static object C55019FCC8F14824(object P_0, byte P_1, byte P_2)
		{
			return ((PlayerInventory)P_0).getItem(P_1, P_2);
		}

		static object _51F622F0D342406C(object P_0)
		{
			return ((_200C0FCD340543F6)P_0).F126871565D3416A();
		}

		static object _8792062CACF741F7(object P_0)
		{
			return ((ItemJar)P_0).item;
		}

		static ushort _948D4A771E474FE6(object P_0)
		{
			return ((Item)P_0).id;
		}

		static object _113547498C884B4A(ushort P_0, byte P_1, byte P_2, byte[] P_3)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected Obj, but got Unknown
			return (object)new Item(P_0, P_1, P_2, P_3);
		}

		static void D3BF50B51FF74331(object P_0, object P_1, bool P_2)
		{
			((PlayerInventory)P_0).forceAddItem((Item)P_1, P_2);
		}

		static ConcurrentDictionary<CSteamID, C7A753824C0746AE._359F714CB1DB4E96> F73B4C212C0D4004(object P_0)
		{
			return ((C7A753824C0746AE)P_0).ADAA9521257F4886();
		}

		static object _86B99FA26B604A23()
		{
			return new C7A753824C0746AE._359F714CB1DB4E96();
		}

		static object _92C62BA4151F472E(TimeSpan P_0)
		{
			return Task.Delay(P_0);
		}

		static string ABC4AC51DF474E9D(string P_0, object P_1, object P_2, object P_3)
		{
			return string.Format(P_0, P_1, P_2, P_3);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct B9BD6FC45A4149B2 : IAsyncStateMachine
	{
		public int B7E24CF5EFC145F7;

		public AsyncUniTaskMethodBuilder B7984369996745CE;

		public _148FC9FDA20643FB _3C88170016274367;

		public string _7503677C6B154123;

		public Color _3939F113FADA48E7;

		private Awaiter _07A1202192F140A5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			int num = B7E24CF5EFC145F7;
			_148FC9FDA20643FB obj = _3C88170016274367;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_01c0;
				IL_0014:
				int num2 = 2059660573;
				goto IL_0019;
				IL_0019:
				Awaiter val = default;
				UniTask val2 = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)((unchecked(769604579 * 2091436227) - -(-1832988 - -1054693603 + unchecked(-1926427224 * 1677688539) + (--1061858124 + (-69323782 - 1329442834)) + (~(~1138684422) + (-111938405 + (0x53D30609 ^ -181691435))) - -(~(~num3))) * -843247673) * 237707359)) % 20)
					{
					case 0u:
						break;
					default:
						goto end_IL_000e;
					case 3u:
					{
						val = val2.GetAwaiter();
						int num9;
						int num10;
						if (!val.IsCompleted)
						{
							num9 = -1470002276;
							num10 = num9;
						}
						else
						{
							num9 = -794161342;
							num10 = num9;
						}
						num2 = num9 ^ ((int)num4 * -283101354);
						continue;
					}
					case 2u:
						val2 = _8694EF1410D845C1((object)obj.D70334A6F9FB43AC, _05720287F3B44A47(_7503677C6B154123, _003CModule_003E._390073C602714496<string>(-1983658028), string.Empty), _3939F113FADA48E7, (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0, (string)null);
						num2 = -378333256;
						continue;
					case 19u:
						val.GetResult();
						num2 = -275940881;
						continue;
					case 1u:
						num = (B7E24CF5EFC145F7 = _003CModule_003E._390073C602714496<int>(2131963235));
						num2 = -125469036;
						continue;
					case 4u:
						return;
					case 11u:
						_07A1202192F140A5 = val;
						B7984369996745CE.AwaitUnsafeOnCompleted<Awaiter, B9BD6FC45A4149B2>(ref val, ref this);
						num2 = ((int)num4 * -290025738) ^ -1386822418;
						continue;
					case 7u:
						goto IL_01c0;
					case 5u:
						num = (B7E24CF5EFC145F7 = _003CModule_003E._390073C602714496<int>(-250964212));
						_07A1202192F140A5 = val;
						num2 = 2108404097;
						continue;
					case 8u:
						B7984369996745CE.AwaitUnsafeOnCompleted<Awaiter, B9BD6FC45A4149B2>(ref val, ref this);
						num2 = ((int)num4 * -904897780) ^ -2117615439;
						continue;
					case 18u:
						val.GetResult();
						num2 = -275940881;
						continue;
					case 14u:
						val = _07A1202192F140A5;
						_07A1202192F140A5 = default;
						num2 = 1160581401;
						continue;
					case 12u:
						goto IL_0251;
					case 13u:
						num = (B7E24CF5EFC145F7 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
						num2 = -391390168;
						continue;
					case 17u:
						val2 = _8694EF1410D845C1((object)obj.D70334A6F9FB43AC, _7503677C6B154123, _3939F113FADA48E7, (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0, _9AB67761792440A7._6142757B48FF46AD);
						num2 = -1680746505;
						continue;
					case 10u:
					{
						val = val2.GetAwaiter();
						int num7;
						int num8;
						if (val.IsCompleted)
						{
							num7 = -349605305;
							num8 = num7;
						}
						else
						{
							num7 = 610205778;
							num8 = num7;
						}
						num2 = num7 ^ (int)(num4 * 987869650);
						continue;
					}
					case 16u:
						num = (B7E24CF5EFC145F7 = _003CModule_003E._390073C602714496<int>(-736908096));
						num2 = -1845580885;
						continue;
					case 15u:
						return;
					case 9u:
					{
						int num5;
						int num6;
						if (!DCD8341BF8E24334((object)obj.D70334A6F9FB43AC))
						{
							num5 = -1854984587;
							num6 = num5;
						}
						else
						{
							num5 = 1117222048;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num4 * 271903215);
						continue;
					}
					case 6u:
						goto end_IL_000e;
					}
					break;
					IL_0251:
					int num11;
					if (num != _003CModule_003E._390073C602714496<int>(-250964212))
					{
						num2 = 1694760738;
						num11 = num2;
					}
					else
					{
						num2 = 737325347;
						num11 = num2;
					}
				}
				goto IL_0014;
				IL_01c0:
				val = _07A1202192F140A5;
				_07A1202192F140A5 = default;
				num2 = 1969199938;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num12 = 1210952089;
					while (true)
					{
						int num3 = num12;
						uint num4;
						switch ((num4 = (uint)((unchecked(769604579 * 2091436227) - -(-1832988 - -1054693603 + unchecked(-1926427224 * 1677688539) + (--1061858124 + (-69323782 - 1329442834)) + (~(~1138684422) + (-111938405 + (0x53D30609 ^ -181691435))) - -(~(~num3))) * -843247673) * 237707359)) % 3)
						{
						case 2u:
							break;
						case 1u:
							goto IL_03dc;
						default:
							B7984369996745CE.SetException(exception);
							return;
						}
						break;
						IL_03dc:
						B7E24CF5EFC145F7 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
						num12 = 1234635247;
					}
				}
			}
			B7E24CF5EFC145F7 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			B7984369996745CE.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			B7984369996745CE.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool DCD8341BF8E24334(object P_0)
		{
			return ((_200C0FCD340543F6)P_0)._3C932459E214469B;
		}

		static string _05720287F3B44A47(string P_0, string P_1, string P_2)
		{
			return Regex.Replace(P_0, P_1, P_2);
		}

		static UniTask _8694EF1410D845C1(object P_0, string P_1, Color P_2, bool P_3, string P_4)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return ((_200C0FCD340543F6)P_0).AE48F40087984EA0(P_1, P_2, P_3, P_4);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct ADA850F57A374945 : IAsyncStateMachine
	{
		public int A2AD1E37CCCF4E7A;

		public AsyncUniTaskMethodBuilder _9A08321E0A6F4513;

		public _148FC9FDA20643FB _48C98436F6674CCB;

		private Awaiter _71AEB64977F546E7;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			int num = A2AD1E37CCCF4E7A;
			_148FC9FDA20643FB obj = _48C98436F6674CCB;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_018e;
				IL_0014:
				int num2 = -169424340;
				goto IL_0019;
				IL_0019:
				Awaiter val = default;
				UniTask val2 = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)((~(((num3 * -470602583) ^ ((-(-345410955 + -381393632 - unchecked(959519589 * 1091005321)) ^ 0x59A542FF) - (~338232357 + (0x7CC8C5E0 ^ 0x6C1F68CA)) - -73995812)) - (~unchecked(1443868693 * unchecked(1450121161 * (0x325CE6DC ^ -1782419405))) + (unchecked(742974944 * -1539710783) - -(-1330018354 + 341356598) - unchecked(unchecked(-1550254407 * 2048248091) + unchecked(-749150725 * (-808295007 + -617479024)))))) ^ ((-1758361655 ^ 0x6E5F17F9) - ~(--1401799714))) * 1755733211 * 1208471129 + 1394433795)) % 10)
					{
					case 9u:
						break;
					case 8u:
						return;
					case 0u:
						val = val2.GetAwaiter();
						num2 = ((int)num4 * -119961354) ^ -405464422;
						continue;
					case 4u:
						val2 = obj._242543716BDB4890(_582BD1F537884F2B((LocalizedString)_08A23270006947ED((object)FB9603B015784B9C.C26D24371E744DF8, _003CModule_003E._8B9C7B12B1AE4949<string>(1023218565))), Color.white);
						num2 = -1482999310;
						continue;
					case 2u:
						goto IL_018e;
					case 5u:
						_71AEB64977F546E7 = val;
						num2 = ((int)num4 * -512768110) ^ 0x627E39F3;
						continue;
					case 6u:
					{
						int num5;
						int num6;
						if (!val.IsCompleted)
						{
							num5 = 1946097453;
							num6 = num5;
						}
						else
						{
							num5 = -323784457;
							num6 = num5;
						}
						num2 = num5 ^ ((int)num4 * -1042128869);
						continue;
					}
					case 1u:
						num = (A2AD1E37CCCF4E7A = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042));
						num2 = -1427142637;
						continue;
					case 7u:
						_9A08321E0A6F4513.AwaitUnsafeOnCompleted<Awaiter, ADA850F57A374945>(ref val, ref this);
						num2 = ((int)num4 * -1159360962) ^ -97662324;
						continue;
					default:
						val.GetResult();
						goto end_IL_000e;
					}
					break;
				}
				goto IL_0014;
				IL_018e:
				val = _71AEB64977F546E7;
				_71AEB64977F546E7 = default;
				num = (A2AD1E37CCCF4E7A = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
				num2 = 1347135615;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				A2AD1E37CCCF4E7A = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				_9A08321E0A6F4513.SetException(exception);
				return;
			}
			A2AD1E37CCCF4E7A = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			while (true)
			{
				int num7 = 347915702;
				while (true)
				{
					int num3 = num7;
					uint num4;
					switch ((num4 = (uint)((~(((num3 * -470602583) ^ ((-(-345410955 + -381393632 - unchecked(959519589 * 1091005321)) ^ 0x59A542FF) - (~338232357 + (0x7CC8C5E0 ^ 0x6C1F68CA)) - -73995812)) - (~unchecked(1443868693 * unchecked(1450121161 * (0x325CE6DC ^ -1782419405))) + (unchecked(742974944 * -1539710783) - -(-1330018354 + 341356598) - unchecked(unchecked(-1550254407 * 2048248091) + unchecked(-749150725 * (-808295007 + -617479024)))))) ^ ((-1758361655 ^ 0x6E5F17F9) - ~(--1401799714))) * 1755733211 * 1208471129 + 1394433795)) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_0375;
					case 0u:
						return;
					}
					break;
					IL_0375:
					_9A08321E0A6F4513.SetResult();
					num7 = ((int)num4 * -1368647567) ^ 0x2FBE1221;
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
			_9A08321E0A6F4513.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _08A23270006947ED(object P_0, string P_1)
		{
			return ((IStringLocalizer)P_0)[P_1];
		}

		static string _582BD1F537884F2B(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}
	}

	private static A19CBF069C964833? _951F97102D064735;

	private static _85A0C820EF334E82? _442B7FBA97954791;

	private static C7A753824C0746AE? _3C79809DB22A48D9;

	private static E651E17AA2CA4BC8? F1FEC2A81524472A;

	private static B7097FC49A384CFA? _1A13B20F5C464EB9;

	private readonly _200C0FCD340543F6 D70334A6F9FB43AC = P_0;

	private readonly string[] _5CB5F38886F54B64 = P_1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool _12E92B7AED794992(string P_0, _200C0FCD340543F6 P_1)
	{
		string[] array = _9843C6951CAA45ED((object)_1D05E2A34B704B48((object)P_0, (char)_003CModule_003E.F84FA79ABE6944BB<int>(188355324)), (char)_003CModule_003E.F84FA79ABE6944BB<int>(-439448862), (StringSplitOptions)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
		if (array.Length == 0)
		{
			goto IL_0037;
		}
		goto IL_0218;
		IL_0037:
		int num = 1989205124;
		goto IL_003c;
		IL_003c:
		int num2 = num;
		uint num3;
		switch ((num3 = (uint)((0x24BA6AAD ^ 0x4B7FA044) - unchecked(-2045377146 * -1845619597) - ((num2 ^ -(2076521857 * (~unchecked((8748998 + 1756883542) * -1659097519) - (-(0x6CA80987 ^ -1238144500) - 990837252)) + (~1715971583 + (~(--1526941728) - (0x18DE5BB2 ^ -2031529989) + -(--26641494)))) ^ (-928055623 ^ -unchecked(unchecked(-1652564852 + -664848179) + (338914779 - -1616210015)) ^ -1821769355 ^ (-1289110824 - (unchecked(-1359545026 + -1498886403) + unchecked(640548186 * -2040981387) - (-2073538315 - --1535894754)) + unchecked(unchecked((0xD7EA4DA ^ -1295296710) - 1948938040) * -1949393579))) ^ (225079739 * -(-(--1838676439 ^ -1514625823)))) - unchecked(unchecked(-2010630049 * ~(-825943761 + -798986067)) * -486457029) + 947722546))) % 5)
		{
		case 2u:
			break;
		case 4u:
			return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
		case 0u:
		{
			object obj = FB2C965016A349B1();
			string[] array2 = array.Skip(_003CModule_003E.F84FA79ABE6944BB<int>(1741630884)).ToArray();
			((F83EA94894A94496)obj)._4E44D80A21654F93 = (_148FC9FDA20643FB)FA5CCDFF58F74A2F((object)P_1, array2);
			UniTask.Void((Func<UniTaskVoid>)([MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(F83EA94894A94496.DCE84B5A30E74D2B))] () =>
			{
				//IL_0002: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_003c: Unknown result type (might be due to invalid IL or missing references)
				F83EA94894A94496.DCE84B5A30E74D2B dCE84B5A30E74D2B = default;
				dCE84B5A30E74D2B._8F897728DCCB46F7 = AsyncUniTaskVoidMethodBuilder.Create();
				dCE84B5A30E74D2B._2BF3CF55A04A487E = (F83EA94894A94496)obj;
				dCE84B5A30E74D2B._4DAA9E1002D740B9 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120);
				dCE84B5A30E74D2B._8F897728DCCB46F7.Start<F83EA94894A94496.DCE84B5A30E74D2B>(ref dCE84B5A30E74D2B);
				return dCE84B5A30E74D2B._8F897728DCCB46F7.Task;
			}));
			return (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0;
		}
		case 3u:
			goto IL_0218;
		default:
			return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
		}
		goto IL_0037;
		IL_0218:
		int num4;
		if (E282C6BD27C84FD6((object)array[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)], _003CModule_003E.F84FA79ABE6944BB<string>(-2104679325), (StringComparison)_003CModule_003E._3F57E81A62734AC2<int>(-1993266263)))
		{
			num = -811910379;
			num4 = num;
		}
		else
		{
			num = 1757900382;
			num4 = num;
		}
		goto IL_003c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_8AF6331E943144F4))]
	public UniTask CD8C425326C64AB5()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		_8AF6331E943144F4 obj = default;
		obj._116FC2362C114D51 = AsyncUniTaskMethodBuilder.Create();
		obj.C639F38DC3D5475B = this;
		obj._213BA1D9C27145CC = _003CModule_003E._390073C602714496<int>(-736908096);
		obj._116FC2362C114D51.Start<_8AF6331E943144F4>(ref obj);
		return obj._116FC2362C114D51.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(B9BD6FC45A4149B2))]
	private UniTask _242543716BDB4890(string P_0, Color P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		B9BD6FC45A4149B2 b9BD6FC45A4149B = default;
		b9BD6FC45A4149B.B7984369996745CE = AsyncUniTaskMethodBuilder.Create();
		b9BD6FC45A4149B._3C88170016274367 = this;
		b9BD6FC45A4149B._7503677C6B154123 = P_0;
		b9BD6FC45A4149B._3939F113FADA48E7 = P_1;
		b9BD6FC45A4149B.B7E24CF5EFC145F7 = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
		b9BD6FC45A4149B.B7984369996745CE.Start<B9BD6FC45A4149B2>(ref b9BD6FC45A4149B);
		return b9BD6FC45A4149B.B7984369996745CE.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(ADA850F57A374945))]
	private UniTask _637E3D758E1E4EA8()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		ADA850F57A374945 aDA850F57A = default;
		aDA850F57A._9A08321E0A6F4513 = AsyncUniTaskMethodBuilder.Create();
		aDA850F57A._48C98436F6674CCB = this;
		aDA850F57A.A2AD1E37CCCF4E7A = _003CModule_003E._390073C602714496<int>(-736908096);
		aDA850F57A._9A08321E0A6F4513.Start<ADA850F57A374945>(ref aDA850F57A);
		return aDA850F57A._9A08321E0A6F4513.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private string _8CE2BF0C517D4102(float P_0)
	{
		string text = _003CModule_003E._3F57E81A62734AC2<string>(-854904693);
		while (true)
		{
			int num = -1129683184;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-num2) + unchecked((-1187524687 ^ 0x554587DD) * -859578601) + ~(-1826418487 ^ (-1179601334 ^ -1965362933)))) % 6)
				{
				case 3u:
					break;
				case 0u:
				{
					int num5;
					if (P_0 <= _003CModule_003E._3F57E81A62734AC2<float>(-1608409756))
					{
						num = 349345344;
						num5 = num;
					}
					else
					{
						num = -1372892787;
						num5 = num;
					}
					continue;
				}
				case 1u:
					text = _003CModule_003E._390073C602714496<string>(657297647);
					num = 349345344;
					continue;
				case 5u:
					text = _003CModule_003E.F84FA79ABE6944BB<string>(-1582635458);
					num = 349345344;
					continue;
				case 4u:
				{
					int num4;
					if (P_0 <= _003CModule_003E.F84FA79ABE6944BB<float>(-1589296915))
					{
						num = -812502344;
						num4 = num;
					}
					else
					{
						num = 104565509;
						num4 = num;
					}
					continue;
				}
				default:
					return _4E10CD0291244588(_003CModule_003E.F84FA79ABE6944BB<string>(-1925628497), (object)text, (object)P_0);
				}
				break;
			}
		}
	}

	static string _1D05E2A34B704B48(object P_0, char P_1)
	{
		return ((string)P_0).TrimStart(P_1);
	}

	static string[] _9843C6951CAA45ED(object P_0, char P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split(P_1, P_2);
	}

	static bool E282C6BD27C84FD6(object P_0, string P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals(P_1, P_2);
	}

	static object FB2C965016A349B1()
	{
		return new F83EA94894A94496();
	}

	static object FA5CCDFF58F74A2F(object P_0, string[] P_1)
	{
		return new _148FC9FDA20643FB((_200C0FCD340543F6)P_0, P_1);
	}

	static string _4E10CD0291244588(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}
}
