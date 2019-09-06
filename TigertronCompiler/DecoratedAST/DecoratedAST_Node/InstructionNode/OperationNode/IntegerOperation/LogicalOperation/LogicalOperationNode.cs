using Antlr.Runtime;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class LogicalOperationNode : IntegerOperation
    {
        #region	Fields and Properties

        #endregion

        #region	Builder Methods

        protected LogicalOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        #endregion
    }
}
