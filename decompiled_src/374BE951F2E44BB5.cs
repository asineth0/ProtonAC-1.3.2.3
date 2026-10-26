using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;
using Microsoft.Extensions.Logging;

public class _374BE951F2E44BB5 : _760EF57D5259421C
{
	[Serializable]
	[CompilerGenerated]
	private sealed class F2E88D7804924E63
	{
		public static readonly F2E88D7804924E63 _003C_003E9 = (F2E88D7804924E63)_457AF1F62EA44D96();

		public static Func<Type, IEnumerable<MethodInfo>> _003C_003E9__1_0;

		public static Func<MethodInfo, bool> _003C_003E9__1_1;

		public static Func<Type, string> _003C_003E9__1_3;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal IEnumerable<MethodInfo> D9C9424CC65A4C8C(Type P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool _7A1E4DABC8894EC6(MethodInfo P_0)
		{
			_650CCD1C9B464D36(default(RuntimeTypeHandle));
			A4A69B5EB9B24197((object)P_0, (object)null, false);
			return false;
		}

		internal string _43ECAB08453846FB(Type P_0)
		{
			return _25CCE6F847414A65((object)P_0);
		}

		static object _457AF1F62EA44D96()
		{
			return new F2E88D7804924E63();
		}

		static MethodInfo[] EBBF4F9BBD2A45B9(object P_0, BindingFlags P_1)
		{
			return ((Type)P_0).GetMethods(P_1);
		}

		static object _650CCD1C9B464D36(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		static object[] A4A69B5EB9B24197(object P_0, object P_1, bool P_2)
		{
			return ((MemberInfo)P_0).GetCustomAttributes((Type)P_1, P_2);
		}

		static string _25CCE6F847414A65(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}
	}

	[CompilerGenerated]
	private sealed class _954F1AB124AA4F48
	{
		public string _4199F325E2DE42B2;

		public Type[] _9BB5F186914040C1;

		public Type[] _825CF37CDB894E88;

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal bool F89070DFC9244D42(MethodInfo P_0)
		{
			if (EC44888A3372421E(_6F9E9C1242AD4887((object)P_0), _4199F325E2DE42B2))
			{
				while (true)
				{
					int num = 715880337;
					while (true)
					{
						int num2 = num;
						uint num3;
						switch ((num3 = (uint)(~(-((num2 * -1052949479 - unchecked(-1573891309 * 2081412109)) ^ (-unchecked((-1087603113 + 293511980 + unchecked(-511411283 - 2072454450)) * -668193731) - ~(-1814303803 ^ -unchecked(-381400301 * -1856422321))) ^ 0x44013AC9) * -476038355) * -13799537)) % 5)
						{
						case 0u:
							break;
						case 4u:
						{
							int num6;
							int num7;
							if (!_7B6A3E06CE144BAB((object)P_0))
							{
								num6 = -1129847872;
								num7 = num6;
							}
							else
							{
								num6 = -804995850;
								num7 = num6;
							}
							num = num6 ^ (int)(num3 * 293544995);
							continue;
						}
						case 2u:
						{
							int num4;
							int num5;
							if (F1B6F199D9664891((object)P_0).Length == _9BB5F186914040C1.Length)
							{
								num4 = -60263230;
								num5 = num4;
							}
							else
							{
								num4 = -1503685553;
								num5 = num4;
							}
							num = num4 ^ (int)(num3 * 1409208410);
							continue;
						}
						case 3u:
							return _2C1D7DDBA0274FE5((object)P_0).Length == _825CF37CDB894E88.Length;
						default:
							goto end_IL_0016;
						}
						break;
					}
					continue;
					end_IL_0016:
					break;
				}
			}
			return (byte)_003CModule_003E._58ECCB512F2A43AC<int>(352679804) != 0;
		}

		static string _6F9E9C1242AD4887(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		static bool EC44888A3372421E(string P_0, string P_1)
		{
			return P_0 == P_1;
		}

		static bool _7B6A3E06CE144BAB(object P_0)
		{
			return ((MethodBase)P_0).IsGenericMethodDefinition;
		}

		static Type[] F1B6F199D9664891(object P_0)
		{
			return ((MethodBase)P_0).GetGenericArguments();
		}

		static ParameterInfo[] _2C1D7DDBA0274FE5(object P_0)
		{
			return ((MethodBase)P_0).GetParameters();
		}
	}

	private readonly List<(MethodBase original, MethodInfo patch)> F596843B6E9B416F;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void _145E72FC73C04183()
	{
		GC.KeepAlive(null);
	}

	public virtual void _5E2EBFB855C94DB8()
	{
		using (List<(MethodBase, MethodInfo)>.Enumerator enumerator = F596843B6E9B416F.GetEnumerator())
		{
			(MethodBase, MethodInfo) current = default;
			while (true)
			{
				IL_0099:
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = 744762299;
					num2 = num;
				}
				else
				{
					num = -1823085896;
					num2 = num;
				}
				while (true)
				{
					int num3 = num;
					uint num4;
					switch ((num4 = (uint)(~(-(-(~(-(~num3) + (unchecked(unchecked(-1302019267 * 1381404182) + 1568994921) + (1527149206 - 264145370 + (415802026 - 1074685539) + 244520046 + (--1243362440 - -2024079202 - (1535989255 - 752238856 + (0x79ABB5AE ^ -783476786))))))))) ^ 0x56D6CAF2)) % 5)
					{
					case 4u:
						num = -1823085896;
						continue;
					default:
						goto end_IL_0016;
					case 1u:
						break;
					case 2u:
						AFFD23764F28405F((object)_760EF57D5259421C.F508BD2323654019, (object)current.Item1, (object)current.Item2);
						num = ((int)num4 * -358201582) ^ -3321957;
						continue;
					case 3u:
						current = enumerator.Current;
						num = 1881844569;
						continue;
					case 0u:
						goto end_IL_0016;
					}
					goto IL_0099;
					continue;
					end_IL_0016:
					break;
				}
				break;
			}
		}
		F596843B6E9B416F.Clear();
		_2B562F5A1E504CBC();
	}

	public _374BE951F2E44BB5()
	{
		List<(MethodBase, MethodInfo)> f596843B6E9B416F = null;
		F596843B6E9B416F = f596843B6E9B416F;
	}

	static object _64442655A07B403A()
	{
		return Assembly.GetExecutingAssembly();
	}

	static Type[] _514024113E5F42B6(object P_0)
	{
		return ((Assembly)P_0).GetTypes();
	}

	static object FC909A3D6180440D()
	{
		return new _954F1AB124AA4F48();
	}

	static object B0EF528C66BE4EED(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object[] BFD943A0F8664AFD(object P_0, object P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes((Type)P_1, P_2);
	}

	static object _178455E446154CE5(object P_0)
	{
		return ((_542A381FC1D44BA3)P_0)._0FB47E4E20D24D2F;
	}

	static string _6414080357CE46A7(object P_0)
	{
		return ((_542A381FC1D44BA3)P_0)._37662C4CEEC14AA4;
	}

	static Type[] _81C29B1F361A4609(object P_0)
	{
		return ((_542A381FC1D44BA3)P_0)._3458718780114A23;
	}

	static Type[] BBD98D558F134900(object P_0)
	{
		return ((_542A381FC1D44BA3)P_0)._2FBBDDB67E0648FE;
	}

	static object _5C35478788334AC1(Type P_0, string P_1, Type[] P_2, Type[] P_3)
	{
		return AccessTools.Method(P_0, P_1, P_2, P_3);
	}

	static MethodInfo[] _3D9EC9BFAF0A42DF(object P_0)
	{
		return ((Type)P_0).GetMethods();
	}

	static object _1150C9F941D74386(object P_0, Type[] P_1)
	{
		return ((MethodInfo)P_0).MakeGenericMethod(P_1);
	}

	static bool _13C26FC0D3514E17(MethodInfo P_0, MethodInfo P_1)
	{
		return P_0 == P_1;
	}

	static string AEE5280B921D4012(object P_0)
	{
		return ((Type)P_0).FullName;
	}

	static string _7F50D60429284B92(string P_0, IEnumerable<string> P_1)
	{
		return string.Join(P_0, P_1);
	}

	static string _3951D979B0304682(string P_0, string P_1, string P_2)
	{
		return P_0 + P_1 + P_2;
	}

	static string B861478038B54668(string[] P_0)
	{
		return string.Concat(P_0);
	}

	static void _8EC490C0DA444527(ILogger P_0, string P_1, object[] P_2)
	{
		LoggerExtensions.LogWarning(P_0, P_1, P_2);
	}

	static object _73C39955815148C2(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected Obj, but got Unknown
		return (object)new HarmonyMethod((MethodInfo)P_0);
	}

	static _24AD03718EF64384 B512A7B65EC6462D(object P_0)
	{
		return ((_542A381FC1D44BA3)P_0).E71F452CC443465C;
	}

	static object _49FBE2F053044039(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		FFA45111F5D348D7._2BF1A0D7A9BC44FE((string)null, (object)null, (object)null, (object)null);
		return null;
	}

	static bool B2A503FA532F4E76(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	static void _9CBC17A6810440DF(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	void _2051AA95EE464726()
	{
		base.A599C828530B4E69();
	}

	static void AFFD23764F28405F(object P_0, object P_1, object P_2)
	{
		((Harmony)P_0).Unpatch((MethodBase)P_1, (MethodInfo)P_2);
	}

	void _2B562F5A1E504CBC()
	{
		base.C4CA2ECFAD654E77();
	}
}
