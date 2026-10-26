using System;
using System.Collections.Generic;
using System.Diagnostics;
using SDG.Unturned;
using UnityEngine;

internal class _9AB67761792440A7
{
	public static string _6142757B48FF46AD;

	public static readonly List<Collider> AA86BD0AC5D34DBE;

	private const int B1CB237E260C431A = 4096;

	private static readonly Dictionary<int, (Transform Transform, bool HasHook)> _23E9B61C12F142B3;

	private static readonly Vector3 _3363F58FE3564799;

	private static readonly Vector3 F5C7EB2E62AE4D65;

	private static readonly Vector3 _751B30646A8C4BD2;

	private static readonly Stopwatch A6FE8FBD5BA54BF9;

	private static readonly long _2B8D5174FBF14B6C;

	public unsafe static bool _7B6477147E0F42D8 => *(int*)2803664211344uL != 3;

	public static long _00FC653ED33A4A96()
	{
		_88390874E8FB49A6._8C1151F9E5DA4875((object)null);
		return 0L;
	}

	public static bool _7A43F8465BE04590(string P_0)
	{
		if (!P_0.StartsWith("9020", StringComparison.InvariantCulture))
		{
			return !P_0.StartsWith("7656", StringComparison.InvariantCulture);
		}
		return false;
	}

	public static Vector3 B808EF2078734847(Vector3 P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3(P_0.x, 0f, P_0.z);
	}

	public static Vector3 _3EB351770C3F4FD8(Vector3 P_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		float num = 1f - Mathf.Abs(P_0.y);
		return new Vector3(num / 2f, P_0.y, num / 2f);
	}

