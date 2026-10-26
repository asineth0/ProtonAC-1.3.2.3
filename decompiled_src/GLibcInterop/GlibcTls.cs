using System;
using System.Linq;

namespace GlibcInterop;

internal static class GlibcTls
{
	private static readonly RtldGlobal _global;

	public unsafe static ulong GetNextModuleId()
	{
		if (!_global.TlsDtvHasGaps)
		{
			return ++_global.TlsDtvMaxIndex;
		}
		ulong num = _global.TlsStaticElementCount + 1;
		ulong num2 = 0uL;
		foreach (DtvSlotInfoArray tlsDtvSlotInfo in _global.TlsDtvSlotInfoList)
		{
			ulong num3 = num - num2;
			while (true)
			{
				if (num3 < tlsDtvSlotInfo.Count)
				{
					if (tlsDtvSlotInfo[num3].LinkMapPtr == null)
					{
						goto end_IL_008a;
					}
					num3++;
					num++;
					continue;
				}
				num2 += tlsDtvSlotInfo.Count;
				break;
			}
			continue;
			end_IL_008a:
			break;
		}
		if (num == _global.TlsDtvMaxIndex + 1)
		{
			_global.TlsDtvHasGaps = false;
			RtldGlobal global = _global;
			ulong tlsDtvMaxIndex = global.TlsDtvMaxIndex + 1;
			global.TlsDtvMaxIndex = tlsDtvMaxIndex;
		}
		return num;
	}

	public unsafe static void AddToSlotInfo(LinkMap l)
	{
		ulong tlsModuleId = l.TlsModuleId;
		DtvSlotInfo dtvSlotInfo = _global.TlsDtvSlotInfoList.FindElement(tlsModuleId);
		dtvSlotInfo.LinkMapPtr = l.GetNativePointer();
		dtvSlotInfo.Generation = ++_global.TlsGeneration;
	}

	public unsafe static void RemoveFromSlotInfo(LinkMap l)
	{
		RemoveFromSlotInfoInternal(l, (DtvSlotInfoListNative*)(void*)_global.TlsDtvSlotInfoList.Head, 0uL);
	}

	private unsafe static bool RemoveFromSlotInfoInternal(LinkMap l, DtvSlotInfoListNative* head, ulong basePos)
	{
		DtvSlotInfoArray dtvSlotInfoArray = new DtvSlotInfoList(head).First();
		ulong num;
		if (l.TlsModuleId >= basePos + (ulong)head->len)
		{
			if (head->next == null)
			{
				throw new InvalidOperationException("Invalid link map index.");
			}
			if (RemoveFromSlotInfoInternal(l, head->next, basePos + (ulong)head->len))
			{
				return true;
			}
			if ((ulong)head->len == 0L)
			{
				return false;
			}
			num = (ulong)head->len - 1;
		}
		else
		{
			DtvSlotInfo dtvSlotInfo = dtvSlotInfoArray[l.TlsModuleId - basePos];
			dtvSlotInfo.Generation = ++_global.TlsGeneration;
			dtvSlotInfo.LinkMapPtr = null;
			if (l.TlsModuleId != _global.TlsDtvMaxIndex)
			{
				return true;
			}
			num = l.TlsModuleId - 1;
		}
		ulong num2 = ((basePos == 0L) ? (_global.TlsStaticElementCount + 1) : 0);
		do
		{
			if (dtvSlotInfoArray[num].LinkMapPtr != null)
			{
				_global.TlsDtvMaxIndex = basePos + num;
				return true;
			}
			num--;
		}
		while (num != num2);
		return false;
	}

	static GlibcTls()
	{
		_global = RtldGlobal.Instance;
	}
}
