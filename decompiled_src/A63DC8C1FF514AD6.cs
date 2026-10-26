using SDG.Unturned;
using UnityEngine;

internal class A63DC8C1FF514AD6
{
	public delegate void DBDBD8D699DD419D(Player _99CD67E2E218482A, in ServerInvocationContext BD0EB7A643FE486C, StructureDrop _567E09C2A3F741B9, ref bool _6DBCBA95BD284837);

	public static DBDBD8D699DD419D? _6CDDE5EFBAE242B1;

	[_542A381FC1D44BA3(typeof(StructureDrop_NetMethods), "ReceiveSalvageRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _0316F95432B44A4F(in ServerInvocationContext context)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(context.reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		StructureDrop val2 = (StructureDrop)((obj is StructureDrop) ? obj : null);
		if (val2 == null)
		{
			return false;
		}
		if (_6FE419FF0A704B1D(in context, val2))
		{
			val2.ReceiveSalvageRequest(ref context);
		}
		return false;
	}

	private static bool _6FE419FF0A704B1D(in ServerInvocationContext context, StructureDrop structureDrop)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		byte b = default;
		byte b2 = default;
		StructureRegion val = default;
		if (!StructureManager.tryGetRegion(structureDrop.model, ref b, ref b2, ref val))
		{
			return true;
		}
		Player player = context.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		Vector3 val2 = structureDrop.model.position - ((Component)player).transform.position;
		if (val2.sqrMagnitude > 400f)
		{
			return true;
		}
		bool _6DBCBA95BD = true;
		_6CDDE5EFBAE242B1?.Invoke(player, in context, structureDrop, ref _6DBCBA95BD);
		return _6DBCBA95BD;
	}
}
