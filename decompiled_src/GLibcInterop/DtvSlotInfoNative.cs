using System;

namespace GlibcInterop;

internal struct DtvSlotInfoNative
{
	public UIntPtr gen;

	public unsafe void* map;
}
