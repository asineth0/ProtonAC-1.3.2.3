using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using HarmonyLib;
using SDG.Unturned;
using UnityEngine;

internal static class _64A4BBC5E4CE4EE1
{
	public static readonly FieldRef<BulletInfo, float> _64E6F1F457E046B9 = AccessTools.FieldRefAccess<BulletInfo, float>(_003CModule_003E._58ECCB512F2A43AC<string>(1989096819));

	public static readonly FieldInfo _1E84BEEF44E648E3 = (FieldInfo)B2CFAC7D411A41F1((Type)_84AC7BA2FC5D4ADF(typeof(UseableGun).TypeHandle), _003CModule_003E._3F57E81A62734AC2<string>(-1172954067));

	public static readonly FieldInfo E35A200F75F74459 = (FieldInfo)B2CFAC7D411A41F1((Type)_84AC7BA2FC5D4ADF(typeof(UseableGun).TypeHandle), _003CModule_003E._58ECCB512F2A43AC<string>(867864801));

	public static readonly FieldRef<UseableGun, Attachments> _3D8DA4D4ADA34DEA = AccessTools.FieldRefAccess<UseableGun, Attachments>(_003CModule_003E._58ECCB512F2A43AC<string>(-1746284059));

	public static readonly FieldRef<UseableGun, Attachments> _74705AAE3534468A;

	public static readonly Func<UseableGun, bool> E8CFFE96D48E4806;

	public static readonly Func<UseableGun, float> B499E9D51CA345F9;

	public static readonly FieldRef<PlayerInput, int> BA44D26DE2144DF8;

	public static readonly Action<CommandWindow, string> C59E7E29CF4C4091;

	public static readonly FieldRef<SteamPlayer, EClientPlatform> _7B1216BE8CDA4953;

	public static readonly FieldRef<uint> F8961D8251614431;

	public static readonly FieldRef<PlayerMovement, PlayerStateUpdate> _5627CF87C9F0423B;

	public static readonly FieldRef<PlayerMovement, bool> _428211F609CD446A;

	public static readonly FieldRef<InteractableVehicle, Rigidbody> _1666B192DD1445FB;

	public static readonly FieldRef<InteractableVehicle, Transform> CFB8EA5D392C40F4;

	public static readonly FieldRef<InteractableObjectRubble, RubbleInfo[]> F5D0D009B88A49C8;

	public static readonly FieldRef<InteractableObjectRubble, GameObject> _18C7E0D250E041F5;

	public static readonly FieldRef<InteractableObjectRubble, GameObject> C02658AE60C24A9E;

	public static readonly FieldRef<Passenger, CapsuleCollider> _12E2FB22CF7C43A8;

