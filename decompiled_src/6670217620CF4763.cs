using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

internal class _6670217620CF4763 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string FDE6C5FFF7AD4432;

	[CompilerGenerated]
	private ushort _789E36569F3F4AD4;

	[CompilerGenerated]
	private string CDB28E04972E4BDA;

	[CompilerGenerated]
	private List<Guid> F3793A6FE0B74F1B;

	[CompilerGenerated]
	private bool _015B873AEE544062;

	[CompilerGenerated]
	private string DA5215C12BE3405F;

	public override byte _1F2EDFE19FDC44F7
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1682812385 ^ (int)new _81DD83B8AA2247AA(3222749216u)._184044A093C04AF2(10, 1604676344u));
		}
	}

	public string AE3D51FAF62C46E5
	{
		[CompilerGenerated]
		get
		{
			return FDE6C5FFF7AD4432;
		}
		[CompilerGenerated]
		set
		{
			FDE6C5FFF7AD4432 = fDE6C5FFF7AD;
		}
	}

	public ushort _24A69A4D8BDB49B3
	{
		[CompilerGenerated]
		get
		{
			return _789E36569F3F4AD4;
		}
		[CompilerGenerated]
		set
		{
			_789E36569F3F4AD4 = num;
		}
	}

	public string _4C1D5609AAD74981
	{
		[CompilerGenerated]
		get
		{
			return CDB28E04972E4BDA;
		}
		[CompilerGenerated]
		set
		{
			CDB28E04972E4BDA = cDB28E04972E4BDA;
		}
	}

	public List<Guid> _0470BC6C3250445B
	{
		[CompilerGenerated]
		get
		{
			return F3793A6FE0B74F1B;
		}
		[CompilerGenerated]
		set
		{
			F3793A6FE0B74F1B = f3793A6FE0B74F1B;
		}
	}

	public bool D44278CE32C645FE
	{
		[CompilerGenerated]
		get
		{
			return _015B873AEE544062;
		}
		[CompilerGenerated]
		set
		{
			_015B873AEE544062 = flag;
		}
	}

	public string _78889B1AF25449F7
	{
		[CompilerGenerated]
		get
		{
			return DA5215C12BE3405F;
		}
		[CompilerGenerated]
		set
		{
			DA5215C12BE3405F = dA5215C12BE3405F;
		}
	}

	public _6670217620CF4763()
	{
		string cDB28E04972E4BDA = null;
		CDB28E04972E4BDA = cDB28E04972E4BDA;
	}

	public _6670217620CF4763(string P_0, ushort P_1, List<Guid> P_2, string P_3, bool P_4, string P_5)
	{
		F3793A6FE0B74F1B = new List<Guid>();
		base._002Ector();
		D4BF62685213471F((object)this, P_0);
		EBAEEEC596C74460((object)this, P_1);
		_6D4F552E2B7A488B((object)this, P_2);
		FBC76E2921494617((object)this, P_3);
		B4D4A942204D4798((object)this, P_4);
		_4B3B6E9FA7BF4674((object)this, P_5);
	}

	public virtual void BE07CC93FF2B4097(BinaryWriter P_0)
	{
		D1D7C5A5C85448A0((object)P_0, A9CC9E35AE7D4949((object)this));
		C84E76F357E54FE0((object)P_0, D62F0E4CB0244CAC((object)this));
		D1D7C5A5C85448A0((object)P_0, _65745582DF494666((object)this));
		while (true)
		{
			int num = -1734720973;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-((0x54673DEE ^ (2102895940 - (unchecked(-1151234063 * unchecked(-704192469 * 1732401086)) + -unchecked(-1414903618 * 1492929403)))) - num2 * 487557553 * 455353441))) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0080;
				default:
				{
					using (List<Guid>.Enumerator enumerator = CCFC33D8B0804A1F((object)this).GetEnumerator())
					{
						while (true)
						{
							IL_0133:
							int num4;
							int num5;
							if (enumerator.MoveNext())
							{
								num4 = -2135443171;
								num5 = num4;
							}
							else
							{
								num4 = 683147888;
								num5 = num4;
							}
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(-((0x54673DEE ^ (2102895940 - (unchecked(-1151234063 * unchecked(-704192469 * 1732401086)) + -unchecked(-1414903618 * 1492929403)))) - num2 * 487557553 * 455353441))) % 4)
								{
								case 0u:
									num4 = -2135443171;
									continue;
								default:
									goto end_IL_00b6;
								case 3u:
									D1D7C5A5C85448A0((object)P_0, enumerator.Current.ToString());
									num4 = -1948389213;
									continue;
								case 1u:
									break;
								case 2u:
									goto end_IL_00b6;
								}
								goto IL_0133;
								continue;
								end_IL_00b6:
								break;
							}
							break;
						}
					}
					_8E5BE57C6EC34FF1((object)P_0, _74F9194672A640B3((object)this));
					D1D7C5A5C85448A0((object)P_0, CB257348749F4C2F((object)this));
					return;
				}
				}
				break;
				IL_0080:
				CB36F5596DB84ECC((object)P_0, CCFC33D8B0804A1F((object)this).Count);
				num = (int)((num3 * 740226022) ^ 0x4F1D0D59);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _21C12DD1285F41F0(BinaryReader P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(32099338u);
		D4BF62685213471F((object)this, A678A7A1876F4891((object)P_0));
		int num7 = default;
		int num6 = default;
		while (true)
		{
			int num = -431438530;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((-(~(582345069 * --466814038)) - (num2 ^ (((2100659967 + (-(-247686259 - 900829011) ^ 0x2F0A1034) - (--668309647 + unchecked(-712254857 * 430263786)) * -2110311205 * 1209183213) ^ 0xCE17A7B) - -((unchecked(-332600104 * 260544797) + (0x24E2A426 ^ -(-284138139 + 408635667))) * -886118595)))) * 1565292015) - (--142834204 - ~-1409352206 + 1389350791) - -710025863 * -2032236337)) % 11)
				{
				case 6u:
					break;
				case 1u:
					num7 = _50BA762ECA4646D4((object)P_0);
					num = ((int)num3 * -297655056) ^ -1456721379;
					continue;
				case 0u:
				{
					obj = new _81DD83B8AA2247AA(675673955u);
					int num8;
					if (num6 >= num7)
					{
						num = -745611285;
						num8 = num;
					}
					else
					{
						num = -877277646;
						num8 = num;
					}
					continue;
				}
				case 9u:
					obj._184044A093C04AF2(0, 443074441u);
					obj._184044A093C04AF2(10, 2233948745u);
					obj._184044A093C04AF2(11, 3675038759u);
					num6 = _003CModule_003E._390073C602714496<int>((int)(0x6C8216E0 ^ obj._184044A093C04AF2(9, 3952278388u)));
					num = ((int)num3 * -1112325633) ^ -1570511902;
					continue;
				case 7u:
					obj = new _81DD83B8AA2247AA(552281318u);
					B4D4A942204D4798((object)this, _306209F97B474FF5((object)P_0));
					_4B3B6E9FA7BF4674((object)this, A678A7A1876F4891((object)P_0));
					return;
				case 5u:
					CCFC33D8B0804A1F((object)this).Add(Guid.Parse(A678A7A1876F4891((object)P_0)));
					num6 += _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x40279557 ^ obj._184044A093C04AF2(1, 805732315u)));
					num = 776426107;
					continue;
				case 4u:
					num = (int)(num3 * 1349028903) ^ -666036040;
					continue;
				case 3u:
					CCFC33D8B0804A1F((object)this).Clear();
					num = ((int)num3 * -2083102897) ^ 0x57AFB0FA;
					continue;
				case 8u:
					EBAEEEC596C74460((object)this, _98369060260A4A97((object)P_0));
					FBC76E2921494617((object)this, A678A7A1876F4891((object)P_0));
					num = (int)((num3 * 382578094) ^ 0x57A7E874);
					continue;
				case 2u:
				{
					int num4;
					int num5;
					if (CCE0D862E48845CF((object)this) < _003CModule_003E.F84FA79ABE6944BB<int>(-1771666553 ^ (int)obj._184044A093C04AF2(4, 3829563843u)))
					{
						num4 = 1738128714;
						num5 = num4;
					}
					else
					{
						num4 = -2028638039;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1255759280);
					continue;
				}
				default:
					B4D4A942204D4798((object)this, (byte)_003CModule_003E._3F57E81A62734AC2<int>((int)(0x773AE164 ^ obj._184044A093C04AF2(5, 4061520383u))) != 0);
					_4B3B6E9FA7BF4674((object)this, _003CModule_003E._8B9C7B12B1AE4949<string>(-1614365900 ^ (int)obj._184044A093C04AF2(2, 3498963874u)));
					return;
				}
				break;
			}
		}
	}

	static void D4BF62685213471F(object P_0, string P_1)
	{
		((_6670217620CF4763)P_0).AE3D51FAF62C46E5 = P_1;
	}

	static void EBAEEEC596C74460(object P_0, ushort P_1)
	{
		((_6670217620CF4763)P_0)._24A69A4D8BDB49B3 = P_1;
	}

	static void _6D4F552E2B7A488B(object P_0, List<Guid> P_1)
	{
		((_6670217620CF4763)P_0)._0470BC6C3250445B = P_1;
	}

	static void FBC76E2921494617(object P_0, string P_1)
	{
		((_6670217620CF4763)P_0)._4C1D5609AAD74981 = P_1;
	}

	static void B4D4A942204D4798(object P_0, bool P_1)
	{
		((_6670217620CF4763)P_0).D44278CE32C645FE = P_1;
	}

	static void _4B3B6E9FA7BF4674(object P_0, string P_1)
	{
		((_6670217620CF4763)P_0)._78889B1AF25449F7 = P_1;
	}

	static string A9CC9E35AE7D4949(object P_0)
	{
		return ((_6670217620CF4763)P_0).AE3D51FAF62C46E5;
	}

	static void D1D7C5A5C85448A0(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static ushort D62F0E4CB0244CAC(object P_0)
	{
		return ((_6670217620CF4763)P_0)._24A69A4D8BDB49B3;
	}

	static void C84E76F357E54FE0(object P_0, ushort P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _65745582DF494666(object P_0)
	{
		return ((_6670217620CF4763)P_0)._4C1D5609AAD74981;
	}

	static List<Guid> CCFC33D8B0804A1F(object P_0)
	{
		return ((_6670217620CF4763)P_0)._0470BC6C3250445B;
	}

	static void CB36F5596DB84ECC(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static bool _74F9194672A640B3(object P_0)
	{
		return ((_6670217620CF4763)P_0).D44278CE32C645FE;
	}

	static void _8E5BE57C6EC34FF1(object P_0, bool P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string CB257348749F4C2F(object P_0)
	{
		return ((_6670217620CF4763)P_0)._78889B1AF25449F7;
	}

	static string A678A7A1876F4891(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static ushort _98369060260A4A97(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}

	static int _50BA762ECA4646D4(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	static byte CCE0D862E48845CF(object P_0)
	{
		return ((_652C34B1E6554F10)P_0)._167F9F1911004A0F;
	}

	static bool _306209F97B474FF5(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}
}
