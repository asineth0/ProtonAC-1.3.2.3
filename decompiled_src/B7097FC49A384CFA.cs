using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

public class B7097FC49A384CFA : C179263454B44BF6
{
	private readonly struct B57BCC7426FB478D(string P_0, string P_1, string P_2, bool P_3)
	{
		public readonly string _3E20AB0715344CAE = P_0;

		public readonly string _6B075EEB395C46E9 = P_1;

		public readonly string _1AE5749185184BD6 = P_2;

		public readonly bool _789A8474C61C4EDE = P_3;

		public bool _5EE35423D9AC40C2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return _6091C2B0DFB046CC((object)_6B075EEB395C46E9) == _003CModule_003E.F84FA79ABE6944BB<int>(1398637845);
			}
		}

		public static B57BCC7426FB478D D14D30CDEC3E4BB2
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return new B57BCC7426FB478D(string.Empty, string.Empty, string.Empty, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static B57BCC7426FB478D CB4C7FBDFCFE4AF9(string P_0, string P_1, string? P_2)
		{
			return new B57BCC7426FB478D(P_0, P_1, P_2 ?? string.Empty, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static B57BCC7426FB478D _677432EDFDA943DB(string P_0, string P_1, string P_2)
		{
			return new B57BCC7426FB478D(P_0, P_1, P_2, (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0);
		}

		static int _6091C2B0DFB046CC(object P_0)
		{
			return ((string)P_0).Length;
		}
	}

	public struct _708ECF20BC9E451D
	{
		public string ACF9BC69E5294E28;

		public string _8DCA212F88FC4301;

		public ulong _37B20A4113D244AA;

		public string _7CD049C055E3441A;

		public string D0085BCED909426B;

		public string _35219130B15F4D94;

		public int B38102437FF64506;

		public float _143FFF351A2C4104;
	}

	[CompilerGenerated]
	private sealed class _7A95916E9B314B73
	{
		public string CFD62621B2B74176;

		public List<B57BCC7426FB478D> B1AA072141C94441;

		public int _744EDDD28BFF4514;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void C19BD68B7B27493F(FD59A46B5C464B4B P_0)
		{
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			_94A19C8837AA4795((object)P_0, _4D0B046329D6442A(_003CModule_003E._3F57E81A62734AC2<string>(-808333392), _80CA2CB46C5A4E72(CFD62621B2B74176, _003CModule_003E._3F57E81A62734AC2<int>(1258659850)), _003CModule_003E.F84FA79ABE6944BB<string>(-837808073)));
			using (List<B57BCC7426FB478D>.Enumerator enumerator = B1AA072141C94441.GetEnumerator())
			{
				B57BCC7426FB478D current = default;
				while (true)
				{
					IL_0129:
					int num;
					int num2;
					if (enumerator.MoveNext())
					{
						num = -297774893;
						num2 = num;
					}
					else
					{
						num = 1326674633;
						num2 = num;
					}
					while (true)
					{
						int num3 = num;
						uint num4;
						switch ((num4 = (uint)(~(~(~(-unchecked(~unchecked(1004048335 * -753217020) * -2025856447) - (-num3 - ~(983094079 * (0x7EE6EC1E ^ (-944898733 * -446513282)) * 1955956079)) * 1898753499)) * 897853743))) % 5)
						{
						case 2u:
							num = -297774893;
							continue;
						default:
							goto end_IL_0051;
						case 1u:
						{
							current = enumerator.Current;
							int num5;
							if (current._5EE35423D9AC40C2)
							{
								num = 1512362361;
								num5 = num;
							}
							else
							{
								num = 752629747;
								num5 = num;
							}
							continue;
						}
						case 0u:
							CB5B3891AC724BBA((object)P_0, _4D0B046329D6442A(_003CModule_003E.F84FA79ABE6944BB<string>(-837808073), current._6B075EEB395C46E9, _003CModule_003E.F84FA79ABE6944BB<string>(1742194028)), _2B07CBD6A2064FB3(current._1AE5749185184BD6), (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0);
							num = 1512362361;
							continue;
						case 4u:
							break;
						case 3u:
							goto end_IL_0051;
						}
						goto IL_0129;
						continue;
						end_IL_0051:
						break;
					}
					break;
				}
			}
			_7A34B9DEF63D4BC8(_1D74583750E64827(A33768E5CD554B74(CB5B3891AC724BBA(CB5B3891AC724BBA((object)P_0, _425613A9941842CB(_003CModule_003E._3F57E81A62734AC2<string>(-488096631), C07F8033DB844DE4((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._3F57E81A62734AC2<string>(986372360))), _2B07CBD6A2064FB3(_3D6B2EC01E78414E(_003CModule_003E._8B9C7B12B1AE4949<string>(601876534), (object)_437728E4F39246EA(), (object)_003CModule_003E._390073C602714496<string>(416397071), (object)_476810E891B84466())), (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0), _425613A9941842CB(_003CModule_003E._390073C602714496<string>(-1081734094), C07F8033DB844DE4((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._8B9C7B12B1AE4949<string>(-1017049256))), E725852CB7F44B84(_003CModule_003E._3F57E81A62734AC2<string>(1860039678), (object)_19525C751A734360().Count, (object)_968C1E31AD5D41F7()), (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0), _744EDDD28BFF4514), DateTimeOffset.UtcNow), _003CModule_003E._8B9C7B12B1AE4949<string>(-312800654), _9AB67761792440A7._6142757B48FF46AD);
		}

		static string _4D0B046329D6442A(string P_0, string P_1, string P_2)
		{
			return P_0 + P_1 + P_2;
		}

		static object _94A19C8837AA4795(object P_0, string P_1)
		{
			return ((FD59A46B5C464B4B)P_0)._37300664FFB04972(P_1);
		}

		static object CB5B3891AC724BBA(object P_0, string P_1, string P_2, bool P_3)
		{
			return ((FD59A46B5C464B4B)P_0).C5710D9CCC3E4D85(P_1, P_2, P_3);
		}

		static object C07F8033DB844DE4(object P_0, string P_1)
		{
			return ((IStringLocalizer)P_0)[P_1];
		}

		static string _425613A9941842CB(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static string _437728E4F39246EA()
		{
			return Provider.serverName;
		}

		static CSteamID _476810E891B84466()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return Provider.server;
		}

		static string _3D6B2EC01E78414E(string P_0, object P_1, object P_2, object P_3)
		{
			return string.Format(P_0, P_1, P_2, P_3);
		}

		static List<SteamPlayer> _19525C751A734360()
		{
			return Provider.clients;
		}

		static byte _968C1E31AD5D41F7()
		{
			return Provider.maxPlayers;
		}

		static string E725852CB7F44B84(string P_0, object P_1, object P_2)
		{
			return string.Format(P_0, P_1, P_2);
		}

		static object A33768E5CD554B74(object P_0, int P_1)
		{
			return ((FD59A46B5C464B4B)P_0).F9D54DAC19D84D2D(P_1);
		}

		static object _1D74583750E64827(object P_0, DateTimeOffset P_1)
		{
			return ((FD59A46B5C464B4B)P_0)._63CBECEBD56F4F2D(P_1);
		}

		static object _7A34B9DEF63D4BC8(object P_0, string P_1, string P_2)
		{
			return ((FD59A46B5C464B4B)P_0).FCD4CE9FCD924C41(P_1, P_2);
		}
	}

	[CompilerGenerated]
	private sealed class B5D3C58D61C74E08 : IEnumerable<(string ChatId, string? ThreadId, string BotToken)>, IEnumerable, IEnumerator<(string ChatId, string? ThreadId, string BotToken)>, IEnumerator, IDisposable
	{
		private int _1B7DFE1B959645E6;

		private (string ChatId, string? ThreadId, string BotToken) _8D7FC95DDF4F4DA8;

		private int _4F56AB021F374EF6;

		private string _616FAC2231C74E5F;

		public string _531EE05250704BB5;

		private string _79C75152AF1B4DE2;

		private string[] _7950A46993AB4FEB;

		private int D5CC18907A454550;

		(string ChatId, string? ThreadId, string BotToken) IEnumerator<(string ChatId, string? ThreadId, string BotToken)>.A2165C3467514125
		{
			[DebuggerHidden]
			get
			{
				return _8D7FC95DDF4F4DA8;
			}
		}

		object IEnumerator.B95872B84ADB4B89
		{
			[DebuggerHidden]
			get
			{
				return _8D7FC95DDF4F4DA8;
			}
		}

		[DebuggerHidden]
		public B5D3C58D61C74E08(int P_0)
		{
			_1B7DFE1B959645E6 = P_0;
			_4F56AB021F374EF6 = _4527EA7E9EAE4C33();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
			_79C75152AF1B4DE2 = null;
			_7950A46993AB4FEB = null;
			while (true)
			{
				int num = -953454934;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(-(-(-((~num2 + (((-219635013 ^ -(-unchecked(1723416301 * 1510982907))) - -983048869) ^ -1726277286)) ^ -(~(-1013159813 - -(289084282 - 1949835956)))) - -unchecked(~808624875 - unchecked(-725841516 * -1303514949)))) - -387910732)) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_00b3;
					case 0u:
						return;
					}
					break;
					IL_00b3:
					_1B7DFE1B959645E6 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
					num = -239476935;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool MoveNext()
		{
			int num = _1B7DFE1B959645E6;
			if (num != 0)
			{
				goto IL_000d;
			}
			goto IL_0269;
			IL_000d:
			int num2 = 332354392;
			goto IL_0012;
			IL_0012:
			string[] array = default;
			string[] array2 = default;
			string item = default;
			while (true)
			{
				int num3 = num2;
				uint num4;
				long result;
				object obj;
				switch ((num4 = (uint)(num3 + -(~-1114237455) + unchecked((0x7D0D03B1 ^ 0x12AB1E91) * 677973059) + (~(-(-785907919) ^ 0x6DD72A05) - (-637638475 + (unchecked(1312294695 * -1118212171) + (0x6A4F3AFB ^ 0x3B3CF89))) * -2132810713))) % 20)
				{
				case 11u:
					break;
				case 14u:
					if (!long.TryParse(array[_003CModule_003E._58ECCB512F2A43AC<int>(1006217019)], out result))
					{
						num2 = 445198022;
						continue;
					}
					obj = array[_003CModule_003E.F84FA79ABE6944BB<int>(1741630884)];
					goto IL_01f9;
				case 0u:
					_79C75152AF1B4DE2 = array2[^_003CModule_003E.F84FA79ABE6944BB<int>(1741630884)];
					_7950A46993AB4FEB = array2[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)..new Index(_003CModule_003E._390073C602714496<int>(-250964212), (byte)_003CModule_003E._390073C602714496<int>(-250964212) != 0)];
					num2 = 230871928;
					continue;
				case 3u:
					array = A426D7D9CDFE4635((object)_7950A46993AB4FEB[D5CC18907A454550], (char)_003CModule_003E._58ECCB512F2A43AC<int>(-1413852701), (StringSplitOptions)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563));
					num2 = 1366308931;
					continue;
				case 10u:
					_1B7DFE1B959645E6 = _003CModule_003E._8B9C7B12B1AE4949<int>(350091668);
					return (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0;
				case 13u:
					D5CC18907A454550 = _003CModule_003E._390073C602714496<int>(2131963235);
					num2 = 1082113290;
					continue;
				case 8u:
					goto IL_01c3;
				case 7u:
					obj = null;
					goto IL_01f9;
				case 19u:
					goto IL_0204;
				case 1u:
					_1B7DFE1B959645E6 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
					num2 = 1049286280;
					continue;
				case 12u:
					goto IL_0269;
				case 16u:
					goto IL_0285;
				case 15u:
					goto IL_02b0;
				case 9u:
					return (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
				case 4u:
					_8D7FC95DDF4F4DA8 = (ChatId: array[_003CModule_003E._58ECCB512F2A43AC<int>(352679804)], ThreadId: item, BotToken: _79C75152AF1B4DE2);
					num2 = -104728755;
					continue;
				case 18u:
					_7950A46993AB4FEB = null;
					num2 = ((int)num4 * -599845208) ^ -1518102243;
					continue;
				case 5u:
					D5CC18907A454550 += _003CModule_003E._58ECCB512F2A43AC<int>(1006217019);
					num2 = 1082113290;
					continue;
				case 6u:
					return (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
				case 17u:
					goto IL_0369;
				default:
					{
						return (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
					}
					IL_01f9:
					item = (string)obj;
					num2 = -29947721;
					continue;
				}
				break;
				IL_0369:
				int num5;
				if (num == _003CModule_003E._390073C602714496<int>(-250964212))
				{
					num2 = 266869916;
					num5 = num2;
				}
				else
				{
					num2 = 34905461;
					num5 = num2;
				}
				continue;
				IL_01c3:
				int num6;
				if (array.Length != _003CModule_003E._8B9C7B12B1AE4949<int>(-1540732256))
				{
					num2 = 445198022;
					num6 = num2;
				}
				else
				{
					num2 = 1671414949;
					num6 = num2;
				}
				continue;
				IL_0285:
				int num7;
				if (!long.TryParse(array[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)], out result))
				{
					num2 = 1049286280;
					num7 = num2;
				}
				else
				{
					num2 = 521474743;
					num7 = num2;
				}
				continue;
				IL_02b0:
				int num8;
				if (D5CC18907A454550 >= _7950A46993AB4FEB.Length)
				{
					num2 = -5761547;
					num8 = num2;
				}
				else
				{
					num2 = 1142278838;
					num8 = num2;
				}
				continue;
				IL_0204:
				array2 = A426D7D9CDFE4635((object)_616FAC2231C74E5F, (char)_003CModule_003E._390073C602714496<int>(-2114588973), (StringSplitOptions)_003CModule_003E._58ECCB512F2A43AC<int>(352679804));
				int num9;
				if (array2.Length < _003CModule_003E._8B9C7B12B1AE4949<int>(944380096))
				{
					num2 = 834133524;
					num9 = num2;
				}
				else
				{
					num2 = 845128475;
					num9 = num2;
				}
			}
			goto IL_000d;
			IL_0269:
			_1B7DFE1B959645E6 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
			num2 = 994575894;
			goto IL_0012;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw _27988570EC6F4EDD();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[DebuggerHidden]
		IEnumerator<(string ChatId, string? ThreadId, string BotToken)> IEnumerable<(string ChatId, string? ThreadId, string BotToken)>.GetEnumerator()
		{
			if (_1B7DFE1B959645E6 == _003CModule_003E._3F57E81A62734AC2<int>(765599498))
			{
				goto IL_0017;
			}
			goto IL_0135;
			IL_0017:
			int num = 940424539;
			goto IL_001c;
			IL_001c:
			B5D3C58D61C74E08 b5D3C58D61C74E = default;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(((0x17A62E71 ^ (-unchecked(647495329 + 1616431301) ^ -1958893243) ^ (unchecked(2083679045 * ~unchecked(~713883343 * 2011359117)) - (unchecked(unchecked(-975257377 + -1599053666) * 529709991) - 248820281 + (-(~-1796351291) ^ -2002407870)))) - num2 * -118048205 - 548841674) ^ -(-1427083715 ^ -989541808) ^ -(-2013260407 ^ -1107862939))) % 6)
				{
				case 5u:
					break;
				case 1u:
				{
					int num4;
					int num5;
					if (_4F56AB021F374EF6 == _4527EA7E9EAE4C33())
					{
						num4 = 1478667722;
						num5 = num4;
					}
					else
					{
						num4 = 2019944729;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -1735093020);
					continue;
				}
				case 3u:
					goto IL_0135;
				case 4u:
					_1B7DFE1B959645E6 = _003CModule_003E._3F57E81A62734AC2<int>(-1803194042);
					b5D3C58D61C74E = this;
					num = -486934564;
					continue;
				case 2u:
					num = (int)(num3 * 1936105480) ^ -48320060;
					continue;
				default:
					b5D3C58D61C74E._616FAC2231C74E5F = _531EE05250704BB5;
					return b5D3C58D61C74E;
				}
				break;
			}
			goto IL_0017;
			IL_0135:
			b5D3C58D61C74E = (B5D3C58D61C74E08)_07D87FC47B164F7C(_003CModule_003E._390073C602714496<int>(2131963235));
			num = -335704556;
			goto IL_001c;
		}

		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<(string, string, string)>)this).GetEnumerator();
		}

		static int _4527EA7E9EAE4C33()
		{
			return Environment.CurrentManagedThreadId;
		}

		static string[] A426D7D9CDFE4635(object P_0, char P_1, StringSplitOptions P_2)
		{
			return ((string)P_0).Split(P_1, P_2);
		}

		static object _27988570EC6F4EDD()
		{
			return new NotSupportedException();
		}

		static object _07D87FC47B164F7C(int P_0)
		{
			return new B5D3C58D61C74E08(P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct B2ADC0272AAE4A6E : IAsyncStateMachine
	{
		public int D3532B0CEFF14B4D;

		public AsyncTaskMethodBuilder F75751A067374718;

		public B7097FC49A384CFA D36C889D3E5041D0;

		public string D95AE0A3EE814EA0;

		public FC940335F4CA4D07 _0C7C7C78CA86480E;

		private TaskAwaiter AD6103C2DB724306;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = D3532B0CEFF14B4D;
			B7097FC49A384CFA b7097FC49A384CFA = D36C889D3E5041D0;
			try
			{
				try
				{
					if (num != 0)
					{
						goto IL_0017;
					}
					goto IL_00f3;
					IL_0017:
					int num2 = 1541808785;
					goto IL_001c;
					IL_001c:
					TaskAwaiter awaiter = default;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(-((~(num3 + -(-(unchecked((-596739448 ^ -1859877329) * 741805873) - -(-unchecked(-384058528 - 183826451 - 1644811386))))) - (~(~unchecked(-121202159 * (-83578196 + -1764595205))) - (379603263 * (1376282973 * --705759210) - (-1242449654 ^ 0x2C980134)))) * 1091222167 * -485200709 * -1055094093 + ~385725532))) % 7)
						{
						case 0u:
							break;
						default:
							goto end_IL_0011;
						case 1u:
							goto IL_00f3;
						case 3u:
							F75751A067374718.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						case 2u:
							awaiter.GetResult();
							num2 = 208520126;
							continue;
						case 5u:
						{
							awaiter = CAD0AC1723A14852(_418AC83FDDAC4D51((object)b7097FC49A384CFA, D95AE0A3EE814EA0, (object)_0C7C7C78CA86480E));
							int num5;
							int num6;
							if (awaiter.IsCompleted)
							{
								num5 = -1545473384;
								num6 = num5;
							}
							else
							{
								num5 = 749528196;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num4 * 1980620565);
							continue;
						}
						case 4u:
							num = (D3532B0CEFF14B4D = _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
							AD6103C2DB724306 = awaiter;
							num2 = 649304489;
							continue;
						case 6u:
							goto end_IL_0011;
						}
						break;
					}
					goto IL_0017;
					IL_00f3:
					awaiter = AD6103C2DB724306;
					AD6103C2DB724306 = default;
					num = (D3532B0CEFF14B4D = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
					num2 = -1915628816;
					goto IL_001c;
					end_IL_0011:;
				}
				catch (Exception ex)
				{
					_12306C1FC242465D(C179263454B44BF6._54DF173DA5E74DC3, ex, _003CModule_003E._8B9C7B12B1AE4949<string>(-2066674744), Array.Empty<object>());
				}
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num7 = 490145174;
					while (true)
					{
						int num3 = num7;
						uint num4;
						switch ((num4 = (uint)(-((~(num3 + -(-(unchecked((-596739448 ^ -1859877329) * 741805873) - -(-unchecked(-384058528 - 183826451 - 1644811386))))) - (~(~unchecked(-121202159 * (-83578196 + -1764595205))) - (379603263 * (1376282973 * --705759210) - (-1242449654 ^ 0x2C980134)))) * 1091222167 * -485200709 * -1055094093 + ~385725532))) % 4)
						{
						case 2u:
							break;
						default:
							return;
						case 3u:
							D3532B0CEFF14B4D = _003CModule_003E._3F57E81A62734AC2<int>(765599498);
							num7 = -459084099;
							continue;
						case 0u:
							F75751A067374718.SetException(exception);
							num7 = ((int)num4 * -1731503685) ^ 0x42AA64F4;
							continue;
						case 1u:
							return;
						}
						break;
					}
				}
			}
			D3532B0CEFF14B4D = _003CModule_003E._390073C602714496<int>(818201983);
			F75751A067374718.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			F75751A067374718.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _418AC83FDDAC4D51(object P_0, string P_1, object P_2)
		{
			return ((B7097FC49A384CFA)P_0).C36BF5A01F6A4A5B(P_1, (AECA8283EE0E4BAC)P_2);
		}

		static TaskAwaiter CAD0AC1723A14852(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static void _12306C1FC242465D(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct EEE6572818404A13 : IAsyncStateMachine
	{
		public int _40557D2D9E22431B;

		public AsyncTaskMethodBuilder _4AA0BB91079143CF;

		public _708ECF20BC9E451D _73F64EECB13F4CE4;

		public B7097FC49A384CFA _2FA4F7A28F6C46DC;

		public string F9FBB8FAE1F3487B;

		private TaskAwaiter _4C0F636A3A0244B3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _40557D2D9E22431B;
			B7097FC49A384CFA b7097FC49A384CFA = _2FA4F7A28F6C46DC;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_04be;
				IL_0014:
				int num2 = -854335273;
				goto IL_0019;
				IL_0019:
				TaskAwaiter awaiter = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(-(unchecked(unchecked(-935714511 * (989531297 - unchecked(1831939760 * 1856696331))) * -589341219) - ~(num3 + (~((-(~(1207273967 + -1964022512)) + (-853131714 ^ (--163344283 ^ 0x3E0402D1))) ^ -1821067243) ^ (-(-71493825 - ~(~(0x5D1495AB ^ -90607017))) ^ ~(-unchecked(-711660966 * -288759715) ^ 0x6AA4F517))) - (-1796042379 - unchecked(-7362723 * -771226643) - -(0x57ADF884 ^ 0x47D72E62) - unchecked(-893342107 * unchecked((0x4EE49A62 ^ -2139458734) * 1646425951))))) * -1769020765)) % 16)
					{
					case 0u:
						break;
					case 5u:
						awaiter.GetResult();
						num2 = 1221504693;
						continue;
					case 15u:
						num = (_40557D2D9E22431B = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
						num2 = -849593582;
						continue;
					case 8u:
						goto IL_018f;
					case 9u:
						_4AA0BB91079143CF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = (int)((num4 * 1336816544) ^ 0x720ADF63);
						continue;
					case 10u:
						awaiter = _4C0F636A3A0244B3;
						num2 = -815783587;
						continue;
					case 12u:
						num = (_40557D2D9E22431B = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563));
						_4C0F636A3A0244B3 = awaiter;
						_4AA0BB91079143CF.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 14u:
						goto IL_021c;
					case 11u:
						num = (_40557D2D9E22431B = _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
						_4C0F636A3A0244B3 = awaiter;
						num2 = 821081020;
						continue;
					case 3u:
						awaiter = _1FB6BA6F04E24320((object)b7097FC49A384CFA._8489AC4CC0CF4986(_73F64EECB13F4CE4.ACF9BC69E5294E28, (FC940335F4CA4D07)B250E9D60E7248C2(B250E9D60E7248C2(B250E9D60E7248C2(B250E9D60E7248C2(B250E9D60E7248C2(B250E9D60E7248C2(B250E9D60E7248C2(_707200F842644022(_76BF3F569B374E62(), _003CModule_003E._8B9C7B12B1AE4949<string>(-533721769), (object)_003CModule_003E._58ECCB512F2A43AC<string>(-1609090440)), _003CModule_003E._8B9C7B12B1AE4949<string>(-1196485114), (object)F9FBB8FAE1F3487B), _003CModule_003E.F84FA79ABE6944BB<string>(-1323536393), (object)_73F64EECB13F4CE4._37B20A4113D244AA), _003CModule_003E._3F57E81A62734AC2<string>(1348005833), (object)_73F64EECB13F4CE4._7CD049C055E3441A), _003CModule_003E._58ECCB512F2A43AC<string>(257570408), (object)_73F64EECB13F4CE4.D0085BCED909426B), _003CModule_003E._58ECCB512F2A43AC<string>(631314414), (object)_73F64EECB13F4CE4._35219130B15F4D94), _003CModule_003E._58ECCB512F2A43AC<string>(-2076785243), (object)_01A61AAFA2C4404D(_003CModule_003E._3F57E81A62734AC2<string>(537695922), (object)_73F64EECB13F4CE4.B38102437FF64506)), _003CModule_003E._58ECCB512F2A43AC<string>(347402841), (object)E0C94DD494A9410E(_73F64EECB13F4CE4._143FFF351A2C4104))));
						num2 = -927061676;
						continue;
					case 13u:
						goto IL_04be;
					case 2u:
					{
						int num7;
						int num8;
						if (A1BE6D06B23945EA(_73F64EECB13F4CE4.ACF9BC69E5294E28))
						{
							num7 = 1616668535;
							num8 = num7;
						}
						else
						{
							num7 = 1756139500;
							num8 = num7;
						}
						num2 = num7 ^ ((int)num4 * -399473103);
						continue;
					}
					case 1u:
					{
						int num5;
						int num6;
						if (awaiter.IsCompleted)
						{
							num5 = 2064376588;
							num6 = num5;
						}
						else
						{
							num5 = -341995825;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num4 * 2088825380);
						continue;
					}
					case 6u:
						_4C0F636A3A0244B3 = default;
						num2 = (int)(num4 * 990948838) ^ -677146306;
						continue;
					case 4u:
						return;
					default:
						awaiter.GetResult();
						goto end_IL_000e;
					}
					break;
					IL_021c:
					string text = _73F64EECB13F4CE4._8DCA212F88FC4301;
					string text2 = _1CA9676F9EF141DA((LocalizedString)_88911403ABBE4421((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._8B9C7B12B1AE4949<string>(902765862)));
					int num9 = _003CModule_003E._3F57E81A62734AC2<int>(-237769836);
					B57BCC7426FB478D[] array = new B57BCC7426FB478D[_003CModule_003E._58ECCB512F2A43AC<int>(1751645849)];
					array[_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563)] = _81EF6BD8F9214C5F(_73F64EECB13F4CE4);
					array[_003CModule_003E._58ECCB512F2A43AC<int>(1006217019)] = D4EE704625AB4B2D(_73F64EECB13F4CE4);
					array[_003CModule_003E._8B9C7B12B1AE4949<int>(-1540732256)] = DA7AA132A7494DC8(_73F64EECB13F4CE4);
					array[_003CModule_003E.F84FA79ABE6944BB<int>(-1420849552)] = B57BCC7426FB478D.D14D30CDEC3E4BB2;
					array[_003CModule_003E._390073C602714496<int>(1661075637)] = B57BCC7426FB478D.CB4C7FBDFCFE4AF9(_003CModule_003E._8B9C7B12B1AE4949<string>(1427578606), _1CA9676F9EF141DA((LocalizedString)_88911403ABBE4421((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._58ECCB512F2A43AC<string>(1654477271))), F9FBB8FAE1F3487B);
					array[_003CModule_003E._390073C602714496<int>(975705554)] = B57BCC7426FB478D.D14D30CDEC3E4BB2;
					array[_003CModule_003E._3F57E81A62734AC2<int>(887139723)] = _77C04349D42C4110(_73F64EECB13F4CE4);
					awaiter = _1FB6BA6F04E24320((object)b7097FC49A384CFA._9F92E532AF534C82(text, text2, num9, array));
					int num10;
					if (awaiter.IsCompleted)
					{
						num2 = -849593582;
						num10 = num2;
					}
					else
					{
						num2 = 47724406;
						num10 = num2;
					}
					continue;
					IL_018f:
					int num11;
					if (num != _003CModule_003E._58ECCB512F2A43AC<int>(1006217019))
					{
						num2 = 1339858009;
						num11 = num2;
					}
					else
					{
						num2 = -34794143;
						num11 = num2;
					}
				}
				goto IL_0014;
				IL_04be:
				awaiter = _4C0F636A3A0244B3;
				_4C0F636A3A0244B3 = default;
				num = (_40557D2D9E22431B = _003CModule_003E._390073C602714496<int>(-736908096));
				num2 = 1542498664;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_40557D2D9E22431B = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				_4AA0BB91079143CF.SetException(exception);
				return;
			}
			_40557D2D9E22431B = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
			while (true)
			{
				int num12 = -1627450533;
				while (true)
				{
					int num3 = num12;
					uint num4;
					switch ((num4 = (uint)(-(unchecked(unchecked(-935714511 * (989531297 - unchecked(1831939760 * 1856696331))) * -589341219) - ~(num3 + (~((-(~(1207273967 + -1964022512)) + (-853131714 ^ (--163344283 ^ 0x3E0402D1))) ^ -1821067243) ^ (-(-71493825 - ~(~(0x5D1495AB ^ -90607017))) ^ ~(-unchecked(-711660966 * -288759715) ^ 0x6AA4F517))) - (-1796042379 - unchecked(-7362723 * -771226643) - -(0x57ADF884 ^ 0x47D72E62) - unchecked(-893342107 * unchecked((0x4EE49A62 ^ -2139458734) * 1646425951))))) * -1769020765)) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_06d0;
					case 1u:
						return;
					}
					break;
					IL_06d0:
					_4AA0BB91079143CF.SetResult();
					num12 = ((int)num4 * -1439480861) ^ -427761286;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_4AA0BB91079143CF.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool A1BE6D06B23945EA(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}

		static object _76BF3F569B374E62()
		{
			return new FC940335F4CA4D07();
		}

		static object _707200F842644022(object P_0, string P_1, object P_2)
		{
			return ((FC940335F4CA4D07)P_0).C6D3E05E6B734BAF(P_1, P_2);
		}

		static object B250E9D60E7248C2(object P_0, string P_1, object P_2)
		{
			return ((FC940335F4CA4D07)P_0).C6D3E05E6B734BAF(P_1, P_2);
		}

		static string _01A61AAFA2C4404D(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static string E0C94DD494A9410E(float P_0)
		{
			return _9AB67761792440A7._9EF78793AEAE41AB(P_0);
		}

		static TaskAwaiter _1FB6BA6F04E24320(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static object _88911403ABBE4421(object P_0, string P_1)
		{
			return ((IStringLocalizer)P_0)[P_1];
		}

		static string _1CA9676F9EF141DA(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct CC44D8CFDD9E41C5 : IAsyncStateMachine
	{
		public int A46C15FCA3604F26;

		public AsyncTaskMethodBuilder _6C7AF7A56A8343E5;

		public _708ECF20BC9E451D D1D6669A363442F1;

		public B7097FC49A384CFA CF99A70477D84357;

		public string _64CC312961184CC5;

		public string _99F6CC7DCB36421F;

		public bool EE08776D551D4362;

		private TaskAwaiter C3A341A27D9E4987;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = A46C15FCA3604F26;
			B7097FC49A384CFA b7097FC49A384CFA = CF99A70477D84357;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_03b8;
				IL_0014:
				int num2 = -1985787393;
				goto IL_0019;
				IL_0019:
				TaskAwaiter awaiter = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(-unchecked(1216755562 - 1889601997 - (-221301670 ^ -2131249178)) - (unchecked(1999104545 * (1839625152 + (~1973536302 + (0x2E52DE4D ^ 0xDD0EDAB)))) - (num3 - (-(--1610905873) ^ 0x8E5E17E)) * -447837363) * 669037231)) % 19)
					{
					case 0u:
						break;
					case 3u:
						num = (A46C15FCA3604F26 = _003CModule_003E._3F57E81A62734AC2<int>(1017304263));
						num2 = -62022384;
						continue;
					case 5u:
						C3A341A27D9E4987 = awaiter;
						num2 = ((int)num4 * -1572444909) ^ 0x7A7F1ADE;
						continue;
					case 15u:
						awaiter.GetResult();
						num2 = 1459722404;
						continue;
					case 13u:
					{
						string text = D1D6669A363442F1._8DCA212F88FC4301;
						string text2 = _99F6CC7DCB36421F;
						int num7 = (EE08776D551D4362 ? _003CModule_003E._58ECCB512F2A43AC<int>(-73831359) : _003CModule_003E._8B9C7B12B1AE4949<int>(-81258033));
						B57BCC7426FB478D[] array = new B57BCC7426FB478D[_003CModule_003E.F84FA79ABE6944BB<int>(2084623923)];
						array[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)] = _81EF6BD8F9214C5F(D1D6669A363442F1);
						array[_003CModule_003E._3F57E81A62734AC2<int>(1017304263)] = D4EE704625AB4B2D(D1D6669A363442F1);
						array[_003CModule_003E._3F57E81A62734AC2<int>(-845933485)] = B57BCC7426FB478D.D14D30CDEC3E4BB2;
						array[_003CModule_003E._3F57E81A62734AC2<int>(-1030831117)] = B57BCC7426FB478D.CB4C7FBDFCFE4AF9(_003CModule_003E._390073C602714496<string>(-1633220718), FB636D6419DF416D((LocalizedString)_6EB61AD56B8948D2((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._3F57E81A62734AC2<string>(-1984526317))), _64CC312961184CC5);
						awaiter = _217773B6B6EA45BB((object)b7097FC49A384CFA._9F92E532AF534C82(text, text2, num7, array));
						num2 = 484717014;
						continue;
					}
					case 2u:
						num = (A46C15FCA3604F26 = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
						num2 = -867971680;
						continue;
					case 6u:
						_6C7AF7A56A8343E5.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 1u:
						C3A341A27D9E4987 = default;
						num2 = (int)((num4 * 1720836232) ^ 0x50BC1A52);
						continue;
					case 9u:
						C3A341A27D9E4987 = default;
						num = (A46C15FCA3604F26 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
						num2 = 507172628;
						continue;
					case 10u:
					{
						int num8;
						int num9;
						if (!_9389A3C604934422(D1D6669A363442F1.ACF9BC69E5294E28))
						{
							num8 = -2008859220;
							num9 = num8;
						}
						else
						{
							num8 = 150276988;
							num9 = num8;
						}
						num2 = num8 ^ (int)(num4 * 1984477814);
						continue;
					}
					case 8u:
						goto IL_02d6;
					case 4u:
						goto IL_03b8;
					case 16u:
						goto IL_03c9;
					case 12u:
						num = (A46C15FCA3604F26 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563));
						num2 = 195697898;
						continue;
					case 18u:
					{
						int num5;
						int num6;
						if (!awaiter.IsCompleted)
						{
							num5 = 1684105466;
							num6 = num5;
						}
						else
						{
							num5 = -1139041775;
							num6 = num5;
						}
						num2 = num5 ^ ((int)num4 * -1925365839);
						continue;
					}
					case 17u:
						C3A341A27D9E4987 = awaiter;
						_6C7AF7A56A8343E5.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = ((int)num4 * -1270140829) ^ 0x3632F746;
						continue;
					case 11u:
						return;
					case 7u:
						awaiter = C3A341A27D9E4987;
						num2 = -448023717;
						continue;
					default:
						awaiter.GetResult();
						goto end_IL_000e;
					}
					break;
					IL_03c9:
					int num10;
					if (num != _003CModule_003E._3F57E81A62734AC2<int>(1017304263))
					{
						num2 = 1404424091;
						num10 = num2;
					}
					else
					{
						num2 = 2101478694;
						num10 = num2;
					}
					continue;
					IL_02d6:
					awaiter = _217773B6B6EA45BB((object)b7097FC49A384CFA._8489AC4CC0CF4986(D1D6669A363442F1.ACF9BC69E5294E28, (FC940335F4CA4D07)_5AD9DBC60FFF413F(_5AD9DBC60FFF413F(_5AD9DBC60FFF413F(_5AD9DBC60FFF413F(_5AD9DBC60FFF413F(EB166008D9DC4DCA(D9B29E6D366B439A(), _003CModule_003E._58ECCB512F2A43AC<string>(1002999238), (object)_003CModule_003E.F84FA79ABE6944BB<string>(1718075107)), _003CModule_003E.F84FA79ABE6944BB<string>(-980543354), (object)_64CC312961184CC5), _003CModule_003E._3F57E81A62734AC2<string>(1027769072), (object)D1D6669A363442F1._37B20A4113D244AA), _003CModule_003E._3F57E81A62734AC2<string>(1348005833), (object)D1D6669A363442F1._7CD049C055E3441A), _003CModule_003E._390073C602714496<string>(1220594327), (object)D1D6669A363442F1.D0085BCED909426B), _003CModule_003E.F84FA79ABE6944BB<string>(1778509575), (object)D1D6669A363442F1._35219130B15F4D94)));
					int num11;
					if (!awaiter.IsCompleted)
					{
						num2 = 1578135980;
						num11 = num2;
					}
					else
					{
						num2 = -867971680;
						num11 = num2;
					}
				}
				goto IL_0014;
				IL_03b8:
				awaiter = C3A341A27D9E4987;
				num2 = 403949117;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				A46C15FCA3604F26 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
				while (true)
				{
					int num12 = 1555582120;
					while (true)
					{
						int num3 = num12;
						uint num4;
						switch ((num4 = (uint)(-unchecked(1216755562 - 1889601997 - (-221301670 ^ -2131249178)) - (unchecked(1999104545 * (1839625152 + (~1973536302 + (0x2E52DE4D ^ 0xDD0EDAB)))) - (num3 - (-(--1610905873) ^ 0x8E5E17E)) * -447837363) * 669037231)) % 3)
						{
						case 2u:
							break;
						default:
							return;
						case 1u:
							goto IL_0522;
						case 0u:
							return;
						}
						break;
						IL_0522:
						_6C7AF7A56A8343E5.SetException(exception);
						num12 = (int)(num4 * 740083246) ^ -1184900344;
					}
				}
			}
			A46C15FCA3604F26 = _003CModule_003E._58ECCB512F2A43AC<int>(728482992);
			_6C7AF7A56A8343E5.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_6C7AF7A56A8343E5.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool _9389A3C604934422(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}

		static object D9B29E6D366B439A()
		{
			return new FC940335F4CA4D07();
		}

		static object EB166008D9DC4DCA(object P_0, string P_1, object P_2)
		{
			return ((FC940335F4CA4D07)P_0).C6D3E05E6B734BAF(P_1, P_2);
		}

		static object _5AD9DBC60FFF413F(object P_0, string P_1, object P_2)
		{
			return ((FC940335F4CA4D07)P_0).C6D3E05E6B734BAF(P_1, P_2);
		}

		static TaskAwaiter _217773B6B6EA45BB(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static object _6EB61AD56B8948D2(object P_0, string P_1)
		{
			return ((IStringLocalizer)P_0)[P_1];
		}

		static string FB636D6419DF416D(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _122D5D6A9EAC456D : IAsyncStateMachine
	{
		public int _491755B554494568;

		public AsyncTaskMethodBuilder F197FBF306F749A0;

		public _708ECF20BC9E451D B5DAB96E3E2648EA;

		public B7097FC49A384CFA FBAC4E63C4844408;

		public string FFC3CFCD7CDD44BD;

		public EFlagLevel _84CB94FB9EF34CF4;

		public ECheckCategory _28BECE69B48A4280;

		public ECheckType _6E213B3B05EB4B8B;

		public (byte[] data, string format, Guid transactionId)? _5AF8A03824904CDE;

		private TaskAwaiter _978AAE73E3174930;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _491755B554494568;
			B7097FC49A384CFA b7097FC49A384CFA = FBAC4E63C4844408;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_0397;
				IL_0014:
				int num2 = -1100490571;
				goto IL_0019;
				IL_0019:
				TaskAwaiter awaiter = default;
				(byte[], string)? tuple = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					(byte[], string)? tuple2;
					(byte[], string)? tuple3;
					string text;
					string text2;
					int num11;
					B57BCC7426FB478D[] array;
					switch ((num4 = (uint)(num3 - (unchecked(-2119346695 * -889479877) - (-152428604 ^ -152671693) + 767818095 - 1568150212 - (-2036223564 ^ (1779359283 - -763029259 + (~330505084 - (-369968032 + 409671124)))) + (~(~(~253864284) + -(~1388046494)) + -822940211) + unchecked(~(~(~unchecked(unchecked(-2129160264 + -1724602350) * 1643091135))) * -1824160755)) + ~(-unchecked(unchecked(-1166313115 * ~(~1175816451)) * -76242543)) - -(~(-(~(1361108442 - 2123124353)))))) % 19)
					{
					case 6u:
						break;
					case 17u:
					{
						int num9;
						int num10;
						if (!awaiter.IsCompleted)
						{
							num9 = 1119956892;
							num10 = num9;
						}
						else
						{
							num9 = -1776992520;
							num10 = num9;
						}
						num2 = num9 ^ ((int)num4 * -712565184);
						continue;
					}
					case 15u:
						awaiter = _29F296962B624F9B((object)b7097FC49A384CFA._8489AC4CC0CF4986(B5DAB96E3E2648EA.ACF9BC69E5294E28, (FC940335F4CA4D07)_97D21D4B15F34DEE(_97D21D4B15F34DEE(_97D21D4B15F34DEE(_97D21D4B15F34DEE(_97D21D4B15F34DEE(_97D21D4B15F34DEE(_97D21D4B15F34DEE(_97D21D4B15F34DEE(_97D21D4B15F34DEE(_0B0B6737E38F4000(_3BE9150A1EC640DA(), _003CModule_003E._8B9C7B12B1AE4949<string>(-533721769), (object)_003CModule_003E._3F57E81A62734AC2<string>(1990204218)), _003CModule_003E._58ECCB512F2A43AC<string>(-581809219), (object)FFC3CFCD7CDD44BD), _003CModule_003E._3F57E81A62734AC2<string>(1027769072), (object)B5DAB96E3E2648EA._37B20A4113D244AA), _003CModule_003E._8B9C7B12B1AE4949<string>(-671672370), (object)B5DAB96E3E2648EA._7CD049C055E3441A), _003CModule_003E._3F57E81A62734AC2<string>(-1215613118), (object)B5DAB96E3E2648EA.D0085BCED909426B), _003CModule_003E._58ECCB512F2A43AC<string>(631314414), (object)B5DAB96E3E2648EA._35219130B15F4D94), _003CModule_003E.F84FA79ABE6944BB<string>(-622441698), (object)B5DAB96E3E2648EA.B38102437FF64506), _003CModule_003E._390073C602714496<string>(335798045), (object)FF160F39EBA34EA0(_003CModule_003E.F84FA79ABE6944BB<string>(1220150161), (object)_84CB94FB9EF34CF4)), _003CModule_003E._58ECCB512F2A43AC<string>(-120291962), (object)_8C09963B071C4516(_003CModule_003E._390073C602714496<string>(1833929210), (object)_28BECE69B48A4280, (object)_6E213B3B05EB4B8B)), _003CModule_003E._58ECCB512F2A43AC<string>(347402841), (object)B5DAB96E3E2648EA._143FFF351A2C4104)));
						num2 = -1142826035;
						continue;
					case 18u:
						num = (_491755B554494568 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
						num2 = -1997829082;
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (awaiter.IsCompleted)
						{
							num7 = -1739773058;
							num8 = num7;
						}
						else
						{
							num7 = -1589137863;
							num8 = num7;
						}
						num2 = num7 ^ (int)(num4 * 55856130);
						continue;
					}
					case 9u:
						_978AAE73E3174930 = awaiter;
						num2 = (int)((num4 * 1437893389) ^ 0x687179D2);
						continue;
					case 12u:
						if (!_5AF8A03824904CDE.HasValue)
						{
							num2 = -1851486213;
							continue;
						}
						tuple2 = (_5AF8A03824904CDE.Value.data, _8C09963B071C4516(_003CModule_003E.F84FA79ABE6944BB<string>(-846818377), (object)B5DAB96E3E2648EA._37B20A4113D244AA, (object)_5AF8A03824904CDE.Value.format));
						goto IL_0426;
					case 10u:
						num = (_491755B554494568 = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
						_978AAE73E3174930 = awaiter;
						F197FBF306F749A0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 0u:
						awaiter.GetResult();
						num2 = -1316459050;
						continue;
					case 4u:
						num = (_491755B554494568 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
						num2 = 1519289976;
						continue;
					case 8u:
						goto IL_0397;
					case 13u:
						goto IL_03b4;
					case 11u:
						tuple2 = tuple;
						goto IL_0426;
					case 16u:
					{
						int num5;
						int num6;
						if (!_031AA3ABCB8D44D1(B5DAB96E3E2648EA.ACF9BC69E5294E28))
						{
							num5 = -388604116;
							num6 = num5;
						}
						else
						{
							num5 = 824204919;
							num6 = num5;
						}
						num2 = num5 ^ ((int)num4 * -1179686755);
						continue;
					}
					case 5u:
						tuple = null;
						num2 = ((int)num4 * -973398947) ^ 0x5C4357FC;
						continue;
					case 14u:
						num = (_491755B554494568 = _003CModule_003E._390073C602714496<int>(-250964212));
						num2 = -901269001;
						continue;
					case 2u:
						F197FBF306F749A0.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					case 3u:
						awaiter = _978AAE73E3174930;
						_978AAE73E3174930 = default;
						num2 = -1545666394;
						continue;
					default:
						{
							awaiter.GetResult();
							goto end_IL_000e;
						}
						IL_0426:
						tuple3 = tuple2;
						text = B5DAB96E3E2648EA._8DCA212F88FC4301;
						text2 = FFC3CFCD7CDD44BD;
						num11 = _003CModule_003E._3F57E81A62734AC2<int>(-237769836);
						array = new B57BCC7426FB478D[_003CModule_003E._8B9C7B12B1AE4949<int>(-741019077)];
						array[_003CModule_003E._390073C602714496<int>(2131963235)] = _81EF6BD8F9214C5F(B5DAB96E3E2648EA);
						array[_003CModule_003E._3F57E81A62734AC2<int>(1017304263)] = D4EE704625AB4B2D(B5DAB96E3E2648EA);
						array[_003CModule_003E._8B9C7B12B1AE4949<int>(-1540732256)] = DA7AA132A7494DC8(B5DAB96E3E2648EA);
						array[_003CModule_003E._3F57E81A62734AC2<int>(-1030831117)] = B57BCC7426FB478D.D14D30CDEC3E4BB2;
						array[_003CModule_003E.F84FA79ABE6944BB<int>(2084623923)] = B57BCC7426FB478D._677432EDFDA943DB(_003CModule_003E._8B9C7B12B1AE4949<string>(1427578606), _7893D2694867492D((LocalizedString)_8067A0F168914E04((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E.F84FA79ABE6944BB<string>(2076176763))), FF160F39EBA34EA0(_003CModule_003E._58ECCB512F2A43AC<string>(-683996744), (object)_84CB94FB9EF34CF4));
						array[_003CModule_003E._390073C602714496<int>(975705554)] = B57BCC7426FB478D._677432EDFDA943DB(_003CModule_003E._3F57E81A62734AC2<string>(1606610050), _7893D2694867492D((LocalizedString)_8067A0F168914E04((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E.F84FA79ABE6944BB<string>(-1696746666))), _8C09963B071C4516(_003CModule_003E.F84FA79ABE6944BB<string>(-503825338), (object)_28BECE69B48A4280, (object)_6E213B3B05EB4B8B));
						array[_003CModule_003E.F84FA79ABE6944BB<int>(604638872)] = B57BCC7426FB478D.D14D30CDEC3E4BB2;
						array[_003CModule_003E._390073C602714496<int>(-1777584834)] = _77C04349D42C4110(B5DAB96E3E2648EA);
						awaiter = _29F296962B624F9B((object)b7097FC49A384CFA._9F92E532AF534C82(text, text2, num11, array, tuple3));
						num2 = 1564973459;
						continue;
					}
					break;
					IL_03b4:
					int num12;
					if (num != _003CModule_003E._3F57E81A62734AC2<int>(1017304263))
					{
						num2 = -860746250;
						num12 = num2;
					}
					else
					{
						num2 = -904066510;
						num12 = num2;
					}
				}
				goto IL_0014;
				IL_0397:
				awaiter = _978AAE73E3174930;
				_978AAE73E3174930 = default;
				num2 = -2117917139;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_491755B554494568 = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
				F197FBF306F749A0.SetException(exception);
				return;
			}
			_491755B554494568 = _003CModule_003E._390073C602714496<int>(818201983);
			F197FBF306F749A0.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			F197FBF306F749A0.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static bool _031AA3ABCB8D44D1(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}

		static object _3BE9150A1EC640DA()
		{
			return new FC940335F4CA4D07();
		}

		static object _0B0B6737E38F4000(object P_0, string P_1, object P_2)
		{
			return ((FC940335F4CA4D07)P_0).C6D3E05E6B734BAF(P_1, P_2);
		}

		static object _97D21D4B15F34DEE(object P_0, string P_1, object P_2)
		{
			return ((FC940335F4CA4D07)P_0).C6D3E05E6B734BAF(P_1, P_2);
		}

		static string FF160F39EBA34EA0(string P_0, object P_1)
		{
			return string.Format(P_0, P_1);
		}

		static string _8C09963B071C4516(string P_0, object P_1, object P_2)
		{
			return string.Format(P_0, P_1, P_2);
		}

		static TaskAwaiter _29F296962B624F9B(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static object _8067A0F168914E04(object P_0, string P_1)
		{
			return ((IStringLocalizer)P_0)[P_1];
		}

		static string _7893D2694867492D(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _8B2A57B0D3E34172 : IAsyncStateMachine
	{
		public int B0ECD447CEEE4AEE;

		public AsyncTaskMethodBuilder C10DEC1950E04E23;

		public int FFC7583256664426;

		public B7097FC49A384CFA DEFE89648BCD4D75;

		public byte[] _136C945CB4E441F5;

		private TaskAwaiter F303B938D9DD4F23;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = B0ECD447CEEE4AEE;
			B7097FC49A384CFA b7097FC49A384CFA = DEFE89648BCD4D75;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_0161;
				IL_0014:
				int num2 = 1582039063;
				goto IL_0019;
				IL_0019:
				TaskAwaiter awaiter = default;
				string text = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(-1005045640 - ~((0x6556AC7B ^ -1007934265) + (0x785FEFF6 ^ 0x41066B02) + 1745513515 * -438329911 - -(-num3 * -884886791 * 446892239) + (-626337247 + 17290255 - ~-1405702163)))) % 8)
					{
					case 2u:
						break;
					case 6u:
						F303B938D9DD4F23 = awaiter;
						C10DEC1950E04E23.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = (int)((num4 * 1292447403) ^ 0x25AF8AB0);
						continue;
					case 5u:
						goto IL_00c2;
					case 0u:
						goto IL_0161;
					case 4u:
						return;
					case 1u:
						text = ConfigurationBinder.GetValue<string>(C179263454B44BF6.F4734FD3602D47CD, _003CModule_003E._390073C602714496<string>(1391531069), _003CModule_003E._390073C602714496<string>(-485078612)) ?? _003CModule_003E.F84FA79ABE6944BB<string>(2095790532);
						num2 = 1850038003;
						continue;
					case 3u:
						num = (B0ECD447CEEE4AEE = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
						num2 = -1878044964;
						continue;
					default:
						awaiter.GetResult();
						goto end_IL_000e;
					}
					break;
					IL_00c2:
					IStringLocalizer val = C179263454B44BF6._66EFCEB30AD8408A;
					string text2 = _003CModule_003E.F84FA79ABE6944BB<string>(-1936231962);
					object[] array = new object[_003CModule_003E._390073C602714496<int>(-250964212)];
					array[_003CModule_003E._390073C602714496<int>(2131963235)] = new
					{
						GlitchBases = FFC7583256664426
					};
					LocalizedString val2 = (LocalizedString)_8D44886438584E3B((object)val, text2, array);
					awaiter = _88B16DA039AE4A03((object)b7097FC49A384CFA._9F92E532AF534C82(text, _02390F865C0E4D39(val2), _003CModule_003E._3F57E81A62734AC2<int>(-237769836), Array.Empty<B57BCC7426FB478D>(), (_136C945CB4E441F5, _003CModule_003E._58ECCB512F2A43AC<string>(2036458005))));
					int num5;
					if (!awaiter.IsCompleted)
					{
						num2 = -1045715311;
						num5 = num2;
					}
					else
					{
						num2 = -20596347;
						num5 = num2;
					}
				}
				goto IL_0014;
				IL_0161:
				awaiter = F303B938D9DD4F23;
				F303B938D9DD4F23 = default;
				num = (B0ECD447CEEE4AEE = _003CModule_003E.F84FA79ABE6944BB<int>(1441711120));
				num2 = -20596347;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				B0ECD447CEEE4AEE = _003CModule_003E._390073C602714496<int>(818201983);
				C10DEC1950E04E23.SetException(exception);
				return;
			}
			B0ECD447CEEE4AEE = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
			C10DEC1950E04E23.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			C10DEC1950E04E23.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _8D44886438584E3B(object P_0, string P_1, object[] P_2)
		{
			return ((IStringLocalizer)P_0)[P_1, P_2];
		}

		static string _02390F865C0E4D39(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}

		static TaskAwaiter _88B16DA039AE4A03(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct BE4EBFB0425E425B : IAsyncStateMachine
	{
		public int _9F89815B72034538;

		public AsyncTaskMethodBuilder A67CB9F0984B47EB;

		public B7097FC49A384CFA _9C727A28DFAE4564;

		public FF4343C122D84FC9 F01E0544C96B47D9;

		private TaskAwaiter _6CA721EC3DBE4576;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			int num = _9F89815B72034538;
			B7097FC49A384CFA b7097FC49A384CFA = _9C727A28DFAE4564;
			try
			{
				if (num != 0)
				{
					goto IL_0014;
				}
				goto IL_0134;
				IL_0014:
				int num2 = -1624402116;
				goto IL_0019;
				IL_0019:
				TaskAwaiter awaiter = default;
				string text = default;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(-(~num3 - (~unchecked(unchecked((-1218390675 + 266952489) * -344616061) * 893627495) + (unchecked(~unchecked(-1660367662 - 1467838123) * 1691599733) + (unchecked(154225681 * (0xA9238C9 ^ -1117634328)) + -(-1796101745 - -1307363044))) + (unchecked(-1649046351 * 1056279113) + (-1026757342 - ~(994279311 - 245675059)) + (0x3BC8B2C5 ^ -unchecked(unchecked(831085424 - -1360625849) + unchecked(835569899 * -874396157)))))))) % 9)
					{
					case 3u:
						break;
					default:
						goto end_IL_000e;
					case 4u:
						num = (_9F89815B72034538 = _003CModule_003E.F84FA79ABE6944BB<int>(1398637845));
						_6CA721EC3DBE4576 = awaiter;
						A67CB9F0984B47EB.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num2 = -1386415523;
						continue;
					case 7u:
						goto IL_0134;
					case 0u:
						awaiter.GetResult();
						num2 = 1452556752;
						continue;
					case 8u:
						text = ConfigurationBinder.GetValue<string>(C179263454B44BF6.F4734FD3602D47CD, _003CModule_003E._3F57E81A62734AC2<string>(-1534125016), _003CModule_003E.F84FA79ABE6944BB<string>(2095790532)) ?? _003CModule_003E._390073C602714496<string>(-485078612);
						num2 = -1191242685;
						continue;
					case 5u:
					{
						string text2 = text;
						string text3 = _5A2E3B108D3B4EB2((LocalizedString)E21BC98736824BA7((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._58ECCB512F2A43AC<string>(1662713999)));
						int num7 = _003CModule_003E.F84FA79ABE6944BB<int>(390865658);
						B57BCC7426FB478D[] array = new B57BCC7426FB478D[_003CModule_003E._58ECCB512F2A43AC<int>(1018572111)];
						array[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)] = B57BCC7426FB478D._677432EDFDA943DB(_003CModule_003E.F84FA79ABE6944BB<string>(-1672627745), _5A2E3B108D3B4EB2((LocalizedString)E21BC98736824BA7((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E.F84FA79ABE6944BB<string>(1936353473))), BAA2097DC4564078(_003CModule_003E._8B9C7B12B1AE4949<string>(601876534), (object)_246F02B0A1E448AD((object)F01E0544C96B47D9), (object)_003CModule_003E._390073C602714496<string>(-1338139207), (object)_246F02B0A1E448AD((object)F01E0544C96B47D9)));
						array[_003CModule_003E._390073C602714496<int>(-250964212)] = B57BCC7426FB478D.D14D30CDEC3E4BB2;
						array[_003CModule_003E.F84FA79ABE6944BB<int>(-1423102128)] = B57BCC7426FB478D.CB4C7FBDFCFE4AF9(_003CModule_003E._58ECCB512F2A43AC<string>(-1333415595), _003CModule_003E._58ECCB512F2A43AC<string>(-391848443), _07083B92003B4697((object)F01E0544C96B47D9));
						array[_003CModule_003E._3F57E81A62734AC2<int>(-1030831117)] = B57BCC7426FB478D.CB4C7FBDFCFE4AF9(_003CModule_003E._3F57E81A62734AC2<string>(1543252643), _003CModule_003E._3F57E81A62734AC2<string>(1800131997), _1BCBF7A213414757((object)F01E0544C96B47D9));
						array[_003CModule_003E._58ECCB512F2A43AC<int>(1659754234)] = B57BCC7426FB478D.CB4C7FBDFCFE4AF9(_003CModule_003E._58ECCB512F2A43AC<string>(-1323119685), _003CModule_003E.F84FA79ABE6944BB<string>(-27107322), _826A9BB172A2404B((object)F01E0544C96B47D9));
						array[_003CModule_003E._390073C602714496<int>(975705554)] = B57BCC7426FB478D.CB4C7FBDFCFE4AF9(_003CModule_003E._8B9C7B12B1AE4949<string>(889271032), _003CModule_003E._58ECCB512F2A43AC<string>(917285169), _2F24AA677F784EAC(CBF5701BDD9A47A9((object)F01E0544C96B47D9), _003CModule_003E._8B9C7B12B1AE4949<string>(-1097017469), _278EFFB6B54B4A71((object)F01E0544C96B47D9), _003CModule_003E.F84FA79ABE6944BB<string>(-986641667)));
						awaiter = A87F2F6A74134685((object)b7097FC49A384CFA._9F92E532AF534C82(text2, text3, num7, array));
						num2 = 1527505945;
						continue;
					}
					case 6u:
						return;
					case 2u:
					{
						int num5;
						int num6;
						if (!awaiter.IsCompleted)
						{
							num5 = -1401048777;
							num6 = num5;
						}
						else
						{
							num5 = 1610532253;
							num6 = num5;
						}
						num2 = num5 ^ (int)(num4 * 1017117792);
						continue;
					}
					case 1u:
						goto end_IL_000e;
					}
					break;
				}
				goto IL_0014;
				IL_0134:
				awaiter = _6CA721EC3DBE4576;
				_6CA721EC3DBE4576 = default;
				num = (_9F89815B72034538 = _003CModule_003E._390073C602714496<int>(-736908096));
				num2 = 2070849821;
				goto IL_0019;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num8 = 1154804662;
					while (true)
					{
						int num3 = num8;
						uint num4;
						switch ((num4 = (uint)(-(~num3 - (~unchecked(unchecked((-1218390675 + 266952489) * -344616061) * 893627495) + (unchecked(~unchecked(-1660367662 - 1467838123) * 1691599733) + (unchecked(154225681 * (0xA9238C9 ^ -1117634328)) + -(-1796101745 - -1307363044))) + (unchecked(-1649046351 * 1056279113) + (-1026757342 - ~(994279311 - 245675059)) + (0x3BC8B2C5 ^ -unchecked(unchecked(831085424 - -1360625849) + unchecked(835569899 * -874396157)))))))) % 3)
						{
						case 0u:
							break;
						default:
							return;
						case 2u:
							goto IL_04c4;
						case 1u:
							return;
						}
						break;
						IL_04c4:
						_9F89815B72034538 = _003CModule_003E._390073C602714496<int>(818201983);
						A67CB9F0984B47EB.SetException(exception);
						num8 = -1339470325;
					}
				}
			}
			_9F89815B72034538 = _003CModule_003E._8B9C7B12B1AE4949<int>(-685038223);
			while (true)
			{
				int num9 = -1708183267;
				while (true)
				{
					int num3 = num9;
					uint num4;
					switch ((num4 = (uint)(-(~num3 - (~unchecked(unchecked((-1218390675 + 266952489) * -344616061) * 893627495) + (unchecked(~unchecked(-1660367662 - 1467838123) * 1691599733) + (unchecked(154225681 * (0xA9238C9 ^ -1117634328)) + -(-1796101745 - -1307363044))) + (unchecked(-1649046351 * 1056279113) + (-1026757342 - ~(994279311 - 245675059)) + (0x3BC8B2C5 ^ -unchecked(unchecked(831085424 - -1360625849) + unchecked(835569899 * -874396157)))))))) % 3)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_05d5;
					case 0u:
						return;
					}
					break;
					IL_05d5:
					A67CB9F0984B47EB.SetResult();
					num9 = ((int)num4 * -1024237421) ^ -1745158668;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			A67CB9F0984B47EB.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object E21BC98736824BA7(object P_0, string P_1)
		{
			return ((IStringLocalizer)P_0)[P_1];
		}

		static string _5A2E3B108D3B4EB2(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}

		static ulong _246F02B0A1E448AD(object P_0)
		{
			return ((FF4343C122D84FC9)P_0).EBCB0E4ED7C143A7;
		}

		static string BAA2097DC4564078(string P_0, object P_1, object P_2, object P_3)
		{
			return string.Format(P_0, P_1, P_2, P_3);
		}

		static string _07083B92003B4697(object P_0)
		{
			return ((FF4343C122D84FC9)P_0).C1C927EE13F54315;
		}

		static string _1BCBF7A213414757(object P_0)
		{
			return ((FF4343C122D84FC9)P_0)._425676B4EB21455F;
		}

		static string _826A9BB172A2404B(object P_0)
		{
			return ((FF4343C122D84FC9)P_0).E8D18C353ED7435B;
		}

		static string CBF5701BDD9A47A9(object P_0)
		{
			return ((FF4343C122D84FC9)P_0)._80CFE22600264A18;
		}

		static string _278EFFB6B54B4A71(object P_0)
		{
			return ((FF4343C122D84FC9)P_0).C1E7B76915A44A84;
		}

		static string _2F24AA677F784EAC(string P_0, string P_1, string P_2, string P_3)
		{
			return P_0 + P_1 + P_2 + P_3;
		}

		static TaskAwaiter A87F2F6A74134685(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct D1998CCA49A44310 : IAsyncStateMachine
	{
		public int _2A46C54F18884C0A;

		public AsyncTaskMethodBuilder BD060DCC975148A4;

		public string EF497DEB7DBB4109;

		public int C80A32C95FCC4740;

		public string _77027E3ABDA24300;

		public B57BCC7426FB478D[] _2CA920B74DA14509;

		private _7A95916E9B314B73 _8928ECDDA03546F8;

		public (byte[] Data, string Name)? _0F26E78618BF46F2;

		public B7097FC49A384CFA _74B177A4C93D4EF1;

		private IEnumerator<(string ChatId, string? ThreadId, string BotToken)> B6F8DE6C5A96449E;

		private TaskAwaiter A3A7E34A660646FC;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
			int num = _2A46C54F18884C0A;
			B7097FC49A384CFA b7097FC49A384CFA = _74B177A4C93D4EF1;
			try
			{
				if (num == 0)
				{
					goto IL_01d7;
				}
				string text = default;
				while (true)
				{
					int num2 = -1807390819;
					while (true)
					{
						int num3 = num2;
						uint num4;
						switch ((num4 = (uint)(-((0x46AEB329 ^ -227280119) - ((num3 ^ ~(~(-692896871))) - (-777619975 ^ (2502551 * (~(--1216847585) + (-1419888489 ^ 0x61FAED29) - ~27463694))) + (~(~751407078) + (~(-unchecked(-1519027973 * 132824427)) - -(-86694451 - (-1870500305 + 530532056)))) - ~805894259) * -1771769365 - unchecked(763466447 * -816559263)))) % 8)
						{
						case 0u:
							break;
						case 7u:
							goto IL_00df;
						case 1u:
							goto end_IL_0014;
						case 6u:
							B6F8DE6C5A96449E = F91F85B4382B4C24(text).GetEnumerator();
							num2 = ((int)num4 * -1070891570) ^ -1666450245;
							continue;
						case 4u:
						{
							_8928ECDDA03546F8 = (_7A95916E9B314B73)_050EC09E975943B3();
							_8928ECDDA03546F8.CFD62621B2B74176 = EF497DEB7DBB4109;
							_8928ECDDA03546F8._744EDDD28BFF4514 = C80A32C95FCC4740;
							int num5;
							int num6;
							if (!_11B829F8399B4C79(_77027E3ABDA24300))
							{
								num5 = 1130313888;
								num6 = num5;
							}
							else
							{
								num5 = -1958274377;
								num6 = num5;
							}
							num2 = num5 ^ (int)(num4 * 969263691);
							continue;
						}
						case 3u:
							goto IL_018e;
						case 2u:
							text = _77027E3ABDA24300;
							_8928ECDDA03546F8.B1AA072141C94441 = _7747FDF87DBB4AA1(_2CA920B74DA14509);
							num2 = -1911475055;
							continue;
						default:
							goto IL_01d7;
						}
						break;
						IL_018e:
						if (_155529BE6FB64E5E((object)text, _003CModule_003E._8B9C7B12B1AE4949<string>(-2135149661)))
						{
							num2 = 1062551464;
							continue;
						}
						goto IL_0c55;
						IL_00df:
						if (num != _003CModule_003E._58ECCB512F2A43AC<int>(1006217019))
						{
							num2 = -184375718;
							continue;
						}
						goto IL_0c23;
					}
					continue;
					end_IL_0014:
					break;
				}
				goto end_IL_000e;
				IL_0c55:
				EACC013FD78547C0 eACC013FD78547C = (EACC013FD78547C0)CE026A305F2A4BA4(FBF29469AC404359(_00B07115ED1049D0(_9993BF1C33F04E42(), _003CModule_003E.F84FA79ABE6944BB<string>(1584350130)), _9AB67761792440A7._6142757B48FF46AD), (Action<FD59A46B5C464B4B>)([MethodImpl(MethodImplOptions.NoInlining)] (FD59A46B5C464B4B P_0) =>
				{
					//IL_019b: Unknown result type (might be due to invalid IL or missing references)
					_7A95916E9B314B73._94A19C8837AA4795((object)P_0, _7A95916E9B314B73._4D0B046329D6442A(_003CModule_003E._3F57E81A62734AC2<string>(-808333392), _80CA2CB46C5A4E72(_8928ECDDA03546F8.CFD62621B2B74176, _003CModule_003E._3F57E81A62734AC2<int>(1258659850)), _003CModule_003E.F84FA79ABE6944BB<string>(-837808073)));
					using (List<B57BCC7426FB478D>.Enumerator enumerator2 = _8928ECDDA03546F8.B1AA072141C94441.GetEnumerator())
					{
						B57BCC7426FB478D current3 = default;
						while (true)
						{
							IL_0129:
							int num23;
							int num24;
							if (enumerator2.MoveNext())
							{
								num23 = -297774893;
								num24 = num23;
							}
							else
							{
								num23 = 1326674633;
								num24 = num23;
							}
							while (true)
							{
								int num25 = num23;
								uint num26;
								switch ((num26 = (uint)(~(~(~(-unchecked(~unchecked(1004048335 * -753217020) * -2025856447) - (-num25 - ~(983094079 * (0x7EE6EC1E ^ (-944898733 * -446513282)) * 1955956079)) * 1898753499)) * 897853743))) % 5)
								{
								case 2u:
									num23 = -297774893;
									continue;
								default:
									goto end_IL_0051;
								case 1u:
								{
									current3 = enumerator2.Current;
									int num27;
									if (current3._5EE35423D9AC40C2)
									{
										num23 = 1512362361;
										num27 = num23;
									}
									else
									{
										num23 = 752629747;
										num27 = num23;
									}
									continue;
								}
								case 0u:
									_7A95916E9B314B73.CB5B3891AC724BBA((object)P_0, _7A95916E9B314B73._4D0B046329D6442A(_003CModule_003E.F84FA79ABE6944BB<string>(-837808073), current3._6B075EEB395C46E9, _003CModule_003E.F84FA79ABE6944BB<string>(1742194028)), _2B07CBD6A2064FB3(current3._1AE5749185184BD6), (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0);
									num23 = 1512362361;
									continue;
								case 4u:
									break;
								case 3u:
									goto end_IL_0051;
								}
								goto IL_0129;
								continue;
								end_IL_0051:
								break;
							}
							break;
						}
					}
					_7A95916E9B314B73._7A34B9DEF63D4BC8(_7A95916E9B314B73._1D74583750E64827(_7A95916E9B314B73.A33768E5CD554B74(_7A95916E9B314B73.CB5B3891AC724BBA(_7A95916E9B314B73.CB5B3891AC724BBA((object)P_0, _7A95916E9B314B73._425613A9941842CB(_003CModule_003E._3F57E81A62734AC2<string>(-488096631), _7A95916E9B314B73.C07F8033DB844DE4((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._3F57E81A62734AC2<string>(986372360))), _2B07CBD6A2064FB3(_7A95916E9B314B73._3D6B2EC01E78414E(_003CModule_003E._8B9C7B12B1AE4949<string>(601876534), (object)_7A95916E9B314B73._437728E4F39246EA(), (object)_003CModule_003E._390073C602714496<string>(416397071), (object)_7A95916E9B314B73._476810E891B84466())), (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0), _7A95916E9B314B73._425613A9941842CB(_003CModule_003E._390073C602714496<string>(-1081734094), _7A95916E9B314B73.C07F8033DB844DE4((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._8B9C7B12B1AE4949<string>(-1017049256))), _7A95916E9B314B73.E725852CB7F44B84(_003CModule_003E._3F57E81A62734AC2<string>(1860039678), (object)_7A95916E9B314B73._19525C751A734360().Count, (object)_7A95916E9B314B73._968C1E31AD5D41F7()), (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0), _8928ECDDA03546F8._744EDDD28BFF4514), DateTimeOffset.UtcNow), _003CModule_003E._8B9C7B12B1AE4949<string>(-312800654), _9AB67761792440A7._6142757B48FF46AD);
				}));
				int num7;
				int num8;
				if (_0F26E78618BF46F2.HasValue)
				{
					num7 = 2098506733;
					num8 = num7;
				}
				else
				{
					num7 = -234330599;
					num8 = num7;
				}
				goto IL_0ae9;
				IL_0ae4:
				num7 = 2042239381;
				goto IL_0ae9;
				IL_0ae9:
				TaskAwaiter awaiter = default;
				while (true)
				{
					int num3 = num7;
					uint num4;
					switch ((num4 = (uint)(-((0x46AEB329 ^ -227280119) - ((num3 ^ ~(~(-692896871))) - (-777619975 ^ (2502551 * (~(--1216847585) + (-1419888489 ^ 0x61FAED29) - ~27463694))) + (~(~751407078) + (~(-unchecked(-1519027973 * 132824427)) - -(-86694451 - (-1870500305 + 530532056)))) - ~805894259) * -1771769365 - unchecked(763466447 * -816559263)))) % 13)
					{
					case 4u:
						break;
					default:
						goto end_IL_000e;
					case 5u:
						return;
					case 12u:
					{
						int num9;
						int num10;
						if (!awaiter.IsCompleted)
						{
							num9 = -1661022673;
							num10 = num9;
						}
						else
						{
							num9 = 219932077;
							num10 = num9;
						}
						num7 = num9 ^ (int)(num4 * 1193832142);
						continue;
					}
					case 3u:
						BD060DCC975148A4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num7 = ((int)num4 * -350524624) ^ -1608139622;
						continue;
					case 7u:
						goto IL_0c23;
					case 10u:
						goto IL_0c55;
					case 9u:
						goto end_IL_000e;
					case 1u:
						num = (_2A46C54F18884C0A = _003CModule_003E._58ECCB512F2A43AC<int>(1006217019));
						num7 = -1432047295;
						continue;
					case 11u:
						E5DC9C3D44D140ED((object)eACC013FD78547C, _0F26E78618BF46F2.Value.Data, _0F26E78618BF46F2.Value.Name);
						num7 = ((int)num4 * -498886830) ^ -1155742009;
						continue;
					case 0u:
						awaiter = _66FF5CD6FA284877(_3620332A2BFA4A68((object)b7097FC49A384CFA, text, (object)eACC013FD78547C));
						num7 = 1198386707;
						continue;
					case 2u:
						awaiter.GetResult();
						num7 = -1032664244;
						continue;
					case 6u:
						A3A7E34A660646FC = awaiter;
						num7 = ((int)num4 * -100296586) ^ -1135100254;
						continue;
					case 8u:
						goto end_IL_000e;
					}
					break;
				}
				goto IL_0ae4;
				IL_0c23:
				awaiter = A3A7E34A660646FC;
				A3A7E34A660646FC = default;
				num = (_2A46C54F18884C0A = _003CModule_003E._390073C602714496<int>(-736908096));
				num7 = -1334115437;
				goto IL_0ae9;
				IL_01d7:
				try
				{
					if (num != 0)
					{
						goto IL_01dd;
					}
					goto IL_07d7;
					IL_01dd:
					int num11 = 1023717703;
					goto IL_01e2;
					IL_01e2:
					int num3 = num11;
					uint num4;
					switch ((num4 = (uint)(-((0x46AEB329 ^ -227280119) - ((num3 ^ ~(~(-692896871))) - (-777619975 ^ (2502551 * (~(--1216847585) + (-1419888489 ^ 0x61FAED29) - ~27463694))) + (~(~751407078) + (~(-unchecked(-1519027973 * 132824427)) - -(-86694451 - (-1870500305 + 530532056)))) - ~805894259) * -1771769365 - unchecked(763466447 * -816559263)))) % 4)
					{
					case 0u:
						break;
					case 3u:
						goto IL_02ad;
					default:
						goto IL_02d9;
					case 1u:
						goto IL_079e;
					}
					goto IL_01dd;
					IL_02d9:
					string item = default;
					_76F96581AED844F6 obj = (_76F96581AED844F6)_88D6CC6D713C433C(_88D6CC6D713C433C(E0456611DF844D99(FDE4682931884391(), item), AB3EDD48384C4A83(_003CModule_003E._390073C602714496<string>(-378061495), F609E619EE744883(_8928ECDDA03546F8.CFD62621B2B74176), _003CModule_003E._8B9C7B12B1AE4949<string>(-422760828))), _003CModule_003E._390073C602714496<string>(178294474));
					List<B57BCC7426FB478D>.Enumerator enumerator = _8928ECDDA03546F8.B1AA072141C94441.GetEnumerator();
					try
					{
						B57BCC7426FB478D current = default;
						while (true)
						{
							IL_04e4:
							int num12;
							int num13;
							if (enumerator.MoveNext())
							{
								num12 = 1507657607;
								num13 = num12;
							}
							else
							{
								num12 = -1316592195;
								num13 = num12;
							}
							while (true)
							{
								num3 = num12;
								switch ((num4 = (uint)(-((0x46AEB329 ^ -227280119) - ((num3 ^ ~(~(-692896871))) - (-777619975 ^ (2502551 * (~(--1216847585) + (-1419888489 ^ 0x61FAED29) - ~27463694))) + (~(~751407078) + (~(-unchecked(-1519027973 * 132824427)) - -(-86694451 - (-1870500305 + 530532056)))) - ~805894259) * -1771769365 - unchecked(763466447 * -816559263)))) % 5)
								{
								case 0u:
									num12 = 1507657607;
									continue;
								default:
									goto end_IL_0346;
								case 1u:
									current = enumerator.Current;
									num12 = -621134508;
									continue;
								case 4u:
								{
									_76F96581AED844F6 obj2 = obj;
									string text2;
									if (!current._5EE35423D9AC40C2)
									{
										string[] array = new string[_003CModule_003E.F84FA79ABE6944BB<int>(1650979182)];
										array[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)] = current._3E20AB0715344CAE;
										array[_003CModule_003E.F84FA79ABE6944BB<int>(1741630884)] = _003CModule_003E._58ECCB512F2A43AC<string>(-2070607697);
										array[_003CModule_003E._3F57E81A62734AC2<int>(-845933485)] = F609E619EE744883(current._6B075EEB395C46E9);
										array[_003CModule_003E._8B9C7B12B1AE4949<int>(944380096)] = _003CModule_003E._3F57E81A62734AC2<string>(5426245);
										array[_003CModule_003E._8B9C7B12B1AE4949<int>(1358231899)] = (current._789A8474C61C4EDE ? current._1AE5749185184BD6 : F609E619EE744883(current._1AE5749185184BD6));
										text2 = _731515CC86AC4BB5(array);
									}
									else
									{
										text2 = _003CModule_003E._8B9C7B12B1AE4949<string>(1855926006);
									}
									_88D6CC6D713C433C((object)obj2, text2);
									num12 = -139659753;
									continue;
								}
								case 2u:
									break;
								case 3u:
									goto end_IL_0346;
								}
								goto IL_04e4;
								continue;
								end_IL_0346:
								break;
							}
							break;
						}
					}
					finally
					{
						if (num < _003CModule_003E._390073C602714496<int>(2131963235))
						{
							while (true)
							{
								IL_0518:
								int num14 = -1156025795;
								while (true)
								{
									num3 = num14;
									switch ((num4 = (uint)(-((0x46AEB329 ^ -227280119) - ((num3 ^ ~(~(-692896871))) - (-777619975 ^ (2502551 * (~(--1216847585) + (-1419888489 ^ 0x61FAED29) - ~27463694))) + (~(~751407078) + (~(-unchecked(-1519027973 * 132824427)) - -(-86694451 - (-1870500305 + 530532056)))) - ~805894259) * -1771769365 - unchecked(763466447 * -816559263)))) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_051d;
									case 2u:
										goto IL_05cc;
									case 1u:
										goto end_IL_051d;
									}
									goto IL_0518;
									IL_05cc:
									((IDisposable)enumerator/*cast due to constrained. prefix*/).Dispose();
									num14 = (int)(num4 * 1424016889) ^ -605237841;
									continue;
									end_IL_051d:
									break;
								}
								break;
							}
						}
					}
					if (_8928ECDDA03546F8.B1AA072141C94441.Count > _003CModule_003E._3F57E81A62734AC2<int>(-1803194042))
					{
						goto IL_060e;
					}
					goto IL_0864;
					IL_079e:
					if (B79736E28B804FDF((object)B6F8DE6C5A96449E))
					{
						goto IL_02ad;
					}
					int num15 = -1818346222;
					goto IL_0613;
					IL_060e:
					num15 = -898404233;
					goto IL_0613;
					IL_0613:
					string item2 = default;
					string item3 = default;
					while (true)
					{
						num3 = num15;
						switch ((num4 = (uint)(-((0x46AEB329 ^ -227280119) - ((num3 ^ ~(~(-692896871))) - (-777619975 ^ (2502551 * (~(--1216847585) + (-1419888489 ^ 0x61FAED29) - ~27463694))) + (~(~751407078) + (~(-unchecked(-1519027973 * 132824427)) - -(-86694451 - (-1870500305 + 530532056)))) - ~805894259) * -1771769365 - unchecked(763466447 * -816559263)))) % 16)
						{
						case 0u:
							break;
						default:
							goto end_IL_01d7;
						case 1u:
							num = (_2A46C54F18884C0A = _003CModule_003E._390073C602714496<int>(2131963235));
							num15 = -88489521;
							continue;
						case 8u:
							goto IL_0718;
						case 3u:
							num = (_2A46C54F18884C0A = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
							num15 = -1167385431;
							continue;
						case 11u:
							awaiter.GetResult();
							num15 = 1293045722;
							continue;
						case 5u:
							_88D6CC6D713C433C((object)obj, _003CModule_003E._58ECCB512F2A43AC<string>(-763533267));
							num15 = 74059300;
							continue;
						case 14u:
							return;
						case 12u:
							goto IL_079e;
						case 6u:
							A3A7E34A660646FC = default;
							num15 = (int)(num4 * 1713947347) ^ -755059805;
							continue;
						case 15u:
							goto IL_07d7;
						case 13u:
							A3A7E34A660646FC = awaiter;
							BD060DCC975148A4.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							num15 = (int)(num4 * 255419100) ^ -2063420644;
							continue;
						case 9u:
							E9F191EC0A8E47E0((object)obj, item2);
							num15 = ((int)num4 * -454805159) ^ 0x491D930F;
							continue;
						case 2u:
							goto IL_082f;
						case 10u:
							goto IL_0864;
						case 7u:
							FEE23185FE8846BB((object)obj, _0F26E78618BF46F2.Value.Data, _0F26E78618BF46F2.Value.Name);
							num15 = (int)((num4 * 1887518016) ^ 0x2C0A584C);
							continue;
						case 4u:
							goto end_IL_01d7;
						}
						break;
						IL_082f:
						awaiter = _66FF5CD6FA284877(_3620332A2BFA4A68((object)b7097FC49A384CFA, _4BB6208CC3E440BF((object)obj, item3), (object)obj));
						int num16;
						if (!awaiter.IsCompleted)
						{
							num15 = -544173285;
							num16 = num15;
						}
						else
						{
							num15 = -1167385431;
							num16 = num15;
						}
						continue;
						IL_0718:
						int num17;
						if (!_0F26E78618BF46F2.HasValue)
						{
							num15 = -101889908;
							num17 = num15;
						}
						else
						{
							num15 = 83052269;
							num17 = num15;
						}
					}
					goto IL_060e;
					IL_02ad:
					(string ChatId, string? ThreadId, string BotToken) current2 = B6F8DE6C5A96449E.Current;
					item = current2.ChatId;
					item2 = current2.ThreadId;
					item3 = current2.BotToken;
					num11 = -1519454896;
					goto IL_01e2;
					IL_0864:
					_76F96581AED844F6 obj3 = obj;
					string text3 = _003CModule_003E._8B9C7B12B1AE4949<string>(102051916);
					object[] array2 = new object[_003CModule_003E._3F57E81A62734AC2<int>(-1354517604)];
					array2[_003CModule_003E.F84FA79ABE6944BB<int>(1398637845)] = F609E619EE744883(AD1A1EA38B454FB2((LocalizedString)F1F3B7B47BBF48D9((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._3F57E81A62734AC2<string>(986372360))));
					array2[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)] = F609E619EE744883(_93AB27B25C3646DE());
					array2[_003CModule_003E._58ECCB512F2A43AC<int>(1208532887)] = _003CModule_003E._3F57E81A62734AC2<string>(-1257009830);
					array2[_003CModule_003E._58ECCB512F2A43AC<int>(1571980983)] = _5A0D809FA2F242D2();
					_88D6CC6D713C433C(_88D6CC6D713C433C(_88D6CC6D713C433C(_88D6CC6D713C433C((object)obj3, _01E5227265964A11(text3, array2)), _1A2F764A6EF84642(_003CModule_003E._3F57E81A62734AC2<string>(-1532400153), (object)F609E619EE744883(AD1A1EA38B454FB2((LocalizedString)F1F3B7B47BBF48D9((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._390073C602714496<string>(-862382264)))), (object)F571082773DC4517().Count, (object)_768F9781619F4546())), _003CModule_003E._8B9C7B12B1AE4949<string>(1855926006)), _003CModule_003E._58ECCB512F2A43AC<string>(-767651631));
					int num18;
					if (item2 == null)
					{
						num15 = 783828734;
						num18 = num15;
					}
					else
					{
						num15 = 1395092067;
						num18 = num15;
					}
					goto IL_0613;
					IL_07d7:
					awaiter = A3A7E34A660646FC;
					num15 = 667112936;
					goto IL_0613;
					end_IL_01d7:;
				}
				finally
				{
					if (num < _003CModule_003E.F84FA79ABE6944BB<int>(1398637845))
					{
						while (true)
						{
							IL_09e1:
							int num19 = -1394731948;
							while (true)
							{
								int num3 = num19;
								uint num4;
								switch ((num4 = (uint)(-((0x46AEB329 ^ -227280119) - ((num3 ^ ~(~(-692896871))) - (-777619975 ^ (2502551 * (~(--1216847585) + (-1419888489 ^ 0x61FAED29) - ~27463694))) + (~(~751407078) + (~(-unchecked(-1519027973 * 132824427)) - -(-86694451 - (-1870500305 + 530532056)))) - ~805894259) * -1771769365 - unchecked(763466447 * -816559263)))) % 4)
								{
								case 0u:
									break;
								default:
									goto end_IL_09e6;
								case 2u:
								{
									int num20;
									int num21;
									if (B6F8DE6C5A96449E != null)
									{
										num20 = -773154789;
										num21 = num20;
									}
									else
									{
										num20 = 1763369853;
										num21 = num20;
									}
									num19 = num20 ^ (int)(num4 * 1855376673);
									continue;
								}
								case 3u:
									AFC0CAD5260E406F((object)B6F8DE6C5A96449E);
									num19 = (int)(num4 * 1410694166) ^ -1259645483;
									continue;
								case 1u:
									goto end_IL_09e6;
								}
								goto IL_09e1;
								continue;
								end_IL_09e6:
								break;
							}
							break;
						}
					}
				}
				B6F8DE6C5A96449E = null;
				goto IL_0ae4;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				while (true)
				{
					int num22 = 1855431307;
					while (true)
					{
						int num3 = num22;
						uint num4;
						switch ((num4 = (uint)(-((0x46AEB329 ^ -227280119) - ((num3 ^ ~(~(-692896871))) - (-777619975 ^ (2502551 * (~(--1216847585) + (-1419888489 ^ 0x61FAED29) - ~27463694))) + (~(~751407078) + (~(-unchecked(-1519027973 * 132824427)) - -(-86694451 - (-1870500305 + 530532056)))) - ~805894259) * -1771769365 - unchecked(763466447 * -816559263)))) % 5)
						{
						case 0u:
							break;
						default:
							return;
						case 3u:
							BD060DCC975148A4.SetException(exception);
							num22 = (int)(num4 * 60577871) ^ -80723370;
							continue;
						case 2u:
							_8928ECDDA03546F8 = null;
							num22 = (int)(num4 * 59530843) ^ -722602182;
							continue;
						case 1u:
							_2A46C54F18884C0A = _003CModule_003E.F84FA79ABE6944BB<int>(1456819737);
							num22 = 378686641;
							continue;
						case 4u:
							return;
						}
						break;
					}
				}
			}
			_2A46C54F18884C0A = _003CModule_003E._390073C602714496<int>(818201983);
			_8928ECDDA03546F8 = null;
			BD060DCC975148A4.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			BD060DCC975148A4.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _050EC09E975943B3()
		{
			return new _7A95916E9B314B73();
		}

		static bool _11B829F8399B4C79(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}

		static bool _155529BE6FB64E5E(object P_0, string P_1)
		{
			return ((string)P_0).StartsWith(P_1);
		}

		static object FDE4682931884391()
		{
			return new _76F96581AED844F6();
		}

		static object E0456611DF844D99(object P_0, string P_1)
		{
			return ((_76F96581AED844F6)P_0)._4C01C045B9BD43F3(P_1);
		}

		static string AB3EDD48384C4A83(string P_0, string P_1, string P_2)
		{
			return P_0 + P_1 + P_2;
		}

		static object _88D6CC6D713C433C(object P_0, string P_1)
		{
			return ((_76F96581AED844F6)P_0).B9E51F6DBE174F90(P_1);
		}

		static string _731515CC86AC4BB5(string[] P_0)
		{
			return string.Concat(P_0);
		}

		static object F1F3B7B47BBF48D9(object P_0, string P_1)
		{
			return ((IStringLocalizer)P_0)[P_1];
		}

		static string AD1A1EA38B454FB2(LocalizedString P_0)
		{
			return LocalizedString.op_Implicit(P_0);
		}

		static string _93AB27B25C3646DE()
		{
			return Provider.serverName;
		}

		static CSteamID _5A0D809FA2F242D2()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return Provider.server;
		}

		static string _01E5227265964A11(string P_0, object[] P_1)
		{
			return string.Format(P_0, P_1);
		}

		static List<SteamPlayer> F571082773DC4517()
		{
			return Provider.clients;
		}

		static byte _768F9781619F4546()
		{
			return Provider.maxPlayers;
		}

		static string _1A2F764A6EF84642(string P_0, object P_1, object P_2, object P_3)
		{
			return string.Format(P_0, P_1, P_2, P_3);
		}

		static object E9F191EC0A8E47E0(object P_0, string P_1)
		{
			return ((_76F96581AED844F6)P_0)._6CB6201A57E44577(P_1);
		}

		static object FEE23185FE8846BB(object P_0, byte[] P_1, string P_2)
		{
			return ((_76F96581AED844F6)P_0)._50B66EEE91694F22(P_1, P_2);
		}

		static string _4BB6208CC3E440BF(object P_0, string P_1)
		{
			return ((_76F96581AED844F6)P_0)._193D68AD3E9E4DAD(P_1);
		}

		static object _3620332A2BFA4A68(object P_0, string P_1, object P_2)
		{
			return ((B7097FC49A384CFA)P_0).C36BF5A01F6A4A5B(P_1, (AECA8283EE0E4BAC)P_2);
		}

		static TaskAwaiter _66FF5CD6FA284877(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}

		static bool B79736E28B804FDF(object P_0)
		{
			return ((IEnumerator)P_0).MoveNext();
		}

		static void AFC0CAD5260E406F(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		static object _9993BF1C33F04E42()
		{
			return new EACC013FD78547C0();
		}

		static object _00B07115ED1049D0(object P_0, string P_1)
		{
			return ((EACC013FD78547C0)P_0).A45A013EEA564A4F(P_1);
		}

		static object FBF29469AC404359(object P_0, string P_1)
		{
			return ((EACC013FD78547C0)P_0)._10254EE96C0B44D7(P_1);
		}

		static object CE026A305F2A4BA4(object P_0, Action<FD59A46B5C464B4B> P_1)
		{
			return ((EACC013FD78547C0)P_0)._6E7F1E94B801439F(P_1);
		}

		static object E5DC9C3D44D140ED(object P_0, byte[] P_1, string P_2)
		{
			return ((EACC013FD78547C0)P_0)._4738138DFEF34E61(P_1, P_2);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct E489D9C92A3A4254 : IAsyncStateMachine
	{
		public int _5AF9B97631374BF5;

		public AsyncTaskMethodBuilder BEA27C44E8F741E3;

		public AECA8283EE0E4BAC A0A4868718F1474C;

		public B7097FC49A384CFA _235587FFA21B4BC6;

		public string _80021D12B6064E4B;

		private int _89FD20B8C77A465F;

		private MultipartFormDataContent A344452FC1814D78;

		private HttpResponseMessage FDCE641B91BE45A6;

		private TaskAwaiter<HttpResponseMessage> _0F8B53367F7D4F43;

		private TaskAwaiter<string> F3572BDA6AF24177;

		private TaskAwaiter _50F8704AAE5D4867;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private unsafe void MoveNext()
		{
			int num = _5AF9B97631374BF5;
			B7097FC49A384CFA b7097FC49A384CFA = _235587FFA21B4BC6;
			try
			{
				if ((uint)num > (uint)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019))
				{
					goto IL_0020;
				}
				goto IL_00fa;
				IL_0020:
				int num2 = -1582304829;
				goto IL_0025;
				IL_0025:
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(1171320491 - ((~(-(-num3 - (~(-(-945123908 - -1362746839)) + (~(~((0x9E0BA3E ^ 0x3B782C85) + (0x33490AA5 ^ -2107155035))) - -420828760))) ^ -1870924505) - (1913934990 - (0x5E2F5307 ^ 0x7A20CDDC))) ^ -1261229268))) % 5)
					{
					case 0u:
						break;
					case 3u:
						goto IL_00a6;
					case 2u:
						goto IL_00c2;
					case 1u:
						_89FD20B8C77A465F = _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
						num2 = -1339828562;
						continue;
					default:
						goto IL_00fa;
					}
					break;
					IL_00a6:
					if (num != _003CModule_003E._390073C602714496<int>(1302522752))
					{
						num2 = -1396424768;
						continue;
					}
					goto IL_0b3a;
				}
				goto IL_0020;
				IL_00c2:
				A344452FC1814D78 = (MultipartFormDataContent)_407D18DEE3D443D5((object)A0A4868718F1474C);
				num2 = -421129950;
				goto IL_0025;
				IL_09cd:
				int num5;
				TaskAwaiter awaiter = default;
				TimeSpan timeSpan = default;
				while (true)
				{
					int num3 = num5;
					uint num4;
					switch ((num4 = (uint)(1171320491 - ((~(-(-num3 - (~(-(-945123908 - -1362746839)) + (~(~((0x9E0BA3E ^ 0x3B782C85) + (0x33490AA5 ^ -2107155035))) - -420828760))) ^ -1870924505) - (1913934990 - (0x5E2F5307 ^ 0x7A20CDDC))) ^ -1261229268))) % 11)
					{
					case 5u:
						goto IL_09c8;
					case 1u:
						awaiter = CAF8E318710140D8(F3630CF59A9D4FA9(timeSpan));
						num5 = (int)((num4 * 442424261) ^ 0x1546CF0F);
						continue;
					case 9u:
						_50F8704AAE5D4867 = default;
						num = (_5AF9B97631374BF5 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224));
						num5 = -2006324016;
						continue;
					case 3u:
					{
						int num8 = _89FD20B8C77A465F;
						_89FD20B8C77A465F = num8 + _003CModule_003E._390073C602714496<int>(-250964212);
						num5 = -2033319086;
						continue;
					}
					case 4u:
						return;
					case 0u:
						BEA27C44E8F741E3.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num5 = ((int)num4 * -75554423) ^ 0x5EB1744B;
						continue;
					case 7u:
						num = (_5AF9B97631374BF5 = _003CModule_003E._3F57E81A62734AC2<int>(-845933485));
						_50F8704AAE5D4867 = awaiter;
						num5 = -1731049088;
						continue;
					case 8u:
						goto IL_0b3a;
					case 10u:
						awaiter.GetResult();
						num5 = -1627105342;
						continue;
					case 2u:
					{
						int num6;
						int num7;
						if (!awaiter.IsCompleted)
						{
							num6 = -547390625;
							num7 = num6;
						}
						else
						{
							num6 = 32418204;
							num7 = num6;
						}
						num5 = num6 ^ ((int)num4 * -1816240820);
						continue;
					}
					}
					break;
				}
				goto IL_00c2;
				IL_0b3a:
				awaiter = _50F8704AAE5D4867;
				num5 = 982083724;
				goto IL_09cd;
				IL_00fa:
				try
				{
					if ((uint)num > (uint)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668))
					{
						while (true)
						{
							int num9 = -1193618086;
							while (true)
							{
								int num3 = num9;
								uint num4;
								switch ((num4 = (uint)(1171320491 - ((~(-(-num3 - (~(-(-945123908 - -1362746839)) + (~(~((0x9E0BA3E ^ 0x3B782C85) + (0x33490AA5 ^ -2107155035))) - -420828760))) ^ -1870924505) - (1913934990 - (0x5E2F5307 ^ 0x7A20CDDC))) ^ -1261229268))) % 3)
								{
								case 0u:
									break;
								case 2u:
									FDCE641B91BE45A6 = null;
									num9 = ((int)num4 * -1429461099) ^ 0x5DBC3538;
									continue;
								default:
									goto end_IL_010c;
								}
								break;
							}
							continue;
							end_IL_010c:
							break;
						}
					}
					Exception ex = default;
					try
					{
						if (num != 0)
						{
							goto IL_01ab;
						}
						goto IL_03c9;
						IL_01ab:
						int num10 = -1077937927;
						goto IL_01b0;
						IL_01b0:
						TaskAwaiter<string> awaiter3 = default;
						TaskAwaiter<HttpResponseMessage> awaiter2 = default;
						string result = default;
						while (true)
						{
							int num3 = num10;
							uint num4;
							switch ((num4 = (uint)(1171320491 - ((~(-(-num3 - (~(-(-945123908 - -1362746839)) + (~(~((0x9E0BA3E ^ 0x3B782C85) + (0x33490AA5 ^ -2107155035))) - -420828760))) ^ -1870924505) - (1913934990 - (0x5E2F5307 ^ 0x7A20CDDC))) ^ -1261229268))) % 21)
							{
							case 14u:
								break;
							case 10u:
							{
								int num13;
								int num14;
								if (awaiter3.IsCompleted)
								{
									num13 = -124062838;
									num14 = num13;
								}
								else
								{
									num13 = 403805897;
									num14 = num13;
								}
								num10 = num13 ^ ((int)num4 * -1636109495);
								continue;
							}
							case 17u:
								_0F8B53367F7D4F43 = default;
								num = (_5AF9B97631374BF5 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817));
								num10 = -1398972795;
								continue;
							case 9u:
								goto IL_02c5;
							case 3u:
								awaiter3 = F3572BDA6AF24177;
								F3572BDA6AF24177 = default;
								num = (_5AF9B97631374BF5 = _003CModule_003E._3F57E81A62734AC2<int>(380280467));
								num10 = -1248031269;
								continue;
							case 13u:
								awaiter3 = _5D0EAFE7914C4908(_92372A1E7918429A((object)FDCE641B91BE45A6)).GetAwaiter();
								num10 = -1538628428;
								continue;
							case 2u:
							{
								awaiter2 = _3E1042293A9742EA((object)b7097FC49A384CFA._32016BA8CBB1490F, _80021D12B6064E4B, (object)A344452FC1814D78).GetAwaiter();
								int num11;
								int num12;
								if (awaiter2.IsCompleted)
								{
									num11 = 1043675325;
									num12 = num11;
								}
								else
								{
									num11 = 1223094073;
									num12 = num11;
								}
								num10 = num11 ^ (int)(num4 * 47362676);
								continue;
							}
							case 7u:
								BEA27C44E8F741E3.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
								num10 = ((int)num4 * -732175881) ^ -1959129331;
								continue;
							case 5u:
								num = (_5AF9B97631374BF5 = _003CModule_003E._58ECCB512F2A43AC<int>(1006217019));
								num10 = -1600222584;
								continue;
							case 0u:
								goto IL_03c9;
							case 4u:
								num = (_5AF9B97631374BF5 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
								num10 = 1440839933;
								continue;
							case 18u:
								goto IL_03f9;
							case 15u:
								goto IL_0421;
							case 19u:
								goto end_IL_01a5;
							case 11u:
								return;
							case 20u:
								F3572BDA6AF24177 = awaiter3;
								num10 = (int)(num4 * 1895191308) ^ -1562333279;
								continue;
							case 16u:
								timeSpan = F1C06CD3C7A04E0F(FDCE641B91BE45A6, result);
								num10 = 1830114409;
								continue;
							case 1u:
								_0F8B53367F7D4F43 = awaiter2;
								BEA27C44E8F741E3.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							case 6u:
								goto IL_04e3;
							case 12u:
								D81B9E9E62EA4E31(C179263454B44BF6._54DF173DA5E74DC3, _5C37A14C3AA74F6C(_003CModule_003E._3F57E81A62734AC2<string>(1544977506), (object)(int)_01E84E4ED06544E5((object)FDCE641B91BE45A6), (object)result), Array.Empty<object>());
								goto end_IL_01a5;
							default:
							{
								ILogger val = C179263454B44BF6._54DF173DA5E74DC3;
								string text = _003CModule_003E._3F57E81A62734AC2<string>(-955284038);
								object[] array = new object[_003CModule_003E.F84FA79ABE6944BB<int>(2084623923)];
								array[_003CModule_003E._390073C602714496<int>(2131963235)] = (int)_01E84E4ED06544E5((object)FDCE641B91BE45A6);
								array[_003CModule_003E._8B9C7B12B1AE4949<int>(350091668)] = timeSpan.TotalSeconds;
								array[_003CModule_003E._58ECCB512F2A43AC<int>(1208532887)] = _89FD20B8C77A465F + _003CModule_003E.F84FA79ABE6944BB<int>(1741630884);
								array[_003CModule_003E._58ECCB512F2A43AC<int>(1571980983)] = _003CModule_003E._58ECCB512F2A43AC<int>(-1977557483);
								_30E7633F8C7847E9(val, _227ECDAFCF144DF0(text, array), Array.Empty<object>());
								goto IL_08dd;
							}
							}
							break;
							IL_04e3:
							int num15;
							if (num != _003CModule_003E._58ECCB512F2A43AC<int>(1006217019))
							{
								num10 = -1378283233;
								num15 = num10;
							}
							else
							{
								num10 = 1875863807;
								num15 = num10;
							}
							continue;
							IL_03f9:
							int num16;
							if (_89FD20B8C77A465F >= _003CModule_003E._8B9C7B12B1AE4949<int>(861409582))
							{
								num10 = -1092722194;
								num16 = num10;
							}
							else
							{
								num10 = -1909847268;
								num16 = num10;
							}
							continue;
							IL_02c5:
							result = awaiter3.GetResult();
							int num17;
							if (!AD9461E067D24127(_01E84E4ED06544E5((object)FDCE641B91BE45A6)))
							{
								num10 = -1092722194;
								num17 = num10;
							}
							else
							{
								num10 = -1097952827;
								num17 = num10;
							}
							continue;
							IL_0421:
							HttpResponseMessage result2 = awaiter2.GetResult();
							FDCE641B91BE45A6 = result2;
							int num18;
							if (!_36C433B8ECA74EEB((object)FDCE641B91BE45A6))
							{
								num10 = 2126817466;
								num18 = num10;
							}
							else
							{
								num10 = 1418368829;
								num18 = num10;
							}
						}
						goto IL_01ab;
						IL_03c9:
						awaiter2 = _0F8B53367F7D4F43;
						num10 = -1590172858;
						goto IL_01b0;
						end_IL_01a5:;
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						Exception obj2 = obj as Exception;
						Unsafe.SkipInit(out int result3);
						if (obj2 == null)
						{
							result3 = _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563);
						}
						else
						{
							ex = obj2;
							result3 = (((uint)((!(ex is HttpRequestException) && !(ex is TaskCanceledException)) ? _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) : _003CModule_003E._3F57E81A62734AC2<int>(1017304263)) > (uint)_003CModule_003E._390073C602714496<int>(2131963235)) ? 1 : 0);
						}
						return (byte)result3 != 0;
					}).Invoke())
					{
						while (true)
						{
							IL_0655:
							int num19 = 1869646597;
							while (true)
							{
								int num3 = num19;
								uint num4;
								switch ((num4 = (uint)(1171320491 - ((~(-(-num3 - (~(-(-945123908 - -1362746839)) + (~(~((0x9E0BA3E ^ 0x3B782C85) + (0x33490AA5 ^ -2107155035))) - -420828760))) ^ -1870924505) - (1913934990 - (0x5E2F5307 ^ 0x7A20CDDC))) ^ -1261229268))) % 6)
								{
								case 0u:
									break;
								case 4u:
								{
									int num20;
									if (_89FD20B8C77A465F >= _003CModule_003E._8B9C7B12B1AE4949<int>(861409582))
									{
										num19 = -2006469248;
										num20 = num19;
									}
									else
									{
										num19 = 2109008135;
										num20 = num19;
									}
									continue;
								}
								case 1u:
									goto end_IL_065a;
								case 2u:
									timeSpan = TimeSpan.FromSeconds(_45D1DE59DE1A4B34(_626E8B3039EA4338.TotalSeconds, _58EF49B36A9C481A(_003CModule_003E.F84FA79ABE6944BB<double>(1702403346), (double)_89FD20B8C77A465F)));
									num19 = 1974012554;
									continue;
								case 3u:
									_51ECB22687AB403C(C179263454B44BF6._54DF173DA5E74DC3, ex, _003CModule_003E._58ECCB512F2A43AC<string>(447531184), Array.Empty<object>());
									num19 = -1688885774;
									continue;
								default:
								{
									ILogger val2 = C179263454B44BF6._54DF173DA5E74DC3;
									string text2 = _003CModule_003E._3F57E81A62734AC2<string>(584267223);
									object[] array2 = new object[_003CModule_003E.F84FA79ABE6944BB<int>(2084623923)];
									array2[_003CModule_003E._3F57E81A62734AC2<int>(-1803194042)] = FBA5DAD7DAAF44BF(_8F73D2708010455E((object)ex));
									array2[_003CModule_003E._58ECCB512F2A43AC<int>(1006217019)] = timeSpan.TotalSeconds;
									array2[_003CModule_003E._58ECCB512F2A43AC<int>(1208532887)] = _89FD20B8C77A465F + _003CModule_003E._58ECCB512F2A43AC<int>(1006217019);
									array2[_003CModule_003E._58ECCB512F2A43AC<int>(1571980983)] = _003CModule_003E._8B9C7B12B1AE4949<int>(861409582);
									_30E7633F8C7847E9(val2, _227ECDAFCF144DF0(text2, array2), Array.Empty<object>());
									goto IL_08dd;
								}
								}
								goto IL_0655;
								continue;
								end_IL_065a:
								break;
							}
							break;
						}
					}
					finally
					{
						if (num < _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
						{
							while (true)
							{
								IL_0843:
								int num21 = -1679193233;
								while (true)
								{
									int num3 = num21;
									uint num4;
									HttpResponseMessage httpResponseMessage;
									switch ((num4 = (uint)(1171320491 - ((~(-(-num3 - (~(-(-945123908 - -1362746839)) + (~(~((0x9E0BA3E ^ 0x3B782C85) + (0x33490AA5 ^ -2107155035))) - -420828760))) ^ -1870924505) - (1913934990 - (0x5E2F5307 ^ 0x7A20CDDC))) ^ -1261229268))) % 3)
									{
									case 0u:
										break;
									default:
										goto end_IL_0848;
									case 2u:
										httpResponseMessage = FDCE641B91BE45A6;
										if (httpResponseMessage != null)
										{
											goto IL_08cd;
										}
										goto end_IL_0848;
									case 1u:
										goto end_IL_0848;
									}
									goto IL_0843;
									IL_08cd:
									((E489D9C92A3A4254*)httpResponseMessage)->_42B9E81684C44734();
									num21 = 1977711464;
									continue;
									end_IL_0848:
									break;
								}
								break;
							}
						}
					}
					goto end_IL_00fa;
					IL_08dd:
					FDCE641B91BE45A6 = null;
					goto IL_09c1;
					end_IL_00fa:;
				}
				finally
				{
					if (num < _003CModule_003E._390073C602714496<int>(2131963235))
					{
						while (true)
						{
							IL_08fb:
							int num22 = 1379402647;
							while (true)
							{
								int num3 = num22;
								uint num4;
								switch ((num4 = (uint)(1171320491 - ((~(-(-num3 - (~(-(-945123908 - -1362746839)) + (~(~((0x9E0BA3E ^ 0x3B782C85) + (0x33490AA5 ^ -2107155035))) - -420828760))) ^ -1870924505) - (1913934990 - (0x5E2F5307 ^ 0x7A20CDDC))) ^ -1261229268))) % 4)
								{
								case 0u:
									break;
								default:
									goto end_IL_0900;
								case 2u:
								{
									int num23;
									int num24;
									if (A344452FC1814D78 != null)
									{
										num23 = 1133101124;
										num24 = num23;
									}
									else
									{
										num23 = -1457320922;
										num24 = num23;
									}
									num22 = num23 ^ ((int)num4 * -640611479);
									continue;
								}
								case 3u:
									A857AEC3DC6E42BA((object)A344452FC1814D78);
									num22 = ((int)num4 * -931301063) ^ 0x1A075483;
									continue;
								case 1u:
									goto end_IL_0900;
								}
								goto IL_08fb;
								continue;
								end_IL_0900:
								break;
							}
							break;
						}
					}
				}
				goto end_IL_000e;
				IL_09c1:
				A344452FC1814D78 = null;
				goto IL_09c8;
				IL_09c8:
				num5 = 2104602254;
				goto IL_09cd;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				_5AF9B97631374BF5 = _003CModule_003E._390073C602714496<int>(818201983);
				BEA27C44E8F741E3.SetException(exception);
				return;
			}
			_5AF9B97631374BF5 = _003CModule_003E._390073C602714496<int>(818201983);
			while (true)
			{
				int num25 = -1225260166;
				while (true)
				{
					int num3 = num25;
					uint num4;
					switch ((num4 = (uint)(1171320491 - ((~(-(-num3 - (~(-(-945123908 - -1362746839)) + (~(~((0x9E0BA3E ^ 0x3B782C85) + (0x33490AA5 ^ -2107155035))) - -420828760))) ^ -1870924505) - (1913934990 - (0x5E2F5307 ^ 0x7A20CDDC))) ^ -1261229268))) % 3)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
						goto IL_0c3e;
					case 2u:
						return;
					}
					break;
					IL_0c3e:
					BEA27C44E8F741E3.SetResult();
					num25 = ((int)num4 * -469243068) ^ -1172499131;
				}
			}
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			BEA27C44E8F741E3.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static object _407D18DEE3D443D5(object P_0)
		{
			return ((AECA8283EE0E4BAC)P_0).E22B0D6862404470();
		}

		static Task<HttpResponseMessage> _3E1042293A9742EA(object P_0, string P_1, object P_2)
		{
			return ((HttpClient)P_0).PostAsync(P_1, (HttpContent?)P_2);
		}

		static bool _36C433B8ECA74EEB(object P_0)
		{
			return ((HttpResponseMessage)P_0).IsSuccessStatusCode;
		}

		static object _92372A1E7918429A(object P_0)
		{
			return ((HttpResponseMessage)P_0).Content;
		}

		static Task<string> _5D0EAFE7914C4908(object P_0)
		{
			return ((HttpContent)P_0).ReadAsStringAsync();
		}

		static HttpStatusCode _01E84E4ED06544E5(object P_0)
		{
			return ((HttpResponseMessage)P_0).StatusCode;
		}

		static string _5C37A14C3AA74F6C(string P_0, object P_1, object P_2)
		{
			return string.Format(P_0, P_1, P_2);
		}

		static void D81B9E9E62EA4E31(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2);
		}

		static string _227ECDAFCF144DF0(string P_0, object[] P_1)
		{
			return string.Format(P_0, P_1);
		}

		static void _30E7633F8C7847E9(ILogger P_0, string P_1, object[] P_2)
		{
			LoggerExtensions.LogWarning(P_0, P_1, P_2);
		}

		static void _51ECB22687AB403C(ILogger P_0, Exception P_1, string P_2, object[] P_3)
		{
			LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
		}

		static double _58EF49B36A9C481A(double P_0, double P_1)
		{
			return Math.Pow(P_0, P_1);
		}

		static double _45D1DE59DE1A4B34(double P_0, double P_1)
		{
			return Math.Min(P_0, P_1);
		}

		static object _8F73D2708010455E(object P_0)
		{
			return ((Exception)P_0).GetType();
		}

		static string FBA5DAD7DAAF44BF(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		unsafe void _42B9E81684C44734()
		{
			//IL_0006: Expected Obj, but got Ref
			((HttpResponseMessage)Unsafe.AsPointer(ref this)).Dispose();
		}

		static void A857AEC3DC6E42BA(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		static object F3630CF59A9D4FA9(TimeSpan P_0)
		{
			return Task.Delay(P_0);
		}

		static TaskAwaiter CAF8E318710140D8(object P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	private const int _789281D92FD04132 = 5;

	private const string DA7F8AE392294DC6 = "telegram,";

	private const string _97A1DB4DCAD640F8 = "*Protected by Proton AntiCheat*";

	private const string _21EE04CC61CA458F = "https://api.proton-anticheat.dev/steam/connect/";

	private const string _14A491F392E5422D = "https://steamcommunity.com/profiles/";

	private const int _37BF9A4A27A44914 = 256;

	private const int A1EFBBE7852A49CD = 1024;

	private const int AEB8141CFA0E49DA = 16711680;

	private const int _5E637AE0E0F84BF8 = 16776960;

	private const int ECE09631AA02401D = 6058983;

	private static readonly TimeSpan B5B4E5F09BE443A1;

	private static readonly TimeSpan A95794EC121D43E0;

	private static readonly TimeSpan _626E8B3039EA4338;

	private readonly HttpClient _32016BA8CBB1490F;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(CC44D8CFDD9E41C5))]
	public Task BA7BE5B4061A4F98(_708ECF20BC9E451D P_0, string P_1, bool P_2, string P_3 = "Player connection was denied!")
	{
		CC44D8CFDD9E41C5 stateMachine = default;
		stateMachine._6C7AF7A56A8343E5 = AsyncTaskMethodBuilder.Create();
		while (true)
		{
			int num = 1147164779;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(((num2 - (unchecked((-665246909 ^ -337319417) * 1217916183) - (1933522858 + -533958320 - unchecked(-1622046410 + -2039868249)) + 1747208240 + (1778542798 + unchecked(unchecked(-1103018299 + -1739915357) * -1409369261) + ~(--2061466359 ^ -664561071)) + 1567786394 - ~(~502955845))) ^ ((unchecked(-2146159205 * 268035713) - (-(-1751139863 - -1176764422 - -1584485621) - unchecked((953862433 + -1702153098 + unchecked(-81552271 - 2120534111)) * 24457971))) ^ -(~(1480743701 + (~-178325660 + -395692933))))) * -742733195 - ~2060661488) - 52338411) - -90193945)) % 4)
				{
				case 2u:
					break;
				case 3u:
					stateMachine.CF99A70477D84357 = this;
					stateMachine.D1D6669A363442F1 = P_0;
					num = ((int)num3 * -890962355) ^ -1551172665;
					continue;
				case 0u:
					stateMachine._64CC312961184CC5 = P_1;
					stateMachine.EE08776D551D4362 = P_2;
					stateMachine._99F6CC7DCB36421F = P_3;
					stateMachine.A46C15FCA3604F26 = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
					num = -1323493919;
					continue;
				default:
					stateMachine._6C7AF7A56A8343E5.Start(ref stateMachine);
					return stateMachine._6C7AF7A56A8343E5.Task;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_122D5D6A9EAC456D))]
	public Task _843A5100D1DA4FE0(_708ECF20BC9E451D P_0, int P_1, EFlagLevel P_2, ECheckCategory P_3, ECheckType P_4, string P_5 = "Unknown", (byte[] data, string format, Guid transactionId)? P_6 = null)
	{
		_122D5D6A9EAC456D stateMachine = default;
		stateMachine.F197FBF306F749A0 = AsyncTaskMethodBuilder.Create();
		stateMachine.FBAC4E63C4844408 = this;
		while (true)
		{
			int num = -583648786;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-((~(~(~num2) - ~(~unchecked(1460538903 * 204386169) + (-257856931 - -996198182 + unchecked(270544085 * -174654431)) + -957984277 * -unchecked(1795390577 - -1400048386))) * -1313841895) ^ -1692878317 ^ 0xE5F161A))) % 6)
				{
				case 2u:
					break;
				case 3u:
					stateMachine.FFC3CFCD7CDD44BD = P_5;
					stateMachine._5AF8A03824904CDE = P_6;
					num = (int)((num3 * 1627404101) ^ 0x5BC53DC);
					continue;
				case 1u:
					stateMachine._491755B554494568 = _003CModule_003E._390073C602714496<int>(-736908096);
					num = -44915220;
					continue;
				case 4u:
					stateMachine.B5DAB96E3E2648EA = P_0;
					num = (int)(num3 * 1265697667) ^ -2117943953;
					continue;
				case 5u:
					stateMachine._84CB94FB9EF34CF4 = P_2;
					stateMachine._28BECE69B48A4280 = P_3;
					stateMachine._6E213B3B05EB4B8B = P_4;
					num = ((int)num3 * -63424789) ^ 0x192EAB2E;
					continue;
				default:
					stateMachine.F197FBF306F749A0.Start(ref stateMachine);
					return stateMachine.F197FBF306F749A0.Task;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(EEE6572818404A13))]
	public Task _0AEFB715ADC84B45(_708ECF20BC9E451D P_0, string P_1)
	{
		EEE6572818404A13 stateMachine = default;
		stateMachine._4AA0BB91079143CF = AsyncTaskMethodBuilder.Create();
		stateMachine._2FA4F7A28F6C46DC = this;
		stateMachine._73F64EECB13F4CE4 = P_0;
		stateMachine.F9FBB8FAE1F3487B = P_1;
		stateMachine._40557D2D9E22431B = _003CModule_003E._8B9C7B12B1AE4949<int>(-1251336224);
		stateMachine._4AA0BB91079143CF.Start(ref stateMachine);
		return stateMachine._4AA0BB91079143CF.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_8B2A57B0D3E34172))]
	public Task B188543F9BD44F49(int P_0, byte[] P_1)
	{
		_8B2A57B0D3E34172 stateMachine = default;
		stateMachine.C10DEC1950E04E23 = AsyncTaskMethodBuilder.Create();
		stateMachine.DEFE89648BCD4D75 = this;
		stateMachine.FFC7583256664426 = P_0;
		while (true)
		{
			int num = -1235004838;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~((num2 * -1604757429 + ~(-(1913749697 * ((0x6D3FAF85 ^ -615329708) + --2115240233)) - ((0x7C85A98F ^ 0x17271485) + (-(-2079864458) + unchecked(881627031 * ~-648490850)))) + ((625767872 + (0xD4EFC86 ^ (-1755292415 + ~-644338916))) ^ 0x39C33264)) * -471724101) * 140778211 - -2055705357 - -944841107)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0105;
				default:
					stateMachine.B0ECD447CEEE4AEE = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817);
					stateMachine.C10DEC1950E04E23.Start(ref stateMachine);
					return stateMachine.C10DEC1950E04E23.Task;
				}
				break;
				IL_0105:
				stateMachine._136C945CB4E441F5 = P_1;
				num = ((int)num3 * -80571714) ^ -1381039248;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(BE4EBFB0425E425B))]
	public Task _76B45974F94B4212(FF4343C122D84FC9 P_0)
	{
		BE4EBFB0425E425B stateMachine = default;
		stateMachine.A67CB9F0984B47EB = AsyncTaskMethodBuilder.Create();
		stateMachine._9C727A28DFAE4564 = this;
		stateMachine.F01E0544C96B47D9 = P_0;
		stateMachine._9F89815B72034538 = _003CModule_003E._58ECCB512F2A43AC<int>(-112955817);
		stateMachine.A67CB9F0984B47EB.Start(ref stateMachine);
		return stateMachine.A67CB9F0984B47EB.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(D1998CCA49A44310))]
	private Task _9F92E532AF534C82(string? P_0, string P_1, int P_2, B57BCC7426FB478D[] P_3, (byte[] Data, string Name)? P_4 = null)
	{
		D1998CCA49A44310 stateMachine = default;
		stateMachine.BD060DCC975148A4 = AsyncTaskMethodBuilder.Create();
		while (true)
		{
			int num = 1697918995;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~num2 ^ (~(-(-683321768) - 825563058) * 785382583)) * -1716146011)) % 5)
				{
				case 0u:
					break;
				case 1u:
					stateMachine._74B177A4C93D4EF1 = this;
					stateMachine._77027E3ABDA24300 = P_0;
					num = (int)(num3 * 1945075256) ^ -1053026697;
					continue;
				case 4u:
					stateMachine.EF497DEB7DBB4109 = P_1;
					stateMachine.C80A32C95FCC4740 = P_2;
					num = ((int)num3 * -667143310) ^ -1176301487;
					continue;
				case 2u:
					stateMachine._2CA920B74DA14509 = P_3;
					stateMachine._0F26E78618BF46F2 = P_4;
					stateMachine._2A46C54F18884C0A = _003CModule_003E._390073C602714496<int>(-736908096);
					stateMachine.BD060DCC975148A4.Start(ref stateMachine);
					num = -1077993934;
					continue;
				default:
					return stateMachine.BD060DCC975148A4.Task;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(B2ADC0272AAE4A6E))]
	private Task _8489AC4CC0CF4986(string P_0, FC940335F4CA4D07 P_1)
	{
		B2ADC0272AAE4A6E stateMachine = default;
		stateMachine.F75751A067374718 = AsyncTaskMethodBuilder.Create();
		while (true)
		{
			int num = -535737118;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~((~(num2 ^ -(unchecked(unchecked((-1358926272 ^ 0x8CF229D) - (~(~228802071) + 1870351079)) * 2001749271) - ~(-126837925 * ~(~237587190 - -1899171192))) ^ -290437486) ^ ((0x7E6EB8EF ^ 0x414EB79C) - ((--822751122 ^ -1481420431) - unchecked(1056855719 * unchecked(758115286 - -1555886410))))) + -(0x20B9A010 ^ -155641231))) ^ -547398587)) % 3)
				{
				case 2u:
					break;
				case 1u:
					goto IL_00ff;
				default:
					stateMachine.D95AE0A3EE814EA0 = P_0;
					stateMachine._0C7C7C78CA86480E = P_1;
					stateMachine.D3532B0CEFF14B4D = _003CModule_003E._390073C602714496<int>(-736908096);
					stateMachine.F75751A067374718.Start(ref stateMachine);
					return stateMachine.F75751A067374718.Task;
				}
				break;
				IL_00ff:
				stateMachine.D36C889D3E5041D0 = this;
				num = (int)((num3 * 1723308011) ^ 0x4817CA98);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(E489D9C92A3A4254))]
	public Task C36BF5A01F6A4A5B(string P_0, AECA8283EE0E4BAC P_1)
	{
		E489D9C92A3A4254 stateMachine = default;
		stateMachine.BEA27C44E8F741E3 = AsyncTaskMethodBuilder.Create();
		stateMachine._235587FFA21B4BC6 = this;
		stateMachine._80021D12B6064E4B = P_0;
		stateMachine.A0A4868718F1474C = P_1;
		stateMachine._5AF9B97631374BF5 = _003CModule_003E._390073C602714496<int>(-736908096);
		stateMachine.BEA27C44E8F741E3.Start(ref stateMachine);
		return stateMachine.BEA27C44E8F741E3.Task;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool AD9461E067D24127(HttpStatusCode P_0)
	{
		if (P_0 != (HttpStatusCode)_003CModule_003E._3F57E81A62734AC2<int>(1832326239))
		{
			while (true)
			{
				int num = -321932705;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((-(-(-((-unchecked(-878395604 * -1551255621) - 1219693013) ^ -(-1028433681 * --40582528)) - -635846447) - num2) + 212630457) ^ ((0x7874A7FE ^ 0x643F003B) + ~454588810 - (-1570016779 + 565430726 - -809938816) - ~(-1936899883 * -999897667)) ^ -1928229862)) % 6)
					{
					case 0u:
						break;
					case 1u:
						goto IL_00c8;
					case 5u:
						return P_0 == (HttpStatusCode)_003CModule_003E._3F57E81A62734AC2<int>(934973363);
					case 3u:
						goto IL_0105;
					case 4u:
						goto IL_0128;
					default:
						goto end_IL_0012;
					}
					break;
					IL_0128:
					int num4;
					if (P_0 != (HttpStatusCode)_003CModule_003E._58ECCB512F2A43AC<int>(103774325))
					{
						num = -1337336875;
						num4 = num;
					}
					else
					{
						num = -646315382;
						num4 = num;
					}
					continue;
					IL_0105:
					int num5;
					if (P_0 != (HttpStatusCode)_003CModule_003E._390073C602714496<int>(1505195181))
					{
						num = -1670710962;
						num5 = num;
					}
					else
					{
						num = -646315382;
						num5 = num;
					}
					continue;
					IL_00c8:
					int num6;
					if (P_0 != (HttpStatusCode)_003CModule_003E._58ECCB512F2A43AC<int>(757311540))
					{
						num = -1228379787;
						num6 = num;
					}
					else
					{
						num = -646315382;
						num6 = num;
					}
				}
				continue;
				end_IL_0012:
				break;
			}
		}
		return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static TimeSpan F1C06CD3C7A04E0F(HttpResponseMessage P_0, string P_1)
	{
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		RetryConditionHeaderValue retryConditionHeaderValue = (RetryConditionHeaderValue)_34615D4617FC4309(_0361738BA69E499C((object)P_0));
		if (retryConditionHeaderValue != null)
		{
			goto IL_0012;
		}
		goto IL_0137;
		IL_0012:
		int num = -1710058606;
		goto IL_0017;
		IL_0017:
		TimeSpan timeSpan = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(~(~(~num2)) * -1783562437 - (--1958608970 + -879648731) * -1760268651)) % 9)
			{
			case 0u:
				break;
			case 2u:
			{
				int num8;
				int num9;
				if (!C61FA7AC51494D25((object)retryConditionHeaderValue).HasValue)
				{
					num8 = 1941504299;
					num9 = num8;
				}
				else
				{
					num8 = -2008220814;
					num9 = num8;
				}
				num = num8 ^ (int)(num3 * 1822520312);
				continue;
			}
			case 5u:
			{
				int num6;
				int num7;
				if (!(C61FA7AC51494D25((object)retryConditionHeaderValue).Value > TimeSpan.Zero))
				{
					num6 = 1394855495;
					num7 = num6;
				}
				else
				{
					num6 = 1123780807;
					num7 = num6;
				}
				num = num6 ^ ((int)num3 * -1652260285);
				continue;
			}
			case 4u:
				return _582ED5630ECF403B(C61FA7AC51494D25((object)retryConditionHeaderValue).Value);
			case 1u:
			{
				timeSpan = _3E0C9F04D9564747((object)retryConditionHeaderValue).Value - DateTimeOffset.UtcNow;
				int num4;
				int num5;
				if (!(timeSpan > TimeSpan.Zero))
				{
					num4 = -1769956581;
					num5 = num4;
				}
				else
				{
					num4 = 2012841957;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 1332483826);
				continue;
			}
			case 3u:
				goto IL_0137;
			case 6u:
				return _582ED5630ECF403B(timeSpan);
			case 8u:
				goto IL_0166;
			default:
				goto IL_018a;
			}
			break;
			IL_0166:
			int num10;
			if (!_3E0C9F04D9564747((object)retryConditionHeaderValue).HasValue)
			{
				num = -1935455013;
				num10 = num;
			}
			else
			{
				num = -685944514;
				num10 = num;
			}
		}
		goto IL_0012;
		IL_02f1:
		return A95794EC121D43E0;
		IL_0137:
		if (!E06AA5120C634468(P_1))
		{
			num = 2127483387;
			goto IL_0017;
		}
		goto IL_02f1;
		IL_018a:
		if (_0A901279EF094ED7((object)_45C8D10D450E409B((object)P_1), _003CModule_003E._3F57E81A62734AC2<string>(-363106680)))
		{
			try
			{
				JsonDocument val = (JsonDocument)_45E7A9A83AD34EA4(P_1, default(JsonDocumentOptions));
				try
				{
					JsonElement val2 = _8901652EE7D342FB((object)val);
					if (!F61BEC17E2F84084(val2, out var value))
					{
						goto IL_01cc;
					}
					goto IL_0216;
					IL_01cc:
					int num11 = 1851976879;
					goto IL_01d1;
					IL_01d1:
					JsonElement val3 = default;
					TimeSpan result = default;
					while (true)
					{
						int num2 = num11;
						uint num3;
						switch ((num3 = (uint)(~(~(~num2)) * -1783562437 - (--1958608970 + -879648731) * -1760268651)) % 6)
						{
						case 3u:
							break;
						default:
							goto end_IL_01b8;
						case 2u:
							goto IL_0216;
						case 4u:
						{
							int num12;
							int num13;
							if (F61BEC17E2F84084(val3, out value))
							{
								num12 = -6291612;
								num13 = num12;
							}
							else
							{
								num12 = -1687500260;
								num13 = num12;
							}
							num11 = num12 ^ (int)(num3 * 1345074284);
							continue;
						}
						case 1u:
							goto IL_0250;
						case 0u:
							goto end_IL_01b8;
						case 5u:
							return result;
						}
						break;
						IL_0250:
						int num14;
						if (!val2.TryGetProperty(_003CModule_003E.F84FA79ABE6944BB<string>(-926207199), ref val3))
						{
							num11 = 1889025572;
							num14 = num11;
						}
						else
						{
							num11 = 1661345376;
							num14 = num11;
						}
					}
					goto IL_01cc;
					IL_0216:
					result = _582ED5630ECF403B(TimeSpan.FromSeconds(value));
					num11 = -1998947885;
					goto IL_01d1;
					end_IL_01b8:;
				}
				finally
				{
					if (val != null)
					{
						while (true)
						{
							IL_0296:
							int num15 = -784100141;
							while (true)
							{
								int num2 = num15;
								uint num3;
								switch ((num3 = (uint)(~(~(~num2)) * -1783562437 - (--1958608970 + -879648731) * -1760268651)) % 3)
								{
								case 0u:
									break;
								default:
									goto end_IL_029b;
								case 1u:
									goto IL_02d4;
								case 2u:
									goto end_IL_029b;
								}
								goto IL_0296;
								IL_02d4:
								_0204AE6A753A474B((object)val);
								num15 = (int)(num3 * 1036869306) ^ -85062333;
								continue;
								end_IL_029b:
								break;
							}
							break;
						}
					}
				}
			}
			catch (JsonException)
			{
			}
		}
		goto IL_02f1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool F61BEC17E2F84084(JsonElement P_0, out double P_1)
	{
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Invalid comparison between Unknown and I4
		//IL_01cd: Invalid comparison between Unknown and I4
		//IL_0248: Invalid comparison between Unknown and I4
		P_1 = _003CModule_003E.F84FA79ABE6944BB<double>(-1224437531);
		bool result = default;
		JsonValueKind valueKind = default;
		JsonElement val = default;
		while (true)
		{
			int num = 180564023;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-(-(-(1188797917 - ~(-(num2 - (~((-(--1715666799) ^ 0x373CB988) - -unchecked(214562211 + 1204002894 - (0x510E5A3D ^ -239626250)) * -1267550775) + ((~(~-2061584309 - --741106935) ^ (~unchecked(2106592202 - -147265865) - -unchecked(-1492349310 * 492129225)) ^ ~(-unchecked(1339774675 * -790868696) + -872567491)) + (~unchecked(-1036269087 * (-1533883813 - -1601234185 + (-481265225 + -252085184))) - ~(unchecked(unchecked(1561821057 * -1744118837) - (-586018419 + -1002994488)) - (0x49C4DBCD ^ -299464976))))))))))))) % 13)
				{
				case 6u:
					break;
				case 3u:
					return (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
				case 0u:
					num = (int)((num3 * 1210288274) ^ 0x50D6C6FD);
					continue;
				case 1u:
					return (byte)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042) != 0;
				case 10u:
					result = (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
					num = 503450747;
					continue;
				case 2u:
				{
					int num5;
					if ((int)P_0.ValueKind == _003CModule_003E._8B9C7B12B1AE4949<int>(350091668))
					{
						num = -785683316;
						num5 = num;
					}
					else
					{
						num = -386876655;
						num5 = num;
					}
					continue;
				}
				case 4u:
				{
					int num7;
					if ((int)valueKind != _003CModule_003E._3F57E81A62734AC2<int>(-1030831117))
					{
						num = -839776555;
						num7 = num;
					}
					else
					{
						num = -380227185;
						num7 = num;
					}
					continue;
				}
				case 8u:
					valueKind = val.ValueKind;
					num = 17176342;
					continue;
				case 9u:
					result = val.TryGetDouble(ref P_1);
					num = ((int)num3 * -951403126) ^ 0x16A4D3DF;
					continue;
				case 7u:
				{
					int num6;
					if (P_0.TryGetProperty(_003CModule_003E._390073C602714496<string>(17544673), ref val))
					{
						num = -414097232;
						num6 = num;
					}
					else
					{
						num = -149554806;
						num6 = num;
					}
					continue;
				}
				case 12u:
				{
					int num4;
					if ((int)valueKind != _003CModule_003E._58ECCB512F2A43AC<int>(1659754234))
					{
						num = -759698503;
						num4 = num;
					}
					else
					{
						num = -721906826;
						num4 = num;
					}
					continue;
				}
				case 5u:
					result = double.TryParse(val.GetString(), (NumberStyles)_003CModule_003E._3F57E81A62734AC2<int>(166060164), (IFormatProvider?)_52CD399642664A35(), out P_1);
					num = 503450747;
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	private static TimeSpan _582ED5630ECF403B(TimeSpan P_0)
	{
		if (!(P_0 > _626E8B3039EA4338))
		{
			while (true)
			{
				int num = 818097357;
				uint num2;
				switch ((num2 = (uint)(~(((num * 842279777 - ((((-(--745336868) - unchecked(-1592707225 * -338979663)) ^ 0x57B700D5) - -(-(~1637279043 + (-176338141 ^ -1940790413)))) ^ (-(-1432033748 * 1998264131 + (~-2136684429 - (-664102429 + 1762860778))) * -503064097)) - -(-(-(-423638921 ^ -1618769759)))) ^ 0x1B34BF49 ^ ~(unchecked(1595577291 * 2126828117) + -1041704444)) - -1431665599 * --2142189272) - 195380867)) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return P_0;
				}
				break;
			}
		}
		return _626E8B3039EA4338;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IteratorStateMachine(typeof(B5D3C58D61C74E08))]
	private static IEnumerable<(string ChatId, string? ThreadId, string BotToken)> F91F85B4382B4C24(string P_0)
	{
		object obj = _63E5E4C2ABC74AB0(_003CModule_003E._58ECCB512F2A43AC<int>(728482992));
		((B5D3C58D61C74E08)obj)._531EE05250704BB5 = P_0;
		return (IEnumerable<(string ChatId, string? ThreadId, string BotToken)>)obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static List<B57BCC7426FB478D> _7747FDF87DBB4AA1(B57BCC7426FB478D[] P_0)
	{
		List<B57BCC7426FB478D> list = new List<B57BCC7426FB478D>(P_0.Length);
		B57BCC7426FB478D b57BCC7426FB478D = default;
		B57BCC7426FB478D item = default;
		int num6 = default;
		while (true)
		{
			int num = -670574307;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((num2 + -(-(unchecked(1833623385 * 1804195014) - 512499080 - unchecked(351968819 * ~-1482146287) + ~(-158045870 ^ --2110713823) + -361127418))) ^ -((-1072690990 ^ -9577317) - (-(-1478314576) + unchecked(443200357 * unchecked(-1252025248 * 1588854357)) - (-893681645 - (-389523260 - -1149132026) - -663462332))) ^ -(~((--1067582363 ^ 0x6A1B145B) + (-1989168404 + 687142045 + ~-913376048))))) % 15)
				{
				case 3u:
					break;
				case 11u:
					b57BCC7426FB478D = list[list.Count - _003CModule_003E.F84FA79ABE6944BB<int>(1741630884)];
					num = 533230384;
					continue;
				case 6u:
				{
					item = P_0[num6];
					int num7;
					if (!item._5EE35423D9AC40C2)
					{
						num = 210331230;
						num7 = num;
					}
					else
					{
						num = -25183971;
						num7 = num;
					}
					continue;
				}
				case 10u:
					num = ((int)num3 * -1408236135) ^ 0x61ADC21;
					continue;
				case 12u:
				{
					int num9;
					int num10;
					if (list.Count != 0)
					{
						num9 = -1080140554;
						num10 = num9;
					}
					else
					{
						num9 = -1685897585;
						num10 = num9;
					}
					num = num9 ^ ((int)num3 * -235795406);
					continue;
				}
				case 8u:
					num6 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
					num = -503134174;
					continue;
				case 9u:
					list.Add(item);
					num = 627504707;
					continue;
				case 7u:
				{
					int num11;
					int num12;
					if (!b57BCC7426FB478D._5EE35423D9AC40C2)
					{
						num11 = -324447849;
						num12 = num11;
					}
					else
					{
						num11 = -985218678;
						num12 = num11;
					}
					num = num11 ^ ((int)num3 * -12416349);
					continue;
				}
				case 5u:
					num = ((int)num3 * -1592015825) ^ 0x7250E426;
					continue;
				case 2u:
					num6 += _003CModule_003E._58ECCB512F2A43AC<int>(1006217019);
					num = -739542456;
					continue;
				case 0u:
				{
					int num8;
					if (num6 < P_0.Length)
					{
						num = 696381122;
						num8 = num;
					}
					else
					{
						num = -492352314;
						num8 = num;
					}
					continue;
				}
				case 4u:
					list.RemoveAt(list.Count - _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
					num = 483905093;
					continue;
				case 1u:
				{
					int num5;
					if (list.Count <= _003CModule_003E._8B9C7B12B1AE4949<int>(-658048563))
					{
						num = -114767579;
						num5 = num;
					}
					else
					{
						num = 649422185;
						num5 = num;
					}
					continue;
				}
				case 13u:
				{
					b57BCC7426FB478D = list[list.Count - _003CModule_003E._3F57E81A62734AC2<int>(1017304263)];
					int num4;
					if (!b57BCC7426FB478D._5EE35423D9AC40C2)
					{
						num = -114767579;
						num4 = num;
					}
					else
					{
						num = 213881130;
						num4 = num;
					}
					continue;
				}
				default:
					return list;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string F609E619EE744883(string? P_0)
	{
		if (A6C1457C51534D93(P_0))
		{
			goto IL_000b;
		}
		goto IL_0145;
		IL_000b:
		int num = 342221920;
		goto IL_0010;
		IL_0010:
		StringBuilder stringBuilder = default;
		char c = default;
		int num4 = default;
		bool flag = default;
		string text = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(~((-1588497407 * -(~(~(-1151431067 ^ 0x6073B8B7) - ~-624405062) - (-1533231088 - (unchecked(-856938642 - (0x620490CE ^ 0xF95213C)) + -1799525718))) - num2) * 1518989769) ^ 0x53102327)) % 18)
			{
			case 15u:
				break;
			case 2u:
				D431FB74E8F84C14((object)stringBuilder, c);
				num4 += _003CModule_003E._58ECCB512F2A43AC<int>(1006217019);
				num = -170013799;
				continue;
			case 13u:
				num = ((int)num3 * -1409346590) ^ -163119457;
				continue;
			case 6u:
				flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0;
				num = 838751303;
				continue;
			case 17u:
				goto IL_00ff;
			case 4u:
				goto IL_0122;
			case 11u:
				goto IL_0145;
			case 8u:
				goto IL_0168;
			case 7u:
				text = P_0;
				num4 = _003CModule_003E._58ECCB512F2A43AC<int>(352679804);
				num = 253054272;
				continue;
			case 1u:
				return string.Empty;
			case 0u:
				goto IL_01b7;
			case 14u:
				goto IL_01da;
			case 12u:
				D431FB74E8F84C14((object)stringBuilder, (char)_003CModule_003E._8B9C7B12B1AE4949<int>(-1927594399));
				num = -877104397;
				continue;
			case 16u:
				num = (int)(num3 * 1695294512) ^ -560543988;
				continue;
			case 9u:
				goto IL_0222;
			case 5u:
				flag = (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(-658048563) != 0;
				num = 838751303;
				continue;
			case 3u:
				goto IL_0265;
			default:
				return ED96AB046E7246E8((object)stringBuilder);
			}
			break;
			IL_0265:
			int num5;
			if (c == _003CModule_003E._3F57E81A62734AC2<int>(-1991541400))
			{
				num = -643165009;
				num5 = num;
			}
			else
			{
				num = -421933237;
				num5 = num;
			}
			continue;
			IL_00ff:
			int num6;
			if (c == _003CModule_003E._390073C602714496<int>(-1791018005))
			{
				num = -643165009;
				num6 = num;
			}
			else
			{
				num = -1141031508;
				num6 = num;
			}
			continue;
			IL_0168:
			int num7;
			if (num4 >= F329491C44104C55((object)text))
			{
				num = -1153761189;
				num7 = num;
			}
			else
			{
				num = 753348790;
				num7 = num;
			}
			continue;
			IL_0222:
			c = CC0F84FFE5014474((object)text, num4);
			int num8;
			if ((uint)c <= (uint)_003CModule_003E._8B9C7B12B1AE4949<int>(-1901605506))
			{
				num = -1209809386;
				num8 = num;
			}
			else
			{
				num = 1786688533;
				num8 = num;
			}
			continue;
			IL_01b7:
			int num9;
			if (c != _003CModule_003E._58ECCB512F2A43AC<int>(1970435173))
			{
				num = 171444653;
				num9 = num;
			}
			else
			{
				num = -643165009;
				num9 = num;
			}
			continue;
			IL_0122:
			int num10;
			if (c != _003CModule_003E.F84FA79ABE6944BB<int>(-1550069377))
			{
				num = -401408872;
				num10 = num;
			}
			else
			{
				num = -643165009;
				num10 = num;
			}
			continue;
			IL_01da:
			int num11;
			if (flag)
			{
				num = -1698406007;
				num11 = num;
			}
			else
			{
				num = -877104397;
				num11 = num;
			}
		}
		goto IL_000b;
		IL_0145:
		stringBuilder = (StringBuilder)C92B366A497F40F2(F329491C44104C55((object)P_0) + _003CModule_003E._390073C602714496<int>(605342613));
		num = 355304996;
		goto IL_0010;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string _2B07CBD6A2064FB3(string? P_0)
	{
		return _80CA2CB46C5A4E72(E06AA5120C634468(P_0) ? _003CModule_003E._8B9C7B12B1AE4949<string>(-696660496) : P_0, _003CModule_003E._390073C602714496<int>(-1705549634));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string _80CA2CB46C5A4E72(string P_0, int P_1)
	{
		if (F329491C44104C55((object)P_0) > P_1)
		{
			while (true)
			{
				int num = 632444206;
				uint num2;
				switch ((num2 = (uint)(-1456482732 - ~(-(~(-num) + (0x5BD33B89 ^ (unchecked(943263208 - -1753811718) - (~520684379 - (0x1FD48294 ^ -958939276) - (-620622515 ^ -1947383152)))) - -(~-44144153))) * 1266170947)) % 3)
				{
				case 2u:
					continue;
				case 1u:
					return FCB0409A66F14C70(_5214272B6D984EA0((object)P_0, _003CModule_003E._390073C602714496<int>(2131963235), P_1 - _003CModule_003E._8B9C7B12B1AE4949<int>(350091668)), _003CModule_003E.F84FA79ABE6944BB<string>(-1165692495));
				}
				break;
			}
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static B57BCC7426FB478D _81EF6BD8F9214C5F(_708ECF20BC9E451D P_0)
	{
		return B57BCC7426FB478D.CB4C7FBDFCFE4AF9(_003CModule_003E._390073C602714496<string>(-396364011), _5BB5B53A54134D36((LocalizedString)_3ECDF13164314D39((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._3F57E81A62734AC2<string>(-298024410))), _0F03559DDD534194(P_0._7CD049C055E3441A, _003CModule_003E._3F57E81A62734AC2<string>(1945357780), P_0.D0085BCED909426B, _003CModule_003E._58ECCB512F2A43AC<string>(-1803169580)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static B57BCC7426FB478D D4EE704625AB4B2D(_708ECF20BC9E451D P_0)
	{
		string text = _003CModule_003E._58ECCB512F2A43AC<string>(1184723286);
		string text2 = _5BB5B53A54134D36((LocalizedString)_3ECDF13164314D39((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._8B9C7B12B1AE4949<string>(-655175239)));
		string text3 = _003CModule_003E.F84FA79ABE6944BB<string>(-1150583878);
		object[] array = new object[_003CModule_003E.F84FA79ABE6944BB<int>(2084623923)];
		array[_003CModule_003E._390073C602714496<int>(2131963235)] = P_0._37B20A4113D244AA;
		array[_003CModule_003E._3F57E81A62734AC2<int>(1017304263)] = _003CModule_003E._3F57E81A62734AC2<string>(1753560696);
		array[_003CModule_003E.F84FA79ABE6944BB<int>(-1423102128)] = P_0._37B20A4113D244AA;
		array[_003CModule_003E._3F57E81A62734AC2<int>(-1030831117)] = P_0._35219130B15F4D94;
		return B57BCC7426FB478D._677432EDFDA943DB(text, text2, _999B47C00B26454B(text3, array));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static B57BCC7426FB478D DA7AA132A7494DC8(_708ECF20BC9E451D P_0)
	{
		return B57BCC7426FB478D._677432EDFDA943DB(_003CModule_003E.F84FA79ABE6944BB<string>(-2000512167), _5BB5B53A54134D36((LocalizedString)_3ECDF13164314D39((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E.F84FA79ABE6944BB<string>(1608469051))), F9734AB2DB94457C(_003CModule_003E.F84FA79ABE6944BB<string>(-449489183), (object)P_0.B38102437FF64506));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static B57BCC7426FB478D _77C04349D42C4110(_708ECF20BC9E451D P_0)
	{
		return B57BCC7426FB478D._677432EDFDA943DB(_003CModule_003E._58ECCB512F2A43AC<string>(-961730771), _5BB5B53A54134D36((LocalizedString)_3ECDF13164314D39((object)C179263454B44BF6._66EFCEB30AD8408A, _003CModule_003E._3F57E81A62734AC2<string>(1369966528))), C58D6585E7A24EB8(P_0._143FFF351A2C4104));
	}

	public virtual void _111F02A2632A43C6()
	{
		A2E064050B844E37((object)_32016BA8CBB1490F);
		_05E82FD0D4C34573();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static _708ECF20BC9E451D _859332892E8643A6(SteamPlayer P_0)
	{
		_708ECF20BC9E451D result = _96F1F311F227458B(P_0);
		result.ACF9BC69E5294E28 = ConfigurationBinder.GetValue<string>(C179263454B44BF6.F4734FD3602D47CD, _003CModule_003E._58ECCB512F2A43AC<string>(625136868), _003CModule_003E._58ECCB512F2A43AC<string>(692318299)) ?? _003CModule_003E.F84FA79ABE6944BB<string>(2095790532);
		result._8DCA212F88FC4301 = ConfigurationBinder.GetValue<string>(C179263454B44BF6.F4734FD3602D47CD, _003CModule_003E._3F57E81A62734AC2<string>(601053329), _003CModule_003E._8B9C7B12B1AE4949<string>(796808756)) ?? _003CModule_003E._3F57E81A62734AC2<string>(-2142288665);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static _708ECF20BC9E451D _9E407BCF45E5403A(SteamPlayer P_0)
	{
		_708ECF20BC9E451D result = _96F1F311F227458B(P_0);
		result.ACF9BC69E5294E28 = ConfigurationBinder.GetValue<string>(C179263454B44BF6.F4734FD3602D47CD, _003CModule_003E._8B9C7B12B1AE4949<string>(77063790), _003CModule_003E.F84FA79ABE6944BB<string>(2095790532)) ?? _003CModule_003E._3F57E81A62734AC2<string>(-2142288665);
		result._8DCA212F88FC4301 = ConfigurationBinder.GetValue<string>(C179263454B44BF6.F4734FD3602D47CD, _003CModule_003E.F84FA79ABE6944BB<string>(-1715701020), _003CModule_003E._58ECCB512F2A43AC<string>(692318299)) ?? _003CModule_003E.F84FA79ABE6944BB<string>(2095790532);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static _708ECF20BC9E451D _29ACB008E63D4EB5(SteamPlayer P_0)
	{
		_708ECF20BC9E451D result = _96F1F311F227458B(P_0);
		result.ACF9BC69E5294E28 = ConfigurationBinder.GetValue<string>(C179263454B44BF6.F4734FD3602D47CD, _003CModule_003E.F84FA79ABE6944BB<string>(1384092372), _003CModule_003E._8B9C7B12B1AE4949<string>(796808756)) ?? _003CModule_003E._3F57E81A62734AC2<string>(-2142288665);
		result._8DCA212F88FC4301 = ConfigurationBinder.GetValue<string>(C179263454B44BF6.F4734FD3602D47CD, _003CModule_003E._8B9C7B12B1AE4949<string>(-226827839), _003CModule_003E.F84FA79ABE6944BB<string>(2095790532)) ?? _003CModule_003E._58ECCB512F2A43AC<string>(692318299);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static _708ECF20BC9E451D _8C03C3611F0D4FA4(SteamPlayer P_0)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		_708ECF20BC9E451D result = default;
		while (true)
		{
			int num = -265787199;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((--1055868780 - -(~(num2 * -1284825795) * 1764532945)) * 1932762301 * 853381073 * -2018268849)) % 3)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0050;
				default:
					return result;
				}
				break;
				IL_0050:
				result._37B20A4113D244AA = _8EF84CE69D90459F(_87D2B733FC294093((object)P_0)).m_SteamID;
				result._7CD049C055E3441A = _0FF720122C9A44FE(_87D2B733FC294093((object)P_0));
				result.D0085BCED909426B = AC1AAA353781487F(_87D2B733FC294093((object)P_0));
				result._35219130B15F4D94 = F9734AB2DB94457C(_003CModule_003E._3F57E81A62734AC2<string>(537695922), (object)_64A4BBC5E4CE4EE1._7B1216BE8CDA4953.Invoke(P_0));
				result.B38102437FF64506 = _9E370707E6364453((Player)_12AB3F7B429F43D9((object)P_0));
				result._143FFF351A2C4104 = DDE19CAED4594F92() - _0B882518A4164872((object)P_0);
				num = 1254564591;
			}
		}
	}

	public B7097FC49A384CFA()
	{
		_34563B1FC7304350();
		_882421B50F934C0C((object)null, default(TimeSpan));
		_32016BA8CBB1490F = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static B7097FC49A384CFA()
	{
		_003CModule_003E._3F57E81A62734AC2<string>(1715918802);
		_003CModule_003E._3F57E81A62734AC2<string>(-450390411);
		_003CModule_003E._3F57E81A62734AC2<string>(-561583219);
	}

	static object _0361738BA69E499C(object P_0)
	{
		return ((HttpResponseMessage)P_0).Headers;
	}

	static object _34615D4617FC4309(object P_0)
	{
		return ((HttpResponseHeaders)P_0).RetryAfter;
	}

	static TimeSpan? C61FA7AC51494D25(object P_0)
	{
		return ((RetryConditionHeaderValue)P_0).Delta;
	}

	static DateTimeOffset? _3E0C9F04D9564747(object P_0)
	{
		return ((RetryConditionHeaderValue)P_0).Date;
	}

	static bool E06AA5120C634468(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static string _45C8D10D450E409B(object P_0)
	{
		return ((string)P_0).TrimStart();
	}

	static bool _0A901279EF094ED7(object P_0, string P_1)
	{
		return ((string)P_0).StartsWith(P_1);
	}

	static object _45E7A9A83AD34EA4(string P_0, JsonDocumentOptions P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return JsonDocument.Parse(P_0, P_1);
	}

	static JsonElement _8901652EE7D342FB(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((JsonDocument)P_0).RootElement;
	}

	static void _0204AE6A753A474B(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static object _52CD399642664A35()
	{
		return CultureInfo.InvariantCulture;
	}

	static object _63E5E4C2ABC74AB0(int P_0)
	{
		return new B5D3C58D61C74E08(P_0);
	}

	static bool A6C1457C51534D93(string P_0)
	{
		return string.IsNullOrEmpty(P_0);
	}

	static int F329491C44104C55(object P_0)
	{
		return ((string)P_0).Length;
	}

	static object C92B366A497F40F2(int P_0)
	{
		return new StringBuilder(P_0);
	}

	static char CC0F84FFE5014474(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	static object D431FB74E8F84C14(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	static string ED96AB046E7246E8(object P_0)
	{
		return P_0.ToString();
	}

	static string _5214272B6D984EA0(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	static string FCB0409A66F14C70(string P_0, string P_1)
	{
		return P_0 + P_1;
	}

	static object _3ECDF13164314D39(object P_0, string P_1)
	{
		return ((IStringLocalizer)P_0)[P_1];
	}

	static string _5BB5B53A54134D36(LocalizedString P_0)
	{
		return LocalizedString.op_Implicit(P_0);
	}

	static string _0F03559DDD534194(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static string _999B47C00B26454B(string P_0, object[] P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string F9734AB2DB94457C(string P_0, object P_1)
	{
		return string.Format(P_0, P_1);
	}

	static string C58D6585E7A24EB8(float P_0)
	{
		return _9AB67761792440A7._9EF78793AEAE41AB(P_0);
	}

	static void A2E064050B844E37(object P_0)
	{
		((HttpMessageInvoker)P_0).Dispose();
	}

	void _05E82FD0D4C34573()
	{
		base.Dispose();
	}

	static _708ECF20BC9E451D _96F1F311F227458B(SteamPlayer P_0)
	{
		return _8C03C3611F0D4FA4(P_0);
	}

	static object _87D2B733FC294093(object P_0)
	{
		return ((SteamPlayer)P_0).playerID;
	}

	static CSteamID _8EF84CE69D90459F(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((SteamPlayerID)P_0).steamID;
	}

	static string _0FF720122C9A44FE(object P_0)
	{
		return ((SteamPlayerID)P_0).characterName;
	}

	static string AC1AAA353781487F(object P_0)
	{
		return ((SteamPlayerID)P_0).playerName;
	}

	static object _12AB3F7B429F43D9(object P_0)
	{
		return ((SteamPlayer)P_0).player;
	}

	static int _9E370707E6364453(Player P_0)
	{
		return _5D3F4B1BF6654E52.C8F36D848FF540AB(P_0);
	}

	static float DDE19CAED4594F92()
	{
		return Time.realtimeSinceStartup;
	}

	static float _0B882518A4164872(object P_0)
	{
		return ((SteamPlayer)P_0).joined;
	}

	static object _34563B1FC7304350()
	{
		return new HttpClient();
	}

	static void _882421B50F934C0C(object P_0, TimeSpan P_1)
	{
		((HttpClient)P_0).Timeout = P_1;
	}
}
