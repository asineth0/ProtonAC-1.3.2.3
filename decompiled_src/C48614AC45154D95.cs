using System.Collections.Generic;
using System.Runtime.CompilerServices;

internal class C48614AC45154D95 : _45A0FAC1031A4143, B2E071EB09EF4831
{
	[CompilerGenerated]
	private ulong _45207C2B05F14CBB;

	[CompilerGenerated]
	private int _664DCB40A99D4B58;

	[CompilerGenerated]
	private List<_5BFAAAB21DD048F9> _5B7835C039F74EFF = new List<_5BFAAAB21DD048F9>();

	private static readonly _1A87FA40A3224FE4 _7F52871BADF547CE = new _1A87FA40A3224FE4("CE7775E06392484A");

	private static readonly _1A87FA40A3224FE4 _92DDA01840C34365 = new _1A87FA40A3224FE4("155BBCE9730A4334");

	private static readonly _1A87FA40A3224FE4 _1CF2761CC17D4567 = new _1A87FA40A3224FE4("BEAD9EC333BA4C46");

	public ulong C03984E0A7D64C2D
	{
		[CompilerGenerated]
		get
		{
			return _45207C2B05F14CBB;
		}
		[CompilerGenerated]
		set
		{
			_45207C2B05F14CBB = num;
		}
	}

	public int _54605946DDFA4216
	{
		[CompilerGenerated]
		get
		{
			return _664DCB40A99D4B58;
		}
		[CompilerGenerated]
		set
		{
			_664DCB40A99D4B58 = num;
		}
	}

	public List<_5BFAAAB21DD048F9> _9B275B1A52C94131
	{
		[CompilerGenerated]
		get
		{
			return _5B7835C039F74EFF;
		}
		[CompilerGenerated]
		set
		{
			_5B7835C039F74EFF = list;
		}
	}

	public void _3EDF64DCBFE848F9()
	{
		C03984E0A7D64C2D = 0uL;
		_54605946DDFA4216 = 0;
		_9B275B1A52C94131.Clear();
	}

	void _45A0FAC1031A4143._058D7D2916534402()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 3EDF64DCBFE848F9
		this._3EDF64DCBFE848F9();
	}

	public void _86D0E7213F204E6D(_40273E31A09B48E7 P_0)
	{
		P_0.C997CE1F965A444E();
		P_0._155F75A22FDC453F(_7F52871BADF547CE, C03984E0A7D64C2D);
		P_0._3652A1899A964F50(_92DDA01840C34365, _54605946DDFA4216);
		P_0.CD30EFF95D2441C5(_1CF2761CC17D4567);
		foreach (_5BFAAAB21DD048F9 item in _9B275B1A52C94131)
		{
			_5BFAAAB21DD048F9.E6F790D5019A484D(P_0, item);
		}
		P_0._43E4D0199681436D();
		P_0.F041F740698D4DE9();
	}

	void B2E071EB09EF4831._19907F326BCB4B52(_40273E31A09B48E7 P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 86D0E7213F204E6D
		this._86D0E7213F204E6D(P_0);
	}
}
