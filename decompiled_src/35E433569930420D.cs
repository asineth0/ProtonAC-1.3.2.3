using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class _35E433569930420D
{
	public delegate void _781A9DC9770F4A09(Player B484B9CE023944D7, in ServerInvocationContext EA687A0B6433450C, Interactable _05720675AD8644E4, bool F13F876C5169491F, ref bool _370B76FF115B4F58);

	public static _781A9DC9770F4A09? F0CF819FE86D45F0;

	[_542A381FC1D44BA3(typeof(InteractableGenerator_NetMethods), "ReceiveToggleRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool AA29B2005B934E27(in ServerInvocationContext context)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NetPakReader reader = context.reader;
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		InteractableGenerator val2 = (InteractableGenerator)((obj is InteractableGenerator) ? obj : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return false;
		}
		bool flag = default;
		reader.ReadBit(ref flag);
		if (_599D6BFC186D4A2A(in context, (Interactable)(object)val2, flag))
		{
			val2.ReceiveToggleRequest(ref context, flag);
		}
		return false;
	}

	public static bool _599D6BFC186D4A2A(in ServerInvocationContext context, Interactable generator, bool desiredPowered)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		ushort num = default;
		BarricadeRegion val = default;
		if (!BarricadeManager.tryGetRegion(((Component)generator).transform, ref b, ref b2, ref num, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = ((Component)generator).transform.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _370B76FF115B4F = true;
		F0CF819FE86D45F0?.Invoke(player, in context, generator, desiredPowered, ref _370B76FF115B4F);
		return _370B76FF115B4F;
	}
}
