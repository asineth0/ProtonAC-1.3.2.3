using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

public class CD12FBF2EC134DF5
{
	public class _02D6D2763D074C45
	{
		public F1C8494D43F0493B _6626673394694F24 = new F1C8494D43F0493B();

		public _62048D7C07184D95 _12878EC8DCE341EE = new _62048D7C07184D95();

		public PlayerStateUpdate _3FE17818BFA04239;
	}

	public readonly Dictionary<int, _02D6D2763D074C45> E1EC2536A22F43F2;

	public _02D6D2763D074C45 F05B22B752C743A2(Player P_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (!E1EC2536A22F43F2.TryGetValue(P_0.channel.owner.channel, out _02D6D2763D074C45 value))
		{
			value = new _02D6D2763D074C45
			{
				_3FE17818BFA04239 = _36CCC4EEE29249C0(P_0)
			};
			value._6626673394694F24._0110D07157A74BF8 = 0.06f;
			E1EC2536A22F43F2.Add(P_0.channel.owner.channel, value);
		}
		return value;
	}

	public bool D8C5D4CF897D418B(A3116505AAB24996 P_0, Player P_1)
	{
		return (Object)(object)P_1.movement.getVehicle() == (Object)null;
	}

	public PlayerStateUpdate _36CCC4EEE29249C0(Player P_0)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if (_64A4BBC5E4CE4EE1._428211F609CD446A.Invoke(P_0.movement))
		{
			return _64A4BBC5E4CE4EE1._5627CF87C9F0423B.Invoke(P_0.movement);
		}
		return new PlayerStateUpdate(((Component)P_0).transform.position, P_0.look.angle, P_0.look.rot);
	}

	public CD12FBF2EC134DF5()
	{
		Dictionary<int, _02D6D2763D074C45> e1EC2536A22F43F = null;
		E1EC2536A22F43F2 = e1EC2536A22F43F;
	}
}
