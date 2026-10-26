using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class _4F90CB7082D74A12
{
	public delegate void C9974768BC7149F3(Player _6FF7EA32D91247A4, in ServerInvocationContext CCDAD27FE4B24CC7, InteractableSpot _583EC2C8F2CA489A, bool _26F6ADE38E22435B, ref bool _7CC0EFF7180940AB);

	public static C9974768BC7149F3? B90140D612944627;

	[_542A381FC1D44BA3(typeof(InteractableSpot_NetMethods), "ReceiveToggleRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _26C0E4EECDED4B81(in ServerInvocationContext context)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NetPakReader reader = context.reader;
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		InteractableSpot val2 = (InteractableSpot)((obj is InteractableSpot) ? obj : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return false;
		}
		bool flag = default;
		reader.ReadBit(ref flag);
		if (EE7DB902F0CD483E(in context, val2, flag))
		{
			val2.ReceiveToggleRequest(ref context, flag);
		}
		return false;
	}

	private static bool EE7DB902F0CD483E(in ServerInvocationContext context, InteractableSpot spot, bool desiredPowered)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val = default;
		if (!BarricadeManager.tryGetRegion(((Component)spot).transform, ref b, ref b2, ref num, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = ((Component)spot).transform.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _7CC0EFF7180940AB = true;
		B90140D612944627?.Invoke(player, in context, spot, desiredPowered, ref _7CC0EFF7180940AB);
		return _7CC0EFF7180940AB;
	}
}
