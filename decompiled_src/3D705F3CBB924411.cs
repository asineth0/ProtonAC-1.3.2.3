using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using SDG.NetPak;
using SDG.NetTransport;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

public class _3D705F3CBB924411 : _760EF57D5259421C
{
	[Serializable]
	[CompilerGenerated]
	private sealed class AFA1A0F8FA6A444A
	{
		public static readonly AFA1A0F8FA6A444A _003C_003E9 = (AFA1A0F8FA6A444A)C09CDC3C18154F93();

		public static Predicate<_4819911A0C0846FF._3147FDB5568446E9> _003C_003E9__12_0;

		public static Action<Exception> _003C_003E9__17_1;

		public static Func<ulong, string> _003C_003E9__19_2;

		public static Action<Exception> _003C_003E9__20_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _42C47DA8EBD64794(_4819911A0C0846FF._3147FDB5568446E9 P_0)
		{
			return (P_0.F9050CCFB6B5492C ? 1 : 0) == _003CModule_003E.F84FA79ABE6944BB<int>(1398637845);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void C80DC41BF46F4719(Exception P_0)
		{
			_212DA57A91504DBB(_760EF57D5259421C._45BE54DAE6C14D66, P_0, _003CModule_003E._3F57E81A62734AC2<string>(1327307477), Array.Empty<object>());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal string _02CE1775B29E4403(ulong P_0)
		{
			return _5E92EEFB22644594(_003CModule_003E._8B9C7B12B1AE4949<string>(-935079509), (object)P_0, (object)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _286BD4DA2C0945C0(Exception P_0)
		{
			_212DA57A91504DBB(_760EF57D5259421C._45BE54DAE6C14D66, P_0, _003CModule_003E._390073C602714496<string>(-247424266), Array.Empty<object>());
		}

		static object C09CDC3C18154F93()
		{
			return new AFA1A0F8FA6A444A();
		}

		static void _212DA57A91504DBB(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}

		static string _5E92EEFB22644594(string P_0, object P_1, object P_2)
		{
			return string.Format(P_0, P_1, P_2);
		}
	}

	[CompilerGenerated]
	private sealed class B44A5B1C66034650
	{
		[StructLayout(LayoutKind.Auto)]
		private struct _89AA6EA3FE0C4E7B : IAsyncStateMachine
		{
			public int _6D8BAB6BEC294518;

			public AsyncTaskMethodBuilder _385B7BACA1454295;

			public B44A5B1C66034650 A1D9ADAEF6174135;

			private TaskAwaiter E735678A9C5247F3;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				int num = _6D8BAB6BEC294518;
				B44A5B1C66034650 b44A5B1C = A1D9ADAEF6174135;
				try
				{
					if (num != 0)
					{
						goto IL_0014;
					}
					goto IL_009e;
					IL_0014:
					int num2 = 1356677695;
					goto IL_0019;
					IL_0019:
					TaskAwaiter awaiter = default;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(~(~(-((-num3 - -(~(0x4C0D8910 ^ -2007564957))) * -2007494741) ^ ~(-(0x1D4B31D0 ^ 0x3A2D1A41)))) * 530155003)) % 8)
						{
						case 0u:
							break;
						case 1u:
							num = (_6D8BAB6BEC294518 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = -1979632031;
							continue;
						case 7u:
							goto IL_009e;
						case 3u:
						{
							awaiter = _33E854900409477F(D85431C35833497F((object)A0C5675E3AB24D12, _5699A84EE94A4356(b44A5B1C._6256BB80450F44EF), b44A5B1C.B3586207E3CF4F5A));
							int num5;
							int num6;
							if (awaiter.IsCompleted)
							{
								num5 = -761130065;
								num6 = num5;
							}
							else
							{
								num5 = -355160458;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num4 * 1560730634);
							continue;
						}
						case 4u:
							num = (_6D8BAB6BEC294518 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
							E735678A9C5247F3 = awaiter;
							num2 = 987288838;
							continue;
						case 2u:
							_385B7BACA1454295.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 6u:
							E735678A9C5247F3 = default;
							num2 = ((int)num4 * -700492611) ^ -1941011197;
							continue;
						default:
							awaiter.GetResult();
							goto end_IL_000e;
						}
						break;
					}
					goto IL_0014;
					IL_009e:
					awaiter = E735678A9C5247F3;
					num2 = -441045174;
					goto IL_0019;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					while (true)
					{
						int num7 = -332500832;
						while (true)
						{
							int num3 = num7;
							uint num4;
							switch ((num4 = (uint)(~(~(-((-num3 - -(~(0x4C0D8910 ^ -2007564957))) * -2007494741) ^ ~(-(0x1D4B31D0 ^ 0x3A2D1A41)))) * 530155003)) % 3)
							{
							case 0u:
								break;
							case 2u:
								goto IL_01c2;
							default:
								_385B7BACA1454295.SetException(exception);
								return;
							}
							break;
							IL_01c2:
							_6D8BAB6BEC294518 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
							num7 = -1562290619;
						}
					}
				}
				_6D8BAB6BEC294518 = _003CModule_003E._390073C602714496<int>(818201983);
				while (true)
				{
					int num8 = -1732757410;
					while (true)
					{
						int num3 = num8;
						uint num4;
						switch ((num4 = (uint)(~(~(-((-num3 - -(~(0x4C0D8910 ^ -2007564957))) * -2007494741) ^ ~(-(0x1D4B31D0 ^ 0x3A2D1A41)))) * 530155003)) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 1u:
							goto IL_0253;
						case 2u:
							return;
						}
						break;
						IL_0253:
						_385B7BACA1454295.SetResult();
						num8 = (int)((num4 * 522596791) ^ 0x2984F5F0);
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
				_385B7BACA1454295.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static B7097FC49A384CFA._708ECF20BC9E451D _5699A84EE94A4356(SteamPlayer P_0)
			{
				return B7097FC49A384CFA._29ACB008E63D4EB5(P_0);
			}

			static object D85431C35833497F(object P_0, B7097FC49A384CFA._708ECF20BC9E451D P_1, string P_2)
			{
				return ((B7097FC49A384CFA)P_0)._0AEFB715ADC84B45(P_1, P_2);
			}

			static TaskAwaiter _33E854900409477F(object P_0)
			{
				return ((Task)P_0).GetAwaiter();
			}
		}

		public SteamPlayer _6256BB80450F44EF;

		public string B3586207E3CF4F5A;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_89AA6EA3FE0C4E7B))]
		internal Task E89E9B00C53948BF()
		{
			_89AA6EA3FE0C4E7B stateMachine = default;
			stateMachine._385B7BACA1454295 = AsyncTaskMethodBuilder.Create();
			stateMachine.A1D9ADAEF6174135 = this;
			while (true)
			{
				int num = 523194796;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(~(~(~(~(-num2)))) * 145575577 - unchecked(1626023527 * -210830785)))) % 3)
					{
					case 0u:
						break;
					case 2u:
						goto IL_004a;
					default:
						return stateMachine._385B7BACA1454295.Task;
					}
					break;
					IL_004a:
					stateMachine._6D8BAB6BEC294518 = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
					stateMachine._385B7BACA1454295.Start(ref stateMachine);
					num = -1811994818;
				}
			}
		}
	}

	[CompilerGenerated]
	private sealed class _2C639165A13F453C
	{
		[StructLayout(LayoutKind.Auto)]
		private struct _8A682B38790A4F32 : IAsyncStateMachine
		{
			public int _6F0022F0B9E0431A;

			public AsyncTaskMethodBuilder _5A8F848D2A4A4DFE;

			public _2C639165A13F453C _035E023727F94BCC;

			private TaskAwaiter<bool> E3F37AC141D04F5E;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				//IL_014d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
				int num = _6F0022F0B9E0431A;
				_2C639165A13F453C obj = _035E023727F94BCC;
				try
				{
					if (num != 0)
					{
						goto IL_0014;
					}
					goto IL_0283;
					IL_0014:
					int num2 = 593680989;
					goto IL_0019;
					IL_0019:
					TaskAwaiter<bool> awaiter = default;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(~(~(num3 ^ -(--547342190 - ~(~429989100 - ~unchecked((-3566424 + 741748917) * 461774555))))))) % 15)
						{
						case 7u:
							break;
						default:
							goto end_IL_000e;
						case 1u:
							E3F37AC141D04F5E = awaiter;
							_5A8F848D2A4A4DFE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 11u:
							goto IL_00bb;
						case 14u:
							num = (_6F0022F0B9E0431A = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042));
							num2 = 1830807955;
							continue;
						case 3u:
							goto IL_0133;
						case 10u:
							goto IL_018b;
						case 12u:
							E3F37AC141D04F5E = default;
							num = (_6F0022F0B9E0431A = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = 733687924;
							continue;
						case 4u:
							E3F37AC141D04F5E = default;
							num = (_6F0022F0B9E0431A = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = 1490591729;
							continue;
						case 9u:
							E3F37AC141D04F5E = awaiter;
							num2 = ((int)num4 * -1451832442) ^ 0x31B9BFC9;
							continue;
						case 8u:
							_5A8F848D2A4A4DFE.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 6u:
							num = (_6F0022F0B9E0431A = _003CModule_003E._390073C602714496<int>(-250964212));
							num2 = 2041206724;
							continue;
						case 2u:
							awaiter = E3F37AC141D04F5E;
							num2 = 677391157;
							continue;
						case 13u:
							awaiter.GetResult();
							num2 = 596192609;
							continue;
						case 0u:
							goto IL_0283;
						case 5u:
							goto end_IL_000e;
						}
						break;
						IL_018b:
						int num5;
						if (num == _003CModule_003E._390073C602714496<int>(-250964212))
						{
							num2 = 1515351770;
							num5 = num2;
						}
						else
						{
							num2 = 1173769968;
							num5 = num2;
						}
						continue;
						IL_0133:
						awaiter = _2BF88C28B2AE4A4B((object)_06A58E53B98649A7, _16A394D620B1464B(_7690107F9CF14EA7((object)((SteamChannel)BE5EBD4B12D64A83((object)obj._164E597D0BAE4E1D)).owner)).m_SteamID, (F9DC65C0B16C4603)_003CModule_003E._390073C602714496<int>(-250964212)).GetAwaiter();
						int num6;
						if (awaiter.IsCompleted)
						{
							num2 = 733687924;
							num6 = num2;
						}
						else
						{
							num2 = 278887648;
							num6 = num2;
						}
						continue;
						IL_00bb:
						awaiter.GetResult();
						awaiter = _5A100B0AAE46400B((object)_06A58E53B98649A7, _16A394D620B1464B(_7690107F9CF14EA7((object)((SteamChannel)BE5EBD4B12D64A83((object)obj._164E597D0BAE4E1D)).owner)).m_SteamID, obj._9FC12C3ADFFA4BE3).GetAwaiter();
						int num7;
						if (!awaiter.IsCompleted)
						{
							num2 = 1351226415;
							num7 = num2;
						}
						else
						{
							num2 = 1490591729;
							num7 = num2;
						}
					}
					goto IL_0014;
					IL_0283:
					awaiter = E3F37AC141D04F5E;
					num2 = 1915562072;
					goto IL_0019;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					_6F0022F0B9E0431A = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
					while (true)
					{
						int num8 = 1113887067;
						while (true)
						{
							int num3 = num8;
							uint num4;
							switch ((num4 = (uint)(~(~(num3 ^ -(--547342190 - ~(~429989100 - ~unchecked((-3566424 + 741748917) * 461774555))))))) % 3)
							{
							case 0u:
								break;
							default:
								return;
							case 2u:
								goto IL_02ef;
							case 1u:
								return;
							}
							break;
							IL_02ef:
							_5A8F848D2A4A4DFE.SetException(exception);
							num8 = ((int)num4 * -1926752373) ^ -1333079536;
						}
					}
				}
				_6F0022F0B9E0431A = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
				while (true)
				{
					int num9 = 13827945;
					while (true)
					{
						int num3 = num9;
						uint num4;
						switch ((num4 = (uint)(~(~(num3 ^ -(--547342190 - ~(~429989100 - ~unchecked((-3566424 + 741748917) * 461774555))))))) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 2u:
							goto IL_0365;
						case 1u:
							return;
						}
						break;
						IL_0365:
						_5A8F848D2A4A4DFE.SetResult();
						num9 = ((int)num4 * -1864492486) ^ 0x5772B878;
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
				_5A8F848D2A4A4DFE.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static object BE5EBD4B12D64A83(object P_0)
			{
				return ((Player)P_0).channel;
			}

			static object _7690107F9CF14EA7(object P_0)
			{
				return ((SteamPlayer)P_0).playerID;
			}

			static CSteamID _16A394D620B1464B(object P_0)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return ((SteamPlayerID)P_0).steamID;
			}

			static Task<bool> _2BF88C28B2AE4A4B(object P_0, ulong P_1, F9DC65C0B16C4603 P_2)
			{
				return ((_9B508551BC7E4B5E)P_0)._8836F1A5FA9A47D4(P_1, P_2);
			}

			static Task<bool> _5A100B0AAE46400B(object P_0, ulong P_1, string P_2)
			{
				return ((_9B508551BC7E4B5E)P_0).C3CBD45B38E74922(P_1, P_2);
			}
		}

		public Player _164E597D0BAE4E1D;

		public string _9FC12C3ADFFA4BE3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_8A682B38790A4F32))]
		internal Task F181BB3311634E01()
		{
			_8A682B38790A4F32 stateMachine = default;
			stateMachine._5A8F848D2A4A4DFE = AsyncTaskMethodBuilder.Create();
			stateMachine._035E023727F94BCC = this;
			stateMachine._6F0022F0B9E0431A = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
			stateMachine._5A8F848D2A4A4DFE.Start(ref stateMachine);
			return stateMachine._5A8F848D2A4A4DFE.Task;
		}
	}

	[CompilerGenerated]
	private sealed class _6EB690586262415C
	{
		[StructLayout(LayoutKind.Auto)]
		private struct _770D94533A4E41C6 : IAsyncStateMachine
		{
			public int DA65C30F09A04D99;

			public AsyncTaskMethodBuilder _5C88713820234942;

			public _6EB690586262415C _749E31D6551541D7;

			private List<string> _09B64DAD86694972;

			private TaskAwaiter _3D7ADB320DAC42BA;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				//IL_0976: Unknown result type (might be due to invalid IL or missing references)
				//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
				//IL_0880: Unknown result type (might be due to invalid IL or missing references)
				//IL_0546: Unknown result type (might be due to invalid IL or missing references)
				//IL_0409: Unknown result type (might be due to invalid IL or missing references)
				int num = DA65C30F09A04D99;
				_6EB690586262415C obj = _749E31D6551541D7;
				try
				{
					HashSet<ulong> hashSet = default;
					if (num != 0)
					{
						while (true)
						{
							int num2 = -405875356;
							while (true)
							{
								int num3 = num2;
								uint num4;
								switch ((num4 = (uint)(-(-(~((-1821453847 ^ (903958752 - -(-1991904844 ^ 0x3CEB4FFA))) * 1405048557) - num3)) ^ ~(~(-(499927188 - -167954254))))) % 3)
								{
								case 0u:
									break;
								case 1u:
									goto IL_0066;
								default:
									goto end_IL_0014;
								}
								break;
								IL_0066:
								if (num != _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
								{
									num2 = -179495414;
									continue;
								}
								goto IL_060d;
							}
							continue;
							end_IL_0014:
							break;
						}
						_09B64DAD86694972 = new List<string>();
						List<byte[]>.Enumerator enumerator = obj.A680E44AD784417F.GetEnumerator();
						try
						{
							while (true)
							{
								IL_0111:
								int num5;
								int num6;
								if (!enumerator.MoveNext())
								{
									num5 = -864619972;
									num6 = num5;
								}
								else
								{
									num5 = -1524569481;
									num6 = num5;
								}
								while (true)
								{
									int num3 = num5;
									uint num4;
									switch ((num4 = (uint)(-(-(~((-1821453847 ^ (903958752 - -(-1991904844 ^ 0x3CEB4FFA))) * 1405048557) - num3)) ^ ~(~(-(499927188 - -167954254))))) % 4)
									{
									case 0u:
										num5 = -1524569481;
										continue;
									default:
										goto end_IL_009e;
									case 3u:
									{
										byte[] current = enumerator.Current;
										_09B64DAD86694972.Add(EFAA5FC2396045FD(current));
										num5 = -266714871;
										continue;
									}
									case 1u:
										break;
									case 2u:
										goto end_IL_009e;
									}
									goto IL_0111;
									continue;
									end_IL_009e:
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
									IL_013f:
									int num7 = -246817409;
									while (true)
									{
										int num3 = num7;
										uint num4;
										switch ((num4 = (uint)(-(-(~((-1821453847 ^ (903958752 - -(-1991904844 ^ 0x3CEB4FFA))) * 1405048557) - num3)) ^ ~(~(-(499927188 - -167954254))))) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0144;
										case 1u:
											goto IL_0191;
										case 2u:
											goto end_IL_0144;
										}
										goto IL_013f;
										IL_0191:
										((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
										num7 = (int)(num4 * 2078668190) ^ -226611579;
										continue;
										end_IL_0144:
										break;
									}
									break;
								}
							}
						}
						hashSet = new HashSet<ulong>();
						List<string>.Enumerator enumerator2 = _09B64DAD86694972.GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								string current2;
								while (true)
								{
									current2 = enumerator2.Current;
									int num8 = 491752951;
									while (true)
									{
										int num3 = num8;
										uint num4;
										switch ((num4 = (uint)(-(-(~((-1821453847 ^ (903958752 - -(-1991904844 ^ 0x3CEB4FFA))) * 1405048557) - num3)) ^ ~(~(-(499927188 - -167954254))))) % 3)
										{
										case 2u:
											num8 = -510988658;
											continue;
										case 1u:
											break;
										default:
											goto end_IL_0219;
										}
										break;
									}
									continue;
									end_IL_0219:
									break;
								}
								IEnumerator<ulong> enumerator3 = _6067F234E12D470D((object)_0AC63CDAB63A4FA8.E6CEB4BA92AA4EB5, current2).GetEnumerator();
								try
								{
									while (true)
									{
										IL_02b2:
										int num9;
										int num10;
										if (_2BC14080C0FF42A7((object)enumerator3))
										{
											num9 = -198552884;
											num10 = num9;
										}
										else
										{
											num9 = -868994379;
											num10 = num9;
										}
										while (true)
										{
											int num3 = num9;
											uint num4;
											switch ((num4 = (uint)(-(-(~((-1821453847 ^ (903958752 - -(-1991904844 ^ 0x3CEB4FFA))) * 1405048557) - num3)) ^ ~(~(-(499927188 - -167954254))))) % 4)
											{
											case 0u:
												num9 = -198552884;
												continue;
											default:
												goto end_IL_0248;
											case 2u:
											{
												ulong current3 = enumerator3.Current;
												hashSet.Add(current3);
												num9 = 108767431;
												continue;
											}
											case 3u:
												break;
											case 1u:
												goto end_IL_0248;
											}
											goto IL_02b2;
											continue;
											end_IL_0248:
											break;
										}
										break;
									}
								}
								finally
								{
									if (num < _003CModule_003E._3F57E81A62734AC2<int>(-1803194042))
									{
										while (true)
										{
											IL_02e6:
											int num11 = -902343196;
											while (true)
											{
												int num3 = num11;
												uint num4;
												switch ((num4 = (uint)(-(-(~((-1821453847 ^ (903958752 - -(-1991904844 ^ 0x3CEB4FFA))) * 1405048557) - num3)) ^ ~(~(-(499927188 - -167954254))))) % 4)
												{
												case 0u:
													break;
												default:
													goto end_IL_02eb;
												case 2u:
												{
													int num12;
													int num13;
													if (enumerator3 != null)
													{
														num12 = -2101769141;
														num13 = num12;
													}
													else
													{
														num12 = -206394871;
														num13 = num12;
													}
													num11 = num12 ^ (int)(num4 * 651325101);
													continue;
												}
												case 1u:
													_9DB0391F573A461E((object)enumerator3);
													num11 = ((int)num4 * -61392624) ^ -840967361;
													continue;
												case 3u:
													goto end_IL_02eb;
												}
												goto IL_02e6;
												continue;
												end_IL_02eb:
												break;
											}
											break;
										}
									}
								}
							}
						}
						finally
						{
							if (num < _003CModule_003E._3F57E81A62734AC2<int>(-1803194042))
							{
								while (true)
								{
									IL_0392:
									int num14 = -863707955;
									while (true)
									{
										int num3 = num14;
										uint num4;
										switch ((num4 = (uint)(-(-(~((-1821453847 ^ (903958752 - -(-1991904844 ^ 0x3CEB4FFA))) * 1405048557) - num3)) ^ ~(~(-(499927188 - -167954254))))) % 3)
										{
										case 0u:
											break;
										default:
											goto end_IL_0397;
										case 2u:
											goto IL_03e4;
										case 1u:
											goto end_IL_0397;
										}
										goto IL_0392;
										IL_03e4:
										((IDisposable)enumerator2/*cast due to constrained. prefix*/).Dispose();
										num14 = ((int)num4 * -85471499) ^ 0x6538EC01;
										continue;
										end_IL_0397:
										break;
									}
									break;
								}
							}
						}
						hashSet.Remove(_5D0704C9679E4113((object)obj.A3E3384DB8AB4C09).m_SteamID);
						if (hashSet.Count > _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
						{
							goto IL_0430;
						}
						goto IL_0642;
					}
					goto IL_06b6;
					IL_0430:
					int num15 = -254093364;
					goto IL_0435;
					IL_0866:
					int num16 = _003CModule_003E._390073C602714496<int>(2131963235);
					goto IL_08b8;
					IL_06b6:
					TaskAwaiter awaiter = _3D7ADB320DAC42BA;
					_3D7ADB320DAC42BA = default;
					num = (DA65C30F09A04D99 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
					num15 = 366022975;
					goto IL_0435;
					IL_060d:
					awaiter = _3D7ADB320DAC42BA;
					num15 = -1153274067;
					goto IL_0435;
					IL_0435:
					string text = default;
					int num24 = default;
					int num17 = default;
					string text2 = default;
					int num21 = default;
					IEnumerable<string> source = default;
					while (true)
					{
						int num3 = num15;
						uint num4;
						int num20;
						switch ((num4 = (uint)(-(-(~((-1821453847 ^ (903958752 - -(-1991904844 ^ 0x3CEB4FFA))) * 1405048557) - num3)) ^ ~(~(-(499927188 - -167954254))))) % 35)
						{
						case 31u:
							break;
						default:
							goto end_IL_000e;
						case 1u:
							_5C88713820234942.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 30u:
							num20 = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042);
							goto IL_057e;
						case 24u:
							num = (DA65C30F09A04D99 = _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
							_3D7ADB320DAC42BA = awaiter;
							_5C88713820234942.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 16u:
							if (_09B64DAD86694972.Count > _003CModule_003E._8B9C7B12B1AE4949<int>(350091668))
							{
								num20 = obj._8F25088495B7436E._6748C1C6E17847D9(_5D0704C9679E4113((object)obj.A3E3384DB8AB4C09).m_SteamID, _003CModule_003E._3F57E81A62734AC2<int>(1017304263), obj._5C01A68F3FA24B42, _09B64DAD86694972[_003CModule_003E.F84FA79ABE6944BB<int>(1741630884)]);
								goto IL_057e;
							}
							num15 = 488290558;
							continue;
						case 29u:
							awaiter.GetResult();
							num15 = -639461987;
							continue;
						case 19u:
							num15 = (int)(num4 * 1324187836) ^ -1807646979;
							continue;
						case 18u:
							goto IL_060d;
						case 15u:
							goto IL_061f;
						case 0u:
							goto IL_0642;
						case 23u:
							text = _40C8072A7DA54885(text, _1E30256F7CD74BD3(_003CModule_003E._58ECCB512F2A43AC<string>(-85285868), (object)num24));
							num15 = -167320812;
							continue;
						case 25u:
							goto IL_0693;
						case 12u:
							goto IL_06b6;
						case 26u:
							awaiter = F6CE75B139A54C5E(_76D5370918B244A4((object)A0C5675E3AB24D12, C74EF1CFED674ABE(((SteamChannel)E1477A4ED9504E11((object)obj._8FD3517F14EB428D)).owner), _40C8072A7DA54885(_003CModule_003E._3F57E81A62734AC2<string>(239882380), text), (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0, _48EEBB0ACC7F47C2((LocalizedString)_624EA17DD34840C6((object)_760EF57D5259421C._690D5F470A354A09, _003CModule_003E._58ECCB512F2A43AC<string>(1781374980)))));
							num15 = -1307832622;
							continue;
						case 8u:
						{
							string text3 = _0DF8082047434BCC(_003CModule_003E._8B9C7B12B1AE4949<string>(722329237), hashSet.Select([MethodImpl(MethodImplOptions.NoInlining)] (ulong P_0) => AFA1A0F8FA6A444A._5E92EEFB22644594(_003CModule_003E._8B9C7B12B1AE4949<string>(-935079509), (object)P_0, (object)P_0)));
							awaiter = F6CE75B139A54C5E(_76D5370918B244A4((object)A0C5675E3AB24D12, C74EF1CFED674ABE(((SteamChannel)E1477A4ED9504E11((object)obj._8FD3517F14EB428D)).owner), _3CBBE868F0544978(_003CModule_003E._390073C602714496<string>(-161955895), (object)hashSet.Count, (object)text3), (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0, _48EEBB0ACC7F47C2((LocalizedString)_624EA17DD34840C6((object)_760EF57D5259421C._690D5F470A354A09, _003CModule_003E._8B9C7B12B1AE4949<string>(-327296251)))));
							num15 = -1310550201;
							continue;
						}
						case 3u:
							num = (DA65C30F09A04D99 = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042));
							_3D7ADB320DAC42BA = awaiter;
							num15 = -215781578;
							continue;
						case 7u:
						{
							int num25;
							int num26;
							if (awaiter.IsCompleted)
							{
								num25 = -737432068;
								num26 = num25;
							}
							else
							{
								num25 = 1987837275;
								num26 = num25;
							}
							num15 = num25 ^ (int)(num4 * 913551393);
							continue;
						}
						case 5u:
							num17 += _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
							num15 = 60703469;
							continue;
						case 10u:
							goto IL_0866;
						case 34u:
							goto IL_08c3;
						case 11u:
							text = _40C8072A7DA54885(text, _003CModule_003E._390073C602714496<string>(-47998067));
							num15 = -1494555054;
							continue;
						case 14u:
							awaiter.GetResult();
							num15 = 177927322;
							continue;
						case 21u:
						{
							int num22;
							int num23;
							if (!_40C009F50D86436E(text))
							{
								num22 = 548769738;
								num23 = num22;
							}
							else
							{
								num22 = -1669185141;
								num23 = num22;
							}
							num15 = num22 ^ ((int)num4 * -1178290673);
							continue;
						}
						case 28u:
							_3D7ADB320DAC42BA = default;
							num15 = (int)((num4 * 753554985) ^ 0x8C67CB3);
							continue;
						case 2u:
							_1586C7649F4A4275((object)_0AC63CDAB63A4FA8.E6CEB4BA92AA4EB5, _5D0704C9679E4113((object)obj.A3E3384DB8AB4C09).m_SteamID, num17, text2, obj._5C01A68F3FA24B42);
							num15 = (int)((num4 * 500107404) ^ 0x3FA71FED);
							continue;
						case 27u:
							goto IL_09a2;
						case 13u:
							text = _40C8072A7DA54885(text, _1E30256F7CD74BD3(_003CModule_003E._3F57E81A62734AC2<string>(1008795579), (object)num21));
							num15 = 44241789;
							continue;
						case 33u:
							source = _265F701E92C54578((object)_0AC63CDAB63A4FA8.E6CEB4BA92AA4EB5, _5D0704C9679E4113((object)obj.A3E3384DB8AB4C09).m_SteamID);
							num15 = -551616621;
							continue;
						case 22u:
							num = (DA65C30F09A04D99 = _003CModule_003E._390073C602714496<int>(-736908096));
							num15 = -165454739;
							continue;
						case 20u:
						{
							int num18;
							int num19;
							if (awaiter.IsCompleted)
							{
								num18 = -1876616547;
								num19 = num18;
							}
							else
							{
								num18 = -611905186;
								num19 = num18;
							}
							num15 = num18 ^ (int)(num4 * 90168692);
							continue;
						}
						case 9u:
							num17 = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042);
							num15 = -975512670;
							continue;
						case 17u:
							text = string.Empty;
							num15 = -1580308926;
							continue;
						case 6u:
							goto IL_0a88;
						case 4u:
							goto IL_0aac;
						case 32u:
							goto end_IL_000e;
							IL_057e:
							num24 = num20;
							num15 = -400557095;
							continue;
						}
						break;
						IL_0aac:
						int num27;
						if (num21 > _003CModule_003E._390073C602714496<int>(2131963235))
						{
							num15 = 89288055;
							num27 = num15;
						}
						else
						{
							num15 = 44241789;
							num27 = num15;
						}
						continue;
						IL_09a2:
						int num28;
						if (num24 > _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
						{
							num15 = 332084932;
							num28 = num15;
						}
						else
						{
							num15 = -639461987;
							num28 = num15;
						}
						continue;
						IL_0693:
						int num29;
						if (num17 >= _09B64DAD86694972.Count)
						{
							num15 = -1226392645;
							num29 = num15;
						}
						else
						{
							num15 = 314610134;
							num29 = num15;
						}
						continue;
						IL_0a88:
						int num30;
						if (num24 <= _003CModule_003E._3F57E81A62734AC2<int>(-1803194042))
						{
							num15 = -167320812;
							num30 = num15;
						}
						else
						{
							num15 = -593212357;
							num30 = num15;
						}
						continue;
						IL_061f:
						int num31;
						if (num21 <= _003CModule_003E.F84FA79ABE6944BB<int>(1398637845))
						{
							num15 = -447370431;
							num31 = num15;
						}
						else
						{
							num15 = 332084932;
							num31 = num15;
						}
						continue;
						IL_08c3:
						text2 = _09B64DAD86694972[num17];
						int num32;
						if (!source.Contains(text2))
						{
							num15 = -576541745;
							num32 = num15;
						}
						else
						{
							num15 = 144229225;
							num32 = num15;
						}
					}
					goto IL_0430;
					IL_0642:
					if (_09B64DAD86694972.Count <= _003CModule_003E._390073C602714496<int>(2131963235))
					{
						num15 = -204731418;
						goto IL_0435;
					}
					num16 = obj._8F25088495B7436E._6748C1C6E17847D9(_5D0704C9679E4113((object)obj.A3E3384DB8AB4C09).m_SteamID, _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563), obj._5C01A68F3FA24B42, _09B64DAD86694972[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)]);
					goto IL_08b8;
					IL_08b8:
					num21 = num16;
					num15 = 313190646;
					goto IL_0435;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					DA65C30F09A04D99 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
					_09B64DAD86694972 = null;
					_5C88713820234942.SetException(exception);
					return;
				}
				DA65C30F09A04D99 = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
				_09B64DAD86694972 = null;
				while (true)
				{
					int num33 = -1140833227;
					while (true)
					{
						int num3 = num33;
						uint num4;
						switch ((num4 = (uint)(-(-(~((-1821453847 ^ (903958752 - -(-1991904844 ^ 0x3CEB4FFA))) * 1405048557) - num3)) ^ ~(~(-(499927188 - -167954254))))) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 2u:
							goto IL_0b69;
						case 1u:
							return;
						}
						break;
						IL_0b69:
						_5C88713820234942.SetResult();
						num33 = (int)(num4 * 871363000) ^ -2127699793;
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
				_5C88713820234942.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static string EFAA5FC2396045FD(byte[] P_0)
			{
				return Hash.toString(P_0);
			}

			static IEnumerable<ulong> _6067F234E12D470D(object P_0, string P_1)
			{
				return ((_05B7A84E8227463B)P_0)._62CB1B0C4D6B4440(P_1);
			}

			static bool _2BC14080C0FF42A7(object P_0)
			{
				return ((IEnumerator)P_0).MoveNext();
			}

			static void _9DB0391F573A461E(object P_0)
			{
				((IDisposable)P_0).Dispose();
			}

			static CSteamID _5D0704C9679E4113(object P_0)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				return ((SteamPlayerID)P_0).steamID;
			}

			static string _0DF8082047434BCC(string P_0, IEnumerable<string> P_1)
			{
				return string.Join(P_0, P_1);
			}

			static object E1477A4ED9504E11(object P_0)
			{
				return ((Player)P_0).channel;
			}

			static B7097FC49A384CFA._708ECF20BC9E451D C74EF1CFED674ABE(SteamPlayer P_0)
			{
				return B7097FC49A384CFA._859332892E8643A6(P_0);
			}

			static string _3CBBE868F0544978(string P_0, object P_1, object P_2)
			{
				return string.Format(P_0, P_1, P_2);
			}

			static object _624EA17DD34840C6(object P_0, string P_1)
			{
				return ((IStringLocalizer)P_0)[P_1];
			}

			static string _48EEBB0ACC7F47C2(LocalizedString P_0)
			{
				return LocalizedString.op_Implicit(P_0);
			}

			static object _76D5370918B244A4(object P_0, B7097FC49A384CFA._708ECF20BC9E451D P_1, string P_2, bool P_3, string P_4)
			{
				return ((B7097FC49A384CFA)P_0).BA7BE5B4061A4F98(P_1, P_2, P_3, P_4);
			}

			static TaskAwaiter F6CE75B139A54C5E(object P_0)
			{
				return ((Task)P_0).GetAwaiter();
			}

			static string _1E30256F7CD74BD3(string P_0, object P_1)
			{
				return string.Format(P_0, P_1);
			}

			static string _40C8072A7DA54885(string P_0, string P_1)
			{
				return P_0 + P_1;
			}

			static bool _40C009F50D86436E(string P_0)
			{
				return string.IsNullOrEmpty(P_0);
			}

			static IEnumerable<string> _265F701E92C54578(object P_0, ulong P_1)
			{
				return ((_05B7A84E8227463B)P_0)._0CE0C14392C04759(P_1);
			}

			static void _1586C7649F4A4275(object P_0, ulong P_1, int P_2, string P_3, long P_4)
			{
				((_05B7A84E8227463B)P_0)._1F53E315509B4C4A(P_1, P_2, P_3, P_4);
			}
		}

		public List<byte[]> A680E44AD784417F;

		public SteamPlayerID A3E3384DB8AB4C09;

		public Player _8FD3517F14EB428D;

		public _3D705F3CBB924411 _8F25088495B7436E;

		public long _5C01A68F3FA24B42;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_770D94533A4E41C6))]
		internal Task E8B330A31A864897()
		{
			_770D94533A4E41C6 stateMachine = default;
			stateMachine._5C88713820234942 = AsyncTaskMethodBuilder.Create();
			while (true)
			{
				int num = -1700177165;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((((~2017767847 + -unchecked(663980652 * 1020180449) - (~(~(unchecked(-882539205 + -1811854267) - (-32549010 - -479410167) - unchecked(1705235156 + 2099148232) + -896385609) + (~(-(-185836619 + (0x5BECA8F3 ^ 0x612FD409))) - (-201021096 ^ ~(-1781554309 * --927412942))) - ~num2) - (0x7E22C531 ^ 0xE234F71))) ^ (--1673222636 - --1114870370)) - unchecked(-496164312 * 1288551161)) ^ 0x243A4B59)) % 5)
					{
					case 3u:
						break;
					case 1u:
						stateMachine._749E31D6551541D7 = this;
						num = ((int)num3 * -1810006875) ^ -375922125;
						continue;
					case 4u:
						stateMachine.DA65C30F09A04D99 = _003CModule_003E._390073C602714496<int>(-736908096);
						num = -404903234;
						continue;
					case 2u:
						stateMachine._5C88713820234942.Start(ref stateMachine);
						num = (int)(num3 * 198362227) ^ -115028838;
						continue;
					default:
						return stateMachine._5C88713820234942.Task;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _25BB7ED0CA784C83(Exception P_0)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			_27F452752EE64D44(_760EF57D5259421C._45BE54DAE6C14D66, P_0, _9879BBFF056F4676(_003CModule_003E._390073C602714496<string>(-1075241634), (object)_11155983E2BC4801((object)A3E3384DB8AB4C09)), Array.Empty<object>());
		}

		static CSteamID _11155983E2BC4801(object P_0)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((SteamPlayerID)P_0).steamID;
		}

		static string _9879BBFF056F4676(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void _27F452752EE64D44(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	[CompilerGenerated]
	private sealed class _5B1EF2191BB64736
	{
		[StructLayout(LayoutKind.Auto)]
		private struct _140DAD5F3D7443AB : IAsyncStateMachine
		{
			public int _1F1F37EEBBF54095;

			public AsyncTaskMethodBuilder _834F5B47477046DA;

			public _5B1EF2191BB64736 A2E5F6E2C6F044AE;

			private TaskAwaiter D4B8C6787F644CC9;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				int num = _1F1F37EEBBF54095;
				_5B1EF2191BB64736 obj = A2E5F6E2C6F044AE;
				try
				{
					if (num != 0)
					{
						goto IL_0014;
					}
					goto IL_00c9;
					IL_0014:
					int num2 = -494810845;
					goto IL_0019;
					IL_0019:
					TaskAwaiter awaiter = default;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)((-(num3 ^ -((~(~(-160762652) ^ -984144141) - unchecked(1548126730 * 1867200569)) ^ -2000639404)) * 1311934347 + (unchecked(unchecked(-986886777 * (-880052358 - -512337210)) * -1296275271) + 2028379627) + (301592889 - (-1465435768 ^ 0x4C9B6D11))) ^ -(0x4FDF1560 ^ 0x3911F9E7) ^ 0x3A2D22C8 ^ -116390381)) % 7)
						{
						case 0u:
							break;
						case 3u:
							goto IL_00c9;
						case 5u:
							num = (_1F1F37EEBBF54095 = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
							num2 = 1076428649;
							continue;
						case 2u:
							return;
						case 1u:
							goto IL_0130;
						case 4u:
							D4B8C6787F644CC9 = awaiter;
							_834F5B47477046DA.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num2 = ((int)num4 * -1726231405) ^ -1653931908;
							continue;
						default:
							awaiter.GetResult();
							goto end_IL_000e;
						}
						break;
						IL_0130:
						awaiter = _2AE90BCED7F74A87(_26D30B2666A048F7((object)A0C5675E3AB24D12, D7267ECD7AA14976(((SteamChannel)_9137299A3B554789((object)obj._01E9530A0B904909)).owner), obj._21A7493C1AC84C3B, (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0, B8F5D12DD2B94DCF((LocalizedString)_02C14789F24846E0((object)_760EF57D5259421C._690D5F470A354A09, _003CModule_003E._390073C602714496<string>(-404927837)))));
						int num5;
						if (awaiter.IsCompleted)
						{
							num2 = -1815325382;
							num5 = num2;
						}
						else
						{
							num2 = 794445500;
							num5 = num2;
						}
					}
					goto IL_0014;
					IL_00c9:
					awaiter = D4B8C6787F644CC9;
					D4B8C6787F644CC9 = default;
					num = (_1F1F37EEBBF54095 = _003CModule_003E._390073C602714496<int>(-736908096));
					num2 = -1815325382;
					goto IL_0019;
					end_IL_000e:;
				}
				catch (Exception exception)
				{
					_1F1F37EEBBF54095 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
					_834F5B47477046DA.SetException(exception);
					return;
				}
				_1F1F37EEBBF54095 = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
				_834F5B47477046DA.SetResult();
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_834F5B47477046DA.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static object _9137299A3B554789(object P_0)
			{
				return ((Player)P_0).channel;
			}

			static B7097FC49A384CFA._708ECF20BC9E451D D7267ECD7AA14976(SteamPlayer P_0)
			{
				return B7097FC49A384CFA._859332892E8643A6(P_0);
			}

			static object _02C14789F24846E0(object P_0, string P_1)
			{
				return ((IStringLocalizer)P_0)[P_1];
			}

			static string B8F5D12DD2B94DCF(LocalizedString P_0)
			{
				return LocalizedString.op_Implicit(P_0);
			}

			static object _26D30B2666A048F7(object P_0, B7097FC49A384CFA._708ECF20BC9E451D P_1, string P_2, bool P_3, string P_4)
			{
				return ((B7097FC49A384CFA)P_0).BA7BE5B4061A4F98(P_1, P_2, P_3, P_4);
			}

			static TaskAwaiter _2AE90BCED7F74A87(object P_0)
			{
				return ((Task)P_0).GetAwaiter();
			}
		}

		public Player _01E9530A0B904909;

		public string _21A7493C1AC84C3B;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_140DAD5F3D7443AB))]
		internal Task F841001DF29A4F14()
		{
			_140DAD5F3D7443AB stateMachine = default;
			stateMachine._834F5B47477046DA = AsyncTaskMethodBuilder.Create();
			stateMachine.A2E5F6E2C6F044AE = this;
			stateMachine._1F1F37EEBBF54095 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817);
			stateMachine._834F5B47477046DA.Start(ref stateMachine);
			return stateMachine._834F5B47477046DA.Task;
		}
	}

	private static readonly _9B508551BC7E4B5E? _06A58E53B98649A7;

	private static readonly B7097FC49A384CFA? A0C5675E3AB24D12;

	private static readonly C7A753824C0746AE? _379079320C04450F;

	private static readonly _743CE34F94B6491F? _0AC63CDAB63A4FA8;

	private static readonly A19CBF069C964833 A1B0CE3761BF4AA4;

	private static readonly C4462CD02B8C4225 D30CFAEA6C414B2B;

	private static readonly A19CBF069C964833._40FE7AC3F69F4B10 _39E21C30FEBE4EB6;

	private static readonly ClientStaticMethod EE4961E8242B4B98 = null;

	private static readonly List<SteamPlayer> _5015949A1C06489C;

	private const int FCB0DB9469964739 = 4;

	public virtual void _7D85D260200A4054()
	{
		A0C5675E3AB24D12 = null;
		throw new Exception();
	}

	public virtual void _9EDF4AF4E6AB4F1D()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected Obj, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected Obj, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected Obj, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected Obj, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected Obj, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected Obj, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected Obj, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected Obj, but got Unknown
		Provider.onServerConnected = (ServerConnected)Delegate.Remove((Delegate?)(object)Provider.onServerConnected, (Delegate?)new ServerConnected(_0916834C25A248A7));
		Provider.onEnemyConnected = (EnemyConnected)Delegate.Remove((Delegate?)(object)Provider.onEnemyConnected, (Delegate?)new EnemyConnected(_364C2D8E3E9A4C80));
		Provider.onEnemyDisconnected = (EnemyDisconnected)Delegate.Remove((Delegate?)(object)Provider.onEnemyDisconnected, (Delegate?)new EnemyDisconnected(_0E2BCDD281F842D0));
		Provider.onBattlEyeKick -= _7D26298FE96945EE;
		UseableGun.onBulletHit -= A44D5F91C90443DE;
		PlayerAnimator.OnGestureChanged_Global -= AD5F98A52EC44832;
		foreach (SteamPlayer client in Provider.clients)
		{
			if (!((Object)(object)client.player == (Object)null))
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(client.player);
				if (a3116505AAB != null)
				{
					_2A320E2F1A3D4AAC.F78AC99C9530449C(client, a3116505AAB);
				}
			}
		}
		A3116505AAB24996.C23919949D8440FA.Clear();
		base.C4CA2ECFAD654E77();
	}

	private void AD5F98A52EC44832(PlayerAnimator P_0, EPlayerGesture P_1)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		F0CD1E00058640DE.playerTracking.F05B22B752C743A2(((PlayerCaller)P_0).player)._12878EC8DCE341EE._0BD0BA5C877B4CB4(P_1);
	}

	private void A44D5F91C90443DE(UseableGun P_0, BulletInfo P_1, InputInfo P_2, ref bool P_3)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)((PlayerCaller)P_0).player == (Object)null || P_0.equippedGunAsset == null || (Object)(object)P_2.transform == (Object)null)
		{
			return;
		}
		using (_39E21C30FEBE4EB6._5D65B053CE1947AD())
		{
			A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)P_0).player);
			if (a3116505AAB != null)
			{
				List<_4819911A0C0846FF._3147FDB5568446E9> list = a3116505AAB._39063EF1442C4822.F933B05D5259474E.FindAll([MethodImpl(MethodImplOptions.NoInlining)] (_4819911A0C0846FF._3147FDB5568446E9 obj) => (obj.F9050CCFB6B5492C ? 1 : 0) == _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
				if (list.Count == 0)
				{
					throw new NullReferenceException("404");
				}
				bool _077EF09404D34FE = false;
				bool flag = P_3;
				A76A63943FD04779._89D43889C2AB4B27?.Invoke(a3116505AAB, P_0, list, P_2, ref P_3, ref _077EF09404D34FE);
				if ((Object)(object)P_2.player != (Object)null || (Object)(object)P_2.animal != (Object)null || (Object)(object)P_2.zombie != (Object)null)
				{
					a3116505AAB._638733A069E74AA4._53C55A88896D458A = P_2.direction;
					a3116505AAB._638733A069E74AA4._0DBA8EE1BBAB4C34 = P_2.point;
				}
				if ((Object)(object)P_2.player != (Object)null)
				{
					a3116505AAB._638733A069E74AA4._080940434C504A7C.Add(new EA091ED8BF2C4A64.A868F02C1F7141CA
					{
						_8B19A6E1795045B9 = list,
						AE92804C67564138 = P_2.point
					});
				}
				if ((_077EF09404D34FE & flag) && !P_3)
				{
					_22F8E66F55C24C0E._3B1EE6DC390B49EE(((PlayerCaller)P_0).player, P_1, P_2);
				}
			}
		}
	}

	private void _0916834C25A248A7(CSteamID P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		Player player = PlayerTool.getPlayer(P_0);
		if ((Object)(object)player == (Object)null)
		{
			return;
		}
		_64A4BBC5E4CE4EE1.F8961D8251614431.Invoke()++;
		foreach (SteamPlayer client in Provider.clients)
		{
			if (client != player.channel.owner)
			{
				_5015949A1C06489C.Clear();
				_5015949A1C06489C.Add(client);
				EE4961E8242B4B98.Invoke<ushort, SteamPlayer>((ENetReliability)0, ((SteamConnectedClientBase)player.channel.owner).transportConnection, (Action<NetPakWriter, ushort, SteamPlayer>)_4BA4875606294E68, (ushort)1, player.channel.owner);
				_5015949A1C06489C.Clear();
				_5015949A1C06489C.Add(player.channel.owner);
				EE4961E8242B4B98.Invoke<ushort, SteamPlayer>((ENetReliability)0, ((SteamConnectedClientBase)client).transportConnection, (Action<NetPakWriter, ushort, SteamPlayer>)_4BA4875606294E68, (ushort)1, client);
			}
		}
		F0CD1E00058640DE.playerTracking.F05B22B752C743A2(player)._3FE17818BFA04239 = new PlayerStateUpdate(((Component)player).transform.position, player.look.angle, player.look.rot);
	}

	private void _4BA4875606294E68(NetPakWriter P_0, ushort P_1, SteamPlayer P_2)
	{
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		SystemNetPakWriterEx.WriteUInt32(P_0, _64A4BBC5E4CE4EE1.F8961D8251614431.Invoke());
		SystemNetPakWriterEx.WriteUInt16(P_0, P_1);
		foreach (SteamPlayer item in _5015949A1C06489C)
		{
			SystemNetPakWriterEx.WriteUInt8(P_0, (byte)item.channel);
			if (_64A4BBC5E4CE4EE1._428211F609CD446A.Invoke(item.player.movement))
			{
				PlayerStateUpdate val = _64A4BBC5E4CE4EE1._5627CF87C9F0423B.Invoke(item.player.movement);
				UnityNetPakWriterEx.WriteClampedVector3(P_0, val.pos, 13, 7);
				SystemNetPakWriterEx.WriteUInt8(P_0, val.angle);
				SystemNetPakWriterEx.WriteUInt8(P_0, val.rot);
			}
			else
			{
				UnityNetPakWriterEx.WriteClampedVector3(P_0, ((Component)item.player).transform.position, 13, 7);
				SystemNetPakWriterEx.WriteUInt8(P_0, item.player.look.angle);
				SystemNetPakWriterEx.WriteUInt8(P_0, item.player.look.rot);
			}
		}
	}

	private void _364C2D8E3E9A4C80(SteamPlayer P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (!_9AB67761792440A7._7A43F8465BE04590(((object)P_0.playerID.steamID/*cast due to constrained. prefix*/).ToString()))
		{
			A3116505AAB24996.FCD5ADEC1258490A(P_0.player);
			B0385A2EEF704492(P_0.player);
			_772C72BB580840D2(P_0.player);
		}
	}

	private void _0E2BCDD281F842D0(SteamPlayer P_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		CSteamID steamID = P_0.playerID.steamID;
		A3116505AAB24996.C23919949D8440FA.TryRemove(steamID, out A3116505AAB24996 _);
		_379079320C04450F?.ADAA9521257F4886().TryRemove(steamID, out C7A753824C0746AE._359F714CB1DB4E96 _);
		_760EF57D5259421C.E7E669564ABD4ED3.DE1F41CD69D248AC(steamID);
		if (!ConfigurationBinder.GetValue<bool>(_760EF57D5259421C._1D28939F0C774697, "Settings:KeepVerboseAfterExit", true))
		{
			_760EF57D5259421C.E7E669564ABD4ED3.C3BAAC3F99224A6F(steamID);
		}
	}

	public void _7D26298FE96945EE(SteamPlayer P_0, string P_1)
	{
		B44A5B1C66034650 CS_0024_003C_003E8__locals3 = new B44A5B1C66034650();
		CS_0024_003C_003E8__locals3._6256BB80450F44EF = P_0;
		CS_0024_003C_003E8__locals3.B3586207E3CF4F5A = P_1;
		_1FFBEDFB3FCE4374._533FDA357CCF49A3("Webhook-Scheduler", [MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(B44A5B1C66034650._89AA6EA3FE0C4E7B))] () =>
		{
			B44A5B1C66034650._89AA6EA3FE0C4E7B stateMachine = default;
			stateMachine._385B7BACA1454295 = AsyncTaskMethodBuilder.Create();
			stateMachine.A1D9ADAEF6174135 = CS_0024_003C_003E8__locals3;
			while (true)
			{
				int num = 523194796;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(~(~(~(~(-num2)))) * 145575577 - unchecked(1626023527 * -210830785)))) % 3)
					{
					case 0u:
						break;
					case 2u:
						goto IL_004a;
					default:
						return stateMachine._385B7BACA1454295.Task;
					}
					break;
					IL_004a:
					stateMachine._6D8BAB6BEC294518 = _003CModule_003E._3F57E81A62734AC2<int>(380280467);
					stateMachine._385B7BACA1454295.Start(ref stateMachine);
					num = -1811994818;
				}
			}
		}, _760EF57D5259421C.C5EE769F130A487C.A70B1408B5ED4F4E, [MethodImpl(MethodImplOptions.NoInlining)] (Exception ex) =>
		{
			AFA1A0F8FA6A444A._212DA57A91504DBB(_760EF57D5259421C._45BE54DAE6C14D66, ex, _003CModule_003E._3F57E81A62734AC2<string>(1327307477), Array.Empty<object>());
		});
	}

	private void B0385A2EEF704492(Player P_0)
	{
		_2C639165A13F453C CS_0024_003C_003E8__locals4 = new _2C639165A13F453C();
		CS_0024_003C_003E8__locals4._164E597D0BAE4E1D = P_0;
		IPAddress address = ((SteamConnectedClientBase)CS_0024_003C_003E8__locals4._164E597D0BAE4E1D.channel.owner).transportConnection.GetAddress();
		CS_0024_003C_003E8__locals4._9FC12C3ADFFA4BE3 = _940E7DA0BB8C4762(address);
		_1FFBEDFB3FCE4374._533FDA357CCF49A3("CheckIP-Task", [MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_2C639165A13F453C._8A682B38790A4F32))] () =>
		{
			_2C639165A13F453C._8A682B38790A4F32 stateMachine = default;
			stateMachine._5A8F848D2A4A4DFE = AsyncTaskMethodBuilder.Create();
			stateMachine._035E023727F94BCC = CS_0024_003C_003E8__locals4;
			stateMachine._6F0022F0B9E0431A = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
			stateMachine._5A8F848D2A4A4DFE.Start(ref stateMachine);
			return stateMachine._5A8F848D2A4A4DFE.Task;
		}, _1DB744298E9F4B09._052FBC588F454484.A70B1408B5ED4F4E);
	}

	private void _772C72BB580840D2(Player P_0)
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		_6EB690586262415C CS_0024_003C_003E8__locals16 = new _6EB690586262415C();
		CS_0024_003C_003E8__locals16._8FD3517F14EB428D = P_0;
		CS_0024_003C_003E8__locals16._8F25088495B7436E = this;
		CS_0024_003C_003E8__locals16.A3E3384DB8AB4C09 = CS_0024_003C_003E8__locals16._8FD3517F14EB428D.channel.owner.playerID;
		CS_0024_003C_003E8__locals16.A680E44AD784417F = CS_0024_003C_003E8__locals16.A3E3384DB8AB4C09.GetHwids().ToList();
		if (_64BD05BBDD974060(CS_0024_003C_003E8__locals16._8FD3517F14EB428D, CS_0024_003C_003E8__locals16.A680E44AD784417F, out string text))
		{
			CDB7F915DDEB4F85 cDB7F915DDEB4F = D30CFAEA6C414B2B._3ECE4ABFF9E04BFF<CDB7F915DDEB4F85>();
			cDB7F915DDEB4F.F130FD183F724D96 = CS_0024_003C_003E8__locals16._8FD3517F14EB428D.channel.owner.playerID.steamID.m_SteamID;
			cDB7F915DDEB4F._5D6E1455321849A3 = text;
			cDB7F915DDEB4F._44694241B9E24721 = _64A4BBC5E4CE4EE1._7B1216BE8CDA4953.Invoke(CS_0024_003C_003E8__locals16._8FD3517F14EB428D.channel.owner);
			cDB7F915DDEB4F._7807214BEE9E482E = CS_0024_003C_003E8__locals16.A680E44AD784417F.Count;
			foreach (byte[] item in CS_0024_003C_003E8__locals16.A680E44AD784417F)
			{
				cDB7F915DDEB4F._0C699508D85F4D7A.Add(Hash.toString(item));
			}
			D30CFAEA6C414B2B.CB4E939A3F83474C("HWID Spoof", cDB7F915DDEB4F);
		}
		if (_0AC63CDAB63A4FA8 == null)
		{
			return;
		}
		CS_0024_003C_003E8__locals16._5C01A68F3FA24B42 = _9AB67761792440A7._00FC653ED33A4A96();
		_1FFBEDFB3FCE4374._533FDA357CCF49A3($"Hwid-Checker-{CS_0024_003C_003E8__locals16.A3E3384DB8AB4C09.steamID}", [MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_6EB690586262415C._770D94533A4E41C6))] () =>
		{
			_6EB690586262415C._770D94533A4E41C6 stateMachine = default;
			stateMachine._5C88713820234942 = AsyncTaskMethodBuilder.Create();
			while (true)
			{
				int num = -1700177165;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((((~2017767847 + -unchecked(663980652 * 1020180449) - (~(~(unchecked(-882539205 + -1811854267) - (-32549010 - -479410167) - unchecked(1705235156 + 2099148232) + -896385609) + (~(-(-185836619 + (0x5BECA8F3 ^ 0x612FD409))) - (-201021096 ^ ~(-1781554309 * --927412942))) - ~num2) - (0x7E22C531 ^ 0xE234F71))) ^ (--1673222636 - --1114870370)) - unchecked(-496164312 * 1288551161)) ^ 0x243A4B59)) % 5)
					{
					case 3u:
						break;
					case 1u:
						stateMachine._749E31D6551541D7 = CS_0024_003C_003E8__locals16;
						num = ((int)num3 * -1810006875) ^ -375922125;
						continue;
					case 4u:
						stateMachine.DA65C30F09A04D99 = _003CModule_003E._390073C602714496<int>(-736908096);
						num = -404903234;
						continue;
					case 2u:
						stateMachine._5C88713820234942.Start(ref stateMachine);
						num = (int)(num3 * 198362227) ^ -115028838;
						continue;
					default:
						return stateMachine._5C88713820234942.Task;
					}
					break;
				}
			}
		}, _760EF57D5259421C.C5EE769F130A487C.A70B1408B5ED4F4E, [MethodImpl(MethodImplOptions.NoInlining)] (Exception ex) =>
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			_6EB690586262415C._27F452752EE64D44(_760EF57D5259421C._45BE54DAE6C14D66, ex, _6EB690586262415C._9879BBFF056F4676(_003CModule_003E._390073C602714496<string>(-1075241634), (object)_6EB690586262415C._11155983E2BC4801((object)CS_0024_003C_003E8__locals16.A3E3384DB8AB4C09)), Array.Empty<object>());
		});
	}

	private void CC1FA79CE89A4EA2(string P_0, Player P_1)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		_5B1EF2191BB64736 CS_0024_003C_003E8__locals4 = new _5B1EF2191BB64736();
		CS_0024_003C_003E8__locals4._01E9530A0B904909 = P_1;
		CS_0024_003C_003E8__locals4._21A7493C1AC84C3B = P_0;
		if (ConfigurationBinder.GetValue<bool>(_760EF57D5259421C._1D28939F0C774697, "Detections:Analysis:HWIDSpoof:Enabled", false))
		{
			_64A4BBC5E4CE4EE1.E6DC166DE03C47D7((ConfigurationBinder.GetValue<string>(_760EF57D5259421C._1D28939F0C774697, "Detections:Analysis:HWIDSpoof:Punishment", "") ?? "").Replace("[steamID]", ((object)CS_0024_003C_003E8__locals4._01E9530A0B904909.channel.owner.playerID.steamID/*cast due to constrained. prefix*/).ToString()));
			_1FFBEDFB3FCE4374._533FDA357CCF49A3("Webhook-Scheduler", [MethodImpl(MethodImplOptions.NoInlining)] [AsyncStateMachine(typeof(_5B1EF2191BB64736._140DAD5F3D7443AB))] () =>
			{
				_5B1EF2191BB64736._140DAD5F3D7443AB stateMachine = default;
				stateMachine._834F5B47477046DA = AsyncTaskMethodBuilder.Create();
				stateMachine.A2E5F6E2C6F044AE = CS_0024_003C_003E8__locals4;
				stateMachine._1F1F37EEBBF54095 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817);
				stateMachine._834F5B47477046DA.Start(ref stateMachine);
				return stateMachine._834F5B47477046DA.Task;
			}, _760EF57D5259421C.C5EE769F130A487C.A70B1408B5ED4F4E, [MethodImpl(MethodImplOptions.NoInlining)] (Exception ex) =>
			{
				AFA1A0F8FA6A444A._212DA57A91504DBB(_760EF57D5259421C._45BE54DAE6C14D66, ex, _003CModule_003E._390073C602714496<string>(-247424266), Array.Empty<object>());
			});
		}
	}

	private int _6748C1C6E17847D9(ulong P_0, int P_1, long P_2, string P_3)
	{
		IEnumerable<string> enumerable = _0AC63CDAB63A4FA8.E6CEB4BA92AA4EB5._725A098C42D04D27(P_0, P_1, P_2, 86400000L);
		int num = 0;
		foreach (string item in enumerable)
		{
			if (P_3 == item)
			{
				return 0;
			}
			num++;
		}
		return num;
	}

	private static string _940E7DA0BB8C4762(IPAddress P_0)
	{
		if (P_0.IsIPv4MappedToIPv6)
		{
			P_0 = P_0.MapToIPv4();
			if (_6801593A2CB54E1D(P_0))
			{
				return string.Empty;
			}
		}
		if (IPAddress.IsLoopback(P_0) || P_0.Equals(IPAddress.IPv6None) || P_0.Equals(IPAddress.None) || P_0.Equals(IPAddress.Any) || P_0.Equals(IPAddress.IPv6Any))
		{
			return string.Empty;
		}
		return P_0.ToString();
	}

	private static bool _6801593A2CB54E1D(IPAddress P_0)
	{
		byte[] addressBytes = P_0.GetAddressBytes();
		if (addressBytes[0] == 10)
		{
			return true;
		}
		if (addressBytes[0] == 172 && addressBytes[1] >= 16 && addressBytes[1] <= 31)
		{
			return true;
		}
		if (addressBytes[0] == 192 && addressBytes[1] == 168)
		{
			return true;
		}
		if (addressBytes[0] == 169 && addressBytes[1] == 254)
		{
			return true;
		}
		return false;
	}

	private static bool _7B88220BFD86406A(List<byte[]> P_0)
	{
		for (int i = 0; i < P_0.Count; i++)
		{
			for (int j = i + 1; j < P_0.Count; j++)
			{
				if (AB0A2FFB3CCF4B23(P_0[i], P_0[j]))
				{
					return true;
				}
			}
		}
		return false;
	}

	private static bool AB0A2FFB3CCF4B23(byte[] P_0, byte[] P_1)
	{
		if (P_0 == P_1)
		{
			return true;
		}
		if (P_0 == null || P_1 == null || P_0.Length != P_1.Length)
		{
			return false;
		}
		for (int i = 0; i < P_0.Length; i++)
		{
			if (P_0[i] != P_1[i])
			{
				return false;
			}
		}
		return true;
	}

	private static bool _64BD05BBDD974060(Player P_0, List<byte[]> P_1, out string P_2)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		P_2 = "";
		EClientPlatform val = _64A4BBC5E4CE4EE1._7B1216BE8CDA4953.Invoke(P_0.channel.owner);
		int count = P_1.Count;
		if (count == 0 || count > 8)
		{
			P_2 = "type: A";
			return true;
		}
		int num = (((int)val == 0) ? 3 : 2);
		if (count != num)
		{
			P_2 = "type: B";
			return true;
		}
		if (_7B88220BFD86406A(P_1))
		{
			P_2 = "type: C";
			return true;
		}
		double num2 = 0.0;
		for (int i = 0; i < count; i++)
		{
			byte[] array = P_1[i];
			if (FEF597D011644FAF(array))
			{
				P_2 = "type: D";
				return true;
			}
			ulong num3 = BitConverter.ToUInt64(array, 0) - P_0.channel.owner.playerID.steamID.m_SteamID;
			if (num3 == 0L || num3 == 87654321012345678L || num3 == 76543210123456789L || num3 == 65432101234567890L)
			{
				P_2 = "type: E";
				return true;
			}
			int num4 = _94CD655BB7624B58(array);
			if (num4 > 4)
			{
				P_2 = $"type: G (z: {num4} i: {i} l: {array.Length})";
				return true;
			}
			num2 += _62353641AFA94B14(array);
		}
		int num5 = num * 4;
		if (num2 < (double)num5)
		{
			P_2 = $"type: F (e: {num2} m: {num5})";
			return true;
		}
		return false;
	}

	public static double _62353641AFA94B14(byte[] P_0)
	{
		if (P_0 == null || P_0.Length == 0)
		{
			return 0.0;
		}
		int[] array = new int[256];
		foreach (byte b in P_0)
		{
			array[b]++;
		}
		double num = 0.0;
		double num2 = P_0.Length;
		double num3 = Math.Log(2.0);
		for (int j = 0; j < 256; j++)
		{
			if (array[j] > 0)
			{
				double num4 = (double)array[j] / num2;
				double num5 = Math.Log(num4) / num3;
				num -= num4 * num5;
			}
		}
		return num;
	}

	private static int _94CD655BB7624B58(ReadOnlySpan<byte> P_0)
	{
		int num = 0;
		ReadOnlySpan<byte> readOnlySpan = P_0;
		for (int i = 0; i < readOnlySpan.Length; i++)
		{
			if (readOnlySpan[i] == 0)
			{
				num++;
			}
		}
		return num;
	}

	private static bool FEF597D011644FAF(ReadOnlySpan<byte> P_0)
	{
		if (P_0.Length <= 1)
		{
			return false;
		}
		byte b = P_0[0];
		for (int i = 1; i < P_0.Length; i++)
		{
			if (P_0[i] != b)
			{
				return false;
			}
		}
		return true;
	}
}
