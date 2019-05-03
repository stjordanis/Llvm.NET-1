﻿// -----------------------------------------------------------------------
// <copyright file="PODToValueTypePass.cs" company=".NET Foundation">
// Copyright (c) .NET Foundation. All rights reserved.
// </copyright>
// -----------------------------------------------------------------------

using CppSharp.AST;
using CppSharp.Passes;

namespace LlvmBindingsGenerator.Passes
{
    internal class PODToValueTypePass
        : TranslationUnitPass
    {
        public override bool VisitASTContext( ASTContext context )
        {
            foreach( TranslationUnit unit in context.GeneratedUnits( ) )
            {
                VisitTranslationUnit( unit );
            }

            return true;
        }

        public override bool VisitClassDecl( Class @class )
        {
            if( base.VisitClassDecl( @class ) )
            {
                return false;
            }

            if( @class.IsPOD )
            {
                @class.Type = ClassType.ValueType;
            }

            return true;
        }
    }
}
