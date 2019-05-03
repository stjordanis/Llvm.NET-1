﻿// -----------------------------------------------------------------------
// <copyright file="StringDisposalMarshalerMap.cs" company=".NET Foundation">
// Copyright (c) .NET Foundation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System.Collections.Generic;

namespace LlvmBindingsGenerator.Templates
{
    internal static class StringDisposalMarshalerMap
    {
        public static (string Name, string NativeDisposer) LookupMarshaler( StringDisposal disposal )
        {
            return StringMarshalerMap[ disposal ];
        }

        private static readonly IReadOnlyDictionary<StringDisposal, (string Name, string NativeDisposer)> StringMarshalerMap
            = new Dictionary<StringDisposal, (string Name, string NativeDisposer)>
            {
                [ StringDisposal.CopyAlias ] = ("AliasStringMarshaler", string.Empty),
                [ StringDisposal.DisposeMessage ] = ("DisposeMessageMarshaler", "LLVMDisposeMessage"),
                [ StringDisposal.OrcDisposeMangledSymbol ] = ("OrcDisposeMangledSymbolMarshaler", "LLVMOrcDisposeMangledSymbol"),
                [ StringDisposal.DisposeErrorMesage ] = ("ErrorMessageMarshaler", "LLVMDisposeErrorMessage")
            };
    }
}
