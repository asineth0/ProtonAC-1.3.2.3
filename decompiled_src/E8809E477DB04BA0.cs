using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class E8809E477DB04BA0
{
	public delegate void _08EAD6DD7D2B407C(Player _8B8799AE97C4474A, in ServerInvocationContext _7FF9F156E0B74609, InteractableStorage _9DB0224F55F64DE7, bool BB98AB98E6B2451F, ref bool _295757E0691B4228);

	public static _08EAD6DD7D2B407C? _554BE91BCFF34D50;

	[_542A381FC1D44BA3(typeof(InteractableStorage_NetMethods), "ReceiveInteractRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool FE34BE9AECD64048(in ServerInvocationContext context)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NetPakReader reader = context.reader;
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		InteractableStorage val2 = (InteractableStorage)((obj is InteractableStorage) ? obj : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return false;
		}
		bool flag = default;
		reader.ReadBit(ref flag);
		if (_725E672036B64B2C(in context, val2, flag))
		{
			val2.ReceiveInteractRequest(ref context, flag);
		}
		return false;
	}

	private static bool _725E672036B64B2C(in ServerInvocationContext context, InteractableStorage storage, bool quickGrab)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val = default;
		if (!BarricadeManager.tryGetRegion(((Component)storage).transform, ref b, ref b2, ref num, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = ((Component)storage).transform.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _295757E0691B = true;
		_554BE91BCFF34D50?.Invoke(player, in context, storage, quickGrab, ref _295757E0691B);
		return _295757E0691B;
	}
}
