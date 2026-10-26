using System;
using System.Runtime.CompilerServices;
using System.Text;
using Cysharp.Threading.Tasks;
using Microsoft.Extensions.Logging;

public class _3DBA106924E9431F(string P_0, Channel<_3DBA106924E9431F._0CAF5A99CBFA42D0> P_1) : ILogger
{
	private class _29C28F917E01495E : IDisposable
	{
		public static readonly _29C28F917E01495E C94030D641B8468C = (_29C28F917E01495E)_72668A503CA64984();

		public void Dispose()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}

		static object _72668A503CA64984()
		{
			return new _29C28F917E01495E();
		}
	}

	public struct _0CAF5A99CBFA42D0
	{
		public string _83CD62B9FB2F4BE2;

		public LogLevel _962F43E32B234CA8;

		public string _8ACEB1070CB04B02;

		public string AB223F2DB14E4197;

		public unsafe _0CAF5A99CBFA42D0(string P_0, LogLevel P_1, string P_2, string P_3)
		{
			//IL_0006: Expected Obj, but got Ref
			((ValueType)Unsafe.AsPointer(ref this))._002Ector();
			_8ACEB1070CB04B02 = P_0;
			AB223F2DB14E4197 = P_0;
		}
	}

	private readonly string E92DF30EE2AE4F00 = P_0;

	private readonly ChannelWriter<_0CAF5A99CBFA42D0> AC1AEE83E82F4A7F = null;

	internal static readonly object D1F96DBDE71441A7 = _8745A881C2E64700();

	public IDisposable BeginScope<TState>(TState state)
	{
		return _29C28F917E01495E.C94030D641B8468C;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool IsEnabled(LogLevel logLevel)
	{
		_003CModule_003E._3F57E81A62734AC2<string>(887139723);
		_003CModule_003E._3F57E81A62734AC2<string>(-658048563);
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		if (!_396F0EDCBB984B54(logLevel))
		{
			goto IL_000c;
		}
		goto IL_0165;
		IL_000c:
		int num = 1576118244;
		goto IL_0011;
		IL_0011:
		StringBuilder stringBuilder = default;
		while (true)
		{
			int num2 = num;
			uint num3;
			switch ((num3 = (uint)(1824538091 - (-(-(unchecked(304138901 * 1290892873) - unchecked(-2099272446 - 600679210) - unchecked(-398941213 * (465726695 + 559202556))) - (unchecked(2004075283 * ((-248190905 ^ 0x29613B79) + ~-1952071480)) - unchecked(unchecked(1489997683 * unchecked(6244951 * 1267617325)) - unchecked((-1138937786 - -748818841) * 736951285))) - (num2 * -817651989 + -1133819925 * -(-1899463753 - -(~unchecked(-1213631934 - 1175831522))))) ^ -(unchecked(-1177694347 * -788220066) + ~-908649942)) * 1745483339 * 603089331)) % 8)
			{
			case 3u:
				break;
			default:
				return;
			case 1u:
				return;
			case 0u:
				AC1AEE83E82F4A7F.TryWrite(new _0CAF5A99CBFA42D0(DateTime.Now.ToString(_003CModule_003E._8B9C7B12B1AE4949<string>(665347616)), logLevel, E92DF30EE2AE4F00, F15145566D0B4C0E((object)stringBuilder)));
				num = -997686565;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (exception != null)
				{
					num4 = -692318592;
					num5 = num4;
				}
				else
				{
					num4 = 1205433833;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 1134018314);
				continue;
			}
			case 6u:
				goto IL_0165;
			case 7u:
				CA77A80751744432((object)stringBuilder, (object)exception);
				num = ((int)num3 * -1654702986) ^ -1597518533;
				continue;
			case 5u:
				BC4608998BEA4D7A((object)stringBuilder);
				num = ((int)num3 * -713146101) ^ -1831184011;
				continue;
			case 2u:
				return;
			}
			break;
		}
		goto IL_000c;
		IL_0165:
		stringBuilder = (StringBuilder)_43C30D19306649AA();
		_0D0175549B274F9F((object)stringBuilder, formatter(state, exception));
		num = -1264802163;
		goto IL_0011;
	}

	bool _396F0EDCBB984B54(LogLevel P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return IsEnabled(P_0);
	}

	static object _43C30D19306649AA()
	{
		return new StringBuilder();
	}

	static object _0D0175549B274F9F(object P_0, string P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	static object BC4608998BEA4D7A(object P_0)
	{
		return ((StringBuilder)P_0).AppendLine();
	}

	static object CA77A80751744432(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	static string F15145566D0B4C0E(object P_0)
	{
		return P_0.ToString();
	}

	static object _8745A881C2E64700()
	{
		return new object();
	}
}
