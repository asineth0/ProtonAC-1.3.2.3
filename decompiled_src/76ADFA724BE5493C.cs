using SDG.Unturned;
using UnityEngine;

internal class _76ADFA724BE5493C : _89ED754871B24D32
{
	private const float _56024F2FCB464491 = 0.25f;

	public virtual ECheckType _20B4F7B3D41C4BF0()
	{
		return ECheckType.InvalidSpeed;
	}

	public virtual (string debug, EFlagLevel level)? _955FBC406F9C4E15(A3116505AAB24996 P_0, Player P_1, InteractableVehicle P_2, Rigidbody P_3, _222604882F4244C0 P_4, _7B93EFC9B3644586 P_5)
	{
		if (!(Mathf.Abs(P_5.C1D4B088000A43F8) > P_5._17C6388F3DE84B2B + 0.25f))
		{
			return null;
		}
		return ("type: A", EFlagLevel.Critical);
	}
}
