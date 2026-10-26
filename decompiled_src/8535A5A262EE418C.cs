using SDG.Unturned;
using UnityEngine;

internal class _8535A5A262EE418C
{
	public delegate void _90E1B2297C0942EA(Player C9D464D8B3FC4EF3, in ServerInvocationContext BC10C5628FBC4A9F, InteractableFarm _441BCCC7ADAC4959, ref bool _094E2D6FEB6645C8);

	public static _90E1B2297C0942EA? DCB16D41FCBC4AB6;

	[_542A381FC1D44BA3(typeof(InteractableFarm_NetMethods), "ReceiveHarvestRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool EBF7051559664477(in ServerInvocationContext context)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(context.reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		InteractableFarm val2 = (InteractableFarm)((obj is InteractableFarm) ? obj : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return false;
		}
		if (_6E50C40EE0564816(in context, val2))
		{
			val2.ReceiveHarvestRequest(ref context);
		}
		return false;
	}

	private static bool _6E50C40EE0564816(in ServerInvocationContext context, InteractableFarm farm)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val = default;
		if (!BarricadeManager.tryGetRegion(((Component)farm).transform, ref b, ref b2, ref num, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = ((Component)farm).transform.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _094E2D6FEB6645C = true;
		DCB16D41FCBC4AB6?.Invoke(player, in context, farm, ref _094E2D6FEB6645C);
		return _094E2D6FEB6645C;
	}
}
