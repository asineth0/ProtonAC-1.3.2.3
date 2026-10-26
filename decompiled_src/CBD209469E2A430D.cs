using System;
using System.Runtime.InteropServices;

internal class CBD209469E2A430D
{
	private unsafe byte* _memory;

	private unsafe byte* _start;

	public unsafe CBD209469E2A430D(byte* memory, ulong offset)
	{
		_memory = memory;
		_start = _memory + offset;
	}

	public unsafe string GetString(ulong offset)
	{
		return Marshal.PtrToStringAnsi((IntPtr)(_start + offset));
	}
}
