using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

public class _3301ED6AA1A1474A : _760EF57D5259421C
{
	private static readonly C4462CD02B8C4225 _330FDA4EC89F4E11;

	private static readonly A19CBF069C964833 _3A703214152C42FC;

	private static readonly A19CBF069C964833._40FE7AC3F69F4B10 CB0389EA159949C6;

	private static readonly float[] FD4D20FF11034FCD;

	private static readonly bool[] _93E7D5D36D3A438E;

	private static bool _33A24EE4CDFF4100;

	private static bool _99B939528A7A4B74;

	public virtual void FF143A0CEA054A0C()
	{
		A76A63943FD04779._133C560B942C4748 obj = null;
		EF3E97E51C654670((Delegate)null, (Delegate)obj);
		A30F7371EEB94415.E2EA6C8214674B80 e2EA6C8214674B = null;
		EF3E97E51C654670((Delegate)null, (Delegate)e2EA6C8214674B);
		throw new Exception();
	}

	public virtual void _72E152AF30E94AF5()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected Obj, but got Unknown
		A76A63943FD04779._89D43889C2AB4B27 = (A76A63943FD04779._133C560B942C4748)_290B5909C49646BA((Delegate)A76A63943FD04779._89D43889C2AB4B27, (Delegate)new A76A63943FD04779._133C560B942C4748(_8126847C5EA64732));
		_72C3EAEF92B04D9F((BulletSpawnedHandler)_66E9B37D500B4EEB);
		A30F7371EEB94415._3B2526A411C740E5 = (A30F7371EEB94415.E2EA6C8214674B80)_290B5909C49646BA((Delegate)A30F7371EEB94415._3B2526A411C740E5, (Delegate)new A30F7371EEB94415.E2EA6C8214674B80(F9E474F0EF3E4903));
		_27C5535316184D7A();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _55B1D16265F64FD9()
	{
		GC.KeepAlive(null);
	}

