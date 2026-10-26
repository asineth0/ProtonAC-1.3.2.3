using System.IO;
using System.Runtime.CompilerServices;

internal class A58BA203630149A8 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string A55F30D1664A4961;

	[CompilerGenerated]
	private string _8E95764C11B5434D;

	[CompilerGenerated]
	private byte _6C82615EC8374146;

	public string _00ECE3BD20C142E6
	{
		[CompilerGenerated]
		get
		{
			return A55F30D1664A4961;
		}
		[CompilerGenerated]
		set
		{
			A55F30D1664A4961 = a55F30D1664A;
		}
	}

	public string _4DF674966D3C4AF9
	{
		[CompilerGenerated]
		get
		{
			return _8E95764C11B5434D;
		}
		[CompilerGenerated]
		set
		{
			_8E95764C11B5434D = text;
		}
	}

	public byte _4B8939E38D994538
	{
		[CompilerGenerated]
		get
		{
			return _6C82615EC8374146;
		}
		[CompilerGenerated]
		set
		{
			_6C82615EC8374146 = b;
		}
	}

	public A58BA203630149A8()
	{
	}

	public A58BA203630149A8(string P_0, string P_1, byte P_2)
	{
		_0141ABA9E76B41D0((object)this, P_0);
		BE9DDC4AF62F49BB((object)this, P_1);
		_0260B7C976A04A06((object)this, P_2);
	}

	public virtual void F05014BFD6B845C5(BinaryWriter P_0)
	{
		_37B52EB18BB74B2F((object)P_0, _94F3CF251D24482B((object)this));
		_37B52EB18BB74B2F((object)P_0, _5AF7932D00BA4D6C((object)this));
		_343DCA62358C4B91((object)P_0, _0E305AD700AF467C((object)this));
	}

	public virtual void D1BC0A1B12BB46BA(BinaryReader P_0)
	{
		_0141ABA9E76B41D0((object)this, _7444CADA1CEC470E((object)P_0));
		BE9DDC4AF62F49BB((object)this, _7444CADA1CEC470E((object)P_0));
		_0260B7C976A04A06((object)this, _982E0B544A864FFB((object)P_0));
	}

	static void _0141ABA9E76B41D0(object P_0, string P_1)
	{
		((A58BA203630149A8)P_0)._00ECE3BD20C142E6 = P_1;
	}

	static void BE9DDC4AF62F49BB(object P_0, string P_1)
	{
		((A58BA203630149A8)P_0)._4DF674966D3C4AF9 = P_1;
	}

	static void _0260B7C976A04A06(object P_0, byte P_1)
	{
		((A58BA203630149A8)P_0)._4B8939E38D994538 = P_1;
	}

	static string _94F3CF251D24482B(object P_0)
	{
		return ((A58BA203630149A8)P_0)._00ECE3BD20C142E6;
	}

	static void _37B52EB18BB74B2F(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _5AF7932D00BA4D6C(object P_0)
	{
		return ((A58BA203630149A8)P_0)._4DF674966D3C4AF9;
	}

	static byte _0E305AD700AF467C(object P_0)
	{
		return ((A58BA203630149A8)P_0)._4B8939E38D994538;
	}

	static void _343DCA62358C4B91(object P_0, byte P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string _7444CADA1CEC470E(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static byte _982E0B544A864FFB(object P_0)
	{
		return ((BinaryReader)P_0).ReadByte();
	}
}
