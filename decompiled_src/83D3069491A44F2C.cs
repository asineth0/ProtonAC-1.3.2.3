using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

internal class _83D3069491A44F2C : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid _448D7031FD6044C1;

	[CompilerGenerated]
	private float DD966CD37A5C4E9C;

	[CompilerGenerated]
	private List<_23AFFD5168C1458B> B043F3B760DE47FB;

	public Guid _9C34C722140546A5
	{
		[CompilerGenerated]
		get
		{
			return _448D7031FD6044C1;
		}
		[CompilerGenerated]
		set
		{
			_448D7031FD6044C1 = guid;
		}
	}

	public float _8EA8906D14BA436B
	{
		[CompilerGenerated]
		get
		{
			return DD966CD37A5C4E9C;
		}
		[CompilerGenerated]
		set
		{
			DD966CD37A5C4E9C = dD966CD37A5C4E9C;
		}
	}

	public List<_23AFFD5168C1458B> E4E7403BB0914C51
	{
		[CompilerGenerated]
		get
		{
			return B043F3B760DE47FB;
		}
		[CompilerGenerated]
		set
		{
			B043F3B760DE47FB = b043F3B760DE47FB;
		}
	}

	public _83D3069491A44F2C()
	{
		_448D7031FD6044C1 = default;
	}

	public _83D3069491A44F2C(Guid P_0, float P_1, List<_23AFFD5168C1458B> P_2)
	{
		B043F3B760DE47FB = new List<_23AFFD5168C1458B>();
		base._002Ector();
		EBE3F333E7FC48CC((object)this, P_0);
		_41C387F4B0B24C52((object)this, P_1);
		DD26A66505EE46ED((object)this, P_2);
	}

	public virtual void A545DCEEF7494663(BinaryWriter P_0)
	{
		_8D7D6889C4E84F62((object)P_0, A361DDC8E763457B((object)this).ToString());
		E6DBCDCDBE6048CB((object)P_0, _185F0140315445F2((object)this));
		while (true)
		{
			int num = -1724123226;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~(~(-num2)) * -627208539 * -1077433143) ^ 0x1FFCB679)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0067;
				default:
				{
					using List<_23AFFD5168C1458B>.Enumerator enumerator = E7DDA1744B9F415C((object)this).GetEnumerator();
					while (true)
					{
						int num4;
						int num5;
						if (enumerator.MoveNext())
						{
							num4 = 1229635120;
							num5 = num4;
						}
						else
						{
							num4 = -1412047785;
							num5 = num4;
						}
						while (true)
						{
							num2 = num4;
							switch ((num3 = (uint)((~(~(-num2)) * -627208539 * -1077433143) ^ 0x1FFCB679)) % 4)
							{
							case 3u:
								num4 = 1229635120;
								continue;
							default:
								return;
							case 1u:
							{
								_23AFFD5168C1458B current = enumerator.Current;
								_159ED7FBCCD14EA6((object)P_0, _432E7685B9ED409E((object)current));
								DE75C0031C974A9D((object)P_0, _53BB41EB31704684((object)current).Length);
								EC4DCD46C4C04AEF((object)P_0, _53BB41EB31704684((object)current));
								num4 = 703841917;
								continue;
							}
							case 2u:
								break;
							case 0u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
				IL_0067:
				DE75C0031C974A9D((object)P_0, E7DDA1744B9F415C((object)this).Count);
				num = ((int)num3 * -1085403770) ^ -1798005596;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void DC04E12B5C19408B(BinaryReader P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(913425958u);
		byte[] array = default;
		long num4 = default;
		int num7 = default;
		int num5 = default;
		int num6 = default;
		while (true)
		{
			int num = -1666369777;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~(unchecked(-1439900545 * ~432506054) - (0x2EB1ACC0 ^ -1200053753)) - num2 * 839404691 * 1426357449 * -679522275))) % 16)
				{
				case 7u:
					break;
				case 12u:
					num = (int)(num3 * 244044147) ^ -1994865332;
					continue;
				case 11u:
					obj = new _81DD83B8AA2247AA(4153077814u);
					array = Array.Empty<byte>();
					num = (int)(num3 * 184663166) ^ -1165183697;
					continue;
				case 13u:
					_41C387F4B0B24C52((object)this, _66BE5EC54D1A4E29((object)P_0));
					num = (int)(num3 * 1498534592) ^ -1953499687;
					continue;
				case 15u:
					num4 = C9632F3C5D2649F6((object)P_0);
					num7 = _8FF057E9A3274C47((object)P_0);
					num = 2112614563;
					continue;
				case 6u:
					num = ((int)num3 * -195510937) ^ 0x33826236;
					continue;
				case 5u:
				{
					obj = new _81DD83B8AA2247AA(1179260496u);
					int num10;
					if (num5 < num6)
					{
						num = -736491502;
						num10 = num;
					}
					else
					{
						num = -561321513;
						num10 = num;
					}
					continue;
				}
				case 4u:
					obj._184044A093C04AF2(135, 3277890358u);
					array = _20674E36A0DB4FE2((object)P_0, num7);
					num = (int)(num3 * 297993477) ^ -1579995476;
					continue;
				case 14u:
				{
					int num8;
					int num9;
					if (num7 >= _003CModule_003E._3F57E81A62734AC2<int>((int)(0x164B0497 ^ obj._184044A093C04AF2(1, 2352863177u))))
					{
						num8 = 1164048874;
						num9 = num8;
					}
					else
					{
						num8 = 7728386;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -2043565866);
					continue;
				}
				case 2u:
					EBE3F333E7FC48CC((object)this, Guid.Parse(C7474C83080D43B1((object)P_0)));
					num = ((int)num3 * -1237919921) ^ -913028230;
					continue;
				case 3u:
					obj._184044A093C04AF2(132, 3681966326u);
					obj._184044A093C04AF2(137, 3303086518u);
					num = 1639782113;
					continue;
				case 1u:
					obj._184044A093C04AF2(7, 89624048u);
					obj._184044A093C04AF2(5, 608718352u);
					obj._184044A093C04AF2(6, 3273342841u);
					num5 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1452133166 ^ (int)obj._184044A093C04AF2(8, 319939600u));
					num = ((int)num3 * -137278922) ^ -1467044595;
					continue;
				case 8u:
					num6 = _8FF057E9A3274C47((object)P_0);
					E7DDA1744B9F415C((object)this).Clear();
					num = (int)((num3 * 1932350815) ^ 0x55651798);
					continue;
				case 9u:
					E7DDA1744B9F415C((object)this).Add((_23AFFD5168C1458B)_40978A4313F447C3(num4, array));
					num5 += _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x6569348B ^ obj._184044A093C04AF2(10, 1426784105u)));
					num = -28326468;
					continue;
				case 0u:
					obj._184044A093C04AF2(134, 616444534u);
					num = ((int)num3 * -674055451) ^ -1867551363;
					continue;
				default:
					obj._184044A093C04AF2(4, 2189817648u);
					return;
				}
				break;
			}
		}
	}

	static void EBE3F333E7FC48CC(object P_0, Guid P_1)
	{
		((_83D3069491A44F2C)P_0)._9C34C722140546A5 = P_1;
	}

	static void _41C387F4B0B24C52(object P_0, float P_1)
	{
		((_83D3069491A44F2C)P_0)._8EA8906D14BA436B = P_1;
	}

	static void DD26A66505EE46ED(object P_0, List<_23AFFD5168C1458B> P_1)
	{
		((_83D3069491A44F2C)P_0).E4E7403BB0914C51 = P_1;
	}

	static Guid A361DDC8E763457B(object P_0)
	{
		return ((_83D3069491A44F2C)P_0)._9C34C722140546A5;
	}

	static void _8D7D6889C4E84F62(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static float _185F0140315445F2(object P_0)
	{
		return ((_83D3069491A44F2C)P_0)._8EA8906D14BA436B;
	}

	static void E6DBCDCDBE6048CB(object P_0, float P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static List<_23AFFD5168C1458B> E7DDA1744B9F415C(object P_0)
	{
		return ((_83D3069491A44F2C)P_0).E4E7403BB0914C51;
	}

	static void DE75C0031C974A9D(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static long _432E7685B9ED409E(object P_0)
	{
		return ((_23AFFD5168C1458B)P_0)._91FF26BE8B674506;
	}

	static void _159ED7FBCCD14EA6(object P_0, long P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static byte[] _53BB41EB31704684(object P_0)
	{
		return ((_23AFFD5168C1458B)P_0)._970C081BF3CA45E7;
	}

	static void EC4DCD46C4C04AEF(object P_0, byte[] P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string C7474C83080D43B1(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static float _66BE5EC54D1A4E29(object P_0)
	{
		return ((BinaryReader)P_0).ReadSingle();
	}

	static int _8FF057E9A3274C47(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	static long C9632F3C5D2649F6(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt64();
	}

	static byte[] _20674E36A0DB4FE2(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}

	static object _40978A4313F447C3(long P_0, byte[] P_1)
	{
		return new _23AFFD5168C1458B(P_0, P_1);
	}
}
