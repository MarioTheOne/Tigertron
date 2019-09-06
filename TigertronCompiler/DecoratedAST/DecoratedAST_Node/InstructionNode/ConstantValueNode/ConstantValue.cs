using Antlr.Runtime;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class ConstantValueNode : InstructionNode
    {
        #region	Builder Methods

        protected ConstantValueNode(IToken payload)
            : base(payload)
        {

        }

        #endregion
    }
}
