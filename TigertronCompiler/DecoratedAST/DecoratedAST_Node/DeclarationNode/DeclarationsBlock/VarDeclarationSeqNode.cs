using Antlr.Runtime;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class VarDeclarationSeqNode : DeclarationSeqNode
    {
        #region	BuilderMethod

        public VarDeclarationSeqNode(IToken payload)
            : base(payload)
        {

        }

        #endregion
    }
}
