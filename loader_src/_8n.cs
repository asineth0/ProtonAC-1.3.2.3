using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

internal class _8n : MonoBehaviour
{
	private static GameObject? _Ff;

	private static readonly Queue<Action> _FO = (Queue<Action>)Activator.CreateInstance(typeof(Queue<Action>));

	public void Update()
	{
		_mE<Queue<Action>, bool>();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void _UK()
	{
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(3489427088u);
		while (true)
		{
			int num = 990476331;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(~(~(-(~(-(~num2))) - ((625260672 + 55955188 + -336095832) ^ 0x8AA6A5E)) * 338087909))) % 5)
				{
				case 4u:
					break;
				default:
					return;
				case 2u:
					_Ff = (GameObject?)_206F_206D_206A_200C_206B_206E_202B_202D_206E_206B_206A_206F_200C_202E_202D_206B_206F_206C_206E_200F_200E_200E_206D_202D_206C_206F_200F_206A_206C_200C_200E_200F_202D_200D_200F_202B_206F_206B_202E_206D_202E(global::_003CModule_003E._206F_200F_200D_200D_200E_206E_206C_206D_200E_200E_206E_200B_200F_200D_200F_206D_206A_206F_202C_202B_202E_206D_206D_202C_206C_206A_206E_200F_206D_206B_206F_200B_206B_202A_206C_206A_206E_206D_202E_206B_202E<string>((int)(0x7A2C338A ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(2, 1999856493u))));
					num = (int)(num3 * 1206183633) ^ -1368696148;
					continue;
				case 0u:
					_200E_200F_202E_202A_206B_206E_206A_206F_206C_206B_200D_206F_206E_202D_206A_200D_200D_206D_200B_202D_202E_202A_200F_200E_200D_200E_200B_206D_206A_202D_206A_202B_200F_202A_202E_200E_206C_200C_206C_202A_202E((Object)(object)_Ff);
					num = ((int)num3 * -1958438903) ^ 0x30200E25;
					continue;
				case 1u:
					_Ff.AddComponent<_8n>();
					num = (int)(num3 * 1457796445) ^ -523795151;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public static void _DB()
	{
		_mE<Queue<Action>, bool>();
		while (true)
		{
			int num = -1099238200;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((-505872125 ^ 0x44976112) - (~(-num2) - ~(-101660955 * ((-787987972 - 469515205) ^ -1307979755))) * 412462901 * -1509846079)) % 4)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
				{
					int num4;
					int num5;
					if (_202C_206F_206A_202D_206C_202D_202A_206C_206A_202A_206C_200F_202D_202E_202B_202D_206A_202C_202E_200D_202C_200F_202D_206B_202D_206B_206E_200E_202E_206F_202B_202E_206F_200E_206F_202B_206C_202B_202E_206A_202E((Object)(object)_Ff, (Object)null))
					{
						num4 = 1979615347;
						num5 = num4;
					}
					else
					{
						num4 = -257995460;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 19770667);
					continue;
				}
				case 1u:
					_206E_202C_200F_202D_200C_200D_206C_206D_202E_206C_200B_202C_206F_200B_206B_202D_200B_202E_202A_200F_206C_200F_202B_200C_206A_200C_200D_206B_202E_200E_200E_206E_206D_202A_202E_202B_202B_206E_200D_202E((Object)(object)_Ff);
					num = ((int)num3 * -1901499643) ^ -567586340;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private unsafe static void _mE<T0, T1>() where T0 : notnull where T1 : notnull
	{
		//IL_0008: Expected O, but got I4
		T0 fO = (T0)_FO;
		T1 val = (T1)0;
		try
		{
			_202A_200C_206B_200C_206A_200F_202A_200F_206E_200D_206F_206B_206F_202C_206D_200F_200F_206F_206B_200E_200F_206E_202A_206C_206A_206A_202D_206E_202A_200C_202B_200D_202C_206A_206E_200B_206D_206F_206D_202E((object)fO, ref *(bool*)(&val));
			while (_FO.Count > 0)
			{
				_FO.Dequeue()();
			}
		}
		finally
		{
			if (val != null)
			{
				_206C_202B_202E_200D_202C_206C_200D_206E_202D_200F_202B_206D_206B_206C_206D_202C_206D_200B_206F_200B_200E_200B_206A_202D_202C_202A_206E_202E_206C_200F_202E_206F_206D_202D_202B_206D_206B_206E_206D_200E_202E((object)fO);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public unsafe static void _GN<T0, T1, T2>(T2 P_0) where T0 : notnull where T1 : notnull where T2 : notnull
	{
		//IL_00f2: Expected O, but got I4
		_200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1405930079u);
		T0 fO = default(T0);
		while (true)
		{
			int num = 1764132718;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(--936640411 - -(~((~num2 ^ 0x373FAAAF) * -207823953)) * 526927011 - 850578848)) % 6)
				{
				case 2u:
					break;
				case 1u:
					fO = (T0)_FO;
					num = 109781441;
					continue;
				case 0u:
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 696687940u);
					num = ((int)num3 * -1611673488) ^ -1268913891;
					continue;
				case 4u:
				{
					int num8;
					int num9;
					if (P_0 == null)
					{
						num8 = -532262962;
						num9 = num8;
					}
					else
					{
						num8 = -1800635071;
						num9 = num8;
					}
					num = num8 ^ ((int)num3 * -29154123);
					continue;
				}
				case 5u:
					return;
				default:
				{
					T1 val = (T1)global::_003CModule_003E._206F_206E_206C_206A_200E_200F_200F_206A_202E_206E_206F_206F_200E_206C_202C_202E_200B_206E_206C_200F_202B_206D_206A_206B_202B_202E_200F_206F_206A_206C_206B_206D_200B_206C_200C_206A_206C_202C_202D_202E<int>((int)(0x718BBBF0 ^ obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(1, 1804988630u)));
					try
					{
						obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(1585827578u);
						while (true)
						{
							IL_00fe:
							int num4 = 1692241767;
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)(--936640411 - -(~((~num2 ^ 0x373FAAAF) * -207823953)) * 526927011 - 850578848)) % 4)
								{
								case 2u:
									break;
								default:
									goto end_IL_0103;
								case 1u:
									_202A_200C_206B_200C_206A_200F_202A_200F_206E_200D_206F_206B_206F_202C_206D_200F_200F_206F_206B_200E_200F_206E_202A_206C_206A_206A_202D_206E_202A_200C_202B_200D_202C_206A_206E_200B_206D_206F_206D_202E((object)fO, ref *(bool*)(&val));
									num4 = (int)((num3 * 1300540169) ^ 0x36D8DD21);
									continue;
								case 0u:
									_FO.Enqueue((Action)P_0);
									num4 = (int)(num3 * 1964119904) ^ -1301889255;
									continue;
								case 3u:
									goto end_IL_0103;
								}
								goto IL_00fe;
								continue;
								end_IL_0103:
								break;
							}
							break;
						}
					}
					finally
					{
						obj = new _200F_206A_200D_202E_206D_202A_206F_202B_202B_206F_202C_202B_206F_202E_206B_200B_200E_206F_206D_202D_206C_200C_200D_202D_200B_206C_202D_206D_206D_200C_202D_202D_202D_200C_206B_206C_202B_206E_200D_202D_202E(626503214u);
						while (true)
						{
							IL_01a9:
							int num5 = 2017621083;
							while (true)
							{
								num2 = num5;
								switch ((num3 = (uint)(--936640411 - -(~((~num2 ^ 0x373FAAAF) * -207823953)) * 526927011 - 850578848)) % 8)
								{
								case 2u:
									break;
								default:
									goto end_IL_01ae;
								case 1u:
								{
									int num6;
									int num7;
									if (val == null)
									{
										num6 = -769935965;
										num7 = num6;
									}
									else
									{
										num6 = -967543553;
										num7 = num6;
									}
									num5 = num6 ^ (int)(num3 * 993413318);
									continue;
								}
								case 4u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(10, 18983892u);
									num5 = (int)(num3 * 449745151) ^ -268101325;
									continue;
								case 3u:
									_206C_202B_202E_200D_202C_206C_200D_206E_202D_200F_202B_206D_206B_206C_206D_202C_206D_200B_206F_200B_200E_200B_206A_202D_202C_202A_206E_202E_206C_200F_202E_206F_206D_202D_202B_206D_206B_206E_206D_200E_202E((object)fO);
									num5 = ((int)num3 * -734081278) ^ 0x27DDA973;
									continue;
								case 0u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(5, 1676561356u);
									num5 = (int)((num3 * 1424966961) ^ 0x72F695B4);
									continue;
								case 5u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(3, 1670957364u);
									num5 = ((int)num3 * -705356476) ^ -1408328274;
									continue;
								case 7u:
									obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(0, 3066978772u);
									num5 = 1255347936;
									continue;
								case 6u:
									goto end_IL_01ae;
								}
								goto IL_01a9;
								continue;
								end_IL_01ae:
								break;
							}
							break;
						}
					}
					obj._206D_206A_200F_206E_206C_206C_206D_202E_206C_202B_206B_206A_206C_206C_202A_206F_206C_200D_200D_202B_206E_206F_202A_206C_200E_206E_202B_200D_200D_206F_202C_200F_202D_206E_206F_202D_202D_206B_206E_200D_202E(8, 1016334093u);
					return;
				}
				}
				break;
			}
		}
	}

	static object _206F_206D_206A_200C_206B_206E_202B_202D_206E_206B_206A_206F_200C_202E_202D_206B_206F_206C_206E_200F_200E_200E_206D_202D_206C_206F_200F_206A_206C_200C_200E_200F_202D_200D_200F_202B_206F_206B_202E_206D_202E(string P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return (object)new GameObject(P_0);
	}

	static void _200E_200F_202E_202A_206B_206E_206A_206F_206C_206B_200D_206F_206E_202D_206A_200D_200D_206D_200B_202D_202E_202A_200F_200E_200D_200E_200B_206D_206A_202D_206A_202B_200F_202A_202E_200E_206C_200C_206C_202A_202E(Object P_0)
	{
		Object.DontDestroyOnLoad(P_0);
	}

	static bool _202C_206F_206A_202D_206C_202D_202A_206C_206A_202A_206C_200F_202D_202E_202B_202D_206A_202C_202E_200D_202C_200F_202D_206B_202D_206B_206E_200E_202E_206F_202B_202E_206F_200E_206F_202B_206C_202B_202E_206A_202E(Object P_0, Object P_1)
	{
		return P_0 != P_1;
	}

	static void _206E_202C_200F_202D_200C_200D_206C_206D_202E_206C_200B_202C_206F_200B_206B_202D_200B_202E_202A_200F_206C_200F_202B_200C_206A_200C_200D_206B_202E_200E_200E_206E_206D_202A_202E_202B_202B_206E_200D_202E(Object P_0)
	{
		Object.Destroy(P_0);
	}

	static void _202A_200C_206B_200C_206A_200F_202A_200F_206E_200D_206F_206B_206F_202C_206D_200F_200F_206F_206B_200E_200F_206E_202A_206C_206A_206A_202D_206E_202A_200C_202B_200D_202C_206A_206E_200B_206D_206F_206D_202E(object P_0, ref bool P_1)
	{
		Monitor.Enter(P_0, ref P_1);
	}

	static void _206C_202B_202E_200D_202C_206C_200D_206E_202D_200F_202B_206D_206B_206C_206D_202C_206D_200B_206F_200B_200E_200B_206A_202D_202C_202A_206E_202E_206C_200F_202E_206F_206D_202D_202B_206D_206B_206E_206D_200E_202E(object P_0)
	{
		Monitor.Exit(P_0);
	}
}
