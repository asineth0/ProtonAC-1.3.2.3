using System;
using System.Runtime.InteropServices;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
internal unsafe delegate void* CustomAllocFunc(void* ptr, UIntPtr size, MemoryAllocation a, PageProtection b, void* ptr1);
