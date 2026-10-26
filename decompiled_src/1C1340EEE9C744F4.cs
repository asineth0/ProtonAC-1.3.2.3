using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Microsoft.Extensions.Localization;

public class _1C1340EEE9C744F4 : IStringLocalizer
{
	[Serializable]
	[CompilerGenerated]
	private sealed class BDBBE7E5266F409C
	{
		public static readonly BDBBE7E5266F409C _003C_003E9 = (BDBBE7E5266F409C)D308AE0D773C4DF1();

		public static Func<JsonElement, bool> _003C_003E9__2_0;

		public static Func<JsonElement, string> _003C_003E9__2_1;

		public static Func<KeyValuePair<string, string>, LocalizedString> _003C_003E9__7_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool B7BFE4E9B6DC4FF3(JsonElement P_0)
		{
			E651E17AA2CA4BC8._1BA897AD7E174710();
			E651E17AA2CA4BC8._1BA897AD7E174710();
			return false;
		}

		internal string _85D8C00E23D94845(JsonElement P_0)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			E651E17AA2CA4BC8._7497D9F457FE469E._78D12C3B593C4A4D((object)P_0);
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal LocalizedString _3AE1960696FA4A1B(KeyValuePair<string, string> P_0)
		{
			return (LocalizedString)_9CEFCF922EC44246(P_0.Key, P_0.Value, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0);
		}

		static object D308AE0D773C4DF1()
		{
			return new BDBBE7E5266F409C();
		}

