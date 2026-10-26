using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

internal class _1g
{
	[CompilerGenerated]
	private sealed class _rM
	{
		[StructLayout(LayoutKind.Auto)]
		private struct _eN : IAsyncStateMachine
		{
			public int _xI;

			public AsyncTaskMethodBuilder _5E;

			public _rM _pk;

			private TaskAwaiter _xM;

			[MethodImpl(MethodImplOptions.NoInlining)]
			private void MoveNext()
			{
				_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(4013883969u);
				int num6 = default(int);
				TaskAwaiter awaiter = default(TaskAwaiter);
				while (true)
				{
					int num = -500315622;
					while (true)
					{
						int num2 = num;
						int num15;
						uint num3;
						switch ((num3 = (uint)((-(num2 ^ (-(-(~1994730746)) + ~(-((-1067437969 + (574611029 + --1183291844)) ^ 0x36462AC7)))) + 1233665046) ^ -647153992)) % 3)
						{
						case 0u:
							break;
						case 2u:
							goto IL_00a1;
						default:
							{
								_rM rM = _pk;
								try
								{
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 429496300u);
									while (true)
									{
										IL_00d0:
										int num4 = 556182398;
										while (true)
										{
											num2 = num4;
											switch ((num3 = (uint)((-(num2 ^ (-(-(~1994730746)) + ~(-((-1067437969 + (574611029 + --1183291844)) ^ 0x36462AC7)))) + 1233665046) ^ -647153992)) % 3)
											{
											case 0u:
												break;
											case 1u:
												goto IL_0165;
											default:
												try
												{
													obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 623166605u);
													while (true)
													{
														IL_0189:
														int num5 = -88928181;
														while (true)
														{
															num2 = num5;
															switch ((num3 = (uint)((-(num2 ^ (-(-(~1994730746)) + ~(-((-1067437969 + (574611029 + --1183291844)) ^ 0x36462AC7)))) + 1233665046) ^ -647153992)) % 15)
															{
															case 14u:
																break;
															default:
																goto end_IL_018e;
															case 12u:
															{
																int num9;
																int num10;
																if (num6 != 0)
																{
																	num9 = -51580092;
																	num10 = num9;
																}
																else
																{
																	num9 = 888296194;
																	num10 = num9;
																}
																num5 = num9 ^ ((int)num3 * -259221956);
																continue;
															}
															case 5u:
																obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3979782376u);
																num5 = 995204064;
																continue;
															case 8u:
																_xM = awaiter;
																num5 = (int)((num3 * 773960969) ^ 0x18BCAC61);
																continue;
															case 6u:
																obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1811144072u);
																num5 = (int)((num3 * 1861390325) ^ 0x5A63CD5A);
																continue;
															case 1u:
																num6 = (_xI = global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x2A425EDF ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 608795964u))));
																num5 = (int)(num3 * 176604439) ^ -455806272;
																continue;
															case 0u:
																awaiter = _xM;
																num5 = -714235441;
																continue;
															case 13u:
															{
																int num7;
																int num8;
																if (awaiter.IsCompleted)
																{
																	num7 = -1369487931;
																	num8 = num7;
																}
																else
																{
																	num7 = 1255502628;
																	num8 = num7;
																}
																num5 = num7 ^ ((int)num3 * -1418885185);
																continue;
															}
															case 3u:
																awaiter = _200E_206F_200F_206F_202A_202C_206C_206B_202A_206C_206F_206F_202E_202B_200C_206B_206B_200E_202B_200D_206E_206B_202D_200E_202A_202B_206D_200D_206B_202A_206C_206F_206B_200E_206D_200E_200B_200D_202C_206D_202E((object)rM._wF());
																num5 = (int)((num3 * 1598970588) ^ 0x37AEE7A8);
																continue;
															case 7u:
																_5E.AwaitUnsafeOnCompleted(ref awaiter, ref this);
																num5 = ((int)num3 * -1460429346) ^ 0x5F46BDEC;
																continue;
															case 9u:
																obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1811144072u);
																num6 = (_xI = global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x3DA873B8 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 0u))));
																num5 = ((int)num3 * -1293697369) ^ -82005581;
																continue;
															case 2u:
																goto end_IL_00d5;
															case 11u:
																awaiter.GetResult();
																num5 = ((int)num3 * -1100568779) ^ -1520171291;
																continue;
															case 10u:
																_xM = default(TaskAwaiter);
																num5 = ((int)num3 * -1501346404) ^ 0x5636506A;
																continue;
															case 4u:
																goto end_IL_018e;
															}
															goto IL_0189;
															continue;
															end_IL_018e:
															break;
														}
														break;
													}
												}
												catch (Exception ex)
												{
													obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2947453723u);
													Exception ex2 = ex;
													while (true)
													{
														IL_0416:
														int num11 = -832607003;
														while (true)
														{
															num2 = num11;
															switch ((num3 = (uint)((-(num2 ^ (-(-(~1994730746)) + ~(-((-1067437969 + (574611029 + --1183291844)) ^ 0x36462AC7)))) + 1233665046) ^ -647153992)) % 11)
															{
															case 0u:
																break;
															default:
																goto end_IL_041b;
															case 2u:
																num11 = ((int)num3 * -1038633093) ^ 0xD7D7A6E;
																continue;
															case 5u:
																obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2761483948u);
																num11 = ((int)num3 * -713653610) ^ 0xC06DEC4;
																continue;
															case 9u:
																obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 442579387u);
																num11 = ((int)num3 * -788546289) ^ -1374630524;
																continue;
															case 3u:
																_200C_202A_206C_200F_202B_200C_202E_206C_202A_200D_200C_202E_206F_200C_200D_200D_202A_200F_200B_206D_200B_206D_206D_200C_206F_202C_206F_206F_206F_200B_200D_206F_206C_206A_200F_206A_206A_206F_206A_206D_202E(_206A_200F_200E_206B_202C_202A_206D_202A_200B_206C_200D_202E_206D_206C_206E_202D_202D_202A_206D_200C_202E_206D_200C_200D_200E_202E_202D_202D_200D_206C_206A_202E_206A_200E_206A_202D_202D_206F_200D_206D_202E(global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<string>(-1715319677 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2761483948u)), (object)rM._AC, (object)ex2));
																num11 = 958312340;
																continue;
															case 4u:
																rM._4m(ex2);
																num11 = ((int)num3 * -2100659397) ^ -499915440;
																continue;
															case 10u:
																obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1415862162u);
																num11 = 336376129;
																continue;
															case 7u:
																obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 2517673434u);
																num11 = (int)(num3 * 445735276) ^ -1583701509;
																continue;
															case 8u:
															{
																int num12;
																int num13;
																if (rM._4m == null)
																{
																	num12 = -741394380;
																	num13 = num12;
																}
																else
																{
																	num12 = 601504616;
																	num13 = num12;
																}
																num11 = num12 ^ (int)(num3 * 336458776);
																continue;
															}
															case 1u:
																obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3737908602u);
																num11 = (int)((num3 * 367681511) ^ 0x41795562);
																continue;
															case 6u:
																goto end_IL_041b;
															}
															goto IL_0416;
															continue;
															end_IL_041b:
															break;
														}
														break;
													}
												}
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 4019370497u);
												goto IL_0733;
											}
											goto IL_00d0;
											IL_0165:
											num4 = (int)((num3 * 109490418) ^ 0x629BCDFC);
											continue;
											end_IL_00d5:
											break;
										}
										break;
									}
								}
								catch (Exception ex3)
								{
									obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1105589239u);
									Exception exception = ex3;
									while (true)
									{
										IL_0619:
										int num14 = 777046643;
										while (true)
										{
											num2 = num14;
											switch ((num3 = (uint)((-(num2 ^ (-(-(~1994730746)) + ~(-((-1067437969 + (574611029 + --1183291844)) ^ 0x36462AC7)))) + 1233665046) ^ -647153992)) % 4)
											{
											case 0u:
												break;
											default:
												goto end_IL_061e;
											case 2u:
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3148531518u);
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3163364534u);
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 323446151u);
												_xI = global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-495818346 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 4130563254u));
												num14 = (int)((num3 * 1492007031) ^ 0x65B93F18);
												continue;
											case 1u:
												_5E.SetException(exception);
												num14 = ((int)num3 * -246116366) ^ 0x6A88CAE6;
												continue;
											case 3u:
												goto end_IL_061e;
											}
											goto IL_0619;
											continue;
											end_IL_061e:
											break;
										}
										break;
									}
								}
								goto IL_0820;
							}
							IL_0733:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 315184920u);
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3420178237u);
							_xI = global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-610832529 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 0u));
							goto IL_0769;
							IL_0769:
							num15 = -832369966;
							goto IL_076e;
							IL_076e:
							while (true)
							{
								num2 = num15;
								switch ((num3 = (uint)((-(num2 ^ (-(-(~1994730746)) + ~(-((-1067437969 + (574611029 + --1183291844)) ^ 0x36462AC7)))) + 1233665046) ^ -647153992)) % 4)
								{
								case 0u:
									break;
								default:
									return;
								case 1u:
									_5E.SetResult();
									num15 = (int)((num3 * 988079583) ^ 0x59421F2B);
									continue;
								case 3u:
									goto IL_0820;
								case 2u:
									return;
								}
								break;
							}
							goto IL_0769;
							IL_0820:
							obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(911618918u);
							num15 = -557341573;
							goto IL_076e;
						}
						break;
						IL_00a1:
						num6 = _xI;
						num = ((int)num3 * -2110352593) ^ -390140365;
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
				_5E.SetStateMachine(stateMachine);
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}

			static TaskAwaiter _200E_206F_200F_206F_202A_202C_206C_206B_202A_206C_206F_206F_202E_202B_200C_206B_206B_200E_202B_200D_206E_206B_202D_200E_202A_202B_206D_200D_206B_202A_206C_206F_206B_200E_206D_200E_200B_200D_202C_206D_202E(object P_0)
			{
				return ((Task)P_0).GetAwaiter();
			}

			static string _206A_200F_200E_206B_202C_202A_206D_202A_200B_206C_200D_202E_206D_206C_206E_202D_202D_202A_206D_200C_202E_206D_200C_200D_200E_202E_202D_202D_200D_206C_206A_202E_206A_200E_206A_202D_202D_206F_200D_206D_202E(string P_0, object P_1, object P_2)
			{
				return string.Format(P_0, P_1, P_2);
			}

			static void _200C_202A_206C_200F_202B_200C_202E_206C_202A_200D_200C_202E_206F_200C_200D_200D_202A_200F_200B_206D_200B_206D_206D_200C_206F_202C_206F_206F_206F_200B_200D_206F_206C_206A_200F_206A_206A_206F_206A_206D_202E(string P_0)
			{
				Console.WriteLine(P_0);
			}
		}

		public Func<Task> _wF;

		public Action<Exception> _4m;

		public string _AC;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[AsyncStateMachine(typeof(_eN))]
		internal T0 _4h<T0>()
		{
			_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2396607600u);
			_eN stateMachine = default(_eN);
			while (true)
			{
				int num = 1050617424;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(~(~(1264392300 + 2136109869) - (-((0x497469DB ^ -890433972) - (0x5424E830 ^ -1700286727)) - ~(~(-((0x459F9B2B ^ 0x4FC913F4) - (-1445636788 ^ -1704904492) * 1210994239)) - -1669831365 - ~num2) * -827515075))))) % 6)
					{
					case 2u:
						break;
					case 0u:
						stateMachine._5E.Start(ref stateMachine);
						num = ((int)num3 * -6219212) ^ 0x4923822A;
						continue;
					case 4u:
						stateMachine._pk = this;
						num = ((int)num3 * -1734557001) ^ 0x8830862;
						continue;
					case 3u:
						stateMachine._xI = global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x3A426AA1 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 522222916u)));
						num = ((int)num3 * -746780413) ^ 0x78DF4BE8;
						continue;
					case 5u:
						stateMachine._5E = AsyncTaskMethodBuilder.Create();
						num = (int)((num3 * 1785864040) ^ 0x42201A17);
						continue;
					default:
						return (T0)stateMachine._5E.Task;
					}
					break;
				}
			}
		}
	}

	public static void _VJ(string P_0, Func<Task> P_1, Action<Exception>? P_2 = null)
	{
		_202C_202D_200D_206A_206B_206F_200D_206E_200D_206A_202C_202D_202A_200B_200D_200C_202B_206C_202D_200B_202B_206D_206A_202E_200B_202B_206E_200C_202E_206C_200E_202D_206F_202E_206C_206A_206F_206A_200C_200E_202E(P_0, P_1, (CancellationToken?)null, P_2);
	}

	public static void _lk(string P_0, Func<Task> P_1, CancellationToken? P_2, Action<Exception>? P_3 = null)
	{
		object obj = _202E_200F_202B_200F_206E_200C_202E_202B_202D_206F_200B_206E_206E_206D_202D_206A_206C_200B_200F_202C_200D_202C_200B_206F_202E_200F_206B_206A_206B_200B_202B_206B_206F_202E_206D_206B_206B_206E_200F_202C_202E();
		((_rM)obj)._wF = P_1;
		((_rM)obj)._4m = P_3;
		((_rM)obj)._AC = P_0;
		_206E_206E_202A_206F_200E_206C_202C_206A_206C_202B_200E_206F_206E_202D_202C_202A_206B_202C_206B_206A_200D_206C_202A_206F_200B_206A_200F_206D_202B_202B_202B_206C_202D_202D_200D_206E_202D_200B_206B_200D_202E((Func<Task>)((_rM)obj)._4h<Task>, P_2 ?? CancellationToken.None);
	}

	static void _202C_202D_200D_206A_206B_206F_200D_206E_200D_206A_202C_202D_202A_200B_200D_200C_202B_206C_202D_200B_202B_206D_206A_202E_200B_202B_206E_200C_202E_206C_200E_202D_206F_202E_206C_206A_206F_206A_200C_200E_202E(string P_0, Func<Task> P_1, CancellationToken? P_2, Action<Exception> P_3)
	{
		_lk(P_0, P_1, P_2, P_3);
	}

	static object _202E_200F_202B_200F_206E_200C_202E_202B_202D_206F_200B_206E_206E_206D_202D_206A_206C_200B_200F_202C_200D_202C_200B_206F_202E_200F_206B_206A_206B_200B_202B_206B_206F_202E_206D_206B_206B_206E_200F_202C_202E()
	{
		return new _rM();
	}

	static object _206E_206E_202A_206F_200E_206C_202C_206A_206C_202B_200E_206F_206E_202D_202C_202A_206B_202C_206B_206A_200D_206C_202A_206F_200B_206A_200F_206D_202B_202B_202B_206C_202D_202D_200D_206E_202D_200B_206B_200D_202E(Func<Task> P_0, CancellationToken P_1)
	{
		return Task.Run(P_0, P_1);
	}
}
