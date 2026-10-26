using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

internal class B165E908635F4A7C : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string _2133505CB071488C;

	[CompilerGenerated]
	private List<string> _7E3AD3CE7E9245A0;

	public string _41EEABA0AD004FA4
	{
		[CompilerGenerated]
		get
		{
			return _2133505CB071488C;
		}
		[CompilerGenerated]
		set
		{
			_2133505CB071488C = text;
		}
	}

	public List<string> A3F9E5C459FD4A47
	{
		[CompilerGenerated]
		get
		{
			return _7E3AD3CE7E9245A0;
		}
		[CompilerGenerated]
		set
		{
			_7E3AD3CE7E9245A0 = list;
		}
	}

	public B165E908635F4A7C()
	{
		List<string> list = null;
		_7E3AD3CE7E9245A0 = list;
	}

	public B165E908635F4A7C(string P_0, List<string> P_1)
	{
		_7E3AD3CE7E9245A0 = new List<string>();
		base._002Ector();
		_4C4E793FF5954CFE((object)this, P_0);
		_0BE07A9424DF483A((object)this, P_1);
	}

	public virtual void _78E81BCCD6AB433A(BinaryWriter P_0)
	{
		E59667C65E6D412E((object)P_0, _22E595F5D1D74595((object)this));
		E7B662955C4D4A78((object)P_0, F7E41439D3154453((object)this).Count);
		using List<string>.Enumerator enumerator = F7E41439D3154453((object)this).GetEnumerator();
		string current = default;
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 1292252394;
				num2 = num;
			}
			else
			{
				num = -1732032523;
				num2 = num;
			}
			while (true)
			{
				int num3 = num;
				uint num4;
				switch ((num4 = (uint)(((-((unchecked(-335537115 * unchecked(-22193697 * (-355992580 ^ 0x6E599C22))) - num3) ^ (~(-(~-757880552) ^ 0x4D3315C2) + ~(-(~-1013609864) + unchecked(774233045 * (-905789520 ^ -2006756471))) - ~(1333183979 * (-1356755770 - (0x6A088015 ^ 0x1301A282)))) ^ 0x7EB31312) ^ -848045503) + -2091200116) * -168134807 - -924726846)) % 5)
				{
				case 3u:
					num = 1292252394;
					continue;
				default:
					return;
				case 1u:
					current = enumerator.Current;
					num = -910477013;
					continue;
				case 4u:
					break;
				case 2u:
					E59667C65E6D412E((object)P_0, current);
					num = (int)((num4 * 697359906) ^ 0x3FB6FDA6);
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void C3A37A6492674BEE(BinaryReader P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(605979995u);
		_4C4E793FF5954CFE((object)this, _938ABF53FBC24125((object)P_0));
		int num4 = default;
		int num5 = default;
		while (true)
		{
			int num = -581621730;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-(num2 ^ -(-1459155853 * -((441442092 + -(0x2A1B5A95 ^ -756733026)) ^ 0x68269707)))))) % 7)
				{
				case 2u:
					break;
				default:
					return;
				case 5u:
					F7E41439D3154453((object)this).Add(_938ABF53FBC24125((object)P_0));
					num4 += _003CModule_003E._3F57E81A62734AC2<int>((int)(0x380F54 ^ obj._184044A093C04AF2(9, 3989976821u)));
					num = -552252063;
					continue;
				case 0u:
					obj._184044A093C04AF2(1, 4274922372u);
					num = ((int)num3 * -1536388172) ^ -923468182;
					continue;
				case 1u:
					F7E41439D3154453((object)this).Clear();
					num5 = _7468F8DB39E04FA5((object)P_0);
					num = ((int)num3 * -602998098) ^ -533993214;
					continue;
				case 3u:
				{
					obj = new _81DD83B8AA2247AA(3904274803u);
					int num6;
					if (num4 < num5)
					{
						num = -753135782;
						num6 = num;
					}
					else
					{
						num = -1792470340;
						num6 = num;
					}
					continue;
				}
				case 4u:
					obj._184044A093C04AF2(4, 3475622248u);
					obj._184044A093C04AF2(7, 3462305768u);
					obj._184044A093C04AF2(5, 1042426125u);
					num4 = _003CModule_003E._8B9C7B12B1AE4949<int>(-463723938 ^ (int)obj._184044A093C04AF2(10, 1484883432u));
					num = ((int)num3 * -1342175900) ^ -656196763;
					continue;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	static void _4C4E793FF5954CFE(object P_0, string P_1)
	{
		((B165E908635F4A7C)P_0)._41EEABA0AD004FA4 = P_1;
	}

	static void _0BE07A9424DF483A(object P_0, List<string> P_1)
	{
		((B165E908635F4A7C)P_0).A3F9E5C459FD4A47 = P_1;
	}

	static string _22E595F5D1D74595(object P_0)
	{
		return ((B165E908635F4A7C)P_0)._41EEABA0AD004FA4;
	}

	static void E59667C65E6D412E(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static List<string> F7E41439D3154453(object P_0)
	{
		return ((B165E908635F4A7C)P_0).A3F9E5C459FD4A47;
	}

	static void E7B662955C4D4A78(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _938ABF53FBC24125(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static int _7468F8DB39E04FA5(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}
}
