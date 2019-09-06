using Antlr.Runtime;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class EqualOperationNode : EqualityOperation
    {
        #region	Builder Methods

        public EqualOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion
    }
}
