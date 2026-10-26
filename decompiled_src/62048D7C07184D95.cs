using SDG.Unturned;

public class _62048D7C07184D95
{
	private const int A750540753DE4054 = 23;

	private const int _3CD50FBAA0054650 = 32;

	private const int C64086C683F540E1 = 65;

	private const int _591DBB9D459D4D54 = 82;

	private const int _6C4B7BE825784753 = 98;

	private const int _8EC020EB660A47A7 = 132;

	private int _0619EBF5514B4FD6;

	private bool C50947A605994198;

	public EPlayerGesture D63E5FFE5E6249E2;

	public void _08588F9CCF7147D9()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (_0619EBF5514B4FD6 > 0)
		{
			_0619EBF5514B4FD6--;
		}
		else if (C50947A605994198)
		{
			D63E5FFE5E6249E2 = (EPlayerGesture)0;
			C50947A605994198 = false;
		}
	}

	public void _0BD0BA5C877B4CB4(EPlayerGesture P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Invalid comparison between Unknown and I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Invalid comparison between Unknown and I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Invalid comparison between Unknown and I4
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		switch (P_0 - 1)
		{
		case 0:
		case 5:
		case 10:
		case 12:
		case 15:
			if ((int)D63E5FFE5E6249E2 == 0)
			{
				D63E5FFE5E6249E2 = P_0;
				_0619EBF5514B4FD6 = 0;
				C50947A605994198 = false;
			}
			break;
		case 1:
			if ((int)D63E5FFE5E6249E2 == 1)
			{
				D63E5FFE5E6249E2 = (EPlayerGesture)0;
			}
			break;
		case 6:
			if ((int)D63E5FFE5E6249E2 == 6)
			{
				D63E5FFE5E6249E2 = (EPlayerGesture)0;
			}
			break;
		case 13:
			if ((int)D63E5FFE5E6249E2 == 13)
			{
				D63E5FFE5E6249E2 = (EPlayerGesture)0;
			}
			break;
		case 16:
			if ((int)D63E5FFE5E6249E2 == 16)
			{
				D63E5FFE5E6249E2 = (EPlayerGesture)0;
			}
			break;
		case 11:
			if ((int)D63E5FFE5E6249E2 == 11)
			{
				D63E5FFE5E6249E2 = (EPlayerGesture)0;
			}
			break;
		case 2:
			_8375367262CE4E45(P_0, 23);
			break;
		case 3:
		case 4:
			_8375367262CE4E45(P_0, 32);
			break;
		case 8:
			if ((int)D63E5FFE5E6249E2 == 0)
			{
				_8375367262CE4E45(P_0, 65);
			}
			break;
		case 9:
			if ((int)D63E5FFE5E6249E2 == 0)
			{
				_8375367262CE4E45(P_0, 82);
			}
			break;
		case 7:
			if ((int)D63E5FFE5E6249E2 == 0)
			{
				_8375367262CE4E45(P_0, 98);
			}
			break;
		case 14:
			if ((int)D63E5FFE5E6249E2 == 0)
			{
				_8375367262CE4E45(P_0, 132);
			}
			break;
		}
	}

	private void _8375367262CE4E45(EPlayerGesture P_0, int P_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		D63E5FFE5E6249E2 = P_0;
		_0619EBF5514B4FD6 = P_1;
		C50947A605994198 = true;
	}
}
