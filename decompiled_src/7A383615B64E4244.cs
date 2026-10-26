using System.Collections.Generic;
using SDG.Unturned;
using Steamworks;

public class _7A383615B64E4244
{
	public Dictionary<uint, _087B17044C8447C2> _5A36DD1A17374A38 = new Dictionary<uint, _087B17044C8447C2>();

	public void E30CF0C5A95049BF(uint P_0)
	{
		_5A36DD1A17374A38.Remove(P_0);
	}

	public _087B17044C8447C2? F424C4A47EFA4596(uint P_0)
	{
		if (!_5A36DD1A17374A38.TryGetValue(P_0, out _087B17044C8447C2 value))
		{
			return null;
		}
		return value;
	}

	public _087B17044C8447C2? D302F4FC9DA8422A(NetId P_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		foreach (_087B17044C8447C2 value in _5A36DD1A17374A38.Values)
		{
			if (value.FC3A17294F3E41FE == P_0)
			{
				return value;
			}
		}
		return null;
	}

	public _087B17044C8447C2? _706B8B0574FC4C59(CSteamID P_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		foreach (_087B17044C8447C2 value in _5A36DD1A17374A38.Values)
		{
			for (byte b = 0; b < value._2F395796086E4AB0.Length; b++)
			{
				CSteamID val = value._2F395796086E4AB0[b];
				if (val != CSteamID.Nil && val == P_0)
				{
					return value;
				}
			}
		}
		return null;
	}
}
