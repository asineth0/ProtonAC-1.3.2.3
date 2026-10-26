using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class _488E817EA4A44E7F : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid _68D5899D136B4EAE;

	[CompilerGenerated]
	private ulong FA210BCB25954075;

	[CompilerGenerated]
	private float _9310A089AC0F4388;

	public Guid _0696A551541147F1
	{
		[CompilerGenerated]
		get
		{
			return _68D5899D136B4EAE;
		}
		[CompilerGenerated]
		set
		{
			_68D5899D136B4EAE = guid;
		}
	}

	public ulong _55ADCC10F4884966
	{
		[CompilerGenerated]
		get
		{
			return FA210BCB25954075;
		}
		[CompilerGenerated]
		set
		{
			FA210BCB25954075 = fA210BCB;
		}
	}

	public float B218E057B31D4251
	{
		[CompilerGenerated]
		get
		{
			return _9310A089AC0F4388;
		}
		[CompilerGenerated]
		set
		{
			_9310A089AC0F4388 = num;
		}
	}

	public _488E817EA4A44E7F()
	{
	}

	public _488E817EA4A44E7F(Guid P_0, ulong P_1, float P_2)
	{
		_58FCA27A892E4A03((object)this, P_0);
		_1B76BD09017D4F5C((object)this, P_1);
		E0CD8F8BE0D0479C((object)this, P_2);
	}

	public virtual void _89F1A3F6AD104F34(BinaryWriter P_0)
	{
		D04E5C57B9654A9D((object)P_0, _2CD73A38C8614C5C((object)this).ToString());
		_7FD80ADE3F374273((object)P_0, _86A79AE7D28B4FBF((object)this));
		A344AF2DF7CA4A2B((object)P_0, B3D45ABF03424E5B((object)this));
	}

	public virtual void _474EF9CDC9B9425A(BinaryReader P_0)
	{
		_58FCA27A892E4A03((object)this, Guid.Parse(A56A1952B5444446((object)P_0)));
		while (true)
		{
			int num = -657868418;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~((((-362467074 ^ -1065756618) - (unchecked(737251407 * 367559905) - -167650484)) ^ ~(~(-903712756))) - ((num2 + (-((1808876945 * -(--940167791) - ((0x46E804FD ^ -1446492763) - --1893845794 - ~(1974759535 - 1517494139))) ^ (-(~-205525918 + (-476419160 + -383221195)) ^ 0xCA8BE33)) - -493435063 * (-(-unchecked(-520471297 + 1981457694 + ~-1852497438)) + -817727265 * -unchecked(-823254873 * (-1195988554 ^ -809816765)))) - (-479936017 ^ ((131089923 * (-(-90677421 ^ 0xCEF71A7) - ~(1206825765 + 221326838))) ^ (-2139499018 ^ (-256320676 + unchecked(1155125785 * -221769103) - -(-1931379401 + 1215692745)))))) ^ -(1152761454 + -570808351))) ^ (-2093685379 + ~-585083101)) + (9372998 + 2088585261) - 1777063999)) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_019d;
				default:
					E0CD8F8BE0D0479C((object)this, _545D739E41DE460D((object)P_0));
					return;
				}
				break;
				IL_019d:
				_1B76BD09017D4F5C((object)this, DFD97529C7D541FC((object)P_0));
				num = (int)(num3 * 930152172) ^ -1751970887;
			}
		}
	}

	static void _58FCA27A892E4A03(object P_0, Guid P_1)
	{
		((_488E817EA4A44E7F)P_0)._0696A551541147F1 = P_1;
	}

	static void _1B76BD09017D4F5C(object P_0, ulong P_1)
	{
		((_488E817EA4A44E7F)P_0)._55ADCC10F4884966 = P_1;
	}

	static void E0CD8F8BE0D0479C(object P_0, float P_1)
	{
		((_488E817EA4A44E7F)P_0).B218E057B31D4251 = P_1;
	}

	static Guid _2CD73A38C8614C5C(object P_0)
	{
		return ((_488E817EA4A44E7F)P_0)._0696A551541147F1;
	}

	static void D04E5C57B9654A9D(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static ulong _86A79AE7D28B4FBF(object P_0)
	{
		return ((_488E817EA4A44E7F)P_0)._55ADCC10F4884966;
	}

	static void _7FD80ADE3F374273(object P_0, ulong P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static float B3D45ABF03424E5B(object P_0)
	{
		return ((_488E817EA4A44E7F)P_0).B218E057B31D4251;
	}

	static void A344AF2DF7CA4A2B(object P_0, float P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string A56A1952B5444446(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static ulong DFD97529C7D541FC(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt64();
	}

	static float _545D739E41DE460D(object P_0)
	{
		return ((BinaryReader)P_0).ReadSingle();
	}
}
