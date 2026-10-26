using SDG.Framework.Water;
using SDG.Unturned;
using UnityEngine;

public class _7B93EFC9B3644586
{
	public const int _52FA34C8E9E24863 = int.MaxValue;

	public bool B5D48CE083EC49C0;

	public bool _2C46A7A338674C2C;

	public bool A8CAA1A1D6C34719;

	public bool _4C81ADCD89774CA4 = true;

	public bool A9449C8C144D4F20;

	public uint FA5227EBF51C4830;

	public uint _8905377ABE704BFE;

	public int _93465A3F7777406A;

	public int _16A30728D8F24ABA = int.MaxValue;

	public int D25D2B302B15425A = int.MaxValue;

	public uint _66DFA475E6E44883;

	public Vector3 _0470E9D8F53D43C6;

	public Vector3 E3BF9E318C8C479C;

	public Vector3 _405D2BC828C54062;

	public Vector3 FAD3BEF525734183;

	public Vector3 _279E82653E8044B4;

	public Vector3 _161169EF650F461B;

	public Vector3 ACDFDD5F50BA4EE4;

	public Vector3 _2239119055A24DB6;

	public Vector3 _7DB446BC37394145;

	public Vector3 _625ACB8DDEB14250;

	public Vector3 _7E879489692D4CC6;

	public Quaternion _02FAEBC136A94E70;

	public Quaternion _402AC6E5E1384F45;

	public float _951F40FDB1074005;

	public float _17C6388F3DE84B2B;

	public float C1D4B088000A43F8;

	public float A8FB94688F4C4B35;

	public float A8FCE6FD7FE4456C;

	public float D4560BCC60764D96;

	public bool? _240AC7891F614FA9;

	public bool? _3C08C9E51ADE47D6;

	public bool? CC644991BE804441;

	public int _8E4287F6739840E3;

	public int _76E6835786544997;

	public int _4D150B4B0F404274;

	public int A31167D13F474774;

	public int B15F680A5C1C4162;

	public int _51E8409FD0C24C3F;

	public float A32FC08A3104466A;

	public float _33C2CFF056124D4E;

	public static int _70BA6327CD734381(int P_0)
	{
		if (P_0 < int.MaxValue)
		{
			return P_0 + 1;
		}
		return int.MaxValue;
	}

	public bool _5E9772367AA844EF(A3116505AAB24996 P_0, InteractableVehicle P_1)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		bool valueOrDefault = _240AC7891F614FA9 == true;
		if (!_240AC7891F614FA9.HasValue)
		{
			valueOrDefault = _1187FAD6AB3F40BD.A67FA565DF2B4DD8(P_0, P_1, ACDFDD5F50BA4EE4, _402AC6E5E1384F45);
			_240AC7891F614FA9 = valueOrDefault;
			return valueOrDefault;
		}
		return valueOrDefault;
	}

	public bool _5E1BF4EB49FC4BD6(InteractableVehicle P_0)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		bool valueOrDefault = _3C08C9E51ADE47D6 == true;
		if (!_3C08C9E51ADE47D6.HasValue)
		{
			valueOrDefault = _1187FAD6AB3F40BD._5611D904424148FF(P_0, ACDFDD5F50BA4EE4, _402AC6E5E1384F45);
			_3C08C9E51ADE47D6 = valueOrDefault;
			return valueOrDefault;
		}
		return valueOrDefault;
	}

	public bool _0CAA8017E59C4B00()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		bool valueOrDefault = CC644991BE804441 == true;
		if (!CC644991BE804441.HasValue)
		{
			valueOrDefault = WaterUtility.isPointUnderwater(ACDFDD5F50BA4EE4 + new Vector3(0f, -1.5f, 0f));
			CC644991BE804441 = valueOrDefault;
			return valueOrDefault;
		}
		return valueOrDefault;
	}
}
