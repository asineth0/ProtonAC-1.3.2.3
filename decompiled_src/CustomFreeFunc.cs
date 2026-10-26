using System;
using System.Runtime.InteropServices;

[UnmanagedFunctionPointer(CallingConvention.Winapi)]
internal unsafe delegate bool CustomFreeFunc(void* ptr, UIntPtr size, MemoryAllocation a, void* ptr1);
