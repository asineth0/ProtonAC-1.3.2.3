using System;

namespace GlibcInterop;

internal class DtvSlotInfoArray : ManagedArray<DtvSlotInfoNative, DtvSlotInfo>
{
	public unsafe DtvSlotInfoArray(byte* data, ulong count)
		: base(data, count)
	{
		Console.WriteLine("Constructed DtvSlotInfoArray");
		Console.WriteLine($"From: 0x{(ulong)data:x}");
		Console.WriteLine($"With count: {count}");
	}

	public unsafe DtvSlotInfoArray(IntPtr managedPtr)
		: this((byte*)(void*)managedPtr + sizeof(DtvSlotInfoListNative), (ulong)((DtvSlotInfoListNative*)(void*)managedPtr)->len)
	{
	}

	protected unsafe override DtvSlotInfo Construct(void* ptr)
	{
		return new DtvSlotInfo((DtvSlotInfoNative*)ptr);
	}
}
