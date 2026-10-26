using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class _90833F1F1E9F41AC
{
	public delegate void D329F3F582EF4A66(Player _8A15477DC9284FCA, in ServerInvocationContext F8CE995C3C334F7D, InteractableDoor _8AABE7EED058424C, bool FE63DBCFC6A44262, ref bool _95B9610947DB4900);

	public static D329F3F582EF4A66? E9910DE5C2BD4C15;

	[_542A381FC1D44BA3(typeof(InteractableDoor_NetMethods), "ReceiveToggleRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _18DFBD5FBE34485C(in ServerInvocationContext context)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NetPakReader reader = context.reader;
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		InteractableDoor val2 = (InteractableDoor)((obj is InteractableDoor) ? obj : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return false;
		}
		bool flag = default;
		reader.ReadBit(ref flag);
		if (_4262E8601B944949(in context, val2, flag))
		{
			val2.ReceiveToggleRequest(ref context, flag);
		}
		return false;
	}

	private static bool _4262E8601B944949(in ServerInvocationContext context, InteractableDoor door, bool desiredOpen)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val = default;
		if (!BarricadeManager.tryGetRegion(((Component)door).transform, ref b, ref b2, ref num, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = ((Component)door).transform.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _95B9610947DB = true;
		E9910DE5C2BD4C15?.Invoke(player, in context, door, desiredOpen, ref _95B9610947DB);
		return _95B9610947DB;
	}
}
