using System;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;

public abstract class C179263454B44BF6 : _03BCC9520C564E55, IDisposable
{
	[CompilerGenerated]
	private static IConfiguration ED5F40D0D9634D75;

	[CompilerGenerated]
	private static ILogger _4635CE9232604427;

	[CompilerGenerated]
	private static IStringLocalizer _028363659EA84861;

	[CompilerGenerated]
	private static _1DB744298E9F4B09 _5402890ECAB54BA0;

	[CompilerGenerated]
	private static string F2D281EFF7E04B75;

	protected static IConfiguration F4734FD3602D47CD
	{
		[CompilerGenerated]
		get
		{
			return ED5F40D0D9634D75;
		}
		[CompilerGenerated]
		private set
		{
			ED5F40D0D9634D75 = eD5F40D0D9634D;
		}
	}

	protected static ILogger _54DF173DA5E74DC3
	{
		[CompilerGenerated]
		get
		{
			return _4635CE9232604427;
		}
		[CompilerGenerated]
		private set
		{
			_4635CE9232604427 = val;
		}
	}

	protected static IStringLocalizer _66EFCEB30AD8408A
	{
		[CompilerGenerated]
		get
		{
			return _028363659EA84861;
		}
		[CompilerGenerated]
		private set
		{
			_028363659EA84861 = val;
		}
	}

	protected static _1DB744298E9F4B09 _472BF0669F5B458A
	{
		[CompilerGenerated]
		get
		{
			return _5402890ECAB54BA0;
		}
		[CompilerGenerated]
		private set
		{
			_5402890ECAB54BA0 = obj;
		}
	}

	protected static string _0FA3DB979E2D48E0
	{
		[CompilerGenerated]
		get
		{
			return F2D281EFF7E04B75;
		}
		[CompilerGenerated]
		private set
		{
			F2D281EFF7E04B75 = f2D281EFF7E04B;
		}
	}

	internal static void _7EB96C896BBA42AF(IConfiguration P_0)
	{
		F4734FD3602D47CD = P_0;
	}

	internal static void D564979FFCBF4384(ILogger P_0)
	{
		_54DF173DA5E74DC3 = P_0;
	}

	internal static void EA2AAE067CD54A44(IStringLocalizer P_0)
	{
		_66EFCEB30AD8408A = P_0;
	}

	internal static void _4D4A1A44ECE34F07(_1DB744298E9F4B09 P_0)
	{
		_472BF0669F5B458A = P_0;
	}

	internal static void C5E5F044ECAC48BA(string P_0)
	{
		_0FA3DB979E2D48E0 = P_0;
	}

	public virtual void Dispose()
	{
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}
}
