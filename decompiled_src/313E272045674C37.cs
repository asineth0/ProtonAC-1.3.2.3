using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

internal class _313E272045674C37 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private _6C63CD6C48F7495C _443AC13DA7A64F7E;

	[CompilerGenerated]
	private List<_0D2DBD97EB44499A> _45E4AA58D15C4332;

	public _6C63CD6C48F7495C BF01A1C09D414E4D
	{
		[CompilerGenerated]
		get
		{
			return _443AC13DA7A64F7E;
		}
		[CompilerGenerated]
		set
		{
			_443AC13DA7A64F7E = obj;
		}
	}

	public List<_0D2DBD97EB44499A> _2BEC0921CD60413F
	{
		[CompilerGenerated]
		get
		{
			return _45E4AA58D15C4332;
		}
		[CompilerGenerated]
		set
		{
			_45E4AA58D15C4332 = list;
		}
	}

	public _313E272045674C37()
	{
		List<_0D2DBD97EB44499A> list = null;
		_45E4AA58D15C4332 = list;
	}

	public _313E272045674C37(_6C63CD6C48F7495C P_0, List<_0D2DBD97EB44499A> P_1)
	{
		_45E4AA58D15C4332 = new List<_0D2DBD97EB44499A>();
		base._002Ector();
		B50A109203F143DD((object)this, P_0);
		_432DF5EB6D7A4611((object)this, P_1);
	}

	public virtual void _0DB85FAE87F94445(BinaryWriter P_0)
	{
		_5703A77724844E81((object)P_0, (byte)_755D26E00FD2430D((object)this));
		_0B7D34B92A724BD5((object)P_0, _527C99F682984309((object)this).Count);
		using List<_0D2DBD97EB44499A>.Enumerator enumerator = _527C99F682984309((object)this).GetEnumerator();
		_0D2DBD97EB44499A current = default;
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = -864673294;
				num2 = num;
			}
			else
			{
				num = 1171682716;
				num2 = num;
			}
			while (true)
			{
				int num3 = num;
				uint num4;
				switch ((num4 = (uint)(((num3 + -(-(-(unchecked(1084845619 * unchecked(1092304754 + 1513847101)) + -1527712647) ^ 0x149A543B))) * 847388409 * 725881759 * -2048239811 + (0x55386678 ^ (--1367903616 + 1965938609))) ^ 0x2B7492C5)) % 8)
				{
				case 0u:
					num = 1171682716;
					continue;
				default:
					return;
				case 4u:
					_5A51613291124BE1(P_0, EC7CD85D6EEE45FA((object)current), BC89D032175544A0((object)current));
					num = ((int)num4 * -872134447) ^ 0x47DF73FA;
					continue;
				case 1u:
					B12EA4FE1B7747AE((object)P_0, F4B4423D6EFB4ECC((object)current));
					num = 1603848789;
					continue;
				case 6u:
					break;
				case 2u:
				{
					int num5;
					int num6;
					if (EC7CD85D6EEE45FA((object)current) == null)
					{
						num5 = 379420934;
						num6 = num5;
					}
					else
					{
						num5 = -818758271;
						num6 = num5;
					}
					num = num5 ^ (int)(num4 * 139493419);
					continue;
				}
				case 3u:
					num = ((int)num4 * -1774520559) ^ 0x24E41896;
					continue;
				case 5u:
					current = enumerator.Current;
					B12EA4FE1B7747AE((object)P_0, E347E21102DA4D2D((object)current));
					B12EA4FE1B7747AE((object)P_0, _2E5CB92E4338462F((object)current));
					num = 1021660993;
					continue;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void _5A51613291124BE1(BinaryWriter P_0, byte[] P_1, int P_2)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2787358145u);
		uint num = (uint)P_2;
		while (true)
		{
			int num2 = 1895840200;
			while (true)
			{
				int num3 = num2;
				uint num4;
				switch ((num4 = (uint)(~(~(~(~num3)) * -526557327))) % 5)
				{
				case 0u:
					break;
				case 1u:
					num2 = (int)(num4 * 1014456207) ^ -393515175;
					continue;
				case 2u:
				{
					uint num6 = num;
					obj._184044A093C04AF2(11, 3379725987u);
					obj._184044A093C04AF2(6, 2779827967u);
					obj._184044A093C04AF2(9, 1821659165u);
					int num7;
					if (num6 >= (uint)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x643DD1 ^ obj._184044A093C04AF2(0, 46795455u))))
					{
						num2 = 1039124467;
						num7 = num2;
					}
					else
					{
						num2 = 1473360086;
						num7 = num2;
					}
					continue;
				}
				case 3u:
				{
					_5703A77724844E81((object)P_0, (byte)(num | (uint)_003CModule_003E._58ECCB512F2A43AC<int>(-191216086 ^ (int)obj._184044A093C04AF2(10, 2385001911u))));
					uint num5 = num;
					obj._184044A093C04AF2(8, 46795455u);
					obj._184044A093C04AF2(3, 915241309u);
					obj._184044A093C04AF2(9, 2473308131u);
					num = num5 >> _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x57822DB8 ^ obj._184044A093C04AF2(10, 731444040u)));
					num2 = -1938196079;
					continue;
				}
				default:
					obj = new _81DD83B8AA2247AA(449948830u);
					_5703A77724844E81((object)P_0, (byte)num);
					_190AF94A3B1947C0((object)P_0, P_1, _003CModule_003E.F84FA79ABE6944BB<int>((int)(0x620E850B ^ obj._184044A093C04AF2(6, 2066750237u))), P_2);
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _5EE5EA6DDE2D4378(BinaryReader P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(4214823379u);
		int num7 = default;
		int num6 = default;
		byte b = default;
		while (true)
		{
			int num = -305892864;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(((((num2 - (-(-unchecked(~unchecked(unchecked(898210351 - -1302226165) + (-87334715 - 1354265219)) * -1597151463)) ^ 0x2ED3E0B3) - ((-(~unchecked(-1473331219 * -1478077624)) ^ (0x1A522E02 ^ -(~(~-1023479936)))) - (-1024596320 ^ (-1814510525 + (-(~1849099363) + -(~1493966505))))) + -(-unchecked((0x597E32FB ^ -1337773504) * -354589377))) ^ -877231897) * 149616597) ^ 0x56079045) * -678707185))) % 9)
				{
				case 8u:
					break;
				case 3u:
					num7 = B4044A67FD5C4360((object)P_0);
					num = -235656179;
					continue;
				case 2u:
					_527C99F682984309((object)this).Add((_0D2DBD97EB44499A)_8343075678FA405D(CE6D8E40DDEC483E((object)P_0), CE6D8E40DDEC483E((object)P_0), CE6D8E40DDEC483E((object)P_0)));
					num6 += _003CModule_003E._3F57E81A62734AC2<int>((int)(0x71B76537 ^ obj._184044A093C04AF2(5, 1245555654u)));
					num = -447580093;
					continue;
				case 5u:
				{
					obj = new _81DD83B8AA2247AA(981825450u);
					int num8;
					if (num6 < num7)
					{
						num = -231971559;
						num8 = num;
					}
					else
					{
						num = 1823171569;
						num8 = num;
					}
					continue;
				}
				case 7u:
					B50A109203F143DD((object)this, (_6C63CD6C48F7495C)_003CModule_003E._390073C602714496<int>(-1617864048 ^ (int)obj._184044A093C04AF2(11, 0u)));
					num = ((int)num3 * -107362028) ^ 0x2D70E787;
					continue;
				case 4u:
					_527C99F682984309((object)this).Clear();
					obj._184044A093C04AF2(10, 30998169u);
					obj._184044A093C04AF2(1, 3013076317u);
					obj._184044A093C04AF2(4, 3838674905u);
					num6 = _003CModule_003E._390073C602714496<int>((int)(0x69A98789 ^ obj._184044A093C04AF2(3, 2475391657u)));
					num = ((int)num3 * -150691747) ^ 0x49E0B003;
					continue;
				case 0u:
				{
					B50A109203F143DD((object)this, (_6C63CD6C48F7495C)b);
					int num4;
					int num5;
					if (!_44C9C799EDE6420F((Type)F1917CF5D7594735(typeof(_6C63CD6C48F7495C).TypeHandle), (object)_755D26E00FD2430D((object)this)))
					{
						num4 = 2100928895;
						num5 = num4;
					}
					else
					{
						num4 = 50554429;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1800818482);
					continue;
				}
				case 1u:
					b = EA6B8145F7934E21((object)P_0);
					num = (int)((num3 * 1943906827) ^ 0x1FC0C80F);
					continue;
				default:
					obj._184044A093C04AF2(8, 870679016u);
					return;
				}
				break;
			}
		}
	}

	static void B50A109203F143DD(object P_0, _6C63CD6C48F7495C P_1)
	{
		((_313E272045674C37)P_0).BF01A1C09D414E4D = P_1;
	}

	static void _432DF5EB6D7A4611(object P_0, List<_0D2DBD97EB44499A> P_1)
	{
		((_313E272045674C37)P_0)._2BEC0921CD60413F = P_1;
	}

	static _6C63CD6C48F7495C _755D26E00FD2430D(object P_0)
	{
		return ((_313E272045674C37)P_0).BF01A1C09D414E4D;
	}

	static void _5703A77724844E81(object P_0, byte P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static List<_0D2DBD97EB44499A> _527C99F682984309(object P_0)
	{
		return ((_313E272045674C37)P_0)._2BEC0921CD60413F;
	}

	static void _0B7D34B92A724BD5(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string E347E21102DA4D2D(object P_0)
	{
		return ((_0D2DBD97EB44499A)P_0).FBE373E21A304DEA;
	}

	static void B12EA4FE1B7747AE(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _2E5CB92E4338462F(object P_0)
	{
		return ((_0D2DBD97EB44499A)P_0).A3D6768BC74A4545;
	}

	static byte[] EC7CD85D6EEE45FA(object P_0)
	{
		return ((_0D2DBD97EB44499A)P_0)._2C6CE46FD430441F;
	}

	static int BC89D032175544A0(object P_0)
	{
		return ((_0D2DBD97EB44499A)P_0).F80F15627D0A40C4;
	}

	static string F4B4423D6EFB4ECC(object P_0)
	{
		return ((_0D2DBD97EB44499A)P_0)._9614B4674EF045C5;
	}

	static void _190AF94A3B1947C0(object P_0, byte[] P_1, int P_2, int P_3)
	{
		((BinaryWriter)P_0).Write(P_1, P_2, P_3);
	}

	static byte EA6B8145F7934E21(object P_0)
	{
		return ((BinaryReader)P_0).ReadByte();
	}

	static object F1917CF5D7594735(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static bool _44C9C799EDE6420F(Type P_0, object P_1)
	{
		return Enum.IsDefined(P_0, P_1);
	}

	static int B4044A67FD5C4360(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	static string CE6D8E40DDEC483E(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static object _8343075678FA405D(string P_0, string P_1, string P_2)
	{
		return new _0D2DBD97EB44499A(P_0, P_1, P_2);
	}
}
