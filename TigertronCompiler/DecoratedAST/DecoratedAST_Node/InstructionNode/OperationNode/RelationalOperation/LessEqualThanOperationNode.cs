using System.Reflection.Emit;
using Antlr.Runtime;
using TigertronCompiler.IntermediateCodeGeneration;

namespace TigertronCompiler.SemanticAnalysis.DecoratedAST_Node
{
    public class LessEqualThanOperationNode : RelationalOperationNode
    {
        #region	Builder Methods

        public LessEqualThanOperationNode(IToken payload)
            : base(payload)
        {

        }

        #endregion

        #region	Main Methods

        public override void GenCode(ICodeGenerator cg)
        {
            var gen = cg.GetGenerator;
            base.GenCode(cg);
            gen.Emit(OpCodes.Cgt);//Comparamos si es mayor, si no lo es entonces es menor o igual
            gen.Emit(OpCodes.Ldc_I4_0);
            gen.Emit(OpCodes.Ceq);
        }

        #endregion
    }
}
