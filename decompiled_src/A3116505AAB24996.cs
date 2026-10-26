using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

public class A3116505AAB24996
{
	public struct _6E4F483A9B9449CC
	{
		public Quaternion FF3A8777E6B044B7;

		public Quaternion _88895B0EE0A947E5;

		public Vector3 D3568030374449FF;

		public Vector3 _2F294FA3A127454E;

		public float _6F39680A8CE54B98;

		public bool _3742319F0B1C495B;

		public readonly Quaternion _9C4D3ED43D094D8B
		{
			get
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_000c: Unknown result type (might be due to invalid IL or missing references)
				return FF3A8777E6B044B7 * _88895B0EE0A947E5;
			}
		}
	}

	public interface A267B4339FBD4D59
	{
		public struct _3AF648BB2F314484 : A267B4339FBD4D59
		{
			public ServerInvocationContext _9FA1F8D5A75D48EF;

			public bool _812C6F1789214088;

			public Transform _70A765625AA54A67;

			public object _54083F1B14D043B5;
		}

		public struct E9CDB3B678C04F5F : A267B4339FBD4D59
		{
			public ServerInvocationContext _99380B3C7B284224;

			public bool _73148AA3804F4E31;

			public ResourceSpawnpoint _4C409FFE87A14735;

			public byte _2C8AAE18A6184413;

			public byte _772F9F4B70334F8D;

			public ushort ABC3FAAB07524438;
		}

		public struct DF332201A56A40B3 : A267B4339FBD4D59
		{
			public ServerInvocationContext _08424B934AE046BF;

			public bool _70FDC26BD93242E3;

			public InteractableFire _5A9EAF16217642A7;

			public bool _0D3F3F5FC32C47C7;
		}

		public struct _23F4667886634573 : A267B4339FBD4D59
		{
			public ServerInvocationContext _433A423A0F7942CC;

			public bool B6BC7ADEDB174AEE;

			public InteractableOven _1F04B79D03924675;

			public bool DF46B5FB8C974ABC;
		}

		public struct D1A8FBEE34924E34 : A267B4339FBD4D59
		{
			public ServerInvocationContext _3F82ED7123CD4EAC;

			public bool _6B424141086A4D98;

			public InteractableSpot _32CAA1632E0542FB;

			public bool _0DB1EF5E797D4C8D;
		}

		public struct _5207C91BA80C4706 : A267B4339FBD4D59
		{
			public ServerInvocationContext _9970D7040A354B07;

			public bool _5BE4275EC4A84C3B;

			public InteractableFarm _42C8F724256B4942;
		}

		public struct _90B4111F6C8B4DC5 : A267B4339FBD4D59
		{
			public ServerInvocationContext _0E6B70342A274607;

			public bool _16E38A19D5324717;

			public InteractableBed _2ED408BBF5C047F1;
		}

		public struct C5BB0C7269794EEB : A267B4339FBD4D59
		{
			public ServerInvocationContext _41428D86D8994823;

			public bool AE71B0188CD04A36;

			public InteractableStorage _4ED7916E663B4B2F;

			public bool D889B6FE2CE14748;
		}

		public struct C440FCC2D3684F92 : A267B4339FBD4D59
		{
			public ServerInvocationContext _1701E54234534270;

			public bool _7B8354A019194A92;

			public Interactable _5A092AB01B884D07;

			public bool _987E8FC6E0184705;
		}
	}

	public static readonly ConcurrentDictionary<CSteamID, A3116505AAB24996> C23919949D8440FA;

	public static readonly long _7B165DBD1B874D50;

	public static readonly long A77D61B4B0FD460D = 1000L;

	public Vector3 _6427DD414B754955;

	public Vector3 B2803D8C670749DB;

	public Vector3 B684B1E7B0BA47C6;

	public Vector3 _0DA16FC0A0F84A2C;

	public Vector3 CEF93264C04F4D30;

	public Vector3 _8363984560D540DE;

	public Vector3 _83F11E366F4442B7;

	public Vector2 DB788F5F95DC46A0;

	public Quaternion DE38BE1DA5014794;

	public Quaternion C20143E4630C4F9B;

	public Quaternion _92A513FF7BCD47D5;

	public Quaternion _2B10E1CD34274F52;

	public Quaternion F1E0B3F113944108;

	public Quaternion _6C4C6ABD35E0410D;

	public float _2D4F008C6CD24E06;

	public bool _1C517C8A588A47C1;

	public float F08C7614E1E24E42;

	public float _0E84A52D8B85441F;

	public float A104D9F0D982448E;

	public float _68911883297A44E0;

	public float A4B01A943DEF4AFA;

	public float _30A4019A1B0C4B0C;

	public float _6386C4789B9E4530;

	public float _978879363C27415A;

	public float BF97EBC776294872;

	public float _50DD9E33A315462C;

	public float _6E6AA4FFF0BB4169;

	public float D7F987AB3D1A4517;

	public global::A807FD2A83C845A2<_6E4F483A9B9449CC> _505462E2C56449B1 = new global::A807FD2A83C845A2<_6E4F483A9B9449CC>(3);

	public Queue<A267B4339FBD4D59> _28945A26E8BF4305 = new Queue<A267B4339FBD4D59>();

	public List<(string Text, DateTime Timestamp)> B6FB1868C64B4AE7 = new List<(string, DateTime)>();

	public Dictionary<string, List<DateTime>> BEE1CD7F6E384F04 = new Dictionary<string, List<DateTime>>();

	public bool _256883125048413A;

	public bool _55A04A73D4B1454E;

	public bool C31CABBC84034E20;

	public bool C4DA765AFB124762;

	public long _57E8DCA4400A413E;

	public long _9D9DA155E15B401B;

	public long _34E706379A734924 = _9AB67761792440A7._00FC653ED33A4A96();

	public long D54F3E2F2CEB4FCF;

	public long C607DEBFA72A49CE;

	public long B15C4F7CA6DF4C8D;

	public long _67938E92F30243BF;

	public long _410DB7863006432C;

	public long B6FE4FCC2911449B;

	public long _443482020698440D;

	public int _4BBDBBC67C114F2D;

	public uint _7F3836A6EEFC4FC4;

	public bool C081DA16FC904E1E;

	public bool CC88B311C3C9412C;

	public float A17C7ECBE5454B78;

	public float _36E803127EF74F8C;

	public _8027E1DAC1FA44EB _5D524510B7C44B15 = new _8027E1DAC1FA44EB();

	public _8027E1DAC1FA44EB _4E59ED5DE8F64E9D = new _8027E1DAC1FA44EB();

	public _8027E1DAC1FA44EB _90DBC4A6726F474A = new _8027E1DAC1FA44EB();

	public _63009F37A59A432B _1D67FF3A771947F1 = new _63009F37A59A432B();

	public _222604882F4244C0 _965694AA41EB4336 = new _222604882F4244C0();

	public _7B93EFC9B3644586 _1610010BF5BD47DA = new _7B93EFC9B3644586();

	public ED0E82F427AA4C5F F470F3F6558649C1 = new ED0E82F427AA4C5F();

	public EA091ED8BF2C4A64 _638733A069E74AA4 = new EA091ED8BF2C4A64();

	public _4819911A0C0846FF _39063EF1442C4822 = new _4819911A0C0846FF();

	public B3E800F7DAAE405D _76477626BCDE4550 = new B3E800F7DAAE405D();

	public _6E7C0DC30F544C9E A19A123B68EB4A44 = new _6E7C0DC30F544C9E();

	public _88BB72CD49B54743 _35F1EA6BE31E4755 = new _88BB72CD49B54743();

	public _7A383615B64E4244 _83B3415EF0E34C51 = new _7A383615B64E4244();

	public _63009F37A59A432B._87AA5908A6EF41DD CFA8D5E44E2A4880;

	private int _363BA099B4C4404B = -1;

	private int _41D400FD5AE04E29 = -1;

	public bool A98460F771B0446B(_4C6B03DD3A6441ED P_0, IConfiguration P_1, CSteamID P_2)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (_41D400FD5AE04E29 == -1)
		{
			_41D400FD5AE04E29 = (ConfigurationBinder.GetValue<bool>(P_1, "Settings:BypassPermission", false) ? 1 : 0);
		}
		if (_41D400FD5AE04E29 == 0)
		{
			return false;
		}
		if (_363BA099B4C4404B == -1)
		{
			_363BA099B4C4404B = (P_0._66F4DDEF71A94E25(P_2, "proton.bypass").GetAwaiter().GetResult() ? 1 : 0);
		}
		return _363BA099B4C4404B == 1;
	}

	public static A3116505AAB24996 FCD5ADEC1258490A(Player P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		CSteamID steamID = P_0.channel.owner.playerID.steamID;
		A3116505AAB24996 a3116505AAB = new A3116505AAB24996
		{
			_57E8DCA4400A413E = _9AB67761792440A7._00FC653ED33A4A96()
		};
		C23919949D8440FA.TryAdd(steamID, a3116505AAB);
		return a3116505AAB;
	}

	public static A3116505AAB24996? _69C6AFA769194D6F(Player P_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		CSteamID steamID = P_0.channel.owner.playerID.steamID;
		if (C23919949D8440FA.TryGetValue(steamID, out A3116505AAB24996 value))
		{
			return value;
		}
		return null;
	}

	public bool _8E872EA320404135(Player P_0, Vector3 P_1)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)P_0.movement.getVehicle() != (Object)null)
		{
			return _2A320E2F1A3D4AAC._2854C72CF5B5446D._3FA9FE04F7C54C5E(P_0.movement.getVehicle(), P_1);
		}
		return true;
	}

	public bool _6C1BA5297F7F4446(InteractableVehicle P_0, Vector3 P_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return _2A320E2F1A3D4AAC._2854C72CF5B5446D.C855493D68FC40C0(P_0, P_1);
	}

	public bool _616493232A8943C9(long P_0)
	{
		if (D54F3E2F2CEB4FCF != 0L)
		{
			return _9AB67761792440A7._00FC653ED33A4A96() - D54F3E2F2CEB4FCF <= P_0;
		}
		return false;
	}

	public bool _0F638DE7CA844A28(long P_0)
	{
		if (B6FE4FCC2911449B != 0L)
		{
			return _9AB67761792440A7._00FC653ED33A4A96() - B6FE4FCC2911449B <= P_0;
		}
		return false;
	}

	public bool _642384DB2ED34461(bool P_0)
	{
		if (P_0)
		{
			if (C081DA16FC904E1E)
			{
				return false;
			}
			C081DA16FC904E1E = A17C7ECBE5454B78++ < 2f;
			return !C081DA16FC904E1E;
		}
		return true;
	}

	public bool _1EFD334B851044AD()
	{
		if (_443482020698440D != 0L && _9AB67761792440A7._00FC653ED33A4A96() - _443482020698440D <= A77D61B4B0FD460D)
		{
			if (CC88B311C3C9412C)
			{
				return false;
			}
			CC88B311C3C9412C = _36E803127EF74F8C++ < 2f;
			return !CC88B311C3C9412C;
		}
		return true;
	}

	public void D4B92BC609984285()
	{
		_443482020698440D = _9AB67761792440A7._00FC653ED33A4A96();
		_36E803127EF74F8C = 0f;
	}
}
