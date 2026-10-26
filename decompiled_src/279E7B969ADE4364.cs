using System.IO;
using System.Runtime.CompilerServices;

internal class _279E7B969ADE4364 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string C1C24DA435744D2E;

	public string A4059C637B884972
	{
		[CompilerGenerated]
		get
		{
			return C1C24DA435744D2E;
		}
		[CompilerGenerated]
		set
		{
			C1C24DA435744D2E = c1C24DA435744D2E;
		}
	}

	public _279E7B969ADE4364()
	{
	}

	public _279E7B969ADE4364(string P_0)
	{
		_652C34B1E6554F10._6002889CC5D04ED9((object)this);
		E9F01515046A4C6E((object)this);
	}

	public virtual void _74EE893E2DA248F7(BinaryWriter P_0)
	{
		E9F01515046A4C6E((object)this);
		E9F01515046A4C6E((object)P_0);
	}

	public virtual void DBD9363BF0FD4E9B(BinaryReader P_0)
	{
		_3240BB38AB02499F((object)this, E9F01515046A4C6E((object)P_0));
	}

	static void _3240BB38AB02499F(object P_0, string P_1)
	{
		((_279E7B969ADE4364)P_0).A4059C637B884972 = P_1;
	}

	static string _6EDDE25C2AC64462(object P_0)
	{
		return ((_279E7B969ADE4364)P_0).A4059C637B884972;
	}

	static void _21D4351206734967(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string E9F01515046A4C6E(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}
}
