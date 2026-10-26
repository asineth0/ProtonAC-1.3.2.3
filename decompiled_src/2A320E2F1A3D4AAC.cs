using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Microsoft.Extensions.Configuration;
using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class _2A320E2F1A3D4AAC
{
	private delegate void _687406DFF1C7493E(BarricadeManager _6F9CFEF3FAB34433, SteamPlayer B957E0B1B98E4861, BarricadeRegion F044D935C3304D30, byte F692A5BB5D6F4C71, byte DC70E5CAA26A4F57, NetId FDADA230147E45FC, float A086C61A95DC46BA);

	private delegate Wheel E8EBC577B11F4F84(InteractableVehicle C2FF7A46CC564ECA, int _4140272A0CB646A1);

	private delegate void _5D340F8EF0854DD6(VehicleManager _1BC41E299BB44399, NetPakWriter F215D3DE224F4117, Vector3 _286EB31023094614);

	[CompilerGenerated]
	private sealed class _4B3FB6AB0B764184
	{
		public VehicleManager __instance;
	}

	private static readonly A19CBF069C964833 D647D1BC81C54BFF;

	private static readonly A19CBF069C964833._40FE7AC3F69F4B10 _7ED26635F68D4B10;

	private static readonly A19CBF069C964833._40FE7AC3F69F4B10 _531988F1E92E48B0;

	private static readonly A19CBF069C964833._40FE7AC3F69F4B10 EEF4BFA52790453D;

	private static readonly FieldRef<VehicleManager, HashSet<InteractableVehicle>> _56F70353789C440C;

	private static readonly FieldRef<VehicleManager, List<InteractableVehicle>> _04BAA19AAA684295;

	private static readonly _687406DFF1C7493E _1674414E752642C3;

	private static readonly FieldRef<Wheel, float> BD254708CD324307;

	private static readonly FieldRef<VehicleBarricadeRegion, NetId> _344E62EAC60748E0;

	private static readonly FieldRef<uint> B282198DEA854C23;

	private static readonly FieldRef<InteractableVehicle, bool> BC5EDFCA6899418E;

	private static readonly ClientStaticMethod _213C1390495148F7;

	private static readonly E8EBC577B11F4F84 _5C96B8495EF7480F;

	private static readonly _5D340F8EF0854DD6 E70AB226D582476C;

	private const int _867C490649A3421D = 500;

	private static readonly HashSet<NetId> _25E3691BCFA6499B;

	private static readonly _087B17044C8447C2[] _8FA39392407C4500;

	private static readonly _087B17044C8447C2[] _92ABFCDF3E914E71;

	private static readonly _087B17044C8447C2[] _40C86CA387064C50;

	private static int _263C8C4BB9E9485D;

	private static int D21206EBBEA54624;

	private static int _8BE0180D6D514FB0;

	public static readonly _0732D1C8FF584BB5 _2854C72CF5B5446D;

	public static bool B5DBDA6B08C74F8A;

	private static bool F5AE6423D0624C91;

	[_542A381FC1D44BA3(typeof(VehicleManager), "sendVehicleStates", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _0C6AFC1C87254787(VehicleManager __instance)
	{
		GC.KeepAlive(null);
		return false;
	}

	[_542A381FC1D44BA3(typeof(VehicleManager), "sendExitVehicle", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _1A6ADAF861604937(InteractableVehicle vehicle, byte seat, Vector3 point, byte angle, bool forceUpdate)
	{
		if (seat == 0)
		{
			vehicle.MarkForReplicationUpdate();
		}
	}

	[_542A381FC1D44BA3(typeof(VehicleManager), "DestroyVehicleCommon", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void BE78C9DEB636477B(InteractableVehicle vehicle)
	{
		_2854C72CF5B5446D._92EC43D608A14E21(vehicle);
	}

	[_542A381FC1D44BA3(typeof(BarricadeManager), "ReceiveDestroyBarricade", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _5491F387F6634594(in ClientInvocationContext context, NetId netId)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		BarricadeDrop val = NetIdRegistry.Get<BarricadeDrop>(netId);
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val2 = default;
		if (val != null && BarricadeManager.tryGetRegion(val.model, ref b, ref b2, ref num, ref val2))
		{
			VehicleBarricadeRegion val3 = (VehicleBarricadeRegion)(object)((val2 is VehicleBarricadeRegion) ? val2 : null);
			if (val3 != null)
			{
				_25E3691BCFA6499B.Add(((Interactable)val3.vehicle).GetNetId());
			}
			if (!val.IsChildOfVehicle)
			{
				_2854C72CF5B5446D._9BC2CB07D61C4058(val.model);
			}
		}
	}

	[_542A381FC1D44BA3(typeof(StructureManager), "ReceiveDestroyStructure", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void A5783B92FC47406C(in ClientInvocationContext context, NetId netId, Vector3 ragdoll, bool wasPickedUp)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		StructureDrop val = NetIdRegistry.Get<StructureDrop>(netId);
		byte b = default;
		byte b2 = default;
		StructureRegion val2 = default;
		if (val != null && StructureManager.tryGetRegion(val.model, ref b, ref b2, ref val2))
		{
			_2854C72CF5B5446D._9BC2CB07D61C4058(val.model);
		}
	}

	[_542A381FC1D44BA3(typeof(BarricadeManager), "spawnBarricade", _24AD03718EF64384._21C2F47B5D9744BD)]
	public static void A06CAFF7793B4183(BarricadeRegion region, Guid assetGuid, byte[] state, Vector3 point, Quaternion rotation, byte hp, ulong owner, ulong group, NetId netId, ref Transform __result)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)__result == (Object)null))
		{
			VehicleBarricadeRegion val = (VehicleBarricadeRegion)(object)((region is VehicleBarricadeRegion) ? region : null);
			if (val != null)
			{
				_25E3691BCFA6499B.Add(((Interactable)val.vehicle).GetNetId());
			}
			_2854C72CF5B5446D._73A3269801654974(__result);
		}
	}

	[_542A381FC1D44BA3(typeof(StructureManager), "spawnStructure", _24AD03718EF64384._21C2F47B5D9744BD)]
	public static void _80E53CAC8AAC489C(StructureRegion region, Guid assetId, Vector3 point, Quaternion rotation, byte hp, ulong owner, ulong group, NetId netId, ref Transform __result)
	{
		if (!((Object)(object)__result == (Object)null))
		{
			_2854C72CF5B5446D._73A3269801654974(__result);
		}
	}

	[_542A381FC1D44BA3(typeof(ResourceManager), "ReceiveResourceDead", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _7CAA2B12419A4AC5(byte x, byte y, ushort index, Vector3 ragdoll)
	{
		List<ResourceSpawnpoint> treesOrNullInRegion = LevelGround.GetTreesOrNullInRegion(x, y);
		if (treesOrNullInRegion != null && index < treesOrNullInRegion.Count)
		{
			Transform model = treesOrNullInRegion[index].model;
			if ((Object)(object)model != (Object)null)
			{
				_2854C72CF5B5446D._9BC2CB07D61C4058(model);
			}
			Transform stump = treesOrNullInRegion[index].stump;
			if ((Object)(object)stump != (Object)null)
			{
				_2854C72CF5B5446D._9BC2CB07D61C4058(stump);
			}
		}
	}

	[_542A381FC1D44BA3(typeof(ResourceManager), "ReceiveResourceAlive", _24AD03718EF64384._21C2F47B5D9744BD)]
	public static void _81BBFCA9AFCC405B(byte x, byte y, ushort index)
	{
		List<ResourceSpawnpoint> treesOrNullInRegion = LevelGround.GetTreesOrNullInRegion(x, y);
		if (treesOrNullInRegion != null && index < treesOrNullInRegion.Count)
		{
			Transform model = treesOrNullInRegion[index].model;
			if ((Object)(object)model != (Object)null)
			{
				_2854C72CF5B5446D._73A3269801654974(model);
			}
			Transform stump = treesOrNullInRegion[index].stump;
			if ((Object)(object)stump != (Object)null)
			{
				_2854C72CF5B5446D._73A3269801654974(stump);
			}
		}
	}

	[_542A381FC1D44BA3(typeof(ObjectManager), "ReceiveObjectRubble", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _800E9DA889FA495E(byte x, byte y, ushort index, byte section, bool isAlive, Vector3 ragdoll)
	{
		if (!Regions.checkSafe((int)x, (int)y) || LevelObjects.objects == null)
		{
			return;
		}
		List<LevelObject> list = LevelObjects.objects[x, y];
		if (list == null || index >= list.Count)
		{
			return;
		}
		LevelObject val = list[index];
		if (val == null)
		{
			return;
		}
		InteractableObjectRubble rubble = val.rubble;
		if (!((Object)(object)rubble != (Object)null))
		{
			return;
		}
		if (section == byte.MaxValue)
		{
			for (int i = 0; i < _64A4BBC5E4CE4EE1.F5D0D009B88A49C8.Invoke(rubble).Length; i++)
			{
				_052A2EC5ED834C4C(rubble, (byte)i, isAlive);
			}
		}
		else
		{
			_052A2EC5ED834C4C(rubble, section, isAlive);
		}
	}

	private static void _052A2EC5ED834C4C(InteractableObjectRubble F353A8E206F7467B, byte _3C2888F4518148CA, bool _03D003AA4E6644C3)
	{
		RubbleInfo[] array = _64A4BBC5E4CE4EE1.F5D0D009B88A49C8.Invoke(F353A8E206F7467B);
		if (array != null && _3C2888F4518148CA < array.Length)
		{
			RubbleInfo val = array[_3C2888F4518148CA];
			bool flag = F353A8E206F7467B.isAllDead();
			if ((Object)(object)val.aliveGameObject != (Object)null)
			{
				_007E01CE3AE9446F(val.aliveGameObject, !val.isDead);
			}
			if ((Object)(object)val.deadGameObject != (Object)null)
			{
				_007E01CE3AE9446F(val.deadGameObject, val.isDead && (!flag || F353A8E206F7467B.asset.IsRubbleFinaleEffectRefNull()));
			}
			if ((Object)(object)_64A4BBC5E4CE4EE1._18C7E0D250E041F5.Invoke(F353A8E206F7467B) != (Object)null)
			{
				_007E01CE3AE9446F(_64A4BBC5E4CE4EE1._18C7E0D250E041F5.Invoke(F353A8E206F7467B), !flag);
			}
			if (Object.op_Implicit((Object)(object)_64A4BBC5E4CE4EE1.C02658AE60C24A9E.Invoke(F353A8E206F7467B)))
			{
				_007E01CE3AE9446F(_64A4BBC5E4CE4EE1.C02658AE60C24A9E.Invoke(F353A8E206F7467B), flag);
			}
		}
	}

	private static void _007E01CE3AE9446F(GameObject CDD0DB94C8104B3C, bool FBF694C9740843E2)
	{
		if (!FBF694C9740843E2)
		{
			_2854C72CF5B5446D._9BC2CB07D61C4058(CDD0DB94C8104B3C.transform);
		}
		else
		{
			_2854C72CF5B5446D._73A3269801654974(CDD0DB94C8104B3C.transform);
		}
	}

	[_542A381FC1D44BA3(typeof(VehicleManager), "addVehicle", _24AD03718EF64384._21C2F47B5D9744BD)]
	public static void F660D3489ABA4968(ref InteractableVehicle __result)
	{
		if (!F5AE6423D0624C91 || (Object)(object)__result == (Object)null || __result.isDriven)
		{
			return;
		}
		foreach (InteractableVehicle vehicle in VehicleManager.vehicles)
		{
			if (vehicle.instanceID != __result.instanceID)
			{
				__result.ignoreCollisionWith(vehicle.vehicleColliders, vehicle.isDriven);
			}
		}
	}

	[_542A381FC1D44BA3(typeof(InteractableVehicle), "updatePhysics", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _10B0E9AF95C84E6D(InteractableVehicle __instance)
	{
		if (!F5AE6423D0624C91)
		{
			return;
		}
		foreach (InteractableVehicle vehicle in VehicleManager.vehicles)
		{
			if (vehicle.instanceID != __instance.instanceID && !vehicle.isDriven)
			{
				vehicle.ignoreCollisionWith(__instance.vehicleColliders, __instance.isDriven);
			}
		}
	}

	[_542A381FC1D44BA3(typeof(InteractableVehicle), "removePlayer", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _24E3B7DA8F014E64(InteractableVehicle __instance, byte seatIndex, Vector3 point, byte angle, bool forceUpdate)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?._10270708481F445D();
		if (__instance.passengers != null && seatIndex == 0 && seatIndex < __instance.passengers.Length)
		{
			SteamPlayer player = __instance.passengers[seatIndex].player;
			if (player != null && (Object)(object)player.player != (Object)null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(player.player);
				if (a3116505AAB != null)
				{
					a3116505AAB.B6FE4FCC2911449B = _9AB67761792440A7._00FC653ED33A4A96();
					a3116505AAB._1610010BF5BD47DA = new _7B93EFC9B3644586();
					a3116505AAB._965694AA41EB4336._364B5CA53A5A48A0();
				}
				__instance.MarkForReplicationUpdate();
				if (F5AE6423D0624C91)
				{
					InteractableVehicle val = B1D486DE761F48EA(__instance);
					if ((Object)(object)val != (Object)null)
					{
						float num = float.MinValue;
						Bounds bounds;
						foreach (Collider vehicleCollider in val.vehicleColliders)
						{
							if (!vehicleCollider.isTrigger)
							{
								float num2 = num;
								bounds = vehicleCollider.bounds;
								num = Mathf.Max(num2, bounds.max.y);
							}
						}
						float num3 = float.MaxValue;
						foreach (Collider vehicleCollider2 in __instance.vehicleColliders)
						{
							if (!vehicleCollider2.isTrigger)
							{
								float num4 = num3;
								bounds = vehicleCollider2.bounds;
								num3 = Mathf.Min(num4, bounds.min.y);
							}
						}
						if (num == float.MinValue)
						{
							num = ((Component)val).transform.position.y;
						}
						if (num3 == float.MaxValue)
						{
							num3 = ((Component)__instance).transform.position.y;
						}
						float num5 = num - num3;
						if (num5 > 0f)
						{
							Rigidbody val2 = _64A4BBC5E4CE4EE1._1666B192DD1445FB.Invoke(__instance);
							if ((Object)(object)val2 != (Object)null)
							{
								bool isKinematic = val2.isKinematic;
								val2.isKinematic = true;
								val2.position += Vector3.up * (num5 + 0.2f);
								val2.isKinematic = isKinematic;
							}
						}
					}
				}
			}
		}
		_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?.F471762FF8094F2B(_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F.F27B18C1D6E54F89());
	}

	[_542A381FC1D44BA3(typeof(InteractableVehicle), "swapPlayer", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _05B6BC7A414D4D8D(InteractableVehicle __instance, byte fromSeatIndex, byte toSeatIndex)
	{
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?._10270708481F445D();
		Passenger seatByIndex = __instance.GetSeatByIndex((int)fromSeatIndex);
		Passenger seatByIndex2 = __instance.GetSeatByIndex((int)toSeatIndex);
		if (seatByIndex != null && seatByIndex2 != null && fromSeatIndex == 0 && toSeatIndex != 0)
		{
			SteamPlayer player = seatByIndex.player;
			if (player != null && (Object)(object)player.player != (Object)null)
			{
				A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(player.player);
				if (a3116505AAB != null)
				{
					a3116505AAB.B6FE4FCC2911449B = _9AB67761792440A7._00FC653ED33A4A96();
					a3116505AAB._1610010BF5BD47DA = new _7B93EFC9B3644586();
					a3116505AAB._965694AA41EB4336._364B5CA53A5A48A0();
				}
				__instance.MarkForReplicationUpdate();
				if (F5AE6423D0624C91)
				{
					InteractableVehicle val = B1D486DE761F48EA(__instance);
					if ((Object)(object)val != (Object)null)
					{
						float num = float.MinValue;
						Bounds bounds;
						foreach (Collider vehicleCollider in val.vehicleColliders)
						{
							if (!vehicleCollider.isTrigger)
							{
								float num2 = num;
								bounds = vehicleCollider.bounds;
								num = Mathf.Max(num2, bounds.max.y);
							}
						}
						float num3 = float.MaxValue;
						foreach (Collider vehicleCollider2 in __instance.vehicleColliders)
						{
							if (!vehicleCollider2.isTrigger)
							{
								float num4 = num3;
								bounds = vehicleCollider2.bounds;
								num3 = Mathf.Min(num4, bounds.min.y);
							}
						}
						if (num == float.MinValue)
						{
							num = ((Component)val).transform.position.y;
						}
						if (num3 == float.MaxValue)
						{
							num3 = ((Component)__instance).transform.position.y;
						}
						float num5 = num - num3;
						if (num5 > 0f)
						{
							Rigidbody val2 = _64A4BBC5E4CE4EE1._1666B192DD1445FB.Invoke(__instance);
							if ((Object)(object)val2 != (Object)null)
							{
								bool isKinematic = val2.isKinematic;
								val2.isKinematic = true;
								val2.position += Vector3.up * (num5 + 0.2f);
								val2.isKinematic = isKinematic;
							}
						}
					}
				}
			}
		}
		_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?.F471762FF8094F2B(_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F.F27B18C1D6E54F89());
	}

	private static InteractableVehicle? B1D486DE761F48EA(InteractableVehicle CEFDC74CCCB941B3)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		float num = default;
		foreach (InteractableVehicle vehicle in VehicleManager.vehicles)
		{
			if (vehicle.instanceID == CEFDC74CCCB941B3.instanceID)
			{
				continue;
			}
			Vector3 val = ((Component)vehicle).transform.position - ((Component)CEFDC74CCCB941B3).transform.position;
			if (!(val.sqrMagnitude < 400f))
			{
				continue;
			}
			foreach (Collider vehicleCollider in vehicle.vehicleColliders)
			{
				if (vehicleCollider.isTrigger)
				{
					continue;
				}
				Bounds bounds = vehicleCollider.bounds;
				foreach (Collider vehicleCollider2 in CEFDC74CCCB941B3.vehicleColliders)
				{
					if (!vehicleCollider2.isTrigger && bounds.Intersects(vehicleCollider2.bounds) && _9AB67761792440A7._04FE91AB81EE4260(vehicleCollider) && _9AB67761792440A7._04FE91AB81EE4260(vehicleCollider2) && !Physics.GetIgnoreLayerCollision(((Component)vehicleCollider).gameObject.layer, ((Component)vehicleCollider2).gameObject.layer) && Physics.ComputePenetration(vehicleCollider, ((Component)vehicleCollider).transform.position, ((Component)vehicleCollider).transform.rotation, vehicleCollider2, ((Component)vehicleCollider2).transform.position, ((Component)vehicleCollider2).transform.rotation, ref val, ref num) && num > 0.03f)
					{
						return vehicle;
					}
				}
			}
		}
		return null;
	}

	public static void F78AC99C9530449C(SteamPlayer C56500B630AF4E95, A3116505AAB24996 B3DB798D09A7402F)
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		_263C8C4BB9E9485D = 0;
		_8BE0180D6D514FB0 = 0;
		foreach (_087B17044C8447C2 value in B3DB798D09A7402F._83B3415EF0E34C51._5A36DD1A17374A38.Values)
		{
			if (value._84FBBCC10ECA454B)
			{
				value._84FBBCC10ECA454B = false;
				if (_263C8C4BB9E9485D < 500)
				{
					_8FA39392407C4500[_263C8C4BB9E9485D++] = value;
				}
				if (_8BE0180D6D514FB0 < 500)
				{
					_40C86CA387064C50[_8BE0180D6D514FB0++] = value;
				}
			}
			else if (!value.BB8633A6EFF8468C && _8BE0180D6D514FB0 < 500)
			{
				_40C86CA387064C50[_8BE0180D6D514FB0++] = value;
			}
		}
		if (_263C8C4BB9E9485D > 0)
		{
			E0979537EFEC4491.B7B0E288AF484EF2(((SteamConnectedClientBase)C56500B630AF4E95).transportConnection, _8FA39392407C4500, _263C8C4BB9E9485D);
		}
		if (_8BE0180D6D514FB0 <= 0)
		{
			return;
		}
		_2B4193F94A734FAF.C94D65522B8243AA(((SteamConnectedClientBase)C56500B630AF4E95).transportConnection, _40C86CA387064C50, _8BE0180D6D514FB0, C56500B630AF4E95);
		for (int i = 0; i < _8BE0180D6D514FB0; i++)
		{
			_087B17044C8447C2 obj = _40C86CA387064C50[i];
			foreach (VehicleBarricadeRegion vehicleRegion in BarricadeManager.vehicleRegions)
			{
				if (((BarricadeRegion)vehicleRegion).drops.Count > 0 && ((Interactable)vehicleRegion.vehicle).GetNetId() == obj.FC3A17294F3E41FE)
				{
					Vector3 val = ((Component)C56500B630AF4E95.player).transform.position - ((BarricadeRegion)vehicleRegion).parent.position;
					float sqrMagnitude = val.sqrMagnitude;
					_2B4193F94A734FAF.FFA26FAB3AA94112 = true;
					_1674414E752642C3(BarricadeManager.instance, C56500B630AF4E95, (BarricadeRegion)(object)vehicleRegion, byte.MaxValue, byte.MaxValue, _344E62EAC60748E0.Invoke(vehicleRegion), sqrMagnitude);
					_2B4193F94A734FAF.FFA26FAB3AA94112 = false;
				}
			}
		}
	}

	public static void _54D7989141C24A59(IConfiguration C9B177373F5A4A95)
	{
		((object)C9B177373F5A4A95).Equals((object?)null);
		((object)C9B177373F5A4A95).Equals((object?)null);
	}

	static _2A320E2F1A3D4AAC()
	{
		GC.KeepAlive(null);
	}
}
