using System.IO;
using System.Runtime.CompilerServices;

internal class FBFDE69E8DC9496E : _652C34B1E6554F10
{
	[CompilerGenerated]
	private long CD1479C6587B4E2B;

	[CompilerGenerated]
	private long _80490619E92B4965;

	public long _1C57B08C9C8140F8
	{
		[CompilerGenerated]
		get
		{
			return CD1479C6587B4E2B;
		}
		[CompilerGenerated]
		set
		{
			CD1479C6587B4E2B = cD1479C6587B4E2B;
		}
	}

	public long _5E1B9FCB44414AFE
	{
		[CompilerGenerated]
		get
		{
			return _80490619E92B4965;
		}
		[CompilerGenerated]
		set
		{
			_80490619E92B4965 = num;
		}
	}

	public FBFDE69E8DC9496E()
	{
	}

	public FBFDE69E8DC9496E(long P_0, long P_1)
	{
		_044450CA08A24914((object)this, P_0);
		_9FEBEB060D8E454B((object)this, P_1);
	}

	public virtual void _46E3BDABE5F94AAB(BinaryWriter P_0)
	{
		C1703607BC8B4F3B((object)P_0, _5982284B018A45FA((object)this));
		while (true)
		{
			int num = -999369235;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(~(~((num2 ^ (-1852115658 ^ (-(-115596375 * 462998815) ^ 0x6004FAC9) ^ (-(1444180648 + 423774148) + -unchecked(-1572133980 - 1681909613) + unchecked(~(-1291535151 ^ -745733905) * 922423073) - (unchecked(122338895 * (unchecked(-1767539156 + -1397520886) - (0x4615E284 ^ -2007863016))) - unchecked(1187099187 * unchecked(~2096880987 - (-1582606937 ^ -1405233273))))) ^ ((-1695290699 ^ -unchecked(-22507240 - -1341372771 + unchecked(-1788217784 * 612734139))) + -205114614 - ~((--715544731 - unchecked(unchecked(-2084927025 - 2054987572) * -1138733543)) * 1969958925)))) - unchecked(1242305581 * ~unchecked(-1629289069 * unchecked(672453713 * (-1663546447 ^ 0x17240D51)))))) - ~((-1100700220 ^ 0x623F00D9) + ~264097355))) * -271359333)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0144;
				case 2u:
					return;
				}
				break;
				IL_0144:
				C1703607BC8B4F3B((object)P_0, _4CDBB6835FAE45A6((object)this));
				num = (int)((num3 * 2055329168) ^ 0x3E4BB819);
			}
		}
	}

	public virtual void _4097D1F80C0B40C4(BinaryReader P_0)
	{
		E715992AD893407A((object)P_0);
		E715992AD893407A((object)this);
		E715992AD893407A((object)P_0);
		E715992AD893407A((object)this);
	}

	static void _044450CA08A24914(object P_0, long P_1)
	{
		((FBFDE69E8DC9496E)P_0)._1C57B08C9C8140F8 = P_1;
	}

	static void _9FEBEB060D8E454B(object P_0, long P_1)
	{
		((FBFDE69E8DC9496E)P_0)._5E1B9FCB44414AFE = P_1;
	}

	static long _5982284B018A45FA(object P_0)
	{
		return ((FBFDE69E8DC9496E)P_0)._1C57B08C9C8140F8;
	}

	static void C1703607BC8B4F3B(object P_0, long P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static long _4CDBB6835FAE45A6(object P_0)
	{
		return ((FBFDE69E8DC9496E)P_0)._5E1B9FCB44414AFE;
	}

	static long E715992AD893407A(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt64();
	}
}
