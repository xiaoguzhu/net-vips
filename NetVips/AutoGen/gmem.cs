// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace NetVips.AutoGen
{
    public unsafe partial class gmem
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libglib-2.0-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="g_free")]
            internal static extern void GFree(global::System.IntPtr mem);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libglib-2.0-0.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="g_malloc")]
            internal static extern global::System.IntPtr GMalloc(ulong n_bytes);
        }

        public static void GFree(global::System.IntPtr mem)
        {
            __Internal.GFree(mem);
        }

        public static global::System.IntPtr GMalloc(ulong n_bytes)
        {
            var __ret = __Internal.GMalloc(n_bytes);
            return __ret;
        }

        public static int GMemGcFriendly
        {
            get
            {
                var __ptr = (int*)CppSharp.SymbolResolver.ResolveSymbol("libvips", "g_mem_gc_friendly");
                return *__ptr;
            }

            set
            {
                var __ptr = (int*)CppSharp.SymbolResolver.ResolveSymbol("libvips", "g_mem_gc_friendly");
                *__ptr = value;
            }
        }
    }
}
