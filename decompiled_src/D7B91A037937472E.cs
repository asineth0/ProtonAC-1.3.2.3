using System.Runtime.CompilerServices;
using System.Threading;

internal static class D7B91A037937472E<_0001> where _0001 : class, _45A0FAC1031A4143, new()
{
	private const int _048ADDFD67B14197 = 32;

	private static readonly _0001?[] _2594623119A74A23 = new _0001[_003CModule_003E._58ECCB512F2A43AC<int>(-1221832743)];

	private static int E8C251D6C7854367;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static _0001 _2583D328976C4661()
	{
		if (DCFB33EB46184BCB(ref E8C251D6C7854367) > _003CModule_003E.F84FA79ABE6944BB<int>(1398637845))
		{
			int num6 = default;
			_0001 val = default;
			while (true)
			{
				int num = 2052087639;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(unchecked(804296851 * ~-1397851089) + -(~1461081961) - (-(unchecked(-926821729 * -900552887) - ~num2) + 2033803703) - unchecked(-73301907 * unchecked(-66795417 * -1440154478)) + unchecked(610350231 * 887653337) - 845470808)) % 8)
					{
					case 7u:
						break;
					case 3u:
						num6 = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042);
						num = 686740726;
						continue;
					case 5u:
						val = Interlocked.Exchange(ref _2594623119A74A23[num6], null);
						num = 1381752589;
						continue;
					case 2u:
						goto IL_00da;
					case 0u:
						_98E2D0DC41094A5E(ref E8C251D6C7854367);
						return val;
					case 4u:
						num6 += _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
						num = 686740726;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (val != null)
						{
							num4 = 2121292460;
							num5 = num4;
						}
						else
						{
							num4 = 1799135960;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -1094776496);
						continue;
					}
					default:
						goto end_IL_001b;
					}
					break;
					IL_00da:
					int num7;
					if (num6 < _2594623119A74A23.Length)
					{
						num = 1382675569;
						num7 = num;
					}
					else
					{
						num = 1576548450;
						num7 = num;
					}
				}
				continue;
				end_IL_001b:
				break;
			}
		}
		return new _0001();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _8812F3ADA5664BC6(_0001 P_0)
	{
		_58772CB6961E4FEC((object)P_0);
		int num4 = default;
		while (true)
		{
			int num = 340436128;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(num2 - ~(736626561 * -(-unchecked(-1644218051 - 1056971274) - (227976736 + -1083732748 + ~-2110353212)) + ~unchecked(unchecked(493013451 * -1366368951) - unchecked(165477389 * 1466523952)))) ^ ~(--3424651))) % 9)
				{
				case 7u:
					break;
				default:
					return;
				case 8u:
				{
					int num6;
					if (Interlocked.CompareExchange(ref _2594623119A74A23[num4], P_0, null) == null)
					{
						num = 159041961;
						num6 = num;
					}
					else
					{
						num = 416158563;
						num6 = num;
					}
					continue;
				}
				case 5u:
					num4 += _003CModule_003E.F84FA79ABE6944BB<int>(1741630884);
					num = 2101787108;
					continue;
				case 3u:
					_19F13448B9534060(ref E8C251D6C7854367);
					num = ((int)num3 * -1225276525) ^ 0x102D9285;
					continue;
				case 2u:
				{
					int num5;
					if (num4 >= _2594623119A74A23.Length)
					{
						num = 1881539058;
						num5 = num;
					}
					else
					{
						num = 1886456259;
						num5 = num;
					}
					continue;
				}
				case 6u:
					num = ((int)num3 * -1132837488) ^ -1458831996;
					continue;
				case 4u:
					return;
				case 1u:
					num4 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
					num = 94408238;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	static int DCFB33EB46184BCB(ref int P_0)
	{
		return Volatile.Read(in P_0);
	}

	static int _98E2D0DC41094A5E(ref int P_0)
	{
		return Interlocked.Decrement(ref P_0);
	}

	static void _58772CB6961E4FEC(object P_0)
	{
		((_45A0FAC1031A4143)P_0)._058D7D2916534402();
	}

	static int _19F13448B9534060(ref int P_0)
	{
		return Interlocked.Increment(ref P_0);
	}
}
