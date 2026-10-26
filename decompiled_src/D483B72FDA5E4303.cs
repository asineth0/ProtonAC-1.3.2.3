using UnityEngine;

public static class D483B72FDA5E4303
{
	private static readonly _1A87FA40A3224FE4 _364E7F2A14D24853 = new _1A87FA40A3224FE4("X");

	private static readonly _1A87FA40A3224FE4 _977A997AD160426C = new _1A87FA40A3224FE4("Y");

	private static readonly _1A87FA40A3224FE4 B4220783EA404468 = new _1A87FA40A3224FE4("Z");

	private static readonly _1A87FA40A3224FE4 C418C0AF147E4CCE = new _1A87FA40A3224FE4("Center");

	private static readonly _1A87FA40A3224FE4 _988A3B989E41416C = new _1A87FA40A3224FE4("Extents");

	public static void _14595196956D489D(_40273E31A09B48E7 P_0, _1A87FA40A3224FE4 P_1, Vector3 P_2)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		P_0.B39A34F0D4084628(P_1);
		P_0._8D3F3D053CAF446A(_364E7F2A14D24853, P_2.x);
		P_0._8D3F3D053CAF446A(_977A997AD160426C, P_2.y);
		P_0._8D3F3D053CAF446A(B4220783EA404468, P_2.z);
		P_0.F041F740698D4DE9();
	}

	public static void B54540300B5F47D9(_40273E31A09B48E7 P_0, _1A87FA40A3224FE4 P_1, Vector3 P_2)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		P_0.B39A34F0D4084628(P_1);
		P_0.D72DC986A4664711(_364E7F2A14D24853, P_2.x);
		P_0.D72DC986A4664711(_977A997AD160426C, P_2.y);
		P_0.D72DC986A4664711(B4220783EA404468, P_2.z);
		P_0.F041F740698D4DE9();
	}

	public static void _131919D7B45A4FCF(_40273E31A09B48E7 P_0, _1A87FA40A3224FE4 P_1, Bounds P_2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		P_0.B39A34F0D4084628(P_1);
		_14595196956D489D(P_0, C418C0AF147E4CCE, P_2.center);
		_14595196956D489D(P_0, _988A3B989E41416C, P_2.extents);
		P_0.F041F740698D4DE9();
	}
}
