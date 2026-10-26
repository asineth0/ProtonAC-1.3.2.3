using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class CCA3D0C8351442CA
{
	[_542A381FC1D44BA3(typeof(InteractableOxygenator_NetMethods), "ReceiveToggleRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool E8E849CB4C984ECD(in ServerInvocationContext context)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		NetPakReader reader = context.reader;
		NetId val = default;
		if (!NetIdPakEx.ReadNetId(reader, ref val))
		{
			return false;
		}
		object obj = NetIdRegistry.Get(val);
		InteractableOxygenator val2 = (InteractableOxygenator)((obj is InteractableOxygenator) ? obj : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return false;
		}
		bool flag = default;
		reader.ReadBit(ref flag);
		if (_35E433569930420D._599D6BFC186D4A2A(in context, (Interactable)(object)val2, flag))
		{
			val2.ReceiveToggleRequest(ref context, flag);
		}
		return false;
	}
}
