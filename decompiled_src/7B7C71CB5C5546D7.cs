using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

internal sealed class _7B7C71CB5C5546D7 : global::_94E3D906D3E34B5F<A58BA203630149A8>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct AEB4C46FA7544C39 : IAsyncStateMachine
	{
		public int _971AA564BCA9442F;

		public AsyncTaskMethodBuilder C920FBDE3FDA46B8;

		public _7B7C71CB5C5546D7 BE46A97E3D614695;

		public A58BA203630149A8 D867F8B522C842CD;

		public _02C54685DE0E4B81 _95F9C85A2AAF45B1;

		public CancellationToken _03F5DD4E8A844F14;

		private TaskAwaiter _22D0619AD924432D;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _971AA564BCA9442F;
			_7B7C71CB5C5546D7 obj = BE46A97E3D614695;
			try
			{
				int num2;
				TaskAwaiter awaiter = default;
				B7097FC49A384CFA._708ECF20BC9E451D obj3 = default;
				string text2 = default;
				B7097FC49A384CFA._708ECF20BC9E451D obj2 = default;
				switch (num)
				{
				default:
					num2 = 2037664166;
					goto IL_0029;
				case 0:
					goto IL_02b8;
				case 1:
					goto IL_03bd;
				case 2:
					goto IL_0441;
				case 3:
					goto IL_0730;
					IL_0029:
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(((-(num3 * 559356871 - (unchecked(994953853 * -1600998065) + 950983201 * (unchecked(-1727197327 * (~1413979485 - unchecked(1078171323 * 1287275789))) + (-(-656971729 ^ -1040373208) + (~1803786268 - (0x3D9CF3BF ^ 0x3680058B)))))) + ~(~(-1892477269 ^ -513580181)) + -(-unchecked(-1495510792 + -1740603792)) - -unchecked(1294672651 * -1666807231)) * -1203598765) ^ -822478454)) % 41)
						{
						case 0u:
							break;
						default:
							goto end_IL_000f;
						case 21u:
							awaiter.GetResult();
							num2 = -1649828869;
							continue;
						case 30u:
							num2 = ((int)num4 * -726410640) ^ 0x6ABC645C;
							continue;
						case 36u:
							awaiter.GetResult();
							num2 = -952165252;
							continue;
						case 39u:
							goto IL_01a9;
						case 12u:
							num2 = (int)(num4 * 171231751) ^ -1230901365;
							continue;
						case 6u:
							goto IL_01dd;
						case 37u:
							num2 = (int)((num4 * 419066218) ^ 0x46AD9712);
							continue;
						case 22u:
							goto IL_024d;
						case 2u:
							num = (_971AA564BCA9442F = _003CModule_003E.F84FA79ABE6944BB<int>(-1423102128));
							_22D0619AD924432D = awaiter;
							num2 = -1587325636;
							continue;
						case 33u:
							goto IL_02b8;
						case 8u:
							goto IL_02ca;
						case 3u:
							num = (_971AA564BCA9442F = _003CModule_003E._3F57E81A62734AC2<int>(-1030831117));
							_22D0619AD924432D = awaiter;
							C920FBDE3FDA46B8.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 23u:
							awaiter.GetResult();
							num2 = -593304084;
							continue;
						case 25u:
							_22D0619AD924432D = awaiter;
							C920FBDE3FDA46B8.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 4u:
							goto IL_036b;
						case 13u:
							goto IL_0394;
						case 31u:
							goto IL_03bd;
						case 26u:
							obj3._37B20A4113D244AA = (ulong)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019);
							obj3._7CD049C055E3441A = _003CModule_003E._3F57E81A62734AC2<string>(-1712585720);
							num2 = -1403569264;
							continue;
						case 27u:
							text2 = _372BB9837C734A8C((object)D867F8B522C842CD);
							num2 = -233021581;
							continue;
						case 40u:
							_22D0619AD924432D = default;
							num = (_971AA564BCA9442F = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = 1220016210;
							continue;
						case 24u:
							goto IL_0441;
						case 5u:
							goto IL_045f;
						case 35u:
							num = (_971AA564BCA9442F = _003CModule_003E._3F57E81A62734AC2<int>(1017304263));
							_22D0619AD924432D = awaiter;
							num2 = 1570729930;
							continue;
						case 34u:
						{
							ILogger? val = obj._0714FC5330274165;
							if (val == null)
							{
								goto case 15u;
							}
							string text = _003CModule_003E.F84FA79ABE6944BB<string>(-103309822);
							object[] array = new object[_003CModule_003E._58ECCB512F2A43AC<int>(1208532887)];
							array[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)] = _372BB9837C734A8C((object)D867F8B522C842CD);
							array[_003CModule_003E._3F57E81A62734AC2<int>(1017304263)] = E57627A99ACE4EC9((object)D867F8B522C842CD);
							_4E6085F0E54242C5(val, text, array);
							num2 = 199938028;
							continue;
						}
						case 14u:
							goto IL_0561;
						case 10u:
							C920FBDE3FDA46B8.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num2 = ((int)num4 * -1762545761) ^ -1727183912;
							continue;
						case 7u:
							_22D0619AD924432D = default;
							num = (_971AA564BCA9442F = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num2 = -1947136108;
							continue;
						case 17u:
							obj2._8DCA212F88FC4301 = E57627A99ACE4EC9((object)D867F8B522C842CD);
							num2 = 714710978;
							continue;
						case 16u:
							goto IL_0647;
						case 11u:
							num = (_971AA564BCA9442F = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
							num2 = -1052421972;
							continue;
						case 18u:
							awaiter.GetResult();
							num2 = -593304084;
							continue;
						case 15u:
							obj3 = default;
							num2 = 419089193;
							continue;
						case 32u:
							C920FBDE3FDA46B8.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num2 = (int)(num4 * 1629533850) ^ -1189720161;
							continue;
						case 1u:
							num = (_971AA564BCA9442F = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
							num2 = 588152275;
							continue;
						case 19u:
							return;
						case 38u:
							goto IL_0730;
						case 28u:
							_22D0619AD924432D = default;
							num = (_971AA564BCA9442F = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
							num2 = -1743919293;
							continue;
						case 9u:
							return;
						case 29u:
							obj2.ACF9BC69E5294E28 = E57627A99ACE4EC9((object)D867F8B522C842CD);
							num2 = (int)((num4 * 17807543) ^ 0x1F1CE028);
							continue;
						case 20u:
							goto end_IL_000f;
						}
						break;
						IL_0647:
						awaiter = E12EA94A86564EA3(_2ABF9C452D91498D((object)_95F9C85A2AAF45B1, A60FECF0A858423B((byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0), _51F989CB07B149CB((object)D867F8B522C842CD), _03F5DD4E8A844F14));
						int num5;
						if (!awaiter.IsCompleted)
						{
							num2 = -521002755;
							num5 = num2;
						}
						else
						{
							num2 = 1220016210;
							num5 = num2;
						}
						continue;
						IL_0394:
						int num6;
						if (FB96DB5F975542F4(text2, _003CModule_003E._390073C602714496<string>(-381755976)))
						{
							num2 = -1954523558;
							num6 = num2;
						}
						else
						{
							num2 = -1925575012;
							num6 = num2;
						}
						continue;
						IL_02ca:
						int num7;
						if (FB96DB5F975542F4(text2, _003CModule_003E._58ECCB512F2A43AC<string>(728612000)))
						{
							num2 = 583170689;
							num7 = num2;
						}
						else
						{
							num2 = -729357048;
							num7 = num2;
						}
						continue;
						IL_0561:
						awaiter = E12EA94A86564EA3(A7017606C08B4D4F((object)((_1DB744298E9F4B09)_91D3FA7AC2E74827()).CF47F3EE0E0C4452.F3B62BCE1450413B<B7097FC49A384CFA>(), obj2, _003CModule_003E._3F57E81A62734AC2<int>(1017304263), (EFlagLevel)_003CModule_003E.F84FA79ABE6944BB<int>(-1423102128), (ECheckCategory)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563), (ECheckType)_003CModule_003E._390073C602714496<int>(2131963235), _003CModule_003E._3F57E81A62734AC2<string>(1364791939), ((byte[], string, Guid)?)null));
						int num8;
						if (!awaiter.IsCompleted)
						{
							num2 = 1643496414;
							num8 = num2;
						}
						else
						{
							num2 = -1743919293;
							num8 = num2;
						}
						continue;
						IL_01dd:
						awaiter = E12EA94A86564EA3(_31BC2750F1DC4939((object)((_1DB744298E9F4B09)_91D3FA7AC2E74827()).CF47F3EE0E0C4452.F3B62BCE1450413B<B7097FC49A384CFA>(), obj2, _003CModule_003E._58ECCB512F2A43AC<string>(1755893221), (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0, _003CModule_003E._58ECCB512F2A43AC<string>(-2016552933)));
						int num9;
						if (!awaiter.IsCompleted)
						{
							num2 = -348907086;
							num9 = num2;
						}
						else
						{
							num2 = -1947136108;
							num9 = num2;
						}
						continue;
						IL_036b:
						int num10;
						if (FB96DB5F975542F4(text2, _003CModule_003E._8B9C7B12B1AE4949<string>(1870421603)))
						{
							num2 = 686934815;
							num10 = num2;
						}
						else
						{
							num2 = -223246268;
							num10 = num2;
						}
						continue;
						IL_045f:
						obj3.D0085BCED909426B = _003CModule_003E.F84FA79ABE6944BB<string>(-267252033);
						obj3._35219130B15F4D94 = _003CModule_003E._58ECCB512F2A43AC<string>(2129637227);
						obj3.B38102437FF64506 = _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
						obj3._143FFF351A2C4104 = _003CModule_003E._58ECCB512F2A43AC<float>(-1745125460);
						obj2 = obj3;
						int num11;
						if (_2230AF6933534784((object)D867F8B522C842CD) != 0)
						{
							num2 = 1341212543;
							num11 = num2;
						}
						else
						{
							num2 = -843595502;
							num11 = num2;
						}
						continue;
						IL_01a9:
						int num12;
						if (!B509A68EEC914157((object)D867F8B522C842CD))
						{
							num2 = -1649828869;
							num12 = num2;
						}
						else
						{
							num2 = 582798019;
							num12 = num2;
						}
						continue;
						IL_024d:
						awaiter = E12EA94A86564EA3(EE7BD36D5FF04A59((object)((_1DB744298E9F4B09)_91D3FA7AC2E74827()).CF47F3EE0E0C4452.F3B62BCE1450413B<B7097FC49A384CFA>(), obj2, _003CModule_003E._3F57E81A62734AC2<string>(-1853099438)));
						int num13;
						if (!awaiter.IsCompleted)
						{
							num2 = 1904786951;
							num13 = num2;
						}
						else
						{
							num2 = -1052421972;
							num13 = num2;
						}
					}
					goto default;
					IL_0730:
					awaiter = _22D0619AD924432D;
					num2 = 153253746;
					goto IL_0029;
					IL_0441:
					awaiter = _22D0619AD924432D;
					_22D0619AD924432D = default;
					num2 = 699917579;
					goto IL_0029;
					IL_03bd:
					awaiter = _22D0619AD924432D;
					num2 = 370260868;
					goto IL_0029;
					IL_02b8:
					awaiter = _22D0619AD924432D;
					num2 = -1420655171;
					goto IL_0029;
					end_IL_000f:
					break;
				}
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num14 = -1723103360;
					while (true)
					{
						int num3 = num14;
						uint num4;
						switch ((num4 = (uint)(((-(num3 * 559356871 - (unchecked(994953853 * -1600998065) + 950983201 * (unchecked(-1727197327 * (~1413979485 - unchecked(1078171323 * 1287275789))) + (-(-656971729 ^ -1040373208) + (~1803786268 - (0x3D9CF3BF ^ 0x3680058B)))))) + ~(~(-1892477269 ^ -513580181)) + -(-unchecked(-1495510792 + -1740603792)) - -unchecked(1294672651 * -1666807231)) * -1203598765) ^ -822478454)) % 4)
						{
						case 2u:
							break;
						default:
							return;
						case 1u:
							_971AA564BCA9442F = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
							num14 = 1428675390;
							continue;
						case 3u:
							C920FBDE3FDA46B8.SetException(exception);
							num14 = ((int)num4 * -607564915) ^ 0x31B4EA76;
							continue;
						case 0u:
							return;
						}
						break;
					}
				}
			}
			_971AA564BCA9442F = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			while (true)
			{
				int num15 = -839426903;
				while (true)
				{
					int num3 = num15;
					uint num4;
					switch ((num4 = (uint)(((-(num3 * 559356871 - (unchecked(994953853 * -1600998065) + 950983201 * (unchecked(-1727197327 * (~1413979485 - unchecked(1078171323 * 1287275789))) + (-(-656971729 ^ -1040373208) + (~1803786268 - (0x3D9CF3BF ^ 0x3680058B)))))) + ~(~(-1892477269 ^ -513580181)) + -(-unchecked(-1495510792 + -1740603792)) - -unchecked(1294672651 * -1666807231)) * -1203598765) ^ -822478454)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_096f;
					case 2u:
						return;
					}
					break;
					IL_096f:
					C920FBDE3FDA46B8.SetResult();
					num15 = ((int)num4 * -545593683) ^ 0x5DDD49F8;
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
			C920FBDE3FDA46B8.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static string _372BB9837C734A8C(object P_0)
		{
			return ((A58BA203630149A8)P_0)._4DF674966D3C4AF9;
		}

		static string E57627A99ACE4EC9(object P_0)
		{
			return ((A58BA203630149A8)P_0)._00ECE3BD20C142E6;
		}

		static void _4E6085F0E54242C5(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}

		static byte _2230AF6933534784(object P_0)
		{
			return ((A58BA203630149A8)P_0)._4B8939E38D994538;
		}

		static bool FB96DB5F975542F4(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static object _91D3FA7AC2E74827()
		{
			return _1DB744298E9F4B09._052FBC588F454484;
		}

		static object _31BC2750F1DC4939(object P_0, B7097FC49A384CFA._708ECF20BC9E451D P_1, string P_2, bool P_3, string P_4)
		{
			return ((B7097FC49A384CFA)P_0).BA7BE5B4061A4F98(P_1, P_2, P_3, P_4);
		}

		static TaskAwaiter E12EA94A86564EA3(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static object A7017606C08B4D4F(object P_0, B7097FC49A384CFA._708ECF20BC9E451D P_1, int P_2, EFlagLevel P_3, ECheckCategory P_4, ECheckType P_5, string P_6, (byte[], string, Guid)? P_7)
		{
			return ((B7097FC49A384CFA)P_0)._843A5100D1DA4FE0(P_1, P_2, P_3, P_4, P_5, P_6, P_7);
		}

		static object EE7BD36D5FF04A59(object P_0, B7097FC49A384CFA._708ECF20BC9E451D P_1, string P_2)
		{
			return ((B7097FC49A384CFA)P_0)._0AEFB715ADC84B45(P_1, P_2);
		}

		static bool B509A68EEC914157(object P_0)
		{
			return ((_652C34B1E6554F10)P_0)._34B44C79896F4AF2;
		}

		static object A60FECF0A858423B(bool P_0)
		{
			return new _95A08CC1D4B4428B(P_0);
		}

		static long _51F989CB07B149CB(object P_0)
		{
			return ((_652C34B1E6554F10)P_0).C4CF7218A3D4459F;
		}

		static object _2ABF9C452D91498D(object P_0, object P_1, long P_2, CancellationToken P_3)
		{
			return ((_02C54685DE0E4B81)P_0)._884DB9DE8C5C4C0A((_652C34B1E6554F10)P_1, P_2, P_3);
		}
	}

	private readonly ILogger? _0714FC5330274165;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(AEB4C46FA7544C39))]
	public Task F1D52E30BF934198(_02C54685DE0E4B81 P_0, A58BA203630149A8 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		AEB4C46FA7544C39 stateMachine = default;
		stateMachine.C920FBDE3FDA46B8 = AsyncTaskMethodBuilder.Create();
		while (true)
		{
			int num = 1025061705;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-2040314232 - -(((((num2 + (~(-1201688837) * 1783415581 - (-(-710864981) ^ 0x4B4AD575 ^ 0x5B872279) + (~(-490155757 + unchecked(~1347867878 * 764701719)) + ((699662927 + ~(--2010544595)) ^ -1891120581)) - ((-1588491143 + --496122509 - unchecked(1124251032 * 490574839)) ^ (-(-(~(1335995895 - 1766021064))) ^ (-(952797132 + -1716662310) ^ -1545825329 ^ 0x370D1400))))) ^ ~(--824354816) ^ (~188627112 + (~unchecked(unchecked(380486571 * -1794893268) * -1727208489) - -(-(1399729392 + -1617559074))))) - 116187130) ^ -16990059) * -678830231))) % 4)
				{
				case 3u:
					break;
				case 2u:
					stateMachine.BE46A97E3D614695 = this;
					num = (int)((num3 * 2058981551) ^ 0x546E729A);
					continue;
				case 1u:
					stateMachine._95F9C85A2AAF45B1 = P_0;
					stateMachine.D867F8B522C842CD = P_1;
					stateMachine._03F5DD4E8A844F14 = P_2;
					stateMachine._971AA564BCA9442F = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120);
					stateMachine.C920FBDE3FDA46B8.Start(ref stateMachine);
					num = -2066792125;
					continue;
				default:
					return stateMachine.C920FBDE3FDA46B8.Task;
				}
				break;
			}
		}
	}

	Task global::_94E3D906D3E34B5F<A58BA203630149A8>._61C062AE41194B7D(_02C54685DE0E4B81 P_0, A58BA203630149A8 P_1, CancellationToken P_2 = default(CancellationToken))
	{
		//ILSpy generated this explicit interface implementation from .override directive in F1D52E30BF934198
		return this.F1D52E30BF934198(P_0, P_1, P_2);
	}

	public _7B7C71CB5C5546D7()
	{
		C8499E51FB314351();
		F3CAA2F7AC8E4D36((object)null);
	}

	static object C8499E51FB314351()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static object F3CAA2F7AC8E4D36(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
	}
}
