using System;
using System.Collections.Generic;
using System.Reflection;
using HarmonyLib;
using SDG.Framework.Water;
using SDG.Unturned;
using UnityEngine;

internal class _1187FAD6AB3F40BD
{
	private struct _38B4BCCED42D47E5
	{
		public Collider _0375F74953394CC9;

		public Vector3 _7F72C865A854410C;

		public Vector3 _151BEC4459B94A6F;

		public Vector3 F2B0439050054303;

		public Quaternion _3EC596E17F824CE0;
	}

	public struct _24FCA214DF144211
	{
		public float BCFADB9DBA5046B2;

		public float B0400B656E174CFF;

		public float _704A9699F0F841A0;

		public int _736276B1DE6B437E;

		public int D1FEEC78C4574F96;

		public int _33FDB0B56FF44938;

		public int _868B8EC3122A4788;

		public string? _831CDD28B3334ED3;

		public int _2075AB1574864CD3;

		public string? _125E41DDDACD4BB4;

		public Vector3 _3BA29E39A1C84E78;

		public string? _2C2EBDFA04F64CF8;

		public float _66C285F040784DEA;

		public Vector3 _26A6A001B15543E6;

		public float _265951FB987C48A7;

		public float CA2A01D1C2C04068;

		public float _3F7DEBF52DD04720;

		public bool F79F396EC5B74A3A;

		public float _98A8CF7E90F24993;
	}

	public struct EC42C732153F478D
	{
		public _8068FDD7ED1B4A4D CE91CF7E1A224A8D;

		public int _444D47266C31484C;

		public int C7A747A4225344F9;

		public int A36F51F04D5A4752;

		public float _8B7E5BEBEA7D4EAB;

		public int F7E6157E550F4697;

		public float _9361EBEFD8994F07;

		public float D68DF0192596499A;

		public Vector3 _3A413409431848D6;

		public float C9843BA935AD44AB;

		public string? _1FA9FF460BAB4839;
	}

	private static readonly Type _97DB471A4E0B430C = AccessTools.TypeByName("SDG.Unturned.LevelObjectRefComponent");

	private static readonly FieldInfo _0607231E95024203 = AccessTools.Field(_97DB471A4E0B430C, "levelObjectOwner");

	private static readonly FieldRef<object, LevelObject> E898F820C9EE41EE = AccessTools.FieldRefAccess<object, LevelObject>(_0607231E95024203);

	private static readonly FieldRef<ObjectAsset, NPCConditionsList> B4E46D0AF09542A0 = AccessTools.FieldRefAccess<ObjectAsset, NPCConditionsList>("visibilityConditionsList");

	private static readonly int _9CFCA7CA130D499D = 406437888;

	private static readonly int DC66C01CC54C4F44 = 1480179712;

	private static readonly int _84CF1CE0EA8A4046 = 404324352;

	private static readonly Collider[] _00E9B9C0FE7C4E06 = new Collider[128];

	private static readonly RaycastHit[] _7D7592C2AEB94E36 = new RaycastHit[128];

	private const float F8120404588840D2 = 0.05f;

	private const float _9AA242E85AD34632 = 0.02f;

	private static readonly List<_38B4BCCED42D47E5> _7D995DA4D2FB4B6A = new List<_38B4BCCED42D47E5>();

	private static readonly Dictionary<ushort, (Vector3 tensor, Quaternion rotation)> _0ED34BBFD6C241BF = new Dictionary<ushort, (Vector3, Quaternion)>();

	internal static bool BF70874A6B034E9A = false;

	public static bool _739EFC5D5557461E(int P_0)
	{
		return (DC66C01CC54C4F44 & (1 << P_0)) != 0;
	}

	public static bool _566147A1CCDD4F15(int P_0)
	{
		return (_84CF1CE0EA8A4046 & (1 << P_0)) != 0;
	}

