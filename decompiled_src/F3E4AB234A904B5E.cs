using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class F3E4AB234A904B5E : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid B7451F122A1643DF;

	[CompilerGenerated]
	private string E49E188AD5654EFF;

	[CompilerGenerated]
	private bool _81A0CE12BAA94F5F;

	public Guid C98DC9ED035F430C
	{
		[CompilerGenerated]
		get
		{
			return B7451F122A1643DF;
		}
		[CompilerGenerated]
		set
		{
			B7451F122A1643DF = b7451F122A1643DF;
		}
	}

	public string A3197CF3088A49FB
	{
		[CompilerGenerated]
		get
		{
			return E49E188AD5654EFF;
		}
		[CompilerGenerated]
		set
		{
			E49E188AD5654EFF = e49E188AD5654EFF;
		}
	}

	public bool _5BC77EB4C1E04BAA
	{
		[CompilerGenerated]
		get
		{
			return _81A0CE12BAA94F5F;
		}
		[CompilerGenerated]
		set
		{
			_81A0CE12BAA94F5F = flag;
		}
	}

	public F3E4AB234A904B5E()
	{
	}

	public F3E4AB234A904B5E(Guid P_0, string P_1, bool P_2)
	{
		_84107EBEF79B453A((object)this, P_0);
		EEB94D1F8E714634((object)this, P_1);
		B841EF3E0C624FAB((object)this, P_2);
	}

	public virtual void _1A94126426234368(BinaryWriter P_0)
	{
		FFBB134CD13A4F01((object)P_0, E2ABD095DC8D47DB((object)this).ToString());
		FFBB134CD13A4F01((object)P_0, _7C706FD80E9F46EC((object)this));
		E67C66C2E03A4A41((object)P_0, _9686E532FE5F4393((object)this));
	}

	public virtual void _0E4F037D91B64E97(BinaryReader P_0)
	{
		_8DC26180EB194243((object)P_0);
		_8DC26180EB194243((object)this);
		_8DC26180EB194243((object)P_0);
		_8DC26180EB194243((object)this);
		_8DC26180EB194243((object)P_0);
		_8DC26180EB194243((object)this);
	}

	static void _84107EBEF79B453A(object P_0, Guid P_1)
	{
		((F3E4AB234A904B5E)P_0).C98DC9ED035F430C = P_1;
	}

	static void EEB94D1F8E714634(object P_0, string P_1)
	{
		((F3E4AB234A904B5E)P_0).A3197CF3088A49FB = P_1;
	}

	static void B841EF3E0C624FAB(object P_0, bool P_1)
	{
		((F3E4AB234A904B5E)P_0)._5BC77EB4C1E04BAA = P_1;
	}

	static Guid E2ABD095DC8D47DB(object P_0)
	{
		return ((F3E4AB234A904B5E)P_0).C98DC9ED035F430C;
	}

	static void FFBB134CD13A4F01(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _7C706FD80E9F46EC(object P_0)
	{
		return ((F3E4AB234A904B5E)P_0).A3197CF3088A49FB;
	}

	static bool _9686E532FE5F4393(object P_0)
	{
		return ((F3E4AB234A904B5E)P_0)._5BC77EB4C1E04BAA;
	}

	static void E67C66C2E03A4A41(object P_0, bool P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string FE7C6D65E6F74C62(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static bool _8DC26180EB194243(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}
}
