using System;

namespace GlibcInterop;

internal class DtvSlotInfo
{
	private unsafe DtvSlotInfoNative* _obj;

	public unsafe ulong Generation
	{
		get
		{
			return (ulong)_obj->gen;
		}
		set
		{
			_obj->gen = (UIntPtr)value;
		}
	}

	public unsafe void* LinkMapPtr
	{
		get
		{
			return _obj->map;
		}
		set
		{
			_obj->map = value;
		}
	}

	public unsafe DtvSlotInfo(DtvSlotInfoNative* obj)
	{
		if (obj == null)
		{
			throw new ArgumentNullException("obj must not be null");
		}
		_obj = obj;
	}
}
