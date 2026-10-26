using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace GlibcInterop;

internal class RtldGlobal
{
	private static class Dl
	{
		[DllImport("dl")]
		public static extern IntPtr dlopen([MarshalAs(UnmanagedType.LPStr)] string name, int mode = 1);

		[DllImport("dl")]
		public static extern IntPtr dlsym(IntPtr handle, [MarshalAs(UnmanagedType.LPStr)] string name);
	}

	private static readonly ulong _dl_tls_dtv_gaps_offset;

	private static readonly ulong _dl_tls_max_dtv_idx_offset;

	private static readonly ulong _dl_tls_static_size_offset;

	private static readonly ulong _dl_tls_static_align_offset;

	private static readonly ulong _dl_tls_generation_offset;

	private static readonly ulong _dl_tls_dtv_slotinfo_list_offset;

	private static readonly ulong _dl_tls_static_nelem_offset;

	private unsafe byte* _memory;

	public static readonly RtldGlobal Instance;

	public unsafe ulong TlsStaticElementCount
	{
		get
		{
			return (ulong)(*(UIntPtr*)(_memory + _dl_tls_static_nelem_offset));
		}
		set
		{
			*(UIntPtr*)(_memory + _dl_tls_static_nelem_offset) = (UIntPtr)value;
		}
	}

	public unsafe bool TlsDtvHasGaps
	{
		get
		{
			return Convert.ToBoolean(_memory[_dl_tls_dtv_gaps_offset]);
		}
		set
		{
			_memory[_dl_tls_dtv_gaps_offset] = Convert.ToByte(value);
		}
	}

	public unsafe ulong TlsDtvMaxIndex
	{
		get
		{
			return (ulong)(*(UIntPtr*)(_memory + _dl_tls_max_dtv_idx_offset));
		}
		set
		{
			*(UIntPtr*)(_memory + _dl_tls_max_dtv_idx_offset) = (UIntPtr)value;
		}
	}

	public unsafe ulong TlsStaticSize
	{
		get
		{
			return (ulong)(*(UIntPtr*)(_memory + _dl_tls_static_size_offset));
		}
		set
		{
			*(UIntPtr*)(_memory + _dl_tls_static_size_offset) = (UIntPtr)value;
		}
	}

	public unsafe ulong TlsStaticAlign
	{
		get
		{
			return (ulong)(*(UIntPtr*)(_memory + _dl_tls_static_align_offset));
		}
		set
		{
			*(UIntPtr*)(_memory + _dl_tls_static_align_offset) = (UIntPtr)value;
		}
	}

	public unsafe ulong TlsGeneration
	{
		get
		{
			return (ulong)(*(UIntPtr*)(_memory + _dl_tls_generation_offset));
		}
		set
		{
			*(UIntPtr*)(_memory + _dl_tls_generation_offset) = (UIntPtr)value;
		}
	}

	public unsafe DtvSlotInfoList TlsDtvSlotInfoList => new DtvSlotInfoList(*(DtvSlotInfoListNative**)(_memory + _dl_tls_dtv_slotinfo_list_offset));

	static RtldGlobal()
	{
		Version version = GlibcEnvironment.Version;
		string text = (Environment.Is64BitProcess ? "64" : "32");
		Type type = Assembly.GetExecutingAssembly().GetType("GlibcInterop.rtld_global_" + version.ToString().Replace('.', '_') + "_" + text);
		FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
		foreach (FieldInfo fieldInfo in fields)
		{
			FieldInfo field = typeof(RtldGlobal).GetField(fieldInfo.Name + "_offset", BindingFlags.Static | BindingFlags.NonPublic);
			if (field != null)
			{
				field.SetValue(null, (ulong)(long)Marshal.OffsetOf(type, fieldInfo.Name));
			}
		}
		Instance = GetInstance();
	}

	private unsafe RtldGlobal(byte* memory)
	{
		_memory = memory;
		try
		{
			_dl_get_tls_static_info(out var size, out var align);
			if ((ulong)size != TlsStaticSize || (ulong)align != TlsStaticAlign)
			{
				Console.WriteLine("rtld_global data seems to be corrupted.\nPlease open an issue at github.com/trungnt2910/MemoryModule.NET");
			}
		}
		catch (Exception arg)
		{
			Console.WriteLine($"Failed to verify rtld_global: {arg}\n" + "Please open an issue at github.com/trungnt2910/MemoryModule.NET");
		}
	}

	private unsafe static RtldGlobal GetInstance()
	{
		IntPtr intPtr;
		try
		{
			intPtr = dlsym(dlopen("libc.so"), "_rtld_global");
		}
		catch (EntryPointNotFoundException)
		{
			intPtr = Dl.dlsym(Dl.dlopen("libdl.so"), "_rtld_global");
		}
		return new RtldGlobal((byte*)(void*)intPtr);
	}

	[DllImport("libc")]
	private static extern IntPtr dlopen([MarshalAs(UnmanagedType.LPStr)] string name, int mode = 1);

	[DllImport("libc")]
	private static extern IntPtr dlsym(IntPtr handle, [MarshalAs(UnmanagedType.LPStr)] string name);

	[DllImport("libc")]
	private static extern void _dl_get_tls_static_info(out UIntPtr size, out UIntPtr align);
}
