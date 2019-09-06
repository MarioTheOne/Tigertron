using Antlr.Runtime;
using TigertronCompiler.SemanticAnalysis.TypeChecking;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class OperationNode : InstructionNode
    {
        #region	Properties

        public override TypeExpression ReturnType { get; set; }

        #endregion

        #region	Builder Methods

        protected OperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion
    }
}
