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
    public enum VipsBandFormat
    {
        VIPS_FORMAT_NOTSET = -1,
        VIPS_FORMAT_UCHAR = 0,
        VIPS_FORMAT_CHAR = 1,
        VIPS_FORMAT_USHORT = 2,
        VIPS_FORMAT_SHORT = 3,
        VIPS_FORMAT_UINT = 4,
        VIPS_FORMAT_INT = 5,
        VIPS_FORMAT_FLOAT = 6,
        VIPS_FORMAT_COMPLEX = 7,
        VIPS_FORMAT_DOUBLE = 8,
        VIPS_FORMAT_DPCOMPLEX = 9,
        VIPS_FORMAT_LAST = 10
    }

    public enum VipsCoding
    {
        VIPS_CODING_ERROR = -1,
        VIPS_CODING_NONE = 0,
        VIPS_CODING_LABQ = 2,
        VIPS_CODING_RAD = 6,
        VIPS_CODING_LAST = 7
    }

    public enum VipsInterpretation
    {
        VIPS_INTERPRETATION_ERROR = -1,
        VIPS_INTERPRETATION_MULTIBAND = 0,
        VIPS_INTERPRETATION_B_W = 1,
        VIPS_INTERPRETATION_HISTOGRAM = 10,
        VIPS_INTERPRETATION_XYZ = 12,
        VIPS_INTERPRETATION_LAB = 13,
        VIPS_INTERPRETATION_CMYK = 15,
        VIPS_INTERPRETATION_LABQ = 16,
        VIPS_INTERPRETATION_RGB = 17,
        VIPS_INTERPRETATION_CMC = 18,
        VIPS_INTERPRETATION_LCH = 19,
        VIPS_INTERPRETATION_LABS = 21,
        VIPS_INTERPRETATION_sRGB = 22,
        VIPS_INTERPRETATION_YXY = 23,
        VIPS_INTERPRETATION_FOURIER = 24,
        VIPS_INTERPRETATION_RGB16 = 25,
        VIPS_INTERPRETATION_GREY16 = 26,
        VIPS_INTERPRETATION_MATRIX = 27,
        VIPS_INTERPRETATION_scRGB = 28,
        VIPS_INTERPRETATION_HSV = 29,
        VIPS_INTERPRETATION_LAST = 30
    }

    public enum VipsImageType
    {
        VIPS_IMAGE_ERROR = -1,
        VIPS_IMAGE_NONE = 0,
        VIPS_IMAGE_SETBUF = 1,
        VIPS_IMAGE_SETBUF_FOREIGN = 2,
        VIPS_IMAGE_OPENIN = 3,
        VIPS_IMAGE_MMAPIN = 4,
        VIPS_IMAGE_MMAPINRW = 5,
        VIPS_IMAGE_OPENOUT = 6,
        VIPS_IMAGE_PARTIAL = 7
    }

    public enum VipsDemandStyle
    {
        VIPS_DEMAND_STYLE_ERROR = -1,
        VIPS_DEMAND_STYLE_SMALLTILE = 0,
        VIPS_DEMAND_STYLE_FATSTRIP = 1,
        VIPS_DEMAND_STYLE_THINSTRIP = 2,
        VIPS_DEMAND_STYLE_ANY = 3
    }

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate global::System.IntPtr VipsStartFn(global::System.IntPtr @out, global::System.IntPtr a, global::System.IntPtr b);

    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate int VipsStopFn(global::System.IntPtr seq, global::System.IntPtr a, global::System.IntPtr b);

    public unsafe partial class VipsImage : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 392)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::NetVips.AutoGen.VipsObject.__Internal parent_instance;

            [FieldOffset(80)]
            internal int Xsize;

            [FieldOffset(84)]
            internal int Ysize;

            [FieldOffset(88)]
            internal int Bands;

            [FieldOffset(92)]
            internal global::NetVips.AutoGen.VipsBandFormat BandFmt;

            [FieldOffset(96)]
            internal global::NetVips.AutoGen.VipsCoding Coding;

            [FieldOffset(100)]
            internal global::NetVips.AutoGen.VipsInterpretation Type;

            [FieldOffset(104)]
            internal double Xres;

            [FieldOffset(112)]
            internal double Yres;

            [FieldOffset(120)]
            internal int Xoffset;

            [FieldOffset(124)]
            internal int Yoffset;

            [FieldOffset(128)]
            internal int Length;

            [FieldOffset(132)]
            internal short Compression;

            [FieldOffset(134)]
            internal short Level;

            [FieldOffset(136)]
            internal int Bbits;

            [FieldOffset(144)]
            internal global::System.IntPtr time;

            [FieldOffset(152)]
            internal global::System.IntPtr Hist;

            [FieldOffset(160)]
            internal global::System.IntPtr filename;

            [FieldOffset(168)]
            internal global::System.IntPtr data;

            [FieldOffset(176)]
            internal int kill;

            [FieldOffset(180)]
            internal float Xres_float;

            [FieldOffset(184)]
            internal float Yres_float;

            [FieldOffset(192)]
            internal global::System.IntPtr mode;

            [FieldOffset(200)]
            internal global::NetVips.AutoGen.VipsImageType dtype;

            [FieldOffset(204)]
            internal int fd;

            [FieldOffset(208)]
            internal global::System.IntPtr baseaddr;

            [FieldOffset(216)]
            internal ulong length;

            [FieldOffset(224)]
            internal uint magic;

            [FieldOffset(232)]
            internal global::System.IntPtr start_fn;

            [FieldOffset(240)]
            internal global::System.IntPtr generate_fn;

            [FieldOffset(248)]
            internal global::System.IntPtr stop_fn;

            [FieldOffset(256)]
            internal global::System.IntPtr client1;

            [FieldOffset(264)]
            internal global::System.IntPtr client2;

            [FieldOffset(272)]
            internal global::System.IntPtr sslock;

            [FieldOffset(280)]
            internal global::System.IntPtr regions;

            [FieldOffset(288)]
            internal global::NetVips.AutoGen.VipsDemandStyle dhint;

            [FieldOffset(296)]
            internal global::System.IntPtr meta;

            [FieldOffset(304)]
            internal global::System.IntPtr meta_traverse;

            [FieldOffset(312)]
            internal long sizeof_header;

            [FieldOffset(320)]
            internal global::System.IntPtr windows;

            [FieldOffset(328)]
            internal global::System.IntPtr upstream;

            [FieldOffset(336)]
            internal global::System.IntPtr downstream;

            [FieldOffset(344)]
            internal int serial;

            [FieldOffset(352)]
            internal global::System.IntPtr history_list;

            [FieldOffset(360)]
            internal global::System.IntPtr progress_signal;

            [FieldOffset(368)]
            internal long file_length;

            [FieldOffset(376)]
            internal int hint_set;

            [FieldOffset(380)]
            internal int delete_on_close;

            [FieldOffset(384)]
            internal global::System.IntPtr delete_on_close_filename;
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NetVips.AutoGen.VipsImage> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::NetVips.AutoGen.VipsImage>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::NetVips.AutoGen.VipsImage __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::NetVips.AutoGen.VipsImage(native.ToPointer(), skipVTables);
        }

        internal static global::NetVips.AutoGen.VipsImage __CreateInstance(global::NetVips.AutoGen.VipsImage.__Internal native, bool skipVTables = false)
        {
            return new global::NetVips.AutoGen.VipsImage(native, skipVTables);
        }

        private static void* __CopyValue(global::NetVips.AutoGen.VipsImage.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::NetVips.AutoGen.VipsImage.__Internal));
            *(global::NetVips.AutoGen.VipsImage.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private VipsImage(global::NetVips.AutoGen.VipsImage.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected VipsImage(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        ~VipsImage()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::NetVips.AutoGen.VipsImage __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::NetVips.AutoGen.VipsObject ParentInstance
        {
            get
            {
                return global::NetVips.AutoGen.VipsObject.__CreateInstance(new global::System.IntPtr(&((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->parent_instance));
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->parent_instance = ReferenceEquals(value, null) ? new global::NetVips.AutoGen.VipsObject.__Internal() : *(global::NetVips.AutoGen.VipsObject.__Internal*) value.__Instance;
            }
        }

        public int Xsize
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Xsize;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Xsize = value;
            }
        }

        public int Ysize
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Ysize;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Ysize = value;
            }
        }

        public int Bands
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Bands;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Bands = value;
            }
        }

        public global::NetVips.AutoGen.VipsBandFormat BandFmt
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->BandFmt;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->BandFmt = value;
            }
        }

        public double Xres
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Xres;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Xres = value;
            }
        }

        public double Yres
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Yres;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Yres = value;
            }
        }

        public int Xoffset
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Xoffset;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Xoffset = value;
            }
        }

        public int Yoffset
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Yoffset;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Yoffset = value;
            }
        }

        public int Length
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Length;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Length = value;
            }
        }

        public short Compression
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Compression;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Compression = value;
            }
        }

        public short Level
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Level;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Level = value;
            }
        }

        public int Bbits
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Bbits;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Bbits = value;
            }
        }

        public char* Hist
        {
            get
            {
                return (char*) ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Hist;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Hist = (global::System.IntPtr) (sbyte*) value;
            }
        }

        public char* Filename
        {
            get
            {
                return (char*) ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->filename;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->filename = (global::System.IntPtr) (sbyte*) value;
            }
        }

        public byte* Data
        {
            get
            {
                return (byte*) ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->data;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->data = (global::System.IntPtr) value;
            }
        }

        public int Kill
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->kill;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->kill = value;
            }
        }

        public float XresFloat
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Xres_float;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Xres_float = value;
            }
        }

        public float YresFloat
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->Yres_float;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->Yres_float = value;
            }
        }

        public char* Mode
        {
            get
            {
                return (char*) ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->mode;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->mode = (global::System.IntPtr) (sbyte*) value;
            }
        }

        public int Fd
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->fd;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->fd = value;
            }
        }

        public global::System.IntPtr Baseaddr
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->baseaddr;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->baseaddr = (global::System.IntPtr) value;
            }
        }

        public ulong length
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->length;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->length = value;
            }
        }

        public uint Magic
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->magic;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->magic = value;
            }
        }

        public global::NetVips.AutoGen.VipsStartFn StartFn
        {
            get
            {
                var __ptr0 = ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->start_fn;
                return __ptr0 == IntPtr.Zero? null : (global::NetVips.AutoGen.VipsStartFn) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::NetVips.AutoGen.VipsStartFn));
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->start_fn = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }

        public global::NetVips.AutoGen.VipsStopFn StopFn
        {
            get
            {
                var __ptr0 = ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->stop_fn;
                return __ptr0 == IntPtr.Zero? null : (global::NetVips.AutoGen.VipsStopFn) Marshal.GetDelegateForFunctionPointer(__ptr0, typeof(global::NetVips.AutoGen.VipsStopFn));
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->stop_fn = value == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(value);
            }
        }

        public global::System.IntPtr Client1
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->client1;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->client1 = (global::System.IntPtr) value;
            }
        }

        public global::System.IntPtr Client2
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->client2;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->client2 = (global::System.IntPtr) value;
            }
        }

        public long SizeofHeader
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->sizeof_header;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->sizeof_header = value;
            }
        }

        public int Serial
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->serial;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->serial = value;
            }
        }

        public global::NetVips.AutoGen.VipsImage ProgressSignal
        {
            get
            {
                global::NetVips.AutoGen.VipsImage __result0;
                if (((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->progress_signal == IntPtr.Zero) __result0 = null;
                else if (global::NetVips.AutoGen.VipsImage.NativeToManagedMap.ContainsKey(((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->progress_signal))
                    __result0 = (global::NetVips.AutoGen.VipsImage) global::NetVips.AutoGen.VipsImage.NativeToManagedMap[((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->progress_signal];
                else __result0 = global::NetVips.AutoGen.VipsImage.__CreateInstance(((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->progress_signal);
                return __result0;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->progress_signal = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        public long FileLength
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->file_length;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->file_length = value;
            }
        }

        public int HintSet
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->hint_set;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->hint_set = value;
            }
        }

        public int DeleteOnClose
        {
            get
            {
                return ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->delete_on_close;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->delete_on_close = value;
            }
        }

        public char* DeleteOnCloseFilename
        {
            get
            {
                return (char*) ((global::NetVips.AutoGen.VipsImage.__Internal*) __Instance)->delete_on_close_filename;
            }

            set
            {
                ((global::NetVips.AutoGen.VipsImage.__Internal*)__Instance)->delete_on_close_filename = (global::System.IntPtr) (sbyte*) value;
            }
        }
    }

    public unsafe partial class image
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_filename_get_filename")]
            internal static extern sbyte* VipsFilenameGetFilename([MarshalAs(UnmanagedType.LPStr)] string vips_filename);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_filename_get_options")]
            internal static extern sbyte* VipsFilenameGetOptions([MarshalAs(UnmanagedType.LPStr)] string vips_filename);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_image_new_from_memory")]
            internal static extern global::System.IntPtr VipsImageNewFromMemory(global::System.IntPtr data, ulong size, int width, int height, int bands, global::NetVips.AutoGen.VipsBandFormat format);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_image_new_matrix_from_array")]
            internal static extern global::System.IntPtr VipsImageNewMatrixFromArray(int width, int height, double* array, int size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_image_new_temp_file")]
            internal static extern global::System.IntPtr VipsImageNewTempFile([MarshalAs(UnmanagedType.LPStr)] string format);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_image_write")]
            internal static extern int VipsImageWrite(global::System.IntPtr image, global::System.IntPtr @out);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_image_write_to_memory")]
            internal static extern global::System.IntPtr VipsImageWriteToMemory(global::System.IntPtr @in, ulong* size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_image_copy_memory")]
            internal static extern global::System.IntPtr VipsImageCopyMemory(global::System.IntPtr image);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_value_get_array_image")]
            internal static extern global::System.IntPtr VipsValueGetArrayImage(global::System.IntPtr value, int* n);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvips-42.dll", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="vips_value_set_array_image")]
            internal static extern void VipsValueSetArrayImage(global::System.IntPtr value, int n);
        }

        public static char* VipsFilenameGetFilename(string vips_filename)
        {
            var __ret = __Internal.VipsFilenameGetFilename(vips_filename);
            return (char*) __ret;
        }

        public static char* VipsFilenameGetOptions(string vips_filename)
        {
            var __ret = __Internal.VipsFilenameGetOptions(vips_filename);
            return (char*) __ret;
        }

        public static global::NetVips.AutoGen.VipsImage VipsImageNewFromMemory(global::System.IntPtr data, ulong size, int width, int height, int bands, global::NetVips.AutoGen.VipsBandFormat format)
        {
            var __ret = __Internal.VipsImageNewFromMemory(data, size, width, height, bands, format);
            global::NetVips.AutoGen.VipsImage __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::NetVips.AutoGen.VipsImage.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::NetVips.AutoGen.VipsImage) global::NetVips.AutoGen.VipsImage.NativeToManagedMap[__ret];
            else __result0 = global::NetVips.AutoGen.VipsImage.__CreateInstance(__ret);
            return __result0;
        }

        public static global::NetVips.AutoGen.VipsImage VipsImageNewMatrixFromArray(int width, int height, ref double array, int size)
        {
            fixed (double* __refParamPtr2 = &array)
            {
                var __arg2 = __refParamPtr2;
                var __ret = __Internal.VipsImageNewMatrixFromArray(width, height, __arg2, size);
                global::NetVips.AutoGen.VipsImage __result0;
                if (__ret == IntPtr.Zero) __result0 = null;
                else if (global::NetVips.AutoGen.VipsImage.NativeToManagedMap.ContainsKey(__ret))
                    __result0 = (global::NetVips.AutoGen.VipsImage) global::NetVips.AutoGen.VipsImage.NativeToManagedMap[__ret];
                else __result0 = global::NetVips.AutoGen.VipsImage.__CreateInstance(__ret);
                return __result0;
            }
        }

        public static global::NetVips.AutoGen.VipsImage VipsImageNewTempFile(string format)
        {
            var __ret = __Internal.VipsImageNewTempFile(format);
            global::NetVips.AutoGen.VipsImage __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::NetVips.AutoGen.VipsImage.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::NetVips.AutoGen.VipsImage) global::NetVips.AutoGen.VipsImage.NativeToManagedMap[__ret];
            else __result0 = global::NetVips.AutoGen.VipsImage.__CreateInstance(__ret);
            return __result0;
        }

        public static int VipsImageWrite(global::NetVips.AutoGen.VipsImage image, global::NetVips.AutoGen.VipsImage @out)
        {
            var __arg0 = ReferenceEquals(image, null) ? global::System.IntPtr.Zero : image.__Instance;
            var __arg1 = ReferenceEquals(@out, null) ? global::System.IntPtr.Zero : @out.__Instance;
            var __ret = __Internal.VipsImageWrite(__arg0, __arg1);
            return __ret;
        }

        public static global::System.IntPtr VipsImageWriteToMemory(global::NetVips.AutoGen.VipsImage @in, ref ulong size)
        {
            var __arg0 = ReferenceEquals(@in, null) ? global::System.IntPtr.Zero : @in.__Instance;
            fixed (ulong* __refParamPtr1 = &size)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.VipsImageWriteToMemory(__arg0, __arg1);
                return __ret;
            }
        }

        public static global::NetVips.AutoGen.VipsImage VipsImageCopyMemory(global::NetVips.AutoGen.VipsImage image)
        {
            var __arg0 = ReferenceEquals(image, null) ? global::System.IntPtr.Zero : image.__Instance;
            var __ret = __Internal.VipsImageCopyMemory(__arg0);
            global::NetVips.AutoGen.VipsImage __result0;
            if (__ret == IntPtr.Zero) __result0 = null;
            else if (global::NetVips.AutoGen.VipsImage.NativeToManagedMap.ContainsKey(__ret))
                __result0 = (global::NetVips.AutoGen.VipsImage) global::NetVips.AutoGen.VipsImage.NativeToManagedMap[__ret];
            else __result0 = global::NetVips.AutoGen.VipsImage.__CreateInstance(__ret);
            return __result0;
        }

        public static global::System.IntPtr VipsValueGetArrayImage(global::NetVips.AutoGen.GValue value, ref int n)
        {
            var __arg0 = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            fixed (int* __refParamPtr1 = &n)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.VipsValueGetArrayImage(__arg0, __arg1);
                return __ret;
            }
        }

        public static void VipsValueSetArrayImage(global::NetVips.AutoGen.GValue value, int n)
        {
            var __arg0 = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            __Internal.VipsValueSetArrayImage(__arg0, n);
        }
    }
}
