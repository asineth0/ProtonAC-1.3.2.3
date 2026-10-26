using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;

internal class EACC013FD78547C0 : AECA8283EE0E4BAC
{
	private readonly Dictionary<string, object> F7606163E8F34F94 = new Dictionary<string, object>();

	private readonly List<Dictionary<string, object>> B5CB0BD2FEF142DC = new List<Dictionary<string, object>>();

	private byte[]? _62B4834FCE6D44C6;

	private string? _9921BEA35976415D;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EACC013FD78547C0 A45A013EEA564A4F(string P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1444303558u);
		F7606163E8F34F94[_003CModule_003E._3F57E81A62734AC2<string>((int)(0x778E31A0 ^ obj._184044A093C04AF2(4, 874259391u)))] = P_0;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public EACC013FD78547C0 _10254EE96C0B44D7(string P_0)
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(1583721573u);
		F7606163E8F34F94[_003CModule_003E._3F57E81A62734AC2<string>(-1899813272 ^ (int)obj._184044A093C04AF2(10, 896449592u))] = P_0;
		return this;
	}

	public EACC013FD78547C0 _6E7F1E94B801439F(Action<FD59A46B5C464B4B> P_0)
	{
		FD59A46B5C464B4B fD59A46B5C464B4B = (FD59A46B5C464B4B)_5DB2D5EFA0B9416E();
		while (true)
		{
			int num = 149010641;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(~-1774147977 - unchecked(-269285318 - 2103361430)) - (~(-(~(~1291139327))) - (~(-num2) - (1348672421 * -(-1020586222 - 265524506) - unchecked((unchecked(1216382898 - -1241328959) + ~-1297807277) * 580814823)) * -693170843)))) % 3)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0076;
				default:
					B5CB0BD2FEF142DC.Add(_9D04C8FEA47043B9((object)fD59A46B5C464B4B));
					return this;
				}
				break;
				IL_0076:
				P_0(fD59A46B5C464B4B);
				num = ((int)num3 * -323455886) ^ -180389099;
			}
		}
	}

	public EACC013FD78547C0 _4738138DFEF34E61(byte[]? P_0, string P_1)
	{
		_62B4834FCE6D44C6 = P_0;
		_9921BEA35976415D = P_1;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual MultipartFormDataContent _230AA88521FA4146()
	{
		_81DD83B8AA2247AA obj = new _81DD83B8AA2247AA(3718206102u);
		MultipartFormDataContent multipartFormDataContent = (MultipartFormDataContent)_8A077221B53246F3();
		if (B5CB0BD2FEF142DC.Count > _003CModule_003E._58ECCB512F2A43AC<int>(-693096534 ^ (int)obj._184044A093C04AF2(8, 2273162572u)))
		{
			goto IL_003a;
		}
		goto IL_0222;
		IL_003a:
		int num = -2001542518;
		goto IL_003f;
		IL_003f:
		ByteArrayContent byteArrayContent = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(-(~num2) + (-1481544651 - (unchecked(468172599 * -1768440332) + -(61032798 - 1884869554) * 427011143)))) % 10)
			{
			case 2u:
				break;
			case 9u:
				byteArrayContent = (ByteArrayContent)CD3247EE904A4343(_62B4834FCE6D44C6);
				num = ((int)num3 * -1873056334) ^ 0x730D7A56;
				continue;
			case 3u:
			{
				object obj2 = _9D32B207947A4F5C((object)byteArrayContent);
				object obj3 = _25C7375737184FCF(_003CModule_003E._8B9C7B12B1AE4949<string>((int)(0x63F7D004 ^ obj._184044A093C04AF2(6, 488032165u))));
				A4A4E5C9CC56426C(obj3, _003CModule_003E._8B9C7B12B1AE4949<string>(-1490555180 ^ (int)obj._184044A093C04AF2(6, 2563102930u)));
				string text = _003CModule_003E.F84FA79ABE6944BB<string>(-216842204 ^ (int)obj._184044A093C04AF2(1, 1463895227u));
				string? text2 = _9921BEA35976415D;
				obj._184044A093C04AF2(1, 1353539869u);
				_5C666D3D1A874184(obj3, _4855FD78C3E14F59(text, text2, _003CModule_003E._8B9C7B12B1AE4949<string>(-1430212772 ^ (int)obj._184044A093C04AF2(10, 2245205879u))));
				AF5EEBC6CF8943A4(obj2, obj3);
				_0AACF0F30C694395((object)multipartFormDataContent, (object)byteArrayContent);
				num = ((int)num3 * -272817800) ^ -1728094247;
				continue;
			}
			case 7u:
			{
				int num6;
				int num7;
				if (!BECDCC56F4F14902(_9921BEA35976415D))
				{
					num6 = -1615320023;
					num7 = num6;
				}
				else
				{
					num6 = -1796962277;
					num7 = num6;
				}
				num = num6 ^ ((int)num3 * -1541135954);
				continue;
			}
			case 8u:
				BCCD2C3B99EC4EDA(_9D32B207947A4F5C((object)byteArrayContent), BA3370CCDB2F4FCC(_003CModule_003E._3F57E81A62734AC2<string>((int)(0x1D6E53B5 ^ obj._184044A093C04AF2(9, 1477532200u)))));
				num = (int)((num3 * 1796691928) ^ 0x66EC1F05);
				continue;
			case 5u:
				obj = new _81DD83B8AA2247AA(2856881631u);
				num = -2030323183;
				continue;
			case 6u:
				F7606163E8F34F94[_003CModule_003E.F84FA79ABE6944BB<string>(-2041558088 ^ (int)obj._184044A093C04AF2(7, 0u))] = B5CB0BD2FEF142DC;
				num = (int)((num3 * 1529341118) ^ 0x614F2728);
				continue;
			case 0u:
				goto IL_0222;
			case 4u:
			{
				int num4;
				int num5;
				if (_62B4834FCE6D44C6 == null)
				{
					num4 = 801104457;
					num5 = num4;
				}
				else
				{
					num4 = 532256141;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 1020750999);
				continue;
			}
			default:
				return multipartFormDataContent;
			}
			break;
		}
		goto IL_003a;
		IL_0222:
		StringContent stringContent = (StringContent)D1D731987B654D5B(_4D6F2165CDDD4F20((object)F7606163E8F34F94), D4CD8DAE3A6842D7(), _003CModule_003E._3F57E81A62734AC2<string>(-2041342208 ^ (int)obj._184044A093C04AF2(2, 3410307443u)));
		object obj4 = _9D32B207947A4F5C((object)stringContent);
		object obj5 = _25C7375737184FCF(_003CModule_003E._390073C602714496<string>((int)(0x7119AC26 ^ obj._184044A093C04AF2(4, 2029299647u))));
		A4A4E5C9CC56426C(obj5, _003CModule_003E._390073C602714496<string>((int)(0x497C7709 ^ obj._184044A093C04AF2(9, 3905477878u))));
		AF5EEBC6CF8943A4(obj4, obj5);
		_0AACF0F30C694395((object)multipartFormDataContent, (object)stringContent);
		num = -1601314870;
		goto IL_003f;
	}

	static object _5DB2D5EFA0B9416E()
	{
		return new FD59A46B5C464B4B();
	}

	static Dictionary<string, object> _9D04C8FEA47043B9(object P_0)
	{
		return ((FD59A46B5C464B4B)P_0)._48A38A507F0B4BBA();
	}

	static object _8A077221B53246F3()
	{
		return new MultipartFormDataContent();
	}

	static string _4D6F2165CDDD4F20(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	static object D4CD8DAE3A6842D7()
	{
		return Encoding.UTF8;
	}

	static object D1D731987B654D5B(string P_0, object P_1, string P_2)
	{
		return new StringContent(P_0, (Encoding?)P_1, P_2);
	}

	static object _9D32B207947A4F5C(object P_0)
	{
		return ((HttpContent)P_0).Headers;
	}

	static object _25C7375737184FCF(string P_0)
	{
		return new ContentDispositionHeaderValue(P_0);
	}

	static void A4A4E5C9CC56426C(object P_0, string P_1)
	{
		((ContentDispositionHeaderValue)P_0).Name = P_1;
	}

	static void AF5EEBC6CF8943A4(object P_0, object P_1)
	{
		((HttpContentHeaders)P_0).ContentDisposition = (ContentDispositionHeaderValue?)P_1;
	}

	static void _0AACF0F30C694395(object P_0, object P_1)
	{
		((MultipartContent)P_0).Add((HttpContent)P_1);
	}

	static bool BECDCC56F4F14902(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static object CD3247EE904A4343(byte[] P_0)
	{
		return new ByteArrayContent(P_0);
	}

	static object BA3370CCDB2F4FCC(string P_0)
	{
		return MediaTypeHeaderValue.Parse(P_0);
	}

	static void BCCD2C3B99EC4EDA(object P_0, object P_1)
	{
		((HttpContentHeaders)P_0).ContentType = (MediaTypeHeaderValue?)P_1;
	}

	static string _4855FD78C3E14F59(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static void _5C666D3D1A874184(object P_0, string P_1)
	{
		((ContentDispositionHeaderValue)P_0).FileName = P_1;
	}
}
