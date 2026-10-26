using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace GlibcInterop;

internal class LinkMap : IDisposable
{
	private static readonly ulong l_tls_initimage_offset;

	private static readonly ulong l_tls_initimage_size_offset;

	private static readonly ulong l_tls_blocksize_offset;

	private static readonly ulong l_tls_align_offset;

	private static readonly ulong l_tls_modid_offset;

	private static readonly ulong l_name_offset;

	private static readonly Type _nativeType;

	private unsafe byte* _memory;

	private bool _disposedValue;

	private bool _initFromNative;

	public unsafe void* TlsInitialImage
	{
		get
		{
			return *(void**)(_memory + l_tls_initimage_offset);
		}
		set
		{
			*(void**)(_memory + l_tls_initimage_offset) = value;
		}
	}

	public unsafe ulong TlsInitImageSize
	{
		get
		{
			return (ulong)(*(UIntPtr*)(_memory + l_tls_initimage_size_offset));
		}
		set
		{
			*(UIntPtr*)(_memory + l_tls_initimage_size_offset) = (UIntPtr)value;
		}
	}

	public unsafe ulong TlsBlockSize
	{
		get
		{
			return (ulong)(*(UIntPtr*)(_memory + l_tls_blocksize_offset));
		}
		set
		{
			*(UIntPtr*)(_memory + l_tls_blocksize_offset) = (UIntPtr)value;
		}
	}

	public unsafe ulong TlsBlockAlignment
	{
		get
		{
			return (ulong)(*(UIntPtr*)(_memory + l_tls_align_offset));
		}
		set
		{
			*(UIntPtr*)(_memory + l_tls_align_offset) = (UIntPtr)value;
		}
	}

	public unsafe ulong TlsModuleId
	{
		get
		{
			return (ulong)(*(UIntPtr*)(_memory + l_tls_modid_offset));
		}
		set
		{
			*(UIntPtr*)(_memory + l_tls_modid_offset) = (UIntPtr)value;
		}
	}

	public unsafe string Name => Marshal.PtrToStringAnsi(*(IntPtr*)(_memory + l_name_offset));

	static LinkMap()
	{
		Version version = GlibcEnvironment.Version;
		string text = (Environment.Is64BitProcess ? "64" : "32");
		_nativeType = Assembly.GetExecutingAssembly().GetType("GlibcInterop.link_map_" + version.ToString().Replace('.', '_') + "_" + text);
		FieldInfo[] fields = _nativeType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			FieldInfo field = typeof(LinkMap).GetField(fieldInfo.Name + "_offset", BindingFlags.Static | BindingFlags.NonPublic);
			if (field != null)
			{
				field.SetValue(null, (ulong)(long)Marshal.OffsetOf(_nativeType, fieldInfo.Name));
			}
		}
	}

	public unsafe LinkMap()
	{
		_initFromNative = false;
		_memory = (byte*)(void*)Marshal.AllocHGlobal(Marshal.SizeOf(_nativeType));
	}

	public unsafe LinkMap(byte* memory)
	{
		_memory = memory;
		_initFromNative = true;
	}

	public unsafe void* GetNativePointer()
	{
		return _memory;
	}

	protected unsafe virtual void Dispose(bool disposing)
	{
		if (!_disposedValue)
		{
			if (!_initFromNative)
			{
				Marshal.FreeHGlobal((IntPtr)_memory);
			}
			_disposedValue = true;
		}
	}

	~LinkMap()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	void IDisposable.Dispose()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Dispose
		this.Dispose();
	}
}