		static object _9CEFCF922EC44246(string P_0, string P_1, bool P_2)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected Obj, but got Unknown
			return (object)new LocalizedString(P_0, P_1, P_2);
		}
	}

	private readonly Dictionary<string, string> AA0ED90BD70C42B5;

	public LocalizedString this[string name]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			if (name == null)
			{
				while (true)
				{
					int num = -1553523060;
					uint num2;
					switch ((num2 = (uint)((--1269745757 - (-unchecked(~2073089852 + -182741259) - ~((num ^ -(-428197505 * ((~(-392173839 + unchecked(-1133293839 * -382018012)) + (unchecked(~-1732014717 * -203658851) - -unchecked(-2047772709 * 1882437463))) * -410580819))) - (~(-1253049982 + --530642499 + -1350188341 + -(~999410419) * 1976927485) + (-1520123400 ^ (480991623 * -(-659583245 ^ -1825855544)))) + -1411273689) - ~(~-1939713148))) ^ 0x11A45587)) % 3)
					{
					case 2u:
						continue;
					case 1u:
						throw FC67E848ACE84C15(_003CModule_003E._8B9C7B12B1AE4949<string>(-1312449890));
					}
					break;
				}
			}
			bool flag = AA0ED90BD70C42B5.TryGetValue(name, out string value);
			return (LocalizedString)ADBFA2BA7CFF499C(name, flag ? value : name, (flag ? 1 : 0) == _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
		}
	}

	public LocalizedString this[string name, params object[] arguments]
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			string text = AD77769C6F1E4418(FD739BB749B84BC9(name));
			if (arguments.Length == _003CModule_003E.F84FA79ABE6944BB<int>(1741630884))
			{
				goto IL_0021;
			}
			goto IL_019c;
			IL_0021:
			int num = -1407592535;
			goto IL_0026;
			IL_0026:
			PropertyInfo[] array = default;
			object obj2 = default;
			int num4 = default;
			PropertyInfo propertyInfo = default;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(-(-(0x6B4E8E00 ^ -549929391) - -(-(num2 - ((1288381143 * (1542213864 + (0x6ADF6CA4 ^ -unchecked((98045950 - -1359183706) * -486538183)))) ^ (-1829275736 + (-(--1507173509) + ~(--615890352) * -1444807693 + unchecked(((0x55833920 ^ 0x75FB46C1) - (0x603F6E04 ^ 0x5A9C2D7B)) * -1908162471)))))))) * 1570954663)) % 11)
				{
				case 4u:
					break;
				case 10u:
					goto IL_0104;
				case 7u:
					text = _1E3E8268E0414F57((IFormatProvider)BDABF36C1A434B99(), text, arguments);
					num = (int)((num3 * 1465124419) ^ 0x2E0E6967);
					continue;
				case 8u:
					array = CC17AAF187F44044(E3CC4A242A5349AA(obj2));
					num4 = _003CModule_003E._390073C602714496<int>(2131963235);
					num = 866869768;
					continue;
				case 5u:
					num = (int)((num3 * 1425912804) ^ 0x45F46204);
					continue;
				case 2u:
					obj2 = arguments[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)];
					num = 1078782973;
					continue;
				case 1u:
					goto IL_019c;
				case 3u:
					goto IL_01b4;
				case 0u:
					propertyInfo = array[num4];
					num = -1465447350;
					continue;
				case 6u:
				{
					string text2 = _1A183CE2001C4D0D(_003CModule_003E._3F57E81A62734AC2<string>(-363106680), C15CD8527956430B((object)propertyInfo), _003CModule_003E._58ECCB512F2A43AC<string>(1208661895));
					object obj = _9136F8C0B1844D36((object)propertyInfo, obj2);
					string text3 = ((obj != null) ? E5167275BE894D4F(obj) : null) ?? string.Empty;
					text = FB9CDE7D01D14027((object)text, text2, text3);
					num4 += _003CModule_003E.F84FA79ABE6944BB<int>(1741630884);
					num = 866869768;
					continue;
				}
				default:
					return (LocalizedString)ADBFA2BA7CFF499C(name, text, (AA0ED90BD70C42B5.ContainsKey(name) ? 1 : 0) == _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
				}
				break;
				IL_01b4:
				int num5;
				if (num4 >= array.Length)
				{
					num = 639764016;
					num5 = num;
				}
				else
				{
					num = -1258439774;
					num5 = num;
				}
				continue;
				IL_0104:
				int num6;
				if (!(arguments[_003CModule_003E._390073C602714496<int>(2131963235)] is string))
				{
					num = 1107016765;
					num6 = num;
				}
				else
				{
					num = 587993857;
					num6 = num;
				}
			}
			goto IL_0021;
			IL_019c:
			int num7;
			if (arguments.Length != 0)
			{
				num = -1794841403;
				num7 = num;
			}
			else
			{
				num = 244469908;
				num7 = num;
			}
			goto IL_0026;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _1C1340EEE9C744F4(string P_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		_9D8E2D6009B74334((string)null, (string)null);
		AEA352792EEF4D90();
		Dictionary<string, string> aA0ED90BD70C42B = null;
		_358A7731B2814A47(P_0);
		AA0ED90BD70C42B5 = aA0ED90BD70C42B;
		A274ED7894D945C6((object)null);
		_5439F9D450104626(default, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _5439F9D450104626(JsonElement P_0, string? P_1)
	{
		GC.KeepAlive(null);
	}

	public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
	{
		return AA0ED90BD70C42B5.Select([MethodImpl(MethodImplOptions.NoInlining)] (KeyValuePair<string, string> P_0) => (LocalizedString)BDBBE7E5266F409C._9CEFCF922EC44246(P_0.Key, P_0.Value, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0));
	}

	public IStringLocalizer _2A4D2A0735AB4436(CultureInfo P_0)
	{
		_490D592C4EEE45D9(P_0);
		return (IStringLocalizer)(object)this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private IEnumerator B6028C316C04492D()
	{
		return _2090F66A339E4F5B((byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0).GetEnumerator();
	}

	static bool _358A7731B2814A47(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static object _9D8E2D6009B74334(string P_0, string P_1)
	{
		return new ArgumentException(P_0, P_1);
	}

	static object AEA352792EEF4D90()
	{
		return StringComparer.OrdinalIgnoreCase;
	}

	static object _0D7AF6A54FFB400B(string P_0, JsonDocumentOptions P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return JsonDocument.Parse(P_0, P_1);
	}

	static JsonElement A274ED7894D945C6(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((JsonDocument)P_0).RootElement;
	}

	static void _6944F96E2F24477A(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static string _1A183CE2001C4D0D(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static string _20C4CF0F6C514057(string P_0, IEnumerable<string> P_1)
	{
		return string.Join(P_0, P_1);
	}

	static string _0A4A56BCEE094C42(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static object FC67E848ACE84C15(string P_0)
	{
		return new ArgumentNullException(P_0);
	}

	static object ADBFA2BA7CFF499C(string P_0, string P_1, bool P_2)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected Obj, but got Unknown
		return (object)new LocalizedString(P_0, P_1, P_2);
	}

	object FD739BB749B84BC9(string P_0)
	{
		return this[P_0];
	}

	static string AD77769C6F1E4418(object P_0)
	{
		return ((LocalizedString)P_0).Value;
	}

	static object E3CC4A242A5349AA(object P_0)
	{
		return P_0.GetType();
	}

	static PropertyInfo[] CC17AAF187F44044(object P_0)
	{
		return ((Type)P_0).GetProperties();
	}

	static string C15CD8527956430B(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	static object _9136F8C0B1844D36(object P_0, object P_1)
	{
		return ((PropertyInfo)P_0).GetValue(P_1);
	}

	static string E5167275BE894D4F(object P_0)
	{
		return P_0.ToString();
	}

	static string FB9CDE7D01D14027(object P_0, string P_1, string P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	static object BDABF36C1A434B99()
	{
		return CultureInfo.CurrentCulture;
	}

	static string _1E3E8268E0414F57(IFormatProvider P_0, string P_1, object[] P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static void _490D592C4EEE45D9(CultureInfo P_0)
	{
		CultureInfo.CurrentUICulture = P_0;
	}

	IEnumerable<LocalizedString> _2090F66A339E4F5B(bool P_0)
	{
		return GetAllStrings(P_0);
	}
}
