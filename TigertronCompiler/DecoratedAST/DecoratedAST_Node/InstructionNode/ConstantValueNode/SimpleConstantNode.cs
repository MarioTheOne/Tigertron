using Antlr.Runtime;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class SimpleConstantNode : ConstantValueNode
    {
        #region	Builder Methods

        protected SimpleConstantNode(IToken payload)
            : base(payload)
        {

        }

        #endregion
    }
}
