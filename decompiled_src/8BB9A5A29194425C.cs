using SDG.Unturned;
using UnityEngine;

internal class _8BB9A5A29194425C
{
	public delegate void _5C5015DF1B7D4608(Player ACB2C4B6185B4C13, in ServerInvocationContext E14564AAAE604687, InteractableBed _7C7994BB4C624651, ref bool _6CD30BC33A294058);

	public static _5C5015DF1B7D4608? _60F899D151F94DD8;

	[_542A381FC1D44BA3(typeof(InteractableBed_NetMethods), "ReceiveClaimRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _16B373AED6DD4C99(in ServerInvocationContext context)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(context.reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		InteractableBed val2 = (InteractableBed)((obj is InteractableBed) ? obj : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return false;
		}
		if (_970CBCC581234E56(in context, val2))
		{
			val2.ReceiveClaimRequest(ref context);
		}
		return false;
	}

	private static bool _970CBCC581234E56(in ServerInvocationContext context, InteractableBed bed)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val = default;
		if (!BarricadeManager.tryGetRegion(((Component)bed).transform, ref b, ref b2, ref num, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = ((Component)bed).transform.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _6CD30BC33A = true;
		_60F899D151F94DD8?.Invoke(player, in context, bed, ref _6CD30BC33A);
		return _6CD30BC33A;
	}
}
