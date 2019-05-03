// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 2.17941.31104.49410
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security;

namespace Llvm.NET.Interop
{
    [UnmanagedFunctionPointer( global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
    public delegate void LLVMValueCacheItemDeletedCallback( LLVMValueRef @ref, System.IntPtr handle );

    [UnmanagedFunctionPointer( global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
    public delegate System.IntPtr LLVMValueCacheItemReplacedCallback( LLVMValueRef oldValue, System.IntPtr handle, LLVMValueRef newValue );

    public static partial class NativeMethods
    {
        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIsConstantZeroValue( LLVMValueRef valueRef );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMRemoveGlobalFromParent( LLVMValueRef valueRef );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern int LLVMGetValueID( LLVMValueRef valueRef );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMGetAliasee( LLVMValueRef Val );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern System.UInt32 LLVMGetArgumentIndex( LLVMValueRef Val );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMComdatRef LLVMGlobalObjectGetComdat( LLVMValueRef Val );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMGlobalObjectSetComdat( LLVMValueRef Val, LLVMComdatRef comdatRef );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMGlobalVariableAddDebugExpression( LLVMValueRef globalVar, LLVMMetadataRef exp );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMFunctionAppendBasicBlock( LLVMValueRef function, LLVMBasicBlockRef block );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueRef LLVMValueAsMetadataGetValue( LLVMMetadataRef vmd );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMValueCacheRef LLVMCreateValueCache( LLVMValueCacheItemDeletedCallback deletedCallback, LLVMValueCacheItemReplacedCallback replacedCallback );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMValueCacheAdd( LLVMValueCacheRef cacheRef, LLVMValueRef value, System.IntPtr handle );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern System.IntPtr LLVMValueCacheLookup( LLVMValueCacheRef cacheRef, LLVMValueRef valueRef );

    }
}
