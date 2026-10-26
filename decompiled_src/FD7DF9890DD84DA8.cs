using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class FD7DF9890DD84DA8 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string _00E52B093A1A4A30;

	[CompilerGenerated]
	private B79532442FF34B1B AB5C54C26EAA4726;

	public string CC1467C209C647B9
	{
		[CompilerGenerated]
		get
		{
			return _00E52B093A1A4A30;
		}
		[CompilerGenerated]
		set
		{
			_00E52B093A1A4A30 = text;
		}
	}

	public B79532442FF34B1B _34CF1F32D50A406C
	{
		[CompilerGenerated]
		get
		{
			return AB5C54C26EAA4726;
		}
		[CompilerGenerated]
		set
		{
			AB5C54C26EAA4726 = aB5C54C26EAA;
		}
	}

	public FD7DF9890DD84DA8()
	{
	}

	public FD7DF9890DD84DA8(string P_0, B79532442FF34B1B P_1)
	{
		_2DCFAD1E4DCE4918((object)this, P_0);
		_8095EC6E27364262((object)this, P_1);
	}

	public virtual void E746B3BD7EFB4B56(BinaryWriter P_0)
	{
		_25A6DA6B7540429E((object)P_0, _1A23251673B44AB5((object)this));
		D921A32BC20C4FD0((object)P_0, (byte)C89A7923D5A948AA((object)this));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _50855B213E4E42DA(BinaryReader P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(2867490538u);
		_2DCFAD1E4DCE4918((object)this, A8525943A4D840E0((object)P_0));
		while (true)
		{
			int num = -1081088246;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((~num2 - -(-685733589 ^ -(~(466608649 + -1631440878 + unchecked(-830570733 - 2138696547))))) ^ -2058665398) - ~unchecked(443045765 * (-610841688 - -547937534 + -242760651)) - -684705716 + ~(~-982993939))) % 4)
				{
				case 0u:
					break;
				case 3u:
				{
					byte b = D3EEEFE7CB0D4A52((object)P_0);
					_8095EC6E27364262((object)this, (B79532442FF34B1B)b);
					int num4;
					int num5;
					if (!_487AD64D74634C01((Type)E4FEF48D90284CB3(typeof(B79532442FF34B1B).TypeHandle), (object)C89A7923D5A948AA((object)this)))
					{
						num4 = 2054169874;
						num5 = num4;
					}
					else
					{
						num4 = -1572934359;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -1089390702);
					continue;
				}
				case 1u:
					_8095EC6E27364262((object)this, (B79532442FF34B1B)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x2D8909EC ^ obj._184044A093C04AF2(8, 0u))));
					num = (int)((num3 * 2135939381) ^ 0x7263211A);
					continue;
				default:
					obj._184044A093C04AF2(10, 174388332u);
					return;
				}
				break;
			}
		}
	}

	static void _2DCFAD1E4DCE4918(object P_0, string P_1)
	{
		((FD7DF9890DD84DA8)P_0).CC1467C209C647B9 = P_1;
	}

	static void _8095EC6E27364262(object P_0, B79532442FF34B1B P_1)
	{
		((FD7DF9890DD84DA8)P_0)._34CF1F32D50A406C = P_1;
	}

	static string _1A23251673B44AB5(object P_0)
	{
		return ((FD7DF9890DD84DA8)P_0).CC1467C209C647B9;
	}

	static void _25A6DA6B7540429E(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static B79532442FF34B1B C89A7923D5A948AA(object P_0)
	{
		return ((FD7DF9890DD84DA8)P_0)._34CF1F32D50A406C;
	}

	static void D921A32BC20C4FD0(object P_0, byte P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string A8525943A4D840E0(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static byte D3EEEFE7CB0D4A52(object P_0)
	{
		return ((BinaryReader)P_0).ReadByte();
	}

	static object E4FEF48D90284CB3(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static bool _487AD64D74634C01(Type P_0, object P_1)
	{
		return Enum.IsDefined(P_0, P_1);
	}
}
