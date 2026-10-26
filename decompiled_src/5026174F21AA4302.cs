using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SDG.Unturned;

internal class _5026174F21AA4302 : _45A0FAC1031A4143, B2E071EB09EF4831
{
	[CompilerGenerated]
	private ushort _667B02DB97E849C6;

	[CompilerGenerated]
	private string? B7D1B4B6B3814D73;

	[CompilerGenerated]
	private EBuild BFFDC5C05E9C4A27;

	[CompilerGenerated]
	private int _1D5E306369CB4439;

	[CompilerGenerated]
	private List<CCF76E55FEF4462A> _025C870A8FAE4A2E = new List<CCF76E55FEF4462A>();

	private static readonly _1A87FA40A3224FE4 F9691C3C0A1141CD = new _1A87FA40A3224FE4("E1A79B4D1F1D9BF3");

	private static readonly _1A87FA40A3224FE4 _0FDAFCBA8A9D4D87 = new _1A87FA40A3224FE4("CB20817C46708F27");

	private static readonly _1A87FA40A3224FE4 _080612E1774949C5 = new _1A87FA40A3224FE4("30BFC8F1137153D9");

	private static readonly _1A87FA40A3224FE4 _5340B2E18B304843 = new _1A87FA40A3224FE4("C1BECC5DB95ECFEA");

	private static readonly _1A87FA40A3224FE4 _2A2947327B2E47AA = new _1A87FA40A3224FE4("5C6E1CF3EE9C74F9");

	public ushort _60FB228B546A494D
	{
		[CompilerGenerated]
		get
		{
			return _667B02DB97E849C6;
		}
		[CompilerGenerated]
		set
		{
			_667B02DB97E849C6 = num;
		}
	}

	public string? _4CEE5B8971034213
	{
		[CompilerGenerated]
		get
		{
			return B7D1B4B6B3814D73;
		}
		[CompilerGenerated]
		set
		{
			B7D1B4B6B3814D73 = b7D1B4B6B3814D;
		}
	}

	public EBuild _528ACD5C250D408B
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return BFFDC5C05E9C4A27;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			BFFDC5C05E9C4A27 = bFFDC5C05E9C4A;
		}
	}

	public int _0FD0D6CB93264B4D
	{
		[CompilerGenerated]
		get
		{
			return _1D5E306369CB4439;
		}
		[CompilerGenerated]
		set
		{
			_1D5E306369CB4439 = num;
		}
	}

	public List<CCF76E55FEF4462A> _49735FDD1E164071
	{
		[CompilerGenerated]
		get
		{
			return _025C870A8FAE4A2E;
		}
		[CompilerGenerated]
		set
		{
			_025C870A8FAE4A2E = list;
		}
	}

	public void _5B6ADF17DBC04004(_40273E31A09B48E7 P_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected I4, but got Unknown
		P_0.C997CE1F965A444E();
		P_0._3652A1899A964F50(F9691C3C0A1141CD, _60FB228B546A494D);
		P_0._7FD3C54C402B4219(_0FDAFCBA8A9D4D87, _4CEE5B8971034213);
		P_0._1D5ED90682A44EC8(_080612E1774949C5, global::_1739BB42C5074828<EBuild>._314F88BB1FD74F74((int)_528ACD5C250D408B));
		P_0._3652A1899A964F50(_5340B2E18B304843, _0FD0D6CB93264B4D);
		P_0.CD30EFF95D2441C5(_2A2947327B2E47AA);
		foreach (CCF76E55FEF4462A item in _49735FDD1E164071)
		{
			CCF76E55FEF4462A._2D22D5EB56EC418C(P_0, item);
		}
		P_0._43E4D0199681436D();
		P_0.F041F740698D4DE9();
	}

	void B2E071EB09EF4831._19907F326BCB4B52(_40273E31A09B48E7 P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 5B6ADF17DBC04004
		this._5B6ADF17DBC04004(P_0);
	}

	public void _0BAED10C649C42E1()
	{
		_60FB228B546A494D = 0;
		_4CEE5B8971034213 = null;
		_528ACD5C250D408B = (EBuild)0;
		_0FD0D6CB93264B4D = 0;
		_49735FDD1E164071.Clear();
	}

	void _45A0FAC1031A4143._058D7D2916534402()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 0BAED10C649C42E1
		this._0BAED10C649C42E1();
	}
}
