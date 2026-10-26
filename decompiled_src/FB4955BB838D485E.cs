using System;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

public class FB4955BB838D485E : _760EF57D5259421C
{
	private static bool A9CBD13D56B944EA;

	public virtual void _59F72B64E7E84E50()
	{
		A5A2C9BAF1B34D4E._99554ED4AEB84AF8 obj = null;
		_60A2A9CE74704AEC((Delegate)null, (Delegate)obj);
		throw new Exception();
	}

	public virtual void _8129B5B072C343B3()
	{
		A5A2C9BAF1B34D4E._6CA34B82A6AC4EDE = (A5A2C9BAF1B34D4E._99554ED4AEB84AF8)_2C503C4312A54A94((Delegate)A5A2C9BAF1B34D4E._6CA34B82A6AC4EDE, (Delegate)new A5A2C9BAF1B34D4E._99554ED4AEB84AF8(_11166B7ED2344120));
		_836E5F85888A4C53();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _79B4ACF1084A40AA()
	{
		GC.KeepAlive(null);
	}

	private void _11166B7ED2344120(A3116505AAB24996 P_0, Player P_1, bool P_2, bool P_3)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		if (!A9CBD13D56B944EA || P_0.A98460F771B0446B(_760EF57D5259421C._8DC4187752784460, _760EF57D5259421C._1D28939F0C774697, P_1.channel.owner.playerID.steamID))
		{
			return;
		}
		float num = P_0._0E84A52D8B85441F * MathF.PI / 180f;
		float num2 = P_0.DB788F5F95DC46A0.y * Mathf.Cos(num) + P_0.DB788F5F95DC46A0.x * Mathf.Sin(num);
		float num3 = P_0.DB788F5F95DC46A0.y * Mathf.Sin(num) - P_0.DB788F5F95DC46A0.x * Mathf.Cos(num);
		P_0._8363984560D540DE = P_0._83F11E366F4442B7;
		P_0._83F11E366F4442B7 = new Vector3(num2, 0f, num3);
		if (P_0._8363984560D540DE.sqrMagnitude < 0.0001f || P_0._83F11E366F4442B7.sqrMagnitude < 0.0001f || P_0._8363984560D540DE != P_0._83F11E366F4442B7)
		{
			return;
		}
		if (P_0.A4B01A943DEF4AFA > 80f && P_0._30A4019A1B0C4B0C <= 0.1f && !_9AB67761792440A7._07BEDFFE3B604170(P_0._68911883297A44E0) && !E88CCE3449334873(P_0, P_1))
		{
			if (P_0._90DBC4A6726F474A._8853594054184234() > 3f)
			{
				_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(P_1.channel.owner.playerID, ECheckCategory.Analysis, ECheckType.SpinBot, EFlagLevel.Minimal, $"type: A (d: {P_0.A4B01A943DEF4AFA} p: {P_0._68911883297A44E0})");
			}
		}
		else if (P_0.A4B01A943DEF4AFA > 50f && P_0.A4B01A943DEF4AFA == P_0._6386C4789B9E4530 && !E88CCE3449334873(P_0, P_1))
		{
			if (P_0._90DBC4A6726F474A._8853594054184234() > 3f)
			{
				_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(P_1.channel.owner.playerID, ECheckCategory.Analysis, ECheckType.SpinBot, EFlagLevel.Minimal, $"type: B (d: {P_0.A4B01A943DEF4AFA})");
			}
		}
		else if (P_0.A4B01A943DEF4AFA > 50f && P_0.A4B01A943DEF4AFA % 1f == 0f && P_0.A4B01A943DEF4AFA != 0f && !E88CCE3449334873(P_0, P_1))
		{
			if (P_0._90DBC4A6726F474A._8853594054184234() > 3f)
			{
				_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(P_1.channel.owner.playerID, ECheckCategory.Analysis, ECheckType.SpinBot, EFlagLevel.Shadow, $"type: C (d: {P_0.A4B01A943DEF4AFA})");
			}
		}
		else
		{
			P_0._90DBC4A6726F474A._19F5F779612A4A8C(0.25f);
		}
	}

	private bool E88CCE3449334873(A3116505AAB24996 P_0, Player P_1)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (P_0._443482020698440D != 0L && _9AB67761792440A7._00FC653ED33A4A96() - P_0._443482020698440D <= A3116505AAB24996.A77D61B4B0FD460D)
		{
			return true;
		}
		bool result = false;
		foreach (Collider trackingTeleporter in F0CD1E00058640DE.trackingTeleporters)
		{
			Bounds bounds = trackingTeleporter.bounds;
			if (bounds.SqrDistance(P_0._76477626BCDE4550._7ED3CB3A6B244A09(P_1).AE0F78E8DD484598) <= 16f)
			{
				result = true;
				break;
			}
		}
		return result;
	}

	static object _60A2A9CE74704AEC(Delegate P_0, Delegate P_1)
	{
		return Delegate.Combine(P_0, P_1);
	}

	void EE7D12296CF048ED()
	{
		base.A599C828530B4E69();
	}

	static object _2C503C4312A54A94(Delegate P_0, Delegate P_1)
	{
		return Delegate.Remove(P_0, P_1);
	}

	void _836E5F85888A4C53()
	{
		base.C4CA2ECFAD654E77();
	}
}
