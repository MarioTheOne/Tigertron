using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SemanticAnalysis.TypeChecking;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class AccessInstructionNode : InstructionNode
    {
        #region	Fields and Properties

        private InstructionNode _lValue;
        public InstructionNode LValue
        {
            get { return _lValue ?? (_lValue = (GetChild(1) as InstructionNode)); }
        }

        #endregion

        #region	Builder Methods

        protected AccessInstructionNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override bool CheckSemantic(List<Error> errors, SymbolTable symbolTable)
        {
            if (LValue.CheckSemantic(errors,symbolTable)) return true;
            ReturnType = TypeExpression.ErrorType;
            return false;
        }

        #endregion
    }
}
