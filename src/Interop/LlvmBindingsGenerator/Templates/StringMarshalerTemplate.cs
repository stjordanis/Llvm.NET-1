﻿// -----------------------------------------------------------------------
// <copyright file="StringMarshalerTemplate.cs" company="Ubiquity.NET Contributors">
// Copyright (c) Ubiquity.NET Contributors. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace LlvmBindingsGenerator.Templates
{
    internal partial class StringMarshalerTemplate
        : ICodeGenTemplate
    {
        public StringMarshalerTemplate( string name, string disposeFunctionName)
        {
            Name = name;
            NativeDisposer = disposeFunctionName;
        }

        public bool HasNativeDisposer => !string.IsNullOrEmpty( NativeDisposer );

        public string Name { get; }

        public string NativeDisposer { get; }

        public Version ToolVersion => GetType( ).Assembly.GetName( ).Version;

        public string FileExtension => "g.cs";

        public string SubFolder => string.Empty;

        public string Generate( )
        {
            return TransformText( );
        }
    }
}