using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

public class B15E2605ED474C2A : _45A0FAC1031A4143, B2E071EB09EF4831
{
	[CompilerGenerated]
	private ulong _0B8A060955A64297;

	[CompilerGenerated]
	private ulong _33634517125A4EF9;

	[CompilerGenerated]
	private int _76C30EAA12894664;

	[CompilerGenerated]
	private ELimb DDB8942F6AC2419C;

	[CompilerGenerated]
	private Vector3 _1A656BD010AE4C48;

	[CompilerGenerated]
	private List<List<_03D84A7376B94EA1>> F486CAAE51064286 = new List<List<_03D84A7376B94EA1>>();

	private readonly Stack<List<_03D84A7376B94EA1>> CA4D56B112BE404A = new Stack<List<_03D84A7376B94EA1>>();

	private static readonly _1A87FA40A3224FE4 _4ED32A2CA850406D = new _1A87FA40A3224FE4("CE7775E06392484A");

	private static readonly _1A87FA40A3224FE4 _3B200BF540E44597 = new _1A87FA40A3224FE4("9C05E3A71D64B82F");

	private static readonly _1A87FA40A3224FE4 _77990841290D4B4A = new _1A87FA40A3224FE4("6E1D8B4A0C7F29E3");

	private static readonly _1A87FA40A3224FE4 _7A3A35CAC71F4124 = new _1A87FA40A3224FE4("3C7F91A24E0B4D85");

	private static readonly _1A87FA40A3224FE4 CB9D9BAA82414A74 = new _1A87FA40A3224FE4("B84D2E60C1F74A39");

	private static readonly _1A87FA40A3224FE4 _9155271565944E38 = new _1A87FA40A3224FE4("7A16C3D85B9E42F0");

	public ulong _08C17298D4F44F01
	{
		[CompilerGenerated]
		get
		{
			return _0B8A060955A64297;
		}
		[CompilerGenerated]
		set
		{
			_0B8A060955A64297 = num;
		}
	}

	public ulong AF8591C5AC444EA8
	{
		[CompilerGenerated]
		get
		{
			return _33634517125A4EF9;
		}
		[CompilerGenerated]
		set
		{
			_33634517125A4EF9 = num;
		}
	}

	public int _341D11B636DB4405
	{
		[CompilerGenerated]
		get
		{
			return _76C30EAA12894664;
		}
		[CompilerGenerated]
		set
		{
			_76C30EAA12894664 = num;
		}
	}

	public ELimb _0CEF90795CAB44B1
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return DDB8942F6AC2419C;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			DDB8942F6AC2419C = dDB8942F6AC2419C;
		}
	}

	public Vector3 _9F9A4C6A32564D6B
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _1A656BD010AE4C48;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_1A656BD010AE4C48 = val;
		}
	}

	public List<List<_03D84A7376B94EA1>> E2102A94A4944897
	{
		[CompilerGenerated]
		get
		{
			return F486CAAE51064286;
		}
		[CompilerGenerated]
		set
		{
			F486CAAE51064286 = f486CAAE;
		}
	}

	public List<_03D84A7376B94EA1> _7856127C6B6646D5(int P_0)
	{
		if (CA4D56B112BE404A.Count <= 0)
		{
			return new List<_03D84A7376B94EA1>(P_0);
		}
		return CA4D56B112BE404A.Pop();
	}

	public void _6846C0A9C8394D94(_40273E31A09B48E7 P_0)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected I4, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		P_0.C997CE1F965A444E();
		P_0._155F75A22FDC453F(_4ED32A2CA850406D, _08C17298D4F44F01);
		P_0._155F75A22FDC453F(_3B200BF540E44597, AF8591C5AC444EA8);
		P_0._3652A1899A964F50(_77990841290D4B4A, _341D11B636DB4405);
		P_0._1D5ED90682A44EC8(_7A3A35CAC71F4124, global::_1739BB42C5074828<ELimb>._314F88BB1FD74F74((int)_0CEF90795CAB44B1));
		D483B72FDA5E4303._14595196956D489D(P_0, CB9D9BAA82414A74, _9F9A4C6A32564D6B);
		P_0.CD30EFF95D2441C5(_9155271565944E38);
		foreach (List<_03D84A7376B94EA1> item in E2102A94A4944897)
		{
			P_0.F565D57FA03F464E();
			foreach (_03D84A7376B94EA1 item2 in item)
			{
				_03D84A7376B94EA1._150C7C6589D64493(P_0, item2);
			}
			P_0._43E4D0199681436D();
		}
		P_0._43E4D0199681436D();
		P_0.F041F740698D4DE9();
	}

	void B2E071EB09EF4831._19907F326BCB4B52(_40273E31A09B48E7 P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in 6846C0A9C8394D94
		this._6846C0A9C8394D94(P_0);
	}

	public void _02059AF1152F4958()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		_08C17298D4F44F01 = 0uL;
		AF8591C5AC444EA8 = 0uL;
		_341D11B636DB4405 = 0;
		_0CEF90795CAB44B1 = (ELimb)0;
		_9F9A4C6A32564D6B = default;
		foreach (List<_03D84A7376B94EA1> item in E2102A94A4944897)
		{
			item.Clear();
			CA4D56B112BE404A.Push(item);
		}
		E2102A94A4944897.Clear();
	}

	void _45A0FAC1031A4143._058D7D2916534402()
	{
		//ILSpy generated this explicit interface implementation from .override directive in 02059AF1152F4958
		this._02059AF1152F4958();
	}
}
