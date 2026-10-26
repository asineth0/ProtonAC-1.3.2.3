using System;

namespace GlibcInterop;

internal struct DtvSlotInfoListNative
{
	public UIntPtr len;

	public unsafe DtvSlotInfoListNative* next;
}
