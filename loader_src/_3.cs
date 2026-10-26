using System;
using System.Runtime.InteropServices;

internal class _3
{
	private unsafe byte* memory;

	private unsafe _5* obj;

	private string name;

	public readonly _v DynamicSectionItems;

	public unsafe ElfSectionHeaderType Type => obj->Type;

	public unsafe ulong Offset => (ulong)obj->Offset;

	public unsafe UIntPtr Pointer => (UIntPtr)obj;

	public unsafe ulong Size => (ulong)obj->Size;

	public unsafe ulong EntrySize => (ulong)obj->EntrySize;

	public unsafe _3(byte* memory, _5* obj, byte* namePtr = null)
	{
		this.memory = memory;
		this.obj = obj;
		if (namePtr != null)
		{
			name = Marshal.PtrToStringAnsi((IntPtr)namePtr);
		}
		if (obj->Type == ElfSectionHeaderType.Dynamic)
		{
			DynamicSectionItems = new _v(memory, (ulong)obj->Offset);
		}
	}

	public unsafe byte* GetData()
	{
		return memory + (ulong)obj->Offset;
	}

	public unsafe override string ToString()
	{
		return $"ELF Section Header at: 0x{(ulong)obj:x}, owned by 0x{(ulong)memory:x}\n- Type: {obj->Type}\n- Name: {name}\n- Info: {obj->Info}\n- Offset: 0x{(ulong)obj->Offset:x}\n- EntrySize: {obj->EntrySize}\n- Flags: {obj->Flags}\n- Alignment: {obj->Alignment}\n- Virtual Address: 0x{(ulong)obj->VirtualAddress:x}\n- Memory Size: {obj->Size}\n- Link: {obj->Link}\n";
	}
}
