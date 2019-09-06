using Antlr.Runtime;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class FlowControlNode : InstructionNode
    {
        #region	Builder Methods

        protected FlowControlNode(IToken payload)
            : base(payload)
        {

        }

        #endregion
    }
}
