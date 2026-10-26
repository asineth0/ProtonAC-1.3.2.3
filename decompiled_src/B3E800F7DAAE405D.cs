using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

public class B3E800F7DAAE405D
{
	public struct _8B7C6A7C18684FA8
	{
		public Vector3 AE0F78E8DD484598;

		public Vector3 _8B47B2B22D864C7B;
	}

	private static readonly int B27946D3DFC74463 = 406044672;

	public static readonly EPlayerStance[] _45BD767F01AF43B2;

	public global::A807FD2A83C845A2<_8B7C6A7C18684FA8> _5C521683885F483B = new global::A807FD2A83C845A2<_8B7C6A7C18684FA8>(3);

	public _8B7C6A7C18684FA8? DAB71A667E20425F;

	public _8B7C6A7C18684FA8? _8EBCE734A07644E8;

	public _8B7C6A7C18684FA8? _18447759A2394EC9;

	public Vector3 _0A55EDE023B44259;

	public Vector3 _13C2E84001FA4667;

	public Vector3 _42DF72C175E845A9;

	public bool _722C1E3EDF244863;

	public _8B7C6A7C18684FA8 _7ED3CB3A6B244A09(Player P_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		return DAB71A667E20425F ?? new _8B7C6A7C18684FA8
		{
			AE0F78E8DD484598 = ((Component)P_0).transform.position,
			_8B47B2B22D864C7B = P_0.look.aim.position
		};
	}

	public _8B7C6A7C18684FA8 _519D3BF95CBF4676(Player P_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		return _18447759A2394EC9 ?? new _8B7C6A7C18684FA8
		{
			AE0F78E8DD484598 = ((Component)P_0).transform.position,
			_8B47B2B22D864C7B = P_0.look.aim.position
		};
	}

	public _8B7C6A7C18684FA8 _4825B46999054930(Player P_0)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		return _8EBCE734A07644E8 ?? new _8B7C6A7C18684FA8
		{
			AE0F78E8DD484598 = ((Component)P_0).transform.position,
			_8B47B2B22D864C7B = P_0.look.aim.position
		};
	}

	public Vector3 D6A0D62EDEA74C2C(Player P_0, Vector3 P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (Vector3.Distance(P_1, ((Component)P_0).transform.position) > 2.5f)
		{
			return ((Component)P_0).transform.position;
		}
		if (Vector3.Distance(P_1, ((Component)P_0).transform.position) > 0.01f && Physics.Linecast(P_1, ((Component)P_0).transform.position, B27946D3DFC74463, (QueryTriggerInteraction)1))
		{
			return ((Component)P_0).transform.position;
		}
		return P_1;
	}

	public void A8AD496AF10A4C77(_8B7C6A7C18684FA8 P_0)
	{
		_5C521683885F483B._0412FB40DF604255(P_0);
	}

	public static float CA4505681FD0490E(EPlayerStance P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		if ((int)P_0 == 3)
		{
			return 1.75f;
		}
		if ((int)P_0 == 4)
		{
			return 1.2f;
		}
		if ((int)P_0 == 5)
		{
			return 0.35f;
		}
		return 1.6f;
	}

	public static float _68CBC890B9CC41BD(EPlayerStance P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)P_0 == 4)
		{
			return 1.2f;
		}
		if ((int)P_0 == 5)
		{
			return 0.8f;
		}
		return 2f;
	}

	static B3E800F7DAAE405D()
	{
		EPlayerStance[] array = new EPlayerStance[3];
		RuntimeHelpers.InitializeArray(array, __ldtoken(_003C470e16ff_002D859c_002D4f3b_002D965d_002Dd33ec81b511b_003E_003CPrivateImplementationDetails_003E.CE99AE045C8B2A2A8A58FD1A2120956E74E90322EEF45F7DFE1CA73EEFE655D4));
		_45BD767F01AF43B2 = array;
	}
}
