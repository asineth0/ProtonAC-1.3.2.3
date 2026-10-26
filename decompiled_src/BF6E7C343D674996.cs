using System.IO;
using System.Runtime.CompilerServices;

internal class BF6E7C343D674996 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string A198A5095F514C74;

	public string _70B6D03CA00D47DA
	{
		[CompilerGenerated]
		get
		{
			return A198A5095F514C74;
		}
		[CompilerGenerated]
		set
		{
			A198A5095F514C74 = a198A5095F514C;
		}
	}

	public BF6E7C343D674996()
	{
	}

	public BF6E7C343D674996(string P_0)
	{
		_652C34B1E6554F10._6002889CC5D04ED9((object)this);
		_39CA9E37AD6D40C0((object)this);
	}

	public virtual void _89DB0CC8B2914726(BinaryWriter P_0)
	{
		_39CA9E37AD6D40C0((object)this);
		_39CA9E37AD6D40C0((object)P_0);
	}

	public virtual void _606161BF5C084F34(BinaryReader P_0)
	{
		_09AE90E843FB42BD((object)this, _39CA9E37AD6D40C0((object)P_0));
	}

	static void _09AE90E843FB42BD(object P_0, string P_1)
	{
		((BF6E7C343D674996)P_0)._70B6D03CA00D47DA = P_1;
	}

	static string A95396B08A28420F(object P_0)
	{
		return ((BF6E7C343D674996)P_0)._70B6D03CA00D47DA;
	}

	static void _1C9E4B59AF0044D1(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _39CA9E37AD6D40C0(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
