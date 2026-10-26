using System;

internal class _14805CC1C4804435 : global::ACC57CCEF3F344A1<ABC0EBBCFB504D83, _1E7BC0C438DF4CB6>
{
	public unsafe _14805CC1C4804435(byte* data, ulong offset)
		: base(data, offset, 0uL)
	{
		ulong num;
		for (num = 0uL; ((ABC0EBBCFB504D83*)_first)[num].Tag != (UIntPtr)0u; num++)
		{
		}
		num++;
		Count = num;
	}

	protected unsafe override _1E7BC0C438DF4CB6 Construct(void* ptr)
	{
		return new _1E7BC0C438DF4CB6(_memory, (ABC0EBBCFB504D83*)ptr);
	}
}
