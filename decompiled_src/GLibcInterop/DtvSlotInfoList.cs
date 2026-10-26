using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace GlibcInterop;

internal class DtvSlotInfoList : IEnumerable<DtvSlotInfoArray>, IEnumerable
{
	private unsafe DtvSlotInfoListNative* _head;

	public unsafe IntPtr Head => (IntPtr)_head;

	public unsafe DtvSlotInfoList(DtvSlotInfoListNative* head)
	{
		_head = head;
	}

	public IEnumerator<DtvSlotInfoArray> GetEnumerator()
	{
		IntPtr current = Head;
		while (current != IntPtr.Zero)
		{
			yield return new DtvSlotInfoArray(current);
			current = GetNextNode(current);
		}
	}

	IEnumerator<DtvSlotInfoArray> IEnumerable<DtvSlotInfoArray>.GetEnumerator()
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetEnumerator
		return this.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public unsafe static IntPtr GetNextNode(IntPtr current)
	{
		DtvSlotInfoListNative* ptr = (DtvSlotInfoListNative*)(void*)current;
		return (IntPtr)ptr->next;
	}

	public unsafe DtvSlotInfo FindElement(ulong offset)
	{
		DtvSlotInfoListNative* ptr = _head;
		DtvSlotInfoListNative* ptr2 = _head;
		while (ptr != null)
		{
			DtvSlotInfoNative* ptr3 = (DtvSlotInfoNative*)(ptr + 1);
			if (offset >= (ulong)ptr->len)
			{
				offset -= (ulong)ptr->len;
				ptr2 = ptr;
				ptr = ptr->next;
				continue;
			}
			return new DtvSlotInfo(ptr3 + offset);
		}
		ulong num = Math.Max(offset, (ulong)ptr2->len);
		int num2 = sizeof(DtvSlotInfoListNative) + sizeof(DtvSlotInfoNative) * (int)num;
		ptr = (DtvSlotInfoListNative*)(void*)Marshal.AllocHGlobal(num2);
		Unsafe.InitBlockUnaligned(ptr, 0, (uint)num2);
		ptr->len = (UIntPtr)num;
		ptr->next = null;
		ptr2->next = ptr;
		DtvSlotInfoNative* ptr4 = (DtvSlotInfoNative*)(ptr + 1);
		return new DtvSlotInfo(ptr4 + offset);
	}
}
