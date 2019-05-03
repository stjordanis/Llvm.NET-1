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
    [StructLayout( LayoutKind.Sequential )]
    [GeneratedCode( "LlvmBindingsGenerator", "2.17941.31104.49410" )]
    public struct LLVMVersionInfo
    {
        public int Major;
        public int Minor;
        public int Patch;
    }

    public static partial class NativeMethods
    {
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMGetVersionInfo( out LLVMVersionInfo pVersionInfo );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMMetadataRef LLVMConstantAsMetadata( LLVMValueRef Val );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMMetadataRef LLVMMDString2( LLVMContextRef C, [MarshalAs( UnmanagedType.LPStr )]string Str, uint SLen );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMMetadataRef LLVMMDNode2( LLVMContextRef C, out LLVMMetadataRef MDs, uint Count );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        [return: MarshalAs( UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof( AliasStringMarshaler ) )]
        public static extern string LLVMGetMDStringText( LLVMMetadataRef mdstring, out uint len );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMAddNamedMetadataOperand2( LLVMModuleRef M, [MarshalAs( UnmanagedType.LPStr )]string name, LLVMMetadataRef Val );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetMetadata2( LLVMValueRef Inst, uint KindID, LLVMMetadataRef MD );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern void LLVMSetCurrentDebugLocation2( LLVMBuilderRef Bref, uint Line, uint Col, LLVMMetadataRef Scope, LLVMMetadataRef InlinedAt );

        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIsTemporary( LLVMMetadataRef M );

        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIsResolved( LLVMMetadataRef M );

        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIsUniqued( LLVMMetadataRef M );

        [return: MarshalAs( UnmanagedType.Bool )]
        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern bool LLVMIsDistinct( LLVMMetadataRef M );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern LLVMMetadataRef LLVMDIGlobalVarExpGetVariable( LLVMMetadataRef metadataHandle );

        [SuppressUnmanagedCodeSecurity]
        [DllImport( LibraryPath, CallingConvention=global::System.Runtime.InteropServices.CallingConvention.Cdecl )]
        public static extern uint LLVMLookupInstrinsicId( [MarshalAs( UnmanagedType.LPStr )]string name );

    }
}
