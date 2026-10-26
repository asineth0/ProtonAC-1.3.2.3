using System;

internal class _1E7BC0C438DF4CB6
{
	private unsafe byte* _memory;

	private unsafe ABC0EBBCFB504D83* _obj;

	public unsafe ElfDynamicSectionItemType Tag => (ElfDynamicSectionItemType)(uint)_obj->Tag;

	public unsafe UIntPtr Pointer => _obj->ValueOrPtr.Ptr;

	public unsafe ulong Value => (ulong)_obj->ValueOrPtr.Value;

	public unsafe _1E7BC0C438DF4CB6(byte* memory, ABC0EBBCFB504D83* ptr)
	{
		_memory = memory;
		_obj = ptr;
	}

	public override string ToString()
	{
		return $"ELF Dynamic Section:\n- Tag: {Tag}\n- Value/Pointer: 0x{Value:x}\n";
	}
}
