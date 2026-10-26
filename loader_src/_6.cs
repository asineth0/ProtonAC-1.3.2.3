using System;
using System.Runtime.InteropServices;

internal class _6
{
	private unsafe byte* _memory;

	private unsafe byte* _start;

	public unsafe _6(byte* memory, ulong offset)
	{
		_memory = memory;
		_start = _memory + offset;
	}

	public unsafe string GetString(ulong offset)
	{
		return Marshal.PtrToStringAnsi((IntPtr)(_start + offset));
	}
}
