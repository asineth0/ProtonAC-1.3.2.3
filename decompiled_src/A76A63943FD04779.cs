using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SDG.Unturned;
using UnityEngine;

internal class A76A63943FD04779
{
	public delegate void _133C560B942C4748(A3116505AAB24996 _0A3BD33B53D74FA2, UseableGun DC468E93DC584DB4, List<_4819911A0C0846FF._3147FDB5568446E9> _3B8CA343362F4455, InputInfo D1BE2D9E251D43FF, ref bool _905E77FC795646C1, ref bool _077EF09404D34FE5);

	public delegate void F268403FFFB4461D(UseableGun C334A0257BEA443F);

	private static readonly C4462CD02B8C4225 DFD3A2A221CF4036;

	private static readonly FieldInfo F9B0F4990F1D4879;

	private static readonly FieldInfo FA57E053C40C4C19;

	private static readonly FieldInfo E9E461D4306A4D26;

	private static readonly FieldInfo BA18FF8452884375;

	private static readonly FieldInfo _139AC42384D74A00;

	private static readonly MethodInfo _8C71B57CB10248BF;

	private static readonly MethodInfo _190F31E087CF41DC;

	private static readonly MethodInfo _96D739E9AC054140;

	private static readonly MethodInfo _1AE82A34D2B34943;

	private static readonly Dictionary<int, bool> F504A830D39749E7;

	public static _133C560B942C4748? _89D43889C2AB4B27;

	public static F268403FFFB4461D? _55A676AE7D2646A4;

