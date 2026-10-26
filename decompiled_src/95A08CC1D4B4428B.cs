using System.IO;
using System.Runtime.CompilerServices;

internal class _95A08CC1D4B4428B : _652C34B1E6554F10
{
	[CompilerGenerated]
	private bool _6494BB99DE044C2B;

	public bool AFF361E783CA49B3
	{
		[CompilerGenerated]
		get
		{
			return _6494BB99DE044C2B;
		}
		[CompilerGenerated]
		set
		{
			_6494BB99DE044C2B = flag;
		}
	}

	public _95A08CC1D4B4428B()
	{
	}

	public _95A08CC1D4B4428B(bool P_0)
	{
		_652C34B1E6554F10._6002889CC5D04ED9((object)this);
		_58088310CA0D46DC((object)this);
	}

	public virtual void B9982839EF294B81(BinaryWriter P_0)
	{
		_58088310CA0D46DC((object)this);
		_58088310CA0D46DC((object)P_0);
	}

	public virtual void F06280333D064E39(BinaryReader P_0)
	{
		_1A1B281AB64B4B0E((object)this, _58088310CA0D46DC((object)P_0));
	}

	static void _1A1B281AB64B4B0E(object P_0, bool P_1)
	{
		((_95A08CC1D4B4428B)P_0).AFF361E783CA49B3 = P_1;
	}

	static bool _7FBFF4A33C324166(object P_0)
	{
		return ((_95A08CC1D4B4428B)P_0).AFF361E783CA49B3;
	}

	static void _463E6564FF154BAA(object P_0, bool P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static bool _58088310CA0D46DC(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}
}
