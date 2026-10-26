using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using HarmonyLib;
using SDG.Unturned;
using UnityEngine;

internal class _324819153CA4494E : _760EF57D5259421C
{
	private static readonly FieldRef<InteractableVehicle, bool> _8908D01AEBC84DB9;

	private static readonly MethodInfo _90E72066F66449EA;

	private static readonly MethodInfo E41D96F206BA4CE6;

	private static readonly _89ED754871B24D32[] _1718C3E3AE2D4E7F;

	private static readonly List<Collider> AC27DBCED8E2445F;

	public virtual void _6B10D39431EA4CCB()
	{
		AC27DBCED8E2445F = null;
		throw new Exception();
	}

	public virtual void _55C18F68693B45D4()
	{
		_25BE834779884F9D.D3C21D90722D4956 = (_25BE834779884F9D._4BEC7538754E4310)Delegate.Remove(_25BE834779884F9D.D3C21D90722D4956, new _25BE834779884F9D._4BEC7538754E4310(_7DC2DA5A942F45AF));
		_95700E7667D44DBC._2CEF4C877BE941D9 = (_95700E7667D44DBC._86DC58AD1D534F3E)Delegate.Remove(_95700E7667D44DBC._2CEF4C877BE941D9, new _95700E7667D44DBC._86DC58AD1D534F3E(C2190858BE3D469E));
		base.C4CA2ECFAD654E77();
	}

	public virtual void C09A92C44A1A4196()
	{
		throw new Exception();
	}

