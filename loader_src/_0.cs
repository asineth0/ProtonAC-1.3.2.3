internal class _0 : global::_X<_1, _Z>
{
	public unsafe _0(byte* data, ulong offset, ulong count)
		: base(data, offset, count)
	{
	}

	protected unsafe override _Z Construct(void* ptr)
	{
		return new _Z(_memory, (_1*)ptr);
	}
}
