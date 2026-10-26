using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class _9E7CD8E645DD49BC : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid _28CCF8C68C574135;

	public Guid BE6ED36A04954AB0
	{
		[CompilerGenerated]
		get
		{
			return _28CCF8C68C574135;
		}
		[CompilerGenerated]
		set
		{
			_28CCF8C68C574135 = guid;
		}
	}

	public _9E7CD8E645DD49BC()
	{
	}

	public _9E7CD8E645DD49BC(Guid P_0)
	{
		while (true)
		{
			int num = 1815789336;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~(num2 - ((247441469 - 956826287 * -unchecked(-723979106 * 1772904613) + unchecked(748398724 + unchecked(~1719308311 - (-318174219 + 1661999521)) + 1458299128) + -(-unchecked(unchecked(-667721619 * (966696926 - 1335242128)) * -1823396693))) ^ (~-1338354148 - ~(~(-443208006 ^ 0x9B2D7C7) - 1038093574) - -(--817178448))))))) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_009b;
				case 2u:
					return;
				}
				break;
				IL_009b:
				_7DD56426BAE549B3((object)this, P_0);
				num = ((int)num3 * -2028872105) ^ 0x73BADFFE;
			}
		}
	}

	public virtual void _915104B8B33141C3(BinaryWriter P_0)
	{
		_5C7092CA35A841D5((object)P_0, _60B90038E2D540DD((object)this).ToString());
	}

	public virtual void _7AE21D88A8A84BBC(BinaryReader P_0)
	{
		_9BD8C00A4F44442F((object)P_0);
		_9BD8C00A4F44442F((object)this);
	}

	static void _7DD56426BAE549B3(object P_0, Guid P_1)
	{
		((_9E7CD8E645DD49BC)P_0).BE6ED36A04954AB0 = P_1;
	}

	static Guid _60B90038E2D540DD(object P_0)
	{
		return ((_9E7CD8E645DD49BC)P_0).BE6ED36A04954AB0;
	}

	static void _5C7092CA35A841D5(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _9BD8C00A4F44442F(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
