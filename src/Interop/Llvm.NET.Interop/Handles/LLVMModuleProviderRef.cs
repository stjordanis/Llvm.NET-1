// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 2.17941.31104.49410
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.Runtime.InteropServices;
using System.Security;

namespace Llvm.NET.Interop
{
    [SecurityCritical]
    [GeneratedCode("LlvmBindingsGenerator","2.17941.31104.49410")]
    public class LLVMModuleProviderRef
        : LlvmObjectRef
    {
        public LLVMModuleProviderRef( IntPtr handle, bool owner )
            : base( owner )
        {
            SetHandle( handle );
        }

        public static LLVMModuleProviderRef Zero { get; } = new LLVMModuleProviderRef(IntPtr.Zero, false);

        [SecurityCritical]
        protected override bool ReleaseHandle( )
        {
            LLVMDisposeModuleProvider( handle );
            return true;
        }

        private LLVMModuleProviderRef( )
            : base( true )
        {
        }

        [DllImport( NativeMethods.LibraryPath, CallingConvention = CallingConvention.Cdecl )]
        private static extern void LLVMDisposeModuleProvider( IntPtr p );
    }
}
