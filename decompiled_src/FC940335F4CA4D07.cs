using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json;

public class FC940335F4CA4D07 : AECA8283EE0E4BAC
{
	private readonly Dictionary<string, object> DB63844DE1D84D23 = new Dictionary<string, object>();

	private byte[]? _0B343366E96B442E;

	private string? E9682C92B17F4F7E;

	public FC940335F4CA4D07 C6D3E05E6B734BAF(string P_0, object P_1)
	{
		DB63844DE1D84D23[P_0] = P_1;
		return this;
	}

	public FC940335F4CA4D07 _8B6315621BBE4DFB(byte[]? P_0, string P_1)
	{
		_0B343366E96B442E = P_0;
		E9682C92B17F4F7E = P_1;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual MultipartFormDataContent _5CBEBFFEC2024055()
	{
		MultipartFormDataContent multipartFormDataContent = (MultipartFormDataContent)_5354CC0E4EA247CA();
		StringContent stringContent = (StringContent)_81506B0F788D4003(CD02E96AD46643A8((object)DB63844DE1D84D23), _68E76CE910DC4F6B(), _003CModule_003E._8B9C7B12B1AE4949<string>(1146673569));
		object obj = B4B35513BDE5495F((object)stringContent);
		object obj2 = D8B97CC5B14843F3(_003CModule_003E._8B9C7B12B1AE4949<string>(-1615340752));
		_2E4F39854BC945C9(obj2, _003CModule_003E._3F57E81A62734AC2<string>(-663107609));
		B11ED3335A7745A8(obj, obj2);
		_38B239FCB11A43C3((object)multipartFormDataContent, (object)stringContent);
		ByteArrayContent byteArrayContent = default;
		while (true)
		{
			int num = 591690619;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(unchecked(681424748 * -278266663) - -(-(-(((0xD5A6D6A ^ -(-1782128601 ^ 0x435D0052)) + (-356042487 ^ -unchecked(-1598939655 * -11330707))) * -2024224497 - -(num2 - (((~162525714 - -(--186734854) * 1568845713) ^ ~(~(unchecked(-2129981899 * -1421264017) + --711645371))) * -1760285917 - (849270961 * (-1818289777 * ~(1070162744 + -838560236)) + 1016452853)))))) + -1380858015)) % 6)
				{
				case 0u:
					break;
				case 5u:
				{
					byteArrayContent = (ByteArrayContent)_4B09A4CC0CDA46F1(_0B343366E96B442E);
					_3476FBC7410F4326(B4B35513BDE5495F((object)byteArrayContent), _3F14A94CC798484F(_003CModule_003E._8B9C7B12B1AE4949<string>(2016863199)));
					object obj3 = B4B35513BDE5495F((object)byteArrayContent);
					object obj4 = D8B97CC5B14843F3(_003CModule_003E._58ECCB512F2A43AC<string>(1175714983));
					_2E4F39854BC945C9(obj4, _003CModule_003E._8B9C7B12B1AE4949<string>(1533535712));
					_45CE42EE5CE34C65(obj4, _371B963BAC1D4934(_003CModule_003E._3F57E81A62734AC2<string>(-1880697246), E9682C92B17F4F7E, _003CModule_003E.F84FA79ABE6944BB<string>(-1418693247)));
					B11ED3335A7745A8(obj3, obj4);
					num = -119846641;
					continue;
				}
				case 3u:
				{
					int num6;
					int num7;
					if (BDE23A3FB0EA4A83(E9682C92B17F4F7E))
					{
						num6 = 663023915;
						num7 = num6;
					}
					else
					{
						num6 = 621492181;
						num7 = num6;
					}
					num = num6 ^ (int)(num3 * 707802101);
					continue;
				}
				case 4u:
				{
					int num4;
					int num5;
					if (_0B343366E96B442E != null)
					{
						num4 = -643243162;
						num5 = num4;
					}
					else
					{
						num4 = -839768540;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1104938713);
					continue;
				}
				case 2u:
					_38B239FCB11A43C3((object)multipartFormDataContent, (object)byteArrayContent);
					num = (int)((num3 * 909270356) ^ 0x3EFAD8CC);
					continue;
				default:
					return multipartFormDataContent;
				}
				break;
			}
		}
	}

	static object _5354CC0E4EA247CA()
	{
		return new MultipartFormDataContent();
	}

	static string CD02E96AD46643A8(object P_0)
	{
		return JsonConvert.SerializeObject(P_0);
	}

	static object _68E76CE910DC4F6B()
	{
		return Encoding.UTF8;
	}

	static object _81506B0F788D4003(string P_0, object P_1, string P_2)
	{
		return new StringContent(P_0, (Encoding?)P_1, P_2);
	}

	static object B4B35513BDE5495F(object P_0)
	{
		return ((HttpContent)P_0).Headers;
	}

	static object D8B97CC5B14843F3(string P_0)
	{
		return new ContentDispositionHeaderValue(P_0);
	}

	static void _2E4F39854BC945C9(object P_0, string P_1)
	{
		((ContentDispositionHeaderValue)P_0).Name = P_1;
	}

	static void B11ED3335A7745A8(object P_0, object P_1)
	{
		((HttpContentHeaders)P_0).ContentDisposition = (ContentDispositionHeaderValue?)P_1;
	}

	static void _38B239FCB11A43C3(object P_0, object P_1)
	{
		((MultipartContent)P_0).Add((HttpContent)P_1);
	}

	static bool BDE23A3FB0EA4A83(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static object _4B09A4CC0CDA46F1(byte[] P_0)
	{
		return new ByteArrayContent(P_0);
	}

	static object _3F14A94CC798484F(string P_0)
	{
		return MediaTypeHeaderValue.Parse(P_0);
	}

	static void _3476FBC7410F4326(object P_0, object P_1)
	{
		((HttpContentHeaders)P_0).ContentType = (MediaTypeHeaderValue?)P_1;
	}

	static string _371B963BAC1D4934(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static void _45CE42EE5CE34C65(object P_0, string P_1)
	{
		((ContentDispositionHeaderValue)P_0).FileName = P_1;
	}
}
