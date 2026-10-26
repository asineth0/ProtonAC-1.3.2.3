using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class ABC2BC94E3D04F1B
{
	public delegate void C081BFDAC9624BDD(Player _24C800FF6BB44EFB, in ServerInvocationContext _0C6B6508C2FA4CAC, NetId _1D0686FDD69C4362, ref bool C09D28D36D3E4EEE);

	public delegate void EC9836EA98314D1A(Player _0E41A3CF582E48E0, in ServerInvocationContext _6ACE5BEE41394AE2, InteractableObject _1E741BFC77764009, ref bool _3C652579CDF44615);

	public static C081BFDAC9624BDD? E2E0B627AFEF46CD;

	public static EC9836EA98314D1A? _3F20AA5736F344FD;

	[_542A381FC1D44BA3(typeof(ObjectManager_NetMethods), "ReceiveTalkWithNpcRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _37B690507A2B4139(in ServerInvocationContext context)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		NetId val = default;
		NetIdPakEx.ReadNetId(context.reader, ref val);
		if (_957A6C3FB8FC4257(in context, val))
		{
			ObjectManager.ReceiveTalkWithNpcRequest(ref context, val);
		}
		return false;
	}

	private static bool _957A6C3FB8FC4257(in ServerInvocationContext _4D27365BC54346AE, NetId _0411C78C80D949D1)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		Player player = _4D27365BC54346AE.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		IDialogueTarget dialogueTargetFromNetId = InteractableObjectNPC.GetDialogueTargetFromNetId(_0411C78C80D949D1);
		if (dialogueTargetFromNetId == null)
		{
			return true;
		}
		Vector3 val = dialogueTargetFromNetId.GetDialogueTargetWorldPosition() - ((Component)player).transform.position;
		if (val.sqrMagnitude > 400f)
		{
			return true;
		}
		if (!dialogueTargetFromNetId.ShouldServerApproveDialogueRequest(player))
		{
			return true;
		}
		bool C09D28D36D3E4EEE = true;
		E2E0B627AFEF46CD?.Invoke(player, in _4D27365BC54346AE, _0411C78C80D949D1, ref C09D28D36D3E4EEE);
		return C09D28D36D3E4EEE;
	}

	[_542A381FC1D44BA3(typeof(ObjectManager_NetMethods), "ReceiveUseObjectDropper_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _170020DFB03C4382(in ServerInvocationContext context)
	{
		NetPakReader reader = context.reader;
		byte b = default;
		SystemNetPakReaderEx.ReadUInt8(reader, ref b);
		byte b2 = default;
		SystemNetPakReaderEx.ReadUInt8(reader, ref b2);
		ushort num = default;
		SystemNetPakReaderEx.ReadUInt16(reader, ref num);
		if (D83A44AAAD7240C1(in context, b, b2, num))
		{
			ObjectManager.ReceiveUseObjectDropper(ref context, b, b2, num);
		}
		return false;
	}

	private static bool D83A44AAAD7240C1(in ServerInvocationContext ACDCDFCC3A52443B, byte E9AAD4DFDDEA4FF8, byte _822771CC89834C50, ushort _9150E4B3D7C74532)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (!Regions.checkSafe((int)E9AAD4DFDDEA4FF8, (int)_822771CC89834C50))
		{
			return true;
		}
		Player player = ACDCDFCC3A52443B.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		if (_9150E4B3D7C74532 >= LevelObjects.objects[E9AAD4DFDDEA4FF8, _822771CC89834C50].Count)
		{
			return true;
		}
		if (LevelObjects.objects[E9AAD4DFDDEA4FF8, _822771CC89834C50][_9150E4B3D7C74532] == null || (Object)(object)LevelObjects.objects[E9AAD4DFDDEA4FF8, _822771CC89834C50][_9150E4B3D7C74532].transform == (Object)null)
		{
			return true;
		}
		Vector3 val = LevelObjects.objects[E9AAD4DFDDEA4FF8, _822771CC89834C50][_9150E4B3D7C74532].transform.position - ((Component)player).transform.position;
		if (val.sqrMagnitude > 400f)
		{
			return true;
		}
		InteractableObject interactable = LevelObjects.objects[E9AAD4DFDDEA4FF8, _822771CC89834C50][_9150E4B3D7C74532].interactable;
		InteractableObjectDropper val2 = (InteractableObjectDropper)(object)((interactable is InteractableObjectDropper) ? interactable : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return true;
		}
		bool _3C652579CDF = true;
		_3F20AA5736F344FD?.Invoke(player, in ACDCDFCC3A52443B, (InteractableObject)(object)val2, ref _3C652579CDF);
		return _3C652579CDF;
	}

	[_542A381FC1D44BA3(typeof(ObjectManager_NetMethods), "ReceiveToggleObjectBinaryStateRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool _15BEC37445F4470D(in ServerInvocationContext context)
	{
		NetPakReader reader = context.reader;
		byte b = default;
		SystemNetPakReaderEx.ReadUInt8(reader, ref b);
		byte b2 = default;
		SystemNetPakReaderEx.ReadUInt8(reader, ref b2);
		ushort num = default;
		SystemNetPakReaderEx.ReadUInt16(reader, ref num);
		bool flag = default;
		reader.ReadBit(ref flag);
		if (_16D6D81479B44451(in context, b, b2, num))
		{
			ObjectManager.ReceiveToggleObjectBinaryStateRequest(ref context, b, b2, num, flag);
		}
		return false;
	}

	private static bool _16D6D81479B44451(in ServerInvocationContext _1C5DFC0FBA0144A6, byte _201073D53EFD414D, byte _9209183744FF4D64, ushort _8B01BC4F49314098)
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		if (!Regions.checkSafe((int)_201073D53EFD414D, (int)_9209183744FF4D64))
		{
			return true;
		}
		Player player = _1C5DFC0FBA0144A6.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		if (_8B01BC4F49314098 >= LevelObjects.objects[_201073D53EFD414D, _9209183744FF4D64].Count)
		{
			return true;
		}
		if (LevelObjects.objects[_201073D53EFD414D, _9209183744FF4D64][_8B01BC4F49314098] == null || (Object)(object)LevelObjects.objects[_201073D53EFD414D, _9209183744FF4D64][_8B01BC4F49314098].transform == (Object)null)
		{
			return true;
		}
		Vector3 val = LevelObjects.objects[_201073D53EFD414D, _9209183744FF4D64][_8B01BC4F49314098].transform.position - ((Component)player).transform.position;
		if (val.sqrMagnitude > 400f)
		{
			return true;
		}
		InteractableObject interactable = LevelObjects.objects[_201073D53EFD414D, _9209183744FF4D64][_8B01BC4F49314098].interactable;
		InteractableObjectBinaryState val2 = (InteractableObjectBinaryState)(object)((interactable is InteractableObjectBinaryState) ? interactable : null);
		if ((Object)(object)val2 == (Object)null)
		{
			return true;
		}
		bool _3C652579CDF = true;
		_3F20AA5736F344FD?.Invoke(player, in _1C5DFC0FBA0144A6, (InteractableObject)(object)val2, ref _3C652579CDF);
		return _3C652579CDF;
	}
}
