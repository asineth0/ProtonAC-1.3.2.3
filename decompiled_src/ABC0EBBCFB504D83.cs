using System;
using System.Runtime.InteropServices;

internal struct ABC0EBBCFB504D83
{
	[StructLayout(LayoutKind.Explicit)]
	public struct DummyUnion
	{
		[FieldOffset(0)]
		public UIntPtr Value;

		[FieldOffset(0)]
		public UIntPtr Ptr;
	}

	public UIntPtr Tag;

	public DummyUnion ValueOrPtr;
}
