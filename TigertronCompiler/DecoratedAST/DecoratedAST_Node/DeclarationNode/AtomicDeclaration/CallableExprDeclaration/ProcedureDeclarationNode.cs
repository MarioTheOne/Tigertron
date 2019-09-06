using Antlr.Runtime;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class ProcedureDeclarationNode : CallableExprDeclarationNode
    {
        #region	Builder Methods

        public ProcedureDeclarationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion
    }
}
