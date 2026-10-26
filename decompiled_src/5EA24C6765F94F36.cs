using System.Collections.Generic;
using SDG.NetPak;
using SDG.Unturned;
using UnityEngine;

internal class _5EA24C6765F94F36
{
	public delegate void _0B7BC539A792436C(Player _8622B96FE76C4137, in ServerInvocationContext _68238AE8AD224051, ResourceSpawnpoint _4F01C8DAAFD24991, byte _03DE452A748D4C36, byte _1B466DC638464A12, ushort _79F7571B7AA64D68, ref bool B2C66C914AC04FA0);

	public static _0B7BC539A792436C? E88C46E8DB294BF9;

	[_542A381FC1D44BA3(typeof(ResourceManager_NetMethods), "ReceiveForageRequest_Read", _24AD03718EF64384._1B48C4AE307B46D9)]
	public static bool B97BB35555C340EB(in ServerInvocationContext context)
	{
		NetPakReader reader = context.reader;
		byte b = default;
		SystemNetPakReaderEx.ReadUInt8(reader, ref b);
		byte b2 = default;
		SystemNetPakReaderEx.ReadUInt8(reader, ref b2);
		ushort num = default;
		SystemNetPakReaderEx.ReadUInt16(reader, ref num);
		if (E8687456105742E5(in context, b, b2, num))
		{
			ResourceManager.ReceiveForageRequest(ref context, b, b2, num);
		}
		return false;
	}

	private static bool E8687456105742E5(in ServerInvocationContext _3251FC289D4346AC, byte _1163D74C297D4797, byte F484E1443031406B, ushort B5445826F0E84EBA)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		if (!Regions.checkSafe((int)_1163D74C297D4797, (int)F484E1443031406B))
		{
			return true;
		}
		Player player = _3251FC289D4346AC.GetPlayer();
		if ((Object)(object)player == (Object)null || player.life.isDead)
		{
			return true;
		}
		List<ResourceSpawnpoint> treesOrNullInRegion = LevelGround.GetTreesOrNullInRegion(_1163D74C297D4797, F484E1443031406B);
		if (treesOrNullInRegion == null || B5445826F0E84EBA >= treesOrNullInRegion.Count || treesOrNullInRegion[B5445826F0E84EBA].isDead)
		{
			return true;
		}
		Vector3 val = treesOrNullInRegion[B5445826F0E84EBA].point - ((Component)player).transform.position;
		if (val.sqrMagnitude > 400f)
		{
			return true;
		}
		ResourceAsset asset = treesOrNullInRegion[B5445826F0E84EBA].asset;
		if (asset == null || !asset.isForage)
		{
			return true;
		}
		bool B2C66C914AC04FA = true;
		E88C46E8DB294BF9?.Invoke(player, in _3251FC289D4346AC, treesOrNullInRegion[B5445826F0E84EBA], _1163D74C297D4797, F484E1443031406B, B5445826F0E84EBA, ref B2C66C914AC04FA);
		return B2C66C914AC04FA;
	}
}
