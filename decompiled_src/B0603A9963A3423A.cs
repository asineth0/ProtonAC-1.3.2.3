using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class B0603A9963A3423A : _652C34B1E6554F10
{
	[CompilerGenerated]
	private bool _88F26D42CA14488D;

	[CompilerGenerated]
	private byte[] DB53C520F2C740FC = Array.Empty<byte>();

	public bool _8C112B84978C478E
	{
		[CompilerGenerated]
		get
		{
			return _88F26D42CA14488D;
		}
		[CompilerGenerated]
		set
		{
			_88F26D42CA14488D = flag;
		}
	}

	public byte[] BD195F36B8F043BD
	{
		[CompilerGenerated]
		get
		{
			return DB53C520F2C740FC;
		}
		[CompilerGenerated]
		set
		{
			DB53C520F2C740FC = dB53C520F2C740FC;
		}
	}

	public B0603A9963A3423A()
	{
	}

	public B0603A9963A3423A(bool P_0, byte[]? P_1 = null)
	{
		_2C0F27A0EB4346D8((object)this, P_0);
		_99E9DF4E3C0049B0((object)this, P_1 ?? Array.Empty<byte>());
	}

	public virtual void _8344C4D7930D4C7D(BinaryWriter P_0)
	{
		_4E3C969E301240C5((object)P_0, _23F2AF3C0D694FA5((object)this));
		_98E4C1C4EE02417A((object)P_0, BA60CFB74223445C((object)this).Length);
		while (true)
		{
			int num = 753101678;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~(num2 * -1632185831 + ~(-720223339 * -845162453 - unchecked(-53180201 * ~(-2139630613 - -1736356731))) * 2140930169)) - (unchecked(-1280782559 * unchecked(2103123783 - -1134236653)) - ~(885279764 - -534234085)))) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0086;
				case 2u:
					return;
				}
				break;
				IL_0086:
				_84348AF1E05F42D8((object)P_0, BA60CFB74223445C((object)this));
				num = (int)(num3 * 231594593) ^ -1438713946;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _284C5DDC27124D79(BinaryReader P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(454178139u);
		_2C0F27A0EB4346D8((object)this, _9E601CDAF90140A3((object)P_0));
		int num = DDCF1D14B14244E8((object)P_0);
		if (num < _003CModule_003E._390073C602714496<int>(-1330264393 ^ (int)obj._184044A093C04AF2(1, 18759167u)))
		{
			while (true)
			{
				int num2 = 716316728;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(((((((110047093 * (-unchecked((0x63B2CC2C ^ 0x3E17269F) - ~626489247) ^ -(--733705096 ^ 0x55B05FA0))) ^ -(-unchecked(-438404087 * ~(0x63F3DF98 ^ 0x441CE53C))) ^ (1121793005 * (~(-894341058) + ~unchecked(-102965049 * 410123739) + unchecked(-1529550907 * unchecked(unchecked(-1064738205 + -1849479312) * -740622993)) + -1374907008))) - num3) ^ -(-(-(-(~1141174214))) - (-(0x882F1A8 ^ 0x41DD262F) ^ -86757801))) - 456965677 * -(~(259216596 - ~301795696))) ^ 0x7358294B ^ -1580398428) * -1690790639 * -912828017 * -1695376133)) % 5)
					{
					case 0u:
						break;
					case 2u:
						return;
					case 4u:
						_99E9DF4E3C0049B0((object)this, Array.Empty<byte>());
						num2 = ((int)num4 * -386283437) ^ 0x41AF0A72;
						continue;
					case 1u:
						obj = new _81DD83B8AA2247AA(2129087405u);
						num2 = (int)((num4 * 431798649) ^ 0x338C1206);
						continue;
					default:
						goto end_IL_003d;
					}
					break;
				}
				continue;
				end_IL_003d:
				break;
			}
		}
		obj = new _81DD83B8AA2247AA(101688106u);
		_99E9DF4E3C0049B0((object)this, _274D8E0F83D646C2((object)P_0, num));
	}

	static void _2C0F27A0EB4346D8(object P_0, bool P_1)
	{
		((B0603A9963A3423A)P_0)._8C112B84978C478E = P_1;
	}

	static void _99E9DF4E3C0049B0(object P_0, byte[] P_1)
	{
		((B0603A9963A3423A)P_0).BD195F36B8F043BD = P_1;
	}

	static bool _23F2AF3C0D694FA5(object P_0)
	{
		return ((B0603A9963A3423A)P_0)._8C112B84978C478E;
	}

	static void _4E3C969E301240C5(object P_0, bool P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static byte[] BA60CFB74223445C(object P_0)
	{
		return ((B0603A9963A3423A)P_0).BD195F36B8F043BD;
	}

	static void _98E4C1C4EE02417A(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static void _84348AF1E05F42D8(object P_0, byte[] P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static bool _9E601CDAF90140A3(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}

	static int DDCF1D14B14244E8(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	static byte[] _274D8E0F83D646C2(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}
}
