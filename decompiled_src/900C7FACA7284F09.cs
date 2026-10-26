using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class _900C7FACA7284F09
{
	public delegate void _736AB21AAE42421C(Player _73C20DCC370F4DD5, in ServerInvocationContext DB527A69760B4C74, InteractableFire _2760A4A3C2EA4171, bool _1684C9128564499D, ref bool _3C07626388C4486B);

	public static _736AB21AAE42421C? E8553E62142A4FC2;

	[_542A381FC1D44BA3(typeof(InteractableFire_NetMethods), "ReceiveToggleRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _860C1CD05F2841FB(in ServerInvocationContext context)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NetPakReader reader = context.reader;
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		InteractableFire val2 = (InteractableFire)((obj is InteractableFire) ? obj : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return false;
		}
		bool flag = default;
		reader.ReadBit(ref flag);
		if (DF99DA15D9EC43A6(in context, val2, flag))
		{
			val2.ReceiveToggleRequest(ref context, flag);
		}
		return false;
	}

	private static bool DF99DA15D9EC43A6(in ServerInvocationContext context, InteractableFire fire, bool desiredLit)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val = default;
		if (!BarricadeManager.tryGetRegion(((Component)fire).transform, ref b, ref b2, ref num, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = ((Component)fire).transform.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _3C07626388C4486B = true;
		E8553E62142A4FC2?.Invoke(player, in context, fire, desiredLit, ref _3C07626388C4486B);
		return _3C07626388C4486B;
	}
}
