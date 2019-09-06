using Antlr.Runtime;
using TigertronCompiler.SemanticAnalysis.TypeChecking;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class InstructionNode : ExpressionNode
    {
        #region	Fields and Properties

        public abstract TypeExpression ReturnType { get; set; }

        #endregion

        #region	Builder Methods

        protected InstructionNode(IToken payload)
            : base(payload)
        {

        }

        #endregion
    }
}
