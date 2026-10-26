using System.IO;
using System.Runtime.CompilerServices;

internal class D08691711E724502 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string _653B6A9FA3DA488B;

	[CompilerGenerated]
	private ulong _43334FCFD84D4ABD;

	public string _107908C557794813
	{
		[CompilerGenerated]
		get
		{
			return _653B6A9FA3DA488B;
		}
		[CompilerGenerated]
		set
		{
			_653B6A9FA3DA488B = text;
		}
	}

	public ulong _392F2945CA144A30
	{
		[CompilerGenerated]
		get
		{
			return _43334FCFD84D4ABD;
		}
		[CompilerGenerated]
		set
		{
			_43334FCFD84D4ABD = num;
		}
	}

	public D08691711E724502()
	{
	}

	public D08691711E724502(string P_0, ulong P_1)
	{
		_262021B7B8B54F31((object)this, P_0);
		_9C08CEADDAEA467C((object)this, P_1);
	}

	public virtual void _933ABE2A887347B4(BinaryWriter P_0)
	{
		F4D7396985E64BA0((object)P_0, EE0816F04BD0449F((object)this));
		_9AD7A77AF7EB4008((object)P_0, F65D9DFC67CF460F((object)this));
	}

	public virtual void EEC75A5CCC3D4C6A(BinaryReader P_0)
	{
		_262021B7B8B54F31((object)this, _701CA663E4514B9F((object)P_0));
		_9C08CEADDAEA467C((object)this, _94FB8BF85CB843F8((object)P_0));
	}

	static void _262021B7B8B54F31(object P_0, string P_1)
	{
		((D08691711E724502)P_0)._107908C557794813 = P_1;
	}

	static void _9C08CEADDAEA467C(object P_0, ulong P_1)
	{
		((D08691711E724502)P_0)._392F2945CA144A30 = P_1;
	}

	static string EE0816F04BD0449F(object P_0)
	{
		return ((D08691711E724502)P_0)._107908C557794813;
	}

	static void F4D7396985E64BA0(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static ulong F65D9DFC67CF460F(object P_0)
	{
		return ((D08691711E724502)P_0)._392F2945CA144A30;
	}

	static void _9AD7A77AF7EB4008(object P_0, ulong P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _701CA663E4514B9F(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static ulong _94FB8BF85CB843F8(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt64();
	}
}
