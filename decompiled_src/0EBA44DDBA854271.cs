using System;
using System.IO;
using System.Runtime.CompilerServices;

internal class _0EBA44DDBA854271 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private string _3E8D460C36364785;

	[CompilerGenerated]
	private Guid CBAA5067DD1E4170;

	[CompilerGenerated]
	private ushort _7212CDF5A9F64848;

	public string E6BA9B5BFA144FBC
	{
		[CompilerGenerated]
		get
		{
			return _3E8D460C36364785;
		}
		[CompilerGenerated]
		set
		{
			_3E8D460C36364785 = text;
		}
	}

	public Guid _441B237E13854373
	{
		[CompilerGenerated]
		get
		{
			return CBAA5067DD1E4170;
		}
		[CompilerGenerated]
		set
		{
			CBAA5067DD1E4170 = cBAA5067DD1E;
		}
	}

	public ushort FF48F97C03B4453F
	{
		[CompilerGenerated]
		get
		{
			return _7212CDF5A9F64848;
		}
		[CompilerGenerated]
		set
		{
			_7212CDF5A9F64848 = num;
		}
	}

	public _0EBA44DDBA854271()
	{
	}

	public _0EBA44DDBA854271(string P_0, Guid P_1, ushort P_2)
	{
		_8D5549A5534D4B68((object)this, P_0);
		_9EAC6C2696A04ABF((object)this, default(Guid));
	}

	public virtual void _4B1030A59ED9498A(BinaryWriter P_0)
	{
		_9BA86FA7EDB54FE7((object)this);
		_9BA86FA7EDB54FE7((object)P_0);
		_9BA86FA7EDB54FE7((object)this);
		_9BA86FA7EDB54FE7((object)P_0);
		_9BA86FA7EDB54FE7((object)this);
		_9BA86FA7EDB54FE7((object)P_0);
	}

	public virtual void _7FB4B2BAAF3E4BA0(BinaryReader P_0)
	{
		_8D5549A5534D4B68((object)this, F063C731B1C741E4((object)P_0));
		_9EAC6C2696A04ABF((object)this, Guid.Parse(F063C731B1C741E4((object)P_0)));
		_63F4A7D2E418458A((object)this, _9BA86FA7EDB54FE7((object)P_0));
	}

	static void _8D5549A5534D4B68(object P_0, string P_1)
	{
		((_0EBA44DDBA854271)P_0).E6BA9B5BFA144FBC = P_1;
	}

	static void _9EAC6C2696A04ABF(object P_0, Guid P_1)
	{
		((_0EBA44DDBA854271)P_0)._441B237E13854373 = P_1;
	}

	static void _63F4A7D2E418458A(object P_0, ushort P_1)
	{
		((_0EBA44DDBA854271)P_0).FF48F97C03B4453F = P_1;
	}

	static string _715C14C34FA14587(object P_0)
	{
		return ((_0EBA44DDBA854271)P_0).E6BA9B5BFA144FBC;
	}

	static void _4221603AF2DA47E4(object P_0, string P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static Guid _72CBAE14E2A14FFC(object P_0)
	{
		return ((_0EBA44DDBA854271)P_0)._441B237E13854373;
	}

	static ushort _0C31D839E6364B1C(object P_0)
	{
		return ((_0EBA44DDBA854271)P_0).FF48F97C03B4453F;
	}

	static void ABA0B0C23C714049(object P_0, ushort P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static string F063C731B1C741E4(object P_0)
	{
		return ((BinaryReader)P_0).ReadString();
	}

	static ushort _9BA86FA7EDB54FE7(object P_0)
	{
		return ((BinaryReader)P_0).ReadUInt16();
	}
}
