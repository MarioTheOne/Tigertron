using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class UnaryOperationNode : OperationNode
    {
        #region	Fields and Properties

        private InstructionNode _operand;
        public InstructionNode Operand
        {
            get { return _operand ?? (_operand = GetChild(0) as InstructionNode); }
        }

        #endregion

        #region	Builder Methods

        protected UnaryOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (Operand.CheckSemantic(errors, symbolTable))
                return true;
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        #endregion
    }
}
