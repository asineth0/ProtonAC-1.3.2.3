using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using SDG.NetTransport;
using SDG.Unturned;
using Steamworks;

internal class _7FE330C6E84D4C74 : _760EF57D5259421C
{
	private static class E39430CC079F4A38
	{
		public const string _9307321902B541FB = "[steamID]";

		public const string _908F67833F2F4462 = "[reason]";

		public const string B9494B1EA4C84E19 = "[bantime]";
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _960BDDEF64FC434B
	{
		public static readonly _960BDDEF64FC434B _003C_003E9 = (_960BDDEF64FC434B)_603D2DDBEE134E56();

		public static Action<Exception> _003C_003E9__21_1;

		public static Func<FCE22BD5614B4582.E108E4DE5C084B2A, bool> _003C_003E9__22_0;

		public static Func<CSteamID, int, int> _003C_003E9__23_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _17DAA44E63324B47(Exception P_0)
		{
			if (!(P_0 is OperationCanceledException))
			{
				goto IL_000b;
			}
			goto IL_0161;
			IL_000b:
			int num = 137550281;
			goto IL_0010;
			IL_0010:
			bool flag = default;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~(~(~1868237779 - ((num2 - (-((-1800059036 + 1279772128) ^ -(~-1785701697) ^ 0x42E6A36F ^ -1506398998) ^ (-(((-1207794027 ^ -1734696858) - (220420740 - -864342883) + -(-683092082 ^ 0x42F00578)) * -102207109) * -1798964073))) ^ ~(-unchecked(850883225 * (0x78C255B2 ^ 0x1468F3A)))) * -1174822341)) ^ -1232708609) * -1932135667)) % 8)
				{
				case 7u:
					break;
				default:
					return;
				case 0u:
					_18C71C27EBCF41F4(_760EF57D5259421C._45BE54DAE6C14D66, _003CModule_003E._3F57E81A62734AC2<string>(1524279150), Array.Empty<object>());
					return;
				case 2u:
					goto IL_0126;
				case 4u:
				{
					int num4;
					int num5;
					if (P_0 is TimeoutException)
					{
						num4 = 1292287863;
						num5 = num4;
					}
					else
					{
						num4 = 1318918836;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -1568648457);
					continue;
				}
				case 6u:
					goto IL_0161;
				case 3u:
					flag = (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
					num = 1003566647;
					continue;
				case 1u:
					_4F17C7C443EF454F(_760EF57D5259421C._45BE54DAE6C14D66, P_0, _003CModule_003E.F84FA79ABE6944BB<string>(242595208), Array.Empty<object>());
					num = -1851059550;
					continue;
				case 5u:
					return;
				}
				break;
				IL_0126:
				int num6;
				if (flag)
				{
					num = 678535301;
					num6 = num;
				}
				else
				{
					num = -1436927234;
					num6 = num;
				}
			}
			goto IL_000b;
			IL_0161:
			flag = (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0;
			num = 1003566647;
			goto IL_0010;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _89527351A94044E2(FCE22BD5614B4582.E108E4DE5C084B2A P_0)
		{
			object obj = _2721EFBBE9A34347((object)P_0);
			if (obj == null)
			{
				return (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
			}
			return _16D65EA37F0D4A24((object)C903AFB486594E28(obj), _003CModule_003E._390073C602714496<string>(1848985496));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal int CB9ABAC80D5E4DC6(CSteamID P_0, int P_1)
		{
			return P_1 + _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
		}

		static object _603D2DDBEE134E56()
		{
			return new _960BDDEF64FC434B();
		}

		static void _18C71C27EBCF41F4(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}

		static void _4F17C7C443EF454F(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}

		static object _2721EFBBE9A34347(object P_0)
		{
			return ((FCE22BD5614B4582.E108E4DE5C084B2A)P_0)._9950B06098C047BB;
		}

		static string C903AFB486594E28(object P_0)
		{
			return ((Uri)P_0).OriginalString;
		}

		static bool _16D65EA37F0D4A24(object P_0, string P_1)
		{
			return ((string)P_0).Contains(P_1);
		}
	}

	[CompilerGenerated]
	private sealed class CA80F952653941F8
	{
		[StructLayout(LayoutKind.Auto)]
		private struct _5BA9D9C248474FE9 : IAsyncStateMachine
		{
			public int D72670B0CDD345A3;

			public AsyncTaskMethodBuilder _668F3CCE73704453;

			public CA80F952653941F8 _589E78004D7C4F95;

			private TaskAwaiter E509D0C878C04C42;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
				int num = D72670B0CDD345A3;
				CA80F952653941F8 cA80F952653941F = _589E78004D7C4F95;
				try
				{
					if (num != 0)
					{
						goto IL_0014;
					}
					goto IL_00ab;
					IL_0014:
					int num2 = -1442166302;
					goto IL_0019;
					IL_0019:
					TaskAwaiter awaiter = default;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)((-130971758 - 301252148 - -(-(~((-(-(--1669749188 + -1370869766)) - (num3 ^ (~((1583227946 + -4051009 - --1949533754 - 1131722149) * 1645208977 * 1711650787) * 158931937))) * 1506126315)))) ^ -602752449)) % 10)
						{
						case 5u:
							break;
						case 0u:
							goto IL_00ab;
						case 2u:
							awaiter = _70EC61510240460E((object)cA80F952653941F._5EBC116FEDE24B0C.E7AC8FC8DE184C82(cA80F952653941F._34BE1A620DCD4092, B63C8FD7EC0C449E((object)cA80F952653941F._653F6091F53848C3)));
							num2 = -2081204257;
							continue;
						case 3u:
							E509D0C878C04C42 = default;
							num2 = ((int)num4 * -129227860) ^ 0xE394CE2;
							continue;
						case 9u:
							num = (D72670B0CDD345A3 = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num2 = 29655962;
							continue;
						case 6u:
						{
							int num7;
							int num8;
							if (!awaiter.IsCompleted)
							{
								num7 = 1049825179;
								num8 = num7;
							}
							else
							{
								num7 = 915441754;
								num8 = num7;
							}
							num2 = num7 ^ (int)(num4 * 485894598);
							continue;
						}
						case 1u:
						{
							int num5;
							int num6;
							if (_79100C544F324537((object)cA80F952653941F._5EBC116FEDE24B0C._6D09CFFF54324A80.E6CEB4BA92AA4EB5, cA80F952653941F._34BE1A620DCD4092.m_SteamID))
							{
								num5 = -178186782;
								num6 = num5;
							}
							else
							{
								num5 = 1062975312;
								num6 = num5;
							}
							num2 = num5 ^ ((int)num4 * -699773469);
							continue;
						}
						case 8u:
							num = (D72670B0CDD345A3 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
							E509D0C878C04C42 = awaiter;
							_668F3CCE73704453.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 4u:
							goto end_IL_000e;
						default:
							awaiter.GetResult();
							goto end_IL_000e;
						}
						break;
					}
					goto IL_0014;
					IL_00ab:
					awaiter = E509D0C878C04C42;
					num2 = -67162964;
					goto IL_0019;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					D72670B0CDD345A3 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
					_668F3CCE73704453.SetException(exception);
					return;
				}
				D72670B0CDD345A3 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				while (true)
				{
					int num9 = 2117804694;
					while (true)
					{
						int num3 = num9;
						uint num4;
						switch ((num4 = (uint)((-130971758 - 301252148 - -(-(~((-(-(--1669749188 + -1370869766)) - (num3 ^ (~((1583227946 + -4051009 - --1949533754 - 1131722149) * 1645208977 * 1711650787) * 158931937))) * 1506126315)))) ^ -602752449)) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 1u:
							goto IL_028d;
						case 2u:
							return;
						}
						break;
						IL_028d:
						_668F3CCE73704453.SetResult();
						num9 = ((int)num4 * -1776811576) ^ 0x4A336E81;
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
				_668F3CCE73704453.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static bool _79100C544F324537(object P_0, ulong P_1)
			{
				return ((_05B7A84E8227463B)P_0).EC834E7B0DC044F4(P_1);
			}

			static CancellationToken B63C8FD7EC0C449E(object P_0)
			{
				return ((CancellationTokenSource)P_0).Token;
			}

			static TaskAwaiter _70EC61510240460E(object P_0)
			{
				return ((Task)P_0).GetAwaiter();
			}
		}

		public _7FE330C6E84D4C74 _5EBC116FEDE24B0C;

		public CSteamID _34BE1A620DCD4092;

		public CancellationTokenSource _653F6091F53848C3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_5BA9D9C248474FE9))]
		internal Task A8F16CE752F84ECD()
		{
			_5BA9D9C248474FE9 stateMachine = default;
			stateMachine._668F3CCE73704453 = AsyncTaskMethodBuilder.Create();
			while (true)
			{
				int num = -1895797292;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~((~(-(0x40ED5B74 ^ -2008992270)) * 1163287979 - (-(0x307FDF25 ^ (-1014047843 * -1910758134)) ^ ~(-(~(332655791 + 113498073)))) - num2 * 13953499 - ((-471623964 ^ -unchecked(256571753 * unchecked(-1815244059 + -410354218))) - ~1414923428)) ^ -680288801) * 1255814677)) % 3)
					{
					case 2u:
						break;
					case 1u:
						goto IL_00df;
					default:
						stateMachine._668F3CCE73704453.Start(ref stateMachine);
						return stateMachine._668F3CCE73704453.Task;
					}
					break;
					IL_00df:
					stateMachine._589E78004D7C4F95 = this;
					stateMachine.D72670B0CDD345A3 = _003CModule_003E._390073C602714496<int>(-736908096);
					num = -1391056511;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct BF97F1769A9C4065 : IAsyncStateMachine
	{
		public int EA4E5F9998F6455D;

		public AsyncTaskMethodBuilder A9582FA8AA8C4BE9;

		public CSteamID E8695B60E64149DE;

		public CancellationToken _7B62E3CE1BB34230;

		public _7FE330C6E84D4C74 _840F7F8437414B9F;

		private F131A7E07B2C4332 C874322FB0AC4646;

		private FCE22BD5614B4582 _37E7D64D689C486E;

		private TaskAwaiter<FCE22BD5614B4582> _2EA0DAC95CE5485C;

		private TaskAwaiter _9EBB7EA9BFDC4176;

		private TaskAwaiter<int?> _3D173AF4EB2E42BE;

		private string _79076B31180C4296;

		private Awaiter _64262815596D45B2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_085a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1177: Unknown result type (might be due to invalid IL or missing references)
			//IL_117c: Unknown result type (might be due to invalid IL or missing references)
			//IL_15fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1602: Unknown result type (might be due to invalid IL or missing references)
			//IL_160a: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d74: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d79: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_15a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1456: Unknown result type (might be due to invalid IL or missing references)
			//IL_12eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_147c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e93: Unknown result type (might be due to invalid IL or missing references)
			//IL_11e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1091: Unknown result type (might be due to invalid IL or missing references)
			//IL_1093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0678: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			int num = EA4E5F9998F6455D;
			_7FE330C6E84D4C74 obj = _840F7F8437414B9F;
			try
			{
				if ((uint)num > (uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-2011565680))
				{
					while (true)
					{
						int num2 = -230502234;
						while (true)
						{
							int num3 = num2;
							uint num4;
							switch ((num4 = (uint)(-(~num3) ^ (unchecked(~1884898492 * 447204809) + ((-722683965 * --155395672) ^ 0xBB7F4B) - ~(1022787248 - (--1598288197 + -1672392476))) ^ (0x760FB53E ^ ((-1808525375 + 1155050643) ^ -738343417)))) % 3)
							{
							case 0u:
								break;
							case 2u:
								C874322FB0AC4646 = (F131A7E07B2C4332)B8560B26CD88464D((object)null);
								num2 = ((int)num4 * -1666752166) ^ 0x409FE344;
								continue;
							default:
								goto end_IL_0020;
							}
							break;
						}
						continue;
						end_IL_0020:
						break;
					}
				}
				try
				{
					int num5;
					TaskAwaiter awaiter = default;
					FCE22BD5614B4582 result = default;
					TaskAwaiter<FCE22BD5614B4582> awaiter2 = default;
					int value;
					int num20;
					int num21;
					int num33 = default;
					TimeSpan timeSpan2 = default;
					Awaiter awaiter4 = default;
					LocalizedString val8 = default;
					DateTime? dateTime = default;
					double num24 = default;
					int num50 = default;
					TimeSpan timeSpan = default;
					LocalizedString val14 = default;
					string text8 = default;
					double? num29 = default;
					FCE22BD5614B4582.E108E4DE5C084B2A e108E4DE5C084B2A = default;
					double? num38 = default;
					switch (num)
					{
					default:
						num5 = -857258065;
						goto IL_00eb;
					case 0:
						goto IL_021b;
					case 1:
						goto IL_022c;
					case 2:
					case 3:
						goto IL_043d;
					case 7:
						goto IL_0ae6;
					case 4:
						goto IL_0e40;
					case 9:
						goto IL_10bd;
					case 6:
						goto IL_1176;
					case 8:
						goto IL_15fc;
					case 5:
						goto IL_161a;
						IL_00eb:
						while (true)
						{
							int num3 = num5;
							uint num4;
							switch ((num4 = (uint)(-(~num3) ^ (unchecked(~1884898492 * 447204809) + ((-722683965 * --155395672) ^ 0xBB7F4B) - ~(1022787248 - (--1598288197 + -1672392476))) ^ (0x760FB53E ^ ((-1808525375 + 1155050643) ^ -738343417)))) % 18)
							{
							case 2u:
								break;
							case 1u:
								num = (EA4E5F9998F6455D = _003CModule_003E._3F57E81A62734AC2<int>(1017304263));
								_9EBB7EA9BFDC4176 = awaiter;
								num5 = -1552702707;
								continue;
							case 12u:
								_2EA0DAC95CE5485C = default;
								num = (EA4E5F9998F6455D = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
								num5 = -1805324435;
								continue;
							case 3u:
								goto IL_01ee;
							case 16u:
								goto IL_021b;
							case 0u:
								goto IL_022c;
							case 4u:
								_37E7D64D689C486E = result;
								num5 = (int)(num4 * 377576191) ^ -1487535309;
								continue;
							case 6u:
								A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								num5 = (int)(num4 * 259632179) ^ -634090917;
								continue;
							case 14u:
								goto IL_0299;
							case 13u:
								awaiter.GetResult();
								goto end_IL_00b9;
							case 17u:
							{
								awaiter2 = C07ADDDB3BE3439C((object)C874322FB0AC4646, E8695B60E64149DE.m_SteamID, _7B62E3CE1BB34230).GetAwaiter();
								int num8;
								int num9;
								if (!awaiter2.IsCompleted)
								{
									num8 = 336752904;
									num9 = num8;
								}
								else
								{
									num8 = 1211791956;
									num9 = num8;
								}
								num5 = num8 ^ ((int)num4 * -537112677);
								continue;
							}
							case 9u:
								return;
							case 8u:
							{
								int num6;
								int num7;
								if (!obj.D5648A346B8C4640.Contains(ECE4813FED1F4EC2((object)_37E7D64D689C486E)))
								{
									num6 = 1470196796;
									num7 = num6;
								}
								else
								{
									num6 = 1900506383;
									num7 = num6;
								}
								num5 = num6 ^ (int)(num4 * 205031393);
								continue;
							}
							case 7u:
								num = (EA4E5F9998F6455D = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
								_2EA0DAC95CE5485C = awaiter2;
								num5 = -69490376;
								continue;
							case 11u:
								result = awaiter2.GetResult();
								num5 = -402176038;
								continue;
							case 15u:
								goto IL_03f5;
							case 5u:
								A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							default:
								goto IL_043d;
							}
							break;
							IL_03f5:
							if (obj.B704F62B092246E0 > _003CModule_003E._58ECCB512F2A43AC<int>(352679804))
							{
								num5 = -1451623238;
								continue;
							}
							goto IL_086c;
							IL_01ee:
							int num10;
							if (obj.D5648A346B8C4640.Count > _003CModule_003E._58ECCB512F2A43AC<int>(352679804))
							{
								num5 = -186959910;
								num10 = num5;
							}
							else
							{
								num5 = -888275233;
								num10 = num5;
							}
							continue;
							IL_0299:
							CSteamID val = E8695B60E64149DE;
							IStringLocalizer val2 = _760EF57D5259421C._690D5F470A354A09;
							string text = _003CModule_003E._390073C602714496<string>(-63054353);
							object[] array = new object[_003CModule_003E.F84FA79ABE6944BB<int>(1741630884)];
							array[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)] = new
							{
								PrivacyState = ECE4813FED1F4EC2((object)_37E7D64D689C486E)
							};
							awaiter = FEDAEC9636AA41D2((object)obj._00F2722AAB714B80(val, _09DABA428BB14163((LocalizedString)_6D27F32F99344A75((object)val2, text, array))));
							int num11;
							if (!awaiter.IsCompleted)
							{
								num5 = -1249250877;
								num11 = num5;
							}
							else
							{
								num5 = -166194697;
								num11 = num5;
							}
						}
						goto default;
						IL_043d:
						try
						{
							if (num != _003CModule_003E._8B9C7B12B1AE4949<int>(-1540732256))
							{
								goto IL_044f;
							}
							goto IL_0558;
							IL_044f:
							int num12 = -1417662477;
							goto IL_0454;
							IL_0454:
							TaskAwaiter<int?> awaiter3 = default;
							int? result2 = default;
							while (true)
							{
								int num3 = num12;
								uint num4;
								switch ((num4 = (uint)(-(~num3) ^ (unchecked(~1884898492 * 447204809) + ((-722683965 * --155395672) ^ 0xBB7F4B) - ~(1022787248 - (--1598288197 + -1672392476))) ^ (0x760FB53E ^ ((-1808525375 + 1155050643) ^ -738343417)))) % 22)
								{
								case 6u:
									break;
								default:
									goto end_IL_043d;
								case 7u:
									goto IL_0517;
								case 21u:
									num = (EA4E5F9998F6455D = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
									num12 = -1018119579;
									continue;
								case 2u:
									goto IL_0558;
								case 11u:
									goto IL_056a;
								case 12u:
									num = (EA4E5F9998F6455D = _003CModule_003E.F84FA79ABE6944BB<int>(-1420849552));
									num12 = -1408041088;
									continue;
								case 17u:
									return;
								case 10u:
									awaiter = _9EBB7EA9BFDC4176;
									num12 = -1775824160;
									continue;
								case 19u:
								{
									ILogger val3 = _760EF57D5259421C._45BE54DAE6C14D66;
									string text2 = _003CModule_003E._58ECCB512F2A43AC<string>(-170999937);
									object[] array2 = new object[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)];
									array2[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)] = E8695B60E64149DE;
									_75E4DEBC07ED44CF(val3, text2, array2);
									num12 = -1337370726;
									continue;
								}
								case 14u:
									_9EBB7EA9BFDC4176 = default;
									num12 = ((int)num4 * -1450701694) ^ -1727114093;
									continue;
								case 16u:
									goto IL_0641;
								case 5u:
									goto IL_0676;
								case 13u:
									awaiter.GetResult();
									num12 = -1551487125;
									continue;
								case 3u:
									goto end_IL_00b9;
								case 15u:
									return;
								case 18u:
									_9EBB7EA9BFDC4176 = awaiter;
									A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num12 = ((int)num4 * -142301812) ^ -2067459177;
									continue;
								case 9u:
									_3D173AF4EB2E42BE = default;
									num12 = (int)(num4 * 112690246) ^ -861012525;
									continue;
								case 8u:
									A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num12 = (int)((num4 * 1010441203) ^ 0x7538B3F3);
									continue;
								case 20u:
								{
									awaiter3 = _467E0F1E14384C2A((object)C874322FB0AC4646, E8695B60E64149DE.m_SteamID, _7B62E3CE1BB34230).GetAwaiter();
									int num13;
									int num14;
									if (!awaiter3.IsCompleted)
									{
										num13 = 1707887138;
										num14 = num13;
									}
									else
									{
										num13 = 1424041923;
										num14 = num13;
									}
									num12 = num13 ^ (int)(num4 * 2070963069);
									continue;
								}
								case 4u:
									num = (EA4E5F9998F6455D = _003CModule_003E._3F57E81A62734AC2<int>(-845933485));
									_3D173AF4EB2E42BE = awaiter3;
									num12 = -105717652;
									continue;
								case 1u:
									num = (EA4E5F9998F6455D = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
									num12 = -1395731991;
									continue;
								case 0u:
									goto end_IL_043d;
								}
								break;
								IL_0676:
								CSteamID val4 = E8695B60E64149DE;
								IStringLocalizer val5 = _760EF57D5259421C._690D5F470A354A09;
								string text3 = _003CModule_003E._3F57E81A62734AC2<string>(1077327575);
								object[] array3 = new object[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)];
								array3[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)] = new
								{
									requiredLevel = obj.B704F62B092246E0,
									profileLevel = result2
								};
								awaiter = FEDAEC9636AA41D2((object)obj._00F2722AAB714B80(val4, _09DABA428BB14163((LocalizedString)_6D27F32F99344A75((object)val5, text3, array3))));
								int num15;
								if (awaiter.IsCompleted)
								{
									num12 = -1395731991;
									num15 = num12;
								}
								else
								{
									num12 = -2146302232;
									num15 = num12;
								}
								continue;
								IL_056a:
								result2 = awaiter3.GetResult();
								int num16;
								if (result2.HasValue)
								{
									num12 = -278631574;
									num16 = num12;
								}
								else
								{
									num12 = -1804166037;
									num16 = num12;
								}
								continue;
								IL_0517:
								int num17;
								if (num != _003CModule_003E._390073C602714496<int>(-1792641120))
								{
									num12 = -1607261420;
									num17 = num12;
								}
								else
								{
									num12 = -1322495248;
									num17 = num12;
								}
								continue;
								IL_0641:
								int? num18 = result2;
								value = obj.B704F62B092246E0;
								int num19;
								if (!(num18 < value))
								{
									num12 = -1337370726;
									num19 = num12;
								}
								else
								{
									num12 = -573705637;
									num19 = num12;
								}
							}
							goto IL_044f;
							IL_0558:
							awaiter3 = _3D173AF4EB2E42BE;
							num12 = -876550861;
							goto IL_0454;
							end_IL_043d:;
						}
						catch (Exception ex)
						{
							ILogger val6 = _760EF57D5259421C._45BE54DAE6C14D66;
							string text4 = _003CModule_003E._8B9C7B12B1AE4949<string>(1661994551);
							object[] array4 = new object[_003CModule_003E._58ECCB512F2A43AC<int>(1006217019)];
							array4[_003CModule_003E._58ECCB512F2A43AC<int>(352679804)] = E8695B60E64149DE;
							_05B4CA2A1A1D47F0(val6, ex, text4, array4);
						}
						goto IL_086c;
						IL_086c:
						if (obj._5EE94C99C4B447A6)
						{
							goto IL_0877;
						}
						goto IL_1003;
						IL_1003:
						if (!obj.A03666C7F0F14F83)
						{
							num20 = -1295119540;
							num21 = num20;
						}
						else
						{
							num20 = -1006876169;
							num21 = num20;
						}
						goto IL_087c;
						IL_022c:
						awaiter = _9EBB7EA9BFDC4176;
						_9EBB7EA9BFDC4176 = default;
						num = (EA4E5F9998F6455D = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
						num5 = -166194697;
						goto IL_00eb;
						IL_021b:
						awaiter2 = _2EA0DAC95CE5485C;
						num5 = -3435030;
						goto IL_00eb;
						IL_087c:
						while (true)
						{
							int num3 = num20;
							uint num4;
							SwitchToMainThreadAwaitable val11;
							double? num41;
							double? num30;
							double? num39;
							double num40;
							switch ((num4 = (uint)(-(~num3) ^ (unchecked(~1884898492 * 447204809) + ((-722683965 * --155395672) ^ 0xBB7F4B) - ~(1022787248 - (--1598288197 + -1672392476))) ^ (0x760FB53E ^ ((-1808525375 + 1155050643) ^ -738343417)))) % 75)
							{
							case 5u:
								break;
							default:
								goto end_IL_00b9;
							case 41u:
								awaiter.GetResult();
								num20 = -258109565;
								continue;
							case 18u:
							{
								LocalizedString val13 = (LocalizedString)_7E3001C189F841E6((object)_760EF57D5259421C._690D5F470A354A09, _003CModule_003E._8B9C7B12B1AE4949<string>(2100834480));
								_79076B31180C4296 = BF2699798A99424E((object)BF2699798A99424E((object)BF2699798A99424E((object)_79076B31180C4296, _003CModule_003E._3F57E81A62734AC2<string>(-219143236), ((object)E8695B60E64149DE/*cast due to constrained. prefix*/).ToString()), _003CModule_003E._3F57E81A62734AC2<string>(-1935430338), _09DABA428BB14163(val13)), _003CModule_003E._3F57E81A62734AC2<string>(244594445), num33.ToString());
								num20 = -1064304983;
								continue;
							}
							case 0u:
								_75E4DEBC07ED44CF(_760EF57D5259421C._45BE54DAE6C14D66, _003CModule_003E._390073C602714496<string>(1996302126), Array.Empty<object>());
								goto end_IL_00b9;
							case 47u:
								goto end_IL_00b9;
							case 8u:
								goto IL_0ae6;
							case 43u:
							{
								D92592EC668F4847((object)obj._6D09CFFF54324A80.E6CEB4BA92AA4EB5, E8695B60E64149DE.m_SteamID);
								ILogger val12 = _760EF57D5259421C._45BE54DAE6C14D66;
								string text7 = _003CModule_003E._58ECCB512F2A43AC<string>(869152408);
								object[] array7 = new object[_003CModule_003E._3F57E81A62734AC2<int>(1017304263)];
								array7[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)] = E8695B60E64149DE;
								_3B562B7D1EAE499B(val12, text7, array7);
								num20 = -488811796;
								continue;
							}
							case 10u:
								timeSpan2 = TimeSpan.Zero;
								num20 = (int)(num4 * 1388213110) ^ -1546236494;
								continue;
							case 24u:
							{
								val11 = UniTask.SwitchToMainThread(default(CancellationToken));
								awaiter4 = val11.GetAwaiter();
								int num48;
								int num49;
								if (!awaiter4.IsCompleted)
								{
									num48 = -1664957705;
									num49 = num48;
								}
								else
								{
									num48 = -551699104;
									num49 = num48;
								}
								num20 = num48 ^ (int)(num4 * 466525396);
								continue;
							}
							case 68u:
							{
								int num31;
								int num32;
								if (!awaiter.IsCompleted)
								{
									num31 = -820931483;
									num32 = num31;
								}
								else
								{
									num31 = -935527443;
									num32 = num31;
								}
								num20 = num31 ^ ((int)num4 * -980934999);
								continue;
							}
							case 42u:
								num = (EA4E5F9998F6455D = _003CModule_003E._8B9C7B12B1AE4949<int>(861409582));
								_9EBB7EA9BFDC4176 = awaiter;
								A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 31u:
								_75E4DEBC07ED44CF(_760EF57D5259421C._45BE54DAE6C14D66, _003CModule_003E._8B9C7B12B1AE4949<string>(-1144507328), Array.Empty<object>());
								goto end_IL_00b9;
							case 53u:
							{
								int num44;
								int num45;
								if (!obj._2144AF146DD6492F)
								{
									num44 = -1524026863;
									num45 = num44;
								}
								else
								{
									num44 = -1545055823;
									num45 = num44;
								}
								num20 = num44 ^ ((int)num4 * -1400482736);
								continue;
							}
							case 55u:
								obj._4DAEF03217FC4B55.TryRemove(E8695B60E64149DE, out value);
								num20 = -392631403;
								continue;
							case 36u:
								goto IL_0ca3;
							case 11u:
								num = (EA4E5F9998F6455D = _003CModule_003E._8B9C7B12B1AE4949<int>(1358231899));
								_9EBB7EA9BFDC4176 = awaiter;
								A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num20 = -1396366514;
								continue;
							case 23u:
							{
								awaiter = FEDAEC9636AA41D2((object)obj._00F2722AAB714B80(E8695B60E64149DE, _09DABA428BB14163(val8)));
								int num36;
								int num37;
								if (awaiter.IsCompleted)
								{
									num36 = 1472407542;
									num37 = num36;
								}
								else
								{
									num36 = 2088440014;
									num37 = num36;
								}
								num20 = num36 ^ ((int)num4 * -1286298440);
								continue;
							}
							case 9u:
								return;
							case 33u:
							{
								val11 = UniTask.SwitchToMainThread(default(CancellationToken));
								awaiter4 = val11.GetAwaiter();
								int num27;
								int num28;
								if (!awaiter4.IsCompleted)
								{
									num27 = 1170031885;
									num28 = num27;
								}
								else
								{
									num27 = 508532661;
									num28 = num27;
								}
								num20 = num27 ^ (int)(num4 * 1772865153);
								continue;
							}
							case 40u:
								awaiter.GetResult();
								goto end_IL_00b9;
							case 51u:
								dateTime = _04C4787F8EC54889((object)_37E7D64D689C486E);
								num20 = ((int)num4 * -1234913762) ^ -1119444555;
								continue;
							case 17u:
								awaiter = FEDAEC9636AA41D2((object)obj._00F2722AAB714B80(E8695B60E64149DE, _09DABA428BB14163((LocalizedString)_7E3001C189F841E6((object)_760EF57D5259421C._690D5F470A354A09, _003CModule_003E._58ECCB512F2A43AC<string>(307506808)))));
								num20 = -1073359074;
								continue;
							case 16u:
								num24 = obj._5AD6136E239447EF;
								num20 = -936526920;
								continue;
							case 69u:
								num = (EA4E5F9998F6455D = _003CModule_003E.F84FA79ABE6944BB<int>(604638872));
								num20 = -1257210634;
								continue;
							case 56u:
								goto IL_0e40;
							case 25u:
								num50 = (int)_355917CC9F26446F(timeSpan2.TotalSeconds);
								_3B562B7D1EAE499B(_760EF57D5259421C._45BE54DAE6C14D66, ACEA010E75514EE1(_42D0B4375C7D444D(_003CModule_003E.F84FA79ABE6944BB<string>(-1526706142), (object)E8695B60E64149DE, (object)timeSpan.TotalDays, (object)obj._5C067711BDF14CDB), A0BE23902AB54199(_003CModule_003E._3F57E81A62734AC2<string>(-2125502559), (object)timeSpan2.TotalDays, (object)num50)), Array.Empty<object>());
								val14 = (LocalizedString)_7E3001C189F841E6((object)_760EF57D5259421C._690D5F470A354A09, _003CModule_003E._8B9C7B12B1AE4949<string>(-191347184));
								num20 = -1590037518;
								continue;
							case 64u:
								num = (EA4E5F9998F6455D = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
								num20 = -1948208704;
								continue;
							case 73u:
								awaiter4.GetResult();
								num20 = -1098018923;
								continue;
							case 37u:
								num = (EA4E5F9998F6455D = _003CModule_003E._58ECCB512F2A43AC<int>(1751645849));
								_9EBB7EA9BFDC4176 = awaiter;
								A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num20 = -1030384920;
								continue;
							case 60u:
								_79076B31180C4296 = BF2699798A99424E((object)BF2699798A99424E((object)BF2699798A99424E((object)text8, _003CModule_003E._390073C602714496<string>(1426961237), ((object)E8695B60E64149DE/*cast due to constrained. prefix*/).ToString()), _003CModule_003E._390073C602714496<string>(855100731), _09DABA428BB14163(val14)), _003CModule_003E.F84FA79ABE6944BB<string>(1098621810), num50.ToString());
								num20 = -1019749243;
								continue;
							case 71u:
							{
								text8 = obj._6A2D94936E18427C;
								int num46;
								int num47;
								if (_42378E35EF674E05(text8))
								{
									num46 = 2139193446;
									num47 = num46;
								}
								else
								{
									num46 = 401883869;
									num47 = num46;
								}
								num20 = num46 ^ ((int)num4 * -1553172160);
								continue;
							}
							case 39u:
								goto IL_1003;
							case 46u:
							{
								int num42;
								int num43;
								if (awaiter.IsCompleted)
								{
									num42 = 1010229458;
									num43 = num42;
								}
								else
								{
									num42 = 538392835;
									num43 = num42;
								}
								num20 = num42 ^ (int)(num4 * 1494684215);
								continue;
							}
							case 1u:
								_9EBB7EA9BFDC4176 = awaiter;
								num20 = (int)((num4 * 1495238374) ^ 0x79EF173E);
								continue;
							case 13u:
								num29 = _66EBE49EF6274CAC((object)e108E4DE5C084B2A);
								num20 = ((int)num4 * -1716287734) ^ 0x523AEB13;
								continue;
							case 67u:
								num = (EA4E5F9998F6455D = _003CModule_003E.F84FA79ABE6944BB<int>(175499283));
								_64262815596D45B2 = awaiter4;
								num20 = -1766058576;
								continue;
							case 6u:
								num38 = null;
								num20 = (int)((num4 * 162709047) ^ 0x6434B4C7);
								continue;
							case 61u:
								goto IL_10bd;
							case 28u:
								num41 = null;
								goto IL_10ea;
							case 29u:
								num30 = num38;
								goto IL_1109;
							case 19u:
								goto IL_112d;
							case 3u:
								goto IL_1176;
							case 21u:
							{
								int num34;
								int num35;
								if (!dateTime.HasValue)
								{
									num34 = 794213838;
									num35 = num34;
								}
								else
								{
									num34 = 738917671;
									num35 = num34;
								}
								num20 = num34 ^ (int)(num4 * 1666031856);
								continue;
							}
							case 52u:
								_2836350B44914A6E(_79076B31180C4296);
								_79076B31180C4296 = null;
								num20 = ((int)num4 * -662675375) ^ -677292839;
								continue;
							case 44u:
								_75E4DEBC07ED44CF(_760EF57D5259421C._45BE54DAE6C14D66, _8580B61213774B90(_003CModule_003E.F84FA79ABE6944BB<string>(-780285596), (object)E8695B60E64149DE), Array.Empty<object>());
								num20 = -19055032;
								continue;
							case 58u:
								A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted<Awaiter, BF97F1769A9C4065>(ref awaiter4, ref this);
								num20 = (int)(num4 * 2073160801) ^ -1092327226;
								continue;
							case 66u:
								_3B562B7D1EAE499B(_760EF57D5259421C._45BE54DAE6C14D66, ACEA010E75514EE1(_003CModule_003E._3F57E81A62734AC2<string>(-1997062882), _79076B31180C4296), Array.Empty<object>());
								num20 = -548186115;
								continue;
							case 45u:
								num33 = (int)num29.Value;
								num20 = ((int)num4 * -1101043254) ^ -1006991961;
								continue;
							case 27u:
								if (num29.HasValue)
								{
									num30 = num24 - num29.GetValueOrDefault();
									goto IL_1109;
								}
								num20 = (int)((num4 * 1802325258) ^ 0x121AFFC6);
								continue;
							case 32u:
								num = (EA4E5F9998F6455D = _003CModule_003E._390073C602714496<int>(2046494864));
								num20 = -238574881;
								continue;
							case 63u:
							{
								_79076B31180C4296 = obj._354FD53BD2984496;
								int num25;
								int num26;
								if (_42378E35EF674E05(_79076B31180C4296))
								{
									num25 = 1306612460;
									num26 = num25;
								}
								else
								{
									num25 = 537617698;
									num26 = num25;
								}
								num20 = num25 ^ ((int)num4 * -1690555364);
								continue;
							}
							case 65u:
							{
								CSteamID val9 = E8695B60E64149DE;
								IStringLocalizer val10 = _760EF57D5259421C._690D5F470A354A09;
								string text6 = _003CModule_003E._58ECCB512F2A43AC<string>(1516512077);
								object[] array6 = new object[_003CModule_003E._3F57E81A62734AC2<int>(1017304263)];
								array6[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)] = new
								{
									CHECK_REQUIRED_HOURS = obj._5AD6136E239447EF,
									HoursOnRecord = _66EBE49EF6274CAC((object)e108E4DE5C084B2A)
								};
								awaiter = FEDAEC9636AA41D2((object)obj._00F2722AAB714B80(val9, _09DABA428BB14163((LocalizedString)_6D27F32F99344A75((object)val10, text6, array6))));
								num20 = -1438624518;
								continue;
							}
							case 12u:
								goto end_IL_00b9;
							case 2u:
							{
								int num22;
								int num23;
								if (!obj.F06D2A0007D34271)
								{
									num22 = -601356610;
									num23 = num22;
								}
								else
								{
									num22 = -1070934993;
									num23 = num22;
								}
								num20 = num22 ^ ((int)num4 * -1375757222);
								continue;
							}
							case 15u:
								_9EBB7EA9BFDC4176 = default;
								num20 = ((int)num4 * -72409430) ^ -1655114876;
								continue;
							case 26u:
								awaiter.GetResult();
								num20 = -1358282124;
								continue;
							case 30u:
								goto IL_13bf;
							case 54u:
								goto end_IL_00b9;
							case 4u:
								return;
							case 35u:
								A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted<Awaiter, BF97F1769A9C4065>(ref awaiter4, ref this);
								return;
							case 59u:
								_64262815596D45B2 = default;
								num = (EA4E5F9998F6455D = _003CModule_003E._390073C602714496<int>(-736908096));
								num20 = -1266004940;
								continue;
							case 70u:
								goto IL_147a;
							case 72u:
								awaiter4.GetResult();
								_2836350B44914A6E(_79076B31180C4296);
								num20 = -1127741699;
								continue;
							case 74u:
							{
								IStringLocalizer val7 = _760EF57D5259421C._690D5F470A354A09;
								string text5 = _003CModule_003E.F84FA79ABE6944BB<string>(-1153495869);
								object[] array5 = new object[_003CModule_003E._390073C602714496<int>(-250964212)];
								array5[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)] = new
								{
									DaysRequired = obj._5C067711BDF14CDB,
									AccountHours = timeSpan.TotalDays
								};
								val8 = (LocalizedString)_6D27F32F99344A75((object)val7, text5, array5);
								num20 = -1195890519;
								continue;
							}
							case 38u:
								num = (EA4E5F9998F6455D = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
								num20 = -2002149298;
								continue;
							case 57u:
								goto IL_1552;
							case 7u:
								goto end_IL_00b9;
							case 50u:
								_64262815596D45B2 = awaiter4;
								num20 = (int)((num4 * 1780841475) ^ 0x604FDF51);
								continue;
							case 49u:
								A9582FA8AA8C4BE9.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								return;
							case 62u:
								awaiter.GetResult();
								goto end_IL_00b9;
							case 48u:
								goto IL_15fc;
							case 22u:
								goto IL_161a;
							case 20u:
								return;
							case 34u:
								goto IL_1664;
							case 14u:
								goto end_IL_00b9;
								IL_1109:
								num39 = num30;
								num40 = _003CModule_003E._8B9C7B12B1AE4949<int>(1904029701);
								if (num39.HasValue)
								{
									num41 = num39.GetValueOrDefault() * num40;
									goto IL_10ea;
								}
								num20 = -121587954;
								continue;
								IL_10ea:
								num29 = num41;
								num20 = -200460388;
								continue;
							}
							break;
							IL_1664:
							timeSpan2 = TimeSpan.FromDays(obj._5C067711BDF14CDB) - timeSpan;
							int num51;
							if (timeSpan2.TotalSeconds < _003CModule_003E._8B9C7B12B1AE4949<double>(-1418278019))
							{
								num20 = -1216106409;
								num51 = num20;
							}
							else
							{
								num20 = -908343568;
								num51 = num20;
							}
							continue;
							IL_147a:
							awaiter = FEDAEC9636AA41D2((object)obj._00F2722AAB714B80(E8695B60E64149DE, _09DABA428BB14163((LocalizedString)_7E3001C189F841E6((object)_760EF57D5259421C._690D5F470A354A09, _003CModule_003E._3F57E81A62734AC2<string>(819985697)))));
							int num52;
							if (awaiter.IsCompleted)
							{
								num20 = -1980030172;
								num52 = num20;
							}
							else
							{
								num20 = -30497157;
								num52 = num20;
							}
							continue;
							IL_112d:
							e108E4DE5C084B2A = E574461FBCD341B4((object)_37E7D64D689C486E).FirstOrDefault([MethodImpl(MethodImplOptions.NoInlining)] (FCE22BD5614B4582.E108E4DE5C084B2A P_0) =>
							{
								object obj2 = _960BDDEF64FC434B._2721EFBBE9A34347((object)P_0);
								return (obj2 == null) ? ((byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0) : _960BDDEF64FC434B._16D65EA37F0D4A24((object)_960BDDEF64FC434B.C903AFB486594E28(obj2), _003CModule_003E._390073C602714496<string>(1848985496));
							});
							int num53;
							if (e108E4DE5C084B2A == null)
							{
								num20 = -1167273246;
								num53 = num20;
							}
							else
							{
								num20 = -381332333;
								num53 = num20;
							}
							continue;
							IL_1552:
							DateTime utcNow = DateTime.UtcNow;
							dateTime = _04C4787F8EC54889((object)_37E7D64D689C486E);
							timeSpan = utcNow - dateTime.Value;
							int num54;
							if (timeSpan.TotalDays < (double)obj._5C067711BDF14CDB)
							{
								num20 = -1723055310;
								num54 = num20;
							}
							else
							{
								num20 = -1295119540;
								num54 = num20;
							}
							continue;
							IL_0ca3:
							int num55;
							if (E574461FBCD341B4((object)_37E7D64D689C486E).Count < _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
							{
								num20 = -1665416796;
								num55 = num20;
							}
							else
							{
								num20 = -1072045710;
								num55 = num20;
							}
							continue;
							IL_13bf:
							int num56;
							if (_66EBE49EF6274CAC((object)e108E4DE5C084B2A) < (double)obj._5AD6136E239447EF)
							{
								num20 = -1915558441;
								num56 = num20;
							}
							else
							{
								num20 = -280707601;
								num56 = num20;
							}
						}
						goto IL_0877;
						IL_161a:
						awaiter = _9EBB7EA9BFDC4176;
						_9EBB7EA9BFDC4176 = default;
						num = (EA4E5F9998F6455D = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
						num20 = -1459554402;
						goto IL_087c;
						IL_15fc:
						awaiter4 = _64262815596D45B2;
						_64262815596D45B2 = default;
						num20 = -638143393;
						goto IL_087c;
						IL_1176:
						awaiter4 = _64262815596D45B2;
						num20 = -527000416;
						goto IL_087c;
						IL_10bd:
						awaiter = _9EBB7EA9BFDC4176;
						num20 = -130483163;
						goto IL_087c;
						IL_0e40:
						awaiter = _9EBB7EA9BFDC4176;
						_9EBB7EA9BFDC4176 = default;
						num = (EA4E5F9998F6455D = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
						num20 = -1980030172;
						goto IL_087c;
						IL_0ae6:
						awaiter = _9EBB7EA9BFDC4176;
						_9EBB7EA9BFDC4176 = default;
						num = (EA4E5F9998F6455D = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
						num20 = -1683658851;
						goto IL_087c;
						IL_0877:
						num20 = -662267150;
						goto IL_087c;
						end_IL_00b9:
						break;
					}
				}
				finally
				{
					if (num < _003CModule_003E.F84FA79ABE6944BB<int>(1398637845))
					{
						while (true)
						{
							IL_16b9:
							int num57 = -963912920;
							while (true)
							{
								int num3 = num57;
								uint num4;
								switch ((num4 = (uint)(-(~num3) ^ (unchecked(~1884898492 * 447204809) + ((-722683965 * --155395672) ^ 0xBB7F4B) - ~(1022787248 - (--1598288197 + -1672392476))) ^ (0x760FB53E ^ ((-1808525375 + 1155050643) ^ -738343417)))) % 4)
								{
								case 3u:
									break;
								default:
									goto end_IL_16be;
								case 2u:
								{
									int num58;
									int num59;
									if (C874322FB0AC4646 != null)
									{
										num58 = -1098782785;
										num59 = num58;
									}
									else
									{
										num58 = -219123556;
										num59 = num58;
									}
									num57 = num58 ^ ((int)num4 * -822915125);
									continue;
								}
								case 1u:
									_1135E20DA5C54549((object)C874322FB0AC4646);
									num57 = (int)(num4 * 1748742851) ^ -1366110487;
									continue;
								case 0u:
									goto end_IL_16be;
								}
								goto IL_16b9;
								continue;
								end_IL_16be:
								break;
							}
							break;
						}
					}
				}
			}
			catch (Exception exception)
			{
				EA4E5F9998F6455D = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
				while (true)
				{
					int num60 = -684436132;
					while (true)
					{
						int num3 = num60;
						uint num4;
						switch ((num4 = (uint)(-(~num3) ^ (unchecked(~1884898492 * 447204809) + ((-722683965 * --155395672) ^ 0xBB7F4B) - ~(1022787248 - (--1598288197 + -1672392476))) ^ (0x760FB53E ^ ((-1808525375 + 1155050643) ^ -738343417)))) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 2u:
							goto IL_1805;
						case 1u:
							return;
						}
						break;
						IL_1805:
						C874322FB0AC4646 = null;
						_37E7D64D689C486E = null;
						A9582FA8AA8C4BE9.SetException(exception);
						num60 = (int)(num4 * 657107292) ^ -149634366;
					}
				}
			}
			EA4E5F9998F6455D = _003CModule_003E._390073C602714496<int>(818201983);
			while (true)
			{
				int num61 = -779986799;
				while (true)
				{
					int num3 = num61;
					uint num4;
					switch ((num4 = (uint)(-(~num3) ^ (unchecked(~1884898492 * 447204809) + ((-722683965 * --155395672) ^ 0xBB7F4B) - ~(1022787248 - (--1598288197 + -1672392476))) ^ (0x760FB53E ^ ((-1808525375 + 1155050643) ^ -738343417)))) % 5)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						C874322FB0AC4646 = null;
						num61 = (int)((num4 * 1527791521) ^ 0x4188EE76);
						continue;
					case 4u:
						A9582FA8AA8C4BE9.SetResult();
						num61 = (int)((num4 * 961408502) ^ 0x5E5D3966);
						continue;
					case 1u:
						_37E7D64D689C486E = null;
						num61 = ((int)num4 * -1013620624) ^ -209399757;
						continue;
					case 3u:
						return;
					}
					break;
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
			A9582FA8AA8C4BE9.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object B8560B26CD88464D(object P_0)
		{
			return new F131A7E07B2C4332((HttpClient?)P_0);
		}

		static Task<FCE22BD5614B4582> C07ADDDB3BE3439C(object P_0, ulong P_1, CancellationToken P_2)
		{
			return ((F131A7E07B2C4332)P_0).EA827CA62FD14532(P_1, P_2);
		}

		static string ECE4813FED1F4EC2(object P_0)
		{
			return ((FCE22BD5614B4582)P_0)._8FAA38B56F924636;
		}

		static object _6D27F32F99344A75(object P_0, string P_1, object[] P_2)
		{
			return ((IStringLocalizer)P_0)[P_1, P_2];
		}

		static string _09DABA428BB14163(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}

		static TaskAwaiter FEDAEC9636AA41D2(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static Task<int?> _467E0F1E14384C2A(object P_0, ulong P_1, CancellationToken P_2)
		{
			return ((F131A7E07B2C4332)P_0).AAC4F23C390A4550(P_1, P_2);
		}

		static void _75E4DEBC07ED44CF(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}

		static void _05B4CA2A1A1D47F0(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}

		static IReadOnlyList<FCE22BD5614B4582.E108E4DE5C084B2A> E574461FBCD341B4(object P_0)
		{
			return ((FCE22BD5614B4582)P_0).FAD96EB78A304ED9;
		}

		static object _7E3001C189F841E6(object P_0, string P_1)
		{
			return ((IStringLocalizer)P_0)[P_1];
		}

		static double? _66EBE49EF6274CAC(object P_0)
		{
			return ((FCE22BD5614B4582.E108E4DE5C084B2A)P_0).DF4871D9FFD448B6;
		}

		static bool _42378E35EF674E05(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}

		static string BF2699798A99424E(object P_0, string P_1, string P_2)
		{
			return ((string)P_0).Replace(P_1, P_2);
		}

		static void _2836350B44914A6E(string P_0)
		{
			_64A4BBC5E4CE4EE1.E6DC166DE03C47D7(P_0);
		}

		static DateTime? _04C4787F8EC54889(object P_0)
		{
			return ((FCE22BD5614B4582)P_0).B938875111A54E87;
		}

		static string _8580B61213774B90(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static double _355917CC9F26446F(double P_0)
		{
			return Math.Ceiling(P_0);
		}

		static string _42D0B4375C7D444D(string P_0, object P_1, object P_2, object P_3)
		{
			return string.Format(P_0, P_1, P_2, P_3);
		}

		static string A0BE23902AB54199(string P_0, object P_1, object P_2)
		{
			return string.Format(P_0, P_1, P_2);
		}

		static string ACEA010E75514EE1(string P_0, string P_1)
		{
			return P_0 + P_1;
		}

		static void _3B562B7D1EAE499B(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogDebug(P_0, P_1, P_2);
		}

		static void D92592EC668F4847(object P_0, ulong P_1)
		{
			((_05B7A84E8227463B)P_0).F66ACEBD262741E3(P_1);
		}

		static void _1135E20DA5C54549(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _086F729B788E40E0 : IAsyncStateMachine
	{
		public int FFC09F29A4754047;

		public AsyncTaskMethodBuilder _9333568E84264457;

		public _7FE330C6E84D4C74 ED7C8657A9B745D2;

		public CSteamID _2A0330243DAC4342;

		public string _469A217CC85045F5;

		private string _10A71A792620476B;

		private string D48818696FA249F5;

		private string F9C98ED9781F4079;

		private TaskAwaiter _592887A90CB24BD5;

		private string FF1CAE5AC8FC4B87;

		private Awaiter _0D879CFF149E4E02;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0552: Unknown result type (might be due to invalid IL or missing references)
			//IL_0557: Unknown result type (might be due to invalid IL or missing references)
			//IL_074a: Unknown result type (might be due to invalid IL or missing references)
			//IL_074f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0753: Unknown result type (might be due to invalid IL or missing references)
			//IL_0758: Unknown result type (might be due to invalid IL or missing references)
			//IL_0464: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_056d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0774: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			int num = FFC09F29A4754047;
			_7FE330C6E84D4C74 obj = ED7C8657A9B745D2;
			try
			{
				int num2;
				Awaiter awaiter = default;
				SwitchToMainThreadAwaitable val = default;
				TaskAwaiter awaiter2 = default;
				CancellationToken cancellationToken = default;
				int num5 = default;
				SteamPlayer val3 = default;
				int num6 = default;
				switch (num)
				{
				default:
					num2 = -814595723;
					goto IL_0025;
				case 1:
					goto IL_012b;
				case 2:
					goto IL_04ad;
				case 0:
					goto IL_0582;
					IL_0025:
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(~(-((1970570816 - (-num3 - --39489386)) ^ 0x2D905F) ^ -1209454855 ^ -1466751974))) % 45)
						{
						case 2u:
							break;
						case 36u:
							awaiter = val.GetAwaiter();
							num2 = (int)((num4 * 1950709175) ^ 0xBF5043A);
							continue;
						case 29u:
							goto IL_012b;
						case 23u:
							awaiter2.GetResult();
							num2 = -268500178;
							continue;
						case 15u:
							num = (FFC09F29A4754047 = _003CModule_003E._3F57E81A62734AC2<int>(-845933485));
							_0D879CFF149E4E02 = awaiter;
							_9333568E84264457.AwaitUnsafeOnCompleted<Awaiter, _086F729B788E40E0>(ref awaiter, ref this);
							return;
						case 41u:
							num = (FFC09F29A4754047 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = -372243452;
							continue;
						case 28u:
						{
							int num13;
							int num14;
							if (awaiter.IsCompleted)
							{
								num13 = 1472210938;
								num14 = num13;
							}
							else
							{
								num13 = 2104083589;
								num14 = num13;
							}
							num2 = num13 ^ (int)(num4 * 833497254);
							continue;
						}
						case 5u:
						{
							ILogger val5 = _760EF57D5259421C._45BE54DAE6C14D66;
							string text3 = _003CModule_003E._8B9C7B12B1AE4949<string>(-1254467502);
							object[] array3 = new object[_003CModule_003E._58ECCB512F2A43AC<int>(1006217019)];
							array3[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)] = _469A217CC85045F5;
							_5A359980DA2B4EDC(val5, text3, array3);
							goto end_IL_000f;
						}
						case 21u:
							_592887A90CB24BD5 = default;
							num2 = ((int)num4 * -1549633363) ^ -1183158790;
							continue;
						case 16u:
							FF1CAE5AC8FC4B87 = _8E4369B4CB1E4895((object)_8E4369B4CB1E4895((object)_10A71A792620476B, _003CModule_003E._58ECCB512F2A43AC<string>(-429685294), _003CModule_003E._3F57E81A62734AC2<string>(-2142288665)), _003CModule_003E._58ECCB512F2A43AC<string>(1236718868), D48818696FA249F5);
							cancellationToken = default;
							num2 = -876932555;
							continue;
						case 7u:
							return;
						case 44u:
							goto IL_02aa;
						case 6u:
							num = (FFC09F29A4754047 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563));
							num2 = -1418170947;
							continue;
						case 37u:
							_050CC66EB03F4BF4((ITransportConnection)F9D7E1154BF6400A((object)Provider.pending[num5]), (ESteamRejection)_003CModule_003E.F84FA79ABE6944BB<int>(-1326352113), FF1CAE5AC8FC4B87);
							num2 = 75287186;
							continue;
						case 0u:
							num = (FFC09F29A4754047 = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num2 = 3596687;
							continue;
						case 3u:
							num5 += _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
							num2 = -1490369864;
							continue;
						case 17u:
							_9333568E84264457.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							num2 = (int)((num4 * 275324122) ^ 0x63304501);
							continue;
						case 39u:
							goto IL_0375;
						case 43u:
							_592887A90CB24BD5 = awaiter2;
							num2 = ((int)num4 * -1164914423) ^ 0x3C841798;
							continue;
						case 30u:
							F9C98ED9781F4079 = _8E4369B4CB1E4895((object)_8E4369B4CB1E4895((object)_10A71A792620476B, _003CModule_003E._3F57E81A62734AC2<string>(-1935430338), D48818696FA249F5), _003CModule_003E._8B9C7B12B1AE4949<string>(1804948987), ((object)_2A0330243DAC4342/*cast due to constrained. prefix*/).ToString());
							num2 = -742896778;
							continue;
						case 26u:
							awaiter.GetResult();
							num2 = -1125243976;
							continue;
						case 8u:
						{
							int num15;
							int num16;
							if (awaiter2.IsCompleted)
							{
								num15 = 1577170747;
								num16 = num15;
							}
							else
							{
								num15 = -1197085501;
								num16 = num15;
							}
							num2 = num15 ^ (int)(num4 * 1699698693);
							continue;
						}
						case 1u:
						{
							int num11;
							int num12;
							if (val3 != null)
							{
								num11 = -1795281237;
								num12 = num11;
							}
							else
							{
								num11 = -933202533;
								num12 = num11;
							}
							num2 = num11 ^ (int)(num4 * 455484397);
							continue;
						}
						case 22u:
							_742118B280194E00(_2A0330243DAC4342, FF1CAE5AC8FC4B87);
							num2 = (int)(num4 * 388718909) ^ -179225410;
							continue;
						case 9u:
							num = (FFC09F29A4754047 = _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
							_0D879CFF149E4E02 = awaiter;
							num2 = -508237505;
							continue;
						case 20u:
							goto IL_04ad;
						case 19u:
						{
							IStringLocalizer val4 = _760EF57D5259421C._690D5F470A354A09;
							string text2 = _003CModule_003E._58ECCB512F2A43AC<string>(775201611);
							object[] array2 = new object[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)];
							array2[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)] = new
							{
								reason = _469A217CC85045F5
							};
							D48818696FA249F5 = CEA00EA0CBE842A1((LocalizedString)_04B479D52F134FC7((object)val4, text2, array2));
							obj._4DAEF03217FC4B55.TryRemove(_2A0330243DAC4342, out var _);
							num2 = -1284790763;
							continue;
						}
						case 10u:
							cancellationToken = default;
							val = UniTask.SwitchToMainThread(cancellationToken);
							num2 = ((int)num4 * -668059809) ^ -432857097;
							continue;
						case 38u:
							val3 = (SteamPlayer)FEC5E3B54AA54028(_2A0330243DAC4342);
							num2 = -132269910;
							continue;
						case 25u:
							goto IL_0582;
						case 12u:
						{
							int num9;
							int num10;
							if (num6 >= obj._771C560818654551)
							{
								num9 = 168908446;
								num10 = num9;
							}
							else
							{
								num9 = 1685439397;
								num10 = num9;
							}
							num2 = num9 ^ (int)(num4 * 815866668);
							continue;
						}
						case 42u:
							goto IL_05ba;
						case 35u:
							_10A71A792620476B = obj.E7C9184C9FD54813;
							num2 = (int)((num4 * 1431291805) ^ 0x7CBFD71A);
							continue;
						case 24u:
							awaiter2 = _69DBAACB976C4E59(B55E3DA395954C4C((object)obj._1E60D2A7E45A4FC2, _8263522A574841DB(val3), D48818696FA249F5, ((num6 < obj._771C560818654551) ? 1 : 0) == _003CModule_003E._3F57E81A62734AC2<int>(-1803194042), _003CModule_003E._3F57E81A62734AC2<string>(-2135851737)));
							num2 = -1428795667;
							continue;
						case 27u:
						{
							_10A71A792620476B = obj.F3D0104E762244DA;
							IStringLocalizer val2 = _760EF57D5259421C._690D5F470A354A09;
							string text = _003CModule_003E._390073C602714496<string>(-986527033);
							object[] array = new object[_003CModule_003E.F84FA79ABE6944BB<int>(1741630884)];
							array[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)] = new
							{
								reason = _469A217CC85045F5,
								failCount = num6,
								maxFailAttempts = obj._771C560818654551
							};
							D48818696FA249F5 = CEA00EA0CBE842A1((LocalizedString)_04B479D52F134FC7((object)val2, text, array));
							num2 = -1284790763;
							continue;
						}
						case 14u:
							goto IL_06c7;
						case 34u:
							goto end_IL_000f;
						case 32u:
						{
							int num7;
							int num8;
							if (awaiter.IsCompleted)
							{
								num7 = 1997340985;
								num8 = num7;
							}
							else
							{
								num7 = 906906759;
								num8 = num7;
							}
							num2 = num7 ^ (int)(num4 * 47114515);
							continue;
						}
						case 33u:
							_9333568E84264457.AwaitUnsafeOnCompleted<Awaiter, _086F729B788E40E0>(ref awaiter, ref this);
							num2 = (int)(num4 * 2147389178) ^ -1795373802;
							continue;
						case 13u:
							val = UniTask.SwitchToMainThread(cancellationToken);
							awaiter = val.GetAwaiter();
							num2 = (int)(num4 * 1509391481) ^ -2045945774;
							continue;
						case 40u:
							num6 = obj._4DAEF03217FC4B55.AddOrUpdate(_2A0330243DAC4342, _003CModule_003E._8B9C7B12B1AE4949<int>(350091668), [MethodImpl(MethodImplOptions.NoInlining)] (CSteamID P_0, int P_1) => P_1 + _003CModule_003E._3F57E81A62734AC2<int>(1017304263));
							num2 = -1399836673;
							continue;
						case 18u:
							num5 = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845);
							num2 = 30153460;
							continue;
						case 31u:
							num2 = ((int)num4 * -824229995) ^ 0x365061E7;
							continue;
						case 11u:
							return;
						default:
							awaiter.GetResult();
							CA454FABAC214F0C(F9C98ED9781F4079);
							goto end_IL_000f;
						}
						break;
						IL_06c7:
						int num17;
						if (num5 >= Provider.pending.Count)
						{
							num2 = -22261938;
							num17 = num2;
						}
						else
						{
							num2 = -1679857568;
							num17 = num2;
						}
						continue;
						IL_0375:
						int num18;
						if (_8FD6298051824F07((object)_10A71A792620476B, _003CModule_003E.F84FA79ABE6944BB<string>(634759835)))
						{
							num2 = -1591687621;
							num18 = num2;
						}
						else
						{
							num2 = -185047104;
							num18 = num2;
						}
						continue;
						IL_02aa:
						int num19;
						if (!_618B8CF4AE1F4769(_10A71A792620476B))
						{
							num2 = -1813240462;
							num19 = num2;
						}
						else
						{
							num2 = -131262278;
							num19 = num2;
						}
						continue;
						IL_05ba:
						CSteamID val6 = _4F76543B6AD442E5(C0FC6C8F2B1F41C1((object)Provider.pending[num5]));
						int num20;
						if (!val6.Equals(_2A0330243DAC4342))
						{
							num2 = 75287186;
							num20 = num2;
						}
						else
						{
							num2 = -203464195;
							num20 = num2;
						}
					}
					goto default;
					IL_0582:
					awaiter2 = _592887A90CB24BD5;
					num2 = -93799515;
					goto IL_0025;
					IL_04ad:
					awaiter = _0D879CFF149E4E02;
					_0D879CFF149E4E02 = default;
					num = (FFC09F29A4754047 = _003CModule_003E._390073C602714496<int>(-736908096));
					num2 = -1472821221;
					goto IL_0025;
					IL_012b:
					awaiter = _0D879CFF149E4E02;
					_0D879CFF149E4E02 = default;
					num2 = -1557706351;
					goto IL_0025;
					end_IL_000f:
					break;
				}
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num21 = -1253970704;
					while (true)
					{
						int num3 = num21;
						uint num4;
						switch ((num4 = (uint)(~(-((1970570816 - (-num3 - --39489386)) ^ 0x2D905F) ^ -1209454855 ^ -1466751974))) % 5)
						{
						case 3u:
							break;
						case 4u:
							F9C98ED9781F4079 = null;
							num21 = ((int)num4 * -1770881421) ^ -1292529122;
							continue;
						case 2u:
							D48818696FA249F5 = null;
							num21 = ((int)num4 * -1781398127) ^ -1413017871;
							continue;
						case 1u:
							FFC09F29A4754047 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
							_10A71A792620476B = null;
							num21 = -1980566980;
							continue;
						default:
							_9333568E84264457.SetException(exception);
							return;
						}
						break;
					}
				}
			}
			FFC09F29A4754047 = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
			while (true)
			{
				int num22 = -1698710306;
				while (true)
				{
					int num3 = num22;
					uint num4;
					switch ((num4 = (uint)(~(-((1970570816 - (-num3 - --39489386)) ^ 0x2D905F) ^ -1209454855 ^ -1466751974))) % 4)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						_10A71A792620476B = null;
						D48818696FA249F5 = null;
						num22 = ((int)num4 * -255978777) ^ -1077709652;
						continue;
					case 2u:
						F9C98ED9781F4079 = null;
						_9333568E84264457.SetResult();
						num22 = (int)((num4 * 848404653) ^ 0x7F7C20DE);
						continue;
					case 3u:
						return;
					}
					break;
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
			_9333568E84264457.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _04B479D52F134FC7(object P_0, string P_1, object[] P_2)
		{
			return ((IStringLocalizer)P_0)[P_1, P_2];
		}

		static string CEA00EA0CBE842A1(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}

		static bool _618B8CF4AE1F4769(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}

		static void _5A359980DA2B4EDC(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}

		static object FEC5E3B54AA54028(CSteamID P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return PlayerTool.getSteamPlayer(P_0);
		}

		static B7097FC49A384CFA._708ECF20BC9E451D _8263522A574841DB(SteamPlayer P_0)
		{
			return B7097FC49A384CFA._859332892E8643A6(P_0);
		}

		static object B55E3DA395954C4C(object P_0, B7097FC49A384CFA._708ECF20BC9E451D P_1, string P_2, bool P_3, string P_4)
		{
			return ((B7097FC49A384CFA)P_0).BA7BE5B4061A4F98(P_1, P_2, P_3, P_4);
		}

		static TaskAwaiter _69DBAACB976C4E59(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static bool _8FD6298051824F07(object P_0, string P_1)
		{
			return ((string)P_0).StartsWith(P_1);
		}

		static string _8E4369B4CB1E4895(object P_0, string P_1, string P_2)
		{
			return ((string)P_0).Replace(P_1, P_2);
		}

		static object C0FC6C8F2B1F41C1(object P_0)
		{
			return ((SteamPending)P_0).playerID;
		}

		static CSteamID _4F76543B6AD442E5(object P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((SteamPlayerID)P_0).steamID;
		}

		static object F9D7E1154BF6400A(object P_0)
		{
			return ((SteamConnectedClientBase)P_0).transportConnection;
		}

		static void _050CC66EB03F4BF4(ITransportConnection P_0, ESteamRejection P_1, string P_2)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			Provider.reject(P_0, P_1, P_2);
		}

		static void _742118B280194E00(CSteamID P_0, string P_1)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			Provider.kick(P_0, P_1);
		}

		static void CA454FABAC214F0C(string P_0)
		{
			_64A4BBC5E4CE4EE1.E6DC166DE03C47D7(P_0);
		}
	}

	private readonly B7097FC49A384CFA? _1E60D2A7E45A4FC2;

	private readonly _743CE34F94B6491F? _6D09CFFF54324A80;

	private readonly ConcurrentDictionary<CSteamID, int> _4DAEF03217FC4B55;

	private bool A59BBB70AA634B9C;

	private bool _5EE94C99C4B447A6;

	private bool _2144AF146DD6492F;

	private bool A03666C7F0F14F83;

	private bool F06D2A0007D34271;

	private string F3D0104E762244DA;

	private string E7C9184C9FD54813;

	private string _354FD53BD2984496;

	private string _6A2D94936E18427C;

	private int B704F62B092246E0;

	private int _771C560818654551;

	private int _5AD6136E239447EF;

	private int _5C067711BDF14CDB;

	private List<string> D5648A346B8C4640;

	public virtual void _21B8A9D9572346C4()
	{
		throw new Exception();
	}

	public virtual void _7B8E4F49DFF543BA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		Provider.onCheckValidWithExplanation = (CheckValidWithExplanation)Delegate.Remove((Delegate?)(object)Provider.onCheckValidWithExplanation, (Delegate?)new CheckValidWithExplanation(_13CF3E3E5AC34E53));
		base.C4CA2ECFAD654E77();
	}

	public virtual void _11B53F8AB29C433D()
	{
		string text = null;
		_6A2D94936E18427C = text;
		A59BBB70AA634B9C = false;
		F3D0104E762244DA = null;
		E7C9184C9FD54813 = null;
		_354FD53BD2984496 = null;
	}

	private void _13CF3E3E5AC34E53(ValidateAuthTicketResponse_t P_0, ref bool P_1, ref string P_2)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		CA80F952653941F8 CS_0024_003C_003E8__locals6 = new CA80F952653941F8();
		CS_0024_003C_003E8__locals6._5EBC116FEDE24B0C = this;
		CS_0024_003C_003E8__locals6._34BE1A620DCD4092 = P_0.m_SteamID;
		if (_1DB744298E9F4B09._052FBC588F454484 == null || !_1DB744298E9F4B09._052FBC588F454484._6EB2D3D9EC934A7A)
		{
			P_1 = false;
			P_2 = "An error occurred on the server";
		}
		else
		{
			if (!P_1 || !A59BBB70AA634B9C || _9AB67761792440A7._7A43F8465BE04590(((object)CS_0024_003C_003E8__locals6._34BE1A620DCD4092/*cast due to constrained. prefix*/).ToString()))
			{
				return;
			}
			CS_0024_003C_003E8__locals6._653F6091F53848C3 = new CancellationTokenSource(TimeSpan.FromSeconds(10.0));
			_1FFBEDFB3FCE4374._533FDA357CCF49A3("SteamProfileCheck", [MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(CA80F952653941F8._5BA9D9C248474FE9))] () =>
			{
				CA80F952653941F8._5BA9D9C248474FE9 stateMachine = default;
				stateMachine._668F3CCE73704453 = AsyncTaskMethodBuilder.Create();
				while (true)
				{
					int num = -1895797292;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~((~(-(0x40ED5B74 ^ -2008992270)) * 1163287979 - (-(0x307FDF25 ^ (-1014047843 * -1910758134)) ^ ~(-(~(332655791 + 113498073)))) - num2 * 13953499 - ((-471623964 ^ -unchecked(256571753 * unchecked(-1815244059 + -410354218))) - ~1414923428)) ^ -680288801) * 1255814677)) % 3)
						{
						case 2u:
							break;
						case 1u:
							goto IL_00df;
						default:
							stateMachine._668F3CCE73704453.Start(ref stateMachine);
							return stateMachine._668F3CCE73704453.Task;
						}
						break;
						IL_00df:
						stateMachine._589E78004D7C4F95 = CS_0024_003C_003E8__locals6;
						stateMachine.D72670B0CDD345A3 = _003CModule_003E._390073C602714496<int>(-736908096);
						num = -1391056511;
					}
				}
			}, CS_0024_003C_003E8__locals6._653F6091F53848C3.Token, [MethodImpl(MethodImplOptions.NoInlining)] (Exception ex) =>
			{
				if (!(ex is OperationCanceledException))
				{
					goto IL_000b;
				}
				goto IL_0161;
				IL_000b:
				int num = 137550281;
				goto IL_0010;
				IL_0010:
				bool flag = default;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((~(~(~1868237779 - ((num2 - (-((-1800059036 + 1279772128) ^ -(~-1785701697) ^ 0x42E6A36F ^ -1506398998) ^ (-(((-1207794027 ^ -1734696858) - (220420740 - -864342883) + -(-683092082 ^ 0x42F00578)) * -102207109) * -1798964073))) ^ ~(-unchecked(850883225 * (0x78C255B2 ^ 0x1468F3A)))) * -1174822341)) ^ -1232708609) * -1932135667)) % 8)
					{
					case 7u:
						break;
					default:
						return;
					case 0u:
						_960BDDEF64FC434B._18C71C27EBCF41F4(_760EF57D5259421C._45BE54DAE6C14D66, _003CModule_003E._3F57E81A62734AC2<string>(1524279150), Array.Empty<object>());
						return;
					case 2u:
						goto IL_0126;
					case 4u:
					{
						int num4;
						int num5;
						if (ex is TimeoutException)
						{
							num4 = 1292287863;
							num5 = num4;
						}
						else
						{
							num4 = 1318918836;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1568648457);
						continue;
					}
					case 6u:
						goto IL_0161;
					case 3u:
						flag = (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
						num = 1003566647;
						continue;
					case 1u:
						_960BDDEF64FC434B._4F17C7C443EF454F(_760EF57D5259421C._45BE54DAE6C14D66, ex, _003CModule_003E.F84FA79ABE6944BB<string>(242595208), Array.Empty<object>());
						num = -1851059550;
						continue;
					case 5u:
						return;
					}
					break;
					IL_0126:
					int num6;
					if (flag)
					{
						num = 678535301;
						num6 = num;
					}
					else
					{
						num = -1436927234;
						num6 = num;
					}
				}
				goto IL_000b;
				IL_0161:
				flag = (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0;
				num = 1003566647;
				goto IL_0010;
			});
		}
	}

	[AsyncStateMachine(typeof(BF97F1769A9C4065))]
	private Task E7AC8FC8DE184C82(CSteamID P_0, CancellationToken P_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		BF97F1769A9C4065 stateMachine = default;
		stateMachine.A9582FA8AA8C4BE9 = AsyncTaskMethodBuilder.Create();
		stateMachine._840F7F8437414B9F = this;
		stateMachine.E8695B60E64149DE = P_0;
		stateMachine._7B62E3CE1BB34230 = P_1;
		stateMachine.EA4E5F9998F6455D = -1;
		stateMachine.A9582FA8AA8C4BE9.Start(ref stateMachine);
		return stateMachine.A9582FA8AA8C4BE9.Task;
	}

	[AsyncStateMachine(typeof(_086F729B788E40E0))]
	private Task _00F2722AAB714B80(CSteamID P_0, string P_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		_086F729B788E40E0 stateMachine = default;
		stateMachine._9333568E84264457 = AsyncTaskMethodBuilder.Create();
		stateMachine.ED7C8657A9B745D2 = this;
		stateMachine._2A0330243DAC4342 = P_0;
		stateMachine._469A217CC85045F5 = P_1;
		stateMachine.FFC09F29A4754047 = -1;
		stateMachine._9333568E84264457.Start(ref stateMachine);
		return stateMachine._9333568E84264457.Task;
	}

	public _7FE330C6E84D4C74()
	{
		ConcurrentDictionary<CSteamID, int> concurrentDictionary = null;
		string text = null;
		_4DAEF03217FC4B55 = concurrentDictionary;
		A59BBB70AA634B9C = false;
		F3D0104E762244DA = null;
		E7C9184C9FD54813 = null;
		_354FD53BD2984496 = null;
		_6A2D94936E18427C = text;
	}
}
