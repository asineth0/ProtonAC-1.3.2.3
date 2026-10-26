using System.IO;
using System.Runtime.CompilerServices;

internal class _88390874E8FB49A6 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string _260ACFDF4EF34EFA;

	[CompilerGenerated]
	private bool _128684C72DB74153;

	[CompilerGenerated]
	private string A34D4ABBF2944591;

	public override byte _1F2EDFE19FDC44F7
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-1757846753 ^ (int)new _81DD83B8AA2247AA(886569166u)._184044A093C04AF2(5, 4231946813u));
		}
	}

	public string DAB152945E7F4A13
	{
		[CompilerGenerated]
		get
		{
			return _260ACFDF4EF34EFA;
		}
		[CompilerGenerated]
		set
		{
			_260ACFDF4EF34EFA = text;
		}
	}

	public bool _22793DB4CFA144F7
	{
		[CompilerGenerated]
		get
		{
			return _128684C72DB74153;
		}
		[CompilerGenerated]
		set
		{
			_128684C72DB74153 = flag;
		}
	}

	public string _20AF4A89563B474E
	{
		[CompilerGenerated]
		get
		{
			return A34D4ABBF2944591;
		}
		[CompilerGenerated]
		set
		{
			A34D4ABBF2944591 = a34D4ABBF;
		}
	}

	public _88390874E8FB49A6()
	{
	}

	public _88390874E8FB49A6(string P_0, bool P_1, string P_2)
	{
		F22D735B7D1041F0((object)this, P_0);
		_88621FEAD32A4AA0((object)this, P_1);
		BD82DA760CFB434B((object)this, P_2);
	}

	public virtual void _24AE795AB0F54032(BinaryWriter P_0)
	{
		CC4084F0ABD946B2((object)P_0, _9092192F42924AA7((object)this));
		_9B3ECD15898A4D36((object)P_0, _0131BF9585CE460C((object)this));
		CC4084F0ABD946B2((object)P_0, _54B7D26C337B40CB((object)this));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _86F0F6D44C374AE7(BinaryReader P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3823920160u);
		F22D735B7D1041F0((object)this, _96D11BA17AA44C20((object)P_0));
		_88621FEAD32A4AA0((object)this, _26DD087B560B4377((object)P_0));
		if (_8C1151F9E5DA4875((object)this) >= _003CModule_003E._58ECCB512F2A43AC<int>((int)(0x4B0EF1B ^ obj._184044A093C04AF2(1, 3447677105u))))
		{
			while (true)
			{
				int num = -176488357;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(~(~(~((num2 ^ -(~(unchecked(-647465381 - unchecked((-720775613 ^ 0x1A6BD54E) - (1140626161 + 587979137))) - ~(-unchecked(-1156237600 + -1327879456))) ^ -1679636864) ^ (-((0x2A57D8FB ^ 0x2E7E7C89) + -232329206) + (-((-1617509947 ^ -43266567) - ~(~188497111)) - 188002366))) - -1198005115 * -unchecked(-2027016138 * 1884209135) - -962991945 * -unchecked(-65003005 - 1881438191 - (0x14517FD ^ 0x6DC74C9F)))))))) % 4)
					{
					case 3u:
						break;
					case 1u:
						obj = new _81DD83B8AA2247AA(3591198838u);
						num = (int)(num3 * 138151145) ^ -89776831;
						continue;
					case 0u:
						BD82DA760CFB434B((object)this, _96D11BA17AA44C20((object)P_0));
						return;
					default:
						goto end_IL_0047;
					}
					break;
				}
				continue;
				end_IL_0047:
				break;
			}
		}
		BD82DA760CFB434B((object)this, _003CModule_003E._58ECCB512F2A43AC<string>(-1405374634 ^ (int)obj._184044A093C04AF2(1, 2368600553u)));
	}

	static void F22D735B7D1041F0(object P_0, string P_1)
	{
		((_88390874E8FB49A6)P_0).DAB152945E7F4A13 = P_1;
	}

	static void _88621FEAD32A4AA0(object P_0, bool P_1)
	{
		((_88390874E8FB49A6)P_0)._22793DB4CFA144F7 = P_1;
	}

	static void BD82DA760CFB434B(object P_0, string P_1)
	{
		((_88390874E8FB49A6)P_0)._20AF4A89563B474E = P_1;
	}

	static string _9092192F42924AA7(object P_0)
	{
		return ((_88390874E8FB49A6)P_0).DAB152945E7F4A13;
	}

	static void CC4084F0ABD946B2(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static bool _0131BF9585CE460C(object P_0)
	{
		return ((_88390874E8FB49A6)P_0)._22793DB4CFA144F7;
	}

	static void _9B3ECD15898A4D36(object P_0, bool P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _54B7D26C337B40CB(object P_0)
	{
		return ((_88390874E8FB49A6)P_0)._20AF4A89563B474E;
	}

	static string _96D11BA17AA44C20(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static bool _26DD087B560B4377(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}

	static byte _8C1151F9E5DA4875(object P_0)
	{
		return ((_652C34B1E6554F10)P_0)._167F9F1911004A0F;
	}
}
