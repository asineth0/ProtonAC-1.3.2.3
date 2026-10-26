using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class _6BD76CD39E2A4E73 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid DE9A6627F2E848C0;

	[CompilerGenerated]
	private byte[] _8382F19FF8D04F43 = Array.Empty<byte>();

	public Guid FFF25575EFCC42D4
	{
		[CompilerGenerated]
		get
		{
			return DE9A6627F2E848C0;
		}
		[CompilerGenerated]
		set
		{
			DE9A6627F2E848C0 = dE9A6627F2E848C;
		}
	}

	public byte[] _7B4BD7A07B534357
	{
		[CompilerGenerated]
		get
		{
			return _8382F19FF8D04F43;
		}
		[CompilerGenerated]
		set
		{
			_8382F19FF8D04F43 = array;
		}
	}

	public _6BD76CD39E2A4E73()
	{
	}

	public _6BD76CD39E2A4E73(Guid P_0, byte[] P_1)
	{
		while (true)
		{
			int num = -870734695;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~((-1461718379 ^ 0x54C30A56) + unchecked(unchecked(-431720074 - 1794747855) - (0x522D7C57 ^ -834246398)) - (-(-num2) + (-(-(-(~942931871))) + 100027051)) * 1347308903)) ^ 0xAB0EAD5)) % 3)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0079;
				case 2u:
					return;
				}
				break;
				IL_0079:
				E972A046BD854B6A((object)this, P_0);
				_76579FF40D3746BE((object)this, P_1);
				num = (int)((num3 * 137375840) ^ 0x2975CE5B);
			}
		}
	}

	public virtual void _6AB1D9171C2542C1(BinaryWriter P_0)
	{
		_87DDB43AC1DD4229((object)P_0, _5DEC8ADA12F948F4((object)this).ToString());
		while (true)
		{
			int num = -219663054;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((1251711965 + unchecked((-1525398509 + 1274871606) * 562530393) - (((-num2 ^ 0x12644B64) + -(--1864056917)) ^ -810113030)) ^ -958295817) * 437446711 + -1474513919)) % 4)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					FEDDF68666404032((object)P_0, _27FE729A12224CA0((object)this).Length);
					num = ((int)num3 * -949062542) ^ -2054746597;
					continue;
				case 0u:
					FFC79A7C0C42423B((object)P_0, _27FE729A12224CA0((object)this));
					num = ((int)num3 * -43784993) ^ 0x75B1234F;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _6E4A352F7129408B(BinaryReader P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3471402397u);
		E972A046BD854B6A((object)this, Guid.Parse(_7E589C7200FE4DB7((object)P_0)));
		int num = _4604641393E946E3((object)P_0);
		if (num < _003CModule_003E._8B9C7B12B1AE4949<int>((int)(0x508656F9 ^ obj._184044A093C04AF2(0, 3666624336u))))
		{
			while (true)
			{
				int num2 = 740812990;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(-(((-((-782501168 + 93336089 - --1772974799 - -(-721403143)) ^ ((-950634274 ^ -543386971) - (-970510119 + -548843849) + (--1787654705 + (1153715269 + -1414464445)))) - (num3 - -(-(-(-(--1663077723)) + (~(~-2012288980) - unchecked(-1166369177 * (-764384598 + -1237042737))) + 1057374782)) - -(~1031507893))) ^ -(0x4F0C26E0 ^ (-1156875957 + (0x26E52A09 ^ -2146387615)))) - (~(~-142064839) + -(--910609001))) * -1088668825 * -754394603)) % 4)
					{
					case 0u:
						break;
					case 2u:
						obj = new _81DD83B8AA2247AA(2969794046u);
						_76579FF40D3746BE((object)this, Array.Empty<byte>());
						num2 = ((int)num4 * -1907878444) ^ 0xD49C70F;
						continue;
					case 3u:
						return;
					default:
						goto end_IL_0042;
					}
					break;
				}
				continue;
				end_IL_0042:
				break;
			}
		}
		obj = new _81DD83B8AA2247AA(4237511338u);
		_76579FF40D3746BE((object)this, _05D8F2EA44C94C71((object)P_0, num));
	}

	static void E972A046BD854B6A(object P_0, Guid P_1)
	{
		((_6BD76CD39E2A4E73)P_0).FFF25575EFCC42D4 = P_1;
	}

	static void _76579FF40D3746BE(object P_0, byte[] P_1)
	{
		((_6BD76CD39E2A4E73)P_0)._7B4BD7A07B534357 = P_1;
	}

	static Guid _5DEC8ADA12F948F4(object P_0)
	{
		return ((_6BD76CD39E2A4E73)P_0).FFF25575EFCC42D4;
	}

	static void _87DDB43AC1DD4229(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static byte[] _27FE729A12224CA0(object P_0)
	{
		return ((_6BD76CD39E2A4E73)P_0)._7B4BD7A07B534357;
	}

	static void FEDDF68666404032(object P_0, int P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static void FFC79A7C0C42423B(object P_0, byte[] P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _7E589C7200FE4DB7(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static int _4604641393E946E3(object P_0)
	{
		return ((BinaryReader)P_0).ReadInt32();
	}

	static byte[] _05D8F2EA44C94C71(object P_0, int P_1)
	{
		return ((BinaryReader)P_0).ReadBytes(P_1);
	}
}
