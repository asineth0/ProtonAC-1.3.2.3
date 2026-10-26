using UnityEngine;

public static class _680955959F674DCC
{
	public const int _362FFDB2BA234B0A = 6;

	public const int _66AB82592F9649DE = 3;

	private const int _219813D76F2F4C27 = 6;

	public const int AF5DA111E90740B5 = 5;

	public const int _4E4046396BDE4D9C = 2;

	private static readonly int BBC4F334822A423B = 15552;

	private static readonly int _20E4A9C2ED594081 = 116640;

	public static bool E4DFDEB8A1664084
	{
		get
		{
			if (_15C70DD7010F4FB2._69777DA02AD34431 != null && _15C70DD7010F4FB2._69777DA02AD34431.Length == BBC4F334822A423B && _15C70DD7010F4FB2._7BC1AAFC10994851 != null)
			{
				return _15C70DD7010F4FB2._7BC1AAFC10994851.Length == _20E4A9C2ED594081;
			}
			return false;
		}
	}

	public static void A2C717841AB84AE5(int P_0, bool P_1, float P_2, int P_3, int P_4, out Vector3 P_5, out Vector3 P_6)
	{
		_001323285EBA4350(_15C70DD7010F4FB2._69777DA02AD34431, P_0 * 2 + (P_1 ? 1 : 0), P_2, P_3, P_4, out P_5, out P_6);
	}

	public static void BD3BC3603262456A(int P_0, int P_1, bool P_2, float P_3, int P_4, int P_5, out Vector3 P_6, out Vector3 P_7)
	{
		int num = (P_0 * 5 + P_1) * 2 + (P_2 ? 1 : 0);
		_001323285EBA4350(_15C70DD7010F4FB2._7BC1AAFC10994851, num, P_3, P_4, P_5, out P_6, out P_7);
	}

	private static void _001323285EBA4350(float[] P_0, int P_1, float P_2, int P_3, int P_4, out Vector3 P_5, out Vector3 P_6)
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		int num = 9;
		float num2 = Mathf.InverseLerp(1f, 179f, P_2) * (float)(num - 1);
		int num3 = Mathf.Clamp(Mathf.FloorToInt(num2), 0, num - 1);
		int num4 = Mathf.Clamp(P_3 + 1, 0, 2);
		B78E3FC4A3A64F09(P_0, BEDC922235884AA0(P_1, num3, num4, P_4, num), out P_5, out P_6);
		int num5 = Mathf.Min(num3 + 1, num - 1);
		float num6 = num2 - (float)num3;
		if (num5 != num3 && !(num6 < 0.0001f))
		{
			B78E3FC4A3A64F09(P_0, BEDC922235884AA0(P_1, num5, num4, P_4, num), out var val, out var val2);
			float num7 = Mathf.Min(P_5.y - P_6.y, val.y - val2.y);
			float num8 = Mathf.Max(P_5.y + P_6.y, val.y + val2.y);
			float num9 = Mathf.Min(P_5.z - P_6.z, val.z - val2.z);
			float num10 = Mathf.Max(P_5.z + P_6.z, val.z + val2.z);
			P_5 = new Vector3(Mathf.Lerp(P_5.x, val.x, num6), (num7 + num8) * 0.5f, (num9 + num10) * 0.5f);
			P_6 = new Vector3(Mathf.Lerp(P_6.x, val2.x, num6), (num8 - num7) * 0.5f, (num10 - num9) * 0.5f);
		}
	}

	private static int BEDC922235884AA0(int P_0, int P_1, int P_2, int P_3, int P_4)
	{
		return (((P_0 * P_4 + P_1) * 3 + P_2) * 6 + P_3) * 6;
	}

	private static void B78E3FC4A3A64F09(float[] P_0, int P_1, out Vector3 P_2, out Vector3 P_3)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		P_2 = new Vector3(P_0[P_1], P_0[P_1 + 1], P_0[P_1 + 2]);
		P_3 = new Vector3(P_0[P_1 + 3], P_0[P_1 + 4], P_0[P_1 + 5]);
	}
}
