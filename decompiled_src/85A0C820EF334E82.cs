using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

internal class _85A0C820EF334E82 : C179263454B44BF6
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AA43369C3B1A47A1 _40CCC338AB744483()
	{
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		List<_31CD7D2CD00648BB> list = new List<_31CD7D2CD00648BB>();
		BarricadeRegion[,] array = AE9DFBC94AAD45DB();
		int num5 = default;
		int num4 = default;
		Vector2 val4 = default;
		BarricadeDrop current2 = default;
		RaycastHit val3 = default;
		int num6 = default;
		List<_1FFFBD257FC54BA7> list2 = default;
		Vector2 val2 = default;
		LocationDevkitNode current = default;
		string text = default;
		string text2 = default;
		int num24 = default;
		while (true)
		{
			int num = 1593013277;
			while (true)
			{
				int num2 = num;
				int num7;
				uint num3;
				switch ((num3 = (uint)(~((-(-(~num2)) * -1325723751 + (-2068206648 - -unchecked(1416580715 * 1572542775))) * -189477837 * 2079195529))) % 5)
				{
				case 2u:
					break;
				case 4u:
					num5 = _211D6CEFAABF42C3((object)array, _003CModule_003E._390073C602714496<int>(-250964212));
					goto IL_0332;
				case 3u:
					num4 = _211D6CEFAABF42C3((object)array, _003CModule_003E._58ECCB512F2A43AC<int>(352679804));
					goto IL_02f1;
				case 1u:
					goto IL_00a1;
				default:
					{
						using (List<BarricadeDrop>.Enumerator enumerator2 = _99C48AB3294E43DF((object)array[num4, num5]).GetEnumerator())
						{
							while (true)
							{
								IL_01d0:
								int num18;
								int num19;
								if (enumerator2.MoveNext())
								{
									num18 = -2126750172;
									num19 = num18;
								}
								else
								{
									num18 = -510251102;
									num19 = num18;
								}
								while (true)
								{
									num2 = num18;
									switch ((num3 = (uint)(~((-(-(~num2)) * -1325723751 + (-2068206648 - -unchecked(1416580715 * 1572542775))) * -189477837 * 2079195529))) % 8)
									{
									case 5u:
										num18 = -2126750172;
										continue;
									default:
										goto end_IL_00f3;
									case 6u:
										val4 = _61FC431FE143423B(EC3291C72D3A4BFF(_81BF666330034FAE(_4957739CD3CF466B((object)current2))));
										num18 = ((int)num3 * -20693734) ^ -1587375495;
										continue;
									case 3u:
									{
										int num21;
										int num22;
										if (_4957739CD3CF466B((object)current2) is InteractableStorage)
										{
											num21 = 1078945016;
											num22 = num21;
										}
										else
										{
											num21 = 481795628;
											num22 = num21;
										}
										num18 = num21 ^ (int)(num3 * 1357543773);
										continue;
									}
									case 7u:
									{
										current2 = enumerator2.Current;
										int num23;
										if (_4957739CD3CF466B((object)current2) is InteractableBed)
										{
											num18 = -2039006737;
											num23 = num18;
										}
										else
										{
											num18 = -1076122248;
											num23 = num18;
										}
										continue;
									}
									case 4u:
										break;
									case 2u:
										list.Add((_31CD7D2CD00648BB)D110687536DF42B5(val4.x, val4.y, _46392EF1E3E1477C(EC3291C72D3A4BFF(_81BF666330034FAE(_4957739CD3CF466B((object)current2))))));
										num18 = ((int)num3 * -622926297) ^ -1091548275;
										continue;
									case 0u:
									{
										int num20;
										if (!B264157A2A924FBB(EC3291C72D3A4BFF(_81BF666330034FAE(_4957739CD3CF466B((object)current2))), Vector3.down, ref val3, _003CModule_003E._3F57E81A62734AC2<float>(-1429949052), _003CModule_003E._58ECCB512F2A43AC<int>(1772237669)))
										{
											num18 = 1629666761;
											num20 = num18;
										}
										else
										{
											num18 = -628112581;
											num20 = num18;
										}
										continue;
									}
									case 1u:
										goto end_IL_00f3;
									}
									goto IL_01d0;
									continue;
									end_IL_00f3:
									break;
								}
								break;
							}
						}
						num5 += _003CModule_003E._3F57E81A62734AC2<int>(1017304263);
						goto IL_029b;
					}
					IL_0332:
					if (num5 <= num6)
					{
						goto default;
					}
					num7 = -1611945305;
					goto IL_02a0;
					IL_02a0:
					while (true)
					{
						num2 = num7;
						switch ((num3 = (uint)(~((-(-(~num2)) * -1325723751 + (-2068206648 - -unchecked(1416580715 * 1572542775))) * -189477837 * 2079195529))) % 6)
						{
						case 0u:
							break;
						case 3u:
							goto IL_02f1;
						case 2u:
							num4 += _003CModule_003E._390073C602714496<int>(-250964212);
							num7 = -1778900988;
							continue;
						case 4u:
							list2 = new List<_1FFFBD257FC54BA7>();
							num7 = (int)(num3 * 1864580131) ^ -1519777218;
							continue;
						case 5u:
							goto IL_0332;
						default:
						{
							object obj = _80605973909F4CFB();
							Local val = (Local)((obj != null) ? A72B700F46844106(obj) : null);
							IEnumerator<LocationDevkitNode> enumerator = E7AAEA26D56144FF(F9F24834135746B1()).GetEnumerator();
							try
							{
								while (true)
								{
									IL_051b:
									int num8;
									int num9;
									if (_231181FE01BD4049((object)enumerator))
									{
										num8 = 1012603849;
										num9 = num8;
									}
									else
									{
										num8 = 1793515732;
										num9 = num8;
									}
									while (true)
									{
										num2 = num8;
										switch ((num3 = (uint)(~((-(-(~num2)) * -1325723751 + (-2068206648 - -unchecked(1416580715 * 1572542775))) * -189477837 * 2079195529))) % 11)
										{
										case 10u:
											num8 = 1012603849;
											continue;
										default:
											goto end_IL_0372;
										case 3u:
										{
											int num13;
											int num14;
											if (val == null)
											{
												num13 = 727538400;
												num14 = num13;
											}
											else
											{
												num13 = -412295265;
												num14 = num13;
											}
											num8 = num13 ^ ((int)num3 * -1178330127);
											continue;
										}
										case 1u:
											val2 = _61FC431FE143423B(EC3291C72D3A4BFF(_81BF666330034FAE((object)current)));
											num8 = 1607207018;
											continue;
										case 4u:
											text = _9C238A93815E443D((object)val, text2);
											num8 = (int)(num3 * 1295729106) ^ -737216068;
											continue;
										case 8u:
										{
											current = enumerator.Current;
											int num12;
											if (!current.isVisibleOnMap)
											{
												num8 = 228741506;
												num12 = num8;
											}
											else
											{
												num8 = 2085538131;
												num12 = num8;
											}
											continue;
										}
										case 9u:
											text2 = F939E10545354E54((object)text, (char)_003CModule_003E._8B9C7B12B1AE4949<int>(-408136254), (char)_003CModule_003E._8B9C7B12B1AE4949<int>(-1377793529));
											num8 = 1761511337;
											continue;
										case 7u:
											list2.Add((_1FFFBD257FC54BA7)_572AE8D33BA34F33(text, val2.x, val2.y, _46392EF1E3E1477C(EC3291C72D3A4BFF(_81BF666330034FAE((object)current)))));
											num8 = (int)(num3 * 691642784) ^ -1792330462;
											continue;
										case 5u:
										{
											int num15;
											int num16;
											if (!A54CE39FAD1548FC((object)val, text2))
											{
												num15 = 527180510;
												num16 = num15;
											}
											else
											{
												num15 = 1682745014;
												num16 = num15;
											}
											num8 = num15 ^ (int)(num3 * 341546004);
											continue;
										}
										case 2u:
										{
											text = current.locationName;
											int num10;
											int num11;
											if (!_0A9A755EDBF347B9(text))
											{
												num10 = -472624434;
												num11 = num10;
											}
											else
											{
												num10 = -1956735322;
												num11 = num10;
											}
											num8 = num10 ^ ((int)num3 * -856460823);
											continue;
										}
										case 0u:
											break;
										case 6u:
											goto end_IL_0372;
										}
										goto IL_051b;
										continue;
										end_IL_0372:
										break;
									}
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									while (true)
									{
										IL_053e:
										int num17 = 1409692785;
										while (true)
										{
											num2 = num17;
											switch ((num3 = (uint)(~((-(-(~num2)) * -1325723751 + (-2068206648 - -unchecked(1416580715 * 1572542775))) * -189477837 * 2079195529))) % 3)
											{
											case 0u:
												break;
											default:
												goto end_IL_0543;
											case 1u:
												goto IL_0588;
											case 2u:
												goto end_IL_0543;
											}
											goto IL_053e;
											IL_0588:
											_5C1D8A72B9B04EB2((object)enumerator);
											num17 = ((int)num3 * -239630230) ^ -1062760563;
											continue;
											end_IL_0543:
											break;
										}
										break;
									}
								}
							}
							return (AA43369C3B1A47A1)_3653CD92057F4615(list2, list);
						}
						}
						break;
					}
					goto IL_029b;
					IL_02f1:
					if (num4 <= num24)
					{
						goto case 4u;
					}
					num7 = -1261228177;
					goto IL_02a0;
					IL_029b:
					num7 = -1387125560;
					goto IL_02a0;
				}
				break;
				IL_00a1:
				num24 = C2ED7B076D1E4F79((object)array, _003CModule_003E._3F57E81A62734AC2<int>(-1803194042));
				num6 = C2ED7B076D1E4F79((object)array, _003CModule_003E.F84FA79ABE6944BB<int>(1741630884));
				num = -1510362232;
			}
		}
	}

	static BarricadeRegion[,] AE9DFBC94AAD45DB()
	{
		return BarricadeManager.regions;
	}

	static int C2ED7B076D1E4F79(object P_0, int P_1)
	{
		return ((Array)P_0).GetUpperBound(P_1);
	}

	static int _211D6CEFAABF42C3(object P_0, int P_1)
	{
		return ((Array)P_0).GetLowerBound(P_1);
	}

	static List<BarricadeDrop> _99C48AB3294E43DF(object P_0)
	{
		return ((BarricadeRegion)P_0).drops;
	}

	static object _4957739CD3CF466B(object P_0)
	{
		return ((BarricadeDrop)P_0).interactable;
	}

	static object _81BF666330034FAE(object P_0)
	{
		return ((Component)P_0).transform;
	}

	static Vector3 EC3291C72D3A4BFF(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Transform)P_0).position;
	}

	static bool B264157A2A924FBB(Vector3 P_0, Vector3 P_1, ref RaycastHit P_2, float P_3, int P_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return Physics.Raycast(P_0, P_1, ref P_2, P_3, P_4);
	}

	static Vector2 _61FC431FE143423B(Vector3 P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return FFA45111F5D348D7._1112B13D40924F28(P_0);
	}

	static string _46392EF1E3E1477C(Vector3 P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		return P_0._5EE59AFB8F8E476C();
	}

	static object D110687536DF42B5(float P_0, float P_1, string P_2)
	{
		return new _31CD7D2CD00648BB(P_0, P_1, P_2);
	}

	static object _80605973909F4CFB()
	{
		return Level.info;
	}

	static object A72B700F46844106(object P_0)
	{
		return ((LevelInfo)P_0).getLocalization();
	}

	static object F9F24834135746B1()
	{
		return LocationDevkitNodeSystem.Get();
	}

	static IReadOnlyList<LocationDevkitNode> E7AAEA26D56144FF(object P_0)
	{
		return ((LocationDevkitNodeSystem)P_0).GetAllNodes();
	}

	static bool _0A9A755EDBF347B9(string P_0)
	{
		return string.IsNullOrWhiteSpace(P_0);
	}

	static string F939E10545354E54(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	static bool A54CE39FAD1548FC(object P_0, string P_1)
	{
		return ((Local)P_0).has(P_1);
	}

	static string _9C238A93815E443D(object P_0, string P_1)
	{
		return ((Local)P_0).format(P_1);
	}

	static object _572AE8D33BA34F33(string P_0, float P_1, float P_2, string P_3)
	{
		return new _1FFFBD257FC54BA7(P_0, P_1, P_2, P_3);
	}

	static bool _231181FE01BD4049(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	static void _5C1D8A72B9B04EB2(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	static object _3653CD92057F4615(List<_1FFFBD257FC54BA7> P_0, List<_31CD7D2CD00648BB> P_1)
	{
		return new AA43369C3B1A47A1(P_0, P_1);
	}
}
