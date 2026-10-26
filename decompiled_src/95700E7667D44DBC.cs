using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class _95700E7667D44DBC
{
	public delegate void _86DC58AD1D534F3E(Player FCBD9DC051D44FE2, in ServerInvocationContext CB3B61A1AE3A43DC, InteractableVehicle _82D0D2C47A1B411A, ref Vector3 _6A9660F690D94234);

	public static _86DC58AD1D534F3E? _2CEF4C877BE941D9;

	[_542A381FC1D44BA3(typeof(VehicleManager_NetMethods), "ReceiveExitVehicleRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void A1CC9D5AC85E4C9A(in ServerInvocationContext context)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		Vector3 A08013FF60304BE = default;
		UnityNetPakReaderEx.ReadClampedVector3(context.reader, ref A08013FF60304BE, 13, 7);
		if (B0057FA71AB149FE(in context, ref A08013FF60304BE))
		{
			VehicleManager.ReceiveExitVehicleRequest(ref context, A08013FF60304BE);
		}
	}

	private static bool B0057FA71AB149FE(in ServerInvocationContext E084ED3FCD86472F, ref Vector3 A08013FF60304BE9)
	{
		Player player = E084ED3FCD86472F.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		InteractableVehicle vehicle = player.movement.getVehicle();
		if ((Object)(object)vehicle == (Object)null)
		{
			return true;
		}
		_86DC58AD1D534F3E? obj = _2CEF4C877BE941D9;
		if (obj != null)
		{
			obj(player, in E084ED3FCD86472F, vehicle, ref A08013FF60304BE9);
			return true;
		}
		return true;
	}
}
