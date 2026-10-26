using System;
using HarmonyLib;
using SDG.Unturned;
using UnityEngine;

internal class _25BE834779884F9D
{
	public delegate void _4BEC7538754E4310(InteractableVehicle EF0ACE8A0797427D, uint _4454F419B1294FAE, bool F00E7B4E59E540A3, Vector3 E8A776E476854485, Quaternion _3902D47792BE4675, float _7BA6F05ED8AB4F91, float _34B9CCF4A0DA44A2, float _864C8BF53C224B61, float EB3206D60B984948);

	private static readonly FieldRef<InteractableVehicle, bool> CFFCBAB269F44C58;

	public static _4BEC7538754E4310? D3C21D90722D4956;

	[_542A381FC1D44BA3(typeof(InteractableVehicle), "updatePhysics", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void _462503C1954B431C(InteractableVehicle __instance)
	{
		_1187FAD6AB3F40BD.A56A3381E61B4454(__instance);
	}

	[_542A381FC1D44BA3(typeof(InteractableVehicle), "simulate", _24AD03718EF64384._1B48C4AE307B46D9, new Type[]
	{
		typeof(uint),
		typeof(int),
		typeof(bool),
		typeof(Vector3),
		typeof(Quaternion),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	})]
	public static bool CD06DC63577641FC(InteractableVehicle __instance)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		Player driverPlayer = __instance.GetDriverPlayer();
		if ((Object)(object)driverPlayer == (Object)null)
		{
			return true;
		}
		SteamPlayerID playerID = driverPlayer.channel.owner.playerID;
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(driverPlayer);
		if (a3116505AAB == null)
		{
			return true;
		}
		a3116505AAB._1610010BF5BD47DA.A8CAA1A1D6C34719 = a3116505AAB._1610010BF5BD47DA._2C46A7A338674C2C;
		a3116505AAB._1610010BF5BD47DA._2C46A7A338674C2C = CFFCBAB269F44C58.Invoke(__instance);
		if (a3116505AAB.C31CABBC84034E20)
		{
			a3116505AAB.C31CABBC84034E20 = false;
			VehicleManager.forceRemovePlayer(playerID.steamID);
			return false;
		}
		return true;
	}

	[_542A381FC1D44BA3(typeof(InteractableVehicle), "simulate", _24AD03718EF64384._21C2F47B5D9744BD, new Type[]
	{
		typeof(uint),
		typeof(int),
		typeof(bool),
		typeof(Vector3),
		typeof(Quaternion),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	})]
	public static void D6F6E678C1814711(InteractableVehicle __instance, uint simulation, int recov, bool inputStamina, Vector3 point, Quaternion angle, float newSpeed, float newForwardVelocity, float newSteeringInput, float newVelocityInput, float delta)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?._10270708481F445D();
		_1DB744298E9F4B09._052FBC588F454484.E31BDAB232D6433D?._10270708481F445D();
		D3C21D90722D4956?.Invoke(__instance, simulation, inputStamina, point, angle, newSpeed, newForwardVelocity, newSteeringInput, newVelocityInput);
		_1DB744298E9F4B09._052FBC588F454484.E31BDAB232D6433D?.F471762FF8094F2B(_1DB744298E9F4B09._052FBC588F454484.E31BDAB232D6433D.F27B18C1D6E54F89());
		_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?.F471762FF8094F2B(_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F.F27B18C1D6E54F89());
	}

	static _25BE834779884F9D()
	{
		E651E17AA2CA4BC8._113C547E3E7142C1.EEE742FC0CF449C0.C2AF6DB5067D4E07((string)null);
	}
}