	public static void E6DC166DE03C47D7(string P_0)
	{
		C59E7E29CF4C4091((CommandWindow)_18DD26F9FEFE46B4(), P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _64A4BBC5E4CE4EE1()
	{
		while (true)
		{
			int num = 504463146;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((((num2 * -1372416757 * 1909597459 + unchecked((-1101854108 ^ -941074716) - unchecked((unchecked(-329339233 * (-1251785483 ^ 0x50CF1DDA)) + (unchecked(-820493028 + -1746662235) - 1942128763)) * 404324435)) - (unchecked(unchecked(244207265 * -643718207) * 855078415) - unchecked((-1837346393 ^ 0x5496D83F) + (unchecked(1205609391 * -548340941) - (1150974036 - 278552070))))) * -1032586797 - ~(~-2028881891)) ^ -585243319) - 642698991)) % 9)
				{
				case 7u:
					break;
				case 0u:
					_428211F609CD446A = AccessTools.FieldRefAccess<PlayerMovement, bool>(_003CModule_003E._3F57E81A62734AC2<string>(289440883));
					_1666B192DD1445FB = AccessTools.FieldRefAccess<InteractableVehicle, Rigidbody>(_003CModule_003E._58ECCB512F2A43AC<string>(-616815313));
					num = -383621910;
					continue;
				case 3u:
					E8CFFE96D48E4806 = AccessTools.MethodDelegate<Func<UseableGun, bool>>((MethodInfo)_2B1745ED7B89478D((Type)_84AC7BA2FC5D4ADF(typeof(UseableGun).TypeHandle), _003CModule_003E.F84FA79ABE6944BB<string>(-706335672)), (object)null, (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0);
					num = -1799657102;
					continue;
				case 8u:
					_7B1216BE8CDA4953 = AccessTools.FieldRefAccess<SteamPlayer, EClientPlatform>(_003CModule_003E._58ECCB512F2A43AC<string>(1437747129));
					F8961D8251614431 = AccessTools.StaticFieldRefAccess<uint>((FieldInfo)B2CFAC7D411A41F1((Type)_84AC7BA2FC5D4ADF(typeof(PlayerManager).TypeHandle), _003CModule_003E._8B9C7B12B1AE4949<string>(-2117651763)));
					_5627CF87C9F0423B = AccessTools.FieldRefAccess<PlayerMovement, PlayerStateUpdate>(_003CModule_003E._58ECCB512F2A43AC<string>(-1829938946));
					num = -1877984146;
					continue;
				case 4u:
					_74705AAE3534468A = AccessTools.FieldRefAccess<UseableGun, Attachments>(_003CModule_003E._58ECCB512F2A43AC<string>(1529638744));
					num = 802716317;
					continue;
				case 2u:
					B499E9D51CA345F9 = AccessTools.MethodDelegate<Func<UseableGun, float>>((MethodInfo)_7B626E1071CF461A((Type)_84AC7BA2FC5D4ADF(typeof(UseableGun).TypeHandle), _003CModule_003E._8B9C7B12B1AE4949<string>(1873423904), (Type[])null, (Type[])null), (object)null, (byte)_003CModule_003E.F84FA79ABE6944BB<int>(1741630884) != 0);
					num = -1492485112;
					continue;
				case 5u:
					BA44D26DE2144DF8 = AccessTools.FieldRefAccess<PlayerInput, int>(_003CModule_003E._3F57E81A62734AC2<string>(161001206));
					C59E7E29CF4C4091 = AccessTools.MethodDelegate<Action<CommandWindow, string>>((MethodInfo)_7B626E1071CF461A((Type)_84AC7BA2FC5D4ADF(typeof(CommandWindow).TypeHandle), _003CModule_003E._390073C602714496<string>(1798947293), (Type[])null, (Type[])null), (object)null, (byte)_003CModule_003E._8B9C7B12B1AE4949<int>(350091668) != 0);
					num = -701275604;
					continue;
				case 6u:
					CFB8EA5D392C40F4 = AccessTools.FieldRefAccess<InteractableVehicle, Transform>(_003CModule_003E._3F57E81A62734AC2<string>(-479472316));
					num = -723683542;
					continue;
				default:
					F5D0D009B88A49C8 = AccessTools.FieldRefAccess<InteractableObjectRubble, RubbleInfo[]>(_003CModule_003E._3F57E81A62734AC2<string>(994996675));
					_18C7E0D250E041F5 = AccessTools.FieldRefAccess<InteractableObjectRubble, GameObject>(_003CModule_003E._58ECCB512F2A43AC<string>(-1554264101));
					C02658AE60C24A9E = AccessTools.FieldRefAccess<InteractableObjectRubble, GameObject>(_003CModule_003E._390073C602714496<string>(-1854195663));
					_12E2FB22CF7C43A8 = AccessTools.FieldRefAccess<Passenger, CapsuleCollider>(_003CModule_003E._3F57E81A62734AC2<string>(-2145738391));
					return;
				}
				break;
			}
		}
	}

	static object _18DD26F9FEFE46B4()
	{
		return Dedicator.commandWindow;
	}

	static object _84AC7BA2FC5D4ADF(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	static object B2CFAC7D411A41F1(Type P_0, string P_1)
	{
		return AccessTools.Field(P_0, P_1);
	}

	static object _2B1745ED7B89478D(Type P_0, string P_1)
	{
		return AccessTools.PropertyGetter(P_0, P_1);
	}

	static object _7B626E1071CF461A(Type P_0, string P_1, Type[] P_2, Type[] P_3)
	{
		return AccessTools.Method(P_0, P_1, P_2, P_3);
	}
}
