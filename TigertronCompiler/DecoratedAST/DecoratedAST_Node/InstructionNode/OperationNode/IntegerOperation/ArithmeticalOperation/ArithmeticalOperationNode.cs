using Antlr.Runtime;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public abstract class ArithmeticalOperationNode : IntegerOperation
    {
        #region	Fields and Properties

        #endregion

        #region	Builder Methods

        protected ArithmeticalOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        #endregion
    }
}
