using System;

internal class _v : global::_X<_w, _V>
{
	public unsafe _v(byte* data, ulong offset)
		: base(data, offset, 0uL)
	{
		ulong num;
		for (num = 0uL; ((_w*)_first)[num].Tag != (UIntPtr)0u; num++)
		{
		}
		num++;
		base.Count = num;
	}

	protected unsafe override _V Construct(void* ptr)
	{
		return new _V(_memory, (_w*)ptr);
	}
}
internal class _V
{
	private unsafe byte* _memory;

	private unsafe _w* _obj;

	public unsafe ElfDynamicSectionItemType Tag => (ElfDynamicSectionItemType)(uint)_obj->Tag;

	public unsafe UIntPtr Pointer => _obj->ValueOrPtr.Ptr;

	public unsafe ulong Value => (ulong)_obj->ValueOrPtr.Value;

	public unsafe _V(byte* memory, _w* ptr)
	{
		_memory = memory;
		_obj = ptr;
	}

	public override string ToString()
	{
		return $"ELF Dynamic Section:\n- Tag: {Tag}\n- Value/Pointer: 0x{Value:x}\n";
	}
}
