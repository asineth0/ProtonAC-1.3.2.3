using System;
using System.Runtime.InteropServices;

namespace GlibcInterop;

internal static class GlibcEnvironment
{
	public static readonly Version Version;

	public static readonly Version FirstAvailableVersion;

	public static readonly Version LatestAvailableVersion;

	[DllImport("libc")]
	private static extern IntPtr gnu_get_libc_version();

	[DllImport("libc")]
	private static extern void _dl_get_tls_static_info(out UIntPtr size, out UIntPtr align);

	static GlibcEnvironment()
	{
		FirstAvailableVersion = new Version(2, 21);
		LatestAvailableVersion = new Version(2, 38);
		try
		{
			Version = Version.Parse(Marshal.PtrToStringAnsi(gnu_get_libc_version()));
			if (Version < FirstAvailableVersion)
			{
				string value = $"Your glibc version, {Version} is too old!\n" + "Please open an issue at github.com/trungnt2910/MemoryModule.NET to remove this message.";
				Version = FirstAvailableVersion;
				Console.WriteLine(value);
			}
			if (Version > LatestAvailableVersion)
			{
				Version = LatestAvailableVersion;
				Console.WriteLine("Are you using a beta glibc build?\nIf you're not, please update this package!\nIf this message continues to show up, please open an issue at github.com/trungnt2910/MemoryModule.NET to remove it.");
			}
		}
		catch (Exception arg)
		{
			string value2 = $"Error when trying to get glibc version: {arg}\n" + "Please open an issue at github.com/trungnt2910/MemoryModule.NET";
			Version = LatestAvailableVersion;
			Console.WriteLine(value2);
		}
	}
}
