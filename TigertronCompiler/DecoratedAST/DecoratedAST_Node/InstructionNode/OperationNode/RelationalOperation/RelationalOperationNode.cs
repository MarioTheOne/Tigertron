using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.IntermediateCodeGeneration;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class RelationalOperationNode : BinaryOperationNode
    {
        #region	Fields and Properties

        #endregion

        #region	Builder Methods

        protected RelationalOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (base.CheckSemantic(errors,symbolTable))
            {
                //case int:int
                //case string:string
                //case string:nil
                if (LeftOperand.ReturnType.PrimitiveType is BuiltInType || RightOperand.ReturnType.PrimitiveType is BuiltInType)
                {
                    Scope = symbolTable.TopScope.Clone();
                    ReturnType = TypeExpression.IntType;
                    return true;
                }
                string message = "Type of one or both operands must be int or string";
                errors.Add(new Error(message,Line,CharPositionInLine));
            }
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        public override void GenCode(ICodeGenerator cg)
        {
            LeftOperand.GenCode(cg);
            RightOperand.GenCode(cg);
        }

        #endregion
    }
}
