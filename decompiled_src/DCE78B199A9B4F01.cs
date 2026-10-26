using System.IO;
using System.Runtime.CompilerServices;

internal class DCE78B199A9B4F01 : _652C34B1E6554F10
{
	[CompilerGenerated]
	private bool _7F126D1CC4D342E9;

	public bool F73DE65159C94094
	{
		[CompilerGenerated]
		get
		{
			return _7F126D1CC4D342E9;
		}
		[CompilerGenerated]
		set
		{
			_7F126D1CC4D342E9 = flag;
		}
	}

	public DCE78B199A9B4F01()
	{
	}

	public DCE78B199A9B4F01(bool P_0)
	{
		_260D24F531084B6B((object)this, P_0);
	}

	public virtual void _6B95D1B95E1744B4(BinaryWriter P_0)
	{
		_584916D9E35449C6((object)P_0, B00E8C9CCE9D4C95((object)this));
	}

	public virtual void _9247DDCA78A347C0(BinaryReader P_0)
	{
		_260D24F531084B6B((object)this, _597BB8B7C03E4977((object)P_0));
	}

	static void _260D24F531084B6B(object P_0, bool P_1)
	{
		((DCE78B199A9B4F01)P_0).F73DE65159C94094 = P_1;
	}

	static bool B00E8C9CCE9D4C95(object P_0)
	{
		return ((DCE78B199A9B4F01)P_0).F73DE65159C94094;
	}

	static void _584916D9E35449C6(object P_0, bool P_1)
	{
		((BinaryWriter)P_0).Write(P_1);
	}

	static bool _597BB8B7C03E4977(object P_0)
	{
		return ((BinaryReader)P_0).ReadBoolean();
	}
}
