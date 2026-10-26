using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using HarmonyLib;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using SDG.Unturned;
using UnityEngine.LowLevel;

public class _1DB744298E9F4B09
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _351058E3F6BE45AB : IAsyncStateMachine
	{
		public int _39B221AA455F4218;

		public AsyncTaskMethodBuilder _423B4CD0D8254759;

		public _1DB744298E9F4B09 B6E2974E575D4A4F;

		private TaskAwaiter _437C287AEEFD45EE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		private void MoveNext()
		{
			_39B221AA455F4218 = -1;
			_39B221AA455F4218 = 0;
			_39B221AA455F4218 = -2;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_423B4CD0D8254759.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}

		static CancellationToken _536F76463D514C0E(object? P_0)
		{
			return ((_1DB744298E9F4B09)P_0).A70B1408B5ED4F4E;
		}

		static object? _1094BCD675FB4F72(object? P_0, CancellationToken P_1)
		{
			return ((_02C54685DE0E4B81)P_0)._73E9E2A3C0BD48F5(P_1);
		}

		static TaskAwaiter BF2F9B05A26448C0(object? P_0)
		{
			return ((Task)P_0).GetAwaiter();
		}
	}

	internal const string E30D35CFB0804EC3 = "ProtonAnticheatPluginHarmony";

	private Harmony? A625F449A82745AC;

	private IConfiguration? _28EB422A207049DC;

	private ILogger? _1DC5134FEF8147BE;

	private ILoggerProvider? BCA776D1DA7D4C8D;

	private IStringLocalizer? _207917117A0940F3;

	private _4C6B03DD3A6441ED? E189947B5D624D72;

	private string? E876F2059BDE4E2D;

	private string? _1324026459604EF8;

	private CancellationTokenSource? _3F0C7F57126F4A3D;

	[CompilerGenerated]
	private CancellationToken _78B98250AB1F4F24;

	[CompilerGenerated]
	private bool A62FF70BE54F4876;

	internal CCF339C5456845F6? _6FB0679464DB4BF6;

	internal _631D551E2DA64E7D? CF47F3EE0E0C4452;

	internal _02C54685DE0E4B81? _0D077240941749FA;

	private Func<Task>? _65184107759743C4;

	private static _1DB744298E9F4B09? _4C759A73139B4C65;

	private bool _6D51944268D542DB;

	private bool F25E3D9195684DE5;

	internal A19CBF069C964833._40FE7AC3F69F4B10? ABB07B32EA8A499F;

	internal A19CBF069C964833._40FE7AC3F69F4B10? _769F45D6312C4B96;

	internal A19CBF069C964833._40FE7AC3F69F4B10? E31BDAB232D6433D;

	internal A19CBF069C964833._40FE7AC3F69F4B10? _4FCE5BF09DEA4F4D;

	internal CancellationToken A70B1408B5ED4F4E
	{
		[CompilerGenerated]
		get
		{
			return _78B98250AB1F4F24;
		}
		[CompilerGenerated]
		private set
		{
			_78B98250AB1F4F24 = cancellationToken;
		}
	}

	internal bool _6EB2D3D9EC934A7A
	{
		[CompilerGenerated]
		get
		{
			return A62FF70BE54F4876;
		}
		[CompilerGenerated]
		private set
		{
			A62FF70BE54F4876 = a62FF70BE54F;
		}
	}

	internal string E58B6ED9182C4C76
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			return E876F2059BDE4E2D ?? B9B9A626BBC7429B(ReadWrite.PATH, _003CModule_003E.F84FA79ABE6944BB<string>(1010882099));
		}
	}

	internal ILogger? _83E23B43ACAC4FEA => _1DC5134FEF8147BE;

	public string EBFF406DCE4B4FB2
	{
		get
		{
			_928653F3A4454D31();
			return null;
		}
	}

	internal static _1DB744298E9F4B09 _052FBC588F454484
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			_2112E077830844B3((string?)null);
			return null;
		}
	}

	private _1DB744298E9F4B09()
	{
	}

	public static _1DB744298E9F4B09 _5854F6AC0CF0464E()
	{
		return new _1DB744298E9F4B09();
	}

	public _1DB744298E9F4B09 _425B7C44C9AB4478(Harmony P_0)
	{
		A625F449A82745AC = P_0;
		return this;
	}

	public _1DB744298E9F4B09 C692D0924E23408D(ILogger P_0)
	{
		_1DC5134FEF8147BE = P_0;
		return this;
	}

	public _1DB744298E9F4B09 _9127E76D13FB459F(string P_0)
	{
		E876F2059BDE4E2D = P_0;
		return this;
	}

	public _1DB744298E9F4B09 _2A06EA6591F2473D(string P_0)
	{
		_1324026459604EF8 = P_0;
		return this;
	}

	public _1DB744298E9F4B09 _9D6B80FD1FF44F7B(_4C6B03DD3A6441ED P_0)
	{
		E189947B5D624D72 = P_0;
		return this;
	}

	public _1DB744298E9F4B09 _287B059A86E24015(Func<Task> P_0)
	{
		_65184107759743C4 = P_0;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public _1DB744298E9F4B09 E8D77ACB56BA43BF()
	{
		GC.KeepAlive(null);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _72B072476EA64F92()
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		_08D958B930D443EB(default(RuntimeTypeHandle));
		E73073B4F7264BA1((string?)null);
		_08D958B930D443EB(default(RuntimeTypeHandle));
		_80D7F4281FD5494F((object?)null, (string?)null, BindingFlags.Default);
		E73073B4F7264BA1((string?)null);
		_01B722A967B642C6();
		_3B3CF6E9B6C94F08((object?)null);
		int num = 0;
		_2329A64F30024A49();
		_08D958B930D443EB(default(RuntimeTypeHandle));
		_80D7F4281FD5494F((object?)null, (string?)null, BindingFlags.Default);
		uint num2 = 8u;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0u:
				num2 = 1u;
				break;
			case 1u:
				return;
			case 2u:
				num2 = 0u;
				break;
			case 3u:
				_80D7F4281FD5494F((object?)null, (string?)null, BindingFlags.Default);
				num2 = 7u;
				break;
			case 4u:
				_4632CE99A2EE4D98((object?)null, (object?)0, (object?)num);
				num2 = 5u;
				break;
			case 5u:
				_2C8446EA5F1243E8();
				num2 = 2u;
				break;
			case 7u:
				_4632CE99A2EE4D98((object?)null, (object?)0, (object?)null);
				num2 = 4u;
				break;
			case 8u:
				num2 = 3u;
				break;
			case 6u:
				return;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private void _0089880B6BD64885(Exception P_0)
	{
		Assembly assembly = (Assembly)B5EDA2F4B9744EB3();
		int num4 = default;
		StackFrame stackFrame = default;
		StackFrame[] array = default;
		StackTrace stackTrace = default;
		while (true)
		{
			int num = 1979735620;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-num2 - (0x482548E6 ^ -1475024364)) * 1518389097 * -1433160573)) % 11)
				{
				case 6u:
					break;
				default:
					return;
				case 7u:
					num4 += _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
					num = 967755838;
					continue;
				case 1u:
				{
					ILogger? val = _1DC5134FEF8147BE;
					if (val != null)
					{
						_04836BC3E9914ECF(val, P_0, _003CModule_003E._390073C602714496<string>(-155015184), Array.Empty<object>());
					}
					return;
				}
				case 2u:
				{
					int num10;
					int num11;
					if (_900528C3C94D4EB9((Assembly?)_4AA0B6CB62334AA1(_99B9B690FC8F4F54(_0B1227EB3A824F28((object?)stackFrame))), assembly))
					{
						num10 = 1809629308;
						num11 = num10;
					}
					else
					{
						num10 = -1932750710;
						num11 = num10;
					}
					num = num10 ^ ((int)num3 * -1344217191);
					continue;
				}
				case 4u:
					array = _66D23BCC50794326((object?)stackTrace);
					num4 = _003CModule_003E._390073C602714496<int>(2131963235);
					num = 967755838;
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (!_4D16230D059E4F12((Type?)_99B9B690FC8F4F54(_0B1227EB3A824F28((object?)stackFrame)), (Type?)null))
					{
						num6 = 702549989;
						num7 = num6;
					}
					else
					{
						num6 = -1638820183;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -524009920);
					continue;
				}
				case 8u:
				{
					stackTrace = (StackTrace)E8A1BBE3FF6D405E((object?)P_0, (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1398637845) != 0);
					int num9;
					if (_77570C2EA5634BEE((object?)stackTrace) == 0)
					{
						num = -1774293256;
						num9 = num;
					}
					else
					{
						num = -574953794;
						num9 = num;
					}
					continue;
				}
				case 5u:
				{
					int num8;
					if (num4 < array.Length)
					{
						num = 50732543;
						num8 = num;
					}
					else
					{
						num = 1162813816;
						num8 = num;
					}
					continue;
				}
				case 3u:
				{
					stackFrame = array[num4];
					int num5;
					if (_221617961E494D2D(stackFrame))
					{
						num = -859195047;
						num5 = num;
					}
					else
					{
						num = -334098395;
						num5 = num;
					}
					continue;
				}
				case 10u:
					return;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _2470246CB7CF4D5E()
	{
		_602204D3EAB54978();
		C1294F0A5D8D438A((object?)null);
		_0BDC346A9B654476((object?)null);
		_4CF5126EEB2E4F86((object?)null);
		_74776E9056D94426();
		F86B2FD60D0D4000((object?)this);
		D295963FF71444B7(_1DC5134FEF8147BE, (string?)null, (object?[]?)null);
		_2BB3781EEB3A40ED((object?)null, (string?)null, StringComparison.CurrentCulture);
		_292A1432976B4A8A();
		_302B6840F2674835((object?)null);
		_134AEE2E797D4022((object?)null);
		_5E70AF3660A442D8((object?)null);
		_72B072476EA64F92();
		throw new Exception();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _72F9E20AFFAE478D(string P_0, string P_1, string P_2)
	{
		GC.KeepAlive(null);
	}

	public void _787CFA78CE4548CC()
	{
		_9B644D6B72B14318(_28EB422A207049DC);
		AE3DF9A31AFA44E4(_28EB422A207049DC);
		C9B3C96F922744A8(_28EB422A207049DC);
		B6D51A226F894F70(_28EB422A207049DC);
	}

	public void _65EB0EF1ED4B4823()
	{
		F1CDF96A36994B24(_207917117A0940F3);
		_69213C66A3584C26(_207917117A0940F3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _0598F4A5E1DD443D()
	{
		try
		{
			_65184107759743C4();
		}
		catch (Exception ex)
		{
			ILogger? val = _1DC5134FEF8147BE;
			if (val != null)
			{
				_04836BC3E9914ECF(val, ex, _003CModule_003E._3F57E81A62734AC2<string>(-1174678930), Array.Empty<object>());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void _1D51E2B36C7345F0()
	{
		_6D51944268D542DB = (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0;
		CancellationTokenSource? cancellationTokenSource = _3F0C7F57126F4A3D;
		if (cancellationTokenSource == null)
		{
			goto IL_00a1;
		}
		_8A71C51B3ED74906((object?)cancellationTokenSource);
		goto IL_0026;
		IL_002b:
		int num2;
		while (true)
		{
			int num = num2;
			uint num3;
			switch ((num3 = (uint)(-(-num - ((0x4D3221F3 ^ (-(-64412957 ^ 0x2180550D) + (~(~-2146644709) - -2025217563))) - ((--49826166 * -738217617) ^ -289497175))))) % 8)
			{
			case 6u:
				break;
			case 5u:
				goto IL_00a1;
			case 7u:
			{
				_631D551E2DA64E7D? cF47F3EE0E0C = CF47F3EE0E0C4452;
				if (cF47F3EE0E0C == null)
				{
					goto case 2u;
				}
				_3CEE6561B1334834((object?)cF47F3EE0E0C);
				num2 = -1370429190;
				continue;
			}
			case 4u:
			{
				_0D077240941749FA = null;
				ILogger? val = _1DC5134FEF8147BE;
				if (val == null)
				{
					goto default;
				}
				EAFA0985C99445A0(val, _003CModule_003E._58ECCB512F2A43AC<string>(-2120028065), Array.Empty<object>());
				num2 = 1391458184;
				continue;
			}
			case 3u:
				goto IL_010d;
			case 2u:
				_0098F6CD831D4367((Action<Exception?>?)_0089880B6BD64885);
				_4C759A73139B4C65 = null;
				num2 = 976057356;
				continue;
			case 1u:
			{
				CCF339C5456845F6? cCF339C5456845F = _6FB0679464DB4BF6;
				if (cCF339C5456845F == null)
				{
					goto case 7u;
				}
				_4B7222A917A74F3A((object?)cCF339C5456845F);
				num2 = 1141491943;
				continue;
			}
			default:
			{
				ILoggerProvider? bCA776D1DA7D4C8D = BCA776D1DA7D4C8D;
				if (bCA776D1DA7D4C8D != null)
				{
					_1FADC19882464927((object?)bCA776D1DA7D4C8D);
				}
				return;
			}
			}
			break;
		}
		goto IL_0026;
		IL_00a1:
		CancellationTokenSource? cancellationTokenSource2 = _3F0C7F57126F4A3D;
		if (cancellationTokenSource2 == null)
		{
			goto IL_010d;
		}
		((_1DB744298E9F4B09)(object)cancellationTokenSource2).FDDBE5A9870C4433();
		num2 = 1335752139;
		goto IL_002b;
		IL_0026:
		num2 = -2087187235;
		goto IL_002b;
		IL_010d:
		_3F0C7F57126F4A3D = null;
		_6EB2D3D9EC934A7A = (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
		num2 = 1912020809;
		goto IL_002b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void _47DCD11B55514AD5(ILoggingBuilder P_0)
	{
		D32755EB89534C20(P_0, (LogLevel)0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[AsyncStateMachine(typeof(_351058E3F6BE45AB))]
	[CompilerGenerated]
	private Task _41DFABF87E734B85()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[CompilerGenerated]
	private void _8F473EAD6D224968(Exception P_0)
	{
		if (!(P_0 is OperationCanceledException))
		{
			while (true)
			{
				int num = 1939706747;
				uint num2;
				switch ((num2 = (uint)(1760433491 - (~((num ^ (-450090509 ^ (unchecked(832601679 * ~unchecked(-1770379575 * (-1982040040 ^ -1008930765))) - ((((-1356314872 ^ 0x5EF17389) + unchecked(1543071691 * unchecked(784896069 * -1736269164))) ^ 0x627E92DE) + -((0xA88BFC8 ^ 0x789A589B) - (-318480890 + 2114629141)))))) + (-((-(347041792 - -395959135) ^ 0x29F02881) - (0x6B8232A3 ^ 0x25014DE0)) - (~(0xD8B938 ^ ~(-20402866)) ^ (-(-1788255023 ^ 0x513E543E) + (-2028886216 ^ -985936278) + -1224484007)))) + unchecked(unchecked(-666269914 * -1853696235) - unchecked(-1741115165 * 424848577) - 723933748 - (~-1512023594 + -474913212 + ~unchecked(-1586563780 * 600500309))) - unchecked((unchecked(1582753745 * 97562221) + (386276145 + 1039825468)) * 1345868557) - ~(490967879 + 961018206)) * -1177507163)) % 3)
				{
				case 0u:
					continue;
				case 1u:
				{
					string text = _003CModule_003E.F84FA79ABE6944BB<string>(710962335);
					_598232785CB54947(P_0, text);
					ILogger? val = _1DC5134FEF8147BE;
					if (val != null)
					{
						_04836BC3E9914ECF(val, P_0, text, Array.Empty<object>());
					}
					return;
				}
				}
				break;
			}
		}
		_5BF8A3AD47194A87(_43E41C5630994DE2((object?)_0D077240941749FA), _003CModule_003E._58ECCB512F2A43AC<int>(726423810));
		ILogger? val2 = _1DC5134FEF8147BE;
		if (val2 != null)
		{
			EAFA0985C99445A0(val2, _003CModule_003E.F84FA79ABE6944BB<string>(-138965954), Array.Empty<object>());
		}
	}

	static string? B9B9A626BBC7429B(string? P_0, string? P_1)
	{
		return Path.Combine(P_0, P_1);
	}

	static string? _928653F3A4454D31()
	{
		return AppContext.BaseDirectory;
	}

	static object? _2112E077830844B3(string? P_0)
	{
		return new InvalidOperationException(P_0);
	}

	static object? EA81BBC9E7D0400D()
	{
		return new CancellationTokenSource();
	}

	static CancellationToken F8A3CF4A67D54C6D(object? P_0)
	{
		return ((CancellationTokenSource)P_0).Token;
	}

	static object? _3D696BA9F00C470B()
	{
		return new _85399D7C08B94D76();
	}

	static bool F031E510C0F041FA(string? P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static object? FAD3946C8B944D1B(object? P_0)
	{
		return ((_85399D7C08B94D76)P_0)._2A2378566E004678();
	}

	static object? _3075671EE01544C0(object? P_0, string? P_1)
	{
		return ((_85399D7C08B94D76)P_0)._66692E0EB4194A0C(P_1);
	}

	static object? D5CC566DA47C417F(Action<ILoggingBuilder?>? P_0)
	{
		return LoggerFactory.Create(P_0);
	}

	static void _1FADC19882464927(object? P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static bool BD620D3B5B0A4F53()
	{
		return _8BAADFBB2FC94256._4D7D3847E27541AE();
	}

	static object? _9702120A8A8F45D7()
	{
		return new _8BAADFBB2FC94256();
	}

	static object? _7487341A38F448A5()
	{
		return new _32B70545407A49EE();
	}

	static string? B8F7ECA57C2C43F5(object? P_0)
	{
		return ((_4C6B03DD3A6441ED)P_0)._97EA0C4EF61E4063();
	}

	static string? _8F379F39440645F9(string? P_0, string? P_1)
	{
		return P_0 + P_1;
	}

	static void EAFA0985C99445A0(ILogger? P_0, string? P_1, object?[]? P_2)
	{
		LoggerExtensions.LogInformation(P_0, P_1, P_2);
	}

	static object? _1FFD4A5BF5284978(string? P_0)
	{
		return new ArgumentNullException(P_0);
	}

	static object? E930E30A231F4C24(string? P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object?)new Harmony(P_0);
	}

	static void _5417602C4BFF4476(Harmony? P_0)
	{
		_760EF57D5259421C._6A6338E1C67E4A8A(P_0);
	}

	static void _1AB4CBCB93AE4A83(ILogger? P_0)
	{
		_760EF57D5259421C._0156EA932C6D485A(P_0);
	}

	static void _46D194BA19F54B57(_1DB744298E9F4B09? P_0)
	{
		_760EF57D5259421C._83DE41A124B84DAB(P_0);
	}

	static void _0ED85A0D846D423A(_4C6B03DD3A6441ED? P_0)
	{
		_760EF57D5259421C.B949AE3E30274831(P_0);
	}

	static void _12471EE31BBA4E57(ILogger? P_0)
	{
		C179263454B44BF6.D564979FFCBF4384(P_0);
	}

	static void CF7AAABC37044570(_1DB744298E9F4B09? P_0)
	{
		C179263454B44BF6._4D4A1A44ECE34F07(P_0);
	}

	static string? CD7429A561324652(object? P_0)
	{
		return ((_1DB744298E9F4B09)P_0).EBFF406DCE4B4FB2;
	}

	static void _407F0B1CB1664556(string? P_0)
	{
		C179263454B44BF6.C5E5F044ECAC48BA(P_0);
	}

	static void _001FECFDE5E04166(_4C6B03DD3A6441ED? P_0)
	{
		FB9603B015784B9C.C365C9AF59A94C5E(P_0);
	}

	static void BC43F9F78A0F4833(ILogger? P_0)
	{
		FB9603B015784B9C._0C0B9C154FB64D1E(P_0);
	}

	static void _4BEDACD4AC924E15(_1DB744298E9F4B09? P_0)
	{
		FB9603B015784B9C.A5E12B576C864511(P_0);
	}

	static object? _75BED042033248A3(object? P_0)
	{
		return new _02C54685DE0E4B81((ILogger)P_0);
	}

	static bool FF6A8097C8474BC4()
	{
		return PlayerLoopHelper.IsInjectedUniTaskPlayerLoop();
	}

	static object? _08D958B930D443EB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object? _80D7F4281FD5494F(object? P_0, string? P_1, BindingFlags P_2)
	{
		return ((Type)P_0).GetField(P_1, P_2);
	}

	static object? E73073B4F7264BA1(string? P_0)
	{
		return new Exception(P_0);
	}

	static object? _2329A64F30024A49()
	{
		return SynchronizationContext.Current;
	}

	static void _4632CE99A2EE4D98(object? P_0, object? P_1, object? P_2)
	{
		((FieldInfo)P_0).SetValue(P_1, P_2);
	}

	static object? _01B722A967B642C6()
	{
		return Thread.CurrentThread;
	}

	static int _3B3CF6E9B6C94F08(object? P_0)
	{
		return ((Thread)P_0).ManagedThreadId;
	}

	static PlayerLoopSystem _2C8446EA5F1243E8()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return PlayerLoop.GetCurrentPlayerLoop();
	}

	static void DB99B16D9EFB4F44(ref PlayerLoopSystem P_0, InjectPlayerLoopTimings P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		PlayerLoopHelper.Initialize(ref P_0, P_1);
	}

	static void _7D7B108555E24AD4(Action<Exception?>? P_0)
	{
		UniTaskScheduler.UnobservedTaskException += P_0;
	}

	static object? B5EDA2F4B9744EB3()
	{
		return Assembly.GetExecutingAssembly();
	}

	static object? E8A1BBE3FF6D405E(object? P_0, bool P_1)
	{
		return new StackTrace((Exception)P_0, P_1);
	}

	static int _77570C2EA5634BEE(object? P_0)
	{
		return ((StackTrace)P_0).FrameCount;
	}

	static StackFrame?[]? _66D23BCC50794326(object? P_0)
	{
		return ((StackTrace)P_0).GetFrames();
	}

	static bool _221617961E494D2D(StackFrame? P_0)
	{
		return P_0.HasMethod();
	}

	static object? _0B1227EB3A824F28(object? P_0)
	{
		return ((StackFrame)P_0).GetMethod();
	}

	static object? _99B9B690FC8F4F54(object? P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	static bool _4D16230D059E4F12(Type? P_0, Type? P_1)
	{
		return P_0 != P_1;
	}

	static object? _4AA0B6CB62334AA1(object? P_0)
	{
		return ((Type)P_0).Assembly;
	}

	static bool _900528C3C94D4EB9(Assembly? P_0, Assembly? P_1)
	{
		return P_0 == P_1;
	}

	static void _04836BC3E9914ECF(ILogger? P_0, Exception? P_1, string? P_2, object?[]? P_3)
	{
		LoggerExtensions.LogError(P_0, P_1, P_2, P_3);
	}

	static object? _602204D3EAB54978()
	{
		return AppDomain.CurrentDomain;
	}

	static Assembly?[]? C1294F0A5D8D438A(object? P_0)
	{
		return ((AppDomain)P_0).GetAssemblies();
	}

	static object? _0BDC346A9B654476(object? P_0)
	{
		return ((Assembly)P_0).GetName();
	}

	static string? _4CF5126EEB2E4F86(object? P_0)
	{
		return ((AssemblyName)P_0).Name;
	}

	static bool _2BB3781EEB3A40ED(object? P_0, string? P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals(P_1, P_2);
	}

	static void D295963FF71444B7(ILogger? P_0, string? P_1, object?[]? P_2)
	{
		LoggerExtensions.LogError(P_0, P_1, P_2);
	}

	static void _292A1432976B4A8A()
	{
		Provider.shutdown();
	}

	static object? _74776E9056D94426()
	{
		return Process.GetCurrentProcess();
	}

	static void _302B6840F2674835(object? P_0)
	{
		((Process)P_0).Kill();
	}

	static void _4E9CE07947DE4E03(int P_0)
	{
		Environment.Exit(P_0);
	}

	static void _5E70AF3660A442D8(object? P_0)
	{
		((_1DB744298E9F4B09)P_0)._0598F4A5E1DD443D();
	}

	static void _134AEE2E797D4022(object? P_0)
	{
		((_1DB744298E9F4B09)P_0)._1D51E2B36C7345F0();
	}

	static CancellationToken F86B2FD60D0D4000(object? P_0)
	{
		return ((_1DB744298E9F4B09)P_0).A70B1408B5ED4F4E;
	}

	static void _8519B7AF8EFB4000(string? P_0, Func<Task?>? P_1, CancellationToken? P_2, Action<Exception?>? P_3)
	{
		_1FFBEDFB3FCE4374._533FDA357CCF49A3(P_0, P_1, P_2, P_3);
	}

	static object? _118BC2EF420749BD(string? P_0)
	{
		return _9E6941D2442741AE.DF274E6B0CD241BF(P_0);
	}

	static object? _76E110F82D444CD6(string? P_0)
	{
		return new _1C1340EEE9C744F4(P_0);
	}

	static void D72B79A4C8314ED0(object? P_0)
	{
		((_1DB744298E9F4B09)P_0)._787CFA78CE4548CC();
	}

	static void _87340CA8A935414D(object? P_0)
	{
		((_1DB744298E9F4B09)P_0)._65EB0EF1ED4B4823();
	}

	static void _0DC9F1E24BAC45AD(object? P_0)
	{
		((CCF339C5456845F6)P_0)._062A95E296D640E5();
	}

	static void _5115F37B0C424E89(IConfiguration? P_0)
	{
		_2A320E2F1A3D4AAC._54D7989141C24A59(P_0);
	}

	static void BAF961CF365D4B81(object? P_0)
	{
		((E651E17AA2CA4BC8)P_0).F08FFF64C62C4F0A();
	}

	static void _8999EFDDB7264684(object? P_0, string? P_1)
	{
		((EE0FD11A7E47463C)P_0).F9E4652CF76D4829(P_1);
	}

	static void DB6EB265DF784F3B(ILogger? P_0, string? P_1, object?[]? P_2)
	{
		LoggerExtensions.LogDebug(P_0, P_1, P_2);
	}

	static object? DA796AAF45954313()
	{
		return new _631D551E2DA64E7D();
	}

	static object? _16C61215B89E427B()
	{
		return new CCF339C5456845F6();
	}

	static void _85EB28639CB34AC1(object? P_0)
	{
		((_631D551E2DA64E7D)P_0)._076B9F9FEED14014();
	}

	static void _52AF56F70AAA454D(object? P_0)
	{
		((CCF339C5456845F6)P_0).BCBC58880D9A4AC5();
	}

	static void _0E9912E29BCC4087()
	{
		FA614F32E31A4FDD._2F2E47BE5BFE404B();
	}

	static object? FC4B299082CA47F9(object? P_0, string? P_1)
	{
		return ((A19CBF069C964833)P_0)._99A93C8FCF084453(P_1);
	}

	static void _639288DA3BB5493D(object? P_0)
	{
		Console.WriteLine(P_0);
	}

	static void _9B644D6B72B14318(IConfiguration? P_0)
	{
		_760EF57D5259421C._083905F6BFEF4847(P_0);
	}

	static void AE3DF9A31AFA44E4(IConfiguration? P_0)
	{
		C179263454B44BF6._7EB96C896BBA42AF(P_0);
	}

	static void C9B3C96F922744A8(IConfiguration? P_0)
	{
		FB9603B015784B9C.E441851EB0AF4F90(P_0);
	}

	static void B6D51A226F894F70(IConfiguration? P_0)
	{
		_087B17044C8447C2._860B6225B78349C7(P_0);
	}

	static void A128D57D14014AE1(IStringLocalizer? P_0)
	{
		_760EF57D5259421C.CC5DAD41DAF64E48(P_0);
	}

	static void F1CDF96A36994B24(IStringLocalizer? P_0)
	{
		C179263454B44BF6.EA2AAE067CD54A44(P_0);
	}

	static void _69213C66A3584C26(IStringLocalizer? P_0)
	{
		FB9603B015784B9C._1CFDE3629C694B0C(P_0);
	}

	static void _8A71C51B3ED74906(object? P_0)
	{
		((CancellationTokenSource)P_0).Cancel();
	}

	void FDDBE5A9870C4433()
	{
		((CancellationTokenSource)this).Dispose();
	}

	static void _4B7222A917A74F3A(object? P_0)
	{
		((CCF339C5456845F6)P_0).A51EEBF78F8241D7();
	}

	static void _3CEE6561B1334834(object? P_0)
	{
		((_631D551E2DA64E7D)P_0)._16FA91F7ADD14444();
	}

	static void _0098F6CD831D4367(Action<Exception?>? P_0)
	{
		UniTaskScheduler.UnobservedTaskException -= P_0;
	}

	static object? D32755EB89534C20(ILoggingBuilder? P_0, LogLevel P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return LoggingBuilderExtensions.SetMinimumLevel(P_0, P_1);
	}

	static object? _19F0C3FCC92C461A(ILoggingBuilder? P_0, ILoggerProvider? P_1)
	{
		return LoggingBuilderExtensions.AddProvider(P_0, P_1);
	}

	static void _598232785CB54947(Exception? P_0, string? P_1)
	{
		UnturnedLog.exception(P_0, P_1);
	}

	static object? _43E41C5630994DE2(object? P_0)
	{
		return ((_02C54685DE0E4B81)P_0).B76672FFD39D4ACA();
	}

	static bool _5BF8A3AD47194A87(object? P_0, int P_1)
	{
		return ((Task)P_0).Wait(P_1);
	}
}
