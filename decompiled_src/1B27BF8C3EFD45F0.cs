using SDG.Unturned;
using UnityEngine;

internal class _1B27BF8C3EFD45F0
{
	public delegate void _12B83BAD32524F4A(Player _01600CD4FC5F4EE3, in ServerInvocationContext _80F795EA2EDF4BC0, BarricadeDrop _26F4794467814E22, ref bool _4AAC2515E0E7480E);

	public static _12B83BAD32524F4A? _6B565C1922CD41BF;

	[_542A381FC1D44BA3(typeof(BarricadeDrop_NetMethods), "ReceiveSalvageRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool ED06A93BE0DB464C(in ServerInvocationContext context)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(context.reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		BarricadeDrop val2 = (BarricadeDrop)((obj is BarricadeDrop) ? obj : null);
		if (val2 == null)
		{
			return false;
		}
		if (_4372ED1C3C914EF3(in context, val2))
		{
			val2.ReceiveSalvageRequest(ref context);
		}
		return false;
	}

	private static bool _4372ED1C3C914EF3(in ServerInvocationContext context, BarricadeDrop barricadeDrop)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val = default;
		if (!BarricadeManager.tryGetRegion(barricadeDrop.model, ref b, ref b2, ref num, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = barricadeDrop.model.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _4AAC2515E0E7480E = true;
		_6B565C1922CD41BF?.Invoke(player, in context, barricadeDrop, ref _4AAC2515E0E7480E);
		return _4AAC2515E0E7480E;
	}
}
