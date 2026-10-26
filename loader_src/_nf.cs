using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using SDG.Unturned;

internal static class _nf
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _Me : IAsyncStateMachine
	{
		public int _hm;

		public AsyncTaskMethodBuilder _PL;

		public TimeSpan? _3i;

		public CancellationToken _rm;

		public int _fH;

		private CancellationTokenSource _oE;

		private CancellationToken _LC;

		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _Bn;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1081174848u);
			int num = _hm;
			try
			{
				obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2080962658u);
				ConfiguredTaskAwaitable.ConfiguredTaskAwaiter awaiter = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
				ConfiguredTaskAwaitable configuredTaskAwaitable = default(ConfiguredTaskAwaitable);
				while (true)
				{
					IL_0022:
					int num2 = -1700211186;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(-((num3 + (--729813401 + ~(0x7A74CE2A ^ -372170856) + ~(780002388 * -1292250743) * 1917626477)) ^ (-(-(2021999447 * (1255957304 - 605249731)) ^ 0x6C860BAA) ^ 0x676C8209)) - (-(~(~-1638776303)) ^ -1420580384) + (-743526571 ^ 0x269087F3))) % 6)
						{
						case 3u:
							break;
						case 0u:
						{
							object oE;
							if (!_3i.HasValue)
							{
								obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3452296313u);
								oE = null;
							}
							else
							{
								CancellationToken[] array = new CancellationToken[global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1697122619 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3249686113u))];
								obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 209164824u);
								array[global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-2021989474 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 0u))] = _rm;
								oE = _206D_206C_200F_206A_200F_202A_206A_202B_202A_206A_206F_202E_200D_206B_206D_206C_200E_202A_202B_202A_206C_200C_200C_202D_200B_202B_200F_206B_206D_202B_206A_206D_206A_202D_206A_200D_206E_206C_206E_202D_202E(array);
							}
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1209109513u);
							_oE = (CancellationTokenSource)oE;
							num2 = -1165548112;
							continue;
						}
						case 5u:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2245283952u);
							num2 = (int)(num4 * 975344785) ^ -1313902319;
							continue;
						case 2u:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1056738779u);
							num2 = -699226301;
							continue;
						case 4u:
						{
							int num19;
							int num20;
							if (num == 0)
							{
								num19 = -2089645508;
								num20 = num19;
							}
							else
							{
								num19 = -1299757729;
								num20 = num19;
							}
							num2 = num19 ^ ((int)num4 * -187435145);
							continue;
						}
						default:
							try
							{
								obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3397145807u);
								while (true)
								{
									IL_020d:
									int num5 = -526275864;
									while (true)
									{
										num3 = num5;
										switch ((num4 = (uint)(-((num3 + (--729813401 + ~(0x7A74CE2A ^ -372170856) + ~(780002388 * -1292250743) * 1917626477)) ^ (-(-(2021999447 * (1255957304 - 605249731)) ^ 0x6C860BAA) ^ 0x676C8209)) - (-(~(~-1638776303)) ^ -1420580384) + (-743526571 ^ 0x269087F3))) % 28)
										{
										case 10u:
											break;
										default:
											goto end_IL_0212;
										case 19u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3448287733u);
											num5 = -1777798732;
											continue;
										case 23u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3223369251u);
											num5 = (int)((num4 * 1266248180) ^ 0x6A68530D);
											continue;
										case 16u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2222113077u);
											num5 = (int)((num4 * 123782787) ^ 0x30D5AA1B);
											continue;
										case 21u:
											awaiter.GetResult();
											num5 = ((int)num4 * -69941516) ^ -404831436;
											continue;
										case 9u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(137, 556296891u);
											num5 = ((int)num4 * -1982574079) ^ 0x129EBE04;
											continue;
										case 20u:
											num5 = ((int)num4 * -2082702507) ^ -1030839536;
											continue;
										case 6u:
										{
											CancellationTokenSource cancellationTokenSource = _oE;
											CancellationToken lC;
											if (cancellationTokenSource == null)
											{
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 2068259417u);
												lC = _rm;
											}
											else
											{
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 2068259417u);
												lC = _200B_200F_202C_202A_202E_206E_206D_200E_206E_206D_200F_200C_206D_202E_206C_200D_206C_206A_206C_200D_200C_200B_206C_200B_200C_206C_206A_206C_200D_202D_206E_206B_206E_200B_202A_202C_206C_202C_200B_202B_202E((object)cancellationTokenSource);
											}
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 515788994u);
											_LC = lC;
											num5 = -425340862;
											continue;
										}
										case 3u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3053169097u);
											num = (_hm = global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1569262601 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 314393220u)));
											num5 = (int)((num4 * 1084295705) ^ 0x3CD22C95);
											continue;
										case 2u:
										{
											int num8;
											int num9;
											if (num != 0)
											{
												num8 = -764938499;
												num9 = num8;
											}
											else
											{
												num8 = -502192694;
												num9 = num8;
											}
											num5 = num8 ^ ((int)num4 * -665408003);
											continue;
										}
										case 0u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(139, 1803291456u);
											num5 = ((int)num4 * -1922149317) ^ -261608483;
											continue;
										case 11u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 4240925705u);
											num5 = (int)((num4 * 2091715988) ^ 0xB29D7BE);
											continue;
										case 13u:
											_Bn = awaiter;
											num5 = ((int)num4 * -157623477) ^ 0x4E89A69D;
											continue;
										case 4u:
										{
											CancellationTokenSource cancellationTokenSource2 = _oE;
											if (cancellationTokenSource2 == null)
											{
												obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 4240925705u);
												goto case 19u;
											}
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 4240925705u);
											_200C_200C_202D_200F_202C_200E_206C_200B_206C_200E_202A_202E_200F_200D_200B_202C_202B_200E_206B_200B_202A_206E_202C_202A_200D_200D_200F_200F_200D_202A_202A_206B_200F_206B_202A_200F_202B_206A_202B_200E_202E((object)cancellationTokenSource2, _3i.Value);
											num5 = -1781894405;
											continue;
										}
										case 25u:
											awaiter = configuredTaskAwaitable.GetAwaiter();
											num5 = (int)((num4 * 2006820303) ^ 0xC6069E4);
											continue;
										case 24u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(132, 1267241792u);
											num5 = -741660791;
											continue;
										case 8u:
											_PL.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num5 = ((int)num4 * -1164258769) ^ -1928715412;
											continue;
										case 27u:
										{
											int num12;
											int num13;
											if (awaiter.IsCompleted)
											{
												num12 = -89028740;
												num13 = num12;
											}
											else
											{
												num12 = -417036745;
												num13 = num12;
											}
											num5 = num12 ^ ((int)num4 * -755022442);
											continue;
										}
										case 14u:
											_Bn = default(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter);
											num5 = ((int)num4 * -619415964) ^ -638372049;
											continue;
										case 22u:
											awaiter = _Bn;
											num5 = -1104996076;
											continue;
										case 5u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 4227979529u);
											num = (_hm = global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-692005827 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 0u)));
											num5 = (int)((num4 * 972386011) ^ 0x7C2C046);
											continue;
										case 26u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3096910150u);
											num5 = 2121975646;
											continue;
										case 17u:
										{
											int num10;
											int num11;
											if (_3i.HasValue)
											{
												num10 = -161490757;
												num11 = num10;
											}
											else
											{
												num10 = -1974873137;
												num11 = num10;
											}
											num5 = num10 ^ ((int)num4 * -971482892);
											continue;
										}
										case 12u:
										{
											int num6;
											int num7;
											if (_206B_200D_202B_206A_202D_202D_206F_202A_200C_206B_206C_206F_206E_200C_206B_206A_206C_206A_200D_206B_206C_206D_200C_206E_200C_200B_206F_206F_200E_202D_206C_202A_202B_206B_202E_202A_206A_202C_202C_202A_202E())
											{
												num6 = 998012774;
												num7 = num6;
											}
											else
											{
												num6 = 524561271;
												num7 = num6;
											}
											num5 = num6 ^ ((int)num4 * -1236796770);
											continue;
										}
										case 1u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(130, 3818456698u);
											num5 = (int)((num4 * 923972851) ^ 0x18F9853D);
											continue;
										case 15u:
											configuredTaskAwaitable = _206B_206C_200B_200F_206B_206A_206E_202C_200C_202C_206A_202E_200D_200F_202B_202E_202A_206A_206A_202B_200C_202A_202E_202E_202A_206F_202E_206E_202B_202D_202B_200F_202C_202A_200E_202C_202C_202C_202B_206E_202E(_202D_206C_200B_202C_202A_200F_200E_202A_206C_202C_200C_200E_206B_202A_200E_202E_200E_206C_206A_206C_200E_206F_202B_200B_206A_202A_202B_200C_200D_200D_202E_206A_200B_206E_206A_200C_200D_202C_206D_200C_202E(_fH, _LC), (byte)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1219030743 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2020808764u)) != 0);
											num5 = -1014323775;
											continue;
										case 7u:
											goto end_IL_0212;
										case 18u:
											goto end_IL_0027;
										}
										goto IL_020d;
										continue;
										end_IL_0212:
										break;
									}
									break;
								}
							}
							finally
							{
								obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3019213610u);
								while (true)
								{
									IL_072b:
									int num14 = -424337213;
									while (true)
									{
										num3 = num14;
										switch ((num4 = (uint)(-((num3 + (--729813401 + ~(0x7A74CE2A ^ -372170856) + ~(780002388 * -1292250743) * 1917626477)) ^ (-(-(2021999447 * (1255957304 - 605249731)) ^ 0x6C860BAA) ^ 0x676C8209)) - (-(~(~-1638776303)) ^ -1420580384) + (-743526571 ^ 0x269087F3))) % 9)
										{
										case 6u:
											break;
										default:
											goto end_IL_0730;
										case 5u:
										{
											int num17;
											int num18;
											if (num >= global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1782995593 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3562627410u)))
											{
												num17 = -1751246423;
												num18 = num17;
											}
											else
											{
												num17 = -736085126;
												num18 = num17;
											}
											num14 = num17 ^ (int)(num4 * 2107556507);
											continue;
										}
										case 8u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(130, 1743505231u);
											num14 = ((int)num4 * -800624601) ^ 0x26EF4356;
											continue;
										case 0u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(135, 1803291456u);
											num14 = (int)((num4 * 1054639953) ^ 0x4F8E4D3B);
											continue;
										case 3u:
											_206D_202A_202C_206B_200D_206C_200B_206D_206A_202E_200D_206D_200B_206E_202D_200C_206F_200E_206E_206C_206C_202B_206D_206B_200E_206E_202B_202B_206E_200E_200B_200C_202D_206C_206F_206A_206E_200F_202B_202E_202E((object)_oE);
											num14 = (int)(num4 * 603874265) ^ -121997108;
											continue;
										case 7u:
										{
											int num15;
											int num16;
											if (_oE == null)
											{
												num15 = -2122283450;
												num16 = num15;
											}
											else
											{
												num15 = -731084760;
												num16 = num15;
											}
											num14 = num15 ^ ((int)num4 * -1907026546);
											continue;
										}
										case 1u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(132, 1267241792u);
											num14 = -1136057234;
											continue;
										case 4u:
											obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(137, 3653207041u);
											num14 = ((int)num4 * -1646746064) ^ -939560268;
											continue;
										case 2u:
											goto end_IL_0730;
										}
										goto IL_072b;
										continue;
										end_IL_0730:
										break;
									}
									break;
								}
							}
							goto end_IL_0013;
						}
						goto IL_0022;
						continue;
						end_IL_0027:
						break;
					}
					break;
				}
				goto IL_0beb;
				end_IL_0013:;
			}
			catch (Exception ex)
			{
				obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(4165529945u);
				Exception exception = ex;
				while (true)
				{
					IL_0934:
					int num21 = -214017496;
					while (true)
					{
						int num3 = num21;
						uint num4;
						switch ((num4 = (uint)(-((num3 + (--729813401 + ~(0x7A74CE2A ^ -372170856) + ~(780002388 * -1292250743) * 1917626477)) ^ (-(-(2021999447 * (1255957304 - 605249731)) ^ 0x6C860BAA) ^ 0x676C8209)) - (-(~(~-1638776303)) ^ -1420580384) + (-743526571 ^ 0x269087F3))) % 6)
						{
						case 5u:
							break;
						case 2u:
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3714324726u);
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 425247336u);
							obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 4087289497u);
							_hm = global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x3D4CE12 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 4051162169u)));
							num21 = ((int)num4 * -1550484801) ^ 0x659D3C49;
							continue;
						case 0u:
							_LC = default(CancellationToken);
							num21 = ((int)num4 * -1285391798) ^ -583271061;
							continue;
						case 3u:
							_PL.SetException(exception);
							num21 = (int)(num4 * 1528624320) ^ -502646808;
							continue;
						case 1u:
							_oE = null;
							num21 = (int)(num4 * 1933836673) ^ -671052463;
							continue;
						default:
							goto end_IL_0939;
						}
						goto IL_0934;
						continue;
						end_IL_0939:
						break;
					}
					break;
				}
				goto IL_0beb;
			}
			_hm = global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1677521722 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 0u));
			goto IL_0afb;
			IL_0afb:
			int num22 = -930349649;
			goto IL_0b00;
			IL_0beb:
			obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3331498067u);
			num22 = -1677026312;
			goto IL_0b00;
			IL_0b00:
			while (true)
			{
				int num3 = num22;
				uint num4;
				switch ((num4 = (uint)(-((num3 + (--729813401 + ~(0x7A74CE2A ^ -372170856) + ~(780002388 * -1292250743) * 1917626477)) ^ (-(-(2021999447 * (1255957304 - 605249731)) ^ 0x6C860BAA) ^ 0x676C8209)) - (-(~(~-1638776303)) ^ -1420580384) + (-743526571 ^ 0x269087F3))) % 6)
				{
				case 2u:
					break;
				default:
					return;
				case 5u:
					goto IL_0beb;
				case 3u:
					_PL.SetResult();
					num22 = ((int)num4 * -978905147) ^ 0xC1BEAF8;
					continue;
				case 4u:
					_LC = default(CancellationToken);
					num22 = ((int)num4 * -929306319) ^ 0x4C159E69;
					continue;
				case 1u:
					_oE = null;
					num22 = (int)(num4 * 652250209) ^ -1959708535;
					continue;
				case 0u:
					return;
				}
				break;
			}
			goto IL_0afb;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_PL.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _206D_206C_200F_206A_200F_202A_206A_202B_202A_206A_206F_202E_200D_206B_206D_206C_200E_202A_202B_202A_206C_200C_200C_202D_200B_202B_200F_206B_206D_202B_206A_206D_206A_202D_206A_200D_206E_206C_206E_202D_202E(CancellationToken[] P_0)
		{
			return CancellationTokenSource.CreateLinkedTokenSource(P_0);
		}

		static void _200C_200C_202D_200F_202C_200E_206C_200B_206C_200E_202A_202E_200F_200D_200B_202C_202B_200E_206B_200B_202A_206E_202C_202A_200D_200D_200F_200F_200D_202A_202A_206B_200F_206B_202A_200F_202B_206A_202B_200E_202E(object P_0, TimeSpan P_1)
		{
			((CancellationTokenSource)P_0).CancelAfter(P_1);
		}

		static CancellationToken _200B_200F_202C_202A_202E_206E_206D_200E_206E_206D_200F_200C_206D_202E_206C_200D_206C_206A_206C_200D_200C_200B_206C_200B_200C_206C_206A_206C_200D_202D_206E_206B_206E_200B_202A_202C_206C_202C_200B_202B_202E(object P_0)
		{
			return ((CancellationTokenSource)P_0).Token;
		}

		static object _202D_206C_200B_202C_202A_200F_200E_202A_206C_202C_200C_200E_206B_202A_200E_202E_200E_206C_206A_206C_200E_206F_202B_200B_206A_202A_202B_200C_200D_200D_202E_206A_200B_206E_206A_200C_200D_202C_206D_200C_202E(int P_0, CancellationToken P_1)
		{
			return Task.Delay(P_0, P_1);
		}

		static ConfiguredTaskAwaitable _206B_206C_200B_200F_206B_206A_206E_202C_200C_202C_206A_202E_200D_200F_202B_202E_202A_206A_206A_202B_200C_202A_202E_202E_202A_206F_202E_206E_202B_202D_202B_200F_202C_202A_200E_202C_202C_202C_202B_206E_202E(object P_0, bool P_1)
		{
			return ((Task)P_0).ConfigureAwait(P_1);
		}

		static bool _206B_200D_202B_206A_202D_202D_206F_202A_200C_206B_206C_206F_206E_200C_206B_206A_206C_206A_200D_206B_206C_206D_200C_206E_200C_200B_206F_206F_200E_202D_206C_202A_202B_206B_202E_202A_206A_202C_202C_202A_202E()
		{
			return Level.isLoaded;
		}

		static void _206D_202A_202C_206B_200D_206C_200B_206D_206A_202E_200D_206D_200B_206E_202D_200C_206F_200E_206E_206C_206C_202B_206D_206B_200E_206E_202B_202B_206E_200E_200B_200C_202D_206C_206F_206A_206E_200F_202B_202E_202E(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_Me))]
	internal static T0 _DH<T0, T1, T2, T3>(T1 P_0 = default(T1), T2 P_1 = 100, T3 P_2 = default(T3)) where T0 : notnull where T1 : notnull where T2 : notnull where T3 : notnull
	{
		//IL_00c7: Expected I4, but got O
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2277362544u);
		_Me stateMachine = default(_Me);
		while (true)
		{
			int num = 511306599;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(((((num2 + ~(((~(~(-1760026599)) + ~(-(1342001815 * -904234339))) * 2071202923) ^ -2017740714)) * 1686927001 - 337125973) * -1300355065) ^ (-(~-382153095) - (-378669898 - 1903778605 + (1963643494 - 73733951)))) * -2112324205) ^ -479783847)) % 8)
				{
				case 7u:
					break;
				case 3u:
					stateMachine._3i = (TimeSpan?)P_2;
					num = (int)((num3 * 1782245343) ^ 0x6DB4E22E);
					continue;
				case 0u:
					stateMachine._fH = (int)P_1;
					num = (int)(num3 * 631579184) ^ -480499987;
					continue;
				case 1u:
					stateMachine._hm = global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1204202219 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 577211081u));
					num = ((int)num3 * -1992179232) ^ 0x5320BB04;
					continue;
				case 5u:
					stateMachine._PL = AsyncTaskMethodBuilder.Create();
					num = ((int)num3 * -682588047) ^ 0xDF73125;
					continue;
				case 6u:
					stateMachine._PL.Start(ref stateMachine);
					num = (int)((num3 * 1426565496) ^ 0x18546DF2);
					continue;
				case 2u:
					stateMachine._rm = (CancellationToken)P_0;
					num = ((int)num3 * -1996093314) ^ 0x784C4C3A;
					continue;
				default:
					return (T0)stateMachine._PL.Task;
				}
				break;
			}
		}
	}
}
internal static class _NF
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
	private struct __anontype_1639d593_0026
	{
		[FieldOffset(0)]
		public uint dwOemID;

		[FieldOffset(0)]
		public __anontype_1639d593_0027 s;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 4)]
	private struct __anontype_1639d593_0027
	{
		public ushort wProcessorArchitecture;

		public ushort wReserved;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
	private struct __anontype_1639d593_0036
	{
		[FieldOffset(0)]
		public uint PhysicalAddress;

		[FieldOffset(0)]
		public uint VirtualSize;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private class MEMORYMODULE
	{
		public unsafe _IMAGE_NT_HEADERS* headers;

		public unsafe byte* codeBase;

		public unsafe void** modules;

		public int numModules;

		[MarshalAs(UnmanagedType.Bool)]
		public bool initialized;

		[MarshalAs(UnmanagedType.Bool)]
		public bool isDLL;

		[MarshalAs(UnmanagedType.Bool)]
		public bool isRelocated;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomAllocFunc alloc;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomFreeFunc free;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomLoadLibraryFunc loadLibrary;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomGetProcAddressFunc getProcAddress;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public CustomFreeLibraryFunc freeLibrary;

		public IntPtr nameExportsTable;

		public unsafe void* userdata;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		public ExeEntryProc exeEntry;

		public uint pageSize;

		public unsafe POINTER_LIST* blockedMemory;

		public unsafe static MEMORYMODULE MarshalFrom(_MEMORYMODULE* ptr)
		{
			MEMORYMODULE mEMORYMODULE = new MEMORYMODULE();
			Marshal.PtrToStructure((IntPtr)ptr, mEMORYMODULE);
			return mEMORYMODULE;
		}

		public unsafe void MarshalTo(_MEMORYMODULE* ptr)
		{
			Marshal.StructureToPtr(this, (IntPtr)ptr, fDeleteOld: true);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private struct _MEMORYMODULE
	{
		public unsafe _IMAGE_NT_HEADERS* headers;

		public unsafe byte* codeBase;

		public unsafe void** modules;

		public int numModules;

		public int initialized;

		public int isDLL;

		public int isRelocated;

		public unsafe void* alloc;

		public unsafe void* free;

		public unsafe void* loadLibrary;

		public unsafe void* getProcAddress;

		public unsafe void* freeLibrary;

		public IntPtr nameExportsTable;

		public unsafe void* userdata;

		public unsafe void* exeEntry;

		public uint pageSize;

		public unsafe POINTER_LIST* blockedMemory;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 8)]
	public struct POINTER_LIST
	{
		public unsafe POINTER_LIST* next;

		public unsafe void* address;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 20)]
	private struct SECTIONFINALIZEDATA
	{
		public unsafe void* address;

		public unsafe void* alignedAddress;

		public uint size;

		public uint characteristics;

		public bool last;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	private struct __anontype_b18cdc1e_0003
	{
		[FieldOffset(0)]
		public __anontype_b18cdc1e_0004 DUMMYSTRUCTNAME;

		[FieldOffset(0)]
		public uint Name;

		[FieldOffset(0)]
		public ushort Id;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 4)]
	private struct __anontype_b18cdc1e_0004
	{
		public uint bits0;
	}

	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 4)]
	private struct __anontype_b18cdc1e_0005
	{
		[FieldOffset(0)]
		public uint OffsetToData;

		[FieldOffset(0)]
		public __anontype_b18cdc1e_0006 DUMMYSTRUCTNAME2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 4)]
	private struct __anontype_b18cdc1e_0006
	{
		public uint bits0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 8)]
	private struct _IMAGE_BASE_RELOCATION
	{
		public uint VirtualAddress;

		public uint SizeOfBlock;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 8)]
	private struct _IMAGE_DATA_DIRECTORY
	{
		public uint VirtualAddress;

		public uint Size;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 128)]
	private struct _IMAGE_DATA_DIRECTORY_array_128
	{
		public unsafe _IMAGE_DATA_DIRECTORY this[int offset]
		{
			get
			{
				fixed (_IMAGE_DATA_DIRECTORY_array_128* ptr = &this)
				{
					void* ptr2 = ptr;
					_IMAGE_DATA_DIRECTORY* ptr3 = (_IMAGE_DATA_DIRECTORY*)ptr2;
					return ptr3[offset];
				}
			}
			set
			{
				fixed (_IMAGE_DATA_DIRECTORY_array_128* ptr = &this)
				{
					void* ptr2 = ptr;
					_IMAGE_DATA_DIRECTORY* ptr3 = (_IMAGE_DATA_DIRECTORY*)ptr2;
					ptr3[offset] = value;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
	private struct _IMAGE_EXPORT_DIRECTORY
	{
		public uint Characteristics;

		public uint TimeDateStamp;

		public ushort MajorVersion;

		public ushort MinorVersion;

		public uint Name;

		public uint Base;

		public uint NumberOfFunctions;

		public uint NumberOfNames;

		public uint AddressOfFunctions;

		public uint AddressOfNames;

		public uint AddressOfNameOrdinals;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 20)]
	private struct _IMAGE_FILE_HEADER
	{
		public ushort Machine;

		public ushort NumberOfSections;

		public uint TimeDateStamp;

		public uint PointerToSymbolTable;

		public uint NumberOfSymbols;

		public ushort SizeOfOptionalHeader;

		public ushort Characteristics;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2, Size = 4)]
	private struct _IMAGE_IMPORT_BY_NAME
	{
		public ushort Hint;

		public unsafe fixed byte Name[1];
	}

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20)]
	private struct _IMAGE_IMPORT_DESCRIPTOR
	{
		[FieldOffset(0)]
		public uint Characteristics;

		[FieldOffset(0)]
		public uint OriginalFirstThunk;

		[FieldOffset(4)]
		public uint TimeDateStamp;

		[FieldOffset(8)]
		public uint ForwarderChain;

		[FieldOffset(12)]
		public uint Name;

		[FieldOffset(16)]
		public uint FirstThunk;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 248)]
	private struct _IMAGE_NT_HEADERS
	{
		public uint Signature;

		public _IMAGE_FILE_HEADER FileHeader;

		public _IMAGE_OPTIONAL_HEADER OptionalHeader;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct _IMAGE_OPTIONAL_HEADER
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 4)]
		private struct DUMMY8BYTEVALUE
		{
			[FieldOffset(0)]
			public uint BaseOfData;

			[FieldOffset(4)]
			public uint ImageBase32;

			[FieldOffset(0)]
			public ulong ImageBase64;
		}

		private const int IMAGE_NUMBEROF_DIRECTORY_ENTRIES = 16;

		public ushort Magic;

		public byte MajorLinkerVersion;

		public byte MinorLinkerVersion;

		public uint SizeOfCode;

		public uint SizeOfInitializedData;

		public uint SizeOfUninitializedData;

		public uint AddressOfEntryPoint;

		public uint BaseOfCode;

		private DUMMY8BYTEVALUE _architectureSpecificValue1;

		public uint SectionAlignment;

		public uint FileAlignment;

		public ushort MajorOperatingSystemVersion;

		public ushort MinorOperatingSystemVersion;

		public ushort MajorImageVersion;

		public ushort MinorImageVersion;

		public ushort MajorSubsystemVersion;

		public ushort MinorSubsystemVersion;

		public uint Win32VersionValue;

		public uint SizeOfImage;

		public uint SizeOfHeaders;

		public uint CheckSum;

		public ushort Subsystem;

		public ushort DllCharacteristics;

		public UIntPtr SizeOfStackReserve;

		public UIntPtr SizeOfStackCommit;

		public UIntPtr SizeOfHeapReserve;

		public UIntPtr SizeOfHeapCommit;

		public uint LoaderFlags;

		public uint NumberOfRvaAndSizes;

		public _IMAGE_DATA_DIRECTORY_array_128 DataDirectory;

		public uint BaseOfData
		{
			get
			{
				return _architectureSpecificValue1.BaseOfData;
			}
			set
			{
				_architectureSpecificValue1.BaseOfData = value;
			}
		}

		public UIntPtr ImageBase
		{
			get
			{
				if (!Environment.Is64BitProcess)
				{
					return (UIntPtr)_architectureSpecificValue1.ImageBase32;
				}
				return (UIntPtr)_architectureSpecificValue1.ImageBase64;
			}
			set
			{
				if (Environment.Is64BitProcess)
				{
					_architectureSpecificValue1.ImageBase64 = (ulong)value;
				}
				else
				{
					_architectureSpecificValue1.ImageBase32 = (uint)value;
				}
			}
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 16)]
	private struct _IMAGE_RESOURCE_DATA_ENTRY
	{
		public uint OffsetToData;

		public uint Size;

		public uint CodePage;

		public uint Reserved;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2, Size = 4)]
	private struct _IMAGE_RESOURCE_DIR_STRING_U
	{
		public ushort Length;

		public unsafe fixed char NameString[1];
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 16)]
	private struct _IMAGE_RESOURCE_DIRECTORY
	{
		public uint Characteristics;

		public uint TimeDateStamp;

		public ushort MajorVersion;

		public ushort MinorVersion;

		public ushort NumberOfNamedEntries;

		public ushort NumberOfIdEntries;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 8)]
	private struct _IMAGE_RESOURCE_DIRECTORY_ENTRY
	{
		public __anontype_b18cdc1e_0003 DUMMYUNIONNAME;

		public __anontype_b18cdc1e_0005 DUMMYUNIONNAME2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 40)]
	private struct _IMAGE_SECTION_HEADER
	{
		public unsafe fixed byte Name[8];

		public __anontype_1639d593_0036 Misc;

		public uint VirtualAddress;

		public uint SizeOfRawData;

		public uint PointerToRawData;

		public uint PointerToRelocations;

		public uint PointerToLinenumbers;

		public ushort NumberOfRelocations;

		public ushort NumberOfLinenumbers;

		public uint Characteristics;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private struct _IMAGE_TLS_DIRECTORY
	{
		public UIntPtr StartAddressOfRawData;

		public UIntPtr EndAddressOfRawData;

		public UIntPtr AddressOfIndex;

		public UIntPtr AddressOfCallBacks;

		public uint SizeOfZeroFill;

		public uint Characteristics;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct _SYSTEM_INFO
	{
		public __anontype_1639d593_0026 u;

		public uint dwPageSize;

		public unsafe void* lpMinimumApplicationAddress;

		public unsafe void* lpMaximumApplicationAddress;

		public UIntPtr dwActiveProcessorMask;

		public uint dwNumberOfProcessors;

		public uint dwProcessorType;

		public uint dwAllocationGranularity;

		public ushort wProcessorLevel;

		public ushort wProcessorRevision;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1, Size = 64)]
	private struct IMAGE_DOS_HEADER
	{
		public ushort e_magic;

		public ushort e_cblp;

		public ushort e_cp;

		public ushort e_crlc;

		public ushort e_cparhdr;

		public ushort e_minalloc;

		public ushort e_maxalloc;

		public ushort e_ss;

		public ushort e_sp;

		public ushort e_csum;

		public ushort e_ip;

		public ushort e_cs;

		public ushort e_lfarlc;

		public ushort e_ovno;

		public unsafe fixed ushort e_res[4];

		public ushort e_oemid;

		public ushort e_oeminfo;

		public unsafe fixed ushort e_res2[10];

		public int e_lfanew;
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr FARPROC();

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private unsafe delegate void PIMAGE_TLS_CALLBACK(void* DllHandle, uint Reason, void* Reserved);

	[UnmanagedFunctionPointer(CallingConvention.Winapi)]
	private unsafe delegate bool DllEntryProc(void* hinstDLL, Dll fdwReason, void* lpReserved);

	[UnmanagedFunctionPointer(CallingConvention.Winapi)]
	private delegate int ExeEntryProc();

	public static CustomAllocFunc _GI;

	public static CustomFreeFunc _KK;

	public static CustomLoadLibraryFunc _CC;

	public static CustomGetProcAddressFunc _nI;

	public static CustomFreeLibraryFunc _ve;

	private static readonly uint _mA;

	private static readonly PageProtection[][][] _4N;

	private const uint _bO = uint.MaxValue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static T0 _BA<T0, T1, T2>(T1* P_0, T2 P_1, CustomAllocFunc P_2 = null, CustomFreeFunc P_3 = null, CustomLoadLibraryFunc P_4 = null, CustomGetProcAddressFunc P_5 = null, CustomFreeLibraryFunc P_6 = null)
	{
		//IL_01d0: Expected I8, but got O
		//IL_0215: Expected O, but got I
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1962029034u);
		while (true)
		{
			int num = -1891428305;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((-782486832 ^ (-864295177 ^ 0x3B219195 ^ (--1226448176 - (-433398948 ^ -251199842)))) + (372317809 * -2117157665 + (--1721610327 + -2022703048)) * 1129230103 - (num2 ^ (1578562162 + (1007745266 - (~(~1679510266) + (0x3469C2F ^ (-355223528 + ~1848811543)))) + (~(-126863279 - -1038214280) * -232686175 + ~(~(1921613213 * -(196604469 * -2016303441)))))) * -2120543999) ^ 0x6AA040BE)) % 7)
				{
				case 3u:
					break;
				case 1u:
				{
					CustomAllocFunc obj5 = P_2 ?? _GI;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1860485857u);
					P_2 = obj5;
					num = 213627262;
					continue;
				}
				case 0u:
				{
					CustomFreeFunc obj3 = P_3 ?? _KK;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1925340958u);
					P_3 = obj3;
					num = -947244437;
					continue;
				}
				case 6u:
				{
					CustomGetProcAddressFunc obj4 = P_5 ?? _nI;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1717915221u);
					P_5 = obj4;
					num = -117729727;
					continue;
				}
				case 2u:
				{
					CustomLoadLibraryFunc obj2 = P_4 ?? _CC;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 619300564u);
					P_4 = obj2;
					num = -912374479;
					continue;
				}
				case 5u:
					P_6 = P_6 ?? _ve;
					num = -979734204;
					continue;
				default:
				{
					void* intPtr = _Jm<T1, int, uint, ulong, UIntPtr, T0>(P_0, (ulong)(long)P_1, P_2, P_3, P_4, P_5, P_6, (void*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1768802507 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2905795222u)));
					if (intPtr == (void*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1269905944 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1233919231u)))
					{
						obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3634514021u);
						throw _202A_206E_202B_202E_200E_206A_206E_206E_206D_206F_206B_200F_206E_200E_202B_202D_206A_200C_206B_202D_206C_200C_202C_202E_206F_202A_202B_200E_202E_202A_206B_202D_202D_202A_202A_200D_206A_200B_202A_202E_202E((int)_hf());
					}
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2358382913u);
					return (T0)(nint)new IntPtr(intPtr);
				}
				}
				break;
			}
		}
	}

	public unsafe static bool _bm(IntPtr P_0)
	{
		return _Gj<GCHandle, int, bool>((_MEMORYMODULE*)(void*)P_0);
	}

	public unsafe static T1 _5A<T0, T1, T2>(T0 P_0, T2 P_1)
	{
		//IL_0007: Expected O, but got I
		//IL_000d: Expected I, but got O
		//IL_0013: Expected I, but got O
		T0 val = (T0)(nint)_200F_200B_206F_202C_200B_206B_200D_200B_202D_202E_206B_202A_206C_206C_206D_206F_206E_202C_202C_206A_206D_206E_200B_206F_206E_206E_206C_206B_200D_200C_206B_206A_202D_206F_206A_206C_206C_202B_206C_206B_202E((string)P_1);
		IntPtr intPtr = (IntPtr)_HI<byte, uint, Dictionary<string, uint>, ushort, T0, GCHandle, char>((_MEMORYMODULE*)(void*)(IntPtr)P_0, (char*)(void*)(IntPtr)val);
		if (intPtr == IntPtr.Zero)
		{
			throw _202A_206E_202B_202E_200E_206A_206E_206E_206D_206F_206B_200F_206E_200E_202B_202D_206A_200C_206B_202D_206C_200C_202C_202E_206F_202A_202B_200E_202E_202A_206B_202D_202D_202A_202A_200D_206A_200B_202A_202E_202E((int)_hf());
		}
		return (T1)(T0)_206B_206B_206A_200F_202D_206A_200F_200F_206E_206A_200D_206D_206B_206C_200C_206D_202E_206C_202C_200D_206C_206C_202E_200E_202B_206B_202B_206B_202A_202C_206B_200B_206E_200E_206F_202B_206E_200D_200E_206D_202E(intPtr, (Type)_206A_202B_200F_202A_206C_202E_206F_206D_206E_206E_206E_206E_200C_200B_202E_200B_206F_206B_200D_202E_206A_202C_202D_202D_200E_200F_206A_200E_206B_206F_202D_206F_206B_206A_202D_206D_200E_200C_206D_202E_202E(typeof(T0).TypeHandle));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static T1 _0B<T0, T1, T2>(T1 P_0, T2 P_1)
	{
		//IL_00fb: Expected I, but got O
		//IL_0107: Expected O, but got I
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2089133979u);
		T0* ptr = (T0*)(uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-221753889 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 4192676136u));
		T1 result = default(T1);
		try
		{
			obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3130257908u);
			while (true)
			{
				IL_0032:
				int num = -1254476556;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~(~(num2 - (-300141175 ^ (723524797 + -(711738712 - ~-1311906073 * 1106967519 - (-929013231 * -529985256 - 541735538)))) - -(-(-(-(549255937 * 405036053 + ~-1763519407))))) - (-(1018435741 * -616147429 + -588207319 * -1665474027) - (697854961 * -339998561 - (--1362356344 + --1300402247)))))) % 4)
					{
					case 0u:
						break;
					default:
						goto end_IL_0037;
					case 3u:
						ptr = (T0*)(void*)_200F_200B_206F_202C_200B_206B_200D_200B_202D_202E_206B_202A_206C_206C_206D_206F_206E_202C_202C_206A_206D_206E_200B_206F_206E_206E_206C_206B_200D_200C_206B_206A_202D_206F_206A_206C_206C_202B_206C_206B_202E((string)P_1);
						num = (int)((num3 * 269841888) ^ 0x77FA7677);
						continue;
					case 2u:
						result = (T1)(nint)(IntPtr)_HI<byte, uint, Dictionary<string, uint>, ushort, T1, GCHandle, T0>((_MEMORYMODULE*)(void*)(IntPtr)P_0, ptr);
						num = (int)((num3 * 1340990041) ^ 0x7416C7EC);
						continue;
					case 1u:
						goto end_IL_0037;
					}
					goto IL_0032;
					continue;
					end_IL_0037:
					break;
				}
				break;
			}
		}
		finally
		{
			obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(128, 706382964u);
			while (true)
			{
				IL_012d:
				int num4 = -1058429698;
				while (true)
				{
					int num2 = num4;
					uint num3;
					switch ((num3 = (uint)(~(~(num2 - (-300141175 ^ (723524797 + -(711738712 - ~-1311906073 * 1106967519 - (-929013231 * -529985256 - 541735538)))) - -(-(-(-(549255937 * 405036053 + ~-1763519407))))) - (-(1018435741 * -616147429 + -588207319 * -1665474027) - (697854961 * -339998561 - (--1362356344 + --1300402247)))))) % 6)
					{
					case 5u:
						break;
					default:
						goto end_IL_0132;
					case 4u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(139, 3787930612u);
						num4 = (int)((num3 * 1796562051) ^ 0x411B9CBD);
						continue;
					case 2u:
						_206D_200B_202C_206A_206B_200C_206F_202C_206F_202B_200D_200B_202A_206F_200D_202B_202E_206C_202A_200E_206D_200F_202A_200F_206F_206A_202D_200B_202B_202D_206C_206B_206B_202B_202B_206A_206A_206E_206D_202C_202E((IntPtr)ptr);
						num4 = (int)((num3 * 523779943) ^ 0x730436F7);
						continue;
					case 3u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(133, 2886989556u);
						num4 = ((int)num3 * -665850201) ^ -110300865;
						continue;
					case 1u:
						obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(138, 290074996u);
						num4 = (int)(num3 * 906489093) ^ -389957590;
						continue;
					case 0u:
						goto end_IL_0132;
					}
					goto IL_012d;
					continue;
					end_IL_0132:
					break;
				}
				break;
			}
		}
		obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3697430938u);
		return result;
	}

	public unsafe static void* _qm<T0>(void* P_0, T0* P_1)
	{
		return _HI<byte, uint, Dictionary<string, uint>, ushort, IntPtr, GCHandle, T0>((_MEMORYMODULE*)P_0, P_1);
	}

	internal unsafe static void* _De<T0>(void* P_0, T0 P_1, MemoryAllocation P_2, PageProtection P_3, void* P_4)
	{
		//IL_0009: Expected I, but got O
		return _8m(P_0, (nuint)(nint)P_1, P_2, P_3);
	}

	internal unsafe static T0 _cI<T0, T1>(void* P_0, T1 P_1, MemoryAllocation P_2, void* P_3)
	{
		//IL_0008: Expected I, but got O
		//IL_0009: Expected O, but got I4
		return (T0)_jh(P_0, (nuint)(nint)P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal unsafe static void* _AF<T0>(T0* P_0, void* P_1)
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3201990298u);
		void* ptr = default(void*);
		while (true)
		{
			int num = -1263661514;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((num2 ^ (266705960 + -(~((-1851815026 ^ -127608341) * 617112303)) - -(~(-(428347515 - 796500809)) ^ (-810353148 + --2101970422 + (0x7EAB0C8A ^ -1429969034)) ^ (~-1150458105 - (-1302039085 - -2060776415 + --1657701558) + (1623197757 - (1076745884 - 1803760368 + (0x7F23593D ^ 0x91BDEE4))))))) - -(-1812064493 ^ -733919668)) ^ -(214561403 * 56948706))) % 6)
				{
				case 5u:
					break;
				case 2u:
					ptr = _Dc((char*)P_0);
					num = (int)(num3 * 352279347) ^ -1586761324;
					continue;
				case 3u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3697622084u);
					num = -1871617692;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (ptr == (void*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-460688747 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 378061796u)))
					{
						num4 = 1857978149;
						num5 = num4;
					}
					else
					{
						num4 = -2103616511;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 962765755);
					continue;
				}
				case 1u:
					return (void*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1565061078 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1178428095u));
				default:
					return ptr;
				}
				break;
			}
		}
	}

	internal unsafe static void* _Hg<T0>(void* P_0, T0* P_1, void* P_2)
	{
		return _zj(P_0, (char*)P_1);
	}

	internal unsafe static T0 _mJ<T0>(void* P_0, void* P_1)
	{
		//IL_0007: Expected O, but got I4
		return (T0)_QA(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _Fi<T0>(void* P_0, T0 P_1)
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3760315067u);
		return _Jm<byte, int, uint, T0, UIntPtr, IntPtr>(P_0, P_1, _GI, _KK, _CC, _nI, _ve, (void*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-2010845807 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3189802565u)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _Jm<T0, T1, T2, T3, T4, T5>(void* P_0, T3 P_1, CustomAllocFunc P_2, CustomFreeFunc P_3, CustomLoadLibraryFunc P_4, CustomGetProcAddressFunc P_5, CustomFreeLibraryFunc P_6, void* P_7)
	{
		//IL_01a9: Expected O, but got I4
		//IL_027b: Expected O, but got I4
		//IL_00f4: Expected O, but got I8
		//IL_02aa: Expected O, but got I8
		//IL_0220: Expected O, but got I8
		//IL_19fc: Expected O, but got I8
		//IL_1392: Expected O, but got I8
		//IL_068b: Expected O, but got I8
		//IL_10d8: Expected O, but got I8
		//IL_0bdb: Expected O, but got I8
		//IL_0bdb: Expected O, but got I8
		//IL_0fe5: Expected O, but got I8
		//IL_0ec2: Expected I8, but got O
		//IL_097c: Expected O, but got I4
		//IL_119b: Expected O, but got I
		//IL_11a6: Expected O, but got I4
		//IL_1693: Expected O, but got I8
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Expected O, but got Unknown
		//IL_1425: Expected O, but got I
		//IL_13f1: Expected O, but got I8
		//IL_1045: Unknown result type (might be due to invalid IL or missing references)
		//IL_1048: Expected O, but got Unknown
		//IL_1872: Expected O, but got I
		//IL_16f2: Expected I8, but got O
		//IL_155e: Expected I8, but got O
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3012409560u);
		T3 val5 = default(T3);
		IMAGE_DOS_HEADER* ptr7 = default(IMAGE_DOS_HEADER*);
		_MEMORYMODULE* ptr2 = default(_MEMORYMODULE*);
		_IMAGE_NT_HEADERS* ptr3 = default(_IMAGE_NT_HEADERS*);
		T1 val7 = default(T1);
		T0* ptr5 = default(T0*);
		_SYSTEM_INFO sYSTEM_INFO = default(_SYSTEM_INFO);
		T3 val4 = default(T3);
		T0* ptr6 = default(T0*);
		T2 val2 = default(T2);
		T3 val3 = default(T3);
		POINTER_LIST* ptr4 = default(POINTER_LIST*);
		void* result = default(void*);
		_IMAGE_SECTION_HEADER* ptr8 = default(_IMAGE_SECTION_HEADER*);
		T4 val6 = default(T4);
		while (true)
		{
			int num = -1495571648;
			while (true)
			{
				int num2 = num;
				int num61;
				uint num3;
				switch ((num3 = (uint)(((((-(-num2) ^ 0x6C8E3405) + (~(~-721753593) + -1951361156 - ((-2003647774 ^ -782644717) - 1846876339 * -1836828537 * -871603653)) - (-1671579069 + ~1532591641) * 607593267) ^ 0x1F302744) - (-7999402 ^ -393828097)) * 281976739)) % 12)
				{
				case 0u:
					break;
				case 7u:
					val5 = (T3)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x64F9B7FB ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2404143991u)));
					num = (int)(num3 * 789846387) ^ -1390357712;
					continue;
				case 9u:
					ptr7 = (IMAGE_DOS_HEADER*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x122ECD8E ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3237651609u)));
					num = ((int)num3 * -8509096) ^ -145596117;
					continue;
				case 6u:
					ptr2 = (_MEMORYMODULE*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x5DE06711 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1843126839u)));
					num = (int)(num3 * 1713493507) ^ -1451338891;
					continue;
				case 5u:
					ptr3 = (_IMAGE_NT_HEADERS*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x5DE06711 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1407161284u)));
					num = ((int)num3 * -652895019) ^ 0x7DBB2AD0;
					continue;
				case 1u:
					val7 = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-784452682 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2766279494u));
					num = ((int)num3 * -1590228972) ^ 0x28742E0;
					continue;
				case 3u:
					ptr5 = (T0*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x7A0E6E9D ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 2893892613u)));
					num = (int)((num3 * 88578883) ^ 0x43059303);
					continue;
				case 2u:
					sYSTEM_INFO = default(_SYSTEM_INFO);
					num = (int)((num3 * 637725505) ^ 0x479641BC);
					continue;
				case 11u:
					val4 = (T3)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x667640C2 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1906932219u)));
					num = ((int)num3 * -1152851364) ^ -2136388988;
					continue;
				case 8u:
					ptr6 = (T0*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x2EA357D ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 4013695638u)));
					num = (int)(num3 * 1627564372) ^ -1570859489;
					continue;
				case 4u:
					val2 = (T2)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-499608554 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 355798084u));
					num = (int)(num3 * 92546081) ^ -1113425827;
					continue;
				default:
					{
						T3 val = (T3)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-291261980 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2121625758u));
						try
						{
							POINTER_LIST* ptr = (POINTER_LIST*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x3D9016F0 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3305267941u)));
							while (true)
							{
								IL_02c5:
								int num4 = -1077786347;
								while (true)
								{
									num2 = num4;
									switch ((num3 = (uint)(((((-(-num2) ^ 0x6C8E3405) + (~(~-721753593) + -1951361156 - ((-2003647774 ^ -782644717) - 1846876339 * -1836828537 * -871603653)) - (-1671579069 + ~1532591641) * 607593267) ^ 0x1F302744) - (-7999402 ^ -393828097)) * 281976739)) % 156)
									{
									case 94u:
										break;
									default:
										goto end_IL_02ca;
									case 143u:
										goto end_IL_02ca;
									case 115u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 275552605u);
										num4 = (int)(num3 * 842023495) ^ -332526031;
										continue;
									case 91u:
										obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(4201217885u);
										num4 = 1390492342;
										continue;
									case 93u:
										ptr2->headers->OptionalHeader.ImageBase = (UIntPtr)ptr5;
										num4 = (int)((num3 * 1470414268) ^ 0x52304CE);
										continue;
									case 146u:
										val4 = val3;
										num4 = (int)(num3 * 474189647) ^ -888063750;
										continue;
									case 67u:
										ptr3 = (_IMAGE_NT_HEADERS*)((byte*)P_0 + ptr7->e_lfanew);
										num4 = -1554092489;
										continue;
									case 12u:
									{
										int num52;
										int num53;
										if (_hE<bool, T3>(P_1, (T3)ptr3->OptionalHeader.SizeOfHeaders))
										{
											num52 = 2052826134;
											num53 = num52;
										}
										else
										{
											num52 = 948401184;
											num53 = num52;
										}
										num4 = num52 ^ (int)(num3 * 747503505);
										continue;
									}
									case 102u:
										ptr4 = (POINTER_LIST*)_206E_206F_206C_202E_206B_206B_202E_206D_206B_202D_202D_202D_200F_202E_200F_206D_202D_206D_202D_206B_200F_200E_206C_202A_202E_200F_202E_206D_206A_206C_200D_200C_200B_206B_200C_200D_200C_206B_202C_202D_202E((uint)sizeof(POINTER_LIST));
										num4 = -2145296138;
										continue;
									case 99u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 275552605u);
										num4 = ((int)num3 * -1523181459) ^ -1662710026;
										continue;
									case 59u:
									{
										int num56;
										int num57;
										if (!_206F_202A_202A_206E_206A_200C_200E_206B_200D_206D_200F_202C_206C_200D_200D_200D_206C_202A_202A_206A_200E_206D_206C_206D_200F_202B_200D_202C_206D_202D_202D_202C_202E_206B_200B_206C_202B_202D_206E_202E_202E())
										{
											num56 = -424256122;
											num57 = num56;
										}
										else
										{
											num56 = 78741070;
											num57 = num56;
										}
										num4 = num56 ^ ((int)num3 * -1215234415);
										continue;
									}
									case 66u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2097360197u);
										num4 = -1742272983;
										continue;
									case 39u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 3915696890u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1415078424u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3318241490u);
										result = (void*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1941891425 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 4073823553u));
										num4 = (int)((num3 * 1391407846) ^ 0x626DE51);
										continue;
									case 47u:
										goto end_IL_02ca;
									case 92u:
									{
										int num37;
										int num38;
										if (ptr4 != (POINTER_LIST*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x14EBA5D9 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1634302104u))))
										{
											num37 = 689046641;
											num38 = num37;
										}
										else
										{
											num37 = 85041629;
											num38 = num37;
										}
										num4 = num37 ^ ((int)num3 * -828265337);
										continue;
									}
									case 107u:
										val3 = (T3)(ptr8->VirtualAddress + val5);
										num4 = ((int)num3 * -1096645725) ^ 0x6CB9346E;
										continue;
									case 110u:
										ptr2->getProcAddress = (void*)Marshal.GetFunctionPointerForDelegate(P_5);
										num4 = (int)(num3 * 228959997) ^ -1132655298;
										continue;
									case 52u:
									{
										ushort e_magic = ptr7->e_magic;
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 2861361824u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1615636332u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1888732470u);
										int num15;
										int num16;
										if (e_magic == global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-267381293 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 532540248u)))
										{
											num15 = -720264498;
											num16 = num15;
										}
										else
										{
											num15 = -176337812;
											num16 = num15;
										}
										num4 = num15 ^ ((int)num3 * -280263350);
										continue;
									}
									case 124u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1119162876u);
										num4 = ((int)num3 * -1528048245) ^ 0x698704E4;
										continue;
									case 138u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3031681303u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 2307250991u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1604154243u);
										_fg((Error)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1061822696 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 1963953505u)));
										num4 = ((int)num3 * -867520340) ^ 0x52CE00AB;
										continue;
									case 147u:
										obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1249880924u);
										num4 = -765604260;
										continue;
									case 69u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3087058924u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2657688517u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 223756539u);
										val2 = (T2)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x1C7FF8D3 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1570844948u)));
										num4 = ((int)num3 * -1669327028) ^ -1079096207;
										continue;
									case 81u:
									{
										int num50;
										int num51;
										if (!_206F_202A_202A_206E_206A_200C_200E_206B_200D_206D_200F_202C_206C_200D_200D_200D_206C_202A_202A_206A_200E_206D_206C_206D_200F_202B_200D_202C_206D_202D_202D_202C_202E_206B_200B_206C_202B_202D_206E_202E_202E())
										{
											num50 = -890458268;
											num51 = num50;
										}
										else
										{
											num50 = -201080477;
											num51 = num50;
										}
										num4 = num50 ^ (int)(num3 * 1912613963);
										continue;
									}
									case 119u:
									{
										int num46;
										int num47;
										if (ptr2->headers->OptionalHeader.AddressOfEntryPoint != 0)
										{
											num46 = 802483877;
											num47 = num46;
										}
										else
										{
											num46 = -1317881085;
											num47 = num46;
										}
										num4 = num46 ^ (int)(num3 * 1759790554);
										continue;
									}
									case 24u:
										ptr2->headers = (_IMAGE_NT_HEADERS*)((byte*)ptr6 + ptr7->e_lfanew);
										num4 = ((int)num3 * -388433525) ^ -1548258197;
										continue;
									case 103u:
										ptr7 = (IMAGE_DOS_HEADER*)P_0;
										num4 = -21692518;
										continue;
									case 82u:
										_fg((Error)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x48BC12F ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 4264417102u))));
										num4 = ((int)num3 * -14426625) ^ -753658507;
										continue;
									case 76u:
										num4 = ((int)num3 * -959832560) ^ 0x508E99AC;
										continue;
									case 37u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 770227921u);
										num4 = (int)((num3 * 160496003) ^ 0x4CC3CE3F);
										continue;
									case 112u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 2482091418u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3030714756u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2292289758u);
										result = (void*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-667985275 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3042680292u));
										num4 = (int)(num3 * 872933247) ^ -1948385781;
										continue;
									case 1u:
									{
										T0* intPtr3 = ptr5;
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2283632369u);
										int num33;
										int num34;
										if (intPtr3 != (T0*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x44E0ED6C ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1611699174u))))
										{
											num33 = 1536422501;
											num34 = num33;
										}
										else
										{
											num33 = -768670068;
											num34 = num33;
										}
										num4 = num33 ^ (int)(num3 * 267137924);
										continue;
									}
									case 75u:
									{
										_MEMORYMODULE* intPtr2 = ptr2;
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1376130504u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1178342689u);
										intPtr2->initialized = _200E_206A_200F_200F_202D_200F_202E_206A_200C_202B_202C_200F_200C_202C_202E_200C_202E_202D_206D_202D_206B_200E_202A_202B_202C_200D_206D_202E_206C_206C_206B_206B_206B_202A_202A_202B_206E_200C_202A_202A_202E((byte)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0xF5A34D7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 0u))) != 0);
										num4 = 1310566585;
										continue;
									}
									case 42u:
										_we(ptr, P_3, P_7);
										num4 = (int)((num3 * 641033227) ^ 0x42E5C8D9);
										continue;
									case 10u:
										ptr2->pageSize = sYSTEM_INFO.dwPageSize;
										num4 = ((int)num3 * -508661023) ^ 0x71684A9F;
										continue;
									case 35u:
										ptr4->next = ptr;
										num4 = 699676490;
										continue;
									case 31u:
										val = _Jh((T3)ptr3->OptionalHeader.SizeOfImage, (T3)sYSTEM_INFO.dwPageSize);
										num4 = (int)(num3 * 1980342418) ^ -1849748952;
										continue;
									case 136u:
										goto end_IL_02ca;
									case 2u:
										ptr2->isRelocated = _200E_206A_200F_200F_202D_200F_202E_206A_200C_202B_202C_200F_200C_202C_202E_200C_202E_202D_206D_202D_206B_200E_202A_202B_202C_200D_206D_202E_206C_206C_206B_206B_206B_202A_202A_202B_206E_200C_202A_202A_202E((byte)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x33B03AC6 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 770227921u))) != 0);
										num4 = 1246141571;
										continue;
									case 141u:
										goto end_IL_02ca;
									case 128u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(132, 304580917u);
										num4 = (int)((num3 * 839349895) ^ 0x44E6BA9F);
										continue;
									case 152u:
									{
										int num23;
										int num24;
										if (((DllEntryProc)_206B_206B_206A_200F_202D_206A_200F_200F_206E_206A_200D_206D_206B_206C_200C_206D_202E_206C_202C_200D_206C_206C_202E_200E_202B_206B_202B_206B_202A_202C_206B_200B_206E_200E_206F_202B_206E_200D_200E_206D_202E((IntPtr)((byte*)ptr5 + ptr2->headers->OptionalHeader.AddressOfEntryPoint), (Type)_206A_202B_200F_202A_206C_202E_206F_206D_206E_206E_206E_206E_200C_200B_202E_200B_206F_206B_200D_202E_206A_202C_202D_202D_200E_200F_206A_200E_206B_206F_202D_206F_206B_206A_202D_206D_200E_200C_206D_202E_202E(typeof(DllEntryProc).TypeHandle)))(ptr5, (Dll)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1286767813 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3116624607u)), (void*)(uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x6CDECCEA ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 788871309u)))))
										{
											num23 = -2110106011;
											num24 = num23;
										}
										else
										{
											num23 = 722866748;
											num24 = num23;
										}
										num4 = num23 ^ ((int)num3 * -1304075418);
										continue;
									}
									case 32u:
										result = ptr2;
										num4 = ((int)num3 * -2106042968) ^ 0x3C84C59B;
										continue;
									case 144u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(133, 746873805u);
										num4 = (int)(num3 * 1362622648) ^ -87618112;
										continue;
									case 139u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3126931447u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1586039187u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 797365219u);
										result = (void*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1085820609 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 3932387007u));
										num4 = ((int)num3 * -1027760385) ^ 0xECADCC6;
										continue;
									case 25u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1229527778u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3250098614u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 4154728052u);
										result = (void*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-349569755 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 1938737866u));
										num4 = (int)((num3 * 1497031743) ^ 0x3C46C4F6);
										continue;
									case 45u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2432488352u);
										num4 = ((int)num3 * -389106950) ^ 0x32139E6C;
										continue;
									case 33u:
										ptr2->loadLibrary = (void*)Marshal.GetFunctionPointerForDelegate(P_4);
										num4 = ((int)num3 * -157340289) ^ -333858337;
										continue;
									case 79u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 189407802u);
										num4 = (int)((num3 * 1756700004) ^ 0x1A36BF5B);
										continue;
									case 131u:
									{
										T0* intPtr = ptr5;
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 305562300u);
										int num11;
										int num12;
										if (intPtr == (T0*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-789502625 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 744509865u)))
										{
											num11 = 1251550668;
											num12 = num11;
										}
										else
										{
											num11 = 1223872470;
											num12 = num11;
										}
										num4 = num11 ^ ((int)num3 * -9005451);
										continue;
									}
									case 62u:
										ptr5 = (T0*)P_2((void*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1391726983 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3603613755u)), (UIntPtr)(ulong)(long)val, (MemoryAllocation)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x725A1441 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 777356306u))), (PageProtection)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x6A653343 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3464454666u))), P_7);
										num4 = ((int)num3 * -898320953) ^ 0x4451CE77;
										continue;
									case 125u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(129, 512161949u);
										num4 = ((int)num3 * -815387741) ^ -44464724;
										continue;
									case 98u:
										ptr2->freeLibrary = (void*)Marshal.GetFunctionPointerForDelegate(P_6);
										num4 = ((int)num3 * -1280785607) ^ 0x7CFDB3E4;
										continue;
									case 101u:
										_202D_206A_202C_202A_206F_206B_200F_200E_206A_206B_206B_206D_206F_200F_206B_202E_206B_202B_200E_202A_206F_200C_206B_200F_206C_206D_202D_206F_202B_200B_200C_202A_200D_202C_202C_200D_206E_200E_200D_206B_202E((void*)ptr6, (void*)ptr7, ptr3->OptionalHeader.SizeOfHeaders);
										num4 = ((int)num3 * -678180054) ^ -1343383152;
										continue;
									case 51u:
										num4 = (int)(num3 * 1188312930) ^ -388011349;
										continue;
									case 113u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(131, 3384754653u);
										num4 = ((int)num3 * -1589027764) ^ 0x25084CE4;
										continue;
									case 50u:
										ptr2->alloc = (void*)Marshal.GetFunctionPointerForDelegate(P_2);
										num4 = ((int)num3 * -1344148553) ^ -1319642016;
										continue;
									case 44u:
									{
										int num58;
										int num59;
										if ((object)val == (object)_Jh(val4, (T3)sYSTEM_INFO.dwPageSize))
										{
											num58 = 1198576807;
											num59 = num58;
										}
										else
										{
											num58 = -928654648;
											num59 = num58;
										}
										num4 = num58 ^ ((int)num3 * -953370733);
										continue;
									}
									case 74u:
										ptr2->isRelocated = _200E_206A_200F_200F_202D_200F_202E_206A_200C_202B_202C_200F_200C_202C_202E_200C_202E_202D_206D_202D_206B_200E_202A_202B_202C_200D_206D_202E_206C_206C_206B_206B_206B_202A_202A_202B_206E_200C_202A_202A_202E(_Ee<T0, T2, ushort, T1, long, bool>(ptr2, (long)val7));
										num4 = ((int)num3 * -1790398073) ^ 0x5906F10E;
										continue;
									case 118u:
										val2 = (T2)(val2 + global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-706666551 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3868165592u)));
										num4 = -334284502;
										continue;
									case 38u:
									{
										int num54;
										int num55;
										if (val7 != null)
										{
											num54 = 118847145;
											num55 = num54;
										}
										else
										{
											num54 = -145875646;
											num55 = num54;
										}
										num4 = num54 ^ ((int)num3 * -776248731);
										continue;
									}
									case 130u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3530412378u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 83813251u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 3669719582u);
										result = (void*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-68352554 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3425396344u));
										num4 = (int)((num3 * 1584687140) ^ 0x7676092);
										continue;
									case 19u:
									{
										int num48;
										int num49;
										if (!_hE<bool, T3>(P_1, (T3)sizeof(IMAGE_DOS_HEADER)))
										{
											num48 = 286945337;
											num49 = num48;
										}
										else
										{
											num48 = 167239154;
											num49 = num48;
										}
										num4 = num48 ^ ((int)num3 * -987749567);
										continue;
									}
									case 7u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 1963953505u);
										num4 = (int)((num3 * 456626105) ^ 0x2AEDCD83);
										continue;
									case 117u:
										ptr2->codeBase = (byte*)ptr5;
										num4 = -1679858534;
										continue;
									case 4u:
									{
										int num44;
										int num45;
										if (ptr8->SizeOfRawData != 0)
										{
											num44 = -83527425;
											num45 = num44;
										}
										else
										{
											num44 = -30258433;
											num45 = num44;
										}
										num4 = num44 ^ ((int)num3 * -1854066491);
										continue;
									}
									case 142u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3099429825u);
										num4 = 1377931898;
										continue;
									case 126u:
										obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3052183096u);
										num4 = (int)(num3 * 973283212) ^ -1236767611;
										continue;
									case 87u:
									{
										ulong num43 = ((UIntPtr*)(&val6))->ToUInt64();
										val6 = (T4)(nuint)ptr3->OptionalHeader.ImageBase;
										val7 = (T1)(num43 - ((UIntPtr*)(&val6))->ToUInt64());
										num4 = ((int)num3 * -702077558) ^ -874122878;
										continue;
									}
									case 8u:
										obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(4046320509u);
										num4 = -60377295;
										continue;
									case 27u:
										obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3129046536u);
										num4 = 1315320814;
										continue;
									case 123u:
										_fg((Error)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-237801742 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1707992775u)));
										num4 = (int)(num3 * 297611450) ^ -1730440109;
										continue;
									case 83u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2139697577u);
										num4 = -1123685220;
										continue;
									case 78u:
										ptr2 = (_MEMORYMODULE*)_gj(_db(), (uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-610004285 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1334085924u)), (uint)_202C_200C_206D_206D_202E_206C_206B_206C_206F_200D_202A_206C_200B_206D_206D_202A_202B_202B_206E_206C_200C_206A_200E_202B_200D_202A_206D_206B_206F_206C_202C_202E_202B_200E_206F_206C_206E_202C_200E_200D_202E((Type)_206A_202B_200F_202A_206C_202E_206F_206D_206E_206E_206E_206E_200C_200B_202E_200B_206F_206B_200D_202E_206A_202C_202D_202D_200E_200F_206A_200E_206B_206F_202D_206F_206B_206A_202D_206D_200E_200C_206D_202E_202E(typeof(_MEMORYMODULE).TypeHandle)));
										num4 = -474155170;
										continue;
									case 46u:
										goto end_IL_02ca;
									case 55u:
										ptr2->exeEntry = (void*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-667985275 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3992977125u));
										num4 = -198940308;
										continue;
									case 48u:
										ptr6 = (T0*)P_2(ptr5, (UIntPtr)ptr3->OptionalHeader.SizeOfHeaders, (MemoryAllocation)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-278073831 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3914238419u)), (PageProtection)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x3CF10A06 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2111501621u))), P_7);
										num4 = 1705129531;
										continue;
									case 6u:
										num4 = (int)((num3 * 1057424827) ^ 0x499C75B1);
										continue;
									case 58u:
										_fg((Error)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x704D3FFB ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 238770132u))));
										num4 = (int)(num3 * 1864443744) ^ -650201909;
										continue;
									case 57u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(134, 3225453373u);
										num4 = ((int)num3 * -1104721512) ^ 0x7AF31E5F;
										continue;
									case 41u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 350224158u);
										num4 = -503530470;
										continue;
									case 11u:
									{
										int num41;
										int num42;
										if (!_hE<bool, T3>(P_1, (T3)(ptr7->e_lfanew + sizeof(_IMAGE_NT_HEADERS))))
										{
											num41 = 1543522230;
											num42 = num41;
										}
										else
										{
											num41 = -1257751402;
											num42 = num41;
										}
										num4 = num41 ^ ((int)num3 * -2119059327);
										continue;
									}
									case 80u:
										ptr2->free = (void*)Marshal.GetFunctionPointerForDelegate(P_3);
										num4 = (int)((num3 * 1284219971) ^ 0x24C8ECFF);
										continue;
									case 111u:
										val3 = (T3)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1633933534 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2258041916u));
										num4 = 207559742;
										continue;
									case 53u:
										goto end_IL_02ca;
									case 109u:
										val6 = (T4)(nuint)ptr2->headers->OptionalHeader.ImageBase;
										num4 = ((int)num3 * -1526920983) ^ 0x16BBDB40;
										continue;
									case 89u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1128908302u);
										num4 = (int)((num3 * 1884069809) ^ 0x2F875B00);
										continue;
									case 18u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(130, 2596463725u);
										num4 = (int)((num3 * 910695907) ^ 0x3373602C);
										continue;
									case 148u:
									{
										int num39;
										int num40;
										if (ptr3->FileHeader.Machine != _mA)
										{
											num39 = 615001544;
											num40 = num39;
										}
										else
										{
											num39 = -1713329020;
											num40 = num39;
										}
										num4 = num39 ^ ((int)num3 * -658660016);
										continue;
									}
									case 122u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1341254366u);
										num4 = -742424127;
										continue;
									case 0u:
									{
										int num35;
										int num36;
										if (_Hj<T1, T0, T4, bool, T3, T5, T2>((T0*)P_0, P_1, ptr3, ptr2))
										{
											num35 = 519589327;
											num36 = num35;
										}
										else
										{
											num35 = -1353379002;
											num36 = num35;
										}
										num4 = num35 ^ (int)(num3 * 1908813790);
										continue;
									}
									case 137u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1371276810u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 4020881982u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1887654864u);
										result = (void*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1285488687 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 2125216578u));
										num4 = (int)((num3 * 1785052065) ^ 0x2A041D52);
										continue;
									case 145u:
										ptr5 = (T0*)P_2((void*)ptr3->OptionalHeader.ImageBase, (UIntPtr)(ulong)(long)val, (MemoryAllocation)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1614792095 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 556169088u)), (PageProtection)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x48F0C04F ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 907345714u))), P_7);
										num4 = -1568666314;
										continue;
									case 95u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3250098614u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 1938737866u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 43238699u);
										result = (void*)(uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x6A256FD4 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 778598549u)));
										num4 = (int)(num3 * 431882056) ^ -892601284;
										continue;
									case 54u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 1963953505u);
										num4 = ((int)num3 * -1103132438) ^ 0x483FAEE6;
										continue;
									case 15u:
										ptr2->exeEntry = (byte*)ptr5 + ptr2->headers->OptionalHeader.AddressOfEntryPoint;
										num4 = ((int)num3 * -641364681) ^ -722234633;
										continue;
									case 70u:
									{
										int num32;
										if (!_200F_200C_206A_200D_200D_206F_206F_200D_206F_202A_206F_206E_206A_206E_200D_202A_202C_200F_206D_202D_206A_200C_202D_206E_200C_202A_202C_200C_200B_202D_200C_200E_200D_206C_202B_206C_200B_202B_200D_202E_202E(ptr3->OptionalHeader.SectionAlignment & (uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x64B9629C ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1272635337u)))))
										{
											num4 = -417814552;
											num32 = num4;
										}
										else
										{
											num4 = -1994616895;
											num32 = num4;
										}
										continue;
									}
									case 88u:
										val5 = (T3)ptr3->OptionalHeader.SectionAlignment;
										num4 = (int)(num3 * 930784675) ^ -1202497961;
										continue;
									case 71u:
										num4 = ((int)num3 * -1566738932) ^ -505416872;
										continue;
									case 149u:
										goto end_IL_02ca;
									case 140u:
										ptr5 = (T0*)P_2((void*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x27029B5D ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2620485933u))), (UIntPtr)(ulong)(long)val, (MemoryAllocation)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x45BCF02F ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 62782189u))), (PageProtection)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1836316159 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2283632369u)), P_7);
										num4 = (int)(num3 * 647096072) ^ -286369957;
										continue;
									case 26u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 361212104u);
										num4 = ((int)num3 * -653805863) ^ 0x217E768E;
										continue;
									case 65u:
										_fg((Error)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x298022A3 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 356801933u))));
										num4 = ((int)num3 * -1510193459) ^ 0x1C5CBA5B;
										continue;
									case 63u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1670697713u);
										num4 = -597835612;
										continue;
									case 29u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2201345580u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 3669719582u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3675909834u);
										result = (void*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-68352554 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 799974388u));
										num4 = ((int)num3 * -1786207307) ^ -291465988;
										continue;
									case 49u:
									{
										uint signature = ptr3->Signature;
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3224312285u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3993351619u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1371005085u);
										int num30;
										int num31;
										if (signature != (uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1762787475 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 1807170429u)))
										{
											num30 = 78949655;
											num31 = num30;
										}
										else
										{
											num30 = 666101388;
											num31 = num30;
										}
										num4 = num30 ^ (int)(num3 * 1413873545);
										continue;
									}
									case 134u:
										ptr8 = _pK<T5, T4>((T4)(nuint)(UIntPtr)ptr3);
										num4 = 605760750;
										continue;
									case 9u:
										num4 = ((int)num3 * -2064495465) ^ 0x5CCCB87A;
										continue;
									case 16u:
										_fg((Error)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0xD5F3473 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3127560544u))));
										num4 = (int)((num3 * 1241909637) ^ 0x35499E3F);
										continue;
									case 129u:
										goto end_IL_02ca;
									case 132u:
									{
										int num28;
										int num29;
										if (!_200C_200E_202D_200B_202D_206E_206D_206C_200C_200F_202D_206C_200F_202D_206A_202B_206D_202A_200D_200C_206C_206E_202B_202A_206A_206C_202B_206C_206D_202D_200E_200C_200C_206A_202C_200B_202A_202A_202E_202C_202E(ptr2->isDLL))
										{
											num28 = -718722016;
											num29 = num28;
										}
										else
										{
											num28 = 2021931374;
											num29 = num28;
										}
										num4 = num28 ^ ((int)num3 * -1533911);
										continue;
									}
									case 116u:
										P_3(ptr5, (UIntPtr)(ulong)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x474F46AC ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 301195868u))), (MemoryAllocation)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1229064421 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 812865845u)), P_7);
										num4 = ((int)num3 * -658142349) ^ 0x18C14B93;
										continue;
									case 23u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1128908302u);
										num4 = ((int)num3 * -1948810086) ^ -1389263853;
										continue;
									case 85u:
										num4 = ((int)num3 * -609227709) ^ 0x417ECA22;
										continue;
									case 155u:
									{
										ulong num25 = (ulong)ptr5 >> global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-89208214 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1661326828u));
										long num26 = (long)((byte*)ptr5 + (nuint)val);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2633640468u);
										int num27;
										if (num25 >= (ulong)(num26 >>> global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-975042389 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1935669796u))))
										{
											num4 = -762462568;
											num27 = num4;
										}
										else
										{
											num4 = -80073304;
											num27 = num4;
										}
										continue;
									}
									case 5u:
										val3 = (T3)(ptr8->VirtualAddress + ptr8->SizeOfRawData);
										num4 = (int)((num3 * 2112610275) ^ 0x7B050DF2);
										continue;
									case 100u:
									{
										int num21;
										int num22;
										if (_BE<T0, bool, T4, char, T1, T2, T5, T3>(ptr2))
										{
											num21 = -679297331;
											num22 = num21;
										}
										else
										{
											num21 = 1456341902;
											num22 = num21;
										}
										num4 = num21 ^ ((int)num3 * -1144218036);
										continue;
									}
									case 84u:
										goto end_IL_02ca;
									case 96u:
									{
										int num19;
										int num20;
										if (ptr5 == (T0*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-42053357 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 716161137u)))
										{
											num19 = -1990347454;
											num20 = num19;
										}
										else
										{
											num19 = 729001769;
											num20 = num19;
										}
										num4 = num19 ^ (int)(num3 * 544693798);
										continue;
									}
									case 127u:
										_fg((Error)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1877716030 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3614899635u)));
										num4 = (int)(num3 * 1180322014) ^ -882707245;
										continue;
									case 40u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1076556091u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 3976368615u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3811860053u);
										result = (void*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-477876672 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 685850439u));
										num4 = ((int)num3 * -978864170) ^ 0x1EBAF85A;
										continue;
									case 68u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1759441099u);
										num4 = ((int)num3 * -1553319276) ^ 0x29DF89A1;
										continue;
									case 114u:
										goto end_IL_02ca;
									case 133u:
										_we(ptr, P_3, P_7);
										num4 = ((int)num3 * -1980801711) ^ -409303296;
										continue;
									case 72u:
										ptr8++;
										num4 = (int)((num3 * 266491728) ^ 0x1774DE3D);
										continue;
									case 17u:
									{
										int num17;
										int num18;
										if (_206F_202A_202A_206E_206A_200C_200E_206B_200D_206D_200F_202C_206C_200D_200D_200D_206C_202A_202A_206A_200E_206D_206C_206D_200F_202B_200D_202C_206D_202D_202D_202C_202E_206B_200B_206C_202B_202D_206E_202E_202E())
										{
											num17 = 1743633595;
											num18 = num17;
										}
										else
										{
											num17 = -1517178004;
											num18 = num17;
										}
										num4 = num17 ^ (int)(num3 * 1300234164);
										continue;
									}
									case 86u:
										_fg((Error)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x7EF5236E ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2943735864u))));
										num4 = ((int)num3 * -1780039589) ^ 0x707579D2;
										continue;
									case 153u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1457974191u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 3976368615u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2309758569u);
										result = (void*)(uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x6A256FD4 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 2019936363u)));
										num4 = (int)((num3 * 1090799811) ^ 0xE47400B);
										continue;
									case 120u:
										ptr2->userdata = P_7;
										num4 = (int)(num3 * 663273091) ^ -130001192;
										continue;
									case 154u:
										_4g(&sYSTEM_INFO);
										num4 = (int)((num3 * 1949341495) ^ 0x35FB9C7F);
										continue;
									case 3u:
										P_3(ptr5, (UIntPtr)(ulong)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-769006312 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3250700095u)), (MemoryAllocation)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x65DB61D1 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2100371374u))), P_7);
										num4 = (int)(num3 * 2025207535) ^ -674127737;
										continue;
									case 135u:
										obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3098532517u);
										num4 = 1723366711;
										continue;
									case 56u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(131, 2768722189u);
										num4 = (int)((num3 * 1353108601) ^ 0x7E25143F);
										continue;
									case 14u:
									{
										int num13;
										int num14;
										if (val3 <= val4)
										{
											num13 = -1245298232;
											num14 = num13;
										}
										else
										{
											num13 = 1474690564;
											num14 = num13;
										}
										num4 = num13 ^ (int)(num3 * 1456358850);
										continue;
									}
									case 61u:
										obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2026633278u);
										num4 = 176794539;
										continue;
									case 150u:
									{
										int num9;
										int num10;
										if (_hk<T1, T4, bool, T5, T2>(ptr2))
										{
											num9 = -1213350318;
											num10 = num9;
										}
										else
										{
											num9 = -1666277557;
											num10 = num9;
										}
										num4 = num9 ^ ((int)num3 * -1415669605);
										continue;
									}
									case 151u:
										ptr2->blockedMemory = ptr;
										num4 = ((int)num3 * -2119243921) ^ -2132958576;
										continue;
									case 34u:
										ptr = ptr4;
										num4 = ((int)num3 * -1214327452) ^ -2067977756;
										continue;
									case 106u:
									{
										int num7;
										int num8;
										if ((nuint)(nint)val2 < (nuint)(int)ptr3->FileHeader.NumberOfSections)
										{
											num7 = 1174905097;
											num8 = num7;
										}
										else
										{
											num7 = 1521620162;
											num8 = num7;
										}
										num4 = num7 ^ ((int)num3 * -1336952466);
										continue;
									}
									case 28u:
										ptr4->address = ptr5;
										num4 = (int)(num3 * 628521753) ^ -880006680;
										continue;
									case 20u:
										_we(ptr, P_3, P_7);
										num4 = (int)(num3 * 620266245) ^ -2015157161;
										continue;
									case 97u:
										obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3787406989u);
										num4 = (int)(num3 * 213160468) ^ -823873179;
										continue;
									case 108u:
										ptr2->isDLL = _200E_206A_200F_200F_202D_200F_202E_206A_200C_202B_202C_200F_200C_202C_202E_200C_202E_202D_206D_202D_206B_200E_202A_202B_202C_200D_206D_202E_206C_206C_206B_206B_206B_202A_202A_202B_206E_200C_202A_202A_202E((uint)(ptr3->FileHeader.Characteristics & global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1460843394 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3109868315u))) > (uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1000548375 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 68189859u)));
										num4 = ((int)num3 * -962435220) ^ -680498124;
										continue;
									case 13u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1935669796u);
										num4 = ((int)num3 * -1408277032) ^ 0x34D8CE57;
										continue;
									case 64u:
										obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1419496064u);
										num4 = ((int)num3 * -1318688031) ^ 0x7398F1CA;
										continue;
									case 43u:
										_fg((Error)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x5DD8E519 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3134788982u))));
										num4 = (int)(num3 * 2025826453) ^ -446614320;
										continue;
									case 36u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 3976368615u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 607030257u);
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 558074275u);
										result = (void*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-349569755 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1457974191u));
										num4 = (int)((num3 * 1579793766) ^ 0x40F7C1DF);
										continue;
									case 121u:
										obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(128, 1308710701u);
										num4 = -480407610;
										continue;
									case 21u:
										goto end_IL_02ca;
									case 73u:
										_fg((Error)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1460841434 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 2132917481u)));
										num4 = 1753600698;
										continue;
									case 60u:
									{
										int num5;
										int num6;
										if (ptr2 != (_MEMORYMODULE*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x355ED2C1 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3950228090u))))
										{
											num5 = -844077165;
											num6 = num5;
										}
										else
										{
											num5 = -1748827222;
											num6 = num5;
										}
										num4 = num5 ^ (int)(num3 * 937372691);
										continue;
									}
									case 105u:
										goto end_IL_02ca;
									case 22u:
									case 30u:
									case 77u:
									case 90u:
									case 104u:
										goto IL_20a8;
									}
									goto IL_02c5;
									continue;
									end_IL_02ca:
									break;
								}
								break;
							}
						}
						catch
						{
							obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1126373049u);
							while (true)
							{
								int num60 = 1374330703;
								while (true)
								{
									num2 = num60;
									switch ((num3 = (uint)(((((-(-num2) ^ 0x6C8E3405) + (~(~-721753593) + -1951361156 - ((-2003647774 ^ -782644717) - 1846876339 * -1836828537 * -871603653)) - (-1671579069 + ~1532591641) * 607593267) ^ 0x1F302744) - (-7999402 ^ -393828097)) * 281976739)) % 3)
									{
									case 2u:
										break;
									case 1u:
										goto IL_208c;
									default:
										throw;
									}
									break;
									IL_208c:
									_Gj<GCHandle, T1, bool>(ptr2);
									num60 = (int)((num3 * 1223581879) ^ 0x6A6FF878);
								}
							}
						}
						goto IL_2186;
					}
					IL_20a8:
					_Gj<GCHandle, T1, bool>(ptr2);
					goto IL_20af;
					IL_20af:
					num61 = 403599356;
					goto IL_20b4;
					IL_20b4:
					num2 = num61;
					switch ((num3 = (uint)(((((-(-num2) ^ 0x6C8E3405) + (~(~-721753593) + -1951361156 - ((-2003647774 ^ -782644717) - 1846876339 * -1836828537 * -871603653)) - (-1671579069 + ~1532591641) * 607593267) ^ 0x1F302744) - (-7999402 ^ -393828097)) * 281976739)) % 4)
					{
					case 0u:
						break;
					case 2u:
						return (void*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-318927790 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 449074223u));
					case 1u:
						goto IL_2186;
					default:
						return result;
					}
					goto IL_20af;
					IL_2186:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1572897429u);
					num61 = -142414815;
					goto IL_20b4;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T2 _Gj<T0, T1, T2>(_MEMORYMODULE* P_0)
	{
		//IL_018e: Expected O, but got I4
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0724: Expected O, but got I4
		//IL_060e: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(246703903u);
		MEMORYMODULE mEMORYMODULE = default(MEMORYMODULE);
		T0 val2 = default(T0);
		_MEMORYMODULE* ptr = default(_MEMORYMODULE*);
		T1 val = default(T1);
		while (true)
		{
			int num = -64992289;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(num2 - (-(-1082382161 * -((-735610465 + -1920649677) * -1411411933)) ^ 0x152A6746) - (1733577052 - -1071661226 - (-6614670 - -1811702121) - (1687824241 - 1557379425 - (1823813038 - -1773430321)) + -(-1922299330 + -1685813812) - -235262348) * -1136236487 - 1412552995 * (~(-819944474 ^ -264920274) ^ (-(-288908732 - 415150616) ^ (-2051788524 ^ --1055280221)))))) % 32)
				{
				case 4u:
					break;
				case 21u:
					return (T2)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1090904743 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2866330976u));
				case 0u:
					mEMORYMODULE = (MEMORYMODULE)_206F_206F_202C_206B_200F_200B_200D_206C_200F_202E_200B_200C_200E_200C_206E_206F_202B_206F_206C_202B_200F_202A_200D_206B_200F_200D_202E_200B_206E_200F_206A_206E_200D_200C_202C_202B_202B_200F_206C_206C_202E(P_0);
					num = (int)((num3 * 1620530427) ^ 0x7F6D9981);
					continue;
				case 17u:
					val2 = (T0)GCHandle.FromIntPtr(ptr->nameExportsTable);
					num = (int)(num3 * 1167350551) ^ -1242619190;
					continue;
				case 29u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3125641348u);
					num = -169388808;
					continue;
				case 6u:
				{
					void** modules = ptr->modules;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 1830778495u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 2020093761u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2041473511u);
					int num9;
					if (modules != (void**)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1178614037 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1091513139u)))
					{
						num = 44792999;
						num9 = num;
					}
					else
					{
						num = -394234252;
						num9 = num;
					}
					continue;
				}
				case 12u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3007724540u);
					num = -529586257;
					continue;
				case 25u:
					((GCHandle*)(&val2))->Free();
					num = (int)((num3 * 1465240131) ^ 0x716ED72B);
					continue;
				case 3u:
				{
					int num14;
					int num15;
					if (!_200C_200E_202D_200B_202D_206E_206D_206C_200C_200F_202D_206C_200F_202D_206A_202B_206D_202A_200D_200C_206C_206E_202B_202A_206A_206C_202B_206C_206D_202D_200E_200C_200C_206A_202C_200B_202A_202A_202E_202C_202E(ptr->initialized))
					{
						num14 = 1170470382;
						num15 = num14;
					}
					else
					{
						num14 = -1196585130;
						num15 = num14;
					}
					num = num14 ^ (int)(num3 * 2014260168);
					continue;
				}
				case 24u:
					((DllEntryProc)_206B_206B_206A_200F_202D_206A_200F_200F_206E_206A_200D_206D_206B_206C_200C_206D_202E_206C_202C_200D_206C_206C_202E_200E_202B_206B_202B_206B_202A_202C_206B_200B_206E_200E_206F_202B_206E_200D_200E_206D_202E((IntPtr)(ptr->codeBase + ptr->headers->OptionalHeader.AddressOfEntryPoint), (Type)_206A_202B_200F_202A_206C_202E_206F_206D_206E_206E_206E_206E_200C_200B_202E_200B_206F_206B_200D_202E_206A_202C_202D_202D_200E_200F_206A_200E_206B_206F_202D_206F_206B_206A_202D_206D_200E_200C_206D_202E_202E(typeof(DllEntryProc).TypeHandle)))(ptr->codeBase, (Dll)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1095523476 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2140034109u)), (void*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x34C2A4DF ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2140034109u))));
					num = (int)(num3 * 1209043839) ^ -1298911404;
					continue;
				case 14u:
				{
					int num7;
					int num8;
					if ((nint)val < ptr->numModules)
					{
						num7 = -395626278;
						num8 = num7;
					}
					else
					{
						num7 = -389524077;
						num8 = num7;
					}
					num = num7 ^ (int)(num3 * 959115022);
					continue;
				}
				case 27u:
					val = (T1)(val + global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x1D08B3D7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 391063291u))));
					num = ((int)num3 * -200765773) ^ 0x5FB80FE8;
					continue;
				case 22u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2258934659u);
					num = -1276383389;
					continue;
				case 19u:
					_ZK(ptr->blockedMemory, ptr->free, ptr->userdata);
					num = (int)((num3 * 162758460) ^ 0x5A54643C);
					continue;
				case 15u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 4092822371u);
					num = (int)(num3 * 1720272100) ^ -779029947;
					continue;
				case 7u:
					ptr = P_0;
					num = ((int)num3 * -698022471) ^ 0x676DD489;
					continue;
				case 30u:
					_6n(_db(), (uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x50601D93 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2293538608u))), ptr);
					num = -265096214;
					continue;
				case 18u:
				{
					int num16;
					if (ptr->codeBase == (byte*)(uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1144238976 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 4281314442u)))
					{
						num = -29385446;
						num16 = num;
					}
					else
					{
						num = -238047412;
						num16 = num;
					}
					continue;
				}
				case 1u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(633808147u);
					num = 336788651;
					continue;
				case 20u:
					mEMORYMODULE.freeLibrary(ptr->modules[(nint)val], ptr->userdata);
					num = ((int)num3 * -1361605258) ^ 0x531B263D;
					continue;
				case 9u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(880947940u);
					num = (int)((num3 * 15377740) ^ 0x9FE905D);
					continue;
				case 5u:
				{
					_MEMORYMODULE* intPtr2 = ptr;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 1863294395u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 35286789u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3362062811u);
					int num12;
					int num13;
					if (intPtr2 == (_MEMORYMODULE*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x5A89D4AB ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1553480859u))))
					{
						num12 = -1072559178;
						num13 = num12;
					}
					else
					{
						num12 = 677871419;
						num13 = num12;
					}
					num = num12 ^ (int)(num3 * 527083759);
					continue;
				}
				case 13u:
					_206E_206C_200D_200B_200D_206C_200F_202B_200F_206D_206D_202C_202A_202A_206D_206F_206F_200B_202E_200C_202D_200D_202A_206B_202E_200E_200C_200D_200C_206A_206C_202B_200C_200D_200C_206B_202C_200C_202B_206F_202E((void*)ptr->modules);
					num = ((int)num3 * -1925365645) ^ 0x5B9CDE83;
					continue;
				case 16u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3600393719u);
					num = 395130788;
					continue;
				case 26u:
				{
					CustomFreeFunc free = mEMORYMODULE.free;
					byte* codeBase = ptr->codeBase;
					UIntPtr size = (UIntPtr)(ulong)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1144238976 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 366157456u));
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 366157456u);
					free(codeBase, size, (MemoryAllocation)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x574432E5 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 0u))), ptr->userdata);
					num = (int)(num3 * 1258319221) ^ -603979752;
					continue;
				}
				case 31u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 2697780108u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2960555604u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 3432052721u);
					val = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-43717049 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 536632911u));
					num = (int)(num3 * 751607318) ^ -155714927;
					continue;
				case 23u:
				{
					int num10;
					int num11;
					if (!_206F_202A_202A_206E_206A_200C_200E_206B_200D_206D_200F_202C_206C_200D_200D_200D_206C_202A_202A_206A_200E_206D_206C_206D_200F_202B_200D_202C_206D_202D_202D_202C_202E_206B_200B_206C_202B_202D_206E_202E_202E())
					{
						num10 = -1861426438;
						num11 = num10;
					}
					else
					{
						num10 = -1603010559;
						num11 = num10;
					}
					num = num10 ^ ((int)num3 * -892633186);
					continue;
				}
				case 2u:
				{
					int num5;
					int num6;
					if (!(ptr->nameExportsTable != IntPtr.Zero))
					{
						num5 = 1270163950;
						num6 = num5;
					}
					else
					{
						num5 = -2026391333;
						num6 = num5;
					}
					num = num5 ^ ((int)num3 * -1194195049);
					continue;
				}
				case 10u:
					_NI<byte, T2>(ptr);
					num = (int)((num3 * 962086489) ^ 0x5E34D7AC);
					continue;
				case 11u:
					num = ((int)num3 * -1135226655) ^ 0x367317A2;
					continue;
				case 8u:
				{
					void* intPtr = ptr->modules[(nint)val];
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1132854583u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 536632911u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3078880631u);
					int num4;
					if (intPtr == (void*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-651333860 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 3432052721u)))
					{
						num = -1115117883;
						num4 = num;
					}
					else
					{
						num = 652242514;
						num4 = num;
					}
					continue;
				}
				default:
					return (T2)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x75CE22DA ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3812322459u)));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void* _HI<T0, T1, T2, T3, T4, T5, T6>(_MEMORYMODULE* P_0, T6* P_1)
	{
		//IL_0687: Expected I, but got O
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		//IL_06a8: Expected O, but got I
		//IL_0851: Expected O, but got I4
		//IL_03cc: Expected I, but got O
		//IL_07d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected O, but got Unknown
		//IL_0a4e: Expected O, but got I4
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(597935361u);
		T2 val3 = default(T2);
		T0* codeBase = default(T0*);
		T1* ptr5 = default(T1*);
		T3* ptr4 = default(T3*);
		_IMAGE_EXPORT_DIRECTORY* ptr = default(_IMAGE_EXPORT_DIRECTORY*);
		T1 value = default(T1);
		T5 val4 = default(T5);
		_MEMORYMODULE* ptr3 = default(_MEMORYMODULE*);
		T4 val2 = default(T4);
		_IMAGE_DATA_DIRECTORY* ptr2 = default(_IMAGE_DATA_DIRECTORY*);
		T1 val = default(T1);
		while (true)
		{
			int num = 1275479549;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(442106550 - (641761789 * -140554930 - (~((num2 - ~(-(-(-(0x2FB9F1BF ^ -(-37441035 * -759442774))))) + -(1514457041 * (-(~(-49593172 * -306203283)) ^ 0x6B713324))) ^ (--1301925784 ^ 0x6CFD59E1)) * 1148625367 + ~(~-452839666))))) % 68)
				{
				case 43u:
					break;
				case 61u:
					((Dictionary<string, uint>)val3).Add(_206B_202B_202D_206A_206E_206F_206A_200D_202B_206D_200E_200C_202E_206A_202C_202D_200B_206D_206B_200E_200E_206D_200B_202A_202D_206B_200B_206C_206E_206E_206D_206E_202A_200B_206B_206C_200E_200E_206B_202E_202E((IntPtr)((byte*)codeBase + (uint)(*(int*)ptr5))), (uint)(*(ushort*)ptr4));
					num = -1615319713;
					continue;
				case 4u:
				{
					int num18;
					int num19;
					if (ptr->NumberOfFunctions != 0)
					{
						num18 = 336529477;
						num19 = num18;
					}
					else
					{
						num18 = -1063608560;
						num19 = num18;
					}
					num = num18 ^ ((int)num3 * -817657985);
					continue;
				}
				case 38u:
					val3 = (T2)Activator.CreateInstance(typeof(T2));
					num = (int)((num3 * 1529648276) ^ 0x11144261);
					continue;
				case 62u:
					value = (T1)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x4E6ED50E ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2324530658u)));
					num = (int)(num3 * 1448564874) ^ -577256416;
					continue;
				case 14u:
				{
					int num14;
					int num15;
					if ((nuint)(nint)value > (nuint)(int)ptr->NumberOfFunctions)
					{
						num14 = 147154536;
						num15 = num14;
					}
					else
					{
						num14 = 1609561529;
						num15 = num14;
					}
					num = num14 ^ (int)(num3 * 1285446507);
					continue;
				}
				case 57u:
					ptr4 = (T3*)((byte*)ptr4 + global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-905895633 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3366758945u)));
					num = (int)((num3 * 2069718857) ^ 0x230CFAC4);
					continue;
				case 0u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3688174643u);
					num = -1437503848;
					continue;
				case 12u:
					return (void*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x16E50DAE ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1142619839u)));
				case 19u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2589903069u);
					num = 1115420719;
					continue;
				case 20u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1742110034u);
					num = -388528861;
					continue;
				case 22u:
					val4 = (T5)GCHandle.FromIntPtr(ptr3->nameExportsTable);
					num = (int)(num3 * 1147533261) ^ -1977307473;
					continue;
				case 2u:
				{
					int num22;
					int num23;
					if (((Dictionary<string, uint>)val3).TryGetValue(_206B_202B_202D_206A_206E_206F_206A_200D_202B_206D_200E_200C_202E_206A_202C_202D_200B_206D_206B_200E_200E_206D_200B_202A_202D_206B_200B_206C_206E_206E_206D_206E_202A_200B_206B_206C_200E_200E_206B_202E_202E((IntPtr)P_1), out *(uint*)(&value)))
					{
						num22 = -1487817243;
						num23 = num22;
					}
					else
					{
						num22 = -1766315864;
						num23 = num22;
					}
					num = num22 ^ ((int)num3 * -1727077244);
					continue;
				}
				case 31u:
					ptr4 = (T3*)((byte*)codeBase + ptr->AddressOfNameOrdinals);
					num = (int)(num3 * 201259814) ^ -1347969771;
					continue;
				case 41u:
				{
					int num12;
					int num13;
					if (!((IntPtr)val2 == IntPtr.Zero))
					{
						num12 = -463187769;
						num13 = num12;
					}
					else
					{
						num12 = 418630449;
						num13 = num12;
					}
					num = num12 ^ ((int)num3 * -1267051521);
					continue;
				}
				case 42u:
				{
					int num8;
					int num9;
					if (ptr2->Size != 0)
					{
						num8 = 1140241567;
						num9 = num8;
					}
					else
					{
						num8 = 82382218;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -434048567);
					continue;
				}
				case 16u:
					num = (int)((num3 * 342882440) ^ 0x6B1C390D);
					continue;
				case 17u:
					ptr2 = _Pf(ptr3, (ImageDirectoryEntry)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1402951794 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 4175459269u)));
					num = (int)((num3 * 567122436) ^ 0x771BB20F);
					continue;
				case 18u:
					ptr = (_IMAGE_EXPORT_DIRECTORY*)((byte*)codeBase + ptr2->VirtualAddress);
					num = ((int)num3 * -1287058226) ^ -482697358;
					continue;
				case 30u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 3400384611u);
					num = (int)((num3 * 437973137) ^ 0x1633DEB9);
					continue;
				case 66u:
				{
					int num24;
					int num25;
					if (ptr3->nameExportsTable == IntPtr.Zero)
					{
						num24 = 1219836085;
						num25 = num24;
					}
					else
					{
						num24 = -1493793692;
						num25 = num24;
					}
					num = num24 ^ ((int)num3 * -304377747);
					continue;
				}
				case 49u:
					ptr = default(_IMAGE_EXPORT_DIRECTORY*);
					num = (int)(num3 * 1844569572) ^ -880744484;
					continue;
				case 1u:
					_fg((Error)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x74029526 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 4133718927u))));
					num = ((int)num3 * -742725526) ^ 0x5571A41B;
					continue;
				case 35u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2205425231u);
					num = (int)((num3 * 470709818) ^ 0x1884E7F2);
					continue;
				case 47u:
					_fg((Error)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1176562177 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3267525783u)));
					num = ((int)num3 * -1488205987) ^ 0x52652DDD;
					continue;
				case 51u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3747311829u);
					num = 154242854;
					continue;
				case 39u:
					_fg((Error)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-602147640 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 753246125u)));
					num = ((int)num3 * -1561639713) ^ 0x1D5D45DF;
					continue;
				case 5u:
					_fg((Error)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-748408228 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1255655960u)));
					num = ((int)num3 * -1500600806) ^ 0x18E6210C;
					continue;
				case 11u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2941126432u);
					num = ((int)num3 * -808988047) ^ 0x2C66031E;
					continue;
				case 64u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2513434524u);
					num = (int)((num3 * 523752859) ^ 0x65ADF0DF);
					continue;
				case 59u:
					val3 = (T2)null;
					num = (int)(num3 * 1178594488) ^ -22504601;
					continue;
				case 55u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 894582685u);
					num = ((int)num3 * -1294471450) ^ -318380419;
					continue;
				case 7u:
					return (void*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-365897715 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 923583266u));
				case 25u:
					ptr3->nameExportsTable = (IntPtr)val2;
					num = (int)((num3 * 1138585966) ^ 0x3D4AE14A);
					continue;
				case 32u:
					val2 = (T4)(nint)GCHandle.ToIntPtr(GCHandle.Alloc(val3));
					num = ((int)num3 * -972163460) ^ 0x2BFE3B4C;
					continue;
				case 54u:
					_fg((Error)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1771992492 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 4091378194u)));
					num = (int)((num3 * 2104114419) ^ 0x6E9E50BB);
					continue;
				case 26u:
					val = (T1)(val + global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x8096C0D ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3028540390u))));
					num = (int)((num3 * 1044264304) ^ 0x48F67E59);
					continue;
				case 10u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3383665009u);
					num = (int)((num3 * 25703507) ^ 0x446C0AD0);
					continue;
				case 21u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1844046602u);
					num = 1506705966;
					continue;
				case 40u:
					num = ((int)num3 * -1300900329) ^ 0x700668D5;
					continue;
				case 24u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1971530635u);
					num = -1291276821;
					continue;
				case 53u:
					_fg((Error)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x31BF3D54 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3838133501u))));
					num = 223633693;
					continue;
				case 28u:
					val3 = (T2)(((GCHandle*)(&val4))->Target as Dictionary<string, uint>);
					num = ((int)num3 * -662663193) ^ 0x581FCF82;
					continue;
				case 45u:
					value = (T1)(_Mj<T3, UIntPtr>((UIntPtr)P_1) - ptr->Base);
					num = (int)((num3 * 1978411925) ^ 0x34528714);
					continue;
				case 46u:
					ptr5 = (T1*)((byte*)codeBase + ptr->AddressOfNames);
					num = (int)(num3 * 1513994344) ^ -1919944498;
					continue;
				case 33u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3747311829u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 3400384611u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 4043634906u);
					val = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x44FE2607 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 707213358u)));
					num = 155208921;
					continue;
				case 34u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1668445516u);
					num = -2040346044;
					continue;
				case 60u:
					return (void*)(uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x4A04DEC5 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3046121288u)));
				case 3u:
				{
					int num20;
					int num21;
					if (ptr->NumberOfNames == 0)
					{
						num20 = 2098540050;
						num21 = num20;
					}
					else
					{
						num20 = 674210427;
						num21 = num20;
					}
					num = num20 ^ (int)(num3 * 1744063266);
					continue;
				}
				case 27u:
					return (void*)(uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-382493351 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1282648391u));
				case 8u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2975144559u);
					num = -431310294;
					continue;
				case 63u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1158002696u);
					num = 759589143;
					continue;
				case 36u:
					ptr3 = P_0;
					num = (int)(num3 * 1232788169) ^ -1319102912;
					continue;
				case 13u:
					codeBase = (T0*)ptr3->codeBase;
					num = (int)(num3 * 74789140) ^ -1752776457;
					continue;
				case 48u:
					return (void*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x32DDEC11 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3852489022u)));
				case 56u:
					ptr5 = (T1*)((byte*)ptr5 + global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x39DC1D7A ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1430719462u))));
					num = ((int)num3 * -559985251) ^ 0x6F445C44;
					continue;
				case 37u:
					_fg((Error)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x2FB23DF5 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3593884025u))));
					num = (int)((num3 * 1340883319) ^ 0x421AD2F6);
					continue;
				case 23u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2513434524u);
					num = (int)((num3 * 1403513608) ^ 0x89B74EA);
					continue;
				case 65u:
					num = ((int)num3 * -680278217) ^ 0x2476729;
					continue;
				case 52u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 417627777u);
					num = (int)(num3 * 646241257) ^ -1528578388;
					continue;
				case 50u:
					val = (T1)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x7022EAF5 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3664632536u)));
					num = (int)((num3 * 641608951) ^ 0x60E37B8D);
					continue;
				case 6u:
				{
					int num16;
					int num17;
					if (!_200F_200C_206A_200D_200D_206F_206F_200D_206F_202A_206F_206E_206A_206E_200D_202A_202C_200F_206D_202D_206A_200C_202D_206E_200C_202A_202C_200C_200B_202D_200C_200E_200D_206C_202B_206C_200B_202B_200D_202E_202E(ptr->NumberOfNames))
					{
						num16 = -1104622658;
						num17 = num16;
					}
					else
					{
						num16 = 2056753458;
						num17 = num16;
					}
					num = num16 ^ ((int)num3 * -1216571013);
					continue;
				}
				case 29u:
				{
					int num10;
					int num11;
					if (_Qh<T3, UIntPtr>((UIntPtr)P_1) != null)
					{
						num10 = -833207368;
						num11 = num10;
					}
					else
					{
						num10 = -548361208;
						num11 = num10;
					}
					num = num10 ^ ((int)num3 * -238130658);
					continue;
				}
				case 9u:
				{
					int num6;
					int num7;
					if ((nuint)(nint)_Mj<T3, UIntPtr>((UIntPtr)P_1) >= (nuint)(int)ptr->Base)
					{
						num6 = -886131807;
						num7 = num6;
					}
					else
					{
						num6 = 117157669;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -453170042);
					continue;
				}
				case 67u:
				{
					int num4;
					int num5;
					if ((nuint)(nint)val >= (nuint)(int)ptr->NumberOfNames)
					{
						num4 = 1735685483;
						num5 = num4;
					}
					else
					{
						num4 = -618703886;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1582312926);
					continue;
				}
				case 44u:
					return (void*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1037601954 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1765884767u));
				case 15u:
					return (void*)(uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x7F052A0B ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 855551797u)));
				default:
					return (byte*)codeBase + (uint)(*(int*)((byte*)codeBase + ptr->AddressOfFunctions + (nuint)(value * global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-970174582 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1274480965u)))));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T0 _hE<T0, T1>(T1 P_0, T1 P_1)
	{
		//IL_0095: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(466768743u);
		while (true)
		{
			int num = -1336489154;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~(~num2 * 449046083 - -562792358) + -(-300087127 * (-2023627768 + 166752884)) - 590078650) * 1480634291)) % 5)
				{
				case 2u:
					break;
				case 4u:
				{
					int num4;
					int num5;
					if (P_0 >= P_1)
					{
						num4 = -747736973;
						num5 = num4;
					}
					else
					{
						num4 = -1909039731;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1126378557);
					continue;
				}
				case 1u:
					return (T0)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x6510416B ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1488112921u)));
				case 0u:
					_fg((Error)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1641997110 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3920884218u)));
					num = (int)((num3 * 1489817595) ^ 0x6D513527);
					continue;
				default:
					return (T0)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x63DD171E ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2531876654u)));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void _ZK(POINTER_LIST* P_0, void* P_1, void* P_2)
	{
		CustomFreeFunc delegateForFunctionPointer = Marshal.GetDelegateForFunctionPointer<CustomFreeFunc>((IntPtr)P_1);
		while (true)
		{
			int num = 1642490664;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((-1996041566 - ((((-1797241199 - -446960441) ^ -160876183) - -(-1824900465 * -247479383) * 22976653) ^ (1841411447 * -(-2130370750 * -1002988383))) - (num2 ^ (465084543 * ((-(--717894786 - --2083850257 + (1620983930 + (-1037696088 - -1094640768))) ^ -1779070026) - -1343508407)))) ^ ~((-1536051912 - (-2131977214 - 1898776540) - ~(-252662894 + -264377552)) ^ (-(--65018105) - 21358941)) ^ (-(788013349 * (-1272227906 - -1785182277)) + -(~-1970760222 + 696122519))) - ((0x57E5E5D4 ^ 0x1D9C6338) + -800820780) - ~(~545259162))) % 3)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0115;
				case 0u:
					return;
				}
				break;
				IL_0115:
				_we(P_0, delegateForFunctionPointer, P_2);
				num = (int)((num3 * 498958770) ^ 0x5946F1E4);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static void _we(POINTER_LIST* P_0, CustomFreeFunc P_1, void* P_2)
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2774567844u);
		POINTER_LIST* ptr = default(POINTER_LIST*);
		while (true)
		{
			int num = 1586137586;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~(((num2 ^ ((0x19F58DA6 ^ ((893964625 * (1089580815 * 1719043677 + (-589323411 - 1837847190) - -(~-1475127012))) ^ 0x4BFCE1B2)) - (395891471 + (-(--875423486 + (-1537471411 + 1030932153) * -810635387) - (~(--196855441 + (0x181B04A6 ^ 0x77BDE355)) ^ (~(-208744796) ^ 0x26D01A68)))))) + (-(148312169 * (-579232430 - 214170599) * -400570215) ^ ~(0x180FC193 ^ -1951081152 ^ 0x51655629) ^ -(~(--73646384) + ~(0x196A99CE ^ 0x138BB736))) - -((0x666574E6 ^ 0x44572DBB) - --1218036636 + (223203673 * -1866137196 - ~-452160877) + -(0x4FEB9733 ^ 0x463CAC53))) ^ -(-(~(0x155E044E ^ -1300195360))))) + (0x7D06023D ^ -347353158))) % 9)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					ptr = P_0;
					num = ((int)num3 * -528317838) ^ -1195575407;
					continue;
				case 4u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2940418632u);
					num = (int)((num3 * 348554167) ^ 0x5648C468);
					continue;
				case 3u:
				{
					POINTER_LIST* next = ptr->next;
					_206E_206C_200D_200B_200D_206C_200F_202B_200F_206D_206D_202C_202A_202A_206D_206F_206F_200B_202E_200C_202D_200D_202A_206B_202E_200E_200C_200D_200C_206A_206C_202B_200C_200D_200C_206B_202C_200C_202B_206F_202E((void*)ptr);
					ptr = next;
					num = ((int)num3 * -641221430) ^ 0x704F8DC8;
					continue;
				}
				case 7u:
				{
					void* address = ptr->address;
					UIntPtr size = (UIntPtr)(ulong)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1002882142 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1561204803u));
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 4191666058u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 471027273u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 357812534u);
					P_1(address, size, (MemoryAllocation)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x701D6B26 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 1587924298u))), P_2);
					num = ((int)num3 * -676474586) ^ -962323993;
					continue;
				}
				case 8u:
					num = ((int)num3 * -318023976) ^ 0x5C99AF6A;
					continue;
				case 5u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2456931310u);
					num = -122311762;
					continue;
				case 6u:
				{
					POINTER_LIST* intPtr = ptr;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1092441610u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 2707042998u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 4191666058u);
					int num4;
					if (intPtr == (POINTER_LIST*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-79594655 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3937154762u)))
					{
						num = 585780799;
						num4 = num;
					}
					else
					{
						num = 592731018;
						num4 = num;
					}
					continue;
				}
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static _IMAGE_SECTION_HEADER* _pK<T0, T1>(T1 P_0)
	{
		//IL_0035: Expected O, but got I
		//IL_0041: Expected I, but got O
		//IL_0047: Expected I, but got O
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3815216213u);
		return (_IMAGE_SECTION_HEADER*)(void*)UIntPtr.Add(UIntPtr.Add((nuint)(nint)P_0, Unsafe.As<T0, IntPtr>(ref (T0)(nint)_200E_206A_206B_200E_206A_202A_206C_200F_202C_206B_202D_200B_202D_206A_206D_206B_200F_202D_200E_206A_206C_202E_200F_202B_200C_202E_202B_200C_206B_206A_200E_202D_206E_200B_206C_200B_202D_206D_202E_200C_202E((Type)_206A_202B_200F_202A_206C_202E_206F_206D_206E_206E_206E_206E_200C_200B_202E_200B_206F_206B_200D_202E_206A_202C_202D_202D_200E_200F_206A_200E_206B_206F_202D_206F_206B_206A_202D_206D_200E_200C_206D_202E_202E(typeof(_IMAGE_NT_HEADERS).TypeHandle), global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<string>(-446905410 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 4034401567u)))).ToInt32()), ((_IMAGE_NT_HEADERS*)(void*)(UIntPtr)(nuint)(nint)P_0)->FileHeader.SizeOfOptionalHeader);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static _IMAGE_DATA_DIRECTORY* _Pf(_MEMORYMODULE* P_0, ImageDirectoryEntry P_1)
	{
		return (_IMAGE_DATA_DIRECTORY*)((byte*)(&P_0->headers->OptionalHeader.DataDirectory) + (nint)P_1 * (nint)sizeof(_IMAGE_DATA_DIRECTORY));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T0 _A<T0, T1>(T1 P_0)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I8
		//IL_0042: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1386303921u);
		return (T0)((P_0 & global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<long>(-1518498161 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 78120068u))) > (long)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1097830447 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 967895438u)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T0 _Do<T0, T1>(T1 P_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I8
		//IL_0044: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2004616264u);
		return (T0)((long)(P_0 & (uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-534357771 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 4016228019u))) > (long)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x46757D7F ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1247623530u))));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static T0 _uj<T0, T1, T2>(T1 P_0)
	{
		//IL_0148: Expected O, but got I8
		//IL_0128: Expected O, but got I8
		if (_206F_202A_202A_206E_206A_200C_200E_206B_200D_206D_200F_202C_206C_200D_200D_200D_206C_202A_202A_206A_200E_206D_206C_206D_200F_202B_200D_202C_206D_202D_202D_202C_202E_206B_200B_206C_202B_202D_206E_202E_202E())
		{
			while (true)
			{
				int num = 483100538;
				uint num2;
				switch ((num2 = (uint)(((-(-(((num ^ (700786290 - (1661130259 + (-(~189859270) - -161470851 * -805944077) - (((-1027430918 * -1864365325) ^ ((0x684DC7DC ^ -399502798) + --1704623054)) + (0x45A1A88 ^ 0x27F72FDF))) + (-(-(1917109079 - -922373531 - -1738620006)) + (1336489455 * (1167972066 - 1605245009 + 661290858 * 869028011) + 864773902 * 1181157849) - ~((~(--1668883227) ^ -1302323011) * -642362557)))) - -(~(0x7FE57969 ^ -1128428758))) * 1696801803)) * 190531817) ^ -1403610820) - 837596959)) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return _A<T0, T2>((T2)((UIntPtr*)(&P_0))->ToUInt64());
				}
				break;
			}
		}
		return _Do<T0, T2>((T2)((UIntPtr*)(&P_0))->ToUInt32());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T0 _Cm<T0>(T0 P_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		return (T0)(P_0 & global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1421030485 ^ (int)new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1720571410u)._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1834206395u)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T0 _1L<T0>(T0 P_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		return (T0)(P_0 & global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x74E6A9EF ^ new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3931342422u)._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 527116917u))));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static T0 _CA<T0, T1, T2>(T0 P_0)
	{
		//IL_0164: Expected O, but got I4
		//IL_0169: Expected I4, but got O
		//IL_016a: Expected O, but got I
		//IL_0140: Expected O, but got I8
		//IL_0145: Expected I8, but got O
		//IL_0146: Expected O, but got I
		if (_206F_202A_202A_206E_206A_200C_200E_206B_200D_206D_200F_202C_206C_200D_200D_200D_206C_202A_202A_206A_200E_206D_206C_206D_200F_202B_200D_202C_206D_202D_202D_202C_202E_206B_200B_206C_202B_202D_206E_202E_202E())
		{
			while (true)
			{
				int num = -1809083850;
				uint num2;
				switch ((num2 = (uint)(~(((num + ((0x24764115 ^ -450278797) + ((0x30C7E35B ^ 0x56AA1C62) * 1152480919 - --819151711 - ((--1742712060 - (-1873923214 - -1855264231)) ^ 0x135CEFDC) + 1313652355 * -911716954) - (1824570519 + (241093809 - (~(1352539352 - -1017741556) - -1650289136 * -20935045 * 1729634529 + (-661876604 - (-1059201285 - 1237066882)) * 473188653))))) ^ (-(0x7E57F498 ^ 0x25FDBFAF) ^ ~(~(-(-103748281 * (-206374174 * 1281861827)))))) * -1277699253 * 709099357))) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return (T0)(nuint)(UIntPtr)(ulong)(long)_Cm((T1)((UIntPtr*)(&P_0))->ToUInt64());
				}
				break;
			}
		}
		return (T0)(nuint)(UIntPtr)(uint)(int)_1L((T2)((UIntPtr*)(&P_0))->ToUInt32());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T0 _Qh<T0, T1>(T1 P_0)
	{
		//IL_0012: Expected I, but got O
		//IL_0047: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3283576587u);
		return (T0)(ushort)((long)((ulong)(UIntPtr)(nuint)(nint)P_0 >> global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x1571FB76 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 662565877u)))) & (long)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x3989AFE5 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3082069063u))));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T0 _Mj<T0, T1>(T1 P_0)
	{
		//IL_0012: Expected I, but got O
		//IL_002e: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3448450054u);
		return (T0)(ushort)((long)(ulong)(UIntPtr)(nuint)(nint)P_0 & (long)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x494052FB ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3774777533u))));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static T0 _Jh<T0>(T0 P_0, T0 P_1)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(463370165u);
		return (T0)(((object)P_0 + (object)P_1 - global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1851412691 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2330495537u))) & ~(P_1 - global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-782277315 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 755646754u))));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void* _DD<T0>(void* P_0, T0 P_1)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected I, but got Unknown
		return (void*)(nint)(P_0 + P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T0 _Eb<T0>(T0 P_0, T0 P_1)
	{
		//IL_003c: Expected O, but got I
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(98438044u);
		return (T0)(nuint)(UIntPtr)(((UIntPtr*)(&P_0))->ToUInt64() & (ulong)(~((long)((UIntPtr*)(&P_1))->ToUInt64() - (long)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x648802D5 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3277743758u))))));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private unsafe static void* _uh<T0>(void* P_0, T0 P_1)
	{
		//IL_000c: Expected O, but got I
		//IL_0011: Expected I, but got O
		return (void*)(UIntPtr)(nuint)(nint)_Eb((T0)(nuint)(UIntPtr)P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T3 _Hj<T0, T1, T2, T3, T4, T5, T6>(T1* P_0, T4 P_1, _IMAGE_NT_HEADERS* P_2, _MEMORYMODULE* P_3)
	{
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_072d: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		//IL_0261: Expected I4, but got O
		//IL_03f0: Expected O, but got I4
		//IL_02b5: Expected O, but got I
		//IL_06d9: Expected O, but got I
		//IL_040f: Expected O, but got I4
		//IL_01fa: Expected O, but got I
		//IL_067e: Expected O, but got I8
		//IL_062f: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_06b6: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2797375273u);
		T0 val2 = default(T0);
		T0 val = default(T0);
		_IMAGE_SECTION_HEADER* ptr = default(_IMAGE_SECTION_HEADER*);
		MEMORYMODULE mEMORYMODULE = default(MEMORYMODULE);
		T1* ptr2 = default(T1*);
		T1* codeBase = default(T1*);
		while (true)
		{
			int num = -1233517558;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~((num2 + -(1139268812 - (-(-1974381789 * (-2091844235 + -1369863887)) + (0x69361528 ^ -686624483)) - ((-462984551 ^ --402288894) * 1990268289 - ~(-329601900)) * -203229061)) * -786272753)))) % 34)
				{
				case 28u:
					break;
				case 32u:
					num = (int)(num3 * 604891464) ^ -1181505037;
					continue;
				case 2u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2223856099u);
					num = 1272698654;
					continue;
				case 24u:
				{
					T0 val3 = val2;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1808785079u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 293231959u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3087396457u);
					int num13;
					int num14;
					if ((nint)val3 > global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x38EE08A7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1847523063u))))
					{
						num13 = 53783553;
						num14 = num13;
					}
					else
					{
						num13 = 1356275857;
						num14 = num13;
					}
					num = num13 ^ (int)(num3 * 1104631417);
					continue;
				}
				case 3u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 1104318177u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3651593055u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 690752965u);
					val = (T0)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x196FD9A7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 784972865u)));
					num = (int)(num3 * 1312356471) ^ -1518057082;
					continue;
				case 21u:
					ptr = _pK<T5, T2>((T2)(nuint)(UIntPtr)mEMORYMODULE.headers);
					num = ((int)num3 * -376991327) ^ -49923683;
					continue;
				case 15u:
					ptr2 = (T1*)((byte*)codeBase + ptr->VirtualAddress);
					num = 2134109208;
					continue;
				case 10u:
				{
					T1* intPtr = ptr2;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 4039261495u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1235982893u);
					_206A_206E_206E_202E_206F_200F_206E_200E_202C_206B_202E_200D_200C_202D_200E_206D_202B_206D_202C_202C_206C_202D_202A_206E_200D_206D_206F_206B_202D_202C_202B_200C_202E_206A_200D_206B_202D_206C_206C_200D_202E((void*)intPtr, global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1447376217 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3220825248u)), (uint)(int)val2);
					num = (int)(num3 * 2012781987) ^ -1376215336;
					continue;
				}
				case 29u:
				{
					int num8;
					int num9;
					if ((nint)val < (int)mEMORYMODULE.headers->FileHeader.NumberOfSections)
					{
						num8 = 1624699278;
						num9 = num8;
					}
					else
					{
						num8 = -1490059862;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -1715512172);
					continue;
				}
				case 14u:
				{
					__anontype_1639d593_0036* misc = &ptr->Misc;
					ulong num10 = Unsafe.As<T2, UIntPtr>(ref (T2)(nuint)(UIntPtr)ptr2).ToUInt64();
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1971255266u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1847523063u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 293231959u);
					misc->PhysicalAddress = (uint)(num10 & (uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x7BA5164 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 210744743u))));
					num = ((int)num3 * -1788038195) ^ 0x2B6ED823;
					continue;
				}
				case 31u:
					return (T3)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x6142FC1 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 696090630u)));
				case 17u:
					mEMORYMODULE = (MEMORYMODULE)_206F_206F_202C_206B_200F_200B_200D_206C_200F_202E_200B_200C_200E_200C_206E_206F_202B_206F_206C_202B_200F_202A_200D_206B_200F_200D_202E_200B_206E_200F_206A_206E_200D_200C_202C_202B_202B_200F_206C_206C_202E(P_3);
					num = ((int)num3 * -1734326332) ^ 0xC30A150;
					continue;
				case 20u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3479911886u);
					num = 291000438;
					continue;
				case 30u:
					return (T3)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x5965FD47 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 4212210886u)));
				case 23u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2977172127u);
					num = -1332981719;
					continue;
				case 8u:
					ptr++;
					num = (int)((num3 * 750753477) ^ 0x416C9D01);
					continue;
				case 11u:
					val2 = (T0)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x43905BA6 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3684526592u)));
					num = ((int)num3 * -231461905) ^ -148720241;
					continue;
				case 19u:
					val2 = (T0)P_2->OptionalHeader.SectionAlignment;
					num = ((int)num3 * -1901457319) ^ 0x65A8A2E8;
					continue;
				case 0u:
					val = (T0)(val + global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-580919679 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 345607810u)));
					num = (int)(num3 * 459726080) ^ -358742597;
					continue;
				case 5u:
				{
					int num15;
					int num16;
					if (ptr2 == (T1*)(uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x4D08ABDB ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1074142048u))))
					{
						num15 = -939193050;
						num16 = num15;
					}
					else
					{
						num15 = 533711962;
						num16 = num15;
					}
					num = num15 ^ (int)(num3 * 966414299);
					continue;
				}
				case 22u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(611177672u);
					num = -402602641;
					continue;
				case 7u:
					num = (int)(num3 * 1870518662) ^ -1768534641;
					continue;
				case 12u:
					ptr2 = (T1*)mEMORYMODULE.alloc((byte*)codeBase + ptr->VirtualAddress, (UIntPtr)ptr->SizeOfRawData, (MemoryAllocation)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x64F72E78 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 652795615u))), (PageProtection)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x5C0DA897 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 867378147u))), mEMORYMODULE.userdata);
					num = 1186622589;
					continue;
				case 13u:
					_202D_206A_202C_202A_206F_206B_200F_200E_206A_206B_206B_206D_206F_200F_206B_202E_206B_202B_200E_202A_206F_200C_206B_200F_206C_206D_202D_206F_202B_200B_200C_202A_200D_202C_202C_200D_206E_200E_200D_206B_202E((void*)ptr2, (void*)((byte*)P_0 + ptr->PointerToRawData), ptr->SizeOfRawData);
					num = ((int)num3 * -386353319) ^ 0x53F14D1E;
					continue;
				case 9u:
					codeBase = (T1*)mEMORYMODULE.codeBase;
					num = ((int)num3 * -1010297081) ^ -1193195835;
					continue;
				case 4u:
				{
					int num11;
					int num12;
					if (ptr2 != (T1*)(uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-272459035 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 755108534u)))
					{
						num11 = -177432522;
						num12 = num11;
					}
					else
					{
						num11 = -2071844844;
						num12 = num11;
					}
					num = num11 ^ ((int)num3 * -27504737);
					continue;
				}
				case 26u:
					ptr2 = (T1*)((byte*)codeBase + ptr->VirtualAddress);
					num = 440097821;
					continue;
				case 18u:
					ptr2 = (T1*)mEMORYMODULE.alloc((byte*)codeBase + ptr->VirtualAddress, (UIntPtr)(ulong)(long)val2, (MemoryAllocation)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-949710141 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 4039261495u)), (PageProtection)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-960069272 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2693037463u)), mEMORYMODULE.userdata);
					num = (int)((num3 * 516705044) ^ 0x26EA6C4C);
					continue;
				case 27u:
					return (T3)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x164E5804 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 296760906u)));
				case 6u:
				{
					int num6;
					int num7;
					if (ptr->SizeOfRawData == 0)
					{
						num6 = 2023303996;
						num7 = num6;
					}
					else
					{
						num6 = 1269028621;
						num7 = num6;
					}
					num = num6 ^ (int)(num3 * 1270653077);
					continue;
				}
				case 25u:
				{
					int num4;
					int num5;
					if (_hE<T3, T4>(P_1, (T4)(ptr->PointerToRawData + ptr->SizeOfRawData)) != null)
					{
						num4 = 1723098609;
						num5 = num4;
					}
					else
					{
						num4 = 650933330;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -122477438);
					continue;
				}
				case 33u:
					val = (T0)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x25211346 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2338661318u)));
					num = ((int)num3 * -1215363741) ^ -1478540729;
					continue;
				case 16u:
					ptr->Misc.PhysicalAddress = (uint)(Unsafe.As<T2, UIntPtr>(ref (T2)(nuint)(UIntPtr)ptr2).ToUInt64() & (uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x64647054 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3912230842u))));
					num = (int)(num3 * 1349073253) ^ -1441045291;
					continue;
				default:
					return (T3)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x38891947 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 4049021947u)));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T5 _Ee<T0, T1, T2, T3, T4, T5>(_MEMORYMODULE* P_0, T4 P_1)
	{
		//IL_04de: Expected O, but got I4
		//IL_0362: Expected O, but got I4
		//IL_055d: Expected I4, but got O
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected I8, but got Unknown
		//IL_019c: Expected O, but got I4
		//IL_0124: Expected O, but got I4
		//IL_087d: Unknown result type (might be due to invalid IL or missing references)
		//IL_087f: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected I, but got Unknown
		//IL_06c4: Expected O, but got I4
		//IL_03da: Expected O, but got I4
		//IL_08a2: Expected O, but got I4
		//IL_040c: Expected O, but got I4
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected I, but got Unknown
		//IL_0736: Expected I4, but got O
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2205086972u);
		T1 val = default(T1);
		ImageRelocation imageRelocation = default(ImageRelocation);
		T3 val2 = default(T3);
		T2* ptr3 = default(T2*);
		T4* ptr4 = default(T4*);
		_IMAGE_BASE_RELOCATION* ptr2 = default(_IMAGE_BASE_RELOCATION*);
		T0* ptr5 = default(T0*);
		T3 val3 = default(T3);
		T0* codeBase = default(T0*);
		_IMAGE_DATA_DIRECTORY* ptr = default(_IMAGE_DATA_DIRECTORY*);
		T1* ptr6 = default(T1*);
		while (true)
		{
			int num = -173698153;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(--743032405) - (-(~(~num2) * 34559397) ^ -(124779399 * -584491432)))) % 50)
				{
				case 25u:
					break;
				case 17u:
					val = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-2064572192 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3370600288u));
					num = -514164515;
					continue;
				case 4u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(223729279u);
					num = -664746611;
					continue;
				case 19u:
				{
					int num6;
					int num7;
					if (imageRelocation == (ImageRelocation)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1307109280 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1986313055u)))
					{
						num6 = -1613237473;
						num7 = num6;
					}
					else
					{
						num6 = 765867653;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -1999536377);
					continue;
				}
				case 16u:
					val2 = (T3)(*(ushort*)ptr3 >> global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1237406465 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1115639315u)));
					num = 1365451726;
					continue;
				case 12u:
				{
					T4* intPtr = ptr4;
					*(long*)intPtr = *(long*)intPtr + P_1;
					num = ((int)num3 * -1252878452) ^ 0x22232629;
					continue;
				}
				case 11u:
					ptr3 = (T2*)((byte*)ptr3 + global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1441405852 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2628786328u)));
					num = ((int)num3 * -1115828288) ^ 0x148D6000;
					continue;
				case 15u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(132, 3665558397u);
					num = (int)(num3 * 862204213) ^ -1070684522;
					continue;
				case 6u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(131, 647244637u);
					num = (int)(num3 * 597285742) ^ -1974519899;
					continue;
				case 21u:
				{
					uint virtualAddress = ptr2->VirtualAddress;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1854958130u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 19513710u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3334031282u);
					int num11;
					if (virtualAddress <= (uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1208514752 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 2251294226u)))
					{
						num = 1452649633;
						num11 = num;
					}
					else
					{
						num = 1304216704;
						num11 = num;
					}
					continue;
				}
				case 40u:
					ptr4 = (T4*)(nint)(ptr5 + val3);
					num = ((int)num3 * -1382298345) ^ 0x3364A78D;
					continue;
				case 18u:
					ptr5 = (T0*)((byte*)codeBase + ptr2->VirtualAddress);
					num = ((int)num3 * -790151607) ^ -479301292;
					continue;
				case 27u:
				{
					int num8;
					if ((nuint)(nint)val >= (nuint)(int)((uint)((int)ptr2->SizeOfBlock - global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-400169294 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 414816677u))) / (uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x6E959288 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 4268727863u)))))
					{
						num = 1384313488;
						num8 = num;
					}
					else
					{
						num = -1539542459;
						num8 = num;
					}
					continue;
				}
				case 1u:
				{
					ushort num16 = *(ushort*)ptr3;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3804024556u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3880150619u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 547408060u);
					val3 = (T3)(num16 & global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-2145739252 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 0u)));
					num = (int)(num3 * 1620866929) ^ -405998891;
					continue;
				}
				case 9u:
					num = ((int)num3 * -163325186) ^ 0x577DED45;
					continue;
				case 35u:
				{
					int num14;
					int num15;
					if (ptr->Size != 0)
					{
						num14 = 637416981;
						num15 = num14;
					}
					else
					{
						num14 = 527010411;
						num15 = num14;
					}
					num = num14 ^ (int)(num3 * 1279794496);
					continue;
				}
				case 49u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1947825885u);
					num = (int)((num3 * 87286236) ^ 0x9AAAF78);
					continue;
				case 32u:
					ptr2 = (_IMAGE_BASE_RELOCATION*)_DD(ptr2, (T3)ptr2->SizeOfBlock);
					num = ((int)num3 * -1564000311) ^ 0x79BB23B6;
					continue;
				case 39u:
					ptr3 = (T2*)_DD(ptr2, (T3)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-616432909 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3501330186u)));
					num = (int)((num3 * 771016754) ^ 0x553B4C87);
					continue;
				case 7u:
					num = ((int)num3 * -904651716) ^ 0x2B20E612;
					continue;
				case 28u:
					ptr6 = (T1*)(nint)(ptr5 + val3);
					num = (int)(num3 * 872688841) ^ -432663977;
					continue;
				case 44u:
					num = ((int)num3 * -1955413578) ^ -1831347757;
					continue;
				case 14u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(852732125u);
					num = 945525196;
					continue;
				case 3u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(130, 512867517u);
					num = ((int)num3 * -321367648) ^ -1181166365;
					continue;
				case 0u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 536108284u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1973146886u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 168703464u);
					val = (T1)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x66985779 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 1913681904u)));
					num = (int)(num3 * 970537310) ^ -250422116;
					continue;
				case 36u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(133, 354058781u);
					num = ((int)num3 * -1329150235) ^ 0x30429A22;
					continue;
				case 10u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 1105215729u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1774802255u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2676108207u);
					_202D_206B_200B_200B_200D_206B_200D_202B_202B_202A_202A_202E_206C_202E_202B_202C_206A_200E_206B_202B_200E_206F_200E_202B_202E_200C_200C_200F_200D_200D_200C_206A_202C_206A_200C_206B_202E_202E_200F_202E(_200E_200E_206E_202B_202D_202C_206D_202E_202C_202A_200C_200C_206F_200D_200D_200E_200C_206E_206D_206E_200C_206C_206B_202A_200D_202D_206B_200B_200C_206C_200B_206A_206A_202C_206B_206E_200B_200B_202E_200F_202E(global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<string>(-1799483349 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 45438447u)), (object)(ImageRelocation)val2));
					num = 732226763;
					continue;
				case 2u:
					codeBase = (T0*)P_0->codeBase;
					num = ((int)num3 * -1420462743) ^ 0x73F049CC;
					continue;
				case 23u:
					ptr2 = default(_IMAGE_BASE_RELOCATION*);
					num = (int)((num3 * 944740078) ^ 0x4E10F647);
					continue;
				case 20u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1947825885u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3598483581u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 4229594691u);
					_202D_206B_200B_200B_200D_206B_200D_202B_202B_202A_202A_202E_206C_202E_202B_202C_206A_200E_206B_202B_200E_206F_200E_202B_202E_200C_200C_200F_200D_200D_200C_206A_202C_206A_200C_206B_202E_202E_200F_202E(global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<string>(-626454113 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2556918557u)));
					num = -640714146;
					continue;
				case 31u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1988295408u);
					num = ((int)num3 * -1812377139) ^ -71371141;
					continue;
				case 22u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 4229594691u);
					num = (int)((num3 * 2015677794) ^ 0x57D16851);
					continue;
				case 41u:
					num = (int)(num3 * 53600138) ^ -980776105;
					continue;
				case 5u:
				{
					int num12;
					int num13;
					if (imageRelocation == (ImageRelocation)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1843601011 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 584306991u)))
					{
						num12 = 1598567628;
						num13 = num12;
					}
					else
					{
						num12 = 1620602297;
						num13 = num12;
					}
					num = num12 ^ ((int)num3 * -571576277);
					continue;
				}
				case 13u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2556918557u);
					num = (int)((num3 * 1532856577) ^ 0xB6BBE06);
					continue;
				case 29u:
					return (T5)((long)P_1 == global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x48B177B7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2274676065u))));
				case 48u:
					*(int*)ptr6 += (int)(uint)P_1;
					num = ((int)num3 * -1495993650) ^ -713754063;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (imageRelocation != ImageRelocation.BasedAbsolute)
					{
						num9 = -1614272982;
						num10 = num9;
					}
					else
					{
						num9 = 857458425;
						num10 = num9;
					}
					num = num9 ^ (int)(num3 * 2035320897);
					continue;
				}
				case 46u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1410897519u);
					num = (int)(num3 * 239997667) ^ -294240787;
					continue;
				case 47u:
					imageRelocation = (ImageRelocation)val2;
					num = (int)((num3 * 687273735) ^ 0x20FF43FA);
					continue;
				case 43u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2907277122u);
					num = 2112452295;
					continue;
				case 42u:
					num = ((int)num3 * -750245377) ^ -1871616149;
					continue;
				case 45u:
					num = (int)((num3 * 397784342) ^ 0x3643DD0A);
					continue;
				case 37u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3598483581u);
					num = ((int)num3 * -93624280) ^ 0x22F09FEA;
					continue;
				case 30u:
				{
					int num4;
					int num5;
					if (!_206F_202A_202A_206E_206A_200C_200E_206B_200D_206D_200F_202C_206C_200D_200D_200D_206C_202A_202A_206A_200E_206D_206C_206D_200F_202B_200D_202C_206D_202D_202D_202C_202E_206B_200B_206C_202B_202D_206E_202E_202E())
					{
						num4 = -525851873;
						num5 = num4;
					}
					else
					{
						num4 = -562931000;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -750549315);
					continue;
				}
				case 24u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2823805035u);
					num = (int)((num3 * 298202076) ^ 0x6769C9BC);
					continue;
				case 33u:
					ptr2 = (_IMAGE_BASE_RELOCATION*)((byte*)codeBase + ptr->VirtualAddress);
					num = ((int)num3 * -636953785) ^ -458229079;
					continue;
				case 38u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 3721578769u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2231425271u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 4113044783u);
					ptr = _Pf(P_0, (ImageDirectoryEntry)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x629699F ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 2546241207u))));
					num = (int)((num3 * 423001198) ^ 0x425B2136);
					continue;
				case 26u:
					val = (T1)(val + global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1129475445 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3804024556u)));
					num = -2096835654;
					continue;
				default:
					return (T5)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x6082E912 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1758803230u)));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T1 _BE<T0, T1, T2, T3, T4, T5, T6, T7>(_MEMORYMODULE* P_0)
	{
		//IL_0486: Expected O, but got I
		//IL_094f: Expected O, but got I4
		//IL_077e: Expected O, but got I4
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected I4, but got Unknown
		//IL_0748: Expected O, but got I4
		//IL_065d: Expected O, but got I4
		//IL_07d5: Expected O, but got I4
		//IL_052f: Expected O, but got I
		//IL_0534: Expected I, but got O
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(625178500u);
		void** ptr7 = default(void**);
		void** ptr4 = default(void**);
		T0* codeBase = default(T0*);
		_IMAGE_IMPORT_DESCRIPTOR* ptr = default(_IMAGE_IMPORT_DESCRIPTOR*);
		T2* ptr3 = default(T2*);
		void* ptr5 = default(void*);
		_IMAGE_DATA_DIRECTORY* ptr2 = default(_IMAGE_DATA_DIRECTORY*);
		_IMAGE_IMPORT_BY_NAME* ptr6 = default(_IMAGE_IMPORT_BY_NAME*);
		MEMORYMODULE mEMORYMODULE = default(MEMORYMODULE);
		T3* ptr8 = default(T3*);
		T1 val = default(T1);
		while (true)
		{
			int num = 486503717;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((num2 - ((-(-(~(-164990759 * (-192366575 ^ -2009668574)))) * 1812901831) ^ (-((-1419114985 ^ -1059222844) * -2018067509 - 1316789552) + ~(-(~(-1673622821 + 901874959)) * -1853166569))) - (0x399FF14E ^ -1568727170)) * 1074040201) ^ -(-1082130495 ^ -1685380728))) % 73)
				{
				case 6u:
					break;
				case 45u:
				{
					int num17;
					int num18;
					if (ptr7 != (void**)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x5B3FCAF2 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3115257216u))))
					{
						num17 = 1442697719;
						num18 = num17;
					}
					else
					{
						num17 = -269120290;
						num18 = num17;
					}
					num = num17 ^ ((int)num3 * -86673409);
					continue;
				}
				case 25u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2174309494u);
					num = -932504994;
					continue;
				case 61u:
					ptr4 = (void**)((byte*)codeBase + ptr->FirstThunk);
					num = ((int)num3 * -1399880320) ^ -109823717;
					continue;
				case 34u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 2822431675u);
					num = 938573725;
					continue;
				case 16u:
					ptr4 = (void**)((byte*)codeBase + ptr->FirstThunk);
					num = ((int)num3 * -1707795023) ^ 0x4B088AF3;
					continue;
				case 63u:
					ptr3 = (T2*)default(UIntPtr*);
					num = -320911860;
					continue;
				case 50u:
					ptr3++;
					num = ((int)num3 * -2021562916) ^ 0x577271A3;
					continue;
				case 55u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 2146442814u);
					num = 2077598847;
					continue;
				case 52u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3801042685u);
					num = -856296787;
					continue;
				case 44u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(137, 864554863u);
					num = ((int)num3 * -1300766737) ^ -1829810012;
					continue;
				case 68u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(136, 2934403215u);
					num = 2088050306;
					continue;
				case 36u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(135, 2773631279u);
					num = ((int)num3 * -1838355448) ^ 0x7C4E0EAE;
					continue;
				case 38u:
					num = ((int)num3 * -1851187060) ^ -932240049;
					continue;
				case 28u:
				{
					int num13;
					int num14;
					if (ptr->OriginalFirstThunk != 0)
					{
						num13 = -825777936;
						num14 = num13;
					}
					else
					{
						num13 = 1763309703;
						num14 = num13;
					}
					num = num13 ^ (int)(num3 * 1407086636);
					continue;
				}
				case 43u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3016146838u);
					num = 1763316000;
					continue;
				case 3u:
				{
					void* intPtr = ptr5;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 1597411540u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3322417441u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2101368812u);
					int num8;
					int num9;
					if (intPtr != (void*)(uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-823841085 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3173201772u)))
					{
						num8 = -1999356964;
						num9 = num8;
					}
					else
					{
						num8 = 1910648255;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -1602300005);
					continue;
				}
				case 22u:
					P_0->modules = ptr7;
					num = 1770580870;
					continue;
				case 64u:
					ptr = (_IMAGE_IMPORT_DESCRIPTOR*)((byte*)codeBase + ptr2->VirtualAddress);
					num = (int)((num3 * 586631303) ^ 0x6F09F017);
					continue;
				case 20u:
				{
					int num21;
					int num22;
					if (*(UIntPtr*)ptr3 != UIntPtr.Zero)
					{
						num21 = -64195423;
						num22 = num21;
					}
					else
					{
						num21 = 1276358807;
						num22 = num21;
					}
					num = num21 ^ (int)(num3 * 342171820);
					continue;
				}
				case 72u:
					ptr6 = (_IMAGE_IMPORT_BY_NAME*)((byte*)codeBase + ((UIntPtr*)ptr3)->ToUInt64());
					num = ((int)num3 * -1931498179) ^ 0x6A7EB88F;
					continue;
				case 70u:
					ptr = default(_IMAGE_IMPORT_DESCRIPTOR*);
					num = ((int)num3 * -928774973) ^ -1335216442;
					continue;
				case 14u:
				{
					int num19;
					int num20;
					if (_uj<T1, T2, T7>((T2)(*(nint*)ptr3)) == null)
					{
						num19 = 1978149726;
						num20 = num19;
					}
					else
					{
						num19 = 2124883766;
						num20 = num19;
					}
					num = num19 ^ (int)(num3 * 1200017233);
					continue;
				}
				case 59u:
				{
					int num15;
					int num16;
					if (!_200C_200E_202D_200B_202D_206E_206D_206C_200C_200F_202D_206C_200F_202D_206A_202B_206D_202A_200D_200C_206C_206E_202B_202A_206A_206C_202B_206C_206D_202D_200E_200C_200C_206A_202C_200B_202A_202A_202E_202C_202E(_Mb(ptr, (uint)sizeof(_IMAGE_IMPORT_DESCRIPTOR))))
					{
						num15 = -2094463524;
						num16 = num15;
					}
					else
					{
						num15 = 753205691;
						num16 = num15;
					}
					num = num15 ^ ((int)num3 * -1938519883);
					continue;
				}
				case 26u:
					mEMORYMODULE.freeLibrary(ptr5, P_0->userdata);
					num = ((int)num3 * -1546022225) ^ 0x56A2FC17;
					continue;
				case 56u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 1987858142u);
					num = (int)((num3 * 627846924) ^ 0x5DFC8852);
					continue;
				case 69u:
					*ptr4 = mEMORYMODULE.getProcAddress(ptr5, (char*)(void*)(UIntPtr)(nuint)(nint)_CA<T2, T7, T5>((T2)(*(nint*)ptr3)), P_0->userdata);
					num = ((int)num3 * -918214101) ^ -563722891;
					continue;
				case 5u:
					ptr5 = mEMORYMODULE.loadLibrary((char*)ptr8, P_0->userdata);
					num = (int)((num3 * 576664104) ^ 0x125703C8);
					continue;
				case 71u:
					ptr4 = default(void**);
					num = ((int)num3 * -1211907918) ^ 0x292E488D;
					continue;
				case 2u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3724717506u);
					num = -1440494611;
					continue;
				case 47u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3012329467u);
					num = 452947492;
					continue;
				case 35u:
					throw _206D_200D_200F_206E_200C_202D_202C_206F_206D_206C_206F_206A_200E_200F_200D_206E_206F_200D_202C_206D_202A_206C_206C_202D_200E_206B_202D_206B_206E_202E_202B_200C_206B_206E_206E_202A_200F_206E_200C_206B_202E(_206C_202B_206F_206C_202D_200F_206A_200D_202A_206C_200F_200B_200B_200D_200C_206B_206B_200C_202C_202B_206D_200D_206A_202C_200F_202E_202C_202B_206E_200C_202B_206B_200B_202B_202D_202E_206C_202B_202E_202E(global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<string>(-863046855 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3754404202u)), _206B_202B_202D_206A_206E_206F_206A_200D_202B_206D_200E_200C_202E_206A_202C_202D_200B_206D_206B_200E_200E_206D_200B_202A_202D_206B_200B_206C_206E_206E_206D_206E_202A_200B_206B_206C_200E_200E_206B_202E_202E((IntPtr)ptr8)));
				case 1u:
					num = (int)((num3 * 306432774) ^ 0x6BA5C627);
					continue;
				case 48u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 4015560083u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 713668543u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1246693559u);
					val = (T1)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-2129986613 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 445022006u));
					num = ((int)num3 * -1674612086) ^ 0x102B2D31;
					continue;
				case 49u:
				{
					int num11;
					int num12;
					if (ptr->Name == 0)
					{
						num11 = -973300812;
						num12 = num11;
					}
					else
					{
						num11 = 190999912;
						num12 = num11;
					}
					num = num11 ^ ((int)num3 * -1664680751);
					continue;
				}
				case 12u:
					ptr7 = default(void**);
					num = ((int)num3 * -368497859) ^ -803769843;
					continue;
				case 58u:
					mEMORYMODULE.freeLibrary(ptr5, P_0->userdata);
					num = ((int)num3 * -848327450) ^ 0xF2F2A48;
					continue;
				case 31u:
					ptr8 = (T3*)((byte*)codeBase + ptr->Name);
					num = (int)((num3 * 140563080) ^ 0x4F2FAB23);
					continue;
				case 53u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2174309494u);
					num = ((int)num3 * -16616582) ^ -119947437;
					continue;
				case 37u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3916208907u);
					num = 736675581;
					continue;
				case 46u:
					return (T1)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1993765825 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1755635069u));
				case 13u:
					num = ((int)num3 * -1796968896) ^ -499476871;
					continue;
				case 30u:
				{
					void** modules = P_0->modules;
					int* numModules = &P_0->numModules;
					T4 val2 = (T4)(*numModules);
					*numModules = val2 + global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-2123608759 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2375780486u));
					modules[(nint)val2] = ptr5;
					num = (int)((num3 * 2109058517) ^ 0x603CECB7);
					continue;
				}
				case 57u:
					val = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-127058720 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 316793079u));
					num = (int)((num3 * 391266772) ^ 0x7DC39A55);
					continue;
				case 15u:
					num = ((int)num3 * -697152903) ^ -906901805;
					continue;
				case 9u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1590732241u);
					num = -1691638638;
					continue;
				case 62u:
					num = (int)((num3 * 1345191036) ^ 0x61A5D463);
					continue;
				case 8u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(138, 2027235919u);
					num = (int)(num3 * 1881981266) ^ -461250388;
					continue;
				case 19u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(131, 2773631279u);
					num = ((int)num3 * -871615557) ^ 0x4EFAD0BC;
					continue;
				case 11u:
					ptr2 = _Pf(P_0, (ImageDirectoryEntry)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1740303047 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1233628539u)));
					num = (int)((num3 * 63014225) ^ 0x48BDD30E);
					continue;
				case 7u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(130, 2027235919u);
					num = (int)(num3 * 1777809564) ^ -2003993598;
					continue;
				case 40u:
				{
					int num10;
					if (*ptr4 == (void*)(uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-981202473 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2817236338u)))
					{
						num = 403591160;
						num10 = num;
					}
					else
					{
						num = 1194863858;
						num10 = num;
					}
					continue;
				}
				case 18u:
					ptr++;
					num = (int)((num3 * 804029021) ^ 0x1E0E9861);
					continue;
				case 21u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1312661974u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2101368812u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 2697555756u);
					val = (T1)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-434307682 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 4041724208u));
					num = ((int)num3 * -284008505) ^ 0x41E1C9E1;
					continue;
				case 60u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3190109054u);
					num = ((int)num3 * -1114529410) ^ 0x294CDE42;
					continue;
				case 42u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(133, 864554863u);
					num = ((int)num3 * -845525750) ^ 0x6460AC63;
					continue;
				case 41u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(132, 2934403215u);
					num = -1005914474;
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if (ptr2->Size == 0)
					{
						num6 = -871184010;
						num7 = num6;
					}
					else
					{
						num6 = -575850703;
						num7 = num6;
					}
					num = num6 ^ (int)(num3 * 1270785839);
					continue;
				}
				case 17u:
					mEMORYMODULE = (MEMORYMODULE)_206F_206F_202C_206B_200F_200B_200D_206C_200F_202E_200B_200C_200E_200C_206E_206F_202B_206F_206C_202B_200F_202A_200D_206B_200F_200D_202E_200B_206E_200F_206A_206E_200D_200C_202C_202B_202B_200F_206C_206C_202E(P_0);
					num = (int)((num3 * 9957605) ^ 0x6DDF3691);
					continue;
				case 27u:
					ptr7 = (void**)_206B_206D_200D_202D_200B_202E_202A_202C_202E_200B_202E_200F_206F_202B_200E_200C_200C_206B_200B_202D_206D_206B_206B_206F_202B_200C_206A_202A_202B_206D_200D_206F_200C_202B_206C_206A_206D_200E_200C_202D_202E((void*)P_0->modules, (uint)((P_0->numModules + global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x13C78C84 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2405503023u)))) * sizeof(void*)));
					num = ((int)num3 * -1697889914) ^ -1920069853;
					continue;
				case 51u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3485480098u);
					num = ((int)num3 * -2097001681) ^ 0x40485EA;
					continue;
				case 33u:
					codeBase = (T0*)P_0->codeBase;
					num = ((int)num3 * -1117582197) ^ 0x3FC4010C;
					continue;
				case 67u:
					*ptr4 = mEMORYMODULE.getProcAddress(ptr5, (char*)ptr6->Name, P_0->userdata);
					num = ((int)num3 * -332671365) ^ 0x6E23CD6A;
					continue;
				case 23u:
					num = (int)(num3 * 621131953) ^ -1577039223;
					continue;
				case 32u:
					ptr4++;
					num = ((int)num3 * -616376544) ^ -79457735;
					continue;
				case 24u:
					ptr3 = (T2*)((byte*)codeBase + ptr->OriginalFirstThunk);
					num = (int)(num3 * 481865062) ^ -477836416;
					continue;
				case 10u:
					ptr3 = (T2*)((byte*)codeBase + ptr->FirstThunk);
					num = (int)(num3 * 736635239) ^ -631308183;
					continue;
				case 29u:
					num = (int)(num3 * 72887932) ^ -1173261963;
					continue;
				case 54u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2707410351u);
					num = ((int)num3 * -1952538765) ^ -1894471195;
					continue;
				case 39u:
					_fg((Error)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x47687808 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 4078868154u))));
					num = (int)(num3 * 1829693747) ^ -144724722;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (val == null)
					{
						num4 = 763963098;
						num5 = num4;
					}
					else
					{
						num4 = -949163539;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -632835552);
					continue;
				}
				case 66u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 1987858142u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 3106721709u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3012329467u);
					_fg((Error)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-772536768 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3190109054u)));
					num = ((int)num3 * -106830790) ^ 0x5CCB98D;
					continue;
				default:
					return val;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T1 _TE<T0, T1>(_MEMORYMODULE* P_0, _IMAGE_SECTION_HEADER* P_1)
	{
		//IL_02a7: Expected I4, but got O
		//IL_02a8: Expected O, but got I
		//IL_01b7: Expected O, but got I4
		//IL_021c: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3527025916u);
		T0 val = default(T0);
		while (true)
		{
			int num = 881305411;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-59265025 - -(-1924745005 * -414713632 - (-(0x767299AB ^ 0x3AEC4106) + 704942645 * (1946504312 - -143571512)) - (~(num2 ^ (((0x3E603A4C ^ -(-(-1376707907) * -923576843)) + ~2021261218) ^ -1324161143)) - (-2094744321 ^ 0x2BAA7938) * 85851031)))) % 14)
				{
				case 7u:
					break;
				case 9u:
					val = (T0)P_0->headers->OptionalHeader.SizeOfInitializedData;
					num = (int)(num3 * 1778649066) ^ -1688773864;
					continue;
				case 8u:
				{
					int num6;
					int num7;
					if (!_200F_200C_206A_200D_200D_206F_206F_200D_206F_202A_206F_206E_206A_206E_200D_202A_202C_200F_206D_202D_206A_200C_202D_206E_200C_202A_202C_200C_200B_202D_200C_200E_200D_206C_202B_206C_200B_202B_200D_202E_202E(P_1->Characteristics & (uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1353981178 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1593195025u))))
					{
						num6 = 795582698;
						num7 = num6;
					}
					else
					{
						num6 = 1018480171;
						num7 = num6;
					}
					num = num6 ^ (int)(num3 * 427779046);
					continue;
				}
				case 0u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2365057471u);
					num = 120310130;
					continue;
				case 13u:
				{
					uint characteristics = P_1->Characteristics;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1593195025u);
					int num8;
					if (!_200F_200C_206A_200D_200D_206F_206F_200D_206F_202A_206F_206E_206A_206E_200D_202A_202C_200F_206D_202D_206A_200C_202D_206E_200C_202A_202C_200C_200B_202D_200C_200E_200D_206C_202B_206C_200B_202B_200D_202E_202E(characteristics & (uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x2C1FE656 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 0u)))))
					{
						num = -433776131;
						num8 = num;
					}
					else
					{
						num = 763433559;
						num8 = num;
					}
					continue;
				}
				case 4u:
					val = (T0)P_1->SizeOfRawData;
					num = (int)(num3 * 1649599856) ^ -1844699676;
					continue;
				case 11u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(138, 515649404u);
					num = ((int)num3 * -921043039) ^ -2027287420;
					continue;
				case 12u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(135, 3141276412u);
					num = (int)((num3 * 1889853068) ^ 0x143F05C8);
					continue;
				case 6u:
					val = (T0)P_0->headers->OptionalHeader.SizeOfUninitializedData;
					num = ((int)num3 * -1118267725) ^ -1806898837;
					continue;
				case 10u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(133, 2481273852u);
					num = ((int)num3 * -1706920939) ^ -13827492;
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (val != null)
					{
						num4 = -42039867;
						num5 = num4;
					}
					else
					{
						num4 = 1142644735;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1130702040);
					continue;
				}
				case 1u:
					num = ((int)num3 * -1695408445) ^ 0x4A847180;
					continue;
				case 2u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(132, 3968415868u);
					num = ((int)num3 * -921435154) ^ 0x3D813FF1;
					continue;
				default:
					return (T1)(nuint)(UIntPtr)(uint)(int)val;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T1 _iC<T0, T1>(_MEMORYMODULE* P_0, SECTIONFINALIZEDATA* P_1)
	{
		//IL_03b0: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_04fa: Expected O, but got I4
		//IL_0383: Expected O, but got I4
		//IL_05c4: Expected O, but got I4
		//IL_066d: Expected O, but got I4
		//IL_020b: Expected I4, but got O
		//IL_0213: Expected I4, but got O
		//IL_021b: Expected I4, but got O
		//IL_03dd: Expected O, but got I4
		//IL_056b: Expected O, but got I4
		//IL_04ac: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_0526: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3068353571u);
		MEMORYMODULE mEMORYMODULE = default(MEMORYMODULE);
		PageProtection pageProtection = default(PageProtection);
		T1 val2 = default(T1);
		T1 val4 = default(T1);
		T1 val = default(T1);
		T0 val3 = default(T0);
		while (true)
		{
			int num = -1017640826;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((((-(~(num2 * 2041300647)) ^ 0x2F751523) * -505507205 + (-2122382974 - (1964720006 + 1490292718))) ^ 0xE776BBC) - -1106904153)) % 30)
				{
				case 24u:
					break;
				case 19u:
					mEMORYMODULE = (MEMORYMODULE)_206F_206F_202C_206B_200F_200B_200D_206C_200F_202E_200B_200C_200E_200C_206E_206F_202B_206F_206C_202B_200F_202A_200D_206B_200F_200D_202E_200B_206E_200F_206A_206E_200D_200C_202C_202B_202B_200F_206C_206C_202E(P_0);
					num = (int)((num3 * 1021333448) ^ 0x7B4F36ED);
					continue;
				case 16u:
				{
					uint characteristics = P_1->characteristics;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(7, 2225125823u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3932437505u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2019616545u);
					int num14;
					if (!_200F_200C_206A_200D_200D_206F_206F_200D_206F_202A_206F_206E_206A_206E_200D_202A_202C_200F_206D_202D_206A_200C_202D_206E_200C_202A_202C_200C_200B_202D_200C_200E_200D_206C_202B_206C_200B_202B_200D_202E_202E(characteristics & (uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-1254928748 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 3082157281u))))
					{
						num = -410197016;
						num14 = num;
					}
					else
					{
						num = 1373919509;
						num14 = num;
					}
					continue;
				}
				case 22u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(609174935u);
					num = (int)(num3 * 1601143205) ^ -1386432039;
					continue;
				case 11u:
					mEMORYMODULE.free(P_1->address, (UIntPtr)P_1->size, (MemoryAllocation)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x45200D8E ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 0u))), P_0->userdata);
					num = -230878336;
					continue;
				case 21u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(753527451u);
					num = -688944876;
					continue;
				case 14u:
					_202B_206B_202A_202B_206E_206A_202A_206D_206B_200F_202C_202A_206D_206C_202D_206C_206C_202B_206A_206D_202C_202E_202D_200E_206E_206F_206E_200B_206C_202B_206B_200D_206B_206B_206D_206F_202C_200E_200E_202E(_202D_202E_202B_202B_202E_206F_202E_202B_206C_206A_202E_206C_200D_200C_202B_202C_202B_202C_200D_206E_206B_200E_202C_200F_202E_206A_200B_206D_202A_200E_202B_200B_202E_206F_206B_202A_202A_206C_206B_202D_202E(), global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<string>(-574686133 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 2844359333u)));
					num = (int)((num3 * 1240989824) ^ 0x2A9B52FC);
					continue;
				case 12u:
					pageProtection = _4N[_200E_206A_200F_200F_202D_200F_202E_206A_200C_202B_202C_200F_200C_202C_202E_200C_202E_202D_206D_202D_206B_200E_202A_202B_202C_200D_206D_202E_206C_206C_206B_206B_206B_202A_202A_202B_206E_200C_202A_202A_202E((byte)(int)val2 != 0)][_200E_206A_200F_200F_202D_200F_202E_206A_200C_202B_202C_200F_200C_202C_202E_200C_202E_202D_206D_202D_206B_200E_202A_202B_202C_200D_206D_202E_206C_206C_206B_206B_206B_202A_202A_202B_206E_200C_202A_202A_202E((byte)(int)val4 != 0)][_200E_206A_200F_200F_202D_200F_202E_206A_200C_202B_202C_200F_200C_202C_202E_200C_202E_202D_206D_202D_206B_200E_202A_202B_202C_200D_206D_202E_206C_206C_206B_206B_206B_202A_202A_202B_206E_200C_202A_202A_202E((byte)(int)val != 0)];
					num = ((int)num3 * -1316455805) ^ 0xED146CC;
					continue;
				case 28u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2870924725u);
					num = -323135197;
					continue;
				case 18u:
				{
					int num15;
					int num16;
					if (_HF(P_1->address, (UIntPtr)P_1->size, pageProtection, &val3) != 0)
					{
						num15 = 1858973741;
						num16 = num15;
					}
					else
					{
						num15 = -2060061405;
						num16 = num15;
					}
					num = num15 ^ ((int)num3 * -255425448);
					continue;
				}
				case 1u:
					return (T1)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x52F54281 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 155476008u)));
				case 29u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(490449114u);
					num = (int)(num3 * 1443537633) ^ -234870447;
					continue;
				case 25u:
				{
					int num8;
					int num9;
					if (P_1->last)
					{
						num8 = 1360261505;
						num9 = num8;
					}
					else
					{
						num8 = 135484336;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -908124291);
					continue;
				}
				case 23u:
					val2 = (T1)((P_1->characteristics & (uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x52B0DF63 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 932006248u)))) > (uint)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1471496321 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2128075234u)));
					num = (int)((num3 * 1727991481) ^ 0x9AAD89D);
					continue;
				case 6u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1145481228u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 701143164u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 2349898697u);
					val = (T1)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-514080156 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 1926009689u));
					num = (int)(num3 * 925198641) ^ -1443797770;
					continue;
				case 0u:
					val3 = (T0)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-428682536 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3513388318u));
					num = (int)((num3 * 2009669431) ^ 0x7864A1AE);
					continue;
				case 13u:
					return (T1)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x66CA7DA7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3581597072u)));
				case 9u:
				{
					int num17;
					int num18;
					if (_200F_200C_206A_200D_200D_206F_206F_200D_206F_202A_206F_206E_206A_206E_200D_202A_202C_200F_206D_202D_206A_200C_202D_206E_200C_202A_202C_200C_200B_202D_200C_200E_200D_206C_202B_206C_200B_202B_200D_202E_202E(P_1->characteristics & (uint)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x3C52B037 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 2336481396u)))))
					{
						num17 = -1881668708;
						num18 = num17;
					}
					else
					{
						num17 = 316664842;
						num18 = num17;
					}
					num = num17 ^ (int)(num3 * 306029577);
					continue;
				}
				case 20u:
				{
					int num12;
					int num13;
					if (P_1->address != P_1->alignedAddress)
					{
						num12 = -481851356;
						num13 = num12;
					}
					else
					{
						num12 = -2135333492;
						num13 = num12;
					}
					num = num12 ^ ((int)num3 * -1755989437);
					continue;
				}
				case 26u:
				{
					int num10;
					int num11;
					if (P_0->headers->OptionalHeader.SectionAlignment == P_0->pageSize)
					{
						num10 = -250160540;
						num11 = num10;
					}
					else
					{
						num10 = 208259983;
						num11 = num10;
					}
					num = num10 ^ (int)(num3 * 1466104799);
					continue;
				}
				case 17u:
					val2 = (T1)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x3144DF6E ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 850170773u)));
					num = ((int)num3 * -917975074) ^ 0x21D07144;
					continue;
				case 3u:
					val = (T1)((P_1->characteristics & (uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1079960296 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 2157843105u))) > (uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1724177083 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 430848932u)));
					num = ((int)num3 * -1350545885) ^ -605307612;
					continue;
				case 27u:
					return (T1)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x5CDAFC4A ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 90955154u)));
				case 15u:
					val4 = (T1)((P_1->characteristics & (uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1907932843 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 171784356u))) > (uint)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-1724177083 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 4167003406u)));
					num = ((int)num3 * -675602423) ^ -1705826129;
					continue;
				case 10u:
					pageProtection = (PageProtection)((uint)pageProtection | (uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x2FAEFA57 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 0u))));
					num = ((int)num3 * -1334494963) ^ -792727261;
					continue;
				case 7u:
					val4 = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1418515415 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2875557818u));
					num = (int)(num3 * 1324815457) ^ -1498346252;
					continue;
				case 2u:
				{
					int num6;
					int num7;
					if (P_1->size % P_0->pageSize == 0)
					{
						num6 = 1701520080;
						num7 = num6;
					}
					else
					{
						num6 = -1649409964;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -993918434);
					continue;
				}
				case 4u:
					pageProtection = (PageProtection)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x6032CD8C ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1534929695u)));
					num = (int)((num3 * 1700417479) ^ 0x56CD359);
					continue;
				case 5u:
				{
					int num4;
					int num5;
					if (P_1->size != 0)
					{
						num4 = 1393469511;
						num5 = num4;
					}
					else
					{
						num4 = 1906891936;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1543173924);
					continue;
				}
				default:
					return (T1)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-837986463 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1638400279u));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T2 _hk<T0, T1, T2, T3, T4>(_MEMORYMODULE* P_0)
	{
		//IL_014d: Expected O, but got I
		//IL_063f: Expected O, but got I
		//IL_065f: Expected O, but got I
		//IL_08e1: Expected O, but got I4
		//IL_04b9: Expected O, but got I
		//IL_0511: Expected O, but got I
		//IL_052d: Expected I, but got O
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_07cf: Expected O, but got I
		//IL_01ee: Expected O, but got I
		//IL_061f: Expected O, but got I
		//IL_03aa: Expected O, but got I
		//IL_0314: Expected O, but got I
		//IL_0699: Expected O, but got I4
		//IL_0382: Expected O, but got I
		//IL_0786: Expected I, but got O
		//IL_0596: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_0749: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3239453011u);
		_IMAGE_SECTION_HEADER* ptr = default(_IMAGE_SECTION_HEADER*);
		SECTIONFINALIZEDATA sECTIONFINALIZEDATA = default(SECTIONFINALIZEDATA);
		void* ptr3 = default(void*);
		T0 val5 = default(T0);
		T1 val3 = default(T1);
		T1 val2 = default(T1);
		void* ptr2 = default(void*);
		T1 val = default(T1);
		while (true)
		{
			int num = 1476457515;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(2144118691 - -1618010023 - -(num2 * 485619585 * 227124377 * -1519725975 * -1722351743 * -1596103859)))) % 53)
				{
				case 19u:
					break;
				case 32u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2473144286u);
					num = 469622109;
					continue;
				case 1u:
					val = (T1)(nuint)(UIntPtr)ptr->Misc.PhysicalAddress;
					num = (int)(num3 * 729538182) ^ -1349786934;
					continue;
				case 51u:
					ptr++;
					num = (int)(num3 * 1880916225) ^ -861538334;
					continue;
				case 29u:
					sECTIONFINALIZEDATA.alignedAddress = ptr3;
					num = ((int)num3 * -1903816499) ^ 0x5A242CE4;
					continue;
				case 42u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(171858699u);
					num = 960137433;
					continue;
				case 24u:
				{
					int num21;
					int num22;
					if (_iC<T4, T2>(P_0, &sECTIONFINALIZEDATA) != null)
					{
						num21 = -1842969701;
						num22 = num21;
					}
					else
					{
						num21 = -1521844964;
						num22 = num21;
					}
					num = num21 ^ (int)(num3 * 82422189);
					continue;
				}
				case 14u:
					sECTIONFINALIZEDATA.alignedAddress = _uh(sECTIONFINALIZEDATA.address, (T1)(nuint)(UIntPtr)P_0->pageSize);
					num = (int)((num3 * 1709060496) ^ 0x108F353E);
					continue;
				case 39u:
					val5 = (T0)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-971316818 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3080634082u));
					num = (int)((num3 * 800511809) ^ 0x45678D69);
					continue;
				case 3u:
					num = ((int)num3 * -706564332) ^ 0x5A13FBA9;
					continue;
				case 41u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3299713047u);
					num = (int)((num3 * 1573398980) ^ 0x313FD0D6);
					continue;
				case 48u:
				{
					int num15;
					int num16;
					if ((nint)val5 >= (int)P_0->headers->FileHeader.NumberOfSections)
					{
						num15 = 1927994971;
						num16 = num15;
					}
					else
					{
						num15 = 261834804;
						num16 = num15;
					}
					num = num15 ^ ((int)num3 * -1053706157);
					continue;
				}
				case 47u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 209153807u);
					num = 180465679;
					continue;
				case 23u:
					sECTIONFINALIZEDATA.characteristics |= ptr->Characteristics;
					num = ((int)num3 * -455080510) ^ -47509671;
					continue;
				case 40u:
					val3 = _TE<T4, T1>(P_0, ptr);
					num = ((int)num3 * -2073521664) ^ 0x5B71F3B3;
					continue;
				case 17u:
					sECTIONFINALIZEDATA.characteristics = ptr->Characteristics;
					num = (int)((num3 * 242276797) ^ 0x3E5C1F51);
					continue;
				case 25u:
					val2 = (T1)(nuint)UIntPtr.Zero;
					num = (int)((num3 * 943305943) ^ 0x4D9F2F39);
					continue;
				case 2u:
					sECTIONFINALIZEDATA.last = (byte)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x1AF467BC ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 765940346u))) != 0;
					num = (int)(num3 * 1127023520) ^ -995685814;
					continue;
				case 49u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1464692056u);
					num = -503492836;
					continue;
				case 30u:
					ptr = _pK<T3, T1>((T1)(nuint)(UIntPtr)P_0->headers);
					num = ((int)num3 * -1111935758) ^ 0x39FCA28A;
					continue;
				case 16u:
					val = (T1)(nuint)(UIntPtr)ptr->Misc.PhysicalAddress;
					sECTIONFINALIZEDATA.address = (void*)(((UIntPtr*)(&val))->ToUInt64() | ((UIntPtr*)(&val2))->ToUInt64());
					num = (int)(num3 * 1802922659) ^ -1384466450;
					continue;
				case 33u:
				{
					int num23;
					if ((ptr->Characteristics & (uint)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-1745819708 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 3647382669u))) == 0)
					{
						num = -467267088;
						num23 = num;
					}
					else
					{
						num = -81686940;
						num23 = num;
					}
					continue;
				}
				case 31u:
					sECTIONFINALIZEDATA.last = (byte)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x4BCA5711 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2952791787u))) != 0;
					num = ((int)num3 * -1810519659) ^ -398892410;
					continue;
				case 27u:
				{
					int num19;
					int num20;
					if (sECTIONFINALIZEDATA.alignedAddress != ptr3)
					{
						num19 = -972749685;
						num20 = num19;
					}
					else
					{
						num19 = 1783752934;
						num20 = num19;
					}
					num = num19 ^ (int)(num3 * 563910521);
					continue;
				}
				case 43u:
					ptr++;
					num = (int)((num3 * 1008984966) ^ 0x31235579);
					continue;
				case 45u:
				{
					int num17;
					int num18;
					if (_206F_202A_202A_206E_206A_200C_200E_206B_200D_206D_200F_202C_206C_200D_200D_200D_206C_202A_202A_206A_200E_206D_206C_206D_200F_202B_200D_202C_206D_202D_202D_202C_202E_206B_200B_206C_202B_202D_206E_202E_202E())
					{
						num17 = -2122491015;
						num18 = num17;
					}
					else
					{
						num17 = 2011016053;
						num18 = num17;
					}
					num = num17 ^ ((int)num3 * -1500876522);
					continue;
				}
				case 9u:
					val = (T1)(nuint)UIntPtr.Add((UIntPtr)sECTIONFINALIZEDATA.address, (int)sECTIONFINALIZEDATA.size);
					num = (int)((num3 * 532687842) ^ 0x4CE3F7A7);
					continue;
				case 18u:
					sECTIONFINALIZEDATA = default(SECTIONFINALIZEDATA);
					num = -747288417;
					continue;
				case 6u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 4036758223u);
					num = (int)(num3 * 1483877002) ^ -503128805;
					continue;
				case 10u:
					val = (T1)(nuint)P_0->headers->OptionalHeader.ImageBase;
					num = ((int)num3 * -1621801453) ^ 0x349BEDA2;
					continue;
				case 11u:
					sECTIONFINALIZEDATA.size = (uint)(UIntPtr)(nuint)(nint)val3;
					num = (int)((num3 * 1792080899) ^ 0x17E3B0F9);
					continue;
				case 8u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1670124476u);
					num = -551945335;
					continue;
				case 44u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2322789302u);
					num = -1482810410;
					continue;
				case 26u:
					num = ((int)num3 * -1509674157) ^ -1984375257;
					continue;
				case 38u:
				{
					ulong num12 = ((UIntPtr*)(&val))->ToUInt64();
					val = (T1)(nuint)(UIntPtr)ptr3;
					int num13;
					int num14;
					if (num12 > ((UIntPtr*)(&val))->ToUInt64())
					{
						num13 = 767551066;
						num14 = num13;
					}
					else
					{
						num13 = 1538817340;
						num14 = num13;
					}
					num = num13 ^ ((int)num3 * -1151284443);
					continue;
				}
				case 12u:
				{
					T0 val4 = val5;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(11, 1576987369u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 4121802640u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 498772303u);
					val5 = (T0)(val4 + global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x46530519 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 350934747u))));
					num = 325725591;
					continue;
				}
				case 15u:
					ptr3 = _uh(ptr2, (T1)(nuint)(UIntPtr)P_0->pageSize);
					num = ((int)num3 * -1450264899) ^ -1080557502;
					continue;
				case 5u:
				{
					ulong num10 = Unsafe.As<T1, UIntPtr>(ref (T1)(nuint)(UIntPtr)ptr2).ToUInt64();
					val = val3;
					ulong num11 = num10 + ((UIntPtr*)(&val))->ToUInt64();
					val = (T1)(nuint)(UIntPtr)sECTIONFINALIZEDATA.address;
					sECTIONFINALIZEDATA.size = (uint)(num11 - ((UIntPtr*)(&val))->ToUInt64());
					num = (int)(num3 * 1744954411) ^ -1582079430;
					continue;
				}
				case 28u:
					return (T2)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x29F5CE71 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 3418081599u)));
				case 21u:
				{
					int num8;
					int num9;
					if (_iC<T4, T2>(P_0, &sECTIONFINALIZEDATA) == null)
					{
						num8 = 549677749;
						num9 = num8;
					}
					else
					{
						num8 = -1561187703;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -417314411);
					continue;
				}
				case 52u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3693200178u);
					num = (int)((num3 * 398714892) ^ 0x60D1D66E);
					continue;
				case 0u:
				{
					int num6;
					int num7;
					if ((sECTIONFINALIZEDATA.characteristics & (uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x2E398C7A ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 0u)))) == 0)
					{
						num6 = -1638129008;
						num7 = num6;
					}
					else
					{
						num6 = -1068821615;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -1049998672);
					continue;
				}
				case 50u:
					return (T2)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-2046655324 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1013562569u));
				case 36u:
					sECTIONFINALIZEDATA.address = ptr2;
					num = (int)((num3 * 1641061441) ^ 0x7F7291DA);
					continue;
				case 37u:
					sECTIONFINALIZEDATA.size = (uint)(UIntPtr)(nuint)(nint)_TE<T4, T1>(P_0, ptr);
					num = ((int)num3 * -1843213519) ^ 0x765356F1;
					continue;
				case 13u:
				{
					ulong num5 = ((UIntPtr*)(&val))->ToUInt64();
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 2322789302u);
					val2 = (T1)(nuint)(UIntPtr)(num5 & (ulong)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<long>(-522014690 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 0u)));
					num = ((int)num3 * -624938863) ^ -851987719;
					continue;
				}
				case 20u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 316339265u);
					num = 1270009760;
					continue;
				case 4u:
					ptr2 = (void*)(((UIntPtr*)(&val))->ToUInt64() | ((UIntPtr*)(&val2))->ToUInt64());
					num = ((int)num3 * -152442848) ^ 0x192C20CF;
					continue;
				case 22u:
				{
					uint num4 = sECTIONFINALIZEDATA.characteristics | ptr->Characteristics;
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 4036758223u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3376860913u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 1530528343u);
					sECTIONFINALIZEDATA.characteristics = num4 & (uint)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0xE2B9777 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 499844250u)));
					num = 6966700;
					continue;
				}
				case 34u:
					sECTIONFINALIZEDATA.characteristics = ptr->Characteristics;
					num = (int)((num3 * 2075876624) ^ 0x5BD761C6);
					continue;
				case 46u:
					num = ((int)num3 * -520716676) ^ -282549465;
					continue;
				case 35u:
					num = ((int)num3 * -1447258866) ^ 0x73E84FB7;
					continue;
				default:
					return (T2)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x785DDDAC ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 4154280771u)));
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private unsafe static T1 _NI<T0, T1>(_MEMORYMODULE* P_0)
	{
		//IL_00af: Expected O, but got I4
		//IL_01dd: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(319910288u);
		_IMAGE_TLS_DIRECTORY* ptr = default(_IMAGE_TLS_DIRECTORY*);
		_IMAGE_DATA_DIRECTORY* ptr2 = default(_IMAGE_DATA_DIRECTORY*);
		T0* codeBase = default(T0*);
		while (true)
		{
			int num = -121331284;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-(~(-((-(1304994795 * ((0x71A44A63 ^ 0x2DBBB069) * -1443859171)) ^ -1804703008) - -num2))) - (--741736797 ^ -360348184)) ^ 0x3F924946)) % 10)
				{
				case 4u:
					break;
				case 3u:
					return (T1)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1927746406 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 1548148374u));
				case 5u:
					ptr = default(_IMAGE_TLS_DIRECTORY*);
					num = ((int)num3 * -1084263552) ^ 0x550BEA61;
					continue;
				case 1u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3972472785u);
					num = (int)(num3 * 2143318862) ^ -658890221;
					continue;
				case 9u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 3072396607u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 3129198721u);
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(4, 4181983073u);
					ptr2 = _Pf(P_0, (ImageDirectoryEntry)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x19E5D9E7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 3153626273u))));
					num = ((int)num3 * -294345583) ^ -1300484824;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (ptr2->VirtualAddress != 0)
					{
						num4 = -1313278638;
						num5 = num4;
					}
					else
					{
						num4 = -1891965873;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -668026148);
					continue;
				}
				case 2u:
					codeBase = (T0*)P_0->codeBase;
					num = ((int)num3 * -1808496600) ^ 0x22DDF87F;
					continue;
				case 0u:
					ptr = (_IMAGE_TLS_DIRECTORY*)((byte*)codeBase + ptr2->VirtualAddress);
					num = ((int)num3 * -1677076719) ^ 0x4F24CD4A;
					continue;
				case 6u:
					obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(2319533491u);
					num = 1833509852;
					continue;
				default:
					return (T1)_fc(*(uint*)(void*)ptr->AddressOfIndex);
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "SetLastError")]
	private static extern void _fg(Error P_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetLastError")]
	private static extern uint _hf();

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetNativeSystemInfo")]
	private unsafe static extern void _4g(void* P_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "HeapAlloc")]
	private unsafe static extern void* _gj(void* P_0, uint P_1, uint P_2);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "HeapFree")]
	private unsafe static extern int _6n(void* P_0, uint P_1, void* P_2);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetProcessHeap")]
	private unsafe static extern void* _db();

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "IsBadReadPtr")]
	private unsafe static extern int _Mb(void* P_0, uint P_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "VirtualAlloc")]
	private unsafe static extern void* _8m(void* P_0, UIntPtr P_1, MemoryAllocation P_2, PageProtection P_3);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "VirtualFree")]
	private unsafe static extern bool _jh(void* P_0, UIntPtr P_1, MemoryAllocation P_2);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "LoadLibraryA")]
	private unsafe static extern void* _Dc(char* P_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetProcAddress")]
	private unsafe static extern void* _zj(void* P_0, char* P_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "FreeLibrary")]
	private unsafe static extern bool _QA(void* P_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "VirtualProtect")]
	private unsafe static extern int _HF(void* P_0, UIntPtr P_1, PageProtection P_2, void* P_3);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "TlsAlloc", SetLastError = true)]
	private static extern uint _4o();

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "TlsFree", SetLastError = true)]
	private static extern bool _fc(uint P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	static unsafe _NF()
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(895654254u);
		while (true)
		{
			int num = 1586243575;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-1034595120 - -(-(-1993440122 + -199734132 + (0x268D8F9A ^ 0x11CE3150) - (-1515908472 ^ 0x224BE078) - ~1761435444 - ~(~(-num2))))))) % 9)
				{
				case 3u:
					break;
				default:
					return;
				case 4u:
					_GI = _De;
					num = ((int)num3 * -171756339) ^ 0x7218CC2E;
					continue;
				case 6u:
					_KK = _cI<bool, UIntPtr>;
					num = (int)((num3 * 1028114183) ^ 0x50C16D3D);
					continue;
				case 2u:
				{
					PageProtection[][][] array = new PageProtection[global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1367905040 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2553219518u))][][];
					int num4 = global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x2A6E4061 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 854328067u)));
					PageProtection[][] array2 = new PageProtection[global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-195088878 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 725723574u))][];
					int num5 = global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x62CD9FE6 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 2559449599u)));
					PageProtection[] array3 = new PageProtection[global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x6C08FE13 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1203118567u)))];
					array3[global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x1E6D0914 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 2068593195u)))] = (PageProtection)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-406495644 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3642693858u));
					array3[global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-651552161 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1170808178u))] = (PageProtection)global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>((int)(0x6F6672B7 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1437731196u)));
					array2[num5] = array3;
					int num6 = global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-502427769 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 2915603790u));
					PageProtection[] array4 = new PageProtection[global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x12A0FE4F ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 948096717u)))];
					array4[global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-2105654235 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(9, 3381910559u))] = (PageProtection)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-41373457 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 1036613641u));
					array4[global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-703311301 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2199877708u))] = (PageProtection)global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-2014770539 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 246639210u));
					array2[num6] = array4;
					array[num4] = array2;
					int num7 = global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0xE7F997C ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 2345953315u)));
					PageProtection[][] array5 = new PageProtection[global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1362975882 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 2762287328u))][];
					int num8 = global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x66BBF772 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 232882660u)));
					PageProtection[] array6 = new PageProtection[global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x5EDE0AE ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1792884552u)))];
					array6[global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-2136394326 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1358768469u))] = (PageProtection)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1862389657 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 1201200286u));
					array6[global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>((int)(0x63273B24 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 152630403u)))] = (PageProtection)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>(-495165309 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 3861681501u));
					array5[num8] = array6;
					int num9 = global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>(-1853007884 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 697537113u));
					PageProtection[] array7 = new PageProtection[global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>(-277511872 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 261464429u))];
					array7[global::_003CModule_003E._206B_202B_200B_206B_206B_202C_202D_206B_200B_200D_206A_202C_202B_202D_206D_200F_200D_206C_202A_200C_206D_202D_200D_206F_200C_200E_202B_200C_200B_202A_206B_206B_206B_200D_206A_202E_202E_206D_202B_200C_202E<int>(-568875777 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 54171722u))] = (PageProtection)global::_003CModule_003E._202B_206D_202E_202A_202E_202D_200C_202B_200D_206E_202C_202E_206B_200C_202A_206A_200F_202E_206E_202E_202B_200D_206E_206C_200F_206E_206B_202C_206A_202B_202B_200B_202D_202D_206D_200C_200E_202E_206B_206F_202E<int>(-1705469859 ^ (int)obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 419232689u));
					array7[global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<int>((int)(0x7A1968B4 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 943258316u)))] = (PageProtection)global::_003CModule_003E._202E_200D_200B_202B_206B_200E_200D_202B_200F_202E_202B_206B_206F_200E_202B_206D_200C_202B_200F_200D_200E_202B_206E_200D_206B_202D_202A_202A_200B_200C_202A_206E_200C_206B_200C_202D_200E_206D_200D_206D_202E<int>((int)(0x30B133FD ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(6, 195634504u)));
					array5[num9] = array7;
					array[num7] = array5;
					_4N = array;
					num = (int)(num3 * 922260337) ^ -182724283;
					continue;
				}
				case 8u:
					_CC = _AF;
					num = (int)(num3 * 1851013845) ^ -1519685740;
					continue;
				case 7u:
					_ve = _mJ<bool>;
					num = (int)((num3 * 696102026) ^ 0x28BEC90A);
					continue;
				case 1u:
					_nI = _Hg;
					num = ((int)num3 * -1412241450) ^ -1566185243;
					continue;
				case 0u:
					_mA = ((Func<uint>)(() => RuntimeInformation.ProcessArchitecture switch
					{
						Architecture.X86 => 332u, 
						Architecture.X64 => 34404u, 
						Architecture.Arm => 452u, 
						Architecture.Arm64 => 43620u, 
						_ => throw Activator.CreateInstance(typeof(PlatformNotSupportedException)), 
					}))();
					num = (int)((num3 * 1261517663) ^ 0x230DB046);
					continue;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	static object _202A_206E_202B_202E_200E_206A_206E_206E_206D_206F_206B_200F_206E_200E_202B_202D_206A_200C_206B_202D_206C_200C_202C_202E_206F_202A_202B_200E_202E_202A_206B_202D_202D_202A_202A_200D_206A_200B_202A_202E_202E(int P_0)
	{
		return new Win32Exception(P_0);
	}

	static IntPtr _200F_200B_206F_202C_200B_206B_200D_200B_202D_202E_206B_202A_206C_206C_206D_206F_206E_202C_202C_206A_206D_206E_200B_206F_206E_206E_206C_206B_200D_200C_206B_206A_202D_206F_206A_206C_206C_202B_206C_206B_202E(string P_0)
	{
		return Marshal.StringToHGlobalAnsi(P_0);
	}

	static object _206A_202B_200F_202A_206C_202E_206F_206D_206E_206E_206E_206E_200C_200B_202E_200B_206F_206B_200D_202E_206A_202C_202D_202D_200E_200F_206A_200E_206B_206F_202D_206F_206B_206A_202D_206D_200E_200C_206D_202E_202E(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object _206B_206B_206A_200F_202D_206A_200F_200F_206E_206A_200D_206D_206B_206C_200C_206D_202E_206C_202C_200D_206C_206C_202E_200E_202B_206B_202B_206B_202A_202C_206B_200B_206E_200E_206F_202B_206E_200D_200E_206D_202E(IntPtr P_0, Type P_1)
	{
		return Marshal.GetDelegateForFunctionPointer(P_0, P_1);
	}

	static void _206D_200B_202C_206A_206B_200C_206F_202C_206F_202B_200D_200B_202A_206F_200D_202B_202E_206C_202A_200E_206D_200F_202A_200F_206F_206A_202D_200B_202B_202D_206C_206B_206B_202B_202B_206A_206A_206E_206D_202C_202E(IntPtr P_0)
	{
		Marshal.FreeHGlobal(P_0);
	}

	static bool _200F_200C_206A_200D_200D_206F_206F_200D_206F_202A_206F_206E_206A_206E_200D_202A_202C_200F_206D_202D_206A_200C_202D_206E_200C_202A_202C_200C_200B_202D_200C_200E_200D_206C_202B_206C_200B_202B_200D_202E_202E(uint P_0)
	{
		return Convert.ToBoolean(P_0);
	}

	static bool _206F_202A_202A_206E_206A_200C_200E_206B_200D_206D_200F_202C_206C_200D_200D_200D_206C_202A_202A_206A_200E_206D_206C_206D_200F_202B_200D_202C_206D_202D_202D_202C_202E_206B_200B_206C_202B_202D_206E_202E_202E()
	{
		return Environment.Is64BitProcess;
	}

	unsafe static void* _206E_206F_206C_202E_206B_206B_202E_206D_206B_202D_202D_202D_200F_202E_200F_206D_202D_206D_202D_206B_200F_200E_206C_202A_202E_200F_202E_206D_206A_206C_200D_200C_200B_206B_200C_200D_200C_206B_202C_202D_202E(uint P_0)
	{
		return _5C._T<IntPtr, uint>(P_0);
	}

	static int _202C_200C_206D_206D_202E_206C_206B_206C_206F_200D_202A_206C_200B_206D_206D_202A_202B_202B_206E_206C_200C_206A_200E_202B_200D_202A_206D_206B_206F_206C_202C_202E_202B_200E_206F_206C_206E_202C_200E_200D_202E(Type P_0)
	{
		return Marshal.SizeOf(P_0);
	}

	static int _200E_206A_200F_200F_202D_200F_202E_206A_200C_202B_202C_200F_200C_202C_202E_200C_202E_202D_206D_202D_206B_200E_202A_202B_202C_200D_206D_202E_206C_206C_206B_206B_206B_202A_202A_202B_206E_200C_202A_202A_202E(bool P_0)
	{
		return Convert.ToInt32(P_0);
	}

	unsafe static void* _202D_206A_202C_202A_206F_206B_200F_200E_206A_206B_206B_206D_206F_200F_206B_202E_206B_202B_200E_202A_206F_200C_206B_200F_206C_206D_202D_206F_202B_200B_200C_202A_200D_202C_202C_200D_206E_200E_200D_206B_202E(void* P_0, void* P_1, uint P_2)
	{
		return _5C._To(P_0, P_1, P_2);
	}

	static bool _200C_200E_202D_200B_202D_206E_206D_206C_200C_200F_202D_206C_200F_202D_206A_202B_206D_202A_200D_200C_206C_206E_202B_202A_206A_206C_202B_206C_206D_202D_200E_200C_200C_206A_202C_200B_202A_202A_202E_202C_202E(int P_0)
	{
		return Convert.ToBoolean(P_0);
	}

	unsafe static object _206F_206F_202C_206B_200F_200B_200D_206C_200F_202E_200B_200C_200E_200C_206E_206F_202B_206F_206C_202B_200F_202A_200D_206B_200F_200D_202E_200B_206E_200F_206A_206E_200D_200C_202C_202B_202B_200F_206C_206C_202E(_MEMORYMODULE* P_0)
	{
		return MEMORYMODULE.MarshalFrom(P_0);
	}

	unsafe static void _206E_206C_200D_200B_200D_206C_200F_202B_200F_206D_206D_202C_202A_202A_206D_206F_206F_200B_202E_200C_202D_200D_202A_206B_202E_200E_200C_200D_200C_206A_206C_202B_200C_200D_200C_206B_202C_200C_202B_206F_202E(void* P_0)
	{
		_5C._RH(P_0);
	}

	static string _206B_202B_202D_206A_206E_206F_206A_200D_202B_206D_200E_200C_202E_206A_202C_202D_200B_206D_206B_200E_200E_206D_200B_202A_202D_206B_200B_206C_206E_206E_206D_206E_202A_200B_206B_206C_200E_200E_206B_202E_202E(IntPtr P_0)
	{
		return Marshal.PtrToStringAnsi(P_0);
	}

	static IntPtr _200E_206A_206B_200E_206A_202A_206C_200F_202C_206B_202D_200B_202D_206A_206D_206B_200F_202D_200E_206A_206C_202E_200F_202B_200C_202E_202B_200C_206B_206A_200E_202D_206E_200B_206C_200B_202D_206D_202E_200C_202E(Type P_0, string P_1)
	{
		return Marshal.OffsetOf(P_0, P_1);
	}

	unsafe static void* _206A_206E_206E_202E_206F_200F_206E_200E_202C_206B_202E_200D_200C_202D_200E_206D_202B_206D_202C_202C_206C_202D_202A_206E_200D_206D_206F_206B_202D_202C_202B_200C_202E_206A_200D_206B_202D_206C_206C_200D_202E(void* P_0, int P_1, uint P_2)
	{
		return _5C._Ul(P_0, P_1, P_2);
	}

	static void _202D_206B_200B_200B_200D_206B_200D_202B_202B_202A_202A_202E_206C_202E_202B_202C_206A_200E_206B_202B_200E_206F_200E_202B_202E_200C_200C_200F_200D_200D_200C_206A_202C_206A_200C_206B_202E_202E_200F_202E(string P_0)
	{
		Console.WriteLine(P_0);
	}

	static string _200E_200E_206E_202B_202D_202C_206D_202E_202C_202A_200C_200C_206F_200D_200D_200E_200C_206E_206D_206E_200C_206C_206B_202A_200D_202D_206B_200B_200C_206C_200B_206A_206A_202C_206B_206E_200B_200B_202E_200F_202E(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string _206C_202B_206F_206C_202D_200F_206A_200D_202A_206C_200F_200B_200B_200D_200C_206B_206B_200C_202C_202B_206D_200D_206A_202C_200F_202E_202C_202B_206E_200C_202B_206B_200B_202B_202D_202E_206C_202B_202E_202E(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static object _206D_200D_200F_206E_200C_202D_202C_206F_206D_206C_206F_206A_200E_200F_200D_206E_206F_200D_202C_206D_202A_206C_206C_202D_200E_206B_202D_206B_206E_202E_202B_200C_206B_206E_206E_202A_200F_206E_200C_206B_202E(string P_0)
	{
		return new _vn(P_0);
	}

	unsafe static void* _206B_206D_200D_202D_200B_202E_202A_202C_202E_200B_202E_200F_206F_202B_200E_200C_200C_206B_200B_202D_206D_206B_206B_206F_202B_200C_206A_202A_202B_206D_200D_206F_200C_202B_206C_206A_206D_200E_200C_202D_202E(void* P_0, uint P_1)
	{
		return _5C._6l<uint, int, IntPtr, bool>(P_0, P_1);
	}

	static object _202D_202E_202B_202B_202E_206F_202E_202B_206C_206A_202E_206C_200D_200C_202B_202C_202B_202C_200D_206E_206B_200E_202C_200F_202E_206A_200B_206D_202A_200E_202B_200B_202E_206F_206B_202A_202A_206C_206B_202D_202E()
	{
		return Console.Error;
	}

	static void _202B_206B_202A_202B_206E_206A_202A_206D_206B_200F_202C_202A_206D_206C_202D_206C_206C_202B_206A_206D_202C_202E_202D_200E_206E_206F_206E_200B_206C_202B_206B_200D_206B_206B_206D_206F_202C_200E_200E_202E(object P_0, string P_1)
	{
		((TextWriter)P_0).WriteLine(P_1);
	}
}