	[_542A381FC1D44BA3(typeof(UseableGun), "ballistics", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _194FB9CEC442450F(UseableGun __instance)
	{
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)__instance).player);
		if (a3116505AAB == null)
		{
			return;
		}
		_4819911A0C0846FF obj = a3116505AAB._39063EF1442C4822;
		int num = ((!Provider.modeConfigData.Gameplay.Ballistics) ? 1 : __instance.equippedGunAsset.ballisticSteps);
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item in obj.F933B05D5259474E)
		{
			if (item.F9050CCFB6B5492C)
			{
				continue;
			}
			item.E18F5E0961B94988++;
			if (item.E18F5E0961B94988 < num + 1)
			{
				continue;
			}
			item.F9050CCFB6B5492C = true;
			a3116505AAB._638733A069E74AA4._067240C6E7D645F7++;
			if (a3116505AAB._638733A069E74AA4._067240C6E7D645F7 < 10)
			{
				continue;
			}
			IEnumerable<EA091ED8BF2C4A64.A868F02C1F7141CA> enumerable = a3116505AAB._638733A069E74AA4._080940434C504A7C.Take(10);
			C48614AC45154D95 c48614AC45154D = DFD3A2A221CF4036._3ECE4ABFF9E04BFF<C48614AC45154D95>();
			foreach (EA091ED8BF2C4A64.A868F02C1F7141CA item2 in enumerable)
			{
				float num2 = float.MaxValue;
				float num3 = float.MaxValue;
				float num4 = float.MaxValue;
				float num5 = float.MaxValue;
				float num6 = float.MaxValue;
				float num7 = float.MaxValue;
				float num8 = float.MaxValue;
				float num9 = float.MinValue;
				foreach (_4819911A0C0846FF._3147FDB5568446E9 item3 in item2._8B19A6E1795045B9)
				{
					float num10 = Vector3.Distance(item3._9EB9E2BEE74640DC._8B47B2B22D864C7B, item2.AE92804C67564138);
					float num11 = 2f * Mathf.Atan(1.65f / (2f * num10)) * 57.29578f;
					float num12 = ((num11 == 0f) ? float.MaxValue : (item3._979A197054D84450 / num11));
					float num13 = ((num11 == 0f) ? float.MaxValue : (Mathf.Max(0f, item3._7828A186B79F4E4F - item3._938D693909384ADF) / num11));
					float num14 = ((num11 == 0f) ? float.MaxValue : (Mathf.Max(0f, item3._8BCCCC895AFF484D - item3._88487C61ED4D49F8) / num11));
					float num15 = ((num11 == 0f) ? float.MaxValue : (item3._7828A186B79F4E4F / num11));
					float num16 = ((num11 == 0f) ? float.MaxValue : (item3._8BCCCC895AFF484D / num11));
					num2 = Mathf.Min(num2, num12);
					num4 = Mathf.Min(num4, num13);
					num5 = Mathf.Min(num5, num14);
					num6 = Mathf.Min(num6, num15);
					num7 = Mathf.Min(num7, num16);
					num3 = Mathf.Min(num3, item3._979A197054D84450);
					num8 = Mathf.Min(num8, Vector3.Distance(item3._9EB9E2BEE74640DC._8B47B2B22D864C7B, item2.AE92804C67564138));
					num9 = Mathf.Max(num9, num11);
				}
				c48614AC45154D._9B275B1A52C94131.Add(new _5BFAAAB21DD048F9
				{
					_5FE8C91B75FD47B1 = num8,
					C0923108A850499C = num3,
					_428E758639EB468F = num2,
					_9CB18FDE8C1A4AFF = num4,
					_27EEF17E853B4531 = num5,
					_6CDC3CD7AF5F4025 = num6,
					_7C9513FAD78747BA = num7,
					D551B8FF4F6D48A7 = num9
				});
			}
			c48614AC45154D.C03984E0A7D64C2D = ((PlayerCaller)__instance).player.channel.owner.playerID.steamID.m_SteamID;
			c48614AC45154D._54605946DDFA4216 = enumerable.Count();
			DFD3A2A221CF4036.CB4E939A3F83474C("Hit Accuracy", c48614AC45154D);
			a3116505AAB._638733A069E74AA4._067240C6E7D645F7 = 0;
			a3116505AAB._638733A069E74AA4._080940434C504A7C.Clear();
		}
	}

	[_542A381FC1D44BA3(typeof(UseableGun), "equip", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _98FBBEFCD6414133(UseableGun __instance)
	{
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)__instance).player);
		if (a3116505AAB == null)
		{
			return;
		}
		a3116505AAB.C4DA765AFB124762 = false;
		_62A93039A0124E9A(((PlayerCaller)__instance).player.equipment);
		Transform firstModel = ((PlayerCaller)__instance).player.equipment.firstModel;
		if ((Object)(object)firstModel == (Object)null)
		{
			return;
		}
		Attachments component = ((Component)firstModel).GetComponent<Attachments>();
		_64A4BBC5E4CE4EE1._3D8DA4D4ADA34DEA.Invoke(__instance) = component;
		if ((Object)(object)component == (Object)null || (Object)(object)component.barrelHook == (Object)null)
		{
			return;
		}
		EffectAsset val = __instance.equippedGunAsset.FindMuzzleEffectAsset();
		if (val == null || !((Object)(object)val.effect != (Object)null))
		{
			return;
		}
		if (!F504A830D39749E7.TryGetValue(((Asset)val).id, out var value))
		{
			GameObject val2 = Object.Instantiate<GameObject>(val.effect);
			Transform transform = val2.transform;
			if ((Object)(object)transform != (Object)null)
			{
				ParticleSystem component2 = ((Component)transform).GetComponent<ParticleSystem>();
				value = (Object)(object)component2 != (Object)null && (Object)(object)((Component)component2).GetComponent<Light>() == (Object)null;
				Object.DestroyImmediate((Object)(object)val2);
			}
			F504A830D39749E7.Add(((Asset)val).id, value);
		}
		if (value)
		{
			a3116505AAB.C4DA765AFB124762 = true;
		}
	}

	[_542A381FC1D44BA3(typeof(UseableGun), "updateState", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _7FAEF98935C1482E(UseableGun __instance, byte[] newState)
	{
		Attachments obj = _64A4BBC5E4CE4EE1._3D8DA4D4ADA34DEA.Invoke(__instance);
		if (obj != null)
		{
			obj.updateAttachments(newState, true);
		}
	}

	[_542A381FC1D44BA3(typeof(UseableGun), "fire", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _949EF1B4B5EE40D0(UseableGun __instance)
	{
		_55A676AE7D2646A4?.Invoke(__instance);
	}

	private static void _62A93039A0124E9A(PlayerEquipment _8CFA4974655F47B8)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected Obj, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected Obj, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected Obj, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected I4, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected Obj, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected Obj, but got Unknown
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		GameObject val = _8CFA4974655F47B8.asset.equipablePrefab ?? _8CFA4974655F47B8.asset.item;
		List<Mesh> list = new List<Mesh>(4);
		Material val2 = null;
		object[] parameters = new object[10]
		{
			_8CFA4974655F47B8.quality,
			_8CFA4974655F47B8.state,
			true,
			_8CFA4974655F47B8.asset,
			(object)(SkinAsset)BA18FF8452884375.GetValue(_8CFA4974655F47B8),
			true,
			list,
			val2,
			(object)new GetStatTrackerValueHandler(_8CFA4974655F47B8.getUseableStatTrackerValue),
			val
		};
		F9B0F4990F1D4879.SetValue(_8CFA4974655F47B8, (object?)(Transform)_1AE82A34D2B34943.Invoke(null, parameters));
		_8C71B57CB10248BF.Invoke(_8CFA4974655F47B8, new object[1] { _8CFA4974655F47B8.firstModel });
		_190F31E087CF41DC.Invoke(_8CFA4974655F47B8, new object[1] { _8CFA4974655F47B8.firstModel });
		_139AC42384D74A00.SetValue(_8CFA4974655F47B8, ((Component)_8CFA4974655F47B8.firstModel).GetComponent<UseableEventHook>());
		EEquipableModelParent equipableModelParent = _8CFA4974655F47B8.asset.EquipableModelParent;
		Transform parent = (equipableModelParent - 1) switch
		{
			0 => _8CFA4974655F47B8.firstLeftHook, 
			1 => (Transform)FA57E053C40C4C19.GetValue(_8CFA4974655F47B8), 
			2 => (Transform)E9E461D4306A4D26.GetValue(_8CFA4974655F47B8), 
			_ => _8CFA4974655F47B8.firstRightHook, 
		};
		((Component)_8CFA4974655F47B8.firstModel).transform.parent = parent;
		_8CFA4974655F47B8.firstModel.localPosition = Vector3.zero;
		_8CFA4974655F47B8.firstModel.localRotation = Quaternion.Euler(0f, 0f, 90f);
		_96D739E9AC054140.Invoke(_8CFA4974655F47B8, new object[2] { _8CFA4974655F47B8.asset, _8CFA4974655F47B8.firstModel });
		((Component)_8CFA4974655F47B8.firstModel).gameObject.SetActive(false);
		((Component)_8CFA4974655F47B8.firstModel).gameObject.SetActive(true);
		TransformEx.DestroyRigidbody(_8CFA4974655F47B8.firstModel);
	}

	static A76A63943FD04779()
	{
		E651E17AA2CA4BC8._18821157D5754512((object)null);
		E651E17AA2CA4BC8._18821157D5754512((object)null);
		E651E17AA2CA4BC8._18821157D5754512((object)null);
		E651E17AA2CA4BC8._18821157D5754512((object)null);
		_ = new Type[10];
	}
}
