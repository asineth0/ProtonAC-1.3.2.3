using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class FCB65C9404154539 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private Guid _33CF7E9F6CFE4A23;

	[CompilerGenerated]
	private string C796B2F1E66B4993;

	public Guid _8282F9168AAC468A
	{
		[CompilerGenerated]
		get
		{
			return _33CF7E9F6CFE4A23;
		}
		[CompilerGenerated]
		set
		{
			_33CF7E9F6CFE4A23 = guid;
		}
	}

	public string _7A96A8D04C36498D
	{
		[CompilerGenerated]
		get
		{
			return C796B2F1E66B4993;
		}
		[CompilerGenerated]
		set
		{
			C796B2F1E66B4993 = c796B2F1E66B;
		}
	}

	public FCB65C9404154539()
	{
	}

	public FCB65C9404154539(Guid P_0, string P_1)
	{
		F1C06FBC0FC44AE4((object)this, P_0);
		_7029E16D54AE4401((object)this, P_1);
	}

	public virtual void B603165290644312(BinaryWriter P_0)
	{
		_47B7974C3AF24B3F((object)P_0, DE6DD16B737F4073((object)this).ToString());
		_47B7974C3AF24B3F((object)P_0, E08CE38EF86647B4((object)this));
	}

	public virtual void _3A0741F791BF4EE3(BinaryReader P_0)
	{
		F1C06FBC0FC44AE4((object)this, Guid.Parse(A32897FA9EF0430E((object)P_0)));
		_7029E16D54AE4401((object)this, A32897FA9EF0430E((object)P_0));
	}

	static void F1C06FBC0FC44AE4(object P_0, Guid P_1)
	{
		((FCB65C9404154539)P_0)._8282F9168AAC468A = P_1;
	}

	static void _7029E16D54AE4401(object P_0, string P_1)
	{
		((FCB65C9404154539)P_0)._7A96A8D04C36498D = P_1;
	}

	static Guid DE6DD16B737F4073(object P_0)
	{
		return ((FCB65C9404154539)P_0)._8282F9168AAC468A;
	}

	static void _47B7974C3AF24B3F(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string E08CE38EF86647B4(object P_0)
	{
		return ((FCB65C9404154539)P_0)._7A96A8D04C36498D;
	}

	static string A32897FA9EF0430E(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
