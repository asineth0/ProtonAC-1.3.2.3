using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Threading;
using MySqlConnector;

internal class _052F586A77234595 : _05B7A84E8227463B
{
	private readonly object E39AB7CE7313492C = A62A60585651404E();

	private readonly MySqlConnection? _39447386857F4221;

	private const string EEBDB4441CDD4DB9 = "hardwareIDHistory";

	private const string _2F2C60B15BA14BB3 = "verifiedPlayers";

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _052F586A77234595(string P_0, uint P_1, string P_2, string P_3, string P_4)
	{
		try
		{
			object obj = _6758B8D9382F4A5A();
			_708F0FE77518498D(obj, P_0);
			_43882A0BCF254334(obj, P_1);
			DCF3583D2A4D44D0(obj, P_2);
			_51246B73EE194A39(obj, P_3);
			F5ED9F68D56A43E1(obj, P_4);
			_1CBB85839C964000(obj, (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0);
			MySqlConnectionStringBuilder val = (MySqlConnectionStringBuilder)obj;
			_39447386857F4221 = (MySqlConnection?)CDB26007122B4EAF(D52BEF2278B4471D((object)val));
			_00849093616B4491((object)_39447386857F4221);
			_57D26F0AB8914D20();
		}
		catch
		{
			_39447386857F4221 = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _57D26F0AB8914D20()
	{
		if (_39447386857F4221 == null)
		{
			while (true)
			{
				int num = 1729486241;
				uint num2;
				switch ((num2 = (uint)(-(-num) * -449881673)) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
		object e39AB7CE7313492C = E39AB7CE7313492C;
		bool flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
		try
		{
			_53A1C95EB4E6455A(e39AB7CE7313492C, ref flag);
			MySqlCommand val = (MySqlCommand)_3807EC5A6A564F58((object)_39447386857F4221);
			try
			{
				B1B3833AE6024AF8((object)val, _003CModule_003E._3F57E81A62734AC2<string>(110980179));
				_8453FA5C78C44812((object)val);
			}
			finally
			{
				if (val != null)
				{
					while (true)
					{
						IL_0089:
						int num3 = 572257984;
						while (true)
						{
							int num = num3;
							uint num2;
							switch ((num2 = (uint)(-(-num) * -449881673)) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_008e;
							case 1u:
								goto IL_00b1;
							case 0u:
								goto end_IL_008e;
							}
							goto IL_0089;
							IL_00b1:
							_79C8A826EEF3490C((object)val);
							num3 = ((int)num2 * -1990184174) ^ -1700280691;
							continue;
							end_IL_008e:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (flag)
			{
				while (true)
				{
					IL_00ca:
					int num4 = -1575942020;
					while (true)
					{
						int num = num4;
						uint num2;
						switch ((num2 = (uint)(-(-num) * -449881673)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_00cf;
						case 2u:
							goto IL_00f2;
						case 1u:
							goto end_IL_00cf;
						}
						goto IL_00ca;
						IL_00f2:
						DE5FEFFD61664913(e39AB7CE7313492C);
						num4 = (int)((num2 * 1399514901) ^ 0x78492A04);
						continue;
						end_IL_00cf:
						break;
					}
					break;
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void C8607D00726A4D74(ulong P_0, int P_1, string P_2, long P_3)
	{
		if (_39447386857F4221 == null)
		{
			while (true)
			{
				int num = -1457819759;
				uint num2;
				switch ((num2 = (uint)(-(-(~(-(unchecked(732597391 * (-1192652870 - unchecked(~1335429841 * -1977904673))) - num) * -1315598753 * 653836513))))) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
		object e39AB7CE7313492C = E39AB7CE7313492C;
		bool flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
		try
		{
			_53A1C95EB4E6455A(e39AB7CE7313492C, ref flag);
			MySqlCommand val = (MySqlCommand)_3807EC5A6A564F58((object)_39447386857F4221);
			try
			{
				B1B3833AE6024AF8((object)val, _003CModule_003E._3F57E81A62734AC2<string>(-1116958636));
				while (true)
				{
					int num3 = -820258045;
					while (true)
					{
						int num = num3;
						uint num2;
						switch ((num2 = (uint)(-(-(~(-(unchecked(732597391 * (-1192652870 - unchecked(~1335429841 * -1977904673))) - num) * -1315598753 * 653836513))))) % 3)
						{
						case 0u:
							break;
						case 2u:
							goto IL_00e4;
						default:
							_8453FA5C78C44812((object)val);
							return;
						}
						break;
						IL_00e4:
						FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E._390073C602714496<string>(558396105), (object)P_0);
						FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E._8B9C7B12B1AE4949<string>(2085338116), (object)P_3);
						FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E._58ECCB512F2A43AC<string>(-2004197841), (object)P_1);
						FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E._58ECCB512F2A43AC<string>(-2098148638), (object)P_2);
						num3 = 422127215;
					}
				}
			}
			finally
			{
				if (val != null)
				{
					while (true)
					{
						IL_0171:
						int num4 = 808882553;
						while (true)
						{
							int num = num4;
							uint num2;
							switch ((num2 = (uint)(-(-(~(-(unchecked(732597391 * (-1192652870 - unchecked(~1335429841 * -1977904673))) - num) * -1315598753 * 653836513))))) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_0176;
							case 1u:
								goto IL_01ba;
							case 2u:
								goto end_IL_0176;
							}
							goto IL_0171;
							IL_01ba:
							_79C8A826EEF3490C((object)val);
							num4 = (int)(num2 * 1208055248) ^ -1292937678;
							continue;
							end_IL_0176:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (flag)
			{
				while (true)
				{
					IL_01d3:
					int num5 = -2017665686;
					while (true)
					{
						int num = num5;
						uint num2;
						switch ((num2 = (uint)(-(-(~(-(unchecked(732597391 * (-1192652870 - unchecked(~1335429841 * -1977904673))) - num) * -1315598753 * 653836513))))) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_01d8;
						case 1u:
							goto IL_021c;
						case 2u:
							goto end_IL_01d8;
						}
						goto IL_01d3;
						IL_021c:
						DE5FEFFD61664913(e39AB7CE7313492C);
						num5 = (int)(num2 * 872520703) ^ -547910861;
						continue;
						end_IL_01d8:
						break;
					}
					break;
				}
			}
		}
	}

	void _05B7A84E8227463B._1F53E315509B4C4A(ulong P_0, int P_1, string P_2, long P_3)
	{
		//ILSpy generated this explicit interface implementation from .override directive in C8607D00726A4D74
		this.C8607D00726A4D74(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<string> B48273490AB245B9(ulong P_0)
	{
		if (_39447386857F4221 == null)
		{
			while (true)
			{
				int num = -353961484;
				uint num2;
				switch ((num2 = (uint)(~(((((-((-(-1712907585 ^ 0x4A79EF9D) + --341322469 * 278256867) * -967643303 + ((-786303798 ^ -(-2009223130 + 802735819)) + -1594567335)) - (-(unchecked(~1750739414 * 6120191) - -(~-858550091)) - 232799751 * (-925714985 * -(-unchecked(1450024946 * 1267944999)))) - num) ^ (-(-1740194111 * ((-1571042613 ^ 0x1362521B) + --140597033) - (0x2260909D ^ -482162134)) + ~(~-540100724 + -1477483997 - unchecked(unchecked(1397636387 - -1165823361) * -1694774835) + ~(--741305619 + (1295127872 - 365132730))))) * 124889567 * 700735191 - unchecked(~(-1329710619 ^ 0x60F19C5C) * 1800215037)) ^ -(~843314870)) * 331855423))) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return Array.Empty<string>();
				}
				break;
			}
		}
		object e39AB7CE7313492C = E39AB7CE7313492C;
		bool flag = (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0;
		try
		{
			_53A1C95EB4E6455A(e39AB7CE7313492C, ref flag);
			List<string> list = new List<string>();
			MySqlCommand val = (MySqlCommand)_3807EC5A6A564F58((object)_39447386857F4221);
			try
			{
				B1B3833AE6024AF8((object)val, _003CModule_003E._58ECCB512F2A43AC<string>(-417330202));
				FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E._390073C602714496<string>(558396105), (object)P_0);
				MySqlDataReader val2 = (MySqlDataReader)_99362694C1E34EB9((object)val);
				try
				{
					while (true)
					{
						int num3;
						int num4;
						if (_05CA5CB7A01847F3((object)val2))
						{
							num3 = -1168965298;
							num4 = num3;
						}
						else
						{
							num3 = -1742061600;
							num4 = num3;
						}
						while (true)
						{
							int num = num3;
							uint num2;
							switch ((num2 = (uint)(~(((((-((-(-1712907585 ^ 0x4A79EF9D) + --341322469 * 278256867) * -967643303 + ((-786303798 ^ -(-2009223130 + 802735819)) + -1594567335)) - (-(unchecked(~1750739414 * 6120191) - -(~-858550091)) - 232799751 * (-925714985 * -(-unchecked(1450024946 * 1267944999)))) - num) ^ (-(-1740194111 * ((-1571042613 ^ 0x1362521B) + --140597033) - (0x2260909D ^ -482162134)) + ~(~-540100724 + -1477483997 - unchecked(unchecked(1397636387 - -1165823361) * -1694774835) + ~(--741305619 + (1295127872 - 365132730))))) * 124889567 * 700735191 - unchecked(~(-1329710619 ^ 0x60F19C5C) * 1800215037)) ^ -(~843314870)) * 331855423))) % 4)
							{
							case 2u:
								num3 = -1168965298;
								continue;
							case 1u:
								list.Add(F874AD27D1F54198((object)val2, _003CModule_003E._390073C602714496<int>(2131963235)));
								num3 = 392740211;
								continue;
							case 0u:
								break;
							default:
								return list;
							}
							break;
						}
					}
				}
				finally
				{
					if (val2 != null)
					{
						while (true)
						{
							IL_0346:
							int num5 = 239838960;
							while (true)
							{
								int num = num5;
								uint num2;
								switch ((num2 = (uint)(~(((((-((-(-1712907585 ^ 0x4A79EF9D) + --341322469 * 278256867) * -967643303 + ((-786303798 ^ -(-2009223130 + 802735819)) + -1594567335)) - (-(unchecked(~1750739414 * 6120191) - -(~-858550091)) - 232799751 * (-925714985 * -(-unchecked(1450024946 * 1267944999)))) - num) ^ (-(-1740194111 * ((-1571042613 ^ 0x1362521B) + --140597033) - (0x2260909D ^ -482162134)) + ~(~-540100724 + -1477483997 - unchecked(unchecked(1397636387 - -1165823361) * -1694774835) + ~(--741305619 + (1295127872 - 365132730))))) * 124889567 * 700735191 - unchecked(~(-1329710619 ^ 0x60F19C5C) * 1800215037)) ^ -(~843314870)) * 331855423))) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_034b;
								case 2u:
									goto IL_0478;
								case 1u:
									goto end_IL_034b;
								}
								goto IL_0346;
								IL_0478:
								_79C8A826EEF3490C((object)val2);
								num5 = (int)((num2 * 2030662338) ^ 0x36AF7EF7);
								continue;
								end_IL_034b:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (val != null)
				{
					while (true)
					{
						IL_0499:
						int num6 = -786946886;
						while (true)
						{
							int num = num6;
							uint num2;
							switch ((num2 = (uint)(~(((((-((-(-1712907585 ^ 0x4A79EF9D) + --341322469 * 278256867) * -967643303 + ((-786303798 ^ -(-2009223130 + 802735819)) + -1594567335)) - (-(unchecked(~1750739414 * 6120191) - -(~-858550091)) - 232799751 * (-925714985 * -(-unchecked(1450024946 * 1267944999)))) - num) ^ (-(-1740194111 * ((-1571042613 ^ 0x1362521B) + --140597033) - (0x2260909D ^ -482162134)) + ~(~-540100724 + -1477483997 - unchecked(unchecked(1397636387 - -1165823361) * -1694774835) + ~(--741305619 + (1295127872 - 365132730))))) * 124889567 * 700735191 - unchecked(~(-1329710619 ^ 0x60F19C5C) * 1800215037)) ^ -(~843314870)) * 331855423))) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_049e;
							case 2u:
								goto IL_05cb;
							case 1u:
								goto end_IL_049e;
							}
							goto IL_0499;
							IL_05cb:
							_79C8A826EEF3490C((object)val);
							num6 = ((int)num2 * -77627178) ^ -1970434393;
							continue;
							end_IL_049e:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (flag)
			{
				while (true)
				{
					IL_05eb:
					int num7 = -650575223;
					while (true)
					{
						int num = num7;
						uint num2;
						switch ((num2 = (uint)(~(((((-((-(-1712907585 ^ 0x4A79EF9D) + --341322469 * 278256867) * -967643303 + ((-786303798 ^ -(-2009223130 + 802735819)) + -1594567335)) - (-(unchecked(~1750739414 * 6120191) - -(~-858550091)) - 232799751 * (-925714985 * -(-unchecked(1450024946 * 1267944999)))) - num) ^ (-(-1740194111 * ((-1571042613 ^ 0x1362521B) + --140597033) - (0x2260909D ^ -482162134)) + ~(~-540100724 + -1477483997 - unchecked(unchecked(1397636387 - -1165823361) * -1694774835) + ~(--741305619 + (1295127872 - 365132730))))) * 124889567 * 700735191 - unchecked(~(-1329710619 ^ 0x60F19C5C) * 1800215037)) ^ -(~843314870)) * 331855423))) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_05f0;
						case 1u:
							goto IL_071d;
						case 0u:
							goto end_IL_05f0;
						}
						goto IL_05eb;
						IL_071d:
						DE5FEFFD61664913(e39AB7CE7313492C);
						num7 = (int)(num2 * 1163421627) ^ -109497139;
						continue;
						end_IL_05f0:
						break;
					}
					break;
				}
			}
		}
	}

	IEnumerable<string> _05B7A84E8227463B._0CE0C14392C04759(ulong P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in B48273490AB245B9
		return this.B48273490AB245B9(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<ulong> _777B2FCA278241D9(string P_0)
	{
		if (_39447386857F4221 == null)
		{
			while (true)
			{
				int num = -1971269503;
				uint num2;
				switch ((num2 = (uint)(-(~(~(~(-num * 727795177 + ~(-114262681 ^ (-46496008 ^ -unchecked(566965263 * 2079397830))))))) - -891212214)) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return Array.Empty<ulong>();
				}
				break;
			}
		}
		object e39AB7CE7313492C = E39AB7CE7313492C;
		bool flag = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
		try
		{
			_53A1C95EB4E6455A(e39AB7CE7313492C, ref flag);
			List<ulong> list = new List<ulong>();
			MySqlCommand val = (MySqlCommand)_3807EC5A6A564F58((object)_39447386857F4221);
			try
			{
				B1B3833AE6024AF8((object)val, _003CModule_003E._58ECCB512F2A43AC<string>(885625864));
				FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E.F84FA79ABE6944BB<string>(-74685749), (object)P_0);
				MySqlDataReader val2 = (MySqlDataReader)_99362694C1E34EB9((object)val);
				try
				{
					while (true)
					{
						int num3;
						int num4;
						if (!_05CA5CB7A01847F3((object)val2))
						{
							num3 = -1159023204;
							num4 = num3;
						}
						else
						{
							num3 = -1923717714;
							num4 = num3;
						}
						while (true)
						{
							int num = num3;
							uint num2;
							switch ((num2 = (uint)(-(~(~(~(-num * 727795177 + ~(-114262681 ^ (-46496008 ^ -unchecked(566965263 * 2079397830))))))) - -891212214)) % 4)
							{
							case 0u:
								num3 = -1923717714;
								continue;
							case 3u:
								list.Add(val2.GetFieldValue<ulong>(_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)));
								num3 = -1729444929;
								continue;
							case 2u:
								break;
							default:
								return list;
							}
							break;
						}
					}
				}
				finally
				{
					if (val2 != null)
					{
						while (true)
						{
							IL_019c:
							int num5 = 1513346993;
							while (true)
							{
								int num = num5;
								uint num2;
								switch ((num2 = (uint)(-(~(~(~(-num * 727795177 + ~(-114262681 ^ (-46496008 ^ -unchecked(566965263 * 2079397830))))))) - -891212214)) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_01a1;
								case 2u:
									goto IL_0200;
								case 1u:
									goto end_IL_01a1;
								}
								goto IL_019c;
								IL_0200:
								_79C8A826EEF3490C((object)val2);
								num5 = (int)(num2 * 168197403) ^ -1410210022;
								continue;
								end_IL_01a1:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (val != null)
				{
					while (true)
					{
						IL_021b:
						int num6 = 2064127771;
						while (true)
						{
							int num = num6;
							uint num2;
							switch ((num2 = (uint)(-(~(~(~(-num * 727795177 + ~(-114262681 ^ (-46496008 ^ -unchecked(566965263 * 2079397830))))))) - -891212214)) % 3)
							{
							case 0u:
								break;
							default:
								goto end_IL_0220;
							case 2u:
								goto IL_027f;
							case 1u:
								goto end_IL_0220;
							}
							goto IL_021b;
							IL_027f:
							_79C8A826EEF3490C((object)val);
							num6 = (int)((num2 * 954829633) ^ 0x15DC679D);
							continue;
							end_IL_0220:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (flag)
			{
				while (true)
				{
					IL_0299:
					int num7 = -2090769663;
					while (true)
					{
						int num = num7;
						uint num2;
						switch ((num2 = (uint)(-(~(~(~(-num * 727795177 + ~(-114262681 ^ (-46496008 ^ -unchecked(566965263 * 2079397830))))))) - -891212214)) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_029e;
						case 1u:
							goto IL_02fd;
						case 0u:
							goto end_IL_029e;
						}
						goto IL_0299;
						IL_02fd:
						DE5FEFFD61664913(e39AB7CE7313492C);
						num7 = ((int)num2 * -789103964) ^ 0x588DDCC;
						continue;
						end_IL_029e:
						break;
					}
					break;
				}
			}
		}
	}

	IEnumerable<ulong> _05B7A84E8227463B._62CB1B0C4D6B4440(string P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 777B2FCA278241D9
		return this._777B2FCA278241D9(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public IEnumerable<string> _019B7DEE941D42A4(ulong P_0, int P_1, long P_2, long P_3)
	{
		if (_39447386857F4221 == null)
		{
			while (true)
			{
				int num = -1683787101;
				uint num2;
				switch ((num2 = (uint)(-1087147471 - (~num ^ -(--2139571260 - ~(-(-1152798593 ^ 0x129E8588)))))) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return Array.Empty<string>();
				}
				break;
			}
		}
		long num3 = P_2 - P_3;
		object e39AB7CE7313492C = E39AB7CE7313492C;
		bool flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
		try
		{
			_53A1C95EB4E6455A(e39AB7CE7313492C, ref flag);
			List<string> list = new List<string>();
			MySqlCommand val = (MySqlCommand)_3807EC5A6A564F58((object)_39447386857F4221);
			try
			{
				B1B3833AE6024AF8((object)val, _003CModule_003E._390073C602714496<string>(-1125728088));
				FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E._3F57E81A62734AC2<string>(-603199928), (object)P_0);
				FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E._8B9C7B12B1AE4949<string>(-1947222808), (object)P_1);
				FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E.F84FA79ABE6944BB<string>(-866432146), (object)num3);
				MySqlDataReader val2 = (MySqlDataReader)_99362694C1E34EB9((object)val);
				try
				{
					while (true)
					{
						int num4;
						int num5;
						if (_05CA5CB7A01847F3((object)val2))
						{
							num4 = -1249220393;
							num5 = num4;
						}
						else
						{
							num4 = 1279915169;
							num5 = num4;
						}
						while (true)
						{
							int num = num4;
							uint num2;
							switch ((num2 = (uint)(-1087147471 - (~num ^ -(--2139571260 - ~(-(-1152798593 ^ 0x129E8588)))))) % 4)
							{
							case 0u:
								num4 = -1249220393;
								continue;
							case 3u:
								list.Add(F874AD27D1F54198((object)val2, _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)));
								num4 = -1827863938;
								continue;
							case 2u:
								break;
							default:
								return list;
							}
							break;
						}
					}
				}
				finally
				{
					if (val2 != null)
					{
						while (true)
						{
							IL_019f:
							int num6 = -1461389277;
							while (true)
							{
								int num = num6;
								uint num2;
								switch ((num2 = (uint)(-1087147471 - (~num ^ -(--2139571260 - ~(-(-1152798593 ^ 0x129E8588)))))) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_01a4;
								case 1u:
									goto IL_01e3;
								case 2u:
									goto end_IL_01a4;
								}
								goto IL_019f;
								IL_01e3:
								_79C8A826EEF3490C((object)val2);
								num6 = ((int)num2 * -521816085) ^ -1157192084;
								continue;
								end_IL_01a4:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (val != null)
				{
					while (true)
					{
						IL_01ff:
						int num7 = 1651702913;
						while (true)
						{
							int num = num7;
							uint num2;
							switch ((num2 = (uint)(-1087147471 - (~num ^ -(--2139571260 - ~(-(-1152798593 ^ 0x129E8588)))))) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_0204;
							case 1u:
								goto IL_0243;
							case 0u:
								goto end_IL_0204;
							}
							goto IL_01ff;
							IL_0243:
							_79C8A826EEF3490C((object)val);
							num7 = ((int)num2 * -428632164) ^ 0x490C8AA7;
							continue;
							end_IL_0204:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (flag)
			{
				while (true)
				{
					IL_025e:
					int num8 = 1656604689;
					while (true)
					{
						int num = num8;
						uint num2;
						switch ((num2 = (uint)(-1087147471 - (~num ^ -(--2139571260 - ~(-(-1152798593 ^ 0x129E8588)))))) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_0263;
						case 2u:
							goto IL_02a2;
						case 1u:
							goto end_IL_0263;
						}
						goto IL_025e;
						IL_02a2:
						DE5FEFFD61664913(e39AB7CE7313492C);
						num8 = ((int)num2 * -812909579) ^ -572816690;
						continue;
						end_IL_0263:
						break;
					}
					break;
				}
			}
		}
	}

	IEnumerable<string> _05B7A84E8227463B._725A098C42D04D27(ulong P_0, int P_1, long P_2, long P_3)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 019B7DEE941D42A4
		return this._019B7DEE941D42A4(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _4F5E8ECADAF04711(ulong P_0)
	{
		if (_39447386857F4221 == null)
		{
			goto IL_000b;
		}
		goto IL_00c0;
		IL_000b:
		int num = 1753950878;
		goto IL_0010;
		IL_0010:
		int num2 = num;
		object e39AB7CE7313492C = default;
		uint num3;
		switch ((num3 = (uint)(-(unchecked(~(-648490294 ^ 0x48C8FA61) - ~(0x619AB196 ^ 0x3C40B94B)) + (-1848856884 ^ -1230384096) + (-1230204868 + unchecked(-1005594307 + (-2093526625 - -182156545))) - -num2) ^ (-579338484 ^ -unchecked(1980604683 * -975221057) ^ (-(--171715462) * -1221080699)))) % 4)
		{
		case 0u:
			break;
		case 2u:
			return;
		case 1u:
			goto IL_00c0;
		default:
		{
			bool flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
			try
			{
				_53A1C95EB4E6455A(e39AB7CE7313492C, ref flag);
				MySqlCommand val = (MySqlCommand)_3807EC5A6A564F58((object)_39447386857F4221);
				try
				{
					B1B3833AE6024AF8((object)val, _003CModule_003E._3F57E81A62734AC2<string>(-407953118));
					FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E._390073C602714496<string>(558396105), (object)P_0);
					_8453FA5C78C44812((object)val);
					return;
				}
				finally
				{
					if (val != null)
					{
						while (true)
						{
							IL_0134:
							int num4 = 480266419;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(-(unchecked(~(-648490294 ^ 0x48C8FA61) - ~(0x619AB196 ^ 0x3C40B94B)) + (-1848856884 ^ -1230384096) + (-1230204868 + unchecked(-1005594307 + (-2093526625 - -182156545))) - -num2) ^ (-579338484 ^ -unchecked(1980604683 * -975221057) ^ (-(--171715462) * -1221080699)))) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_0139;
								case 1u:
									goto IL_01d2;
								case 2u:
									goto end_IL_0139;
								}
								goto IL_0134;
								IL_01d2:
								_79C8A826EEF3490C((object)val);
								num4 = (int)((num3 * 1830808708) ^ 0x2B89C576);
								continue;
								end_IL_0139:
								break;
							}
							break;
						}
					}
				}
			}
			finally
			{
				if (flag)
				{
					while (true)
					{
						IL_01f1:
						int num5 = 1782519155;
						while (true)
						{
							num2 = num5;
							switch ((num3 = (uint)(-(unchecked(~(-648490294 ^ 0x48C8FA61) - ~(0x619AB196 ^ 0x3C40B94B)) + (-1848856884 ^ -1230384096) + (-1230204868 + unchecked(-1005594307 + (-2093526625 - -182156545))) - -num2) ^ (-579338484 ^ -unchecked(1980604683 * -975221057) ^ (-(--171715462) * -1221080699)))) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_01f6;
							case 1u:
								goto IL_028f;
							case 0u:
								goto end_IL_01f6;
							}
							goto IL_01f1;
							IL_028f:
							DE5FEFFD61664913(e39AB7CE7313492C);
							num5 = ((int)num3 * -1149737288) ^ 0x1FEB7292;
							continue;
							end_IL_01f6:
							break;
						}
						break;
					}
				}
			}
		}
		}
		goto IL_000b;
		IL_00c0:
		e39AB7CE7313492C = E39AB7CE7313492C;
		num = 837880607;
		goto IL_0010;
	}

	void _05B7A84E8227463B.F66ACEBD262741E3(ulong P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 4F5E8ECADAF04711
		this._4F5E8ECADAF04711(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool _631B4DE28B124636(ulong P_0)
	{
		if (_39447386857F4221 == null)
		{
			while (true)
			{
				int num = -373523322;
				uint num2;
				switch ((num2 = (uint)(-(-((num ^ -(~(423177496 - (--1258849150 + -(~(-180100544 ^ -2120921189)))))) + (unchecked(-1038291329 * 1250555554) + 945749583)) * -563071983 + -(-(-675321245 + 19156695)) - ~944916062))) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
				}
				break;
			}
		}
		object e39AB7CE7313492C = E39AB7CE7313492C;
		bool flag = (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
		bool result = default;
		try
		{
			_53A1C95EB4E6455A(e39AB7CE7313492C, ref flag);
			MySqlCommand val = (MySqlCommand)_3807EC5A6A564F58((object)_39447386857F4221);
			try
			{
				B1B3833AE6024AF8((object)val, _003CModule_003E._390073C602714496<string>(43962764));
				FF5352E2222C4A16(E5362711AF0B4A08((object)val), _003CModule_003E._3F57E81A62734AC2<string>(-603199928), (object)P_0);
				object obj = _8C5097357BDB48AE((object)val);
				while (true)
				{
					IL_00eb:
					int num3 = -2093728538;
					while (true)
					{
						int num = num3;
						uint num2;
						int num4;
						switch ((num2 = (uint)(-(-((num ^ -(~(423177496 - (--1258849150 + -(~(-180100544 ^ -2120921189)))))) + (unchecked(-1038291329 * 1250555554) + 945749583)) * -563071983 + -(-(-675321245 + 19156695)) - ~944916062))) % 4)
						{
						case 2u:
							break;
						default:
							goto end_IL_00f0;
						case 1u:
							if (obj != null)
							{
								num3 = ((int)num2 * -1159526259) ^ -394063658;
								continue;
							}
							num4 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563);
							goto IL_0192;
						case 0u:
							num4 = ((_64A7F6D4743B4E63(obj) == _003CModule_003E.F84FA79ABE6944BB<int>(1741630884)) ? 1 : 0);
							goto IL_0192;
						case 3u:
							goto end_IL_00f0;
							IL_0192:
							result = (byte)num4 != 0;
							num3 = 561630528;
							continue;
						}
						goto IL_00eb;
						continue;
						end_IL_00f0:
						break;
					}
					break;
				}
			}
			finally
			{
				if (val != null)
				{
					while (true)
					{
						IL_01a9:
						int num5 = -1429534721;
						while (true)
						{
							int num = num5;
							uint num2;
							switch ((num2 = (uint)(-(-((num ^ -(~(423177496 - (--1258849150 + -(~(-180100544 ^ -2120921189)))))) + (unchecked(-1038291329 * 1250555554) + 945749583)) * -563071983 + -(-(-675321245 + 19156695)) - ~944916062))) % 3)
							{
							case 2u:
								break;
							default:
								goto end_IL_01ae;
							case 1u:
								goto IL_0216;
							case 0u:
								goto end_IL_01ae;
							}
							goto IL_01a9;
							IL_0216:
							_79C8A826EEF3490C((object)val);
							num5 = ((int)num2 * -1307449804) ^ 0x725A7CD1;
							continue;
							end_IL_01ae:
							break;
						}
						break;
					}
				}
			}
		}
		finally
		{
			if (flag)
			{
				while (true)
				{
					IL_0233:
					int num6 = 1322003515;
					while (true)
					{
						int num = num6;
						uint num2;
						switch ((num2 = (uint)(-(-((num ^ -(~(423177496 - (--1258849150 + -(~(-180100544 ^ -2120921189)))))) + (unchecked(-1038291329 * 1250555554) + 945749583)) * -563071983 + -(-(-675321245 + 19156695)) - ~944916062))) % 3)
						{
						case 2u:
							break;
						default:
							goto end_IL_0238;
						case 1u:
							goto IL_02a0;
						case 0u:
							goto end_IL_0238;
						}
						goto IL_0233;
						IL_02a0:
						DE5FEFFD61664913(e39AB7CE7313492C);
						num6 = ((int)num2 * -1097328670) ^ 0x42D465DD;
						continue;
						end_IL_0238:
						break;
					}
					break;
				}
			}
		}
		return result;
	}

	bool _05B7A84E8227463B.EC834E7B0DC044F4(ulong P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 631B4DE28B124636
		return this._631B4DE28B124636(P_0);
	}

	public void _8D0590F1823B4F50()
	{
		((_052F586A77234595)(object)_39447386857F4221)?.C1E36CD5D2B64692();
	}

	void _05B7A84E8227463B.E3A8BD6E89444F56()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 8D0590F1823B4F50
		this._8D0590F1823B4F50();
	}

	static object A62A60585651404E()
	{
		return new object();
	}

	static object _6758B8D9382F4A5A()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected Obj, but got Unknown
		return (object)new MySqlConnectionStringBuilder();
	}

	static void _708F0FE77518498D(object P_0, string P_1)
	{
		((MySqlConnectionStringBuilder)P_0).Server = P_1;
	}

	static void _43882A0BCF254334(object P_0, uint P_1)
	{
		((MySqlConnectionStringBuilder)P_0).Port = P_1;
	}

	static void DCF3583D2A4D44D0(object P_0, string P_1)
	{
		((MySqlConnectionStringBuilder)P_0).Database = P_1;
	}

	static void _51246B73EE194A39(object P_0, string P_1)
	{
		((MySqlConnectionStringBuilder)P_0).UserID = P_1;
	}

	static void F5ED9F68D56A43E1(object P_0, string P_1)
	{
		((MySqlConnectionStringBuilder)P_0).Password = P_1;
	}

	static void _1CBB85839C964000(object P_0, bool P_1)
	{
		((MySqlConnectionStringBuilder)P_0).Pooling = P_1;
	}

	static string D52BEF2278B4471D(object P_0)
	{
		return ((DbConnectionStringBuilder)P_0).ConnectionString;
	}

	static object CDB26007122B4EAF(string P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object)new MySqlConnection(P_0);
	}

	static void _00849093616B4491(object P_0)
	{
		((DbConnection)P_0).Open();
	}

	static void _53A1C95EB4E6455A(object P_0, ref bool P_1)
	{
		Monitor.Enter(P_0, ref P_1);
	}

	static object _3807EC5A6A564F58(object P_0)
	{
		return ((MySqlConnection)P_0).CreateCommand();
	}

	static void B1B3833AE6024AF8(object P_0, string P_1)
	{
		((DbCommand)P_0).CommandText = P_1;
	}

	static int _8453FA5C78C44812(object P_0)
	{
		return ((DbCommand)P_0).ExecuteNonQuery();
	}

	static void _79C8A826EEF3490C(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static void DE5FEFFD61664913(object P_0)
	{
		Monitor.Exit(P_0);
	}

	static object E5362711AF0B4A08(object P_0)
	{
		return ((MySqlCommand)P_0).Parameters;
	}

	static object FF5352E2222C4A16(object P_0, string P_1, object P_2)
	{
		return ((MySqlParameterCollection)P_0).AddWithValue(P_1, P_2);
	}

	static object _99362694C1E34EB9(object P_0)
	{
		return ((MySqlCommand)P_0).ExecuteReader();
	}

	static string F874AD27D1F54198(object P_0, int P_1)
	{
		return ((DbDataReader)P_0).GetString(P_1);
	}

	static bool _05CA5CB7A01847F3(object P_0)
	{
		return ((DbDataReader)P_0).Read();
	}

	static object _8C5097357BDB48AE(object P_0)
	{
		return ((DbCommand)P_0).ExecuteScalar();
	}

	static long _64A7F6D4743B4E63(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	void C1E36CD5D2B64692()
	{
		((Component)this).Dispose();
	}
}
