internal class _8 : global::_X<_9, _7>
{
	public unsafe _8(byte* data, ulong offset, ulong count)
		: base(data, offset, count)
	{
	}

	protected unsafe override _7 Construct(void* ptr)
	{
		return new _7(_memory, (_9*)ptr);
	}
}
