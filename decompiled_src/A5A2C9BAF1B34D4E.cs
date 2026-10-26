using System;
using SDG.Unturned;
using UnityEngine;

internal class A5A2C9BAF1B34D4E
{
	public delegate void _99554ED4AEB84AF8(A3116505AAB24996 _18D616526E174791, Player E5D78D4713FC4786, bool _86F58CAD734C41E6, bool _5BA8D3981B0C45A7);

	public static _99554ED4AEB84AF8? _6CA34B82A6AC4EDE;

	[_542A381FC1D44BA3(typeof(PlayerMovement), "simulate", _24AD03718EF64384._21C2F47B5D9744BD, new Type[]
	{
		typeof(uint),
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(float),
		typeof(float),
		typeof(bool),
		typeof(bool),
		typeof(float)
	})]
	public static void _0BB2535DFE3E452A(PlayerMovement __instance, uint simulation, int recov, int input_x, int input_y, float look_x, float look_y, bool inputJump, bool inputSprint, float deltaTime)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		A3116505AAB24996 a3116505AAB = A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)__instance).player);
		if (a3116505AAB != null)
		{
			_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?._10270708481F445D();
			_1DB744298E9F4B09._052FBC588F454484._4FCE5BF09DEA4F4D?._10270708481F445D();
			a3116505AAB.DB788F5F95DC46A0 = Vector2.op_Implicit(new Vector3((float)input_x, (float)input_y));
			a3116505AAB._2B10E1CD34274F52 = a3116505AAB._92A513FF7BCD47D5;
			a3116505AAB._92A513FF7BCD47D5 = Quaternion.Euler(0f, ((PlayerCaller)__instance).player.look.yaw, 0f);
			a3116505AAB._6C4C6ABD35E0410D = a3116505AAB.F1E0B3F113944108;
			a3116505AAB.F1E0B3F113944108 = Quaternion.Euler(((PlayerCaller)__instance).player.look.pitch - 90f, 0f, 0f);
			Quaternion dE38BE1DA = a3116505AAB.DE38BE1DA5014794;
			a3116505AAB.DE38BE1DA5014794 = a3116505AAB._92A513FF7BCD47D5 * a3116505AAB.F1E0B3F113944108;
			a3116505AAB._50DD9E33A315462C = Vector3.Angle(a3116505AAB.DE38BE1DA5014794 * Vector3.forward, dE38BE1DA * Vector3.forward);
			a3116505AAB._6E6AA4FFF0BB4169 = _9AB67761792440A7.A026CE8FA25C4CB8(_9AB67761792440A7.B808EF2078734847(a3116505AAB.DE38BE1DA5014794 * Vector3.forward), _9AB67761792440A7.B808EF2078734847(dE38BE1DA * Vector3.forward));
			a3116505AAB.D7F987AB3D1A4517 = Vector3.Angle(_9AB67761792440A7._3EB351770C3F4FD8(a3116505AAB.DE38BE1DA5014794 * Vector3.forward), _9AB67761792440A7._3EB351770C3F4FD8(dE38BE1DA * Vector3.forward));
			a3116505AAB.C20143E4630C4F9B = dE38BE1DA;
			_6CA34B82A6AC4EDE?.Invoke(a3116505AAB, ((PlayerCaller)__instance).player, inputJump, inputSprint);
			_1DB744298E9F4B09._052FBC588F454484._4FCE5BF09DEA4F4D?.F471762FF8094F2B(_1DB744298E9F4B09._052FBC588F454484._4FCE5BF09DEA4F4D.F27B18C1D6E54F89());
			_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F?.F471762FF8094F2B(_1DB744298E9F4B09._052FBC588F454484.ABB07B32EA8A499F.F27B18C1D6E54F89());
		}
	}

	[_542A381FC1D44BA3(typeof(PlayerMovement), "EnterCollisionTeleporter", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void EA7EA5D793804F34(PlayerMovement __instance)
	{
		A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)__instance).player)?.D4B92BC609984285();
	}

	[_542A381FC1D44BA3(typeof(PlayerMovement), "EnterTeleporterVolume", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static void BD4C8BB6464F457B(PlayerMovement __instance)
	{
		A3116505AAB24996._69C6AFA769194D6F(((PlayerCaller)__instance).player)?.D4B92BC609984285();
	}
}
