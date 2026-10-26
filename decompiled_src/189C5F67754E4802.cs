using System.IO;
using System.Runtime.CompilerServices;

internal class _189C5F67754E4802 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string _1DB6E51DEB0C4BDE;

	[CompilerGenerated]
	private string _71A4F40760804ADF;

	public string _9A35F3E389974B29
	{
		[CompilerGenerated]
		get
		{
			return _1DB6E51DEB0C4BDE;
		}
		[CompilerGenerated]
		set
		{
			_1DB6E51DEB0C4BDE = text;
		}
	}

	public string _866C9427894F418F
	{
		[CompilerGenerated]
		get
		{
			return _71A4F40760804ADF;
		}
		[CompilerGenerated]
		set
		{
			_71A4F40760804ADF = text;
		}
	}

	public _189C5F67754E4802()
	{
	}

	public _189C5F67754E4802(string P_0, string P_1)
	{
		_67CBE2E046724D46((object)this, P_0);
		_061D50F81D444629((object)this, P_1);
	}

	public virtual void F8BD7E613427472E(BinaryWriter P_0)
	{
		_4434D241B86046D6((object)P_0, _6BEBA4FEC90F4118((object)this));
		_4434D241B86046D6((object)P_0, DFAB354E25C345D1((object)this));
	}

	public virtual void BF9A020687FE4014(BinaryReader P_0)
	{
		_67CBE2E046724D46((object)this, _3EC5D0AD358242EE((object)P_0));
		_061D50F81D444629((object)this, _3EC5D0AD358242EE((object)P_0));
	}

	static void _67CBE2E046724D46(object P_0, string P_1)
	{
		((_189C5F67754E4802)P_0)._9A35F3E389974B29 = P_1;
	}

	static void _061D50F81D444629(object P_0, string P_1)
	{
		((_189C5F67754E4802)P_0)._866C9427894F418F = P_1;
	}

	static string _6BEBA4FEC90F4118(object P_0)
	{
		return ((_189C5F67754E4802)P_0)._9A35F3E389974B29;
	}

	static void _4434D241B86046D6(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string DFAB354E25C345D1(object P_0)
	{
		return ((_189C5F67754E4802)P_0)._866C9427894F418F;
	}

	static string _3EC5D0AD358242EE(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
