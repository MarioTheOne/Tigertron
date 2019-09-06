using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.IntermediateCodeGeneration
{
    class ILCodeGenerator : ICodeGenerator
    {

        public ILCodeGenerator(ModuleBuilder moduleBuilder, TypeBuilder typeBuilder, ILGenerator cg, StandardLibrary stdlib)
        {
            GetGenerator = cg;
            LoopsEndLabels = new Stack<Label>();
            GetStandardLibrary = stdlib;
            this.TypeBuilder = typeBuilder;
            this.Module = moduleBuilder;
        }

        public ILCodeGenerator(ICodeGenerator cg, ILGenerator gen)
        {
            GetGenerator = gen;
            LoopsEndLabels = cg.LoopsEndLabels;
            GetStandardLibrary = cg.GetStandardLibrary;
            this.TypeBuilder = cg.TypeBuilder;
            this.Module = cg.Module;
        }

        public ILGenerator GetGenerator { get; set; }

        public Stack<Label> LoopsEndLabels { get; set; }

        public Type GetExpressionType(Scope scope, TypeExpression typeExpression)
        {
            if (typeExpression.PrimitiveType is IntegerType) return typeof(int);

            if (typeExpression.PrimitiveType is StringType) return typeof(string);

            if (typeExpression.PrimitiveType is VoidType) return typeof(void);

            return scope.MappingDeclaration<TypeSymbol>(typeExpression.Identifier).ILType;
        }

        public StandardLibrary GetStandardLibrary { get; set; }

        public TypeBuilder TypeBuilder { get; set; }

        public ModuleBuilder Module { get; set; }
    }
}