	private void C2190858BE3D469E(Player P_0, in ServerInvocationContext P_1, InteractableVehicle P_2, ref Vector3 P_3)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(P_0);
		if (a3116505AAB != null)
		{
			float num = Mathf.Min(a3116505AAB._1610010BF5BD47DA._951F40FDB1074005 + 2.5f, Mathf.Max(Mathf.Abs(P_2.asset.TargetForwardVelocity), Mathf.Abs(P_2.asset.TargetReverseVelocity)));
			P_3 = a3116505AAB._1610010BF5BD47DA.E3BF9E318C8C479C.normalized * Mathf.Clamp(P_3.magnitude, 0f - num, num);
		}
	}

	private void _7DC2DA5A942F45AF(InteractableVehicle P_0, uint P_1, bool P_2, Vector3 P_3, Quaternion P_4, float P_5, float P_6, float P_7, float P_8)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		Player driverPlayer = P_0.GetDriverPlayer();
		if ((Object)(object)driverPlayer == (Object)null || (int)P_0.asset.engine == 5)
		{
			return;
		}
		bool flag = _8908D01AEBC84DB9.Invoke(P_0);
		SteamPlayerID playerID = driverPlayer.channel.owner.playerID;
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(driverPlayer);
		if (a3116505AAB == null || a3116505AAB.A98460F771B0446B(_760EF57D5259421C._8DC4187752784460, _760EF57D5259421C._1D28939F0C774697, driverPlayer.channel.owner.playerID.steamID))
		{
			return;
		}
		if (a3116505AAB._1610010BF5BD47DA._4C81ADCD89774CA4)
		{
			a3116505AAB._1610010BF5BD47DA._4C81ADCD89774CA4 = false;
			a3116505AAB._965694AA41EB4336.F0CE0620916B414A.Clear();
			a3116505AAB._965694AA41EB4336._4AEC7A8C281646EB.Clear();
			AC27DBCED8E2445F.Clear();
			((Component)P_0).GetComponentsInChildren<Collider>(AC27DBCED8E2445F);
			foreach (Collider item in AC27DBCED8E2445F)
			{
				if ((Object)(object)item == (Object)null || item.isTrigger || (Object)(object)item.attachedRigidbody != (Object)(object)_64A4BBC5E4CE4EE1._1666B192DD1445FB.Invoke(P_0) || !_1187FAD6AB3F40BD.D58FF514B9754D06(((Component)item).gameObject.layer) || (Object)(object)((Component)item).GetComponentInParent<Bumper>(true) != (Object)null)
				{
					continue;
				}
				if (_9AB67761792440A7.CFAE6A363DB74C8E(P_0, item, out var flag2))
				{
					if (!flag2)
					{
						a3116505AAB._965694AA41EB4336.F0CE0620916B414A.Add(item);
						continue;
					}
				}
				else if (!item.enabled || !((Component)item).gameObject.activeInHierarchy)
				{
					continue;
				}
				a3116505AAB._965694AA41EB4336._4AEC7A8C281646EB.Add(item);
				a3116505AAB._965694AA41EB4336.F0CE0620916B414A.Add(item);
			}
			a3116505AAB._965694AA41EB4336.FF7A51941D954D73.Clear();
			((Component)P_0).GetComponentsInChildren<ConstantForce>(true, a3116505AAB._965694AA41EB4336.FF7A51941D954D73);
		}
		if (a3116505AAB._965694AA41EB4336.BA0F0BD00C2E4CDA.DE13140484C148CD > 0)
		{
			if (!flag)
			{
				a3116505AAB._965694AA41EB4336._6ED654F8D3C449A4(P_3, P_4);
			}
		}
		else
		{
			a3116505AAB._965694AA41EB4336._6ED654F8D3C449A4(((Component)P_0).transform.position, ((Component)P_0).transform.rotation);
		}
		a3116505AAB.C081DA16FC904E1E = false;
		Rigidbody val = _64A4BBC5E4CE4EE1._1666B192DD1445FB.Invoke(P_0);
		bool flag3 = flag || a3116505AAB._1610010BF5BD47DA.A8CAA1A1D6C34719;
		a3116505AAB._1610010BF5BD47DA._3C08C9E51ADE47D6 = null;
		a3116505AAB._1610010BF5BD47DA._240AC7891F614FA9 = null;
		a3116505AAB._1610010BF5BD47DA.CC644991BE804441 = null;
		a3116505AAB._1610010BF5BD47DA.ACDFDD5F50BA4EE4 = P_3;
		a3116505AAB._1610010BF5BD47DA._402AC6E5E1384F45 = P_4;
		a3116505AAB._1610010BF5BD47DA._17C6388F3DE84B2B = P_5;
		a3116505AAB._1610010BF5BD47DA.C1D4B088000A43F8 = P_6;
		a3116505AAB._1610010BF5BD47DA.A8FB94688F4C4B35 = P_8;
		a3116505AAB._1610010BF5BD47DA.A9449C8C144D4F20 = flag3;
		a3116505AAB._1610010BF5BD47DA._8905377ABE704BFE = P_1;
		a3116505AAB._1610010BF5BD47DA._16A30728D8F24ABA = ((!flag3) ? _7B93EFC9B3644586._70BA6327CD734381(a3116505AAB._1610010BF5BD47DA._16A30728D8F24ABA) : 0);
		bool flag4 = a3116505AAB._7F3836A6EEFC4FC4 != a3116505AAB._1610010BF5BD47DA._66DFA475E6E44883 || !a3116505AAB._1610010BF5BD47DA.B5D48CE083EC49C0 || P_1 - a3116505AAB._1610010BF5BD47DA.FA5227EBF51C4830 != 1;
		a3116505AAB._1610010BF5BD47DA._66DFA475E6E44883 = a3116505AAB._7F3836A6EEFC4FC4;
		a3116505AAB._1610010BF5BD47DA.D25D2B302B15425A = ((!flag4) ? _7B93EFC9B3644586._70BA6327CD734381(a3116505AAB._1610010BF5BD47DA.D25D2B302B15425A) : 0);
		a3116505AAB._1610010BF5BD47DA._2239119055A24DB6 = P_3 + P_4 * Vector3.Scale(val.centerOfMass, ((Component)P_0).transform.lossyScale);
		if (!a3116505AAB._1610010BF5BD47DA.B5D48CE083EC49C0)
		{
			a3116505AAB._1610010BF5BD47DA._0470E9D8F53D43C6 = P_3;
			a3116505AAB._1610010BF5BD47DA._02FAEBC136A94E70 = P_4;
			a3116505AAB._1610010BF5BD47DA._405D2BC828C54062 = a3116505AAB._1610010BF5BD47DA._2239119055A24DB6;
		}
		a3116505AAB._1610010BF5BD47DA._7DB446BC37394145 = a3116505AAB._1610010BF5BD47DA._2239119055A24DB6 - a3116505AAB._1610010BF5BD47DA._405D2BC828C54062;
		a3116505AAB._1610010BF5BD47DA._625ACB8DDEB14250 = a3116505AAB._1610010BF5BD47DA._7DB446BC37394145 / PlayerInput.RATE;
		Quaternion val2 = Quaternion.Inverse(a3116505AAB._1610010BF5BD47DA._02FAEBC136A94E70) * P_4;
		float num = default;
		Vector3 val3 = default;
		val2.ToAngleAxis(ref num, ref val3);
		if (num > 180f)
		{
			num = 360f - num;
			val3 = -val3;
		}
		a3116505AAB._1610010BF5BD47DA._7E879489692D4CC6 = val3.normalized * (num * (MathF.PI / 180f) / PlayerInput.RATE);
		(string, EFlagLevel)? tuple = null;
		_89ED754871B24D32 obj = null;
		_89ED754871B24D32[] array = _1718C3E3AE2D4E7F;
		foreach (_89ED754871B24D32 obj2 in array)
		{
			if (obj2._269AF1CBDF4E4DDF)
			{
				(string, EFlagLevel)? tuple2 = obj2._0FF402D9B2444C73(a3116505AAB, driverPlayer, P_0, val, a3116505AAB._965694AA41EB4336, a3116505AAB._1610010BF5BD47DA);
				if (!tuple.HasValue)
				{
					tuple = tuple2;
					obj = obj2;
				}
			}
		}
		Vector3 e3BF9E318C8C479C = P_3 - a3116505AAB._1610010BF5BD47DA._0470E9D8F53D43C6;
		a3116505AAB._1610010BF5BD47DA._405D2BC828C54062 = a3116505AAB._1610010BF5BD47DA._2239119055A24DB6;
		a3116505AAB._1610010BF5BD47DA.FAD3BEF525734183 = a3116505AAB._1610010BF5BD47DA._7DB446BC37394145;
		a3116505AAB._1610010BF5BD47DA._161169EF650F461B = a3116505AAB._1610010BF5BD47DA._7E879489692D4CC6;
		a3116505AAB._1610010BF5BD47DA._279E82653E8044B4 = a3116505AAB._1610010BF5BD47DA._625ACB8DDEB14250;
		a3116505AAB._1610010BF5BD47DA._0470E9D8F53D43C6 = P_3;
		a3116505AAB._1610010BF5BD47DA._02FAEBC136A94E70 = P_4;
		a3116505AAB._1610010BF5BD47DA.FA5227EBF51C4830 = P_1;
		a3116505AAB._1610010BF5BD47DA._951F40FDB1074005 = P_5;
		a3116505AAB._1610010BF5BD47DA.D4560BCC60764D96 = P_8;
		a3116505AAB._1610010BF5BD47DA.E3BF9E318C8C479C = e3BF9E318C8C479C;
		a3116505AAB._1610010BF5BD47DA.B5D48CE083EC49C0 = true;
		if (tuple.HasValue && obj != null)
		{
			if (obj._4ACC43F9466F41CD)
			{
				bool isKinematic = val.isKinematic;
				val.isKinematic = true;
				val.position = a3116505AAB._965694AA41EB4336.BA0F0BD00C2E4CDA.E8BE769561E344FF(0).EB980DF04A52435C;
				val.rotation = a3116505AAB._965694AA41EB4336.BA0F0BD00C2E4CDA.E8BE769561E344FF(0)._096783DA9551468B;
				val.isKinematic = isKinematic;
				a3116505AAB.C31CABBC84034E20 = true;
			}
			_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(playerID, ECheckCategory.VehicleMovement, obj._2115E39EB2D34824(), tuple.Value.Item2, $"{tuple.Value.Item1} type: {((object)P_0.asset.engine/*cast due to constrained. prefix*/).ToString().ToLower()} i: {((Asset)P_0.asset).id} r: {flag || a3116505AAB._1610010BF5BD47DA.A8CAA1A1D6C34719}");
		}
		else if (!flag3)
		{
			a3116505AAB.A17C7ECBE5454B78 = Mathf.Max(0f, a3116505AAB.A17C7ECBE5454B78 - 0.25f);
		}
	}

	static _324819153CA4494E()
	{
		E651E17AA2CA4BC8._44E3775C76EA45B6((Func<Task>)null, default(CancellationToken));
		E651E17AA2CA4BC8._44E3775C76EA45B6((Func<Task>)null, default(CancellationToken));
		_ = new _89ED754871B24D32[5];
		new B6EA0A2F39B94A06();
		new _76ADFA724BE5493C();
		new D67833F516334C13();
		new _9AD43A3E564C4B20();
		new _59207101D2374F50();
	}
}
