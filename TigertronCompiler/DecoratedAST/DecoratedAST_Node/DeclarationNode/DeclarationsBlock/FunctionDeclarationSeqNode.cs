using Antlr.Runtime;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class FunctionDeclarationSeqNode : RecursiveDeclarationSeqNode
    {
        #region	BuilderMethod

        public FunctionDeclarationSeqNode(IToken payload)
            : base(payload)
        {

        }

        #endregion
    }
}
