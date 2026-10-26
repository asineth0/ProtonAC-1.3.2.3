using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

internal class F0CD1E00058640DE : _760EF57D5259421C
{
	[CompilerGenerated]
	private sealed class _02834BF6F9CE4817
	{
		public long _76A3ECD65DC84313;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void _39C802D54BF14583(CSteamID P_0, byte[] P_1)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			if (!_16BA0CC17E904D7A((object)_screenRecorderService).TryGetValue(P_0, out C7A753824C0746AE._359F714CB1DB4E96 value))
			{
				return;
			}
			long num7 = default;
			long num4 = default;
			while (true)
			{
				int num = -21909004;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)((-((num2 - -(~(~(~(--1246145102 ^ 0xB3EE470)) * -1424139233))) ^ (-(~-1120803010) * -1874159889)) ^ ~(~(--1389013672 + --1974668367))) * -1117805389 * -1888342773 * -1385462827)) % 6)
					{
					case 5u:
						break;
					default:
						return;
					case 2u:
						num7 = _76A3ECD65DC84313 + num4 / _003CModule_003E._58ECCB512F2A43AC<int>(1208532887);
						num = 1422489329;
						continue;
					case 0u:
						value._849CF3D1826A4684 += _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
						value._358E24B6AAB2450C.Add((_23AFFD5168C1458B)C5AC7166D0754CEA(num7, P_1));
						num = 745939157;
						continue;
					case 1u:
					{
						int num5;
						int num6;
						if (value._849CF3D1826A4684 >= value._8985A39E28C04E36)
						{
							num5 = 429568050;
							num6 = num5;
						}
						else
						{
							num5 = -1783413131;
							num6 = num5;
						}
						num = num5 ^ (int)(num3 * 441980157);
						continue;
					}
					case 3u:
						num4 = D7E33806F2AE4B00() - _76A3ECD65DC84313;
						num = ((int)num3 * -100165068) ^ 0x42AF3C89;
						continue;
					case 4u:
						return;
					}
					break;
				}
			}
		}

		static ConcurrentDictionary<CSteamID, C7A753824C0746AE._359F714CB1DB4E96> _16BA0CC17E904D7A(object P_0)
		{
			return ((C7A753824C0746AE)P_0).ADAA9521257F4886();
		}

		static long D7E33806F2AE4B00()
		{
			return _9AB67761792440A7._00FC653ED33A4A96();
		}

		static object C5AC7166D0754CEA(long P_0, byte[] P_1)
		{
			return new _23AFFD5168C1458B(P_0, P_1);
		}
	}

	private static readonly A19CBF069C964833 _performanceProfilingService;

	private static readonly A19CBF069C964833._40FE7AC3F69F4B10 _playerTicking = null;

	private static readonly C7A753824C0746AE _screenRecorderService;

	public static readonly List<Collider> trackingTeleporters;

	public static readonly CD12FBF2EC134DF5 playerTracking = new CD12FBF2EC134DF5();

	public static bool scannedTeleporters;

	[_542A381FC1D44BA3(typeof(PlayerManager), "sendPlayerStates", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool SendPlayerStates_Prefix(PlayerManager __instance)
	{
		GC.KeepAlive(null);
		return false;
	}
}
