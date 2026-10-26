using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SDG.Unturned;

internal class CDB7F915DDEB4F85 : _45A0FAC1031A4143, B2E071EB09EF4831
{
	[CompilerGenerated]
	private ulong F7E841922E3D4A4D;

	[CompilerGenerated]
	private string? CEE99B0CF320477A;

	[CompilerGenerated]
	private EClientPlatform? _8730E7803107455D;

	[CompilerGenerated]
	private int _5BAD5F15262C423E;

	[CompilerGenerated]
	private List<string> E3BECB07ACD34CB5 = new List<string>();

	private static readonly _1A87FA40A3224FE4 _96FAF49CC16F4E59 = new _1A87FA40A3224FE4("CE7775E06392484A");

	private static readonly _1A87FA40A3224FE4 C6B3591E29BE468D = new _1A87FA40A3224FE4("7B2D9E41A083F51C");

	private static readonly _1A87FA40A3224FE4 A1A4B802658647CB = new _1A87FA40A3224FE4("4F81A02E9B3D7C56");

	private static readonly _1A87FA40A3224FE4 _15225B55BD9149DB = new _1A87FA40A3224FE4("C21D83E0A9B4671F");

	private static readonly _1A87FA40A3224FE4 _6CFD961F747A4E9C = new _1A87FA40A3224FE4("8B3A79E21D045C83");

	public ulong F130FD183F724D96
	{
		[CompilerGenerated]
		get
		{
			return F7E841922E3D4A4D;
		}
		[CompilerGenerated]
		set
		{
			F7E841922E3D4A4D = f7E841922E3D4A4D;
		}
	}

	public string? _5D6E1455321849A3
	{
		[CompilerGenerated]
		get
		{
			return CEE99B0CF320477A;
		}
		[CompilerGenerated]
		set
		{
			CEE99B0CF320477A = cEE99B0CF320477A;
		}
	}

	public EClientPlatform? _44694241B9E24721
	{
		[CompilerGenerated]
		get
		{
			return _8730E7803107455D;
		}
		[CompilerGenerated]
		set
		{
			_8730E7803107455D = val;
		}
	}

	public int _7807214BEE9E482E
	{
		[CompilerGenerated]
		get
		{
			return _5BAD5F15262C423E;
		}
		[CompilerGenerated]
		set
		{
			_5BAD5F15262C423E = num;
		}
	}

	public List<string> _0C699508D85F4D7A
	{
		[CompilerGenerated]
		get
		{
			return E3BECB07ACD34CB5;
		}
		[CompilerGenerated]
		set
		{
			E3BECB07ACD34CB5 = e3BECB07ACD34CB;
		}
	}

	public void A654BA8BAB4C41F0()
	{
		F130FD183F724D96 = 0uL;
		_5D6E1455321849A3 = null;
		_44694241B9E24721 = null;
		_7807214BEE9E482E = 0;
		_0C699508D85F4D7A.Clear();
	}

	void _45A0FAC1031A4143._058D7D2916534402()
	{
		//ILSpy generated this explicit interface implementation from .override directive in A654BA8BAB4C41F0
		this.A654BA8BAB4C41F0();
	}

	public void DAAE124C12B347F1(_40273E31A09B48E7 P_0)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected I4, but got Unknown
		P_0.C997CE1F965A444E();
		P_0._155F75A22FDC453F(_96FAF49CC16F4E59, F130FD183F724D96);
		P_0._7FD3C54C402B4219(C6B3591E29BE468D, _5D6E1455321849A3);
		if (_44694241B9E24721.HasValue)
		{
			P_0._1D5ED90682A44EC8(A1A4B802658647CB, global::_1739BB42C5074828<EClientPlatform>._314F88BB1FD74F74((int)_44694241B9E24721.Value));
		}
		else
		{
			P_0._540DCAD9AF674164(A1A4B802658647CB);
		}
		P_0._3652A1899A964F50(_15225B55BD9149DB, _7807214BEE9E482E);
		P_0.CD30EFF95D2441C5(_6CFD961F747A4E9C);
		foreach (string item in _0C699508D85F4D7A)
		{
			P_0._612EF485E8CC4905(item);
		}
		P_0._43E4D0199681436D();
		P_0.F041F740698D4DE9();
	}

	void B2E071EB09EF4831._19907F326BCB4B52(_40273E31A09B48E7 P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in DAAE124C12B347F1
		this.DAAE124C12B347F1(P_0);
	}
}
