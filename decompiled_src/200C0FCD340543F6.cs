using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

public abstract class _200C0FCD340543F6
{
	public bool A3CF4997217E497C => this is _2E54684D829B4208;

	public bool _3C932459E214469B => this is E2BC8640A3134A27;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static _200C0FCD340543F6 _41B423B9BBFA4DD0(Player P_0)
	{
		if (FDCCABD004704384((Object)(object)P_0, (Object)null))
		{
			while (true)
			{
				int num = 2131182528;
				uint num2;
				switch ((num2 = (uint)(-(-(~(-(~(-797458190 - (846704206 + -1313592884)) ^ 0x30F3D170) - (~(-(-unchecked(-1650292533 * -211964471) + ~(-1219962278 - -1244041153))) - 331874399 * (231709969 * ((-742035236 + ~-812130653) * -1380875089)) - ~num))) * 273909725))) % 3)
				{
				case 0u:
					continue;
				case 2u:
					throw A134FC53D8BD4C78(_003CModule_003E._8B9C7B12B1AE4949<string>(360455220));
				}
				break;
			}
		}
		return (_200C0FCD340543F6)F89FE127A8234470((object)P_0);
	}

	public static _200C0FCD340543F6 _7C49F3F609634A1E(CSteamID P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return (_200C0FCD340543F6)FDC31B35B71C47E1(P_0);
	}

	public virtual Player? F126871565D3416A()
	{
		return null;
	}

	public virtual CSteamID? _23E19D6E7BEF47E0()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public CSteamID E6E47FE0E57A443A()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		Player val = (Player)_05394775E0634E87((object)this);
		if (_8A8A6A3C81F4471D((Object)(object)val, (Object)null))
		{
			goto IL_0010;
		}
		goto IL_008c;
		IL_0010:
		int num = 1422700221;
		goto IL_0015;
		IL_0015:
		int num2 = num;
		uint num3;
		CSteamID? val2 = default;
		switch ((num3 = (uint)((num2 * 1228397821 - ~(--1754707369) + -694571648) * 667240309)) % 5)
		{
		case 2u:
			break;
		case 3u:
			return _2630D22396E642BE(_5B86671455E94AB7((object)((SteamChannel)_45EEEACF53C74FBF((object)val)).owner));
		case 1u:
			return val2.Value;
		case 4u:
			goto IL_008c;
		default:
			throw A90AE46F54604645(_003CModule_003E._3F57E81A62734AC2<string>(-1887596698));
		}
		goto IL_0010;
		IL_008c:
		val2 = F19302F643F24FB4((object)this);
		int num4;
		if (!val2.HasValue)
		{
			num = 168995732;
			num4 = num;
		}
		else
		{
			num = 1682930607;
			num4 = num;
		}
		goto IL_0015;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public UniTask _96EF65A363244CC0(string P_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		return _1410AEB4A7B24C0A((object)this, P_0, Color.white, (byte)_003CModule_003E._58ECCB512F2A43AC<int>(1006217019) != 0, (string)null);
	}

	public abstract UniTask AE48F40087984EA0(string P_0, Color P_1, bool P_2 = true, string? P_3 = null);

	static bool FDCCABD004704384(Object P_0, Object P_1)
	{
		return P_0 == P_1;
	}

	static object A134FC53D8BD4C78(string P_0)
	{
		return new ArgumentNullException(P_0);
	}

	static object F89FE127A8234470(object P_0)
	{
		return new _2E54684D829B4208((Player)P_0);
	}

	static object FDC31B35B71C47E1(CSteamID P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return new E2BC8640A3134A27(P_0);
	}

	static object _05394775E0634E87(object P_0)
	{
		return ((_200C0FCD340543F6)P_0).F126871565D3416A();
	}

	static bool _8A8A6A3C81F4471D(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static object _45EEEACF53C74FBF(object P_0)
	{
		return ((Player)P_0).channel;
	}

	static object _5B86671455E94AB7(object P_0)
	{
		return ((SteamPlayer)P_0).playerID;
	}

	static CSteamID _2630D22396E642BE(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((SteamPlayerID)P_0).steamID;
	}

	static CSteamID? F19302F643F24FB4(object P_0)
	{
		return ((_200C0FCD340543F6)P_0)._23E19D6E7BEF47E0();
	}

	static object A90AE46F54604645(string P_0)
	{
		return new InvalidOperationException(P_0);
	}

	static UniTask _1410AEB4A7B24C0A(object P_0, string P_1, Color P_2, bool P_3, string P_4)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return ((_200C0FCD340543F6)P_0).AE48F40087984EA0(P_1, P_2, P_3, P_4);
	}
}
