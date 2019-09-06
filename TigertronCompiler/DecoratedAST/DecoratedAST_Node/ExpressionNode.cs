using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement;
using TigertronCompiler.SymbolTableManagement.SymbolNode;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class ExpressionNode : DecoratedASTNode
    {
        #region	BuilderMethod

        protected ExpressionNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public abstract bool CheckSemantic(List<Error> errors, SymbolTable symbolTable);

        public abstract void GenCode(ICodeGenerator cg);

        #endregion

        #region	Auxiliar Semantic

        protected bool CheckAssigment(InstructionNode value, TypeExpression type, List<Error> errors, string decoratedMessage = "")
        {
            if (value.ReturnType is NilType)
            {
                if (!type.IsNullable)
                {
                    string message = string.Format("The nil value cannot be assigned to {0} type", type);
                    errors.Add(new Error(message, value.Line, value.CharPositionInLine));
                    return false;
                }
                return true;
            }
            if (!value.ReturnType.PrimitiveType.IsEquivalent(type.PrimitiveType))
            {
                string message = string.Format("Cannot convert source type {0} to target type {1}. {2}", value.ReturnType, type,decoratedMessage);
                errors.Add(new Error(message, value.Line, value.CharPositionInLine));
                return false;
            }
            return true;
        }
       

        #endregion
    }
}
