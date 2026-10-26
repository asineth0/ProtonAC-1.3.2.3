using System.Runtime.InteropServices;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
internal unsafe delegate void* CustomGetProcAddressFunc(void* customModule, char* name, void* ptr);
