using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class DivOperationNode : ArithmeticalOperationNode
    {
        #region	Builder Methods

        public DivOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            LeftOperand.GenCode(cg);
            RightOperand.GenCode(cg);
            gen.Emit(OpCodes.Div);
        }

        #endregion
    }
}
