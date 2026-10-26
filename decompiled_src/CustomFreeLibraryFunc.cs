using System.Runtime.InteropServices;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
internal unsafe delegate bool CustomFreeLibraryFunc(void* customModule, void* ptr);
