using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class F9F55F72967F4654
{
	public delegate void F74CB3BD418243A2(Player _0935AF6F54A34D2E, in ServerInvocationContext CD36A89567C749E1, InteractableOven _7FDDC11F9248435D, bool CADBE4159A1A4D04, ref bool _3B25B7AE05BF43F8);

	public static F74CB3BD418243A2? _574936AFE1C24436;

	[_542A381FC1D44BA3(typeof(InteractableOven_NetMethods), "ReceiveToggleRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _7CACC7C1494146DA(in ServerInvocationContext context)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NetPakReader reader = context.reader;
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		InteractableOven val2 = (InteractableOven)((obj is InteractableOven) ? obj : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return false;
		}
		bool flag = default;
		reader.ReadBit(ref flag);
		if (_7E239F8576114183(in context, val2, flag))
		{
			val2.ReceiveToggleRequest(ref context, flag);
		}
		return false;
	}

	private static bool _7E239F8576114183(in ServerInvocationContext context, InteractableOven oven, bool desiredLit)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val = default;
		if (!BarricadeManager.tryGetRegion(((Component)oven).transform, ref b, ref b2, ref num, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = ((Component)oven).transform.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _3B25B7AE05BF43F = true;
		_574936AFE1C24436?.Invoke(player, in context, oven, desiredLit, ref _3B25B7AE05BF43F);
		return _3B25B7AE05BF43F;
	}
}
