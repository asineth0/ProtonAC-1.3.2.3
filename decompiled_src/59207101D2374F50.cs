using SDG.Unturned;
using UnityEngine;

internal class _59207101D2374F50 : _89ED754871B24D32
{
	public virtual ECheckType DD6CC759B89C44CE()
	{
		return ECheckType.NoClipping;
	}

	public virtual (string debug, EFlagLevel level)? _87767B34EE4B400A(A3116505AAB24996 P_0, Player P_1, InteractableVehicle P_2, Rigidbody P_3, _222604882F4244C0 P_4, _7B93EFC9B3644586 P_5)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		bool flag = _1187FAD6AB3F40BD.EBAE00EFCB7849E4(P_0, P_2, P_5._0470E9D8F53D43C6, P_5._02FAEBC136A94E70, P_5.ACDFDD5F50BA4EE4, P_5._402AC6E5E1384F45, out string _, out float _);
		P_5._93465A3F7777406A = (flag ? (P_5._93465A3F7777406A + 1) : 0);
		if (flag)
		{
			_1187FAD6AB3F40BD._250BEFC7C7AA4F04(P_0, P_2, P_5._0470E9D8F53D43C6, P_5._02FAEBC136A94E70, P_5.ACDFDD5F50BA4EE4, P_5._402AC6E5E1384F45, out var obj);
			EF50FD92909145D6 eF50FD92909145D = _89ED754871B24D32._0736621F55AC491C._3ECE4ABFF9E04BFF<EF50FD92909145D6>();
			eF50FD92909145D._63E6A516D4034E7A = P_1.channel.owner.playerID.steamID.m_SteamID;
			eF50FD92909145D._1B67685397164669 = ((Asset)P_2.asset).FriendlyName;
			eF50FD92909145D.C0C6B4C94BDD4FF6 = ((Asset)P_2.asset).id;
			eF50FD92909145D.E60236EC23F74F41 = P_2.asset.engine;
			eF50FD92909145D._603906CD5E8048EC = obj._831CDD28B3334ED3;
			eF50FD92909145D._6146B99DE0C04927 = obj._66C285F040784DEA;
			eF50FD92909145D._5BA684F567334D38 = P_5.ACDFDD5F50BA4EE4;
			eF50FD92909145D._0FA0D5C48A94429C = P_5._0470E9D8F53D43C6;
			eF50FD92909145D._21C313F2C61C4951 = Vector3.Distance(P_5._0470E9D8F53D43C6, P_5.ACDFDD5F50BA4EE4);
			eF50FD92909145D.B7917955F0A24475 = Quaternion.Angle(P_5._02FAEBC136A94E70, P_5._402AC6E5E1384F45);
			eF50FD92909145D._76C8C2B285804FAC = P_5._625ACB8DDEB14250;
			eF50FD92909145D._32AA8C76EC064436 = P_5._17C6388F3DE84B2B;
			eF50FD92909145D.F72FC2BE967B465E = P_4._4AEC7A8C281646EB.Count;
			eF50FD92909145D.FD01F47E73EE4770 = P_5.A9449C8C144D4F20;
			eF50FD92909145D._2EB2208F23D94498 = obj.BCFADB9DBA5046B2;
			eF50FD92909145D._303F68722B4545BD = obj.B0400B656E174CFF;
			eF50FD92909145D.E1C097F36C4F47EA = obj._704A9699F0F841A0;
			eF50FD92909145D.C90937A6464F42B2 = obj._2075AB1574864CD3;
			eF50FD92909145D._1721D20D61DF49EB = obj._125E41DDDACD4BB4;
			eF50FD92909145D.C4A6E73FC54F4317 = obj._3BA29E39A1C84E78;
			eF50FD92909145D._56ED4259C45B4A6D = obj._2C2EBDFA04F64CF8;
			eF50FD92909145D._8726E31220BC49B2 = obj._26A6A001B15543E6;
			eF50FD92909145D.F01A348C4328455A = obj._265951FB987C48A7;
			eF50FD92909145D._7DE9812063064D03 = obj.CA2A01D1C2C04068;
			eF50FD92909145D.E7C4E9937A4B43FC = obj._3F7DEBF52DD04720;
			eF50FD92909145D._40C21CB00EEB4841 = obj.F79F396EC5B74A3A;
			eF50FD92909145D.EDD89C0EC26E4E8F = obj._98A8CF7E90F24993;
			eF50FD92909145D._42E2E936AF9C4B41 = obj._736276B1DE6B437E;
			eF50FD92909145D._4FDDF6C345944722 = obj.D1FEEC78C4574F96;
			eF50FD92909145D._0886062C99154A76 = obj._33FDB0B56FF44938;
			eF50FD92909145D.CB4427761D7740FE = obj._868B8EC3122A4788;
			eF50FD92909145D._95B2C4FAB7344AE3 = ((Component)P_2).transform.position;
			eF50FD92909145D.FA946D0BCA0748B3 = Quaternion.Angle(((Component)P_2).transform.rotation, P_5._402AC6E5E1384F45);
			eF50FD92909145D.B3EB4A7FA81542A3 = Time.frameCount;
			eF50FD92909145D.F0B14899B3264479 = (int)(P_5._8905377ABE704BFE - P_5.FA5227EBF51C4830);
			eF50FD92909145D.EAB61672AA2C4744 = P_5._93465A3F7777406A;
			eF50FD92909145D._6CD6F80B7E824894 = P_5._16A30728D8F24ABA;
			eF50FD92909145D._125C402CBA7543AF = P_5._5E1BF4EB49FC4BD6(P_2);
			_89ED754871B24D32._0736621F55AC491C.CB4E939A3F83474C("Vehicle NoClipping V5", eF50FD92909145D);
			return ("type: E (c: " + obj._831CDD28B3334ED3 + ")", EFlagLevel.Minimal);
		}
		return null;
	}
}