	private void _66E9B37D500B4EEB(UseableGun P_0, BulletInfo P_1)
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		if (D0AC8C9EC45A4010((Object)_967D63AFE66E49D3((object)P_0), (Object)null))
		{
			return;
		}
		A3116505AAB24996 a3116505AAB = (A3116505AAB24996)F35EA5130E5C4B9F((Player)_967D63AFE66E49D3((object)P_0));
		if (a3116505AAB != null)
		{
			float num2;
			float num = (num2 = _64A4BBC5E4CE4EE1.B499E9D51CA345F9(P_0));
			if (num2 < 1f)
			{
				num2 = 0f;
			}
			float num3 = num;
			if (num3 > 0f)
			{
				num3 = 1f;
			}
			float num4 = _12C6BA1F5C5F4F11(a3116505AAB, P_0, true);
			float num5 = _12C6BA1F5C5F4F11(a3116505AAB, P_0, false);
			object obj = _461134DB7B2F479E();
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._3491A0DDF1674FF0 = P_0;
			((_4819911A0C0846FF._3147FDB5568446E9)obj).CB743CD423CB4991 = C835504939554F4A((object)a3116505AAB._76477626BCDE4550, _967D63AFE66E49D3((object)P_0));
			((_4819911A0C0846FF._3147FDB5568446E9)obj).BCEAA4E8A41640C2 = a3116505AAB._76477626BCDE4550._5C521683885F483B.ToList();
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._9EB9E2BEE74640DC = _2365255CDB0F4772((object)a3116505AAB._76477626BCDE4550, _967D63AFE66E49D3((object)P_0));
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._63B79AD0C1094E94 = a3116505AAB._92A513FF7BCD47D5;
			((_4819911A0C0846FF._3147FDB5568446E9)obj).EB3D8ED29BD04389 = a3116505AAB.F1E0B3F113944108;
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._04A7C19047954A74 = a3116505AAB._2B10E1CD34274F52;
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._7721B403999045BE = a3116505AAB._6C4C6ABD35E0410D;
			((_4819911A0C0846FF._3147FDB5568446E9)obj).B816394284A14C8D = _00474FF99D904A2F(a3116505AAB, P_0, num2, P_1.quality, true) * 57.29578f;
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._979A197054D84450 = _00474FF99D904A2F(a3116505AAB, P_0, num3, P_1.quality, false) * 57.29578f;
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._5E8B57884ED846F7 = Vector3.Angle(Vector3.forward, Quaternion.Euler(num4, num4, 0f) * Vector3.forward);
			((_4819911A0C0846FF._3147FDB5568446E9)obj).E8B36921B188475B = Vector3.Angle(Vector3.forward, Quaternion.Euler(num5, num5, 0f) * Vector3.forward);
			((_4819911A0C0846FF._3147FDB5568446E9)obj).B20DDC09C08540F1 = _1173B9E4F20B4119((object)this, (object)a3116505AAB, (object)P_0, true);
			((_4819911A0C0846FF._3147FDB5568446E9)obj).ECEA119252CD4167 = _1173B9E4F20B4119((object)this, (object)a3116505AAB, (object)P_0, false);
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._30249645703B47E7 = a3116505AAB._35F1EA6BE31E4755._3F81FECA615E459B.F912CB261E164317;
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._48BEC7816DA943BC = a3116505AAB._35F1EA6BE31E4755.AB336DF9A66E4F8D.F912CB261E164317;
			((_4819911A0C0846FF._3147FDB5568446E9)obj).B32947997F7043B7 = a3116505AAB._50DD9E33A315462C;
			((_4819911A0C0846FF._3147FDB5568446E9)obj).AC47143ADD1E42BC = P_1.quality;
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._7828A186B79F4E4F = a3116505AAB._6E6AA4FFF0BB4169;
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._8BCCCC895AFF484D = a3116505AAB.D7F987AB3D1A4517;
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._48FE83AE14EC46DA = a3116505AAB._1C517C8A588A47C1;
			((_4819911A0C0846FF._3147FDB5568446E9)obj)._05D08946EDA64DEC = a3116505AAB._76477626BCDE4550._722C1E3EDF244863;
			((_4819911A0C0846FF._3147FDB5568446E9)obj).A06E15E132D548C1 = _64A4BBC5E4CE4EE1._64E6F1F457E046B9.Invoke(P_1);
			((_4819911A0C0846FF._3147FDB5568446E9)obj).BAC3D1236F334A36 = a3116505AAB.CFA8D5E44E2A4880;
			((_4819911A0C0846FF._3147FDB5568446E9)obj).B0169C33A3674C0D = a3116505AAB._1D67FF3A771947F1.A88639D29F0644DC;
			_4819911A0C0846FF._3147FDB5568446E9 item = (_4819911A0C0846FF._3147FDB5568446E9)obj;
			a3116505AAB._39063EF1442C4822.F933B05D5259474E.Add(item);
		}
	}

	private void F9E474F0EF3E4903(Player P_0)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		using (CB0389EA159949C6._5D65B053CE1947AD())
		{
			A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(P_0);
			if (a3116505AAB == null)
			{
				return;
			}
			a3116505AAB._39063EF1442C4822._0AF680B55A654923();
			foreach (_4819911A0C0846FF._3147FDB5568446E9 item in a3116505AAB._39063EF1442C4822.F933B05D5259474E)
			{
				if (item._62DB85C9E0D5497C)
				{
					continue;
				}
				item._62DB85C9E0D5497C = true;
				item._48FE83AE14EC46DA = item._48FE83AE14EC46DA || a3116505AAB._1C517C8A588A47C1;
				item._05D08946EDA64DEC = item._05D08946EDA64DEC || a3116505AAB._76477626BCDE4550._722C1E3EDF244863;
				item.FE6AF73253D346E7 = a3116505AAB._76477626BCDE4550._7ED3CB3A6B244A09(P_0);
				item._005A4DCA76144918 = a3116505AAB._6E6AA4FFF0BB4169;
				item._0CDF4F72C2204DA3 = a3116505AAB.D7F987AB3D1A4517;
				item._1B0ED80F923E4586 = a3116505AAB._92A513FF7BCD47D5;
				item._803CF3EE969F42B9 = a3116505AAB.F1E0B3F113944108;
				if ((Object)(object)item._3491A0DDF1674FF0 != (Object)null && (Object)(object)((PlayerCaller)item._3491A0DDF1674FF0).player != (Object)null && (Object)(object)P_0.equipment.useable == (Object)(object)item._3491A0DDF1674FF0)
				{
					float num2;
					float num = (num2 = _64A4BBC5E4CE4EE1.B499E9D51CA345F9(item._3491A0DDF1674FF0));
					if (num2 < 1f)
					{
						num2 = 0f;
					}
					float num3 = num;
					if (num3 > 0f)
					{
						num3 = 1f;
					}
					item.B816394284A14C8D = Mathf.Max(item.B816394284A14C8D, _00474FF99D904A2F(a3116505AAB, item._3491A0DDF1674FF0, num2, item.AC47143ADD1E42BC, true) * 57.29578f);
					item._979A197054D84450 = Mathf.Min(item._979A197054D84450, _00474FF99D904A2F(a3116505AAB, item._3491A0DDF1674FF0, num3, item.AC47143ADD1E42BC, false) * 57.29578f);
				}
				float num4 = Mathf.Max(0f, a3116505AAB.A4B01A943DEF4AFA - (item.BAC3D1236F334A36._1F27592A92314C22 - item.BAC3D1236F334A36._1F27592A92314C22 * item.BAC3D1236F334A36._1649BA3AC8EE497F / 4f));
				float num5 = Mathf.Max(0f, a3116505AAB._30A4019A1B0C4B0C - (item.BAC3D1236F334A36._8D09E60C866E478D - item.BAC3D1236F334A36._8D09E60C866E478D * item.BAC3D1236F334A36._6D5F05EB5E914328 / 4f));
				if (num4 > 10f && (Mathf.Abs(a3116505AAB._6386C4789B9E4530 - a3116505AAB.A4B01A943DEF4AFA) < 1f || Mathf.Abs(a3116505AAB._6386C4789B9E4530 - a3116505AAB.A4B01A943DEF4AFA) > 20f))
				{
					item._47914AA1386B4B09 = true;
				}
				if (num5 > 10f && (Mathf.Abs(a3116505AAB._978879363C27415A - a3116505AAB._30A4019A1B0C4B0C) < 1f || Mathf.Abs(a3116505AAB._978879363C27415A - a3116505AAB._30A4019A1B0C4B0C) > 20f))
				{
					item._47914AA1386B4B09 = true;
				}
			}
			bool flag = a3116505AAB._39063EF1442C4822._1430091BC74B40AC.Count > 0;
			bool flag2 = false;
			bool flag3 = false;
			while (a3116505AAB._39063EF1442C4822._1430091BC74B40AC.Count > 0)
			{
				_4819911A0C0846FF._80F40B3A6052448D obj = a3116505AAB._39063EF1442C4822._1430091BC74B40AC.Dequeue();
				_6F50DA8EC0F043B0(P_0, a3116505AAB, obj, ref flag2, ref flag3);
			}
			if (flag)
			{
				a3116505AAB._39063EF1442C4822._270EE9BEFABF4D71 = flag3;
			}
		}
	}

	private void _6F50DA8EC0F043B0(Player P_0, A3116505AAB24996 P_1, _4819911A0C0846FF._80F40B3A6052448D P_2, ref bool P_3, ref bool P_4)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		FD0E16AEF3D24100 fD0E16AEF3D = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<FD0E16AEF3D24100>();
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item in P_2._7EBE8DC10D2A4339)
		{
			if (item._62DB85C9E0D5497C)
			{
				Vector3 val = _9AB67761792440A7.B808EF2078734847(P_2.D6BBF61F7BD54CB5);
				fD0E16AEF3D.AECA3C750DAD4857.Add(new _322608EAC88B405F
				{
					_80AB575FD39C4E6E = Vector3.Distance(P_2.D6BBF61F7BD54CB5, item._9EB9E2BEE74640DC._8B47B2B22D864C7B),
					_96E05C14482C4185 = item.B816394284A14C8D,
					E2EAA89A1F8345A3 = item._979A197054D84450,
					_2330741451A043C4 = Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item._9EB9E2BEE74640DC._8B47B2B22D864C7B), val),
					AC1FA8EB8E964D7C = item._526C77F5AD8543F9 * Vector3.forward,
					F7DF37BF7FAA4EFC = item._24D6906F99D54084 * Vector3.forward,
					D89B44AECB7841E7 = item._5323059ADC574BFF * Vector3.forward,
					_4B96F51E25A54844 = item.B32947997F7043B7,
					_92E855646A9F4DDC = item._005A4DCA76144918,
					E93CB65015724FF4 = item._0CDF4F72C2204DA3
				});
			}
		}
		fD0E16AEF3D._6B5A75199FD14AC8 = P_0.channel.owner.playerID.steamID.m_SteamID;
		fD0E16AEF3D._2662C66770F646E3 = P_2._3186DEB29E9F4153;
		fD0E16AEF3D.E1593AC44DE4461A = P_2._40919D6F28DC47E4;
		fD0E16AEF3D._0669F8B67CB74C3C = P_2.F4C9529C16D1499B;
		fD0E16AEF3D.C70C69E26FDB4A9E = P_2._0377D473DDE24690;
		fD0E16AEF3D._683396EB90764033 = P_2.D6BBF61F7BD54CB5;
		_330FDA4EC89F4E11.CB4E939A3F83474C("Bullet Hit", fD0E16AEF3D);
		bool flag = false;
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item2 in P_2._7EBE8DC10D2A4339)
		{
			if (!item2._62DB85C9E0D5497C)
			{
				continue;
			}
			Vector3 val2 = _9AB67761792440A7.B808EF2078734847(P_2.D6BBF61F7BD54CB5);
			float num = Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item2._9EB9E2BEE74640DC._8B47B2B22D864C7B), val2);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item3 in item2.BCEAA4E8A41640C2)
			{
				num = Mathf.Min(num, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item3._8B47B2B22D864C7B), val2));
			}
			num = Mathf.Min(num, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item2.FE6AF73253D346E7._8B47B2B22D864C7B), val2));
			if (num < 3f)
			{
				flag = true;
				break;
			}
		}
		bool flag2 = false;
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item4 in P_2._7EBE8DC10D2A4339)
		{
			if (item4._47914AA1386B4B09)
			{
				flag2 = true;
				break;
			}
		}
		(string, EFlagLevel)? tuple = _08B6744903554277(P_0, P_1, P_2);
		if (tuple.HasValue)
		{
			_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(P_0.channel.owner.playerID, ECheckCategory.Analysis, ECheckType.NoSpread, tuple.Value.Item2, tuple.Value.Item1 + " | target: " + P_2._3186DEB29E9F4153);
		}
		_0A6E5AE484A347AB obj = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<_0A6E5AE484A347AB>();
		(string, bool)? tuple2 = E446912C38B240E8(P_0, P_1, P_2, obj);
		if (tuple2.HasValue)
		{
			if (tuple2.Value.Item2)
			{
				P_4 = true;
			}
			_330FDA4EC89F4E11.CB4E939A3F83474C("Silent Aim Bullet", obj);
			_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(P_0.channel.owner.playerID, ECheckCategory.Raycast, ECheckType.Bullet, EFlagLevel.Medium, tuple2.Value.Item1 + " | target: " + P_2._3186DEB29E9F4153);
		}
		else
		{
			_330FDA4EC89F4E11._840CF0233A3D467E(obj);
		}
		_9A1C7911656E423E obj2 = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<_9A1C7911656E423E>();
		(string, bool)? tuple3 = AAFEA23CEBF745BF(P_0, P_1, P_2, obj2);
		if (tuple3.HasValue)
		{
			bool flag3 = false;
			if (!P_3 && P_1._39063EF1442C4822.E4E1FD4F5C744008._8853594054184234() > 1f)
			{
				int num2 = ((P_1._39063EF1442C4822.E4E1FD4F5C744008._75C7C80D8F654C06 > 2f) ? 2000 : 1000);
				P_1._9D9DA155E15B401B = _9AB67761792440A7._00FC653ED33A4A96() + num2;
				if (!flag)
				{
					P_4 = true;
				}
				flag3 = true;
			}
			if (tuple3.Value.Item2 && !flag3)
			{
				P_1._9D9DA155E15B401B = _9AB67761792440A7._00FC653ED33A4A96() + 1000;
				P_4 = true;
				flag3 = true;
			}
			_330FDA4EC89F4E11.CB4E939A3F83474C("Silent Aim Bullet", obj2);
			_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(P_0.channel.owner.playerID, ECheckCategory.Raycast, ECheckType.Bullet, (!(P_3 | flag)) ? EFlagLevel.Medium : EFlagLevel.Shadow, tuple3.Value.Item1 + (flag3 ? " (mitigated)" : "") + " | target: " + P_2._3186DEB29E9F4153);
			P_3 = true;
		}
		else
		{
			_330FDA4EC89F4E11._840CF0233A3D467E(obj2);
			if (!P_3)
			{
				P_1._39063EF1442C4822.E4E1FD4F5C744008._19F5F779612A4A8C(0.1f);
			}
		}
		D33919027C6741BD d33919027C6741BD = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<D33919027C6741BD>();
		(string, bool)? tuple4 = E6D2C344F1B04FC4(P_0, P_1, P_2, d33919027C6741BD);
		if (tuple4.HasValue)
		{
			bool flag4 = false;
			if (!P_3 && P_1._39063EF1442C4822.AADE095FEED54D3E._8853594054184234() > 1f)
			{
				int num3 = ((P_1._39063EF1442C4822.AADE095FEED54D3E._75C7C80D8F654C06 > 2f) ? 2000 : 1000);
				P_1._9D9DA155E15B401B = _9AB67761792440A7._00FC653ED33A4A96() + num3;
				if (!flag)
				{
					P_4 = true;
				}
				flag4 = true;
			}
			if (tuple4.Value.Item2 && !flag4)
			{
				P_1._9D9DA155E15B401B = _9AB67761792440A7._00FC653ED33A4A96() + 1000;
				P_4 = true;
				flag4 = true;
			}
			_330FDA4EC89F4E11.CB4E939A3F83474C("Silent Aim Bullet", d33919027C6741BD);
			_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(P_0.channel.owner.playerID, ECheckCategory.Raycast, ECheckType.Bullet, (!(!flag4 | flag)) ? EFlagLevel.Minimal : EFlagLevel.Shadow, tuple4.Value.Item1 + (flag4 ? " (mitigated)" : "") + " | target: " + P_2._3186DEB29E9F4153);
			P_3 = true;
		}
		else
		{
			_330FDA4EC89F4E11._840CF0233A3D467E(d33919027C6741BD);
			if (!P_3)
			{
				P_1._39063EF1442C4822.AADE095FEED54D3E._19F5F779612A4A8C(0.1f);
			}
		}
		bool flag5 = true;
		A2D875DCF20D4D6A a2D875DCF20D4D6A = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<A2D875DCF20D4D6A>();
		_066CDB4E16674AE7 obj3 = null;
		(string, float)? tuple5 = B7762631CD1A4B60(P_0, P_1, P_2, false, false, a2D875DCF20D4D6A);
		if (!tuple5.HasValue)
		{
			flag5 = false;
			obj3 = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<_066CDB4E16674AE7>();
			tuple5 = A703BA36CD5D4B46(P_0, P_1, P_2, false, false, obj3);
		}
		if (tuple5.HasValue)
		{
			bool flag6 = false;
			if (!P_3 && P_1._39063EF1442C4822._00327F881EB04CEE._8853594054184234() > 1f)
			{
				int num4 = ((P_1._39063EF1442C4822._00327F881EB04CEE._75C7C80D8F654C06 > 2f) ? 2000 : 1000);
				P_1._9D9DA155E15B401B = _9AB67761792440A7._00FC653ED33A4A96() + num4;
				if (!flag)
				{
					P_4 = true;
				}
				flag6 = true;
			}
			if (tuple5.Value.Item2 > 3f && !flag6)
			{
				P_1._9D9DA155E15B401B = _9AB67761792440A7._00FC653ED33A4A96() + 1000;
				P_4 = true;
				flag6 = true;
			}
			if (flag5)
			{
				_330FDA4EC89F4E11.CB4E939A3F83474C("Silent Aim Bullet", a2D875DCF20D4D6A);
			}
			else
			{
				_330FDA4EC89F4E11._840CF0233A3D467E(a2D875DCF20D4D6A);
				_330FDA4EC89F4E11.CB4E939A3F83474C("Silent Aim Bullet", obj3);
			}
			_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(P_0.channel.owner.playerID, ECheckCategory.Raycast, ECheckType.Bullet, (!flag & flag6) ? EFlagLevel.Minimal : EFlagLevel.Shadow, tuple5.Value.Item1 + (flag6 ? " (mitigated)" : "") + " | target: " + P_2._3186DEB29E9F4153);
			P_3 = true;
		}
		else
		{
			_330FDA4EC89F4E11._840CF0233A3D467E(a2D875DCF20D4D6A);
			if (obj3 != null)
			{
				_330FDA4EC89F4E11._840CF0233A3D467E(obj3);
			}
			if (!P_3)
			{
				P_1._39063EF1442C4822._00327F881EB04CEE._19F5F779612A4A8C(0.1f);
			}
		}
		flag5 = true;
		A2D875DCF20D4D6A a2D875DCF20D4D6A2 = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<A2D875DCF20D4D6A>();
		_066CDB4E16674AE7 obj4 = null;
		(string, float)? tuple6 = B7762631CD1A4B60(P_0, P_1, P_2, true, false, a2D875DCF20D4D6A2);
		if (!tuple6.HasValue)
		{
			flag5 = false;
			obj4 = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<_066CDB4E16674AE7>();
			tuple6 = A703BA36CD5D4B46(P_0, P_1, P_2, true, false, obj4);
		}
		if (tuple6.HasValue & flag5)
		{
			_330FDA4EC89F4E11.CB4E939A3F83474C("Silent Aim Bullet", a2D875DCF20D4D6A2);
		}
		else
		{
			_330FDA4EC89F4E11._840CF0233A3D467E(a2D875DCF20D4D6A2);
		}
		if (obj4 != null)
		{
			if (tuple6.HasValue)
			{
				_330FDA4EC89F4E11.CB4E939A3F83474C("Silent Aim Bullet", obj4);
			}
			else
			{
				_330FDA4EC89F4E11._840CF0233A3D467E(obj4);
			}
		}
		if (!B7762631CD1A4B60(P_0, P_1, P_2, true, true, null).HasValue)
		{
			A703BA36CD5D4B46(P_0, P_1, P_2, true, true, null);
		}
		if (flag2)
		{
			C9C8B4B72078408A c9C8B4B72078408A = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<C9C8B4B72078408A>();
			c9C8B4B72078408A.D4BD47C19E4F4C07 = P_0.channel.owner.playerID.steamID.m_SteamID;
			_330FDA4EC89F4E11.CB4E939A3F83474C("Suspicious Rotation", c9C8B4B72078408A);
		}
	}

	private void _8126847C5EA64732(A3116505AAB24996 P_0, UseableGun P_1, List<_4819911A0C0846FF._3147FDB5568446E9> P_2, InputInfo P_3, ref bool P_4, ref bool P_5)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Invalid comparison between Unknown and I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Invalid comparison between Unknown and I4
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Invalid comparison between Unknown and I4
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		if (!_33A24EE4CDFF4100 || P_0.A98460F771B0446B(_760EF57D5259421C._8DC4187752784460, _760EF57D5259421C._1D28939F0C774697, ((PlayerCaller)P_1).player.channel.owner.playerID.steamID))
		{
			return;
		}
		bool flag = P_0._616493232A8943C9(A3116505AAB24996._7B165DBD1B874D50);
		bool flag2 = P_0._9D9DA155E15B401B != 0L && _9AB67761792440A7._00FC653ED33A4A96() < P_0._9D9DA155E15B401B;
		bool flag3 = (Object)(object)((PlayerCaller)P_1).player.movement.getVehicle() != (Object)null || P_0._0F638DE7CA844A28(A3116505AAB24996._7B165DBD1B874D50);
		bool flag4 = (Object)(object)P_3.player != (Object)null || (Object)(object)P_3.animal != (Object)null || (Object)(object)P_3.zombie != (Object)null;
		bool flag5 = ((int)P_3.type == 2 || (int)P_3.type == 8 || (int)P_3.type == 9) | flag4;
		bool flag6 = flag4 && _9AB67761792440A7._079E8C19685F4DD4(P_3);
		(string, EFlagLevel)? tuple = null;
		if ((Object)(object)P_3.player != (Object)null && (Object)(object)P_3.player == (Object)(object)((PlayerCaller)P_1).player)
		{
			tuple = ("type: A", EFlagLevel.Critical);
		}
		else if (_9AB67761792440A7.B8383F2716824CB2(P_3.type, P_3.limb))
		{
			tuple = ("type: B", EFlagLevel.Critical);
		}
		else if (_9AB67761792440A7._9849D016EBC24F95(flag5, P_3))
		{
			tuple = ("type: C", EFlagLevel.Critical);
		}
		else if (flag5 && Vector3.Dot(P_3.direction, P_3.normal) > 0f)
		{
			tuple = ("type: D", EFlagLevel.Critical);
		}
		else if (flag4)
		{
			if ((Object)(object)P_3.player != (Object)null)
			{
				if (!P_0._8E872EA320404135(P_3.player, P_3.point))
				{
					tuple = ("type: Z", EFlagLevel.Shadow);
				}
				else if (_392FF68B691048E8(P_1, P_3))
				{
					if (P_0._39063EF1442C4822._0749B78FC51F49D9._8853594054184234() > 2f)
					{
						tuple = ("type: R", EFlagLevel.Shadow);
					}
				}
				else
				{
					P_0._39063EF1442C4822._0749B78FC51F49D9._19F5F779612A4A8C(0.1f);
				}
				if (F0CD1E00058640DE.playerTracking.D8C5D4CF897D418B(P_0, P_3.player) && !F0CD1E00058640DE.playerTracking.F05B22B752C743A2(P_3.player)._6626673394694F24._635085B12CF4471D(P_3.limb, P_3.point))
				{
					B15E2605ED474C2A b15E2605ED474C2A = _330FDA4EC89F4E11._3ECE4ABFF9E04BFF<B15E2605ED474C2A>();
					F0CD1E00058640DE.playerTracking.F05B22B752C743A2(P_3.player)._6626673394694F24._4C62EF0AE3694F6E(b15E2605ED474C2A, ((PlayerCaller)P_1).player, P_3.player, P_3.limb, P_3.point);
					_330FDA4EC89F4E11.CB4E939A3F83474C("Missed Point V6", b15E2605ED474C2A);
				}
			}
			if (!tuple.HasValue && (flag6 & flag2))
			{
				tuple = ("type: T", EFlagLevel.Shadow);
			}
		}
		if (!tuple.HasValue)
		{
			if ((Object)(object)P_3.vehicle != (Object)null && !P_0._6C1BA5297F7F4446(P_3.vehicle, P_3.point))
			{
				tuple = ("type: Z", EFlagLevel.Shadow);
			}
			else if ((int)P_3.type == 8 || (int)P_3.type == 7)
			{
				float num = _9AB67761792440A7.AFDAF7F618374BA0(P_3.transform, P_3.point, RayMasks.DAMAGE_CLIENT);
				if (num > 0.03f)
				{
					tuple = ($"type: Z (d: {num} t: {((Object)P_3.transform).name})", EFlagLevel.Shadow);
				}
			}
			else if ((Object)(object)P_3.vehicle != (Object)null)
			{
				float num2 = _2A320E2F1A3D4AAC._2854C72CF5B5446D.DB296859268A40D5(P_3.vehicle, P_3.point);
				if (num2 <= 0.03f)
				{
					tuple = ($"type: Z (d: {num2}", EFlagLevel.Shadow);
				}
			}
		}
		if (flag4 && !flag3)
		{
			if (_99B939528A7A4B74 && P_0._39063EF1442C4822._270EE9BEFABF4D71)
			{
				if (P_4)
				{
					P_5 = true;
				}
				P_4 = false;
			}
			_8A8869C4A55A437A(P_0, P_1, P_2, P_3, flag, flag4);
		}
		_ = P_3.normal == -P_3.direction;
		if (tuple.HasValue)
		{
			_760EF57D5259421C.E7E669564ABD4ED3.E99E5CDB10C04998(((PlayerCaller)P_1).player.channel.owner.playerID, ECheckCategory.Raycast, ECheckType.Bullet, tuple.Value.Item2, tuple.Value.Item1 + " |" + (((Object)(object)((PlayerCaller)P_1).player.movement.getVehicle() != (Object)null) ? " vehicle |" : "") + " target: " + _9AB67761792440A7._9D3DAA5834DD4DA6(P_3));
			if (_99B939528A7A4B74 && tuple.Value.Item2 != EFlagLevel.Warning)
			{
				if (P_4)
				{
					P_5 = true;
				}
				P_4 = false;
			}
			if (flag2 || tuple.Value.Item2 == EFlagLevel.Critical)
			{
				P_0._9D9DA155E15B401B = _9AB67761792440A7._00FC653ED33A4A96() + 10000;
			}
		}
		else if (_99B939528A7A4B74 & flag2)
		{
			if (P_4)
			{
				P_5 = true;
			}
			P_4 = false;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool _392FF68B691048E8(UseableGun P_0, InputInfo P_1)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		InteractableVehicle val = (InteractableVehicle)B38AB7C6D18E4148(_037ACD7707E84263((object)P_1.player));
		Vector3 val2 = C3EED0F29DD54FB1(_107051786ADE4CA5(_065A482FA6934674(_967D63AFE66E49D3((object)P_0))));
		float num = Vector3.Distance(val2, P_1.point);
		if (C8543D48C1B9454B((object)_2A320E2F1A3D4AAC._2854C72CF5B5446D, (object)val, P_1.point, new Ray(val2, P_1.point - val2), num))
		{
			while (true)
			{
				int num2 = -2071931921;
				uint num3;
				switch ((num3 = (uint)((~(~(~(-num2)) * -820584489 + (0x39222731 ^ 0x4E7EAEF)) - --1507030869) * 788543951)) % 3)
				{
				case 0u:
					continue;
				case 1u:
					return C8543D48C1B9454B((object)_2A320E2F1A3D4AAC._2854C72CF5B5446D, (object)val, P_1.point, new Ray(P_1.point, -P_1.direction), num);
				}
				break;
			}
		}
		return (byte)_003CModule_003E._390073C602714496<int>(2131963235) != 0;
	}

	private void _8A8869C4A55A437A(A3116505AAB24996 P_0, UseableGun P_1, List<_4819911A0C0846FF._3147FDB5568446E9> P_2, InputInfo P_3, bool P_4, bool P_5)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		Queue<_4819911A0C0846FF._80F40B3A6052448D> queue = P_0._39063EF1442C4822._1430091BC74B40AC;
		_4819911A0C0846FF._80F40B3A6052448D item = new _4819911A0C0846FF._80F40B3A6052448D
		{
			_7EBE8DC10D2A4339 = P_2,
			_0377D473DDE24690 = P_3.direction,
			D6BBF61F7BD54CB5 = P_3.point,
			A1D4A938ECD84492 = ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).ballisticSteps,
			_4E367F2AD2F8498A = C6DD482D21774414(_4899F086FE2E41A8((object)P_1)),
			F4C9529C16D1499B = DF85FE54C33943AD(_8B2CA70930BE4FAB(_967D63AFE66E49D3((object)P_1))),
			_11F09242BCDF4087 = P_4,
			_81499F0A443E4DFC = P_5,
			_40919D6F28DC47E4 = ((Asset)_4899F086FE2E41A8((object)P_1)).name,
			_3186DEB29E9F4153 = E4A94C64F2AA433B(P_3)
		};
		int e095AB92F06747F;
		if (P_0._638733A069E74AA4._53C55A88896D458A.HasValue)
		{
			Vector3 direction = P_3.direction;
			Vector3? val = P_0._638733A069E74AA4._53C55A88896D458A;
			e095AB92F06747F = ((val.HasValue && direction == val.GetValueOrDefault()) ? 1 : 0);
		}
		else
		{
			e095AB92F06747F = 0;
		}
		item.E095AB92F06747F2 = (byte)e095AB92F06747F != 0;
		int num;
		if (P_0._638733A069E74AA4._0DBA8EE1BBAB4C34.HasValue)
		{
			Vector3 direction = P_3.point;
			Vector3? val = P_0._638733A069E74AA4._0DBA8EE1BBAB4C34;
			num = ((val.HasValue && direction == val.GetValueOrDefault()) ? 1 : 0);
		}
		else
		{
			num = 0;
		}
		item._59C152CABA934374 = (byte)num != 0;
		queue.Enqueue(item);
	}

	private (string debug, EFlagLevel level)? _08B6744903554277(Player P_0, A3116505AAB24996 P_1, _4819911A0C0846FF._80F40B3A6052448D P_2)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		if (!C9DAE847B3664123._097881B3023C4A68)
		{
			return null;
		}
		float num = float.MaxValue;
		float num2 = float.MaxValue;
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item in P_2._7EBE8DC10D2A4339)
		{
			if (!item._62DB85C9E0D5497C)
			{
				return null;
			}
			float num3 = Vector3.Distance(item._9EB9E2BEE74640DC._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item2 in item.BCEAA4E8A41640C2)
			{
				num3 = Mathf.Min(num3, Vector3.Distance(item2._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			}
			num3 = Mathf.Min(num3, Vector3.Distance(item.FE6AF73253D346E7._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			num = Mathf.Min(num, item._979A197054D84450);
			num2 = Mathf.Min(num2, num3);
		}
		(string, EFlagLevel)? result = null;
		if (num2 > 1f && num > 1.5f && P_2.E095AB92F06747F2)
		{
			result = ($"type: A (s: {num})", EFlagLevel.Medium);
		}
		else if (num2 > 10f && num > 1.5f && P_2._59C152CABA934374)
		{
			result = ($"type: B (s: {num})", EFlagLevel.Shadow);
		}
		return result;
	}

	private (string result, bool forceMitigate)? E446912C38B240E8(Player P_0, A3116505AAB24996 P_1, _4819911A0C0846FF._80F40B3A6052448D P_2, _0A6E5AE484A347AB? P_3)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		if (!Provider.modeConfigData.Gameplay.Ballistics)
		{
			return null;
		}
		float num = float.MinValue;
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item in P_2._7EBE8DC10D2A4339)
		{
			if (!item._62DB85C9E0D5497C)
			{
				return null;
			}
			float num2 = Vector3.Distance(item._9EB9E2BEE74640DC._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item2 in item.BCEAA4E8A41640C2)
			{
				num2 = Mathf.Min(num2, Vector3.Distance(item2._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			}
			num2 = Mathf.Min(num2, Vector3.Distance(item.FE6AF73253D346E7._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			if (num2 < 3f)
			{
				return null;
			}
			Vector3 val = _9AB67761792440A7.B808EF2078734847(P_2.D6BBF61F7BD54CB5);
			float num3 = Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item._9EB9E2BEE74640DC._8B47B2B22D864C7B), val);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item3 in item.BCEAA4E8A41640C2)
			{
				num3 = Mathf.Min(num3, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item3._8B47B2B22D864C7B), val));
			}
			num3 = Mathf.Min(num3, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item.FE6AF73253D346E7._8B47B2B22D864C7B), val));
			if (num3 < 3f)
			{
				return null;
			}
			float num4 = Mathf.Abs(Physics.gravity.y * item.A06E15E132D548C1 * 0.02f / P_2._4E367F2AD2F8498A);
			float num5 = P_2._4E367F2AD2F8498A * 0.02f;
			float num6 = 0f;
			float num7 = 0f;
			for (int i = 0; i < P_2.A1D4A938ECD84492; i++)
			{
				num7 += num5;
				if (!(num3 > num7))
				{
					break;
				}
				num6 += num4;
				num7 += num5;
			}
			float y = P_2._0377D473DDE24690.y;
			Vector3 val2 = P_2.D6BBF61F7BD54CB5 - item._9EB9E2BEE74640DC._8B47B2B22D864C7B;
			float y2 = val2.normalized.y;
			float num8 = y - y2;
			val2 = P_2.D6BBF61F7BD54CB5 - item.FE6AF73253D346E7._8B47B2B22D864C7B;
			float num9 = Mathf.Abs(y2 - val2.normalized.y);
			val2 = P_2.D6BBF61F7BD54CB5 - item.FE6AF73253D346E7._8B47B2B22D864C7B;
			float num10 = Mathf.Abs(y2 - val2.normalized.y);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item4 in item.BCEAA4E8A41640C2)
			{
				float num11 = num10;
				val2 = P_2.D6BBF61F7BD54CB5 - item4._8B47B2B22D864C7B;
				num10 = Mathf.Max(num11, Mathf.Abs(y2 - val2.normalized.y));
			}
			float num12 = num10 + num9;
			num12 *= 2f;
			if (item._05D08946EDA64DEC)
			{
				num12 += 0.25f;
			}
			float num13 = 0.008f;
			float num14 = num12 + num13;
			if (item._48FE83AE14EC46DA)
			{
				if (num3 < 1.5f)
				{
					return null;
				}
				num14 += 0.1f;
			}
			float num15 = Mathf.Abs(num8);
			float num16 = num15 + num14;
			if (num16 >= num6)
			{
				return null;
			}
			if (num16 > num)
			{
				num = num16;
				if (P_3 != null)
				{
					P_3.A1CFB0D2E3A044B9 = P_0.channel.owner.playerID.steamID.m_SteamID;
					P_3._89441458E251476B = "type: S" + (P_2._11F09242BCDF4087 ? " (m)" : "") + (item._48FE83AE14EC46DA ? " (lean)" : "");
					P_3._7B000F73CA904FE7 = num15;
					P_3._0EA405C03A614208 = num12;
					P_3._9501A187A2354FD7 = num16;
					P_3._2B24EB9124E74A58 = num4;
					P_3._1C1552ABDACB49A1 = num6;
					P_3._34B9385A922C4C25 = num2;
				}
			}
		}
		if (num == float.MinValue)
		{
			return null;
		}
		return ("type: S", false);
	}

	private (string result, bool forceMitigate)? AAFEA23CEBF745BF(Player P_0, A3116505AAB24996 P_1, _4819911A0C0846FF._80F40B3A6052448D P_2, _9A1C7911656E423E? P_3)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		float num = float.MaxValue;
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item in P_2._7EBE8DC10D2A4339)
		{
			if (!item._62DB85C9E0D5497C)
			{
				return null;
			}
			float num2 = Vector3.Distance(item._9EB9E2BEE74640DC._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item2 in item.BCEAA4E8A41640C2)
			{
				num2 = Mathf.Min(num2, Vector3.Distance(item2._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			}
			num2 = Mathf.Min(num2, Vector3.Distance(item.FE6AF73253D346E7._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			if (num2 < 3f)
			{
				return null;
			}
			Vector3 val = _9AB67761792440A7.B808EF2078734847(P_2.D6BBF61F7BD54CB5);
			float num3 = Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item._9EB9E2BEE74640DC._8B47B2B22D864C7B), val);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item3 in item.BCEAA4E8A41640C2)
			{
				num3 = Mathf.Min(num3, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item3._8B47B2B22D864C7B), val));
			}
			num3 = Mathf.Min(num3, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item.FE6AF73253D346E7._8B47B2B22D864C7B), val));
			Vector3 val2 = _9AB67761792440A7.B808EF2078734847(P_2._0377D473DDE24690);
			Vector3 val3 = P_2.D6BBF61F7BD54CB5 - item._9EB9E2BEE74640DC._8B47B2B22D864C7B;
			Vector3 val4 = _9AB67761792440A7.B808EF2078734847(val3.normalized);
			float num4 = _9AB67761792440A7.A026CE8FA25C4CB8(val2, val4);
			val3 = P_2.D6BBF61F7BD54CB5 - item.FE6AF73253D346E7._8B47B2B22D864C7B;
			float num5 = _9AB67761792440A7.A026CE8FA25C4CB8(val4, _9AB67761792440A7.B808EF2078734847(val3.normalized));
			float num6 = 0f;
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item4 in item.BCEAA4E8A41640C2)
			{
				float num7 = num6;
				val3 = P_2.D6BBF61F7BD54CB5 - item4._8B47B2B22D864C7B;
				num6 = Mathf.Max(num7, _9AB67761792440A7.A026CE8FA25C4CB8(val4, _9AB67761792440A7.B808EF2078734847(val3.normalized)));
			}
			float num8 = num6 + num5;
			float num9 = (P_2._81499F0A443E4DFC ? 2f : 5f);
			if (num2 < 5f)
			{
				num9 += 1.5f;
			}
			float num10 = num8 + num9;
			if (item._48FE83AE14EC46DA)
			{
				if (num3 < 0.3f)
				{
					return null;
				}
				num10 += 40f / num3;
			}
			if (num4 <= num10)
			{
				return null;
			}
			float num11 = Mathf.Max(0f, num4 - num10);
			if (num11 < num)
			{
				num = num11;
				if (P_3 != null)
				{
					P_3.E49EF67FB96C4298 = P_0.channel.owner.playerID.steamID.m_SteamID;
					P_3._25AC3279EE3E4D9A = "type: E" + (P_2._11F09242BCDF4087 ? " (m)" : "") + (item._48FE83AE14EC46DA ? " (lean)" : "");
					P_3._45798817B72D4341 = num4;
					P_3._2B10D6F89FAF428A = num8;
					P_3._4B3FD3D34E584AEA = num11;
					P_3.FB0545F8D8F2458F = num2;
				}
			}
		}
		if (num == float.MaxValue)
		{
			return null;
		}
		return ("type: E", num > 3f);
	}

	private (string result, bool forceMitigate)? E6D2C344F1B04FC4(Player P_0, A3116505AAB24996 P_1, _4819911A0C0846FF._80F40B3A6052448D P_2, D33919027C6741BD? P_3)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		float num = float.MaxValue;
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item in P_2._7EBE8DC10D2A4339)
		{
			if (!item._62DB85C9E0D5497C)
			{
				return null;
			}
			float num2 = Vector3.Distance(item._9EB9E2BEE74640DC._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item2 in item.BCEAA4E8A41640C2)
			{
				num2 = Mathf.Min(num2, Vector3.Distance(item2._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			}
			num2 = Mathf.Min(num2, Vector3.Distance(item.FE6AF73253D346E7._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			if (num2 < 3f)
			{
				return null;
			}
			Vector3 val = _9AB67761792440A7.B808EF2078734847(P_2.D6BBF61F7BD54CB5);
			float num3 = Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item._9EB9E2BEE74640DC._8B47B2B22D864C7B), val);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item3 in item.BCEAA4E8A41640C2)
			{
				num3 = Mathf.Min(num3, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item3._8B47B2B22D864C7B), val));
			}
			num3 = Mathf.Min(num3, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item.FE6AF73253D346E7._8B47B2B22D864C7B), val));
			float num4 = Mathf.Abs(Physics.gravity.y * item.A06E15E132D548C1 * 0.02f / P_2._4E367F2AD2F8498A);
			float num5 = (Provider.modeConfigData.Gameplay.Ballistics ? (num4 * (float)P_2.A1D4A938ECD84492) : 0f);
			float y = P_2._0377D473DDE24690.y;
			Vector3 val2 = P_2.D6BBF61F7BD54CB5 - item._9EB9E2BEE74640DC._8B47B2B22D864C7B;
			float y2 = val2.normalized.y;
			float num6 = y - y2;
			val2 = P_2.D6BBF61F7BD54CB5 - item.FE6AF73253D346E7._8B47B2B22D864C7B;
			float num7 = Mathf.Abs(y2 - val2.normalized.y);
			val2 = P_2.D6BBF61F7BD54CB5 - item.FE6AF73253D346E7._8B47B2B22D864C7B;
			float num8 = Mathf.Abs(y2 - val2.normalized.y);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item4 in item.BCEAA4E8A41640C2)
			{
				float num9 = num8;
				val2 = P_2.D6BBF61F7BD54CB5 - item4._8B47B2B22D864C7B;
				num8 = Mathf.Max(num9, Mathf.Abs(y2 - val2.normalized.y));
			}
			float num10 = num8 + num7;
			num10 *= 2f;
			if (item._05D08946EDA64DEC)
			{
				num10 += 0.25f;
			}
			float num11 = (P_2._81499F0A443E4DFC ? 0.01f : 0.03f);
			float num12 = num10 + num11 + num5;
			if (item._48FE83AE14EC46DA)
			{
				if (num3 < 1.5f)
				{
					return null;
				}
				num12 += 0.1f;
			}
			if (Mathf.Abs(num6) <= num12)
			{
				return null;
			}
			float num13 = _4077D94F71EB4408(num6, num12);
			float num14 = Mathf.Abs(num13);
			if (num14 < num)
			{
				num = num14;
				if (P_3 != null)
				{
					P_3.D8DB4917CC4442DF = P_0.channel.owner.playerID.steamID.m_SteamID;
					P_3._5AFCDB50AC90440C = "type: V" + (P_2._11F09242BCDF4087 ? " (m)" : "") + (item._48FE83AE14EC46DA ? " (lean)" : "");
					P_3._0F62A0CE37D44C7F = num6;
					P_3._49628262B54F4769 = num10;
					P_3.BD0E0988B84D4664 = num13;
					P_3.D9DCE80B2EB049AF = num5;
					P_3._9AB28F7B123E4ACD = num2;
				}
			}
		}
		if (num == float.MaxValue)
		{
			return null;
		}
		return ("type: V", num > 0.1f);
	}

	private (string result, float angle)? B7762631CD1A4B60(Player P_0, A3116505AAB24996 P_1, _4819911A0C0846FF._80F40B3A6052448D P_2, bool P_3, bool P_4, A2D875DCF20D4D6A? P_5)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Unknown result type (might be due to invalid IL or missing references)
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		float num = float.MaxValue;
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item3 in P_2._7EBE8DC10D2A4339)
		{
			if (!item3._62DB85C9E0D5497C)
			{
				return null;
			}
			if (P_4 && !item3._47914AA1386B4B09)
			{
				continue;
			}
			float num2 = Vector3.Distance(item3._9EB9E2BEE74640DC._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item4 in item3.BCEAA4E8A41640C2)
			{
				num2 = Mathf.Min(num2, Vector3.Distance(item4._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			}
			num2 = Mathf.Min(num2, Vector3.Distance(item3.FE6AF73253D346E7._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			if (num2 < 5f)
			{
				return null;
			}
			Vector3 val = _9AB67761792440A7.B808EF2078734847(P_2.D6BBF61F7BD54CB5);
			float num3 = Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item3._9EB9E2BEE74640DC._8B47B2B22D864C7B), val);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item5 in item3.BCEAA4E8A41640C2)
			{
				num3 = Mathf.Min(num3, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item5._8B47B2B22D864C7B), val));
			}
			num3 = Mathf.Min(num3, Vector3.Distance(_9AB67761792440A7.B808EF2078734847(item3.FE6AF73253D346E7._8B47B2B22D864C7B), val));
			if (num3 < 2.5f)
			{
				return null;
			}
			Vector3 val2 = _9AB67761792440A7.B808EF2078734847(item3._526C77F5AD8543F9 * Vector3.forward);
			float b816394284A14C8D = item3.B816394284A14C8D;
			float num4 = item3._5E8B57884ED846F7;
			float num5 = (P_3 ? 0f : (Mathf.Max(item3._7828A186B79F4E4F, item3._005A4DCA76144918) * 2f));
			float num6 = 0f;
			if (item3._48FE83AE14EC46DA)
			{
				ReadOnlySpan<(Quaternion, Quaternion)> readOnlySpan = stackalloc(Quaternion, Quaternion)[3]
				{
					(item3._63B79AD0C1094E94, item3.EB3D8ED29BD04389),
					(item3._04A7C19047954A74, item3._7721B403999045BE),
					(item3._1B0ED80F923E4586, item3._803CF3EE969F42B9)
				};
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					(Quaternion, Quaternion) tuple = readOnlySpan[i];
					Quaternion item = tuple.Item1;
					Quaternion item2 = tuple.Item2;
					float num7 = _9AB67761792440A7.A026CE8FA25C4CB8(_9AB67761792440A7.B808EF2078734847(item * Quaternion.Euler(0f, 0f, HumanAnimator.LEAN) * item2 * Vector3.forward), _9AB67761792440A7.B808EF2078734847(item * item2 * Vector3.forward));
					float num8 = _9AB67761792440A7.A026CE8FA25C4CB8(_9AB67761792440A7.B808EF2078734847(item * Quaternion.Euler(0f, 0f, 0f - HumanAnimator.LEAN) * item2 * Vector3.forward), _9AB67761792440A7.B808EF2078734847(item * item2 * Vector3.forward));
					num6 = Mathf.Max(num6, Mathf.Max(num7, num8));
				}
			}
			float num9 = num5 + b816394284A14C8D + num4;
			float num10 = 0f;
			if (_9AB67761792440A7._7B6477147E0F42D8)
			{
				float num11 = 0f;
				if ((Object)(object)P_0.movement.controller != (Object)null)
				{
					num11 = Mathf.Clamp(P_0.look.heightLook, 0.39499998f, P_0.movement.controller.height - 0.39f - 0.005f);
				}
				float num12 = (Provider.modeConfigData.Gameplay.Allow_Shoulder_Camera ? 512f : Mathf.Floor(Mathf.Min(num2, 20f)));
				float num13 = 0f;
				ReadOnlySpan<Quaternion> readOnlySpan2 = stackalloc Quaternion[3] { item3._526C77F5AD8543F9, item3._5323059ADC574BFF, item3._24D6906F99D54084 };
				for (int i = 0; i < readOnlySpan2.Length; i++)
				{
					Quaternion val3 = readOnlySpan2[i];
					float[] fD4D20FF11034FCD = FD4D20FF11034FCD;
					foreach (float num14 in fD4D20FF11034FCD)
					{
						Quaternion val4 = (Provider.modeConfigData.Gameplay.Allow_Shoulder_Camera ? (val3 * Quaternion.Euler(0f, num14 * -5f, 0f)) : val3);
						float num15 = _9AB67761792440A7.A026CE8FA25C4CB8(_9AB67761792440A7.B808EF2078734847(_098974F79D0441B0(((Component)P_0).transform.position, val4, num11, num14) + val4 * Vector3.forward * num12 - P_0.look.aim.position), _9AB67761792440A7.B808EF2078734847(val3 * Vector3.forward));
						num13 = Mathf.Max(num13, num15);
					}
				}
				num10 = item3.B20DDC09C08540F1 + num13 + 1f;
			}
			float num16 = _9AB67761792440A7.A026CE8FA25C4CB8(val2, _9AB67761792440A7.B808EF2078734847(P_2._0377D473DDE24690));
			num16 = Mathf.Min(num16, _9AB67761792440A7.A026CE8FA25C4CB8(_9AB67761792440A7.B808EF2078734847(item3._5323059ADC574BFF * Vector3.forward), _9AB67761792440A7.B808EF2078734847(P_2._0377D473DDE24690)));
			num16 = Mathf.Min(num16, _9AB67761792440A7.A026CE8FA25C4CB8(_9AB67761792440A7.B808EF2078734847(item3._24D6906F99D54084 * Vector3.forward), _9AB67761792440A7.B808EF2078734847(P_2._0377D473DDE24690)));
			float num17 = (P_2._81499F0A443E4DFC ? 1.5f : 6.5f);
			float num18 = num9 + Mathf.Max(num6, num10) + num17;
			if (num16 <= num18)
			{
				return null;
			}
			float num19 = Mathf.Max(0f, num16 - num18);
			if (num19 < num)
			{
				num = num19;
				if (P_5 != null)
				{
					P_5._41DA198007F24F3E = P_0.channel.owner.playerID.steamID.m_SteamID;
					P_5.B6BFE90375214843 = "type: " + (P_3 ? "O" : "L") + (P_2._11F09242BCDF4087 ? " (m)" : "") + (item3._48FE83AE14EC46DA ? " (lean)" : "");
					P_5._716FF1866AE84C7F = num16;
					P_5._2BED7E13AD2D4E79 = num5;
					P_5.EAF74D5A1D7241B4 = b816394284A14C8D;
					P_5._45A3DA1A3C6A4575 = num4;
					P_5._3DC01D40F95B4222 = num10;
					P_5.F569E77FB9564742 = $"{item3._30249645703B47E7} ({item3.B20DDC09C08540F1})";
					P_5.A2012418C7A74446 = item3._48BEC7816DA943BC;
					P_5._24CC4FC3DA7D49D7 = num19;
					P_5._4B106ECF35AA42A6 = num2;
					P_5._7A513F46A259411F = num3;
				}
			}
		}
		if (num == float.MaxValue)
		{
			return null;
		}
		return ("type: L", num);
	}

	private (string result, float angle)? A703BA36CD5D4B46(Player P_0, A3116505AAB24996 P_1, _4819911A0C0846FF._80F40B3A6052448D P_2, bool P_3, bool P_4, _066CDB4E16674AE7? P_5)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		float num = float.MaxValue;
		foreach (_4819911A0C0846FF._3147FDB5568446E9 item5 in P_2._7EBE8DC10D2A4339)
		{
			if (!item5._62DB85C9E0D5497C)
			{
				return null;
			}
			if (P_4 && !item5._47914AA1386B4B09)
			{
				continue;
			}
			float num2 = Vector3.Distance(item5._9EB9E2BEE74640DC._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5);
			foreach (B3E800F7DAAE405D._8B7C6A7C18684FA8 item6 in item5.BCEAA4E8A41640C2)
			{
				num2 = Mathf.Min(num2, Vector3.Distance(item6._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			}
			num2 = Mathf.Min(num2, Vector3.Distance(item5.FE6AF73253D346E7._8B47B2B22D864C7B, P_2.D6BBF61F7BD54CB5));
			if (num2 < 5f)
			{
				return null;
			}
			Vector3 val = _66E7CB8070EB4BDD(_778981E1F591424B((object)item5) * Vector3.forward);
			float b816394284A14C8D = item5.B816394284A14C8D;
			float num3 = item5._5E8B57884ED846F7;
			float num4 = (P_3 ? 0f : (Mathf.Max(item5._8BCCCC895AFF484D, item5._0CDF4F72C2204DA3) * 2f));
			float num5 = 0f;
			if (item5._48FE83AE14EC46DA)
			{
				ReadOnlySpan<(Quaternion, Quaternion)> readOnlySpan = stackalloc(Quaternion, Quaternion)[3]
				{
					(item5._63B79AD0C1094E94, item5.EB3D8ED29BD04389),
					(item5._04A7C19047954A74, item5._7721B403999045BE),
					(item5._1B0ED80F923E4586, item5._803CF3EE969F42B9)
				};
				for (int i = 0; i < readOnlySpan.Length; i++)
				{
					(Quaternion, Quaternion) tuple = readOnlySpan[i];
					Quaternion item = tuple.Item1;
					Quaternion item2 = tuple.Item2;
					float num6 = Vector3.Angle(_66E7CB8070EB4BDD(item * Quaternion.Euler(0f, 0f, HumanAnimator.LEAN) * item2 * Vector3.forward), _66E7CB8070EB4BDD(item * item2 * Vector3.forward));
					float num7 = Vector3.Angle(_66E7CB8070EB4BDD(item * Quaternion.Euler(0f, 0f, 0f - HumanAnimator.LEAN) * item2 * Vector3.forward), _66E7CB8070EB4BDD(item * item2 * Vector3.forward));
					num5 = Mathf.Max(num5, Mathf.Max(num6, num7));
				}
			}
			float num8 = num4 + b816394284A14C8D + num3;
			float num9 = 0f;
			if (D5122D5A17744805())
			{
				float num10 = (((ModeConfigData)_22094E82141C4562()).Gameplay.Allow_Shoulder_Camera ? 512f : Mathf.Floor(Mathf.Min(num2, 20f)));
				float num11 = 0f;
				EPlayerStance[] array = B3E800F7DAAE405D._45BD767F01AF43B2;
				foreach (EPlayerStance val2 in array)
				{
					float num12 = 0f;
					if (_51B35FC555C04CC8((Object)A7C067ED846844ED(_037ACD7707E84263((object)P_0)), (Object)null))
					{
						num12 = Mathf.Clamp(_59AC87D8CB494C0B(val2), 0.39499998f, _15A68DB680C442B0(val2) - 0.39f - 0.005f);
					}
					ReadOnlySpan<(Quaternion, Quaternion)> readOnlySpan2 = stackalloc(Quaternion, Quaternion)[3]
					{
						(_778981E1F591424B((object)item5), item5._63B79AD0C1094E94),
						(D8AD276DC182411E((object)item5), item5._04A7C19047954A74),
						(_92F791B952E144BC((object)item5), item5._1B0ED80F923E4586)
					};
					for (int j = 0; j < readOnlySpan2.Length; j++)
					{
						(Quaternion, Quaternion) tuple2 = readOnlySpan2[j];
						Quaternion item3 = tuple2.Item1;
						Quaternion item4 = tuple2.Item2;
						float[] fD4D20FF11034FCD = FD4D20FF11034FCD;
						foreach (float num13 in fD4D20FF11034FCD)
						{
							bool[] array2 = _93E7D5D36D3A438E;
							foreach (bool flag in array2)
							{
								if (!flag || item5._48FE83AE14EC46DA)
								{
									Vector3 val3 = C3EED0F29DD54FB1(D4F009DD72A04D15((object)P_0)) + Vector3.up * _59AC87D8CB494C0B(val2);
									if (flag)
									{
										val3 = DE39B4AEB7C44DC9(C3EED0F29DD54FB1(D4F009DD72A04D15((object)P_0)), val3, item4, num13);
									}
									Quaternion val4 = (((ModeConfigData)_22094E82141C4562()).Gameplay.Allow_Shoulder_Camera ? (item3 * Quaternion.Euler(0f, num13 * -5f, 0f)) : item3);
									Vector3 val5 = _098974F79D0441B0(val3, val4, num12, num13) + val4 * Vector3.forward * num10 - val3;
									float num14 = Vector3.Angle(_66E7CB8070EB4BDD(val5.normalized), _66E7CB8070EB4BDD(item3 * Vector3.forward));
									num11 = Mathf.Max(num11, num14);
								}
							}
						}
					}
				}
				num9 = item5.ECEA119252CD4167 + num11 + 1f;
			}
			float num15 = Vector3.Angle(val, _66E7CB8070EB4BDD(P_2._0377D473DDE24690));
			num15 = Mathf.Min(num15, Vector3.Angle(_66E7CB8070EB4BDD(D8AD276DC182411E((object)item5) * Vector3.forward), _66E7CB8070EB4BDD(P_2._0377D473DDE24690)));
			num15 = Mathf.Min(num15, Vector3.Angle(_66E7CB8070EB4BDD(_92F791B952E144BC((object)item5) * Vector3.forward), _66E7CB8070EB4BDD(P_2._0377D473DDE24690)));
			float num16 = Mathf.Abs(_83EAA57868E84B50().y * item5.A06E15E132D548C1 * 0.02f / P_2._4E367F2AD2F8498A);
			float num17 = (((ModeConfigData)_22094E82141C4562()).Gameplay.Ballistics ? Vector3.Angle(_66E7CB8070EB4BDD(Vector3.up), _66E7CB8070EB4BDD(Vector3.up - new Vector3(0f, Mathf.Clamp(num16 * (float)P_2.A1D4A938ECD84492, -1f, 1f), 0f))) : 0f);
			num17 *= 2f;
			float num18 = (P_2._81499F0A443E4DFC ? 2.5f : 6.5f);
			float num19 = num8 + Mathf.Max(num5, num9) + num17 + num18;
			if (num15 <= num19)
			{
				return null;
			}
			float num20 = Mathf.Max(0f, num15 - num19);
			if (num20 < num)
			{
				num = num20;
				if (P_5 != null)
				{
					_23C8D2D0ADB84F85((object)P_5, D50AFC80FB744BC7(_640A807FDEC646EC((object)((SteamChannel)_04B88BC1F12B4358((object)P_0)).owner)).m_SteamID);
					_35ABA3C54B524135((object)P_5, _39DA0A13F808445B("type: ", P_3 ? "Y" : "N", P_2._11F09242BCDF4087 ? " (m)" : "", item5._48FE83AE14EC46DA ? " (lean)" : ""));
					C2A74DB592AC445A((object)P_5, num15);
					BBDC11BC498E4413((object)P_5, num4);
					_004352088C254E11((object)P_5, b816394284A14C8D);
					_6AC74B8CED634F2D((object)P_5, num3);
					_1AB1CA73A2C5434D((object)P_5, num9);
					AC39440AFD2E4FA0((object)P_5, E34BE26597C148EC("{0} ({1})", (object)item5._30249645703B47E7, (object)item5.ECEA119252CD4167));
					D63074A720084185((object)P_5, (float)item5._48BEC7816DA943BC);
					_3F7E9AE4879841A5((object)P_5, num20);
					_3A9393D695184453((object)P_5, num2);
				}
			}
		}
		if (num == float.MaxValue)
		{
			return null;
		}
		return ("type: N", num);
	}

	private Vector3 _098974F79D0441B0(Vector3 P_0, Quaternion P_1, float P_2, float P_3)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		Vector3 val = P_1 * Vector3.forward;
		Vector3 val2 = P_1 * Vector3.up;
		Vector3 val3 = P_1 * Vector3.right;
		Vector3 val4 = ((!Provider.modeConfigData.Gameplay.Allow_Shoulder_Camera) ? (val * -1.5f + val2 * 0.5f + val3 * P_3 * 0.5f) : (val * -1.5f + val2 * 0.25f + val3 * P_3 * 1f));
		val4.Normalize();
		return P_0 + new Vector3(0f, P_2, 0f) + val4 * 2f;
	}

	private Vector3 DE39B4AEB7C44DC9(Vector3 P_0, Vector3 P_1, Quaternion P_2, float P_3)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		Quaternion val = Quaternion.Euler(0f, 0f, P_3 * HumanAnimator.LEAN);
		Vector3 val2 = P_1 - P_0;
		Vector3 val3 = P_2 * (val * val2);
		return P_0 + val3;
	}

	private float _4077D94F71EB4408(float P_0, float P_1)
	{
		float num = Mathf.Abs(P_0);
		if (num <= P_1)
		{
			return 0f;
		}
		return Mathf.Sign(P_0) * (num - P_1);
	}

	private float _00474FF99D904A2F(A3116505AAB24996 P_0, UseableGun P_1, float P_2, float P_3, bool P_4)
	{
		Attachments val = _64A4BBC5E4CE4EE1._74705AAE3534468A.Invoke(P_1);
		bool flag = _64A4BBC5E4CE4EE1.E8CFFE96D48E4806(P_1);
		float num = C08A1EE5847F49B9(_4899F086FE2E41A8((object)P_1));
		if (P_4)
		{
			num *= Mathf.Max(1f, (P_3 < 0.5f) ? (1f + (1f - P_3 * 2f)) : 1f);
		}
		num *= Mathf.Lerp(1f, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadAim, P_2);
		num *= _8603AE79D3FA499C(_0F8075720C8B4ACD(_967D63AFE66E49D3((object)P_1)));
		if (_65093FCF8A174143((object)val) != null)
		{
			float num2 = Mathf.Lerp(1f, _00C2C08655474062(_65093FCF8A174143((object)val)), P_2);
			num = ((!_97FC263521DA4768(_65093FCF8A174143((object)val))) ? (num * num2) : (num * (P_4 ? Mathf.Max(1f, num2) : Mathf.Min(1f, num2))));
		}
		if ((CC10E7FB3FAB4F65((object)val) != null) & flag)
		{
			num = ((!_97FC263521DA4768(CC10E7FB3FAB4F65((object)val))) ? (num * _00C2C08655474062(CC10E7FB3FAB4F65((object)val))) : (num * (P_4 ? Mathf.Max(1f, _00C2C08655474062(CC10E7FB3FAB4F65((object)val))) : Mathf.Min(1f, _00C2C08655474062(CC10E7FB3FAB4F65((object)val))))));
		}
		if (_3AAC97ABB4334995((object)val) != null)
		{
			num = ((!_97FC263521DA4768(_3AAC97ABB4334995((object)val))) ? (num * _00C2C08655474062(_3AAC97ABB4334995((object)val))) : (num * (P_4 ? Mathf.Max(1f, _00C2C08655474062(_3AAC97ABB4334995((object)val))) : Mathf.Min(1f, _00C2C08655474062(_3AAC97ABB4334995((object)val))))));
		}
		if (_45FD8CA9F99F4B32((object)val) != null)
		{
			num = ((!_97FC263521DA4768(_45FD8CA9F99F4B32((object)val))) ? (num * _00C2C08655474062(_45FD8CA9F99F4B32((object)val))) : (num * (P_4 ? Mathf.Max(1f, _00C2C08655474062(_45FD8CA9F99F4B32((object)val))) : Mathf.Min(1f, _00C2C08655474062(_45FD8CA9F99F4B32((object)val))))));
		}
		if (_411E2CED4CF04B70((object)val) != null)
		{
			num = ((!_97FC263521DA4768(_411E2CED4CF04B70((object)val))) ? (num * _00C2C08655474062(_411E2CED4CF04B70((object)val))) : (num * (P_4 ? Mathf.Max(1f, _00C2C08655474062(_411E2CED4CF04B70((object)val))) : Mathf.Min(1f, _00C2C08655474062(_411E2CED4CF04B70((object)val))))));
		}
		float num3 = 1f;
		num3 = (P_4 ? Mathf.Max(num3, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadSprint) : Mathf.Min(num3, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadSprint));
		num3 = (P_4 ? Mathf.Max(num3, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadCrouch) : Mathf.Min(num3, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadCrouch));
		num3 = (P_4 ? Mathf.Max(num3, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadProne) : Mathf.Min(num3, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadProne));
		num3 = (P_4 ? Mathf.Max(num3, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadSwimming) : Mathf.Min(num3, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadSwimming));
		num *= num3;
		if (D5122D5A17744805())
		{
			num *= (P_4 ? Mathf.Max(1f, ((ModeConfigData)_22094E82141C4562()).Gameplay.ThirdPerson_SpreadMultiplier) : Mathf.Min(1f, ((ModeConfigData)_22094E82141C4562()).Gameplay.ThirdPerson_SpreadMultiplier));
		}
		if (!_87D4C2C5291A4884(_037ACD7707E84263(_967D63AFE66E49D3((object)P_1))) || P_0._55A04A73D4B1454E)
		{
			num *= (P_4 ? Mathf.Max(1f, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadMidair) : Mathf.Min(1f, ((ItemGunAsset)_4899F086FE2E41A8((object)P_1)).spreadMidair));
		}
		return Mathf.Min(num, 1.5697963f);
	}

	private float _12C6BA1F5C5F4F11(A3116505AAB24996 P_0, UseableGun P_1, bool P_2)
	{
		Attachments val = _64A4BBC5E4CE4EE1._74705AAE3534468A.Invoke(P_1);
		Attachments val2 = _64A4BBC5E4CE4EE1._74705AAE3534468A.Invoke(P_1);
		bool flag = _64A4BBC5E4CE4EE1.E8CFFE96D48E4806(P_1);
		if (!_12C0036407DD4EB0((object)P_1) || _65093FCF8A174143((object)val) == null)
		{
			return 0f;
		}
		float num = (1f - 1f / E817E9AFF36B4DFA(_65093FCF8A174143((object)val))) * 1.25f;
		num *= 1f - _3AE81588B6A84F3F(_0F8075720C8B4ACD(_967D63AFE66E49D3((object)P_1)), 0, 5) * 0.5f;
		num *= _28695ED587AD4930(_65093FCF8A174143((object)val));
		if ((_51B35FC555C04CC8((Object)(object)val2, (Object)null) && CC10E7FB3FAB4F65((object)val2) != null) & flag)
		{
			num = ((!_97FC263521DA4768(CC10E7FB3FAB4F65((object)val2))) ? (num * _28695ED587AD4930(CC10E7FB3FAB4F65((object)val2))) : (num * (P_2 ? Mathf.Max(1f, _28695ED587AD4930(CC10E7FB3FAB4F65((object)val2))) : Mathf.Min(1f, _28695ED587AD4930(CC10E7FB3FAB4F65((object)val2))))));
		}
		if (_51B35FC555C04CC8((Object)(object)val2, (Object)null) && _3AAC97ABB4334995((object)val2) != null)
		{
			num = ((!_97FC263521DA4768(_3AAC97ABB4334995((object)val2))) ? (num * _28695ED587AD4930(_3AAC97ABB4334995((object)val2))) : (num * (P_2 ? Mathf.Max(1f, _28695ED587AD4930(_3AAC97ABB4334995((object)val2))) : Mathf.Min(1f, _28695ED587AD4930(_3AAC97ABB4334995((object)val2))))));
		}
		if (_51B35FC555C04CC8((Object)(object)val2, (Object)null) && _45FD8CA9F99F4B32((object)val2) != null)
		{
			num = ((!_97FC263521DA4768(_45FD8CA9F99F4B32((object)val2))) ? (num * _28695ED587AD4930(_45FD8CA9F99F4B32((object)val2))) : (num * (P_2 ? Mathf.Max(1f, _28695ED587AD4930(_45FD8CA9F99F4B32((object)val2))) : Mathf.Min(1f, _28695ED587AD4930(_45FD8CA9F99F4B32((object)val2))))));
		}
		if (_51B35FC555C04CC8((Object)(object)val2, (Object)null) && _411E2CED4CF04B70((object)val2) != null)
		{
			num = ((!_97FC263521DA4768(_411E2CED4CF04B70((object)val2))) ? (num * _28695ED587AD4930(_411E2CED4CF04B70((object)val2))) : (num * (P_2 ? Mathf.Max(1f, _28695ED587AD4930(_411E2CED4CF04B70((object)val2))) : Mathf.Min(1f, _28695ED587AD4930(_411E2CED4CF04B70((object)val2))))));
		}
		if (!P_2)
		{
			num *= 0.7f;
		}
		return num;
	}

	public float B99D01D832D74647(A3116505AAB24996 P_0, UseableGun P_1, bool P_2)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		if (!((ModeConfigData)_22094E82141C4562()).Gameplay.Enable_Damage_Flinch)
		{
			return 0f;
		}
		float num = 0f;
		using Queue<_88BB72CD49B54743._7AD92A1151594320>.Enumerator enumerator = P_0._35F1EA6BE31E4755._3F81FECA615E459B.A2A766451ED44A51();
		while (enumerator.MoveNext())
		{
			_88BB72CD49B54743._7AD92A1151594320 current = enumerator.Current;
			float num2 = (float)Mathf.Min((int)current._5CDE673BDC354F82, 25) * 0.5f;
			float num3 = 1f - _3AE81588B6A84F3F(_0F8075720C8B4ACD(_967D63AFE66E49D3((object)P_1)), 1, 3) * 0.75f;
			num2 *= num3;
			Vector3 val = Vector3.Cross(Vector3.up, current.B893D67CB7004977);
			Vector3 normalized = val.normalized;
			Vector3 val2 = Quaternion.Inverse(P_0.DE38BE1DA5014794) * normalized;
			float num4 = (P_2 ? _25A9107C96964770(Vector3.forward, Quaternion.AngleAxis(num2, val2) * Vector3.forward) : Vector3.Angle(_66E7CB8070EB4BDD(Vector3.forward), _66E7CB8070EB4BDD(Quaternion.AngleAxis(num2, val2) * Vector3.forward)));
			if (_82B5FE84C9634EA6() - current._226B7B943D07494C > 500)
			{
				num4 *= 0.5f;
			}
			num += num4;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _3301ED6AA1A1474A()
	{
		uint num = 4u;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1u:
				num = 5u;
				break;
			case 4u:
				num = 1u;
				break;
			case 5u:
				return;
			case 2u:
			case 3u:
				return;
			}
		}
	}

	static object EF3E97E51C654670(Delegate P_0, Delegate P_1)
	{
		return Delegate.Combine(P_0, P_1);
	}

	static void B1EC180BD62C468D(BulletSpawnedHandler P_0)
	{
		UseableGun.onBulletSpawned += P_0;
	}

	void _15AE93DFC562412F()
	{
		base.A599C828530B4E69();
	}

	static object _290B5909C49646BA(Delegate P_0, Delegate P_1)
	{
		return Delegate.Remove(P_0, P_1);
	}

	static void _72C3EAEF92B04D9F(BulletSpawnedHandler P_0)
	{
		UseableGun.onBulletSpawned -= P_0;
	}

	void _27C5535316184D7A()
	{
		base.C4CA2ECFAD654E77();
	}

	static object _967D63AFE66E49D3(object P_0)
	{
		return ((PlayerCaller)P_0).player;
	}

	static bool D0AC8C9EC45A4010(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static object F35EA5130E5C4B9F(Player P_0)
	{
		return A3116505AAB24996._69C6AFA769194D6F(P_0);
	}

	static object _461134DB7B2F479E()
	{
		return new _4819911A0C0846FF._3147FDB5568446E9();
	}

	static B3E800F7DAAE405D._8B7C6A7C18684FA8 C835504939554F4A(object P_0, object P_1)
	{
		return ((B3E800F7DAAE405D)P_0)._519D3BF95CBF4676((Player)P_1);
	}

	static B3E800F7DAAE405D._8B7C6A7C18684FA8 _2365255CDB0F4772(object P_0, object P_1)
	{
		return ((B3E800F7DAAE405D)P_0)._7ED3CB3A6B244A09((Player)P_1);
	}

	static float _1173B9E4F20B4119(object P_0, object P_1, object P_2, bool P_3)
	{
		return ((_3301ED6AA1A1474A)P_0).B99D01D832D74647((A3116505AAB24996)P_1, (UseableGun)P_2, P_3);
	}

	static object _037ACD7707E84263(object P_0)
	{
		return ((Player)P_0).movement;
	}

	static object B38AB7C6D18E4148(object P_0)
	{
		return ((PlayerMovement)P_0).getVehicle();
	}

	static object _065A482FA6934674(object P_0)
	{
		return ((Player)P_0).look;
	}

	static object _107051786ADE4CA5(object P_0)
	{
		return ((PlayerLook)P_0).aim;
	}

	static Vector3 C3EED0F29DD54FB1(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Transform)P_0).position;
	}

	static bool C8543D48C1B9454B(object P_0, object P_1, Vector3 P_2, Ray P_3, float P_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return ((_0732D1C8FF584BB5)P_0).FE59E1EE1CEA40B2((InteractableVehicle)P_1, P_2, P_3, P_4);
	}

	static object _4899F086FE2E41A8(object P_0)
	{
		return ((UseableGun)P_0).equippedGunAsset;
	}

	static float C6DD482D21774414(object P_0)
	{
		return ((ItemGunAsset)P_0).muzzleVelocity;
	}

	static object _8B2CA70930BE4FAB(object P_0)
	{
		return ((Player)P_0).input;
	}

	static int DF85FE54C33943AD(object P_0)
	{
		return ((PlayerInput)P_0).getInputCount();
	}

	static string E4A94C64F2AA433B(InputInfo P_0)
	{
		return _9AB67761792440A7._9D3DAA5834DD4DA6(P_0);
	}

	static Quaternion _778981E1F591424B(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((_4819911A0C0846FF._3147FDB5568446E9)P_0)._526C77F5AD8543F9;
	}

	static Vector3 _66E7CB8070EB4BDD(Vector3 P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _9AB67761792440A7._3EB351770C3F4FD8(P_0);
	}

	static bool D5122D5A17744805()
	{
		return _9AB67761792440A7._7B6477147E0F42D8;
	}

	static object _22094E82141C4562()
	{
		return Provider.modeConfigData;
	}

	static object A7C067ED846844ED(object P_0)
	{
		return ((PlayerMovement)P_0).controller;
	}

	static bool _51B35FC555C04CC8(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static float _59AC87D8CB494C0B(EPlayerStance P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return B3E800F7DAAE405D.CA4505681FD0490E(P_0);
	}

	static float _15A68DB680C442B0(EPlayerStance P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return B3E800F7DAAE405D._68CBC890B9CC41BD(P_0);
	}

	static Quaternion D8AD276DC182411E(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((_4819911A0C0846FF._3147FDB5568446E9)P_0)._5323059ADC574BFF;
	}

	static Quaternion _92F791B952E144BC(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((_4819911A0C0846FF._3147FDB5568446E9)P_0)._24D6906F99D54084;
	}

	static object D4F009DD72A04D15(object P_0)
	{
		return ((Component)P_0).transform;
	}

	static Vector3 _83EAA57868E84B50()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return Physics.gravity;
	}

	static object _04B88BC1F12B4358(object P_0)
	{
		return ((Player)P_0).channel;
	}

	static object _640A807FDEC646EC(object P_0)
	{
		return ((SteamPlayer)P_0).playerID;
	}

	static CSteamID D50AFC80FB744BC7(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((SteamPlayerID)P_0).steamID;
	}

	static void _23C8D2D0ADB84F85(object P_0, ulong P_1)
	{
		((_066CDB4E16674AE7)P_0)._277E6753D336485D = P_1;
	}

	static string _39DA0A13F808445B(string P_0, string P_1, string P_2, string P_3)
	{
		return P_0 + P_1 + P_2 + P_3;
	}

	static void _35ABA3C54B524135(object P_0, string P_1)
	{
		((_066CDB4E16674AE7)P_0).D1607A7D1D2C4D34 = P_1;
	}

	static void C2A74DB592AC445A(object P_0, float P_1)
	{
		((_066CDB4E16674AE7)P_0)._5CC31927E35B485F = P_1;
	}

	static void BBDC11BC498E4413(object P_0, float P_1)
	{
		((_066CDB4E16674AE7)P_0).C7EBD3260C49405F = P_1;
	}

	static void _004352088C254E11(object P_0, float P_1)
	{
		((_066CDB4E16674AE7)P_0)._397A2BA3C3D14472 = P_1;
	}

	static void _6AC74B8CED634F2D(object P_0, float P_1)
	{
		((_066CDB4E16674AE7)P_0)._13EC21C0126A4590 = P_1;
	}

	static void _1AB1CA73A2C5434D(object P_0, float P_1)
	{
		((_066CDB4E16674AE7)P_0).F8DC259E4DB743BD = P_1;
	}

	static string E34BE26597C148EC(string P_0, object P_1, object P_2)
	{
		return string.Format(P_0, P_1, P_2);
	}

	static void AC39440AFD2E4FA0(object P_0, string P_1)
	{
		((_066CDB4E16674AE7)P_0)._2C5400CFBA414C03 = P_1;
	}

	static void D63074A720084185(object P_0, float P_1)
	{
		((_066CDB4E16674AE7)P_0)._17AD318D49794A53 = P_1;
	}

	static void _3F7E9AE4879841A5(object P_0, float P_1)
	{
		((_066CDB4E16674AE7)P_0)._014A8D596C61406E = P_1;
	}

	static void _3A9393D695184453(object P_0, float P_1)
	{
		((_066CDB4E16674AE7)P_0)._14B817B76FD84521 = P_1;
	}

	static float C08A1EE5847F49B9(object P_0)
	{
		return ((ItemGunAsset)P_0).baseSpreadAngleRadians;
	}

	static object _0F8075720C8B4ACD(object P_0)
	{
		return ((Player)P_0).skills;
	}

	static float _8603AE79D3FA499C(object P_0)
	{
		return ((PlayerSkills)P_0).GetSharpshooterRecoilMultiplier();
	}

	static object _65093FCF8A174143(object P_0)
	{
		return ((Attachments)P_0).sightAsset;
	}

	static float _00C2C08655474062(object P_0)
	{
		return ((ItemCaliberAsset)P_0).spread;
	}

	static bool _97FC263521DA4768(object P_0)
	{
		return ((ItemCaliberAsset)P_0).ShouldOnlyAffectAimWhileProne;
	}

	static object CC10E7FB3FAB4F65(object P_0)
	{
		return ((Attachments)P_0).tacticalAsset;
	}

	static object _3AAC97ABB4334995(object P_0)
	{
		return ((Attachments)P_0).gripAsset;
	}

	static object _45FD8CA9F99F4B32(object P_0)
	{
		return ((Attachments)P_0).barrelAsset;
	}

	static object _411E2CED4CF04B70(object P_0)
	{
		return ((Attachments)P_0).magazineAsset;
	}

	static bool _87D4C2C5291A4884(object P_0)
	{
		return ((PlayerMovement)P_0).isGrounded;
	}

	static bool _12C0036407DD4EB0(object P_0)
	{
		return ((UseableGun)P_0).isAiming;
	}

	static float E817E9AFF36B4DFA(object P_0)
	{
		return ((ItemSightAsset)P_0).zoom;
	}

	static float _3AE81588B6A84F3F(object P_0, int P_1, int P_2)
	{
		return ((PlayerSkills)P_0).mastery(P_1, P_2);
	}

	static float _28695ED587AD4930(object P_0)
	{
		return ((ItemCaliberAsset)P_0).sway;
	}

	static float _25A9107C96964770(Vector3 P_0, Vector3 P_1)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return _9AB67761792440A7.A026CE8FA25C4CB8(P_0, P_1);
	}

	static long _82B5FE84C9634EA6()
	{
		return _9AB67761792440A7._00FC653ED33A4A96();
	}

	static object A636D00EF74944C6(object P_0, string P_1)
	{
		return ((A19CBF069C964833)P_0)._99A93C8FCF084453(P_1);
	}
}
