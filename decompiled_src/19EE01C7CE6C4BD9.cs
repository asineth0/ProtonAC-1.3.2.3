using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class _19EE01C7CE6C4BD9 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid _02618023E6B44439;

	[CompilerGenerated]
	private ulong _4D802B8B057B4BB9;

	[CompilerGenerated]
	private F9DC65C0B16C4603 C05954863FCB4478;

	public Guid E0A103678DD64EFC
	{
		[CompilerGenerated]
		get
		{
			return _02618023E6B44439;
		}
		[CompilerGenerated]
		set
		{
			_02618023E6B44439 = guid;
		}
	}

	public ulong FDF2C12447CB4E4E
	{
		[CompilerGenerated]
		get
		{
			return _4D802B8B057B4BB9;
		}
		[CompilerGenerated]
		set
		{
			_4D802B8B057B4BB9 = num;
		}
	}

	public F9DC65C0B16C4603 A35E931917974222
	{
		[CompilerGenerated]
		get
		{
			return C05954863FCB4478;
		}
		[CompilerGenerated]
		set
		{
			C05954863FCB4478 = c05954863FCB;
		}
	}

	public _19EE01C7CE6C4BD9()
	{
	}

	public _19EE01C7CE6C4BD9(ulong P_0, Guid P_1, F9DC65C0B16C4603 P_2)
	{
		_0622678C14E0448C((object)this, P_0);
		BD7D33982F3747A4((object)this, P_1);
		BA2D388B2FC949AB((object)this, P_2);
	}

	public virtual void _8AC57B404B334A2C(BinaryWriter P_0)
	{
		_9EBE08DCF3674980((object)P_0, _463FF56F899741D1((object)this).ToString());
		_1F89947EC0AF4BD7((object)P_0, _87FC0BD07A0F4AFA((object)this));
		_98ABDD7572574C26((object)P_0, (byte)_602AD775A7A74949((object)this));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _2D5926C212A64A20(BinaryReader P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3557027785u);
		BD7D33982F3747A4((object)this, Guid.Parse(A4D8C87F1ED547EE((object)P_0)));
		_0622678C14E0448C((object)this, E5393706BF8B4EF9((object)P_0));
		while (true)
		{
			int num = 43519594;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~(~((num2 * -695614921 - (-1191872574 + 1530525476 + ~(-1668175937 * (unchecked(-1643584401 + -1082005486) + --1422417143))) * -52486161) ^ -138814483)) - unchecked(1445781765 - (-535041489 + -1384849044)) - (73541775 - -475391971)))) % 4)
				{
				case 3u:
					break;
				case 1u:
				{
					byte b = _44928D55A6154C1B((object)P_0);
					BA2D388B2FC949AB((object)this, (F9DC65C0B16C4603)b);
					int num4;
					int num5;
					if (!_4BB26A73257645E2((Type)A907F8BB9D764021(typeof(F9DC65C0B16C4603).TypeHandle), (object)_602AD775A7A74949((object)this)))
					{
						num4 = 1642338930;
						num5 = num4;
					}
					else
					{
						num4 = 1685005832;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -909957289);
					continue;
				}
				case 2u:
					BA2D388B2FC949AB((object)this, (F9DC65C0B16C4603)_003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x7F0181E4 ^ obj._184044A093C04AF2(9, 0u))));
					num = (int)((num3 * 529332678) ^ 0x1AEAAA4F);
					continue;
				default:
					obj._184044A093C04AF2(0, 1091866691u);
					return;
				}
				break;
			}
		}
	}

	static void _0622678C14E0448C(object P_0, ulong P_1)
	{
		((_19EE01C7CE6C4BD9)P_0).FDF2C12447CB4E4E = P_1;
	}

	static void BD7D33982F3747A4(object P_0, Guid P_1)
	{
		((_19EE01C7CE6C4BD9)P_0).E0A103678DD64EFC = P_1;
	}

	static void BA2D388B2FC949AB(object P_0, F9DC65C0B16C4603 P_1)
	{
		((_19EE01C7CE6C4BD9)P_0).A35E931917974222 = P_1;
	}

	static Guid _463FF56F899741D1(object P_0)
	{
		return ((_19EE01C7CE6C4BD9)P_0).E0A103678DD64EFC;
	}

	static void _9EBE08DCF3674980(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static ulong _87FC0BD07A0F4AFA(object P_0)
	{
		return ((_19EE01C7CE6C4BD9)P_0).FDF2C12447CB4E4E;
	}

	static void _1F89947EC0AF4BD7(object P_0, ulong P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static F9DC65C0B16C4603 _602AD775A7A74949(object P_0)
	{
		return ((_19EE01C7CE6C4BD9)P_0).A35E931917974222;
	}

	static void _98ABDD7572574C26(object P_0, byte P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string A4D8C87F1ED547EE(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static ulong E5393706BF8B4EF9(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt64();
	}

	static byte _44928D55A6154C1B(object P_0)
	{
		return ((BinaryReader)P_0).ReadByte();
	}

	static object A907F8BB9D764021(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static bool _4BB26A73257645E2(Type P_0, object P_1)
	{
		return Enum.IsDefined(P_0, P_1);
	}
}
