using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Steamworks;
using UnityEngine;

public sealed class E2BC8640A3134A27 : _200C0FCD340543F6
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _7D30235674574B35
	{
		public static readonly _7D30235674574B35 _003C_003E9 = (_7D30235674574B35)_53BE2880A43449C1();

		public static Func<string, bool> _003C_003E9__5_0;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _25D789BD22074768(string P_0)
		{
			return (ADF4C5E8A26D41C5(P_0) ? 1 : 0) == _003CModule_003E._3F57E81A62734AC2<int>(-1803194042);
		}

		static object _53BE2880A43449C1()
		{
			return new _7D30235674574B35();
		}

		static bool ADF4C5E8A26D41C5(string P_0)
		{
			return string.IsNullOrWhiteSpace(P_0);
		}
	}

	[CompilerGenerated]
	private readonly CSteamID B65EB0A099D4436D;

	public CSteamID B1152A11940B4BBB
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return B65EB0A099D4436D;
		}
	}

	internal E2BC8640A3134A27(CSteamID P_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		B65EB0A099D4436D = P_0;
	}

	public CSteamID? _6D5CEF5CF5B74ED6()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return FC13EEE205BB4769((object)this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UniTask F4AD19CEE24D4B41(string P_0, Color P_1, bool P_2 = true, string? P_3 = null)
	{
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		IEnumerable<string> enumerable = from text in _4B9132EF62C34937((object)_9569D403F20D410B((object)P_0, _0C276219B9984F04(), _003CModule_003E.F84FA79ABE6944BB<string>(-1739819941)), (char)_003CModule_003E._390073C602714496<int>(-224097870), (StringSplitOptions)_003CModule_003E._3F57E81A62734AC2<int>(-1803194042))
			where (_7D30235674574B35.ADF4C5E8A26D41C5(text) ? 1 : 0) == _003CModule_003E._3F57E81A62734AC2<int>(-1803194042)
			select text;
		if (!enumerable.Any())
		{
			while (true)
			{
				int num = -101508370;
				uint num2;
				switch ((num2 = (uint)(((~(~(-(~(1329049987 * -(-1406730195 - -622691515)) + (unchecked(unchecked(unchecked(91680473 * -699761382) * -1361137745) * 616707493) - ~(-(-428188607)))) - ~num - 939336499)) - unchecked(-2147408899 - ~-555235450)) ^ 0x2DFAD974) + -217513876)) % 3)
				{
				case 0u:
					continue;
				case 2u:
					return UniTask.CompletedTask;
				}
				break;
			}
		}
		IEnumerator<string> enumerator = enumerable.GetEnumerator();
		try
		{
			while (true)
			{
				IL_01b4:
				int num3;
				int num4;
				if (_08C50EDC8B6C4C29((object)enumerator))
				{
					num3 = 667667049;
					num4 = num3;
				}
				else
				{
					num3 = -325250109;
					num4 = num3;
				}
				while (true)
				{
					int num = num3;
					uint num2;
					switch ((num2 = (uint)(((~(~(-(~(1329049987 * -(-1406730195 - -622691515)) + (unchecked(unchecked(unchecked(91680473 * -699761382) * -1361137745) * 616707493) - ~(-(-428188607)))) - ~num - 939336499)) - unchecked(-2147408899 - ~-555235450)) ^ 0x2DFAD974) + -217513876)) % 4)
					{
					case 3u:
						num3 = 667667049;
						continue;
					default:
						goto end_IL_010b;
					case 2u:
					{
						string current = enumerator.Current;
						object obj = AC1C7ECB477D4DB8(_54F03A6F2BA44363());
						if (obj == null)
						{
							break;
						}
						_1DB03CB0B9F94A22((ILogger)obj, current, Array.Empty<object>());
						num3 = -2084960320;
						continue;
					}
					case 1u:
						break;
					case 0u:
						goto end_IL_010b;
					}
					goto IL_01b4;
					continue;
					end_IL_010b:
					break;
				}
				break;
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					IL_01db:
					int num5 = 479410287;
					while (true)
					{
						int num = num5;
						uint num2;
						switch ((num2 = (uint)(((~(~(-(~(1329049987 * -(-1406730195 - -622691515)) + (unchecked(unchecked(unchecked(91680473 * -699761382) * -1361137745) * 616707493) - ~(-(-428188607)))) - ~num - 939336499)) - unchecked(-2147408899 - ~-555235450)) ^ 0x2DFAD974) + -217513876)) % 3)
						{
						case 0u:
							break;
						default:
							goto end_IL_01e0;
						case 1u:
							goto IL_0259;
						case 2u:
							goto end_IL_01e0;
						}
						goto IL_01db;
						IL_0259:
						_8906D234690F428E((object)enumerator);
						num5 = ((int)num2 * -1539879576) ^ 0x1C950629;
						continue;
						end_IL_01e0:
						break;
					}
					break;
				}
			}
		}
		return UniTask.CompletedTask;
	}

	static CSteamID FC13EEE205BB4769(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((E2BC8640A3134A27)P_0).B1152A11940B4BBB;
	}

	static string _0C276219B9984F04()
	{
		return Environment.NewLine;
	}

	static string _9569D403F20D410B(object P_0, string P_1, string P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	static string[] _4B9132EF62C34937(object P_0, char P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split(P_1, P_2);
	}

	static object _54F03A6F2BA44363()
	{
		return _1DB744298E9F4B09._052FBC588F454484;
	}

	static object AC1C7ECB477D4DB8(object P_0)
	{
		return ((_1DB744298E9F4B09)P_0)._83E23B43ACAC4FEA;
	}

	static void _1DB03CB0B9F94A22(ILogger P_0, string P_1, object[] P_2)
	{
		LoggerExtensions.LogInformation(P_0, P_1, P_2);
	}

	static bool _08C50EDC8B6C4C29(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	static void _8906D234690F428E(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