	public static string _9D3DAA5834DD4DA6(InputInfo P_0)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)P_0.player != (Object)null)
		{
			return $"player [{P_0.player.channel.owner.playerID.steamID} ({P_0.player.channel.owner.playerID.playerName})] limb={P_0.limb}";
		}
		if ((Object)(object)P_0.zombie != (Object)null)
		{
			return $"zombie limb={P_0.limb}";
		}
		return ((object)P_0.type/*cast due to constrained. prefix*/).ToString().ToLower();
	}

	public static bool ADE95AC79DC44882(Transform P_0)
	{
		if ((Object)(object)P_0.parent != (Object)null && ((Component)P_0.parent).CompareTag("Vehicle"))
		{
			return true;
		}
		return A445BD0B1AB24EC2(P_0);
	}

	private static bool A445BD0B1AB24EC2(Transform P_0)
	{
		int instanceID = ((Object)P_0).GetInstanceID();
		if (_23E9B61C12F142B3.TryGetValue(instanceID, out (Transform, bool) value) && value.Item1 == P_0)
		{
			return value.Item2;
		}
		if (_23E9B61C12F142B3.Count >= 4096)
		{
			_23E9B61C12F142B3.Clear();
		}
		bool flag = (Object)(object)((Component)P_0).GetComponentInChildren<ActivationEventHook>() != (Object)null;
		_23E9B61C12F142B3[instanceID] = (P_0, flag);
		return flag;
	}

	public static bool _22A1896F79EB41C2(Transform P_0)
	{
		if (ADE95AC79DC44882(P_0))
		{
			return false;
		}
		AA86BD0AC5D34DBE.Clear();
		((Component)P_0).GetComponentsInChildren<Collider>(true, AA86BD0AC5D34DBE);
		return AA86BD0AC5D34DBE.Count > 0;
	}

	public static float _713742BC87CA41AC(in Vector3 P_0, int P_1)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		float num = float.MaxValue;
		foreach (Collider item in AA86BD0AC5D34DBE)
		{
			if ((P_1 & (1 << ((Component)item).gameObject.layer)) == 0)
			{
				continue;
			}
			Bounds bounds = item.bounds;
			if (!(bounds.SqrDistance(P_0) >= num))
			{
				Vector3 val = (_04FE91AB81EE4260(item) ? item.ClosestPoint(P_0) : item.ClosestPointOnBounds(P_0));
				Vector3 val2 = P_0 - val;
				float sqrMagnitude = val2.sqrMagnitude;
				if (sqrMagnitude < num)
				{
					num = sqrMagnitude;
				}
			}
		}
		if (num == float.MaxValue)
		{
			return 0f;
		}
		return Mathf.Sqrt(num);
	}

	public static float AFDAF7F618374BA0(Transform P_0, Vector3 P_1, int P_2)
	{
		if (FA614F32E31A4FDD._8F4115917F6F414D(P_0, out FA614F32E31A4FDD._041C68EA4DEF4ECB[] array))
		{
			return FA614F32E31A4FDD.F62E764B646B414A(P_0, in P_1, array, P_2);
		}
		if (!_22A1896F79EB41C2(P_0))
		{
			return 0f;
		}
		return _713742BC87CA41AC(in P_1, P_2);
	}

	public static bool B8383F2716824CB2(ERaycastInfoType P_0, ELimb P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Invalid comparison between Unknown and I4
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		if ((int)P_0 == 3)
		{
			if ((int)P_1 == 0)
			{
				return true;
			}
			if ((int)P_1 == 10)
			{
				return true;
			}
			if ((int)P_1 == 8)
			{
				return true;
			}
			if ((int)P_1 == 4)
			{
				return true;
			}
			if ((int)P_1 == 2)
			{
				return true;
			}
			if ((int)P_1 == 11)
			{
				return true;
			}
			if ((int)P_1 == 9)
			{
				return true;
			}
			if ((int)P_1 == 6)
			{
				return true;
			}
		}
		return false;
	}

	public static bool _04FE91AB81EE4260(Collider P_0)
	{
		if (!(P_0 is BoxCollider) && !(P_0 is SphereCollider) && !(P_0 is CapsuleCollider))
		{
			MeshCollider val = (MeshCollider)(object)((P_0 is MeshCollider) ? P_0 : null);
			if (val != null)
			{
				return val.convex;
			}
			return false;
		}
		return true;
	}

	public static Bounds A80B7E2F0E1B440B(Vector3 P_0, Vector3 P_1, Quaternion P_2)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		Matrix4x4 val = Matrix4x4.Rotate(P_2);
		Vector3 val2 = new Vector3(Mathf.Abs(val.m00) * P_1.x + Mathf.Abs(val.m01) * P_1.y + Mathf.Abs(val.m02) * P_1.z, Mathf.Abs(val.m10) * P_1.x + Mathf.Abs(val.m11) * P_1.y + Mathf.Abs(val.m12) * P_1.z, Mathf.Abs(val.m20) * P_1.x + Mathf.Abs(val.m21) * P_1.y + Mathf.Abs(val.m22) * P_1.z) * 2f;
		return new Bounds(P_0, val2);
	}

	public static float D35C65BF560949CF(in Bounds P_0, in Bounds P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		Bounds val = P_0;
		Vector3 min = val.min;
		val = P_0;
		Vector3 max = val.max;
		val = P_1;
		Vector3 min2 = val.min;
		val = P_1;
		Vector3 max2 = val.max;
		float num = Mathf.Max(0f, Mathf.Max(min.x - max2.x, min2.x - max.x));
		float num2 = Mathf.Max(0f, Mathf.Max(min.y - max2.y, min2.y - max.y));
		float num3 = Mathf.Max(0f, Mathf.Max(min.z - max2.z, min2.z - max.z));
		return num * num + num2 * num2 + num3 * num3;
	}

	public static float E4153A33B27E4C71(in Bounds P_0, in Bounds P_1)
	{
		return Mathf.Sqrt(D35C65BF560949CF(in P_0, in P_1));
	}

	public static float A026CE8FA25C4CB8(Vector3 P_0, Vector3 P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (Vector3.Distance(P_0, P_1) < 0.01f)
		{
			return 0f;
		}
		return Vector3.Angle(P_0, P_1);
	}

	public static bool _07BEDFFE3B604170(float P_0)
	{
		return _47C3AA91C6B94D1E(P_0, 0.005f);
	}

	public static bool _47C3AA91C6B94D1E(float P_0, float P_1)
	{
		if (_43064443A9074303(P_0, 0f, P_1) || _43064443A9074303(P_0, 180f, P_1))
		{
			return true;
		}
		if (_43064443A9074303(P_0, 45f, P_1) || _43064443A9074303(P_0, 100f, P_1))
		{
			return true;
		}
		if (_43064443A9074303(P_0, 45f, P_1) || _43064443A9074303(P_0, 135f, P_1))
		{
			return true;
		}
		if (_43064443A9074303(P_0, 20f, P_1) || _43064443A9074303(P_0, 160f, P_1))
		{
			return true;
		}
		if (_43064443A9074303(P_0, 60f, P_1) || _43064443A9074303(P_0, 120f, P_1))
		{
			return true;
		}
		return false;
	}

	private static bool _43064443A9074303(float P_0, float P_1, float P_2)
	{
		return Mathf.Abs(P_0 - P_1) <= P_2;
	}

	public static string _9EF78793AEAE41AB(float P_0)
	{
		TimeSpan timeSpan = TimeSpan.FromSeconds(P_0);
		string text = string.Empty;
		if (timeSpan.Days > 0)
		{
			text += $"{timeSpan.Days} d.";
		}
		if (timeSpan.Hours > 0)
		{
			if (!string.IsNullOrEmpty(text))
			{
				text += " ";
			}
			text += $"{timeSpan.Hours} h.";
		}
		if (timeSpan.Minutes > 0)
		{
			if (!string.IsNullOrEmpty(text))
			{
				text += " ";
			}
			text += $"{timeSpan.Minutes} m.";
		}
		if (!string.IsNullOrEmpty(text))
		{
			text += " ";
		}
		return text + $"{timeSpan.Seconds} s.";
	}

	public static bool _8D8FC23C9FAA4540(Quaternion P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		if (!float.IsNaN(P_0.x) && !float.IsInfinity(P_0.x) && !float.IsNaN(P_0.y) && !float.IsInfinity(P_0.y) && !float.IsNaN(P_0.z) && !float.IsInfinity(P_0.z) && !float.IsNaN(P_0.w))
		{
			return !float.IsInfinity(P_0.w);
		}
		return false;
	}

	public static bool _9849D016EBC24F95(bool P_0, InputInfo P_1)
	{
		if (Mathf.Abs(P_1.normal.magnitude - 1f) > 0.005f)
		{
			return true;
		}
		if (P_0)
		{
			return Mathf.Abs(P_1.direction.magnitude - 1f) > 0.005f;
		}
		return false;
	}

	public static bool _079E8C19685F4DD4(InputInfo P_0)
	{
		if (P_0.normal.x == 1f && P_0.normal.y == 0f)
		{
			return P_0.normal.z == 0f;
		}
		return false;
	}

	public static Vector3 _7FC4D441AD394AD8(A3116505AAB24996 P_0, Vector3 P_1, Vector3 P_2, Vector3 P_3, float P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		Quaternion val = Quaternion.LookRotation(P_3);
		Quaternion val2 = Quaternion.Euler(0f, 0f, P_4 * HumanAnimator.LEAN);
		return P_1 + Quaternion.Euler(0f, val.eulerAngles.y, 0f) * (val2 * P_2);
	}

	public static Bounds _79FF44A168A24F7A(_0732D1C8FF584BB5.BACE3A97F70C46B0 P_0)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (P_0._867A75B3EDD34DB1)
		{
			return new Bounds(P_0.BCF717E56F1C4757, _3363F58FE3564799);
		}
		Matrix4x4 val = Matrix4x4.Rotate(P_0.B6BA11EF2DE84A0B);
		Vector3 val2 = new Vector3(Mathf.Abs(val.m00) * F5C7EB2E62AE4D65.x + Mathf.Abs(val.m01) * F5C7EB2E62AE4D65.y + Mathf.Abs(val.m02) * F5C7EB2E62AE4D65.z, Mathf.Abs(val.m10) * F5C7EB2E62AE4D65.x + Mathf.Abs(val.m11) * F5C7EB2E62AE4D65.y + Mathf.Abs(val.m12) * F5C7EB2E62AE4D65.z, Mathf.Abs(val.m20) * F5C7EB2E62AE4D65.x + Mathf.Abs(val.m21) * F5C7EB2E62AE4D65.y + Mathf.Abs(val.m22) * F5C7EB2E62AE4D65.z) * 2f;
		return new Bounds(P_0.BCF717E56F1C4757 + val.MultiplyPoint3x4(_751B30646A8C4BD2), val2);
	}

	public static bool CFAE6A363DB74C8E(InteractableVehicle P_0, Collider P_1, out bool P_2)
	{
		P_2 = false;
		for (byte b = 0; b < P_0.passengers.Length; b++)
		{
			Passenger val = P_0.passengers[b];
			if (val != null)
			{
				CapsuleCollider val2 = _64A4BBC5E4CE4EE1._12E2FB22CF7C43A8.Invoke(val);
				if (!((Object)(object)val2 == (Object)null) && (Object)(object)val2 == (Object)(object)P_1)
				{
					P_2 = b == 0;
					return true;
				}
			}
		}
		return false;
	}
}
