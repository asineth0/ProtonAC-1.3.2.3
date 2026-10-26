using System;
using System.Runtime.CompilerServices;

internal struct _81DD83B8AA2247AA
{
	internal uint AC0A7CEDFFF44036;

	internal uint _2AFF121C01C1459F;

	internal uint FA7EF4447A474D70;

	internal uint _964259AAC7FB4290;

	internal unsafe _81DD83B8AA2247AA(uint seed)
	{
		//IL_0006: Expected Obj, but got Ref
		((ValueType)Unsafe.AsPointer(ref this))._002Ector();
		AC0A7CEDFFF44036 = seed * 557916961;
		_2AFF121C01C1459F = seed * 557916961 * 557916961;
		FA7EF4447A474D70 = seed * 557916961 * 557916961 * 557916961;
		_964259AAC7FB4290 = seed * 557916961 * 557916961 * 557916961 * 557916961;
	}

	internal uint _184044A093C04AF2(byte f, uint q)
	{
		AC0A7CEDFFF44036 = q;
		_2AFF121C01C1459F = q;
		FA7EF4447A474D70 = q;
		_964259AAC7FB4290 = q;
		AC0A7CEDFFF44036 ^= q;
		_2AFF121C01C1459F += q;
		FA7EF4447A474D70 ^= q;
		_964259AAC7FB4290 -= q;
		return _964259AAC7FB4290;
	}
}
