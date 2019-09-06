using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class IntegerOperation : BinaryOperationNode
    {
        #region	BuilderMethod

        protected IntegerOperation(IToken payload)
            : base(payload)
        {
        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (base.CheckSemantic(errors,symbolTable))
            {
                //Only check type of first operand because base verify that two operands have same type
                if ((LeftOperand.ReturnType.PrimitiveType is IntegerType))
                {
                    Scope = symbolTable.TopScope.Clone();
                    ReturnType = TypeExpression.IntType;
                    return true;
                }
                string message = string.Format("Cannot apply operator '{0}' to operands of type {1}, the expressions type must be int",
                                               Text, LeftOperand.ReturnType.PrimitiveType);
                errors.Add(new Error(message, Line, CharPositionInLine));
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        #endregion
    }
}
