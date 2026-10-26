using System;
using SDG.Unturned;
using UnityEngine;

internal class D67833F516334C13 : _89ED754871B24D32
{
	private const int FF423F017C434D6C = 11;

	private static readonly float _01DC0C7C8F164353;

	private static readonly float A21153569A8745A8;

	private static readonly float _4893DFDA7AE84F4C;

	public virtual ECheckType F2033207E12A4587()
	{
		return ECheckType.RotationSpeed;
	}

	public virtual (string debug, EFlagLevel level)? D93C2B4181BF449E(A3116505AAB24996 P_0, Player P_1, InteractableVehicle P_2, Rigidbody P_3, _222604882F4244C0 P_4, _7B93EFC9B3644586 P_5)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!P_5.B5D48CE083EC49C0 || (int)P_2.asset.engine == 0)
		{
			return null;
		}
		float magnitude = P_5._7E879489692D4CC6.magnitude;
		if (magnitude > P_3.maxAngularVelocity + _4893DFDA7AE84F4C)
		{
			E747CEFE7DD94657 e747CEFE7DD = _89ED754871B24D32._0736621F55AC491C._3ECE4ABFF9E04BFF<E747CEFE7DD94657>();
			e747CEFE7DD._265309AD78C3406B = P_1.channel.owner.playerID.steamID.m_SteamID;
			e747CEFE7DD._40B2446DD91E454C = ((Asset)P_2.asset).FriendlyName;
			e747CEFE7DD.A4A8FDF1DCA04887 = P_2.asset.engine;
			e747CEFE7DD._05063342CCCA4D92 = magnitude;
			e747CEFE7DD.E9A6124F4CF844C3 = P_3.maxAngularVelocity;
			e747CEFE7DD.E5DE9564B6934DB7 = _4893DFDA7AE84F4C;
			e747CEFE7DD._70825D7549064B3F = P_5.D25D2B302B15425A;
			e747CEFE7DD._9B64CFADC173462D = (int)(P_5._8905377ABE704BFE - P_5.FA5227EBF51C4830);
			_89ED754871B24D32._0736621F55AC491C.CB4E939A3F83474C("Vehicle Rotation Speed V5", e747CEFE7DD);
			return ("type: A", EFlagLevel.Critical);
		}
		return null;
	}

	static D67833F516334C13()
	{
		GC.KeepAlive(null);
	}
}
