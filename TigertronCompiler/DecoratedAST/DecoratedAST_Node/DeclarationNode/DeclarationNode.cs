using System.Collections.Generic;
using Antlr.Runtime;
using TigertronCompiler.ErrorHandling;
using TigertronCompiler.SymbolTableManagement.SymbolStore;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class DeclarationNode : ExpressionNode
    {
        #region	Builder Methods

        protected DeclarationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public abstract bool CheckHeaderSemantic(List<Error> errors, SymbolTable symbolTable);

        #endregion
    }
}
