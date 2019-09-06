using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.DecoratedAST_Node;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler
{
    public abstract class EqualityOperation : BinaryOperationNode
    {
        #region	Builder Method

        protected EqualityOperation(IToken payload)
            : base(payload)
        {
        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (base.CheckSemantic(errors,symbolTable))
            {
                //ILType Checking
                if (!(LeftOperand.ReturnType is NilType && RightOperand.ReturnType is NilType))
                {
                    Scope = symbolTable.TopScope.Clone();
                    ReturnType = TypeExpression.IntType;
                    return true;
                }
                string message = "Nil must be used in a context were its actual type can be determined";
                errors.Add(new Error(message,Line,CharPositionInLine));
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            LeftOperand.GenCode(cg);
            RightOperand.GenCode(cg);
            if (LeftOperand.ReturnType.PrimitiveType is StringType)
            {
                MethodInfo method = typeof(string).GetMethod("Compare", new Type[] { typeof(string), typeof(string) });
                cg.GetGenerator.Emit(OpCodes.Call, method);
                cg.GetGenerator.Emit(OpCodes.Ldc_I4_0);
            }
            cg.GetGenerator.Emit(OpCodes.Ceq);
        }

        #endregion
    }
}