	public static bool D58FF514B9754D06(int P_0)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((_9CFCA7CA130D499D & (1 << i)) != 0 && !Physics.GetIgnoreLayerCollision(P_0, i))
			{
				return true;
			}
		}
		return false;
	}

	public static bool A67FA565DF2B4DD8(A3116505AAB24996 P_0, InteractableVehicle P_1, Vector3 P_2, Quaternion P_3)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		Transform transform = ((Component)P_1).transform;
		Vector3 lossyScale = transform.lossyScale;
		Quaternion val = Quaternion.Inverse(transform.rotation);
		foreach (Collider item in P_0._965694AA41EB4336.F0CE0620916B414A)
		{
			if (_6965F2576A0D4CFA(P_1, item, transform, lossyScale, val, P_2, P_3))
			{
				return true;
			}
		}
		return false;
	}

	private static bool _6965F2576A0D4CFA(InteractableVehicle P_0, Collider P_1, Transform P_2, Vector3 P_3, Quaternion P_4, Vector3 P_5, Quaternion P_6)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		Transform transform = ((Component)P_1).transform;
		Vector3 val = P_2.InverseTransformPoint(transform.position);
		Quaternion val2 = P_4 * transform.rotation;
		Vector3 val3 = P_5 + P_6 * Vector3.Scale(val, P_3);
		Quaternion val4 = P_6 * val2;
		Vector3 lossyScale = transform.lossyScale;
		Vector3 val5 = new Vector3(Mathf.Abs(lossyScale.x), Mathf.Abs(lossyScale.y), Mathf.Abs(lossyScale.z));
		BoxCollider val6 = (BoxCollider)(object)((P_1 is BoxCollider) ? P_1 : null);
		Vector3 val10;
		Vector3 val11;
		Quaternion val12;
		int num;
		if (val6 == null)
		{
			SphereCollider val7 = (SphereCollider)(object)((P_1 is SphereCollider) ? P_1 : null);
			if (val7 == null)
			{
				CapsuleCollider val8 = (CapsuleCollider)(object)((P_1 is CapsuleCollider) ? P_1 : null);
				if (val8 == null)
				{
					MeshCollider val9 = (MeshCollider)(object)((P_1 is MeshCollider) ? P_1 : null);
					if (val9 == null || !val9.convex || !((Object)(object)val9.sharedMesh != (Object)null))
					{
						return false;
					}
					Bounds bounds = val9.sharedMesh.bounds;
					val10 = val3 + val4 * Vector3.Scale(bounds.center, lossyScale);
					val11 = Vector3.Scale(bounds.extents, val5) + Vector3.one * 0.1f;
					val12 = val4;
					num = Physics.OverlapBoxNonAlloc(val10, val11, _00E9B9C0FE7C4E06, val4, DC66C01CC54C4F44, (QueryTriggerInteraction)1);
				}
				else
				{
					val10 = val3 + val4 * Vector3.Scale(val8.center, lossyScale);
					Vector3 capsuleLocalDirection = CapsuleColliderEx.GetCapsuleLocalDirection(val8);
					float num2 = Mathf.Abs(Vector3.Dot(val5, capsuleLocalDirection));
					float num3 = Mathf.Max(val5.x * (1f - Mathf.Abs(capsuleLocalDirection.x)), Mathf.Max(val5.y * (1f - Mathf.Abs(capsuleLocalDirection.y)), val5.z * (1f - Mathf.Abs(capsuleLocalDirection.z))));
					float num4 = val8.radius * num3 + 0.1f;
					float num5 = Mathf.Max(0f, val8.height * 0.5f * num2 - val8.radius * num3);
					Vector3 val13 = val4 * capsuleLocalDirection;
					val11 = Vector3.one * num4 + new Vector3(Mathf.Abs(val13.x), Mathf.Abs(val13.y), Mathf.Abs(val13.z)) * num5;
					val12 = Quaternion.identity;
					num = Physics.OverlapCapsuleNonAlloc(val10 - val13 * num5, val10 + val13 * num5, num4, _00E9B9C0FE7C4E06, DC66C01CC54C4F44, (QueryTriggerInteraction)1);
				}
			}
			else
			{
				val10 = val3 + val4 * Vector3.Scale(val7.center, lossyScale);
				float num6 = val7.radius * Mathf.Max(val5.x, Mathf.Max(val5.y, val5.z)) + 0.1f;
				val11 = Vector3.one * num6;
				val12 = Quaternion.identity;
				num = Physics.OverlapSphereNonAlloc(val10, num6, _00E9B9C0FE7C4E06, DC66C01CC54C4F44, (QueryTriggerInteraction)1);
			}
		}
		else
		{
			val10 = val3 + val4 * Vector3.Scale(val6.center, lossyScale);
			val11 = Vector3.Scale(val6.size * 0.5f, val5) + Vector3.one * 0.1f;
			val12 = val4;
			num = Physics.OverlapBoxNonAlloc(val10, val11, _00E9B9C0FE7C4E06, val4, DC66C01CC54C4F44, (QueryTriggerInteraction)1);
		}
		for (int i = 0; i < num; i++)
		{
			if (!((Component)((Component)_00E9B9C0FE7C4E06[i]).transform.root).CompareTag("Vehicle"))
			{
				return true;
			}
		}
		Bounds val14 = _9AB67761792440A7.A80B7E2F0E1B440B(val10, val11, val12);
		foreach (var (num8, obj2) in _2A320E2F1A3D4AAC._2854C72CF5B5446D._0442BACC6B2A4332)
		{
			if (num8 == P_0.instanceID)
			{
				continue;
			}
			Bounds? val15 = _2A320E2F1A3D4AAC._2854C72CF5B5446D._304D068D6E744D79(obj2);
			if (val15.HasValue)
			{
				Bounds value = val15.Value;
				if (value.Intersects(val14))
				{
					return true;
				}
			}
		}
		if (_2A320E2F1A3D4AAC._2854C72CF5B5446D._777E0ECC9E4A47E3.F912CB261E164317 > 0)
		{
			using Queue<_0732D1C8FF584BB5._46973BD565ED4E94>.Enumerator enumerator2 = _2A320E2F1A3D4AAC._2854C72CF5B5446D._777E0ECC9E4A47E3.A2A766451ED44A51();
			while (enumerator2.MoveNext())
			{
				foreach (Bounds item in enumerator2.Current._303A3B95A94A4719)
				{
					Bounds current = item;
					if (current.Intersects(val14))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private static bool _3164953A708C4418(A3116505AAB24996 P_0, InteractableVehicle P_1, List<Collider> P_2, out Vector3 P_3, out Vector3 P_4)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		P_3 = Vector3.zero;
		P_4 = Vector3.zero;
		Transform transform = ((Component)P_1).transform;
		Vector3 lossyScale = transform.lossyScale;
		Vector3 val = new Vector3(Mathf.Abs(lossyScale.x), Mathf.Abs(lossyScale.y), Mathf.Abs(lossyScale.z));
		Quaternion val2 = Quaternion.Inverse(transform.rotation);
		_7D995DA4D2FB4B6A.Clear();
		Vector3 val3 = Vector3.positiveInfinity;
		Vector3 val4 = Vector3.negativeInfinity;
		foreach (Collider item in P_2)
		{
			if (_81A4CC2F49C040DA(item, out var val5, out var val6))
			{
				Vector3 val7 = (val5 + val6) * 0.5f;
				Vector3 val8 = Vector3.Max(Vector3.Scale((val6 - val5) * 0.5f, val) - Vector3.one * 0.05f, Vector3.one * 0.01f);
				Transform transform2 = ((Component)item).transform;
				Vector3 val9 = Vector3.Scale(transform.InverseTransformPoint(transform2.TransformPoint(val7)), lossyScale);
				_7D995DA4D2FB4B6A.Add(new _38B4BCCED42D47E5
				{
					_0375F74953394CC9 = item,
					_7F72C865A854410C = val9,
					_151BEC4459B94A6F = val8,
					F2B0439050054303 = Vector3.Scale(transform.InverseTransformPoint(transform2.position), lossyScale),
					_3EC596E17F824CE0 = val2 * transform2.rotation
				});
				val3 = Vector3.Min(val3, val9 - val8);
				val4 = Vector3.Max(val4, val9 + val8);
			}
		}
		if (_7D995DA4D2FB4B6A.Count == 0)
		{
			return false;
		}
		P_3 = (val3 + val4) * 0.5f;
		P_4 = (val4 - val3) * 0.5f;
		return true;
	}

	public static bool EBAE00EFCB7849E4(A3116505AAB24996 P_0, InteractableVehicle P_1, Vector3 P_2, Quaternion P_3, Vector3 P_4, Quaternion P_5, out string P_6, out float P_7)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		bool result = F27D0BA280974985(P_0, P_1, P_2, P_3, P_4, P_5, false, out var obj);
		P_6 = obj._831CDD28B3334ED3 ?? "";
		P_7 = obj._66C285F040784DEA;
		return result;
	}

	public static bool _250BEFC7C7AA4F04(A3116505AAB24996 P_0, InteractableVehicle P_1, Vector3 P_2, Quaternion P_3, Vector3 P_4, Quaternion P_5, out _24FCA214DF144211 P_6)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return F27D0BA280974985(P_0, P_1, P_2, P_3, P_4, P_5, true, out P_6);
	}

	private static bool F27D0BA280974985(A3116505AAB24996 P_0, InteractableVehicle P_1, Vector3 P_2, Quaternion P_3, Vector3 P_4, Quaternion P_5, bool P_6, out _24FCA214DF144211 P_7)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		P_7 = default;
		Transform transform = ((Component)P_1).transform;
		Vector3 lossyScale = transform.lossyScale;
		Vector3 val = new Vector3(Mathf.Abs(lossyScale.x), Mathf.Abs(lossyScale.y), Mathf.Abs(lossyScale.z));
		float num = Vector3.Distance(P_2, P_4) + Quaternion.Angle(P_3, P_5) * (MathF.PI / 180f) * val.magnitude;
		float num2 = Time.fixedDeltaTime / PlayerInput.RATE;
		float num3 = num * num2 + 0.05f;
		P_7.B0400B656E174CFF = num;
		P_7._704A9699F0F841A0 = num2;
		P_7.BCFADB9DBA5046B2 = num3;
		if (!_3164953A708C4418(P_0, P_1, P_0._965694AA41EB4336._4AEC7A8C281646EB, out var val2, out var val3))
		{
			return false;
		}
		if (Physics.OverlapBoxNonAlloc(P_4 + P_5 * val2, val3, _00E9B9C0FE7C4E06, P_5, _9CFCA7CA130D499D, (QueryTriggerInteraction)1) == 0)
		{
			return false;
		}
		float num4 = 0f;
		bool flag = false;
		Collider val4 = null;
		_38B4BCCED42D47E5 obj = default;
		Vector3 val5 = Vector3.zero;
		Vector3 val7 = default;
		float num6 = default;
		foreach (_38B4BCCED42D47E5 item in _7D995DA4D2FB4B6A)
		{
			int num5 = Physics.OverlapBoxNonAlloc(P_4 + P_5 * item._7F72C865A854410C, item._151BEC4459B94A6F, _00E9B9C0FE7C4E06, P_5, _9CFCA7CA130D499D, (QueryTriggerInteraction)1);
			for (int i = 0; i < num5; i++)
			{
				Collider val6 = _00E9B9C0FE7C4E06[i];
				if (((Component)((Component)val6).transform.root).CompareTag("Vehicle"))
				{
					continue;
				}
				P_7._736276B1DE6B437E++;
				if (!Physics.ComputePenetration(item._0375F74953394CC9, P_4 + P_5 * item.F2B0439050054303, P_5 * item._3EC596E17F824CE0, val6, ((Component)val6).transform.position, ((Component)val6).transform.rotation, ref val7, ref num6))
				{
					continue;
				}
				float num7 = item._0375F74953394CC9.contactOffset + val6.contactOffset;
				if (num6 <= num7)
				{
					continue;
				}
				P_7.D1FEEC78C4574F96++;
				if (!P_6 && num6 <= num4)
				{
					continue;
				}
				if (_9AB67761792440A7.ADE95AC79DC44882(((Component)val6).transform) || C26F4FFE24DD4D6B(val6) || B0225E3F6257443A(((Component)val6).transform))
				{
					P_7._33FDB0B56FF44938++;
					continue;
				}
				ICraftingTagProvider componentInParent = ((Component)val6).GetComponentInParent<ICraftingTagProvider>();
				Asset obj2 = ((componentInParent != null) ? componentInParent.GetTagProviderAsset() : null);
				ObjectAsset val8 = (ObjectAsset)(object)((obj2 is ObjectAsset) ? obj2 : null);
				if (val8 != null && val8.IsClutter)
				{
					P_7._33FDB0B56FF44938++;
					continue;
				}
				if (num6 > num3)
				{
					P_7._868B8EC3122A4788++;
					flag = true;
				}
				if (num6 > num4)
				{
					num4 = num6;
					val4 = val6;
					obj = item;
					val5 = val7;
					P_7._3F7DEBF52DD04720 = num7;
				}
				if (!P_6 & flag)
				{
					_22F0B0ED43994887(ref P_7, num4, val4, in obj, val5, false, transform, P_2, P_3, P_4, P_5);
					return true;
				}
			}
		}
		_22F0B0ED43994887(ref P_7, num4, val4, in obj, val5, P_6, transform, P_2, P_3, P_4, P_5);
		return flag;
	}

	private static void _22F0B0ED43994887(ref _24FCA214DF144211 P_0, float P_1, Collider? P_2, in _38B4BCCED42D47E5 P_3, Vector3 P_4, bool P_5, Transform P_6, Vector3 P_7, Quaternion P_8, Vector3 P_9, Quaternion P_10)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		P_0._66C285F040784DEA = P_1;
		if (P_2 == null)
		{
			return;
		}
		P_0._831CDD28B3334ED3 = ((Object)P_2).name;
		if (P_5)
		{
			P_0._2075AB1574864CD3 = ((Component)P_2).gameObject.layer;
			Bounds bounds = P_2.bounds;
			P_0._3BA29E39A1C84E78 = bounds.size;
			P_0._2C2EBDFA04F64CF8 = ((Object)P_3._0375F74953394CC9).name;
			string text;
			if (!(P_2 is TerrainCollider))
			{
				MeshCollider val = (MeshCollider)(object)((P_2 is MeshCollider) ? P_2 : null);
				if (val != null)
				{
					text = (val.convex ? "MeshConvex" : "MeshConcave");
				}
				else if (P_2 is BoxCollider)
				{
					text = "Box";
				}
				else if (P_2 is SphereCollider)
				{
					text = "Sphere";
				}
				else
				{
					text = ((!(P_2 is CapsuleCollider)) ? ((object)P_2).GetType().Name : "Capsule");
				}
			}
			else
			{
				text = "Terrain";
			}
			P_0._125E41DDDACD4BB4 = text;
			Vector3 val2 = default;
			float num = default;
			if (Physics.ComputePenetration(P_3._0375F74953394CC9, P_7 + P_8 * P_3.F2B0439050054303, P_8 * P_3._3EC596E17F824CE0, P_2, ((Component)P_2).transform.position, ((Component)P_2).transform.rotation, ref val2, ref num))
			{
				P_0._265951FB987C48A7 = num;
			}
			Vector3 position = P_6.position;
			Quaternion rotation = P_6.rotation;
			float cA2A01D1C2C = default;
			if (Physics.ComputePenetration(P_3._0375F74953394CC9, position + rotation * P_3.F2B0439050054303, rotation * P_3._3EC596E17F824CE0, P_2, ((Component)P_2).transform.position, ((Component)P_2).transform.rotation, ref val2, ref cA2A01D1C2C))
			{
				P_0.CA2A01D1C2C04068 = cA2A01D1C2C;
			}
			P_0._26A6A001B15543E6 = ((P_4.sqrMagnitude > 1E-08f) ? P_4.normalized : Vector3.zero);
			Vector3 val3 = P_7 + P_8 * P_3._7F72C865A854410C;
			Vector3 val4 = P_9 + P_10 * P_3._7F72C865A854410C - val3;
			float magnitude = val4.magnitude;
			RaycastHit val5 = default;
			if (magnitude > 0.0001f && P_2.Raycast(new Ray(val3, val4 / magnitude), ref val5, magnitude))
			{
				P_0.F79F396EC5B74A3A = true;
				P_0._98A8CF7E90F24993 = val5.distance;
			}
		}
	}

	public static bool A4BB2285DB2946ED(Wheel P_0, InteractableVehicle P_1, Vector3 P_2, Quaternion P_3)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		EC42C732153F478D eC42C732153F478D;
		return _66F3D7AE68A14B68(P_0, P_1, P_2, P_3, false, out eC42C732153F478D);
	}

	public static bool A8A3594975F047AC(Wheel P_0, InteractableVehicle P_1, Vector3 P_2, Quaternion P_3, out EC42C732153F478D P_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return _66F3D7AE68A14B68(P_0, P_1, P_2, P_3, true, out P_4);
	}

	private static bool _66F3D7AE68A14B68(Wheel P_0, InteractableVehicle P_1, Vector3 P_2, Quaternion P_3, bool P_4, out EC42C732153F478D P_5)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		P_5 = default;
		P_5._8B7E5BEBEA7D4EAB = -1f;
		if ((Object)(object)P_0.wheel == (Object)null)
		{
			P_5.CE91CF7E1A224A8D = _8068FDD7ED1B4A4D.NoCollider;
			return true;
		}
		Vector3 lossyScale = ((Component)P_0.wheel).transform.lossyScale;
		float num = Mathf.Max(new float[3]
		{
			Mathf.Abs(lossyScale.x),
			Mathf.Abs(lossyScale.y),
			Mathf.Abs(lossyScale.z)
		});
		Vector3 lossyScale2 = ((Component)P_1).transform.lossyScale;
		Vector3 val = ((Component)P_1).transform.InverseTransformPoint(((Component)P_0.wheel).transform.TransformPoint(P_0.wheel.center));
		Vector3 val2 = P_2 + P_3 * Vector3.Scale(val, lossyScale2);
		Vector3 val3 = P_3 * Vector3.up;
		float num2 = P_0.wheel.radius * num;
		float num3 = P_0.wheel.suspensionDistance * num;
		float num4 = num2 + 0.05f;
		int num5 = (P_5._444D47266C31484C = Physics.SphereCastNonAlloc(val2 + val3 * num4, num2, -val3, _7D7592C2AEB94E36, num4 + num3 + 0.02f, _84CF1CE0EA8A4046, (QueryTriggerInteraction)1));
		P_5._9361EBEFD8994F07 = num2;
		P_5.D68DF0192596499A = num3;
		P_5._3A413409431848D6 = val2;
		for (int i = 0; i < num5; i++)
		{
			RaycastHit val4 = _7D7592C2AEB94E36[i];
			if (((Component)val4.transform.root).CompareTag("Vehicle"))
			{
				P_5.C7A747A4225344F9++;
				continue;
			}
			Vector3 normal = val4.normal;
			if (normal.sqrMagnitude <= 0.0001f)
			{
				P_5.CE91CF7E1A224A8D = _8068FDD7ED1B4A4D.GroundedDegenerate;
				P_5.C9843BA935AD44AB = val4.distance;
				if (P_4)
				{
					P_5._1FA9FF460BAB4839 = ((Object)val4.collider).name;
				}
				return false;
			}
			float num6 = Vector3.Angle(val4.normal, val3);
			if (num6 > 60f)
			{
				P_5.A36F51F04D5A4752++;
				if (num6 > P_5._8B7E5BEBEA7D4EAB)
				{
					P_5._8B7E5BEBEA7D4EAB = num6;
				}
				P_5.F7E6157E550F4697 |= 1 << ((Component)val4.collider).gameObject.layer;
				continue;
			}
			P_5.CE91CF7E1A224A8D = _8068FDD7ED1B4A4D.Grounded;
			P_5.C9843BA935AD44AB = val4.distance;
			if (P_4)
			{
				P_5._1FA9FF460BAB4839 = ((Object)val4.collider).name;
			}
			return false;
		}
		float num7 = (P_0.wheel.radius + P_0.wheel.suspensionDistance) * num;
		using (Queue<_0732D1C8FF584BB5._46973BD565ED4E94>.Enumerator enumerator = _2A320E2F1A3D4AAC._2854C72CF5B5446D._777E0ECC9E4A47E3.A2A766451ED44A51())
		{
			while (enumerator.MoveNext())
			{
				foreach (Bounds item in enumerator.Current.E263A30D298E4689)
				{
					Bounds current = item;
					if (current.SqrDistance(val2) <= num7 * num7)
					{
						P_5.CE91CF7E1A224A8D = _8068FDD7ED1B4A4D.GroundedRecentDestroy;
						return false;
					}
				}
			}
		}
		P_5.CE91CF7E1A224A8D = ((num5 == 0) ? _8068FDD7ED1B4A4D.NoHits : _8068FDD7ED1B4A4D.AllRejected);
		return true;
	}

	public static bool _5611D904424148FF(InteractableVehicle P_0, Vector3 P_1, Quaternion P_2)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (P_0.tires == null)
		{
			return false;
		}
		Wheel[] tires = P_0.tires;
		for (int i = 0; i < tires.Length; i++)
		{
			if (!A4BB2285DB2946ED(tires[i], P_0, P_1, P_2))
			{
				return true;
			}
		}
		return false;
	}

	internal static bool _81A4CC2F49C040DA(Collider P_0, out Vector3 P_1, out Vector3 P_2)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		BoxCollider val = (BoxCollider)(object)((P_0 is BoxCollider) ? P_0 : null);
		if (val == null)
		{
			SphereCollider val2 = (SphereCollider)(object)((P_0 is SphereCollider) ? P_0 : null);
			if (val2 == null)
			{
				CapsuleCollider val3 = (CapsuleCollider)(object)((P_0 is CapsuleCollider) ? P_0 : null);
				if (val3 == null)
				{
					MeshCollider val4 = (MeshCollider)(object)((P_0 is MeshCollider) ? P_0 : null);
					if (val4 != null && val4.convex && (Object)(object)val4.sharedMesh != (Object)null)
					{
						Bounds bounds = val4.sharedMesh.bounds;
						P_1 = bounds.min;
						bounds = val4.sharedMesh.bounds;
						P_2 = bounds.max;
						return true;
					}
					P_1 = (P_2 = Vector3.zero);
					return false;
				}
				Vector3 capsuleLocalDirection = CapsuleColliderEx.GetCapsuleLocalDirection(val3);
				float num = Mathf.Max(val3.height * 0.5f, val3.radius);
				Vector3 val5 = new Vector3(Mathf.Lerp(val3.radius, num, Mathf.Abs(capsuleLocalDirection.x)), Mathf.Lerp(val3.radius, num, Mathf.Abs(capsuleLocalDirection.y)), Mathf.Lerp(val3.radius, num, Mathf.Abs(capsuleLocalDirection.z)));
				P_1 = val3.center - val5;
				P_2 = val3.center + val5;
				return true;
			}
			P_1 = val2.center - Vector3.one * val2.radius;
			P_2 = val2.center + Vector3.one * val2.radius;
			return true;
		}
		P_1 = val.center - val.size * 0.5f;
		P_2 = val.center + val.size * 0.5f;
		return true;
	}

	private static bool C26F4FFE24DD4D6B(Collider P_0)
	{
		if (_2A320E2F1A3D4AAC._2854C72CF5B5446D._9C9BA43C8C834495.F912CB261E164317 == 0)
		{
			return false;
		}
		using (Queue<_0732D1C8FF584BB5._00AE748AAABE4B0F>.Enumerator enumerator = _2A320E2F1A3D4AAC._2854C72CF5B5446D._9C9BA43C8C834495.A2A766451ED44A51())
		{
			while (enumerator.MoveNext())
			{
				foreach (Collider item in enumerator.Current.BF78DD9D05D344AF)
				{
					if ((Object)(object)item == (Object)(object)P_0)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private static bool B0225E3F6257443A(Transform P_0)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		Component componentInParent = ((Component)P_0).GetComponentInParent(_97DB471A4E0B430C);
		if ((Object)(object)componentInParent != (Object)null)
		{
			LevelObject val = E898F820C9EE41EE.Invoke((object)componentInParent);
			if (val.asset != null)
			{
				NPCConditionsList val2 = B4E46D0AF09542A0.Invoke(val.asset);
				if (!val2.IsEmpty)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static void _52523C6B6BE140CA(InteractableVehicle P_0, Rigidbody P_1, Vector3 P_2, Quaternion P_3, Vector3 P_4, Vector3 P_5, out float P_6, out float P_7, out Vector3 P_8)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		P_6 = 0f;
		P_7 = 0f;
		P_8 = Vector3.zero;
		Wheel[] tires = P_0.tires;
		if (tires == null || tires.Length == 0)
		{
			return;
		}
		Transform transform = ((Component)P_0).transform;
		Vector3 lossyScale = transform.lossyScale;
		Vector3 val = Vector3.Scale(P_1.centerOfMass, lossyScale);
		float num = Mathf.Max(P_1.mass, 0.001f) / (float)tires.Length;
		float num2 = num * Mathf.Abs(Physics.gravity.y);
		Wheel[] array = tires;
		foreach (Wheel val2 in array)
		{
			WheelCollider wheel = val2.wheel;
			if (!((Object)(object)wheel == (Object)null) && !A4BB2285DB2946ED(val2, P_0, P_2, P_3))
			{
				Vector3 lossyScale2 = ((Component)wheel).transform.lossyScale;
				float num3 = Mathf.Max(Mathf.Abs(lossyScale2.x), Mathf.Max(Mathf.Abs(lossyScale2.y), Mathf.Abs(lossyScale2.z)));
				Vector3 val3 = transform.InverseTransformPoint(((Component)wheel).transform.TransformPoint(wheel.center));
				float num4 = (wheel.forceAppPointDistance - wheel.radius) * num3;
				Vector3 val4 = Vector3.Scale(val3, lossyScale) + Vector3.up * num4 - val;
				JointSpring suspensionSpring = wheel.suspensionSpring;
				float num5 = Mathf.Abs(wheel.suspensionDistance) * num3;
				float num6 = Mathf.Sqrt(Mathf.Abs(suspensionSpring.spring) / Mathf.Max(num5, 0.0001f) / num);
				float num7 = Mathf.Clamp01(Mathf.Clamp01(suspensionSpring.targetPosition) + num2 / Mathf.Max(Mathf.Abs(suspensionSpring.spring), 0.0001f));
				float num8 = Mathf.Max(num7, 1f - num7) * num5;
				float num9 = Mathf.Abs(P_4.y);
				float magnitude = P_5.magnitude;
				Vector2 val5 = new Vector2(val4.x, val4.z);
				float num10 = num9 + magnitude * val5.magnitude;
				float num11 = Mathf.Min(num8 * num6 + num10, num5 / Time.fixedDeltaTime);
				float num12 = Mathf.Abs(suspensionSpring.spring) * (1f - Mathf.Clamp01(suspensionSpring.targetPosition)) + Mathf.Abs(suspensionSpring.damper) * num11;
				WheelFrictionCurve val6 = wheel.forwardFriction;
				float num13 = Mathf.Abs(val6.extremumValue);
				val6 = wheel.forwardFriction;
				float num14 = Mathf.Max(num13, Mathf.Abs(val6.asymptoteValue)) * Mathf.Abs(val2.stiffnessForward);
				val6 = wheel.sidewaysFriction;
				float num15 = Mathf.Abs(val6.extremumValue);
				val6 = wheel.sidewaysFriction;
				float num16 = Mathf.Max(num14, Mathf.Max(num15, Mathf.Abs(val6.asymptoteValue)) * Mathf.Abs(val2.stiffnessSideways));
				float num17 = num12 * num16;
				P_6 += num12;
				P_7 = Mathf.Max(P_7, num16);
				P_8.x += num12 * Mathf.Abs(val4.z) + num17 * Mathf.Abs(val4.y);
				P_8.y += num17 * (Mathf.Abs(val4.x) + Mathf.Abs(val4.z));
				P_8.z += num12 * Mathf.Abs(val4.x) + num17 * Mathf.Abs(val4.y);
			}
		}
	}

	public static void A56A3381E61B4454(InteractableVehicle P_0)
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)P_0 == (Object)null || P_0.asset == null || _0ED34BBFD6C241BF.ContainsKey(((Asset)P_0.asset).id))
		{
			return;
		}
		Transform val = _64A4BBC5E4CE4EE1.CFB8EA5D392C40F4.Invoke(P_0);
		Wheel[] tires = P_0.tires;
		if ((tires == null || tires.Length == 0) && (Object)(object)val == (Object)null)
		{
			return;
		}
		if (tires != null)
		{
			Wheel[] array = tires;
			foreach (Wheel val2 in array)
			{
				if ((Object)(object)val2.wheel == (Object)null || !val2.isAlive || !((Component)val2.wheel).gameObject.activeInHierarchy)
				{
					return;
				}
			}
		}
		if (!((Object)(object)val != (Object)null) || ((Component)val).gameObject.activeInHierarchy)
		{
			Rigidbody val3 = _64A4BBC5E4CE4EE1._1666B192DD1445FB.Invoke(P_0);
			if (!((Object)(object)val3 == (Object)null))
			{
				_0ED34BBFD6C241BF[((Asset)P_0.asset).id] = (val3.inertiaTensor, val3.inertiaTensorRotation);
			}
		}
	}

	public static bool C0862A68BDFB4224(InteractableVehicle P_0, Rigidbody P_1, out Vector3 P_2, out Quaternion P_3)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		Wheel[] tires = P_0.tires;
		Transform val = _64A4BBC5E4CE4EE1.CFB8EA5D392C40F4.Invoke(P_0);
		if ((tires == null || tires.Length == 0) && (Object)(object)val == (Object)null)
		{
			P_2 = P_1.inertiaTensor;
			P_3 = P_1.inertiaTensorRotation;
			return true;
		}
		if (P_0.asset != null && _0ED34BBFD6C241BF.TryGetValue(((Asset)P_0.asset).id, out (Vector3, Quaternion) value))
		{
			if (tires != null)
			{
				Wheel[] array = tires;
				for (int i = 0; i < array.Length; i++)
				{
					if (!array[i].isAlive)
					{
						P_2 = P_1.inertiaTensor;
						P_3 = P_1.inertiaTensorRotation;
						return false;
					}
				}
			}
			(P_2, P_3) = value;
			return true;
		}
		P_2 = P_1.inertiaTensor;
		P_3 = P_1.inertiaTensorRotation;
		return false;
	}

	public static bool _335A18BA0BAC488D(InteractableVehicle P_0, Rigidbody P_1, List<ConstantForce> P_2, Quaternion P_3, out Vector3 P_4, out Vector3 P_5, out float P_6, out Vector3 P_7)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		P_4 = Vector3.zero;
		P_5 = Vector3.zero;
		P_6 = 0f;
		P_7 = Vector3.zero;
		if ((Object)(object)P_1 == (Object)null || P_2 == null || P_2.Count == 0)
		{
			return false;
		}
		float num = Mathf.Max(P_1.mass, 0.001f);
		Quaternion val = Quaternion.Inverse(P_3);
		bool flag = false;
		foreach (ConstantForce item in P_2)
		{
			if ((Object)(object)item == (Object)null)
			{
				continue;
			}
			Rigidbody component = ((Component)item).GetComponent<Rigidbody>();
			if (!((Object)(object)component == (Object)null))
			{
				if (!BF70874A6B034E9A || !((Object)(object)component == (Object)(object)P_1) || !((Behaviour)item).isActiveAndEnabled)
				{
					P_7 += (_763B1656BD6B4357(item.force) + _763B1656BD6B4357(P_3 * item.relativeForce)) / num;
					continue;
				}
				Vector3 val2 = P_3 * item.relativeForce;
				P_4 += (item.force + val2) / num;
				P_6 += val2.magnitude / num;
				P_5 += val * item.torque + item.relativeTorque;
				flag = true;
			}
		}
		if (!flag)
		{
			return P_7 != Vector3.zero;
		}
		return true;
	}

	private static Vector3 _763B1656BD6B4357(Vector3 P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		return new Vector3(Mathf.Abs(P_0.x), Mathf.Abs(P_0.y), Mathf.Abs(P_0.z));
	}

	public static bool _04F56088A7C24F32(InteractableVehicle P_0, Vector3 P_1, Quaternion P_2)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		Transform val = _64A4BBC5E4CE4EE1.CFB8EA5D392C40F4.Invoke(P_0);
		if ((Object)(object)val == (Object)null)
		{
			return false;
		}
		Transform transform = ((Component)P_0).transform;
		Vector3 lossyScale = transform.lossyScale;
		for (int i = 0; i < val.childCount; i++)
		{
			Transform child = val.GetChild(i);
			Buoyancy component = ((Component)child).GetComponent<Buoyancy>();
			BoxCollider component2 = ((Component)child).GetComponent<BoxCollider>();
			if ((Object)(object)component == (Object)null || (Object)(object)component2 == (Object)null || !((Behaviour)component).enabled)
			{
				continue;
			}
			int num = Mathf.Max(1, component.slicesPerAxis);
			Vector3 size = component2.size;
			Vector3 val2 = size * -0.5f;
			Vector3 val3 = size / (float)num;
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					for (int l = 0; l < num; l++)
					{
						Vector3 val4 = new Vector3(val2.x + val3.x * (0.5f + (float)j), val2.y + val3.y * (0.5f + (float)k), val2.z + val3.z * (0.5f + (float)l));
						Vector3 val5 = transform.InverseTransformPoint(child.TransformPoint(val4));
						if (WaterUtility.isPointUnderwater(P_1 + P_2 * Vector3.Scale(val5, lossyScale)))
						{
							return true;
						}
					}
				}
			}
		}
		return false;
	}

	public static void BB6377961E3F44CA(InteractableVehicle P_0, Rigidbody P_1, float P_2, out float P_3, out float P_4, out float P_5, out float P_6)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		P_3 = 0f;
		P_4 = 0f;
		P_5 = 0f;
		P_6 = 0f;
		Transform val = _64A4BBC5E4CE4EE1.CFB8EA5D392C40F4.Invoke(P_0);
		if ((Object)(object)val == (Object)null)
		{
			return;
		}
		Transform transform = ((Component)P_0).transform;
		Vector3 centerOfMass = P_1.centerOfMass;
		int num = 0;
		int num2 = 0;
		float num3 = 0f;
		for (int i = 0; i < val.childCount; i++)
		{
			Transform child = val.GetChild(i);
			Buoyancy component = ((Component)child).GetComponent<Buoyancy>();
			BoxCollider component2 = ((Component)child).GetComponent<BoxCollider>();
			if (!((Object)(object)component == (Object)null) && !((Object)(object)component2 == (Object)null) && ((Behaviour)component).enabled)
			{
				float num4 = 1000f * Mathf.Abs(Physics.gravity.y) / Mathf.Max(component.density, 1f);
				P_3 += num4;
				int num5 = Mathf.Max(1, component.slicesPerAxis);
				int num6 = num5 * num5 * num5;
				num += num6;
				Vector3 val2 = component2.size / (float)num5;
				float num7 = Mathf.Max(Mathf.Min(val2.x, Mathf.Min(val2.y, val2.z)) * 0.5f, 0.0001f);
				float num8 = 0.1f / (2f * num7);
				num3 += num4 * Mathf.Min(1f, num8 / (2f * Mathf.Sqrt(0.5f)));
				if (num7 < 0.1f)
				{
					num2 += num6;
				}
				Vector3 val3 = transform.TransformPoint(centerOfMass);
				Vector3 val4 = child.TransformPoint(component2.center);
				Vector3 val5 = Vector3.Scale(component2.size * 0.5f, child.lossyScale);
				float magnitude = val5.magnitude;
				float num9 = P_5;
				val5 = val4 - val3;
				P_5 = Mathf.Max(num9, val5.magnitude + magnitude);
			}
		}
		P_4 = 0.1f * (float)num;
		P_6 = num3 + 0.1f * (float)num2 * P_2;
	}
}
