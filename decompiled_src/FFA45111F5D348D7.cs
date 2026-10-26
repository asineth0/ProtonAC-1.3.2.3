using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

internal static class FFA45111F5D348D7
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Vector2 _1112B13D40924F28(Vector3 P_0)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		CartographyVolume val = (CartographyVolume)EDDAFBBB78CA4DF3((object)VolumeManager<CartographyVolume, CartographyVolumeManager>.Get());
		if (D45298C58A824EE8((Object)(object)val, (Object)null))
		{
			while (true)
			{
				int num = 1877960259;
				uint num2;
				switch ((num2 = (uint)((num * 925140815 - (2113223944 + ((--506800804 ^ (~(--479142986) ^ -366071589)) + (-(~(-404175518 + -1199233348)) ^ 0x4C1E123E)))) * -2049698747)) % 3)
				{
				case 0u:
					continue;
				case 2u:
				{
					Vector3 val2 = C7AFC030184D4172(DD85204DF51E4DB6((object)val), P_0);
					return new Vector2(val2.x + _003CModule_003E._8B9C7B12B1AE4949<float>(1400717923), _003CModule_003E.F84FA79ABE6944BB<float>(1724269691) - val2.z);
				}
				}
				break;
			}
		}
		float num3 = (float)(int)_49E222ECB0B24A3F() - (float)(int)B5736F74CE994186() * _003CModule_003E._8B9C7B12B1AE4949<float>(-1402781655);
		return new Vector2(P_0.x / num3 + _003CModule_003E._390073C602714496<float>(1217054381), _003CModule_003E._3F57E81A62734AC2<float>(563453236) - P_0.z / num3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string _5EE59AFB8F8E476C(this Vector3 P_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		return _2BF1A0D7A9BC44FE(_003CModule_003E._3F57E81A62734AC2<string>(1638919923), (object)P_0.x, (object)P_0.y, (object)P_0.z);
	}

	static object EDDAFBBB78CA4DF3(object P_0)
	{
		return ((CartographyVolumeManager)P_0).GetMainVolume();
	}

	static bool D45298C58A824EE8(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static object DD85204DF51E4DB6(object P_0)
	{
		return ((Component)P_0).transform;
	}

	static Vector3 C7AFC030184D4172(object P_0, Vector3 P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return ((Transform)P_0).InverseTransformPoint(P_1);
	}

	static ushort _49E222ECB0B24A3F()
	{
		return Level.size;
	}

	static ushort B5736F74CE994186()
	{
		return Level.border;
	}

	static string _2BF1A0D7A9BC44FE(string P_0, object P_1, object P_2, object P_3)
	{
		return string.Format(P_0, P_1, P_2, P_3);
	}
}
