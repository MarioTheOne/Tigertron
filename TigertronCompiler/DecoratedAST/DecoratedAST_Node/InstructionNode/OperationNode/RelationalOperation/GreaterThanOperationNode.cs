using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class GreaterThanOperationNode : RelationalOperationNode
    {
        #region	Builder Methods

        public GreaterThanOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            base.GenCode(cg);
            cg.GetGenerator.Emit(OpCodes.Cgt);
        }

        #endregion
    }
}
