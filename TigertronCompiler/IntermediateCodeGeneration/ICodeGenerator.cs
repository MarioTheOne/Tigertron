using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Emit;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.IntermediateCodeGeneration
{
    public interface ICodeGenerator
    {
        ILGenerator GetGenerator { get; }

        Stack<Label> LoopsEndLabels { get; set; }

        Type GetExpressionType(Scope scope, TypeExpression typeExpression);

        StandardLibrary GetStandardLibrary { get; set; }

        TypeBuilder TypeBuilder { get; set; }

        ModuleBuilder Module { get; set; }
    }
}
