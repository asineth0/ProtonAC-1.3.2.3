using System;
using System.Runtime.CompilerServices;

internal class _365B9A5C91614F23
{
	[CompilerGenerated]
	private readonly _652C34B1E6554F10 F75E84E57BD742BE;

	[CompilerGenerated]
	private readonly DateTime _0050CCFBAD704D06;

	[CompilerGenerated]
	private readonly DateTime B45036A2136B478E;

	public _652C34B1E6554F10 _2D636DB4F07744B8
	{
		[CompilerGenerated]
		get
		{
			return F75E84E57BD742BE;
		}
	}

	public DateTime _0E1C8BFB9AD2476C
	{
		[CompilerGenerated]
		get
		{
			return _0050CCFBAD704D06;
		}
	}

	public DateTime _03519B3707694622
	{
		[CompilerGenerated]
		get
		{
			return B45036A2136B478E;
		}
	}

	public bool DDD5694FE0D84D69 => DateTime.UtcNow > _5BFFD2A281FC4F41((object)this);

	public _365B9A5C91614F23(_652C34B1E6554F10 P_0, TimeSpan P_1)
	{
		F75E84E57BD742BE = P_0;
		_0050CCFBAD704D06 = DateTime.UtcNow;
		B45036A2136B478E = _2C78D38DE0C44492((object)this).Add(P_1);
	}

	static DateTime _2C78D38DE0C44492(object P_0)
	{
		return ((_365B9A5C91614F23)P_0)._0E1C8BFB9AD2476C;
	}

	static DateTime _5BFFD2A281FC4F41(object P_0)
	{
		return ((_365B9A5C91614F23)P_0)._03519B3707694622;
	}
}
