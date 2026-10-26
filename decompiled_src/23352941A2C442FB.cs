using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class _23352941A2C442FB : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid _82339FE0C5344B29;

	[CompilerGenerated]
	private ushort _27F57F9405924E74;

	public Guid _0C12449A62C548C8
	{
		[CompilerGenerated]
		get
		{
			return _82339FE0C5344B29;
		}
		[CompilerGenerated]
		set
		{
			_82339FE0C5344B29 = guid;
		}
	}

	public ushort _959432D0090B4253
	{
		[CompilerGenerated]
		get
		{
			return _27F57F9405924E74;
		}
		[CompilerGenerated]
		set
		{
			_27F57F9405924E74 = num;
		}
	}

	public _23352941A2C442FB()
	{
	}

	public _23352941A2C442FB(Guid P_0, ushort P_1)
	{
		_652C34B1E6554F10._6002889CC5D04ED9((object)this);
		_237EE3B7B4C74DC2((object)this);
		_237EE3B7B4C74DC2((object)this);
	}

	public virtual void CE90A380627A4E87(BinaryWriter P_0)
	{
		_237EE3B7B4C74DC2((object)this);
		_237EE3B7B4C74DC2((object)P_0);
		_237EE3B7B4C74DC2((object)this);
		_237EE3B7B4C74DC2((object)P_0);
	}

	public virtual void _19073F8FA72F4CA7(BinaryReader P_0)
	{
		FF78C43EB8534B6F((object)this, Guid.Parse(_71F6C053E0924DE7((object)P_0)));
		C2A444AEDA7B4277((object)this, _237EE3B7B4C74DC2((object)P_0));
	}

	static void FF78C43EB8534B6F(object P_0, Guid P_1)
	{
		((_23352941A2C442FB)P_0)._0C12449A62C548C8 = P_1;
	}

	static void C2A444AEDA7B4277(object P_0, ushort P_1)
	{
		((_23352941A2C442FB)P_0)._959432D0090B4253 = P_1;
	}

	static Guid F1730FD7AD5E47D3(object P_0)
	{
		return ((_23352941A2C442FB)P_0)._0C12449A62C548C8;
	}

	static void _510B5F121E734AE9(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static ushort _4F40992735A04684(object P_0)
	{
		return ((_23352941A2C442FB)P_0)._959432D0090B4253;
	}

	static void _9E2B6AC18A584081(object P_0, ushort P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _71F6C053E0924DE7(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static ushort _237EE3B7B4C74DC2(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}
}
