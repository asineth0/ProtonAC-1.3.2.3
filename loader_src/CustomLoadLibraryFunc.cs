using System.Runtime.InteropServices;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
internal unsafe delegate void* CustomLoadLibraryFunc(char* str, void* ptr);
