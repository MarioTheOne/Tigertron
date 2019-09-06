using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class LessThanOperationNode : RelationalOperationNode
    {
        #region	Builder Methods

        public LessThanOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            base.GenCode(cg);
            cg.GetGenerator.Emit(OpCodes.Clt);
        }

        #endregion
    }
}
