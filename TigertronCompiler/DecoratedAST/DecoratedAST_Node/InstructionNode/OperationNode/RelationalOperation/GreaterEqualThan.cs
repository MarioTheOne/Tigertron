using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class GreaterEqualThanOperationNode : RelationalOperationNode
    {
        #region	Builder Methods

        public GreaterEqualThanOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            base.GenCode(cg);
            gen.Emit(OpCodes.Clt);
            gen.Emit(OpCodes.Ldc_I4_0);
            gen.Emit(OpCodes.Ceq);
        }

        #endregion
    }
}
